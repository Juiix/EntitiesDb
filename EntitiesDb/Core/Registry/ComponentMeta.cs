using System;

namespace EntitiesDb;

public static class ComponentMeta<T>
{
	public readonly static int InternalCapacity;
	public readonly static int ByteSize;
	public readonly static int Stride;
	public readonly static bool IsUnmanaged;
	public readonly static bool IsBuffered;

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

		return BufferHeader.DataOffset + Math.Max(internalCapacity * byteSize, nint.Size);
	}
}
