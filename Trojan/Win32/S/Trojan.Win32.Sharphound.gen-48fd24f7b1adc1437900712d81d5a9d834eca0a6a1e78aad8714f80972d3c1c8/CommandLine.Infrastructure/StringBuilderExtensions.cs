using System;
using System.Text;

namespace CommandLine.Infrastructure;

internal static class StringBuilderExtensions
{
	public static StringBuilder AppendWhen(this StringBuilder builder, bool condition, params string[] values)
	{
		if (condition)
		{
			foreach (string value in values)
			{
				builder.Append(value);
			}
		}
		return builder;
	}

	public static StringBuilder AppendWhen(this StringBuilder builder, bool condition, params char[] values)
	{
		if (condition)
		{
			foreach (char value in values)
			{
				builder.Append(value);
			}
		}
		return builder;
	}

	public static StringBuilder AppendFormatWhen(this StringBuilder builder, bool condition, string format, params object[] args)
	{
		if (!condition)
		{
			return builder;
		}
		return builder.AppendFormat(format, args);
	}

	public static StringBuilder AppendIf(this StringBuilder builder, bool condition, string ifTrue, string ifFalse)
	{
		if (!condition)
		{
			return builder.Append(ifFalse);
		}
		return builder.Append(ifTrue);
	}

	public static StringBuilder BimapIf(this StringBuilder builder, bool condition, Func<StringBuilder, StringBuilder> ifTrue, Func<StringBuilder, StringBuilder> ifFalse)
	{
		if (!condition)
		{
			return ifFalse(builder);
		}
		return ifTrue(builder);
	}

	public static StringBuilder MapIf(this StringBuilder builder, bool condition, Func<StringBuilder, StringBuilder> ifTrue)
	{
		if (!condition)
		{
			return builder;
		}
		return ifTrue(builder);
	}

	public static StringBuilder AppendIfNotEmpty(this StringBuilder builder, params string[] values)
	{
		foreach (string text in values)
		{
			if (text.Length > 0)
			{
				builder.Append(text);
			}
		}
		return builder;
	}

	public static string SafeToString(this StringBuilder builder)
	{
		if (builder != null)
		{
			return builder.ToString();
		}
		return string.Empty;
	}

	public static int SafeLength(this StringBuilder builder)
	{
		return builder?.Length ?? 0;
	}

	public static StringBuilder TrimEnd(this StringBuilder builder, char c)
	{
		if (builder.Length <= 0)
		{
			return builder;
		}
		return builder.Remove(builder.Length - 1, 1);
	}

	public static StringBuilder TrimEndIfMatch(this StringBuilder builder, char c)
	{
		if (builder.Length > 0 && builder[builder.Length - 1] == c)
		{
			builder.Remove(builder.Length - 1, 1);
		}
		return builder;
	}

	public static StringBuilder TrimEndIfMatchWhen(this StringBuilder builder, bool condition, char c)
	{
		if (!condition)
		{
			return builder;
		}
		return builder.TrimEndIfMatch(c);
	}

	public static int TrailingSpaces(this StringBuilder builder)
	{
		int num = builder.Length - 1;
		if (builder.Length == 0)
		{
			return 0;
		}
		if (builder[num] != ' ')
		{
			return 0;
		}
		int num2 = 0;
		int num3 = num;
		while (num3 <= num && num3 >= 0 && builder[num3] == ' ')
		{
			num2++;
			num3--;
		}
		return num2;
	}

	public static bool SafeStartsWith(this StringBuilder builder, string s)
	{
		if (string.IsNullOrEmpty(s))
		{
			return false;
		}
		if (builder?.Length >= s.Length)
		{
			return builder.ToString(0, s.Length) == s;
		}
		return false;
	}

	public static bool SafeEndsWith(this StringBuilder builder, string s)
	{
		if (string.IsNullOrEmpty(s))
		{
			return false;
		}
		if (builder?.Length >= s.Length)
		{
			return builder.ToString(builder.Length - s.Length, s.Length) == s;
		}
		return false;
	}
}
