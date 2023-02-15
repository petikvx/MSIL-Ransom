using System;
using System.Runtime.CompilerServices;

namespace NiceJson;

[Serializable]
public sealed class JsonBasic : JsonNode
{
	private object m_value;

	[SpecialName]
	public object method_1()
	{
		return m_value;
	}

	public JsonBasic(object object_0)
	{
		m_value = object_0;
	}

	string object.ToString()
	{
		return m_value.ToString();
	}

	public override string vmethod_0()
	{
		if (m_value == null)
		{
			return "null";
		}
		if (m_value is string)
		{
			return "\"" + JsonNode.smethod_0(m_value.ToString()) + "\"";
		}
		if (m_value is bool)
		{
			if ((bool)m_value)
			{
				return "true";
			}
			return "false";
		}
		return m_value.ToString();
	}
}
