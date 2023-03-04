using System;
using System.IO;

namespace SyhMhfzDosyaTasimaClass;

public class ebubekirbastama
{
	public static string klasor_tasi(string KaynakDosya, string HedefDosya)
	{
		try
		{
			Directory.Move(KaynakDosya, HedefDosya);
		}
		catch (IOException ex)
		{
			return ex.Message;
		}
		return "Taşıma İşlemi Tamamlandı.";
	}

	public static string Copy(string KaynakDosya, string HedefDosya)
	{
		DirectoryInfo kaynakDosya = new DirectoryInfo(KaynakDosya);
		DirectoryInfo hedefDosya = new DirectoryInfo(HedefDosya);
		return CopyAll(kaynakDosya, hedefDosya);
	}

	public static string CopyAll(DirectoryInfo KaynakDosya, DirectoryInfo HedefDosya)
	{
		try
		{
			Directory.CreateDirectory(HedefDosya.FullName);
			FileInfo[] files = KaynakDosya.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				fileInfo.CopyTo(Path.Combine(HedefDosya.FullName, fileInfo.Name), overwrite: true);
			}
			DirectoryInfo[] directories = KaynakDosya.GetDirectories();
			foreach (DirectoryInfo directoryInfo in directories)
			{
				DirectoryInfo hedefDosya = HedefDosya.CreateSubdirectory(directoryInfo.Name);
				CopyAll(directoryInfo, hedefDosya);
			}
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
		return "Kopyalama İşlemi Tamam";
	}
}
