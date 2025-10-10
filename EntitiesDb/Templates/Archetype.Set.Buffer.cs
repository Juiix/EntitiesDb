
using System;

namespace EntitiesDb;

public partial class Archetype
{
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1>(in EntitySlot slot, in Ids<T0, T1> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2>(in EntitySlot slot, in Ids<T0, T1, T2> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3>(in EntitySlot slot, in Ids<T0, T1, T2, T3> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
        chunk.Set(slot.Index, ids.T10, t10Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
        chunk.Set(slot.Index, ids.T10, t10Components);
        chunk.Set(slot.Index, ids.T11, t11Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
        chunk.Set(slot.Index, ids.T10, t10Components);
        chunk.Set(slot.Index, ids.T11, t11Components);
        chunk.Set(slot.Index, ids.T12, t12Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
        chunk.Set(slot.Index, ids.T10, t10Components);
        chunk.Set(slot.Index, ids.T11, t11Components);
        chunk.Set(slot.Index, ids.T12, t12Components);
        chunk.Set(slot.Index, ids.T13, t13Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
        chunk.Set(slot.Index, ids.T10, t10Components);
        chunk.Set(slot.Index, ids.T11, t11Components);
        chunk.Set(slot.Index, ids.T12, t12Components);
        chunk.Set(slot.Index, ids.T13, t13Components);
        chunk.Set(slot.Index, ids.T14, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
        chunk.Set(slot.Index, ids.T10, t10Components);
        chunk.Set(slot.Index, ids.T11, t11Components);
        chunk.Set(slot.Index, ids.T12, t12Components);
        chunk.Set(slot.Index, ids.T13, t13Components);
        chunk.Set(slot.Index, ids.T14, t14Components);
        chunk.Set(slot.Index, ids.T15, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
        chunk.Set(slot.Index, ids.T10, t10Components);
        chunk.Set(slot.Index, ids.T11, t11Components);
        chunk.Set(slot.Index, ids.T12, t12Components);
        chunk.Set(slot.Index, ids.T13, t13Components);
        chunk.Set(slot.Index, ids.T14, t14Components);
        chunk.Set(slot.Index, ids.T15, t15Components);
        chunk.Set(slot.Index, ids.T16, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
        chunk.Set(slot.Index, ids.T10, t10Components);
        chunk.Set(slot.Index, ids.T11, t11Components);
        chunk.Set(slot.Index, ids.T12, t12Components);
        chunk.Set(slot.Index, ids.T13, t13Components);
        chunk.Set(slot.Index, ids.T14, t14Components);
        chunk.Set(slot.Index, ids.T15, t15Components);
        chunk.Set(slot.Index, ids.T16, t16Components);
        chunk.Set(slot.Index, ids.T17, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
        chunk.Set(slot.Index, ids.T10, t10Components);
        chunk.Set(slot.Index, ids.T11, t11Components);
        chunk.Set(slot.Index, ids.T12, t12Components);
        chunk.Set(slot.Index, ids.T13, t13Components);
        chunk.Set(slot.Index, ids.T14, t14Components);
        chunk.Set(slot.Index, ids.T15, t15Components);
        chunk.Set(slot.Index, ids.T16, t16Components);
        chunk.Set(slot.Index, ids.T17, t17Components);
        chunk.Set(slot.Index, ids.T18, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
        chunk.Set(slot.Index, ids.T10, t10Components);
        chunk.Set(slot.Index, ids.T11, t11Components);
        chunk.Set(slot.Index, ids.T12, t12Components);
        chunk.Set(slot.Index, ids.T13, t13Components);
        chunk.Set(slot.Index, ids.T14, t14Components);
        chunk.Set(slot.Index, ids.T15, t15Components);
        chunk.Set(slot.Index, ids.T16, t16Components);
        chunk.Set(slot.Index, ids.T17, t17Components);
        chunk.Set(slot.Index, ids.T18, t18Components);
        chunk.Set(slot.Index, ids.T19, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
        chunk.Set(slot.Index, ids.T10, t10Components);
        chunk.Set(slot.Index, ids.T11, t11Components);
        chunk.Set(slot.Index, ids.T12, t12Components);
        chunk.Set(slot.Index, ids.T13, t13Components);
        chunk.Set(slot.Index, ids.T14, t14Components);
        chunk.Set(slot.Index, ids.T15, t15Components);
        chunk.Set(slot.Index, ids.T16, t16Components);
        chunk.Set(slot.Index, ids.T17, t17Components);
        chunk.Set(slot.Index, ids.T18, t18Components);
        chunk.Set(slot.Index, ids.T19, t19Components);
        chunk.Set(slot.Index, ids.T20, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
        chunk.Set(slot.Index, ids.T10, t10Components);
        chunk.Set(slot.Index, ids.T11, t11Components);
        chunk.Set(slot.Index, ids.T12, t12Components);
        chunk.Set(slot.Index, ids.T13, t13Components);
        chunk.Set(slot.Index, ids.T14, t14Components);
        chunk.Set(slot.Index, ids.T15, t15Components);
        chunk.Set(slot.Index, ids.T16, t16Components);
        chunk.Set(slot.Index, ids.T17, t17Components);
        chunk.Set(slot.Index, ids.T18, t18Components);
        chunk.Set(slot.Index, ids.T19, t19Components);
        chunk.Set(slot.Index, ids.T20, t20Components);
        chunk.Set(slot.Index, ids.T21, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
        chunk.Set(slot.Index, ids.T10, t10Components);
        chunk.Set(slot.Index, ids.T11, t11Components);
        chunk.Set(slot.Index, ids.T12, t12Components);
        chunk.Set(slot.Index, ids.T13, t13Components);
        chunk.Set(slot.Index, ids.T14, t14Components);
        chunk.Set(slot.Index, ids.T15, t15Components);
        chunk.Set(slot.Index, ids.T16, t16Components);
        chunk.Set(slot.Index, ids.T17, t17Components);
        chunk.Set(slot.Index, ids.T18, t18Components);
        chunk.Set(slot.Index, ids.T19, t19Components);
        chunk.Set(slot.Index, ids.T20, t20Components);
        chunk.Set(slot.Index, ids.T21, t21Components);
        chunk.Set(slot.Index, ids.T22, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, ReadOnlySpan{T0})"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> ids, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
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
		chunk.Set(slot.Index, ids.T0, t0Components);
        chunk.Set(slot.Index, ids.T1, t1Components);
        chunk.Set(slot.Index, ids.T2, t2Components);
        chunk.Set(slot.Index, ids.T3, t3Components);
        chunk.Set(slot.Index, ids.T4, t4Components);
        chunk.Set(slot.Index, ids.T5, t5Components);
        chunk.Set(slot.Index, ids.T6, t6Components);
        chunk.Set(slot.Index, ids.T7, t7Components);
        chunk.Set(slot.Index, ids.T8, t8Components);
        chunk.Set(slot.Index, ids.T9, t9Components);
        chunk.Set(slot.Index, ids.T10, t10Components);
        chunk.Set(slot.Index, ids.T11, t11Components);
        chunk.Set(slot.Index, ids.T12, t12Components);
        chunk.Set(slot.Index, ids.T13, t13Components);
        chunk.Set(slot.Index, ids.T14, t14Components);
        chunk.Set(slot.Index, ids.T15, t15Components);
        chunk.Set(slot.Index, ids.T16, t16Components);
        chunk.Set(slot.Index, ids.T17, t17Components);
        chunk.Set(slot.Index, ids.T18, t18Components);
        chunk.Set(slot.Index, ids.T19, t19Components);
        chunk.Set(slot.Index, ids.T20, t20Components);
        chunk.Set(slot.Index, ids.T21, t21Components);
        chunk.Set(slot.Index, ids.T22, t22Components);
        chunk.Set(slot.Index, ids.T23, t23Components);
	}
}