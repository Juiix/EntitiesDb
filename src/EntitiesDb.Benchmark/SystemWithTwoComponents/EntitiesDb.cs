using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using EntitiesDb.Benchmark.Contexts.EntitiesDb_Components;
using System.Runtime.Intrinsics;

namespace EntitiesDb.Benchmark;

public partial class SystemWithTwoComponents
{
	private class EntitiesDbContext : EntitiesDbBaseContext
	{
		public Query Query;
		public Ids<Component1, Component2> Ids;

		public EntitiesDbContext(int entityCount) : base(6)
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
	//[Benchmark]
	public void EntitiesDb_Simd()
	{
		foreach (var (length, handleA, handleB) in _entitiesDb.Query.GetWriteHandles<Component1, Component2>())
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
		var sum = Vector256<int>.One;
		_entitiesDb.Query.ForEachChunkParallel(static (int length, Handle<Component1> handleA, Handle<Component2> handleB, ref Vector256<int> sum) =>
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
		}, ref sum);
	}

	[BenchmarkCategory(Categories.EntitiesDb)]
	//[Benchmark]
	public void EntitiesDb_ForEach()
	{
		_entitiesDb.Query.ForEach((Entity entity, ref Component1 a, in Component2 b) =>
		{
			a.Value += b.Value;
		});
	}
}