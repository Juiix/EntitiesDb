using System;

namespace EntitiesDb;

public sealed class ComponentException(Type componentType, string message) : Exception(message)
{
	public Type ComponentType { get; } = componentType;
}
