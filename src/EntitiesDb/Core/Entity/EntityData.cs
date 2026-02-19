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
	/// The target <see cref="EntitiesDb.Entity"/>
	/// </summary>
	public Entity Entity => TargetChunk.Entity(Index);

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
    /// <para>
	/// Returns a readonly reference to an entity component
	/// </para>
    /// <para>
    /// Ref values may be invalid after structural changes and should not be stored.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Component type</typeparam>
    /// <returns>Readonly reference to the entity component</returns>
    /// <exception cref="ComponentException"></exception>
    public readonly ref readonly T? Read<T>()
	{
		return ref TargetChunk.Read<T>(Index);
	}

    /// <summary>
    /// <para>
	/// Returns a readonly entity component buffer.
	/// </para>
    /// <para>
    /// Buffer is invalid after structural changes and should not be stored.
	/// </para>
    /// </summary>
    /// <typeparam name="T">Component type</typeparam>
    /// <returns>Entity component buffer</returns>
    /// <exception cref="ComponentException"></exception>
    public readonly ReadBuffer<T> ReadBuffer<T>() where T : unmanaged
	{
		return TargetChunk.ReadBuffer<T>(Index);
    }

    /// <summary>
	/// Attempts to read an entity component. Will return false if the entity does not have the component.
    /// </summary>
    /// <typeparam name="T">Component type</typeparam>
    /// <returns>Readonly reference to the entity component</returns>
    /// <exception cref="ComponentException"></exception>
    public bool TryRead<T>(out T? component)
    {
		if (!TargetChunk.Has<T>())
		{
			component = default;
			return false;
		}

		component = TargetChunk.Read<T>(Index);
		return true;
	}

    /// <summary>
	/// <para>
    /// Attempts to read an entity component buffer.
	/// Will return false if the entity does not have the component.
	/// </para>
	/// <para>
    /// Buffer is invalid after structural changes and should not be stored.
	/// </para>
    /// </summary>
    /// <typeparam name="T">Component type</typeparam>
    /// <returns>Entity component buffer</returns>
    /// <exception cref="ComponentException"></exception>
    public bool TryReadBuffer<T>(out ReadBuffer<T> buffer) where T : unmanaged
    {
        if (!TargetChunk.Has<T>())
        {
            buffer = default;
            return false;
        }

        buffer = TargetChunk.ReadBuffer<T>(Index);
		return true;
    }

    /// <summary>
    /// <para>
	/// Returns a reference to an entity component.
	/// </para>
    /// <para>
	/// Ref values may be invalid after structural changes and should not be stored.
	/// </para>
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
    /// <para>
    /// Returns an entity component buffer.
    /// </para>
    /// <para>
    /// Buffer is invalid after structural changes and should not be stored.
    /// </para>
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
