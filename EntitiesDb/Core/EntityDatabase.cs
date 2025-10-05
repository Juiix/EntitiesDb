using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

public sealed partial class EntityDatabase
{
	private readonly EntityMap _entityMap;
	private readonly Queue<Entity> _recycledEntityIds = [];

	public EntityDatabase(int chunkByteSize, int maxEntities)
	{
		_entityMap = new(maxEntities);
        ComponentRegistry = new();
        Archetypes = new(ComponentRegistry, chunkByteSize);
		MaxEntities = maxEntities;
		QueryBuilder = new(Archetypes, ComponentRegistry);
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
	/// Adds a component to an entity
	/// </summary>
	/// <remarks>
	/// Use <see cref="Set{T0}(uint, T0)"/> if a component is already attached to the entity.
	/// </remarks>
	/// <param name="entityId">Id of the entity altered</param>
	/// <param name="component">Component value</param>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	[StructuralChange]
	public void Add<T0>(int entityId, T0? component = default)
	{
		ComponentMeta.AssertNotBuffered<T0>();
		var ids = ComponentRegistry.GetIds<T0>();
        var addedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Has(in ids))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.WithSet(componentId);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		dstArchetype.Set(in entityReference.Slot, in ids, in component);
	}

	/// <summary>
	/// Adds a component buffer to an entity. Entity component is copied to a new <see cref="Archetype"/>.
	/// </summary>
	/// <remarks>
	/// Use <see cref="Set{T0}(uint, ReadOnlySpan{T0})"/> if a component buffer is already attached to the entity.
	/// </remarks>
	/// <param name="entityId">Id of the entity altered</param>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	[StructuralChange]
	public void Add<T0>(int entityId, ReadOnlySpan<T0> components) where T : unmanaged
    {
        ComponentMeta.AssertBuffered<T0>();
        var ids = ComponentRegistry.GetIds<T>();
        ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Has(in ids))
            throw srcArchetype.GetComponentAlreadyAdded(entityId, in ids);

