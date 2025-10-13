using Schedulers;
using System;
using System.Threading;

namespace EntitiesDb;

internal sealed class ParallelJobRunner : IDisposable
{
	private readonly Thread[] _threads;
	private readonly Exception[] _exceptions;
	private readonly ManualResetEventSlim _workersStart;
	private readonly CountdownEvent _countdown;
	private Memory<IJob?> _jobs = Memory<IJob?>.Empty;
	private int _exceptionCount = 0;
	private bool _running = true;
	private int _run;

	public ParallelJobRunner(int threadCount, string? threadName = null)
	{
		// -1 background thread because we will reuse the calling thread
		//_workersStart = CreateStartEvents(threadCount - 1);
		_workersStart = new ManualResetEventSlim(false, 2047);
		_threads = CreateThreads(threadCount - 1, threadName ?? nameof(ParallelJobRunner));
		_exceptions = new Exception[threadCount];
		_countdown = new CountdownEvent(threadCount);
		ThreadCount = threadCount;
	}

	public int ThreadCount { get; }

	public void ExecuteJobs(Memory<IJob?> jobs)
	{
		if (jobs.Length == 0) return;

		_jobs = jobs;
		Interlocked.Increment(ref _run);
		Volatile.Write(ref _exceptionCount, 0);

		_workersStart.Set();

		RunJob(jobs.Span[0]);

		_countdown.Wait();
		_countdown.Reset();
		_jobs = Memory<IJob?>.Empty;

		var exceptionCount = Volatile.Read(ref _exceptionCount);
		if (exceptionCount > 0)
		{
			_exceptionCount = 0;
			throw new AggregateException(_exceptions.AsSpan(0, exceptionCount).ToArray());
		}
	}

	public void Dispose()
	{
		_running = false;
		_workersStart.Set();
		//for (int i = 0; i < _workersStart.Length; i++)
		//	_workersStart[i].Set();
		for (int i = 0; i < _threads.Length; i++)
			_threads[i].Join();
	}

	private void RunWorker(object? i)
	{
		int lastRun = -1;
		int threadIndex = (int)i!;
		//var start = _workersStart[threadIndex - 1];
		while (Volatile.Read(ref _running))
		{
			_workersStart.Wait();
			if (!Volatile.Read(ref _running)) break;

			var run = Volatile.Read(ref _run);
			if (run == lastRun) continue;
			lastRun = run;

			var jobs = _jobs.Span;
			RunJob(threadIndex < jobs.Length
				? jobs[threadIndex]
				: null);
		}
	}

	private void ExceptionThrown(Exception e)
	{
		var index = Interlocked.Increment(ref _exceptionCount) - 1;
		_exceptions[index] = e;
	}

	private void RunJob(IJob? job)
	{
		try
		{
			job?.Execute();
		}
		catch (Exception e)
		{
			ExceptionThrown(e);
		}
		finally
		{
			_countdown.Signal();
		}
	}

	private Thread[] CreateThreads(int count, string baseName)
	{
		var threads = new Thread[count];
		for (int i = 0; i < count; i++)
		{
			var thread = new Thread(RunWorker)
			{
				Name = $"{baseName}+{i + 1}",
				IsBackground = true
			};
			thread.Start(i + 1);
			threads[i] = thread;
		}
		return threads;
	}

	private static AutoResetEvent[] CreateStartEvents(int v)
	{
		var events = new AutoResetEvent[v];
		for (int i = 0; i < v; i++)
		{
			events[i] = new AutoResetEvent(false);
		}
		return events;
	}
}
