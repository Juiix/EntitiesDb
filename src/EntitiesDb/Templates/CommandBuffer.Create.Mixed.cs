
using System;

namespace EntitiesDb;

public partial class CommandBuffer
{
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default)
		where T1 : unmanaged
	{
		var signature = ComponentSingle<T0>.Signature | ComponentBuffer<T1>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1>(in T0? t0Component, T1[] t1Components)
		where T1 : unmanaged
	{
		return Create(in t0Component, t1Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		var signature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2>(in T0? t0Component, T1[] t1Components, T2[] t2Components)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		return Create(in t0Component, t1Components.AsSpan(), t2Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var signature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3>(in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		return Create(in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var signature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		return Create(in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var signature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4, T5>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		return Create(in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var signature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4, T5, T6>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		return Create(in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var signature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4, T5, T6, T7>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		return Create(in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var signature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		return Create(in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentSingle<T0>.Signature | ComponentBuffer<T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
            SetData(entityIndex, t9Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component, T1[] t1Components, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		return Create(in t0Component, t1Components.AsSpan(), t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default)
		where T2 : unmanaged
	{
		var signature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			SetData(entityIndex, t2Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2>(in T0? t0Component, in T1? t1Component, T2[] t2Components)
		where T2 : unmanaged
	{
		return Create(in t0Component, in t1Component, t2Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		var signature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3>(in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		return Create(in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var signature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		return Create(in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var signature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		return Create(in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var signature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5, T6>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		return Create(in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var signature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5, T6, T7>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		return Create(in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var signature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5, T6, T7, T8>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		return Create(in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentSingle<T0, T1>.Signature | ComponentBuffer<T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
            SetData(entityIndex, t9Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component, in T1? t1Component, T2[] t2Components, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		return Create(in t0Component, in t1Component, t2Components.AsSpan(), t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default)
		where T3 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
			SetData(entityIndex, t3Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3>(in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components)
		where T3 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, t3Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
			SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
			SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5, T6>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
			SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5, T6, T7>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
			SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5, T6, T7, T8>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
			SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2>.Signature | ComponentBuffer<T3, T4, T5, T6, T7, T8, T9>.Signature;
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
			SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
            SetData(entityIndex, t9Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component, in T1? t1Component, in T2? t2Component, T3[] t3Components, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, t3Components.AsSpan(), t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default)
		where T4 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4>.Signature;
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
			SetData(entityIndex, t4Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components)
		where T4 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5>.Signature;
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
			SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6>.Signature;
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
			SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6, T7>.Signature;
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
			SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6, T7, T8>.Signature;
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
			SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3>.Signature | ComponentBuffer<T4, T5, T6, T7, T8, T9>.Signature;
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
			SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
            SetData(entityIndex, t9Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, T4[] t4Components, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, t4Components.AsSpan(), t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default)
		where T5 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5>.Signature;
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
			SetData(entityIndex, t5Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components)
		where T5 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6>.Signature;
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
			SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6, T7>.Signature;
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
			SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components, T7[] t7Components)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6, T7, T8>.Signature;
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
			SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4>.Signature | ComponentBuffer<T5, T6, T7, T8, T9>.Signature;
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
			SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
            SetData(entityIndex, t9Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, T5[] t5Components, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components.AsSpan(), t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default)
		where T6 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6>.Signature;
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
			SetData(entityIndex, t6Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components)
		where T6 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6, T7>.Signature;
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
			SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components, T7[] t7Components)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan(), t7Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6, T7, T8>.Signature;
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
			SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components, T7[] t7Components, T8[] t8Components)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature | ComponentBuffer<T6, T7, T8, T9>.Signature;
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
			SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
            SetData(entityIndex, t9Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, T6[] t6Components, T7[] t7Components, T8[] t8Components, T9[] t9Components)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components.AsSpan(), t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default)
		where T7 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature | ComponentBuffer<T7>.Signature;
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
			SetData(entityIndex, t7Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, T7[] t7Components)
		where T7 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature | ComponentBuffer<T7, T8>.Signature;
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
			SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, T7[] t7Components, T8[] t8Components)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components.AsSpan(), t8Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature | ComponentBuffer<T7, T8, T9>.Signature;
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
			SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
            SetData(entityIndex, t9Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, T7[] t7Components, T8[] t8Components, T9[] t9Components)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components.AsSpan(), t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default)
		where T8 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature | ComponentBuffer<T8>.Signature;
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
			SetData(entityIndex, t8Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, T8[] t8Components)
		where T8 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, t8Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature | ComponentBuffer<T8, T9>.Signature;
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
			SetData(entityIndex, t8Components);
            SetData(entityIndex, t9Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, T8[] t8Components, T9[] t9Components)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, t8Components.AsSpan(), t9Components.AsSpan());
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default)
		where T9 : unmanaged
	{
		var signature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature | ComponentBuffer<T9>.Signature;
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
			SetData(entityIndex, t9Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(in T0)"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, T9[] t9Components)
		where T9 : unmanaged
	{
		return Create(in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, t9Components.AsSpan());
	}
}