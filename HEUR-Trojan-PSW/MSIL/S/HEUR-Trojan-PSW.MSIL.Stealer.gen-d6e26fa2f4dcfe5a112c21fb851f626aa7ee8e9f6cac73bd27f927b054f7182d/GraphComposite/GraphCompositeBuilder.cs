using System;
using System.Collections.Generic;
using GraphComposite.Exceptions;

namespace GraphComposite;

public class GraphCompositeBuilder<Tkey, Tval>
{
	private GraphCompositeBuilderConfiguration config = new GraphCompositeBuilderConfiguration();

	private GraphComposite<Tkey, Tval> root;

	private Dictionary<Tkey, GraphComposite<Tkey, Tval>> allItems;

	private List<KeyValuePair<Tkey, Tkey>> allEdges = new List<KeyValuePair<Tkey, Tkey>>();

	public GraphCompositeBuilderConfiguration Configuration => config;

	public GraphCompositeBuilder(IEqualityComparer<Tkey> comparer, Tkey rootKey, Tval rootVal)
	{
		allItems = new Dictionary<Tkey, GraphComposite<Tkey, Tval>>(comparer);
		root = new GraphComposite<Tkey, Tval>(rootKey, rootVal, isGraph: true, null);
		allItems.Add(rootKey, root);
	}

	public GraphCompositeBuilder(GraphCompositeBuilderConfiguration cfg, IEqualityComparer<Tkey> comparer, Tkey rootKey, Tval rootVal)
		: this(comparer, rootKey, rootVal)
	{
		config = cfg;
	}

	public bool TryGetValue(Tkey key, out Tval value)
	{
		if (allItems.TryGetValue(key, out var value2))
		{
			value = value2.Value;
			return true;
		}
		value = default(Tval);
		return false;
	}

	public void AddNode(Tkey containingGraphKey, Tkey thisKey, Tval value, bool isGraph)
	{
		if (!allItems.TryGetValue(containingGraphKey, out var value2))
		{
			throw new KeyNotFoundGraphException(GraphCompositeBuilder<Tkey, Tval>._200D_206E_202E_206C_200C_202D_200E_200E_202A_200F_202C_202B_206B_206D_206C_200C_200E_206B_202C_206C_202D_202A_200E_206F_206D_206B_202A_202B_206C_200E_200B_200C_206E_200E_200E_200D_206D_202E_200D_200D_202E("containing graph ", containingGraphKey.ToString(), " not found"));
		}
		if (!value2.IsGraph)
		{
			throw new AddToLeafGraphException(GraphCompositeBuilder<Tkey, Tval>._202B_202B_200B_200B_202D_202E_206A_200B_202C_206A_202D_202E_206F_200E_200B_206E_206A_200D_206B_200E_206C_202B_206C_206E_200D_200E_206C_206C_200C_200F_206B_202B_202C_202A_202E_206B_206B_200B_200C_202B_202E(containingGraphKey.ToString(), " is not a graph"));
		}
		if (!config.Hierarchical && isGraph)
		{
			throw new SubgraphAttemptedException("Attempt to add a subgraph to a non-hierarchical graph");
		}
		if (allItems.ContainsKey(thisKey))
		{
			throw new AddDuplicateGraphException(GraphCompositeBuilder<Tkey, Tval>._202B_202B_200B_200B_202D_202E_206A_200B_202C_206A_202D_202E_206F_200E_200B_206E_206A_200D_206B_200E_206C_202B_206C_206E_200D_200E_206C_206C_200C_200F_206B_202B_202C_202A_202E_206B_206B_200B_200C_202B_202E(thisKey.ToString(), " already a member"));
		}
		GraphComposite<Tkey, Tval> graphComposite = new GraphComposite<Tkey, Tval>(thisKey, value, isGraph, value2);
		value2.Subgraph.Add(graphComposite);
		allItems.Add(thisKey, graphComposite);
	}

