using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDb.Parallel;

[Collection("Sequential")]
public sealed class ParallelJobRunnerTests : IDisposable
{
	private readonly int _callingThreadId = Environment.CurrentManagedThreadId;

	public void Dispose()
	{
		// No shared state to clean up here; runner instances are disposed per-test.
	}

	// Helper: create a Memory<IJob?> sized to threadCount, filling the first jobCount with jobs.
	private static Memory<IJob?> MakeJobMemory(int threadCount, params IJob[] jobs)
	{
		var arr = new IJob?[threadCount];
		for (int i = 0; i < jobs.Length; i++)
			arr[i] = jobs[i];
		return new Memory<IJob?>(arr);
	}

	private sealed class RecordingJob : IJob
	{
		private readonly Action _action;
		public int? ExecutedByThreadId { get; private set; }

		public RecordingJob(Action action) => _action = action;

		public void Execute()
		{
			ExecutedByThreadId = Thread.CurrentThread.ManagedThreadId;
			_action();
		}
	}

	[Fact]
	public void ExecuteJobs_RunsEachJobExactlyOnce_OnCorrectThreads()
	{
		const int threadCount = 4;

		var hits = new int[threadCount];
		var jobs = new RecordingJob[threadCount];

		for (int i = 0; i < threadCount; i++)
		{
			int idx = i;
			jobs[i] = new RecordingJob(() => Interlocked.Increment(ref hits[idx]));
		}

		using var runner = new ParallelJobRunner(threadCount, "TestRunner-1");

		// Build job memory with exactly threadCount jobs (one per thread, slot 0 is caller)
		var memory = MakeJobMemory(threadCount, jobs);

		runner.ExecuteJobs(memory);

		// Each job should be executed exactly once
		Assert.Equal(Enumerable.Repeat(1, threadCount), hits);

		// Slot 0 must have executed on the calling thread
		Assert.Equal(_callingThreadId, jobs[0].ExecutedByThreadId);

		// Other jobs must not have run on the calling thread
		foreach (var job in jobs.Skip(1))
			Assert.NotEqual(_callingThreadId, job.ExecutedByThreadId);
	}

	[Fact]
	public void ExecuteJobs_FewerJobsThanThreads_StillCompletes_NoExtraExecutions()
	{
		const int threadCount = 4;
		const int jobCount = 2; // fewer than threadCount

		var hits = new int[jobCount];
		var jobs = new RecordingJob[jobCount];

		for (int i = 0; i < jobCount; i++)
		{
			int idx = i;
			jobs[i] = new RecordingJob(() => Interlocked.Increment(ref hits[idx]));
		}

		using var runner = new ParallelJobRunner(threadCount, "TestRunner-2");

		// Only two jobs provided; the remaining threads will receive null jobs
		var memory = MakeJobMemory(threadCount, jobs);

		runner.ExecuteJobs(memory);

		// Only the provided jobs ran
		Assert.Equal(Enumerable.Repeat(1, jobCount), hits);
	}

	[Fact]
	public void ExecuteJobs_AggregatesExceptions_FromAnyThread()
	{
		const int threadCount = 3;

		var okHit = 0;
		var ex1 = new InvalidOperationException("boom-1");
		var ex2 = new ApplicationException("boom-2");

		var jobs = new IJob[]
		{
			new RecordingJob(() => { throw ex1; }),        // will run on caller
            new RecordingJob(() => { throw ex2; }),        // worker
            new RecordingJob(() => Interlocked.Increment(ref okHit)) // worker
        };

		using var runner = new ParallelJobRunner(threadCount, "TestRunner-3");
		var memory = MakeJobMemory(threadCount, jobs);

		var agg = Assert.Throws<AggregateException>(() => runner.ExecuteJobs(memory));

		// Both exceptions are present (order not guaranteed)
		Assert.Equal(2, agg.InnerExceptions.Count);
		Assert.Contains(agg.InnerExceptions, e => e.Message == "boom-1" && e.GetType() == typeof(InvalidOperationException));
		Assert.Contains(agg.InnerExceptions, e => e.Message == "boom-2" && e.GetType() == typeof(ApplicationException));

		// The non-throwing job still ran
		Assert.Equal(1, okHit);
	}

	[Fact]
	public void ExecuteJobs_CanRunMultipleTimes_BackToBack()
	{
		const int threadCount = 3;

		var run1Hits = new int[threadCount];
		var run2Hits = new int[threadCount];

		var jobsRun1 = new IJob[]
		{
			new RecordingJob(() => Interlocked.Increment(ref run1Hits[0])),
			new RecordingJob(() => Interlocked.Increment(ref run1Hits[1])),
			new RecordingJob(() => Interlocked.Increment(ref run1Hits[2])),
		};

		var jobsRun2 = new IJob[]
		{
			new RecordingJob(() => Interlocked.Increment(ref run2Hits[0])),
			new RecordingJob(() => Interlocked.Increment(ref run2Hits[1])),
			new RecordingJob(() => Interlocked.Increment(ref run2Hits[2])),
		};

		using var runner = new ParallelJobRunner(threadCount, "TestRunner-4");

		runner.ExecuteJobs(MakeJobMemory(threadCount, jobsRun1));
		runner.ExecuteJobs(MakeJobMemory(threadCount, jobsRun2));

		Assert.Equal(new[] { 1, 1, 1 }, run1Hits);
		Assert.Equal(new[] { 1, 1, 1 }, run2Hits);
	}

	[Fact]
	public void ExecuteJobs_DoesNothing_WhenEmpty()
	{
		using var runner = new ParallelJobRunner(threadCount: 2, threadName: "TestRunner-5");

		// No jobs => returns immediately without throwing
		runner.ExecuteJobs(Memory<IJob?>.Empty);
	}
}