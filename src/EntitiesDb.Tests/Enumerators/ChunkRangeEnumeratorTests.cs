using System;
using System.Linq;
using Xunit;
using EntitiesDb;

namespace EntitiesDb.Enumerators;

public class ChunkRangeEnumeratorTests
{
	// ---- Adjust in one place if your ChunkRange ctor/shape differs ----
	private static ChunkRange[] MakeRanges(params int[] sizes)
	{
		var arr = new ChunkRange[sizes.Length];
		for (int i = 0; i < sizes.Length; i++)
		{
			// If your ChunkRange has a different shape, change this line accordingly.
			arr[i] = new ChunkRange(i, sizes[i]);
		}
		return arr;
	}

	private static int SliceCountFromCurrent(
		(int Start, int End, int First, int Last) cur,
		ChunkRange[] ranges)
	{
		int start = cur.Start;
		int endEx = cur.End;
		int first = cur.First;
		int last = cur.Last;

		if (start == endEx)
		{
			return last - first;
		}

		int count = ranges[start].Size - first;
		for (int i = start + 1; i < endEx; i++)
			count += ranges[i].Size;
		count += last;
		return count;
	}

	[Fact]
	public void SingleRange_EvenSpread_WithRemainderOnFirstSlices()
	{
		// size = 10, slices = 3  =>  4,3,3
		var ranges = MakeRanges(10);
		var e = new ChunkRangeEnumerator(ranges.AsSpan(), size: 10, slices: 3);

		int[] got = EnumerateSizes(e, ranges);
		Assert.Equal(new[] { 4, 3, 3 }, got);
		Assert.Equal(10, got.Sum());
	}

	[Fact]
	public void MultiRange_SpreadsAcrossBoundaries_Evenly()
	{
		// [3,7,5,9] total=24, slices=5 => 5,5,5,5,4
		var ranges = MakeRanges(3, 7, 5, 9);
		var e = new ChunkRangeEnumerator(ranges.AsSpan(), size: 24, slices: 5);

		var got = EnumerateSizes(e, ranges);
		Assert.Equal(new[] { 5, 5, 5, 5, 4 }, got);
		Assert.Equal(24, got.Sum());
	}

	[Fact]
	public void MultiRange_SlicesLimitedBySize_AndRemainderDistribution()
	{
		// [2,2,2] total=6, slices=4 => 2,2,1,1
		var ranges = MakeRanges(2, 2, 2);
		var e = new ChunkRangeEnumerator(ranges.AsSpan(), size: 6, slices: 4);

		var got = EnumerateSizes(e, ranges);
		Assert.Equal(new[] { 2, 2, 1, 1 }, got);
		Assert.Equal(6, got.Sum());
	}

	[Fact]
	public void Reset_ReenumeratesIdentically()
	{
		var ranges = MakeRanges(4, 4, 4); // total=12
		var e = new ChunkRangeEnumerator(ranges.AsSpan(), size: 12, slices: 5);
		var firstRun = EnumerateSizes(e, ranges);

		e.Reset();
		var secondRun = EnumerateSizes(e, ranges);

		Assert.Equal(firstRun, secondRun);
		Assert.Equal(new[] { 3, 3, 2, 2, 2 }, firstRun);
	}

	[Fact]
	public void Boundaries_AreContiguous_NoGaps_NoOverlap()
	{
		// [5,1,4] total=10, slices=4 => 3,3,2,2
		var ranges = MakeRanges(5, 1, 4);
		var e = new ChunkRangeEnumerator(ranges.AsSpan(), size: 10, slices: 4);

		var currents = CollectCurrents(e);

		var counts = currents.Select(c => SliceCountFromCurrent(c, ranges)).ToArray();
		Assert.Equal(new[] { 3, 3, 2, 2 }, counts);
		Assert.Equal(10, counts.Sum());

		var flat = currents.SelectMany(c => ExpandPositions(c, ranges)).ToArray();
		Assert.Equal(Enumerable.Range(0, 10).ToArray(), flat);
	}

	[Fact]
	public void Test()
	{
		var perfectRanges = new RangePartitioner(2661, 6);
		var rs = new List<ChunkRange>();
		foreach (var (start, size) in perfectRanges)
		{
			rs.Add(new ChunkRange(start, size));
		}
		var ranges = rs.ToArray();
		var e = new ChunkRangeEnumerator(ranges.AsSpan(), size: 2661, slices: 6);

		var currents = CollectCurrents(e);

		var counts = currents.Select(c => SliceCountFromCurrent(c, ranges)).ToArray();
		Assert.Equal(new[] { 444, 444, 444, 443, 443, 443 }, counts);
		Assert.Equal(2661, counts.Sum());

		var flat = currents.SelectMany(c => ExpandPositions(c, ranges)).ToArray();
		Assert.Equal(Enumerable.Range(0, 2661).ToArray(), flat);
	}

	// ---- Helpers (no yield/iterators) ----

	private static int[] EnumerateSizes(ChunkRangeEnumerator e, ChunkRange[] ranges)
	{
		var list = new System.Collections.Generic.List<int>();
		while (e.MoveNext())
			list.Add(SliceCountFromCurrent(e.Current, ranges));
		return list.ToArray();
	}

	private static (int Start, int End, int First, int Last)[] CollectCurrents(ChunkRangeEnumerator e)
	{
		var list = new System.Collections.Generic.List<(int, int, int, int)>();
		while (e.MoveNext())
			list.Add(e.Current);
		return list.ToArray();
	}

	private static System.Collections.Generic.IEnumerable<int> ExpandPositions(
		(int Start, int End, int First, int Last) cur,
		ChunkRange[] ranges)
	{
		var prefix = new int[ranges.Length + 1];
		for (int i = 0; i < ranges.Length; i++)
			prefix[i + 1] = prefix[i] + ranges[i].Size;

		int start = cur.Start;
		int endEx = cur.End;
		int first = cur.First;
		int last = cur.Last;

		if (start == endEx)
		{
			for (int o = first; o < last; o++)
				yield return prefix[start] + o;
			yield break;
		}

		for (int o = first; o < ranges[start].Size; o++)
			yield return prefix[start] + o;

		for (int r = start + 1; r < endEx; r++)
			for (int o = 0; o < ranges[r].Size; o++)
				yield return prefix[r] + o;

		int lastRange = endEx;
		for (int o = 0; o < last; o++)
			yield return prefix[lastRange] + o;
	}
}
