using System;
using System.Collections;
using System.Collections.Generic;

namespace GraphComposite;

public abstract class ConvertToGraph<T, Tkey, Tval>
{
	private IEqualityComparer<Tkey> comparer = null;

	protected ConvertToGraph()
	{
	}

	protected ConvertToGraph(IEqualityComparer<Tkey> comp)
	{
		comparer = comp;
	}

	public GraphComposite<Tkey, Tval> Convert(T source)
	{
		Tkey key = GetKey(source);
		GraphCompositeBuilder<Tkey, Tval> graphCompositeBuilder = new GraphCompositeBuilder<Tkey, Tval>(comparer, key, GetValue(source));
		IEnumerator<T> enumerator = Elements(source).GetEnumerator();
		try
		{
			while (ConvertToGraph<T, Tkey, Tval>._206A_202D_206D_200F_200E_200C_202A_202A_206C_202C_200F_200C_202A_202C_202D_200D_202C_200E_202B_206D_202A_202B_202E_200B_206E_206F_206D_206F_200B_202D_200D_206F_202D_200E_200F_206D_200E_206B_206A_202A_202E((IEnumerator)enumerator))
			{
				T current = enumerator.Current;
				ProcessNode(graphCompositeBuilder, key, current);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				ConvertToGraph<T, Tkey, Tval>._202E_200D_200C_200E_200E_206B_206C_200C_206C_206C_202D_206F_200D_200F_206A_206C_200E_202B_206B_200D_202B_202C_200F_200C_202D_202D_200E_202C_206C_202E_206D_202B_200C_200E_202E_206C_206D_206E_206B_200F_202E((IDisposable)enumerator);
			}
		}
		AddEdges(graphCompositeBuilder, source, key);
		return graphCompositeBuilder.GenerateCopy();
	}

	protected abstract Tkey GetKey(T x);

	protected abstract Tval GetValue(T x);

	protected abstract IEnumerable<T> Elements(T x);

	protected abstract IEnumerable<T> OutgoingEdges(T x);

	private void ProcessNode(GraphCompositeBuilder<Tkey, Tval> builder, Tkey currentParent, T node)
	{
		List<T> list = new List<T>(Elements(node));
		Tkey key = GetKey(node);
		builder.AddNode(currentParent, key, GetValue(node), list.Count > 0);
		foreach (T item in list)
		{
			ProcessNode(builder, key, item);
		}
	}

	private void AddEdges(GraphCompositeBuilder<Tkey, Tval> builder, T source, Tkey sourceKey)
	{
		IEnumerator<T> enumerator = OutgoingEdges(source).GetEnumerator();
		try
		{
			while (ConvertToGraph<T, Tkey, Tval>._206A_202D_206D_200F_200E_200C_202A_202A_206C_202C_200F_200C_202A_202C_202D_200D_202C_200E_202B_206D_202A_202B_202E_200B_206E_206F_206D_206F_200B_202D_200D_206F_202D_200E_200F_206D_200E_206B_206A_202A_202E((IEnumerator)enumerator))
			{
				T current = enumerator.Current;
				builder.AddEdge(sourceKey, GetKey(current));
			}
		}
		finally
		{
			if (enumerator != null)
			{
				ConvertToGraph<T, Tkey, Tval>._202E_200D_200C_200E_200E_206B_206C_200C_206C_206C_202D_206F_200D_200F_206A_206C_200E_202B_206B_200D_202B_202C_200F_200C_202D_202D_200E_202C_206C_202E_206D_202B_200C_200E_202E_206C_206D_206E_206B_200F_202E((IDisposable)enumerator);
			}
		}
		IEnumerator<T> enumerator2 = Elements(source).GetEnumerator();
		try
		{
			while (ConvertToGraph<T, Tkey, Tval>._206A_202D_206D_200F_200E_200C_202A_202A_206C_202C_200F_200C_202A_202C_202D_200D_202C_200E_202B_206D_202A_202B_202E_200B_206E_206F_206D_206F_200B_202D_200D_206F_202D_200E_200F_206D_200E_206B_206A_202A_202E((IEnumerator)enumerator2))
			{
				T current2 = enumerator2.Current;
				AddEdges(builder, current2, GetKey(current2));
			}
		}
		finally
		{
			if (enumerator2 != null)
			{
				ConvertToGraph<T, Tkey, Tval>._202E_200D_200C_200E_200E_206B_206C_200C_206C_206C_202D_206F_200D_200F_206A_206C_200E_202B_206B_200D_202B_202C_200F_200C_202D_202D_200E_202C_206C_202E_206D_202B_200C_200E_202E_206C_206D_206E_206B_200F_202E((IDisposable)enumerator2);
			}
		}
	}
}
