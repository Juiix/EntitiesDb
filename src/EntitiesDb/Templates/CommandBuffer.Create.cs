
namespace EntitiesDb;

public partial class CommandBuffer
{
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1>(in T0? t0Component = default, in T1? t1Component = default)
	{
		var signature = ComponentSingle<T0, T1>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
            SetData(entityIndex, in t6Component);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
            SetData(entityIndex, in t6Component);
            SetData(entityIndex, in t7Component);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

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
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

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
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

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
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

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
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

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
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

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
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

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
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default)
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

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
			return entity;
		}
	}
}