using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.MyServices;

namespace ns0;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Class6
{
	internal sealed class Class7
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 272)]
		private struct Struct1
		{
		}

		private static readonly object object_0;

		private static readonly object object_1;

		private static readonly Array array_0;

		internal static byte byte_0/* Not supported: data(00) */;

		[SecuritySafeCritical]
		internal static bool smethod_0<T>(T gparam_0, short short_0, int int_0) where T : WindowsFormsApplicationBase
		{
			int num = 0;
			bool result = (((short_0 ^ int_0) - 85) ^ 0) switch
			{
				0 => Class10.Class11.smethod_0<WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)gparam_0, 910, (short)928), 
				_ => false, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_1<T>(T gparam_0, short short_0, int int_0) where T : ApplicationSettingsBase
		{
			int num = 0;
			do
			{
				switch (((int_0 ^ short_0) - 29) ^ num)
				{
				case 0:
					Class10.smethod_0<ApplicationSettingsBase>((ApplicationSettingsBase)(object)gparam_0, 883, (short)799);
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static bool smethod_2<T, U>(U gparam_0, T gparam_1, short short_0, int int_0)
		{
			int num = 0;
			bool result;
			do
			{
				result = (((int_0 ^ short_0) - 33) ^ num) switch
				{
					0 => Class17.smethod_0((object)gparam_0, (object)gparam_1, 'Ş', (short)315), 
					_ => false, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static bool smethod_3<T, U>(U gparam_0, T gparam_1, char char_0, char char_1) where U : Hashtable
		{
			int num = 0;
			bool result;
			do
			{
				result = (((char_1 ^ char_0) - 104) ^ num) switch
				{
					0 => Class10.Class13.smethod_0((Hashtable)gparam_0, (object)gparam_1, 967, (short)929), 
					_ => true, 
				};
				num++;
			}
			while ((char_1 * char_1 + char_1) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static string smethod_4<T>(T gparam_0, string[] string_0, char char_0, int int_0) where T : string
		{
			int num = 0;
			string result;
			int num2;
			do
			{
				result = (((char_0 ^ int_0) - 73) ^ num) switch
				{
					0 => (string)(IComparable)Class10.Class11.smethod_1((string)gparam_0, string_0, 578, 'ɖ'), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static XAttribute smethod_5<T, U>(T gparam_0, U gparam_1, short short_0, char char_0) where T : XElement where U : XName
		{
			int num = 0;
			XAttribute result;
			do
			{
				result = (XAttribute)((((char_0 ^ short_0) - 63) ^ num) switch
				{
					0 => Class10.smethod_2<XName, XElement>((XElement)(object)gparam_0, (XName)(object)gparam_1, '\u0366', (short)876), 
					_ => null, 
				});
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_6<T, U, V>(U gparam_0, V gparam_1, T gparam_2, short short_0, short short_1) where U : XElement where V : XName
		{
			int num = 0;
			do
			{
				switch (((short_0 ^ short_1) - 52) ^ num)
				{
				case 0:
					Class10.Class12.smethod_1<XName, XElement, object>((XElement)(object)gparam_0, (XName)(object)gparam_1, (object)gparam_2, 707, (short)735);
					break;
				}
				num++;
			}
			while ((short_1 * short_1 + short_1) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static XName smethod_7<T>(T gparam_0, short short_0, short short_1) where T : XAttribute
		{
			int num = 0;
			XName result;
			do
			{
				result = (XName)((((short_1 ^ short_0) - 94) ^ num) switch
				{
					0 => Class10.Class11.smethod_2<XAttribute>((XAttribute)(object)gparam_0, (short)390, 416), 
					_ => null, 
				});
				num++;
			}
			while ((short_1 * short_1 + short_1) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static string smethod_8<T>(T gparam_0, short short_0, char char_0) where T : XName
		{
			int num = 0;
			string result = (((short_0 ^ char_0) - 74) ^ 0) switch
			{
				0 => (string)(ICloneable)Class10.Class13.smethod_1<XName>((XName)(object)gparam_0, 804, (short)865), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_9(char char_0, short short_0)
		{
			int num = 0;
			Assembly result = (((char_0 ^ short_0) - 100) ^ 0) switch
			{
				0 => Class10.Class13.smethod_2(524, 'ɳ'), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static bool smethod_10<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : Assembly where U : Assembly
		{
			int num = 0;
			bool result;
			do
			{
				result = (((int_0 ^ char_0) - 50) ^ num) switch
				{
					0 => Class10.Class12.smethod_2((Assembly)gparam_0, (Assembly)gparam_1, ',', 64), 
					_ => true, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_11<T, U, V>(T gparam_0, U gparam_1, V gparam_2, short short_0, char char_0) where T : AppDomain where U : string
		{
			int num = 0;
			switch (((short_0 ^ char_0) - 96) ^ 0)
			{
			case 0:
				Class17.smethod_1((AppDomain)gparam_0, (string)gparam_1, (object)gparam_2, 539, 'ɷ');
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static string[] smethod_12<T>(T gparam_0, char char_0, int int_0) where T : Assembly
		{
			int num = 0;
			string[] result = (((char_0 ^ int_0) - 97) ^ 0) switch
			{
				0 => Class10.Class12.smethod_3((Assembly)gparam_0, (short)208, 143), 
				_ => null, 
			};
			num++;
			return result;
		}

		static Class7()
		{
			object_1 = new char[136];
			char[] array = new char[8];
			array[1] = '㏑';
			array[0] = 'ତ';
			array[2] = '℡';
			array[4] = 'ⵁ';
			array[5] = '㦑';
			array[6] = 'Ẅ';
			array[3] = '\u0599';
			array[7] = '⛉';
			array_0 = new string[7];
			object_0 = array;
		}
	}

	internal sealed class Class8
	{
		[SecuritySafeCritical]
		internal static Assembly smethod_0<T>(T gparam_0, short short_0, char char_0) where T : Type
		{
			int num = 0;
			Assembly result = (((short_0 ^ char_0) - 42) ^ 0) switch
			{
				0 => Class10.Class13.smethod_3((Type)gparam_0, 'Τ', 967), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_1<T, U, V>(T gparam_0, V gparam_1, U gparam_2, short short_0, int int_0) where T : Hashtable
		{
			int num = 0;
			switch (((int_0 ^ short_0) - 14) ^ 0)
			{
			case 0:
				Class10.Class12.smethod_4((Hashtable)gparam_0, (object)gparam_1, (object)gparam_2, (short)359, 312);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_2<T>(T gparam_0, char char_0, short short_0) where T : Exception
		{
			int num = 0;
			do
			{
				switch (((short_0 ^ char_0) - 32) ^ num)
				{
				case 0:
					Class10.smethod_3((Exception)gparam_0, (short)706, 750);
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static string smethod_3<T>(T gparam_0, short short_0, int int_0) where T : XAttribute
		{
			int num = 0;
			string result = (((int_0 ^ short_0) - 87) ^ 0) switch
			{
				0 => Class10.Class12.smethod_5<XAttribute>((XAttribute)(object)gparam_0, (short)586, 'ȶ'), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_4<T, U>(U gparam_0, T gparam_1, char char_0, int int_0) where U : XObject
		{
			int num = 0;
			switch (((char_0 ^ int_0) - 79) ^ 0)
			{
			case 0:
				Class10.Class11.smethod_3<object, XObject>((XObject)(object)gparam_0, (object)gparam_1, 'Đ', (short)371);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static bool smethod_5<T, U>(U gparam_0, T gparam_1, short short_0, int int_0) where T : XNamespace where U : XNamespace
		{
			int num = 0;
			bool result;
			do
			{
				result = (((short_0 ^ int_0) - 32) ^ num) switch
				{
					0 => Class10.Class11.smethod_4<XNamespace, XNamespace>((XNamespace)(object)gparam_0, (XNamespace)(object)gparam_1, 285, 380), 
					_ => true, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_6(byte[] byte_0, byte[] byte_1, SecurityContextSource securityContextSource_0, int int_0, short short_0)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			Assembly result = (((short_0 ^ int_0) - 18) ^ 0) switch
			{
				0 => (Assembly)(ISerializable)Class10.smethod_4(byte_0, byte_1, securityContextSource_0, 'Ͱ', 859), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static string smethod_7<T>(T gparam_0, char char_0, short short_0) where T : SpecialDirectoriesProxy
		{
			int num = 0;
			string result = (((short_0 ^ char_0) - 12) ^ 0) switch
			{
				0 => (string)(ICloneable)Class10.Class13.smethod_4<SpecialDirectoriesProxy>((SpecialDirectoriesProxy)(object)gparam_0, 'ˡ', 741), 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	private static bool bool_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class7.smethod_2<object, object>(resourceManager_0, null, 312, 281))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("Ⴃ.ႨႳ", Class8.smethod_0(typeof(Class6), 103, 'M')));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	[SpecialName]
	internal static byte[] smethod_0()
	{
		return (byte[])smethod_2(smethod_4(ResourceManager_0, "Server", cultureInfo_0, 'Ȑ', 534), '\u0310', 817);
	}

	[SecuritySafeCritical]
	static Class6()
	{
		smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_1()
	{
		if (bool_0)
		{
			return;
		}
		Type typeFromHandle;
		Class10.Class13.smethod_5((object)(typeFromHandle = typeof(Class6)), 'ɯ', 'ȭ');
		try
		{
			if (!bool_0)
			{
				bool_0 = true;
				Class10.Class13.smethod_6<ResolveEventHandler, AppDomain>(Class10.smethod_5('{', 108), Class3.smethod_5, 238, 133);
			}
		}
		finally
		{
			Class10.Class13.smethod_5((object)typeFromHandle, 'ő', 'Ē');
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_2<T>(T gparam_0, char char_0, int int_0)
	{
		int num = 0;
		object result = (((int_0 ^ char_0) - 33) ^ 0) switch
		{
			0 => Class10.smethod_6((object)gparam_0, (short)914, 'Ϧ'), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_3<T>(T gparam_0, int int_0, short short_0)
	{
		int num = 0;
		switch (((short_0 ^ int_0) - 23) ^ 0)
		{
		case 0:
			Class10.Class13.smethod_5((object)gparam_0, 'ī', 'ů');
			break;
		case 1:
			Class10.Class13.smethod_5((object)gparam_0, 'ɶ', 'ȵ');
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static object smethod_4<T, U, V>(T gparam_0, U gparam_1, V gparam_2, char char_0, int int_0) where T : ResourceManager where U : string where V : CultureInfo
	{
		int num = 0;
		object result;
		do
		{
			result = (((int_0 ^ char_0) - 6) ^ num) switch
			{
				0 => Class10.smethod_7((ResourceManager)gparam_0, (string)gparam_1, (CultureInfo)gparam_2, 221, 'ñ'), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_5<T>(T gparam_0, short short_0, int int_0) where T : ResolveEventArgs
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		int num = 0;
		Assembly result = (((short_0 ^ int_0) - 110) ^ 0) switch
		{
			0 => (Assembly)(_Assembly)Class10.smethod_8((ResolveEventArgs)gparam_0, 504, (short)395), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static AppDomain smethod_6(short short_0, int int_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		int num = 0;
		AppDomain result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 11) ^ num) switch
			{
				0 => (AppDomain)(IEvidenceFactory)Class10.smethod_5('¹', 174), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_7<T>(T gparam_0, AutoScaleMode autoScaleMode_0, char char_0, int int_0) where T : ContainerControl
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		do
		{
			switch (((int_0 ^ char_0) - 7) ^ num)
			{
			case 0:
				Class17.smethod_2<ContainerControl>((ContainerControl)(object)gparam_0, autoScaleMode_0, 'ʭ', (short)695);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static void smethod_8(short short_0, short short_1)
	{
		int num = 0;
		do
		{
			switch (((short_1 ^ short_0) - 3) ^ num)
			{
			case 1:
				Class10.Class11.smethod_5('\u008c', '£');
				break;
			case 0:
				Class10.Class11.smethod_5('θ', 'Ζ');
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static byte[] smethod_9<T>(T gparam_0, char char_0, char char_1) where T : MemoryStream
	{
		int num = 0;
		byte[] result;
		int num2;
		do
		{
			result = (((char_1 ^ char_0) - 2) ^ num) switch
			{
				0 => (byte[])(IList)Class10.Class11.smethod_6((MemoryStream)gparam_0, 'ș', 'ȵ'), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static SpecialDirectoriesProxy smethod_10<T>(T gparam_0, char char_0, char char_1) where T : FileSystemProxy
	{
		int num = 0;
		SpecialDirectoriesProxy result = (SpecialDirectoriesProxy)((((char_0 ^ char_1) - 87) ^ 0) switch
		{
			0 => Class10.Class11.smethod_7<FileSystemProxy>((FileSystemProxy)(object)gparam_0, (short)892, 873), 
			_ => null, 
		});
		num++;
		return result;
	}
}
