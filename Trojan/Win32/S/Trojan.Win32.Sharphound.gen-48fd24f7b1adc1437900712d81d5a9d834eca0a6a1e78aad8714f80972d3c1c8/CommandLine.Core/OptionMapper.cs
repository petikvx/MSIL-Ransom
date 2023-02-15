using System;
using System.Collections.Generic;
using System.Linq;
using CSharpx;
using RailwaySharp.ErrorHandling;

namespace CommandLine.Core;

internal static class OptionMapper
{
	public static Result<IEnumerable<SpecificationProperty>, Error> MapValues(IEnumerable<SpecificationProperty> propertyTuples, IEnumerable<KeyValuePair<string, IEnumerable<string>>> options, Func<IEnumerable<string>, Type, bool, Maybe<object>> converter, StringComparer comparer)
	{
		IEnumerable<Tuple<SpecificationProperty, Maybe<Error>>> source = Enumerable.Select(propertyTuples, delegate(SpecificationProperty pt)
		{
			Maybe<KeyValuePair<string, IEnumerable<string>>> maybe = Enumerable.FirstOrDefault(options, (KeyValuePair<string, IEnumerable<string>> s) => s.Key.MatchName(((OptionSpecification)pt.Specification).ShortName, ((OptionSpecification)pt.Specification).LongName, comparer)).ToMaybe();
			return (!maybe.IsJust()) ? Tuple.Create(pt, Maybe.Nothing<Error>()) : maybe.SelectMany(delegate(KeyValuePair<string, IEnumerable<string>> sequence)
			{
				Func<IEnumerable<string>, Type, bool, Maybe<object>> func = converter;
				KeyValuePair<string, IEnumerable<string>> keyValuePair = sequence;
				return func(keyValuePair.Value, pt.Property.PropertyType, pt.Specification.TargetType != TargetType.Sequence);
			}, (KeyValuePair<string, IEnumerable<string>> sequence, object converted) => Tuple.Create(pt.WithValue(Maybe.Just(converted)), Maybe.Nothing<Error>())).GetValueOrDefault(Tuple.Create(pt, (Maybe<Error>)Maybe.Just((Error)new BadFormatConversionError(((OptionSpecification)pt.Specification).FromOptionSpecification()))));
		}).Memorize();
		return Result.Succeed(Enumerable.Select(source, (Tuple<SpecificationProperty, Maybe<Error>> se) => se.Item1), Enumerable.Select(Enumerable.OfType<Just<Error>>(Enumerable.Select(source, (Tuple<SpecificationProperty, Maybe<Error>> se) => se.Item2)), (Just<Error> se) => se.Value));
	}
}
