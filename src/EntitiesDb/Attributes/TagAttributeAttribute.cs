using System;

namespace EntitiesDb;

/// <summary>
/// Marks a component as a zero-size tag component
/// </summary>
[AttributeUsage(AttributeTargets.Struct)]
internal sealed class TagAttribute : Attribute
{
}
