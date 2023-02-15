using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandLine.Core;

internal static class PreprocessorGuards
{
	public static IEnumerable<Func<IEnumerable<string>, IEnumerable<Error>>> Lookup(StringComparer nameComparer, bool autoHelp, bool autoVersion)
	{
		List<Func<IEnumerable<string>, IEnumerable<Error>>> list = new List<Func<IEnumerable<string>, IEnumerable<Error>>>();
		if (autoHelp)
		{
			list.Add(HelpCommand(nameComparer));
		}
		if (autoVersion)
		{
			list.Add(VersionCommand(nameComparer));
		}
		return list;
	}

	public static Func<IEnumerable<string>, IEnumerable<Error>> HelpCommand(StringComparer nameComparer)
	{
		return (IEnumerable<string> arguments) => (!nameComparer.Equals("--help", Enumerable.First(arguments))) ? Enumerable.Empty<Error>() : new Error[1]
		{
			new HelpRequestedError()
		};
	}

	public static Func<IEnumerable<string>, IEnumerable<Error>> VersionCommand(StringComparer nameComparer)
	{
		return (IEnumerable<string> arguments) => (!nameComparer.Equals("--version", Enumerable.First(arguments))) ? Enumerable.Empty<Error>() : new Error[1]
		{
			new VersionRequestedError()
		};
	}
}
