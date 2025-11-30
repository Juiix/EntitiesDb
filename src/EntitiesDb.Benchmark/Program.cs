// See https://aka.ms/new-console-template for more information

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
	/*
	typeof(CreateEntityWithOneComponent),
	typeof(SystemWithOneComponent),
	typeof(SystemWithTwoComponentsVariedComposition),
	*/
});

IConfig configuration = DefaultConfig.Instance
	.WithOptions(ConfigOptions.DisableOptimizationsValidator)
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
