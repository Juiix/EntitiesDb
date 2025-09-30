using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public ref struct ArchetypeEnumerator
{
	private ReadOnlyEnumerator<Archetype> _archetypes;

	[SkipLocalsInit]
	public ArchetypeEnumerator(Span<Archetype> archetypes)
	{
		_archetypes = new ReadOnlyEnumerator<Archetype>(archetypes);
	}

	[SkipLocalsInit]
	public bool MoveNext()
	{
		// Caching query locally for less lookups, improved speed
		while (_archetypes.MoveNext())
		{
			var archetype = _archetypes.Current;
			if (archetype.EntityCount > 0)
			{
				return true;
			}
		}

		return false;
	}

	[SkipLocalsInit]
	public void Reset()
	{
		_archetypes.Reset();
	}

	public readonly Archetype Current
	{
		[SkipLocalsInit]
		get => _archetypes.Current;
	}
}
