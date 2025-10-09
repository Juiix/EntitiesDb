using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

/// <summary>
/// A chunk of entities, stored as rows across tight component array columns
/// </summary>
public partial struct Chunk
{
	internal Chunk(ComponentType[] componentTypes, int[] idToOffsets, nint unmanagedComponents, Array[] managedComponents, int unmanagedComponentCount)
	{
		ComponentTypes = componentTypes;
		IdToOffsets = idToOffsets;
		UnmanagedComponents = unmanagedComponents;
		ManagedComponents = managedComponents;
		UnmanagedComponentCount = unmanagedComponentCount;
	}

	/// <summary>
	/// Archetype component types for ease-of-access
	/// </summary>
	internal readonly ComponentType[] ComponentTypes { get; }

	/// <summary>
	/// Archetype id to offsets for ease-of-access.
	/// </summary>
	internal readonly int[] IdToOffsets { get; }

	/// <summary>
	/// Base pointer to the unmanaged component block (component slices inside).
	/// </summary>
	internal readonly nint UnmanagedComponents { get; }

	/// <summary>
	/// One entry per managed component type (e.g., <c>T[]</c> boxed as <see cref="Array"/>).
	/// </summary>
	internal readonly Array[] ManagedComponents { get; }

	/// <summary>
	/// The count of entities stored in this chunk
	/// </summary>
	public int EntityCount { readonly get; internal set; }

	/// <summary>
	/// Count of unmanaged components
	/// </summary>
	/// <remarks>
	/// <see cref="ComponentTypes"/> are laid out in unmanaged types first. Use <see cref="UnmanagedComponentCount"/> as the boundary.
	/// </remarks>
	internal readonly int UnmanagedComponentCount { get; }

	/// <summary>
	/// A span helper for unmanaged component types
	/// </summary>
	internal readonly ReadOnlySpan<ComponentType> UnmanagedComponentTypes => ComponentTypes.AsSpan(0, UnmanagedComponentCount);

	/// <summary>
	/// A span helper for managed component types
	/// </summary>
	internal readonly ReadOnlySpan<ComponentType> ManagedComponentTypes => ComponentTypes.AsSpan(UnmanagedComponentCount);

	/// <summary>
	/// Gets a reference to an <see cref="Entity"/> at a given index
	/// </summary>
	/// <param name="index">The index of the <see cref="Entity"/> to get</param>
	/// <returns>A reference to the <see cref="Entity"/> at <paramref name="index"/></returns>
	public unsafe readonly ref readonly Entity GetEntity(int index)
	{
		return ref GetUnmanaged<Entity>(index * sizeof(Entity));
	}

	/// <summary>
	/// Returns a reference to a component at a given index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <param name="index">The index to get</param>
	/// <returns>A reference at <paramref name="index"/></returns>
	public readonly unsafe ref T0? Get<T0>(int index, int typeId)
	{
		var offset = GetOffset<T0>(typeId);
		return ref ComponentMeta<T0>.IsUnmanaged
			? ref Unsafe.AsRef<T0?>((void*)(UnmanagedComponents + offset + index * ComponentMeta<T0>.Stride))
			: ref ((T0?[])ManagedComponents[offset])[index];
    }

	/// <summary>
	/// Returns a readonly reference to a component at a given index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <param name="index">The index to get</param>
	/// <returns>A readonly reference at <paramref name="index"/></returns>
	public readonly unsafe ref T0? GetReadOnly<T0>(int index, int typeId)
	{
		var offset = GetOffset<T0>(typeId);
		return ref ComponentMeta<T0>.IsUnmanaged
            ? ref Unsafe.AsRef<T0?>((void*)(UnmanagedComponents + offset + index * ComponentMeta<T0>.Stride))
            : ref ((T0?[])ManagedComponents[offset])[index];
    }

	/// <summary>
	/// Returns a buffer of components at a given index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <param name="index">The index to get</param>
	/// <returns>A buffer of components at <paramref name="index"/></returns>
	public readonly unsafe DynamicBuffer<T0> GetBuffer<T0>(int index, int typeId) where T0 : unmanaged
	{
		var offset = GetOffset<T0>(typeId);
		return new DynamicBuffer<T0>((void*)(UnmanagedComponents + offset + index * ComponentMeta<T0>.Stride));
    }

