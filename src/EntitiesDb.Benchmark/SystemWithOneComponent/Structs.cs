using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using EntitiesDb.Benchmark.Contexts.Structs_Components;
using System.Runtime.InteropServices;

namespace EntitiesDb.Benchmark;

public partial class SystemWithOneComponent
{
	private class StructsContext : StructsBaseContext
	{
		public StructsContext(int entityCount)
		{
			var list = OneComponentEntities;
			for (int i = 0; i < entityCount; i++)
			{
				list.Add(new EntityOneComponent()
				{
					EntityId = i,
					Component1 = new Component1()
				});
			}
		}
	}

	[Context]
	private readonly StructsContext _structs;

	[BenchmarkCategory(Categories.Structs)]
	[Benchmark]
	public void Structs()
	{
		var entitySpan = CollectionsMarshal.AsSpan(_structs.OneComponentEntities);
		foreach (ref var entity in entitySpan)
		{
			entity.Component1.Value++;
		}
	}
}
