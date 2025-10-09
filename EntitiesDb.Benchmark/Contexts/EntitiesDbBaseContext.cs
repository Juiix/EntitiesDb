namespace EntitiesDb.Benchmark.Contexts
{
	namespace EntitiesDb_Components
	{
		internal struct Component1
		{
			public int Value;
		}

		internal struct Component2
		{
			public int Value;
		}

		internal struct Component3
		{
			public int Value;
		}
	}

	internal class EntitiesDbBaseContext : IDisposable
	{
		public EntityDatabase Entities { get; }

		public EntitiesDbBaseContext()
		{
			Entities = new(16384, int.MaxValue);
		}

		public virtual void Dispose()
		{
			Entities.Dispose();
		}
	}
}
