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
	public void Set_UniqueValuesPerEntity()
	{
		var db = CreateDb();
		var buffer = db.CreateCommandBuffer(128);
		int count = 20;
		var entities = new Entity[count];
		for (int i = 0; i < count; i++)
			entities[i] = db.Create();

		for (int i = 0; i < count; i++)
			buffer.Set(entities[i], new Component1(i * 10));
		buffer.Commit();

		for (int i = 0; i < count; i++)
		{
			var value = db.Write<Component1>(entities[i]).Value;
			Assert.Equal(i * 10, value);
		}
	}

	[Fact]
	public void Set_ManagedComponent_UniqueValuesPerEntity()
	{
		var db = CreateDb();
		var buffer = db.CreateCommandBuffer(128);
		int count = 20;
		var entities = new Entity[count];
		for (int i = 0; i < count; i++)
			entities[i] = db.Create();

		for (int i = 0; i < count; i++)
			buffer.Set(entities[i], new NameTag($"entity_{i}"));
		buffer.Commit();

		for (int i = 0; i < count; i++)
		{
			var text = db.Write<NameTag>(entities[i]).Text;
			Assert.Equal($"entity_{i}", text);
		}
	}

	[Fact]
	public void Create_WithComponent_UniqueValuesPerEntity()
	{
		var db = CreateDb();
		var buffer = db.CreateCommandBuffer(128);
		int count = 15;
		var bufferedEntities = new Entity[count];

		for (int i = 0; i < count; i++)
		{
			bufferedEntities[i] = buffer.Create();
			buffer.Set(bufferedEntities[i], new Component1(i * 100));
		}
		buffer.Commit();

		Assert.Equal(count, db.GetArchetype(Component<Component1>.Signature).EntityCount);
	}

	[Fact]
	public void Set_Overwrite_ExistingComponent()
	{
		var db = CreateDb();
		var buffer = db.CreateCommandBuffer(128);
		var entity = db.Create(new Component1(1));

		buffer.Set(entity, new Component1(42));
		buffer.Commit();

		Assert.Equal(42, db.Write<Component1>(entity).Value);
	}

	[Fact]
	public void Set_MultipleComponents_UniqueValuesPerEntity()
	{
		var db = CreateDb();
		var buffer = db.CreateCommandBuffer(128);
		int count = 20;
		var entities = new Entity[count];
		for (int i = 0; i < count; i++)
			entities[i] = db.Create();

		for (int i = 0; i < count; i++)
			buffer.Set(entities[i], new Component1(i), new Component2(i * 2));
		buffer.Commit();

		for (int i = 0; i < count; i++)
		{
			Assert.Equal(i, db.Write<Component1>(entities[i]).Value);
			Assert.Equal(i * 2, db.Write<Component2>(entities[i]).Value);
		}
	}

	[Fact]
	public void Destroy_RemovesEntities()
	{
		var db = CreateDb();
		var buffer = db.CreateCommandBuffer(128);
		int count = 5;
		var entities = new Entity[count];
		for (int i = 0; i < count; i++)
			entities[i] = db.Create(new Component1(i));

		var startCount = db.EntityCount;
		for (int i = 0; i < count; i++)
			buffer.Destroy(entities[i]);
		buffer.Commit();

		Assert.Equal(startCount - count, db.EntityCount);
	}

	[Fact]
	public void Clear_DiscardsBufferedCommands()
	{
		var db = CreateDb();
		var buffer = db.CreateCommandBuffer(128);
		var startCount = db.EntityCount;

		buffer.Create();
		buffer.Create();
		buffer.Clear();
		buffer.Commit();

		Assert.Equal(startCount, db.EntityCount);
	}

	[Fact]
	public void Set_MixedCreatesAndExisting_UniqueValues()
	{
		var db = CreateDb();
		var buffer = db.CreateCommandBuffer(128);
		int existingCount = 5;
		int createCount = 5;
		var existing = new Entity[existingCount];
		for (int i = 0; i < existingCount; i++)
			existing[i] = db.Create();

		// interleave creates and sets on existing entities
		var created = new Entity[createCount];
		for (int i = 0; i < createCount; i++)
		{
			created[i] = buffer.Create();
			buffer.Set(created[i], new Component1(i + 100));
			buffer.Set(existing[i], new Component1(i + 200));
		}
		buffer.Commit();

		for (int i = 0; i < existingCount; i++)
			Assert.Equal(i + 200, db.Write<Component1>(existing[i]).Value);
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
