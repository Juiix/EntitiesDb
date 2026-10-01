```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.9168)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.300
  [Host]     : .NET 8.0.27 (8.0.27, 8.0.2726.22922), X64 RyuJIT x86-64-v3
  Job-VLLPHX : .NET 8.0.27 (8.0.27, 8.0.2726.22922), X64 RyuJIT x86-64-v3

MaxIterationCount=60  MinIterationCount=25  

```
| Method                    | EntityCount | ThreadCount | Mean         | Error        | StdDev       | Median       | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|-------------------------- |------------ |------------ |-------------:|-------------:|-------------:|-------------:|------:|--------:|-------:|----------:|------------:|
| Dispatch_OneEntity        | 100000      | 6           |   1,010.1 ns |      7.55 ns |      9.55 ns |   1,011.6 ns |  0.02 |    0.00 | 0.0172 |     112 B |          NA |
| ForEachChunkParallel_Simd | 100000      | 6           |   5,634.0 ns |     68.84 ns |     91.89 ns |   5,618.0 ns |  0.09 |    0.00 | 0.0381 |     272 B |          NA |
| ForEachChunkParallel      | 100000      | 6           |  18,729.0 ns |    241.50 ns |    322.40 ns |  18,701.6 ns |  0.31 |    0.01 | 0.0305 |     272 B |          NA |
| ForEachParallel           | 100000      | 6           |  37,235.3 ns |    737.87 ns |  1,572.47 ns |  36,630.4 ns |  0.61 |    0.04 |      - |     272 B |          NA |
| ForEachChunk              | 100000      | 6           |  61,193.5 ns |  1,217.07 ns |  2,567.21 ns |  61,382.6 ns |  1.00 |    0.06 |      - |         - |          NA |
|                           |             |             |              |              |              |              |       |         |        |           |             |
| Dispatch_OneEntity        | 100000      | 11          |   2,936.9 ns |    135.90 ns |    292.53 ns |   2,878.2 ns |  0.05 |    0.01 | 0.0153 |     112 B |          NA |
| ForEachParallel           | 100000      | 11          |  50,410.4 ns |  3,789.28 ns |  7,909.63 ns |  48,556.6 ns |  0.87 |    0.14 | 0.0610 |     432 B |          NA |
| ForEachChunk              | 100000      | 11          |  57,911.5 ns |    656.98 ns |    854.26 ns |  57,784.1 ns |  1.00 |    0.02 |      - |         - |          NA |
| ForEachChunkParallel      | 100000      | 11          |  58,281.0 ns | 21,383.29 ns | 44,160.21 ns |  38,622.0 ns |  1.01 |    0.76 |      - |     432 B |          NA |
| ForEachChunkParallel_Simd | 100000      | 11          |  60,472.6 ns | 18,835.73 ns | 38,899.06 ns |  44,635.4 ns |  1.04 |    0.67 | 0.0610 |     432 B |          NA |
|                           |             |             |              |              |              |              |       |         |        |           |             |
| Dispatch_OneEntity        | 100000      | 12          |   4,329.2 ns |    890.15 ns |  1,838.32 ns |   4,147.8 ns |  0.07 |    0.03 | 0.0153 |     112 B |          NA |
| ForEachChunkParallel_Simd | 100000      | 12          |  28,366.1 ns |  2,891.42 ns |  6,035.48 ns |  26,062.1 ns |  0.48 |    0.10 |      - |     464 B |          NA |
| ForEachChunk              | 100000      | 12          |  59,196.8 ns |  1,169.47 ns |  2,138.45 ns |  59,013.4 ns |  1.00 |    0.05 |      - |         - |          NA |
| ForEachChunkParallel      | 100000      | 12          |  98,737.8 ns | 18,570.51 ns | 38,763.58 ns |  82,401.4 ns |  1.67 |    0.65 |      - |     464 B |          NA |
| ForEachParallel           | 100000      | 12          | 108,379.4 ns | 10,745.18 ns | 22,429.20 ns | 104,122.2 ns |  1.83 |    0.38 |      - |     464 B |          NA |
|                           |             |             |              |              |              |              |       |         |        |           |             |
| Dispatch_OneEntity        | 1000000     | 6           |     975.1 ns |     16.48 ns |     20.84 ns |     967.7 ns | 0.001 |    0.00 | 0.0172 |     112 B |          NA |
| ForEachChunkParallel_Simd | 1000000     | 6           | 111,759.4 ns | 13,580.70 ns | 30,375.18 ns | 109,922.6 ns | 0.154 |    0.04 |      - |     272 B |          NA |
| ForEachChunkParallel      | 1000000     | 6           | 227,167.9 ns | 16,782.89 ns | 37,189.73 ns | 214,942.5 ns | 0.314 |    0.05 |      - |     272 B |          NA |
| ForEachParallel           | 1000000     | 6           | 346,904.6 ns |  6,870.97 ns | 10,492.69 ns | 344,528.6 ns | 0.479 |    0.02 |      - |     272 B |          NA |
| ForEachChunk              | 1000000     | 6           | 724,757.2 ns | 12,799.35 ns | 15,718.75 ns | 726,168.7 ns | 1.000 |    0.03 |      - |         - |          NA |
|                           |             |             |              |              |              |              |       |         |        |           |             |
| Dispatch_OneEntity        | 1000000     | 11          |   2,115.6 ns |    401.91 ns |    830.01 ns |   1,895.7 ns | 0.003 |    0.00 | 0.0172 |     112 B |          NA |
| ForEachChunkParallel_Simd | 1000000     | 11          |  83,908.9 ns |  7,070.50 ns | 15,519.91 ns |  87,389.7 ns | 0.114 |    0.02 |      - |     432 B |          NA |
| ForEachChunkParallel      | 1000000     | 11          | 157,993.0 ns | 13,551.09 ns | 29,458.95 ns | 148,901.9 ns | 0.215 |    0.04 |      - |     432 B |          NA |
| ForEachParallel           | 1000000     | 11          | 258,609.4 ns | 18,575.11 ns | 38,773.17 ns | 243,820.6 ns | 0.351 |    0.06 |      - |     432 B |          NA |
| ForEachChunk              | 1000000     | 11          | 741,204.8 ns | 28,478.90 ns | 62,511.88 ns | 725,810.1 ns | 1.007 |    0.12 |      - |         - |          NA |
|                           |             |             |              |              |              |              |       |         |        |           |             |
| Dispatch_OneEntity        | 1000000     | 12          |   5,513.6 ns |  1,550.12 ns |  3,336.80 ns |   3,837.5 ns | 0.007 |    0.00 | 0.0153 |     112 B |          NA |
| ForEachChunkParallel_Simd | 1000000     | 12          | 179,001.7 ns | 34,960.11 ns | 73,742.74 ns | 151,265.7 ns | 0.222 |    0.09 |      - |     464 B |          NA |
| ForEachChunkParallel      | 1000000     | 12          | 292,202.4 ns | 14,973.83 ns | 31,255.97 ns | 285,589.0 ns | 0.363 |    0.05 |      - |     464 B |          NA |
| ForEachParallel           | 1000000     | 12          | 432,620.0 ns | 19,593.66 ns | 42,595.02 ns | 419,759.9 ns | 0.538 |    0.07 |      - |     464 B |          NA |
| ForEachChunk              | 1000000     | 12          | 810,079.9 ns | 31,689.22 ns | 68,214.39 ns | 795,733.3 ns | 1.007 |    0.12 |      - |         - |          NA |
