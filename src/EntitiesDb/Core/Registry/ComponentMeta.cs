using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace EntitiesDb;

public static partial class ComponentMeta
{
	private static int _nextGlobalId;

    /// <summary>
    /// Asserts that components are buffered
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertBuffered<T0>()
    {
        if (!ComponentMeta<T0>.IsBuffered)
            throw ThrowHelper.ComponentNotBuffered(typeof(T0));
    }

    /// <summary>
    /// Asserts that components are not buffered
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void AssertNotBuffered<T0>()
    {
        if (ComponentMeta<T0>.IsBuffered)
            throw ThrowHelper.ComponentBuffered(typeof(T0));
	}

	/// <summary>
	/// Asserts that components are not buffered
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNonZeroSize<T0>()
	{
		if (ComponentMeta<T0>.IsZeroSize)
			throw ThrowHelper.ComponentZeroSize(typeof(T0));
	}

	internal static int RegisterGlobalId()
	{
		var globalId = Interlocked.Increment(ref _nextGlobalId);
		return globalId;
	}
}

public static class ComponentMeta<T>
{
	/// <summary>
	/// The global (application-scoped) id of this type
	/// </summary>
	public readonly static int GlobalId;

	/// <summary>
	/// The internal inline buffer capacity,  -1 if not buffered
	/// </summary>
	public readonly static int InternalCapacity;

	/// <summary>
	/// The component size in bytes
	/// </summary>
	public readonly static int ByteSize;

	/// <summary>
	/// The components byte stride (size * internalCapacity if buffered)
	/// </summary>
	public readonly static int Stride;

	/// <summary>
	/// If this component is unmanaged
	/// </summary>
	public readonly static bool IsUnmanaged;

	/// <summary>
	/// If this component is buffered
	/// </summary>
	public readonly static bool IsBuffered;

	/// <summary>
	/// If this component is zero size
	/// </summary>
	public static bool IsZeroSize => ByteSize == 0;

	static ComponentMeta()
	{
		var byteSize = TypeUtils.GetByteSize<T>();
		InternalCapacity = TypeUtils.GetBufferedInternalCapacity(typeof(T));
		IsUnmanaged = TypeUtils.IsUnmanaged<T>();
		IsBuffered = IsUnmanaged && InternalCapacity > 0;
		Stride = GetStride(byteSize, IsUnmanaged, InternalCapacity);
		ByteSize = byteSize;
		GlobalId = ComponentMeta.RegisterGlobalId();
	}

	private static int GetStride(int byteSize, bool isUnmanaged, int internalCapacity)
	{
		if (!isUnmanaged || internalCapacity <= 0)
			return byteSize;

		return BufferHeader.DataOffset + Math.Max(internalCapacity * byteSize, IntPtr.Size);
	}
}
