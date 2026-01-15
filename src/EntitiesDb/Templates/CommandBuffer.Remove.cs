
namespace EntitiesDb;

public partial class CommandBuffer
{
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1>();
			RegisterRemove(entityIndex, in signature);
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1, T2>();
			RegisterRemove(entityIndex, in signature);
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1, T2, T3>();
			RegisterRemove(entityIndex, in signature);
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1, T2, T3, T4>();
			RegisterRemove(entityIndex, in signature);
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5>();
			RegisterRemove(entityIndex, in signature);
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6>();
			RegisterRemove(entityIndex, in signature);
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7>();
			RegisterRemove(entityIndex, in signature);
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
			RegisterRemove(entityIndex, in signature);
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
			RegisterRemove(entityIndex, in signature);
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
			RegisterRemove(entityIndex, in signature);
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
			RegisterRemove(entityIndex, in signature);
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
			RegisterRemove(entityIndex, in signature);
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
			RegisterRemove(entityIndex, in signature);
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
			RegisterRemove(entityIndex, in signature);
		}
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity)
	{
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
			RegisterRemove(entityIndex, in signature);
		}
	}
}