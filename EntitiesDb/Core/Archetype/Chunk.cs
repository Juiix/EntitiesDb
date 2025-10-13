using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

/// <summary>
/// A chunk of entities, stored as rows across tight component array columns
/// </summary>
public partial struct Chunk
{
	internal Chunk(nint unmanagedComponents, Array[] managedComponents)
	{
		UnmanagedComponents = unmanagedComponents;
		ManagedComponents = managedComponents;
	}

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
	/// Gets a reference to an <see cref="Entity"/> at a given index
	/// </summary>
	/// <param name="index">The index of the <see cref="Entity"/> to get</param>
	/// <returns>A reference to the <see cref="Entity"/> at <paramref name="index"/></returns>
	public unsafe readonly ref readonly Entity GetEntity(int index)
	{
		return ref GetEntityMutable(index);
	}

	/// <summary>
	/// Returns a reference to a component at a given index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <param name="index">The index to get</param>
	/// <returns>A reference at <paramref name="index"/></returns>
	public readonly unsafe ref T0? Get<T0>(int index, Offset<T0> offset)
	{
		return ref ComponentMeta<T0>.IsUnmanaged
			? ref Unsafe.AsRef<T0?>((void*)(UnmanagedComponents + offset.Value + index * ComponentMeta<T0>.Stride))
			: ref ((T0?[])ManagedComponents[offset.Value])[index];
	}

	/// <summary>
	/// Returns a readonly reference to a component at a given index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <param name="index">The index to get</param>
	/// <returns>A readonly reference at <paramref name="index"/></returns>
	public readonly unsafe ref T0? GetReadOnly<T0>(int index, Offset<T0> offset)
	{
		return ref ComponentMeta<T0>.IsUnmanaged
			? ref Unsafe.AsRef<T0?>((void*)(UnmanagedComponents + offset.Value + index * ComponentMeta<T0>.Stride))
			: ref ((T0?[])ManagedComponents[offset.Value])[index];
	}

	/// <summary>
	/// Returns a buffer of components at a given index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <param name="index">The index to get</param>
	/// <returns>A buffer of components at <paramref name="index"/></returns>
	public readonly unsafe DynamicBuffer<T0> GetBuffer<T0>(int index, Offset<T0> offset) where T0 : unmanaged
	{
		return new DynamicBuffer<T0>((void*)(UnmanagedComponents + offset.Value + index * ComponentMeta<T0>.Stride));
	}

