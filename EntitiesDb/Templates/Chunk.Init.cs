
using System;

namespace EntitiesDb;

public partial struct Chunk
{
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1>(int index, in ComponentIds<T0, T1> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2>(int index, in ComponentIds<T0, T1, T2> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3>(int index, in ComponentIds<T0, T1, T2, T3> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4>(int index, in ComponentIds<T0, T1, T2, T3, T4> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
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
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
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
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
        GetBuffer<T10>(index, ids.T10).Init(ComponentMeta<T10>.InternalCapacity, t10Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
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
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
        GetBuffer<T10>(index, ids.T10).Init(ComponentMeta<T10>.InternalCapacity, t10Components);
        GetBuffer<T11>(index, ids.T11).Init(ComponentMeta<T11>.InternalCapacity, t11Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
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
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
        GetBuffer<T10>(index, ids.T10).Init(ComponentMeta<T10>.InternalCapacity, t10Components);
        GetBuffer<T11>(index, ids.T11).Init(ComponentMeta<T11>.InternalCapacity, t11Components);
        GetBuffer<T12>(index, ids.T12).Init(ComponentMeta<T12>.InternalCapacity, t12Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
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
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
        GetBuffer<T10>(index, ids.T10).Init(ComponentMeta<T10>.InternalCapacity, t10Components);
        GetBuffer<T11>(index, ids.T11).Init(ComponentMeta<T11>.InternalCapacity, t11Components);
        GetBuffer<T12>(index, ids.T12).Init(ComponentMeta<T12>.InternalCapacity, t12Components);
        GetBuffer<T13>(index, ids.T13).Init(ComponentMeta<T13>.InternalCapacity, t13Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
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
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
        GetBuffer<T10>(index, ids.T10).Init(ComponentMeta<T10>.InternalCapacity, t10Components);
        GetBuffer<T11>(index, ids.T11).Init(ComponentMeta<T11>.InternalCapacity, t11Components);
        GetBuffer<T12>(index, ids.T12).Init(ComponentMeta<T12>.InternalCapacity, t12Components);
        GetBuffer<T13>(index, ids.T13).Init(ComponentMeta<T13>.InternalCapacity, t13Components);
        GetBuffer<T14>(index, ids.T14).Init(ComponentMeta<T14>.InternalCapacity, t14Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
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
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
        GetBuffer<T10>(index, ids.T10).Init(ComponentMeta<T10>.InternalCapacity, t10Components);
        GetBuffer<T11>(index, ids.T11).Init(ComponentMeta<T11>.InternalCapacity, t11Components);
        GetBuffer<T12>(index, ids.T12).Init(ComponentMeta<T12>.InternalCapacity, t12Components);
        GetBuffer<T13>(index, ids.T13).Init(ComponentMeta<T13>.InternalCapacity, t13Components);
        GetBuffer<T14>(index, ids.T14).Init(ComponentMeta<T14>.InternalCapacity, t14Components);
        GetBuffer<T15>(index, ids.T15).Init(ComponentMeta<T15>.InternalCapacity, t15Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
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
        where T16 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
        GetBuffer<T10>(index, ids.T10).Init(ComponentMeta<T10>.InternalCapacity, t10Components);
        GetBuffer<T11>(index, ids.T11).Init(ComponentMeta<T11>.InternalCapacity, t11Components);
        GetBuffer<T12>(index, ids.T12).Init(ComponentMeta<T12>.InternalCapacity, t12Components);
        GetBuffer<T13>(index, ids.T13).Init(ComponentMeta<T13>.InternalCapacity, t13Components);
        GetBuffer<T14>(index, ids.T14).Init(ComponentMeta<T14>.InternalCapacity, t14Components);
        GetBuffer<T15>(index, ids.T15).Init(ComponentMeta<T15>.InternalCapacity, t15Components);
        GetBuffer<T16>(index, ids.T16).Init(ComponentMeta<T16>.InternalCapacity, t16Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
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
        where T16 : unmanaged
        where T17 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
        GetBuffer<T10>(index, ids.T10).Init(ComponentMeta<T10>.InternalCapacity, t10Components);
        GetBuffer<T11>(index, ids.T11).Init(ComponentMeta<T11>.InternalCapacity, t11Components);
        GetBuffer<T12>(index, ids.T12).Init(ComponentMeta<T12>.InternalCapacity, t12Components);
        GetBuffer<T13>(index, ids.T13).Init(ComponentMeta<T13>.InternalCapacity, t13Components);
        GetBuffer<T14>(index, ids.T14).Init(ComponentMeta<T14>.InternalCapacity, t14Components);
        GetBuffer<T15>(index, ids.T15).Init(ComponentMeta<T15>.InternalCapacity, t15Components);
        GetBuffer<T16>(index, ids.T16).Init(ComponentMeta<T16>.InternalCapacity, t16Components);
        GetBuffer<T17>(index, ids.T17).Init(ComponentMeta<T17>.InternalCapacity, t17Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
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
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
        GetBuffer<T10>(index, ids.T10).Init(ComponentMeta<T10>.InternalCapacity, t10Components);
        GetBuffer<T11>(index, ids.T11).Init(ComponentMeta<T11>.InternalCapacity, t11Components);
        GetBuffer<T12>(index, ids.T12).Init(ComponentMeta<T12>.InternalCapacity, t12Components);
        GetBuffer<T13>(index, ids.T13).Init(ComponentMeta<T13>.InternalCapacity, t13Components);
        GetBuffer<T14>(index, ids.T14).Init(ComponentMeta<T14>.InternalCapacity, t14Components);
        GetBuffer<T15>(index, ids.T15).Init(ComponentMeta<T15>.InternalCapacity, t15Components);
        GetBuffer<T16>(index, ids.T16).Init(ComponentMeta<T16>.InternalCapacity, t16Components);
        GetBuffer<T17>(index, ids.T17).Init(ComponentMeta<T17>.InternalCapacity, t17Components);
        GetBuffer<T18>(index, ids.T18).Init(ComponentMeta<T18>.InternalCapacity, t18Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
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
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
        GetBuffer<T10>(index, ids.T10).Init(ComponentMeta<T10>.InternalCapacity, t10Components);
        GetBuffer<T11>(index, ids.T11).Init(ComponentMeta<T11>.InternalCapacity, t11Components);
        GetBuffer<T12>(index, ids.T12).Init(ComponentMeta<T12>.InternalCapacity, t12Components);
        GetBuffer<T13>(index, ids.T13).Init(ComponentMeta<T13>.InternalCapacity, t13Components);
        GetBuffer<T14>(index, ids.T14).Init(ComponentMeta<T14>.InternalCapacity, t14Components);
        GetBuffer<T15>(index, ids.T15).Init(ComponentMeta<T15>.InternalCapacity, t15Components);
        GetBuffer<T16>(index, ids.T16).Init(ComponentMeta<T16>.InternalCapacity, t16Components);
        GetBuffer<T17>(index, ids.T17).Init(ComponentMeta<T17>.InternalCapacity, t17Components);
        GetBuffer<T18>(index, ids.T18).Init(ComponentMeta<T18>.InternalCapacity, t18Components);
        GetBuffer<T19>(index, ids.T19).Init(ComponentMeta<T19>.InternalCapacity, t19Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
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
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
        GetBuffer<T10>(index, ids.T10).Init(ComponentMeta<T10>.InternalCapacity, t10Components);
        GetBuffer<T11>(index, ids.T11).Init(ComponentMeta<T11>.InternalCapacity, t11Components);
        GetBuffer<T12>(index, ids.T12).Init(ComponentMeta<T12>.InternalCapacity, t12Components);
        GetBuffer<T13>(index, ids.T13).Init(ComponentMeta<T13>.InternalCapacity, t13Components);
        GetBuffer<T14>(index, ids.T14).Init(ComponentMeta<T14>.InternalCapacity, t14Components);
        GetBuffer<T15>(index, ids.T15).Init(ComponentMeta<T15>.InternalCapacity, t15Components);
        GetBuffer<T16>(index, ids.T16).Init(ComponentMeta<T16>.InternalCapacity, t16Components);
        GetBuffer<T17>(index, ids.T17).Init(ComponentMeta<T17>.InternalCapacity, t17Components);
        GetBuffer<T18>(index, ids.T18).Init(ComponentMeta<T18>.InternalCapacity, t18Components);
        GetBuffer<T19>(index, ids.T19).Init(ComponentMeta<T19>.InternalCapacity, t19Components);
        GetBuffer<T20>(index, ids.T20).Init(ComponentMeta<T20>.InternalCapacity, t20Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
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
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
        GetBuffer<T10>(index, ids.T10).Init(ComponentMeta<T10>.InternalCapacity, t10Components);
        GetBuffer<T11>(index, ids.T11).Init(ComponentMeta<T11>.InternalCapacity, t11Components);
        GetBuffer<T12>(index, ids.T12).Init(ComponentMeta<T12>.InternalCapacity, t12Components);
        GetBuffer<T13>(index, ids.T13).Init(ComponentMeta<T13>.InternalCapacity, t13Components);
        GetBuffer<T14>(index, ids.T14).Init(ComponentMeta<T14>.InternalCapacity, t14Components);
        GetBuffer<T15>(index, ids.T15).Init(ComponentMeta<T15>.InternalCapacity, t15Components);
        GetBuffer<T16>(index, ids.T16).Init(ComponentMeta<T16>.InternalCapacity, t16Components);
        GetBuffer<T17>(index, ids.T17).Init(ComponentMeta<T17>.InternalCapacity, t17Components);
        GetBuffer<T18>(index, ids.T18).Init(ComponentMeta<T18>.InternalCapacity, t18Components);
        GetBuffer<T19>(index, ids.T19).Init(ComponentMeta<T19>.InternalCapacity, t19Components);
        GetBuffer<T20>(index, ids.T20).Init(ComponentMeta<T20>.InternalCapacity, t20Components);
        GetBuffer<T21>(index, ids.T21).Init(ComponentMeta<T21>.InternalCapacity, t21Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
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
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
        GetBuffer<T10>(index, ids.T10).Init(ComponentMeta<T10>.InternalCapacity, t10Components);
        GetBuffer<T11>(index, ids.T11).Init(ComponentMeta<T11>.InternalCapacity, t11Components);
        GetBuffer<T12>(index, ids.T12).Init(ComponentMeta<T12>.InternalCapacity, t12Components);
        GetBuffer<T13>(index, ids.T13).Init(ComponentMeta<T13>.InternalCapacity, t13Components);
        GetBuffer<T14>(index, ids.T14).Init(ComponentMeta<T14>.InternalCapacity, t14Components);
        GetBuffer<T15>(index, ids.T15).Init(ComponentMeta<T15>.InternalCapacity, t15Components);
        GetBuffer<T16>(index, ids.T16).Init(ComponentMeta<T16>.InternalCapacity, t16Components);
        GetBuffer<T17>(index, ids.T17).Init(ComponentMeta<T17>.InternalCapacity, t17Components);
        GetBuffer<T18>(index, ids.T18).Init(ComponentMeta<T18>.InternalCapacity, t18Components);
        GetBuffer<T19>(index, ids.T19).Init(ComponentMeta<T19>.InternalCapacity, t19Components);
        GetBuffer<T20>(index, ids.T20).Init(ComponentMeta<T20>.InternalCapacity, t20Components);
        GetBuffer<T21>(index, ids.T21).Init(ComponentMeta<T21>.InternalCapacity, t21Components);
        GetBuffer<T22>(index, ids.T22).Init(ComponentMeta<T22>.InternalCapacity, t22Components);
	}
	/// <inheritdoc cref="Init{T0}(int, in ComponentIds{T0}, ReadOnlySpan{T0})"/>
	internal readonly void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int index, in ComponentIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
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
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		GetBuffer<T0>(index, ids.T0).Init(ComponentMeta<T0>.InternalCapacity, t0Components);
        GetBuffer<T1>(index, ids.T1).Init(ComponentMeta<T1>.InternalCapacity, t1Components);
        GetBuffer<T2>(index, ids.T2).Init(ComponentMeta<T2>.InternalCapacity, t2Components);
        GetBuffer<T3>(index, ids.T3).Init(ComponentMeta<T3>.InternalCapacity, t3Components);
        GetBuffer<T4>(index, ids.T4).Init(ComponentMeta<T4>.InternalCapacity, t4Components);
        GetBuffer<T5>(index, ids.T5).Init(ComponentMeta<T5>.InternalCapacity, t5Components);
        GetBuffer<T6>(index, ids.T6).Init(ComponentMeta<T6>.InternalCapacity, t6Components);
        GetBuffer<T7>(index, ids.T7).Init(ComponentMeta<T7>.InternalCapacity, t7Components);
        GetBuffer<T8>(index, ids.T8).Init(ComponentMeta<T8>.InternalCapacity, t8Components);
        GetBuffer<T9>(index, ids.T9).Init(ComponentMeta<T9>.InternalCapacity, t9Components);
        GetBuffer<T10>(index, ids.T10).Init(ComponentMeta<T10>.InternalCapacity, t10Components);
        GetBuffer<T11>(index, ids.T11).Init(ComponentMeta<T11>.InternalCapacity, t11Components);
        GetBuffer<T12>(index, ids.T12).Init(ComponentMeta<T12>.InternalCapacity, t12Components);
        GetBuffer<T13>(index, ids.T13).Init(ComponentMeta<T13>.InternalCapacity, t13Components);
        GetBuffer<T14>(index, ids.T14).Init(ComponentMeta<T14>.InternalCapacity, t14Components);
        GetBuffer<T15>(index, ids.T15).Init(ComponentMeta<T15>.InternalCapacity, t15Components);
        GetBuffer<T16>(index, ids.T16).Init(ComponentMeta<T16>.InternalCapacity, t16Components);
        GetBuffer<T17>(index, ids.T17).Init(ComponentMeta<T17>.InternalCapacity, t17Components);
        GetBuffer<T18>(index, ids.T18).Init(ComponentMeta<T18>.InternalCapacity, t18Components);
        GetBuffer<T19>(index, ids.T19).Init(ComponentMeta<T19>.InternalCapacity, t19Components);
        GetBuffer<T20>(index, ids.T20).Init(ComponentMeta<T20>.InternalCapacity, t20Components);
        GetBuffer<T21>(index, ids.T21).Init(ComponentMeta<T21>.InternalCapacity, t21Components);
        GetBuffer<T22>(index, ids.T22).Init(ComponentMeta<T22>.InternalCapacity, t22Components);
        GetBuffer<T23>(index, ids.T23).Init(ComponentMeta<T23>.InternalCapacity, t23Components);
	}
}