using System;
using System.Windows.Forms;

namespace AdrianPiecyk_Lab2;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new FormWindow());
	}
}
