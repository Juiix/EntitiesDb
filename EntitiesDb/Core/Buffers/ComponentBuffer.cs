using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EntitiesDb;

public unsafe readonly ref struct ComponentBuffer<T> where T : unmanaged
{
	private readonly ComponentBufferHeader* _header;

	// --- Size/Tag packing ----------------------------------------------------
	private const int HeapTag = unchecked((int)0x8000_0000);
	private const int SizeMask = 0x7FFF_FFFF;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private int GetSize() => _header->Size & SizeMask;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void SetSize(int size) => _header->Size = (_header->Size & HeapTag) | (size & SizeMask);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool IsHeap() => (_header->Size & HeapTag) != 0;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void MarkHeap() => _header->Size |= HeapTag;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void MarkInline() => _header->Size &= SizeMask;

	// --- Ctors ---------------------------------------------------------------

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ComponentBuffer(ref ComponentBufferHeader headerRef)
	{
		_header = (ComponentBufferHeader*)Unsafe.AsPointer(ref headerRef);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ComponentBuffer(ComponentBufferHeader* header) => _header = header;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ComponentBuffer(void* header) => _header = (ComponentBufferHeader*)header;

	/// <summary>
	/// Initializes from data, promoting to heap if needed.
	/// </summary>
	internal void Init(int internalCapacity, ReadOnlySpan<T> data)
	{
		_header->InternalCapacity = internalCapacity;
		SetSize(data.Length);
		MarkInline(); // start inline

		if (data.Length == 0) return;

		var needCap = ComputeCapacity(_header->InternalCapacity, GetSize());
		if (needCap > _header->InternalCapacity)
		{
			// Promote to heap
			var bytes = checked((nuint)needCap * (nuint)sizeof(T));
			void* dst = (void*)Marshal.AllocHGlobal((IntPtr)bytes);
			data.CopyTo(new Span<T>(dst, data.Length));
			_header->Heap = (nint)dst;   // writing here is OK; we’re switching to heap
			MarkHeap();
		}
		else
		{
			data.CopyTo(new Span<T>(InlinePtr, data.Length));
			// DO NOT touch _header->Heap while inline (overlaps inline data bytes)
		}
	}

	// --- Indexing / Views ----------------------------------------------------

	public ref T this[int index]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			int size = GetSize();
			if ((uint)index >= (uint)size) throw new ArgumentOutOfRangeException(nameof(index));
			return ref Unsafe.AsRef<T>(((T*)DataPtr) + index);
		}
	}

	/// <summary>The number of items currently in the buffer.</summary>
	public int Length
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => GetSize();
	}

	/// <summary>Span view of the live elements. Do not hold across Add/Remove calls.</summary>
	public Span<T> Span
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(DataPtr, GetSize());
	}

	// --- Core helpers --------------------------------------------------------

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int ComputeCapacity(int baseCap, int size)
	{
		if (baseCap <= 0) throw new ArgumentOutOfRangeException(nameof(baseCap));
		if (size <= baseCap) return baseCap;

		long blocks = ((long)size + baseCap - 1) / baseCap;
		blocks--;
		blocks |= blocks >> 1;
		blocks |= blocks >> 2;
		blocks |= blocks >> 4;
		blocks |= blocks >> 8;
		blocks |= blocks >> 16;
		blocks++;
		long cap = blocks * (long)baseCap;
		if (cap > int.MaxValue) throw new OutOfMemoryException("Capacity overflow.");
		return (int)cap;
	}

	private void* InlinePtr
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => (byte*)_header + ComponentBufferHeader.DataOffset;
	}

	private void* DataPtr
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => IsHeap() ? (void*)_header->Heap : InlinePtr; // never consult Heap when inline
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private int EffectiveCapacity()
		=> IsHeap() ? ComputeCapacity(_header->InternalCapacity, GetSize())
					: _header->InternalCapacity;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void EnsureCapacityFor(int targetSize)
	{
		if (targetSize <= 0) return;

		int currentCap = EffectiveCapacity();
		if (targetSize <= currentCap) return;

		int size = GetSize();
		int newCap = ComputeCapacity(_header->InternalCapacity, targetSize);

		var bytesToCopy = checked((nuint)size * (nuint)sizeof(T));
		var newBytes = checked((nuint)newCap * (nuint)sizeof(T));

		void* src = DataPtr; // safe: if inline, this is InlinePtr
		void* dst = (void*)Marshal.AllocHGlobal((IntPtr)newBytes);

		Buffer.MemoryCopy(src, dst, newBytes, bytesToCopy);

		if (IsHeap())
		{
			Marshal.FreeHGlobal(_header->Heap);
		}

		_header->Heap = (nint)dst; // OK to write; we are (or are becoming) heap
		MarkHeap();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void ShrinkIfNeededAfterRemove()
	{
		int size = GetSize();
		if (size == 0)
		{
			if (IsHeap())
			{
				Marshal.FreeHGlobal(_header->Heap);
				// DO NOT zero _header->Heap; that memory overlaps inline data
				MarkInline();
			}
			return;
		}

		// Only consider shrink at InternalCapacity boundaries to avoid thrash.
		if ((size % _header->InternalCapacity) != 0) return;

		int cap = ComputeCapacity(_header->InternalCapacity, size);
		if (size != cap) return;

		if (!IsHeap())
			return; // already inline; nothing to do

		var bytes = checked((nuint)cap * (nuint)sizeof(T));
		void* src = (void*)_header->Heap;

		if (cap == _header->InternalCapacity)
		{
			// Move back to inline
			Buffer.MemoryCopy(src, InlinePtr, bytes, bytes);
			Marshal.FreeHGlobal(_header->Heap);
			MarkInline(); // do not write _header->Heap = 0 (overlaps inline!)
		}
		else
		{
			// Allocate a smaller heap
			void* dst = (void*)Marshal.AllocHGlobal((IntPtr)bytes);
			Buffer.MemoryCopy(src, dst, bytes, bytes);
			Marshal.FreeHGlobal(_header->Heap);
			_header->Heap = (nint)dst; // still heap
			MarkHeap();
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int IndexOfItem(void* data, int length, in T value)
	{
		var p = (T*)data;
		var cmp = EqualityComparer<T>.Default;
		for (int i = 0; i < length; i++)
		{
			if (cmp.Equals(p[i], value))
				return i;
		}
		return -1;
	}

	// --- API -----------------------------------------------------------------

	public void Add(T item) => Add(ref item);

	public void Add(ref T item)
	{
		int size = GetSize();
		if (size == int.MaxValue) throw new OutOfMemoryException("Max size reached.");
		EnsureCapacityFor(size + 1);
		((T*)DataPtr)[size] = item;
		SetSize(size + 1);
	}

	public void AddRange(ReadOnlySpan<T> items)
	{
		int count = items.Length;
		if (count == 0) return;

		int oldSize = GetSize();
		int newSize = checked(oldSize + count);

		EnsureCapacityFor(newSize);

		// Safe even if source comes from this buffer (span copy handles overlap).
		items.CopyTo(new Span<T>(((T*)DataPtr) + oldSize, count));

		SetSize(newSize);
	}

	public void AddRange(T[] items) => AddRange(items.AsSpan());

	public void Clear()
	{
		if (IsHeap())
		{
			Marshal.FreeHGlobal(_header->Heap);
			// DO NOT zero Heap in inline state; it overlaps inline bytes
			MarkInline();
		}
		SetSize(0);
	}

	public ref T Get(int index)
	{
		int size = GetSize();
		if ((uint)index >= (uint)size) throw new ArgumentOutOfRangeException(nameof(index));
		return ref Unsafe.AsRef<T>(((T*)DataPtr) + index);
	}

	public void RemoveAt(int index)
	{
		int size = GetSize();
		if ((uint)index >= (uint)size) throw new ArgumentOutOfRangeException(nameof(index));

		int last = size - 1;
		if (index < last)
		{
			var span = new Span<T>(DataPtr, size);
			span.Slice(index + 1, last - index).CopyTo(span.Slice(index));
		}

		SetSize(last);
		ShrinkIfNeededAfterRemove();
	}

	public bool Remove(T item)
	{
		int size = GetSize();
		int idx = IndexOfItem(DataPtr, size, item);
		if (idx < 0) return false;
		RemoveAt(idx);
		return true;
	}

	public void RemoveAtSwapBack(int index)
	{
		int size = GetSize();
		if ((uint)index >= (uint)size) throw new ArgumentOutOfRangeException(nameof(index));

		int last = size - 1;
		if (index != last)
			((T*)DataPtr)[index] = ((T*)DataPtr)[last];

		SetSize(last);
		ShrinkIfNeededAfterRemove();
	}
}
