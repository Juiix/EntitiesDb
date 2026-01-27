using System;
using System.Linq;
using System.Runtime.InteropServices;
using Xunit;

namespace EntitiesDb.Core;

public sealed class ArchetypeTests
{
	// Simple managed component (struct containing a reference)
	private struct ManagedName
	{
		public string Name;
		public ManagedName(string name) => Name = name;
		public override string ToString() => Name ?? string.Empty;
	}

	private static Signature Sig(params int[] ids)
	{
		var s = Signature.Empty;
		foreach (var id in ids) s = s.WithSet(id);
		return s;
	}

	private static ArrayFactory[] FactoriesForManaged(ComponentType[] types)
		=> types.Where(t => !t.IsUnmanaged)
				.Select(t => ComponentRegistry.GetArrayFactory(t.Id))
				.ToArray();

	private static Archetype BuildArchetype_Int_Float_Name(int chunkBytes = 4096)
	{
		// Register types (ids assigned in this order)
		ref readonly var ctInt = ref Component<int>.ComponentType;
		ref readonly var ctFloat = ref Component<float>.ComponentType;
		ref readonly var ctName = ref Component<ManagedName>.ComponentType;

		// Unmanaged first, then managed
		var componentTypes = new[] { ctInt, ctFloat, ctName };
		int unmanagedCount = componentTypes.Count(t => t.IsUnmanaged);
		var globalChangeVersions = new int[256];

		// Signature includes all three
		var signature = Sig(ctInt.Id, ctFloat.Id, ctName.Id);

		// Factories for managed components (just ManagedName[] here)
		var arrayFactories = FactoriesForManaged(componentTypes);

		var archetype = new Archetype(signature, componentTypes, arrayFactories, unmanagedCount, chunkBytes, globalChangeVersions);
		return archetype;
	}

