using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EntitiesDb;

internal static class DynamicBuffer
{
	private const int HeapTag = unchecked((int)0x8000_0000);
	private const int SizeMask = 0x7FFF_FFFF;

	public static unsafe void Clear(void* header) => Clear(ref Unsafe.AsRef<BufferHeader>(header));
	public static void Clear(ref BufferHeader header)
	{
		if ((header.Size & HeapTag) != 0)
		{
			Marshal.FreeHGlobal(header.Heap);
			header.Size &= SizeMask; // clear heap tag
		}
		header.Size = 0;
		// keep header.Capacity as-is; it will be reset on next init if needed
	}

	public static unsafe void Clone(void* src, void* dst, uint stride) => Clone(ref Unsafe.AsRef<BufferHeader>(src), ref Unsafe.AsRef<BufferHeader>(dst), stride);
	public static unsafe void Clone(ref BufferHeader src, ref BufferHeader dst, uint stride)
	{
		const int HeapTag = unchecked((int)0x8000_0000);
		const int SizeMask = 0x7FFF_FFFF;

		int size = src.Size & SizeMask;
		bool isHeap = (src.Size & HeapTag) != 0;

		// destination is guaranteed zero'd/default => treat as inline/no heap
		// (and caller guarantees its default inline capacity is already set up)

		byte* srcInline = (byte*)Unsafe.AsPointer(ref src) + BufferHeader.DataOffset;
		byte* dstInline = (byte*)Unsafe.AsPointer(ref dst) + BufferHeader.DataOffset;

		if (!isHeap)
		{
			// Inline -> Inline
			dst.Size = size;         // heap tag off
			dst.Capacity = src.Capacity; // preserve effective capacity

			if (size != 0)
			{
				nuint bytes = checked((nuint)size * stride);
				Buffer.MemoryCopy(srcInline, dstInline, bytes, bytes);
			}
			return;
		}

		// Heap -> Heap (deep copy)
		{
			int cap = src.Capacity;
			if (cap < size) cap = size; // defensive

			nuint allocBytes = checked((nuint)cap * stride);
			void* heap = (void*)Marshal.AllocHGlobal((nint)allocBytes);

			nuint copyBytes = checked((nuint)size * stride);
			if (copyBytes != 0)
				Buffer.MemoryCopy((void*)src.Heap, heap, allocBytes, copyBytes);

			dst.Heap = (nint)heap;
			dst.Capacity = cap;
			dst.Size = size | HeapTag;
		}
	}

	public static unsafe void Init(void* header, int internalCapacity) => Init(ref Unsafe.AsRef<BufferHeader>(header), internalCapacity);
	public static void Init(ref BufferHeader header, int internalCapacity)
	{
		header.Size = 0;
		header.Capacity = internalCapacity;
		header.Heap = 0;
	}
}
