using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using UNIVERSALGAME.Properties;

public sealed class GForm1 : Form
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct1 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm1 gform1_0;

		private TaskAwaiter<GClass5> taskAwaiter_0;

		private void MoveNext()
		{
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Expected O, but got Unknown
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Expected O, but got Unknown
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0529: Unknown result type (might be due to invalid IL or missing references)
			//IL_052e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0551: Expected O, but got Unknown
			//IL_054c: Unknown result type (might be due to invalid IL or missing references)
			//IL_059e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c6: Expected O, but got Unknown
			//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
			int num = int_0;
			GForm1 gForm = gform1_0;
			try
			{
				try
				{
					TaskAwaiter<GClass5> awaiter;
					if (num == 0)
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<GClass5>);
						num = -1;
						int_0 = -1;
						goto IL_0218;
					}
					if (gForm.bool_0)
					{
						goto IL_01c5;
					}
					gForm.process_0 = gForm.gclass14_0.method_4(Class60.smethod_0(-2050204785));
					if (gForm.process_0 != null && gForm.process_0.Length != 0)
					{
						gForm.intptr_0 = gForm.process_0[0].MainWindowHandle;
					}
					else
					{
						gForm.intptr_0 = IntPtr.Zero;
					}
					if (gForm.intptr_0.ToInt32() > 0)
					{
						if (!gForm.gclass14_0.method_5(gForm.process_0[0].Id, 1))
						{
							Form val = new Form();
							val.set_TopMost(true);
							MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050197103), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
						}
						else
						{
							gForm.gclass14_0.method_1(gForm.process_0[0].Id);
							if (gForm.gclass14_0.method_9(gForm.gclass12_0.MAX_HP) > 0)
							{
								gForm.gclass14_0.method_10(gForm.gclass12_0.MAX_ZOOM, Class60.smethod_0(-2050205505), 1145569280.ToString());
								((Control)gForm.label_0).set_Text(gForm.gclass14_0.method_8(gForm.gclass12_0.NAME));
								gForm.bool_0 = true;
							}
							if (Settings.Default.ROSUPPORT_Lock_Target >= 100000)
							{
								goto IL_01c5;
							}
							Form val2 = new Form();
							val2.set_TopMost(true);
							MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050196404), Class60.smethod_0(-2050208686), (MessageBoxButtons)0, (MessageBoxIcon)16);
							gForm.tabControl_0.set_SelectedIndex(1);
						}
					}
					else
					{
						Form val3 = new Form();
						val3.set_TopMost(true);
						MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050197342), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					goto end_IL_000e;
					IL_01c5:
					awaiter = GClass6.smethod_8().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0218;
					IL_0218:
					GClass5 gClass = (gForm.gclass5_0 = awaiter.GetResult());
					if (gForm.gclass5_0 != null)
					{
						if (gForm.class5_0.IsBusy)
						{
							gForm.class5_0.method_0();
							gForm.class5_0.Dispose();
						}
						if (gForm.checkBox_6.get_Checked())
						{
							gForm.int_3 = Settings.Default.ROSUPPORT_Self_AB_Freq + 1;
						}
						if (gForm.checkBox_5.get_Checked())
						{
							gForm.int_4 = Settings.Default.ROSUPPORT_Self_Kyrie_Freq + 1;
						}
						if (gForm.checkBox_13.get_Checked())
						{
							gForm.int_5 = Settings.Default.ROSUPPORT_Self_Sacrament_Freq + 1;
						}
						if (gForm.checkBox_0.get_Checked())
						{
							gForm.int_6 = Settings.Default.ROSUPPORT_Target_AB_Freq + 1;
						}
						if (gForm.checkBox_1.get_Checked())
						{
							gForm.int_7 = Settings.Default.ROSUPPORT_Target_Kyrie_Freq + 1;
						}
						if (gForm.checkBox_11.get_Checked())
						{
							gForm.int_8 = Settings.Default.ROSUPPORT_Target_ImpositoManus_Freq + 1;
						}
						if (gForm.checkBox_12.get_Checked())
						{
							gForm.int_9 = Settings.Default.ROSUPPORT_Target_Sacrament_Freq + 1;
						}
						if (gForm.checkBox_2.get_Checked())
						{
							gForm.int_10 = Settings.Default.ROSUPPORT_Party_Gloria_Freq + 1;
						}
						if (gForm.checkBox_3.get_Checked())
						{
							gForm.int_11 = Settings.Default.ROSUPPORT_Party_Magnificat_Freq + 1;
						}
						if (gForm.checkBox_9.get_Checked())
						{
							gForm.int_12 = Settings.Default.ROSUPPORT_Party_AB_Freq + 1;
						}
						if (gForm.checkBox_10.get_Checked())
						{
							gForm.int_13 = Settings.Default.ROSUPPORT_Party_Kyrie_Freq + 1;
						}
						if (gForm.checkBox_8.get_Checked())
						{
							gForm.int_14 = Settings.Default.ROSUPPORT_Party_Heal_Freq + 1;
						}
						gForm.list_0 = gForm.gclass12_0.method_0();
						gForm.list_1 = gForm.gclass12_0.method_1();
						gForm.list_2 = gForm.gclass12_0.method_2();
						gForm.list_3 = gForm.gclass12_0.method_3();
						gForm.int_1 = gForm.gclass14_0.method_9(gForm.gclass12_0.CHAR_ID);
						((Control)gForm.button_0).set_Enabled(false);
						((Control)gForm.button_1).set_Enabled(true);
						((Control)gForm.tableLayoutPanel_2).set_Enabled(false);
						((Control)gForm.tableLayoutPanel_4).set_Enabled(false);
						((Control)gForm.tableLayoutPanel_3).set_Enabled(false);
						((Control)gForm.tableLayoutPanel_5).set_Enabled(false);
						((Control)gForm.tableLayoutPanel_7).set_Enabled(false);
						((Control)gForm.tableLayoutPanel_6).set_Enabled(false);
						((Control)gForm.tableLayoutPanel_9).set_Enabled(false);
						((Control)gForm.tableLayoutPanel_8).set_Enabled(false);
						gForm.gclass8_0 = new GClass8((Keys)Enum.Parse(typeof(Keys), Settings.Default.ROSUPPORT_Call_Heal_Hotkey, ignoreCase: true), (Form)(object)gForm);
						gForm.gclass8_0.method_0();
						if (!gForm.class5_1.IsBusy)
						{
							gForm.class5_1.RunWorkerAsync();
						}
						if (!gForm.class5_0.IsBusy)
						{
							gForm.class5_0.RunWorkerAsync();
						}
						if (!gForm.radioButton_1.get_Checked())
						{
							gForm.timer_0.Start();
						}
					}
					else
					{
						gForm.gclass12_0 = null;
						Form val4 = new Form();
						val4.set_TopMost(true);
						MessageBox.Show((IWin32Window)val4, Class60.smethod_0(-2050197399), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
					}
					end_IL_000e:;
				}
				catch
				{
					if (gForm.class5_0.IsBusy)
					{
						gForm.class5_0.method_0();
						gForm.class5_0.Dispose();
					}
					if (gForm.class5_1.IsBusy)
					{
						gForm.class5_1.method_0();
						gForm.class5_1.Dispose();
					}
					Form val5 = new Form();
					val5.set_TopMost(true);
					MessageBox.Show((IWin32Window)val5, Class60.smethod_0(-2050195508), Class60.smethod_0(-2050195508), (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Control)gForm.button_0).set_Enabled(false);
					((Control)gForm.button_1).set_Enabled(false);
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

	[StructLayout(LayoutKind.Auto)]
	private struct Struct2 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm1 gform1_0;

		private TaskAwaiter<GClass12> taskAwaiter_0;

		private void MoveNext()
		{
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected O, but got Unknown
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0407: Unknown result type (might be due to invalid IL or missing references)
			//IL_040c: Unknown result type (might be due to invalid IL or missing references)
			//IL_042f: Expected O, but got Unknown
			//IL_042a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0452: Unknown result type (might be due to invalid IL or missing references)
			//IL_0457: Unknown result type (might be due to invalid IL or missing references)
			//IL_047a: Expected O, but got Unknown
			//IL_0475: Unknown result type (might be due to invalid IL or missing references)
			int num = int_0;
			GForm1 gForm = gform1_0;
			try
			{
				try
				{
					TaskAwaiter<GClass12> awaiter;
					if (num != 0)
					{
						((ListControl)gForm.comboBox_2).set_SelectedIndex(Settings.Default.ROSUPPORT_Self_AB_Freq);
						((ListControl)gForm.comboBox_3).set_SelectedIndex(Settings.Default.ROSUPPORT_Self_Kyrie_Freq);
						((ListControl)gForm.comboBox_12).set_SelectedIndex(Settings.Default.ROSUPPORT_Self_Sacrament_Freq);
						((ListControl)gForm.comboBox_4).set_SelectedIndex(Settings.Default.ROSUPPORT_Target_AB_Freq);
						((ListControl)gForm.comboBox_5).set_SelectedIndex(Settings.Default.ROSUPPORT_Target_Kyrie_Freq);
						((ListControl)gForm.comboBox_6).set_SelectedIndex(Settings.Default.ROSUPPORT_Target_ImpositoManus_Freq);
						((ListControl)gForm.comboBox_13).set_SelectedIndex(Settings.Default.ROSUPPORT_Target_Sacrament_Freq);
						((ListControl)gForm.comboBox_7).set_SelectedIndex(Settings.Default.ROSUPPORT_Party_Gloria_Freq);
						((ListControl)gForm.comboBox_8).set_SelectedIndex(Settings.Default.ROSUPPORT_Party_Magnificat_Freq);
						((ListControl)gForm.comboBox_9).set_SelectedIndex(Settings.Default.ROSUPPORT_Party_AB_Freq);
						((ListControl)gForm.comboBox_10).set_SelectedIndex(Settings.Default.ROSUPPORT_Party_Kyrie_Freq);
						((ListControl)gForm.comboBox_11).set_SelectedIndex(Settings.Default.ROSUPPORT_Party_Heal_Freq);
						((Control)gForm.textBox_0).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.ROSUPPORT_Call_Heal_Hotkey + Class60.smethod_0(-2050195546));
						if (gForm.gclass1_0 == null)
						{
							Form val = new Form();
							val.set_TopMost(true);
							MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050210429), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
							((Form)gForm).Close();
							goto IL_0430;
						}
						gForm.int_0 = Settings.Default.Server_Index;
						awaiter = GClass6.smethod_5(gForm.int_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<GClass12>);
						num = -1;
						int_0 = -1;
					}
					GClass12 gClass = (gForm.gclass12_0 = awaiter.GetResult());
					if (gForm.gclass12_0 != null)
					{
						gForm.gclass14_0.string_0 = gForm.gclass12_0.BASE_ADDRESS;
						gForm.gclass14_0.string_1 = gForm.gclass12_0.MAX_HP;
						string[] files = Directory.GetFiles(Class60.smethod_0(-2050209934), Class60.smethod_0(-2050209980), SearchOption.TopDirectoryOnly);
						if (files == null || files.Length == 0)
						{
							File.WriteAllBytes(Class60.smethod_0(-2050209961), Class41.smethod_12());
							Thread.Sleep(1000);
							files = Directory.GetFiles(Class60.smethod_0(-2050209934), Class60.smethod_0(-2050209980), SearchOption.TopDirectoryOnly);
						}
						if (files != null && files.Length != 0)
						{
							try
							{
								GClass6.smethod_10();
								GClass13.smethod_3(Class60.smethod_0(-2050209995), Class60.smethod_0(-2050210047));
								GClass13.smethod_3(Class60.smethod_0(-2050210068), Class60.smethod_0(-2050210056));
								GClass13.smethod_3(Class60.smethod_0(-2050210107), Class60.smethod_0(-2050210095));
								GClass13.smethod_3(Class60.smethod_0(-2050210114), Class60.smethod_0(-2050210166));
								GClass13.smethod_3(Class60.smethod_0(-2050210154), Class60.smethod_0(-2050210206));
								GClass13.smethod_3(Class60.smethod_0(-2050210240), Class60.smethod_0(-2050210212));
							}
							catch
							{
							}
							try
							{
								File.Delete(Class60.smethod_0(-2050210047));
							}
							catch
							{
							}
							try
							{
								File.Delete(Class60.smethod_0(-2050210056));
							}
							catch
							{
							}
							try
							{
								File.Delete(Class60.smethod_0(-2050210095));
							}
							catch
							{
							}
							try
							{
								File.Delete(Class60.smethod_0(-2050210166));
							}
							catch
							{
							}
							try
							{
								File.Delete(Class60.smethod_0(-2050210206));
							}
							catch
							{
							}
							try
							{
								File.Delete(Class60.smethod_0(-2050210212));
							}
							catch
							{
							}
						}
						gForm.timer_0 = new System.Timers.Timer(5000.0);
						gForm.timer_0.Enabled = true;
						gForm.timer_0.Elapsed += gForm.method_1;
						gForm.timer_0.Stop();
						((Control)gForm.button_0).set_Enabled(true);
					}
					else
					{
						Form val2 = new Form();
						val2.set_TopMost(true);
						MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050203423), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
					}
					goto IL_0430;
					IL_0430:
					gForm.bool_1 = false;
				}
				catch
				{
					((Control)gForm.button_0).set_Enabled(false);
					((Control)gForm.button_1).set_Enabled(false);
					Form val3 = new Form();
					val3.set_TopMost(true);
					MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050203472), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)gForm).Close();
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

	private sealed class Class5 : BackgroundWorker
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

	private Dictionary<string, int> dictionary_0 = new Dictionary<string, int>
	{
		{
			Class60.smethod_0(-2050210591),
			13
		},
		{
			Class60.smethod_0(-2050210562),
			27
		},
		{
			Class60.smethod_0(-2050210613),
			45
		},
		{
			Class60.smethod_0(-2050210600),
			112
		},
		{
			Class60.smethod_0(-2050210607),
			113
		},
		{
			Class60.smethod_0(-2050210646),
			114
		},
		{
			Class60.smethod_0(-2050210653),
			115
		},
		{
			Class60.smethod_0(-2050210628),
			116
		},
		{
			Class60.smethod_0(-2050210635),
			117
		},
		{
			Class60.smethod_0(-2050210674),
			118
		},
		{
			Class60.smethod_0(-2050210681),
			119
		},
		{
			Class60.smethod_0(-2050210672),
			120
		},
		{
			Class60.smethod_0(-2050210711),
			121
		},
		{
			Class60.smethod_0(-2050210717),
			122
		},
		{
			Class60.smethod_0(-2050210691),
			123
		},
		{
			Class60.smethod_0(-2050210697),
			65
		},
		{
			Class60.smethod_0(-2050210737),
			66
		},
		{
			Class60.smethod_0(-2050210745),
			67
		},
		{
			Class60.smethod_0(-2050210721),
			68
		},
		{
			Class60.smethod_0(-2050210729),
			69
		},
		{
			Class60.smethod_0(-2050210769),
			70
		},
		{
			Class60.smethod_0(-2050210777),
			71
		},
		{
			Class60.smethod_0(-2050210753),
			72
		},
		{
			Class60.smethod_0(-2050210761),
			73
		},
		{
			Class60.smethod_0(-2050210801),
			74
		},
		{
			Class60.smethod_0(-2050210809),
			75
		},
		{
			Class60.smethod_0(-2050210785),
			76
		},
		{
			Class60.smethod_0(-2050210793),
			77
		},
		{
			Class60.smethod_0(-2050204689),
			78
		},
		{
			Class60.smethod_0(-2050204697),
			79
		},
		{
			Class60.smethod_0(-2050204673),
			80
		},
		{
			Class60.smethod_0(-2050204681),
			81
		},
		{
			Class60.smethod_0(-2050204721),
			82
		},
		{
			Class60.smethod_0(-2050204729),
			83
		},
		{
			Class60.smethod_0(-2050204705),
			84
		},
		{
			Class60.smethod_0(-2050204713),
			85
		},
		{
			Class60.smethod_0(-2050204753),
			86
		},
		{
			Class60.smethod_0(-2050204761),
			87
		},
		{
			Class60.smethod_0(-2050211142),
			88
		},
		{
			Class60.smethod_0(-2050204737),
			89
		},
		{
			Class60.smethod_0(-2050204745),
			90
		}
	};

	public GClass1 gclass1_0;

	private IntPtr intptr_0;

	private GClass14 gclass14_0 = new GClass14();

	private GClass12 gclass12_0 = new GClass12();

	private GClass5 gclass5_0;

	private Class5 class5_0 = new Class5();

	private Class5 class5_1 = new Class5();

	private System.Timers.Timer timer_0;

	private Process[] process_0;

	private Class55.Struct25 struct25_0;

	private GClass8 gclass8_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private int int_10;

	private int int_11;

	private int int_12;

	private int int_13;

	private int int_14;

	private bool bool_0;

	private bool bool_1 = true;

	private List<string> list_0;

	private List<string> list_1;

	private List<string> list_2;

	private List<string> list_3;

	private int[] int_15 = new int[360];

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private TableLayoutPanel tableLayoutPanel_1;

	private Button button_0;

	private Button button_1;

	private MenuStrip menuStrip_0;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private TabPage tabPage_1;

	private GroupBox groupBox_0;

	private TableLayoutPanel tableLayoutPanel_2;

	private GroupBox groupBox_1;

	private TableLayoutPanel tableLayoutPanel_3;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private GroupBox groupBox_2;

	private TableLayoutPanel tableLayoutPanel_4;

	private CheckBox checkBox_0;

	private CheckBox checkBox_1;

	private CheckBox checkBox_2;

	private CheckBox checkBox_3;

	private CheckBox checkBox_4;

	private CheckBox checkBox_5;

	private CheckBox checkBox_6;

	private CheckBox checkBox_7;

	private RadioButton radioButton_0;

	private RadioButton radioButton_1;

	private RadioButton radioButton_2;

	private TableLayoutPanel tableLayoutPanel_5;

	private GroupBox groupBox_3;

	private GroupBox groupBox_4;

	private TableLayoutPanel tableLayoutPanel_6;

	private TableLayoutPanel tableLayoutPanel_7;

	private Label label_6;

	private GroupBox groupBox_5;

	private TableLayoutPanel tableLayoutPanel_8;

	private ComboBox comboBox_0;

	private Label label_7;

	private GroupBox groupBox_6;

	private TableLayoutPanel tableLayoutPanel_9;

	private ComboBox comboBox_1;

	private Button button_2;

	private Label label_8;

	private TextBox textBox_0;

	private CheckBox checkBox_8;

	private CheckBox checkBox_9;

	private CheckBox checkBox_10;

	private CheckBox checkBox_11;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private TabPage tabPage_2;

	private TableLayoutPanel tableLayoutPanel_10;

	private GroupBox groupBox_7;

	private TableLayoutPanel tableLayoutPanel_11;

	private Label label_9;

	private Label label_10;

	private ComboBox comboBox_2;

	private ComboBox comboBox_3;

	private ComboBox comboBox_4;

	private ComboBox comboBox_5;

	private ComboBox comboBox_6;

	private ComboBox comboBox_7;

	private ComboBox comboBox_8;

	private ComboBox comboBox_9;

	private ComboBox comboBox_10;

	private ComboBox comboBox_11;

	private Label label_11;

	private Label label_12;

	private Label label_13;

	private Label label_14;

	private Label label_15;

	private Label label_16;

	private Label label_17;

	private Label label_18;

	private Label label_19;

	private Label label_20;

	private Label label_21;

	private Label label_22;

	private Label label_23;

	private Label label_24;

	private Label label_25;

	private Label label_26;

	private Label label_27;

	private Label label_28;

	private CheckBox checkBox_12;

	private CheckBox checkBox_13;

	private Label label_29;

	private Label label_30;

	private Label label_31;

	private Label label_32;

	private ComboBox comboBox_12;

	private ComboBox comboBox_13;

	public GForm1()
	{
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected O, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		method_5();
		((Control)tabControl_0).set_Region(new Region(new RectangleF(((Control)tabPage_0).get_Left(), ((Control)tabPage_0).get_Top(), ((Control)tabPage_0).get_Width(), ((Control)tabPage_0).get_Height())));
		Control.set_CheckForIllegalCrossThreadCalls(false);
		class5_0.WorkerSupportsCancellation = true;
		class5_0.DoWork += class5_0_DoWork;
		class5_1.WorkerSupportsCancellation = true;
		class5_1.DoWork += class5_1_DoWork;
		for (int i = 1; i <= 360; i++)
		{
			int_15[i - 1] = i * 5;
		}
		comboBox_2.set_DataSource((object)new BindingSource((object)int_15, (string)null));
		comboBox_3.set_DataSource((object)new BindingSource((object)int_15, (string)null));
		comboBox_12.set_DataSource((object)new BindingSource((object)int_15, (string)null));
		comboBox_4.set_DataSource((object)new BindingSource((object)int_15, (string)null));
		comboBox_5.set_DataSource((object)new BindingSource((object)int_15, (string)null));
		comboBox_6.set_DataSource((object)new BindingSource((object)int_15, (string)null));
		comboBox_13.set_DataSource((object)new BindingSource((object)int_15, (string)null));
		comboBox_7.set_DataSource((object)new BindingSource((object)int_15, (string)null));
		comboBox_8.set_DataSource((object)new BindingSource((object)int_15, (string)null));
		comboBox_9.set_DataSource((object)new BindingSource((object)int_15, (string)null));
		comboBox_10.set_DataSource((object)new BindingSource((object)int_15, (string)null));
		comboBox_11.set_DataSource((object)new BindingSource((object)int_15, (string)null));
		((ListControl)comboBox_1).set_SelectedIndex(Settings.Default.ROSUPPORT_HP_Percent);
		((ListControl)comboBox_0).set_SelectedIndex(Settings.Default.ROSUPPORT_Call_Freq);
		if (Settings.Default.ROSUPPORT_Lock_Target != 0)
		{
			((Control)button_2).set_BackColor(Color.Teal);
		}
	}

	[DllImport("User32.Dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage(IntPtr intptr_1, uint uint_0, int int_16, int int_17);

	private void method_0()
	{
		if (checkBox_7.get_Checked())
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			num = gclass14_0.method_9(gclass12_0.HP);
			num2 = gclass14_0.method_9(gclass12_0.MAX_HP);
			num3 = ((num2 > 0) ? (num * 100 / num2) : 100);
			if (num3 < 90 - Settings.Default.ROSUPPORT_HP_Percent * 10)
			{
				return;
			}
		}
		gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), Settings.Default.ROSUPPORT_Lock_Target.ToString());
		gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_0().ToString());
		gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
		gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
		Thread.Sleep(600);
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 786)
		{
			method_0();
		}
		((Form)this).WndProc(ref m);
	}

	private async void GForm1_Load(object sender, EventArgs e)
	{
		try
		{
			((ListControl)comboBox_2).set_SelectedIndex(Settings.Default.ROSUPPORT_Self_AB_Freq);
			((ListControl)comboBox_3).set_SelectedIndex(Settings.Default.ROSUPPORT_Self_Kyrie_Freq);
			((ListControl)comboBox_12).set_SelectedIndex(Settings.Default.ROSUPPORT_Self_Sacrament_Freq);
			((ListControl)comboBox_4).set_SelectedIndex(Settings.Default.ROSUPPORT_Target_AB_Freq);
			((ListControl)comboBox_5).set_SelectedIndex(Settings.Default.ROSUPPORT_Target_Kyrie_Freq);
			((ListControl)comboBox_6).set_SelectedIndex(Settings.Default.ROSUPPORT_Target_ImpositoManus_Freq);
			((ListControl)comboBox_13).set_SelectedIndex(Settings.Default.ROSUPPORT_Target_Sacrament_Freq);
			((ListControl)comboBox_7).set_SelectedIndex(Settings.Default.ROSUPPORT_Party_Gloria_Freq);
			((ListControl)comboBox_8).set_SelectedIndex(Settings.Default.ROSUPPORT_Party_Magnificat_Freq);
			((ListControl)comboBox_9).set_SelectedIndex(Settings.Default.ROSUPPORT_Party_AB_Freq);
			((ListControl)comboBox_10).set_SelectedIndex(Settings.Default.ROSUPPORT_Party_Kyrie_Freq);
			((ListControl)comboBox_11).set_SelectedIndex(Settings.Default.ROSUPPORT_Party_Heal_Freq);
			((Control)textBox_0).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.ROSUPPORT_Call_Heal_Hotkey + Class60.smethod_0(-2050195546));
			if (gclass1_0 != null)
			{
				int_0 = Settings.Default.Server_Index;
				gclass12_0 = await GClass6.smethod_5(int_0);
				if (gclass12_0 != null)
				{
					gclass14_0.string_0 = gclass12_0.BASE_ADDRESS;
					gclass14_0.string_1 = gclass12_0.MAX_HP;
					string[] files = Directory.GetFiles(Class60.smethod_0(-2050209934), Class60.smethod_0(-2050209980), SearchOption.TopDirectoryOnly);
					if (files == null || files.Length == 0)
					{
						File.WriteAllBytes(Class60.smethod_0(-2050209961), Class41.smethod_12());
						Thread.Sleep(1000);
						files = Directory.GetFiles(Class60.smethod_0(-2050209934), Class60.smethod_0(-2050209980), SearchOption.TopDirectoryOnly);
					}
					if (files != null && files.Length != 0)
					{
						try
						{
							GClass6.smethod_10();
							GClass13.smethod_3(Class60.smethod_0(-2050209995), Class60.smethod_0(-2050210047));
							GClass13.smethod_3(Class60.smethod_0(-2050210068), Class60.smethod_0(-2050210056));
							GClass13.smethod_3(Class60.smethod_0(-2050210107), Class60.smethod_0(-2050210095));
							GClass13.smethod_3(Class60.smethod_0(-2050210114), Class60.smethod_0(-2050210166));
							GClass13.smethod_3(Class60.smethod_0(-2050210154), Class60.smethod_0(-2050210206));
							GClass13.smethod_3(Class60.smethod_0(-2050210240), Class60.smethod_0(-2050210212));
						}
						catch
						{
						}
						try
						{
							File.Delete(Class60.smethod_0(-2050210047));
						}
						catch
						{
						}
						try
						{
							File.Delete(Class60.smethod_0(-2050210056));
						}
						catch
						{
						}
						try
						{
							File.Delete(Class60.smethod_0(-2050210095));
						}
						catch
						{
						}
						try
						{
							File.Delete(Class60.smethod_0(-2050210166));
						}
						catch
						{
						}
						try
						{
							File.Delete(Class60.smethod_0(-2050210206));
						}
						catch
						{
						}
						try
						{
							File.Delete(Class60.smethod_0(-2050210212));
						}
						catch
						{
						}
					}
					timer_0 = new System.Timers.Timer(5000.0);
					timer_0.Enabled = true;
					timer_0.Elapsed += method_1;
					timer_0.Stop();
					((Control)button_0).set_Enabled(true);
				}
				else
				{
					Form val = new Form();
					val.set_TopMost(true);
					MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050203423), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
			}
			else
			{
				Form val2 = new Form();
				val2.set_TopMost(true);
				MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050210429), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
				((Form)this).Close();
			}
			bool_1 = false;
		}
		catch
		{
			((Control)button_0).set_Enabled(false);
			((Control)button_1).set_Enabled(false);
			Form val3 = new Form();
			val3.set_TopMost(true);
			MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050203472), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Form)this).Close();
		}
	}

	private async void button_0_Click(object sender, EventArgs e)
	{
		try
		{
			if (!bool_0)
			{
				process_0 = gclass14_0.method_4(Class60.smethod_0(-2050204785));
				if (process_0 != null && process_0.Length != 0)
				{
					intptr_0 = process_0[0].MainWindowHandle;
				}
				else
				{
					intptr_0 = IntPtr.Zero;
				}
				if (intptr_0.ToInt32() <= 0)
				{
					Form val = new Form();
					val.set_TopMost(true);
					MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050197342), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				if (!gclass14_0.method_5(process_0[0].Id, 1))
				{
					Form val2 = new Form();
					val2.set_TopMost(true);
					MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050197103), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
					return;
				}
				gclass14_0.method_1(process_0[0].Id);
				if (gclass14_0.method_9(gclass12_0.MAX_HP) > 0)
				{
					gclass14_0.method_10(gclass12_0.MAX_ZOOM, Class60.smethod_0(-2050205505), 1145569280.ToString());
					((Control)label_0).set_Text(gclass14_0.method_8(gclass12_0.NAME));
					bool_0 = true;
				}
				if (Settings.Default.ROSUPPORT_Lock_Target < 100000)
				{
					Form val3 = new Form();
					val3.set_TopMost(true);
					MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050196404), Class60.smethod_0(-2050208686), (MessageBoxButtons)0, (MessageBoxIcon)16);
					tabControl_0.set_SelectedIndex(1);
					return;
				}
			}
			gclass5_0 = await GClass6.smethod_8();
			if (gclass5_0 != null)
			{
				if (class5_0.IsBusy)
				{
					class5_0.method_0();
					class5_0.Dispose();
				}
				if (checkBox_6.get_Checked())
				{
					int_3 = Settings.Default.ROSUPPORT_Self_AB_Freq + 1;
				}
				if (checkBox_5.get_Checked())
				{
					int_4 = Settings.Default.ROSUPPORT_Self_Kyrie_Freq + 1;
				}
				if (checkBox_13.get_Checked())
				{
					int_5 = Settings.Default.ROSUPPORT_Self_Sacrament_Freq + 1;
				}
				if (checkBox_0.get_Checked())
				{
					int_6 = Settings.Default.ROSUPPORT_Target_AB_Freq + 1;
				}
				if (checkBox_1.get_Checked())
				{
					int_7 = Settings.Default.ROSUPPORT_Target_Kyrie_Freq + 1;
				}
				if (checkBox_11.get_Checked())
				{
					int_8 = Settings.Default.ROSUPPORT_Target_ImpositoManus_Freq + 1;
				}
				if (checkBox_12.get_Checked())
				{
					int_9 = Settings.Default.ROSUPPORT_Target_Sacrament_Freq + 1;
				}
				if (checkBox_2.get_Checked())
				{
					int_10 = Settings.Default.ROSUPPORT_Party_Gloria_Freq + 1;
				}
				if (checkBox_3.get_Checked())
				{
					int_11 = Settings.Default.ROSUPPORT_Party_Magnificat_Freq + 1;
				}
				if (checkBox_9.get_Checked())
				{
					int_12 = Settings.Default.ROSUPPORT_Party_AB_Freq + 1;
				}
				if (checkBox_10.get_Checked())
				{
					int_13 = Settings.Default.ROSUPPORT_Party_Kyrie_Freq + 1;
				}
				if (checkBox_8.get_Checked())
				{
					int_14 = Settings.Default.ROSUPPORT_Party_Heal_Freq + 1;
				}
				list_0 = gclass12_0.method_0();
				list_1 = gclass12_0.method_1();
				list_2 = gclass12_0.method_2();
				list_3 = gclass12_0.method_3();
				int_1 = gclass14_0.method_9(gclass12_0.CHAR_ID);
				((Control)button_0).set_Enabled(false);
				((Control)button_1).set_Enabled(true);
				((Control)tableLayoutPanel_2).set_Enabled(false);
				((Control)tableLayoutPanel_4).set_Enabled(false);
				((Control)tableLayoutPanel_3).set_Enabled(false);
				((Control)tableLayoutPanel_5).set_Enabled(false);
				((Control)tableLayoutPanel_7).set_Enabled(false);
				((Control)tableLayoutPanel_6).set_Enabled(false);
				((Control)tableLayoutPanel_9).set_Enabled(false);
				((Control)tableLayoutPanel_8).set_Enabled(false);
				gclass8_0 = new GClass8((Keys)Enum.Parse(typeof(Keys), Settings.Default.ROSUPPORT_Call_Heal_Hotkey, ignoreCase: true), (Form)(object)this);
				gclass8_0.method_0();
				if (!class5_1.IsBusy)
				{
					class5_1.RunWorkerAsync();
				}
				if (!class5_0.IsBusy)
				{
					class5_0.RunWorkerAsync();
				}
				if (!radioButton_1.get_Checked())
				{
					timer_0.Start();
				}
			}
			else
			{
				gclass12_0 = null;
				Form val4 = new Form();
				val4.set_TopMost(true);
				MessageBox.Show((IWin32Window)val4, Class60.smethod_0(-2050197399), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		catch
		{
			if (class5_0.IsBusy)
			{
				class5_0.method_0();
				class5_0.Dispose();
			}
			if (class5_1.IsBusy)
			{
				class5_1.method_0();
				class5_1.Dispose();
			}
			Form val5 = new Form();
			val5.set_TopMost(true);
			MessageBox.Show((IWin32Window)val5, Class60.smethod_0(-2050195508), Class60.smethod_0(-2050195508), (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Control)button_0).set_Enabled(false);
			((Control)button_1).set_Enabled(false);
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			gclass8_0.method_1();
			timer_0.Stop();
			if (class5_0.IsBusy)
			{
				class5_0.method_0();
				class5_0.Dispose();
				((Control)button_0).set_Enabled(true);
				((Control)button_1).set_Enabled(false);
				((Control)tableLayoutPanel_2).set_Enabled(true);
				((Control)tableLayoutPanel_4).set_Enabled(true);
				((Control)tableLayoutPanel_3).set_Enabled(true);
				((Control)tableLayoutPanel_5).set_Enabled(true);
				((Control)tableLayoutPanel_7).set_Enabled(true);
				((Control)tableLayoutPanel_6).set_Enabled(true);
				((Control)tableLayoutPanel_9).set_Enabled(true);
				((Control)tableLayoutPanel_8).set_Enabled(true);
			}
			if (class5_1.IsBusy)
			{
				class5_1.method_0();
				class5_1.Dispose();
			}
		}
		catch
		{
			if (class5_0.IsBusy)
			{
				class5_0.method_0();
				class5_0.Dispose();
			}
			if (class5_1.IsBusy)
			{
				class5_1.method_0();
				class5_1.Dispose();
			}
			Form val = new Form();
			val.set_TopMost(true);
			MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050195522), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Control)button_0).set_Enabled(false);
			((Control)button_1).set_Enabled(false);
		}
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = gclass14_0.method_9(gclass12_0.LOCK_MONSTER);
			if (num > 100000)
			{
				if (!num.Equals(gclass14_0.method_9(gclass12_0.CHAR_ID)))
				{
					Settings.Default.ROSUPPORT_Lock_Target = num;
					((SettingsBase)Settings.Default).Save();
					((Control)button_2).set_BackColor(Color.Teal);
				}
				else
				{
					Form val = new Form();
					val.set_TopMost(true);
					MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050196469), Class60.smethod_0(-2050208686), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			else
			{
				Form val2 = new Form();
				val2.set_TopMost(true);
				MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050198554), Class60.smethod_0(-2050198623), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		catch
		{
			Form val3 = new Form();
			val3.set_TopMost(true);
			MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050198602), Class60.smethod_0(-2050208686), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			Settings.Default.ROSUPPORT_HP_Percent = ((ListControl)comboBox_1).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
		catch
		{
		}
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			Settings.Default.ROSUPPORT_Call_Freq = ((ListControl)comboBox_0).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
		catch
		{
		}
	}

	private void radioButton_2_CheckedChanged(object sender, EventArgs e)
	{
		checkBox_4.set_Checked(false);
		((Control)checkBox_4).set_Enabled(false);
	}

	private void radioButton_1_CheckedChanged(object sender, EventArgs e)
	{
		((Control)checkBox_4).set_Enabled(true);
	}

	private void radioButton_0_CheckedChanged(object sender, EventArgs e)
	{
		((Control)checkBox_4).set_Enabled(true);
	}

	private void GForm1_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void method_1(object sender, ElapsedEventArgs e)
	{
		if (radioButton_2.get_Checked())
		{
			if (checkBox_6.get_Checked())
			{
				int_3++;
			}
			if (checkBox_5.get_Checked())
			{
				int_4++;
			}
			if (checkBox_13.get_Checked())
			{
				int_5++;
			}
			if (checkBox_0.get_Checked())
			{
				int_6++;
			}
			if (checkBox_1.get_Checked())
			{
				int_7++;
			}
			if (checkBox_11.get_Checked())
			{
				int_8++;
			}
			if (checkBox_12.get_Checked())
			{
				int_9++;
			}
			if (checkBox_2.get_Checked())
			{
				int_10++;
			}
			if (checkBox_3.get_Checked())
			{
				int_11++;
			}
			if (checkBox_9.get_Checked())
			{
				int_12++;
			}
			if (checkBox_10.get_Checked())
			{
				int_13++;
			}
			if (checkBox_8.get_Checked())
			{
				int_14++;
			}
		}
		if (radioButton_0.get_Checked())
		{
			int_2++;
		}
	}

	private void class5_0_DoWork(object sender, DoWorkEventArgs e)
	{
		int num = 0;
		while (!class5_0.CancellationPending)
		{
			if (method_3())
			{
				if (radioButton_2.get_Checked())
				{
					if (int_3 < Settings.Default.ROSUPPORT_Self_AB_Freq + 1 && int_4 < Settings.Default.ROSUPPORT_Self_Kyrie_Freq + 1 && int_5 < Settings.Default.ROSUPPORT_Self_Sacrament_Freq + 1 && int_6 < Settings.Default.ROSUPPORT_Target_AB_Freq + 1 && int_7 < Settings.Default.ROSUPPORT_Target_Kyrie_Freq + 1 && int_8 < Settings.Default.ROSUPPORT_Target_ImpositoManus_Freq + 1 && int_9 < Settings.Default.ROSUPPORT_Target_Sacrament_Freq + 1 && int_10 < Settings.Default.ROSUPPORT_Party_Gloria_Freq + 1 && int_11 < Settings.Default.ROSUPPORT_Party_Magnificat_Freq + 1 && int_12 < Settings.Default.ROSUPPORT_Party_AB_Freq + 1 && int_13 < Settings.Default.ROSUPPORT_Party_Kyrie_Freq + 1 && int_14 < Settings.Default.ROSUPPORT_Party_Heal_Freq + 1)
					{
						if (gclass14_0.method_9(gclass12_0.FOLLOW) != Settings.Default.ROSUPPORT_Lock_Target)
						{
							gclass14_0.method_10(gclass12_0.FOLLOW, Class60.smethod_0(-2050205505), Settings.Default.ROSUPPORT_Lock_Target.ToString());
						}
					}
					else
					{
						gclass14_0.method_10(gclass12_0.FOLLOW, Class60.smethod_0(-2050205505), 0.ToString());
						method_4();
					}
				}
				else if (radioButton_1.get_Checked())
				{
					for (num = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN); num == 1; num = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN))
					{
						method_2(Class60.smethod_0(-2050210613));
						Thread.Sleep(1000);
					}
					method_4();
					Thread.Sleep(5000);
				}
				else if (radioButton_0.get_Checked())
				{
					for (num = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN); num == 1; num = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN))
					{
						method_2(Class60.smethod_0(-2050210613));
						Thread.Sleep(1000);
					}
					method_4();
					int_2 = 0;
					Thread.Sleep(5000);
				}
			}
			else if (radioButton_1.get_Checked() && checkBox_4.get_Checked())
			{
				for (num = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN); num == 0; num = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN))
				{
					method_2(Class60.smethod_0(-2050210613));
					Thread.Sleep(1000);
				}
			}
			else if (radioButton_0.get_Checked())
			{
				if (int_2 >= Settings.Default.ROSUPPORT_Call_Freq + 1)
				{
					for (num = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN); num == 1; num = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN))
					{
						method_2(Class60.smethod_0(-2050210613));
						Thread.Sleep(1000);
					}
					gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_1.ToString());
					gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), 336.ToString());
					gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205598));
					gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
					Thread.Sleep(1000);
				}
				else if (checkBox_4.get_Checked())
				{
					for (num = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN); num == 0; num = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN))
					{
						method_2(Class60.smethod_0(-2050210613));
						Thread.Sleep(1000);
					}
				}
			}
			else if (radioButton_2.get_Checked() && gclass14_0.method_9(gclass12_0.FOLLOW) != Settings.Default.ROSUPPORT_Lock_Target)
			{
				gclass14_0.method_10(gclass12_0.FOLLOW, Class60.smethod_0(-2050205505), Settings.Default.ROSUPPORT_Lock_Target.ToString());
			}
			Thread.Sleep(800);
		}
		if (class5_0.CancellationPending)
		{
			e.Cancel = true;
		}
	}

	private void class5_1_DoWork(object sender, DoWorkEventArgs e)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		while (!class5_1.CancellationPending)
		{
			num6 = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN);
			num = gclass14_0.method_9(gclass12_0.HP);
			num2 = gclass14_0.method_9(gclass12_0.MAX_HP);
			num5 = gclass14_0.method_9(gclass12_0.MAX_SP);
			num4 = gclass14_0.method_9(gclass12_0.SP);
			num3 = ((num2 > 0) ? (num * 100 / num2) : 100);
			if (num5 > 0)
			{
			}
			if (checkBox_7.get_Checked() && num6 == 0 && num3 < 90 - Settings.Default.ROSUPPORT_HP_Percent * 10)
			{
				if (class5_0.IsBusy)
				{
					class5_0.method_0();
					class5_0.Dispose();
					Thread.Sleep(400);
				}
				if (!class5_0.IsBusy)
				{
					gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_1.ToString());
					gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_0().ToString());
					gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
					gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
					Thread.Sleep(600);
					if (!class5_0.IsBusy)
					{
						if (!timer_0.Enabled)
						{
							timer_0.Start();
						}
						class5_0.RunWorkerAsync();
					}
				}
			}
			((Control)label_4).set_Text(num4 + Class60.smethod_0(-2050205079) + num5);
			((Control)label_2).set_Text(num + Class60.smethod_0(-2050205079) + num2);
			Thread.Sleep(100);
		}
		if (class5_1.CancellationPending)
		{
			e.Cancel = true;
		}
	}

	private void textBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)textBox_0).set_Text(string.Concat(Class60.smethod_0(-2050195538), e.get_KeyCode(), Class60.smethod_0(-2050195546)));
			Settings @default = Settings.Default;
			Keys keyCode = e.get_KeyCode();
			@default.ROSUPPORT_Call_Heal_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
			((SettingsBase)Settings.Default).Save();
			e.set_SuppressKeyPress(true);
		}
		catch
		{
		}
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		tabControl_0.set_SelectedIndex(0);
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		tabControl_0.set_SelectedIndex(1);
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		tabControl_0.set_SelectedIndex(2);
	}

	private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			Settings.Default.ROSUPPORT_Self_AB_Freq = ((ListControl)comboBox_2).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
	}

	private void comboBox_3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			Settings.Default.ROSUPPORT_Self_Kyrie_Freq = ((ListControl)comboBox_3).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
	}

	private void comboBox_12_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			Settings.Default.ROSUPPORT_Self_Sacrament_Freq = ((ListControl)comboBox_12).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
	}

	private void comboBox_4_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			Settings.Default.ROSUPPORT_Target_AB_Freq = ((ListControl)comboBox_4).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
	}

	private void comboBox_5_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			Settings.Default.ROSUPPORT_Target_Kyrie_Freq = ((ListControl)comboBox_5).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
	}

	private void comboBox_6_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			Settings.Default.ROSUPPORT_Target_ImpositoManus_Freq = ((ListControl)comboBox_6).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
	}

	private void comboBox_13_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			Settings.Default.ROSUPPORT_Target_Sacrament_Freq = ((ListControl)comboBox_13).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
	}

	private void comboBox_7_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			Settings.Default.ROSUPPORT_Party_Gloria_Freq = ((ListControl)comboBox_7).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
	}

	private void comboBox_8_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			Settings.Default.ROSUPPORT_Party_Magnificat_Freq = ((ListControl)comboBox_8).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
	}

	private void comboBox_9_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			Settings.Default.ROSUPPORT_Party_AB_Freq = ((ListControl)comboBox_9).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
	}

	private void comboBox_10_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			Settings.Default.ROSUPPORT_Party_Kyrie_Freq = ((ListControl)comboBox_10).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
	}

	private void comboBox_11_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			Settings.Default.ROSUPPORT_Party_Heal_Freq = ((ListControl)comboBox_11).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
	}

	private void method_2(string string_0)
	{
		PostMessage(intptr_0, 256u, dictionary_0[string_0], 0);
		Thread.Sleep(100);
		PostMessage(intptr_0, 257u, dictionary_0[string_0], 0);
		Thread.Sleep(200);
	}

	private bool method_3()
	{
		bool result = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		foreach (string item in list_1)
		{
			_ = item;
			num2 = gclass14_0.method_9(list_0[num].ToString());
			num3 = gclass14_0.method_9(list_2[num].ToString());
			num4 = gclass14_0.method_9(list_3[num].ToString());
			if (num2 != Settings.Default.ROSUPPORT_Lock_Target)
			{
				num++;
				continue;
			}
			int num5 = Math.Abs(num3 - gclass14_0.method_9(gclass12_0.CHAR_X));
			if (num5 > 8)
			{
				result = false;
			}
			int num6 = Math.Abs(num4 - gclass14_0.method_9(gclass12_0.CHAR_Y));
			if (num6 > 8)
			{
				return false;
			}
			return true;
		}
		return result;
	}

	private void method_4()
	{
		if (gclass14_0.method_9(gclass12_0.ATTACK) != 0 || gclass14_0.method_9(gclass12_0.CHECK_ATTACK) != 0)
		{
			return;
		}
		if (checkBox_3.get_Checked() && (radioButton_1.get_Checked() || radioButton_0.get_Checked() || int_11 >= Settings.Default.ROSUPPORT_Party_Magnificat_Freq + 1))
		{
			int_11 = 0;
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_1.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_8().ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205590));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(4000);
			int_11 = 0;
		}
		if (checkBox_6.get_Checked() && (radioButton_1.get_Checked() || radioButton_0.get_Checked() || int_3 >= Settings.Default.ROSUPPORT_Self_AB_Freq + 1))
		{
			if (checkBox_3.get_Checked())
			{
				Thread.Sleep(1000);
			}
			int_3 = 0;
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_1.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_2().ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(1000);
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_1().ToString());
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(2000);
			int_3 = 0;
		}
		if (checkBox_5.get_Checked() && (radioButton_1.get_Checked() || radioButton_0.get_Checked() || int_4 >= Settings.Default.ROSUPPORT_Self_Kyrie_Freq + 1))
		{
			int_4 = 0;
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_1.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_7().ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(3000);
			int_4 = 0;
		}
		if (checkBox_13.get_Checked() && (radioButton_1.get_Checked() || radioButton_0.get_Checked() || int_5 >= Settings.Default.ROSUPPORT_Self_Sacrament_Freq + 1))
		{
			int_5 = 0;
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_1.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_41().ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205590));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(2000);
			int_5 = 0;
		}
		if (checkBox_0.get_Checked() && (radioButton_1.get_Checked() || radioButton_0.get_Checked() || int_6 >= Settings.Default.ROSUPPORT_Target_AB_Freq + 1))
		{
			if (checkBox_3.get_Checked() || checkBox_5.get_Checked())
			{
				Thread.Sleep(1000);
			}
			int_6 = 0;
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), Settings.Default.ROSUPPORT_Lock_Target.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_2().ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(1000);
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_1().ToString());
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(2000);
			int_6 = 0;
		}
		if (checkBox_1.get_Checked() && (radioButton_1.get_Checked() || radioButton_0.get_Checked() || int_7 >= Settings.Default.ROSUPPORT_Target_Kyrie_Freq + 1))
		{
			int_7 = 0;
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), Settings.Default.ROSUPPORT_Lock_Target.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_7().ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(3000);
			int_7 = 0;
		}
		if (checkBox_11.get_Checked() && (radioButton_1.get_Checked() || radioButton_0.get_Checked() || int_8 >= Settings.Default.ROSUPPORT_Target_ImpositoManus_Freq + 1))
		{
			int_8 = 0;
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), Settings.Default.ROSUPPORT_Lock_Target.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_6().ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205590));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(3000);
			int_8 = 0;
		}
		if (checkBox_12.get_Checked() && (radioButton_1.get_Checked() || radioButton_0.get_Checked() || int_9 >= Settings.Default.ROSUPPORT_Target_Sacrament_Freq + 1))
		{
			if (checkBox_11.get_Checked())
			{
				Thread.Sleep(1000);
			}
			int_9 = 0;
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), Settings.Default.ROSUPPORT_Lock_Target.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_41().ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205590));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(2000);
			int_9 = 0;
		}
		if (checkBox_2.get_Checked() && (radioButton_1.get_Checked() || radioButton_0.get_Checked() || int_10 >= Settings.Default.ROSUPPORT_Party_Gloria_Freq + 1))
		{
			if (checkBox_3.get_Checked() || checkBox_5.get_Checked() || checkBox_1.get_Checked())
			{
				Thread.Sleep(1000);
			}
			int_10 = 0;
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_1.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_9().ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(3000);
			int_10 = 0;
		}
		if (checkBox_8.get_Checked() && (radioButton_1.get_Checked() || radioButton_0.get_Checked() || int_14 >= Settings.Default.ROSUPPORT_Party_Heal_Freq + 1))
		{
			int_14 = 0;
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_1.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_35().ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(3000);
			int_14 = 0;
		}
		if (checkBox_9.get_Checked() && (radioButton_1.get_Checked() || radioButton_0.get_Checked() || int_12 >= Settings.Default.ROSUPPORT_Party_AB_Freq + 1))
		{
			int_12 = 0;
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_1.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_33().ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(1000);
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_34().ToString());
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(2000);
			int_12 = 0;
		}
		if (checkBox_10.get_Checked() && (radioButton_1.get_Checked() || radioButton_0.get_Checked() || int_13 >= Settings.Default.ROSUPPORT_Party_Kyrie_Freq + 1))
		{
			int_13 = 0;
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_1.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_36().ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(3000);
			int_13 = 0;
		}
		if (radioButton_0.get_Checked())
		{
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_1.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), 334.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205598));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(3000);
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_1.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), 335.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205598));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(1000);
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

	private void method_5()
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
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected O, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected O, but got Unknown
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected O, but got Unknown
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected O, but got Unknown
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected O, but got Unknown
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected O, but got Unknown
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected O, but got Unknown
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Expected O, but got Unknown
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Expected O, but got Unknown
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Expected O, but got Unknown
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Expected O, but got Unknown
		//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Expected O, but got Unknown
		//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Expected O, but got Unknown
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Expected O, but got Unknown
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a41: Expected O, but got Unknown
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected O, but got Unknown
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Expected O, but got Unknown
		//IL_0b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0c: Expected O, but got Unknown
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Expected O, but got Unknown
		//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d74: Expected O, but got Unknown
		//IL_0e16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e20: Expected O, but got Unknown
		//IL_0e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edc: Expected O, but got Unknown
		//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa3: Expected O, but got Unknown
		//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1059: Unknown result type (might be due to invalid IL or missing references)
		//IL_1063: Expected O, but got Unknown
		//IL_1084: Unknown result type (might be due to invalid IL or missing references)
		//IL_111a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1124: Expected O, but got Unknown
		//IL_11c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d0: Expected O, but got Unknown
		//IL_1274: Unknown result type (might be due to invalid IL or missing references)
		//IL_127e: Expected O, but got Unknown
		//IL_1298: Unknown result type (might be due to invalid IL or missing references)
		//IL_1330: Unknown result type (might be due to invalid IL or missing references)
		//IL_133a: Expected O, but got Unknown
		//IL_1364: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1403: Expected O, but got Unknown
		//IL_14aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b4: Expected O, but got Unknown
		//IL_154d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1557: Expected O, but got Unknown
		//IL_1569: Unknown result type (might be due to invalid IL or missing references)
		//IL_1573: Expected O, but got Unknown
		//IL_1585: Unknown result type (might be due to invalid IL or missing references)
		//IL_158f: Expected O, but got Unknown
		//IL_15fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1606: Expected O, but got Unknown
		//IL_1620: Unknown result type (might be due to invalid IL or missing references)
		//IL_1649: Unknown result type (might be due to invalid IL or missing references)
		//IL_1670: Unknown result type (might be due to invalid IL or missing references)
		//IL_167a: Expected O, but got Unknown
		//IL_168c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1696: Expected O, but got Unknown
		//IL_16a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b2: Expected O, but got Unknown
		//IL_16c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ce: Expected O, but got Unknown
		//IL_16e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ea: Expected O, but got Unknown
		//IL_174c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1756: Expected O, but got Unknown
		//IL_1817: Unknown result type (might be due to invalid IL or missing references)
		//IL_1821: Expected O, but got Unknown
		//IL_18eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f5: Expected O, but got Unknown
		//IL_19ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c4: Expected O, but got Unknown
		//IL_1a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a66: Expected O, but got Unknown
		//IL_1a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a82: Expected O, but got Unknown
		//IL_1a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9e: Expected O, but got Unknown
		//IL_1ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aba: Expected O, but got Unknown
		//IL_1acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad6: Expected O, but got Unknown
		//IL_1ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af2: Expected O, but got Unknown
		//IL_1ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb1: Expected O, but got Unknown
		//IL_1bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c25: Expected O, but got Unknown
		//IL_1c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c83: Expected O, but got Unknown
		//IL_1c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d38: Expected O, but got Unknown
		//IL_1d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ded: Expected O, but got Unknown
		//IL_1e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea5: Expected O, but got Unknown
		//IL_1ec2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f53: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5d: Expected O, but got Unknown
		//IL_1f7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_200b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2015: Expected O, but got Unknown
		//IL_2032: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ba: Expected O, but got Unknown
		//IL_20cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d6: Expected O, but got Unknown
		//IL_2130: Unknown result type (might be due to invalid IL or missing references)
		//IL_216c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2176: Expected O, but got Unknown
		//IL_2188: Unknown result type (might be due to invalid IL or missing references)
		//IL_2192: Expected O, but got Unknown
		//IL_2212: Unknown result type (might be due to invalid IL or missing references)
		//IL_221c: Expected O, but got Unknown
		//IL_230a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2314: Expected O, but got Unknown
		//IL_23d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23da: Expected O, but got Unknown
		//IL_26d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2790: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_27fc: Expected O, but got Unknown
		//IL_28ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b7: Expected O, but got Unknown
		//IL_28c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d3: Expected O, but got Unknown
		//IL_28e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ef: Expected O, but got Unknown
		//IL_2901: Unknown result type (might be due to invalid IL or missing references)
		//IL_290b: Expected O, but got Unknown
		//IL_291d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2927: Expected O, but got Unknown
		//IL_2986: Unknown result type (might be due to invalid IL or missing references)
		//IL_2990: Expected O, but got Unknown
		//IL_2a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a36: Expected O, but got Unknown
		//IL_2a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a52: Expected O, but got Unknown
		//IL_2ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ade: Expected O, but got Unknown
		//IL_2b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b4a: Expected O, but got Unknown
		//IL_2c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c9f: Expected O, but got Unknown
		//IL_2d44: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d4e: Expected O, but got Unknown
		//IL_2dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df4: Expected O, but got Unknown
		//IL_2e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e10: Expected O, but got Unknown
		//IL_2e92: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e9c: Expected O, but got Unknown
		//IL_2eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb8: Expected O, but got Unknown
		//IL_2f0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f14: Expected O, but got Unknown
		//IL_2fa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2faf: Expected O, but got Unknown
		//IL_3017: Unknown result type (might be due to invalid IL or missing references)
		//IL_3021: Expected O, but got Unknown
		//IL_3059: Unknown result type (might be due to invalid IL or missing references)
		//IL_3063: Expected O, but got Unknown
		//IL_30fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3106: Expected O, but got Unknown
		//IL_3118: Unknown result type (might be due to invalid IL or missing references)
		//IL_3122: Expected O, but got Unknown
		//IL_31a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ae: Expected O, but got Unknown
		//IL_3210: Unknown result type (might be due to invalid IL or missing references)
		//IL_321a: Expected O, but got Unknown
		//IL_32a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_332f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3339: Expected O, but got Unknown
		//IL_33de: Unknown result type (might be due to invalid IL or missing references)
		//IL_33e8: Expected O, but got Unknown
		//IL_3480: Unknown result type (might be due to invalid IL or missing references)
		//IL_348a: Expected O, but got Unknown
		//IL_349c: Unknown result type (might be due to invalid IL or missing references)
		//IL_34a6: Expected O, but got Unknown
		//IL_3510: Unknown result type (might be due to invalid IL or missing references)
		//IL_351a: Expected O, but got Unknown
		//IL_358e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3598: Expected O, but got Unknown
		//IL_366e: Unknown result type (might be due to invalid IL or missing references)
		//IL_36d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_36da: Expected O, but got Unknown
		//IL_36ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_36f6: Expected O, but got Unknown
		//IL_375f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3769: Expected O, but got Unknown
		//IL_377b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3785: Expected O, but got Unknown
		//IL_37e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_37ee: Expected O, but got Unknown
		//IL_3889: Unknown result type (might be due to invalid IL or missing references)
		//IL_3893: Expected O, but got Unknown
		//IL_38a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_38af: Expected O, but got Unknown
		//IL_38c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_38cb: Expected O, but got Unknown
		//IL_3c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c91: Expected O, but got Unknown
		//IL_3ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cad: Expected O, but got Unknown
		//IL_3cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cc9: Expected O, but got Unknown
		//IL_3cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ce5: Expected O, but got Unknown
		//IL_3cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d01: Expected O, but got Unknown
		//IL_3d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d1d: Expected O, but got Unknown
		//IL_3d2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d39: Expected O, but got Unknown
		//IL_3d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d55: Expected O, but got Unknown
		//IL_3d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d71: Expected O, but got Unknown
		//IL_3d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d8d: Expected O, but got Unknown
		//IL_3d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3da9: Expected O, but got Unknown
		//IL_3dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dc5: Expected O, but got Unknown
		//IL_3e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e24: Expected O, but got Unknown
		//IL_3ec4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ece: Expected O, but got Unknown
		//IL_3f6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f75: Expected O, but got Unknown
		//IL_4015: Unknown result type (might be due to invalid IL or missing references)
		//IL_401f: Expected O, but got Unknown
		//IL_40bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_40c6: Expected O, but got Unknown
		//IL_4166: Unknown result type (might be due to invalid IL or missing references)
		//IL_4170: Expected O, but got Unknown
		//IL_420d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4217: Expected O, but got Unknown
		//IL_42b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_42c1: Expected O, but got Unknown
		//IL_435e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4368: Expected O, but got Unknown
		//IL_4408: Unknown result type (might be due to invalid IL or missing references)
		//IL_4412: Expected O, but got Unknown
		//IL_44af: Unknown result type (might be due to invalid IL or missing references)
		//IL_44b9: Expected O, but got Unknown
		//IL_4559: Unknown result type (might be due to invalid IL or missing references)
		//IL_4563: Expected O, but got Unknown
		//IL_4603: Unknown result type (might be due to invalid IL or missing references)
		//IL_460d: Expected O, but got Unknown
		//IL_46ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_46b7: Expected O, but got Unknown
		//IL_4754: Unknown result type (might be due to invalid IL or missing references)
		//IL_475e: Expected O, but got Unknown
		//IL_47fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_4805: Expected O, but got Unknown
		//IL_489f: Unknown result type (might be due to invalid IL or missing references)
		//IL_48a9: Expected O, but got Unknown
		//IL_4946: Unknown result type (might be due to invalid IL or missing references)
		//IL_4950: Expected O, but got Unknown
		//IL_49ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_49f4: Expected O, but got Unknown
		//IL_4a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a99: Expected O, but got Unknown
		//IL_4b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b4d: Expected O, but got Unknown
		//IL_4bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c05: Expected O, but got Unknown
		//IL_4cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cbe: Expected O, but got Unknown
		//IL_4d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d77: Expected O, but got Unknown
		//IL_4e29: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e33: Expected O, but got Unknown
		//IL_4ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4eef: Expected O, but got Unknown
		//IL_4fa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fab: Expected O, but got Unknown
		//IL_505d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5067: Expected O, but got Unknown
		//IL_511a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5124: Expected O, but got Unknown
		//IL_51d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_51e1: Expected O, but got Unknown
		//IL_5282: Unknown result type (might be due to invalid IL or missing references)
		//IL_528c: Expected O, but got Unknown
		//IL_5329: Unknown result type (might be due to invalid IL or missing references)
		//IL_5333: Expected O, but got Unknown
		//IL_53d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_53dd: Expected O, but got Unknown
		//IL_547a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5484: Expected O, but got Unknown
		//IL_5534: Unknown result type (might be due to invalid IL or missing references)
		//IL_553e: Expected O, but got Unknown
		//IL_55ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_55f6: Expected O, but got Unknown
		//IL_56d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_56e2: Expected O, but got Unknown
		//IL_5732: Unknown result type (might be due to invalid IL or missing references)
		//IL_573c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm1));
		tableLayoutPanel_0 = new TableLayoutPanel();
		groupBox_2 = new GroupBox();
		tableLayoutPanel_4 = new TableLayoutPanel();
		checkBox_8 = new CheckBox();
		checkBox_2 = new CheckBox();
		checkBox_3 = new CheckBox();
		checkBox_9 = new CheckBox();
		checkBox_10 = new CheckBox();
		checkBox_5 = new CheckBox();
		checkBox_6 = new CheckBox();
		checkBox_4 = new CheckBox();
		checkBox_7 = new CheckBox();
		checkBox_12 = new CheckBox();
		checkBox_11 = new CheckBox();
		checkBox_1 = new CheckBox();
		checkBox_0 = new CheckBox();
		checkBox_13 = new CheckBox();
		groupBox_0 = new GroupBox();
		tableLayoutPanel_2 = new TableLayoutPanel();
		radioButton_0 = new RadioButton();
		radioButton_1 = new RadioButton();
		radioButton_2 = new RadioButton();
		groupBox_1 = new GroupBox();
		tableLayoutPanel_3 = new TableLayoutPanel();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		label_5 = new Label();
		tableLayoutPanel_1 = new TableLayoutPanel();
		button_0 = new Button();
		button_1 = new Button();
		menuStrip_0 = new MenuStrip();
		toolStripMenuItem_0 = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		toolStripMenuItem_2 = new ToolStripMenuItem();
		toolStripMenuItem_3 = new ToolStripMenuItem();
		tabControl_0 = new TabControl();
		tabPage_0 = new TabPage();
		tabPage_1 = new TabPage();
		tableLayoutPanel_5 = new TableLayoutPanel();
		groupBox_5 = new GroupBox();
		tableLayoutPanel_8 = new TableLayoutPanel();
		comboBox_0 = new ComboBox();
		label_7 = new Label();
		groupBox_6 = new GroupBox();
		tableLayoutPanel_9 = new TableLayoutPanel();
		label_8 = new Label();
		textBox_0 = new TextBox();
		groupBox_4 = new GroupBox();
		tableLayoutPanel_6 = new TableLayoutPanel();
		comboBox_1 = new ComboBox();
		label_6 = new Label();
		groupBox_3 = new GroupBox();
		tableLayoutPanel_7 = new TableLayoutPanel();
		button_2 = new Button();
		tabPage_2 = new TabPage();
		tableLayoutPanel_10 = new TableLayoutPanel();
		groupBox_7 = new GroupBox();
		tableLayoutPanel_11 = new TableLayoutPanel();
		label_11 = new Label();
		label_12 = new Label();
		label_13 = new Label();
		label_14 = new Label();
		label_15 = new Label();
		label_16 = new Label();
		label_17 = new Label();
		label_18 = new Label();
		label_19 = new Label();
		label_20 = new Label();
		label_21 = new Label();
		label_22 = new Label();
		label_23 = new Label();
		label_24 = new Label();
		label_25 = new Label();
		label_26 = new Label();
		label_27 = new Label();
		label_28 = new Label();
		label_9 = new Label();
		label_10 = new Label();
		comboBox_2 = new ComboBox();
		comboBox_3 = new ComboBox();
		comboBox_4 = new ComboBox();
		comboBox_5 = new ComboBox();
		comboBox_6 = new ComboBox();
		comboBox_7 = new ComboBox();
		comboBox_8 = new ComboBox();
		comboBox_9 = new ComboBox();
		comboBox_10 = new ComboBox();
		comboBox_11 = new ComboBox();
		label_29 = new Label();
		label_30 = new Label();
		label_31 = new Label();
		label_32 = new Label();
		comboBox_12 = new ComboBox();
		comboBox_13 = new ComboBox();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((Control)groupBox_2).SuspendLayout();
		((Control)tableLayoutPanel_4).SuspendLayout();
		((Control)groupBox_0).SuspendLayout();
		((Control)tableLayoutPanel_2).SuspendLayout();
		((Control)groupBox_1).SuspendLayout();
		((Control)tableLayoutPanel_3).SuspendLayout();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)menuStrip_0).SuspendLayout();
		((Control)tabControl_0).SuspendLayout();
		((Control)tabPage_0).SuspendLayout();
		((Control)tabPage_1).SuspendLayout();
		((Control)tableLayoutPanel_5).SuspendLayout();
		((Control)groupBox_5).SuspendLayout();
		((Control)tableLayoutPanel_8).SuspendLayout();
		((Control)groupBox_6).SuspendLayout();
		((Control)tableLayoutPanel_9).SuspendLayout();
		((Control)groupBox_4).SuspendLayout();
		((Control)tableLayoutPanel_6).SuspendLayout();
		((Control)groupBox_3).SuspendLayout();
		((Control)tableLayoutPanel_7).SuspendLayout();
		((Control)tabPage_2).SuspendLayout();
		((Control)tableLayoutPanel_10).SuspendLayout();
		((Control)groupBox_7).SuspendLayout();
		((Control)tableLayoutPanel_11).SuspendLayout();
		((Control)this).SuspendLayout();
		tableLayoutPanel_0.set_ColumnCount(1);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_2, 0, 2);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_0, 0, 1);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_1, 0, 0);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_1, 0, 3);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Location(new Point(3, 3));
		((Control)tableLayoutPanel_0).set_Name(Class60.smethod_0(-2050208027));
		tableLayoutPanel_0.set_RowCount(4);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 16f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 16f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 58f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		((Control)tableLayoutPanel_0).set_Size(new Size(390, 422));
		((Control)tableLayoutPanel_0).set_TabIndex(0);
		((Control)groupBox_2).get_Controls().Add((Control)(object)tableLayoutPanel_4);
		((Control)groupBox_2).set_Dock((DockStyle)5);
		((Control)groupBox_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)groupBox_2).set_ForeColor(SystemColors.Control);
		((Control)groupBox_2).set_Location(new Point(3, 137));
		((Control)groupBox_2).set_Name(Class60.smethod_0(-2050198717));
		((Control)groupBox_2).set_Size(new Size(384, 238));
		((Control)groupBox_2).set_TabIndex(6);
		groupBox_2.set_TabStop(false);
		((Control)groupBox_2).set_Text(Class60.smethod_0(-2050198701));
		tableLayoutPanel_4.set_ColumnCount(2);
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 55f));
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 45f));
		tableLayoutPanel_4.get_Controls().Add((Control)(object)checkBox_8, 1, 4);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)checkBox_2, 1, 0);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)checkBox_3, 1, 1);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)checkBox_9, 1, 2);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)checkBox_10, 1, 3);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)checkBox_5, 0, 1);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)checkBox_6, 0, 0);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)checkBox_4, 1, 6);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)checkBox_7, 1, 5);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)checkBox_12, 0, 6);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)checkBox_11, 0, 5);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)checkBox_1, 0, 4);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)checkBox_0, 0, 3);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)checkBox_13, 0, 2);
		((Control)tableLayoutPanel_4).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_4).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)tableLayoutPanel_4).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_4).set_Margin(new Padding(4));
		((Control)tableLayoutPanel_4).set_Name(Class60.smethod_0(-2050211088));
		tableLayoutPanel_4.set_RowCount(7);
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 14.28571f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 14.28571f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 14.28571f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 14.28571f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 14.28571f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 14.28571f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 14.28571f));
		((Control)tableLayoutPanel_4).set_Size(new Size(378, 213));
		((Control)tableLayoutPanel_4).set_TabIndex(0);
		((Control)checkBox_8).set_AutoSize(true);
		((Control)checkBox_8).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_8).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_8).set_Location(new Point(210, 123));
		((Control)checkBox_8).set_Name(Class60.smethod_0(-2050198754));
		((Control)checkBox_8).set_Size(new Size(108, 20));
		((Control)checkBox_8).set_TabIndex(25);
		((Control)checkBox_8).set_Text(Class60.smethod_0(-2050198814));
		((ButtonBase)checkBox_8).set_UseVisualStyleBackColor(true);
		((Control)checkBox_2).set_AutoSize(true);
		((Control)checkBox_2).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_2).set_Location(new Point(211, 4));
		((Control)checkBox_2).set_Margin(new Padding(4));
		((Control)checkBox_2).set_Name(Class60.smethod_0(-2050198823));
		((Control)checkBox_2).set_Size(new Size(115, 20));
		((Control)checkBox_2).set_TabIndex(19);
		((Control)checkBox_2).set_Text(Class60.smethod_0(-2050198871));
		((ButtonBase)checkBox_2).set_UseVisualStyleBackColor(true);
		((Control)checkBox_3).set_AutoSize(true);
		((Control)checkBox_3).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_3).set_Location(new Point(211, 34));
		((Control)checkBox_3).set_Margin(new Padding(4));
		((Control)checkBox_3).set_Name(Class60.smethod_0(-2050198908));
		((Control)checkBox_3).set_Size(new Size(143, 20));
		((Control)checkBox_3).set_TabIndex(20);
		((Control)checkBox_3).set_Text(Class60.smethod_0(-2050198936));
		((ButtonBase)checkBox_3).set_UseVisualStyleBackColor(true);
		((Control)checkBox_9).set_AutoSize(true);
		((Control)checkBox_9).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_9).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_9).set_Location(new Point(210, 63));
		((Control)checkBox_9).set_Name(Class60.smethod_0(-2050198949));
		((Control)checkBox_9).set_Size(new Size(99, 20));
		((Control)checkBox_9).set_TabIndex(23);
		((Control)checkBox_9).set_Text(Class60.smethod_0(-2050198995));
		((ButtonBase)checkBox_9).set_UseVisualStyleBackColor(true);
		((Control)checkBox_10).set_AutoSize(true);
		((Control)checkBox_10).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_10).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_10).set_Location(new Point(210, 93));
		((Control)checkBox_10).set_Name(Class60.smethod_0(-2050199040));
		((Control)checkBox_10).set_Size(new Size(112, 20));
		((Control)checkBox_10).set_TabIndex(24);
		((Control)checkBox_10).set_Text(Class60.smethod_0(-2050199019));
		((ButtonBase)checkBox_10).set_UseVisualStyleBackColor(true);
		((Control)checkBox_5).set_AutoSize(true);
		((Control)checkBox_5).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_5).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_5).set_Location(new Point(4, 34));
		((Control)checkBox_5).set_Margin(new Padding(4));
		((Control)checkBox_5).set_Name(Class60.smethod_0(-2050199090));
		((Control)checkBox_5).set_Size(new Size(144, 20));
		((Control)checkBox_5).set_TabIndex(11);
		((Control)checkBox_5).set_Text(Class60.smethod_0(-2050199086));
		((ButtonBase)checkBox_5).set_UseVisualStyleBackColor(true);
		((Control)checkBox_6).set_AutoSize(true);
		((Control)checkBox_6).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_6).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_6).set_Location(new Point(4, 4));
		((Control)checkBox_6).set_Margin(new Padding(4));
		((Control)checkBox_6).set_Name(Class60.smethod_0(-2050199161));
		((Control)checkBox_6).set_Size(new Size(131, 20));
		((Control)checkBox_6).set_TabIndex(10);
		((Control)checkBox_6).set_Text(Class60.smethod_0(-2050199192));
		((ButtonBase)checkBox_6).set_UseVisualStyleBackColor(true);
		((Control)checkBox_4).set_AutoSize(true);
		((Control)checkBox_4).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_4).set_Enabled(false);
		((Control)checkBox_4).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_4).set_Location(new Point(211, 184));
		((Control)checkBox_4).set_Margin(new Padding(4));
		((Control)checkBox_4).set_Name(Class60.smethod_0(-2050199225));
		((Control)checkBox_4).set_Size(new Size(89, 20));
		((Control)checkBox_4).set_TabIndex(22);
		((Control)checkBox_4).set_Text(Class60.smethod_0(-2050199256));
		((ButtonBase)checkBox_4).set_UseVisualStyleBackColor(true);
		((Control)checkBox_7).set_AutoSize(true);
		((Control)checkBox_7).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_7).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_7).set_Location(new Point(211, 154));
		((Control)checkBox_7).set_Margin(new Padding(4));
		((Control)checkBox_7).set_Name(Class60.smethod_0(-2050199287));
		((Control)checkBox_7).set_Size(new Size(147, 20));
		((Control)checkBox_7).set_TabIndex(9);
		((Control)checkBox_7).set_Text(Class60.smethod_0(-2050199268));
		((ButtonBase)checkBox_7).set_UseVisualStyleBackColor(true);
		((Control)checkBox_12).set_AutoSize(true);
		((Control)checkBox_12).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_12).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_12).set_Location(new Point(3, 183));
		((Control)checkBox_12).set_Name(Class60.smethod_0(-2050199357));
		((Control)checkBox_12).set_Size(new Size(192, 20));
		((Control)checkBox_12).set_TabIndex(27);
		((Control)checkBox_12).set_Text(Class60.smethod_0(-2050199379));
		((ButtonBase)checkBox_12).set_UseVisualStyleBackColor(true);
		((Control)checkBox_11).set_AutoSize(true);
		((Control)checkBox_11).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_11).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_11).set_Location(new Point(3, 153));
		((Control)checkBox_11).set_Name(Class60.smethod_0(-2050199442));
		((Control)checkBox_11).set_Size(new Size(179, 20));
		((Control)checkBox_11).set_TabIndex(26);
		((Control)checkBox_11).set_Text(Class60.smethod_0(-2050199476));
		((ButtonBase)checkBox_11).set_UseVisualStyleBackColor(true);
		((Control)checkBox_1).set_AutoSize(true);
		((Control)checkBox_1).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_1).set_Location(new Point(4, 124));
		((Control)checkBox_1).set_Margin(new Padding(4));
		((Control)checkBox_1).set_Name(Class60.smethod_0(-2050199541));
		((Control)checkBox_1).set_Size(new Size(160, 20));
		((Control)checkBox_1).set_TabIndex(18);
		((Control)checkBox_1).set_Text(Class60.smethod_0(-2050199535));
		((ButtonBase)checkBox_1).set_UseVisualStyleBackColor(true);
		((Control)checkBox_0).set_AutoSize(true);
		((Control)checkBox_0).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_0).set_ForeColor(SystemColors.Control);
		((Control)checkBox_0).set_Location(new Point(4, 94));
		((Control)checkBox_0).set_Margin(new Padding(4));
		((Control)checkBox_0).set_Name(Class60.smethod_0(-2050197542));
		((Control)checkBox_0).set_Size(new Size(147, 20));
		((Control)checkBox_0).set_TabIndex(0);
		((Control)checkBox_0).set_Text(Class60.smethod_0(-2050197587));
		((ButtonBase)checkBox_0).set_UseVisualStyleBackColor(true);
		((Control)checkBox_13).set_AutoSize(true);
		((Control)checkBox_13).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_13).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_13).set_Location(new Point(3, 63));
		((Control)checkBox_13).set_Name(Class60.smethod_0(-2050197616));
		((Control)checkBox_13).set_Size(new Size(176, 20));
		((Control)checkBox_13).set_TabIndex(28);
		((Control)checkBox_13).set_Text(Class60.smethod_0(-2050197640));
		((ButtonBase)checkBox_13).set_UseVisualStyleBackColor(true);
		((Control)groupBox_0).get_Controls().Add((Control)(object)tableLayoutPanel_2);
		((Control)groupBox_0).set_Dock((DockStyle)5);
		((Control)groupBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)groupBox_0).set_ForeColor(SystemColors.Control);
		((Control)groupBox_0).set_Location(new Point(3, 70));
		((Control)groupBox_0).set_Name(Class60.smethod_0(-2050207223));
		((Control)groupBox_0).set_Size(new Size(384, 61));
		((Control)groupBox_0).set_TabIndex(5);
		groupBox_0.set_TabStop(false);
		((Control)groupBox_0).set_Text(Class60.smethod_0(-2050197723));
		tableLayoutPanel_2.set_ColumnCount(3);
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 30f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 35f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 35f));
		tableLayoutPanel_2.get_Controls().Add((Control)(object)radioButton_0, 2, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)radioButton_1, 1, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)radioButton_2, 0, 0);
		((Control)tableLayoutPanel_2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)tableLayoutPanel_2).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_2).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_2).set_Name(Class60.smethod_0(-2050208091));
		((Control)tableLayoutPanel_2).set_Padding(new Padding(0, 0, 0, 5));
		tableLayoutPanel_2.set_RowCount(1);
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)1, 31f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)1, 31f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)1, 31f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)1, 31f));
		((Control)tableLayoutPanel_2).set_Size(new Size(378, 36));
		((Control)tableLayoutPanel_2).set_TabIndex(0);
		((Control)radioButton_0).set_AutoSize(true);
		((Control)radioButton_0).set_Cursor(Cursors.get_Hand());
		((Control)radioButton_0).set_Dock((DockStyle)5);
		((Control)radioButton_0).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1));
		((Control)radioButton_0).set_Location(new Point(248, 3));
		((Control)radioButton_0).set_Name(Class60.smethod_0(-2050197782));
		((Control)radioButton_0).set_Size(new Size(127, 25));
		((Control)radioButton_0).set_TabIndex(4);
		((Control)radioButton_0).set_Text(Class60.smethod_0(-2050197761));
		((ButtonBase)radioButton_0).set_UseVisualStyleBackColor(true);
		radioButton_0.add_CheckedChanged((EventHandler)radioButton_0_CheckedChanged);
		((Control)radioButton_1).set_AutoSize(true);
		((Control)radioButton_1).set_Cursor(Cursors.get_Hand());
		((Control)radioButton_1).set_Dock((DockStyle)5);
		((Control)radioButton_1).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1));
		((Control)radioButton_1).set_Location(new Point(116, 3));
		((Control)radioButton_1).set_Name(Class60.smethod_0(-2050197806));
		((Control)radioButton_1).set_Size(new Size(126, 25));
		((Control)radioButton_1).set_TabIndex(3);
		((Control)radioButton_1).set_Text(Class60.smethod_0(-2050197831));
		((ButtonBase)radioButton_1).set_UseVisualStyleBackColor(true);
		radioButton_1.add_CheckedChanged((EventHandler)radioButton_1_CheckedChanged);
		((Control)radioButton_2).set_AutoSize(true);
		radioButton_2.set_Checked(true);
		((Control)radioButton_2).set_Cursor(Cursors.get_Hand());
		((Control)radioButton_2).set_Dock((DockStyle)5);
		((Control)radioButton_2).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1));
		((Control)radioButton_2).set_Location(new Point(3, 3));
		((Control)radioButton_2).set_Name(Class60.smethod_0(-2050197886));
		((Control)radioButton_2).set_Size(new Size(107, 25));
		((Control)radioButton_2).set_TabIndex(2);
		radioButton_2.set_TabStop(true);
		((Control)radioButton_2).set_Text(Class60.smethod_0(-2050197911));
		((ButtonBase)radioButton_2).set_UseVisualStyleBackColor(true);
		radioButton_2.add_CheckedChanged((EventHandler)radioButton_2_CheckedChanged);
		((Control)groupBox_1).get_Controls().Add((Control)(object)tableLayoutPanel_3);
		((Control)groupBox_1).set_Dock((DockStyle)5);
		((Control)groupBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)groupBox_1).set_ForeColor(SystemColors.Control);
		((Control)groupBox_1).set_Location(new Point(3, 3));
		((Control)groupBox_1).set_Name(Class60.smethod_0(-2050210886));
		((Control)groupBox_1).set_Size(new Size(384, 61));
		((Control)groupBox_1).set_TabIndex(4);
		groupBox_1.set_TabStop(false);
		((Control)groupBox_1).set_Text(Class60.smethod_0(-2050207009));
		tableLayoutPanel_3.set_ColumnCount(6);
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 11f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 28f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 11f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 11f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 19f));
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_0, 1, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_1, 0, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_2, 3, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_3, 2, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_4, 5, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_5, 4, 0);
		((Control)tableLayoutPanel_3).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)tableLayoutPanel_3).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_3).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_3).set_Name(Class60.smethod_0(-2050211259));
		((Control)tableLayoutPanel_3).set_Padding(new Padding(0, 0, 0, 5));
		tableLayoutPanel_3.set_RowCount(1);
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_3).set_Size(new Size(378, 36));
		((Control)tableLayoutPanel_3).set_TabIndex(0);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Dock((DockStyle)3);
		((Control)label_0).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_Location(new Point(41, 0));
		((Control)label_0).set_Margin(new Padding(0));
		((Control)label_0).set_Name(Class60.smethod_0(-2050207056));
		((Control)label_0).set_Size(new Size(33, 31));
		((Control)label_0).set_TabIndex(1);
		((Control)label_0).set_Text(Class60.smethod_0(-2050207089));
		label_0.set_TextAlign((ContentAlignment)16);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Dock((DockStyle)4);
		((Control)label_1).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_Location(new Point(13, 0));
		((Control)label_1).set_Margin(new Padding(0));
		((Control)label_1).set_Name(Class60.smethod_0(-2050208088));
		((Control)label_1).set_Size(new Size(28, 31));
		((Control)label_1).set_TabIndex(0);
		((Control)label_1).set_Text(Class60.smethod_0(-2050207086));
		label_1.set_TextAlign((ContentAlignment)64);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Dock((DockStyle)3);
		((Control)label_2).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_2).set_Location(new Point(187, 0));
		((Control)label_2).set_Margin(new Padding(0));
		((Control)label_2).set_Name(Class60.smethod_0(-2050207131));
		((Control)label_2).set_Size(new Size(28, 31));
		((Control)label_2).set_TabIndex(5);
		((Control)label_2).set_Text(Class60.smethod_0(-2050207118));
		label_2.set_TextAlign((ContentAlignment)16);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Dock((DockStyle)4);
		((Control)label_3).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_3).set_Location(new Point(155, 0));
		((Control)label_3).set_Margin(new Padding(0));
		((Control)label_3).set_Name(Class60.smethod_0(-2050207156));
		((Control)label_3).set_Size(new Size(32, 31));
		((Control)label_3).set_TabIndex(3);
		((Control)label_3).set_Text(Class60.smethod_0(-2050207143));
		label_3.set_TextAlign((ContentAlignment)64);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Dock((DockStyle)3);
		((Control)label_4).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_4).set_Location(new Point(303, 0));
		((Control)label_4).set_Margin(new Padding(0));
		((Control)label_4).set_Name(Class60.smethod_0(-2050207148));
		((Control)label_4).set_Size(new Size(28, 31));
		((Control)label_4).set_TabIndex(8);
		((Control)label_4).set_Text(Class60.smethod_0(-2050207118));
		label_4.set_TextAlign((ContentAlignment)16);
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_Dock((DockStyle)4);
		((Control)label_5).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_5).set_Location(new Point(271, 0));
		((Control)label_5).set_Margin(new Padding(0));
		((Control)label_5).set_Name(Class60.smethod_0(-2050207199));
		((Control)label_5).set_Size(new Size(32, 31));
		((Control)label_5).set_TabIndex(6);
		((Control)label_5).set_Text(Class60.smethod_0(-2050207170));
		label_5.set_TextAlign((ContentAlignment)16);
		tableLayoutPanel_1.set_ColumnCount(2);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)button_0, 0, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)button_1, 1, 0);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(0, 378));
		((Control)tableLayoutPanel_1).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050211375));
		tableLayoutPanel_1.set_RowCount(1);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)1, 44f));
		((Control)tableLayoutPanel_1).set_Size(new Size(390, 44));
		((Control)tableLayoutPanel_1).set_TabIndex(3);
		((Control)button_0).set_BackColor(Color.LightSeaGreen);
		((Control)button_0).set_Cursor(Cursors.get_Hand());
		((Control)button_0).set_Dock((DockStyle)5);
		((Control)button_0).set_Enabled(false);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)1);
		((Control)button_0).set_Font(new Font(Class60.smethod_0(-2050211150), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_0).set_ForeColor(SystemColors.Control);
		((Control)button_0).set_Location(new Point(3, 3));
		((Control)button_0).set_Name(Class60.smethod_0(-2050200350));
		((Control)button_0).set_Size(new Size(189, 38));
		((Control)button_0).set_TabIndex(2);
		((Control)button_0).set_Text(Class60.smethod_0(-2050200334));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)button_1).set_BackColor(Color.Salmon);
		((Control)button_1).set_Cursor(Cursors.get_Hand());
		((Control)button_1).set_Dock((DockStyle)5);
		((Control)button_1).set_Enabled(false);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)1);
		((Control)button_1).set_Font(new Font(Class60.smethod_0(-2050211150), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_1).set_ForeColor(SystemColors.Control);
		((Control)button_1).set_Location(new Point(198, 3));
		((Control)button_1).set_Name(Class60.smethod_0(-2050200316));
		((Control)button_1).set_Size(new Size(189, 38));
		((Control)button_1).set_TabIndex(3);
		((Control)button_1).set_Text(Class60.smethod_0(-2050200301));
		((ButtonBase)button_1).set_UseVisualStyleBackColor(false);
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((ToolStrip)menuStrip_0).set_BackColor(Color.Teal);
		((Control)menuStrip_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((ToolStrip)menuStrip_0).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)toolStripMenuItem_0,
			(ToolStripItem)toolStripMenuItem_1
		});
		((Control)menuStrip_0).set_Location(new Point(0, 0));
		((Control)menuStrip_0).set_Name(Class60.smethod_0(-2050200381));
		((Control)menuStrip_0).set_Size(new Size(404, 24));
		((Control)menuStrip_0).set_TabIndex(1);
		((Control)menuStrip_0).set_Text(Class60.smethod_0(-2050200381));
		((ToolStripItem)toolStripMenuItem_0).set_Name(Class60.smethod_0(-2050197890));
		((ToolStripItem)toolStripMenuItem_0).set_Size(new Size(64, 20));
		((ToolStripItem)toolStripMenuItem_0).set_Text(Class60.smethod_0(-2050200400));
		((ToolStripItem)toolStripMenuItem_0).add_Click((EventHandler)toolStripMenuItem_0_Click);
		((ToolStripDropDownItem)toolStripMenuItem_1).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)toolStripMenuItem_2,
			(ToolStripItem)toolStripMenuItem_3
		});
		((ToolStripItem)toolStripMenuItem_1).set_Name(Class60.smethod_0(-2050197926));
		((ToolStripItem)toolStripMenuItem_1).set_Size(new Size(47, 20));
		((ToolStripItem)toolStripMenuItem_1).set_Text(Class60.smethod_0(-2050202680));
		((ToolStripItem)toolStripMenuItem_2).set_Name(Class60.smethod_0(-2050197959));
		((ToolStripItem)toolStripMenuItem_2).set_Size(new Size(129, 22));
		((ToolStripItem)toolStripMenuItem_2).set_Text(Class60.smethod_0(-2050202701));
		((ToolStripItem)toolStripMenuItem_2).add_Click((EventHandler)toolStripMenuItem_2_Click);
		((ToolStripItem)toolStripMenuItem_3).set_Name(Class60.smethod_0(-2050197992));
		((ToolStripItem)toolStripMenuItem_3).set_Size(new Size(129, 22));
		((ToolStripItem)toolStripMenuItem_3).set_Text(Class60.smethod_0(-2050198043));
		((ToolStripItem)toolStripMenuItem_3).add_Click((EventHandler)toolStripMenuItem_3_Click);
		((Control)tabControl_0).get_Controls().Add((Control)(object)tabPage_0);
		((Control)tabControl_0).get_Controls().Add((Control)(object)tabPage_1);
		((Control)tabControl_0).get_Controls().Add((Control)(object)tabPage_2);
		((Control)tabControl_0).set_Dock((DockStyle)5);
		tabControl_0.set_DrawMode((TabDrawMode)1);
		tabControl_0.set_ItemSize(new Size(0, 1));
		((Control)tabControl_0).set_Location(new Point(0, 24));
		((Control)tabControl_0).set_Name(Class60.smethod_0(-2050202111));
		tabControl_0.set_SelectedIndex(0);
		((Control)tabControl_0).set_Size(new Size(404, 437));
		((Control)tabControl_0).set_TabIndex(2);
		((Control)tabPage_0).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_0).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		tabPage_0.set_Location(new Point(4, 5));
		((Control)tabPage_0).set_Margin(new Padding(0));
		((Control)tabPage_0).set_Name(Class60.smethod_0(-2050206984));
		((Control)tabPage_0).set_Padding(new Padding(3));
		((Control)tabPage_0).set_Size(new Size(396, 428));
		tabPage_0.set_TabIndex(0);
		((Control)tabPage_0).set_Text(Class60.smethod_0(-2050206984));
		((Control)tabPage_1).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_1).get_Controls().Add((Control)(object)tableLayoutPanel_5);
		tabPage_1.set_Location(new Point(4, 5));
		((Control)tabPage_1).set_Name(Class60.smethod_0(-2050199988));
		((Control)tabPage_1).set_Padding(new Padding(3));
		((Control)tabPage_1).set_Size(new Size(396, 428));
		tabPage_1.set_TabIndex(1);
		((Control)tabPage_1).set_Text(Class60.smethod_0(-2050199988));
		tableLayoutPanel_5.set_ColumnCount(1);
		tableLayoutPanel_5.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_5.get_Controls().Add((Control)(object)groupBox_5, 0, 3);
		tableLayoutPanel_5.get_Controls().Add((Control)(object)groupBox_6, 0, 2);
		tableLayoutPanel_5.get_Controls().Add((Control)(object)groupBox_4, 0, 1);
		tableLayoutPanel_5.get_Controls().Add((Control)(object)groupBox_3, 0, 0);
		((Control)tableLayoutPanel_5).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_5).set_Location(new Point(3, 3));
		((Control)tableLayoutPanel_5).set_Name(Class60.smethod_0(-2050206985));
		tableLayoutPanel_5.set_RowCount(5);
		tableLayoutPanel_5.get_RowStyles().Add(new RowStyle((SizeType)2, 18f));
		tableLayoutPanel_5.get_RowStyles().Add(new RowStyle((SizeType)2, 15f));
		tableLayoutPanel_5.get_RowStyles().Add(new RowStyle((SizeType)2, 15f));
		tableLayoutPanel_5.get_RowStyles().Add(new RowStyle((SizeType)2, 15f));
		tableLayoutPanel_5.get_RowStyles().Add(new RowStyle((SizeType)2, 37f));
		((Control)tableLayoutPanel_5).set_Size(new Size(390, 422));
		((Control)tableLayoutPanel_5).set_TabIndex(0);
		((Control)groupBox_5).get_Controls().Add((Control)(object)tableLayoutPanel_8);
		((Control)groupBox_5).set_Dock((DockStyle)5);
		((Control)groupBox_5).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5));
		((Control)groupBox_5).set_ForeColor(SystemColors.Control);
		((Control)groupBox_5).set_Location(new Point(3, 204));
		((Control)groupBox_5).set_Name(Class60.smethod_0(-2050198080));
		((Control)groupBox_5).set_Size(new Size(384, 57));
		((Control)groupBox_5).set_TabIndex(3);
		groupBox_5.set_TabStop(false);
		((Control)groupBox_5).set_Text(Class60.smethod_0(-2050198064));
		tableLayoutPanel_8.set_ColumnCount(2);
		tableLayoutPanel_8.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_8.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_8.get_Controls().Add((Control)(object)comboBox_0, 0, 0);
		tableLayoutPanel_8.get_Controls().Add((Control)(object)label_7, 0, 0);
		((Control)tableLayoutPanel_8).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_8).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_8).set_Name(Class60.smethod_0(-2050198139));
		tableLayoutPanel_8.set_RowCount(1);
		tableLayoutPanel_8.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_8).set_Size(new Size(378, 32));
		((Control)tableLayoutPanel_8).set_TabIndex(0);
		((Control)comboBox_0).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_0).set_Dock((DockStyle)5);
		comboBox_0.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1));
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		comboBox_0.get_Items().AddRange(new object[10]
		{
			Class60.smethod_0(-2050205598),
			Class60.smethod_0(-2050205567),
			Class60.smethod_0(-2050205550),
			Class60.smethod_0(-2050205627),
			Class60.smethod_0(-2050205590),
			Class60.smethod_0(-2050198162),
			Class60.smethod_0(-2050198170),
			Class60.smethod_0(-2050198146),
			Class60.smethod_0(-2050198154),
			Class60.smethod_0(-2050205620)
		});
		((Control)comboBox_0).set_Location(new Point(153, 2));
		((Control)comboBox_0).set_Margin(new Padding(2));
		((Control)comboBox_0).set_Name(Class60.smethod_0(-2050198194));
		((Control)comboBox_0).set_Size(new Size(223, 27));
		((Control)comboBox_0).set_TabIndex(11);
		comboBox_0.add_SelectedIndexChanged((EventHandler)comboBox_0_SelectedIndexChanged);
		((Control)label_7).set_AutoSize(true);
		((Control)label_7).set_Dock((DockStyle)5);
		((Control)label_7).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_7).set_Location(new Point(3, 0));
		((Control)label_7).set_Name(Class60.smethod_0(-2050198190));
		((Control)label_7).set_Size(new Size(145, 32));
		((Control)label_7).set_TabIndex(10);
		((Control)label_7).set_Text(Class60.smethod_0(-2050198225));
		label_7.set_TextAlign((ContentAlignment)64);
		((Control)groupBox_6).get_Controls().Add((Control)(object)tableLayoutPanel_9);
		((Control)groupBox_6).set_Dock((DockStyle)5);
		((Control)groupBox_6).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5));
		((Control)groupBox_6).set_ForeColor(SystemColors.Control);
		((Control)groupBox_6).set_Location(new Point(3, 141));
		((Control)groupBox_6).set_Name(Class60.smethod_0(-2050198296));
		((Control)groupBox_6).set_Size(new Size(384, 57));
		((Control)groupBox_6).set_TabIndex(2);
		groupBox_6.set_TabStop(false);
		((Control)groupBox_6).set_Text(Class60.smethod_0(-2050198280));
		tableLayoutPanel_9.set_ColumnCount(2);
		tableLayoutPanel_9.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_9.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_9.get_Controls().Add((Control)(object)label_8, 0, 0);
		tableLayoutPanel_9.get_Controls().Add((Control)(object)textBox_0, 1, 0);
		((Control)tableLayoutPanel_9).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_9).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_9).set_Name(Class60.smethod_0(-2050198317));
		tableLayoutPanel_9.set_RowCount(1);
		tableLayoutPanel_9.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_9.get_RowStyles().Add(new RowStyle((SizeType)1, 32f));
		((Control)tableLayoutPanel_9).set_Size(new Size(378, 32));
		((Control)tableLayoutPanel_9).set_TabIndex(0);
		((Control)label_8).set_AutoSize(true);
		((Control)label_8).set_Dock((DockStyle)5);
		((Control)label_8).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_8).set_Location(new Point(3, 0));
		((Control)label_8).set_Name(Class60.smethod_0(-2050202302));
		((Control)label_8).set_Size(new Size(145, 32));
		((Control)label_8).set_TabIndex(12);
		((Control)label_8).set_Text(Class60.smethod_0(-2050198341));
		label_8.set_TextAlign((ContentAlignment)64);
		((Control)textBox_0).set_Dock((DockStyle)5);
		((Control)textBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox_0).set_Location(new Point(154, 3));
		((TextBoxBase)textBox_0).set_MaxLength(3);
		((Control)textBox_0).set_Name(Class60.smethod_0(-2050198418));
		((Control)textBox_0).set_Size(new Size(221, 24));
		((Control)textBox_0).set_TabIndex(13);
		((Control)textBox_0).add_KeyDown(new KeyEventHandler(textBox_0_KeyDown));
		((Control)groupBox_4).get_Controls().Add((Control)(object)tableLayoutPanel_6);
		((Control)groupBox_4).set_Dock((DockStyle)5);
		((Control)groupBox_4).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5));
		((Control)groupBox_4).set_ForeColor(SystemColors.Control);
		((Control)groupBox_4).set_Location(new Point(3, 78));
		((Control)groupBox_4).set_Name(Class60.smethod_0(-2050198412));
		((Control)groupBox_4).set_Size(new Size(384, 57));
		((Control)groupBox_4).set_TabIndex(1);
		groupBox_4.set_TabStop(false);
		((Control)groupBox_4).set_Text(Class60.smethod_0(-2050198460));
		tableLayoutPanel_6.set_ColumnCount(2);
		tableLayoutPanel_6.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_6.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_6.get_Controls().Add((Control)(object)comboBox_1, 0, 0);
		tableLayoutPanel_6.get_Controls().Add((Control)(object)label_6, 0, 0);
		((Control)tableLayoutPanel_6).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_6).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_6).set_Name(Class60.smethod_0(-2050198489));
		tableLayoutPanel_6.set_RowCount(1);
		tableLayoutPanel_6.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_6).set_Size(new Size(378, 32));
		((Control)tableLayoutPanel_6).set_TabIndex(0);
		((Control)comboBox_1).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_1).set_Dock((DockStyle)5);
		comboBox_1.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1));
		((ListControl)comboBox_1).set_FormattingEnabled(true);
		comboBox_1.get_Items().AddRange(new object[6]
		{
			Class60.smethod_0(-2050195867),
			Class60.smethod_0(-2050195842),
			Class60.smethod_0(-2050195849),
			Class60.smethod_0(-2050195904),
			Class60.smethod_0(-2050195879),
			Class60.smethod_0(-2050195886)
		});
		((Control)comboBox_1).set_Location(new Point(153, 2));
		((Control)comboBox_1).set_Margin(new Padding(2));
		((Control)comboBox_1).set_Name(Class60.smethod_0(-2050196120));
		((Control)comboBox_1).set_Size(new Size(223, 27));
		((Control)comboBox_1).set_TabIndex(11);
		comboBox_1.add_SelectedIndexChanged((EventHandler)comboBox_1_SelectedIndexChanged);
		((Control)label_6).set_AutoSize(true);
		((Control)label_6).set_Dock((DockStyle)5);
		((Control)label_6).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_6).set_Location(new Point(3, 0));
		((Control)label_6).set_Name(Class60.smethod_0(-2050210999));
		((Control)label_6).set_Size(new Size(145, 32));
		((Control)label_6).set_TabIndex(10);
		((Control)label_6).set_Text(Class60.smethod_0(-2050198513));
		label_6.set_TextAlign((ContentAlignment)64);
		((Control)groupBox_3).get_Controls().Add((Control)(object)tableLayoutPanel_7);
		((Control)groupBox_3).set_Dock((DockStyle)5);
		((Control)groupBox_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5));
		((Control)groupBox_3).set_ForeColor(SystemColors.Control);
		((Control)groupBox_3).set_Location(new Point(3, 3));
		((Control)groupBox_3).set_Name(Class60.smethod_0(-2050225208));
		((Control)groupBox_3).set_Size(new Size(384, 69));
		((Control)groupBox_3).set_TabIndex(0);
		groupBox_3.set_TabStop(false);
		((Control)groupBox_3).set_Text(Class60.smethod_0(-2050225192));
		tableLayoutPanel_7.set_ColumnCount(1);
		tableLayoutPanel_7.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_7.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tableLayoutPanel_7.get_Controls().Add((Control)(object)button_2, 0, 0);
		((Control)tableLayoutPanel_7).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_7).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_7).set_Name(Class60.smethod_0(-2050200260));
		tableLayoutPanel_7.set_RowCount(1);
		tableLayoutPanel_7.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_7).set_Size(new Size(378, 44));
		((Control)tableLayoutPanel_7).set_TabIndex(0);
		((Control)button_2).set_BackColor(Color.Salmon);
		((Control)button_2).set_Cursor(Cursors.get_Hand());
		((Control)button_2).set_Dock((DockStyle)5);
		((ButtonBase)button_2).set_FlatStyle((FlatStyle)0);
		((Control)button_2).set_Font(new Font(Class60.smethod_0(-2050211150), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_2).set_Location(new Point(3, 3));
		((Control)button_2).set_Name(Class60.smethod_0(-2050225241));
		((Control)button_2).set_Size(new Size(372, 38));
		((Control)button_2).set_TabIndex(0);
		((Control)button_2).set_Text(Class60.smethod_0(-2050225268));
		((ButtonBase)button_2).set_UseVisualStyleBackColor(false);
		((Control)button_2).add_Click((EventHandler)button_2_Click);
		((Control)tabPage_2).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_2).get_Controls().Add((Control)(object)tableLayoutPanel_10);
		tabPage_2.set_Location(new Point(4, 5));
		((Control)tabPage_2).set_Name(Class60.smethod_0(-2050200014));
		((Control)tabPage_2).set_Padding(new Padding(3));
		((Control)tabPage_2).set_Size(new Size(396, 428));
		tabPage_2.set_TabIndex(2);
		((Control)tabPage_2).set_Text(Class60.smethod_0(-2050200014));
		tableLayoutPanel_10.set_ColumnCount(1);
		tableLayoutPanel_10.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_10.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tableLayoutPanel_10.get_Controls().Add((Control)(object)groupBox_7, 0, 0);
		((Control)tableLayoutPanel_10).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_10).set_Location(new Point(3, 3));
		((Control)tableLayoutPanel_10).set_Name(Class60.smethod_0(-2050225249));
		tableLayoutPanel_10.set_RowCount(1);
		tableLayoutPanel_10.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_10.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)tableLayoutPanel_10).set_Size(new Size(390, 422));
		((Control)tableLayoutPanel_10).set_TabIndex(0);
		((Control)groupBox_7).get_Controls().Add((Control)(object)tableLayoutPanel_11);
		((Control)groupBox_7).set_Dock((DockStyle)5);
		((Control)groupBox_7).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5));
		((Control)groupBox_7).set_ForeColor(SystemColors.Control);
		((Control)groupBox_7).set_Location(new Point(3, 3));
		((Control)groupBox_7).set_Name(Class60.smethod_0(-2050225288));
		((Control)groupBox_7).set_Size(new Size(384, 416));
		((Control)groupBox_7).set_TabIndex(0);
		groupBox_7.set_TabStop(false);
		((Control)groupBox_7).set_Text(Class60.smethod_0(-2050198043));
		tableLayoutPanel_11.set_ColumnCount(3);
		tableLayoutPanel_11.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 45f));
		tableLayoutPanel_11.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		tableLayoutPanel_11.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 30f));
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_11, 1, 11);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_12, 0, 11);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_13, 1, 10);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_14, 0, 10);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_15, 1, 9);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_16, 0, 9);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_17, 1, 8);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_18, 0, 8);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_19, 1, 7);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_20, 0, 7);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_21, 1, 5);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_22, 0, 5);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_23, 1, 4);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_24, 0, 4);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_25, 1, 3);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_26, 0, 3);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_27, 1, 1);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_28, 0, 1);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_9, 1, 0);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_10, 0, 0);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)comboBox_2, 2, 0);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)comboBox_3, 2, 1);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)comboBox_4, 2, 3);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)comboBox_5, 2, 4);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)comboBox_6, 2, 5);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)comboBox_7, 2, 7);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)comboBox_8, 2, 8);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)comboBox_9, 2, 9);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)comboBox_10, 2, 10);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)comboBox_11, 2, 11);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_29, 0, 2);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_30, 0, 6);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_31, 1, 2);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)label_32, 1, 6);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)comboBox_12, 2, 2);
		tableLayoutPanel_11.get_Controls().Add((Control)(object)comboBox_13, 2, 6);
		((Control)tableLayoutPanel_11).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_11).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_11).set_Name(Class60.smethod_0(-2050225336));
		tableLayoutPanel_11.set_RowCount(12);
		tableLayoutPanel_11.get_RowStyles().Add(new RowStyle((SizeType)2, 8.333332f));
		tableLayoutPanel_11.get_RowStyles().Add(new RowStyle((SizeType)2, 8.333332f));
		tableLayoutPanel_11.get_RowStyles().Add(new RowStyle((SizeType)2, 8.333332f));
		tableLayoutPanel_11.get_RowStyles().Add(new RowStyle((SizeType)2, 8.333332f));
		tableLayoutPanel_11.get_RowStyles().Add(new RowStyle((SizeType)2, 8.333332f));
		tableLayoutPanel_11.get_RowStyles().Add(new RowStyle((SizeType)2, 8.333332f));
		tableLayoutPanel_11.get_RowStyles().Add(new RowStyle((SizeType)2, 8.333332f));
		tableLayoutPanel_11.get_RowStyles().Add(new RowStyle((SizeType)2, 8.333332f));
		tableLayoutPanel_11.get_RowStyles().Add(new RowStyle((SizeType)2, 8.333332f));
		tableLayoutPanel_11.get_RowStyles().Add(new RowStyle((SizeType)2, 8.333332f));
		tableLayoutPanel_11.get_RowStyles().Add(new RowStyle((SizeType)2, 8.333332f));
		tableLayoutPanel_11.get_RowStyles().Add(new RowStyle((SizeType)2, 8.333332f));
		((Control)tableLayoutPanel_11).set_Size(new Size(378, 391));
		((Control)tableLayoutPanel_11).set_TabIndex(0);
		((Control)label_11).set_AutoSize(true);
		((Control)label_11).set_Dock((DockStyle)4);
		((Control)label_11).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_11).set_Location(new Point(184, 352));
		((Control)label_11).set_Name(Class60.smethod_0(-2050225327));
		((Control)label_11).set_Size(new Size(77, 39));
		((Control)label_11).set_TabIndex(29);
		((Control)label_11).set_Text(Class60.smethod_0(-2050225361));
		label_11.set_TextAlign((ContentAlignment)64);
		((Control)label_12).set_AutoSize(true);
		((Control)label_12).set_Dock((DockStyle)4);
		((Control)label_12).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_12).set_Location(new Point(93, 352));
		((Control)label_12).set_Name(Class60.smethod_0(-2050225404));
		((Control)label_12).set_Size(new Size(74, 39));
		((Control)label_12).set_TabIndex(28);
		((Control)label_12).set_Text(Class60.smethod_0(-2050225390));
		label_12.set_TextAlign((ContentAlignment)16);
		((Control)label_13).set_AutoSize(true);
		((Control)label_13).set_Dock((DockStyle)4);
		((Control)label_13).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_13).set_Location(new Point(184, 320));
		((Control)label_13).set_Name(Class60.smethod_0(-2050225421));
		((Control)label_13).set_Size(new Size(77, 32));
		((Control)label_13).set_TabIndex(27);
		((Control)label_13).set_Text(Class60.smethod_0(-2050225361));
		label_13.set_TextAlign((ContentAlignment)64);
		((Control)label_14).set_AutoSize(true);
		((Control)label_14).set_Dock((DockStyle)4);
		((Control)label_14).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_14).set_Location(new Point(89, 320));
		((Control)label_14).set_Name(Class60.smethod_0(-2050225471));
		((Control)label_14).set_Size(new Size(78, 32));
		((Control)label_14).set_TabIndex(26);
		((Control)label_14).set_Text(Class60.smethod_0(-2050225441));
		label_14.set_TextAlign((ContentAlignment)16);
		((Control)label_15).set_AutoSize(true);
		((Control)label_15).set_Dock((DockStyle)4);
		((Control)label_15).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_15).set_Location(new Point(184, 288));
		((Control)label_15).set_Name(Class60.smethod_0(-2050225486));
		((Control)label_15).set_Size(new Size(77, 32));
		((Control)label_15).set_TabIndex(25);
		((Control)label_15).set_Text(Class60.smethod_0(-2050225361));
		label_15.set_TextAlign((ContentAlignment)64);
		((Control)label_16).set_AutoSize(true);
		((Control)label_16).set_Dock((DockStyle)4);
		((Control)label_16).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_16).set_Location(new Point(102, 288));
		((Control)label_16).set_Name(Class60.smethod_0(-2050225536));
		((Control)label_16).set_Size(new Size(65, 32));
		((Control)label_16).set_TabIndex(24);
		((Control)label_16).set_Text(Class60.smethod_0(-2050225506));
		label_16.set_TextAlign((ContentAlignment)16);
		((Control)label_17).set_AutoSize(true);
		((Control)label_17).set_Dock((DockStyle)4);
		((Control)label_17).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_17).set_Location(new Point(184, 256));
		((Control)label_17).set_Name(Class60.smethod_0(-2050225541));
		((Control)label_17).set_Size(new Size(77, 32));
		((Control)label_17).set_TabIndex(23);
		((Control)label_17).set_Text(Class60.smethod_0(-2050225361));
		label_17.set_TextAlign((ContentAlignment)64);
		((Control)label_18).set_AutoSize(true);
		((Control)label_18).set_Dock((DockStyle)4);
		((Control)label_18).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_18).set_Location(new Point(58, 256));
		((Control)label_18).set_Name(Class60.smethod_0(-2050225591));
		((Control)label_18).set_Size(new Size(109, 32));
		((Control)label_18).set_TabIndex(22);
		((Control)label_18).set_Text(Class60.smethod_0(-2050225593));
		label_18.set_TextAlign((ContentAlignment)16);
		((Control)label_19).set_AutoSize(true);
		((Control)label_19).set_Dock((DockStyle)4);
		((Control)label_19).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_19).set_Location(new Point(184, 224));
		((Control)label_19).set_Name(Class60.smethod_0(-2050225612));
		((Control)label_19).set_Size(new Size(77, 32));
		((Control)label_19).set_TabIndex(21);
		((Control)label_19).set_Text(Class60.smethod_0(-2050225361));
		label_19.set_TextAlign((ContentAlignment)64);
		((Control)label_20).set_AutoSize(true);
		((Control)label_20).set_Dock((DockStyle)4);
		((Control)label_20).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_20).set_Location(new Point(86, 224));
		((Control)label_20).set_Name(Class60.smethod_0(-2050225662));
		((Control)label_20).set_Size(new Size(81, 32));
		((Control)label_20).set_TabIndex(20);
		((Control)label_20).set_Text(Class60.smethod_0(-2050225648));
		label_20.set_TextAlign((ContentAlignment)16);
		((Control)label_21).set_AutoSize(true);
		((Control)label_21).set_Dock((DockStyle)4);
		((Control)label_21).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_21).set_Location(new Point(184, 160));
		((Control)label_21).set_Name(Class60.smethod_0(-2050225675));
		((Control)label_21).set_Size(new Size(77, 32));
		((Control)label_21).set_TabIndex(19);
		((Control)label_21).set_Text(Class60.smethod_0(-2050225361));
		label_21.set_TextAlign((ContentAlignment)64);
		((Control)label_22).set_AutoSize(true);
		((Control)label_22).set_Dock((DockStyle)4);
		((Control)label_22).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_22).set_Location(new Point(22, 160));
		((Control)label_22).set_Name(Class60.smethod_0(-2050225725));
		((Control)label_22).set_Size(new Size(145, 32));
		((Control)label_22).set_TabIndex(18);
		((Control)label_22).set_Text(Class60.smethod_0(-2050225711));
		label_22.set_TextAlign((ContentAlignment)16);
		((Control)label_23).set_AutoSize(true);
		((Control)label_23).set_Dock((DockStyle)4);
		((Control)label_23).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_23).set_Location(new Point(184, 128));
		((Control)label_23).set_Name(Class60.smethod_0(-2050225766));
		((Control)label_23).set_Size(new Size(77, 32));
		((Control)label_23).set_TabIndex(17);
		((Control)label_23).set_Text(Class60.smethod_0(-2050225361));
		label_23.set_TextAlign((ContentAlignment)64);
		((Control)label_24).set_AutoSize(true);
		((Control)label_24).set_Dock((DockStyle)4);
		((Control)label_24).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_24).set_Location(new Point(41, 128));
		((Control)label_24).set_Name(Class60.smethod_0(-2050225816));
		((Control)label_24).set_Size(new Size(126, 32));
		((Control)label_24).set_TabIndex(16);
		((Control)label_24).set_Text(Class60.smethod_0(-2050225818));
		label_24.set_TextAlign((ContentAlignment)16);
		((Control)label_25).set_AutoSize(true);
		((Control)label_25).set_Dock((DockStyle)4);
		((Control)label_25).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_25).set_Location(new Point(184, 96));
		((Control)label_25).set_Name(Class60.smethod_0(-2050225879));
		((Control)label_25).set_Size(new Size(77, 32));
		((Control)label_25).set_TabIndex(15);
		((Control)label_25).set_Text(Class60.smethod_0(-2050225361));
		label_25.set_TextAlign((ContentAlignment)64);
		((Control)label_26).set_AutoSize(true);
		((Control)label_26).set_Dock((DockStyle)4);
		((Control)label_26).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_26).set_Location(new Point(54, 96));
		((Control)label_26).set_Name(Class60.smethod_0(-2050225881));
		((Control)label_26).set_Size(new Size(113, 32));
		((Control)label_26).set_TabIndex(14);
		((Control)label_26).set_Text(Class60.smethod_0(-2050225867));
		label_26.set_TextAlign((ContentAlignment)16);
		((Control)label_27).set_AutoSize(true);
		((Control)label_27).set_Dock((DockStyle)4);
		((Control)label_27).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_27).set_Location(new Point(184, 32));
		((Control)label_27).set_Name(Class60.smethod_0(-2050225950));
		((Control)label_27).set_Size(new Size(77, 32));
		((Control)label_27).set_TabIndex(13);
		((Control)label_27).set_Text(Class60.smethod_0(-2050225361));
		label_27.set_TextAlign((ContentAlignment)64);
		((Control)label_28).set_AutoSize(true);
		((Control)label_28).set_Dock((DockStyle)4);
		((Control)label_28).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_28).set_Location(new Point(57, 32));
		((Control)label_28).set_Name(Class60.smethod_0(-2050225936));
		((Control)label_28).set_Size(new Size(110, 32));
		((Control)label_28).set_TabIndex(12);
		((Control)label_28).set_Text(Class60.smethod_0(-2050225970));
		label_28.set_TextAlign((ContentAlignment)16);
		((Control)label_9).set_AutoSize(true);
		((Control)label_9).set_Dock((DockStyle)4);
		((Control)label_9).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_9).set_Location(new Point(184, 0));
		((Control)label_9).set_Name(Class60.smethod_0(-2050225987));
		((Control)label_9).set_Size(new Size(77, 32));
		((Control)label_9).set_TabIndex(1);
		((Control)label_9).set_Text(Class60.smethod_0(-2050225361));
		label_9.set_TextAlign((ContentAlignment)64);
		((Control)label_10).set_AutoSize(true);
		((Control)label_10).set_Dock((DockStyle)4);
		((Control)label_10).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_10).set_Location(new Point(70, 0));
		((Control)label_10).set_Name(Class60.smethod_0(-2050226038));
		((Control)label_10).set_Size(new Size(97, 32));
		((Control)label_10).set_TabIndex(0);
		((Control)label_10).set_Text(Class60.smethod_0(-2050226041));
		label_10.set_TextAlign((ContentAlignment)16);
		((Control)comboBox_2).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_2).set_Dock((DockStyle)5);
		comboBox_2.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_2).set_FormattingEnabled(true);
		((Control)comboBox_2).set_Location(new Point(267, 3));
		((Control)comboBox_2).set_Name(Class60.smethod_0(-2050226064));
		((Control)comboBox_2).set_Size(new Size(108, 27));
		((Control)comboBox_2).set_TabIndex(2);
		comboBox_2.add_SelectedIndexChanged((EventHandler)comboBox_2_SelectedIndexChanged);
		((Control)comboBox_3).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_3).set_Dock((DockStyle)5);
		comboBox_3.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_3).set_FormattingEnabled(true);
		((Control)comboBox_3).set_Location(new Point(267, 35));
		((Control)comboBox_3).set_Name(Class60.smethod_0(-2050226105));
		((Control)comboBox_3).set_Size(new Size(108, 27));
		((Control)comboBox_3).set_TabIndex(3);
		comboBox_3.add_SelectedIndexChanged((EventHandler)comboBox_3_SelectedIndexChanged);
		((Control)comboBox_4).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_4).set_Dock((DockStyle)5);
		comboBox_4.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_4).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_4).set_FormattingEnabled(true);
		((Control)comboBox_4).set_Location(new Point(267, 99));
		((Control)comboBox_4).set_Name(Class60.smethod_0(-2050226143));
		((Control)comboBox_4).set_Size(new Size(108, 27));
		((Control)comboBox_4).set_TabIndex(4);
		comboBox_4.add_SelectedIndexChanged((EventHandler)comboBox_4_SelectedIndexChanged);
		((Control)comboBox_5).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_5).set_Dock((DockStyle)5);
		comboBox_5.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_5).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_5).set_FormattingEnabled(true);
		((Control)comboBox_5).set_Location(new Point(267, 131));
		((Control)comboBox_5).set_Name(Class60.smethod_0(-2050226166));
		((Control)comboBox_5).set_Size(new Size(108, 27));
		((Control)comboBox_5).set_TabIndex(5);
		comboBox_5.add_SelectedIndexChanged((EventHandler)comboBox_5_SelectedIndexChanged);
		((Control)comboBox_6).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_6).set_Dock((DockStyle)5);
		comboBox_6.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_6).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_6).set_FormattingEnabled(true);
		((Control)comboBox_6).set_Location(new Point(267, 163));
		((Control)comboBox_6).set_Name(Class60.smethod_0(-2050226154));
		((Control)comboBox_6).set_Size(new Size(108, 27));
		((Control)comboBox_6).set_TabIndex(6);
		comboBox_6.add_SelectedIndexChanged((EventHandler)comboBox_6_SelectedIndexChanged);
		((Control)comboBox_7).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_7).set_Dock((DockStyle)5);
		comboBox_7.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_7).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_7).set_FormattingEnabled(true);
		((Control)comboBox_7).set_Location(new Point(267, 227));
		((Control)comboBox_7).set_Name(Class60.smethod_0(-2050224139));
		((Control)comboBox_7).set_Size(new Size(108, 27));
		((Control)comboBox_7).set_TabIndex(7);
		comboBox_7.add_SelectedIndexChanged((EventHandler)comboBox_7_SelectedIndexChanged);
		((Control)comboBox_8).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_8).set_Dock((DockStyle)5);
		comboBox_8.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_8).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_8).set_FormattingEnabled(true);
		((Control)comboBox_8).set_Location(new Point(267, 259));
		((Control)comboBox_8).set_Name(Class60.smethod_0(-2050224175));
		((Control)comboBox_8).set_Size(new Size(108, 27));
		((Control)comboBox_8).set_TabIndex(8);
		comboBox_8.add_SelectedIndexChanged((EventHandler)comboBox_8_SelectedIndexChanged);
		((Control)comboBox_9).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_9).set_Dock((DockStyle)5);
		comboBox_9.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_9).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_9).set_FormattingEnabled(true);
		((Control)comboBox_9).set_Location(new Point(267, 291));
		((Control)comboBox_9).set_Name(Class60.smethod_0(-2050224207));
		((Control)comboBox_9).set_Size(new Size(108, 27));
		((Control)comboBox_9).set_TabIndex(9);
		comboBox_9.add_SelectedIndexChanged((EventHandler)comboBox_9_SelectedIndexChanged);
		((Control)comboBox_10).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_10).set_Dock((DockStyle)5);
		comboBox_10.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_10).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_10).set_FormattingEnabled(true);
		((Control)comboBox_10).set_Location(new Point(267, 323));
		((Control)comboBox_10).set_Name(Class60.smethod_0(-2050224231));
		((Control)comboBox_10).set_Size(new Size(108, 27));
		((Control)comboBox_10).set_TabIndex(10);
		comboBox_10.add_SelectedIndexChanged((EventHandler)comboBox_10_SelectedIndexChanged);
		((Control)comboBox_11).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_11).set_Dock((DockStyle)5);
		comboBox_11.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_11).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_11).set_FormattingEnabled(true);
		((Control)comboBox_11).set_Location(new Point(267, 355));
		((Control)comboBox_11).set_Name(Class60.smethod_0(-2050224284));
		((Control)comboBox_11).set_Size(new Size(108, 27));
		((Control)comboBox_11).set_TabIndex(11);
		comboBox_11.add_SelectedIndexChanged((EventHandler)comboBox_11_SelectedIndexChanged);
		((Control)label_29).set_AutoSize(true);
		((Control)label_29).set_Dock((DockStyle)4);
		((Control)label_29).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_29).set_Location(new Point(25, 64));
		((Control)label_29).set_Name(Class60.smethod_0(-2050210921));
		((Control)label_29).set_Size(new Size(142, 32));
		((Control)label_29).set_TabIndex(30);
		((Control)label_29).set_Text(Class60.smethod_0(-2050224306));
		label_29.set_TextAlign((ContentAlignment)64);
		((Control)label_30).set_AutoSize(true);
		((Control)label_30).set_Dock((DockStyle)4);
		((Control)label_30).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_30).set_Location(new Point(9, 192));
		((Control)label_30).set_Name(Class60.smethod_0(-2050224331));
		((Control)label_30).set_Size(new Size(158, 32));
		((Control)label_30).set_TabIndex(31);
		((Control)label_30).set_Text(Class60.smethod_0(-2050224381));
		label_30.set_TextAlign((ContentAlignment)64);
		((Control)label_31).set_AutoSize(true);
		((Control)label_31).set_Dock((DockStyle)4);
		((Control)label_31).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_31).set_Location(new Point(184, 64));
		((Control)label_31).set_Name(Class60.smethod_0(-2050224434));
		((Control)label_31).set_Size(new Size(77, 32));
		((Control)label_31).set_TabIndex(32);
		((Control)label_31).set_Text(Class60.smethod_0(-2050225361));
		label_31.set_TextAlign((ContentAlignment)64);
		((Control)label_32).set_AutoSize(true);
		((Control)label_32).set_Dock((DockStyle)4);
		((Control)label_32).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_32).set_Location(new Point(184, 192));
		((Control)label_32).set_Name(Class60.smethod_0(-2050224420));
		((Control)label_32).set_Size(new Size(77, 32));
		((Control)label_32).set_TabIndex(33);
		((Control)label_32).set_Text(Class60.smethod_0(-2050225361));
		label_32.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_12).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_12).set_Dock((DockStyle)5);
		comboBox_12.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_12).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1));
		((ListControl)comboBox_12).set_FormattingEnabled(true);
		((Control)comboBox_12).set_Location(new Point(267, 67));
		((Control)comboBox_12).set_Name(Class60.smethod_0(-2050224470));
		((Control)comboBox_12).set_Size(new Size(108, 27));
		((Control)comboBox_12).set_TabIndex(34);
		comboBox_12.add_SelectedIndexChanged((EventHandler)comboBox_12_SelectedIndexChanged);
		((Control)comboBox_13).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_13).set_Dock((DockStyle)5);
		comboBox_13.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_13).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1));
		((ListControl)comboBox_13).set_FormattingEnabled(true);
		((Control)comboBox_13).set_Location(new Point(267, 195));
		((Control)comboBox_13).set_Name(Class60.smethod_0(-2050224504));
		((Control)comboBox_13).set_Size(new Size(108, 27));
		((Control)comboBox_13).set_TabIndex(35);
		comboBox_13.add_SelectedIndexChanged((EventHandler)comboBox_13_SelectedIndexChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkSlateGray);
		((Form)this).set_ClientSize(new Size(404, 461));
		((Control)this).get_Controls().Add((Control)(object)tabControl_0);
		((Control)this).get_Controls().Add((Control)(object)menuStrip_0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(Class60.smethod_0(-2050208183)));
		((Form)this).set_MainMenuStrip(menuStrip_0);
		((Control)this).set_MinimumSize(new Size(420, 500));
		((Control)this).set_Name(Class60.smethod_0(-2050224536));
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(Class60.smethod_0(-2050224516));
		((Form)this).add_FormClosing(new FormClosingEventHandler(GForm1_FormClosing));
		((Form)this).add_Load((EventHandler)GForm1_Load);
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((Control)groupBox_2).ResumeLayout(false);
		((Control)tableLayoutPanel_4).ResumeLayout(false);
		((Control)tableLayoutPanel_4).PerformLayout();
		((Control)groupBox_0).ResumeLayout(false);
		((Control)tableLayoutPanel_2).ResumeLayout(false);
		((Control)tableLayoutPanel_2).PerformLayout();
		((Control)groupBox_1).ResumeLayout(false);
		((Control)tableLayoutPanel_3).ResumeLayout(false);
		((Control)tableLayoutPanel_3).PerformLayout();
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)menuStrip_0).ResumeLayout(false);
		((Control)menuStrip_0).PerformLayout();
		((Control)tabControl_0).ResumeLayout(false);
		((Control)tabPage_0).ResumeLayout(false);
		((Control)tabPage_1).ResumeLayout(false);
		((Control)tableLayoutPanel_5).ResumeLayout(false);
		((Control)groupBox_5).ResumeLayout(false);
		((Control)tableLayoutPanel_8).ResumeLayout(false);
		((Control)tableLayoutPanel_8).PerformLayout();
		((Control)groupBox_6).ResumeLayout(false);
		((Control)tableLayoutPanel_9).ResumeLayout(false);
		((Control)tableLayoutPanel_9).PerformLayout();
		((Control)groupBox_4).ResumeLayout(false);
		((Control)tableLayoutPanel_6).ResumeLayout(false);
		((Control)tableLayoutPanel_6).PerformLayout();
		((Control)groupBox_3).ResumeLayout(false);
		((Control)tableLayoutPanel_7).ResumeLayout(false);
		((Control)tabPage_2).ResumeLayout(false);
		((Control)tableLayoutPanel_10).ResumeLayout(false);
		((Control)groupBox_7).ResumeLayout(false);
		((Control)tableLayoutPanel_11).ResumeLayout(false);
		((Control)tableLayoutPanel_11).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
