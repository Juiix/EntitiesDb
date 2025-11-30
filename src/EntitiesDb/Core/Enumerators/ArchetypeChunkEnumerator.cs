using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace EntitiesDb;

[SkipLocalsInit]
public unsafe ref struct ArchetypeChunkEnumerator
{
	private ArchetypeEnumerator _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;
	private int _index;

	[SkipLocalsInit]
	public ArchetypeChunkEnumerator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = new ArchetypeEnumerator(archetypes);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;

		// Make it move once, otherwise we can not check directly for Current.Size which results in bad behaviour
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

		// Make it move once, otherwise we can not check directly for Current.Size which results in bad behaviour
		if (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			_index = archetype.ChunksInUse;
		}
	}

	public readonly ref readonly Chunk Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => ref _archetypes.Current.GetChunk(_index);
	}
}
