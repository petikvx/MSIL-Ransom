using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;

namespace ns0;

internal sealed class Class10
{
	internal sealed class Class11
	{
		[SecuritySafeCritical]
		internal static bool smethod_0<T>(T gparam_0, int int_0, short short_0) where T : WindowsFormsApplicationBase
		{
			int num = 0;
			bool result;
			int num2;
			do
			{
				result = (((int_0 ^ short_0) - 46) ^ num) switch
				{
					0 => ((WindowsFormsApplicationBase)gparam_0).get_SaveMySettingsOnExit(), 
					_ => false, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static string smethod_1<T>(T gparam_0, string[] string_0, int int_0, char char_0) where T : string
		{
			int num = 0;
			string result;
			int num2;
			do
			{
				result = (((char_0 ^ int_0) - 20) ^ num) switch
				{
					0 => (string)(IComparable)Utils.GetResourceString((string)gparam_0, string_0), 
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
		internal static XName smethod_2<T>(T gparam_0, short short_0, int int_0) where T : XAttribute
		{
			int num = 0;
			XName result;
			do
			{
				result = (XName)((((short_0 ^ int_0) - 38) ^ num) switch
				{
					0 => ((XAttribute)gparam_0).get_Name(), 
					_ => null, 
				});
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_3<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where U : XObject
		{
			int num = 0;
			do
			{
				switch (((short_0 ^ char_0) - 99) ^ num)
				{
				case 0:
					((XObject)gparam_0).AddAnnotation((object)gparam_1);
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static bool smethod_4<T, U>(U gparam_0, T gparam_1, int int_0, int int_1) where T : XNamespace where U : XNamespace
		{
			int num = 0;
			bool result = (((int_0 ^ int_1) - 97) ^ 0) switch
			{
				0 => (XNamespace)(object)gparam_0 == (XNamespace)(object)gparam_1, 
				_ => true, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_5(char char_0, char char_1)
		{
			int num = 0;
			switch (((char_0 ^ char_1) - 46) ^ 0)
			{
			case 0:
				ProjectData.ClearProjectError();
				break;
			case 1:
				ProjectData.EndApp();
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static byte[] smethod_6<T>(T gparam_0, char char_0, char char_1) where T : MemoryStream
		{
			int num = 0;
			byte[] result;
			do
			{
				result = (((char_1 ^ char_0) - 44) ^ num) switch
				{
					0 => (byte[])(Array)gparam_0.ToArray(), 
					_ => null, 
				};
				num++;
			}
			while ((char_1 * char_1 + char_1) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static SpecialDirectoriesProxy smethod_7<T>(T gparam_0, short short_0, int int_0) where T : FileSystemProxy
		{
			int num = 0;
			SpecialDirectoriesProxy result;
			int num2;
			do
			{
				result = (SpecialDirectoriesProxy)((((int_0 ^ short_0) - 21) ^ num) switch
				{
					0 => ((FileSystemProxy)gparam_0).get_SpecialDirectories(), 
					_ => null, 
				});
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static Exception smethod_8(int int_0, short short_0, char char_0)
		{
			int num = 0;
			Exception result;
			do
			{
				result = (((char_0 ^ short_0) - 77) ^ num) switch
				{
					0 => ProjectData.CreateProjectError(int_0), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_9<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : Form where U : EventHandler
		{
			int num = 0;
			switch (((int_0 ^ int_1) - 28) ^ 0)
			{
			case 0:
				((Form)gparam_0).add_Load((EventHandler)gparam_1);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static string smethod_10<T>(T gparam_0, char char_0, int int_0) where T : Exception
		{
			int num = 0;
			string result = (((char_0 ^ int_0) - 97) ^ 0) switch
			{
				0 => (string)(IEnumerable)gparam_0.Message, 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static FileSystemProxy smethod_11<T>(T gparam_0, char char_0, int int_0) where T : ServerComputer
		{
			int num = 0;
			FileSystemProxy result;
			int num2;
			do
			{
				result = (FileSystemProxy)((((int_0 ^ char_0) - 18) ^ num) switch
				{
					0 => ((ServerComputer)gparam_0).get_FileSystem(), 
					_ => null, 
				});
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_12<T>(T gparam_0, byte[] byte_0, int int_0, char char_0) where T : string
		{
			int num = 0;
			switch (((char_0 ^ int_0) - 80) ^ 0)
			{
			case 0:
				File.WriteAllBytes(gparam_0, byte_0);
				break;
			}
			num++;
		}
	}

	internal sealed class Class12
	{
		[SecuritySafeCritical]
		internal static string smethod_0<T>(T gparam_0, char char_0, char char_1)
		{
			int num = 0;
			string result;
			int num2;
			do
			{
				result = (((char_1 ^ char_0) - 35) ^ num) switch
				{
					0 => (string)(IEquatable<string>)gparam_0.ToString(), 
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
		internal static void smethod_1<T, U, V>(U gparam_0, T gparam_1, V gparam_2, int int_0, short short_0) where T : XName where U : XElement
		{
			int num = 0;
			do
			{
				switch (((int_0 ^ short_0) - 28) ^ num)
				{
				case 0:
					((XElement)gparam_0).SetAttributeValue((XName)(object)gparam_1, (object)gparam_2);
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static bool smethod_2<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : Assembly where U : Assembly
		{
			int num = 0;
			bool result = (((char_0 ^ int_0) - 108) ^ 0) switch
			{
				0 => (Assembly?)gparam_0 != (Assembly?)gparam_1, 
				_ => true, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static string[] smethod_3<T>(T gparam_0, short short_0, int int_0) where T : Assembly
		{
			int num = 0;
			string[] result;
			do
			{
				result = (((int_0 ^ short_0) - 95) ^ num) switch
				{
					0 => (string[])(Array)gparam_0.GetManifestResourceNames(), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_4<T, U, V>(U gparam_0, T gparam_1, V gparam_2, short short_0, int int_0) where U : Hashtable
		{
			int num = 0;
			switch (((short_0 ^ int_0) - 95) ^ 0)
			{
			case 0:
				gparam_0.Add(gparam_1, gparam_2);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static string smethod_5<T>(T gparam_0, short short_0, char char_0) where T : XAttribute
		{
			int num = 0;
			string result;
			do
			{
				result = (((short_0 ^ char_0) - 124) ^ num) switch
				{
					0 => (string)(IEquatable<string>)(string)(XAttribute)(object)gparam_0, 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static SettingsBase smethod_6<T>(T gparam_0, short short_0, char char_0) where T : SettingsBase
		{
			int num = 0;
			SettingsBase result = (SettingsBase)((((char_0 ^ short_0) - 21) ^ 0) switch
			{
				0 => SettingsBase.Synchronized((SettingsBase)(object)gparam_0), 
				_ => null, 
			});
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static bool smethod_7<T>(T gparam_0, short short_0, char char_0) where T : WeakReference
		{
			int num = 0;
			bool result = (((char_0 ^ short_0) - 44) ^ 0) switch
			{
				0 => gparam_0.IsAlive, 
				_ => true, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_8<T>(T gparam_0, bool bool_0, int int_0, int int_1) where T : WindowsFormsApplicationBase
		{
			int num = 0;
			switch (((int_0 ^ int_1) - 127) ^ 0)
			{
			case 0:
				((WindowsFormsApplicationBase)gparam_0).set_SaveMySettingsOnExit(bool_0);
				break;
			}
			num++;
		}
	}

	internal sealed class Class13
	{
		internal sealed class Class14
		{
			internal IContainer icontainer_0;

			internal Class14()
			{
			}
		}

		internal sealed class Class15
		{
			internal sealed class Class16
			{
				internal string[] string_0;

				internal Class16()
				{
				}
			}

			internal XNamespace[] xnamespace_0;

			internal Class15()
			{
			}
		}

		[SecuritySafeCritical]
		internal static bool smethod_0<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : Hashtable
		{
			int num = 0;
			bool result = (((int_0 ^ short_0) - 102) ^ 0) switch
			{
				0 => gparam_0.ContainsKey(gparam_1), 
				_ => false, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static string smethod_1<T>(T gparam_0, int int_0, short short_0) where T : XName
		{
			int num = 0;
			string result = (((short_0 ^ int_0) - 69) ^ 0) switch
			{
				0 => (string)(IComparable)((XName)gparam_0).get_LocalName(), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_2(int int_0, char char_0)
		{
			int num = 0;
			Assembly result = (((char_0 ^ int_0) - 127) ^ 0) switch
			{
				0 => (Assembly)(ICustomAttributeProvider)Assembly.GetExecutingAssembly(), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static Assembly smethod_3<T>(T gparam_0, char char_0, int int_0) where T : Type
		{
			int num = 0;
			Assembly result = (((int_0 ^ char_0) - 99) ^ 0) switch
			{
				0 => gparam_0.Assembly, 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static string smethod_4<T>(T gparam_0, char char_0, int int_0) where T : SpecialDirectoriesProxy
		{
			int num = 0;
			string result = (((char_0 ^ int_0) - 4) ^ 0) switch
			{
				0 => (string)(ICloneable)((SpecialDirectoriesProxy)gparam_0).get_Temp(), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_5<T>(T gparam_0, char char_0, char char_1)
		{
			int num = 0;
			switch (((char_1 ^ char_0) - 66) ^ 0)
			{
			case 0:
				Monitor.Enter(gparam_0);
				break;
			case 1:
				Monitor.Exit(gparam_0);
				break;
			case 2:
				ObjectFlowControl.CheckForSyncLockOnValueType((object)gparam_0);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_6<T, U>(U gparam_0, T gparam_1, int int_0, int int_1) where T : ResolveEventHandler where U : AppDomain
		{
			int num = 0;
			switch (((int_0 ^ int_1) - 107) ^ 0)
			{
			case 0:
				gparam_0.ResourceResolve += gparam_1;
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_7<T, U>(U gparam_0, T gparam_1, short short_0, char char_0) where T : string where U : Form
		{
			int num = 0;
			int num2;
			do
			{
				switch (((short_0 ^ char_0) - 35) ^ num)
				{
				case 0:
					((Form)gparam_0).set_Text((string)gparam_1);
					break;
				}
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static Exception smethod_8<T>(T gparam_0, char char_0, short short_0) where T : Exception
		{
			int num = 0;
			Exception result = (((short_0 ^ char_0) - 1) ^ 0) switch
			{
				0 => gparam_0.InnerException, 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_9<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, short short_0, short short_1) where T : Stream
		{
			int num = 0;
			switch (((short_0 ^ short_1) - 119) ^ 0)
			{
			case 0:
				gparam_0.Write(byte_0, int_0, int_1);
				break;
			}
			num++;
		}

		[SecuritySafeCritical]
		internal static void smethod_10<T, U>(T gparam_0, U gparam_1, int int_0, char char_0) where T : WindowsFormsApplicationBase where U : ShutdownEventHandler
		{
			int num = 0;
			int num2;
			do
			{
				switch (((char_0 ^ int_0) - 68) ^ num)
				{
				case 0:
					((WindowsFormsApplicationBase)gparam_0).add_Shutdown((ShutdownEventHandler)(object)gparam_1);
					break;
				}
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		[SecuritySafeCritical]
		internal static string smethod_11<T>(T gparam_0, int int_0, short short_0) where T : XElement
		{
			int num = 0;
			string result;
			int num2;
			do
			{
				result = (((short_0 ^ int_0) - 82) ^ num) switch
				{
					0 => (string)(IEnumerable)((XElement)gparam_0).get_Value(), 
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
		internal static XAttribute smethod_12<T>(T gparam_0, char char_0, char char_1) where T : XAttribute
		{
			int num = 0;
			XAttribute result;
			int num2;
			do
			{
				result = (XAttribute)((((char_0 ^ char_1) - 42) ^ num) switch
				{
					0 => ((XAttribute)gparam_0).get_NextAttribute(), 
					_ => null, 
				});
				num++;
				num2 = char_1 * char_1;
				num2 = char_1 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static string smethod_13<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : string where U : string
		{
			int num = 0;
			string result = (((int_0 ^ short_0) - 109) ^ 0) switch
			{
				0 => (string)(IComparable<string>)string.Concat(gparam_0, gparam_1), 
				_ => null, 
			};
			num++;
			return result;
		}

		[SecuritySafeCritical]
		internal static void smethod_14<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : Control where U : string
		{
			int num = 0;
			switch (((int_0 ^ int_1) - 68) ^ 0)
			{
			case 0:
				((Control)gparam_0).set_Name((string)gparam_1);
				break;
			}
			num++;
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_0<T>(T gparam_0, int int_0, short short_0) where T : ApplicationSettingsBase
	{
		int num = 0;
		do
		{
			switch (((short_0 ^ int_0) - 108) ^ num)
			{
			case 0:
				((ApplicationSettingsBase)gparam_0).Save();
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static StringBuilder smethod_1<T>(T gparam_0, char char_0, char char_1, short short_0) where T : StringBuilder
	{
		int num = 0;
		StringBuilder result;
		int num2;
		do
		{
			result = (((short_0 ^ char_1) - 3) ^ num) switch
			{
				0 => gparam_0.Append(char_0), 
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
	internal static XAttribute smethod_2<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : XName where U : XElement
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		int num = 0;
		XAttribute result;
		int num2;
		do
		{
			result = (XAttribute)((((char_0 ^ short_0) - 10) ^ num) switch
			{
				0 => (object)(XObject)((XElement)gparam_0).Attribute((XName)(object)gparam_1), 
				_ => null, 
			});
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_3<T>(T gparam_0, short short_0, int int_0) where T : Exception
	{
		int num = 0;
		switch (((short_0 ^ int_0) - 44) ^ 0)
		{
		case 0:
			ProjectData.SetProjectError((Exception)gparam_0);
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_4(byte[] byte_0, byte[] byte_1, SecurityContextSource securityContextSource_0, char char_0, int int_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		Assembly result;
		int num2;
		do
		{
			result = (((int_0 ^ char_0) - 43) ^ num) switch
			{
				0 => (Assembly)(ISerializable)Assembly.Load(byte_0, byte_1, securityContextSource_0), 
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
	internal static AppDomain smethod_5(char char_0, int int_0)
	{
		int num = 0;
		AppDomain result = (((char_0 ^ int_0) - 23) ^ 0) switch
		{
			0 => (AppDomain)(MarshalByRefObject)AppDomain.CurrentDomain, 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static object smethod_6<T>(T gparam_0, short short_0, char char_0)
	{
		int num = 0;
		object result = (((short_0 ^ char_0) - 116) ^ 0) switch
		{
			0 => RuntimeHelpers.GetObjectValue(gparam_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static object smethod_7<T, U, V>(T gparam_0, V gparam_1, U gparam_2, int int_0, char char_0) where T : ResourceManager where U : CultureInfo where V : string
	{
		int num = 0;
		object result = (((int_0 ^ char_0) - 44) ^ 0) switch
		{
			0 => gparam_0.GetObject(gparam_1, gparam_2), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_8<T>(T gparam_0, int int_0, short short_0) where T : ResolveEventArgs
	{
		int num = 0;
		Assembly result;
		int num2;
		do
		{
			result = (((int_0 ^ short_0) - 115) ^ num) switch
			{
				0 => gparam_0.RequestingAssembly, 
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
	internal static void smethod_9<T>(T gparam_0, bool bool_0, char char_0, short short_0) where T : Control
	{
		int num = 0;
		do
		{
			switch (((char_0 ^ short_0) - 33) ^ num)
			{
			case 0:
				((Control)gparam_0).ResumeLayout(bool_0);
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static bool smethod_10<T>(T gparam_0, char char_0, int int_0) where T : XAttribute
	{
		int num = 0;
		bool result = (((char_0 ^ int_0) - 49) ^ 0) switch
		{
			0 => ((XAttribute)gparam_0).get_IsNamespaceDeclaration(), 
			_ => false, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_11<T>(T gparam_0, char char_0, char char_1) where T : XAttribute
	{
		int num = 0;
		switch (((char_0 ^ char_1) - 108) ^ 0)
		{
		case 0:
			((XAttribute)gparam_0).Remove();
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static void smethod_12<T>(T gparam_0, char char_0, int int_0) where T : Control
	{
		int num = 0;
		int num2;
		do
		{
			switch (((char_0 ^ int_0) - 89) ^ num)
			{
			case 0:
				((Control)gparam_0).SuspendLayout();
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static void smethod_13<T>(T gparam_0, SizeF sizeF_0, int int_0, char char_0) where T : ContainerControl
	{
		int num = 0;
		do
		{
			switch (((char_0 ^ int_0) - 31) ^ num)
			{
			case 0:
				((ContainerControl)gparam_0).set_AutoScaleDimensions(sizeF_0);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static object smethod_14<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : AppDomain where U : string
	{
		int num = 0;
		object result = (((int_0 ^ int_1) - 94) ^ 0) switch
		{
			0 => gparam_0.GetData(gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_15<T>(T gparam_0, string[] string_0, char char_0, char char_1) where T : WindowsFormsApplicationBase
	{
		int num = 0;
		int num2;
		do
		{
			switch (((char_1 ^ char_0) - 43) ^ num)
			{
			case 0:
				((WindowsFormsApplicationBase)gparam_0).Run(string_0);
				break;
			}
			num++;
			num2 = char_1 * char_1;
			num2 = char_1 + num2;
		}
		while (num2 % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static XAttribute smethod_16<T>(T gparam_0, int int_0, char char_0) where T : XElement
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		int num = 0;
		XAttribute result;
		do
		{
			result = (XAttribute)((((int_0 ^ char_0) - 89) ^ num) switch
			{
				0 => (object)(XObject)((XElement)gparam_0).get_FirstAttribute(), 
				_ => null, 
			});
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static Process smethod_17<T>(T gparam_0, int int_0, char char_0) where T : string
	{
		int num = 0;
		Process result = (((char_0 ^ int_0) - 90) ^ 0) switch
		{
			0 => Process.Start(gparam_0), 
			_ => null, 
		};
		num++;
		return result;
	}
}
