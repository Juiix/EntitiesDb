using System;

namespace EntitiesDb;

public partial class Query
{
	private readonly struct DefaultAggregate<TJob>(TJob baseJob) : IParallelAggregate<TJob> where TJob : IChunkJob
	{
		public readonly TJob BaseJob = baseJob;
		public readonly TJob Create(int threadIndex) => BaseJob;
		public readonly void Join(int threadIndex, ref TJob job) { }
	}

	public TAggregate ChunkJobParallel<T, TAggregate>(TAggregate aggregate, ParallelOptions options = default)
		where T : IChunkJob
		where TAggregate : IParallelAggregate<T>
	{
		if (_parallelRunner is null)
		{
			// if no parallel threads are enabled, call inline
			var job = aggregate.Create(0);
			ChunkJob(ref job);
			aggregate.Join(0, ref job);
			return aggregate;
		}

		var changeFilter = ChangeFilter;
		var compareVersion = changeFilter?.Version;

		var jobPool = JobMeta<T>.JobPool;
		var jobsPool = JobMeta<T>.ArrayPool;
		var rangesPool = JobMeta.RangesPool;
		var jobs = jobsPool.Rent();
		var ranges = rangesPool.Rent();
		var threadCount = options.MaxThreads > 0
			? Math.Min(options.MaxThreads, _parallelRunner.ThreadCount)
			: _parallelRunner.ThreadCount;
		int jobMax = 0;
		foreach (var archetype in EnumerateArchetypes())
		{
			AssignRanges(archetype, changeFilter, compareVersion, ref ranges, threadCount, out var rangeCount, out var chunkCount);
			if (rangeCount == 0)
				continue;

			var chunkRanges = new ChunkRangePartitioner(ranges.AsSpan(), chunkCount, threadCount);
			int jobI = 0;
			foreach (var (start, end, first, last) in chunkRanges)
			{
				ChunkJob<T> job;
				if (jobI < jobMax) job = (ChunkJob<T>)jobs[jobI]!;
				else
				{
					jobs[jobI] = job = jobPool.Rent();
					jobMax++;
				}

				job.Start = start;
				job.End = end;
				job.First = first;
				job.Last = last;
				job.Archetype = archetype;
				job.Ranges = ranges;
				job.ForEach = aggregate.Create(jobI++);
			}

			_parallelRunner.ExecuteJobs(jobs.AsMemory(0, jobI));

			for (var i = 0; i < jobI; i++)
			{
				var job = jobs[i] as ChunkJob<T>;
				aggregate.Join(i, ref job!.ForEach);
			}
		}

		for (var i = 0; i < jobMax; i++)
		{
			var job = jobs[i] as ChunkJob<T>;
			jobPool.Return(job);
			jobs[i] = null;
		}
		jobsPool.Return(jobs);
		rangesPool.Return(ranges);
		return aggregate;
	}

	public void ChunkJobParallel<T>(in T chunkJob, ParallelOptions options = default)
		where T : IChunkJob
	{
		ChunkJobParallel<T, DefaultAggregate<T>>(new DefaultAggregate<T>(chunkJob), options);
	}

	private static void AssignRanges(Archetype archetype, ChangeFilter? changeFilter, int? compareVersion, ref SpanList<ChunkRange> ranges, int slices, out int rangeCount, out int chunkCount)
	{
		rangeCount = 0;
		chunkCount = 0;
		if (changeFilter != null)
		{
			var filteredRanges = new ChangeFilterIterator(archetype.ChunkSpan, changeFilter, compareVersion!.Value);
			foreach (var chunkRange in filteredRanges)
			{
				if (rangeCount >= ranges.Count)
					ranges.Add(chunkRange);
				else
					ranges[rangeCount] = chunkRange;
				rangeCount++;
				chunkCount += chunkRange.Size;
			}
		}
		else
		{
			foreach (var (start, size) in new RangePartitioner(archetype.ChunksInUse, slices))
			{
				var chunkRange = new ChunkRange(start, size);
				if (rangeCount >= ranges.Count)
					ranges.Add(chunkRange);
				else
					ranges[rangeCount] = chunkRange;
				rangeCount++;
				chunkCount += chunkRange.Size;
			}
		}
	}
}
