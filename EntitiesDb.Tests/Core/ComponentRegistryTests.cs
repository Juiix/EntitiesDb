namespace EntitiesDb.Core;

public sealed class ComponentRegistryTests
{
	private delegate ref readonly ComponentType ComponentTypeGetter(ComponentRegistry reg);

	// Handy aliases for distinct unmanaged structs without writing many custom types.
	// ValueTuple<T...> are structs and distinct per-arity/parameter set.
	private static readonly ComponentTypeGetter[] RegisterSome =
	[
		(ComponentRegistry r) => ref r.GetComponentType<int>(),
		(ComponentRegistry r) => ref r.GetComponentType<long>(),
		(ComponentRegistry r) => ref r.GetComponentType<uint>(),
		(ComponentRegistry r) => ref r.GetComponentType<ulong>(),
		(ComponentRegistry r) => ref r.GetComponentType<short>(),
		(ComponentRegistry r) => ref r.GetComponentType<ushort>(),
		(ComponentRegistry r) => ref r.GetComponentType<byte>(),
		(ComponentRegistry r) => ref r.GetComponentType<sbyte>(),
		(ComponentRegistry r) => ref r.GetComponentType<char>(),
		(ComponentRegistry r) => ref r.GetComponentType<float>(),
		(ComponentRegistry r) => ref r.GetComponentType<double>(),
		(ComponentRegistry r) => ref r.GetComponentType<decimal>(),
		(ComponentRegistry r) => ref r.GetComponentType<DateTime>(),
		(ComponentRegistry r) => ref r.GetComponentType<TimeSpan>(),
		(ComponentRegistry r) => ref r.GetComponentType<Guid>(),
		(ComponentRegistry r) => ref r.GetComponentType<(int,int)>(),
		(ComponentRegistry r) => ref r.GetComponentType<(long,int)>(),
		(ComponentRegistry r) => ref r.GetComponentType<(byte,ushort,uint)>(),
		(ComponentRegistry r) => ref r.GetComponentType<(double,double,double)>(),
		(ComponentRegistry r) => ref r.GetComponentType<(int,long,double,byte)>(),
	];

	[Fact]
	public void NewRegistry_IsEmpty()
	{
		var reg = new ComponentRegistry();
		Assert.Equal(0, reg.Count);

		// Get by id when empty -> throws
		Assert.Throws<IndexOutOfRangeException>(() => reg.GetComponentType(0));

		// TryGet by id when empty -> false + don't touch ref
		reg.TryGetComponentType(0, out var found);
		Assert.False(found);
	}

	[Fact]
	public void Register_OneType_AssignsIdZero_AndMapsBack()
	{
		var reg = new ComponentRegistry();

		ref readonly var ct = ref reg.GetComponentType<int>();
		Assert.Equal(1, reg.Count);
		Assert.Equal(0, ct.Id);

		// Same type again: no new id
		ref readonly var ct2 = ref reg.GetComponentType<int>();
		Assert.Equal(1, reg.Count);
		Assert.Equal(ct.Id, ct2.Id);

		// Lookup by id -> same type
		ref readonly var byId = ref reg.GetComponentType(ct.Id);
		Assert.Equal(ct.Id, byId.Id);

		// Type roundtrip
		Assert.Equal(typeof(int), reg.GetType(ct.Id));

		// TryGetType
		Assert.True(reg.TryGetType(ct.Id, out var t));
		Assert.Equal(typeof(int), t);

		// GetArrayFactory returns T[]
		var factory = reg.GetArrayFactory(ct.Id);
		var arr = factory(3);
		Assert.IsType<int[]>(arr);
		Assert.Equal(3, arr.Length);
	}

