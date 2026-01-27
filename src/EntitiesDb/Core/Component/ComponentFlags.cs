using System;

namespace EntitiesDb;

/// <summary>
/// Flags for a component type
/// </summary>
[Flags]
public enum ComponentFlags : byte
{
	None = 0,

	/// <summary>
	/// If changes should be tracked
	/// </summary>
	TrackChanges = 1
}
