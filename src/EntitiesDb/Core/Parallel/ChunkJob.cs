#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
namespace EntitiesDb;

internal sealed class ChunkJob<T> : IJob where T : IChunkJob
{
	public Archetype Archetype;
	public SpanList<ChunkRange> Ranges;
	public int Start;
	public int End;
	public int First;
	public int Last;
	public T ForEach;

	public void Execute()
	{
		var archetype = Archetype;
		var range = Ranges[Start];
		if (Start == End)
		{
			for (int i = First; i < Last; i++)
			{
				ref readonly var chunk = ref archetype.GetChunk(range.Start + i);
				ForEach.ForEach(in chunk);
			}
			return;
		}

		for (int i = First; i < range.Size; i++)
		{
			ref readonly var chunk = ref archetype.GetChunk(range.Start + i);
			ForEach.ForEach(in chunk);
		}

		for (int i = Start + 1; i < End; i++)
		{
			range = Ranges[i];
			for (int j = 0; j < range.Size; j++)
			{
				ref readonly var chunk = ref archetype.GetChunk(range.Start + j);
				ForEach.ForEach(in chunk);
			}
		}

		range = Ranges[End];
		for (int i = 0; i < Last; i++)
		{
			ref readonly var chunk = ref archetype.GetChunk(range.Start + i);
			ForEach.ForEach(in chunk);
		}
	}
}