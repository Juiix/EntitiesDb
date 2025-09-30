using System;

namespace EntitiesDb;

[AttributeUsage(AttributeTargets.Struct)]
internal sealed class ZeroSizeAttribute : Attribute
{
}
