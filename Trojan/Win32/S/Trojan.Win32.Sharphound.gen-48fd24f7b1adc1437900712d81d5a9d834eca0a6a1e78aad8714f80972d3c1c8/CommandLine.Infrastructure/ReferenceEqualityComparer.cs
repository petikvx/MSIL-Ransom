using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CommandLine.Infrastructure;

internal sealed class ReferenceEqualityComparer : IEqualityComparer<object>, IEqualityComparer
{
	public static readonly ReferenceEqualityComparer Default = new ReferenceEqualityComparer();

	public new bool Equals(object x, object y)
	{
		return x == y;
	}

	public int GetHashCode(object obj)
	{
		return RuntimeHelpers.GetHashCode(obj);
	}
}
