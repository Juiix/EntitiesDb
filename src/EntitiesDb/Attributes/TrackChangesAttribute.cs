using System;

namespace EntitiesDb;

/// <summary>
/// Enables change filter tracking for this component
/// </summary>
[AttributeUsage(AttributeTargets.Struct)]
public sealed class TrackChangesAttribute() : Attribute
{

}