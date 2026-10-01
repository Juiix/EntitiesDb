using System;
using System.Buffers;
using System.Runtime.InteropServices;

namespace EntitiesDb;

/// <summary>
/// The work list for one parallel query call: the matching chunk ranges (possibly spanning many
/// archetypes) plus a shared claim cursor. Every job claims batches of chunks from the cursor until
/// the list is exhausted, so a stalled thread only delays its own batch instead of the whole join.
/// </summary>
internal sealed class ChunkJobWork
{
	private const int InitialRangeCapacity = 256;

	public SpanList<Archetype> RangeArchetypes = new(InitialRangeCapacity);
	public SpanList<ChunkRange> Ranges = new(InitialRangeCapacity);

	/// <summary>Exclusive cumulative chunk count per range (RangeEnds[i] = sum of Ranges[0..i].Size).</summary>
	public int[] RangeEnds = ArrayPool<int>.Shared.Rent(InitialRangeCapacity);

	public int RangeCount;
	public int TotalChunks;

	/// <summary>Number of jobs sharing this work list (drives the guided claim size).</summary>
	public int JobCount;

	private Cursor _cursor;

	// keep the hot cursor on its own cache line so claims don't false-share with the read-only fields above
	[StructLayout(LayoutKind.Explicit, Size = 128)]
	private struct Cursor
	{
		[FieldOffset(64)] public int Next;
	}

	public void Reset()
	{
		RangeCount = 0;
		TotalChunks = 0;
		_cursor.Next = 0;
	}

	public void Append(Archetype archetype, in ChunkRange range)
	{
		if (range.Size <= 0) return;

		// the pooled lists keep prior capacity/entries; overwrite in place while slots exist, append past the end
		if (RangeCount >= Ranges.Count) Ranges.Add(range); else Ranges[RangeCount] = range;
		if (RangeCount >= RangeArchetypes.Count) RangeArchetypes.Add(archetype); else RangeArchetypes[RangeCount] = archetype;

		if (RangeCount >= RangeEnds.Length)
		{
			var grown = ArrayPool<int>.Shared.Rent(RangeEnds.Length * 2);
			Array.Copy(RangeEnds, grown, RangeEnds.Length);
			ArrayPool<int>.Shared.Return(RangeEnds);
			RangeEnds = grown;
		}

		TotalChunks += range.Size;
		RangeEnds[RangeCount] = TotalChunks;
		RangeCount++;
	}

	public void Finish(int jobCount)
	{
		JobCount = Math.Max(1, jobCount);
	}

	/// <summary>
	/// Claims the next batch of chunks (guided self-scheduling: each claim takes
	/// <c>remaining / jobs</c> chunks, so early claims are large and contiguous — few contended
	/// atomics, prefetch-friendly — and claims shrink geometrically toward the tail so a slow thread
	/// only ever delays the join by its current, small batch). Returns false when the list is exhausted.
	/// </summary>
	public bool TryClaim(out int start, out int end)
	{
		var total = TotalChunks;
		var divisor = JobCount;
		var current = System.Threading.Volatile.Read(ref _cursor.Next);
		while (current < total)
		{
			var size = Math.Max(1, (total - current) / divisor);
			var next = current + size;
			var seen = System.Threading.Interlocked.CompareExchange(ref _cursor.Next, next, current);
			if (seen == current)
			{
				start = current;
				end = next;
				return true;
			}
			current = seen;
		}

		start = end = total;
		return false;
	}
}
