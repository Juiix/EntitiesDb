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
	public void Query_AddComponent_MovesEntity_MarksOneChunk()
	{
		using var db = CreateDb();
		db.FillPlayers();

		var query = db.QueryBuilder
			.WithAll<Position>()
			.WithAny<PlayerTag, BossTag>()
			.WithChangeFilter<ComponentTracked>()
			.Build();

		// 1. No chunks
		Assert.Equal(0, query.CountChunks());

		// Add a tag the player doesn't have to force an archetype move that still matches the query
		db.Add(new Entity(0, 0), new ComponentTracked());

		// 2. One chunk (dst both have Position/PlayerTag and were written)
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

	// Source-generated ForEach / ForEachChunk must honor the query's change filter exactly like
	// ReadHandles/WriteHandles do: after the filter is consumed nothing is visited; a single write
	// makes exactly that chunk visible; visiting with a `ref` parameter re-marks the chunk.
	[Fact]
	public void Query_ForEachRef_VisitsOnlyChangedChunks_AndReMarksThem()
	{
		using var db = CreateDb();

		// a change filter sees changes made after the query is built, so build it before the players exist
		var changeQuery = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<Position>()
			.Build();
		db.FillPlayers();

		// 1. all 5 chunks are "changed" right after creation; a ref ForEach visits them all and re-marks them
		int visited = 0;
		changeQuery.ForEach((ref Position p) => { visited++; });
		Assert.Equal(db.QueryBuilder.WithAll<Position, PlayerTag>().Build().CountEntities(), visited);
		Assert.Equal(5, changeQuery.CountChunks());   // re-marked by the ref parameter

		// 2. consumed -> a further ref ForEach sees nothing (and therefore marks nothing)
		visited = 0;
		changeQuery.ForEach((ref Position p) => { visited++; });
		Assert.Equal(0, visited);
		Assert.Equal(0, changeQuery.CountChunks());

		// 3. write to one entity -> exactly one chunk is visited, and re-marked
		ref var position = ref db.Write<Position>(new Entity(0, 0));
		visited = 0;
		changeQuery.ForEach((ref Position p) => { visited++; });
		Assert.True(visited > 0 && visited <= db.GetArchetype(new Entity(0, 0)).EntitiesPerChunk, $"visited {visited}");
		Assert.Equal(1, changeQuery.CountChunks());
	}

	[Fact]
	public void Query_ForEachIn_VisitsOnlyChangedChunks_AndDoesNotMark()
	{
		using var db = CreateDb();

		var changeQuery = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<Position>()
			.Build();
		db.FillPlayers();

		// 1. consume
		Assert.Equal(5, changeQuery.CountChunks());
		Assert.Equal(0, changeQuery.CountChunks());

		// 2. an `in` ForEach on a consumed filter visits nothing
		int visited = 0;
		changeQuery.ForEachAlt((in Position position) => { visited++; });
		Assert.Equal(0, visited);
		Assert.Equal(0, changeQuery.CountChunks());

		// 3. write one entity: `in` ForEach visits that chunk but does not re-mark it
		db.Write<Position>(new Entity(0, 0)) = new Position(1, 1);
		visited = 0;
		changeQuery.ForEachAlt((in Position position) => { visited++; });
		Assert.True(visited > 0, "expected the changed chunk to be visited");
		Assert.Equal(0, changeQuery.CountChunks());
	}

	[Fact]
	public void Destroy_MovingAChangedEntity_KeepsItsChangeVisible()
	{
		using var db = CreateDb();
		db.FillPlayers();

		var changeQuery = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<Position>()
			.Build();
		var archetype = db.GetArchetype(new Entity(0, 0));
		ref readonly var lastChunk = ref archetype.GetChunk(archetype.ChunksInUse - 1);
		var last = lastChunk.Entity(lastChunk.EntityCount - 1);
		var lastId = last.Id;

		// the filter has consumed everything; only the last entity changes, in the last chunk
		Assert.Equal(0, changeQuery.CountChunks());
		db.Write<Position>(last) = new Position(7, 7);

		// destroying an entity in the first chunk moves the last entity into its slot
		db.Destroy(new Entity(0, 0));

		var seen = new List<int>();
		changeQuery.ForEach((Entity e, in Position p, ref List<int> seen) => seen.Add(e.Id), ref seen);

		// its change used to stay behind in the last chunk, so the filter skipped the chunk it moved to
		Assert.Contains(lastId, seen);
	}

	[Fact]
	public void UntrackedWriteHandle_WritesWithoutMarking_UntilMarkChanged()
	{
		using var db = CreateDb();
		var changeQuery = db.QueryBuilder.WithAll<Position, PlayerTag>().WithChangeFilter<Position>().Build();
		db.FillPlayers();
		Assert.Equal(5, changeQuery.CountChunks()); // consume the creation

		// write in every chunk, mark only the first
		var chunks = 0;
		foreach (ref readonly var chunk in db.QueryBuilder.WithAll<Position, PlayerTag>().Build())
		{
			var positions = chunk.UntrackedWriteHandle<Position>();
			positions[0] = new Position(9, 9);
			if (chunks++ == 0) positions.MarkChanged();
		}

		Assert.Equal(5, chunks);
		Assert.Equal(1, changeQuery.CountChunks());

		// and Chunk.MarkChanged<T>() marks the same way
		foreach (ref readonly var chunk in db.QueryBuilder.WithAll<Position, PlayerTag>().Build())
			chunk.MarkChanged<Position>();
		Assert.Equal(5, changeQuery.CountChunks());
	}

	[Fact]
	public void ForEachChunk_UntrackedWriteHandle_ReportsOnlyTheChunksItMarks()
	{
		using var db = CreateDb();
		var changeQuery = db.QueryBuilder.WithAll<Position, PlayerTag>().WithChangeFilter<Position>().Build();
		db.FillPlayers();
		Assert.Equal(5, changeQuery.CountChunks());

		var chunkNumber = 0;
		db.QueryBuilder.WithAll<Position, PlayerTag>().Build().ForEachChunk((int length, UntrackedWriteHandle<Position> positions, ref int chunkNumber) =>
		{
			for (int i = 0; i < length; i++)
				positions[i] = new Position(i, i);
			if (chunkNumber++ % 2 == 0)
				positions.MarkChanged();
		}, ref chunkNumber);

		Assert.Equal(5, chunkNumber);
		Assert.Equal(3, changeQuery.CountChunks()); // the 1st, 3rd and 5th
	}

	[Fact]
	public void ForEachChunkParallel_UntrackedWriteHandle_ReportsOnlyTheChunksItMarks()
	{
		using var db = CreateDb(parallel: true);
		var changeQuery = db.QueryBuilder.WithAll<Position, PlayerTag>().WithChangeFilter<Position>().Build();
		db.FillPlayers();
		Assert.Equal(5, changeQuery.CountChunks());
		var perChunk = db.GetArchetype(new Entity(0, 0)).EntitiesPerChunk;

		// mark only the partly filled chunk, from whichever thread gets it
		var full = perChunk;
		db.QueryBuilder.WithAll<Position, PlayerTag>().Build().ForEachChunkParallel((int length, UntrackedWriteHandle<Position> positions, ref int full) =>
		{
			positions[0] = new Position(1, 1);
			if (length < full)
				positions.MarkChanged();
		}, ref full);

		Assert.Equal(1, changeQuery.CountChunks());
	}

	[Fact]
	public void Query_ForEachChunk_HonorsChangeFilter()
	{
		using var db = CreateDb();

		var changeQuery = db.QueryBuilder
			.WithAll<Position, PlayerTag>()
			.WithChangeFilter<Position>()
			.Build();
		db.FillPlayers();

		int chunks = 0;
		changeQuery.ForEachChunk((int length, ReadHandle<Position> positions) => { chunks++; });
		Assert.Equal(5, chunks);

		chunks = 0;
		changeQuery.ForEachChunk((int length, ReadHandle<Position> positions) => { chunks++; });
		Assert.Equal(0, chunks);

		db.Write<Position>(new Entity(0, 0)) = new Position(2, 2);
		chunks = 0;
		changeQuery.ForEachChunk((int length, WriteHandle<Position> positions) => { chunks++; });
		Assert.Equal(1, chunks);
		Assert.Equal(1, changeQuery.CountChunks()); // WriteHandle re-marked it
	}
}
