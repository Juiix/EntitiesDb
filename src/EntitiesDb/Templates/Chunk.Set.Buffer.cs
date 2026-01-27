
using System;

namespace EntitiesDb;

public partial struct Chunk
{
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		WriteBuffer<T0>(index).Set(t0Components);
        WriteBuffer<T1>(index).Set(t1Components);
	}
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		WriteBuffer<T0>(index).Set(t0Components);
        WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
	}
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		WriteBuffer<T0>(index).Set(t0Components);
        WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
	}
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		WriteBuffer<T0>(index).Set(t0Components);
        WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		WriteBuffer<T0>(index).Set(t0Components);
        WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		WriteBuffer<T0>(index).Set(t0Components);
        WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		WriteBuffer<T0>(index).Set(t0Components);
        WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
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
		WriteBuffer<T0>(index).Set(t0Components);
        WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		WriteBuffer<T0>(index).Set(t0Components);
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
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
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
		WriteBuffer<T0>(index).Set(t0Components);
        WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
        WriteBuffer<T9>(index).Set(t9Components);
        WriteBuffer<T10>(index).Set(t10Components);
	}
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
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
		WriteBuffer<T0>(index).Set(t0Components);
        WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
        WriteBuffer<T9>(index).Set(t9Components);
        WriteBuffer<T10>(index).Set(t10Components);
        WriteBuffer<T11>(index).Set(t11Components);
	}
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
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
		WriteBuffer<T0>(index).Set(t0Components);
        WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
        WriteBuffer<T9>(index).Set(t9Components);
        WriteBuffer<T10>(index).Set(t10Components);
        WriteBuffer<T11>(index).Set(t11Components);
        WriteBuffer<T12>(index).Set(t12Components);
	}
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
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
		WriteBuffer<T0>(index).Set(t0Components);
        WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
        WriteBuffer<T9>(index).Set(t9Components);
        WriteBuffer<T10>(index).Set(t10Components);
        WriteBuffer<T11>(index).Set(t11Components);
        WriteBuffer<T12>(index).Set(t12Components);
        WriteBuffer<T13>(index).Set(t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
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
		WriteBuffer<T0>(index).Set(t0Components);
        WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
        WriteBuffer<T9>(index).Set(t9Components);
        WriteBuffer<T10>(index).Set(t10Components);
        WriteBuffer<T11>(index).Set(t11Components);
        WriteBuffer<T12>(index).Set(t12Components);
        WriteBuffer<T13>(index).Set(t13Components);
        WriteBuffer<T14>(index).Set(t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int index, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
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
		WriteBuffer<T0>(index).Set(t0Components);
        WriteBuffer<T1>(index).Set(t1Components);
        WriteBuffer<T2>(index).Set(t2Components);
        WriteBuffer<T3>(index).Set(t3Components);
        WriteBuffer<T4>(index).Set(t4Components);
        WriteBuffer<T5>(index).Set(t5Components);
        WriteBuffer<T6>(index).Set(t6Components);
        WriteBuffer<T7>(index).Set(t7Components);
        WriteBuffer<T8>(index).Set(t8Components);
        WriteBuffer<T9>(index).Set(t9Components);
        WriteBuffer<T10>(index).Set(t10Components);
        WriteBuffer<T11>(index).Set(t11Components);
        WriteBuffer<T12>(index).Set(t12Components);
        WriteBuffer<T13>(index).Set(t13Components);
        WriteBuffer<T14>(index).Set(t14Components);
        WriteBuffer<T15>(index).Set(t15Components);
	}
}