![Banner](https://raw.githubusercontent.com/Juiix/EntitiesDb/main/.github/banner.png)

[![NuGet Version](https://img.shields.io/nuget/v/EntitiesDb.svg)](https://www.nuget.org/packages/EntitiesDb)
[![NuGet Downloads](https://img.shields.io/nuget/dt/EntitiesDb.svg)](https://www.nuget.org/packages/EntitiesDb)
[![Build & Publish](https://github.com/Juiix/EntitiesDb/actions/workflows/nuget-publish.yml/badge.svg)](https://github.com/Juiix/EntitiesDb/actions/workflows/nuget-publish.yml)
[![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/Juiix/EntitiesDb/blob/main/LICENSE)
![.NET 8 | netstandard2.1](https://img.shields.io/badge/.NET-8.0%20%7C%20netstandard2.1-512BD4)

### A High-Performance, Lightweight C# Entity Component System

A modern, cache-efficient **Entity Component System (ECS)** for games, simulations, and other data-oriented workloads.
EntitiesDb focuses on **raw performance**, **simple APIs**, and **zero external dependencies** — all in pure C#.

```csharp
using var db = new EntityDatabase();

var player = db.Create(new Position(0, 0), new Velocity(1, 1));

var query = db.QueryBuilder.WithAll<Position, Velocity>().Build();

query.ForEach((ref Position pos, in Velocity vel) =>
{
    pos.X += vel.Dx;
    pos.Y += vel.Dy;
});
```

---

# Highlights

* 🚀 **Fast** — archetype-organized, fixed-size chunk storage; components of a type are contiguous in memory
* 🧩 **Simple** — any `struct`/`class`/`record` is a component; expressive `WithAll / WithAny / WithNone / WithOnly` queries
* ⚙️ **Source-generated `ForEach`** — lambdas with `ref`/`in` parameters are rewritten at compile time into strongly-typed loops; the generator ships inside the package, no setup
* 🧵 **Multithreaded** — `ForEachParallel` / `ForEachChunkParallel` with a single fork/join per query, plus per-thread aggregates for reductions *(opt-in via options)*
* 📦 **Tags & inline buffers** — zero-size tag components and `[Buffer(n)]` inline lists stored directly in the chunk
* 🔍 **Change filters** — only visit chunks whose components were written since the last pass
* 🧮 **SIMD-friendly** — reinterpret component handles as `Vector128/256/512<T>` and process several entities per instruction
* 📝 **Command buffers** — thread-safe deferred `Create / Add / Set / Remove / Destroy`, applied with one `Commit()`
* 🔧 **Manual enumeration** — walk archetypes, chunks and raw read/write handles when you need full control
* 0️⃣ **GC-friendly** — unmanaged chunk memory, allocation-free iteration, no per-entity objects
* 🎯 **Targets `net8.0` and `netstandard2.1`** — no dependencies on .NET 8 (`System.Memory` + `System.Runtime.CompilerServices.Unsafe` on netstandard)

---

# Installation

```
dotnet add package EntitiesDb
```

```xml
<PackageReference Include="EntitiesDb" Version="*" />
```

```
Install-Package EntitiesDb
```

### Requirements

* **Runtime:** .NET 8+ or any runtime that supports `netstandard2.1` (Unity, Mono, .NET Core 3.x, …)
* **SDK:** the `ForEach` source generator needs a Roslyn 4.3+ compiler — .NET 6 SDK or newer, or a recent Visual Studio / Rider
* **Language:** lambdas with `ref` / `in` parameters (C# 7.2+); the samples below use `record struct` (C# 10)

> Consuming the **project** instead of the package? Reference the generator too, so `ForEach` gets rewritten:
> ```xml
> <ProjectReference Include="..\EntitiesDb\EntitiesDb.csproj" />
> <ProjectReference Include="..\EntitiesDb.SourceGenerators\EntitiesDb.SourceGenerators.csproj"
>                   OutputItemType="Analyzer" ReferenceOutputAssembly="false" />
> ```
> Without the generator, `ForEach` throws `CodeGenerationException` at runtime.

---

# Quick Start

```csharp
using EntitiesDb;

// 1. Define components — plain types, no base class or interface
public record struct Position(float X, float Y);
public record struct Velocity(float Dx, float Dy);
public record struct Health(int Points, int Max);

// 2. Create a database (defaults: 16 KB chunks, unlimited entities, parallel disabled)
using var db = new EntityDatabase();

// 3. Create entities (up to 16 components per call)
var player = db.Create(new Position(10, 10), new Velocity(5, 5), new Health(100, 100));
var rock   = db.Create(new Position(0, 0));

// 4. Work with a single entity
db.Add(rock, new Velocity(1, 0));
db.Has<Velocity>(rock);                             // true
ref var hp = ref db.Write<Health>(player);          // by-ref write
hp.Points -= 10;
ref readonly var pos = ref db.Read<Position>(rock); // by-ref read
db.Remove<Velocity>(rock);
db.Destroy(rock);

// 5. Build a query once, reuse it every frame
var movers = db.QueryBuilder
    .WithAll<Position, Velocity>()
    .Build();

// 6. Iterate — `ref` = write, `in` = read
movers.ForEach((ref Position pos, in Velocity vel) =>
{
    pos.X += vel.Dx;
    pos.Y += vel.Dy;
});
```

---

# Feature Tour

Each snippet is a taste — follow the links for the full story in [DOCS.md](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md).

### Queries

```csharp
var query = db.QueryBuilder
    .WithAll<Damage, EnemyTag>()   // must have all
    .WithAny<PlayerTag, NpcTag>()  // at least one of
    .WithNone<BossTag>()           // none of
    .Build();

var exact = db.QueryBuilder.WithOnly<Position, Velocity>().Build(); // exactly these
```
→ [QueryBuilder](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#querybuilder)

### Tags & Buffers

```csharp
[Tag] public struct EnemyTag { }                       // zero-size marker
[Buffer(8)] public record struct Item(int Id, int Count); // inline list, 8 elements in-chunk

var e = db.Create(new Position(1, 1), new EnemyTag(), new[] { new Item(1, 5) });

var items = db.WriteBuffer<Item>(e);
items.Add(new Item(2, 1));
```
→ [Buffers](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#buffers) · [Tags](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#tags)

### Chunk iteration & SIMD

```csharp
query.ForEachChunk((int len, WriteHandle<Position> pos, ReadHandle<Velocity> vel) =>
{
    var p = pos.Reinterpret<Position, Vector256<float>>(); // 4 entities per lane (2 floats each)
    var v = vel.Reinterpret<Velocity, Vector256<float>>();
    int simdLen = (len - (len & 3)) / 4;
    for (int i = 0; i < simdLen; i++) p[i] += v[i];
    for (int i = simdLen * 4; i < len; i++) { pos[i].X += vel[i].Dx; pos[i].Y += vel[i].Dy; }
});
```
→ [ForEachChunk](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#foreachchunk) · [SIMD](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#simd)

### Multithreading

```csharp
// parallel execution is opt-in — physical cores are the sweet spot (see Benchmarks)
using var db = new EntityDatabase(new EntityDatabaseOptions(parallelThreads: Environment.ProcessorCount / 2));

query.ForEachParallel((ref Position pos, in Velocity vel) => { pos.X += vel.Dx; pos.Y += vel.Dy; });

// per-thread state + join for reductions (SumAggregate : IParallelAggregate<int>)
var total = new SumAggregate();
query.ForEachParallel((in Wallet w, ref int local) => local += w.Gold, ref total);
```
> No structural changes (`Create/Add/Remove/Destroy`) inside parallel loops — use a command buffer.

→ [Multithreading](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#multithreading) · [Parallel Aggregate](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#parallel-aggregate)

### Change filters

```csharp
[TrackChanges] public record struct Position(float X, float Y);

var moved = db.QueryBuilder
    .WithAll<Position, Renderable>()
    .WithChangeFilter<Position>()   // only chunks where Position was written since last pass
    .Build();
```
→ [Change Filter](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#change-filter)

### Command buffers

```csharp
var commands = db.CreateCommandBuffer(initialCapacity: 256);

query.ForEachParallel((Entity e, in Health hp) =>
{
    if (hp.Points <= 0) commands.Destroy(e);   // thread-safe
});

commands.Commit();                              // apply on the main thread
```
→ [Command Buffers](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#command-buffers)

### Manual enumeration

```csharp
foreach (var (length, positions, velocities) in query.WriteHandles<Position, Velocity>())
    for (int i = 0; i < length; i++) { positions[i].X += velocities[i].Dx; }
```
→ [Manual Enumeration](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#manual-enumeration)

---

# How It Works

* An **entity** is an `int` id plus a version; ids are recycled and the version rejects stale handles.
* Entities with the same set of components share an **archetype**. Each archetype owns a list of fixed-size **chunks** (16 KB by default, `EntityDatabaseOptions.chunkByteSize`) laid out **structure-of-arrays**: all `Position`s in a chunk are contiguous, then all `Velocity`s, and so on.
* Unmanaged components live in unmanaged chunk memory (no GC tracking); `class` components are supported through parallel managed arrays but iterate slower.
* A **query** is a signature filter that lazily matches archetypes; iterating it means walking matched chunks and handing out spans (`ReadHandle<T>` / `WriteHandle<T>`).
* `ForEach` lambdas are captured by a Roslyn **incremental source generator** that emits a strongly-typed extension method per call site — no delegate invocation or boxing per entity. The generator is packaged as an analyzer inside the NuGet package.
* **Parallel** methods run one fork/join per call over a fixed thread pool; threads claim batches of chunks from a shared cursor (dynamic scheduling, so a preempted thread can't stall the join) and per-thread state is created and joined through `IParallelAggregate<T>`. Steady-state parallel calls don't allocate.
* **Structural changes** (create/destroy/add/remove) move entities between archetypes and are single-threaded; a thread-safe `CommandBuffer` defers them.
* Limits: 256 component types per process, 16 components per `Create`/`Add` call, component size ≤ 32 KB.

---

# Benchmarks

<!-- BENCHMARKS:START -->
Numbers from the in-repo [BenchmarkDotNet suite](https://github.com/Juiix/EntitiesDb/blob/main/src/EntitiesDb.Benchmark/README.md), which compares EntitiesDb against plain
`List<struct>` / `List<class>` loops doing the same work. Snapshot: **2026-08-17, EntitiesDb 3.6.1**,
Intel Core i7-8700K (6C/12T), Windows 11, .NET 8.0.27 x64, library-default options (16 KB chunks),
parallel rows on 12 threads. Full reports with mean/error/std-dev columns:
[`src/EntitiesDb.Benchmark/results/2026-08-17-v3.6.1`](https://github.com/Juiix/EntitiesDb/blob/main/src/EntitiesDb.Benchmark/results/2026-08-17-v3.6.1/README.md).

**`c1.Value += c2.Value` over every entity** — `SystemWithTwoComponents` (single archetype), **median** time per pass:

| Method | 100 000 entities | 1 000 000 entities |
|--------|-----------------:|-------------------:|
| `Structs` — `List<struct>` baseline (AoS) | 59.8 μs | 1,234.0 μs |
| `Classes` — `List<class>` baseline | 143.4 μs | 4,189.0 μs |
| `EntitiesDb_ForEach` — source-generated lambda | 84.9 μs | 968.8 μs |
| `EntitiesDb_ForEachChunk` — chunk handles | 72.1 μs | 738.7 μs |
| `EntitiesDb_ForEachChunk_Simd` — chunk handles + `Vector256<int>` | 18.4 μs | 421.1 μs |
| `EntitiesDb_Enumeration_Simd` — manual `WriteHandles` + SIMD | 17.7 μs | 408.7 μs |

**Same work, entities spread over 4 archetypes** — `SystemWithTwoComponentsVariedComposition` (median):

| Method | 100 000 entities | 1 000 000 entities |
|--------|-----------------:|-------------------:|
| `Structs` baseline (4 lists) | 66.2 μs | 1,510.0 μs |
| `Classes` baseline (4 lists) | 217.1 μs | 8,896.6 μs |
| `EntitiesDb_ForEach` | 76.6 μs | 1,224.5 μs |
| `EntitiesDb_ForEachChunk` | 56.0 μs | 803.3 μs |
| `EntitiesDb_Enumeration_Simd` | 18.1 μs | 604.6 μs |

**Parallel** — `ParallelScaling`, same `c1 += c2` work, `parallelThreads = 6` (physical cores), median per pass:

| Method | 100 000 entities | 1 000 000 entities |
|--------|-----------------:|-------------------:|
| `ForEachChunk` — single thread, for reference | 55.2 μs | 740.6 μs |
| `ForEachParallel` | 22.5 μs | 213.2 μs |
| `ForEachChunkParallel` | 15.9 μs | 176.0 μs |
| `ForEachChunkParallel_Simd` | 7.4 μs | 74.6 μs |
| `Dispatch_OneEntity` — fork/join floor (query matching 1 entity) | 0.95 μs | 0.94 μs |

Parallel calls allocate nothing in steady state. Threads claim chunks from a shared cursor (guided
self-scheduling), so a preempted thread only delays its current batch. **Thread count matters:** with
11–12 threads on this 6-core/12-thread CPU the same calls were 2–5× slower and highly variable
(SMT siblings add nothing to memory-bound loops, and using every logical processor oversubscribes
the box) — use physical cores.

**Create 100 000 entities with one component** — `CreateEntityWithOneComponent` (mean; managed allocations only ‡):

| Method | Mean | Allocated (managed) ‡ |
|--------|-----:|----------:|
| `Structs` — `List<struct>.Add` | 271.3 μs | 781 KB |
| `Classes` — `List<class>.Add` | 967.7 μs | 3,125 KB |
| `EntitiesDb` — `Reserve` + `Create` | 3,067.2 μs | 84 KB |
| `EntitiesDb_CommandBuffer` — queue + `Commit` | 16,142.5 μs | 14,351 KB |

Notes:

* `EntitiesDb_ForEach` is the like-for-like row (a scalar per-entity loop, same as the baselines). `*_Simd` rows are hand-vectorized; a SIMD baseline over SoA arrays is on the [follow-up list](https://github.com/Juiix/EntitiesDb/blob/main/src/EntitiesDb.Benchmark/README.md#follow-ups).
* Medians are shown throughout; the machine was not isolated.
* ‡ BenchmarkDotNet's `Allocated` column counts managed heap only. EntitiesDb stores entities and unmanaged components in native chunk memory, which is **not** included — the 84 KB is entity-map growth, not total memory.
* Entity creation is a structural change and is not EntitiesDb's design center; the numbers are here for completeness. The command-buffer path trades throughput for thread-safety and deferral.
* All timings are one machine on one day. Reproduce with `dotnet run -c Release --project src/EntitiesDb.Benchmark`.
<!-- BENCHMARKS:END -->

---

# Documentation

📚 Full guide: **[DOCS.md](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md)**

[Core Concepts](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#core-concepts) ·
[EntityDatabase](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#entitydatabase) ·
[Entities](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#entities) ·
[Components](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#components) ·
[Buffers](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#buffers) ·
[Tags](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#tags) ·
[Queries](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#queries) ·
[ForEach](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#foreach) ·
[ForEachChunk](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#foreachchunk) ·
[Change Filter](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#change-filter) ·
[Manual Enumeration](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#manual-enumeration) ·
[Multithreading](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#multithreading) ·
[Parallel Aggregate](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#parallel-aggregate) ·
[Command Buffers](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#command-buffers) ·
[SIMD](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#simd) ·
[Attributes](https://github.com/Juiix/EntitiesDb/blob/main/DOCS.md#attributes-reference)

---

# Building From Source

```bash
git clone https://github.com/Juiix/EntitiesDb.git
cd EntitiesDb

dotnet build src/EntitiesDb.sln -c Release
dotnet test  src/EntitiesDb.Tests
dotnet run   -c Release --project src/EntitiesDb.Benchmark      # optional, slow
```

Repository layout:

| Path | What it is |
|------|------------|
| `src/EntitiesDb` | The library (`net8.0`, `netstandard2.1`). Much of the generic API surface (`Create<T0..T15>`, `WithAll<…>`, handles, …) is produced from the T4 templates in `Templates/`. |
| `src/EntitiesDb.SourceGenerators` | Roslyn incremental generator for `ForEach*` calls; packed into the NuGet package under `analyzers/dotnet/cs`. |
| `src/EntitiesDb.Tests` | xUnit test suite. |
| `src/EntitiesDb.Benchmark` | BenchmarkDotNet suite (see its [README](https://github.com/Juiix/EntitiesDb/blob/main/src/EntitiesDb.Benchmark/README.md)). |

Editing a `.tt` template requires re-running the T4 generator (Visual Studio does this on save; the generated `.cs` files are checked in).

---

# Contributing

Issues and pull requests are welcome. Please run `dotnet test src/EntitiesDb.Tests` before opening a PR, and include a benchmark run for performance-sensitive changes.

# License

[MIT](https://github.com/Juiix/EntitiesDb/blob/main/LICENSE) — free for commercial and open-source use.
