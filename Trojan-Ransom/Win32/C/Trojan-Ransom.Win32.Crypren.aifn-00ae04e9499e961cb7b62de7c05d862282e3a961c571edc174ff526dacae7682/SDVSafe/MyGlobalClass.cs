using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x02000013 RID: 19
	public class MyGlobalClass
	{
		// Token: 0x0600011C RID: 284 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		public static string GetRpiSerial()
		{
			bool flag = Application.StartupPath.Contains("home/pi");
			if (flag)
			{
				MyGlobalClass.CommandSync("cat /proc/cpuinfo | grep Serial | cut -d ':' -f 2 > /home/pi/serial.txt", "");
				using (StreamReader streamReader = new StreamReader("/home/pi/serial.txt"))
				{
					return streamReader.ReadLine().Trim();
				}
			}
			return "0000088800000001";
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000F870 File Offset: 0x0000DA70
		public static void CommandSync(string cmd, string args)
		{
			Process process = Process.Start(new ProcessStartInfo
			{
				FileName = "/bin/bash",
				Arguments = string.Format("-c \"sudo {0} {1}\"", cmd, args),
				UseShellExecute = false,
				RedirectStandardOutput = true
			});
			process.WaitForExit();
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000F8C4 File Offset: 0x0000DAC4
		public static bool AcknowledgementToFernwareEncrypt()
		{
			int num = 0;
			string rpiSerial = MyGlobalClass.GetRpiSerial();
			string text = rpiSerial + "@Q@" + DateTime.Now.ToString("yyyyMMddHHmmss");
			string text2 = clsEncryptDecrypt.StringEncrypt(text, MyGlobalClass.StringEncryptDecryptKey, MyGlobalClass.StringEncryptDecryptIV);
			string text3 = MyGlobalClass.WebServerHostName + "/rp1/queries/getAcknowledgementEncrypt.php";
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection { 
				{
					"data",
					text2.ToString()
				} };
				try
				{
					num = int.Parse(Encoding.UTF8.GetString(webClient.UploadValues(text3, nameValueCollection)));
				}
				catch
				{
				}
			}
			return num != 0;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		public static bool AcknowledgementToFernware()
		{
			int num = 0;
			string rpiSerial = MyGlobalClass.GetRpiSerial();
			string text = MyGlobalClass.WebServerHostName + "/rp1/queries/getAcknowledgement.php";
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection { 
				{
					"serial",
					rpiSerial.ToString()
				} };
				try
				{
					num = int.Parse(Encoding.UTF8.GetString(webClient.UploadValues(text, nameValueCollection)));
				}
				catch
				{
				}
			}
			return num != 0;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000FA4C File Offset: 0x0000DC4C
		public static void CheckDevelopPC()
		{
			string text = "";
			string hostName = Dns.GetHostName();
			IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
			IPAddress[] addressList = hostEntry.AddressList;
			foreach (IPAddress ipaddress in addressList)
			{
				bool flag = ipaddress.AddressFamily == AddressFamily.InterNetwork;
				if (flag)
				{
					text = ipaddress.ToString();
				}
			}
			bool flag2 = hostName.ToUpper().Contains("FERNWARE") && text.StartsWith("172.16.20.");
			if (flag2)
			{
				MyGlobalClass.isDevelop = true;
			}
			else
			{
				MyGlobalClass.isDevelop = false;
			}
		}

		// Token: 0x040000F2 RID: 242
		public static List<clsUsers> ListOfUsers;

		// Token: 0x040000F3 RID: 243
		public static List<clsUsers> ListOfUsersTemp;

		// Token: 0x040000F4 RID: 244
		public static List<clsServiceProviders> ListOfServiceProviders;

		// Token: 0x040000F5 RID: 245
		public static clsUsers TempLoginUser;

		// Token: 0x040000F6 RID: 246
		public static int StoreID;

		// Token: 0x040000F7 RID: 247
		public static string StoreName;

		// Token: 0x040000F8 RID: 248
		public static int tmpStoreID;

		// Token: 0x040000F9 RID: 249
		public static string tmpKeyValue;

		// Token: 0x040000FA RID: 250
		public static bool isDevelop = false;

		// Token: 0x040000FB RID: 251
		public static bool isPi = true;

		// Token: 0x040000FC RID: 252
		public static string initialDirectory;

		// Token: 0x040000FD RID: 253
		public static string dfgDirectory;

		// Token: 0x040000FE RID: 254
		public static string dfgFileName;

		// Token: 0x040000FF RID: 255
		public static string dfgFullPath;

		// Token: 0x04000100 RID: 256
		public static string dfgKeyFileName;

		// Token: 0x04000101 RID: 257
		public static string dfgKeyFullPath;

		// Token: 0x04000102 RID: 258
		public static string batchDirectory;

		// Token: 0x04000103 RID: 259
		public static string batchUploadDirectory;

		// Token: 0x04000104 RID: 260
		public static string batchArchiveDirectory;

		// Token: 0x04000105 RID: 261
		public static string batchArchiveUploadDirectory;

		// Token: 0x04000106 RID: 262
		public static string batchErrorDirectory;

		// Token: 0x04000107 RID: 263
		public static string cashClsDirectory;

		// Token: 0x04000108 RID: 264
		public static string cashClsUploadDirectory;

		// Token: 0x04000109 RID: 265
		public static string cashClsErrorDirectory;

		// Token: 0x0400010A RID: 266
		public static string FileEncryptDecryptKey;

		// Token: 0x0400010B RID: 267
		public static string StringEncryptDecryptKey;

		// Token: 0x0400010C RID: 268
		public static string StringEncryptDecryptIV;

		// Token: 0x0400010D RID: 269
		public static string WebServerHostName;
	}
}
