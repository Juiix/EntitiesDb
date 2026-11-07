using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace EntitiesDb;

/// <summary>
/// A thread-safe command buffer to queue and playback entity changes
/// </summary>
public sealed partial class CommandBuffer
{
	private readonly EntityDatabase _database;
	private readonly int _initialCapacity;
	/// <summary>
	/// Guards every operation. Each recorded command holds it for a few dozen nanoseconds, where an
	/// uncontended <c>lock</c> costs about as much as the command itself; a spin lock costs less and
	/// also holds up better when parallel jobs record into one buffer. Never re-entered, so no owner
	/// tracking. Mutable field: a <see cref="SpinLock"/> must not be copied.
	/// </summary>
	private SpinLock _lock = new(enableThreadOwnerTracking: false);
	private readonly List<Exception> _exceptions = [];

	/// <summary>
	/// Existing entity id -> entity index. Buffered creates need no lookup: a placeholder's id encodes its index.
	/// </summary>
	private EntityIndexMap _existing = new();
	private SpanList<int> _destroys;
	private SpanList<BufferedEntity> _entities;

	/// <summary>
	/// Buffered creates, existing entities, and whether any non-create entry has a set or remove: Commit
	/// and Reset skip the passes over <see cref="_entities"/> that would find nothing to do
	/// </summary>
	private int _createCount;
	private int _existingCount;
	private bool _hasChanges;

	/// <summary>
	/// Pending set / remove signatures, shared by every entity that ends up with the same one (a batch of
	/// identical commands stores a single entry). Entries are never changed in place.
	/// </summary>
	private SpanList<Signature> _sets;
	private SpanList<Signature> _removes;

	/// <summary>
	/// Value stores by component id (null until a value of that type is buffered; tags never get one)
	/// </summary>
	private readonly ComponentStore?[] _stores = new ComponentStore?[ComponentRegistry.MaxComponents];
	private SpanList<ComponentStore> _activeStores = new(8);

	/// <summary>
	/// The current <see cref="WritePlan"/>: stores to write and their offsets in the target archetype
	/// </summary>
	private readonly ComponentStore[] _planStores = new ComponentStore[ComponentRegistry.MaxComponents];
	private readonly int[] _planOffsets = new int[ComponentRegistry.MaxComponents];

	internal CommandBuffer(EntityDatabase database, int initialCapacity)
	{
		initialCapacity = Math.Max(initialCapacity, 1);
		_database = database;
		_initialCapacity = initialCapacity;
		_destroys = new SpanList<int>();
		_entities = new SpanList<BufferedEntity>(initialCapacity);
		_sets = new SpanList<Signature>(16);
		_removes = new SpanList<Signature>();
	}

	/// <summary>
	/// Clears all buffered commands
	/// </summary>
	public void Clear()
	{
		Enter();
		try
		{
			Reset();
		}
		finally
		{
			Exit();
		}
	}

	/// <summary>
	/// Commits buffered commands to the database.
	/// </summary>
	/// <remarks>
	/// Exceptions for each command are collected and thrown in an <see cref="AggregateException"/>.
	/// A single exception won't stop further command execution.
	/// </remarks>
	public void Commit()
	{
		Enter();
		try
		{
			try
			{
				if (_createCount > 0) CommitCreates();
				CommitDestroys();
				if (_hasChanges) CommitChanges();

				// throw exceptions
				if (_exceptions.Count > 0)
				{
					throw new AggregateException([.. _exceptions]);
				}
			}
			finally
			{
				Reset();
			}
		}
		finally
		{
			Exit();
		}
	}

	/// <summary>
	/// Creates a buffered entity
	/// </summary>
	/// <returns>An <see cref="Entity"/> representing the buffered entity.</returns>
	public Entity Create()
	{
		Enter();
		try
		{
			RegisterCreate(out var entity);
			return entity;
		}
		finally
		{
			Exit();
		}
	}

	/// <summary>
	/// Creates a buffered entity with components
	/// </summary>
	/// <returns>An <see cref="Entity"/> representing the buffered entity.</returns>
	public Entity Create<T0>(in T0? t0Component = default)
	{
		var signature = ComponentSingle<T0>.Signature;
		Enter();
		try
		{
			var entityIndex = RegisterCreate(in signature, out var entity);
			SetData(entityIndex, in t0Component);
			return entity;
		}
		finally
		{
			Exit();
		}
	}

