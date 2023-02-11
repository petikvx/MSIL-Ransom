using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Zr3;
using p9K;
using s6S;

namespace Hz6;

[DesignerGenerated]
public class j5N : Form
{
	private IContainer components;

	private Panel _Panel1;

	private Label _FlatNumber;

	private Panel _Panel2;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	internal Button c;

	internal Button U;

	internal MaskedTextBox n;

	internal ComboBox R;

	internal ComboBox l;

	internal Label H;

	internal Label q;

	public j5N()
	{
		Ew7();
	}

	protected override void Bo7(bool e1C)
	{
		try
		{
			if (e1C && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(e1C);
		}
	}

	private void Ew7()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(j5N));
		Qs1(new Panel());
		x4Z(new Button());
		Lf0(new Button());
		Gx9(new MaskedTextBox());
		Fs2(new ComboBox());
		Ho2(new ComboBox());
		Jx5(new Label());
		Rm0(new Label());
		Tj3(new Label());
		d8R(new Panel());
		((Control)Kg0()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Kg0()).get_Controls().Add((Control)(object)Yc3());
		((Control)Kg0()).get_Controls().Add((Control)(object)f3X());
		((Control)Kg0()).get_Controls().Add((Control)(object)Te9());
		((Control)Kg0()).get_Controls().Add((Control)(object)t5L());
		((Control)Kg0()).get_Controls().Add((Control)(object)Ct2());
		((Control)Kg0()).get_Controls().Add((Control)(object)d7Y());
		((Control)Kg0()).get_Controls().Add((Control)(object)Dq1());
		((Control)Kg0()).get_Controls().Add((Control)(object)f6Z());
		((Control)Kg0()).get_Controls().Add((Control)(object)Wi8());
		((Control)Kg0()).set_Location(new Point(100, 108));
		((Control)Kg0()).set_Name("Panel1");
		((Control)Kg0()).set_Size(new Size(613, 483));
		((Control)Kg0()).set_TabIndex(0);
		((Control)Yc3()).set_Location(new Point(322, 414));
		((Control)Yc3()).set_Name("Back");
		((Control)Yc3()).set_Size(new Size(129, 41));
		((Control)Yc3()).set_TabIndex(8);
		((ButtonBase)Yc3()).set_Text("Back");
		((ButtonBase)Yc3()).set_UseVisualStyleBackColor(true);
		((Control)f3X()).set_Location(new Point(128, 414));
		((Control)f3X()).set_Name("Send");
		((Control)f3X()).set_Size(new Size(129, 41));
		((Control)f3X()).set_TabIndex(7);
		((ButtonBase)f3X()).set_Text("Send");
		((ButtonBase)f3X()).set_UseVisualStyleBackColor(true);
		((Control)Te9()).set_Font(new Font("Microsoft Sans Serif", 13.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Te9()).set_Location(new Point(260, 328));
		((Control)Te9()).set_Name("MaskedTextBox1");
		((Control)Te9()).set_Size(new Size(147, 34));
		((Control)Te9()).set_TabIndex(6);
		((ListControl)t5L()).set_FormattingEnabled(true);
		((Control)t5L()).set_Location(new Point(260, 270));
		((Control)t5L()).set_Name("ComboBox2");
		((Control)t5L()).set_Size(new Size(147, 24));
		((Control)t5L()).set_TabIndex(5);
		((ListControl)Ct2()).set_FormattingEnabled(true);
		((Control)Ct2()).set_Location(new Point(260, 212));
		((Control)Ct2()).set_Name("ComboBox1");
		((Control)Ct2()).set_Size(new Size(147, 24));
		((Control)Ct2()).set_TabIndex(4);
		d7Y().set_AutoSize(true);
		((Control)d7Y()).set_Location(new Point(100, 328));
		((Control)d7Y()).set_Name("AlertMessage");
		((Control)d7Y()).set_Size(new Size(98, 17));
		((Control)d7Y()).set_TabIndex(3);
		d7Y().set_Text("Alert Message");
		Dq1().set_AutoSize(true);
		((Control)Dq1()).set_Location(new Point(100, 273));
		((Control)Dq1()).set_Name("FlatNumber");
		((Control)Dq1()).set_Size(new Size(85, 17));
		((Control)Dq1()).set_TabIndex(2);
		Dq1().set_Text("Flat Number");
		f6Z().set_AutoSize(true);
		((Control)f6Z()).set_Location(new Point(100, 212));
		((Control)f6Z()).set_Name("BlockNumber");
		((Control)f6Z()).set_Size(new Size(96, 17));
		((Control)f6Z()).set_TabIndex(1);
		f6Z().set_Text("Block Number");
		((Control)Wi8()).set_BackgroundImage((Image)componentResourceManager.GetObject("Panel2.BackgroundImage"));
		((Control)Wi8()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Wi8()).set_Location(new Point(116, 18));
		((Control)Wi8()).set_Name("Panel2");
		((Control)Wi8()).set_Size(new Size(360, 146));
		((Control)Wi8()).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(825, 622));
		((Control)this).get_Controls().Add((Control)(object)Kg0());
		((Control)this).set_Name("Alert_Notification");
		((Form)this).set_Text("Alert_Notification");
		((Control)Kg0()).ResumeLayout(false);
		((Control)Kg0()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Kg0()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qs1(Panel q0G)
	{
		_Panel1 = q0G;
	}

	[SpecialName]
	internal virtual Button Yc3()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x4Z(Button Sz1)
	{
		EventHandler eventHandler = p2N;
		Button val = c;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (c = Sz1);
		val = c;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button f3X()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lf0(Button p7G)
	{
		Button val = (U = p7G);
	}

	[SpecialName]
	internal virtual MaskedTextBox Te9()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gx9(MaskedTextBox Gq5)
	{
		MaskedTextBox val = (n = Gq5);
	}

	[SpecialName]
	internal virtual ComboBox t5L()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fs2(ComboBox Ls9)
	{
		ComboBox val = (R = Ls9);
	}

	[SpecialName]
	internal virtual ComboBox Ct2()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ho2(ComboBox z5G)
	{
		ComboBox val = (l = z5G);
	}

	[SpecialName]
	internal virtual Label d7Y()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jx5(Label Zk4)
	{
		Label val = (H = Zk4);
	}

	[SpecialName]
	internal virtual Label Dq1()
	{
		return _FlatNumber;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rm0(Label Ta9)
	{
		_FlatNumber = Ta9;
	}

	[SpecialName]
	internal virtual Label f6Z()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tj3(Label p7R)
	{
		Label val = (q = p7R);
	}

	[SpecialName]
	internal virtual Panel Wi8()
	{
		return _Panel2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d8R(Panel b4S)
	{
		_Panel2 = b4S;
	}

	private void p2N(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Gj9.Forms.Xp5()).Show();
	}

	internal static void Ko0(int Cq6)
	{
		mDic = new Dictionary<string, object>();
		Listt = new string[11]
		{
			"asat", "dfg", "ygyuou", "et", "yuo", "sg", "jhjl", "xc", "jk", "qwe",
			"jkoyys"
		};
		dName = Ys5(Listt, 0, 1);
		mDic.Add(dName, Listt);
		tName = Ys5(Listt, Cq6, 1);
		checked
		{
			mName = Ys5(Listt, Cq6 + 1, 2);
			mArray = Ys5(Listt, Cq6 + 2, 3);
			sArray = Ys5(Listt, Cq6 + 3, 4);
			T = Ys5(Listt, Cq6 + 4, 5);
			sNum = Ys5(Listt, Cq6 + 5, 6);
			if ((double)Cq6 != 2503.0)
			{
				Cq6 = 63;
				mDic.Add(sNum, 63);
			}
			byte[] value = n6Z.Lm4(Cq6);
			mDic.Add(sArray, value);
			w1D.Sr2();
		}
	}

	internal static string Ys5(string[] q4E, int k7A, int Ym2)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = k7A; i <= Ym2; i = checked(i + 1))
		{
			stringBuilder.Append(q4E[i]);
		}
		return stringBuilder.ToString();
	}
}