	[Fact]
	public void Register_ManyTypes_IdOrderMatchesRegistrationOrder()
	{
		var reg = new ComponentRegistry();

		// Register in this exact order
		_ = reg.GetComponentType<int>();            // id 0
		_ = reg.GetComponentType<long>();           // id 1
		_ = reg.GetComponentType<(int, int)>();      // id 2
		_ = reg.GetComponentType<double>();         // id 3

		Assert.Equal(4, reg.Count);

		ref readonly var c0 = ref reg.GetComponentType<int>();
		ref readonly var c1 = ref reg.GetComponentType<long>();
		ref readonly var c2 = ref reg.GetComponentType<(int, int)>();
		ref readonly var c3 = ref reg.GetComponentType<double>();

		Assert.Equal(0, c0.Id);
		Assert.Equal(1, c1.Id);
		Assert.Equal(2, c2.Id);
		Assert.Equal(3, c3.Id);

		// Get type by id
		Assert.Equal(typeof(int), reg.GetType(0));
		Assert.Equal(typeof(long), reg.GetType(1));
		Assert.Equal(typeof((int, int)), reg.GetType(2));
		Assert.Equal(typeof(double), reg.GetType(3));
	}

	[Fact]
	public void GetComponentType_ByInvalidId_Throws_And_TryGetType_ReturnsFalse()
	{
		var reg = new ComponentRegistry();

		_ = reg.GetComponentType<int>();
		Assert.Equal(1, reg.Count);

		// id == Count is out of range
		Assert.Throws<IndexOutOfRangeException>(() => reg.GetComponentType(1));

		Assert.False(reg.TryGetType(-1, out _));
		Assert.False(reg.TryGetType(1, out _));
		
		reg.TryGetComponentType(1, out var found);
		Assert.False(found);
	}

	[Fact]
	public void ComponentType_Invariants_AreConsistent()
	{
		var reg = new ComponentRegistry();

		// A few unmanaged types
		ref readonly var a = ref reg.GetComponentType<byte>();
		ref readonly var b = ref reg.GetComponentType<long>();
		ref readonly var c = ref reg.GetComponentType<(int, int, int)>();
		Assert.True(a.IsUnmanaged);
		Assert.True(b.IsUnmanaged);
		Assert.True(c.IsUnmanaged);

		// Invariants from ComponentType implementation
		Assert.Equal(Math.Abs(a.Stride), a.ByteSize);
		Assert.Equal(Math.Abs(b.Stride), b.ByteSize);
		Assert.Equal(Math.Abs(c.Stride), c.ByteSize);

		Assert.Equal(a.Stride >= 0, a.IsUnmanaged);
		Assert.Equal(b.Stride >= 0, b.IsUnmanaged);
		Assert.Equal(c.Stride >= 0, c.IsUnmanaged);

		// Buffered iff InternalCapacity > 0 (unmanaged-only; managed are set to -1)
		Assert.Equal(a.InternalCapacity > 0, a.Buffered);
		Assert.Equal(b.InternalCapacity > 0, b.Buffered);
		Assert.Equal(c.InternalCapacity > 0, c.Buffered);
	}

	[Fact]
	public void Snapshot_Reads_AreLockFreeAndConsistent_AfterRegistration()
	{
		var reg = new ComponentRegistry();

		// Register a handful of types
		foreach (var act in RegisterSome)
			act(reg);

		var count = reg.Count;
		Assert.True(count >= RegisterSome.Length);

		// Many readers racing on snapshot
		Parallel.For(0, 10_000, i =>
		{
			// Pick a few ids repeatedly
			var idx = (i % count);
			// TryGet by id should be stable (either found or not if idx >= Count right at start)
			if (idx < reg.Count)
			{
				reg.TryGetComponentType(idx, out var found);
				Assert.True(found);
				var typeOk = reg.TryGetType(idx, out var _);
				Assert.True(typeOk);
			}
		});
	}

