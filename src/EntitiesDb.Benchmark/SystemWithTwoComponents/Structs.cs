using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using EntitiesDb.Benchmark.Contexts.Structs_Components;
using System.Runtime.InteropServices;

namespace EntitiesDb.Benchmark;

public partial class SystemWithTwoComponents
{
	private class StructsContext : StructsBaseContext
	{
		public StructsContext(int entityCount)
		{
			var list = TwoComponentEntities;
			for (int i = 0; i < entityCount; i++)
			{
				list.Add(new EntityTwoComponent()
				{
					EntityId = i,
					Component1 = new Component1(),
					Component2 = new Component2(1),
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
		var entitySpan = CollectionsMarshal.AsSpan(_structs.TwoComponentEntities);
		foreach (ref var entity in entitySpan)
		{
			entity.Component1.Value += entity.Component2.Value;
		}
	}
}
