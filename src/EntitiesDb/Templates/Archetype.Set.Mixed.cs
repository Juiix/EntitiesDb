
using System;

namespace EntitiesDb;

public partial class Archetype
{
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1>(in EntitySlot slot, in Ids<T0, T1> ids, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default)
		where T1 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
		chunk.Set(slot.Index, offsets.T1, t1Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2>(in EntitySlot slot, in Ids<T0, T1, T2> ids, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
		chunk.Set(slot.Index, offsets.T1, t1Components);
        chunk.Set(slot.Index, offsets.T2, t2Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3>(in EntitySlot slot, in Ids<T0, T1, T2, T3> ids, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
		chunk.Set(slot.Index, offsets.T1, t1Components);
        chunk.Set(slot.Index, offsets.T2, t2Components);
        chunk.Set(slot.Index, offsets.T3, t3Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4> ids, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
		chunk.Set(slot.Index, offsets.T1, t1Components);
        chunk.Set(slot.Index, offsets.T2, t2Components);
        chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5> ids, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
		chunk.Set(slot.Index, offsets.T1, t1Components);
        chunk.Set(slot.Index, offsets.T2, t2Components);
        chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6> ids, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
		chunk.Set(slot.Index, offsets.T1, t1Components);
        chunk.Set(slot.Index, offsets.T2, t2Components);
        chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
		chunk.Set(slot.Index, offsets.T1, t1Components);
        chunk.Set(slot.Index, offsets.T2, t2Components);
        chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
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
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
		chunk.Set(slot.Index, offsets.T1, t1Components);
        chunk.Set(slot.Index, offsets.T2, t2Components);
        chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
        chunk.Set(slot.Index, offsets.T8, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
		chunk.Set(slot.Index, offsets.T1, t1Components);
        chunk.Set(slot.Index, offsets.T2, t2Components);
        chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
        chunk.Set(slot.Index, offsets.T8, t8Components);
        chunk.Set(slot.Index, offsets.T9, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2>(in EntitySlot slot, in Ids<T0, T1, T2> ids, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default)
		where T2 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
		chunk.Set(slot.Index, offsets.T2, t2Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3>(in EntitySlot slot, in Ids<T0, T1, T2, T3> ids, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
		chunk.Set(slot.Index, offsets.T2, t2Components);
        chunk.Set(slot.Index, offsets.T3, t3Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4> ids, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
		chunk.Set(slot.Index, offsets.T2, t2Components);
        chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5> ids, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
		chunk.Set(slot.Index, offsets.T2, t2Components);
        chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6> ids, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
		chunk.Set(slot.Index, offsets.T2, t2Components);
        chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
		chunk.Set(slot.Index, offsets.T2, t2Components);
        chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
		chunk.Set(slot.Index, offsets.T2, t2Components);
        chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
        chunk.Set(slot.Index, offsets.T8, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
		chunk.Set(slot.Index, offsets.T2, t2Components);
        chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
        chunk.Set(slot.Index, offsets.T8, t8Components);
        chunk.Set(slot.Index, offsets.T9, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3>(in EntitySlot slot, in Ids<T0, T1, T2, T3> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default)
		where T3 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
		chunk.Set(slot.Index, offsets.T3, t3Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
		chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
		chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
		chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
		chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
		chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
        chunk.Set(slot.Index, offsets.T8, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
		chunk.Set(slot.Index, offsets.T3, t3Components);
        chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
        chunk.Set(slot.Index, offsets.T8, t8Components);
        chunk.Set(slot.Index, offsets.T9, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default)
		where T4 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
		chunk.Set(slot.Index, offsets.T4, t4Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
		chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
		chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
		chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
		chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
        chunk.Set(slot.Index, offsets.T8, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
		chunk.Set(slot.Index, offsets.T4, t4Components);
        chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
        chunk.Set(slot.Index, offsets.T8, t8Components);
        chunk.Set(slot.Index, offsets.T9, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default)
		where T5 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
		chunk.Set(slot.Index, offsets.T5, t5Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
		chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
		chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
		chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
        chunk.Set(slot.Index, offsets.T8, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
		chunk.Set(slot.Index, offsets.T5, t5Components);
        chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
        chunk.Set(slot.Index, offsets.T8, t8Components);
        chunk.Set(slot.Index, offsets.T9, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default)
		where T6 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
        chunk.Set(slot.Index, offsets.T5, in t5Component);
		chunk.Set(slot.Index, offsets.T6, t6Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
        chunk.Set(slot.Index, offsets.T5, in t5Component);
		chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
        chunk.Set(slot.Index, offsets.T5, in t5Component);
		chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
        chunk.Set(slot.Index, offsets.T8, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
        chunk.Set(slot.Index, offsets.T5, in t5Component);
		chunk.Set(slot.Index, offsets.T6, t6Components);
        chunk.Set(slot.Index, offsets.T7, t7Components);
        chunk.Set(slot.Index, offsets.T8, t8Components);
        chunk.Set(slot.Index, offsets.T9, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default)
		where T7 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
        chunk.Set(slot.Index, offsets.T5, in t5Component);
        chunk.Set(slot.Index, offsets.T6, in t6Component);
		chunk.Set(slot.Index, offsets.T7, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
        chunk.Set(slot.Index, offsets.T5, in t5Component);
        chunk.Set(slot.Index, offsets.T6, in t6Component);
		chunk.Set(slot.Index, offsets.T7, t7Components);
        chunk.Set(slot.Index, offsets.T8, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
        chunk.Set(slot.Index, offsets.T5, in t5Component);
        chunk.Set(slot.Index, offsets.T6, in t6Component);
		chunk.Set(slot.Index, offsets.T7, t7Components);
        chunk.Set(slot.Index, offsets.T8, t8Components);
        chunk.Set(slot.Index, offsets.T9, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default)
		where T8 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
        chunk.Set(slot.Index, offsets.T5, in t5Component);
        chunk.Set(slot.Index, offsets.T6, in t6Component);
        chunk.Set(slot.Index, offsets.T7, in t7Component);
		chunk.Set(slot.Index, offsets.T8, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
        chunk.Set(slot.Index, offsets.T5, in t5Component);
        chunk.Set(slot.Index, offsets.T6, in t6Component);
        chunk.Set(slot.Index, offsets.T7, in t7Component);
		chunk.Set(slot.Index, offsets.T8, t8Components);
        chunk.Set(slot.Index, offsets.T9, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default)
		where T9 : unmanaged
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, offsets.T0, in t0Component);
        chunk.Set(slot.Index, offsets.T1, in t1Component);
        chunk.Set(slot.Index, offsets.T2, in t2Component);
        chunk.Set(slot.Index, offsets.T3, in t3Component);
        chunk.Set(slot.Index, offsets.T4, in t4Component);
        chunk.Set(slot.Index, offsets.T5, in t5Component);
        chunk.Set(slot.Index, offsets.T6, in t6Component);
        chunk.Set(slot.Index, offsets.T7, in t7Component);
        chunk.Set(slot.Index, offsets.T8, in t8Component);
		chunk.Set(slot.Index, offsets.T9, t9Components);
	}
}