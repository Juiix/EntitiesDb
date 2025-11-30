using System;

namespace EntitiesDb;

/// <summary>
/// When present on a method, the underlying chunk will be flagged as changed and appear in <see cref="ChangeFilter"/> queries
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class ChunkChangeAttribute : Attribute
{

}
