using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public ref struct ChunkEnumerator
{
	private ArchetypeEnumerator _archetypes;
	private int _index;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Archetype> archetypes)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);

		// Make it move once, otherwise we can not check directly for Current.Size which results in bad behaviour
		if (_archetypes.MoveNext())
		{
			_index = _archetypes.Current.ChunkCount + 1;
		}
	}
	[SkipLocalsInit]
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

			_index = _archetypes.Current.ChunkCount;
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
			_index = _archetypes.Current.ChunkCount + 1;
		}
	}

	public readonly ref Chunk Current
	{
		[SkipLocalsInit]
		get => ref _archetypes.Current.GetChunk(_index);
	}
}
