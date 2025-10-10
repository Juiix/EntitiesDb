using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using EntitiesDb.Benchmark.Contexts.Structs_Components;
using System.Runtime.InteropServices;

namespace EntitiesDb.Benchmark;

public partial class SystemWithVariedComposition
{
	private class StructsContext : StructsBaseContext
	{
		public StructsContext(int entityCount)
		{
			var listA = OneComponentEntities;
			for (int i = 0; i < entityCount; i++)
			{
				listA.Add(new EntityOneComponent()
				{
					EntityId = i
				});
			}

			var listB = TwoComponentEntities;
			for (int i = 0; i < entityCount; i++)
			{
				listB.Add(new EntityTwoComponent()
				{
					EntityId = i
				});
			}

			var listC = ThreeComponentEntities;
			for (int i = 0; i < entityCount; i++)
			{
				listC.Add(new EntityThreeComponent()
				{
					EntityId = i
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
		var entitySpanA = CollectionsMarshal.AsSpan(_structs.OneComponentEntities);
		foreach (ref var entity in entitySpanA)
		{
			entity.Component1.Value++;
		}

		var entitySpanB = CollectionsMarshal.AsSpan(_structs.TwoComponentEntities);
		foreach (ref var entity in entitySpanB)
		{
			entity.Component1.Value++;
		}

		var entitySpanC = CollectionsMarshal.AsSpan(_structs.ThreeComponentEntities);
		foreach (ref var entity in entitySpanC)
		{
			entity.Component1.Value++;
		}
	}
}
