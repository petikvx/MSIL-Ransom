using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace GraphComposite;

public class GraphComposite<Tkey, Tval>
{
	private List<GraphComposite<Tkey, Tval>> subgraph = null;

	private GraphComposite<Tkey, Tval> parent = null;

	private Tkey key;

	private List<GraphComposite<Tkey, Tval>> outgoing = new List<GraphComposite<Tkey, Tval>>();

	private List<GraphComposite<Tkey, Tval>> incoming = new List<GraphComposite<Tkey, Tval>>();

	private Tval value;

	public List<GraphComposite<Tkey, Tval>> Outgoing => outgoing;

	public List<GraphComposite<Tkey, Tval>> Incoming => incoming;

	public Tval Value => value;

	public List<GraphComposite<Tkey, Tval>> Subgraph => subgraph;

	public bool IsGraph => subgraph != null;

	public Tkey Key => key;

	public GraphComposite<Tkey, Tval> Parent => parent;

	public GraphComposite(Tkey key, Tval value, bool isGraph, GraphComposite<Tkey, Tval> parent)
	{
		if (isGraph)
		{
			subgraph = new List<GraphComposite<Tkey, Tval>>();
		}
		this.parent = parent;
		this.key = key;
		this.value = value;
	}

	private GraphComposite()
	{
	}

	public XElement AsXElement()
	{
		XElement result = null;
		XElement currentParent = null;
		Action<GraphComposite<Tkey, Tval>> onSelf = delegate(GraphComposite<Tkey, Tval> thisC)
		{
			if (currentParent == null)
			{
				currentParent = _003C_003Ec__DisplayClass22_0._200D_202A_206B_200F_200C_206C_206D_200C_206F_202C_202D_202E_200F_206A_206E_200D_206C_206A_206A_202E_206F_200B_206E_200C_206B_206D_206E_200F_206D_200C_200E_206D_206C_202C_200D_200C_206E_206E_206A_206E_202E(_003C_003Ec__DisplayClass22_0._206D_200F_206A_200F_202C_202E_202B_202B_202E_200F_200B_200C_202A_202D_206F_202B_202C_200D_206B_202E_200F_202E_200F_206A_206D_200C_202D_202A_202D_200E_202E_200D_200B_202E_206E_206C_200D_206C_202E_206D_202E(_003C_003Ec__DisplayClass22_0._200F_200D_202A_202A_200B_206B_202C_206A_202E_200F_200F_206B_202E_206A_206B_206F_206B_206F_200E_200F_206D_200D_202D_206E_200F_202D_202D_206C_206D_202D_200D_206E_200B_200F_200B_202B_200C_206D_202D_206C_202E("_", thisC.Key.ToString())), (object)thisC.Value);
				result = currentParent;
			}
			else
			{
				_003C_003Ec__DisplayClass22_0._206C_200D_206E_202D_206E_200F_202B_206A_206F_202D_206A_200C_202D_206F_200D_206A_206C_200F_200C_200B_206E_200C_202D_202E_202D_202C_206B_206E_202A_202D_206D_206D_206C_202A_206F_202B_200E_200C_206F_200D_202E((XContainer)(object)currentParent, (object)_003C_003Ec__DisplayClass22_0._200D_202A_206B_200F_200C_206C_206D_200C_206F_202C_202D_202E_200F_206A_206E_200D_206C_206A_206A_202E_206F_200B_206E_200C_206B_206D_206E_200F_206D_200C_200E_206D_206C_202C_200D_200C_206E_206E_206A_206E_202E(_003C_003Ec__DisplayClass22_0._206D_200F_206A_200F_202C_202E_202B_202B_202E_200F_200B_200C_202A_202D_206F_202B_202C_200D_206B_202E_200F_202E_200F_206A_206D_200C_202D_202A_202D_200E_202E_200D_200B_202E_206E_206C_200D_206C_202E_206D_202E(_003C_003Ec__DisplayClass22_0._200F_200D_202A_202A_200B_206B_202C_206A_202E_200F_200F_206B_202E_206A_206B_206F_206B_206F_200E_200F_206D_200D_202D_206E_200F_202D_202D_206C_206D_202D_200D_206E_200B_200F_200B_202B_200C_206D_202D_206C_202E("_", thisC.Key.ToString())), (object)thisC.Value));
			}
		};
		Action<GraphComposite<Tkey, Tval>> onGraphEntry = delegate(GraphComposite<Tkey, Tval> thisC)
		{
			currentParent = _003C_003Ec__DisplayClass22_0._200B_200C_200C_206F_206B_200F_202E_202B_202C_206A_206C_206F_206B_202E_202B_206C_200E_206E_202A_206B_200E_206D_206B_206D_200D_206F_206F_206D_206C_202B_206D_200B_202E_206B_202A_206B_202D_206E_206F_206D_202E((XContainer)(object)currentParent, _003C_003Ec__DisplayClass22_0._206D_200F_206A_200F_202C_202E_202B_202B_202E_200F_200B_200C_202A_202D_206F_202B_202C_200D_206B_202E_200F_202E_200F_206A_206D_200C_202D_202A_202D_200E_202E_200D_200B_202E_206E_206C_200D_206C_202E_206D_202E(_003C_003Ec__DisplayClass22_0._200F_200D_202A_202A_200B_206B_202C_206A_202E_200F_200F_206B_202E_206A_206B_206F_206B_206F_200E_200F_206D_200D_202D_206E_200F_202D_202D_206C_206D_202D_200D_206E_200B_200F_200B_202B_200C_206D_202D_206C_202E("_", thisC.Key.ToString())));
		};
		Action<GraphComposite<Tkey, Tval>> onGraphExit = delegate
		{
			currentParent = _003C_003Ec__DisplayClass22_0._202D_206C_206F_206B_206D_206B_200F_206C_206E_200B_206E_202C_202C_200D_206C_202C_202B_200B_200E_206E_200D_200B_206D_206B_206A_206A_206F_206A_206B_206E_202B_200D_202C_206A_200F_200C_202E_206D_202E_202D_202E((XObject)(object)currentParent);
		};
		GraphCompositeTraversal<Tkey, Tval>.TraverseSubgraphs(this, onSelf, onGraphEntry, onGraphExit);
		return result;
	}
}
