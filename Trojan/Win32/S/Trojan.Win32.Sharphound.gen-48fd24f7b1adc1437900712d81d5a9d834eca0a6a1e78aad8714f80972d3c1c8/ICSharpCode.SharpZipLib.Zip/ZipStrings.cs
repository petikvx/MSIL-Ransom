using System;
using System.Text;

namespace ICSharpCode.SharpZipLib.Zip;

public static class ZipStrings
{
	private static int codePage;

	private const int AutomaticCodePage = -1;

	private const int FallbackCodePage = 437;

	public static int CodePage
	{
		get
		{
			if (codePage != -1)
			{
				return codePage;
			}
			return Encoding.UTF8.CodePage;
		}
		set
		{
			if (value < 0 || value > 65535 || value == 1 || value == 2 || value == 3 || value == 42)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			codePage = value;
		}
	}

	public static int SystemDefaultCodePage { get; }

	public static bool UseUnicode
	{
		get
		{
			return codePage == Encoding.UTF8.CodePage;
		}
		set
		{
			if (value)
			{
				codePage = Encoding.UTF8.CodePage;
			}
			else
			{
				codePage = SystemDefaultCodePage;
			}
		}
	}

	static ZipStrings()
	{
		codePage = -1;
		try
		{
			int num = Encoding.GetEncoding(0).CodePage;
			SystemDefaultCodePage = ((num == 1 || num == 2 || num == 3 || num == 42) ? 437 : num);
		}
		catch
		{
			SystemDefaultCodePage = 437;
		}
	}

	public static string ConvertToString(byte[] data, int count)
	{
		if (data != null)
		{
			return Encoding.GetEncoding(CodePage).GetString(data, 0, count);
		}
		return string.Empty;
	}

	public static string ConvertToString(byte[] data)
	{
		return ConvertToString(data, data.Length);
	}

	private static Encoding EncodingFromFlag(int flags)
	{
		if ((flags & 0x800) == 0)
		{
			return Encoding.GetEncoding((codePage == -1) ? SystemDefaultCodePage : codePage);
		}
		return Encoding.UTF8;
	}

	public static string ConvertToStringExt(int flags, byte[] data, int count)
	{
		if (data != null)
		{
			return EncodingFromFlag(flags).GetString(data, 0, count);
		}
		return string.Empty;
	}

	public static string ConvertToStringExt(int flags, byte[] data)
	{
		return ConvertToStringExt(flags, data, data.Length);
	}

	public static byte[] ConvertToArray(string str)
	{
		if (str != null)
		{
			return Encoding.GetEncoding(CodePage).GetBytes(str);
		}
		return new byte[0];
	}

	public static byte[] ConvertToArray(int flags, string str)
	{
		if (!string.IsNullOrEmpty(str))
		{
			return EncodingFromFlag(flags).GetBytes(str);
		}
		return new byte[0];
	}
}
