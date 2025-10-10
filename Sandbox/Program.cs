using BenchmarkDotNet.Running;
using EntitiesDb;
using Sandbox;
using System.Runtime.Intrinsics;

int entityCount = 100000;
using var entities = new EntityDatabase(16384, int.MaxValue);
entities.Reserve<Component1>(entityCount);

var bulk = entities.GetBulkCreate<Component1>();
for (int i = 0; i < entityCount; ++i)
{
	entities.Create(in bulk, new Component1());
}

var query = entities.QueryBuilder
	.WithAll<Component1>()
	.Build();

for (int it = 0; it < 100000; it++)
{
	Vector256<int> sum = Vector256.Create(1);
	var ids = entities.ComponentRegistry.GetIds<Component1>();
	foreach (var archetype in query.GetArchetypeIterator())
	{
		var offsets = archetype.GetOffsets(in ids);
		foreach (ref readonly var chunk in archetype)
		{
			var ec = chunk.EntityCount;
			var alignedLength = ec - (ec & 7);
			var handle = chunk.GetHandle<Component1>(offsets.T0);
			var simdHandle = handle.Reinterpret<Vector256<int>>();
			var simdLength = alignedLength / 8;
			for (int i = 0; i < simdLength; i++)
			{
				simdHandle[i] += sum;
			}

			for (int i = alignedLength; i < ec; i++)
			{
				handle[i].Value++;
			}
		}
	}
}

internal struct Component1
{
	public int Value;
}

internal struct Component2
{
	public int Value;
}

internal struct Component3
{
	public int Value;
}