
using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

public ref struct ArchetypeChunkWriteMixed1Enumerator<T0, T1>
	where T1 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed1Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed1<T0, T1> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed1Enumerator<T0, T1, T2>
	where T1 : unmanaged
    where T2 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed1Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed1<T0, T1, T2> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed1Enumerator<T0, T1, T2, T3>
	where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed1Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed1<T0, T1, T2, T3> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed1Enumerator<T0, T1, T2, T3, T4>
	where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed1Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed1<T0, T1, T2, T3, T4> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed1Enumerator<T0, T1, T2, T3, T4, T5>
	where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed1Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed1<T0, T1, T2, T3, T4, T5> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6>
	where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed1Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed1<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>
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
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed1Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed1<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed1Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed1Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed2Enumerator<T0, T1, T2>
	where T2 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed2Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed2<T0, T1, T2> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed2Enumerator<T0, T1, T2, T3>
	where T2 : unmanaged
    where T3 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed2Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed2<T0, T1, T2, T3> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed2Enumerator<T0, T1, T2, T3, T4>
	where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed2Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed2<T0, T1, T2, T3, T4> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed2Enumerator<T0, T1, T2, T3, T4, T5>
	where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed2Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed2<T0, T1, T2, T3, T4, T5> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6>
	where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed2Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed2<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>
	where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed2Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed2<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed2Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed2Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed3Enumerator<T0, T1, T2, T3>
	where T3 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed3Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed3<T0, T1, T2, T3> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed3Enumerator<T0, T1, T2, T3, T4>
	where T3 : unmanaged
    where T4 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed3Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed3<T0, T1, T2, T3, T4> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed3Enumerator<T0, T1, T2, T3, T4, T5>
	where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed3Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed3<T0, T1, T2, T3, T4, T5> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6>
	where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed3Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed3<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>
	where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed3Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed3<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed3Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed3Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed4Enumerator<T0, T1, T2, T3, T4>
	where T4 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed4Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed4<T0, T1, T2, T3, T4> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed4Enumerator<T0, T1, T2, T3, T4, T5>
	where T4 : unmanaged
    where T5 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed4Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed4<T0, T1, T2, T3, T4, T5> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6>
	where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed4Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed4<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>
	where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed4Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed4<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed4Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed4Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed5Enumerator<T0, T1, T2, T3, T4, T5>
	where T5 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed5Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed5<T0, T1, T2, T3, T4, T5> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6>
	where T5 : unmanaged
    where T6 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed5Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed5<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>
	where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed5Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed5<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed5Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed5Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6>
	where T6 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed6Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed6<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>
	where T6 : unmanaged
    where T7 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed6Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed6<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed6Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed6Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed7Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>
	where T7 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed7Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed7<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed7Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T7 : unmanaged
    where T8 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed7Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed7Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed7Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed8Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T8 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed8Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed8Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T8 : unmanaged
    where T9 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed8Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteMixed9Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T9 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteMixed9Enumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_ids = ids;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_offsets = archetype.GetOffsets(in _ids);
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
					_offsets = a.GetOffsets(in _ids);
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
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly ChunkWriteMixed9<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
