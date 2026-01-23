
using System;

namespace EntitiesDb;

public partial struct Chunk
{
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0>(int index, in Offsets<T0> offsets, ReadOnlySpan<T0> t0Components = default)
		where T0 : unmanaged
	{
		WriteBuffer(index, offsets.T0).Set(t0Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1>(int index, in Offsets<T0, T1> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2>(int index, in Offsets<T0, T1, T2> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3>(int index, in Offsets<T0, T1, T2, T3> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in Offsets<T0, T1, T2, T3, T4> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in Offsets<T0, T1, T2, T3, T4, T5> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
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
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
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
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
        WriteBuffer(index, offsets.T10).Set(t10Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
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
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
        WriteBuffer(index, offsets.T10).Set(t10Components);
        WriteBuffer(index, offsets.T11).Set(t11Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
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
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
        WriteBuffer(index, offsets.T10).Set(t10Components);
        WriteBuffer(index, offsets.T11).Set(t11Components);
        WriteBuffer(index, offsets.T12).Set(t12Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
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
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
        WriteBuffer(index, offsets.T10).Set(t10Components);
        WriteBuffer(index, offsets.T11).Set(t11Components);
        WriteBuffer(index, offsets.T12).Set(t12Components);
        WriteBuffer(index, offsets.T13).Set(t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
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
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
        WriteBuffer(index, offsets.T10).Set(t10Components);
        WriteBuffer(index, offsets.T11).Set(t11Components);
        WriteBuffer(index, offsets.T12).Set(t12Components);
        WriteBuffer(index, offsets.T13).Set(t13Components);
        WriteBuffer(index, offsets.T14).Set(t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> offsets, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
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
		WriteBuffer(index, offsets.T0).Set(t0Components);
        WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
        WriteBuffer(index, offsets.T10).Set(t10Components);
        WriteBuffer(index, offsets.T11).Set(t11Components);
        WriteBuffer(index, offsets.T12).Set(t12Components);
        WriteBuffer(index, offsets.T13).Set(t13Components);
        WriteBuffer(index, offsets.T14).Set(t14Components);
        WriteBuffer(index, offsets.T15).Set(t15Components);
	}
}