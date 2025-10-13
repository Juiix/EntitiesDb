
using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

public ref struct ChunkMixed1Enumerator<T0, T1>
	where T1 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1> _offsets;

	[SkipLocalsInit]
	public ChunkMixed1Enumerator(Span<Archetype> archetypes, Ids<T0, T1> ids)
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

	public readonly ChunkMixed1<T0, T1> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed1Enumerator<T0, T1, T2>
	where T1 : unmanaged
    where T2 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2> _offsets;

	[SkipLocalsInit]
	public ChunkMixed1Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2> ids)
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

	public readonly ChunkMixed1<T0, T1, T2> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed1Enumerator<T0, T1, T2, T3>
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
	public ChunkMixed1Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3> ids)
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

	public readonly ChunkMixed1<T0, T1, T2, T3> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed1Enumerator<T0, T1, T2, T3, T4>
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
	public ChunkMixed1Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4> ids)
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

	public readonly ChunkMixed1<T0, T1, T2, T3, T4> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5>
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
	public ChunkMixed1Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5> ids)
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

	public readonly ChunkMixed1<T0, T1, T2, T3, T4, T5> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6>
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
	public ChunkMixed1Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
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

	public readonly ChunkMixed1<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>
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
	public ChunkMixed1Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
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

	public readonly ChunkMixed1<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
	public ChunkMixed1Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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

	public readonly ChunkMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
	public ChunkMixed1Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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

	public readonly ChunkMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed2Enumerator<T0, T1, T2>
	where T2 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2> _offsets;

	[SkipLocalsInit]
	public ChunkMixed2Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2> ids)
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

	public readonly ChunkMixed2<T0, T1, T2> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed2Enumerator<T0, T1, T2, T3>
	where T2 : unmanaged
    where T3 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3> _offsets;

	[SkipLocalsInit]
	public ChunkMixed2Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3> ids)
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

	public readonly ChunkMixed2<T0, T1, T2, T3> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed2Enumerator<T0, T1, T2, T3, T4>
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
	public ChunkMixed2Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4> ids)
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

	public readonly ChunkMixed2<T0, T1, T2, T3, T4> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5>
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
	public ChunkMixed2Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5> ids)
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

	public readonly ChunkMixed2<T0, T1, T2, T3, T4, T5> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6>
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
	public ChunkMixed2Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
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

	public readonly ChunkMixed2<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>
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
	public ChunkMixed2Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
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

	public readonly ChunkMixed2<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
	public ChunkMixed2Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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

	public readonly ChunkMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
	public ChunkMixed2Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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

	public readonly ChunkMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed3Enumerator<T0, T1, T2, T3>
	where T3 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3> _offsets;

	[SkipLocalsInit]
	public ChunkMixed3Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3> ids)
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

	public readonly ChunkMixed3<T0, T1, T2, T3> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed3Enumerator<T0, T1, T2, T3, T4>
	where T3 : unmanaged
    where T4 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4> _offsets;

	[SkipLocalsInit]
	public ChunkMixed3Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4> ids)
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

	public readonly ChunkMixed3<T0, T1, T2, T3, T4> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5>
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
	public ChunkMixed3Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5> ids)
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

	public readonly ChunkMixed3<T0, T1, T2, T3, T4, T5> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6>
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
	public ChunkMixed3Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
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

	public readonly ChunkMixed3<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>
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
	public ChunkMixed3Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
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

	public readonly ChunkMixed3<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
	public ChunkMixed3Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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

	public readonly ChunkMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
	public ChunkMixed3Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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

	public readonly ChunkMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed4Enumerator<T0, T1, T2, T3, T4>
	where T4 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4> _offsets;

	[SkipLocalsInit]
	public ChunkMixed4Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4> ids)
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

	public readonly ChunkMixed4<T0, T1, T2, T3, T4> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5>
	where T4 : unmanaged
    where T5 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5> _offsets;

	[SkipLocalsInit]
	public ChunkMixed4Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5> ids)
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

	public readonly ChunkMixed4<T0, T1, T2, T3, T4, T5> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6>
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
	public ChunkMixed4Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
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

	public readonly ChunkMixed4<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>
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
	public ChunkMixed4Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
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

	public readonly ChunkMixed4<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
	public ChunkMixed4Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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

	public readonly ChunkMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
	public ChunkMixed4Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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

	public readonly ChunkMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5>
	where T5 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5> _offsets;

	[SkipLocalsInit]
	public ChunkMixed5Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5> ids)
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

	public readonly ChunkMixed5<T0, T1, T2, T3, T4, T5> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6>
	where T5 : unmanaged
    where T6 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets;

	[SkipLocalsInit]
	public ChunkMixed5Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
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

	public readonly ChunkMixed5<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>
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
	public ChunkMixed5Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
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

	public readonly ChunkMixed5<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
	public ChunkMixed5Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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

	public readonly ChunkMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
	public ChunkMixed5Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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

	public readonly ChunkMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6>
	where T6 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets;

	[SkipLocalsInit]
	public ChunkMixed6Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
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

	public readonly ChunkMixed6<T0, T1, T2, T3, T4, T5, T6> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>
	where T6 : unmanaged
    where T7 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets;

	[SkipLocalsInit]
	public ChunkMixed6Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
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

	public readonly ChunkMixed6<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
	public ChunkMixed6Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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

	public readonly ChunkMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
	public ChunkMixed6Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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

	public readonly ChunkMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed7Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>
	where T7 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets;

	[SkipLocalsInit]
	public ChunkMixed7Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
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

	public readonly ChunkMixed7<T0, T1, T2, T3, T4, T5, T6, T7> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed7Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T7 : unmanaged
    where T8 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets;

	[SkipLocalsInit]
	public ChunkMixed7Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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

	public readonly ChunkMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed7Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
	public ChunkMixed7Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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

	public readonly ChunkMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed8Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T8 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets;

	[SkipLocalsInit]
	public ChunkMixed8Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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

	public readonly ChunkMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed8Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T8 : unmanaged
    where T9 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets;

	[SkipLocalsInit]
	public ChunkMixed8Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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

	public readonly ChunkMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
public ref struct ChunkMixed9Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T9 : unmanaged
{
	private ArchetypeEnumerator _archetypes;
	private Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids;
	private int _index;
	private ref Chunk _chunk;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets;

	[SkipLocalsInit]
	public ChunkMixed9Enumerator(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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

	public readonly ChunkMixed9<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(ref Unsafe.Add(ref _chunk, _index), _offsets);
	}
}
