using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

/// <summary>
/// Where an unmanaged component's column lives inside a chunk's unmanaged block.
/// Precomputed per <see cref="Archetype"/> so per-entity paths walk a flat array instead of testing
/// signatures and looking up offsets for every component.
/// </summary>
internal readonly struct ColumnInfo(int id, int offset, int stride, int internalCapacity)
{
	/// <summary>The component type id</summary>
	public readonly int Id = id;

	/// <summary>Byte offset of the column from the chunk's unmanaged base pointer</summary>
	public readonly int Offset = offset;

	/// <summary>Bytes per entity in the column</summary>
	public readonly int Stride = stride;

	/// <summary>Inline element capacity of a buffer column (0 for non-buffer columns)</summary>
	public readonly int InternalCapacity = internalCapacity;
}

internal static unsafe class ChunkMemory
{
	/// <summary>
	/// Copies one component element. Components are usually a handful of bytes, where a <c>cpblk</c>
	/// helper call costs more than the copy itself; common sizes become plain loads and stores.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Copy(byte* dst, byte* src, int size)
	{
		switch (size)
		{
			case 4:
				Unsafe.WriteUnaligned(dst, Unsafe.ReadUnaligned<int>(src));
				return;
			case 8:
				Unsafe.WriteUnaligned(dst, Unsafe.ReadUnaligned<long>(src));
				return;
			case 12:
				Unsafe.WriteUnaligned(dst, Unsafe.ReadUnaligned<long>(src));
				Unsafe.WriteUnaligned(dst + 8, Unsafe.ReadUnaligned<int>(src + 8));
				return;
			case 16:
				Unsafe.WriteUnaligned(dst, Unsafe.ReadUnaligned<long>(src));
				Unsafe.WriteUnaligned(dst + 8, Unsafe.ReadUnaligned<long>(src + 8));
				return;
			default:
				Buffer.MemoryCopy(src, dst, size, size);
				return;
		}
	}

	/// <summary>
	/// Zeroes one component element
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Zero(byte* dst, int size)
	{
		switch (size)
		{
			case 4:
				Unsafe.WriteUnaligned(dst, 0);
				return;
			case 8:
				Unsafe.WriteUnaligned(dst, 0L);
				return;
			default:
				Unsafe.InitBlockUnaligned(dst, 0, (uint)size);
				return;
		}
	}
}
