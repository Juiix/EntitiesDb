using static EntitiesDb.FakeDb;

namespace EntitiesDb.Storage;

public sealed class EntityVersionTests
{
	// the map's version arrays come from the process-wide ArrayPool<int>.Shared and went back with the
	// versions its destroys had bumped still in them: the next database to rent one gave its first
	// entities versions they had never had, so Entity(0, 0) "didn't exist"
	[Fact]
	public void AFreshDatabase_StartsEveryIdAtVersionZero_AfterAnotherDestroyedItsEntities()
	{
		for (int round = 0; round < 3; round++)
		{
			using (var used = new EntityDatabase())
			{
				var a = used.Create(new Position(1, 1));
				var b = used.Create(new Position(2, 2));
				used.Destroy(a);
				used.Destroy(b);
			}

			using var fresh = new EntityDatabase();
			Assert.Equal(new Entity(0, 0), fresh.Create(new Position(0, 0)));
			Assert.Equal(new Entity(1, 0), fresh.Create(new Position(0, 0)));
		}
	}
}
