using System.Runtime.InteropServices;

namespace EntitiesDb.Core;

/// <summary>
/// Large command buffer arrays go back to the shared array pool at Commit / Clear and entity map blocks
/// to a native block pool at Dispose, so the next buffer or database takes them warm. These pin that
/// reused and fresh storage stays correct, and that pooled memory is actually reused and released.
/// </summary>
public sealed class PooledStorageTests
{
	private record struct Value(int V);
	private record struct Other(int V);
	[Buffer(2)] private record struct Item(int V);

	[Fact]
	public void LargeCommandBuffer_Reused_RentsStorageBackAndAppliesEverything()
	{
		using var db = new EntityDatabase();
		var e = new Entity[30_000];
		for (int i = 0; i < e.Length; i++)
			e[i] = db.Create(new Value(0));

		var buffer = db.CreateCommandBuffer(16); // grows past the pooling threshold
		for (int round = 1; round <= 3; round++)
		{
			for (int i = 0; i < e.Length; i++)
				buffer.Set(e[i], new Value(i * round));
			for (int i = 0; i < 1000; i++)
				buffer.AddOrAppend(e[i], new Item(round));
			var created = buffer.Create(new Value(-round));
			buffer.Commit();

			Assert.Equal(29_999 * round, db.Read<Value>(e[29_999]).V);
			Assert.Equal(round, db.ReadBuffer<Item>(e[999]).Length);
			Assert.Equal(round, db.ReadBuffer<Item>(e[0])[round - 1].V);
			Assert.False(db.Has<Item>(e[1000]));
		}
		Assert.Equal(30_003, db.EntityCount);
	}

	[Fact]
	public void OneShotCommandBuffers_InSequence_StayCorrect()
	{
		using var db = new EntityDatabase();
		var e = new Entity[20_000];
		for (int i = 0; i < e.Length; i++)
			e[i] = db.Create(new Value(i));

		for (int round = 0; round < 4; round++)
		{
			var buffer = db.CreateCommandBuffer(e.Length);
			for (int i = round; i < e.Length; i += 2)
				buffer.Add(e[i], new Other(round));
			buffer.Commit();
		}

		Assert.Equal(2, db.Read<Other>(e[2]).V);  // even ids: rounds 0 and 2
		Assert.Equal(3, db.Read<Other>(e[19_999]).V); // odd ids: rounds 1 and 3
		Assert.Equal(19_999, db.Read<Value>(e[19_999]).V);
	}

	[Fact]
	public void SecondOneShotCommandBuffer_TakesOverTheFirstOnesArrays()
	{
		static long CreateBatch(EntityDatabase db)
		{
			var before = GC.GetAllocatedBytesForCurrentThread();
			var buffer = db.CreateCommandBuffer(100_000);
			for (int i = 0; i < 100_000; i++)
				buffer.Create(new Value(i));
			buffer.Commit();
			return GC.GetAllocatedBytesForCurrentThread() - before;
		}

		using var db = new EntityDatabase();
		db.Reserve<Value>(300_000);
		CreateBatch(db); // warms the pool
		var first = CreateBatch(db);
		var second = CreateBatch(db);

		// a fresh buffer allocated ~3.5 MB of storage per batch; pooled, only its small parts are new
		Assert.True(second < 512 * 1024 && first < 512 * 1024, $"allocated {first} then {second} bytes");
		Assert.Equal(300_000, db.EntityCount);
	}

	[Fact]
	public void NativeBlockPool_HandsBackAReturnedBlock_AndReleasesIdleOnes()
	{
		const long Bytes = 1L << 25; // 32 MB: a size class nothing else in the suite uses
		var block = NativeBlockPool.Rent(Bytes);
		NativeBlockPool.Return(block, Bytes);
		Assert.True(NativeBlockPool.IsHolding(Bytes));

		var again = NativeBlockPool.Rent(Bytes);
		Assert.Equal(block, again);
		Assert.False(NativeBlockPool.IsHolding(Bytes));

		// a forced collection must not empty the pool (benchmark harnesses force them between runs) ...
		NativeBlockPool.Return(again, Bytes);
		GC.Collect();
		GC.WaitForPendingFinalizers();
		GC.Collect();
		GC.WaitForPendingFinalizers();
		var memory = GC.GetGCMemoryInfo();
		if (memory.MemoryLoadBytes < memory.HighMemoryLoadThresholdBytes) // short on memory it lets go of everything
			Assert.True(NativeBlockPool.IsHolding(Bytes));

		// ... but a block idle past the limit goes at the next gen2 collection
		var idle = NativeBlockPool.IdleMilliseconds;
		NativeBlockPool.IdleMilliseconds = 0;
		try
		{
			for (int i = 0; i < 4 && NativeBlockPool.IsHolding(Bytes); i++)
			{
				GC.Collect();
				GC.WaitForPendingFinalizers();
			}
			Assert.False(NativeBlockPool.IsHolding(Bytes));
		}
		finally
		{
			NativeBlockPool.IdleMilliseconds = idle;
		}
	}

	[Fact]
	public void NativeBlockPool_OddSizes_AreNotPooled()
	{
		var block = NativeBlockPool.Rent(100_000);
		Marshal.WriteByte(block, 99_999, 7);
		NativeBlockPool.Return(block, 100_000);
		Assert.False(NativeBlockPool.IsHolding(100_000));
	}

	[Fact]
	public void DatabasesBuiltOneAfterAnother_StayIndependent()
	{
		// each database's map block is the previous one's, full of its versions: a new database must
		// still hand out every id at version 0
		for (int round = 0; round < 3; round++)
		{
			using var db = new EntityDatabase();
			var e = new Entity[50_000];
			for (int i = 0; i < e.Length; i++)
				e[i] = db.Create(new Value(i + round));
			Assert.Equal(new Entity(10, 0), e[10]);
			Assert.Equal(new Entity(49_999, 0), e[49_999]);
			Assert.Equal(49_999 + round, db.Read<Value>(49_999).V);
			Assert.False(db.Exists(50_000));

			for (int i = 0; i < e.Length; i += 3)
				db.Destroy(e[i]);
			Assert.Equal(new Entity(0, 1), db.Create(new Value(0)));
		}
	}
}
