
using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public ref struct ChunkMixed1Iterator<T0, T1>(Span<Archetype> archetypes, Ids<T0, T1> ids)
	where T1 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed1Enumerator<T0, T1> GetEnumerator()
	{
		return new ChunkMixed1Enumerator<T0, T1>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed1Iterator<T0, T1, T2>(Span<Archetype> archetypes, Ids<T0, T1, T2> ids)
	where T1 : unmanaged
    where T2 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed1Enumerator<T0, T1, T2> GetEnumerator()
	{
		return new ChunkMixed1Enumerator<T0, T1, T2>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed1Iterator<T0, T1, T2, T3>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3> ids)
	where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed1Enumerator<T0, T1, T2, T3> GetEnumerator()
	{
		return new ChunkMixed1Enumerator<T0, T1, T2, T3>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed1Iterator<T0, T1, T2, T3, T4>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4> ids)
	where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed1Enumerator<T0, T1, T2, T3, T4> GetEnumerator()
	{
		return new ChunkMixed1Enumerator<T0, T1, T2, T3, T4>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed1Iterator<T0, T1, T2, T3, T4, T5>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5> ids)
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
	public ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5> GetEnumerator()
	{
		return new ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed1Iterator<T0, T1, T2, T3, T4, T5, T6>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
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
	public ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6> GetEnumerator()
	{
		return new ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed1Iterator<T0, T1, T2, T3, T4, T5, T6, T7>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
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
	public ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6, T7> GetEnumerator()
	{
		return new ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed1Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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
	public ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetEnumerator()
	{
		return new ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed1Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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
	public ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetEnumerator()
	{
		return new ChunkMixed1Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed2Iterator<T0, T1, T2>(Span<Archetype> archetypes, Ids<T0, T1, T2> ids)
	where T2 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed2Enumerator<T0, T1, T2> GetEnumerator()
	{
		return new ChunkMixed2Enumerator<T0, T1, T2>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed2Iterator<T0, T1, T2, T3>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3> ids)
	where T2 : unmanaged
    where T3 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed2Enumerator<T0, T1, T2, T3> GetEnumerator()
	{
		return new ChunkMixed2Enumerator<T0, T1, T2, T3>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed2Iterator<T0, T1, T2, T3, T4>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4> ids)
	where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed2Enumerator<T0, T1, T2, T3, T4> GetEnumerator()
	{
		return new ChunkMixed2Enumerator<T0, T1, T2, T3, T4>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed2Iterator<T0, T1, T2, T3, T4, T5>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5> ids)
	where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5> GetEnumerator()
	{
		return new ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed2Iterator<T0, T1, T2, T3, T4, T5, T6>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
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
	public ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6> GetEnumerator()
	{
		return new ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed2Iterator<T0, T1, T2, T3, T4, T5, T6, T7>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
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
	public ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6, T7> GetEnumerator()
	{
		return new ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed2Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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
	public ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetEnumerator()
	{
		return new ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed2Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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
	public ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetEnumerator()
	{
		return new ChunkMixed2Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed3Iterator<T0, T1, T2, T3>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3> ids)
	where T3 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed3Enumerator<T0, T1, T2, T3> GetEnumerator()
	{
		return new ChunkMixed3Enumerator<T0, T1, T2, T3>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed3Iterator<T0, T1, T2, T3, T4>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4> ids)
	where T3 : unmanaged
    where T4 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed3Enumerator<T0, T1, T2, T3, T4> GetEnumerator()
	{
		return new ChunkMixed3Enumerator<T0, T1, T2, T3, T4>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed3Iterator<T0, T1, T2, T3, T4, T5>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5> ids)
	where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5> GetEnumerator()
	{
		return new ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed3Iterator<T0, T1, T2, T3, T4, T5, T6>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6> GetEnumerator()
	{
		return new ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed3Iterator<T0, T1, T2, T3, T4, T5, T6, T7>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
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
	public ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6, T7> GetEnumerator()
	{
		return new ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed3Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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
	public ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetEnumerator()
	{
		return new ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed3Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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
	public ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetEnumerator()
	{
		return new ChunkMixed3Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed4Iterator<T0, T1, T2, T3, T4>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4> ids)
	where T4 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed4Enumerator<T0, T1, T2, T3, T4> GetEnumerator()
	{
		return new ChunkMixed4Enumerator<T0, T1, T2, T3, T4>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed4Iterator<T0, T1, T2, T3, T4, T5>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5> ids)
	where T4 : unmanaged
    where T5 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5> GetEnumerator()
	{
		return new ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed4Iterator<T0, T1, T2, T3, T4, T5, T6>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6> GetEnumerator()
	{
		return new ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed4Iterator<T0, T1, T2, T3, T4, T5, T6, T7>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6, T7> GetEnumerator()
	{
		return new ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed4Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
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
	public ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetEnumerator()
	{
		return new ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed4Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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
	public ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetEnumerator()
	{
		return new ChunkMixed4Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed5Iterator<T0, T1, T2, T3, T4, T5>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5> ids)
	where T5 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5> GetEnumerator()
	{
		return new ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed5Iterator<T0, T1, T2, T3, T4, T5, T6>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	where T5 : unmanaged
    where T6 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6> GetEnumerator()
	{
		return new ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed5Iterator<T0, T1, T2, T3, T4, T5, T6, T7>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6, T7> GetEnumerator()
	{
		return new ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed5Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetEnumerator()
	{
		return new ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed5Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
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
	public ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetEnumerator()
	{
		return new ChunkMixed5Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed6Iterator<T0, T1, T2, T3, T4, T5, T6>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	where T6 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6> GetEnumerator()
	{
		return new ChunkMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed6Iterator<T0, T1, T2, T3, T4, T5, T6, T7>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	where T6 : unmanaged
    where T7 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6, T7> GetEnumerator()
	{
		return new ChunkMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed6Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetEnumerator()
	{
		return new ChunkMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed6Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetEnumerator()
	{
		return new ChunkMixed6Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed7Iterator<T0, T1, T2, T3, T4, T5, T6, T7>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	where T7 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed7Enumerator<T0, T1, T2, T3, T4, T5, T6, T7> GetEnumerator()
	{
		return new ChunkMixed7Enumerator<T0, T1, T2, T3, T4, T5, T6, T7>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed7Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	where T7 : unmanaged
    where T8 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed7Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetEnumerator()
	{
		return new ChunkMixed7Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed7Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed7Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetEnumerator()
	{
		return new ChunkMixed7Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed8Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	where T8 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed8Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetEnumerator()
	{
		return new ChunkMixed8Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed8Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	where T8 : unmanaged
    where T9 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed8Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetEnumerator()
	{
		return new ChunkMixed8Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_archetypes, _ids);
	}
}
[SkipLocalsInit]
public ref struct ChunkMixed9Iterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Span<Archetype> archetypes, Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	where T9 : unmanaged
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids = ids;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ChunkMixed9Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetEnumerator()
	{
		return new ChunkMixed9Enumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_archetypes, _ids);
	}
}
