using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

internal static class TypeUtils
{
	public static short GetBufferedInternalCapacity(Type type)
	{
		var bufferable = type.GetCustomAttribute<BufferedAttribute>();
		if (bufferable == null) return -1;
		return bufferable.InternalCapacity;
	}

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

	public static bool IsUnmanaged<T>()
	{
		return !RuntimeHelpers.IsReferenceOrContainsReferences<T>();
	}
}
