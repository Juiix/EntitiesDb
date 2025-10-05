using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;

namespace EntitiesDb;

/// <summary>
/// Thread-safe registry that assigns unique IDs to component types and supports lock-free reads via snapshotting.
/// </summary>
/// <remarks>
/// <para>
/// Reads are served from an immutable snapshot published with <see cref="Volatile.Write{T}(ref T, T)"/>; writers (type registrations)
/// take a lock, update the authoritative maps, and publish a single coherent snapshot so Type↔Id lookups remain consistent.
/// </para>
/// <para>
/// Typical access pattern: many reads, rare writes. Lookups are lock-free; registering a new type copies the maps once.
/// </para>
/// </remarks>
public sealed partial class ComponentRegistry
{
	public const int MaxComponents = 256;

	private readonly ComponentType[] _componentTypes = new ComponentType[MaxComponents];
	private readonly Type[] _types = new Type[MaxComponents];
	private readonly ArrayFactory[] _arrayFactories = new ArrayFactory[MaxComponents];
	private readonly Dictionary<Type, int> _typeMap = [];
	private readonly object _lock = new();

	private ImmutableDictionary<Type, int> _snapshot = ImmutableDictionary.Create<Type, int>();
	private int _nextId = 0;

	public int Count => Volatile.Read(ref _nextId);

	/// <summary>
	/// Gets the registered <see cref="ComponentType{T}"/> for <typeparamref name="T"/>, creating and registering it if needed.
	/// </summary>
	/// <typeparam name="T">The CLR component type.</typeparam>
	/// <returns>The <see cref="ComponentType{T}"/> associated with <typeparamref name="T"/>.</returns>
	/// <remarks>
	/// Fast path reads from the current snapshot without locking. If missing, acquires a lock, updates the authoritative maps,
	/// and publishes a new snapshot atomically so subsequent readers observe a consistent view.
	/// </remarks>
	/// <exception cref="MaxReachedException"></exception>
	public ref readonly ComponentType GetComponentType<T>()
	{
		var type = typeof(T);

		// Fast path: read-only snapshot (no locking)
		var snap = Volatile.Read(ref _snapshot);
		if (snap.TryGetValue(type, out var existingId))
			return ref _componentTypes[existingId];

		// Slow path: create or fetch under the lock
		lock (_lock)
		{
			// Re-check in the authoritative map
			if (_typeMap.TryGetValue(type, out existingId))
				return ref _componentTypes[existingId];

			ref var created = ref AddComponentType<T>();

			// Publish a single, consistent snapshot
			var newSnapshot = ImmutableDictionary.CreateRange(_typeMap);
			Volatile.Write(ref _snapshot, newSnapshot);

			return ref created;
		}
	}

	/// <summary>
	/// Gets the <see cref="ComponentType"/> associated with the specified <paramref name="id"/>.
	/// </summary>
	/// <param name="id">The component type identifier.</param>
	/// <returns>The matching <see cref="ComponentType"/>.</returns>
	/// <exception cref="IndexOutOfRangeException"></exception>
	public ref readonly ComponentType GetComponentType(int id)
	{
		if (id < 0 ||
			id >= Count)
			throw new IndexOutOfRangeException();
		return ref _componentTypes[id];
	}

	/// <summary>
	/// Tries to get the <see cref="ComponentType"/> associated with the specified <paramref name="id"/>.
	/// </summary>
	/// <param name="id">The component type identifier.</param>
	/// <param name="componentType">When this method returns, contains the component type if found; otherwise <see langword="null"/>.</param>
	/// <returns><see langword="true"/> if a component type with the given <paramref name="id"/> exists; otherwise <see langword="false"/>.</returns>
	public ref readonly ComponentType TryGetComponentType(int id, out bool found)
	{
		if (id < 0 ||
			id >= Count)
		{
			found = false;
			return ref Unsafe.NullRef<ComponentType>();
		}

		found = true;
		return ref _componentTypes[id];
	}

	/// <summary>
	/// Gets a component's <see cref="Type"/> by a given id
	/// </summary>
	/// <param name="id">Id of the target component</param>
	/// <returns>The type retrieved</returns>
	/// <exception cref="IndexOutOfRangeException"></exception>
	public Type GetType(int id)
	{
		if (id < 0 ||
			id >= Count)
			throw new IndexOutOfRangeException();
		return _types[id];
	}

	/// <summary>
	/// Tries to get a component's <see cref="Type"/> by a given id
	/// </summary>
	/// <param name="id">Id of the target component</param>
	/// <param name="type">The retrived type</param>
	/// <returns>If the type was retrieved</returns>
	public bool TryGetType(int id, [MaybeNullWhen(false)] out Type type)
	{
		if (id < 0 ||
			id >= Count)
		{
			type = null;
			return false;
		}

		type = _types[id];
		return true;
	}

	/// <summary>
	/// Gets the signature of given components
	/// </summary>
	/// <returns>Signature of component types</returns>
	public Signature GetSignature<T>()
	{
		return Signature.SingleBit(IdOf<T>());
    }

    /// <summary>
    /// Gets component ids for types
    /// </summary>
    /// <returns></returns>
    public ComponentIds<T> GetIds<T>()
    {
        return new(GetComponentType<T>().Id);
    }

    /// <summary>
    /// Gets the component id for a given type
    /// </summary>
    /// <typeparam name="T">The target type</typeparam>
    /// <returns>Component id for <typeparamref name="T"/></returns>
    public int IdOf<T>()
	{
		return GetComponentType<T>().Id;
	}

    /// <summary>
    /// Returns an array factory for a given id
    /// </summary>
    /// <param name="id">Id of the target component</param>
    /// <returns>An array factory for the component of the given id</returns>
    internal ArrayFactory GetArrayFactory(int id) => _arrayFactories[id];

	/// <summary>
	/// Adds a component type to the registry.
	/// </summary>
	/// <remarks>
	/// Must be called under a lock on <see cref="_lock"/>.
	/// </remarks>
	/// <typeparam name="T">The component type</typeparam>
	/// <returns></returns>
	/// <exception cref="MaxReachedException"></exception>
	private ref ComponentType AddComponentType<T>()
	{
		var id = Volatile.Read(ref _nextId);
		if (id >= MaxComponents)
			throw ThrowHelper.MaxComponentsReached(MaxComponents);

		var type = typeof(T);
		var internalCapacity = ComponentMeta<T>.InternalCapacity;
		var byteSize = ComponentMeta<T>.ByteSize;
		var isUnmanaged = ComponentMeta<T>.IsUnmanaged;

		if (byteSize > ComponentType.MaxSize)
			throw ThrowHelper.ComponentSizeExceeded(type, ComponentType.MaxSize);
		if (byteSize == 0 && internalCapacity > 0)
			throw ThrowHelper.ComponentBufferZeroSize(typeof(T));

		Volatile.Write(ref _nextId, id + 1);
		_componentTypes[id] = new ComponentType(id, (short)internalCapacity, (short)byteSize, isUnmanaged);
		_types[id] = type;
		_arrayFactories[id] = static (int length) => new T[length];
		_typeMap[type] = id;
		return ref _componentTypes[id];
	}
}
