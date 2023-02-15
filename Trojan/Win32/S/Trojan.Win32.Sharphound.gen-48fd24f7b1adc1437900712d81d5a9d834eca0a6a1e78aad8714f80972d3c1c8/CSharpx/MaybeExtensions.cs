using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpx;

internal static class MaybeExtensions
{
	public static void Match<T>(this Maybe<T> maybe, Action<T> ifJust, Action ifNothing)
	{
		if (maybe.MatchJust(out var value))
		{
			ifJust(value);
		}
		else
		{
			ifNothing();
		}
	}

	public static void Match<T1, T2>(this Maybe<Tuple<T1, T2>> maybe, Action<T1, T2> ifJust, Action ifNothing)
	{
		if (maybe.MatchJust(out var value, out var value2))
		{
			ifJust(value, value2);
		}
		else
		{
			ifNothing();
		}
	}

	public static bool MatchJust<T1, T2>(this Maybe<Tuple<T1, T2>> maybe, out T1 value1, out T2 value2)
	{
		if (maybe.MatchJust(out var value3))
		{
			value1 = value3.Item1;
			value2 = value3.Item2;
			return true;
		}
		value1 = default(T1);
		value2 = default(T2);
		return false;
	}

	public static Maybe<T> ToMaybe<T>(this T value)
	{
		return Maybe.Return(value);
	}

	public static Maybe<T2> Bind<T1, T2>(this Maybe<T1> maybe, Func<T1, Maybe<T2>> func)
	{
		return Maybe.Bind(maybe, func);
	}

	public static Maybe<T2> Map<T1, T2>(this Maybe<T1> maybe, Func<T1, T2> func)
	{
		return Maybe.Map(maybe, func);
	}

	public static Maybe<TResult> Select<TSource, TResult>(this Maybe<TSource> maybe, Func<TSource, TResult> selector)
	{
		return Maybe.Map(maybe, selector);
	}

	public static Maybe<TResult> SelectMany<TSource, TValue, TResult>(this Maybe<TSource> maybe, Func<TSource, Maybe<TValue>> valueSelector, Func<TSource, TValue, TResult> resultSelector)
	{
		return maybe.Bind((TSource sourceValue) => valueSelector(sourceValue).Map((TValue resultValue) => resultSelector(sourceValue, resultValue)));
	}

	public static void Do<T>(this Maybe<T> maybe, Action<T> action)
	{
		if (maybe.MatchJust(out var value))
		{
			action(value);
		}
	}

	public static void Do<T1, T2>(this Maybe<Tuple<T1, T2>> maybe, Action<T1, T2> action)
	{
		if (maybe.MatchJust(out var value, out var value2))
		{
			action(value, value2);
		}
	}

	public static bool IsJust<T>(this Maybe<T> maybe)
	{
		return maybe.Tag == MaybeType.Just;
	}

	public static bool IsNothing<T>(this Maybe<T> maybe)
	{
		return maybe.Tag == MaybeType.Nothing;
	}

	public static T FromJust<T>(this Maybe<T> maybe)
	{
		if (maybe.MatchJust(out var value))
		{
			return value;
		}
		return default(T);
	}

	public static T FromJustOrFail<T>(this Maybe<T> maybe, Exception exceptionToThrow = null)
	{
		if (!maybe.MatchJust(out var value))
		{
			throw exceptionToThrow ?? new ArgumentException("Value empty.");
		}
		return value;
	}

	public static T GetValueOrDefault<T>(this Maybe<T> maybe, T noneValue)
	{
		if (!maybe.MatchJust(out var value))
		{
			return noneValue;
		}
		return value;
	}

	public static T2 MapValueOrDefault<T1, T2>(this Maybe<T1> maybe, Func<T1, T2> func, T2 noneValue)
	{
		if (!maybe.MatchJust(out var value))
		{
			return noneValue;
		}
		return func(value);
	}

	public static IEnumerable<T> ToEnumerable<T>(this Maybe<T> maybe)
	{
		if (maybe.MatchJust(out var value))
		{
			return Enumerable.Concat(Enumerable.Empty<T>(), new T[1] { value });
		}
		return Enumerable.Empty<T>();
	}
}
