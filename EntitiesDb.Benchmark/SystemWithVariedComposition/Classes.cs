using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using EntitiesDb.Benchmark.Contexts.Classes_Components;
using System.Runtime.InteropServices;

namespace EntitiesDb.Benchmark;

public partial class SystemWithVariedComposition
{
	private class ClassesContext : ClassesBaseContext
	{
		public ClassesContext(int entityCount)
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
	private readonly ClassesContext _classes;

	[BenchmarkCategory(Categories.Classes)]
	[Benchmark]
	public void Classes()
	{
		var entitySpanA = CollectionsMarshal.AsSpan(_classes.OneComponentEntities);
		foreach (ref var entity in entitySpanA)
		{
			entity.Component1.Value++;
		}

		var entitySpanB = CollectionsMarshal.AsSpan(_classes.TwoComponentEntities);
		foreach (ref var entity in entitySpanB)
		{
			entity.Component1.Value++;
		}

		var entitySpanC = CollectionsMarshal.AsSpan(_classes.ThreeComponentEntities);
		foreach (ref var entity in entitySpanC)
		{
			entity.Component1.Value++;
		}
	}
}
