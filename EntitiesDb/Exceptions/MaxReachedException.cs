using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDb;

public sealed class MaxReachedException(int max, string message) : Exception(message)
{
	public int Max { get; } = max;
}
