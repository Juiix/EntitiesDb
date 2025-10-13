using static EntitiesDb.FakeDb;

namespace EntitiesDb.Queries;

public sealed class SrouceGenQueryTests
{
	[Fact]
	public void Query_WithPositionHealth_NoEnemy()
	{
		using var db = CreateDb();
		var query = db.QueryBuilder.WithAll<Position, Health>()
			.WithNone<EnemyTag>()
			.Build();

		query.ForEach((Entity entity, in Position position, in Health health) =>
		{
			Assert.InRange(entity.Id, 0, 2);
			switch (entity.Id)
			{
				case 0:
					Assert.Equal(new Position(1, 1), position);
					Assert.Equal(new Health(10, 10), health);
					break;
				case 1:
					Assert.Equal(new Position(2, 3), position);
					Assert.Equal(new Health(9, 10), health);
					break;
				case 2:
					Assert.Equal(new Position(5, 5), position);
					Assert.Equal(new Health(12, 12), health);
					break;
			}
		});
	}

	[Fact]
	public void Query_WithOnly_Health_ExactlyHealthOnlyArchetype()
	{
		using var db = CreateDb();

		// Only entities whose signature is exactly {Health}
		var query = db.QueryBuilder
			.WithOnly<Health>()
			.Build();

		var healthId = db.ComponentRegistry.GetId<Health>();
		var results = new List<(int Id, Health Health)>();
		query.ForEach((Entity e, in Health h, ref List<(int Id, Health Health)> results) =>
		{
			results.Add((e.Id, h));
		}, ref results);

		// Seeded DB has exactly one Health-only entity: id 21 with (99,99)
		Assert.Single(results);
		Assert.Equal(21, results[0].Id);
		Assert.Equal(new Health(99, 99), results[0].Health);
	}

	[Fact]
	public void Query_WithAll_Position_WithNone_Velocity_NoVelocityMoversEtc()
	{
		using var db = CreateDb();

		// Must have Position, must NOT have Velocity
		var query = db.QueryBuilder
			.WithAll<Position>()
			.WithNone<Velocity>()
			.Build();

		var results = new List<int>();
		query.ForEach((Entity e, in Position p, ref List<int> results) =>
		{
			results.Add(e.Id);
		}, ref results);

		// Expected: Enemies(3..5), Bosses(6..7), NPCs(8..11), Corpses(17..18), Movers(22..23)
		// Excluded: Players(0..2), Ghosts(12..13), Projectiles(14..16) since they have Velocity
		var expected = new HashSet<int> { 3, 4, 5, 6, 7, 8, 9, 10, 11, 17, 18, 22, 23 };
		Assert.True(expected.SetEquals(results), $"Got [{string.Join(",", results)}]");
	}

	[Fact]
	public void Query_WithOnly_Position_OnlyPositionMovers()
	{
		using var db = CreateDb();

		// Exactly {Position} signature (the two movers)
		var query = db.QueryBuilder
			.WithOnly<Position>()
			.Build();

		var positions = new Dictionary<int, Position>();
		query.ForEach((Entity e, in Position p, ref Dictionary<int, Position> positions) =>
		{
			positions[e.Id] = p;
		}, ref positions);

		// Movers are ids 22 -> (42,0) and 23 -> (43,1)
		Assert.Equal(2, positions.Count);
		Assert.Equal(new Position(42, 0), positions[22]);
		Assert.Equal(new Position(43, 1), positions[23]);
	}

	[Fact]
	public void Query_NpcQuestGivers_WithAllNpc_WithNoneMerchant()
	{
		using var db = CreateDb();

		// All NPCs except merchants => Quest givers only
		var query = db.QueryBuilder
			.WithAll<NpcTag>()
			.WithNone<MerchantTag>()
			.Build();

		var found = new Dictionary<int, (Position Pos, string Name)>();
		query.ForEach((Entity e, in Position p, in NameTag nt, ref Dictionary<int, (Position Pos, string Name)> found) =>
		{
			found[e.Id] = (p, nt.Text);
		}, ref found);

		// Quest givers are ids 10 and 11 at (23,23) and (24,24)
		Assert.Equal(2, found.Count);
		Assert.True(found.ContainsKey(10) && found.ContainsKey(11));
		Assert.Equal(new Position(23, 23), found[10].Pos);
		Assert.Equal("Questor A", found[10].Name);
		Assert.Equal(new Position(24, 24), found[11].Pos);
		Assert.Equal("Questor B", found[11].Name);
	}

	[Fact]
	public void Query_EnemiesButNotBosses_WithAllEnemy_WithNoneBoss()
	{
		using var db = CreateDb();

		// Enemy-tagged entities that are not bosses
		var query = db.QueryBuilder
			.WithAll<EnemyTag>()
			.WithNone<BossTag>()
			.Build();

		var ids = new List<int>();
		query.ForEach((Entity e, ref List<int> ids) =>
		{
			ids.Add(e.Id);
		}, ref ids);

		var names = new List<string>();
		query.ForEach((Entity e, in NameTag nt, ref List<string> names) =>
		{
			names.Add(nt.Text);
		}, ref names);

		// Expected: Enemy grunts (3,4,5) and Ghosts (12,13). Bosses (6,7) excluded.
		Assert.True(new HashSet<int> { 3, 4, 5, 12, 13 }.SetEquals(ids), $"Got [{string.Join(",", ids)}]");
		Assert.Contains("Goblin", names);
		Assert.Contains("Orc", names);
		Assert.Contains("Slime", names);
	}

