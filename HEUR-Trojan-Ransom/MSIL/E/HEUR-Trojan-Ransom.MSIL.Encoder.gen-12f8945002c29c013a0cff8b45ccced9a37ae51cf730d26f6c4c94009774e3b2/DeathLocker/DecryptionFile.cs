using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DeathLocker;

public class DecryptionFile
{
	public void DecryptFile(string fileEncrypted, string password)
	{
		try
		{
			byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = CoreDecryption.AES_Decrypt(bytesToBeDecrypted, bytes);
			File.WriteAllBytes(fileEncrypted, bytes2);
		}
		catch
		{
		}
	}
}
