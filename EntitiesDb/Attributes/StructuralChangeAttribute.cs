using System;

namespace EntitiesDb;

/// <summary>
/// Methods with this attribute cause a structural change to the <see cref="EntityDatabase"/>
/// </summary>
/// <remarks>
/// Queries may break and references may be invalidated.
/// </remarks>
[AttributeUsage(AttributeTargets.Method)]
public sealed class StructuralChangeAttribute : Attribute
{
}
