using System;

namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default)
		where T1 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1>();
		var ids = ComponentRegistry.GetIds<T0,T1>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1,T2>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1,T2,T3>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1,T2,T3,T4>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertBuffered<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default)
		where T2 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1>();
		ComponentMeta.AssertBuffered<T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default)
		where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9,T10>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2>();
		ComponentMeta.AssertBuffered<T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default)
		where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9,T10>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9,T10,T11>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3>();
		ComponentMeta.AssertBuffered<T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default)
		where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9,T10>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9,T10,T11>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9,T10,T11,T12>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4>();
		ComponentMeta.AssertBuffered<T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default)
		where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9,T10>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components,t10Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9,T10,T11>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9,T10,T11,T12>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9,T10,T11,T12,T13>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5>();
		ComponentMeta.AssertBuffered<T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default)
		where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9,T10>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components,t10Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9,T10,T11>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components,t10Components,t11Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9,T10,T11,T12>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9,T10,T11,T12,T13>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9,T10,T11,T12,T13,T14>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6>();
		ComponentMeta.AssertBuffered<T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default)
		where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9,T10>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components,t10Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9,T10,T11>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components,t10Components,t11Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9,T10,T11,T12>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components,t10Components,t11Components,t12Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9,T10,T11,T12,T13>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9,T10,T11,T12,T13,T14>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9,T10,T11,T12,T13,T14,T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7>();
		ComponentMeta.AssertBuffered<T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default)
		where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9,T10>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components,t10Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9,T10,T11>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components,t10Components,t11Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9,T10,T11,T12>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components,t10Components,t11Components,t12Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9,T10,T11,T12,T13>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components,t10Components,t11Components,t12Components,t13Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9,T10,T11,T12,T13,T14>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9,T10,T11,T12,T13,T14,T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9,T10,T11,T12,T13,T14,T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8>();
		ComponentMeta.AssertBuffered<T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default)
		where T10 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ComponentMeta.AssertBuffered<T10>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,t10Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ComponentMeta.AssertBuffered<T10,T11>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,t10Components,t11Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ComponentMeta.AssertBuffered<T10,T11,T12>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,t10Components,t11Components,t12Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ComponentMeta.AssertBuffered<T10,T11,T12,T13>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,t10Components,t11Components,t12Components,t13Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ComponentMeta.AssertBuffered<T10,T11,T12,T13,T14>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,t10Components,t11Components,t12Components,t13Components,t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ComponentMeta.AssertBuffered<T10,T11,T12,T13,T14,T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ComponentMeta.AssertBuffered<T10,T11,T12,T13,T14,T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ComponentMeta.AssertBuffered<T10,T11,T12,T13,T14,T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ComponentMeta.AssertBuffered<T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ComponentMeta.AssertBuffered<T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ComponentMeta.AssertBuffered<T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ComponentMeta.AssertBuffered<T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ComponentMeta.AssertBuffered<T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ComponentMeta.AssertBuffered<T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default)
		where T11 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ComponentMeta.AssertBuffered<T11>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,t11Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ComponentMeta.AssertBuffered<T11,T12>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,t11Components,t12Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ComponentMeta.AssertBuffered<T11,T12,T13>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,t11Components,t12Components,t13Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ComponentMeta.AssertBuffered<T11,T12,T13,T14>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,t11Components,t12Components,t13Components,t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ComponentMeta.AssertBuffered<T11,T12,T13,T14,T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,t11Components,t12Components,t13Components,t14Components,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ComponentMeta.AssertBuffered<T11,T12,T13,T14,T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ComponentMeta.AssertBuffered<T11,T12,T13,T14,T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ComponentMeta.AssertBuffered<T11,T12,T13,T14,T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ComponentMeta.AssertBuffered<T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ComponentMeta.AssertBuffered<T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ComponentMeta.AssertBuffered<T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ComponentMeta.AssertBuffered<T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ComponentMeta.AssertBuffered<T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default)
		where T12 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ComponentMeta.AssertBuffered<T12>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,t12Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ComponentMeta.AssertBuffered<T12,T13>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,t12Components,t13Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ComponentMeta.AssertBuffered<T12,T13,T14>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,t12Components,t13Components,t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ComponentMeta.AssertBuffered<T12,T13,T14,T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,t12Components,t13Components,t14Components,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ComponentMeta.AssertBuffered<T12,T13,T14,T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,t12Components,t13Components,t14Components,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ComponentMeta.AssertBuffered<T12,T13,T14,T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ComponentMeta.AssertBuffered<T12,T13,T14,T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ComponentMeta.AssertBuffered<T12,T13,T14,T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ComponentMeta.AssertBuffered<T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ComponentMeta.AssertBuffered<T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ComponentMeta.AssertBuffered<T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ComponentMeta.AssertBuffered<T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default)
		where T13 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ComponentMeta.AssertBuffered<T13>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,t13Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ComponentMeta.AssertBuffered<T13,T14>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,t13Components,t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ComponentMeta.AssertBuffered<T13,T14,T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,t13Components,t14Components,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ComponentMeta.AssertBuffered<T13,T14,T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,t13Components,t14Components,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ComponentMeta.AssertBuffered<T13,T14,T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,t13Components,t14Components,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ComponentMeta.AssertBuffered<T13,T14,T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ComponentMeta.AssertBuffered<T13,T14,T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ComponentMeta.AssertBuffered<T13,T14,T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ComponentMeta.AssertBuffered<T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ComponentMeta.AssertBuffered<T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ComponentMeta.AssertBuffered<T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default)
		where T14 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ComponentMeta.AssertBuffered<T14>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ComponentMeta.AssertBuffered<T14,T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,t14Components,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ComponentMeta.AssertBuffered<T14,T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,t14Components,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ComponentMeta.AssertBuffered<T14,T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,t14Components,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ComponentMeta.AssertBuffered<T14,T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,t14Components,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ComponentMeta.AssertBuffered<T14,T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ComponentMeta.AssertBuffered<T14,T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ComponentMeta.AssertBuffered<T14,T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ComponentMeta.AssertBuffered<T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ComponentMeta.AssertBuffered<T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default)
		where T15 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ComponentMeta.AssertBuffered<T15>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ComponentMeta.AssertBuffered<T15,T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,t15Components,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ComponentMeta.AssertBuffered<T15,T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,t15Components,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ComponentMeta.AssertBuffered<T15,T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,t15Components,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ComponentMeta.AssertBuffered<T15,T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,t15Components,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ComponentMeta.AssertBuffered<T15,T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ComponentMeta.AssertBuffered<T15,T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ComponentMeta.AssertBuffered<T15,T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ComponentMeta.AssertBuffered<T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default)
		where T16 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ComponentMeta.AssertBuffered<T16>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ComponentMeta.AssertBuffered<T16,T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,t16Components,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ComponentMeta.AssertBuffered<T16,T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,t16Components,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ComponentMeta.AssertBuffered<T16,T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,t16Components,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ComponentMeta.AssertBuffered<T16,T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,t16Components,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ComponentMeta.AssertBuffered<T16,T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ComponentMeta.AssertBuffered<T16,T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ComponentMeta.AssertBuffered<T16,T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,ReadOnlySpan<T17> t17Components = default)
		where T17 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ComponentMeta.AssertBuffered<T17>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ComponentMeta.AssertBuffered<T17,T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,t17Components,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ComponentMeta.AssertBuffered<T17,T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,t17Components,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ComponentMeta.AssertBuffered<T17,T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,t17Components,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ComponentMeta.AssertBuffered<T17,T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,t17Components,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ComponentMeta.AssertBuffered<T17,T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ComponentMeta.AssertBuffered<T17,T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,ReadOnlySpan<T18> t18Components = default)
		where T18 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ComponentMeta.AssertBuffered<T18>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ComponentMeta.AssertBuffered<T18,T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,t18Components,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ComponentMeta.AssertBuffered<T18,T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,t18Components,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ComponentMeta.AssertBuffered<T18,T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,t18Components,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ComponentMeta.AssertBuffered<T18,T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,t18Components,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ComponentMeta.AssertBuffered<T18,T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,ReadOnlySpan<T19> t19Components = default)
		where T19 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ComponentMeta.AssertBuffered<T19>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
		where T19 : unmanaged
        where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ComponentMeta.AssertBuffered<T19,T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,t19Components,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
		where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ComponentMeta.AssertBuffered<T19,T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,t19Components,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
		where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ComponentMeta.AssertBuffered<T19,T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,t19Components,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
		where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ComponentMeta.AssertBuffered<T19,T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,t19Components,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,ReadOnlySpan<T20> t20Components = default)
		where T20 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ComponentMeta.AssertBuffered<T20>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
		where T20 : unmanaged
        where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ComponentMeta.AssertBuffered<T20,T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,t20Components,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
		where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ComponentMeta.AssertBuffered<T20,T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,t20Components,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
		where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ComponentMeta.AssertBuffered<T20,T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,t20Components,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,ReadOnlySpan<T21> t21Components = default)
		where T21 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ComponentMeta.AssertBuffered<T21>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
		where T21 : unmanaged
        where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ComponentMeta.AssertBuffered<T21,T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,t21Components,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
		where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ComponentMeta.AssertBuffered<T21,T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,t21Components,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,in T21? t21Component = default,ReadOnlySpan<T22> t22Components = default)
		where T22 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ComponentMeta.AssertBuffered<T22>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component,t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,in T21? t21Component = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
		where T22 : unmanaged
        where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ComponentMeta.AssertBuffered<T22,T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component,t22Components,t23Components);
	}
	/// <inheritdoc cref="Add{T0}(int, in T0?)"/>
	public void Add<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(int entityId,in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,in T21? t21Component = default,in T22? t22Component = default,ReadOnlySpan<T23> t23Components = default)
		where T23 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ComponentMeta.AssertBuffered<T23>();
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component,in t22Component,t23Components);
	}
}