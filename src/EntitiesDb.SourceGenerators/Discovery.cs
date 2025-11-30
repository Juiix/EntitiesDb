#nullable enable
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using System.Text;

namespace EntitiesDb.SourceGenerators;

internal static class Discovery
{
	internal static bool IsCandidateNode(SyntaxNode node, System.Threading.CancellationToken _)
	{
		// Quick, cheap syntax filter: ForEach(...)
		var inv = node as InvocationExpressionSyntax;
		if (inv == null) return false;

		var args = inv.ArgumentList;
		if (args.Arguments.Count is < 1 or > 3) return false;

		var ma = inv.Expression as MemberAccessExpressionSyntax;
		if (ma == null) return false;

		var isMatchingMethod = ma.Name.Identifier.ValueText switch
		{
			"ForEach" or "ForEachAlt" or "ForEachParallel" or "ForEachParallelAlt" or "ForEachChunk" or "ForEachChunkParallel" => true,
			_ => false
		};
		return isMatchingMethod;
	}

	internal static InvocationCapture Transform(GeneratorSyntaxContext ctx, System.Threading.CancellationToken _)
	{
		var inv = (InvocationExpressionSyntax)ctx.Node;
		var sm = ctx.SemanticModel;

		if (inv.ArgumentList == null) return InvocationCapture.Invalid;

		var args = inv.ArgumentList.Arguments;
		if (args.Count < 1 || args.Count > 3) return InvocationCapture.Invalid;

		ExpressionSyntax recvExpr = null;
		ExpressionSyntax actExpr = args[0].Expression;
		var expr = inv.Expression;
		var ma = expr as MemberAccessExpressionSyntax;
		string methodName;
		if (ma != null)
		{
			recvExpr = ma.Expression; // query.ForEach(...)
			methodName = ma.Name.Identifier.ValueText;
		}
		else
		{
			var mb = expr as MemberBindingExpressionSyntax;
			if (mb == null) return InvocationCapture.Invalid;
			var ca = inv.Parent as ConditionalAccessExpressionSyntax;
			if (ca == null) return InvocationCapture.Invalid;
			recvExpr = ca.Expression;
			methodName = mb.Name.Identifier.ValueText;
		}

		// Receiver must be EntitiesDb.Query (no need for a valid bound invocation)
		var forEachType = methodName switch
		{
			"ForEach" or "ForEachAlt" => MethodType.ForEach,
			"ForEachParallel" or "ForEachParallelAlt" => MethodType.ForEachParallel,
			"ForEachChunk" => MethodType.ForEachChunk,
			"ForEachChunkParallel" => MethodType.ForEachChunkParallel,
			_ => MethodType.Unknown
		};
		if (forEachType == MethodType.Unknown)
			return InvocationCapture.Invalid;

		var isAlt = methodName.EndsWith("Alt", StringComparison.Ordinal);

		var recvType = sm.GetTypeInfo(recvExpr).Type;
		if (recvType == null) return InvocationCapture.Invalid;
		var recvNs = recvType.ContainingNamespace != null ? recvType.ContainingNamespace.ToDisplayString() : "";
		if (!(recvType.Name == "Query" && string.Equals(recvNs, "EntitiesDb", StringComparison.Ordinal)))
			return InvocationCapture.Invalid;

		// Get callable from the raw argument (works even if overall invocation is invalid)
		if (!TryGetCallable(sm, actExpr, out var methodSym))
			return InvocationCapture.Invalid;

		// Optional: forbid captured state (safe static generation)
		//if (LambdaCaptures(anon)) return InvocationCapture.Invalid;

		var sig = LambdaSignature.From(methodSym);
		var id = SignatureId(sig);
		var lambdaText = actExpr.ToFullString();

		// Optional state arg
		if (args.Count > 1)
		{
			var stateArg = args[1];
			var stateExpr = stateArg.Expression;
			var stateType = sm.GetTypeInfo(stateExpr).Type;
			if (stateType == null) return InvocationCapture.Invalid;

			var isParallel = forEachType is MethodType.ForEachParallel or MethodType.ForEachChunkParallel;
			if (isParallel && stateType is INamedTypeSymbol namedState &&
				string.Equals(namedState.Name, "ParallelOptions", StringComparison.Ordinal) && string.Equals(namedState.ContainingNamespace?.Name, "EntitiesDb", StringComparison.Ordinal))
			{
				// arg is not state, but parallel options
				return InvocationCapture.FromLambda(forEachType, inv, recvType, sig, id, lambdaText, isAlt);
			}

			// check if state is Job aggregate
			var isAggregate = false;
			var stateJobType = stateType;
			if (isParallel && stateType is INamedTypeSymbol namedStateType)
			{
				var interfaces = namedStateType.AllInterfaces;
				foreach (var @interface in interfaces)
				{
					if (@interface.IsGenericType && string.Equals(@interface.Name, "IParallelAggregate") &&
						string.Equals(@interface.ContainingNamespace?.Name, "EntitiesDb"))
					{
						isAggregate = true;
						stateJobType = @interface.TypeArguments[0];
						break;
					}
				}
			}

			id = SignatureId(sig, stateType);
			return InvocationCapture.FromLambdaWithState(forEachType, inv, recvType, sig, id, lambdaText, isAggregate, stateType, stateJobType, stateExpr.ToFullString(), isAlt);
		}
		else
		{
			return InvocationCapture.FromLambda(forEachType, inv, recvType, sig, id, lambdaText, isAlt);
		}
	}