	/// <summary>
	/// Creates a buffered entity with components
	/// </summary>
	/// <returns>An <see cref="Entity"/> representing the buffered entity.</returns>
	public Entity Create<T0>(T0[] t0Components)
		where T0 : unmanaged
	{
		return Create(t0Components.AsSpan());
	}

	/// <summary>
	/// Creates a buffered entity with components
	/// </summary>
	/// <returns>An <see cref="Entity"/> representing the buffered entity.</returns>
	public Entity Create<T0>(ReadOnlySpan<T0> t0Components = default)
		where T0 : unmanaged
	{
		var signature = ComponentBuffer<T0>.Signature;
		Enter();
		try
		{
			var entityIndex = RegisterCreate(in signature, out var entity);
			SetData(entityIndex, t0Components);
			return entity;
		}
		finally
		{
			Exit();
		}
	}

	/// <summary>
	/// Destroys a given entity
	/// </summary>
	/// <param name="entity">The target entity</param>
	public void Destroy(Entity entity)
	{
		Enter();
		try
		{
			var entityIndex = Register(entity);
			_destroys.Add(entityIndex);
		}
		finally
		{
			Exit();
		}
	}

	/// <summary>
	/// Buffers components to be added to a given entity
	/// </summary>
	/// <typeparam name="T0">The type of component to add</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="t0Component">The component to be added</param>
	public void Add<T0>(Entity entity, in T0? t0Component = default)
	{
		Set(entity, in t0Component);
	}

	/// <summary>
	/// Buffers component buffers to be added to a given entity
	/// </summary>
	/// <typeparam name="T0">The type of component to add</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="t0Components">The component to be added</param>
	public void Add<T0>(Entity entity, T0[] t0Components)
		where T0 : unmanaged
	{
		Set(entity, t0Components.AsSpan());
	}

	/// <summary>
	/// Buffers component buffers to be added to a given entity
	/// </summary>
	/// <typeparam name="T0">The type of component to add</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="t0Components">The component to be added</param>
	public void Add<T0>(Entity entity, ReadOnlySpan<T0> t0Components = default)
		where T0 : unmanaged
	{
		Set(entity, t0Components);
	}

	/// <summary>
	/// Appends elements to an existing buffer component, or adds the buffer if the entity doesn't have it
	/// </summary>
	/// <typeparam name="T0">The type of buffer element</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="t0Component">The element to append</param>
	public void AddOrAppend<T0>(Entity entity, in T0 t0Component)
		where T0 : unmanaged
	{
		AddOrAppend(entity, MemoryMarshal.CreateReadOnlySpan(ref Unsafe.AsRef(in t0Component), 1));
	}

	/// <summary>
	/// Appends elements to an existing buffer component, or adds the buffer if the entity doesn't have it
	/// </summary>
	/// <typeparam name="T0">The type of buffer element</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="t0Components">The elements to append</param>
	public void AddOrAppend<T0>(Entity entity, T0[] t0Components)
		where T0 : unmanaged
	{
		AddOrAppend(entity, t0Components.AsSpan());
	}

