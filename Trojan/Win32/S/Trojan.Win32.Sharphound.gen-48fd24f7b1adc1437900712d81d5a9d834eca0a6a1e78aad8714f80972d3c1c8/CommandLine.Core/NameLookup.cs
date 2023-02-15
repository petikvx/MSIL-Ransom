using System;
using System.Collections.Generic;
using System.Linq;
using CSharpx;

namespace CommandLine.Core;

internal static class NameLookup
{
	public static NameLookupResult Contains(string name, IEnumerable<OptionSpecification> specifications, StringComparer comparer)
	{
		OptionSpecification optionSpecification = Enumerable.FirstOrDefault(specifications, (OptionSpecification a) => name.MatchName(a.ShortName, a.LongName, comparer));
		if (optionSpecification == null)
		{
			return NameLookupResult.NoOptionFound;
		}
		if (!(optionSpecification.ConversionType == typeof(bool)))
		{
			return NameLookupResult.OtherOptionFound;
		}
		return NameLookupResult.BooleanOptionFound;
	}

	public static Maybe<char> HavingSeparator(string name, IEnumerable<OptionSpecification> specifications, StringComparer comparer)
	{
		return Enumerable.SingleOrDefault(specifications, (OptionSpecification a) => name.MatchName(a.ShortName, a.LongName, comparer) && a.Separator != '\0').ToMaybe().MapValueOrDefault<OptionSpecification, Maybe<char>>((OptionSpecification spec) => Maybe.Just(spec.Separator), Maybe.Nothing<char>());
	}
}
