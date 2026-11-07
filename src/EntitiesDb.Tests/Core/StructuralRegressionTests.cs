namespace EntitiesDb.Core;

/// <summary>
/// Regressions found while optimizing the create / move / command buffer paths.
/// </summary>
public sealed class StructuralRegressionTests
{
	private record struct Value(int V);
	private record struct Other(int V);
	private record struct Name(string Text);
	[Buffer(2)] private record struct ItemA(int V);
	[Buffer(2)] private record struct ItemB(int V);
	[Buffer(2)] private record struct ItemC(int V);

	// Clone held a ref into the entity map while allocating the clone's id. When that allocation grew
	// the map, the old array went back to the pool cleared, so the source slot read as (0, 0) and the
	// clone copied whichever entity sat at chunk 0, row 0.
	[Fact]
	public void Clone_WhenEntityMapGrows_CopiesTheSourceEntity()
	{
		using var db = new EntityDatabase();
		var entities = new Entity[1024]; // the map starts with 1024 references; the clone's id is the 1025th
		for (int i = 0; i < entities.Length; i++)
			entities[i] = db.Create(new Value(i));

		var clone = db.Clone(entities[500]);

		Assert.Equal(500, db.Read<Value>(clone).V);
		Assert.Equal(500, db.Read<Value>(entities[500]).V);
	}

	// Archetype.Dispose only suppressed the finalizer (the one place chunk memory was freed), so every
	// disposed database and every archetype dropped by TrimExcess leaked its chunks.
	[Fact]
	public void Dispose_FreesArchetypeChunks()
	{
		var db = new EntityDatabase();
		for (int i = 0; i < 5000; i++)
			db.Create(new Value(i), (ReadOnlySpan<ItemA>)[new ItemA(1), new ItemA(2), new ItemA(3)]); // heap-backed buffers
		var archetype = db.GetArchetype(db.GetSignature(db.Create(new Value(0), (ReadOnlySpan<ItemA>)[])));
		Assert.True(archetype.ChunksAllocated > 1);

		db.Dispose();

		Assert.Equal(0, archetype.ChunksAllocated);
		Assert.Equal(0, archetype.ChunksInUse);
		Assert.Equal(0, archetype.EntityCount);
	}

	// By-entity access skips the entity map's array bounds check (the live-id count guards it): after
	// Dispose no id may still count as live, or a stale handle would read freed memory.
	[Fact]
	public void Dispose_ThenAccessByEntity_Throws()
	{
		var db = new EntityDatabase();
		var entity = db.Create(new Value(1));
		db.Dispose();

		Assert.False(db.Exists(entity));
		Assert.Throws<EntityException>(() => db.Read<Value>(entity));
		Assert.Throws<EntityException>(() => db.Write<Value>(entity.Id));
	}

	[Fact]
	public void TrimExcess_FreesDroppedArchetype_AndQueriesStillRun()
	{
		using var db = new EntityDatabase();
		var entity = db.Create(new Value(1), new Other(2));
		var archetype = db.GetArchetype(entity);
		var query = db.QueryBuilder.WithAll<Value, Other>().Build();
		Assert.Equal(1, Count(query));

		db.Destroy(entity);
		db.TrimExcess();

		Assert.Equal(0, archetype.ChunksAllocated);
		Assert.Equal(0, Count(query));

		// the signature resolves to a fresh archetype afterwards
		var again = db.Create(new Value(3), new Other(4));
		Assert.NotSame(archetype, db.GetArchetype(again));
		Assert.Equal(1, Count(query));
		Assert.Equal(4, db.Read<Other>(again).V);

		static int Count(Query query)
		{
			int count = 0;
			foreach (var (length, values) in query.ReadHandles<Value>())
				count += length;
			return count;
		}
	}

	// Move documents that components it adds are defaulted, but the row it lands in can still hold a
	// previous occupant's values.
	[Fact]
	public void Move_AddedComponents_AreDefaulted()
	{
		using var db = new EntityDatabase();
		var previous = db.Create(new Value(1), new Other(99));
		db.Destroy(previous); // leaves Other = 99 in the archetype's free row

		var entity = db.Create(new Value(2));
		db.Move(entity, Signature.From<Value, Other>());

		Assert.Equal(2, db.Read<Value>(entity).V);
		Assert.Equal(0, db.Read<Other>(entity).V);
	}

