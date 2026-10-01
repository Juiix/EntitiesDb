```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.9168)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.300
  [Host]     : .NET 8.0.27 (8.0.27, 8.0.2726.22922), X64 RyuJIT x86-64-v3
  Job-VLLPHX : .NET 8.0.27 (8.0.27, 8.0.2726.22922), X64 RyuJIT x86-64-v3

MaxIterationCount=60  MinIterationCount=25  

```
| Method                    | EntityCount | ThreadCount | Mean         | Error        | StdDev       | Median       | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------------------- |------------ |------------ |-------------:|-------------:|-------------:|-------------:|------:|--------:|----------:|------------:|
| Dispatch_OneEntity        | 100000      | 6           |     948.3 ns |      9.22 ns |     10.25 ns |     950.2 ns |  0.02 |    0.00 |         - |          NA |
| ForEachChunkParallel_Simd | 100000      | 6           |   7,740.4 ns |    329.98 ns |    738.05 ns |   7,412.9 ns |  0.14 |    0.01 |         - |          NA |
| ForEachChunkParallel      | 100000      | 6           |  15,985.3 ns |    330.48 ns |    718.45 ns |  15,870.6 ns |  0.29 |    0.02 |         - |          NA |
| ForEachParallel           | 100000      | 6           |  22,291.2 ns |    412.04 ns |    850.94 ns |  22,523.8 ns |  0.40 |    0.02 |         - |          NA |
| ForEachChunk              | 100000      | 6           |  55,523.1 ns |  1,084.24 ns |  1,622.84 ns |  55,162.9 ns |  1.00 |    0.04 |         - |          NA |
|                           |             |             |              |              |              |              |       |         |           |             |
| Dispatch_OneEntity        | 1000000     | 6           |     947.1 ns |     11.38 ns |     13.98 ns |     944.0 ns | 0.001 |    0.00 |         - |          NA |
| ForEachChunkParallel_Simd | 1000000     | 6           |  75,082.2 ns |  1,484.47 ns |  2,397.14 ns |  74,627.4 ns | 0.101 |    0.00 |         - |          NA |
| ForEachChunkParallel      | 1000000     | 6           | 176,070.7 ns |  2,620.46 ns |  3,407.33 ns | 175,986.1 ns | 0.237 |    0.01 |         - |          NA |
| ForEachParallel           | 1000000     | 6           | 213,838.5 ns |  4,073.75 ns |  5,297.03 ns | 213,233.7 ns | 0.288 |    0.01 |         - |          NA |
| ForEachChunk              | 1000000     | 6           | 742,688.1 ns | 12,148.35 ns | 14,461.75 ns | 740,555.0 ns | 1.000 |    0.03 |         - |          NA |
