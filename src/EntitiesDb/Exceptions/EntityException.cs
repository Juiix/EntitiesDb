using System;

namespace EntitiesDb;

public sealed class EntityException(int entityId, string message) : Exception(message)
{
	public int EntityId { get; } = entityId;
}
