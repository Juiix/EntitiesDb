
namespace EntitiesDb;

public partial struct Chunk
{
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1> GetOffsets<T0, T1>(in Ids<T0, T1> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2> GetOffsets<T0, T1, T2>(in Ids<T0, T1, T2> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3> GetOffsets<T0, T1, T2, T3>(in Ids<T0, T1, T2, T3> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4> GetOffsets<T0, T1, T2, T3, T4>(in Ids<T0, T1, T2, T3, T4> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5> GetOffsets<T0, T1, T2, T3, T4, T5>(in Ids<T0, T1, T2, T3, T4, T5> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6> GetOffsets<T0, T1, T2, T3, T4, T5, T6>(in Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value]),
            new Offset<T10>(offsets[ids.T10.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value]),
            new Offset<T10>(offsets[ids.T10.Value]),
            new Offset<T11>(offsets[ids.T11.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value]),
            new Offset<T10>(offsets[ids.T10.Value]),
            new Offset<T11>(offsets[ids.T11.Value]),
            new Offset<T12>(offsets[ids.T12.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value]),
            new Offset<T10>(offsets[ids.T10.Value]),
            new Offset<T11>(offsets[ids.T11.Value]),
            new Offset<T12>(offsets[ids.T12.Value]),
            new Offset<T13>(offsets[ids.T13.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value]),
            new Offset<T10>(offsets[ids.T10.Value]),
            new Offset<T11>(offsets[ids.T11.Value]),
            new Offset<T12>(offsets[ids.T12.Value]),
            new Offset<T13>(offsets[ids.T13.Value]),
            new Offset<T14>(offsets[ids.T14.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value]),
            new Offset<T10>(offsets[ids.T10.Value]),
            new Offset<T11>(offsets[ids.T11.Value]),
            new Offset<T12>(offsets[ids.T12.Value]),
            new Offset<T13>(offsets[ids.T13.Value]),
            new Offset<T14>(offsets[ids.T14.Value]),
            new Offset<T15>(offsets[ids.T15.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value]),
            new Offset<T10>(offsets[ids.T10.Value]),
            new Offset<T11>(offsets[ids.T11.Value]),
            new Offset<T12>(offsets[ids.T12.Value]),
            new Offset<T13>(offsets[ids.T13.Value]),
            new Offset<T14>(offsets[ids.T14.Value]),
            new Offset<T15>(offsets[ids.T15.Value]),
            new Offset<T16>(offsets[ids.T16.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value]),
            new Offset<T10>(offsets[ids.T10.Value]),
            new Offset<T11>(offsets[ids.T11.Value]),
            new Offset<T12>(offsets[ids.T12.Value]),
            new Offset<T13>(offsets[ids.T13.Value]),
            new Offset<T14>(offsets[ids.T14.Value]),
            new Offset<T15>(offsets[ids.T15.Value]),
            new Offset<T16>(offsets[ids.T16.Value]),
            new Offset<T17>(offsets[ids.T17.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value]),
            new Offset<T10>(offsets[ids.T10.Value]),
            new Offset<T11>(offsets[ids.T11.Value]),
            new Offset<T12>(offsets[ids.T12.Value]),
            new Offset<T13>(offsets[ids.T13.Value]),
            new Offset<T14>(offsets[ids.T14.Value]),
            new Offset<T15>(offsets[ids.T15.Value]),
            new Offset<T16>(offsets[ids.T16.Value]),
            new Offset<T17>(offsets[ids.T17.Value]),
            new Offset<T18>(offsets[ids.T18.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value]),
            new Offset<T10>(offsets[ids.T10.Value]),
            new Offset<T11>(offsets[ids.T11.Value]),
            new Offset<T12>(offsets[ids.T12.Value]),
            new Offset<T13>(offsets[ids.T13.Value]),
            new Offset<T14>(offsets[ids.T14.Value]),
            new Offset<T15>(offsets[ids.T15.Value]),
            new Offset<T16>(offsets[ids.T16.Value]),
            new Offset<T17>(offsets[ids.T17.Value]),
            new Offset<T18>(offsets[ids.T18.Value]),
            new Offset<T19>(offsets[ids.T19.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value]),
            new Offset<T10>(offsets[ids.T10.Value]),
            new Offset<T11>(offsets[ids.T11.Value]),
            new Offset<T12>(offsets[ids.T12.Value]),
            new Offset<T13>(offsets[ids.T13.Value]),
            new Offset<T14>(offsets[ids.T14.Value]),
            new Offset<T15>(offsets[ids.T15.Value]),
            new Offset<T16>(offsets[ids.T16.Value]),
            new Offset<T17>(offsets[ids.T17.Value]),
            new Offset<T18>(offsets[ids.T18.Value]),
            new Offset<T19>(offsets[ids.T19.Value]),
            new Offset<T20>(offsets[ids.T20.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value]),
            new Offset<T10>(offsets[ids.T10.Value]),
            new Offset<T11>(offsets[ids.T11.Value]),
            new Offset<T12>(offsets[ids.T12.Value]),
            new Offset<T13>(offsets[ids.T13.Value]),
            new Offset<T14>(offsets[ids.T14.Value]),
            new Offset<T15>(offsets[ids.T15.Value]),
            new Offset<T16>(offsets[ids.T16.Value]),
            new Offset<T17>(offsets[ids.T17.Value]),
            new Offset<T18>(offsets[ids.T18.Value]),
            new Offset<T19>(offsets[ids.T19.Value]),
            new Offset<T20>(offsets[ids.T20.Value]),
            new Offset<T21>(offsets[ids.T21.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value]),
            new Offset<T10>(offsets[ids.T10.Value]),
            new Offset<T11>(offsets[ids.T11.Value]),
            new Offset<T12>(offsets[ids.T12.Value]),
            new Offset<T13>(offsets[ids.T13.Value]),
            new Offset<T14>(offsets[ids.T14.Value]),
            new Offset<T15>(offsets[ids.T15.Value]),
            new Offset<T16>(offsets[ids.T16.Value]),
            new Offset<T17>(offsets[ids.T17.Value]),
            new Offset<T18>(offsets[ids.T18.Value]),
            new Offset<T19>(offsets[ids.T19.Value]),
            new Offset<T20>(offsets[ids.T20.Value]),
            new Offset<T21>(offsets[ids.T21.Value]),
            new Offset<T22>(offsets[ids.T22.Value])
		);
	}
	/// <inheritdoc cref="GetOffsets{T0}(in Ids{T0})"/>
	public readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> GetOffsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> ids)
	{
		var offsets = IdToOffsets;
		return new Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(
			new Offset<T0>(offsets[ids.T0.Value]),
            new Offset<T1>(offsets[ids.T1.Value]),
            new Offset<T2>(offsets[ids.T2.Value]),
            new Offset<T3>(offsets[ids.T3.Value]),
            new Offset<T4>(offsets[ids.T4.Value]),
            new Offset<T5>(offsets[ids.T5.Value]),
            new Offset<T6>(offsets[ids.T6.Value]),
            new Offset<T7>(offsets[ids.T7.Value]),
            new Offset<T8>(offsets[ids.T8.Value]),
            new Offset<T9>(offsets[ids.T9.Value]),
            new Offset<T10>(offsets[ids.T10.Value]),
            new Offset<T11>(offsets[ids.T11.Value]),
            new Offset<T12>(offsets[ids.T12.Value]),
            new Offset<T13>(offsets[ids.T13.Value]),
            new Offset<T14>(offsets[ids.T14.Value]),
            new Offset<T15>(offsets[ids.T15.Value]),
            new Offset<T16>(offsets[ids.T16.Value]),
            new Offset<T17>(offsets[ids.T17.Value]),
            new Offset<T18>(offsets[ids.T18.Value]),
            new Offset<T19>(offsets[ids.T19.Value]),
            new Offset<T20>(offsets[ids.T20.Value]),
            new Offset<T21>(offsets[ids.T21.Value]),
            new Offset<T22>(offsets[ids.T22.Value]),
            new Offset<T23>(offsets[ids.T23.Value])
		);
	}
}