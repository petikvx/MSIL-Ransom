using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns0;

internal sealed class Class22
{
	private static readonly string string_0;

	private static readonly string string_1;

	private static readonly byte[] byte_0;

	private static readonly Dictionary<int, string> dictionary_0;

	private static readonly object object_0;

	private static readonly bool bool_0;

	private static readonly int int_0;

	public static string smethod_0(int int_1)
	{
		int_1 -= int_0;
		if (bool_0)
		{
			lock (object_0)
			{
				dictionary_0.TryGetValue(int_1, out var value);
				if (value != null)
				{
					return value;
				}
			}
		}
		int num = 0;
		int index = int_1;
		int num2 = byte_0[index++];
		if (((uint)num2 & 0x80u) != 0)
		{
			num = ((((uint)num2 & 0x40u) != 0) ? (((num2 & 0x1F) << 24) + (byte_0[index++] << 16) + (byte_0[index++] << 8) + byte_0[index++]) : (((num2 & 0x3F) << 8) + byte_0[index++]));
		}
		else
		{
			num = num2;
			if (num == 0)
			{
				return string.Empty;
			}
		}
		try
		{
			byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(byte_0, index, num));
			string text = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
			if (bool_0)
			{
				try
				{
					lock (object_0)
					{
						dictionary_0.Add(int_1, text);
					}
				}
				catch
				{
				}
			}
			return text;
		}
		catch
		{
			return null;
		}
	}

	static Class22()
	{
		string_0 = "1";
		string_1 = "201";
		byte_0 = null;
		object_0 = new object();
		bool_0 = false;
		int_0 = 0;
		if (string_0 == "1")
		{
			bool_0 = true;
			dictionary_0 = new Dictionary<int, string>();
		}
		int_0 = Convert.ToInt32(string_1);
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("{2337e8ee-0ac2-4c9e-b36a-433bae9c013c}");
		int num = Convert.ToInt32(stream.Length);
		byte[] buffer = new byte[num];
		stream.Read(buffer, 0, num);
		byte_0 = Class21.smethod_112(buffer);
		buffer = null;
		stream.Close();
	}
}