	/// <summary>
	/// Appends elements to an existing buffer component, or adds the buffer if the entity doesn't have it
	/// </summary>
	/// <typeparam name="T0">The type of buffer element</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="t0Components">The elements to append</param>
	public void AddOrAppend<T0>(Entity entity, ReadOnlySpan<T0> t0Components)
		where T0 : unmanaged
	{
		var signature = ComponentBuffer<T0>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			AppendData(entityIndex, t0Components);
		}
		finally
		{
			Exit();
		}
	}

	/// <summary>
	/// Buffers components to be removed from a given entity
	/// </summary>
	/// <typeparam name="T0">The type of component to remove</typeparam>
	/// <param name="entity">The target entity</param>
	public void Remove<T0>(Entity entity)
	{
		var signature = Component<T0>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}

	/// <summary>
	/// Buffers components to be set on a given entity
	/// </summary>
	/// <typeparam name="T0">The type of component to set</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="component">The component to be set</param>
	public void Set<T0>(Entity entity, in T0? t0Component = default)
	{
		var signature = ComponentSingle<T0>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
		}
		finally
		{
			Exit();
		}
	}

	/// <summary>
	/// Buffers component buffers to be set on a given entity
	/// </summary>
	/// <typeparam name="T0">The type of component to set</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="components">The components to be set</param>
	public void Set<T0>(Entity entity, T0[] t0Components)
		where T0 : unmanaged
	{
		Set(entity, t0Components.AsSpan());
	}

	/// <summary>
	/// Buffers component buffers to be set on a given entity
	/// </summary>
	/// <typeparam name="T0">The type of component to set</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="components">The components to be set</param>
	public void Set<T0>(Entity entity, ReadOnlySpan<T0> t0Components = default)
		where T0 : unmanaged
	{
		var signature = ComponentBuffer<T0>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
		}
		finally
		{
			Exit();
		}
	}

	// ---- playback ---------------------------------------------------------------------------

	/// <summary>
	/// Creates every buffered entity directly in its final archetype and writes its values: a created
	/// entity's pending sets are its whole signature, and its removes only cancelled sets.
	/// </summary>
	private void CommitCreates()
	{
		var database = _database;
		var archetypes = database.Archetypes;
		var entities = _entities.AsSpan();
		var sets = _sets.AsSpan();
		var plan = new WritePlan(-1, null!, 0);
		for (int entityIndex = 0; entityIndex < entities.Length; entityIndex++)
		{
			ref var bufferedEntity = ref entities[entityIndex];
			if (bufferedEntity.Kind != BufferedEntityKind.Create) continue;
			try
			{
				var setIndex = bufferedEntity.SetIndex;
				if (setIndex < 0)
				{
					database.CreateEntity(archetypes.GetOrCreateArchetype(Signature.Empty), out bufferedEntity.Entity, out _);
				}
				else
				{
					// a batch of identical creates shares one interned signature, so the plan is built once per run
					if (setIndex != plan.SetIndex)
						plan = BuildPlan(setIndex, in sets[setIndex], archetypes.GetOrCreateArchetype(in sets[setIndex]));
					ref var chunk = ref database.CreateEntity(plan.Archetype, out bufferedEntity.Entity, out var row);
					Write(in plan, entityIndex, ref chunk, row, freshRow: true);
				}
			}
			catch (Exception e)
			{
				_exceptions.Add(e);
			}

			// nothing is left for the change pass (a failed create would only fail again there)
			bufferedEntity.SetIndex = -1;
			bufferedEntity.RemoveIndex = -1;
		}
	}

	private void CommitDestroys()
	{
		var entities = _entities.AsSpan();
		foreach (var entityIndex in _destroys.AsSpan())
		{
			try
			{
				ref var bufferedEntity = ref entities[entityIndex];
				_database.Destroy(bufferedEntity.Entity);
				bufferedEntity.SetIndex = -1;
				bufferedEntity.RemoveIndex = -1;
			}
			catch (Exception e)
			{
				_exceptions.Add(e);
			}
		}
	}

	/// <summary>
	/// Applies sets and removes to entities that existed before this buffer: one archetype move per
	/// entity, then the buffered values are written in place
	/// </summary>
	private void CommitChanges()
	{
		var database = _database;
		var archetypes = database.Archetypes;
		var entities = _entities.AsSpan();
		var sets = _sets.AsSpan();
		var removes = _removes.AsSpan();
		var plan = new WritePlan(-1, null!, 0);
		for (int entityIndex = 0; entityIndex < entities.Length; entityIndex++)
		{
			ref var bufferedEntity = ref entities[entityIndex];
			var setIndex = bufferedEntity.SetIndex;
			if (setIndex < 0 && bufferedEntity.RemoveIndex < 0) continue;
			try
			{
				ref var reference = ref database.GetEntity(bufferedEntity.Entity);
				var source = database.ArchetypeOf(in reference);
				var targetSignature = source.Signature;
				if (setIndex >= 0) targetSignature = targetSignature.Or(in sets[setIndex]);
				if (bufferedEntity.RemoveIndex >= 0) targetSignature = targetSignature.AndNot(in removes[bufferedEntity.RemoveIndex]);

				// change archetypes (adds / removes components)
				var target = source;
				if (targetSignature != source.Signature)
				{
					target = archetypes.GetOrCreateArchetype(in targetSignature);
					database.MoveEntity(bufferedEntity.Entity.Id, ref reference, source, target);
				}

				if (setIndex >= 0)
				{
					// sets and removes never overlap (each cancels the other when buffered)
					if (setIndex != plan.SetIndex || !ReferenceEquals(target, plan.Archetype))
						plan = BuildPlan(setIndex, in sets[setIndex], target);
					ref var chunk = ref target.GetChunk(reference.Slot.ChunkIndex);
					Write(in plan, entityIndex, ref chunk, reference.Slot.Index, freshRow: false);
				}
			}
			catch (Exception e)
			{
				_exceptions.Add(e);
			}
		}
	}

	/// <summary>
	/// The value stores a signature writes and where each lands in <paramref name="archetype"/>, so a run
	/// of entities with the same pending sets skips the per-entity bit scan and lookups
	/// </summary>
	private WritePlan BuildPlan(int setIndex, in Signature signature, Archetype archetype)
	{
		var offsets = archetype.IdToOffsets;
		int count = 0;
		int nextId = 0;
		while (signature.TryGetNextSetBit(nextId, out var id))
		{
			nextId = id + 1;
			var store = _stores[id];
			if (store is null) continue; // tags have no store
			_planStores[count] = store;
			_planOffsets[count] = offsets[id];
			count++;
		}
		return new WritePlan(setIndex, archetype, count);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void Write(in WritePlan plan, int entityIndex, ref Chunk chunk, int row, bool freshRow)
	{
		var stores = _planStores;
		var offsets = _planOffsets;
		for (int i = 0; i < plan.Count; i++)
		{
			var store = stores[i];
			// a chunk this Commit already marked is newer than any filter's version, so further marks
			// of it are free (see ChangeVersions.Mark)
			if (store.WriteTo(entityIndex, ref chunk, offsets[i], row, freshRow) && store.TrackChanges)
				chunk.MarkChanged(store.Id);
		}
	}

	private readonly struct WritePlan(int setIndex, Archetype archetype, int count)
	{
		public readonly int SetIndex = setIndex;
		public readonly Archetype Archetype = archetype;
		public readonly int Count = count;
	}

	private void Reset()
	{
		_exceptions.Clear();
		if (_existing.ClearIsCheaperThanRemoving(_existingCount))
		{
			_existing.Clear();
		}
		else if (_existingCount > 0)
		{
			foreach (ref readonly var bufferedEntity in _entities.AsSpan())
			{
				if (bufferedEntity.Kind == BufferedEntityKind.Existing)
					_existing.Remove(bufferedEntity.Entity.Id);
			}
		}
		_createCount = 0;
		_existingCount = 0;
		_hasChanges = false;
		_destroys.Clear();
		_entities.Clear();
		_sets.Clear();
		_removes.Clear();
		foreach (var store in _activeStores.AsSpan())
			store.Clear();
	}

	// ---- recording --------------------------------------------------------------------------

	/// <summary>
	/// Takes the lock; call before the <c>try</c> whose <c>finally</c> calls <see cref="Exit"/>
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void Enter()
	{
		bool taken = false;
		_lock.Enter(ref taken);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void Exit() => _lock.Exit(useMemoryBarrier: false);

	/// <summary>
	/// Registers a buffered create with no components
	/// </summary>
	private int RegisterCreate(out Entity entity)
	{
		var entityIndex = _entities.Count;
		entity = new Entity(-entityIndex - 1, -1);
		_entities.Add(new BufferedEntity(entity, -1, -1, BufferedEntityKind.Create));
		_createCount++;
		return entityIndex;
	}

	/// <summary>
	/// Registers a buffered create with the components of <paramref name="signature"/>
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private int RegisterCreate(in Signature signature, out Entity entity)
	{
		var entityIndex = _entities.Count;
		entity = new Entity(-entityIndex - 1, -1);
		_entities.Add(new BufferedEntity(entity, Intern(in signature, ref _sets), -1, BufferedEntityKind.Create));
		_createCount++;
		return entityIndex;
	}

	/// <summary>
	/// Finds or registers the buffered entry for <paramref name="entity"/>
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private int Register(Entity entity)
	{
		var id = entity.Id;
		if (id < 0)
		{
			// a buffered create: its placeholder id encodes its index
			var index = -(id + 1);
			if ((uint)index < (uint)_entities.Count && _entities.ItemRef(index).Entity == entity)
				return index;
			return RegisterUnknown(entity);
		}

		if (_existing.TryGet(id, out var entityIndex))
			return entityIndex;
		return RegisterExisting(entity);
	}

	private int RegisterExisting(Entity entity)
	{
		var entityIndex = _entities.Count;
		_entities.Add(new BufferedEntity(entity, -1, -1, BufferedEntityKind.Existing));
		_existing.Add(entity.Id, entityIndex);
		_existingCount++;
		return entityIndex;
	}

	/// <summary>
	/// A placeholder this buffer did not hand out (another buffer's, or one from before a Commit): it
	/// gets its own entry, which fails at Commit because no such entity exists
	/// </summary>
	private int RegisterUnknown(Entity entity)
	{
		var entityIndex = _entities.Count;
		_entities.Add(new BufferedEntity(entity, -1, -1, BufferedEntityKind.Unknown));
		return entityIndex;
	}

	private void RegisterRemove(int entityIndex, in Signature signature)
	{
		ref var bufferedEntity = ref _entities.ItemRef(entityIndex);
		bufferedEntity.RemoveIndex = Merge(bufferedEntity.RemoveIndex, in signature, ref _removes);
		if (bufferedEntity.Kind != BufferedEntityKind.Create) _hasChanges = true;

		// Clear pending sets for removed components
		if (bufferedEntity.SetIndex >= 0)
		{
			var set = _sets[bufferedEntity.SetIndex];
			var cancelled = set.And(in signature);
			if (cancelled.IsEmpty) return;
			bufferedEntity.SetIndex = Intern(set.AndNot(in signature), ref _sets);

			int nextId = 0;
			while (cancelled.TryGetNextSetBit(nextId, out var id))
			{
				nextId = id + 1;
				_stores[id]?.ClearEntityIndex(entityIndex);
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void RegisterSet(int entityIndex, in Signature signature)
	{
		ref var bufferedEntity = ref _entities.ItemRef(entityIndex);
		bufferedEntity.SetIndex = Merge(bufferedEntity.SetIndex, in signature, ref _sets);
		if (bufferedEntity.Kind != BufferedEntityKind.Create) _hasChanges = true;

		// Clear pending removes for set components
		if (bufferedEntity.RemoveIndex >= 0)
		{
			var remove = _removes[bufferedEntity.RemoveIndex];
			if (remove.HasAny(in signature))
				bufferedEntity.RemoveIndex = Intern(remove.AndNot(in signature), ref _removes);
		}
	}

	/// <summary>
	/// The entry for <c>list[index] | signature</c> (or <paramref name="signature"/> when there is no entry yet)
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int Merge(int index, in Signature signature, ref SpanList<Signature> list)
	{
		if (index < 0)
			return Intern(in signature, ref list);

		var current = list[index];
		var merged = current.Or(in signature);
		return merged == current ? index : Intern(in merged, ref list);
	}

	/// <summary>
	/// An entry holding <paramref name="signature"/>: the last entry when it matches (commands come in
	/// batches), otherwise a new one
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int Intern(in Signature signature, ref SpanList<Signature> list)
	{
		var count = list.Count;
		if (count != 0 && list.ItemRef(count - 1) == signature)
			return count - 1;
		list.Add(signature);
		return count;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void SetData<T>(int entityIndex, in T? component)
	{
		if (ComponentMeta<T>.IsZeroSize) return; // tags carry no value
		GetComponentStore<T>().SetData(entityIndex, in component);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void SetData<T>(int entityIndex, ReadOnlySpan<T> components) where T : unmanaged
	{
		if (ComponentMeta<T>.IsZeroSize) return;
		GetComponentStore<T>().SetData(entityIndex, components);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void AppendData<T>(int entityIndex, ReadOnlySpan<T> components) where T : unmanaged
	{
		if (ComponentMeta<T>.IsZeroSize) return;
		GetComponentStore<T>().AppendData(entityIndex, components);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private ComponentStore GetComponentStore<T>()
	{
		var id = Component<T>.Id;
		return _stores[id] ?? CreateComponentStore(id);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ComponentStore CreateComponentStore(int id)
	{
		var componentType = ComponentRegistry.GetComponentType(id);
		var arrayFactory = ComponentRegistry.GetArrayFactory(id);
		var store = new ComponentStore(componentType, arrayFactory, _initialCapacity);
		_stores[id] = store;
		_activeStores.Add(store);
		return store;
	}
}
