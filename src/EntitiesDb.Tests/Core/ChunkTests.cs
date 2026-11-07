using System;
using System.Linq;
using System.Runtime.InteropServices;
using Xunit;
using EntitiesDb;

namespace EntitiesDb.Core;

// A managed component (struct with a reference field)
file struct ManagedName
{
	public string Name;
	public ManagedName(string name) => Name = name;
	public override string ToString() => Name ?? string.Empty;
}

public unsafe class ChunkTests : IDisposable
{
	// Unmanaged backing memory we allocate per test
	private IntPtr _srcBlock = IntPtr.Zero;
	private IntPtr _dstBlock = IntPtr.Zero;

	public void Dispose()
	{
		if (_srcBlock != IntPtr.Zero) Marshal.FreeHGlobal(_srcBlock);
		if (_dstBlock != IntPtr.Zero) Marshal.FreeHGlobal(_dstBlock);
	}

	// Build a simple archetype: two unmanaged components (int, float) + one managed (ManagedName)
	private (ComponentType[] types, int unmanagedCount) BuildComponentTypes()
	{
		ref readonly var ctInt = ref Component<int>.ComponentType;
		ref readonly var ctFloat = ref Component<float>.ComponentType;
		ref readonly var ctName = ref Component<ManagedName>.ComponentType;

		// IMPORTANT: unmanaged first, then managed
		var componentTypes = new[] { ctInt, ctFloat, ctName };
		int unmanagedCount = componentTypes.Count(ct => ct.IsUnmanaged);
		return (componentTypes, unmanagedCount);
	}

	private static int ComputeUnmanagedBytesPerEntity(ReadOnlySpan<ComponentType> types)
	{
		// unmanaged region = [Entity table] + sum of unmanaged component strides
		int perEntity = sizeof(Entity);
		foreach (ref readonly var t in types)
			if (t.IsUnmanaged) perEntity += t.Stride;
		return perEntity;
	}

	private static int ComputeUnmanagedBytesTotal(ReadOnlySpan<ComponentType> types, int capacity)
		=> ComputeUnmanagedBytesPerEntity(types) * capacity;

	private static Array[] CreateManagedArrays(ComponentType[] types, int capacity, int unmanagedCount)
	{
		var managed = types.Skip(unmanagedCount).ToArray();
		var arrays = new Array[managed.Length];
		for (int i = 0; i < managed.Length; i++)
		{
			// Use registry-provided element arrays via Array.CreateInstance
			var elementType = typeof(ManagedName); // only one managed in this test set
			arrays[i] = Array.CreateInstance(elementType, capacity);
		}
		return arrays;
	}

	private static Signature BuildSignatureFor(params ComponentType[] include)
	{
		var sig = Signature.Empty;
		foreach (var t in include) sig = sig.WithSet(t.Id);
		return sig;
	}

	[Fact]
	public void HasAndHasAny_WithMultipleTypes_ReportExpectedPresence()
	{
		var (types, unmanagedCount) = BuildComponentTypes();
		int capacity = ArchetypeUtils.CalculateChunkCapacity(types, 4096);
		var offsets = ArchetypeUtils.BuildIdOffsetLookup(types, unmanagedCount, capacity);
		var globalChangeVersions = new int[256];
		var localChangeVersions = new int[256];

		int unmanagedBytes = ComputeUnmanagedBytesTotal(types, capacity);
		_srcBlock = Marshal.AllocHGlobal(unmanagedBytes);

		var managed = CreateManagedArrays(types, capacity, unmanagedCount);
		var chunk = new Chunk(_srcBlock, managed, globalChangeVersions, localChangeVersions, offsets);

		Assert.True(chunk.Has<int, float>());
		Assert.False(chunk.Has<int, Guid>());
		Assert.True(chunk.HasAny<int, Guid>());
		Assert.False(chunk.HasAny<Guid, DateTime>());
	}

	[Fact]
	public void AddEntity_GetEntity_AcceptEntity_CopyAll_Data_Roundtrip()
	{
		// Arrange archetype and capacity
		var (types, unmanagedCount) = BuildComponentTypes();
		int chunkSize = 4096;
		int capacity = ArchetypeUtils.CalculateChunkCapacity(types, chunkSize);
		var offsets = ArchetypeUtils.BuildIdOffsetLookup(types, unmanagedCount, capacity);
		var globalChangeVersions = new int[256];
		var srcChangeVersions = new int[256];
		var dstChangeVersions = new int[256];

		// Unmanaged blocks
		int unmanagedBytes = ComputeUnmanagedBytesTotal(types, capacity);
		_srcBlock = Marshal.AllocHGlobal(unmanagedBytes);
		_dstBlock = Marshal.AllocHGlobal(unmanagedBytes);

		// Managed arrays
		var srcManaged = CreateManagedArrays(types, capacity, unmanagedCount);
		var dstManaged = CreateManagedArrays(types, capacity, unmanagedCount);

		var src = new Chunk(_srcBlock, srcManaged, globalChangeVersions, srcChangeVersions, offsets);
		var dst = new Chunk(_dstBlock, dstManaged, globalChangeVersions, dstChangeVersions, offsets);

		// Put data in src at srcIndex
		int srcIndex = 2, dstIndex = 5;

		// Entity
		var entity = new Entity(123, 0);
		src.AddEntity(srcIndex, entity);

		// Unmanaged components
		// int
		src.Write<int>(srcIndex) = 42;
		// float
		src.Write<float>(srcIndex) = 3.5f;

		// Managed component: ManagedName
		src.Write<ManagedName>(srcIndex) = new ManagedName("Alice");

		// Act: transfer entity + all its components via AcceptEntity
		ArchetypeUtils.BuildColumns(types, unmanagedCount, offsets, out _, out _, out var columns, out _, out _);
		int accepted = dst.AcceptEntity(dstIndex, ref src, srcIndex, columns);

		// Assert entity id
		Assert.Equal(123, accepted);
		Assert.Equal(123, dst.Entity(dstIndex).Id);

		// Assert unmanaged copied
		Assert.Equal(42, dst.Read<int>(dstIndex));
		Assert.Equal(3.5f, dst.Read<float>(dstIndex));

		// Assert managed copied
		Assert.Equal("Alice", dst.Read<ManagedName>(dstIndex).Name);
	}
}
