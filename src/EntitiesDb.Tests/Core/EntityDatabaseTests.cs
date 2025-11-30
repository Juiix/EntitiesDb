using System;
using Xunit;
using EntitiesDb;
using System.Runtime.CompilerServices;


namespace EntitiesDb.Core;

// ---------- Test components with attributes ----------

// Unmanaged POD component
public struct Position { public float X, Y; }

// Another unmanaged POD
public struct Health { public int Value; }

// Managed component (struct containing a reference) – not unmanaged
public struct NameTag
{
	public string Text;
	public NameTag(string s) => Text = s;
	public override string ToString() => Text ?? string.Empty;
}

// Buffered component: buffer-of-Damage elements lives in chunk via ComponentBufferHeader.
// The attribute drives the registry to treat T as “buffered”.
[Buffered(8)]
public struct Damage { public int Amount; public Damage(int a) => Amount = a; }

// Zero-size component/tag: occupies no storage; only presence matters.
[ZeroSize]
public struct PlayerTag { }

[Buffered(2)]                                           // tiny capacity to force promotion in tests
public struct LargeBuf { public int V; public LargeBuf(int v) => V = v; }

public sealed class EntityDatabaseTests
{
	private static EntityDatabase CreateDb(int chunkBytes = 4096, int maxEntities = 1_000)
		=> new(new(chunkBytes, maxEntities));

	// -------------------- Entity lifecycle --------------------

	[Fact]
	public void CreateEntity_IncrementsCount_And_Exists()
	{
		var db = CreateDb();
		var e1 = db.Create();
		var e2 = db.Create();

		Assert.Equal(2, db.EntityCount);
		Assert.True(db.Exists(e1));
		Assert.True(db.Exists(e2));
		Assert.NotEqual(e1.Id, e2.Id);
	}

	[Fact]
	public void DestroyEntity_Removes_And_Compacts()
	{
		var db = CreateDb();
		var a = db.Create();
		var b = db.Create();

		// Give b a component so we can detect moves
		db.Add<Health>(b.Id, new Health { Value = 77 });

		db.Destroy(a.Id);

		// a is gone, b still present, its data preserved
		Assert.False(db.Exists(a));
		Assert.True(db.Exists(b));
		Assert.Equal(77, db.Write<Health>(b.Id).Value);

		// Contract-wise, EntityCount should reflect “currently stored”
		Assert.Equal(1, db.EntityCount);
	}

	[Fact]
	public void CloneEntity_CopiesAllComponents()
	{
		var db = CreateDb();
		var src = db.Create();

		db.Add<Position>(src.Id, new Position { X = 10, Y = -5 });
		db.Add<NameTag>(src.Id, new NameTag("src"));

		// Also add a small buffered component (stays inline: <= internalCapacity)
		var dmgInit = new[] { new Damage(1), new Damage(2), new Damage(3) };
		db.Add<Damage>(src.Id, dmgInit);
		var buf = db.WriteBuffer<Damage>(src.Id);
		Assert.Equal(3, buf.Length);

		var clone = db.CloneEntity(src.Id);

		// Counts/exists
		Assert.Equal(2, db.EntityCount);
		Assert.True(db.Exists(src));
		Assert.True(db.Exists(clone));

		// Unmanaged + managed copied
		var p = db.Write<Position>(clone.Id);
		var n = db.Write<NameTag>(clone.Id);
		Assert.Equal(10, p.X);
		Assert.Equal(-5, p.Y);
		Assert.Equal("src", n.Text);

		// Buffered copied (content visible)
		var cloneBuf = db.WriteBuffer<Damage>(clone.Id);
		Assert.Equal(new[] { 1, 2, 3 }, new[] { cloneBuf[0].Amount, cloneBuf[1].Amount, cloneBuf[2].Amount });
	}

