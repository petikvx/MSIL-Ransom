using System;
using System.Windows.Forms;

namespace Program;

public class Program
{
	public Program()
	{
		Main();
	}

	[STAThread]
	public static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
