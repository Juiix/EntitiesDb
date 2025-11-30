using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public unsafe ref struct ChunkEnumerator
{
	private ReadOnlyEnumerator<Chunk> _chunks;
	private readonly ChangeFilter? _changeFilter;
	private readonly int _compareVersion;

	[SkipLocalsInit]
	public ChunkEnumerator(Span<Chunk> chunks, ChangeFilter? changeFilter, int? compareVersion)
	{
		_chunks = new ReadOnlyEnumerator<Chunk>(chunks);
		_changeFilter = changeFilter;
		_compareVersion = compareVersion ?? _changeFilter?.Version ?? 0;
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		while (_chunks.MoveNext())
		{
			if (_changeFilter == null)
				return true;

			ref readonly var chunk = ref _chunks.Current;
			var chunkVersion = chunk.LocalChangeVersions[_changeFilter.Id];
			if ((chunkVersion - _compareVersion) > 0)
			{
				Dangerous.InterlockedExchangeIfGreaterThan(ref _changeFilter.InternalVersion, chunkVersion, chunkVersion);
				return true;
			}
		}
		return false;
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_chunks.Reset();
	}

	public readonly ref readonly Chunk Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => ref _chunks.Current;
	}
}
