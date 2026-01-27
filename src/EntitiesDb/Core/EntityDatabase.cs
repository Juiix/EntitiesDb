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
	private Queue<Entity> _recycledEntityIds = new(1024);
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
        Archetypes = new(options.ChunkByteSize, _globalChangeVersions);
		MaxEntities = options.MaxEntities;
		ParallelRunner = options.ParallelThreads > 1 ? new ParallelJobRunner(options.ParallelThreads) : null;
		QueryBuilder = new(Archetypes, ParallelRunner, _globalChangeVersions);
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
	/// <param name="t0Component">Component value</param>
	/// <exception cref="EntityException"></exception>
	/// <exception cref="ComponentException"></exception>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0>(Entity entity, in T0? t0Component = default)
	{
		var addedSignature = ComponentSingle<T0>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
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
	public void Add<T0>(Entity entity, T0[] t0Components) where T0 : unmanaged
	{
		Add(entity, t0Components.AsSpan());
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
	public void Add<T0>(Entity entity, ReadOnlySpan<T0> t0Components = default) where T0 : unmanaged
	{
		var addedSignature = ComponentBuffer<T0>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
		var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// buffers must be initialized for first use since
		// SetBuffer relies on internal state
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
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
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(Signature.Empty);
		var dstSlot = archetype.AddEntity(dstEntityId, out _);
		entityReference = new EntityReference(archetype, dstSlot, dstEntityId.Version);
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
		var signature = ComponentSingle<T0>.Signature;
		ref var entityReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
		entityReference = new EntityReference(archetype, slot, dstEntityId.Version);
		EntityCount++;
		return dstEntityId;
	}

	/// <summary>
	/// Creates an entity with a buffer of components
	/// </summary>
	/// <returns>Id of the created entity</returns>
	/// <exception cref="MaxReachedException"></exception>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0>(T0[] t0Components) where T0 : unmanaged
	{
		return Create(t0Components.AsSpan());
	}

	/// <summary>
	/// Creates an entity with a buffer of components
	/// </summary>
	/// <returns>Id of the created entity</returns>
	/// <exception cref="MaxReachedException"></exception>
	[StructuralChange]
	[ChunkChange]
	public Entity Create<T0>(ReadOnlySpan<T0> t0Components = default) where T0 : unmanaged
	{
		var signature = ComponentBuffer<T0>.Signature;
		ref var dstReference = ref GetNextEntityId(out var dstEntityId);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var slot = archetype.AddEntity(dstEntityId, out var chunk);
		chunk.WriteBuffer<T0>(slot.Index).Set(t0Components);
		dstReference = new EntityReference(archetype, slot, dstEntityId.Version);
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
		ref var chunk = ref archetype.GetChunk(entityReference.Slot.ChunkIndex);
		archetype.ClearBuffers(ref chunk, in entityReference.Slot, archetype.Signature);
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
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		ref readonly var component = ref chunk.Read<T0>(entityReference.Slot.Index);
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
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		var buffer = chunk.ReadBuffer<T0>(entityReference.Slot.Index);
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
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		ref var component = ref chunk.Write<T0>(entityReference.Slot.Index);
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
		ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		var buffer = chunk.WriteBuffer<T0>(entityReference.Slot.Index);
		return buffer;
	}

	/// <summary>
	/// Returns if an entity has given component types
	/// </summary>
	/// <typeparam name="T">Component type</typeparam>
	/// <param name="entity">The target entity</param>
	/// <returns>If the entity has the given component type</returns>
	/// <exception cref="EntityException"></exception>
	public bool Has<T0>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		return reference.Archetype.Has<T0>();
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
		var removedSignature = Component<T0>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
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
		var signature = Signature.From<T0>();
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
	/// Gets <see cref="EntityData"/> for faster read/write of multiple components. Avoid's duplicate entity slot lookups.
	/// </summary>
	/// <remarks>
	/// The data is invalid after any structural change and should not be stored.
	/// </remarks>
	/// <param name="entity"></param>
	/// <returns>An <see cref="EntityData"/> for the given entity.</returns>
	public EntityData GetEntityData(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		ref var chunk = ref reference.Archetype.GetChunk(reference.Slot.ChunkIndex);
		return new EntityData(ref chunk, reference.Slot.Index);
	}

	/// <summary>
	/// Sets component values for a given entity
	/// </summary>
	/// <typeparam name="T">The component type</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="t0Component">The value to set</param>
	public void Set<T0>(Entity entity, in T0? t0Component)
	{
        ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
	}

	/// <summary>
	/// Sets buffer values for a given entity
	/// </summary>
	/// <remarks>
	/// This method will overwrite any existing buffer values.
	/// Use <see cref="WriteBuffer{T0}(Entity)"/> and <see cref="WriteBuffer{T}.AddRange(ReadOnlySpan{T})"/> to append values.
	/// </remarks>
	/// <typeparam name="T0">The buffer type</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="t0Components">The values to set</param>
	public void Set<T0>(Entity entity, T0[] t0Components) where T0 : unmanaged
	{
		Set(entity, t0Components.AsSpan());
	}

	/// <summary>
	/// Sets buffer values for a given entity
	/// </summary>
	/// <remarks>
	/// This method will overwrite any existing buffer values.
	/// Use <see cref="WriteBuffer{T0}(Entity)"/> and <see cref="WriteBuffer{T}.AddRange(ReadOnlySpan{T})"/> to append values.
	/// </remarks>
	/// <typeparam name="T0">The buffer type</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="t0Components">The values to set</param>
	public void Set<T0>(Entity entity, ReadOnlySpan<T0> t0Components) where T0 : unmanaged
    {
        ref var entityReference = ref GetEntity(entity);
		ref readonly var chunk = ref entityReference.Archetype.GetChunk(entityReference.Slot.ChunkIndex);
		chunk.WriteBuffer<T0>(entityReference.Slot.Index).Set(t0Components);
	}

	/// <summary>
	/// Creates a new <see cref="ChangeFilter{T}"/> with the current change state
	/// </summary>
	/// <typeparam name="T0"></typeparam>
	/// <returns></returns>
	public ChangeFilter<T0> CreateChangeFilter<T0>()
	{
		var id = Component<T0>.Id;
		var version = Volatile.Read(ref _globalChangeVersions[id]);
		return new ChangeFilter<T0>(id, version);
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
		// add new slot
		var srcSlot = entityReference.Slot;
		var dstSlot = dstArchetype.AddEntity(new Entity(entityId, entityReference.Version), out _);

		// clear / init buffers
		ref var srcChunk = ref srcArchetype.GetChunk(srcSlot.ChunkIndex);
		var removedMask = srcArchetype.Signature.AndNot(dstArchetype.Signature);
		var addedMask = dstArchetype.Signature.AndNot(srcArchetype.Signature);
		srcArchetype.ClearBuffers(ref srcChunk, in entityReference.Slot, in removedMask);
		srcArchetype.InitBuffers(ref srcChunk, in entityReference.Slot, in addedMask);

		// copy data
		srcArchetype.CopyComponents(srcSlot, dstArchetype, dstSlot);
		srcArchetype.RemoveEntity(srcSlot, out var movedEntity);

		// update reference
		_entityMap.Move(movedEntity, in srcSlot);
		entityReference = new EntityReference(dstArchetype, dstSlot, entityReference.Version);
	}
}

