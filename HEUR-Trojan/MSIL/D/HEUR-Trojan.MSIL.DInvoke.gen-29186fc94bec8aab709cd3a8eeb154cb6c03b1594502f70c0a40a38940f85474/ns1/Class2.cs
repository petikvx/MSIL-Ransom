using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns1;

internal class Class2
{
	public enum Enum0
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8
	}

	public static Random random_0 = new Random();

	[CompilerGenerated]
	private static Func<string, char> func_0;

	private string method_0(int int_0)
	{
		return new string((from string_0 in Enumerable.Repeat("abcdefghijklmnopkrIdmFAS", int_0)
			select string_0[random_0.Next(string_0.Length)]).ToArray());
	}

	public static void smethod_0(string string_0, bool bool_0, bool bool_1, bool bool_2, bool bool_3, string string_1)
	{
		if (!(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) == ""))
		{
			return;
		}
		Directory.Move(string_1, "");
		Path.GetTempPath();
		string text = "";
		string text2 = text;
		foreach (char c in text2)
		{
			if ((c < '0' || c > '9') && ((Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) == "") & Directory.Exists("fffffff")))
			{
				Directory.EnumerateDirectories(string_1);
			}
		}
	}

	[CompilerGenerated]
	private static char smethod_1(string string_0)
	{
		return string_0[random_0.Next(string_0.Length)];
	}
}
