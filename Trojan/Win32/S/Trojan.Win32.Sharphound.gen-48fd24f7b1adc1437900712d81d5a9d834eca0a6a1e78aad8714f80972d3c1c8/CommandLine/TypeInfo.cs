using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandLine;

public sealed class TypeInfo
{
	private readonly Type current;

	private readonly IEnumerable<Type> choices;

	public Type Current => current;

	public IEnumerable<Type> Choices => choices;

	private TypeInfo(Type current, IEnumerable<Type> choices)
	{
		this.current = current;
		this.choices = choices;
	}

	internal static TypeInfo Create(Type current)
	{
		return new TypeInfo(current, Enumerable.Empty<Type>());
	}

	internal static TypeInfo Create(Type current, IEnumerable<Type> choices)
	{
		return new TypeInfo(current, choices);
	}
}