	[Fact]
	public void Constructor_Initializes_FirstChunk_And_Properties()
	{
		var arch = BuildArchetype_Int_Float_Name();
		try
		{
			Assert.True(arch.EntitiesPerChunk > 0);
			Assert.Equal(0, arch.EntityCount);
			Assert.Equal(1, arch.ChunksInUse);

			// Signature / HasComponent
			Assert.True(arch.Has<int>());
			Assert.True(arch.Has<float>());
			Assert.True(arch.Has<ManagedName>());

			// A type not in the archetype
			Assert.False(arch.Has<Guid>());
		}
		finally
		{
			// Encourage finalizer to release native memory
			arch = null!;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}

	[Fact]
	public void AddEntity_FillsCurrentChunk_ThenAddsNewChunk()
	{
		var arch = BuildArchetype_Int_Float_Name();
		try
		{
			int cap = arch.EntitiesPerChunk;

			// Fill the first chunk
			for (int i = 0; i < cap; i++)
			{
				var slot = arch.AddEntity(new Entity(i, 0), out _);
				Assert.Equal(0, slot.ChunkIndex);
				Assert.Equal(i, slot.Index);
				Assert.Equal(i, arch.GetEntity(slot).Id);
			}

			Assert.Equal(cap, arch.EntityCount);
			Assert.Equal(1, arch.ChunksInUse);

			// Adding one more should create a second chunk at index 0
			var extra = arch.AddEntity(new Entity(999, 0), out _);
			Assert.Equal(cap + 1, arch.EntityCount);
			Assert.Equal(2, arch.ChunksInUse);
			Assert.Equal(1, extra.ChunkIndex);
			Assert.Equal(0, extra.Index);
			Assert.Equal(999, arch.GetEntity(extra).Id);
		}
		finally
		{
			arch = null!;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}

	[Fact]
	public void RemoveEntity_SwapsFromLastChunk_And_DropsEmptyLastChunk()
	{
		var arch = BuildArchetype_Int_Float_Name();
		try
		{
			int cap = arch.EntitiesPerChunk;

			// Ensure 2 chunks exist (cap + 1 entities)
			for (int i = 0; i < cap; i++) arch.AddEntity(new Entity(i, 0), out _);
			var last = arch.AddEntity(new Entity(777, 0), out _); // second chunk, index 0

			Assert.Equal(2, arch.ChunksInUse);

			// Remove first entity in first chunk; it should be replaced by "777" from the last chunk
			var first = new EntitySlot(0, 0);
			arch.RemoveEntity(first, out int moved);
			Assert.Equal(777, moved);
			Assert.Equal(777, arch.GetEntity(first).Id);

			// Because the last chunk had only 1 entity, removing it should drop the chunk
			Assert.Equal(1, arch.ChunksInUse);
			Assert.Equal(cap, arch.EntityCount); // cap + 1 - 1
		}
		finally
		{
			arch = null!;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}

	[Fact]
	public void CloneComponents_Copies_Managed_And_Unmanaged_WithinSameArchetype()
	{
		var arch = BuildArchetype_Int_Float_Name();
		try
		{
			// Two entities in the same chunk
			var src = arch.AddEntity(new Entity(1, 0), out var srcChunk);
			var dst = arch.AddEntity(new Entity(2, 0), out var dstChunk);

			// Seed source component data
			srcChunk.Write<int>(src.Index) = 1234;
			srcChunk.Write<float>(src.Index) = -9.5f;
			srcChunk.Write<ManagedName>(src.Index) = new ManagedName("Alpha");

			// Different data in destination to ensure it changes
			dstChunk.Write<int>(dst.Index) = 0;
			dstChunk.Write<float>(dst.Index) = 0f;
			dstChunk.Write<ManagedName>(dst.Index) = new ManagedName("z");

			// Act
			arch.CloneComponents(src, dst);

			// Assert: values copied
			Assert.Equal(1234,		dstChunk.Read<int>(dst.Index));
			Assert.Equal(-9.5f,		dstChunk.Read<float>(dst.Index));
			Assert.Equal("Alpha",	dstChunk.Read<ManagedName>(dst.Index).Name);
		}
		finally
		{
			arch = null!;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}

	[Fact]
	public void CopyComponents_ToSubsetArchetype_CopiesOnlyPresentComponents()
	{
		// Source: int, float, ManagedName
		var srcArch = BuildArchetype_Int_Float_Name();

		// Destination: int, ManagedName (no float)
		ref readonly var dInt = ref Component<int>.ComponentType;
		ref readonly var dName = ref Component<ManagedName>.ComponentType;
		var dstTypes = new[] { dInt, dName };
		int dstUnmanagedCount = dstTypes.Count(t => t.IsUnmanaged);
		var dstSig = Sig(dInt.Id, dName.Id);
		var dstFactories = FactoriesForManaged(dstTypes);
		var globalChangeVersions = new int[256];
		var dstArch = new Archetype(dstSig, dstTypes, dstFactories, dstUnmanagedCount, 4096, globalChangeVersions);

		try
		{
			// Make one entity in each
			var s = srcArch.AddEntity(new Entity(10, 0), out var sChunk);
			var d = dstArch.AddEntity(new Entity(20, 0), out var dChunk);

			// Seed source values
			sChunk.Write<int>(s.Index) = 7;
			sChunk.Write<float>(s.Index) = 99.25f;
			sChunk.Write<ManagedName>(s.Index) = new ManagedName("Carol");

			// Seed destination with sentinels
			dChunk.Write<int>(s.Index) = -1;
			dChunk.Write<ManagedName>(s.Index) = new ManagedName("unset");

			// Act: copy subset (int + name)
			srcArch.CopyComponents(s, dstArch, d);

			// Assert: int and name copied; float intentionally absent in dst archetype
			Assert.Equal(7, dChunk.Read<int>(d.Index));
			Assert.Equal("Carol", dChunk.Read<ManagedName>(d.Index).Name);
		}
		finally
		{
			srcArch = null!;
			dstArch = null!;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}

	[Fact]
	public void CurrentChunk_PointsTo_LastChunk()
	{
		var arch = BuildArchetype_Int_Float_Name();
		try
		{
			var firstPtr = arch.CurrentChunk.UnmanagedComponents;

			// Force a new chunk
			int cap = arch.EntitiesPerChunk;
			for (int i = 0; i < cap + 1; i++)
				arch.AddEntity(new Entity(i, 0), out _);

			var lastPtr = arch.CurrentChunk.UnmanagedComponents;

			Assert.Equal(2, arch.ChunksInUse);
			Assert.NotEqual(firstPtr, lastPtr);
		}
		finally
		{
			arch = null!;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}

	[Fact]
	public void Has_ByTypeId_Works_For_Present_And_Absent()
	{
		var arch = BuildArchetype_Int_Float_Name();
		try
		{
			// present
			Assert.True(arch.Has<int>());
			Assert.True(arch.Has<float>());
			Assert.True(arch.Has<ManagedName>());

			// absent
			Assert.False(arch.Has<Guid>());
		}
		finally
		{
			arch = null!;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}

	[Fact]
	public void Reserve_WithZero_DoesNotChangeCounts()
	{
		var arch = BuildArchetype_Int_Float_Name();
		try
		{
			Assert.Equal(0, arch.EntityCount);
			Assert.Equal(1, arch.ChunksInUse);

			// Act
			arch.Reserve(0);

			// Assert
			Assert.Equal(0, arch.EntityCount);
			Assert.Equal(1, arch.ChunksInUse);
		}
		finally
		{
			arch = null!;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}

	[Fact]
	public void Reserve_DoesNotAllocate_NewChunk_WhenCapacityNotCrossed()
	{
		var arch = BuildArchetype_Int_Float_Name();
		try
		{
			int cap = arch.EntitiesPerChunk;

			// Pre-fill some entities but don't reach capacity
			for (int i = 0; i < cap / 2; i++)
				arch.AddEntity(new Entity(i, 0), out _);

			Assert.Equal(1, arch.ChunksInUse);

			// Reserve so that total still fits in a single chunk
			int remaining = cap - arch.EntityCount; // enough to exactly fill the chunk
			arch.Reserve(remaining - 1);           // leave headroom so we shouldn't need a new chunk

			Assert.Equal(1, arch.ChunksInUse);       // still a single chunk
			Assert.Equal(cap / 2, arch.EntityCount);// reserve should NOT change EntityCount
		}
		finally
		{
			arch = null!;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}

	[Fact]
	public void Reserve_Allocates_Ceil_NewChunks_ForTargetTotal()
	{
		var arch = BuildArchetype_Int_Float_Name();
		try
		{
			int cap = arch.EntitiesPerChunk;

			// Request space for more than 2 chunks worth
			int toReserve = cap * 2 + 1; // requires 3 chunks total when empty
			arch.Reserve(toReserve);

			// Expect 3 chunks allocated/available to use
			Assert.Equal(3, arch.ChunksAllocated);

			// Reserve should not change EntityCount (just capacity)
			Assert.Equal(0, arch.EntityCount);

			// Adding entities now should use the already-reserved chunks without growing ChunkCount
			for (int i = 0; i < toReserve; i++)
				arch.AddEntity(new Entity(i, 0), out _);

			Assert.Equal(toReserve, arch.EntityCount);
			Assert.Equal(3, arch.ChunksInUse);
		}
		finally
		{
			arch = null!;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}

	[Fact]
	public void Reserve_FollowedBy_AddEntity_DoesNotOverAllocate()
	{
		var arch = BuildArchetype_Int_Float_Name();
		try
		{
			int cap = arch.EntitiesPerChunk * 2;

			// Reserve exactly 2 full chunks worth
			arch.Reserve(cap);

			Assert.Equal(2, arch.ChunksAllocated);
			Assert.Equal(0, arch.EntityCount);

			// Fill exactly cap entities; ChunkCount should remain 2
			for (int i = 0; i < cap; i++)
				arch.AddEntity(new Entity(i, 0), out _);

			Assert.Equal(cap, arch.EntityCount);
			Assert.Equal(2, arch.ChunksInUse);
		}
		finally
		{
			arch = null!;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}

	[Fact]
	public void GetChunk_ReturnsRef_ToCorrectChunk()
	{
		var arch = BuildArchetype_Int_Float_Name();
		try
		{
			int cap = arch.EntitiesPerChunk;

			// Ensure multiple chunks
			for (int i = 0; i < cap + 5; i++)
				arch.AddEntity(new Entity(i, 0), out _);

			Assert.Equal(2, arch.ChunksInUse);

			ref var first = ref arch.GetChunk(0);
			ref var last = ref arch.GetChunk(1);

			Assert.NotEqual(first.UnmanagedComponents, last.UnmanagedComponents);
			Assert.Equal(last.UnmanagedComponents, arch.CurrentChunk.UnmanagedComponents);
		}
		finally
		{
			arch = null!;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}

	[Fact]
	public void Chunk_Enumerator_Yields_AllActiveChunks_InOrder()
	{
		var arch = BuildArchetype_Int_Float_Name();
		try
		{
			int cap = arch.EntitiesPerChunk;

			// 3 chunks total
			for (int i = 0; i < cap * 2 + 3; i++)
				arch.AddEntity(new Entity(i, 0), out _);

			Assert.Equal(3, arch.ChunksInUse);

			int seen = 0;
			var lastPtr = IntPtr.Zero;

			foreach (ref readonly var chunk in arch)
			{
				seen++;
				// ensure strictly increasing (by identity) across chunks
				Assert.NotEqual(lastPtr, chunk.UnmanagedComponents);
				lastPtr = chunk.UnmanagedComponents;
			}

			Assert.Equal(3, seen);
		}
		finally
		{
			arch = null!;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}
}