	[Fact]
	public void Move_AddedManagedComponent_IsNull()
	{
		using var db = new EntityDatabase();
		var previous = db.Create(new Value(1), new Name("stale"));
		db.Destroy(previous);

		var entity = db.Create(new Value(2));
		db.Move(entity, Signature.From<Value, Name>());

		Assert.Null(db.Read<Name>(entity).Text);
	}

	// Clear() reset each component store's count but kept its entity -> slot map, so the next round
	// handed two entities the same data slot.
	[Fact]
	public void CommandBuffer_ReusedAfterClear_KeepsValuesApart()
	{
		using var db = new EntityDatabase();
		var a = db.Create(new Value(0));
		var b = db.Create(new Value(0));
		var c = db.Create(new Value(0));
		var buffer = db.CreateCommandBuffer(16);

		buffer.Set(a, new Value(1));
		buffer.Clear();

		buffer.Set(b, new Value(2));
		buffer.Set(c, new Value(3));
		buffer.Commit();

		Assert.Equal(0, db.Read<Value>(a).V);
		Assert.Equal(2, db.Read<Value>(b).V);
		Assert.Equal(3, db.Read<Value>(c).V);
	}

	// Many existing entities (whole id-map pages wiped at reset), then a reuse on a different mix of
	// commands: nothing from the first batch may leak into the second, and passes skipped for having no
	// work (no creates, no changes) must run again once there is some.
	[Fact]
	public void CommandBuffer_ReusedAfterDenseBatch_StartsClean()
	{
		using var db = new EntityDatabase();
		var entities = new Entity[3000];
		for (int i = 0; i < entities.Length; i++)
			entities[i] = db.Create(new Value(0));
		var buffer = db.CreateCommandBuffer(16);

		// 1. destroys only: no create pass, no change pass
		for (int i = 0; i < 1000; i++)
			buffer.Destroy(entities[i]);
		buffer.Commit();
		Assert.Equal(2000, db.EntityCount);

		// 2. sets on the survivors and one create
		for (int i = 1000; i < entities.Length; i++)
			buffer.Set(entities[i], new Value(i));
		var created = buffer.Create(new Value(-1));
		buffer.Commit();
		Assert.Equal(2001, db.EntityCount);
		for (int i = 1000; i < entities.Length; i++)
			Assert.Equal(i, db.Read<Value>(entities[i]).V);

		// 3. a single add on an entity from batch 2: its old entry is gone, so it registers fresh
		buffer.Add(entities[2999], new Other(7));
		buffer.Commit();
		Assert.Equal(2999, db.Read<Value>(entities[2999]).V);
		Assert.Equal(7, db.Read<Other>(entities[2999]).V);
		Assert.False(db.Has<Other>(entities[2998]));
	}

	// A component set on an entity the same buffer destroys was never consumed, leaving the same stale
	// entity -> slot entry behind for the next Commit.
	[Fact]
	public void CommandBuffer_SetThenDestroy_NextCommitKeepsValuesApart()
	{
		using var db = new EntityDatabase();
		var a = db.Create(new Value(0));
		var b = db.Create(new Value(0));
		var c = db.Create(new Value(0));
		var buffer = db.CreateCommandBuffer(16);

		buffer.Set(a, new Value(1));
		buffer.Destroy(a);
		buffer.Commit();

		buffer.Set(b, new Value(2));
		buffer.Set(c, new Value(3));
		buffer.Commit();

		Assert.False(db.Exists(a));
		Assert.Equal(2, db.Read<Value>(b).V);
		Assert.Equal(3, db.Read<Value>(c).V);
	}

	[Fact]
	public void CommandBuffer_SetManagedThenDestroy_NextCommitKeepsValuesApart()
	{
		using var db = new EntityDatabase();
		var a = db.Create(new Name("a"));
		var b = db.Create(new Name("b"));
		var c = db.Create(new Name("c"));
		var buffer = db.CreateCommandBuffer(16);

		buffer.Set(a, new Name("a1"));
		buffer.Destroy(a);
		buffer.Commit();

		buffer.Set(b, new Name("b2"));
		buffer.Set(c, new Name("c3"));
		buffer.Commit();

		Assert.Equal("b2", db.Read<Name>(b).Text);
		Assert.Equal("c3", db.Read<Name>(c).Text);
	}

