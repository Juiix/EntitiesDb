using System;
using System.Buffers;

namespace EntitiesDb;

public sealed partial class Query
{
	private readonly ArchetypeCollection _archetypes;
	private readonly ParallelJobRunner? _parallelRunner;
	private readonly QueryFilter _filter;
	private Archetype[] _matchingArchetypes = ArrayPool<Archetype>.Shared.Rent(16);
	private int _matchingCount = 0;
	private int _matchVersion;

	internal Query(ArchetypeCollection archetypes, ParallelJobRunner? parallelRunner, QueryFilter filter, ChangeFilter? changeFilter)
	{
		_archetypes = archetypes;
		_filter = filter;
		_parallelRunner = parallelRunner;
		ChangeFilter = changeFilter;
	}

	public ChangeFilter? ChangeFilter { get; }

	private Span<Archetype> MatchingArchetypesSpan => _matchingArchetypes.AsSpan(0, _matchingCount);

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
	/// Returns <see cref="ArchetypeIterator"/> for matching <see cref="Archetype"/> entities
	/// </summary>
	public ArchetypeIterator EnumerateArchetypes()
	{
		Match();
		return new ArchetypeIterator(MatchingArchetypesSpan);
	}

	/// <summary>
	/// <see cref="ArchetypeChunkIterator"/> for matching <see cref="Chunk"/>'s of entities
	/// </summary>
	public ArchetypeChunkIterator Enumerate()
	{
		Match();
		return new ArchetypeChunkIterator(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version);
	}

	/// <summary>
	/// <see cref="ArchetypeChunkEnumerator"/> for matching <see cref="Archetype"/> entities
	/// </summary>
	public ArchetypeEnumerator GetEnumerator()
	{
		Match();
		return new ArchetypeEnumerator(MatchingArchetypesSpan);
	}

	/// <summary>
	/// Match and update <see cref="_matchingArchetypes"/> against <see cref="_archetypes"/>
	/// </summary>
	public void Match()
	{
		if (_matchVersion == _archetypes.Version)
			return;

		Array.Clear(_matchingArchetypes, 0, _matchingCount);
		_matchingCount = 0;
		foreach (var archetype in _archetypes.AsSpan())
		{
			if (Matches(in archetype.Signature))
			{
				if (_matchingCount >= _matchingArchetypes.Length)
				{
					var newArr = ArrayPool<Archetype>.Shared.Rent(_matchingArchetypes.Length * 2);
					Array.Copy(_matchingArchetypes, newArr, _matchingCount);
					Array.Clear(_matchingArchetypes, 0, _matchingCount);
					ArrayPool<Archetype>.Shared.Return(_matchingArchetypes);
					_matchingArchetypes = newArr;
				}
				_matchingArchetypes[_matchingCount++] = archetype;
			}
		}
		_matchVersion = _archetypes.Version;
	}
}
