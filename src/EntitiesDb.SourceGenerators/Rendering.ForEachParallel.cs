namespace EntitiesDb.SourceGenerators;

internal static partial class Renderer
{
	public static string RenderForEachParallel(ForEachRenderModel m)
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

		// Extension Class
		w.AppendLine("internal static partial class " + m.ExtensionClassName);
		w.AppendLine("{");
		w.Indent();

		// Aggregate
		if (m.IsAggregate)
		{
			w.AppendLine("private struct " + m.AggregateName + " : IParallelAggregate<" + m.JobName + ">");
			w.AppendLine("{");
			w.Indent();

			// fields
			w.AppendLine("private readonly " + m.DelegateName + " _delegate;");
			w.AppendLine("public DangerousRef<" + m.StateType + "> state;");

			// constructor
			w.Append("public " + m.AggregateName + "(" + m.DelegateName + " @delegate");
			w.Append(", ref " + m.StateType + " state");
			w.AppendLine(")");
			w.AppendLine("{");
			w.Indent();

			w.AppendLine("_delegate = @delegate;");
			w.AppendLine("this.state = new DangerousRef<" + m.StateType + ">(ref state);");

			w.Unindent();
			w.AppendLine("}"); // constructor

			// create
			w.AppendLine("public " + m.JobName + " Create(int threadIndex)");
			w.AppendLine("{");
			w.Indent();

			w.Append("return new " + m.JobName + "(_delegate");
			if (hasComponents) w.Append(", _ids");
			w.AppendLine(", state.Value.Create(threadIndex));");

			w.Unindent();
			w.AppendLine("}"); // create

			// join
			w.AppendLine("public void Join(int threadIndex, ref " + m.JobName + " job)");
			w.AppendLine("{");
			w.Indent();

			w.AppendLine("state.Value.Join(threadIndex, ref job.state);");

			w.Unindent();
			w.AppendLine("}"); // join

			w.Unindent();
			w.AppendLine("}"); // Aggregate
		}

		// Job
		w.AppendLine("private struct " + m.JobName + " : IChunkJob");
		w.AppendLine("{");
		w.Indent();

		w.AppendLine("private readonly " + m.DelegateName + " _delegate;");
		if (hasState)
		{
			w.AppendLine("public " + m.StateJobType + " state;");
		}

		w.Append("public " + m.JobName + "(" + m.DelegateName + " @delegate");
		if (hasState) w.Append(", in " + m.StateJobType + " state");
		w.AppendLine(")");

		w.AppendLine("{");
		w.Indent();

		w.AppendLine("_delegate = @delegate;");
		if (hasState)
		{
			w.AppendLine("this.state = state;");
		}

		w.Unindent();
		w.AppendLine("}"); // constr

		// foreach chunk
		w.AppendLine("public void ForEach(in Chunk chunk)");
		w.AppendLine("{");
		w.Indent();

		// handles
		foreach (var l in m.HandleLines)
			w.AppendLine(l);

		w.AppendLine("foreach (var index in chunk)");
		w.AppendLine("{");
		w.Indent();

		// delegate call
		w.AppendLine("_delegate(");
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
		w.AppendLine("}"); // Job

		// Method header
		w.Append("public static void ForEachParallel")
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

		w.Append(", global::EntitiesDb.ParallelOptions options = default");

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

		if (m.IsAggregate)
		{
			w.Append("var job = new " + m.AggregateName + "(@delegate");
			if (hasState) w.Append(", ref state");
			w.AppendLine(");");
			w.AppendLine("self.ChunkJobParallel<" + m.JobName + ", " + m.AggregateName + ">(ref job, options);");
		}
		else
		{
			w.Append("var job = new " + m.JobName + "(@delegate");
			if (hasState) w.Append(", in state");
			w.AppendLine(");");
			w.AppendLine("self.ChunkJobParallel(in job, options);");
		}

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
