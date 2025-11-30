A high-performance Entity Component Framework written in C# for data-oriented programming.

- **Simple** - Create, Read, Write, and Query components, no side-effects.
- **Cache-Locality** - Components are stored in tight arrays, enabling maximum cache-hits.
- **Archetype-Based** - Entities are stored in Archetypes and chunks for fast and efficient queries.
- **Self-Contained** - You may have multiple database instances throughout your program.

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

# Api Overview

- [Database](#Database) - Initialization and options
- [Entities](#Entities) - Create or destroy entities
- [Components](#Components) - Add, remove, read, and write single components
- [QueryBuilder](#QueryBuilder) - Filter chunks of entities to enumerate
- [ForEach](#ForEach) - Source-generated ForEach queries
- [Manual Enumeration](#Manual-Enumeration) - Custom enumeration and raw chunk access
- [Change Filter](#Change-Filter) - Custom enumeration and raw chunk access

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
db.Add(entity.Id, new Velocity(10, 10));

db.Has<Velocity>();			// true

// components must already exist on the entity
db.Set(entitiy.Id, new Velocity(200, 200));

// remove components
db.Remove<Velocity>();

// read-only access
readonly ref var position = ref db.Read<Position>(entity.Id);

// write access
ref var position = ref db.Write<Position>(entity.Id);
```

# QueryBuilder
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

# ForEach
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

# ForEachChunk
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

# Enumeration
Manually enumerate entities from a query. (SIMD, etc..)

```csharp
// enumerate archetypes & chunks
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


// enumerate read handles
int totalGold = 0;
foreach (var (length, wallets) in query.GetReadHandles<Wallet>())
{
	for (int i = 0; i < length; i++)
	{
		readonly ref var wallet = ref wallets[i];
		totalGold += wallet.Gold;
	}


// enumerate write handles
int heal = 50;
foreach (var (length, healths) in query.GetWriteHandles<Health>())
{
	for (int i = 0; i < length; i++)
	{
		ref var health = ref healths[i];
		health.Points = Math.Min(health.Max, health.Points + heal)
	}
}
```

# Change Filter
Filter query results based on chunks that have been write accessed

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

# SIMD operations
When components are designed with SIMD in mind, you may run operations on query handles

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
	}
	
	for (int i = alignedLength; i < length; i++)
	{
		deltas[i].Dx = positions[i].X - sentPositions[i].X;
		deltas[i].Dy = positions[i].Y - sentPositions[i].Y;
	}
});

```