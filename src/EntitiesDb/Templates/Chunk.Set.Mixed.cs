
using System;

namespace EntitiesDb;

public partial struct Chunk
{
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1>(int index, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default)
		where T1 : unmanaged
	{
		Write<T0>(index) = t0Component;
		WriteBuffer<T1>(index).Set(t1Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2>(int index, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		Write<T0>(index) = t0Component;
		WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3>(int index, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		Write<T0>(index) = t0Component;
		WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		Write<T0>(index) = t0Component;
		WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		Write<T0>(index) = t0Component;
		WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		Write<T0>(index) = t0Component;
		WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Write<T0>(index) = t0Component;
		WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Write<T0>(index) = t0Component;
		WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		Write<T0>(index) = t0Component;
		WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
        WriteBuffer<T9>(index).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2>(int index, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default)
		where T2 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
		WriteBuffer<T2>(index).Set(t2Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3>(int index, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
		WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
		WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
		WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
		WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
		WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
		WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
		WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
        WriteBuffer<T9>(index).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default)
		where T3 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
		WriteBuffer<T3>(index).Set(t3Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
		WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
		WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
		WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
		WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
		WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
		WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
        WriteBuffer<T9>(index).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default)
		where T4 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
		WriteBuffer<T4>(index).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
		WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
		WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
		WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
		WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
		WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
        WriteBuffer<T9>(index).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default)
		where T5 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
		WriteBuffer<T5>(index).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
		WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
		WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
		WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
		WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
        WriteBuffer<T9>(index).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default)
		where T6 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
		WriteBuffer<T6>(index).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
		WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
		WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
		WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
        WriteBuffer<T9>(index).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default)
		where T7 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
		WriteBuffer<T7>(index).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
		WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
		WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
        WriteBuffer<T9>(index).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default)
		where T8 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
        Write<T7>(index) = t7Component;
		WriteBuffer<T8>(index).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
        Write<T7>(index) = t7Component;
		WriteBuffer<T8>(index).Set(t8Components);
        WriteBuffer<T9>(index).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default)
		where T9 : unmanaged
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
        Write<T7>(index) = t7Component;
        Write<T8>(index) = t8Component;
		WriteBuffer<T9>(index).Set(t9Components);
	}
}