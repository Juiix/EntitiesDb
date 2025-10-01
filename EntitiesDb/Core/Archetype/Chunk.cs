using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

public struct Chunk
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
	internal readonly ComponentType[] ComponentTypes { [Pure] get; }

	/// <summary>
	/// Archetype id to offsets for ease-of-access.
	/// </summary>
	internal readonly int[] IdToOffsets { [Pure] get; }

	/// <summary>
	/// Base pointer to the unmanaged component block (component slices inside).
	/// </summary>
	internal readonly nint UnmanagedComponents { [Pure] get; }

	/// <summary>
	/// One entry per managed component type (e.g., <c>T[]</c> boxed as <see cref="Array"/>).
	/// </summary>
	internal readonly Array[] ManagedComponents { [Pure] get; }

	/// <summary>
	/// The count of entities stored in this chunk
	/// </summary>
	public int EntityCount { [Pure] readonly get; internal set; }

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
	/// Returns a reference to the first component of typeId
	/// </summary>
	/// <typeparam name="T">The component type</typeparam>
	/// <param name="offset">The byte offset</param>
	/// <returns>A reference at <paramref name="offset"/></returns>
	public readonly unsafe ref T GetFirst<T>(int typeId)
	{
		if (ComponentMeta<T>.IsBuffered)
			throw ThrowHelper.ComponentBuffered(typeof(T));

		var offset = IdToOffsets[typeId];
		return ref ComponentMeta<T>.IsUnmanaged
			? ref Unsafe.AsRef<T>((void*)(UnmanagedComponents + offset))
			: ref ((T[])ManagedComponents[offset])[0];
	}

	/// <summary>
	/// Returns a component buffer to the first buffer of typeId
	/// </summary>
	/// <typeparam name="T">The component type</typeparam>
	/// <param name="offset">The byte offset</param>
	/// <returns>The first component buffer for <paramref name="typeId"/></returns>
	public readonly unsafe ComponentBuffer<T> GetFirstBuffer<T>(int typeId) where T : unmanaged
	{
		if (!ComponentMeta<T>.IsBuffered)
			throw ThrowHelper.ComponentNotBuffered(typeof(T));

		var offset = IdToOffsets[typeId];
		return new ComponentBuffer<T>((void*)(UnmanagedComponents + offset));
	}

	/// <summary>
	/// Returns a reference to a component at a given offset
	/// </summary>
	/// <typeparam name="T">The component type</typeparam>
	/// <param name="offset">The byte offset</param>
	/// <returns>A reference at <paramref name="offset"/></returns>
	public readonly unsafe ref T? Get<T>(int index, int typeId)
	{
		var offset = IdToOffsets[typeId];
		return ref ComponentMeta<T>.IsUnmanaged
			? ref Unsafe.AsRef<T?>((void*)(UnmanagedComponents + offset + index * ComponentMeta<T>.Stride))
			: ref ((T?[])ManagedComponents[offset])[index];
	}

	/// <summary>
	/// Returns a reference to a component at a given offset
	/// </summary>
	/// <typeparam name="T">The component type</typeparam>
	/// <param name="offset">The byte offset</param>
	/// <returns>A reference at <paramref name="offset"/></returns>
	public readonly unsafe ComponentBuffer<T> GetBuffer<T>(int index, int typeId) where T : unmanaged
	{
		var offset = IdToOffsets[typeId];
		return new ComponentBuffer<T>((void*)(UnmanagedComponents + offset + index * ComponentMeta<T>.Stride));
	}

	/// <summary>
	/// Returns a readonly reference to a component at a given offset
	/// </summary>
	/// <typeparam name="T">The component type</typeparam>
	/// <param name="offset">The byte offset</param>
	/// <returns>A readonly reference at <paramref name="offset"/></returns>
	public readonly unsafe ref T? GetReadOnly<T>(int index, int typeId)
	{
		var offset = IdToOffsets[typeId];

		// unmanaged component offsets are stored negative
		return ref ComponentMeta<T>.IsUnmanaged
			? ref Unsafe.AsRef<T?>((void*)(UnmanagedComponents + offset + index * ComponentMeta<T>.Stride))
			: ref ((T?[])ManagedComponents[offset])[index];
	}

	/// <summary>
	/// Returns a reference to an unmanaged component at a given offset
	/// </summary>
	/// <typeparam name="T">The unmanaged type</typeparam>
	/// <param name="offset">The byte offset</param>
	/// <returns>An unmanaged reference at <paramref name="offset"/></returns>
	public readonly unsafe ref T? GetUnmanaged<T>(int offset)
	{
		var ptr = UnmanagedComponents + offset;
		return ref Unsafe.AsRef<T?>((void*)ptr);
	}

	/// <summary>
	/// Returns a readonly reference to an unmanaged component at a given offset
	/// </summary>
	/// <typeparam name="T">The unmanaged type</typeparam>
	/// <param name="offset">The byte offset</param>
	/// <returns>An unmanaged readonly reference at <paramref name="offset"/></returns>
	public readonly unsafe ref readonly T? GetReadOnlyUnmanaged<T>(int offset)
	{
		var ptr = UnmanagedComponents + offset;
		return ref Unsafe.AsRef<T?>((void*)ptr);
	}

	/// <summary>
	/// Returns a <see cref="ComponentBuffer{T}"/> of an unmanaged component at a given offset
	/// </summary>
	/// <typeparam name="T">The unmanaged type</typeparam>
	/// <param name="offset">The byte offset</param>
	/// <returns><see cref="ComponentBuffer{T}"/> at <paramref name="offset"/></returns>
	public readonly unsafe ComponentBuffer<T> GetUnmanagedBuffer<T>(int offset) where T : unmanaged
	{
		var ptr = UnmanagedComponents + offset;
		return new ComponentBuffer<T>((void*)ptr);
	}

	/// <summary>
	/// Returns a reference to an managed component at a given offset
	/// </summary>
	/// <typeparam name="T">The unmanaged type</typeparam>
	/// <param name="offset">The component offset</param>
	/// <param name="index">The array index</param>
	/// <returns>An managed reference at <paramref name="offset"/></returns>
	public readonly ref T? GetManaged<T>(int offset, int index = 0)
	{
		var array = (T?[])ManagedComponents[offset];
		return ref array[index];
	}

	/// <summary>
	/// Returns a readonly reference to an managed component at a given offset &amp; array index
	/// </summary>
	/// <typeparam name="T">The unmanaged type</typeparam>
	/// <param name="offset">The component offset</param>
	/// <param name="index">The array index</param>
	/// <returns>An managed readonly reference at <paramref name="offset"/></returns>
	public readonly ref readonly T? GetReadOnlyManaged<T>(int offset, int index = 0)
	{
		var array = (T?[])ManagedComponents[offset];
		return ref array[index];
	}

	/// <summary>
	/// Adds an entityId at the given index
	/// </summary>
	/// <param name="index">The index to set</param>
	/// <param name="entityId">The entity id to add</param>
	internal readonly unsafe void AddEntity(int index, Entity entityId)
	{
		GetUnmanaged<Entity>(index * sizeof(Entity)) = entityId;
	}

	/// <summary>
	/// Gets an <see cref="Entity"/> ref at a given index
	/// </summary>
	/// <param name="index">The index of the <see cref="Entity"/> to get</param>
	/// <returns>A <c>ref</c> of the <see cref="Entity"/> retrieved</returns>
	internal readonly unsafe ref Entity GetEntity(int index)
	{
		return ref GetUnmanaged<Entity>(index * sizeof(Entity));
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
		GetEntity(dstIndex) = srcEntity;

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

