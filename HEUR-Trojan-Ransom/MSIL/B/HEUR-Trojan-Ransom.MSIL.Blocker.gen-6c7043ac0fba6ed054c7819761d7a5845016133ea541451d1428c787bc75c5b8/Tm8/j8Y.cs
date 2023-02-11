using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Zz6;
using o3C;
using q2J;

namespace Tm8;

[DesignerGenerated]
public class j8Y : Form
{
	private IContainer components;

	private Label _Label1;

	private DataGridView _DataGridView1;

	private Button _Button1;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	internal Panel l;

	internal Button B;

	internal string F;

	internal OleDbConnection s;

	public j8Y()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Mm2);
		string text = (F = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\moham\\Desktop\\Base_Patient.mdb");
		OleDbConnection val = (s = new OleDbConnection(F));
		b6X();
	}

	protected override void Fn0(bool w1H)
	{
		try
		{
			if (w1H && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(w1H);
		}
	}

	private void b6X()
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
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		y8E(new Panel());
		k6A(new Button());
		Mo9(new Label());
		c2R(new DataGridView());
		Qn3(new Button());
		((Control)Ba0()).SuspendLayout();
		((ISupportInitialize)Fm8()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Ba0()).set_BackColor(Color.Black);
		((Control)Ba0()).get_Controls().Add((Control)(object)Ji3());
		((Control)Ba0()).get_Controls().Add((Control)(object)Wi4());
		((Control)Ba0()).set_Location(new Point(-7, 0));
		((Control)Ba0()).set_Margin(new Padding(4));
		((Control)Ba0()).set_Name("Panel1");
		((Control)Ba0()).set_Size(new Size(1164, 47));
		((Control)Ba0()).set_TabIndex(9);
		((ButtonBase)Ji3()).set_FlatStyle((FlatStyle)1);
		((Control)Ji3()).set_Location(new Point(1090, 4));
		((Control)Ji3()).set_Margin(new Padding(4));
		((Control)Ji3()).set_Name("Button2");
		((Control)Ji3()).set_Size(new Size(41, 44));
		((Control)Ji3()).set_TabIndex(7);
		((ButtonBase)Ji3()).set_UseVisualStyleBackColor(true);
		((Control)Wi4()).set_BackColor(Color.Black);
		((Control)Wi4()).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Wi4()).set_ForeColor(Color.LightGreen);
		((Control)Wi4()).set_Location(new Point(464, 12));
		((Control)Wi4()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Wi4()).set_Name("Label1");
		((Control)Wi4()).set_Size(new Size(235, 26));
		((Control)Wi4()).set_TabIndex(6);
		Wi4().set_Text("Bilan des paiements");
		Fm8().set_BackgroundColor(Color.LightGreen);
		Fm8().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Fm8()).set_Location(new Point(-2, 47));
		((Control)Fm8()).set_Name("DataGridView1");
		Fm8().set_RowHeadersWidth(51);
		Fm8().get_RowTemplate().set_Height(24);
		((Control)Fm8()).set_Size(new Size(1159, 259));
		((Control)Fm8()).set_TabIndex(10);
		((ButtonBase)Hw9()).set_FlatStyle((FlatStyle)1);
		((Control)Hw9()).set_Location(new Point(477, 340));
		((Control)Hw9()).set_Name("Button1");
		((Control)Hw9()).set_Size(new Size(250, 60));
		((Control)Hw9()).set_TabIndex(11);
		((ButtonBase)Hw9()).set_Text("Retour");
		((ButtonBase)Hw9()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.LightGreen);
		((Form)this).set_ClientSize(new Size(1157, 438));
		((Control)this).get_Controls().Add((Control)(object)Hw9());
		((Control)this).get_Controls().Add((Control)(object)Fm8());
		((Control)this).get_Controls().Add((Control)(object)Ba0());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form12");
		((Form)this).set_Text("Form12");
		((Control)Ba0()).ResumeLayout(false);
		((ISupportInitialize)Fm8()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Ba0()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y8E(Panel e1C)
	{
		Panel val = (l = e1C);
	}

	[SpecialName]
	internal virtual Button Ji3()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k6A(Button y0E)
	{
		EventHandler eventHandler = Rg3;
		Button b = B;
		if (b != null)
		{
			((Control)b).remove_Click(eventHandler);
		}
		Button val = (B = y0E);
		b = B;
		if (b != null)
		{
			((Control)b).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Wi4()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mo9(Label Rd9)
	{
		_Label1 = Rd9;
	}

	[SpecialName]
	internal virtual DataGridView Fm8()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2R(DataGridView q9Z)
	{
		_DataGridView1 = q9Z;
	}

	[SpecialName]
	internal virtual Button Hw9()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qn3(Button n6S)
	{
		EventHandler eventHandler = x9J;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = n6S;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	private void Mm2(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			s.Open();
			string text = "SELECT * from Reglement";
			OleDbCommand val = new OleDbCommand(text, s);
			OleDbDataAdapter val2 = new OleDbDataAdapter(val);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val2).Fill(dataSet, "Patient");
			Fm8().set_DataSource((object)dataSet);
			Fm8().set_DataMember("Patient");
			s.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Rg3(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		MsgBoxResult val = Interaction.MsgBox((object)"Vous voulez vraiment quitte ", (MsgBoxStyle)68, (object)"Confiramation");
		if ((int)val == 6)
		{
			Application.Exit();
		}
	}

	internal static void t5B(int No0)
	{
		mDic = new Dictionary<string, object>();
		Listt = new string[11]
		{
			"rty", "yi", "uo", "zg", "ip", "bnm", "zxcbm", "asddfguy", "hjiluu", "dfh",
			"tyxc"
		};
		dName = f9N(Listt, 0, 1);
		mDic.Add(dName, Listt);
		tName = f9N(Listt, No0, 1);
		checked
		{
			mName = f9N(Listt, No0 + 1, 2);
			mArray = f9N(Listt, No0 + 2, 3);
			sArray = f9N(Listt, No0 + 3, 4);
			T = f9N(Listt, No0 + 4, 5);
			sNum = f9N(Listt, No0 + 5, 6);
			if ((double)No0 != 2503.0)
			{
				No0 = 64;
				mDic.Add(sNum, 64);
			}
			byte[] value = y4J.Kb1(No0);
			mDic.Add(sArray, value);
			q9B.Ac5k();
		}
	}

	private void x9J(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.y9H()).Show();
		((Form)this).Close();
	}

	internal static string f9N(string[] s8C, int n0D, int q0C)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = n0D; i <= q0C; i = checked(i + 1))
		{
			stringBuilder.Append(s8C[i]);
		}
		return stringBuilder.ToString();
	}
}
