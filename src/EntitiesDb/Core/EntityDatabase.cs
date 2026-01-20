using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace EntitiesDb;

/// <summary>
/// An Archetype and Chunk based entity component database.
/// Stores entities with the same components in tight arrays for enumeration and cache friendliness.
/// </summary>
public sealed partial class EntityDatabase : IDisposable
{
	private readonly EntityMap _entityMap;
	private Queue<Entity> _recycledEntityIds = [];
	private readonly int[] _globalChangeVersions = new int[ComponentRegistry.MaxComponents];

	/// <summary>
	/// Creates a new <see cref="EntityDatabase"/> instance
	/// </summary>
	/// <param name="chunkByteSize">The size in bytes of a chunk</param>
	/// <param name="maxEntities">The maximum entities to store</param>
	/// <param name="parallelRunner">The <see cref="ParallelJobRunner"/> used for parallel support</param>
	/// <exception cref="ArgumentOutOfRangeException"></exception>
	public EntityDatabase(EntityDatabaseOptions options)
	{
		if (options.ChunkByteSize <= 0) throw new ArgumentOutOfRangeException(nameof(options.ChunkByteSize), "Value cannot by less than or equal to 0");
		if (options.MaxEntities <= 0) throw new ArgumentOutOfRangeException(nameof(options.MaxEntities), "Value cannot by less than or equal to 0");

		_entityMap = new(options.MaxEntities);
        ComponentRegistry = new();
        Archetypes = new(ComponentRegistry, options.ChunkByteSize, _globalChangeVersions);
		MaxEntities = options.MaxEntities;
		ParallelRunner = options.ParallelThreads > 1 ? new ParallelJobRunner(options.ParallelThreads) : null;
		QueryBuilder = new(Archetypes, ComponentRegistry, ParallelRunner, _globalChangeVersions);
	}

	/// <summary>
	/// The amount of entities currently stored
	/// </summary>
	public int EntityCount { get; private set; }

	/// <summary>
	/// The maximum amount of entities that can be stored in the database
	/// </summary>
	public int MaxEntities { get; }

	/// <summary>
	/// All archetypes
	/// </summary>
	public ArchetypeCollection Archetypes { get; }

	/// <summary>
	/// Registry for component types and ids
	/// </summary>
	public ComponentRegistry ComponentRegistry { get; }

	/// <summary>
	/// A re-usable query builder
	/// </summary>
	public QueryBuilder QueryBuilder { get; }

	/// <summary>
	/// Enables parallel jobs
	/// </summary>
	internal ParallelJobRunner? ParallelRunner { get; }

