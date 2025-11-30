namespace EntitiesDb;

public delegate void ForEachDelegate();
public delegate void ForEachChunkDelegate(int length);

public partial class Query
{
	/// <summary>
	/// Executes a self-composed ForEach query. Accepts in, ref, <see cref="DynamicBuffer{T}"/>, and <see cref="ReadOnlyBuffer{T}"/> components.
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
	public void ForEach(ForEachDelegate @delegate) =>
		throw new CodeGenerationException();

	/// <summary>
	/// <inheritdoc cref="ForEach(ForEachDelegate)"/>
	/// </summary>
	public void ForEach(ForEachDelegate @delegate, ref object? state) =>
		throw new CodeGenerationException();

	/// <summary>
	/// <para>
	/// This is an alt-method to <see cref="ForEach(ForEachDelegate)"/>. Used to quickly resolve ref/in conflicts.
	/// </para>
	/// 
	/// <inheritdoc cref="ForEach(ForEachDelegate)"/>
	/// </summary>
	public void ForEachAlt(ForEachDelegate @delegate) =>
		throw new CodeGenerationException();

	/// <summary>
	/// <para>
	/// This is an alt-method to <see cref="ForEach(ForEachDelegate, ref object?)"/>. Used to quickly resolve ref/in conflicts.
	/// </para>
	/// 
	/// <inheritdoc cref="ForEach(ForEachDelegate, ref object?)"/>
	/// </summary>
	public void ForEachAlt(ForEachDelegate @delegate, ref object? state) =>
		throw new CodeGenerationException();

	/// <summary>
	/// Executes a self-composed ForEach chunk query. Accepts <see cref="Handle{T}"/>, <see cref="ReadOnlyHandle{T}"/>, <see cref="DynamicBufferHandle{T}"/>, and <see cref="ReadOnlyBufferHandle{T}"/> components.
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
	public void ForEachChunk(ForEachChunkDelegate @delegate) =>
		throw new CodeGenerationException();

	/// <summary>
	/// <inheritdoc cref="ForEachChunk(ForEachChunkDelegate)"/>
	/// </summary>
	public void ForEachChunk(ForEachChunkDelegate @delegate, ref object? state) =>
		throw new CodeGenerationException();
}
