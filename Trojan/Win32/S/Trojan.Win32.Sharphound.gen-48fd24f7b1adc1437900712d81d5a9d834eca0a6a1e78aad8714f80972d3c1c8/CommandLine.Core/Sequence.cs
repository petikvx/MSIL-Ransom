using System;
using System.Collections.Generic;
using System.Linq;
using CSharpx;
using CommandLine.Infrastructure;

namespace CommandLine.Core;

internal static class Sequence
{
	public static IEnumerable<Token> Partition(IEnumerable<Token> tokens, Func<string, Maybe<TypeDescriptor>> typeLookup)
	{
		return Enumerable.SelectMany(tokens.Pairwise((Token f, Token s) => (f.IsName() && s.IsValue()) ? typeLookup(f.Text).MapValueOrDefault((TypeDescriptor info) => (info.TargetType != TargetType.Sequence) ? new Token[0] : Enumerable.Concat(new Token[1] { f }, tokens.OfSequence(f, info)), new Token[0]) : new Token[0]), (IEnumerable<Token> tseq) => tseq, (IEnumerable<Token> tseq, Token t) => t);
	}

	private static IEnumerable<Token> OfSequence(this IEnumerable<Token> tokens, Token nameToken, TypeDescriptor info)
	{
		int nameIndex = tokens.IndexOf((Token t) => t.Equals(nameToken));
		if (nameIndex >= 0)
		{
			return info.NextValue.MapValueOrDefault<TypeDescriptor, IEnumerable<Token>>((TypeDescriptor _) => info.MaxItems.MapValueOrDefault<int, IEnumerable<Token>>((int n) => Enumerable.Take(Enumerable.Skip(tokens, nameIndex + 1), n), Enumerable.TakeWhile(Enumerable.Skip(tokens, nameIndex + 1), (Token v) => v.IsValue())), Enumerable.TakeWhile(Enumerable.Skip(tokens, nameIndex + 1), (Token v) => v.IsValue()));
		}
		return new Token[0];
	}
}
