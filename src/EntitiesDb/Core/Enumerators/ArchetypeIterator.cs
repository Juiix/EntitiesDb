using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public readonly ref struct ArchetypeIterator(Span<Archetype> archetypes)
{
	private readonly Span<Archetype> _archetypes = archetypes;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ArchetypeEnumerator GetEnumerator()
	{
		return new ArchetypeEnumerator(_archetypes);
	}
}