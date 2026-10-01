using System.Runtime.CompilerServices;

namespace EntitiesDb;

public readonly ref struct EntityData(ref Chunk chunk, int index)
{
#if NETSTANDARD2_1
	internal readonly Ref<Chunk> ChunkRef = new(ref chunk);
	internal readonly ref Chunk TargetChunk => ref ChunkRef.Value;
    public bool IsNull => ChunkRef.IsEmpty;
#else
	internal readonly ref Chunk TargetChunk = ref chunk;

    public bool IsNull => Unsafe.IsNullRef(ref TargetChunk);
#endif

    internal readonly int Index = index;

	/// <summary>
	/// <see cref="TargetChunk"/>, checked. An archetype's chunk array is replaced (and the old one cleared)
	/// when it grows or is trimmed; a chunk without offsets means this EntityData outlived its array.
	/// </summary>
	private ref Chunk Live
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ref var chunk = ref TargetChunk;
			if (chunk.IdToOffsets is null)
				ThrowHelper.ThrowStaleEntityData();
			return ref chunk;
		}
	}

	/// <summary>
	/// The target <see cref="EntitiesDb.Entity"/>
	/// </summary>
	public Entity Entity => Live.Entity(Index);

	/// <summary>
	/// If this entity has a component of type <typeparamref name="T0"/>
	/// </summary>
	/// <typeparam name="T0"></typeparam>
	/// <returns></returns>
	public bool Has<T0>()
	{
		return Live.Has<T0>();
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
		return ref Live.Read<T>(Index);
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
		return Live.ReadBuffer<T>(Index);
    }

    /// <summary>
	/// Attempts to read an entity component. Will return false if the entity does not have the component.
    /// </summary>
    /// <typeparam name="T">Component type</typeparam>
    /// <returns>Readonly reference to the entity component</returns>
    /// <exception cref="ComponentException"></exception>
    public bool TryRead<T>(out T? component)
    {
		if (!Live.Has<T>())
		{
			component = default;
			return false;
		}

		component = Live.Read<T>(Index);
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
        if (!Live.Has<T>())
        {
            buffer = default;
            return false;
        }

        buffer = Live.ReadBuffer<T>(Index);
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
		return ref Live.Write<T>(Index);
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
		return Live.WriteBuffer<T>(Index);
	}
}
