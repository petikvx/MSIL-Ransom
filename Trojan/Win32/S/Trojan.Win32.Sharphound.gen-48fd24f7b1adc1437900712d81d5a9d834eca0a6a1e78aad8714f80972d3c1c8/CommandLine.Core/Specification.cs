using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CSharpx;
using CommandLine.Infrastructure;

namespace CommandLine.Core;

internal abstract class Specification
{
	private readonly SpecificationType tag;

	private readonly bool required;

	private readonly bool hidden;

	private readonly Maybe<int> min;

	private readonly Maybe<int> max;

	private readonly Maybe<object> defaultValue;

	private readonly string helpText;

	private readonly string metaValue;

	private readonly IEnumerable<string> enumValues;

	private readonly Type conversionType;

	private readonly TargetType targetType;

	public SpecificationType Tag => tag;

	public bool Required => required;

	public Maybe<int> Min => min;

	public Maybe<int> Max => max;

	public Maybe<object> DefaultValue => defaultValue;

	public string HelpText => helpText;

	public string MetaValue => metaValue;

	public IEnumerable<string> EnumValues => enumValues;

	public Type ConversionType => conversionType;

	public TargetType TargetType => targetType;

	public bool Hidden => hidden;

	protected Specification(SpecificationType tag, bool required, Maybe<int> min, Maybe<int> max, Maybe<object> defaultValue, string helpText, string metaValue, IEnumerable<string> enumValues, Type conversionType, TargetType targetType, bool hidden = false)
	{
		this.tag = tag;
		this.required = required;
		this.min = min;
		this.max = max;
		this.defaultValue = defaultValue;
		this.conversionType = conversionType;
		this.targetType = targetType;
		this.helpText = helpText;
		this.metaValue = metaValue;
		this.enumValues = enumValues;
		this.hidden = hidden;
	}

	public static Specification FromProperty(PropertyInfo property)
	{
		object[] customAttributes = property.GetCustomAttributes(inherit: true);
		IEnumerable<OptionAttribute> source = Enumerable.OfType<OptionAttribute>(customAttributes);
		if (Enumerable.Count(source) == 1)
		{
			OptionSpecification optionSpecification = OptionSpecification.FromAttribute(Enumerable.Single(source), property.PropertyType, ReflectionHelper.GetNamesOfEnum(property.PropertyType));
			if (optionSpecification.ShortName.Length == 0 && optionSpecification.LongName.Length == 0)
			{
				return optionSpecification.WithLongName(property.Name.ToLowerInvariant());
			}
			return optionSpecification;
		}
		IEnumerable<ValueAttribute> source2 = Enumerable.OfType<ValueAttribute>(customAttributes);
		if (Enumerable.Count(source2) == 1)
		{
			ValueAttribute attribute = Enumerable.Single(source2);
			Type propertyType = property.PropertyType;
			IEnumerable<string> enumerable;
			if (!property.PropertyType.GetTypeInfo().IsEnum)
			{
				enumerable = Enumerable.Empty<string>();
			}
			else
			{
				IEnumerable<string> names = Enum.GetNames(property.PropertyType);
				enumerable = names;
			}
			return ValueSpecification.FromAttribute(attribute, propertyType, enumerable);
		}
		throw new InvalidOperationException();
	}
}
