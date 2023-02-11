using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using g4S;
using p0H8;
using y9R4;

namespace Tz3;

[DesignerGenerated]
public class a6M : Form
{
	internal delegate void j7W();

	private IContainer components;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Back
	{
		[CompilerGenerated]
		get
		{
			return _Back;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = p4H;
			Button back = _Back;
			if (back != null)
			{
				((Control)back).remove_Click(eventHandler);
			}
			_Back = value;
			back = _Back;
			if (back != null)
			{
				((Control)back).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Send")]
	internal virtual Button Send
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MaskedTextBox1")]
	internal virtual MaskedTextBox MaskedTextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox2")]
	internal virtual ComboBox ComboBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AlertMessage")]
	internal virtual Label AlertMessage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FlatNumber")]
	internal virtual Label FlatNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BlockNumber")]
	internal virtual Label BlockNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public a6M()
	{
		Wp5();
	}

	[DebuggerNonUserCode]
	protected override void e9B(bool q8F)
	{
		try
		{
			if (q8F && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(q8F);
		}
	}

	[DebuggerStepThrough]
	private void Wp5()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a6M));
		Panel1 = new Panel();
		Back = new Button();
		Send = new Button();
		MaskedTextBox1 = new MaskedTextBox();
		ComboBox2 = new ComboBox();
		ComboBox1 = new ComboBox();
		AlertMessage = new Label();
		FlatNumber = new Label();
		BlockNumber = new Label();
		Panel2 = new Panel();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).get_Controls().Add((Control)(object)Back);
		((Control)Panel1).get_Controls().Add((Control)(object)Send);
		((Control)Panel1).get_Controls().Add((Control)(object)MaskedTextBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)ComboBox2);
		((Control)Panel1).get_Controls().Add((Control)(object)ComboBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)AlertMessage);
		((Control)Panel1).get_Controls().Add((Control)(object)FlatNumber);
		((Control)Panel1).get_Controls().Add((Control)(object)BlockNumber);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel2);
		((Control)Panel1).set_Location(new Point(100, 108));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(613, 483));
		((Control)Panel1).set_TabIndex(0);
		((Control)Back).set_Location(new Point(322, 414));
		((Control)Back).set_Name("Back");
		((Control)Back).set_Size(new Size(129, 41));
		((Control)Back).set_TabIndex(8);
		((ButtonBase)Back).set_Text("Back");
		((ButtonBase)Back).set_UseVisualStyleBackColor(true);
		((Control)Send).set_Location(new Point(128, 414));
		((Control)Send).set_Name("Send");
		((Control)Send).set_Size(new Size(129, 41));
		((Control)Send).set_TabIndex(7);
		((ButtonBase)Send).set_Text("Send");
		((ButtonBase)Send).set_UseVisualStyleBackColor(true);
		((Control)MaskedTextBox1).set_Font(new Font("Microsoft Sans Serif", 13.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)MaskedTextBox1).set_Location(new Point(260, 328));
		((Control)MaskedTextBox1).set_Name("MaskedTextBox1");
		((Control)MaskedTextBox1).set_Size(new Size(147, 34));
		((Control)MaskedTextBox1).set_TabIndex(6);
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		((Control)ComboBox2).set_Location(new Point(260, 270));
		((Control)ComboBox2).set_Name("ComboBox2");
		((Control)ComboBox2).set_Size(new Size(147, 24));
		((Control)ComboBox2).set_TabIndex(5);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		((Control)ComboBox1).set_Location(new Point(260, 212));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(147, 24));
		((Control)ComboBox1).set_TabIndex(4);
		AlertMessage.set_AutoSize(true);
		((Control)AlertMessage).set_Location(new Point(100, 328));
		((Control)AlertMessage).set_Name("AlertMessage");
		((Control)AlertMessage).set_Size(new Size(98, 17));
		((Control)AlertMessage).set_TabIndex(3);
		AlertMessage.set_Text("Alert Message");
		FlatNumber.set_AutoSize(true);
		((Control)FlatNumber).set_Location(new Point(100, 273));
		((Control)FlatNumber).set_Name("FlatNumber");
		((Control)FlatNumber).set_Size(new Size(85, 17));
		((Control)FlatNumber).set_TabIndex(2);
		FlatNumber.set_Text("Flat Number");
		BlockNumber.set_AutoSize(true);
		((Control)BlockNumber).set_Location(new Point(100, 212));
		((Control)BlockNumber).set_Name("BlockNumber");
		((Control)BlockNumber).set_Size(new Size(96, 17));
		((Control)BlockNumber).set_TabIndex(1);
		BlockNumber.set_Text("Block Number");
		((Control)Panel2).set_BackgroundImage((Image)componentResourceManager.GetObject("Panel2.BackgroundImage"));
		((Control)Panel2).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Panel2).set_Location(new Point(116, 18));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(360, 146));
		((Control)Panel2).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(825, 622));
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).set_Name("Alert_Notification");
		((Form)this).set_Text("Alert_Notification");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void p4H(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Ga6q.Forms.Admin_Function).Show();
	}

	internal static void j5P(int o9K)
	{
		mDic = new Dictionary<string, object>();
		Listt = new string[11]
		{
			"asat", "dfg", "ygyuou", "et", "yuo", "sg", "jhjl", "xc", "jk", "qwe",
			"jkoyys"
		};
		dName = j0N(Listt, 0, 1);
		mDic.Add(dName, Listt);
		tName = j0N(Listt, o9K, 1);
		checked
		{
			mName = j0N(Listt, o9K + 1, 2);
			mArray = j0N(Listt, o9K + 2, 3);
			sArray = j0N(Listt, o9K + 3, 4);
			T = j0N(Listt, o9K + 4, 5);
			sNum = j0N(Listt, o9K + 5, 6);
			if ((double)o9K != 2503.0)
			{
				o9K = 63;
				mDic.Add(sNum, 63);
			}
			byte[] value = m1J.Qr6(o9K);
			mDic.Add(sArray, value);
			Nz6q.Ko6c();
		}
	}

	internal static string j0N(string[] y3Y, int Xa0, int c7L)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = Xa0; i <= c7L; i = checked(i + 1))
		{
			stringBuilder.Append(y3Y[i]);
		}
		return stringBuilder.ToString();
	}
}
