using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

public unsafe readonly ref struct ReadBuffer<T> where T : unmanaged
{
	private readonly BufferHeader* _header;

	// --- Size/Tag packing (read-only helpers) --------------------------------
	private const int HeapTag = unchecked((int)0x8000_0000);
	private const int SizeMask = 0x7FFF_FFFF;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private int GetSize() => _header->Size & SizeMask;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool IsHeap() => (_header->Size & HeapTag) != 0;

	// --- Ctors ----------------------------------------------------------------

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ReadBuffer(ref BufferHeader headerRef)
	{
		_header = (BufferHeader*)Unsafe.AsPointer(ref headerRef);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ReadBuffer(BufferHeader* header) => _header = header;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ReadBuffer(void* header) => _header = (BufferHeader*)header;

	// --- Views ----------------------------------------------------------------

	/// <summary>The number of items currently in the buffer.</summary>
	public int Length
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => GetSize();
	}

	/// <summary>Read-only span view of the live elements.</summary>
	public ReadOnlySpan<T> Span
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new ReadOnlySpan<T>(DataPtr, GetSize());
	}

	/// <summary>Indexer returning a ref readonly element.</summary>
	public ref readonly T this[int index]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			int size = GetSize();
			if ((uint)index >= (uint)size) throw new ArgumentOutOfRangeException(nameof(index));
			return ref Unsafe.AsRef<T>(((T*)DataPtr) + index); // exposed as 'ref readonly'
		}
	}

	/// <summary>
	/// Provides a pinnable reference to the first element (or null ref if empty).
	/// Useful for <c>fixed</c> pinning scenarios.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ref readonly T GetPinnableReference()
	{
		if (GetSize() == 0) return ref Unsafe.NullRef<T>();
		return ref Unsafe.AsRef<T>(DataPtr);
	}

	// --- Queries / utilities --------------------------------------------------

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool IsEmpty() => GetSize() == 0;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Contains(T value) => IndexOf(value) >= 0;

	/// <summary>Linear index-of using EqualityComparer&lt;T&gt;.Default.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int IndexOf(T value)
	{
		var p = (T*)DataPtr;
		var len = GetSize();
		var cmp = EqualityComparer<T>.Default;
		for (int i = 0; i < len; i++)
		{
			if (cmp.Equals(p[i], value))
				return i;
		}
		return -1;
	}

	/// <summary>Copies the contents into the destination span (throws if too small).</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void CopyTo(Span<T> destination)
	{
		int size = GetSize();
		if (destination.Length < size) throw new ArgumentException("Destination too small.", nameof(destination));
		new ReadOnlySpan<T>(DataPtr, size).CopyTo(destination);
	}

	/// <summary>Attempts to copy to the destination span; returns false if too small.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool TryCopyTo(Span<T> destination)
	{
		int size = GetSize();
		if (destination.Length < size) return false;
		new ReadOnlySpan<T>(DataPtr, size).CopyTo(destination);
		return true;
	}

	/// <summary>Materializes the buffer to a managed array.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public T[] ToArray()
	{
		int size = GetSize();
		if (size == 0) return [];
		var arr = new T[size];
		new ReadOnlySpan<T>(DataPtr, size).CopyTo(arr);
		return arr;
	}

	// --- Enumeration ----------------------------------------------------------

	public Enumerator GetEnumerator() => new(this);

	public ref struct Enumerator
	{
		private readonly T* _ptr;
		private readonly int _length;
		private int _index;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Enumerator(ReadBuffer<T> buffer)
		{
			_ptr = (T*)buffer.DataPtr;
			_length = buffer.Length;
			_index = -1;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool MoveNext() => ++_index < _length;

		public ref readonly T Current
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ref _ptr[_index];
		}
	}

	// --- Core helpers (read-only) --------------------------------------------
	internal void* Header => _header;

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
}
