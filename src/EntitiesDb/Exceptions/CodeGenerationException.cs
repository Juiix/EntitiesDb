using System;

namespace EntitiesDb;

public sealed class CodeGenerationException() : Exception("Code not generated for this callsite!")
{
}