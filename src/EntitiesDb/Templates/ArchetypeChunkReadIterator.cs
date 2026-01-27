
using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1, T2>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1, T2> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1, T2, T3>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1, T2, T3> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1, T2, T3, T4>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1, T2, T3, T4> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1, T2, T3, T4, T5>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1, T2, T3, T4, T5> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1, T2, T3, T4, T5, T6>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1, T2, T3, T4, T5, T6> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1, T2, T3, T4, T5, T6, T7>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1, T2, T3, T4, T5, T6, T7> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
[SkipLocalsInit]
public readonly ref struct ArchetypeChunkReadIterator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Span<Archetype> archetypes, ChangeFilter? changeFilter, int? compareVersion)
{
	private readonly Span<Archetype> _archetypes = archetypes;
	private readonly ChangeFilter? _changeFilter = changeFilter;
	private readonly int? _compareVersion = compareVersion;

	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly ArchetypeChunkReadEnumerator<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> GetEnumerator()
	{
		return new(_archetypes, _changeFilter, _compareVersion);
	}
}
