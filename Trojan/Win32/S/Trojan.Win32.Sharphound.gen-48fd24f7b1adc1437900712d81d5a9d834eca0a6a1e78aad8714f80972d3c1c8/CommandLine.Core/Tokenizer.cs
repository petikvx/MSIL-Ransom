using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using CSharpx;
using CommandLine.Infrastructure;
using RailwaySharp.ErrorHandling;

namespace CommandLine.Core;

internal static class Tokenizer
{
	public static Result<IEnumerable<Token>, Error> Tokenize(IEnumerable<string> arguments, Func<string, NameLookupResult> nameLookup)
	{
		return Tokenize(arguments, nameLookup, (IEnumerable<Token> tokens) => tokens);
	}

	public static Result<IEnumerable<Token>, Error> Tokenize(IEnumerable<string> arguments, Func<string, NameLookupResult> nameLookup, Func<IEnumerable<Token>, IEnumerable<Token>> normalize)
	{
		List<Error> list = new List<Error>();
		Action<Error> onError = list.Add;
		IEnumerable<Token> arg2 = Enumerable.SelectMany(arguments, (string arg) => arg.StartsWith("-", StringComparison.Ordinal) ? ((!arg.StartsWith("--", StringComparison.Ordinal)) ? TokenizeShortName(arg, nameLookup) : TokenizeLongName(arg, onError)) : new Token[1] { Token.Value(arg) }, (string arg, Token token) => token).Memorize();
		IEnumerable<Token> source = normalize(arg2).Memorize();
		IEnumerable<Token> unkTokens = Enumerable.Where(source, (Token t) => t.IsName() && nameLookup(t.Text) == NameLookupResult.NoOptionFound).Memorize();
		return Result.Succeed(Enumerable.Where(source, (Token x) => !Enumerable.Contains(unkTokens, x)), Enumerable.Concat(list, Enumerable.Select(unkTokens, (Token t) => new UnknownOptionError(t.Text))));
	}

	public static Result<IEnumerable<Token>, Error> PreprocessDashDash(IEnumerable<string> arguments, Func<IEnumerable<string>, Result<IEnumerable<Token>, Error>> tokenizer)
	{
		if (Enumerable.Any(arguments, (string arg) => arg.EqualsOrdinal("--")))
		{
			Result<IEnumerable<Token>, Error> result = tokenizer(Enumerable.TakeWhile(arguments, (string arg) => !arg.EqualsOrdinal("--")));
			IEnumerable<Token> values = Enumerable.Select(Enumerable.Skip(Enumerable.SkipWhile(arguments, (string arg) => !arg.EqualsOrdinal("--")), 1), Token.Value);
			return result.Map((IEnumerable<Token> tokens) => Enumerable.Concat(tokens, values));
		}
		return tokenizer(arguments);
	}

	public static Result<IEnumerable<Token>, Error> ExplodeOptionList(Result<IEnumerable<Token>, Error> tokenizerResult, Func<string, Maybe<char>> optionSequenceWithSeparatorLookup)
	{
		IEnumerable<Token> source = tokenizerResult.SucceededWith().Memorize();
		IEnumerable<Tuple<int, char>> replaces = Enumerable.SkipWhile(Enumerable.Select(source, (Token t, int i) => optionSequenceWithSeparatorLookup(t.Text).MapValueOrDefault((char sep) => Tuple.Create(i + 1, sep), Tuple.Create(-1, '\0'))), (Tuple<int, char> x) => x.Item1 < 0).Memorize();
		return Result.Succeed(Enumerable.SelectMany(Enumerable.Select(source, (Token t, int i) => Enumerable.FirstOrDefault(replaces, (Tuple<int, char> x) => x.Item1 == i).ToMaybe().MapValueOrDefault<Tuple<int, char>, IEnumerable<Token>>((Tuple<int, char> r) => Enumerable.Select(t.Text.Split(new char[1] { r.Item2 }), Token.Value), Enumerable.Concat(Enumerable.Empty<Token>(), new Token[1] { t }))), (IEnumerable<Token> x) => x), tokenizerResult.SuccessfulMessages());
	}

