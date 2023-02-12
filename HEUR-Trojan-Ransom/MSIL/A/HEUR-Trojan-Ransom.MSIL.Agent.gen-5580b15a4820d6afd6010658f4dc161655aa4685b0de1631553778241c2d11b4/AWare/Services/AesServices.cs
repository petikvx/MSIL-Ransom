using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AWare.Services
{
	// Token: 0x02000004 RID: 4
	public class AesServices
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002110 File Offset: 0x00000310
		public void DecryptFile(string sourceFilename, string destinationFilename, string password, int iterations)
		{
			AesManaged aesManaged = new AesManaged();
			aesManaged.BlockSize = aesManaged.LegalBlockSizes[0].MaxSize;
			aesManaged.KeySize = aesManaged.LegalKeySizes[0].MaxSize;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, this._salt, iterations);
			aesManaged.Key = rfc2898DeriveBytes.GetBytes(aesManaged.KeySize / 8);
			aesManaged.IV = rfc2898DeriveBytes.GetBytes(aesManaged.BlockSize / 8);
			aesManaged.Mode = CipherMode.CBC;
			ICryptoTransform cryptoTransform = aesManaged.CreateDecryptor(aesManaged.Key, aesManaged.IV);
			using (FileStream fileStream = new FileStream(destinationFilename, FileMode.CreateNew, FileAccess.Write, FileShare.None))
			{
				using (CryptoStream cryptoStream = new CryptoStream(fileStream, cryptoTransform, CryptoStreamMode.Write))
				{
					try
					{
						using (FileStream fileStream2 = new FileStream(sourceFilename, FileMode.Open, FileAccess.Read, FileShare.Read))
						{
							fileStream2.CopyTo(cryptoStream);
						}
					}
					catch (CryptographicException ex)
					{
						bool flag = ex.Message == "Padding is invalid and cannot be removed.";
						if (flag)
						{
							throw new ApplicationException("Universal Microsoft Cryptographic Exception (Not to be believed!)", ex);
						}
						throw;
					}
				}
			}
			File.Delete(sourceFilename);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002260 File Offset: 0x00000460
		public string EncryptFile(string sourceFilename, string destinationFilename, string password, int iterations)
		{
			AesManaged aesManaged = new AesManaged();
			aesManaged.BlockSize = aesManaged.LegalBlockSizes[0].MaxSize;
			aesManaged.KeySize = aesManaged.LegalKeySizes[0].MaxSize;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, this._salt, iterations);
			aesManaged.Key = rfc2898DeriveBytes.GetBytes(aesManaged.KeySize / 8);
			aesManaged.IV = rfc2898DeriveBytes.GetBytes(aesManaged.BlockSize / 8);
			aesManaged.Mode = CipherMode.CBC;
			ICryptoTransform cryptoTransform = aesManaged.CreateEncryptor(aesManaged.Key, aesManaged.IV);
			using (FileStream fileStream = new FileStream(destinationFilename, FileMode.CreateNew, FileAccess.Write, FileShare.None))
			{
				using (CryptoStream cryptoStream = new CryptoStream(fileStream, cryptoTransform, CryptoStreamMode.Write))
				{
					using (FileStream fileStream2 = new FileStream(sourceFilename, FileMode.Open, FileAccess.Read, FileShare.Read))
					{
						fileStream2.CopyTo(cryptoStream);
					}
				}
			}
			File.Delete(sourceFilename);
			return sourceFilename + ".AWare";
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002388 File Offset: 0x00000588
		public string DecryptString(string cipherText, string password)
		{
			SHA256 sha = SHA256.Create();
			byte[] array = sha.ComputeHash(Encoding.ASCII.GetBytes(password));
			byte[] array2 = new byte[16];
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			byte[] array3 = new byte[32];
			Array.Copy(array, 0, array3, 0, 32);
			aes.Key = array3;
			aes.IV = array2;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform cryptoTransform = aes.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
			string text = string.Empty;
			try
			{
				byte[] array4 = Convert.FromBase64String(cipherText);
				cryptoStream.Write(array4, 0, array4.Length);
				cryptoStream.FlushFinalBlock();
				byte[] array5 = memoryStream.ToArray();
				text = Encoding.ASCII.GetString(array5, 0, array5.Length);
			}
			finally
			{
				memoryStream.Close();
				cryptoStream.Close();
			}
			return text;
		}

		// Token: 0x04000007 RID: 7
		private readonly byte[] _salt = new byte[32];
	}
}
