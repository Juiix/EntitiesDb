namespace EntitiesDb;

public partial class Query
{
	/// <summary>
	/// Executes a self-composed Parallel ForEach query. Accepts in, ref, <see cref="WriteBuffer{T}"/>, and <see cref="ReadBuffer{T}"/> components.
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
	/// ForEach((Entity entity, ref ComponentA a, in ComponentB b, WriteBuffer&lt;ComponentC&gt; cBuffer) =&gt; { });
	/// </c>
	/// <br/>
	/// <c>
	/// ForEach((ref ComponentA a, ReadBuffer&lt;ComponentC&gt; cBuffer, ref int count) =&gt; { }, ref count);
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
	/// Executes a self-composed Parallel ForEach chunk query. Accepts <see cref="WriteHandle{T}"/>, <see cref="ReadHandle{T}"/>, <see cref="WriteBufferHandle{T}"/>, and <see cref="ReadBufferHandle{T}"/> components.
	/// 
	/// <para>
	/// 1. <see cref="ReadHandle{T}"/> for <see cref="Entity"/> can be accessed via the first lambda parameter.
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
	/// ForEach((int length, ReadHandle&lt;Entity&gt; entities, WriteHandle&lt;ComponentA&gt; aHandle, ReadHandle&lt;ComponentB&gt; bHandle, WriteBufferHandle&lt;ComponentC&gt; cBufferHandle) =&gt; { });
	/// </c>
	/// <br/>
	/// <c>
	/// ForEach((int length, WriteHandle&lt;ComponentA&gt; aHandle, ReadBufferHandle&lt;ComponentC&gt; cBufferHandle, ref int count) =&gt; { }, ref count);
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
