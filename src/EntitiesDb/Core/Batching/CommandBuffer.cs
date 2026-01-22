using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

/// <summary>
/// A thread-safe command buffer to queue and playback entity changes
/// </summary>
public sealed partial class CommandBuffer
{
	private readonly EntityDatabase _database;
	private readonly ComponentRegistry _registry;
	private readonly Dictionary<int, int> _entityMap;
	private readonly int _initialCapacity;
	private readonly object _lock = new();
	private readonly List<Exception> _exceptions = [];
	private SpanList<int> _creates;
	private SpanList<int> _destroys;
	private SpanList<BufferedEntity> _entities;
	private SpanList<Signature> _sets;
	private SpanList<Signature> _removes;
	private SpanList<ComponentStore?> _components;

	internal CommandBuffer(EntityDatabase database, int initialCapacity)
	{
		_database = database;
		_registry = database.ComponentRegistry;
		_entityMap = new(initialCapacity);
		_initialCapacity = initialCapacity;
		_creates = new SpanList<int>(initialCapacity);
		_destroys = new SpanList<int>(initialCapacity);
		_entities = new SpanList<BufferedEntity>(initialCapacity);
		_sets = new SpanList<Signature>(initialCapacity);
		_removes = new SpanList<Signature>(initialCapacity);
		_components = new SpanList<ComponentStore?>(ComponentRegistry.MaxComponents / 4);
	}

	/// <summary>
	/// Clears all buffered commands
	/// </summary>
	public void Clear()
	{
		lock (_lock)
		{
			_exceptions.Clear();
			_entityMap.Clear();
			_creates.Clear();
			_destroys.Clear();
			_entities.Clear();
			_sets.Clear();
			_removes.Clear();
			foreach (var componentStore in _components)
			{
				componentStore?.Clear();
			}
		}
	}

	/// <summary>
	/// Commits buffered commands to the database.
	/// </summary>
	/// <remarks>
	/// Exceptions for each command are collected and thrown in an <see cref="AggregateException"/>.
	/// A single exception won't stop further command execution.
	/// </remarks>
	public unsafe void Commit()
	{
		lock (_lock)
		{
			try
			{
				// create
				var entitiesSpan = _entities.AsSpan();
				foreach (ref var entityIndex in _creates)
				{
					try
					{
						ref var bufferedEntity = ref entitiesSpan[entityIndex];
						var signature = bufferedEntity.SetIndex >= 0 ? _sets[entityIndex] : default;
						bufferedEntity = bufferedEntity with
						{
							Entity = _database.Create(in signature)
						};
					}
					catch (Exception e)
					{
						_exceptions.Add(e);
					}
				}

				// destroy
				foreach (var entityIndex in _destroys)
				{
					try
					{
						ref var bufferedEntity = ref entitiesSpan[entityIndex];
						_database.Destroy(bufferedEntity.Entity);
					}
					catch (Exception e)
					{
						_exceptions.Add(e);
					}
				}

				// set & remove
				for (int entityIndex = 0; entityIndex < entitiesSpan.Length; entityIndex++)
				{
					ref var bufferedEntity = ref entitiesSpan[entityIndex];
					try
					{
						var archetype = _database.GetArchetype(bufferedEntity.Entity);
						var remove = bufferedEntity.RemoveIndex >= 0 ? _removes[bufferedEntity.RemoveIndex] : Signature.Empty;
						var set = bufferedEntity.SetIndex >= 0 ? _sets[bufferedEntity.SetIndex] : Signature.Empty;
						var targetSignature = archetype.Signature.Or(in set).AndNot(in remove);
						var targetArchetype = _database.GetArchetype(in targetSignature);
						
						// change archetypes (removes components)
						if (archetype != targetArchetype)
						{
							_database.Move(bufferedEntity.Entity, targetArchetype);
						}

						ref var reference = ref _database.GetEntity(bufferedEntity.Entity);
						ref readonly var chunk = ref targetArchetype.ChunkSpan[reference.Slot.ChunkIndex];

						// copy components
						int nextId = 0;
						set &= targetSignature; // clear removed components
						while (set.TryGetNextSetBit(nextId, out var id))
						{
							nextId = id + 1;
							var componentStore = id < _components.Count ? _components[id] : null;
							if (componentStore is null) continue; // ComponentStores for tag components are null

							var offset = targetArchetype.GetOffset(id);
							if (componentStore.ComponentType.IsUnmanaged)
							{
								var stride = componentStore.ComponentType.Stride;
								var data = chunk.WriteUnmanaged(id, offset + reference.Slot.Index * stride);
								var sourceData = (byte[])componentStore.Components;
								var sourceIndex = componentStore.GetComponentIndex(entityIndex) * stride;

								// if we are overwriting an existing buffer, clear the previous one
								if (componentStore.ComponentType.IsBuffer &&
									targetArchetype.Signature.Test(id))
								{
									DynamicBuffer.Clear((void*)data);
								}

								fixed (byte* src = &sourceData[sourceIndex])
								{
									Unsafe.CopyBlock((void*)data, src, (uint)stride);
								}
							}
							else
							{
								var array = chunk.WriteManaged(id, offset);
								var sourceArray = componentStore.Components;
								var sourceIndex = componentStore.GetComponentIndex(entityIndex);
								Array.Copy(
									sourceArray, entityIndex,
									array, reference.Slot.Index,
									1);
							}
						}
					}
					catch (Exception e)
					{
						_exceptions.Add(e);
					}
				}

				// throw exceptions
				if (_exceptions.Count > 0)
				{
					throw new AggregateException([.. _exceptions]);
				}
			}
			finally
			{
				_exceptions.Clear();
				_entityMap.Clear();
				_creates.Clear();
				_destroys.Clear();
				_entities.Clear();
				_sets.Clear();
				_removes.Clear();
				foreach (var componentStore in _components)
				{
					componentStore?.Clear();
				}
			}
		}
	}

