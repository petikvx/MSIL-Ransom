using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace GraphComposite;

public class MainForm : Form
{
	public static string[] Al_j2023008 = new string[3] { "73766E75", "796A72", "GraphComposite" };

	private IContainer components = null;

	private Button btnRoll;

	private ListBox lstResults;

	public MainForm()
	{
		InitializeComponent();
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		MainForm.smethod_2(MainForm.smethod_1("This program simulates the rolling of two dice 100 times.", MainForm.smethod_0(), MainForm.smethod_0(), "Whenever the two dice display the same number, the program will show the roll sequence number and the number on the dice."));
	}

	private void btnRoll_Click(object sender, EventArgs e)
	{
		Random random_ = MainForm.smethod_3();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		MainForm.smethod_5(MainForm.smethod_4(lstResults));
		for (int i = 1; i <= 100; i++)
		{
			num = MainForm.smethod_6(random_, 1, 7);
			num2 = MainForm.smethod_6(random_, 1, 7);
			if (num == num2)
			{
				num3++;
				MainForm.smethod_8(MainForm.smethod_4(lstResults), (object)MainForm.smethod_7(new string[5]
				{
					"Roll ",
					i.ToString(),
					" produced a pair of ",
					num.ToString(),
					"s"
				}));
				if (num3 > 1 && i == 100)
				{
					MainForm.smethod_8(MainForm.smethod_4(lstResults), (object)MainForm.smethod_9("Nice, ", num3.ToString(), " in a row"));
				}
			}
			else
			{
				if (num3 > 1)
				{
					MainForm.smethod_8(MainForm.smethod_4(lstResults), (object)MainForm.smethod_9("Nice, ", num3.ToString(), " in a row"));
				}
				num3 = 0;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			MainForm.smethod_10((IDisposable)components);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager resourceManager_ = MainForm.smethod_12(MainForm.smethod_11(typeof(MainForm).TypeHandle));
		btnRoll = MainForm.smethod_13();
		lstResults = MainForm.smethod_14();
		MainForm.smethod_15((Control)(object)this);
		MainForm.smethod_17((Control)(object)btnRoll, MainForm.smethod_16("Baskerville Old Face", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		MainForm.smethod_18((Control)(object)btnRoll, new Point(237, 29));
		MainForm.smethod_19((Control)(object)btnRoll, new Padding(8, 7, 8, 7));
		MainForm.smethod_20((Control)(object)btnRoll, "btnRoll");
		MainForm.smethod_21((Control)(object)btnRoll, new Size(259, 117));
		MainForm.smethod_22((Control)(object)btnRoll, 0);
		MainForm.smethod_23((Control)(object)btnRoll, "Roll the dice");
		MainForm.smethod_24((ButtonBase)(object)btnRoll, bool_0: true);
		MainForm.smethod_25((Control)(object)btnRoll, (EventHandler)btnRoll_Click);
		MainForm.smethod_26((ListControl)(object)lstResults, bool_0: true);
		MainForm.smethod_27(lstResults, 31);
		MainForm.smethod_18((Control)(object)lstResults, new Point(56, 160));
		MainForm.smethod_19((Control)(object)lstResults, new Padding(8, 7, 8, 7));
		MainForm.smethod_20((Control)(object)lstResults, "lstResults");
		MainForm.smethod_21((Control)(object)lstResults, new Size(628, 407));
		MainForm.smethod_22((Control)(object)lstResults, 1);
		MainForm.smethod_28((ContainerControl)(object)this, new SizeF(16f, 31f));
		MainForm.smethod_29((ContainerControl)(object)this, (AutoScaleMode)1);
		MainForm.smethod_30((Form)(object)this, new Size(779, 622));
		MainForm.smethod_32(MainForm.smethod_31((Control)(object)this), (Control)(object)lstResults);
		MainForm.smethod_32(MainForm.smethod_31((Control)(object)this), (Control)(object)btnRoll);
		MainForm.smethod_34((Form)(object)this, (Icon)MainForm.smethod_33((ResourceManager)resourceManager_, "$this.Icon"));
		MainForm.smethod_35((Form)(object)this, new Padding(8, 7, 8, 7));
		MainForm.smethod_36((Control)(object)this, "MainForm");
		MainForm.smethod_23((Control)(object)this, "Dice Simulation");
		MainForm.smethod_37((Form)(object)this, (EventHandler)MainForm_Load);
		MainForm.smethod_38((Control)(object)this, bool_0: false);
	}

	static string smethod_0()
	{
		return Environment.NewLine;
	}

	static string smethod_1(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static DialogResult smethod_2(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static Random smethod_3()
	{
		return new Random();
	}

	static ObjectCollection smethod_4(ListBox listBox_0)
	{
		return listBox_0.get_Items();
	}

	static void smethod_5(ObjectCollection objectCollection_0)
	{
		objectCollection_0.Clear();
	}

	static int smethod_6(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	static string smethod_7(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static int smethod_8(ObjectCollection objectCollection_0, object object_0)
	{
		return objectCollection_0.Add(object_0);
	}

	static string smethod_9(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static void smethod_10(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_12(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static Button smethod_13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static ListBox smethod_14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ListBox();
	}

	static void smethod_15(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static Font smethod_16(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_17(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_18(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_19(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_20(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_21(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_22(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_23(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_24(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_25(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_26(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static void smethod_27(ListBox listBox_0, int int_0)
	{
		listBox_0.set_ItemHeight(int_0);
	}

	static void smethod_28(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_29(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_30(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_31(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_32(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static object smethod_33(ResourceManager resourceManager_0, string string_0)
	{
		return resourceManager_0.GetObject(string_0);
	}

	static void smethod_34(Form form_0, Icon icon_0)
	{
		form_0.set_Icon(icon_0);
	}

	static void smethod_35(Form form_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_Margin(padding_0);
	}

	static void smethod_36(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_37(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_38(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
