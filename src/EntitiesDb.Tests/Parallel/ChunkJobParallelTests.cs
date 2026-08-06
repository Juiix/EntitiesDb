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
}
