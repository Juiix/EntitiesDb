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
    private readonly int[] _idToOffsets;

	/// <summary>
	/// Unmanaged, non-tag, non-buffer columns (zeroed by <see cref="InitEntity"/>)
	/// </summary>
	private readonly ColumnInfo[] _dataColumns;

	/// <summary>
	/// Buffer columns
	/// </summary>
	private readonly ColumnInfo[] _bufferColumns;

	/// <summary>
	/// Every unmanaged column that holds bytes (data + buffers)
	/// </summary>
	private readonly ColumnInfo[] _copyColumns;

	/// <summary>
	/// Managed component ids, index-aligned with <see cref="Chunk.ManagedComponents"/>
	/// </summary>
	private readonly int[] _managedIds;

	/// <summary>
	/// Ids of components with change tracking
	/// </summary>
	private readonly int[] _trackedIds;

	/// <summary>
	/// Single-component transitions resolved from this archetype, indexed by component id. Lazily
	/// allocated; lets Add&lt;T&gt;/Remove&lt;T&gt; skip the signature dictionary.
	/// </summary>
	private Archetype?[]? _addEdges;
	private Archetype?[]? _removeEdges;

	/// <summary>
	/// Array used to store chunks
	/// </summary>
	// at least this many chunk slots: arrays grow by doubling, and replacing one invalidates EntityData
	private const int InitialChunkCapacity = 16;
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

		_chunks = new Chunk[InitialChunkCapacity];
        _idToOffsets = ArchetypeUtils.BuildIdOffsetLookup(componentTypes, unmanagedComponentCount, EntitiesPerChunk);
		ArchetypeUtils.BuildColumns(componentTypes, unmanagedComponentCount, _idToOffsets,
			out _dataColumns, out _bufferColumns, out _copyColumns, out _managedIds, out _trackedIds);

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
	/// <see cref="ComponentType.Id"/> to offset lookup table (-1 when absent)
	/// </summary>
	internal int[] IdToOffsets => _idToOffsets;

	/// <summary>
	/// Ids of components with change tracking
	/// </summary>
	internal int[] TrackedIds => _trackedIds;

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
	/// <returns>If this <see cref="Archetype"/> has component of type <typeparamref name="T"/></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Has<T>() =>
		Signature.Test(Component<T>.Id);

    /// <summary>
    /// If this <see cref="Archetype"/> contains any 1 of the given components
    /// </summary>
    /// <returns>If this <see cref="Archetype"/> has component of type <typeparamref name="T"/></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool HasAny<T>() =>
        Signature.Test(Component<T>.Id);

    /// <summary>
    /// Returns a chunk enumerator
    /// </summary>
    public ChunkIterator GetChunks(ChangeFilter? changeFilter = null, int? compareVersion = null) => new(_chunks.AsSpan(0, ChunksInUse), changeFilter, compareVersion);

	/// <summary>
	/// Returns a chunk enumerator
	/// </summary>
	public ReadOnlyEnumerator<Chunk> GetEnumerator() => new(_chunks.AsSpan(0, ChunksInUse));

	/// <summary>
	/// Clears all entities
	/// </summary>
	internal void Clear()
	{
		for (int i = 0; i < ChunksInUse; i++)
		{
			ref var chunk = ref _chunks[i];
			if (_bufferColumns.Length != 0)
			{
				for (int j = 0; j < chunk.EntityCount; j++)
					ClearBuffers(ref chunk, j);
			}
            foreach (var array in chunk.ManagedComponents)
                Array.Clear(array, 0, chunk.EntityCount);
            chunk.EntityCount = 0;
		}
		ChunksInUse = 1;
		EntityCount = 0;
	}

	/// <summary>
	/// Gets the offset of a component type with a given id
	/// </summary>
	/// <param name="id">The component type id</param>
	/// <returns>Offset of the component type with the given id</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal int GetOffset(int id)
	{
		return _idToOffsets[id];
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
			ReplaceChunkArray(Math.Max(newChunkCount, _chunks.Length * 2));

		for (var i = ChunksAllocated; i < newChunkCount; i++)
			_chunks[i] = AllocateChunk();
		if (newChunkCount > ChunksAllocated)
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
			ReplaceChunkArray(Math.Max(InitialChunkCapacity, count * 2));

		ref var chunk = ref _chunks[count];
		if (count >= ChunksAllocated)
		{
			ChunksAllocated++;
			chunk = AllocateChunk();
		}

		ChunksInUse = ++count;
		return ref chunk;
	}

	/// <summary>
	/// Allocates a zeroed chunk. Reserved chunks must not hold garbage when they are later brought into use.
	/// </summary>
	private Chunk AllocateChunk()
	{
		var unmanagedComponents = Marshal.AllocHGlobal(_unmanagedChunkByteSize);
		Unsafe.InitBlockUnaligned((void*)unmanagedComponents, 0, (uint)_unmanagedChunkByteSize);
		var managedComponents = ArchetypeUtils.CreateManagedComponentArrays(_arrayFactories, EntitiesPerChunk);
		var changeFilters = ArchetypeUtils.BuildChangeVersions(_globalChangeVersions);
		return new Chunk(unmanagedComponents, managedComponents, _globalChangeVersions, changeFilters, _idToOffsets);
	}

	/// <summary>
	/// Gets a ref to a <see cref="Chunk"/> at a given index
	/// </summary>
	/// <param name="index">Index of the <see cref="Chunk"/> to get</param>
	/// <returns>A reference to the <see cref="Chunk"/></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ref Chunk GetChunk(int index)
	{
		return ref _chunks[index];
	}

	// By-entity access. The slot comes from the entity map, so its chunk index is in range, and the
	// offset is read from this archetype instead of the chunk: the two loads overlap rather than chain.

	/// <summary>
	/// Readonly ref to component <typeparamref name="T0"/> of the entity at <paramref name="slot"/>
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ref readonly T0? Read<T0>(EntitySlot slot)
	{
		var offset = ArrayAccess.At(_idToOffsets, ComponentSingleWritable<T0>.Id);
		if (offset < 0) throw ThrowHelper.ComponentNotFound(typeof(T0));
		return ref ComponentRef<T0>(ref ArrayAccess.At(_chunks, slot.ChunkIndex), offset, slot.Index);
	}

	/// <summary>
	/// Copies component <typeparamref name="T0"/> of the entity at <paramref name="slot"/>; false when this
	/// archetype has no <typeparamref name="T0"/>
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal bool TryRead<T0>(EntitySlot slot, out T0? component)
	{
		var offset = ArrayAccess.At(_idToOffsets, Component<T0>.Id);
		if (offset < 0)
		{
			component = default;
			return false;
		}
		_ = ComponentSingleWritable<T0>.Id; // a buffer component present throws here, as Read does
		component = ComponentRef<T0>(ref ArrayAccess.At(_chunks, slot.ChunkIndex), offset, slot.Index);
		return true;
	}

	/// <summary>
	/// Ref to component <typeparamref name="T0"/> of the entity at <paramref name="slot"/>; marks its chunk changed
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ref T0? Write<T0>(EntitySlot slot)
	{
		var id = ComponentSingleWritable<T0>.Id;
		var offset = ArrayAccess.At(_idToOffsets, id);
		if (offset < 0) throw ThrowHelper.ComponentNotFound(typeof(T0));
		ref var chunk = ref ArrayAccess.At(_chunks, slot.ChunkIndex);
		if (ComponentMeta<T0>.TrackChanges) ChangeVersions.Mark(chunk.LocalChangeVersions, _globalChangeVersions, id);
		return ref ComponentRef<T0>(ref chunk, offset, slot.Index);
	}

	/// <summary>
	/// Buffer <typeparamref name="T0"/> of the entity at <paramref name="slot"/>
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ReadBuffer<T0> ReadBuffer<T0>(EntitySlot slot) where T0 : unmanaged
	{
		var offset = ArrayAccess.At(_idToOffsets, ComponentBufferWritable<T0>.Id);
		if (offset < 0) throw ThrowHelper.ComponentNotFound(typeof(T0));
		return new ReadBuffer<T0>(BufferPointer<T0>(ref ArrayAccess.At(_chunks, slot.ChunkIndex), offset, slot.Index));
	}

	/// <summary>
	/// Buffer <typeparamref name="T0"/> of the entity at <paramref name="slot"/>; marks its chunk changed
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal WriteBuffer<T0> WriteBuffer<T0>(EntitySlot slot) where T0 : unmanaged
	{
		var id = ComponentBufferWritable<T0>.Id;
		var offset = ArrayAccess.At(_idToOffsets, id);
		if (offset < 0) throw ThrowHelper.ComponentNotFound(typeof(T0));
		ref var chunk = ref ArrayAccess.At(_chunks, slot.ChunkIndex);
		if (ComponentMeta<T0>.TrackChanges) ChangeVersions.Mark(chunk.LocalChangeVersions, _globalChangeVersions, id);
		return new WriteBuffer<T0>(BufferPointer<T0>(ref chunk, offset, slot.Index));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static ref T0? ComponentRef<T0>(ref Chunk chunk, int offset, int index)
	{
		return ref ComponentMeta<T0>.IsUnmanaged
			? ref Unsafe.AsRef<T0?>((void*)(chunk.UnmanagedComponents + offset + index * ComponentMeta<T0>.Stride))
			: ref ((T0?[])chunk.ManagedComponents[offset])[index];
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void* BufferPointer<T0>(ref Chunk chunk, int offset, int index) where T0 : unmanaged
	{
		return (void*)(chunk.UnmanagedComponents + offset + index * ComponentMeta<T0>.Stride);
	}

	/// <summary>
	/// Adds an <see cref="Entity"/> to the last <see cref="Chunk"/>
	/// </summary>
	/// <param name="entity">The <see cref="Entity"/> to add</param>
	/// <param name="slot">The filled <see cref="EntitySlot"/></param>
	/// <returns>A reference to the chunk holding the new row; its component values are whatever the slot last held</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ref Chunk AddEntity(Entity entity, out EntitySlot slot)
	{
		var chunkIndex = ChunksInUse - 1;
		ref var chunk = ref _chunks[chunkIndex];
		var index = chunk.EntityCount;
		if (index >= EntitiesPerChunk)
			return ref AddEntityToNewChunk(entity, out slot);

		chunk.EntityCount = index + 1;
		chunk.WriteEntity(index) = entity;
		EntityCount++;
		slot = new EntitySlot(index, chunkIndex);
		return ref chunk;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ref Chunk AddEntityToNewChunk(Entity entity, out EntitySlot slot)
	{
		ref var chunk = ref AddChunk();
		chunk.EntityCount = 1;
		chunk.WriteEntity(0) = entity;
		EntityCount++;
		slot = new EntitySlot(0, ChunksInUse - 1);
		return ref chunk;
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
	/// Defaults every component of the row at <paramref name="index"/>: unmanaged values zeroed, buffers
	/// empty, managed values null
	/// </summary>
	internal void InitEntity(ref Chunk chunk, int index)
	{
		var basePtr = (byte*)chunk.UnmanagedComponents;
		foreach (ref readonly var column in _dataColumns.AsSpan())
			ChunkMemory.Zero(basePtr + column.Offset + column.Stride * index, column.Stride);

		foreach (ref readonly var column in _bufferColumns.AsSpan())
			DynamicBuffer.Init(basePtr + column.Offset + column.Stride * index, column.InternalCapacity);

		foreach (var array in chunk.ManagedComponents)
			Array.Clear(array, index, 1);
	}

	/// <summary>
	/// Initializes every buffer of the row at <paramref name="index"/> to empty
	/// </summary>
	internal void InitBuffers(ref Chunk chunk, int index)
	{
		var basePtr = (byte*)chunk.UnmanagedComponents;
		foreach (ref readonly var column in _bufferColumns.AsSpan())
			DynamicBuffer.Init(basePtr + column.Offset + column.Stride * index, column.InternalCapacity);
	}

	/// <summary>
	/// Releases every buffer of the row at <paramref name="index"/>
	/// </summary>
	internal void ClearBuffers(ref Chunk chunk, int index)
	{
		var basePtr = (byte*)chunk.UnmanagedComponents;
		foreach (ref readonly var column in _bufferColumns.AsSpan())
			DynamicBuffer.Clear(basePtr + column.Offset + column.Stride * index);
	}

	/// <summary>
	/// Removes an <see cref="Entity"/> at the given <see cref="EntitySlot"/>
	/// </summary>
	/// <param name="slot">The <see cref="EntitySlot"/> to remove</param>
	/// <param name="movedEntityId">The entity id that filled the removed <see cref="EntitySlot"/></param>
	internal void RemoveEntity(in EntitySlot slot, out int movedEntityId)
	{
		var lastChunkIndex = ChunksInUse - 1;
		ref var lastChunk = ref _chunks[lastChunkIndex];
		var lastIndex = lastChunk.EntityCount - 1;

		// guard structural invariants: a violation here means the entity map and
		// chunk storage have diverged — fail loudly instead of corrupting memory
		// via negative-index copies
		if ((uint)slot.ChunkIndex > (uint)lastChunkIndex || lastIndex < 0 || slot.Index >= _chunks[slot.ChunkIndex].EntityCount)
			throw new EntityException(-1,
				$"RemoveEntity invariant violation: slot={slot.Index}@chunk{slot.ChunkIndex} (chunkCount={_chunks[slot.ChunkIndex].EntityCount}) " +
				$"ChunksInUse={ChunksInUse} lastChunkCount={lastChunk.EntityCount} archetypeEntityCount={EntityCount}");

		ref var chunk = ref _chunks[slot.ChunkIndex];
		if (slot.ChunkIndex == lastChunkIndex && slot.Index == lastIndex)
		{
			// removing the tail row: nothing moves into the hole, only release its managed references
			movedEntityId = chunk.Entity(lastIndex).Id;
			foreach (var array in chunk.ManagedComponents)
				Array.Clear(array, lastIndex, 1);
		}
		else
		{
			movedEntityId = chunk.AcceptEntity(slot.Index, ref lastChunk, lastIndex, _copyColumns);
			InheritChanges(ref chunk, in lastChunk);
		}

		lastChunk.EntityCount = lastIndex;
		EntityCount--;

		if (lastIndex == 0 && ChunksInUse > 1)
			ChunksInUse--;
	}

	/// <summary>
	/// An entity moved into <paramref name="dst"/> takes its pending changes along: every tracked
	/// component's change version in <paramref name="dst"/> becomes at least <paramref name="src"/>'s,
	/// so a change filter that hasn't consumed the source chunk's changes still visits the chunk the
	/// entity now lives in. (Never lowers a version; at worst a neighbour is reported too.)
	/// </summary>
	private void InheritChanges(ref Chunk dst, in Chunk src)
	{
		var trackedIds = _trackedIds;
		if (trackedIds.Length == 0) return;

		var srcVersions = src.LocalChangeVersions;
		var dstVersions = dst.LocalChangeVersions;
		if (ReferenceEquals(srcVersions, dstVersions)) return;

		foreach (var id in trackedIds)
		{
			var version = srcVersions[id];
			if (version - dstVersions[id] > 0) // wrap-safe "newer than"
				dstVersions[id] = version;
		}
	}

	/// <summary>
	/// Marks every tracked component of a chunk changed
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal void MarkTrackedChanged(ref Chunk chunk)
	{
		foreach (var id in _trackedIds)
			chunk.MarkChanged(id);
	}

	/// <summary>
	/// Clones components internally
	/// </summary>
	internal void CloneComponents(in EntitySlot srcSlot, ref Chunk dstChunk, int dstIndex)
	{
		ref var srcChunk = ref GetChunk(srcSlot.ChunkIndex);
		var srcIndex = srcSlot.Index;
		var srcBase = (byte*)srcChunk.UnmanagedComponents;
		var dstBase = (byte*)dstChunk.UnmanagedComponents;
		foreach (ref readonly var column in _copyColumns.AsSpan())
		{
			var src = srcBase + column.Offset + column.Stride * srcIndex;
			var dst = dstBase + column.Offset + column.Stride * dstIndex;
			if (column.InternalCapacity > 0)
				DynamicBuffer.Clone(src, dst, (uint)column.Stride);
			else
				ChunkMemory.Copy(dst, src, column.Stride);
		}

		var srcManaged = srcChunk.ManagedComponents;
		var dstManaged = dstChunk.ManagedComponents;
		for (int i = 0; i < srcManaged.Length; i++)
			Array.Copy(srcManaged[i], srcIndex, dstManaged[i], dstIndex, 1);

		MarkTrackedChanged(ref dstChunk);
	}

	/// <summary>
	/// Moves the components of a row into a row of another <see cref="Archetype"/>: values both
	/// archetypes share are copied, buffers <paramref name="dstArchetype"/> drops are released, and
	/// components it adds start defaulted (buffers empty). The source row is left for
	/// <see cref="RemoveEntity"/> to fill.
	/// </summary>
	internal void MoveComponents(ref Chunk srcChunk, int srcIndex, Archetype dstArchetype, ref Chunk dstChunk, int dstIndex)
	{
		var dstOffsets = dstArchetype._idToOffsets;
		var srcBase = (byte*)srcChunk.UnmanagedComponents;
		var dstBase = (byte*)dstChunk.UnmanagedComponents;

		foreach (ref readonly var column in _copyColumns.AsSpan())
		{
			var src = srcBase + column.Offset + column.Stride * srcIndex;
			var dstOffset = dstOffsets[column.Id];
			if (dstOffset >= 0)
				ChunkMemory.Copy(dstBase + dstOffset + column.Stride * dstIndex, src, column.Stride);
			else if (column.InternalCapacity > 0)
				DynamicBuffer.Clear(src); // dropped buffer: release its heap block
		}

		// components the destination adds start defaulted: the row may still hold a previous occupant's values
		var srcOffsets = _idToOffsets;
		foreach (ref readonly var column in dstArchetype._dataColumns.AsSpan())
		{
			if (srcOffsets[column.Id] < 0)
				ChunkMemory.Zero(dstBase + column.Offset + column.Stride * dstIndex, column.Stride);
		}
		foreach (ref readonly var column in dstArchetype._bufferColumns.AsSpan())
		{
			if (srcOffsets[column.Id] < 0)
				DynamicBuffer.Init(dstBase + column.Offset + column.Stride * dstIndex, column.InternalCapacity);
		}

		var managedIds = _managedIds;
		if (managedIds.Length != 0)
		{
			var srcManaged = srcChunk.ManagedComponents;
			var dstManaged = dstChunk.ManagedComponents;
			for (int i = 0; i < managedIds.Length; i++)
			{
				var dstArrayIndex = dstOffsets[managedIds[i]];
				if (dstArrayIndex >= 0)
					Array.Copy(srcManaged[i], srcIndex, dstManaged[dstArrayIndex], dstIndex, 1);
			}
		}

		dstArchetype.MarkTrackedChanged(ref dstChunk);
	}

	/// <summary>
	/// The archetype reached by adding component <paramref name="id"/>, if already resolved
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal Archetype? GetAddEdge(int id)
	{
		var edges = _addEdges;
		return edges is null ? null : edges[id];
	}

	/// <summary>
	/// The archetype reached by removing component <paramref name="id"/>, if already resolved
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal Archetype? GetRemoveEdge(int id)
	{
		var edges = _removeEdges;
		return edges is null ? null : edges[id];
	}

	internal void SetAddEdge(int id, Archetype archetype) =>
		(_addEdges ??= new Archetype?[ComponentRegistry.MaxComponents])[id] = archetype;

	internal void SetRemoveEdge(int id, Archetype archetype) =>
		(_removeEdges ??= new Archetype?[ComponentRegistry.MaxComponents])[id] = archetype;

	/// <summary>
	/// Forgets resolved transitions (an archetype they may point at was removed)
	/// </summary>
	internal void ClearEdges()
	{
		_addEdges = null;
		_removeEdges = null;
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

		// shrink the chunk array
		var length = Math.Max(InitialChunkCapacity, ChunksAllocated);
		if (length < _chunks.Length)
			ReplaceChunkArray(length);
	}

	/// <summary>
	/// Moves the chunks into a new array of <paramref name="length"/>. The old array is cleared and left to
	/// the GC, never pooled: a chunk ref or <see cref="EntityData"/> still pointing into it then finds an
	/// empty chunk (EntityData throws) instead of whatever another archetype rented that array for.
	/// </summary>
	private void ReplaceChunkArray(int length)
	{
		var newArray = new Chunk[length];
		Array.Copy(_chunks, newArray, ChunksAllocated);
		Array.Clear(_chunks, 0, _chunks.Length);
		_chunks = newArray;
	}

	internal void Dispose()
	{
		if (_disposed) return;
#pragma warning disable CA1816 // Dispose methods should call SuppressFinalize
		GC.SuppressFinalize(this);
#pragma warning restore CA1816 // Dispose methods should call SuppressFinalize
		_disposed = true;
		// suppressing the finalizer used to be all Dispose did, so the finalizer's free never ran and
		// every disposed archetype leaked its chunks
		DoDispose();
	}

	/// <summary>
	/// Frees chunk memory and the heap blocks of buffers that outgrew their inline capacity. The
	/// archetype is left with no chunks, so anything still holding it (a query's match list, an
	/// enumerator) sees it empty.
	/// </summary>
	private void DoDispose()
	{
		var chunks = _chunks;
		for (int i = 0; i < ChunksAllocated; i++)
		{
			ref var chunk = ref chunks[i];
			if (chunk.UnmanagedComponents == 0) continue;
			if (i < ChunksInUse && _bufferColumns.Length != 0)
			{
				for (int row = 0; row < chunk.EntityCount; row++)
					ClearBuffers(ref chunk, row);
			}
			Marshal.FreeHGlobal(chunk.UnmanagedComponents);
			chunk = default;
		}
		ChunksAllocated = 0;
		ChunksInUse = 0;
		EntityCount = 0;
	}
}
