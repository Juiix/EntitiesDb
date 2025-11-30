using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EntitiesDb;

/// <summary>
/// A collection of entities with the same <see cref="Signature"/> split into tight chunks.
/// </summary>
public unsafe sealed partial class Archetype
{
    /// <summary>
    /// The component bitset signature
    /// </summary>
    public readonly Signature Signature;

	/// <summary>
	/// Array of factories used to create managed component arrays
	/// </summary>
	private readonly ArrayFactory[] _arrayFactories;

	/// <summary>
	/// The count of unmanaged components
	/// </summary>
	/// <remarks>
	/// Managed component count is the inverse <c>(componentLength - unmanagedCount)</c>
	/// </remarks>
	private readonly int _unmangedComponentCount;

	/// <summary>
	/// The amount of bytes a <see cref="Chunk"/> can hold
	/// </summary>
	private readonly int _unmanagedChunkByteSize;

	/// <summary>
	/// A global array of change versions
	/// </summary>
	private readonly int[] _globalChangeVersions;

    /// <summary>
    /// <see cref="ComponentType.Id"/> to offset lookup table
    /// </summary>
    private readonly short[] _idToOffsets;

    /// <summary>
    /// Array used to store chunks
    /// </summary>
    private Chunk[] _chunks;

	/// <summary>
	/// If this has been disposed
	/// </summary>
	private bool _disposed;

	internal Archetype(in Signature signature, ComponentType[] componentTypes, ArrayFactory[] arrayFactories, int unmanagedComponentCount, int chunkByteSize, int[] globalChangeVersions)
	{
		Signature = signature;
		ComponentTypes = componentTypes;
		_arrayFactories = arrayFactories;
		_unmangedComponentCount = unmanagedComponentCount;
		EntitiesPerChunk = ArchetypeUtils.CalculateChunkCapacity(componentTypes, chunkByteSize);
		_unmanagedChunkByteSize = ArchetypeUtils.CalculateUnmanagedSize(componentTypes.AsSpan(0, unmanagedComponentCount)) * EntitiesPerChunk;
		_globalChangeVersions = globalChangeVersions;

		_chunks = ArrayPool<Chunk>.Shared.Rent(1);
        _idToOffsets = ArchetypeUtils.BuildIdOffsetLookup(componentTypes, unmanagedComponentCount, EntitiesPerChunk);

		AddChunk();
	}

	~Archetype() => DoDispose();

	/// <summary>
	/// How many entities are stored per chunk
	/// </summary>
	public int EntitiesPerChunk { get; }

	/// <summary>
	/// An array of <see cref="ComponentType"/> contained in this <see cref="Archetype"/>
	/// </summary>
	/// <remarks>
	/// Types are sorted (unmanaged | managed) components
	/// </remarks>
	public ComponentType[] ComponentTypes { get; }

	/// <summary>
	/// How many entities are stored in this archetype
	/// </summary>
	public int EntityCount { get; internal set; }

	/// <summary>
	/// How many chunks are in use
	/// </summary>
	public int ChunksInUse { get; internal set; }

	/// <summary>
	/// How many chunks are currently allocated
	/// </summary>
	public int ChunksAllocated { get; internal set; }

	/// <summary>
	/// The current working chunk (last chunk)
	/// </summary>
	internal ref Chunk CurrentChunk => ref _chunks[ChunksInUse - 1];

	/// <summary>
	/// A span helper for unmanaged component types
	/// </summary>
	internal ReadOnlySpan<ComponentType> UnmanagedComponentTypes => ComponentTypes.AsSpan(0, _unmangedComponentCount);

	/// <summary>
	/// A span helper for managed component types
	/// </summary>
	internal ReadOnlySpan<ComponentType> ManagedComponentTypes => ComponentTypes.AsSpan(_unmangedComponentCount);

	internal ReadOnlySpan<Chunk> ChunkSpan => _chunks.AsSpan(0, ChunksInUse);

	/// <summary>
	/// If this <see cref="Archetype"/> contains a given component
	/// </summary>
	/// <returns>If this <see cref="Archetype"/> has component with <paramref name="typeId"/></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Has(int typeId) =>
		Signature.Test(typeId);

