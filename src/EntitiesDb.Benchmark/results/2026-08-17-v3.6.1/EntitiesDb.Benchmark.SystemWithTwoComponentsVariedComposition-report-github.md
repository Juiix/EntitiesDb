```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.9168)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.300
  [Host]     : .NET 8.0.27 (8.0.27, 8.0.2726.22922), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.27 (8.0.27, 8.0.2726.22922), X64 RyuJIT x86-64-v3


```
| Method                          | EntityCount | Mean        | Error      | StdDev       | Median      | Allocated |
|-------------------------------- |------------ |------------:|-----------:|-------------:|------------:|----------:|
| EntitiesDb_Enumeration_Simd     | 100000      |    18.36 μs |   0.365 μs |     0.859 μs |    18.13 μs |         - |
| EntitiesDb_ForEachChunkParallel | 100000      |    40.89 μs |   1.407 μs |     4.036 μs |    40.73 μs |     464 B |
| EntitiesDb_ForEachChunk         | 100000      |    55.40 μs |   1.085 μs |     1.372 μs |    55.97 μs |         - |
| EntitiesDb_ForEachParallel      | 100000      |    61.67 μs |   2.556 μs |     7.083 μs |    60.51 μs |     464 B |
| Structs                         | 100000      |    69.81 μs |   2.455 μs |     7.161 μs |    66.18 μs |         - |
| EntitiesDb_ForEach              | 100000      |    76.60 μs |   0.423 μs |     0.396 μs |    76.55 μs |         - |
| Classes                         | 100000      |   228.87 μs |   8.318 μs |    24.265 μs |   217.06 μs |         - |
| EntitiesDb_ForEachChunkParallel | 1000000     |   334.56 μs |  31.982 μs |    88.087 μs |   302.92 μs |     464 B |
| EntitiesDb_Enumeration_Simd     | 1000000     |   652.85 μs |  93.004 μs |   274.224 μs |   604.62 μs |         - |
| EntitiesDb_ForEachChunk         | 1000000     |   814.52 μs |  17.838 μs |    50.020 μs |   803.29 μs |         - |
| EntitiesDb_ForEachParallel      | 1000000     | 1,201.49 μs | 389.197 μs | 1,071.962 μs |   722.96 μs |     469 B |
| EntitiesDb_ForEach              | 1000000     | 1,251.65 μs |  36.095 μs |   105.859 μs | 1,224.49 μs |         - |
| Structs                         | 1000000     | 1,576.68 μs |  54.519 μs |   159.893 μs | 1,509.95 μs |         - |
| Classes                         | 1000000     | 9,150.77 μs | 243.452 μs |   686.661 μs | 8,896.64 μs |         - |
