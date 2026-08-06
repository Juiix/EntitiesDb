using System;
using System.Buffers;

namespace EntitiesDb;

public partial class Query
{
	private readonly struct DefaultAggregate<TJob>(TJob baseJob) : IParallelAggregate<TJob> where TJob : IChunkJob
	{
		public readonly TJob BaseJob = baseJob;
		public readonly TJob Create(int threadIndex) => BaseJob;
		public readonly void Join(int threadIndex, ref TJob job) { }
	}

	public void ChunkJobParallel<T, TAggregate>(ref TAggregate aggregate, ParallelOptions options = default)
		where T : IChunkJob
		where TAggregate : IParallelAggregate<T>
	{
		if (_parallelRunner is null)
		{
			// if no parallel threads are enabled, call inline
			var job = aggregate.Create(0);
			ChunkJob(ref job);
			aggregate.Join(0, ref job);
			return;
		}

		var changeFilter = ChangeFilter;
		var compareVersion = changeFilter?.Version;

		var jobPool = JobMeta<T>.JobPool;
		var rangesPool = JobMeta.RangesPool;
		var rangeArchetypesPool = JobMeta.RangeArchetypesPool;
		var ranges = rangesPool.Rent();
		var rangeArchetypes = rangeArchetypesPool.Rent();
		var threadCount = options.MaxThreads > 0
			? Math.Min(options.MaxThreads, _parallelRunner.ThreadCount)
			: _parallelRunner.ThreadCount;

		// collect chunk ranges across ALL matching archetypes so the whole query
		// costs a single fork/join, instead of one barrier per archetype —
		// otherwise parallel overhead scales with archetype fragmentation
		int totalRanges = 0;
		int totalChunks = 0;
		foreach (var archetype in EnumerateArchetypes())
			AppendRanges(archetype, changeFilter, compareVersion, ref ranges, ref rangeArchetypes, threadCount, ref totalRanges, ref totalChunks);

		if (totalRanges == 0)
		{
			rangeArchetypesPool.Return(rangeArchetypes);
			rangesPool.Return(ranges);
			return;
		}

		var jobs = ArrayPool<IJob?>.Shared.Rent(threadCount);
		int jobI = 0;
		var chunkRanges = new ChunkRangePartitioner(ranges.AsSpan()[..totalRanges], totalChunks, threadCount);
		foreach (var (start, end, first, last) in chunkRanges)
		{
			var job = jobPool.Rent();
			jobs[jobI] = job;
			job.Start = start;
			job.End = end;
			job.First = first;
			job.Last = last;
			job.RangeArchetypes = rangeArchetypes;
			job.Ranges = ranges;
			job.ForEach = aggregate.Create(jobI++);
		}

		_parallelRunner.ExecuteJobs(jobs.AsMemory(0, jobI));

		for (var i = 0; i < jobI; i++)
		{
			var job = (ChunkJob<T>)jobs[i]!;
			aggregate.Join(i, ref job.ForEach);
			jobPool.Return(job);
			jobs[i] = null;
		}
		ArrayPool<IJob?>.Shared.Return(jobs);
		rangeArchetypesPool.Return(rangeArchetypes);
		rangesPool.Return(ranges);
	}

	public void ChunkJobParallel<T>(in T chunkJob, ParallelOptions options = default)
		where T : IChunkJob
	{
		var aggregate = new DefaultAggregate<T>(chunkJob);
		ChunkJobParallel<T, DefaultAggregate<T>>(ref aggregate, options);
	}

	private static void AppendRanges(Archetype archetype, ChangeFilter? changeFilter, int? compareVersion,
		ref SpanList<ChunkRange> ranges, ref SpanList<Archetype> rangeArchetypes, int slices,
		ref int rangeCount, ref int chunkCount)
	{
		if (changeFilter != null)
		{
			var filteredRanges = new ChangeFilterIterator(archetype.ChunkSpan, changeFilter, compareVersion!.Value);
			foreach (var chunkRange in filteredRanges)
			{
				Append(ref ranges, ref rangeArchetypes, archetype, chunkRange, ref rangeCount);
				chunkCount += chunkRange.Size;
			}
		}
		else
		{
			// pre-slice large archetypes so a single archetype can still split
			// across all threads
			foreach (var (start, size) in new RangePartitioner(archetype.ChunksInUse, slices))
			{
				var chunkRange = new ChunkRange(start, size);
				Append(ref ranges, ref rangeArchetypes, archetype, chunkRange, ref rangeCount);
				chunkCount += chunkRange.Size;
			}
		}
	}

	private static void Append(ref SpanList<ChunkRange> ranges, ref SpanList<Archetype> rangeArchetypes,
		Archetype archetype, ChunkRange chunkRange, ref int rangeCount)
	{
		// the pooled lists keep prior capacity/entries; overwrite in place while
		// slots exist, append past the end
		if (rangeCount >= ranges.Count)
			ranges.Add(chunkRange);
		else
			ranges[rangeCount] = chunkRange;

		if (rangeCount >= rangeArchetypes.Count)
			rangeArchetypes.Add(archetype);
		else
			rangeArchetypes[rangeCount] = archetype;

		rangeCount++;
	}
}
