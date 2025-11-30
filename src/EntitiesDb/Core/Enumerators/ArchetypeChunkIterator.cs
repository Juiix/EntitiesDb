using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public readonly ref struct ArchetypeChunkIterator
{
	private readonly Span<Archetype> _archetypes;
	private readonly ChangeFilter? _changeFilter;
	private readonly int? _compareVersion;

	public ArchetypeChunkIterator(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
	{
		_archetypes = archetypes;
		_changeFilter = changeFilter;
		_compareVersion = compareVersion;
	}

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ArchetypeChunkEnumerator GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
