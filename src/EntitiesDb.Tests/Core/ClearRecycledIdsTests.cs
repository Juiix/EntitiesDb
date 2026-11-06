namespace EntitiesDb.Core;

/// <summary>
/// Clear empties the database, so ids start again from 0. Ids recycled by Destroy before the Clear
/// used to survive it: the next Create handed out a pre-Clear id beyond the reset entity count, which
/// lookups by id then treated as missing.
/// </summary>
public sealed class ClearRecycledIdsTests
{
	private record struct Value(int V);

	[Fact]
	public void Create_AfterDestroyAndClear_StartsFromIdZero()
	{
		using var db = new EntityDatabase();
		var a = db.Create(new Value(1));
		var b = db.Create(new Value(2));
		db.Create(new Value(3));
		db.Destroy(b);
		db.Destroy(a);

		db.Clear();

		var first = db.Create(new Value(10));
		var second = db.Create(new Value(20));
		Assert.Equal(0, first.Id);
		Assert.Equal(1, second.Id);
		Assert.True(db.Exists(first.Id));
		Assert.True(db.Exists(second));
		Assert.Equal(10, db.Read<Value>(first).V);
		Assert.Equal(2, db.EntityCount);
	}

	[Fact]
	public void Destroy_AfterClear_RecyclesOnlyNewIds()
	{
		using var db = new EntityDatabase();
		var stale = db.Create(new Value(1));
		db.Create(new Value(2));
		db.Destroy(stale);
		db.Clear();

		var e = db.Create(new Value(3));
		db.Destroy(e);
		var reused = db.Create(new Value(4));

		Assert.Equal(e.Id, reused.Id);
		Assert.True(db.Exists(reused));
		Assert.False(db.Exists(e)); // the destroyed handle's version is stale
		Assert.Equal(4, db.Read<Value>(reused).V);
	}
}
