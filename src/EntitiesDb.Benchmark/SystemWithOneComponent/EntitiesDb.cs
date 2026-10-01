using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using EntitiesDb.Benchmark.Contexts.EntitiesDb_Components;
using System.Runtime.Intrinsics;

namespace EntitiesDb.Benchmark;

public partial class SystemWithOneComponent
{
	private class EntitiesDbContext : EntitiesDbBaseContext
	{
		public Query Query;

		public EntitiesDbContext(int entityCount) : base(ParallelThreads)
		{
			for (int i = 0; i < entityCount; i++)
			{
				Entities.Create(new Component1());
			}

			Query = Entities.QueryBuilder
				.WithAll<Component1>()
				.Build();
		}
	}

	[Context]
	private readonly EntitiesDbContext _entitiesDb;

	// Source-generated per-entity loop; like-for-like with the Structs/Classes baselines.
	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_ForEach()
	{
		_entitiesDb.Query.ForEach(static (ref Component1 a) =>
		{
			a.Value++;
		});
	}

	// Source-generated per-chunk loop over raw handles.
	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_ForEachChunk()
	{
		_entitiesDb.Query.ForEachChunk(static (int length, WriteHandle<Component1> handle) =>
		{
			for (int i = 0; i < length; i++)
			{
				handle[i].Value++;
			}
		});
	}

	// Manual chunk enumeration with hand-written SIMD (8 x int per Vector256).
	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_Enumeration_Simd()
	{
		Vector256<int> one = Vector256.Create(1);
		foreach (var (length, handle) in _entitiesDb.Query.WriteHandles<Component1>())
		{
			var alignedLength = length - (length & 7);
			var simdHandle = handle.Reinterpret<Component1, Vector256<int>>();
			var simdLength = alignedLength / 8;
			for (int i = 0; i < simdLength; i++)
			{
				simdHandle[i] += one;
			}

			for (int i = alignedLength; i < length; i++)
			{
				handle[i].Value++;
			}
		}
	}

	// Parallel per-entity loop (thread count = Environment.ProcessorCount).
	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_ForEachParallel()
	{
		_entitiesDb.Query.ForEachParallel(static (ref Component1 a) =>
		{
			a.Value++;
		});
	}

	// Parallel per-chunk loop (thread count = Environment.ProcessorCount).
	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_ForEachChunkParallel()
	{
		_entitiesDb.Query.ForEachChunkParallel(static (int length, WriteHandle<Component1> handle) =>
		{
			for (int i = 0; i < length; i++)
			{
				handle[i].Value++;
			}
		});
	}
}
