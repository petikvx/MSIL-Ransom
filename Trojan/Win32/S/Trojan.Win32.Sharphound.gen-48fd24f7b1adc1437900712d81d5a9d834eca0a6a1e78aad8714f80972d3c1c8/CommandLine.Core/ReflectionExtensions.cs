using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using CSharpx;
using CommandLine.Infrastructure;
using CommandLine.Text;

namespace CommandLine.Core;

internal static class ReflectionExtensions
{
	public static IEnumerable<T> GetSpecifications<T>(this Type type, Func<PropertyInfo, T> selector)
	{
		return Enumerable.Select(Enumerable.GroupBy(Enumerable.Where(Enumerable.Select(Enumerable.SelectMany(type.FlattenHierarchy(), (Type x) => x.GetTypeInfo().GetProperties()), (PropertyInfo pi) => new
		{
			pi = pi,
			attrs = pi.GetCustomAttributes(inherit: true)
		}), _003C_003Eh__TransparentIdentifier0 => Enumerable.Any(Enumerable.OfType<OptionAttribute>(_003C_003Eh__TransparentIdentifier0.attrs)) || Enumerable.Any(Enumerable.OfType<ValueAttribute>(_003C_003Eh__TransparentIdentifier0.attrs))), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.pi.Name, _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.pi), (IGrouping<string, PropertyInfo> g) => selector(Enumerable.First(g)));
	}

	public static Maybe<VerbAttribute> GetVerbSpecification(this Type type)
	{
		return Enumerable.SingleOrDefault(Enumerable.Select(Enumerable.Select(Enumerable.SelectMany(type.FlattenHierarchy(), (Type x) => x.GetTypeInfo().GetCustomAttributes(typeof(VerbAttribute), inherit: true)), (object attr) => new
		{
			attr = attr,
			vattr = (VerbAttribute)attr
		}), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.vattr)).ToMaybe();
	}

	public static Maybe<Tuple<PropertyInfo, UsageAttribute>> GetUsageData(this Type type)
	{
		return Enumerable.SingleOrDefault(Enumerable.Select(Enumerable.Where(Enumerable.Select(Enumerable.SelectMany(type.FlattenHierarchy(), (Type x) => x.GetTypeInfo().GetProperties()), (PropertyInfo pi) => new
		{
			pi = pi,
			attrs = pi.GetCustomAttributes(inherit: true)
		}), _003C_003Eh__TransparentIdentifier0 => Enumerable.Any(Enumerable.OfType<UsageAttribute>(_003C_003Eh__TransparentIdentifier0.attrs))), _003C_003Eh__TransparentIdentifier0 => Tuple.Create(_003C_003Eh__TransparentIdentifier0.pi, (UsageAttribute)Enumerable.First(_003C_003Eh__TransparentIdentifier0.attrs)))).ToMaybe();
	}

	private static IEnumerable<Type> FlattenHierarchy(this Type type)
	{
		if (type == null)
		{
			yield break;
		}
		yield return type;
		foreach (Type item in type.SafeGetInterfaces())
		{
			yield return item;
		}
		foreach (Type item2 in type.GetTypeInfo().BaseType.FlattenHierarchy())
		{
			yield return item2;
		}
	}

	private static IEnumerable<Type> SafeGetInterfaces(this Type type)
	{
		if (!(type == null))
		{
			return type.GetTypeInfo().GetInterfaces();
		}
		return Enumerable.Empty<Type>();
	}

	public static TargetType ToTargetType(this Type type)
	{
		if (!(type == typeof(bool)))
		{
			if (!(type == typeof(string)))
			{
				if (!type.IsArray && !typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(type))
				{
					return TargetType.Scalar;
				}
				return TargetType.Sequence;
			}
			return TargetType.Scalar;
		}
		return TargetType.Switch;
	}

	public static IEnumerable<Error> SetProperties<T>(this T instance, IEnumerable<SpecificationProperty> specProps, Func<SpecificationProperty, bool> predicate, Func<SpecificationProperty, object> selector)
	{
		return Enumerable.SelectMany(Enumerable.Where(specProps, predicate), (SpecificationProperty specProp) => specProp.SetValue(instance, selector(specProp)));
	}

	private static IEnumerable<Error> SetValue<T>(this SpecificationProperty specProp, T instance, object value)
	{
		try
		{
			specProp.Property.SetValue(instance, value, null);
			return Enumerable.Empty<Error>();
		}
		catch (TargetInvocationException ex)
		{
			return new SetValueExceptionError[1]
			{
				new SetValueExceptionError(specProp.Specification.FromSpecification(), ex.InnerException, value)
			};
		}
		catch (ArgumentException innerException)
		{
			ArgumentException exception = new ArgumentException("Check if Option or Value attribute values are set properly for the given type.", innerException);
			return new SetValueExceptionError[1]
			{
				new SetValueExceptionError(specProp.Specification.FromSpecification(), exception, value)
			};
		}
		catch (Exception exception2)
		{
			return new SetValueExceptionError[1]
			{
				new SetValueExceptionError(specProp.Specification.FromSpecification(), exception2, value)
			};
		}
	}

	public static object CreateEmptyArray(this Type type)
	{
		return Array.CreateInstance(type, 0);
	}

	public static object GetDefaultValue(this Type type)
	{
		return Expression.Lambda<Func<object>>(Expression.Convert(Expression.Default(type), typeof(object)), new ParameterExpression[0]).Compile()();
	}

	public static bool IsMutable(this Type type)
	{
		if (type == typeof(object))
		{
			return true;
		}
		return Enumerable.Any(type.GetTypeInfo().GetProperties(BindingFlags.Instance | BindingFlags.Public), (PropertyInfo p) => p.CanWrite) | Enumerable.Any(type.GetTypeInfo().GetFields(BindingFlags.Instance | BindingFlags.Public));
	}

	public static object CreateDefaultForImmutable(this Type type)
	{
		if (type.GetTypeInfo().IsGenericType && type.GetTypeInfo().GetGenericTypeDefinition() == typeof(IEnumerable<>))
		{
			return type.GetTypeInfo().GetGenericArguments()[0].CreateEmptyArray();
		}
		return type.GetDefaultValue();
	}

	public static object AutoDefault(this Type type)
	{
		if (type.IsMutable())
		{
			return Activator.CreateInstance(type);
		}
		Type[] constructorTypes = Enumerable.ToArray(type.GetSpecifications((PropertyInfo pi) => pi.PropertyType));
		return ReflectionHelper.CreateDefaultImmutableInstance(type, constructorTypes);
	}

	public static TypeInfo ToTypeInfo(this Type type)
	{
		return TypeInfo.Create(type);
	}

	public static object StaticMethod(this Type type, string name, params object[] args)
	{
		return type.GetTypeInfo().InvokeMember(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, args);
	}

	public static object StaticProperty(this Type type, string name)
	{
		return type.GetTypeInfo().InvokeMember(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.GetProperty, null, null, new object[0]);
	}

	public static object InstanceProperty(this Type type, string name, object target)
	{
		return type.GetTypeInfo().InvokeMember(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty, null, target, new object[0]);
	}

	public static bool IsPrimitiveEx(this Type type)
	{
		if ((!type.GetTypeInfo().IsValueType || !(type != typeof(Guid))) && !type.GetTypeInfo().IsPrimitive && !Enumerable.Contains(new Type[5]
		{
			typeof(string),
			typeof(decimal),
			typeof(DateTime),
			typeof(DateTimeOffset),
			typeof(TimeSpan)
		}, type))
		{
			return Convert.GetTypeCode(type) != TypeCode.Object;
		}
		return true;
	}
}
