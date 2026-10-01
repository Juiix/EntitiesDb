using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using EntitiesDb.Benchmark.Contexts.EntitiesDb_Components;
using System.Runtime.Intrinsics;

namespace EntitiesDb.Benchmark;

public partial class SystemWithTwoComponentsVariedComposition
{
	private class EntitiesDbContext : EntitiesDbBaseContext
	{
		public Query Query;

		public EntitiesDbContext(int entityCount) : base(ParallelThreads)
		{
			// Entities spread across 4 archetypes that all contain Component1 + Component2.
			// Same seed values as the Structs/Classes baselines.
			for (int i = 0; i < entityCount; i++)
			{
				_ = (i % 4) switch
				{
					3 => Entities.Create(new Component1(), new Component2(1)),
					2 => Entities.Create(new Component1(), new Component2(1), new Component3()),
					1 => Entities.Create(new Component1(), new Component2(1), new Component4()),
					_ => Entities.Create(new Component1(), new Component2(1), new Component3(), new Component4()),
				};
			}

			Query = Entities.QueryBuilder
				.WithAll<Component1, Component2>()
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
		_entitiesDb.Query.ForEach(static (ref Component1 a, in Component2 b) =>
		{
			a.Value += b.Value;
		});
	}

	// Source-generated per-chunk loop over raw handles.
	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_ForEachChunk()
	{
		_entitiesDb.Query.ForEachChunk(static (int length, WriteHandle<Component1> handleA, ReadHandle<Component2> handleB) =>
		{
			for (int i = 0; i < length; i++)
			{
				handleA[i].Value += handleB[i].Value;
			}
		});
	}

	// Manual chunk enumeration with hand-written SIMD (8 x int per Vector256).
	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_Enumeration_Simd()
	{
		foreach (var (length, handleA, handleB) in _entitiesDb.Query.WriteHandles<Component1, Component2>())
		{
			var alignedLength = length - (length & 7);
			var simdHandleA = handleA.Reinterpret<Component1, Vector256<int>>();
			var simdHandleB = handleB.Reinterpret<Component2, Vector256<int>>();
			var simdLength = alignedLength / 8;
			for (int i = 0; i < simdLength; i++)
			{
				simdHandleA[i] += simdHandleB[i];
			}

			for (int i = alignedLength; i < length; i++)
			{
				handleA[i].Value += handleB[i].Value;
			}
		}
	}

	// Parallel per-entity loop (thread count = Environment.ProcessorCount).
	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_ForEachParallel()
	{
		_entitiesDb.Query.ForEachParallel(static (ref Component1 a, in Component2 b) =>
		{
			a.Value += b.Value;
		});
	}

	// Parallel per-chunk loop (thread count = Environment.ProcessorCount).
	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_ForEachChunkParallel()
	{
		_entitiesDb.Query.ForEachChunkParallel(static (int length, WriteHandle<Component1> handleA, ReadHandle<Component2> handleB) =>
		{
			for (int i = 0; i < length; i++)
			{
				handleA[i].Value += handleB[i].Value;
			}
		});
	}
}
