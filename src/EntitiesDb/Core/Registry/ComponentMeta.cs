using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

public static partial class ComponentMeta
{
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
}

public static class ComponentMeta<T>
{
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
	}

	private static int GetStride(int byteSize, bool isUnmanaged, int internalCapacity)
	{
		if (!isUnmanaged || internalCapacity <= 0)
			return byteSize;

		return BufferHeader.DataOffset + Math.Max(internalCapacity * byteSize, IntPtr.Size);
	}
}
