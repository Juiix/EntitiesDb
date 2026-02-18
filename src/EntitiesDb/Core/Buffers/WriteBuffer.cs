using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EntitiesDb;

public unsafe readonly ref struct WriteBuffer<T> where T : unmanaged
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
	internal WriteBuffer(ref BufferHeader headerRef)
	{
		_header = (BufferHeader*)Unsafe.AsPointer(ref headerRef);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal WriteBuffer(BufferHeader* header) => _header = header;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal WriteBuffer(void* header) => _header = (BufferHeader*)header;

	/// <summary>
	/// Initializes from data, promoting to heap if needed.
	/// Uses ComponentMeta&lt;T&gt;.InternalCapacity as the inline base,
	/// and sets header.Capacity to the effective capacity (base or base*2^k).
	/// </summary>
	public void Init(ReadOnlySpan<T> data)
	{
		int baseCap = ComponentMeta<T>.InternalCapacity;
		if (baseCap <= 0) throw new ArgumentOutOfRangeException(nameof(baseCap));

		_header->Capacity = baseCap;
		SetSize(data.Length);
		MarkInline();

		if (data.Length == 0)
			return;

		if (data.Length <= baseCap)
		{
			data.CopyTo(new Span<T>(InlinePtr, data.Length));
			return;
		}

		int needCap = GrowPow2(baseCap, data.Length);
		var bytes = checked(needCap * sizeof(T));
		void* dst = (void*)Marshal.AllocHGlobal(bytes);
		data.CopyTo(new Span<T>(dst, data.Length));
		_header->Heap = (nint)dst;
		_header->Capacity = needCap;
		MarkHeap();
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

	public int Length
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => GetSize();
	}

	public Span<T> Span
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(DataPtr, GetSize());
	}

	public ReadBuffer<T> ReadOnly
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(_header);
	}

	public ReadOnlySpan<T> ReadOnlySpan
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(DataPtr, GetSize());
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ref T GetPinnableReference()
		=> ref (Length == 0 ? ref Unsafe.NullRef<T>() : ref Unsafe.AsRef<T>(DataPtr));

	// --- Helpers: power-of-two scaling on top of baseCap --------------------

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int GrowPow2(int baseCap, int target)
	{
		if (target <= baseCap) return baseCap;
		long cap = baseCap;
		// multiply by 2 until >= target
		while (cap < target)
		{
			cap <<= 1;
			if (cap > int.MaxValue) throw new OutOfMemoryException("Capacity overflow.");
		}
		return (int)cap;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int MinimalPow2AtLeast(int baseCap, int size)
	{
		// Smallest baseCap * 2^k such that >= size
		if (size <= baseCap) return baseCap;
		long cap = baseCap;
		while (cap < size)
		{
			cap <<= 1;
			if (cap > int.MaxValue) throw new OutOfMemoryException("Capacity overflow.");
		}
		return (int)cap;
	}

	internal void* Header => _header;

	private void* InlinePtr
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => (byte*)_header + BufferHeader.DataOffset;
	}

	private void* DataPtr
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => IsHeap() ? (void*)_header->Heap : InlinePtr;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void EnsureCapacityFor(int targetSize)
	{
		if (targetSize <= 0) return;

		int currentCap = _header->Capacity;
		if (targetSize <= currentCap) return;

		int baseCap = ComponentMeta<T>.InternalCapacity;
		if (baseCap <= 0) throw new ArgumentOutOfRangeException(nameof(baseCap));

		int oldSize = GetSize();
		int newCap = GrowPow2(baseCap, targetSize);

		var bytesToCopy = checked(oldSize * sizeof(T));
		var newBytes = checked(newCap * sizeof(T));

		void* src = DataPtr;
		void* dst = (void*)Marshal.AllocHGlobal(newBytes);

		Buffer.MemoryCopy(src, dst, newBytes, bytesToCopy);

		if (IsHeap())
		{
			Marshal.FreeHGlobal(_header->Heap);
		}

		_header->Heap = (nint)dst;
		_header->Capacity = newCap;
		MarkHeap();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void ShrinkIfNeededAfterRemove()
	{
		int size = GetSize();
		int baseCap = ComponentMeta<T>.InternalCapacity;
		int cap = _header->Capacity;

		if (size == 0)
		{
			if (IsHeap())
			{
				Marshal.FreeHGlobal(_header->Heap);
				_header->Capacity = baseCap; // reset to inline
				MarkInline();
			}
			return;
		}

		// Only shrink when strictly less than 1/3 of current capacity
		if (size * 3 >= cap) return;

		// Compute target capacity using power-of-two scaling
		int targetCap = MinimalPow2AtLeast(baseCap, size);

		if (!IsHeap())
		{
			// already inline; nothing to do
			return;
		}

		if (targetCap <= baseCap)
		{
			// Demote to inline
			var bytes = checked((nuint)size * (nuint)sizeof(T));
			void* src = (void*)_header->Heap;
			Buffer.MemoryCopy(src, InlinePtr, bytes, bytes);
			Marshal.FreeHGlobal(_header->Heap);
			_header->Capacity = baseCap;
			MarkInline();
		}
		else if (targetCap < cap)
		{
			// Reallocate a smaller heap
			var bytes = checked(targetCap * sizeof(T));
			void* src = (void*)_header->Heap;
			void* dst = (void*)Marshal.AllocHGlobal(bytes);
			Buffer.MemoryCopy(src, dst, bytes, checked(size * sizeof(T)));
			Marshal.FreeHGlobal(_header->Heap);
			_header->Heap = (nint)dst;
			_header->Capacity = targetCap;
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

	public static int MetaInternalCapacity
		=> ComponentMeta<T>.InternalCapacity;

	/// <summary>Current effective capacity (inline or heap).</summary>
	public int Capacity
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => _header->Capacity;
	}

	public bool IsInline
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => !IsHeap();
	}

	public bool IsEmpty
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => Length == 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Reserve(int targetSize) => EnsureCapacityFor(targetSize);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void ReserveAdditional(int additional)
		=> Reserve(checked(Length + Math.Max(0, additional)));

	/// <summary>
	/// Trim backing storage using power-of-two scaling and the 1/3 rule.
	/// </summary>
	public void TrimExcess()
	{
		int size = Length;
		int baseCap = ComponentMeta<T>.InternalCapacity;

		if (size == 0)
		{
			if (IsHeap())
			{
				Marshal.FreeHGlobal(_header->Heap);
				_header->Capacity = baseCap;
				MarkInline();
			}
			return;
		}

		int cap = _header->Capacity;

		// Only shrink when strictly less than 1/3 of current capacity
		if (size * 3 >= cap) return;

		int targetCap = MinimalPow2AtLeast(baseCap, size);

		if (!IsHeap())
			return; // already inline

		if (targetCap <= baseCap)
		{
			var bytes = checked((nuint)size * (nuint)sizeof(T));
			void* src = (void*)_header->Heap;
			Buffer.MemoryCopy(src, InlinePtr, bytes, bytes);
			Marshal.FreeHGlobal(_header->Heap);
			_header->Capacity = baseCap;
			MarkInline();
		}
		else if (targetCap < cap)
		{
			var bytes = checked(targetCap * sizeof(T));
			void* src = (void*)_header->Heap;
			void* dst = (void*)Marshal.AllocHGlobal(bytes);
			Buffer.MemoryCopy(src, dst, bytes, checked(size * sizeof(T)));
			Marshal.FreeHGlobal(_header->Heap);
			_header->Heap = (nint)dst;
			_header->Capacity = targetCap;
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

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ReadBuffer<T> AsReadOnly()
		=> new ReadBuffer<T>(_header);

	// --- Mutators ------------------------------------------------------------

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
		items.CopyTo(new Span<T>(((T*)DataPtr) + oldSize, count));
		SetSize(newSize);
	}

	public void AddRange(T[] items) => AddRange(items.AsSpan());

	public void AddRange(ReadBuffer<T> other) => AddRange(other.Span);

	public void Clear() => Clear(false);
    public void Clear(bool resizeCapacity)
    {
        if (resizeCapacity &&
			IsHeap())
        {
            Marshal.FreeHGlobal(_header->Heap);
            _header->Capacity = ComponentMeta<T>.InternalCapacity;
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

	public void RemoveAt(int index) => RemoveAt(index, false);
	public void RemoveAt(int index, bool resizeCapacity)
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
		if (resizeCapacity) ShrinkIfNeededAfterRemove();
	}

	public bool Remove(T item) => Remove(item, false);
	public bool Remove(T item, bool resizeCapacity)
	{
		int size = GetSize();
		int idx = IndexOfItem(DataPtr, size, item);
		if (idx < 0) return false;
		RemoveAt(idx, resizeCapacity);
		return true;
	}

	public bool TryRemove(T item) => TryRemove(item, false);
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool TryRemove(T item, bool resizeCapacity)
	{
		int idx = IndexOf(item);
		if (idx < 0) return false;
		RemoveAt(idx, resizeCapacity);
		return true;
	}

	public void RemoveAtSwapBack(int index) => RemoveAtSwapBack(index, false);
	public void RemoveAtSwapBack(int index, bool resizeCapacity)
	{
		int size = GetSize();
		if ((uint)index >= (uint)size) throw new ArgumentOutOfRangeException(nameof(index));

		int last = size - 1;
		if (index != last)
			((T*)DataPtr)[index] = ((T*)DataPtr)[last];

		SetSize(last);
		if (resizeCapacity) ShrinkIfNeededAfterRemove();
	}

	public void Set(ReadOnlySpan<T> items)
	{
		Clear();
		AddRange(items);
	}

	public bool TryRemoveAtSwapBack(int index, out T movedOrRemoved) => TryRemoveAtSwapBack(index, out movedOrRemoved, false);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool TryRemoveAtSwapBack(int index, out T movedOrRemoved, bool resizeCapacity)
	{
		int size = GetSize();
		if ((uint)index >= (uint)size) { movedOrRemoved = default; return false; }

		int last = size - 1;
		movedOrRemoved = ((T*)DataPtr)[last];
		if (index != last)
			((T*)DataPtr)[index] = movedOrRemoved;

		SetSize(last);
		if (resizeCapacity) ShrinkIfNeededAfterRemove();
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
		internal Enumerator(WriteBuffer<T> buffer)
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
