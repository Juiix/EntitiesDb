using System;
using System.Linq;
using System.Runtime.InteropServices;
using Xunit;

namespace EntitiesDb.Core;

// Simple managed component (struct containing a reference)
file struct ManagedName
{
	public string Name;
	public ManagedName(string name) => Name = name;
	public override string ToString() => Name ?? string.Empty;
}

public sealed class ArchetypeTests
{
	private static Signature Sig(params int[] ids)
	{
		var s = Signature.Empty;
		foreach (var id in ids) s = s.WithSet(id);
		return s;
	}

	private static ArrayFactory[] FactoriesForManaged(ComponentRegistry reg, ComponentType[] types)
		=> types.Where(t => !t.IsUnmanaged)
				.Select(t => reg.GetArrayFactory(t.Id))
				.ToArray();

	private static (Archetype archetype,
					ComponentRegistry reg,
					ComponentType ctInt,
					ComponentType ctFloat,
					ComponentType ctName)
		BuildArchetype_Int_Float_Name(int chunkBytes = 4096)
	{
		var reg = new ComponentRegistry();

		// Register types (ids assigned in this order)
		ref readonly var ctInt = ref reg.GetComponentType<int>();
		ref readonly var ctFloat = ref reg.GetComponentType<float>();
		ref readonly var ctName = ref reg.GetComponentType<ManagedName>();

		// Unmanaged first, then managed
		var componentTypes = new[] { ctInt, ctFloat, ctName };
		int unmanagedCount = componentTypes.Count(t => t.IsUnmanaged);

		// Signature includes all three
		var signature = Sig(ctInt.Id, ctFloat.Id, ctName.Id);

		// Factories for managed components (just ManagedName[] here)
		var arrayFactories = FactoriesForManaged(reg, componentTypes);

		var archetype = new Archetype(signature, componentTypes, arrayFactories, unmanagedCount, chunkBytes);
		return (archetype, reg, ctInt, ctFloat, ctName);
	}

