
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1>(in T0? t0Component = default, in T1? t1Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1>(in BulkCreate<T0, T1> bulk, in T0? t0Component = default, in T1? t1Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2>(in BulkCreate<T0, T1, T2> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3>(in BulkCreate<T0, T1, T2, T3> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4>(in BulkCreate<T0, T1, T2, T3, T4> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in BulkCreate<T0, T1, T2, T3, T4, T5> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default, in T22? t22Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component, in t22Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default, in T22? t22Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component, in t22Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default, in T22? t22Component = default, in T23? t23Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component, in t22Component, in t23Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default, in T22? t22Component = default, in T23? t23Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
        chunk.Set(slot.Index, in bulk.Ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component, in t22Component, in t23Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
}