	private static bool TryGetCallable(
		SemanticModel sm,
		SyntaxNode expr,
		out IMethodSymbol? methodSym)
	{
		methodSym = null;

		var op = sm.GetOperation(expr);
		if (op is null) return false;

		op = Unwrap(op);

		switch (op)
		{
			case IAnonymousFunctionOperation a:
				methodSym = a.Symbol;
				return true;

			case IMethodReferenceOperation m:
				var chosen = m.Method;
				methodSym = chosen.ReducedFrom ?? chosen;                // prefer the original (unreduced) extension method
				return true;

			case IInvalidOperation inv:
				// Try to find a lambda inside the invalid operation
				var anon = inv.ChildOperations.OfType<IAnonymousFunctionOperation>().FirstOrDefault();
				if (anon != null)
				{
					methodSym = anon.Symbol;
					return true;
				}
				return false;

			default:
				return false;
		}

		static IOperation Unwrap(IOperation o)
		{
			while (true)
			{
				switch (o)
				{
					case IConversionOperation c:
						o = c.Operand;
						continue;

					case IDelegateCreationOperation d:
						o = d.Target;
						continue;

					case IParenthesizedOperation p:
						o = p.Operand;
						continue;

					case IArgumentOperation a:
						o = a.Value;
						continue;

					// Add more “wrapper” kinds here if you encounter them in the wild:
					// case IDefaultValueOperation dv: o = dv.Value; continue;

					default:
						return o;
				}
			}
		}
	}

	// Minimal capture detector (no C#8/visitor sugar)
	private static bool LambdaCaptures(IAnonymousFunctionOperation lambda)
	{
		var found = false;
		var walker = new CaptureWalker(lambda.Symbol, () => found = true);
		walker.Visit(lambda);
		return found;
	}

	private sealed class CaptureWalker : OperationVisitor
	{
		private readonly IMethodSymbol _lambda;
		private readonly Action _hit;
		internal CaptureWalker(IMethodSymbol lambda, Action hit) { _lambda = lambda; _hit = hit; }

		public override void VisitLocalReference(ILocalReferenceOperation operation)
		{
			// If the local isn't declared inside this lambda and isn't const, it’s a capture
			if (!operation.Local.IsConst && !SymbolEquals(operation.Local.ContainingSymbol, _lambda))
				_hit();
		}

		public override void VisitInstanceReference(IInstanceReferenceOperation operation)
		{
			// Non-static instance access implies capturing 'this'
			if (operation.ReferenceKind == InstanceReferenceKind.ContainingTypeInstance)
				_hit();
		}

		public override void VisitFieldReference(IFieldReferenceOperation operation)
		{
			if (!operation.Member.IsStatic)
				_hit();
			base.VisitFieldReference(operation);
		}

		private static bool SymbolEquals(ISymbol a, ISymbol b)
		{
			return SymbolEqualityComparer.Default.Equals(a, b);
		}
	}

	// --- signature + id ---

	internal static string SignatureId(LambdaSignature s, ITypeSymbol? stateType = null)
	{
		var fmt = SymbolDisplayFormat.FullyQualifiedFormat;
		var sb = new StringBuilder();
		sb.Append(s.Return.ToDisplayString(fmt));
		for (int i = 0; i < s.ParamTypes.Length; i++)
		{
			sb.Append('|').Append((int)s.ParamRefs[i]).Append('|')
			  .Append(s.ParamTypes[i].ToDisplayString(fmt));
		}

		if (stateType != null)
		{
			sb.Append('|').Append(stateType.ToDisplayString(fmt));
		}

		// FNV-1a 32-bit
		unchecked
		{
			uint h = 2166136261;
			var str = sb.ToString();
			for (int i = 0; i < str.Length; i++)
				h = (h ^ str[i]) * 16777619;
			return h.ToString("X8", System.Globalization.CultureInfo.InvariantCulture);
		}
	}
}

