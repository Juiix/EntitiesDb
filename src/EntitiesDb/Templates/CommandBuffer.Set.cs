
namespace EntitiesDb;

public partial class CommandBuffer
{
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1>(Entity entity, in T0? t0Component = default, in T1? t1Component = default)
	{
		var signature = ComponentSingle<T0, T1>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1, T2>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1, T2, T3>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
            SetData(entityIndex, in t6Component);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
            SetData(entityIndex, in t6Component);
            SetData(entityIndex, in t7Component);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
            SetData(entityIndex, in t6Component);
            SetData(entityIndex, in t7Component);
            SetData(entityIndex, in t8Component);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
            SetData(entityIndex, in t6Component);
            SetData(entityIndex, in t7Component);
            SetData(entityIndex, in t8Component);
            SetData(entityIndex, in t9Component);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
            SetData(entityIndex, in t6Component);
            SetData(entityIndex, in t7Component);
            SetData(entityIndex, in t8Component);
            SetData(entityIndex, in t9Component);
            SetData(entityIndex, in t10Component);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
            SetData(entityIndex, in t6Component);
            SetData(entityIndex, in t7Component);
            SetData(entityIndex, in t8Component);
            SetData(entityIndex, in t9Component);
            SetData(entityIndex, in t10Component);
            SetData(entityIndex, in t11Component);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
            SetData(entityIndex, in t6Component);
            SetData(entityIndex, in t7Component);
            SetData(entityIndex, in t8Component);
            SetData(entityIndex, in t9Component);
            SetData(entityIndex, in t10Component);
            SetData(entityIndex, in t11Component);
            SetData(entityIndex, in t12Component);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
            SetData(entityIndex, in t6Component);
            SetData(entityIndex, in t7Component);
            SetData(entityIndex, in t8Component);
            SetData(entityIndex, in t9Component);
            SetData(entityIndex, in t10Component);
            SetData(entityIndex, in t11Component);
            SetData(entityIndex, in t12Component);
            SetData(entityIndex, in t13Component);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
            SetData(entityIndex, in t6Component);
            SetData(entityIndex, in t7Component);
            SetData(entityIndex, in t8Component);
            SetData(entityIndex, in t9Component);
            SetData(entityIndex, in t10Component);
            SetData(entityIndex, in t11Component);
            SetData(entityIndex, in t12Component);
            SetData(entityIndex, in t13Component);
            SetData(entityIndex, in t14Component);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature;
		lock (_lock)
		{
			var entityIndex = Register(entity);
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
            SetData(entityIndex, in t6Component);
            SetData(entityIndex, in t7Component);
            SetData(entityIndex, in t8Component);
            SetData(entityIndex, in t9Component);
            SetData(entityIndex, in t10Component);
            SetData(entityIndex, in t11Component);
            SetData(entityIndex, in t12Component);
            SetData(entityIndex, in t13Component);
            SetData(entityIndex, in t14Component);
            SetData(entityIndex, in t15Component);
		}
	}
}