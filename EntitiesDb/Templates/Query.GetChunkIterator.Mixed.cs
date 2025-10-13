
using System;

namespace EntitiesDb;

public partial class Query
{
	public ChunkMixed1Iterator<T0, T1> GetChunkMixed1Iterator<T0, T1>()
		where T1 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed1Iterator<T0, T1, T2> GetChunkMixed1Iterator<T0, T1, T2>()
		where T1 : unmanaged
        where T2 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed1Iterator<T0, T1, T2, T3> GetChunkMixed1Iterator<T0, T1, T2, T3>()
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed1Iterator<T0, T1, T2, T3, T4> GetChunkMixed1Iterator<T0, T1, T2, T3, T4>()
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed1Iterator<T0, T1, T2, T3, T4, T5> GetChunkMixed1Iterator<T0, T1, T2, T3, T4, T5>()
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed1Iterator<T0, T1, T2, T3, T4, T5, T6> GetChunkMixed1Iterator<T0, T1, T2, T3, T4, T5, T6>()
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed1Iterator<T0, T1, T2, T3, T4, T5, T6, T7> GetChunkMixed1Iterator<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed2Iterator<T0, T1, T2> GetChunkMixed2Iterator<T0, T1, T2>()
		where T2 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed2Iterator<T0, T1, T2, T3> GetChunkMixed2Iterator<T0, T1, T2, T3>()
		where T2 : unmanaged
        where T3 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed2Iterator<T0, T1, T2, T3, T4> GetChunkMixed2Iterator<T0, T1, T2, T3, T4>()
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed2Iterator<T0, T1, T2, T3, T4, T5> GetChunkMixed2Iterator<T0, T1, T2, T3, T4, T5>()
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed2Iterator<T0, T1, T2, T3, T4, T5, T6> GetChunkMixed2Iterator<T0, T1, T2, T3, T4, T5, T6>()
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed2Iterator<T0, T1, T2, T3, T4, T5, T6, T7> GetChunkMixed2Iterator<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed3Iterator<T0, T1, T2, T3> GetChunkMixed3Iterator<T0, T1, T2, T3>()
		where T3 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed3Iterator<T0, T1, T2, T3, T4> GetChunkMixed3Iterator<T0, T1, T2, T3, T4>()
		where T3 : unmanaged
        where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed3Iterator<T0, T1, T2, T3, T4, T5> GetChunkMixed3Iterator<T0, T1, T2, T3, T4, T5>()
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed3Iterator<T0, T1, T2, T3, T4, T5, T6> GetChunkMixed3Iterator<T0, T1, T2, T3, T4, T5, T6>()
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed3Iterator<T0, T1, T2, T3, T4, T5, T6, T7> GetChunkMixed3Iterator<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed4Iterator<T0, T1, T2, T3, T4> GetChunkMixed4Iterator<T0, T1, T2, T3, T4>()
		where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed4Iterator<T0, T1, T2, T3, T4, T5> GetChunkMixed4Iterator<T0, T1, T2, T3, T4, T5>()
		where T4 : unmanaged
        where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed4Iterator<T0, T1, T2, T3, T4, T5, T6> GetChunkMixed4Iterator<T0, T1, T2, T3, T4, T5, T6>()
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed4Iterator<T0, T1, T2, T3, T4, T5, T6, T7> GetChunkMixed4Iterator<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed5Iterator<T0, T1, T2, T3, T4, T5> GetChunkMixed5Iterator<T0, T1, T2, T3, T4, T5>()
		where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed5Iterator<T0, T1, T2, T3, T4, T5, T6> GetChunkMixed5Iterator<T0, T1, T2, T3, T4, T5, T6>()
		where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed5Iterator<T0, T1, T2, T3, T4, T5, T6, T7> GetChunkMixed5Iterator<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed6Iterator<T0, T1, T2, T3, T4, T5, T6> GetChunkMixed6Iterator<T0, T1, T2, T3, T4, T5, T6>()
		where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed6Iterator<T0, T1, T2, T3, T4, T5, T6, T7> GetChunkMixed6Iterator<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkMixed7Iterator<T0, T1, T2, T3, T4, T5, T6, T7> GetChunkMixed7Iterator<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
}