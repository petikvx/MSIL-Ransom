using System.Collections.Generic;
using System.Xml.Linq;

namespace GraphComposite;

public class ConvertFromXElementToGraph : ConvertToGraph<XElement, int, string>
{
	private int currentKey = 1;

	private Dictionary<int, int> keyMapping = new Dictionary<int, int>();

	public ConvertFromXElementToGraph(IEqualityComparer<int> comp)
		: base(comp)
	{
	}

	private ConvertFromXElementToGraph()
	{
	}

	protected override int GetKey(XElement x)
	{
		int value = 0;
		if (keyMapping.TryGetValue(ConvertFromXElementToGraph.smethod_0((object)x), out value))
		{
			return value;
		}
		keyMapping.Add(ConvertFromXElementToGraph.smethod_0((object)x), currentKey);
		return currentKey++;
	}

	protected override string GetValue(XElement x)
	{
		return ConvertFromXElementToGraph.smethod_2((object)ConvertFromXElementToGraph.smethod_1(x));
	}

	protected override IEnumerable<XElement> Elements(XElement x)
	{
		return ConvertFromXElementToGraph.smethod_3((XContainer)(object)x);
	}

	protected override IEnumerable<XElement> OutgoingEdges(XElement x)
	{
		return new List<XElement>();
	}

	static int smethod_0(object object_0)
	{
		return object_0.GetHashCode();
	}

	static XName smethod_1(XElement xelement_0)
	{
		return xelement_0.get_Name();
	}

	static string smethod_2(object object_0)
	{
		return object_0.ToString();
	}

	static IEnumerable<XElement> smethod_3(XContainer xcontainer_0)
	{
		return xcontainer_0.Elements();
	}
}
