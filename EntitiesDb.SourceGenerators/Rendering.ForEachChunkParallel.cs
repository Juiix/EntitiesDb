namespace EntitiesDb.SourceGenerators;

internal static partial class Renderer
{
	private static string RenderForEachChunkParallel(ForEachRenderModel m)
	{
		var w = new IndentedStringBuilder();
		var hasComponents = !string.IsNullOrEmpty(m.IdTypesJoined);
		var hasState = !string.IsNullOrEmpty(m.StateType);
		var jobName = m.ExtensionClassName + "Job";

		if (!string.IsNullOrEmpty(m.Namespace))
		{
			w.AppendLine("namespace " + m.Namespace);
			w.AppendLine("{");
			w.Indent();
		}

		w.AppendLine("using global::System;");
		w.AppendLine("using global::EntitiesDb;");
		w.AppendLine();

		w.AppendLine("internal static partial class " + m.ExtensionClassName);
		w.AppendLine("{");
		w.Indent();

		// Delegate
		w.AppendLine("// Strongly-typed delegate for this callsite");
		w.Append("public delegate void ").Append(m.DelegateName).Append("(")
		 .Append(m.DelegateParameters).AppendLine(");");
		w.AppendLine();

		// Job
		w.AppendLine("private struct " + jobName + " : IChunkJob");
		w.AppendLine("{");
		w.Indent();

		w.AppendLine("private readonly " + m.DelegateName + " _delegate;");
		if (hasComponents)
		{
			w.AppendLine("private readonly Ids" + m.IdTypesJoined + " _ids;");
			w.AppendLine("private Offsets" + m.IdTypesJoined + " _offsets;");
		}
		if (hasState)
		{
			w.AppendLine("private " + m.StateType + " _state;");
		}

		w.Append("public " + jobName + "(" + m.DelegateName + " @delegate");
		if (hasComponents) w.Append(", in Ids" + m.IdTypesJoined + " ids");
		if (hasState) w.Append(", in " + m.StateType + " state");
		w.AppendLine(")");

		w.AppendLine("{");
		w.Indent();

		w.AppendLine("_delegate = @delegate;");
		if (hasComponents)
		{
			w.AppendLine("_ids = ids;");
			w.AppendLine("_offsets = default;");
		}
		if (hasState)
		{
			w.AppendLine("_state = state;");
		}

		w.Unindent();
		w.AppendLine("}"); // constr

		w.AppendLine("public void Enter(Archetype archetype)");
		w.AppendLine("{");
		w.Indent();

		if (hasComponents)
			w.AppendLine("_offsets = archetype.GetOffsets(in _ids);");

		w.Unindent();
		w.AppendLine("}"); // enter archetype

		w.AppendLine("public void ForEach(in Chunk chunk)");
		w.AppendLine("{");
		w.Indent();

		// handles
		foreach (var l in m.HandleLines)
			w.AppendLine(l);

		// delegate call
		w.AppendLine("_delegate(");
		w.Indent();

		w.Append("chunk.EntityCount");
		w.AppendLine(m.CallArguments.Count == 0 ? "" : ",");

		for (int i = 0; i < m.CallArguments.Count; i++)
		{
			var arg = m.CallArguments[i];
			var isLast = i == m.CallArguments.Count - 1;
			w.Append(arg);
			w.AppendLine(isLast ? "" : ",");
		}
		w.Unindent();
		w.AppendLine(");");

		w.Unindent();
		w.AppendLine("}"); // enter archetype

		w.Unindent();
		w.AppendLine("}"); // job

		// Method header
		w.Append("public static void ForEachChunkParallel")
		 .Append("(this ").Append(m.ReceiverType).Append(" self, ")
		 .Append(m.DelegateName).Append(" @delegate");

		// State param
		if (!string.IsNullOrEmpty(m.StateParam))
		{
			w.Append(", ");
			w.Append(m.StateParam);
		}

		w.Append(", global::EntitiesDb.ParallelOptions options = default");

		w.AppendLine(")");

		w.AppendLine("{");
		w.Indent();

		// ComponentMeta assertions
		if (m.BufferedTypes.Count > 0)
		{
			w.Append("global::EntitiesDb.ComponentMeta.AssertBuffered<")
			 .Append(string.Join(", ", m.BufferedTypes.ToArray()))
			 .AppendLine(">();");
		}
		if (m.NotBufferedTypes.Count > 0)
		{
			w.Append("global::EntitiesDb.ComponentMeta.AssertNotBuffered<")
			 .Append(string.Join(", ", m.NotBufferedTypes.ToArray()))
			 .AppendLine(">();");
		}

		// ids
		if (hasComponents)
		{
			w.Append("var ids = self.GetIds").Append(m.IdTypesJoined).AppendLine("();");
			w.AppendLine("var all = Signature.FromIds(in ids);");
		}

		if (hasComponents) w.Append("var job = new " + jobName + "(@delegate, in ids");
		else w.Append("var job = new " + jobName + "(@delegate");
		if (hasState) w.Append(", in state");
		w.AppendLine(");");
		w.AppendLine("self.InlineChunkParallel(in job, options);");

		w.Unindent();
		w.AppendLine("}"); // method

		w.Unindent();
		w.AppendLine("}"); // class

		if (!string.IsNullOrEmpty(m.Namespace))
		{
			w.Unindent();
			w.AppendLine("}"); // namespace
		}

		return w.ToString();
	}
}
