using System.Collections.Generic;
using System.Linq;
using CommandLine.Core;
using CommandLine.Infrastructure;

namespace CommandLine;

internal static class ErrorExtensions
{
	public static ParserResult<T> ToParserResult<T>(this IEnumerable<Error> errors, T instance)
	{
		if (!Enumerable.Any(errors))
		{
			return new Parsed<T>(instance);
		}
		return new NotParsed<T>(instance.GetType().ToTypeInfo(), errors);
	}

	public static IEnumerable<Error> OnlyMeaningfulOnes(this IEnumerable<Error> errors)
	{
		return Enumerable.Where(Enumerable.Where(errors, (Error e) => !e.StopsProcessing), (Error e) => e.Tag != ErrorType.UnknownOptionError || !((UnknownOptionError)e).Token.EqualsOrdinalIgnoreCase("help"));
	}
}
