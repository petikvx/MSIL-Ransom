using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UNIVERSALGAME.Models;
using UNIVERSALGAME.Properties;

public sealed class GForm0 : Form
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct0 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm0 gform0_0;

		private TaskAwaiter<GClass1> taskAwaiter_0;

		private GClass1 gclass1_0;

		private TaskAwaiter<GClass15> taskAwaiter_1;

		private void MoveNext()
		{
			//IL_0395: Unknown result type (might be due to invalid IL or missing references)
			//IL_041e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0473: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0515: Expected O, but got Unknown
			//IL_0510: Unknown result type (might be due to invalid IL or missing references)
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				try
				{
					TaskAwaiter<GClass1> awaiter3;
					TaskAwaiter<GClass1> awaiter2;
					TaskAwaiter<GClass15> awaiter;
					GClass1 gClass;
					GClass15 result;
					GClass15 gClass2;
					GClass1 result2;
					GClass1 gClass3;
					UserLogin userLogin;
					switch (num)
					{
					default:
						if (!string.IsNullOrEmpty(((Control)gForm.textBox_0).get_Text()) && !string.IsNullOrEmpty(((Control)gForm.textBox_1).get_Text()))
						{
							userLogin = new UserLogin();
							userLogin.Email = ((Control)gForm.textBox_0).get_Text().ToLower().Trim();
							userLogin.Password = ((Control)gForm.textBox_1).get_Text().Trim();
							userLogin.Client = Class55.smethod_1(Class55.smethod_0());
							awaiter3 = GClass6.smethod_1(userLogin).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 0;
								int_0 = 0;
								taskAwaiter_0 = awaiter3;
								asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_011f;
						}
						((Control)gForm.label_3).set_Text(Class60.smethod_0(-2050208399));
						((Control)gForm.label_3).set_Visible(true);
						((Control)gForm.textBox_0).Focus();
						goto end_IL_000e;
					case 0:
						awaiter3 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<GClass1>);
						num = -1;
						int_0 = -1;
						goto IL_011f;
					case 1:
						awaiter2 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<GClass1>);
						num = -1;
						int_0 = -1;
						goto IL_0208;
					case 2:
						{
							awaiter = taskAwaiter_1;
							taskAwaiter_1 = default(TaskAwaiter<GClass15>);
							num = -1;
							int_0 = -1;
							goto IL_0309;
						}
						IL_0208:
						gClass = (gclass1_0 = awaiter2.GetResult());
						userLogin = null;
						if (gForm.checkBox_0.get_Checked())
						{
							Settings.Default.Username = ((Control)gForm.textBox_0).get_Text().Trim();
							Settings.Default.Password = ((Control)gForm.textBox_1).get_Text().Trim();
							((SettingsBase)Settings.Default).Save();
						}
						else if (!string.IsNullOrEmpty(Settings.Default.Username) && !string.IsNullOrEmpty(Settings.Default.Password))
						{
							Settings.Default.Username = string.Empty;
							Settings.Default.Password = string.Empty;
							((SettingsBase)Settings.Default).Save();
						}
						awaiter = GClass6.smethod_3().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 2;
							int_0 = 2;
							taskAwaiter_1 = awaiter;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0309;
						IL_0309:
						result = awaiter.GetResult();
						gClass2 = result;
						if (gForm.string_0.Equals(gClass2.Version))
						{
							if (GClass6.smethod_0().Equals(7) && Process.GetProcessesByName(Class60.smethod_0(-2050208285)).Length > 1)
							{
								GForm2 gForm2 = new GForm2();
								try
								{
									((Control)gForm).Hide();
									((Form)gForm2).add_Closed((EventHandler)gForm.method_1);
									gForm2.string_0 = gForm.string_0;
									gForm2.int_0 = gForm.int_0;
									gForm2.gclass1_0 = gclass1_0;
									((Form)gForm2).ShowDialog();
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)(object)gForm2)?.Dispose();
									}
								}
							}
							else if (GClass6.smethod_0().Equals(1) && Process.GetProcessesByName(Class60.smethod_0(-2050208285)).Length > 1 && gForm.bool_0)
							{
								GForm2 gForm3 = new GForm2();
								try
								{
									((Control)gForm).Hide();
									((Form)gForm3).add_Closed((EventHandler)gForm.method_2);
									gForm3.string_0 = gForm.string_0;
									gForm3.int_0 = gForm.int_0;
									gForm3.gclass1_0 = gclass1_0;
									((Form)gForm3).ShowDialog();
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)(object)gForm3)?.Dispose();
									}
								}
							}
							else
							{
								GForm8 gForm4 = new GForm8();
								try
								{
									((Control)gForm).Hide();
									((Form)gForm4).add_Closed((EventHandler)gForm.method_3);
									gForm4.gclass1_0 = gclass1_0;
									gForm4.string_0 = gForm.string_0;
									((Form)gForm4).ShowDialog();
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)(object)gForm4)?.Dispose();
									}
								}
							}
						}
						else
						{
							GForm10 gForm5 = new GForm10();
							try
							{
								((Control)gForm).Hide();
								((Form)gForm5).add_Closed((EventHandler)gForm.method_4);
								gForm5.string_0 = gClass2.Version;
								((Form)gForm5).ShowDialog();
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)(object)gForm5)?.Dispose();
								}
							}
						}
						gclass1_0 = null;
						break;
						IL_011f:
						result2 = awaiter3.GetResult();
						gClass3 = result2;
						if (gClass3 != null)
						{
							if (!gClass3.DisplayName.Equals(Class60.smethod_0(-2050208239)))
							{
								awaiter2 = GClass6.smethod_2().GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num = 1;
									int_0 = 1;
									taskAwaiter_0 = awaiter2;
									asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0208;
							}
							((Control)gForm.label_3).set_Text(Class60.smethod_0(-2050208269));
							((Control)gForm.label_3).set_Visible(true);
							((Control)gForm.textBox_1).Focus();
							break;
						}
						((Control)gForm.label_3).set_Text(Class60.smethod_0(-2050208332));
						((Control)gForm.label_3).set_Visible(true);
						((Control)gForm.textBox_1).Focus();
						break;
					}
					userLogin = null;
					end_IL_000e:;
				}
				catch (Exception ex)
				{
					Form val = new Form();
					val.set_TopMost(true);
					MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050208456) + ex.ToString(), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
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

	private string string_0 = Class60.smethod_0(-2050208590);

	private bool bool_0;

	private int int_0 = 1;

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private GroupBox groupBox_0;

	private TableLayoutPanel tableLayoutPanel_1;

	private TableLayoutPanel tableLayoutPanel_2;

	private PictureBox pictureBox_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private CheckBox checkBox_0;

	private Button button_0;

	private LinkLabel linkLabel_0;

	private Button button_1;

	private Label label_3;

	private TableLayoutPanel tableLayoutPanel_3;

	private LinkLabel linkLabel_1;

	private PictureBox pictureBox_1;

	private TableLayoutPanel tableLayoutPanel_4;

	private LinkLabel linkLabel_2;

	private LinkLabel linkLabel_3;

	public GForm0(string string_1)
	{
		method_0();
		if (string_1.Equals(Class60.smethod_0(-2050208627)) || string_1.Equals(Class60.smethod_0(-2050208616)))
		{
			int_0 = int.Parse(string_1.Substring(2));
			bool_0 = true;
		}
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if (GClass6.smethod_0().Equals(1) && Process.GetProcessesByName(Class60.smethod_0(-2050208285)).Length > 1 && !bool_0)
		{
			Form val = new Form();
			val.set_TopMost(true);
			MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050208621), Class60.smethod_0(-2050208686), (MessageBoxButtons)0, (MessageBoxIcon)48);
			Application.Exit();
		}
		if (!string.IsNullOrEmpty(Settings.Default.Username) && !string.IsNullOrEmpty(Settings.Default.Password))
		{
			((Control)textBox_0).set_Text(Settings.Default.Username);
			((Control)textBox_1).set_Text(Settings.Default.Password);
			checkBox_0.set_Checked(true);
		}
		if (bool_0)
		{
			button_0.PerformClick();
		}
	}

	private async void button_0_Click(object sender, EventArgs e)
	{
		try
		{
			if (!string.IsNullOrEmpty(((Control)textBox_0).get_Text()) && !string.IsNullOrEmpty(((Control)textBox_1).get_Text()))
			{
				UserLogin userLogin = new UserLogin();
				userLogin.Email = ((Control)textBox_0).get_Text().ToLower().Trim();
				userLogin.Password = ((Control)textBox_1).get_Text().Trim();
				userLogin.Client = Class55.smethod_1(Class55.smethod_0());
				GClass1 gClass = await GClass6.smethod_1(userLogin);
				if (gClass != null)
				{
					if (gClass.DisplayName.Equals(Class60.smethod_0(-2050208239)))
					{
						((Control)label_3).set_Text(Class60.smethod_0(-2050208269));
						((Control)label_3).set_Visible(true);
						((Control)textBox_1).Focus();
						return;
					}
					GClass1 gclass1_ = await GClass6.smethod_2();
					if (checkBox_0.get_Checked())
					{
						Settings.Default.Username = ((Control)textBox_0).get_Text().Trim();
						Settings.Default.Password = ((Control)textBox_1).get_Text().Trim();
						((SettingsBase)Settings.Default).Save();
					}
					else if (!string.IsNullOrEmpty(Settings.Default.Username) && !string.IsNullOrEmpty(Settings.Default.Password))
					{
						Settings.Default.Username = string.Empty;
						Settings.Default.Password = string.Empty;
						((SettingsBase)Settings.Default).Save();
					}
					GClass15 gClass2 = await GClass6.smethod_3();
					if (string_0.Equals(gClass2.Version))
					{
						if (GClass6.smethod_0().Equals(7) && Process.GetProcessesByName(Class60.smethod_0(-2050208285)).Length > 1)
						{
							GForm2 gForm = new GForm2();
							try
							{
								((Control)this).Hide();
								((Form)gForm).add_Closed((EventHandler)method_1);
								gForm.string_0 = string_0;
								gForm.int_0 = int_0;
								gForm.gclass1_0 = gclass1_;
								((Form)gForm).ShowDialog();
							}
							finally
							{
								((IDisposable)(object)gForm)?.Dispose();
							}
						}
						else if (GClass6.smethod_0().Equals(1) && Process.GetProcessesByName(Class60.smethod_0(-2050208285)).Length > 1 && bool_0)
						{
							GForm2 gForm2 = new GForm2();
							try
							{
								((Control)this).Hide();
								((Form)gForm2).add_Closed((EventHandler)method_2);
								gForm2.string_0 = string_0;
								gForm2.int_0 = int_0;
								gForm2.gclass1_0 = gclass1_;
								((Form)gForm2).ShowDialog();
							}
							finally
							{
								((IDisposable)(object)gForm2)?.Dispose();
							}
						}
						else
						{
							GForm8 gForm3 = new GForm8();
							try
							{
								((Control)this).Hide();
								((Form)gForm3).add_Closed((EventHandler)method_3);
								gForm3.gclass1_0 = gclass1_;
								gForm3.string_0 = string_0;
								((Form)gForm3).ShowDialog();
							}
							finally
							{
								((IDisposable)(object)gForm3)?.Dispose();
							}
						}
					}
					else
					{
						GForm10 gForm4 = new GForm10();
						try
						{
							((Control)this).Hide();
							((Form)gForm4).add_Closed((EventHandler)method_4);
							gForm4.string_0 = gClass2.Version;
							((Form)gForm4).ShowDialog();
						}
						finally
						{
							((IDisposable)(object)gForm4)?.Dispose();
						}
					}
				}
				else
				{
					((Control)label_3).set_Text(Class60.smethod_0(-2050208332));
					((Control)label_3).set_Visible(true);
					((Control)textBox_1).Focus();
				}
			}
			else
			{
				((Control)label_3).set_Text(Class60.smethod_0(-2050208399));
				((Control)label_3).set_Visible(true);
				((Control)textBox_0).Focus();
			}
		}
		catch (Exception ex)
		{
			Form val = new Form();
			val.set_TopMost(true);
			MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050208456) + ex.ToString(), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void linkLabel_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel_1.set_LinkVisited(true);
		Process.Start(Class60.smethod_0(-2050208733));
	}

	private void linkLabel_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel_2.set_LinkVisited(true);
		Process.Start(Class60.smethod_0(-2050208745));
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel_0.set_LinkVisited(true);
		Process.Start(Class60.smethod_0(-2050207993));
	}

	private void linkLabel_3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel_3.set_LinkVisited(true);
		Process.Start(Class60.smethod_0(-2050207993));
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		Application.Exit();
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
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected O, but got Unknown
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected O, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected O, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected O, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected O, but got Unknown
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected O, but got Unknown
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Expected O, but got Unknown
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected O, but got Unknown
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected O, but got Unknown
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected O, but got Unknown
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected O, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Expected O, but got Unknown
		//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Expected O, but got Unknown
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected O, but got Unknown
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Expected O, but got Unknown
		//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1f: Expected O, but got Unknown
		//IL_0d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0b: Expected O, but got Unknown
		//IL_0dd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddc: Expected O, but got Unknown
		//IL_0e71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7b: Expected O, but got Unknown
		//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e97: Expected O, but got Unknown
		//IL_0ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb3: Expected O, but got Unknown
		//IL_0f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5b: Expected O, but got Unknown
		//IL_0fc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcd: Expected O, but got Unknown
		//IL_1070: Unknown result type (might be due to invalid IL or missing references)
		//IL_107a: Expected O, but got Unknown
		//IL_1141: Unknown result type (might be due to invalid IL or missing references)
		//IL_114b: Expected O, but got Unknown
		//IL_1200: Unknown result type (might be due to invalid IL or missing references)
		//IL_120a: Expected O, but got Unknown
		//IL_1227: Unknown result type (might be due to invalid IL or missing references)
		//IL_1231: Expected O, but got Unknown
		//IL_1243: Unknown result type (might be due to invalid IL or missing references)
		//IL_124d: Expected O, but got Unknown
		//IL_12a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ee: Expected O, but got Unknown
		//IL_1300: Unknown result type (might be due to invalid IL or missing references)
		//IL_130a: Expected O, but got Unknown
		//IL_136f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1379: Expected O, but got Unknown
		//IL_143b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1445: Expected O, but got Unknown
		//IL_1485: Unknown result type (might be due to invalid IL or missing references)
		//IL_148f: Expected O, but got Unknown
		//IL_154d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1557: Expected O, but got Unknown
		//IL_15b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c1: Expected O, but got Unknown
		//IL_15d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e3: Expected O, but got Unknown
		//IL_15e5: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
		tableLayoutPanel_0 = new TableLayoutPanel();
		groupBox_0 = new GroupBox();
		tableLayoutPanel_1 = new TableLayoutPanel();
		label_1 = new Label();
		label_2 = new Label();
		textBox_0 = new TextBox();
		textBox_1 = new TextBox();
		checkBox_0 = new CheckBox();
		tableLayoutPanel_2 = new TableLayoutPanel();
		pictureBox_0 = new PictureBox();
		button_1 = new Button();
		label_0 = new Label();
		button_0 = new Button();
		label_3 = new Label();
		tableLayoutPanel_3 = new TableLayoutPanel();
		linkLabel_1 = new LinkLabel();
		pictureBox_1 = new PictureBox();
		linkLabel_3 = new LinkLabel();
		tableLayoutPanel_4 = new TableLayoutPanel();
		linkLabel_0 = new LinkLabel();
		linkLabel_2 = new LinkLabel();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((Control)groupBox_0).SuspendLayout();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)tableLayoutPanel_2).SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((Control)tableLayoutPanel_3).SuspendLayout();
		((ISupportInitialize)pictureBox_1).BeginInit();
		((Control)tableLayoutPanel_4).SuspendLayout();
		((Control)this).SuspendLayout();
		tableLayoutPanel_0.set_ColumnCount(1);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_0, 0, 2);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_2, 0, 0);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)label_0, 0, 1);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)button_0, 0, 4);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)label_3, 0, 3);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_3, 0, 7);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_4, 0, 5);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_0).set_Name(Class60.smethod_0(-2050208027));
		((Control)tableLayoutPanel_0).set_Padding(new Padding(10));
		tableLayoutPanel_0.set_RowCount(8);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 29f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 7f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 31f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 5f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 7f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 3f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 8f));
		((Control)tableLayoutPanel_0).set_Size(new Size(320, 450));
		((Control)tableLayoutPanel_0).set_TabIndex(0);
		((Control)groupBox_0).get_Controls().Add((Control)(object)tableLayoutPanel_1);
		((Control)groupBox_0).set_Dock((DockStyle)5);
		((Control)groupBox_0).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox_0).set_ForeColor(SystemColors.Window);
		((Control)groupBox_0).set_Location(new Point(13, 167));
		((Control)groupBox_0).set_Name(Class60.smethod_0(-2050210886));
		((Control)groupBox_0).set_Size(new Size(294, 127));
		((Control)groupBox_0).set_TabIndex(0);
		groupBox_0.set_TabStop(false);
		((Control)groupBox_0).set_Text(Class60.smethod_0(-2050210934));
		tableLayoutPanel_1.set_ColumnCount(3);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 30f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 10f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_1, 0, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_2, 0, 1);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)textBox_0, 1, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)textBox_1, 1, 1);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)checkBox_0, 1, 2);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(3, 23));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050208091));
		tableLayoutPanel_1.set_RowCount(3);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 35f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 35f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 30f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)tableLayoutPanel_1).set_Size(new Size(288, 101));
		((Control)tableLayoutPanel_1).set_TabIndex(0);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Dock((DockStyle)4);
		((Control)label_1).set_Font(new Font(Class60.smethod_0(-2050210859), 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_Location(new Point(39, 0));
		((Control)label_1).set_Name(Class60.smethod_0(-2050210921));
		((Control)label_1).set_Size(new Size(44, 35));
		((Control)label_1).set_TabIndex(0);
		((Control)label_1).set_Text(Class60.smethod_0(-2050210972));
		label_1.set_TextAlign((ContentAlignment)64);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Dock((DockStyle)5);
		((Control)label_2).set_Font(new Font(Class60.smethod_0(-2050210859), 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_2).set_Location(new Point(3, 35));
		((Control)label_2).set_Name(Class60.smethod_0(-2050210999));
		((Control)label_2).set_Size(new Size(80, 35));
		((Control)label_2).set_TabIndex(1);
		((Control)label_2).set_Text(Class60.smethod_0(-2050211002));
		label_2.set_TextAlign((ContentAlignment)64);
		((Control)textBox_0).set_Dock((DockStyle)5);
		((Control)textBox_0).set_Font(new Font(Class60.smethod_0(-2050210859), 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_0).set_Location(new Point(89, 3));
		((TextBoxBase)textBox_0).set_MaxLength(50);
		((Control)textBox_0).set_Name(Class60.smethod_0(-2050211039));
		((Control)textBox_0).set_Size(new Size(166, 26));
		((Control)textBox_0).set_TabIndex(2);
		((Control)textBox_1).set_Dock((DockStyle)5);
		((Control)textBox_1).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_1).set_Location(new Point(89, 38));
		((TextBoxBase)textBox_1).set_MaxLength(20);
		((Control)textBox_1).set_Name(Class60.smethod_0(-2050211020));
		((Control)textBox_1).set_Size(new Size(166, 27));
		((Control)textBox_1).set_TabIndex(3);
		textBox_1.set_UseSystemPasswordChar(true);
		((Control)checkBox_0).set_AutoSize(true);
		((Control)checkBox_0).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_0).set_Dock((DockStyle)5);
		((Control)checkBox_0).set_Font(new Font(Class60.smethod_0(-2050210859), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_0).set_Location(new Point(89, 73));
		((Control)checkBox_0).set_Name(Class60.smethod_0(-2050211065));
		((Control)checkBox_0).set_Size(new Size(166, 25));
		((Control)checkBox_0).set_TabIndex(4);
		((Control)checkBox_0).set_Text(Class60.smethod_0(-2050211095));
		((ButtonBase)checkBox_0).set_UseVisualStyleBackColor(true);
		((Control)tableLayoutPanel_2).set_BackColor(Color.DarkSlateGray);
		tableLayoutPanel_2.set_ColumnCount(3);
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		tableLayoutPanel_2.get_Controls().Add((Control)(object)pictureBox_0, 1, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)button_1, 2, 0);
		((Control)tableLayoutPanel_2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_2).set_Location(new Point(13, 13));
		((Control)tableLayoutPanel_2).set_Name(Class60.smethod_0(-2050211088));
		tableLayoutPanel_2.set_RowCount(1);
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)1, 118f));
		((Control)tableLayoutPanel_2).set_Size(new Size(294, 118));
		((Control)tableLayoutPanel_2).set_TabIndex(1);
		((Control)pictureBox_0).set_Dock((DockStyle)5);
		pictureBox_0.set_Image((Image)(object)Class41.smethod_10());
		((Control)pictureBox_0).set_Location(new Point(76, 3));
		((Control)pictureBox_0).set_Name(Class60.smethod_0(-2050211112));
		((Control)pictureBox_0).set_Size(new Size(141, 112));
		pictureBox_0.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox_0.set_TabIndex(0);
		pictureBox_0.set_TabStop(false);
		((Control)button_1).set_Anchor((AnchorStyles)9);
		((Control)button_1).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button_1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)0);
		((Control)button_1).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_1).set_ForeColor(SystemColors.Window);
		((Control)button_1).set_Location(new Point(266, 3));
		((Control)button_1).set_Name(Class60.smethod_0(-2050211158));
		((Control)button_1).set_Size(new Size(25, 25));
		((Control)button_1).set_TabIndex(6);
		((Control)button_1).set_TabStop(false);
		((Control)button_1).set_Text(Class60.smethod_0(-2050211142));
		((ButtonBase)button_1).set_UseVisualStyleBackColor(true);
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_BackColor(Color.Firebrick);
		((Control)label_0).set_Dock((DockStyle)5);
		((Control)label_0).set_Font(new Font(Class60.smethod_0(-2050211150), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_ForeColor(Color.Goldenrod);
		((Control)label_0).set_Location(new Point(13, 134));
		((Control)label_0).set_Name(Class60.smethod_0(-2050208088));
		((Control)label_0).set_Size(new Size(294, 30));
		((Control)label_0).set_TabIndex(2);
		((Control)label_0).set_Text(Class60.smethod_0(-2050211194));
		label_0.set_TextAlign((ContentAlignment)32);
		((Control)button_0).set_BackColor(Color.LightSeaGreen);
		((Control)button_0).set_Cursor(Cursors.get_Hand());
		((Control)button_0).set_Dock((DockStyle)5);
		((ButtonBase)button_0).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)0);
		((Control)button_0).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_0).set_ForeColor(SystemColors.Window);
		((Control)button_0).set_Location(new Point(13, 321));
		((Control)button_0).set_Name(Class60.smethod_0(-2050211228));
		((Control)button_0).set_Size(new Size(294, 37));
		((Control)button_0).set_TabIndex(4);
		((Control)button_0).set_Text(Class60.smethod_0(-2050210934));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Dock((DockStyle)5);
		((Control)label_3).set_Font(new Font(Class60.smethod_0(-2050210859), 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_3).set_ForeColor(Color.Red);
		((Control)label_3).set_Location(new Point(13, 297));
		((Control)label_3).set_Name(Class60.smethod_0(-2050211212));
		((Control)label_3).set_Size(new Size(294, 21));
		((Control)label_3).set_TabIndex(7);
		label_3.set_TextAlign((ContentAlignment)32);
		((Control)label_3).set_Visible(false);
		tableLayoutPanel_3.set_ColumnCount(3);
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 13f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 37f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_3.get_Controls().Add((Control)(object)linkLabel_1, 1, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)pictureBox_1, 0, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)linkLabel_3, 2, 0);
		((Control)tableLayoutPanel_3).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_3).set_Location(new Point(13, 406));
		((Control)tableLayoutPanel_3).set_Name(Class60.smethod_0(-2050211259));
		tableLayoutPanel_3.set_RowCount(1);
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_3).set_Size(new Size(294, 31));
		((Control)tableLayoutPanel_3).set_TabIndex(8);
		((Control)linkLabel_1).set_AutoSize(true);
		((Control)linkLabel_1).set_Cursor(Cursors.get_Hand());
		((Control)linkLabel_1).set_Dock((DockStyle)5);
		((Control)linkLabel_1).set_Font(new Font(Class60.smethod_0(-2050208051), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)222));
		linkLabel_1.set_LinkColor(SystemColors.ControlLightLight);
		((Control)linkLabel_1).set_Location(new Point(41, 0));
		((Control)linkLabel_1).set_Name(Class60.smethod_0(-2050211283));
		((Control)linkLabel_1).set_Size(new Size(102, 31));
		((Control)linkLabel_1).set_TabIndex(0);
		linkLabel_1.set_TabStop(true);
		((Control)linkLabel_1).set_Text(Class60.smethod_0(-2050211265));
		((Label)linkLabel_1).set_TextAlign((ContentAlignment)16);
		linkLabel_1.set_VisitedLinkColor(Color.Blue);
		linkLabel_1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel_1_LinkClicked));
		((Control)pictureBox_1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)pictureBox_1).set_Dock((DockStyle)5);
		pictureBox_1.set_Image((Image)(object)Class41.smethod_7());
		((Control)pictureBox_1).set_Location(new Point(3, 3));
		((Control)pictureBox_1).set_Name(Class60.smethod_0(-2050211308));
		((Control)pictureBox_1).set_Size(new Size(32, 25));
		pictureBox_1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox_1.set_TabIndex(1);
		pictureBox_1.set_TabStop(false);
		((Control)linkLabel_3).set_AutoSize(true);
		((Control)linkLabel_3).set_Cursor(Cursors.get_Hand());
		((Control)linkLabel_3).set_Dock((DockStyle)5);
		((Control)linkLabel_3).set_Font(new Font(Class60.smethod_0(-2050210859), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		linkLabel_3.set_LinkBehavior((LinkBehavior)3);
		linkLabel_3.set_LinkColor(SystemColors.Window);
		((Control)linkLabel_3).set_Location(new Point(149, 0));
		((Control)linkLabel_3).set_Name(Class60.smethod_0(-2050211354));
		((Control)linkLabel_3).set_Size(new Size(142, 31));
		((Control)linkLabel_3).set_TabIndex(2);
		linkLabel_3.set_TabStop(true);
		((Control)linkLabel_3).set_Text(Class60.smethod_0(-2050211383));
		((Label)linkLabel_3).set_TextAlign((ContentAlignment)64);
		linkLabel_3.set_VisitedLinkColor(SystemColors.Window);
		linkLabel_3.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel_3_LinkClicked));
		tableLayoutPanel_4.set_ColumnCount(2);
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_4.get_Controls().Add((Control)(object)linkLabel_0, 1, 0);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)linkLabel_2, 0, 0);
		((Control)tableLayoutPanel_4).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_4).set_Location(new Point(10, 361));
		((Control)tableLayoutPanel_4).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_4).set_Name(Class60.smethod_0(-2050211375));
		tableLayoutPanel_4.set_RowCount(1);
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)1, 30f));
		((Control)tableLayoutPanel_4).set_Size(new Size(300, 30));
		((Control)tableLayoutPanel_4).set_TabIndex(9);
		((Control)linkLabel_0).set_AutoSize(true);
		((Control)linkLabel_0).set_Cursor(Cursors.get_Hand());
		((Control)linkLabel_0).set_Dock((DockStyle)4);
		((Control)linkLabel_0).set_Font(new Font(Class60.smethod_0(-2050210859), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel_0).set_ForeColor(SystemColors.Window);
		linkLabel_0.set_LinkBehavior((LinkBehavior)3);
		linkLabel_0.set_LinkColor(SystemColors.Window);
		((Control)linkLabel_0).set_Location(new Point(192, 0));
		((Control)linkLabel_0).set_Name(Class60.smethod_0(-2050211399));
		((Control)linkLabel_0).set_Size(new Size(105, 30));
		((Control)linkLabel_0).set_TabIndex(5);
		linkLabel_0.set_TabStop(true);
		((Control)linkLabel_0).set_Text(Class60.smethod_0(-2050211441));
		((Label)linkLabel_0).set_TextAlign((ContentAlignment)64);
		linkLabel_0.set_VisitedLinkColor(SystemColors.Window);
		linkLabel_0.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel_0_LinkClicked));
		((Control)linkLabel_2).set_AutoSize(true);
		((Control)linkLabel_2).set_Cursor(Cursors.get_Hand());
		((Control)linkLabel_2).set_Dock((DockStyle)3);
		((Control)linkLabel_2).set_Font(new Font(Class60.smethod_0(-2050210859), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel_2).set_ForeColor(SystemColors.Window);
		linkLabel_2.set_LinkBehavior((LinkBehavior)3);
		linkLabel_2.set_LinkColor(SystemColors.Window);
		((Control)linkLabel_2).set_Location(new Point(3, 0));
		((Control)linkLabel_2).set_Name(Class60.smethod_0(-2050211472));
		((Control)linkLabel_2).set_Size(new Size(75, 30));
		((Control)linkLabel_2).set_TabIndex(6);
		linkLabel_2.set_TabStop(true);
		((Control)linkLabel_2).set_Text(Class60.smethod_0(-2050211492));
		((Label)linkLabel_2).set_TextAlign((ContentAlignment)64);
		linkLabel_2.set_VisitedLinkColor(SystemColors.Window);
		linkLabel_2.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel_2_LinkClicked));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(10f, 21f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkSlateGray);
		((Form)this).set_ClientSize(new Size(320, 450));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		((Control)this).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(Class60.smethod_0(-2050208183)));
		((Form)this).set_Margin(new Padding(5));
		((Control)this).set_MinimumSize(new Size(320, 450));
		((Control)this).set_Name(Class60.smethod_0(-2050211523));
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(Class60.smethod_0(-2050210934));
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((Control)tableLayoutPanel_0).PerformLayout();
		((Control)groupBox_0).ResumeLayout(false);
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)tableLayoutPanel_1).PerformLayout();
		((Control)tableLayoutPanel_2).ResumeLayout(false);
		((ISupportInitialize)pictureBox_0).EndInit();
		((Control)tableLayoutPanel_3).ResumeLayout(false);
		((Control)tableLayoutPanel_3).PerformLayout();
		((ISupportInitialize)pictureBox_1).EndInit();
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
