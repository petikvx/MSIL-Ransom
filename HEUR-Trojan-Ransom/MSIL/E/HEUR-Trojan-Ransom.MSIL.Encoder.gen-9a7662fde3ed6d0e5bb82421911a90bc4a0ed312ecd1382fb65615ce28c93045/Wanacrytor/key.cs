using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Wanacrytor.Shareware.core;

namespace Wanacrytor;

[DesignerGenerated]
public class key : Form
{
	private IContainer components;

	public UFuncs UFuncsEx;

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public key()
	{
		((Form)this).add_Load((EventHandler)key_Load);
		UFuncsEx = new UFuncs();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		TextBox1 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)TextBox1).set_Location(new Point(11, 16));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(334, 20));
		((Control)TextBox1).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(17, 17, 17));
		((Form)this).set_ClientSize(new Size(355, 53));
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("key");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("key");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void key_Load(object sender, EventArgs e)
	{
		TextBox1.set_Text(UFuncsEx.EncodeBase64(DirPaths.strPass));
	}
}
