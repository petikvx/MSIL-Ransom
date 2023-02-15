using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Newtonsoft.Json;
using UNIVERSALGAME.Properties;

public sealed class GForm7 : Form
{
	[Serializable]
	private sealed class Class43
	{
		public static readonly Class43 class43_0 = new Class43();

		public static Func<Class50, bool> func_0;

		public static Func<Class50, bool> func_1;

		public static Func<Class50, bool> func_2;

		public static Func<Class50, double> func_3;

		public static Func<Class50, double> func_4;

		public static Func<Class50, bool> func_5;

		public static Func<Class50, bool> func_6;

		public static Func<Class50, bool> func_7;

		internal bool method_0(Class50 class50_0)
		{
			return class50_0.method_2().Equals(obj: true);
		}

		internal bool method_1(Class50 class50_0)
		{
			return class50_0.method_2().Equals(obj: true);
		}

		internal bool method_2(Class50 class50_0)
		{
			return class50_0.method_2().Equals(obj: true);
		}

		internal double method_3(Class50 class50_0)
		{
			return class50_0.method_4();
		}

		internal double method_4(Class50 class50_0)
		{
			return class50_0.method_4();
		}

		internal bool method_5(Class50 class50_0)
		{
			return class50_0.method_2().Equals(obj: true);
		}

		internal bool method_6(Class50 class50_0)
		{
			return class50_0.method_2().Equals(obj: true);
		}

		internal bool method_7(Class50 class50_0)
		{
			return class50_0.method_2().Equals(obj: true);
		}
	}

	private sealed class Class44
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

	private sealed class Class45
	{
		public List<int> list_0;

		public int int_0;

		public int int_1;

		public List<int> list_1;

		public int int_2;

		public int int_3;

		public GForm7 gform7_0;

		public int int_4;

		public int int_5;

		public Predicate<int> predicate_0;

		public Func<int, bool> func_0;

		public Func<int, bool> func_1;

		public Func<int, bool> func_2;

		public Func<Class50, bool> func_3;

		public Func<Point, double> func_4;

		public Func<GClass7, double> func_5;

		internal bool method_0(int int_6)
		{
			return int_6.Equals(list_0[int_0]);
		}

		internal bool method_1(int int_6)
		{
			return int_6.Equals(int_1);
		}

		internal bool method_2(int int_6)
		{
			return int_6.Equals(int_1);
		}

		internal bool method_3(Class50 class50_0)
		{
			if (class50_0.method_0().Equals(list_1[int_0]))
			{
				if (!class50_0.method_2().Equals(obj: false))
				{
					return class50_0.method_0().Equals(int_2);
				}
				return true;
			}
			return false;
		}

		internal bool method_4(Class50 class50_0)
		{
			return class50_0.method_0().Equals(int_2);
		}

		internal bool method_5(int int_6)
		{
			return int_6 == int_3;
		}

		internal bool method_6(int int_6)
		{
			return int_6 == int_3;
		}

		internal bool method_7(int int_6)
		{
			return int_6 == int_3;
		}

		internal bool method_8(Class50 class50_0)
		{
			return class50_0.method_0() == int_3;
		}

		internal bool method_9(int int_6)
		{
			return int_6 == int_3;
		}

		internal bool method_10(int int_6)
		{
			return int_6 == int_3;
		}

		internal bool method_11(int int_6)
		{
			return int_6 == int_3;
		}

		internal bool method_12(int int_6)
		{
			return int_6.Equals(list_0[int_0]);
		}

		internal bool method_13(int int_6)
		{
			return int_6.Equals(gform7_0.list_11[0]);
		}

		internal double method_14(Point point_0)
		{
			return gform7_0.method_24(new Point(int_4, int_5), point_0);
		}

		internal double method_15(GClass7 gclass7_0)
		{
			return gform7_0.method_23(new GClass7(gform7_0.gclass14_0.method_9(gform7_0.gclass12_0.CHAR_X), gform7_0.gclass14_0.method_9(gform7_0.gclass12_0.CHAR_Y)), gclass7_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct20 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm7 gform7_0;

		private TaskAwaiter<GClass12> taskAwaiter_0;

		private TaskAwaiter<List<GClass0>> taskAwaiter_1;

		private TaskAwaiter<List<GClass3>> taskAwaiter_2;

		private void MoveNext()
		{
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Expected O, but got Unknown
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_049d: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c5: Expected O, but got Unknown
			//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
			int num = int_0;
			GForm7 gForm = gform7_0;
			try
			{
				try
				{
					TaskAwaiter<GClass12> awaiter3;
					TaskAwaiter<List<GClass0>> awaiter2;
					TaskAwaiter<List<GClass3>> awaiter;
					GClass12 gClass;
					Form val2;
					List<GClass0> result;
					switch (num)
					{
					default:
					{
						((Control)gForm).set_Text(((Control)gForm).get_Text() + gForm.string_0);
						if (gForm.gclass1_0 != null)
						{
							gForm.int_1 = Settings.Default.Server_Index;
							awaiter3 = GClass6.smethod_5(gForm.int_1).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = 0;
								int_0 = 0;
								taskAwaiter_0 = awaiter3;
								asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_00dc;
						}
						Form val = new Form();
						val.set_TopMost(true);
						MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050210429), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
						((Form)gForm).Close();
						goto end_IL_000e;
					}
					case 0:
						awaiter3 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<GClass12>);
						num = -1;
						int_0 = -1;
						goto IL_00dc;
					case 1:
						awaiter2 = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<List<GClass0>>);
						num = -1;
						int_0 = -1;
						goto IL_01d6;
					case 2:
						{
							awaiter = taskAwaiter_2;
							taskAwaiter_2 = default(TaskAwaiter<List<GClass3>>);
							num = -1;
							int_0 = -1;
							break;
						}
						IL_00dc:
						gClass = (gForm.gclass12_0 = awaiter3.GetResult());
						if (gForm.gclass12_0 != null)
						{
							gForm.gclass14_0.string_0 = gForm.gclass12_0.BASE_ADDRESS;
							gForm.gclass14_0.string_1 = gForm.gclass12_0.MAX_HP;
							gForm.gclass14_0.method_1(gForm.int_0);
							gForm.bool_0 = gForm.gclass14_0.method_5(gForm.gclass14_0.method_0(), 3);
							awaiter2 = GClass6.smethod_6().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 1;
								int_0 = 1;
								taskAwaiter_1 = awaiter2;
								asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_01d6;
						}
						val2 = new Form();
						val2.set_TopMost(true);
						MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050203423), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
						goto end_IL_000e;
						IL_01d6:
						result = awaiter2.GetResult();
						gForm.struct24_0.method_1(result);
						awaiter = GClass6.smethod_7().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 2;
							int_0 = 2;
							taskAwaiter_2 = awaiter;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					}
					List<GClass3> result2 = awaiter.GetResult();
					gForm.struct26_0.method_1(result2);
					gForm.struct23_0.method_1();
					gForm.timer_0 = new System.Timers.Timer(1000.0);
					gForm.timer_0.Enabled = true;
					gForm.timer_0.Elapsed += gForm.method_2;
					gForm.timer_0.Stop();
					gForm.class47_0.WorkerSupportsCancellation = true;
					gForm.class47_0.DoWork += gForm.method_0;
					gForm.class47_1.WorkerSupportsCancellation = true;
					gForm.class47_1.DoWork += gForm.method_1;
					((Control)gForm.button_1).set_Enabled(true);
					if (gForm.int_1 == 1 || gForm.int_1 == 2 || gForm.int_1 == 3 || gForm.int_1 == 5)
					{
						gForm.int_8 = 65537;
					}
					gForm.gcontrol1_0.gclass12_0 = gForm.gclass12_0;
					gForm.gcontrol1_0.gclass14_0 = gForm.gclass14_0;
					gForm.gcontrol0_0.gclass12_0 = gForm.gclass12_0;
					gForm.gcontrol0_0.gclass14_0 = gForm.gclass14_0;
					gForm.gcontrol0_0.int_1 = gForm.int_0;
					((Control)gForm.label_0).set_Text(gForm.gclass14_0.method_8(gForm.gclass12_0.NAME));
					((Control)gForm.label_2).set_Text(gForm.gclass14_0.method_9(gForm.gclass12_0.HP) + Class60.smethod_0(-2050205079) + gForm.gclass14_0.method_9(gForm.gclass12_0.MAX_HP));
					((Control)gForm.label_4).set_Text(gForm.gclass14_0.method_9(gForm.gclass12_0.SP) + Class60.smethod_0(-2050205079) + gForm.gclass14_0.method_9(gForm.gclass12_0.MAX_SP));
					GStruct3 gstruct3_ = default(GStruct3);
					GetWindowRect(gForm.intptr_0, ref gstruct3_);
					gForm.int_9 = gstruct3_.int_2 - gstruct3_.int_0;
					gForm.int_10 = gstruct3_.int_3 - gstruct3_.int_1;
					gForm.int_11 = gForm.int_9 / 2;
					gForm.int_12 = gForm.int_10 / 2;
					gForm.method_19();
					end_IL_000e:;
				}
				catch
				{
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

	private sealed class Class46
	{
		public Point point_0;

		internal bool method_0(Point point_1)
		{
			if (point_1.X.Equals(point_0.X))
			{
				return point_1.Y.Equals(point_0.Y);
			}
			return false;
		}
	}

	private sealed class Class47 : BackgroundWorker
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

	private sealed class Class48
	{
		public int int_0;

		internal bool method_0(Class50 class50_0)
		{
			return class50_0.method_0().Equals(int_0);
		}
	}

	public struct GStruct3
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;
	}

	private sealed class Class49
	{
		public GClass7 gclass7_0;

		internal bool method_0(GClass7 gclass7_1)
		{
			if (gclass7_1.int_0.Equals(gclass7_0.int_0))
			{
				return gclass7_1.int_1.Equals(gclass7_0.int_1);
			}
			return false;
		}
	}

	private sealed class Class50
	{
		private int int_0;

		private bool bool_0;

		private double double_0;

		public int method_0()
		{
			return int_0;
		}

		public void method_1(int int_1)
		{
			int_0 = int_1;
		}

		public bool method_2()
		{
			return bool_0;
		}

		public void method_3(bool bool_1)
		{
			bool_0 = bool_1;
		}

		public double method_4()
		{
			return double_0;
		}

		public void method_5(double double_1)
		{
			double_0 = double_1;
		}
	}

	private sealed class Class51
	{
		public int int_0;

		public Func<Class50, bool> func_0;

		internal bool method_0(Class50 class50_0)
		{
			return class50_0.method_0() == int_0;
		}
	}

	private sealed class Class52
	{
		public int int_0;

		public Func<Class50, bool> func_0;

		public Func<Class50, bool> func_1;

		public Func<int, bool> func_2;

		public Func<int, bool> func_3;

		public Func<int, bool> func_4;

		public Func<Class50, bool> func_5;

		public Func<Class50, bool> func_6;

		public Func<int, bool> func_7;

		public Func<int, bool> func_8;

		public Func<int, bool> func_9;

		internal bool method_0(Class50 class50_0)
		{
			return class50_0.method_0() == int_0;
		}

		internal bool method_1(Class50 class50_0)
		{
			return class50_0.method_0() == int_0;
		}

		internal bool method_2(int int_1)
		{
			return int_1 == int_0;
		}

		internal bool method_3(int int_1)
		{
			return int_1 == int_0;
		}

		internal bool method_4(int int_1)
		{
			return int_1 == int_0;
		}

		internal bool method_5(Class50 class50_0)
		{
			return class50_0.method_0() == int_0;
		}

		internal bool method_6(Class50 class50_0)
		{
			return class50_0.method_0() == int_0;
		}

		internal bool method_7(int int_1)
		{
			return int_1 == int_0;
		}

		internal bool method_8(int int_1)
		{
			return int_1 == int_0;
		}

