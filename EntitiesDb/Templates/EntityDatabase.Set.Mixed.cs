
using System;

namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default)
		where T1 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1>();
		var ids = ComponentRegistry.GetIds<T0,T1>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1>(ids.T1);
		archetype.Init(in entityReference.Slot, in bIds, t1Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2>(ids.T1, ids.T2);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3>(ids.T1, ids.T2, ids.T3);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4>(ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0,T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0>(ids.T0);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component);

		var bIds = new Ids<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default)
		where T2 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2>(ids.T2);
		archetype.Init(in entityReference.Slot, in bIds, t2Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3>(ids.T2, ids.T3);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4>(ids.T2, ids.T3, ids.T4);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5>(ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9, T10>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1,T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1>(ids.T0, ids.T1);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component);

		var bIds = new Ids<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default)
		where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3>(ids.T3);
		archetype.Init(in entityReference.Slot, in bIds, t3Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4>(ids.T3, ids.T4);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5>(ids.T3, ids.T4, ids.T5);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6>(ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9, T10>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9, T10>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9, T10>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9, T10, T11>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2,T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2>(ids.T0, ids.T1, ids.T2);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component);

		var bIds = new Ids<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default)
		where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4>(ids.T4);
		archetype.Init(in entityReference.Slot, in bIds, t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5>(ids.T4, ids.T5);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6>(ids.T4, ids.T5, ids.T6);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7>(ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9, T10>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9, T10>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9, T10>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9, T10, T11>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9, T10, T11>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9, T10, T11>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9, T10, T11, T12>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3,T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3>(ids.T0, ids.T1, ids.T2, ids.T3);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component);

		var bIds = new Ids<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default)
		where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5>(ids.T5);
		archetype.Init(in entityReference.Slot, in bIds, t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6>(ids.T5, ids.T6);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7>(ids.T5, ids.T6, ids.T7);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8>(ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9, T10>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9, T10>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9, T10>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9, T10, T11>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9, T10, T11>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9, T10, T11>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9, T10, T11, T12>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9, T10, T11, T12>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9, T10, T11, T12>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9, T10, T11, T12, T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4,T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);

		var bIds = new Ids<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default)
		where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6>(ids.T6);
		archetype.Init(in entityReference.Slot, in bIds, t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7>(ids.T6, ids.T7);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8>(ids.T6, ids.T7, ids.T8);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9>(ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9, T10>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9, T10>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9, T10>(ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components, t10Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9, T10, T11>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9, T10, T11>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9, T10, T11>(ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9, T10, T11, T12>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9, T10, T11, T12>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9, T10, T11, T12>(ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9, T10, T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9, T10, T11, T12, T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9, T10, T11, T12, T13>(ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9, T10, T11, T12, T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5,T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);

		var bIds = new Ids<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default)
		where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7>(ids.T7);
		archetype.Init(in entityReference.Slot, in bIds, t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8>(ids.T7, ids.T8);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9>(ids.T7, ids.T8, ids.T9);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9, T10>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9, T10>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9, T10>(ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components, t10Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9, T10, T11>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9, T10, T11>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9, T10, T11>(ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components, t10Components, t11Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9, T10, T11, T12>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9, T10, T11, T12>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9, T10, T11, T12>(ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9, T10, T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9, T10, T11, T12, T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9, T10, T11, T12, T13>(ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9, T10, T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9, T10, T11, T12, T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9, T10, T11, T12, T13, T14>(ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9, T10, T11, T12, T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6,T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);

		var bIds = new Ids<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default)
		where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8>(ids.T8);
		archetype.Init(in entityReference.Slot, in bIds, t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9>(ids.T8, ids.T9);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9, T10>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9, T10>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9, T10>(ids.T8, ids.T9, ids.T10);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components, t10Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9, T10, T11>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9, T10, T11>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9, T10, T11>(ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components, t10Components, t11Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9, T10, T11, T12>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9, T10, T11, T12>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9, T10, T11, T12>(ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components, t10Components, t11Components, t12Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9, T10, T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9, T10, T11, T12, T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9, T10, T11, T12, T13>(ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9, T10, T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9, T10, T11, T12, T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9, T10, T11, T12, T13, T14>(ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9, T10, T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9, T10, T11, T12, T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9, T10, T11, T12, T13, T14, T15>(ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9, T10, T11, T12, T13, T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7,T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);

		var bIds = new Ids<T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default)
		where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9>(ids.T9);
		archetype.Init(in entityReference.Slot, in bIds, t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9, T10>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9, T10>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9, T10>(ids.T9, ids.T10);
		archetype.Init(in entityReference.Slot, in bIds, t9Components, t10Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9, T10, T11>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9, T10, T11>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9, T10, T11>(ids.T9, ids.T10, ids.T11);
		archetype.Init(in entityReference.Slot, in bIds, t9Components, t10Components, t11Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9, T10, T11, T12>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9, T10, T11, T12>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9, T10, T11, T12>(ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Init(in entityReference.Slot, in bIds, t9Components, t10Components, t11Components, t12Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9, T10, T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9, T10, T11, T12, T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9, T10, T11, T12, T13>(ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Init(in entityReference.Slot, in bIds, t9Components, t10Components, t11Components, t12Components, t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9, T10, T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9, T10, T11, T12, T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9, T10, T11, T12, T13, T14>(ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Init(in entityReference.Slot, in bIds, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9, T10, T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9, T10, T11, T12, T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9, T10, T11, T12, T13, T14, T15>(ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9, T10, T11, T12, T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9, T10, T11, T12, T13, T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9, T10, T11, T12, T13, T14, T15, T16>(ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9, T10, T11, T12, T13, T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8,T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);

		var bIds = new Ids<T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, ReadOnlySpan<T10> t10Components = default)
		where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ComponentMeta.AssertBuffered<T10>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,T10>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);

		var bIds = new Ids<T10>(ids.T10);
		archetype.Init(in entityReference.Slot, in bIds, t10Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ComponentMeta.AssertBuffered<T10, T11>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, T11>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);

		var bIds = new Ids<T10, T11>(ids.T10, ids.T11);
		archetype.Init(in entityReference.Slot, in bIds, t10Components, t11Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ComponentMeta.AssertBuffered<T10, T11, T12>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, T11, T12>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);

		var bIds = new Ids<T10, T11, T12>(ids.T10, ids.T11, ids.T12);
		archetype.Init(in entityReference.Slot, in bIds, t10Components, t11Components, t12Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ComponentMeta.AssertBuffered<T10, T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, T11, T12, T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);

		var bIds = new Ids<T10, T11, T12, T13>(ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Init(in entityReference.Slot, in bIds, t10Components, t11Components, t12Components, t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ComponentMeta.AssertBuffered<T10, T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, T11, T12, T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);

		var bIds = new Ids<T10, T11, T12, T13, T14>(ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Init(in entityReference.Slot, in bIds, t10Components, t11Components, t12Components, t13Components, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ComponentMeta.AssertBuffered<T10, T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, T11, T12, T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);

		var bIds = new Ids<T10, T11, T12, T13, T14, T15>(ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ComponentMeta.AssertBuffered<T10, T11, T12, T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, T11, T12, T13, T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);

		var bIds = new Ids<T10, T11, T12, T13, T14, T15, T16>(ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ComponentMeta.AssertBuffered<T10, T11, T12, T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, T11, T12, T13, T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);

		var bIds = new Ids<T10, T11, T12, T13, T14, T15, T16, T17>(ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ComponentMeta.AssertBuffered<T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, T11, T12, T13, T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);

		var bIds = new Ids<T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ComponentMeta.AssertBuffered<T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);

		var bIds = new Ids<T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ComponentMeta.AssertBuffered<T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);

		var bIds = new Ids<T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ComponentMeta.AssertBuffered<T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);

		var bIds = new Ids<T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ComponentMeta.AssertBuffered<T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);

		var bIds = new Ids<T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ComponentMeta.AssertBuffered<T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);

		var bIds = new Ids<T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, ReadOnlySpan<T11> t11Components = default)
		where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ComponentMeta.AssertBuffered<T11>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);

		var bIds = new Ids<T11>(ids.T11);
		archetype.Init(in entityReference.Slot, in bIds, t11Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ComponentMeta.AssertBuffered<T11, T12>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, T12>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);

		var bIds = new Ids<T11, T12>(ids.T11, ids.T12);
		archetype.Init(in entityReference.Slot, in bIds, t11Components, t12Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ComponentMeta.AssertBuffered<T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, T12, T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);

		var bIds = new Ids<T11, T12, T13>(ids.T11, ids.T12, ids.T13);
		archetype.Init(in entityReference.Slot, in bIds, t11Components, t12Components, t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ComponentMeta.AssertBuffered<T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, T12, T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);

		var bIds = new Ids<T11, T12, T13, T14>(ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Init(in entityReference.Slot, in bIds, t11Components, t12Components, t13Components, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ComponentMeta.AssertBuffered<T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, T12, T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);

		var bIds = new Ids<T11, T12, T13, T14, T15>(ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t11Components, t12Components, t13Components, t14Components, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ComponentMeta.AssertBuffered<T11, T12, T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, T12, T13, T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);

		var bIds = new Ids<T11, T12, T13, T14, T15, T16>(ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ComponentMeta.AssertBuffered<T11, T12, T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, T12, T13, T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);

		var bIds = new Ids<T11, T12, T13, T14, T15, T16, T17>(ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ComponentMeta.AssertBuffered<T11, T12, T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, T12, T13, T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);

		var bIds = new Ids<T11, T12, T13, T14, T15, T16, T17, T18>(ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ComponentMeta.AssertBuffered<T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, T12, T13, T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);

		var bIds = new Ids<T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ComponentMeta.AssertBuffered<T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);

		var bIds = new Ids<T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ComponentMeta.AssertBuffered<T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);

		var bIds = new Ids<T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ComponentMeta.AssertBuffered<T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);

		var bIds = new Ids<T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ComponentMeta.AssertBuffered<T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);

		var bIds = new Ids<T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, ReadOnlySpan<T12> t12Components = default)
		where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ComponentMeta.AssertBuffered<T12>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);

		var bIds = new Ids<T12>(ids.T12);
		archetype.Init(in entityReference.Slot, in bIds, t12Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ComponentMeta.AssertBuffered<T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);

		var bIds = new Ids<T12, T13>(ids.T12, ids.T13);
		archetype.Init(in entityReference.Slot, in bIds, t12Components, t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ComponentMeta.AssertBuffered<T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);

		var bIds = new Ids<T12, T13, T14>(ids.T12, ids.T13, ids.T14);
		archetype.Init(in entityReference.Slot, in bIds, t12Components, t13Components, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ComponentMeta.AssertBuffered<T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);

		var bIds = new Ids<T12, T13, T14, T15>(ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t12Components, t13Components, t14Components, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ComponentMeta.AssertBuffered<T12, T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, T13, T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);

		var bIds = new Ids<T12, T13, T14, T15, T16>(ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t12Components, t13Components, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ComponentMeta.AssertBuffered<T12, T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, T13, T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);

		var bIds = new Ids<T12, T13, T14, T15, T16, T17>(ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ComponentMeta.AssertBuffered<T12, T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, T13, T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);

		var bIds = new Ids<T12, T13, T14, T15, T16, T17, T18>(ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ComponentMeta.AssertBuffered<T12, T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, T13, T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);

		var bIds = new Ids<T12, T13, T14, T15, T16, T17, T18, T19>(ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ComponentMeta.AssertBuffered<T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);

		var bIds = new Ids<T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ComponentMeta.AssertBuffered<T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);

		var bIds = new Ids<T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ComponentMeta.AssertBuffered<T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);

		var bIds = new Ids<T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ComponentMeta.AssertBuffered<T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);

		var bIds = new Ids<T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, ReadOnlySpan<T13> t13Components = default)
		where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		ComponentMeta.AssertBuffered<T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);

		var bIds = new Ids<T13>(ids.T13);
		archetype.Init(in entityReference.Slot, in bIds, t13Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		ComponentMeta.AssertBuffered<T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);

		var bIds = new Ids<T13, T14>(ids.T13, ids.T14);
		archetype.Init(in entityReference.Slot, in bIds, t13Components, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		ComponentMeta.AssertBuffered<T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);

		var bIds = new Ids<T13, T14, T15>(ids.T13, ids.T14, ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t13Components, t14Components, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		ComponentMeta.AssertBuffered<T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);

		var bIds = new Ids<T13, T14, T15, T16>(ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t13Components, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		ComponentMeta.AssertBuffered<T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);

		var bIds = new Ids<T13, T14, T15, T16, T17>(ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t13Components, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		ComponentMeta.AssertBuffered<T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);

		var bIds = new Ids<T13, T14, T15, T16, T17, T18>(ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		ComponentMeta.AssertBuffered<T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);

		var bIds = new Ids<T13, T14, T15, T16, T17, T18, T19>(ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		ComponentMeta.AssertBuffered<T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);

		var bIds = new Ids<T13, T14, T15, T16, T17, T18, T19, T20>(ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		ComponentMeta.AssertBuffered<T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);

		var bIds = new Ids<T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		ComponentMeta.AssertBuffered<T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);

		var bIds = new Ids<T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		ComponentMeta.AssertBuffered<T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);

		var bIds = new Ids<T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, ReadOnlySpan<T14> t14Components = default)
		where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		ComponentMeta.AssertBuffered<T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);

		var bIds = new Ids<T14>(ids.T14);
		archetype.Init(in entityReference.Slot, in bIds, t14Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		ComponentMeta.AssertBuffered<T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14, T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);

		var bIds = new Ids<T14, T15>(ids.T14, ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t14Components, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		ComponentMeta.AssertBuffered<T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14, T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);

		var bIds = new Ids<T14, T15, T16>(ids.T14, ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		ComponentMeta.AssertBuffered<T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14, T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);

		var bIds = new Ids<T14, T15, T16, T17>(ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		ComponentMeta.AssertBuffered<T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14, T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);

		var bIds = new Ids<T14, T15, T16, T17, T18>(ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		ComponentMeta.AssertBuffered<T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14, T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);

		var bIds = new Ids<T14, T15, T16, T17, T18, T19>(ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		ComponentMeta.AssertBuffered<T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14, T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);

		var bIds = new Ids<T14, T15, T16, T17, T18, T19, T20>(ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		ComponentMeta.AssertBuffered<T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14, T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);

		var bIds = new Ids<T14, T15, T16, T17, T18, T19, T20, T21>(ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		ComponentMeta.AssertBuffered<T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);

		var bIds = new Ids<T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		ComponentMeta.AssertBuffered<T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);

		var bIds = new Ids<T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, ReadOnlySpan<T15> t15Components = default)
		where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		ComponentMeta.AssertBuffered<T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);

		var bIds = new Ids<T15>(ids.T15);
		archetype.Init(in entityReference.Slot, in bIds, t15Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		ComponentMeta.AssertBuffered<T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15, T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);

		var bIds = new Ids<T15, T16>(ids.T15, ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t15Components, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		ComponentMeta.AssertBuffered<T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15, T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);

		var bIds = new Ids<T15, T16, T17>(ids.T15, ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		ComponentMeta.AssertBuffered<T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15, T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);

		var bIds = new Ids<T15, T16, T17, T18>(ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		ComponentMeta.AssertBuffered<T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15, T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);

		var bIds = new Ids<T15, T16, T17, T18, T19>(ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		ComponentMeta.AssertBuffered<T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15, T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);

		var bIds = new Ids<T15, T16, T17, T18, T19, T20>(ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		ComponentMeta.AssertBuffered<T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15, T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);

		var bIds = new Ids<T15, T16, T17, T18, T19, T20, T21>(ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		ComponentMeta.AssertBuffered<T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15, T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);

		var bIds = new Ids<T15, T16, T17, T18, T19, T20, T21, T22>(ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		ComponentMeta.AssertBuffered<T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);

		var bIds = new Ids<T15, T16, T17, T18, T19, T20, T21, T22, T23>(ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, ReadOnlySpan<T16> t16Components = default)
		where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		ComponentMeta.AssertBuffered<T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);

		var bIds = new Ids<T16>(ids.T16);
		archetype.Init(in entityReference.Slot, in bIds, t16Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		ComponentMeta.AssertBuffered<T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);

		var bIds = new Ids<T16, T17>(ids.T16, ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t16Components, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		ComponentMeta.AssertBuffered<T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);

		var bIds = new Ids<T16, T17, T18>(ids.T16, ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		ComponentMeta.AssertBuffered<T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);

		var bIds = new Ids<T16, T17, T18, T19>(ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		ComponentMeta.AssertBuffered<T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);

		var bIds = new Ids<T16, T17, T18, T19, T20>(ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		ComponentMeta.AssertBuffered<T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);

		var bIds = new Ids<T16, T17, T18, T19, T20, T21>(ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		ComponentMeta.AssertBuffered<T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);

		var bIds = new Ids<T16, T17, T18, T19, T20, T21, T22>(ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		ComponentMeta.AssertBuffered<T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);

		var bIds = new Ids<T16, T17, T18, T19, T20, T21, T22, T23>(ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, ReadOnlySpan<T17> t17Components = default)
		where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		ComponentMeta.AssertBuffered<T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16,T17>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component);

		var bIds = new Ids<T17>(ids.T17);
		archetype.Init(in entityReference.Slot, in bIds, t17Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		ComponentMeta.AssertBuffered<T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16,T17, T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component);

		var bIds = new Ids<T17, T18>(ids.T17, ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t17Components, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		ComponentMeta.AssertBuffered<T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16,T17, T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component);

		var bIds = new Ids<T17, T18, T19>(ids.T17, ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		ComponentMeta.AssertBuffered<T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16,T17, T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component);

		var bIds = new Ids<T17, T18, T19, T20>(ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		ComponentMeta.AssertBuffered<T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16,T17, T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component);

		var bIds = new Ids<T17, T18, T19, T20, T21>(ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		ComponentMeta.AssertBuffered<T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16,T17, T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component);

		var bIds = new Ids<T17, T18, T19, T20, T21, T22>(ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		ComponentMeta.AssertBuffered<T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16,T17, T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component);

		var bIds = new Ids<T17, T18, T19, T20, T21, T22, T23>(ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, ReadOnlySpan<T18> t18Components = default)
		where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		ComponentMeta.AssertBuffered<T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17,T18>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component);

		var bIds = new Ids<T18>(ids.T18);
		archetype.Init(in entityReference.Slot, in bIds, t18Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		ComponentMeta.AssertBuffered<T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17,T18, T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component);

		var bIds = new Ids<T18, T19>(ids.T18, ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t18Components, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		ComponentMeta.AssertBuffered<T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17,T18, T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component);

		var bIds = new Ids<T18, T19, T20>(ids.T18, ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		ComponentMeta.AssertBuffered<T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17,T18, T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component);

		var bIds = new Ids<T18, T19, T20, T21>(ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		ComponentMeta.AssertBuffered<T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17,T18, T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component);

		var bIds = new Ids<T18, T19, T20, T21, T22>(ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		ComponentMeta.AssertBuffered<T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17,T18, T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component);

		var bIds = new Ids<T18, T19, T20, T21, T22, T23>(ids.T18, ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, ReadOnlySpan<T19> t19Components = default)
		where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		ComponentMeta.AssertBuffered<T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18,T19>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component);

		var bIds = new Ids<T19>(ids.T19);
		archetype.Init(in entityReference.Slot, in bIds, t19Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		ComponentMeta.AssertBuffered<T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18,T19, T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component);

		var bIds = new Ids<T19, T20>(ids.T19, ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t19Components, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		ComponentMeta.AssertBuffered<T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18,T19, T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component);

		var bIds = new Ids<T19, T20, T21>(ids.T19, ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		ComponentMeta.AssertBuffered<T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18,T19, T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component);

		var bIds = new Ids<T19, T20, T21, T22>(ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		ComponentMeta.AssertBuffered<T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18,T19, T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component);

		var bIds = new Ids<T19, T20, T21, T22, T23>(ids.T19, ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, ReadOnlySpan<T20> t20Components = default)
		where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		ComponentMeta.AssertBuffered<T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,T20>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component);

		var bIds = new Ids<T20>(ids.T20);
		archetype.Init(in entityReference.Slot, in bIds, t20Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		ComponentMeta.AssertBuffered<T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,T20, T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component);

		var bIds = new Ids<T20, T21>(ids.T20, ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t20Components, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		ComponentMeta.AssertBuffered<T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,T20, T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component);

		var bIds = new Ids<T20, T21, T22>(ids.T20, ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		ComponentMeta.AssertBuffered<T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,T20, T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component);

		var bIds = new Ids<T20, T21, T22, T23>(ids.T20, ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t20Components, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, ReadOnlySpan<T21> t21Components = default)
		where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		ComponentMeta.AssertBuffered<T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20,T21>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component);

		var bIds = new Ids<T21>(ids.T21);
		archetype.Init(in entityReference.Slot, in bIds, t21Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		ComponentMeta.AssertBuffered<T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20,T21, T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component);

		var bIds = new Ids<T21, T22>(ids.T21, ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t21Components, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		ComponentMeta.AssertBuffered<T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20,T21, T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component);

		var bIds = new Ids<T21, T22, T23>(ids.T21, ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t21Components, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default, ReadOnlySpan<T22> t22Components = default)
		where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		ComponentMeta.AssertBuffered<T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21,T22>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component);

		var bIds = new Ids<T22>(ids.T22);
		archetype.Init(in entityReference.Slot, in bIds, t22Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		ComponentMeta.AssertBuffered<T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21,T22, T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component);

		var bIds = new Ids<T22, T23>(ids.T22, ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t22Components, t23Components);
	}
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId,in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default, in T22? t22Component = default, ReadOnlySpan<T23> t23Components = default)
		where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		ComponentMeta.AssertBuffered<T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22,T23>();
        var checkSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var archetype = entityReference.Archetype;
		if (!archetype.Signature.HasAny(in checkSignature))
			throw archetype.GetComponentNotFound(entityId, in ids);

		// set component value
		var cIds = new Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ids.T0, ids.T1, ids.T2, ids.T3, ids.T4, ids.T5, ids.T6, ids.T7, ids.T8, ids.T9, ids.T10, ids.T11, ids.T12, ids.T13, ids.T14, ids.T15, ids.T16, ids.T17, ids.T18, ids.T19, ids.T20, ids.T21, ids.T22);
		archetype.Set(in entityReference.Slot, in cIds, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component, in t22Component);

		var bIds = new Ids<T23>(ids.T23);
		archetype.Init(in entityReference.Slot, in bIds, t23Components);
	}
}