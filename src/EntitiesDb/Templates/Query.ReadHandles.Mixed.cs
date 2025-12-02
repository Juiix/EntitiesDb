
using System;

namespace EntitiesDb;

public partial class Query
{
	public ArchetypeChunkReadMixed1Iterator<T0, T1> ReadHandlesM1<T0, T1>()
		where T1 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed1Iterator<T0, T1, T2> ReadHandlesM1<T0, T1, T2>()
		where T1 : unmanaged
        where T2 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed1Iterator<T0, T1, T2, T3> ReadHandlesM1<T0, T1, T2, T3>()
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed1Iterator<T0, T1, T2, T3, T4> ReadHandlesM1<T0, T1, T2, T3, T4>()
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed1Iterator<T0, T1, T2, T3, T4, T5> ReadHandlesM1<T0, T1, T2, T3, T4, T5>()
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed1Iterator<T0, T1, T2, T3, T4, T5, T6> ReadHandlesM1<T0, T1, T2, T3, T4, T5, T6>()
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed1Iterator<T0, T1, T2, T3, T4, T5, T6, T7> ReadHandlesM1<T0, T1, T2, T3, T4, T5, T6, T7>()
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
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed1Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> ReadHandlesM1<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed1Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ReadHandlesM1<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed2Iterator<T0, T1, T2> ReadHandlesM2<T0, T1, T2>()
		where T2 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed2Iterator<T0, T1, T2, T3> ReadHandlesM2<T0, T1, T2, T3>()
		where T2 : unmanaged
        where T3 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed2Iterator<T0, T1, T2, T3, T4> ReadHandlesM2<T0, T1, T2, T3, T4>()
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed2Iterator<T0, T1, T2, T3, T4, T5> ReadHandlesM2<T0, T1, T2, T3, T4, T5>()
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed2Iterator<T0, T1, T2, T3, T4, T5, T6> ReadHandlesM2<T0, T1, T2, T3, T4, T5, T6>()
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed2Iterator<T0, T1, T2, T3, T4, T5, T6, T7> ReadHandlesM2<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed2Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> ReadHandlesM2<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed2Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ReadHandlesM2<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed3Iterator<T0, T1, T2, T3> ReadHandlesM3<T0, T1, T2, T3>()
		where T3 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed3Iterator<T0, T1, T2, T3, T4> ReadHandlesM3<T0, T1, T2, T3, T4>()
		where T3 : unmanaged
        where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed3Iterator<T0, T1, T2, T3, T4, T5> ReadHandlesM3<T0, T1, T2, T3, T4, T5>()
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed3Iterator<T0, T1, T2, T3, T4, T5, T6> ReadHandlesM3<T0, T1, T2, T3, T4, T5, T6>()
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed3Iterator<T0, T1, T2, T3, T4, T5, T6, T7> ReadHandlesM3<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed3Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> ReadHandlesM3<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed3Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ReadHandlesM3<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed4Iterator<T0, T1, T2, T3, T4> ReadHandlesM4<T0, T1, T2, T3, T4>()
		where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed4Iterator<T0, T1, T2, T3, T4, T5> ReadHandlesM4<T0, T1, T2, T3, T4, T5>()
		where T4 : unmanaged
        where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed4Iterator<T0, T1, T2, T3, T4, T5, T6> ReadHandlesM4<T0, T1, T2, T3, T4, T5, T6>()
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed4Iterator<T0, T1, T2, T3, T4, T5, T6, T7> ReadHandlesM4<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed4Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> ReadHandlesM4<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed4Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ReadHandlesM4<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed5Iterator<T0, T1, T2, T3, T4, T5> ReadHandlesM5<T0, T1, T2, T3, T4, T5>()
		where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed5Iterator<T0, T1, T2, T3, T4, T5, T6> ReadHandlesM5<T0, T1, T2, T3, T4, T5, T6>()
		where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed5Iterator<T0, T1, T2, T3, T4, T5, T6, T7> ReadHandlesM5<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed5Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> ReadHandlesM5<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed5Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ReadHandlesM5<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed6Iterator<T0, T1, T2, T3, T4, T5, T6> ReadHandlesM6<T0, T1, T2, T3, T4, T5, T6>()
		where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed6Iterator<T0, T1, T2, T3, T4, T5, T6, T7> ReadHandlesM6<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed6Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> ReadHandlesM6<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed6Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ReadHandlesM6<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed7Iterator<T0, T1, T2, T3, T4, T5, T6, T7> ReadHandlesM7<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed7Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> ReadHandlesM7<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
		where T7 : unmanaged
        where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed7Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ReadHandlesM7<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed8Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> ReadHandlesM8<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
		where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed8Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ReadHandlesM8<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		where T8 : unmanaged
        where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkReadMixed9Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ReadHandlesM9<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
}