using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using UNIVERSALGAME.Properties;

public sealed class GControl1 : UserControl
{
	private sealed class Class29
	{
		public int int_0;

		public int int_1;

		internal bool method_0(Point point_0)
		{
			if (point_0.X.Equals(int_0))
			{
				return point_0.Y.Equals(int_1);
			}
			return false;
		}
	}

	private sealed class Class30 : BackgroundWorker
	{
		private Thread thread_0;

		protected override void OnDoWork(DoWorkEventArgs e)
		{
			thread_0 = Thread.CurrentThread;
			try
			{
				base.OnDoWork(e);
			}
			catch (ThreadAbortException)
			{
				e.Cancel = true;
				Thread.ResetAbort();
			}
		}

		public void method_0()
		{
			if (thread_0 != null)
			{
				thread_0.Abort();
				thread_0 = null;
			}
		}
	}

	public int int_0;

	public GClass14 gclass14_0;

	public GClass12 gclass12_0;

	private bool bool_0;

	private bool bool_1 = true;

	private Class30 class30_0 = new Class30();

	private List<Point> list_0 = new List<Point>();

	private string string_0 = AppDomain.CurrentDomain.BaseDirectory + Class60.smethod_0(-2050219628);

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private GroupBox groupBox_0;

	private GroupBox groupBox_1;

	private TableLayoutPanel tableLayoutPanel_1;

	private Label label_0;

	private ComboBox comboBox_0;

	private TableLayoutPanel tableLayoutPanel_2;

	private ListBox listBox_0;

	private TableLayoutPanel tableLayoutPanel_3;

	private Label label_1;

	private Button button_0;

	private SaveFileDialog saveFileDialog_0;

	public GControl1()
	{
		method_1();
	}

	private void GControl1_Load(object sender, EventArgs e)
	{
		class30_0.WorkerSupportsCancellation = true;
		class30_0.DoWork += class30_0_DoWork;
		if (!Directory.Exists(string_0))
		{
			Directory.CreateDirectory(string_0);
		}
		method_0();
	}