	public static IEnumerable<Token> Normalize(IEnumerable<Token> tokens, Func<string, bool> nameLookup)
	{
		IEnumerable<int> indexes = Enumerable.Select(Enumerable.Where(Enumerable.Select(tokens, delegate(Token t, int i)
		{
			Maybe<Token> maybe = Enumerable.ElementAtOrDefault(tokens, i - 1).ToMaybe();
			return (t.IsValue() && ((Value)t).ExplicitlyAssigned && maybe.MapValueOrDefault((Token p) => p.IsName() && !nameLookup(p.Text), noneValue: false)) ? Maybe.Just(i) : Maybe.Nothing<int>();
		}), (Maybe<int> i) => i.IsJust()), (Maybe<int> i) => i.FromJustOrFail());
		IEnumerable<Token> toExclude = Enumerable.Select(Enumerable.Where(Enumerable.Select(tokens, (Token t, int i) => (!Enumerable.Contains(indexes, i)) ? Maybe.Nothing<Token>() : Maybe.Just(t)), (Maybe<Token> t) => t.IsJust()), (Maybe<Token> t) => t.FromJustOrFail());
		return Enumerable.Where(tokens, (Token t) => !Enumerable.Contains(toExclude, t));
	}

	public static Func<IEnumerable<string>, IEnumerable<OptionSpecification>, Result<IEnumerable<Token>, Error>> ConfigureTokenizer(StringComparer nameComparer, bool ignoreUnknownArguments, bool enableDashDash)
	{
		return delegate(IEnumerable<string> arguments, IEnumerable<OptionSpecification> optionSpecs)
		{
			Func<IEnumerable<Token>, IEnumerable<Token>> normalize = (ignoreUnknownArguments ? ((Func<IEnumerable<Token>, IEnumerable<Token>>)((IEnumerable<Token> toks) => Normalize(toks, (string name) => NameLookup.Contains(name, optionSpecs, nameComparer) != NameLookupResult.NoOptionFound))) : ((Func<IEnumerable<Token>, IEnumerable<Token>>)((IEnumerable<Token> toks) => toks)));
			return ExplodeOptionList(enableDashDash ? PreprocessDashDash(arguments, (IEnumerable<string> args) => Tokenize(args, (string name) => NameLookup.Contains(name, optionSpecs, nameComparer), normalize)) : Tokenize(arguments, (string name) => NameLookup.Contains(name, optionSpecs, nameComparer), normalize), (string name) => NameLookup.HavingSeparator(name, optionSpecs, nameComparer));
		};
	}

	private static IEnumerable<Token> TokenizeShortName(string value, Func<string, NameLookupResult> nameLookup)
	{
		if (value.Length <= 1 || value[0] != '-' || value[1] == '-')
		{
			yield break;
		}
		string text = value.Substring(1);
		if (char.IsDigit(text[0]))
		{
			yield return Token.Value(value);
			yield break;
		}
		if (value.Length == 2)
		{
			yield return Token.Name(text);
			yield break;
		}
		int i = 0;
		string text2 = text;
		for (int j = 0; j < text2.Length; j++)
		{
			string text3 = new string(text2[j], 1);
			NameLookupResult r = nameLookup(text3);
			if (i > 0 && r == NameLookupResult.NoOptionFound)
			{
				break;
			}
			i++;
			yield return Token.Name(text3);
			if (r == NameLookupResult.OtherOptionFound)
			{
				break;
			}
		}
		if (i < text.Length)
		{
			yield return Token.Value(text.Substring(i));
		}
	}

	private static IEnumerable<Token> TokenizeLongName(string value, Action<Error> onError)
	{
		if (value.Length <= 2 || !value.StartsWith("--", StringComparison.Ordinal))
		{
			yield break;
		}
		string text = value.Substring(2);
		int num = text.IndexOf('=');
		if (num <= 0)
		{
			yield return Token.Name(text);
			yield break;
		}
		if (num == 1)
		{
			onError(new BadFormatTokenError(value));
			yield break;
		}
		Match tokenMatch = Regex.Match(text, "^([^=]+)=([^ ].*)$");
		if (tokenMatch.Success)
		{
			yield return Token.Name(tokenMatch.Groups[1].Value);
			yield return Token.Value(tokenMatch.Groups[2].Value, explicitlyAssigned: true);
		}
		else
		{
			onError(new BadFormatTokenError(value));
		}
	}
}
