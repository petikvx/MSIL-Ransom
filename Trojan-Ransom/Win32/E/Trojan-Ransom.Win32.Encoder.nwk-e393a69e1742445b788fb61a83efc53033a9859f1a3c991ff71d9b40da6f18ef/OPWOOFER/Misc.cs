using System;

namespace OPWOOFER
{
	// Token: 0x02000002 RID: 2
	internal class Misc
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void DrawASCII()
		{
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine(" ▒█████   ██▓███      █     █░ ▒█████   ▒█████    █████▒▓█████  ██▀███  ");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("▒██▒  ██▒▓██░  ██▒   ▓█░ █ ░█░▒██▒  ██▒▒██▒  ██▒▓██   ▒ ▓█   ▀ ▓██ ▒ ██▒");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("▒██░  ██▒▓██░ ██▓▒   ▒█░ █ ░█ ▒██░  ██▒▒██░  ██▒▒████ ░ ▒███   ▓██ ░▄█ ▒");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("▒██   ██░▒██▄█▓▒ ▒   ░█░ █ ░█ ▒██   ██░▒██   ██░░▓█▒  ░ ▒▓█  ▄ ▒██▀▀█▄  ");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("░ ████▓▒░▒██▒ ░  ░   ░░██▒██▓ ░ ████▓▒░░ ████▓▒░░▒█░    ░▒████▒░██▓ ▒██▒");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("░ ▒░▒░▒░ ▒▓▒░ ░  ░   ░ ▓░▒ ▒  ░ ▒░▒░▒░ ░ ▒░▒░▒░  ▒ ░    ░░ ▒░ ░░ ▒▓ ░▒▓░");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("  ░ ▒ ▒░ ░▒ ░          ▒ ░ ░    ░ ▒ ▒░   ░ ▒ ▒░  ░       ░ ░  ░  ░▒ ░ ▒░");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("░ ░ ░ ▒  ░░            ░   ░  ░ ░ ░ ▒  ░ ░ ░ ▒   ░ ░       ░     ░░   ░ ");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("    ░ ░                  ░        ░ ░      ░ ░             ░  ░   ░     ");
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("VERSION 1.8(PUBLIC TUTORIAL) Done By Head#2900");
			Console.WriteLine("8.3.2021");
			Console.WriteLine("https://discord.gg/s77bJcSGRN");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002134 File Offset: 0x00000334
		public static void HashText(string text)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n(");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("X");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write(") ");
			Console.Write(text);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002184 File Offset: 0x00000384
		public static void OptionText(string text)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n(");
			Console.ForegroundColor = ConsoleColor.Magenta;
			Misc.number++;
			Console.Write(Misc.number);
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(") ");
			Console.Write(text);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021DE File Offset: 0x000003DE
		private static void ResetOption()
		{
			Misc.number = 0;
		}

		// Token: 0x04000001 RID: 1
		private static int number;
	}
}
