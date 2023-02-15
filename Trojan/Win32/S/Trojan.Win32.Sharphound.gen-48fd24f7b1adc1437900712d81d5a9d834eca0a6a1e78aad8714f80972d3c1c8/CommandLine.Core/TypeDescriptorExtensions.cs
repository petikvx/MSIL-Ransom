using CSharpx;

namespace CommandLine.Core;

internal static class TypeDescriptorExtensions
{
	public static TypeDescriptor WithNextValue(this TypeDescriptor descriptor, Maybe<TypeDescriptor> nextValue)
	{
		return TypeDescriptor.Create(descriptor.TargetType, descriptor.MaxItems, nextValue.GetValueOrDefault(default(TypeDescriptor)));
	}
}