	public void AddEdge(Tkey key1, Tkey key2)
	{
		if (!allItems.TryGetValue(key1, out var val1))
		{
			throw new KeyNotFoundGraphException(GraphCompositeBuilder<Tkey, Tval>._202B_202B_200B_200B_202D_202E_206A_200B_202C_206A_202D_202E_206F_200E_200B_206E_206A_200D_206B_200E_206C_202B_206C_206E_200D_200E_206C_206C_200C_200F_206B_202B_202C_202A_202E_206B_206B_200B_200C_202B_202E(key1.ToString(), " not found"));
		}
		if (!allItems.TryGetValue(key2, out var value))
		{
			throw new KeyNotFoundGraphException(GraphCompositeBuilder<Tkey, Tval>._202B_202B_200B_200B_202D_202E_206A_200B_202C_206A_202D_202E_206F_200E_200B_206E_206A_200D_206B_200E_206C_202B_206C_206E_200D_200E_206C_206C_200C_200F_206B_202B_202C_202A_202E_206B_206B_200B_200C_202B_202E(key2.ToString(), " not found"));
		}
		if (val1 != root && value != root)
		{
			if (val1.Outgoing.Contains(value))
			{
				throw new AddDuplicateGraphException(GraphCompositeBuilder<Tkey, Tval>._206B_200D_206F_206B_206D_200B_206C_200F_206E_206A_202A_202B_206C_202E_202B_206C_202D_206A_206C_202A_206D_200B_206C_206B_202D_200F_200B_206E_206B_200E_202D_200C_206D_206C_202E_206B_202E_200C_202C_200D_202E("duplicate edge attempt from ", key1.ToString(), " to ", key2.ToString()));
			}
			if (value.Incoming.Contains(value))
			{
				throw new AddDuplicateGraphException(GraphCompositeBuilder<Tkey, Tval>._206B_200D_206F_206B_206D_200B_206C_200F_206E_206A_202A_202B_206C_202E_202B_206C_202D_206A_206C_202A_206D_200B_206C_206B_202D_200F_200B_206E_206B_200E_202D_200C_206D_206C_202E_206B_202E_200C_202C_200D_202E("duplicate edge attempt from ", key1.ToString(), " to ", key2.ToString()));
			}
			if (config.Acyclic)
			{
				Func<GraphComposite<Tkey, Tval>, bool> f = (GraphComposite<Tkey, Tval> c) => allItems.Comparer.Equals(c.Key, val1.Key);
				if (GraphCompositeTraversal<Tkey, Tval>.FindFirstOnPaths(value, f) != null)
				{
					throw new CycleAttemptedException(GraphCompositeBuilder<Tkey, Tval>._206B_200D_206F_206B_206D_200B_206C_200F_206E_206A_202A_202B_206C_202E_202B_206C_202D_206A_206C_202A_206D_200B_206C_206B_202D_200F_200B_206E_206B_200E_202D_200C_206D_206C_202E_206B_202E_200C_202C_200D_202E("edge between ", key1.ToString(), " and ", key2.ToString()));
				}
			}
			val1.Outgoing.Add(value);
			value.Incoming.Add(val1);
			allEdges.Add(new KeyValuePair<Tkey, Tkey>(key1, key2));
			return;
		}
		throw new AddEdgeToRootGraphException("attempt to connect edge to root");
	}

	public GraphComposite<Tkey, Tval> GenerateCopy()
	{
		GraphComposite<Tkey, Tval> result = null;
		GraphComposite<Tkey, Tval> currentParent = null;
		GraphComposite<Tkey, Tval> latest = null;
		Dictionary<Tkey, GraphComposite<Tkey, Tval>> allCopiedItems = new Dictionary<Tkey, GraphComposite<Tkey, Tval>>();
		Action<GraphComposite<Tkey, Tval>> onSelf = delegate(GraphComposite<Tkey, Tval> c)
		{
			latest = new GraphComposite<Tkey, Tval>(c.Key, c.Value, c.IsGraph, currentParent);
			if (latest.Parent == null)
			{
				result = latest;
			}
			else
			{
				latest.Parent.Subgraph.Add(latest);
			}
			allCopiedItems.Add(latest.Key, latest);
		};
		Action<GraphComposite<Tkey, Tval>> onGraphEntry = delegate
		{
			currentParent = latest;
		};
		Action<GraphComposite<Tkey, Tval>> onGraphExit = delegate
		{
			currentParent = currentParent.Parent;
		};
		GraphCompositeTraversal<Tkey, Tval>.TraverseSubgraphs(root, onSelf, onGraphEntry, onGraphExit);
		foreach (KeyValuePair<Tkey, Tkey> allEdge in allEdges)
		{
			allCopiedItems[allEdge.Key].Outgoing.Add(allCopiedItems[allEdge.Value]);
			allCopiedItems[allEdge.Value].Incoming.Add(allCopiedItems[allEdge.Key]);
		}
		return result;
	}
}
