using Microsoft.CodeAnalysis;

namespace EntitiesDb.SourceGenerators;

internal sealed class ForEachRenderModel
{
	public bool Chunks;
	public bool Parallel;
	public bool IsValid;
	public bool IsAlt;
	public string HintName;
	public string Namespace;
	public string ExtensionClassName;
	public string JobName;
	public string AggregateName;
	public string ReceiverType;
	public string DelegateName;
	public string DelegateParameters;
	public string IdTypesJoined;   // e.g., "<Health, Position, Damage, Item>"
	public string StateType;
	public string StateJobType;
	public bool IsAggregate;
	public List<string> HandleLines = new List<string>();
	public List<string> CallArguments = new List<string>();

	// Assertions
	public List<string> BufferedTypes = new List<string>();     // e.g., ["Damage", "Item"]
	public List<string> NotBufferedTypes = new List<string>();  // e.g., ["Health", "Position"]
}

internal static partial class ModelBuilder
{
	public static ForEachRenderModel Build(InvocationCapture cap)
	{
		return BuildModel(cap);
	}

	private static ForEachRenderModel BuildModel(InvocationCapture cap)
	{
		var chunks = cap.MethodType is MethodType.ForEachChunk or MethodType.ForEachChunkParallel;
		var parallel = cap.MethodType is MethodType.ForEachParallel or MethodType.ForEachChunkParallel;

		// --- Receiver ---
		var receiver = cap.ReceiverType;
		if (receiver == null) return Invalid();

		var receiverTypeName = Utilities.ToDisplay(receiver);
		var receiverNs = receiver.ContainingNamespace != null ? receiver.ContainingNamespace.ToDisplayString() : "";
		var receiverShort = receiver.Name;

		// --- Signature from capture ---
		var types = cap.Signature.ParamTypes;
		var refs = cap.Signature.ParamRefs;
		if (types.Length == 0 || refs.Length == 0 || types.Length != refs.Length)
			return Invalid();

		// --- Build ParamParts from (type, ref) ---
		var indexOffset = chunks ? 1 : 0;
		var lengthIndex = indexOffset - 1;
		var entityIndex = indexOffset;
		var parts = new List<ParamPart>(types.Length);
		for (int i = 0; i < types.Length; i++)
		{
			var t = types[i];
			var rk = refs[i];

			// stable param names: prefer "entity" for EntitiesDb.Entity, else p{i}
			string pname;
			var tNs = t.ContainingNamespace != null ? t.ContainingNamespace.ToDisplayString() : "";

			if (i == lengthIndex && t.Name == "Int32" && string.Equals(tNs, "System", StringComparison.Ordinal))
				pname = "length";
			else if (!chunks && i == entityIndex && t.Name == "Entity" && string.Equals(tNs, "EntitiesDb", StringComparison.Ordinal))
				pname = "entity";
			else if (chunks && i == entityIndex && t.Name == "ReadHandle" && string.Equals(tNs, "EntitiesDb", StringComparison.Ordinal) &&
				t is INamedTypeSymbol namedT && namedT.IsGenericType && namedT.TypeArguments.Length == 1 && string.Equals("Entity", namedT.TypeArguments[0].Name, StringComparison.Ordinal) &&
				string.Equals("EntitiesDb", namedT.TypeArguments[0].ContainingNamespace?.ToDisplayString()))
				pname = "entities";
			else
				pname = "p" + i.ToString(System.Globalization.CultureInfo.InvariantCulture);

			var pp = Classifier.Classify(t, rk, pname);
			if (pp == null) return Invalid();
			parts.Add(pp);
		}

		string stateType = null;
		string stateJobType = null;
		if (cap.HasState && parts.Count > 0)
		{
			stateType = Utilities.ToDisplay(cap.StateType);
			stateJobType = Utilities.ToDisplay(cap.StateJobType);
			var part = new ParamPart(ParamKind.State, "state", cap.StateJobType, cap.StateJobType);

			var last = parts[parts.Count - 1];
			var lastRef = refs[parts.Count - 1];
			if (last.Type.Equals(cap.StateJobType, SymbolEqualityComparer.Default) && lastRef == RefKind.Ref)
			{
				parts[parts.Count - 1] = part;
			}
			else
			{
				parts = [.. parts, .. Enumerable.Repeat(part, 1)];
			}
		}

		// --- Partition: optional Entity first, then component/buffer params ---
		var hasEntity = chunks
			? (parts.Count > 1 && parts[1].Kind is ParamKind.EntityHandle)
			: (parts.Count > 0 && parts[0].Kind is ParamKind.Entity);

		var comps = new List<ParamPart>();
		for (int i = 0; i < parts.Count; i++)
			if (parts[i].Kind is not (ParamKind.Entity or ParamKind.EntityHandle or ParamKind.Length or ParamKind.State)) comps.Add(parts[i]);

		// --- Concrete id generic types (component element types) ---
		var idTypes = new List<string>(comps.Count);
		for (int i = 0; i < comps.Count; i++)
		{
			idTypes.Add(Utilities.ToDisplay(comps[i].ComponentType));
		}

		// --- Handles, call args, and assertion buckets ---
		var handleLines = new List<string>();
		var callArgs = new List<string>();
		var bufferedTypes = new List<string>();
		var notBufferedTypes = new List<string>();

		if (hasEntity)
		{
			handleLines.Add("var entityHandle = chunk.EntityHandle();");
			callArgs.Add(chunks ? "entityHandle" : "entityHandle[index]");
		}

		for (int i = 0; i < comps.Count; i++)
		{
			var c = comps[i];
			var baseVar = Utilities.Sanitize(c.Name) + "Handle";
			var displayType = Utilities.ToDisplay(c.ComponentType);

			string h;
			switch (c.Kind)
			{
				case ParamKind.ComponentRef:
				case ParamKind.ComponentWriteHandle:
					h = "var " + baseVar + " = chunk.WriteHandle<" + displayType + ">();"; break;
				case ParamKind.ComponentIn:
				case ParamKind.ComponentReadHandle:
					h = "var " + baseVar + " = chunk.ReadHandle<" + displayType + ">();"; break;
				case ParamKind.WriteBuffer:
				case ParamKind.WriteBufferHandle:
					h = "var " + baseVar + " = chunk.WriteBufferHandle<" + displayType + ">();"; break;
				case ParamKind.ReadBuffer:
				case ParamKind.ReadBufferHandle:
					h = "var " + baseVar + " = chunk.ReadBufferHandle<" + displayType + ">();"; break;
				default:
					h = ""; break;
			}

			handleLines.Add(h);
			if (chunks)
			{
				callArgs.Add(baseVar);
			}
			else
			{
				string arg = c.Kind switch
				{
					ParamKind.ComponentRef => "ref " + baseVar + "[index]",
					ParamKind.ComponentIn => "in " + baseVar + "[index]",
					ParamKind.WriteBuffer or ParamKind.ReadBuffer => baseVar + "[index]",
					_ => "",
				};
				callArgs.Add(arg);
			}

			if (c.Kind is ParamKind.WriteBuffer or ParamKind.ReadBuffer or ParamKind.WriteBufferHandle or ParamKind.ReadBufferHandle)
				bufferedTypes.Add(displayType);
			else
				notBufferedTypes.Add(displayType);
		}

		if (cap.HasState)
		{
			callArgs.Add("ref state");
		}

		// --- IDs / names ---
		var idHex = cap.SignatureIdHex;
		var hint = $"{cap.MethodType}Extensions_" + idHex;

		// Delegate parameter list text (your existing template helper)
		var delParams = Utilities.JoinDelegateParameters(parts);

		return new ForEachRenderModel
		{
			IsValid = true,
			IsAlt = cap.IsAlt,
			HintName = hint,
			Namespace = string.Empty, //receiverNs,
			Chunks = chunks,
			Parallel = parallel,

			// Emit into the SAME extension container to beat generic overloads
			ExtensionClassName = $"{cap.MethodType}Extensions_Gen",
			DelegateName = $"{cap.MethodType}Delegate_" + idHex,
			JobName = $"{cap.MethodType}Job_" + idHex,
			AggregateName = $"{cap.MethodType}JobAggregate_" + idHex,

			ReceiverType = receiverTypeName,
			DelegateParameters = delParams,
			IsAggregate = cap.IsAggregate,
			StateType = stateType,
			StateJobType = stateJobType,
			IdTypesJoined = idTypes.Count == 0 ? "" : "<" + string.Join(", ", idTypes.ToArray()) + ">",

			HandleLines = handleLines,
			CallArguments = callArgs,
			BufferedTypes = bufferedTypes,
			NotBufferedTypes = notBufferedTypes
		};
	}

	private static ForEachRenderModel Invalid()
	{
		var m = new ForEachRenderModel
		{
			IsValid = false,
			HintName = "Invalid_"
		};
		return m;
	}
}
