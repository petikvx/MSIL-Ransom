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

public sealed class GForm11 : Form
{
	private sealed class Class63
	{
		public int int_0;

		public Func<int, bool> func_0;

		public Func<int, bool> func_1;

		internal bool method_0(int int_1)
		{
			return int_1 == int_0;
		}

		internal bool method_1(int int_1)
		{
			return int_1 == int_0;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct28 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm11 gform11_0;

		private TaskAwaiter<GClass5> taskAwaiter_0;

		private void MoveNext()
		{
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Expected O, but got Unknown
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d4: Expected O, but got Unknown
			//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0521: Unknown result type (might be due to invalid IL or missing references)
			//IL_0526: Unknown result type (might be due to invalid IL or missing references)
			//IL_0549: Expected O, but got Unknown
			//IL_0544: Unknown result type (might be due to invalid IL or missing references)
			int num = int_0;
			GForm11 gForm = gform11_0;
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
						goto IL_021b;
					}
					if (gForm.bool_1)
					{
						goto IL_01c8;
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
								gForm.gclass14_0.method_10(gForm.gclass12_0.MAX_ZOOM, Class60.smethod_0(-2050205505), 1145569280.ToString());
								((Control)gForm.label_1).set_Text(gForm.gclass14_0.method_8(gForm.gclass12_0.NAME));
								((Control)gForm.label_2).set_Text(Class60.smethod_0(-2050197272));
								((Control)gForm.label_2).set_ForeColor(Color.Black);
								gForm.bool_1 = true;
							}
							else
							{
								((Control)gForm.label_2).set_Text(Class60.smethod_0(-2050197299));
								((Control)gForm.label_2).set_ForeColor(Color.DarkRed);
							}
							goto IL_01c8;
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
					IL_01c8:
					awaiter = GClass6.smethod_8().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_021b;
					IL_021b:
					GClass5 gClass = (gForm.gclass5_0 = awaiter.GetResult());
					if (gForm.gclass5_0 != null)
					{
						if (gForm.class64_0.IsBusy)
						{
							gForm.class64_0.method_0();
							gForm.class64_0.Dispose();
						}
						if (gForm.list_4.ToList().Count > 0)
						{
							gForm.list_4.Clear();
						}
						if (gForm.int_1 != null && gForm.int_1.Length != 0)
						{
							Array.Clear(gForm.int_1, 0, gForm.int_1.Length);
						}
						if (gForm.checkBox_2.get_Checked())
						{
							if (Settings.Default.ROLOOT_Item_List.Count > 0)
							{
								List<int> list = new List<int>();
								List<string>.Enumerator enumerator = Settings.Default.ROLOOT_Item_List.Cast<string>().ToList().GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										string current = enumerator.Current;
										list.Add(gForm.struct24_0.method_0().ElementAt(int.Parse(current)).Key);
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator).Dispose();
									}
								}
								gForm.int_1 = list.ToArray();
							}
							else
							{
								gForm.checkBox_2.set_Checked(false);
							}
						}
						gForm.list_0 = gForm.gclass12_0.method_8();
						gForm.list_1 = gForm.gclass12_0.method_9();
						gForm.list_2 = gForm.gclass12_0.method_10();
						gForm.list_3 = gForm.gclass12_0.method_11();
						GStruct4 gstruct4_ = default(GStruct4);
						GetWindowRect(gForm.intptr_0, ref gstruct4_);
						gForm.int_2 = gstruct4_.int_2 - gstruct4_.int_0;
						gForm.int_3 = gstruct4_.int_3 - gstruct4_.int_1;
						gForm.int_4 = gForm.int_2 / 2;
						gForm.int_5 = gForm.int_3 / 2;
						gForm.int_6 = gForm.int_4 - gForm.int_2 * 11 / 100;
						gForm.int_7 = gForm.int_4 + gForm.int_2 * 11 / 100;
						gForm.int_8 = gForm.int_5 - gForm.int_3 * 14 / 100;
						gForm.int_9 = gForm.int_5 + gForm.int_3 * 14 / 100;
						((Control)gForm.button_1).set_Enabled(false);
						((Control)gForm.button_0).set_Enabled(true);
						((Control)gForm.tableLayoutPanel_0).set_Enabled(false);
						if (!gForm.class64_1.IsBusy)
						{
							gForm.class64_1.RunWorkerAsync();
						}
						if (!gForm.class64_0.IsBusy)
						{
							gForm.class64_0.RunWorkerAsync();
						}
					}
					else
					{
						gForm.gclass12_0 = null;
						Form val3 = new Form();
						val3.set_TopMost(true);
						MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050197399), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
					}
					end_IL_000e:;
				}
				catch
				{
					if (gForm.class64_0.IsBusy)
					{
						gForm.class64_0.method_0();
						gForm.class64_0.Dispose();
					}
					if (gForm.class64_1.IsBusy)
					{
						gForm.class64_1.method_0();
						gForm.class64_1.Dispose();
					}
					Form val4 = new Form();
					val4.set_TopMost(true);
					MessageBox.Show((IWin32Window)val4, Class60.smethod_0(-2050195508), Class60.smethod_0(-2050195508), (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Control)gForm.button_1).set_Enabled(false);
					((Control)gForm.button_0).set_Enabled(false);
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
	private struct Struct29 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm11 gform11_0;

		private TaskAwaiter<GClass12> taskAwaiter_0;

		private TaskAwaiter<List<GClass0>> taskAwaiter_1;

		private void MoveNext()
		{
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_0338: Unknown result type (might be due to invalid IL or missing references)
			//IL_0342: Expected O, but got Unknown
			//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_040e: Expected O, but got Unknown
			//IL_0409: Unknown result type (might be due to invalid IL or missing references)
			//IL_042a: Unknown result type (might be due to invalid IL or missing references)
			//IL_042f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0452: Expected O, but got Unknown
			//IL_044d: Unknown result type (might be due to invalid IL or missing references)
			int num = int_0;
			GForm11 gForm = gform11_0;
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
						goto IL_00e8;
					}
					TaskAwaiter<List<GClass0>> awaiter2;
					if (num == 1)
					{
						awaiter2 = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<List<GClass0>>);
						num = -1;
						int_0 = -1;
						goto IL_0310;
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
						goto IL_00e8;
					}
					Form val = new Form();
					val.set_TopMost(true);
					MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050210429), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)gForm).Close();
					goto end_IL_000e;
					IL_0310:
					List<GClass0> result = awaiter2.GetResult();
					gForm.struct24_0.method_1(result);
					gForm.checkedListBox_0.set_DataSource((object)new BindingSource((object)gForm.struct24_0.method_0(), (string)null));
					gForm.checkedListBox_0.set_DisplayMember(Class60.smethod_0(-2050195496));
					gForm.checkedListBox_0.set_ValueMember(Class60.smethod_0(-2050195500));
					List<string> list = Settings.Default.ROLOOT_Item_List.Cast<string>().ToList();
					if (list != null && list.Count > 0)
					{
						List<string>.Enumerator enumerator = list.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								string current = enumerator.Current;
								gForm.checkedListBox_0.SetItemChecked(int.Parse(current), true);
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
					}
					gForm.bool_0 = false;
					((Control)gForm.button_1).set_Enabled(true);
					goto end_IL_000e;
					IL_00e8:
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
						if (Settings.Default.ROLOOT_Item_List == null)
						{
							Settings.Default.ROLOOT_Item_List = new StringCollection();
						}
						awaiter2 = GClass6.smethod_6().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter2;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0310;
					}
					Form val2 = new Form();
					val2.set_TopMost(true);
					MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050203423), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
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

	public struct GStruct4
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;
	}

	private sealed class Class64 : BackgroundWorker
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

	private Class64 class64_0 = new Class64();

	private Class64 class64_1 = new Class64();

	private Process[] process_0;

	private Class55.Struct24 struct24_0;

	private List<string> list_0;

	private List<string> list_1;

	private List<string> list_2;

	private List<string> list_3;

	private List<int> list_4 = new List<int>();

	private int int_0;

	private int[] int_1;

	private bool bool_0 = true;

	private bool bool_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private IContainer icontainer_0;

	private GroupBox groupBox_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private Label label_0;

	private Label label_1;

	private Button button_0;

	private Button button_1;

	private Label label_2;

	private Label label_3;

	private TableLayoutPanel tableLayoutPanel_1;

	private ComboBox comboBox_0;

	private TextBox textBox_0;

	private TableLayoutPanel tableLayoutPanel_2;

	private ComboBox comboBox_1;

	private TextBox textBox_1;

	private CheckBox checkBox_0;

	private CheckBox checkBox_1;

	private CheckBox checkBox_2;

	private CheckedListBox checkedListBox_0;

	private TableLayoutPanel tableLayoutPanel_3;

	private TableLayoutPanel tableLayoutPanel_4;

	private ComboBox comboBox_2;

	private Label label_4;

	public GForm11()
	{
		method_2();
		Control.set_CheckForIllegalCrossThreadCalls(false);
		class64_0.WorkerSupportsCancellation = true;
		class64_0.DoWork += class64_0_DoWork;
		class64_1.WorkerSupportsCancellation = true;
		class64_1.DoWork += class64_1_DoWork;
		((ListControl)comboBox_0).set_SelectedIndex(Settings.Default.ROLOOT_HP_Percent);
		((Control)textBox_0).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.ROLOOT_HP_Hotkey + Class60.smethod_0(-2050195546));
		((ListControl)comboBox_1).set_SelectedIndex(Settings.Default.ROLOOT_SP_Percent);
		((Control)textBox_1).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.ROLOOT_SP_Hotkey + Class60.smethod_0(-2050195546));
		((ListControl)comboBox_2).set_SelectedIndex(Settings.Default.ROLOOT_Speed);
	}

	[DllImport("User32.Dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage(IntPtr intptr_1, uint uint_0, int int_10, int int_11);

	[DllImport("User32.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetWindowRect(IntPtr intptr_1, ref GStruct4 gstruct4_0);

	private async void GForm11_Load(object sender, EventArgs e)
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
					if (Settings.Default.ROLOOT_Item_List == null)
					{
						Settings.Default.ROLOOT_Item_List = new StringCollection();
					}
					List<GClass0> list = await GClass6.smethod_6();
					struct24_0.method_1(list);
					checkedListBox_0.set_DataSource((object)new BindingSource((object)struct24_0.method_0(), (string)null));
					checkedListBox_0.set_DisplayMember(Class60.smethod_0(-2050195496));
					checkedListBox_0.set_ValueMember(Class60.smethod_0(-2050195500));
					List<string> list2 = Settings.Default.ROLOOT_Item_List.Cast<string>().ToList();
					if (list2 != null && list2.Count > 0)
					{
						foreach (string item in list2)
						{
							checkedListBox_0.SetItemChecked(int.Parse(item), true);
						}
					}
					bool_0 = false;
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
			if (!bool_1)
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
					((Control)label_1).set_Text(gclass14_0.method_8(gclass12_0.NAME));
					((Control)label_2).set_Text(Class60.smethod_0(-2050197272));
					((Control)label_2).set_ForeColor(Color.Black);
					bool_1 = true;
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
				if (class64_0.IsBusy)
				{
					class64_0.method_0();
					class64_0.Dispose();
				}
				if (list_4.ToList().Count > 0)
				{
					list_4.Clear();
				}
				if (int_1 != null && int_1.Length != 0)
				{
					Array.Clear(int_1, 0, int_1.Length);
				}
				if (checkBox_2.get_Checked())
				{
					if (Settings.Default.ROLOOT_Item_List.Count > 0)
					{
						List<int> list = new List<int>();
						foreach (string item in Settings.Default.ROLOOT_Item_List.Cast<string>().ToList())
						{
							list.Add(struct24_0.method_0().ElementAt(int.Parse(item)).Key);
						}
						int_1 = list.ToArray();
					}
					else
					{
						checkBox_2.set_Checked(false);
					}
				}
				list_0 = gclass12_0.method_8();
				list_1 = gclass12_0.method_9();
				list_2 = gclass12_0.method_10();
				list_3 = gclass12_0.method_11();
				GStruct4 gstruct4_ = default(GStruct4);
				GetWindowRect(intptr_0, ref gstruct4_);
				int_2 = gstruct4_.int_2 - gstruct4_.int_0;
				int_3 = gstruct4_.int_3 - gstruct4_.int_1;
				int_4 = int_2 / 2;
				int_5 = int_3 / 2;
				int_6 = int_4 - int_2 * 11 / 100;
				int_7 = int_4 + int_2 * 11 / 100;
				int_8 = int_5 - int_3 * 14 / 100;
				int_9 = int_5 + int_3 * 14 / 100;
				((Control)button_1).set_Enabled(false);
				((Control)button_0).set_Enabled(true);
				((Control)tableLayoutPanel_0).set_Enabled(false);
				if (!class64_1.IsBusy)
				{
					class64_1.RunWorkerAsync();
				}
				if (!class64_0.IsBusy)
				{
					class64_0.RunWorkerAsync();
				}
			}
			else
			{
				gclass12_0 = null;
				Form val3 = new Form();
				val3.set_TopMost(true);
				MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050197399), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		catch
		{
			if (class64_0.IsBusy)
			{
				class64_0.method_0();
				class64_0.Dispose();
			}
			if (class64_1.IsBusy)
			{
				class64_1.method_0();
				class64_1.Dispose();
			}
			Form val4 = new Form();
			val4.set_TopMost(true);
			MessageBox.Show((IWin32Window)val4, Class60.smethod_0(-2050195508), Class60.smethod_0(-2050195508), (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Control)button_1).set_Enabled(false);
			((Control)button_0).set_Enabled(false);
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (class64_0.IsBusy)
			{
				class64_0.method_0();
				class64_0.Dispose();
				((Control)button_1).set_Enabled(true);
				((Control)button_0).set_Enabled(false);
				((Control)tableLayoutPanel_0).set_Enabled(true);
				((Control)label_2).set_Text(Class60.smethod_0(-2050197272));
				((Control)label_2).set_ForeColor(Color.Black);
			}
			if (class64_1.IsBusy)
			{
				class64_1.method_0();
				class64_1.Dispose();
			}
		}
		catch
		{
			if (class64_0.IsBusy)
			{
				class64_0.method_0();
				class64_0.Dispose();
			}
			if (class64_1.IsBusy)
			{
				class64_1.method_0();
				class64_1.Dispose();
			}
			Form val = new Form();
			val.set_TopMost(true);
			MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050195522), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Control)button_1).set_Enabled(false);
			((Control)button_0).set_Enabled(false);
		}
	}

	private void class64_0_DoWork(object sender, DoWorkEventArgs e)
	{
		int num = -1;
		while (!class64_0.CancellationPending)
		{
			if (num < 0)
			{
				if (list_4.ToList().Count > 0)
				{
					list_4.Clear();
				}
				method_1();
				num = ((list_4.ToList().Count <= 0) ? (-1) : (list_4.ToList().Count - 1));
			}
			if (num >= 0 && list_4.ToList().Count > 0 && gclass14_0.method_9(gclass12_0.ATTACK) == 0)
			{
				((Control)label_2).set_ForeColor(Color.LimeGreen);
				((Control)label_2).set_Text(Class60.smethod_0(-2050195667));
				gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), list_4[num--].ToString());
				gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
				if (((ListControl)comboBox_2).get_SelectedIndex() > 0)
				{
					Thread.Sleep(200);
				}
				else
				{
					Thread.Sleep(60);
				}
			}
			else
			{
				((Control)label_2).set_ForeColor(Color.DarkRed);
				((Control)label_2).set_Text(Class60.smethod_0(-2050195688));
			}
		}
		if (class64_0.CancellationPending)
		{
			e.Cancel = true;
		}
	}

	private void class64_1_DoWork(object sender, DoWorkEventArgs e)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		while (!class64_1.CancellationPending)
		{
			num = gclass14_0.method_9(gclass12_0.HP);
			num2 = gclass14_0.method_9(gclass12_0.MAX_HP);
			num5 = gclass14_0.method_9(gclass12_0.MAX_SP);
			num4 = gclass14_0.method_9(gclass12_0.SP);
			num3 = ((num2 > 0) ? (num * 100 / num2) : 100);
			num6 = ((num5 > 0) ? (num4 * 100 / num5) : 100);
			if (checkBox_0.get_Checked() && num3 < 90 - Settings.Default.ROLOOT_HP_Percent * 10)
			{
				method_0(Settings.Default.ROLOOT_HP_Hotkey);
			}
			if (checkBox_1.get_Checked() && num6 < 90 - Settings.Default.ROLOOT_SP_Percent * 10)
			{
				method_0(Settings.Default.ROLOOT_SP_Hotkey);
			}
			Thread.Sleep(100);
		}
		if (class64_1.CancellationPending)
		{
			e.Cancel = true;
		}
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			Settings.Default.ROLOOT_HP_Percent = ((ListControl)comboBox_0).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
		catch
		{
		}
	}

	private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			Settings.Default.ROLOOT_Speed = ((ListControl)comboBox_2).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
		}
		catch
		{
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
			@default.ROLOOT_HP_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
			((SettingsBase)Settings.Default).Save();
			e.set_SuppressKeyPress(true);
		}
		catch
		{
		}
	}

	private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			Settings.Default.ROLOOT_SP_Percent = ((ListControl)comboBox_1).get_SelectedIndex();
			((SettingsBase)Settings.Default).Save();
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
			@default.ROLOOT_SP_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
			((SettingsBase)Settings.Default).Save();
			e.set_SuppressKeyPress(true);
		}
		catch
		{
		}
	}

	private void GForm11_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void method_0(string string_0)
	{
		PostMessage(intptr_0, 256u, dictionary_0[string_0], 0);
		Thread.Sleep(40);
		PostMessage(intptr_0, 257u, dictionary_0[string_0], 0);
		Thread.Sleep(40);
	}

	private void checkedListBox_0_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		if (bool_0)
		{
			return;
		}
		try
		{
			if ((int)e.get_NewValue() == 1)
			{
				List<string> source = Settings.Default.ROLOOT_Item_List.Cast<string>().ToList();
				if (!source.Any(method_3))
				{
					Settings.Default.ROLOOT_Item_List.Add(Array.IndexOf(struct24_0.method_0().Keys.ToArray(), ((ListControl)checkedListBox_0).get_SelectedValue()).ToString());
				}
			}
			else
			{
				Settings.Default.ROLOOT_Item_List.Cast<string>().ToList();
				Array.IndexOf(struct24_0.method_0().Keys.ToArray(), ((ListControl)checkedListBox_0).get_SelectedValue()).ToString();
				Settings.Default.ROLOOT_Item_List.Remove(Array.IndexOf(struct24_0.method_0().Keys.ToArray(), ((ListControl)checkedListBox_0).get_SelectedValue()).ToString());
				Settings.Default.ROLOOT_Item_List.Cast<string>().ToList();
			}
			((SettingsBase)Settings.Default).Save();
		}
		catch
		{
		}
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox_0.get_Checked())
		{
			((Control)comboBox_0).set_Enabled(true);
			((Control)textBox_0).set_Enabled(true);
		}
		else
		{
			((Control)comboBox_0).set_Enabled(false);
			((Control)textBox_0).set_Enabled(false);
		}
	}

	private void checkBox_1_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox_1.get_Checked())
		{
			((Control)comboBox_1).set_Enabled(true);
			((Control)textBox_1).set_Enabled(true);
		}
		else
		{
			((Control)comboBox_1).set_Enabled(false);
			((Control)textBox_1).set_Enabled(false);
		}
	}

	private void checkBox_2_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox_2.get_Checked())
		{
			((Control)checkedListBox_0).set_Enabled(true);
		}
		else
		{
			((Control)checkedListBox_0).set_Enabled(false);
		}
	}

	private void method_1()
	{
		Class63 @class = new Class63();
		int num = 0;
		@class.int_0 = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		foreach (string item in list_1)
		{
			_ = item;
			num2 = gclass14_0.method_9(list_1[num].ToString());
			@class.int_0 = gclass14_0.method_9(list_0[num].ToString());
			num3 = gclass14_0.method_9(list_2[num].ToString());
			num4 = gclass14_0.method_9(list_3[num].ToString());
			if (num2 <= 4000 || num2 >= 4900)
			{
				if (struct24_0.method_0().ContainsKey(num2) && num3 > int_6 && num3 < int_7 && num4 > int_8 && num4 < int_9)
				{
					if (checkBox_2.get_Checked() && int_1.Length != 0)
					{
						if (int_1.Contains(num2) && @class.int_0 > 0 && @class.int_0 < 90000 && !list_4.ToList().Any(@class.method_0))
						{
							list_4.Add(@class.int_0);
						}
					}
					else if (@class.int_0 > 0 && @class.int_0 < 90000 && !list_4.ToList().Any(@class.method_1))
					{
						list_4.Add(@class.int_0);
					}
				}
				num++;
				continue;
			}
			list_4.Add(@class.int_0);
			break;
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

	private void method_2()
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
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected O, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected O, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected O, but got Unknown
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected O, but got Unknown
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected O, but got Unknown
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected O, but got Unknown
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected O, but got Unknown
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Expected O, but got Unknown
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Expected O, but got Unknown
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae1: Expected O, but got Unknown
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c22: Expected O, but got Unknown
		//IL_0c34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Expected O, but got Unknown
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Expected O, but got Unknown
		//IL_0cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfb: Expected O, but got Unknown
		//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d74: Expected O, but got Unknown
		//IL_0dfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8b: Expected O, but got Unknown
		//IL_0ea5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efb: Expected O, but got Unknown
		//IL_0f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f43: Expected O, but got Unknown
		//IL_1013: Unknown result type (might be due to invalid IL or missing references)
		//IL_101d: Expected O, but got Unknown
		//IL_10f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1103: Expected O, but got Unknown
		//IL_11d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11dc: Expected O, but got Unknown
		//IL_1248: Unknown result type (might be due to invalid IL or missing references)
		//IL_1252: Expected O, but got Unknown
		//IL_12ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b8: Expected O, but got Unknown
		//IL_13aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b4: Expected O, but got Unknown
		//IL_1463: Unknown result type (might be due to invalid IL or missing references)
		//IL_146d: Expected O, but got Unknown
		//IL_147f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1489: Expected O, but got Unknown
		//IL_150a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1514: Expected O, but got Unknown
		//IL_1526: Unknown result type (might be due to invalid IL or missing references)
		//IL_1530: Expected O, but got Unknown
		//IL_1574: Unknown result type (might be due to invalid IL or missing references)
		//IL_157e: Expected O, but got Unknown
		//IL_1590: Unknown result type (might be due to invalid IL or missing references)
		//IL_159a: Expected O, but got Unknown
		//IL_161f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1629: Expected O, but got Unknown
		//IL_163b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1645: Expected O, but got Unknown
		//IL_16c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d1: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171f: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm11));
		groupBox_0 = new GroupBox();
		tableLayoutPanel_0 = new TableLayoutPanel();
		comboBox_2 = new ComboBox();
		label_4 = new Label();
		tableLayoutPanel_2 = new TableLayoutPanel();
		comboBox_1 = new ComboBox();
		textBox_1 = new TextBox();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		label_3 = new Label();
		tableLayoutPanel_1 = new TableLayoutPanel();
		comboBox_0 = new ComboBox();
		textBox_0 = new TextBox();
		checkBox_0 = new CheckBox();
		checkBox_1 = new CheckBox();
		checkBox_2 = new CheckBox();
		checkedListBox_0 = new CheckedListBox();
		button_0 = new Button();
		button_1 = new Button();
		tableLayoutPanel_3 = new TableLayoutPanel();
		tableLayoutPanel_4 = new TableLayoutPanel();
		((Control)groupBox_0).SuspendLayout();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((Control)tableLayoutPanel_2).SuspendLayout();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)tableLayoutPanel_3).SuspendLayout();
		((Control)tableLayoutPanel_4).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox_0).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		((Control)groupBox_0).set_Dock((DockStyle)5);
		((Control)groupBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5));
		((Control)groupBox_0).set_ForeColor(SystemColors.Control);
		((Control)groupBox_0).set_Location(new Point(3, 3));
		((Control)groupBox_0).set_Name(Class60.smethod_0(-2050210886));
		((Control)groupBox_0).set_Size(new Size(358, 426));
		((Control)groupBox_0).set_TabIndex(1);
		groupBox_0.set_TabStop(false);
		((Control)groupBox_0).set_Text(Class60.smethod_0(-2050195719));
		tableLayoutPanel_0.set_ColumnCount(2);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 45f));
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 55f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)comboBox_2, 1, 5);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)label_4, 0, 5);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_2, 1, 3);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)label_0, 0, 1);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)label_1, 1, 1);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)label_2, 1, 6);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)label_3, 0, 6);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_1, 1, 2);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)checkBox_0, 0, 2);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)checkBox_1, 0, 3);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)checkBox_2, 0, 4);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)checkedListBox_0, 1, 4);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_0).set_Name(Class60.smethod_0(-2050208027));
		tableLayoutPanel_0.set_RowCount(7);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 1f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 7f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 8f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 8f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 60f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 8f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 8f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)tableLayoutPanel_0).set_Size(new Size(352, 401));
		((Control)tableLayoutPanel_0).set_TabIndex(1);
		((Control)comboBox_2).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_2).set_Dock((DockStyle)5);
		comboBox_2.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1));
		((ListControl)comboBox_2).set_FormattingEnabled(true);
		comboBox_2.get_Items().AddRange(new object[2]
		{
			Class60.smethod_0(-2050195754),
			Class60.smethod_0(-2050195803)
		});
		((Control)comboBox_2).set_Location(new Point(160, 338));
		((Control)comboBox_2).set_Margin(new Padding(2));
		((Control)comboBox_2).set_Name(Class60.smethod_0(-2050195790));
		((Control)comboBox_2).set_Size(new Size(190, 27));
		((Control)comboBox_2).set_TabIndex(2);
		comboBox_2.add_SelectedIndexChanged((EventHandler)comboBox_2_SelectedIndexChanged);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Dock((DockStyle)4);
		((Control)label_4).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_4).set_Location(new Point(79, 336));
		((Control)label_4).set_Name(Class60.smethod_0(-2050210921));
		((Control)label_4).set_Size(new Size(76, 32));
		((Control)label_4).set_TabIndex(19);
		((Control)label_4).set_Text(Class60.smethod_0(-2050195838));
		label_4.set_TextAlign((ContentAlignment)32);
		tableLayoutPanel_2.set_ColumnCount(2);
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_2.get_Controls().Add((Control)(object)comboBox_1, 0, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)textBox_1, 1, 0);
		((Control)tableLayoutPanel_2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_2).set_Location(new Point(158, 64));
		((Control)tableLayoutPanel_2).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_2).set_Name(Class60.smethod_0(-2050211088));
		tableLayoutPanel_2.set_RowCount(1);
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)1, 32f));
		((Control)tableLayoutPanel_2).set_Size(new Size(194, 32));
		((Control)tableLayoutPanel_2).set_TabIndex(14);
		((Control)comboBox_1).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_1).set_Dock((DockStyle)5);
		comboBox_1.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_1).set_Enabled(false);
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
		((Control)comboBox_1).set_Location(new Point(2, 2));
		((Control)comboBox_1).set_Margin(new Padding(2));
		((Control)comboBox_1).set_Name(Class60.smethod_0(-2050195925));
		((Control)comboBox_1).set_Size(new Size(93, 27));
		((Control)comboBox_1).set_TabIndex(0);
		comboBox_1.add_SelectedIndexChanged((EventHandler)comboBox_1_SelectedIndexChanged);
		((Control)textBox_1).set_Dock((DockStyle)5);
		((Control)textBox_1).set_Enabled(false);
		((Control)textBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1));
		((Control)textBox_1).set_Location(new Point(99, 2));
		((Control)textBox_1).set_Margin(new Padding(2));
		((Control)textBox_1).set_Name(Class60.smethod_0(-2050195920));
		((Control)textBox_1).set_Size(new Size(93, 26));
		((Control)textBox_1).set_TabIndex(1);
		((Control)textBox_1).add_KeyDown(new KeyEventHandler(textBox_1_KeyDown));
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Dock((DockStyle)5);
		((Control)label_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_0).set_Location(new Point(3, 4));
		((Control)label_0).set_Name(Class60.smethod_0(-2050210999));
		((Control)label_0).set_Size(new Size(152, 28));
		((Control)label_0).set_TabIndex(9);
		((Control)label_0).set_Text(Class60.smethod_0(-2050195964));
		label_0.set_TextAlign((ContentAlignment)64);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Dock((DockStyle)5);
		((Control)label_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_Location(new Point(161, 4));
		((Control)label_1).set_Name(Class60.smethod_0(-2050195983));
		((Control)label_1).set_Size(new Size(188, 28));
		((Control)label_1).set_TabIndex(10);
		((Control)label_1).set_Text(Class60.smethod_0(-2050196032));
		label_1.set_TextAlign((ContentAlignment)16);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Dock((DockStyle)5);
		((Control)label_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_2).set_Location(new Point(161, 368));
		((Control)label_2).set_Name(Class60.smethod_0(-2050196003));
		((Control)label_2).set_Size(new Size(188, 33));
		((Control)label_2).set_TabIndex(1);
		((Control)label_2).set_Text(Class60.smethod_0(-2050196050));
		label_2.set_TextAlign((ContentAlignment)16);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Dock((DockStyle)4);
		((Control)label_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_3).set_Location(new Point(108, 368));
		((Control)label_3).set_Name(Class60.smethod_0(-2050208088));
		((Control)label_3).set_Size(new Size(47, 33));
		((Control)label_3).set_TabIndex(0);
		((Control)label_3).set_Text(Class60.smethod_0(-2050196093));
		label_3.set_TextAlign((ContentAlignment)32);
		tableLayoutPanel_1.set_ColumnCount(2);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)comboBox_0, 0, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)textBox_0, 1, 0);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(158, 32));
		((Control)tableLayoutPanel_1).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050208091));
		tableLayoutPanel_1.set_RowCount(2);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)1, 34f));
		((Control)tableLayoutPanel_1).set_Size(new Size(194, 32));
		((Control)tableLayoutPanel_1).set_TabIndex(13);
		((Control)comboBox_0).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_0).set_Dock((DockStyle)5);
		comboBox_0.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_0).set_Enabled(false);
		((Control)comboBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1));
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		comboBox_0.get_Items().AddRange(new object[6]
		{
			Class60.smethod_0(-2050195867),
			Class60.smethod_0(-2050195842),
			Class60.smethod_0(-2050195849),
			Class60.smethod_0(-2050195904),
			Class60.smethod_0(-2050195879),
			Class60.smethod_0(-2050195886)
		});
		((Control)comboBox_0).set_Location(new Point(2, 2));
		((Control)comboBox_0).set_Margin(new Padding(2));
		((Control)comboBox_0).set_Name(Class60.smethod_0(-2050196120));
		((Control)comboBox_0).set_Size(new Size(93, 27));
		((Control)comboBox_0).set_TabIndex(0);
		comboBox_0.add_SelectedIndexChanged((EventHandler)comboBox_0_SelectedIndexChanged);
		((Control)textBox_0).set_Dock((DockStyle)5);
		((Control)textBox_0).set_Enabled(false);
		((Control)textBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1));
		((Control)textBox_0).set_Location(new Point(99, 2));
		((Control)textBox_0).set_Margin(new Padding(2));
		((Control)textBox_0).set_Name(Class60.smethod_0(-2050196099));
		((Control)textBox_0).set_Size(new Size(93, 26));
		((Control)textBox_0).set_TabIndex(1);
		((Control)textBox_0).add_KeyDown(new KeyEventHandler(textBox_0_KeyDown));
		((Control)checkBox_0).set_AutoSize(true);
		((Control)checkBox_0).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_0).set_Dock((DockStyle)4);
		((Control)checkBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_0).set_Location(new Point(24, 35));
		((Control)checkBox_0).set_Name(Class60.smethod_0(-2050196159));
		((Control)checkBox_0).set_Size(new Size(131, 26));
		((Control)checkBox_0).set_TabIndex(15);
		((Control)checkBox_0).set_Text(Class60.smethod_0(-2050196143));
		((ButtonBase)checkBox_0).set_TextAlign((ContentAlignment)64);
		((ButtonBase)checkBox_0).set_UseVisualStyleBackColor(true);
		checkBox_0.add_CheckedChanged((EventHandler)checkBox_0_CheckedChanged);
		((Control)checkBox_1).set_AutoSize(true);
		((Control)checkBox_1).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_1).set_Dock((DockStyle)4);
		((Control)checkBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_1).set_Location(new Point(25, 67));
		((Control)checkBox_1).set_Name(Class60.smethod_0(-2050196167));
		((Control)checkBox_1).set_Size(new Size(130, 26));
		((Control)checkBox_1).set_TabIndex(16);
		((Control)checkBox_1).set_Text(Class60.smethod_0(-2050196215));
		((ButtonBase)checkBox_1).set_TextAlign((ContentAlignment)64);
		((ButtonBase)checkBox_1).set_UseVisualStyleBackColor(true);
		checkBox_1.add_CheckedChanged((EventHandler)checkBox_1_CheckedChanged);
		((Control)checkBox_2).set_AutoSize(true);
		checkBox_2.set_CheckAlign((ContentAlignment)1);
		((Control)checkBox_2).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_2).set_Dock((DockStyle)4);
		((Control)checkBox_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_2).set_Location(new Point(6, 99));
		((Control)checkBox_2).set_Name(Class60.smethod_0(-2050196207));
		((Control)checkBox_2).set_Size(new Size(149, 234));
		((Control)checkBox_2).set_TabIndex(17);
		((Control)checkBox_2).set_Text(Class60.smethod_0(-2050196251));
		((ButtonBase)checkBox_2).set_TextAlign((ContentAlignment)4);
		((ButtonBase)checkBox_2).set_UseVisualStyleBackColor(true);
		checkBox_2.add_CheckedChanged((EventHandler)checkBox_2_CheckedChanged);
		checkedListBox_0.set_CheckOnClick(true);
		((Control)checkedListBox_0).set_Dock((DockStyle)5);
		((Control)checkedListBox_0).set_Enabled(false);
		((Control)checkedListBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)checkedListBox_0).set_FormattingEnabled(true);
		((Control)checkedListBox_0).set_Location(new Point(161, 99));
		((Control)checkedListBox_0).set_Name(Class60.smethod_0(-2050196312));
		((Control)checkedListBox_0).set_Size(new Size(188, 234));
		((Control)checkedListBox_0).set_TabIndex(18);
		checkedListBox_0.add_ItemCheck(new ItemCheckEventHandler(checkedListBox_0_ItemCheck));
		((Control)button_0).set_BackColor(Color.Salmon);
		((Control)button_0).set_Cursor(Cursors.get_Hand());
		((Control)button_0).set_Dock((DockStyle)5);
		((Control)button_0).set_Enabled(false);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)1);
		((Control)button_0).set_Font(new Font(Class60.smethod_0(-2050211150), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_0).set_ForeColor(SystemColors.Control);
		((Control)button_0).set_Location(new Point(182, 3));
		((Control)button_0).set_Name(Class60.smethod_0(-2050200316));
		((Control)button_0).set_Size(new Size(173, 37));
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
		((Control)button_1).set_Size(new Size(173, 37));
		((Control)button_1).set_TabIndex(2);
		((Control)button_1).set_Text(Class60.smethod_0(-2050200334));
		((ButtonBase)button_1).set_UseVisualStyleBackColor(false);
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		tableLayoutPanel_3.set_ColumnCount(1);
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tableLayoutPanel_3.get_Controls().Add((Control)(object)groupBox_0, 0, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)tableLayoutPanel_4, 0, 1);
		((Control)tableLayoutPanel_3).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_3).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_3).set_Name(Class60.smethod_0(-2050211259));
		tableLayoutPanel_3.set_RowCount(2);
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 90f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		((Control)tableLayoutPanel_3).set_Size(new Size(364, 481));
		((Control)tableLayoutPanel_3).set_TabIndex(2);
		tableLayoutPanel_4.set_ColumnCount(2);
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_4.get_Controls().Add((Control)(object)button_1, 0, 0);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)button_0, 1, 0);
		((Control)tableLayoutPanel_4).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_4).set_Location(new Point(3, 435));
		((Control)tableLayoutPanel_4).set_Name(Class60.smethod_0(-2050211375));
		tableLayoutPanel_4.set_RowCount(1);
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)tableLayoutPanel_4).set_Size(new Size(358, 43));
		((Control)tableLayoutPanel_4).set_TabIndex(2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkSlateGray);
		((Form)this).set_ClientSize(new Size(364, 481));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel_3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(Class60.smethod_0(-2050208183)));
		((Control)this).set_MinimumSize(new Size(300, 520));
		((Control)this).set_Name(Class60.smethod_0(-2050196294));
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(Class60.smethod_0(-2050196341));
		((Form)this).add_FormClosing(new FormClosingEventHandler(GForm11_FormClosing));
		((Form)this).add_Load((EventHandler)GForm11_Load);
		((Control)groupBox_0).ResumeLayout(false);
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((Control)tableLayoutPanel_0).PerformLayout();
		((Control)tableLayoutPanel_2).ResumeLayout(false);
		((Control)tableLayoutPanel_2).PerformLayout();
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)tableLayoutPanel_1).PerformLayout();
		((Control)tableLayoutPanel_3).ResumeLayout(false);
		((Control)tableLayoutPanel_4).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private bool method_3(string string_0)
	{
		return string_0 == Array.IndexOf(struct24_0.method_0().Keys.ToArray(), ((ListControl)checkedListBox_0).get_SelectedValue()).ToString();
	}
}
