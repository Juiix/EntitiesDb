using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public ref struct ChunkEnumerator
{
	private ArchetypeEnumerator _archetypes;
	private int _index;
	private ref Chunk _chunk;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);

		// Make it move once, otherwise we can not check directly for Current.Size which results in bad behaviour
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
		}
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		unchecked
		{
			// Decrease chunk till its zero, skip empty chunks -> otherwise entity query might fail since it tries to acess that chunk
			if (--_index >= 0)
			{
				return true;
			}

			// Return false if there no new archetypes
			if (!_archetypes.MoveNext())
			{
				return false;
			}

			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse - 1;
			_chunk = ref archetype.GetChunk(0);
			return true;
		}
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_index = -1;
		_archetypes.Reset();

		// Make it move once, otherwise we can not check directly for Current.Size which results in bad behaviour
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
			_chunk = ref archetype.GetChunk(0);
		}
	}

	public readonly ref readonly Chunk Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => ref Unsafe.Add(ref _chunk, _index);
	}
}
