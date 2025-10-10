
namespace EntitiesDb;

public partial struct Chunk
{
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0>(int index, in Ids<T0> ids, in T0? t0Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1>(int index, in Ids<T0, T1> ids, in T0? t0Component = default, in T1? t1Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2>(int index, in Ids<T0, T1, T2> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3>(int index, in Ids<T0, T1, T2, T3> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in Ids<T0, T1, T2, T3, T4> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in Ids<T0, T1, T2, T3, T4, T5> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, ids.T10) = t10Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, ids.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, ids.T11) = t11Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, ids.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, ids.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, ids.T12) = t12Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, ids.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, ids.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, ids.T12) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) Get<T13>(index, ids.T13) = t13Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, ids.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, ids.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, ids.T12) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) Get<T13>(index, ids.T13) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) Get<T14>(index, ids.T14) = t14Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, ids.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, ids.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, ids.T12) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) Get<T13>(index, ids.T13) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) Get<T14>(index, ids.T14) = t14Component;
        if (!ComponentMeta<T15>.IsZeroSize) Get<T15>(index, ids.T15) = t15Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, ids.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, ids.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, ids.T12) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) Get<T13>(index, ids.T13) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) Get<T14>(index, ids.T14) = t14Component;
        if (!ComponentMeta<T15>.IsZeroSize) Get<T15>(index, ids.T15) = t15Component;
        if (!ComponentMeta<T16>.IsZeroSize) Get<T16>(index, ids.T16) = t16Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, ids.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, ids.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, ids.T12) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) Get<T13>(index, ids.T13) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) Get<T14>(index, ids.T14) = t14Component;
        if (!ComponentMeta<T15>.IsZeroSize) Get<T15>(index, ids.T15) = t15Component;
        if (!ComponentMeta<T16>.IsZeroSize) Get<T16>(index, ids.T16) = t16Component;
        if (!ComponentMeta<T17>.IsZeroSize) Get<T17>(index, ids.T17) = t17Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, ids.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, ids.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, ids.T12) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) Get<T13>(index, ids.T13) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) Get<T14>(index, ids.T14) = t14Component;
        if (!ComponentMeta<T15>.IsZeroSize) Get<T15>(index, ids.T15) = t15Component;
        if (!ComponentMeta<T16>.IsZeroSize) Get<T16>(index, ids.T16) = t16Component;
        if (!ComponentMeta<T17>.IsZeroSize) Get<T17>(index, ids.T17) = t17Component;
        if (!ComponentMeta<T18>.IsZeroSize) Get<T18>(index, ids.T18) = t18Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, ids.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, ids.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, ids.T12) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) Get<T13>(index, ids.T13) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) Get<T14>(index, ids.T14) = t14Component;
        if (!ComponentMeta<T15>.IsZeroSize) Get<T15>(index, ids.T15) = t15Component;
        if (!ComponentMeta<T16>.IsZeroSize) Get<T16>(index, ids.T16) = t16Component;
        if (!ComponentMeta<T17>.IsZeroSize) Get<T17>(index, ids.T17) = t17Component;
        if (!ComponentMeta<T18>.IsZeroSize) Get<T18>(index, ids.T18) = t18Component;
        if (!ComponentMeta<T19>.IsZeroSize) Get<T19>(index, ids.T19) = t19Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, ids.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, ids.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, ids.T12) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) Get<T13>(index, ids.T13) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) Get<T14>(index, ids.T14) = t14Component;
        if (!ComponentMeta<T15>.IsZeroSize) Get<T15>(index, ids.T15) = t15Component;
        if (!ComponentMeta<T16>.IsZeroSize) Get<T16>(index, ids.T16) = t16Component;
        if (!ComponentMeta<T17>.IsZeroSize) Get<T17>(index, ids.T17) = t17Component;
        if (!ComponentMeta<T18>.IsZeroSize) Get<T18>(index, ids.T18) = t18Component;
        if (!ComponentMeta<T19>.IsZeroSize) Get<T19>(index, ids.T19) = t19Component;
        if (!ComponentMeta<T20>.IsZeroSize) Get<T20>(index, ids.T20) = t20Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, ids.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, ids.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, ids.T12) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) Get<T13>(index, ids.T13) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) Get<T14>(index, ids.T14) = t14Component;
        if (!ComponentMeta<T15>.IsZeroSize) Get<T15>(index, ids.T15) = t15Component;
        if (!ComponentMeta<T16>.IsZeroSize) Get<T16>(index, ids.T16) = t16Component;
        if (!ComponentMeta<T17>.IsZeroSize) Get<T17>(index, ids.T17) = t17Component;
        if (!ComponentMeta<T18>.IsZeroSize) Get<T18>(index, ids.T18) = t18Component;
        if (!ComponentMeta<T19>.IsZeroSize) Get<T19>(index, ids.T19) = t19Component;
        if (!ComponentMeta<T20>.IsZeroSize) Get<T20>(index, ids.T20) = t20Component;
        if (!ComponentMeta<T21>.IsZeroSize) Get<T21>(index, ids.T21) = t21Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default, in T22? t22Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, ids.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, ids.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, ids.T12) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) Get<T13>(index, ids.T13) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) Get<T14>(index, ids.T14) = t14Component;
        if (!ComponentMeta<T15>.IsZeroSize) Get<T15>(index, ids.T15) = t15Component;
        if (!ComponentMeta<T16>.IsZeroSize) Get<T16>(index, ids.T16) = t16Component;
        if (!ComponentMeta<T17>.IsZeroSize) Get<T17>(index, ids.T17) = t17Component;
        if (!ComponentMeta<T18>.IsZeroSize) Get<T18>(index, ids.T18) = t18Component;
        if (!ComponentMeta<T19>.IsZeroSize) Get<T19>(index, ids.T19) = t19Component;
        if (!ComponentMeta<T20>.IsZeroSize) Get<T20>(index, ids.T20) = t20Component;
        if (!ComponentMeta<T21>.IsZeroSize) Get<T21>(index, ids.T21) = t21Component;
        if (!ComponentMeta<T22>.IsZeroSize) Get<T22>(index, ids.T22) = t22Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Id{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(int index, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> ids, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default, in T16? t16Component = default, in T17? t17Component = default, in T18? t18Component = default, in T19? t19Component = default, in T20? t20Component = default, in T21? t21Component = default, in T22? t22Component = default, in T23? t23Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, ids.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, ids.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, ids.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, ids.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, ids.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, ids.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, ids.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, ids.T7) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) Get<T8>(index, ids.T8) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, ids.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, ids.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, ids.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, ids.T12) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) Get<T13>(index, ids.T13) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) Get<T14>(index, ids.T14) = t14Component;
        if (!ComponentMeta<T15>.IsZeroSize) Get<T15>(index, ids.T15) = t15Component;
        if (!ComponentMeta<T16>.IsZeroSize) Get<T16>(index, ids.T16) = t16Component;
        if (!ComponentMeta<T17>.IsZeroSize) Get<T17>(index, ids.T17) = t17Component;
        if (!ComponentMeta<T18>.IsZeroSize) Get<T18>(index, ids.T18) = t18Component;
        if (!ComponentMeta<T19>.IsZeroSize) Get<T19>(index, ids.T19) = t19Component;
        if (!ComponentMeta<T20>.IsZeroSize) Get<T20>(index, ids.T20) = t20Component;
        if (!ComponentMeta<T21>.IsZeroSize) Get<T21>(index, ids.T21) = t21Component;
        if (!ComponentMeta<T22>.IsZeroSize) Get<T22>(index, ids.T22) = t22Component;
        if (!ComponentMeta<T23>.IsZeroSize) Get<T23>(index, ids.T23) = t23Component;
	}
}