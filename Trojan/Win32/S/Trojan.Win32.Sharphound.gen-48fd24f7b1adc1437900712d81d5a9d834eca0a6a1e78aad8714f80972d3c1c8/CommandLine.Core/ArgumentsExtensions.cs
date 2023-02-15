using System;
using System.Collections.Generic;
using System.Linq;
using CSharpx;

namespace CommandLine.Core;

internal static class ArgumentsExtensions
{
	public static IEnumerable<Error> Preprocess(this IEnumerable<string> arguments, IEnumerable<Func<IEnumerable<string>, IEnumerable<Error>>> preprocessorLookup)
	{
		return preprocessorLookup.TryHead().MapValueOrDefault<Func<IEnumerable<string>, IEnumerable<Error>>, IEnumerable<Error>>(delegate(Func<IEnumerable<string>, IEnumerable<Error>> func)
		{
			IEnumerable<Error> enumerable = func(arguments);
			return (!Enumerable.Any(enumerable)) ? arguments.Preprocess(preprocessorLookup.TailNoFail()) : enumerable;
		}, Enumerable.Empty<Error>());
	}
}