	/// <summary>
	/// If this <see cref="Archetype"/> contains a given component
	/// </summary>
	/// <returns>If this <see cref="Archetype"/> has component with <paramref name="typeId"/></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Has<T>(Id<T> id) =>
		Signature.Test(id.Value);

	/// <summary>
	/// If this <see cref="Archetype"/> contains a given component
	/// </summary>
	/// <param name="ids">Component ids from <see cref="ComponentRegistry.GetIds{T}()"/></param>
	/// <returns>If this <see cref="Archetype"/> has <typeparamref name="T"/></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Has<T0>(in Ids<T0> ids) =>
        Signature.Test(ids.T0.Value);

	/// <summary>
	/// Gets offset for a given id
	/// </summary>
	/// <returns>Offsets for <paramref name="ids"/></returns>
	public Offset<T0> GetOffset<T0>(Id<T0> id)
	{
		var offsets = _idToOffsets;
		return new Offset<T0>(offsets[id.Value], id);
	}

	/// <summary>
	/// Gets offsets for given ids
	/// </summary>
	/// <returns>Offsets for <paramref name="ids"/></returns>
	public Offsets<T0> GetOffsets<T0>(in Ids<T0> ids)
	{
		var offsets = _idToOffsets;
		return new Offsets<T0>(
			new Offset<T0>(offsets[ids.T0.Value], ids.T0)
		);
	}

	/// <summary>
	/// Returns a chunk enumerator
	/// </summary>
	public ChunkIterator GetChunks(ChangeFilter? changeFilter = null, int? compareVersion = null) => new(_chunks.AsSpan(0, ChunksInUse), changeFilter, compareVersion);

	/// <summary>
	/// Returns a chunk enumerator
	/// </summary>
	public ReadOnlyEnumerator<Chunk> GetEnumerator() => new(_chunks.AsSpan(0, ChunksInUse));

	/// <summary>
	/// Clears a target slot and released buffer lists
	/// </summary>
	/// <param name="slot">The target slot</param>
	/// <param name="ids">Component ids</param>
	internal void Clear<T0>(in EntitySlot slot, in Ids<T0> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer(slot.Index, offsets.T0);
    }

	/// <summary>
	/// Gets a readonly component at a given slot
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="slot"></param>
	/// <param name="id"></param>
	/// <returns></returns>
	internal ref readonly T? Read<T>(in EntitySlot slot, Id<T> id)
    {
        ref var chunk = ref _chunks[slot.ChunkIndex];
		var offset = GetOffset(id);
		return ref chunk.Read(slot.Index, offset);
	}

	/// <summary>
	/// Gets a readonly buffer at a given slot
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="slot"></param>
	/// <param name="id"></param>
	/// <returns></returns>
	internal ReadOnlyBuffer<T> ReadBuffer<T>(in EntitySlot slot, Id<T> id) where T : unmanaged
    {
        ref var chunk = ref _chunks[slot.ChunkIndex];
		var offset = GetOffset(id);
		return chunk.ReadBuffer(slot.Index, offset);
	}

