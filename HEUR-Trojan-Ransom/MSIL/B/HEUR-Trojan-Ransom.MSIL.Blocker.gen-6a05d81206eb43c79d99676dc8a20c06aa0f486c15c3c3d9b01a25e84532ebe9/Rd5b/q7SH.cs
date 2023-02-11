using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hz6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Rd5b;

[DesignerGenerated]
public class q7SH : Form
{
	private Label _TenantID;

	private Label _Name;

	private Label _FlatNumber;

	private Label _Date2;

	private MaskedTextBox _tname;

	private MaskedTextBox _f_no;

	private Button _Submit;

	private ComboBox _complain;

	private DateTimePicker _DateTimePicker1;

	private SqlConnection con;

	internal IContainer I;

	internal Button y;

	internal Button h;

	internal Label p;

	internal MaskedTextBox K;

	internal SqlCommand V;

	public q7SH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		con = new SqlConnection();
		SqlCommand val = (V = new SqlCommand());
		z1RC();
	}

	protected override void b4C0(bool Sf64)
	{
		try
		{
			if (Sf64 && I != null)
			{
				I.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Sf64);
		}
	}

	private void z1RC()
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		y7QT(new Button());
		Ry2o(new Button());
		w7T8(new Label());
		Qz60(new Label());
		Ej9r(new Label());
		Lj0f(new Label());
		p6P0(new Label());
		Rn24(new MaskedTextBox());
		Bz31(new MaskedTextBox());
		s3FB(new MaskedTextBox());
		b2JC(new Button());
		b0KY(new ComboBox());
		i9E1(new DateTimePicker());
		((Control)this).SuspendLayout();
		((Control)Fd53()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Fd53()).set_Location(new Point(696, 131));
		((Control)Fd53()).set_Name("Logout");
		((Control)Fd53()).set_Size(new Size(122, 37));
		((Control)Fd53()).set_TabIndex(17);
		((ButtonBase)Fd53()).set_Text("Logout");
		((ButtonBase)Fd53()).set_UseVisualStyleBackColor(true);
		((Control)t7LF()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)t7LF()).set_Location(new Point(496, 131));
		((Control)t7LF()).set_Name("Back");
		((Control)t7LF()).set_Size(new Size(122, 37));
		((Control)t7LF()).set_TabIndex(16);
		((ButtonBase)t7LF()).set_Text("Back");
		((ButtonBase)t7LF()).set_UseVisualStyleBackColor(true);
		Ac7f().set_AutoSize(true);
		((Control)Ac7f()).set_Location(new Point(61, 131));
		((Control)Ac7f()).set_Name("TenantID");
		((Control)Ac7f()).set_Size(new Size(70, 17));
		((Control)Ac7f()).set_TabIndex(0);
		Ac7f().set_Text("Tenant ID");
		Ht5z().set_AutoSize(true);
		((Control)Ht5z()).set_Location(new Point(61, 198));
		((Control)Ht5z()).set_Name("Name");
		((Control)Ht5z()).set_Size(new Size(45, 17));
		((Control)Ht5z()).set_TabIndex(1);
		Ht5z().set_Text("Name");
		Nk7t().set_AutoSize(true);
		((Control)Nk7t()).set_Location(new Point(61, 247));
		((Control)Nk7t()).set_Name("FlatNumber");
		((Control)Nk7t()).set_Size(new Size(85, 17));
		((Control)Nk7t()).set_TabIndex(2);
		Nk7t().set_Text("Flat Number");
		t9R0().set_AutoSize(true);
		((Control)t9R0()).set_Location(new Point(61, 298));
		((Control)t9R0()).set_Name("Complaint");
		((Control)t9R0()).set_Size(new Size(70, 17));
		((Control)t9R0()).set_TabIndex(3);
		t9R0().set_Text("Complaint");
		Xf7c().set_AutoSize(true);
		((Control)Xf7c()).set_Location(new Point(61, 352));
		((Control)Xf7c()).set_Name("Date2");
		((Control)Xf7c()).set_Size(new Size(38, 17));
		((Control)Xf7c()).set_TabIndex(4);
		Xf7c().set_Text("Date");
		((Control)Pg14()).set_Location(new Point(191, 126));
		((Control)Pg14()).set_Name("t_id");
		((Control)Pg14()).set_Size(new Size(183, 22));
		((Control)Pg14()).set_TabIndex(15);
		((Control)Hb36()).set_Location(new Point(191, 193));
		((Control)Hb36()).set_Name("tname");
		((Control)Hb36()).set_Size(new Size(183, 22));
		((Control)Hb36()).set_TabIndex(16);
		((Control)g9C2()).set_Location(new Point(191, 244));
		((Control)g9C2()).set_Name("f_no");
		((Control)g9C2()).set_Size(new Size(183, 22));
		((Control)g9C2()).set_TabIndex(17);
		((Control)q0CA()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)q0CA()).set_Location(new Point(585, 488));
		((Control)q0CA()).set_Name("Submit");
		((Control)q0CA()).set_Size(new Size(127, 42));
		((Control)q0CA()).set_TabIndex(15);
		((ButtonBase)q0CA()).set_Text("Submit");
		((ButtonBase)q0CA()).set_UseVisualStyleBackColor(true);
		((ListControl)n7JW()).set_FormattingEnabled(true);
		n7JW().get_Items().AddRange(new object[3] { "Insufficiency of Water", "Road Damage", "Parking Camera Not Working" });
		((Control)n7JW()).set_Location(new Point(191, 295));
		((Control)n7JW()).set_Name("complain");
		((Control)n7JW()).set_Size(new Size(183, 24));
		((Control)n7JW()).set_TabIndex(22);
		((Control)Lz3g()).set_Location(new Point(191, 352));
		((Control)Lz3g()).set_Name("DateTimePicker1");
		((Control)Lz3g()).set_Size(new Size(200, 22));
		((Control)Lz3g()).set_TabIndex(23);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(902, 642));
		((Control)this).get_Controls().Add((Control)(object)Lz3g());
		((Control)this).get_Controls().Add((Control)(object)n7JW());
		((Control)this).get_Controls().Add((Control)(object)q0CA());
		((Control)this).get_Controls().Add((Control)(object)g9C2());
		((Control)this).get_Controls().Add((Control)(object)Hb36());
		((Control)this).get_Controls().Add((Control)(object)Pg14());
		((Control)this).get_Controls().Add((Control)(object)Xf7c());
		((Control)this).get_Controls().Add((Control)(object)t9R0());
		((Control)this).get_Controls().Add((Control)(object)Nk7t());
		((Control)this).get_Controls().Add((Control)(object)Ht5z());
		((Control)this).get_Controls().Add((Control)(object)Ac7f());
		((Control)this).get_Controls().Add((Control)(object)Fd53());
		((Control)this).get_Controls().Add((Control)(object)t7LF());
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Fd53()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y7QT(Button b3Y6)
	{
		Button val = (y = b3Y6);
	}

	[SpecialName]
	internal virtual Button t7LF()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ry2o(Button Jc27)
	{
		EventHandler eventHandler = Cf9y;
		Button val = h;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (h = Jc27);
		val = h;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Ac7f()
	{
		return _TenantID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w7T8(Label f9L6)
	{
		_TenantID = f9L6;
	}

	[SpecialName]
	internal virtual Label Ht5z()
	{
		return _Name;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qz60(Label Tb8q)
	{
		_Name = Tb8q;
	}

	[SpecialName]
	internal virtual Label Nk7t()
	{
		return _FlatNumber;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ej9r(Label q7TN)
	{
		_FlatNumber = q7TN;
	}

	[SpecialName]
	internal virtual Label t9R0()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lj0f(Label Dg70)
	{
		Label val = (p = Dg70);
	}

	[SpecialName]
	internal virtual Label Xf7c()
	{
		return _Date2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p6P0(Label x5GY)
	{
		_Date2 = x5GY;
	}

	[SpecialName]
	internal virtual MaskedTextBox Pg14()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rn24(MaskedTextBox Ye3k)
	{
		MaskedTextBox val = (K = Ye3k);
	}

	[SpecialName]
	internal virtual MaskedTextBox Hb36()
	{
		return _tname;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bz31(MaskedTextBox t0BF)
	{
		_tname = t0BF;
	}

	[SpecialName]
	internal virtual MaskedTextBox g9C2()
	{
		return _f_no;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s3FB(MaskedTextBox y8R7)
	{
		_f_no = y8R7;
	}

	[SpecialName]
	internal virtual Button q0CA()
	{
		return _Submit;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b2JC(Button a8T5)
	{
		EventHandler eventHandler = r2NZ;
		Button submit = _Submit;
		if (submit != null)
		{
			((Control)submit).remove_Click(eventHandler);
		}
		_Submit = a8T5;
		submit = _Submit;
		if (submit != null)
		{
			((Control)submit).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ComboBox n7JW()
	{
		return _complain;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b0KY(ComboBox Ws6o)
	{
		_complain = Ws6o;
	}

	[SpecialName]
	internal virtual DateTimePicker Lz3g()
	{
		return _DateTimePicker1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i9E1(DateTimePicker t8S1)
	{
		_DateTimePicker1 = t8S1;
	}

	private void r2NZ(object sender, EventArgs e)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Manish\\Source\\Repos\\Apartment-Management-System2\\apart.mdf;Integrated Security=True");
			V.set_Connection(con);
			V.set_CommandText(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)("insert into complain(tenantid,name,flatnumber,complain,date) values(" + Pg14().get_Text() + ",'" + Hb36().get_Text() + "'," + g9C2().get_Text() + ",'"), n7JW().get_SelectedItem()), (object)"','"), (object)Lz3g().get_Value()), (object)"')")));
			con.Open();
			if (V.ExecuteNonQuery() == 1)
			{
				MessageBox.Show(" Added");
			}
			else
			{
				MessageBox.Show(" Not Added");
			}
			con.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"invalid cmd", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Cf9y(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal static string[] k2MG()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)j5N.mDic["Ann"]).GetManifestResourceNames();
		foreach (string item in manifestResourceNames)
		{
			list.Add(item);
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}
}
