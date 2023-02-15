using System;
using System.Globalization;
using System.Reflection;
using System.Text;
using CSharpx;
using CommandLine.Infrastructure;

namespace CommandLine.Text;

public class CopyrightInfo
{
	private const string DefaultCopyrightWord = "Copyright";

	private const string SymbolLower = "(c)";

	private const string SymbolUpper = "(C)";

	private readonly AssemblyCopyrightAttribute attribute;

	private readonly bool isSymbolUpper;

	private readonly int[] copyrightYears;

	private readonly string author;

	private readonly int builderSize;

	public static CopyrightInfo Empty => new CopyrightInfo("author", DateTime.Now.Year);

	public static CopyrightInfo Default
	{
		get
		{
			Maybe<AssemblyCopyrightAttribute> maybe = ReflectionHelper.GetAttribute<AssemblyCopyrightAttribute>();
			if (maybe.Tag == MaybeType.Just)
			{
				return new CopyrightInfo(maybe.FromJustOrFail());
			}
			Maybe<AssemblyCompanyAttribute> maybe2 = ReflectionHelper.GetAttribute<AssemblyCompanyAttribute>();
			if (!maybe2.IsNothing())
			{
				return new CopyrightInfo(maybe2.FromJust().Company, DateTime.Now.Year);
			}
			return Empty;
		}
	}

	protected virtual string CopyrightWord => "Copyright";

	public CopyrightInfo(string author, int year)
		: this(true, author, year)
	{
	}

	public CopyrightInfo(string author, params int[] years)
		: this(isSymbolUpper: true, author, years)
	{
	}

	public CopyrightInfo(bool isSymbolUpper, string author, params int[] copyrightYears)
	{
		if (string.IsNullOrWhiteSpace(author))
		{
			throw new ArgumentException("author");
		}
		if (copyrightYears.Length == 0)
		{
			throw new ArgumentOutOfRangeException("copyrightYears");
		}
		this.isSymbolUpper = isSymbolUpper;
		this.author = author;
		this.copyrightYears = copyrightYears;
		builderSize = 12 + author.Length + 4 * copyrightYears.Length + 10;
	}

	protected CopyrightInfo()
	{
	}

	private CopyrightInfo(AssemblyCopyrightAttribute attribute)
	{
		this.attribute = attribute;
	}

	public static implicit operator string(CopyrightInfo info)
	{
		return info.ToString();
	}

	public override string ToString()
	{
		if (attribute != null)
		{
			return attribute.Copyright;
		}
		return new StringBuilder(builderSize).Append(CopyrightWord).Append(' ').Append(isSymbolUpper ? "(C)" : "(c)")
			.Append(' ')
			.Append(FormatYears(copyrightYears))
			.Append(' ')
			.Append(author)
			.ToString();
	}

	protected virtual string FormatYears(int[] years)
	{
		if (years.Length == 1)
		{
			return years[0].ToString(CultureInfo.InvariantCulture);
		}
		StringBuilder stringBuilder = new StringBuilder(years.Length * 6);
		for (int i = 0; i < years.Length; i++)
		{
			stringBuilder.Append(years[i].ToString(CultureInfo.InvariantCulture));
			int num = i + 1;
			if (num < years.Length)
			{
				stringBuilder.Append((years[num] - years[i] > 1) ? " - " : ", ");
			}
		}
		return stringBuilder.ToString();
	}
}
