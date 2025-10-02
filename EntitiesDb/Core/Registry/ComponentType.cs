using System;
using System.Runtime.InteropServices;

namespace EntitiesDb;

public readonly struct ComponentType(int id, short internalCapacity, short byteSize, bool isUnmanaged)
{
	public const int MaxSize = short.MaxValue;

	/// <summary>
	/// The unique type id assigned by the component registry
	/// </summary>
	public readonly int Id { get; } = id;

	/// <summary>
	/// The internal buffer capacity of the component, -1 if the type is not buffered
	/// </summary>
	public readonly short InternalCapacity { get; } = (short)(isUnmanaged ? internalCapacity : -1);

	/// <summary>
	/// The size of this component when stored in a chunk
	/// </summary>
	/// <remarks>
	/// Managed components return negative values
	/// </remarks>
	public readonly short Stride { get; } = (short)GetStride(byteSize, isUnmanaged, internalCapacity);

	/// <summary>
	/// Size of the raw component in bytes
	/// </summary>
	public readonly int ByteSize => Math.Abs(Stride);

	/// <summary>
	/// If this component is unmanaged
	/// </summary>
	public readonly bool IsUnmanaged => Stride >= 0;

	/// <summary>
	/// If this component is buffered
	/// </summary>
	public readonly bool Buffered => InternalCapacity > 0;

	/// <summary>
	/// If the component contains no data
	/// </summary>
	public readonly bool ZeroSize => ByteSize == 0;

	private static int GetStride(short byteSize, bool isUnmanaged, int internalCapacity)
	{
		if (!isUnmanaged)
			return -byteSize;

		if (internalCapacity <= 0)
			return byteSize;

		return BufferHeader.DataOffset + Math.Max(internalCapacity * byteSize, Marshal.SizeOf<nint>());
	}
}