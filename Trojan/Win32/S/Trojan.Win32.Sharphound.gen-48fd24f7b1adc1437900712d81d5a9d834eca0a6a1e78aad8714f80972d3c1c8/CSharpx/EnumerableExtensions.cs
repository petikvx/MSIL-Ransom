using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CSharpx;

internal static class EnumerableExtensions
{
	private class MaterializedEnumerable<T> : IEnumerable<T>, IEnumerable
	{
		private readonly ICollection<T> inner;

		public MaterializedEnumerable(IEnumerable<T> enumerable)
		{
			inner = (enumerable as ICollection<T>) ?? Enumerable.ToArray(enumerable);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return inner.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	private static readonly Func<int, int, Exception> OnFolderSourceSizeErrorSelector = OnFolderSourceSizeError;

	private static IEnumerable<TSource> AssertCountImpl<TSource>(IEnumerable<TSource> source, int count, Func<int, int, Exception> errorSelector)
	{
		if (source is ICollection<TSource> collection)
		{
			if (collection.Count != count)
			{
				throw errorSelector(collection.Count.CompareTo(count), count);
			}
			return source;
		}
		return ExpectingCountYieldingImpl(source, count, errorSelector);
	}

	private static IEnumerable<TSource> ExpectingCountYieldingImpl<TSource>(IEnumerable<TSource> source, int count, Func<int, int, Exception> errorSelector)
	{
		int iterations = 0;
		foreach (TSource item in source)
		{
			iterations++;
			if (iterations > count)
			{
				throw errorSelector(1, count);
			}
			yield return item;
		}
		if (iterations != count)
		{
			throw errorSelector(-1, count);
		}
	}

	public static IEnumerable<TResult> Cartesian<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
	{
		if (first == null)
		{
			throw new ArgumentNullException("first");
		}
		if (second == null)
		{
			throw new ArgumentNullException("second");
		}
		if (resultSelector == null)
		{
			throw new ArgumentNullException("resultSelector");
		}
		return Enumerable.SelectMany(first, (TFirst item1) => second, (TFirst item1, TSecond item2) => resultSelector(item1, item2));
	}

	public static IEnumerable<TSource> Prepend<TSource>(this IEnumerable<TSource> source, TSource value)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return Enumerable.Concat(Enumerable.Repeat(value, 1), source);
	}

	public static IEnumerable<T> Concat<T>(this T head, IEnumerable<T> tail)
	{
		if (tail == null)
		{
			throw new ArgumentNullException("tail");
		}
		return tail.Prepend(head);
	}

	public static IEnumerable<T> Concat<T>(this IEnumerable<T> head, T tail)
	{
		if (head == null)
		{
			throw new ArgumentNullException("head");
		}
		return Enumerable.Concat(head, Enumerable.Repeat(tail, 1));
	}

	public static IEnumerable<T> Exclude<T>(this IEnumerable<T> sequence, int startIndex, int count)
	{
		if (sequence == null)
		{
			throw new ArgumentNullException("sequence");
		}
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		return ExcludeImpl(sequence, startIndex, count);
	}

	private static IEnumerable<T> ExcludeImpl<T>(IEnumerable<T> sequence, int startIndex, int count)
	{
		int index = -1;
		int endIndex = startIndex + count;
		using IEnumerator<T> iter = sequence.GetEnumerator();
		int num;
		while (iter.MoveNext())
		{
			num = index + 1;
			index = num;
			if (num >= startIndex)
			{
				break;
			}
			yield return iter.Current;
		}
		do
		{
			num = index + 1;
			index = num;
		}
		while (num < endIndex && iter.MoveNext());
		while (iter.MoveNext())
		{
			yield return iter.Current;
		}
	}

	public static IEnumerable<KeyValuePair<int, TSource>> Index<TSource>(this IEnumerable<TSource> source)
	{
		return source.Index(0);
	}

	public static IEnumerable<KeyValuePair<int, TSource>> Index<TSource>(this IEnumerable<TSource> source, int startIndex)
	{
		return Enumerable.Select(source, (TSource item, int index) => new KeyValuePair<int, TSource>(startIndex + index, item));
	}

	public static TResult Fold<T, TResult>(this IEnumerable<T> source, Func<T, TResult> folder)
	{
		return FoldImpl(source, 1, folder, null, null, null);
	}

	public static TResult Fold<T, TResult>(this IEnumerable<T> source, Func<T, T, TResult> folder)
	{
		return FoldImpl(source, 2, null, folder, null, null);
	}

	public static TResult Fold<T, TResult>(this IEnumerable<T> source, Func<T, T, T, TResult> folder)
	{
		return FoldImpl(source, 3, null, null, folder, null);
	}

