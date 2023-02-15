using System;
using System.Runtime.CompilerServices;
using ns0;

namespace ns1;

internal sealed class Class2
{
	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly Enum0 enum0_0;

	[CompilerGenerated]
	private readonly string string_3;

	public Class2(string string_4, string string_5, string string_6, Enum0 enum0_1, string string_7)
	{
		if (Enum0.flag_4 == enum0_1 && "IPC$" == string_5)
		{
			enum0_1 |= Enum0.flag_3;
		}
		string_0 = string_4;
		string_1 = string_5;
		string_2 = string_6;
		enum0_0 = enum0_1;
		string_3 = string_7;
	}

	string object.ToString()
	{
		if (string.IsNullOrEmpty(method_1()))
		{
			return $"\\\\{Environment.MachineName}\\{method_2()}";
		}
		return $"\\\\{method_1()}\\{method_2()}";
	}

	public bool method_0(string string_4)
	{
		if (!method_5())
		{
			return false;
		}
		if (string.IsNullOrEmpty(string_4))
		{
			return true;
		}
		return string_4.ToLower().StartsWith(method_3().ToLower());
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_1()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_2()
	{
		return string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_3()
	{
		return string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public Enum0 method_4()
	{
		return enum0_0;
	}

	[SpecialName]
	public bool method_5()
	{
		if ((method_4() & Enum0.flag_2) != 0)
		{
			return false;
		}
		if ((method_4() & Enum0.flag_3) != 0)
		{
			return false;
		}
		if ((method_4() & Enum0.flag_1) != 0)
		{
			return false;
		}
		if ((method_4() & Enum0.flag_4) == 0)
		{
			return true;
		}
		if (Enum0.flag_4 == method_4() && !string.IsNullOrEmpty(method_2()))
		{
			return true;
		}
		return false;
	}
}
