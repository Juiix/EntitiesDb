using System;

namespace EntitiesDb;

public interface IParallelJobRunner
{
	int ThreadCount { get; }
	void ExecuteJobs(Memory<IJob?> jobs);
}
