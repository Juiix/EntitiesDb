
using System;

namespace EntitiesDb;

public partial class CommandBuffer
{
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default)
		where T1 : unmanaged
	{
		Set(entity, in t0Component, t1Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		Set(entity, in t0Component, t1Components, t2Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		Set(entity, in t0Component, t1Components, t2Components, t3Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		Set(entity, in t0Component, t1Components, t2Components, t3Components, t4Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		Set(entity, in t0Component, t1Components, t2Components, t3Components, t4Components, t5Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		Set(entity, in t0Component, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Set(entity, in t0Component, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Set(entity, in t0Component, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		Set(entity, in t0Component, t1Components, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default)
		where T2 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, t2Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, t2Components, t3Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, t2Components, t3Components, t4Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, t2Components, t3Components, t4Components, t5Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, t2Components, t3Components, t4Components, t5Components, t6Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, t2Components, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default)
		where T3 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, t3Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, t3Components, t4Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, t3Components, t4Components, t5Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, t3Components, t4Components, t5Components, t6Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, t3Components, t4Components, t5Components, t6Components, t7Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, t3Components, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default)
		where T4 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components, t5Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components, t5Components, t6Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components, t5Components, t6Components, t7Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components, t5Components, t6Components, t7Components, t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, t4Components, t5Components, t6Components, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default)
		where T5 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components, t6Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components, t6Components, t7Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components, t6Components, t7Components, t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, t5Components, t6Components, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default)
		where T6 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components, t7Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components, t7Components, t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, t6Components, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default)
		where T7 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components, t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, t7Components, t8Components, t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default)
		where T8 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, t8Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, t8Components, t9Components);
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default)
		where T9 : unmanaged
	{
		Set(entity, in t0Component, in t1Component, in t2Component, in t3Component, in t4Component, in t5Component, in t6Component, in t7Component, in t8Component, t9Components);
	}
}