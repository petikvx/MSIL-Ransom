using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

public sealed class GClass14
{
	public string string_0;

	public string string_1;

	private int int_0;

	[DllImport("C:\\Windows\\Microlap.dll")]
	private static extern bool Attach(int int_1, int int_2);

	[DllImport("C:\\Windows\\Microlap.dll")]
	private static extern uint ReadMem(ulong ulong_0);

	[DllImport("C:\\Windows\\Microlap.dll")]
	private static extern byte ReadMemByte(ulong ulong_0);

	[DllImport("C:\\Windows\\Microlap.dll")]
	private static extern bool WriteMem(ulong ulong_0, uint uint_0);

	[DllImport("C:\\Windows\\Microlap.dll")]
	private static extern bool WriteMemProtect(ulong ulong_0, uint uint_0);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(int int_1, bool bool_0, int int_2);

	[DllImport("kernel32.dll")]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_1, ref int int_2);

	[DllImport("kernel32.dll")]
	private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_1, ref int int_2);

	public int method_0()
	{
		return int_0;
	}

	public void method_1(int int_1)
	{
		int_0 = int_1;
	}

	private IntPtr method_2(string string_2)
	{
		IntPtr intPtr = (IntPtr)0;
		string[] array = string_2.Split(new char[1] { ',' });
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (text.Length > 10 && text.Substring(0, 11) == Class60.smethod_0(-2050226480))
			{
				intPtr = IntPtr.Add((IntPtr)4194304, int.Parse(string_0.Substring(2, 8), NumberStyles.HexNumber));
				continue;
			}
			if (text.Length > 3 && text.Substring(0, 4) == Class60.smethod_0(-2050226526))
			{
				intPtr = IntPtr.Add((IntPtr)4194304, int.Parse(text.Substring(7, 8), NumberStyles.HexNumber));
				continue;
			}
			string s = method_3(intPtr).ToString(Class60.smethod_0(-2050211142));
			intPtr = (IntPtr)int.Parse(s, NumberStyles.HexNumber);
			intPtr = IntPtr.Add(intPtr, int.Parse(text.Substring(2, text.Length - 2), NumberStyles.HexNumber));
		}
		return intPtr;
	}

	private int method_3(IntPtr intptr_0)
	{
		try
		{
			return (int)ReadMem((uint)(int)intptr_0);
		}
		catch
		{
			return 0;
		}
	}

	public Process[] method_4(string string_2)
	{
		Process[] processesByName = Process.GetProcessesByName(string_2);
		if (processesByName.Length != 0)
		{
			return processesByName;
		}
		return null;
	}

	public bool method_5(int int_1, int int_2)
	{
		try
		{
			if (int_1 > 0)
			{
				if (Attach(int_1, int_2))
				{
					return true;
				}
				return false;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public bool method_6(int int_1)
	{
		try
		{
			if (int_1 > 0)
			{
				if (OpenProcess(2035711, bool_0: false, int_1) != IntPtr.Zero)
				{
					return true;
				}
				return false;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	private byte method_7(ulong ulong_0, int[] int_1)
	{
		uint num = 0u;
		uint num2 = 0u;
		num = ReadMem(ulong_0);
		if (int_1[0] != 0)
		{
			for (int i = 0; i < int_1.Length; i++)
			{
				num2 = num + (uint)int_1[i];
				num = ReadMem(num2);
			}
			return ReadMemByte(num2);
		}
		return ReadMemByte(ulong_0);
	}

	public string method_8(string string_2)
	{
		byte[] array = new byte[32];
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		try
		{
			ulong num = 0uL;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = method_7((uint)(int)method_2(string_2) + num, new int[1]);
				num++;
			}
			return aSCIIEncoding.GetString(array);
		}
		catch
		{
			return string.Empty;
		}
	}

	public int method_9(string string_2)
	{
		try
		{
			return (int)ReadMem((uint)(int)method_2(string_2));
		}
		catch
		{
			return 0;
		}
	}

	public void method_10(string string_2, string string_3, string string_4)
	{
		WriteMem((uint)(int)method_2(string_2), uint.Parse(string_4));
	}

	public void method_11(string string_2, string string_3, string string_4)
	{
		WriteMemProtect(ulong.Parse(string_2.Substring(2, 8), NumberStyles.HexNumber), uint.Parse(string_4));
	}
}
