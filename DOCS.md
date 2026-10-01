# EntitiesDb Documentation

# Table of Contents

* [Core Concepts](#core-concepts)
* [EntityDatabase](#entitydatabase)
  * [Options](#options)
  * [Parallel Runner](#parallel-runner)
  * [Limits](#limits)
* [Entities](#entities)
* [Components](#components)
  * [Add / Read / Write / Remove](#add--read--write--remove)
  * [Buffers](#buffers)
  * [Tags](#tags)
  * [Reserving Capacity](#reserving-capacity)
* [Queries](#queries)
  * [QueryBuilder](#querybuilder)
  * [ForEach](#foreach)
  * [ForEachChunk](#foreachchunk)
* [Change Filter](#change-filter)
* [Manual Enumeration](#manual-enumeration)
* [Multithreading](#multithreading)
  * [Parallel Aggregate](#parallel-aggregate)
  * [Parallel Options](#parallel-options)
* [Command Buffers](#command-buffers)
* [SIMD](#simd)
* [Attributes Reference](#attributes-reference)

---

# Core Concepts

EntitiesDb is built around a classic data-oriented ECS design:

* **Entities**: Lightweight integer IDs (`Entity` = id + version). They have no data themselves — components define the data.
* **Components**: Plain C# types (`struct`, `class`, `record`, etc). Stored densely in chunked arrays.
* **Archetypes**: Unique sets of components. Entities with the same component signature are grouped into the same chunk layout.
* **Queries**: Pull in chunks of entities matching component filters — the basis for all system updates.
* **Source-Generated Iterators**: `ForEach` methods generate strongly-typed, allocation-free iteration code at compile time.

---

# EntityDatabase

`EntityDatabase` is the container for all entities, archetypes and chunks. It is `IDisposable` — chunk memory is unmanaged and freed on `Dispose`.

```csharp
using var db = new EntityDatabase();          // default options
```

## Options

Configure memory/storage behavior through `EntityDatabaseOptions`:

```csharp
var options = new EntityDatabaseOptions(
    chunkByteSize: 16384,       // size of storage chunks (default 16 KB)
    maxEntities: int.MaxValue,  // hard cap on live entities (default unlimited)
    parallelThreads: 4          // threads for parallel execution; -1 disables parallel (default)
);

using var db = new EntityDatabase(options);
```

> ⚠️ **Parallel execution is disabled by default.** `ForEachParallel` / `ForEachChunkParallel` fall back to
> single-threaded execution unless `parallelThreads > 1` (or a custom runner) is supplied.
> Use the number of **physical** cores (`Environment.ProcessorCount / 2` on SMT/hyper-threaded CPUs):
> `new EntityDatabaseOptions(parallelThreads: Environment.ProcessorCount / 2)`. Component loops are
> memory-bound, so SMT siblings add nothing, and using every logical processor (including the calling
> thread) oversubscribes the machine — in the repo benchmarks 12 threads on a 6C/12T CPU was *slower*
> than single-threaded, while 6 threads gave a stable 3× speed-up.

Useful properties:

```csharp
db.EntityCount;     // live entities
db.MaxEntities;     // configured cap
db.Archetypes;      // ArchetypeCollection — direct archetype/chunk access
db.ParallelRunner;  // IParallelJobRunner? (null when parallel is disabled)
db.QueryBuilder;    // start building a query
```

Maintenance:

```csharp
db.Clear();               // destroy every entity and reset versions (memory stays allocated)
db.TrimExcess();          // release unused chunk memory (call rarely, not per tick)
```

## Parallel Runner

Parallel work is dispatched through an `IParallelJobRunner`. By default the database creates its own
`ParallelJobRunner(parallelThreads)`. You can supply one yourself — for example to share a single
thread pool across several databases:

```csharp
using var runner = new ParallelJobRunner(threadCount: 8, threadName: "ecs-worker");

using var dbA = new EntityDatabase(new EntityDatabaseOptions(parallelThreads: 8), runner);
using var dbB = new EntityDatabase(new EntityDatabaseOptions(parallelThreads: 8), runner);
```

When a runner is passed in, the database does **not** dispose it.

A `ParallelJobRunner(threadCount)` runs a call's jobs on the calling thread plus up to `threadCount - 1`
workers. A call with `n` jobs signals only `n - 1` workers (a one-job call never leaves the calling
thread), and once the caller's own job is done it runs any job a worker hasn't started yet — so a job
may run on any of the runner's threads, and the call never waits on a thread the scheduler hasn't
run. Idle workers sleep instead of spinning. Still, keep `threadCount` at or below the cores the
process can actually use: more threads than cores only adds wake-ups.

## Limits

* Up to **256 distinct component types** per process (`ComponentRegistry.MaxComponents`).
* Up to **16 components** per `Create` / `Add` / `Set` / `Remove` call (the generic fast path). Larger signatures can be built with `Signature` and `Create(in Signature)` / `Move`.
* A component must fit inside a chunk; component size is capped at `short.MaxValue` bytes.
* Zero-size components must be marked `[Tag]`.

---

# Entities

```csharp
// create entity
var entity = db.Create(new Position(10, 10), new Health(100, 100));
db.Exists(entity);      // true

// create an empty entity, add components later
var empty = db.Create();

// duplicate an entity and all of its components
var copy = db.Clone(entity);

// destroy entity
db.Destroy(entity);     // destroy
db.Exists(entity);      // false
```

* `Entity` carries an `Id` and a `Version`. Ids are recycled after `Destroy`; the version lets `Exists`/`Read`/… reject stale handles.
* Every entity API has an `Entity` overload (checks the version) and an `int entityId` overload (skips the version check — faster, use when you know the id is live).
* Pass **up to 16 components** when creating or adding (fast path).
* Structural changes (`Create` / `Add` / `Remove` / `Destroy` / `Clone` / `Move`) are **not thread-safe** and must not be made inside parallel execution — use a [Command Buffer](#command-buffers).

---

# Components

Components are simple data types that can be `struct` or `class`:

```csharp
public record struct Position(float X, float Y);
public record struct Velocity(float Dx, float Dy);
```
> *`class` components should be avoided when fast enumeration is a priority of the component*

## Add / Read / Write / Remove

```csharp
db.Add(entity, new Velocity(10, 10));

db.Has<Velocity>(entity);                // true
db.HasAny<Velocity, Health>(entity);     // true if it has at least one of them

db.Set(entity, new Velocity(200, 200));  // overwrite component (must already exist)

db.Remove<Velocity>(entity);

// Read-only
ref readonly var position = ref db.Read<Position>(entity);

// Write
ref var pos = ref db.Write<Position>(entity);
pos.X += 5;

// Non-throwing read
if (db.TryRead<Health>(entity, out var health)) { /* ... */ }
```

Multiple components can be added or removed in one structural move:

```csharp
db.Add(entity, new Velocity(1, 1), new Health(50, 50));
db.Remove<Velocity, Health>(entity);

// swap components in a single archetype move
db.AddAndRemove(entity, new Health(50, 50), Signature.From<Velocity>());
```

## Buffers

Buffers act like **inline component lists**, stored directly in the chunk.
Only `unmanaged` types can be buffered.

```csharp
[Buffer(8)] // use the buffer attribute to mark a component as buffered and passing the inline buffer size
public record struct InventoryItem(int Id, int Count);
```

Up to `internalCapacity` (8 above) elements live inline in the chunk; longer buffers spill to a heap
allocation transparently.

### Creating with a buffer:

```csharp
var entity = db.Create(
    new Position(100, 100),
    new Velocity(10, 10),
    new[] {
        new InventoryItem(1, 1),
        new InventoryItem(2, 10)
    } // Buffers must be the last component arguments
);
```

### Accessing a buffer:

```csharp
// Read
var read = db.ReadBuffer<InventoryItem>(entity);
for (int i = 0; i < read.Length; i++)
{
    ref readonly var item = ref read[i];
}

// Write
var write = db.WriteBuffer<InventoryItem>(entity);
write.Add(new InventoryItem(3, 5));
write.RemoveAt(0);
var span = write.Span;
```

`ReadBuffer<T>` / `WriteBuffer<T>` are `ref struct` views — don't store them past the next structural change.

## Tags

Tags are **zero-data components** used for classification and filtering:

```csharp
[Tag] public struct PlayerTag { }
[Tag] public struct EnemyTag { }
[Tag] public struct BossTag  { }

var player = db.Create(new Position(100, 100), new PlayerTag());
var enemy  = db.Create(new Position(50, 50), new EnemyTag());
var boss   = db.Create(new Position(10, 10), new EnemyTag(), new BossTag());
```

## Reserving Capacity

When you know how many entities of a given archetype you're about to create, reserve chunk memory
up front to avoid incremental growth:

```csharp
db.Reserve<Position, Velocity>(entityCount: 100_000);
for (int i = 0; i < 100_000; i++)
    db.Create(new Position(i, i), new Velocity(1, 0));
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

Queries are cheap objects that match archetypes lazily; build them once (e.g. in a system's
constructor) and reuse them every frame. `db.QueryBuilder` is reset after each `Build()`.

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

* `ref` parameters are **writes**, `in` parameters are **reads** (this also drives [change filters](#change-filter)).
* Buffer components are received as `ReadBuffer<T>` / `WriteBuffer<T>` parameters.
* The last `ref` parameter after the components is optional **state** passed by reference — a cheap way to avoid closure allocations.
* `ForEach` is rewritten at compile time by the `EntitiesDb.SourceGenerators` analyzer that ships inside the NuGet package. If the generator is not active the call throws `CodeGenerationException`.

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

Buffer components use `ReadBufferHandle<T>` / `WriteBufferHandle<T>`.

---

# Change Filter

Enable change filtering with the `TrackChanges` attribute:
```csharp
[TrackChanges]
public record struct Position(float X, float Y);
```

Only enumerate chunks whose components were written recently.

```csharp
var query = db.QueryBuilder
    .WithAll<Position, SentPosition, PositionDelta>()
    .WithChangeFilter<Position>()                         // add change filter
    .Build();

query.ForEach((in Position pos, ref SentPosition sent, ref PositionDelta delta) =>
{
    delta.Dx = pos.X - sent.X;
    delta.Dy = pos.Y - sent.Y;
    sent.X = pos.X;
    sent.Y = pos.Y;
});
```

* `ref` marks a write, `in` marks a read — only writes bump a chunk's change version.
* Any write access (`db.Write<T>`, `WriteHandle<T>`, `Set`, `Add`, …) marks the chunk changed for that component. Library methods that do so are annotated `[ChunkChange]`.
* A query's change filter starts when the query is built: changes made before that are never reported.
* Each pass reports the chunks changed since the last pass and consumes them; call `query.ResetChanges()` to drop everything pending, so the next pass only reports changes made from then on.

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

### Archetypes and Chunks

```csharp
foreach (var archetype in query.EnumerateArchetypes()) { /* archetype.Signature, EntityCount, ... */ }
foreach (var chunk in query.EnumerateChunks())         { /* chunk.EntityCount, chunk.ReadHandle<T>() ... */ }
```

---

# Multithreading

Parallelized versions of the same APIs (requires `parallelThreads > 1` in the options — see [Options](#options)):

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

Work is executed as a single fork/join across all matching archetypes: each thread claims batches of chunks
from a shared cursor until the query is exhausted (dynamic scheduling), then per-thread results are joined.

⚠️ **No structural changes** (`Create`, `Add`, `Remove`, `Destroy`, …) while in parallel — queue them in a [Command Buffer](#command-buffers) and `Commit()` afterwards.

## Parallel Aggregate

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

## Parallel Options

Every parallel method accepts an optional `ParallelOptions` to cap the number of threads used for that call:

```csharp
query.ForEachParallel((ref Position p) => { /* ... */ }, new EntitiesDb.ParallelOptions(maxThreads: 2));
```

> Projects with implicit usings also see `System.Threading.Tasks.ParallelOptions`, so qualify the type as `EntitiesDb.ParallelOptions` (or add a `using` alias).

---

# Command Buffers

A `CommandBuffer` records structural changes and plays them back later with a single `Commit()`.
It is **thread-safe**, which makes it the tool for creating/destroying/adding/removing from inside
`ForEachParallel`, or for deferring changes until the end of a frame.

```csharp
var commands = db.CreateCommandBuffer(initialCapacity: 256);

query.ForEachParallel((Entity e, in Health health) =>
{
    if (health.Points <= 0)
        commands.Destroy(e);            // safe from any thread
});

commands.Commit();                      // apply everything on the main thread
```

Supported operations:

```csharp
var spawned = commands.Create(new Position(0, 0), new Velocity(1, 1)); // returns a placeholder Entity
commands.Add(entity, new Velocity(1, 1));       // add-or-overwrite
commands.Set(entity, new Position(5, 5));       // same as Add in a command buffer
commands.Remove<Velocity>(entity);
commands.Destroy(entity);

// buffer components
commands.Add(entity, new[] { new InventoryItem(1, 1) });          // replace / create the whole buffer
commands.AddOrAppend(spawned, new InventoryItem(2, 3));           // append to an existing buffer, or create it (placeholder entities work too)

commands.Commit();   // apply; exceptions from individual commands are collected into an AggregateException
commands.Clear();    // discard without applying (Commit also clears)
```

Notes:

* Entities returned from `commands.Create(...)` are placeholders that resolve when `Commit()` runs; you can use them for further commands on the same buffer.
* Conflicting operations on the same entity/component inside one buffer resolve to the **last** one queued: `Set` then `Remove` removes; `Remove` then `Set` sets; `Set` then `AddOrAppend` on the same buffer component keeps only the appended elements. Multiple `AddOrAppend` calls accumulate.
* Reuse the buffer across frames — it keeps its allocations after `Commit`/`Clear`.

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

Components of one type are stored contiguously inside a chunk, so a handle is a plain span of `T`
that can be reinterpreted as `Vector128<T>` / `Vector256<T>` / `Vector512<T>` when `sizeof(T)` divides evenly.

---

# Attributes Reference

| Attribute            | Target    | Purpose                                                                                     |
|----------------------|-----------|---------------------------------------------------------------------------------------------|
| `[Tag]`              | component | Zero-size marker component. Required for empty structs.                                     |
| `[Buffer(capacity)]` | component | Inline list component; `capacity` elements are stored in-chunk before spilling to the heap. Unmanaged types only. |
| `[TrackChanges]`     | component | Enables per-chunk change versions so the component can be used in `WithChangeFilter<T>()`. |
| `[ChunkChange]`      | method    | Informational: the method marks chunks as changed.                                          |
| `[StructuralChange]` | method    | Informational: the method changes archetype layout — queries/refs may be invalidated; never call during parallel execution. |

---
