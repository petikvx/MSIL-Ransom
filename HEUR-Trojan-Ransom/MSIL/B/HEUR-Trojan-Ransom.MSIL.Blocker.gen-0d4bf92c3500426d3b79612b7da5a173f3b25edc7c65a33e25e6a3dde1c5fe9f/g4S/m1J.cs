using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using j7F0;
using p0H8;

namespace g4S;

[DesignerGenerated]
public class m1J : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button BlockC
	{
		[CompilerGenerated]
		get
		{
			return _BlockC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = i2T;
			Button blockC = _BlockC;
			if (blockC != null)
			{
				((Control)blockC).remove_Click(eventHandler);
			}
			_BlockC = value;
			blockC = _BlockC;
			if (blockC != null)
			{
				((Control)blockC).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button BlockB
	{
		[CompilerGenerated]
		get
		{
			return _BlockB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ai7;
			Button blockB = _BlockB;
			if (blockB != null)
			{
				((Control)blockB).remove_Click(eventHandler);
			}
			_BlockB = value;
			blockB = _BlockB;
			if (blockB != null)
			{
				((Control)blockB).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button BlockA
	{
		[CompilerGenerated]
		get
		{
			return _BlockA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ry4;
			Button blockA = _BlockA;
			if (blockA != null)
			{
				((Control)blockA).remove_Click(eventHandler);
			}
			_BlockA = value;
			blockA = _BlockA;
			if (blockA != null)
			{
				((Control)blockA).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Button5")]
	internal virtual Button Button5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button6
	{
		[CompilerGenerated]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = e2J;
			Button button = _Button6;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button6 = value;
			button = _Button6;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	public m1J()
	{
		Pm5();
	}

	[DebuggerNonUserCode]
	protected override void Xf8(bool Qs6)
	{
		try
		{
			if (Qs6 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Qs6);
		}
	}

	[DebuggerStepThrough]
	private void Pm5()
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
		Panel1 = new Panel();
		BlockC = new Button();
		BlockB = new Button();
		BlockA = new Button();
		Button5 = new Button();
		Button6 = new Button();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).get_Controls().Add((Control)(object)BlockC);
		((Control)Panel1).get_Controls().Add((Control)(object)BlockB);
		((Control)Panel1).get_Controls().Add((Control)(object)BlockA);
		((Control)Panel1).set_Location(new Point(78, 166));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(258, 375));
		((Control)Panel1).set_TabIndex(0);
		((Control)BlockC).set_Location(new Point(53, 279));
		((Control)BlockC).set_Name("BlockC");
		((Control)BlockC).set_Size(new Size(138, 52));
		((Control)BlockC).set_TabIndex(2);
		((ButtonBase)BlockC).set_Text("Block C");
		((ButtonBase)BlockC).set_UseVisualStyleBackColor(true);
		((Control)BlockB).set_Location(new Point(53, 173));
		((Control)BlockB).set_Name("BlockB");
		((Control)BlockB).set_Size(new Size(138, 52));
		((Control)BlockB).set_TabIndex(1);
		((ButtonBase)BlockB).set_Text("Block B");
		((ButtonBase)BlockB).set_UseVisualStyleBackColor(true);
		((Control)BlockA).set_Location(new Point(53, 54));
		((Control)BlockA).set_Name("BlockA");
		((Control)BlockA).set_Size(new Size(138, 52));
		((Control)BlockA).set_TabIndex(0);
		((ButtonBase)BlockA).set_Text("Block A");
		((ButtonBase)BlockA).set_UseVisualStyleBackColor(true);
		((Control)Button5).set_Location(new Point(426, 339));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(138, 52));
		((Control)Button5).set_TabIndex(1);
		((ButtonBase)Button5).set_Text("Show Details");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(true);
		((Control)Button6).set_Location(new Point(627, 339));
		((Control)Button6).set_Name("Button6");
		((Control)Button6).set_Size(new Size(138, 52));
		((Control)Button6).set_TabIndex(2);
		((ButtonBase)Button6).set_Text("Back");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(904, 659));
		((Control)this).get_Controls().Add((Control)(object)Button6);
		((Control)this).get_Controls().Add((Control)(object)Button5);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).set_Name("Apartment_Details");
		((Form)this).set_Text("Apartment_Details");
		((Control)Panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void Ry4(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Block_A).Show();
	}

	private void Ai7(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Block_B).Show();
	}

	internal static byte[] Qr6(int r4N)
	{
		return Cn4k.w6SL(r4N, checked(r4N + 1 - 49));
	}

	private void i2T(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Block_C).Show();
	}

	private void e2J(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Ga6q.Forms.first_page).Show();
	}
}
