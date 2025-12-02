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
		public Id<Component1> Id;

		public EntitiesDbContext(int entityCount)
		{
			for (int i = 0; i < entityCount; i++)
			{
				Entities.Create(new Component1());
			}

			Query = Entities.QueryBuilder
				.WithAll<Component1>()
				.Build();
			Id = Entities.ComponentRegistry.GetId<Component1>();
		}
	}

	[Context]
	private readonly EntitiesDbContext _entitiesDb;

	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_Simd()
	{
		Vector256<int> sum = Vector256.Create(1);
		foreach (var (length, handle) in _entitiesDb.Query.WriteHandles<Component1>())
		{
			var alignedLength = length - (length & 7);
			var simdHandle = handle.Reinterpret<Component1, Vector256<int>>();
			var simdLength = alignedLength / 8;
			for (int i = 0; i < simdLength; i++)
			{
				simdHandle[i] += sum;
			}

			for (int i = alignedLength; i < length; i++)
			{
				handle[i].Value++;
			}
		}
	}

	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_ForEach()
	{
		_entitiesDb.Query.ForEach((Entity entity, ref Component1 a) =>
		{
			a.Value++;
		});
	}
}