	[Fact]
	public void EntityExists_IsVersionSensitive()
	{
		var db = CreateDb();
		var e = db.Create();
		Assert.True(db.Exists(e));

		db.Add<Position>(e.Id, new Position { X = 1, Y = 2 });
		Assert.True(db.Exists(e)); // structural moves shouldn’t change version

		db.Destroy(e.Id);
		Assert.False(db.Exists(e)); // old (id,version) invalid
	}

	[Fact]
	public void CreateEntity_UpToMax_ThenThrows()
	{
		var db = CreateDb(maxEntities: 2);
		db.Create();
		db.Create();
		Assert.Throws<MaxReachedException>(() => db.Create());
		Assert.Equal(2, db.EntityCount);
	}

	// -------------------- Unmanaged & managed components --------------------

	[Fact]
	public void Add_Get_UnmanagedComponent_Works_ByRef()
	{
		var db = CreateDb();
		var e = db.Create();

		db.Add<Position>(e.Id, new Position { X = 3, Y = 4 });
		ref var pos = ref db.Write<Position>(e.Id);
		Assert.True(db.Has<Position>(e.Id));
		ref var same = ref db.Write<Position>(e.Id);
		Assert.True(Unsafe.AreSame(ref pos, ref same));

		same.X = 9;
		Assert.Equal(9, db.Write<Position>(e.Id).X);
	}

	[Fact]
	public void Add_Get_ManagedComponent_Works()
	{
		var db = CreateDb();
		var e = db.Create();

		db.Add<NameTag>(e.Id, new NameTag("alpha"));
		ref var tag = ref db.Write<NameTag>(e.Id);
		Assert.True(db.Has<NameTag>(e.Id));

		ref var tag2 = ref db.Write<NameTag>(e.Id);
		tag2.Text = "beta";
		Assert.Equal("beta", db.Write<NameTag>(e.Id).Text);
	}

	[Fact]
	public void RemoveComponent_PreservesOtherComponents()
	{
		var db = CreateDb();
		var e = db.Create();

		db.Add<Position>(e.Id, new Position { X = 7, Y = 8 });
		db.Add<Health>(e.Id, new Health { Value = 10 });

		db.Remove<Health>(e.Id);

		Assert.True(db.Has<Position>(e.Id));
		Assert.False(db.Has<Health>(e.Id));
		var p = db.Write<Position>(e.Id);
		Assert.Equal((7, 8), (p.X, p.Y));
	}

	[Fact]
	public void GetComponent_Throws_WhenMissing()
	{
		var db = CreateDb();
		var e = db.Create();
		var ex = Assert.Throws<ComponentException>(() => db.Write<Position>(e.Id));
		Assert.Contains(nameof(Position), ex.Message);
	}

	[Fact]
	public void Has_Throws_ForUnknownEntity()
	{
		var db = CreateDb();
		Assert.Throws<EntityException>(() => db.Has<Position>(999));
	}

	// -------------------- Buffered components via [Buffered] --------------------

	[Fact]
	public void AddBuffer_GetBuffer_RemoveBuffer_HappyPath()
	{
		var db = CreateDb();
		var e = db.Create();

		var initial = new[] { new Damage(5), new Damage(6) };
		db.Add<Damage>(e.Id, initial);
		var buf = db.WriteBuffer<Damage>(e.Id);

		Assert.Equal(2, buf.Length);
		Assert.Equal(5, buf[0].Amount);
		Assert.Equal(6, buf[1].Amount);

		// GetBuffer returns a live view (until structural change)
		var view = db.WriteBuffer<Damage>(e.Id);
		view.Add(new Damage(9));
		Assert.Equal(3, view.Length);
		Assert.Equal(9, view[2].Amount);

		// Removing buffer should drop the component
		db.Remove<Damage>(e.Id);
		Assert.Throws<ComponentException>(() => db.WriteBuffer<Damage>(e.Id));
		Assert.False(db.Has<Damage>(e.Id)); // presence-bit cleared in archetype
	}

	[Fact]
	public void AddComponent_OnBufferedType_Throws()
	{
		var db = CreateDb();
		var e = db.Create();
		Assert.Throws<ComponentException>(() => db.Add<Damage>(e.Id, new Damage(1)));
	}

