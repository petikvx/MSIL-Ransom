using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using Pittsburgh.Properties;

namespace Pittsburgh;

public static class RuleManager
{
	public static List<Rule> GetAllRules()
	{
		return GetRulesFromDirectory(Settings.Default.RulesDirectory);
	}

	public static List<Rule> GetRulesFromFiles(List<string> files)
	{
		List<Rule> list = new List<Rule>();
		foreach (string file in files)
		{
			list.AddRange(GetRulesFromFile(file));
		}
		return list;
	}

	public static List<Rule> GetRulesFromDirectory(string directory)
	{
		List<Rule> list = new List<Rule>();
		if (Directory.Exists(directory))
		{
			string[] directories = Directory.GetDirectories(directory);
			foreach (string directory2 in directories)
			{
				list.AddRange(GetRulesFromDirectory(directory2));
			}
			directories = Directory.GetFiles(directory);
			foreach (string file in directories)
			{
				list.AddRange(GetRulesFromFile(file));
			}
		}
		return list;
	}

	public static List<Rule> GetRulesFromFile(string file)
	{
		List<Rule> list = new List<Rule>();
		if (File.Exists(file))
		{
			XmlTextReader xmlTextReader = new XmlTextReader(file);
			while (xmlTextReader.Read())
			{
				if (!("Rule" == xmlTextReader.Name))
				{
					continue;
				}
				Rule rule = new Rule();
				while (XmlNodeType.EndElement != xmlTextReader.NodeType || !("Rule" == xmlTextReader.Name))
				{
					xmlTextReader.Read();
					switch (xmlTextReader.Name)
					{
					case "Description":
						rule.Description = ReadElement(xmlTextReader, "Description");
						break;
					case "Title":
						rule.Title = ReadElement(xmlTextReader, "Title");
						break;
					case "RegularExpressionPattern":
						rule.RegexSearchPattern = ReadElement(xmlTextReader, "RegularExpressionPattern");
						break;
					case "Guidance":
						rule.AddGuidanceList(ReadList(xmlTextReader, "Guidance", "Url"));
						break;
					case "Severity":
						rule.Severity = ReadElement(xmlTextReader, "Severity");
						break;
					case "Type":
						rule.Type = ReadElement(xmlTextReader, "Type");
						break;
					case "Extensions":
						rule.AddExtensionList(ReadList(xmlTextReader, "Extensions", "Extension"));
						break;
					}
				}
				rule.Selected = true;
				list.Add(rule);
			}
			xmlTextReader.Close();
		}
		return list;
	}

	private static List<string> ReadList(XmlTextReader reader, string NodeName, string SubnodeName)
	{
		List<string> list = new List<string>();
		while (reader.NodeType != XmlNodeType.EndElement || !(NodeName == reader.Name))
		{
			list.Add(ReadElement(reader, SubnodeName));
			reader.Read();
		}
		return list;
	}

	private static string ReadElement(XmlTextReader reader, string NodeName)
	{
		string text = "";
		while (reader.NodeType != XmlNodeType.Text)
		{
			reader.Read();
		}
		text = reader.Value;
		while (reader.NodeType != XmlNodeType.EndElement || !(NodeName == reader.Name))
		{
			reader.Read();
		}
		reader.Read();
		return text;
	}

	public static void AddRule(Rule r)
	{
		StreamReader streamReader = new StreamReader(Settings.Default.RulesDirectory);
		string[] array = Regex.Split(streamReader.ReadToEnd(), "\r\n");
		streamReader.Close();
		StreamWriter streamWriter = new StreamWriter(Settings.Default.RulesDirectory);
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (!text.Contains("</Rules>"))
			{
				streamWriter.WriteLine(text);
			}
			else
			{
				streamWriter.Write(r.GenerateXMLSnippet());
			}
		}
		streamWriter.WriteLine("</Rules>");
		streamWriter.Close();
	}

	public static void RemoveRule(Rule r)
	{
	}

	public static int RuleCount()
	{
		return GetAllRules().Count;
	}
}