	public void method_0()
	{
		bool_1 = true;
		string[] files = Directory.GetFiles(string_0, Class60.smethod_0(-2050219665));
		if (files.Length != 0)
		{
			comboBox_0.get_Items().Clear();
		}
		string[] array = files;
		foreach (string path in array)
		{
			comboBox_0.get_Items().Add((object)Path.GetFileName(path)!.Substring(0, Path.GetFileName(path)!.IndexOf('.')));
		}
		if (int_0 == 0 && !string.IsNullOrEmpty(Settings.Default.Path_Map))
		{
			if (comboBox_0.get_Items().get_Count() > 0)
			{
				comboBox_0.set_SelectedItem((object)Path.GetFileName(Settings.Default.Path_Map)!.Substring(0, Path.GetFileName(Settings.Default.Path_Map)!.IndexOf('.')));
			}
		}
		else if (int_0 == 1 && !string.IsNullOrEmpty(Settings.Default._2_Path_Map))
		{
			if (comboBox_0.get_Items().get_Count() > 0)
			{
				comboBox_0.set_SelectedItem((object)Path.GetFileName(Settings.Default._2_Path_Map)!.Substring(0, Path.GetFileName(Settings.Default._2_Path_Map)!.IndexOf('.')));
			}
		}
		else if (int_0 == 2 && !string.IsNullOrEmpty(Settings.Default._3_Path_Map) && comboBox_0.get_Items().get_Count() > 0)
		{
			comboBox_0.set_SelectedItem((object)Path.GetFileName(Settings.Default._3_Path_Map)!.Substring(0, Path.GetFileName(Settings.Default._3_Path_Map)!.IndexOf('.')));
		}
		bool_1 = false;
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Invalid comparison between Unknown and I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		if (gclass14_0 != null)
		{
			try
			{
				if (!bool_0)
				{
					bool_0 = true;
					((Control)button_0).set_BackColor(Color.DarkOrange);
					if (!class30_0.IsBusy)
					{
						class30_0.RunWorkerAsync();
					}
					return;
				}
				bool_0 = false;
				if (class30_0.IsBusy)
				{
					class30_0.CancelAsync();
				}
				try
				{
					((Control)button_0).set_BackColor(Color.LightSeaGreen);
					if (list_0.Count > 0)
					{
						string text = gclass14_0.method_8(gclass12_0.MAP_NAME);
						if (text.IndexOf('\0') > 0)
						{
							text = text.Substring(0, text.IndexOf('.'));
						}
						((FileDialog)saveFileDialog_0).set_InitialDirectory(AppDomain.CurrentDomain.BaseDirectory + Class60.smethod_0(-2050219628));
						((FileDialog)saveFileDialog_0).set_FileName(text + Class60.smethod_0(-2050219653));
						if ((int)((CommonDialog)saveFileDialog_0).ShowDialog() == 1)
						{
							StreamWriter streamWriter = new StreamWriter(((FileDialog)saveFileDialog_0).get_FileName());
							try
							{
								foreach (Point item in list_0)
								{
									string value = string.Format(Class60.smethod_0(-2050219658), item.X, item.Y);
									streamWriter.WriteLine(value);
								}
							}
							finally
							{
								((IDisposable)streamWriter).Dispose();
							}
							if (int_0 == 0)
							{
								Settings.Default.Path_Map = ((FileDialog)saveFileDialog_0).get_FileName();
							}
							else if (int_0 == 1)
							{
								Settings.Default._2_Path_Map = ((FileDialog)saveFileDialog_0).get_FileName();
							}
							else if (int_0 == 2)
							{
								Settings.Default._3_Path_Map = ((FileDialog)saveFileDialog_0).get_FileName();
							}
							((SettingsBase)Settings.Default).Save();
							method_0();
						}
					}
					return;
				}
				catch
				{
					((Control)button_0).set_BackColor(Color.DarkGray);
					Form val = new Form();
					val.set_TopMost(true);
					MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050219708), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
					return;
				}
			}
			catch
			{
				((Control)button_0).set_BackColor(Color.DarkGray);
				return;
			}
		}
		Form val2 = new Form();
		val2.set_TopMost(true);
		MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050216182), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
	}

	private void class30_0_DoWork(object sender, DoWorkEventArgs e)
	{
		Class29 @class = new Class29();
		@class.int_0 = 0;
		@class.int_1 = 0;
		list_0.Clear();
		listBox_0.get_Items().Clear();
		while (!class30_0.CancellationPending && bool_0)
		{
			@class.int_0 = gclass14_0.method_9(gclass12_0.CHAR_X);
			@class.int_1 = gclass14_0.method_9(gclass12_0.CHAR_Y);
			if (!list_0.Exists(@class.method_0))
			{
				list_0.Add(new Point(@class.int_0, @class.int_1));
				if (listBox_0.get_Items().get_Count() > 0)
				{
					listBox_0.get_Items().Insert(0, (object)(Class60.smethod_0(-2050219761) + @class.int_0 + Class60.smethod_0(-2050219752) + @class.int_1));
				}
				else
				{
					listBox_0.get_Items().Add((object)(Class60.smethod_0(-2050219761) + @class.int_0 + Class60.smethod_0(-2050219752) + @class.int_1));
				}
			}
			if (class30_0.CancellationPending || !bool_0)
			{
				e.Cancel = true;
			}
			Thread.Sleep(200);
		}
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (bool_1)
		{
			return;
		}
		string[] files = Directory.GetFiles(string_0, string.Concat(comboBox_0.get_SelectedItem(), Class60.smethod_0(-2050219653)));
		if (files.Length == 1)
		{
			if (int_0 == 0)
			{
				Settings.Default.Path_Map = files[0];
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_Path_Map = files[0];
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_Path_Map = files[0];
			}
			((SettingsBase)Settings.Default).Save();
		}
		else
		{
			Form val = new Form();
			val.set_TopMost(true);
			MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050219757), Class60.smethod_0(-2050198623), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void method_1()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
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
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected O, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected O, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected O, but got Unknown
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected O, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Expected O, but got Unknown
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected O, but got Unknown
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected O, but got Unknown
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected O, but got Unknown
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected O, but got Unknown
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_098d: Expected O, but got Unknown
		tableLayoutPanel_0 = new TableLayoutPanel();
		groupBox_0 = new GroupBox();
		tableLayoutPanel_1 = new TableLayoutPanel();
		label_0 = new Label();
		comboBox_0 = new ComboBox();
		groupBox_1 = new GroupBox();
		tableLayoutPanel_2 = new TableLayoutPanel();
		listBox_0 = new ListBox();
		tableLayoutPanel_3 = new TableLayoutPanel();
		label_1 = new Label();
		button_0 = new Button();
		saveFileDialog_0 = new SaveFileDialog();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((Control)groupBox_0).SuspendLayout();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)groupBox_1).SuspendLayout();
		((Control)tableLayoutPanel_2).SuspendLayout();
		((Control)tableLayoutPanel_3).SuspendLayout();
		((Control)this).SuspendLayout();
		tableLayoutPanel_0.set_ColumnCount(1);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_0, 0, 0);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_1, 0, 1);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_0).set_Name(Class60.smethod_0(-2050208027));
		tableLayoutPanel_0.set_RowCount(2);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 11f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 89f));
		((Control)tableLayoutPanel_0).set_Size(new Size(450, 600));
		((Control)tableLayoutPanel_0).set_TabIndex(0);
		((Control)groupBox_0).get_Controls().Add((Control)(object)tableLayoutPanel_1);
		((Control)groupBox_0).set_Dock((DockStyle)5);
		((Control)groupBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5));
		((Control)groupBox_0).set_ForeColor(SystemColors.Control);
		((Control)groupBox_0).set_Location(new Point(0, 0));
		((Control)groupBox_0).set_Margin(new Padding(0));
		((Control)groupBox_0).set_Name(Class60.smethod_0(-2050210886));
		((Control)groupBox_0).set_Size(new Size(450, 66));
		((Control)groupBox_0).set_TabIndex(0);
		groupBox_0.set_TabStop(false);
		((Control)groupBox_0).set_Text(Class60.smethod_0(-2050202832));
		tableLayoutPanel_1.set_ColumnCount(2);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_0, 0, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)comboBox_0, 1, 0);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050208091));
		tableLayoutPanel_1.set_RowCount(1);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)1, 41f));
		((Control)tableLayoutPanel_1).set_Size(new Size(444, 41));
		((Control)tableLayoutPanel_1).set_TabIndex(0);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Dock((DockStyle)4);
		((Control)label_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_0).set_Location(new Point(110, 0));
		((Control)label_0).set_Name(Class60.smethod_0(-2050208088));
		((Control)label_0).set_Size(new Size(109, 41));
		((Control)label_0).set_TabIndex(0);
		((Control)label_0).set_Text(Class60.smethod_0(-2050219882));
		label_0.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_0).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_0).set_Dock((DockStyle)5);
		comboBox_0.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f));
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		((Control)comboBox_0).set_Location(new Point(225, 3));
		((Control)comboBox_0).set_Name(Class60.smethod_0(-2050219963));
		((Control)comboBox_0).set_Size(new Size(216, 25));
		((Control)comboBox_0).set_TabIndex(1);
		comboBox_0.add_SelectedIndexChanged((EventHandler)comboBox_0_SelectedIndexChanged);
		((Control)groupBox_1).get_Controls().Add((Control)(object)tableLayoutPanel_2);
		((Control)groupBox_1).set_Dock((DockStyle)5);
		((Control)groupBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5));
		((Control)groupBox_1).set_ForeColor(SystemColors.Control);
		((Control)groupBox_1).set_Location(new Point(0, 66));
		((Control)groupBox_1).set_Margin(new Padding(0));
		((Control)groupBox_1).set_Name(Class60.smethod_0(-2050207223));
		((Control)groupBox_1).set_Size(new Size(450, 534));
		((Control)groupBox_1).set_TabIndex(1);
		groupBox_1.set_TabStop(false);
		((Control)groupBox_1).set_Text(Class60.smethod_0(-2050219948));
		tableLayoutPanel_2.set_ColumnCount(2);
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_2.get_Controls().Add((Control)(object)listBox_0, 1, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)tableLayoutPanel_3, 0, 0);
		((Control)tableLayoutPanel_2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_2).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_2).set_Name(Class60.smethod_0(-2050211088));
		tableLayoutPanel_2.set_RowCount(1);
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)1, 509f));
		((Control)tableLayoutPanel_2).set_Size(new Size(444, 509));
		((Control)tableLayoutPanel_2).set_TabIndex(0);
		((Control)listBox_0).set_Dock((DockStyle)5);
		((Control)listBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)listBox_0).set_FormattingEnabled(true);
		listBox_0.set_ItemHeight(18);
		((Control)listBox_0).set_Location(new Point(225, 3));
		((Control)listBox_0).set_Name(Class60.smethod_0(-2050220023));
		listBox_0.set_SelectionMode((SelectionMode)0);
		((Control)listBox_0).set_Size(new Size(216, 503));
		((Control)listBox_0).set_TabIndex(0);
		tableLayoutPanel_3.set_ColumnCount(1);
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_1, 0, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)button_0, 0, 1);
		((Control)tableLayoutPanel_3).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_3).set_Location(new Point(3, 3));
		((Control)tableLayoutPanel_3).set_Name(Class60.smethod_0(-2050211259));
		tableLayoutPanel_3.set_RowCount(3);
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 17f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 8f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 75f));
		((Control)tableLayoutPanel_3).set_Size(new Size(216, 503));
		((Control)tableLayoutPanel_3).set_TabIndex(1);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Dock((DockStyle)5);
		((Control)label_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_1).set_Location(new Point(3, 0));
		((Control)label_1).set_Name(Class60.smethod_0(-2050210921));
		((Control)label_1).set_Size(new Size(210, 85));
		((Control)label_1).set_TabIndex(0);
		((Control)label_1).set_Text(Class60.smethod_0(-2050220003));
		label_1.set_TextAlign((ContentAlignment)32);
		((Control)button_0).set_BackColor(Color.DarkGray);
		((Control)button_0).set_Cursor(Cursors.get_Hand());
		((Control)button_0).set_Dock((DockStyle)5);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)0);
		((Control)button_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1));
		((Control)button_0).set_Location(new Point(3, 88));
		((Control)button_0).set_Name(Class60.smethod_0(-2050218228));
		((Control)button_0).set_Size(new Size(210, 34));
		((Control)button_0).set_TabIndex(1);
		((Control)button_0).set_Text(Class60.smethod_0(-2050225268));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((FileDialog)saveFileDialog_0).set_DefaultExt(Class60.smethod_0(-2050218213));
		((FileDialog)saveFileDialog_0).set_Filter(Class60.smethod_0(-2050218219));
		((FileDialog)saveFileDialog_0).set_RestoreDirectory(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkSlateGray);
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		((Control)this).set_Name(Class60.smethod_0(-2050218245));
		((Control)this).set_Size(new Size(450, 600));
		((UserControl)this).add_Load((EventHandler)GControl1_Load);
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((Control)groupBox_0).ResumeLayout(false);
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)tableLayoutPanel_1).PerformLayout();
		((Control)groupBox_1).ResumeLayout(false);
		((Control)tableLayoutPanel_2).ResumeLayout(false);
		((Control)tableLayoutPanel_3).ResumeLayout(false);
		((Control)tableLayoutPanel_3).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
