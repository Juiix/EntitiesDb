using EntitiesDb.Benchmark.Contexts.Classes_Components;

namespace EntitiesDb.Benchmark.Contexts
{
	namespace Classes_Components
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

		internal class EntityOneComponent
		{
			public int EntityId;
			public Component1 Component1;
		}

		internal class EntityTwoComponent
		{
			public int EntityId;
			public Component1 Component1;
			public Component2 Component2;
		}

		internal class EntityThreeComponent
		{
			public int EntityId;
			public Component1 Component1;
			public Component2 Component2;
			public Component3 Component3;
		}
	}

	internal class ClassesBaseContext : IDisposable
	{
		public List<EntityOneComponent> OneComponentEntities { get; } = [];
		public List<EntityTwoComponent> TwoComponentEntities { get; } = [];
		public List<EntityThreeComponent> ThreeComponentEntities { get; } = [];

		public ClassesBaseContext()
		{
		}

		public virtual void Dispose()
		{

		}
	}
}
