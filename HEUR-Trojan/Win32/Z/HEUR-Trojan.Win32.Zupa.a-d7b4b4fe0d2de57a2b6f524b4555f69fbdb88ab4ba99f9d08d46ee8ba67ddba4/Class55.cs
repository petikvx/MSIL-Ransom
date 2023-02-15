using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;

internal sealed class Class55
{
	[Serializable]
	private sealed class Class56
	{
		public static readonly Class56 class56_0 = new Class56();

		public static Func<NetworkInterface, bool> func_0;

		public static Func<NetworkInterface, string> func_1;

		public static Func<NetworkInterface, bool> func_2;

		public static Func<NetworkInterface, string> func_3;

		public static Func<NetworkInterface, bool> func_4;

		public static Func<NetworkInterface, string> func_5;

		internal bool method_0(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.NetworkInterfaceType == NetworkInterfaceType.Ethernet;
		}

		internal string method_1(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.GetPhysicalAddress().ToString();
		}

		internal bool method_2(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.NetworkInterfaceType == NetworkInterfaceType.GigabitEthernet;
		}

		internal string method_3(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.GetPhysicalAddress().ToString();
		}

		internal bool method_4(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.NetworkInterfaceType == NetworkInterfaceType.Wireless80211;
		}

		internal string method_5(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.GetPhysicalAddress().ToString();
		}
	}

	public struct Struct23
	{
		private List<int> list_0;

		public List<int> method_0()
		{
			return list_0;
		}

