using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandLine.Core;

internal static class SpecificationExtensions
{
	public static bool IsOption(this Specification specification)
	{
		return specification.Tag == SpecificationType.Option;
	}

	public static bool IsValue(this Specification specification)
	{
		return specification.Tag == SpecificationType.Value;
	}

	public static OptionSpecification WithLongName(this OptionSpecification specification, string newLongName)
	{
		return new OptionSpecification(specification.ShortName, newLongName, specification.Required, specification.SetName, specification.Min, specification.Max, specification.Separator, specification.DefaultValue, specification.HelpText, specification.MetaValue, specification.EnumValues, specification.ConversionType, specification.TargetType, specification.Group, specification.Hidden);
	}

	public static string UniqueName(this OptionSpecification specification)
	{
		if (specification.ShortName.Length <= 0)
		{
			return specification.LongName;
		}
		return specification.ShortName;
	}

	public static IEnumerable<Specification> ThrowingValidate(this IEnumerable<Specification> specifications, IEnumerable<Tuple<Func<Specification, bool>, string>> guardsLookup)
	{
		foreach (Tuple<Func<Specification, bool>, string> guard in guardsLookup)
		{
			if (Enumerable.Any(specifications, (Specification spec) => guard.Item1(spec)))
			{
				throw new InvalidOperationException(guard.Item2);
			}
		}
		return specifications;
	}

	public static bool HavingRange(this Specification specification, Func<int, int, bool> predicate)
	{
		if (specification.Min.MatchJust(out var value) && specification.Max.MatchJust(out var value2))
		{
			return predicate(value, value2);
		}
		return false;
	}

	public static bool HavingMin(this Specification specification, Func<int, bool> predicate)
	{
		if (specification.Min.MatchJust(out var value))
		{
			return predicate(value);
		}
		return false;
	}

	public static bool HavingMax(this Specification specification, Func<int, bool> predicate)
	{
		if (specification.Max.MatchJust(out var value))
		{
			return predicate(value);
		}
		return false;
	}
}
