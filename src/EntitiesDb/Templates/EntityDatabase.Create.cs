
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1>(in T0? t0Component = default, in T1? t1Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
		return entity;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1, T2>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(index) = t2Component;
		return entity;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1, T2, T3>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(index) = t3Component;
		return entity;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1, T2, T3, T4>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(index) = t4Component;
		return entity;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(index) = t5Component;
		return entity;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(index) = t6Component;
		return entity;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(index) = t7Component;
		return entity;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(index) = t8Component;
		return entity;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(index) = t9Component;
		return entity;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(index) = t10Component;
		return entity;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(index) = t11Component;
		return entity;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(index) = t12Component;
		return entity;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(index) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) chunk.Write<T13>(index) = t13Component;
		return entity;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(index) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) chunk.Write<T13>(index) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) chunk.Write<T14>(index) = t14Component;
		return entity;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default)
	{
		ref var chunk = ref CreateEntity(Archetypes.GetOrCreateArchetype(in ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature), out var entity, out var index);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(index) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) chunk.Write<T13>(index) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) chunk.Write<T14>(index) = t14Component;
        if (!ComponentMeta<T15>.IsZeroSize) chunk.Write<T15>(index) = t15Component;
		return entity;
	}
}