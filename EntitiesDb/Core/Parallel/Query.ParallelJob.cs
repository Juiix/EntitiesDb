using System;

namespace EntitiesDb;

public partial class Query
{
	public void InlineChunkJobParallel<T, TCoordinator>(ref TCoordinator coordinator, ParallelOptions options = default)
		where T : IChunkJob
		where TCoordinator : IJobCoordinator<T>
	{
		if (_parallelRunner is null)
		{
			// if no parallel threads are enabled, call inline
			var job = coordinator.Create(0);
			InlineChunkJob(ref job);
			coordinator.Return(0, ref job);
			return;
		}

		var jobPool = JobMeta<T>.JobPool;
		var jobsPool = JobMeta<T>.ArrayPool;
		var jobs = jobsPool.Rent();
		var threadCount = options.MaxThreads > 0 ? options.MaxThreads : _parallelRunner.ThreadCount;
		foreach (var archetype in GetArchetypeIterator())
		{
			var chunkCount = archetype.ChunksInUse;
			var ranges = new RangePartitioner(chunkCount, threadCount);
			int jobCount = 0;
			foreach (var (start, size) in ranges)
			{
				var job = jobPool.Rent();
				job.Start = start;
				job.Size = size;
				job.Archetype = archetype;
				job.ForEach = coordinator.Create(jobCount);

				jobs[jobCount++] = job;
			}

			_parallelRunner.ExecuteJobs(jobs.AsMemory(0, jobCount));

			for (var i = 0; i < jobCount; i++)
			{
				var job = jobs[i] as ChunkJob<T>;
				coordinator.Return(i, ref job!.ForEach);
				jobPool.Return(job);
				jobs[i] = null;
			}
			jobsPool.Return(jobs);
		}
	}

	public void InlineChunkJobParallel<T>(in T chunkJob, ParallelOptions options = default)
		where T : IChunkJob
	{
		if (_parallelRunner is null)
		{
			// if no parallel threads are enabled, call inline
			var job = chunkJob;
			InlineChunkJob(ref job);
			return;
		}

		var jobPool = JobMeta<T>.JobPool;
		var jobsPool = JobMeta<T>.ArrayPool;
		var jobs = jobsPool.Rent();
		var threadCount = options.MaxThreads > 0 ? options.MaxThreads : _parallelRunner.ThreadCount;
		foreach (var archetype in GetArchetypeIterator())
		{
			var chunkCount = archetype.ChunksInUse;
			var ranges = new RangePartitioner(chunkCount, threadCount);
			int jobCount = 0;
			foreach (var (start, size) in ranges)
			{
				var job = jobPool.Rent();
				job.Start = start;
				job.Size = size;
				job.Archetype = archetype;
				job.ForEach = chunkJob;

				jobs[jobCount++] = job;
			}

			_parallelRunner.ExecuteJobs(jobs.AsMemory(0, jobCount));

			for (var i = 0; i < jobCount; i++)
			{
				jobPool.Return(jobs[i] as ChunkJob<T>);
				jobs[i] = null;
			}
			jobsPool.Return(jobs);
		}
	}
}
