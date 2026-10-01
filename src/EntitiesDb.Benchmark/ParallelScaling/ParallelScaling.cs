using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts.EntitiesDb_Components;
using System.Runtime.Intrinsics;

namespace EntitiesDb.Benchmark;

/// <summary>
/// How parallel query execution scales with thread count and entity count, plus the fixed
/// fork/join cost of a parallel call (<see cref="Dispatch_OneEntity"/>).
/// Work is the same as <see cref="SystemWithTwoComponents"/>: c1.Value += c2.Value.
/// </summary>
[BenchmarkCategory(Categories.System, Categories.EntitiesDb)]
[MemoryDiagnoser]
[MedianColumn]
[MinIterationCount(25)]
[MaxIterationCount(60)]
public class ParallelScaling
{
	[Params(100_000, 1_000_000)]
	public int EntityCount { get; set; }

	// physical cores (ProcessorCount / 2 on SMT machines), all logical cores - 1, all logical cores
	[ParamsSource(nameof(ThreadCounts))]
	public int ThreadCount { get; set; }

	public static IEnumerable<int> ThreadCounts => new[]
	{
		Math.Max(1, Environment.ProcessorCount / 2),
		Math.Max(1, Environment.ProcessorCount - 1),
		Environment.ProcessorCount,
	}.Distinct();

	private EntityDatabase _db;
	private Query _query;
	private Query _oneEntityQuery;

	[GlobalSetup]
	public void Setup()
	{
		_db = new EntityDatabase(new EntityDatabaseOptions(parallelThreads: ThreadCount));
		_db.Reserve<Component1, Component2>(EntityCount);
		for (int i = 0; i < EntityCount; i++)
			_db.Create(new Component1(), new Component2(1));

		// a single entity in its own archetype: a parallel call over it is pure dispatch cost
		_db.Create(new Component3(1));

		_query = _db.QueryBuilder.WithAll<Component1, Component2>().Build();
		_oneEntityQuery = _db.QueryBuilder.WithAll<Component3>().Build();
	}

	[GlobalCleanup]
	public void Cleanup() => _db.Dispose();

	// ---- single-thread reference rows (ThreadCount has no effect) ----

	[Benchmark(Baseline = true)]
	public void ForEachChunk()
	{
		_query.ForEachChunk(static (int length, WriteHandle<Component1> a, ReadHandle<Component2> b) =>
		{
			for (int i = 0; i < length; i++)
				a[i].Value += b[i].Value;
		});
	}

	// ---- parallel rows ----

	[Benchmark]
	public void ForEachParallel()
	{
		_query.ForEachParallel(static (ref Component1 a, in Component2 b) =>
		{
			a.Value += b.Value;
		});
	}

	[Benchmark]
	public void ForEachChunkParallel()
	{
		_query.ForEachChunkParallel(static (int length, WriteHandle<Component1> a, ReadHandle<Component2> b) =>
		{
			for (int i = 0; i < length; i++)
				a[i].Value += b[i].Value;
		});
	}

	[Benchmark]
	public void ForEachChunkParallel_Simd()
	{
		_query.ForEachChunkParallel(static (int length, WriteHandle<Component1> a, ReadHandle<Component2> b) =>
		{
			var aligned = length - (length & 7);
			var va = a.Reinterpret<Component1, Vector256<int>>();
			var vb = b.Reinterpret<Component2, Vector256<int>>();
			var simdLength = aligned / 8;
			for (int i = 0; i < simdLength; i++)
				va[i] += vb[i];
			for (int i = aligned; i < length; i++)
				a[i].Value += b[i].Value;
		});
	}

	/// <summary>
	/// Fork/join floor: a parallel call over a query that matches exactly one entity.
	/// </summary>
	[Benchmark]
	public void Dispatch_OneEntity()
	{
		_oneEntityQuery.ForEachChunkParallel(static (int length, WriteHandle<Component3> c) =>
		{
			for (int i = 0; i < length; i++)
				c[i].Value++;
		});
	}
}
