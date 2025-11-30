
using System;

namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Set{T0}(int, in T0?)"/>
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
	[ChunkChange]
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
}