	/// <summary>
	/// Gets a component at a given slot
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="slot"></param>
	/// <param name="id"></param>
	/// <returns></returns>
	internal ref T? Write<T>(in EntitySlot slot, Id<T> id)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offset = GetOffset(id);
		return ref chunk.Write(slot.Index, offset);
	}

	/// <summary>
	/// Gets a buffer at a given slot
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="slot"></param>
	/// <param name="id"></param>
	/// <returns></returns>
	internal DynamicBuffer<T> WriteBuffer<T>(in EntitySlot slot, Id<T> id) where T : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offset = GetOffset(id);
		return chunk.WriteBuffer(slot.Index, offset);
	}

	/// <summary>
	/// Initializes a buffer of components at a given slot
	/// </summary>
	internal void Init<T0>(in EntitySlot slot, in Ids<T0> ids, ReadOnlySpan<T0> components) where T0 : unmanaged
    {
        ref var chunk = ref _chunks[slot.ChunkIndex];
		var offset = GetOffset(ids.T0);
		chunk.WriteBuffer(slot.Index, offset).Init(components);
	}

	/// <summary>
	/// Sets a component at a given slot
	/// </summary>
	internal void Set<T0>(in EntitySlot slot, in Ids<T0> ids, in T0? component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offset = GetOffset(ids.T0);
		chunk.Set(slot.Index, offset, in component);
	}

	/// <summary>
	/// Sets a buffer of components at a given slot
	/// </summary>
	internal void Set<T0>(in EntitySlot slot, in Ids<T0> ids, ReadOnlySpan<T0> components = default) where T0 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offset = GetOffset(ids.T0);
		chunk.Set(slot.Index, offset, components);
    }

	/// <summary>
	/// Reserves space for additional entities
	/// </summary>
	/// <param name="entityCount">The amount of entities to reserve for</param>
	internal void Reserve(int entityCount)
	{
		var newTotal = EntityCount + entityCount;
		var newChunkCount = (newTotal + EntitiesPerChunk - 1) / EntitiesPerChunk;

		if (newChunkCount > _chunks.Length)
		{
			// expand array
			var newArray = ArrayPool<Chunk>.Shared.Rent(newChunkCount);
			Array.Copy(_chunks, newArray, ChunksAllocated);
			ArrayPool<Chunk>.Shared.Return(_chunks, true);
			_chunks = newArray;
		}

		for (var i = ChunksAllocated; i < newChunkCount; i++)
		{
			var unmanagedComponents = Marshal.AllocHGlobal(_unmanagedChunkByteSize);
			var managedComponents = ArchetypeUtils.CreateManagedComponentArrays(_arrayFactories, EntitiesPerChunk);
			var changeFilters = ArchetypeUtils.BuildChangeVersions(_globalChangeVersions);
			_chunks[i] = new Chunk(unmanagedComponents, managedComponents, _globalChangeVersions, changeFilters);
		}
		ChunksAllocated = newChunkCount;
	}

	/// <summary>
	/// Allocates of reuses a new <see cref="Chunk"/>
	/// </summary>
	/// <returns></returns>
	internal ref Chunk AddChunk()
	{
		var count = ChunksInUse;
		if (count == _chunks.Length)
		{
			// expand array
			var newArray = ArrayPool<Chunk>.Shared.Rent(count + 1);
			Array.Copy(_chunks, newArray, count);
			ArrayPool<Chunk>.Shared.Return(_chunks, true);
			_chunks = newArray;
		}

		ref var chunk = ref _chunks[count];
		if (count >= ChunksAllocated)
		{
			ChunksAllocated++;
			var unmanagedComponents = Marshal.AllocHGlobal(_unmanagedChunkByteSize);
			var managedComponents = ArchetypeUtils.CreateManagedComponentArrays(_arrayFactories, EntitiesPerChunk);
			var changeFilters = ArchetypeUtils.BuildChangeVersions(_globalChangeVersions);
			chunk = new Chunk(unmanagedComponents, managedComponents, _globalChangeVersions, changeFilters);
		}

		ChunksInUse = ++count;
		return ref chunk;
	}

	/// <summary>
	/// Gets a ref to a <see cref="Chunk"/> at a given index
	/// </summary>
	/// <param name="index">Index of the <see cref="Chunk"/> to get</param>
	/// <returns>A reference to the <see cref="Chunk"/></returns>
	internal ref Chunk GetChunk(int index)
	{
		return ref _chunks[index];
	}

	/// <summary>
	/// Adds an <see cref="Entity"/> to the last <see cref="Chunk"/>
	/// </summary>
	/// <param name="entity">The <see cref="Entity"/> to add</param>
	/// <returns>The filled <see cref="EntitySlot"/></returns>
	internal EntitySlot AddEntity(Entity entity, out Chunk chunk)
	{
		int index;
		EntityCount++;

		// add to existing
		var chunkIndex = ChunksInUse - 1;
		ref var currentChunk = ref _chunks[chunkIndex];
		if (currentChunk.EntityCount < EntitiesPerChunk)
		{
			index = currentChunk.EntityCount++;
			currentChunk.AddEntity(index, entity);
			chunk = currentChunk;
			return new EntitySlot(index, chunkIndex);
		}

		// new chunk
		index = 0;
		currentChunk = ref AddChunk();
		currentChunk.EntityCount++;
		currentChunk.AddEntity(index, entity);
		chunk = currentChunk;
		return new EntitySlot(index, chunkIndex + 1);
	}

	/// <summary>
	/// Gets a reference to the <see cref="Entity"/> at the given <see cref="EntitySlot"/>
	/// </summary>
	/// <param name="entitySlot">The <see cref="EntitySlot"/> to check</param>
	/// <returns>The <see cref="Entity"/> reference</returns>
	internal ref Entity GetEntity(in EntitySlot entitySlot)
	{
		ref var chunk = ref _chunks[entitySlot.ChunkIndex];
		return ref chunk.WriteEntity(entitySlot.Index);
	}

	/// <summary>
	/// Removes an <see cref="Entity"/> at the given <see cref="EntitySlot"/>
	/// </summary>
	/// <param name="slot">The <see cref="EntitySlot"/> to remove</param>
	/// <param name="movedEntityId">The entity id that filled the removed <see cref="EntitySlot"/></param>
	internal void RemoveEntity(in EntitySlot slot, out int movedEntityId)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var lastChunkIndex = ChunksInUse - 1;
		ref var lastChunk = ref GetChunk(lastChunkIndex);

		var removedIndex = lastChunk.EntityCount - 1;
		movedEntityId = chunk.AcceptEntity(
			slot.Index, ref lastChunk, removedIndex,
			_idToOffsets, UnmanagedComponentTypes);

		lastChunk.EntityCount--;
		EntityCount--;

		if (removedIndex > 0 || ChunksInUse <= 0)
		{
			return;
		}

		ChunksInUse = Math.Max(ChunksInUse - 1, 1);
	}

	/// <summary>
	/// Clones components internally
	/// </summary>
	internal void CloneComponents(in EntitySlot srcSlot, in EntitySlot dstSlot)
	{
		ref var srcChunk = ref GetChunk(srcSlot.ChunkIndex);
		ref var dstChunk = ref GetChunk(dstSlot.ChunkIndex);
		srcChunk.CloneComponents(
			srcSlot.Index, ref dstChunk, dstSlot.Index,
			_idToOffsets, UnmanagedComponentTypes);

		foreach (ref readonly var type in ComponentTypes.AsSpan())
			dstChunk.MarkChanged(type.Id);
	}

	/// <summary>
	/// Copies components into an external <see cref="Archetype"/>
	/// </summary>
	internal void CopyComponents(in EntitySlot srcSlot, Archetype dstArchetype, in EntitySlot dstSlot)
	{
		ref var srcChunk = ref GetChunk(srcSlot.ChunkIndex);
		ref var dstChunk = ref dstArchetype.GetChunk(dstSlot.ChunkIndex);
		srcChunk.CopyComponents(
			srcSlot.Index, _idToOffsets,
			dstArchetype.Signature, ref dstChunk, dstSlot.Index, dstArchetype._idToOffsets,
			UnmanagedComponentTypes, ManagedComponentTypes);
	}

	/// <summary>
	/// Trims excess allocated chunks
	/// </summary>
	internal void TrimExcess()
	{
		// dealloc extra chunks
		for (int i = ChunksInUse; i < ChunksAllocated; i++)
		{
			ref var chunk = ref _chunks[i];
			Marshal.FreeHGlobal(chunk.UnmanagedComponents);
			chunk = default;
		}
		ChunksAllocated = ChunksInUse;

		// try resize chunk array
		var newArray = ArrayPool<Chunk>.Shared.Rent(ChunksAllocated);
		if (newArray.Length == _chunks.Length)
		{
			ArrayPool<Chunk>.Shared.Return(newArray);
			return;
		}

		Array.Copy(_chunks, newArray, ChunksAllocated);
		ArrayPool<Chunk>.Shared.Return(_chunks, true);
		_chunks = newArray;
	}

	internal void Dispose()
	{
		if (_disposed) return;
#pragma warning disable CA1816 // Dispose methods should call SuppressFinalize
		GC.SuppressFinalize(this);
#pragma warning restore CA1816 // Dispose methods should call SuppressFinalize
		_disposed = true;
	}

	private void DoDispose()
	{
		foreach (ref var chunk in _chunks.AsSpan(0, ChunksAllocated))
		{
			Marshal.FreeHGlobal(chunk.UnmanagedComponents);
		}
	}
}