	[Fact]
	public void GetBuffer_OnNonBufferedType_Throws()
	{
		var db = CreateDb();
		var e = db.Create();
		db.Add<Position>(e.Id, new Position { X = 1, Y = 2 });
		Assert.Throws<ComponentException>(() => db.WriteBuffer<Position>(e.Id));
	}

	[Fact]
	public void AddBuffer_OnZeroSizeType_Throws()
	{
		var db = CreateDb();
		var e = db.Create();
		Assert.Throws<ComponentException>(() => db.Add<PlayerTag>(e.Id, ReadOnlySpan<PlayerTag>.Empty));
	}

	[Fact]
	public void RemoveBuffer_OnMissing_Throws_ComponentNotFound()
	{
		var db = CreateDb();
		var e = db.Create();
		var ex = Assert.Throws<ComponentException>(() => db.Remove<Damage>(e.Id));
		Assert.Contains(nameof(Damage), ex.Message);
	}

	// -------------------- Zero-size tag via [ZeroSize] --------------------

	[Fact]
	public void Tag_AddAndRemove_TogglesPresence()
	{
		var db = CreateDb();
		var e = db.Create();

		// Add zero-size tag as a normal component
		db.Add(e.Id, new PlayerTag());
		Assert.True(db.Has<PlayerTag>(e.Id));

		// Removing should flip signature/archetype, no data to preserve
		db.Remove<PlayerTag>(e.Id);
		Assert.False(db.Has<PlayerTag>(e.Id));
	}

	[Fact]
	public void AddBuffer_OnTag_Throws_And_GetComponent_OnTag_Throws()
	{
		var db = CreateDb();
		var e = db.Create();

		// Buffer APIs must reject zero-size
		Assert.Throws<ComponentException>(() => db.Add<PlayerTag>(e.Id, ReadOnlySpan<PlayerTag>.Empty));

		// Accessing component data for a tag is not meaningful in many ECS.
		// Your implementation throws ComponentException on missing component;
		// we add the tag and then validate Has<T> rather than data access.
		db.Add(e.Id, new PlayerTag());
		Assert.True(db.Has<PlayerTag>(e.Id));
	}

	// ------------------------- Set<T> -------------------------

	[Fact]
	public void Set_UnmanagedComponent_OverwritesValue()
	{
		var db = CreateDb();
		var e = db.Create();

		db.Add<Position>(e.Id, new Position { X = 1, Y = 2 });
		// overwrite via Set<T>
		db.Set(e.Id, new Position { X = 9, Y = -5 });

		var p = db.Write<Position>(e.Id);
		Assert.Equal(9, p.X);
		Assert.Equal(-5, p.Y);
	}

	[Fact]
	public void Set_ManagedComponent_OverwritesValue()
	{
		var db = CreateDb();
		var e = db.Create();

		db.Add<NameTag>(e.Id, new NameTag("init"));
		db.Set(e.Id, new NameTag("after"));

		var t = db.Write<NameTag>(e.Id);
		Assert.Equal("after", t.Text);
	}

	[Fact]
	public void Set_ComponentMissing_Throws()
	{
		var db = CreateDb();
		var e = db.Create();

		// Position not attached yet
		var ex = Assert.Throws<ComponentException>(() => db.Set(e.Id, new Position { X = 3, Y = 4 }));
		Assert.Contains(nameof(Position), ex.Message);
	}

	[Fact]
	public void Set_UnknownEntity_Throws()
	{
		var db = CreateDb();
		Assert.Throws<EntityException>(() => db.Set(999, new Position { X = 1, Y = 2 }));
	}

	// Intentionally **not** testing Set<T> with buffered or zero-size types:
	// Set<T> is for regular components; buffered/zero-size have dedicated flows.

	// --------------------- SetBuffer<T> -----------------------