        var dstSignature = srcArchetype.Signature.WithSet(componentId);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// buffers must be initialized for first use since
		// SetBuffer relies on internal state
		dstArchetype.Init(in entityReference.Slot, in ids, components);
	}

	/// <summary>
	/// Clones an existing entity and its components
	/// </summary>
	/// <param name="srcEntityId">Id of the entity to clone</param>
	/// <returns>Id of the cloned entity</returns>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="MaxReachedException"></exception>
	[StructuralChange]
	public Entity CloneEntity(int srcEntityId)
	{
		// get entity
		ref var srcReference = ref GetEntity(srcEntityId);

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
	public Entity Create<T0>(in T0? t0Component = default)
	{
        ComponentMeta.AssertNotBuffered<T0>();
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var signature = ComponentRegistry.GetSignature<T0>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var dstSlot = archetype.AddEntity(dstEntityId, out var chunk);
		var ids = ComponentRegistry.GetIds<T0>();
        chunk.Set(dstSlot.Index, in ids, t0Component);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}

	/// <summary>
	/// Destroys a given entity
	/// </summary>
	/// <param name="entityId">Id of the entity to destroy</param>
	/// <exception cref="EntityException"></exception>
	[StructuralChange]
	public void Destroy(int entityId)
	{
		// get entity
		ref var entityReference = ref GetEntity(entityId);
		var archetype = entityReference.Archetype;
		archetype.RemoveEntity(in entityReference.Slot, out var movedEntityId);

		_entityMap.Move(movedEntityId, in entityReference.Slot);
		_entityMap.Remove(entityId);
		EntityCount--;
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
	/// Returns a reference to a component for an entity.
	/// Ref values may be invalid after structural changes and should not be stored.
	/// </summary>
	/// <typeparam name="T">Component type</typeparam>
	/// <param name="entityId">Id of the entity</param>
	/// <returns>Reference to the component for the given entity</returns>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	public ref T? Get<T>(int entityId)
    {
        ComponentMeta.AssertNotBuffered<T0>();
        var ids = ComponentRegistry.GetIds<T>();
        ref var entityReference = ref GetEntity(entityId);

		// check if has component
		if (!entityReference.Archetype.Has(in ids))
			throw ThrowHelper.ComponentNotFound(entityId, typeof(T));

		ref var component = ref entityReference.Archetype.Get(in entityReference.Slot, in ids);
		return ref component;
	}

	/// <summary>
	/// Returns a component buffer for an entity.
	/// Buffer is invalid after structural changes and should not be stored.
	/// </summary>
	/// <typeparam name="T">Component type</typeparam>
	/// <param name="entityId">Id of the entity</param>
	/// <returns>Component buffer for the given entity</returns>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	public DynamicBuffer<T> GetBuffer<T>(int entityId) where T : unmanaged
    {
        ComponentMeta.AssertBuffered<T>();
		var ids = ComponentRegistry.GetIds<T>();
		ref var entityReference = ref GetEntity(entityId);

		// check if has component
		if (!entityReference.Archetype.Has(in ids))
			throw ThrowHelper.ComponentNotFound(entityId, typeof(T));

		var buffer = entityReference.Archetype.GetBuffer(in entityReference.Slot, in ids);
		return buffer;
	}

	/// <summary>
	/// Returns if an entity has a given component type
	/// </summary>
	/// <typeparam name="T">Component type</typeparam>
	/// <param name="entityId">Id of the entity</param>
	/// <returns>If the entity has the given component type</returns>
	/// <exception cref="EntityException"></exception>
	public bool Has<T>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		return reference.Archetype.Has(ComponentRegistry.GetIds<T>());
	}

	/// <summary>
	/// Removes a component or buffer for a given entity
	/// </summary>
	/// <typeparam name="T">Component type</typeparam>
	/// <param name="entityId">Id of the entity</param>
	/// <returns>If the component was found and removed</returns>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	[StructuralChange]
	public void Remove<T>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T>();
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Has(in ids))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);

		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.WithCleared(componentId);
		var dstArchetype = Archetypes.GetOrCreateArchetype(in dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}

	/// <summary>
	/// Sets the component value for <typeparamref name="T"/> at a given entity id
	/// </summary>
	/// <typeparam name="T">The component type</typeparam>
	/// <param name="entityId">The entity id</param>
	/// <param name="component">The value to set</param>
	public void Set<T>(int entityId, T component)
    {
        ComponentMeta.AssertNotBuffered<T>();
        var ids = ComponentRegistry.GetIds<T>();
        ref var entityReference = ref GetEntity(entityId);

		// check if component exists
		var archetype = entityReference.Archetype;
		if (!archetype.Has(in ids))
            throw archetype.GetComponentNotFound(entityId, in ids);

        // set value
        entityReference.Archetype.Set(in entityReference.Slot, in ids, in component);
	}

	/// <summary>
	/// Sets the buffer values for <typeparamref name="T"/> at a given entity id
	/// </summary>
	/// <remarks>
	/// This method will overwrite any existing buffer values.
	/// Use <see cref="GetBuffer{T}(uint)"/> and <see cref="DynamicBuffer{T}.AddRange(ReadOnlySpan{T})"/> to append values.
	/// </remarks>
	/// <typeparam name="T">The buffer type</typeparam>
	/// <param name="entityId">The entity id</param>
	/// <param name="values">The values to set</param>
	public void Set<T>(int entityId, ReadOnlySpan<T> values) where T : unmanaged
    {
        ComponentMeta.AssertBuffered<T>();
        var ids = ComponentRegistry.GetIds<T>();
        ref var entityReference = ref GetEntity(entityId);

        // check if component exists
        var archetype = entityReference.Archetype;
        if (!archetype.Has(in ids))
            throw archetype.GetComponentNotFound(entityId, in ids);

        // set values
        entityReference.Archetype.SetBuffer(in entityReference.Slot, in ids, values);
	}

	/// <summary>
	/// Gets an internal <see cref="EntityReference"/> to a given entity id
	/// </summary>
	/// <param name="entityId">The entity id</param>
	/// <returns>A reference to the entity</returns>
	/// <exception cref="EntityException"></exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private ref EntityReference GetEntity(int entityId)
	{
		ref var entityReference = ref _entityMap.TryGetReference(entityId, out var foundEntity);
		if (!foundEntity)
			throw ThrowHelper.EntityNotFound(entityId);
		return ref entityReference;
	}

	/// <summary>
	/// Gets a new or recycled entity id
	/// </summary>
	/// <param name="entity">The assigned entity</param>
	/// <returns>A <see cref="EntityReference"/> for storing entity data</returns>
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
		ref var entityReference = ref _entityMap.Add(out var id);
		entity = new Entity(id, 0);
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
		srcArchetype.CopyComponents(srcSlot, dstArchetype, dstSlot);
		srcArchetype.RemoveEntity(srcSlot, out var movedEntity);

		_entityMap.Move(movedEntity, in srcSlot);

		// update reference
		entityReference = entityReference with
		{
			Archetype = dstArchetype,
			Slot = dstSlot
		};
	}
}

