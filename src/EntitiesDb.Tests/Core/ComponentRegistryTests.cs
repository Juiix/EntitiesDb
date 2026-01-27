namespace EntitiesDb.Core;

public sealed class ComponentRegistryTests
{
	private delegate ref readonly ComponentType ComponentTypeGetter();

	// Handy aliases for distinct unmanaged structs without writing many custom types.
	// ValueTuple<T...> are structs and distinct per-arity/parameter set.
	private static readonly ComponentTypeGetter[] RegisterSome =
	[
		() => ref Component<int>.ComponentType,
		() => ref Component<long>.ComponentType,
		() => ref Component<uint>.ComponentType,
		() => ref Component<ulong>.ComponentType,
		() => ref Component<short>.ComponentType,
		() => ref Component<ushort>.ComponentType,
		() => ref Component<byte>.ComponentType,
		() => ref Component<sbyte>.ComponentType,
		() => ref Component<char>.ComponentType,
		() => ref Component<float>.ComponentType,
		() => ref Component<double>.ComponentType,
		() => ref Component<decimal>.ComponentType,
		() => ref Component<DateTime>.ComponentType,
		() => ref Component<TimeSpan>.ComponentType,
		() => ref Component<Guid>.ComponentType,
		() => ref Component<(int,int)>.ComponentType,
		() => ref Component<(long,int)>.ComponentType,
		() => ref Component<(byte,ushort,uint)>.ComponentType,
		() => ref Component<(double,double,double)>.ComponentType,
		() => ref Component<(int,long,double,byte)>.ComponentType,
	];

	[Fact]
	public void NewRegistry_IsEmpty()
	{
		Assert.Equal(0, ComponentRegistry.Count);

		// Get by id when empty -> throws
		Assert.Throws<IndexOutOfRangeException>(() => ComponentRegistry.GetComponentType(0));

		// TryGet by id when empty -> false + don't touch ref
		ComponentRegistry.TryGetComponentType(0, out var found);
		Assert.False(found);
	}

	[Fact]
	public void Register_OneType_AssignsIdZero_AndMapsBack()
	{
		ref readonly var ct = ref Component<int>.ComponentType;
		Assert.Equal(1, ComponentRegistry.Count);
		Assert.Equal(0, ct.Id);

		// Same type again: no new id
		ref readonly var ct2 = ref Component<int>.ComponentType;
		Assert.Equal(1, ComponentRegistry.Count);
		Assert.Equal(ct.Id, ct2.Id);

		// Lookup by id -> same type
		ref readonly var byId = ref ComponentRegistry.GetComponentType(ct.Id);
		Assert.Equal(ct.Id, byId.Id);

		// Type roundtrip
		Assert.Equal(typeof(int), ComponentRegistry.GetType(ct.Id));

		// TryGetType
		Assert.True(ComponentRegistry.TryGetType(ct.Id, out var t));
		Assert.Equal(typeof(int), t);

		// GetArrayFactory returns T[]
		var factory = ComponentRegistry.GetArrayFactory(ct.Id);
		var arr = factory(3);
		Assert.IsType<int[]>(arr);
		Assert.Equal(3, arr.Length);
	}

	[Fact]
	public void Register_ManyTypes_IdOrderMatchesRegistrationOrder()
	{
		// Register in this exact order
		_ = ComponentRegistry.GetComponentType<int>();            // id 0
		_ = ComponentRegistry.GetComponentType<long>();           // id 1
		_ = ComponentRegistry.GetComponentType<(int, int)>();      // id 2
		_ = ComponentRegistry.GetComponentType<double>();         // id 3

		Assert.Equal(4, ComponentRegistry.Count);

		ref readonly var c0 = ref ComponentRegistry.GetComponentType<int>();
		ref readonly var c1 = ref ComponentRegistry.GetComponentType<long>();
		ref readonly var c2 = ref ComponentRegistry.GetComponentType<(int, int)>();
		ref readonly var c3 = ref ComponentRegistry.GetComponentType<double>();

		Assert.Equal(0, c0.Id);
		Assert.Equal(1, c1.Id);
		Assert.Equal(2, c2.Id);
		Assert.Equal(3, c3.Id);

		// Get type by id
		Assert.Equal(typeof(int), ComponentRegistry.GetType(0));
		Assert.Equal(typeof(long), ComponentRegistry.GetType(1));
		Assert.Equal(typeof((int, int)), ComponentRegistry.GetType(2));
		Assert.Equal(typeof(double), ComponentRegistry.GetType(3));
	}

	[Fact]
	public void GetComponentType_ByInvalidId_Throws_And_TryGetType_ReturnsFalse()
	{
		_ = ComponentRegistry.GetComponentType<int>();
		Assert.Equal(1, ComponentRegistry.Count);

		// id == Count is out of range
		Assert.Throws<IndexOutOfRangeException>(() => ComponentRegistry.GetComponentType(1));

		Assert.False(ComponentRegistry.TryGetType(-1, out _));
		Assert.False(ComponentRegistry.TryGetType(1, out _));

		ComponentRegistry.TryGetComponentType(1, out var found);
		Assert.False(found);
	}

