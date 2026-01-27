using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

internal static class ThrowHelper
{

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertVersion(Entity entity, int version)
	{
		if (entity.Version != version) EntityNotFound(entity.Version);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentBuffered(Type componentType) =>
		new(componentType, $"Component '{componentType.FullName}' is buffered and must be added or removed using buffer methods.");
	[MethodImpl(MethodImplOptions.AggressiveInlining)]

	public static ComponentException ComponentNotBuffered(Type componentType) =>
		new(componentType, $"Component '{componentType.FullName}' is not buffered and cannot be added or removed using buffer methods.");


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentAlreadyAdded(int entityId, Type componentType) =>
		new(componentType, $"Component '{componentType}' has already been added to the entity {entityId}, use Set instead.");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentBufferNotRequired(Type componentType) =>
		new(componentType, $"Component '{componentType.FullName}' is not marked with {nameof(BufferAttribute)} and cannot be wrapped by ComponentBuffer<T> in ForEach delegates.");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentBufferRequired(Type componentType) =>
		new(componentType, $"Component '{componentType.FullName}' is marked with {nameof(BufferAttribute)} must be wrapped by ComponentBuffer<T> in ForEach delegates.");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentNotFound(int entityId, Type componentType) =>
		new(componentType, $"Component {componentType} not found for entity id: {entityId}");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentNotFound(Type componentType) =>
		new(componentType, $"Component {componentType} not found");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentBufferZeroSize(Type componentType) =>
		new(componentType, $"Tag components cannot be used in buffers, invalid component type: {componentType}");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentSizeExceeded(Type componentType, int maxSize) =>
		new(componentType, $"Component '{componentType}' byte size exceeds the max component size of {maxSize:n0}");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentZeroSize(Type componentType) =>
		new(componentType, $"Cannot get a reference to a tag component: {componentType}");


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EntityException EntityNotFound(int entityId) =>
		new(entityId, $"Entity not found for id: {entityId}");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException TrackChangesMissing(Type componentType) =>
		new(componentType, $"Component '{componentType}' is missing the `TrackChanges` attribute.");


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static MaxReachedException MaxComponentsReached(int maxComponents) =>
		new(maxComponents, $"A maximum of {maxComponents} components has been reached.");

	internal static MaxReachedException MaxEntitiesReached(int maxEntities) =>
		new(maxEntities, $"A maximum of {maxEntities} entities has been reached.");
}
