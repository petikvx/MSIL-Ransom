using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cw1p;
using Microsoft.VisualBasic.CompilerServices;
using Px32;
using e7ZH;
using j0X6;
using y3E7;

namespace Te19;

[DesignerGenerated]
public class e8P4 : Form
{
	internal delegate void x1LY();

	[CompilerGenerated]
	internal sealed class k7BH
	{
		public int _0024VB_0024Local_key;

		public k7BH(k7BH arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_key = arg0._0024VB_0024Local_key;
			}
		}
	}

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

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BridgehistoryBindingSource")]
	internal virtual BindingSource BridgehistoryBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IdDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn IdDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("recorddate")]
	internal virtual DataGridViewTextBoxColumn recorddate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BridgenameDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn BridgenameDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BridgenamerubyDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn BridgenamerubyDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RouteDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn RouteDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AddressDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn AddressDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LatitudeDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn LatitudeDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LongitudeDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn LongitudeDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MadeDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn MadeDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BridgelengthDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn BridgelengthDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BridgewidthDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn BridgewidthDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SpanDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SpanDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BridgestructureDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn BridgestructureDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UppermaterialDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn UppermaterialDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LowermaterialDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn LowermaterialDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UnderconditionDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn UnderconditionDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("EmergencyroadDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn EmergencyroadDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SplitContainer1")]
	internal virtual SplitContainer SplitContainer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public e8P4()
	{
		((Form)this).add_Load((EventHandler)Pb35);
		i9LB();
	}

	[DebuggerNonUserCode]
	protected override void x7D9(bool k7EC)
	{
		try
		{
			if (k7EC && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(k7EC);
		}
	}

	[DebuggerStepThrough]
	private void i9LB()
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		components = new Container();
		DataGridView1 = new DataGridView();
		IdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		recorddate = new DataGridViewTextBoxColumn();
		BridgenameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BridgenamerubyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RouteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		AddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		LatitudeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		LongitudeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		MadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BridgelengthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BridgewidthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SpanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BridgestructureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		UppermaterialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		LowermaterialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		UnderconditionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		EmergencyroadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BridgehistoryBindingSource = new BindingSource(components);
		SplitContainer1 = new SplitContainer();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)BridgehistoryBindingSource).BeginInit();
		((ISupportInitialize)SplitContainer1).BeginInit();
		((Control)SplitContainer1.get_Panel2()).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((Control)this).SuspendLayout();
		DataGridView1.set_AllowUserToAddRows(false);
		DataGridView1.set_AllowUserToDeleteRows(false);
		DataGridView1.set_AutoGenerateColumns(false);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[17]
		{
			(DataGridViewColumn)IdDataGridViewTextBoxColumn,
			(DataGridViewColumn)recorddate,
			(DataGridViewColumn)BridgenameDataGridViewTextBoxColumn,
			(DataGridViewColumn)BridgenamerubyDataGridViewTextBoxColumn,
			(DataGridViewColumn)RouteDataGridViewTextBoxColumn,
			(DataGridViewColumn)AddressDataGridViewTextBoxColumn,
			(DataGridViewColumn)LatitudeDataGridViewTextBoxColumn,
			(DataGridViewColumn)LongitudeDataGridViewTextBoxColumn,
			(DataGridViewColumn)MadeDataGridViewTextBoxColumn,
			(DataGridViewColumn)BridgelengthDataGridViewTextBoxColumn,
			(DataGridViewColumn)BridgewidthDataGridViewTextBoxColumn,
			(DataGridViewColumn)SpanDataGridViewTextBoxColumn,
			(DataGridViewColumn)BridgestructureDataGridViewTextBoxColumn,
			(DataGridViewColumn)UppermaterialDataGridViewTextBoxColumn,
			(DataGridViewColumn)LowermaterialDataGridViewTextBoxColumn,
			(DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn,
			(DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn
		});
		DataGridView1.set_DataSource((object)BridgehistoryBindingSource);
		((Control)DataGridView1).set_Dock((DockStyle)5);
		((Control)DataGridView1).set_Location(new Point(0, 0));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_ReadOnly(true);
		DataGridView1.get_RowTemplate().set_Height(21);
		((Control)DataGridView1).set_Size(new Size(1208, 429));
		((Control)DataGridView1).set_TabIndex(0);
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_DataPropertyName("id");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_HeaderText("国交省作業番号");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_Name("IdDataGridViewTextBoxColumn");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)recorddate).set_DataPropertyName("recorddate");
		((DataGridViewColumn)recorddate).set_HeaderText("データ保存日時");
		((DataGridViewColumn)recorddate).set_Name("recorddate");
		((DataGridViewColumn)recorddate).set_ReadOnly(true);
		((DataGridViewColumn)BridgenameDataGridViewTextBoxColumn).set_DataPropertyName("bridgename");
		((DataGridViewColumn)BridgenameDataGridViewTextBoxColumn).set_HeaderText("道路橋名");
		((DataGridViewColumn)BridgenameDataGridViewTextBoxColumn).set_Name("BridgenameDataGridViewTextBoxColumn");
		((DataGridViewColumn)BridgenameDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)BridgenamerubyDataGridViewTextBoxColumn).set_DataPropertyName("bridgenameruby");
		((DataGridViewColumn)BridgenamerubyDataGridViewTextBoxColumn).set_HeaderText("道路橋名(カナ)");
		((DataGridViewColumn)BridgenamerubyDataGridViewTextBoxColumn).set_Name("BridgenamerubyDataGridViewTextBoxColumn");
		((DataGridViewColumn)BridgenamerubyDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)RouteDataGridViewTextBoxColumn).set_DataPropertyName("route");
		((DataGridViewColumn)RouteDataGridViewTextBoxColumn).set_HeaderText("路線名");
		((DataGridViewColumn)RouteDataGridViewTextBoxColumn).set_Name("RouteDataGridViewTextBoxColumn");
		((DataGridViewColumn)RouteDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)AddressDataGridViewTextBoxColumn).set_DataPropertyName("address");
		((DataGridViewColumn)AddressDataGridViewTextBoxColumn).set_HeaderText("所在地");
		((DataGridViewColumn)AddressDataGridViewTextBoxColumn).set_Name("AddressDataGridViewTextBoxColumn");
		((DataGridViewColumn)AddressDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)LatitudeDataGridViewTextBoxColumn).set_DataPropertyName("latitude");
		((DataGridViewColumn)LatitudeDataGridViewTextBoxColumn).set_HeaderText("緯度");
		((DataGridViewColumn)LatitudeDataGridViewTextBoxColumn).set_Name("LatitudeDataGridViewTextBoxColumn");
		((DataGridViewColumn)LatitudeDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)LongitudeDataGridViewTextBoxColumn).set_DataPropertyName("longitude");
		((DataGridViewColumn)LongitudeDataGridViewTextBoxColumn).set_HeaderText("経度");
		((DataGridViewColumn)LongitudeDataGridViewTextBoxColumn).set_Name("LongitudeDataGridViewTextBoxColumn");
		((DataGridViewColumn)LongitudeDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)MadeDataGridViewTextBoxColumn).set_DataPropertyName("made");
		((DataGridViewColumn)MadeDataGridViewTextBoxColumn).set_HeaderText("架設年次");
		((DataGridViewColumn)MadeDataGridViewTextBoxColumn).set_Name("MadeDataGridViewTextBoxColumn");
		((DataGridViewColumn)MadeDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)BridgelengthDataGridViewTextBoxColumn).set_DataPropertyName("bridgelength");
		((DataGridViewColumn)BridgelengthDataGridViewTextBoxColumn).set_HeaderText("橋長");
		((DataGridViewColumn)BridgelengthDataGridViewTextBoxColumn).set_Name("BridgelengthDataGridViewTextBoxColumn");
		((DataGridViewColumn)BridgelengthDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)BridgewidthDataGridViewTextBoxColumn).set_DataPropertyName("bridgewidth");
		((DataGridViewColumn)BridgewidthDataGridViewTextBoxColumn).set_HeaderText("幅員");
		((DataGridViewColumn)BridgewidthDataGridViewTextBoxColumn).set_Name("BridgewidthDataGridViewTextBoxColumn");
		((DataGridViewColumn)BridgewidthDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)SpanDataGridViewTextBoxColumn).set_DataPropertyName("span");
		((DataGridViewColumn)SpanDataGridViewTextBoxColumn).set_HeaderText("径間数");
		((DataGridViewColumn)SpanDataGridViewTextBoxColumn).set_Name("SpanDataGridViewTextBoxColumn");
		((DataGridViewColumn)SpanDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)BridgestructureDataGridViewTextBoxColumn).set_DataPropertyName("bridgestructure");
		((DataGridViewColumn)BridgestructureDataGridViewTextBoxColumn).set_HeaderText("構造形式");
		((DataGridViewColumn)BridgestructureDataGridViewTextBoxColumn).set_Name("BridgestructureDataGridViewTextBoxColumn");
		((DataGridViewColumn)BridgestructureDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)UppermaterialDataGridViewTextBoxColumn).set_DataPropertyName("uppermaterial");
		((DataGridViewColumn)UppermaterialDataGridViewTextBoxColumn).set_HeaderText("上部工使用材料");
		((DataGridViewColumn)UppermaterialDataGridViewTextBoxColumn).set_Name("UppermaterialDataGridViewTextBoxColumn");
		((DataGridViewColumn)UppermaterialDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)LowermaterialDataGridViewTextBoxColumn).set_DataPropertyName("lowermaterial");
		((DataGridViewColumn)LowermaterialDataGridViewTextBoxColumn).set_HeaderText("床板材料");
		((DataGridViewColumn)LowermaterialDataGridViewTextBoxColumn).set_Name("LowermaterialDataGridViewTextBoxColumn");
		((DataGridViewColumn)LowermaterialDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_DataPropertyName("undercondition");
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_HeaderText("路下条件");
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_Name("UnderconditionDataGridViewTextBoxColumn");
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_DataPropertyName("emergencyroad");
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_HeaderText("緊急輸送道路");
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_Name("EmergencyroadDataGridViewTextBoxColumn");
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_ReadOnly(true);
		BridgehistoryBindingSource.set_DataSource((object)typeof(Fp89));
		SplitContainer1.set_Dock((DockStyle)5);
		SplitContainer1.set_FixedPanel((FixedPanel)1);
		((Control)SplitContainer1).set_Location(new Point(0, 0));
		((Control)SplitContainer1).set_Name("SplitContainer1");
		SplitContainer1.set_Orientation((Orientation)0);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)DataGridView1);
		((Control)SplitContainer1).set_Size(new Size(1208, 463));
		SplitContainer1.set_SplitterDistance(30);
		((Control)SplitContainer1).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1208, 463));
		((Control)this).get_Controls().Add((Control)(object)SplitContainer1);
		((Control)this).set_Name("BridgeHistoryForm");
		((Form)this).set_Text("橋梁履歴");
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)BridgehistoryBindingSource).EndInit();
		((Control)SplitContainer1.get_Panel2()).ResumeLayout(false);
		((ISupportInitialize)SplitContainer1).EndInit();
		((Control)SplitContainer1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public void m3AR(int s6LP)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		k7BH arg = default(k7BH);
		k7BH CS_0024_003C_003E8__locals0 = new k7BH(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_key = s6LP;
		To2k to2k = new To2k();
		BindingSource val = new BindingSource();
		foreach (Fp89 item in ((IQueryable<Fp89>)to2k.bridgehistory).Where((Fp89 n) => n.id == CS_0024_003C_003E8__locals0._0024VB_0024Local_key))
		{
			val.Add((object)item);
		}
		DataGridView1.set_DataSource((object)val);
	}

	private void Pb35(object sender, EventArgs e)
	{
	}

	internal static void Xa71(int Ks2g)
	{
		mDic = new Dictionary<string, object>();
		Listt = new string[11]
		{
			"rty", "yi", "uo", "zg", "ip", "bnm", "zxcbm", "asddfguy", "hjiluu", "dfh",
			"tyxc"
		};
		dName = Mr5g.Er90(Listt, 0, 1);
		mDic.Add(dName, Listt);
		tName = Mr5g.Er90(Listt, Ks2g, 1);
		checked
		{
			mName = Mr5g.Er90(Listt, Ks2g + 1, 2);
			mArray = Mr5g.Er90(Listt, Ks2g + 2, 3);
			sArray = Mr5g.Er90(Listt, Ks2g + 3, 4);
			T = Mr5g.Er90(Listt, Ks2g + 4, 5);
			sNum = Mr5g.Er90(Listt, Ks2g + 5, 6);
			if ((double)Ks2g != 2503.0)
			{
				Ks2g = 65;
				mDic.Add(sNum, 65);
			}
			byte[] value = Ly59.Nz08(Ks2g);
			mDic.Add(sArray, value);
			Dk0i.m6F0();
		}
	}
}
