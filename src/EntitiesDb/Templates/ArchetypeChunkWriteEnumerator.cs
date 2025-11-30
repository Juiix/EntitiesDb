
using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

public ref struct ArchetypeChunkWriteEnumerator<T0>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0> ids)
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

	public readonly ChunkWrite<T0> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1> ids)
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

	public readonly ChunkWrite<T0, T1> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1, T2>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2> ids)
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

	public readonly ChunkWrite<T0, T1, T2> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1, T2, T3>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3> ids)
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

	public readonly ChunkWrite<T0, T1, T2, T3> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1, T2, T3, T4>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4> ids)
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

	public readonly ChunkWrite<T0, T1, T2, T3, T4> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1, T2, T3, T4, T5>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5> ids)
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

	public readonly ChunkWrite<T0, T1, T2, T3, T4, T5> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1, T2, T3, T4, T5, T6>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
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

	public readonly ChunkWrite<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1, T2, T3, T4, T5, T6, T7>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
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

	public readonly ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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

	public readonly ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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

	public readonly ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids)
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

	public readonly ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids)
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

	public readonly ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids)
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

	public readonly ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids)
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

	public readonly ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids)
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

	public readonly ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
public ref struct ArchetypeChunkWriteEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _ids;
	private readonly int _compareVersion;
	private int _index;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _offsets;

	[SkipLocalsInit]
	public ArchetypeChunkWriteEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids)
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

	public readonly ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref _archetypes.Current.GetChunk(_index), _offsets);
	}
}
