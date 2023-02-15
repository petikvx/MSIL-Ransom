using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed class GForm6 : Form
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct19 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm6 gform6_0;

		private GClass5 gclass5_0;

		private TaskAwaiter<GClass5> taskAwaiter_0;

		private TaskAwaiter<DateTime> taskAwaiter_1;

		private void MoveNext()
		{
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected O, but got Unknown
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected O, but got Unknown
			//IL_0335: Unknown result type (might be due to invalid IL or missing references)
			//IL_033a: Unknown result type (might be due to invalid IL or missing references)
			//IL_035d: Expected O, but got Unknown
			//IL_0358: Unknown result type (might be due to invalid IL or missing references)
			//IL_0360: Unknown result type (might be due to invalid IL or missing references)
			//IL_0365: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected O, but got Unknown
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			int num = int_0;
			GForm6 gForm = gform6_0;
			try
			{
				TaskAwaiter<GClass5> awaiter;
				if (num == 0)
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<GClass5>);
					num = -1;
					int_0 = -1;
					goto IL_00b6;
				}
				TaskAwaiter<DateTime> awaiter2;
				if (num == 1)
				{
					awaiter2 = taskAwaiter_1;
					taskAwaiter_1 = default(TaskAwaiter<DateTime>);
					num = -1;
					int_0 = -1;
					goto IL_0155;
				}
				((Control)gForm).set_Text(((Control)gForm).get_Text() + gForm.string_0);
				if (gForm.gclass1_0 != null)
				{
					awaiter = GClass6.smethod_8().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00b6;
				}
				((Form)gForm).Close();
				goto end_IL_000e;
				IL_038f:
				gclass5_0 = null;
				goto end_IL_000e;
				IL_0155:
				DateTime result = awaiter2.GetResult();
				DateTime value = result;
				if (!value.Equals(DateTime.MinValue) && gclass5_0.ExpireDate.Subtract(value).TotalMinutes > 0.0)
				{
					GraphicsPath val = new GraphicsPath();
					val.AddEllipse(0, 0, ((Control)gForm.pictureBox_1).get_Width() - 3, ((Control)gForm.pictureBox_1).get_Height() - 3);
					Region region = new Region(val);
					((Control)gForm.pictureBox_1).set_Region(region);
					gForm.pictureBox_1.Load(gForm.gclass1_0.Image);
					((Control)gForm.label_8).set_Text(gclass5_0.ExpireDate.ToString(Class60.smethod_0(-2050203601), new CultureInfo(Class60.smethod_0(-2050203640))));
					((Control)gForm.label_7).set_Text(gclass5_0.License);
					if (gclass5_0.Flags < 2 || gclass5_0.Flags.Equals(3))
					{
						((Control)gForm.label_7).set_ForeColor(Color.LightGreen);
					}
					((Control)gForm.button_3).set_Visible(true);
					((Control)gForm.label_12).set_Visible(true);
					((Control)gForm.button_2).set_Visible(true);
					((Control)gForm.label_11).set_Visible(true);
					((Control)gForm.button_4).set_Visible(true);
					((Control)gForm.label_13).set_Visible(true);
					((Control)gForm.button_5).set_Visible(true);
					((Control)gForm.label_14).set_Visible(true);
				}
				else
				{
					((Control)gForm.label_8).set_Text(gclass5_0.ExpireDate.ToString(Class60.smethod_0(-2050203601), new CultureInfo(Class60.smethod_0(-2050203640))) + Class60.smethod_0(-2050203644));
					((Control)gForm.label_8).set_ForeColor(Color.DarkRed);
					Form val2 = new Form();
					val2.set_TopMost(true);
					MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050201617), Class60.smethod_0(-2050209943), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				goto IL_038f;
				IL_00b6:
				GClass5 gClass = (gclass5_0 = awaiter.GetResult());
				if (gclass5_0 != null)
				{
					((Control)gForm.label_5).set_Text(gForm.gclass1_0.DisplayName);
					((Control)gForm.label_6).set_Text(gForm.gclass1_0.Email);
					((Control)gForm.label_10).set_Text(Class60.smethod_0(-2050203561) + gForm.string_0);
					awaiter2 = GClass6.smethod_9().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter2;
						asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0155;
				}
				Form val3 = new Form();
				val3.set_TopMost(true);
				MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050201784), Class60.smethod_0(-2050209943), (MessageBoxButtons)0, (MessageBoxIcon)48);
				((Form)gForm).Close();
				goto IL_038f;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public GClass1 gclass1_0;

	public string string_0;

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private TableLayoutPanel tableLayoutPanel_1;

	private Label label_0;

	private Label label_1;

	private TableLayoutPanel tableLayoutPanel_2;

	private Button button_0;

	private Button button_1;

	private LinkLabel linkLabel_0;

	private PictureBox pictureBox_0;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private TabPage tabPage_1;

	private GroupBox groupBox_0;

	private TableLayoutPanel tableLayoutPanel_3;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private Label label_6;

	private Label label_7;

	private Label label_8;

	private Label label_9;

	private Label label_10;

	private GroupBox groupBox_1;

	private TableLayoutPanel tableLayoutPanel_4;

	private Label label_11;

	private Button button_2;

	private Button button_3;

	private Button button_4;

	private Button button_5;

	private Label label_12;

	private Label label_13;

	private Label label_14;

	private PictureBox pictureBox_1;

	public GForm6()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		method_0();
		((Control)tabControl_0).set_Region(new Region(new RectangleF(((Control)tabPage_0).get_Left(), ((Control)tabPage_0).get_Top(), ((Control)tabPage_0).get_Width(), ((Control)tabPage_0).get_Height())));
	}

	private async void GForm6_Load(object sender, EventArgs e)
	{
		((Control)this).set_Text(((Control)this).get_Text() + string_0);
		if (gclass1_0 == null)
		{
			((Form)this).Close();
			return;
		}
		GClass5 gClass = await GClass6.smethod_8();
		if (gClass != null)
		{
			((Control)label_5).set_Text(gclass1_0.DisplayName);
			((Control)label_6).set_Text(gclass1_0.Email);
			((Control)label_10).set_Text(Class60.smethod_0(-2050203561) + string_0);
			DateTime value = await GClass6.smethod_9();
			if (!value.Equals(DateTime.MinValue) && gClass.ExpireDate.Subtract(value).TotalMinutes > 0.0)
			{
				GraphicsPath val = new GraphicsPath();
				val.AddEllipse(0, 0, ((Control)pictureBox_1).get_Width() - 3, ((Control)pictureBox_1).get_Height() - 3);
				Region region = new Region(val);
				((Control)pictureBox_1).set_Region(region);
				pictureBox_1.Load(gclass1_0.Image);
				((Control)label_8).set_Text(gClass.ExpireDate.ToString(Class60.smethod_0(-2050203601), new CultureInfo(Class60.smethod_0(-2050203640))));
				((Control)label_7).set_Text(gClass.License);
				if (gClass.Flags < 2 || gClass.Flags.Equals(3))
				{
					((Control)label_7).set_ForeColor(Color.LightGreen);
				}
				((Control)button_3).set_Visible(true);
				((Control)label_12).set_Visible(true);
				((Control)button_2).set_Visible(true);
				((Control)label_11).set_Visible(true);
				((Control)button_4).set_Visible(true);
				((Control)label_13).set_Visible(true);
				((Control)button_5).set_Visible(true);
				((Control)label_14).set_Visible(true);
			}
			else
			{
				((Control)label_8).set_Text(gClass.ExpireDate.ToString(Class60.smethod_0(-2050203601), new CultureInfo(Class60.smethod_0(-2050203640))) + Class60.smethod_0(-2050203644));
				((Control)label_8).set_ForeColor(Color.DarkRed);
				Form val2 = new Form();
				val2.set_TopMost(true);
				MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050201617), Class60.smethod_0(-2050209943), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}
		else
		{
			Form val3 = new Form();
			val3.set_TopMost(true);
			MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050201784), Class60.smethod_0(-2050209943), (MessageBoxButtons)0, (MessageBoxIcon)48);
			((Form)this).Close();
		}
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel_0.set_LinkVisited(true);
		Process.Start(Class60.smethod_0(-2050208733));
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		((Control)label_0).set_Visible(true);
		((Control)label_1).set_Visible(false);
		tabControl_0.set_SelectedIndex(0);
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		((Control)label_0).set_Visible(false);
		((Control)label_1).set_Visible(true);
		tabControl_0.set_SelectedIndex(1);
	}

	private void button_3_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		GForm2 gForm = new GForm2();
		try
		{
			((Control)this).Hide();
			((Form)gForm).add_Closed((EventHandler)method_1);
			gForm.string_0 = string_0;
			gForm.gclass1_0 = gclass1_0;
			((Form)gForm).ShowDialog();
		}
		finally
		{
			((IDisposable)(object)gForm).Dispose();
		}
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		GForm3 gForm = new GForm3();
		try
		{
			((Control)this).Hide();
			((Form)gForm).add_Closed((EventHandler)method_2);
			gForm.gclass1_0 = gclass1_0;
			((Form)gForm).ShowDialog();
		}
		finally
		{
			((IDisposable)(object)gForm).Dispose();
		}
	}

	private void button_4_Click(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		GForm11 gForm = new GForm11();
		try
		{
			((Control)this).Hide();
			((Form)gForm).add_Closed((EventHandler)method_3);
			gForm.gclass1_0 = gclass1_0;
			((Form)gForm).ShowDialog();
		}
		finally
		{
			((IDisposable)(object)gForm).Dispose();
		}
	}

	private void button_5_Click(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		GForm1 gForm = new GForm1();
		try
		{
			((Control)this).Hide();
			((Form)gForm).add_Closed((EventHandler)method_4);
			gForm.gclass1_0 = gclass1_0;
			((Form)gForm).ShowDialog();
		}
		finally
		{
			((IDisposable)(object)gForm).Dispose();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
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
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected O, but got Unknown
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected O, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected O, but got Unknown
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected O, but got Unknown
		//IL_0819: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Expected O, but got Unknown
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Expected O, but got Unknown
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected O, but got Unknown
		//IL_0aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Expected O, but got Unknown
		//IL_0c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Expected O, but got Unknown
		//IL_0ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb1: Expected O, but got Unknown
		//IL_0df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfd: Expected O, but got Unknown
		//IL_0e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e19: Expected O, but got Unknown
		//IL_0e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e35: Expected O, but got Unknown
		//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e51: Expected O, but got Unknown
		//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6d: Expected O, but got Unknown
		//IL_0e7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e89: Expected O, but got Unknown
		//IL_0e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea5: Expected O, but got Unknown
		//IL_0eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec1: Expected O, but got Unknown
		//IL_0f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Expected O, but got Unknown
		//IL_0fbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc7: Expected O, but got Unknown
		//IL_1062: Unknown result type (might be due to invalid IL or missing references)
		//IL_106c: Expected O, but got Unknown
		//IL_110a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1114: Expected O, but got Unknown
		//IL_11b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11be: Expected O, but got Unknown
		//IL_125f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1269: Expected O, but got Unknown
		//IL_131a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1324: Expected O, but got Unknown
		//IL_13d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e3: Expected O, but got Unknown
		//IL_1482: Unknown result type (might be due to invalid IL or missing references)
		//IL_148c: Expected O, but got Unknown
		//IL_152e: Unknown result type (might be due to invalid IL or missing references)
		//IL_15da: Unknown result type (might be due to invalid IL or missing references)
		//IL_1657: Unknown result type (might be due to invalid IL or missing references)
		//IL_1661: Expected O, but got Unknown
		//IL_16fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1706: Expected O, but got Unknown
		//IL_1718: Unknown result type (might be due to invalid IL or missing references)
		//IL_1722: Expected O, but got Unknown
		//IL_1834: Unknown result type (might be due to invalid IL or missing references)
		//IL_183e: Expected O, but got Unknown
		//IL_1850: Unknown result type (might be due to invalid IL or missing references)
		//IL_185a: Expected O, but got Unknown
		//IL_186c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1876: Expected O, but got Unknown
		//IL_1888: Unknown result type (might be due to invalid IL or missing references)
		//IL_1892: Expected O, but got Unknown
		//IL_18a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ae: Expected O, but got Unknown
		//IL_18c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ca: Expected O, but got Unknown
		//IL_18dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e6: Expected O, but got Unknown
		//IL_194d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1957: Expected O, but got Unknown
		//IL_1a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3e: Expected O, but got Unknown
		//IL_1b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3a: Expected O, but got Unknown
		//IL_1c28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c32: Expected O, but got Unknown
		//IL_1d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d2b: Expected O, but got Unknown
		//IL_1e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e18: Expected O, but got Unknown
		//IL_1ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eeb: Expected O, but got Unknown
		//IL_1fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc1: Expected O, but got Unknown
		//IL_20af: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b9: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm6));
		tableLayoutPanel_0 = new TableLayoutPanel();
		tableLayoutPanel_1 = new TableLayoutPanel();
		label_0 = new Label();
		label_1 = new Label();
		tableLayoutPanel_2 = new TableLayoutPanel();
		button_0 = new Button();
		button_1 = new Button();
		linkLabel_0 = new LinkLabel();
		pictureBox_0 = new PictureBox();
		tabControl_0 = new TabControl();
		tabPage_0 = new TabPage();
		groupBox_0 = new GroupBox();
		tableLayoutPanel_3 = new TableLayoutPanel();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		label_5 = new Label();
		label_6 = new Label();
		label_7 = new Label();
		label_8 = new Label();
		label_9 = new Label();
		label_10 = new Label();
		pictureBox_1 = new PictureBox();
		tabPage_1 = new TabPage();
		groupBox_1 = new GroupBox();
		tableLayoutPanel_4 = new TableLayoutPanel();
		label_11 = new Label();
		button_2 = new Button();
		button_3 = new Button();
		button_4 = new Button();
		button_5 = new Button();
		label_12 = new Label();
		label_13 = new Label();
		label_14 = new Label();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)tableLayoutPanel_2).SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((Control)tabControl_0).SuspendLayout();
		((Control)tabPage_0).SuspendLayout();
		((Control)groupBox_0).SuspendLayout();
		((Control)tableLayoutPanel_3).SuspendLayout();
		((ISupportInitialize)pictureBox_1).BeginInit();
		((Control)tabPage_1).SuspendLayout();
		((Control)groupBox_1).SuspendLayout();
		((Control)tableLayoutPanel_4).SuspendLayout();
		((Control)this).SuspendLayout();
		tableLayoutPanel_0.set_ColumnCount(3);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 10f));
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 2f));
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 88f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_1, 1, 0);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_2, 0, 0);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)linkLabel_0, 2, 1);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)pictureBox_0, 0, 1);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tabControl_0, 2, 0);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_0).set_Name(Class60.smethod_0(-2050208027));
		tableLayoutPanel_0.set_RowCount(2);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 90f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)tableLayoutPanel_0).set_Size(new Size(434, 311));
		((Control)tableLayoutPanel_0).set_TabIndex(0);
		tableLayoutPanel_1.set_ColumnCount(1);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_0, 0, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_1, 0, 1);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(43, 6));
		((Control)tableLayoutPanel_1).set_Margin(new Padding(0, 6, 0, 6));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050208091));
		tableLayoutPanel_1.set_RowCount(2);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		((Control)tableLayoutPanel_1).set_Size(new Size(8, 267));
		((Control)tableLayoutPanel_1).set_TabIndex(0);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_BackColor(Color.Goldenrod);
		((Control)label_0).set_Dock((DockStyle)5);
		((Control)label_0).set_Location(new Point(0, 3));
		((Control)label_0).set_Margin(new Padding(0, 3, 0, 3));
		((Control)label_0).set_Name(Class60.smethod_0(-2050201933));
		((Control)label_0).set_Size(new Size(8, 127));
		((Control)label_0).set_TabIndex(0);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_BackColor(Color.Goldenrod);
		((Control)label_1).set_Dock((DockStyle)5);
		((Control)label_1).set_Location(new Point(0, 136));
		((Control)label_1).set_Margin(new Padding(0, 3, 0, 3));
		((Control)label_1).set_Name(Class60.smethod_0(-2050201982));
		((Control)label_1).set_Size(new Size(8, 128));
		((Control)label_1).set_TabIndex(1);
		((Control)label_1).set_Visible(false);
		tableLayoutPanel_2.set_ColumnCount(1);
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tableLayoutPanel_2.get_Controls().Add((Control)(object)button_0, 0, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)button_1, 0, 1);
		((Control)tableLayoutPanel_2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_2).set_Location(new Point(0, 6));
		((Control)tableLayoutPanel_2).set_Margin(new Padding(0, 6, 0, 6));
		((Control)tableLayoutPanel_2).set_Name(Class60.smethod_0(-2050211088));
		tableLayoutPanel_2.set_RowCount(2);
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		((Control)tableLayoutPanel_2).set_Size(new Size(43, 267));
		((Control)tableLayoutPanel_2).set_TabIndex(1);
		((Control)button_0).set_BackColor(Color.IndianRed);
		((Control)button_0).set_Cursor(Cursors.get_Hand());
		((Control)button_0).set_Dock((DockStyle)5);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)0);
		((Control)button_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_0).set_ForeColor(SystemColors.Control);
		((Control)button_0).set_Location(new Point(3, 3));
		((Control)button_0).set_Name(Class60.smethod_0(-2050201964));
		((Control)button_0).set_Size(new Size(37, 127));
		((Control)button_0).set_TabIndex(0);
		((Control)button_0).set_Text(Class60.smethod_0(-2050202013));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)button_1).set_BackColor(Color.IndianRed);
		((Control)button_1).set_Cursor(Cursors.get_Hand());
		((Control)button_1).set_Dock((DockStyle)5);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)0);
		((Control)button_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_1).set_ForeColor(SystemColors.Control);
		((Control)button_1).set_Location(new Point(3, 136));
		((Control)button_1).set_Name(Class60.smethod_0(-2050202044));
		((Control)button_1).set_Size(new Size(37, 128));
		((Control)button_1).set_TabIndex(1);
		((Control)button_1).set_Text(Class60.smethod_0(-2050202026));
		((ButtonBase)button_1).set_UseVisualStyleBackColor(false);
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)linkLabel_0).set_AutoSize(true);
		((Control)linkLabel_0).set_Dock((DockStyle)3);
		((Control)linkLabel_0).set_Font(new Font(Class60.smethod_0(-2050208051), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)222));
		linkLabel_0.set_LinkColor(SystemColors.ControlLightLight);
		((Control)linkLabel_0).set_Location(new Point(54, 279));
		((Control)linkLabel_0).set_Name(Class60.smethod_0(-2050202053));
		((Control)linkLabel_0).set_Size(new Size(80, 32));
		((Control)linkLabel_0).set_TabIndex(9);
		linkLabel_0.set_TabStop(true);
		((Control)linkLabel_0).set_Text(Class60.smethod_0(-2050211265));
		((Label)linkLabel_0).set_TextAlign((ContentAlignment)16);
		linkLabel_0.set_VisitedLinkColor(Color.Blue);
		linkLabel_0.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel_0_LinkClicked));
		((Control)pictureBox_0).set_BackgroundImageLayout((ImageLayout)3);
		((Control)pictureBox_0).set_Dock((DockStyle)4);
		pictureBox_0.set_Image((Image)(object)Class41.smethod_7());
		((Control)pictureBox_0).set_Location(new Point(14, 282));
		((Control)pictureBox_0).set_Name(Class60.smethod_0(-2050211112));
		((Control)pictureBox_0).set_Size(new Size(26, 26));
		pictureBox_0.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox_0.set_TabIndex(10);
		pictureBox_0.set_TabStop(false);
		((Control)tabControl_0).get_Controls().Add((Control)(object)tabPage_0);
		((Control)tabControl_0).get_Controls().Add((Control)(object)tabPage_1);
		((Control)tabControl_0).set_Dock((DockStyle)5);
		tabControl_0.set_DrawMode((TabDrawMode)1);
		tabControl_0.set_ItemSize(new Size(0, 1));
		((Control)tabControl_0).set_Location(new Point(51, 3));
		((Control)tabControl_0).set_Margin(new Padding(0, 3, 0, 3));
		((Control)tabControl_0).set_Name(Class60.smethod_0(-2050202111));
		tabControl_0.set_SelectedIndex(0);
		((Control)tabControl_0).set_Size(new Size(383, 273));
		tabControl_0.set_SizeMode((TabSizeMode)2);
		((Control)tabControl_0).set_TabIndex(11);
		((Control)tabControl_0).set_TabStop(false);
		((Control)tabPage_0).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_0).get_Controls().Add((Control)(object)groupBox_0);
		tabPage_0.set_Location(new Point(4, 5));
		((Control)tabPage_0).set_Name(Class60.smethod_0(-2050206984));
		((Control)tabPage_0).set_Padding(new Padding(3));
		((Control)tabPage_0).set_Size(new Size(375, 264));
		tabPage_0.set_TabIndex(0);
		((Control)tabPage_0).set_Text(Class60.smethod_0(-2050206984));
		((Control)groupBox_0).get_Controls().Add((Control)(object)tableLayoutPanel_3);
		((Control)groupBox_0).set_Dock((DockStyle)5);
		((Control)groupBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)groupBox_0).set_ForeColor(SystemColors.Control);
		((Control)groupBox_0).set_Location(new Point(3, 3));
		((Control)groupBox_0).set_Name(Class60.smethod_0(-2050210886));
		((Control)groupBox_0).set_Size(new Size(369, 258));
		((Control)groupBox_0).set_TabIndex(1);
		groupBox_0.set_TabStop(false);
		((Control)groupBox_0).set_Text(Class60.smethod_0(-2050202013));
		tableLayoutPanel_3.set_ColumnCount(2);
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 35f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 65f));
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_2, 0, 2);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_3, 0, 3);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_4, 0, 4);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_5, 1, 1);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_6, 1, 2);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_7, 1, 3);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_8, 1, 4);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_9, 0, 5);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_10, 1, 5);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)pictureBox_1, 0, 1);
		((Control)tableLayoutPanel_3).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_3).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_3).set_Name(Class60.smethod_0(-2050211259));
		tableLayoutPanel_3.set_RowCount(7);
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 2f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 32f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 12f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 12f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 12f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 12f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 18f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)tableLayoutPanel_3).set_Size(new Size(363, 233));
		((Control)tableLayoutPanel_3).set_TabIndex(0);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Dock((DockStyle)4);
		((Control)label_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_2).set_Location(new Point(81, 78));
		((Control)label_2).set_Name(Class60.smethod_0(-2050210921));
		((Control)label_2).set_Size(new Size(43, 27));
		((Control)label_2).set_TabIndex(1);
		((Control)label_2).set_Text(Class60.smethod_0(-2050202093));
		label_2.set_TextAlign((ContentAlignment)64);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Dock((DockStyle)4);
		((Control)label_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_3).set_Location(new Point(36, 105));
		((Control)label_3).set_Name(Class60.smethod_0(-2050210999));
		((Control)label_3).set_Size(new Size(88, 27));
		((Control)label_3).set_TabIndex(2);
		((Control)label_3).set_Text(Class60.smethod_0(-2050202116));
		label_3.set_TextAlign((ContentAlignment)64);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Dock((DockStyle)4);
		((Control)label_4).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_4).set_Location(new Point(41, 132));
		((Control)label_4).set_Name(Class60.smethod_0(-2050207156));
		((Control)label_4).set_Size(new Size(83, 27));
		((Control)label_4).set_TabIndex(3);
		((Control)label_4).set_Text(Class60.smethod_0(-2050202157));
		label_4.set_TextAlign((ContentAlignment)64);
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_Dock((DockStyle)5);
		((Control)label_5).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_5).set_Location(new Point(130, 4));
		((Control)label_5).set_Name(Class60.smethod_0(-2050202230));
		((Control)label_5).set_Size(new Size(230, 74));
		((Control)label_5).set_TabIndex(6);
		((Control)label_5).set_Text(Class60.smethod_0(-2050207089));
		label_5.set_TextAlign((ContentAlignment)16);
		((Control)label_6).set_AutoSize(true);
		((Control)label_6).set_Dock((DockStyle)5);
		((Control)label_6).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_6).set_Location(new Point(130, 78));
		((Control)label_6).set_Name(Class60.smethod_0(-2050202211));
		((Control)label_6).set_Size(new Size(230, 27));
		((Control)label_6).set_TabIndex(7);
		((Control)label_6).set_Text(Class60.smethod_0(-2050207089));
		label_6.set_TextAlign((ContentAlignment)16);
		((Control)label_7).set_AutoSize(true);
		((Control)label_7).set_Dock((DockStyle)5);
		((Control)label_7).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_7).set_ForeColor(Color.DarkRed);
		((Control)label_7).set_Location(new Point(130, 105));
		((Control)label_7).set_Name(Class60.smethod_0(-2050202259));
		((Control)label_7).set_Size(new Size(230, 27));
		((Control)label_7).set_TabIndex(8);
		((Control)label_7).set_Text(Class60.smethod_0(-2050207089));
		label_7.set_TextAlign((ContentAlignment)16);
		((Control)label_8).set_AutoSize(true);
		((Control)label_8).set_Dock((DockStyle)5);
		((Control)label_8).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_8).set_ForeColor(Color.MediumSeaGreen);
		((Control)label_8).set_Location(new Point(130, 132));
		((Control)label_8).set_Name(Class60.smethod_0(-2050202243));
		((Control)label_8).set_Size(new Size(230, 27));
		((Control)label_8).set_TabIndex(9);
		((Control)label_8).set_Text(Class60.smethod_0(-2050207089));
		label_8.set_TextAlign((ContentAlignment)16);
		((Control)label_9).set_AutoSize(true);
		((Control)label_9).set_Dock((DockStyle)4);
		((Control)label_9).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_9).set_Location(new Point(23, 159));
		((Control)label_9).set_Name(Class60.smethod_0(-2050202302));
		((Control)label_9).set_Size(new Size(101, 27));
		((Control)label_9).set_TabIndex(10);
		((Control)label_9).set_Text(Class60.smethod_0(-2050202273));
		label_9.set_TextAlign((ContentAlignment)64);
		((Control)label_10).set_AutoSize(true);
		((Control)label_10).set_Dock((DockStyle)5);
		((Control)label_10).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_10).set_Location(new Point(130, 159));
		((Control)label_10).set_Name(Class60.smethod_0(-2050202356));
		((Control)label_10).set_Size(new Size(230, 27));
		((Control)label_10).set_TabIndex(11);
		((Control)label_10).set_Text(Class60.smethod_0(-2050207089));
		label_10.set_TextAlign((ContentAlignment)16);
		((Control)pictureBox_1).set_Dock((DockStyle)4);
		((Control)pictureBox_1).set_Location(new Point(76, 16));
		((Control)pictureBox_1).set_Margin(new Padding(76, 12, 0, 12));
		((Control)pictureBox_1).set_Name(Class60.smethod_0(-2050211308));
		((Control)pictureBox_1).set_Size(new Size(51, 50));
		pictureBox_1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox_1.set_TabIndex(12);
		pictureBox_1.set_TabStop(false);
		((Control)tabPage_1).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_1).get_Controls().Add((Control)(object)groupBox_1);
		tabPage_1.set_Location(new Point(4, 5));
		((Control)tabPage_1).set_Name(Class60.smethod_0(-2050199988));
		((Control)tabPage_1).set_Padding(new Padding(3));
		((Control)tabPage_1).set_Size(new Size(375, 264));
		tabPage_1.set_TabIndex(1);
		((Control)tabPage_1).set_Text(Class60.smethod_0(-2050199988));
		((Control)groupBox_1).get_Controls().Add((Control)(object)tableLayoutPanel_4);
		((Control)groupBox_1).set_Dock((DockStyle)5);
		((Control)groupBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5));
		((Control)groupBox_1).set_ForeColor(SystemColors.Control);
		((Control)groupBox_1).set_Location(new Point(3, 3));
		((Control)groupBox_1).set_Name(Class60.smethod_0(-2050207223));
		((Control)groupBox_1).set_Size(new Size(369, 258));
		((Control)groupBox_1).set_TabIndex(1);
		groupBox_1.set_TabStop(false);
		((Control)groupBox_1).set_Text(Class60.smethod_0(-2050202338));
		tableLayoutPanel_4.set_ColumnCount(2);
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_11, 1, 2);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)button_2, 1, 1);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)button_3, 0, 1);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)button_4, 0, 4);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)button_5, 1, 4);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_12, 0, 2);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_13, 0, 5);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_14, 1, 5);
		((Control)tableLayoutPanel_4).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_4).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_4).set_Name(Class60.smethod_0(-2050211375));
		tableLayoutPanel_4.set_RowCount(7);
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 2f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 34f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 11f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 6f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 34f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 11f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 2f));
		((Control)tableLayoutPanel_4).set_Size(new Size(363, 233));
		((Control)tableLayoutPanel_4).set_TabIndex(0);
		((Control)label_11).set_AutoSize(true);
		((Control)label_11).set_BackColor(Color.SeaGreen);
		((Control)label_11).set_Dock((DockStyle)5);
		((Control)label_11).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_11).set_ForeColor(Color.Gold);
		((Control)label_11).set_Location(new Point(184, 83));
		((Control)label_11).set_Name(Class60.smethod_0(-2050202403));
		((Control)label_11).set_Size(new Size(176, 25));
		((Control)label_11).set_TabIndex(5);
		((Control)label_11).set_Text(Class60.smethod_0(-2050202464));
		label_11.set_TextAlign((ContentAlignment)32);
		((Control)label_11).set_Visible(false);
		((Control)button_2).set_BackColor(Color.LightSeaGreen);
		((Control)button_2).set_Cursor(Cursors.get_Hand());
		((Control)button_2).set_Dock((DockStyle)5);
		((ButtonBase)button_2).set_FlatStyle((FlatStyle)0);
		((Control)button_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_2).set_ForeColor(Color.DarkRed);
		((Control)button_2).set_Location(new Point(184, 7));
		((Control)button_2).set_Name(Class60.smethod_0(-2050202448));
		((Control)button_2).set_Size(new Size(176, 73));
		((Control)button_2).set_TabIndex(1);
		((Control)button_2).set_Text(Class60.smethod_0(-2050202493));
		((ButtonBase)button_2).set_UseVisualStyleBackColor(false);
		((Control)button_2).set_Visible(false);
		((Control)button_2).add_Click((EventHandler)button_2_Click);
		((Control)button_3).set_BackColor(Color.LightSeaGreen);
		((Control)button_3).set_Cursor(Cursors.get_Hand());
		((Control)button_3).set_Dock((DockStyle)5);
		((ButtonBase)button_3).set_FlatStyle((FlatStyle)0);
		((Control)button_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_3).set_ForeColor(Color.Maroon);
		((Control)button_3).set_Location(new Point(3, 7));
		((Control)button_3).set_Name(Class60.smethod_0(-2050202522));
		((Control)button_3).set_Size(new Size(175, 73));
		((Control)button_3).set_TabIndex(0);
		((Control)button_3).set_Text(Class60.smethod_0(-2050202551));
		((ButtonBase)button_3).set_UseVisualStyleBackColor(false);
		((Control)button_3).set_Visible(false);
		((Control)button_3).add_Click((EventHandler)button_3_Click);
		((Control)button_4).set_BackColor(Color.LightSeaGreen);
		((Control)button_4).set_Cursor(Cursors.get_Hand());
		((Control)button_4).set_Dock((DockStyle)5);
		((ButtonBase)button_4).set_FlatStyle((FlatStyle)0);
		((Control)button_4).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_4).set_ForeColor(Color.DarkRed);
		((Control)button_4).set_Location(new Point(3, 124));
		((Control)button_4).set_Name(Class60.smethod_0(-2050202584));
		((Control)button_4).set_Size(new Size(175, 73));
		((Control)button_4).set_TabIndex(2);
		((Control)button_4).set_Text(Class60.smethod_0(-2050202565));
		((ButtonBase)button_4).set_UseVisualStyleBackColor(false);
		((Control)button_4).set_Visible(false);
		((Control)button_4).add_Click((EventHandler)button_4_Click);
		((Control)button_5).set_BackColor(Color.LightSeaGreen);
		((Control)button_5).set_Cursor(Cursors.get_Hand());
		((Control)button_5).set_Dock((DockStyle)5);
		((ButtonBase)button_5).set_FlatStyle((FlatStyle)0);
		((Control)button_5).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_5).set_ForeColor(Color.DarkRed);
		((Control)button_5).set_Location(new Point(184, 124));
		((Control)button_5).set_Name(Class60.smethod_0(-2050202598));
		((Control)button_5).set_Size(new Size(176, 73));
		((Control)button_5).set_TabIndex(3);
		((Control)button_5).set_Text(Class60.smethod_0(-2050196499));
		((ButtonBase)button_5).set_UseVisualStyleBackColor(false);
		((Control)button_5).set_Visible(false);
		((Control)button_5).add_Click((EventHandler)button_5_Click);
		((Control)label_12).set_AutoSize(true);
		((Control)label_12).set_BackColor(Color.SeaGreen);
		((Control)label_12).set_Dock((DockStyle)5);
		((Control)label_12).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_12).set_ForeColor(Color.Gold);
		((Control)label_12).set_Location(new Point(3, 83));
		((Control)label_12).set_Name(Class60.smethod_0(-2050196542));
		((Control)label_12).set_Size(new Size(175, 25));
		((Control)label_12).set_TabIndex(4);
		((Control)label_12).set_Text(Class60.smethod_0(-2050196523));
		label_12.set_TextAlign((ContentAlignment)32);
		((Control)label_12).set_Visible(false);
		((Control)label_13).set_AutoSize(true);
		((Control)label_13).set_BackColor(Color.SeaGreen);
		((Control)label_13).set_Dock((DockStyle)5);
		((Control)label_13).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_13).set_ForeColor(Color.Gold);
		((Control)label_13).set_Location(new Point(3, 200));
		((Control)label_13).set_Name(Class60.smethod_0(-2050196571));
		((Control)label_13).set_Size(new Size(175, 25));
		((Control)label_13).set_TabIndex(6);
		((Control)label_13).set_Text(Class60.smethod_0(-2050196600));
		label_13.set_TextAlign((ContentAlignment)32);
		((Control)label_13).set_Visible(false);
		((Control)label_14).set_AutoSize(true);
		((Control)label_14).set_BackColor(Color.SeaGreen);
		((Control)label_14).set_Dock((DockStyle)5);
		((Control)label_14).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_14).set_ForeColor(Color.Gold);
		((Control)label_14).set_Location(new Point(184, 200));
		((Control)label_14).set_Name(Class60.smethod_0(-2050196583));
		((Control)label_14).set_Size(new Size(176, 25));
		((Control)label_14).set_TabIndex(7);
		((Control)label_14).set_Text(Class60.smethod_0(-2050196628));
		label_14.set_TextAlign((ContentAlignment)32);
		((Control)label_14).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkSlateGray);
		((Form)this).set_ClientSize(new Size(434, 311));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(Class60.smethod_0(-2050208183)));
		((Control)this).set_Name(Class60.smethod_0(-2050196624));
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(Class60.smethod_0(-2050196669));
		((Form)this).add_Load((EventHandler)GForm6_Load);
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((Control)tableLayoutPanel_0).PerformLayout();
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)tableLayoutPanel_1).PerformLayout();
		((Control)tableLayoutPanel_2).ResumeLayout(false);
		((ISupportInitialize)pictureBox_0).EndInit();
		((Control)tabControl_0).ResumeLayout(false);
		((Control)tabPage_0).ResumeLayout(false);
		((Control)groupBox_0).ResumeLayout(false);
		((Control)tableLayoutPanel_3).ResumeLayout(false);
		((Control)tableLayoutPanel_3).PerformLayout();
		((ISupportInitialize)pictureBox_1).EndInit();
		((Control)tabPage_1).ResumeLayout(false);
		((Control)groupBox_1).ResumeLayout(false);
		((Control)tableLayoutPanel_4).ResumeLayout(false);
		((Control)tableLayoutPanel_4).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void method_1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void method_2(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void method_3(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void method_4(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
