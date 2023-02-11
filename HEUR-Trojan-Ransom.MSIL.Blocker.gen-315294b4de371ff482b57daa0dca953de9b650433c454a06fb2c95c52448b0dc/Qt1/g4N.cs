using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Af7;
using Fs0;
using Hm3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Po7;
using Sr8n;
using a3A1;
using a4M;
using a5A1;
using c7JX;
using d0FH;
using q5S;

namespace Qt1;

[DesignerGenerated]
public class g4N : Form
{
	private IContainer components;

	private Xk42 setting;

	private int designationYear;

	internal virtual Button inspectionHistoryButton
	{
		[CompilerGenerated]
		get
		{
			return _inspectionHistoryButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ee7;
			Button val = _inspectionHistoryButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_inspectionHistoryButton = value;
			val = _inspectionHistoryButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Expr1DataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn Expr1DataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Expr2DataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn Expr2DataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Expr3DataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn Expr3DataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button bridgeHistoryButton
	{
		[CompilerGenerated]
		get
		{
			return _bridgeHistoryButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Jg0;
			Button val = _bridgeHistoryButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_bridgeHistoryButton = value;
			val = _bridgeHistoryButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("BridgemanagementviewBindingSource")]
	internal virtual BindingSource BridgemanagementviewBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button bridgeNoteButton
	{
		[CompilerGenerated]
		get
		{
			return _bridgeNoteButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Eq1;
			Button val = _bridgeNoteButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_bridgeNoteButton = value;
			val = _bridgeNoteButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
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
			EventHandler eventHandler = b9K;
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

	internal virtual Button editBridgeNoteButton
	{
		[CompilerGenerated]
		get
		{
			return _editBridgeNoteButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = w8N;
			Button val = _editBridgeNoteButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_editBridgeNoteButton = value;
			val = _editBridgeNoteButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button openDirectoryButton
	{
		[CompilerGenerated]
		get
		{
			return _openDirectoryButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = b7Z;
			Button val = _openDirectoryButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_openDirectoryButton = value;
			val = _openDirectoryButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button searchButton
	{
		[CompilerGenerated]
		get
		{
			return _searchButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = y4K;
			Button val = _searchButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_searchButton = value;
			val = _searchButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("inspectionYearComboBox")]
	internal virtual ComboBox inspectionYearComboBox
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

	internal virtual Button exportButton
	{
		[CompilerGenerated]
		get
		{
			return _exportButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = n4E;
			Button val = _exportButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_exportButton = value;
			val = _exportButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button archiveButton
	{
		[CompilerGenerated]
		get
		{
			return _archiveButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d9P;
			Button val = _archiveButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_archiveButton = value;
			val = _archiveButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("SplitContainer1")]
	internal virtual SplitContainer SplitContainer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InspectionuppermaterialDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn InspectionuppermaterialDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button searchCancelButton
	{
		[CompilerGenerated]
		get
		{
			return _searchCancelButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Gx4;
			Button val = _searchCancelButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_searchCancelButton = value;
			val = _searchCancelButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("SplitContainer2")]
	internal virtual SplitContainer SplitContainer2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m5N;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
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

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
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

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox10")]
	internal virtual TextBox TextBox10
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

	[field: AccessedThroughProperty("TextBox11")]
	internal virtual TextBox TextBox11
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

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox8")]
	internal virtual TextBox TextBox8
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

	[field: AccessedThroughProperty("TextBox9")]
	internal virtual TextBox TextBox9
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
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

	[field: AccessedThroughProperty("TextBox7")]
	internal virtual TextBox TextBox7
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

	[field: AccessedThroughProperty("TabControl1")]
	internal virtual TabControl TabControl1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
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

	[field: AccessedThroughProperty("TextBox12")]
	internal virtual TextBox TextBox12
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

	[field: AccessedThroughProperty("TextBox13")]
	internal virtual TextBox TextBox13
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

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox14")]
	internal virtual TextBox TextBox14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label22")]
	internal virtual Label Label22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox15")]
	internal virtual TextBox TextBox15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label23")]
	internal virtual Label Label23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox16")]
	internal virtual TextBox TextBox16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label24")]
	internal virtual Label Label24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox17")]
	internal virtual TextBox TextBox17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = f0C;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("id")]
	internal virtual DataGridViewTextBoxColumn id
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bridgename")]
	internal virtual DataGridViewTextBoxColumn bridgename
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bridgenameruby")]
	internal virtual DataGridViewTextBoxColumn bridgenameruby
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("route")]
	internal virtual DataGridViewTextBoxColumn route
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("address")]
	internal virtual DataGridViewTextBoxColumn address
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("latitude")]
	internal virtual DataGridViewTextBoxColumn latitude
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("longitude")]
	internal virtual DataGridViewTextBoxColumn longitude
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("made")]
	internal virtual DataGridViewTextBoxColumn made
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bridgeage")]
	internal virtual DataGridViewTextBoxColumn bridgeage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bridgelength")]
	internal virtual DataGridViewTextBoxColumn bridgelength
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bridgewidth")]
	internal virtual DataGridViewTextBoxColumn bridgewidth
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("span")]
	internal virtual DataGridViewTextBoxColumn span
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bridgestructure")]
	internal virtual DataGridViewTextBoxColumn bridgestructure
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("uppermaterial")]
	internal virtual DataGridViewTextBoxColumn uppermaterial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lowermaterial")]
	internal virtual DataGridViewTextBoxColumn lowermaterial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("undercondition")]
	internal virtual DataGridViewTextBoxColumn undercondition
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("emergencyroad")]
	internal virtual DataGridViewTextBoxColumn emergencyroad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("repair")]
	internal virtual DataGridViewTextBoxColumn repair
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nextinspection")]
	internal virtual DataGridViewTextBoxColumn nextinspection
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("inspectionway")]
	internal virtual DataGridViewTextBoxColumn inspectionway
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("memo")]
	internal virtual DataGridViewTextBoxColumn memo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("inspectionyear")]
	internal virtual DataGridViewTextBoxColumn inspectionyear
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("inspectioner")]
	internal virtual DataGridViewTextBoxColumn inspectioner
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("inspectionundercondition")]
	internal virtual DataGridViewTextBoxColumn inspectionundercondition
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("alternatepath")]
	internal virtual DataGridViewTextBoxColumn alternatepath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("generalroad")]
	internal virtual DataGridViewTextBoxColumn generalroad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("inspectionemergencyroad")]
	internal virtual DataGridViewTextBoxColumn inspectionemergencyroad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("occupancy")]
	internal virtual DataGridViewTextBoxColumn occupancy
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("soundness")]
	internal virtual DataGridViewTextBoxColumn soundness
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("inspectionuppermaterialmain")]
	internal virtual DataGridViewTextBoxColumn inspectionuppermaterialmain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("uppermaterialside")]
	internal virtual DataGridViewTextBoxColumn uppermaterialside
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("uppermaterialfloor")]
	internal virtual DataGridViewTextBoxColumn uppermaterialfloor
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("undermaterial")]
	internal virtual DataGridViewTextBoxColumn undermaterial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bearing")]
	internal virtual DataGridViewTextBoxColumn bearing
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("face")]
	internal virtual DataGridViewTextBoxColumn face
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("datasavedir")]
	internal virtual DataGridViewTextBoxColumn datasavedir
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

	[field: AccessedThroughProperty("BridgeageDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn BridgeageDataGridViewTextBoxColumn
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

	[field: AccessedThroughProperty("RepairDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn RepairDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NextinspectionDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn NextinspectionDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InspectionwayDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn InspectionwayDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MemoDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn MemoDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InspectionyearDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn InspectionyearDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InspectionerDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn InspectionerDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InspectionunderconditionDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn InspectionunderconditionDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AlternatepathDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn AlternatepathDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GeneralroadDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn GeneralroadDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InspectionemergencyroadDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn InspectionemergencyroadDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("OccupancyDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn OccupancyDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SoundnessDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SoundnessDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UndermaterialDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn UndermaterialDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BearingDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn BearingDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FaceDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn FaceDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DatasavedirDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn DatasavedirDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label25")]
	internal virtual Label Label25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NumericUpDown1")]
	internal virtual NumericUpDown NumericUpDown1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public g4N()
	{
		((Form)this).add_Load((EventHandler)Xj1);
		setting = Xk42.Yd9g();
		designationYear = 0;
		Bt3();
	}

	[DebuggerNonUserCode]
	protected override void x0T(bool Fo4)
	{
		try
		{
			if (Fo4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Fo4);
		}
	}

	[DebuggerStepThrough]
	private void Bt3()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected O, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected O, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected O, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected O, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected O, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected O, but got Unknown
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected O, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected O, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected O, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected O, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected O, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected O, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected O, but got Unknown
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected O, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected O, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected O, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected O, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected O, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected O, but got Unknown
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected O, but got Unknown
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected O, but got Unknown
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected O, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected O, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected O, but got Unknown
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected O, but got Unknown
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected O, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected O, but got Unknown
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected O, but got Unknown
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_217d: Unknown result type (might be due to invalid IL or missing references)
		//IL_21fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_24e6: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		inspectionHistoryButton = new Button();
		DataGridView1 = new DataGridView();
		bridgeHistoryButton = new Button();
		bridgeNoteButton = new Button();
		editBridgeButton = new Button();
		editBridgeNoteButton = new Button();
		openDirectoryButton = new Button();
		searchButton = new Button();
		inspectionYearComboBox = new ComboBox();
		Label1 = new Label();
		exportButton = new Button();
		archiveButton = new Button();
		SplitContainer1 = new SplitContainer();
		searchCancelButton = new Button();
		SplitContainer2 = new SplitContainer();
		Label2 = new Label();
		GroupBox1 = new GroupBox();
		Label3 = new Label();
		TextBox1 = new TextBox();
		Button1 = new Button();
		TextBox2 = new TextBox();
		Label4 = new Label();
		TextBox3 = new TextBox();
		Label5 = new Label();
		TextBox4 = new TextBox();
		Label6 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		TextBox5 = new TextBox();
		Label9 = new Label();
		TextBox6 = new TextBox();
		Label10 = new Label();
		TextBox7 = new TextBox();
		Label11 = new Label();
		Label12 = new Label();
		TextBox8 = new TextBox();
		Label13 = new Label();
		TextBox9 = new TextBox();
		Label14 = new Label();
		Label15 = new Label();
		TextBox10 = new TextBox();
		Label16 = new Label();
		TextBox11 = new TextBox();
		Label17 = new Label();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		TabPage2 = new TabPage();
		TabPage3 = new TabPage();
		Label18 = new Label();
		TextBox12 = new TextBox();
		Label19 = new Label();
		TextBox13 = new TextBox();
		Label20 = new Label();
		TabPage4 = new TabPage();
		TextBox14 = new TextBox();
		Label21 = new Label();
		Label22 = new Label();
		TextBox15 = new TextBox();
		Label23 = new Label();
		TextBox16 = new TextBox();
		Label24 = new Label();
		TextBox17 = new TextBox();
		Button2 = new Button();
		id = new DataGridViewTextBoxColumn();
		bridgename = new DataGridViewTextBoxColumn();
		bridgenameruby = new DataGridViewTextBoxColumn();
		route = new DataGridViewTextBoxColumn();
		address = new DataGridViewTextBoxColumn();
		latitude = new DataGridViewTextBoxColumn();
		longitude = new DataGridViewTextBoxColumn();
		made = new DataGridViewTextBoxColumn();
		bridgeage = new DataGridViewTextBoxColumn();
		bridgelength = new DataGridViewTextBoxColumn();
		bridgewidth = new DataGridViewTextBoxColumn();
		span = new DataGridViewTextBoxColumn();
		bridgestructure = new DataGridViewTextBoxColumn();
		uppermaterial = new DataGridViewTextBoxColumn();
		lowermaterial = new DataGridViewTextBoxColumn();
		undercondition = new DataGridViewTextBoxColumn();
		emergencyroad = new DataGridViewTextBoxColumn();
		repair = new DataGridViewTextBoxColumn();
		nextinspection = new DataGridViewTextBoxColumn();
		inspectionway = new DataGridViewTextBoxColumn();
		memo = new DataGridViewTextBoxColumn();
		inspectionyear = new DataGridViewTextBoxColumn();
		inspectioner = new DataGridViewTextBoxColumn();
		inspectionundercondition = new DataGridViewTextBoxColumn();
		alternatepath = new DataGridViewTextBoxColumn();
		generalroad = new DataGridViewTextBoxColumn();
		inspectionemergencyroad = new DataGridViewTextBoxColumn();
		occupancy = new DataGridViewTextBoxColumn();
		soundness = new DataGridViewTextBoxColumn();
		inspectionuppermaterialmain = new DataGridViewTextBoxColumn();
		uppermaterialside = new DataGridViewTextBoxColumn();
		uppermaterialfloor = new DataGridViewTextBoxColumn();
		undermaterial = new DataGridViewTextBoxColumn();
		bearing = new DataGridViewTextBoxColumn();
		face = new DataGridViewTextBoxColumn();
		datasavedir = new DataGridViewTextBoxColumn();
		NumericUpDown1 = new NumericUpDown();
		Label25 = new Label();
		IdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BridgenameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BridgenamerubyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RouteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		AddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		LatitudeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		LongitudeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		MadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BridgeageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BridgelengthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BridgewidthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SpanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BridgestructureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		UppermaterialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		LowermaterialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		UnderconditionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		EmergencyroadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RepairDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		NextinspectionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		InspectionwayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		MemoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		InspectionyearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		InspectionerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		InspectionunderconditionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		AlternatepathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		GeneralroadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		InspectionemergencyroadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		OccupancyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SoundnessDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		UndermaterialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BearingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		FaceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		DatasavedirDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BridgemanagementviewBindingSource = new BindingSource(components);
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)SplitContainer1).BeginInit();
		((Control)SplitContainer1.get_Panel1()).SuspendLayout();
		((Control)SplitContainer1.get_Panel2()).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((ISupportInitialize)SplitContainer2).BeginInit();
		((Control)SplitContainer2.get_Panel1()).SuspendLayout();
		((Control)SplitContainer2.get_Panel2()).SuspendLayout();
		((Control)SplitContainer2).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)TabPage4).SuspendLayout();
		((ISupportInitialize)NumericUpDown1).BeginInit();
		((ISupportInitialize)BridgemanagementviewBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		((Control)inspectionHistoryButton).set_Location(new Point(12, 8));
		((Control)inspectionHistoryButton).set_Name("inspectionHistoryButton");
		((Control)inspectionHistoryButton).set_Size(new Size(66, 23));
		((Control)inspectionHistoryButton).set_TabIndex(1);
		((ButtonBase)inspectionHistoryButton).set_Text("点検履歴");
		((ButtonBase)inspectionHistoryButton).set_UseVisualStyleBackColor(true);
		DataGridView1.set_AllowUserToAddRows(false);
		DataGridView1.set_AllowUserToDeleteRows(false);
		DataGridView1.set_AutoGenerateColumns(false);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[69]
		{
			(DataGridViewColumn)id,
			(DataGridViewColumn)bridgename,
			(DataGridViewColumn)bridgenameruby,
			(DataGridViewColumn)route,
			(DataGridViewColumn)address,
			(DataGridViewColumn)latitude,
			(DataGridViewColumn)longitude,
			(DataGridViewColumn)made,
			(DataGridViewColumn)bridgeage,
			(DataGridViewColumn)bridgelength,
			(DataGridViewColumn)bridgewidth,
			(DataGridViewColumn)span,
			(DataGridViewColumn)bridgestructure,
			(DataGridViewColumn)uppermaterial,
			(DataGridViewColumn)lowermaterial,
			(DataGridViewColumn)undercondition,
			(DataGridViewColumn)emergencyroad,
			(DataGridViewColumn)repair,
			(DataGridViewColumn)nextinspection,
			(DataGridViewColumn)inspectionway,
			(DataGridViewColumn)memo,
			(DataGridViewColumn)inspectionyear,
			(DataGridViewColumn)inspectioner,
			(DataGridViewColumn)inspectionundercondition,
			(DataGridViewColumn)alternatepath,
			(DataGridViewColumn)generalroad,
			(DataGridViewColumn)inspectionemergencyroad,
			(DataGridViewColumn)occupancy,
			(DataGridViewColumn)soundness,
			(DataGridViewColumn)inspectionuppermaterialmain,
			(DataGridViewColumn)uppermaterialside,
			(DataGridViewColumn)uppermaterialfloor,
			(DataGridViewColumn)undermaterial,
			(DataGridViewColumn)bearing,
			(DataGridViewColumn)face,
			(DataGridViewColumn)datasavedir,
			(DataGridViewColumn)IdDataGridViewTextBoxColumn,
			(DataGridViewColumn)BridgenameDataGridViewTextBoxColumn,
			(DataGridViewColumn)BridgenamerubyDataGridViewTextBoxColumn,
			(DataGridViewColumn)RouteDataGridViewTextBoxColumn,
			(DataGridViewColumn)AddressDataGridViewTextBoxColumn,
			(DataGridViewColumn)LatitudeDataGridViewTextBoxColumn,
			(DataGridViewColumn)LongitudeDataGridViewTextBoxColumn,
			(DataGridViewColumn)MadeDataGridViewTextBoxColumn,
			(DataGridViewColumn)BridgeageDataGridViewTextBoxColumn,
			(DataGridViewColumn)BridgelengthDataGridViewTextBoxColumn,
			(DataGridViewColumn)BridgewidthDataGridViewTextBoxColumn,
			(DataGridViewColumn)SpanDataGridViewTextBoxColumn,
			(DataGridViewColumn)BridgestructureDataGridViewTextBoxColumn,
			(DataGridViewColumn)UppermaterialDataGridViewTextBoxColumn,
			(DataGridViewColumn)LowermaterialDataGridViewTextBoxColumn,
			(DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn,
			(DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn,
			(DataGridViewColumn)RepairDataGridViewTextBoxColumn,
			(DataGridViewColumn)NextinspectionDataGridViewTextBoxColumn,
			(DataGridViewColumn)InspectionwayDataGridViewTextBoxColumn,
			(DataGridViewColumn)MemoDataGridViewTextBoxColumn,
			(DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn,
			(DataGridViewColumn)InspectionerDataGridViewTextBoxColumn,
			(DataGridViewColumn)InspectionunderconditionDataGridViewTextBoxColumn,
			(DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn,
			(DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn,
			(DataGridViewColumn)InspectionemergencyroadDataGridViewTextBoxColumn,
			(DataGridViewColumn)OccupancyDataGridViewTextBoxColumn,
			(DataGridViewColumn)SoundnessDataGridViewTextBoxColumn,
			(DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn,
			(DataGridViewColumn)BearingDataGridViewTextBoxColumn,
			(DataGridViewColumn)FaceDataGridViewTextBoxColumn,
			(DataGridViewColumn)DatasavedirDataGridViewTextBoxColumn
		});
		DataGridView1.set_DataSource((object)BridgemanagementviewBindingSource);
		((Control)DataGridView1).set_Dock((DockStyle)5);
		((Control)DataGridView1).set_Location(new Point(0, 0));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.get_RowTemplate().set_Height(21);
		((Control)DataGridView1).set_Size(new Size(1290, 634));
		((Control)DataGridView1).set_TabIndex(2);
		((Control)bridgeHistoryButton).set_Location(new Point(448, 8));
		((Control)bridgeHistoryButton).set_Name("bridgeHistoryButton");
		((Control)bridgeHistoryButton).set_Size(new Size(75, 23));
		((Control)bridgeHistoryButton).set_TabIndex(3);
		((ButtonBase)bridgeHistoryButton).set_Text("橋梁履歴");
		((ButtonBase)bridgeHistoryButton).set_UseVisualStyleBackColor(true);
		((Control)bridgeNoteButton).set_Location(new Point(280, 8));
		((Control)bridgeNoteButton).set_Name("bridgeNoteButton");
		((Control)bridgeNoteButton).set_Size(new Size(81, 23));
		((Control)bridgeNoteButton).set_TabIndex(4);
		((ButtonBase)bridgeNoteButton).set_Text("橋梁メモ履歴");
		((ButtonBase)bridgeNoteButton).set_UseVisualStyleBackColor(true);
		((Control)editBridgeButton).set_Location(new Point(367, 8));
		((Control)editBridgeButton).set_Name("editBridgeButton");
		((Control)editBridgeButton).set_Size(new Size(75, 23));
		((Control)editBridgeButton).set_TabIndex(5);
		((ButtonBase)editBridgeButton).set_Text("橋梁編集");
		((ButtonBase)editBridgeButton).set_UseVisualStyleBackColor(true);
		((Control)editBridgeNoteButton).set_Location(new Point(191, 8));
		((Control)editBridgeNoteButton).set_Name("editBridgeNoteButton");
		((Control)editBridgeNoteButton).set_Size(new Size(83, 23));
		((Control)editBridgeNoteButton).set_TabIndex(6);
		((ButtonBase)editBridgeNoteButton).set_Text("橋梁メモ編集");
		((ButtonBase)editBridgeNoteButton).set_UseVisualStyleBackColor(true);
		((Control)openDirectoryButton).set_Location(new Point(84, 8));
		((Control)openDirectoryButton).set_Name("openDirectoryButton");
		((Control)openDirectoryButton).set_Size(new Size(101, 23));
		((Control)openDirectoryButton).set_TabIndex(7);
		((ButtonBase)openDirectoryButton).set_Text("点検データフォルダ");
		((ButtonBase)openDirectoryButton).set_UseVisualStyleBackColor(true);
		((Control)searchButton).set_Location(new Point(913, 8));
		((Control)searchButton).set_Name("searchButton");
		((Control)searchButton).set_Size(new Size(58, 23));
		((Control)searchButton).set_TabIndex(8);
		((ButtonBase)searchButton).set_Text("絞込");
		((ButtonBase)searchButton).set_UseVisualStyleBackColor(true);
		((ListControl)inspectionYearComboBox).set_FormattingEnabled(true);
		((Control)inspectionYearComboBox).set_Location(new Point(786, 8));
		((Control)inspectionYearComboBox).set_Name("inspectionYearComboBox");
		((Control)inspectionYearComboBox).set_Size(new Size(121, 20));
		((Control)inspectionYearComboBox).set_TabIndex(9);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(727, 14));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(53, 12));
		((Control)Label1).set_TabIndex(10);
		Label1.set_Text("次回調査");
		((Control)exportButton).set_Location(new Point(1060, 9));
		((Control)exportButton).set_Name("exportButton");
		((Control)exportButton).set_Size(new Size(105, 23));
		((Control)exportButton).set_TabIndex(11);
		((ButtonBase)exportButton).set_Text("データエクスポート");
		((ButtonBase)exportButton).set_UseVisualStyleBackColor(true);
		((Control)archiveButton).set_Location(new Point(1171, 8));
		((Control)archiveButton).set_Name("archiveButton");
		((Control)archiveButton).set_Size(new Size(102, 23));
		((Control)archiveButton).set_TabIndex(12);
		((ButtonBase)archiveButton).set_Text("点検データまとめ");
		((ButtonBase)archiveButton).set_UseVisualStyleBackColor(true);
		SplitContainer1.set_Dock((DockStyle)5);
		SplitContainer1.set_FixedPanel((FixedPanel)1);
		((Control)SplitContainer1).set_Location(new Point(0, 0));
		((Control)SplitContainer1).set_Name("SplitContainer1");
		SplitContainer1.set_Orientation((Orientation)0);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)Label25);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)NumericUpDown1);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)Button2);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)searchCancelButton);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)inspectionHistoryButton);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)archiveButton);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)openDirectoryButton);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)exportButton);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)editBridgeNoteButton);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)searchButton);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)inspectionYearComboBox);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)Label1);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)bridgeNoteButton);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)editBridgeButton);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)bridgeHistoryButton);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)DataGridView1);
		((Control)SplitContainer1).set_Size(new Size(1290, 676));
		SplitContainer1.set_SplitterDistance(38);
		((Control)SplitContainer1).set_TabIndex(13);
		((Control)searchCancelButton).set_Location(new Point(977, 9));
		((Control)searchCancelButton).set_Name("searchCancelButton");
		((Control)searchCancelButton).set_Size(new Size(75, 23));
		((Control)searchCancelButton).set_TabIndex(13);
		((ButtonBase)searchCancelButton).set_Text("絞込解除");
		((ButtonBase)searchCancelButton).set_UseVisualStyleBackColor(true);
		SplitContainer2.set_Dock((DockStyle)5);
		SplitContainer2.set_FixedPanel((FixedPanel)1);
		((Control)SplitContainer2).set_Location(new Point(0, 0));
		((Control)SplitContainer2).set_Name("SplitContainer2");
		((Control)SplitContainer2.get_Panel1()).get_Controls().Add((Control)(object)GroupBox1);
		((Control)SplitContainer2.get_Panel1()).get_Controls().Add((Control)(object)Label2);
		((Control)SplitContainer2.get_Panel2()).get_Controls().Add((Control)(object)SplitContainer1);
		((Control)SplitContainer2).set_Size(new Size(1477, 676));
		SplitContainer2.set_SplitterDistance(183);
		((Control)SplitContainer2).set_TabIndex(14);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(12, 19));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(0, 12));
		((Control)Label2).set_TabIndex(0);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TabControl1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).set_Dock((DockStyle)5);
		((Control)GroupBox1).set_Location(new Point(0, 0));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(183, 676));
		((Control)GroupBox1).set_TabIndex(1);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("検索条件設定");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(9, 14));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(53, 12));
		((Control)Label3).set_TabIndex(0);
		Label3.set_Text("道路橋名");
		((Control)TextBox1).set_Location(new Point(7, 29));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(141, 19));
		((Control)TextBox1).set_TabIndex(1);
		((Control)Button1).set_Location(new Point(6, 21));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(167, 29));
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("検\u3000\u3000索");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)TextBox2).set_Location(new Point(7, 65));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(141, 19));
		((Control)TextBox2).set_TabIndex(4);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(9, 50));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(41, 12));
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("路線名");
		((Control)TextBox3).set_Location(new Point(7, 102));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(141, 19));
		((Control)TextBox3).set_TabIndex(6);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Location(new Point(9, 87));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(41, 12));
		((Control)Label5).set_TabIndex(5);
		Label5.set_Text("所在地");
		((Control)TextBox4).set_Location(new Point(66, 142));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(80, 19));
		((Control)TextBox4).set_TabIndex(8);
		Label6.set_AutoSize(true);
		((Control)Label6).set_Location(new Point(7, 127));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(53, 12));
		((Control)Label6).set_TabIndex(7);
		Label6.set_Text("架設年次");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Location(new Point(25, 149));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(37, 12));
		((Control)Label7).set_TabIndex(9);
		Label7.set_Text("FROM");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Location(new Point(42, 170));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(20, 12));
		((Control)Label8).set_TabIndex(11);
		Label8.set_Text("TO");
		((Control)TextBox5).set_Location(new Point(66, 167));
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(80, 19));
		((Control)TextBox5).set_TabIndex(10);
		Label9.set_AutoSize(true);
		((Control)Label9).set_Location(new Point(40, 236));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(20, 12));
		((Control)Label9).set_TabIndex(16);
		Label9.set_Text("TO");
		((Control)TextBox6).set_Location(new Point(66, 208));
		((Control)TextBox6).set_Name("TextBox6");
		((Control)TextBox6).set_Size(new Size(80, 19));
		((Control)TextBox6).set_TabIndex(15);
		Label10.set_AutoSize(true);
		((Control)Label10).set_Location(new Point(23, 215));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(37, 12));
		((Control)Label10).set_TabIndex(14);
		Label10.set_Text("FROM");
		((Control)TextBox7).set_Location(new Point(66, 233));
		((Control)TextBox7).set_Name("TextBox7");
		((Control)TextBox7).set_Size(new Size(80, 19));
		((Control)TextBox7).set_TabIndex(13);
		Label11.set_AutoSize(true);
		((Control)Label11).set_Location(new Point(7, 196));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(29, 12));
		((Control)Label11).set_TabIndex(12);
		Label11.set_Text("橋令");
		Label12.set_AutoSize(true);
		((Control)Label12).set_Location(new Point(40, 302));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(20, 12));
		((Control)Label12).set_TabIndex(21);
		Label12.set_Text("TO");
		((Control)TextBox8).set_Location(new Point(66, 277));
		((Control)TextBox8).set_Name("TextBox8");
		((Control)TextBox8).set_Size(new Size(80, 19));
		((Control)TextBox8).set_TabIndex(20);
		Label13.set_AutoSize(true);
		((Control)Label13).set_Location(new Point(23, 280));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Size(new Size(37, 12));
		((Control)Label13).set_TabIndex(19);
		Label13.set_Text("FROM");
		((Control)TextBox9).set_Location(new Point(66, 302));
		((Control)TextBox9).set_Name("TextBox9");
		((Control)TextBox9).set_Size(new Size(80, 19));
		((Control)TextBox9).set_TabIndex(18);
		Label14.set_AutoSize(true);
		((Control)Label14).set_Location(new Point(7, 262));
		((Control)Label14).set_Name("Label14");
		((Control)Label14).set_Size(new Size(29, 12));
		((Control)Label14).set_TabIndex(17);
		Label14.set_Text("橋長");
		Label15.set_AutoSize(true);
		((Control)Label15).set_Location(new Point(40, 370));
		((Control)Label15).set_Name("Label15");
		((Control)Label15).set_Size(new Size(20, 12));
		((Control)Label15).set_TabIndex(26);
		Label15.set_Text("TO");
		((Control)TextBox10).set_Location(new Point(66, 338));
		((Control)TextBox10).set_Name("TextBox10");
		((Control)TextBox10).set_Size(new Size(80, 19));
		((Control)TextBox10).set_TabIndex(25);
		Label16.set_AutoSize(true);
		((Control)Label16).set_Location(new Point(23, 345));
		((Control)Label16).set_Name("Label16");
		((Control)Label16).set_Size(new Size(37, 12));
		((Control)Label16).set_TabIndex(24);
		Label16.set_Text("FROM");
		((Control)TextBox11).set_Location(new Point(66, 363));
		((Control)TextBox11).set_Name("TextBox11");
		((Control)TextBox11).set_Size(new Size(80, 19));
		((Control)TextBox11).set_TabIndex(23);
		Label17.set_AutoSize(true);
		((Control)Label17).set_Location(new Point(7, 327));
		((Control)Label17).set_Name("Label17");
		((Control)Label17).set_Size(new Size(29, 12));
		((Control)Label17).set_TabIndex(22);
		Label17.set_Text("幅員");
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage1);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage2);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage3);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage4);
		((Control)TabControl1).set_Location(new Point(0, 64));
		((Control)TabControl1).set_Name("TabControl1");
		TabControl1.set_SelectedIndex(0);
		((Control)TabControl1).set_Size(new Size(177, 609));
		((Control)TabControl1).set_TabIndex(27);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label22);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox15);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label23);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox16);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label24);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox17);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label18);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox12);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label19);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox13);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label20);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label15);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label3);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox10);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox1);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label16);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label4);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox11);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox2);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label17);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label5);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label12);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox3);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox8);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label6);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label13);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox4);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox9);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label7);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label14);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox5);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label9);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label8);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox6);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label11);
		((Control)TabPage1).get_Controls().Add((Control)(object)Label10);
		((Control)TabPage1).get_Controls().Add((Control)(object)TextBox7);
		TabPage1.set_Location(new Point(4, 22));
		((Control)TabPage1).set_Name("TabPage1");
		((Control)TabPage1).set_Padding(new Padding(3));
		((Control)TabPage1).set_Size(new Size(169, 583));
		TabPage1.set_TabIndex(0);
		TabPage1.set_Text("橋梁");
		TabPage1.set_UseVisualStyleBackColor(true);
		TabPage2.set_Location(new Point(4, 22));
		((Control)TabPage2).set_Name("TabPage2");
		((Control)TabPage2).set_Padding(new Padding(3));
		((Control)TabPage2).set_Size(new Size(169, 583));
		TabPage2.set_TabIndex(1);
		TabPage2.set_Text("メモ");
		TabPage2.set_UseVisualStyleBackColor(true);
		TabPage3.set_Location(new Point(4, 22));
		((Control)TabPage3).set_Name("TabPage3");
		((Control)TabPage3).set_Size(new Size(169, 583));
		TabPage3.set_TabIndex(2);
		TabPage3.set_Text("点検");
		TabPage3.set_UseVisualStyleBackColor(true);
		Label18.set_AutoSize(true);
		((Control)Label18).set_Location(new Point(42, 435));
		((Control)Label18).set_Name("Label18");
		((Control)Label18).set_Size(new Size(20, 12));
		((Control)Label18).set_TabIndex(31);
		Label18.set_Text("TO");
		((Control)TextBox12).set_Location(new Point(66, 407));
		((Control)TextBox12).set_Name("TextBox12");
		((Control)TextBox12).set_Size(new Size(80, 19));
		((Control)TextBox12).set_TabIndex(30);
		Label19.set_AutoSize(true);
		((Control)Label19).set_Location(new Point(25, 410));
		((Control)Label19).set_Name("Label19");
		((Control)Label19).set_Size(new Size(37, 12));
		((Control)Label19).set_TabIndex(29);
		Label19.set_Text("FROM");
		((Control)TextBox13).set_Location(new Point(66, 432));
		((Control)TextBox13).set_Name("TextBox13");
		((Control)TextBox13).set_Size(new Size(80, 19));
		((Control)TextBox13).set_TabIndex(28);
		Label20.set_AutoSize(true);
		((Control)Label20).set_Location(new Point(9, 392));
		((Control)Label20).set_Name("Label20");
		((Control)Label20).set_Size(new Size(41, 12));
		((Control)Label20).set_TabIndex(27);
		Label20.set_Text("径間数");
		((Control)TabPage4).get_Controls().Add((Control)(object)Label21);
		((Control)TabPage4).get_Controls().Add((Control)(object)TextBox14);
		TabPage4.set_Location(new Point(4, 22));
		((Control)TabPage4).set_Name("TabPage4");
		((Control)TabPage4).set_Padding(new Padding(3));
		((Control)TabPage4).set_Size(new Size(169, 583));
		TabPage4.set_TabIndex(3);
		TabPage4.set_Text("並順");
		TabPage4.set_UseVisualStyleBackColor(true);
		((Control)TextBox14).set_Location(new Point(9, 30));
		TextBox14.set_Multiline(true);
		((Control)TextBox14).set_Name("TextBox14");
		((Control)TextBox14).set_Size(new Size(147, 534));
		((Control)TextBox14).set_TabIndex(0);
		Label21.set_AutoSize(true);
		((Control)Label21).set_Location(new Point(12, 8));
		((Control)Label21).set_Name("Label21");
		((Control)Label21).set_Size(new Size(89, 12));
		((Control)Label21).set_TabIndex(1);
		Label21.set_Text("国土交通省番号");
		Label22.set_AutoSize(true);
		((Control)Label22).set_Location(new Point(9, 460));
		((Control)Label22).set_Name("Label22");
		((Control)Label22).set_Size(new Size(53, 12));
		((Control)Label22).set_TabIndex(32);
		Label22.set_Text("構造形式");
		((Control)TextBox15).set_Location(new Point(7, 475));
		((Control)TextBox15).set_Name("TextBox15");
		((Control)TextBox15).set_Size(new Size(141, 19));
		((Control)TextBox15).set_TabIndex(33);
		Label23.set_AutoSize(true);
		((Control)Label23).set_Location(new Point(9, 496));
		((Control)Label23).set_Name("Label23");
		((Control)Label23).set_Size(new Size(89, 12));
		((Control)Label23).set_TabIndex(34);
		Label23.set_Text("上部工使用材料");
		((Control)TextBox16).set_Location(new Point(7, 511));
		((Control)TextBox16).set_Name("TextBox16");
		((Control)TextBox16).set_Size(new Size(141, 19));
		((Control)TextBox16).set_TabIndex(35);
		Label24.set_AutoSize(true);
		((Control)Label24).set_Location(new Point(9, 533));
		((Control)Label24).set_Name("Label24");
		((Control)Label24).set_Size(new Size(53, 12));
		((Control)Label24).set_TabIndex(36);
		Label24.set_Text("床板材料");
		((Control)TextBox17).set_Location(new Point(7, 548));
		((Control)TextBox17).set_Name("TextBox17");
		((Control)TextBox17).set_Size(new Size(141, 19));
		((Control)TextBox17).set_TabIndex(37);
		((Control)Button2).set_Location(new Point(658, 8));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(50, 23));
		((Control)Button2).set_TabIndex(28);
		((ButtonBase)Button2).set_Text("←確定");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((DataGridViewColumn)id).set_DataPropertyName("id");
		((DataGridViewColumn)id).set_HeaderText("国交省作業番号");
		((DataGridViewColumn)id).set_Name("id");
		((DataGridViewColumn)id).set_ReadOnly(true);
		((DataGridViewColumn)bridgename).set_DataPropertyName("bridgename");
		((DataGridViewColumn)bridgename).set_FillWeight(50f);
		((DataGridViewColumn)bridgename).set_HeaderText("道路橋名");
		((DataGridViewColumn)bridgename).set_MinimumWidth(100);
		((DataGridViewColumn)bridgename).set_Name("bridgename");
		((DataGridViewColumn)bridgename).set_ReadOnly(true);
		((DataGridViewColumn)bridgenameruby).set_DataPropertyName("bridgenameruby");
		((DataGridViewColumn)bridgenameruby).set_HeaderText("道路橋名(カナ)");
		((DataGridViewColumn)bridgenameruby).set_Name("bridgenameruby");
		((DataGridViewColumn)bridgenameruby).set_ReadOnly(true);
		((DataGridViewColumn)route).set_DataPropertyName("route");
		((DataGridViewColumn)route).set_HeaderText("路線名");
		((DataGridViewColumn)route).set_Name("route");
		((DataGridViewColumn)route).set_ReadOnly(true);
		((DataGridViewColumn)address).set_DataPropertyName("address");
		((DataGridViewColumn)address).set_HeaderText("所在地");
		((DataGridViewColumn)address).set_Name("address");
		((DataGridViewColumn)address).set_ReadOnly(true);
		((DataGridViewColumn)latitude).set_DataPropertyName("latitude");
		((DataGridViewColumn)latitude).set_HeaderText("緯度");
		((DataGridViewColumn)latitude).set_Name("latitude");
		((DataGridViewColumn)latitude).set_ReadOnly(true);
		((DataGridViewColumn)longitude).set_DataPropertyName("longitude");
		((DataGridViewColumn)longitude).set_HeaderText("経度");
		((DataGridViewColumn)longitude).set_Name("longitude");
		((DataGridViewColumn)longitude).set_ReadOnly(true);
		((DataGridViewColumn)made).set_DataPropertyName("made");
		((DataGridViewColumn)made).set_HeaderText("架設年次");
		((DataGridViewColumn)made).set_Name("made");
		((DataGridViewColumn)made).set_ReadOnly(true);
		((DataGridViewColumn)bridgeage).set_DataPropertyName("bridgeage");
		((DataGridViewColumn)bridgeage).set_HeaderText("橋令");
		((DataGridViewColumn)bridgeage).set_Name("bridgeage");
		((DataGridViewColumn)bridgeage).set_ReadOnly(true);
		((DataGridViewColumn)bridgelength).set_DataPropertyName("bridgelength");
		((DataGridViewColumn)bridgelength).set_HeaderText("橋長");
		((DataGridViewColumn)bridgelength).set_Name("bridgelength");
		((DataGridViewColumn)bridgelength).set_ReadOnly(true);
		((DataGridViewColumn)bridgewidth).set_DataPropertyName("bridgewidth");
		((DataGridViewColumn)bridgewidth).set_HeaderText("幅員");
		((DataGridViewColumn)bridgewidth).set_Name("bridgewidth");
		((DataGridViewColumn)bridgewidth).set_ReadOnly(true);
		((DataGridViewColumn)span).set_DataPropertyName("span");
		((DataGridViewColumn)span).set_HeaderText("径間数");
		((DataGridViewColumn)span).set_Name("span");
		((DataGridViewColumn)span).set_ReadOnly(true);
		((DataGridViewColumn)bridgestructure).set_DataPropertyName("bridgestructure");
		((DataGridViewColumn)bridgestructure).set_HeaderText("構造形式");
		((DataGridViewColumn)bridgestructure).set_Name("bridgestructure");
		((DataGridViewColumn)bridgestructure).set_ReadOnly(true);
		((DataGridViewColumn)uppermaterial).set_DataPropertyName("uppermaterial");
		((DataGridViewColumn)uppermaterial).set_HeaderText("上部工使用材料");
		((DataGridViewColumn)uppermaterial).set_Name("uppermaterial");
		((DataGridViewColumn)uppermaterial).set_ReadOnly(true);
		((DataGridViewColumn)lowermaterial).set_DataPropertyName("lowermaterial");
		((DataGridViewColumn)lowermaterial).set_HeaderText("床板材料");
		((DataGridViewColumn)lowermaterial).set_Name("lowermaterial");
		((DataGridViewColumn)lowermaterial).set_ReadOnly(true);
		((DataGridViewColumn)undercondition).set_DataPropertyName("undercondition");
		((DataGridViewColumn)undercondition).set_HeaderText("路下条件");
		((DataGridViewColumn)undercondition).set_Name("undercondition");
		((DataGridViewColumn)undercondition).set_ReadOnly(true);
		((DataGridViewColumn)emergencyroad).set_DataPropertyName("emergencyroad");
		((DataGridViewColumn)emergencyroad).set_HeaderText("緊急輸送道路");
		((DataGridViewColumn)emergencyroad).set_Name("emergencyroad");
		((DataGridViewColumn)emergencyroad).set_ReadOnly(true);
		((DataGridViewColumn)repair).set_DataPropertyName("repair");
		((DataGridViewColumn)repair).set_HeaderText("修繕履歴");
		((DataGridViewColumn)repair).set_Name("repair");
		((DataGridViewColumn)nextinspection).set_DataPropertyName("nextinspection");
		((DataGridViewColumn)nextinspection).set_HeaderText("次回点検年度");
		((DataGridViewColumn)nextinspection).set_Name("nextinspection");
		((DataGridViewColumn)nextinspection).set_ReadOnly(true);
		((DataGridViewColumn)inspectionway).set_DataPropertyName("inspectionway");
		((DataGridViewColumn)inspectionway).set_HeaderText("点検方法");
		((DataGridViewColumn)inspectionway).set_Name("inspectionway");
		((DataGridViewColumn)inspectionway).set_ReadOnly(true);
		((DataGridViewColumn)memo).set_DataPropertyName("memo");
		((DataGridViewColumn)memo).set_HeaderText("備考");
		((DataGridViewColumn)memo).set_Name("memo");
		((DataGridViewColumn)memo).set_ReadOnly(true);
		((DataGridViewColumn)inspectionyear).set_DataPropertyName("inspectionyear");
		((DataGridViewColumn)inspectionyear).set_HeaderText("最新点検年度");
		((DataGridViewColumn)inspectionyear).set_Name("inspectionyear");
		((DataGridViewColumn)inspectionyear).set_ReadOnly(true);
		((DataGridViewColumn)inspectioner).set_DataPropertyName("inspectioner");
		((DataGridViewColumn)inspectioner).set_HeaderText("点検者");
		((DataGridViewColumn)inspectioner).set_Name("inspectioner");
		((DataGridViewColumn)inspectioner).set_ReadOnly(true);
		((DataGridViewColumn)inspectionundercondition).set_DataPropertyName("inspectionundercondition");
		((DataGridViewColumn)inspectionundercondition).set_HeaderText("路下条件(点検)");
		((DataGridViewColumn)inspectionundercondition).set_Name("inspectionundercondition");
		((DataGridViewColumn)inspectionundercondition).set_ReadOnly(true);
		((DataGridViewColumn)alternatepath).set_DataPropertyName("alternatepath");
		((DataGridViewColumn)alternatepath).set_HeaderText("代替路有無");
		((DataGridViewColumn)alternatepath).set_Name("alternatepath");
		((DataGridViewColumn)alternatepath).set_ReadOnly(true);
		((DataGridViewColumn)generalroad).set_DataPropertyName("generalroad");
		((DataGridViewColumn)generalroad).set_HeaderText("自専道or一般道");
		((DataGridViewColumn)generalroad).set_Name("generalroad");
		((DataGridViewColumn)generalroad).set_ReadOnly(true);
		((DataGridViewColumn)inspectionemergencyroad).set_DataPropertyName("inspectionemergencyroad");
		((DataGridViewColumn)inspectionemergencyroad).set_HeaderText("緊急輸送道路(点検)");
		((DataGridViewColumn)inspectionemergencyroad).set_Name("inspectionemergencyroad");
		((DataGridViewColumn)inspectionemergencyroad).set_ReadOnly(true);
		((DataGridViewColumn)occupancy).set_DataPropertyName("occupancy");
		((DataGridViewColumn)occupancy).set_HeaderText("占用物件（名称）");
		((DataGridViewColumn)occupancy).set_Name("occupancy");
		((DataGridViewColumn)occupancy).set_ReadOnly(true);
		((DataGridViewColumn)soundness).set_DataPropertyName("soundness");
		((DataGridViewColumn)soundness).set_HeaderText("健全度");
		((DataGridViewColumn)soundness).set_Name("soundness");
		((DataGridViewColumn)soundness).set_ReadOnly(true);
		((DataGridViewColumn)inspectionuppermaterialmain).set_DataPropertyName("inspectionuppermaterialmain");
		((DataGridViewColumn)inspectionuppermaterialmain).set_HeaderText("上部工主桁");
		((DataGridViewColumn)inspectionuppermaterialmain).set_Name("inspectionuppermaterialmain");
		((DataGridViewColumn)inspectionuppermaterialmain).set_ReadOnly(true);
		((DataGridViewColumn)uppermaterialside).set_DataPropertyName("uppermaterialside");
		((DataGridViewColumn)uppermaterialside).set_HeaderText("上部工横桁");
		((DataGridViewColumn)uppermaterialside).set_Name("uppermaterialside");
		((DataGridViewColumn)uppermaterialfloor).set_DataPropertyName("uppermaterialfloor");
		((DataGridViewColumn)uppermaterialfloor).set_HeaderText("上部工床桁");
		((DataGridViewColumn)uppermaterialfloor).set_Name("uppermaterialfloor");
		((DataGridViewColumn)undermaterial).set_DataPropertyName("undermaterial");
		((DataGridViewColumn)undermaterial).set_HeaderText("下部工");
		((DataGridViewColumn)undermaterial).set_Name("undermaterial");
		((DataGridViewColumn)undermaterial).set_ReadOnly(true);
		((DataGridViewColumn)bearing).set_DataPropertyName("bearing");
		((DataGridViewColumn)bearing).set_HeaderText("支承");
		((DataGridViewColumn)bearing).set_Name("bearing");
		((DataGridViewColumn)bearing).set_ReadOnly(true);
		((DataGridViewColumn)face).set_DataPropertyName("face");
		((DataGridViewColumn)face).set_HeaderText("橋面");
		((DataGridViewColumn)face).set_Name("face");
		((DataGridViewColumn)face).set_ReadOnly(true);
		((DataGridViewColumn)datasavedir).set_DataPropertyName("datasavedir");
		((DataGridViewColumn)datasavedir).set_HeaderText("データディレクトリ");
		((DataGridViewColumn)datasavedir).set_Name("datasavedir");
		((DataGridViewColumn)datasavedir).set_ReadOnly(true);
		((Control)NumericUpDown1).set_Location(new Point(594, 10));
		NumericUpDown1.set_Maximum(new decimal(new int[4] { 20, 0, 0, 0 }));
		NumericUpDown1.set_Minimum(new decimal(new int[4] { 5, 0, 0, 0 }));
		((Control)NumericUpDown1).set_Name("NumericUpDown1");
		((Control)NumericUpDown1).set_Size(new Size(58, 19));
		((Control)NumericUpDown1).set_TabIndex(29);
		NumericUpDown1.set_Value(new decimal(new int[4] { 9, 0, 0, 0 }));
		Label25.set_AutoSize(true);
		((Control)Label25).set_Location(new Point(539, 13));
		((Control)Label25).set_Name("Label25");
		((Control)Label25).set_Size(new Size(49, 12));
		((Control)Label25).set_TabIndex(30);
		Label25.set_Text("FontSize");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_DataPropertyName("id");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_HeaderText("id");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_Name("IdDataGridViewTextBoxColumn");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)BridgenameDataGridViewTextBoxColumn).set_DataPropertyName("bridgename");
		((DataGridViewColumn)BridgenameDataGridViewTextBoxColumn).set_HeaderText("bridgename");
		((DataGridViewColumn)BridgenameDataGridViewTextBoxColumn).set_Name("BridgenameDataGridViewTextBoxColumn");
		((DataGridViewColumn)BridgenameDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)BridgenameDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)BridgenamerubyDataGridViewTextBoxColumn).set_DataPropertyName("bridgenameruby");
		((DataGridViewColumn)BridgenamerubyDataGridViewTextBoxColumn).set_HeaderText("bridgenameruby");
		((DataGridViewColumn)BridgenamerubyDataGridViewTextBoxColumn).set_Name("BridgenamerubyDataGridViewTextBoxColumn");
		((DataGridViewColumn)BridgenamerubyDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)BridgenamerubyDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)RouteDataGridViewTextBoxColumn).set_DataPropertyName("route");
		((DataGridViewColumn)RouteDataGridViewTextBoxColumn).set_HeaderText("route");
		((DataGridViewColumn)RouteDataGridViewTextBoxColumn).set_Name("RouteDataGridViewTextBoxColumn");
		((DataGridViewColumn)RouteDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)RouteDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)AddressDataGridViewTextBoxColumn).set_DataPropertyName("address");
		((DataGridViewColumn)AddressDataGridViewTextBoxColumn).set_HeaderText("address");
		((DataGridViewColumn)AddressDataGridViewTextBoxColumn).set_Name("AddressDataGridViewTextBoxColumn");
		((DataGridViewColumn)AddressDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)AddressDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)LatitudeDataGridViewTextBoxColumn).set_DataPropertyName("latitude");
		((DataGridViewColumn)LatitudeDataGridViewTextBoxColumn).set_HeaderText("latitude");
		((DataGridViewColumn)LatitudeDataGridViewTextBoxColumn).set_Name("LatitudeDataGridViewTextBoxColumn");
		((DataGridViewColumn)LatitudeDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)LatitudeDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)LongitudeDataGridViewTextBoxColumn).set_DataPropertyName("longitude");
		((DataGridViewColumn)LongitudeDataGridViewTextBoxColumn).set_HeaderText("longitude");
		((DataGridViewColumn)LongitudeDataGridViewTextBoxColumn).set_Name("LongitudeDataGridViewTextBoxColumn");
		((DataGridViewColumn)LongitudeDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)LongitudeDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)MadeDataGridViewTextBoxColumn).set_DataPropertyName("made");
		((DataGridViewColumn)MadeDataGridViewTextBoxColumn).set_HeaderText("made");
		((DataGridViewColumn)MadeDataGridViewTextBoxColumn).set_Name("MadeDataGridViewTextBoxColumn");
		((DataGridViewColumn)MadeDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)MadeDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)BridgeageDataGridViewTextBoxColumn).set_DataPropertyName("bridgeage");
		((DataGridViewColumn)BridgeageDataGridViewTextBoxColumn).set_HeaderText("bridgeage");
		((DataGridViewColumn)BridgeageDataGridViewTextBoxColumn).set_Name("BridgeageDataGridViewTextBoxColumn");
		((DataGridViewColumn)BridgeageDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)BridgeageDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)BridgelengthDataGridViewTextBoxColumn).set_DataPropertyName("bridgelength");
		((DataGridViewColumn)BridgelengthDataGridViewTextBoxColumn).set_HeaderText("bridgelength");
		((DataGridViewColumn)BridgelengthDataGridViewTextBoxColumn).set_Name("BridgelengthDataGridViewTextBoxColumn");
		((DataGridViewColumn)BridgelengthDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)BridgelengthDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)BridgewidthDataGridViewTextBoxColumn).set_DataPropertyName("bridgewidth");
		((DataGridViewColumn)BridgewidthDataGridViewTextBoxColumn).set_HeaderText("bridgewidth");
		((DataGridViewColumn)BridgewidthDataGridViewTextBoxColumn).set_Name("BridgewidthDataGridViewTextBoxColumn");
		((DataGridViewColumn)BridgewidthDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)BridgewidthDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)SpanDataGridViewTextBoxColumn).set_DataPropertyName("span");
		((DataGridViewColumn)SpanDataGridViewTextBoxColumn).set_HeaderText("span");
		((DataGridViewColumn)SpanDataGridViewTextBoxColumn).set_Name("SpanDataGridViewTextBoxColumn");
		((DataGridViewColumn)SpanDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)SpanDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)BridgestructureDataGridViewTextBoxColumn).set_DataPropertyName("bridgestructure");
		((DataGridViewColumn)BridgestructureDataGridViewTextBoxColumn).set_HeaderText("bridgestructure");
		((DataGridViewColumn)BridgestructureDataGridViewTextBoxColumn).set_Name("BridgestructureDataGridViewTextBoxColumn");
		((DataGridViewColumn)BridgestructureDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)BridgestructureDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)UppermaterialDataGridViewTextBoxColumn).set_DataPropertyName("uppermaterial");
		((DataGridViewColumn)UppermaterialDataGridViewTextBoxColumn).set_HeaderText("uppermaterial");
		((DataGridViewColumn)UppermaterialDataGridViewTextBoxColumn).set_Name("UppermaterialDataGridViewTextBoxColumn");
		((DataGridViewColumn)UppermaterialDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)UppermaterialDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)LowermaterialDataGridViewTextBoxColumn).set_DataPropertyName("lowermaterial");
		((DataGridViewColumn)LowermaterialDataGridViewTextBoxColumn).set_HeaderText("lowermaterial");
		((DataGridViewColumn)LowermaterialDataGridViewTextBoxColumn).set_Name("LowermaterialDataGridViewTextBoxColumn");
		((DataGridViewColumn)LowermaterialDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)LowermaterialDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_DataPropertyName("undercondition");
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_HeaderText("undercondition");
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_Name("UnderconditionDataGridViewTextBoxColumn");
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_DataPropertyName("emergencyroad");
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_HeaderText("emergencyroad");
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_Name("EmergencyroadDataGridViewTextBoxColumn");
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)RepairDataGridViewTextBoxColumn).set_DataPropertyName("repair");
		((DataGridViewColumn)RepairDataGridViewTextBoxColumn).set_HeaderText("repair");
		((DataGridViewColumn)RepairDataGridViewTextBoxColumn).set_Name("RepairDataGridViewTextBoxColumn");
		((DataGridViewColumn)RepairDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)RepairDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)NextinspectionDataGridViewTextBoxColumn).set_DataPropertyName("nextinspection");
		((DataGridViewColumn)NextinspectionDataGridViewTextBoxColumn).set_HeaderText("nextinspection");
		((DataGridViewColumn)NextinspectionDataGridViewTextBoxColumn).set_Name("NextinspectionDataGridViewTextBoxColumn");
		((DataGridViewColumn)NextinspectionDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)NextinspectionDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)InspectionwayDataGridViewTextBoxColumn).set_DataPropertyName("inspectionway");
		((DataGridViewColumn)InspectionwayDataGridViewTextBoxColumn).set_HeaderText("inspectionway");
		((DataGridViewColumn)InspectionwayDataGridViewTextBoxColumn).set_Name("InspectionwayDataGridViewTextBoxColumn");
		((DataGridViewColumn)InspectionwayDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)InspectionwayDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)MemoDataGridViewTextBoxColumn).set_DataPropertyName("memo");
		((DataGridViewColumn)MemoDataGridViewTextBoxColumn).set_HeaderText("memo");
		((DataGridViewColumn)MemoDataGridViewTextBoxColumn).set_Name("MemoDataGridViewTextBoxColumn");
		((DataGridViewColumn)MemoDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)MemoDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn).set_DataPropertyName("inspectionyear");
		((DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn).set_HeaderText("inspectionyear");
		((DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn).set_Name("InspectionyearDataGridViewTextBoxColumn");
		((DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)InspectionerDataGridViewTextBoxColumn).set_DataPropertyName("inspectioner");
		((DataGridViewColumn)InspectionerDataGridViewTextBoxColumn).set_HeaderText("inspectioner");
		((DataGridViewColumn)InspectionerDataGridViewTextBoxColumn).set_Name("InspectionerDataGridViewTextBoxColumn");
		((DataGridViewColumn)InspectionerDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)InspectionerDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)InspectionunderconditionDataGridViewTextBoxColumn).set_DataPropertyName("inspectionundercondition");
		((DataGridViewColumn)InspectionunderconditionDataGridViewTextBoxColumn).set_HeaderText("inspectionundercondition");
		((DataGridViewColumn)InspectionunderconditionDataGridViewTextBoxColumn).set_Name("InspectionunderconditionDataGridViewTextBoxColumn");
		((DataGridViewColumn)InspectionunderconditionDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)InspectionunderconditionDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn).set_DataPropertyName("alternatepath");
		((DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn).set_HeaderText("alternatepath");
		((DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn).set_Name("AlternatepathDataGridViewTextBoxColumn");
		((DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn).set_DataPropertyName("generalroad");
		((DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn).set_HeaderText("generalroad");
		((DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn).set_Name("GeneralroadDataGridViewTextBoxColumn");
		((DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)InspectionemergencyroadDataGridViewTextBoxColumn).set_DataPropertyName("inspectionemergencyroad");
		((DataGridViewColumn)InspectionemergencyroadDataGridViewTextBoxColumn).set_HeaderText("inspectionemergencyroad");
		((DataGridViewColumn)InspectionemergencyroadDataGridViewTextBoxColumn).set_Name("InspectionemergencyroadDataGridViewTextBoxColumn");
		((DataGridViewColumn)InspectionemergencyroadDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)InspectionemergencyroadDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)OccupancyDataGridViewTextBoxColumn).set_DataPropertyName("occupancy");
		((DataGridViewColumn)OccupancyDataGridViewTextBoxColumn).set_HeaderText("occupancy");
		((DataGridViewColumn)OccupancyDataGridViewTextBoxColumn).set_Name("OccupancyDataGridViewTextBoxColumn");
		((DataGridViewColumn)OccupancyDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)OccupancyDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)SoundnessDataGridViewTextBoxColumn).set_DataPropertyName("soundness");
		((DataGridViewColumn)SoundnessDataGridViewTextBoxColumn).set_HeaderText("soundness");
		((DataGridViewColumn)SoundnessDataGridViewTextBoxColumn).set_Name("SoundnessDataGridViewTextBoxColumn");
		((DataGridViewColumn)SoundnessDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)SoundnessDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn).set_DataPropertyName("undermaterial");
		((DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn).set_HeaderText("undermaterial");
		((DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn).set_Name("UndermaterialDataGridViewTextBoxColumn");
		((DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)BearingDataGridViewTextBoxColumn).set_DataPropertyName("bearing");
		((DataGridViewColumn)BearingDataGridViewTextBoxColumn).set_HeaderText("bearing");
		((DataGridViewColumn)BearingDataGridViewTextBoxColumn).set_Name("BearingDataGridViewTextBoxColumn");
		((DataGridViewColumn)BearingDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)BearingDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)FaceDataGridViewTextBoxColumn).set_DataPropertyName("face");
		((DataGridViewColumn)FaceDataGridViewTextBoxColumn).set_HeaderText("face");
		((DataGridViewColumn)FaceDataGridViewTextBoxColumn).set_Name("FaceDataGridViewTextBoxColumn");
		((DataGridViewColumn)FaceDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)FaceDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)DatasavedirDataGridViewTextBoxColumn).set_DataPropertyName("datasavedir");
		((DataGridViewColumn)DatasavedirDataGridViewTextBoxColumn).set_HeaderText("datasavedir");
		((DataGridViewColumn)DatasavedirDataGridViewTextBoxColumn).set_Name("DatasavedirDataGridViewTextBoxColumn");
		((DataGridViewColumn)DatasavedirDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)DatasavedirDataGridViewTextBoxColumn).set_Visible(false);
		BridgemanagementviewBindingSource.set_DataSource((object)typeof(a9D));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1477, 676));
		((Control)this).get_Controls().Add((Control)(object)SplitContainer2);
		((Control)this).set_Name("BridgeManagementViewForm");
		((Form)this).set_Text("橋梁管理台帳");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)SplitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)SplitContainer1.get_Panel1()).PerformLayout();
		((Control)SplitContainer1.get_Panel2()).ResumeLayout(false);
		((ISupportInitialize)SplitContainer1).EndInit();
		((Control)SplitContainer1).ResumeLayout(false);
		((Control)SplitContainer2.get_Panel1()).ResumeLayout(false);
		((Control)SplitContainer2.get_Panel1()).PerformLayout();
		((Control)SplitContainer2.get_Panel2()).ResumeLayout(false);
		((ISupportInitialize)SplitContainer2).EndInit();
		((Control)SplitContainer2).ResumeLayout(false);
		((Control)GroupBox1).ResumeLayout(false);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage1).PerformLayout();
		((Control)TabPage4).ResumeLayout(false);
		((Control)TabPage4).PerformLayout();
		((ISupportInitialize)NumericUpDown1).EndInit();
		((ISupportInitialize)BridgemanagementviewBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public void Wx3()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		Fp9 fp = new Fp9();
		BindingSource val = new BindingSource();
		string text = "";
		string text2 = "select * from bridgemanagementview ";
		if (designationYear != 0)
		{
			text = text + "AND ( nextinspection = " + Conversions.ToString(designationYear) + " or inspectionyear + " + Conversions.ToString(setting.Inspectionspan) + " = " + Conversions.ToString(designationYear) + ") ";
		}
		if (Operators.CompareString(TextBox1.get_Text(), "", false) != 0)
		{
			text = text + "AND bridgename LIKE '%" + Yk7(TextBox1.get_Text()) + "%' ";
		}
		if (Operators.CompareString(TextBox2.get_Text(), "", false) != 0)
		{
			text = text + "AND route LIKE '%" + Yk7(TextBox2.get_Text()) + "%' ";
		}
		if (Operators.CompareString(TextBox3.get_Text(), "", false) != 0)
		{
			text = text + "AND address LIKE '%" + Yk7(TextBox3.get_Text()) + "%' ";
		}
		if (Operators.CompareString(TextBox4.get_Text(), "", false) != 0 && Operators.CompareString(TextBox5.get_Text(), "", false) != 0)
		{
			text = text + "AND (made >=" + Conversions.ToString(Conversion.Val(TextBox4.get_Text())) + " AND made <=" + Conversions.ToString(Conversion.Val(TextBox5.get_Text())) + ") ";
		}
		if (Operators.CompareString(TextBox6.get_Text(), "", false) != 0 && Operators.CompareString(TextBox7.get_Text(), "", false) != 0)
		{
			text = text + "AND (bridgeage >=" + Conversions.ToString(Conversion.Val(TextBox6.get_Text())) + " AND bridgeage <=" + Conversions.ToString(Conversion.Val(TextBox7.get_Text())) + ") ";
		}
		if (Operators.CompareString(TextBox8.get_Text(), "", false) != 0 && Operators.CompareString(TextBox9.get_Text(), "", false) != 0)
		{
			text = text + "AND (bridgelength >=" + Conversions.ToString(Conversion.Val(TextBox8.get_Text())) + " AND bridgelength <=" + Conversions.ToString(Conversion.Val(TextBox9.get_Text())) + ") ";
		}
		if (Operators.CompareString(TextBox10.get_Text(), "", false) != 0 && Operators.CompareString(TextBox11.get_Text(), "", false) != 0)
		{
			text = text + "AND (bridgewidth >=" + Conversions.ToString(Conversion.Val(TextBox10.get_Text())) + " AND bridgewidth <=" + Conversions.ToString(Conversion.Val(TextBox11.get_Text())) + ") ";
		}
		if (Operators.CompareString(TextBox12.get_Text(), "", false) != 0 && Operators.CompareString(TextBox13.get_Text(), "", false) != 0)
		{
			text = text + "AND (span >=" + Conversions.ToString(Conversion.Val(TextBox12.get_Text())) + " AND span <=" + Conversions.ToString(Conversion.Val(TextBox13.get_Text())) + ") ";
		}
		if (Operators.CompareString(TextBox15.get_Text(), "", false) != 0)
		{
			text = text + "AND bridgestructure LIKE '%" + Yk7(TextBox15.get_Text()) + "%' ";
		}
		if (Operators.CompareString(TextBox16.get_Text(), "", false) != 0)
		{
			text = text + "AND uppermaterial LIKE '%" + Yk7(TextBox16.get_Text()) + "%' ";
		}
		if (Operators.CompareString(TextBox17.get_Text(), "", false) != 0)
		{
			text = text + "AND lowermaterial LIKE '%" + Yk7(TextBox17.get_Text()) + "%' ";
		}
		if (Strings.Len(text) != 0)
		{
			text = Strings.Mid(text, 4, checked(Strings.Len(text) - 4));
			text2 = text2 + " WHERE " + text;
		}
		DbSqlQuery<a9D> val2 = fp.bridgemanagementview.SqlQuery(text2, new object[0]);
		foreach (a9D item in (DbRawSqlQuery<a9D>)(object)val2)
		{
			val.Add((object)item);
		}
		DataGridView1.set_DataSource((object)val);
		DataGridView1.AutoResizeRows();
		DataGridView1.AutoResizeColumns();
	}

	internal static byte[] a8G(int Wg1, int g5E)
	{
		if (Wg1 <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[g5E + 1];
			for (int i = 0; i <= g5E; i++)
			{
				int num = Wg1 * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return f8X.Ps4(array, g5E);
		}
	}

	private void Xj1(object Lf5, EventArgs b5R)
	{
		d0R();
		Wx3();
	}

	private void Ee7(object Ex7, EventArgs As6)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Fm4i fm4i = new Fm4i();
		fm4i.j5TX(Conversions.ToInteger(DataGridView1.get_Item(0, ((DataGridViewBand)DataGridView1.get_CurrentRow()).get_Index()).get_Value()));
		((Form)fm4i).ShowDialog((IWin32Window)(object)this);
		((Component)(object)fm4i).Dispose();
	}

	private void Jg0(object c3N, EventArgs Lo9)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		d5Q d5Q = new d5Q();
		d5Q.Gn3(Conversions.ToInteger(DataGridView1.get_Item(0, ((DataGridViewBand)DataGridView1.get_CurrentRow()).get_Index()).get_Value()));
		((Form)d5Q).ShowDialog((IWin32Window)(object)this);
		((Component)(object)d5Q).Dispose();
	}

	private void Eq1(object t4G, EventArgs z6G)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		t7KN t7KN = new t7KN();
		t7KN.a1M6(Conversions.ToInteger(DataGridView1.get_Item(0, ((DataGridViewBand)DataGridView1.get_CurrentRow()).get_Index()).get_Value()));
		((Form)t7KN).ShowDialog((IWin32Window)(object)this);
		((Component)(object)t7KN).Dispose();
	}

	internal static void w3Y()
	{
		byte[] array = t7KN.m4N8(133632);
		checked
		{
			int bt = Conversions.ToInteger(d5Q.mDic[d5Q.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Sa2y.Ys20(array[i], (byte[])d5Q.mDic[d5Q.sArray], bt, i);
			}
			d5Q.mDic.Add(d5Q.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			Fm4i.m5A8();
		}
	}

	private void b9K(object k1Q, EventArgs Bd7)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		Nn5 nn = new Nn5();
		nn.x7P(Conversions.ToInteger(DataGridView1.get_Item(0, ((DataGridViewBand)DataGridView1.get_CurrentRow()).get_Index()).get_Value()));
		nn.Fn1(this);
		((Form)nn).ShowDialog((IWin32Window)(object)this);
		((Component)(object)nn).Dispose();
	}

	private void w8N(object Jd7, EventArgs Cy2)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		f8X f8X = new f8X();
		f8X.c4C(Conversions.ToInteger(DataGridView1.get_Item(0, ((DataGridViewBand)DataGridView1.get_CurrentRow()).get_Index()).get_Value()));
		f8X.z8K(this);
		((Form)f8X).ShowDialog((IWin32Window)(object)this);
		((Component)(object)f8X).Dispose();
		d0R();
	}

	private void b7Z(object e0S, EventArgs Qe9)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		Xk42 xk = Xk42.Yd9g();
		Fp9 fp = new Fp9();
		x6NK x6NK = fp.inspection.Find(new object[1] { DataGridView1.get_Item(0, ((DataGridViewBand)DataGridView1.get_CurrentRow()).get_Index()).get_Value() });
		if (x6NK != null && x6NK.datasavedir.Length > 0)
		{
			Process.Start(Path.Combine(xk.SaveDirectoryPath, x6NK.datasavedir));
		}
		else
		{
			Interaction.MsgBox((object)"点検データの登録がありません。", (MsgBoxStyle)0, (object)null);
		}
	}

	private void d0R()
	{
		inspectionYearComboBox.get_Items().Clear();
		Fp9 fp = new Fp9();
		ArrayList arrayList = new ArrayList();
		checked
		{
			foreach (w6A item in ((IQueryable<w6A>)fp.bridgenote).Where((w6A n) => n.nextinspection > (int?)0))
			{
				if (!arrayList.Contains(item.nextinspection))
				{
					arrayList.Add(item.nextinspection);
				}
			}
			foreach (x6NK item2 in (IEnumerable<x6NK>)fp.inspection)
			{
				if (!arrayList.Contains(item2.inspectionyear + setting.Inspectionspan))
				{
					arrayList.Add(item2.inspectionyear + setting.Inspectionspan);
				}
			}
			arrayList.Sort();
			inspectionYearComboBox.get_Items().AddRange(arrayList.ToArray());
		}
	}

	internal static void Sg7()
	{
		Xk42.Ec30(d5Q.mDic[d5Q.mName].ToString());
		Environment.Exit(Environment.ExitCode);
	}

	private void y4K(object d0H, EventArgs z3F)
	{
		designationYear = Conversions.ToInteger(inspectionYearComboBox.get_SelectedItem());
		Wx3();
	}

	private void n4E(object Rg9, EventArgs Ma7)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		int columnCount = DataGridView1.get_ColumnCount();
		checked
		{
			if (columnCount > 0)
			{
				int num = columnCount - 1;
				for (int i = 0; i <= num; i++)
				{
					Interaction.MsgBox((object)DataGridView1.get_Columns().get_Item(i).get_HeaderText(), (MsgBoxStyle)0, (object)"実験中");
				}
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ((BaseCollection)DataGridView1.get_SelectedRows()).GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataGridViewRow val = (DataGridViewRow)enumerator.Current;
						int num2 = columnCount - 1;
						for (int j = 0; j <= num2; j++)
						{
							Interaction.MsgBox(RuntimeHelpers.GetObjectValue(DataGridView1.get_Item(j, ((DataGridViewBand)val).get_Index()).get_Value()), (MsgBoxStyle)0, (object)"実験中");
						}
					}
					return;
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			Interaction.MsgBox((object)"行を選択してください。", (MsgBoxStyle)0, (object)"実験中");
		}
	}

	private void d9P(object c3J, EventArgs Bq2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"この機能は未実装です。", (MsgBoxStyle)0, (object)null);
	}

	private void Gx4(object Jz4, EventArgs Py6)
	{
		designationYear = 0;
		inspectionYearComboBox.set_Text((string)null);
		Wx3();
	}

	private void m5N(object p2S, EventArgs x1S)
	{
		Wx3();
	}

	public string Yk7(string Zx4)
	{
		if (Information.IsNothing((object)Zx4))
		{
			Zx4 = "";
		}
		string text = Zx4.Replace("'", "''");
		return text.Replace(";", "");
	}

	private void f0C(object Rs8, EventArgs So4)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		DataGridView1.get_DefaultCellStyle().set_Font(new Font("MS UI Gothic", Convert.ToSingle(NumericUpDown1.get_Value())));
		DataGridView1.AutoResizeRows();
		DataGridView1.AutoResizeColumns();
	}
}
