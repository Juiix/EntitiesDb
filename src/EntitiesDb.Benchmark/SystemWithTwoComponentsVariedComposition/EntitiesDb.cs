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
		public Ids<Component1, Component2> Ids;

		public EntitiesDbContext(int entityCount)
		{
			for (int i = 0; i < entityCount; i++)
			{
				_ = (i % 4) switch
				{
					3 => Entities.Create(new Component1(), new Component2()),
					2 => Entities.Create(new Component1(), new Component2(), new Component3()),
					1 => Entities.Create(new Component1(), new Component2(), new Component4()),
					_ => Entities.Create(new Component1(), new Component2(), new Component3(), new Component4()),
				};
			}

			Query = Entities.QueryBuilder
				.WithAll<Component1>()
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

	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_SourceGen()
	{
		_entitiesDb.Query.ForEach((Entity entity, ref Component1 a, in Component2 b) =>
		{
			a.Value += b.Value;
		});
	}
}