using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using CSharpx;
using CommandLine.Infrastructure;
using RailwaySharp.ErrorHandling;

namespace CommandLine.Core;

internal static class TypeConverter
{
	public static Maybe<object> ChangeType(IEnumerable<string> values, Type conversionType, bool scalar, CultureInfo conversionCulture, bool ignoreValueCase)
	{
		if (!scalar)
		{
			return ChangeTypeSequence(values, conversionType, conversionCulture, ignoreValueCase);
		}
		return ChangeTypeScalar(Enumerable.Single(values), conversionType, conversionCulture, ignoreValueCase);
	}

	private static Maybe<object> ChangeTypeSequence(IEnumerable<string> values, Type conversionType, CultureInfo conversionCulture, bool ignoreValueCase)
	{
		Type type = Enumerable.SingleOrDefault(conversionType.GetTypeInfo().GetGenericArguments()).ToMaybe().FromJustOrFail(new InvalidOperationException("Non scalar properties should be sequence of type IEnumerable<T>."));
		IEnumerable<Maybe<object>> source = Enumerable.Select(values, (string value) => ChangeTypeScalar(value, type, conversionCulture, ignoreValueCase));
		if (!Enumerable.Any(source, (Maybe<object> a) => a.MatchNothing()))
		{
			return Maybe.Just(Enumerable.Select(source, (Maybe<object> c) => ((Just<object>)c).Value).ToUntypedArray(type));
		}
		return Maybe.Nothing<object>();
	}

	private static Maybe<object> ChangeTypeScalar(string value, Type conversionType, CultureInfo conversionCulture, bool ignoreValueCase)
	{
		Result<object, Exception> result = ChangeTypeScalarImpl(value, conversionType, conversionCulture, ignoreValueCase);
		result.Match(delegate
		{
		}, delegate(IEnumerable<Exception> e)
		{
			Enumerable.First(e).RethrowWhenAbsentIn(new Type[3]
			{
				typeof(InvalidCastException),
				typeof(FormatException),
				typeof(OverflowException)
			});
		});
		return result.ToMaybe();
	}

	private static object ConvertString(string value, Type type, CultureInfo conversionCulture)
	{
		try
		{
			return Convert.ChangeType(value, type, conversionCulture);
		}
		catch (InvalidCastException)
		{
			return System.ComponentModel.TypeDescriptor.GetConverter(type).ConvertFrom(null, conversionCulture, value);
		}
	}

	private static Result<object, Exception> ChangeTypeScalarImpl(string value, Type conversionType, CultureInfo conversionCulture, bool ignoreValueCase)
	{
		Func<object> func = delegate
		{
			Func<object> func3 = delegate
			{
				ReflectionHelper.IsFSharpOptionType(conversionType);
				Func<Type> func4 = () => Nullable.GetUnderlyingType(conversionType);
				Type type = func4() ?? conversionType;
				Func<object> func5 = () => ConvertString(value, type, conversionCulture);
				Func<object> func6 = () => null;
				return (value != null) ? func5() : func6();
			};
			if (value.IsBooleanString() && conversionType == typeof(bool))
			{
				return value.ToBoolean();
			}
			return (!conversionType.GetTypeInfo().IsEnum) ? func3() : value.ToEnum(conversionType, ignoreValueCase);
		};
		Func<object> func2 = delegate
		{
			try
			{
				return conversionType.GetTypeInfo().GetConstructor(new Type[1] { typeof(string) })!.Invoke(new object[1] { value });
			}
			catch (Exception)
			{
				throw new FormatException("Destination conversion type must have a constructor that accepts a string.");
			}
		};
		return Result.Try((conversionType.IsPrimitiveEx() || ReflectionHelper.IsFSharpOptionType(conversionType)) ? func : func2);
	}

	private static object ToEnum(this string value, Type conversionType, bool ignoreValueCase)
	{
		object obj;
		try
		{
			obj = Enum.Parse(conversionType, value, ignoreValueCase);
		}
		catch (ArgumentException)
		{
			throw new FormatException();
		}
		if (!Enum.IsDefined(conversionType, obj))
		{
			throw new FormatException();
		}
		return obj;
	}
}
