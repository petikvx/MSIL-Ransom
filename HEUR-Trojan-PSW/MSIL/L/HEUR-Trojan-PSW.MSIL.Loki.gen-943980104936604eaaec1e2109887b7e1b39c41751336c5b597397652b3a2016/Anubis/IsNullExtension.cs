using System;

namespace Anubis;

public static class IsNullExtension
{
	public static bool IsNotNull<T>(this T data)
	{
		return data != null;
	}

	public static string IsNull(this string value, string defaultValue)
	{
		if (string.IsNullOrEmpty(value))
		{
			return defaultValue;
		}
		return value;
	}

	public static bool IsNullOrEmpty(this string str)
	{
		return string.IsNullOrEmpty(str);
	}

	public static bool IsNull(this bool? value, bool def)
	{
		if (!value.HasValue)
		{
			return def;
		}
		return value.Value;
	}

	public static T IsNull<T>(this T value) where T : class
	{
		if (value != null)
		{
			return value;
		}
		return Activator.CreateInstance<T>();
	}

	public static T IsNull<T>(this T value, T def) where T : class
	{
		if (value != null)
		{
			return value;
		}
		if (def != null)
		{
			return def;
		}
		return Activator.CreateInstance<T>();
	}

	public static int IsNull(this int? value, int def)
	{
		if (!value.HasValue)
		{
			return def;
		}
		return value.Value;
	}

	public static long IsNull(this long? value, long def)
	{
		if (!value.HasValue)
		{
			return def;
		}
		return value.Value;
	}

	public static double IsNull(this double? value, double def)
	{
		if (!value.HasValue)
		{
			return def;
		}
		return value.Value;
	}

	public static DateTime IsNull(this DateTime? value, DateTime def)
	{
		if (!value.HasValue)
		{
			return def;
		}
		return value.Value;
	}

	public static Guid IsNull(this Guid? value, Guid def)
	{
		if (!value.HasValue)
		{
			return def;
		}
		return value.Value;
	}
}
