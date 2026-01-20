
using System;

namespace EntitiesDb;

public partial class CommandBuffer
{
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
            SetData(entityIndex, t1Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1, T2>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1, T2>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
            SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1, T2, T3>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1, T2, T3>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
            SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1, T2, T3, T4>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1, T2, T3, T4>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
            SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1, T2, T3, T4, T5>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
            SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
            SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
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
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
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
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T0 : unmanaged
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
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
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
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
            SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
            SetData(entityIndex, t9Components);
            SetData(entityIndex, t10Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
            SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
            SetData(entityIndex, t9Components);
            SetData(entityIndex, t10Components);
            SetData(entityIndex, t11Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
            SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
            SetData(entityIndex, t9Components);
            SetData(entityIndex, t10Components);
            SetData(entityIndex, t11Components);
            SetData(entityIndex, t12Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
            SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
            SetData(entityIndex, t9Components);
            SetData(entityIndex, t10Components);
            SetData(entityIndex, t11Components);
            SetData(entityIndex, t12Components);
            SetData(entityIndex, t13Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
            SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
            SetData(entityIndex, t9Components);
            SetData(entityIndex, t10Components);
            SetData(entityIndex, t11Components);
            SetData(entityIndex, t12Components);
            SetData(entityIndex, t13Components);
            SetData(entityIndex, t14Components);
			return entity;
		}
	}
	/// <inheritdoc cref="Create{T0}(ReadOnlySpan{T0})"/>
	public Entity Create<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ReadOnlySpan<T0> t0Components = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default, ReadOnlySpan<T10> t10Components = default, ReadOnlySpan<T11> t11Components = default, ReadOnlySpan<T12> t12Components = default, ReadOnlySpan<T13> t13Components = default, ReadOnlySpan<T14> t14Components = default, ReadOnlySpan<T15> t15Components = default)
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		ComponentMeta.AssertBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		lock (_lock)
		{
			var entity = new Entity(-_entities.Count - 1, -1);
			var entityIndex = Register(entity);
			_creates.Add(entityIndex);

			var signature = _registry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, t0Components);
            SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
            SetData(entityIndex, t8Components);
            SetData(entityIndex, t9Components);
            SetData(entityIndex, t10Components);
            SetData(entityIndex, t11Components);
            SetData(entityIndex, t12Components);
            SetData(entityIndex, t13Components);
            SetData(entityIndex, t14Components);
            SetData(entityIndex, t15Components);
			return entity;
		}
	}
}