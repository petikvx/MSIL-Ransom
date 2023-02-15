using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using UNIVERSALGAME.Properties;

public sealed class GForm3 : Form
{
	private sealed class Class25
	{
		public int int_0;

		internal bool method_0(string string_0)
		{
			return string_0.Equals(int_0.ToString());
		}
	}

	private sealed class Class26
	{
		public int int_0;

		internal bool method_0(string string_0)
		{
			return string_0.Equals(int_0.ToString());
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct4 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm3 gform3_0;

		private TaskAwaiter<GClass5> taskAwaiter_0;

		private void MoveNext()
		{
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected O, but got Unknown
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0315: Expected O, but got Unknown
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_048e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0493: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b6: Expected O, but got Unknown
			//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0503: Unknown result type (might be due to invalid IL or missing references)
			//IL_0508: Unknown result type (might be due to invalid IL or missing references)
			//IL_052b: Expected O, but got Unknown
			//IL_0526: Unknown result type (might be due to invalid IL or missing references)
			int num = int_0;
			GForm3 gForm = gform3_0;
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
						goto IL_0217;
					}
					if (gForm.bool_0)
					{
						goto IL_01c4;
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
						if (gForm.gclass14_0.method_5(gForm.process_0[0].Id, 1))
						{
							gForm.gclass14_0.method_1(gForm.process_0[0].Id);
							if (gForm.gclass14_0.method_9(gForm.gclass12_0.MAX_HP) > 0)
							{
								gForm.gclass14_0.method_10(gForm.gclass12_0.MAX_ZOOM, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050224589));
								((Control)gForm.label_1).set_Text(gForm.gclass14_0.method_8(gForm.gclass12_0.NAME));
								((Control)gForm.label_2).set_Text(Class60.smethod_0(-2050197272));
								((Control)gForm.label_2).set_ForeColor(Color.Black);
								gForm.bool_0 = true;
							}
							else
							{
								((Control)gForm.label_2).set_Text(Class60.smethod_0(-2050197299));
								((Control)gForm.label_2).set_ForeColor(Color.DarkRed);
							}
							goto IL_01c4;
						}
						Form val = new Form();
						val.set_TopMost(true);
						MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050197103), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
					}
					else
					{
						Form val2 = new Form();
						val2.set_TopMost(true);
						MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050197342), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					goto end_IL_000e;
					IL_01c4:
					awaiter = GClass6.smethod_8().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0217;
					IL_0217:
					GClass5 gClass = (gForm.gclass5_0 = awaiter.GetResult());
					if (gForm.gclass5_0 != null)
					{
						gForm.gclass12_0.amountPtr = 15;
						if (gForm.gclass14_0.method_9(gForm.gclass12_0.MONSTER_SMOKIE.ToString()) == 184)
						{
							goto IL_031b;
						}
						gForm.gclass14_0.method_10(gForm.gclass12_0.MONSTER_SMOKIE, Class60.smethod_0(-2050205505), 184.ToString());
						if (gForm.gclass14_0.method_9(gForm.gclass12_0.MONSTER_HIDING) != 0)
						{
							gForm.gclass14_0.method_10(gForm.gclass12_0.MONSTER_HIDING, Class60.smethod_0(-2050205505), (gForm.gclass14_0.method_9(gForm.gclass12_0.MONSTER_HIDING) + 20).ToString());
							goto IL_031b;
						}
						Form val3 = new Form();
						val3.set_TopMost(true);
						MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050224636), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
					else
					{
						gForm.gclass12_0 = null;
						Form val4 = new Form();
						val4.set_TopMost(true);
						MessageBox.Show((IWin32Window)val4, Class60.smethod_0(-2050197399), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
					}
					goto end_IL_000e;
					IL_031b:
					((Control)gForm.button_1).set_Enabled(false);
					((Control)gForm.button_0).set_Enabled(true);
					((Control)gForm.comboBox_1).set_Enabled(false);
					((Control)gForm.comboBox_0).set_Enabled(false);
					((Control)gForm.comboBox_2).set_Enabled(false);
					((Control)gForm.textBox_0).set_Enabled(false);
					((Control)gForm.comboBox_3).set_Enabled(false);
					((Control)gForm.textBox_1).set_Enabled(false);
					((Control)gForm.checkBox_0).set_Enabled(false);
					((Control)gForm.checkBox_1).set_Enabled(false);
					((Control)gForm.button_2).set_Enabled(false);
					((Control)gForm.button_3).set_Enabled(false);
					gForm.class27_1.RunWorkerAsync();
					if (gForm.checkBox_1.get_Checked())
					{
						gForm.gclass14_0.method_11(gForm.gclass12_0.NO_DELAY_1, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050224705));
						gForm.gclass14_0.method_11(gForm.gclass12_0.NO_DELAY_2, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050224768));
					}
					else
					{
						gForm.gclass14_0.method_11(gForm.gclass12_0.NO_DELAY_1, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050224751));
						gForm.gclass14_0.method_11(gForm.gclass12_0.NO_DELAY_2, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050224798));
					}
					if (gForm.checkBox_0.get_Checked())
					{
						gForm.class27_0.RunWorkerAsync();
					}
					end_IL_000e:;
				}
				catch
				{
					if (gForm.class27_0.IsBusy)
					{
						gForm.class27_0.method_0();
						gForm.class27_0.Dispose();
					}
					if (gForm.class27_1.IsBusy)
					{
						gForm.class27_1.method_0();
						gForm.class27_1.Dispose();
					}
					Form val5 = new Form();
					val5.set_TopMost(true);
					MessageBox.Show((IWin32Window)val5, Class60.smethod_0(-2050195508), Class60.smethod_0(-2050195508), (MessageBoxButtons)0, (MessageBoxIcon)16);
					gForm.button_0.PerformClick();
					((Control)gForm.button_1).set_Enabled(true);
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

	private sealed class Class27 : BackgroundWorker
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

	[StructLayout(LayoutKind.Auto)]
	private struct Struct5 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm3 gform3_0;

		private TaskAwaiter<GClass12> taskAwaiter_0;

		private void MoveNext()
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0381: Expected O, but got Unknown
			//IL_037c: Unknown result type (might be due to invalid IL or missing references)
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c5: Expected O, but got Unknown
			//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
			int num = int_0;
			GForm3 gForm = gform3_0;
			try
			{
				try
				{
					TaskAwaiter<GClass12> awaiter;
					if (num == 0)
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<GClass12>);
						num = -1;
						int_0 = -1;
						goto IL_00b9;
					}
					if (gForm.gclass1_0 != null)
					{
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
						goto IL_00b9;
					}
					Form val = new Form();
					val.set_TopMost(true);
					MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050210429), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)gForm).Close();
					goto end_IL_000e;
					IL_00b9:
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
						Dictionary<string, int>.Enumerator enumerator = gForm.struct6_0.method_0().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								KeyValuePair<string, int> current = enumerator.Current;
								gForm.comboBox_1.get_Items().Add((object)current.Key);
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						Dictionary<string, int>.Enumerator enumerator2 = gForm.struct7_0.method_0().GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								KeyValuePair<string, int> current2 = enumerator2.Current;
								gForm.comboBox_0.get_Items().Add((object)current2.Key);
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator2).Dispose();
							}
						}
						((ListControl)gForm.comboBox_1).set_SelectedIndex(0);
						((ListControl)gForm.comboBox_0).set_SelectedIndex(0);
						((Control)gForm.button_1).set_Enabled(true);
					}
					else
					{
						Form val2 = new Form();
						val2.set_TopMost(true);
						MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050203423), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
					}
					end_IL_000e:;
				}
				catch
				{
					((Control)gForm.button_1).set_Enabled(false);
					((Control)gForm.button_0).set_Enabled(false);
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

	private struct Struct6
	{
		private Dictionary<string, int> dictionary_0;

		public Dictionary<string, int> method_0()
		{
			return dictionary_0;
		}

		public void method_1()
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			dictionary.Add(Class60.smethod_0(-2050224781), 7);
			dictionary.Add(Class60.smethod_0(-2050224832), 12);
			dictionary.Add(Class60.smethod_0(-2050224801), 15);
			dictionary.Add(Class60.smethod_0(-2050224854), 16);
			dictionary.Add(Class60.smethod_0(-2050224859), 19);
			dictionary.Add(Class60.smethod_0(-2050224848), 20);
			dictionary.Add(Class60.smethod_0(-2050224883), 4008);
			dictionary.Add(Class60.smethod_0(-2050224865), 4012);
			dictionary.Add(Class60.smethod_0(-2050224916), 4015);
			dictionary.Add(Class60.smethod_0(-2050224902), 4016);
			dictionary.Add(Class60.smethod_0(-2050224951), 4017);
			dictionary.Add(Class60.smethod_0(-2050224953), 4020);
			dictionary.Add(Class60.smethod_0(-2050224940), 4021);
			dictionary.Add(Class60.smethod_0(-2050224992), 4049);
			dictionary.Add(Class60.smethod_0(-2050224974), 4062);
			dictionary.Add(Class60.smethod_0(-2050225009), 4063);
			dictionary_0 = dictionary;
		}
	}

	private struct Struct7
	{
		private Dictionary<string, int> dictionary_0;

		public Dictionary<string, int> method_0()
		{
			return dictionary_0;
		}

		public void method_1()
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			dictionary.Add(Class60.smethod_0(-2050225007), 28);
			dictionary.Add(Class60.smethod_0(-2050225044), 29);
			dictionary.Add(Class60.smethod_0(-2050225030), 34);
			dictionary.Add(Class60.smethod_0(-2050225079), 46);
			dictionary.Add(Class60.smethod_0(-2050225059), 47);
			dictionary.Add(Class60.smethod_0(-2050225120), 73);
			dictionary.Add(Class60.smethod_0(-2050225092), 289);
			dictionary.Add(Class60.smethod_0(-2050225142), 379);
			dictionary.Add(Class60.smethod_0(-2050225121), 2022);
			dictionary.Add(Class60.smethod_0(-2050227230), 2031);
			dictionary.Add(Class60.smethod_0(-2050227209), 2040);
			dictionary_0 = dictionary;
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

	private Struct7 struct7_0;

	private Struct6 struct6_0;

	private Class27 class27_0 = new Class27();

	private Class27 class27_1 = new Class27();

	private Process[] process_0;

	private GClass8 gclass8_0;

	private int int_0;

	private bool bool_0;

	private IContainer icontainer_0;

	private GroupBox groupBox_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private Label label_0;

	private Label label_1;

	private Button button_0;

	private Button button_1;

	private Label label_2;

	private Label label_3;

	private ComboBox comboBox_0;

	private Label label_4;

	private ComboBox comboBox_1;

	private Label label_5;

	private Label label_6;

	private Label label_7;

	private TableLayoutPanel tableLayoutPanel_1;

	private ComboBox comboBox_2;

	private TextBox textBox_0;

	private TableLayoutPanel tableLayoutPanel_2;

	private Label label_8;

	private Button button_2;

	private Button button_3;

	private TableLayoutPanel tableLayoutPanel_3;

	private TableLayoutPanel tableLayoutPanel_4;

	private GroupBox groupBox_1;

	private TableLayoutPanel tableLayoutPanel_5;

	private TableLayoutPanel tableLayoutPanel_6;

	private TableLayoutPanel tableLayoutPanel_7;

	private CheckBox checkBox_0;

	private TableLayoutPanel tableLayoutPanel_8;

	private TableLayoutPanel tableLayoutPanel_9;

	private ComboBox comboBox_3;

	private TextBox textBox_1;

	private Label label_9;

	private CheckBox checkBox_1;

	public GForm3()
	{
		method_3();
		gclass8_0 = new GClass8((Keys)35, (Form)(object)this);
		gclass8_0.method_0();
		class27_0.WorkerSupportsCancellation = true;
		class27_0.DoWork += class27_0_DoWork;
		class27_1.WorkerSupportsCancellation = true;
		class27_1.DoWork += class27_1_DoWork;
		Control.set_CheckForIllegalCrossThreadCalls(false);
		struct7_0.method_1();
		struct6_0.method_1();
		((ListControl)comboBox_2).set_SelectedIndex(Settings.Default.ROWAR_HP_Percent);
		((Control)textBox_0).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.ROWAR_HP_Hotkey + Class60.smethod_0(-2050195546));
		((ListControl)comboBox_3).set_SelectedIndex(Settings.Default.ROWAR_SP_Percent);
		((Control)textBox_1).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.ROWAR_SP_Hotkey + Class60.smethod_0(-2050195546));
		if (Settings.Default.ROWAR_Friend_List == null)
		{
			Settings.Default.ROWAR_Friend_List = new StringCollection();
		}
		((Control)label_8).set_Text(Settings.Default.ROWAR_Friend_List.Count.ToString());
	}

	[DllImport("User32.Dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage(IntPtr intptr_1, uint uint_0, int int_1, int int_2);

	private void method_0()
	{
		if (((Control)button_1).get_Enabled())
		{
			button_1.PerformClick();
		}
		else
		{
			button_0.PerformClick();
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 786)
		{
			method_0();
		}
		((Form)this).WndProc(ref m);
	}

	private async void GForm3_Load(object sender, EventArgs e)
	{
		try
		{
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
					foreach (KeyValuePair<string, int> item in struct6_0.method_0())
					{
						comboBox_1.get_Items().Add((object)item.Key);
					}
					foreach (KeyValuePair<string, int> item2 in struct7_0.method_0())
					{
						comboBox_0.get_Items().Add((object)item2.Key);
					}
					((ListControl)comboBox_1).set_SelectedIndex(0);
					((ListControl)comboBox_0).set_SelectedIndex(0);
					((Control)button_1).set_Enabled(true);
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
		}
		catch
		{
			((Control)button_1).set_Enabled(false);
			((Control)button_0).set_Enabled(false);
			Form val3 = new Form();
			val3.set_TopMost(true);
			MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050203472), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Form)this).Close();
		}
	}

	private async void button_1_Click(object sender, EventArgs e)
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
					gclass14_0.method_10(gclass12_0.MAX_ZOOM, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050224589));
					((Control)label_1).set_Text(gclass14_0.method_8(gclass12_0.NAME));
					((Control)label_2).set_Text(Class60.smethod_0(-2050197272));
					((Control)label_2).set_ForeColor(Color.Black);
					bool_0 = true;
				}
				else
				{
					((Control)label_2).set_Text(Class60.smethod_0(-2050197299));
					((Control)label_2).set_ForeColor(Color.DarkRed);
				}
			}
			gclass5_0 = await GClass6.smethod_8();
			if (gclass5_0 != null)
			{
				gclass12_0.amountPtr = 15;
				if (gclass14_0.method_9(gclass12_0.MONSTER_SMOKIE.ToString()) != 184)
				{
					gclass14_0.method_10(gclass12_0.MONSTER_SMOKIE, Class60.smethod_0(-2050205505), 184.ToString());
					if (gclass14_0.method_9(gclass12_0.MONSTER_HIDING) == 0)
					{
						Form val3 = new Form();
						val3.set_TopMost(true);
						MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050224636), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
						return;
					}
					gclass14_0.method_10(gclass12_0.MONSTER_HIDING, Class60.smethod_0(-2050205505), (gclass14_0.method_9(gclass12_0.MONSTER_HIDING) + 20).ToString());
				}
				((Control)button_1).set_Enabled(false);
				((Control)button_0).set_Enabled(true);
				((Control)comboBox_1).set_Enabled(false);
				((Control)comboBox_0).set_Enabled(false);
				((Control)comboBox_2).set_Enabled(false);
				((Control)textBox_0).set_Enabled(false);
				((Control)comboBox_3).set_Enabled(false);
				((Control)textBox_1).set_Enabled(false);
				((Control)checkBox_0).set_Enabled(false);
				((Control)checkBox_1).set_Enabled(false);
				((Control)button_2).set_Enabled(false);
				((Control)button_3).set_Enabled(false);
				class27_1.RunWorkerAsync();
				if (checkBox_1.get_Checked())
				{
					gclass14_0.method_11(gclass12_0.NO_DELAY_1, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050224705));
					gclass14_0.method_11(gclass12_0.NO_DELAY_2, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050224768));
				}
				else
				{
					gclass14_0.method_11(gclass12_0.NO_DELAY_1, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050224751));
					gclass14_0.method_11(gclass12_0.NO_DELAY_2, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050224798));
				}
				if (checkBox_0.get_Checked())
				{
					class27_0.RunWorkerAsync();
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
			if (class27_0.IsBusy)
			{
				class27_0.method_0();
				class27_0.Dispose();
			}
			if (class27_1.IsBusy)
			{
				class27_1.method_0();
				class27_1.Dispose();
			}
			Form val5 = new Form();
			val5.set_TopMost(true);
			MessageBox.Show((IWin32Window)val5, Class60.smethod_0(-2050195508), Class60.smethod_0(-2050195508), (MessageBoxButtons)0, (MessageBoxIcon)16);
			button_0.PerformClick();
			((Control)button_1).set_Enabled(true);
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (class27_0.IsBusy)
			{
				class27_0.method_0();
				class27_0.Dispose();
			}
			if (class27_1.IsBusy)
			{
				class27_1.method_0();
				class27_1.Dispose();
			}
			((Control)button_1).set_Enabled(true);
			((Control)button_0).set_Enabled(false);
			((Control)comboBox_1).set_Enabled(true);
			((Control)comboBox_0).set_Enabled(true);
			((Control)comboBox_2).set_Enabled(true);
			((Control)textBox_0).set_Enabled(true);
			((Control)comboBox_3).set_Enabled(true);
			((Control)textBox_1).set_Enabled(true);
			((Control)checkBox_0).set_Enabled(true);
			((Control)checkBox_1).set_Enabled(true);
			((Control)button_2).set_Enabled(true);
			((Control)button_3).set_Enabled(true);
			((Control)label_2).set_Text(Class60.smethod_0(-2050197272));
			((Control)label_2).set_ForeColor(Color.Black);
		}
		catch
		{
			if (class27_0.IsBusy)
			{
				class27_0.method_0();
				class27_0.Dispose();
			}
			if (class27_1.IsBusy)
			{
				class27_1.method_0();
				class27_1.Dispose();
			}
			Form val = new Form();
			val.set_TopMost(true);
			MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050195522), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Control)button_1).set_Enabled(false);
			((Control)button_0).set_Enabled(false);
		}
	}

	private void class27_0_DoWork(object sender, DoWorkEventArgs e)
	{
		int num = 0;
		int num2 = -1;
		int index = 0;
		List<string> list = gclass12_0.method_0();
		List<string> list2 = gclass12_0.method_1();
		List<string> list3 = gclass12_0.method_2();
		List<string> list4 = gclass12_0.method_3();
		List<string> list5 = Settings.Default.ROWAR_Friend_List.Cast<string>().ToList();
		while (!class27_0.CancellationPending)
		{
			if (num != gclass14_0.method_9(list[index]))
			{
				num2 = 0;
				foreach (string item in list2)
				{
					Class25 @class = new Class25();
					@class.int_0 = gclass14_0.method_9(list[num2]);
					if (@class.int_0 > 100000)
					{
						if (gclass14_0.method_9(item) == int.Parse(struct6_0.method_0().ElementAt(((ListControl)comboBox_1).get_SelectedIndex()).Value.ToString()))
						{
							if (!list5.Exists(@class.method_0))
							{
								num = @class.int_0;
								index = num2;
								break;
							}
						}
						else
						{
							((Control)label_2).set_Text(Class60.smethod_0(-2050195688));
							((Control)label_2).set_ForeColor(Color.DarkRed);
						}
					}
					else
					{
						((Control)label_2).set_Text(Class60.smethod_0(-2050195688));
						((Control)label_2).set_ForeColor(Color.DarkRed);
					}
					num2++;
				}
			}
			else if (num > 0)
			{
				if (num2 < list2.Count)
				{
					if (method_1(gclass14_0.method_9(list3[num2]), gclass14_0.method_9(list4[num2])))
					{
						((Control)label_2).set_Text(Class60.smethod_0(-2050227258));
						((Control)label_2).set_ForeColor(Color.LimeGreen);
						if (((ListControl)comboBox_0).get_SelectedIndex() != 4)
						{
							gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), num.ToString());
							gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct7_0.method_0().ElementAt(((ListControl)comboBox_0).get_SelectedIndex()).Value.ToString());
							gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
							gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
							if (((ListControl)comboBox_0).get_SelectedIndex() == 3)
							{
								Thread.Sleep(200);
							}
							else
							{
								Thread.Sleep(600);
							}
						}
						else
						{
							gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct7_0.method_0().ElementAt(((ListControl)comboBox_0).get_SelectedIndex()).Value.ToString());
							gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
							gclass14_0.method_10(gclass12_0.SKILL_FLOOR_X, Class60.smethod_0(-2050205505), gclass14_0.method_9(list3[num2]).ToString());
							gclass14_0.method_10(gclass12_0.SKILL_FLOOR_Y, Class60.smethod_0(-2050205505), gclass14_0.method_9(list4[num2]).ToString());
							gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205627));
							Thread.Sleep(200);
						}
					}
					else
					{
						((Control)label_2).set_Text(Class60.smethod_0(-2050195688));
						((Control)label_2).set_ForeColor(Color.DarkRed);
					}
				}
				else
				{
					num = 0;
					num2 = 0;
					((Control)label_2).set_Text(Class60.smethod_0(-2050195688));
					((Control)label_2).set_ForeColor(Color.DarkRed);
				}
			}
			if (class27_0.CancellationPending)
			{
				e.Cancel = true;
			}
			Thread.Sleep(200);
		}
	}

	private void class27_1_DoWork(object sender, DoWorkEventArgs e)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		while (!class27_1.CancellationPending)
		{
			num = gclass14_0.method_9(gclass12_0.HP);
			num2 = gclass14_0.method_9(gclass12_0.MAX_HP);
			num5 = gclass14_0.method_9(gclass12_0.MAX_SP);
			num4 = gclass14_0.method_9(gclass12_0.SP);
			num3 = ((num2 > 0) ? (num * 100 / num2) : 100);
			num6 = ((num5 > 0) ? (num4 * 100 / num5) : 100);
			if (num3 < 90 - Settings.Default.ROWAR_HP_Percent * 10)
			{
				method_2(Settings.Default.ROWAR_HP_Hotkey);
			}
			if (num6 < 90 - Settings.Default.ROWAR_SP_Percent * 10)
			{
				method_2(Settings.Default.ROWAR_SP_Hotkey);
			}
			Thread.Sleep(40);
		}
		if (class27_1.CancellationPending)
		{
			e.Cancel = true;
		}
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Class26 @class = new Class26();
			@class.int_0 = gclass14_0.method_9(gclass12_0.LOCK_MONSTER);
			if (@class.int_0 > 100000)
			{
				List<string> list = Settings.Default.ROWAR_Friend_List.Cast<string>().ToList();
				if (!list.Exists(@class.method_0))
				{
					if (!@class.int_0.Equals(gclass14_0.method_9(gclass12_0.CHAR_ID)))
					{
						Settings.Default.ROWAR_Friend_List.Add(@class.int_0.ToString());
						((SettingsBase)Settings.Default).Save();
						((Control)label_8).set_Text((list.Count + 1).ToString());
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
					MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050227283), Class60.smethod_0(-2050208686), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			else
			{
				Form val3 = new Form();
				val3.set_TopMost(true);
				MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050198554), Class60.smethod_0(-2050198623), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		catch
		{
			Form val4 = new Form();
			val4.set_TopMost(true);
			MessageBox.Show((IWin32Window)val4, Class60.smethod_0(-2050198602), Class60.smethod_0(-2050208686), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void button_3_Click(object sender, EventArgs e)
	{
		Settings.Default.ROWAR_Friend_List.Clear();
		((SettingsBase)Settings.Default).Save();
		((Control)label_8).set_Text(Class60.smethod_0(-2050205559));
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
			@default.ROWAR_HP_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
			((SettingsBase)Settings.Default).Save();
			e.set_SuppressKeyPress(true);
		}
		catch
		{
		}
	}

	private void textBox_1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)textBox_1).set_Text(string.Concat(Class60.smethod_0(-2050195538), e.get_KeyCode(), Class60.smethod_0(-2050195546)));
			Settings @default = Settings.Default;
			Keys keyCode = e.get_KeyCode();
			@default.ROWAR_SP_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
			((SettingsBase)Settings.Default).Save();
			e.set_SuppressKeyPress(true);
		}
		catch
		{
		}
	}

	private void GForm3_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			Settings.Default.ROWAR_HP_Percent = ((ListControl)comboBox_2).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
		catch
		{
		}
	}

	private void comboBox_3_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			Settings.Default.ROWAR_SP_Percent = ((ListControl)comboBox_3).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
		catch
		{
		}
	}

	private bool method_1(int int_1, int int_2)
	{
		int num = Math.Abs(int_1 - gclass14_0.method_9(gclass12_0.CHAR_X));
		if (num > 9)
		{
			return false;
		}
		int num2 = Math.Abs(int_2 - gclass14_0.method_9(gclass12_0.CHAR_Y));
		if (num2 > 9)
		{
			return false;
		}
		return true;
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox_0.get_Checked())
		{
			((Control)groupBox_1).set_Enabled(true);
		}
		else
		{
			((Control)groupBox_1).set_Enabled(false);
		}
	}

	private void method_2(string string_0)
	{
		PostMessage(intptr_0, 256u, dictionary_0[string_0], 0);
		Thread.Sleep(40);
		PostMessage(intptr_0, 257u, dictionary_0[string_0], 0);
		Thread.Sleep(40);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_3()
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
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected O, but got Unknown
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected O, but got Unknown
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected O, but got Unknown
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected O, but got Unknown
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected O, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected O, but got Unknown
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected O, but got Unknown
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected O, but got Unknown
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Expected O, but got Unknown
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected O, but got Unknown
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a72: Expected O, but got Unknown
		//IL_0b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Expected O, but got Unknown
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc2: Expected O, but got Unknown
		//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected O, but got Unknown
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7f: Expected O, but got Unknown
		//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9b: Expected O, but got Unknown
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d08: Expected O, but got Unknown
		//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e23: Expected O, but got Unknown
		//IL_0e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e93: Expected O, but got Unknown
		//IL_0eb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Expected O, but got Unknown
		//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed6: Expected O, but got Unknown
		//IL_0f2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f73: Expected O, but got Unknown
		//IL_0f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8f: Expected O, but got Unknown
		//IL_0ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1007: Expected O, but got Unknown
		//IL_10a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ab: Expected O, but got Unknown
		//IL_10bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c7: Expected O, but got Unknown
		//IL_11a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b3: Expected O, but got Unknown
		//IL_11c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cf: Expected O, but got Unknown
		//IL_11e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11eb: Expected O, but got Unknown
		//IL_11fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1207: Expected O, but got Unknown
		//IL_1259: Unknown result type (might be due to invalid IL or missing references)
		//IL_1263: Expected O, but got Unknown
		//IL_1317: Unknown result type (might be due to invalid IL or missing references)
		//IL_1321: Expected O, but got Unknown
		//IL_13a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b3: Expected O, but got Unknown
		//IL_146a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1474: Expected O, but got Unknown
		//IL_14ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f6: Expected O, but got Unknown
		//IL_1508: Unknown result type (might be due to invalid IL or missing references)
		//IL_1512: Expected O, but got Unknown
		//IL_1524: Unknown result type (might be due to invalid IL or missing references)
		//IL_152e: Expected O, but got Unknown
		//IL_15a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e7: Expected O, but got Unknown
		//IL_163a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1644: Expected O, but got Unknown
		//IL_1660: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1709: Expected O, but got Unknown
		//IL_1736: Unknown result type (might be due to invalid IL or missing references)
		//IL_17eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f5: Expected O, but got Unknown
		//IL_1822: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d1: Expected O, but got Unknown
		//IL_18ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3d: Expected O, but got Unknown
		//IL_1a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a59: Expected O, but got Unknown
		//IL_1ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af9: Expected O, but got Unknown
		//IL_1b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b56: Expected O, but got Unknown
		//IL_1bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfe: Expected O, but got Unknown
		//IL_1c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca4: Expected O, but got Unknown
		//IL_1cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8d: Expected O, but got Unknown
		//IL_1e7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e89: Expected O, but got Unknown
		//IL_1f38: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f42: Expected O, but got Unknown
		//IL_1fc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcd: Expected O, but got Unknown
		//IL_1fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe9: Expected O, but got Unknown
		//IL_202d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2037: Expected O, but got Unknown
		//IL_2049: Unknown result type (might be due to invalid IL or missing references)
		//IL_2053: Expected O, but got Unknown
		//IL_20d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e2: Expected O, but got Unknown
		//IL_20f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20fe: Expected O, but got Unknown
		//IL_2180: Unknown result type (might be due to invalid IL or missing references)
		//IL_218a: Expected O, but got Unknown
		//IL_21ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d8: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm3));
		groupBox_0 = new GroupBox();
		tableLayoutPanel_6 = new TableLayoutPanel();
		tableLayoutPanel_0 = new TableLayoutPanel();
		tableLayoutPanel_9 = new TableLayoutPanel();
		comboBox_3 = new ComboBox();
		textBox_1 = new TextBox();
		label_9 = new Label();
		label_0 = new Label();
		label_1 = new Label();
		label_6 = new Label();
		tableLayoutPanel_1 = new TableLayoutPanel();
		comboBox_2 = new ComboBox();
		textBox_0 = new TextBox();
		tableLayoutPanel_7 = new TableLayoutPanel();
		groupBox_1 = new GroupBox();
		tableLayoutPanel_5 = new TableLayoutPanel();
		label_4 = new Label();
		comboBox_0 = new ComboBox();
		label_5 = new Label();
		comboBox_1 = new ComboBox();
		tableLayoutPanel_2 = new TableLayoutPanel();
		label_8 = new Label();
		button_2 = new Button();
		button_3 = new Button();
		label_7 = new Label();
		checkBox_0 = new CheckBox();
		tableLayoutPanel_8 = new TableLayoutPanel();
		label_2 = new Label();
		label_3 = new Label();
		checkBox_1 = new CheckBox();
		button_0 = new Button();
		button_1 = new Button();
		tableLayoutPanel_3 = new TableLayoutPanel();
		tableLayoutPanel_4 = new TableLayoutPanel();
		((Control)groupBox_0).SuspendLayout();
		((Control)tableLayoutPanel_6).SuspendLayout();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((Control)tableLayoutPanel_9).SuspendLayout();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)tableLayoutPanel_7).SuspendLayout();
		((Control)groupBox_1).SuspendLayout();
		((Control)tableLayoutPanel_5).SuspendLayout();
		((Control)tableLayoutPanel_2).SuspendLayout();
		((Control)tableLayoutPanel_8).SuspendLayout();
		((Control)tableLayoutPanel_3).SuspendLayout();
		((Control)tableLayoutPanel_4).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox_0).get_Controls().Add((Control)(object)tableLayoutPanel_6);
		((Control)groupBox_0).set_Dock((DockStyle)5);
		((Control)groupBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5));
		((Control)groupBox_0).set_ForeColor(SystemColors.Control);
		((Control)groupBox_0).set_Location(new Point(3, 3));
		((Control)groupBox_0).set_Name(Class60.smethod_0(-2050210886));
		((Control)groupBox_0).set_Size(new Size(328, 308));
		((Control)groupBox_0).set_TabIndex(0);
		groupBox_0.set_TabStop(false);
		((Control)groupBox_0).set_Text(Class60.smethod_0(-2050227302));
		tableLayoutPanel_6.set_ColumnCount(1);
		tableLayoutPanel_6.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_6.get_Controls().Add((Control)(object)tableLayoutPanel_0, 0, 0);
		tableLayoutPanel_6.get_Controls().Add((Control)(object)tableLayoutPanel_7, 0, 2);
		tableLayoutPanel_6.get_Controls().Add((Control)(object)tableLayoutPanel_8, 0, 3);
		tableLayoutPanel_6.get_Controls().Add((Control)(object)checkBox_1, 0, 1);
		((Control)tableLayoutPanel_6).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_6).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_6).set_Name(Class60.smethod_0(-2050200260));
		tableLayoutPanel_6.set_RowCount(4);
		tableLayoutPanel_6.get_RowStyles().Add(new RowStyle((SizeType)2, 35f));
		tableLayoutPanel_6.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		tableLayoutPanel_6.get_RowStyles().Add(new RowStyle((SizeType)2, 47f));
		tableLayoutPanel_6.get_RowStyles().Add(new RowStyle((SizeType)2, 8f));
		((Control)tableLayoutPanel_6).set_Size(new Size(322, 283));
		((Control)tableLayoutPanel_6).set_TabIndex(2);
		tableLayoutPanel_0.set_ColumnCount(2);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_9, 1, 2);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)label_9, 0, 2);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)label_0, 0, 0);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)label_1, 1, 0);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)label_6, 0, 1);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_1, 1, 1);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_0).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_0).set_Name(Class60.smethod_0(-2050208027));
		tableLayoutPanel_0.set_RowCount(3);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 30f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 35f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 35f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)tableLayoutPanel_0).set_Size(new Size(322, 99));
		((Control)tableLayoutPanel_0).set_TabIndex(1);
		tableLayoutPanel_9.set_ColumnCount(2);
		tableLayoutPanel_9.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_9.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_9.get_Controls().Add((Control)(object)comboBox_3, 0, 0);
		tableLayoutPanel_9.get_Controls().Add((Control)(object)textBox_1, 1, 0);
		((Control)tableLayoutPanel_9).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_9).set_Location(new Point(128, 63));
		((Control)tableLayoutPanel_9).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_9).set_Name(Class60.smethod_0(-2050198139));
		tableLayoutPanel_9.set_RowCount(1);
		tableLayoutPanel_9.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_9.get_RowStyles().Add(new RowStyle((SizeType)1, 36f));
		((Control)tableLayoutPanel_9).set_Size(new Size(194, 36));
		((Control)tableLayoutPanel_9).set_TabIndex(15);
		((Control)comboBox_3).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_3).set_Dock((DockStyle)5);
		comboBox_3.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1));
		((ListControl)comboBox_3).set_FormattingEnabled(true);
		comboBox_3.get_Items().AddRange(new object[6]
		{
			Class60.smethod_0(-2050195867),
			Class60.smethod_0(-2050195842),
			Class60.smethod_0(-2050195849),
			Class60.smethod_0(-2050195904),
			Class60.smethod_0(-2050195879),
			Class60.smethod_0(-2050195886)
		});
		((Control)comboBox_3).set_Location(new Point(2, 2));
		((Control)comboBox_3).set_Margin(new Padding(2));
		((Control)comboBox_3).set_Name(Class60.smethod_0(-2050195925));
		((Control)comboBox_3).set_Size(new Size(93, 27));
		((Control)comboBox_3).set_TabIndex(0);
		comboBox_3.add_SelectedIndexChanged((EventHandler)comboBox_3_SelectedIndexChanged);
		((Control)textBox_1).set_Cursor(Cursors.get_Default());
		((Control)textBox_1).set_Dock((DockStyle)5);
		((Control)textBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1));
		((Control)textBox_1).set_Location(new Point(99, 2));
		((Control)textBox_1).set_Margin(new Padding(2));
		((Control)textBox_1).set_Name(Class60.smethod_0(-2050195920));
		((Control)textBox_1).set_Size(new Size(93, 26));
		((Control)textBox_1).set_TabIndex(1);
		((Control)textBox_1).add_KeyDown(new KeyEventHandler(textBox_1_KeyDown));
		((Control)label_9).set_AutoSize(true);
		((Control)label_9).set_Dock((DockStyle)4);
		((Control)label_9).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_9).set_Location(new Point(15, 63));
		((Control)label_9).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label_9).set_Name(Class60.smethod_0(-2050207199));
		((Control)label_9).set_Size(new Size(111, 36));
		((Control)label_9).set_TabIndex(14);
		((Control)label_9).set_Text(Class60.smethod_0(-2050196215));
		label_9.set_TextAlign((ContentAlignment)64);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Dock((DockStyle)4);
		((Control)label_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_0).set_Location(new Point(18, 0));
		((Control)label_0).set_Name(Class60.smethod_0(-2050210999));
		((Control)label_0).set_Size(new Size(107, 29));
		((Control)label_0).set_TabIndex(9);
		((Control)label_0).set_Text(Class60.smethod_0(-2050195964));
		label_0.set_TextAlign((ContentAlignment)64);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Dock((DockStyle)5);
		((Control)label_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_Location(new Point(131, 0));
		((Control)label_1).set_Name(Class60.smethod_0(-2050195983));
		((Control)label_1).set_Size(new Size(188, 29));
		((Control)label_1).set_TabIndex(10);
		((Control)label_1).set_Text(Class60.smethod_0(-2050196032));
		label_1.set_TextAlign((ContentAlignment)16);
		((Control)label_6).set_AutoSize(true);
		((Control)label_6).set_Dock((DockStyle)4);
		((Control)label_6).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_6).set_Location(new Point(14, 29));
		((Control)label_6).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label_6).set_Name(Class60.smethod_0(-2050198190));
		((Control)label_6).set_Size(new Size(112, 34));
		((Control)label_6).set_TabIndex(11);
		((Control)label_6).set_Text(Class60.smethod_0(-2050196143));
		label_6.set_TextAlign((ContentAlignment)64);
		tableLayoutPanel_1.set_ColumnCount(2);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)comboBox_2, 0, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)textBox_0, 1, 0);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(128, 29));
		((Control)tableLayoutPanel_1).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050208091));
		tableLayoutPanel_1.set_RowCount(1);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)1, 34f));
		((Control)tableLayoutPanel_1).set_Size(new Size(194, 34));
		((Control)tableLayoutPanel_1).set_TabIndex(13);
		((Control)comboBox_2).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_2).set_Dock((DockStyle)5);
		comboBox_2.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1));
		((ListControl)comboBox_2).set_FormattingEnabled(true);
		comboBox_2.get_Items().AddRange(new object[6]
		{
			Class60.smethod_0(-2050195867),
			Class60.smethod_0(-2050195842),
			Class60.smethod_0(-2050195849),
			Class60.smethod_0(-2050195904),
			Class60.smethod_0(-2050195879),
			Class60.smethod_0(-2050195886)
		});
		((Control)comboBox_2).set_Location(new Point(2, 2));
		((Control)comboBox_2).set_Margin(new Padding(2));
		((Control)comboBox_2).set_Name(Class60.smethod_0(-2050196120));
		((Control)comboBox_2).set_Size(new Size(93, 27));
		((Control)comboBox_2).set_TabIndex(0);
		comboBox_2.add_SelectedIndexChanged((EventHandler)comboBox_2_SelectedIndexChanged);
		((Control)textBox_0).set_Cursor(Cursors.get_Default());
		((Control)textBox_0).set_Dock((DockStyle)5);
		((Control)textBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1));
		((Control)textBox_0).set_Location(new Point(99, 2));
		((Control)textBox_0).set_Margin(new Padding(2));
		((Control)textBox_0).set_Name(Class60.smethod_0(-2050196099));
		((Control)textBox_0).set_Size(new Size(93, 26));
		((Control)textBox_0).set_TabIndex(1);
		((Control)textBox_0).add_KeyDown(new KeyEventHandler(textBox_0_KeyDown));
		tableLayoutPanel_7.set_ColumnCount(2);
		tableLayoutPanel_7.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 10f));
		tableLayoutPanel_7.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 90f));
		tableLayoutPanel_7.get_Controls().Add((Control)(object)groupBox_1, 1, 0);
		tableLayoutPanel_7.get_Controls().Add((Control)(object)checkBox_0, 0, 0);
		((Control)tableLayoutPanel_7).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_7).set_Location(new Point(0, 127));
		((Control)tableLayoutPanel_7).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_7).set_Name(Class60.smethod_0(-2050198489));
		tableLayoutPanel_7.set_RowCount(1);
		tableLayoutPanel_7.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_7.get_RowStyles().Add(new RowStyle((SizeType)1, 133f));
		((Control)tableLayoutPanel_7).set_Size(new Size(322, 133));
		((Control)tableLayoutPanel_7).set_TabIndex(16);
		((Control)groupBox_1).get_Controls().Add((Control)(object)tableLayoutPanel_5);
		((Control)groupBox_1).set_Dock((DockStyle)5);
		((Control)groupBox_1).set_Enabled(false);
		((Control)groupBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox_1).set_ForeColor(SystemColors.Control);
		((Control)groupBox_1).set_Location(new Point(35, 3));
		((Control)groupBox_1).set_Name(Class60.smethod_0(-2050207223));
		((Control)groupBox_1).set_Size(new Size(284, 127));
		((Control)groupBox_1).set_TabIndex(15);
		groupBox_1.set_TabStop(false);
		((Control)groupBox_1).set_Text(Class60.smethod_0(-2050227381));
		tableLayoutPanel_5.set_ColumnCount(2);
		tableLayoutPanel_5.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_5.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_5.get_Controls().Add((Control)(object)label_4, 0, 0);
		tableLayoutPanel_5.get_Controls().Add((Control)(object)comboBox_0, 1, 0);
		tableLayoutPanel_5.get_Controls().Add((Control)(object)label_5, 0, 1);
		tableLayoutPanel_5.get_Controls().Add((Control)(object)comboBox_1, 1, 1);
		tableLayoutPanel_5.get_Controls().Add((Control)(object)tableLayoutPanel_2, 1, 2);
		tableLayoutPanel_5.get_Controls().Add((Control)(object)label_7, 0, 2);
		((Control)tableLayoutPanel_5).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_5).set_Location(new Point(3, 20));
		((Control)tableLayoutPanel_5).set_Name(Class60.smethod_0(-2050206985));
		tableLayoutPanel_5.set_RowCount(3);
		tableLayoutPanel_5.get_RowStyles().Add(new RowStyle((SizeType)2, 33f));
		tableLayoutPanel_5.get_RowStyles().Add(new RowStyle((SizeType)2, 33f));
		tableLayoutPanel_5.get_RowStyles().Add(new RowStyle((SizeType)2, 34f));
		tableLayoutPanel_5.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)tableLayoutPanel_5).set_Size(new Size(278, 104));
		((Control)tableLayoutPanel_5).set_TabIndex(0);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Dock((DockStyle)4);
		((Control)label_4).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_4).set_Location(new Point(52, 0));
		((Control)label_4).set_Name(Class60.smethod_0(-2050207156));
		((Control)label_4).set_Size(new Size(84, 34));
		((Control)label_4).set_TabIndex(6);
		((Control)label_4).set_Text(Class60.smethod_0(-2050227414));
		label_4.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_0).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_0).set_Dock((DockStyle)5);
		comboBox_0.set_DropDownStyle((ComboBoxStyle)2);
		comboBox_0.set_FlatStyle((FlatStyle)1);
		((Control)comboBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		((Control)comboBox_0).set_Location(new Point(142, 3));
		((Control)comboBox_0).set_Name(Class60.smethod_0(-2050227441));
		((Control)comboBox_0).set_Size(new Size(133, 24));
		((Control)comboBox_0).set_TabIndex(8);
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_Dock((DockStyle)4);
		((Control)label_5).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_5).set_Location(new Point(18, 34));
		((Control)label_5).set_Name(Class60.smethod_0(-2050210921));
		((Control)label_5).set_Size(new Size(118, 34));
		((Control)label_5).set_TabIndex(4);
		((Control)label_5).set_Text(Class60.smethod_0(-2050227437));
		label_5.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_1).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_1).set_Dock((DockStyle)5);
		comboBox_1.set_DropDownStyle((ComboBoxStyle)2);
		comboBox_1.set_FlatStyle((FlatStyle)1);
		((Control)comboBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_1).set_FormattingEnabled(true);
		((Control)comboBox_1).set_Location(new Point(142, 37));
		((Control)comboBox_1).set_Name(Class60.smethod_0(-2050227514));
		((Control)comboBox_1).set_Size(new Size(133, 24));
		((Control)comboBox_1).set_TabIndex(7);
		tableLayoutPanel_2.set_ColumnCount(3);
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_2.get_Controls().Add((Control)(object)label_8, 0, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)button_2, 1, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)button_3, 2, 0);
		((Control)tableLayoutPanel_2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_2).set_Location(new Point(141, 70));
		((Control)tableLayoutPanel_2).set_Margin(new Padding(2));
		((Control)tableLayoutPanel_2).set_Name(Class60.smethod_0(-2050211088));
		tableLayoutPanel_2.set_RowCount(1);
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_2).set_Size(new Size(135, 32));
		((Control)tableLayoutPanel_2).set_TabIndex(14);
		((Control)label_8).set_AutoSize(true);
		((Control)label_8).set_Dock((DockStyle)5);
		((Control)label_8).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_8).set_Location(new Point(2, 0));
		((Control)label_8).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label_8).set_Name(Class60.smethod_0(-2050227541));
		((Control)label_8).set_Size(new Size(23, 32));
		((Control)label_8).set_TabIndex(0);
		((Control)label_8).set_Text(Class60.smethod_0(-2050205559));
		label_8.set_TextAlign((ContentAlignment)16);
		((Control)button_2).set_Cursor(Cursors.get_Hand());
		((Control)button_2).set_Dock((DockStyle)5);
		((ButtonBase)button_2).set_FlatStyle((FlatStyle)0);
		((Control)button_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)button_2).set_ForeColor(Color.ForestGreen);
		((Control)button_2).set_Location(new Point(29, 0));
		((Control)button_2).set_Margin(new Padding(2, 0, 2, 0));
		((Control)button_2).set_Name(Class60.smethod_0(-2050227535));
		((Control)button_2).set_Size(new Size(50, 32));
		((Control)button_2).set_TabIndex(1);
		((Control)button_2).set_Text(Class60.smethod_0(-2050225268));
		((ButtonBase)button_2).set_UseVisualStyleBackColor(true);
		((Control)button_2).add_Click((EventHandler)button_2_Click);
		((Control)button_3).set_Cursor(Cursors.get_Hand());
		((Control)button_3).set_Dock((DockStyle)5);
		((ButtonBase)button_3).set_FlatStyle((FlatStyle)0);
		((Control)button_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)button_3).set_ForeColor(Color.IndianRed);
		((Control)button_3).set_Location(new Point(83, 0));
		((Control)button_3).set_Margin(new Padding(2, 0, 2, 0));
		((Control)button_3).set_Name(Class60.smethod_0(-2050227581));
		((Control)button_3).set_Size(new Size(50, 32));
		((Control)button_3).set_TabIndex(2);
		((Control)button_3).set_Text(Class60.smethod_0(-2050227565));
		((ButtonBase)button_3).set_UseVisualStyleBackColor(true);
		((Control)button_3).add_Click((EventHandler)button_3_Click);
		((Control)label_7).set_AutoSize(true);
		((Control)label_7).set_Dock((DockStyle)4);
		((Control)label_7).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_7).set_Location(new Point(8, 68));
		((Control)label_7).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label_7).set_Name(Class60.smethod_0(-2050202302));
		((Control)label_7).set_Size(new Size(129, 36));
		((Control)label_7).set_TabIndex(12);
		((Control)label_7).set_Text(Class60.smethod_0(-2050227614));
		label_7.set_TextAlign((ContentAlignment)64);
		((Control)checkBox_0).set_AutoSize(true);
		checkBox_0.set_CheckAlign((ContentAlignment)32);
		((Control)checkBox_0).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_0).set_Dock((DockStyle)1);
		((Control)checkBox_0).set_Location(new Point(3, 9));
		((Control)checkBox_0).set_Margin(new Padding(3, 9, 3, 3));
		((Control)checkBox_0).set_Name(Class60.smethod_0(-2050227667));
		((Control)checkBox_0).set_Size(new Size(26, 14));
		((Control)checkBox_0).set_TabIndex(16);
		((ButtonBase)checkBox_0).set_TextAlign((ContentAlignment)64);
		((ButtonBase)checkBox_0).set_UseVisualStyleBackColor(true);
		checkBox_0.add_CheckedChanged((EventHandler)checkBox_0_CheckedChanged);
		tableLayoutPanel_8.set_ColumnCount(2);
		tableLayoutPanel_8.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_8.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_8.get_Controls().Add((Control)(object)label_2, 1, 0);
		tableLayoutPanel_8.get_Controls().Add((Control)(object)label_3, 0, 0);
		((Control)tableLayoutPanel_8).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_8).set_Location(new Point(0, 260));
		((Control)tableLayoutPanel_8).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_8).set_Name(Class60.smethod_0(-2050198317));
		tableLayoutPanel_8.set_RowCount(1);
		tableLayoutPanel_8.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_8).set_Size(new Size(322, 23));
		((Control)tableLayoutPanel_8).set_TabIndex(17);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Dock((DockStyle)5);
		((Control)label_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_2).set_Location(new Point(131, 0));
		((Control)label_2).set_Name(Class60.smethod_0(-2050196003));
		((Control)label_2).set_Size(new Size(188, 23));
		((Control)label_2).set_TabIndex(1);
		((Control)label_2).set_Text(Class60.smethod_0(-2050196050));
		label_2.set_TextAlign((ContentAlignment)16);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Dock((DockStyle)4);
		((Control)label_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_3).set_Location(new Point(78, 0));
		((Control)label_3).set_Name(Class60.smethod_0(-2050208088));
		((Control)label_3).set_Size(new Size(47, 23));
		((Control)label_3).set_TabIndex(0);
		((Control)label_3).set_Text(Class60.smethod_0(-2050196093));
		label_3.set_TextAlign((ContentAlignment)64);
		((Control)checkBox_1).set_AutoSize(true);
		((Control)checkBox_1).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_1).set_Location(new Point(9, 102));
		((Control)checkBox_1).set_Margin(new Padding(9, 3, 3, 3));
		((Control)checkBox_1).set_Name(Class60.smethod_0(-2050227664));
		((Control)checkBox_1).set_Size(new Size(136, 20));
		((Control)checkBox_1).set_TabIndex(18);
		((Control)checkBox_1).set_Text(Class60.smethod_0(-2050227711));
		((ButtonBase)checkBox_1).set_UseVisualStyleBackColor(true);
		((Control)button_0).set_BackColor(Color.Salmon);
		((Control)button_0).set_Cursor(Cursors.get_Hand());
		((Control)button_0).set_Dock((DockStyle)5);
		((Control)button_0).set_Enabled(false);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)1);
		((Control)button_0).set_Font(new Font(Class60.smethod_0(-2050211150), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_0).set_ForeColor(SystemColors.Control);
		((Control)button_0).set_Location(new Point(167, 3));
		((Control)button_0).set_Name(Class60.smethod_0(-2050200316));
		((Control)button_0).set_Size(new Size(158, 35));
		((Control)button_0).set_TabIndex(3);
		((Control)button_0).set_Text(Class60.smethod_0(-2050200301));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)button_1).set_BackColor(Color.LightSeaGreen);
		((Control)button_1).set_Cursor(Cursors.get_Hand());
		((Control)button_1).set_Dock((DockStyle)5);
		((Control)button_1).set_Enabled(false);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)1);
		((Control)button_1).set_Font(new Font(Class60.smethod_0(-2050211150), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_1).set_ForeColor(SystemColors.Control);
		((Control)button_1).set_Location(new Point(3, 3));
		((Control)button_1).set_Name(Class60.smethod_0(-2050200350));
		((Control)button_1).set_Size(new Size(158, 35));
		((Control)button_1).set_TabIndex(2);
		((Control)button_1).set_Text(Class60.smethod_0(-2050227728));
		((ButtonBase)button_1).set_UseVisualStyleBackColor(false);
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		tableLayoutPanel_3.set_ColumnCount(1);
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_3.get_Controls().Add((Control)(object)groupBox_0, 0, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)tableLayoutPanel_4, 0, 1);
		((Control)tableLayoutPanel_3).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_3).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_3).set_Name(Class60.smethod_0(-2050211259));
		tableLayoutPanel_3.set_RowCount(2);
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 87f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 13f));
		((Control)tableLayoutPanel_3).set_Size(new Size(334, 361));
		((Control)tableLayoutPanel_3).set_TabIndex(1);
		tableLayoutPanel_4.set_ColumnCount(2);
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_4.get_Controls().Add((Control)(object)button_1, 0, 0);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)button_0, 1, 0);
		((Control)tableLayoutPanel_4).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_4).set_Location(new Point(3, 317));
		((Control)tableLayoutPanel_4).set_Name(Class60.smethod_0(-2050211375));
		tableLayoutPanel_4.set_RowCount(1);
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)tableLayoutPanel_4).set_Size(new Size(328, 41));
		((Control)tableLayoutPanel_4).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkSlateGray);
		((Form)this).set_ClientSize(new Size(334, 361));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel_3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(Class60.smethod_0(-2050208183)));
		((Control)this).set_MinimumSize(new Size(350, 400));
		((Control)this).set_Name(Class60.smethod_0(-2050227747));
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(Class60.smethod_0(-2050227795));
		((Form)this).add_FormClosing(new FormClosingEventHandler(GForm3_FormClosing));
		((Form)this).add_Load((EventHandler)GForm3_Load);
		((Control)groupBox_0).ResumeLayout(false);
		((Control)tableLayoutPanel_6).ResumeLayout(false);
		((Control)tableLayoutPanel_6).PerformLayout();
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((Control)tableLayoutPanel_0).PerformLayout();
		((Control)tableLayoutPanel_9).ResumeLayout(false);
		((Control)tableLayoutPanel_9).PerformLayout();
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)tableLayoutPanel_1).PerformLayout();
		((Control)tableLayoutPanel_7).ResumeLayout(false);
		((Control)tableLayoutPanel_7).PerformLayout();
		((Control)groupBox_1).ResumeLayout(false);
		((Control)tableLayoutPanel_5).ResumeLayout(false);
		((Control)tableLayoutPanel_5).PerformLayout();
		((Control)tableLayoutPanel_2).ResumeLayout(false);
		((Control)tableLayoutPanel_2).PerformLayout();
		((Control)tableLayoutPanel_8).ResumeLayout(false);
		((Control)tableLayoutPanel_8).PerformLayout();
		((Control)tableLayoutPanel_3).ResumeLayout(false);
		((Control)tableLayoutPanel_4).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
