using System;

namespace EntitiesDb;

public partial struct Chunk
{
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1>(int index,in ComponentIds<T0,T1> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2>(int index,in ComponentIds<T0,T1,T2> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3>(int index,in ComponentIds<T0,T1,T2,T3> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4>(int index,in ComponentIds<T0,T1,T2,T3,T4> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
        GetBufferById<T10>(index, ids.T10).Set(t10Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
        GetBufferById<T10>(index, ids.T10).Set(t10Components);
        GetBufferById<T11>(index, ids.T11).Set(t11Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
        GetBufferById<T10>(index, ids.T10).Set(t10Components);
        GetBufferById<T11>(index, ids.T11).Set(t11Components);
        GetBufferById<T12>(index, ids.T12).Set(t12Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
        GetBufferById<T10>(index, ids.T10).Set(t10Components);
        GetBufferById<T11>(index, ids.T11).Set(t11Components);
        GetBufferById<T12>(index, ids.T12).Set(t12Components);
        GetBufferById<T13>(index, ids.T13).Set(t13Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
        GetBufferById<T10>(index, ids.T10).Set(t10Components);
        GetBufferById<T11>(index, ids.T11).Set(t11Components);
        GetBufferById<T12>(index, ids.T12).Set(t12Components);
        GetBufferById<T13>(index, ids.T13).Set(t13Components);
        GetBufferById<T14>(index, ids.T14).Set(t14Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
        GetBufferById<T10>(index, ids.T10).Set(t10Components);
        GetBufferById<T11>(index, ids.T11).Set(t11Components);
        GetBufferById<T12>(index, ids.T12).Set(t12Components);
        GetBufferById<T13>(index, ids.T13).Set(t13Components);
        GetBufferById<T14>(index, ids.T14).Set(t14Components);
        GetBufferById<T15>(index, ids.T15).Set(t15Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
        GetBufferById<T10>(index, ids.T10).Set(t10Components);
        GetBufferById<T11>(index, ids.T11).Set(t11Components);
        GetBufferById<T12>(index, ids.T12).Set(t12Components);
        GetBufferById<T13>(index, ids.T13).Set(t13Components);
        GetBufferById<T14>(index, ids.T14).Set(t14Components);
        GetBufferById<T15>(index, ids.T15).Set(t15Components);
        GetBufferById<T16>(index, ids.T16).Set(t16Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
        GetBufferById<T10>(index, ids.T10).Set(t10Components);
        GetBufferById<T11>(index, ids.T11).Set(t11Components);
        GetBufferById<T12>(index, ids.T12).Set(t12Components);
        GetBufferById<T13>(index, ids.T13).Set(t13Components);
        GetBufferById<T14>(index, ids.T14).Set(t14Components);
        GetBufferById<T15>(index, ids.T15).Set(t15Components);
        GetBufferById<T16>(index, ids.T16).Set(t16Components);
        GetBufferById<T17>(index, ids.T17).Set(t17Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
        GetBufferById<T10>(index, ids.T10).Set(t10Components);
        GetBufferById<T11>(index, ids.T11).Set(t11Components);
        GetBufferById<T12>(index, ids.T12).Set(t12Components);
        GetBufferById<T13>(index, ids.T13).Set(t13Components);
        GetBufferById<T14>(index, ids.T14).Set(t14Components);
        GetBufferById<T15>(index, ids.T15).Set(t15Components);
        GetBufferById<T16>(index, ids.T16).Set(t16Components);
        GetBufferById<T17>(index, ids.T17).Set(t17Components);
        GetBufferById<T18>(index, ids.T18).Set(t18Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
        GetBufferById<T10>(index, ids.T10).Set(t10Components);
        GetBufferById<T11>(index, ids.T11).Set(t11Components);
        GetBufferById<T12>(index, ids.T12).Set(t12Components);
        GetBufferById<T13>(index, ids.T13).Set(t13Components);
        GetBufferById<T14>(index, ids.T14).Set(t14Components);
        GetBufferById<T15>(index, ids.T15).Set(t15Components);
        GetBufferById<T16>(index, ids.T16).Set(t16Components);
        GetBufferById<T17>(index, ids.T17).Set(t17Components);
        GetBufferById<T18>(index, ids.T18).Set(t18Components);
        GetBufferById<T19>(index, ids.T19).Set(t19Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
        GetBufferById<T10>(index, ids.T10).Set(t10Components);
        GetBufferById<T11>(index, ids.T11).Set(t11Components);
        GetBufferById<T12>(index, ids.T12).Set(t12Components);
        GetBufferById<T13>(index, ids.T13).Set(t13Components);
        GetBufferById<T14>(index, ids.T14).Set(t14Components);
        GetBufferById<T15>(index, ids.T15).Set(t15Components);
        GetBufferById<T16>(index, ids.T16).Set(t16Components);
        GetBufferById<T17>(index, ids.T17).Set(t17Components);
        GetBufferById<T18>(index, ids.T18).Set(t18Components);
        GetBufferById<T19>(index, ids.T19).Set(t19Components);
        GetBufferById<T20>(index, ids.T20).Set(t20Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
        GetBufferById<T10>(index, ids.T10).Set(t10Components);
        GetBufferById<T11>(index, ids.T11).Set(t11Components);
        GetBufferById<T12>(index, ids.T12).Set(t12Components);
        GetBufferById<T13>(index, ids.T13).Set(t13Components);
        GetBufferById<T14>(index, ids.T14).Set(t14Components);
        GetBufferById<T15>(index, ids.T15).Set(t15Components);
        GetBufferById<T16>(index, ids.T16).Set(t16Components);
        GetBufferById<T17>(index, ids.T17).Set(t17Components);
        GetBufferById<T18>(index, ids.T18).Set(t18Components);
        GetBufferById<T19>(index, ids.T19).Set(t19Components);
        GetBufferById<T20>(index, ids.T20).Set(t20Components);
        GetBufferById<T21>(index, ids.T21).Set(t21Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
        GetBufferById<T10>(index, ids.T10).Set(t10Components);
        GetBufferById<T11>(index, ids.T11).Set(t11Components);
        GetBufferById<T12>(index, ids.T12).Set(t12Components);
        GetBufferById<T13>(index, ids.T13).Set(t13Components);
        GetBufferById<T14>(index, ids.T14).Set(t14Components);
        GetBufferById<T15>(index, ids.T15).Set(t15Components);
        GetBufferById<T16>(index, ids.T16).Set(t16Components);
        GetBufferById<T17>(index, ids.T17).Set(t17Components);
        GetBufferById<T18>(index, ids.T18).Set(t18Components);
        GetBufferById<T19>(index, ids.T19).Set(t19Components);
        GetBufferById<T20>(index, ids.T20).Set(t20Components);
        GetBufferById<T21>(index, ids.T21).Set(t21Components);
        GetBufferById<T22>(index, ids.T22).Set(t22Components);
	}
	/// <inheritdoc cref="Set{T}(int, in ComponentIds{T}, in T)"/>
	public void Set<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int index,in ComponentIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23> ids,ReadOnlySpan<T0> t0Components = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		GetBufferById<T0>(index, ids.T0).Set(t0Components);
        GetBufferById<T1>(index, ids.T1).Set(t1Components);
        GetBufferById<T2>(index, ids.T2).Set(t2Components);
        GetBufferById<T3>(index, ids.T3).Set(t3Components);
        GetBufferById<T4>(index, ids.T4).Set(t4Components);
        GetBufferById<T5>(index, ids.T5).Set(t5Components);
        GetBufferById<T6>(index, ids.T6).Set(t6Components);
        GetBufferById<T7>(index, ids.T7).Set(t7Components);
        GetBufferById<T8>(index, ids.T8).Set(t8Components);
        GetBufferById<T9>(index, ids.T9).Set(t9Components);
        GetBufferById<T10>(index, ids.T10).Set(t10Components);
        GetBufferById<T11>(index, ids.T11).Set(t11Components);
        GetBufferById<T12>(index, ids.T12).Set(t12Components);
        GetBufferById<T13>(index, ids.T13).Set(t13Components);
        GetBufferById<T14>(index, ids.T14).Set(t14Components);
        GetBufferById<T15>(index, ids.T15).Set(t15Components);
        GetBufferById<T16>(index, ids.T16).Set(t16Components);
        GetBufferById<T17>(index, ids.T17).Set(t17Components);
        GetBufferById<T18>(index, ids.T18).Set(t18Components);
        GetBufferById<T19>(index, ids.T19).Set(t19Components);
        GetBufferById<T20>(index, ids.T20).Set(t20Components);
        GetBufferById<T21>(index, ids.T21).Set(t21Components);
        GetBufferById<T22>(index, ids.T22).Set(t22Components);
        GetBufferById<T23>(index, ids.T23).Set(t23Components);
	}
}