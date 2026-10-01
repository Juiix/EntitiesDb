```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.9168)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.300
  [Host]     : .NET 8.0.27 (8.0.27, 8.0.2726.22922), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.27 (8.0.27, 8.0.2726.22922), X64 RyuJIT x86-64-v3


```
| Method                               | EntityCount | Mean        | Error      | StdDev     | Median      | Gen0   | Allocated |
|------------------------------------- |------------ |------------:|-----------:|-----------:|------------:|-------:|----------:|
| EntitiesDb_Enumeration_Simd          | 100000      |    17.68 μs |   0.346 μs |   0.569 μs |    17.67 μs |      - |         - |
| EntitiesDb_ForEachChunkParallel_Simd | 100000      |    18.20 μs |   0.474 μs |   1.307 μs |    17.79 μs | 0.0610 |     464 B |
| EntitiesDb_ForEachChunk_Simd         | 100000      |    18.38 μs |   0.350 μs |   0.443 μs |    18.41 μs |      - |         - |
| EntitiesDb_ForEachChunkParallel      | 100000      |    31.79 μs |   1.143 μs |   3.262 μs |    30.58 μs | 0.0610 |     464 B |
| Structs                              | 100000      |    59.64 μs |   1.155 μs |   1.418 μs |    59.84 μs |      - |         - |
| EntitiesDb_ForEachChunk              | 100000      |    72.62 μs |   4.176 μs |  12.312 μs |    72.09 μs |      - |         - |
| EntitiesDb_ForEach                   | 100000      |    85.34 μs |   1.674 μs |   1.928 μs |    84.85 μs |      - |         - |
| EntitiesDb_ForEachParallel           | 100000      |    86.37 μs |  18.282 μs |  49.113 μs |    68.10 μs |      - |     464 B |
| EntitiesDb_ForEachChunkParallel_Simd | 1000000     |   137.00 μs |  22.987 μs |  62.147 μs |   112.57 μs |      - |     464 B |
| Classes                              | 100000      |   145.42 μs |   3.018 μs |   8.851 μs |   143.42 μs |      - |         - |
| EntitiesDb_Enumeration_Simd          | 1000000     |   426.01 μs |  23.554 μs |  68.336 μs |   408.73 μs |      - |         - |
| EntitiesDb_ForEachChunk_Simd         | 1000000     |   430.85 μs |  21.178 μs |  60.764 μs |   421.09 μs |      - |         - |
| EntitiesDb_ForEachParallel           | 1000000     |   558.77 μs |  57.449 μs | 158.231 μs |   512.28 μs |      - |     464 B |
| EntitiesDb_ForEachChunkParallel      | 1000000     |   686.77 μs | 164.785 μs | 467.467 μs |   508.76 μs |      - |     464 B |
| EntitiesDb_ForEachChunk              | 1000000     |   777.02 μs |  46.644 μs | 133.078 μs |   738.69 μs |      - |         - |
| EntitiesDb_ForEach                   | 1000000     |   968.84 μs |  18.879 μs |  16.736 μs |   968.79 μs |      - |         - |
| Structs                              | 1000000     | 1,234.01 μs |  22.030 μs |  22.623 μs | 1,233.98 μs |      - |         - |
| Classes                              | 1000000     | 4,247.02 μs |  83.840 μs | 180.474 μs | 4,189.04 μs |      - |         - |
