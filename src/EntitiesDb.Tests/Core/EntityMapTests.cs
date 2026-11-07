namespace EntitiesDb.Core;

/// <summary>
/// Entity ids and versions as seen through the public API: recycling order, growth, TrimExcess with and
/// without kept versions, the entity limit. The entity map moved from managed arrays to native memory;
/// these pin that nothing observable changed (one exception, marked below).
/// </summary>
public sealed class EntityMapTests
{
	private record struct Value(int V);

	private static Entity[] CreateMany(EntityDatabase db, int count)
	{
		var entities = new Entity[count];
		for (int i = 0; i < count; i++)
			entities[i] = db.Create(new Value(i));
		return entities;
	}

	[Fact]
	public void Destroy_RecyclesIdsOldestFirst_WithTheNextVersion()
	{
		using var db = new EntityDatabase();
		var e = CreateMany(db, 5);
		db.Destroy(e[3]);
		db.Destroy(e[1]);
		db.Destroy(e[4]);

		var x = db.Create(new Value(30));
		var y = db.Create(new Value(10));
		var z = db.Create(new Value(40));
		var fresh = db.Create(new Value(50));

		Assert.Equal(new Entity(3, 1), x);
		Assert.Equal(new Entity(1, 1), y);
		Assert.Equal(new Entity(4, 1), z);
		Assert.Equal(new Entity(5, 0), fresh);
		Assert.False(db.Exists(e[3]));
		Assert.True(db.Exists(x));
		Assert.Equal(10, db.Read<Value>(y).V);
	}

	[Fact]
	public void Recycling_SurvivesMapGrowth_AndRepeatedReuse()
	{
		using var db = new EntityDatabase();
		var e = CreateMany(db, 3000); // grows the map past its first block
		db.Destroy(e[2999]);
		db.Destroy(e[5]);
		db.Destroy(e[1500]);

		Assert.Equal(new Entity(2999, 1), db.Create(new Value(0)));
		Assert.Equal(new Entity(5, 1), db.Create(new Value(0)));
		var reused = db.Create(new Value(7));
		Assert.Equal(new Entity(1500, 1), reused);

		db.Destroy(reused);
		Assert.Equal(new Entity(1500, 2), db.Create(new Value(0)));
		Assert.Equal(new Entity(3000, 0), db.Create(new Value(0)));
		Assert.Equal(3001, db.EntityCount);
	}

	[Fact]
	public void TrimExcess_KeepVersions_IdsPastTheEndComeBackWithTheirVersions()
	{
		using var db = new EntityDatabase();
		var e = CreateMany(db, 5000);
		db.Destroy(e[3]);
		for (int i = 10; i < 5000; i++)
			db.Destroy(e[i]);

		db.TrimExcess(keepVersions: true);

		// id 3 is still free and recycled first; ids from 10 are handed out as new ids again
		Assert.Equal(new Entity(3, 1), db.Create(new Value(0)));
		var again = CreateMany(db, 4990);
		Assert.Equal(new Entity(10, 1), again[0]);
		Assert.Equal(new Entity(4000, 1), again[3990]);
		Assert.Equal(new Entity(4999, 1), again[4989]);
		Assert.False(db.Exists(e[4000]));
		Assert.Equal(3990, db.Read<Value>(again[3990]).V);
	}

	[Fact]
	public void TrimExcess_Twice_RestoresEachIdsNewestVersion()
	{
		using var db = new EntityDatabase();
		var e = CreateMany(db, 5000);
		for (int i = 10; i < 5000; i++)
			db.Destroy(e[i]);
		db.TrimExcess(); // ids 10..4999 at version 1

		var second = CreateMany(db, 2000); // ids 10..2009, version 1
		foreach (var entity in second)
			db.Destroy(entity);
		db.TrimExcess(); // ids 10..2009 at version 2, 2010..4999 still at 1

		var third = CreateMany(db, 4990);
		Assert.Equal(new Entity(500, 2), third[490]);
		Assert.Equal(new Entity(1500, 2), third[1490]);
		Assert.Equal(new Entity(2009, 2), third[1999]);
		Assert.Equal(new Entity(2010, 1), third[2000]);
		Assert.Equal(new Entity(4999, 1), third[4989]);
	}

	[Fact]
	public void TrimExcess_DropVersions_ForgetsVersionsPastTheTrimmedBlock()
	{
		using var db = new EntityDatabase();
		var e = CreateMany(db, 5000);
		for (int i = 10; i < 5000; i++)
			db.Destroy(e[i]);

		db.TrimExcess(keepVersions: false);

		var again = CreateMany(db, 4990);
		Assert.Equal(new Entity(500, 1), again[490]);   // inside the kept block (1024 ids)
		Assert.Equal(new Entity(4000, 0), again[3990]); // past it: version lost
	}

	[Fact]
	public void MaxEntities_IsEnforced_AndFreedIdsStillRecycle()
	{
		using var db = new EntityDatabase(new(16 * 1024, 3000, -1));
		var e = CreateMany(db, 3000);
		Assert.Throws<MaxReachedException>(() => db.Create(new Value(0)));
		// the one deliberate change: a reservation past the limit always throws (it used to pass when the
		// pooled reference array happened to be longer than the limit, as 4096 is here)
		Assert.Throws<MaxReachedException>(() => db.Reserve<Value>(1));

		db.Destroy(e[42]);
		Assert.Equal(new Entity(42, 1), db.Create(new Value(0)));
		Assert.Throws<MaxReachedException>(() => db.Create(new Value(0)));
	}

	[Fact]
	public void Exists_OutOfRangeOrNegativeIds_IsFalse()
	{
		using var db = new EntityDatabase();
		var a = db.Create(new Value(1));
		Assert.False(db.Exists(-1));
		Assert.False(db.Exists(1));
		Assert.False(db.Exists(int.MaxValue));
		Assert.False(db.Exists(new Entity(a.Id, 1)));
		Assert.Throws<EntityException>(() => db.Read<Value>(5000));
	}

	[Fact]
	public void Create_WithoutReserve_AllocatesNoManagedMemoryForTheEntityMap()
	{
		using var db = new EntityDatabase();
		db.Create(new Value(0)); // archetype and first chunk

		var before = GC.GetAllocatedBytesForCurrentThread();
		for (int i = 0; i < 100_000; i++)
			db.Create(new Value(i));
		var allocated = GC.GetAllocatedBytesForCurrentThread() - before;

		// chunk bookkeeping only; the managed entity map grew by ~7 MB here
		Assert.True(allocated < 512 * 1024, $"allocated {allocated} bytes");
	}
}
