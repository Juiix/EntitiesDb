using System;

namespace EntitiesDb;

internal readonly ref struct ChangeFilterIterator(ReadOnlySpan<Chunk> chunks, ChangeFilter changeFilter, int compareVersion)
{
	private readonly ReadOnlySpan<Chunk> _chunks = chunks;
	private readonly ChangeFilter _changeFilter = changeFilter;
	private readonly int _compareVersion = compareVersion;

	public ChangeFilterEnumerator GetEnumerator()
	{
		return new ChangeFilterEnumerator(_chunks, _changeFilter, _compareVersion);
	}
}
