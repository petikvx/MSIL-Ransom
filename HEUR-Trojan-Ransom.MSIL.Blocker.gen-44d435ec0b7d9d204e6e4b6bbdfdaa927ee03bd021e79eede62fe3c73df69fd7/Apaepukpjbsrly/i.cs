using System;
using System.Threading;
using System.Windows.Forms;

namespace Apaepukpjbsrly;

public sealed class i
{
	public i()
	{
		_ = 7;
		if (6 == 0)
		{
		}
		base._002Ector();
	}

	[STAThread]
	private static void a()
	{
		if (uint.MaxValue != 0)
		{
			Application.EnableVisualStyles();
		}
		if (8u != 0)
		{
			Application.SetCompatibleTextRenderingDefault(false);
		}
		if (4u != 0)
		{
			Application.SetUnhandledExceptionMode((UnhandledExceptionMode)2);
		}
		AppDomain.CurrentDomain.UnhandledException += a;
		Application.add_ThreadException((ThreadExceptionEventHandler)a);
		Application.Run((Form)(object)new h());
	}

	private static void a(object a, ThreadExceptionEventArgs b)
	{
		if (0 == 0)
		{
			Environment.Exit(0);
		}
	}

	private static void a(object a, UnhandledExceptionEventArgs b)
	{
		if (uint.MaxValue != 0)
		{
			Environment.Exit(0);
		}
	}
}
