namespace EntitiesDb;

/// <summary>
/// One entity a <see cref="CommandBuffer"/> has commands for
/// </summary>
internal struct BufferedEntity(Entity entity, int setIndex, int removeIndex, BufferedEntityKind kind)
{
	/// <summary>
	/// The target entity; a buffered create's placeholder until <see cref="CommandBuffer.Commit"/> creates it
	/// </summary>
	public Entity Entity = entity;

	/// <summary>
	/// Index of the pending set signature, -1 if none. Signatures are shared between entities and never
	/// changed in place.
	/// </summary>
	public int SetIndex = setIndex;

	/// <summary>
	/// Index of the pending remove signature, -1 if none. Shared like <see cref="SetIndex"/>.
	/// </summary>
	public int RemoveIndex = removeIndex;

	public readonly BufferedEntityKind Kind = kind;
}

internal enum BufferedEntityKind : byte
{
	/// <summary>
	/// A placeholder this buffer did not hand out: its commands fail at Commit
	/// </summary>
	Unknown,

	/// <summary>
	/// An entity that existed when buffered (registered in the id map)
	/// </summary>
	Existing,

	/// <summary>
	/// A buffered create
	/// </summary>
	Create,
}
