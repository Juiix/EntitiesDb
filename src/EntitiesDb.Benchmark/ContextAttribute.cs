using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDb.Benchmark;

[AttributeUsage(AttributeTargets.Field)]
internal sealed class ContextAttribute : Attribute
{
}
