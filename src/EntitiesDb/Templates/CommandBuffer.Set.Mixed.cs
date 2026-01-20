
using System;

namespace EntitiesDb;

public partial class CommandBuffer
{
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default)
		where T1 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T1, T0>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T1, T2, T0>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T1, T2, T3, T0>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T1, T2, T3, T4, T0>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T1, T2, T3, T4, T5, T0>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T1, T2, T3, T4, T5, T6, T0>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T1, T2, T3, T4, T5, T6, T7, T0>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
			SetData(entityIndex, t1Components);
            SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T1, T2, T3, T4, T5, T6, T7, T8, T0>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T1, T2, T3, T4, T5, T6, T7, T8, T9, T0>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default)
		where T2 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T2, T0, T1>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			SetData(entityIndex, t2Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T2, T3, T0, T1>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T2, T3, T4, T0, T1>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T2, T3, T4, T5, T0, T1>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T2, T3, T4, T5, T6, T0, T1>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T2, T3, T4, T5, T6, T7, T0, T1>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
			SetData(entityIndex, t2Components);
            SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T2, T3, T4, T5, T6, T7, T8, T0, T1>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T2, T3, T4, T5, T6, T7, T8, T9, T0, T1>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default)
		where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T3, T0, T1, T2>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
			SetData(entityIndex, t3Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T3, T4, T0, T1, T2>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
			SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T3, T4, T5, T0, T1, T2>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
			SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T3, T4, T5, T6, T0, T1, T2>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
			SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T3, T4, T5, T6, T7, T0, T1, T2>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
			SetData(entityIndex, t3Components);
            SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T3, T4, T5, T6, T7, T8, T0, T1, T2>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T3, T4, T5, T6, T7, T8, T9, T0, T1, T2>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default)
		where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T4, T0, T1, T2, T3>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
			SetData(entityIndex, t4Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T4, T5, T0, T1, T2, T3>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
			SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T4, T5, T6, T0, T1, T2, T3>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
			SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T4, T5, T6, T7, T0, T1, T2, T3>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
			SetData(entityIndex, t4Components);
            SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T4, T5, T6, T7, T8, T0, T1, T2, T3>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T4, T5, T6, T7, T8, T9, T0, T1, T2, T3>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default)
		where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T5, T0, T1, T2, T3, T4>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
			SetData(entityIndex, t5Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T5, T6, T0, T1, T2, T3, T4>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
			SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T5, T6, T7, T0, T1, T2, T3, T4>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
			SetData(entityIndex, t5Components);
            SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T5, T6, T7, T8, T0, T1, T2, T3, T4>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T5, T6, T7, T8, T9, T0, T1, T2, T3, T4>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default)
		where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T6, T0, T1, T2, T3, T4, T5>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
			SetData(entityIndex, t6Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T6, T7, T0, T1, T2, T3, T4, T5>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
			SetData(entityIndex, t6Components);
            SetData(entityIndex, t7Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T6, T7, T8, T0, T1, T2, T3, T4, T5>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T6, T7, T8, T9, T0, T1, T2, T3, T4, T5>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default)
		where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T7, T0, T1, T2, T3, T4, T5, T6>();
			RegisterSet(entityIndex, in signature);
			SetData(entityIndex, in t0Component);
            SetData(entityIndex, in t1Component);
            SetData(entityIndex, in t2Component);
            SetData(entityIndex, in t3Component);
            SetData(entityIndex, in t4Component);
            SetData(entityIndex, in t5Component);
            SetData(entityIndex, in t6Component);
			SetData(entityIndex, t7Components);
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T7, T8, T0, T1, T2, T3, T4, T5, T6>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T7, T8, T9, T0, T1, T2, T3, T4, T5, T6>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default)
		where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T8, T0, T1, T2, T3, T4, T5, T6, T7>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T8, T9, T0, T1, T2, T3, T4, T5, T6, T7>();
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
		}
	}
	/// <inheritdoc cref="Set{T0}(Entity, in T0?)"/>
	public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default)
		where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9>();
		lock (_lock)
		{
			var entityIndex = Register(entity);
			var signature = _registry.GetSignature<T9, T0, T1, T2, T3, T4, T5, T6, T7, T8>();
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
		}
	}
}