
using System;

namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default)
		where T1 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1>(in ids);
		var cOffsets = new Offsets<T0>(offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1>(offsets.T1);
        chunk.Init(slot.Index, in bOffsets, t1Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1>(in BulkCreate<T0, T1> bulk, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default)
		where T1 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0>(bulk.Offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1>(bulk.Offsets.T1);
        chunk.Init(slot.Index, in bOffsets, t1Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2>(in ids);
		var cOffsets = new Offsets<T0>(offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2>(offsets.T1, offsets.T2);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2>(in BulkCreate<T0, T1, T2> bulk, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0>(bulk.Offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2>(bulk.Offsets.T1, bulk.Offsets.T2);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3>(in ids);
		var cOffsets = new Offsets<T0>(offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2, T3>(offsets.T1, offsets.T2, offsets.T3);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components, t3Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3>(in BulkCreate<T0, T1, T2, T3> bulk, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0>(bulk.Offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2, T3>(bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components, t3Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4>(in ids);
		var cOffsets = new Offsets<T0>(offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2, T3, T4>(offsets.T1, offsets.T2, offsets.T3, offsets.T4);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components, t3Components, t4Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4>(in BulkCreate<T0, T1, T2, T3, T4> bulk, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0>(bulk.Offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2, T3, T4>(bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components, t3Components, t4Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5>(in ids);
		var cOffsets = new Offsets<T0>(offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2, T3, T4, T5>(offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components, t3Components, t4Components, t5Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in BulkCreate<T0, T1, T2, T3, T4, T5> bulk, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0>(bulk.Offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2, T3, T4, T5>(bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components, t3Components, t4Components, t5Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6>(in ids);
		var cOffsets = new Offsets<T0>(offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2, T3, T4, T5, T6>(offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5, offsets.T6);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6> bulk, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0>(bulk.Offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2, T3, T4, T5, T6>(bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
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
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7>(in ids);
		var cOffsets = new Offsets<T0>(offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2, T3, T4, T5, T6, T7>(offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5, offsets.T6, offsets.T7);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7> bulk, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
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
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0>(bulk.Offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2, T3, T4, T5, T6, T7>(bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
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
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in ids);
		var cOffsets = new Offsets<T0>(offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2, T3, T4, T5, T6, T7, T8>(offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5, offsets.T6, offsets.T7, offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8> bulk, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
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
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0>(bulk.Offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2, T3, T4, T5, T6, T7, T8>(bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7, bulk.Offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in ids);
		var cOffsets = new Offsets<T0>(offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2, T3, T4, T5, T6, T7, T8, T9>(offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5, offsets.T6, offsets.T7, offsets.T8, offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> bulk, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0>(bulk.Offsets.T0);
        chunk.Set(slot.Index, in cOffsets, in t0Component);
		var bOffsets = new Offsets<T1, T2, T3, T4, T5, T6, T7, T8, T9>(bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7, bulk.Offsets.T8, bulk.Offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default)
		where T2 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2>(in ids);
		var cOffsets = new Offsets<T0, T1>(offsets.T0, offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2>(offsets.T2);
        chunk.Init(slot.Index, in bOffsets, t2Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2>(in BulkCreate<T0, T1, T2> bulk, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default)
		where T2 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1>(bulk.Offsets.T0, bulk.Offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2>(bulk.Offsets.T2);
        chunk.Init(slot.Index, in bOffsets, t2Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3>(in ids);
		var cOffsets = new Offsets<T0, T1>(offsets.T0, offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2, T3>(offsets.T2, offsets.T3);
        chunk.Init(slot.Index, in bOffsets, t2Components, t3Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3>(in BulkCreate<T0, T1, T2, T3> bulk, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1>(bulk.Offsets.T0, bulk.Offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2, T3>(bulk.Offsets.T2, bulk.Offsets.T3);
        chunk.Init(slot.Index, in bOffsets, t2Components, t3Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4>(in ids);
		var cOffsets = new Offsets<T0, T1>(offsets.T0, offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2, T3, T4>(offsets.T2, offsets.T3, offsets.T4);
        chunk.Init(slot.Index, in bOffsets, t2Components, t3Components, t4Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4>(in BulkCreate<T0, T1, T2, T3, T4> bulk, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1>(bulk.Offsets.T0, bulk.Offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2, T3, T4>(bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4);
        chunk.Init(slot.Index, in bOffsets, t2Components, t3Components, t4Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5>(in ids);
		var cOffsets = new Offsets<T0, T1>(offsets.T0, offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2, T3, T4, T5>(offsets.T2, offsets.T3, offsets.T4, offsets.T5);
        chunk.Init(slot.Index, in bOffsets, t2Components, t3Components, t4Components, t5Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in BulkCreate<T0, T1, T2, T3, T4, T5> bulk, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1>(bulk.Offsets.T0, bulk.Offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2, T3, T4, T5>(bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5);
        chunk.Init(slot.Index, in bOffsets, t2Components, t3Components, t4Components, t5Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6>(in ids);
		var cOffsets = new Offsets<T0, T1>(offsets.T0, offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2, T3, T4, T5, T6>(offsets.T2, offsets.T3, offsets.T4, offsets.T5, offsets.T6);
        chunk.Init(slot.Index, in bOffsets, t2Components, t3Components, t4Components, t5Components, t6Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6> bulk, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1>(bulk.Offsets.T0, bulk.Offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2, T3, T4, T5, T6>(bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6);
        chunk.Init(slot.Index, in bOffsets, t2Components, t3Components, t4Components, t5Components, t6Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7>(in ids);
		var cOffsets = new Offsets<T0, T1>(offsets.T0, offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2, T3, T4, T5, T6, T7>(offsets.T2, offsets.T3, offsets.T4, offsets.T5, offsets.T6, offsets.T7);
        chunk.Init(slot.Index, in bOffsets, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7> bulk, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1>(bulk.Offsets.T0, bulk.Offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2, T3, T4, T5, T6, T7>(bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7);
        chunk.Init(slot.Index, in bOffsets, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
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
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in ids);
		var cOffsets = new Offsets<T0, T1>(offsets.T0, offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2, T3, T4, T5, T6, T7, T8>(offsets.T2, offsets.T3, offsets.T4, offsets.T5, offsets.T6, offsets.T7, offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8> bulk, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
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
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1>(bulk.Offsets.T0, bulk.Offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2, T3, T4, T5, T6, T7, T8>(bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7, bulk.Offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in ids);
		var cOffsets = new Offsets<T0, T1>(offsets.T0, offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2, T3, T4, T5, T6, T7, T8, T9>(offsets.T2, offsets.T3, offsets.T4, offsets.T5, offsets.T6, offsets.T7, offsets.T8, offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> bulk, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1>(bulk.Offsets.T0, bulk.Offsets.T1);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component);
		var bOffsets = new Offsets<T2, T3, T4, T5, T6, T7, T8, T9>(bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7, bulk.Offsets.T8, bulk.Offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default)
		where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3>(in ids);
		var cOffsets = new Offsets<T0, T1, T2>(offsets.T0, offsets.T1, offsets.T2);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component);
		var bOffsets = new Offsets<T3>(offsets.T3);
        chunk.Init(slot.Index, in bOffsets, t3Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3>(in BulkCreate<T0, T1, T2, T3> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default)
		where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component);
		var bOffsets = new Offsets<T3>(bulk.Offsets.T3);
        chunk.Init(slot.Index, in bOffsets, t3Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4>(in ids);
		var cOffsets = new Offsets<T0, T1, T2>(offsets.T0, offsets.T1, offsets.T2);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component);
		var bOffsets = new Offsets<T3, T4>(offsets.T3, offsets.T4);
        chunk.Init(slot.Index, in bOffsets, t3Components, t4Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4>(in BulkCreate<T0, T1, T2, T3, T4> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component);
		var bOffsets = new Offsets<T3, T4>(bulk.Offsets.T3, bulk.Offsets.T4);
        chunk.Init(slot.Index, in bOffsets, t3Components, t4Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5>(in ids);
		var cOffsets = new Offsets<T0, T1, T2>(offsets.T0, offsets.T1, offsets.T2);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component);
		var bOffsets = new Offsets<T3, T4, T5>(offsets.T3, offsets.T4, offsets.T5);
        chunk.Init(slot.Index, in bOffsets, t3Components, t4Components, t5Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in BulkCreate<T0, T1, T2, T3, T4, T5> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component);
		var bOffsets = new Offsets<T3, T4, T5>(bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5);
        chunk.Init(slot.Index, in bOffsets, t3Components, t4Components, t5Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6>(in ids);
		var cOffsets = new Offsets<T0, T1, T2>(offsets.T0, offsets.T1, offsets.T2);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component);
		var bOffsets = new Offsets<T3, T4, T5, T6>(offsets.T3, offsets.T4, offsets.T5, offsets.T6);
        chunk.Init(slot.Index, in bOffsets, t3Components, t4Components, t5Components, t6Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component);
		var bOffsets = new Offsets<T3, T4, T5, T6>(bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6);
        chunk.Init(slot.Index, in bOffsets, t3Components, t4Components, t5Components, t6Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7>(in ids);
		var cOffsets = new Offsets<T0, T1, T2>(offsets.T0, offsets.T1, offsets.T2);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component);
		var bOffsets = new Offsets<T3, T4, T5, T6, T7>(offsets.T3, offsets.T4, offsets.T5, offsets.T6, offsets.T7);
        chunk.Init(slot.Index, in bOffsets, t3Components, t4Components, t5Components, t6Components, t7Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component);
		var bOffsets = new Offsets<T3, T4, T5, T6, T7>(bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7);
        chunk.Init(slot.Index, in bOffsets, t3Components, t4Components, t5Components, t6Components, t7Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in ids);
		var cOffsets = new Offsets<T0, T1, T2>(offsets.T0, offsets.T1, offsets.T2);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component);
		var bOffsets = new Offsets<T3, T4, T5, T6, T7, T8>(offsets.T3, offsets.T4, offsets.T5, offsets.T6, offsets.T7, offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component);
		var bOffsets = new Offsets<T3, T4, T5, T6, T7, T8>(bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7, bulk.Offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in ids);
		var cOffsets = new Offsets<T0, T1, T2>(offsets.T0, offsets.T1, offsets.T2);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component);
		var bOffsets = new Offsets<T3, T4, T5, T6, T7, T8, T9>(offsets.T3, offsets.T4, offsets.T5, offsets.T6, offsets.T7, offsets.T8, offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component);
		var bOffsets = new Offsets<T3, T4, T5, T6, T7, T8, T9>(bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7, bulk.Offsets.T8, bulk.Offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default)
		where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3>(offsets.T0, offsets.T1, offsets.T2, offsets.T3);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component);
		var bOffsets = new Offsets<T4>(offsets.T4);
        chunk.Init(slot.Index, in bOffsets, t4Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4>(in BulkCreate<T0, T1, T2, T3, T4> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default)
		where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component);
		var bOffsets = new Offsets<T4>(bulk.Offsets.T4);
        chunk.Init(slot.Index, in bOffsets, t4Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3>(offsets.T0, offsets.T1, offsets.T2, offsets.T3);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component);
		var bOffsets = new Offsets<T4, T5>(offsets.T4, offsets.T5);
        chunk.Init(slot.Index, in bOffsets, t4Components, t5Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in BulkCreate<T0, T1, T2, T3, T4, T5> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component);
		var bOffsets = new Offsets<T4, T5>(bulk.Offsets.T4, bulk.Offsets.T5);
        chunk.Init(slot.Index, in bOffsets, t4Components, t5Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3>(offsets.T0, offsets.T1, offsets.T2, offsets.T3);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component);
		var bOffsets = new Offsets<T4, T5, T6>(offsets.T4, offsets.T5, offsets.T6);
        chunk.Init(slot.Index, in bOffsets, t4Components, t5Components, t6Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component);
		var bOffsets = new Offsets<T4, T5, T6>(bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6);
        chunk.Init(slot.Index, in bOffsets, t4Components, t5Components, t6Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3>(offsets.T0, offsets.T1, offsets.T2, offsets.T3);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component);
		var bOffsets = new Offsets<T4, T5, T6, T7>(offsets.T4, offsets.T5, offsets.T6, offsets.T7);
        chunk.Init(slot.Index, in bOffsets, t4Components, t5Components, t6Components, t7Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component);
		var bOffsets = new Offsets<T4, T5, T6, T7>(bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7);
        chunk.Init(slot.Index, in bOffsets, t4Components, t5Components, t6Components, t7Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3>(offsets.T0, offsets.T1, offsets.T2, offsets.T3);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component);
		var bOffsets = new Offsets<T4, T5, T6, T7, T8>(offsets.T4, offsets.T5, offsets.T6, offsets.T7, offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t4Components, t5Components, t6Components, t7Components, t8Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component);
		var bOffsets = new Offsets<T4, T5, T6, T7, T8>(bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7, bulk.Offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t4Components, t5Components, t6Components, t7Components, t8Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3>(offsets.T0, offsets.T1, offsets.T2, offsets.T3);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component);
		var bOffsets = new Offsets<T4, T5, T6, T7, T8, T9>(offsets.T4, offsets.T5, offsets.T6, offsets.T7, offsets.T8, offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component);
		var bOffsets = new Offsets<T4, T5, T6, T7, T8, T9>(bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7, bulk.Offsets.T8, bulk.Offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default)
		where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
		var bOffsets = new Offsets<T5>(offsets.T5);
        chunk.Init(slot.Index, in bOffsets, t5Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in BulkCreate<T0, T1, T2, T3, T4, T5> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default)
		where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
		var bOffsets = new Offsets<T5>(bulk.Offsets.T5);
        chunk.Init(slot.Index, in bOffsets, t5Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
		var bOffsets = new Offsets<T5, T6>(offsets.T5, offsets.T6);
        chunk.Init(slot.Index, in bOffsets, t5Components, t6Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
		var bOffsets = new Offsets<T5, T6>(bulk.Offsets.T5, bulk.Offsets.T6);
        chunk.Init(slot.Index, in bOffsets, t5Components, t6Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
		var bOffsets = new Offsets<T5, T6, T7>(offsets.T5, offsets.T6, offsets.T7);
        chunk.Init(slot.Index, in bOffsets, t5Components, t6Components, t7Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
		var bOffsets = new Offsets<T5, T6, T7>(bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7);
        chunk.Init(slot.Index, in bOffsets, t5Components, t6Components, t7Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
		var bOffsets = new Offsets<T5, T6, T7, T8>(offsets.T5, offsets.T6, offsets.T7, offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t5Components, t6Components, t7Components, t8Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
		var bOffsets = new Offsets<T5, T6, T7, T8>(bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7, bulk.Offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t5Components, t6Components, t7Components, t8Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
		var bOffsets = new Offsets<T5, T6, T7, T8, T9>(offsets.T5, offsets.T6, offsets.T7, offsets.T8, offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t5Components, t6Components, t7Components, t8Components, t9Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
		var bOffsets = new Offsets<T5, T6, T7, T8, T9>(bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7, bulk.Offsets.T8, bulk.Offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t5Components, t6Components, t7Components, t8Components, t9Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default)
		where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
		var bOffsets = new Offsets<T6>(offsets.T6);
        chunk.Init(slot.Index, in bOffsets, t6Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default)
		where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
		var bOffsets = new Offsets<T6>(bulk.Offsets.T6);
        chunk.Init(slot.Index, in bOffsets, t6Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
		var bOffsets = new Offsets<T6, T7>(offsets.T6, offsets.T7);
        chunk.Init(slot.Index, in bOffsets, t6Components, t7Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
		var bOffsets = new Offsets<T6, T7>(bulk.Offsets.T6, bulk.Offsets.T7);
        chunk.Init(slot.Index, in bOffsets, t6Components, t7Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
		var bOffsets = new Offsets<T6, T7, T8>(offsets.T6, offsets.T7, offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t6Components, t7Components, t8Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
		var bOffsets = new Offsets<T6, T7, T8>(bulk.Offsets.T6, bulk.Offsets.T7, bulk.Offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t6Components, t7Components, t8Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
		var bOffsets = new Offsets<T6, T7, T8, T9>(offsets.T6, offsets.T7, offsets.T8, offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t6Components, t7Components, t8Components, t9Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
		var bOffsets = new Offsets<T6, T7, T8, T9>(bulk.Offsets.T6, bulk.Offsets.T7, bulk.Offsets.T8, bulk.Offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t6Components, t7Components, t8Components, t9Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default)
		where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5, T6>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5, offsets.T6);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);
		var bOffsets = new Offsets<T7>(offsets.T7);
        chunk.Init(slot.Index, in bOffsets, t7Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default)
		where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5, T6>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);
		var bOffsets = new Offsets<T7>(bulk.Offsets.T7);
        chunk.Init(slot.Index, in bOffsets, t7Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5, T6>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5, offsets.T6);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);
		var bOffsets = new Offsets<T7, T8>(offsets.T7, offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t7Components, t8Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5, T6>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);
		var bOffsets = new Offsets<T7, T8>(bulk.Offsets.T7, bulk.Offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t7Components, t8Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5, T6>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5, offsets.T6);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);
		var bOffsets = new Offsets<T7, T8, T9>(offsets.T7, offsets.T8, offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t7Components, t8Components, t9Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5, T6>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);
		var bOffsets = new Offsets<T7, T8, T9>(bulk.Offsets.T7, bulk.Offsets.T8, bulk.Offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t7Components, t8Components, t9Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default)
		where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5, T6, T7>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5, offsets.T6, offsets.T7);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);
		var bOffsets = new Offsets<T8>(offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t8Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default)
		where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5, T6, T7>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);
		var bOffsets = new Offsets<T8>(bulk.Offsets.T8);
        chunk.Init(slot.Index, in bOffsets, t8Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5, T6, T7>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5, offsets.T6, offsets.T7);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);
		var bOffsets = new Offsets<T8, T9>(offsets.T8, offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t8Components, t9Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5, T6, T7>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);
		var bOffsets = new Offsets<T8, T9>(bulk.Offsets.T8, bulk.Offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t8Components, t9Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default)
		where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offsets = archetype.GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in ids);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8>(offsets.T0, offsets.T1, offsets.T2, offsets.T3, offsets.T4, offsets.T5, offsets.T6, offsets.T7, offsets.T8);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);
		var bOffsets = new Offsets<T9>(offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t9Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in ArchetypeIds{T0}, in T0?)"/>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> bulk, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default)
		where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		var cOffsets = new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8>(bulk.Offsets.T0, bulk.Offsets.T1, bulk.Offsets.T2, bulk.Offsets.T3, bulk.Offsets.T4, bulk.Offsets.T5, bulk.Offsets.T6, bulk.Offsets.T7, bulk.Offsets.T8);
        chunk.Set(slot.Index, in cOffsets, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);
		var bOffsets = new Offsets<T9>(bulk.Offsets.T9);
        chunk.Init(slot.Index, in bOffsets, t9Components);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
}