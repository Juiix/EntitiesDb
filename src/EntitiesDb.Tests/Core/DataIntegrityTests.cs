using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDb.Core;

public sealed class DataIntegrityTests
{
	// ----------------------------
	// Test components
	// ----------------------------
	[Tag] private readonly struct Tag { }              // zero-size style component (if supported)
	private readonly struct Position
	{
		public readonly int X;
		public readonly int Y;
		public Position(int x, int y) { X = x; Y = y; }
	}

	private struct Health
	{
		public int Value;
		public Health(int v) => Value = v;
	}

	private readonly struct Velocity
	{
		public readonly float X;
		public readonly float Y;
		public Velocity(float x, float y) { X = x; Y = y; }
	}

	// Buffer element type
	[Buffer(8)]
	private readonly struct Waypoint
	{
		public readonly int Id;
		public Waypoint(int id) => Id = id;
	}

	// ----------------------------
	// Helpers
	// ----------------------------
	private static EntityDatabase CreateDb(int maxEntities = 10_000, int chunkByteSize = 16 * 1024, int parallelThreads = 1)
	{
		var options = new EntityDatabaseOptions(chunkByteSize, maxEntities, parallelThreads);
		return new EntityDatabase(options);
	}

	[Fact]
	public void RandomizedOperations_PreserveDataIntegrityAgainstModel()
	{
		using var db = CreateDb(maxEntities: 5000);

		var rng = new Random(12345);

		// Simple model of expected state per live entity-id+version handle
		var live = new List<Entity>();
		var modelPos = new Dictionary<(int id, int ver), Position>();
		var modelHealth = new Dictionary<(int id, int ver), int>();
		var modelBuf = new Dictionary<(int id, int ver), int[]>(); // waypoint ids

		int Steps = 2000;

		for (int step = 0; step < Steps; step++)
		{
			int op = rng.Next(0, 8);

			if (live.Count == 0) op = 0;

			switch (op)
			{
				case 0: // create empty
					{
						var e = db.Create();
						live.Add(e);
						break;
					}
				case 1: // create with Position
					{
						var p = new Position(rng.Next(-1000, 1000), rng.Next(-1000, 1000));
						var e = db.Create(p);
						live.Add(e);
						modelPos[(e.Id, e.Version)] = p;
						break;
					}
				case 2: // add/set Position
					{
						var idx = rng.Next(live.Count);
						var e = live[idx];

						var p = new Position(rng.Next(-1000, 1000), rng.Next(-1000, 1000));
						if (db.Has<Position>(e)) db.Set(e, p);
						else db.Add(e, p);

						modelPos[(e.Id, e.Version)] = p;
						break;
					}
				case 3: // add/set Health
					{
						var idx = rng.Next(live.Count);
						var e = live[idx];

						int v = rng.Next(0, 10000);
						if (db.Has<Health>(e)) db.Set(e, new Health(v));
						else db.Add(e, new Health(v));

						modelHealth[(e.Id, e.Version)] = v;
						break;
					}
				case 4: // add/set buffer
					{
						var idx = rng.Next(live.Count);
						var e = live[idx];

						int len = rng.Next(0, 10);
						var arr = Enumerable.Range(0, len).Select(_ => new Waypoint(rng.Next(0, 1000))).ToArray();

						if (db.Has<Waypoint>(e)) db.Set(e, arr);
						else db.Add(e, arr);

						modelBuf[(e.Id, e.Version)] = arr.Select(w => w.Id).ToArray();
						break;
					}
				case 5: // remove Health
					{
						var idx = rng.Next(live.Count);
						var e = live[idx];

						if (db.Has<Health>(e))
						{
							db.Remove<Health>(e);
							modelHealth.Remove((e.Id, e.Version));
						}
						break;
					}
				case 6: // clone
					{
						var idx = rng.Next(live.Count);
						var src = live[idx];
						var c = db.Clone(src);
						live.Add(c);

						// Copy model state
						if (modelPos.TryGetValue((src.Id, src.Version), out var p))
							modelPos[(c.Id, c.Version)] = p;

						if (modelHealth.TryGetValue((src.Id, src.Version), out var h))
							modelHealth[(c.Id, c.Version)] = h;

						if (modelBuf.TryGetValue((src.Id, src.Version), out var b))
							modelBuf[(c.Id, c.Version)] = b.ToArray();
						break;
					}
				case 7: // destroy
					{
						var idx = rng.Next(live.Count);
						var e = live[idx];

						db.Destroy(e);
						live.RemoveAt(idx);

						modelPos.Remove((e.Id, e.Version));
						modelHealth.Remove((e.Id, e.Version));
						modelBuf.Remove((e.Id, e.Version));
						break;
					}
			}

			// Invariant check every step (cheap but valuable)
			Assert.Equal(live.Count, db.EntityCount);

			// Sample a few live entities each step to validate stored data matches model
			int samples = Math.Min(5, live.Count);
			for (int i = 0; i < samples; i++)
			{
				var e = live[rng.Next(live.Count)];
				Assert.True(db.Exists(e));

				var key = (e.Id, e.Version);

				// Position
				bool hasPos = db.Has<Position>(e);
				Assert.Equal(modelPos.ContainsKey(key), hasPos);
				if (hasPos)
				{
					var p = db.Read<Position>(e);
					var mp = modelPos[key];
					Assert.Equal(mp.X, p!.X);
					Assert.Equal(mp.Y, p.Y);
				}

				// Health
				bool hasHealth = db.Has<Health>(e);
				Assert.Equal(modelHealth.ContainsKey(key), hasHealth);
				if (hasHealth)
				{
					var h = db.Read<Health>(e);
					Assert.Equal(modelHealth[key], h!.Value);
				}

				// Buffer
				bool hasBuf = db.Has<Waypoint>(e);
				Assert.Equal(modelBuf.ContainsKey(key), hasBuf);
				if (hasBuf)
				{
					var buf = db.ReadBuffer<Waypoint>(e).ToArray().Select(x => x.Id).ToArray();
					Assert.Equal(modelBuf[key], buf);
				}
			}
		}
	}
}
