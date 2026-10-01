# EntitiesDb.Benchmark

BenchmarkDotNet suite that tracks EntitiesDb against plain C# baselines. It exists to catch
performance regressions and to give README numbers a reproducible source — it is **not** a
cross-library ECS comparison (see [Follow-ups](#follow-ups)).

## What is measured

Every scenario has three implementations that do the *same work* on the *same seed data*:

| Category     | Baseline                                                                 |
|--------------|--------------------------------------------------------------------------|
| `Structs`    | `List<struct>` (array-of-structs), iterated via `CollectionsMarshal.AsSpan` |
| `Classes`    | `List<class>` (array of heap objects)                                    |
| `EntitiesDb` | Archetype/chunk storage, several iteration styles (see below)             |

| Scenario                                    | Work                                                                                              | Params            |
|---------------------------------------------|---------------------------------------------------------------------------------------------------|-------------------|
| `CreateEntityWithOneComponent`              | Create N entities with one `int` component (`Reserve` first). Also a `CommandBuffer` + `Commit` variant. | N = 100k         |
| `SystemWithOneComponent`                    | `c1.Value++` over every entity                                                                    | N = 100k, 1M      |
| `SystemWithTwoComponents`                   | `c1.Value += c2.Value` over every entity (single archetype)                                        | N = 100k, 1M      |
| `SystemWithTwoComponentsVariedComposition`  | Same as above, entities spread across 4 archetypes that all contain C1 + C2                        | N = 100k, 1M      |
| `ParallelScaling`                           | `c1 += c2` with `ForEachParallel` / `ForEachChunkParallel` (+SIMD) vs single-thread `ForEachChunk`, plus dispatch floor | N = 100k, 1M × threads |

EntitiesDb iteration styles used in the `System*` scenarios:

| Row                                    | API                                              | Notes                                                    |
|----------------------------------------|--------------------------------------------------|----------------------------------------------------------|
| `EntitiesDb_ForEach`                   | `query.ForEach((ref C1 a, in C2 b) => …)`        | Source-generated per-entity loop. **Like-for-like with the baselines.** |
| `EntitiesDb_ForEachChunk`              | `query.ForEachChunk((len, WriteHandle<C1>, ReadHandle<C2>) => …)` | Source-generated per-chunk loop over raw handles |
| `EntitiesDb_ForEachChunk_Simd`         | same + `handle.Reinterpret<C1, Vector256<int>>()` | Hand-vectorized (8 ints per op)                          |
| `EntitiesDb_Enumeration_Simd`          | `foreach (var (len, a, b) in query.WriteHandles<C1, C2>())` + SIMD | Manual enumeration, hand-vectorized             |
| `EntitiesDb_ForEachParallel`           | `query.ForEachParallel(…)`                       | Threads = physical cores (`ProcessorCount / 2`)          |
| `EntitiesDb_ForEachChunkParallel`      | `query.ForEachChunkParallel(…)`                  | Threads = physical cores (`ProcessorCount / 2`)          |
| `EntitiesDb_ForEachChunkParallel_Simd` | same + SIMD                                      |                                                          |

All EntitiesDb contexts use library-default options (`EntityDatabaseOptions`: 16 KB chunks) with
`parallelThreads = Environment.ProcessorCount / 2` (physical cores on SMT machines) where a parallel row exists.

`ParallelScaling` additionally sweeps thread count (physical cores, logical − 1, all logical) at 100k and 1M
entities and includes `Dispatch_OneEntity`, the fixed fork/join cost of a parallel call.

## Running

```bash
# everything (10-30 minutes depending on machine)
dotnet run -c Release --project src/EntitiesDb.Benchmark

# a subset
dotnet run -c Release --project src/EntitiesDb.Benchmark -- --filter '*SystemWithTwoComponents*'

# quick sanity pass (not for publishing numbers)
dotnet run -c Release --project src/EntitiesDb.Benchmark -- --filter '*' --job short
```

Reports are written to `src/EntitiesDb.Benchmark/BenchmarkDotNet.Artifacts/results/` (git-ignored).
The `*-report-github.md` files are the ones to copy into [`results/`](results/) when publishing a
new snapshot; name the folder `<yyyy-MM-dd>-v<version>` and keep the BenchmarkDotNet environment
header (CPU, OS, runtime) intact.

The optimizations validator is intentionally **enabled**: a Debug build fails validation instead of
silently producing bad numbers.

## Follow-ups

Ideas that would make the suite more useful, roughly in value order:

1. **Structural changes** — `Add`/`Remove` component, `AddAndRemove`, `Destroy` scenarios; this is where archetype ECSs differ most.
2. **Random access** — `Read<T>(id)` / `Write<T>(id)` over shuffled entity ids.
3. **Change filter** — `WithChangeFilter<T>()` queries at 0 % / 10 % / 100 % dirty chunks.
4. **Buffer components** — `ReadBuffer`/`WriteBuffer`, `AddOrAppend` throughput.
5. **Three-component system** and a `ChunkJob` / `IParallelAggregate` reduction row.
6. **SoA SIMD baseline** — a hand-vectorized `int[]` baseline so the SIMD rows have an apples-to-apples comparison.
7. **Cross-library numbers** — contribute EntitiesDb to
   [Doraku/Ecs.CSharp.Benchmark](https://github.com/Doraku/Ecs.CSharp.Benchmark) (this suite's scenario
   names already mirror it) rather than pulling other ECS packages into this repo.
8. **CI snapshot** — a `workflow_dispatch` GitHub Action that runs `--job short` and uploads the reports as an artifact (relative numbers only; hosted runners are noisy).
