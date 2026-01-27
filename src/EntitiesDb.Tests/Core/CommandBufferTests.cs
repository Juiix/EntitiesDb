using static EntitiesDb.FakeDb;

namespace EntitiesDb.Core;

public sealed class CommandBufferTests
{
	private record struct Order(int Index);
	private record struct Component1(int Value);
	private record struct Component2(int Value);
	[Tag] private record struct TestTag();

	[Fact]
	public void Create_EmptyEntities()
	{
		var db = CreateDb();
		var buffer = db.CreateCommandBuffer(128);
		int entitiesToCreate = 10;
		int startCount = db.EntityCount;
		var emptyArchetype = db.GetArchetype(Signature.Empty);
		var emptyStartCount = emptyArchetype.EntityCount;

		for (int i = 0; i < entitiesToCreate; i++)
			buffer.Create();
		buffer.Commit();

		Assert.Equal(startCount + entitiesToCreate, db.EntityCount);
		Assert.Equal(emptyStartCount + entitiesToCreate, emptyArchetype.EntityCount);
	}

	[Fact]
	public void Add_Remove_2Components()
	{
		var db = CreateDb();
		var buffer = db.CreateCommandBuffer(128);
		int entitiesToCreate = 100;
		var entities = new Entity[entitiesToCreate];
		int startCount = db.EntityCount;
		var emptyArchetype = db.GetArchetype(Signature.Empty);
		var emptyStartCount = emptyArchetype.EntityCount;
		for (int i = 0; i < entitiesToCreate; i++)
			entities[i] = db.Create();

		for (int i = 0; i < entitiesToCreate; i++)
		{
			var entity = entities[i];
			buffer.Add(entity, new Component1(), new Component2());
		}
		buffer.Commit();

		for (int i = 0; i < entitiesToCreate; i++)
		{
			var entity = entities[i];
			buffer.Remove<Component1, Component2>(entity);
		}
		buffer.Commit();

		Assert.Equal(startCount + entitiesToCreate, db.EntityCount);
		Assert.Equal(emptyStartCount + entitiesToCreate, emptyArchetype.EntityCount);
	}

	[Fact]
	public void Create_Add_4Components()
	{
		var db = CreateDb();
		var buffer = db.CreateCommandBuffer(128);
		int entitiesToCreate = 10;
		int startCount = db.EntityCount;

		for (int i = 0; i < entitiesToCreate; i++)
		{
			var entity = buffer.Create();
			InventoryItem[] items = [ new(1, 1), new(2, 1), new(3, 1), new(4, 1) ];
			buffer.Add(entity, new Order(i), new FakeDb.Position(i, i + 1), new FakeDb.Velocity(i + 2, i + 3), new TestTag(), (ReadOnlySpan<InventoryItem>)items.AsSpan(0, (i % 4) + 1));
		}
		buffer.Commit();

		var signature = Component<Order, FakeDb.Position, FakeDb.Velocity, TestTag, InventoryItem>.Signature;
		var archetype = db.GetArchetype(signature);
		Assert.Equal(startCount + entitiesToCreate, db.EntityCount);
		Assert.Equal(entitiesToCreate, archetype.EntityCount);

		var query = db.QueryBuilder
			.WithOnly<Order, FakeDb.Position, FakeDb.Velocity, TestTag, InventoryItem>()
			.Build();

		int count = 0;
		bool[] found = new bool[entitiesToCreate];
		foreach (var (length, orders, positions, velocities, itemBuffers) in query.ReadHandlesM3<Order, FakeDb.Position, FakeDb.Velocity, InventoryItem>())
		{
			for (int i = 0; i < length; i++)
			{
				ref readonly var order = ref orders[i];
				ref readonly var position = ref positions[i];
				ref readonly var velocity = ref velocities[i];
				var itemBuffer = itemBuffers[i];
				var index = order.Index;
				Assert.Equal(index, position.X);
				Assert.Equal(index + 1, position.Y);
				Assert.Equal(index + 2, velocity.dX);
				Assert.Equal(index + 3, velocity.dY);
				Assert.False(found[index]);
				found[index] = true;
				count++;

				var itemLength = (index % 4) + 1;
				Assert.Equal(itemLength, itemBuffer.Length);
				for (int j = 0; j < itemBuffer.Length; j++)
				{
					var item = itemBuffer[j];
					Assert.Equal(j + 1, item.ItemId);
					Assert.Equal(1, item.Count);
				}
			}
		}

		Assert.Equal(entitiesToCreate, count);
	}

	[Fact]
	public void Remove_2Components()
	{
		var db = CreateDb();
		var buffer = db.CreateCommandBuffer(128);
		int entitiesToCreate = 10;
		int startCount = db.EntityCount;

		var entities = new List<Entity>();
		for (int i = 0; i < entitiesToCreate; i++)
		{
			InventoryItem[] items = [new(1, 1), new(2, 1), new(3, 1), new(4, 1)];
			var itemSpan = (ReadOnlySpan<InventoryItem>)items.AsSpan(0, (i % 4) + 1);
			var entity = db.Create(new Order(i), new FakeDb.Position(i, i + 1), new FakeDb.Velocity(i + 2, i + 3), new TestTag(), itemSpan);
			entities.Add(entity);
		}

		for (int i = 0; i < entitiesToCreate; i++)
		{
			buffer.Remove<Velocity, InventoryItem>(entities[i]);
		}
		buffer.Commit();

		var signature = Component<Order, FakeDb.Position, TestTag>.Signature;
		var archetype = db.GetArchetype(signature);
		Assert.Equal(startCount + entitiesToCreate, db.EntityCount);
		Assert.Equal(entitiesToCreate, archetype.EntityCount);

		var query = db.QueryBuilder
			.WithOnly<Order, FakeDb.Position, TestTag>()
			.Build();

		int count = 0;
		bool[] found = new bool[entitiesToCreate];
		foreach (var (length, orders, positions) in query.ReadHandles<Order, FakeDb.Position>())
		{
			for (int i = 0; i < length; i++)
			{
				ref readonly var order = ref orders[i];
				ref readonly var position = ref positions[i];
				var index = order.Index;
				Assert.Equal(index, position.X);
				Assert.Equal(index + 1, position.Y);
				Assert.False(found[index]);
				found[index] = true;
				count++;
			}
		}

		Assert.Equal(entitiesToCreate, count);
	}
}