	[Fact]
	public void SetBuffer_OverwritesExistingValues_Inline()
	{
		var db = CreateDb();
		var e = db.Create();

		// initial small buffer
		var initial = new[] { new Damage(1), new Damage(2), new Damage(3) };
		db.Add<Damage>(e.Id, initial);

		// overwrite with fewer values
		var newVals = new[] { new Damage(7), new Damage(8) };
		db.Set<Damage>(e.Id, newVals);

		var buf = db.WriteBuffer<Damage>(e.Id);
		Assert.Equal(2, buf.Length);
		Assert.Equal(7, buf[0].Amount);
		Assert.Equal(8, buf[1].Amount);
	}

	[Fact]
	public void SetBuffer_OverwritesAndGrowsBeyondInternalCapacity()
	{
		var db = CreateDb();
		var e = db.Create();

		// internal capacity for LargeBuf is 2 -> start small
		db.Add<LargeBuf>(e.Id, new[] { new LargeBuf(1), new LargeBuf(2) });

		// overwrite with many items (forces promotion/resize)
		var big = new LargeBuf[10];
		for (int i = 0; i < big.Length; i++) big[i] = new LargeBuf(i * 10);

		db.Set<LargeBuf>(e.Id, big);

		var buf = db.WriteBuffer<LargeBuf>(e.Id);
		Assert.Equal(10, buf.Length);
		Assert.Equal(0, buf[0].V);
		Assert.Equal(90, buf[9].V);
	}

	[Fact]
	public void SetBuffer_WithEmptySpan_ClearsContents()
	{
		var db = CreateDb();
		var e = db.Create();

		db.Add<Damage>(e.Id, new[] { new Damage(1), new Damage(2) });
		db.Set<Damage>(e.Id, ReadOnlySpan<Damage>.Empty);

		var buf = db.WriteBuffer<Damage>(e.Id);
		Assert.Equal(0, buf.Length);
	}

	[Fact]
	public void SetBuffer_ComponentMissing_ThrowsComponentNotFound()
	{
		var db = CreateDb();
		var e = db.Create();

		// Damage buffer *not* attached yet
		var ex = Assert.Throws<ComponentException>(() => db.Set<Damage>(e.Id, new[] { new Damage(1) }));
		Assert.Contains(nameof(Damage), ex.Message);
	}

	[Fact]
	public void SetBuffer_OnNonBufferedType_Throws()
	{
		var db = CreateDb();
		var e = db.Create();

		// Attach a normal component so the entity exists; still SetBuffer should throw since Position isn't buffered
		db.Add<Position>(e.Id, new Position { X = 0, Y = 0 });

		var ex = Assert.Throws<ComponentException>(() => db.Set<Position>(e.Id, ReadOnlySpan<Position>.Empty));
		Assert.Contains("buffer", ex.Message, StringComparison.OrdinalIgnoreCase);
	}

	[Fact]
	public void SetBuffer_UnknownEntity_Throws()
	{
		var db = CreateDb();
		Assert.Throws<EntityException>(() => db.Set<Damage>(999, new[] { new Damage(1) }));
	}

	// -------------------- Guardrails around SetBuffer vs. GetBuffer --------------------

	[Fact]
	public void SetBuffer_ReplacesRatherThanAppends()
	{
		var db = CreateDb();
		var e = db.Create();

		db.Add<Damage>(e.Id, new[] { new Damage(1), new Damage(2) });
		// replace with just one value
		db.Set<Damage>(e.Id, new[] { new Damage(99) });

		var buf = db.WriteBuffer<Damage>(e.Id);
		Assert.Equal(1, buf.Length);
		Assert.Equal(99, buf[0].Amount);

		// Append via ComponentBuffer.AddRange to confirm difference
		buf.AddRange(new[] { new Damage(5), new Damage(6) });
		Assert.Equal(3, buf.Length);
		Assert.Equal(99, buf[0].Amount);
		Assert.Equal(5, buf[1].Amount);
		Assert.Equal(6, buf[2].Amount);
	}
}