using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using EntitiesDb.Benchmark.Contexts.EntitiesDb_Components;
using System.Runtime.Intrinsics;

namespace EntitiesDb.Benchmark;

public partial class SystemWithVariedComposition
{
	private class EntitiesDbContext : EntitiesDbBaseContext
	{
		public Query Query;

		public EntitiesDbContext(int entityCount)
		{
			for (int i = 0; i < entityCount; i++)
			{
				Entities.Create(new Component1());
			}
			for (int i = 0; i < entityCount; i++)
			{
				Entities.Create(new Component1(), new Component2());
			}
			for (int i = 0; i < entityCount; i++)
			{
				Entities.Create(new Component1(), new Component2(), new Component3());
			}

			Query = Entities.QueryBuilder
				.WithAll<Component1>()
				.Build();
			Query.Match();
		}
	}

	[Context]
	private readonly EntitiesDbContext _entitiesDb;

	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb()
	{
		var id = _entitiesDb.Entities.ComponentRegistry.GetId<Component1>();
		foreach (ref readonly var chunk in _entitiesDb.Query)
		{
			var handle = chunk.GetHandle(id);
			foreach (var index in chunk)
			{
				handle[index].Value++;
			}
		}
	}

	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_Simd()
	{
		Vector256<int> sum = Vector256.Create(1);
		var id = _entitiesDb.Entities.ComponentRegistry.GetId<Component1>();
		foreach (ref readonly var chunk in _entitiesDb.Query)
		{
			var entityCount = chunk.EntityCount;
			var alignedLength = entityCount - (entityCount & 7);
			var handle = chunk.GetHandle(id);
			var simdHandle = handle.Reinterpret<Vector256<int>>();
			var simdLength = alignedLength / 8;
			for (int i = 0; i < simdLength; i++)
			{
				simdHandle[i] += sum;
			}

			for (int i = alignedLength; i < entityCount; i++)
			{
				handle[i].Value++;
			}
		}
	}
}