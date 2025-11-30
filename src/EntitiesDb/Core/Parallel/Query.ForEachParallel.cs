namespace EntitiesDb;

public partial class Query
{
	/// <summary>
	/// Executes a self-composed Parallel ForEach query. Accepts in, ref, <see cref="DynamicBuffer{T}"/>, and <see cref="ReadOnlyBuffer{T}"/> components.
	/// 
	/// <para>
	/// 1. <see cref="Entity"/> can be accessed via the first lambda parameter.
	/// </para>
	/// 
	/// <para>
	/// 2. Any state object may be passed via ref after the lambda. Access state as the last ref parameter in the lambda.
	/// </para>
	/// 
	/// <para>
	/// Examples:
	/// <br/>
	/// <c>
	/// ForEach((Entity entity, ref ComponentA a, in ComponentB b, DynamicBuffer&lt;ComponentC&gt; cBuffer) =&gt; { });
	/// </c>
	/// <br/>
	/// <c>
	/// ForEach((ref ComponentA a, ReadOnlyBuffer&lt;ComponentC&gt; cBuffer, ref int count) =&gt; { }, ref count);
	/// </c>
	/// </para>
	/// </summary>
	/// <param name="delegate">The self-composed ForEach lambda</param>
	/// <exception cref="CodeGenerationException"></exception>
	public void ForEachParallel(ForEachDelegate @delegate, ParallelOptions options = default) =>
		throw new CodeGenerationException();

	/// <summary>
	/// <inheritdoc cref="ForEachParallel(ForEachDelegate, ParallelOptions)"/>
	/// </summary>
	public void ForEachParallel(ForEachDelegate @delegate, ref object? state, ParallelOptions options = default) =>
		throw new CodeGenerationException();

	/// <summary>
	/// <para>
	/// This is an alt-method to <see cref="ForEachParallel(ForEachDelegate, ParallelOptions)"/>. Used to quickly resolve ref/in conflicts.
	/// </para>
	/// 
	/// <inheritdoc cref="ForEachParallel(ForEachDelegate, ParallelOptions)"/>
	/// </summary>
	public void ForEachParallelAlt(ForEachDelegate @delegate, ParallelOptions options = default) =>
		throw new CodeGenerationException();

	/// <summary>
	/// <para>
	/// This is an alt-method to <see cref="ForEachParallel(ForEachDelegate, ref object?, ParallelOptions)"/>. Used to quickly resolve ref/in conflicts.
	/// </para>
	/// 
	/// <inheritdoc cref="ForEachParallel(ForEachDelegate, ParallelOptions)"/>
	/// </summary>
	public void ForEachParallelAlt(ForEachDelegate @delegate, ref object? state, ParallelOptions options = default) =>
		throw new CodeGenerationException();

	/// <summary>
	/// Executes a self-composed Parallel ForEach chunk query. Accepts <see cref="Handle{T}"/>, <see cref="ReadOnlyHandle{T}"/>, <see cref="DynamicBufferHandle{T}"/>, and <see cref="ReadOnlyBufferHandle{T}"/> components.
	/// 
	/// <para>
	/// 1. <see cref="ReadOnlyHandle{T}"/> for <see cref="Entity"/> can be accessed via the first lambda parameter.
	/// </para>
	/// 
	/// <para>
	/// 2. Any state object may be passed via ref after the lambda. Access state as the last ref parameter in the lambda.
	/// </para>
	/// 
	/// <para>
	/// Examples:
	/// <br/>
	/// <c>
	/// ForEach((int length, ReadOnlyHandle&lt;Entity&gt; entities, Handle&lt;ComponentA&gt; aHandle, ReadOnlyHandle&lt;ComponentB&gt; bHandle, DynamicBufferHandle&lt;ComponentC&gt; cBufferHandle) =&gt; { });
	/// </c>
	/// <br/>
	/// <c>
	/// ForEach((int length, Handle&lt;ComponentA&gt; aHandle, ReadOnlyBufferHandle&lt;ComponentC&gt; cBufferHandle, ref int count) =&gt; { }, ref count);
	/// </c>
	/// </para>
	/// </summary>
	/// <param name="delegate">The self-composed ForEach chunk lambda</param>
	/// <exception cref="CodeGenerationException"></exception>
	public void ForEachChunkParallel(ForEachChunkDelegate @delegate, ParallelOptions options = default) =>
		throw new CodeGenerationException();

	/// <summary>
	/// <inheritdoc cref="ForEachChunkParallel(ForEachChunkDelegate, ParallelOptions)"/>
	/// </summary>
	public void ForEachChunkParallel(ForEachChunkDelegate @delegate, ref object? state, ParallelOptions options = default) =>
		throw new CodeGenerationException();
}
