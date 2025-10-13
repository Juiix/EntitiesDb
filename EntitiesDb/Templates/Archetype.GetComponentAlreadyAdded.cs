
namespace EntitiesDb;

public partial class Archetype
{
	internal ComponentException GetComponentAlreadyAdded<T0>(int entityId, in Ids<T0> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1>(int entityId, in Ids<T0, T1> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1, T2>(int entityId, in Ids<T0, T1, T2> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
        if (Signature.Test(ids.T2.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T2));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1, T2, T3>(int entityId, in Ids<T0, T1, T2, T3> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
        if (Signature.Test(ids.T2.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T2));
        if (Signature.Test(ids.T3.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T3));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1, T2, T3, T4>(int entityId, in Ids<T0, T1, T2, T3, T4> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
        if (Signature.Test(ids.T2.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T2));
        if (Signature.Test(ids.T3.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T3));
        if (Signature.Test(ids.T4.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T4));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1, T2, T3, T4, T5>(int entityId, in Ids<T0, T1, T2, T3, T4, T5> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
        if (Signature.Test(ids.T2.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T2));
        if (Signature.Test(ids.T3.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T3));
        if (Signature.Test(ids.T4.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T4));
        if (Signature.Test(ids.T5.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T5));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1, T2, T3, T4, T5, T6>(int entityId, in Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
        if (Signature.Test(ids.T2.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T2));
        if (Signature.Test(ids.T3.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T3));
        if (Signature.Test(ids.T4.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T4));
        if (Signature.Test(ids.T5.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T5));
        if (Signature.Test(ids.T6.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T6));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
        if (Signature.Test(ids.T2.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T2));
        if (Signature.Test(ids.T3.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T3));
        if (Signature.Test(ids.T4.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T4));
        if (Signature.Test(ids.T5.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T5));
        if (Signature.Test(ids.T6.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T6));
        if (Signature.Test(ids.T7.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T7));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
        if (Signature.Test(ids.T2.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T2));
        if (Signature.Test(ids.T3.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T3));
        if (Signature.Test(ids.T4.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T4));
        if (Signature.Test(ids.T5.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T5));
        if (Signature.Test(ids.T6.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T6));
        if (Signature.Test(ids.T7.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T7));
        if (Signature.Test(ids.T8.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T8));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
        if (Signature.Test(ids.T2.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T2));
        if (Signature.Test(ids.T3.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T3));
        if (Signature.Test(ids.T4.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T4));
        if (Signature.Test(ids.T5.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T5));
        if (Signature.Test(ids.T6.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T6));
        if (Signature.Test(ids.T7.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T7));
        if (Signature.Test(ids.T8.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T8));
        if (Signature.Test(ids.T9.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T9));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
        if (Signature.Test(ids.T2.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T2));
        if (Signature.Test(ids.T3.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T3));
        if (Signature.Test(ids.T4.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T4));
        if (Signature.Test(ids.T5.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T5));
        if (Signature.Test(ids.T6.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T6));
        if (Signature.Test(ids.T7.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T7));
        if (Signature.Test(ids.T8.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T8));
        if (Signature.Test(ids.T9.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T9));
        if (Signature.Test(ids.T10.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T10));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
        if (Signature.Test(ids.T2.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T2));
        if (Signature.Test(ids.T3.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T3));
        if (Signature.Test(ids.T4.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T4));
        if (Signature.Test(ids.T5.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T5));
        if (Signature.Test(ids.T6.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T6));
        if (Signature.Test(ids.T7.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T7));
        if (Signature.Test(ids.T8.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T8));
        if (Signature.Test(ids.T9.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T9));
        if (Signature.Test(ids.T10.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T10));
        if (Signature.Test(ids.T11.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T11));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
        if (Signature.Test(ids.T2.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T2));
        if (Signature.Test(ids.T3.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T3));
        if (Signature.Test(ids.T4.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T4));
        if (Signature.Test(ids.T5.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T5));
        if (Signature.Test(ids.T6.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T6));
        if (Signature.Test(ids.T7.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T7));
        if (Signature.Test(ids.T8.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T8));
        if (Signature.Test(ids.T9.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T9));
        if (Signature.Test(ids.T10.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T10));
        if (Signature.Test(ids.T11.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T11));
        if (Signature.Test(ids.T12.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T12));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
        if (Signature.Test(ids.T2.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T2));
        if (Signature.Test(ids.T3.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T3));
        if (Signature.Test(ids.T4.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T4));
        if (Signature.Test(ids.T5.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T5));
        if (Signature.Test(ids.T6.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T6));
        if (Signature.Test(ids.T7.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T7));
        if (Signature.Test(ids.T8.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T8));
        if (Signature.Test(ids.T9.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T9));
        if (Signature.Test(ids.T10.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T10));
        if (Signature.Test(ids.T11.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T11));
        if (Signature.Test(ids.T12.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T12));
        if (Signature.Test(ids.T13.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T13));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
        if (Signature.Test(ids.T2.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T2));
        if (Signature.Test(ids.T3.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T3));
        if (Signature.Test(ids.T4.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T4));
        if (Signature.Test(ids.T5.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T5));
        if (Signature.Test(ids.T6.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T6));
        if (Signature.Test(ids.T7.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T7));
        if (Signature.Test(ids.T8.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T8));
        if (Signature.Test(ids.T9.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T9));
        if (Signature.Test(ids.T10.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T10));
        if (Signature.Test(ids.T11.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T11));
        if (Signature.Test(ids.T12.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T12));
        if (Signature.Test(ids.T13.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T13));
        if (Signature.Test(ids.T14.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T14));
		throw new CodeGenerationException();
	}
	internal ComponentException GetComponentAlreadyAdded<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids)
	{
		if (Signature.Test(ids.T0.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T0));
        if (Signature.Test(ids.T1.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T1));
        if (Signature.Test(ids.T2.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T2));
        if (Signature.Test(ids.T3.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T3));
        if (Signature.Test(ids.T4.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T4));
        if (Signature.Test(ids.T5.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T5));
        if (Signature.Test(ids.T6.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T6));
        if (Signature.Test(ids.T7.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T7));
        if (Signature.Test(ids.T8.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T8));
        if (Signature.Test(ids.T9.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T9));
        if (Signature.Test(ids.T10.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T10));
        if (Signature.Test(ids.T11.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T11));
        if (Signature.Test(ids.T12.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T12));
        if (Signature.Test(ids.T13.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T13));
        if (Signature.Test(ids.T14.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T14));
        if (Signature.Test(ids.T15.Value)) return ThrowHelper.ComponentAlreadyAdded(entityId, typeof(T15));
		throw new CodeGenerationException();
	}
}