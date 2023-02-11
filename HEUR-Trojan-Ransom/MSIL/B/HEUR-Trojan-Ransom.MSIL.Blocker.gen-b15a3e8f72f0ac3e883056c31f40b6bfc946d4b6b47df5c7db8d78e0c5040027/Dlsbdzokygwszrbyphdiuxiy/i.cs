using System;
using System.Threading;
using System.Windows.Forms;

namespace Dlsbdzokygwszrbyphdiuxiy;

public sealed class i
{
	public i()
	{
		_ = -1;
		if (8 == 0)
		{
		}
		base._002Ector();
	}

	[STAThread]
	private static void a()
	{
		if (2u != 0)
		{
			Application.EnableVisualStyles();
		}
		if (7u != 0)
		{
			Application.SetCompatibleTextRenderingDefault(false);
		}
		if (5u != 0)
		{
			Application.SetUnhandledExceptionMode((UnhandledExceptionMode)2);
		}
		AppDomain.CurrentDomain.UnhandledException += a;
		Application.add_ThreadException((ThreadExceptionEventHandler)a);
		Application.Run((Form)(object)new h());
	}

	private static void a(object a, ThreadExceptionEventArgs b)
	{
		if (3u != 0)
		{
			Environment.Exit(0);
		}
	}

	private static void a(object a, UnhandledExceptionEventArgs b)
	{
		if (8u != 0)
		{
			Environment.Exit(0);
		}
	}
}
