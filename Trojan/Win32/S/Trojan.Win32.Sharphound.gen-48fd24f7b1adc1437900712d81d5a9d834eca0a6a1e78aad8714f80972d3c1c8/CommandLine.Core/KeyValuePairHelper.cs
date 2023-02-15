using System.Collections.Generic;
using System.Linq;
using CSharpx;
using CommandLine.Infrastructure;

namespace CommandLine.Core;

internal static class KeyValuePairHelper
{
	public static IEnumerable<KeyValuePair<string, IEnumerable<string>>> ForSwitch(IEnumerable<Token> tokens)
	{
		return Enumerable.Select(tokens, (Token t) => t.Text.ToKeyValuePair("true"));
	}

	public static IEnumerable<KeyValuePair<string, IEnumerable<string>>> ForScalar(IEnumerable<Token> tokens)
	{
		return Enumerable.Select(tokens.Group(2), (Token[] g) => g[0].Text.ToKeyValuePair(g[1].Text));
	}

	public static IEnumerable<KeyValuePair<string, IEnumerable<string>>> ForSequence(IEnumerable<Token> tokens)
	{
		return Enumerable.Where(tokens.Pairwise((Token f, Token s) => (!f.IsName()) ? string.Empty.ToKeyValuePair() : f.Text.ToKeyValuePair(Enumerable.ToArray(Enumerable.Select(Enumerable.TakeWhile(Enumerable.SkipWhile(Enumerable.SkipWhile(tokens, (Token t) => !t.Equals(f)), (Token t) => t.Equals(f)), (Token v) => v.IsValue()), (Token x) => x.Text)))), delegate(KeyValuePair<string, IEnumerable<string>> t)
		{
			KeyValuePair<string, IEnumerable<string>> keyValuePair = t;
			if (keyValuePair.Key.Length > 0)
			{
				keyValuePair = t;
				return Enumerable.Any(keyValuePair.Value);
			}
			return false;
		});
	}

	private static KeyValuePair<string, IEnumerable<string>> ToKeyValuePair(this string value, params string[] values)
	{
		return new KeyValuePair<string, IEnumerable<string>>(value, values);
	}
}
