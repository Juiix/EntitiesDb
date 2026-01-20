
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1>(Entity entity, in T0? t0Component = default, in T1? t1Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		var ids = ComponentRegistry.GetIds<T0, T1>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);
	}
}