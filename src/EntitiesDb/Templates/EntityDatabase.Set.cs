
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1>(Entity entity, in T0? t0Component, in T1? t1Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		var ids = ComponentRegistry.GetIds<T0, T1>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component);
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component);
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component);
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entity.Id, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);
	}
}