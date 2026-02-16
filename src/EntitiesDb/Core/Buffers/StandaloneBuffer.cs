using System;
using System.Runtime.InteropServices;

namespace EntitiesDb;

public unsafe sealed class StandaloneBuffer<T> : IDisposable where T : unmanaged
{
	private IntPtr _owner;

	public StandaloneBuffer(ReadOnlySpan<T> data = default)
	{
		int headerBytes = BufferHeader.DataOffset;
		nint total = headerBytes + (ComponentMeta<T>.InternalCapacity * ComponentMeta<T>.ByteSize);
		_owner = Marshal.AllocHGlobal(total);

		var buffer = new WriteBuffer<T>(_owner.ToPointer());
		buffer.Init(data);
	}

	public WriteBuffer<T> Buffer => new(_owner.ToPointer());

	public void Dispose()
	{
		try { if (_owner != IntPtr.Zero) Buffer.Clear(); }
		finally
		{
			if (_owner != IntPtr.Zero) Marshal.FreeHGlobal(_owner);
			_owner = IntPtr.Zero;
		}
	}
}
