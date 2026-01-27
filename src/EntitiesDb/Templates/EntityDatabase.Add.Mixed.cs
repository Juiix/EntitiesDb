
using System;

namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default)
		where T1 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1>(Entity entity, in T0? t0Component, T1[] t1Components)
		where T1 : unmanaged
	{
		Add(entity, in t0Component, t1Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		Add(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		Add(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		Add(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		Add(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		Add(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Add(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Add(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components)
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
		Add(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default)
		where T2 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
		chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components)
		where T2 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, t2Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
		chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
		chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
		chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
		chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
		chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
		chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
		chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default)
		where T3 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
		chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components)
		where T3 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, t3Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
		chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
		chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
		chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
		chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
		chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
		chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default)
		where T4 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
		chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components)
		where T4 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
		chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
		chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
		chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
		chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
		chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default)
		where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
		chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components)
		where T5 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
		chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
		chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components, T7[] t7Components)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
		chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
		chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default)
		where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
		chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components)
		where T6 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
		chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components, T7[] t7Components)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan(), t7Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
		chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components, T7[] t7Components, T8[] t8Components)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
		chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default)
		where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature | ComponentBuffer<T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
		chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, T7[] t7Components)
		where T7 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature | ComponentBuffer<T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
		chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, T7[] t7Components, T8[] t8Components)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature | ComponentBuffer<T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
		chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, T7[] t7Components, T8[] t8Components, T9[] t9Components)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default)
		where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature | ComponentBuffer<T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
		chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, T8[] t8Components)
		where T8 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, t8Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature | ComponentBuffer<T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
		chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, T8[] t8Components, T9[] t9Components)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default)
		where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature | ComponentBuffer<T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
		chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, T9[] t9Components)
		where T9 : unmanaged
	{
		Add(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, t9Components.AsSpan());
	}
}