using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace EntitiesDb;

/// <summary>
/// Thread-safe registry that assigns unique IDs to component types and supports lock-free reads via snapshotting.
/// </summary>
public static partial class ComponentRegistry
{
	public const int MaxComponents = 256;

	private static readonly ComponentType[] _componentTypes = new ComponentType[MaxComponents];
	private static readonly Type[] _types = new Type[MaxComponents];
	private static readonly ArrayFactory[] _arrayFactories = new ArrayFactory[MaxComponents];
	private static readonly object _lock = new();

	private static int _nextId = 0;

	public static int Count => Volatile.Read(ref _nextId);

	/// <summary>
	/// Gets the <see cref="ComponentType"/> associated with the specified <paramref name="id"/>.
	/// </summary>
	/// <param name="id">The component type identifier.</param>
	/// <returns>The matching <see cref="ComponentType"/>.</returns>
	/// <exception cref="IndexOutOfRangeException"></exception>
	public static ref readonly ComponentType GetComponentType<T>()
	{
		return ref Component<T>.ComponentType;
	}

	/// <summary>
	/// Gets the <see cref="ComponentType"/> associated with the specified <paramref name="id"/>.
	/// </summary>
	/// <param name="id">The component type identifier.</param>
	/// <returns>The matching <see cref="ComponentType"/>.</returns>
	/// <exception cref="IndexOutOfRangeException"></exception>
	public static ref readonly ComponentType GetComponentType(int id)
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
	public static ref readonly ComponentType TryGetComponentType(int id, out bool found)
	{
		if (id < 0 ||
			id >= Count)
		{
			found = false;
			return ref Dangerous.NullRef<ComponentType>();
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
	public static Type GetType(int id)
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
#if NETSTANDARD2_1
	public static bool TryGetType(int id, out Type? type)
#else
	public static bool TryGetType(int id, [MaybeNullWhen(false)] out Type type)
#endif
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
    /// Returns an array factory for a given id
    /// </summary>
    /// <param name="id">Id of the target component</param>
    /// <returns>An array factory for the component of the given id</returns>
    internal static ArrayFactory GetArrayFactory(int id) => _arrayFactories[id];

	/// <summary>
	/// Registers a new component type
	/// </summary>
	/// <typeparam name="T">The component type</typeparam>
	/// <param name="componentType">The created <see cref="ComponentType"/></param>
	/// <param name="arrayFactory">An array factory for the given type</param>
	/// <returns></returns>
	internal static int Register<T>(out ComponentType componentType, out ArrayFactory arrayFactory)
	{
		lock (_lock)
		{
			var id = Volatile.Read(ref _nextId);
			if (id >= MaxComponents)
				throw ThrowHelper.MaxComponentsReached(MaxComponents);

			var type = typeof(T);
			var internalCapacity = ComponentMeta<T>.InternalCapacity;
			var byteSize = ComponentMeta<T>.ByteSize;
			var isUnmanaged = ComponentMeta<T>.IsUnmanaged;
			var trackChanges = ComponentMeta<T>.TrackChanges;
			var flags = ComponentFlags.None;
			flags |= trackChanges ? ComponentFlags.TrackChanges : ComponentFlags.None;

			if (byteSize > ComponentType.MaxSize)
				throw ThrowHelper.ComponentSizeExceeded(type, ComponentType.MaxSize);
			if (byteSize == 0 && internalCapacity > 0)
				throw ThrowHelper.ComponentBufferZeroSize(typeof(T));

			Volatile.Write(ref _nextId, id + 1);
			_componentTypes[id] = componentType = new ComponentType((byte)id, (short)internalCapacity, (short)byteSize, isUnmanaged, flags);
			_types[id] = type;
			_arrayFactories[id] = arrayFactory = static (int length) => new T[length];
			return id;
		}
	}
}

public static class Component<T>
{
	public readonly static int Id;
	public readonly static Signature Signature;
	public readonly static ComponentType ComponentType;
	internal readonly static ArrayFactory ArrayFactory;

	static Component()
	{
		Id = ComponentRegistry.Register<T>(out ComponentType, out ArrayFactory);
		Signature = Signature.SingleBit(Id);
	}
}

public static class ComponentSingle<T>
{
	public readonly static int Id;
	public readonly static Signature Signature;

	static ComponentSingle()
	{
		if (ComponentMeta<T>.IsBuffered)
			throw ThrowHelper.ComponentBuffered(typeof(T));
		Id = Component<T>.Id;
		Signature = Signature.SingleBit(Id);
	}
}

public static class ComponentBuffer<T>
{
	public readonly static int Id;
	public readonly static Signature Signature;

	static ComponentBuffer()
	{
		if (!ComponentMeta<T>.IsBuffered)
			throw ThrowHelper.ComponentNotBuffered(typeof(T));
		if (ComponentMeta<T>.IsZeroSize)
			throw ThrowHelper.ComponentBufferZeroSize(typeof(T));
		Id = Component<T>.Id;
		Signature = Signature.SingleBit(Id);
	}
}

public static class ComponentSingleWritable<T>
{
	public readonly static int Id;
	public readonly static int Check;
	public readonly static Signature Signature;

	static ComponentSingleWritable()
	{
		if (ComponentMeta<T>.IsBuffered)
			throw ThrowHelper.ComponentBuffered(typeof(T));
		if (ComponentMeta<T>.IsZeroSize)
			throw ThrowHelper.ComponentZeroSize(typeof(T));
		Id = Component<T>.Id;
		Check = Id;
		Signature = Signature.SingleBit(Id);
	}
}

public static class ComponentBufferWritable<T>
{
	public readonly static int Id;
	public readonly static int Check;
	public readonly static Signature Signature;

	static ComponentBufferWritable()
	{
		if (!ComponentMeta<T>.IsBuffered)
			throw ThrowHelper.ComponentNotBuffered(typeof(T));
		if (ComponentMeta<T>.IsZeroSize)
			throw ThrowHelper.ComponentBufferZeroSize(typeof(T));
		Id = Component<T>.Id;
		Check = Id;
		Signature = Signature.SingleBit(Id);
	}
}