using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using EntitiesDb.Benchmark.Contexts.Classes_Components;

namespace EntitiesDb.Benchmark;

public partial class CreateEntityWithOneComponent
{
	[Context]
	private readonly ClassesBaseContext _classes;

	[BenchmarkCategory(Categories.Classes)]
	[Benchmark]
	public void Classes()
	{
		var list = _classes.OneComponentEntities;
		list.EnsureCapacity(EntityCount);

		for (int i = 0; i < EntityCount; ++i)
		{
			list.Add(new EntityOneComponent()
			{
				EntityId = i,
				Component1 = new Component1()
			});
		}
	}
}
