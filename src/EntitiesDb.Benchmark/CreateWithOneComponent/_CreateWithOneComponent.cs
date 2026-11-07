using BenchmarkDotNet.Attributes;

namespace EntitiesDb.Benchmark;

[BenchmarkCategory(Categories.Create)]
[MemoryDiagnoser]
// One invocation per iteration (IterationSetup): a method the workload calls once per iteration, such
// as CommandBuffer.Commit with its per-entity loop, stays unoptimized for its first ~30-50 calls.
// Without a long warmup BenchmarkDotNet can stop measuring before that, and compares tier-0 code.
[WarmupCount(80)]
[MinIterationCount(30)]
public partial class CreateEntityWithOneComponent
{
	[Params(100_000)]
	public int EntityCount { get; set; }

	[IterationSetup]
	public void Setup() => BenchmarkOperations.SetupContexts(this);

	[IterationCleanup]
	public void Cleanup() => BenchmarkOperations.CleanupContexts(this);
}
