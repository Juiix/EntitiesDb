
using System;

namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1>(Entity entity, in T0? t0Component, ReadOnlySpan<T1> t1Components, in Signature removedSignature)
		where T1 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1>(int entityId, in T0? t0Component, ReadOnlySpan<T1> t1Components, in Signature removedSignature)
		where T1 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1>(Entity entity, in T0? t0Component, T1[] t1Components, in Signature removedSignature)
		where T1 : unmanaged
	{
		AddAndRemove(entity, in t0Component, t1Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1>(int entityId, in T0? t0Component, T1[] t1Components, in Signature removedSignature)
		where T1 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, t1Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2>(Entity entity, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2>(int entityId, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		AddAndRemove(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2>(int entityId, in T0? t0Component, T1[] t1Components, T2[] t2Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(Entity entity, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(int entityId, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		AddAndRemove(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(int entityId, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(int entityId, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		AddAndRemove(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(int entityId, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(int entityId, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		AddAndRemove(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(int entityId, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, in Signature removedSignature)
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
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		AddAndRemove(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
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
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		AddAndRemove(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
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
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
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
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		AddAndRemove(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
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
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
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
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
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
		AddAndRemove(entity, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
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
		AddAndRemove(entityId, in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2>(Entity entity, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, in Signature removedSignature)
		where T2 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
		chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2>(int entityId, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, in Signature removedSignature)
		where T2 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
		chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, in Signature removedSignature)
		where T2 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, t2Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2>(int entityId, in T0? t0Component, in T1? t1Component, T2[] t2Components, in Signature removedSignature)
		where T2 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, t2Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(Entity entity, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(int entityId, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
		chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(int entityId, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(int entityId, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
		chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(int entityId, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(int entityId, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
		chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(int entityId, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
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
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
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
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
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
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
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
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, ReadOnlySpan<T3> t3Components, in Signature removedSignature)
		where T3 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, ReadOnlySpan<T3> t3Components, in Signature removedSignature)
		where T3 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
		chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, in Signature removedSignature)
		where T3 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, in Signature removedSignature)
		where T3 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
		chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
		chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
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
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
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
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, ReadOnlySpan<T4> t4Components, in Signature removedSignature)
		where T4 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, ReadOnlySpan<T4> t4Components, in Signature removedSignature)
		where T4 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
		chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, in Signature removedSignature)
		where T4 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, in Signature removedSignature)
		where T4 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
		chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
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
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, ReadOnlySpan<T5> t5Components, in Signature removedSignature)
		where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, ReadOnlySpan<T5> t5Components, in Signature removedSignature)
		where T5 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
		chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, in Signature removedSignature)
		where T5 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, in Signature removedSignature)
		where T5 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components, T7[] t7Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components, T7[] t7Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, ReadOnlySpan<T6> t6Components, in Signature removedSignature)
		where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, ReadOnlySpan<T6> t6Components, in Signature removedSignature)
		where T6 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components, in Signature removedSignature)
		where T6 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components, in Signature removedSignature)
		where T6 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components, T7[] t7Components, in Signature removedSignature)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan(), t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components, T7[] t7Components, in Signature removedSignature)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan(), t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
		where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature | ComponentBuffer<T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
		where T7 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature | ComponentBuffer<T7>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, T7[] t7Components, in Signature removedSignature)
		where T7 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, T7[] t7Components, in Signature removedSignature)
		where T7 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature | ComponentBuffer<T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature | ComponentBuffer<T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature | ComponentBuffer<T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature | ComponentBuffer<T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
		where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature | ComponentBuffer<T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
		where T8 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature | ComponentBuffer<T8>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, T8[] t8Components, in Signature removedSignature)
		where T8 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, T8[] t8Components, in Signature removedSignature)
		where T8 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature | ComponentBuffer<T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature | ComponentBuffer<T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
		where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature | ComponentBuffer<T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
		where T9 : unmanaged
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature | ComponentBuffer<T9>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, T9[] t9Components, in Signature removedSignature)
		where T9 : unmanaged
	{
		AddAndRemove(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, T9[] t9Components, in Signature removedSignature)
		where T9 : unmanaged
	{
		AddAndRemove(entityId, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, t9Components.AsSpan(), in removedSignature);
	}
}