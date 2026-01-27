
using System;

namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		_ = ComponentBufferWritable<T0, T1>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1>(Entity entity, T0[] t0Components, T1[] t1Components)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan());
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		_ = ComponentBufferWritable<T0, T1, T2>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan());
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		_ = ComponentBufferWritable<T0, T1, T2, T3>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan());
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		_ = ComponentBufferWritable<T0, T1, T2, T3, T4>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan());
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		_ = ComponentBufferWritable<T0, T1, T2, T3, T4, T5>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan());
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		_ = ComponentBufferWritable<T0, T1, T2, T3, T4, T5, T6>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan());
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		_ = ComponentBufferWritable<T0, T1, T2, T3, T4, T5, T6, T7>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
        chunk.WriteBuffer<T1>(entityReference.Slot.Index).Set(t1Components);
        chunk.WriteBuffer<T2>(entityReference.Slot.Index).Set(t2Components);
        chunk.WriteBuffer<T3>(entityReference.Slot.Index).Set(t3Components);
        chunk.WriteBuffer<T4>(entityReference.Slot.Index).Set(t4Components);
        chunk.WriteBuffer<T5>(entityReference.Slot.Index).Set(t5Components);
        chunk.WriteBuffer<T6>(entityReference.Slot.Index).Set(t6Components);
        chunk.WriteBuffer<T7>(entityReference.Slot.Index).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan());
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
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
		_ = ComponentBufferWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
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
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components)
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
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		_ = ComponentBufferWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
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
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components)
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
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
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
		_ = ComponentBufferWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
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
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components)
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
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan());
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
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
		_ = ComponentBufferWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
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
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components)
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
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan());
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
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
		_ = ComponentBufferWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
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
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components)
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
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan());
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
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
		_ = ComponentBufferWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
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
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components, T13[] t13Components)
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
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan(), t13Components.AsSpan());
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
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
		_ = ComponentBufferWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
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
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components, T13[] t13Components, T14[] t14Components)
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
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan(), t13Components.AsSpan(), t14Components.AsSpan());
	}
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity, ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
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
		_ = ComponentBufferWritable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Check;
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
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
	/// <inheritdoc cref="Set{T0}(Entity, ReadOnlySpan{T0})"/>
	[ChunkChange]
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity, T0[] t0Components, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components, T10[] t10Components, T11[] t11Components, T12[] t12Components, T13[] t13Components, T14[] t14Components, T15[] t15Components)
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
		Set(entity, t0Components.AsSpan(), t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan(), t10Components.AsSpan(), t11Components.AsSpan(), t12Components.AsSpan(), t13Components.AsSpan(), t14Components.AsSpan(), t15Components.AsSpan());
	}
}