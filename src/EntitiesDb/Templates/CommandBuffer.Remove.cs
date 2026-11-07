
namespace EntitiesDb;

public partial class CommandBuffer
{
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1>(Entity entity)
	{
		var signature = Component<T0, T1>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2>(Entity entity)
	{
		var signature = Component<T0, T1, T2>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3>(Entity entity)
	{
		var signature = Component<T0, T1, T2, T3>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4>(Entity entity)
	{
		var signature = Component<T0, T1, T2, T3, T4>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5>(Entity entity)
	{
		var signature = Component<T0, T1, T2, T3, T4, T5>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6>(Entity entity)
	{
		var signature = Component<T0, T1, T2, T3, T4, T5, T6>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity)
	{
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity)
	{
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity)
	{
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity)
	{
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity)
	{
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity)
	{
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity)
	{
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity)
	{
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity)
	{
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature;
		Enter();
		try
		{
			var entityIndex = Register(entity);
			RegisterRemove(entityIndex, in signature);
		}
		finally
		{
			Exit();
		}
	}
}