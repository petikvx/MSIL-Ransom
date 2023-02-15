using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DnsClient;

public class DnsString
{
	public const string ACEPrefix = "xn--";

	public const int LabelMaxLength = 63;

	public const int QueryMaxLength = 255;

	public static readonly DnsString RootLabel = new DnsString(".", ".");

	internal static readonly IdnMapping IDN = new IdnMapping();

	private const char Dot = '.';

	private const string DotStr = ".";

	public string Original { get; }

	public string Value { get; }

	public IReadOnlyList<string> Labels => Enumerable.ToArray(Enumerable.Select(Enumerable.Reverse(Value.Split(new char[1] { '.' })), (string p) => p + "."));

	internal DnsString(string original, string value)
	{
		Original = original;
		Value = value;
	}

	public static implicit operator string(DnsString name)
	{
		return name?.Value;
	}

	public override string ToString()
	{
		return Value;
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		return obj?.ToString().Equals(Value) ?? false;
	}

	public static DnsString Parse(string query)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if (query.Length > 1 && query[0] == '.')
		{
			throw new ArgumentException($"'{query}' is not a legal name, found leading root label.", "query");
		}
		if (query.Length != 0 && (query.Length != 1 || !query.Equals(".")))
		{
			int num4 = 0;
			while (true)
			{
				if (num4 < query.Length)
				{
					char c = query[num4];
					if (c == '.')
					{
						if (num2 > 63)
						{
							break;
						}
						num3++;
						num2 = 0;
					}
					else
					{
						num2++;
						num++;
						switch (c)
						{
						default:
							if ((c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
							{
								break;
							}
							try
							{
								string text = IDN.GetAscii(query);
								if (text[text.Length - 1] != '.')
								{
									text += ".";
								}
								return new DnsString(query, text);
							}
							catch (Exception innerException)
							{
								throw new ArgumentException($"'{query}' is not a valid hostname.", "query", innerException);
							}
						case '-':
						case '_':
						case 'a':
						case 'b':
						case 'c':
						case 'd':
						case 'e':
						case 'f':
						case 'g':
						case 'h':
						case 'i':
						case 'j':
						case 'k':
						case 'l':
						case 'm':
						case 'n':
						case 'o':
						case 'p':
						case 'q':
						case 'r':
						case 's':
						case 't':
						case 'u':
						case 'v':
						case 'w':
						case 'x':
						case 'y':
						case 'z':
							break;
						}
					}
					num4++;
					continue;
				}
				if (num2 > 0)
				{
					num3++;
					if (num2 > 63)
					{
						throw new ArgumentException($"Label '{num3}' is longer than {63} bytes.", "query");
					}
				}
				if (num + num3 + 1 > 255)
				{
					throw new ArgumentException($"Octet length of '{query}' exceeds maximum of {255} bytes.", "query");
				}
				if (query[query.Length - 1] != '.')
				{
					return new DnsString(query, query + ".");
				}
				return new DnsString(query, query);
			}
			throw new ArgumentException($"Label '{num3 + 1}' is longer than {63} bytes.", "query");
		}
		return RootLabel;
	}

	public static DnsString FromResponseQueryString(string query)
	{
		if (query.Length == 0 || query[query.Length - 1] != '.')
		{
			query += ".";
		}
		if (query.Contains("xn--"))
		{
			return new DnsString(IDN.GetUnicode(query), query);
		}
		return new DnsString(query, query);
	}
}
