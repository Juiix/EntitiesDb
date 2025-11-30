using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using System.Runtime.InteropServices;

namespace EntitiesDb.Benchmark;

public partial class SystemWithTwoComponentsVariedComposition
{
	private class ClassesContext : ClassesBaseContext
	{
		public ClassesContext(int entityCount)
		{
			var listA = TwoComponentEntities;
			var listB = ThreeComponentEntities;
			var listC = Three2ComponentEntities;
			var listD = FourComponentEntities;
			for (int i = 0; i < entityCount; i++)
			{
				switch (i % 4)
				{
					case 3:
						listA.Add(new()
						{
							EntityId = i,
							Component2 = new(1)
						});
						break;
					case 2:
						listB.Add(new()
						{
							EntityId = i,
							Component2 = new(1)
						});
						break;
					case 1:
						listC.Add(new()
						{
							EntityId = i,
							Component2 = new(1)
						});
						break;
					default:
						listD.Add(new()
						{
							EntityId = i,
							Component2 = new(1)
						});
						break;
				}
			}
		}
	}

	[Context]
	private readonly ClassesContext _classes;

	[BenchmarkCategory(Categories.Classes)]
	[Benchmark]
	public void Classes()
	{
		var entitySpanA = CollectionsMarshal.AsSpan(_classes.TwoComponentEntities);
		foreach (ref var entity in entitySpanA)
		{
			entity.Component1.Value += entity.Component2.Value;
		}

		var entitySpanB = CollectionsMarshal.AsSpan(_classes.ThreeComponentEntities);
		foreach (ref var entity in entitySpanB)
		{
			entity.Component1.Value += entity.Component2.Value;
		}

		var entitySpanC = CollectionsMarshal.AsSpan(_classes.Three2ComponentEntities);
		foreach (ref var entity in entitySpanC)
		{
			entity.Component1.Value += entity.Component2.Value;
		}

		var entitySpanD = CollectionsMarshal.AsSpan(_classes.FourComponentEntities);
		foreach (ref var entity in entitySpanD)
		{
			entity.Component1.Value += entity.Component2.Value;
		}
	}
}
