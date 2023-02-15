using System;

namespace CommandLine.Infrastructure;

internal static class PopsicleSetter
{
	public static void Set<T>(bool consumed, ref T field, T value)
	{
		if (consumed)
		{
			throw new InvalidOperationException();
		}
		field = value;
	}
}
