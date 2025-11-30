using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using EntitiesDb.Benchmark.Contexts.Structs_Components;

namespace EntitiesDb.Benchmark;

public partial class CreateEntityWithOneComponent
{
	[Context]
	private readonly StructsBaseContext _structs;

	[BenchmarkCategory(Categories.Structs)]
	[Benchmark]
	public void Structs()
	{
		var list = _structs.OneComponentEntities;
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
