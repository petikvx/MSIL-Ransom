using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ns0;

internal sealed class Class17
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
	private struct Struct6
	{
	}

	private static readonly object object_0;

	private static readonly object object_1;

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	[SecuritySafeCritical]
	internal static bool smethod_0<T, U>(T gparam_0, U gparam_1, char char_0, short short_0)
	{
		int num = 0;
		bool result;
		do
		{
			result = (((char_0 ^ short_0) - 101) ^ num) switch
			{
				0 => object.ReferenceEquals(gparam_0, gparam_1), 
				_ => true, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_1<T, U, V>(T gparam_0, V gparam_1, U gparam_2, int int_0, char char_0) where T : AppDomain where V : string
	{
		int num = 0;
		switch (((int_0 ^ char_0) - 108) ^ 0)
		{
		case 0:
			gparam_0.SetData(gparam_1, gparam_2);
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static void smethod_2<T>(T gparam_0, AutoScaleMode autoScaleMode_0, char char_0, short short_0) where T : ContainerControl
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		switch (((char_0 ^ short_0) - 26) ^ 0)
		{
		case 0:
			((ContainerControl)gparam_0).set_AutoScaleMode(autoScaleMode_0);
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static void smethod_3<T>(T gparam_0, ref bool bool_0, short short_0, char char_0)
	{
		int num = 0;
		switch (((char_0 ^ short_0) - 103) ^ 0)
		{
		case 0:
			Monitor.Enter(gparam_0, ref bool_0);
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static void smethod_4<T, U>(U gparam_0, T gparam_1, short short_0, int int_0) where T : string where U : XElement
	{
		int num = 0;
		do
		{
			switch (((short_0 ^ int_0) - 77) ^ num)
			{
			case 0:
				((XElement)gparam_0).set_Value((string)gparam_1);
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static bool smethod_5<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : string where U : string
	{
		int num = 0;
		bool result = (((short_0 ^ char_0) - 39) ^ 0) switch
		{
			0 => gparam_0.Equals(gparam_1), 
			_ => false, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_6<T>(T gparam_0, Size size_0, short short_0, int int_0) where T : Form
	{
		int num = 0;
		switch (((int_0 ^ short_0) - 71) ^ 0)
		{
		case 0:
			((Form)gparam_0).set_ClientSize(size_0);
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static string smethod_7<T>(T gparam_0, short short_0, short short_1) where T : ResolveEventArgs
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((short_1 ^ short_0) - 114) ^ num) switch
			{
				0 => (string)(IConvertible)gparam_0.Name, 
				_ => null, 
			};
			num++;
			num2 = short_1 * short_1;
			num2 = short_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_8(bool bool_0, char char_0, int int_0)
	{
		int num = 0;
		do
		{
			switch (((int_0 ^ char_0) - 97) ^ num)
			{
			case 0:
				Application.SetCompatibleTextRenderingDefault(bool_0);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static string smethod_9<T>(T gparam_0, int int_0, short short_0) where T : XNamespace
	{
		int num = 0;
		string result;
		do
		{
			result = (((int_0 ^ short_0) - 103) ^ num) switch
			{
				0 => ((XNamespace)gparam_0).get_NamespaceName(), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static int smethod_10<T>(T gparam_0, byte[] byte_1, int int_0, int int_1, char char_0, char char_1) where T : Stream
	{
		int num = 0;
		int result = (((char_0 ^ char_1) - 99) ^ 0) switch
		{
			0 => gparam_0.Read(byte_1, int_0, int_1), 
			_ => 3, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_11<T, U>(T gparam_0, U gparam_1, char char_0, short short_0) where T : Hashtable
	{
		int num = 0;
		do
		{
			switch (((short_0 ^ char_0) - 27) ^ num)
			{
			case 0:
				gparam_0.Remove(gparam_1);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	static Class17()
	{
		object_1 = new char[39];
		char[] array = new char[8];
		array[6] = 'ċ';
		array[4] = '႕';
		array[7] = '∔';
		array[5] = '᎙';
		array[1] = '\u1a56';
		array[3] = 'Ӳ';
		array[2] = '⼒';
		array[0] = 'ᢐ';
		object_2 = new string[1];
		object_0 = array;
	}
}
