```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.9168)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.300
  [Host]     : .NET 8.0.27 (8.0.27, 8.0.2726.22922), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.27 (8.0.27, 8.0.2726.22922), X64 RyuJIT x86-64-v3


```
| Method                          | EntityCount | Mean        | Error     | StdDev    | Median      | Gen0   | Allocated |
|-------------------------------- |------------ |------------:|----------:|----------:|------------:|-------:|----------:|
| EntitiesDb_Enumeration_Simd     | 100000      |    10.97 μs |  0.101 μs |  0.089 μs |    10.99 μs |      - |         - |
| EntitiesDb_ForEachChunkParallel | 100000      |    48.82 μs |  2.871 μs |  7.907 μs |    46.74 μs | 0.0610 |     464 B |
| EntitiesDb_ForEachParallel      | 100000      |    50.21 μs |  1.902 μs |  5.303 μs |    48.64 μs | 0.0610 |     464 B |
| EntitiesDb_ForEach              | 100000      |    51.96 μs |  0.935 μs |  0.829 μs |    51.61 μs |      - |         - |
| EntitiesDb_ForEachChunk         | 100000      |    52.51 μs |  0.700 μs |  0.620 μs |    52.30 μs |      - |         - |
| Structs                         | 100000      |    76.83 μs |  1.480 μs |  1.519 μs |    76.70 μs |      - |         - |
| Classes                         | 100000      |    81.38 μs |  1.087 μs |  1.163 μs |    81.39 μs |      - |         - |
| EntitiesDb_Enumeration_Simd     | 1000000     |   157.31 μs |  3.130 μs |  8.410 μs |   155.68 μs |      - |         - |
| EntitiesDb_ForEachChunkParallel | 1000000     |   207.20 μs |  9.603 μs | 26.287 μs |   198.70 μs |      - |     464 B |
| EntitiesDb_ForEachParallel      | 1000000     |   276.16 μs | 22.813 μs | 62.451 μs |   246.75 μs |      - |     464 B |
| EntitiesDb_ForEach              | 1000000     |   649.79 μs | 19.462 μs | 57.078 μs |   636.32 μs |      - |         - |
| EntitiesDb_ForEachChunk         | 1000000     |   654.83 μs | 13.096 μs | 36.723 μs |   647.78 μs |      - |         - |
| Structs                         | 1000000     |   984.60 μs | 19.390 μs | 34.465 μs |   984.80 μs |      - |         - |
| Classes                         | 1000000     | 2,702.00 μs | 50.298 μs | 51.652 μs | 2,690.73 μs |      - |         - |
