using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

internal static class ThrowHelper
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentBuffered(Type componentType) =>
		new(componentType, $"Component '{componentType.FullName}' is buffered and must be added or removed using buffer methods.");
	[MethodImpl(MethodImplOptions.AggressiveInlining)]

	public static ComponentException ComponentNotBuffered(Type componentType) =>
		new(componentType, $"Component '{componentType.FullName}' is not buffered and cannot be added or removed using buffer methods.");


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentAlreadyAdded(Type componentType) =>
		new(componentType, $"Component '{componentType}' has already been added to the entity, use Set instead.");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentBufferNotRequired(Type componentType) =>
		new(componentType, $"Component '{componentType.FullName}' is not marked with Buffered attribute and cannot be wrapped by ComponentBuffer<T> in ForEach delegates.");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentBufferRequired(Type componentType) =>
		new(componentType, $"Component '{componentType.FullName}' is marked with Buffered attribute must be wrapped by ComponentBuffer<T> in ForEach delegates.");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentNotFound(int entityId, Type componentType) =>
		new(componentType, $"Component {componentType} not found for entity id: {entityId}");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentBufferZeroSize(Type componentType) =>
		new(componentType, $"Zero-size components cannot be used in buffers, invalid component type: {componentType}");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentException ComponentSizeExceeded(Type componentType, int maxSize) =>
		new(componentType, $"Component '{componentType}' byte size exceeds the max component size of {maxSize:n0}");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EntityException EntityNotFound(int entityId) =>
		new(entityId, $"Entity not found for id: {entityId}");


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static MaxReachedException MaxComponentsReached(int maxComponents) =>
		new(maxComponents, $"A maximum of {maxComponents} components has been reached.");

	internal static MaxReachedException MaxEntitiesReached(int maxEntities) =>
		new(maxEntities, $"A maximum of {maxEntities} entities has been reached.");
}
