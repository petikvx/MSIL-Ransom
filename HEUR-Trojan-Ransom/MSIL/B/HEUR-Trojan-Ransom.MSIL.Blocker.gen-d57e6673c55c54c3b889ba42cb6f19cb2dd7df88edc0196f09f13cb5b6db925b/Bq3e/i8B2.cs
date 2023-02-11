using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cd6;
using Microsoft.VisualBasic.CompilerServices;

namespace Bq3e;

[DesignerGenerated]
public class i8B2 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button med
	{
		[CompilerGenerated]
		get
		{
			return _med;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = f1R0;
			Button val = _med;
			if (val != null)
			{
				((Control)val).remove_MouseHover(eventHandler);
			}
			_med = value;
			val = _med;
			if (val != null)
			{
				((Control)val).add_MouseHover(eventHandler);
			}
		}
	}

	internal virtual Button Bill
	{
		[CompilerGenerated]
		get
		{
			return _Bill;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Sq82;
			Button bill = _Bill;
			if (bill != null)
			{
				((Control)bill).remove_Click(eventHandler);
			}
			_Bill = value;
			bill = _Bill;
			if (bill != null)
			{
				((Control)bill).add_Click(eventHandler);
			}
		}
	}

	internal virtual ContextMenuStrip strip
	{
		[CompilerGenerated]
		get
		{
			return _strip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			CancelEventHandler cancelEventHandler = Ez8r;
			ContextMenuStrip val = _strip;
			if (val != null)
			{
				((ToolStripDropDown)val).remove_Opening(cancelEventHandler);
			}
			_strip = value;
			val = _strip;
			if (val != null)
			{
				((ToolStripDropDown)val).add_Opening(cancelEventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem AddElementToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AddElementToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = b9ZF;
			ToolStripMenuItem addElementToolStripMenuItem = _AddElementToolStripMenuItem;
			if (addElementToolStripMenuItem != null)
			{
				((ToolStripItem)addElementToolStripMenuItem).remove_Click(eventHandler);
			}
			_AddElementToolStripMenuItem = value;
			addElementToolStripMenuItem = _AddElementToolStripMenuItem;
			if (addElementToolStripMenuItem != null)
			{
				((ToolStripItem)addElementToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem CheckAvailabilityToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _CheckAvailabilityToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Mo6w;
			ToolStripMenuItem checkAvailabilityToolStripMenuItem = _CheckAvailabilityToolStripMenuItem;
			if (checkAvailabilityToolStripMenuItem != null)
			{
				((ToolStripItem)checkAvailabilityToolStripMenuItem).remove_Click(eventHandler);
			}
			_CheckAvailabilityToolStripMenuItem = value;
			checkAvailabilityToolStripMenuItem = _CheckAvailabilityToolStripMenuItem;
			if (checkAvailabilityToolStripMenuItem != null)
			{
				((ToolStripItem)checkAvailabilityToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem updateToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _updateToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Bn4x;
			ToolStripMenuItem val = _updateToolStripMenuItem;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			_updateToolStripMenuItem = value;
			val = _updateToolStripMenuItem;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	public i8B2()
	{
		((Form)this).add_Load((EventHandler)Jn07);
		Hx4r();
	}

	[DebuggerNonUserCode]
	protected override void Po52(bool p4BX)
	{
		try
		{
			if (p4BX && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(p4BX);
		}
	}

	[DebuggerStepThrough]
	private void Hx4r()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(i8B2));
		Label1 = new Label();
		med = new Button();
		strip = new ContextMenuStrip(components);
		AddElementToolStripMenuItem = new ToolStripMenuItem();
		CheckAvailabilityToolStripMenuItem = new ToolStripMenuItem();
		updateToolStripMenuItem = new ToolStripMenuItem();
		Bill = new Button();
		((Control)strip).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Label1).set_Anchor((AnchorStyles)13);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Modern No. 20", 48f));
		((Control)Label1).set_ForeColor(SystemColors.HotTrack);
		Label1.set_ImeMode((ImeMode)0);
		((Control)Label1).set_Location(new Point(617, 65));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(588, 83));
		((Control)Label1).set_TabIndex(9);
		Label1.set_Text("I-Care Pharmacy");
		((Control)med).set_AllowDrop(true);
		((ButtonBase)med).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)med).set_ContextMenuStrip(strip);
		((Control)med).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)med).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)med).set_ImeMode((ImeMode)0);
		((Control)med).set_Location(new Point(631, 212));
		((Control)med).set_Name("med");
		((Control)med).set_Size(new Size(206, 44));
		((Control)med).set_TabIndex(7);
		((ButtonBase)med).set_Text("Medicines");
		((ButtonBase)med).set_UseVisualStyleBackColor(false);
		((ToolStrip)strip).set_AllowDrop(true);
		((ToolStrip)strip).set_BackColor(SystemColors.ActiveCaption);
		((ToolStripDropDown)strip).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ToolStrip)strip).set_ImageScalingSize(new Size(20, 20));
		((ToolStrip)strip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)AddElementToolStripMenuItem,
			(ToolStripItem)CheckAvailabilityToolStripMenuItem,
			(ToolStripItem)updateToolStripMenuItem
		});
		((Control)strip).set_Name("strip");
		((ToolStrip)strip).set_RenderMode((ToolStripRenderMode)2);
		((Control)strip).set_Size(new Size(254, 74));
		((ToolStripItem)AddElementToolStripMenuItem).set_Name("AddElementToolStripMenuItem");
		((ToolStripItem)AddElementToolStripMenuItem).set_Padding(new Padding(0));
		((ToolStripItem)AddElementToolStripMenuItem).set_Size(new Size(253, 22));
		((ToolStripItem)AddElementToolStripMenuItem).set_Text("Add Medicines");
		((ToolStripItem)CheckAvailabilityToolStripMenuItem).set_Name("CheckAvailabilityToolStripMenuItem");
		((ToolStripItem)CheckAvailabilityToolStripMenuItem).set_Size(new Size(253, 24));
		((ToolStripItem)CheckAvailabilityToolStripMenuItem).set_Text("Check Availability");
		((ToolStripItem)updateToolStripMenuItem).set_Name("updateToolStripMenuItem");
		((ToolStripItem)updateToolStripMenuItem).set_Size(new Size(253, 24));
		((ToolStripItem)updateToolStripMenuItem).set_Text("Update Medicines Data");
		((ButtonBase)Bill).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Bill).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Bill).set_ForeColor(SystemColors.ActiveCaptionText);
		((ButtonBase)Bill).set_ImeMode((ImeMode)0);
		((Control)Bill).set_Location(new Point(920, 212));
		((Control)Bill).set_Name("Bill");
		((Control)Bill).set_Size(new Size(219, 41));
		((Control)Bill).set_TabIndex(8);
		((ButtonBase)Bill).set_Text("Billing");
		((ButtonBase)Bill).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(1247, 568));
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)med);
		((Control)this).get_Controls().Add((Control)(object)Bill);
		((Control)this).set_Name("Form31");
		((Form)this).set_Text("Pharmacy");
		((Control)strip).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void f1R0(object sender, EventArgs e)
	{
		((ToolStripDropDown)strip).Show((Control)(object)med, 0, ((Control)med).get_Height());
	}

	private void Sq82(object sender, EventArgs e)
	{
		((Control)Rg8.Forms.Form32).Show();
	}

	private void Jn07(object sender, EventArgs e)
	{
	}

	private void b9ZF(object sender, EventArgs e)
	{
		((Control)Rg8.Forms.Form33).Show();
	}

	private void Bn4x(object sender, EventArgs e)
	{
		((Control)Rg8.Forms.Form34).Show();
	}

	private void Ez8r(object sender, CancelEventArgs e)
	{
	}

	private void Mo6w(object sender, EventArgs e)
	{
		((Control)Rg8.Forms.Form35).Show();
	}
}
