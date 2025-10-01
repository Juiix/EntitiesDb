using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

internal static class TypeUtils
{
	/// <summary>
	/// Retrieves the internal capacity from the [Buffered] attribute
	/// </summary>
	/// <param name="type">The target type</param>
	/// <returns>The internal capacity, if buffered, else -1</returns>
	public static short GetBufferedInternalCapacity(Type type)
	{
		var bufferable = type.GetCustomAttribute<BufferedAttribute>();
		if (bufferable == null) return -1;
		return bufferable.InternalCapacity;
	}

	/// <summary>
	/// Retrieves the byte size 
	/// </summary>
	/// <param name="type">The target type</param>
	/// <returns>The internal capacity, if buffered, else -1</returns>
	public static int GetByteSize<T>()
	{
		var type = typeof(T);
		var zeroSize = type.GetCustomAttribute<ZeroSizeAttribute>();
		return !type.IsValueType
			? nint.Size
			: zeroSize != null 
			? 0
			: Unsafe.SizeOf<T>();
	}

	/// <summary>
	/// Returns if <typeparamref name="T"/> is an unmanaged type
	/// </summary>
	/// <typeparam name="T">The type to check</typeparam>
	/// <returns>If <typeparamref name="T"/> is unmanaged</returns>
	public static bool IsUnmanaged<T>()
	{
		return !RuntimeHelpers.IsReferenceOrContainsReferences<T>();
	}
}
