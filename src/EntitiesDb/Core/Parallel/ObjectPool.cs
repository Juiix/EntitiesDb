using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading;

namespace EntitiesDb;

internal sealed class ObjectPool<T>
{
	private readonly ConcurrentStack<T> _stack = new();
	private readonly Func<T> _factory;
	private readonly Action<T>? _reset;     // called before an item is stored back
	private readonly Action<T>? _onDrop;    // called if an item can't be stored (pool full)
	private readonly int _maxSize;

	// Tracks items currently stored in the pool (not total created).
	private int _count;

	public ObjectPool(Func<T> factory, int maxSize,
					  Action<T>? reset = null,
					  Action<T>? onDrop = null,
					  int prefill = 0)
	{
		if (factory is null) throw new ArgumentNullException(nameof(factory));
		if (maxSize <= 0) throw new ArgumentOutOfRangeException(nameof(maxSize));

		_factory = factory;
		_reset = reset;
		_onDrop = onDrop;
		_maxSize = maxSize;

		// Prefill eagerly (best effort; stays lock-free and fast).
		for (int i = 0; i < prefill; i++)
		{
			var item = _factory();
			_stack.Push(item);
		}
		_count = prefill;
	}

	/// <summary>Get an instance from the pool or create a new one if empty.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public T Rent()
	{
		if (_stack.TryPop(out var item))
		{
			// Balance the count for a successful pop.
			Interlocked.Decrement(ref _count);
			return item!;
		}
		return _factory();
	}

	/// <summary>
	/// Return an instance to the pool. If the pool is full, optionally drop/cleanup it.
	/// Safe to call multiple times but double-returns may waste capacity.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Return(T? item)
	{
		if (item is null) return;

		// If we can't store more, drop it (best effort; small races allowed).
		int c = Volatile.Read(ref _count);
		if (c >= _maxSize)
		{
			_onDrop?.Invoke(item);
			return;
		}

		_reset?.Invoke(item); // e.g., clear fields, reset buffers, etc.

		// Reserve a slot: increment first; if we raced and exceeded capacity, undo.
		int newCount = Interlocked.Increment(ref _count);
		if (newCount <= _maxSize)
		{
			_stack.Push(item);
			return;
		}

		// We over-shot due to a race; undo and drop the item.
		Interlocked.Decrement(ref _count);
		_onDrop?.Invoke(item);
	}
}
