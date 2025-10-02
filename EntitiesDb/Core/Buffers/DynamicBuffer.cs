using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EntitiesDb;

public unsafe readonly ref struct DynamicBuffer<T> where T : unmanaged
{
	private readonly BufferHeader* _header;

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
	internal DynamicBuffer(ref BufferHeader headerRef)
	{
		_header = (BufferHeader*)Unsafe.AsPointer(ref headerRef);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal DynamicBuffer(BufferHeader* header) => _header = header;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal DynamicBuffer(void* header) => _header = (BufferHeader*)header;

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

	/// <summary>Writable span view of the live elements. Do not hold across Add/Remove calls.</summary>
	public Span<T> Span
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(DataPtr, GetSize());
	}

	/// <summary>Read-only span view of the live elements.</summary>
	public ReadOnlySpan<T> ReadOnlySpan
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(DataPtr, GetSize());
	}

	/// <summary>Provides a pinnable reference to the first element (or null ref if empty).</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ref T GetPinnableReference()
		=> ref (Length == 0 ? ref Unsafe.NullRef<T>() : ref Unsafe.AsRef<T>(DataPtr));

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
		get => (byte*)_header + BufferHeader.DataOffset;
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

	// --- Surface area: state & capacity --------------------------------------

	/// <summary>Configured inline-chunk capacity used for geometric growth steps.</summary>
	public int InternalCapacity
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => _header->InternalCapacity;
	}

	/// <summary>Effective capacity based on current representation (inline or heap).</summary>
	public int Capacity
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => IsHeap() ? ComputeCapacity(_header->InternalCapacity, Length)
						: _header->InternalCapacity;
	}

	/// <summary>True if the buffer is stored inline (i.e., not on the heap).</summary>
	public bool IsInline
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => !IsHeap();
	}

	/// <summary>True if the buffer contains no elements.</summary>
	public bool IsEmpty
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => Length == 0;
	}

	/// <summary>
	/// Ensure capacity for at least <paramref name="targetSize"/> elements (no change to Length).
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Reserve(int targetSize) => EnsureCapacityFor(targetSize);

	/// <summary>Ensure capacity for current Length + <paramref name="additional"/>.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void ReserveAdditional(int additional)
		=> Reserve(checked(Length + Math.Max(0, additional)));

	/// <summary>
	/// Trim backing storage to the minimal geometric capacity for current Length.
	/// May move from heap back to inline when size ≤ InternalCapacity.
	/// </summary>
	public void TrimExcess()
	{
		int size = Length;
		if (size == 0)
		{
			if (IsHeap())
			{
				Marshal.FreeHGlobal(_header->Heap);
				MarkInline();
			}
			return;
		}

		int cap = ComputeCapacity(_header->InternalCapacity, size);
		if (!IsHeap())
		{
			// Already inline; nothing to do.
			return;
		}

		var bytes = checked((nuint)cap * (nuint)sizeof(T));
		void* src = (void*)_header->Heap;

		if (cap == _header->InternalCapacity)
		{
			Buffer.MemoryCopy(src, InlinePtr, bytes, bytes);
			Marshal.FreeHGlobal(_header->Heap);
			MarkInline();
		}
		else
		{
			void* dst = (void*)Marshal.AllocHGlobal((IntPtr)bytes);
			Buffer.MemoryCopy(src, dst, bytes, bytes);
			Marshal.FreeHGlobal(_header->Heap);
			_header->Heap = (nint)dst;
			MarkHeap();
		}
	}

	// --- Convenience / utility methods ---------------------------------------

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Contains(T value) => IndexOf(value) >= 0;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int IndexOf(T value)
	{
		var p = (T*)DataPtr;
		return IndexOfItem(p, Length, value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void CopyTo(Span<T> destination)
	{
		int size = Length;
		if (destination.Length < size) throw new ArgumentException("Destination too small.", nameof(destination));
		ReadOnlySpan.CopyTo(destination);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool TryCopyTo(Span<T> destination)
	{
		int size = Length;
		if (destination.Length < size) return false;
		ReadOnlySpan.CopyTo(destination);
		return true;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void CopyTo(T[] array, int destinationIndex)
		=> ReadOnlySpan.CopyTo(array.AsSpan(destinationIndex));

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public T[] ToArray()
	{
		int size = Length;
		if (size == 0) return Array.Empty<T>();
		var arr = new T[size];
		ReadOnlySpan.CopyTo(arr);
		return arr;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool TryGet(int index, out T value)
	{
		if ((uint)index < (uint)Length)
		{
			value = Unsafe.AsRef<T>(((T*)DataPtr) + index);
			return true;
		}
		value = default;
		return false;
	}

	/// <summary>Returns a read-only view over the same header.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ReadOnlyBuffer<T> AsReadOnly()
		=> new ReadOnlyBuffer<T>(_header);

	// --- API (existing mutators) ---------------------------------------------

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

	/// <summary>Adds the contents of a read-only buffer without materializing a temporary array.</summary>
	public void AddRange(ReadOnlyBuffer<T> other)
		=> AddRange(other.Span);

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

	/// <summary>Try-remove by value (no throw paths).</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool TryRemove(T item)
	{
		int idx = IndexOf(item);
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

	/// <summary>
	/// Swap-back removal that returns the element moved into <paramref name="index"/> (or the removed element if it was last).
	/// Returns false if index out of range.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool TryRemoveAtSwapBack(int index, out T movedOrRemoved)
	{
		int size = GetSize();
		if ((uint)index >= (uint)size) { movedOrRemoved = default; return false; }

		int last = size - 1;
		movedOrRemoved = ((T*)DataPtr)[last];
		if (index != last)
			((T*)DataPtr)[index] = movedOrRemoved;

		SetSize(last);
		ShrinkIfNeededAfterRemove();
		return true;
	}

	// --- Enumeration by ref (mutable) ----------------------------------------

	public Enumerator GetEnumerator() => new Enumerator(this);

	public ref struct Enumerator
	{
		private readonly T* _ptr;
		private readonly int _length;
		private int _index;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Enumerator(DynamicBuffer<T> buffer)
		{
			_ptr = (T*)buffer.DataPtr;
			_length = buffer.Length;
			_index = -1;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool MoveNext() => ++_index < _length;

		public ref T Current
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ref _ptr[_index];
		}
	}
}
