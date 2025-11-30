#nullable enable
using Microsoft.CodeAnalysis;
using System.Diagnostics;

namespace EntitiesDb.SourceGenerators;

internal enum ParamKind
{
	Entity,
	EntityHandle,
	ComponentRef,
	ComponentWriteHandle,
	ComponentIn,
	ComponentReadHandle,
	WriteBuffer,
	WriteBufferHandle,
	ReadBuffer,
	ReadBufferHandle,
	State,
	Length
}

internal sealed class ParamPart
{
	public ParamKind Kind;
	public string Name;
	public ITypeSymbol Type;
	public ITypeSymbol ComponentType; // for buffers, else same as Type

	public ParamPart(ParamKind kind, string name, ITypeSymbol type, ITypeSymbol componentType)
	{
		Kind = kind; Name = name; Type = type; ComponentType = componentType;
	}
}

internal static class Classifier
{
	internal static ParamPart Classify(ITypeSymbol type, RefKind rk, string paramName)
	{
		var ns = type.ContainingNamespace != null ? type.ContainingNamespace.ToDisplayString() : "";

		// Length
		if (rk == RefKind.None && type.Name == "Int32" && string.Equals(ns, "System", StringComparison.Ordinal))
			return new ParamPart(ParamKind.Length, paramName, type, type);

		// Entity
		if (type.Name == "Entity" && string.Equals(ns, "EntitiesDb", StringComparison.Ordinal))
			return new ParamPart(ParamKind.Entity, paramName, type, type);

		// Buffer<T>-like?  Prefer project helpers if you have them.
		INamedTypeSymbol named = type as INamedTypeSymbol;
		if (named != null && named.IsGenericType && string.Equals(named.Name, "WriteBuffer", StringComparison.Ordinal) && string.Equals(ns, "EntitiesDb", StringComparison.Ordinal))
		{
			var elem = named.TypeArguments.Length == 1 ? named.TypeArguments[0] : type;
			return new ParamPart(ParamKind.WriteBuffer, paramName, type, elem);
		}

		if (named != null && named.IsGenericType && string.Equals(named.Name, "ReadBuffer", StringComparison.Ordinal) && string.Equals(ns, "EntitiesDb", StringComparison.Ordinal))
		{
			var elem = named.TypeArguments.Length == 1 ? named.TypeArguments[0] : type;
			return new ParamPart(ParamKind.ReadBuffer, paramName, type, elem);
		}


		if (named != null && named.IsGenericType && string.Equals(named.Name, "WriteHandle", StringComparison.Ordinal) && string.Equals(ns, "EntitiesDb", StringComparison.Ordinal))
		{
			var elem = named.TypeArguments.Length == 1 ? named.TypeArguments[0] : type;
			return new ParamPart(ParamKind.ComponentWriteHandle, paramName, type, elem);
		}

		if (named != null && named.IsGenericType && string.Equals(named.Name, "ReadHandle", StringComparison.Ordinal) && string.Equals(ns, "EntitiesDb", StringComparison.Ordinal))
		{
			var elem = named.TypeArguments.Length == 1 ? named.TypeArguments[0] : type;
			var ens = elem.ContainingNamespace != null ? elem.ContainingNamespace.ToDisplayString() : "";
			INamedTypeSymbol elemNamed = elem as INamedTypeSymbol;
			if (elemNamed != null && string.Equals(elemNamed.Name, "Entity", StringComparison.Ordinal) && string.Equals(ens, "EntitiesDb", StringComparison.Ordinal))
				return new ParamPart(ParamKind.EntityHandle, paramName, type, elem);
			else
				return new ParamPart(ParamKind.ComponentReadHandle, paramName, type, elem);
		}

		if (named != null && named.IsGenericType && string.Equals(named.Name, "WriteBufferHandle", StringComparison.Ordinal) && string.Equals(ns, "EntitiesDb", StringComparison.Ordinal))
		{
			var elem = named.TypeArguments.Length == 1 ? named.TypeArguments[0] : type;
			return new ParamPart(ParamKind.WriteBufferHandle, paramName, type, elem);
		}

		if (named != null && named.IsGenericType && string.Equals(named.Name, "ReadBufferHandle", StringComparison.Ordinal) && string.Equals(ns, "EntitiesDb", StringComparison.Ordinal))
		{
			var elem = named.TypeArguments.Length == 1 ? named.TypeArguments[0] : type;
			return new ParamPart(ParamKind.ReadBufferHandle, paramName, type, elem);
		}

		// If you have marker interfaces/attributes, check them here, e.g.:
		// if (Utilities.IsBufferType(type)) { var elem = Utilities.GetBufferElementType(type); ... }

		// Components
		if (rk == RefKind.Ref)
			return new ParamPart(ParamKind.ComponentRef, paramName, type, type);

		// Treat by-value as read-only component (ComponentIn) to match your handle usage
		return new ParamPart(ParamKind.ComponentIn, paramName, type, type);
	}
}
