using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandLine.Infrastructure;

internal static class EnumerableExtensions
{
	public static int IndexOf<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		int num = -1;
		foreach (TSource item in source)
		{
			num++;
			if (predicate(item))
			{
				return num;
			}
		}
		return num;
	}

	public static object ToUntypedArray(this IEnumerable<object> value, Type type)
	{
		Array array = Array.CreateInstance(type, Enumerable.Count(value));
		Enumerable.ToArray(value).CopyTo(array, 0);
		return array;
	}

	public static bool Empty<TSource>(this IEnumerable<TSource> source)
	{
		return !Enumerable.Any(source);
	}

	public static IEnumerable<T[]> Group<T>(this IEnumerable<T> source, int groupSize)
	{
		if (groupSize < 1)
		{
			throw new ArgumentOutOfRangeException("groupSize");
		}
		T[] array = new T[groupSize];
		int num = 0;
		foreach (T item in source)
		{
			array[num++] = item;
			if (num == groupSize)
			{
				yield return array;
				array = new T[groupSize];
				num = 0;
			}
		}
	}
}
