
using System;

namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		var signature = ComponentBuffer<T0, T1>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1>(T0[] t0Components, T1[] t1Components)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		return Create(t0Components.AsSpan(), t1Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		var signature = ComponentBuffer<T0, T1, T2>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(slot.Index).Set(t2Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2>(T0[] t0Components, T1[] t1Components, T2[] t2Components)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		return Create(t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var signature = ComponentBuffer<T0, T1, T2, T3>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(slot.Index).Set(t3Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3>(T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		return Create(t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var signature = ComponentBuffer<T0, T1, T2, T3, T4>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(slot.Index).Set(t4Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4>(T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		return Create(t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var signature = ComponentBuffer<T0, T1, T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(slot.Index).Set(t5Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		return Create(t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var signature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(slot.Index).Set(t6Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		return Create(t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var signature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(slot.Index).Set(t7Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		return Create(t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
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
		var signature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(slot.Index).Set(t8Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components)
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
		return Create(t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		var signature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(slot.Index).Set(t9Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components)
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
		return Create(t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
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
		var signature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(slot.Index).Set(t10Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components)
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
		return Create(t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
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
		var signature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(slot.Index).Set(t11Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components)
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
		return Create(t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
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
		var signature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(slot.Index).Set(t11Components);
        chunk.WriteBuffer<T12>(slot.Index).Set(t12Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components)
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
		return Create(t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
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
		var signature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(slot.Index).Set(t11Components);
        chunk.WriteBuffer<T12>(slot.Index).Set(t12Components);
        chunk.WriteBuffer<T13>(slot.Index).Set(t13Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components, T13[] t13Components)
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
		return Create(t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan(), t13Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
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
		var signature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(slot.Index).Set(t11Components);
        chunk.WriteBuffer<T12>(slot.Index).Set(t12Components);
        chunk.WriteBuffer<T13>(slot.Index).Set(t13Components);
        chunk.WriteBuffer<T14>(slot.Index).Set(t14Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components, T13[] t13Components, T14[] t14Components)
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
		return Create(t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan(), t13Components.AsSpan(), t14Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
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
		var signature = ComponentBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(slot.Index).Set(t7Components);
        chunk.WriteBuffer<T8>(slot.Index).Set(t8Components);
        chunk.WriteBuffer<T9>(slot.Index).Set(t9Components);
        chunk.WriteBuffer<T10>(slot.Index).Set(t10Components);
        chunk.WriteBuffer<T11>(slot.Index).Set(t11Components);
        chunk.WriteBuffer<T12>(slot.Index).Set(t12Components);
        chunk.WriteBuffer<T13>(slot.Index).Set(t13Components);
        chunk.WriteBuffer<T14>(slot.Index).Set(t14Components);
        chunk.WriteBuffer<T15>(slot.Index).Set(t15Components);
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components, T13[] t13Components, T14[] t14Components, T15[] t15Components)
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
		return Create(t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan(), t13Components.AsSpan(), t14Components.AsSpan(), t15Components.AsSpan());
	}
}