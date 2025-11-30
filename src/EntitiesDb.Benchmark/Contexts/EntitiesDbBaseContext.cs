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
		public EntityDatabase Entities { get; }

		public EntitiesDbBaseContext() : this(-1) { }
		public EntitiesDbBaseContext(int threadCount)
		{
			Entities = new(new(16384 * 2, int.MaxValue, threadCount));
		}

		public virtual void Dispose()
		{
			Entities.Dispose();
		}
	}
}
