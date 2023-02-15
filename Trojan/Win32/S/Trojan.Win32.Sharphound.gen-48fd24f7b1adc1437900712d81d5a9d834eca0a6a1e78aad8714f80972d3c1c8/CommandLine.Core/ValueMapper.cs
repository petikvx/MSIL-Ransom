using System;
using System.Collections.Generic;
using System.Linq;
using CSharpx;
using CommandLine.Infrastructure;
using RailwaySharp.ErrorHandling;

namespace CommandLine.Core;

internal static class ValueMapper
{
	public static Result<IEnumerable<SpecificationProperty>, Error> MapValues(IEnumerable<SpecificationProperty> specProps, IEnumerable<string> values, Func<IEnumerable<string>, Type, bool, Maybe<object>> converter)
	{
		IEnumerable<Tuple<SpecificationProperty, Maybe<Error>>> source = MapValuesImpl(specProps, values, converter);
		return Result.Succeed(Enumerable.Select(source, (Tuple<SpecificationProperty, Maybe<Error>> pe) => pe.Item1), Enumerable.Select(Enumerable.OfType<Just<Error>>(Enumerable.Select(source, (Tuple<SpecificationProperty, Maybe<Error>> pe) => pe.Item2)), (Just<Error> e) => e.Value));
	}

	private static IEnumerable<Tuple<SpecificationProperty, Maybe<Error>>> MapValuesImpl(IEnumerable<SpecificationProperty> specProps, IEnumerable<string> values, Func<IEnumerable<string>, Type, bool, Maybe<object>> converter)
	{
		if (specProps.Empty())
		{
			yield break;
		}
		SpecificationProperty pt = Enumerable.First(specProps);
		IEnumerable<string> taken = Enumerable.Take(values, pt.Specification.CountOfMaxNumberOfValues().GetValueOrDefault(Enumerable.Count(values)));
		if (taken.Empty())
		{
			yield return Tuple.Create(pt, pt.Specification.MakeErrorInCaseOfMinConstraint());
			yield break;
		}
		Maybe<SpecificationProperty> maybe = Enumerable.FirstOrDefault(Enumerable.Skip(specProps, 1), (SpecificationProperty s) => s.Specification.IsValue()).ToMaybe();
		if (pt.Specification.Max.IsJust() && maybe.IsNothing() && Enumerable.Any(Enumerable.Skip(values, Enumerable.Count(taken))))
		{
			yield return Tuple.Create(pt, (Maybe<Error>)Maybe.Just((Error)new SequenceOutOfRangeError(NameInfo.EmptyName)));
			yield break;
		}
		yield return converter(taken, pt.Property.PropertyType, pt.Specification.TargetType != TargetType.Sequence).MapValueOrDefault((object converted) => Tuple.Create(pt.WithValue(Maybe.Just(converted)), Maybe.Nothing<Error>()), Tuple.Create(pt, (Maybe<Error>)Maybe.Just((Error)new BadFormatConversionError(NameInfo.EmptyName))));
		foreach (Tuple<SpecificationProperty, Maybe<Error>> item in MapValuesImpl(Enumerable.Skip(specProps, 1), Enumerable.Skip(values, Enumerable.Count(taken)), converter))
		{
			yield return item;
		}
	}

	private static Maybe<int> CountOfMaxNumberOfValues(this Specification specification)
	{
		TargetType targetType = specification.TargetType;
		if (targetType != TargetType.Scalar)
		{
			if (targetType == TargetType.Sequence && specification.Max.IsJust())
			{
				return Maybe.Just(specification.Max.FromJustOrFail());
			}
			return Maybe.Nothing<int>();
		}
		return Maybe.Just(1);
	}

	private static Maybe<Error> MakeErrorInCaseOfMinConstraint(this Specification specification)
	{
		if (!specification.Min.IsJust())
		{
			return Maybe.Nothing<Error>();
		}
		return Maybe.Just((Error)new SequenceOutOfRangeError(NameInfo.EmptyName));
	}
}
