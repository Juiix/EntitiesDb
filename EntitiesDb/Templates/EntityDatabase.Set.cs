
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1>(int entityId, in T0? t0Component, in T1? t1Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		var ids = ComponentRegistry.GetIds<T0, T1>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component, in T17? t17Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component, in T17? t17Component, in T18? t18Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component, in T17? t17Component, in T18? t18Component, in T19? t19Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component, in T17? t17Component, in T18? t18Component, in T19? t19Component, in T20? t20Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component, in T17? t17Component, in T18? t18Component, in T19? t19Component, in T20? t20Component, in T21? t21Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component, in T17? t17Component, in T18? t18Component, in T19? t19Component, in T20? t20Component, in T21? t21Component, in T22? t22Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component, in t22Component);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component, in T17? t17Component, in T18? t18Component, in T19? t19Component, in T20? t20Component, in T21? t21Component, in T22? t22Component, in T23? t23Component)
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		archetype.Set(in entityReference.Slot, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component, in t22Component, in t23Component);
	}
}