
using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0>(Span<Archetype> archetypes, Ids<T0> ids)
	where T0 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1>(Span<Archetype> archetypes, Ids<T0, T1> ids)
	where T0 : unmanaged
    where T1 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1, T2>(Span<Archetype> archetypes, Ids<T0, T1, T2> ids)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1, T2> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1, T2>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1, T2, T3>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3> ids)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1, T2, T3> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1, T2, T3>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1, T2, T3, T4>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4> ids)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1, T2, T3, T4> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1, T2, T3, T4>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1, T2, T3, T4, T5>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5> ids)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids)
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
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids)
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
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids)
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
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids)
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
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids)
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
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkBufferIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids)
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
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> GetEnumerator()
	{
		return new ChunkBufferEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(_archetypes, _ids);
	}
}
