#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
using System;

namespace EntitiesDb;

internal sealed class ChunkJob<T> : IJob where T : IChunkJob
{
	public Archetype Archetype;
	public int Start;
	public int Size;
	public T ForEach;

	public void Execute()
	{
		var archetype = Archetype;
		ForEach.Enter(Archetype);
		int start = Start, size = Size;
		for (var i = 0; i < size; i++)
		{
			ref readonly var chunk = ref archetype.GetChunk(start + i);
			ForEach.ForEach(in chunk);
		}
	}
}