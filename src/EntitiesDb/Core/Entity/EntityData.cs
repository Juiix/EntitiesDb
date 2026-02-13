namespace EntitiesDb;

public readonly ref struct EntityData(ref Chunk chunk, int index)
{
#if NETSTANDARD2_1
	internal readonly Ref<Chunk> ChunkRef = new(ref chunk);
	internal readonly ref Chunk TargetChunk => ref ChunkRef.Value;
#else
	internal readonly ref Chunk TargetChunk = ref chunk;
#endif

	internal readonly int Index = index;

	/// <summary>
	/// If this entity has a component of type <typeparamref name="T0"/>
	/// </summary>
	/// <typeparam name="T0"></typeparam>
	/// <returns></returns>
	public bool Has<T0>()
	{
		return TargetChunk.Has<T0>();
	}

	/// <summary>
	/// Returns a readonly reference to an entity component
	/// Ref values may be invalid after structural changes and should not be stored.
	/// </summary>
	/// <typeparam name="T">Component type</typeparam>
	/// <returns>Readonly reference to the entity component</returns>
	/// <exception cref="ComponentException"></exception>
	public readonly ref readonly T? Read<T>()
	{
		return ref TargetChunk.Read<T>(Index);
	}

	/// <summary>
	/// Returns a readonly entity component buffer.
	/// Buffer is invalid after structural changes and should not be stored.
	/// </summary>
	/// <typeparam name="T">Component type</typeparam>
	/// <returns>Entity component buffer</returns>
	/// <exception cref="ComponentException"></exception>
	public readonly ReadBuffer<T> ReadBuffer<T>() where T : unmanaged
	{
		return TargetChunk.ReadBuffer<T>(Index);
	}

	/// <summary>
	/// Returns a reference to an entity component.
	/// Ref values may be invalid after structural changes and should not be stored.
	/// </summary>
	/// <remarks>
	/// Marks the accessed <see cref="Chunk"/> as changed.
	/// </remarks>
	/// <typeparam name="T">Component type</typeparam>
	/// <returns>Reference to the entity component</returns>
	/// <exception cref="ComponentException"></exception>
	[ChunkChange]
	public readonly ref T? Write<T>()
	{
		return ref TargetChunk.Write<T>(Index);
	}

	/// <summary>
	/// Returns an entity component buffer.
	/// Buffer is invalid after structural changes and should not be stored.
	/// </summary>
	/// <remarks>
	/// Marks the accessed <see cref="Chunk"/> as changed.
	/// </remarks>
	/// <typeparam name="T">Component type</typeparam>
	/// <returns>Entity component buffer</returns>
	/// <exception cref="ComponentException"></exception>
	[ChunkChange]
	public readonly WriteBuffer<T> WriteBuffer<T>() where T : unmanaged
	{
		return TargetChunk.WriteBuffer<T>(Index);
	}
}
