using System.Runtime.CompilerServices;
#if !NETSTANDARD2_1
using System.Numerics;
#endif

namespace EntitiesDb;

public readonly partial struct Signature
{
	/// <summary>
	/// Index of the lowest set bit of a non-zero word
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int LowestSetBit(ulong word)
	{
#if NETSTANDARD2_1
		return TrailingZeroCount(word);
#else
		return BitOperations.TrailingZeroCount(word);
#endif
	}
}
