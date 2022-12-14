using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Vip_Auto_Kill_PointBlank_Eagine_Pro.My.Resources;

namespace Vip_Auto_Kill_PointBlank_Eagine_Pro;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	private string reg;

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2
	{
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer3
	{
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (_Timer3 != null)
			{
				_Timer3.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			if (_Timer3 != null)
			{
				_Timer3.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label15
	{
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label15 = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click_2;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label Label6
	{
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label5
	{
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual Label Label14
	{
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual Label Label7
	{
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Label Label9
	{
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual Label Label11
	{
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual Label Label12
	{
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label12 = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		reg = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "SystemRoot", string.Empty));
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected O, but got Unknown
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected O, but got Unknown
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Expected O, but got Unknown
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected O, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected O, but got Unknown
		//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Expected O, but got Unknown
		//IL_0a8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a98: Expected O, but got Unknown
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c56: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		Label1 = new Label();
		Label15 = new Label();
		Button1 = new Button();
		ListBox1 = new ListBox();
		GroupBox1 = new GroupBox();
		Label6 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label14 = new Label();
		Label7 = new Label();
		Label9 = new Label();
		Label11 = new Label();
		Label12 = new Label();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		Timer3.set_Interval(6000);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Arial", 11.25f, (FontStyle)1));
		Label label = Label1;
		Point location = new Point(51, 16);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(239, 18);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("???????????????????????????\u0e49????????????\u0e49???????????????\u0e38????????????\u0e49???????????????\u0e4c");
		Label15.set_AutoSize(true);
		Label label3 = Label15;
		location = new Point(14, 45);
		((Control)label3).set_Location(location);
		((Control)Label15).set_Name("Label15");
		Label label4 = Label15;
		size = new Size(0, 13);
		((Control)label4).set_Size(size);
		((Control)Label15).set_TabIndex(10);
		((Control)Button1).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button button = Button1;
		location = new Point(14, 632);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(340, 27);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(12);
		((ButtonBase)Button1).set_Text("???\u0e49???\u0e49?????????????????????\u0e4c??????\u0e49??????\u0e31????????????????????????\u0e49?????????");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		ListBox1.set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox1.set_ItemHeight(14);
		ListBox1.get_Items().AddRange(new object[36]
		{
			"??? 1. ????????????????????? ?????????\u0e31??? 1-9 ????????????\u0e34??? F1/F2", "??? 2. ??????????????????\u0e35\u0e48???\u0e39?????????\u0e48??????\u0e35???HP ????????????\u0e34??? F1/F2", "??? 3. ??????\u0e48?????????????????????\u0e34??????\u0e31???????????? ????????????\u0e34??? F1/F2", "??? 4. ????????????????????????\u0e48?????? 3 ?????????\u0e35 ????????????\u0e34??? F3", "??? 5. ????????????????????????\u0e48?????? 7 ?????????\u0e35 ????????????\u0e34??? F4", "??? 6. ????????????????????????\u0e48?????? 10 ?????????\u0e35 ????????????\u0e34??? F5", "??? 7. ????????????????????????\u0e48?????? 20 ?????????\u0e35 ????????????\u0e34??? F6", "??? 8. ????????????????????????\u0e48?????? 30 ?????????\u0e35 ????????????\u0e34??? F7", "??? 9. ????????????????????????\u0e48?????? 15 ?????????\u0e35 ????????????\u0e34??? F8", "??? 10. ????????????????????????\u0e48?????? 25 ?????????\u0e35 ????????????\u0e34??? F9",
			"*???\u0e34???\u0e35??????\u0e49 ???????????????????????????\u0e49?????????\u0e49????????????????????????\u0e34", "F3-F9 ???\u0e35\u0e48???\u0e49??????????????????????????????\u0e49????????????\u0e31\u0e49??????\u0e48???????????????\u0e4c ???\u0e37??????\u0e35???", "??? 11. ??????????????????\u0e31??? 10 ???\u0e31?????????\u0e48????????? ???\u0e31????????????\u0e31???", "??? 12. ??????\u0e38?????????????????????\u0e31??? 10 ???\u0e31????????????\u0e31???", "??? 13. ??????\u0e37????????????????????????\u0e31??? 10 ??????\u0e37???????????????\u0e37??? HP1 ???\u0e31????????????\u0e31???", "??? 14. ???\u0e35??????\u0e31???????????? (????????????+4) ?????????\u0e31????????????\u0e31\u0e48????????? ???\u0e31????????????\u0e31???", "??? 15. ?????????????????????\u0e39?????????\u0e48?????????\u0e31??? ???\u0e31????????????\u0e31???", "??? 16. ??????\u0e34?????????\u0e47?????????\u0e48???\u0e49????????????????????????  ???\u0e31????????????\u0e31???", "??? 17. ???\u0e37??????\u0e31???????????? ???\u0e31????????????\u0e31??? ", "??? 18. ???\u0e37??????\u0e31???????????????\u0e31??? ???\u0e31????????????\u0e31???",
			"??? 19. ????????????\u0e49????????? (???\u0e34??????????????????\u0e37\u0e48?????????\u0e49??????\u0e35\u0e49) ???\u0e31????????????\u0e31???", "??? 20. ?????????\u0e35\u0e48???????????????\u0e38?????????\u0e48???\u0e35???\u0e35??????  ???\u0e31????????????\u0e31???", "??? 21. ???\u0e35??????\u0e31???(??????\u0e34????????????) ??????\u0e34??? Delete / ???\u0e34??? End", "??? 22. ??????\u0e48??????\u0e49???????????????\u0e49????????????\u0e37\u0e48?????????\u0e48??????\u0e31???????????????\u0e4c  ???\u0e31????????????\u0e31???", "??? 23. ??????\u0e47????????????\u0e38\u0e4d??????\u0e37??????\u0e49??????????????????\u0e49????????????\u0e49 ???\u0e31????????????\u0e31???", "??? 24. ???????????????\u0e37\u0e48??????\u0e39\u0e49??????\u0e48??? ?????????-???\u0e49?????????\u0e34??? ???\u0e31????????????\u0e31???", "??? 25. ??????????????????\u0e37?????? HP ?????????-???\u0e49?????????\u0e34??? ???\u0e31????????????\u0e31???", "??? 26. ???\u0e37?????????\u0e48???\u0e35??? (???\u0e36\u0e49???/??????) ???\u0e31????????????\u0e31???", "??? 27. ???\u0e37??????\u0e39??????????????????\u0e48?????????????????? (????????????\u0e38?????????\u0e47???) ???\u0e31????????????\u0e31???", "??? 28. ????????????\u0e38?????????\u0e48?????????\u0e31??? ??????\u0e47?????????\u0e31??? ???\u0e31????????????\u0e31???",
			"??? 29. ?????????????????????\u0e49?????????????????????????????????\u0e4c???\u0e31??????\u0e35 Home", "??? 30. ??????????????????\u0e38??????????????? (??????\u0e34???Shift/???\u0e34???E) Windows 7", "??? 31. ??????\u0e48????????????\u0e38?????????\u0e48???\u0e35???\u0e35?????? ???\u0e31????????????\u0e31???", "??? 32. ???\u0e34??????\u0e31???x10  (??????\u0e34???/???\u0e34??? Insert)", "??? 33. ??????????????????\u0e31??? 9 ?????? PageUP/????????????\u0e36\u0e49??????\u0e39???", "??? 34. ??????????????????\u0e31??? 1 ?????? PageDown/??????????????????\u0e37\u0e49???"
		});
		ListBox listBox = ListBox1;
		location = new Point(17, 102);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		size = new Size(344, 508);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(14);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		GroupBox groupBox = GroupBox1;
		location = new Point(11, 3);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(350, 39);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(15);
		GroupBox1.set_TabStop(false);
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Arial", 11.25f, (FontStyle)1));
		Label label5 = Label6;
		location = new Point(6, -3);
		((Control)label5).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label6 = Label6;
		size = new Size(51, 18);
		((Control)label6).set_Size(size);
		((Control)Label6).set_TabIndex(20);
		Label6.set_Text("???????????????");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Arial", 11.25f, (FontStyle)1));
		((Control)Label2).set_ForeColor(Color.Red);
		Label label7 = Label2;
		location = new Point(14, 45);
		((Control)label7).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label8 = Label2;
		size = new Size(104, 18);
		((Control)label8).set_Size(size);
		((Control)Label2).set_TabIndex(16);
		Label2.set_Text("**???\u0e48????????????\u0e49?????????**");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label9 = Label3;
		location = new Point(14, 63);
		((Control)label9).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label10 = Label3;
		size = new Size(160, 15);
		((Control)label10).set_Size(size);
		((Control)Label3).set_TabIndex(17);
		Label3.set_Text("1. ???\u0e34???????????????\u0e35\u0e49?????????\u0e31??????\u0e48????????????\u0e49?????????");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label11 = Label4;
		location = new Point(13, 78);
		((Control)label11).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label12 = Label4;
		size = new Size(257, 15);
		((Control)label12).set_Size(size);
		((Control)Label4).set_TabIndex(18);
		Label4.set_Text("2. ???\u0e34????????????\u0e4c 7 / 8 ??????\u0e34???????????????\u0e31???????????????\u0e34??????\u0e49??????????????????\u0e31???");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.Red);
		Label label13 = Label5;
		location = new Point(89, 662);
		((Control)label13).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label14 = Label5;
		size = new Size(200, 16);
		((Control)label14).set_Size(size);
		((Control)Label5).set_TabIndex(19);
		Label5.set_Text("http://dcn-mode.blogspot.com/");
		Label14.set_AutoSize(true);
		((Control)Label14).set_Font(new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label14).set_ForeColor(Color.Red);
		Label label15 = Label14;
		location = new Point(14, 613);
		((Control)label15).set_Location(location);
		((Control)Label14).set_Name("Label14");
		Label label16 = Label14;
		size = new Size(340, 16);
		((Control)label16).set_Size(size);
		((Control)Label14).set_TabIndex(28);
		Label14.set_Text("???????????????\u0e31\u0e48??? ????????????\u0e49?????????\u0e31??????\u0e35 ??????\u0e49???????????????\u0e48??????\u0e49????????????\u0e34?????????\u0e48??????\u0e49 ????????????\u0e48??????\u0e49???????????????\u0e48");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.White);
		((Control)Label7).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.Red);
		Label label17 = Label7;
		location = new Point(199, 553);
		((Control)label17).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label18 = Label7;
		size = new Size(43, 14);
		((Control)label18).set_Size(size);
		((Control)Label7).set_TabIndex(31);
		Label7.set_Text("*??????\u0e49??????");
		Label9.set_AutoSize(true);
		((Control)Label9).set_BackColor(Color.White);
		((Control)Label9).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.Red);
		Label label19 = Label9;
		location = new Point(246, 469);
		((Control)label19).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label20 = Label9;
		size = new Size(43, 14);
		((Control)label20).set_Size(size);
		((Control)Label9).set_TabIndex(33);
		Label9.set_Text("*??????\u0e49??????");
		Label11.set_AutoSize(true);
		((Control)Label11).set_BackColor(Color.White);
		((Control)Label11).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_ForeColor(Color.Red);
		Label label21 = Label11;
		location = new Point(246, 455);
		((Control)label21).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label22 = Label11;
		size = new Size(43, 14);
		((Control)label22).set_Size(size);
		((Control)Label11).set_TabIndex(34);
		Label11.set_Text("*??????\u0e49??????");
		Label12.set_AutoSize(true);
		((Control)Label12).set_BackColor(Color.White);
		((Control)Label12).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label12).set_ForeColor(Color.Red);
		Label label23 = Label12;
		location = new Point(246, 441);
		((Control)label23).set_Location(location);
		((Control)Label12).set_Name("Label12");
		Label label24 = Label12;
		size = new Size(43, 14);
		((Control)label24).set_Size(size);
		((Control)Label12).set_TabIndex(35);
		Label12.set_Text("*??????\u0e49??????");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_AutoValidate((AutoValidate)0);
		((Form)this).set_BackColor(Color.Silver);
		((Control)this).set_CausesValidation(false);
		size = new Size(379, 678);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label12);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label14);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Label15);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text(" DCNPB #18.2 28-3-2557 ??? ");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int VirtualAllocEx(int hProcess, int lpAddress, int dwSize, int flAllocationType, int flProtect);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int nSize, uint lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetProcAddress(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpProcName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpModuleName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CreateRemoteThread(int hProcess, int lpThreadAttributes, int dwStackSize, int lpStartAddress, int lpParameter, int dwCreationFlags, int lpThreadId);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int WaitForSingleObject(int hHandle, int dwMilliseconds);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CloseHandle(int hObject);

	private bool Inject(int pID, string dllLocation)
	{
		if (IntPtr.Size == 8)
		{
			throw new ArgumentException("Please make sure this program is compiled as x86, not x64. Memory functions don't work so well otherwise.");
		}
		if (!File.Exists(dllLocation))
		{
			throw new FileNotFoundException("Please make sure your dll actually exists!");
		}
		int num = OpenProcess(2035711, 1, pID);
		if (num == 0)
		{
			return false;
		}
		byte[] bytes = Encoding.ASCII.GetBytes(dllLocation);
		int num2 = VirtualAllocEx(num, 0, bytes.Length, 4096, 4);
		if (num2 == 0)
		{
			return false;
		}
		string lpModuleName = "kernel32.dll";
		int moduleHandleA = GetModuleHandleA(ref lpModuleName);
		lpModuleName = "LoadLibraryA";
		int procAddress = GetProcAddress(moduleHandleA, ref lpModuleName);
		if (moduleHandleA != 0 && procAddress != 0)
		{
			WriteProcessMemory(num, num2, bytes, bytes.Length, 0u);
			int num3 = CreateRemoteThread(num, 0, 0, procAddress, num2, 0, 0);
			if (num3 == 0)
			{
				return false;
			}
			WaitForSingleObject(num3, 5000);
			CloseHandle(num3);
			CloseHandle(num);
			return true;
		}
		return false;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Process.Start("http://dcn-mode.blogspot.com/");
		try
		{
			string path = reg + "\\System32\\drivers\\Update33.dll";
			File.Delete(path);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Timer1.Start();
		Timer2.Start();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("PointBlank");
			if (processesByName.Length == 1)
			{
				int id = Process.GetProcessesByName("PointBlank")[0].Id;
				Inject(id, reg + "\\System32\\drivers\\Update33.dll");
				Label1.set_Text("????????????????????????????????????????????????\u0e47?????????\u0e49???!!");
				Timer3.Start();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("HSUpdate");
			if (processesByName.Length == 1)
			{
				_ = Process.GetProcessesByName("HSUpdate")[0].Id;
				string path = reg + "\\System32\\drivers\\Update33.dll";
				File.WriteAllBytes(path, Resources.Update33);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
	}

	private void Button1_Click_2(object sender, EventArgs e)
	{
		Process.Start("http://dcn-mode.blogspot.com/");
	}

	private void Button2_Click_1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Process.Start("http://dcn-mode.blogspot.com/");
	}
}
