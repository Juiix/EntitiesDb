using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using EntitiesDb.Benchmark.Contexts.Classes_Components;
using System.Runtime.InteropServices;

namespace EntitiesDb.Benchmark;

public partial class SystemWithOneComponent
{
	private class ClassesContext : ClassesBaseContext
	{
		public ClassesContext(int entityCount)
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
	private readonly ClassesContext _classes;

	[BenchmarkCategory(Categories.Classes)]
	[Benchmark]
	public void Classes()
	{
		var entitySpan = CollectionsMarshal.AsSpan(_classes.OneComponentEntities);
		foreach (ref var entity in entitySpan)
		{
			entity.Component1.Value++;
		}
	}
}
