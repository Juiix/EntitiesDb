using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using EntitiesDb.Benchmark.Contexts.EntitiesDb_Components;

namespace EntitiesDb.Benchmark;

public partial class CreateEntityWithOneComponent
{
	[Context]
	private readonly EntitiesDbBaseContext _entitiesDb;

	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb()
	{
		var entities = _entitiesDb.Entities;
		entities.Reserve<Component1>(EntityCount);

		for (int i = 0; i < EntityCount; ++i)
		{
			entities.Create(new Component1());
		}
	}

	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_Bulk()
	{
		var entities = _entitiesDb.Entities;
		entities.Reserve<Component1>(EntityCount);

		var bulk = entities.GetBulkCreate<Component1>();
		for (int i = 0; i < EntityCount; ++i)
		{
			entities.Create(in bulk, new Component1());
		}
	}
}
