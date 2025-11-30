
namespace EntitiesDb;

public partial class Archetype
{
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1>(in EntitySlot slot, in Ids<T0, T1> ids, in T0? t0Component = default, in T1? t1Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2>(in EntitySlot slot, in Ids<T0, T1, T2> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component, in t2Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3>(in EntitySlot slot, in Ids<T0, T1, T2, T3> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component, in t2Component, in t3Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		chunk.Set(slot.Index, in offsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);
	}
}