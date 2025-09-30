using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

internal static class ThrowHelper
{
	public static void ThrowComponentBuffered(Type componentType) =>
		throw new ComponentException(componentType, $"Component '{componentType.FullName}' is buffered and must be added or removed using buffer methods.");
	public static void ThrowComponentNotBuffered(Type componentType) =>
		throw new ComponentException(componentType, $"Component '{componentType.FullName}' is not buffered and cannot be added or removed using buffer methods.");


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ThrowComponentAlreadyAdded(Type componentType) =>
		throw new ComponentException(componentType, $"Component '{componentType}' has already been added to the entity, use Set instead.");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ThrowComponentBufferNotRequired(Type componentType) =>
		throw new ComponentException(componentType, $"Component '{componentType.FullName}' is not marked with Buffered attribute and cannot be wrapped by ComponentBuffer<T> in ForEach delegates.");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ThrowComponentBufferRequired(Type componentType) =>
		throw new ComponentException(componentType, $"Component '{componentType.FullName}' is marked with Buffered attribute must be wrapped by ComponentBuffer<T> in ForEach delegates.");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ThrowComponentNotFound(uint entityId, Type componentType) =>
		throw new ComponentException(componentType, $"Component {componentType} not found for entity id: {entityId}");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ThrowComponentBufferZeroSize(Type componentType) =>
		throw new ComponentException(componentType, $"Zero-size components cannot be used in buffers, invalid component type: {componentType}");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ThrowComponentSizeExceeded(Type componentType, int maxSize) =>
		throw new ComponentException(componentType, $"Component '{componentType}' byte size exceeds the max component size of {maxSize:n0}");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ThrowEntityNotFound(uint entityId) =>
		throw new EntityException(entityId, $"Entity not found for id: {entityId}");

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void ThrowMaxComponentsReached(int maxComponents) =>
		throw new MaxReachedException(maxComponents, $"A maximum of {maxComponents} components has been reached.");
	internal static void ThrowMaxEntitiesReached(int maxEntities) =>
		throw new MaxReachedException(maxEntities, $"A maximum of {maxEntities} entities has been reached.");
}
