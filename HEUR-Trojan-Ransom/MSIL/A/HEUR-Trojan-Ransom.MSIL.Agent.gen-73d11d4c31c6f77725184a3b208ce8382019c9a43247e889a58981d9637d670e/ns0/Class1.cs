using System;
using System.Windows.Forms;
using MIni_Ransomware;

namespace ns0;

internal static class Class1
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
