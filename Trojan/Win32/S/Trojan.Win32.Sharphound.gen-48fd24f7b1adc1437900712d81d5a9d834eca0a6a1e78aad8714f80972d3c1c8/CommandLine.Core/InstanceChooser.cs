using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using CSharpx;
using RailwaySharp.ErrorHandling;

namespace CommandLine.Core;

internal static class InstanceChooser
{
	public static ParserResult<object> Choose(Func<IEnumerable<string>, IEnumerable<OptionSpecification>, Result<IEnumerable<Token>, Error>> tokenizer, IEnumerable<Type> types, IEnumerable<string> arguments, StringComparer nameComparer, bool ignoreValueCase, CultureInfo parsingCulture, bool autoHelp, bool autoVersion, IEnumerable<ErrorType> nonFatalErrors)
	{
		Func<ParserResult<object>> func = delegate
		{
			string firstArg = Enumerable.First(arguments);
			Func<string, bool> func2 = (string command) => nameComparer.Equals(command, firstArg) || nameComparer.Equals("--" + command, firstArg);
			IEnumerable<Tuple<Verb, Type>> verbs = Verb.SelectFromTypes(types);
			if (autoHelp && func2("help"))
			{
				return MakeNotParsed(types, MakeHelpVerbRequestedError(verbs, Enumerable.FirstOrDefault(Enumerable.Skip(arguments, 1)) ?? string.Empty, nameComparer));
			}
			return (autoVersion && func2("version")) ? MakeNotParsed(types, new VersionRequestedError()) : MatchVerb(tokenizer, verbs, arguments, nameComparer, ignoreValueCase, parsingCulture, autoHelp, autoVersion, nonFatalErrors);
		};
		if (!Enumerable.Any(arguments))
		{
			return MakeNotParsed(types, new NoVerbSelectedError());
		}
		return func();
	}

	private static ParserResult<object> MatchVerb(Func<IEnumerable<string>, IEnumerable<OptionSpecification>, Result<IEnumerable<Token>, Error>> tokenizer, IEnumerable<Tuple<Verb, Type>> verbs, IEnumerable<string> arguments, StringComparer nameComparer, bool ignoreValueCase, CultureInfo parsingCulture, bool autoHelp, bool autoVersion, IEnumerable<ErrorType> nonFatalErrors)
	{
		if (!Enumerable.Any(verbs, (Tuple<Verb, Type> a) => nameComparer.Equals(a.Item1.Name, Enumerable.First(arguments))))
		{
			return MakeNotParsed(Enumerable.Select(verbs, (Tuple<Verb, Type> v) => v.Item2), new BadVerbSelectedError(Enumerable.First(arguments)));
		}
		return InstanceBuilder.Build(Maybe.Just<Func<object>>(() => Enumerable.Single(verbs, (Tuple<Verb, Type> v) => nameComparer.Equals(v.Item1.Name, Enumerable.First(arguments))).Item2.AutoDefault()), tokenizer, Enumerable.Skip(arguments, 1), nameComparer, ignoreValueCase, parsingCulture, autoHelp, autoVersion, nonFatalErrors);
	}

	private static HelpVerbRequestedError MakeHelpVerbRequestedError(IEnumerable<Tuple<Verb, Type>> verbs, string verb, StringComparer nameComparer)
	{
		if (verb.Length <= 0)
		{
			return new HelpVerbRequestedError(null, null, matched: false);
		}
		return Enumerable.SingleOrDefault(verbs, (Tuple<Verb, Type> v) => nameComparer.Equals(v.Item1.Name, verb)).ToMaybe().MapValueOrDefault<Tuple<Verb, Type>, HelpVerbRequestedError>((Tuple<Verb, Type> v) => new HelpVerbRequestedError(v.Item1.Name, v.Item2, matched: true), new HelpVerbRequestedError(null, null, matched: false));
	}

	private static NotParsed<object> MakeNotParsed(IEnumerable<Type> types, params Error[] errors)
	{
		return new NotParsed<object>(TypeInfo.Create(typeof(NullInstance), types), errors);
	}
}
