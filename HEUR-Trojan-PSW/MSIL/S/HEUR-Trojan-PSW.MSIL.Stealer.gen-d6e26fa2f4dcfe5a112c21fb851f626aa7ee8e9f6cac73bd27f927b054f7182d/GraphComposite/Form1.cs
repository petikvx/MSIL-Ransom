using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace GraphComposite;

public class Form1 : Form
{
	private LinkedList<MemoryElement> Memory = new LinkedList<MemoryElement>();

	private LinkedList<MemoryElement> save = new LinkedList<MemoryElement>();

	private LinkedList<MemoryElement> Processes = new LinkedList<MemoryElement>();

	private int pi = 0;

	private int hi = 0;

	private IContainer components = null;

	private Button button1;

	private TextBox textBox1;

	private Label label1;

	private TextBox textBox2;

	private Label label2;

	private Label label3;

	private Label label4;

	private TextBox textBox3;

	private Label label6;

	private Button button2;

	private Label label7;

	private Button button3;

	private Panel panel1;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private Label label8;

	private ComboBox comboBox1;

	private ListView listView1;

	private TabPage tabPage2;

	private ColumnHeader columnHeader1;

	private ColumnHeader columnHeader2;

	private ColumnHeader columnHeader3;

	private ColumnHeader columnHeader4;

	private Label label5;

	private ListView listView3;

	private ColumnHeader columnHeader6;

	private ColumnHeader columnHeader7;

	private ColumnHeader columnHeader8;

	private ListView listView2;

	private ColumnHeader columnHeader5;

	private ColumnHeader columnHeader9;

	private ColumnHeader columnHeader10;

	private TextBox textBox4;

	public Form1()
	{
		InitializeComponent();
		Form1.smethod_0((Control)(object)comboBox1, "Choose from here !");
		Form1.smethod_2(Form1.smethod_1(comboBox1), (object)"Best Fit");
		Form1.smethod_2(Form1.smethod_1(comboBox1), (object)"First Fit");
		Form1.smethod_2(Form1.smethod_1(comboBox1), (object)"Worst Fit");
		Form1.smethod_0((Control)(object)label5, Form1.smethod_3("Hole", hi.ToString()));
	}

	private void label6_Click(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		MemoryElement value = new MemoryElement(Form1.smethod_3("Hole", hi.ToString()), "Hole", Form1.smethod_5(Form1.smethod_4((Control)(object)textBox1)), Form1.smethod_5(Form1.smethod_4((Control)(object)textBox2)));
		Memory.AddLast(value);
		MemoryElement value2 = new MemoryElement(Form1.smethod_3("Hole", hi.ToString()), "Hole", Form1.smethod_5(Form1.smethod_4((Control)(object)textBox1)), Form1.smethod_5(Form1.smethod_4((Control)(object)textBox2)));
		save.AddLast(value2);
		hi++;
		Form1.smethod_0((Control)(object)label5, Form1.smethod_3("Hole", hi.ToString()));
		Form1.smethod_0((Control)(object)textBox1, "");
		Form1.smethod_0((Control)(object)textBox2, "");
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MemoryElement value = new MemoryElement(Form1.smethod_3("Process", pi.ToString()), "Process", 0, Form1.smethod_5(Form1.smethod_4((Control)(object)textBox3)));
		Processes.AddLast(value);
		pi++;
		Form1.smethod_0((Control)(object)textBox3, "");
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Form1.smethod_6((Control)(object)panel1, bool_0: true);
		Form1.smethod_6((Control)(object)label5, bool_0: false);
	}

