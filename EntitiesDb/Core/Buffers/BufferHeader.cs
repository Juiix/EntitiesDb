using System.Runtime.InteropServices;

namespace EntitiesDb;

[StructLayout(LayoutKind.Explicit)]
internal struct BufferHeader
{
    public const int DataOffset = sizeof(int) * 2;

    [FieldOffset(0)]
    public int InternalCapacity;
    [FieldOffset(4)]
    public int Size;
    [FieldOffset(8)]
    public nint Heap;

    /// <summary>
    /// Disposes unmanaged resource.
    /// </summary>
    public void Dispose()
    {
        if (Size > InternalCapacity)
        {
            Marshal.FreeHGlobal(Heap);
        }
        Size = 0;
    }
}