	/// <summary>
	/// Returns a readonly buffer of components at a given index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <param name="index">The index to get</param>
	/// <returns>A readonly buffer of components at <paramref name="index"/></returns>
	public readonly unsafe ReadOnlyBuffer<T0> GetBufferReadOnly<T0>(int index, Offset<T0> offset) where T0 : unmanaged
	{
		return new ReadOnlyBuffer<T0>((void*)(UnmanagedComponents + offset.Value + index * ComponentMeta<T0>.Stride));
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
	public unsafe readonly Handle<T0?> GetHandle<T0>(Offset<T0> offset)
	{
		ref var first = ref ComponentMeta<T0>.IsUnmanaged
			? ref Unsafe.AsRef<T0?>((void*)(UnmanagedComponents + offset.Value))
			: ref ((T0?[])ManagedComponents[offset.Value])[0];
		return new Handle<T0?>(ref first);
	}

	/// <summary>
	/// Returns a readonly handle to a component at the first index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <returns>A <see cref="ReadOnlyHandle{T}"/> to the first index</returns>
	public unsafe readonly ReadOnlyHandle<T0?> GetHandleReadOnly<T0>(Offset<T0> offset)
	{
		ref var first = ref ComponentMeta<T0>.IsUnmanaged
			? ref Unsafe.AsRef<T0?>((void*)(UnmanagedComponents + offset.Value))
			: ref ((T0?[])ManagedComponents[offset.Value])[0];
		return new ReadOnlyHandle<T0?>(ref first);
	}

	/// <summary>
	/// Returns a handle to a buffer of components at the first index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <returns>A <see cref="DynamicBufferHandle{T}"/> to the first index</returns>
	public unsafe readonly DynamicBufferHandle<T0> GetBufferHandle<T0>(Offset<T0> offset) where T0 : unmanaged
	{
		var buffer = new DynamicBuffer<T0>((void*)(UnmanagedComponents + offset.Value));
		return new DynamicBufferHandle<T0>(buffer);
	}

	/// <summary>
	/// Returns a readonly handle to a buffer of components at the first index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <returns>A <see cref="ReadOnlyBufferHandle{T}"/> to the first index</returns>
	public readonly unsafe ReadOnlyBufferHandle<T0> GetBufferHandleReadOnly<T0>(Offset<T0> offset) where T0 : unmanaged
	{
		var buffer = new ReadOnlyBuffer<T0>((void*)(UnmanagedComponents + offset.Value));
		return new ReadOnlyBufferHandle<T0>(buffer);
	}

	/// <summary>
	/// Sets and replaces component value values
	/// </summary>
	/// <param name="index">The chunk index</param>
	/// <param name="component"></param>
	public unsafe readonly void Set<T0>(int index, Offset<T0> offset, in T0? component)
	{
		ref var value = ref ComponentMeta<T0>.IsUnmanaged
			? ref Unsafe.AsRef<T0?>((void*)(UnmanagedComponents + offset.Value + index * ComponentMeta<T0>.Stride))
			: ref ((T0?[])ManagedComponents[offset.Value])[index];
		value = component;
	}

	/// <summary>
	/// Sets and replaces component value values
	/// </summary>
	/// <param name="index">The chunk index</param>
	/// <param name="components"></param>
	public unsafe readonly void Set<T0>(int index, Offset<T0> offset, ReadOnlySpan<T0> components) where T0 : unmanaged
	{
		var buffer = new DynamicBuffer<T0>((void*)(UnmanagedComponents + offset.Value + index * ComponentMeta<T0>.Stride));
		buffer.Set(components);
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
	internal readonly void Init<T0>(int index, in Offsets<T0> offsets, ReadOnlySpan<T0> components) where T0 : unmanaged
	{
		GetBuffer<T0>(index, offsets.T0).Init(components);
	}

	/// <summary>
	/// Clears a buffer of components and releases allocated lists
	/// </summary>
	/// <param name="index">Index of the buffer to clear</param>
	/// <param name="typeId">The component type id</param>
	internal readonly unsafe void ClearBuffer<T>(int index, Offset<T> offset)
	{
		ref var header = ref Unsafe.AsRef<BufferHeader>(((byte*)UnmanagedComponents + offset.Value + index * ComponentMeta<T>.Stride));
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
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal readonly unsafe ref Entity GetEntityMutable(int index)
	{
		var ptr = UnmanagedComponents;
		return ref Unsafe.AsRef<Entity>((byte*)UnmanagedComponents + index * sizeof(Entity));
	}

	/// <summary>
	/// Accepts an entity transferred from a source chunk.
	/// </summary>
	/// <param name="dstIndex">The index to transfer into</param>
	/// <param name="srcChunk">The source <see cref="Chunk"/></param>
	/// <param name="srcIndex">the index to transfer from</param>
	/// <returns>The entity id of the transferred entity</returns>
	internal readonly unsafe int AcceptEntity(
		int dstIndex, ref Chunk srcChunk, int srcIndex,
		short[] offsets, ReadOnlySpan<ComponentType> unmanagedComponentTypes)
	{
		// get src entity
		var srcEntity = srcChunk.GetEntity(srcIndex);

		// copy entity id
		GetEntityMutable(dstIndex) = srcEntity;

		// copy unmanaged components
		var srcPtr = srcChunk.UnmanagedComponents;
		var dstPtr = UnmanagedComponents;
		foreach (ref readonly var componentType in unmanagedComponentTypes)
		{
			var offset = offsets[componentType.Id];
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
	internal readonly unsafe void CloneComponents(
		int srcIndex, ref Chunk dstChunk, int dstIndex,
		short[] offsets, ReadOnlySpan<ComponentType> unmanagedComponentTypes)
	{
		// copy unmanaged components
		var srcPtr = UnmanagedComponents;
		var dstPtr = dstChunk.UnmanagedComponents;
		foreach (ref readonly var componentType in unmanagedComponentTypes)
		{
			// copy component
			var offset = offsets[componentType.Id];
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
	internal readonly unsafe void CopyComponents(
		int srcIndex, short[] srcOffsets,
		in Signature dstSignature, ref Chunk dstChunk, int dstIndex, short[] dstOffsets,
		ReadOnlySpan<ComponentType> unmanagedComponentTypes, ReadOnlySpan<ComponentType> managedComponentTypes)
	{
		// copy unmanaged components
		var srcPtr = UnmanagedComponents;
		var dstPtr = dstChunk.UnmanagedComponents;
		foreach (ref readonly var componentType in unmanagedComponentTypes)
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
		foreach (ref readonly var componentType in managedComponentTypes)
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

