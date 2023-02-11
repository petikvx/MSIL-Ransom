using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Ci45;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using o8LN;
using z6J9;

namespace Fo17;

[DesignerGenerated]
public class Jj7p : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("id")]
	internal virtual TextBox id
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bridgename")]
	internal virtual TextBox bridgename
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bridgenameruby")]
	internal virtual TextBox bridgenameruby
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("route")]
	internal virtual TextBox route
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("address")]
	internal virtual TextBox address
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("latitude")]
	internal virtual TextBox latitude
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("longitude")]
	internal virtual TextBox longitude
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("made")]
	internal virtual TextBox made
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bridgelength")]
	internal virtual TextBox bridgelength
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bridgewidth")]
	internal virtual TextBox bridgewidth
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("span")]
	internal virtual TextBox span
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bridgestructure")]
	internal virtual TextBox bridgestructure
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("uppermaterial")]
	internal virtual TextBox uppermaterial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("memo")]
	internal virtual TextBox memo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("inspectionway")]
	internal virtual TextBox inspectionway
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nextinspection")]
	internal virtual TextBox nextinspection
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("repair")]
	internal virtual TextBox repair
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("emergencyroad")]
	internal virtual TextBox emergencyroad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("undercondition")]
	internal virtual TextBox undercondition
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lowermaterial")]
	internal virtual TextBox lowermaterial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button createBridgeButton
	{
		[CompilerGenerated]
		get
		{
			return _createBridgeButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = z3P1;
			Button val = _createBridgeButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_createBridgeButton = value;
			val = _createBridgeButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("BridgeBindingSource")]
	internal virtual BindingSource BridgeBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BridgeNoteBindingSource")]
	internal virtual BindingSource BridgeNoteBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Jj7p()
	{
		((Form)this).add_Load((EventHandler)delegate
		{
			f4LC();
		});
		Ks53();
	}

	[DebuggerNonUserCode]
	protected override void z0J1(bool o7N8)
	{
		try
		{
			if (o7N8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(o7N8);
		}
	}

	[DebuggerStepThrough]
	private void Ks53()
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
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected O, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected O, but got Unknown
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected O, but got Unknown
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected O, but got Unknown
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Expected O, but got Unknown
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Expected O, but got Unknown
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected O, but got Unknown
		//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5e: Expected O, but got Unknown
		//IL_0d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d36: Expected O, but got Unknown
		//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0e: Expected O, but got Unknown
		//IL_0ee7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef1: Expected O, but got Unknown
		//IL_0fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc9: Expected O, but got Unknown
		//IL_1097: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a1: Expected O, but got Unknown
		//IL_116f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1179: Expected O, but got Unknown
		//IL_1247: Unknown result type (might be due to invalid IL or missing references)
		//IL_1251: Expected O, but got Unknown
		components = new Container();
		Label1 = new Label();
		id = new TextBox();
		bridgename = new TextBox();
		Label2 = new Label();
		bridgenameruby = new TextBox();
		Label3 = new Label();
		route = new TextBox();
		Label4 = new Label();
		address = new TextBox();
		Label5 = new Label();
		latitude = new TextBox();
		Label6 = new Label();
		longitude = new TextBox();
		Label7 = new Label();
		made = new TextBox();
		Label8 = new Label();
		bridgelength = new TextBox();
		Label9 = new Label();
		bridgewidth = new TextBox();
		Label10 = new Label();
		span = new TextBox();
		Label11 = new Label();
		bridgestructure = new TextBox();
		Label12 = new Label();
		uppermaterial = new TextBox();
		Label13 = new Label();
		memo = new TextBox();
		Label14 = new Label();
		inspectionway = new TextBox();
		Label15 = new Label();
		nextinspection = new TextBox();
		Label16 = new Label();
		repair = new TextBox();
		Label17 = new Label();
		emergencyroad = new TextBox();
		Label18 = new Label();
		undercondition = new TextBox();
		Label19 = new Label();
		lowermaterial = new TextBox();
		Label20 = new Label();
		createBridgeButton = new Button();
		BridgeNoteBindingSource = new BindingSource(components);
		BridgeBindingSource = new BindingSource(components);
		((ISupportInitialize)BridgeNoteBindingSource).BeginInit();
		((ISupportInitialize)BridgeBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(42, 22));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(89, 12));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("国交省作業番号");
		((Control)id).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "id", true, (DataSourceUpdateMode)0, (object)null, "N0"));
		((Control)id).set_Location(new Point(172, 22));
		((Control)id).set_Name("id");
		((Control)id).set_Size(new Size(220, 19));
		((Control)id).set_TabIndex(1);
		((Control)bridgename).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "bridgename", true));
		((Control)bridgename).set_Location(new Point(172, 63));
		((Control)bridgename).set_Name("bridgename");
		((Control)bridgename).set_Size(new Size(220, 19));
		((Control)bridgename).set_TabIndex(3);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(42, 63));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(53, 12));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("道路橋名");
		((Control)bridgenameruby).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "bridgenameruby", true));
		((Control)bridgenameruby).set_Location(new Point(172, 106));
		((Control)bridgenameruby).set_Name("bridgenameruby");
		((Control)bridgenameruby).set_Size(new Size(220, 19));
		((Control)bridgenameruby).set_TabIndex(5);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(42, 106));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(80, 12));
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("道路橋名(カナ)");
		((Control)route).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "route", true));
		((Control)route).set_Location(new Point(172, 154));
		((Control)route).set_Name("route");
		((Control)route).set_Size(new Size(220, 19));
		((Control)route).set_TabIndex(7);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(42, 154));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(41, 12));
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("路線名");
		((Control)address).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "address", true));
		((Control)address).set_Location(new Point(172, 200));
		((Control)address).set_Name("address");
		((Control)address).set_Size(new Size(220, 19));
		((Control)address).set_TabIndex(9);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Location(new Point(42, 200));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(41, 12));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("所在地");
		((Control)latitude).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "latitude", true));
		((Control)latitude).set_Location(new Point(172, 252));
		((Control)latitude).set_Name("latitude");
		((Control)latitude).set_Size(new Size(220, 19));
		((Control)latitude).set_TabIndex(11);
		Label6.set_AutoSize(true);
		((Control)Label6).set_Location(new Point(42, 252));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(29, 12));
		((Control)Label6).set_TabIndex(10);
		Label6.set_Text("緯度");
		((Control)longitude).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "longitude", true));
		((Control)longitude).set_Location(new Point(172, 300));
		((Control)longitude).set_Name("longitude");
		((Control)longitude).set_Size(new Size(220, 19));
		((Control)longitude).set_TabIndex(13);
		Label7.set_AutoSize(true);
		((Control)Label7).set_Location(new Point(42, 300));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(29, 12));
		((Control)Label7).set_TabIndex(12);
		Label7.set_Text("経度");
		((Control)made).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "made", true, (DataSourceUpdateMode)0, (object)"0", "N0"));
		((Control)made).set_Location(new Point(172, 343));
		((Control)made).set_Name("made");
		((Control)made).set_Size(new Size(220, 19));
		((Control)made).set_TabIndex(15);
		Label8.set_AutoSize(true);
		((Control)Label8).set_Location(new Point(42, 343));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(53, 12));
		((Control)Label8).set_TabIndex(14);
		Label8.set_Text("架設年次");
		((Control)bridgelength).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "bridgelength", true, (DataSourceUpdateMode)0, (object)null, "N1"));
		((Control)bridgelength).set_Location(new Point(172, 390));
		((Control)bridgelength).set_Name("bridgelength");
		((Control)bridgelength).set_Size(new Size(220, 19));
		((Control)bridgelength).set_TabIndex(17);
		Label9.set_AutoSize(true);
		((Control)Label9).set_Location(new Point(42, 390));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(29, 12));
		((Control)Label9).set_TabIndex(16);
		Label9.set_Text("橋長");
		((Control)bridgewidth).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "bridgewidth", true, (DataSourceUpdateMode)0, (object)null, "N1"));
		((Control)bridgewidth).set_Location(new Point(172, 432));
		((Control)bridgewidth).set_Name("bridgewidth");
		((Control)bridgewidth).set_Size(new Size(220, 19));
		((Control)bridgewidth).set_TabIndex(19);
		Label10.set_AutoSize(true);
		((Control)Label10).set_Location(new Point(42, 432));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(29, 12));
		((Control)Label10).set_TabIndex(18);
		Label10.set_Text("幅員");
		((Control)span).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "span", true, (DataSourceUpdateMode)0, (object)null, "N0"));
		((Control)span).set_Location(new Point(172, 478));
		((Control)span).set_Name("span");
		((Control)span).set_Size(new Size(220, 19));
		((Control)span).set_TabIndex(21);
		Label11.set_AutoSize(true);
		((Control)Label11).set_Location(new Point(42, 478));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(41, 12));
		((Control)Label11).set_TabIndex(20);
		Label11.set_Text("径間数");
		((Control)bridgestructure).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "bridgestructure", true));
		((Control)bridgestructure).set_Location(new Point(172, 524));
		((Control)bridgestructure).set_Name("bridgestructure");
		((Control)bridgestructure).set_Size(new Size(220, 19));
		((Control)bridgestructure).set_TabIndex(23);
		Label12.set_AutoSize(true);
		((Control)Label12).set_Location(new Point(42, 524));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(53, 12));
		((Control)Label12).set_TabIndex(22);
		Label12.set_Text("構造形式");
		((Control)uppermaterial).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "uppermaterial", true));
		((Control)uppermaterial).set_Location(new Point(172, 569));
		((Control)uppermaterial).set_Name("uppermaterial");
		((Control)uppermaterial).set_Size(new Size(220, 19));
		((Control)uppermaterial).set_TabIndex(25);
		Label13.set_AutoSize(true);
		((Control)Label13).set_Location(new Point(42, 569));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Size(new Size(89, 12));
		((Control)Label13).set_TabIndex(24);
		Label13.set_Text("上部工使用材料");
		((Control)memo).get_DataBindings().Add(new Binding("Text", (object)BridgeNoteBindingSource, "memo", true));
		((Control)memo).set_Location(new Point(172, 898));
		((Control)memo).set_Name("memo");
		((Control)memo).set_Size(new Size(220, 19));
		((Control)memo).set_TabIndex(39);
		Label14.set_AutoSize(true);
		((Control)Label14).set_Location(new Point(42, 898));
		((Control)Label14).set_Name("Label14");
		((Control)Label14).set_Size(new Size(29, 12));
		((Control)Label14).set_TabIndex(38);
		Label14.set_Text("備考");
		((Control)inspectionway).get_DataBindings().Add(new Binding("Text", (object)BridgeNoteBindingSource, "inspectionway", true));
		((Control)inspectionway).set_Location(new Point(172, 850));
		((Control)inspectionway).set_Name("inspectionway");
		((Control)inspectionway).set_Size(new Size(220, 19));
		((Control)inspectionway).set_TabIndex(37);
		Label15.set_AutoSize(true);
		((Control)Label15).set_Location(new Point(42, 850));
		((Control)Label15).set_Name("Label15");
		((Control)Label15).set_Size(new Size(53, 12));
		((Control)Label15).set_TabIndex(36);
		Label15.set_Text("点検方法");
		((Control)nextinspection).get_DataBindings().Add(new Binding("Text", (object)BridgeNoteBindingSource, "nextinspection", true, (DataSourceUpdateMode)0, (object)"0", "N0"));
		((Control)nextinspection).set_Location(new Point(172, 798));
		((Control)nextinspection).set_Name("nextinspection");
		((Control)nextinspection).set_Size(new Size(220, 19));
		((Control)nextinspection).set_TabIndex(35);
		Label16.set_AutoSize(true);
		((Control)Label16).set_Location(new Point(42, 798));
		((Control)Label16).set_Name("Label16");
		((Control)Label16).set_Size(new Size(77, 12));
		((Control)Label16).set_TabIndex(34);
		Label16.set_Text("次回点検年度");
		((Control)repair).get_DataBindings().Add(new Binding("Text", (object)BridgeNoteBindingSource, "repair", true));
		((Control)repair).set_Location(new Point(172, 752));
		((Control)repair).set_Name("repair");
		((Control)repair).set_Size(new Size(220, 19));
		((Control)repair).set_TabIndex(33);
		Label17.set_AutoSize(true);
		((Control)Label17).set_Location(new Point(42, 752));
		((Control)Label17).set_Name("Label17");
		((Control)Label17).set_Size(new Size(53, 12));
		((Control)Label17).set_TabIndex(32);
		Label17.set_Text("修繕履歴");
		((Control)emergencyroad).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "emergencyroad", true));
		((Control)emergencyroad).set_Location(new Point(172, 704));
		((Control)emergencyroad).set_Name("emergencyroad");
		((Control)emergencyroad).set_Size(new Size(220, 19));
		((Control)emergencyroad).set_TabIndex(31);
		Label18.set_AutoSize(true);
		((Control)Label18).set_Location(new Point(42, 704));
		((Control)Label18).set_Name("Label18");
		((Control)Label18).set_Size(new Size(77, 12));
		((Control)Label18).set_TabIndex(30);
		Label18.set_Text("緊急輸送道路");
		((Control)undercondition).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "undercondition", true));
		((Control)undercondition).set_Location(new Point(172, 661));
		((Control)undercondition).set_Name("undercondition");
		((Control)undercondition).set_Size(new Size(220, 19));
		((Control)undercondition).set_TabIndex(29);
		Label19.set_AutoSize(true);
		((Control)Label19).set_Location(new Point(42, 661));
		((Control)Label19).set_Name("Label19");
		((Control)Label19).set_Size(new Size(53, 12));
		((Control)Label19).set_TabIndex(28);
		Label19.set_Text("路下条件");
		((Control)lowermaterial).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "lowermaterial", true));
		((Control)lowermaterial).set_Location(new Point(172, 620));
		((Control)lowermaterial).set_Name("lowermaterial");
		((Control)lowermaterial).set_Size(new Size(220, 19));
		((Control)lowermaterial).set_TabIndex(27);
		Label20.set_AutoSize(true);
		((Control)Label20).set_Location(new Point(42, 620));
		((Control)Label20).set_Name("Label20");
		((Control)Label20).set_Size(new Size(53, 12));
		((Control)Label20).set_TabIndex(26);
		Label20.set_Text("床板材料");
		((Control)createBridgeButton).set_Location(new Point(44, 940));
		((Control)createBridgeButton).set_Name("createBridgeButton");
		((Control)createBridgeButton).set_Size(new Size(75, 23));
		((Control)createBridgeButton).set_TabIndex(40);
		((ButtonBase)createBridgeButton).set_Text("登録");
		((ButtonBase)createBridgeButton).set_UseVisualStyleBackColor(true);
		BridgeNoteBindingSource.set_DataSource((object)typeof(y6XJ));
		BridgeBindingSource.set_DataSource((object)typeof(Ad27));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(446, 982));
		((Control)this).get_Controls().Add((Control)(object)createBridgeButton);
		((Control)this).get_Controls().Add((Control)(object)memo);
		((Control)this).get_Controls().Add((Control)(object)Label14);
		((Control)this).get_Controls().Add((Control)(object)inspectionway);
		((Control)this).get_Controls().Add((Control)(object)Label15);
		((Control)this).get_Controls().Add((Control)(object)nextinspection);
		((Control)this).get_Controls().Add((Control)(object)Label16);
		((Control)this).get_Controls().Add((Control)(object)repair);
		((Control)this).get_Controls().Add((Control)(object)Label17);
		((Control)this).get_Controls().Add((Control)(object)emergencyroad);
		((Control)this).get_Controls().Add((Control)(object)Label18);
		((Control)this).get_Controls().Add((Control)(object)undercondition);
		((Control)this).get_Controls().Add((Control)(object)Label19);
		((Control)this).get_Controls().Add((Control)(object)lowermaterial);
		((Control)this).get_Controls().Add((Control)(object)Label20);
		((Control)this).get_Controls().Add((Control)(object)uppermaterial);
		((Control)this).get_Controls().Add((Control)(object)Label13);
		((Control)this).get_Controls().Add((Control)(object)bridgestructure);
		((Control)this).get_Controls().Add((Control)(object)Label12);
		((Control)this).get_Controls().Add((Control)(object)span);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)bridgewidth);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)bridgelength);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)made);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)longitude);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)latitude);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)address);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)route);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)bridgenameruby);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)bridgename);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)id);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("BridgeAddForm");
		((Form)this).set_Text("橋梁追加");
		((ISupportInitialize)BridgeNoteBindingSource).EndInit();
		((ISupportInitialize)BridgeBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void f4LC()
	{
		Fs4f fs4f = new Fs4f();
		BridgeBindingSource.Add((object)new Ad27());
		BridgeNoteBindingSource.Add((object)new y6XJ());
		id.set_Text(Conversions.ToString(checked(((IQueryable<Ad27>)fs4f.bridge).Select((Ad27 br) => br.id).Max() + 1)));
	}

	internal static string Md2y(string[] Lz5g, int Qc9k, int e2XP)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = Qc9k; i <= e2XP; i = checked(i + 1))
		{
			stringBuilder.Append(Lz5g[i]);
		}
		return stringBuilder.ToString();
	}

	private void z3P1(object sender, EventArgs e)
	{
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Fs4f fs4f = new Fs4f();
			object objectValue = RuntimeHelpers.GetObjectValue(BridgeBindingSource.get_Current());
			NewLateBinding.LateSet(objectValue, (Type)null, "recorddate", new object[1] { DateAndTime.get_Now() }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue, (Type)null, "recordprogram", new object[1] { ((Control)this).get_Name() }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue, (Type)null, "recorduserid", new object[1] { Environment.UserName }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue, (Type)null, "recordvalid", new object[1] { true }, (string[])null, (Type[])null);
			fs4f.bridge.Add((Ad27)objectValue);
			object objectValue2 = RuntimeHelpers.GetObjectValue(BridgeNoteBindingSource.get_Current());
			NewLateBinding.LateSet(objectValue2, (Type)null, "id", new object[1] { NewLateBinding.LateGet(objectValue, (Type)null, "id", new object[0], (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue2, (Type)null, "recorddate", new object[1] { DateAndTime.get_Now() }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue2, (Type)null, "recordprogram", new object[1] { ((Control)this).get_Name() }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue2, (Type)null, "recorduserid", new object[1] { Environment.UserName }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue2, (Type)null, "recordvalid", new object[1] { true }, (string[])null, (Type[])null);
			fs4f.bridgenote.Add((y6XJ)objectValue2);
			((DbContext)fs4f).SaveChanges();
			((Form)this).Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static bool Xq9a(int b5Q3)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(b5Q3 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				b5Q3 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				b5Q3 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				b5Q3 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Loa", false) == 0 && Operators.CompareString(text, "d", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "Load", false) == 0)
		{
			return true;
		}
		return false;
	}

	[SpecialName]
	[DebuggerHidden]
	[CompilerGenerated]
	private void Ee7i(object sender, EventArgs e)
	{
		f4LC();
	}
}
