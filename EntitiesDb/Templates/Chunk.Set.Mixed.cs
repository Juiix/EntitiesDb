
using System;

namespace EntitiesDb;

public partial struct Chunk
{
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1>(int index, in Offsets<T0, T1> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default)
		where T1 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
		GetBuffer<T1>(index, offsets.T1).Set(t1Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2>(int index, in Offsets<T0, T1, T2> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
		GetBuffer<T1>(index, offsets.T1).Set(t1Components);
        GetBuffer<T2>(index, offsets.T2).Set(t2Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3>(int index, in Offsets<T0, T1, T2, T3> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
		GetBuffer<T1>(index, offsets.T1).Set(t1Components);
        GetBuffer<T2>(index, offsets.T2).Set(t2Components);
        GetBuffer<T3>(index, offsets.T3).Set(t3Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in Offsets<T0, T1, T2, T3, T4> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
		GetBuffer<T1>(index, offsets.T1).Set(t1Components);
        GetBuffer<T2>(index, offsets.T2).Set(t2Components);
        GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in Offsets<T0, T1, T2, T3, T4, T5> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
		GetBuffer<T1>(index, offsets.T1).Set(t1Components);
        GetBuffer<T2>(index, offsets.T2).Set(t2Components);
        GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
		GetBuffer<T1>(index, offsets.T1).Set(t1Components);
        GetBuffer<T2>(index, offsets.T2).Set(t2Components);
        GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
		GetBuffer<T1>(index, offsets.T1).Set(t1Components);
        GetBuffer<T2>(index, offsets.T2).Set(t2Components);
        GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
		GetBuffer<T1>(index, offsets.T1).Set(t1Components);
        GetBuffer<T2>(index, offsets.T2).Set(t2Components);
        GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
        GetBuffer<T8>(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
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
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
		GetBuffer<T1>(index, offsets.T1).Set(t1Components);
        GetBuffer<T2>(index, offsets.T2).Set(t2Components);
        GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
        GetBuffer<T8>(index, offsets.T8).Set(t8Components);
        GetBuffer<T9>(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2>(int index, in Offsets<T0, T1, T2> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default)
		where T2 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
		GetBuffer<T2>(index, offsets.T2).Set(t2Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3>(int index, in Offsets<T0, T1, T2, T3> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
		GetBuffer<T2>(index, offsets.T2).Set(t2Components);
        GetBuffer<T3>(index, offsets.T3).Set(t3Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in Offsets<T0, T1, T2, T3, T4> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
		GetBuffer<T2>(index, offsets.T2).Set(t2Components);
        GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in Offsets<T0, T1, T2, T3, T4, T5> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
		GetBuffer<T2>(index, offsets.T2).Set(t2Components);
        GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
		GetBuffer<T2>(index, offsets.T2).Set(t2Components);
        GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
		GetBuffer<T2>(index, offsets.T2).Set(t2Components);
        GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
		GetBuffer<T2>(index, offsets.T2).Set(t2Components);
        GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
        GetBuffer<T8>(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
		GetBuffer<T2>(index, offsets.T2).Set(t2Components);
        GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
        GetBuffer<T8>(index, offsets.T8).Set(t8Components);
        GetBuffer<T9>(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3>(int index, in Offsets<T0, T1, T2, T3> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default)
		where T3 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
		GetBuffer<T3>(index, offsets.T3).Set(t3Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in Offsets<T0, T1, T2, T3, T4> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
		GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in Offsets<T0, T1, T2, T3, T4, T5> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
		GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
		GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
		GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
		GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
        GetBuffer<T8>(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
		GetBuffer<T3>(index, offsets.T3).Set(t3Components);
        GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
        GetBuffer<T8>(index, offsets.T8).Set(t8Components);
        GetBuffer<T9>(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in Offsets<T0, T1, T2, T3, T4> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default)
		where T4 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
		GetBuffer<T4>(index, offsets.T4).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in Offsets<T0, T1, T2, T3, T4, T5> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
		GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
		GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
		GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
		GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
        GetBuffer<T8>(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
		GetBuffer<T4>(index, offsets.T4).Set(t4Components);
        GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
        GetBuffer<T8>(index, offsets.T8).Set(t8Components);
        GetBuffer<T9>(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in Offsets<T0, T1, T2, T3, T4, T5> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default)
		where T5 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
		GetBuffer<T5>(index, offsets.T5).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
		GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
		GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
		GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
        GetBuffer<T8>(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
		GetBuffer<T5>(index, offsets.T5).Set(t5Components);
        GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
        GetBuffer<T8>(index, offsets.T8).Set(t8Components);
        GetBuffer<T9>(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default)
		where T6 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, offsets.T5) = t5Component;
		GetBuffer<T6>(index, offsets.T6).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, offsets.T5) = t5Component;
		GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, offsets.T5) = t5Component;
		GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
        GetBuffer<T8>(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, offsets.T5) = t5Component;
		GetBuffer<T6>(index, offsets.T6).Set(t6Components);
        GetBuffer<T7>(index, offsets.T7).Set(t7Components);
        GetBuffer<T8>(index, offsets.T8).Set(t8Components);
        GetBuffer<T9>(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default)
		where T7 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, offsets.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, offsets.T6) = t6Component;
		GetBuffer<T7>(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, offsets.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, offsets.T6) = t6Component;
		GetBuffer<T7>(index, offsets.T7).Set(t7Components);
        GetBuffer<T8>(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, offsets.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, offsets.T6) = t6Component;
		GetBuffer<T7>(index, offsets.T7).Set(t7Components);
        GetBuffer<T8>(index, offsets.T8).Set(t8Components);
        GetBuffer<T9>(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default)
		where T8 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, offsets.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, offsets.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, offsets.T7) = t7Component;
		GetBuffer<T8>(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, offsets.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, offsets.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, offsets.T7) = t7Component;
		GetBuffer<T8>(index, offsets.T8).Set(t8Components);
        GetBuffer<T9>(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default)
		where T9 : unmanaged
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, offsets.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, offsets.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, offsets.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, offsets.T8) = t8Component;
		GetBuffer<T9>(index, offsets.T9).Set(t9Components);
	}
}