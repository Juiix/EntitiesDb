using System;

namespace EntitiesDb;

internal ref struct ChangeFilterEnumerator
{
	private readonly ReadOnlySpan<Chunk> _chunks;
	private readonly ChangeFilter _changeFilter;
	private readonly int _compareVersion;
	private int _index = -1;
	private int _size = 0;

	public ChangeFilterEnumerator(ReadOnlySpan<Chunk> chunks, ChangeFilter changeFilter, int compareVersion)
	{
		_chunks = chunks;
		_changeFilter = changeFilter;
		_compareVersion = compareVersion;

		_index = chunks.Length;
	}

	public bool MoveNext()
	{
		unchecked
		{
			if (--_index < 0)
				return false;

			_size = 0;
			for (; _index >= 0; _index--)
			{
				ref readonly var chunk = ref _chunks[_index];
				var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
				if ((chunkVersion - _compareVersion) <= 0)
				{
					if (_size > 0)
					{
						_index++;
						return true;
					}
					continue;
				}

				Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
				_size++;
			}

			_index = 0;
			return _size > 0;
		}
	}

	public void Reset()
	{
		_index = _chunks.Length;
	}

	/// <summary>
	/// Partitions evenly, spreading remainders across the first indices
	/// <br/>
	/// e.g size=24, slices=5, sliceSize=4
	/// <br/>
	/// 5, 5, 5, 5, 4
	/// </summary>
	public ChunkRange Current
	{
		get => new(_index, _size);
	}
}