	// The generated Create overloads for 3+ buffers registered only the first two buffer types.
	[Fact]
	public void CommandBuffer_CreateWithThreeBuffers_HasEveryBuffer()
	{
		using var db = new EntityDatabase();
		var buffer = db.CreateCommandBuffer(16);
		ReadOnlySpan<ItemA> a = [new ItemA(1)];
		ReadOnlySpan<ItemB> b = [new ItemB(2), new ItemB(3)];
		ReadOnlySpan<ItemC> c = [new ItemC(4), new ItemC(5), new ItemC(6)]; // past the inline capacity

		buffer.Create(a, b, c);
		buffer.Commit();

		var archetype = db.GetArchetype(Signature.From<ItemA, ItemB, ItemC>());
		Assert.Equal(1, archetype.EntityCount);
		var query = db.QueryBuilder.WithAll<ItemA, ItemB, ItemC>().Build();
		int found = 0;
		foreach (var (length, aBuffers, bBuffers, cBuffers) in query.ReadHandlesB<ItemA, ItemB, ItemC>())
		{
			for (int i = 0; i < length; i++)
			{
				Assert.Equal(1, aBuffers[i].Length);
				Assert.Equal(2, bBuffers[i].Length);
				Assert.Equal(3, cBuffers[i].Length);
				Assert.Equal(6, cBuffers[i][2].V);
				found++;
			}
		}
		Assert.Equal(1, found);
	}

	// A buffered entity's id maps straight to its command; a placeholder that names no buffered entity
	// (another buffer's, or one from before a Commit) must fail at Commit instead of touching another entity.
	[Fact]
	public void CommandBuffer_UnknownPlaceholder_FailsAtCommit()
	{
		using var db = new EntityDatabase();
		var other = db.CreateCommandBuffer(16);
		other.Create();
		var foreign = other.Create(); // index 1 in the other buffer

		var buffer = db.CreateCommandBuffer(16);
		var mine = buffer.Create(new Value(7)); // index 0 here
		buffer.Set(foreign, new Value(1));

		Assert.Throws<AggregateException>(() => buffer.Commit());
		Assert.Equal(1, db.EntityCount);
		Assert.Equal(1, db.GetArchetype(Signature.From<Value>()).EntityCount);
	}

	[TrackChanges] private record struct Tracked(int V);

	// A Commit marks each written chunk changed once instead of once per value; filters must still see
	// exactly the chunks it wrote, on every Commit.
	[Fact]
	public void CommandBuffer_Set_ChangeFilterSeesWrittenChunksOnly()
	{
		using var db = new EntityDatabase(new EntityDatabaseOptions(chunkByteSize: 256));
		var entities = new Entity[100];
		for (int i = 0; i < entities.Length; i++)
			entities[i] = db.Create(new Tracked(i));
		var archetype = db.GetArchetype(entities[0]);
		Assert.True(archetype.ChunksInUse >= 4);

		// a query built now starts at the current version: nothing has changed for it yet
		var query = db.QueryBuilder.WithAll<Tracked>().WithChangeFilter<Tracked>().Build();
		Assert.Equal(0, query.CountChunks());

		var buffer = db.CreateCommandBuffer(16);
		buffer.Set(entities[0], new Tracked(-1));
		buffer.Set(entities[1], new Tracked(-2)); // same chunk as entities[0]
		buffer.Set(entities[99], new Tracked(-3)); // last chunk
		buffer.Commit();

		Assert.Equal(2, query.CountChunks());
		Assert.Equal(0, query.CountChunks());

		// the next Commit is seen again
		buffer.Set(entities[0], new Tracked(-4));
		buffer.Commit();
		Assert.Equal(1, query.CountChunks());
		Assert.Equal(-4, db.Read<Tracked>(entities[0]).V);
	}

	[Fact]
	public void CommandBuffer_Create_ChangeFilterSeesNewChunks()
	{
		using var db = new EntityDatabase(new EntityDatabaseOptions(chunkByteSize: 256));
		for (int i = 0; i < 100; i++)
			db.Create(new Tracked(i));
		var query = db.QueryBuilder.WithAll<Tracked>().WithChangeFilter<Tracked>().Build();
		query.CountChunks();
		Assert.Equal(0, query.CountChunks());

		var buffer = db.CreateCommandBuffer(16);
		for (int i = 0; i < 50; i++)
			buffer.Create(new Tracked(100 + i));
		buffer.Commit();

		var capacity = db.GetArchetype(Signature.From<Tracked>()).EntitiesPerChunk;
		Assert.Equal(149 / capacity - 100 / capacity + 1, query.CountChunks());
		Assert.Equal(0, query.CountChunks());
	}

