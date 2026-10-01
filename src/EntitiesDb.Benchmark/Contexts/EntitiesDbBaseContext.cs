namespace EntitiesDb.Benchmark.Contexts
{
	namespace EntitiesDb_Components
	{
		internal record struct Component1(int Value);
		internal record struct Component2(int Value);
		internal record struct Component3(int Value);
		internal record struct Component4(int Value);
	}

	internal class EntitiesDbBaseContext : IDisposable
	{
		/// <summary>
		/// Thread count used by parallel benchmarks: physical cores (ProcessorCount / 2 on SMT machines).
		/// Using every logical processor oversubscribes the box and makes parallel rows slower and noisy
		/// (see the ParallelScaling scenario).
		/// </summary>
		public static int ParallelThreads => Math.Max(1, Environment.ProcessorCount / 2);

		public EntityDatabase Entities { get; }

		/// <summary>
		/// Creates a database with library-default options (16 KB chunks, parallel disabled).
		/// </summary>
		public EntitiesDbBaseContext() : this(-1) { }

		/// <summary>
		/// Creates a database with library-default chunk size and the given parallel thread count (-1 disables parallel).
		/// </summary>
		public EntitiesDbBaseContext(int threadCount)
		{
			Entities = new(new EntityDatabaseOptions(parallelThreads: threadCount));
		}

		public virtual void Dispose()
		{
			Entities.Dispose();
		}
	}
}