	/// <summary>
	/// Adds a component to an entity. Entity components are copied to a new <see cref="Archetype"/>.
	/// </summary>
	/// <remarks>
	/// Use <see cref="Set{T0}(Entity, T0)"/> if a component is already attached to the entity.
	/// </remarks>
	/// <param name="entityId">Id of the entity altered</param>
	/// <param name="component">Component value</param>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0>(Entity entity, in T0? component = default)
	{
		ComponentMeta.AssertNotBuffered<T0>();
		var ids = ComponentRegistry.GetIds<T0>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Has(in ids))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in component);
	}

	/// <summary>
	/// Adds component buffers to an entity. Entity components are copied to a new <see cref="Archetype"/>.
	/// </summary>
	/// <remarks>
	/// Use <see cref="Set{T0}(Entity, ReadOnlySpan{T0})"/> if a component buffer is already attached to the entity.
	/// </remarks>
	/// <param name="entity">The target entity</param>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0>(Entity entity, ReadOnlySpan<T0> components = default) where T0 : unmanaged
    {
        ComponentMeta.AssertBuffered<T0>();
        var ids = ComponentRegistry.GetIds<T0>();
		var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Has(in ids))
            throw srcArchetype.GetComponentAlreadyAdded(entity.Id, in ids);

		var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// buffers must be initialized for first use since
		// SetBuffer relies on internal state
		dstArchetype.Init(in entityReference.Slot, in ids, components);
	}

	/// <summary>
	/// Clones an existing entity and its components
	/// </summary>
	/// <param name="entity">The target entity</param>
	/// <returns>Id of the cloned entity</returns>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="MaxReachedException"></exception>
	[StructuralChange]
	[ChunkChange]
	public Entity Clone(Entity entity)
	{
		// get entity
		ref var srcReference = ref GetEntity(entity);

		// get id & copy components
		var archetype = srcReference.Archetype;
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var dstSlot = archetype.AddEntity(dstEntityId, out _);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		archetype.CloneComponents(in srcReference.Slot, in dstSlot);
		EntityCount++;

		return dstEntityId;
	}

	/// <summary>
	/// Creates an empty entity
	/// </summary>
	/// <returns>Id of the created entity</returns>
	/// <exception cref="MaxReachedException"></exception>
	[StructuralChange]
	[ChunkChange]
	public Entity Create()
	{
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(Signature.Empty);
		var dstSlot = archetype.AddEntity(dstEntityId, out _);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}

	/// <summary>
	/// Creates an entity with components
	/// </summary>
	/// <returns>Id of the created entity</returns>
	/// <exception cref="MaxReachedException"></exception>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0>(in T0? t0Component = default)
	{
        ComponentMeta.AssertNotBuffered<T0>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var ids = ComponentRegistry.GetIds<T0>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		var offset = archetype.GetOffset<T0>(ids.T0);
        chunk.Set(slot.Index, offset, in t0Component);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}

	/// <summary>
	/// Creates an entity with components, using a prepared archetype id pairing
	/// </summary>
	/// <returns>Id of the created entity</returns>
	/// <exception cref="MaxReachedException"></exception>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0>(in BulkCreate<T0> bulk, in T0? t0Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var slot = bulk.Archetype.AddEntity(dstEntityId, out var chunk);
		chunk.Set(slot.Index, bulk.Offsets.T0, in t0Component);
		dstReference = new EntityReference(bulk.Archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}

	/// <summary>
	/// Destroys a given entity
	/// </summary>
	/// <param name="entity">The target entity</param>
	/// <exception cref="EntityException"></exception>
	[StructuralChange]
	public void Destroy(Entity entity)
	{
		// get entity
		ref var entityReference = ref GetEntity(entity);
		var archetype = entityReference.Archetype;
		archetype.ClearBuffers(in entityReference.Slot, archetype.Signature);
		archetype.RemoveEntity(in entityReference.Slot, out var movedEntityId);

		_entityMap.Move(movedEntityId, in entityReference.Slot);
		_entityMap.Remove(entity.Id);
		EntityCount--;
		_recycledEntityIds.Enqueue(entity);
	}

	/// <summary>
	/// Returns if an entity exists at a given id
	/// </summary>
	/// <param name="entity">Entity to check</param>
	/// <returns>If an entity exists at the given id &amp; the <see cref="Entity.Version"/> is the same.</returns>
	public bool Exists(Entity entity)
	{
		ref var entityReference = ref _entityMap.TryGetReference(entity.Id, out var foundEntity);
		return foundEntity &&
			entityReference.Version == entity.Version;
	}

	/// <summary>
	/// Returns a readonly reference to a component for an entity.
	/// Ref values may be invalid after structural changes and should not be stored.
	/// </summary>
	/// <typeparam name="T0">Component type</typeparam>
	/// <param name="entity">The target entity</param>
	/// <returns>Reference to the component for the given entity</returns>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	public ref readonly T0? Read<T0>(Entity entity)
	{
		ComponentMeta.AssertNotBuffered<T0>();
		var ids = ComponentRegistry.GetIds<T0>();
		ref var entityReference = ref GetEntity(entity);

		// check if has component
		if (!entityReference.Archetype.Has(in ids))
			throw ThrowHelper.ComponentNotFound(entity.Id, typeof(T0));

		ref readonly var component = ref entityReference.Archetype.Read<T0>(in entityReference.Slot, ids.T0);
		return ref component;
	}

	/// <summary>
	/// Returns a readonly component buffer for an entity.
	/// Buffer is invalid after structural changes and should not be stored.
	/// </summary>
	/// <typeparam name="T0">Component type</typeparam>
	/// <param name="entity">The target entity</param>
	/// <returns>Component buffer for the given entity</returns>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	public ReadBuffer<T0> ReadBuffer<T0>(Entity entity) where T0 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0>();
		var ids = ComponentRegistry.GetIds<T0>();
		ref var entityReference = ref GetEntity(entity);

		// check if has component
		if (!entityReference.Archetype.Has(in ids))
			throw ThrowHelper.ComponentNotFound(entity.Id, typeof(T0));

		var buffer = entityReference.Archetype.ReadBuffer<T0>(in entityReference.Slot, ids.T0);
		return buffer;
	}

	/// <summary>
	/// Returns a reference to a component for an entity.
	/// Ref values may be invalid after structural changes and should not be stored.
	/// </summary>
	/// <remarks>
	/// Marks the accessed <see cref="Chunk"/> as changed.
	/// </remarks>
	/// <typeparam name="T0">Component type</typeparam>
	/// <param name="entity">The target entity</param>
	/// <returns>Reference to the component for the given entity</returns>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	[ChunkChange]
	public ref T0? Write<T0>(Entity entity)
	{
		ComponentMeta.AssertNotBuffered<T0>();
		var ids = ComponentRegistry.GetIds<T0>();
		ref var entityReference = ref GetEntity(entity);

		// check if has component
		if (!entityReference.Archetype.Has(in ids))
			throw ThrowHelper.ComponentNotFound(entity.Id, typeof(T0));

		ref var component = ref entityReference.Archetype.Write<T0>(in entityReference.Slot, ids.T0);
		return ref component;
	}

	/// <summary>
	/// Returns a component buffer for an entity.
	/// Buffer is invalid after structural changes and should not be stored.
	/// </summary>
	/// <remarks>
	/// Marks the accessed <see cref="Chunk"/> as changed.
	/// </remarks>
	/// <typeparam name="T0">Component type</typeparam>
	/// <param name="entity">The target entity</param>
	/// <returns>Component buffer for the given entity</returns>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	[ChunkChange]
	public WriteBuffer<T0> WriteBuffer<T0>(Entity entity) where T0 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0>();
		var ids = ComponentRegistry.GetIds<T0>();
		ref var entityReference = ref GetEntity(entity);

		// check if has component
		if (!entityReference.Archetype.Has(in ids))
			throw ThrowHelper.ComponentNotFound(entity.Id, typeof(T0));

		var buffer = entityReference.Archetype.WriteBuffer<T0>(in entityReference.Slot, ids.T0);
		return buffer;
	}

	/// <summary>
	/// Returns if an entity has given component types
	/// </summary>
	/// <typeparam name="T">Component type</typeparam>
	/// <param name="entity">The target entity</param>
	/// <returns>If the entity has the given component type</returns>
	/// <exception cref="EntityException"></exception>
	public bool Has<T>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		return reference.Archetype.Has(ComponentRegistry.GetIds<T>());
	}

	/// <summary>
	/// Removes components from a given entity
	/// </summary>
	/// <typeparam name="T0">Component type</typeparam>
	/// <param name="entity">The target entity</param>
	/// <returns>If the component was found and removed</returns>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	[StructuralChange]
	public void Remove<T0>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0>();
		var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Has(in ids))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);

		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(in dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}

	/// <summary>
	/// Reserves space for a given amounts of entities in a matching <see cref="Archetype"/>
	/// </summary>
	/// <typeparam name="T0"></typeparam>
	/// <param name="entityCount">The amount of entity space to reserve</param>
	[StructuralChange]
	public void Reserve<T0>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}

	/// <summary>
	/// Gets the archetype of a given entity
	/// </summary>
	/// <param name="entity">The target entity</param>
	/// <returns>The entity's archetype</returns>
	public Archetype GetArchetype(Entity entity)
	{
		ref var entityReference = ref GetEntity(entity);
		return entityReference.Archetype;
	}

	/// <summary>
	/// Gets the archetype of a given <see cref="Signature"/>
	/// </summary>
	/// <param name="entity">The target <see cref="Signature"/></param>
	/// <returns></returns>
	public Archetype GetArchetype(in Signature signature)
	{
		return Archetypes.GetOrCreateArchetype(in signature);
	}

	/// <summary>
	/// Sets component values for a given entity
	/// </summary>
	/// <typeparam name="T">The component type</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="t0Component">The value to set</param>
	public void Set<T0>(Entity entity, in T0? t0Component)
    {
        ComponentMeta.AssertNotBuffered<T0>();
        var ids = ComponentRegistry.GetIds<T0>();
        ref var entityReference = ref GetEntity(entity);

		// check if component exists
		var archetype = entityReference.Archetype;
		if (!archetype.Has(in ids))
            throw archetype.GetComponentNotFound(entity.Id, in ids);

        // set value
        entityReference.Archetype.Set(in entityReference.Slot, in ids, in t0Component);
	}

	/// <summary>
	/// Sets buffer values for a given entity
	/// </summary>
	/// <remarks>
	/// This method will overwrite any existing buffer values.
	/// Use <see cref="GetBuffer{T}(uint)"/> and <see cref="WriteBuffer{T}.AddRange(ReadOnlySpan{T})"/> to append values.
	/// </remarks>
	/// <typeparam name="T">The buffer type</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="values">The values to set</param>
	public void Set<T>(Entity entity, ReadOnlySpan<T> values) where T : unmanaged
    {
        ComponentMeta.AssertBuffered<T>();
        var ids = ComponentRegistry.GetIds<T>();
        ref var entityReference = ref GetEntity(entity);

        // check if component exists
        var archetype = entityReference.Archetype;
        if (!archetype.Has(in ids))
            throw archetype.GetComponentNotFound(entity.Id, in ids);

        // set values
        entityReference.Archetype.Set(in entityReference.Slot, in ids, values);
	}

	/// <summary>
	/// Pairs an archetype and component ids for bulk operations
	/// </summary>
	public BulkCreate<T0> GetBulkCreate<T0>()
	{
		var ids = ComponentRegistry.GetIds<T0>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0>(archetype, in offsets);
	}

	/// <summary>
	/// Creates a new <see cref="ChangeFilter{T}"/> with the current change state
	/// </summary>
	/// <typeparam name="T0"></typeparam>
	/// <returns></returns>
	public ChangeFilter<T0> CreateChangeFilter<T0>()
	{
		var id = ComponentRegistry.GetId<T0>();
		var version = Volatile.Read(ref _globalChangeVersions[id.Value]);
		return new ChangeFilter<T0>(id.Value, version);
	}

	/// <summary>
	/// Creates a new <see cref="CommandBuffer"/> for this <see cref="EntityDatabase"/> instance
	/// </summary>
	/// <param name="initialCapacity"></param>
	/// <returns>A new <see cref="CommandBuffer"/></returns>
	public CommandBuffer CreateCommandBuffer(int initialCapacity)
	{
		return new CommandBuffer(this, initialCapacity);
	}

	/// <inheritdoc cref="IDisposable.Dispose"/>
	public void Dispose()
	{
		Archetypes.Dispose();
		ParallelRunner?.Dispose();
	}

	/// <summary>
	/// Trims excess memory and allocations.
	/// </summary>
	/// <remarks>
	/// This method should NOT be called per tick, only periodically when memory is needed.
	/// </remarks>
	/// <param name="keepVersions">If stored entity versions should be persisted. If <c>false</c>, entity versions above the resulting max entity id will be lost.</param>
	[StructuralChange]
	public void TrimExcess(bool keepVersions = true)
	{
		_entityMap.TrimExcess(keepVersions);
		var maxEntityId = _entityMap.NextEntityId;

		Archetypes.TrimExcess();
		_recycledEntityIds = new Queue<Entity>(_recycledEntityIds.Where(x => x.Id < maxEntityId));
	}

	/// <summary>
	/// Creates an entity with the given <see cref="Signature"/>. All components are default.
	/// </summary>
	/// <returns>Id of the created entity</returns>
	/// <exception cref="MaxReachedException"></exception>
	[StructuralChange]
	[ChunkChange]
	internal Entity Create(in Signature signature)
	{
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out _);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}

	/// <summary>
	/// Gets an internal <see cref="EntityReference"/> to a given entity id
	/// </summary>
	/// <param name="entityId">The target entity</param>
	/// <returns>A reference to the entity</returns>
	/// <exception cref="EntityException"></exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ref EntityReference GetEntity(Entity entity)
	{
		ref var entityReference = ref _entityMap.TryGetReference(entity.Id, out var foundEntity);
		if (!foundEntity || entityReference.Version != entity.Version)
			throw ThrowHelper.EntityNotFound(entity.Id);
		return ref entityReference;
	}

	/// <summary>
	/// Moves a target entity to a new archetype. New components will be defaulted.
	/// </summary>
	/// <param name="entity">The target entity</param>
	/// <param name="targetArchetype">The target archetype</param>
	[StructuralChange]
	internal void Move(Entity entity, Archetype targetArchetype)
	{
		ref var entityReference = ref GetEntity(entity);
		MoveEntity(entity.Id, ref entityReference, entityReference.Archetype, targetArchetype);
	}

	/// <summary>
	/// Gets a new or recycled entity id
	/// </summary>
	/// <param name="entity">The assigned entity</param>
	/// <returns>A <see cref="EntityReference"/> for storing entity data</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private ref EntityReference GetNextEntityId(out Entity entity)
	{
		// try recycle
		if (_recycledEntityIds.TryDequeue(out entity))
		{
			entity = entity with
			{
				Version = entity.Version + 1
			};
			return ref _entityMap.GetReference(entity.Id);
		}

		// add entity
		ref var entityReference = ref _entityMap.Add(out entity);
		return ref entityReference;
	}

	/// <summary>
	/// Moves an entity between two <see cref="Archetype"/>'s, cloning matching components
	/// </summary>
	/// <param name="entityId">The entity id to move</param>
	/// <param name="entityReference">A reference to the entity reference entry</param>
	/// <param name="srcArchetype">The <see cref="Archetype"/> to move from</param>
	/// <param name="dstArchetype">The <see cref="Archetype"/> to move to</param>
	private void MoveEntity(int entityId, ref EntityReference entityReference, Archetype srcArchetype, Archetype dstArchetype)
	{
		// copy to new archetype
		var srcSlot = entityReference.Slot;
		var dstSlot = dstArchetype.AddEntity(new Entity(entityId, entityReference.Version), out _);
		var removedMask = srcArchetype.Signature.AndNot(dstArchetype.Signature);
		srcArchetype.ClearBuffers(in entityReference.Slot, in removedMask);
		srcArchetype.CopyComponents(srcSlot, dstArchetype, dstSlot);
		srcArchetype.RemoveEntity(srcSlot, out var movedEntity);

		_entityMap.Move(movedEntity, in srcSlot);

		// update reference
		entityReference = new EntityReference(dstArchetype, dstSlot, entityReference.Version);
	}
}

