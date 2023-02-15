using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandLine.Infrastructure;

internal static class ExceptionExtensions
{
	public static void RethrowWhenAbsentIn(this Exception exception, IEnumerable<Type> validExceptions)
	{
		if (!Enumerable.Contains(validExceptions, exception.GetType()))
		{
			throw exception;
		}
	}
}
