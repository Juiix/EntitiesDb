
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1>(in T0? t0Component = default, in T1? t1Component = default)
	{
		var signature = ComponentSingle<T0, T1>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(slot.Index) = t2Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(slot.Index) = t3Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(slot.Index) = t4Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(slot.Index) = t5Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(slot.Index) = t6Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(slot.Index) = t7Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(slot.Index) = t8Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(slot.Index) = t9Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(slot.Index) = t10Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(slot.Index) = t11Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(slot.Index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(slot.Index) = t12Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(slot.Index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(slot.Index) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) chunk.Write<T13>(slot.Index) = t13Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(slot.Index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(slot.Index) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) chunk.Write<T13>(slot.Index) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) chunk.Write<T14>(slot.Index) = t14Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(slot.Index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(slot.Index) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) chunk.Write<T13>(slot.Index) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) chunk.Write<T14>(slot.Index) = t14Component;
        if (!ComponentMeta<T15>.IsZeroSize) chunk.Write<T15>(slot.Index) = t15Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
}