
using System;

namespace EntitiesDb;

public partial class Query
{
	public ArchetypeChunkWriteMixed1Iterator<T0, T1> GetWriteHandlesM1<T0, T1>()
		where T1 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed1Iterator<T0, T1, T2> GetWriteHandlesM1<T0, T1, T2>()
		where T1 : unmanaged
        where T2 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed1Iterator<T0, T1, T2, T3> GetWriteHandlesM1<T0, T1, T2, T3>()
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed1Iterator<T0, T1, T2, T3, T4> GetWriteHandlesM1<T0, T1, T2, T3, T4>()
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed1Iterator<T0, T1, T2, T3, T4, T5> GetWriteHandlesM1<T0, T1, T2, T3, T4, T5>()
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
	public ArchetypeChunkWriteMixed1Iterator<T0, T1, T2, T3, T4, T5, T6> GetWriteHandlesM1<T0, T1, T2, T3, T4, T5, T6>()
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
	public ArchetypeChunkWriteMixed1Iterator<T0, T1, T2, T3, T4, T5, T6, T7> GetWriteHandlesM1<T0, T1, T2, T3, T4, T5, T6, T7>()
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
	public ArchetypeChunkWriteMixed1Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetWriteHandlesM1<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
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
	public ArchetypeChunkWriteMixed1Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetWriteHandlesM1<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
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
	public ArchetypeChunkWriteMixed2Iterator<T0, T1, T2> GetWriteHandlesM2<T0, T1, T2>()
		where T2 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed2Iterator<T0, T1, T2, T3> GetWriteHandlesM2<T0, T1, T2, T3>()
		where T2 : unmanaged
        where T3 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed2Iterator<T0, T1, T2, T3, T4> GetWriteHandlesM2<T0, T1, T2, T3, T4>()
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed2Iterator<T0, T1, T2, T3, T4, T5> GetWriteHandlesM2<T0, T1, T2, T3, T4, T5>()
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed2Iterator<T0, T1, T2, T3, T4, T5, T6> GetWriteHandlesM2<T0, T1, T2, T3, T4, T5, T6>()
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
	public ArchetypeChunkWriteMixed2Iterator<T0, T1, T2, T3, T4, T5, T6, T7> GetWriteHandlesM2<T0, T1, T2, T3, T4, T5, T6, T7>()
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
	public ArchetypeChunkWriteMixed2Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetWriteHandlesM2<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
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
	public ArchetypeChunkWriteMixed2Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetWriteHandlesM2<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
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
	public ArchetypeChunkWriteMixed3Iterator<T0, T1, T2, T3> GetWriteHandlesM3<T0, T1, T2, T3>()
		where T3 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed3Iterator<T0, T1, T2, T3, T4> GetWriteHandlesM3<T0, T1, T2, T3, T4>()
		where T3 : unmanaged
        where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed3Iterator<T0, T1, T2, T3, T4, T5> GetWriteHandlesM3<T0, T1, T2, T3, T4, T5>()
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed3Iterator<T0, T1, T2, T3, T4, T5, T6> GetWriteHandlesM3<T0, T1, T2, T3, T4, T5, T6>()
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed3Iterator<T0, T1, T2, T3, T4, T5, T6, T7> GetWriteHandlesM3<T0, T1, T2, T3, T4, T5, T6, T7>()
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
	public ArchetypeChunkWriteMixed3Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetWriteHandlesM3<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
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
	public ArchetypeChunkWriteMixed3Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetWriteHandlesM3<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
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
	public ArchetypeChunkWriteMixed4Iterator<T0, T1, T2, T3, T4> GetWriteHandlesM4<T0, T1, T2, T3, T4>()
		where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed4Iterator<T0, T1, T2, T3, T4, T5> GetWriteHandlesM4<T0, T1, T2, T3, T4, T5>()
		where T4 : unmanaged
        where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed4Iterator<T0, T1, T2, T3, T4, T5, T6> GetWriteHandlesM4<T0, T1, T2, T3, T4, T5, T6>()
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed4Iterator<T0, T1, T2, T3, T4, T5, T6, T7> GetWriteHandlesM4<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed4Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetWriteHandlesM4<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
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
	public ArchetypeChunkWriteMixed4Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetWriteHandlesM4<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
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
	public ArchetypeChunkWriteMixed5Iterator<T0, T1, T2, T3, T4, T5> GetWriteHandlesM5<T0, T1, T2, T3, T4, T5>()
		where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed5Iterator<T0, T1, T2, T3, T4, T5, T6> GetWriteHandlesM5<T0, T1, T2, T3, T4, T5, T6>()
		where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed5Iterator<T0, T1, T2, T3, T4, T5, T6, T7> GetWriteHandlesM5<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed5Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetWriteHandlesM5<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed5Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetWriteHandlesM5<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
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
	public ArchetypeChunkWriteMixed6Iterator<T0, T1, T2, T3, T4, T5, T6> GetWriteHandlesM6<T0, T1, T2, T3, T4, T5, T6>()
		where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed6Iterator<T0, T1, T2, T3, T4, T5, T6, T7> GetWriteHandlesM6<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed6Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetWriteHandlesM6<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed6Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetWriteHandlesM6<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed7Iterator<T0, T1, T2, T3, T4, T5, T6, T7> GetWriteHandlesM7<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed7Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetWriteHandlesM7<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
		where T7 : unmanaged
        where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed7Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetWriteHandlesM7<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed8Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetWriteHandlesM8<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
		where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed8Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetWriteHandlesM8<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		where T8 : unmanaged
        where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
	public ArchetypeChunkWriteMixed9Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetWriteHandlesM9<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		Match();
		return new(MatchingArchetypesSpan, ChangeFilter, ChangeFilter?.Version, ids);
	}
}