	public static TResult Fold<T, TResult>(this IEnumerable<T> source, Func<T, T, T, T, TResult> folder)
	{
		return FoldImpl(source, 4, null, null, null, folder);
	}

	private static TResult FoldImpl<T, TResult>(IEnumerable<T> source, int count, Func<T, TResult> folder1, Func<T, T, TResult> folder2, Func<T, T, T, TResult> folder3, Func<T, T, T, T, TResult> folder4)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if ((count == 1 && folder1 == null) || (count == 2 && folder2 == null) || (count == 3 && folder3 == null) || (count == 4 && folder4 == null))
		{
			throw new ArgumentNullException("folder");
		}
		T[] array = new T[count];
		foreach (KeyValuePair<int, T> item in AssertCountImpl(source.Index(), count, OnFolderSourceSizeErrorSelector))
		{
			array[item.Key] = item.Value;
		}
		return count switch
		{
			1 => folder1(array[0]), 
			2 => folder2(array[0], array[1]), 
			3 => folder3(array[0], array[1], array[2]), 
			4 => folder4(array[0], array[1], array[2], array[3]), 
			_ => throw new NotSupportedException(), 
		};
	}

	private static Exception OnFolderSourceSizeError(int cmp, int count)
	{
		return new Exception(string.Format((cmp < 0) ? "Sequence contains too few elements when exactly {0} {1} expected." : "Sequence contains too many elements when exactly {0} {1} expected.", count.ToString("N0"), (count == 1) ? "was" : "were"));
	}

	public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		foreach (T item in source)
		{
			action(item);
		}
	}

	public static IEnumerable<TResult> Pairwise<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TSource, TResult> resultSelector)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (resultSelector == null)
		{
			throw new ArgumentNullException("resultSelector");
		}
		return source.PairwiseImpl(resultSelector);
	}

	private static IEnumerable<TResult> PairwiseImpl<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TSource, TResult> resultSelector)
	{
		using IEnumerator<TSource> e = source.GetEnumerator();
		if (e.MoveNext())
		{
			TSource current = e.Current;
			while (e.MoveNext())
			{
				yield return resultSelector(current, e.Current);
				current = e.Current;
			}
			yield break;
		}
	}

	public static string ToDelimitedString<TSource>(this IEnumerable<TSource> source)
	{
		return source.ToDelimitedString(null);
	}

	public static string ToDelimitedString<TSource>(this IEnumerable<TSource> source, string delimiter)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return ToDelimitedStringImpl(source, delimiter, (StringBuilder sb, TSource e) => sb.Append(e));
	}

	private static string ToDelimitedStringImpl<T>(IEnumerable<T> source, string delimiter, Func<StringBuilder, T, StringBuilder> append)
	{
		delimiter = delimiter ?? CultureInfo.CurrentCulture.TextInfo.ListSeparator;
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		foreach (T item in source)
		{
			if (num++ > 0)
			{
				stringBuilder.Append(delimiter);
			}
			append(stringBuilder, item);
		}
		return stringBuilder.ToString();
	}

	public static Maybe<T> TryHead<T>(this IEnumerable<T> source)
	{
		using IEnumerator<T> enumerator = source.GetEnumerator();
		return enumerator.MoveNext() ? Maybe.Just(enumerator.Current) : Maybe.Nothing<T>();
	}

	public static Maybe<IEnumerable<T>> ToMaybe<T>(this IEnumerable<T> source)
	{
		using IEnumerator<T> enumerator = source.GetEnumerator();
		return enumerator.MoveNext() ? Maybe.Just(source) : Maybe.Nothing<IEnumerable<T>>();
	}

	public static IEnumerable<T> Tail<T>(this IEnumerable<T> source)
	{
		using IEnumerator<T> e = source.GetEnumerator();
		if (e.MoveNext())
		{
			while (e.MoveNext())
			{
				yield return e.Current;
			}
			yield break;
		}
		throw new ArgumentException("Source sequence cannot be empty.", "source");
	}

	public static IEnumerable<T> TailNoFail<T>(this IEnumerable<T> source)
	{
		using IEnumerator<T> e = source.GetEnumerator();
		if (e.MoveNext())
		{
			while (e.MoveNext())
			{
				yield return e.Current;
			}
		}
	}

	public static IEnumerable<T> Memorize<T>(this IEnumerable<T> source)
	{
		if (!source.GetType().IsArray)
		{
			return Enumerable.ToArray(source);
		}
		return source;
	}

	public static IEnumerable<T> Materialize<T>(this IEnumerable<T> source)
	{
		if (!(source is MaterializedEnumerable<T>) && !source.GetType().IsArray)
		{
			return new MaterializedEnumerable<T>(source);
		}
		return source;
	}
}