		public void method_1()
		{
			List<int> list = new List<int>();
			list.Add(1478956);
			list.Add(1478957);
			list.Add(1478958);
			list.Add(1478959);
			list.Add(1478960);
			list.Add(1478961);
			list.Add(1478962);
			list.Add(1478963);
			list.Add(1478964);
			list.Add(1478965);
			list.Add(1478966);
			list.Add(1478967);
			list.Add(1478968);
			list.Add(1478969);
			list.Add(1789171);
			list.Add(1789198);
			list.Add(1789206);
			list.Add(1789215);
			list.Add(1789219);
			list.Add(1789231);
			list.Add(1789243);
			list.Add(1789247);
			list.Add(1789250);
			list.Add(1789256);
			list.Add(1789224);
			list.Add(1789239);
			list.Add(1789246);
			list.Add(1789326);
			list.Add(1789329);
			list.Add(1789340);
			list.Add(1789348);
			list.Add(1789355);
			list.Add(1789376);
			list.Add(1789388);
			list.Add(1789323);
			list.Add(1789221);
			list.Add(1789238);
			list.Add(331308);
			list.Add(1789251);
			list.Add(1789264);
			list.Add(1789266);
			list.Add(1789272);
			list.Add(1789291);
			list.Add(1789297);
			list.Add(1789301);
			list.Add(1789259);
			list.Add(1789262);
			list.Add(1789269);
			list.Add(1789270);
			list.Add(1789273);
			list.Add(1789279);
			list.Add(1789280);
			list.Add(1789320);
			list.Add(1789341);
			list.Add(1789343);
			list.Add(1789353);
			list.Add(1789362);
			list.Add(1789366);
			list.Add(1789370);
			list.Add(1789342);
			list.Add(1789357);
			list.Add(1789367);
			list.Add(1789371);
			list.Add(1789374);
			list.Add(1789387);
			list.Add(1478955);
			list.Add(1478956);
			list.Add(1478957);
			list.Add(1478958);
			list.Add(1478959);
			list.Add(1478960);
			list.Add(1478961);
			list.Add(1478962);
			list.Add(1478963);
			list.Add(1478964);
			list.Add(1478965);
			list.Add(1478966);
			list.Add(1478967);
			list.Add(1478968);
			list.Add(1478969);
			list.Add(1789171);
			list.Add(1789198);
			list.Add(1789206);
			list.Add(1789215);
			list.Add(1789219);
			list.Add(1789231);
			list.Add(1789243);
			list.Add(1789247);
			list.Add(1789250);
			list.Add(1789256);
			list.Add(1789224);
			list.Add(1789239);
			list.Add(1789246);
			list.Add(1789326);
			list.Add(1789329);
			list.Add(1789340);
			list.Add(1789348);
			list.Add(1789355);
			list.Add(1789376);
			list.Add(1789388);
			list.Add(1789323);
			list.Add(1789221);
			list.Add(1789238);
			list.Add(1789251);
			list.Add(1789264);
			list.Add(1789266);
			list.Add(1789272);
			list.Add(1789291);
			list.Add(1789297);
			list.Add(331308);
			list.Add(1789301);
			list.Add(1789259);
			list.Add(1789262);
			list.Add(1789269);
			list.Add(1789270);
			list.Add(1789273);
			list.Add(1789279);
			list.Add(1789280);
			list.Add(1789320);
			list.Add(1789341);
			list.Add(1789343);
			list.Add(1789353);
			list.Add(1789362);
			list.Add(1789366);
			list.Add(1789370);
			list.Add(1789342);
			list.Add(1789357);
			list.Add(1789367);
			list.Add(1789371);
			list.Add(1789374);
			list.Add(1789387);
			list.Add(1478955);
			list.Add(1478956);
			list.Add(1478957);
			list.Add(1478958);
			list.Add(1478959);
			list.Add(1478960);
			list.Add(1478961);
			list.Add(1478962);
			list.Add(1478963);
			list.Add(1478964);
			list.Add(1478965);
			list.Add(1478966);
			list.Add(1478967);
			list.Add(1478968);
			list.Add(1478969);
			list.Add(1789171);
			list.Add(1789198);
			list.Add(1789206);
			list.Add(1789215);
			list.Add(1789219);
			list.Add(1789231);
			list.Add(1789243);
			list.Add(1789247);
			list.Add(1789250);
			list.Add(1789256);
			list.Add(1789224);
			list.Add(1789239);
			list.Add(1789246);
			list.Add(1789326);
			list.Add(1789329);
			list.Add(1789340);
			list.Add(1789348);
			list.Add(1789355);
			list.Add(1789376);
			list.Add(1789388);
			list.Add(1789323);
			list.Add(1789221);
			list.Add(1789238);
			list.Add(1789251);
			list.Add(331308);
			list.Add(1789264);
			list.Add(1789266);
			list.Add(1789272);
			list.Add(1789291);
			list.Add(1789297);
			list.Add(1789301);
			list.Add(1789259);
			list.Add(1789262);
			list.Add(1789269);
			list.Add(1789270);
			list.Add(1789273);
			list.Add(1789279);
			list.Add(1789280);
			list.Add(1789320);
			list.Add(1789341);
			list.Add(1789343);
			list.Add(1789353);
			list.Add(1789362);
			list.Add(1789366);
			list.Add(1789370);
			list.Add(1789342);
			list.Add(1789357);
			list.Add(1789367);
			list.Add(1789371);
			list.Add(1789374);
			list.Add(1789387);
			list.Add(1478955);
			list.Add(1478956);
			list.Add(1478957);
			list.Add(1478958);
			list.Add(1478959);
			list.Add(1478960);
			list.Add(1478961);
			list.Add(1478962);
			list.Add(1478963);
			list.Add(1478964);
			list.Add(1478965);
			list.Add(1478966);
			list.Add(1478967);
			list.Add(331308);
			list.Add(1478968);
			list.Add(1478969);
			list.Add(1789171);
			list.Add(1789198);
			list.Add(1789206);
			list.Add(1789215);
			list.Add(1789219);
			list.Add(1789231);
			list.Add(1789243);
			list.Add(1789247);
			list.Add(1789250);
			list.Add(1789256);
			list.Add(1789224);
			list.Add(1789239);
			list.Add(1789246);
			list.Add(1789326);
			list.Add(1789329);
			list.Add(1789340);
			list.Add(1789348);
			list.Add(1789355);
			list.Add(1789376);
			list.Add(1789388);
			list.Add(1789323);
			list.Add(1789221);
			list.Add(1789238);
			list.Add(1789251);
			list.Add(1789264);
			list.Add(1789266);
			list.Add(1789272);
			list.Add(1789291);
			list.Add(1789297);
			list.Add(1789301);
			list.Add(1789259);
			list.Add(1789262);
			list.Add(1789269);
			list.Add(1789270);
			list.Add(1789273);
			list.Add(1789279);
			list.Add(1789280);
			list.Add(1789320);
			list.Add(1789341);
			list.Add(1789343);
			list.Add(1789353);
			list.Add(1789362);
			list.Add(1789366);
			list.Add(1789370);
			list.Add(1789342);
			list.Add(1789357);
			list.Add(1789367);
			list.Add(1789371);
			list.Add(1789374);
			list.Add(1789387);
			list_0 = list;
		}
	}

