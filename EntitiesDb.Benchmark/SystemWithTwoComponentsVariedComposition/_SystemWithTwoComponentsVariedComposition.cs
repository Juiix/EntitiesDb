using BenchmarkDotNet.Attributes;

namespace EntitiesDb.Benchmark;

[BenchmarkCategory(Categories.System)]
[MemoryDiagnoser]
//[HardwareCounters(BenchmarkDotNet.Diagnosers.HardwareCounter.CacheMisses)]
public partial class SystemWithTwoComponentsVariedComposition
{
	[Params(100_000)]
	public int EntityCount { get; set; }

	[GlobalSetup]
	public void Setup() => BenchmarkOperations.SetupContexts(this, EntityCount);

	[GlobalCleanup]
	public void Cleanup() => BenchmarkOperations.CleanupContexts(this);
}
