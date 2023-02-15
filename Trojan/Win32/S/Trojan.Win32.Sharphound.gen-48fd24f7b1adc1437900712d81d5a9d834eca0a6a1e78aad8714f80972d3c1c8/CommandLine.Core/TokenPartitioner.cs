using System;
using System.Collections.Generic;
using System.Linq;
using CSharpx;
using CommandLine.Infrastructure;

namespace CommandLine.Core;

internal static class TokenPartitioner
{
	public static Tuple<IEnumerable<KeyValuePair<string, IEnumerable<string>>>, IEnumerable<string>, IEnumerable<Token>> Partition(IEnumerable<Token> tokens, Func<string, Maybe<TypeDescriptor>> typeLookup)
	{
		IEqualityComparer<Token> @default = CommandLine.Infrastructure.ReferenceEqualityComparer.Default;
		IEnumerable<Token> enumerable = tokens.Memorize();
		HashSet<Token> switches = new HashSet<Token>(Switch.Partition(enumerable, typeLookup), @default);
		HashSet<Token> scalars = new HashSet<Token>(Scalar.Partition(enumerable, typeLookup), @default);
		HashSet<Token> sequences = new HashSet<Token>(Sequence.Partition(enumerable, typeLookup), @default);
		IEnumerable<Token> enumerable2 = Enumerable.Where(Enumerable.Where(Enumerable.Where(enumerable, (Token t) => !switches.Contains(t)), (Token t) => !scalars.Contains(t)), (Token t) => !sequences.Contains(t)).Memorize();
		IEnumerable<Token> enumerable3 = Enumerable.Where(enumerable2, (Token v) => v.IsValue()).Memorize();
		IEnumerable<Token> item = Enumerable.Except(enumerable2, enumerable3, (IEqualityComparer<Token>?)CommandLine.Infrastructure.ReferenceEqualityComparer.Default).Memorize();
		return Tuple.Create(Enumerable.Concat(Enumerable.Concat(KeyValuePairHelper.ForSwitch(switches), KeyValuePairHelper.ForScalar(scalars)), KeyValuePairHelper.ForSequence(sequences)), Enumerable.Select(enumerable3, (Token t) => t.Text), item);
	}
}
