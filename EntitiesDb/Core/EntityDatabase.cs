using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

public sealed partial class EntityDatabase
{
	private readonly ComponentRegistry _componentRegistry;
	private readonly EntityMap _entityMap;
	private readonly Queue<Entity> _recycledEntityIds = [];

	public EntityDatabase(int chunkByteSize, int maxEntities)
	{
		_componentRegistry = new();
		_entityMap = new(maxEntities);
		Archetypes = new(_componentRegistry, chunkByteSize);
		MaxEntities = maxEntities;
		QueryBuilder = new(Archetypes, _componentRegistry);
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
	/// A re-usable query builder
	/// </summary>
	public QueryBuilder QueryBuilder { get; }

	/// <summary>
	/// Adds a component to an entity
	/// </summary>
	/// <remarks>
	/// Use <see cref="Set{T}(uint, T)"/> if the component of type <typeparamref name="T"/> is already attached to the entity.
	/// </remarks>
	/// <typeparam name="T">The component type</typeparam>
	/// <param name="entityId">Id of the entity altered</param>
	/// <param name="component">Component value</param>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	[StructuralChange]
	public ref T? Add<T>(int entityId, T? component = default)
	{
		var componentId = GetId<T>();
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Has(componentId))
			throw ThrowHelper.ComponentAlreadyAdded(typeof(T));

		var dstSignature = srcArchetype.Signature.WithSet(componentId);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref var value = ref dstArchetype.Get<T>(componentId, entityReference.Slot);
		value = component;
		return ref value;
	}

	/// <summary>
	/// Adds a component buffer to an entity. Entity component is copied to a new <see cref="Archetype"/>.
	/// </summary>
	/// <remarks>
	/// Use <see cref="SetBuffer{T}(uint, ReadOnlySpan{T})"/> if the component buffer of type <typeparamref name="T"/> is already attached to the entity.
	/// </remarks>
	/// <typeparam name="T">The component type</typeparam>
	/// <param name="entityId">Id of the entity altered</param>
	/// <param name="components">Components to initialize the buffer with</param>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	[StructuralChange]
	public DynamicBuffer<T> AddBuffer<T>(int entityId, ReadOnlySpan<T> components) where T : unmanaged
	{
		var componentId = GetBufferedId<T>();
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (srcArchetype.Has(componentId))
			throw ThrowHelper.ComponentAlreadyAdded(typeof(T));

		var dstSignature = srcArchetype.Signature.WithSet(componentId);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// buffers must be initialized for first use since
		// SetBuffer relies on internal state
		var buffer = dstArchetype.InitBuffer(componentId, entityReference.Slot, components);
		return buffer;
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
		var dstSlot = archetype.AddEntity(dstEntityId);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		archetype.CloneComponents(srcReference.Slot, dstSlot);
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
		var dstSlot = archetype.AddEntity(dstEntityId);
		dstReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
		EntityCount++;

		return dstEntityId;
	}

	/// <summary>
	/// Creates an empty entity
	/// </summary>
	/// <returns>Id of the created entity</returns>
	/// <exception cref="MaxReachedException"></exception>
	[StructuralChange]
	public Entity Create<T0>(in T0? t0Component = default)
	{
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(Signature.Empty);
		var dstSlot = archetype.AddEntity(dstEntityId, in t0Component);
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
		archetype.RemoveEntity(entityReference.Slot, out var movedEntityId);

		_entityMap.Move(movedEntityId, entityReference.Slot);
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
		var componentId = GetId<T>();
		ref var entityReference = ref GetEntity(entityId);

		// check if has component
		if (!entityReference.Archetype.Has(componentId))
			throw ThrowHelper.ComponentNotFound(entityId, typeof(T));

		ref var component = ref entityReference.Archetype.Get<T>(componentId, entityReference.Slot);
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
		var componentId = GetBufferedId<T>();
		ref var entityReference = ref GetEntity(entityId);

		// check if has component
		if (!entityReference.Archetype.Has(componentId))
			throw ThrowHelper.ComponentNotFound(entityId, typeof(T));

		var buffer = entityReference.Archetype.GetBuffer<T>(componentId, entityReference.Slot);
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
		return reference.Archetype.Has(_componentRegistry.IdOf<T>());
	}

