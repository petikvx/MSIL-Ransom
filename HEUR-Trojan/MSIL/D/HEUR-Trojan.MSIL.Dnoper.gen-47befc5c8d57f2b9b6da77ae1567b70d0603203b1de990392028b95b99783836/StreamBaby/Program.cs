using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Windows.Forms;

namespace StreamBaby;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		string str = "WuRHkVbPCo7KBiXblEwx5A%3d%3d";
		string key = HttpUtility.UrlDecode(str);
		SymmetricMethod.Decrypt(key);
		bool createdNew = false;
		try
		{
			using (new Mutex(initiallyOwned: true, "StreamBaby_NewForm", out createdNew))
			{
				if (!createdNew)
				{
					MessageBox.Show("类似程序已经在运行中...");
					Thread.Sleep(1000);
					Environment.Exit(1);
					return;
				}
				string lastSoftVersion = HttpHelper.GetLastSoftVersion();
				string version = GetVersion();
				if (lastSoftVersion == version)
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new NewForm());
					return;
				}
				string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Update.exe");
				if (!File.Exists(text))
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new NewForm());
					return;
				}
				string arg = HttpHelper.DownLoadFileUrl();
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = text;
				processStartInfo.Arguments = string.Format("{0} " + AppDomain.CurrentDomain.FriendlyName, arg);
				Process.Start(processStartInfo);
				Application.ExitThread();
				Application.Exit();
			}
		}
		catch
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new NewForm());
		}
	}

	private static string GetVersion()
	{
		string result = string.Empty;
		object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyFileVersionAttribute), inherit: false);
		if (customAttributes.Length != 0)
		{
			result = ((AssemblyFileVersionAttribute)customAttributes[0]).Version;
		}
		return result;
	}

	public static string GetMD5String(string key)
	{
		return FormsAuthentication.HashPasswordForStoringInConfigFile(key, "MD5");
	}
}
