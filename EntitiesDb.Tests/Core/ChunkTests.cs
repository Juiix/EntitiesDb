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
	private readonly ComponentRegistry _registry = new();

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
		ref readonly var ctInt = ref _registry.GetComponentType<int>();
		ref readonly var ctFloat = ref _registry.GetComponentType<float>();
		ref readonly var ctName = ref _registry.GetComponentType<ManagedName>();

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
	public void Constructor_Spans_And_EntityCount_Basics()
	{
		// Arrange
		var (types, unmanagedCount) = BuildComponentTypes();

		// Chunk capacity from ArchetypeUtils
		int chunkSize = 4096;
		int capacity = ArchetypeUtils.CalculateChunkCapacity(types, chunkSize);

		// Offsets via ArchetypeUtils
		var offsets = ArchetypeUtils.BuildIdOffsetLookup(types, unmanagedCount, capacity);

		// Allocate unmanaged region of appropriate size
		int unmanagedBytes = ComputeUnmanagedBytesTotal(types, capacity);
		_srcBlock = Marshal.AllocHGlobal(unmanagedBytes);

		// Managed arrays (one: ManagedName[])
		var managed = CreateManagedArrays(types, capacity, unmanagedCount);

		var chunk = new Chunk(types, offsets, _srcBlock, managed, unmanagedCount)
		{
			EntityCount = capacity
		};

		// Assert
		Assert.Equal(capacity, chunk.EntityCount);
		Assert.Equal(unmanagedCount, chunk.UnmanagedComponentTypes.Length);
		Assert.Equal(types.Length - unmanagedCount, chunk.ManagedComponentTypes.Length);
	}

	[Fact]
	public void AddEntity_GetEntity_AcceptEntity_CopyAll_Data_Roundtrip()
	{
		// Arrange archetype and capacity
		var (types, unmanagedCount) = BuildComponentTypes();
		int chunkSize = 4096;
		int capacity = ArchetypeUtils.CalculateChunkCapacity(types, chunkSize);
		var offsets = ArchetypeUtils.BuildIdOffsetLookup(types, unmanagedCount, capacity);

		// Unmanaged blocks
		int unmanagedBytes = ComputeUnmanagedBytesTotal(types, capacity);
		_srcBlock = Marshal.AllocHGlobal(unmanagedBytes);
		_dstBlock = Marshal.AllocHGlobal(unmanagedBytes);

		// Managed arrays
		var srcManaged = CreateManagedArrays(types, capacity, unmanagedCount);
		var dstManaged = CreateManagedArrays(types, capacity, unmanagedCount);

		var src = new Chunk(types, offsets, _srcBlock, srcManaged, unmanagedCount);
		var dst = new Chunk(types, offsets, _dstBlock, dstManaged, unmanagedCount);

		// Alias for component types we care about
		ref readonly var ctInt = ref _registry.GetComponentType<int>();
		ref readonly var ctFloat = ref _registry.GetComponentType<float>();
		ref readonly var ctName = ref _registry.GetComponentType<ManagedName>();

		// Put data in src at srcIndex
		int srcIndex = 2, dstIndex = 5;

		// Entity
		var entity = new Entity(123, 0);
		src.AddEntity(srcIndex, entity);

		// Unmanaged components
		// int
		src.Get<int>(srcIndex, ctInt.Id) = 42;
		// float
		src.Get<float>(srcIndex, ctFloat.Id) = 3.5f;

		// Managed component: ManagedName
		src.Get<ManagedName>(srcIndex, ctName.Id) = new ManagedName("Alice");

		// Act: transfer entity + all its components via AcceptEntity
		int accepted = dst.AcceptEntity(dstIndex, ref src, srcIndex);

		// Assert entity id
		Assert.Equal(123, accepted);
		Assert.Equal(123, dst.GetEntity(dstIndex).Id);

		// Assert unmanaged copied
		Assert.Equal(42, dst.Get<int>(dstIndex, ctInt.Id));
		Assert.Equal(3.5f, dst.Get<float>(dstIndex, ctFloat.Id));

		// Assert managed copied
		Assert.Equal("Alice", dst.Get<ManagedName>(dstIndex, ctName.Id).Name);
	}


	[Fact]
	public void CloneComponents_SameArchetype_CopiesUnmanagedAndManaged()
	{
		// Arrange
		var (types, unmanagedCount) = BuildComponentTypes();
		int capacity = ArchetypeUtils.CalculateChunkCapacity(types, 4096);
		var offsets = ArchetypeUtils.BuildIdOffsetLookup(types, unmanagedCount, capacity);

		int unmanagedBytes = ComputeUnmanagedBytesTotal(types, capacity);
		_srcBlock = Marshal.AllocHGlobal(unmanagedBytes);
		_dstBlock = Marshal.AllocHGlobal(unmanagedBytes);

		var srcManaged = CreateManagedArrays(types, capacity, unmanagedCount);
		var dstManaged = CreateManagedArrays(types, capacity, unmanagedCount);

		var src = new Chunk(types, offsets, _srcBlock, srcManaged, unmanagedCount);
		var dst = new Chunk(types, offsets, _dstBlock, dstManaged, unmanagedCount);

		ref readonly var ctInt = ref _registry.GetComponentType<int>();
		ref readonly var ctFloat = ref _registry.GetComponentType<float>();
		ref readonly var ctName = ref _registry.GetComponentType<ManagedName>();

		int srcIndex = 1, dstIndex = 7;

		// Seed source values
		src.Get<int>(srcIndex, ctInt.Id) = 1001;
		src.Get<float>(srcIndex, ctFloat.Id) = -2.25f;
		src.Get<ManagedName>(srcIndex, ctName.Id) = new ManagedName("Bob");

		// Act
		src.CloneComponents(srcIndex, ref dst, dstIndex);

		// Assert
		Assert.Equal(1001, dst.Get<int>(dstIndex, ctInt.Id));
		Assert.Equal(-2.25f, dst.Get<float>(dstIndex, ctFloat.Id));
		Assert.Equal("Bob", dst.Get<ManagedName>(dstIndex, ctName.Id).Name);
	}

	[Fact]
	public void CopyComponents_SubsetSignature_CopiesOnlyPresentTypes()
	{
		// Src archetype: int, float, ManagedName
		var (srcTypes, srcUnmanagedCount) = BuildComponentTypes();
		int srcCap = ArchetypeUtils.CalculateChunkCapacity(srcTypes, 4096);
		var srcOffsets = ArchetypeUtils.BuildIdOffsetLookup(srcTypes, srcUnmanagedCount, srcCap);

		// Dst archetype: int, ManagedName (drop float)
		ref readonly var ctInt = ref _registry.GetComponentType<int>();
		ref readonly var ctFloat = ref _registry.GetComponentType<float>();
		ref readonly var ctName = ref _registry.GetComponentType<ManagedName>();

		var dstTypes = new[] { ctInt, ctName }; // unmanaged first (int), then managed
		int dstUnmanagedCount = dstTypes.Count(t => t.IsUnmanaged);
		int dstCap = ArchetypeUtils.CalculateChunkCapacity(dstTypes, 4096);
		var dstOffsets = ArchetypeUtils.BuildIdOffsetLookup(dstTypes, 1, dstCap);

		// Allocate unmanaged blocks
		int srcUnmanagedBytes = ComputeUnmanagedBytesTotal(srcTypes, srcCap);
		int dstUnmanagedBytes = ComputeUnmanagedBytesTotal(dstTypes, dstCap);
		_srcBlock = Marshal.AllocHGlobal(srcUnmanagedBytes);
		_dstBlock = Marshal.AllocHGlobal(dstUnmanagedBytes);

		// Managed arrays for each
		var srcManaged = CreateManagedArrays(srcTypes, srcCap, srcUnmanagedCount);
		var dstManaged = CreateManagedArrays(dstTypes, dstCap, dstUnmanagedCount);

		var src = new Chunk(srcTypes, srcOffsets, _srcBlock, srcManaged, srcUnmanagedCount);
		var dst = new Chunk(dstTypes, dstOffsets, _dstBlock, dstManaged, dstUnmanagedCount);

		int srcIndex = 0, dstIndex = 3;

		// Seed source values
		src.Get<int>(srcIndex, ctInt.Id) = 7;
		src.Get<float>(srcIndex, ctFloat.Id) = 9.25f;
		src.Get<ManagedName>(srcIndex, ctName.Id) = new ManagedName("Carol");

		// Destination starts with sentinel values
		dst.Get<int>(dstIndex, ctInt.Id) = -1;
		// No float in destination
		dst.Get<ManagedName>(dstIndex, ctName.Id) = new ManagedName("unset");

		// Copy only types present in destination: int + name
		var dstSig = BuildSignatureFor(ctInt, ctName);
		src.CopyComponents(srcIndex, in dstSig, ref dst, dstIndex);

		// Assert: int copied, name copied, float untouched (no float slot in dst)
		Assert.Equal(7, dst.Get<int>(dstIndex, ctInt.Id));
		Assert.Equal("Carol", dst.Get<ManagedName>(dstIndex, ctName.Id).Name);
	}
}
