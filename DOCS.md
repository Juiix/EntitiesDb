# Table of Contents

* [Core Concepts](#core-concepts)
* [EntityDatabase](#entitydatabase)
* [Entities](#entities)
* [Components](#components)
  * [Buffers](#buffers)
  * [Tags](#tags)
* [Queries](#queries)
  * [QueryBuilder](#querybuilder)
  * [ForEach](#foreach)
  * [ForEachChunk](#foreachchunk)
  * [Change Filter](#change-filter)
  * [Manual Enumeration](#manual-enumeration)
  * [Multithreading](#multithreading)
  * [Parallel Aggregate](#parallel-aggregate)
  * [SIMD](#simd)
* [License](#license)

---

# Core Concepts

EntitiesDb is built around a classic data-oriented ECS design:

### **Entities**

Lightweight integer IDs. They have no data themselves — components define the data.

### **Components**

Plain C# types (`struct`, `class`, `record`, etc). Stored densely in chunked arrays.

### **Archetypes**

Unique sets of components. Entities with the same component signature are grouped into the same chunk layout.

### **Queries**

Pull in chunks of entities matching component filters — the basis for all system updates.

### **Source-Generated Iterators**

`ForEach` methods generate strongly-typed, allocation-free iteration code.

---

# EntityDatabase

Configure memory/storage behavior through `EntityDatabaseOptions`.

```csharp
var options = new EntityDatabaseOptions(
    chunkByteSize: 16384,     // Size of storage chunks
    maxEntities: int.MaxValue,
    parallelThreads: 16384    // -1 disables parallel execution
);

var db = new EntityDatabase(options);
```

Each database is completely isolated, allowing multiple worlds.

---

# Entities

```csharp
var entity = db.Create(new Position(10, 10), new Health(100, 100));

db.Exists(entity);      // true
db.Destroy(entity.Id);  // destroy
db.Exists(entity);      // false
```

* Pass **up to 16 components** when creating or adding (fast path)
* Structural changes (Create/Add/Remove/Destroy) are **not thread-safe** inside parallel execution

---

# Components

Components are simple data types:

```csharp
public record struct Position(float X, float Y);
public record struct Velocity(float Dx, float Dy);
```

### Add / Read / Write / Remove

```csharp
db.Add(entity.Id, new Velocity(10, 10));

db.Has<Velocity>(entity.Id);                // true

db.Set(entity.Id, new Velocity(200, 200));  // overwrite component

db.Remove<Velocity>(entity.Id);

// Read-only
readonly ref var position = ref db.Read<Position>(entity.Id);

// Write
ref var pos = ref db.Write<Position>(entity.Id);
pos.X += 5;
```

---

## Buffers

Buffers act like **inline component lists**, stored directly in the chunk.
Only `unmanaged` types can be buffered.

```csharp
[Buffer(8)]
public record struct InventoryItem(int Id, int Count);
```

### Creating with a buffer:

```csharp
var entity = db.Create(
    new Position(100, 100),
    new Velocity(10, 10),
    new[] {
        new InventoryItem(1, 1),
        new InventoryItem(2, 10)
    } // Buffer must be the last argument
);
```

### Accessing a buffer:

```csharp
// Read
var read = db.ReadBuffer<InventoryItem>(entity.Id);
for (int i = 0; i < read.Length; i++)
{
    ref readonly var item = ref read[i];
}

// Write
var write = db.WriteBuffer<InventoryItem>(entity.Id);
write.Add(new InventoryItem(3, 5));
```

---

## Tags

Tags are **zero-data components** used for classification:

```csharp
[Tag] public struct PlayerTag { }
[Tag] public struct EnemyTag { }
[Tag] public struct BossTag  { }

var player = db.Create(new Position(100, 100), new PlayerTag());
var enemy  = db.Create(new Position(50, 50), new EnemyTag());
var boss   = db.Create(new Position(10, 10), new EnemyTag(), new BossTag());
```

---

# Queries

Queries filter entities by component signature.

## QueryBuilder

```csharp
var query = db.QueryBuilder
    .WithAll<Damage, EnemyTag>()  // must include
    .WithAny<PlayerTag, NpcTag>() // at least one
    .WithNone<BossTag>()          // must not include
    .Build();

var exact = db.QueryBuilder
    .WithOnly<Damage, Position>() // has exactly these components
    .Build();
```

---

## ForEach

Source-generated iteration over entities.

The lambda pattern is:

```
(ENTITY?, COMPONENTS..., STATE?) => { }
```

Examples:

```csharp
query.ForEach((ref Position pos) => { });

query.ForEach((Entity e, ref Position pos, in Velocity vel) => { });

float dt = 0.1f;
query.ForEach(
    (ref Position pos, in Velocity vel, ref float dt) => { },
    ref dt
);
```

---

## ForEachChunk

Chunk-level iteration (fewer instructions, SIMD-friendly).

Pattern:

```
(LENGTH, ENTITIES?, HANDLES..., STATE?) => { }
```

Example:

```csharp
query.ForEachChunk((int len,
                    ReadHandle<Entity> entities,
                    WriteHandle<Position> positions,
                    ReadHandle<Velocity> velocities) =>
{
    for (int i = 0; i < len; i++)
    {
        ref var pos = ref positions[i];
        ref readonly var vel = ref velocities[i];
        pos.X += vel.Dx;
        pos.Y += vel.Dy;
    }
});
```

---

# Change Filter

Only enumerate chunks whose components were written recently.

```csharp
var query = db.QueryBuilder
    .WithAll<Position, SentPosition, PositionDelta>()
    .WithChangeFilter<Position>()
    .Build();

query.ForEach((in Position pos, ref SentPosition sent, ref PositionDelta delta) =>
{
    delta.Dx = pos.X - sent.X;
    delta.Dy = pos.Y - sent.Y;
    sent.X = pos.X;
    sent.Y = pos.Y;
});
```

* `ref` marks a write
* `in` marks a read
* `[ChunkChange]` attributes flag writes in custom methods

---

# Manual Enumeration

Full control for custom iteration, SIMD, or advanced logic.

### Read Handles

```csharp
int total = 0;
foreach (var (length, wallets) in query.ReadHandles<Wallet>())
{
    for (int i = 0; i < length; i++)
        total += wallets[i].Gold;
}
```

### Write Handles

```csharp
foreach (var (length, healths) in query.WriteHandles<Health>())
{
    for (int i = 0; i < length; i++)
        healths[i].Points = Math.Min(healths[i].Max, healths[i].Points + 50);
}
```

### Combined

```csharp
foreach (var chunk in query.WriteHandles<Position, Velocity>())
{
    var positions = chunk.WriteHandleT0();
    var velocities = chunk.ReadHandleT1();

    for (int i = 0; i < chunk.EntityCount; i++)
    {
        ref var pos = ref positions[i];
        ref readonly var vel = ref velocities[i];
        pos.X += vel.Dx;
        pos.Y += vel.Dy;
    }
}
```

---

# Multithreading

Parallelized versions of the same APIs:

```csharp
query.ForEachParallel((in Position pos, ref SentPosition sent, ref PositionDelta delta) =>
{
    delta.Dx = pos.X - sent.X;
    delta.Dy = pos.Y - sent.Y;
    sent = new SentPosition(pos.X, pos.Y);
});
```

Chunk-level:

```csharp
query.ForEachChunkParallel((int length,
                            ReadHandle<Position> positions,
                            WriteHandle<SentPosition> sent,
                            WriteHandle<PositionDelta> delta) =>
{
    for (int i = 0; i < length; i++)
    {
        delta[i].Dx = positions[i].X - sent[i].X;
        delta[i].Dy = positions[i].Y - sent[i].Y;
        sent[i] = new SentPosition(positions[i].X, positions[i].Y);
    }
});
```

⚠️ **No structural changes** (`Create`, `Add`, `Remove`, `Destroy`) while in parallel.

---

# Parallel Aggregate

Use a custom aggregator struct to manage independent per-thread state and combine results.

```csharp
public struct CountAggregate : IParallelAggregate<int>
{
    public int Sum;

    public int Create(int threadIndex) => 0;

    public void Join(int threadIndex, ref int local)
        => Sum += local;
}
```

Usage:

```csharp
var agg = new CountAggregate();
query.ForEachParallel((in Wallet w, ref int local) =>
{
    local += w.Gold;
}, ref agg);

Console.WriteLine(agg.Sum);
```

---

# SIMD

Handles can be reinterpreted as vectors when components are SIMD-friendly:

```csharp
query.ForEachChunk((int length,
                    ReadHandle<Position> positions,
                    WriteHandle<SentPosition> sent,
                    WriteHandle<PositionDelta> delta) =>
{
    var simdPos  = positions.Reinterpret<Position, Vector256<int>>();
    var simdSent = sent.Reinterpret<SentPosition, Vector256<int>>();
    var simdDelta = delta.Reinterpret<PositionDelta, Vector256<int>>();

    // 2 ints per component → process 4 entities per SIMD lane
    int aligned = length - (length & 3);
    int simdLen = aligned / 4;

    for (int i = 0; i < simdLen; i++)
    {
        simdDelta[i] = simdPos[i] - simdSent[i];
        simdSent[i]  = simdPos[i];
    }

    for (int i = aligned; i < length; i++)
    {
        delta[i].Dx = positions[i].X - sent[i].X;
        delta[i].Dy = positions[i].Y - sent[i].Y;
        sent[i] = new SentPosition(positions[i].X, positions[i].Y);
    }
});
```

---