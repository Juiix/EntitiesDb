using System;

namespace EntitiesDb.Parallel;

[Collection("Sequential")]
public sealed class ChunkJobParallelTests
{
	private struct Payload
	{
		public long A, B;
	}

	private struct CountJob : IChunkJob
	{
		public int Count;
		public void ForEach(in Chunk chunk) => Count += chunk.EntityCount;
	}

	private struct CountAggregate : IParallelAggregate<CountJob>
	{
		public int Total;
		public CountJob Create(int threadIndex) => default;
		public void Join(int threadIndex, ref CountJob job) => Total += job.Count;
	}

	private struct PayloadB
	{
		public long A;
	}

	private struct PayloadC
	{
		public long A; public int B;
	}

	// Cross-archetype single fan-out: a query spanning many archetypes must
	// visit every chunk exactly once with ONE ExecuteJobs call (job count per
	// invocation bounded by ThreadCount), instead of one fork/join barrier per
	// archetype.
	[Fact]
	public void ChunkJobParallel_ManyArchetypes_CountsAllEntities_SingleFanOut()
	{
		var threadCount = Math.Max(2, Environment.ProcessorCount);
		using var runner = new ParallelJobRunner(threadCount, "TestRunner-CrossArchetype");
		using var db = new EntityDatabase(new EntityDatabaseOptions(1024, int.MaxValue, threadCount), runner);

		// three archetypes all matching WithAll<Payload>
		const int perArchetype = 500;
		for (int i = 0; i < perArchetype; i++)
		{
			db.Create(new Payload { A = i });
			db.Create(new Payload { A = i }, new PayloadB { A = i });
			db.Create(new Payload { A = i }, new PayloadC { A = i });
		}

		var query = db.QueryBuilder.WithAll<Payload>().Build();

		for (int run = 0; run < 3; run++)
		{
			var aggregate = new CountAggregate();
			query.ChunkJobParallel<CountJob, CountAggregate>(ref aggregate);
			Assert.Equal(perArchetype * 3, aggregate.Total);
		}
	}

	// Change-filtered queries also use the combined range list — chunks from
	// multiple archetypes with pending changes must all be visited once.
	[Fact]
	public void ChunkJobParallel_ManyArchetypes_WithChangeFilter_VisitsChangedChunks()
	{
		var threadCount = Math.Max(2, Environment.ProcessorCount);
		using var runner = new ParallelJobRunner(threadCount, "TestRunner-CrossArchetypeFilter");
		using var db = new EntityDatabase(new EntityDatabaseOptions(1024, int.MaxValue, threadCount), runner);

		// build first — the change filter's compare version is captured at Build
		var query = db.QueryBuilder.WithAll<Tracked>().WithChangeFilter<Tracked>().Build();

		const int perArchetype = 300;
		for (int i = 0; i < perArchetype; i++)
		{
			db.Create(new Tracked { Value = i });
			db.Create(new Tracked { Value = i }, new PayloadB { A = i });
		}

		// first pass sees everything as changed
		var aggregate = new CountAggregate();
		query.ChunkJobParallel<CountJob, CountAggregate>(ref aggregate);
		Assert.Equal(perArchetype * 2, aggregate.Total);

		// no writes since — nothing to visit
		aggregate = new CountAggregate();
		query.ChunkJobParallel<CountJob, CountAggregate>(ref aggregate);
		Assert.Equal(0, aggregate.Total);

		// touch one entity in each archetype — its chunk (only) re-appears
		var e1 = db.Create(new Tracked { Value = -1 });
		var e2 = db.Create(new Tracked { Value = -2 }, new PayloadB { A = -2 });
		aggregate = new CountAggregate();
		query.ChunkJobParallel<CountJob, CountAggregate>(ref aggregate);
		Assert.True(aggregate.Total > 0);
	}

	[TrackChanges]
	private struct Tracked
	{
		public int Value;
	}

