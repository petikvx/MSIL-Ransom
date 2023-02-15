using System;
using System.Reflection;
using CSharpx;

namespace CommandLine.Core;

internal class SpecificationProperty
{
	private readonly Specification specification;

	private readonly PropertyInfo property;

	private readonly Maybe<object> value;

	public Specification Specification => specification;

	public PropertyInfo Property => property;

	public Maybe<object> Value => value;

	private SpecificationProperty(Specification specification, PropertyInfo property, Maybe<object> value)
	{
		this.property = property;
		this.specification = specification;
		this.value = value;
	}

	public static SpecificationProperty Create(Specification specification, PropertyInfo property, Maybe<object> value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return new SpecificationProperty(specification, property, value);
	}
}
