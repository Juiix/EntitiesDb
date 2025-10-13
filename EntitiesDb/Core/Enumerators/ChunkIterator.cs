using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public ref struct ChunkIterator(Span<Archetype> archetypes)
{
	private readonly Span<Archetype> _archetypes = archetypes;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator GetEnumerator()
	{
		return new ChunkEnumerator(_archetypes);
	}
}
