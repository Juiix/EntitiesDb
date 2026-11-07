using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts.EntitiesDb_Components;

namespace EntitiesDb.Benchmark;

/// <summary>
/// Structural changes over N entities: creates with several components, adding / removing a component
/// (an archetype move per entity) and destroys, each done directly and through a <see cref="CommandBuffer"/>.
/// Every iteration starts from a freshly seeded database; seeding is not measured.
/// </summary>
[BenchmarkCategory(Categories.Structural, Categories.EntitiesDb)]
[MemoryDiagnoser]
public class StructuralChanges
{
	private EntityDatabase _db;
	private Entity[] _entities;

	[Params(100_000)]
	public int EntityCount { get; set; }

	[IterationSetup(Targets = [nameof(Create_ThreeComponents), nameof(CommandBuffer_Create_ThreeComponents)])]
	public void SetupEmpty()
	{
		_db = new EntityDatabase();
		_db.Reserve<Component1, Component2, Component3>(EntityCount);
	}

	[IterationSetup(Targets = [nameof(Add), nameof(CommandBuffer_Add), nameof(CommandBuffer_Set), nameof(Destroy), nameof(CommandBuffer_Destroy)])]
	public void SetupOneComponent() => Seed(twoComponents: false);

	[IterationSetup(Targets = [nameof(Remove), nameof(CommandBuffer_Remove)])]
	public void SetupTwoComponents() => Seed(twoComponents: true);

	[IterationCleanup]
	public void Cleanup()
	{
		_db.Dispose();
		_db = null;
		_entities = null;
	}

	private void Seed(bool twoComponents)
	{
		_db = new EntityDatabase();
		_entities = new Entity[EntityCount];
		for (int i = 0; i < EntityCount; i++)
		{
			_entities[i] = twoComponents
				? _db.Create(new Component1(i), new Component2(i))
				: _db.Create(new Component1(i));
		}
		if (!twoComponents)
			_db.Reserve<Component1, Component2>(EntityCount); // destination chunks for the Add rows
	}

	[Benchmark]
	public void Create_ThreeComponents()
	{
		for (int i = 0; i < EntityCount; i++)
			_db.Create(new Component1(i), new Component2(i), new Component3(i));
	}

	[Benchmark]
	public void CommandBuffer_Create_ThreeComponents()
	{
		var commands = _db.CreateCommandBuffer(EntityCount);
		for (int i = 0; i < EntityCount; i++)
			commands.Create(new Component1(i), new Component2(i), new Component3(i));
		commands.Commit();
	}

	[Benchmark]
	public void Add()
	{
		foreach (var entity in _entities)
			_db.Add(entity, new Component2(1));
	}

	[Benchmark]
	public void CommandBuffer_Add()
	{
		var commands = _db.CreateCommandBuffer(EntityCount);
		foreach (var entity in _entities)
			commands.Add(entity, new Component2(1));
		commands.Commit();
	}

	/// <summary>
	/// Overwrites a component every entity already has: no archetype move
	/// </summary>
	[Benchmark]
	public void CommandBuffer_Set()
	{
		var commands = _db.CreateCommandBuffer(EntityCount);
		foreach (var entity in _entities)
			commands.Set(entity, new Component1(1));
		commands.Commit();
	}

	[Benchmark]
	public void Remove()
	{
		foreach (var entity in _entities)
			_db.Remove<Component2>(entity);
	}

	[Benchmark]
	public void CommandBuffer_Remove()
	{
		var commands = _db.CreateCommandBuffer(EntityCount);
		foreach (var entity in _entities)
			commands.Remove<Component2>(entity);
		commands.Commit();
	}

	[Benchmark]
	public void Destroy()
	{
		foreach (var entity in _entities)
			_db.Destroy(entity);
	}

	[Benchmark]
	public void CommandBuffer_Destroy()
	{
		var commands = _db.CreateCommandBuffer(EntityCount);
		foreach (var entity in _entities)
			commands.Destroy(entity);
		commands.Commit();
	}
}