	[Fact]
	public void ComponentType_Invariants_AreConsistent()
	{
		// A few unmanaged types
		ref readonly var a = ref ComponentRegistry.GetComponentType<byte>();
		ref readonly var b = ref ComponentRegistry.GetComponentType<long>();
		ref readonly var c = ref ComponentRegistry.GetComponentType<(int, int, int)>();
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
		Assert.Equal(a.InternalCapacity > 0, a.IsBuffer);
		Assert.Equal(b.InternalCapacity > 0, b.IsBuffer);
		Assert.Equal(c.InternalCapacity > 0, c.IsBuffer);
	}

	[Fact]
	public void Snapshot_Reads_AreLockFreeAndConsistent_AfterRegistration()
	{
		// Register a handful of types
		foreach (var act in RegisterSome)
			act();

		var count = ComponentRegistry.Count;
		Assert.True(count >= RegisterSome.Length);

		// Many readers racing on snapshot
		System.Threading.Tasks.Parallel.For(0, 10_000, i =>
		{
			// Pick a few ids repeatedly
			var idx = (i % count);
			// TryGet by id should be stable (either found or not if idx >= Count right at start)
			if (idx < ComponentRegistry.Count)
			{
				ComponentRegistry.TryGetComponentType(idx, out var found);
				Assert.True(found);
				var typeOk = ComponentRegistry.TryGetType(idx, out var _);
				Assert.True(typeOk);
			}
		});
	}

	[Fact]
	public void Concurrent_FirstTime_Registrations_ProduceUniqueIds()
	{
		// First, register a couple (to ensure some pre-existing snapshot)
		_ = ComponentRegistry.GetComponentType<int>();
		_ = ComponentRegistry.GetComponentType<long>();

		// Launch parallel first-time registrations for a bunch of distinct types
		var actions = RegisterSome;
		System.Threading.Tasks.Parallel.ForEach(actions, act => act());

		// Ensure each type maps back to a unique id; also Count equals number of unique types seen
		var pairs = new (Type type, int id)[actions.Length + 2];
		int k = 0;

		// Collect all types we asked for
		pairs[k++] = (typeof(int), ComponentRegistry.GetComponentType<int>().Id);
		pairs[k++] = (typeof(long), ComponentRegistry.GetComponentType<long>().Id);

		// Add the rest
		foreach (var act in actions)
		{
			// recover the specific type from action by invoking and then scanning ids that match
			// simpler: directly re-invoke the same generic call we used in the action array
			ref readonly var type = ref act();
			pairs[k++] = (ComponentRegistry.GetType(type.Id), type.Id);
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
				t == typeof(int) ? ComponentRegistry.GetComponentType<int>().Id :
				t == typeof(long) ? ComponentRegistry.GetComponentType<long>().Id :
				t == typeof(uint) ? ComponentRegistry.GetComponentType<uint>().Id :
				t == typeof(ulong) ? ComponentRegistry.GetComponentType<ulong>().Id :
				t == typeof(short) ? ComponentRegistry.GetComponentType<short>().Id :
				t == typeof(ushort) ? ComponentRegistry.GetComponentType<ushort>().Id :
				t == typeof(byte) ? ComponentRegistry.GetComponentType<byte>().Id :
				t == typeof(sbyte) ? ComponentRegistry.GetComponentType<sbyte>().Id :
				t == typeof(char) ? ComponentRegistry.GetComponentType<char>().Id :
				t == typeof(float) ? ComponentRegistry.GetComponentType<float>().Id :
				t == typeof(double) ? ComponentRegistry.GetComponentType<double>().Id :
				t == typeof(decimal) ? ComponentRegistry.GetComponentType<decimal>().Id :
				t == typeof(DateTime) ? ComponentRegistry.GetComponentType<DateTime>().Id :
				t == typeof(TimeSpan) ? ComponentRegistry.GetComponentType<TimeSpan>().Id :
				t == typeof(Guid) ? ComponentRegistry.GetComponentType<Guid>().Id :
				t == typeof((int, int)) ? ComponentRegistry.GetComponentType<(int, int)>().Id :
				t == typeof((long, int)) ? ComponentRegistry.GetComponentType<(long, int)>().Id :
				t == typeof((byte, ushort, uint)) ? ComponentRegistry.GetComponentType<(byte, ushort, uint)>().Id :
				t == typeof((double, double, double)) ? ComponentRegistry.GetComponentType<(double, double, double)>().Id :
				/* else (int,long,double,byte) tuple */ ComponentRegistry.GetComponentType<(int, long, double, byte)>().Id;

			pairs = pairs.Append((t, id)).ToArray();
		}

		// ids unique per type
		var ids = pairs.Select(p => p.id).ToArray();
		Assert.Equal(actions.Length, ids.Distinct().Count());

		// Count >= number of distinct registrations we attempted
		Assert.True(ComponentRegistry.Count >= allTypes.Length);
	}

	[Fact]
	public void GetArrayFactory_CreatesArraysOfCorrectRuntimeType()
	{
		ref readonly var a = ref ComponentRegistry.GetComponentType<(int, int, int)>();
		ref readonly var b = ref ComponentRegistry.GetComponentType<Guid>();

		var fa = ComponentRegistry.GetArrayFactory(a.Id);
		var fb = ComponentRegistry.GetArrayFactory(b.Id);

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
		_ = ComponentRegistry.GetComponentType<uint>(); // id 0

		ComponentRegistry.TryGetComponentType(0, out var ok);
		Assert.True(ok);

		ComponentRegistry.TryGetComponentType(-1, out var bad1);
		ComponentRegistry.TryGetComponentType(5, out var bad2); // out of range
		Assert.False(bad1);
		Assert.False(bad2);
	}
}
