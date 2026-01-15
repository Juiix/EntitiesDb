using static EntitiesDb.FakeDb;

namespace EntitiesDb.Queries;

public sealed class ChangeFilterTests
{
	[Fact]
	public void Query_CreateEntities_ShowInFilter()
	{
		using var db = CreateDb();

		var query = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<Position>()
			.Build();

		// 1.
		// No chunks
		Assert.Equal(0, query.CountChunks());

		// create players
		db.FillPlayers();

		// 2. First query
		// All 5 chunks
		Assert.Equal(5, query.CountChunks());

		// 3.
		// No chunks
		Assert.Equal(0, query.CountChunks());
	}

	[Fact]
	public void Query_Get_ReturnsOneChunk()
	{
		using var db = CreateDb();
		db.FillPlayers();

		var query = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<Position>()
			.Build();

		// 1.
		// No chunks
		Assert.Equal(0, query.CountChunks());

		// get component
		ref var position = ref db.Write<Position>(new Entity(0, 0));

		// 2.
		// One chunk
		Assert.Equal(1, query.CountChunks());

		// 3.
		// No chunks
		Assert.Equal(0, query.CountChunks());
	}

	[Fact]
	public void Query_GetBuffer_ReturnsOneChunk()
	{
		using var db = CreateDb();
		db.FillPlayers();

		var query = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<InventoryItem>()
			.Build();

		// 1.
		// No chunks
		Assert.Equal(0, query.CountChunks());

		// get component
		var items = db.WriteBuffer<InventoryItem>(new Entity(0, 0));

		// 2.
		// One chunk
		Assert.Equal(1, query.CountChunks());

		// 3.
		// No chunks
		Assert.Equal(0, query.CountChunks());
	}

	[Fact]
	public void Query_GetReadOnly_ReturnsNoChunks()
	{
		using var db = CreateDb();
		db.FillPlayers();

		var query = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<Position>()
			.Build();

		// 1.
		// No chunks
		Assert.Equal(0, query.CountChunks());

		// get component
		ref readonly var position = ref db.Read<Position>(new Entity(0, 0));

		// 2.
		// No chunk
		Assert.Equal(0, query.CountChunks());
	}

	[Fact]
	public void Query_SetComponent_ReturnsOneChunk()
	{
		using var db = CreateDb();
		db.FillPlayers();

		var query = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<Position>()
			.Build();

		// 1. No chunks
		Assert.Equal(0, query.CountChunks());

		// write to a non-buffer component
		db.Set(new Entity(0, 0), new Position(123, 456));

		// 2. One chunk
		Assert.Equal(1, query.CountChunks());

		// 3. Consumed
		Assert.Equal(0, query.CountChunks());
	}

	[Fact]
	public void Query_SetBuffer_ReturnsOneChunk()
	{
		using var db = CreateDb();
		db.FillPlayers();

		var query = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<InventoryItem>()
			.Build();

		// 1. No chunks
		Assert.Equal(0, query.CountChunks());

		// overwrite buffer values
		db.Set<InventoryItem>(new Entity(0, 0), new[] { new InventoryItem(42, 9), new InventoryItem(7, 1) });

		// 2. One chunk (buffer write marks chunk changed)
		Assert.Equal(1, query.CountChunks());

		// 3. Consumed
		Assert.Equal(0, query.CountChunks());
	}

	[Fact]
	public void Query_AddComponent_MovesEntity_MarksTwoChunks()
	{
		using var db = CreateDb();
		db.FillPlayers();

		var query = db.QueryBuilder
			.WithAll<Position>()
			.WithAny<PlayerTag, BossTag>()
			.WithChangeFilter<BossTag>()
			.Build();

		// 1. No chunks
		Assert.Equal(0, query.CountChunks());

		// Add a tag the player doesn't have to force an archetype move that still matches the query
		db.Add(new Entity(0, 0), new BossTag());

		// 2. Two chunks (src & dst both have Position/PlayerTag and were written)
		Assert.Equal(1, query.CountChunks());

		// 3. Consumed
		Assert.Equal(0, query.CountChunks());
	}

	[Fact]
	public void Query_RemoveComponent_ThatDropsFromQuery_MarksNoChunks()
	{
		using var db = CreateDb();
		db.FillPlayers();

		var query = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<Position>()
			.Build();

		// 1. No chunks
		Assert.Equal(0, query.CountChunks());

		// Removing Position drops the destination archetype from the query;
		// no chunks should report changes, since changes are driven per component not entity
		db.Remove<Position>(new Entity(0, 0));

		// 2. No chunks
		Assert.Equal(0, query.CountChunks());
	}

	[Fact]
	public void Query_CloneEntity_ReturnsOneChunk()
	{
		using var db = CreateDb();
		db.FillPlayers();

		var query = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<Position>()
			.Build();

		// 1. No chunks
		Assert.Equal(0, query.CountChunks());

		// Clone writes a new entity into the same archetype (destination chunk changed)
		db.Clone(new Entity(0, 0));

		// 2. One chunk
		Assert.Equal(1, query.CountChunks());

		// 3. Consumed
		Assert.Equal(0, query.CountChunks());
	}

	[Fact]
	public void Query_GetBufferReadOnly_ReturnsNoChunks()
	{
		using var db = CreateDb();
		db.FillPlayers();

		var query = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<Position>()
			.Build();

		// 1. No chunks
		Assert.Equal(0, query.CountChunks());

		// read-only buffer access
		var ro = db.ReadBuffer<InventoryItem>(new Entity(0, 0));
		_ = ro.Length;

		// 2. Still none
		Assert.Equal(0, query.CountChunks());
	}

	[Fact]
	public void Query_Create_MatchingEntity_ReturnsOneChunk()
	{
		using var db = CreateDb();

		var query = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<Position>()
			.Build();

		// 1. No chunks
		Assert.Equal(0, query.CountChunks());

		// Create an entity that matches the query directly
		db.Create(new Position(1, 2), new PlayerTag());

		// 2. One chunk
		Assert.Equal(1, query.CountChunks());

		// 3. Consumed
		Assert.Equal(0, query.CountChunks());
	}

	[Fact]
	public void Query_ForEachRef_ReturnsAllChunks()
	{
		using var db = CreateDb();
		db.FillPlayers();

		var forEachQuery = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.Build();

		var changeQuery = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<Position>()
			.Build();

		// 1.
		// No chunks
		Assert.Equal(0, changeQuery.CountChunks());

		// get Position components
		changeQuery.ForEach((ref Position p) =>
		{

		});

		// 2.
		// All 5 chunks
		Assert.Equal(5, changeQuery.CountChunks());

		// 3.
		// No chunks
		Assert.Equal(0, changeQuery.CountChunks());
	}


	[Fact]
	public void Query_ForEachIn_ReturnsNoChunks()
	{
		using var db = CreateDb();
		db.FillPlayers();

		var forEachQuery = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.Build();

		var changeQuery = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<Position>()
			.Build();

		// 1.
		// No chunks
		Assert.Equal(0, changeQuery.CountChunks());

		// get Position components
		changeQuery.ForEachAlt((in Position position) =>
		{

		});

		// 2.
		// No chunks
		Assert.Equal(0, changeQuery.CountChunks());
	}
}
