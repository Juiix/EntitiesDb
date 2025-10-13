using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public ref struct ArchetypeEnumerator(Span<Archetype> archetypes)
{
	private ReadOnlyEnumerator<Archetype> _archetypes = new(archetypes);

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
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
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => _archetypes.Current;
	}
}
