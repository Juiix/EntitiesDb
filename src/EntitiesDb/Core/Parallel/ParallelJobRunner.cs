using System;
using System.Threading;

namespace EntitiesDb;

/// <summary>
/// Runs a call's jobs on the calling thread plus up to <see cref="ThreadCount"/> - 1 worker threads.
/// </summary>
/// <remarks>
/// <para>A call with <c>n</c> jobs signals only <c>n - 1</c> workers: job 0 always runs on the caller, and
/// a one-job call never touches the workers at all.</para>
/// <para>Once the caller's own job is done it runs any job whose worker hasn't picked it up yet, so the
/// join only ever waits on jobs that are actually running — never on a thread the scheduler hasn't got
/// round to. A job may therefore run on the calling thread or on any worker.</para>
/// <para>Idle workers block (after <see cref="SemaphoreSlim"/>'s brief spin) rather than spin, so more
/// threads than cores costs a wake-up, not a scheduler fight on every call. Steady-state calls
/// allocate nothing.</para>
/// </remarks>
public sealed class ParallelJobRunner : IParallelJobRunner, IDisposable
{
	private const int Pending = 1;
	private const int Taken = 0;

	private readonly Worker[] _workers;
	private readonly Exception?[] _exceptions;
	private readonly SemaphoreSlim _joined = new(0);
	private int _exceptionCount;
	private int _outstanding;
	private volatile bool _disposed;

	public ParallelJobRunner(int threadCount, string? threadName = null)
	{
		if (threadCount < 1)
			throw new ArgumentOutOfRangeException(nameof(threadCount), threadCount, "At least the calling thread is needed");

		ThreadCount = threadCount;
		_exceptions = new Exception?[threadCount];
		// -1: the calling thread runs a job too
		_workers = new Worker[threadCount - 1];
		for (int i = 0; i < _workers.Length; i++)
			_workers[i] = new Worker(this, $"{threadName ?? nameof(ParallelJobRunner)}+{i + 1}");
	}

	public int ThreadCount { get; }

	/// <summary>Workers signalled over the runner's lifetime (one per job beyond the first).</summary>
	internal long WorkersSignalled { get; private set; }

	public void ExecuteJobs(Memory<IJob?> jobs)
	{
		var count = jobs.Length;
		if (count == 0) return;
		if (count > ThreadCount)
			throw new InvalidOperationException("Cannot run more jobs than threads available. Keep job count below ThreadCount");
		if (_disposed)
			throw new ObjectDisposedException(nameof(ParallelJobRunner));

		var span = jobs.Span;
		_exceptionCount = 0;
		// one per worker job plus the caller's own: whoever takes it to zero knows everyone else is done.
		// Published to the workers by the Release below (a full fence).
		_outstanding = count;

		for (int i = 1; i < count; i++)
		{
			var worker = _workers[i - 1];
			worker.Job = span[i];
			Volatile.Write(ref worker.State, Pending);
			worker.Signal.Release();
		}
		WorkersSignalled += count - 1;

		Run(span[0]);

		// run whatever a worker hasn't picked up yet instead of waiting for it to be scheduled
		for (int i = 1; i < count; i++)
		{
			var worker = _workers[i - 1];
			if (Interlocked.CompareExchange(ref worker.State, Taken, Pending) != Pending)
				continue;

			var job = worker.Job;
			worker.Job = null;
			Run(job);
			Interlocked.Decrement(ref _outstanding); // never the last: the caller's own share is still out
		}

		if (Interlocked.Decrement(ref _outstanding) != 0)
			_joined.Wait();

		var exceptionCount = Volatile.Read(ref _exceptionCount);
		if (exceptionCount > 0)
		{
			var errors = new Exception[exceptionCount];
			Array.Copy(_exceptions, errors, exceptionCount);
			Array.Clear(_exceptions, 0, exceptionCount);
			throw new AggregateException(errors);
		}
	}

	public void Dispose()
	{
		if (_disposed) return;
		_disposed = true;

		foreach (var worker in _workers)
			worker.Signal.Release();
		foreach (var worker in _workers)
			worker.Thread.Join();
		foreach (var worker in _workers)
			worker.Signal.Dispose();
		_joined.Dispose();
	}

	private void Run(IJob? job)
	{
		if (job is null) return;

		try
		{
			job.Execute();
		}
		catch (Exception e)
		{
			_exceptions[Interlocked.Increment(ref _exceptionCount) - 1] = e;
		}
	}

	private void WorkerLoop(Worker worker)
	{
		while (true)
		{
			worker.Signal.Wait();
			if (_disposed) return;

			// a signal whose job the caller already ran (or a stale one from such a call): nothing to do
			if (Interlocked.CompareExchange(ref worker.State, Taken, Pending) != Pending)
				continue;

			var job = worker.Job;
			worker.Job = null;
			Run(job);
			if (Interlocked.Decrement(ref _outstanding) == 0)
				_joined.Release();
		}
	}

	private sealed class Worker
	{
		public readonly SemaphoreSlim Signal = new(0);
		public readonly Thread Thread;
		public IJob? Job;
		public int State = Taken;

		public Worker(ParallelJobRunner runner, string name)
		{
			Thread = new Thread(() => runner.WorkerLoop(this)) { Name = name, IsBackground = true };
			Thread.Start();
		}
	}
}
