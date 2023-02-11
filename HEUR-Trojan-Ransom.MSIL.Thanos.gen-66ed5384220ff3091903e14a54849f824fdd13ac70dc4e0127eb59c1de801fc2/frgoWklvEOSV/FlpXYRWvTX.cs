using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public static class FlpXYRWvTX
{
	private static bool QHqhUxmYNLgFw;

	private static readonly string XLDTHwKdmajt;

	[NonSerialized]
	internal static GetString _008F;

	public static string ZTvekdOmyg(string P_0)
	{
		int OPfmSiyNGzFxTlOi = 0;
		string fPzbhtlmbDZXN = _008F(107388735);
		MkdigCRsEEMOX(XLDTHwKdmajt, out OPfmSiyNGzFxTlOi, out fPzbhtlmbDZXN);
		byte[] inArray = YEURKxvgnTup(Encoding.UTF8.GetBytes(P_0), OPfmSiyNGzFxTlOi, fPzbhtlmbDZXN);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] YEURKxvgnTup(byte[] P_0, int P_1, string P_2)
	{
		if (P_0 == null || P_0.Length == 0)
		{
			throw new ArgumentException(_008F(107402583), _008F(107402562));
		}
		int num = NmEJfVQfRMcT(P_1);
		if (P_0.Length > num)
		{
			throw new ArgumentException(string.Format(_008F(107402553), num), _008F(107402562));
		}
		if (!KNJuZPxStl(P_1))
		{
			throw new ArgumentException(_008F(107402548), _008F(107402487));
		}
		if (string.IsNullOrEmpty(P_2))
		{
			throw new ArgumentException(_008F(107402506), _008F(107402477));
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(P_1);
		rSACryptoServiceProvider.FromXmlString(P_2);
		return rSACryptoServiceProvider.Encrypt(P_0, QHqhUxmYNLgFw);
	}

	private static int NmEJfVQfRMcT(int P_0)
	{
		if (QHqhUxmYNLgFw)
		{
			return (P_0 - 384) / 8 + 7;
		}
		return (P_0 - 384) / 8 + 37;
	}

	private static bool KNJuZPxStl(int P_0)
	{
		if (P_0 >= 384 && P_0 <= 16384)
		{
			return P_0 % 8 == 0;
		}
		return false;
	}

	private static void MkdigCRsEEMOX(string IZpTbvGgqiuQ, out int OPfmSiyNGzFxTlOi, out string fPzbhtlmbDZXN)
	{
		OPfmSiyNGzFxTlOi = 0;
		fPzbhtlmbDZXN = _008F(107388735);
		if (IZpTbvGgqiuQ == null || IZpTbvGgqiuQ.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(IZpTbvGgqiuQ);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(_008F(107402428)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				OPfmSiyNGzFxTlOi = int.Parse(array[0]);
				fPzbhtlmbDZXN = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static FlpXYRWvTX()
	{
		Strings.CreateGetStringDelegate(typeof(FlpXYRWvTX));
		QHqhUxmYNLgFw = false;
		XLDTHwKdmajt = _008F(107402423);
	}
}
