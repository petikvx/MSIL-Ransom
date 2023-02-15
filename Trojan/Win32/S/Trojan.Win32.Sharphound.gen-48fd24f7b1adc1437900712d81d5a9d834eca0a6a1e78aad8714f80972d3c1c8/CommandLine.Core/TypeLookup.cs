using System;
using System.Collections.Generic;
using System.Linq;
using CSharpx;

namespace CommandLine.Core;

internal static class TypeLookup
{
	public static Maybe<TypeDescriptor> FindTypeDescriptorAndSibling(string name, IEnumerable<OptionSpecification> specifications, StringComparer comparer)
	{
		return Enumerable.SingleOrDefault(specifications, (OptionSpecification a) => name.MatchName(a.ShortName, a.LongName, comparer)).ToMaybe().Map<OptionSpecification, TypeDescriptor>(delegate(OptionSpecification first)
		{
			TypeDescriptor descriptor = TypeDescriptor.Create(first.TargetType, first.Max);
			Maybe<TypeDescriptor> nextValue = Enumerable.SingleOrDefault(Enumerable.Take(Enumerable.SkipWhile(specifications, (OptionSpecification s) => s.Equals(first)), 1), (OptionSpecification x) => x.IsValue()).ToMaybe().Map<OptionSpecification, TypeDescriptor>((OptionSpecification second) => TypeDescriptor.Create(second.TargetType, second.Max));
			return descriptor.WithNextValue(nextValue);
		});
	}
}
