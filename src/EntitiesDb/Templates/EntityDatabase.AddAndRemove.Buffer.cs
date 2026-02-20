
using System;

namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0, T1>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0, T1>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1>(Entity entity, T0[] t0Components, T1[] t1Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1>(int entityId, T0[] t0Components, T1[] t1Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0, T1, T2>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0, T1, T2>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2>(int entityId, T0[] t0Components, T1[] t1Components, T2[] t2Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0, T1, T2, T3>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0, T1, T2, T3>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(int entityId, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(int entityId, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(int entityId, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, in Signature removedSignature)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
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
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, in Signature removedSignature)
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
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
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
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
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
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
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
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, in Signature removedSignature)
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
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, ReadOnlySpan<T10> t10Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(entityReference.Slot.Index).Set(t10Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, ReadOnlySpan<T10> t10Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(entityReference.Slot.Index).Set(t10Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, in Signature removedSignature)
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
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, in Signature removedSignature)
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
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, ReadOnlySpan<T10> t10Components, ReadOnlySpan<T11> t11Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(entityReference.Slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(entityReference.Slot.Index).Set(t11Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, ReadOnlySpan<T10> t10Components, ReadOnlySpan<T11> t11Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(entityReference.Slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(entityReference.Slot.Index).Set(t11Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, in Signature removedSignature)
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
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, in Signature removedSignature)
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
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, ReadOnlySpan<T10> t10Components, ReadOnlySpan<T11> t11Components, ReadOnlySpan<T12> t12Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(entityReference.Slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(entityReference.Slot.Index).Set(t11Components);
        chunk.WriteBuffer<T12>(entityReference.Slot.Index).Set(t12Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, ReadOnlySpan<T10> t10Components, ReadOnlySpan<T11> t11Components, ReadOnlySpan<T12> t12Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(entityReference.Slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(entityReference.Slot.Index).Set(t11Components);
        chunk.WriteBuffer<T12>(entityReference.Slot.Index).Set(t12Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components, in Signature removedSignature)
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
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components, in Signature removedSignature)
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
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, ReadOnlySpan<T10> t10Components, ReadOnlySpan<T11> t11Components, ReadOnlySpan<T12> t12Components, ReadOnlySpan<T13> t13Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(entityReference.Slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(entityReference.Slot.Index).Set(t11Components);
        chunk.WriteBuffer<T12>(entityReference.Slot.Index).Set(t12Components);
        chunk.WriteBuffer<T13>(entityReference.Slot.Index).Set(t13Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, ReadOnlySpan<T10> t10Components, ReadOnlySpan<T11> t11Components, ReadOnlySpan<T12> t12Components, ReadOnlySpan<T13> t13Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(entityReference.Slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(entityReference.Slot.Index).Set(t11Components);
        chunk.WriteBuffer<T12>(entityReference.Slot.Index).Set(t12Components);
        chunk.WriteBuffer<T13>(entityReference.Slot.Index).Set(t13Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components, T13[] t13Components, in Signature removedSignature)
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
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan(), t13Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components, T13[] t13Components, in Signature removedSignature)
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
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan(), t13Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, ReadOnlySpan<T10> t10Components, ReadOnlySpan<T11> t11Components, ReadOnlySpan<T12> t12Components, ReadOnlySpan<T13> t13Components, ReadOnlySpan<T14> t14Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(entityReference.Slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(entityReference.Slot.Index).Set(t11Components);
        chunk.WriteBuffer<T12>(entityReference.Slot.Index).Set(t12Components);
        chunk.WriteBuffer<T13>(entityReference.Slot.Index).Set(t13Components);
        chunk.WriteBuffer<T14>(entityReference.Slot.Index).Set(t14Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, ReadOnlySpan<T10> t10Components, ReadOnlySpan<T11> t11Components, ReadOnlySpan<T12> t12Components, ReadOnlySpan<T13> t13Components, ReadOnlySpan<T14> t14Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(entityReference.Slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(entityReference.Slot.Index).Set(t11Components);
        chunk.WriteBuffer<T12>(entityReference.Slot.Index).Set(t12Components);
        chunk.WriteBuffer<T13>(entityReference.Slot.Index).Set(t13Components);
        chunk.WriteBuffer<T14>(entityReference.Slot.Index).Set(t14Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components, T13[] t13Components, T14[] t14Components, in Signature removedSignature)
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
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan(), t13Components.AsSpan(), t14Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components, T13[] t13Components, T14[] t14Components, in Signature removedSignature)
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
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan(), t13Components.AsSpan(), t14Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, ReadOnlySpan<T10> t10Components, ReadOnlySpan<T11> t11Components, ReadOnlySpan<T12> t12Components, ReadOnlySpan<T13> t13Components, ReadOnlySpan<T14> t14Components, ReadOnlySpan<T15> t15Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(entityReference.Slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(entityReference.Slot.Index).Set(t11Components);
        chunk.WriteBuffer<T12>(entityReference.Slot.Index).Set(t12Components);
        chunk.WriteBuffer<T13>(entityReference.Slot.Index).Set(t13Components);
        chunk.WriteBuffer<T14>(entityReference.Slot.Index).Set(t14Components);
        chunk.WriteBuffer<T15>(entityReference.Slot.Index).Set(t15Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, ReadOnlySpan{T0}, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId, ReadOnlySpan<T0> t0Components, ReadOnlySpan<T1> t1Components, ReadOnlySpan<T2> t2Components, ReadOnlySpan<T3> t3Components, ReadOnlySpan<T4> t4Components, ReadOnlySpan<T5> t5Components, ReadOnlySpan<T6> t6Components, ReadOnlySpan<T7> t7Components, ReadOnlySpan<T8> t8Components, ReadOnlySpan<T9> t9Components, ReadOnlySpan<T10> t10Components, ReadOnlySpan<T11> t11Components, ReadOnlySpan<T12> t12Components, ReadOnlySpan<T13> t13Components, ReadOnlySpan<T14> t14Components, ReadOnlySpan<T15> t15Components, in Signature removedSignature)
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
		var addedSignature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(entityReference.Slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(entityReference.Slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(entityReference.Slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(entityReference.Slot.Index).Set(t11Components);
        chunk.WriteBuffer<T12>(entityReference.Slot.Index).Set(t12Components);
        chunk.WriteBuffer<T13>(entityReference.Slot.Index).Set(t13Components);
        chunk.WriteBuffer<T14>(entityReference.Slot.Index).Set(t14Components);
        chunk.WriteBuffer<T15>(entityReference.Slot.Index).Set(t15Components);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components, T13[] t13Components, T14[] t14Components, T15[] t15Components, in Signature removedSignature)
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
		AddAndRemove(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan(), t13Components.AsSpan(), t14Components.AsSpan(), t15Components.AsSpan(), in removedSignature);
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, T0[], in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components, T13[] t13Components, T14[] t14Components, T15[] t15Components, in Signature removedSignature)
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
		AddAndRemove(entityId, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan(), t13Components.AsSpan(), t14Components.AsSpan(), t15Components.AsSpan(), in removedSignature);
	}
}