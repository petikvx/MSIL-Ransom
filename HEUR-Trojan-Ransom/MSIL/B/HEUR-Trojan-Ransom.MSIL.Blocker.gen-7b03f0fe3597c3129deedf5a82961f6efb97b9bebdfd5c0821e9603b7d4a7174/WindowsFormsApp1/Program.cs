using System;

namespace WindowsFormsApp1;

public static class Program
{
	[STAThread]
	public static void Main()
	{
		new Json().FromText();
	}
}
