using System;
using CSharpx;

namespace CommandLine.Core;

internal struct TypeDescriptor
{
	private readonly TargetType targetType;

	private readonly Maybe<int> maxItems;

	private readonly Maybe<TypeDescriptor> nextValue;

	public TargetType TargetType => targetType;

	public Maybe<int> MaxItems => maxItems;

	public Maybe<TypeDescriptor> NextValue => nextValue;

	private TypeDescriptor(TargetType targetType, Maybe<int> maxItems, Maybe<TypeDescriptor> nextValue = null)
	{
		this.targetType = targetType;
		this.maxItems = maxItems;
		this.nextValue = nextValue;
	}

	public static TypeDescriptor Create(TargetType tag, Maybe<int> maximumItems, TypeDescriptor next = default(TypeDescriptor))
	{
		if (maximumItems == null)
		{
			throw new ArgumentNullException("maximumItems");
		}
		return new TypeDescriptor(tag, maximumItems, next.ToMaybe());
	}
}
