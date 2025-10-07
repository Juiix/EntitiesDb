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
    /// <see cref="ComponentType.Id"/> to index lookup table
    /// </summary>
    private readonly int[] _idToIndex;

    /// <summary>
    /// <see cref="ComponentType.Id"/> to offset lookup table
    /// </summary>
    private readonly int[] _idToOffsets;

    /// <summary>
    /// Array used to store chunks
    /// </summary>
    private Chunk[] _chunks;

	/// <summary>
	/// How many chunks are currently allocated
	/// </summary>
	private int _allocatedChunks;

	/// <summary>
	/// If this has been disposed
	/// </summary>
	private bool _disposed;

	internal Archetype(in Signature signature, ComponentType[] componentTypes, ArrayFactory[] arrayFactories, int unmanagedComponentCount, int chunkByteSize)
	{
		Signature = signature;
		ComponentTypes = componentTypes;
		_arrayFactories = arrayFactories;
		_unmangedComponentCount = unmanagedComponentCount;
		EntitiesPerChunk = ArchetypeUtils.CalculateChunkCapacity(componentTypes, chunkByteSize);
		_unmanagedChunkByteSize = ArchetypeUtils.CalculateUnmanagedSize(componentTypes.AsSpan(0, unmanagedComponentCount)) * EntitiesPerChunk;

		_chunks = ArrayPool<Chunk>.Shared.Rent(1);
		_idToIndex = ArchetypeUtils.BuildIdIndexLookup(componentTypes, unmanagedComponentCount);
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
	public int ChunkCount { get; internal set; }

	/// <summary>
	/// Returns a chunk enumerator
	/// </summary>
	public ReadOnlyEnumerator<Chunk> GetEnumerator => new(_chunks.AsSpan(0, ChunkCount));

	/// <summary>
	/// The current working chunk (last chunk)
	/// </summary>
	internal ref Chunk CurrentChunk => ref _chunks[ChunkCount - 1];

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
	/// <param name="ids">Component ids from <see cref="ComponentRegistry.GetIds{T}()"/></param>
	/// <returns>If this <see cref="Archetype"/> has <typeparamref name="T"/></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Has<T0>(in ComponentIds<T0> ids) =>
        Signature.Test(ids.T0);

    /// <summary>
    /// Clears a target slot and released buffer lists
    /// </summary>
    /// <param name="slot">The target slot</param>
    /// <param name="ids">Component ids</param>
    internal void Clear<T0>(in EntitySlot slot, in ComponentIds<T0> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
    }

	/// <summary>
	/// Clears a buffer component and releases allocated memory
	/// </summary>
	/// <remarks>
	///	You must KNOW <typeparamref name="T"/> is a buffered type before calling this
	/// </remarks>
	/// <typeparam name="T">The component type</typeparam>
	/// <param name="slot">The target slot</param>
	/// <param name="typeId">Component id for <typeparamref name="T"/></param>
    internal void ClearBuffer<T>(in EntitySlot slot, int typeId)
    {
        ref var chunk = ref _chunks[slot.ChunkIndex];
        chunk.ClearBuffer<T>(slot.Index, typeId);
    }

    internal ref T? Get<T>(in EntitySlot slot, int typeId)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		return ref chunk.Get<T>(slot.Index, typeId);
    }

    internal ref readonly T? GetReadOnly<T>(in EntitySlot slot, int typeId)
    {
        ref var chunk = ref _chunks[slot.ChunkIndex];
        return ref chunk.GetReadOnly<T>(slot.Index, typeId);
    }

    internal DynamicBuffer<T> GetBuffer<T>(in EntitySlot slot, int typeId) where T : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		return chunk.GetBuffer<T>(slot.Index, typeId);
    }

    internal ReadOnlyBuffer<T> GetBufferReadOnly<T>(in EntitySlot slot, int typeId) where T : unmanaged
    {
        ref var chunk = ref _chunks[slot.ChunkIndex];
        return chunk.GetBufferReadOnly<T>(slot.Index, typeId);
    }

	/// <summary>
	/// Initializes a buffer of components at a given slot
	/// </summary>
	internal void Init<T0>(in EntitySlot slot, in ComponentIds<T0> ids, ReadOnlySpan<T0> components) where T0 : unmanaged
    {
        ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, components);
    }

	/// <summary>
	/// Sets a component at a given slot
	/// </summary>
	internal void Set<T0>(in EntitySlot slot, in ComponentIds<T0> ids, in T0? component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in component);
	}

	/// <summary>
	/// Sets a buffer of components at a given slot
	/// </summary>
	internal void Set<T0>(in EntitySlot slot, in ComponentIds<T0> ids, ReadOnlySpan<T0> components = default) where T0 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
        chunk.Set(slot.Index, ids.T0, components);
    }

	/// <summary>
	/// Allocates of reuses a new <see cref="Chunk"/>
	/// </summary>
	/// <returns></returns>
	internal ref Chunk AddChunk()
	{
		var count = ChunkCount;
		if (count == _chunks.Length)
		{
			// expand array
			var newArray = ArrayPool<Chunk>.Shared.Rent(count + 1);
			Array.Copy(_chunks, newArray, count);
			ArrayPool<Chunk>.Shared.Return(_chunks, true);
			_chunks = newArray;
		}

		var unmanagedComponents = Marshal.AllocHGlobal(_unmanagedChunkByteSize);
		var managedComponents = ArchetypeUtils.CreateManagedComponentArrays(_arrayFactories, EntitiesPerChunk);
		//var changeVersions = ArchetypeUtils.BuildChangeVersions(ComponentTypes, _globalChangeVersions);

		ref var chunk = ref _chunks[count];
		if (count >= _allocatedChunks)
		{
			_allocatedChunks++;
			chunk = new Chunk(ComponentTypes, _idToOffsets, unmanagedComponents, managedComponents, _unmangedComponentCount);
		}

		ChunkCount = ++count;

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
		var chunkIndex = ChunkCount - 1;
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
		return ref chunk.GetEntity(entitySlot.Index);
	}

	/// <summary>
	/// Removes an <see cref="Entity"/> at the given <see cref="EntitySlot"/>
	/// </summary>
	/// <param name="slot">The <see cref="EntitySlot"/> to remove</param>
	/// <param name="movedEntityId">The entity id that filled the removed <see cref="EntitySlot"/></param>
	internal void RemoveEntity(in EntitySlot slot, out int movedEntityId)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var lastChunkIndex = ChunkCount - 1;
		ref var lastChunk = ref GetChunk(lastChunkIndex);

		var removedIndex = lastChunk.EntityCount - 1;
		movedEntityId = chunk.AcceptEntity(slot.Index, ref lastChunk, removedIndex);

		lastChunk.EntityCount--;
		EntityCount--;

		if (removedIndex > 0 || ChunkCount <= 0)
		{
			return;
		}

		ChunkCount = Math.Max(ChunkCount - 1, 1);
	}

	/// <summary>
	/// Clones components internally
	/// </summary>
	internal void CloneComponents(in EntitySlot srcSlot, in EntitySlot dstSlot)
	{
		ref var srcChunk = ref GetChunk(srcSlot.ChunkIndex);
		ref var dstChunk = ref GetChunk(dstSlot.ChunkIndex);
		srcChunk.CloneComponents(srcSlot.Index, ref dstChunk, dstSlot.Index);
	}

	/// <summary>
	/// Copies components into an external <see cref="Archetype"/>
	/// </summary>
	internal void CopyComponents(in EntitySlot srcSlot, Archetype dstArchetype, in EntitySlot dstSlot)
	{
		ref var srcChunk = ref GetChunk(srcSlot.ChunkIndex);
		ref var dstChunk = ref dstArchetype.GetChunk(dstSlot.ChunkIndex);
		srcChunk.CopyComponents(srcSlot.Index, dstArchetype.Signature, ref dstChunk, dstSlot.Index);
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
		foreach (ref var chunk in _chunks.AsSpan(0, _allocatedChunks))
		{
			Marshal.FreeHGlobal(chunk.UnmanagedComponents);
		}
	}
}