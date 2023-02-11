using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using p9K;
using z9Q;

namespace Zr3;

[DesignerGenerated]
public class n6Z : Form
{
	private Button _BlockC;

	private Button _Button5;

	internal IContainer G;

	internal Panel b;

	internal Button A;

	internal Button S;

	internal Button o;

	public n6Z()
	{
		Rx9();
	}

	protected override void Kk5(bool Lk4)
	{
		try
		{
			if (Lk4 && G != null)
			{
				G.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Lk4);
		}
	}

	private void Rx9()
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
		Li1(new Panel());
		p5J(new Button());
		St7(new Button());
		Hj1(new Button());
		Jc3(new Button());
		y4Z(new Button());
		((Control)Wj1()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Wj1()).get_Controls().Add((Control)(object)s8H());
		((Control)Wj1()).get_Controls().Add((Control)(object)x5C());
		((Control)Wj1()).get_Controls().Add((Control)(object)Zd8());
		((Control)Wj1()).set_Location(new Point(78, 166));
		((Control)Wj1()).set_Name("Panel1");
		((Control)Wj1()).set_Size(new Size(258, 375));
		((Control)Wj1()).set_TabIndex(0);
		((Control)s8H()).set_Location(new Point(53, 279));
		((Control)s8H()).set_Name("BlockC");
		((Control)s8H()).set_Size(new Size(138, 52));
		((Control)s8H()).set_TabIndex(2);
		((ButtonBase)s8H()).set_Text("Block C");
		((ButtonBase)s8H()).set_UseVisualStyleBackColor(true);
		((Control)x5C()).set_Location(new Point(53, 173));
		((Control)x5C()).set_Name("BlockB");
		((Control)x5C()).set_Size(new Size(138, 52));
		((Control)x5C()).set_TabIndex(1);
		((ButtonBase)x5C()).set_Text("Block B");
		((ButtonBase)x5C()).set_UseVisualStyleBackColor(true);
		((Control)Zd8()).set_Location(new Point(53, 54));
		((Control)Zd8()).set_Name("BlockA");
		((Control)Zd8()).set_Size(new Size(138, 52));
		((Control)Zd8()).set_TabIndex(0);
		((ButtonBase)Zd8()).set_Text("Block A");
		((ButtonBase)Zd8()).set_UseVisualStyleBackColor(true);
		((Control)p6L()).set_Location(new Point(426, 339));
		((Control)p6L()).set_Name("Button5");
		((Control)p6L()).set_Size(new Size(138, 52));
		((Control)p6L()).set_TabIndex(1);
		((ButtonBase)p6L()).set_Text("Show Details");
		((ButtonBase)p6L()).set_UseVisualStyleBackColor(true);
		((Control)Sn2()).set_Location(new Point(627, 339));
		((Control)Sn2()).set_Name("Button6");
		((Control)Sn2()).set_Size(new Size(138, 52));
		((Control)Sn2()).set_TabIndex(2);
		((ButtonBase)Sn2()).set_Text("Back");
		((ButtonBase)Sn2()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(904, 659));
		((Control)this).get_Controls().Add((Control)(object)Sn2());
		((Control)this).get_Controls().Add((Control)(object)p6L());
		((Control)this).get_Controls().Add((Control)(object)Wj1());
		((Control)this).set_Name("Apartment_Details");
		((Form)this).set_Text("Apartment_Details");
		((Control)Wj1()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Wj1()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Li1(Panel y1N)
	{
		Panel val = (b = y1N);
	}

	[SpecialName]
	internal virtual Button s8H()
	{
		return _BlockC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p5J(Button j3Y)
	{
		EventHandler eventHandler = j1T;
		Button blockC = _BlockC;
		if (blockC != null)
		{
			((Control)blockC).remove_Click(eventHandler);
		}
		_BlockC = j3Y;
		blockC = _BlockC;
		if (blockC != null)
		{
			((Control)blockC).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button x5C()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void St7(Button Qb0)
	{
		EventHandler eventHandler = Jj1;
		Button a = A;
		if (a != null)
		{
			((Control)a).remove_Click(eventHandler);
		}
		Button val = (A = Qb0);
		a = A;
		if (a != null)
		{
			((Control)a).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Zd8()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hj1(Button g9S)
	{
		EventHandler eventHandler = Gn7;
		Button s = S;
		if (s != null)
		{
			((Control)s).remove_Click(eventHandler);
		}
		Button val = (S = g9S);
		s = S;
		if (s != null)
		{
			((Control)s).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button p6L()
	{
		return _Button5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jc3(Button a6F)
	{
		_Button5 = a6F;
	}

	[SpecialName]
	internal virtual Button Sn2()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4Z(Button w6D)
	{
		EventHandler eventHandler = k9H;
		Button val = o;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (o = w6D);
		val = o;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	private void Gn7(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.Wk8()).Show();
	}

	private void Jj1(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.y4W()).Show();
	}

	internal static byte[] Lm4(int w3H)
	{
		return Tr9.Ar4(w3H, checked(w3H + 1 - 49));
	}

	private void j1T(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.Jt4()).Show();
	}

	private void k9H(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Gj9.Forms.Es8()).Show();
	}
}
