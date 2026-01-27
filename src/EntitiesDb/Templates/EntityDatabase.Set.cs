
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1>(Entity entity, in T0? t0Component, in T1? t1Component)
	{
		_ = ComponentSingleWritable<T0, T1>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component)
	{
		_ = ComponentSingleWritable<T0, T1, T2>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component)
	{
		_ = ComponentSingleWritable<T0, T1, T2, T3>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component)
	{
		_ = ComponentSingleWritable<T0, T1, T2, T3, T4>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component)
	{
		_ = ComponentSingleWritable<T0, T1, T2, T3, T4, T5>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component)
	{
		_ = ComponentSingleWritable<T0, T1, T2, T3, T4, T5, T6>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component)
	{
		_ = ComponentSingleWritable<T0, T1, T2, T3, T4, T5, T6, T7>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component)
	{
		_ = ComponentSingleWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component)
	{
		_ = ComponentSingleWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component)
	{
		_ = ComponentSingleWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component)
	{
		_ = ComponentSingleWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component)
	{
		_ = ComponentSingleWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
        chunk.Write<T12>(entityReference.Slot.Index) = t12Component;
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component)
	{
		_ = ComponentSingleWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
        chunk.Write<T12>(entityReference.Slot.Index) = t12Component;
        chunk.Write<T13>(entityReference.Slot.Index) = t13Component;
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component)
	{
		_ = ComponentSingleWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
        chunk.Write<T12>(entityReference.Slot.Index) = t12Component;
        chunk.Write<T13>(entityReference.Slot.Index) = t13Component;
        chunk.Write<T14>(entityReference.Slot.Index) = t14Component;
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component)
	{
		_ = ComponentSingleWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
        chunk.Write<T12>(entityReference.Slot.Index) = t12Component;
        chunk.Write<T13>(entityReference.Slot.Index) = t13Component;
        chunk.Write<T14>(entityReference.Slot.Index) = t14Component;
        chunk.Write<T15>(entityReference.Slot.Index) = t15Component;
	}
}