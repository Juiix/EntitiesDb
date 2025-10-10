
using System;

namespace EntitiesDb;

public partial class Archetype
{
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1>(in EntitySlot slot, in Ids<T0, T1> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2>(in EntitySlot slot, in Ids<T0, T1, T2> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3>(in EntitySlot slot, in Ids<T0, T1, T2, T3> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
        chunk.GetBuffer<T10>(slot.Index, ids.T10).Init(t10Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
        chunk.GetBuffer<T10>(slot.Index, ids.T10).Init(t10Components);
        chunk.GetBuffer<T11>(slot.Index, ids.T11).Init(t11Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
        chunk.GetBuffer<T10>(slot.Index, ids.T10).Init(t10Components);
        chunk.GetBuffer<T11>(slot.Index, ids.T11).Init(t11Components);
        chunk.GetBuffer<T12>(slot.Index, ids.T12).Init(t12Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
        chunk.GetBuffer<T10>(slot.Index, ids.T10).Init(t10Components);
        chunk.GetBuffer<T11>(slot.Index, ids.T11).Init(t11Components);
        chunk.GetBuffer<T12>(slot.Index, ids.T12).Init(t12Components);
        chunk.GetBuffer<T13>(slot.Index, ids.T13).Init(t13Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
        chunk.GetBuffer<T10>(slot.Index, ids.T10).Init(t10Components);
        chunk.GetBuffer<T11>(slot.Index, ids.T11).Init(t11Components);
        chunk.GetBuffer<T12>(slot.Index, ids.T12).Init(t12Components);
        chunk.GetBuffer<T13>(slot.Index, ids.T13).Init(t13Components);
        chunk.GetBuffer<T14>(slot.Index, ids.T14).Init(t14Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
        chunk.GetBuffer<T10>(slot.Index, ids.T10).Init(t10Components);
        chunk.GetBuffer<T11>(slot.Index, ids.T11).Init(t11Components);
        chunk.GetBuffer<T12>(slot.Index, ids.T12).Init(t12Components);
        chunk.GetBuffer<T13>(slot.Index, ids.T13).Init(t13Components);
        chunk.GetBuffer<T14>(slot.Index, ids.T14).Init(t14Components);
        chunk.GetBuffer<T15>(slot.Index, ids.T15).Init(t15Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
        chunk.GetBuffer<T10>(slot.Index, ids.T10).Init(t10Components);
        chunk.GetBuffer<T11>(slot.Index, ids.T11).Init(t11Components);
        chunk.GetBuffer<T12>(slot.Index, ids.T12).Init(t12Components);
        chunk.GetBuffer<T13>(slot.Index, ids.T13).Init(t13Components);
        chunk.GetBuffer<T14>(slot.Index, ids.T14).Init(t14Components);
        chunk.GetBuffer<T15>(slot.Index, ids.T15).Init(t15Components);
        chunk.GetBuffer<T16>(slot.Index, ids.T16).Init(t16Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
        chunk.GetBuffer<T10>(slot.Index, ids.T10).Init(t10Components);
        chunk.GetBuffer<T11>(slot.Index, ids.T11).Init(t11Components);
        chunk.GetBuffer<T12>(slot.Index, ids.T12).Init(t12Components);
        chunk.GetBuffer<T13>(slot.Index, ids.T13).Init(t13Components);
        chunk.GetBuffer<T14>(slot.Index, ids.T14).Init(t14Components);
        chunk.GetBuffer<T15>(slot.Index, ids.T15).Init(t15Components);
        chunk.GetBuffer<T16>(slot.Index, ids.T16).Init(t16Components);
        chunk.GetBuffer<T17>(slot.Index, ids.T17).Init(t17Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
        chunk.GetBuffer<T10>(slot.Index, ids.T10).Init(t10Components);
        chunk.GetBuffer<T11>(slot.Index, ids.T11).Init(t11Components);
        chunk.GetBuffer<T12>(slot.Index, ids.T12).Init(t12Components);
        chunk.GetBuffer<T13>(slot.Index, ids.T13).Init(t13Components);
        chunk.GetBuffer<T14>(slot.Index, ids.T14).Init(t14Components);
        chunk.GetBuffer<T15>(slot.Index, ids.T15).Init(t15Components);
        chunk.GetBuffer<T16>(slot.Index, ids.T16).Init(t16Components);
        chunk.GetBuffer<T17>(slot.Index, ids.T17).Init(t17Components);
        chunk.GetBuffer<T18>(slot.Index, ids.T18).Init(t18Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
        chunk.GetBuffer<T10>(slot.Index, ids.T10).Init(t10Components);
        chunk.GetBuffer<T11>(slot.Index, ids.T11).Init(t11Components);
        chunk.GetBuffer<T12>(slot.Index, ids.T12).Init(t12Components);
        chunk.GetBuffer<T13>(slot.Index, ids.T13).Init(t13Components);
        chunk.GetBuffer<T14>(slot.Index, ids.T14).Init(t14Components);
        chunk.GetBuffer<T15>(slot.Index, ids.T15).Init(t15Components);
        chunk.GetBuffer<T16>(slot.Index, ids.T16).Init(t16Components);
        chunk.GetBuffer<T17>(slot.Index, ids.T17).Init(t17Components);
        chunk.GetBuffer<T18>(slot.Index, ids.T18).Init(t18Components);
        chunk.GetBuffer<T19>(slot.Index, ids.T19).Init(t19Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
        chunk.GetBuffer<T10>(slot.Index, ids.T10).Init(t10Components);
        chunk.GetBuffer<T11>(slot.Index, ids.T11).Init(t11Components);
        chunk.GetBuffer<T12>(slot.Index, ids.T12).Init(t12Components);
        chunk.GetBuffer<T13>(slot.Index, ids.T13).Init(t13Components);
        chunk.GetBuffer<T14>(slot.Index, ids.T14).Init(t14Components);
        chunk.GetBuffer<T15>(slot.Index, ids.T15).Init(t15Components);
        chunk.GetBuffer<T16>(slot.Index, ids.T16).Init(t16Components);
        chunk.GetBuffer<T17>(slot.Index, ids.T17).Init(t17Components);
        chunk.GetBuffer<T18>(slot.Index, ids.T18).Init(t18Components);
        chunk.GetBuffer<T19>(slot.Index, ids.T19).Init(t19Components);
        chunk.GetBuffer<T20>(slot.Index, ids.T20).Init(t20Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
        chunk.GetBuffer<T10>(slot.Index, ids.T10).Init(t10Components);
        chunk.GetBuffer<T11>(slot.Index, ids.T11).Init(t11Components);
        chunk.GetBuffer<T12>(slot.Index, ids.T12).Init(t12Components);
        chunk.GetBuffer<T13>(slot.Index, ids.T13).Init(t13Components);
        chunk.GetBuffer<T14>(slot.Index, ids.T14).Init(t14Components);
        chunk.GetBuffer<T15>(slot.Index, ids.T15).Init(t15Components);
        chunk.GetBuffer<T16>(slot.Index, ids.T16).Init(t16Components);
        chunk.GetBuffer<T17>(slot.Index, ids.T17).Init(t17Components);
        chunk.GetBuffer<T18>(slot.Index, ids.T18).Init(t18Components);
        chunk.GetBuffer<T19>(slot.Index, ids.T19).Init(t19Components);
        chunk.GetBuffer<T20>(slot.Index, ids.T20).Init(t20Components);
        chunk.GetBuffer<T21>(slot.Index, ids.T21).Init(t21Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
        chunk.GetBuffer<T10>(slot.Index, ids.T10).Init(t10Components);
        chunk.GetBuffer<T11>(slot.Index, ids.T11).Init(t11Components);
        chunk.GetBuffer<T12>(slot.Index, ids.T12).Init(t12Components);
        chunk.GetBuffer<T13>(slot.Index, ids.T13).Init(t13Components);
        chunk.GetBuffer<T14>(slot.Index, ids.T14).Init(t14Components);
        chunk.GetBuffer<T15>(slot.Index, ids.T15).Init(t15Components);
        chunk.GetBuffer<T16>(slot.Index, ids.T16).Init(t16Components);
        chunk.GetBuffer<T17>(slot.Index, ids.T17).Init(t17Components);
        chunk.GetBuffer<T18>(slot.Index, ids.T18).Init(t18Components);
        chunk.GetBuffer<T19>(slot.Index, ids.T19).Init(t19Components);
        chunk.GetBuffer<T20>(slot.Index, ids.T20).Init(t20Components);
        chunk.GetBuffer<T21>(slot.Index, ids.T21).Init(t21Components);
        chunk.GetBuffer<T22>(slot.Index, ids.T22).Init(t22Components);
	}
	/// <inheritdoc cref="Init{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Init<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
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
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.GetBuffer<T0>(slot.Index, ids.T0).Init(t0Components);
        chunk.GetBuffer<T1>(slot.Index, ids.T1).Init(t1Components);
        chunk.GetBuffer<T2>(slot.Index, ids.T2).Init(t2Components);
        chunk.GetBuffer<T3>(slot.Index, ids.T3).Init(t3Components);
        chunk.GetBuffer<T4>(slot.Index, ids.T4).Init(t4Components);
        chunk.GetBuffer<T5>(slot.Index, ids.T5).Init(t5Components);
        chunk.GetBuffer<T6>(slot.Index, ids.T6).Init(t6Components);
        chunk.GetBuffer<T7>(slot.Index, ids.T7).Init(t7Components);
        chunk.GetBuffer<T8>(slot.Index, ids.T8).Init(t8Components);
        chunk.GetBuffer<T9>(slot.Index, ids.T9).Init(t9Components);
        chunk.GetBuffer<T10>(slot.Index, ids.T10).Init(t10Components);
        chunk.GetBuffer<T11>(slot.Index, ids.T11).Init(t11Components);
        chunk.GetBuffer<T12>(slot.Index, ids.T12).Init(t12Components);
        chunk.GetBuffer<T13>(slot.Index, ids.T13).Init(t13Components);
        chunk.GetBuffer<T14>(slot.Index, ids.T14).Init(t14Components);
        chunk.GetBuffer<T15>(slot.Index, ids.T15).Init(t15Components);
        chunk.GetBuffer<T16>(slot.Index, ids.T16).Init(t16Components);
        chunk.GetBuffer<T17>(slot.Index, ids.T17).Init(t17Components);
        chunk.GetBuffer<T18>(slot.Index, ids.T18).Init(t18Components);
        chunk.GetBuffer<T19>(slot.Index, ids.T19).Init(t19Components);
        chunk.GetBuffer<T20>(slot.Index, ids.T20).Init(t20Components);
        chunk.GetBuffer<T21>(slot.Index, ids.T21).Init(t21Components);
        chunk.GetBuffer<T22>(slot.Index, ids.T22).Init(t22Components);
        chunk.GetBuffer<T23>(slot.Index, ids.T23).Init(t23Components);
	}
}