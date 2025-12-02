![Banner](.github/banner.png)

A high-performance Entity Component Framework written in C# for data-oriented programming.

- **Fast** - Cache efficient, minimal structure, and low GC overhead.
- **Simple** - Read, write, and query components, no side-effects.
- **Self-Contained** - Contains its own internal structure, allowing multiple instances in a program.

# Quick Look

```csharp
using EntitiesDb;

// define components (any struct, class, etc)
public record struct Position(float X, float Y);
public record struct Velocity(float Dx, float Dy);
public record struct Health(int Points, int Max);

// create database
using var db = new EntityDatabase();

// create entities
var player = db.Create(
	new Position(10, 10),
	new Velocity(5, 5),
	new Health(100, 100)
);

// enumerate entities
var query = db.QueryBuilder
	.WithAll<Position, Velocity>()
	.Build();
query.ForEach((ref Position position, in Velocity velocity) =>
{
	position.X += velocity.Dx;
	position.Y += velocity.Dy;
});
```

# Table of Contents
- [Database](#database) - Initialization and options
- [Entities](#entities) - Create or destroy entities
- [Components](#components) - Add, remove, read, and write single components
	- [Buffers](#buffers)
	- [Tags](#tags)
- [Query](#query) - Filter chunks of entities to enumerate
	- [QueryBuilder](#querybuilder) - Filter chunks of entities to enumerate
	- [ForEach](#foreach) - Source-generated queries
	- [ForEachChunk](#foreachchunk) - Source-generated queries
	- [Manual Enumeration](#manual-enumeration) - Custom enumeration and raw chunk access
	- [Change Filter](#change-filter) - Enumerate only chunks that have been write accessed
	- [Multithreading](#multithreading) - Execute queries in parallel
	- [Parallel Aggregate](#parallel-aggregate) - Aggregate data from a parallel query
	- [SIMD](#simd) - Blazing fast operations

# Database

```csharp
var options = new EntityDatabaseOptions(
	chunkByteSize: 16384, 		// Byte-size of entity chunks
	maxEntities: int.MaxValue, 	// Maximum amount of entities that can be created
	parallelThreads: 16384 		// How many threads to use for parallel execution, -1 to disable parallel
);
var db = new EntityDatabase(options);
```

# Entities

```csharp
// create and pass up to 16 components
var entity = db.Create(new Position(10, 10), new Health(100, 100));

db.Exists(entity); 			// true

db.Destroy(entity.Id);		// destroy entity

db.Exists(entity); 			// false
```

# Components
Add/remove, read/write, and check components for specific entities

```csharp
// pass up to 16 components to add to an entity
// each add call is comparable to creating an entity
db.Add(entity.Id, new Velocity(10, 10));

db.Has<Velocity>(entity.Id);			// true

// components must already exist on the entity
db.Set(entitiy.Id, new Velocity(200, 200));

// remove components
db.Remove<Velocity>(entity.Id);

// read-only access
readonly ref var position = ref db.Read<Position>(entity.Id);

// write access
ref var position = ref db.Write<Position>(entity.Id);
```
## Buffers
Store an inline list as a component. Only `unmanaged` types may be used in a component buffer.

The `BufferAttribute` takes a parameter for the inline buffer size ()

```csharp
// use the Buffer attribute 
[Buffer(8)] public record struct InventoryItem(int Id, int Count);

// create entity with InventoryItem buffer
var entity = db.Create(
	new Position(100, 100),
	new Velocity(10, 10),
	[new InventoryItem(1, 1), new InventoryItem(2, 10)]		// buffer components must be the last parameters
);

// read-only access
var itemReadBuffer = db.ReadBuffer<InventoryItem>(entity.Id);
for (int i = 0; i < itemReadBuffer.Length; i++)
{
	ref readonly var item = ref itemReadBuffer[i];
}

// write access
var itemWriteBuffer = db.WriteBuffer<InventoryItem>(entity.Id);
itemWriteBuffer.Add(new InventoryItem(3, 5));

Assert.Equal(3, itemReadBuffer.Length);
```

## Tags
Types may be marked as tag components, which hold zero data and only contribute towards the component signature.

Use tags as markers or flags for entities. Tag component values cannot be read or written to.

```csharp
// use Tag attribute to mark types
[Tag] public struct PlayerTag { }
[Tag] public struct EnemyTag { }
[Tag] public struct BossTag { }

var player = db.Create(new Position(100, 100), new Health(100, 100), new PlayerTag());
var enemy =  db.Create(new Position(100, 100), new Health(100, 100), new EnemyTag());
var boss = 	 db.Create(new Position(100, 100), new Health(100, 100), new EnemyTag(), new BossTag());
```

# Query

## QueryBuilder
Create reusable queries that filter entities for enumeration

```csharp
var query = db.QueryBuilder
	.WithAll<Damage, EnemyTag>()	// must have all these components
	.WithAny<PlayerTag, NpcTag>()	// must have at least 1
	.WithNone<BossTag>()			// cannot have these
	.Build();

var query = db.QueryBuilder
	.WithOnly<Damage, Position>()	// must have exactly these components
	.Build();
```

## ForEach
Enumerate entities in a given query, reading or writing components

ForEach queries are source-generated and the lambda structure is:
```
(ENTITY?, [COMPONENT, COMPONENT2, ...], STATE?) => { }
```

Example valid lambdas:
```csharp
// no entity, just components
query.ForEach((ref Position position) => { });

// entity with components
query.ForEach((Entity entity, ref Position position, in Velocity velocity) => { });

// components with state (pass state by ref after lambda)
float deltaTime = 0.1f;
query.ForEach((ref Position position, in Velocity velocity, ref float deltaTime) => { }, ref deltaTime);

// entity, components, and state
query.ForEach((Entity entity, ref Position position, in Velocity velocity, ref float deltaTime) => { }, ref deltaTime);
```

## ForEachChunk
Enumerate chunks of entities in a given query, reading or writing components

ForEachChunk queries have a similar lambda structure, just using handles instead:
```
(LENGTH, ENTITIES?, [COMPONENTS, COMPONENTS2, ...], STATE?) => { }
```

Example valid lambdas:
```csharp
// no entities, just components
query.ForEachChunk((int length, WriteHandle<Position> positions) => { });

// entities with component handles
query.ForEachChunk((int length, ReadHandle<Entity> entities, WriteHandle<Position> positions, ReadHandle<Velocity> velocities) => { });

// component handles with state (pass state by ref after lambda)
float deltaTime = 0.1f;
query.ForEachChunk((int length, WriteHandle<Position> positions, ReadHandle<Velocity> velocities, ref float deltaTime) => { }, ref deltaTime);

// entities, component handles, and state
query.ForEachChunk((int length, ReadHandle<Entity> entities, WriteHandle<Position> positions, ReadHandle<Velocity> velocities, ref float deltaTime) => { }, ref deltaTime);
```

## Change Filter
Filter query results based on chunks that have been write accessed.

Methods marked with `[ChunkChange]` will flag the chunk as changed.

Within `ForEach` queries, `ref` 

```csharp
var query = db.QueryBuilder
	.WithAll<Position, SentPosition, PositionDelta>()
	.WithChangeFilter<Position>() // change filter on position
	.Build();

query.ForEach((in Position position, ref SentPosition sentPosition, ref PositionDelta delta) =>
{
	delta.Dx = position.X - sentPosition.X;
	delta.Dy = position.Y - sentPosition.Y;
	sentPosition.X = position.X;
	sentPosition.Y = position.Y;
});
```

## Manual Enumeration
Manually enumerate entities from a query. (SIMD, etc..)

```csharp
// enumerate read handles
int totalGold = 0;
foreach (var (length, wallets) in query.ReadHandles<Wallet>())
{
	for (int i = 0; i < length; i++)
	{
		readonly ref var wallet = ref wallets[i];
		totalGold += wallet.Gold;
	}
}

// enumerate write handles
int heal = 50;
foreach (var (length, healths) in query.WriteHandles<Health>())
{
	for (int i = 0; i < length; i++)
	{
		ref var health = ref healths[i];
		health.Points = Math.Min(health.Max, health.Points + heal)
	}
}

// enumerate read/write handles
foreach (var chunk in query.WriteHandles<Position, Velocity>())
{
	var positions = chunk.WriteHandleT0();
	var velocities = chunk.ReadHandleT1();
	for (int i = 0; i < chunk.EntityCount; i++)
	{
		ref var position = ref positions[i];
		ref readonly var velocity = ref velocities[i];
		position.X += velocity.Dx;
		position.Y += velocity.Dy;
	}
}

// enumerate raw archetypes & chunks
var posId = db.ComponentRegistry.GetId<Position>();
var velId = db.ComponentRegistry.GetId<Velocity>();
foreach (var archetype in query)
{
	var posOffset = archetype.GetOffset(posId);
	var velOffset = archetype.GetOffset(velId);
	foreach (ref readonly var chunk in archetype)
	{
		var entities = chunk.EntityHandle();
		var positions = chunk.WriteHandle<Position>(offset);
		var velocities = chunk.ReadHandle<Velocity>(offset);
		foreach (var i in chunk)
		{
			ref var position = ref positions[i];
			readonly ref var velocity = ref velocities[i];
			position.X += velocity.Dx;
			position.Y += velocity.Dy;
		}
	}
}

```

## Multithreading
The methods `ForEachParallel` and `ForEachChunkParallel` run query execution in parallel.

EntityDatabase methods marked with `[StructuralChange]` should not be called during parallel execution.

```csharp
query.ForEachParallel((in Position position, ref SentPosition sentPosition, ref PositionDelta delta) =>
{
	delta.Dx = position.X - sentPosition.X;
	delta.Dy = position.Y - sentPosition.Y;
	sentPosition.X = position.X;
	sentPosition.Y = position.Y;
});

query.ForEachChunkParallel((int length, ReadHandle<Position> positions, WriteHandle<SentPosition> sentPositions, WriteHandle<PositionDelta> deltas) =>
{
	for (int i = 0; i < length; i++)
	{
		deltas[i].Dx = positions[i].X - sentPositions[i].X;
		deltas[i].Dy = positions[i].Y - sentPositions[i].Y;
		sentPositions[i].X = positions[i].X;
		sentPositions[i].Y = positions[i].Y;
	}
});
```

## Parallel Aggregate
When using a `struct` as your state value, the struct is copied to each thread at the start of jobs, and the source state will remain unchanged.

To control state creation and results, use an `IParallelAggregate` with your state.

```csharp
public struct CountAggregate : IParallelAggregate<int>
{
	public int Sum;
	
	public int Create(int threadIndex)
	{
		return 0;
	}
	
	public void Join(int threadIndex, ref int job)
	{
		Sum += job;
	}
}

var aggregate = new CountAggregate();
query.ForEachParallel((in Wallet wallet, ref int count) =>
{
	count += wallet.Gold;
}, ref aggregate);

Console.WriteLine("Gold Sum: " + aggregate.Sum);

aggregate = new CountAggregate();
query.ForEachChunkParallel((int length, ReadHandle<Wallet> wallets, ref int count) =>
{
	for (int i = 0; i < length; i++)
	{
		count += wallets[i].Gold;
	}
}, ref aggregate);

Console.WriteLine("Chunk Gold Sum: " + aggregate.Sum);
```

## SIMD
When components are designed with SIMD in mind, you may reinterpret query handles

```csharp
query.ForEachChunk((int length, ReadHandle<Position> positions, WriteHandle<SentPosition> sentPositions, WriteHandle<PositionDelta> deltas) =>
{
	var simdPositions = positions.Reinterpret<Position, Vector256<int>>();
	var simdSentPositions = sentPositions.Reinterpret<SentPosition, Vector256<int>>();
	var simdDeltas = deltas.Reinterpret<PositionDelta, Vector256<int>>();
	
	// Each component is 2 integers
	var alignedLength = length - (length & 3);
	var simdLength = alignedLength / 4;
	
	for (int i = 0; i < simdLength; i++)
	{
		simdDeltas[i] = simdPositions[i] - simdSentPositions[i];
		simdSentPositions[i] = simdPositions[i];
	}
	
	for (int i = alignedLength; i < length; i++)
	{
		deltas[i].Dx = positions[i].X - sentPositions[i].X;
		deltas[i].Dy = positions[i].Y - sentPositions[i].Y;
		sentPositions[i].X = positions[i].X;
		sentPositions[i].Y = positions[i].Y;
	}
});

```