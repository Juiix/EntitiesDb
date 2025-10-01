using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EntitiesDb;

public unsafe sealed class Archetype
{
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
		_idToOffsets = ArchetypeUtils.BuildIdOffsetLookup(componentTypes, EntitiesPerChunk, unmanagedComponentCount);

		AddChunk();
	}

	~Archetype() => DoDispose();

	/// <summary>
	/// The component bitset signature
	/// </summary>
	public Signature Signature { get; }

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
	/// If this <see cref="Archetype"/> contains a given <see cref="ComponentType.Id"/>
	/// </summary>
	/// <param name="componentTypeId"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Has(int componentTypeId) =>
		Signature.Test(componentTypeId);

	/// <summary>
	/// Returns a chunk enumerator
	/// </summary>
	public ReadOnlyEnumerator<Chunk> GetEnumerator => new(_chunks.AsSpan(0, ChunkCount));

	/// <summary>
	/// The current working chunk (last chunk)
	/// </summary>
	internal ref Chunk CurrentChunk => ref _chunks[ChunkCount - 1];

	internal ref T? Get<T>(int typeId, in EntitySlot slot)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		return ref chunk.Get<T>(slot.Index, typeId);
	}

	internal ComponentBuffer<T> GetBuffer<T>(int typeId, in EntitySlot slot) where T : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		return chunk.GetBuffer<T>(slot.Index, typeId);
	}

	internal void Set<T>(int typeId, in EntitySlot slot, in T? value)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Get<T>(slot.Index, typeId) = value;
	}

	internal void SetBuffer<T>(int typeId, in EntitySlot slot, ReadOnlySpan<T> values) where T : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var buffer = chunk.GetBuffer<T>(slot.Index, typeId);
		buffer.Clear();
		buffer.AddRange(values);
	}

	internal ComponentBuffer<T> InitBuffer<T>(int typeId, in EntitySlot slot, ReadOnlySpan<T> values) where T : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offset = chunk.IdToOffsets[typeId];
		ref var header = ref chunk.GetUnmanaged<ComponentBufferHeader>(offset + ComponentMeta<T>.Stride * slot.Index);
		var buffer = new ComponentBuffer<T>(ref header);
		buffer.Init(ComponentMeta<T>.InternalCapacity, values);
		return buffer;
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
	internal EntitySlot AddEntity(Entity entity)
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
			return new EntitySlot(index, chunkIndex);
		}

		// new chunk
		index = 0;
		currentChunk = ref AddChunk();
		currentChunk.EntityCount++;
		currentChunk.AddEntity(index, entity);
		return new EntitySlot(index, chunkIndex + 1);
	}

	/// <summary>
	/// Gets a reference to the <see cref="Entity"/> at the given <see cref="EntitySlot"/>
	/// </summary>
	/// <param name="entitySlot">The <see cref="EntitySlot"/> to check</param>
	/// <returns>The <see cref="Entity"/> reference</returns>
	internal ref Entity GetEntity(EntitySlot entitySlot)
	{
		ref var chunk = ref _chunks[entitySlot.ChunkIndex];
		return ref chunk.GetEntity(entitySlot.Index);
	}

	/// <summary>
	/// Removes an <see cref="Entity"/> at the given <see cref="EntitySlot"/>
	/// </summary>
	/// <param name="slot">The <see cref="EntitySlot"/> to remove</param>
	/// <param name="movedEntityId">The entity id that filled the removed <see cref="EntitySlot"/></param>
	internal void RemoveEntity(EntitySlot slot, out int movedEntityId)
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