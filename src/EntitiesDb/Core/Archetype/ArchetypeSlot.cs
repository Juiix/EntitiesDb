using System.Runtime.CompilerServices;

namespace EntitiesDb;

/// <summary>
/// An archetype's entry in its <see cref="ArchetypeCollection"/>'s index table, which entity map entries
/// point into by <see cref="Archetype.Index"/>. It carries the two arrays by-entity access needs next to
/// the archetype itself, so a lookup goes entry -> slot -> arrays: no deeper than the object reference the
/// entity map used to hold (entry -> archetype -> arrays).
/// </summary>
internal unsafe struct ArchetypeSlot(Archetype archetype)
{
	public readonly Archetype Archetype = archetype;
	public readonly int[] IdToOffsets = archetype.IdToOffsets;

	/// <summary>
	/// The archetype's chunk array; the archetype refreshes this whenever it replaces the array
	/// </summary>
	public Chunk[] Chunks = archetype.ChunkArray;

	// The slot comes from the entity map, so its chunk index is in range; component ids are below
	// MaxComponents, the length of IdToOffsets.

	/// <summary>
	/// If the archetype has component <typeparamref name="T0"/> (of any kind)
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly bool Has<T0>() => ArrayAccess.At(IdToOffsets, Component<T0>.Id) >= 0;

	/// <summary>
	/// Readonly ref to component <typeparamref name="T0"/> of the entity at <paramref name="slot"/>
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ref readonly T0? Read<T0>(EntitySlot slot)
	{
		var offset = ArrayAccess.At(IdToOffsets, ComponentSingleWritable<T0>.Id);
		if (offset < 0) throw ThrowHelper.ComponentNotFound(typeof(T0));
		return ref ComponentRef<T0>(ref ArrayAccess.At(Chunks, slot.ChunkIndex), offset, slot.Index);
	}

	/// <summary>
	/// Copies component <typeparamref name="T0"/> of the entity at <paramref name="slot"/>; false when the
	/// archetype has no <typeparamref name="T0"/>
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly bool TryRead<T0>(EntitySlot slot, out T0? component)
	{
		var offset = ArrayAccess.At(IdToOffsets, Component<T0>.Id);
		if (offset < 0)
		{
			component = default;
			return false;
		}
		_ = ComponentSingleWritable<T0>.Id; // a buffer component present throws here, as Read does
		component = ComponentRef<T0>(ref ArrayAccess.At(Chunks, slot.ChunkIndex), offset, slot.Index);
		return true;
	}

	/// <summary>
	/// Ref to component <typeparamref name="T0"/> of the entity at <paramref name="slot"/>; marks its chunk changed
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ref T0? Write<T0>(EntitySlot slot)
	{
		var id = ComponentSingleWritable<T0>.Id;
		var offset = ArrayAccess.At(IdToOffsets, id);
		if (offset < 0) throw ThrowHelper.ComponentNotFound(typeof(T0));
		ref var chunk = ref ArrayAccess.At(Chunks, slot.ChunkIndex);
		if (ComponentMeta<T0>.TrackChanges) ChangeVersions.Mark(chunk.LocalChangeVersions, chunk.GlobalChangeVersions, id);
		return ref ComponentRef<T0>(ref chunk, offset, slot.Index);
	}

	/// <summary>
	/// Buffer <typeparamref name="T0"/> of the entity at <paramref name="slot"/>
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ReadBuffer<T0> ReadBuffer<T0>(EntitySlot slot) where T0 : unmanaged
	{
		var offset = ArrayAccess.At(IdToOffsets, ComponentBufferWritable<T0>.Id);
		if (offset < 0) throw ThrowHelper.ComponentNotFound(typeof(T0));
		return new ReadBuffer<T0>(BufferPointer<T0>(ref ArrayAccess.At(Chunks, slot.ChunkIndex), offset, slot.Index));
	}

	/// <summary>
	/// Buffer <typeparamref name="T0"/> of the entity at <paramref name="slot"/>; marks its chunk changed
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly WriteBuffer<T0> WriteBuffer<T0>(EntitySlot slot) where T0 : unmanaged
	{
		var id = ComponentBufferWritable<T0>.Id;
		var offset = ArrayAccess.At(IdToOffsets, id);
		if (offset < 0) throw ThrowHelper.ComponentNotFound(typeof(T0));
		ref var chunk = ref ArrayAccess.At(Chunks, slot.ChunkIndex);
		if (ComponentMeta<T0>.TrackChanges) ChangeVersions.Mark(chunk.LocalChangeVersions, chunk.GlobalChangeVersions, id);
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
}
