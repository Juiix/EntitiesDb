using BenchmarkDotNet.Attributes;

namespace EntitiesDb.Benchmark;

[BenchmarkCategory(Categories.Create)]
[MemoryDiagnoser]
public partial class CreateEntityWithOneComponent
{
	[Params(100_000)]
	public int EntityCount { get; set; }

	[IterationSetup]
	public void Setup() => BenchmarkOperations.SetupContexts(this);

	[IterationCleanup]
	public void Cleanup() => BenchmarkOperations.CleanupContexts(this);
}
