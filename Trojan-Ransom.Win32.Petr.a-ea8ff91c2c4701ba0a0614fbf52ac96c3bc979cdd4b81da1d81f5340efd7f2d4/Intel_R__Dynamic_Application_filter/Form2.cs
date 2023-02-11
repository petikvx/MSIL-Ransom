using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;
using Intel_R__Dynamic_Application_filter.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Intel_R__Dynamic_Application_filter;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Guna2AnimateWindow1")]
	internal virtual Guna2AnimateWindow Guna2AnimateWindow1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2Elipse1")]
	internal virtual Guna2Elipse Guna2Elipse1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2PictureBox1")]
	internal virtual Guna2PictureBox Guna2PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Guna2GradientButton OK
	{
		[CompilerGenerated]
		get
		{
			return _OK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = OK_Click;
			Guna2GradientButton oK = _OK;
			if (oK != null)
			{
				((Control)oK).remove_Click(eventHandler);
			}
			_OK = value;
			oK = _OK;
			if (oK != null)
			{
				((Control)oK).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Guna2PictureBox2")]
	internal virtual Guna2PictureBox Guna2PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form2()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		Guna2AnimateWindow1 = new Guna2AnimateWindow(components);
		Guna2Elipse1 = new Guna2Elipse(components);
		OK = new Guna2GradientButton();
		Label1 = new Label();
		Guna2PictureBox2 = new Guna2PictureBox();
		Guna2PictureBox1 = new Guna2PictureBox();
		Label2 = new Label();
		((ISupportInitialize)Guna2PictureBox2).BeginInit();
		((ISupportInitialize)Guna2PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Guna2AnimateWindow1.set_TargetForm((Form)(object)this);
		Guna2Elipse1.set_BorderRadius(33);
		Guna2Elipse1.set_TargetControl((Control)(object)this);
		OK.set_Animated(true);
		OK.set_AutoRoundedCorners(true);
		OK.set_BorderRadius(22);
		OK.set_BorderStyle((DashStyle)4);
		OK.set_ButtonMode((ButtonMode)1);
		((ButtonState)OK.get_CheckedState()).set_Parent((CustomButtonBase)(object)OK);
		OK.get_CustomImages().set_Parent((CustomButtonBase)(object)OK);
		OK.set_FillColor(Color.Maroon);
		OK.set_FillColor2(Color.FromArgb(192, 0, 0));
		((Control)OK).set_Font(new Font("Yu Gothic UI", 11f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)OK).set_ForeColor(Color.White);
		((ButtonState)OK.get_HoverState()).set_Parent((CustomButtonBase)(object)OK);
		((Control)OK).set_Location(new Point(1117, 792));
		((Control)OK).set_Name("OK");
		OK.get_ShadowDecoration().set_Parent((Control)(object)OK);
		((Control)OK).set_Size(new Size(125, 46));
		((Control)OK).set_TabIndex(0);
		((CustomButtonBase)OK).set_Text("OK");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft YaHei UI", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)Label1).set_Location(new Point(328, 756));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(534, 64));
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("P1N3AL PROTECTOR");
		((Control)Guna2PictureBox2).set_BackColor(Color.Transparent);
		((PictureBox)Guna2PictureBox2).set_Image((Image)(object)Resources.Faiscas);
		((Control)Guna2PictureBox2).set_Location(new Point(-88, 742));
		((Control)Guna2PictureBox2).set_Name("Guna2PictureBox2");
		Guna2PictureBox2.get_ShadowDecoration().set_Parent((Control)(object)Guna2PictureBox2);
		((Control)Guna2PictureBox2).set_Size(new Size(211, 319));
		((PictureBox)Guna2PictureBox2).set_TabIndex(3);
		((PictureBox)Guna2PictureBox2).set_TabStop(false);
		Guna2PictureBox2.set_UseTransparentBackground(true);
		((PictureBox)Guna2PictureBox1).set_Image((Image)(object)Resources.SkullMeditation);
		((Control)Guna2PictureBox1).set_Location(new Point(165, -201));
		((Control)Guna2PictureBox1).set_Name("Guna2PictureBox1");
		Guna2PictureBox1.get_ShadowDecoration().set_Parent((Control)(object)Guna2PictureBox1);
		((Control)Guna2PictureBox1).set_Size(new Size(905, 929));
		((PictureBox)Guna2PictureBox1).set_TabIndex(1);
		((PictureBox)Guna2PictureBox1).set_TabStop(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)Label2).set_Location(new Point(1, 825));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(172, 15));
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("DISCORD:  P1N3AL#1172");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Form)this).set_ClientSize(new Size(1241, 850));
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Guna2PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Guna2PictureBox2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)OK);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Form2");
		((Form)this).set_TopMost(true);
		((ISupportInitialize)Guna2PictureBox2).EndInit();
		((ISupportInitialize)Guna2PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void OK_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
