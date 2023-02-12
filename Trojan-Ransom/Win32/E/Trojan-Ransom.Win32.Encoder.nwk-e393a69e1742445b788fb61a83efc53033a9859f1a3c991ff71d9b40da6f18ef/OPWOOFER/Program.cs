using System;
using System.Diagnostics;

namespace OPWOOFER
{
	// Token: 0x02000003 RID: 3
	internal class Program
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000021F0 File Offset: 0x000003F0
		private static void Main(string[] args)
		{
			Console.Title = "OP WOOFER";
			Misc.DrawASCII();
			Misc.HashText("Welcome to OP WOOFER");
			for (;;)
			{
				Console.Clear();
				Misc.DrawASCII();
				Misc.OptionText("Spoof Ur DiskDrive");
				Misc.OptionText("Discord");
				Misc.HashText("1,2:");
				string text = Console.ReadLine();
				bool flag = text == "1";
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				if (flag4)
				{
					Console.Clear();
					Misc.DrawASCII();
					Misc.HashText("spoofing");
					Spoof.SpoofHDD();
					Misc.HashText("spoofed");
					Console.ReadKey();
				}
				else
				{
					bool flag5 = text == "2";
					bool flag6 = flag5;
					bool flag7 = flag6;
					bool flag8 = flag7;
					if (flag8)
					{
						Process.Start("https://discord.gg/s77bJcSGRN");
					}
					else
					{
						Misc.HashText("Ok bud maybe type right next time");
					}
				}
			}
		}
	}
}
