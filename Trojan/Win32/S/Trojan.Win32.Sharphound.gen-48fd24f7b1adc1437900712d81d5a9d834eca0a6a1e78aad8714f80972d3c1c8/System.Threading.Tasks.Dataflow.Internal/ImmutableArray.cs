using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks.Dataflow.Internal;

[IsReadOnlyAttribute1]
[DebuggerDisplay("Count={Count}")]
internal struct ImmutableArray<T>
{
	private static readonly ImmutableArray<T> s_empty = new ImmutableArray<T>(new T[0]);

	private readonly T[] _array;

	public static ImmutableArray<T> Empty => s_empty;

	public int Count => _array.Length;

	private ImmutableArray(T[] elements)
	{
		_array = elements;
	}

	public ImmutableArray<T> Add(T item)
	{
		T[] array = new T[_array.Length + 1];
		Array.Copy(_array, 0, array, 0, _array.Length);
		array[^1] = item;
		return new ImmutableArray<T>(array);
	}

	public ImmutableArray<T> Remove(T item)
	{
		int num = Array.IndexOf(_array, item);
		if (num < 0)
		{
			return this;
		}
		if (_array.Length == 1)
		{
			return Empty;
		}
		T[] array = new T[_array.Length - 1];
		Array.Copy(_array, 0, array, 0, num);
		Array.Copy(_array, num + 1, array, num, _array.Length - num - 1);
		return new ImmutableArray<T>(array);
	}

	public bool Contains(T item)
	{
		return Array.IndexOf(_array, item) >= 0;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return ((IEnumerable<T>)_array).GetEnumerator();
	}

	public T[] ToArray()
	{
		if (_array.Length != 0)
		{
			return (T[])_array.Clone();
		}
		return s_empty._array;
	}
}