	// Regression: JobMeta<T>.ArrayPool arrays are sized to Environment.ProcessorCount,
	// but ChunkJobParallel slices work into up to runner.ThreadCount jobs. On machines
	// with fewer cores than the configured thread count (e.g. a 2-vCPU host running
	// ThreadCount=4), jobs[] overflowed with IndexOutOfRangeException once an archetype
	// spanned more chunks than ProcessorCount.
	[Fact]
	public void ChunkJobParallel_ThreadCountAboveProcessorCount_CountsAllEntities()
	{
		var threadCount = Environment.ProcessorCount + 2;
		using var runner = new ParallelJobRunner(threadCount, "TestRunner-ChunkJobParallel");
		using var db = new EntityDatabase(new EntityDatabaseOptions(1024, int.MaxValue, threadCount), runner);

		// 16-byte payload in 1KB chunks -> ~64 entities per chunk -> far more chunks
		// than any realistic core count
		const int entityCount = 5000;
		for (int i = 0; i < entityCount; i++)
			db.Create(new Payload { A = i });

		var query = db.QueryBuilder.WithAll<Payload>().Build();

		// run repeatedly: the first call replaces an undersized pooled array with a
		// right-sized one, later calls rent the converged array back from the pool
		for (int run = 0; run < 3; run++)
		{
			var aggregate = new CountAggregate();
			query.ChunkJobParallel<CountJob, CountAggregate>(ref aggregate);
			Assert.Equal(entityCount, aggregate.Total);
		}
	}

	// Per-entity sum job: proves every chunk is visited exactly once (not just counted) under the
	// dynamic chunk-claiming scheduler, across many archetypes of very different sizes.
	private struct SumJob : IChunkJob
	{
		public long Sum;
		public void ForEach(in Chunk chunk)
		{
			var handle = chunk.ReadHandle<Payload>();
			for (int i = 0; i < chunk.EntityCount; i++)
				Sum += handle[i].A;
		}
	}

	private struct SumAggregate : IParallelAggregate<SumJob>
	{
		public long Total;
		public SumJob Create(int threadIndex) => default;
		public void Join(int threadIndex, ref SumJob job) => Total += job.Sum;
	}

	[Theory]
	[InlineData(1)]
	[InlineData(3)]
	[InlineData(0)] // 0 = runner thread count
	public void ChunkJobParallel_UnevenArchetypes_VisitsEveryChunkExactlyOnce(int maxThreads)
	{
		var threadCount = Math.Max(2, Environment.ProcessorCount);
		using var runner = new ParallelJobRunner(threadCount, "TestRunner-Uneven");
		using var db = new EntityDatabase(new EntityDatabaseOptions(1024, int.MaxValue, threadCount), runner);

		// one big archetype (many chunks), one medium, one with a single partially-filled chunk
		long expected = 0;
		int id = 1;
		for (int i = 0; i < 20_000; i++) { db.Create(new Payload { A = id }); expected += id++; }
		for (int i = 0; i < 700; i++) { db.Create(new Payload { A = id }, new PayloadB()); expected += id++; }
		for (int i = 0; i < 5; i++) { db.Create(new Payload { A = id }, new PayloadC()); expected += id++; }

		var query = db.QueryBuilder.WithAll<Payload>().Build();
		var options = maxThreads > 0 ? new EntitiesDb.ParallelOptions(maxThreads) : default;

		for (int run = 0; run < 5; run++)
		{
			var aggregate = new SumAggregate();
			query.ChunkJobParallel<SumJob, SumAggregate>(ref aggregate, options);
			Assert.Equal(expected, aggregate.Total);
		}
	}

	[Fact]
	public void ChunkJobParallel_SteadyState_DoesNotAllocate()
	{
		var threadCount = Math.Max(2, Environment.ProcessorCount);
		using var runner = new ParallelJobRunner(threadCount, "TestRunner-Alloc");
		using var db = new EntityDatabase(new EntityDatabaseOptions(1024, int.MaxValue, threadCount), runner);
		for (int i = 0; i < 10_000; i++)
			db.Create(new Payload { A = i });
		var query = db.QueryBuilder.WithAll<Payload>().Build();

		// warm up pools / lazily-created sync objects
		for (int run = 0; run < 10; run++)
		{
			var warm = new CountAggregate();
			query.ChunkJobParallel<CountJob, CountAggregate>(ref warm);
		}

		// measure the calling thread (where job/work pooling happens — the old ConcurrentStack pools
		// allocated ~300 B per call here); keep xunit's (allocating) asserts out of the loop
		long total = 0;
		var before = GC.GetAllocatedBytesForCurrentThread();
		for (int run = 0; run < 100; run++)
		{
			var aggregate = new CountAggregate();
			query.ChunkJobParallel<CountJob, CountAggregate>(ref aggregate);
			total += aggregate.Total;
		}
		var allocated = GC.GetAllocatedBytesForCurrentThread() - before;

		Assert.Equal(100L * 10_000, total);
		Assert.True(allocated == 0, $"parallel query allocated {allocated} bytes on the calling thread over 100 calls");
	}
}
