using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts;
using EntitiesDb.Benchmark.Contexts.EntitiesDb_Components;

namespace EntitiesDb.Benchmark;

public partial class CreateEntityWithOneComponent
{
	[Context]
	private readonly EntitiesDbBaseContext _entitiesDb;

	/// <summary>
	/// Direct creation: Reserve capacity up front, then Create one entity at a time.
	/// </summary>
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

	/// <summary>
	/// Deferred creation: queue every Create in a CommandBuffer, then Commit once.
	/// This is the pattern used for structural changes from inside parallel queries.
	/// </summary>
	[BenchmarkCategory(Categories.EntitiesDb)]
	[Benchmark]
	public void EntitiesDb_CommandBuffer()
	{
		var entities = _entitiesDb.Entities;
		entities.Reserve<Component1>(EntityCount);

		var commands = entities.CreateCommandBuffer(EntityCount);
		for (int i = 0; i < EntityCount; ++i)
		{
			commands.Create(new Component1());
		}
		commands.Commit();
	}
}
