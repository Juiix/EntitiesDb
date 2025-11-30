using System;

namespace EntitiesDb;

public sealed class MaxReachedException(int max, string message) : Exception(message)
{
	public int Max { get; } = max;
}