internal struct LambdaSignature : IEquatable<LambdaSignature>
{
	public ITypeSymbol Return;
	public ITypeSymbol[] ParamTypes;
	public RefKind[] ParamRefs;

	public static LambdaSignature From(IMethodSymbol m)
	{
		var types = m.Parameters.Select(p => p.Type).ToArray();
		var refs = m.Parameters.Select(p => p.RefKind).ToArray();
		return new LambdaSignature { Return = m.ReturnType, ParamTypes = types, ParamRefs = refs };
	}

	public bool Equals(LambdaSignature other)
	{
		var cmp = SymbolEqualityComparer.Default;
		if (!cmp.Equals(Return, other.Return)) return false;

		if (ParamTypes != null ^ other.ParamTypes != null) return false;
		if (ParamRefs != null ^ other.ParamRefs != null) return false;

		if (ParamTypes != null && other.ParamTypes != null &&
			ParamTypes.Length != other.ParamTypes.Length) return false;
		if (ParamRefs != null && other.ParamRefs != null &&
			ParamRefs.Length != other.ParamRefs.Length) return false;

		if (ParamTypes != null)
		{
			for (int i = 0; i < ParamTypes.Length; i++)
			{
				if (!cmp.Equals(ParamTypes[i], other.ParamTypes[i])) return false;
			}
		}

		if (ParamRefs != null)
		{
			for (int i = 0; i < ParamRefs.Length; i++)
			{
				if (ParamRefs[i] != other.ParamRefs[i]) return false;
			}
		}
		return true;
	}

	public override bool Equals(object obj) => obj is LambdaSignature ls && Equals(ls);

	public override int GetHashCode()
	{
		unchecked
		{
			var cmp = SymbolEqualityComparer.Default;
			int h = 17;
			h = h * 31 + (Return != null ? cmp.GetHashCode(Return) : 0);
			for (int i = 0; i < ParamTypes.Length; i++)
			{
				h = h * 31 + (int)ParamRefs[i];
				var t = ParamTypes[i];
				h = h * 31 + (t != null ? cmp.GetHashCode(t) : 0);
			}
			return h;
		}
	}
}

internal enum MethodType
{
	Unknown,
	ForEach,
	ForEachParallel,
	ForEachChunk,
	ForEachChunkParallel,
}

internal struct InvocationCapture
{
	public static readonly InvocationCapture Invalid = new InvocationCapture();

	public InvocationExpressionSyntax InvocationSyntax;
	public ITypeSymbol ReceiverType;
	public LambdaSignature Signature;
	public string SignatureIdHex;
	public string UniqueName;
	public string LambdaSourceText;
	public MethodType MethodType;

	public bool IsAlt;
	public bool HasState;
	public bool IsAggregate;
	public ITypeSymbol StateType;
	public ITypeSymbol StateJobType;
	public string StateSourceText;

	public bool IsValid { get { return InvocationSyntax != null; } }

	public static InvocationCapture FromLambda(
		MethodType methodType,
		InvocationExpressionSyntax inv,
		ITypeSymbol recv,
		LambdaSignature sig,
		string id,
		string lambdaSrc,
		bool isAlt)
	{
		return new InvocationCapture
		{
			MethodType = methodType,
			InvocationSyntax = inv,
			ReceiverType = recv,
			Signature = sig,
			SignatureIdHex = id,
			UniqueName = $"{methodType}_{id}",
			LambdaSourceText = lambdaSrc,
			IsAlt = isAlt
		};
	}

	public static InvocationCapture FromLambdaWithState(
		MethodType methodType,
		InvocationExpressionSyntax inv,
		ITypeSymbol recv,
		LambdaSignature sigPlusState,
		string id,
		string lambdaSrc,
		bool isAggregate,
		ITypeSymbol stateType,
		ITypeSymbol stateJobType,
		string stateExprText,
		bool isAlt)
	{
		return new InvocationCapture
		{
			MethodType = methodType,
			InvocationSyntax = inv,
			ReceiverType = recv,
			Signature = sigPlusState,
			SignatureIdHex = id,
			UniqueName = $"{methodType}_{id}",
			LambdaSourceText = lambdaSrc,
			HasState = true,
			IsAggregate = isAggregate,
			StateType = stateType,
			StateJobType = stateJobType,
			StateSourceText = stateExprText,
			IsAlt = isAlt
		};
	}
}
