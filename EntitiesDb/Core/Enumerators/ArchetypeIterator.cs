using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public readonly ref struct ArchetypeIterator
{
	private readonly Span<Archetype> _archetypes;

	[SkipLocalsInit]
	public ArchetypeIterator(Span<Archetype> archetypes)
	{
		_archetypes = archetypes;
	}

	[SkipLocalsInit]
	public ArchetypeEnumerator GetEnumerator()
	{
		return new ArchetypeEnumerator(_archetypes);
	}
}