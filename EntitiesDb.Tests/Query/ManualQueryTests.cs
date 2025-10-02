namespace EntitiesDb.Query;

public sealed class ManualQueryTests
{
	private record struct Position(float X, float Y);
	private record struct Health(int Value, int Max);

	[ZeroSize]
	private record struct PlayerTag;
	[ZeroSize]
	private record struct NpcTag;
	[ZeroSize]
	private record struct EnemyTag;

	private static EntityDatabase CreateDb() => new(4096, 1000);

	[Fact]
	public void Query()
	{
		var db = CreateDb();
		var query = db.QueryBuilder.WithAll<Position, Health>()
			.WithNone<EnemyTag>()
			.Build();

		foreach (ref readonly var chunk in query)
		{

		}
	}


}
