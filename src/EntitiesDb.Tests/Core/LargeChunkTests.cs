using static EntitiesDb.FakeDb;

namespace EntitiesDb.Storage;

public sealed class LargeChunkTests
{
	// column offsets used to be `short`: in a chunk past 32 KB the later columns' offsets wrapped
	// negative and components overwrote each other (or memory before the chunk)
	[Theory]
	[InlineData(16 * 1024)]
	[InlineData(64 * 1024)]
	[InlineData(256 * 1024)]
	public void EveryColumn_KeepsItsOwnValues_InAChunkOfThisSize(int chunkByteSize)
	{
		using var db = new EntityDatabase(new EntityDatabaseOptions(chunkByteSize));
		var first = db.Create(new Position(0, 0), new Health(0, 0), new Velocity(0, 0), new Mana(0, 0), new Stamina(0, 0));
		var perChunk = db.GetArchetype(first).EntitiesPerChunk;
		var count = perChunk * 2 + 3; // spill into a third chunk

		var entities = new Entity[count];
		entities[0] = first;
		for (int i = 1; i < count; i++)
			entities[i] = db.Create(new Position(0, 0), new Health(0, 0), new Velocity(0, 0), new Mana(0, 0), new Stamina(0, 0));

		for (int i = 0; i < count; i++)
		{
			db.Write<Position>(entities[i]) = new Position(i, -i);
			db.Write<Health>(entities[i]) = new Health(i, i + 1);
			db.Write<Velocity>(entities[i]) = new Velocity(i * 2, i * 3);
			db.Write<Mana>(entities[i]) = new Mana(i * 5, i * 7);
			db.Write<Stamina>(entities[i]) = new Stamina(i * 11, i * 13);
		}

		for (int i = 0; i < count; i++)
		{
			Assert.Equal(new Position(i, -i), db.Read<Position>(entities[i]));
			Assert.Equal(new Health(i, i + 1), db.Read<Health>(entities[i]));
			Assert.Equal(new Velocity(i * 2, i * 3), db.Read<Velocity>(entities[i]));
			Assert.Equal(new Mana(i * 5, i * 7), db.Read<Mana>(entities[i]));
			Assert.Equal(new Stamina(i * 11, i * 13), db.Read<Stamina>(entities[i]));
		}

		// a destroy moves the last entity into the hole: its columns must move with it
		db.Destroy(entities[0]);
		var last = entities[count - 1];
		Assert.Equal(new Stamina((count - 1) * 11, (count - 1) * 13), db.Read<Stamina>(last));
		Assert.Equal(new Position(count - 1, -(count - 1)), db.Read<Position>(last));
	}
}