	/// <summary>
	/// Returns a readonly buffer of components at a given index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <param name="index">The index to get</param>
	/// <returns>A readonly buffer of components at <paramref name="index"/></returns>
	public readonly unsafe ReadOnlyBuffer<T0> GetBufferReadOnly<T0>(int index, int typeId) where T0 : unmanaged
	{
		var offset = GetOffset<T0>(typeId);
		return new ReadOnlyBuffer<T0>((void*)(UnmanagedComponents + offset + index * ComponentMeta<T0>.Stride));
	}

	/// <summary>
	/// Returns a handle to a component at the first index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <returns>A <see cref="Handle{T}"/> to the first index</returns>
	public readonly ReadOnlyHandle<Entity> GetEntityHandle()
	{
		return new ReadOnlyHandle<Entity>(ref GetEntityMutable(0));
	}

	/// <summary>
	/// Returns a handle to a component at the first index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <returns>A <see cref="Handle{T}"/> to the first index</returns>
	public readonly Handle<T0?> GetHandle<T0>(int typeId)
	{
		return new Handle<T0?>(ref Get<T0>(0, typeId));
	}

	/// <summary>
	/// Returns a readonly handle to a component at the first index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <returns>A <see cref="ReadOnlyHandle{T}"/> to the first index</returns>
	public readonly ReadOnlyHandle<T0?> GetHandleReadOnly<T0>(int typeId)
	{
		return new ReadOnlyHandle<T0?>(ref GetReadOnly<T0>(0, typeId));
	}

	/// <summary>
	/// Returns a handle to a buffer of components at the first index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <returns>A <see cref="DynamicBufferHandle{T}"/> to the first index</returns>
	public readonly DynamicBufferHandle<T0> GetBufferHandle<T0>(int typeId) where T0 : unmanaged
	{
		return new DynamicBufferHandle<T0>(GetBuffer<T0>(0, typeId));
	}

	/// <summary>
	/// Returns a readonly handle to a buffer of components at the first index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <returns>A <see cref="ReadOnlyBufferHandle{T}"/> to the first index</returns>
	public readonly unsafe ReadOnlyBufferHandle<T0> GetBufferHandleReadOnly<T0>(int typeId) where T0 : unmanaged
	{
		return new ReadOnlyBufferHandle<T0>(GetBufferReadOnly<T0>(0, typeId));
	}

	/// <summary>
	/// Returns if the chunk contains a component type of the given id
	/// </summary>
	/// <param name="typeId">The component type id</param>
	/// <returns>If the chunk contains a component type of <paramref name="typeId"/></returns>
	public readonly bool Has(int typeId) =>
		TryGetOffset(typeId, out _);

	/// <summary>
	/// Returns if the chunk contains components types of the given ids
	/// </summary>
	/// <param name="ids">The component type ids</param>
	/// <returns>If the chunk contains component types of <paramref name="ids"/></returns>
	public readonly bool Has<T0>(in ComponentIds<T0> ids) =>
		Has(ids.T0);

	/// <summary>
	/// Sets and replaces component value values
	/// </summary>
	/// <param name="index">The chunk index</param>
	/// <param name="ids"><see cref="ComponentIds{T0}"/> retrieved via <see cref=""/></param>
	/// <param name="component"></param>
	public readonly void Set<T0>(int index, int typeId, in T0? component)
	{
		if (ComponentMeta<T0>.IsZeroSize)
			return;
		Get<T0>(index, typeId) = component;
	}

	/// <summary>
	/// Sets and replaces component value values
	/// </summary>
	/// <param name="index">The chunk index</param>
	/// <param name="ids"><see cref="ComponentIds{T0}"/> retrieved via <see cref=""/></param>
	/// <param name="components"></param>
	public readonly void Set<T0>(int index, int typeId, in ReadOnlySpan<T0> components) where T0 : unmanaged
	{
		if (ComponentMeta<T0>.IsZeroSize)
			return;
		GetBuffer<T0>(index, typeId).Set(components);
	}

