using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jtAYXTgtXeY;

public static class LaEpsyZsIhRz
{
	private static bool FgplFcpRDZRmRv;

	private static readonly string bgENoIdCObJJqen;

	[NonSerialized]
	internal static GetString getString_0;

	public static string FCwTjlNAKSS(string string_0)
	{
		int pAhgJGIdxRPi = 0;
		string SaDgyBUqlirqQ = getString_0(107388187);
		thbNoSvXoDJ(bgENoIdCObJJqen, out pAhgJGIdxRPi, out SaDgyBUqlirqQ);
		byte[] inArray = iTVSgLQUIJ(Encoding.UTF8.GetBytes(string_0), pAhgJGIdxRPi, SaDgyBUqlirqQ);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] iTVSgLQUIJ(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = qovaXXOtyjbVftWA(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107401723), num), getString_0(107401764));
			}
			if (!KZVOYKjpAYiPq(int_0))
			{
				throw new ArgumentException(getString_0(107401686), getString_0(107401145));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107401164), getString_0(107401103));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, FgplFcpRDZRmRv);
		}
		throw new ArgumentException(getString_0(107401753), getString_0(107401764));
	}

	private static int qovaXXOtyjbVftWA(int int_0)
	{
		if (FgplFcpRDZRmRv)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool KZVOYKjpAYiPq(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void thbNoSvXoDJ(string RktLzspXqYIm, out int pAhgJGIdxRPi, out string SaDgyBUqlirqQ)
	{
		pAhgJGIdxRPi = 0;
		SaDgyBUqlirqQ = getString_0(107388187);
		if (RktLzspXqYIm == null || RktLzspXqYIm.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(RktLzspXqYIm);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107401086)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				pAhgJGIdxRPi = int.Parse(array[0]);
				SaDgyBUqlirqQ = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static LaEpsyZsIhRz()
	{
		Strings.CreateGetStringDelegate(typeof(LaEpsyZsIhRz));
		FgplFcpRDZRmRv = false;
		bgENoIdCObJJqen = getString_0(107401081);
	}
}
