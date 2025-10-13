
namespace EntitiesDb;

public partial class Query
{
	public ChunkBufferIterator<T0> GetChunkBufferIterator<T0>()
		where T0 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkBufferIterator<T0, T1> GetChunkBufferIterator<T0, T1>()
		where T0 : unmanaged
        where T1 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkBufferIterator<T0, T1, T2> GetChunkBufferIterator<T0, T1, T2>()
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkBufferIterator<T0, T1, T2, T3> GetChunkBufferIterator<T0, T1, T2, T3>()
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkBufferIterator<T0, T1, T2, T3, T4> GetChunkBufferIterator<T0, T1, T2, T3, T4>()
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkBufferIterator<T0, T1, T2, T3, T4, T5> GetChunkBufferIterator<T0, T1, T2, T3, T4, T5>()
		where T0 : unmanaged
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
	public ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6> GetChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6>()
		where T0 : unmanaged
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
	public ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7> GetChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7>()
		where T0 : unmanaged
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
	public ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
		where T0 : unmanaged
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
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		where T0 : unmanaged
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
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> GetChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> GetChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>()
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GetChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>()
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> GetChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>()
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> GetChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>()
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
	public ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> GetChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>()
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		Match();
		return new(MatchingArchetypesSpan, ids);
	}
}