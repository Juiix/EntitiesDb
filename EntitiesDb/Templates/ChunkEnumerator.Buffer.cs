
using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

public ref struct ChunkBufferEnumerator<T0>
	where T0 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0> ids)
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

	public readonly ChunkBuffer<T0> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1>
	where T0 : unmanaged
    where T1 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1> ids)
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

	public readonly ChunkBuffer<T0, T1> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1, T2>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2> ids)
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

	public readonly ChunkBuffer<T0, T1, T2> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1, T2, T3>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3> ids)
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

	public readonly ChunkBuffer<T0, T1, T2, T3> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1, T2, T3, T4>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4> ids)
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

	public readonly ChunkBuffer<T0, T1, T2, T3, T4> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5> ids)
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

	public readonly ChunkBuffer<T0, T1, T2, T3, T4, T5> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
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

	public readonly ChunkBuffer<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7>
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
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
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

	public readonly ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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

	public readonly ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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

	public readonly ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids)
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

	public readonly ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids)
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

	public readonly ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids)
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

	public readonly ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
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
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids)
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

	public readonly ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
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
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids)
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

	public readonly ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
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
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _offsets;

	[SkipLocalsInit]
	public ChunkBufferEnumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids)
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

	public readonly ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
