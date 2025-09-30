using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public ref struct ChunkIterator
{
	private readonly Span<Archetype> _archetypes;

	[SkipLocalsInit]
	public ChunkIterator(Span<Archetype> archetypes)
	{
		_archetypes = archetypes;
	}

	[SkipLocalsInit]
	public ChunkEnumerator GetEnumerator()
	{
		return new ChunkEnumerator(_archetypes);
	}
}