	/// <summary>
	/// Removes a component for a given entity if the entity contains the component
	/// </summary>
	/// <typeparam name="T">Component type</typeparam>
	/// <param name="entityId">Id of the entity</param>
	/// <returns>If the component was found and removed</returns>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	[StructuralChange]
	public void Remove<T>(int entityId)
	{
		var componentId = GetId<T>();
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Has(componentId))
			throw ThrowHelper.ComponentNotFound(entityId, typeof(T));

		var dstSignature = srcArchetype.Signature.WithCleared(componentId);
		var dstArchetype = Archetypes.GetOrCreateArchetype(in dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}

	/// <summary>
	/// Removes a component buffer for a given entity if the entity contains the component
	/// </summary>
	/// <typeparam name="T">Component type</typeparam>
	/// <param name="entityId">Id of the entity</param>
	/// <returns>If the component was found and removed</returns>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	[StructuralChange]
	public void RemoveBuffer<T>(int entityId) where T : unmanaged
	{
		var componentId = GetBufferedId<T>();
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Has(componentId))
			throw ThrowHelper.ComponentNotFound(entityId, typeof(T));

		// get and clear existing buffer
		var buffer = srcArchetype.GetBuffer<T>(componentId, entityReference.Slot);
		buffer.Clear();

		var dstSignature = srcArchetype.Signature.WithCleared(componentId);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

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
		var componentId = GetId<T>();
		ref var entityReference = ref GetEntity(entityId);

		// check if component exists
		if (!entityReference.Archetype.Has(componentId))
			throw ThrowHelper.ComponentNotFound(entityId, typeof(T));

		// set value
		entityReference.Archetype.Set(componentId, entityReference.Slot, in component);
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
	public void SetBuffer<T>(int entityId, ReadOnlySpan<T> values) where T : unmanaged
	{
		var componentId = GetBufferedId<T>();
		ref var entityReference = ref GetEntity(entityId);

		// check if component exists
		if (!entityReference.Archetype.Has(componentId))
			throw ThrowHelper.ComponentNotFound(entityId, typeof(T));

		// set values
		entityReference.Archetype.SetBuffer(componentId, entityReference.Slot, values);
	}

	/// <summary>
	/// Gets a <see cref="ComponentType"/> for a given type <typeparamref name="T"/>
	/// </summary>
	/// <remarks>
	/// This methods asserts that the type is NOT buffered. It will throw if used on a buffered type
	/// </remarks>
	/// <typeparam name="T">The type to get</typeparam>
	/// <returns>A readonly reference to the <see cref="ComponentType"/></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private int GetId<T>()
	{
		ref readonly var componentType = ref _componentRegistry.GetComponentType<T>();
		if (componentType.Buffered)
			throw ThrowHelper.ComponentBuffered(typeof(T));
		return componentType.Id;
	}

	/// <summary>
	/// Gets a <see cref="ComponentType"/> for a given buffered type <typeparamref name="T"/>
	/// </summary>
	/// <remarks>
	/// This methods asserts that the type IS buffered. It will throw if used on a not-buffered type
	/// </remarks>
	/// <typeparam name="T">The type to get</typeparam>
	/// <returns>A readonly reference to the <see cref="ComponentType"/></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private int GetBufferedId<T>() where T : unmanaged
	{
		ref readonly var componentType = ref _componentRegistry.GetComponentType<T>();
		if (!componentType.Buffered)
			throw ThrowHelper.ComponentNotBuffered(typeof(T));
		return componentType.Id;
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
		var dstSlot = dstArchetype.AddEntity(new Entity(entityId, entityReference.Version));
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

