namespace EntitiesDb.SourceGenerators;

internal static partial class Renderer
{
    private static void RenderAggregate(ForEachRenderModel m, IndentedStringBuilder w)
    {
        w.AppendLine("private struct " + m.AggregateName + " : IParallelAggregate<" + m.JobName + ">");
        w.AppendLine("{");
        w.Indent();

        // fields
        w.AppendLine("private readonly " + m.DelegateName + " _delegate;");
        w.AppendLine("public DangerousRef<" + m.StateType + "> state;");

        // constructor
        w.AppendLine("public " + m.AggregateName + "(" + m.DelegateName + " @delegate, ref " + m.StateType + " state)");
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

        w.AppendLine("return new " + m.JobName + "(_delegate, state.Value.Create(threadIndex));");

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
}
