using EntitiesDb.Benchmark.Contexts.Structs_Components;

namespace EntitiesDb.Benchmark.Contexts
{
	namespace Structs_Components
	{
		internal record struct Component1(int Value);
		internal record struct Component2(int Value);
		internal record struct Component3(int Value);
		internal record struct Component4(int Value);

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

		internal struct EntityThree2Component
		{
			public int EntityId;
			public Component1 Component1;
			public Component2 Component2;
			public Component4 Component4;
		}

		internal struct EntityFourComponent
		{
			public int EntityId;
			public Component1 Component1;
			public Component2 Component2;
			public Component3 Component3;
			public Component4 Component4;
		}
	}

	internal class StructsBaseContext : IDisposable
	{
		public List<EntityOneComponent> OneComponentEntities { get; } = [];
		public List<EntityTwoComponent> TwoComponentEntities { get; } = [];
		public List<EntityThreeComponent> ThreeComponentEntities { get; } = [];
		public List<EntityThree2Component> Three2ComponentEntities { get; } = [];
		public List<EntityFourComponent> FourComponentEntities { get; } = [];

		public StructsBaseContext()
		{
		}

		public virtual void Dispose()
		{

		}
	}
}
