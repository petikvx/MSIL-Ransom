using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Pittsburgh;

public class Configuration
{
	public int Repetitions { get; set; }

	public int SearchCount { get; set; }

	public string[] ToSearch { get; set; }

	public string[] ToFind { get; set; }

	private Configuration()
	{
	}

	public static Configuration LoadConfiguration(string path)
	{
		XmlReaderSettings settings = new XmlReaderSettings
		{
			CloseInput = true,
			IgnoreComments = true,
			IgnoreProcessingInstructions = true,
			IgnoreWhitespace = true
		};
		int result = 3;
		int result2 = 1000;
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		using (FileStream input = File.OpenRead(path))
		{
			using XmlReader xmlReader = XmlReader.Create(input, settings);
			while (xmlReader.Read())
			{
				switch (xmlReader.NodeType)
				{
				case XmlNodeType.EndElement:
					switch (xmlReader.Name)
					{
					case "item":
						flag6 = false;
						break;
					case "searchTerms":
						flag6 = false;
						flag5 = false;
						break;
					case "searchList":
						flag6 = false;
						flag4 = false;
						break;
					case "settings":
						flag2 = false;
						flag3 = false;
						flag = false;
						break;
					case "searchCount":
						flag3 = false;
						break;
					case "repetitions":
						flag2 = false;
						break;
					}
					break;
				case XmlNodeType.Text:
					if (flag)
					{
						if (flag2)
						{
							int.TryParse(xmlReader.Value, out result);
						}
						else if (flag3)
						{
							int.TryParse(xmlReader.Value, out result2);
						}
					}
					else if (flag5 && flag6)
					{
						list2.Add(xmlReader.Value);
					}
					else if (flag4 && flag6)
					{
						list.Add(xmlReader.Value);
					}
					break;
				case XmlNodeType.Element:
					switch (xmlReader.Name)
					{
					case "item":
						flag6 = flag4 || flag5;
						break;
					case "searchTerms":
						flag5 = true;
						break;
					case "searchList":
						flag4 = true;
						break;
					case "settings":
						flag = true;
						break;
					case "searchCount":
						flag3 = flag;
						break;
					case "repetitions":
						flag2 = flag;
						break;
					}
					break;
				}
			}
		}
		return new Configuration
		{
			Repetitions = result,
			SearchCount = result2,
			ToFind = list2.ToArray(),
			ToSearch = list.ToArray()
		};
	}
}
