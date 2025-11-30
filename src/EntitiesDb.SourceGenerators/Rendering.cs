// Rendering.cs
#nullable enable
using System.Text;

namespace EntitiesDb.SourceGenerators;

internal static partial class Renderer
{
	public static string Render(ForEachRenderModel m)
	{
		return (m.Chunks, m.Parallel) switch
		{
			(true, false) => RenderForEachChunk(m),
			(true, true) => RenderForEachChunkParallel(m),
			(false, true) => RenderForEachParallel(m),
			_ => RenderForEach(m)
		};
	}
}

// Minimal indentation-aware builder
internal sealed class IndentedStringBuilder
{
	private readonly StringBuilder _sb = new StringBuilder(2048);
	private int _indent;
	private int _currentIndentCount;

	public IndentedStringBuilder Indent() { _indent++; return this; }
	public IndentedStringBuilder Unindent() { if (_indent > 0) _indent--; return this; }

	public IndentedStringBuilder Append(string s)
	{
		AppendIndent();
		_sb.Append(s);
		return this;
	}
	public IndentedStringBuilder AppendLine()
	{
		AppendIndent();
		_sb.AppendLine();
		_currentIndentCount = 0;
		return this;
	}
	public IndentedStringBuilder AppendLine(string s)
	{
		AppendIndent();
		if (s.Length == 0)
			_sb.AppendLine();
		else
			_sb.AppendLine(s);
		_currentIndentCount = 0;
		return this;
	}

	public override string ToString() { return _sb.ToString(); }

	private void AppendIndent()
	{
		while (_currentIndentCount < _indent)
		{
			_sb.Append(' ', 4);
			_currentIndentCount++;
		}
	}
}
