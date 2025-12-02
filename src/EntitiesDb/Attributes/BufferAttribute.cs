using System;

namespace EntitiesDb;

/// <summary>
/// Marks a component as bufferable with an internal capacity.
/// </summary>
/// <param name="internalCapacity">The amount of components stored internally before allocating heap memory.</param>
[AttributeUsage(AttributeTargets.Struct)]
public sealed class BufferAttribute(short internalCapacity) : Attribute
{
	/// <summary>
	/// The amount of components stored internally before allocating heap memory.
	/// </summary>
	public short InternalCapacity { get; } = internalCapacity;
}
