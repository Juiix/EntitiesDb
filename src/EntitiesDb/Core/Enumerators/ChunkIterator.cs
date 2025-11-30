using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public readonly ref struct ChunkIterator(Span<Chunk> chunks, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Chunk> _chunks = chunks;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator GetEnumerator()
	{
		return new ChunkEnumerator(_chunks, _changeFilter, _compareVersion);
	}
}