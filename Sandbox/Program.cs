using BenchmarkDotNet.Running;
using Sandbox;

#if RELEASE
BenchmarkRunner.Run<SeqEqBench>();
#else
var test = new BufferTest();
test.Setup();
test.Test();
test.Cleanup();
#endif