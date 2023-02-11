using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Af7;
using Hm3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qt1;
using Rm67;
using a4M;
using k7R;
using o8B;

namespace Zo6w;

[DesignerGenerated]
public class Nq60 : Form
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
			EventHandler eventHandler = o9AT;
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
			EventHandler eventHandler = Pd2o;
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
			EventHandler eventHandler = Bw14;
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
			EventHandler eventHandler = s4T8;
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
			EventHandler eventHandler = k3J6;
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

	public Nq60()
	{
		((Form)this).add_Load((EventHandler)e7MH);
		p6Y0();
	}

	private void o9AT(object f8DA, EventArgs Yd8t)
	{
		Fp9 fp = new Fp9();
		Zo4 zo = new Zo4();
		zo.id = checked(((IQueryable<Zo4>)fp.bridge).Select((Zo4 br) => br.id).Max() + 1);
		zo.recorddate = DateAndTime.get_Now();
		zo.recordprogram = ((Control)this).get_Name();
		zo.recorduserid = "yosh";
		zo.recordvalid = true;
		zo.bridgename = "相川";
		fp.bridge.Add(zo);
		((DbContext)fp).SaveChanges();
		TextBox1.set_Text(Conversions.ToString(zo.id));
	}

	private void e7MH(object e5T1, EventArgs p6BY)
	{
		TextBox1.set_Text(Environment.UserName);
	}

	private void Pd2o(object Md1w, EventArgs e5E6)
	{
	}

	private void Bw14(object Gf6p, EventArgs s8W4)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Mk49 mk = new Mk49();
		((Form)mk).ShowDialog((IWin32Window)(object)this);
		((Component)(object)mk).Dispose();
	}

	private void s4T8(object Ab9o, EventArgs n5ZX)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		g4N g4N = new g4N();
		((Form)g4N).ShowDialog((IWin32Window)(object)this);
		((Component)(object)g4N).Dispose();
	}

	[STAThread]
	public static void x4J3()
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
				int z4M;
				do
				{
					z4M = 2;
				}
				while (!p9F.Xk2(z4M) || !Nn5.Jj9());
				int f0D = 1;
				d5Q.c9W(f0D);
				break;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				try0001_dispatch = 2;
			}
		}
	}

	private void k3J6(object s6N9, EventArgs Co63)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		p9F p9F = new p9F();
		((Form)p9F).ShowDialog((IWin32Window)(object)this);
		((Component)(object)p9F).Dispose();
	}

	[DebuggerNonUserCode]
	protected override void Fa14(bool w0JK)
	{
		try
		{
			if (w0JK && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(w0JK);
		}
	}

	[DebuggerStepThrough]
	private void p6Y0()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
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
