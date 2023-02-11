using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ek9;
using Hz6;
using Microsoft.VisualBasic.CompilerServices;
using m2Q;
using p9K;

namespace Ww2i;

[DesignerGenerated]
public class g2BD : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 10584)]
	private struct Le24
	{
	}

	private Panel _Panel1;

	private BindingSource _HouseentryBindingSource;

	private DataGridViewTextBoxColumn _PhoneDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _BlockNoDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _FlattypeDataGridViewTextBoxColumn;

	private static readonly Array n;

	private static readonly object U;

	private static readonly Array i;

	internal static byte c/* Not supported: data(00) */;

	internal IContainer g;

	internal Button Q;

	internal Button H;

	internal RadioButton k;

	internal RadioButton s;

	internal BindingSource P;

	internal DataGridView j;

	internal DataGridViewTextBoxColumn N;

	internal DataGridViewTextBoxColumn e;

	internal DataGridViewTextBoxColumn F;

	internal DataGridViewTextBoxColumn Y;

	internal DataGridViewTextBoxColumn L;

	internal BindingSource W;

	internal Label v;

	public g2BD()
	{
		((Form)this).add_Load((EventHandler)Me10);
		Jn72();
	}

	protected override void Xo5w(bool d3K8)
	{
		try
		{
			if (d3K8 && g != null)
			{
				g.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(d3K8);
		}
	}

	private void Jn72()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected O, but got Unknown
		IContainer container = (g = new Container());
		t9XM(new Panel());
		y3EB(new RadioButton());
		x5PB(new RadioButton());
		Wm57(new Button());
		r9CR(new Button());
		Qa08(new BindingSource(g));
		f7R2(new DataGridView());
		e8BK(new BindingSource(g));
		t6FH(new DataGridViewTextBoxColumn());
		Te61(new DataGridViewTextBoxColumn());
		Tg3p(new DataGridViewTextBoxColumn());
		g1E3(new DataGridViewTextBoxColumn());
		Hd5i(new DataGridViewTextBoxColumn());
		As4y(new DataGridViewTextBoxColumn());
		d0FA(new DataGridViewTextBoxColumn());
		Bp13(new DataGridViewTextBoxColumn());
		Nm8x(new BindingSource(g));
		y4RH(new Label());
		((Control)k6P3()).SuspendLayout();
		((ISupportInitialize)Ls14()).BeginInit();
		((ISupportInitialize)w6QA()).BeginInit();
		((ISupportInitialize)Tw15()).BeginInit();
		((ISupportInitialize)x5H8()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)k6P3()).get_Controls().Add((Control)(object)d5G9());
		((Control)k6P3()).get_Controls().Add((Control)(object)f6X0());
		((Control)k6P3()).set_Location(new Point(47, 38));
		((Control)k6P3()).set_Name("Panel1");
		((Control)k6P3()).set_Size(new Size(139, 116));
		((Control)k6P3()).set_TabIndex(0);
		((ButtonBase)d5G9()).set_AutoSize(true);
		((Control)d5G9()).set_ForeColor(SystemColors.ControlText);
		((Control)d5G9()).set_Location(new Point(13, 67));
		((Control)d5G9()).set_Name("PaidPartially");
		((Control)d5G9()).set_Size(new Size(111, 21));
		((Control)d5G9()).set_TabIndex(24);
		d5G9().set_TabStop(true);
		((ButtonBase)d5G9()).set_Text("Paid Partially");
		((ButtonBase)d5G9()).set_UseVisualStyleBackColor(true);
		((ButtonBase)f6X0()).set_AutoSize(true);
		((Control)f6X0()).set_ForeColor(SystemColors.ControlText);
		((Control)f6X0()).set_Location(new Point(13, 18));
		((Control)f6X0()).set_Name("PaidFully");
		((Control)f6X0()).set_Size(new Size(90, 21));
		((Control)f6X0()).set_TabIndex(23);
		f6X0().set_TabStop(true);
		((ButtonBase)f6X0()).set_Text("Paid Fully");
		((ButtonBase)f6X0()).set_UseVisualStyleBackColor(true);
		((Control)Rf39()).set_Location(new Point(248, 78));
		((Control)Rf39()).set_Name("Button1");
		((Control)Rf39()).set_Size(new Size(155, 48));
		((Control)Rf39()).set_TabIndex(1);
		((ButtonBase)Rf39()).set_Text("View Details");
		((ButtonBase)Rf39()).set_UseVisualStyleBackColor(true);
		((Control)Ym9o()).set_Location(new Point(442, 78));
		((Control)Ym9o()).set_Name("Button2");
		((Control)Ym9o()).set_Size(new Size(155, 48));
		((Control)Ym9o()).set_TabIndex(2);
		((ButtonBase)Ym9o()).set_Text("Back");
		((ButtonBase)Ym9o()).set_UseVisualStyleBackColor(true);
		Ls14().set_DataMember("RentDetails");
		w6QA().set_AutoGenerateColumns(false);
		w6QA().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		w6QA().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[8]
		{
			(DataGridViewColumn)w9EZ(),
			(DataGridViewColumn)d7Y8(),
			(DataGridViewColumn)t8B9(),
			(DataGridViewColumn)Mo58(),
			(DataGridViewColumn)o0BR(),
			(DataGridViewColumn)m9PA(),
			(DataGridViewColumn)Wg08(),
			(DataGridViewColumn)Pf25()
		});
		w6QA().set_DataSource((object)x5H8());
		((Control)w6QA()).set_Location(new Point(25, 190));
		((Control)w6QA()).set_Name("DataGridView1");
		w6QA().set_RowHeadersWidth(51);
		w6QA().get_RowTemplate().set_Height(24);
		((Control)w6QA()).set_Size(new Size(1053, 176));
		((Control)w6QA()).set_TabIndex(3);
		Tw15().set_DataMember("houseentry");
		((DataGridViewColumn)w9EZ()).set_DataPropertyName("Phone");
		((DataGridViewColumn)w9EZ()).set_HeaderText("Phone");
		((DataGridViewColumn)w9EZ()).set_MinimumWidth(6);
		((DataGridViewColumn)w9EZ()).set_Name("PhoneDataGridViewTextBoxColumn");
		((DataGridViewColumn)w9EZ()).set_Width(125);
		((DataGridViewColumn)d7Y8()).set_DataPropertyName("TenantID");
		((DataGridViewColumn)d7Y8()).set_HeaderText("TenantID");
		((DataGridViewColumn)d7Y8()).set_MinimumWidth(6);
		((DataGridViewColumn)d7Y8()).set_Name("TenantIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)d7Y8()).set_Width(125);
		((DataGridViewColumn)t8B9()).set_DataPropertyName("NoofPersoninFamily");
		((DataGridViewColumn)t8B9()).set_HeaderText("NoofPersoninFamily");
		((DataGridViewColumn)t8B9()).set_MinimumWidth(6);
		((DataGridViewColumn)t8B9()).set_Name("NoofPersoninFamilyDataGridViewTextBoxColumn");
		((DataGridViewColumn)t8B9()).set_Width(125);
		((DataGridViewColumn)Mo58()).set_DataPropertyName("BlockNo");
		((DataGridViewColumn)Mo58()).set_HeaderText("BlockNo");
		((DataGridViewColumn)Mo58()).set_MinimumWidth(6);
		((DataGridViewColumn)Mo58()).set_Name("BlockNoDataGridViewTextBoxColumn");
		((DataGridViewColumn)Mo58()).set_Width(125);
		((DataGridViewColumn)o0BR()).set_DataPropertyName("Flatno");
		((DataGridViewColumn)o0BR()).set_HeaderText("Flatno");
		((DataGridViewColumn)o0BR()).set_MinimumWidth(6);
		((DataGridViewColumn)o0BR()).set_Name("FlatnoDataGridViewTextBoxColumn");
		((DataGridViewColumn)o0BR()).set_Width(125);
		((DataGridViewColumn)m9PA()).set_DataPropertyName("Flattype");
		((DataGridViewColumn)m9PA()).set_HeaderText("Flattype");
		((DataGridViewColumn)m9PA()).set_MinimumWidth(6);
		((DataGridViewColumn)m9PA()).set_Name("FlattypeDataGridViewTextBoxColumn");
		((DataGridViewColumn)m9PA()).set_Width(125);
		((DataGridViewColumn)Wg08()).set_DataPropertyName("RentAmount");
		((DataGridViewColumn)Wg08()).set_HeaderText("RentAmount");
		((DataGridViewColumn)Wg08()).set_MinimumWidth(6);
		((DataGridViewColumn)Wg08()).set_Name("RentAmountDataGridViewTextBoxColumn");
		((DataGridViewColumn)Wg08()).set_Width(125);
		((DataGridViewColumn)Pf25()).set_DataPropertyName("PaymentStatus");
		((DataGridViewColumn)Pf25()).set_HeaderText("PaymentStatus");
		((DataGridViewColumn)Pf25()).set_MinimumWidth(6);
		((DataGridViewColumn)Pf25()).set_Name("PaymentStatusDataGridViewTextBoxColumn");
		((DataGridViewColumn)Pf25()).set_Width(125);
		x5H8().set_DataMember("houseentry");
		g3GZ().set_AutoSize(true);
		((Control)g3GZ()).set_Font(new Font("Microsoft YaHei", 28.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)g3GZ()).set_Location(new Point(347, 9));
		((Control)g3GZ()).set_Name("Label1");
		((Control)g3GZ()).set_Size(new Size(445, 64));
		((Control)g3GZ()).set_TabIndex(4);
		g3GZ().set_Text("Rent Information");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1108, 537));
		((Control)this).get_Controls().Add((Control)(object)g3GZ());
		((Control)this).get_Controls().Add((Control)(object)w6QA());
		((Control)this).get_Controls().Add((Control)(object)Ym9o());
		((Control)this).get_Controls().Add((Control)(object)Rf39());
		((Control)this).get_Controls().Add((Control)(object)k6P3());
		((Control)this).set_Name("Rent_Info");
		((Form)this).set_Text("Rent_Info");
		((Control)k6P3()).ResumeLayout(false);
		((Control)k6P3()).PerformLayout();
		((ISupportInitialize)Ls14()).EndInit();
		((ISupportInitialize)w6QA()).EndInit();
		((ISupportInitialize)Tw15()).EndInit();
		((ISupportInitialize)x5H8()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Panel k6P3()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t9XM(Panel d0M1)
	{
		_Panel1 = d0M1;
	}

	[SpecialName]
	internal virtual Button Rf39()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wm57(Button Ta78)
	{
		Button val = (Q = Ta78);
	}

	[SpecialName]
	internal virtual Button Ym9o()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r9CR(Button z5SK)
	{
		EventHandler eventHandler = Gn3c;
		Button h = H;
		if (h != null)
		{
			((Control)h).remove_Click(eventHandler);
		}
		Button val = (H = z5SK);
		h = H;
		if (h != null)
		{
			((Control)h).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual RadioButton f6X0()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x5PB(RadioButton Yf42)
	{
		RadioButton val = (k = Yf42);
	}

	[SpecialName]
	internal virtual RadioButton d5G9()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3EB(RadioButton c9D4)
	{
		RadioButton val = (s = c9D4);
	}

	[SpecialName]
	internal virtual BindingSource Ls14()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qa08(BindingSource m6E4)
	{
		BindingSource val = (P = m6E4);
	}

	[SpecialName]
	internal virtual DataGridView w6QA()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f7R2(DataGridView k6J5)
	{
		DataGridView val = (j = k6J5);
	}

	[SpecialName]
	internal virtual BindingSource Tw15()
	{
		return _HouseentryBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8BK(BindingSource t9TN)
	{
		_HouseentryBindingSource = t9TN;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn w9EZ()
	{
		return _PhoneDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6FH(DataGridViewTextBoxColumn b6R5)
	{
		_PhoneDataGridViewTextBoxColumn = b6R5;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn d7Y8()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Te61(DataGridViewTextBoxColumn r7ST)
	{
		DataGridViewTextBoxColumn val = (N = r7ST);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn t8B9()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tg3p(DataGridViewTextBoxColumn Py5m)
	{
		DataGridViewTextBoxColumn val = (e = Py5m);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Mo58()
	{
		return _BlockNoDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1E3(DataGridViewTextBoxColumn Nz93)
	{
		_BlockNoDataGridViewTextBoxColumn = Nz93;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn o0BR()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hd5i(DataGridViewTextBoxColumn He81)
	{
		DataGridViewTextBoxColumn val = (F = He81);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn m9PA()
	{
		return _FlattypeDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void As4y(DataGridViewTextBoxColumn Fp70)
	{
		_FlattypeDataGridViewTextBoxColumn = Fp70;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Wg08()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d0FA(DataGridViewTextBoxColumn f8FJ)
	{
		DataGridViewTextBoxColumn val = (Y = f8FJ);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Pf25()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bp13(DataGridViewTextBoxColumn Nn6j)
	{
		DataGridViewTextBoxColumn val = (L = Nn6j);
	}

	[SpecialName]
	internal virtual BindingSource x5H8()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nm8x(BindingSource o2AH)
	{
		BindingSource val = (W = o2AH);
	}

	[SpecialName]
	internal virtual Label g3GZ()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4RH(Label x5NL)
	{
		Label val = (v = x5NL);
	}

	private void Me10(object sender, EventArgs e)
	{
	}

	private void Gn3c(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Gj9.Forms.Xp5()).Show();
	}

	[STAThread]
	public static void z5N1()
	{
		int try0000_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				}
				while (!Fo8.Mo4(2) || !Mq9.Lr3())
				{
				}
				j5N.Ko0(1);
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				try0000_dispatch = 15;
			}
		}
	}

	static g2BD()
	{
		U = new char[5292];
		char[] array = new char[8];
		array[5] = 'ຑ';
		array[7] = '㏒';
		array[3] = '㜰';
		array[4] = '\u0b98';
		array[0] = 'ẞ';
		array[1] = 'ṣ';
		array[2] = '㎥';
		array[6] = 'ᆿ';
		i = new string[322];
		n = array;
	}
}
