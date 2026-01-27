namespace EntitiesDb.SourceGenerators;

internal static partial class Renderer
{
	public static string RenderForEach(ForEachRenderModel m)
	{
		var w = new IndentedStringBuilder();
		var hasComponents = !string.IsNullOrEmpty(m.IdTypesJoined);
		var hasState = !string.IsNullOrEmpty(m.StateType);

		if (!string.IsNullOrEmpty(m.Namespace))
		{
			w.AppendLine("namespace " + m.Namespace);
			w.AppendLine("{");
			w.Indent();
		}

		w.AppendLine("using global::System;");
		w.AppendLine("using global::EntitiesDb;");
		w.AppendLine();

		// Delegate
		w.AppendLine("// Strongly-typed delegate for this callsite");
		w.Append("internal delegate void ").Append(m.DelegateName).Append("(")
		 .Append(m.DelegateParameters).AppendLine(");");
		w.AppendLine();

		w.AppendLine("internal static partial class " + m.ExtensionClassName);
		w.AppendLine("{");
		w.Indent();

		// Method header
		w.Append("public static void ForEach")
		 .Append(m.IsAlt ? "Alt" : "")
		 .Append("(this ").Append(m.ReceiverType).Append(" self, ")
		 .Append(m.DelegateName).Append(" @delegate");

		// State param
		if (hasState)
		{
			w.Append(", ref ");
			w.Append(m.StateType);
			w.Append(" state");
		}

		w.AppendLine(")");

		w.AppendLine("{");
		w.Indent();

		// ComponentMeta assertions
		if (m.BufferedTypes.Count > 0)
		{
			w.Append("_ = global::EntitiesDb.ComponentBufferWritable<")
			 .Append(string.Join(", ", m.BufferedTypes.ToArray()))
			 .AppendLine(">.Check;");
		}
		if (m.NotBufferedTypes.Count > 0)
		{
			w.Append("_ = global::EntitiesDb.ComponentSingleWritable<")
			 .Append(string.Join(", ", m.NotBufferedTypes.ToArray()))
			 .AppendLine(">.Check;");
		}

		// main loops
		w.AppendLine("foreach (var archetype in self.EnumerateArchetypes())");
		w.AppendLine("{");
		w.Indent();

		w.AppendLine("foreach (ref readonly var chunk in archetype)");
		w.AppendLine("{");
		w.Indent();

		// handles
		foreach (var l in m.HandleLines)
			w.AppendLine(l);

		w.AppendLine("foreach (var index in chunk)");
		w.AppendLine("{");
		w.Indent();

		// delegate call
		w.AppendLine("@delegate(");
		w.Indent();
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
		w.AppendLine("}"); // foreach index

		w.Unindent();
		w.AppendLine("}"); // foreach chunk

		w.Unindent();
		w.AppendLine("}"); // foreach archetype

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
