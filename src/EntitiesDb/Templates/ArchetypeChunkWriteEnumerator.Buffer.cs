
using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

public ref struct ArchetypeChunkWriteBufferEnumerator<T0>
	where T0 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1>
	where T0 : unmanaged
    where T1 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1, T2>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1, T2> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1, T2, T3>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1, T2, T3> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1, T2, T3, T4>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1, T2, T3, T4> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1, T2, T3, T4, T5>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1, T2, T3, T4, T5> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1, T2, T3, T4, T5, T6>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
    where T10 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
    where T10 : unmanaged
    where T11 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
    where T10 : unmanaged
    where T11 : unmanaged
    where T12 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
    where T10 : unmanaged
    where T11 : unmanaged
    where T12 : unmanaged
    where T13 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
    where T10 : unmanaged
    where T11 : unmanaged
    where T12 : unmanaged
    where T13 : unmanaged
    where T14 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
public ref struct ArchetypeChunkWriteBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
    where T10 : unmanaged
    where T11 : unmanaged
    where T12 : unmanaged
    where T13 : unmanaged
    where T14 : unmanaged
    where T15 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkWriteBufferEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			while (true)
			{
				if (--_index < 0)
				{
					if (!_archetypes.MoveNext())
						return false; // no more archetypes

					var a = _archetypes.Current;
					_index = a.ChunksInUse - 1;
				}

				if (_changeFilter == null)
					return true;

				var archetype = _archetypes.Current;
				for (; _index >= 0; _index--)
				{
					ref readonly var chunk = ref archetype.GetChunk(_index);
					var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
					if ((chunkVersion - _compareVersion) > 0)
					{
						Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
						return true;
					}
				}
			}
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index));
	}
}
