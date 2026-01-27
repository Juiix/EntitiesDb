namespace EntitiesDb;

public readonly ref struct EntityData(ref Chunk chunk, int index)
{
#if NETSTANDARD2_1
	internal readonly Ref<Chunk> ChunkRef = new(ref chunk);
	internal readonly ref Chunk Chunk => ref ChunkRef.Value;
#else
	internal readonly ref Chunk Chunk = ref chunk;
#endif

	internal readonly int Index = index;

	public readonly ref readonly T? Read<T>()
	{
		return ref Chunk.Read<T>(Index);
	}

	public readonly ReadBuffer<T> ReadBuffer<T>() where T : unmanaged
	{
		return Chunk.ReadBuffer<T>(Index);
	}

	public readonly ref T? Write<T>()
	{
		return ref Chunk.Write<T>(Index);
	}

	public readonly WriteBuffer<T> WriteBuffer<T>() where T : unmanaged
	{
		return Chunk.WriteBuffer<T>(Index);
	}
}
