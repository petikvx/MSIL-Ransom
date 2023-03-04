using System;
using System.Collections.Generic;

namespace GraphComposite;

public class GraphCompositeTraversal<Tkey, Tval>
{
	public static void TraverseSubgraphs(GraphComposite<Tkey, Tval> c, Action<GraphComposite<Tkey, Tval>> onSelf, Action<GraphComposite<Tkey, Tval>> onGraphEntry, Action<GraphComposite<Tkey, Tval>> onGraphExit)
	{
		onSelf?.Invoke(c);
		if (!c.IsGraph)
		{
			return;
		}
		onGraphEntry?.Invoke(c);
		foreach (GraphComposite<Tkey, Tval> item in c.Subgraph)
		{
			TraverseSubgraphs(item, onSelf, onGraphEntry, onGraphExit);
		}
		onGraphExit?.Invoke(c);
	}

	public static void PathTraverse(GraphComposite<Tkey, Tval> startC, Action<GraphComposite<Tkey, Tval>> a)
	{
		List<GraphComposite<Tkey, Tval>> l = new List<GraphComposite<Tkey, Tval>>();
		PathTraverse(startC, a, l);
	}

	public static GraphComposite<Tkey, Tval> FindFirstOnPaths(GraphComposite<Tkey, Tval> startC, Func<GraphComposite<Tkey, Tval>, bool> f)
	{
		if (f(startC))
		{
			return startC;
		}
		foreach (GraphComposite<Tkey, Tval> item in startC.Outgoing)
		{
			GraphComposite<Tkey, Tval> graphComposite = FindFirstOnPaths(item, f);
			if (graphComposite != null)
			{
				return graphComposite;
			}
		}
		return null;
	}

	private static void PathTraverse(GraphComposite<Tkey, Tval> startC, Action<GraphComposite<Tkey, Tval>> a, List<GraphComposite<Tkey, Tval>> l)
	{
		if (l.Contains(startC))
		{
			return;
		}
		l.Add(startC);
		a(startC);
		foreach (GraphComposite<Tkey, Tval> item in startC.Outgoing)
		{
			PathTraverse(item, a, l);
		}
	}
}
