using System;

namespace GraphComposite;

public abstract class ConvertFromGraph<T, Tkey, Tval>
{
	public T Convert(GraphComposite<Tkey, Tval> g)
	{
		T result = default(T);
		T currentParent = default(T);
		Action<GraphComposite<Tkey, Tval>> onSelf = delegate(GraphComposite<Tkey, Tval> thisC)
		{
			if (currentParent != null)
			{
				AddChild(currentParent, MakeInstance(thisC.Key, thisC.Value));
			}
			foreach (GraphComposite<Tkey, Tval> item in thisC.Outgoing)
			{
				OnEdge(thisC.Key, item.Key);
			}
			foreach (GraphComposite<Tkey, Tval> item2 in thisC.Incoming)
			{
				OnEdge(item2.Key, thisC.Key);
			}
		};
		Action<GraphComposite<Tkey, Tval>> onGraphEntry = delegate(GraphComposite<Tkey, Tval> thisC)
		{
			if (currentParent == null)
			{
				currentParent = MakeInstance(thisC.Key, thisC.Value);
				result = currentParent;
			}
			else
			{
				currentParent = GetChild(currentParent, thisC.Key);
			}
		};
		Action<GraphComposite<Tkey, Tval>> onGraphExit = delegate
		{
			currentParent = GetParent(currentParent);
		};
		GraphCompositeTraversal<Tkey, Tval>.TraverseSubgraphs(g, onSelf, onGraphEntry, onGraphExit);
		return result;
	}

	protected abstract T MakeInstance(Tkey key, Tval val);

	protected abstract void AddChild(T parent, T child);

	protected abstract T GetParent(T child);

	protected abstract T GetChild(T parent, Tkey key);

	protected abstract void OnEdge(Tkey sourceKey, Tkey targetKey);
}
