using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CommandLine;

public static class HelpTextExtensions
{
	public static bool IsHelp(this IEnumerable<Error> errs)
	{
		if (Enumerable.Any(errs, (Error x) => x.Tag == ErrorType.HelpRequestedError || x.Tag == ErrorType.HelpVerbRequestedError))
		{
			return true;
		}
		return Enumerable.Any(errs, (Error x) => ((x is UnknownOptionError unknownOptionError) ? unknownOptionError.Token : "") == "help");
	}

	public static bool IsVersion(this IEnumerable<Error> errs)
	{
		if (Enumerable.Any(errs, (Error x) => x.Tag == ErrorType.VersionRequestedError))
		{
			return true;
		}
		return Enumerable.Any(errs, (Error x) => ((x is UnknownOptionError unknownOptionError) ? unknownOptionError.Token : "") == "version");
	}

	public static TextWriter Output(this IEnumerable<Error> errs)
	{
		if (!errs.IsHelp() && !errs.IsVersion())
		{
			return Console.Error;
		}
		return Console.Out;
	}
}
