using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CSharpx;

namespace CommandLine.Core;

internal static class SpecificationPropertyExtensions
{
	public static SpecificationProperty WithSpecification(this SpecificationProperty specProp, Specification newSpecification)
	{
		if (newSpecification == null)
		{
			throw new ArgumentNullException("newSpecification");
		}
		return SpecificationProperty.Create(newSpecification, specProp.Property, specProp.Value);
	}

	public static SpecificationProperty WithValue(this SpecificationProperty specProp, Maybe<object> newValue)
	{
		if (newValue == null)
		{
			throw new ArgumentNullException("newValue");
		}
		return SpecificationProperty.Create(specProp.Specification, specProp.Property, newValue);
	}

	public static Type GetConversionType(this SpecificationProperty specProp)
	{
		if (specProp.Specification.TargetType == TargetType.Sequence)
		{
			return Enumerable.SingleOrDefault(specProp.Property.PropertyType.GetTypeInfo().GetGenericArguments()).ToMaybe().FromJustOrFail(new InvalidOperationException("Sequence properties should be of type IEnumerable<T>."));
		}
		return specProp.Property.PropertyType;
	}

	public static IEnumerable<Error> Validate(this IEnumerable<SpecificationProperty> specProps, IEnumerable<Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>>> rules)
	{
		return Enumerable.SelectMany(rules, (Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>> rule) => rule(specProps));
	}
}
