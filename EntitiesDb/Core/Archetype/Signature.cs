using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

/// <summary>
/// A bitset representing component types. 256-bit length
/// </summary>
public readonly partial struct Signature : IEquatable<Signature>
{
	public readonly ulong W0, W1, W2, W3;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Signature(ulong w0, ulong w1, ulong w2, ulong w3)
		=> (W0, W1, W2, W3) = (w0, w1, w2, w3);

	// --- Construction helpers -------------------------------------------------

	public static Signature Empty
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Signature SingleBit(int id)
	{
		int word = id >> 6; int bit = id & 63;
		ulong v = 1UL << bit;
		return word switch
		{
			0 => new(v, 0, 0, 0),
			1 => new(0, v, 0, 0),
			2 => new(0, 0, v, 0),
			3 => new(0, 0, 0, v),
			_ => throw new ArgumentOutOfRangeException(nameof(id))
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Signature MultipleBits(params Span<int> ids)
	{
		ulong w0 = 0, w1 = 0, w2 = 0, w3 = 0;
		foreach (ref var id in ids)
		{
			int word = id >> 6; int bit = id & 63; ulong m = 1UL << bit;
			switch (word)
			{
				case 0: w0 |= m; break;
				case 1: w1 |= m; break;
				case 2: w2 |= m; break;
				case 3: w3 |= m; break;
			}
		}
		return new Signature(w0, w1, w2, w3);
    }

    /// <summary>
    /// Gets the signature of given component ids
    /// </summary>
    /// <returns>Signature of component ids</returns>
    public static Signature FromIds<T>(in ComponentIds<T0> ids)
    {
        return SingleBit(ids.T0);
    }

    // --- Queries --------------------------------------------------------------

    public readonly bool IsEmpty => (W0 | W1 | W2 | W3) == 0;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly bool Test(int id)
	{
		int word = id >> 6; int bit = id & 63;
		return word switch
		{
			0 => (W0 & (1UL << bit)) != 0,
			1 => (W1 & (1UL << bit)) != 0,
			2 => (W2 & (1UL << bit)) != 0,
			3 => (W3 & (1UL << bit)) != 0,
			_ => false
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly int PopCount()
		=> BitOperations.PopCount(W0)
		 + BitOperations.PopCount(W1)
		 + BitOperations.PopCount(W2)
		 + BitOperations.PopCount(W3);

	// Relations (subset/superset/intersection)

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly bool HasAll(in Signature req)
		=> (W0 & req.W0) == req.W0
		&& (W1 & req.W1) == req.W1
		&& (W2 & req.W2) == req.W2
		&& (W3 & req.W3) == req.W3;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly bool HasAny(in Signature other)
		=> ((W0 & other.W0) | (W1 & other.W1) | (W2 & other.W2) | (W3 & other.W3)) != 0;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly bool HasNone(in Signature other) => !HasAny(other);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly bool IsSubsetOf(in Signature sup) => sup.HasAll(in this);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly bool IsSupersetOf(in Signature sub) => HasAll(in sub);

	// --- Bitwise (functional) -------------------------------------------------

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly Signature And(in Signature b)
		=> new(W0 & b.W0, W1 & b.W1, W2 & b.W2, W3 & b.W3);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly Signature Or(in Signature b)
		=> new(W0 | b.W0, W1 | b.W1, W2 | b.W2, W3 | b.W3);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly Signature Xor(in Signature b)
		=> new(W0 ^ b.W0, W1 ^ b.W1, W2 ^ b.W2, W3 ^ b.W3);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly Signature AndNot(in Signature b)
		=> new(W0 & ~b.W0, W1 & ~b.W1, W2 & ~b.W2, W3 & ~b.W3);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly Signature Not() => new(~W0, ~W1, ~W2, ~W3);

	// --- Operators ------------------------------------------------------------

	public static Signature operator &(in Signature a, in Signature b) => a.And(in b);
	public static Signature operator |(in Signature a, in Signature b) => a.Or(in b);
	public static Signature operator ^(in Signature a, in Signature b) => a.Xor(in b);
	public static Signature operator ~(in Signature a) => a.Not();

	public static bool operator ==(in Signature a, in Signature b)
		=> a.W0 == b.W0 && a.W1 == b.W1 && a.W2 == b.W2 && a.W3 == b.W3;

	public static bool operator !=(Signature a, Signature b) => !(a == b);

	// --- Equality / Hash ------------------------------------------------------

	public readonly bool Equals(in Signature other) => this == other;
	public readonly bool Equals(Signature other) => this == other;

	public readonly override bool Equals(object? obj) => obj is Signature s && Equals(s);

	public readonly override int GetHashCode()
	{
		// Strong-ish 64->32 mix (fmix64)
		ulong x = W0 ^ (W1 * 0x9E3779B97F4A7C15UL) ^ (W2 << 1) ^ (W3 >> 1);
		x ^= x >> 33; x *= 0xff51afd7ed558ccdUL;
		x ^= x >> 33; x *= 0xc4ceb9fe1a85ec53UL;
		x ^= x >> 33;
		return (int)x;
	}

	// --- Mutators that return a new value (fluent, keeps struct immutable) ----

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly Signature WithSet(int id)
	{
		int word = id >> 6; int bit = id & 63; ulong m = 1UL << bit;
		return word switch
		{
			0 => new(W0 | m, W1, W2, W3),
			1 => new(W0, W1 | m, W2, W3),
			2 => new(W0, W1, W2 | m, W3),
			3 => new(W0, W1, W2, W3 | m),
			_ => this // ignore OOR to keep it branch-free for hot paths (or throw)
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly Signature WithSets(params Span<int> ids)
	{
		ulong w0 = W0, w1 = W1, w2 = W2, w3 = W3;
		foreach (ref var id in ids)
		{
			int word = id >> 6; int bit = id & 63; ulong m = 1UL << bit;
			switch (word)
			{
				case 0: w0 |= m; break;
				case 1: w1 |= m; break;
				case 2: w2 |= m; break;
				case 3: w3 |= m; break;
			}
		}
		return new Signature(w0, w1, w2, w3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly Signature WithCleared(int id)
	{
		int word = id >> 6; int bit = id & 63; ulong m = ~(1UL << bit);
		return word switch
		{
			0 => new(W0 & m, W1, W2, W3),
			1 => new(W0, W1 & m, W2, W3),
			2 => new(W0, W1, W2 & m, W3),
			3 => new(W0, W1, W2, W3 & m),
			_ => this
		};
	}

	// --- Iteration helper -----------------------------------------------------

	/// <summary>
	/// Find the next set bit >= start, or return false if none.
	/// </summary>
	public readonly bool TryGetNextSetBit(int start, out int index)
	{
		if ((uint)start >= 256) { index = -1; return false; }

		int word = start >> 6;
		int bit = start & 63;

		ulong w = word switch
		{
			0 => W0,
			1 => W1,
			2 => W2,
			_ => W3
		};

		// Mask off bits before 'bit' in the first word
		w &= ~((1UL << bit) - 1);

		for (int widx = word; widx < 4; widx++)
		{
			if (w != 0)
			{
				int tz = BitOperations.TrailingZeroCount(w);
				index = (widx << 6) + tz;
				return true;
			}

			if (widx == 0) w = W1;
			else if (widx == 1) w = W2;
			else if (widx == 2) w = W3;
		}

		index = -1;
		return false;
	}

	public readonly override string ToString()
		=> $"[{Convert.ToString((long)W3, 2).PadLeft(64, '0')}_"
		 + $"{Convert.ToString((long)W2, 2).PadLeft(64, '0')}_"
		 + $"{Convert.ToString((long)W1, 2).PadLeft(64, '0')}_"
		 + $"{Convert.ToString((long)W0, 2).PadLeft(64, '0')}]";
}
