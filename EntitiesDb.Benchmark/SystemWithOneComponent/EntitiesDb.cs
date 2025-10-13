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
		foreach (var (handle, length) in _entitiesDb.Query.GetChunkIterator<Component1>())
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
	public void EntitiesDb_SourceGen()
	{
		_entitiesDb.Query.ForEach((Entity entity, ref Component1 a) =>
		{
			a.Value++;
		});
	}

	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_Inline()
	{
		var add = new Add();
		_entitiesDb.Query.Inline<Add, Component1>(ref add);
	}

	private struct Add : IForEach<Component1>
	{
		public void ForEach(ref Component1 t0Component)
		{
			t0Component.Value++;
		}
	}
}