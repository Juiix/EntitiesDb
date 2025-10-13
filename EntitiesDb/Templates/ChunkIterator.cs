
using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public ref struct ChunkIterator<T0>(Span<Archetype> archetypes, Ids<T0> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0> GetEnumerator()
	{
		return new ChunkEnumerator<T0>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1>(Span<Archetype> archetypes, Ids<T0, T1> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1, T2>(Span<Archetype> archetypes, Ids<T0, T1, T2> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1, T2> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1, T2>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1, T2, T3>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1, T2, T3> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1, T2, T3>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1, T2, T3, T4>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1, T2, T3, T4> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1, T2, T3, T4>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1, T2, T3, T4, T5>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1, T2, T3, T4, T5> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1, T2, T3, T4, T5>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1, T2, T3, T4, T5, T6>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1, T2, T3, T4, T5, T6, T7>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> GetEnumerator()
	{
		return new ChunkEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(_archetypes, _ids);
	}
}