	[Fact]
	public void Constructor_Initializes_FirstChunk_And_Properties()
	{
		var (arch, reg, ctInt, ctFloat, ctName) = BuildArchetype_Int_Float_Name();
		try
		{
			Assert.True(arch.EntitiesPerChunk > 0);
			Assert.Equal(0, arch.EntityCount);
			Assert.Equal(1, arch.ChunkCount);

			// Signature / HasComponent
			Assert.True(arch.Has(ctInt.Id));
			Assert.True(arch.Has(ctFloat.Id));
			Assert.True(arch.Has(ctName.Id));

			// A type not in the archetype
			ref readonly var ctGuid = ref reg.GetComponentType<Guid>();
			Assert.False(arch.Has(ctGuid.Id));
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
		var (arch, _, _, _, _) = BuildArchetype_Int_Float_Name();
		try
		{
			int cap = arch.EntitiesPerChunk;

			// Fill the first chunk
			for (int i = 0; i < cap; i++)
			{
				var slot = arch.AddEntity(new Entity(i, 0));
				Assert.Equal(0, slot.ChunkIndex);
				Assert.Equal(i, slot.Index);
				Assert.Equal(i, arch.GetEntity(slot).Id);
			}

			Assert.Equal(cap, arch.EntityCount);
			Assert.Equal(1, arch.ChunkCount);

			// Adding one more should create a second chunk at index 0
			var extra = arch.AddEntity(new Entity(999, 0));
			Assert.Equal(cap + 1, arch.EntityCount);
			Assert.Equal(2, arch.ChunkCount);
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
		var (arch, _, _, _, _) = BuildArchetype_Int_Float_Name();
		try
		{
			int cap = arch.EntitiesPerChunk;

			// Ensure 2 chunks exist (cap + 1 entities)
			for (int i = 0; i < cap; i++) arch.AddEntity(new Entity(i, 0));
			var last = arch.AddEntity(new Entity(777, 0)); // second chunk, index 0

			Assert.Equal(2, arch.ChunkCount);

			// Remove first entity in first chunk; it should be replaced by "777" from the last chunk
			var first = new EntitySlot(0, 0);
			arch.RemoveEntity(first, out int moved);
			Assert.Equal(777, moved);
			Assert.Equal(777, arch.GetEntity(first).Id);

			// Because the last chunk had only 1 entity, removing it should drop the chunk
			Assert.Equal(1, arch.ChunkCount);
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
		var (arch, _, ctInt, ctFloat, ctName) = BuildArchetype_Int_Float_Name();
		try
		{
			// Two entities in the same chunk
			var src = arch.AddEntity(new Entity(1, 0));
			var dst = arch.AddEntity(new Entity(2, 0));

			// Access offsets via current chunk (internals)
			ref var chunk = ref arch.CurrentChunk;
			var offsets = chunk.IdToOffsets;

			// Seed source component data
			int intOff = offsets[ctInt.Id] + ctInt.Stride * src.Index;
			int floatOff = offsets[ctFloat.Id] + ctFloat.Stride * src.Index;
			int nameIdx = offsets[ctName.Id];

			chunk.GetUnmanaged<int>(intOff) = 1234;
			chunk.GetUnmanaged<float>(floatOff) = -9.5f;
			chunk.GetManaged<ManagedName>(nameIdx, src.Index) = new ManagedName("Alpha");

			// Different data in destination to ensure it changes
			int intOffDst = offsets[ctInt.Id] + ctInt.Stride * dst.Index;
			int floatOffDst = offsets[ctFloat.Id] + ctFloat.Stride * dst.Index;
			chunk.GetUnmanaged<int>(intOffDst) = 0;
			chunk.GetUnmanaged<float>(floatOffDst) = 0f;
			chunk.GetManaged<ManagedName>(nameIdx, dst.Index) = new ManagedName("z");

			// Act
			arch.CloneComponents(src, dst);

			// Assert: values copied
			Assert.Equal(1234, chunk.GetUnmanaged<int>(intOffDst));
			Assert.Equal(-9.5f, chunk.GetUnmanaged<float>(floatOffDst));
			Assert.Equal("Alpha", chunk.GetManaged<ManagedName>(nameIdx, dst.Index).Name);
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
		var (srcArch, reg, ctInt, ctFloat, ctName) = BuildArchetype_Int_Float_Name();

		// Destination: int, ManagedName (no float)
		ref readonly var dInt = ref reg.GetComponentType<int>();
		ref readonly var dName = ref reg.GetComponentType<ManagedName>();
		var dstTypes = new[] { dInt, dName };
		int dstUnmanagedCount = dstTypes.Count(t => t.IsUnmanaged);
		var dstSig = Sig(dInt.Id, dName.Id);
		var dstFactories = FactoriesForManaged(reg, dstTypes);
		var dstArch = new Archetype(dstSig, dstTypes, dstFactories, dstUnmanagedCount, 4096);

		try
		{
			// Make one entity in each
			var s = srcArch.AddEntity(new Entity(10, 0));
			var d = dstArch.AddEntity(new Entity(20, 0));

			// Seed source values
			ref var sChunk = ref srcArch.GetChunk(s.ChunkIndex);
			var sOffsets = sChunk.IdToOffsets;

			int sIntOff = sOffsets[ctInt.Id] + ctInt.Stride * s.Index;
			int sFloatOff = sOffsets[ctFloat.Id] + ctFloat.Stride * s.Index;
			int sNameIdx = sOffsets[ctName.Id];

			sChunk.GetUnmanaged<int>(sIntOff) = 7;
			sChunk.GetUnmanaged<float>(sFloatOff) = 99.25f;
			sChunk.GetManaged<ManagedName>(sNameIdx, s.Index) = new ManagedName("Carol");

			// Seed destination with sentinels
			ref var dChunk = ref dstArch.GetChunk(d.ChunkIndex);
			var dOffsets = dChunk.IdToOffsets;
			int dIntOff = dOffsets[dInt.Id] + dInt.Stride * d.Index;
			int dNameIdx = dOffsets[dName.Id];
			dChunk.GetUnmanaged<int>(dIntOff) = -1;
			dChunk.GetManaged<ManagedName>(dNameIdx, d.Index) = new ManagedName("unset");

			// Act: copy subset (int + name)
			srcArch.CopyComponents(s, dstArch, d);

			// Assert: int and name copied; float intentionally absent in dst archetype
			Assert.Equal(7, dChunk.GetUnmanaged<int>(dIntOff));
			Assert.Equal("Carol", dChunk.GetManaged<ManagedName>(dNameIdx, d.Index).Name);
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
		var (arch, _, _, _, _) = BuildArchetype_Int_Float_Name();
		try
		{
			var firstPtr = arch.CurrentChunk.UnmanagedComponents;

			// Force a new chunk
			int cap = arch.EntitiesPerChunk;
			for (int i = 0; i < cap + 1; i++)
				arch.AddEntity(new Entity(i, 0));

			var lastPtr = arch.CurrentChunk.UnmanagedComponents;

			Assert.Equal(2, arch.ChunkCount);
			Assert.NotEqual(firstPtr, lastPtr);
		}
		finally
		{
			arch = null!;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}
}
