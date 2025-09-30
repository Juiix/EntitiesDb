using System;

namespace EntitiesDb
{
	public sealed class ComponentException : Exception
	{
		public ComponentException(Type componentType, string message) : base(message)
		{
			ComponentType = componentType;
		}

		public Type ComponentType { get; }
	}
}