	// The buffer is documented thread-safe; parallel jobs record into one buffer at once.
	[Fact]
	public void CommandBuffer_ConcurrentRecording_KeepsEveryCommand()
	{
		using var db = new EntityDatabase();
		const int threads = 8, perThread = 5_000;
		var existing = new Entity[threads * perThread];
		for (int i = 0; i < existing.Length; i++)
			existing[i] = db.Create(new Value(-1));
		var buffer = db.CreateCommandBuffer(64);

		var workers = new Thread[threads];
		for (int t = 0; t < threads; t++)
		{
			int thread = t;
			workers[t] = new Thread(() =>
			{
				for (int i = 0; i < perThread; i++)
				{
					int n = thread * perThread + i;
					var created = buffer.Create(new Value(n));
					buffer.Set(created, new Other(n));
					buffer.Set(existing[n], new Value(n));
				}
			});
		}
		foreach (var worker in workers) worker.Start();
		foreach (var worker in workers) worker.Join();
		buffer.Commit();

		Assert.Equal(existing.Length * 2, db.EntityCount);
		for (int n = 0; n < existing.Length; n++)
			Assert.Equal(n, db.Read<Value>(existing[n]).V);

		var createdArchetype = db.GetArchetype(Signature.From<Value, Other>());
		Assert.Equal(existing.Length, createdArchetype.EntityCount);
		var seen = new bool[existing.Length];
		foreach (ref readonly var chunk in createdArchetype)
		{
			for (int row = 0; row < chunk.EntityCount; row++)
			{
				var v = chunk.Read<Value>(row).V;
				Assert.Equal(v, chunk.Read<Other>(row).V);
				Assert.False(seen[v]);
				seen[v] = true;
			}
		}
	}

	// Buffered creates, sets on created entities and sets on existing entities all land in one Commit.
	[Fact]
	public void CommandBuffer_CreatesAndExistingEntities_RoundTripValues()
	{
		using var db = new EntityDatabase();
		var existing = new Entity[300];
		for (int i = 0; i < existing.Length; i++)
			existing[i] = db.Create(new Value(-1));

		var buffer = db.CreateCommandBuffer(4);
		var created = new Entity[300];
		for (int i = 0; i < created.Length; i++)
		{
			created[i] = buffer.Create(new Value(i));
			if (i % 3 == 0) buffer.Set(created[i], new Other(i * 2));
			buffer.Set(existing[i], new Value(i + 1000));
			if (i % 2 == 0) buffer.Add(existing[i], new Other(i));
			if (i % 5 == 0) buffer.Destroy(existing[i]);
		}
		buffer.Commit();

		Assert.Equal(300 + 300 - 60, db.EntityCount);
		for (int i = 0; i < existing.Length; i++)
		{
			if (i % 5 == 0)
			{
				Assert.False(db.Exists(existing[i]));
				continue;
			}
			Assert.Equal(i + 1000, db.Read<Value>(existing[i]).V);
			Assert.Equal(i % 2 == 0, db.Has<Other>(existing[i]));
			if (i % 2 == 0) Assert.Equal(i, db.Read<Other>(existing[i]).V);
		}

		var withOther = db.GetArchetype(Signature.From<Value, Other>());
		var valueOnly = db.GetArchetype(Signature.From<Value>());
		int seen = 0;
		foreach (var archetype in new[] { withOther, valueOnly })
		{
			foreach (ref readonly var chunk in archetype)
			{
				for (int row = 0; row < chunk.EntityCount; row++)
				{
					var v = chunk.Read<Value>(row).V;
					if (v >= 1000) continue; // an existing entity
					seen++;
					Assert.Equal(v % 3 == 0, archetype == withOther);
					if (v % 3 == 0) Assert.Equal(v * 2, chunk.Read<Other>(row).V);
				}
			}
		}
		Assert.Equal(300, seen);
	}
}
