namespace EntitiesDb.Core;

/// <summary>
/// Moving an entity to an archetype without one of its managed components must keep every
/// remaining managed component paired with its own array. Chunk.CopyComponents used to advance
/// the source array index only for components present in the destination, so a dropped managed
/// component shifted every later one onto its neighbour's array (ArrayTypeMismatchException).
/// </summary>
public sealed class ManagedComponentMoveTests
{
	private record struct OwnerName(string Value);
	private record struct Session(string Token, int Id);
	private record struct KilledBy(string Name, int Type);
	private record struct Plain(int Value);

	[Fact]
	public void Remove_ManagedComponentBeforeOthers_KeepsRemainingManagedComponents()
	{
		using var db = new EntityDatabase();
		var e = db.Create(new OwnerName("owner"), new Session("token", 7), new KilledBy("boss", 3), new Plain(42));

		db.Remove(e, Component<OwnerName>.Signature);

		Assert.False(db.Has<OwnerName>(e));
		Assert.Equal(new Session("token", 7), db.Read<Session>(e));
		Assert.Equal(new KilledBy("boss", 3), db.Read<KilledBy>(e));
		Assert.Equal(42, db.Read<Plain>(e).Value);
	}

	[Fact]
	public void Remove_SeveralManagedComponents_KeepsTheRest()
	{
		using var db = new EntityDatabase();
		var e = db.Create(new OwnerName("owner"), new Session("token", 7), new KilledBy("boss", 3), new Plain(42));

		db.Remove(e, Component<OwnerName, Session>.Signature);

		Assert.False(db.Has<OwnerName>(e));
		Assert.False(db.Has<Session>(e));
		Assert.Equal(new KilledBy("boss", 3), db.Read<KilledBy>(e));
		Assert.Equal(42, db.Read<Plain>(e).Value);
	}

	[Fact]
	public void AddAndRemove_DropsManagedComponent_KeepsTheRest()
	{
		using var db = new EntityDatabase();
		var e = db.Create(new OwnerName("owner"), new Session("token", 7), new Plain(42));

		db.AddAndRemove(e, new KilledBy("boss", 3), Component<OwnerName>.Signature);

		Assert.False(db.Has<OwnerName>(e));
		Assert.Equal(new Session("token", 7), db.Read<Session>(e));
		Assert.Equal(new KilledBy("boss", 3), db.Read<KilledBy>(e));
		Assert.Equal(42, db.Read<Plain>(e).Value);
	}
}
