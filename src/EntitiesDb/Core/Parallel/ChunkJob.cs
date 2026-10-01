#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
namespace EntitiesDb;

internal sealed class ChunkJob<T> : IJob where T : IChunkJob
{
	/// <summary>Shared work list for this parallel call (one per call, shared by all jobs).</summary>
	public ChunkJobWork Work;

	/// <summary>Per-thread job state (created by the aggregate, joined after the run).</summary>
	public T ForEach;

	public void Execute()
	{
		var work = Work;
		var ranges = work.Ranges.AsSpan();
		var archetypes = work.RangeArchetypes.AsSpan();
		var ends = work.RangeEnds;

		// claims are monotonically increasing per job, so the range index only ever moves forward
		int rangeIndex = 0;
		while (work.TryClaim(out var start, out var end))
		{
			for (int c = start; c < end; c++)
			{
				while (c >= ends[rangeIndex]) rangeIndex++;

				var range = ranges[rangeIndex];
				var offset = c - (ends[rangeIndex] - range.Size);
				ref readonly var chunk = ref archetypes[rangeIndex].GetChunk(range.Start + offset);
				ForEach.ForEach(in chunk);
			}
		}
	}
}
