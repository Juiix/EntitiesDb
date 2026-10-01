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

		var threadCount = options.MaxThreads > 0
			? Math.Min(options.MaxThreads, _parallelRunner.ThreadCount)
			: _parallelRunner.ThreadCount;

		// collect chunk ranges across ALL matching archetypes so the whole query
		// costs a single fork/join, instead of one barrier per archetype
		var work = JobMeta.WorkPool.Rent();
		work.Reset();
		foreach (var archetype in EnumerateArchetypes())
			AppendRanges(work, archetype, changeFilter, compareVersion);

		if (work.TotalChunks == 0)
		{
			JobMeta.WorkPool.Return(work);
			return;
		}

		// one job per thread; jobs claim chunks dynamically from the shared work list, so a
		// preempted thread only delays its current batch rather than the whole join
		var jobCount = Math.Min(threadCount, work.TotalChunks);
		work.Finish(jobCount);

		var jobPool = JobMeta<T>.JobPool;
		var jobs = ArrayPool<IJob?>.Shared.Rent(jobCount);
		for (int i = 0; i < jobCount; i++)
		{
			var job = jobPool.Rent();
			job.Work = work;
			job.ForEach = aggregate.Create(i);
			jobs[i] = job;
		}

		try
		{
			_parallelRunner.ExecuteJobs(jobs.AsMemory(0, jobCount));
		}
		finally
		{
			for (var i = 0; i < jobCount; i++)
			{
				var job = (ChunkJob<T>)jobs[i]!;
				aggregate.Join(i, ref job.ForEach);
				job.Work = null!;
				job.ForEach = default!;
				jobPool.Return(job);
				jobs[i] = null;
			}
			ArrayPool<IJob?>.Shared.Return(jobs);
			JobMeta.WorkPool.Return(work);
		}
	}

	public void ChunkJobParallel<T>(in T chunkJob, ParallelOptions options = default)
		where T : IChunkJob
	{
		var aggregate = new DefaultAggregate<T>(chunkJob);
		ChunkJobParallel<T, DefaultAggregate<T>>(ref aggregate, options);
	}

	private static void AppendRanges(ChunkJobWork work, Archetype archetype, ChangeFilter? changeFilter, int? compareVersion)
	{
		if (changeFilter != null)
		{
			var filteredRanges = new ChangeFilterIterator(archetype.ChunkSpan, changeFilter, compareVersion!.Value);
			foreach (var chunkRange in filteredRanges)
				work.Append(archetype, in chunkRange);
		}
		else
		{
			work.Append(archetype, new ChunkRange(0, archetype.ChunksInUse));
		}
	}
}