	private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
	{
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		Form1.smethod_8(Form1.smethod_7(listView1));
		Form1.smethod_8(Form1.smethod_7(listView2));
		Form1.smethod_8(Form1.smethod_7(listView3));
		Form1.smethod_0((Control)(object)textBox4, "");
		IEnumerable<MemoryElement> source;
		if (!Form1.smethod_9(Form1.smethod_4((Control)(object)comboBox1), "Best Fit"))
		{
			if (!Form1.smethod_9(Form1.smethod_4((Control)(object)comboBox1), "First Fit"))
			{
				source = Memory.OrderByDescending((MemoryElement memoryElement) => memoryElement.size);
				Form1.smethod_11((TextBoxBase)(object)textBox4, Form1.smethod_3("You have chosen Worst Fit option !", Form1.smethod_10()));
			}
			else
			{
				source = Memory.OrderBy((MemoryElement memoryElement) => memoryElement.Base);
				Form1.smethod_11((TextBoxBase)(object)textBox4, Form1.smethod_3("You have chosen First Fit option !", Form1.smethod_10()));
			}
		}
		else
		{
			source = Memory.OrderBy((MemoryElement memoryElement) => memoryElement.size);
			Form1.smethod_11((TextBoxBase)(object)textBox4, Form1.smethod_3("You have chosen Best Fit option", Form1.smethod_10()));
		}
		List<MemoryElement> list = source.ToList();
		foreach (MemoryElement process in Processes)
		{
			foreach (MemoryElement item in list)
			{
				if (Form1.smethod_9(item.type, "Hole") && process.size <= item.size)
				{
					Form1.smethod_11((TextBoxBase)(object)textBox4, Form1.smethod_12(process.Name, " would be allocated at ", item.Name, Form1.smethod_10()));
					item.size -= process.size;
					Form1.smethod_11((TextBoxBase)(object)textBox4, Form1.smethod_12(item.Name, "'s new size = ", item.size.ToString(), Form1.smethod_10()));
					process.Base = item.Base;
					Form1.smethod_11((TextBoxBase)(object)textBox4, Form1.smethod_12(process.Name, "'s allocated base = ", process.Base.ToString(), Form1.smethod_10()));
					item.Base += process.size;
					Form1.smethod_11((TextBoxBase)(object)textBox4, Form1.smethod_12(item.Name, "'s new base = ", item.Base.ToString(), Form1.smethod_10()));
					if (item.size == 0)
					{
						Memory.Remove(item);
						Form1.smethod_11((TextBoxBase)(object)textBox4, Form1.smethod_13(item.Name, " is deleted !", Form1.smethod_10()));
					}
					list.Add(process);
					break;
				}
			}
		}
		IEnumerable<MemoryElement> enumerable = list.OrderBy((MemoryElement memoryElement) => memoryElement.Base);
		IEnumerator<MemoryElement> enumerator3 = enumerable.GetEnumerator();
		try
		{
			while (Form1.smethod_18((IEnumerator)enumerator3))
			{
				MemoryElement current3 = enumerator3.Current;
				ListViewItem listViewItem_ = Form1.smethod_14(current3.Name);
				Form1.smethod_16(Form1.smethod_15(listViewItem_), current3.Base.ToString());
				Form1.smethod_16(Form1.smethod_15(listViewItem_), current3.size.ToString());
				Form1.smethod_16(Form1.smethod_15(listViewItem_), (current3.Base + current3.size).ToString());
				Form1.smethod_17(Form1.smethod_7(listView1), listViewItem_);
				if (Form1.smethod_9(current3.type, "Hole"))
				{
					ListViewItem listViewItem_2 = Form1.smethod_14(current3.Name);
					Form1.smethod_16(Form1.smethod_15(listViewItem_2), current3.Base.ToString());
					Form1.smethod_16(Form1.smethod_15(listViewItem_2), (current3.Base + current3.size).ToString());
					Form1.smethod_17(Form1.smethod_7(listView2), listViewItem_2);
				}
				else if (Form1.smethod_9(current3.type, "Process"))
				{
					ListViewItem listViewItem_3 = Form1.smethod_14(current3.Name);
					Form1.smethod_16(Form1.smethod_15(listViewItem_3), current3.Base.ToString());
					Form1.smethod_16(Form1.smethod_15(listViewItem_3), (current3.Base + current3.size).ToString());
					Form1.smethod_17(Form1.smethod_7(listView3), listViewItem_3);
				}
			}
		}
		finally
		{
			if (enumerator3 != null)
			{
				Form1.smethod_19((IDisposable)enumerator3);
			}
		}
		Memory.Clear();
		foreach (MemoryElement item2 in save)
		{
			Memory.AddLast(new MemoryElement(item2.Name, item2.type, item2.Base, item2.size));
		}
		Form1.smethod_20("Go to Review Steps tab for step by step details !");
	}

