using BenchmarkDotNet.Running;
using EntitiesDb;
using Sandbox;
using System.Diagnostics;
using System.Runtime.Intrinsics;

int entityCount = 100000;
using var entities = new EntityDatabase(new(16384, int.MaxValue, Environment.ProcessorCount));
entities.Reserve<Component1>(entityCount);

var bulk = entities.GetBulkCreate<Component1, Component2>();
for (int i = 0; i < entityCount; ++i)
{
	entities.Create(in bulk, new Component1(), new Component2(1));
}

var query = entities.QueryBuilder
	.WithAll<Component1, Component2>()
	.Build();

var ids = entities.ComponentRegistry.GetIds<Component1, Component2>();
for (int it = 0; it < 100000; it++)
{
	var add = new AddParallel(ids);
	query.InlineChunkJobParallel(in add);
}

internal struct AddParallel(Ids<Component1, Component2> ids) : IChunkJob
{
	private readonly Ids<Component1, Component2> _ids = ids;
	private Offsets<Component1, Component2> _offsets;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var length = chunk.EntityCount;
		var alignedLength = length - (length & 7);
		var handleA = chunk.GetHandle(_offsets.T0);
		var handleB = chunk.GetHandle(_offsets.T1);
		var simdHandleA = handleA.Reinterpret<Component1, Vector256<int>>();
		var simdHandleB = handleB.Reinterpret<Component2, Vector256<int>>();
		var simdLength = alignedLength / 8;
		for (int i = 0; i < simdLength; i++)
		{
			simdHandleA[i] += simdHandleB[i];
		}

		for (int i = alignedLength; i < length; i++)
		{
			handleA[i].Value += handleB[i].Value;
		}
	}
}

internal record struct Component1(int Value);
internal record struct Component2(int Value);
internal record struct Component3(int Value);