	public struct Struct24
	{
		[Serializable]
		private sealed class Class57
		{
			public static readonly Class57 class57_0 = new Class57();

			public static Func<KeyValuePair<int, string>, string> func_0;

			public static Func<KeyValuePair<int, string>, int> func_1;

			public static Func<KeyValuePair<int, string>, string> func_2;

			internal string method_0(KeyValuePair<int, string> keyValuePair_0)
			{
				return keyValuePair_0.Value;
			}

			internal int method_1(KeyValuePair<int, string> keyValuePair_0)
			{
				return keyValuePair_0.Key;
			}

			internal string method_2(KeyValuePair<int, string> keyValuePair_0)
			{
				return keyValuePair_0.Value;
			}
		}

		private Dictionary<int, string> dictionary_0;

		public Dictionary<int, string> method_0()
		{
			return dictionary_0;
		}

		public void method_1(List<GClass0> list_0)
		{
			if (list_0 == null || list_0.Count() <= 0)
			{
				return;
			}
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			foreach (GClass0 item in list_0)
			{
				dictionary.Add(item.ID, item.NAME);
			}
			dictionary_0 = dictionary.OrderBy(Class57.class57_0.method_0).ToDictionary(Class57.class57_0.method_1, Class57.class57_0.method_2);
		}
	}

	public struct Struct25
	{
		private Dictionary<int, string> dictionary_0;

		public int method_0()
		{
			return 28;
		}

		public int method_1()
		{
			return 29;
		}

		public int method_2()
		{
			return 34;
		}

		public int method_3()
		{
			return 45;
		}

		public int method_4()
		{
			return 60;
		}

		public int method_5()
		{
			return 61;
		}

		public int method_6()
		{
			return 66;
		}

		public int method_7()
		{
			return 73;
		}

		public int method_8()
		{
			return 74;
		}

		public int method_9()
		{
			return 75;
		}

		public int method_10()
		{
			return 111;
		}

		public int method_11()
		{
			return 112;
		}

		public int method_12()
		{
			return 113;
		}

		public int method_13()
		{
			return 114;
		}

		public int method_14()
		{
			return 155;
		}

		public int method_15()
		{
			return 249;
		}

		public int method_16()
		{
			return 252;
		}

		public int method_17()
		{
			return 254;
		}

		public int method_18()
		{
			return 257;
		}

		public int method_19()
		{
			return 258;
		}

		public int method_20()
		{
			return 261;
		}

		public int method_21()
		{
			return 275;
		}

		public int method_22()
		{
			return 276;
		}

		public int method_23()
		{
			return 279;
		}

		public int method_24()
		{
			return 290;
		}

		public int method_25()
		{
			return 355;
		}

		public int method_26()
		{
			return 357;
		}

		public int method_27()
		{
			return 380;
		}

		public int method_28()
		{
			return 383;
		}

		public int method_29()
		{
			return 401;
		}

		public int method_30()
		{
			return 475;
		}

		public int method_31()
		{
			return 482;
		}

		public int method_32()
		{
			return 2001;
		}

		public int method_33()
		{
			return 2041;
		}

		public int method_34()
		{
			return 2042;
		}

		public int method_35()
		{
			return 2043;
		}

		public int method_36()
		{
			return 2045;
		}

		public int method_37()
		{
			return 2054;
		}

		public int method_38()
		{
			return 2234;
		}

		public int method_39()
		{
			return 2286;
		}

		public int method_40()
		{
			return 2338;
		}

		public int method_41()
		{
			return 2515;
		}

		public int method_42()
		{
			return 5035;
		}

		public Dictionary<int, string> method_43()
		{
			return dictionary_0;
		}