	[Fact]
	public void Query_WithOnly_NameTag_NoEntityHasOnlyName()
	{
		using var db = CreateDb();

		// No archetype contains only NameTag
		var query = db.QueryBuilder
			.WithOnly<NameTag>()
			.Build();

		var count = 0;
		query.ForEach((ref int count) =>
		{
			count++;
		}, ref count);

		Assert.Equal(0, count);
	}

	[Fact]
	public void Query_PlayerInventories_WithBufferHandle_LengthsAndSomeContents()
	{
		using var db = CreateDb();

		// Select Players (they all have InventoryItem[] buffer)
		var query = db.QueryBuilder
			.WithAll<PlayerTag>()
			.Build();

		var lengths = new Dictionary<int, int>();
		query.ForEach((Entity e, DynamicBuffer<InventoryItem> inv, ref Dictionary<int, int> lengths) =>
		{
			lengths[e.Id] = inv.Length;

			// Spot-check content we know from the seed data:
			// Player 0 (Alice): 2 items => (1,2), (2,1)
			if (e.Id == 0)
			{
				Assert.Equal(2, inv.Length);
				Assert.Equal(new InventoryItem(1, 2), inv[0]);
				Assert.Equal(new InventoryItem(2, 1), inv[1]);
			}

			// Player 2 (Cara): 1 item => (8,1)
			if (e.Id == 2)
			{
				Assert.Equal(1, inv.Length);
				Assert.Equal(new InventoryItem(8, 1), inv[0]);
			}
		}, ref lengths);

		// Inventories are seeded as: id 0 -> 2 items, id 1 -> 5 items (promoted), id 2 -> 1 item
		Assert.Equal(3, lengths.Count);
		Assert.Equal(2, lengths[0]);
		Assert.Equal(5, lengths[1]); // > [Buffered(4)] => promotion path
		Assert.Equal(1, lengths[2]);
	}

	[Fact]
	public void Query_EnemyDamage_WithBufferHandle_LengthsForGoblinAndSlime()
	{
		using var db = CreateDb();

		// Non-boss enemies (have Damage[] buffer)
		var query = db.QueryBuilder
			.WithAll<Damage, EnemyTag>()
			.WithNone<BossTag>()
			.Build();

		var counts = new Dictionary<int, int>();
		query.ForEach((Entity e, DynamicBuffer<Damage> dmg, ref Dictionary<int, int> counts) =>
		{
			counts[e.Id] = dmg.Length;

			// Spot-check specifics that are unambiguous in the seed:
			// Goblin (id 3) => 2 hits recorded
			if (e.Id == 3)
			{
				Assert.Equal(2, dmg.Length);
			}
			// Slime (id 5) => empty damage history
			if (e.Id == 5)
			{
				Assert.Equal(0, dmg.Length);
			}
		}, ref counts);

		Assert.True(counts.ContainsKey(3) && counts[3] == 2);
		Assert.True(counts.ContainsKey(5) && counts[5] == 0);
	}

	[Fact]
	public void Query_BossDamage_ReadOnlyBufferHandle_PromotedSizedBuffers()
	{
		using var db = CreateDb();

		// Bosses have big Damage[] (> Buffered(8)) so they promote
		var query = db.QueryBuilder
			.WithAll<BossTag>()
			.Build();

		var seenAny = false;
		query.ForEach((Entity e, DynamicBuffer<Damage> dmg, ref bool seenAny) =>
		{
			seenAny = true;
			// We don't rely on the exact count, only that bosses carry a "large" buffer.
			// Buffered attribute for Damage is 8, so ensure bosses exceed that to catch promotion paths.
			Assert.True(dmg.Length > 8, $"Boss {e.Id} should have > 8 damage entries");
		}, ref seenAny);

		Assert.True(seenAny);
	}

	[Fact]
	public void Query_Parallel_Test()
	{
		using var db = CreateDb(true);
		var query = db.QueryBuilder
			.WithAll<Health, Position>()
			.Build();

		int count = 0;
		query.ForEachParallel((Entity entity, in Health health, in Position position, ref int count) =>
		{

		}, ref count);

		query.ForEachChunkParallel((int length, ReadOnlyHandle<Entity> entities, Handle<Health> healths, Handle<Position> positions, ref int count) =>
		{

		}, ref count);

		query.ForEachChunk((int length, ReadOnlyHandle<Entity> entities, Handle<Health> healths, Handle<Position> positions, ref int count) =>
		{

		}, ref count);
	}

	private struct ParallelTest(Ids<Health, Position> ids) : IChunkJob
	{
		private readonly Ids<Health, Position> _ids = ids;
		private Offsets<Health, Position> _offsets;

		public void Enter(Archetype archetype)
		{
			_offsets = archetype.GetOffsets(in _ids);
		}

		public void ForEach(in Chunk chunk)
		{
			/*
			var length = chunk.EntityCount;
			var alignedLength = length - (length & 7);
			var handleA = chunk.GetHandle(_offsets.T0);
			var handleB = chunk.GetHandle(_offsets.T1);
			var simdHandleA = handleA.Reinterpret<Component1, Vector256<int>>();
			var simdHandleB = handleB.Reinterpret<Component2, Vector256<int>>();
			var simdLength = alignedLength / 8;
			for (int i = 0; i < simdLength; i++)
			{
				simdHandleA[i] += simdHandleB[i];
			}

			for (int i = alignedLength; i < length; i++)
			{
				handleA[i].Value += handleB[i].Value;
			}
			*/
		}
	}
}
