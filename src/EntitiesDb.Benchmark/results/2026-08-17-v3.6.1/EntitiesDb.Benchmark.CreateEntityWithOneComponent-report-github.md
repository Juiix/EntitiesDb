```

BenchmarkDotNet v0.15.4, Windows 11 (10.0.26200.9168)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.300
  [Host]     : .NET 8.0.27 (8.0.27, 8.0.2726.22922), X64 RyuJIT x86-64-v3
  Job-CNUJVU : .NET 8.0.27 (8.0.27, 8.0.2726.22922), X64 RyuJIT x86-64-v3

InvocationCount=1  UnrollFactor=1  

```
| Method                   | EntityCount | Mean        | Error     | StdDev    | Gen0      | Gen1      | Gen2      | Allocated   |
|------------------------- |------------ |------------:|----------:|----------:|----------:|----------:|----------:|------------:|
| Structs                  | 100000      |    271.3 μs |  13.07 μs |  38.12 μs |         - |         - |         - |   781.27 KB |
| Classes                  | 100000      |    967.7 μs |  39.87 μs | 115.67 μs |         - |         - |         - |  3125.02 KB |
| EntitiesDb               | 100000      |  3,067.2 μs |  98.13 μs | 271.93 μs |         - |         - |         - |    84.45 KB |
| EntitiesDb_CommandBuffer | 100000      | 16,142.5 μs | 310.93 μs | 824.54 μs | 1000.0000 | 1000.0000 | 1000.0000 | 14351.41 KB |
