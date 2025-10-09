using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EntitiesDb;

public sealed partial class Query
{
	private readonly QueryFilter _filter;
	private readonly ArchetypeCollection _archetypes;
	private readonly List<Archetype> _matchingArchetypes = [];
	private int _matchVersion;

	internal Query(ArchetypeCollection archetypes, QueryFilter filter)
	{
		_archetypes = archetypes;
		_filter = filter;
	}

	private Span<Archetype> MatchingArchetypesSpan => CollectionsMarshal.AsSpan(_matchingArchetypes);

	/// <summary>
	/// If a given <see cref="Signature"/> matches this query
	/// </summary>
	/// <param name="signature">The <see cref="Signature"/> to match</param>
	/// <returns>If <paramref name="signature"/> matches</returns>
	public bool Matches(in Signature signature)
	{
		return _filter.Mode switch
		{
			QueryFilterMode.Only => signature.Equals(in _filter.All),
			_ =>   signature.HasAll(in _filter.All)
				&& signature.HasAny(in _filter.Any)
				&& signature.HasNone(in _filter.None),
		};
	}

	/// <summary>
	/// Returns <see cref="ArchetypeIterator"/> for matching <see cref="Archetype"/>'s entities
	/// </summary>
	public ArchetypeIterator GetArchetypeIterator()
	{
		Match();
		return new ArchetypeIterator(MatchingArchetypesSpan);
	}

	/// <summary>
	/// <see cref="ChunkIterator"/> for matching <see cref="Chunk"/>'s of entities
	/// </summary>
	public ChunkIterator GetChunkIterator()
	{
		Match();
		return new ChunkIterator(MatchingArchetypesSpan);
	}

	/// <summary>
	/// <see cref="ChunkEnumerator"/> for matching <see cref="Chunk"/>'s of entities
	/// </summary>
	public ChunkEnumerator GetEnumerator()
	{
		Match();
		return new ChunkEnumerator(MatchingArchetypesSpan);
	}

	/// <summary>
	/// Match and update <see cref="_matchingArchetypes"/> against <see cref="_archetypes"/>
	/// </summary>
	public void Match()
	{
		if (_matchVersion == _archetypes.Version)
			return;

		_matchingArchetypes.Clear();
		foreach (var archetype in _archetypes.AsSpan())
		{
			if (Matches(in archetype.Signature))
			{
				_matchingArchetypes.Add(archetype);
			}
		}
		_matchVersion = _archetypes.Version;
	}
}
