using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ICSharpCode.SharpZipLib.Core;

public class NameFilter : IScanFilter
{
	private string filter_;

	private List<Regex> inclusions_;

	private List<Regex> exclusions_;

	public NameFilter(string filter)
	{
		filter_ = filter;
		inclusions_ = new List<Regex>();
		exclusions_ = new List<Regex>();
		Compile();
	}

	public static bool IsValidExpression(string expression)
	{
		bool result = true;
		try
		{
			new Regex(expression, RegexOptions.IgnoreCase | RegexOptions.Singleline);
			return result;
		}
		catch (ArgumentException)
		{
			return false;
		}
	}

	public static bool IsValidFilterExpression(string toTest)
	{
		bool result = true;
		try
		{
			if (toTest != null)
			{
				string[] array = SplitQuoted(toTest);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != null && array[i].Length > 0)
					{
						string pattern = ((array[i][0] == '+') ? array[i].Substring(1, array[i].Length - 1) : ((array[i][0] != '-') ? array[i] : array[i].Substring(1, array[i].Length - 1)));
						new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
					}
				}
				return result;
			}
			return result;
		}
		catch (ArgumentException)
		{
			return false;
		}
	}

	public static string[] SplitQuoted(string original)
	{
		char c = '\\';
		char[] array = new char[1] { ';' };
		List<string> list = new List<string>();
		if (!string.IsNullOrEmpty(original))
		{
			int num = -1;
			StringBuilder stringBuilder = new StringBuilder();
			while (num < original.Length)
			{
				num++;
				if (num >= original.Length)
				{
					list.Add(stringBuilder.ToString());
				}
				else if (original[num] == c)
				{
					num++;
					if (num >= original.Length)
					{
						throw new ArgumentException("Missing terminating escape character", "original");
					}
					if (Array.IndexOf(array, original[num]) < 0)
					{
						stringBuilder.Append(c);
					}
					stringBuilder.Append(original[num]);
				}
				else if (Array.IndexOf(array, original[num]) >= 0)
				{
					list.Add(stringBuilder.ToString());
					stringBuilder.Length = 0;
				}
				else
				{
					stringBuilder.Append(original[num]);
				}
			}
		}
		return list.ToArray();
	}

	public override string ToString()
	{
		return filter_;
	}

	public bool IsIncluded(string name)
	{
		bool result = false;
		if (inclusions_.Count == 0)
		{
			return true;
		}
		foreach (Regex item in inclusions_)
		{
			if (item.IsMatch(name))
			{
				return true;
			}
		}
		return result;
	}

	public bool IsExcluded(string name)
	{
		bool result = false;
		foreach (Regex item in exclusions_)
		{
			if (item.IsMatch(name))
			{
				return true;
			}
		}
		return result;
	}

	public bool IsMatch(string name)
	{
		if (IsIncluded(name))
		{
			return !IsExcluded(name);
		}
		return false;
	}

	private void Compile()
	{
		if (filter_ == null)
		{
			return;
		}
		string[] array = SplitQuoted(filter_);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null && array[i].Length > 0)
			{
				bool num = array[i][0] != '-';
				string pattern = ((array[i][0] == '+') ? array[i].Substring(1, array[i].Length - 1) : ((array[i][0] != '-') ? array[i] : array[i].Substring(1, array[i].Length - 1)));
				if (num)
				{
					inclusions_.Add(new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline));
				}
				else
				{
					exclusions_.Add(new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline));
				}
			}
		}
	}
}
