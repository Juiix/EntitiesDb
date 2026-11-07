namespace EntitiesDb.Queries;

/// <summary>
/// Marking a chunk that is already newer than every change filter's version skips the global version
/// bump (see ChangeVersions). These pin the cases where skipping would lose a change.
/// </summary>
public sealed class ChangeVersionTests
{
	[TrackChanges] internal record struct Tracked(int Value);
	internal record struct Plain(int Value);

	private const int ChunkBytes = 4096;

	/// <summary>
	/// A database with three full-ish chunks of tracked entities; entity <c>i</c> lives in chunk
	/// <c>i / EntitiesPerChunk</c>
	/// </summary>
	private static (EntityDatabase Db, Entity[] Entities, int PerChunk) Create()
	{
		var db = new EntityDatabase(new(ChunkBytes, int.MaxValue, -1));
		var first = db.Create(new Tracked(0), new Plain(0));
		var perChunk = db.GetArchetype(first).EntitiesPerChunk;
		var entities = new Entity[perChunk * 3];
		entities[0] = first;
		for (int i = 1; i < entities.Length; i++)
			entities[i] = db.Create(new Tracked(i), new Plain(i));
		return (db, entities, perChunk);
	}

	private static Query TrackedQuery(EntityDatabase db) =>
		db.QueryBuilder.WithAll<Tracked>().WithChangeFilter<Tracked>().Build();

	private static int Changed(Query query)
	{
		int count = 0;
		foreach (var _ in query.ReadHandles<Tracked>())
			count++;
		return count;
	}

	private static int Global(EntityDatabase db) => db.GlobalChangeVersions[Component<Tracked>.Id];

	[Fact]
	public void WriteAfterTheFilterConsumedTheChunk_IsSeen()
	{
		var (db, e, _) = Create();
		using var _db = db;
		var query = TrackedQuery(db);

		db.Write<Tracked>(e[0]).Value++;
		db.Write<Tracked>(e[1]).Value++;
		Assert.Equal(1, Changed(query));
		Assert.Equal(0, Changed(query));

		// the chunk's version is now the filter's own: this write must bump it again
		db.Write<Tracked>(e[2]).Value++;
		Assert.Equal(1, Changed(query));
		Assert.Equal(0, Changed(query));
	}

	[Fact]
	public void RepeatedWritesToOneChunk_BumpTheGlobalVersionOnce()
	{
		var (db, e, perChunk) = Create();
		using var _db = db;
		var query = TrackedQuery(db);

		var before = Global(db);
		for (int i = 0; i < perChunk; i++)
			db.Set(e[i], new Tracked(-i));
		Assert.Equal(before + 1, Global(db));
		Assert.Equal(1, Changed(query));

		// after the filter looked, the next write needs a new version again
		db.Set(e[0], new Tracked(1));
		db.Set(e[1], new Tracked(1));
		Assert.Equal(before + 2, Global(db));
		Assert.Equal(1, Changed(query));
	}

	[Fact]
	public void TwoFilters_EachSeeEveryWrite_WhateverTheOtherConsumed()
	{
		var (db, e, perChunk) = Create();
		using var _db = db;
		var a = TrackedQuery(db);
		var b = TrackedQuery(db);

		db.Write<Tracked>(e[0]).Value++;
		Assert.Equal(1, Changed(a)); // a consumes; b hasn't looked

		db.Write<Tracked>(e[0]).Value++;
		db.Write<Tracked>(e[perChunk]).Value++;
		Assert.Equal(2, Changed(a));
		Assert.Equal(2, Changed(b));
		Assert.Equal(0, Changed(a));
		Assert.Equal(0, Changed(b));
	}

	[Fact]
	public void ResetChanges_ThenWrite_IsSeen()
	{
		var (db, e, _) = Create();
		using var _db = db;
		var query = TrackedQuery(db);

		db.Write<Tracked>(e[0]).Value++;
		query.ResetChanges();
		Assert.Equal(0, Changed(query));

		db.Write<Tracked>(e[0]).Value++;
		Assert.Equal(1, Changed(query));
	}

	[Fact]
	public void FilterBuiltAfterAWrite_SeesTheNextWriteToThatChunk()
	{
		var (db, e, _) = Create();
		using var _db = db;

		db.Write<Tracked>(e[0]).Value++;
		var late = TrackedQuery(db); // starts at the current version: the write above is not news to it
		Assert.Equal(0, Changed(late));

		db.Write<Tracked>(e[1]).Value++;
		Assert.Equal(1, Changed(late));
	}

	[Fact]
	public void WriteDuringAPass_ToAnAlreadyVisitedChunk_IsSeenNextPass()
	{
		var (db, e, perChunk) = Create();
		using var _db = db;
		var query = TrackedQuery(db);
		db.Write<Tracked>(e[0]).Value++;
		db.Write<Tracked>(e[perChunk]).Value++;
		db.Write<Tracked>(e[2 * perChunk]).Value++;

		// chunks are visited last to first; write the last chunk once the pass has moved past it
		int visited = 0;
		foreach (var _ in query.ReadHandles<Tracked>())
		{
			if (++visited == 2)
				db.Write<Tracked>(e[2 * perChunk + 1]).Value++;
		}
		Assert.Equal(3, visited);
		Assert.Equal(1, Changed(query));
	}

	[Fact]
	public void CommandBufferSets_InOneChunk_BumpOnce_AndAreSeen()
	{
		var (db, e, perChunk) = Create();
		using var _db = db;
		var query = TrackedQuery(db);
		var before = Global(db);

		var cb = db.CreateCommandBuffer(perChunk);
		for (int i = 0; i < perChunk; i++)
			cb.Set(e[i], new Tracked(7));
		cb.Commit();

		Assert.Equal(before + 1, Global(db));
		Assert.Equal(1, Changed(query));
		Assert.Equal(7, db.Read<Tracked>(e[perChunk - 1]).Value);
	}

	[Fact]
	public void ParallelChunkWrites_MarkEveryChunk_EveryPass()
	{
		var db = new EntityDatabase(new(ChunkBytes, int.MaxValue, 4));
		using var _db = db;
		for (int i = 0; i < 2000; i++)
			db.Create(new Tracked(i), new Plain(i));
		var all = db.QueryBuilder.WithAll<Tracked>().Build();
		var query = TrackedQuery(db);
		int chunks = 0;
		foreach (var _ in all.ReadHandles<Tracked>()) chunks++;
		Assert.True(chunks > 4, $"only {chunks} chunks");

		for (int pass = 0; pass < 3; pass++)
		{
			all.ForEachChunkParallel(static (int length, WriteHandle<Tracked> t) =>
			{
				for (int i = 0; i < length; i++) t[i].Value++;
			});
			Assert.Equal(chunks, Changed(query));
			Assert.Equal(0, Changed(query));
		}
	}
}
