using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

/// <summary>
/// A small, thread-safe, allocation-free (after warm-up) object pool.
/// </summary>
/// <remarks>
/// Backed by an array + lock rather than <see cref="System.Collections.Concurrent.ConcurrentStack{T}"/>,
/// which allocates a node on every push and made every parallel query allocate.
/// Contention is negligible: Rent/Return happen once per job per parallel call, on the calling thread.
/// </remarks>
internal sealed class ObjectPool<T> where T : class
{
	private readonly T?[] _items;
	private readonly Func<T> _factory;
	private readonly Action<T>? _reset;     // called before an item is stored back
	private readonly Action<T>? _onDrop;    // called if an item can't be stored (pool full)
	private readonly object _lock = new();
	private int _count;                      // items currently stored

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
		_items = new T?[maxSize];

		prefill = Math.Min(prefill, maxSize);
		for (int i = 0; i < prefill; i++)
			_items[i] = _factory();
		_count = prefill;
	}

	/// <summary>Get an instance from the pool or create a new one if empty.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public T Rent()
	{
		lock (_lock)
		{
			if (_count > 0)
			{
				var item = _items[--_count]!;
				_items[_count] = null;
				return item;
			}
		}
		return _factory();
	}

	/// <summary>
	/// Return an instance to the pool. If the pool is full the item is dropped (after <c>onDrop</c>).
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Return(T? item)
	{
		if (item is null) return;

		_reset?.Invoke(item);
		lock (_lock)
		{
			if (_count < _items.Length)
			{
				_items[_count++] = item;
				return;
			}
		}
		_onDrop?.Invoke(item);
	}
}
