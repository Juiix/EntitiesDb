using EntitiesDb.Benchmark.Contexts.Structs_Components;

namespace EntitiesDb.Benchmark.Contexts
{
	namespace Structs_Components
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

		internal struct EntityOneComponent
		{
			public int EntityId;
			public Component1 Component1;
		}

		internal struct EntityTwoComponent
		{
			public int EntityId;
			public Component1 Component1;
			public Component2 Component2;
		}

		internal struct EntityThreeComponent
		{
			public int EntityId;
			public Component1 Component1;
			public Component2 Component2;
			public Component3 Component3;
		}
	}

	internal class StructsBaseContext : IDisposable
	{
		public List<EntityOneComponent> OneComponentEntities { get; } = [];
		public List<EntityTwoComponent> TwoComponentEntities { get; } = [];
		public List<EntityThreeComponent> ThreeComponentEntities { get; } = [];

		public StructsBaseContext()
		{
		}

		public virtual void Dispose()
		{

		}
	}
}
