
namespace EntitiesDb;

public partial struct Chunk
{
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0>(int index, in Offsets<T0> offsets, in T0? t0Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1>(int index, in Offsets<T0, T1> offsets, in T0? t0Component = default, in T1? t1Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2>(int index, in Offsets<T0, T1, T2> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3>(int index, in Offsets<T0, T1, T2, T3> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in Offsets<T0, T1, T2, T3, T4> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in Offsets<T0, T1, T2, T3, T4, T5> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, offsets.T5) = t5Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, offsets.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, offsets.T6) = t6Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Get<T0>(index, offsets.T0) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) Get<T1>(index, offsets.T1) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) Get<T2>(index, offsets.T2) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) Get<T3>(index, offsets.T3) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) Get<T4>(index, offsets.T4) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) Get<T5>(index, offsets.T5) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) Get<T6>(index, offsets.T6) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) Get<T7>(index, offsets.T7) = t7Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default)
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
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default)
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
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, offsets.T9) = t9Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default)
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
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, offsets.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, offsets.T10) = t10Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default)
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
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, offsets.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, offsets.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, offsets.T11) = t11Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default)
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
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, offsets.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, offsets.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, offsets.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, offsets.T12) = t12Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default)
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
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, offsets.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, offsets.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, offsets.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, offsets.T12) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) Get<T13>(index, offsets.T13) = t13Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default)
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
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, offsets.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, offsets.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, offsets.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, offsets.T12) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) Get<T13>(index, offsets.T13) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) Get<T14>(index, offsets.T14) = t14Component;
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default)
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
        if (!ComponentMeta<T9>.IsZeroSize) Get<T9>(index, offsets.T9) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) Get<T10>(index, offsets.T10) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) Get<T11>(index, offsets.T11) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) Get<T12>(index, offsets.T12) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) Get<T13>(index, offsets.T13) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) Get<T14>(index, offsets.T14) = t14Component;
        if (!ComponentMeta<T15>.IsZeroSize) Get<T15>(index, offsets.T15) = t15Component;
	}
}