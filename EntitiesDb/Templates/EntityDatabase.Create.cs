
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1>(in T0? t0Component, in T1? t1Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2>(in T0? t0Component, in T1? t1Component, in T2? t2Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component, in T17? t17Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component, in T17? t17Component, in T18? t18Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component, in T17? t17Component, in T18? t18Component, in T19? t19Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component, in T17? t17Component, in T18? t18Component, in T19? t19Component, in T20? t20Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component, in T17? t17Component, in T18? t18Component, in T19? t19Component, in T20? t20Component, in T21? t21Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component, in T17? t17Component, in T18? t18Component, in T19? t19Component, in T20? t20Component, in T21? t21Component, in T22? t22Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component, in t22Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
	/// <inheritdoc cref="Create{T0}(in T0?)"/>
	[StructuralChange]
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in T16? t16Component, in T17? t17Component, in T18? t18Component, in T19? t19Component, in T20? t20Component, in T21? t21Component, in T22? t22Component, in T23? t23Component)
	{
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
        chunk.Set(dstSlot.Index, in ids, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, in t9Component, in t10Component, in t11Component, in t12Component, in t13Component, in t14Component, in t15Component, in t16Component, in t17Component, in t18Component, in t19Component, in t20Component, in t21Component, in t22Component, in t23Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}
}