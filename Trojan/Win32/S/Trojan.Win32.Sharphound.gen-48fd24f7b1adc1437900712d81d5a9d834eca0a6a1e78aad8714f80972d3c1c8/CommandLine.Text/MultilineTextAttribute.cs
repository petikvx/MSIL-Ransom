using System;
using System.Linq;
using System.Text;

namespace CommandLine.Text;

public abstract class MultilineTextAttribute : Attribute
{
	private readonly string line1;

	private readonly string line2;

	private readonly string line3;

	private readonly string line4;

	private readonly string line5;

	public virtual string Value
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(string.Empty);
			string[] array = new string[5] { line1, line2, line3, line4, line5 };
			for (int i = 0; i < GetLastLineWithText(array); i++)
			{
				stringBuilder.AppendLine(array[i]);
			}
			return stringBuilder.ToString();
		}
	}

	public string Line1 => line1;

	public string Line2 => line2;

	public string Line3 => line3;

	public string Line4 => line4;

	public string Line5 => line5;

	protected MultilineTextAttribute(string line1)
		: this(line1, string.Empty, string.Empty, string.Empty, string.Empty)
	{
	}

	protected MultilineTextAttribute(string line1, string line2)
		: this(line1, line2, string.Empty, string.Empty, string.Empty)
	{
	}

	protected MultilineTextAttribute(string line1, string line2, string line3)
		: this(line1, line2, line3, string.Empty, string.Empty)
	{
	}

	protected MultilineTextAttribute(string line1, string line2, string line3, string line4)
		: this(line1, line2, line3, line4, string.Empty)
	{
	}

	protected MultilineTextAttribute(string line1, string line2, string line3, string line4, string line5)
	{
		if (line1 == null)
		{
			throw new ArgumentException("line1");
		}
		if (line2 == null)
		{
			throw new ArgumentException("line2");
		}
		if (line3 == null)
		{
			throw new ArgumentException("line3");
		}
		if (line4 == null)
		{
			throw new ArgumentException("line4");
		}
		if (line5 == null)
		{
			throw new ArgumentException("line5");
		}
		this.line1 = line1;
		this.line2 = line2;
		this.line3 = line3;
		this.line4 = line4;
		this.line5 = line5;
	}

	internal HelpText AddToHelpText(HelpText helpText, Func<string, HelpText> func)
	{
		string[] array = new string[5] { line1, line2, line3, line4, line5 };
		return Enumerable.Aggregate(Enumerable.Take(array, GetLastLineWithText(array)), helpText, (HelpText current, string line) => func(line));
	}

	internal HelpText AddToHelpText(HelpText helpText, bool before)
	{
		if (!before)
		{
			return AddToHelpText(helpText, helpText.AddPostOptionsLine);
		}
		return AddToHelpText(helpText, helpText.AddPreOptionsLine);
	}

	protected virtual int GetLastLineWithText(string[] value)
	{
		return Array.FindLastIndex(value, (string str) => !string.IsNullOrEmpty(str)) + 1;
	}
}
