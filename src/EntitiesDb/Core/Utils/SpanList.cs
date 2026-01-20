#nullable enable
using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

/// <summary>
/// A List&lt;T&gt;-like growable array that exposes Span/Memory over its live elements.
/// NetStandard2.1 compatible (no CollectionsMarshal).
/// </summary>
internal struct SpanList<T>
{
	private const int DefaultCapacity = 4;

	private T[] _items;
	private int _count;

	public SpanList()
	{
		_items = [];
	}

	public SpanList(int capacity)
	{
		if (capacity < 0) throw new ArgumentOutOfRangeException(nameof(capacity));
		_items = capacity == 0 ? [] : ArrayPool<T>.Shared.Rent(capacity);
	}

	public SpanList(ReadOnlySpan<T> source)
	{
		if (source.Length == 0)
		{
			_items = [];
			_count = 0;
		}
		else
		{
			_items = ArrayPool<T>.Shared.Rent(source.Length);
			source.CopyTo(_items);
			_count = source.Length;
		}
	}

	public int Count => _count;

	public int Capacity
	{
		get => _items.Length;
		set
		{
			if (value < _count) throw new ArgumentOutOfRangeException(nameof(value));
			if (value != _items.Length)
			{
				if (value == 0)
				{
					if (_items.Length != 0)
						ArrayPool<T>.Shared.Return(_items);
					_items = [];
					return;
				}
				var newArr = ArrayPool<T>.Shared.Rent(value);
				if (_count != 0)
					Array.Copy(_items, 0, newArr, 0, _count);
				if (_items.Length != 0)
					ArrayPool<T>.Shared.Return(_items);
				_items = newArr;
			}
		}
	}

	public T this[int index]
	{
		get
		{
			if ((uint)index >= (uint)_count) ThrowIndexOutOfRange();
			return _items[index];
		}
		set
		{
			if ((uint)index >= (uint)_count) ThrowIndexOutOfRange();
			_items[index] = value;
		}
	}

	/// <summary>Returns a by-ref to the item at index (mutating ref). No copy.</summary>
	public ref T ItemRef(int index)
	{
		if ((uint)index >= (uint)_count) ThrowIndexOutOfRange();
		return ref _items[index];
	}

	/// <summary>Adds an item (by value).</summary>
	public void Add(T item)
	{
		EnsureCapacity(_count + 1);
		_items[_count++] = item;
	}

	/// <summary>Adds an uninitialized slot and returns a ref you can fill.</summary>
	public ref T AddRef()
	{
		EnsureCapacity(_count + 1);
		_count++;
		return ref _items[_count - 1];
	}

	/// <summary>Adds a range from a span.</summary>
	public void AddRange(ReadOnlySpan<T> items)
	{
		if (items.Length == 0) return;
		EnsureCapacity(_count + items.Length);
		items.CopyTo(_items.AsSpan(_count));
		_count += items.Length;
	}

	public void Insert(int index, T item)
	{
		if ((uint)index > (uint)_count) ThrowIndexOutOfRange();
		EnsureCapacity(_count + 1);
		if (index < _count)
			Array.Copy(_items, index, _items, index + 1, _count - index);
		_items[index] = item;
		_count++;
	}

	public void RemoveAt(int index)
	{
		if ((uint)index >= (uint)_count) ThrowIndexOutOfRange();
		_count--;
		if (index < _count)
			Array.Copy(_items, index + 1, _items, index, _count - index);
		_items[_count] = default!; // clear last
	}

	/// <summary>Fast remove that does not preserve order (swaps with last).</summary>
	public void RemoveUnorderedAt(int index)
	{
		if ((uint)index >= (uint)_count) ThrowIndexOutOfRange();
		_count--;
		_items[index] = _items[_count];
		_items[_count] = default!;
	}

	public void Clear()
	{
		if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
		{
			Array.Clear(_items, 0, _count);
		}
		_count = 0;
	}

	public bool Contains(T item)
		=> IndexOf(item) >= 0;

	public int IndexOf(T item)
		=> Array.IndexOf(_items, item, 0, _count);

	public T[] ToArray()
	{
		if (_count == 0) return Array.Empty<T>();
		var arr = new T[_count];
		Array.Copy(_items, 0, arr, 0, _count);
		return arr;
	}

	public void TrimExcess()
	{
		int threshold = (int)(_items.Length * 0.9);
		if (_count < threshold)
			Capacity = _count;
	}

	/// <summary>Ensure capacity is at least <paramref name="min"/>.</summary>
	public void EnsureCapacity(int min)
	{
		if (_items.Length >= min) return;

		int newCap = _items.Length == 0 ? DefaultCapacity : _items.Length * 2;
		if ((uint)newCap > 0X7FEFFFFF) newCap = 0X7FEFFFFF; // same max as List<T>
		if (newCap < min) newCap = min;

		var newArr = ArrayPool<T>.Shared.Rent(newCap);
		if (_count > 0)
			Array.Copy(_items, 0, newArr, 0, _count);
		if (_items.Length != 0)
			ArrayPool<T>.Shared.Return(_items);
		_items = newArr;
	}

	// ----- Span/Memory exposure over the "live" segment -----

	/// <summary>Live-elements span [0..Count).</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Span<T> AsSpan() => _items.AsSpan(0, _count);

	/// <summary>Live-elements span slice.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Span<T> AsSpan(int start, int length) => _items.AsSpan(start, length);

	/// <summary>Live-elements read-only span.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ReadOnlySpan<T> AsReadOnlySpan() => _items.AsSpan(0, _count);

	/// <summary>Live-elements memory.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Memory<T> AsMemory() => new Memory<T>(_items, 0, _count);

	/// <summary>Pinnable ref to first element (returns a ref to dummy if empty).</summary>
	public ref T GetPinnableReference()
	{
		// Matches the pattern used by arrays/spans when empty.
		return ref (_count != 0 ? ref _items[0] : ref UnsafeNullRef());
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static ref T UnsafeNullRef()
	{
		return ref Unsafe.NullRef<T>();
	}

	// ----- Enumeration -----

	public Enumerator GetEnumerator() => new Enumerator(this);

	public struct Enumerator
	{
		private readonly T[] _arr;
		private readonly int _count;
		private int _index;

		internal Enumerator(SpanList<T> list)
		{
			_arr = list._items;
			_count = list._count;
			_index = -1;
		}

		public ref T Current => ref _arr[_index];

		public bool MoveNext()
		{
			int next = _index + 1;
			if (next < _count)
			{
				_index = next;
				return true;
			}
			return false;
		}

		public void Reset() => _index = -1;
		public void Dispose() { }
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowIndexOutOfRange()
		=> throw new ArgumentOutOfRangeException("index");
}
