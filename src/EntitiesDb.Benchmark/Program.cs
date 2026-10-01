using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using EntitiesDb.Benchmark;
using System.Globalization;

CultureInfo cultureInfo = new("en-US");

CultureInfo.CurrentCulture = cultureInfo;
CultureInfo.CurrentUICulture = cultureInfo;
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

BenchmarkSwitcher benchmark = BenchmarkSwitcher.FromTypes(new[]
{
	typeof(SystemWithTwoComponents),
	typeof(CreateEntityWithOneComponent),
	typeof(SystemWithOneComponent),
	typeof(SystemWithTwoComponentsVariedComposition),
	typeof(ParallelScaling),
});

// Release-only: the optimizations validator is intentionally left enabled so a Debug build
// can never produce publishable numbers. Reports (incl. *-report-github.md) land in
// BenchmarkDotNet.Artifacts/results/.
IConfig configuration = ManualConfig.Create(DefaultConfig.Instance)
	.WithBuildTimeout(TimeSpan.FromMinutes(10))
	.WithOrderer(new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest));

if (args.Length > 0)
{
	benchmark.Run(args, configuration);
}
else
{
	benchmark.RunAll(configuration);
}
