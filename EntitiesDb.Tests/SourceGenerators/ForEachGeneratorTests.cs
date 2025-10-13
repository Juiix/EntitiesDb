// ForEachGeneratorTests.cs (xUnit)
using System;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Xunit;

namespace EntitiesDb.SourceGenerators;

public class ForEachGeneratorTests
{
	private static readonly CSharpParseOptions ParseOptions =
		new CSharpParseOptions(languageVersion: LanguageVersion.CSharp12); // or Preview

	[Fact]
	public void Generates_ForEach_Overload_and_Delegate()
	{
		// 1) Provide minimal stubs for your ECS types + the callsite under test
		var sources = new[]
		{
			EntitiesDbStubs,  // Query, Entity, buffers, etc.
            @"
using EntitiesDb;

public static class TestHost
{
    public static void Run()
    {
        var q = new Query(default(object)); // pass anything
        q.ForEach((Entity e, ref Health h, in Position p, DynamicBuffer<Damage> d, ReadOnlyBuffer<Item> items) =>
        {
            // noop
        });

        q.ForEach((ref Health h) =>
        {
            // noop
        });
    }
}
"
		};

		// 2) Create a Roslyn compilation
		var compilation = CreateCompilation(sources);

		// 3) Run your generator
		var generator = new EntitiesDb.SourceGenerators.ForEachGenerator();
		CSharpGeneratorDriver.Create(
			generators: new ISourceGenerator[] { generator.AsSourceGenerator() },
			additionalTexts: null,
			parseOptions: ParseOptions)
			.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var diagnostics);

		Assert.Empty(diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error));

		// 4) Inspect results
		var runResult = CSharpGeneratorDriver.Create(generator)
			.RunGenerators(compilation)
			.GetRunResult();

		// Ensure at least one file was emitted
		Assert.True(runResult.GeneratedTrees.Length > 0);

		// Find our file & check important snippets
		var text = string.Join("\n\n---\n\n", runResult.Results.SelectMany(r => r.GeneratedSources).Select(g => g.SourceText.ToString()));

		Assert.Contains("delegate void ForEachDelegate_", text);
		Assert.Contains("public static void ForEach<", text);                // generic overload
		Assert.Contains("ComponentMeta.AssertBuffered<", text);              // your new assertion
		Assert.Contains("ComponentMeta.AssertNotBuffered<", text);
		Assert.Contains("GetBufferHandle(", text);                           // buffer param mapped
		Assert.Contains("GetBufferHandleReadOnly(", text);
		Assert.Contains("GetHandleReadOnly(", text);
		Assert.Contains("GetHandle(", text);
	}

	// ------- Helpers --------

	private static Compilation CreateCompilation(string[] sources)
	{
		var trees = sources.Select(s => CSharpSyntaxTree.ParseText(s,
			new CSharpParseOptions(LanguageVersion.CSharp12))).ToArray();

		// Basic references
		var refs = new[]
		{
			MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
			MetadataReference.CreateFromFile(typeof(Enumerable).Assembly.Location),
			MetadataReference.CreateFromFile(typeof(System.Runtime.CompilerServices.IsUnmanagedAttribute).Assembly.Location)
		};

		return CSharpCompilation.Create("Tests",
			syntaxTrees: trees,
			references: refs,
			options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
	}

	private const string EntitiesDbStubs = @"
using System;
using System.Collections;
using System.Collections.Generic;

namespace EntitiesDb
{
    public readonly struct Entity { public readonly int Id; public Entity(int id){ Id=id;} }

    public struct Health { }
    public struct Position { }
    public struct Damage  { }
    public struct Item    { }

    // Buffer shells
    public readonly struct DynamicBuffer<T> where T : unmanaged { }
    public readonly struct ReadOnlyBuffer<T> where T : unmanaged { }

    // Meta assertions
    public static class ComponentMeta
    {
        public static void AssertBuffered<T1>() {}
        public static void AssertBuffered<T1,T2>() {}
        public static void AssertBuffered<T1,T2,T3>() {}
        public static void AssertBuffered<T1,T2,T3,T4>() {}
        public static void AssertNotBuffered<T1>() {}
        public static void AssertNotBuffered<T1,T2>() {}
        public static void AssertNotBuffered<T1,T2,T3>() {}
        public static void AssertNotBuffered<T1,T2,T3,T4>() {}
    }

    // Fake chunk/archetype APIs the generator expects
    public sealed class Query
    {
        internal readonly object _componentRegistry;
        public Query(object reg){ _componentRegistry = reg; }

        public void ForEach(Delegate forEachDelegate) => throw new Exception(""CodeGenerationException"");

        public IEnumerable<Archetype> GetArchetypeIterator() => new []{ new Archetype() };
    }

    public sealed class Archetype : IEnumerable<Chunk>
    {
        public (int T0, int T1, int T2, int T3) GetOffsets<T0,T1,T2,T3>(in object ids = null) => (0,1,2,3);
        public IEnumerator<Chunk> GetEnumerator(){ yield return new Chunk(); }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public readonly ref struct Chunk
    {
        public EntityHandle GetEntityHandle() => new EntityHandle();
        public ComponentHandle<T> GetHandle<T>(int ofs) where T: struct => new ComponentHandle<T>();
        public ReadOnlyComponentHandle<T> GetHandleReadOnly<T>(int ofs) where T: struct => new ReadOnlyComponentHandle<T>();
        public BufferHandle<T> GetBufferHandle<T>(int ofs) where T: unmanaged => new BufferHandle<T>();
        public ReadOnlyBufferHandle<T> GetBufferHandleReadOnly<T>(int ofs) where T: unmanaged => new ReadOnlyBufferHandle<T>();
        public IndexEnumerator GetEnumerator() => new IndexEnumerator();
    }

    public ref struct EntityHandle { public int this[int i] => i; }
    public ref struct ComponentHandle<T> where T: struct { public ref T this[int i] => throw new NotImplementedException(); }
    public ref struct ReadOnlyComponentHandle<T> where T: struct { public ref readonly T this[int i] => throw new NotImplementedException(); }
    public ref struct BufferHandle<T> where T: unmanaged { public DynamicBuffer<T> this[int i] => default; }
    public ref struct ReadOnlyBufferHandle<T> where T: unmanaged { public ReadOnlyBuffer<T> this[int i] => default; }
    public ref struct IndexEnumerator
    {
        int _i; public bool MoveNext()=> ++_i<4;
        public int Current => _i;
        public IndexEnumerator GetEnumerator()=>this;
    }

    // Component registry stub
    public static class ComponentRegistryExtensions
    {
        public static object GetIds<T0,T1,T2,T3>(this object _reg) => new object();
    }
}
";
}
