#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type
using System;
using System.Threading;

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

	public static bool InterlockedExchangeIfGreaterThan(ref int location, int comparison, int newValue)
	{
		unchecked
		{
			int initialValue;
			do
			{
				initialValue = Volatile.Read(ref location);
				if (initialValue - comparison > 0) return false;
			}
			while (Interlocked.CompareExchange(ref location, newValue, initialValue) != initialValue);
			return true;
		}
	}
}

#pragma warning restore CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type