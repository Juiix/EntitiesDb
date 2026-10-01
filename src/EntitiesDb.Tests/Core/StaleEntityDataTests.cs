using static EntitiesDb.FakeDb;

namespace EntitiesDb.Storage;

public sealed class StaleEntityDataTests
{
	// EntityData is a ref into its archetype's chunk array. That array used to come from the shared
	// ArrayPool<Chunk> and went back to it when it grew, so a stale EntityData could end up reading or
	// writing whatever archetype rented the array next.
	[Fact]
	public void EntityData_UsedAfterItsArchetypeGrew_ThrowsInsteadOfTouchingAnotherArchetype()
	{
		using var db = new EntityDatabase(new EntityDatabaseOptions(chunkByteSize: 1024));
		var first = db.Create(new Position(1, 1));
		var perChunk = db.GetArchetype(first).EntitiesPerChunk;
		var data = db.GetEntityData(first);
		Assert.Equal(new Position(1, 1), data.Read<Position>());

		// grow Position's chunk array past its first 16 slots, and give another archetype chunks
		for (int i = 0; i < perChunk * 20; i++)
			db.Create(new Position(i, i));
		for (int i = 0; i < perChunk * 20; i++)
			db.Create(new Health(i, i));

		InvalidOperationException? stale = null;
		try { _ = data.Read<Position>(); }
		catch (InvalidOperationException e) { stale = e; }
		Assert.NotNull(stale);

		// taken again, it works
		Assert.Equal(new Position(1, 1), db.GetEntityData(first).Read<Position>());
	}
}
