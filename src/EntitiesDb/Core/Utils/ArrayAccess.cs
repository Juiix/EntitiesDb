using System.Runtime.CompilerServices;
#if !NETSTANDARD2_1
using System.Runtime.InteropServices;
#endif

namespace EntitiesDb;

internal static class ArrayAccess
{
	/// <summary>
	/// <c>ref array[index]</c> without the bounds check, for indices an invariant already keeps in range
	/// (a chunk index read from the entity map, a component id below <see cref="ComponentRegistry.MaxComponents"/>).
	/// netstandard2.1 has no <c>GetArrayDataReference</c> and keeps the check.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ref T At<T>(T[] array, int index)
	{
#if NETSTANDARD2_1
		return ref array[index];
#else
		return ref Unsafe.Add(ref MemoryMarshal.GetArrayDataReference(array), (nint)(uint)index);
#endif
	}
}
