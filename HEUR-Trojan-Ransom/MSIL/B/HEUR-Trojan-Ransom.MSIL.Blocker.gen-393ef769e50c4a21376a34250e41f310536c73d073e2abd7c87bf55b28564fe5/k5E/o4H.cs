using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz98;
using Jt82;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Mp73;
using Xb3;
using Zo4;
using Zx2m;
using t8E;

namespace k5E;

[DesignerGenerated]
public class o4H : Form
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
			EventHandler eventHandler = Xn3;
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
			EventHandler eventHandler = Kp5;
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
			EventHandler eventHandler = p7H;
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
			EventHandler eventHandler = s8G;
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
			EventHandler eventHandler = d1Z;
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

	public o4H()
	{
		((Form)this).add_Load((EventHandler)i1P);
		Np2();
	}

	private void Xn3(object sender, EventArgs e)
	{
		j8K j8K = new j8K();
		z1B6 z1B = new z1B6();
		z1B.id = checked(((IQueryable<z1B6>)j8K.bridge).Select((z1B6 br) => br.id).Max() + 1);
		z1B.recorddate = DateAndTime.get_Now();
		z1B.recordprogram = ((Control)this).get_Name();
		z1B.recorduserid = "yosh";
		z1B.recordvalid = true;
		z1B.bridgename = "相川";
		j8K.bridge.Add(z1B);
		((DbContext)j8K).SaveChanges();
		TextBox1.set_Text(Conversions.ToString(z1B.id));
	}

	private void i1P(object sender, EventArgs e)
	{
		TextBox1.set_Text(Environment.UserName);
	}

	private void Kp5(object sender, EventArgs e)
	{
	}

	private void p7H(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Hx1 hx = new Hx1();
		((Form)hx).ShowDialog((IWin32Window)(object)this);
		((Component)(object)hx).Dispose();
	}

	private void s8G(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Di7 di = new Di7();
		((Form)di).ShowDialog((IWin32Window)(object)this);
		((Component)(object)di).Dispose();
	}

	[STAThread]
	public static void d7K()
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
				while (!Hj32.j6BM(2) || !d1Y8.g1E4())
				{
				}
				Ds5j.s1P(1);
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

	private void d1Z(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Hj32 hj = new Hj32();
		((Form)hj).ShowDialog((IWin32Window)(object)this);
		((Component)(object)hj).Dispose();
	}

	[DebuggerNonUserCode]
	protected override void c3W(bool Pk8)
	{
		try
		{
			if (Pk8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Pk8);
		}
	}

	[DebuggerStepThrough]
	private void Np2()
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
