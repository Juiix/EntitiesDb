namespace EntitiesDb;

internal static class FakeDb
{
	// --- Core components already present ---
	public record struct Position(float X, float Y);
	public record struct Health(int Value, int Max);

	// --- Extra components for richer archetypes ---
	public record struct Velocity(float dX, float dY);
	public record struct Mana(int Value, int Max);
	public record struct Stamina(int Value, int Max);
	public record struct Component1(int Value);
	public record struct Component2(int Value);

	// Managed (has a reference)
	public record struct NameTag(string Text);

	// Buffered components (arrays-per-entity; internal capacities chosen to let some stay inline and some promote to heap)
	[Buffer(4)] public record struct InventoryItem(int ItemId, int Count);
	[Buffer(8)] public record struct Damage(int Amount);

	// Tags (zero-size)
	[Tag] public record struct PlayerTag;
	[Tag] public record struct NpcTag;
	[Tag] public record struct EnemyTag;
	[Tag] public record struct BossTag;
	[Tag] public record struct FriendlyTag;
	[Tag] public record struct DeadTag;
	[Tag] public record struct FlyingTag;
	[Tag] public record struct MerchantTag;
	[Tag] public record struct QuestGiverTag;
	[Tag] public record struct GroundedTag;
	[Tag] public record struct ProjectileTag;

	public static EntityDatabase CreateDb(int chunkSize = 4096, int maxEntities = int.MaxValue, bool parallel = false)
	{
		var db = new EntityDatabase(new(chunkSize, maxEntities, parallel ? 2 : -1));

		// --- Seed data across many archetypes -------------------------------

		// Players (inventory stays inline for some, promotes for others)
		db.AddPlayer(1, 1, 0.2f, 0.0f, 10, 10, 8, 10, 5, 8, "Alice",
			new[] { new InventoryItem(1, 2), new InventoryItem(2, 1) }); // len 2 <= cap 4 (inline)
		db.AddPlayer(2, 3, 0.0f, 0.1f, 9, 10, 6, 10, 3, 8, "Bob",
			new[] { new InventoryItem(3, 5), new InventoryItem(4, 1), new InventoryItem(5, 1), new InventoryItem(6, 2), new InventoryItem(7, 1) }); // len 5 > cap 4 (promote)
		db.AddPlayer(5, 5, 0.0f, 0.0f, 12, 12, 9, 12, 7, 12, "Cara",
			new[] { new InventoryItem(8, 1) });

		// Enemy grunts (damage buffers of various sizes)
		db.AddEnemy(10, 1, 5, 5, "Goblin", new[] { new Damage(2), new Damage(1) });
		db.AddEnemy(12, 3, 4, 7, "Orc", new[] { new Damage(3), new Damage(3), new Damage(1), new Damage(2), new Damage(2), new Damage(2), new Damage(1), new Damage(1), new Damage(1) }); // > cap 8
		db.AddEnemy(14, 5, 2, 6, "Slime", Array.Empty<Damage>());

		// Bosses (big damage arrays, guaranteed promotion)
		db.AddBoss(18, 6, 50, 50, 20, 30, "Dragon",
			new[] { new Damage(10), new Damage(12), new Damage(15), new Damage(18), new Damage(20), new Damage(10), new Damage(12), new Damage(15), new Damage(18), new Damage(20), });
		db.AddBoss(22, 8, 60, 60, 25, 40, "Lich",
			new[] { new Damage(8), new Damage(8), new Damage(16), new Damage(16), new Damage(32), new Damage(4), new Damage(4), new Damage(4), new Damage(24), });

		// NPCs
		db.AddNpcMerchant(20, 20, "Vendor A");
		db.AddNpcMerchant(21, 21, "Vendor B");
		db.AddNpcQuestGiver(23, 23, "Questor A");
		db.AddNpcQuestGiver(24, 24, "Questor B");

		// Ghosts / Projectiles / Corpses
		db.AddGhost(30, 10, 0.0f, -0.5f);
		db.AddGhost(32, 12, 0.2f, 0.0f);

		db.AddProjectile(5, 10, 1.0f, 0.0f);
		db.AddProjectile(6, 10, 1.0f, 0.1f);
		db.AddProjectile(7, 10, 1.0f, 0.2f);

		db.AddCorpse(12, 12);
		db.AddCorpse(13, 11);

		// Critters & health-only
		db.AddCritter(1, 1);
		db.AddCritter(2, 3);
		db.AddHealthOnly(99, 99);

		// Movers & empty
		db.AddMover(42, 0);
		db.AddMover(43, 1);
		db.AddEmpty();
		db.AddEmpty();

		return db;
	}

	// --- Archetype builders ---------------------------------------------

