#nullable enable
using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace EntitiesDb.SourceGenerators;

internal static class Utilities
{
	private static readonly SymbolDisplayFormat s_display = new SymbolDisplayFormat(
		globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.Included,
		typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces,
		genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters,
		miscellaneousOptions:
			SymbolDisplayMiscellaneousOptions.UseSpecialTypes |
			SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers);

	internal static string ToDisplay(ITypeSymbol t) { return t.ToDisplayString(s_display); }

	internal static string Sanitize(string name)
	{
		return SyntaxFacts.GetKeywordKind(name) != SyntaxKind.None ? "@" + name : name;
	}

	internal static string JoinSignature(ImmutableArray<IParameterSymbol> parameters)
	{
		var sb = new StringBuilder();
		for (int i = 0; i < parameters.Length; i++)
		{
			if (i > 0) sb.Append(",");
			var p = parameters[i];
			sb.Append(p.RefKind.ToString()).Append(":").Append(ToDisplay(p.Type));
		}
		return sb.ToString();
	}

	internal static string JoinDelegateParameters(List<ParamPart> parts)
	{
		var arr = new string[parts.Count];
		for (int i = 0; i < parts.Count; i++)
		{
			var pp = parts[i];
			var t = ToDisplay(pp.Type);
			var n = Sanitize(pp.Name);

			switch (pp.Kind)
			{
				case ParamKind.Length: arr[i] = t + " " + n; break;
				case ParamKind.Entity: arr[i] = t + " " + n; break;
				case ParamKind.EntityHandle: arr[i] = t + " " + n; break;
				case ParamKind.ComponentRef: arr[i] = "ref " + t + " " + n; break;
				case ParamKind.ComponentIn: arr[i] = "in " + t + " " + n; break;
				case ParamKind.ComponentHandle: arr[i] = t + " " + n; break;
				case ParamKind.ComponentReadOnlyHandle: arr[i] = t + " " + n; break;
				case ParamKind.Buffer: arr[i] = t + " " + n; break;
				case ParamKind.BufferHandle: arr[i] = t + " " + n; break;
				case ParamKind.ReadOnlyBuffer: arr[i] = t + " " + n; break;
				case ParamKind.ReadOnlyBufferHandle: arr[i] = t + " " + n; break;
				case ParamKind.State: arr[i] = "ref " + t + " " + n; break;
			}
		}
		return string.Join(", ", arr);
	}

	internal static uint XxHash32(string s)
	{
		unchecked
		{
			const uint prime2 = 2246822519u;
			const uint prime3 = 3266489917u;
			const uint prime5 = 374761393u;

			uint h = prime5;
			for (int i = 0; i < s.Length; i++)
			{
				h += s[i];
				h *= prime3;
				h = (h << 17) | (h >> 15);
			}
			h += (uint)s.Length;
			h ^= h >> 15; h *= prime2;
			h ^= h >> 13; h *= prime3;
			h ^= h >> 16;
			return h;
		}
	}
}
