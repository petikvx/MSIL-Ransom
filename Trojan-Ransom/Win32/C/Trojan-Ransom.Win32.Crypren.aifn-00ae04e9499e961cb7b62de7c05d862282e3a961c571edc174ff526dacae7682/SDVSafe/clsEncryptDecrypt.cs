using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x02000007 RID: 7
	internal class clsEncryptDecrypt
	{
		// Token: 0x06000043 RID: 67
		[DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
		public static extern bool ZeroMemory(IntPtr Destination, int Length);

		// Token: 0x06000044 RID: 68 RVA: 0x00005950 File Offset: 0x00003B50
		public static byte[] GenerateRandomSalt()
		{
			byte[] array = new byte[32];
			for (int i = 0; i < 10; i++)
			{
				clsEncryptDecrypt.rngCsp.GetBytes(array);
			}
			return array;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000598C File Offset: 0x00003B8C
		public void FileEncrypt(string inputFile, string password)
		{
			byte[] array = clsEncryptDecrypt.GenerateRandomSalt();
			FileStream fileStream = new FileStream(inputFile + ".aes", FileMode.Create);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CFB;
			fileStream.Write(array, 0, array.Length);
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
			byte[] array2 = new byte[1048576];
			try
			{
				int num;
				while ((num = fileStream2.Read(array2, 0, array2.Length)) > 0)
				{
					Application.DoEvents();
					cryptoStream.Write(array2, 0, num);
				}
				fileStream2.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				cryptoStream.Close();
				fileStream.Close();
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005AE0 File Offset: 0x00003CE0
		public void FileDecrypt(string inputFile, string outputFile, string password)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			byte[] array = new byte[32];
			FileStream fileStream = new FileStream(inputFile, FileMode.Open);
			fileStream.Read(array, 0, array.Length);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			Console.WriteLine(Encoding.Default.GetString(rijndaelManaged.Key));
			Console.WriteLine(Encoding.Default.GetString(rijndaelManaged.IV));
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CFB;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
			FileStream fileStream2 = new FileStream(outputFile, FileMode.Create);
			byte[] array2 = new byte[1048576];
			try
			{
				int num;
				while ((num = cryptoStream.Read(array2, 0, array2.Length)) > 0)
				{
					Application.DoEvents();
					fileStream2.Write(array2, 0, num);
				}
			}
			catch (CryptographicException ex)
			{
				Console.WriteLine("CryptographicException error: " + ex.Message);
			}
			catch (Exception ex2)
			{
				Console.WriteLine("Error: " + ex2.Message);
			}
			try
			{
				cryptoStream.Close();
			}
			catch (Exception ex3)
			{
				Console.WriteLine("Error by closing CryptoStream: " + ex3.Message);
			}
			finally
			{
				fileStream2.Close();
				fileStream.Close();
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005CB0 File Offset: 0x00003EB0
		public static void GenerateKeyIV(out string key, out string IV)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged
			{
				Padding = PaddingMode.PKCS7,
				Mode = CipherMode.CBC,
				KeySize = 256,
				BlockSize = 256
			};
			rijndaelManaged.GenerateKey();
			rijndaelManaged.GenerateIV();
			key = Convert.ToBase64String(rijndaelManaged.Key);
			IV = Convert.ToBase64String(rijndaelManaged.IV);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005D14 File Offset: 0x00003F14
		public static string StringEncrypt(string prm_text_to_encrypt, string prm_key, string prm_iv)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged
			{
				Padding = PaddingMode.PKCS7,
				Mode = CipherMode.CBC,
				KeySize = 256,
				BlockSize = 256
			};
			byte[] bytes = Encoding.ASCII.GetBytes(prm_key);
			byte[] bytes2 = Encoding.ASCII.GetBytes(prm_iv);
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(bytes, bytes2);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
			byte[] bytes3 = Encoding.ASCII.GetBytes(prm_text_to_encrypt);
			cryptoStream.Write(bytes3, 0, bytes3.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array = memoryStream.ToArray();
			return Convert.ToBase64String(array);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005DC4 File Offset: 0x00003FC4
		public static string StringDecrypt(string prm_text_to_decrypt, string prm_key, string prm_iv)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged
			{
				Padding = PaddingMode.PKCS7,
				Mode = CipherMode.CBC,
				KeySize = 256,
				BlockSize = 256
			};
			byte[] bytes = Encoding.ASCII.GetBytes(prm_key);
			byte[] bytes2 = Encoding.ASCII.GetBytes(prm_iv);
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(bytes, bytes2);
			byte[] array = Convert.FromBase64String(prm_text_to_decrypt);
			byte[] array2 = new byte[array.Length];
			MemoryStream memoryStream = new MemoryStream(array);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read);
			cryptoStream.Read(array2, 0, array2.Length);
			return Encoding.ASCII.GetString(array2);
		}

		// Token: 0x04000046 RID: 70
		private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
	}
}
