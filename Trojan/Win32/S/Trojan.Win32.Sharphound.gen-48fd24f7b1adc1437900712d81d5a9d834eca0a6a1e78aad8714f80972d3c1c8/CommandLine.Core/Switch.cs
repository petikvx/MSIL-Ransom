using System;
using System.Collections.Generic;
using System.Linq;
using CSharpx;

namespace CommandLine.Core;

internal static class Switch
{
	public static IEnumerable<Token> Partition(IEnumerable<Token> tokens, Func<string, Maybe<TypeDescriptor>> typeLookup)
	{
		return Enumerable.Where(tokens, (Token t) => typeLookup(t.Text).MapValueOrDefault((TypeDescriptor info) => t.IsName() && info.TargetType == TargetType.Switch, noneValue: false));
	}
}
