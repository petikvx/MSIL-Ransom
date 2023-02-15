using System;
using System.Globalization;
using System.Text;

namespace CommandLine.Infrastructure;

internal static class StringExtensions
{
	public static string ToOneCharString(this char c)
	{
		return new string(c, 1);
	}

	public static string ToStringInvariant<T>(this T value)
	{
		return Convert.ToString(value, CultureInfo.InvariantCulture);
	}

	public static string ToStringLocal<T>(this T value)
	{
		return Convert.ToString(value, CultureInfo.CurrentCulture);
	}

	public static string FormatInvariant(this string value, params object[] arguments)
	{
		return string.Format(CultureInfo.InvariantCulture, value, arguments);
	}

	public static string FormatLocal(this string value, params object[] arguments)
	{
		return string.Format(CultureInfo.CurrentCulture, value, arguments);
	}

	public static string Spaces(this int value)
	{
		return new string(' ', value);
	}

	public static bool EqualsOrdinal(this string strA, string strB)
	{
		return string.CompareOrdinal(strA, strB) == 0;
	}

	public static bool EqualsOrdinalIgnoreCase(this string strA, string strB)
	{
		return string.Compare(strA, strB, StringComparison.OrdinalIgnoreCase) == 0;
	}

	public static int SafeLength(this string value)
	{
		return value?.Length ?? 0;
	}

	public static string JoinTo(this string value, params string[] others)
	{
		StringBuilder stringBuilder = new StringBuilder(value);
		foreach (string value2 in others)
		{
			stringBuilder.Append(value2);
		}
		return stringBuilder.ToString();
	}

	public static bool IsBooleanString(this string value)
	{
		if (!value.Equals("true", StringComparison.OrdinalIgnoreCase))
		{
			return value.Equals("false", StringComparison.OrdinalIgnoreCase);
		}
		return true;
	}

	public static bool ToBoolean(this string value)
	{
		return value.Equals("true", StringComparison.OrdinalIgnoreCase);
	}
}
