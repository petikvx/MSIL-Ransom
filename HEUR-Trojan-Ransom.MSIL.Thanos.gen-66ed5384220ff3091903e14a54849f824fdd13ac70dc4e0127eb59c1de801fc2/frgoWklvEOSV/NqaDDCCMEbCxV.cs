using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

internal sealed class NqaDDCCMEbCxV
{
	private sealed class mmvNUPMEkYcFz
	{
		public string fmfdAkvSVbMP;

		public bool _003CKillproc_003Eb__4(string P_0)
		{
			return P_0.Contains(fmfdAkvSVbMP);
		}
	}

	public static readonly List<string> XjjKqGKaaiFFD;

	public static readonly List<string> VJCdOgLUhSBh;

	private static Func<string, string[]> CS_0024_003C_003E9__CachedAnonymousMethodDelegate8;

	private static Func<string[], string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate9;

	[NonSerialized]
	internal static GetString _008C;

	public static bool SmlSZjnRIeVP(string P_0)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(P_0, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(P_0, FileMode.Open, FileAccess.Read, FileShare.None);
			}
			catch (Exception)
			{
				return true;
			}
		}
		catch (Exception)
		{
			return true;
		}
		finally
		{
			fileStream.Close();
		}
		return false;
	}

	public static void XkoarExxofRiBeK(string P_0)
	{
		mmvNUPMEkYcFz CS_0024_003C_003E8__locals0 = new mmvNUPMEkYcFz();
		CS_0024_003C_003E8__locals0.fmfdAkvSVbMP = P_0;
		try
		{
			string text = oLflouHqkSEuZ(PFruJiQrcriiZ.GwTsezEgVAuVAU(_008C(107403123)), PFruJiQrcriiZ.GwTsezEgVAuVAU(_008C(107403138)));
			string[] separator = new string[1] { _008C(107396319) };
			string[] source = text.Split(separator, StringSplitOptions.None);
			IEnumerable<string> source2 = source.Where((string P_0) => P_0.Contains(CS_0024_003C_003E8__locals0.fmfdAkvSVbMP));
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate8 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate8 = (string P_0) => P_0.Split(new char[1] { ',' });
			}
			IEnumerable<string[]> source3 = source2.Select(CS_0024_003C_003E9__CachedAnonymousMethodDelegate8);
			if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate9 == null)
			{
				CS_0024_003C_003E9__CachedAnonymousMethodDelegate9 = (string[] P_0) => P_0[1].Replace(_008C(107387773), _008C(107388726));
			}
			List<string> list = source3.Select(CS_0024_003C_003E9__CachedAnonymousMethodDelegate9).ToList();
			foreach (string item in list)
			{
				oLflouHqkSEuZ(PFruJiQrcriiZ.GwTsezEgVAuVAU(_008C(107387813)), PFruJiQrcriiZ.GwTsezEgVAuVAU(_008C(107403113)) + item);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string oLflouHqkSEuZ(string P_0, string P_1)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(P_0, P_1);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.StandardOutputEncoding = Encoding.GetEncoding(_008C(107403064));
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			Process process = Process.Start(processStartInfo);
			string text;
			using (StreamReader streamReader = process.StandardOutput)
			{
				text = streamReader.ReadToEnd();
			}
			string text2;
			using (StreamReader streamReader2 = process.StandardError)
			{
				text2 = streamReader2.ReadToEnd();
			}
			process.WaitForExit();
			return text2 + text;
		}
		catch (Exception ex)
		{
			return ex.Message + _008C(107403055) + ex.StackTrace;
		}
	}

	private static string[] _003CKillproc_003Eb__5(string P_0)
	{
		return P_0.Split(new char[1] { ',' });
	}

	private static string _003CKillproc_003Eb__6(string[] P_0)
	{
		return P_0[1].Replace(_008C(107387773), _008C(107388726));
	}

	static NqaDDCCMEbCxV()
	{
		Strings.CreateGetStringDelegate(typeof(NqaDDCCMEbCxV));
		XjjKqGKaaiFFD = new List<string>();
		VJCdOgLUhSBh = new List<string>();
	}
}
