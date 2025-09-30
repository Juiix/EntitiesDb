using System;

namespace EntitiesDb
{
	public sealed class EntityException : Exception
	{
		public EntityException(uint entityId, string message) : base(message)
		{
			EntityId = entityId;
		}

		public uint EntityId { get; }
	}
}
