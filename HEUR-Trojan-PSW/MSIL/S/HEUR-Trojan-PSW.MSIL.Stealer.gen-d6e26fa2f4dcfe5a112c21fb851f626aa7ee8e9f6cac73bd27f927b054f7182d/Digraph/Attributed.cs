using System;
using System.Collections.Generic;
using System.IO;

namespace Digraph;

public class Attributed
{
	private Dictionary<string, string> _attribs = new Dictionary<string, string>();

	public Dictionary<string, string> attribs
	{
		get
		{
			return _attribs;
		}
		set
		{
			_attribs = value;
		}
	}

	public string this[string key]
	{
		get
		{
			return _attribs[key];
		}
		set
		{
			_attribs[key] = value;
		}
	}

	public Attributed()
	{
	}

	public Attributed(string key, string value)
	{
		_attribs.Add(key, value);
	}

	public Attributed(string[] keyVals)
	{
		char[] char_ = new char[1] { '=' };
		foreach (string string_ in keyVals)
		{
			string[] array = Attributed.smethod_0(string_, char_, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length == 2)
			{
				_attribs.Add(array[0], array[1]);
			}
		}
	}

	public Attributed(Attributed a)
	{
		foreach (string key in a._attribs.Keys)
		{
			if (_attribs.TryGetValue(key, out var value))
			{
				_attribs.Add(key, value);
				continue;
			}
			throw Attributed.smethod_1("shouldn't get here if single-threaded");
		}
	}

	public Attributed(string fileName, char delimiter)
	{
		StreamReader textReader_ = Attributed.smethod_2(fileName);
		char[] char_ = new char[1] { delimiter };
		for (string text = Attributed.smethod_3((TextReader)textReader_); text != null; text = Attributed.smethod_3((TextReader)textReader_))
		{
			string[] array = Attributed.smethod_0(text, char_, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length >= 2)
			{
				_attribs.Add(array[0], array[1]);
			}
		}
		Attributed.smethod_4((TextReader)textReader_);
	}

	public void graft(Attributed src)
	{
		foreach (KeyValuePair<string, string> attrib in src.attribs)
		{
			if (hasKey(attrib.Key))
			{
				attribs[attrib.Key] = attrib.Value;
			}
			else
			{
				attribs.Add(attrib.Key, attrib.Value);
			}
		}
	}

	public bool hasKey(string key)
	{
		string value;
		return _attribs.TryGetValue(key, out value);
	}

	static string[] smethod_0(string string_0, char[] char_0, StringSplitOptions stringSplitOptions_0)
	{
		return string_0.Split(char_0, stringSplitOptions_0);
	}

	static Exception smethod_1(string string_0)
	{
		return new Exception(string_0);
	}

	static StreamReader smethod_2(string string_0)
	{
		return new StreamReader(string_0);
	}

	static string smethod_3(TextReader textReader_0)
	{
		return textReader_0.ReadLine();
	}

	static void smethod_4(TextReader textReader_0)
	{
		textReader_0.Close();
	}
}
