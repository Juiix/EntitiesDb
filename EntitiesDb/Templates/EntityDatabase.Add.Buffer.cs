
using System;

namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1>();
		var ids = ComponentRegistry.GetIds<T0, T1>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components);
	}
	/// <inheritdoc cref="Add{T0}(int, ReadOnlySpan{T0})"/>
	[StructuralChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int entityId, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default, ReadOnlySpan<T16> t16Components = default, ReadOnlySpan<T17> t17Components = default, ReadOnlySpan<T18> t18Components = default, ReadOnlySpan<T19> t19Components = default, ReadOnlySpan<T20> t20Components = default, ReadOnlySpan<T21> t21Components = default, ReadOnlySpan<T22> t22Components = default, ReadOnlySpan<T23> t23Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Signature.HasAny(in addedSignature))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Init(in entityReference.Slot, in ids, t0Components, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components, t10Components, t11Components, t12Components, t13Components, t14Components, t15Components, t16Components, t17Components, t18Components, t19Components, t20Components, t21Components, t22Components, t23Components);
	}
}