using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace SmartAssembly.StringsEncoding;

public class Strings
{
	public static class DynProx
	{
		public static string Get(int stringID)
		{
			stringID ^= 0x666BEEF;
			stringID -= offset;
			if (!cacheStrings)
			{
				return GetFromResource(stringID);
			}
			return GetCachedOrResource(stringID);
		}
	}

	private static readonly string MustUseCache;

	private static readonly string OffsetValue;

	private static readonly byte[] bytes;

	private static readonly Dictionary<int, string> hashtable;

	private static readonly object hashtableLock;

	private static readonly bool cacheStrings;

	private static readonly int offset;

	public static string Get(int stringID)
	{
		return DynProx.Get(stringID);
	}

	public static string GetCachedOrResource(int stringID)
	{
		lock (hashtableLock)
		{
			hashtable.TryGetValue(stringID, out var value);
			if (value != null)
			{
				return value;
			}
		}
		return GetFromResource(stringID);
	}

	public static string GetFromResource(int stringID)
	{
		int index = stringID;
		int num = bytes[index++];
		int num2;
		if (((uint)num & 0x80u) != 0)
		{
			num2 = ((((uint)num & 0x40u) != 0) ? (((num & 0x1F) << 24) + (bytes[index++] << 16) + (bytes[index++] << 8) + bytes[index++]) : (((num & 0x3F) << 8) + bytes[index++]));
		}
		else
		{
			num2 = num;
			if (num2 == 0)
			{
				return string.Empty;
			}
		}
		try
		{
			byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(bytes, index, num2));
			string text = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
			if (cacheStrings)
			{
				CacheString(stringID, text);
			}
			return text;
		}
		catch
		{
			return null;
		}
	}

	public static void CacheString(int stringID, string value)
	{
		try
		{
			lock (hashtableLock)
			{
				hashtable.Add(stringID, value);
			}
		}
		catch
		{
		}
	}

	static Strings()
	{
		MustUseCache = "0";
		OffsetValue = "143";
		bytes = null;
		hashtableLock = new object();
		cacheStrings = false;
		offset = 0;
		if (MustUseCache == "1")
		{
			cacheStrings = true;
			hashtable = new Dictionary<int, string>();
		}
		offset = Convert.ToInt32(OffsetValue);
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("{886c8846-a2c5-4fea-86fc-ac483bdbcc12}");
		int num = Convert.ToInt32(stream.Length);
		bytes = new byte[num];
		stream.Read(bytes, 0, num);
	}
}
