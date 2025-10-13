using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

	// Managed (has a reference)
	public record struct NameTag(string Text);

	// Buffered components (arrays-per-entity; internal capacities chosen to let some stay inline and some promote to heap)
	[Buffered(4)] public record struct InventoryItem(int ItemId, int Count);
	[Buffered(8)] public record struct Damage(int Amount);

	// Tags (zero-size)
	[ZeroSize] public record struct PlayerTag;
	[ZeroSize] public record struct NpcTag;
	[ZeroSize] public record struct EnemyTag;
	[ZeroSize] public record struct BossTag;
	[ZeroSize] public record struct FriendlyTag;
	[ZeroSize] public record struct DeadTag;
	[ZeroSize] public record struct FlyingTag;
	[ZeroSize] public record struct MerchantTag;
	[ZeroSize] public record struct QuestGiverTag;
	[ZeroSize] public record struct GroundedTag;
	[ZeroSize] public record struct ProjectileTag;

	// NOTE: If your EntityDatabase ctor is (ComponentRegistry, chunkBytes, maxEntities), use the commented line.
	public static EntityDatabase CreateDb(bool parallel = false)
	{
		// var db = new EntityDatabase(new ComponentRegistry(), 4096, 1000);
		var db = new EntityDatabase(new(4096, 1_000_000, parallel ? Environment.ProcessorCount : -1));

		// --- Archetype builders ---------------------------------------------

		// Players: Position + Velocity + Health + Stamina + Mana + Inventory + PlayerTag + FriendlyTag + NameTag
		void AddPlayer(float x, float y, float dx, float dy, int hp, int hpMax, int stam, int stamMax, int mana, int manaMax, string name, ReadOnlySpan<InventoryItem> inv)
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
		void AddEnemy(float x, float y, int hp, int hpMax, string name, ReadOnlySpan<Damage> dmg)
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
		void AddBoss(float x, float y, int hp, int hpMax, int mana, int manaMax, string name, ReadOnlySpan<Damage> dmg)
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
		void AddNpcMerchant(float x, float y, string name)
		{
			db.Create(
				new Position(x, y),
				new NameTag(name),
				new NpcTag(),
				new MerchantTag()
			);
		}

		void AddNpcQuestGiver(float x, float y, string name)
		{
			db.Create(
				new Position(x, y),
				new NameTag(name),
				new NpcTag(),
				new QuestGiverTag()
			);
		}

		// Critters: Health + GroundedTag (no Position)
		void AddCritter(int hp, int hpMax)
		{
			db.Create(
				new Health(hp, hpMax),
				new GroundedTag()
			);
		}

		// Ghosts: Position + Velocity + FlyingTag + EnemyTag
		void AddGhost(float x, float y, float dx, float dy)
		{
			db.Create(
				new Position(x, y),
				new Velocity(dx, dy),
				new FlyingTag(),
				new EnemyTag()
			);
		}

		// Projectiles: Position + Velocity + ProjectileTag
		void AddProjectile(float x, float y, float dx, float dy)
		{
			db.Create(
				new Position(x, y),
				new Velocity(dx, dy),
				new ProjectileTag()
			);
		}

		// Corpses: Position + DeadTag
		void AddCorpse(float x, float y)
		{
			db.Create(
				new Position(x, y),
				new DeadTag()
			);
		}

		// Position-only movers
		void AddMover(float x, float y) { db.Create(new Position(x, y)); }

		// Health-only (healers’ pool, structures, etc.)
		void AddHealthOnly(int hp, int hpMax) { db.Create(new Health(hp, hpMax)); }

		// Empty (Signature.Empty)
		void AddEmpty() => db.Create();

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
			new[] { new Damage(8), new Damage(8), new Damage(16), new Damage(16), new Damage(32), new Damage(4), new Damage(4), new Damage(4), new Damage(24), });

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

		if (parallel)
		{
			for (int i = 0; i < 100_000; i++)
			{
				AddPlayer(1, 1, 0.2f, 0.0f, 10, 10, 8, 10, 5, 8, "Alice",
					new[] { new InventoryItem(1, 2), new InventoryItem(2, 1) }); // len 2 <= cap 4 (inline)
			}
		}

		return db;
	}
}