		internal bool method_9(int int_1)
		{
			return int_1 == int_0;
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

	public string string_0;

	public GClass1 gclass1_0;

	private GClass12 gclass12_0;

	public IntPtr intptr_0;

	private GClass14 gclass14_0 = new GClass14();

	public int int_0;

	public int int_1;

	private Class55.Struct25 struct25_0;

	private Class55.Struct27 struct27_0;

	private Class47 class47_0 = new Class47();

	private Class47 class47_1 = new Class47();

	private List<string> list_0;

	private List<string> list_1;

	private List<string> list_2;

	private List<string> list_3;

	private List<string> list_4;

	private List<string> list_5;

	private List<string> list_6;

	private List<string> list_7;

	private List<string> list_8;

	private List<string> list_9;

	private System.Timers.Timer timer_0;

	private Class55.Struct26 struct26_0;

	private Class55.Struct24 struct24_0;

	private Class55.Struct23 struct23_0;

	private List<Class50> list_10 = new List<Class50>();

	private List<int> list_11 = new List<int>();

	private List<int> list_12 = new List<int>();

	private bool bool_0;

	private string string_1;

	private int[] int_2;

	private int[] int_3;

	private int[] int_4;

	private int int_5 = 3;

	private int int_6;

	private int int_7;

	private int int_8 = 1;

	private int int_9;

	private int int_10;

	private int int_11;

	private int int_12;

	private int int_13;

	private int int_14;

	private int int_15;

	private int int_16;

	private int int_17;

	private int int_18;

	private int int_19;

	private int int_20;

	private int int_21;

	private int int_22;

	private int int_23;

	private int int_24;

	private int int_25;

	private int int_26;

	private int int_27;

	private int int_28;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private bool bool_6;

	private bool bool_7;

	private bool bool_8;

	private bool bool_9;

	private bool bool_10;

	private bool bool_11;

	private bool bool_12;

	private bool bool_13;

	private bool bool_14;

	private bool bool_15;

	private bool bool_16;

	private bool bool_17;

	private bool bool_18;

	private bool bool_19;

	private bool bool_20;

	private bool bool_21;

	private bool bool_22;

	private bool bool_23;

	private bool bool_24;

	private bool bool_25;

	private bool bool_26;

	private bool bool_27;

	private bool bool_28;

	private bool bool_29;

	private bool bool_30;

	private bool bool_31;

	private bool bool_32;

	private bool bool_33;

	private bool bool_34;

	private bool bool_35;

	private bool bool_36;

	private bool bool_37;

	private bool bool_38;

	private bool bool_39;

	private bool bool_40;

	private bool bool_41;

	private bool bool_42;

	private Point point_0;

	private List<Point> list_13;

	private List<GClass7> list_14;

	private SoundPlayer soundPlayer_0 = new SoundPlayer((Stream)Class41.smethod_8());

	private SoundPlayer soundPlayer_1 = new SoundPlayer((Stream)Class41.smethod_17());

	private SoundPlayer soundPlayer_2 = new SoundPlayer((Stream)Class41.smethod_20());

	private bool bool_43;

	private bool bool_44;

	private bool bool_45;

	private bool bool_46;

	private bool bool_47;

	private bool bool_48;

	private int int_29;

	private int int_30;

	private int int_31;

	private int int_32;

	private int int_33 = 5;

	private int int_34;

	private int int_35;

	private int int_36;

	private int int_37;

	private int int_38;

	private int int_39;

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private MenuStrip menuStrip_0;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private TableLayoutPanel tableLayoutPanel_1;

	private Button button_0;

	private Button button_1;

	private TableLayoutPanel tableLayoutPanel_2;

	private GroupBox groupBox_0;

	private TableLayoutPanel tableLayoutPanel_3;

	private CheckBox checkBox_0;

	private CheckBox checkBox_1;

	private CheckBox checkBox_2;

	private CheckBox checkBox_3;

	private CheckBox checkBox_4;

	private CheckBox checkBox_5;

	private CheckBox checkBox_6;

	private CheckBox checkBox_7;

	private CheckBox checkBox_8;

	private CheckBox checkBox_9;

	private CheckBox checkBox_10;

	private CheckBox checkBox_11;

	private CheckBox checkBox_12;

	private GControl5 gcontrol5_0;

	private GControl0 gcontrol0_0;

	private CheckBox checkBox_13;

	private CheckBox checkBox_14;

	private CheckBox checkBox_15;

	private CheckBox checkBox_16;

	private CheckBox checkBox_17;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private CheckBox checkBox_18;

	private CheckBox checkBox_19;

	private CheckBox checkBox_20;

	private CheckBox checkBox_21;

	private CheckBox checkBox_22;

	private CheckBox checkBox_23;

	private CheckBox checkBox_24;

	private CheckBox checkBox_25;

	private CheckBox checkBox_26;

	private CheckBox checkBox_27;

	private CheckBox checkBox_28;

	private CheckBox checkBox_29;

	private GroupBox groupBox_1;

	private TableLayoutPanel tableLayoutPanel_4;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private CheckBox checkBox_30;

	private GControl2 gcontrol2_0;

	private GControl4 gcontrol4_0;

	private GControl3 gcontrol3_0;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem toolStripMenuItem_5;

	private ToolStripMenuItem toolStripMenuItem_6;

	private ToolStripMenuItem toolStripMenuItem_7;

	private ToolStripMenuItem toolStripMenuItem_8;

	private ToolStripMenuItem toolStripMenuItem_9;

	private CheckBox checkBox_31;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private TabPage tabPage_1;

	private TabPage tabPage_2;

	private TabPage tabPage_3;

	private TabPage tabPage_4;

	private TabPage tabPage_5;

	private TabPage tabPage_6;

	private GControl1 gcontrol1_0;

	private ToolStripMenuItem toolStripMenuItem_10;

	private CheckBox checkBox_32;

	private CheckBox checkBox_33;

	private CheckBox checkBox_34;

	private CheckBox checkBox_35;

	private CheckBox checkBox_36;

	private CheckBox checkBox_37;

	private CheckBox checkBox_38;

	private CheckBox checkBox_39;

	private CheckBox checkBox_40;

	private CheckBox checkBox_41;

	private SaveFileDialog saveFileDialog_0;

	private OpenFileDialog openFileDialog_0;

	private ToolStripMenuItem toolStripMenuItem_11;

	private ToolStripMenuItem toolStripMenuItem_12;

	public GForm7()
	{
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		method_25();
		((Control)tabControl_0).set_Region(new Region(new RectangleF(((Control)tabPage_0).get_Left(), ((Control)tabPage_0).get_Top(), ((Control)tabPage_0).get_Width(), ((Control)tabPage_0).get_Height())));
		Control.set_CheckForIllegalCrossThreadCalls(false);
		gcontrol0_0.int_0 = 2;
		gcontrol5_0.int_0 = 2;
		gcontrol1_0.int_0 = 2;
	}

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	internal static extern IntPtr FindWindow(string string_2, string string_3);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool TerminateProcess(IntPtr intptr_1, uint uint_0);

	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(IntPtr intptr_1);

	[DllImport("User32.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetWindowRect(IntPtr intptr_1, ref GStruct3 gstruct3_0);

	[DllImport("User32.Dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage(IntPtr intptr_1, uint uint_0, int int_40, int int_41);

	private async void GForm7_Load(object sender, EventArgs e)
	{
		try
		{
			((Control)this).set_Text(((Control)this).get_Text() + string_0);
			if (gclass1_0 != null)
			{
				int_1 = Settings.Default.Server_Index;
				gclass12_0 = await GClass6.smethod_5(int_1);
				if (gclass12_0 != null)
				{
					gclass14_0.string_0 = gclass12_0.BASE_ADDRESS;
					gclass14_0.string_1 = gclass12_0.MAX_HP;
					gclass14_0.method_1(int_0);
					bool_0 = gclass14_0.method_5(gclass14_0.method_0(), 3);
					List<GClass0> list = await GClass6.smethod_6();
					struct24_0.method_1(list);
					List<GClass3> list2 = await GClass6.smethod_7();
					struct26_0.method_1(list2);
					struct23_0.method_1();
					timer_0 = new System.Timers.Timer(1000.0);
					timer_0.Enabled = true;
					timer_0.Elapsed += method_2;
					timer_0.Stop();
					class47_0.WorkerSupportsCancellation = true;
					class47_0.DoWork += method_0;
					class47_1.WorkerSupportsCancellation = true;
					class47_1.DoWork += method_1;
					((Control)button_1).set_Enabled(true);
					if (int_1 == 1 || int_1 == 2 || int_1 == 3 || int_1 == 5)
					{
						int_8 = 65537;
					}
					gcontrol1_0.gclass12_0 = gclass12_0;
					gcontrol1_0.gclass14_0 = gclass14_0;
					gcontrol0_0.gclass12_0 = gclass12_0;
					gcontrol0_0.gclass14_0 = gclass14_0;
					gcontrol0_0.int_1 = int_0;
					((Control)label_0).set_Text(gclass14_0.method_8(gclass12_0.NAME));
					((Control)label_2).set_Text(gclass14_0.method_9(gclass12_0.HP) + Class60.smethod_0(-2050205079) + gclass14_0.method_9(gclass12_0.MAX_HP));
					((Control)label_4).set_Text(gclass14_0.method_9(gclass12_0.SP) + Class60.smethod_0(-2050205079) + gclass14_0.method_9(gclass12_0.MAX_SP));
					GStruct3 gstruct3_ = default(GStruct3);
					GetWindowRect(intptr_0, ref gstruct3_);
					int_9 = gstruct3_.int_2 - gstruct3_.int_0;
					int_10 = gstruct3_.int_3 - gstruct3_.int_1;
					int_11 = int_9 / 2;
					int_12 = int_10 / 2;
					method_19();
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
			Form val3 = new Form();
			val3.set_TopMost(true);
			MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050203472), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Form)this).Close();
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected O, but got Unknown
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Expected O, but got Unknown
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected O, but got Unknown
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			bool_47 = false;
			bool_48 = false;
			bool_43 = false;
			bool_44 = false;
			bool_45 = false;
			bool_46 = false;
			int_36 = 0;
			int_37 = 0;
			int_38 = 0;
			int_39 = 0;
			((Control)label_0).set_Text(gclass14_0.method_8(gclass12_0.NAME));
			int_6 = gclass14_0.method_9(gclass12_0.CHAR_ID.ToString());
			int_17 = Settings.Default._3_AB_Freq + 1;
			int_18 = Settings.Default._3_ATK_Floor_Freq + 1;
			int_19 = Settings.Default._3_SKILLBUFF_1_Freq + 1;
			int_20 = Settings.Default._3_SKILLBUFF_2_Freq + 1;
			int_21 = Settings.Default._3_SKILLBUFF_3_Freq + 1;
			int_22 = Settings.Default._3_SKILLBUFF_4_Freq + 1;
			int_23 = Settings.Default._3_SKILLBUFF_5_Freq + 1;
			int_24 = Settings.Default._3_SKILLBUFF_6_Freq + 1;
			int_25 = Settings.Default._3_Macro1_Freq + 1;
			int_26 = Settings.Default._3_Macro2_Freq + 1;
			int_27 = Settings.Default._3_Macro3_Freq + 1;
			int_28 = Settings.Default._3_Macro4_Freq + 1;
			if (bool_0)
			{
				if (bool_4)
				{
					int_13 = int_11 - int_9 * 11 / 100;
					int_14 = int_11 + int_9 * 11 / 100;
					int_15 = int_12 - int_10 * 14 / 100;
					int_16 = int_12 + int_10 * 14 / 100;
				}
				else
				{
					int_13 = int_11 - int_9 * 49 / 100;
					int_14 = int_11 + int_9 * 49 / 100;
					int_15 = int_12 - int_10 * 49 / 100;
					int_16 = int_12 + int_10 * 49 / 100;
				}
				if (list_11.ToList().Count > 0)
				{
					list_11.Clear();
				}
				if (list_10.ToList().Count > 0)
				{
					list_10.Clear();
				}
				((Control)tableLayoutPanel_3).set_Enabled(false);
				((Control)button_1).set_Enabled(false);
				((Control)button_0).set_Enabled(true);
				if (class47_0.IsBusy)
				{
					class47_0.method_0();
					class47_0.Dispose();
				}
				list_0 = gclass12_0.method_0();
				list_1 = gclass12_0.method_1();
				list_2 = gclass12_0.method_2();
				list_3 = gclass12_0.method_3();
				list_4 = gclass12_0.method_6();
				list_5 = gclass12_0.method_8();
				list_6 = gclass12_0.method_9();
				list_7 = gclass12_0.method_10();
				list_8 = gclass12_0.method_11();
				list_9 = gclass12_0.method_7();
				if (int_2 != null && int_2.Length != 0)
				{
					Array.Clear(int_2, 0, int_2.Length);
				}
				if (int_3 != null && int_3.Length != 0)
				{
					Array.Clear(int_3, 0, int_3.Length);
				}
				if (int_4 != null && int_4.Length != 0)
				{
					Array.Clear(int_4, 0, int_4.Length);
				}
				if (bool_13)
				{
					if (Settings.Default.Monster_List.Count > 0)
					{
						List<int> list = new List<int>();
						foreach (string item in Settings.Default.Monster_List.Cast<string>().ToList())
						{
							list.Add(struct26_0.method_0().ElementAt(int.Parse(item)).Key);
						}
						int_2 = list.ToArray();
					}
					else
					{
						checkBox_14.set_Checked(false);
					}
				}
				if (bool_7)
				{
					if (Settings.Default.Monster_Escape_List.Count > 0)
					{
						List<int> list2 = new List<int>();
						foreach (string item2 in Settings.Default.Monster_Escape_List.Cast<string>().ToList())
						{
							list2.Add(struct26_0.method_0().ElementAt(int.Parse(item2)).Key);
						}
						int_3 = list2.ToArray();
					}
					else
					{
						checkBox_23.set_Checked(false);
					}
				}
				if (bool_3)
				{
					if (Settings.Default.Item_List.Count > 0)
					{
						List<int> list3 = new List<int>();
						foreach (string item3 in Settings.Default.Item_List.Cast<string>().ToList())
						{
							list3.Add(struct24_0.method_0().ElementAt(int.Parse(item3)).Key);
						}
						int_4 = list3.ToArray();
					}
					else
					{
						checkBox_13.set_Checked(false);
					}
				}
				((Control)label_0).set_Text(gclass14_0.method_8(gclass12_0.NAME));
				string_1 = gclass14_0.method_8(gclass12_0.MAP_NAME);
				if (bool_24)
				{
					if (string.IsNullOrEmpty(Settings.Default._3_Path_Map) || !File.Exists(Settings.Default._3_Path_Map))
					{
						Form val = new Form();
						val.set_TopMost(true);
						MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050205087), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
						((Control)tableLayoutPanel_3).set_Enabled(true);
						((Control)button_1).set_Enabled(true);
						((Control)button_0).set_Enabled(false);
						if (int_2 != null && int_2.Length != 0)
						{
							Array.Clear(int_2, 0, int_2.Length);
						}
						if (int_3 != null && int_3.Length != 0)
						{
							Array.Clear(int_3, 0, int_3.Length);
						}
						if (int_4 != null && int_4.Length != 0)
						{
							Array.Clear(int_4, 0, int_4.Length);
						}
						tabControl_0.set_SelectedIndex(3);
						return;
					}
					list_13 = struct27_0.method_1(Settings.Default._3_Path_Map);
					int_34 = list_13.Count();
				}
				else if (bool_23 && !struct27_0.method_2(string_1))
				{
					Form val2 = new Form();
					val2.set_TopMost(true);
					MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050205180), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
					checkBox_2.set_Checked(false);
					((Control)tableLayoutPanel_3).set_Enabled(true);
					((Control)button_1).set_Enabled(true);
					((Control)button_0).set_Enabled(false);
					if (int_2 != null && int_2.Length != 0)
					{
						Array.Clear(int_2, 0, int_2.Length);
					}
					if (int_3 != null && int_3.Length != 0)
					{
						Array.Clear(int_3, 0, int_3.Length);
					}
					if (int_4 != null && int_4.Length != 0)
					{
						Array.Clear(int_4, 0, int_4.Length);
					}
					tabControl_0.set_SelectedIndex(3);
					return;
				}
				method_20();
				if (!class47_0.IsBusy)
				{
					class47_0.RunWorkerAsync();
				}
				if (!class47_1.IsBusy)
				{
					class47_1.RunWorkerAsync();
				}
				timer_0.Start();
			}
			else
			{
				gclass12_0 = null;
				Form val3 = new Form();
				val3.set_TopMost(true);
				MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050205309), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		catch (Exception ex)
		{
			Form val4 = new Form();
			val4.set_TopMost(true);
			MessageBox.Show((IWin32Window)val4, Class60.smethod_0(-2050208456) + ex.ToString(), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
			bool_0 = false;
			((Control)tableLayoutPanel_3).set_Enabled(true);
			((Control)button_1).set_Enabled(true);
			((Control)button_0).set_Enabled(false);
			if (class47_1.IsBusy)
			{
				class47_1.method_0();
				class47_1.Dispose();
			}
			if (class47_0.IsBusy)
			{
				class47_0.method_0();
				class47_0.Dispose();
			}
			if (int_2 != null && int_2.Length != 0)
			{
				Array.Clear(int_2, 0, int_2.Length);
			}
			if (int_3 != null && int_3.Length != 0)
			{
				Array.Clear(int_3, 0, int_3.Length);
			}
			if (int_4 != null && int_4.Length != 0)
			{
				Array.Clear(int_4, 0, int_4.Length);
			}
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Invalid comparison between Unknown and I4
		try
		{
			timer_0.Stop();
			if (class47_0.IsBusy)
			{
				class47_0.method_0();
				class47_0.Dispose();
			}
			if (class47_1.IsBusy)
			{
				class47_1.method_0();
				class47_1.Dispose();
			}
			if (bool_47 || bool_48)
			{
				try
				{
					Process.GetProcessesByName(Class60.smethod_0(-2050204785))[0].Kill();
				}
				catch
				{
					TerminateProcess(intptr_0, 0u);
				}
			}
			if (int_2 != null && int_2.Length != 0)
			{
				Array.Clear(int_2, 0, int_2.Length);
			}
			if (int_3 != null && int_3.Length != 0)
			{
				Array.Clear(int_3, 0, int_3.Length);
			}
			if (int_4 != null && int_4.Length != 0)
			{
				Array.Clear(int_4, 0, int_4.Length);
			}
			((Control)tableLayoutPanel_3).set_Enabled(true);
			((Control)button_1).set_Enabled(true);
			((Control)button_0).set_Enabled(false);
		}
		catch
		{
			if (class47_1.IsBusy)
			{
				class47_1.method_0();
				class47_1.Dispose();
			}
			if (class47_0.IsBusy)
			{
				class47_0.method_0();
				class47_0.Dispose();
			}
			if (int_2 != null && int_2.Length != 0)
			{
				Array.Clear(int_2, 0, int_2.Length);
			}
			if (int_3 != null && int_3.Length != 0)
			{
				Array.Clear(int_3, 0, int_3.Length);
			}
			if (int_4 != null && int_4.Length != 0)
			{
				Array.Clear(int_4, 0, int_4.Length);
			}
			bool_0 = false;
			((Control)button_0).set_Enabled(false);
			if ((int)MessageBox.Show(Class60.smethod_0(-2050205414), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16, (MessageBoxDefaultButton)0) == 1)
			{
				((Control)tableLayoutPanel_3).set_Enabled(true);
				((Control)button_1).set_Enabled(true);
			}
		}
	}

	private void method_0(object sender, DoWorkEventArgs e)
	{
		Class45 @class = new Class45();
		@class.gform7_0 = this;
		if (list_11.ToList().Count > 0)
		{
			list_11.Clear();
		}
		if (list_10.ToList().Count > 0)
		{
			list_10.Clear();
		}
		bool flag = false;
		@class.list_1 = new List<int>();
		@class.list_0 = new List<int>();
		int num = 0;
		@class.int_3 = 0;
		@class.int_0 = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		@class.int_4 = 0;
		@class.int_5 = 0;
		int num11 = 0;
		int num12 = 0;
		@class.int_1 = 0;
		@class.int_2 = 0;
		while (!class47_0.CancellationPending)
		{
			if (bool_1)
			{
				num = method_8();
				if (num > 0)
				{
					if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
					{
						gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					if (gclass14_0.method_9(gclass12_0.ATTACK) > 0)
					{
						gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					if (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) == 1)
					{
						gclass14_0.method_10(gclass12_0.CHECK_ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					if (gclass14_0.method_9(gclass12_0.LOCK_MONSTER) > 0)
					{
						gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					list_11.Add(num);
					while (num > 0)
					{
						gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), num.ToString());
						gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
						Thread.Sleep(1000);
						num = method_8();
					}
				}
			}
			if (bool_9)
			{
				method_9();
			}
			if (bool_15 && method_6().Count > 0)
			{
				if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
				{
					gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
				}
				num5 = 0;
				if (bool_22)
				{
					int_30 = 0;
					while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
					{
						int_30++;
						gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
						gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205543));
						gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
						gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
						Thread.Sleep(400);
					}
					while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
					{
						method_3(Class60.smethod_0(-2050210591));
						Thread.Sleep(400);
					}
				}
				else
				{
					method_3(Settings.Default._3_Wing_Hotkey);
				}
				Thread.Sleep(800);
			}
			if (bool_2 || bool_3)
			{
				method_17();
				if (list_11.ToList().Count == 0 && @class.list_0.ToList().Count > 0)
				{
					@class.list_0.Clear();
				}
				if (@class.list_0.ToList().Count > 0)
				{
					@class.int_0 = 0;
					while (@class.int_0 < @class.list_0.ToList().Count && list_11.ToList().Count > 0)
					{
						list_11.RemoveAll(@class.method_0);
						@class.int_0++;
					}
				}
				num3 = gclass14_0.method_9(gclass12_0.CHECK_ATTACK);
				num4 = gclass14_0.method_9(gclass12_0.CHECK_WALKING);
				while (list_11.ToList().Count > 0 && num3 == 0 && num4 < 2)
				{
					if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
					{
						gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					num2 = gclass14_0.method_9(gclass12_0.ATTACK);
					num4 = gclass14_0.method_9(gclass12_0.CHECK_WALKING);
					if (@class.int_1 != list_11.Last())
					{
						List<int> list = method_6();
						if (list.Count == 2)
						{
							if (bool_15)
							{
								if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
								{
									gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
								}
								num5 = 0;
								if (bool_22)
								{
									int_30 = 0;
									while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
									{
										int_30++;
										gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
										gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205543));
										gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
										gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
										Thread.Sleep(400);
									}
									while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
									{
										method_3(Class60.smethod_0(-2050210591));
										Thread.Sleep(400);
									}
								}
								else
								{
									method_3(Settings.Default._3_Wing_Hotkey);
								}
								list_10.Clear();
								@class.list_1.Clear();
								num11 = list_11.Last();
								Thread.Sleep(800);
							}
							else
							{
								num11 = list[1];
							}
						}
						else
						{
							num11 = 0;
						}
						if (list_11.Last() != num11)
						{
							num9 = gclass14_0.method_9(gclass12_0.CHAR_X);
							num10 = gclass14_0.method_9(gclass12_0.CHAR_Y);
							gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), list_11.Last().ToString());
							gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
							Thread.Sleep(600);
							while (gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 1)
							{
								Thread.Sleep(600);
							}
						}
						@class.int_1 = list_11.Last();
						list_11.RemoveAll(@class.method_1);
						num12 = 0;
						continue;
					}
					num12++;
					if ((num12 <= 15 || num3 != 0) && (num12 <= 10 || num3 != 0 || gclass14_0.method_9(gclass12_0.CHAR_X) != num9 || gclass14_0.method_9(gclass12_0.CHAR_Y) != num10) && (num12 <= 30 || num3 != 1 || gclass14_0.method_9(gclass12_0.CHAR_X) == num9 || gclass14_0.method_9(gclass12_0.CHAR_Y) == num10))
					{
						if (num12 > 10 && num3 == 1 && num4 == 0)
						{
							if (gclass14_0.method_9(gclass12_0.ATTACK) > 0)
							{
								gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
							}
							if (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) == 1)
							{
								gclass14_0.method_10(gclass12_0.CHECK_ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
							}
							@class.int_1 = 0;
							num9 = gclass14_0.method_9(gclass12_0.CHAR_X);
							num10 = gclass14_0.method_9(gclass12_0.CHAR_Y);
						}
						else if (num12 > 5)
						{
							method_16();
							if (list_10.Any(Class43.class43_0.method_0))
							{
								break;
							}
						}
						Thread.Sleep(100);
						continue;
					}
					if (gclass14_0.method_9(gclass12_0.ATTACK) > 0)
					{
						gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					if (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) == 1)
					{
						gclass14_0.method_10(gclass12_0.CHECK_ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					if (gclass14_0.method_9(gclass12_0.LOCK_MONSTER) > 0)
					{
						gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					if (!@class.list_0.ToList().Any(@class.method_2))
					{
						@class.list_0.Add(@class.int_1);
					}
					@class.int_1 = 0;
					num12 = 0;
					list_11.Clear();
					break;
				}
				num12 = 0;
				@class.int_1 = 0;
			}
			if (!bool_14)
			{
				method_16();
				if (@class.list_1.ToList().Count > 0)
				{
					@class.int_0 = 0;
					while (@class.int_0 < @class.list_1.ToList().Count && list_10.ToList().Count > 0)
					{
						list_10.RemoveAll(@class.method_3);
						@class.int_0++;
					}
				}
				if (list_10.ToList().Count > 0)
				{
					@class.int_3 = 0;
					if (list_10.Any(Class43.class43_0.method_1))
					{
						@class.int_3 = list_10.Where(Class43.class43_0.method_2).OrderBy(Class43.class43_0.method_3).FirstOrDefault()!.method_0();
					}
					else
					{
						@class.int_3 = list_10.OrderBy(Class43.class43_0.method_4).FirstOrDefault()!.method_0();
					}
					if (@class.int_3 > 0)
					{
						num2 = gclass14_0.method_9(gclass12_0.ATTACK);
						num3 = gclass14_0.method_9(gclass12_0.CHECK_ATTACK);
						num4 = gclass14_0.method_9(gclass12_0.CHECK_WALKING);
						if (num3 == 0 && num2 == 0 && ((num4 < 2 && gclass14_0.method_9(gclass12_0.CHECK_SITDOWN) == 0) || (num4 > 30 && num4 < 100)) && (bool_33 || !list_10.Any(@class.method_4)))
						{
							List<int> list2 = method_6();
							if (list2.Count == 2)
							{
								if (bool_15)
								{
									if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
									{
										gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
									}
									num5 = 0;
									if (bool_22)
									{
										int_30 = 0;
										while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
										{
											int_30++;
											gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
											gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205543));
											gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
											gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
											Thread.Sleep(400);
										}
										while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
										{
											method_3(Class60.smethod_0(-2050210591));
											Thread.Sleep(400);
										}
									}
									else
									{
										method_3(Settings.Default._3_Wing_Hotkey);
									}
									list_10.Clear();
									@class.list_1.Clear();
									num11 = 0;
									@class.int_3 = 0;
									Thread.Sleep(800);
								}
								else
								{
									num11 = list2[1];
								}
							}
							else
							{
								num11 = 0;
							}
							if (!bool_6 && (bool_6 || list2.Count != 0) && (bool_6 || @class.int_3 == num11 || method_7(@class.int_3) || method_13(@class.int_3)))
							{
								if (!@class.list_1.ToList().Any(@class.method_7))
								{
									@class.list_1.Add(@class.int_3);
								}
							}
							else
							{
								if (bool_9)
								{
									method_9();
								}
								if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
								{
									gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
								}
								gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), @class.int_3.ToString());
								if (bool_33 && gclass14_0.method_9(gclass12_0.SP) * 100 / gclass14_0.method_9(gclass12_0.MAX_SP) > 5)
								{
									num6 = 0;
									gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Settings.Default._3_ATK_Skill_Lv.ToString());
									if (Settings.Default._3_ATK_Skill_Mode == 1 && !flag)
									{
										gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default._3_ATK_Skill.ToString());
										gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
										Thread.Sleep(600);
										while (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) == 0 && gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 1 && gclass14_0.method_9(gclass12_0.ATTACK) == 3)
										{
											num6++;
											if (num6 > 5)
											{
												break;
											}
											Thread.Sleep(600);
											method_16();
										}
										gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205590));
										flag = true;
										Thread.Sleep(200);
									}
									else
									{
										gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default._3_ATK_Skill.ToString());
										while (method_14(@class.int_3))
										{
											gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
											num6++;
											if (num6 > 5)
											{
												break;
											}
											Thread.Sleep(600);
											method_16();
										}
									}
								}
								else
								{
									gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205590));
								}
								Thread.Sleep(400);
								num3 = gclass14_0.method_9(gclass12_0.CHECK_ATTACK);
								num4 = gclass14_0.method_9(gclass12_0.CHECK_WALKING);
								if (num3 == 0 && num4 == 0 && gclass14_0.method_9(gclass12_0.CHECK_SITDOWN) == 0)
								{
									if (!@class.list_1.ToList().Any(@class.method_5))
									{
										@class.list_1.Add(@class.int_3);
									}
									gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
								}
								num6 = 0;
								while (method_14(@class.int_3) && ((num3 == 0 && num4 == 1) || (num3 == 1 && num4 == 2)))
								{
									num6++;
									if (bool_33)
									{
										if (!(Settings.Default._3_ATK_Skill_Mode == 1 && flag) && gclass14_0.method_9(gclass12_0.SP) * 100 / gclass14_0.method_9(gclass12_0.MAX_SP) > 5)
										{
											gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default._3_ATK_Skill.ToString());
											gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
										}
										else
										{
											gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205590));
										}
									}
									if (num3 == 0 && num4 == 1)
									{
										num6 = 0;
									}
									else if (num3 == 1 && num4 == 2 && num6 > 20)
									{
										num6 = 0;
										if (gclass14_0.method_9(gclass12_0.ATTACK) > 0)
										{
											gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
										}
										if (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) > 0)
										{
											gclass14_0.method_10(gclass12_0.CHECK_ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
										}
										if (!@class.list_1.ToList().Any(@class.method_6))
										{
											@class.list_1.Add(@class.int_3);
										}
										@class.int_2 = 0;
										break;
									}
									if (bool_23 && list_14 != null)
									{
										list_14 = struct27_0.method_3(gclass14_0.method_9(gclass12_0.CHAR_X), gclass14_0.method_9(gclass12_0.CHAR_Y));
									}
									Thread.Sleep(600);
									method_16();
									if (@class.list_0.ToList().Count > 0)
									{
										@class.list_0.Clear();
									}
									num3 = gclass14_0.method_9(gclass12_0.CHECK_ATTACK);
									num4 = gclass14_0.method_9(gclass12_0.CHECK_WALKING);
								}
								if (flag)
								{
									flag = false;
								}
								@class.int_2 = @class.int_3;
								num5 = 0;
							}
							list_10.Remove(list_10.Where(@class.method_8).FirstOrDefault());
							num6 = 0;
							num7 = 0;
						}
						else
						{
							num6++;
							if (num3 == 0 && num4 == 0)
							{
								if (num6 > 1)
								{
									if (gclass14_0.method_9(gclass12_0.ATTACK) > 0)
									{
										gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
									}
									if (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) > 0)
									{
										gclass14_0.method_10(gclass12_0.CHECK_ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
									}
									if (!@class.list_1.ToList().Any(@class.method_9))
									{
										@class.list_1.Add(@class.int_3);
									}
									@class.int_2 = 0;
								}
							}
							else if (num3 == 1 && num4 == 0)
							{
								if (num6 > 4)
								{
									if (gclass14_0.method_9(gclass12_0.ATTACK) > 0)
									{
										gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
									}
									if (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) > 0)
									{
										gclass14_0.method_10(gclass12_0.CHECK_ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
									}
									if (!@class.list_1.ToList().Any(@class.method_10))
									{
										@class.list_1.Add(@class.int_3);
									}
									@class.int_2 = 0;
								}
							}
							else if (num3 == 0 && num4 == 1)
							{
								num6 = 0;
							}
							else if (num3 == 1 && num4 == 2 && num6 > 20)
							{
								num6 = 0;
								if (gclass14_0.method_9(gclass12_0.ATTACK) > 0)
								{
									gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
								}
								if (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) > 0)
								{
									gclass14_0.method_10(gclass12_0.CHECK_ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
								}
								if (!@class.list_1.ToList().Any(@class.method_11))
								{
									@class.list_1.Add(@class.int_3);
								}
								@class.int_2 = 0;
							}
						}
					}
				}
				else
				{
					num5++;
					if (num5 > 1)
					{
						if (bool_1 && method_8() > 0)
						{
							continue;
						}
						@class.int_2 = 0;
						if (bool_2 || bool_3)
						{
							method_17();
							if (@class.list_0.ToList().Count > 0)
							{
								@class.int_0 = 0;
								while (@class.int_0 < @class.list_0.ToList().Count && list_11.ToList().Count > 0)
								{
									list_11.RemoveAll(@class.method_12);
									@class.int_0++;
								}
							}
							while (list_11.ToList().Count > 0)
							{
								if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
								{
									gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
								}
								gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), list_11[0].ToString());
								gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
								Thread.Sleep(600);
								while (gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 1)
								{
									Thread.Sleep(600);
								}
								if (!@class.list_0.ToList().Any(@class.method_13))
								{
									@class.list_0.Add(list_11[0]);
								}
								list_11.RemoveAt(0);
							}
						}
						if ((bool_24 || bool_23) && (bool_21 || bool_22) && num7 > 15)
						{
							num7 = 0;
							if (bool_22)
							{
								int_30 = 0;
								while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
								{
									int_30++;
									gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
									gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205543));
									gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
									gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
									Thread.Sleep(400);
								}
								while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
								{
									method_3(Class60.smethod_0(-2050210591));
									Thread.Sleep(400);
								}
								num11 = 0;
								@class.int_3 = 0;
							}
							else
							{
								method_3(Settings.Default._3_Wing_Hotkey);
							}
							if (list_10.ToList().Count > 0)
							{
								list_10.Clear();
							}
							if (@class.list_1.ToList().Count > 0)
							{
								@class.list_1.Clear();
							}
							if (@class.list_0.ToList().Count > 0)
							{
								@class.list_0.Clear();
							}
							Thread.Sleep(800);
							num5 = 0;
						}
						else if (bool_24)
						{
							if (bool_21 || bool_22)
							{
								num7++;
							}
							if (list_13 != null && int_34 > 0)
							{
								Class46 class2 = new Class46();
								@class.int_4 = gclass14_0.method_9(gclass12_0.CHAR_X);
								@class.int_5 = gclass14_0.method_9(gclass12_0.CHAR_Y);
								class2.point_0 = list_13.OrderBy(@class.method_14).FirstOrDefault();
								int num13 = list_13.FindIndex(class2.method_0);
								if (num13 == -1)
								{
									continue;
								}
								num13 += int_33;
								if (num13 < int_34)
								{
									Point point = list_13[num13];
									if (point.X < @class.int_4 && point.Y > @class.int_5)
									{
										int_31 = Math.Abs(@class.int_4 - point.X);
										int_32 = Math.Abs(@class.int_5 - point.Y);
										if (int_31 < 4)
										{
											int_31 = 4;
										}
										if (int_32 < 4)
										{
											int_32 = 4;
										}
										int_31 *= 35;
										int_32 *= 35;
										if (int_31 > 60 * int_11 / 100)
										{
											int_31 = 60 * int_11 / 100;
										}
										if (int_32 > 60 * int_12 / 100)
										{
											int_32 = 60 * int_12 / 100;
										}
										point_0.X = int_11 - int_31;
										point_0.Y = int_12 - int_32;
									}
									else if (point.X == @class.int_4 && point.Y > @class.int_5)
									{
										int_31 = Math.Abs(@class.int_4 - point.X);
										int_32 = Math.Abs(@class.int_5 - point.Y);
										if (int_31 < 4)
										{
											int_31 = 4;
										}
										if (int_32 < 4)
										{
											int_32 = 4;
										}
										int_31 *= 35;
										int_32 *= 35;
										if (int_31 > 60 * int_11 / 100)
										{
											int_31 = 60 * int_11 / 100;
										}
										if (int_32 > 60 * int_12 / 100)
										{
											int_32 = 60 * int_12 / 100;
										}
										point_0.X = int_11 + int_31;
										point_0.Y = int_12 - int_32;
									}
									else if (point.X > @class.int_4 && point.Y > @class.int_5)
									{
										int_31 = Math.Abs(@class.int_4 - point.X);
										int_32 = Math.Abs(@class.int_5 - point.Y);
										if (int_31 < 4)
										{
											int_31 = 4;
										}
										if (int_32 < 4)
										{
											int_32 = 4;
										}
										int_31 *= 35;
										int_32 *= 35;
										if (int_31 > 60 * int_11 / 100)
										{
											int_31 = 60 * int_11 / 100;
										}
										if (int_32 > 60 * int_12 / 100)
										{
											int_32 = 60 * int_12 / 100;
										}
										point_0.X = int_11 + int_31;
										point_0.Y = int_12 - int_32;
									}
									else if (point.X > @class.int_4 && point.Y == @class.int_5)
									{
										int_31 = Math.Abs(@class.int_4 - point.X);
										int_32 = Math.Abs(@class.int_5 - point.Y);
										if (int_31 < 4)
										{
											int_31 = 4;
										}
										if (int_32 < 4)
										{
											int_32 = 4;
										}
										int_31 *= 35;
										int_32 *= 35;
										if (int_31 > 60 * int_11 / 100)
										{
											int_31 = 60 * int_11 / 100;
										}
										if (int_32 > 60 * int_12 / 100)
										{
											int_32 = 60 * int_12 / 100;
										}
										point_0.X = int_11 + int_31;
										point_0.Y = int_12 - int_32;
									}
									else if (point.X > @class.int_4 && point.Y < @class.int_5)
									{
										int_31 = Math.Abs(@class.int_4 - point.X);
										int_32 = Math.Abs(@class.int_5 - point.Y);
										if (int_31 < 4)
										{
											int_31 = 4;
										}
										if (int_32 < 4)
										{
											int_32 = 4;
										}
										int_31 *= 35;
										int_32 *= 35;
										if (int_31 > 60 * int_11 / 100)
										{
											int_31 = 60 * int_11 / 100;
										}
										if (int_32 > 60 * int_12 / 100)
										{
											int_32 = 60 * int_12 / 100;
										}
										point_0.X = int_11 + int_31;
										point_0.Y = int_12 + int_32;
									}
									else if (point.X == @class.int_4 && point.Y < @class.int_5)
									{
										int_31 = Math.Abs(@class.int_4 - point.X);
										int_32 = Math.Abs(@class.int_5 - point.Y);
										if (int_31 < 4)
										{
											int_31 = 4;
										}
										if (int_32 < 4)
										{
											int_32 = 4;
										}
										int_31 *= 35;
										int_32 *= 35;
										if (int_31 > 60 * int_11 / 100)
										{
											int_31 = 60 * int_11 / 100;
										}
										if (int_32 > 60 * int_12 / 100)
										{
											int_32 = 60 * int_12 / 100;
										}
										point_0.X = int_11 + int_31;
										point_0.Y = int_12 + int_32;
									}
									else if (point.X < @class.int_4 && point.Y < @class.int_5)
									{
										int_31 = Math.Abs(@class.int_4 - point.X);
										int_32 = Math.Abs(@class.int_5 - point.Y);
										if (int_31 < 4)
										{
											int_31 = 4;
										}
										if (int_32 < 4)
										{
											int_32 = 4;
										}
										int_31 *= 35;
										int_32 *= 35;
										if (int_31 > 60 * int_11 / 100)
										{
											int_31 = 60 * int_11 / 100;
										}
										if (int_32 > 60 * int_12 / 100)
										{
											int_32 = 60 * int_12 / 100;
										}
										point_0.X = int_11 - int_31;
										point_0.Y = int_12 + int_32;
									}
									else if (point.X < @class.int_4 && point.Y == @class.int_5)
									{
										int_31 = Math.Abs(@class.int_4 - point.X);
										int_32 = Math.Abs(@class.int_5 - point.Y);
										if (int_31 < 4)
										{
											int_31 = 4;
										}
										if (int_32 < 4)
										{
											int_32 = 4;
										}
										int_31 *= 35;
										int_32 *= 35;
										if (int_31 > 60 * int_11 / 100)
										{
											int_31 = 60 * int_11 / 100;
										}
										if (int_32 > 60 * int_12 / 100)
										{
											int_32 = 60 * int_12 / 100;
										}
										point_0.X = int_11 - int_31;
										point_0.Y = int_12 - int_32;
									}
									if (gclass14_0.method_9(gclass12_0.CHECK_MOUSE) == 0)
									{
										gclass14_0.method_10(gclass12_0.CHECK_MOUSE, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205598));
									}
									gclass14_0.method_10(gclass12_0.MOUSE_X, Class60.smethod_0(-2050205505), point_0.X.ToString());
									gclass14_0.method_10(gclass12_0.MOUSE_Y, Class60.smethod_0(-2050205505), point_0.Y.ToString());
									if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == 0)
									{
										gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), int_8.ToString());
									}
									Thread.Sleep(200);
								}
								if (gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 0)
								{
									int_29++;
									if (int_29 > 10)
									{
										if (bool_22)
										{
											int_30 = 0;
											while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
											{
												int_30++;
												gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
												gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205543));
												gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
												gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
												Thread.Sleep(400);
											}
											while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
											{
												method_3(Class60.smethod_0(-2050210591));
												Thread.Sleep(400);
											}
										}
										else if (bool_21)
										{
											method_3(Settings.Default._3_Wing_Hotkey);
										}
										Thread.Sleep(800);
										list_10.Clear();
										@class.list_1.Clear();
										num11 = 0;
										@class.int_3 = 0;
										int_29 = 0;
									}
									else if (int_29 > 5)
									{
										list_13 = struct27_0.method_0(Settings.Default._3_Path_Map);
									}
								}
								if (num13 > int_34 - 10)
								{
									list_13 = struct27_0.method_0(Settings.Default._3_Path_Map);
								}
								num9 = @class.int_4;
								num10 = @class.int_5;
								num5 = 0;
							}
						}
						else if (bool_23)
						{
							if (bool_21 || bool_22)
							{
								num7++;
							}
							if (list_14 == null)
							{
								list_14 = struct27_0.method_3(gclass14_0.method_9(gclass12_0.CHAR_X), gclass14_0.method_9(gclass12_0.CHAR_Y));
							}
							if (list_14 != null && list_14.Count() > 0)
							{
								Class49 class3 = new Class49();
								class3.gclass7_0 = list_14.OrderBy(@class.method_15).FirstOrDefault();
								int num14 = list_14.FindIndex(class3.method_0);
								if (num14 == -1)
								{
									continue;
								}
								num14 += 10;
								if (num14 < list_14.Count())
								{
									GClass7 gClass = list_14[num14];
									if (gclass14_0.method_9(gclass12_0.CHAR_TYPE) == 8)
									{
										gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205574));
									}
									else
									{
										gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205581));
									}
									gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
									gclass14_0.method_10(gclass12_0.SKILL_FLOOR_X, Class60.smethod_0(-2050205505), gClass.int_0.ToString());
									gclass14_0.method_10(gclass12_0.SKILL_FLOOR_Y, Class60.smethod_0(-2050205505), gClass.int_1.ToString());
									gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205627));
									if (num14 > list_14.Count() - 10)
									{
										list_14 = struct27_0.method_3(gClass.int_0, gClass.int_1);
									}
								}
								if (num8.Equals(num14) && gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 0)
								{
									list_14 = struct27_0.method_3(gclass14_0.method_9(gclass12_0.CHAR_X), gclass14_0.method_9(gclass12_0.CHAR_Y));
								}
								num8 = num14;
								num5 = 0;
							}
						}
						else if (bool_21)
						{
							method_3(Settings.Default._3_Wing_Hotkey);
							if (list_10.ToList().Count > 0)
							{
								list_10.Clear();
							}
							if (@class.list_1.ToList().Count > 0)
							{
								@class.list_1.Clear();
							}
							if (@class.list_0.ToList().Count > 0)
							{
								@class.list_0.Clear();
							}
							Thread.Sleep(800);
							num5 = 0;
						}
						else if (bool_22)
						{
							int_30 = 0;
							while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
							{
								int_30++;
								gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
								gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205543));
								gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
								gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
								Thread.Sleep(400);
							}
							while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
							{
								method_3(Class60.smethod_0(-2050210591));
								Thread.Sleep(400);
							}
							if (list_10.ToList().Count > 0)
							{
								list_10.Clear();
							}
							if (@class.list_1.ToList().Count > 0)
							{
								@class.list_1.Clear();
							}
							if (@class.list_0.ToList().Count > 0)
							{
								@class.list_0.Clear();
							}
							Thread.Sleep(800);
							num5 = 0;
						}
						else if (@class.list_1.ToList().Count > 0)
						{
							@class.list_1.Clear();
						}
					}
					else if (num5 > 0 && @class.list_1.ToList().Count > 0)
					{
						method_16();
						if (list_10.Count > 0)
						{
							using List<int>.Enumerator enumerator = @class.list_1.ToList().GetEnumerator();
							while (enumerator.MoveNext())
							{
								Class48 class4 = new Class48();
								class4.int_0 = enumerator.Current;
								if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
								{
									gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
								}
								if (list_10.Any(class4.method_0))
								{
									if (gclass14_0.method_9(gclass12_0.ATTACK) > 0)
									{
										gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
									}
									if (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) == 1)
									{
										gclass14_0.method_10(gclass12_0.CHECK_ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
									}
									gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), class4.int_0.ToString());
									if (bool_33 && gclass14_0.method_9(gclass12_0.SP) * 100 / gclass14_0.method_9(gclass12_0.MAX_SP) > 5)
									{
										num6 = 0;
										gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Settings.Default._3_ATK_Skill_Lv.ToString());
										if (Settings.Default._3_ATK_Skill_Mode == 1 && !flag)
										{
											gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default._3_ATK_Skill.ToString());
											gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
											Thread.Sleep(800);
											while (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) == 0 && gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 1)
											{
												num6++;
												if (num6 > 5)
												{
													break;
												}
												Thread.Sleep(400);
											}
											Thread.Sleep(600);
											gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205590));
											flag = true;
										}
										else
										{
											gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default._3_ATK_Skill.ToString());
											gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
											Thread.Sleep(800);
											while (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) == 0 && gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 1)
											{
												num6++;
												if (num6 > 5)
												{
													break;
												}
												Thread.Sleep(400);
											}
										}
									}
									else
									{
										gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205590));
									}
									Thread.Sleep(800);
									num3 = gclass14_0.method_9(gclass12_0.CHECK_ATTACK);
									num4 = gclass14_0.method_9(gclass12_0.CHECK_WALKING);
									int_7 = 0;
									while ((num3 == 0 && num4 == 1) || (num3 == 1 && num4 == 2))
									{
										int_7++;
										if (int_7 > 15)
										{
											break;
										}
										Thread.Sleep(600);
										num3 = gclass14_0.method_9(gclass12_0.CHECK_ATTACK);
										num4 = gclass14_0.method_9(gclass12_0.CHECK_WALKING);
									}
								}
								if (flag)
								{
									flag = false;
								}
							}
						}
						else if (@class.list_1.ToList().Count > 0)
						{
							@class.list_1.Clear();
						}
					}
				}
			}
			else if (int_18 >= Settings.Default._3_ATK_Floor_Freq + 1)
			{
				if (gclass14_0.method_9(gclass12_0.CHECK_WALKING) < 7)
				{
					Thread.Sleep(400);
					if (gclass14_0.method_9(gclass12_0.LOCK_MONSTER) > 0)
					{
						gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default._3_ATK_Floor_Skill.ToString());
					gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Settings.Default._3_ATK_Floor_Skill_Lv.ToString());
					if (Settings.Default._3_ATK_Floor_Skill_Mode.Equals(0))
					{
						gclass14_0.method_10(gclass12_0.SKILL_FLOOR_X, Class60.smethod_0(-2050205505), gclass14_0.method_9(gclass12_0.CHAR_X).ToString());
						gclass14_0.method_10(gclass12_0.SKILL_FLOOR_Y, Class60.smethod_0(-2050205505), gclass14_0.method_9(gclass12_0.CHAR_Y).ToString());
					}
					else
					{
						gclass14_0.method_10(gclass12_0.SKILL_FLOOR_X, Class60.smethod_0(-2050205505), Settings.Default._3_ATK_Floor_Skill_X.ToString());
						gclass14_0.method_10(gclass12_0.SKILL_FLOOR_Y, Class60.smethod_0(-2050205505), Settings.Default._3_ATK_Floor_Skill_Y.ToString());
					}
					gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205627));
					Thread.Sleep(400);
					while (gclass14_0.method_9(gclass12_0.CHECK_WALKING) > 0)
					{
						Thread.Sleep(600);
						int_18 = 0;
					}
				}
				else
				{
					int_18 = 0;
				}
			}
			method_18();
			if (class47_0.CancellationPending)
			{
				e.Cancel = true;
			}
			Thread.Sleep(400);
		}
	}

	private void method_1(object sender, DoWorkEventArgs e)
	{
		//IL_14b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b7: Invalid comparison between Unknown and I4
		//IL_1594: Unknown result type (might be due to invalid IL or missing references)
		//IL_159a: Invalid comparison between Unknown and I4
		bool_48 = false;
		bool_47 = false;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		int num14 = 0;
		while (!class47_1.CancellationPending)
		{
			num = gclass14_0.method_9(gclass12_0.HP);
			num6 = gclass14_0.method_9(gclass12_0.MAX_HP);
			num2 = gclass14_0.method_9(gclass12_0.SP);
			num7 = gclass14_0.method_9(gclass12_0.MAX_SP);
			num3 = ((num6 > 0) ? (num * 100 / num6) : 100);
			num4 = ((num7 > 0) ? (num2 * 100 / num7) : 100);
			((Control)label_4).set_Text(num2 + Class60.smethod_0(-2050205079) + num7);
			((Control)label_2).set_Text(num + Class60.smethod_0(-2050205079) + num6);
			if (bool_10 && num3 < Settings.Default._3_HP_Escape * 10 + 10)
			{
				method_3(Settings.Default._3_Wing_Hotkey);
				if (class47_0.IsBusy)
				{
					class47_0.method_0();
					class47_0.Dispose();
				}
				Thread.Sleep(800);
				if (!class47_0.IsBusy)
				{
					class47_0.RunWorkerAsync();
				}
			}
			if (bool_17)
			{
				if (num3 < Settings.Default._3_HP_Percent * 10 + 10)
				{
					method_3(Settings.Default._3_HP_Hotkey);
					if (bool_10)
					{
						int num15 = 0;
						while (num3 < Settings.Default._3_HP_Escape * 10 + 10 && num15 < 6)
						{
							if (num15 == 0)
							{
								method_3(Settings.Default._3_Wing_Hotkey);
								if (class47_0.IsBusy)
								{
									class47_0.method_0();
									class47_0.Dispose();
								}
								Thread.Sleep(800);
								if (!class47_0.IsBusy)
								{
									class47_0.RunWorkerAsync();
								}
							}
							else
							{
								method_3(Settings.Default._3_HP_Hotkey);
							}
							num = gclass14_0.method_9(gclass12_0.HP);
							num6 = gclass14_0.method_9(gclass12_0.MAX_HP);
							num3 = ((num6 > 0) ? (num * 100 / num6) : 100);
							Thread.Sleep(200);
							num15++;
						}
					}
					if (bool_16)
					{
						if (gclass14_0.method_9(gclass12_0.HP) <= num)
						{
							num9++;
							if (num9 > 5)
							{
								if (bool_22)
								{
									while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
									{
										method_3(Class60.smethod_0(-2050210591));
										Thread.Sleep(1000);
									}
								}
								flag3 = true;
								break;
							}
						}
						else
						{
							num9 = 0;
						}
					}
				}
			}
			else if (bool_18 && num3 < Settings.Default._3_HP_Percent * 10 + 10)
			{
				if (class47_0.IsBusy)
				{
					class47_0.method_0();
					class47_0.Dispose();
				}
				if (bool_22)
				{
					while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
					{
						method_3(Class60.smethod_0(-2050210591));
						Thread.Sleep(400);
					}
				}
				gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
				gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_0().ToString());
				gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
				gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
				method_16();
				Thread.Sleep(400);
				if (bool_10)
				{
					int num16 = 0;
					while (num3 < Settings.Default._3_HP_Escape * 10 + 10 && num16 < 5)
					{
						if (num16 == 0)
						{
							method_3(Settings.Default._3_Wing_Hotkey);
							Thread.Sleep(800);
						}
						else
						{
							gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
							gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_0().ToString());
							gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
							gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
							Thread.Sleep(400);
						}
						num = gclass14_0.method_9(gclass12_0.HP);
						num6 = gclass14_0.method_9(gclass12_0.MAX_HP);
						num3 = ((num6 > 0) ? (num * 100 / num6) : 100);
						Thread.Sleep(200);
						num16++;
					}
				}
				if (!class47_0.IsBusy)
				{
					class47_0.RunWorkerAsync();
				}
			}
			if (bool_20 && num4 < Settings.Default._3_SP_Percent * 10 + 10)
			{
				method_3(Settings.Default._3_SP_Hotkey);
				if (bool_19)
				{
					if (gclass14_0.method_9(gclass12_0.SP) <= num2)
					{
						num10++;
						if (num10 > 5)
						{
							if (bool_22)
							{
								while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
								{
									method_3(Class60.smethod_0(-2050210591));
									Thread.Sleep(1000);
								}
							}
							flag4 = true;
							break;
						}
					}
					else
					{
						num10 = 0;
					}
				}
			}
			if (bool_12)
			{
				num11 = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN);
				if (num11 == 0 && num4 < Settings.Default._3_SP_Sitdown * 10 + 10 && !flag2 && !list_10.Any(Class43.class43_0.method_5))
				{
					if (gclass14_0.method_9(gclass12_0.ATTACK) == 0 && gclass14_0.method_9(gclass12_0.CHECK_ATTACK) == 0)
					{
						if (class47_0.IsBusy)
						{
							class47_0.method_0();
							class47_0.Dispose();
						}
						if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
						{
							gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
						}
						Thread.Sleep(1000);
						if (bool_22)
						{
							while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
							{
								method_3(Class60.smethod_0(-2050210591));
								Thread.Sleep(400);
								num13 = 0;
								num12 = 0;
							}
						}
						Thread.Sleep(500);
						while (num11 == 0)
						{
							method_3(Class60.smethod_0(-2050210613));
							Thread.Sleep(1000);
							num11 = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN);
						}
						flag2 = true;
					}
				}
				else if (num11 == 0 && flag2)
				{
					flag2 = false;
					num13 = 0;
					num12 = 0;
					if (!class47_0.IsBusy)
					{
						class47_0.RunWorkerAsync();
					}
					timer_0.Start();
				}
				else if (num11 == 1 && num4 > 98 && flag2 && gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0)
				{
					while (num11 == 1)
					{
						method_3(Class60.smethod_0(-2050210613));
						Thread.Sleep(1000);
						num11 = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN);
					}
					num13 = 0;
					num12 = 0;
					flag2 = false;
					if (bool_22)
					{
						while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
						{
							method_3(Class60.smethod_0(-2050210591));
							Thread.Sleep(400);
						}
					}
					if (!class47_0.IsBusy)
					{
						class47_0.RunWorkerAsync();
					}
					timer_0.Start();
				}
				else if (num11 == 1 && flag2)
				{
					if (num12 == 0)
					{
						num13 = num2;
						num12++;
					}
					else if (num12 >= 50)
					{
						if (num13 == num2)
						{
							while (num11 == 1)
							{
								method_3(Class60.smethod_0(-2050210613));
								Thread.Sleep(1000);
								num11 = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN);
							}
							if (bool_22)
							{
								while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
								{
									method_3(Class60.smethod_0(-2050210591));
									Thread.Sleep(400);
								}
							}
							while (num11 == 0)
							{
								method_3(Class60.smethod_0(-2050210613));
								Thread.Sleep(1000);
								num11 = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN);
							}
							num13 = 0;
							num12 = 0;
						}
						else
						{
							num13 = 0;
							num12 = 0;
						}
					}
					else
					{
						num12++;
					}
				}
			}
			if (bool_11)
			{
				num11 = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN);
				if (num11 == 0 && num3 < Settings.Default._3_HP_Sitdown * 10 + 10 && !flag && !list_10.Any(Class43.class43_0.method_6))
				{
					if (gclass14_0.method_9(gclass12_0.ATTACK) == 0 && gclass14_0.method_9(gclass12_0.CHECK_ATTACK) == 0)
					{
						if (class47_0.IsBusy)
						{
							class47_0.method_0();
							class47_0.Dispose();
						}
						if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
						{
							gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
						}
						Thread.Sleep(1000);
						if (bool_22)
						{
							while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
							{
								method_3(Class60.smethod_0(-2050210591));
								Thread.Sleep(400);
								num14 = 0;
								num12 = 0;
							}
						}
						Thread.Sleep(500);
						while (num11 == 0)
						{
							method_3(Class60.smethod_0(-2050210613));
							Thread.Sleep(1000);
							num11 = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN);
						}
						flag = true;
					}
				}
				else if (num11 == 0 && flag)
				{
					flag = false;
					num14 = 0;
					num12 = 0;
					if (!class47_0.IsBusy)
					{
						class47_0.RunWorkerAsync();
					}
					timer_0.Start();
				}
				else if (num11 == 1 && num3 > 98 && flag && gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0)
				{
					while (num11 == 1)
					{
						method_3(Class60.smethod_0(-2050210613));
						Thread.Sleep(1000);
						num11 = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN);
					}
					num14 = 0;
					num12 = 0;
					flag = false;
					if (bool_22)
					{
						while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
						{
							method_3(Class60.smethod_0(-2050210591));
							Thread.Sleep(400);
						}
					}
					if (!class47_0.IsBusy)
					{
						class47_0.RunWorkerAsync();
					}
					timer_0.Start();
				}
				else if (num11 == 1 && flag)
				{
					if (num12 == 0)
					{
						num14 = num2;
						num12++;
					}
					else if (num12 >= 50)
					{
						if (num14 == num2)
						{
							while (num11 == 1)
							{
								method_3(Class60.smethod_0(-2050210613));
								Thread.Sleep(1000);
								num11 = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN);
							}
							if (bool_22)
							{
								while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
								{
									method_3(Class60.smethod_0(-2050210591));
									Thread.Sleep(400);
								}
							}
							while (num11 == 0)
							{
								method_3(Class60.smethod_0(-2050210613));
								Thread.Sleep(1000);
								num11 = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN);
							}
							num14 = 0;
							num12 = 0;
						}
						else
						{
							num14 = 0;
							num12 = 0;
						}
					}
					else
					{
						num12++;
					}
				}
			}
			while (gclass14_0.method_9(gclass12_0.CHECK_DEAD) == 1 && gclass14_0.method_9(gclass12_0.CHECK_SITDOWN) == 0 && gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 0)
			{
				method_3(Class60.smethod_0(-2050210591));
				Thread.Sleep(600);
			}
			if (bool_25)
			{
				num5 = gclass14_0.method_9(gclass12_0.WEIGHT);
				num8 = gclass14_0.method_9(gclass12_0.MAX_WEIGHT);
				if (num8 > 0)
				{
					if (Settings.Default.Over_Weight >= 8)
					{
						if (num5 * 100 / num8 >= Settings.Default._3_Over_Weight * 10 + 9)
						{
							flag5 = true;
							break;
						}
					}
					else if (num5 * 100 / num8 >= Settings.Default._3_Over_Weight * 10 + 10)
					{
						flag5 = true;
						break;
					}
				}
			}
			if (gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 3 && gclass14_0.method_9(gclass12_0.CHECK_SITDOWN) == 1 && gclass14_0.method_9(gclass12_0.CHECK_DEAD) == 1)
			{
				if (bool_41)
				{
					bool_47 = true;
					break;
				}
				if (bool_39 || bool_40)
				{
					if (bool_39)
					{
						soundPlayer_1.Play();
						Thread.Sleep(5000);
					}
					if (bool_40 && !bool_46)
					{
						bool_46 = true;
						Class55.smethod_8(Settings.Default.Line_Token, int_5, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050205603));
					}
				}
			}
			if ((!bool_39 && !bool_40 && !bool_42) || !method_10() || !bool_42)
			{
				if ((bool_39 || bool_40) && !gclass14_0.method_8(gclass12_0.MAP_NAME).Equals(string_1))
				{
					if (bool_39)
					{
						soundPlayer_1.Play();
						Thread.Sleep(5000);
					}
					if (bool_40 && !bool_43)
					{
						bool_43 = true;
						string text = gclass14_0.method_8(gclass12_0.MAP_NAME);
						if (text.IndexOf('\0') > 0)
						{
							text = text.Substring(0, text.IndexOf('.'));
						}
						Class55.smethod_8(Settings.Default.Line_Token, int_5, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050205685) + text);
					}
				}
				if ((!bool_39 && !bool_40) || gclass14_0.method_9(gclass12_0.CHECK_DISCONNECT) == 0)
				{
					if (class47_1.CancellationPending)
					{
						e.Cancel = true;
					}
					Thread.Sleep(300);
					continue;
				}
				if (bool_39)
				{
					soundPlayer_1.Play();
					Thread.Sleep(5000);
				}
				if (bool_40)
				{
					Class55.smethod_8(Settings.Default.Line_Token, int_5, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050203668));
				}
				break;
			}
			bool_48 = true;
			break;
		}
		try
		{
			timer_0.Stop();
			if (class47_0.IsBusy)
			{
				class47_0.method_0();
				class47_0.Dispose();
			}
			if (flag3 || flag4 || flag5)
			{
				if (bool_22)
				{
					while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
					{
						method_3(Class60.smethod_0(-2050210591));
						Thread.Sleep(1000);
					}
				}
				method_3(Settings.Default._3_BWing_Hotkey);
				Thread.Sleep(2000);
				int_30 = 0;
				while (gclass14_0.method_8(gclass12_0.MAP_NAME).Equals(string_1))
				{
					int_30++;
					if (int_30 > 2)
					{
						break;
					}
					method_3(Settings.Default._3_BWing_Hotkey);
					Thread.Sleep(2000);
				}
				if (bool_39 || bool_40)
				{
					if (bool_39)
					{
						soundPlayer_1.Play();
					}
					if (bool_40)
					{
						string text2 = Class60.smethod_0(-2050203705);
						if (flag3)
						{
							text2 = Class60.smethod_0(-2050203740);
						}
						else if (flag4)
						{
							text2 = Class60.smethod_0(-2050203769);
						}
						if (int_30 > 2)
						{
							Class55.smethod_8(Settings.Default.Line_Token, int_5, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050203782) + text2);
						}
						else
						{
							Class55.smethod_8(Settings.Default.Line_Token, int_5, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050203823) + text2);
						}
					}
				}
			}
			if (bool_48)
			{
				try
				{
					Process.GetProcessById(int_0).Kill();
				}
				catch
				{
					TerminateProcess(intptr_0, 0u);
				}
				if (bool_39 || bool_40)
				{
					if (bool_39)
					{
						soundPlayer_1.Play();
					}
					if (bool_40)
					{
						Class55.smethod_8(Settings.Default.Line_Token, int_5, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050203844));
					}
				}
			}
			if (bool_47)
			{
				try
				{
					Process.GetProcessById(int_0).Kill();
				}
				catch
				{
					TerminateProcess(intptr_0, 0u);
				}
				if (bool_39 || bool_40)
				{
					if (bool_39)
					{
						soundPlayer_1.Play();
					}
					if (bool_40)
					{
						Class55.smethod_8(Settings.Default.Line_Token, int_5, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050203935));
					}
				}
			}
			if (int_2 != null && int_2.Length != 0)
			{
				Array.Clear(int_2, 0, int_2.Length);
			}
			if (int_3 != null && int_3.Length != 0)
			{
				Array.Clear(int_3, 0, int_3.Length);
			}
			if (int_4 != null && int_4.Length != 0)
			{
				Array.Clear(int_4, 0, int_4.Length);
			}
			((Control)button_0).set_Enabled(false);
			if ((int)MessageBox.Show(Class60.smethod_0(-2050203944), Class60.smethod_0(-2050204063), (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0) == 1)
			{
				((Control)tableLayoutPanel_3).set_Enabled(true);
				((Control)button_1).set_Enabled(true);
			}
		}
		catch
		{
			if (class47_0.IsBusy)
			{
				class47_0.method_0();
				class47_0.Dispose();
			}
			if (int_2 != null && int_2.Length != 0)
			{
				Array.Clear(int_2, 0, int_2.Length);
			}
			if (int_3 != null && int_3.Length != 0)
			{
				Array.Clear(int_3, 0, int_3.Length);
			}
			if (int_4 != null && int_4.Length != 0)
			{
				Array.Clear(int_4, 0, int_4.Length);
			}
			bool_0 = false;
			((Control)button_0).set_Enabled(false);
			if ((int)MessageBox.Show(Class60.smethod_0(-2050205414), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16, (MessageBoxDefaultButton)0) == 1)
			{
				((Control)tableLayoutPanel_3).set_Enabled(true);
				((Control)button_1).set_Enabled(true);
			}
		}
	}

	private void method_2(object sender, ElapsedEventArgs e)
	{
		if (bool_14)
		{
			int_18++;
		}
		if (bool_26)
		{
			int_17++;
		}
		if (bool_27)
		{
			int_19++;
		}
		if (bool_28)
		{
			int_20++;
		}
		if (bool_29)
		{
			int_21++;
		}
		if (bool_30)
		{
			int_22++;
		}
		if (bool_31)
		{
			int_23++;
		}
		if (bool_32)
		{
			int_24++;
		}
		if (bool_34)
		{
			int_25++;
		}
		if (bool_35)
		{
			int_26++;
		}
		if (bool_36)
		{
			int_27++;
		}
		if (bool_37)
		{
			int_28++;
		}
		if (bool_48)
		{
			bool_48 = false;
			button_0.PerformClick();
		}
		if (bool_47)
		{
			bool_47 = false;
			button_0.PerformClick();
		}
		if (bool_43)
		{
			int_36++;
			if (int_36 > 300)
			{
				int_36 = 0;
				bool_43 = false;
			}
		}
		if (bool_45)
		{
			int_38++;
			if (int_38 > 300)
			{
				int_38 = 0;
				bool_45 = false;
			}
		}
		if (bool_44)
		{
			int_37++;
			if (int_37 > 300)
			{
				int_37 = 0;
				bool_44 = false;
			}
		}
		if (bool_46)
		{
			int_39++;
			if (int_39 > 300)
			{
				int_39 = 0;
				bool_46 = false;
			}
		}
		if (!class47_0.IsBusy && !class47_1.IsBusy)
		{
			int_35++;
			if (int_35 > 10)
			{
				int_35 = 0;
				class47_0.RunWorkerAsync();
				class47_1.RunWorkerAsync();
				if (bool_40)
				{
					Class55.smethod_8(Settings.Default.Line_Token, int_5, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050204044));
				}
			}
		}
		else
		{
			int_35 = 0;
		}
	}

	private void checkBox_32_CheckedChanged(object sender, EventArgs e)
	{
		bool_1 = checkBox_32.get_Checked();
	}

	private void checkBox_13_CheckedChanged(object sender, EventArgs e)
	{
		bool_3 = checkBox_13.get_Checked();
		if (bool_3)
		{
			checkBox_0.set_Checked(false);
		}
		else if (!bool_2)
		{
			checkBox_28.set_Checked(false);
		}
	}

	private void checkBox_14_CheckedChanged(object sender, EventArgs e)
	{
		bool_13 = checkBox_14.get_Checked();
	}

	private void checkBox_38_CheckedChanged(object sender, EventArgs e)
	{
		bool_5 = checkBox_38.get_Checked();
	}

	private void checkBox_28_CheckedChanged(object sender, EventArgs e)
	{
		bool_4 = checkBox_28.get_Checked();
		if (bool_4 && !bool_2 && !bool_3)
		{
			checkBox_0.set_Checked(true);
		}
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		bool_2 = checkBox_0.get_Checked();
		if (bool_2)
		{
			checkBox_13.set_Checked(false);
		}
		else if (!bool_3)
		{
			checkBox_28.set_Checked(false);
		}
	}

	private void checkBox_29_CheckedChanged(object sender, EventArgs e)
	{
		bool_6 = checkBox_29.get_Checked();
	}

	private void checkBox_25_CheckedChanged(object sender, EventArgs e)
	{
		bool_15 = checkBox_25.get_Checked();
	}

	private void checkBox_35_CheckedChanged(object sender, EventArgs e)
	{
		bool_9 = checkBox_35.get_Checked();
	}

	private void checkBox_17_CheckedChanged(object sender, EventArgs e)
	{
		bool_10 = checkBox_17.get_Checked();
	}

	private void checkBox_31_CheckedChanged(object sender, EventArgs e)
	{
		bool_11 = checkBox_31.get_Checked();
	}

	private void checkBox_16_CheckedChanged(object sender, EventArgs e)
	{
		bool_12 = checkBox_16.get_Checked();
	}

	private void checkBox_33_CheckedChanged(object sender, EventArgs e)
	{
		bool_16 = checkBox_33.get_Checked();
		if (bool_16 && !bool_17)
		{
			checkBox_5.set_Checked(true);
		}
	}

	private void checkBox_34_CheckedChanged(object sender, EventArgs e)
	{
		bool_19 = checkBox_34.get_Checked();
		if (bool_19 && !bool_20)
		{
			checkBox_3.set_Checked(true);
		}
	}

	private void checkBox_5_CheckedChanged(object sender, EventArgs e)
	{
		bool_17 = checkBox_5.get_Checked();
		if (bool_17)
		{
			checkBox_7.set_Checked(false);
		}
		else if (bool_16)
		{
			checkBox_33.set_Checked(false);
		}
	}

	private void checkBox_7_CheckedChanged(object sender, EventArgs e)
	{
		bool_18 = checkBox_7.get_Checked();
		if (bool_18)
		{
			checkBox_5.set_Checked(false);
		}
	}

	private void checkBox_3_CheckedChanged(object sender, EventArgs e)
	{
		bool_20 = checkBox_3.get_Checked();
		if (!bool_20 && bool_19)
		{
			checkBox_34.set_Checked(false);
		}
	}

	private void checkBox_8_CheckedChanged(object sender, EventArgs e)
	{
		bool_33 = checkBox_8.get_Checked();
		if (bool_33)
		{
			checkBox_36.set_Checked(false);
		}
	}

	private void checkBox_36_CheckedChanged(object sender, EventArgs e)
	{
		bool_14 = checkBox_36.get_Checked();
		if (bool_14)
		{
			checkBox_8.set_Checked(false);
		}
	}

	private void checkBox_9_CheckedChanged(object sender, EventArgs e)
	{
		bool_26 = checkBox_9.get_Checked();
		if (bool_26)
		{
			int_33 = 8;
		}
		else
		{
			int_33 = 5;
		}
	}

	private void checkBox_12_CheckedChanged(object sender, EventArgs e)
	{
		bool_34 = checkBox_12.get_Checked();
	}

	private void checkBox_11_CheckedChanged(object sender, EventArgs e)
	{
		bool_35 = checkBox_11.get_Checked();
	}

	private void checkBox_15_CheckedChanged(object sender, EventArgs e)
	{
		bool_36 = checkBox_15.get_Checked();
	}

	private void checkBox_27_CheckedChanged(object sender, EventArgs e)
	{
		bool_37 = checkBox_27.get_Checked();
	}

	private void checkBox_6_CheckedChanged(object sender, EventArgs e)
	{
		bool_21 = checkBox_6.get_Checked();
		if (bool_21)
		{
			checkBox_4.set_Checked(false);
		}
	}

	private void checkBox_4_CheckedChanged(object sender, EventArgs e)
	{
		bool_22 = checkBox_4.get_Checked();
		if (bool_22)
		{
			checkBox_6.set_Checked(false);
		}
	}

	private void checkBox_2_CheckedChanged(object sender, EventArgs e)
	{
		bool_23 = checkBox_2.get_Checked();
		if (bool_23)
		{
			checkBox_30.set_Checked(false);
		}
	}

	private void checkBox_30_CheckedChanged(object sender, EventArgs e)
	{
		bool_24 = checkBox_30.get_Checked();
		if (bool_24)
		{
			checkBox_2.set_Checked(false);
		}
	}

	private void checkBox_1_CheckedChanged(object sender, EventArgs e)
	{
		bool_25 = checkBox_1.get_Checked();
	}

	private void checkBox_24_CheckedChanged(object sender, EventArgs e)
	{
		bool_41 = checkBox_24.get_Checked();
	}

	private void checkBox_37_CheckedChanged(object sender, EventArgs e)
	{
		bool_42 = checkBox_37.get_Checked();
	}

	private void checkBox_10_CheckedChanged(object sender, EventArgs e)
	{
		bool_27 = checkBox_10.get_Checked();
	}

	private void checkBox_18_CheckedChanged(object sender, EventArgs e)
	{
		bool_28 = checkBox_18.get_Checked();
	}

	private void checkBox_19_CheckedChanged(object sender, EventArgs e)
	{
		bool_29 = checkBox_19.get_Checked();
	}

	private void checkBox_20_CheckedChanged(object sender, EventArgs e)
	{
		bool_30 = checkBox_20.get_Checked();
	}

	private void checkBox_21_CheckedChanged(object sender, EventArgs e)
	{
		bool_31 = checkBox_21.get_Checked();
	}

	private void checkBox_22_CheckedChanged(object sender, EventArgs e)
	{
		bool_32 = checkBox_22.get_Checked();
	}

	private void checkBox_40_CheckedChanged(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		bool_38 = checkBox_40.get_Checked();
		if (bool_38 && !checkBox_10.get_Checked() && !checkBox_18.get_Checked() && !checkBox_19.get_Checked() && !checkBox_20.get_Checked() && !checkBox_21.get_Checked() && !checkBox_22.get_Checked() && !checkBox_12.get_Checked() && !checkBox_11.get_Checked() && !checkBox_15.get_Checked() && !checkBox_27.get_Checked())
		{
			checkBox_40.set_Checked(false);
			Form val = new Form();
			val.set_TopMost(true);
			MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050204109), Class60.smethod_0(-2050209943), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void checkBox_39_CheckedChanged(object sender, EventArgs e)
	{
		bool_39 = checkBox_39.get_Checked();
	}

	private void checkBox_41_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		bool_40 = checkBox_41.get_Checked();
		if (bool_40 && string.IsNullOrEmpty(Settings.Default.Line_Token))
		{
			checkBox_41.set_Checked(false);
			Form val = new Form();
			val.set_TopMost(true);
			MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050204202), Class60.smethod_0(-2050209943), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void checkBox_23_CheckedChanged(object sender, EventArgs e)
	{
		bool_7 = checkBox_23.get_Checked();
	}

	private void checkBox_26_CheckedChanged(object sender, EventArgs e)
	{
		bool_8 = checkBox_26.get_Checked();
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		tabControl_0.set_SelectedIndex(0);
	}

	private void toolStripMenuItem_11_Click(object sender, EventArgs e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		try
		{
			((FileDialog)openFileDialog_0).set_InitialDirectory(AppDomain.CurrentDomain.BaseDirectory + Class60.smethod_0(-2050204309));
			if (!Directory.Exists(((FileDialog)openFileDialog_0).get_InitialDirectory()))
			{
				Directory.CreateDirectory(((FileDialog)openFileDialog_0).get_InitialDirectory());
			}
			if ((int)((CommonDialog)openFileDialog_0).ShowDialog() == 1)
			{
				StreamReader streamReader = new StreamReader(((FileDialog)openFileDialog_0).get_FileName());
				try
				{
					method_21(JsonConvert.DeserializeObject<GClass17>(streamReader.ReadToEnd()));
					gcontrol5_0.method_0();
					gcontrol0_0.method_0();
					gcontrol1_0.method_0();
					return;
				}
				finally
				{
					((IDisposable)streamReader).Dispose();
				}
			}
		}
		catch
		{
		}
	}

	private void toolStripMenuItem_12_Click(object sender, EventArgs e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		try
		{
			((FileDialog)saveFileDialog_0).set_InitialDirectory(AppDomain.CurrentDomain.BaseDirectory + Class60.smethod_0(-2050204309));
			if (!Directory.Exists(((FileDialog)saveFileDialog_0).get_InitialDirectory()))
			{
				Directory.CreateDirectory(((FileDialog)saveFileDialog_0).get_InitialDirectory());
			}
			if ((int)((CommonDialog)saveFileDialog_0).ShowDialog() == 1)
			{
				StreamWriter streamWriter = new StreamWriter(((FileDialog)saveFileDialog_0).get_FileName());
				try
				{
					string value = JsonConvert.SerializeObject((object)method_22());
					streamWriter.Write(value);
					return;
				}
				finally
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
		}
		catch
		{
		}
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		tabControl_0.set_SelectedIndex(1);
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		tabControl_0.set_SelectedIndex(2);
	}

	private void toolStripMenuItem_10_Click(object sender, EventArgs e)
	{
		tabControl_0.set_SelectedIndex(3);
	}

	private void method_3(string string_2)
	{
		PostMessage(intptr_0, 256u, dictionary_0[string_2], 0);
		Thread.Sleep(100);
		PostMessage(intptr_0, 257u, dictionary_0[string_2], 0);
		Thread.Sleep(100);
	}

	private int method_4(int int_40)
	{
		if (int_40 % 2 != 0)
		{
			int_40++;
		}
		return int_40;
	}

	private Point method_5(int int_40)
	{
		return int_40 switch
		{
			1 => new Point(method_4(int_11 - int_9 / 6), method_4(int_12 - int_10 / 6)), 
			8 => new Point(method_4(int_11 - int_9 * 30 / 100), method_4(int_12)), 
			7 => new Point(method_4(int_11 - int_9 / 6), method_4(int_12 + int_10 / 6)), 
			3 => new Point(method_4(int_11 + int_9 / 6), method_4(int_12 - int_10 / 6)), 
			4 => new Point(method_4(int_11 + int_9 * 30 / 100), method_4(int_12)), 
			5 => new Point(method_4(int_11 + int_9 / 6), method_4(int_12 + int_10 / 6)), 
			2 => new Point(method_4(int_11), method_4(int_12 - int_10 * 35 / 100)), 
			_ => new Point(method_4(int_11), method_4(int_12 + int_10 * 30 / 100)), 
		};
	}

	private List<int> method_6()
	{
		List<int> list = new List<int>();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		foreach (string item in list_1)
		{
			num2 = gclass14_0.method_9(item);
			if ((num2 > 0 && num2 < 200) || (num2 > 4000 && num2 < 4200))
			{
				num3 = gclass14_0.method_9(list_0[num]);
				if (num3 > 100000 && num3 < 99999999)
				{
					list.Add(num3);
					list.Add(gclass14_0.method_9(list_4[num]));
					return list;
				}
			}
			num++;
		}
		return list;
	}

	private bool method_7(int int_40)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		foreach (string item in list_1)
		{
			num2 = gclass14_0.method_9(item);
			num4 = gclass14_0.method_9(list_4[num].ToString());
			if ((num2 > 0 && num2 < 200) || (num2 > 4000 && num2 < 4200))
			{
				num3 = gclass14_0.method_9(list_0[num]);
				if (num3 > 100000 && num3 < 99999999 && int_40 == num4)
				{
					return true;
				}
			}
			num++;
		}
		return false;
	}

	private int method_8()
	{
		int result = 0;
		int num = 0;
		int num2 = 0;
		foreach (string item in list_6)
		{
			num2 = gclass14_0.method_9(item);
			if ((num2 <= 4000 || num2 >= 4900) && num2 != 27161 && num2 != 27018 && num2 != 27014 && num2 != 27015 && num2 != 27019 && num2 != 27016 && num2 != 27020)
			{
				num++;
				continue;
			}
			if (bool_39 || bool_40)
			{
				if (bool_39)
				{
					soundPlayer_2.Play();
				}
				if (bool_40 && !bool_44)
				{
					bool_44 = true;
					Class55.smethod_8(Settings.Default.Line_Token, int_5, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050206904));
				}
			}
			return gclass14_0.method_9(list_5[num]);
		}
		return result;
	}

	private void method_9()
	{
		bool flag = false;
		int num = 0;
		foreach (string item in list_1)
		{
			num = gclass14_0.method_9(item);
			if (num == 45 || gclass14_0.method_9(gclass12_0.WARP_PRIEST) == 1)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return;
		}
		if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
		{
			gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
		}
		if (bool_22)
		{
			int_30 = 0;
			while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
			{
				int_30++;
				gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
				gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205543));
				gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
				gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
				Thread.Sleep(400);
			}
			while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
			{
				method_3(Class60.smethod_0(-2050210591));
				Thread.Sleep(400);
			}
		}
		else
		{
			method_3(Settings.Default._3_Wing_Hotkey);
		}
		if (list_10.ToList().Count() > 0)
		{
			list_10.Clear();
		}
		if (list_11.ToList().Count() > 0)
		{
			list_11.Clear();
		}
		Thread.Sleep(800);
	}

	private bool method_10()
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if (gclass14_0.method_9(gclass12_0.CHECK_WEAPON) == 0)
		{
			SetForegroundWindow(intptr_0);
			if (bool_39 || bool_40)
			{
				if (bool_39)
				{
					soundPlayer_0.Play();
				}
				if (bool_40 && !bool_45)
				{
					bool_45 = true;
					Class55.smethod_8(Settings.Default.Line_Token, int_5, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050206929));
				}
			}
			return true;
		}
		foreach (string item in list_1)
		{
			num3 = gclass14_0.method_9(item);
			num2 = gclass14_0.method_9(list_0[num].ToString());
			if ((num3 <= 2400 || num3 >= 2500) && (num3 != 8 || !struct23_0.method_0().Contains(num2)) && gclass14_0.method_9(gclass12_0.CHECK_WALKING) != 10)
			{
				num++;
				continue;
			}
			SetForegroundWindow(intptr_0);
			if (bool_39 || bool_40)
			{
				if (bool_39)
				{
					soundPlayer_0.Play();
				}
				if (bool_40 && !bool_45)
				{
					bool_45 = true;
					Class55.smethod_8(Settings.Default.Line_Token, int_5, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050206929));
				}
			}
			return true;
		}
		return false;
	}

	private double method_11(int int_40, int int_41)
	{
		int num = gclass14_0.method_9(gclass12_0.CHAR_X);
		int num2 = gclass14_0.method_9(gclass12_0.CHAR_Y);
		if (num < 0 || num > 1000 || num2 < 0 || num2 > 1000)
		{
			num = int_40 + 10;
			num2 = int_41 + 10;
		}
		double num3 = method_12(int_41 - num2);
		double num4 = method_12(int_40 - num);
		double num5 = Math.Sin(num4 / 2.0) * Math.Sin(num4 / 2.0) + Math.Cos(method_12(num)) * Math.Cos(method_12(int_40)) * (Math.Sin(num3 / 2.0) * Math.Sin(num3 / 2.0));
		double num6 = 2.0 * Math.Atan2(Math.Sqrt(num5), Math.Sqrt(1.0 - num5));
		return num6 * 6378.16;
	}

	private double method_12(double double_0)
	{
		return double_0 * Math.PI / 180.0;
	}

	private bool method_13(int int_40)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		foreach (string item in list_1)
		{
			num3 = gclass14_0.method_9(item);
			num2 = gclass14_0.method_9(list_0[num].ToString());
			num4 = gclass14_0.method_9(list_4[num].ToString());
			if (!struct26_0.method_0().ContainsKey(num3) || num2 != int_40)
			{
				num++;
				continue;
			}
			if (num4 != 0 && num4 != int_6)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private bool method_14(int int_40)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		foreach (string item in list_1)
		{
			num3 = gclass14_0.method_9(item);
			num2 = gclass14_0.method_9(list_0[num].ToString());
			gclass14_0.method_9(list_4[num].ToString());
			if (!struct26_0.method_0().ContainsKey(num3) || num2 != int_40)
			{
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private List<Class50> method_15()
	{
		Class51 @class = new Class51();
		List<Class50> list = new List<Class50>();
		int index = 0;
		@class.int_0 = 0;
		int num = 0;
		int num2 = 0;
		bool flag = false;
		foreach (string item in list_1)
		{
			num = gclass14_0.method_9(item);
			@class.int_0 = gclass14_0.method_9(list_0[index].ToString());
			num2 = gclass14_0.method_9(list_4[index++].ToString());
			if (struct26_0.method_0().ContainsKey(num))
			{
				flag = ((num2 == int_6) ? true : false);
				if (!list.ToList().Any(@class.method_0))
				{
					Class50 class2 = new Class50();
					class2.method_1(@class.int_0);
					class2.method_3(flag);
					class2.method_5(0.0);
					list.Add(class2);
				}
			}
		}
		return list;
	}

	private void method_16()
	{
		Class52 @class = new Class52();
		List<Class50> list = new List<Class50>();
		if (list_10.ToList().Count > 0)
		{
			list_10.Clear();
		}
		if (list_12.ToList().Count > 0)
		{
			list_12.Clear();
		}
		bool flag = false;
		int num = 0;
		@class.int_0 = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		foreach (string item in list_1)
		{
			num2 = gclass14_0.method_9(item);
			@class.int_0 = gclass14_0.method_9(list_0[num].ToString());
			num3 = gclass14_0.method_9(list_2[num].ToString());
			num4 = gclass14_0.method_9(list_3[num].ToString());
			num5 = gclass14_0.method_9(list_4[num].ToString());
			if (struct26_0.method_0().ContainsKey(num2))
			{
				if (bool_7 && int_3.Contains(num2) && @class.int_0 > 0 && @class.int_0 < 90000)
				{
					if (class47_0.IsBusy && class47_1.IsBusy)
					{
						class47_1.method_0();
						class47_1.Dispose();
					}
					if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
					{
						gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					if (bool_22)
					{
						int_30 = 0;
						while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
						{
							int_30++;
							gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
							gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205543));
							gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
							gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
							Thread.Sleep(400);
						}
						while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
						{
							method_3(Class60.smethod_0(-2050210591));
							Thread.Sleep(400);
						}
					}
					else
					{
						method_3(Settings.Default._3_Wing_Hotkey);
					}
					Thread.Sleep(800);
					if (!class47_1.IsBusy)
					{
						class47_1.RunWorkerAsync();
					}
					break;
				}
				if (bool_13 && int_2.Length != 0)
				{
					if (int_2.Contains(num2) && ((!bool_5 && (gclass14_0.method_9(gclass12_0.CHAR_X) == 0 || Math.Abs(num3 - gclass14_0.method_9(gclass12_0.CHAR_X)) < 14) && (gclass14_0.method_9(gclass12_0.CHAR_Y) == 0 || Math.Abs(num4 - gclass14_0.method_9(gclass12_0.CHAR_Y)) < 14)) || (bool_5 && (gclass14_0.method_9(gclass12_0.CHAR_X) == 0 || Math.Abs(num3 - gclass14_0.method_9(gclass12_0.CHAR_X)) < 5) && (gclass14_0.method_9(gclass12_0.CHAR_Y) == 0 || Math.Abs(num4 - gclass14_0.method_9(gclass12_0.CHAR_Y)) < 5))))
					{
						if (@class.int_0 > 0 && @class.int_0 < 90000 && (@class.int_0 < 47000 || @class.int_0 > 50000))
						{
							if (!list_10.ToList().Any(@class.method_0) && !list.ToList().Any(@class.method_1))
							{
								if (bool_6 || (!bool_6 && (num5 == 0 || num5 == int_6)))
								{
									if (num5 == int_6)
									{
										flag = true;
										if (!list_12.ToList().Any(@class.method_2))
										{
											list_12.Add(@class.int_0);
										}
									}
									else
									{
										flag = false;
									}
									Class50 class2 = new Class50();
									class2.method_1(@class.int_0);
									class2.method_3(flag);
									class2.method_5(method_11(num3, num4));
									list.Add(class2);
								}
							}
							else if (num5 == int_6 && !list_12.ToList().Any(@class.method_3))
							{
								list_12.Add(@class.int_0);
							}
						}
					}
					else if (num5 == int_6 && !list_12.ToList().Any(@class.method_4))
					{
						list_12.Add(@class.int_0);
					}
				}
				else if ((!bool_5 && (gclass14_0.method_9(gclass12_0.CHAR_X) == 0 || Math.Abs(num3 - gclass14_0.method_9(gclass12_0.CHAR_X)) < 14) && (gclass14_0.method_9(gclass12_0.CHAR_Y) == 0 || Math.Abs(num4 - gclass14_0.method_9(gclass12_0.CHAR_Y)) < 14)) || (bool_5 && (gclass14_0.method_9(gclass12_0.CHAR_X) == 0 || Math.Abs(num3 - gclass14_0.method_9(gclass12_0.CHAR_X)) < 5) && (gclass14_0.method_9(gclass12_0.CHAR_Y) == 0 || Math.Abs(num4 - gclass14_0.method_9(gclass12_0.CHAR_Y)) < 5)))
				{
					if (@class.int_0 > 0 && @class.int_0 < 90000 && (@class.int_0 < 47000 || @class.int_0 > 50000))
					{
						if (!list_10.ToList().Any(@class.method_5) && !list.ToList().Any(@class.method_6))
						{
							if (bool_6 || (!bool_6 && (num5 == 0 || num5 == int_6)))
							{
								if (num5 == int_6)
								{
									flag = true;
									if (!list_12.ToList().Any(@class.method_7))
									{
										list_12.Add(@class.int_0);
									}
								}
								else
								{
									flag = false;
								}
								Class50 class3 = new Class50();
								class3.method_1(@class.int_0);
								class3.method_3(flag);
								class3.method_5(method_11(num3, num4));
								list.Add(class3);
							}
						}
						else if (num5 == int_6 && !list_12.ToList().Any(@class.method_8))
						{
							list_12.Add(@class.int_0);
						}
					}
				}
				else if (num5 == int_6 && !list_12.ToList().Any(@class.method_9))
				{
					list_12.Add(@class.int_0);
				}
				if (bool_8 && list_12.ToList().Count >= Settings.Default._3_Scrum_Escape + 2)
				{
					list_12.Clear();
					if (class47_0.IsBusy && class47_1.IsBusy)
					{
						class47_1.method_0();
						class47_1.Dispose();
					}
					if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
					{
						gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					if (bool_22)
					{
						int_30 = 0;
						while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
						{
							int_30++;
							gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
							gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205543));
							gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
							gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
							Thread.Sleep(400);
						}
						while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
						{
							method_3(Class60.smethod_0(-2050210591));
							Thread.Sleep(400);
						}
					}
					else
					{
						method_3(Settings.Default._3_Wing_Hotkey);
					}
					Thread.Sleep(800);
					if (!class47_1.IsBusy)
					{
						class47_1.RunWorkerAsync();
					}
					break;
				}
			}
			num++;
		}
		if (list.ToList().Count > 0)
		{
			list_10.AddRange(list);
		}
		else
		{
			list_10.Clear();
		}
	}

	private void method_17()
	{
		Class44 @class = new Class44();
		if (list_11.ToList().Count > 0)
		{
			list_11.Clear();
		}
		int num = 0;
		@class.int_0 = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (!bool_2 && !bool_3)
		{
			return;
		}
		foreach (string item in list_1)
		{
			_ = item;
			num2 = gclass14_0.method_9(list_6[num].ToString());
			@class.int_0 = gclass14_0.method_9(list_5[num].ToString());
			num3 = gclass14_0.method_9(list_7[num].ToString());
			num4 = gclass14_0.method_9(list_8[num].ToString());
			if ((struct24_0.method_0().ContainsKey(num2) || (bool_1 && num2 > 4000 && num2 < 4900)) && num3 > int_13 && num3 < int_14 && num4 > int_15 && num4 < int_16)
			{
				if (bool_3 && int_4.Length != 0)
				{
					if ((int_4.Contains(num2) || (bool_1 && num2 > 4000 && num2 < 4900)) && @class.int_0 > 0 && @class.int_0 < 100000 && !list_11.ToList().Any(@class.method_0))
					{
						list_11.Add(@class.int_0);
					}
				}
				else if (@class.int_0 > 0 && @class.int_0 < 100000 && !list_11.ToList().Any(@class.method_1))
				{
					list_11.Add(@class.int_0);
				}
			}
			num++;
		}
	}

	private void method_18()
	{
		if (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) != 0 || (bool_38 && (!bool_38 || method_15().Count() > 3 || method_15().Count(Class43.class43_0.method_7) > 0)))
		{
			return;
		}
		if (bool_26 && int_17 >= Settings.Default._3_AB_Freq + 1)
		{
			int_17 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_2().ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(1000);
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_1().ToString());
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(2000);
		}
		if (bool_27 && int_19 >= Settings.Default._3_SKILLBUFF_1_Freq + 1)
		{
			int_19 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default._3_SKILLBUFF_1.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(3000);
		}
		if (bool_28 && int_20 >= Settings.Default._3_SKILLBUFF_2_Freq + 1)
		{
			int_20 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default._3_SKILLBUFF_2.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(2000);
		}
		if (bool_29 && int_21 >= Settings.Default._3_SKILLBUFF_3_Freq + 1)
		{
			int_21 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default._3_SKILLBUFF_3.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(2000);
		}
		if (bool_30 && int_22 >= Settings.Default._3_SKILLBUFF_4_Freq + 1)
		{
			int_22 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default._3_SKILLBUFF_4.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(2000);
		}
		if (bool_31 && int_23 >= Settings.Default._3_SKILLBUFF_5_Freq + 1)
		{
			int_23 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default._3_SKILLBUFF_5.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(2000);
		}
		if (bool_32 && int_24 >= Settings.Default._3_SKILLBUFF_6_Freq + 1)
		{
			int_24 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_6.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default._3_SKILLBUFF_6.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(2000);
		}
		if (bool_34 && int_25 >= Settings.Default._3_Macro1_Freq + 1)
		{
			int_25 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			method_3(Settings.Default._3_Macro1_Hotkey);
			Thread.Sleep(1500);
		}
		if (bool_35 && int_26 >= Settings.Default._3_Macro2_Freq + 1)
		{
			int_26 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			method_3(Settings.Default._3_Macro2_Hotkey);
			Thread.Sleep(1500);
		}
		if (bool_36 && int_27 >= Settings.Default._3_Macro3_Freq + 1)
		{
			int_27 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			method_3(Settings.Default._3_Macro3_Hotkey);
			Thread.Sleep(1500);
		}
		if (bool_37 && int_28 >= Settings.Default._3_Macro4_Freq + 1)
		{
			int_28 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			method_3(Settings.Default._3_Macro4_Hotkey);
			Thread.Sleep(1500);
		}
	}

	private void method_19()
	{
		if (Settings.Default._3_Home_Settings == null)
		{
			Settings.Default._3_Home_Settings = new StringCollection();
		}
		if (Settings.Default._3_Home_Settings.Count <= 0)
		{
			return;
		}
		List<string> list = Settings.Default._3_Home_Settings.Cast<string>().ToList();
		if (list == null || list.Count <= 0)
		{
			return;
		}
		int num = 0;
		foreach (string item in list)
		{
			if (item == Class60.smethod_0(-2050206966))
			{
				switch (num)
				{
				case 0:
					checkBox_32.set_Checked(true);
					break;
				case 1:
					checkBox_0.set_Checked(true);
					break;
				case 2:
					checkBox_13.set_Checked(true);
					break;
				case 3:
					checkBox_28.set_Checked(true);
					break;
				case 4:
					checkBox_14.set_Checked(true);
					break;
				case 5:
					checkBox_38.set_Checked(true);
					break;
				case 6:
					checkBox_3.set_Checked(true);
					break;
				case 7:
					checkBox_34.set_Checked(true);
					break;
				case 8:
					checkBox_5.set_Checked(true);
					break;
				case 9:
					checkBox_33.set_Checked(true);
					break;
				case 10:
					checkBox_7.set_Checked(true);
					break;
				case 11:
					checkBox_6.set_Checked(true);
					break;
				case 12:
					checkBox_4.set_Checked(true);
					break;
				case 13:
					checkBox_2.set_Checked(true);
					break;
				case 14:
					checkBox_30.set_Checked(true);
					break;
				case 15:
					checkBox_23.set_Checked(true);
					break;
				case 16:
					checkBox_26.set_Checked(true);
					break;
				case 17:
					checkBox_17.set_Checked(true);
					break;
				case 18:
					checkBox_25.set_Checked(true);
					break;
				case 19:
					checkBox_35.set_Checked(true);
					break;
				case 20:
					checkBox_39.set_Checked(true);
					break;
				case 21:
					checkBox_29.set_Checked(true);
					break;
				case 22:
					checkBox_8.set_Checked(true);
					break;
				case 23:
					checkBox_36.set_Checked(true);
					break;
				case 24:
					checkBox_9.set_Checked(true);
					break;
				case 25:
					checkBox_10.set_Checked(true);
					break;
				case 26:
					checkBox_18.set_Checked(true);
					break;
				case 27:
					checkBox_19.set_Checked(true);
					break;
				case 28:
					checkBox_20.set_Checked(true);
					break;
				case 29:
					checkBox_21.set_Checked(true);
					break;
				case 30:
					checkBox_22.set_Checked(true);
					break;
				case 31:
					checkBox_12.set_Checked(true);
					break;
				case 32:
					checkBox_11.set_Checked(true);
					break;
				case 33:
					checkBox_15.set_Checked(true);
					break;
				case 34:
					checkBox_27.set_Checked(true);
					break;
				case 35:
					checkBox_40.set_Checked(true);
					break;
				case 36:
					checkBox_31.set_Checked(true);
					break;
				case 37:
					checkBox_16.set_Checked(true);
					break;
				case 38:
					checkBox_1.set_Checked(true);
					break;
				case 39:
					checkBox_24.set_Checked(true);
					break;
				case 40:
					checkBox_37.set_Checked(true);
					break;
				case 41:
					checkBox_41.set_Checked(true);
					break;
				}
			}
			num++;
		}
	}

	private void method_20()
	{
		if (Settings.Default._3_Home_Settings != null && Settings.Default._3_Home_Settings.Count > 0)
		{
			Settings.Default._3_Home_Settings.Clear();
		}
		Settings.Default._3_Home_Settings.Add(checkBox_32.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_0.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_13.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_28.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_14.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_38.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_3.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_34.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_5.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_33.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_7.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_6.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_4.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_2.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_30.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_23.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_26.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_17.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_25.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_35.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_39.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_29.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_8.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_36.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_9.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_10.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_18.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_19.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_20.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_21.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_22.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_12.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_11.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_15.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_27.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_40.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_31.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_16.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_1.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_24.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_37.get_Checked().ToString());
		Settings.Default._3_Home_Settings.Add(checkBox_41.get_Checked().ToString());
		((SettingsBase)Settings.Default).Save();
	}

	private void method_21(GClass17 gclass17_0)
	{
		checkBox_32.set_Checked(gclass17_0.CB_CardLoot);
		checkBox_0.set_Checked(gclass17_0.CB_Autoloot);
		checkBox_13.set_Checked(gclass17_0.CB_AutolootExpect);
		checkBox_28.set_Checked(gclass17_0.CB_AutolootNearest);
		checkBox_14.set_Checked(gclass17_0.CB_AttackExpect);
		checkBox_38.set_Checked(gclass17_0.CB_AttackNearest);
		checkBox_3.set_Checked(gclass17_0.CB_SP_Potion);
		checkBox_34.set_Checked(gclass17_0.CB_SP_Potion_Bwing);
		checkBox_5.set_Checked(gclass17_0.CB_HP_Potion);
		checkBox_33.set_Checked(gclass17_0.CB_HP_Potion_Bwing);
		checkBox_7.set_Checked(gclass17_0.CB_HP_Skill);
		checkBox_6.set_Checked(gclass17_0.CB_WingNotFound);
		checkBox_4.set_Checked(gclass17_0.CB_TeleportNotFound);
		checkBox_2.set_Checked(gclass17_0.CB_RandomWalkNotFound);
		checkBox_30.set_Checked(gclass17_0.CB_WalkNotFound);
		checkBox_23.set_Checked(gclass17_0.CB_Monster_Escape);
		checkBox_26.set_Checked(gclass17_0.CB_Scrum_Escape);
		checkBox_17.set_Checked(gclass17_0.CB_HP_Escape);
		checkBox_25.set_Checked(gclass17_0.CB_EscapePeopleWait);
		checkBox_35.set_Checked(gclass17_0.CB_EscapeWarp);
		checkBox_39.set_Checked(gclass17_0.CB_AlertSound);
		checkBox_29.set_Checked(gclass17_0.CB_Jam);
		checkBox_8.set_Checked(gclass17_0.CB__ATK_Skill);
		checkBox_36.set_Checked(gclass17_0.CB_ATK_Floor_Skill);
		checkBox_9.set_Checked(gclass17_0.CB_AB_Skill);
		checkBox_10.set_Checked(gclass17_0.CB_SkillBuff_1);
		checkBox_18.set_Checked(gclass17_0.CB_SkillBuff_2);
		checkBox_19.set_Checked(gclass17_0.CB_SkillBuff_3);
		checkBox_20.set_Checked(gclass17_0.CB_SkillBuff_4);
		checkBox_21.set_Checked(gclass17_0.CB_SkillBuff_5);
		checkBox_22.set_Checked(gclass17_0.CB_SkillBuff_6);
		checkBox_12.set_Checked(gclass17_0.CB_Macro1);
		checkBox_11.set_Checked(gclass17_0.CB_Macro2);
		checkBox_15.set_Checked(gclass17_0.CB_Macro3);
		checkBox_27.set_Checked(gclass17_0.CB_Macro4);
		checkBox_40.set_Checked(gclass17_0.CB_Buff_Safety);
		checkBox_31.set_Checked(gclass17_0.CB_HP_Sitdown);
		checkBox_16.set_Checked(gclass17_0.CB_SP_Sitdown);
		checkBox_1.set_Checked(gclass17_0.CB_ExitOverWeight);
		checkBox_24.set_Checked(gclass17_0.CB_ExitOnDead);
		checkBox_37.set_Checked(gclass17_0.CB_ExitOnGM);
		checkBox_41.set_Checked(gclass17_0.CB_AlertLine);
		Settings.Default._3_HP_Percent = gclass17_0.HP_Percent;
		Settings.Default._3_HP_Hotkey = gclass17_0.HP_Hotkey;
		Settings.Default._3_HP_Escape = gclass17_0.HP_Escape;
		Settings.Default._3_Scrum_Escape = gclass17_0.Scrum_Escape;
		Settings.Default._3_HP_Sitdown = gclass17_0.HP_Sitdown;
		Settings.Default._3_SP_Percent = gclass17_0.SP_Percent;
		Settings.Default._3_SP_Hotkey = gclass17_0.SP_Hotkey;
		Settings.Default._3_SP_Sitdown = gclass17_0.SP_Sitdown;
		Settings.Default._3_Wing_Hotkey = gclass17_0.Wing_Hotkey;
		Settings.Default._3_BWing_Hotkey = gclass17_0.BWing_Hotkey;
		Settings.Default._3_Over_Weight = gclass17_0.Over_Weight;
		Settings.Default._3_ATK_Skill_Mode = gclass17_0.ATK_Skill_Mode;
		Settings.Default._3_ATK_Skill = gclass17_0.ATK_Skill;
		Settings.Default._3_ATK_Skill_Lv = gclass17_0.ATK_Skill_Lv;
		Settings.Default._3_ATK_Floor_Skill_Mode = gclass17_0.ATK_Floor_Skill_Mode;
		Settings.Default._3_ATK_Floor_Skill = gclass17_0.ATK_Floor_Skill;
		Settings.Default._3_ATK_Floor_Skill_Lv = gclass17_0.ATK_Floor_Skill_Lv;
		Settings.Default._3_ATK_Floor_Skill_X = gclass17_0.ATK_Floor_Skill_X;
		Settings.Default._3_ATK_Floor_Skill_Y = gclass17_0.ATK_Floor_Skill_Y;
		Settings.Default._3_ATK_Floor_Freq = gclass17_0.ATK_Floor_Freq;
		Settings.Default._3_AB_Freq = gclass17_0.AB_Freq;
		Settings.Default._3_SKILLBUFF_1 = gclass17_0.SKILLBUFF_1;
		Settings.Default._3_SKILLBUFF_1_Freq = gclass17_0.SKILLBUFF_1_Freq;
		Settings.Default._3_SKILLBUFF_2 = gclass17_0.SKILLBUFF_2;
		Settings.Default._3_SKILLBUFF_2_Freq = gclass17_0.SKILLBUFF_2_Freq;
		Settings.Default._3_SKILLBUFF_3 = gclass17_0.SKILLBUFF_3;
		Settings.Default._3_SKILLBUFF_3_Freq = gclass17_0.SKILLBUFF_3_Freq;
		Settings.Default._3_SKILLBUFF_4 = gclass17_0.SKILLBUFF_4;
		Settings.Default._3_SKILLBUFF_4_Freq = gclass17_0.SKILLBUFF_4_Freq;
		Settings.Default._3_SKILLBUFF_5 = gclass17_0.SKILLBUFF_5;
		Settings.Default._3_SKILLBUFF_5_Freq = gclass17_0.SKILLBUFF_5_Freq;
		Settings.Default._3_SKILLBUFF_6 = gclass17_0.SKILLBUFF_6;
		Settings.Default._3_SKILLBUFF_6_Freq = gclass17_0.SKILLBUFF_6_Freq;
		Settings.Default._3_Macro1_Freq = gclass17_0.Macro1_Freq;
		Settings.Default._3_Macro1_Hotkey = gclass17_0.Macro1_Hotkey;
		Settings.Default._3_Macro2_Freq = gclass17_0.Macro2_Freq;
		Settings.Default._3_Macro2_Hotkey = gclass17_0.Macro2_Hotkey;
		Settings.Default._3_Macro3_Freq = gclass17_0.Macro3_Freq;
		Settings.Default._3_Macro3_Hotkey = gclass17_0.Macro3_Hotkey;
		Settings.Default._3_Macro4_Freq = gclass17_0.Macro4_Freq;
		Settings.Default._3_Macro4_Hotkey = gclass17_0.Macro4_Hotkey;
		Settings.Default._3_Path_Map = gclass17_0.Path_Map;
		((SettingsBase)Settings.Default).Save();
	}

	private GClass17 method_22()
	{
		GClass17 gClass = new GClass17();
		gClass.CB_CardLoot = checkBox_32.get_Checked();
		gClass.CB_Autoloot = checkBox_0.get_Checked();
		gClass.CB_AutolootExpect = checkBox_13.get_Checked();
		gClass.CB_AutolootNearest = checkBox_28.get_Checked();
		gClass.CB_AttackExpect = checkBox_14.get_Checked();
		gClass.CB_AttackNearest = checkBox_38.get_Checked();
		gClass.CB_SP_Potion = checkBox_3.get_Checked();
		gClass.CB_SP_Potion_Bwing = checkBox_34.get_Checked();
		gClass.CB_HP_Potion = checkBox_5.get_Checked();
		gClass.CB_HP_Potion_Bwing = checkBox_33.get_Checked();
		gClass.CB_HP_Skill = checkBox_7.get_Checked();
		gClass.CB_WingNotFound = checkBox_6.get_Checked();
		gClass.CB_TeleportNotFound = checkBox_4.get_Checked();
		gClass.CB_RandomWalkNotFound = checkBox_2.get_Checked();
		gClass.CB_WalkNotFound = checkBox_30.get_Checked();
		gClass.CB_Monster_Escape = checkBox_23.get_Checked();
		gClass.CB_Scrum_Escape = checkBox_26.get_Checked();
		gClass.CB_HP_Escape = checkBox_17.get_Checked();
		gClass.CB_EscapePeopleWait = checkBox_25.get_Checked();
		gClass.CB_EscapeWarp = checkBox_35.get_Checked();
		gClass.CB_AlertSound = checkBox_39.get_Checked();
		gClass.CB_Jam = checkBox_29.get_Checked();
		gClass.CB__ATK_Skill = checkBox_8.get_Checked();
		gClass.CB_ATK_Floor_Skill = checkBox_36.get_Checked();
		gClass.CB_AB_Skill = checkBox_9.get_Checked();
		gClass.CB_SkillBuff_1 = checkBox_10.get_Checked();
		gClass.CB_SkillBuff_2 = checkBox_18.get_Checked();
		gClass.CB_SkillBuff_3 = checkBox_19.get_Checked();
		gClass.CB_SkillBuff_4 = checkBox_20.get_Checked();
		gClass.CB_SkillBuff_5 = checkBox_21.get_Checked();
		gClass.CB_SkillBuff_6 = checkBox_22.get_Checked();
		gClass.CB_Macro1 = checkBox_12.get_Checked();
		gClass.CB_Macro2 = checkBox_11.get_Checked();
		gClass.CB_Macro3 = checkBox_15.get_Checked();
		gClass.CB_Macro4 = checkBox_27.get_Checked();
		gClass.CB_Buff_Safety = checkBox_40.get_Checked();
		gClass.CB_HP_Sitdown = checkBox_31.get_Checked();
		gClass.CB_SP_Sitdown = checkBox_16.get_Checked();
		gClass.CB_ExitOverWeight = checkBox_1.get_Checked();
		gClass.CB_ExitOnDead = checkBox_24.get_Checked();
		gClass.CB_ExitOnGM = checkBox_37.get_Checked();
		gClass.CB_AlertLine = checkBox_41.get_Checked();
		gClass.HP_Percent = Settings.Default._3_HP_Percent;
		gClass.HP_Hotkey = Settings.Default._3_HP_Hotkey;
		gClass.HP_Escape = Settings.Default._3_HP_Escape;
		gClass.Scrum_Escape = Settings.Default._3_Scrum_Escape;
		gClass.HP_Sitdown = Settings.Default._3_HP_Sitdown;
		gClass.SP_Percent = Settings.Default._3_SP_Percent;
		gClass.SP_Hotkey = Settings.Default._3_SP_Hotkey;
		gClass.SP_Sitdown = Settings.Default._3_SP_Sitdown;
		gClass.Wing_Hotkey = Settings.Default._3_Wing_Hotkey;
		gClass.BWing_Hotkey = Settings.Default._3_BWing_Hotkey;
		gClass.Over_Weight = Settings.Default._3_Over_Weight;
		gClass.ATK_Skill_Mode = Settings.Default._3_ATK_Skill_Mode;
		gClass.ATK_Skill = Settings.Default._3_ATK_Skill;
		gClass.ATK_Skill_Lv = Settings.Default._3_ATK_Skill_Lv;
		gClass.ATK_Floor_Skill_Mode = Settings.Default._3_ATK_Floor_Skill_Mode;
		gClass.ATK_Floor_Skill = Settings.Default._3_ATK_Floor_Skill;
		gClass.ATK_Floor_Skill_Lv = Settings.Default._3_ATK_Floor_Skill_Lv;
		gClass.ATK_Floor_Skill_X = Settings.Default._3_ATK_Floor_Skill_X;
		gClass.ATK_Floor_Skill_Y = Settings.Default._3_ATK_Floor_Skill_Y;
		gClass.ATK_Floor_Freq = Settings.Default._3_ATK_Floor_Freq;
		gClass.AB_Freq = Settings.Default._3_AB_Freq;
		gClass.SKILLBUFF_1 = Settings.Default._3_SKILLBUFF_1;
		gClass.SKILLBUFF_1_Freq = Settings.Default._3_SKILLBUFF_1_Freq;
		gClass.SKILLBUFF_2 = Settings.Default._3_SKILLBUFF_2;
		gClass.SKILLBUFF_2_Freq = Settings.Default._3_SKILLBUFF_2_Freq;
		gClass.SKILLBUFF_3 = Settings.Default._3_SKILLBUFF_3;
		gClass.SKILLBUFF_3_Freq = Settings.Default._3_SKILLBUFF_3_Freq;
		gClass.SKILLBUFF_4 = Settings.Default._3_SKILLBUFF_4;
		gClass.SKILLBUFF_4_Freq = Settings.Default._3_SKILLBUFF_4_Freq;
		gClass.SKILLBUFF_5 = Settings.Default._3_SKILLBUFF_5;
		gClass.SKILLBUFF_5_Freq = Settings.Default._3_SKILLBUFF_5_Freq;
		gClass.SKILLBUFF_6 = Settings.Default._3_SKILLBUFF_6;
		gClass.SKILLBUFF_6_Freq = Settings.Default._3_SKILLBUFF_6_Freq;
		gClass.Macro1_Freq = Settings.Default._3_Macro1_Freq;
		gClass.Macro1_Hotkey = Settings.Default._3_Macro1_Hotkey;
		gClass.Macro2_Freq = Settings.Default._3_Macro2_Freq;
		gClass.Macro2_Hotkey = Settings.Default._3_Macro2_Hotkey;
		gClass.Macro3_Freq = Settings.Default._3_Macro3_Freq;
		gClass.Macro3_Hotkey = Settings.Default._3_Macro3_Hotkey;
		gClass.Macro4_Freq = Settings.Default._3_Macro4_Freq;
		gClass.Macro4_Hotkey = Settings.Default._3_Macro4_Hotkey;
		gClass.Path_Map = Settings.Default._3_Path_Map;
		return gClass;
	}

	private double method_23(GClass7 gclass7_0, GClass7 gclass7_1)
	{
		return Math.Pow(gclass7_1.int_0 - gclass7_0.int_0, 2.0) + Math.Pow(gclass7_1.int_1 - gclass7_0.int_1, 2.0);
	}

	private double method_24(Point point_1, Point point_2)
	{
		return Math.Pow(point_2.X - point_1.X, 2.0) + Math.Pow(point_2.Y - point_1.Y, 2.0);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_25()
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
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
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
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected O, but got Unknown
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected O, but got Unknown
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected O, but got Unknown
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected O, but got Unknown
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected O, but got Unknown
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected O, but got Unknown
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Expected O, but got Unknown
		//IL_098f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Expected O, but got Unknown
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Expected O, but got Unknown
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Expected O, but got Unknown
		//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Expected O, but got Unknown
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aea: Expected O, but got Unknown
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Expected O, but got Unknown
		//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Expected O, but got Unknown
		//IL_0b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Expected O, but got Unknown
		//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cce: Expected O, but got Unknown
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Expected O, but got Unknown
		//IL_0da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3e: Expected O, but got Unknown
		//IL_0e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef6: Expected O, but got Unknown
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb8: Expected O, but got Unknown
		//IL_0fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1008: Unknown result type (might be due to invalid IL or missing references)
		//IL_1076: Unknown result type (might be due to invalid IL or missing references)
		//IL_1080: Expected O, but got Unknown
		//IL_1092: Unknown result type (might be due to invalid IL or missing references)
		//IL_109c: Expected O, but got Unknown
		//IL_14c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d3: Expected O, but got Unknown
		//IL_14ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_152a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1534: Expected O, but got Unknown
		//IL_1546: Unknown result type (might be due to invalid IL or missing references)
		//IL_1550: Expected O, but got Unknown
		//IL_1562: Unknown result type (might be due to invalid IL or missing references)
		//IL_156c: Expected O, but got Unknown
		//IL_157e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1588: Expected O, but got Unknown
		//IL_159a: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a4: Expected O, but got Unknown
		//IL_15b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c0: Expected O, but got Unknown
		//IL_15d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15dc: Expected O, but got Unknown
		//IL_15ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f8: Expected O, but got Unknown
		//IL_160a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1614: Expected O, but got Unknown
		//IL_1626: Unknown result type (might be due to invalid IL or missing references)
		//IL_1630: Expected O, but got Unknown
		//IL_1642: Unknown result type (might be due to invalid IL or missing references)
		//IL_164c: Expected O, but got Unknown
		//IL_165e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1668: Expected O, but got Unknown
		//IL_167a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1684: Expected O, but got Unknown
		//IL_1696: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a0: Expected O, but got Unknown
		//IL_16b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bc: Expected O, but got Unknown
		//IL_16ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d8: Expected O, but got Unknown
		//IL_16ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f4: Expected O, but got Unknown
		//IL_1706: Unknown result type (might be due to invalid IL or missing references)
		//IL_1710: Expected O, but got Unknown
		//IL_1722: Unknown result type (might be due to invalid IL or missing references)
		//IL_172c: Expected O, but got Unknown
		//IL_173e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1748: Expected O, but got Unknown
		//IL_175a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1764: Expected O, but got Unknown
		//IL_17bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c9: Expected O, but got Unknown
		//IL_17ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1899: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a3: Expected O, but got Unknown
		//IL_18c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1973: Unknown result type (might be due to invalid IL or missing references)
		//IL_197d: Expected O, but got Unknown
		//IL_19a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a57: Expected O, but got Unknown
		//IL_1a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b31: Expected O, but got Unknown
		//IL_1b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0b: Expected O, but got Unknown
		//IL_1c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce5: Expected O, but got Unknown
		//IL_1d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbf: Expected O, but got Unknown
		//IL_1de3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e99: Expected O, but got Unknown
		//IL_1eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f66: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f70: Expected O, but got Unknown
		//IL_1f91: Unknown result type (might be due to invalid IL or missing references)
		//IL_203d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2047: Expected O, but got Unknown
		//IL_2068: Unknown result type (might be due to invalid IL or missing references)
		//IL_2114: Unknown result type (might be due to invalid IL or missing references)
		//IL_211e: Expected O, but got Unknown
		//IL_213f: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f6: Expected O, but got Unknown
		//IL_2216: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_22cc: Expected O, but got Unknown
		//IL_22e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2396: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a0: Expected O, but got Unknown
		//IL_23bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_246c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2476: Expected O, but got Unknown
		//IL_2493: Unknown result type (might be due to invalid IL or missing references)
		//IL_2542: Unknown result type (might be due to invalid IL or missing references)
		//IL_254c: Expected O, but got Unknown
		//IL_2579: Unknown result type (might be due to invalid IL or missing references)
		//IL_2622: Unknown result type (might be due to invalid IL or missing references)
		//IL_262c: Expected O, but got Unknown
		//IL_2648: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_26fc: Expected O, but got Unknown
		//IL_271d: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_27d1: Expected O, but got Unknown
		//IL_27f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_289d: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a7: Expected O, but got Unknown
		//IL_28c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2973: Unknown result type (might be due to invalid IL or missing references)
		//IL_297d: Expected O, but got Unknown
		//IL_299d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a56: Expected O, but got Unknown
		//IL_2a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b2f: Expected O, but got Unknown
		//IL_2b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c08: Expected O, but got Unknown
		//IL_2c28: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ce1: Expected O, but got Unknown
		//IL_2d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_2daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2db9: Expected O, but got Unknown
		//IL_2dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e91: Expected O, but got Unknown
		//IL_2eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f69: Expected O, but got Unknown
		//IL_2f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_3035: Unknown result type (might be due to invalid IL or missing references)
		//IL_303f: Expected O, but got Unknown
		//IL_305f: Unknown result type (might be due to invalid IL or missing references)
		//IL_310e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3118: Expected O, but got Unknown
		//IL_3138: Unknown result type (might be due to invalid IL or missing references)
		//IL_31e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ee: Expected O, but got Unknown
		//IL_320e: Unknown result type (might be due to invalid IL or missing references)
		//IL_32bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_32c7: Expected O, but got Unknown
		//IL_32e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3393: Unknown result type (might be due to invalid IL or missing references)
		//IL_339d: Expected O, but got Unknown
		//IL_33ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_3464: Unknown result type (might be due to invalid IL or missing references)
		//IL_346e: Expected O, but got Unknown
		//IL_348e: Unknown result type (might be due to invalid IL or missing references)
		//IL_353d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3547: Expected O, but got Unknown
		//IL_356b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3616: Unknown result type (might be due to invalid IL or missing references)
		//IL_3620: Expected O, but got Unknown
		//IL_3644: Unknown result type (might be due to invalid IL or missing references)
		//IL_36ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_36f8: Expected O, but got Unknown
		//IL_371c: Unknown result type (might be due to invalid IL or missing references)
		//IL_37c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_37d2: Expected O, but got Unknown
		//IL_37f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_38a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_38aa: Expected O, but got Unknown
		//IL_38ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_397b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3985: Expected O, but got Unknown
		//IL_39a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a60: Expected O, but got Unknown
		//IL_3a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_3df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e77: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4019: Unknown result type (might be due to invalid IL or missing references)
		//IL_409d: Unknown result type (might be due to invalid IL or missing references)
		//IL_412c: Unknown result type (might be due to invalid IL or missing references)
		//IL_418e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4198: Expected O, but got Unknown
		//IL_41aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_41b4: Expected O, but got Unknown
		//IL_420e: Unknown result type (might be due to invalid IL or missing references)
		//IL_424a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4254: Expected O, but got Unknown
		//IL_4266: Unknown result type (might be due to invalid IL or missing references)
		//IL_4270: Expected O, but got Unknown
		//IL_42f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_42fa: Expected O, but got Unknown
		//IL_432a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4400: Unknown result type (might be due to invalid IL or missing references)
		//IL_440a: Expected O, but got Unknown
		//IL_4436: Unknown result type (might be due to invalid IL or missing references)
		//IL_44d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_44e2: Expected O, but got Unknown
		//IL_4556: Unknown result type (might be due to invalid IL or missing references)
		//IL_49da: Unknown result type (might be due to invalid IL or missing references)
		//IL_49e4: Expected O, but got Unknown
		//IL_49f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_49ff: Expected O, but got Unknown
		//IL_4a0d: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm7));
		tableLayoutPanel_0 = new TableLayoutPanel();
		tabControl_0 = new TabControl();
		tabPage_0 = new TabPage();
		tableLayoutPanel_2 = new TableLayoutPanel();
		groupBox_1 = new GroupBox();
		tableLayoutPanel_4 = new TableLayoutPanel();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		label_5 = new Label();
		groupBox_0 = new GroupBox();
		tableLayoutPanel_3 = new TableLayoutPanel();
		checkBox_27 = new CheckBox();
		checkBox_15 = new CheckBox();
		checkBox_11 = new CheckBox();
		checkBox_12 = new CheckBox();
		checkBox_22 = new CheckBox();
		checkBox_21 = new CheckBox();
		checkBox_20 = new CheckBox();
		checkBox_19 = new CheckBox();
		checkBox_18 = new CheckBox();
		checkBox_10 = new CheckBox();
		checkBox_9 = new CheckBox();
		checkBox_8 = new CheckBox();
		checkBox_29 = new CheckBox();
		checkBox_14 = new CheckBox();
		checkBox_28 = new CheckBox();
		checkBox_13 = new CheckBox();
		checkBox_0 = new CheckBox();
		checkBox_32 = new CheckBox();
		checkBox_36 = new CheckBox();
		checkBox_35 = new CheckBox();
		checkBox_25 = new CheckBox();
		checkBox_17 = new CheckBox();
		checkBox_26 = new CheckBox();
		checkBox_23 = new CheckBox();
		checkBox_30 = new CheckBox();
		checkBox_2 = new CheckBox();
		checkBox_4 = new CheckBox();
		checkBox_6 = new CheckBox();
		checkBox_7 = new CheckBox();
		checkBox_33 = new CheckBox();
		checkBox_5 = new CheckBox();
		checkBox_34 = new CheckBox();
		checkBox_3 = new CheckBox();
		checkBox_38 = new CheckBox();
		checkBox_39 = new CheckBox();
		checkBox_1 = new CheckBox();
		checkBox_16 = new CheckBox();
		checkBox_31 = new CheckBox();
		checkBox_24 = new CheckBox();
		checkBox_37 = new CheckBox();
		checkBox_40 = new CheckBox();
		checkBox_41 = new CheckBox();
		tabPage_1 = new TabPage();
		gcontrol5_0 = new GControl5();
		tabPage_2 = new TabPage();
		gcontrol0_0 = new GControl0();
		tabPage_3 = new TabPage();
		gcontrol1_0 = new GControl1();
		tabPage_4 = new TabPage();
		gcontrol2_0 = new GControl2();
		tabPage_5 = new TabPage();
		gcontrol4_0 = new GControl4();
		tabPage_6 = new TabPage();
		gcontrol3_0 = new GControl3();
		tableLayoutPanel_1 = new TableLayoutPanel();
		button_0 = new Button();
		button_1 = new Button();
		menuStrip_0 = new MenuStrip();
		toolStripMenuItem_0 = new ToolStripMenuItem();
		toolStripMenuItem_11 = new ToolStripMenuItem();
		toolStripMenuItem_12 = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		toolStripMenuItem_2 = new ToolStripMenuItem();
		toolStripMenuItem_3 = new ToolStripMenuItem();
		toolStripMenuItem_10 = new ToolStripMenuItem();
		toolStripMenuItem_4 = new ToolStripMenuItem();
		toolStripMenuItem_8 = new ToolStripMenuItem();
		toolStripMenuItem_9 = new ToolStripMenuItem();
		toolStripMenuItem_5 = new ToolStripMenuItem();
		toolStripMenuItem_6 = new ToolStripMenuItem();
		toolStripMenuItem_7 = new ToolStripMenuItem();
		saveFileDialog_0 = new SaveFileDialog();
		openFileDialog_0 = new OpenFileDialog();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((Control)tabControl_0).SuspendLayout();
		((Control)tabPage_0).SuspendLayout();
		((Control)tableLayoutPanel_2).SuspendLayout();
		((Control)groupBox_1).SuspendLayout();
		((Control)tableLayoutPanel_4).SuspendLayout();
		((Control)groupBox_0).SuspendLayout();
		((Control)tableLayoutPanel_3).SuspendLayout();
		((Control)tabPage_1).SuspendLayout();
		((Control)tabPage_2).SuspendLayout();
		((Control)tabPage_3).SuspendLayout();
		((Control)tabPage_4).SuspendLayout();
		((Control)tabPage_5).SuspendLayout();
		((Control)tabPage_6).SuspendLayout();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)menuStrip_0).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)tableLayoutPanel_0).set_BackColor(Color.DarkSlateGray);
		tableLayoutPanel_0.set_ColumnCount(1);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tabControl_0, 0, 0);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_1, 0, 1);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Location(new Point(0, 26));
		((Control)tableLayoutPanel_0).set_Margin(new Padding(4));
		((Control)tableLayoutPanel_0).set_Name(Class60.smethod_0(-2050208027));
		tableLayoutPanel_0.set_RowCount(2);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 94f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 6f));
		((Control)tableLayoutPanel_0).set_Size(new Size(409, 635));
		((Control)tableLayoutPanel_0).set_TabIndex(0);
		((Control)tabControl_0).get_Controls().Add((Control)(object)tabPage_0);
		((Control)tabControl_0).get_Controls().Add((Control)(object)tabPage_1);
		((Control)tabControl_0).get_Controls().Add((Control)(object)tabPage_2);
		((Control)tabControl_0).get_Controls().Add((Control)(object)tabPage_3);
		((Control)tabControl_0).get_Controls().Add((Control)(object)tabPage_4);
		((Control)tabControl_0).get_Controls().Add((Control)(object)tabPage_5);
		((Control)tabControl_0).get_Controls().Add((Control)(object)tabPage_6);
		((Control)tabControl_0).set_Dock((DockStyle)5);
		tabControl_0.set_DrawMode((TabDrawMode)1);
		tabControl_0.set_ItemSize(new Size(0, 1));
		((Control)tabControl_0).set_Location(new Point(3, 3));
		((Control)tabControl_0).set_Name(Class60.smethod_0(-2050206971));
		tabControl_0.set_SelectedIndex(0);
		((Control)tabControl_0).set_Size(new Size(403, 590));
		((Control)tabControl_0).set_TabIndex(1);
		((Control)tabPage_0).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_0).get_Controls().Add((Control)(object)tableLayoutPanel_2);
		tabPage_0.set_Location(new Point(4, 5));
		((Control)tabPage_0).set_Margin(new Padding(0));
		((Control)tabPage_0).set_Name(Class60.smethod_0(-2050206998));
		((Control)tabPage_0).set_Size(new Size(395, 581));
		tabPage_0.set_TabIndex(0);
		((Control)tabPage_0).set_Text(Class60.smethod_0(-2050206984));
		tableLayoutPanel_2.set_ColumnCount(1);
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_2.get_Controls().Add((Control)(object)groupBox_1, 0, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)groupBox_0, 0, 1);
		((Control)tableLayoutPanel_2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_2).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_2).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_2).set_Name(Class60.smethod_0(-2050206985));
		tableLayoutPanel_2.set_RowCount(2);
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 90f));
		((Control)tableLayoutPanel_2).set_Size(new Size(395, 581));
		((Control)tableLayoutPanel_2).set_TabIndex(0);
		((Control)groupBox_1).get_Controls().Add((Control)(object)tableLayoutPanel_4);
		((Control)groupBox_1).set_Dock((DockStyle)5);
		((Control)groupBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)groupBox_1).set_ForeColor(SystemColors.Control);
		((Control)groupBox_1).set_Location(new Point(0, 0));
		((Control)groupBox_1).set_Margin(new Padding(0));
		((Control)groupBox_1).set_Name(Class60.smethod_0(-2050210886));
		((Control)groupBox_1).set_Padding(new Padding(3, 0, 3, 3));
		((Control)groupBox_1).set_Size(new Size(395, 58));
		((Control)groupBox_1).set_TabIndex(3);
		groupBox_1.set_TabStop(false);
		((Control)groupBox_1).set_Text(Class60.smethod_0(-2050207009));
		tableLayoutPanel_4.set_ColumnCount(6);
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 9f));
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 27f));
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 10f));
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 22f));
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 10f));
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 22f));
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_0, 1, 1);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_1, 0, 1);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_2, 3, 1);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_3, 2, 1);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_4, 5, 1);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_5, 4, 1);
		((Control)tableLayoutPanel_4).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_4).set_Location(new Point(3, 19));
		((Control)tableLayoutPanel_4).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_4).set_Name(Class60.smethod_0(-2050211375));
		tableLayoutPanel_4.set_RowCount(2);
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 5f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 95f));
		((Control)tableLayoutPanel_4).set_Size(new Size(389, 36));
		((Control)tableLayoutPanel_4).set_TabIndex(9);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Dock((DockStyle)3);
		((Control)label_0).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_Location(new Point(35, 1));
		((Control)label_0).set_Margin(new Padding(0));
		((Control)label_0).set_Name(Class60.smethod_0(-2050207056));
		((Control)label_0).set_Size(new Size(33, 35));
		((Control)label_0).set_TabIndex(1);
		((Control)label_0).set_Text(Class60.smethod_0(-2050207089));
		label_0.set_TextAlign((ContentAlignment)16);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Dock((DockStyle)4);
		((Control)label_1).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_Location(new Point(7, 1));
		((Control)label_1).set_Margin(new Padding(0));
		((Control)label_1).set_Name(Class60.smethod_0(-2050208088));
		((Control)label_1).set_Size(new Size(28, 35));
		((Control)label_1).set_TabIndex(0);
		((Control)label_1).set_Text(Class60.smethod_0(-2050207086));
		label_1.set_TextAlign((ContentAlignment)64);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Dock((DockStyle)3);
		((Control)label_2).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_2).set_Location(new Point(178, 1));
		((Control)label_2).set_Margin(new Padding(0));
		((Control)label_2).set_Name(Class60.smethod_0(-2050207131));
		((Control)label_2).set_Size(new Size(28, 35));
		((Control)label_2).set_TabIndex(5);
		((Control)label_2).set_Text(Class60.smethod_0(-2050207118));
		label_2.set_TextAlign((ContentAlignment)16);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Dock((DockStyle)4);
		((Control)label_3).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_3).set_Location(new Point(146, 1));
		((Control)label_3).set_Margin(new Padding(0));
		((Control)label_3).set_Name(Class60.smethod_0(-2050207156));
		((Control)label_3).set_Size(new Size(32, 35));
		((Control)label_3).set_TabIndex(3);
		((Control)label_3).set_Text(Class60.smethod_0(-2050207143));
		label_3.set_TextAlign((ContentAlignment)64);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Dock((DockStyle)3);
		((Control)label_4).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_4).set_Location(new Point(301, 1));
		((Control)label_4).set_Margin(new Padding(0));
		((Control)label_4).set_Name(Class60.smethod_0(-2050207148));
		((Control)label_4).set_Size(new Size(28, 35));
		((Control)label_4).set_TabIndex(8);
		((Control)label_4).set_Text(Class60.smethod_0(-2050207118));
		label_4.set_TextAlign((ContentAlignment)16);
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_Dock((DockStyle)4);
		((Control)label_5).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_5).set_Location(new Point(269, 1));
		((Control)label_5).set_Margin(new Padding(0));
		((Control)label_5).set_Name(Class60.smethod_0(-2050207199));
		((Control)label_5).set_Size(new Size(32, 35));
		((Control)label_5).set_TabIndex(6);
		((Control)label_5).set_Text(Class60.smethod_0(-2050207170));
		label_5.set_TextAlign((ContentAlignment)16);
		((Control)groupBox_0).get_Controls().Add((Control)(object)tableLayoutPanel_3);
		((Control)groupBox_0).set_Dock((DockStyle)5);
		((Control)groupBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)groupBox_0).set_ForeColor(SystemColors.Control);
		((Control)groupBox_0).set_Location(new Point(0, 58));
		((Control)groupBox_0).set_Margin(new Padding(0));
		((Control)groupBox_0).set_Name(Class60.smethod_0(-2050207223));
		((Control)groupBox_0).set_Padding(new Padding(4));
		((Control)groupBox_0).set_Size(new Size(395, 523));
		((Control)groupBox_0).set_TabIndex(1);
		groupBox_0.set_TabStop(false);
		((Control)groupBox_0).set_Text(Class60.smethod_0(-2050207207));
		tableLayoutPanel_3.set_ColumnCount(2);
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 55f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 45f));
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_27, 1, 13);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_15, 1, 12);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_11, 1, 11);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_12, 1, 10);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_22, 1, 9);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_21, 1, 8);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_20, 1, 7);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_19, 1, 6);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_18, 1, 5);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_10, 1, 4);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_9, 1, 3);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_8, 1, 1);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_29, 1, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_14, 0, 4);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_28, 0, 3);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_13, 0, 2);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_0, 0, 1);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_32, 0, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_36, 1, 2);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_35, 0, 19);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_25, 0, 18);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_17, 0, 17);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_26, 0, 16);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_23, 0, 15);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_30, 0, 14);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_2, 0, 13);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_4, 0, 12);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_6, 0, 11);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_7, 0, 10);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_33, 0, 9);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_5, 0, 8);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_34, 0, 7);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_3, 0, 6);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_38, 0, 5);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_39, 0, 20);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_1, 1, 17);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_16, 1, 16);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_31, 1, 15);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_24, 1, 18);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_37, 1, 19);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_40, 1, 14);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_41, 1, 20);
		((Control)tableLayoutPanel_3).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)tableLayoutPanel_3).set_Location(new Point(4, 23));
		((Control)tableLayoutPanel_3).set_Margin(new Padding(4));
		((Control)tableLayoutPanel_3).set_Name(Class60.smethod_0(-2050211088));
		tableLayoutPanel_3.set_RowCount(21);
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.963143f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.963143f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.963143f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.963143f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.963143f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.963143f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.963143f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.717444f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.717444f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.717444f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.717444f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.717444f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.717444f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.717444f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.717444f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.717444f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.717444f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.717444f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.717444f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.717444f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 3.931203f));
		((Control)tableLayoutPanel_3).set_Size(new Size(387, 496));
		((Control)tableLayoutPanel_3).set_TabIndex(0);
		((Control)checkBox_27).set_AutoSize(true);
		((Control)checkBox_27).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_27).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_27).set_Location(new Point(215, 306));
		((Control)checkBox_27).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_27).set_Name(Class60.smethod_0(-2050200782));
		((Control)checkBox_27).set_Size(new Size(85, 20));
		((Control)checkBox_27).set_TabIndex(33);
		((Control)checkBox_27).set_Text(Class60.smethod_0(-2050200830));
		((ButtonBase)checkBox_27).set_UseVisualStyleBackColor(true);
		checkBox_27.add_CheckedChanged((EventHandler)checkBox_27_CheckedChanged);
		((Control)checkBox_15).set_AutoSize(true);
		((Control)checkBox_15).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_15).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_15).set_Location(new Point(215, 283));
		((Control)checkBox_15).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_15).set_Name(Class60.smethod_0(-2050200761));
		((Control)checkBox_15).set_Size(new Size(85, 20));
		((Control)checkBox_15).set_TabIndex(21);
		((Control)checkBox_15).set_Text(Class60.smethod_0(-2050200745));
		((ButtonBase)checkBox_15).set_UseVisualStyleBackColor(true);
		checkBox_15.add_CheckedChanged((EventHandler)checkBox_15_CheckedChanged);
		((Control)checkBox_11).set_AutoSize(true);
		((Control)checkBox_11).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_11).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_11).set_Location(new Point(215, 260));
		((Control)checkBox_11).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_11).set_Name(Class60.smethod_0(-2050200724));
		((Control)checkBox_11).set_Size(new Size(85, 20));
		((Control)checkBox_11).set_TabIndex(12);
		((Control)checkBox_11).set_Text(Class60.smethod_0(-2050200708));
		((ButtonBase)checkBox_11).set_UseVisualStyleBackColor(true);
		checkBox_11.add_CheckedChanged((EventHandler)checkBox_11_CheckedChanged);
		((Control)checkBox_12).set_AutoSize(true);
		((Control)checkBox_12).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_12).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_12).set_Location(new Point(215, 237));
		((Control)checkBox_12).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_12).set_Name(Class60.smethod_0(-2050200655));
		((Control)checkBox_12).set_Size(new Size(85, 20));
		((Control)checkBox_12).set_TabIndex(13);
		((Control)checkBox_12).set_Text(Class60.smethod_0(-2050200703));
		((ButtonBase)checkBox_12).set_UseVisualStyleBackColor(true);
		checkBox_12.add_CheckedChanged((EventHandler)checkBox_12_CheckedChanged);
		((Control)checkBox_22).set_AutoSize(true);
		((Control)checkBox_22).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_22).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_22).set_Location(new Point(215, 214));
		((Control)checkBox_22).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_22).set_Name(Class60.smethod_0(-2050200627));
		((Control)checkBox_22).set_Size(new Size(89, 20));
		((Control)checkBox_22).set_TabIndex(26);
		((Control)checkBox_22).set_Text(Class60.smethod_0(-2050200622));
		((ButtonBase)checkBox_22).set_UseVisualStyleBackColor(true);
		checkBox_22.add_CheckedChanged((EventHandler)checkBox_22_CheckedChanged);
		((Control)checkBox_21).set_AutoSize(true);
		((Control)checkBox_21).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_21).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_21).set_Location(new Point(215, 191));
		((Control)checkBox_21).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_21).set_Name(Class60.smethod_0(-2050206695));
		((Control)checkBox_21).set_Size(new Size(89, 20));
		((Control)checkBox_21).set_TabIndex(25);
		((Control)checkBox_21).set_Text(Class60.smethod_0(-2050200594));
		((ButtonBase)checkBox_21).set_UseVisualStyleBackColor(true);
		checkBox_21.add_CheckedChanged((EventHandler)checkBox_21_CheckedChanged);
		((Control)checkBox_20).set_AutoSize(true);
		((Control)checkBox_20).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_20).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_20).set_Location(new Point(215, 168));
		((Control)checkBox_20).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_20).set_Name(Class60.smethod_0(-2050206635));
		((Control)checkBox_20).set_Size(new Size(89, 20));
		((Control)checkBox_20).set_TabIndex(24);
		((Control)checkBox_20).set_Text(Class60.smethod_0(-2050206662));
		((ButtonBase)checkBox_20).set_UseVisualStyleBackColor(true);
		checkBox_20.add_CheckedChanged((EventHandler)checkBox_20_CheckedChanged);
		((Control)checkBox_19).set_AutoSize(true);
		((Control)checkBox_19).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_19).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_19).set_Location(new Point(215, 144));
		((Control)checkBox_19).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_19).set_Name(Class60.smethod_0(-2050206623));
		((Control)checkBox_19).set_Size(new Size(89, 20));
		((Control)checkBox_19).set_TabIndex(23);
		((Control)checkBox_19).set_Text(Class60.smethod_0(-2050206602));
		((ButtonBase)checkBox_19).set_UseVisualStyleBackColor(true);
		checkBox_19.add_CheckedChanged((EventHandler)checkBox_19_CheckedChanged);
		((Control)checkBox_18).set_AutoSize(true);
		((Control)checkBox_18).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_18).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_18).set_Location(new Point(215, 120));
		((Control)checkBox_18).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_18).set_Name(Class60.smethod_0(-2050206531));
		((Control)checkBox_18).set_Size(new Size(89, 20));
		((Control)checkBox_18).set_TabIndex(22);
		((Control)checkBox_18).set_Text(Class60.smethod_0(-2050206590));
		((ButtonBase)checkBox_18).set_UseVisualStyleBackColor(true);
		checkBox_18.add_CheckedChanged((EventHandler)checkBox_18_CheckedChanged);
		((Control)checkBox_10).set_AutoSize(true);
		((Control)checkBox_10).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_10).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_10).set_Location(new Point(215, 96));
		((Control)checkBox_10).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_10).set_Name(Class60.smethod_0(-2050206519));
		((Control)checkBox_10).set_Size(new Size(89, 20));
		((Control)checkBox_10).set_TabIndex(11);
		((Control)checkBox_10).set_Text(Class60.smethod_0(-2050206498));
		((ButtonBase)checkBox_10).set_UseVisualStyleBackColor(true);
		checkBox_10.add_CheckedChanged((EventHandler)checkBox_10_CheckedChanged);
		((Control)checkBox_9).set_AutoSize(true);
		((Control)checkBox_9).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_9).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_9).set_Location(new Point(215, 72));
		((Control)checkBox_9).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_9).set_Name(Class60.smethod_0(-2050207282));
		((Control)checkBox_9).set_Size(new Size(99, 20));
		((Control)checkBox_9).set_TabIndex(10);
		((Control)checkBox_9).set_Text(Class60.smethod_0(-2050207280));
		((ButtonBase)checkBox_9).set_UseVisualStyleBackColor(true);
		checkBox_9.add_CheckedChanged((EventHandler)checkBox_9_CheckedChanged);
		((Control)checkBox_8).set_AutoSize(true);
		((Control)checkBox_8).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_8).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_8).set_Location(new Point(215, 24));
		((Control)checkBox_8).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_8).set_Name(Class60.smethod_0(-2050207311));
		((Control)checkBox_8).set_Size(new Size(148, 20));
		((Control)checkBox_8).set_TabIndex(9);
		((Control)checkBox_8).set_Text(Class60.smethod_0(-2050207355));
		((ButtonBase)checkBox_8).set_UseVisualStyleBackColor(true);
		checkBox_8.add_CheckedChanged((EventHandler)checkBox_8_CheckedChanged);
		((Control)checkBox_29).set_AutoSize(true);
		((Control)checkBox_29).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_29).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_29).set_Location(new Point(215, 0));
		((Control)checkBox_29).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_29).set_Name(Class60.smethod_0(-2050207433));
		((Control)checkBox_29).set_Size(new Size(97, 20));
		((Control)checkBox_29).set_TabIndex(36);
		((Control)checkBox_29).set_Text(Class60.smethod_0(-2050207484));
		((ButtonBase)checkBox_29).set_UseVisualStyleBackColor(true);
		checkBox_29.add_CheckedChanged((EventHandler)checkBox_29_CheckedChanged);
		((Control)checkBox_14).set_AutoSize(true);
		((Control)checkBox_14).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_14).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_14).set_Location(new Point(3, 96));
		((Control)checkBox_14).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_14).set_Name(Class60.smethod_0(-2050207519));
		((Control)checkBox_14).set_Size(new Size(180, 20));
		((Control)checkBox_14).set_TabIndex(19);
		((Control)checkBox_14).set_Text(Class60.smethod_0(-2050207497));
		((ButtonBase)checkBox_14).set_UseVisualStyleBackColor(true);
		checkBox_14.add_CheckedChanged((EventHandler)checkBox_14_CheckedChanged);
		((Control)checkBox_28).set_AutoSize(true);
		((Control)checkBox_28).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_28).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_28).set_Location(new Point(3, 72));
		((Control)checkBox_28).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_28).set_Name(Class60.smethod_0(-2050207566));
		((Control)checkBox_28).set_Size(new Size(132, 20));
		((Control)checkBox_28).set_TabIndex(35);
		((Control)checkBox_28).set_Text(Class60.smethod_0(-2050207589));
		((ButtonBase)checkBox_28).set_UseVisualStyleBackColor(true);
		checkBox_28.add_CheckedChanged((EventHandler)checkBox_28_CheckedChanged);
		((Control)checkBox_13).set_AutoSize(true);
		((Control)checkBox_13).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_13).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_13).set_Location(new Point(3, 48));
		((Control)checkBox_13).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_13).set_Name(Class60.smethod_0(-2050207672));
		((Control)checkBox_13).set_Size(new Size(176, 20));
		((Control)checkBox_13).set_TabIndex(18);
		((Control)checkBox_13).set_Text(Class60.smethod_0(-2050207664));
		((ButtonBase)checkBox_13).set_UseVisualStyleBackColor(true);
		checkBox_13.add_CheckedChanged((EventHandler)checkBox_13_CheckedChanged);
		((Control)checkBox_0).set_AutoSize(true);
		((Control)checkBox_0).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_0).set_ForeColor(SystemColors.Control);
		((Control)checkBox_0).set_Location(new Point(3, 24));
		((Control)checkBox_0).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_0).set_Name(Class60.smethod_0(-2050207717));
		((Control)checkBox_0).set_Size(new Size(106, 20));
		((Control)checkBox_0).set_TabIndex(0);
		((Control)checkBox_0).set_Text(Class60.smethod_0(-2050205715));
		((ButtonBase)checkBox_0).set_UseVisualStyleBackColor(true);
		checkBox_0.add_CheckedChanged((EventHandler)checkBox_0_CheckedChanged);
		((Control)checkBox_32).set_AutoSize(true);
		((Control)checkBox_32).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_32).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_32).set_Location(new Point(3, 0));
		((Control)checkBox_32).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_32).set_Name(Class60.smethod_0(-2050205758));
		((Control)checkBox_32).set_Size(new Size(72, 20));
		((Control)checkBox_32).set_TabIndex(39);
		((Control)checkBox_32).set_Text(Class60.smethod_0(-2050205740));
		((ButtonBase)checkBox_32).set_UseVisualStyleBackColor(true);
		checkBox_32.add_CheckedChanged((EventHandler)checkBox_32_CheckedChanged);
		((Control)checkBox_36).set_AutoSize(true);
		((Control)checkBox_36).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_36).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_36).set_Location(new Point(215, 48));
		((Control)checkBox_36).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_36).set_Name(Class60.smethod_0(-2050205763));
		((Control)checkBox_36).set_Size(new Size(118, 20));
		((Control)checkBox_36).set_TabIndex(43);
		((Control)checkBox_36).set_Text(Class60.smethod_0(-2050205818));
		((ButtonBase)checkBox_36).set_UseVisualStyleBackColor(true);
		checkBox_36.add_CheckedChanged((EventHandler)checkBox_36_CheckedChanged);
		((Control)checkBox_35).set_AutoSize(true);
		((Control)checkBox_35).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_35).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_35).set_Location(new Point(3, 444));
		((Control)checkBox_35).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_35).set_Name(Class60.smethod_0(-2050201097));
		((Control)checkBox_35).set_Size(new Size(68, 20));
		((Control)checkBox_35).set_TabIndex(42);
		((Control)checkBox_35).set_Text(Class60.smethod_0(-2050201125));
		((ButtonBase)checkBox_35).set_UseVisualStyleBackColor(true);
		checkBox_35.add_CheckedChanged((EventHandler)checkBox_35_CheckedChanged);
		((Control)checkBox_25).set_AutoSize(true);
		((Control)checkBox_25).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_25).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_25).set_Location(new Point(3, 421));
		((Control)checkBox_25).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_25).set_Name(Class60.smethod_0(-2050201182));
		((Control)checkBox_25).set_Size(new Size(59, 20));
		((Control)checkBox_25).set_TabIndex(32);
		((Control)checkBox_25).set_Text(Class60.smethod_0(-2050201204));
		((ButtonBase)checkBox_25).set_UseVisualStyleBackColor(true);
		checkBox_25.add_CheckedChanged((EventHandler)checkBox_25_CheckedChanged);
		((Control)checkBox_17).set_AutoSize(true);
		((Control)checkBox_17).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_17).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_17).set_Location(new Point(3, 398));
		((Control)checkBox_17).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_17).set_Name(Class60.smethod_0(-2050201187));
		((Control)checkBox_17).set_Size(new Size(134, 20));
		((Control)checkBox_17).set_TabIndex(30);
		((Control)checkBox_17).set_Text(Class60.smethod_0(-2050201248));
		((ButtonBase)checkBox_17).set_UseVisualStyleBackColor(true);
		checkBox_17.add_CheckedChanged((EventHandler)checkBox_17_CheckedChanged);
		((Control)checkBox_26).set_AutoSize(true);
		((Control)checkBox_26).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_26).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_26).set_Location(new Point(3, 375));
		((Control)checkBox_26).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_26).set_Name(Class60.smethod_0(-2050201259));
		((Control)checkBox_26).set_Size(new Size(128, 20));
		((Control)checkBox_26).set_TabIndex(34);
		((Control)checkBox_26).set_Text(Class60.smethod_0(-2050201285));
		((ButtonBase)checkBox_26).set_UseVisualStyleBackColor(true);
		checkBox_26.add_CheckedChanged((EventHandler)checkBox_26_CheckedChanged);
		((Control)checkBox_23).set_AutoSize(true);
		((Control)checkBox_23).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_23).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_23).set_Location(new Point(3, 352));
		((Control)checkBox_23).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_23).set_Name(Class60.smethod_0(-2050201366));
		((Control)checkBox_23).set_Size(new Size(136, 20));
		((Control)checkBox_23).set_TabIndex(27);
		((Control)checkBox_23).set_Text(Class60.smethod_0(-2050201358));
		((ButtonBase)checkBox_23).set_UseVisualStyleBackColor(true);
		checkBox_23.add_CheckedChanged((EventHandler)checkBox_23_CheckedChanged);
		((Control)checkBox_30).set_AutoSize(true);
		((Control)checkBox_30).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_30).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_30).set_Location(new Point(3, 329));
		((Control)checkBox_30).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_30).set_Name(Class60.smethod_0(-2050201425));
		((Control)checkBox_30).set_Size(new Size(206, 20));
		((Control)checkBox_30).set_TabIndex(37);
		((Control)checkBox_30).set_Text(Class60.smethod_0(-2050201419));
		((ButtonBase)checkBox_30).set_UseVisualStyleBackColor(true);
		checkBox_30.add_CheckedChanged((EventHandler)checkBox_30_CheckedChanged);
		((Control)checkBox_2).set_AutoSize(true);
		((Control)checkBox_2).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_2).set_Location(new Point(3, 306));
		((Control)checkBox_2).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_2).set_Name(Class60.smethod_0(-2050201536));
		((Control)checkBox_2).set_Size(new Size(162, 20));
		((Control)checkBox_2).set_TabIndex(5);
		((Control)checkBox_2).set_Text(Class60.smethod_0(-2050201556));
		((ButtonBase)checkBox_2).set_UseVisualStyleBackColor(true);
		checkBox_2.add_CheckedChanged((EventHandler)checkBox_2_CheckedChanged);
		((Control)checkBox_4).set_AutoSize(true);
		((Control)checkBox_4).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_4).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_4).set_Location(new Point(3, 283));
		((Control)checkBox_4).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_4).set_Name(Class60.smethod_0(-2050199573));
		((Control)checkBox_4).set_Size(new Size(180, 20));
		((Control)checkBox_4).set_TabIndex(3);
		((Control)checkBox_4).set_Text(Class60.smethod_0(-2050199563));
		((ButtonBase)checkBox_4).set_UseVisualStyleBackColor(true);
		checkBox_4.add_CheckedChanged((EventHandler)checkBox_4_CheckedChanged);
		((Control)checkBox_6).set_AutoSize(true);
		((Control)checkBox_6).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_6).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_6).set_Location(new Point(3, 260));
		((Control)checkBox_6).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_6).set_Name(Class60.smethod_0(-2050199626));
		((Control)checkBox_6).set_Size(new Size(138, 20));
		((Control)checkBox_6).set_TabIndex(1);
		((Control)checkBox_6).set_Text(Class60.smethod_0(-2050199652));
		((ButtonBase)checkBox_6).set_UseVisualStyleBackColor(true);
		checkBox_6.add_CheckedChanged((EventHandler)checkBox_6_CheckedChanged);
		((Control)checkBox_7).set_AutoSize(true);
		((Control)checkBox_7).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_7).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_7).set_Location(new Point(3, 237));
		((Control)checkBox_7).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_7).set_Name(Class60.smethod_0(-2050205839));
		((Control)checkBox_7).set_Size(new Size(162, 20));
		((Control)checkBox_7).set_TabIndex(8);
		((Control)checkBox_7).set_Text(Class60.smethod_0(-2050205885));
		((ButtonBase)checkBox_7).set_UseVisualStyleBackColor(true);
		checkBox_7.add_CheckedChanged((EventHandler)checkBox_7_CheckedChanged);
		((Control)checkBox_33).set_AutoSize(true);
		((Control)checkBox_33).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_33).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_33).set_Location(new Point(3, 214));
		((Control)checkBox_33).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_33).set_Name(Class60.smethod_0(-2050205938));
		((Control)checkBox_33).set_Size(new Size(152, 20));
		((Control)checkBox_33).set_TabIndex(40);
		((Control)checkBox_33).set_Text(Class60.smethod_0(-2050205929));
		((ButtonBase)checkBox_33).set_UseVisualStyleBackColor(true);
		checkBox_33.add_CheckedChanged((EventHandler)checkBox_33_CheckedChanged);
		((Control)checkBox_5).set_AutoSize(true);
		((Control)checkBox_5).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_5).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_5).set_Location(new Point(3, 191));
		((Control)checkBox_5).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_5).set_Name(Class60.smethod_0(-2050206000));
		((Control)checkBox_5).set_Size(new Size(148, 20));
		((Control)checkBox_5).set_TabIndex(2);
		((Control)checkBox_5).set_Text(Class60.smethod_0(-2050206045));
		((ButtonBase)checkBox_5).set_UseVisualStyleBackColor(true);
		checkBox_5.add_CheckedChanged((EventHandler)checkBox_5_CheckedChanged);
		((Control)checkBox_34).set_AutoSize(true);
		((Control)checkBox_34).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_34).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_34).set_Location(new Point(3, 168));
		((Control)checkBox_34).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_34).set_Name(Class60.smethod_0(-2050206102));
		((Control)checkBox_34).set_Size(new Size(151, 20));
		((Control)checkBox_34).set_TabIndex(41);
		((Control)checkBox_34).set_Text(Class60.smethod_0(-2050206093));
		((ButtonBase)checkBox_34).set_UseVisualStyleBackColor(true);
		checkBox_34.add_CheckedChanged((EventHandler)checkBox_34_CheckedChanged);
		((Control)checkBox_3).set_AutoSize(true);
		((Control)checkBox_3).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_3).set_Location(new Point(3, 144));
		((Control)checkBox_3).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_3).set_Name(Class60.smethod_0(-2050206148));
		((Control)checkBox_3).set_Size(new Size(149, 20));
		((Control)checkBox_3).set_TabIndex(4);
		((Control)checkBox_3).set_Text(Class60.smethod_0(-2050206193));
		((ButtonBase)checkBox_3).set_UseVisualStyleBackColor(true);
		checkBox_3.add_CheckedChanged((EventHandler)checkBox_3_CheckedChanged);
		((Control)checkBox_38).set_AutoSize(true);
		((Control)checkBox_38).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_38).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_38).set_Location(new Point(3, 120));
		((Control)checkBox_38).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_38).set_Name(Class60.smethod_0(-2050206220));
		((Control)checkBox_38).set_Size(new Size(121, 20));
		((Control)checkBox_38).set_TabIndex(45);
		((Control)checkBox_38).set_Text(Class60.smethod_0(-2050206245));
		((ButtonBase)checkBox_38).set_UseVisualStyleBackColor(true);
		checkBox_38.add_CheckedChanged((EventHandler)checkBox_38_CheckedChanged);
		((Control)checkBox_39).set_AutoSize(true);
		((Control)checkBox_39).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_39).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_39).set_Location(new Point(3, 467));
		((Control)checkBox_39).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_39).set_Name(Class60.smethod_0(-2050200966));
		((Control)checkBox_39).set_Size(new Size(142, 20));
		((Control)checkBox_39).set_TabIndex(46);
		((Control)checkBox_39).set_Text(Class60.smethod_0(-2050201010));
		((ButtonBase)checkBox_39).set_UseVisualStyleBackColor(true);
		checkBox_39.add_CheckedChanged((EventHandler)checkBox_39_CheckedChanged);
		((Control)checkBox_1).set_AutoSize(true);
		((Control)checkBox_1).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_1).set_Location(new Point(215, 398));
		((Control)checkBox_1).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_1).set_Name(Class60.smethod_0(-2050206284));
		((Control)checkBox_1).set_Size(new Size(123, 20));
		((Control)checkBox_1).set_TabIndex(7);
		((Control)checkBox_1).set_Text(Class60.smethod_0(-2050206308));
		((ButtonBase)checkBox_1).set_UseVisualStyleBackColor(true);
		checkBox_1.add_CheckedChanged((EventHandler)checkBox_1_CheckedChanged);
		((Control)checkBox_16).set_AutoSize(true);
		((Control)checkBox_16).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_16).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_16).set_Location(new Point(215, 375));
		((Control)checkBox_16).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_16).set_Name(Class60.smethod_0(-2050206385));
		((Control)checkBox_16).set_Size(new Size(98, 20));
		((Control)checkBox_16).set_TabIndex(29);
		((Control)checkBox_16).set_Text(Class60.smethod_0(-2050206381));
		((ButtonBase)checkBox_16).set_UseVisualStyleBackColor(true);
		checkBox_16.add_CheckedChanged((EventHandler)checkBox_16_CheckedChanged);
		((Control)checkBox_31).set_AutoSize(true);
		((Control)checkBox_31).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_31).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_31).set_Location(new Point(215, 352));
		((Control)checkBox_31).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_31).set_Name(Class60.smethod_0(-2050206452));
		((Control)checkBox_31).set_Size(new Size(99, 20));
		((Control)checkBox_31).set_TabIndex(38);
		((Control)checkBox_31).set_Text(Class60.smethod_0(-2050206448));
		((ButtonBase)checkBox_31).set_UseVisualStyleBackColor(true);
		checkBox_31.add_CheckedChanged((EventHandler)checkBox_31_CheckedChanged);
		((Control)checkBox_24).set_AutoSize(true);
		((Control)checkBox_24).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_24).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_24).set_Location(new Point(215, 421));
		((Control)checkBox_24).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_24).set_Name(Class60.smethod_0(-2050207414));
		((Control)checkBox_24).set_Size(new Size(111, 20));
		((Control)checkBox_24).set_TabIndex(31);
		((Control)checkBox_24).set_Text(Class60.smethod_0(-2050207394));
		((ButtonBase)checkBox_24).set_UseVisualStyleBackColor(true);
		checkBox_24.add_CheckedChanged((EventHandler)checkBox_24_CheckedChanged);
		((Control)checkBox_37).set_AutoSize(true);
		((Control)checkBox_37).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_37).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_37).set_Location(new Point(215, 444));
		((Control)checkBox_37).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_37).set_Name(Class60.smethod_0(-2050200903));
		((Control)checkBox_37).set_Size(new Size(130, 20));
		((Control)checkBox_37).set_TabIndex(44);
		((Control)checkBox_37).set_Text(Class60.smethod_0(-2050200949));
		((ButtonBase)checkBox_37).set_UseVisualStyleBackColor(true);
		checkBox_37.add_CheckedChanged((EventHandler)checkBox_37_CheckedChanged);
		((Control)checkBox_40).set_AutoSize(true);
		((Control)checkBox_40).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_40).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_40).set_Location(new Point(215, 329));
		((Control)checkBox_40).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_40).set_Name(Class60.smethod_0(-2050200851));
		((Control)checkBox_40).set_Size(new Size(161, 20));
		((Control)checkBox_40).set_TabIndex(47);
		((Control)checkBox_40).set_Text(Class60.smethod_0(-2050200846));
		((ButtonBase)checkBox_40).set_UseVisualStyleBackColor(true);
		checkBox_40.add_CheckedChanged((EventHandler)checkBox_40_CheckedChanged);
		((Control)checkBox_41).set_AutoSize(true);
		((Control)checkBox_41).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_41).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_41).set_Location(new Point(215, 467));
		((Control)checkBox_41).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_41).set_Name(Class60.smethod_0(-2050201039));
		((Control)checkBox_41).set_Size(new Size(145, 20));
		((Control)checkBox_41).set_TabIndex(48);
		((Control)checkBox_41).set_Text(Class60.smethod_0(-2050201084));
		((ButtonBase)checkBox_41).set_UseVisualStyleBackColor(true);
		checkBox_41.add_CheckedChanged((EventHandler)checkBox_41_CheckedChanged);
		((Control)tabPage_1).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_1).get_Controls().Add((Control)(object)gcontrol5_0);
		tabPage_1.set_Location(new Point(4, 5));
		((Control)tabPage_1).set_Margin(new Padding(0));
		((Control)tabPage_1).set_Name(Class60.smethod_0(-2050199942));
		((Control)tabPage_1).set_Size(new Size(395, 581));
		tabPage_1.set_TabIndex(1);
		((Control)tabPage_1).set_Text(Class60.smethod_0(-2050199988));
		((Control)gcontrol5_0).set_BackColor(Color.DarkSlateGray);
		((Control)gcontrol5_0).set_Dock((DockStyle)5);
		((Control)gcontrol5_0).set_Location(new Point(0, 0));
		((Control)gcontrol5_0).set_Margin(new Padding(4));
		((Control)gcontrol5_0).set_Name(Class60.smethod_0(-2050199973));
		((Control)gcontrol5_0).set_Size(new Size(395, 581));
		((Control)gcontrol5_0).set_TabIndex(0);
		((Control)tabPage_2).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_2).get_Controls().Add((Control)(object)gcontrol0_0);
		tabPage_2.set_Location(new Point(4, 5));
		((Control)tabPage_2).set_Margin(new Padding(0));
		((Control)tabPage_2).set_Name(Class60.smethod_0(-2050200018));
		((Control)tabPage_2).set_Size(new Size(395, 581));
		tabPage_2.set_TabIndex(2);
		((Control)tabPage_2).set_Text(Class60.smethod_0(-2050200014));
		((Control)gcontrol0_0).set_BackColor(Color.DarkSlateGray);
		((Control)gcontrol0_0).set_Dock((DockStyle)5);
		((Control)gcontrol0_0).set_Location(new Point(0, 0));
		((Control)gcontrol0_0).set_Margin(new Padding(4));
		((Control)gcontrol0_0).set_Name(Class60.smethod_0(-2050200063));
		((Control)gcontrol0_0).set_Size(new Size(395, 581));
		((Control)gcontrol0_0).set_TabIndex(0);
		((Control)tabPage_3).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_3).get_Controls().Add((Control)(object)gcontrol1_0);
		tabPage_3.set_Location(new Point(4, 5));
		((Control)tabPage_3).set_Margin(new Padding(0));
		((Control)tabPage_3).set_Name(Class60.smethod_0(-2050200042));
		((Control)tabPage_3).set_Size(new Size(395, 581));
		tabPage_3.set_TabIndex(3);
		((Control)tabPage_3).set_Text(Class60.smethod_0(-2050200067));
		((Control)gcontrol1_0).set_BackColor(Color.DarkSlateGray);
		((Control)gcontrol1_0).set_Dock((DockStyle)5);
		((Control)gcontrol1_0).set_Location(new Point(0, 0));
		((Control)gcontrol1_0).set_Margin(new Padding(4));
		((Control)gcontrol1_0).set_Name(Class60.smethod_0(-2050200116));
		((Control)gcontrol1_0).set_Size(new Size(395, 550));
		((Control)gcontrol1_0).set_TabIndex(0);
		((Control)tabPage_4).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_4).get_Controls().Add((Control)(object)gcontrol2_0);
		tabPage_4.set_Location(new Point(4, 5));
		((Control)tabPage_4).set_Margin(new Padding(0));
		((Control)tabPage_4).set_Name(Class60.smethod_0(-2050200105));
		((Control)tabPage_4).set_Size(new Size(395, 581));
		tabPage_4.set_TabIndex(4);
		((Control)tabPage_4).set_Text(Class60.smethod_0(-2050206984));
		((Control)gcontrol2_0).set_BackColor(Color.DarkSlateGray);
		((Control)gcontrol2_0).set_Dock((DockStyle)5);
		((Control)gcontrol2_0).set_Location(new Point(0, 0));
		((Control)gcontrol2_0).set_Margin(new Padding(4));
		((Control)gcontrol2_0).set_Name(Class60.smethod_0(-2050200140));
		((Control)gcontrol2_0).set_Size(new Size(395, 581));
		((Control)gcontrol2_0).set_TabIndex(0);
		((Control)tabPage_5).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_5).get_Controls().Add((Control)(object)gcontrol4_0);
		tabPage_5.set_Location(new Point(4, 5));
		((Control)tabPage_5).set_Margin(new Padding(0));
		((Control)tabPage_5).set_Name(Class60.smethod_0(-2050200164));
		((Control)tabPage_5).set_Size(new Size(395, 581));
		tabPage_5.set_TabIndex(5);
		((Control)tabPage_5).set_Text(Class60.smethod_0(-2050206984));
		((Control)gcontrol4_0).set_BackColor(Color.DarkSlateGray);
		((Control)gcontrol4_0).set_Dock((DockStyle)5);
		((Control)gcontrol4_0).set_Location(new Point(0, 0));
		((Control)gcontrol4_0).set_Margin(new Padding(4));
		((Control)gcontrol4_0).set_Name(Class60.smethod_0(-2050200224));
		((Control)gcontrol4_0).set_Size(new Size(395, 581));
		((Control)gcontrol4_0).set_TabIndex(0);
		((Control)tabPage_6).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_6).get_Controls().Add((Control)(object)gcontrol3_0);
		tabPage_6.set_Location(new Point(4, 5));
		((Control)tabPage_6).set_Margin(new Padding(0));
		((Control)tabPage_6).set_Name(Class60.smethod_0(-2050200242));
		((Control)tabPage_6).set_Size(new Size(395, 581));
		tabPage_6.set_TabIndex(6);
		((Control)tabPage_6).set_Text(Class60.smethod_0(-2050206984));
		((Control)gcontrol3_0).set_BackColor(Color.DarkSlateGray);
		((Control)gcontrol3_0).set_Dock((DockStyle)5);
		((Control)gcontrol3_0).set_Location(new Point(0, 0));
		((Control)gcontrol3_0).set_Margin(new Padding(4));
		((Control)gcontrol3_0).set_Name(Class60.smethod_0(-2050200233));
		((Control)gcontrol3_0).set_Size(new Size(395, 581));
		((Control)gcontrol3_0).set_TabIndex(0);
		tableLayoutPanel_1.set_ColumnCount(2);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)button_0, 1, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)button_1, 0, 0);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(0, 596));
		((Control)tableLayoutPanel_1).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050200260));
		tableLayoutPanel_1.set_RowCount(1);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)1, 39f));
		((Control)tableLayoutPanel_1).set_Size(new Size(409, 39));
		((Control)tableLayoutPanel_1).set_TabIndex(3);
		((Control)button_0).set_BackColor(Color.Salmon);
		((Control)button_0).set_Cursor(Cursors.get_Hand());
		((Control)button_0).set_Dock((DockStyle)5);
		((Control)button_0).set_Enabled(false);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)1);
		((Control)button_0).set_Font(new Font(Class60.smethod_0(-2050211150), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_0).set_ForeColor(SystemColors.Window);
		((Control)button_0).set_Location(new Point(208, 0));
		((Control)button_0).set_Margin(new Padding(4, 0, 4, 4));
		((Control)button_0).set_Name(Class60.smethod_0(-2050200316));
		((Control)button_0).set_Size(new Size(197, 35));
		((Control)button_0).set_TabIndex(1);
		((Control)button_0).set_Text(Class60.smethod_0(-2050200301));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)button_1).set_BackColor(Color.LightSeaGreen);
		((Control)button_1).set_Cursor(Cursors.get_Hand());
		((Control)button_1).set_Dock((DockStyle)5);
		((Control)button_1).set_Enabled(false);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)1);
		((Control)button_1).set_Font(new Font(Class60.smethod_0(-2050211150), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_1).set_ForeColor(SystemColors.Window);
		((Control)button_1).set_Location(new Point(4, 0));
		((Control)button_1).set_Margin(new Padding(4, 0, 4, 4));
		((Control)button_1).set_Name(Class60.smethod_0(-2050200350));
		((Control)button_1).set_Size(new Size(196, 35));
		((Control)button_1).set_TabIndex(0);
		((Control)button_1).set_Text(Class60.smethod_0(-2050200334));
		((ButtonBase)button_1).set_UseVisualStyleBackColor(false);
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((ToolStrip)menuStrip_0).set_BackColor(Color.Teal);
		((Control)menuStrip_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ToolStrip)menuStrip_0).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)toolStripMenuItem_0,
			(ToolStripItem)toolStripMenuItem_1,
			(ToolStripItem)toolStripMenuItem_4,
			(ToolStripItem)toolStripMenuItem_8,
			(ToolStripItem)toolStripMenuItem_9
		});
		((Control)menuStrip_0).set_Location(new Point(0, 0));
		((Control)menuStrip_0).set_Name(Class60.smethod_0(-2050200381));
		((Control)menuStrip_0).set_Padding(new Padding(8, 3, 0, 3));
		((Control)menuStrip_0).set_Size(new Size(409, 26));
		((Control)menuStrip_0).set_TabIndex(0);
		((Control)menuStrip_0).set_Text(Class60.smethod_0(-2050200381));
		((ToolStripDropDownItem)toolStripMenuItem_0).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)toolStripMenuItem_11,
			(ToolStripItem)toolStripMenuItem_12
		});
		((ToolStripItem)toolStripMenuItem_0).set_Name(Class60.smethod_0(-2050200364));
		((ToolStripItem)toolStripMenuItem_0).set_Size(new Size(64, 20));
		((ToolStripItem)toolStripMenuItem_0).set_Text(Class60.smethod_0(-2050200400));
		((ToolStripItem)toolStripMenuItem_0).add_Click((EventHandler)toolStripMenuItem_0_Click);
		((ToolStripItem)toolStripMenuItem_11).set_Name(Class60.smethod_0(-2050200441));
		((ToolStripItem)toolStripMenuItem_11).set_Size(new Size(151, 22));
		((ToolStripItem)toolStripMenuItem_11).set_Text(Class60.smethod_0(-2050200454));
		((ToolStripItem)toolStripMenuItem_11).add_Click((EventHandler)toolStripMenuItem_11_Click);
		((ToolStripItem)toolStripMenuItem_12).set_Name(Class60.smethod_0(-2050200483));
		((ToolStripItem)toolStripMenuItem_12).set_Size(new Size(151, 22));
		((ToolStripItem)toolStripMenuItem_12).set_Text(Class60.smethod_0(-2050200527));
		((ToolStripItem)toolStripMenuItem_12).add_Click((EventHandler)toolStripMenuItem_12_Click);
		((ToolStripDropDownItem)toolStripMenuItem_1).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)toolStripMenuItem_2,
			(ToolStripItem)toolStripMenuItem_3,
			(ToolStripItem)toolStripMenuItem_10
		});
		((ToolStripItem)toolStripMenuItem_1).set_Name(Class60.smethod_0(-2050202648));
		((ToolStripItem)toolStripMenuItem_1).set_Size(new Size(47, 20));
		((ToolStripItem)toolStripMenuItem_1).set_Text(Class60.smethod_0(-2050202680));
		((ToolStripItem)toolStripMenuItem_2).set_Name(Class60.smethod_0(-2050202659));
		((ToolStripItem)toolStripMenuItem_2).set_Size(new Size(153, 22));
		((ToolStripItem)toolStripMenuItem_2).set_Text(Class60.smethod_0(-2050202701));
		((ToolStripItem)toolStripMenuItem_2).add_Click((EventHandler)toolStripMenuItem_2_Click);
		((ToolStripItem)toolStripMenuItem_3).set_Name(Class60.smethod_0(-2050202746));
		((ToolStripItem)toolStripMenuItem_3).set_Size(new Size(153, 22));
		((ToolStripItem)toolStripMenuItem_3).set_Text(Class60.smethod_0(-2050202758));
		((ToolStripItem)toolStripMenuItem_3).add_Click((EventHandler)toolStripMenuItem_3_Click);
		((ToolStripItem)toolStripMenuItem_10).set_Name(Class60.smethod_0(-2050202791));
		((ToolStripItem)toolStripMenuItem_10).set_Size(new Size(153, 22));
		((ToolStripItem)toolStripMenuItem_10).set_Text(Class60.smethod_0(-2050202832));
		((ToolStripItem)toolStripMenuItem_10).add_Click((EventHandler)toolStripMenuItem_10_Click);
		((ToolStripItem)toolStripMenuItem_4).set_Name(Class60.smethod_0(-2050202861));
		((ToolStripItem)toolStripMenuItem_4).set_Size(new Size(12, 20));
		((ToolStripItem)toolStripMenuItem_8).set_Name(Class60.smethod_0(-2050203185));
		((ToolStripItem)toolStripMenuItem_8).set_Size(new Size(12, 20));
		((ToolStripItem)toolStripMenuItem_9).set_Name(Class60.smethod_0(-2050203254));
		((ToolStripItem)toolStripMenuItem_9).set_Size(new Size(12, 20));
		((ToolStripItem)toolStripMenuItem_5).set_Name(Class60.smethod_0(-2050203005));
		((ToolStripItem)toolStripMenuItem_5).set_Size(new Size(32, 19));
		((ToolStripItem)toolStripMenuItem_6).set_Name(Class60.smethod_0(-2050203066));
		((ToolStripItem)toolStripMenuItem_6).set_Size(new Size(32, 19));
		((ToolStripItem)toolStripMenuItem_7).set_Name(Class60.smethod_0(-2050203112));
		((ToolStripItem)toolStripMenuItem_7).set_Size(new Size(32, 19));
		((FileDialog)saveFileDialog_0).set_FileName(Class60.smethod_0(-2050203327));
		((FileDialog)saveFileDialog_0).set_RestoreDirectory(true);
		((FileDialog)openFileDialog_0).set_FileName(Class60.smethod_0(-2050203327));
		((FileDialog)openFileDialog_0).set_RestoreDirectory(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 18f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(409, 661));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		((Control)this).get_Controls().Add((Control)(object)menuStrip_0);
		((Control)this).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(Class60.smethod_0(-2050208183)));
		((Form)this).set_MainMenuStrip(menuStrip_0);
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_MinimumSize(new Size(425, 700));
		((Control)this).set_Name(Class60.smethod_0(-2050203577));
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(Class60.smethod_0(-2050204294));
		((Form)this).add_Load((EventHandler)GForm7_Load);
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((Control)tabControl_0).ResumeLayout(false);
		((Control)tabPage_0).ResumeLayout(false);
		((Control)tableLayoutPanel_2).ResumeLayout(false);
		((Control)groupBox_1).ResumeLayout(false);
		((Control)tableLayoutPanel_4).ResumeLayout(false);
		((Control)tableLayoutPanel_4).PerformLayout();
		((Control)groupBox_0).ResumeLayout(false);
		((Control)tableLayoutPanel_3).ResumeLayout(false);
		((Control)tableLayoutPanel_3).PerformLayout();
		((Control)tabPage_1).ResumeLayout(false);
		((Control)tabPage_2).ResumeLayout(false);
		((Control)tabPage_3).ResumeLayout(false);
		((Control)tabPage_4).ResumeLayout(false);
		((Control)tabPage_5).ResumeLayout(false);
		((Control)tabPage_6).ResumeLayout(false);
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)menuStrip_0).ResumeLayout(false);
		((Control)menuStrip_0).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
