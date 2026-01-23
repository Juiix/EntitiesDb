using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace EntitiesDb;

/// <summary>
/// A chunk of entities, stored as rows across tight component array columns
/// </summary>
public partial struct Chunk
{
	internal Chunk(nint unmanagedComponents, Array[] managedComponents, int[] globalChangeVersions, int[] localChangeVersions)
	{
		UnmanagedComponents = unmanagedComponents;
		ManagedComponents = managedComponents;
		GlobalChangeVersions = globalChangeVersions;
		LocalChangeVersions = localChangeVersions;
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
	/// An array of change versions
	/// </summary>
	internal readonly int[] LocalChangeVersions { get; }

	/// <summary>
	/// An array of global change versions
	/// </summary>
	internal readonly int[] GlobalChangeVersions { get; }

	/// <summary>
	/// The count of entities stored in this chunk
	/// </summary>
	public int EntityCount { readonly get; internal set; }

	/// <summary>
	/// Gets a reference to an <see cref="EntitiesDb.Entity"/> at a given index
	/// </summary>
	/// <param name="index">The index of the <see cref="EntitiesDb.Entity"/> to get</param>
	/// <returns>A reference to the <see cref="EntitiesDb.Entity"/> at <paramref name="index"/></returns>
	public unsafe readonly ref readonly Entity Entity(int index)
	{
		return ref Unsafe.AsRef<Entity>((byte*)UnmanagedComponents + index * sizeof(Entity));
	}

	/// <summary>
	/// Returns a readonly reference to a component at a given index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <param name="index">The index to get</param>
	/// <returns>A readonly reference at <paramref name="index"/></returns>
	public readonly unsafe ref readonly T0? Read<T0>(int index, Offset<T0> offset)
	{
		var validCheck = offset.Value >= 0 & !ComponentMeta<T0>.IsBuffered & !ComponentMeta<T0>.IsZeroSize ? 1 : 0;
		return ref ComponentMeta<T0>.IsUnmanaged
			? ref Unsafe.AsRef<T0?>((void*)((UnmanagedComponents + offset.Value + index * ComponentMeta<T0>.Stride) * validCheck))
			: ref ((T0?[])ManagedComponents[offset.Value])[index];
	}

	/// <summary>
	/// Returns a readonly buffer of components at a given index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <param name="index">The index to get</param>
	/// <returns>A readonly buffer of components at <paramref name="index"/></returns>
	public readonly unsafe ReadBuffer<T0> ReadBuffer<T0>(int index, Offset<T0> offset) where T0 : unmanaged
	{
		var validCheck = offset.Value >= 0 & ComponentMeta<T0>.IsBuffered & !ComponentMeta<T0>.IsZeroSize ? 1 : 0;
		return new ReadBuffer<T0>((void*)((UnmanagedComponents + offset.Value + index * ComponentMeta<T0>.Stride) * validCheck));
	}

	/// <summary>
	/// Returns a reference to a component at a given index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <param name="index">The index to get</param>
	/// <returns>A reference at <paramref name="index"/></returns>
	[ChunkChange]
	public readonly unsafe ref T0? Write<T0>(int index, Offset<T0> offset)
	{
		var validCheck = offset.Value >= 0 & !ComponentMeta<T0>.IsBuffered & !ComponentMeta<T0>.IsZeroSize ? 1 : 0;
		MarkChanged(offset.Id.Value);
		return ref ComponentMeta<T0>.IsUnmanaged
			? ref Unsafe.AsRef<T0?>((void*)((UnmanagedComponents + offset.Value + index * ComponentMeta<T0>.Stride) * validCheck))
			: ref ((T0?[])ManagedComponents[offset.Value])[index];
	}

	/// <summary>
	/// Returns a buffer of components at a given index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <param name="index">The index to get</param>
	/// <returns>A buffer of components at <paramref name="index"/></returns>
	[ChunkChange]
	public readonly unsafe WriteBuffer<T0> WriteBuffer<T0>(int index, Offset<T0> offset) where T0 : unmanaged
	{
		var validCheck = offset.Value >= 0 & ComponentMeta<T0>.IsBuffered & !ComponentMeta<T0>.IsZeroSize ? 1 : 0;
		MarkChanged(offset.Id.Value);
		return new WriteBuffer<T0>((void*)((UnmanagedComponents + offset.Value + index * ComponentMeta<T0>.Stride) * validCheck));
	}

	/// <summary>
	/// Returns a handle to a component at the first index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <returns>A <see cref="EntitiesDb.WriteHandle{T}"/> to the first index</returns>
	public readonly ReadHandle<Entity> EntityHandle()
	{
		return new ReadHandle<Entity>(ref WriteEntity(0));
	}

	/// <summary>
	/// Returns a readonly handle to a component at the first index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <returns>A <see cref="EntitiesDb.ReadHandle{T}"/> to the first index</returns>
	public unsafe readonly ReadHandle<T0?> ReadHandle<T0>(Offset<T0> offset)
	{
		var validCheck = offset.Value >= 0 & !ComponentMeta<T0>.IsBuffered & !ComponentMeta<T0>.IsZeroSize ? 1 : 0;
		ref var first = ref ComponentMeta<T0>.IsUnmanaged
			? ref Unsafe.AsRef<T0?>((void*)((UnmanagedComponents + offset.Value) * validCheck))
			: ref ((T0?[])ManagedComponents[offset.Value])[0];
		return new ReadHandle<T0?>(ref first);
	}

	/// <summary>
	/// Returns a readonly handle to a buffer of components at the first index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <returns>A <see cref="EntitiesDb.ReadBufferHandle{T}"/> to the first index</returns>
	public readonly unsafe ReadBufferHandle<T0> ReadBufferHandle<T0>(Offset<T0> offset) where T0 : unmanaged
	{
		var validCheck = offset.Value >= 0 & ComponentMeta<T0>.IsBuffered & !ComponentMeta<T0>.IsZeroSize ? 1 : 0;
		var buffer = new ReadBuffer<T0>((void*)((UnmanagedComponents + offset.Value) * validCheck));
		return new ReadBufferHandle<T0>(buffer);
	}

	/// <summary>
	/// Returns a handle to a component at the first index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <returns>A <see cref="EntitiesDb.WriteHandle{T}"/> to the first index</returns>
	[ChunkChange]
	public unsafe readonly WriteHandle<T0?> WriteHandle<T0>(Offset<T0> offset)
	{
		var validCheck = offset.Value >= 0 & !ComponentMeta<T0>.IsBuffered & !ComponentMeta<T0>.IsZeroSize ? 1 : 0;
		MarkChanged(offset.Id.Value);
		ref var first = ref ComponentMeta<T0>.IsUnmanaged
			? ref Unsafe.AsRef<T0?>((void*)((UnmanagedComponents + offset.Value) * validCheck))
			: ref ((T0?[])ManagedComponents[offset.Value])[0];
		return new WriteHandle<T0?>(ref first);
	}

	/// <summary>
	/// Returns a handle to a buffer of components at the first index
	/// </summary>
	/// <typeparam name="T0">The component type</typeparam>
	/// <returns>A <see cref="EntitiesDb.WriteBufferHandle{T}"/> to the first index</returns>
	[ChunkChange]
	public unsafe readonly WriteBufferHandle<T0> WriteBufferHandle<T0>(Offset<T0> offset) where T0 : unmanaged
	{
		var validCheck = offset.Value >= 0 & ComponentMeta<T0>.IsBuffered & !ComponentMeta<T0>.IsZeroSize ? 1 : 0;
		MarkChanged(offset.Id.Value);
		var buffer = new WriteBuffer<T0>((void*)((UnmanagedComponents + offset.Value) * validCheck));
		return new WriteBufferHandle<T0>(buffer);
	}

	/// <summary>
	/// Sets and replaces component value values
	/// </summary>
	/// <param name="index">The chunk index</param>
	/// <param name="component"></param>
	[ChunkChange]
	public unsafe readonly void Set<T0>(int index, Offset<T0> offset, in T0? component)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offset) = component;
		else MarkChanged(offset.Id.Value);
	}

	/// <summary>
	/// Sets and replaces component value values
	/// </summary>
	/// <param name="index">The chunk index</param>
	/// <param name="components"></param>
	[ChunkChange]
	public unsafe readonly void Set<T0>(int index, Offset<T0> offset, ReadOnlySpan<T0> components) where T0 : unmanaged
	{
		WriteBuffer(index, offset).Set(components);
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
		WriteBuffer(index, offsets.T0).Init(components);
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
	/// Clears a buffer of components and releases allocated lists
	/// </summary>
	/// <param name="index">Index of the buffer to clear</param>
	/// <param name="typeId">The component type id</param>
	internal readonly unsafe void ClearBuffer(int index, int offset, int stride)
	{
		ref var header = ref Unsafe.AsRef<BufferHeader>(((byte*)UnmanagedComponents + offset + index * stride));
		DynamicBuffer.Clear(ref header);
	}

    /// <summary>
    /// Adds an entityId at the given index
    /// </summary>
    /// <param name="index">The index to set</param>
    /// <param name="entityId">The entity id to add</param>
    internal readonly unsafe void AddEntity(int index, Entity entityId)
	{
		WriteEntity(index) = entityId;
	}

	/// <summary>
	/// Marks a type as changed
	/// </summary>
	/// <typeparam name="T0"></typeparam>
	/// <param name="id"></param>
	internal readonly void MarkChanged(byte id)
	{
		LocalChangeVersions[id] = Interlocked.Increment(ref GlobalChangeVersions[id]);
	}

	/// <summary>
	/// Gets an <see cref="EntitiesDb.Entity"/> ref at a given index
	/// </summary>
	/// <param name="index">The index of the <see cref="EntitiesDb.Entity"/> to get</param>
	/// <returns>A <c>ref</c> of the <see cref="EntitiesDb.Entity"/> retrieved</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal readonly unsafe ref Entity WriteEntity(int index)
	{
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
		var srcEntity = srcChunk.Entity(srcIndex);

		// copy entity id
		WriteEntity(dstIndex) = srcEntity;

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
			if (componentType.IsTag)
			{
				continue;
			}

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
			if (!dstSignature.Test(componentType.Id) ||
				componentType.IsTag)
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

	internal readonly nint WriteUnmanaged(int id, int offset)
	{
		MarkChanged((byte)id);
		return UnmanagedComponents + offset;
	}

	internal readonly Array WriteManaged(int id, int offset)
	{
		MarkChanged((byte)id);
		return ManagedComponents[offset];
	}
}

