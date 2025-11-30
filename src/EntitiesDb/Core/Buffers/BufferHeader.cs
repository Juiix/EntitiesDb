using System.Runtime.InteropServices;

namespace EntitiesDb;

[StructLayout(LayoutKind.Explicit)]
internal struct BufferHeader
{
    public const int DataOffset = sizeof(int) * 2;

    [FieldOffset(0)]
    public int Capacity;
    [FieldOffset(4)]
    public int Size;
    [FieldOffset(8)]
    public nint Heap;
}
