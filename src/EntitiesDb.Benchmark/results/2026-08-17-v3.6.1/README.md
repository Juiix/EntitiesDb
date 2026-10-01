# Benchmark snapshot — 2026-08-17, EntitiesDb 3.6.1

Full BenchmarkDotNet reports (`*-report-github.md`) for every scenario in the suite, run with:

```
dotnet run -c Release --project src/EntitiesDb.Benchmark
```

Environment (from the report headers):

```
BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.9168)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.300, .NET 8.0.27, X64 RyuJIT x86-64-v3
```

Settings: library-default `EntityDatabaseOptions` (16 KB chunks). `MemoryDiagnoser` enabled.
The four `System*`/`Create*` reports were taken with `parallelThreads = Environment.ProcessorCount` (12) and the
previous static-partition scheduler; the suite has since been changed to physical cores (`ProcessorCount / 2`)
and the runner to guided chunk claiming — see the two `ParallelScaling` reports for the effect. The `System*`
parallel rows should be re-run before being quoted.

Caveats:

* Desktop machine, not isolated — the parallel rows at 1M entities show high variance
  (see the `StdDev` / `Median` columns); those workloads are memory-bandwidth-bound, so
  extra threads help less than at 100k where the working set fits in cache.
* `*_Simd` rows are hand-vectorized (`Vector256<int>`); `Structs` / `Classes` baselines are plain
  scalar loops. `EntitiesDb_ForEach` is the like-for-like comparison.
* Create numbers use `[IterationSetup]` (fresh database per iteration) with `InvocationCount=1`,
  so they carry more measurement overhead than the `System*` rows.

| Scenario | Report |
|----------|--------|
| CreateEntityWithOneComponent | [report](EntitiesDb.Benchmark.CreateEntityWithOneComponent-report-github.md) |
| SystemWithOneComponent | [report](EntitiesDb.Benchmark.SystemWithOneComponent-report-github.md) |
| SystemWithTwoComponents | [report](EntitiesDb.Benchmark.SystemWithTwoComponents-report-github.md) |
| SystemWithTwoComponentsVariedComposition | [report](EntitiesDb.Benchmark.SystemWithTwoComponentsVariedComposition-report-github.md) |
| ParallelScaling — thread count 6 / 11 / 12, **previous static-partition scheduler** (motivated the rewrite; run 2026-08-18) | [report](EntitiesDb.Benchmark.ParallelScaling-report-github.md) |
| ParallelScaling — 6 threads, **current guided-claim scheduler** (run 2026-08-18) | [report](EntitiesDb.Benchmark.ParallelScaling-6threads-guided-report-github.md) |
