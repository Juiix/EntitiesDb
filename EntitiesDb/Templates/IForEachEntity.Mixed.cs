
using System;

namespace EntitiesDb;

public interface IForEachEntityMixed1<T0, T1>
	where T1 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, DynamicBuffer<T1> t1Components);
}
public interface IForEachEntityMixed1<T0, T1, T2>
	where T1 : unmanaged
    where T2 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, DynamicBuffer<T1> t1Components, DynamicBuffer<T2> t2Components);
}
public interface IForEachEntityMixed1<T0, T1, T2, T3>
	where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, DynamicBuffer<T1> t1Components, DynamicBuffer<T2> t2Components, DynamicBuffer<T3> t3Components);
}
public interface IForEachEntityMixed1<T0, T1, T2, T3, T4>
	where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, DynamicBuffer<T1> t1Components, DynamicBuffer<T2> t2Components, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components);
}
public interface IForEachEntityMixed1<T0, T1, T2, T3, T4, T5>
	where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, DynamicBuffer<T1> t1Components, DynamicBuffer<T2> t2Components, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components);
}
public interface IForEachEntityMixed1<T0, T1, T2, T3, T4, T5, T6>
	where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, DynamicBuffer<T1> t1Components, DynamicBuffer<T2> t2Components, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components);
}
public interface IForEachEntityMixed1<T0, T1, T2, T3, T4, T5, T6, T7>
	where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, DynamicBuffer<T1> t1Components, DynamicBuffer<T2> t2Components, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components);
}
public interface IForEachEntityMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, DynamicBuffer<T1> t1Components, DynamicBuffer<T2> t2Components, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components, DynamicBuffer<T8> t8Components);
}
public interface IForEachEntityMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
	void ForEach(Entity entity, ref T0? t0Component, DynamicBuffer<T1> t1Components, DynamicBuffer<T2> t2Components, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components, DynamicBuffer<T8> t8Components, DynamicBuffer<T9> t9Components);
}
public interface IForEachEntityMixed2<T0, T1, T2>
	where T2 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, DynamicBuffer<T2> t2Components);
}
public interface IForEachEntityMixed2<T0, T1, T2, T3>
	where T2 : unmanaged
    where T3 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, DynamicBuffer<T2> t2Components, DynamicBuffer<T3> t3Components);
}
public interface IForEachEntityMixed2<T0, T1, T2, T3, T4>
	where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, DynamicBuffer<T2> t2Components, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components);
}
public interface IForEachEntityMixed2<T0, T1, T2, T3, T4, T5>
	where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, DynamicBuffer<T2> t2Components, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components);
}
public interface IForEachEntityMixed2<T0, T1, T2, T3, T4, T5, T6>
	where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, DynamicBuffer<T2> t2Components, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components);
}
public interface IForEachEntityMixed2<T0, T1, T2, T3, T4, T5, T6, T7>
	where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, DynamicBuffer<T2> t2Components, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components);
}
public interface IForEachEntityMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, DynamicBuffer<T2> t2Components, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components, DynamicBuffer<T8> t8Components);
}
public interface IForEachEntityMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, DynamicBuffer<T2> t2Components, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components, DynamicBuffer<T8> t8Components, DynamicBuffer<T9> t9Components);
}
public interface IForEachEntityMixed3<T0, T1, T2, T3>
	where T3 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, DynamicBuffer<T3> t3Components);
}
public interface IForEachEntityMixed3<T0, T1, T2, T3, T4>
	where T3 : unmanaged
    where T4 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components);
}
public interface IForEachEntityMixed3<T0, T1, T2, T3, T4, T5>
	where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components);
}
public interface IForEachEntityMixed3<T0, T1, T2, T3, T4, T5, T6>
	where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components);
}
public interface IForEachEntityMixed3<T0, T1, T2, T3, T4, T5, T6, T7>
	where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components);
}
public interface IForEachEntityMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components, DynamicBuffer<T8> t8Components);
}
public interface IForEachEntityMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, DynamicBuffer<T3> t3Components, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components, DynamicBuffer<T8> t8Components, DynamicBuffer<T9> t9Components);
}
public interface IForEachEntityMixed4<T0, T1, T2, T3, T4>
	where T4 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, DynamicBuffer<T4> t4Components);
}
public interface IForEachEntityMixed4<T0, T1, T2, T3, T4, T5>
	where T4 : unmanaged
    where T5 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components);
}
public interface IForEachEntityMixed4<T0, T1, T2, T3, T4, T5, T6>
	where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components);
}
public interface IForEachEntityMixed4<T0, T1, T2, T3, T4, T5, T6, T7>
	where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components);
}
public interface IForEachEntityMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components, DynamicBuffer<T8> t8Components);
}
public interface IForEachEntityMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, DynamicBuffer<T4> t4Components, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components, DynamicBuffer<T8> t8Components, DynamicBuffer<T9> t9Components);
}
public interface IForEachEntityMixed5<T0, T1, T2, T3, T4, T5>
	where T5 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, DynamicBuffer<T5> t5Components);
}
public interface IForEachEntityMixed5<T0, T1, T2, T3, T4, T5, T6>
	where T5 : unmanaged
    where T6 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components);
}
public interface IForEachEntityMixed5<T0, T1, T2, T3, T4, T5, T6, T7>
	where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components);
}
public interface IForEachEntityMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components, DynamicBuffer<T8> t8Components);
}
public interface IForEachEntityMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, DynamicBuffer<T5> t5Components, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components, DynamicBuffer<T8> t8Components, DynamicBuffer<T9> t9Components);
}
public interface IForEachEntityMixed6<T0, T1, T2, T3, T4, T5, T6>
	where T6 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, ref T5? t5Component, DynamicBuffer<T6> t6Components);
}
public interface IForEachEntityMixed6<T0, T1, T2, T3, T4, T5, T6, T7>
	where T6 : unmanaged
    where T7 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, ref T5? t5Component, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components);
}
public interface IForEachEntityMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, ref T5? t5Component, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components, DynamicBuffer<T8> t8Components);
}
public interface IForEachEntityMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, ref T5? t5Component, DynamicBuffer<T6> t6Components, DynamicBuffer<T7> t7Components, DynamicBuffer<T8> t8Components, DynamicBuffer<T9> t9Components);
}
public interface IForEachEntityMixed7<T0, T1, T2, T3, T4, T5, T6, T7>
	where T7 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, ref T5? t5Component, ref T6? t6Component, DynamicBuffer<T7> t7Components);
}
public interface IForEachEntityMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T7 : unmanaged
    where T8 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, ref T5? t5Component, ref T6? t6Component, DynamicBuffer<T7> t7Components, DynamicBuffer<T8> t8Components);
}
public interface IForEachEntityMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, ref T5? t5Component, ref T6? t6Component, DynamicBuffer<T7> t7Components, DynamicBuffer<T8> t8Components, DynamicBuffer<T9> t9Components);
}
public interface IForEachEntityMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	where T8 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, ref T5? t5Component, ref T6? t6Component, ref T7? t7Component, DynamicBuffer<T8> t8Components);
}
public interface IForEachEntityMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T8 : unmanaged
    where T9 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, ref T5? t5Component, ref T6? t6Component, ref T7? t7Component, DynamicBuffer<T8> t8Components, DynamicBuffer<T9> t9Components);
}
public interface IForEachEntityMixed9<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T9 : unmanaged
{
	void ForEach(Entity entity, ref T0? t0Component, ref T1? t1Component, ref T2? t2Component, ref T3? t3Component, ref T4? t4Component, ref T5? t5Component, ref T6? t6Component, ref T7? t7Component, ref T8? t8Component, DynamicBuffer<T9> t9Components);
}