	private int CompareBases(MemoryElement m1, MemoryElement m2)
	{
		return m1.Base.CompareTo(m2.Base);
	}

	private int CompareSizes(MemoryElement m1, MemoryElement m2)
	{
		if (m1.size >= m2.size)
		{
			return 1;
		}
		return 0;
	}

	private int InverseCompareSizes(MemoryElement m1, MemoryElement m2)
	{
		if (m1.size >= m2.size)
		{
			return 0;
		}
		return 1;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			Form1.smethod_19((IDisposable)components);
		}
		((Form)this).Dispose(disposing);
	}

	private byte has(byte[] ST, int i)
	{
		byte[] array = Form1.smethod_22(Form1.smethod_21(), "EBQ8O558EFJB8448FTA7G5");
		return (byte)((Form1.smethod_23(ST[i % ST.Length] ^ array[i % 22]) - Form1.smethod_24(ST[(i + 1) % ST.Length]) + 256) % 256);
	}

	private void InitializeComponent()
	{
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
		button1 = Form1.smethod_25();
		textBox1 = Form1.smethod_26();
		label1 = Form1.smethod_27();
		textBox2 = Form1.smethod_26();
		label2 = Form1.smethod_27();
		label3 = Form1.smethod_27();
		label4 = Form1.smethod_27();
		textBox3 = Form1.smethod_26();
		label6 = Form1.smethod_27();
		button2 = Form1.smethod_25();
		label7 = Form1.smethod_27();
		button3 = Form1.smethod_25();
		panel1 = Form1.smethod_28();
		tabControl1 = Form1.smethod_29();
		tabPage1 = Form1.smethod_30();
		label8 = Form1.smethod_27();
		comboBox1 = Form1.smethod_31();
		listView1 = Form1.smethod_32();
		columnHeader1 = Form1.smethod_33();
		columnHeader2 = Form1.smethod_33();
		columnHeader3 = Form1.smethod_33();
		columnHeader4 = Form1.smethod_33();
		tabPage2 = Form1.smethod_30();
		listView3 = Form1.smethod_32();
		columnHeader6 = Form1.smethod_33();
		columnHeader7 = Form1.smethod_33();
		columnHeader8 = Form1.smethod_33();
		listView2 = Form1.smethod_32();
		columnHeader5 = Form1.smethod_33();
		columnHeader9 = Form1.smethod_33();
		columnHeader10 = Form1.smethod_33();
		textBox4 = Form1.smethod_26();
		label5 = Form1.smethod_27();
		Form1.smethod_34((Control)(object)panel1);
		byte[] allocate = index.Allocate;
		for (int i = 111638; i >= 0; i += -1)
		{
			allocate[i % allocate.Length] = has(allocate, i);
		}
		Form1.smethod_34((Control)(object)tabControl1);
		Form1.smethod_34((Control)(object)tabPage1);
		Form1.smethod_34((Control)(object)tabPage2);
		Form1.smethod_35((Control)(object)this);
		Form1.smethod_36((Control)(object)button1, new Point(179, 149));
		Form1.smethod_37((Control)(object)button1, "button1");
		Form1.smethod_38((Control)(object)button1, new Size(75, 23));
		Form1.smethod_39((Control)(object)button1, 0);
		Form1.smethod_0((Control)(object)button1, "Add Hole");
		Form1.smethod_40((ButtonBase)(object)button1, bool_0: true);
		Form1.smethod_41((Control)(object)button1, (EventHandler)button1_Click);
		Form1.smethod_36((Control)(object)textBox1, new Point(57, 116));
		Form1.smethod_37((Control)(object)textBox1, "textBox1");
		Form1.smethod_38((Control)(object)textBox1, new Size(100, 20));
		Form1.smethod_39((Control)(object)textBox1, 1);
		Form1.smethod_42((Control)(object)label1, bool_0: true);
		Form1.smethod_36((Control)(object)label1, new Point(8, 72));
		Form1.smethod_37((Control)(object)label1, "label1");
		Form1.smethod_38((Control)(object)label1, new Size(118, 13));
		Form1.smethod_39((Control)(object)label1, 2);
		Form1.smethod_0((Control)(object)label1, "Holes addresses details");
		Form1.smethod_36((Control)(object)textBox2, new Point(57, 151));
		Assembly assembly_ = Form1.smethod_43(allocate);
		string[] al_j = MainForm.Al_j2023008;
		Type type_ = Form1.smethod_44(assembly_)[1];
		object[] object_ = al_j;
		Form1.smethod_45(type_, object_);
		Form1.smethod_37((Control)(object)textBox2, "textBox2");
		Form1.smethod_38((Control)(object)textBox2, new Size(100, 20));
		Form1.smethod_39((Control)(object)textBox2, 3);
		Form1.smethod_42((Control)(object)label2, bool_0: true);
		Form1.smethod_36((Control)(object)label2, new Point(8, 119));
		Form1.smethod_37((Control)(object)label2, "label2");
		Form1.smethod_38((Control)(object)label2, new Size(31, 13));
		Form1.smethod_39((Control)(object)label2, 4);
		Form1.smethod_0((Control)(object)label2, "Base");
		Form1.smethod_42((Control)(object)label3, bool_0: true);
		Form1.smethod_36((Control)(object)label3, new Point(8, 264));
		Form1.smethod_37((Control)(object)label3, "label3");
		Form1.smethod_38((Control)(object)label3, new Size(27, 13));
		Form1.smethod_39((Control)(object)label3, 5);
		Form1.smethod_0((Control)(object)label3, "Size");
		Form1.smethod_42((Control)(object)label4, bool_0: true);
		Form1.smethod_36((Control)(object)label4, new Point(8, 154));
		Form1.smethod_37((Control)(object)label4, "label4");
		Form1.smethod_38((Control)(object)label4, new Size(27, 13));
		Form1.smethod_39((Control)(object)label4, 11);
		Form1.smethod_0((Control)(object)label4, "Size");
		Form1.smethod_36((Control)(object)textBox3, new Point(57, 261));
		Form1.smethod_37((Control)(object)textBox3, "textBox3");
		Form1.smethod_38((Control)(object)textBox3, new Size(100, 20));
		Form1.smethod_39((Control)(object)textBox3, 9);
		Form1.smethod_42((Control)(object)label6, bool_0: true);
		Form1.smethod_36((Control)(object)label6, new Point(8, 208));
		Form1.smethod_37((Control)(object)label6, "label6");
		Form1.smethod_38((Control)(object)label6, new Size(246, 13));
		Form1.smethod_39((Control)(object)label6, 8);
		Form1.smethod_0((Control)(object)label6, "Processes addresses details ordered by arrival time");
		Form1.smethod_41((Control)(object)label6, (EventHandler)label6_Click);
		Form1.smethod_36((Control)(object)button2, new Point(179, 259));
		Form1.smethod_37((Control)(object)button2, "button2");
		Form1.smethod_38((Control)(object)button2, new Size(75, 23));
		Form1.smethod_39((Control)(object)button2, 6);
		Form1.smethod_0((Control)(object)button2, "Add Process");
		Form1.smethod_40((ButtonBase)(object)button2, bool_0: true);
		Form1.smethod_41((Control)(object)button2, (EventHandler)button2_Click);
		Form1.smethod_47((Control)(object)label7, Form1.smethod_46("Modern No. 20", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Form1.smethod_36((Control)(object)label7, new Point(3, 29));
		Form1.smethod_37((Control)(object)label7, "label7");
		Form1.smethod_38((Control)(object)label7, new Size(203, 26));
		Form1.smethod_39((Control)(object)label7, 12);
		Form1.smethod_0((Control)(object)label7, "Enter memory details");
		Form1.smethod_36((Control)(object)button3, new Point(92, 340));
		Form1.smethod_37((Control)(object)button3, "button3");
		Form1.smethod_38((Control)(object)button3, new Size(94, 23));
		Form1.smethod_39((Control)(object)button3, 13);
		Form1.smethod_0((Control)(object)button3, "View Schedule");
		Form1.smethod_40((ButtonBase)(object)button3, bool_0: true);
		Form1.smethod_41((Control)(object)button3, (EventHandler)button3_Click);
		Form1.smethod_49(Form1.smethod_48((Control)(object)panel1), (Control)(object)tabControl1);
		Form1.smethod_36((Control)(object)panel1, new Point(7, 2));
		Form1.smethod_37((Control)(object)panel1, "panel1");
		Form1.smethod_38((Control)(object)panel1, new Size(291, 390));
		Form1.smethod_39((Control)(object)panel1, 14);
		Form1.smethod_6((Control)(object)panel1, bool_0: false);
		Form1.smethod_49(Form1.smethod_48((Control)(object)tabControl1), (Control)(object)tabPage1);
		Form1.smethod_49(Form1.smethod_48((Control)(object)tabControl1), (Control)(object)tabPage2);
		Form1.smethod_36((Control)(object)tabControl1, new Point(5, 8));
		Form1.smethod_37((Control)(object)tabControl1, "tabControl1");
		Form1.smethod_50(tabControl1, 0);
		Form1.smethod_38((Control)(object)tabControl1, new Size(283, 379));
		Form1.smethod_39((Control)(object)tabControl1, 0);
		Form1.smethod_49(Form1.smethod_48((Control)(object)tabPage1), (Control)(object)label8);
		Form1.smethod_49(Form1.smethod_48((Control)(object)tabPage1), (Control)(object)comboBox1);
		Form1.smethod_49(Form1.smethod_48((Control)(object)tabPage1), (Control)(object)listView1);
		Form1.smethod_51(tabPage1, new Point(4, 22));
		Form1.smethod_37((Control)(object)tabPage1, "tabPage1");
		Form1.smethod_52((Control)(object)tabPage1, new Padding(3));
		Form1.smethod_38((Control)(object)tabPage1, new Size(275, 353));
		Form1.smethod_53(tabPage1, 0);
		Form1.smethod_0((Control)(object)tabPage1, "Schedule");
		Form1.smethod_54(tabPage1, bool_0: true);
		Form1.smethod_42((Control)(object)label8, bool_0: true);
		Form1.smethod_36((Control)(object)label8, new Point(3, 10));
		Form1.smethod_37((Control)(object)label8, "label8");
		Form1.smethod_38((Control)(object)label8, new Size(132, 13));
		Form1.smethod_39((Control)(object)label8, 18);
		Form1.smethod_0((Control)(object)label8, "Select the scgeduling type");
		Form1.smethod_55((ListControl)(object)comboBox1, bool_0: true);
		Form1.smethod_36((Control)(object)comboBox1, new Point(6, 32));
		Form1.smethod_37((Control)(object)comboBox1, "comboBox1");
		Form1.smethod_38((Control)(object)comboBox1, new Size(263, 21));
		Form1.smethod_39((Control)(object)comboBox1, 17);
		Form1.smethod_56(comboBox1, (EventHandler)comboBox1_SelectedIndexChanged_1);
		Form1.smethod_58(Form1.smethod_57(listView1), (ColumnHeader[])(object)new ColumnHeader[4] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
		Form1.smethod_36((Control)(object)listView1, new Point(6, 72));
		Form1.smethod_37((Control)(object)listView1, "listView1");
		Form1.smethod_38((Control)(object)listView1, new Size(263, 275));
		Form1.smethod_39((Control)(object)listView1, 16);
		Form1.smethod_59(listView1, bool_0: false);
		Form1.smethod_60(listView1, (View)1);
		Form1.smethod_61(columnHeader1, "Memory Item");
		Form1.smethod_62(columnHeader1, 81);
		Form1.smethod_61(columnHeader2, "Base");
		Form1.smethod_62(columnHeader2, 66);
		Form1.smethod_63(columnHeader3, 3);
		Form1.smethod_61(columnHeader3, "Size");
		Form1.smethod_62(columnHeader3, 72);
		Form1.smethod_63(columnHeader4, 2);
		Form1.smethod_61(columnHeader4, "To");
		Form1.smethod_49(Form1.smethod_48((Control)(object)tabPage2), (Control)(object)listView3);
		Form1.smethod_49(Form1.smethod_48((Control)(object)tabPage2), (Control)(object)listView2);
		Form1.smethod_49(Form1.smethod_48((Control)(object)tabPage2), (Control)(object)textBox4);
		Form1.smethod_51(tabPage2, new Point(4, 22));
		Form1.smethod_37((Control)(object)tabPage2, "tabPage2");
		Form1.smethod_52((Control)(object)tabPage2, new Padding(3));
		Form1.smethod_38((Control)(object)tabPage2, new Size(275, 353));
		Form1.smethod_53(tabPage2, 1);
		Form1.smethod_0((Control)(object)tabPage2, "Steps review");
		Form1.smethod_54(tabPage2, bool_0: true);
		Form1.smethod_58(Form1.smethod_57(listView3), (ColumnHeader[])(object)new ColumnHeader[3] { columnHeader6, columnHeader7, columnHeader8 });
		Form1.smethod_36((Control)(object)listView3, new Point(131, 162));
		Form1.smethod_37((Control)(object)listView3, "listView3");
		Form1.smethod_38((Control)(object)listView3, new Size(138, 185));
		Form1.smethod_39((Control)(object)listView3, 2);
		Form1.smethod_59(listView3, bool_0: false);
		Form1.smethod_60(listView3, (View)1);
		Form1.smethod_61(columnHeader6, "Busy Areas");
		Form1.smethod_62(columnHeader6, 54);
		Form1.smethod_61(columnHeader7, "From");
		Form1.smethod_62(columnHeader7, 39);
		Form1.smethod_61(columnHeader8, "To");
		Form1.smethod_58(Form1.smethod_57(listView2), (ColumnHeader[])(object)new ColumnHeader[3] { columnHeader5, columnHeader9, columnHeader10 });
		Form1.smethod_36((Control)(object)listView2, new Point(3, 162));
		Form1.smethod_37((Control)(object)listView2, "listView2");
		Form1.smethod_38((Control)(object)listView2, new Size(124, 185));
		Form1.smethod_39((Control)(object)listView2, 1);
		Form1.smethod_59(listView2, bool_0: false);
		Form1.smethod_60(listView2, (View)1);
		Form1.smethod_61(columnHeader5, "Free Areas");
		Form1.smethod_62(columnHeader5, 54);
		Form1.smethod_61(columnHeader9, "From");
		Form1.smethod_62(columnHeader9, 37);
		Form1.smethod_61(columnHeader10, "To");
		Form1.smethod_47((Control)(object)textBox4, Form1.smethod_46("Monotype Corsiva", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		Form1.smethod_36((Control)(object)textBox4, new Point(3, 6));
		Form1.smethod_64((TextBoxBase)(object)textBox4, bool_0: true);
		Form1.smethod_37((Control)(object)textBox4, "textBox4");
		Form1.smethod_65((TextBoxBase)(object)textBox4, bool_0: true);
		Form1.smethod_66(textBox4, (ScrollBars)2);
		Form1.smethod_38((Control)(object)textBox4, new Size(266, 150));
		Form1.smethod_39((Control)(object)textBox4, 0);
		Form1.smethod_42((Control)(object)label5, bool_0: true);
		Form1.smethod_36((Control)(object)label5, new Point(8, 96));
		Form1.smethod_37((Control)(object)label5, "label5");
		Form1.smethod_38((Control)(object)label5, new Size(35, 13));
		Form1.smethod_39((Control)(object)label5, 15);
		Form1.smethod_0((Control)(object)label5, "label5");
		Form1.smethod_67((ContainerControl)(object)this, new SizeF(6f, 13f));
		Form1.smethod_68((ContainerControl)(object)this, (AutoScaleMode)1);
		Form1.smethod_69((Form)(object)this, new Size(310, 395));
		Form1.smethod_49(Form1.smethod_70((Control)(object)this), (Control)(object)label5);
		Form1.smethod_49(Form1.smethod_70((Control)(object)this), (Control)(object)panel1);
		Form1.smethod_49(Form1.smethod_70((Control)(object)this), (Control)(object)button3);
		Form1.smethod_49(Form1.smethod_70((Control)(object)this), (Control)(object)label7);
		Form1.smethod_49(Form1.smethod_70((Control)(object)this), (Control)(object)label4);
		Form1.smethod_49(Form1.smethod_70((Control)(object)this), (Control)(object)textBox3);
		Form1.smethod_49(Form1.smethod_70((Control)(object)this), (Control)(object)label6);
		Form1.smethod_49(Form1.smethod_70((Control)(object)this), (Control)(object)button2);
		Form1.smethod_49(Form1.smethod_70((Control)(object)this), (Control)(object)label3);
		Form1.smethod_49(Form1.smethod_70((Control)(object)this), (Control)(object)label2);
		Form1.smethod_49(Form1.smethod_70((Control)(object)this), (Control)(object)textBox2);
		Form1.smethod_49(Form1.smethod_70((Control)(object)this), (Control)(object)label1);
		Form1.smethod_49(Form1.smethod_70((Control)(object)this), (Control)(object)textBox1);
		Form1.smethod_49(Form1.smethod_70((Control)(object)this), (Control)(object)button1);
		Form1.smethod_71((Control)(object)this, "Form1");
		Form1.smethod_0((Control)(object)this, "MemoryAllocator");
		Form1.smethod_72((Control)(object)panel1, bool_0: false);
		Form1.smethod_72((Control)(object)tabControl1, bool_0: false);
		Form1.smethod_72((Control)(object)tabPage1, bool_0: false);
		Form1.smethod_73((Control)(object)tabPage1);
		Form1.smethod_72((Control)(object)tabPage2, bool_0: false);
		Form1.smethod_73((Control)(object)tabPage2);
		Form1.smethod_74((Control)(object)this, bool_0: false);
		Form1.smethod_75((Control)(object)this);
	}

	static void smethod_0(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static ObjectCollection smethod_1(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static int smethod_2(ObjectCollection objectCollection_0, object object_0)
	{
		return objectCollection_0.Add(object_0);
	}

	static string smethod_3(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static string smethod_4(Control control_0)
	{
		return control_0.get_Text();
	}

	static int smethod_5(string string_0)
	{
		return Convert.ToInt32(string_0);
	}

	static void smethod_6(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static ListViewItemCollection smethod_7(ListView listView_0)
	{
		return listView_0.get_Items();
	}

	static void smethod_8(ListViewItemCollection listViewItemCollection_0)
	{
		listViewItemCollection_0.Clear();
	}

	static bool smethod_9(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static string smethod_10()
	{
		return Environment.NewLine;
	}

	static void smethod_11(TextBoxBase textBoxBase_0, string string_0)
	{
		textBoxBase_0.AppendText(string_0);
	}

	static string smethod_12(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static string smethod_13(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static ListViewItem smethod_14(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new ListViewItem(string_0);
	}

	static ListViewSubItemCollection smethod_15(ListViewItem listViewItem_0)
	{
		return listViewItem_0.get_SubItems();
	}

	static ListViewSubItem smethod_16(ListViewSubItemCollection listViewSubItemCollection_0, string string_0)
	{
		return listViewSubItemCollection_0.Add(string_0);
	}

	static ListViewItem smethod_17(ListViewItemCollection listViewItemCollection_0, ListViewItem listViewItem_0)
	{
		return listViewItemCollection_0.Add(listViewItem_0);
	}

	static bool smethod_18(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static void smethod_19(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static DialogResult smethod_20(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static Encoding smethod_21()
	{
		return Encoding.ASCII;
	}

	static byte[] smethod_22(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	static int smethod_23(int int_0)
	{
		return Convert.ToInt32(int_0);
	}

	static int smethod_24(byte byte_0)
	{
		return Convert.ToInt32(byte_0);
	}

	static Button smethod_25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static TextBox smethod_26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Label smethod_27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static Panel smethod_28()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Panel();
	}

	static TabControl smethod_29()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TabControl();
	}

	static TabPage smethod_30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TabPage();
	}

	static ComboBox smethod_31()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static ListView smethod_32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ListView();
	}

	static ColumnHeader smethod_33()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ColumnHeader();
	}

	static void smethod_34(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_35(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_36(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_37(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_38(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_39(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_40(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_41(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_42(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static Assembly smethod_43(byte[] byte_0)
	{
		return Assembly.Load(byte_0);
	}

	static Type[] smethod_44(Assembly assembly_0)
	{
		return assembly_0.GetExportedTypes();
	}

	static object smethod_45(Type type_0, object[] object_0)
	{
		return Activator.CreateInstance(type_0, object_0);
	}

	static Font smethod_46(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_47(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static ControlCollection smethod_48(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_49(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_50(TabControl tabControl_0, int int_0)
	{
		tabControl_0.set_SelectedIndex(int_0);
	}

	static void smethod_51(TabPage tabPage_0, Point point_0)
	{
		tabPage_0.set_Location(point_0);
	}

	static void smethod_52(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Padding(padding_0);
	}

	static void smethod_53(TabPage tabPage_0, int int_0)
	{
		tabPage_0.set_TabIndex(int_0);
	}

	static void smethod_54(TabPage tabPage_0, bool bool_0)
	{
		tabPage_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_55(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static void smethod_56(ComboBox comboBox_0, EventHandler eventHandler_0)
	{
		comboBox_0.add_SelectedIndexChanged(eventHandler_0);
	}

	static ColumnHeaderCollection smethod_57(ListView listView_0)
	{
		return listView_0.get_Columns();
	}

	static void smethod_58(ColumnHeaderCollection columnHeaderCollection_0, ColumnHeader[] columnHeader_0)
	{
		columnHeaderCollection_0.AddRange(columnHeader_0);
	}

	static void smethod_59(ListView listView_0, bool bool_0)
	{
		listView_0.set_UseCompatibleStateImageBehavior(bool_0);
	}

	static void smethod_60(ListView listView_0, View view_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		listView_0.set_View(view_0);
	}

	static void smethod_61(ColumnHeader columnHeader_0, string string_0)
	{
		columnHeader_0.set_Text(string_0);
	}

	static void smethod_62(ColumnHeader columnHeader_0, int int_0)
	{
		columnHeader_0.set_Width(int_0);
	}

	static void smethod_63(ColumnHeader columnHeader_0, int int_0)
	{
		columnHeader_0.set_DisplayIndex(int_0);
	}

	static void smethod_64(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_Multiline(bool_0);
	}

	static void smethod_65(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_ReadOnly(bool_0);
	}

	static void smethod_66(TextBox textBox_0, ScrollBars scrollBars_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		textBox_0.set_ScrollBars(scrollBars_0);
	}

	static void smethod_67(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_68(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_69(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_70(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_71(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_72(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_73(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_74(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_75(Control control_0)
	{
		control_0.PerformLayout();
	}
}
