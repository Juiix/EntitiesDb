
using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

public ref struct ChunkEnumerator<T0>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1, T2>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1, T2> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1, T2, T3>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1, T2, T3> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1, T2, T3, T4>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1, T2, T3, T4> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1, T2, T3, T4, T5>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1, T2, T3, T4, T5> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _offsets;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_ids = ids;
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			if (--_index >= 0)
				return true;

			if (!_archetypes.MoveNext())
				return false;

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
			return true;
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
			_chunk = ref archetype.GetChunk(0);
			_offsets = archetype.GetOffsets(in _ids);
		}
	}

	public readonly Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