	/// <summary>
	/// Returns an index enumerator
	/// </summary>
	/// <returns></returns>
	public readonly IndexEnumerator GetEnumerator()
	{
		return new IndexEnumerator(EntityCount);
	}

	/// <summary>
	/// Initializes component value values
	/// </summary>
	internal readonly void Init<T0>(int index, in ComponentIds<T0> ids, in ReadOnlySpan<T0> components) where T0 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(components);
	}

	/// <summary>
	/// Returns a reference to an unmanaged component at a given offset
	/// </summary>
	/// <typeparam name="T">The unmanaged type</typeparam>
	/// <param name="offset">The byte offset</param>
	/// <returns>An unmanaged reference at <paramref name="offset"/></returns>
	internal readonly unsafe ref T? GetUnmanaged<T>(int offset)
    {
        var ptr = UnmanagedComponents + offset;
        return ref Unsafe.AsRef<T?>((void*)ptr);
    }

	/// <summary>
	/// Clears a buffer of components and releases allocated lists
	/// </summary>
	/// <param name="index">Index of the buffer to clear</param>
	/// <param name="typeId">The component type id</param>
    internal readonly void ClearBuffer<T>(int index, int typeId)
	{
		var offset = IdToOffsets[typeId];
		ref var header = ref GetUnmanaged<BufferHeader>(offset + index * ComponentMeta<T>.Stride);
		DynamicBuffer.Clear(ref header);
	}

    /// <summary>
    /// Adds an entityId at the given index
    /// </summary>
    /// <param name="index">The index to set</param>
    /// <param name="entityId">The entity id to add</param>
    internal readonly unsafe void AddEntity(int index, Entity entityId)
	{
		GetEntityMutable(index) = entityId;
	}

	/// <summary>
	/// Gets an <see cref="Entity"/> ref at a given index
	/// </summary>
	/// <param name="index">The index of the <see cref="Entity"/> to get</param>
	/// <returns>A <c>ref</c> of the <see cref="Entity"/> retrieved</returns>
	internal readonly unsafe ref Entity GetEntityMutable(int index)
	{
		return ref GetUnmanaged<Entity>(index * sizeof(Entity));
	}

	/// <summary>
	/// Gets the offset for a component type of a given id
	/// </summary>
	/// <param name="typeId">The component type id</param>
	/// <returns>Offset for a component type of <paramref name="typeId"/></returns>
	internal readonly int GetOffset<T>(int typeId)
	{
		if (ComponentMeta<T>.IsZeroSize)
			throw ThrowHelper.ComponentZeroSize(typeof(T));

		if (typeId >= IdToOffsets.Length)
			throw ThrowHelper.ComponentNotFound(typeof(T));
		var offset = IdToOffsets[typeId];
		if (offset < 0)
			throw ThrowHelper.ComponentNotFound(typeof(T));
		return offset;
	}

	/// <summary>
	/// Trys to get the offset of a given component type id
	/// </summary>
	/// <param name="typeId">The component type id</param>
	/// <param name="offset">Offset for a component type of <paramref name="typeId"/></param>
	/// <returns>If the offset was found for component type of <paramref name="typeId"/></returns>
	internal readonly bool TryGetOffset(int typeId, out int offset)
	{
		if (typeId >= IdToOffsets.Length)
		{
			offset = -1;
			return false;
		}
		offset = IdToOffsets[typeId];
		return offset >= 0;
	}

	/// <summary>
	/// Accepts an entity transferred from a source chunk.
	/// </summary>
	/// <param name="dstIndex">The index to transfer into</param>
	/// <param name="srcChunk">The source <see cref="Chunk"/></param>
	/// <param name="srcIndex">the index to transfer from</param>
	/// <returns>The entity id of the transferred entity</returns>
	internal readonly unsafe int AcceptEntity(int dstIndex, ref Chunk srcChunk, int srcIndex)
	{
		// get src entity
		var srcEntity = srcChunk.GetEntity(srcIndex);

		// copy entity id
		GetEntityMutable(dstIndex) = srcEntity;

		// copy unmanaged components
		var offsetLookup = IdToOffsets;
		var srcPtr = srcChunk.UnmanagedComponents;
		var dstPtr = UnmanagedComponents;
		foreach (ref readonly var componentType in UnmanagedComponentTypes)
		{
			var offset = offsetLookup[componentType.Id];
			Unsafe.CopyBlock(
				(byte*)dstPtr + offset + componentType.Stride * dstIndex,
				(byte*)srcPtr + offset + componentType.Stride * srcIndex,
				(uint)componentType.Stride
			);
		}

		// copy managed components
		for (int i = 0; i < ManagedComponents.Length; i++)
		{
			var srcArray = srcChunk.ManagedComponents[i];
			var dstArray = ManagedComponents[i];
			Array.Copy(srcArray, srcIndex, dstArray, dstIndex, 1);
		}

		return srcEntity.Id;
	}

	/// <summary>
	/// Clones components to a destination <see cref="Chunk"/> within the same <see cref="Archetype"/>
	/// </summary>
	/// <param name="srcIndex">Index of the components to clone</param>
	/// <param name="dstChunk">The chunk to clone into</param>
	/// <param name="dstIndex">Index of the destination components</param>
	internal readonly unsafe void CloneComponents(int srcIndex, ref Chunk dstChunk, int dstIndex)
	{
		var offsetLookup = IdToOffsets;

		// copy unmanaged components
		var srcPtr = UnmanagedComponents;
		var dstPtr = dstChunk.UnmanagedComponents;
		foreach (ref readonly var componentType in UnmanagedComponentTypes)
		{
			// copy component
			var offset = offsetLookup[componentType.Id];
			Unsafe.CopyBlock(
				(byte*)dstPtr + offset + componentType.Stride * dstIndex,
				(byte*)srcPtr + offset + componentType.Stride * srcIndex,
				(uint)componentType.Stride
			);
		}

		// copy managed components
		var srcMananagedComponents = ManagedComponents;
		var dstMananagedComponents = dstChunk.ManagedComponents;
		var length = srcMananagedComponents.Length;
		for (int i = 0; i < length; i++)
		{
			Array.Copy(
				srcMananagedComponents[i], srcIndex,
				dstMananagedComponents[i], dstIndex,
				1
			);
		}
	}

	/// <summary>
	/// Copies components to any destination <see cref="Chunk"/>
	/// </summary>
	/// <param name="srcIndex">Index of the components to copy</param>
	/// <param name="dstSignature">The <see cref="Signature"/> of <paramref name="dstChunk"/></param>
	/// <param name="dstChunk">The chunk to copy into</param>
	/// <param name="dstIndex">Index of the destination components</param>
	internal readonly unsafe void CopyComponents(int srcIndex, in Signature dstSignature, ref Chunk dstChunk, int dstIndex)
	{
		var srcOffsets = IdToOffsets;
		var dstOffsets = dstChunk.IdToOffsets;

		// copy unmanaged components
		var srcPtr = UnmanagedComponents;
		var dstPtr = dstChunk.UnmanagedComponents;
		foreach (ref readonly var componentType in UnmanagedComponentTypes)
		{
			if (!dstSignature.Test(componentType.Id))
			{
				continue; // component doesn't exist in the destination chunk
			}

			var srcOffset = srcOffsets[componentType.Id] + componentType.Stride * srcIndex;
			var dstOffset = dstOffsets[componentType.Id] + componentType.Stride * dstIndex;
			Unsafe.CopyBlock(
				(byte*)dstPtr + dstOffset,
				(byte*)srcPtr + srcOffset,
				(uint)componentType.Stride
			);
		}

		// copy managed components
		int srcArrayIndex = 0;
		var srcMananagedComponents = ManagedComponents;
		var dstMananagedComponents = dstChunk.ManagedComponents;
		foreach (ref readonly var componentType in ManagedComponentTypes)
		{
			if (!dstSignature.Test(componentType.Id))
			{
				continue; // component doesn't exist in the destination chunk
			}

			var dstArrayIndex = dstOffsets[componentType.Id];
			Array.Copy(
				srcMananagedComponents[srcArrayIndex++], srcIndex,
				dstMananagedComponents[dstArrayIndex], dstIndex,
				1
			);
		}
	}
}

