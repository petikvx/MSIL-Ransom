using System;

namespace CommandLine.Core;

internal static class NameExtensions
{
	public static bool MatchName(this string value, string shortName, string longName, StringComparer comparer)
	{
		if (value.Length != 1)
		{
			return comparer.Equals(value, longName);
		}
		return comparer.Equals(value, shortName);
	}

	public static NameInfo FromOptionSpecification(this OptionSpecification specification)
	{
		return new NameInfo(specification.ShortName, specification.LongName);
	}

	public static NameInfo FromSpecification(this Specification specification)
	{
		if (specification.Tag == SpecificationType.Option)
		{
			return ((OptionSpecification)specification).FromOptionSpecification();
		}
		return NameInfo.EmptyName;
	}
}