		public void method_44()
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			dictionary.Add(45, Class60.smethod_0(-2050208788));
			dictionary.Add(74, Class60.smethod_0(-2050208824));
			dictionary.Add(60, Class60.smethod_0(-2050208807));
			dictionary.Add(61, Class60.smethod_0(-2050208849));
			dictionary.Add(66, Class60.smethod_0(-2050208844));
			dictionary.Add(111, Class60.smethod_0(-2050208870));
			dictionary.Add(112, Class60.smethod_0(-2050208928));
			dictionary.Add(113, Class60.smethod_0(-2050208952));
			dictionary.Add(114, Class60.smethod_0(-2050208933));
			dictionary.Add(155, Class60.smethod_0(-2050208992));
			dictionary.Add(249, Class60.smethod_0(-2050208973));
			dictionary.Add(252, Class60.smethod_0(-2050209009));
			dictionary.Add(254, Class60.smethod_0(-2050209004));
			dictionary.Add(257, Class60.smethod_0(-2050209050));
			dictionary.Add(258, Class60.smethod_0(-2050209077));
			dictionary.Add(261, Class60.smethod_0(-2050209057));
			dictionary.Add(275, Class60.smethod_0(-2050209094));
			dictionary.Add(276, Class60.smethod_0(-2050209140));
			dictionary.Add(279, Class60.smethod_0(-2050209124));
			dictionary.Add(290, Class60.smethod_0(-2050209171));
			dictionary.Add(355, Class60.smethod_0(-2050209153));
			dictionary.Add(357, Class60.smethod_0(-2050209216));
			dictionary.Add(380, Class60.smethod_0(-2050209197));
			dictionary.Add(383, Class60.smethod_0(-2050209243));
			dictionary.Add(401, Class60.smethod_0(-2050209225));
			dictionary.Add(475, Class60.smethod_0(-2050209260));
			dictionary.Add(482, Class60.smethod_0(-2050209309));
			dictionary.Add(2001, Class60.smethod_0(-2050209292));
			dictionary.Add(2041, Class60.smethod_0(-2050209320));
			dictionary.Add(2042, Class60.smethod_0(-2050209368));
			dictionary.Add(2043, Class60.smethod_0(-2050209348));
			dictionary.Add(2045, Class60.smethod_0(-2050209393));
			dictionary.Add(2054, Class60.smethod_0(-2050209377));
			dictionary.Add(2234, Class60.smethod_0(-2050209439));
			dictionary.Add(2286, Class60.smethod_0(-2050209421));
			dictionary.Add(2338, Class60.smethod_0(-2050209466));
			dictionary_0 = dictionary;
		}
	}

	public struct Struct26
	{
		[Serializable]
		private sealed class Class58
		{
			public static readonly Class58 class58_0 = new Class58();

			public static Func<KeyValuePair<int, string>, string> func_0;

			public static Func<KeyValuePair<int, string>, int> func_1;

			public static Func<KeyValuePair<int, string>, string> func_2;

			internal string method_0(KeyValuePair<int, string> keyValuePair_0)
			{
				return keyValuePair_0.Value;
			}

			internal int method_1(KeyValuePair<int, string> keyValuePair_0)
			{
				return keyValuePair_0.Key;
			}

			internal string method_2(KeyValuePair<int, string> keyValuePair_0)
			{
				return keyValuePair_0.Value;
			}
		}

		private Dictionary<int, string> dictionary_0;

		public Dictionary<int, string> method_0()
		{
			return dictionary_0;
		}

		public void method_1(List<GClass3> list_0)
		{
			if (list_0 == null || list_0.Count() <= 0)
			{
				return;
			}
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			foreach (GClass3 item in list_0)
			{
				dictionary.Add(item.ID, item.NAME);
			}
			dictionary_0 = dictionary.OrderBy(Class58.class58_0.method_0).ToDictionary(Class58.class58_0.method_1, Class58.class58_0.method_2);
		}
	}

	public struct Struct27
	{
		private int int_0;

		private int int_1;

		private bool[,] bool_0;

		private GClass2 gclass2_0;

		private List<Point> list_0;

		private List<GClass7> list_1;

		private string string_0;

		public List<Point> method_0(string string_1)
		{
			if (list_0 != null)
			{
				list_0.Reverse();
			}
			return method_1(string_1);
		}

		public List<Point> method_1(string string_1)
		{
			if (list_0 == null || !string_0.Equals(string_1))
			{
				if (list_0 == null)
				{
					list_0 = new List<Point>();
				}
				else
				{
					list_0.Clear();
				}
				using (StreamReader streamReader = new StreamReader(string_1))
				{
					while (true)
					{
						string text = streamReader.ReadLine();
						if (text != null)
						{
							string[] array = text.Split(new char[1] { ',' });
							if (array != null)
							{
								list_0.Add(new Point(int.Parse(array[0]), int.Parse(array[1])));
							}
							continue;
						}
						break;
					}
				}
				string_0 = string_1;
			}
			return list_0;
		}

		public bool method_2(string string_1)
		{
			if (string.IsNullOrEmpty(string_1))
			{
				return false;
			}
			if (string_1.IndexOf('.') != -1)
			{
				string_1 = string_1.Substring(0, string_1.IndexOf('.'));
			}
			string text = AppDomain.CurrentDomain.BaseDirectory + Class60.smethod_0(-2050209494);
			string empty = string.Empty;
			int num = string_1.Length;
			int num2;
			int num3;
			while (true)
			{
				if (num > string_1.Length - 2)
				{
					empty = text + string_1.Substring(0, num) + Class60.smethod_0(-2050209480);
					if (File.Exists(empty))
					{
						byte[] array = File.ReadAllBytes(empty);
						num2 = BitConverter.ToInt16(array, 0);
						num3 = BitConverter.ToInt16(array, 2);
						if (num2 + 15 > 330)
						{
							int_0 = num2 + 15;
						}
						else
						{
							int_0 = 330;
						}
						if (num3 + 150 > 427)
						{
							int_1 = num3 + 150;
						}
						else
						{
							int_1 = 427;
						}
						if (bool_0 != null)
						{
							bool_0 = null;
						}
						if (bool_0 == null)
						{
							bool_0 = new bool[int_0, int_1];
						}
						if (list_1 == null)
						{
							list_1 = new List<GClass7>();
						}
						else
						{
							list_1.Clear();
						}
						for (int i = 0; i < num2; i++)
						{
							for (int j = 0; j < num3; j++)
							{
								if (array[j * num2 + i + 3] != 0)
								{
									bool_0[i, j] = false;
									continue;
								}
								bool_0[i, j] = true;
								list_1.Add(new GClass7(i, j));
							}
						}
						if (bool_0 != null)
						{
							break;
						}
					}
					num--;
					continue;
				}
				return false;
			}
			gclass2_0 = new GClass2(num2, num3, bool_0);
			return true;
		}

		public List<GClass7> method_3(int int_2, int int_3)
		{
			Random random = new Random();
			List<GClass7> list = null;
			GClass7 gclass7_ = new GClass7(int_2, int_3);
			GClass7 gclass7_2 = list_1[random.Next(list_1.Count)];
			list = GClass11.smethod_0(gclass2_0, gclass7_, gclass7_2);
			if (list != null && list.Count() > 0)
			{
				return list;
			}
			return null;
		}
	}

	public static string smethod_0()
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			text = NetworkInterface.GetAllNetworkInterfaces().Where(Class56.class56_0.method_0).Select(Class56.class56_0.method_1)
				.FirstOrDefault();
			if (string.IsNullOrEmpty(text))
			{
				text = NetworkInterface.GetAllNetworkInterfaces().Where(Class56.class56_0.method_2).Select(Class56.class56_0.method_3)
					.FirstOrDefault();
			}
			if (string.IsNullOrEmpty(text))
			{
				text = NetworkInterface.GetAllNetworkInterfaces().Where(Class56.class56_0.method_4).Select(Class56.class56_0.method_5)
					.FirstOrDefault();
			}
		}
		finally
		{
			ManagementObject val = new ManagementObject(Class60.smethod_0(-2050209485));
			val.Get();
			text += ((ManagementBaseObject)val).get_Item(Class60.smethod_0(-2050209559)).ToString();
			ManagementObjectSearcher val2 = new ManagementObjectSearcher(Class60.smethod_0(-2050209550));
			ManagementObjectEnumerator enumerator = val2.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					if (((ManagementBaseObject)val3).get_Properties().get_Item(Class60.smethod_0(-2050209578)).get_Value() != null)
					{
						text += string.Format(Class60.smethod_0(-2050209608), ((ManagementBaseObject)val3).get_Properties().get_Item(Class60.smethod_0(-2050209578)).get_Value());
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		return text;
	}

	public static string smethod_1(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(Class60.smethod_0(-2050209614)));
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = key;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			byte[] bytes = uTF8Encoding.GetBytes(smethod_5(smethod_3(string_0)));
			byte[] inArray;
			try
			{
				ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
				inArray = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
			}
			finally
			{
				tripleDESCryptoServiceProvider.Clear();
				mD5CryptoServiceProvider.Clear();
			}
			return Convert.ToBase64String(inArray);
		}
		return null;
	}

	public static string smethod_2(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(Class60.smethod_0(-2050209614)));
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = key;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			byte[] array = Convert.FromBase64String(string_0);
			byte[] bytes;
			try
			{
				ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
				bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
			}
			finally
			{
				tripleDESCryptoServiceProvider.Clear();
				mD5CryptoServiceProvider.Clear();
			}
			return smethod_4(smethod_6(uTF8Encoding.GetString(bytes)));
		}
		return null;
	}

	private static string smethod_3(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			MemoryStream memoryStream = null;
			byte[] array = new byte[0];
			byte[] rgbIV = new byte[8] { 12, 21, 43, 17, 57, 35, 67, 27 };
			string s = Class60.smethod_0(-2050209634);
			array = Encoding.UTF8.GetBytes(s);
			string_0 = string_0.Replace(' ', '+');
			string_0 = string_0.Replace('-', '+');
			string_0 = string_0.Replace('_', '/');
			int num = string_0.Length % 4;
			if (num > 0)
			{
				string_0 += new string('=', 4 - num);
			}
			byte[] bytes = Encoding.UTF8.GetBytes(string_0);
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			memoryStream = new MemoryStream();
			ICryptoTransform transform = dESCryptoServiceProvider.CreateEncryptor(array, rgbIV);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
		return null;
	}

	private static string smethod_4(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			MemoryStream memoryStream = null;
			byte[] array = new byte[0];
			byte[] rgbIV = new byte[8] { 12, 21, 43, 17, 57, 35, 67, 27 };
			string s = Class60.smethod_0(-2050209634);
			array = Encoding.UTF8.GetBytes(s);
			byte[] array2 = new byte[string_0.Length];
			array2 = Convert.FromBase64String(string_0);
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			memoryStream = new MemoryStream();
			ICryptoTransform transform = dESCryptoServiceProvider.CreateDecryptor(array, rgbIV);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array2, 0, array2.Length);
			cryptoStream.FlushFinalBlock();
			Encoding uTF = Encoding.UTF8;
			return uTF.GetString(memoryStream.ToArray());
		}
		return null;
	}

	private static string smethod_5(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(Class60.smethod_0(-2050209683)));
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = key;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			byte[] bytes = uTF8Encoding.GetBytes(string_0);
			byte[] inArray;
			try
			{
				ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
				inArray = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
			}
			finally
			{
				tripleDESCryptoServiceProvider.Clear();
				mD5CryptoServiceProvider.Clear();
			}
			return Convert.ToBase64String(inArray);
		}
		return null;
	}

	public static string smethod_6(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(Class60.smethod_0(-2050209683)));
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = key;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			byte[] array = Convert.FromBase64String(string_0);
			byte[] bytes;
			try
			{
				ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
				bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
			}
			finally
			{
				tripleDESCryptoServiceProvider.Clear();
				mD5CryptoServiceProvider.Clear();
			}
			return uTF8Encoding.GetString(bytes);
		}
		return null;
	}

	public static string smethod_7(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = mD5CryptoServiceProvider.ComputeHash(new UTF8Encoding().GetBytes(string_0));
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString(Class60.smethod_0(-2050209665)));
		}
		stringBuilder.ToString();
		return stringBuilder.ToString();
	}

	public static void smethod_8(string string_0, int int_0, string string_1, string string_2)
	{
		try
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				string text = Class60.smethod_0(-2050209720) + int_0 + Class60.smethod_0(-2050209697);
				text = text + Class60.smethod_0(-2050209752) + string_1 + Class60.smethod_0(-2050209733);
				text = text + Class60.smethod_0(-2050209741) + string_2;
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Class60.smethod_0(-2050209766));
				string s = string.Format(Class60.smethod_0(-2050207754), text);
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				httpWebRequest.Method = Class60.smethod_0(-2050207784);
				httpWebRequest.ContentType = Class60.smethod_0(-2050207789);
				httpWebRequest.ContentLength = bytes.Length;
				httpWebRequest.Headers.Add(Class60.smethod_0(-2050207861), Class60.smethod_0(-2050207841) + string_0);
				using (Stream stream = httpWebRequest.GetRequestStream())
				{
					stream.Write(bytes, 0, bytes.Length);
				}
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
			}
		}
		catch
		{
		}
	}
}
