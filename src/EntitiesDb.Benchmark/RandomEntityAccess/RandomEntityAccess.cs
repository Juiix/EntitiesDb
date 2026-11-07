using BenchmarkDotNet.Attributes;
using EntitiesDb.Benchmark.Contexts.EntitiesDb_Components;

namespace EntitiesDb.Benchmark;

/// <summary>
/// Per-entity access by <see cref="Entity"/> handle in shuffled order: every call is a fresh entity-map
/// lookup. Entities alternate over four archetypes (half of them have <see cref="Component2"/>), so
/// neighbouring handles land in different archetypes. <see cref="TrackedComponent"/> has
/// <see cref="TrackChangesAttribute"/>, so its writes mark chunks for change filters.
/// </summary>
[BenchmarkCategory(Categories.RandomAccess, Categories.EntitiesDb)]
[MemoryDiagnoser]
public class RandomEntityAccess
{
	[TrackChanges] internal record struct TrackedComponent(int Value);

	private EntityDatabase _db;
	private Entity[] _shuffled;

	[Params(100_000)]
	public int EntityCount { get; set; }

	[GlobalSetup]
	public void Setup()
	{
		_db = new EntityDatabase();
		_shuffled = new Entity[EntityCount];
		for (int i = 0; i < EntityCount; i++)
		{
			_shuffled[i] = (i & 3) switch
			{
				0 => _db.Create(new Component1(i), new TrackedComponent(i)),
				1 => _db.Create(new Component1(i), new Component2(i), new TrackedComponent(i)),
				2 => _db.Create(new Component1(i), new Component3(i), new TrackedComponent(i)),
				_ => _db.Create(new Component1(i), new Component2(i), new Component3(i), new TrackedComponent(i)),
			};
		}
		new Random(42).Shuffle(_shuffled);
	}

	[GlobalCleanup]
	public void Cleanup() => _db.Dispose();

	[Benchmark]
	public long Read()
	{
		long sum = 0;
		foreach (var entity in _shuffled)
			sum += _db.Read<Component1>(entity).Value;
		return sum;
	}

	[Benchmark]
	public long TryRead_HalfMissing()
	{
		long sum = 0;
		foreach (var entity in _shuffled)
		{
			_db.TryRead<Component2>(entity, out var component);
			sum += component.Value; // default when missing; no branch on the result
		}
		return sum;
	}

	[Benchmark]
	public void Write()
	{
		foreach (var entity in _shuffled)
			_db.Write<Component1>(entity).Value++;
	}

	[Benchmark]
	public void Set()
	{
		int i = 0;
		foreach (var entity in _shuffled)
			_db.Set(entity, new Component1(i++));
	}

	[Benchmark]
	public void Write_Tracked()
	{
		foreach (var entity in _shuffled)
			_db.Write<TrackedComponent>(entity).Value++;
	}

	[Benchmark]
	public void Set_Tracked()
	{
		int i = 0;
		foreach (var entity in _shuffled)
			_db.Set(entity, new TrackedComponent(i++));
	}
}
