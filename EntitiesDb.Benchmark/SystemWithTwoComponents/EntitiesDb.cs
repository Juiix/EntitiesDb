using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using EntitiesDb.Benchmark.Contexts.EntitiesDb_Components;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace EntitiesDb.Benchmark;

public partial class SystemWithTwoComponents
{
	private class EntitiesDbContext : EntitiesDbBaseContext
	{
		public Query Query;
		public Ids<Component1, Component2> Ids;

		public EntitiesDbContext(int entityCount) : base(3)
		{
			for (int i = 0; i < entityCount; i++)
			{
				Entities.Create(new Component1(), new Component2());
			}

			Query = Entities.QueryBuilder
				.WithAll<Component1, Component2>()
				.Build();
			Ids = Entities.ComponentRegistry.GetIds<Component1, Component2>();
		}
	}

	[Context]
	private readonly EntitiesDbContext _entitiesDb;

	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_Simd()
	{
		foreach (var (handleA, handleB, length) in _entitiesDb.Query.GetChunkIterator<Component1, Component2>())
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

	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_Parallel_Simd()
	{
		var add = new AddParallel(_entitiesDb.Ids);
		_entitiesDb.Query.InlineChunkParallel(in add);
	}

	private struct AddParallel(Ids<Component1, Component2> ids) : IForEachChunk
	{
		private readonly Ids<Component1, Component2> _ids = ids;
		private Offsets<Component1, Component2> _offsets;

		public void Enter(Archetype archetype)
		{
			_offsets = archetype.GetOffsets(in _ids);
		}

		public void ForEach(in Chunk chunk)
		{
			var length = chunk.EntityCount;
			var alignedLength = length - (length & 7);
			var handleA = chunk.GetHandle(_offsets.T0);
			var handleB = chunk.GetHandle(_offsets.T1);
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

	/*
	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_SourceGen()
	{
		_entitiesDb.Query.ForEach((Entity entity, ref Component1 a, in Component2 b) =>
		{
			a.Value += b.Value;
		});
	}

	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_Inline()
	{
		var add = new Add();
		_entitiesDb.Query.Inline<Add, Component1, Component2>(ref add);
	}
	*/

	private struct Add : IForEach<Component1, Component2>
	{
		public void ForEach(ref Component1 t0Component, ref Component2 t1Component)
		{
			t0Component.Value += t1Component.Value;
		}
	}
}