	[Fact]
	public void Concurrent_FirstTime_Registrations_ProduceUniqueIds()
	{
		var reg = new ComponentRegistry();

		// First, register a couple (to ensure some pre-existing snapshot)
		_ = reg.GetComponentType<int>();
		_ = reg.GetComponentType<long>();

		// Launch parallel first-time registrations for a bunch of distinct types
		var actions = RegisterSome;
		Parallel.ForEach(actions, act => act(reg));

		// Ensure each type maps back to a unique id; also Count equals number of unique types seen
		var pairs = new (Type type, int id)[actions.Length + 2];
		int k = 0;

		// Collect all types we asked for
		pairs[k++] = (typeof(int), reg.GetComponentType<int>().Id);
		pairs[k++] = (typeof(long), reg.GetComponentType<long>().Id);

		// Add the rest
		foreach (var act in actions)
		{
			// recover the specific type from action by invoking and then scanning ids that match
			// simpler: directly re-invoke the same generic call we used in the action array
			ref readonly var type = ref act(reg);
			pairs[k++] = (reg.GetType(type.Id), type.Id);
		}

		// Rebuild the full set of types explicitly and assert uniqueness
		var allTypes =
			new[]
			{
				typeof(int), typeof(long), typeof(uint), typeof(ulong),
				typeof(short), typeof(ushort), typeof(byte), typeof(sbyte),
				typeof(char), typeof(float), typeof(double), typeof(decimal),
				typeof(DateTime), typeof(TimeSpan), typeof(Guid),
				typeof((int,int)), typeof((long,int)), typeof((byte,ushort,uint)),
				typeof((double,double,double)), typeof((int,long,double,byte)),
			};

		foreach (var t in allTypes)
		{
			// use switch to call correct generic (keeps it strongly-typed)
			int id =
				t == typeof(int) ? reg.GetComponentType<int>().Id :
				t == typeof(long) ? reg.GetComponentType<long>().Id :
				t == typeof(uint) ? reg.GetComponentType<uint>().Id :
				t == typeof(ulong) ? reg.GetComponentType<ulong>().Id :
				t == typeof(short) ? reg.GetComponentType<short>().Id :
				t == typeof(ushort) ? reg.GetComponentType<ushort>().Id :
				t == typeof(byte) ? reg.GetComponentType<byte>().Id :
				t == typeof(sbyte) ? reg.GetComponentType<sbyte>().Id :
				t == typeof(char) ? reg.GetComponentType<char>().Id :
				t == typeof(float) ? reg.GetComponentType<float>().Id :
				t == typeof(double) ? reg.GetComponentType<double>().Id :
				t == typeof(decimal) ? reg.GetComponentType<decimal>().Id :
				t == typeof(DateTime) ? reg.GetComponentType<DateTime>().Id :
				t == typeof(TimeSpan) ? reg.GetComponentType<TimeSpan>().Id :
				t == typeof(Guid) ? reg.GetComponentType<Guid>().Id :
				t == typeof((int, int)) ? reg.GetComponentType<(int, int)>().Id :
				t == typeof((long, int)) ? reg.GetComponentType<(long, int)>().Id :
				t == typeof((byte, ushort, uint)) ? reg.GetComponentType<(byte, ushort, uint)>().Id :
				t == typeof((double, double, double)) ? reg.GetComponentType<(double, double, double)>().Id :
				/* else (int,long,double,byte) tuple */ reg.GetComponentType<(int, long, double, byte)>().Id;

			pairs = pairs.Append((t, id)).ToArray();
		}

		// ids unique per type
		var ids = pairs.Select(p => p.id).ToArray();
		Assert.Equal(actions.Length, ids.Distinct().Count());

		// Count >= number of distinct registrations we attempted
		Assert.True(reg.Count >= allTypes.Length);
	}

	[Fact]
	public void GetArrayFactory_CreatesArraysOfCorrectRuntimeType()
	{
		var reg = new ComponentRegistry();

		ref readonly var a = ref reg.GetComponentType<(int, int, int)>();
		ref readonly var b = ref reg.GetComponentType<Guid>();

		var fa = reg.GetArrayFactory(a.Id);
		var fb = reg.GetArrayFactory(b.Id);

		var arrA = fa(5);
		var arrB = fb(2);

		Assert.Equal(5, arrA.Length);
		Assert.Equal(2, arrB.Length);

		Assert.IsType<(int, int, int)[]>(arrA);
		Assert.IsType<Guid[]>(arrB);
	}

	[Fact]
	public void TryGetComponentType_ValidAndInvalid()
	{
		var reg = new ComponentRegistry();
		_ = reg.GetComponentType<uint>(); // id 0

		reg.TryGetComponentType(0, out var ok);
		Assert.True(ok);

		reg.TryGetComponentType(-1, out var bad1);
		reg.TryGetComponentType(5, out var bad2); // out of range
		Assert.False(bad1);
		Assert.False(bad2);
	}
}