	/// <summary>
	/// Creates a buffered entity
	/// </summary>
	/// <returns>An <see cref="Entity"/> representing the buffered entity.</returns>
	public Entity Create()
	{
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			return entity;
		}
	}

	/// <summary>
	/// Creates a buffered entity with components
	/// </summary>
	/// <returns>An <see cref="Entity"/> representing the buffered entity.</returns>
	public Entity Create<T0>(in T0? t0Component = default)
	{
		ComponentMeta.AssertNotBuffered<T0>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			return entity;
		}
	}

	/// <summary>
	/// Creates a buffered entity with components
	/// </summary>
	/// <returns>An <see cref="Entity"/> representing the buffered entity.</returns>
	public Entity Create<T0>(ReadOnlySpan<T0> t0Components)
		where T0 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
			return entity;
		}
	}

	/// <summary>
	/// Destroys a given entity
	/// </summary>
	/// <param name="entity">The target entity</param>
	public void Destroy(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			_destroys.Add(entityIndex);
		}
	}

	/// <summary>
	/// Buffers components to be added to a given entity
	/// </summary>
	/// <typeparam name="T0">The type of component to add</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="component">The component to be added</param>
	public void Add<T0>(Entity entity, in T0? component = default)
	{
		Set(entity, in component);
	}

	/// <summary>
	/// Buffers component buffers to be added to a given entity
	/// </summary>
	/// <typeparam name="T0">The type of component to add</typeparam>
	/// <param name="entity">The target entity</param>
	/// <param name="component">The component to be added</param>
	public void Add<T0>(Entity entity, ReadOnlySpan<T0> components = default)
		where T0 : unmanaged
	{
		Set(entity, components);
	}

	/// <summary>
	/// Buffers components to be removed from a given entity
	/// </summary>
	/// <typeparam name="T0">The type of component to remove</typeparam>
	/// <param name="entity">The target entity</param>
	public void Remove<T0>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0>();
			RegisterRemove(entityIndex, in signature);
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
		ComponentMeta.AssertNotBuffered<T0>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
		}
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
        ComponentMeta.AssertBuffered<T0>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
		}
	}

	private ComponentStore GetComponentStore(int id)
	{
		while (id >= _components.Count)
			_components.Add(null);

		ref var componentStore = ref _components.AsSpan()[id];
		if (componentStore is null)
		{
			var componentType = _registry.GetComponentType(id);
			var arrayFactory = _registry.GetArrayFactory(id);
			componentStore = new ComponentStore(componentType, arrayFactory, _initialCapacity);
		}
		return componentStore;
	}

	private int Register(Entity entity)
    {
        if (!_entityMap.TryGetValue(entity.Id, out var entityIndex))
		{
			entityIndex = _entities.Count;
			_entities.Add(new BufferedEntity(entity, -1, -1));
			_entityMap.Add(entity.Id, entityIndex);
		}
		return entityIndex;
	}

	private void RegisterRemove(int entityIndex, in Signature signature)
	{
		ref var reference = ref _entities.AsSpan()[entityIndex];
		reference = reference with
		{
			RemoveIndex = RegisterIndex(reference.RemoveIndex, in signature, ref _removes)
		};
	}

	private void RegisterSet(int entityIndex, in Signature signature)
	{
		ref var reference = ref _entities.AsSpan()[entityIndex];
		reference = reference with
		{
			SetIndex = RegisterIndex(reference.SetIndex, in signature, ref _sets)
		};
	}

	private static int RegisterIndex(int index, in Signature signature, ref SpanList<Signature> list)
	{
		if (index < 0)
		{
			index = list.Count;
			list.Add(signature);
		}
		else
		{
			var existing = list[index];
			list[index] = existing | signature;
		}
		return index;
	}

	private void SetData<T>(int entityIndex, in T? component)
	{
		var componentType = _registry.GetComponentType<T>();
		if (componentType.IsTag) return;
		var componentStore = GetComponentStore(componentType.Id);
		componentStore.SetData(entityIndex, in component);
	}

	private void SetData<T>(int entityIndex, ReadOnlySpan<T> components) where T : unmanaged
	{
		var componentType = _registry.GetComponentType<T>();
		if (componentType.IsTag) return;
		var componentStore = GetComponentStore(componentType.Id);
		componentStore.SetData(entityIndex, components);
	}
}