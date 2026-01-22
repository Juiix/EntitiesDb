using System;

namespace EntitiesDb;

[Flags]
public enum ComponentFlags : byte
{
	None = 0,
	Unmanaged = 1,
	Buffer = 2,
	Tag = 4
}
