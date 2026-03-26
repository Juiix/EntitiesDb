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

	/// <summary>
	/// Appends elements from a source buffer to a target buffer using raw memory operations.
	/// </summary>
	public static unsafe void Append(void* target, void* source, int elementSize, int internalCapacity)
		=> Append(ref Unsafe.AsRef<BufferHeader>(target), ref Unsafe.AsRef<BufferHeader>(source), elementSize, internalCapacity);

	public static unsafe void Append(ref BufferHeader target, ref BufferHeader source, int elementSize, int internalCapacity)
	{
		int sourceSize = source.Size & SizeMask;
		if (sourceSize == 0) return;

		int targetSize = target.Size & SizeMask;
		int newSize = targetSize + sourceSize;

		// ensure target capacity
		int targetCap = target.Capacity;
		if (newSize > targetCap)
		{
			int newCap = internalCapacity;
			while (newCap < newSize) newCap <<= 1;

			bool targetIsHeap = (target.Size & HeapTag) != 0;
			byte* targetInline = (byte*)Unsafe.AsPointer(ref target) + BufferHeader.DataOffset;

			int newBytes = newCap * elementSize;
			int copyBytes = targetSize * elementSize;
			void* dst = (void*)Marshal.AllocHGlobal(newBytes);

			void* targetData = targetIsHeap ? (void*)target.Heap : targetInline;
			if (copyBytes > 0)
				Buffer.MemoryCopy(targetData, dst, newBytes, copyBytes);

			if (targetIsHeap)
				Marshal.FreeHGlobal(target.Heap);

			target.Heap = (nint)dst;
			target.Capacity = newCap;
			target.Size = (newSize & SizeMask) | HeapTag;
		}
		else
		{
			target.Size = (target.Size & HeapTag) | (newSize & SizeMask);
		}

		// get pointers to data regions
		bool srcIsHeap = (source.Size & HeapTag) != 0;
		byte* srcInline = (byte*)Unsafe.AsPointer(ref source) + BufferHeader.DataOffset;
		void* srcData = srcIsHeap ? (void*)source.Heap : srcInline;

		bool tgtIsHeap = (target.Size & HeapTag) != 0;
		byte* tgtInline = (byte*)Unsafe.AsPointer(ref target) + BufferHeader.DataOffset;
		void* tgtData = tgtIsHeap ? (void*)target.Heap : tgtInline;

		// copy source elements after existing target elements
		int srcBytes = sourceSize * elementSize;
		Buffer.MemoryCopy(srcData, (byte*)tgtData + targetSize * elementSize, srcBytes, srcBytes);
	}
}
