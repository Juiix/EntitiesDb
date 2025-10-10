
namespace EntitiesDb;

public partial class Archetype
{
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1>(in EntitySlot slot, in Ids<T0, T1> ids, in T0? t0Component = default, in T1? t1Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2>(in EntitySlot slot, in Ids<T0, T1, T2> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3>(in EntitySlot slot, in Ids<T0, T1, T2, T3> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
        chunk.Set(slot.Index, ids.T10, in t10Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
        chunk.Set(slot.Index, ids.T10, in t10Component);
        chunk.Set(slot.Index, ids.T11, in t11Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
        chunk.Set(slot.Index, ids.T10, in t10Component);
        chunk.Set(slot.Index, ids.T11, in t11Component);
        chunk.Set(slot.Index, ids.T12, in t12Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
        chunk.Set(slot.Index, ids.T10, in t10Component);
        chunk.Set(slot.Index, ids.T11, in t11Component);
        chunk.Set(slot.Index, ids.T12, in t12Component);
        chunk.Set(slot.Index, ids.T13, in t13Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
        chunk.Set(slot.Index, ids.T10, in t10Component);
        chunk.Set(slot.Index, ids.T11, in t11Component);
        chunk.Set(slot.Index, ids.T12, in t12Component);
        chunk.Set(slot.Index, ids.T13, in t13Component);
        chunk.Set(slot.Index, ids.T14, in t14Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
        chunk.Set(slot.Index, ids.T10, in t10Component);
        chunk.Set(slot.Index, ids.T11, in t11Component);
        chunk.Set(slot.Index, ids.T12, in t12Component);
        chunk.Set(slot.Index, ids.T13, in t13Component);
        chunk.Set(slot.Index, ids.T14, in t14Component);
        chunk.Set(slot.Index, ids.T15, in t15Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
        chunk.Set(slot.Index, ids.T10, in t10Component);
        chunk.Set(slot.Index, ids.T11, in t11Component);
        chunk.Set(slot.Index, ids.T12, in t12Component);
        chunk.Set(slot.Index, ids.T13, in t13Component);
        chunk.Set(slot.Index, ids.T14, in t14Component);
        chunk.Set(slot.Index, ids.T15, in t15Component);
        chunk.Set(slot.Index, ids.T16, in t16Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
        chunk.Set(slot.Index, ids.T10, in t10Component);
        chunk.Set(slot.Index, ids.T11, in t11Component);
        chunk.Set(slot.Index, ids.T12, in t12Component);
        chunk.Set(slot.Index, ids.T13, in t13Component);
        chunk.Set(slot.Index, ids.T14, in t14Component);
        chunk.Set(slot.Index, ids.T15, in t15Component);
        chunk.Set(slot.Index, ids.T16, in t16Component);
        chunk.Set(slot.Index, ids.T17, in t17Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
        chunk.Set(slot.Index, ids.T10, in t10Component);
        chunk.Set(slot.Index, ids.T11, in t11Component);
        chunk.Set(slot.Index, ids.T12, in t12Component);
        chunk.Set(slot.Index, ids.T13, in t13Component);
        chunk.Set(slot.Index, ids.T14, in t14Component);
        chunk.Set(slot.Index, ids.T15, in t15Component);
        chunk.Set(slot.Index, ids.T16, in t16Component);
        chunk.Set(slot.Index, ids.T17, in t17Component);
        chunk.Set(slot.Index, ids.T18, in t18Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
        chunk.Set(slot.Index, ids.T10, in t10Component);
        chunk.Set(slot.Index, ids.T11, in t11Component);
        chunk.Set(slot.Index, ids.T12, in t12Component);
        chunk.Set(slot.Index, ids.T13, in t13Component);
        chunk.Set(slot.Index, ids.T14, in t14Component);
        chunk.Set(slot.Index, ids.T15, in t15Component);
        chunk.Set(slot.Index, ids.T16, in t16Component);
        chunk.Set(slot.Index, ids.T17, in t17Component);
        chunk.Set(slot.Index, ids.T18, in t18Component);
        chunk.Set(slot.Index, ids.T19, in t19Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
        chunk.Set(slot.Index, ids.T10, in t10Component);
        chunk.Set(slot.Index, ids.T11, in t11Component);
        chunk.Set(slot.Index, ids.T12, in t12Component);
        chunk.Set(slot.Index, ids.T13, in t13Component);
        chunk.Set(slot.Index, ids.T14, in t14Component);
        chunk.Set(slot.Index, ids.T15, in t15Component);
        chunk.Set(slot.Index, ids.T16, in t16Component);
        chunk.Set(slot.Index, ids.T17, in t17Component);
        chunk.Set(slot.Index, ids.T18, in t18Component);
        chunk.Set(slot.Index, ids.T19, in t19Component);
        chunk.Set(slot.Index, ids.T20, in t20Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
        chunk.Set(slot.Index, ids.T10, in t10Component);
        chunk.Set(slot.Index, ids.T11, in t11Component);
        chunk.Set(slot.Index, ids.T12, in t12Component);
        chunk.Set(slot.Index, ids.T13, in t13Component);
        chunk.Set(slot.Index, ids.T14, in t14Component);
        chunk.Set(slot.Index, ids.T15, in t15Component);
        chunk.Set(slot.Index, ids.T16, in t16Component);
        chunk.Set(slot.Index, ids.T17, in t17Component);
        chunk.Set(slot.Index, ids.T18, in t18Component);
        chunk.Set(slot.Index, ids.T19, in t19Component);
        chunk.Set(slot.Index, ids.T20, in t20Component);
        chunk.Set(slot.Index, ids.T21, in t21Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default, in T22? t22Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
        chunk.Set(slot.Index, ids.T10, in t10Component);
        chunk.Set(slot.Index, ids.T11, in t11Component);
        chunk.Set(slot.Index, ids.T12, in t12Component);
        chunk.Set(slot.Index, ids.T13, in t13Component);
        chunk.Set(slot.Index, ids.T14, in t14Component);
        chunk.Set(slot.Index, ids.T15, in t15Component);
        chunk.Set(slot.Index, ids.T16, in t16Component);
        chunk.Set(slot.Index, ids.T17, in t17Component);
        chunk.Set(slot.Index, ids.T18, in t18Component);
        chunk.Set(slot.Index, ids.T19, in t19Component);
        chunk.Set(slot.Index, ids.T20, in t20Component);
        chunk.Set(slot.Index, ids.T21, in t21Component);
        chunk.Set(slot.Index, ids.T22, in t22Component);
	}
	/// <inheritdoc cref="Set{T0}(in EntitySlot, in Ids{T0}, in T0?)"/>
	internal void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default, in T22? t22Component = default, in T23? t23Component = default)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		chunk.Set(slot.Index, ids.T0, in t0Component);
        chunk.Set(slot.Index, ids.T1, in t1Component);
        chunk.Set(slot.Index, ids.T2, in t2Component);
        chunk.Set(slot.Index, ids.T3, in t3Component);
        chunk.Set(slot.Index, ids.T4, in t4Component);
        chunk.Set(slot.Index, ids.T5, in t5Component);
        chunk.Set(slot.Index, ids.T6, in t6Component);
        chunk.Set(slot.Index, ids.T7, in t7Component);
        chunk.Set(slot.Index, ids.T8, in t8Component);
        chunk.Set(slot.Index, ids.T9, in t9Component);
        chunk.Set(slot.Index, ids.T10, in t10Component);
        chunk.Set(slot.Index, ids.T11, in t11Component);
        chunk.Set(slot.Index, ids.T12, in t12Component);
        chunk.Set(slot.Index, ids.T13, in t13Component);
        chunk.Set(slot.Index, ids.T14, in t14Component);
        chunk.Set(slot.Index, ids.T15, in t15Component);
        chunk.Set(slot.Index, ids.T16, in t16Component);
        chunk.Set(slot.Index, ids.T17, in t17Component);
        chunk.Set(slot.Index, ids.T18, in t18Component);
        chunk.Set(slot.Index, ids.T19, in t19Component);
        chunk.Set(slot.Index, ids.T20, in t20Component);
        chunk.Set(slot.Index, ids.T21, in t21Component);
        chunk.Set(slot.Index, ids.T22, in t22Component);
        chunk.Set(slot.Index, ids.T23, in t23Component);
	}
}