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
	.WithAll<Position>()
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
- [Enumeration](#Enumeration) - Custom enumeration and raw chunk access

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
var entity = db.Create(	// create and pass up to 16 components
	new Position(10, 10),
	new Health(100, 100)
);

db.Exists(entity); 		// true

db.Destroy(entity.Id);	// destroy entity

db.Exists(entity); 		// false
```

# Components
Add/remove, read/write, and check components for specific entities

```csharp
db.Add(entity.Id,			// pass up to 16 components to add to an entity
	new Velocity(10, 10)
);

db.Has<Velocity>();		// true

db.Set(entitiy.Id,		// components must already exist on the entity
	new Position(200, 200)
);

db.Remove<Velocity>();	// remove components by type

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
Enumerate entities in a given query, reading or writing to components

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