using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Kn0;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Rm1;
using Xm80;
using b4C;
using o4X;
using r7T8;
using t6G;

namespace Sp0;

[DesignerGenerated]
public class b0K : Form
{
	private IContainer components;

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = p7T;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Zc4;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button inspectionDataImportButtom
	{
		[CompilerGenerated]
		get
		{
			return _inspectionDataImportButtom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = n5S;
			Button val = _inspectionDataImportButtom;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_inspectionDataImportButtom = value;
			val = _inspectionDataImportButtom;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button bridgeManagementButton
	{
		[CompilerGenerated]
		get
		{
			return _bridgeManagementButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = f3P;
			Button val = _bridgeManagementButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_bridgeManagementButton = value;
			val = _bridgeManagementButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button bridgeAddButton
	{
		[CompilerGenerated]
		get
		{
			return _bridgeAddButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Le1;
			Button val = _bridgeAddButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_bridgeAddButton = value;
			val = _bridgeAddButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public b0K()
	{
		((Form)this).add_Load((EventHandler)s5K);
		Rw8();
	}

	private void p7T(object sender, EventArgs e)
	{
		r3E r3E = new r3E();
		p1W4 p1W = new p1W4();
		p1W.id = checked(((IQueryable<p1W4>)r3E.bridge).Select((p1W4 br) => br.id).Max() + 1);
		p1W.recorddate = DateAndTime.get_Now();
		p1W.recordprogram = ((Control)this).get_Name();
		p1W.recorduserid = "yosh";
		p1W.recordvalid = true;
		p1W.bridgename = "相川";
		r3E.bridge.Add(p1W);
		((DbContext)r3E).SaveChanges();
		TextBox1.set_Text(Conversions.ToString(p1W.id));
	}

	private void s5K(object sender, EventArgs e)
	{
		TextBox1.set_Text(Environment.UserName);
	}

	private void Zc4(object sender, EventArgs e)
	{
	}

	private void n5S(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Ns0 ns = new Ns0();
		((Form)ns).ShowDialog((IWin32Window)(object)this);
		((Component)(object)ns).Dispose();
	}

	private void f3P(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Xg5 xg = new Xg5();
		((Form)xg).ShowDialog((IWin32Window)(object)this);
		((Component)(object)xg).Dispose();
	}

	[STAThread]
	public static void Ed4()
	{
		int try0001_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				}
				while (!r1Z9.Kn9(2) || !s8H.Pn9())
				{
				}
				y6N.Ad4(1);
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				try0001_dispatch = 16;
			}
		}
	}

	private void Le1(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		r1Z9 r1Z = new r1Z9();
		((Form)r1Z).ShowDialog((IWin32Window)(object)this);
		((Component)(object)r1Z).Dispose();
	}

	[DebuggerNonUserCode]
	protected override void Jw3(bool z9Q)
	{
		try
		{
			if (z9Q && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(z9Q);
		}
	}

	[DebuggerStepThrough]
	private void Rw8()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		Button1 = new Button();
		Button2 = new Button();
		TextBox1 = new TextBox();
		inspectionDataImportButtom = new Button();
		bridgeManagementButton = new Button();
		bridgeAddButton = new Button();
		((Control)this).SuspendLayout();
		((Control)Button1).set_Location(new Point(657, 14));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(75, 23));
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Visible(false);
		((ButtonBase)Button2).set_AutoSize(true);
		((Control)Button2).set_Location(new Point(657, 70));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(55, 22));
		((Control)Button2).set_TabIndex(2);
		((ButtonBase)Button2).set_Text("Button2");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Visible(false);
		((Control)TextBox1).set_Location(new Point(657, 136));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(100, 19));
		((Control)TextBox1).set_TabIndex(3);
		((Control)TextBox1).set_Visible(false);
		((Control)inspectionDataImportButtom).set_Location(new Point(12, 28));
		((Control)inspectionDataImportButtom).set_Name("inspectionDataImportButtom");
		((Control)inspectionDataImportButtom).set_Size(new Size(234, 35));
		((Control)inspectionDataImportButtom).set_TabIndex(4);
		((ButtonBase)inspectionDataImportButtom).set_Text("点検データ取り込み");
		((ButtonBase)inspectionDataImportButtom).set_UseVisualStyleBackColor(true);
		((Control)bridgeManagementButton).set_Location(new Point(12, 85));
		((Control)bridgeManagementButton).set_Name("bridgeManagementButton");
		((Control)bridgeManagementButton).set_Size(new Size(234, 34));
		((Control)bridgeManagementButton).set_TabIndex(5);
		((ButtonBase)bridgeManagementButton).set_Text("橋梁管理台帳");
		((ButtonBase)bridgeManagementButton).set_UseVisualStyleBackColor(true);
		((Control)bridgeAddButton).set_Location(new Point(12, 178));
		((Control)bridgeAddButton).set_Name("bridgeAddButton");
		((Control)bridgeAddButton).set_Size(new Size(234, 35));
		((Control)bridgeAddButton).set_TabIndex(6);
		((ButtonBase)bridgeAddButton).set_Text("橋梁追加");
		((ButtonBase)bridgeAddButton).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(262, 242));
		((Control)this).get_Controls().Add((Control)(object)bridgeAddButton);
		((Control)this).get_Controls().Add((Control)(object)bridgeManagementButton);
		((Control)this).get_Controls().Add((Control)(object)inspectionDataImportButtom);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Name("MenuForm");
		((Form)this).set_Text("橋梁管理システム");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
