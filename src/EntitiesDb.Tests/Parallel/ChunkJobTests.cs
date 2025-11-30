// EntitiesDb.Tests/ChunkJobTests.cs
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace EntitiesDb.Parallel;

public sealed class ChunkJobTests
{
	// --- Test 1: single-range path (Start == End) ---
	// range: start=10 size=5 => absolute chunk indices: [10,11,12,13,14]
	// First=1, Last=4 => should visit [11,12,13]
	[Fact]
	public void Execute_SingleRange_RespectsFirstAndLast_InclusiveEndContract()
	{
		var archetype = new Archetype(totalChunks: 50);

		var ranges = new[]
		{
			new ChunkRange(start: 10, size: 5)
		};
		var spanList = new SpanList<ChunkRange>(ranges);

		var job = new ChunkJob<TestJob>
		{
			Archetype = archetype,
			Ranges = spanList,
			Start = 0,
			End = 0,     // inclusive
			First = 1,
			Last = 4,    // loop is i = First .. < Last  => [1,2,3]
			ForEach = new TestJob()
		};

		job.Execute();

		Assert.True(job.ForEach.EnteredWith == archetype);
		Assert.Equal(new[] { 11, 12, 13 }, job.ForEach.Visited);
	}

	// --- Test 2: multi-range path with middle ranges ---
	// ranges:
	//   R0: start=0, size=3   => [0,1,2]
	//   R1: start=3, size=4   => [3,4,5,6]
	//   R2: start=7, size=5   => [7,8,9,10,11]
	// Execute over Start=0, End=2 (inclusive).
	//   First range tail: First=1 => visit [1,2]
	//   Middle full ranges: R1 => [3,4,5,6]
	//   Last range head: Last=2 => visit [7,8]
	// Expected visitation order: [1,2,3,4,5,6,7,8]
	[Fact]
	public void Execute_MultiRange_VisitsTailFullMiddleHead_InCorrectOrder()
	{
		var archetype = new Archetype(totalChunks: 100);

		var ranges = new[]
		{
			new ChunkRange(0, 3),
			new ChunkRange(3, 4),
			new ChunkRange(7, 5)
		};
		var spanList = new SpanList<ChunkRange>(ranges);

		var job = new ChunkJob<TestJob>
		{
			Archetype = archetype,
			Ranges = spanList,
			Start = 0,
			End = 2,   // inclusive
			First = 1, // tail of first range: [1,2]
			Last = 2,  // head of last range: [0,1] -> absolute [7,8]
			ForEach = new TestJob()
		};

		job.Execute();

		Assert.True(job.ForEach.EnteredWith == archetype);
		Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, job.ForEach.Visited);
	}

	// --- Test 3: multi-range, edge-aligned ---
	// ranges:
	//   R0: [100..104] (size=5)
	//   R1: [105..107] (size=3)
	// Start=0, End=1 (inclusive), First=0, Last=1
	// Expect: full R0 [100,101,102,103,104], head of R1 up to Last-1 => [105]
	// Total: [100,101,102,103,104,105]
	[Fact]
	public void Execute_MultiRange_EdgeAligned_TakesFullFirst_AndHeadOfLast()
	{
		var archetype = new Archetype(totalChunks: 200);

		var ranges = new[]
		{
			new ChunkRange(100, 5),
			new ChunkRange(105, 3)
		};
		var spanList = new SpanList<ChunkRange>(ranges);

		var job = new ChunkJob<TestJob>
		{
			Archetype = archetype,
			Ranges = spanList,
			Start = 0,
			End = 1,   // inclusive
			First = 0, // full first range
			Last = 1,  // head of last: [105]
			ForEach = new TestJob()
		};

		job.Execute();

		Assert.True(job.ForEach.EnteredWith == archetype);
		Assert.Equal(new[] { 100, 101, 102, 103, 104, 105 }, job.ForEach.Visited);
	}

	// --- Test 4: degenerate "empty" work when First == Last on Start==End ---
	// Should visit nothing but still call Enter.
	[Fact]
	public void Execute_SingleRange_EmptyWindow_VisitsNothing()
	{
		var archetype = new Archetype(totalChunks: 20);

		var ranges = new[]
		{
			new ChunkRange(5, 4) // [5,6,7,8]
        };
		var spanList = new SpanList<ChunkRange>(ranges);

		var job = new ChunkJob<TestJob>
		{
			Archetype = archetype,
			Ranges = spanList,
			Start = 0,
			End = 0,
			First = 2,
			Last = 2,   // no iterations
			ForEach = new TestJob()
		};

		job.Execute();

		Assert.True(job.ForEach.EnteredWith == archetype);
		Assert.Empty(job.ForEach.Visited);
	}

	/* -------------------------------------------------------
 * Minimal fakes to support the tests
 * -----------------------------------------------------*/
	// Mirror the contract that ChunkJob<T> expects:
	internal interface IJob { void Execute(); }

	public interface IChunkJob
	{
		void Enter(Archetype archetype);
		void ForEach(in Chunk chunk);
	}

	public readonly struct ChunkRange
	{
		public readonly int Start;
		public readonly int Size;
		public ChunkRange(int start, int size)
		{
			Start = start;
			Size = size;
		}
	}

	// Simple span-like list with just an indexer
	public readonly struct SpanList<T>
	{
		private readonly T[] _items;
		public SpanList(T[] items) => _items = items;
		public ref readonly T this[int index] => ref _items[index];
		public int Length => _items?.Length ?? 0;
	}

	public readonly struct Chunk
	{
		public readonly int Index;
		public Chunk(int index) => Index = index;
		public override string ToString() => $"Chunk[{Index}]";
	}

	public sealed class Archetype
	{
		private readonly Chunk[] _chunks;
		public Archetype(int totalChunks)
		{
			_chunks = Enumerable.Range(0, totalChunks)
								.Select(i => new Chunk(i))
								.ToArray();
		}

		public ref readonly Chunk GetChunk(int index) => ref _chunks[index];
	}

	/* -------------------------------------------------------
	 * Recorder job that captures the order of visited chunks
	 * -----------------------------------------------------*/
	public sealed class TestJob : IChunkJob
	{
		public Archetype EnteredWith { get; private set; } = null!;
		public List<int> Visited { get; } = new();

		public void Enter(Archetype archetype)
			=> EnteredWith = archetype;

		public void ForEach(in Chunk chunk)
			=> Visited.Add(chunk.Index);
	}

	internal sealed class ChunkJob<T> : IJob where T : IChunkJob
	{
		public Archetype Archetype;
		public SpanList<ChunkRange> Ranges;
		public int Start;
		public int End;
		public int First;
		public int Last;
		public T ForEach;

		public void Execute()
		{
			var archetype = Archetype;
			ForEach.Enter(Archetype);

			var range = Ranges[Start];
			if (Start == End)
			{
				for (int i = First; i < Last; i++)
				{
					ref readonly var chunk = ref archetype.GetChunk(range.Start + i);
					ForEach.ForEach(in chunk);
				}
				return;
			}

			for (int i = First; i < range.Size; i++)
			{
				ref readonly var chunk = ref archetype.GetChunk(range.Start + i);
				ForEach.ForEach(in chunk);
			}

			for (int i = Start + 1; i < End; i++)
			{
				range = Ranges[i];
				for (int j = 0; j < range.Size; j++)
				{
					ref readonly var chunk = ref archetype.GetChunk(range.Start + j);
					ForEach.ForEach(in chunk);
				}
			}

			range = Ranges[End];
			for (int i = 0; i < Last; i++)
			{
				ref readonly var chunk = ref archetype.GetChunk(range.Start + i);
				ForEach.ForEach(in chunk);
			}
		}
	}
}