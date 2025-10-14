#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type
using System;

namespace EntitiesDb;

internal static unsafe class Dangerous
{
	public static ref T NullRef<T>() => ref *(T*)null;

	public static T* AsPointer<T>(ref T v)
	{
		fixed (T* vp = &v)
		{
			return vp;
		}
	}
}

#pragma warning restore CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type