	// Players: Position + Velocity + Health + Stamina + Mana + Inventory + PlayerTag + FriendlyTag + NameTag
	public static void AddPlayer(this EntityDatabase db, float x, float y, float dx, float dy, int hp, int hpMax, int stam, int stamMax, int mana, int manaMax, string name, ReadOnlySpan<InventoryItem> inv)
	{
		db.Create(
			new Position(x, y),
			new Velocity(dx, dy),
			new Health(hp, hpMax),
			new Stamina(stam, stamMax),
			new Mana(mana, manaMax),
			new NameTag(name),
			new PlayerTag(),
			new FriendlyTag(),
			inv
		);
	}

	// Enemy grunts: Position + Health + DamageBuffer + EnemyTag + NameTag
	public static void AddEnemy(this EntityDatabase db, float x, float y, int hp, int hpMax, string name, ReadOnlySpan<Damage> dmg)
	{
		db.Create(
			new Position(x, y),
			new Health(hp, hpMax),
			new NameTag(name),
			new EnemyTag(),
			dmg
		);
	}

	// Bosses: Position + Health + Mana + DamageBuffer + EnemyTag + BossTag + NameTag
	public static void AddBoss(this EntityDatabase db, float x, float y, int hp, int hpMax, int mana, int manaMax, string name, ReadOnlySpan<Damage> dmg)
	{
		db.Create(
			new Position(x, y),
			new Health(hp, hpMax),
			new Mana(mana, manaMax),
			new NameTag(name),
			new EnemyTag(),
			new BossTag(),
			dmg
		);
	}

	// NPCs: Position + NpcTag + (Merchant|QuestGiver) + NameTag
	public static void AddNpcMerchant(this EntityDatabase db, float x, float y, string name)
	{
		db.Create(
			new Position(x, y),
			new NameTag(name),
			new NpcTag(),
			new MerchantTag()
		);
	}

	public static void AddNpcQuestGiver(this EntityDatabase db, float x, float y, string name)
	{
		db.Create(
			new Position(x, y),
			new NameTag(name),
			new NpcTag(),
			new QuestGiverTag()
		);
	}

	// Critters: Health + GroundedTag (no Position)
	public static void AddCritter(this EntityDatabase db, int hp, int hpMax)
	{
		db.Create(
			new Health(hp, hpMax),
			new GroundedTag()
		);
	}

	// Ghosts: Position + Velocity + FlyingTag + EnemyTag
	public static void AddGhost(this EntityDatabase db, float x, float y, float dx, float dy)
	{
		db.Create(
			new Position(x, y),
			new Velocity(dx, dy),
			new FlyingTag(),
			new EnemyTag()
		);
	}

	// Projectiles: Position + Velocity + ProjectileTag
	public static void AddProjectile(this EntityDatabase db, float x, float y, float dx, float dy)
	{
		db.Create(
			new Position(x, y),
			new Velocity(dx, dy),
			new ProjectileTag()
		);
	}

	// Corpses: Position + DeadTag
	public static void AddCorpse(this EntityDatabase db, float x, float y)
	{
		db.Create(
			new Position(x, y),
			new DeadTag()
		);
	}

	// Position-only movers
	public static void AddMover(this EntityDatabase db, float x, float y) { db.Create(new Position(x, y)); }

	// Health-only (healers’ pool, structures, etc.)
	public static void AddHealthOnly(this EntityDatabase db, int hp, int hpMax) { db.Create(new Health(hp, hpMax)); }

	// Empty (Signature.Empty)
	public static void AddEmpty(this EntityDatabase db) => db.Create();

	public static void FillPlayers(this EntityDatabase db, float chunks = 4.5f)
	{
		var playerArchetype = db.GetArchetype<Position, Velocity, Health, Stamina, Mana, NameTag, PlayerTag, FriendlyTag, InventoryItem>();
		Assert.NotNull(playerArchetype);

		// fill 4.5 chunks
		while (playerArchetype.EntityCount < playerArchetype.EntitiesPerChunk * chunks)
		{
			db.AddPlayer(1, 1, 0.2f, 0.0f, 10, 10, 8, 10, 5, 8, "PlayerPadding",
				new[] { new InventoryItem(1, 2), new InventoryItem(2, 1) });
		}
	}

	public static void FillTest(this EntityDatabase db, float chunks = 4.5f)
	{
		var bulkCreate = db.GetBulkCreate<Component1, Component2>();
		for (int i = 0; i < 100_000; i++)
		{
			db.Create(in bulkCreate, new Component1(), new Component2(1));
		}
	}

	public static int CountChunks(this Query query)
	{
		int count = 0;
		foreach (var _ in query.ReadHandles<Position>())
		{
			count++;
		}
		return count;
	}

	public static int CountEntities(this Query query)
	{
		int count = 0;
		foreach (var chunk in query.ReadHandles<Position>())
		{
			count += chunk.EntityCount;
		}
		return count;
	}
}
