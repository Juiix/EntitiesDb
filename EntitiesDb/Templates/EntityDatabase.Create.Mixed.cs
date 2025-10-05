using System;

namespace EntitiesDb;

public partial struct Chunk
{
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default)
		where T1 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0, T1>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0, T1,T2>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,ReadOnlySpan<T1> t1Components = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, t1Components,t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default)
		where T2 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1, T2>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,ReadOnlySpan<T2> t2Components = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1, T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component, t2Components,t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default)
		where T3 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,ReadOnlySpan<T3> t3Components = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2, T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component, t3Components,t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default)
		where T4 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,ReadOnlySpan<T4> t4Components = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3, T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component, t4Components,t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default)
		where T5 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components,t10Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,ReadOnlySpan<T5> t5Components = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4, T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component, t5Components,t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default)
		where T6 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components,t10Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components,t10Components,t11Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,ReadOnlySpan<T6> t6Components = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5, T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component, t6Components,t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default)
		where T7 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components,t10Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components,t10Components,t11Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components,t10Components,t11Components,t12Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,ReadOnlySpan<T7> t7Components = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6, T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component, t7Components,t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default)
		where T8 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components,t10Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components,t10Components,t11Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components,t10Components,t11Components,t12Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components,t10Components,t11Components,t12Components,t13Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,ReadOnlySpan<T8> t8Components = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7, T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component, t8Components,t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default)
		where T9 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components,t10Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components,t10Components,t11Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components,t10Components,t11Components,t12Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components,t10Components,t11Components,t12Components,t13Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components,t10Components,t11Components,t12Components,t13Components,t14Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
		where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,ReadOnlySpan<T9> t9Components = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8, T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component, t9Components,t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default)
		where T10 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component, t10Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component, t10Components,t11Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component, t10Components,t11Components,t12Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component, t10Components,t11Components,t12Components,t13Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component, t10Components,t11Components,t12Components,t13Components,t14Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component, t10Components,t11Components,t12Components,t13Components,t14Components,t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component, t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
		where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component, t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component, t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component, t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component, t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component, t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component, t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,ReadOnlySpan<T10> t10Components = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9, T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component, t10Components,t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default)
		where T11 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component, t11Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component, t11Components,t12Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component, t11Components,t12Components,t13Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component, t11Components,t12Components,t13Components,t14Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component, t11Components,t12Components,t13Components,t14Components,t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component, t11Components,t12Components,t13Components,t14Components,t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component, t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
		where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component, t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component, t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component, t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component, t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component, t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,ReadOnlySpan<T11> t11Components = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component, t11Components,t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default)
		where T12 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component, t12Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component, t12Components,t13Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component, t12Components,t13Components,t14Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component, t12Components,t13Components,t14Components,t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component, t12Components,t13Components,t14Components,t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component, t12Components,t13Components,t14Components,t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component, t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
		where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component, t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component, t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component, t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component, t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,ReadOnlySpan<T12> t12Components = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component, t12Components,t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default)
		where T13 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component, t13Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component, t13Components,t14Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component, t13Components,t14Components,t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component, t13Components,t14Components,t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component, t13Components,t14Components,t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component, t13Components,t14Components,t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component, t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
		where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component, t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component, t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component, t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,ReadOnlySpan<T13> t13Components = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component, t13Components,t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default)
		where T14 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component, t14Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component, t14Components,t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component, t14Components,t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component, t14Components,t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component, t14Components,t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component, t14Components,t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component, t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
		where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component, t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component, t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,ReadOnlySpan<T14> t14Components = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component, t14Components,t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default)
		where T15 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component, t15Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component, t15Components,t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component, t15Components,t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component, t15Components,t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component, t15Components,t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component, t15Components,t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component, t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
		where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component, t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,ReadOnlySpan<T15> t15Components = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
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
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, T15,T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component, t15Components,t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default)
		where T16 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component, t16Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16,T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16,T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component, t16Components,t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16,T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16,T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component, t16Components,t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16,T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16,T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component, t16Components,t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16,T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16,T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component, t16Components,t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16,T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16,T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component, t16Components,t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16,T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16,T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component, t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,ReadOnlySpan<T16> t16Components = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
		where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16,T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, T16,T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component, t16Components,t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,ReadOnlySpan<T17> t17Components = default)
		where T17 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component, t17Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, T17,T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, T17,T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component, t17Components,t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, T17,T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, T17,T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component, t17Components,t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, T17,T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, T17,T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component, t17Components,t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, T17,T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, T17,T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component, t17Components,t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, T17,T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, T17,T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component, t17Components,t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,ReadOnlySpan<T17> t17Components = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
		where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, T17,T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, T17,T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component, t17Components,t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,ReadOnlySpan<T18> t18Components = default)
		where T18 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17, T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17, T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component, t18Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17, T18,T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17, T18,T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component, t18Components,t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17, T18,T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17, T18,T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component, t18Components,t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17, T18,T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17, T18,T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component, t18Components,t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17, T18,T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17, T18,T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component, t18Components,t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,ReadOnlySpan<T18> t18Components = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
		where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17, T18,T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17, T18,T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component, t18Components,t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,ReadOnlySpan<T19> t19Components = default)
		where T19 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18, T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18, T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component, t19Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default)
		where T19 : unmanaged
        where T20 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18, T19,T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18, T19,T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component, t19Components,t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
		where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18, T19,T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18, T19,T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component, t19Components,t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
		where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18, T19,T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18, T19,T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component, t19Components,t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,ReadOnlySpan<T19> t19Components = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
		where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18, T19,T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18, T19,T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component, t19Components,t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,ReadOnlySpan<T20> t20Components = default)
		where T20 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19, T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19, T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component, t20Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default)
		where T20 : unmanaged
        where T21 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19, T20,T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19, T20,T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component, t20Components,t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
		where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19, T20,T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19, T20,T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component, t20Components,t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,ReadOnlySpan<T20> t20Components = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
		where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19, T20,T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19, T20,T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component, t20Components,t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,ReadOnlySpan<T21> t21Components = default)
		where T21 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20, T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20, T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component, t21Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default)
		where T21 : unmanaged
        where T22 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20, T21,T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20, T21,T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component, t21Components,t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,ReadOnlySpan<T21> t21Components = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
		where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20, T21,T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20, T21,T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component, t21Components,t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,in T21? t21Component = default,ReadOnlySpan<T22> t22Components = default)
		where T22 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21, T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21, T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component, t22Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,in T21? t21Component = default,ReadOnlySpan<T22> t22Components = default,ReadOnlySpan<T23> t23Components = default)
		where T22 : unmanaged
        where T23 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21, T22,T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21, T22,T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component, t22Components,t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	public Entity Create<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,in T21? t21Component = default,in T22? t22Component = default,ReadOnlySpan<T23> t23Components = default)
		where T23 : unmanaged
	{
		var signature = ComponentRegistry.GetSignature<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22, T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22, T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component,in t22Component, t23Components);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
}