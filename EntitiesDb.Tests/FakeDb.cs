using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDb;

internal static class FakeDb
{
	// --- Core components already present ---
	private record struct Position(float X, float Y);
	private record struct Health(int Value, int Max);

	// --- Extra components for richer archetypes ---
	private record struct Velocity(float dX, float dY);
	private record struct Mana(int Value, int Max);
	private record struct Stamina(int Value, int Max);

	// Managed (has a reference)
	private record struct NameTag(string Text);

	// Buffered components (arrays-per-entity; internal capacities chosen to let some stay inline and some promote to heap)
	[Buffered(4)] private record struct InventoryItem(int ItemId, int Count);
	[Buffered(8)] private record struct Damage(int Amount);

	// Tags (zero-size)
	[ZeroSize] private record struct PlayerTag;
	[ZeroSize] private record struct NpcTag;
	[ZeroSize] private record struct EnemyTag;
	[ZeroSize] private record struct BossTag;
	[ZeroSize] private record struct FriendlyTag;
	[ZeroSize] private record struct DeadTag;
	[ZeroSize] private record struct FlyingTag;
	[ZeroSize] private record struct MerchantTag;
	[ZeroSize] private record struct QuestGiverTag;
	[ZeroSize] private record struct GroundedTag;
	[ZeroSize] private record struct ProjectileTag;

