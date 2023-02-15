using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NiceJson;

[Serializable]
public sealed class JsonObject : JsonNode, IEnumerable
{
	private Dictionary<string, JsonNode> m_dictionary = new Dictionary<string, JsonNode>();

	public new JsonNode this[string string_0]
	{
		get
		{
			return m_dictionary[string_0];
		}
		set
		{
			m_dictionary[string_0] = value;
		}
	}

	public IEnumerator method_1()
	{
		//yield-return decompiler failed: Method not found
		return new Class0(0)
		{
			jsonObject_0 = this
		};
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return method_1();
	}

	public override string vmethod_0()
	{
		if (m_dictionary == null)
		{
			return "null";
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('{');
		foreach (string key in m_dictionary.Keys)
		{
			stringBuilder.Append('"');
			stringBuilder.Append(JsonNode.smethod_0(key));
			stringBuilder.Append('"');
			stringBuilder.Append(':');
			if (m_dictionary[key] != null)
			{
				stringBuilder.Append(m_dictionary[key].vmethod_0());
			}
			else
			{
				stringBuilder.Append("null");
			}
			stringBuilder.Append(',');
		}
		if (stringBuilder[stringBuilder.Length - 1] == ',')
		{
			stringBuilder.Remove(stringBuilder.Length - 1, 1);
		}
		stringBuilder.Append('}');
		return stringBuilder.ToString();
	}
}
