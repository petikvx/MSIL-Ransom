using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CSharpx;
using CommandLine.Core;

namespace CommandLine.Infrastructure;

internal static class ReflectionHelper
{
	[ThreadStatic]
	private static IDictionary<Type, Attribute> _overrides;

	public static void SetAttributeOverride(IEnumerable<Attribute> overrides)
	{
		if (overrides != null)
		{
			_overrides = Enumerable.ToDictionary(overrides, (Attribute attr) => attr.GetType(), (Attribute attr) => attr);
		}
		else
		{
			_overrides = null;
		}
	}

	public static Maybe<TAttribute> GetAttribute<TAttribute>() where TAttribute : Attribute
	{
		if (_overrides != null)
		{
			if (!_overrides.ContainsKey(typeof(TAttribute)))
			{
				return Maybe.Nothing<TAttribute>();
			}
			return Maybe.Just((TAttribute)_overrides[typeof(TAttribute)]);
		}
		TAttribute[] array = Enumerable.ToArray(GetExecutingOrEntryAssembly().GetCustomAttributes<TAttribute>());
		if (array.Length == 0)
		{
			return Maybe.Nothing<TAttribute>();
		}
		return Maybe.Just(array[0]);
	}

	public static string GetAssemblyName()
	{
		return GetExecutingOrEntryAssembly().GetName().Name;
	}

	public static string GetAssemblyVersion()
	{
		return GetExecutingOrEntryAssembly().GetName().Version.ToStringInvariant();
	}

	public static bool IsFSharpOptionType(Type type)
	{
		return type.FullName!.StartsWith("Microsoft.FSharp.Core.FSharpOption`1", StringComparison.Ordinal);
	}

	public static T CreateDefaultImmutableInstance<T>(Type[] constructorTypes)
	{
		return (T)CreateDefaultImmutableInstance(typeof(T), constructorTypes);
	}

	public static object CreateDefaultImmutableInstance(Type type, Type[] constructorTypes)
	{
		ConstructorInfo? constructor = type.GetTypeInfo().GetConstructor(constructorTypes);
		if (constructor == null)
		{
			throw new InvalidOperationException("Type " + type.FullName + " appears to be immutable, but no constructor found to accept values.");
		}
		object[] parameters = Enumerable.ToArray(Enumerable.Select(constructor!.GetParameters(), (ParameterInfo prms) => prms.ParameterType.CreateDefaultForImmutable()));
		return constructor!.Invoke(parameters);
	}

	private static Assembly GetExecutingOrEntryAssembly()
	{
		return Assembly.GetEntryAssembly() ?? Assembly.GetCallingAssembly();
	}

	public static IEnumerable<string> GetNamesOfEnum(Type t)
	{
		if (t.IsEnum)
		{
			return Enum.GetNames(t);
		}
		Type underlyingType = Nullable.GetUnderlyingType(t);
		if (underlyingType != null && underlyingType.IsEnum)
		{
			return Enum.GetNames(underlyingType);
		}
		return Enumerable.Empty<string>();
	}
}
