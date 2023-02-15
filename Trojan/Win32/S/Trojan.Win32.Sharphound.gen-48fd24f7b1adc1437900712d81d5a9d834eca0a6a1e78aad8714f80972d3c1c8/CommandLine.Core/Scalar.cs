using System;
using System.Collections.Generic;
using System.Linq;
using CSharpx;

namespace CommandLine.Core;

internal static class Scalar
{
	public static IEnumerable<Token> Partition(IEnumerable<Token> tokens, Func<string, Maybe<TypeDescriptor>> typeLookup)
	{
		return Enumerable.SelectMany(tokens.Pairwise((Token f, Token s) => (f.IsName() && s.IsValue()) ? typeLookup(f.Text).MapValueOrDefault((TypeDescriptor info) => (info.TargetType == TargetType.Scalar) ? new Token[2] { f, s } : new Token[0], new Token[0]) : new Token[0]), (Token[] tseq) => tseq, (Token[] tseq, Token t) => t);
	}
}
