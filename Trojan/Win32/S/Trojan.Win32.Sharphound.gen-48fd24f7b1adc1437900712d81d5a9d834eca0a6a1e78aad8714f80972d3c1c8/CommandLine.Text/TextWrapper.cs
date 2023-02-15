using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandLine.Infrastructure;

namespace CommandLine.Text;

public class TextWrapper
{
	private string[] lines;

	public TextWrapper(string input)
	{
		lines = input.Replace("\r", "").Split(new char[1] { '\n' }, StringSplitOptions.None);
	}

	public TextWrapper WordWrap(int columnWidth)
	{
		columnWidth = Math.Max(1, columnWidth);
		lines = Enumerable.ToArray(Enumerable.SelectMany(lines, (string line) => WordWrapLine(line, columnWidth)));
		return this;
	}

	public TextWrapper Indent(int numberOfSpaces)
	{
		lines = Enumerable.ToArray(Enumerable.Select(lines, (string line) => numberOfSpaces.Spaces() + line));
		return this;
	}

	public string ToText()
	{
		return string.Join(Environment.NewLine, lines);
	}

	public static string WrapAndIndentText(string input, int indentLevel, int columnWidth)
	{
		return new TextWrapper(input).WordWrap(columnWidth).Indent(indentLevel).ToText();
	}

	private string[] WordWrapLine(string line, int columnWidth)
	{
		string text = line.TrimStart(new char[0]);
		int currentIndentLevel = Math.Min(line.Length - text.Length, columnWidth - 1);
		columnWidth -= currentIndentLevel;
		return Enumerable.ToArray(Enumerable.Select(Enumerable.Aggregate(text.Split(new char[1] { ' ' }), new List<StringBuilder>(), (List<StringBuilder> lineList, string word) => AddWordToLastLineOrCreateNewLineIfNecessary(lineList, word, columnWidth)), (StringBuilder builder) => currentIndentLevel.Spaces() + builder.ToString().TrimEnd(new char[0])));
	}

	private static List<StringBuilder> AddWordToLastLineOrCreateNewLineIfNecessary(List<StringBuilder> lines, string word, int columnWidth)
	{
		StringBuilder? stringBuilder = Enumerable.LastOrDefault(lines);
		object obj;
		if (stringBuilder == null)
		{
			obj = null;
		}
		else
		{
			obj = stringBuilder!.ToString();
			if (obj != null)
			{
				goto IL_001b;
			}
		}
		obj = string.Empty;
		goto IL_001b;
		IL_001b:
		string text = (string)obj;
		if (Enumerable.Any(lines) && (word.Length <= 0 || text.Length + word.Length <= columnWidth))
		{
			Enumerable.Last(lines).Append(word + " ");
		}
		else
		{
			do
			{
				int n = Math.Min(columnWidth, word.Length);
				string value = LeftString(word, n) + " ";
				lines.Add(new StringBuilder(value));
				word = RightString(word, n);
			}
			while (word.Length > 0);
		}
		return lines;
	}

	private static string RightString(string str, int n)
	{
		if (n < str.Length && str.Length != 0)
		{
			return str.Substring(n);
		}
		return string.Empty;
	}

	private static string LeftString(string str, int n)
	{
		if (n < str.Length && str.Length != 0)
		{
			return str.Substring(0, n);
		}
		return str;
	}
}
