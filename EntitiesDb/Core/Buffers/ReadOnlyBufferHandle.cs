using System.Runtime.CompilerServices;

namespace EntitiesDb;

public unsafe readonly ref struct ReadOnlyBufferHandle<T> where T : unmanaged
{
	private readonly void* _header;

	internal ReadOnlyBufferHandle(ref BufferHeader header)
	{
		_header = Unsafe.AsPointer(ref header);
	}

	public ReadOnlyBuffer<T> this[int index] => new(ref GetHeader(index));

	private ref BufferHeader GetHeader(int index) => ref Unsafe.AsRef<BufferHeader>((byte*)_header + ComponentMeta<T>.Stride * index);
}