	// NOTE: If your EntityDatabase ctor is (ComponentRegistry, chunkBytes, maxEntities), use the commented line.
	private static EntityDatabase CreateDb()
	{
		// var db = new EntityDatabase(new ComponentRegistry(), 4096, 1000);
		var db = new EntityDatabase(4096, 1000);

		// --- Helpers ---------------------------------------------------------
		Entity New() => db.CreateEntity();

		void Add<T>(in Entity e, T c) where T : struct => db.AddComponent<T>(e.Id, c);
		void Tag<T>(in Entity e) where T : struct => db.AddComponent<T>(e.Id);

		void Buf<T>(in Entity e, params T[] items) where T : unmanaged
			=> db.AddBuffer<T>(e.Id, items);

		// --- Archetype builders ---------------------------------------------

		// Players: Position + Velocity + Health + Stamina + Mana + Inventory + PlayerTag + FriendlyTag + NameTag
		void AddPlayer(float x, float y, float dx, float dy, int hp, int hpMax, int stam, int stamMax, int mana, int manaMax, string name, InventoryItem[] inv)
		{
			var e = New();
			Add(e, new Position(x, y));
			Add(e, new Velocity(dx, dy));
			Add(e, new Health(hp, hpMax));
			Add(e, new Stamina(stam, stamMax));
			Add(e, new Mana(mana, manaMax));
			Add(e, new NameTag(name));
			Tag<PlayerTag>(e);
			Tag<FriendlyTag>(e);
			Buf(e, inv);
		}

		// Enemy grunts: Position + Health + DamageBuffer + EnemyTag + NameTag
		void AddEnemy(float x, float y, int hp, int hpMax, string name, Damage[] dmg)
		{
			var e = New();
			Add(e, new Position(x, y));
			Add(e, new Health(hp, hpMax));
			Add(e, new NameTag(name));
			Tag<EnemyTag>(e);
			Buf(e, dmg);
		}

		// Bosses: Position + Health + Mana + DamageBuffer + EnemyTag + BossTag + NameTag
		void AddBoss(float x, float y, int hp, int hpMax, int mana, int manaMax, string name, Damage[] dmg)
		{
			var e = New();
			Add(e, new Position(x, y));
			Add(e, new Health(hp, hpMax));
			Add(e, new Mana(mana, manaMax));
			Add(e, new NameTag(name));
			Tag<EnemyTag>(e);
			Tag<BossTag>(e);
			Buf(e, dmg);
		}

		// NPCs: Position + NpcTag + (Merchant|QuestGiver) + NameTag
		void AddNpcMerchant(float x, float y, string name)
		{
			var e = New();
			Add(e, new Position(x, y));
			Add(e, new NameTag(name));
			Tag<NpcTag>(e);
			Tag<MerchantTag>(e);
		}

		void AddNpcQuestGiver(float x, float y, string name)
		{
			var e = New();
			Add(e, new Position(x, y));
			Add(e, new NameTag(name));
			Tag<NpcTag>(e);
			Tag<QuestGiverTag>(e);
		}

		// Critters: Health + GroundedTag (no Position)
		void AddCritter(int hp, int hpMax)
		{
			var e = New();
			Add(e, new Health(hp, hpMax));
			Tag<GroundedTag>(e);
		}

		// Ghosts: Position + Velocity + FlyingTag + EnemyTag
		void AddGhost(float x, float y, float dx, float dy)
		{
			var e = New();
			Add(e, new Position(x, y));
			Add(e, new Velocity(dx, dy));
			Tag<FlyingTag>(e);
			Tag<EnemyTag>(e);
		}

		// Projectiles: Position + Velocity + ProjectileTag
		void AddProjectile(float x, float y, float dx, float dy)
		{
			var e = New();
			Add(e, new Position(x, y));
			Add(e, new Velocity(dx, dy));
			Tag<ProjectileTag>(e);
		}

		// Corpses: Position + DeadTag
		void AddCorpse(float x, float y)
		{
			var e = New();
			Add(e, new Position(x, y));
			Tag<DeadTag>(e);
		}

		// Position-only movers
		void AddMover(float x, float y) { var e = New(); Add(e, new Position(x, y)); }

		// Health-only (healers’ pool, structures, etc.)
		void AddHealthOnly(int hp, int hpMax) { var e = New(); Add(e, new Health(hp, hpMax)); }

		// Empty (Signature.Empty)
		void AddEmpty() => New();

		// --- Seed data across many archetypes -------------------------------

		// Players (inventory stays inline for some, promotes for others)
		AddPlayer(1, 1, 0.2f, 0.0f, 10, 10, 8, 10, 5, 8, "Alice",
			new[] { new InventoryItem(1, 2), new InventoryItem(2, 1) }); // len 2 <= cap 4 (inline)
		AddPlayer(2, 3, 0.0f, 0.1f, 9, 10, 6, 10, 3, 8, "Bob",
			new[] { new InventoryItem(3, 5), new InventoryItem(4, 1), new InventoryItem(5, 1), new InventoryItem(6, 2), new InventoryItem(7, 1) }); // len 5 > cap 4 (promote)
		AddPlayer(5, 5, 0.0f, 0.0f, 12, 12, 9, 12, 7, 12, "Cara",
			new[] { new InventoryItem(8, 1) });

		// Enemy grunts (damage buffers of various sizes)
		AddEnemy(10, 1, 5, 5, "Goblin", new[] { new Damage(2), new Damage(1) });
		AddEnemy(12, 3, 4, 7, "Orc", new[] { new Damage(3), new Damage(3), new Damage(1), new Damage(2), new Damage(2), new Damage(2), new Damage(1), new Damage(1), new Damage(1) }); // > cap 8
		AddEnemy(14, 5, 2, 6, "Slime", Array.Empty<Damage>());

		// Bosses (big damage arrays, guaranteed promotion)
		AddBoss(18, 6, 50, 50, 20, 30, "Dragon",
			new[] { new Damage(10), new Damage(12), new Damage(15), new Damage(18), new Damage(20), new Damage(10), new Damage(12), new Damage(15), new Damage(18), new Damage(20), });
		AddBoss(22, 8, 60, 60, 25, 40, "Lich",
			new[] { new Damage(8), new Damage(8), new Damage(16), new Damage(16), new Damage(32), new Damage(4), new Damage(4), new Damage(4), });

		// NPCs
		AddNpcMerchant(20, 20, "Vendor A");
		AddNpcMerchant(21, 21, "Vendor B");
		AddNpcQuestGiver(23, 23, "Questor A");
		AddNpcQuestGiver(24, 24, "Questor B");

		// Ghosts / Projectiles / Corpses
		AddGhost(30, 10, 0.0f, -0.5f);
		AddGhost(32, 12, 0.2f, 0.0f);

		AddProjectile(5, 10, 1.0f, 0.0f);
		AddProjectile(6, 10, 1.0f, 0.1f);
		AddProjectile(7, 10, 1.0f, 0.2f);

		AddCorpse(12, 12);
		AddCorpse(13, 11);

		// Critters & health-only
		AddCritter(1, 1);
		AddCritter(2, 3);
		AddHealthOnly(99, 99);

		// Movers & empty
		AddMover(42, 0);
		AddMover(43, 1);
		AddEmpty();
		AddEmpty();

		return db;
	}
}
