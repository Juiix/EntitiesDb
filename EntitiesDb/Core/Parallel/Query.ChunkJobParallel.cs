using System;

namespace EntitiesDb;

public partial class Query
{
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
				job.ForEach = aggregate.Create(jobCount);

				jobs[jobCount++] = job;
			}

			_parallelRunner.ExecuteJobs(jobs.AsMemory(0, jobCount));

			for (var i = 0; i < jobCount; i++)
			{
				var job = jobs[i] as ChunkJob<T>;
				aggregate.Join(i, ref job!.ForEach);
				jobPool.Return(job);
				jobs[i] = null;
			}
			jobsPool.Return(jobs);
		}
		return aggregate;
	}

	public void ChunkJobParallel<T>(in T chunkJob, ParallelOptions options = default)
		where T : IChunkJob
	{
		if (_parallelRunner is null)
		{
			// if no parallel threads are enabled, call inline
			var job = chunkJob;
			ChunkJob(ref job);
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
