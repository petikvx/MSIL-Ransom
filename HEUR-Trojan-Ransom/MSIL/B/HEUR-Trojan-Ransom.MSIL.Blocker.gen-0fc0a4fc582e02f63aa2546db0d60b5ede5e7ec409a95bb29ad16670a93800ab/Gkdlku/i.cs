using System;
using System.Threading;
using System.Windows.Forms;

namespace Gkdlku;

public sealed class i
{
	public i()
	{
		_ = 8;
		if (false)
		{
		}
		base._002Ector();
	}

	[STAThread]
	private static void a()
	{
		if (6u != 0)
		{
			Application.EnableVisualStyles();
		}
		if (6u != 0)
		{
			Application.SetCompatibleTextRenderingDefault(false);
		}
		if (2u != 0)
		{
			Application.SetUnhandledExceptionMode((UnhandledExceptionMode)2);
		}
		AppDomain.CurrentDomain.UnhandledException += a;
		Application.add_ThreadException((ThreadExceptionEventHandler)a);
		Application.Run((Form)(object)new h());
	}

	private static void a(object a, ThreadExceptionEventArgs b)
	{
		if (uint.MaxValue != 0)
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
