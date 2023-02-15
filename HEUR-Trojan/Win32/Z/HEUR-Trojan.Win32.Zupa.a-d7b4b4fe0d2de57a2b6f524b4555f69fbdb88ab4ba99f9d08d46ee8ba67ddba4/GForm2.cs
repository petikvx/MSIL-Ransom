using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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

public sealed class GForm2 : Form
{
	[Serializable]
	private sealed class Class15
	{
		public static readonly Class15 class15_0 = new Class15();

		public static Func<Process, int> func_0;

		public static Func<Class22, bool> func_1;

		public static Func<Class22, bool> func_2;

		public static Func<Class22, bool> func_3;

		public static Func<Class22, double> func_4;

		public static Func<Class22, double> func_5;

		public static Predicate<Class22> predicate_0;

		public static Predicate<Class22> predicate_1;

		public static Func<Class22, bool> func_6;

		public static Func<Class22, bool> func_7;

		public static Func<Class22, bool> func_8;

		internal int method_0(Process process_0)
		{
			return process_0.Id;
		}

		internal bool method_1(Class22 class22_0)
		{
			return class22_0.method_2().Equals(obj: true);
		}

		internal bool method_2(Class22 class22_0)
		{
			return class22_0.method_2().Equals(obj: true);
		}

		internal bool method_3(Class22 class22_0)
		{
			return class22_0.method_2().Equals(obj: true);
		}

		internal double method_4(Class22 class22_0)
		{
			return class22_0.method_4();
		}

		internal double method_5(Class22 class22_0)
		{
			return class22_0.method_4();
		}

		internal bool method_6(Class22 class22_0)
		{
			return class22_0.method_2().Equals(obj: true);
		}

		internal bool method_7(Class22 class22_0)
		{
			return class22_0.method_2().Equals(obj: true);
		}

		internal bool method_8(Class22 class22_0)
		{
			return class22_0.method_2().Equals(obj: true);
		}

		internal bool method_9(Class22 class22_0)
		{
			return class22_0.method_2().Equals(obj: true);
		}

		internal bool method_10(Class22 class22_0)
		{
			return class22_0.method_2().Equals(obj: true);
		}
	}

	private sealed class Class16
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

	private sealed class Class17
	{
		public List<int> list_0;

		public int int_0;

		public int int_1;

		public List<int> list_1;

		public int int_2;

		public int int_3;

		public GForm2 gform2_0;

		public int int_4;

		public int int_5;

		public Predicate<int> predicate_0;

		public Func<int, bool> func_0;

		public Func<int, bool> func_1;

		public Func<int, bool> func_2;

		public Func<Class22, bool> func_3;

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

		internal bool method_3(Class22 class22_0)
		{
			if (class22_0.method_0().Equals(list_1[int_0]))
			{
				if (!class22_0.method_2().Equals(obj: false))
				{
					return class22_0.method_0().Equals(int_2);
				}
				return true;
			}
			return false;
		}

		internal bool method_4(Class22 class22_0)
		{
			return class22_0.method_0().Equals(int_2);
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

		internal bool method_8(Class22 class22_0)
		{
			return class22_0.method_0() == int_3;
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
			return int_6.Equals(gform2_0.list_11[0]);
		}

		internal double method_14(Point point_0)
		{
			return gform2_0.method_26(new Point(int_4, int_5), point_0);
		}

		internal double method_15(GClass7 gclass7_0)
		{
			return gform2_0.method_25(new GClass7(gform2_0.gclass14_0.method_9(gform2_0.gclass12_0.CHAR_X), gform2_0.gclass14_0.method_9(gform2_0.gclass12_0.CHAR_Y)), gclass7_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct3 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm2 gform2_0;

		private TaskAwaiter<GClass12> taskAwaiter_0;

		private TaskAwaiter<List<GClass0>> taskAwaiter_1;

		private TaskAwaiter<List<GClass3>> taskAwaiter_2;

		private void MoveNext()
		{
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Expected O, but got Unknown
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0504: Unknown result type (might be due to invalid IL or missing references)
			//IL_0509: Unknown result type (might be due to invalid IL or missing references)
			//IL_052c: Expected O, but got Unknown
			//IL_0527: Unknown result type (might be due to invalid IL or missing references)
			//IL_0538: Unknown result type (might be due to invalid IL or missing references)
			//IL_053d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0560: Expected O, but got Unknown
			//IL_055b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0745: Unknown result type (might be due to invalid IL or missing references)
			//IL_0767: Unknown result type (might be due to invalid IL or missing references)
			//IL_076c: Unknown result type (might be due to invalid IL or missing references)
			//IL_079b: Expected O, but got Unknown
			//IL_0796: Unknown result type (might be due to invalid IL or missing references)
			int num = int_0;
			GForm2 gForm = gform2_0;
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
						((ToolStripItem)gForm.toolStripMenuItem_8).set_Visible(false);
						((Control)gForm).set_Text(((Control)gForm).get_Text() + gForm.string_0 + Class60.smethod_0(-2050211571) + gForm.int_0 + Class60.smethod_0(-2050211560));
						if (gForm.gclass1_0 != null)
						{
							gForm.int_6 = Settings.Default.Server_Index;
							awaiter3 = GClass6.smethod_5(gForm.int_6).GetAwaiter();
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
						goto IL_011f;
					case 1:
						awaiter2 = taskAwaiter_1;
						taskAwaiter_1 = default(TaskAwaiter<List<GClass0>>);
						num = -1;
						int_0 = -1;
						goto IL_01ee;
					case 2:
						{
							awaiter = taskAwaiter_2;
							taskAwaiter_2 = default(TaskAwaiter<List<GClass3>>);
							num = -1;
							int_0 = -1;
							break;
						}
						IL_011f:
						gClass = (gForm.gclass12_0 = awaiter3.GetResult());
						if (gForm.gclass12_0 != null)
						{
							gForm.gclass14_0.string_0 = gForm.gclass12_0.BASE_ADDRESS;
							gForm.gclass14_0.string_1 = gForm.gclass12_0.MAX_HP;
							awaiter2 = GClass6.smethod_6().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 1;
								int_0 = 1;
								taskAwaiter_1 = awaiter2;
								asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_01ee;
						}
						val2 = new Form();
						val2.set_TopMost(true);
						MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050210246), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
						((Form)gForm).Close();
						goto end_IL_000e;
						IL_01ee:
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
					gForm.gcontrol2_0.method_0(gForm.struct26_0);
					gForm.gcontrol4_0.method_0(gForm.struct26_0);
					gForm.gcontrol3_0.method_0(gForm.struct24_0);
					gForm.timer_0 = new System.Timers.Timer(1000.0);
					gForm.timer_0.Enabled = true;
					gForm.timer_0.Elapsed += gForm.method_2;
					gForm.timer_0.Stop();
					gForm.class19_0.WorkerSupportsCancellation = true;
					gForm.class19_0.DoWork += gForm.method_0;
					gForm.class19_1.WorkerSupportsCancellation = true;
					gForm.class19_1.DoWork += gForm.method_1;
					((Control)gForm.button_1).set_Enabled(true);
					if (gForm.int_6 == 1 || gForm.int_6 == 2 || gForm.int_6 == 3 || gForm.int_6 == 5)
					{
						gForm.int_8 = 65537;
					}
					if (GClass6.smethod_0().Equals(7))
					{
						string[] array = Directory.GetFiles(Class60.smethod_0(-2050211568), Class60.smethod_0(-2050211586), SearchOption.AllDirectories);
						if (array == null || array.Length == 0)
						{
							try
							{
								array = Directory.GetFiles(Class60.smethod_0(-2050211622), Class60.smethod_0(-2050211586), SearchOption.AllDirectories);
							}
							catch
							{
								array = null;
							}
						}
						if (array == null || array.Length == 0)
						{
							string[] files = Directory.GetFiles(Class60.smethod_0(-2050211568), Class60.smethod_0(-2050211678), SearchOption.AllDirectories);
							if (files == null || files.Length == 0)
							{
								files = Directory.GetFiles(Class60.smethod_0(-2050211622), Class60.smethod_0(-2050211678), SearchOption.AllDirectories);
							}
							if (files != null && files.Length != 0)
							{
								string value = files.Where(gForm.method_28).FirstOrDefault();
								if (!string.IsNullOrEmpty(value))
								{
									if ((gForm.int_6.Equals(1) && Directory.GetFiles(Class60.smethod_0(-2050211698), Class60.smethod_0(-2050211763), SearchOption.TopDirectoryOnly).Length == 0) || (gForm.int_6.Equals(5) && Directory.GetFiles(Class60.smethod_0(-2050211808), Class60.smethod_0(-2050211763), SearchOption.TopDirectoryOnly).Length == 0))
									{
										GForm9 gForm2 = new GForm9();
										try
										{
											((Control)gForm).Hide();
											((Form)gForm2).add_Closed((EventHandler)gForm.method_29);
											gForm2.int_0 = gForm.int_6;
											gForm2.int_1 = GClass6.smethod_0();
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
								}
								else
								{
									Form val3 = new Form();
									val3.set_TopMost(true);
									MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050211838), Class60.smethod_0(-2050209943), (MessageBoxButtons)0, (MessageBoxIcon)48);
									((Form)gForm).Close();
								}
							}
							else
							{
								Form val4 = new Form();
								val4.set_TopMost(true);
								MessageBox.Show((IWin32Window)val4, Class60.smethod_0(-2050211838), Class60.smethod_0(-2050209943), (MessageBoxButtons)0, (MessageBoxIcon)48);
								((Form)gForm).Close();
							}
						}
					}
					else
					{
						string[] files2 = Directory.GetFiles(Class60.smethod_0(-2050209934), Class60.smethod_0(-2050209980), SearchOption.TopDirectoryOnly);
						if (files2 == null || files2.Length == 0)
						{
							File.WriteAllBytes(Class60.smethod_0(-2050209961), Class41.smethod_12());
							Thread.Sleep(1000);
							files2 = Directory.GetFiles(Class60.smethod_0(-2050209934), Class60.smethod_0(-2050209980), SearchOption.TopDirectoryOnly);
						}
						if (files2 != null && files2.Length != 0 && gForm.int_0 == 1)
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
							GForm9 gForm3 = new GForm9();
							try
							{
								((Control)gForm).Hide();
								((Form)gForm3).add_Closed((EventHandler)gForm.method_30);
								gForm3.int_0 = gForm.int_6;
								gForm3.int_1 = GClass6.smethod_0();
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
					}
					gForm.method_21();
					end_IL_000e:;
				}
				catch (Exception ex)
				{
					Form val5 = new Form();
					val5.set_TopMost(true);
					MessageBox.Show((IWin32Window)val5, Class60.smethod_0(-2050210520) + ex.Message, Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
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

	private sealed class Class18
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

	private sealed class Class19 : BackgroundWorker
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

	private sealed class Class20
	{
		public int int_0;

		internal bool method_0(Class22 class22_0)
		{
			return class22_0.method_0().Equals(int_0);
		}
	}

	public struct GStruct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;
	}

	private sealed class Class21
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

	private sealed class Class22
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

	private sealed class Class23
	{
		public int int_0;

		public Func<Class22, bool> func_0;

		internal bool method_0(Class22 class22_0)
		{
			return class22_0.method_0() == int_0;
		}
	}

	private sealed class Class24
	{
		public int int_0;

		public Func<Class22, bool> func_0;

		public Func<Class22, bool> func_1;

		public Func<int, bool> func_2;

		public Func<int, bool> func_3;

		public Func<Class22, bool> func_4;

		public Func<Class22, bool> func_5;

		public Func<int, bool> func_6;

		public Func<int, bool> func_7;

		public Func<int, bool> func_8;

		public Func<int, bool> func_9;

		internal bool method_0(Class22 class22_0)
		{
			return class22_0.method_0() == int_0;
		}

		internal bool method_1(Class22 class22_0)
		{
			return class22_0.method_0() == int_0;
		}

		internal bool method_2(int int_1)
		{
			return int_1 == int_0;
		}

		internal bool method_3(int int_1)
		{
			return int_1 == int_0;
		}

		internal bool method_4(Class22 class22_0)
		{
			return class22_0.method_0() == int_0;
		}

		internal bool method_5(Class22 class22_0)
		{
			return class22_0.method_0() == int_0;
		}

		internal bool method_6(int int_1)
		{
			return int_1 == int_0;
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

	public int int_0 = 1;

	public string string_0;

	public GClass1 gclass1_0;

	private int int_1;

	private GClass12 gclass12_0;

	private IntPtr intptr_0;

	private Process[] process_0;

	private GClass14 gclass14_0 = new GClass14();

	private Class55.Struct25 struct25_0;

	private Class55.Struct27 struct27_0;

	private Class19 class19_0 = new Class19();

	private Class19 class19_1 = new Class19();

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

	private List<Class22> list_10 = new List<Class22>();

	private List<int> list_11 = new List<int>();

	private List<int> list_12 = new List<int>();

	private List<int> list_13 = new List<int>();

	private bool bool_0;

	private int[] int_2;

	private int[] int_3;

	private int[] int_4;

	private string string_1;

	private int int_5;

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

	private bool bool_43;

	private bool bool_44;

	private bool bool_45;

	private Point point_0;

	private List<Point> list_14;

	private List<GClass7> list_15;

	private SoundPlayer soundPlayer_0 = new SoundPlayer((Stream)Class41.smethod_8());

	private SoundPlayer soundPlayer_1 = new SoundPlayer((Stream)Class41.smethod_17());

	private SoundPlayer soundPlayer_2 = new SoundPlayer((Stream)Class41.smethod_20());

	private bool bool_46;

	private bool bool_47;

	private bool bool_48;

	private bool bool_49;

	private bool bool_50;

	private bool bool_51;

	private bool bool_52;

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

	private int int_40;

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

	private ToolStripMenuItem toolStripMenuItem_11;

	private ToolStripMenuItem toolStripMenuItem_12;

	private OpenFileDialog openFileDialog_0;

	private SaveFileDialog saveFileDialog_0;

	private CheckBox checkBox_42;

	private CheckBox checkBox_43;

	private CheckBox checkBox_44;

	public GForm2()
	{
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		method_27();
		((Control)tabControl_0).set_Region(new Region(new RectangleF(((Control)tabPage_0).get_Left(), ((Control)tabPage_0).get_Top(), ((Control)tabPage_0).get_Width(), ((Control)tabPage_0).get_Height())));
		Control.set_CheckForIllegalCrossThreadCalls(false);
		gcontrol0_0.int_0 = 0;
		gcontrol5_0.int_0 = 0;
		gcontrol1_0.int_0 = 0;
	}

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	internal static extern IntPtr FindWindow(string string_2, string string_3);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool TerminateProcess(IntPtr intptr_1, uint uint_0);

	[DllImport("User32.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetWindowRect(IntPtr intptr_1, ref GStruct0 gstruct0_0);

	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(IntPtr intptr_1);

	[DllImport("User32.Dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage(IntPtr intptr_1, uint uint_0, int int_41, int int_42);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "PostMessage", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage_1(IntPtr intptr_1, uint uint_0, IntPtr intptr_2, IntPtr intptr_3);

	private static IntPtr smethod_0(int int_41, int int_42)
	{
		return (IntPtr)((int_42 << 16) | (int_41 & 0xFFFF));
	}

	private void GForm2_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private async void GForm2_Load(object sender, EventArgs e)
	{
		try
		{
			((ToolStripItem)toolStripMenuItem_8).set_Visible(false);
			((Control)this).set_Text(((Control)this).get_Text() + string_0 + Class60.smethod_0(-2050211571) + int_0 + Class60.smethod_0(-2050211560));
			if (gclass1_0 != null)
			{
				int_6 = Settings.Default.Server_Index;
				gclass12_0 = await GClass6.smethod_5(int_6);
				if (gclass12_0 != null)
				{
					gclass14_0.string_0 = gclass12_0.BASE_ADDRESS;
					gclass14_0.string_1 = gclass12_0.MAX_HP;
					List<GClass0> list = await GClass6.smethod_6();
					struct24_0.method_1(list);
					List<GClass3> list2 = await GClass6.smethod_7();
					struct26_0.method_1(list2);
					struct23_0.method_1();
					gcontrol2_0.method_0(struct26_0);
					gcontrol4_0.method_0(struct26_0);
					gcontrol3_0.method_0(struct24_0);
					timer_0 = new System.Timers.Timer(1000.0);
					timer_0.Enabled = true;
					timer_0.Elapsed += method_2;
					timer_0.Stop();
					class19_0.WorkerSupportsCancellation = true;
					class19_0.DoWork += method_0;
					class19_1.WorkerSupportsCancellation = true;
					class19_1.DoWork += method_1;
					((Control)button_1).set_Enabled(true);
					if (int_6 == 1 || int_6 == 2 || int_6 == 3 || int_6 == 5)
					{
						int_8 = 65537;
					}
					if (GClass6.smethod_0().Equals(7))
					{
						string[] array = Directory.GetFiles(Class60.smethod_0(-2050211568), Class60.smethod_0(-2050211586), SearchOption.AllDirectories);
						if (array == null || array.Length == 0)
						{
							try
							{
								array = Directory.GetFiles(Class60.smethod_0(-2050211622), Class60.smethod_0(-2050211586), SearchOption.AllDirectories);
							}
							catch
							{
								array = null;
							}
						}
						if (array == null || array.Length == 0)
						{
							string[] files = Directory.GetFiles(Class60.smethod_0(-2050211568), Class60.smethod_0(-2050211678), SearchOption.AllDirectories);
							if (files == null || files.Length == 0)
							{
								files = Directory.GetFiles(Class60.smethod_0(-2050211622), Class60.smethod_0(-2050211678), SearchOption.AllDirectories);
							}
							if (files != null && files.Length != 0)
							{
								string value = files.Where(method_28).FirstOrDefault();
								if (!string.IsNullOrEmpty(value))
								{
									if ((int_6.Equals(1) && Directory.GetFiles(Class60.smethod_0(-2050211698), Class60.smethod_0(-2050211763), SearchOption.TopDirectoryOnly).Length == 0) || (int_6.Equals(5) && Directory.GetFiles(Class60.smethod_0(-2050211808), Class60.smethod_0(-2050211763), SearchOption.TopDirectoryOnly).Length == 0))
									{
										GForm9 gForm = new GForm9();
										try
										{
											((Control)this).Hide();
											((Form)gForm).add_Closed((EventHandler)method_29);
											gForm.int_0 = int_6;
											gForm.int_1 = GClass6.smethod_0();
											((Form)gForm).ShowDialog();
										}
										finally
										{
											((IDisposable)(object)gForm)?.Dispose();
										}
									}
								}
								else
								{
									Form val = new Form();
									val.set_TopMost(true);
									MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050211838), Class60.smethod_0(-2050209943), (MessageBoxButtons)0, (MessageBoxIcon)48);
									((Form)this).Close();
								}
							}
							else
							{
								Form val2 = new Form();
								val2.set_TopMost(true);
								MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050211838), Class60.smethod_0(-2050209943), (MessageBoxButtons)0, (MessageBoxIcon)48);
								((Form)this).Close();
							}
						}
					}
					else
					{
						string[] files2 = Directory.GetFiles(Class60.smethod_0(-2050209934), Class60.smethod_0(-2050209980), SearchOption.TopDirectoryOnly);
						if (files2 == null || files2.Length == 0)
						{
							File.WriteAllBytes(Class60.smethod_0(-2050209961), Class41.smethod_12());
							Thread.Sleep(1000);
							files2 = Directory.GetFiles(Class60.smethod_0(-2050209934), Class60.smethod_0(-2050209980), SearchOption.TopDirectoryOnly);
						}
						if (files2 != null && files2.Length != 0 && int_0 == 1)
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
							GForm9 gForm2 = new GForm9();
							try
							{
								((Control)this).Hide();
								((Form)gForm2).add_Closed((EventHandler)method_30);
								gForm2.int_0 = int_6;
								gForm2.int_1 = GClass6.smethod_0();
								((Form)gForm2).ShowDialog();
							}
							finally
							{
								((IDisposable)(object)gForm2)?.Dispose();
							}
						}
					}
					method_21();
				}
				else
				{
					Form val3 = new Form();
					val3.set_TopMost(true);
					MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050210246), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
				}
			}
			else
			{
				Form val4 = new Form();
				val4.set_TopMost(true);
				MessageBox.Show((IWin32Window)val4, Class60.smethod_0(-2050210429), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
				((Form)this).Close();
			}
		}
		catch (Exception ex)
		{
			Form val5 = new Form();
			val5.set_TopMost(true);
			MessageBox.Show((IWin32Window)val5, Class60.smethod_0(-2050210520) + ex.Message, Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
			((Form)this).Close();
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Expected O, but got Unknown
		//IL_09db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Expected O, but got Unknown
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Expected O, but got Unknown
		//IL_0bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2d: Expected O, but got Unknown
		//IL_0c28: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = 0;
			bool_51 = false;
			bool_52 = false;
			bool_46 = false;
			bool_47 = false;
			bool_48 = false;
			bool_49 = false;
			bool_50 = false;
			int_36 = 0;
			int_37 = 0;
			int_38 = 0;
			int_39 = 0;
			int_40 = 0;
			if (!bool_0)
			{
				process_0 = gclass14_0.method_4(Class60.smethod_0(-2050204785));
				if (process_0 != null && process_0.Length != 0)
				{
					List<Process> list = process_0.OrderBy(Class15.class15_0.method_0).ToList();
					if (int_0 <= list.Count())
					{
						num = list[int_0 - 1].Id;
						intptr_0 = list[int_0 - 1].MainWindowHandle;
					}
					else
					{
						Form val = new Form();
						val.set_TopMost(true);
						MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050204772), Class60.smethod_0(-2050208686), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
				else
				{
					intptr_0 = IntPtr.Zero;
				}
				if (intptr_0.ToInt32() <= 0)
				{
					Form val2 = new Form();
					val2.set_TopMost(true);
					MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050205012), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				int_1 = num;
				if (GClass6.smethod_0().Equals(1))
				{
					bool_0 = gclass14_0.method_5(num, int_0);
				}
				else
				{
					bool_0 = gclass14_0.method_6(num);
				}
				if (!bool_0)
				{
					Form val3 = new Form();
					val3.set_TopMost(true);
					MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050204833), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
					return;
				}
				if (GClass6.smethod_0().Equals(1))
				{
					gclass14_0.method_1(process_0[0].Id);
				}
				else
				{
					gclass14_0.method_1(num);
				}
				gcontrol1_0.gclass12_0 = gclass12_0;
				gcontrol1_0.gclass14_0 = gclass14_0;
				gcontrol0_0.gclass12_0 = gclass12_0;
				gcontrol0_0.gclass14_0 = gclass14_0;
				if (GClass6.smethod_0().Equals(1))
				{
					gcontrol0_0.int_1 = process_0[0].Id;
				}
				else
				{
					gcontrol0_0.int_1 = num;
				}
				GStruct0 gstruct0_ = default(GStruct0);
				GetWindowRect(intptr_0, ref gstruct0_);
				int_9 = gstruct0_.int_2 - gstruct0_.int_0;
				int_10 = gstruct0_.int_3 - gstruct0_.int_1;
				int_11 = int_9 / 2;
				int_12 = int_10 / 2;
			}
			((Control)label_0).set_Text(gclass14_0.method_8(gclass12_0.NAME));
			((Control)label_2).set_Text(gclass14_0.method_9(gclass12_0.HP) + Class60.smethod_0(-2050205079) + gclass14_0.method_9(gclass12_0.MAX_HP));
			((Control)label_4).set_Text(gclass14_0.method_9(gclass12_0.SP) + Class60.smethod_0(-2050205079) + gclass14_0.method_9(gclass12_0.MAX_SP));
			int_5 = gclass14_0.method_9(gclass12_0.CHAR_ID.ToString());
			int_17 = Settings.Default.AB_Freq + 1;
			int_18 = Settings.Default.ATK_Floor_Freq + 1;
			int_19 = Settings.Default.SKILLBUFF_1_Freq + 1;
			int_20 = Settings.Default.SKILLBUFF_2_Freq + 1;
			int_21 = Settings.Default.SKILLBUFF_3_Freq + 1;
			int_22 = Settings.Default.SKILLBUFF_4_Freq + 1;
			int_23 = Settings.Default.SKILLBUFF_5_Freq + 1;
			int_24 = Settings.Default.SKILLBUFF_6_Freq + 1;
			int_25 = Settings.Default.Macro1_Freq + 1;
			int_26 = Settings.Default.Macro2_Freq + 1;
			int_27 = Settings.Default.Macro3_Freq + 1;
			int_28 = Settings.Default.Macro4_Freq + 1;
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
				if (class19_0.IsBusy)
				{
					class19_0.method_0();
					class19_0.Dispose();
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
				if (bool_14)
				{
					if (Settings.Default.Monster_List.Count > 0)
					{
						List<int> list2 = new List<int>();
						foreach (string item in Settings.Default.Monster_List.Cast<string>().ToList())
						{
							list2.Add(struct26_0.method_0().ElementAt(int.Parse(item)).Key);
						}
						int_2 = list2.ToArray();
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
						List<int> list3 = new List<int>();
						foreach (string item2 in Settings.Default.Monster_Escape_List.Cast<string>().ToList())
						{
							list3.Add(struct26_0.method_0().ElementAt(int.Parse(item2)).Key);
						}
						int_3 = list3.ToArray();
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
						List<int> list4 = new List<int>();
						foreach (string item3 in Settings.Default.Item_List.Cast<string>().ToList())
						{
							list4.Add(struct24_0.method_0().ElementAt(int.Parse(item3)).Key);
						}
						int_4 = list4.ToArray();
					}
					else
					{
						checkBox_13.set_Checked(false);
					}
				}
				((Control)label_0).set_Text(gclass14_0.method_8(gclass12_0.NAME));
				string_1 = gclass14_0.method_8(gclass12_0.MAP_NAME);
				if (bool_27)
				{
					if (string.IsNullOrEmpty(Settings.Default.Path_Map) || !File.Exists(Settings.Default.Path_Map))
					{
						Form val4 = new Form();
						val4.set_TopMost(true);
						MessageBox.Show((IWin32Window)val4, Class60.smethod_0(-2050205087), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
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
					list_14 = struct27_0.method_1(Settings.Default.Path_Map);
					int_34 = list_14.Count();
				}
				else if (bool_26 && !struct27_0.method_2(string_1))
				{
					Form val5 = new Form();
					val5.set_TopMost(true);
					MessageBox.Show((IWin32Window)val5, Class60.smethod_0(-2050205180), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
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
				method_22();
				if (!class19_0.IsBusy)
				{
					class19_0.RunWorkerAsync();
				}
				if (!class19_1.IsBusy)
				{
					class19_1.RunWorkerAsync();
				}
				timer_0.Start();
			}
			else
			{
				gclass12_0 = null;
				Form val6 = new Form();
				val6.set_TopMost(true);
				MessageBox.Show((IWin32Window)val6, Class60.smethod_0(-2050205309), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		catch (Exception ex)
		{
			Form val7 = new Form();
			val7.set_TopMost(true);
			MessageBox.Show((IWin32Window)val7, Class60.smethod_0(-2050208456) + ex.ToString(), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)16);
			bool_0 = false;
			((Control)tableLayoutPanel_3).set_Enabled(true);
			((Control)button_1).set_Enabled(true);
			((Control)button_0).set_Enabled(false);
			if (class19_1.IsBusy)
			{
				class19_1.method_0();
				class19_1.Dispose();
			}
			if (class19_0.IsBusy)
			{
				class19_0.method_0();
				class19_0.Dispose();
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
			if (class19_0.IsBusy)
			{
				class19_0.method_0();
				class19_0.Dispose();
			}
			if (class19_1.IsBusy)
			{
				class19_1.method_0();
				class19_1.Dispose();
			}
			if (bool_51 || bool_52)
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
			if (class19_1.IsBusy)
			{
				class19_1.method_0();
				class19_1.Dispose();
			}
			if (class19_0.IsBusy)
			{
				class19_0.method_0();
				class19_0.Dispose();
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
		Class17 @class = new Class17();
		@class.gform2_0 = this;
		if (list_11.ToList().Count > 0)
		{
			list_11.Clear();
		}
		if (list_10.ToList().Count > 0)
		{
			list_10.Clear();
		}
		int num = 0;
		@class.list_1 = new List<int>();
		@class.list_0 = new List<int>();
		bool flag = false;
		int num2 = 0;
		@class.int_3 = 0;
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		@class.int_0 = 0;
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
		@class.int_4 = 0;
		@class.int_5 = 0;
		int num14 = 0;
		int num15 = 0;
		@class.int_1 = 0;
		@class.int_2 = 0;
		while (!class19_0.CancellationPending)
		{
			if (bool_1)
			{
				num2 = method_9();
				if (num2 > 0)
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
					list_11.Add(num2);
					while (num2 > 0)
					{
						gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), num2.ToString());
						gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
						Thread.Sleep(1000);
						num2 = method_9();
					}
				}
			}
			if (bool_10)
			{
				method_10();
			}
			if (bool_16 && method_7().Count > 0)
			{
				if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
				{
					gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
				}
				num7 = 0;
				if (bool_25)
				{
					int_30 = 0;
					while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
					{
						int_30++;
						gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
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
					method_3(Settings.Default.Wing_Hotkey);
				}
				Thread.Sleep(800);
			}
			if (bool_2 || bool_3)
			{
				method_19();
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
				num4 = gclass14_0.method_9(gclass12_0.CHECK_ATTACK);
				num6 = gclass14_0.method_9(gclass12_0.CHECK_WALKING);
				while (list_11.ToList().Count > 0 && num4 == 0 && num6 < 2)
				{
					if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
					{
						gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					num3 = gclass14_0.method_9(gclass12_0.ATTACK);
					num6 = gclass14_0.method_9(gclass12_0.CHECK_WALKING);
					if (@class.int_1 != list_11.Last())
					{
						List<int> list = method_7();
						if (list.Count == 2)
						{
							if (bool_16)
							{
								if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
								{
									gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
								}
								num7 = 0;
								if (bool_25)
								{
									int_30 = 0;
									while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
									{
										int_30++;
										gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
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
									method_3(Settings.Default.Wing_Hotkey);
								}
								Thread.Sleep(800);
								list_10.Clear();
								@class.list_1.Clear();
								num14 = list_11.Last();
							}
							else
							{
								num14 = list[1];
							}
						}
						else
						{
							num14 = 0;
						}
						if (list_11.Last() != num14)
						{
							num12 = gclass14_0.method_9(gclass12_0.CHAR_X);
							num13 = gclass14_0.method_9(gclass12_0.CHAR_Y);
							gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), list_11.Last().ToString());
							gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205567));
							Thread.Sleep(600);
							while (gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 1)
							{
								Thread.Sleep(400);
							}
						}
						@class.int_1 = list_11.Last();
						list_11.RemoveAll(@class.method_1);
						num15 = 0;
						continue;
					}
					num15++;
					if ((num15 <= 15 || num4 != 0) && (num15 <= 10 || num4 != 0 || gclass14_0.method_9(gclass12_0.CHAR_X) != num12 || gclass14_0.method_9(gclass12_0.CHAR_Y) != num13) && (num15 <= 30 || num4 != 1 || gclass14_0.method_9(gclass12_0.CHAR_X) == num12 || gclass14_0.method_9(gclass12_0.CHAR_Y) == num13))
					{
						if (num15 > 10 && num4 == 1 && num6 == 0)
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
							num12 = gclass14_0.method_9(gclass12_0.CHAR_X);
							num13 = gclass14_0.method_9(gclass12_0.CHAR_Y);
						}
						else if (num15 > 5)
						{
							method_18();
							if (list_10.Any(Class15.class15_0.method_1))
							{
								break;
							}
						}
						Thread.Sleep(200);
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
					num15 = 0;
					list_11.Clear();
					break;
				}
				num15 = 0;
				@class.int_1 = 0;
			}
			if (!bool_15)
			{
				method_18();
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
					if (list_10.Any(Class15.class15_0.method_2))
					{
						@class.int_3 = list_10.Where(Class15.class15_0.method_3).OrderBy(Class15.class15_0.method_4).FirstOrDefault()!.method_0();
					}
					else
					{
						@class.int_3 = list_10.OrderBy(Class15.class15_0.method_5).FirstOrDefault()!.method_0();
					}
					if (@class.int_3 > 0)
					{
						num3 = gclass14_0.method_9(gclass12_0.ATTACK);
						num4 = gclass14_0.method_9(gclass12_0.CHECK_ATTACK);
						num6 = gclass14_0.method_9(gclass12_0.CHECK_WALKING);
						if (num4 == 0 && num3 == 0 && ((num6 < 2 && gclass14_0.method_9(gclass12_0.CHECK_SITDOWN) == 0) || (num6 > 30 && num6 < 100)) && (bool_36 || !list_10.Any(@class.method_4)))
						{
							List<int> list2 = method_7();
							if (list2.Count == 2)
							{
								if (bool_16)
								{
									if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
									{
										gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
									}
									num7 = 0;
									if (bool_25)
									{
										int_30 = 0;
										while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
										{
											int_30++;
											gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
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
										method_3(Settings.Default.Wing_Hotkey);
									}
									Thread.Sleep(800);
									list_10.Clear();
									@class.list_1.Clear();
									num14 = 0;
									@class.int_3 = 0;
								}
								else
								{
									num14 = list2[1];
								}
							}
							else
							{
								num14 = 0;
							}
							if (!bool_6 && (bool_6 || list2.Count != 0) && (bool_6 || @class.int_3 == num14 || method_8(@class.int_3) || method_15(@class.int_3)))
							{
								if (!@class.list_1.ToList().Any(@class.method_7))
								{
									@class.list_1.Add(@class.int_3);
								}
							}
							else
							{
								if (bool_10)
								{
									method_10();
								}
								if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
								{
									gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
								}
								gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), @class.int_3.ToString());
								if (bool_36 && gclass14_0.method_9(gclass12_0.SP) * 100 / gclass14_0.method_9(gclass12_0.MAX_SP) > 5)
								{
									num8 = 0;
									gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Settings.Default.ATK_Skill_Lv.ToString());
									gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default.ATK_Skill.ToString());
									gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
									Thread.Sleep(200);
									while (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) == 0 && gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 1 && gclass14_0.method_9(gclass12_0.ATTACK) == 3)
									{
										num8++;
										if (num8 > 10)
										{
											break;
										}
										Thread.Sleep(400);
										method_18();
									}
									if (Settings.Default.ATK_Skill_Mode > 0 && num < Settings.Default.ATK_Skill_Mode)
									{
										num++;
									}
								}
								else
								{
									gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205590));
									Thread.Sleep(400);
								}
								num8 = 0;
								num5 = 0;
								flag = false;
								while (method_16(@class.int_3, out int_, out int_2, out int_3))
								{
									num8++;
									if (bool_36)
									{
										if ((Settings.Default.ATK_Skill_Mode > 0 && num >= Settings.Default.ATK_Skill_Mode) || gclass14_0.method_9(gclass12_0.SP) * 100 / gclass14_0.method_9(gclass12_0.MAX_SP) <= 5)
										{
											gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205590));
										}
										else
										{
											gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default.ATK_Skill.ToString());
											gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
											if (Settings.Default.ATK_Skill == 211)
											{
												Thread.Sleep(400);
											}
											if (Settings.Default.ATK_Skill_Mode > 0)
											{
												num5 = 0;
											}
											num++;
										}
										if (Settings.Default.ATK_Skill != 2308)
										{
											Thread.Sleep(200);
										}
									}
									else if (gclass14_0.method_9(gclass12_0.ATTACK) == 0)
									{
										gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205590));
										Thread.Sleep(400);
									}
									num4 = gclass14_0.method_9(gclass12_0.CHECK_ATTACK);
									num6 = gclass14_0.method_9(gclass12_0.CHECK_WALKING);
									if (num4 == 0 && num6 == 1)
									{
										num8 = 0;
										num5 = 0;
									}
									else if ((((bool_36 && num6 > 1) || (!bool_36 && num6 == 0 && (int_ == gclass14_0.method_9(gclass12_0.CHAR_ID) || (Math.Abs(int_2 - gclass14_0.method_9(gclass12_0.CHAR_X)) < 3 && Math.Abs(int_3 - gclass14_0.method_9(gclass12_0.CHAR_Y)) < 3))) || num6 > 0) && num4 == 1) || (bool_36 && num4 == 0 && (int_ == gclass14_0.method_9(gclass12_0.CHAR_ID) || (Math.Abs(int_2 - gclass14_0.method_9(gclass12_0.CHAR_X)) < 3 && Math.Abs(int_3 - gclass14_0.method_9(gclass12_0.CHAR_Y)) < 3))))
									{
										if (num8 > 30)
										{
											num8 = 0;
											if (gclass14_0.method_9(gclass12_0.ATTACK) > 0)
											{
												gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
											}
											if (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) > 0)
											{
												gclass14_0.method_10(gclass12_0.CHECK_ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
											}
											if (!@class.list_1.ToList().Any(@class.method_5))
											{
												@class.list_1.Add(@class.int_3);
											}
											@class.int_2 = 0;
											break;
										}
										Thread.Sleep(200);
										if (bool_36 && Settings.Default.ATK_Skill_Mode > 0)
										{
											num5 = 0;
										}
									}
									else
									{
										num4 = gclass14_0.method_9(gclass12_0.CHECK_ATTACK);
										num6 = gclass14_0.method_9(gclass12_0.CHECK_WALKING);
										if (num5 > 1)
										{
											num8 = 0;
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
										num5++;
										Thread.Sleep(200);
									}
									if (bool_26 && !flag && list_15 != null)
									{
										list_15 = struct27_0.method_3(gclass14_0.method_9(gclass12_0.CHAR_X), gclass14_0.method_9(gclass12_0.CHAR_Y));
										flag = true;
									}
									method_18();
									if (bool_10)
									{
										method_10();
									}
									if (@class.list_0.ToList().Count > 0)
									{
										@class.list_0.Clear();
									}
								}
								if (list_10.Find(Class15.class15_0.method_6) != null)
								{
									gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), list_10.Find(Class15.class15_0.method_7)!.method_0().ToString());
									if (bool_36)
									{
										gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
									}
									else
									{
										gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205590));
									}
								}
								num = 0;
								@class.int_2 = @class.int_3;
								num7 = 0;
							}
							list_10.Remove(list_10.Where(@class.method_8).FirstOrDefault());
							num8 = 0;
							num9 = 0;
						}
						else
						{
							num8++;
							if (num4 == 0 && num6 == 0)
							{
								if (num8 > 1)
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
							else if (num4 == 1 && num6 == 0)
							{
								if (num8 > 4)
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
							else if (num4 == 0 && num6 == 1)
							{
								num8 = 0;
							}
							else if (num4 == 1 && num6 == 2 && num8 > 30)
							{
								num8 = 0;
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
					num7++;
					if (num7 > 1)
					{
						if (bool_1 && method_9() > 0)
						{
							continue;
						}
						@class.int_2 = 0;
						if (bool_2 || bool_3)
						{
							method_19();
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
									Thread.Sleep(400);
								}
								if (!@class.list_0.ToList().Any(@class.method_13))
								{
									@class.list_0.Add(list_11[0]);
								}
								list_11.RemoveAt(0);
							}
						}
						if ((bool_27 || bool_26) && (bool_24 || bool_25) && num9 > 15)
						{
							num9 = 0;
							if (bool_25)
							{
								int_30 = 0;
								while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
								{
									int_30++;
									gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
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
								num14 = 0;
								@class.int_3 = 0;
							}
							else
							{
								method_3(Settings.Default.Wing_Hotkey);
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
							num7 = 0;
						}
						else if (bool_27)
						{
							if (bool_24 || bool_25)
							{
								num9++;
							}
							if (list_14 != null && int_34 > 0)
							{
								Class18 class2 = new Class18();
								@class.int_4 = gclass14_0.method_9(gclass12_0.CHAR_X);
								@class.int_5 = gclass14_0.method_9(gclass12_0.CHAR_Y);
								class2.point_0 = list_14.OrderBy(@class.method_14).FirstOrDefault();
								int num16 = list_14.FindIndex(class2.method_0);
								if (num16 == -1)
								{
									continue;
								}
								num16 += int_33;
								if (num16 < int_34)
								{
									Point point = list_14[num16];
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
										if (bool_25)
										{
											int_30 = 0;
											while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
											{
												int_30++;
												gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
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
										else if (bool_24)
										{
											method_3(Settings.Default.Wing_Hotkey);
										}
										Thread.Sleep(800);
										list_10.Clear();
										@class.list_1.Clear();
										num14 = 0;
										@class.int_3 = 0;
										int_29 = 0;
									}
									else if (int_29 > 5)
									{
										list_14 = struct27_0.method_0(Settings.Default.Path_Map);
									}
								}
								if (num16 > int_34 - 10)
								{
									list_14 = struct27_0.method_0(Settings.Default.Path_Map);
								}
								num12 = @class.int_4;
								num13 = @class.int_5;
								num7 = 0;
							}
						}
						else if (bool_26)
						{
							if (bool_24 || bool_25)
							{
								num9++;
							}
							if (list_15 == null)
							{
								list_15 = struct27_0.method_3(gclass14_0.method_9(gclass12_0.CHAR_X), gclass14_0.method_9(gclass12_0.CHAR_Y));
							}
							if (list_15 != null && list_15.Count() > 0)
							{
								Class21 class3 = new Class21();
								class3.gclass7_0 = list_15.OrderBy(@class.method_15).FirstOrDefault();
								int num17 = list_15.FindIndex(class3.method_0);
								if (num17 == -1)
								{
									continue;
								}
								num17 += 10;
								if (num17 < list_15.Count())
								{
									GClass7 gClass = list_15[num17];
									if (gclass14_0.method_9(gclass12_0.CHAR_TYPE) != 8 && gclass14_0.method_9(gclass12_0.CHAR_TYPE) != 4009)
									{
										gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205581));
									}
									else
									{
										gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205574));
									}
									gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
									gclass14_0.method_10(gclass12_0.SKILL_FLOOR_X, Class60.smethod_0(-2050205505), gClass.int_0.ToString());
									gclass14_0.method_10(gclass12_0.SKILL_FLOOR_Y, Class60.smethod_0(-2050205505), gClass.int_1.ToString());
									gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205627));
									if (num17 > list_15.Count() - 10)
									{
										list_15 = struct27_0.method_3(gClass.int_0, gClass.int_1);
									}
								}
								if (num11.Equals(num17) && gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 0)
								{
									list_15 = struct27_0.method_3(gclass14_0.method_9(gclass12_0.CHAR_X), gclass14_0.method_9(gclass12_0.CHAR_Y));
								}
								num11 = num17;
								num7 = 0;
							}
						}
						else if (bool_24)
						{
							method_3(Settings.Default.Wing_Hotkey);
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
							num7 = 0;
						}
						else if (bool_25)
						{
							int_30 = 0;
							while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
							{
								int_30++;
								gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
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
							num7 = 0;
						}
						else
						{
							if (@class.list_1.ToList().Count > 0)
							{
								@class.list_1.Clear();
							}
							if (@class.list_0.ToList().Count > 0)
							{
								@class.list_0.Clear();
							}
						}
					}
					else if (num7 > 0 && @class.list_1.ToList().Count > 0)
					{
						method_18();
						if (list_10.Count > 0)
						{
							using List<int>.Enumerator enumerator = @class.list_1.ToList().GetEnumerator();
							while (enumerator.MoveNext())
							{
								Class20 class4 = new Class20();
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
									if (bool_36 && gclass14_0.method_9(gclass12_0.SP) * 100 / gclass14_0.method_9(gclass12_0.MAX_SP) > 5)
									{
										num8 = 0;
										gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Settings.Default.ATK_Skill_Lv.ToString());
										if (Settings.Default.ATK_Skill_Mode > 0 && num < Settings.Default.ATK_Skill_Mode)
										{
											gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default.ATK_Skill.ToString());
											gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
											Thread.Sleep(800);
											while (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) == 0 && gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 1)
											{
												num8++;
												if (num8 > 10)
												{
													break;
												}
												Thread.Sleep(400);
											}
											gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205590));
											num++;
											Thread.Sleep(400);
										}
										else
										{
											gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default.ATK_Skill.ToString());
											gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
											Thread.Sleep(800);
											while (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) == 0 && gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 1)
											{
												num8++;
												if (num8 > 5)
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
									Thread.Sleep(200);
									num4 = gclass14_0.method_9(gclass12_0.CHECK_ATTACK);
									num6 = gclass14_0.method_9(gclass12_0.CHECK_WALKING);
									int_7 = 0;
									while ((num4 == 0 && num6 == 1) || (num4 == 1 && num6 == 2))
									{
										int_7++;
										if (int_7 > 70)
										{
											break;
										}
										Thread.Sleep(200);
										if (bool_10)
										{
											method_10();
										}
										num4 = gclass14_0.method_9(gclass12_0.CHECK_ATTACK);
										num6 = gclass14_0.method_9(gclass12_0.CHECK_WALKING);
									}
								}
								num = 0;
							}
						}
						else if (@class.list_1.ToList().Count > 0)
						{
							@class.list_1.Clear();
						}
					}
				}
			}
			else if (int_18 >= Settings.Default.ATK_Floor_Freq + 1)
			{
				if (gclass14_0.method_9(gclass12_0.CHECK_WALKING) < 17)
				{
					Thread.Sleep(400);
					if (gclass14_0.method_9(gclass12_0.LOCK_MONSTER) > 0)
					{
						gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default.ATK_Floor_Skill.ToString());
					gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Settings.Default.ATK_Floor_Skill_Lv.ToString());
					if (Settings.Default.ATK_Floor_Skill_Mode.Equals(0))
					{
						gclass14_0.method_10(gclass12_0.SKILL_FLOOR_X, Class60.smethod_0(-2050205505), gclass14_0.method_9(gclass12_0.CHAR_X).ToString());
						gclass14_0.method_10(gclass12_0.SKILL_FLOOR_Y, Class60.smethod_0(-2050205505), gclass14_0.method_9(gclass12_0.CHAR_Y).ToString());
					}
					else
					{
						gclass14_0.method_10(gclass12_0.SKILL_FLOOR_X, Class60.smethod_0(-2050205505), Settings.Default.ATK_Floor_Skill_X.ToString());
						gclass14_0.method_10(gclass12_0.SKILL_FLOOR_Y, Class60.smethod_0(-2050205505), Settings.Default.ATK_Floor_Skill_Y.ToString());
					}
					gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205627));
					Thread.Sleep(400);
					num10 = 0;
					while (gclass14_0.method_9(gclass12_0.CHECK_WALKING) > 0 && num10 < 9)
					{
						Thread.Sleep(600);
						int_18 = 0;
						num10++;
					}
				}
				else
				{
					int_18 = 0;
				}
			}
			method_20();
			if (class19_0.CancellationPending)
			{
				e.Cancel = true;
			}
			Thread.Sleep(400);
		}
	}

	private void method_1(object sender, DoWorkEventArgs e)
	{
		//IL_166c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1672: Invalid comparison between Unknown and I4
		//IL_174f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1755: Invalid comparison between Unknown and I4
		bool_52 = false;
		bool_51 = false;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
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
		while (!class19_1.CancellationPending)
		{
			num = gclass14_0.method_9(gclass12_0.HP);
			num6 = gclass14_0.method_9(gclass12_0.MAX_HP);
			num2 = gclass14_0.method_9(gclass12_0.SP);
			num7 = gclass14_0.method_9(gclass12_0.MAX_SP);
			num3 = ((num6 > 0) ? (num * 100 / num6) : 100);
			num4 = ((num7 > 0) ? (num2 * 100 / num7) : 100);
			((Control)label_4).set_Text(num2 + Class60.smethod_0(-2050205079) + num7);
			((Control)label_2).set_Text(num + Class60.smethod_0(-2050205079) + num6);
			if (bool_11 && num3 < Settings.Default.HP_Escape * 10 + 10)
			{
				method_3(Settings.Default.Wing_Hotkey);
				if (class19_0.IsBusy)
				{
					class19_0.method_0();
					class19_0.Dispose();
				}
				Thread.Sleep(800);
				if (!class19_0.IsBusy)
				{
					class19_0.RunWorkerAsync();
				}
			}
			if (bool_18)
			{
				if (num3 < Settings.Default.HP_Percent * 10 + 10)
				{
					method_3(Settings.Default.HP_Hotkey);
					if (bool_11)
					{
						int num15 = 0;
						while (num3 < Settings.Default.HP_Escape * 10 + 10 && num15 < 6)
						{
							if (num15 == 0)
							{
								method_3(Settings.Default.Wing_Hotkey);
								if (class19_0.IsBusy)
								{
									class19_0.method_0();
									class19_0.Dispose();
								}
								Thread.Sleep(800);
								if (!class19_0.IsBusy)
								{
									class19_0.RunWorkerAsync();
								}
							}
							else
							{
								method_3(Settings.Default.HP_Hotkey);
							}
							num = gclass14_0.method_9(gclass12_0.HP);
							num6 = gclass14_0.method_9(gclass12_0.MAX_HP);
							num3 = ((num6 > 0) ? (num * 100 / num6) : 100);
							Thread.Sleep(200);
							num15++;
						}
					}
					if (bool_17)
					{
						if (gclass14_0.method_9(gclass12_0.HP) <= num)
						{
							num9++;
							if (num9 > 5)
							{
								if (bool_25)
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
			else if (bool_19 && num3 < Settings.Default.HP_Percent * 10 + 10)
			{
				if (class19_0.IsBusy)
				{
					class19_0.method_0();
					class19_0.Dispose();
				}
				if (bool_25)
				{
					while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
					{
						method_3(Class60.smethod_0(-2050210591));
						Thread.Sleep(400);
					}
				}
				gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
				gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_0().ToString());
				gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
				gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
				method_18();
				Thread.Sleep(400);
				if (bool_11)
				{
					int num16 = 0;
					while (num3 < Settings.Default.HP_Escape * 10 + 10 && num16 < 5)
					{
						if (num16 == 0)
						{
							method_3(Settings.Default.Wing_Hotkey);
							Thread.Sleep(800);
						}
						else
						{
							gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
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
				if (!class19_0.IsBusy)
				{
					class19_0.RunWorkerAsync();
				}
			}
			if (bool_21 && num4 < Settings.Default.SP_Percent * 10 + 10)
			{
				method_3(Settings.Default.SP_Hotkey);
				if (bool_20)
				{
					if (gclass14_0.method_9(gclass12_0.SP) <= num2)
					{
						num10++;
						if (num10 > 5)
						{
							if (bool_25)
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
			if (bool_13)
			{
				num11 = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN);
				if (num11 == 0 && num4 < Settings.Default.SP_Sitdown * 10 + 10 && !flag2 && !list_10.Any(Class15.class15_0.method_8))
				{
					if (gclass14_0.method_9(gclass12_0.ATTACK) == 0 && gclass14_0.method_9(gclass12_0.CHECK_ATTACK) == 0)
					{
						if (class19_0.IsBusy)
						{
							class19_0.method_0();
							class19_0.Dispose();
						}
						if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
						{
							gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
						}
						Thread.Sleep(1000);
						if (bool_25)
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
					if (!class19_0.IsBusy)
					{
						class19_0.RunWorkerAsync();
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
					if (bool_25)
					{
						while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
						{
							method_3(Class60.smethod_0(-2050210591));
							Thread.Sleep(400);
						}
					}
					if (!class19_0.IsBusy)
					{
						class19_0.RunWorkerAsync();
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
							if (bool_25)
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
			if (bool_12)
			{
				num11 = gclass14_0.method_9(gclass12_0.CHECK_SITDOWN);
				if (num11 == 0 && num3 < Settings.Default.HP_Sitdown * 10 + 10 && !flag && !list_10.Any(Class15.class15_0.method_9))
				{
					if (gclass14_0.method_9(gclass12_0.ATTACK) == 0 && gclass14_0.method_9(gclass12_0.CHECK_ATTACK) == 0)
					{
						if (class19_0.IsBusy)
						{
							class19_0.method_0();
							class19_0.Dispose();
						}
						if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
						{
							gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
						}
						Thread.Sleep(1000);
						if (bool_25)
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
					if (!class19_0.IsBusy)
					{
						class19_0.RunWorkerAsync();
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
					if (bool_25)
					{
						while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
						{
							method_3(Class60.smethod_0(-2050210591));
							Thread.Sleep(400);
						}
					}
					if (!class19_0.IsBusy)
					{
						class19_0.RunWorkerAsync();
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
							if (bool_25)
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
			if (bool_28)
			{
				num5 = gclass14_0.method_9(gclass12_0.WEIGHT);
				num8 = gclass14_0.method_9(gclass12_0.MAX_WEIGHT);
				if (num8 > 0)
				{
					if (Settings.Default.Over_Weight >= 8)
					{
						if (num5 * 100 / num8 >= Settings.Default.Over_Weight * 10 + 9)
						{
							flag6 = true;
							break;
						}
					}
					else if (num5 * 100 / num8 >= Settings.Default.Over_Weight * 10 + 10)
					{
						flag6 = true;
						break;
					}
				}
			}
			if (gclass14_0.method_9(gclass12_0.CHECK_WALKING) == 3 && gclass14_0.method_9(gclass12_0.CHECK_SITDOWN) == 1 && gclass14_0.method_9(gclass12_0.CHECK_DEAD) == 1)
			{
				if (bool_44)
				{
					bool_51 = true;
					break;
				}
				if (bool_42 || bool_43)
				{
					if (bool_42)
					{
						soundPlayer_1.Play();
						Thread.Sleep(5000);
					}
					if (bool_43 && !bool_50)
					{
						bool_50 = true;
						Class55.smethod_8(Settings.Default.Line_Token, int_0, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050205603));
					}
				}
			}
			if (bool_22 && gclass14_0.method_9(gclass12_0.CHECK_ARROW) == 0)
			{
				if (class19_0.IsBusy)
				{
					class19_0.method_0();
					class19_0.Dispose();
				}
				if (gclass14_0.method_9(gclass12_0.ATTACK) > 0)
				{
					gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
				}
				method_3(Settings.Default.Arrow_Box_Hotkey);
				Thread.Sleep(400);
				method_3(Settings.Default.Arrow_Hotkey);
				Thread.Sleep(600);
				if (!class19_0.IsBusy)
				{
					class19_0.RunWorkerAsync();
				}
			}
			if (!bool_23 || gclass14_0.method_9(gclass12_0.CHECK_ARROW) != 0)
			{
				if (bool_22 && gclass14_0.method_9(gclass12_0.CHECK_ARROW) == 0)
				{
					if (bool_42)
					{
						soundPlayer_1.Play();
						Thread.Sleep(5000);
					}
					if (bool_43 && !bool_48)
					{
						bool_48 = true;
						Class55.smethod_8(Settings.Default.Line_Token, int_0, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050205662));
					}
				}
				if ((!bool_42 && !bool_43 && !bool_45) || !method_12() || !bool_45)
				{
					if ((bool_42 || bool_43) && !string.IsNullOrEmpty(gclass14_0.method_8(gclass12_0.MAP_NAME)) && !gclass14_0.method_8(gclass12_0.MAP_NAME).Equals(string_1))
					{
						if (bool_42)
						{
							soundPlayer_1.Play();
							Thread.Sleep(5000);
						}
						if (bool_43 && !bool_46)
						{
							bool_46 = true;
							string text = gclass14_0.method_8(gclass12_0.MAP_NAME);
							if (text.IndexOf('\0') > 0)
							{
								text = text.Substring(0, text.IndexOf('.'));
							}
							Class55.smethod_8(Settings.Default.Line_Token, int_0, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050205685) + text);
						}
					}
					if ((!bool_42 && !bool_43) || gclass14_0.method_9(gclass12_0.CHECK_DISCONNECT) == 0)
					{
						if (class19_1.CancellationPending)
						{
							e.Cancel = true;
						}
						Thread.Sleep(300);
						continue;
					}
					if (bool_42)
					{
						soundPlayer_1.Play();
						Thread.Sleep(5000);
					}
					if (bool_43)
					{
						Class55.smethod_8(Settings.Default.Line_Token, int_0, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050203668));
					}
					break;
				}
				bool_52 = true;
				break;
			}
			flag5 = true;
			break;
		}
		try
		{
			timer_0.Stop();
			if (class19_0.IsBusy)
			{
				class19_0.method_0();
				class19_0.Dispose();
			}
			if (flag3 || flag4 || flag5 || flag6)
			{
				if (bool_25)
				{
					while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) != 0)
					{
						method_3(Class60.smethod_0(-2050210591));
						Thread.Sleep(1000);
					}
				}
				method_3(Settings.Default.BWing_Hotkey);
				Thread.Sleep(2000);
				int_30 = 0;
				while (gclass14_0.method_8(gclass12_0.MAP_NAME).Equals(string_1))
				{
					int_30++;
					if (int_30 > 2)
					{
						break;
					}
					method_3(Settings.Default.BWing_Hotkey);
					Thread.Sleep(2000);
				}
				if (bool_42 || bool_43)
				{
					if (bool_42)
					{
						soundPlayer_1.Play();
					}
					if (bool_43)
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
						else if (flag5)
						{
							text2 = Class60.smethod_0(-2050205662);
						}
						if (int_30 > 2)
						{
							Class55.smethod_8(Settings.Default.Line_Token, int_0, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050203782) + text2);
						}
						else
						{
							Class55.smethod_8(Settings.Default.Line_Token, int_0, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050203823) + text2);
						}
					}
				}
			}
			if (bool_52)
			{
				try
				{
					Process.GetProcessById(int_1).Kill();
				}
				catch
				{
					TerminateProcess(intptr_0, 0u);
				}
				if (bool_42 || bool_43)
				{
					if (bool_42)
					{
						soundPlayer_1.Play();
					}
					if (bool_43)
					{
						Class55.smethod_8(Settings.Default.Line_Token, int_0, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050203844));
					}
				}
			}
			if (bool_51)
			{
				try
				{
					Process.GetProcessById(int_1).Kill();
				}
				catch
				{
					TerminateProcess(intptr_0, 0u);
				}
				if (bool_42 || bool_43)
				{
					if (bool_42)
					{
						soundPlayer_1.Play();
					}
					if (bool_43)
					{
						Class55.smethod_8(Settings.Default.Line_Token, int_0, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050203935));
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
			if (class19_0.IsBusy)
			{
				class19_0.method_0();
				class19_0.Dispose();
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
		if (bool_15)
		{
			int_18++;
		}
		if (bool_29)
		{
			int_17++;
		}
		if (bool_30)
		{
			int_19++;
		}
		if (bool_31)
		{
			int_20++;
		}
		if (bool_32)
		{
			int_21++;
		}
		if (bool_33)
		{
			int_22++;
		}
		if (bool_34)
		{
			int_23++;
		}
		if (bool_35)
		{
			int_24++;
		}
		if (bool_37)
		{
			int_25++;
		}
		if (bool_38)
		{
			int_26++;
		}
		if (bool_39)
		{
			int_27++;
		}
		if (bool_40)
		{
			int_28++;
		}
		if (bool_52)
		{
			bool_52 = false;
			button_0.PerformClick();
		}
		if (bool_51)
		{
			bool_51 = false;
			button_0.PerformClick();
		}
		if (bool_46)
		{
			int_36++;
			if (int_36 > 300)
			{
				int_36 = 0;
				bool_46 = false;
			}
		}
		if (bool_48)
		{
			int_38++;
			if (int_38 > 300)
			{
				int_38 = 0;
				bool_48 = false;
			}
		}
		if (bool_49)
		{
			int_39++;
			if (int_39 > 300)
			{
				int_39 = 0;
				bool_49 = false;
			}
		}
		if (bool_47)
		{
			int_37++;
			if (int_37 > 300)
			{
				int_37 = 0;
				bool_47 = false;
			}
		}
		if (bool_50)
		{
			int_40++;
			if (int_40 > 300)
			{
				int_40 = 0;
				bool_50 = false;
			}
		}
		if (!class19_0.IsBusy && !class19_1.IsBusy)
		{
			int_35++;
			if (int_35 > 10)
			{
				int_35 = 0;
				class19_0.RunWorkerAsync();
				class19_1.RunWorkerAsync();
				if (bool_43)
				{
					Class55.smethod_8(Settings.Default.Line_Token, int_0, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050204044));
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
		bool_14 = checkBox_14.get_Checked();
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
		bool_16 = checkBox_25.get_Checked();
	}

	private void checkBox_35_CheckedChanged(object sender, EventArgs e)
	{
		bool_10 = checkBox_35.get_Checked();
	}

	private void checkBox_17_CheckedChanged(object sender, EventArgs e)
	{
		bool_11 = checkBox_17.get_Checked();
	}

	private void checkBox_31_CheckedChanged(object sender, EventArgs e)
	{
		bool_12 = checkBox_31.get_Checked();
	}

	private void checkBox_16_CheckedChanged(object sender, EventArgs e)
	{
		bool_13 = checkBox_16.get_Checked();
	}

	private void checkBox_33_CheckedChanged(object sender, EventArgs e)
	{
		bool_17 = checkBox_33.get_Checked();
		if (bool_17 && !bool_18)
		{
			checkBox_5.set_Checked(true);
		}
	}

	private void checkBox_34_CheckedChanged(object sender, EventArgs e)
	{
		bool_20 = checkBox_34.get_Checked();
		if (bool_20 && !bool_21)
		{
			checkBox_3.set_Checked(true);
		}
	}

	private void checkBox_5_CheckedChanged(object sender, EventArgs e)
	{
		bool_18 = checkBox_5.get_Checked();
		if (bool_18)
		{
			checkBox_7.set_Checked(false);
		}
		else if (bool_17)
		{
			checkBox_33.set_Checked(false);
		}
	}

	private void checkBox_7_CheckedChanged(object sender, EventArgs e)
	{
		bool_19 = checkBox_7.get_Checked();
		if (bool_19)
		{
			checkBox_5.set_Checked(false);
		}
	}

	private void checkBox_3_CheckedChanged(object sender, EventArgs e)
	{
		bool_21 = checkBox_3.get_Checked();
		if (!bool_21 && bool_20)
		{
			checkBox_34.set_Checked(false);
		}
	}

	private void checkBox_42_CheckedChanged(object sender, EventArgs e)
	{
		bool_22 = checkBox_42.get_Checked();
	}

	private void checkBox_43_CheckedChanged(object sender, EventArgs e)
	{
		bool_23 = checkBox_43.get_Checked();
	}

	private void checkBox_8_CheckedChanged(object sender, EventArgs e)
	{
		bool_36 = checkBox_8.get_Checked();
		if (bool_36)
		{
			checkBox_36.set_Checked(false);
		}
	}

	private void checkBox_36_CheckedChanged(object sender, EventArgs e)
	{
		bool_15 = checkBox_36.get_Checked();
		if (bool_15)
		{
			checkBox_8.set_Checked(false);
		}
	}

	private void checkBox_9_CheckedChanged(object sender, EventArgs e)
	{
		bool_29 = checkBox_9.get_Checked();
		if (bool_29)
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
		bool_37 = checkBox_12.get_Checked();
	}

	private void checkBox_11_CheckedChanged(object sender, EventArgs e)
	{
		bool_38 = checkBox_11.get_Checked();
	}

	private void checkBox_15_CheckedChanged(object sender, EventArgs e)
	{
		bool_39 = checkBox_15.get_Checked();
	}

	private void checkBox_27_CheckedChanged(object sender, EventArgs e)
	{
		bool_40 = checkBox_27.get_Checked();
	}

	private void checkBox_6_CheckedChanged(object sender, EventArgs e)
	{
		bool_24 = checkBox_6.get_Checked();
		if (bool_24)
		{
			checkBox_4.set_Checked(false);
		}
	}

	private void checkBox_4_CheckedChanged(object sender, EventArgs e)
	{
		bool_25 = checkBox_4.get_Checked();
		if (bool_25)
		{
			checkBox_6.set_Checked(false);
		}
	}

	private void checkBox_2_CheckedChanged(object sender, EventArgs e)
	{
		bool_26 = checkBox_2.get_Checked();
		if (bool_26)
		{
			checkBox_30.set_Checked(false);
		}
	}

	private void checkBox_30_CheckedChanged(object sender, EventArgs e)
	{
		bool_27 = checkBox_30.get_Checked();
		if (bool_27)
		{
			checkBox_2.set_Checked(false);
		}
	}

	private void checkBox_1_CheckedChanged(object sender, EventArgs e)
	{
		bool_28 = checkBox_1.get_Checked();
	}

	private void checkBox_24_CheckedChanged(object sender, EventArgs e)
	{
		bool_44 = checkBox_24.get_Checked();
	}

	private void checkBox_37_CheckedChanged(object sender, EventArgs e)
	{
		bool_45 = checkBox_37.get_Checked();
	}

	private void checkBox_10_CheckedChanged(object sender, EventArgs e)
	{
		bool_30 = checkBox_10.get_Checked();
	}

	private void checkBox_18_CheckedChanged(object sender, EventArgs e)
	{
		bool_31 = checkBox_18.get_Checked();
	}

	private void checkBox_19_CheckedChanged(object sender, EventArgs e)
	{
		bool_32 = checkBox_19.get_Checked();
	}

	private void checkBox_20_CheckedChanged(object sender, EventArgs e)
	{
		bool_33 = checkBox_20.get_Checked();
	}

	private void checkBox_21_CheckedChanged(object sender, EventArgs e)
	{
		bool_34 = checkBox_21.get_Checked();
	}

	private void checkBox_22_CheckedChanged(object sender, EventArgs e)
	{
		bool_35 = checkBox_22.get_Checked();
	}

	private void checkBox_40_CheckedChanged(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		bool_41 = checkBox_40.get_Checked();
		if (bool_41 && !checkBox_10.get_Checked() && !checkBox_18.get_Checked() && !checkBox_19.get_Checked() && !checkBox_20.get_Checked() && !checkBox_21.get_Checked() && !checkBox_22.get_Checked() && !checkBox_12.get_Checked() && !checkBox_11.get_Checked() && !checkBox_15.get_Checked() && !checkBox_27.get_Checked())
		{
			checkBox_40.set_Checked(false);
			Form val = new Form();
			val.set_TopMost(true);
			MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050204109), Class60.smethod_0(-2050209943), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void checkBox_39_CheckedChanged(object sender, EventArgs e)
	{
		bool_42 = checkBox_39.get_Checked();
	}

	private void checkBox_41_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		bool_43 = checkBox_41.get_Checked();
		if (bool_43 && string.IsNullOrEmpty(Settings.Default.Line_Token))
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

	private void checkBox_44_CheckedChanged(object sender, EventArgs e)
	{
		bool_9 = checkBox_44.get_Checked();
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
					method_23(JsonConvert.DeserializeObject<GClass17>(streamReader.ReadToEnd()));
					gcontrol5_0.method_0();
					gcontrol0_0.method_0();
					gcontrol1_0.method_0();
					gcontrol2_0.method_0(null);
					gcontrol4_0.method_0(null);
					gcontrol3_0.method_0(null);
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
					string value = JsonConvert.SerializeObject((object)method_24());
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

	private void toolStripMenuItem_5_Click(object sender, EventArgs e)
	{
		tabControl_0.set_SelectedIndex(4);
	}

	private void toolStripMenuItem_6_Click(object sender, EventArgs e)
	{
		tabControl_0.set_SelectedIndex(5);
	}

	private void toolStripMenuItem_7_Click(object sender, EventArgs e)
	{
		tabControl_0.set_SelectedIndex(6);
	}

	private void toolStripMenuItem_8_Click(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			FormCollection openForms = Application.get_OpenForms();
			bool flag = false;
			bool flag2 = false;
			foreach (Form item in (ReadOnlyCollectionBase)(object)openForms)
			{
				Form val = item;
				if (!(((Control)val).get_Text() == Class60.smethod_0(-2050204294) + string_0))
				{
					if (((Control)val).get_Text() == Class60.smethod_0(-2050204363) + string_0)
					{
						flag = true;
					}
					continue;
				}
				flag2 = true;
				break;
			}
			if (!flag2)
			{
				if (!flag)
				{
					if (process_0.Length > 1)
					{
						GForm4 gForm = new GForm4();
						gForm.int_0 = process_0[1].Id;
						gForm.int_1 = int_6;
						gForm.intptr_0 = process_0[1].MainWindowHandle;
						gForm.string_0 = string_0;
						gForm.gclass1_0 = gclass1_0;
						((Control)gForm).Show();
					}
					else
					{
						Form val2 = new Form();
						val2.set_TopMost(true);
						MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050204480), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
					}
				}
				else if (process_0.Length > 2)
				{
					GForm7 gForm2 = new GForm7();
					gForm2.int_0 = process_0[2].Id;
					gForm2.int_1 = int_6;
					gForm2.intptr_0 = process_0[2].MainWindowHandle;
					gForm2.string_0 = string_0;
					gForm2.gclass1_0 = gclass1_0;
					((Control)gForm2).Show();
				}
				else
				{
					Form val3 = new Form();
					val3.set_TopMost(true);
					MessageBox.Show((IWin32Window)val3, Class60.smethod_0(-2050204553), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
			}
			else
			{
				Form val4 = new Form();
				val4.set_TopMost(true);
				MessageBox.Show((IWin32Window)val4, Class60.smethod_0(-2050206722), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}
		catch
		{
			Form val5 = new Form();
			val5.set_TopMost(true);
			MessageBox.Show((IWin32Window)val5, Class60.smethod_0(-2050206787), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	private void toolStripMenuItem_9_Click(object sender, EventArgs e)
	{
		SetForegroundWindow(intptr_0);
	}

	private void method_3(string string_2)
	{
		PostMessage(intptr_0, 256u, dictionary_0[string_2], 0);
		Thread.Sleep(100);
		PostMessage(intptr_0, 257u, dictionary_0[string_2], 0);
		Thread.Sleep(100);
	}

	private void method_4(int int_41, int int_42)
	{
		PostMessage_1(intptr_0, 513u, (IntPtr)1, smethod_0(int_41, int_42));
		Thread.Sleep(100);
		PostMessage_1(intptr_0, 514u, (IntPtr)0, smethod_0(int_41, int_42));
	}

	private int method_5(int int_41)
	{
		if (int_41 % 2 != 0)
		{
			int_41++;
		}
		return int_41;
	}

	private Point method_6(int int_41)
	{
		return int_41 switch
		{
			1 => new Point(method_5(int_11 - int_9 / 6), method_5(int_12 - int_10 / 6)), 
			8 => new Point(method_5(int_11 - int_9 * 30 / 100), method_5(int_12)), 
			7 => new Point(method_5(int_11 - int_9 / 6), method_5(int_12 + int_10 / 6)), 
			3 => new Point(method_5(int_11 + int_9 / 6), method_5(int_12 - int_10 / 6)), 
			4 => new Point(method_5(int_11 + int_9 * 30 / 100), method_5(int_12)), 
			5 => new Point(method_5(int_11 + int_9 / 6), method_5(int_12 + int_10 / 6)), 
			2 => new Point(method_5(int_11), method_5(int_12 - int_10 * 35 / 100)), 
			_ => new Point(method_5(int_11), method_5(int_12 + int_10 * 30 / 100)), 
		};
	}

	private List<int> method_7()
	{
		List<int> list = new List<int>();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		foreach (string item in list_1)
		{
			num2 = gclass14_0.method_9(item);
			if ((num2 > 0 && num2 < 200) || (num2 > 4000 && num2 < 4220))
			{
				num3 = gclass14_0.method_9(list_0[num]);
				if (num3 > 10000 && num3 < 99999999)
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

	private bool method_8(int int_41)
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
				if (num3 > 100000 && num3 < 99999999 && int_41 == num4)
				{
					return true;
				}
			}
			num++;
		}
		return false;
	}

	private int method_9()
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
			if (bool_42 || bool_43)
			{
				if (bool_42)
				{
					soundPlayer_2.Play();
				}
				if (bool_43 && !bool_47)
				{
					bool_47 = true;
					Class55.smethod_8(Settings.Default.Line_Token, int_0, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050206904));
				}
			}
			return gclass14_0.method_9(list_5[num]);
		}
		return result;
	}

	private void method_10()
	{
		bool flag = false;
		int num = 0;
		foreach (string item in list_1)
		{
			num = gclass14_0.method_9(item);
			if (num == 45 || method_11())
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
		if (bool_25)
		{
			int_30 = 0;
			while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
			{
				int_30++;
				gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
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
			method_3(Settings.Default.Wing_Hotkey);
		}
		Thread.Sleep(800);
		if (list_10.ToList().Count() > 0)
		{
			list_10.Clear();
		}
		if (list_11.ToList().Count() > 0)
		{
			list_11.Clear();
		}
	}

	private bool method_11()
	{
		IntPtr pointer = IntPtr.Add(IntPtr.Zero, Convert.ToInt32(gclass12_0.WARP_PRIEST, 16));
		int num = 0;
		while (true)
		{
			if (num <= 28)
			{
				string s = num.ToString(Class60.smethod_0(-2050211142));
				IntPtr intPtr = IntPtr.Add(pointer, int.Parse(s, NumberStyles.HexNumber));
				if (gclass14_0.method_9(Class60.smethod_0(-2050206881) + intPtr.ToString(Class60.smethod_0(-2050211142))).Equals(58))
				{
					break;
				}
				num += 4;
				continue;
			}
			return false;
		}
		return true;
	}

	private bool method_12()
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if (gclass14_0.method_9(gclass12_0.CHECK_WEAPON) == 0)
		{
			SetForegroundWindow(intptr_0);
			if (bool_42 || bool_43)
			{
				if (bool_42)
				{
					soundPlayer_0.Play();
				}
				if (bool_43 && !bool_49)
				{
					bool_49 = true;
					Class55.smethod_8(Settings.Default.Line_Token, int_0, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050206929));
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
			if (bool_42 || bool_43)
			{
				if (bool_42)
				{
					soundPlayer_0.Play();
				}
				if (bool_43 && !bool_49)
				{
					bool_49 = true;
					Class55.smethod_8(Settings.Default.Line_Token, int_0, ((Control)label_0).get_Text().Trim(), Class60.smethod_0(-2050206929));
				}
			}
			return true;
		}
		return false;
	}

	private double method_13(int int_41, int int_42)
	{
		int num = gclass14_0.method_9(gclass12_0.CHAR_X);
		int num2 = gclass14_0.method_9(gclass12_0.CHAR_Y);
		if (num < 0 || num > 1000 || num2 < 0 || num2 > 1000)
		{
			num = int_41 + 10;
			num2 = int_42 + 10;
		}
		double num3 = method_14(int_42 - num2);
		double num4 = method_14(int_41 - num);
		double num5 = Math.Sin(num4 / 2.0) * Math.Sin(num4 / 2.0) + Math.Cos(method_14(num)) * Math.Cos(method_14(int_41)) * (Math.Sin(num3 / 2.0) * Math.Sin(num3 / 2.0));
		double num6 = 2.0 * Math.Atan2(Math.Sqrt(num5), Math.Sqrt(1.0 - num5));
		return num6 * 6378.16;
	}

	private double method_14(double double_0)
	{
		return double_0 * Math.PI / 180.0;
	}

	private bool method_15(int int_41)
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
			if (!struct26_0.method_0().ContainsKey(num3) || num2 != int_41)
			{
				num++;
				continue;
			}
			if (num4 != 0 && num4 != int_5)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private bool method_16(int int_41, out int int_42, out int int_43, out int int_44)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		foreach (string item in list_1)
		{
			num3 = gclass14_0.method_9(item);
			if (num4 >= 3)
			{
				break;
			}
			if (num3 == 0)
			{
				num++;
				num4++;
				continue;
			}
			num2 = gclass14_0.method_9(list_0[num].ToString());
			int_43 = gclass14_0.method_9(list_2[num].ToString());
			int_44 = gclass14_0.method_9(list_3[num].ToString());
			int_42 = gclass14_0.method_9(list_4[num].ToString());
			if (!struct26_0.method_0().ContainsKey(num3) || num2 != int_41)
			{
				num++;
				continue;
			}
			return true;
		}
		int_43 = 0;
		int_44 = 0;
		int_42 = 0;
		return false;
	}

	private List<Class22> method_17()
	{
		Class23 @class = new Class23();
		List<Class22> list = new List<Class22>();
		int index = 0;
		@class.int_0 = 0;
		int num = 0;
		int num2 = 0;
		bool flag = false;
		foreach (string item in list_1)
		{
			num = gclass14_0.method_9(item);
			@class.int_0 = gclass14_0.method_9(list_0[index].ToString());
			gclass14_0.method_9(list_2[index].ToString());
			gclass14_0.method_9(list_3[index].ToString());
			num2 = gclass14_0.method_9(list_4[index++].ToString());
			if (struct26_0.method_0().ContainsKey(num))
			{
				flag = ((num2 == int_5) ? true : false);
				if (!list.ToList().Any(@class.method_0))
				{
					Class22 class2 = new Class22();
					class2.method_1(@class.int_0);
					class2.method_3(flag);
					class2.method_5(0.0);
					list.Add(class2);
				}
			}
		}
		return list;
	}

	private void method_18()
	{
		Class24 @class = new Class24();
		List<Class22> list = new List<Class22>();
		if (list_10.ToList().Count > 0)
		{
			list_10.Clear();
		}
		if (list_12.ToList().Count > 0)
		{
			list_12.Clear();
		}
		if (list_13.ToList().Count > 0)
		{
			list_13.Clear();
		}
		bool flag = false;
		int num = 0;
		@class.int_0 = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		foreach (string item in list_1)
		{
			num2 = gclass14_0.method_9(item);
			if (num6 >= 3)
			{
				break;
			}
			if (num2 == 0)
			{
				num++;
				num6++;
				continue;
			}
			@class.int_0 = gclass14_0.method_9(list_0[num].ToString());
			num3 = gclass14_0.method_9(list_2[num].ToString());
			num4 = gclass14_0.method_9(list_3[num].ToString());
			num5 = gclass14_0.method_9(list_4[num].ToString());
			if (struct26_0.method_0().ContainsKey(num2))
			{
				if (bool_7 && int_3.Contains(num2) && @class.int_0 > 0 && @class.int_0 < 90000)
				{
					if (class19_0.IsBusy && class19_1.IsBusy)
					{
						class19_1.method_0();
						class19_1.Dispose();
					}
					if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
					{
						gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					if (bool_25)
					{
						int_30 = 0;
						while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
						{
							int_30++;
							gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
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
						method_3(Settings.Default.Wing_Hotkey);
					}
					Thread.Sleep(800);
					if (!class19_1.IsBusy)
					{
						class19_1.RunWorkerAsync();
					}
					break;
				}
				if (bool_14 && int_2.Length != 0)
				{
					if (int_2.Contains(num2) && ((!bool_5 && (gclass14_0.method_9(gclass12_0.CHAR_X) == 0 || Math.Abs(num3 - gclass14_0.method_9(gclass12_0.CHAR_X)) < 14) && (gclass14_0.method_9(gclass12_0.CHAR_Y) == 0 || Math.Abs(num4 - gclass14_0.method_9(gclass12_0.CHAR_Y)) < 14)) || (bool_5 && (gclass14_0.method_9(gclass12_0.CHAR_X) == 0 || Math.Abs(num3 - gclass14_0.method_9(gclass12_0.CHAR_X)) <= Settings.Default.Distance_Attack + 2) && (gclass14_0.method_9(gclass12_0.CHAR_Y) == 0 || Math.Abs(num4 - gclass14_0.method_9(gclass12_0.CHAR_Y)) <= Settings.Default.Distance_Attack + 2))) && @class.int_0 > 0 && @class.int_0 < 90000 && (@class.int_0 < 47000 || @class.int_0 > 50000))
					{
						if (!list_10.ToList().Any(@class.method_0) && !list.ToList().Any(@class.method_1))
						{
							if (bool_6 || (!bool_6 && (num5 == 0 || num5 == int_5)))
							{
								if (num5 == int_5)
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
								Class22 class2 = new Class22();
								class2.method_1(@class.int_0);
								class2.method_3(flag);
								class2.method_5(method_13(num3, num4));
								list.Add(class2);
							}
						}
						else if (num5 == int_5 && !list_12.ToList().Any(@class.method_3))
						{
							list_12.Add(@class.int_0);
						}
					}
				}
				else if (((!bool_5 && (gclass14_0.method_9(gclass12_0.CHAR_X) == 0 || Math.Abs(num3 - gclass14_0.method_9(gclass12_0.CHAR_X)) < 14) && (gclass14_0.method_9(gclass12_0.CHAR_Y) == 0 || Math.Abs(num4 - gclass14_0.method_9(gclass12_0.CHAR_Y)) < 14)) || (bool_5 && (gclass14_0.method_9(gclass12_0.CHAR_X) == 0 || Math.Abs(num3 - gclass14_0.method_9(gclass12_0.CHAR_X)) <= Settings.Default.Distance_Attack + 2) && (gclass14_0.method_9(gclass12_0.CHAR_Y) == 0 || Math.Abs(num4 - gclass14_0.method_9(gclass12_0.CHAR_Y)) <= Settings.Default.Distance_Attack + 2))) && @class.int_0 > 0 && @class.int_0 < 90000 && (@class.int_0 < 47000 || @class.int_0 > 50000))
				{
					if (!list_10.ToList().Any(@class.method_4) && !list.ToList().Any(@class.method_5))
					{
						if (bool_6 || (!bool_6 && (num5 == 0 || num5 == int_5)))
						{
							if (num5 == int_5)
							{
								flag = true;
								if (!list_12.ToList().Any(@class.method_6))
								{
									list_12.Add(@class.int_0);
								}
							}
							else
							{
								flag = false;
							}
							Class22 class3 = new Class22();
							class3.method_1(@class.int_0);
							class3.method_3(flag);
							class3.method_5(method_13(num3, num4));
							list.Add(class3);
						}
					}
					else if (num5 == int_5 && !list_12.ToList().Any(@class.method_7))
					{
						list_12.Add(@class.int_0);
					}
				}
				if (num5 == int_5 && !list_12.ToList().Any(@class.method_8))
				{
					list_12.Add(@class.int_0);
				}
				if (!list_13.ToList().Any(@class.method_9))
				{
					list_13.Add(@class.int_0);
				}
				if ((bool_9 && list_13.ToList().Count >= Settings.Default.Monster_Over_Escape + 2) || (bool_8 && list_12.ToList().Count >= Settings.Default.Scrum_Escape + 1))
				{
					list_12.Clear();
					list_13.Clear();
					if (class19_0.IsBusy && class19_1.IsBusy)
					{
						class19_1.method_0();
						class19_1.Dispose();
					}
					if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
					{
						gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
					}
					if (bool_25)
					{
						int_30 = 0;
						while (gclass14_0.method_9(gclass12_0.CHECK_TELEPORT) == 0 && int_30 < 4)
						{
							int_30++;
							gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
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
						method_3(Settings.Default.Wing_Hotkey);
					}
					Thread.Sleep(800);
					if (!class19_1.IsBusy)
					{
						class19_1.RunWorkerAsync();
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

	private void method_19()
	{
		Class16 @class = new Class16();
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

	private void method_20()
	{
		if (gclass14_0.method_9(gclass12_0.CHECK_ATTACK) != 0 || (bool_41 && (!bool_41 || method_17().Count() > 3 || method_17().Count(Class15.class15_0.method_10) > 0)))
		{
			return;
		}
		if (bool_29 && int_17 >= Settings.Default.AB_Freq + 1)
		{
			int_17 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_2().ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(1000);
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), struct25_0.method_1().ToString());
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(2000);
		}
		if (bool_30 && int_19 >= Settings.Default.SKILLBUFF_1_Freq + 1)
		{
			int_19 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default.SKILLBUFF_1.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(3000);
		}
		if (bool_31 && int_20 >= Settings.Default.SKILLBUFF_2_Freq + 1)
		{
			int_20 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default.SKILLBUFF_2.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			Thread.Sleep(2000);
		}
		if (bool_32 && int_21 >= Settings.Default.SKILLBUFF_3_Freq + 1)
		{
			int_21 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default.SKILLBUFF_3.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			if (Settings.Default.SKILLBUFF_3.Equals(2286))
			{
				Thread.Sleep(4000);
				if (gclass14_0.method_9(gclass12_0.CHECK_MOUSE) == 0)
				{
					gclass14_0.method_10(gclass12_0.CHECK_MOUSE, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205598));
				}
				gclass14_0.method_10(gclass12_0.MOUSE_X, Class60.smethod_0(-2050205505), (int_9 * 40 / 100).ToString());
				gclass14_0.method_10(gclass12_0.MOUSE_Y, Class60.smethod_0(-2050205505), (int_10 * 45 / 100).ToString());
				Thread.Sleep(400);
				method_4(0, 0);
				gclass14_0.method_10(gclass12_0.MOUSE_X, Class60.smethod_0(-2050205505), (int_9 / 2).ToString());
				gclass14_0.method_10(gclass12_0.MOUSE_Y, Class60.smethod_0(-2050205505), (int_10 * 64 / 100).ToString());
				Thread.Sleep(400);
				method_4(0, 0);
				Thread.Sleep(1000);
			}
			else
			{
				Thread.Sleep(2000);
			}
		}
		if (bool_33 && int_22 >= Settings.Default.SKILLBUFF_4_Freq + 1)
		{
			int_22 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default.SKILLBUFF_4.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			if (Settings.Default.SKILLBUFF_4.Equals(2286))
			{
				Thread.Sleep(4000);
				if (gclass14_0.method_9(gclass12_0.CHECK_MOUSE) == 0)
				{
					gclass14_0.method_10(gclass12_0.CHECK_MOUSE, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205598));
				}
				gclass14_0.method_10(gclass12_0.MOUSE_X, Class60.smethod_0(-2050205505), (int_9 * 40 / 100).ToString());
				gclass14_0.method_10(gclass12_0.MOUSE_Y, Class60.smethod_0(-2050205505), (int_10 * 45 / 100).ToString());
				Thread.Sleep(400);
				method_4(0, 0);
				gclass14_0.method_10(gclass12_0.MOUSE_X, Class60.smethod_0(-2050205505), (int_9 / 2).ToString());
				gclass14_0.method_10(gclass12_0.MOUSE_Y, Class60.smethod_0(-2050205505), (int_10 * 64 / 100).ToString());
				Thread.Sleep(400);
				method_4(0, 0);
				Thread.Sleep(1000);
			}
			else
			{
				Thread.Sleep(2000);
			}
		}
		if (bool_34 && int_23 >= Settings.Default.SKILLBUFF_5_Freq + 1)
		{
			int_23 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default.SKILLBUFF_5.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			if (Settings.Default.SKILLBUFF_5.Equals(2286))
			{
				Thread.Sleep(4000);
				if (gclass14_0.method_9(gclass12_0.CHECK_MOUSE) == 0)
				{
					gclass14_0.method_10(gclass12_0.CHECK_MOUSE, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205598));
				}
				gclass14_0.method_10(gclass12_0.MOUSE_X, Class60.smethod_0(-2050205505), (int_9 * 40 / 100).ToString());
				gclass14_0.method_10(gclass12_0.MOUSE_Y, Class60.smethod_0(-2050205505), (int_10 * 45 / 100).ToString());
				Thread.Sleep(400);
				method_4(0, 0);
				gclass14_0.method_10(gclass12_0.MOUSE_X, Class60.smethod_0(-2050205505), (int_9 / 2).ToString());
				gclass14_0.method_10(gclass12_0.MOUSE_Y, Class60.smethod_0(-2050205505), (int_10 * 64 / 100).ToString());
				Thread.Sleep(400);
				method_4(0, 0);
				Thread.Sleep(1000);
			}
			else
			{
				Thread.Sleep(2000);
			}
		}
		if (bool_35 && int_24 >= Settings.Default.SKILLBUFF_6_Freq + 1)
		{
			int_24 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			gclass14_0.method_10(gclass12_0.LOCK_MONSTER, Class60.smethod_0(-2050205505), int_5.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_ID, Class60.smethod_0(-2050205505), Settings.Default.SKILLBUFF_6.ToString());
			gclass14_0.method_10(gclass12_0.SKILL_LEVEL, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205620));
			gclass14_0.method_10(gclass12_0.ATTACK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205550));
			if (Settings.Default.SKILLBUFF_6.Equals(2286))
			{
				Thread.Sleep(4000);
				if (gclass14_0.method_9(gclass12_0.CHECK_MOUSE) == 0)
				{
					gclass14_0.method_10(gclass12_0.CHECK_MOUSE, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205598));
				}
				gclass14_0.method_10(gclass12_0.MOUSE_X, Class60.smethod_0(-2050205505), (int_9 * 40 / 100).ToString());
				gclass14_0.method_10(gclass12_0.MOUSE_Y, Class60.smethod_0(-2050205505), (int_10 * 45 / 100).ToString());
				Thread.Sleep(400);
				method_4(0, 0);
				gclass14_0.method_10(gclass12_0.MOUSE_X, Class60.smethod_0(-2050205505), (int_9 / 2).ToString());
				gclass14_0.method_10(gclass12_0.MOUSE_Y, Class60.smethod_0(-2050205505), (int_10 * 64 / 100).ToString());
				Thread.Sleep(400);
				method_4(0, 0);
				Thread.Sleep(1000);
			}
			else
			{
				Thread.Sleep(2000);
			}
		}
		if (bool_37 && int_25 >= Settings.Default.Macro1_Freq + 1)
		{
			int_25 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			method_3(Settings.Default.Macro1_Hotkey);
			Thread.Sleep(1500);
		}
		if (bool_38 && int_26 >= Settings.Default.Macro2_Freq + 1)
		{
			int_26 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			method_3(Settings.Default.Macro2_Hotkey);
			Thread.Sleep(1500);
		}
		if (bool_39 && int_27 >= Settings.Default.Macro3_Freq + 1)
		{
			int_27 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			method_3(Settings.Default.Macro3_Hotkey);
			Thread.Sleep(1500);
		}
		if (bool_40 && int_28 >= Settings.Default.Macro4_Freq + 1)
		{
			int_28 = 0;
			if (gclass14_0.method_9(gclass12_0.LEFT_CLICK) == int_8)
			{
				gclass14_0.method_10(gclass12_0.LEFT_CLICK, Class60.smethod_0(-2050205505), Class60.smethod_0(-2050205559));
			}
			method_3(Settings.Default.Macro4_Hotkey);
			Thread.Sleep(1500);
		}
	}

	private void method_21()
	{
		if (Settings.Default.Home_Settings == null)
		{
			Settings.Default.Home_Settings = new StringCollection();
		}
		if (Settings.Default.Home_Settings.Count <= 0)
		{
			return;
		}
		List<string> list = Settings.Default.Home_Settings.Cast<string>().ToList();
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
					checkBox_42.set_Checked(true);
					break;
				case 12:
					checkBox_43.set_Checked(true);
					break;
				case 13:
					checkBox_6.set_Checked(true);
					break;
				case 14:
					checkBox_4.set_Checked(true);
					break;
				case 15:
					checkBox_2.set_Checked(true);
					break;
				case 16:
					checkBox_30.set_Checked(true);
					break;
				case 17:
					checkBox_23.set_Checked(true);
					break;
				case 18:
					checkBox_26.set_Checked(true);
					break;
				case 19:
					checkBox_44.set_Checked(true);
					break;
				case 20:
					checkBox_17.set_Checked(true);
					break;
				case 21:
					checkBox_25.set_Checked(true);
					break;
				case 22:
					checkBox_35.set_Checked(true);
					break;
				case 23:
					checkBox_29.set_Checked(true);
					break;
				case 24:
					checkBox_8.set_Checked(true);
					break;
				case 25:
					checkBox_36.set_Checked(true);
					break;
				case 26:
					checkBox_9.set_Checked(true);
					break;
				case 27:
					checkBox_10.set_Checked(true);
					break;
				case 28:
					checkBox_18.set_Checked(true);
					break;
				case 29:
					checkBox_19.set_Checked(true);
					break;
				case 30:
					checkBox_20.set_Checked(true);
					break;
				case 31:
					checkBox_21.set_Checked(true);
					break;
				case 32:
					checkBox_22.set_Checked(true);
					break;
				case 33:
					checkBox_12.set_Checked(true);
					break;
				case 34:
					checkBox_11.set_Checked(true);
					break;
				case 35:
					checkBox_15.set_Checked(true);
					break;
				case 36:
					checkBox_27.set_Checked(true);
					break;
				case 37:
					checkBox_40.set_Checked(true);
					break;
				case 38:
					checkBox_31.set_Checked(true);
					break;
				case 39:
					checkBox_16.set_Checked(true);
					break;
				case 40:
					checkBox_1.set_Checked(true);
					break;
				case 41:
					checkBox_24.set_Checked(true);
					break;
				case 42:
					checkBox_37.set_Checked(true);
					break;
				case 43:
					checkBox_39.set_Checked(true);
					break;
				case 44:
					checkBox_41.set_Checked(true);
					break;
				}
			}
			num++;
		}
	}

	private void method_22()
	{
		if (Settings.Default.Home_Settings != null && Settings.Default.Home_Settings.Count > 0)
		{
			Settings.Default.Home_Settings.Clear();
		}
		Settings.Default.Home_Settings.Add(checkBox_32.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_0.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_13.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_28.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_14.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_38.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_3.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_34.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_5.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_33.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_7.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_42.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_43.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_6.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_4.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_2.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_30.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_23.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_26.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_44.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_17.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_25.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_35.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_29.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_8.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_36.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_9.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_10.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_18.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_19.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_20.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_21.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_22.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_12.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_11.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_15.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_27.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_40.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_31.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_16.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_1.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_24.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_37.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_39.get_Checked().ToString());
		Settings.Default.Home_Settings.Add(checkBox_41.get_Checked().ToString());
		((SettingsBase)Settings.Default).Save();
	}

	private void method_23(GClass17 gclass17_0)
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
		checkBox_42.set_Checked(gclass17_0.CB_ArrowBox);
		checkBox_43.set_Checked(gclass17_0.CB_ArrowBwing);
		checkBox_6.set_Checked(gclass17_0.CB_WingNotFound);
		checkBox_4.set_Checked(gclass17_0.CB_TeleportNotFound);
		checkBox_2.set_Checked(gclass17_0.CB_RandomWalkNotFound);
		checkBox_30.set_Checked(gclass17_0.CB_WalkNotFound);
		checkBox_23.set_Checked(gclass17_0.CB_Monster_Escape);
		checkBox_26.set_Checked(gclass17_0.CB_Scrum_Escape);
		checkBox_44.set_Checked(gclass17_0.CB_MonsterOver_Escape);
		checkBox_17.set_Checked(gclass17_0.CB_HP_Escape);
		checkBox_25.set_Checked(gclass17_0.CB_EscapePeopleWait);
		checkBox_35.set_Checked(gclass17_0.CB_EscapeWarp);
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
		checkBox_39.set_Checked(gclass17_0.CB_AlertSound);
		checkBox_41.set_Checked(gclass17_0.CB_AlertLine);
		Settings.Default.Distance_Attack = gclass17_0.Distance_Attack;
		Settings.Default.HP_Percent = gclass17_0.HP_Percent;
		Settings.Default.HP_Hotkey = gclass17_0.HP_Hotkey;
		Settings.Default.HP_Escape = gclass17_0.HP_Escape;
		Settings.Default.Scrum_Escape = gclass17_0.Scrum_Escape;
		Settings.Default.Monster_Over_Escape = gclass17_0.Monster_Over_Escape;
		Settings.Default.HP_Sitdown = gclass17_0.HP_Sitdown;
		Settings.Default.SP_Percent = gclass17_0.SP_Percent;
		Settings.Default.SP_Hotkey = gclass17_0.SP_Hotkey;
		Settings.Default.SP_Sitdown = gclass17_0.SP_Sitdown;
		Settings.Default.Arrow_Box_Hotkey = gclass17_0.Arrow_Box_Hotkey;
		Settings.Default.Arrow_Hotkey = gclass17_0.Arrow_Hotkey;
		Settings.Default.Wing_Hotkey = gclass17_0.Wing_Hotkey;
		Settings.Default.BWing_Hotkey = gclass17_0.BWing_Hotkey;
		Settings.Default.Over_Weight = gclass17_0.Over_Weight;
		Settings.Default.Line_Token = gclass17_0.Line_Token;
		Settings.Default.ATK_Skill_Mode = gclass17_0.ATK_Skill_Mode;
		Settings.Default.ATK_Skill = gclass17_0.ATK_Skill;
		Settings.Default.ATK_Skill_Lv = gclass17_0.ATK_Skill_Lv;
		Settings.Default.ATK_Floor_Skill_Mode = gclass17_0.ATK_Floor_Skill_Mode;
		Settings.Default.ATK_Floor_Skill = gclass17_0.ATK_Floor_Skill;
		Settings.Default.ATK_Floor_Skill_Lv = gclass17_0.ATK_Floor_Skill_Lv;
		Settings.Default.ATK_Floor_Skill_X = gclass17_0.ATK_Floor_Skill_X;
		Settings.Default.ATK_Floor_Skill_Y = gclass17_0.ATK_Floor_Skill_Y;
		Settings.Default.ATK_Floor_Freq = gclass17_0.ATK_Floor_Freq;
		Settings.Default.AB_Freq = gclass17_0.AB_Freq;
		Settings.Default.SKILLBUFF_1 = gclass17_0.SKILLBUFF_1;
		Settings.Default.SKILLBUFF_1_Freq = gclass17_0.SKILLBUFF_1_Freq;
		Settings.Default.SKILLBUFF_2 = gclass17_0.SKILLBUFF_2;
		Settings.Default.SKILLBUFF_2_Freq = gclass17_0.SKILLBUFF_2_Freq;
		Settings.Default.SKILLBUFF_3 = gclass17_0.SKILLBUFF_3;
		Settings.Default.SKILLBUFF_3_Freq = gclass17_0.SKILLBUFF_3_Freq;
		Settings.Default.SKILLBUFF_4 = gclass17_0.SKILLBUFF_4;
		Settings.Default.SKILLBUFF_4_Freq = gclass17_0.SKILLBUFF_4_Freq;
		Settings.Default.SKILLBUFF_5 = gclass17_0.SKILLBUFF_5;
		Settings.Default.SKILLBUFF_5_Freq = gclass17_0.SKILLBUFF_5_Freq;
		Settings.Default.SKILLBUFF_6 = gclass17_0.SKILLBUFF_6;
		Settings.Default.SKILLBUFF_6_Freq = gclass17_0.SKILLBUFF_6_Freq;
		Settings.Default.Macro1_Freq = gclass17_0.Macro1_Freq;
		Settings.Default.Macro1_Hotkey = gclass17_0.Macro1_Hotkey;
		Settings.Default.Macro2_Freq = gclass17_0.Macro2_Freq;
		Settings.Default.Macro2_Hotkey = gclass17_0.Macro2_Hotkey;
		Settings.Default.Macro3_Freq = gclass17_0.Macro3_Freq;
		Settings.Default.Macro3_Hotkey = gclass17_0.Macro3_Hotkey;
		Settings.Default.Macro4_Freq = gclass17_0.Macro4_Freq;
		Settings.Default.Macro4_Hotkey = gclass17_0.Macro4_Hotkey;
		Settings.Default.Path_Map = gclass17_0.Path_Map;
		if (gclass17_0.Item_List != null)
		{
			Settings.Default.Item_List = gclass17_0.Item_List;
		}
		else
		{
			Settings.Default.Item_List.Clear();
		}
		if (gclass17_0.Monster_List != null)
		{
			Settings.Default.Monster_List = gclass17_0.Monster_List;
		}
		else
		{
			Settings.Default.Monster_List.Clear();
		}
		if (gclass17_0.Monster_Escape_List != null)
		{
			Settings.Default.Monster_Escape_List = gclass17_0.Monster_Escape_List;
		}
		else
		{
			Settings.Default.Monster_Escape_List.Clear();
		}
		((SettingsBase)Settings.Default).Save();
	}

	private GClass17 method_24()
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
		gClass.CB_ArrowBox = checkBox_42.get_Checked();
		gClass.CB_ArrowBwing = checkBox_43.get_Checked();
		gClass.CB_WingNotFound = checkBox_6.get_Checked();
		gClass.CB_TeleportNotFound = checkBox_4.get_Checked();
		gClass.CB_RandomWalkNotFound = checkBox_2.get_Checked();
		gClass.CB_WalkNotFound = checkBox_30.get_Checked();
		gClass.CB_Monster_Escape = checkBox_23.get_Checked();
		gClass.CB_Scrum_Escape = checkBox_26.get_Checked();
		gClass.CB_MonsterOver_Escape = checkBox_44.get_Checked();
		gClass.CB_HP_Escape = checkBox_17.get_Checked();
		gClass.CB_EscapePeopleWait = checkBox_25.get_Checked();
		gClass.CB_EscapeWarp = checkBox_35.get_Checked();
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
		gClass.CB_AlertSound = checkBox_39.get_Checked();
		gClass.CB_AlertLine = checkBox_41.get_Checked();
		gClass.Distance_Attack = Settings.Default.Distance_Attack;
		gClass.HP_Percent = Settings.Default.HP_Percent;
		gClass.HP_Hotkey = Settings.Default.HP_Hotkey;
		gClass.HP_Escape = Settings.Default.HP_Escape;
		gClass.Scrum_Escape = Settings.Default.Scrum_Escape;
		gClass.Monster_Over_Escape = Settings.Default.Monster_Over_Escape;
		gClass.HP_Sitdown = Settings.Default.HP_Sitdown;
		gClass.SP_Percent = Settings.Default.SP_Percent;
		gClass.SP_Hotkey = Settings.Default.SP_Hotkey;
		gClass.SP_Sitdown = Settings.Default.SP_Sitdown;
		gClass.Arrow_Box_Hotkey = Settings.Default.Arrow_Box_Hotkey;
		gClass.Arrow_Hotkey = Settings.Default.Arrow_Hotkey;
		gClass.Wing_Hotkey = Settings.Default.Wing_Hotkey;
		gClass.BWing_Hotkey = Settings.Default.BWing_Hotkey;
		gClass.Over_Weight = Settings.Default.Over_Weight;
		gClass.Line_Token = Settings.Default.Line_Token;
		gClass.ATK_Skill_Mode = Settings.Default.ATK_Skill_Mode;
		gClass.ATK_Skill = Settings.Default.ATK_Skill;
		gClass.ATK_Skill_Lv = Settings.Default.ATK_Skill_Lv;
		gClass.ATK_Floor_Skill_Mode = Settings.Default.ATK_Floor_Skill_Mode;
		gClass.ATK_Floor_Skill = Settings.Default.ATK_Floor_Skill;
		gClass.ATK_Floor_Skill_Lv = Settings.Default.ATK_Floor_Skill_Lv;
		gClass.ATK_Floor_Skill_X = Settings.Default.ATK_Floor_Skill_X;
		gClass.ATK_Floor_Skill_Y = Settings.Default.ATK_Floor_Skill_Y;
		gClass.ATK_Floor_Freq = Settings.Default.ATK_Floor_Freq;
		gClass.AB_Freq = Settings.Default.AB_Freq;
		gClass.SKILLBUFF_1 = Settings.Default.SKILLBUFF_1;
		gClass.SKILLBUFF_1_Freq = Settings.Default.SKILLBUFF_1_Freq;
		gClass.SKILLBUFF_2 = Settings.Default.SKILLBUFF_2;
		gClass.SKILLBUFF_2_Freq = Settings.Default.SKILLBUFF_2_Freq;
		gClass.SKILLBUFF_3 = Settings.Default.SKILLBUFF_3;
		gClass.SKILLBUFF_3_Freq = Settings.Default.SKILLBUFF_3_Freq;
		gClass.SKILLBUFF_4 = Settings.Default.SKILLBUFF_4;
		gClass.SKILLBUFF_4_Freq = Settings.Default.SKILLBUFF_4_Freq;
		gClass.SKILLBUFF_5 = Settings.Default.SKILLBUFF_5;
		gClass.SKILLBUFF_5_Freq = Settings.Default.SKILLBUFF_5_Freq;
		gClass.SKILLBUFF_6 = Settings.Default.SKILLBUFF_6;
		gClass.SKILLBUFF_6_Freq = Settings.Default.SKILLBUFF_6_Freq;
		gClass.Macro1_Freq = Settings.Default.Macro1_Freq;
		gClass.Macro1_Hotkey = Settings.Default.Macro1_Hotkey;
		gClass.Macro2_Freq = Settings.Default.Macro2_Freq;
		gClass.Macro2_Hotkey = Settings.Default.Macro2_Hotkey;
		gClass.Macro3_Freq = Settings.Default.Macro3_Freq;
		gClass.Macro3_Hotkey = Settings.Default.Macro3_Hotkey;
		gClass.Macro4_Freq = Settings.Default.Macro4_Freq;
		gClass.Macro4_Hotkey = Settings.Default.Macro4_Hotkey;
		gClass.Path_Map = Settings.Default.Path_Map;
		gClass.Item_List = Settings.Default.Item_List;
		gClass.Monster_List = Settings.Default.Monster_List;
		gClass.Monster_Escape_List = Settings.Default.Monster_Escape_List;
		return gClass;
	}

	private double method_25(GClass7 gclass7_0, GClass7 gclass7_1)
	{
		return Math.Pow(gclass7_1.int_0 - gclass7_0.int_0, 2.0) + Math.Pow(gclass7_1.int_1 - gclass7_0.int_1, 2.0);
	}

	private double method_26(Point point_1, Point point_2)
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

	private void method_27()
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
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
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
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected O, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected O, but got Unknown
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected O, but got Unknown
		//IL_0846: Unknown result type (might be due to invalid IL or missing references)
		//IL_0850: Expected O, but got Unknown
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected O, but got Unknown
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected O, but got Unknown
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Expected O, but got Unknown
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected O, but got Unknown
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Expected O, but got Unknown
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected O, but got Unknown
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Expected O, but got Unknown
		//IL_0ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Expected O, but got Unknown
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b27: Expected O, but got Unknown
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected O, but got Unknown
		//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3b: Expected O, but got Unknown
		//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Expected O, but got Unknown
		//IL_0d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5f: Expected O, but got Unknown
		//IL_0e7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f17: Expected O, but got Unknown
		//IL_0f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd9: Expected O, but got Unknown
		//IL_1003: Unknown result type (might be due to invalid IL or missing references)
		//IL_1029: Unknown result type (might be due to invalid IL or missing references)
		//IL_1097: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a1: Expected O, but got Unknown
		//IL_10b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bd: Expected O, but got Unknown
		//IL_1535: Unknown result type (might be due to invalid IL or missing references)
		//IL_153f: Expected O, but got Unknown
		//IL_1559: Unknown result type (might be due to invalid IL or missing references)
		//IL_1596: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a0: Expected O, but got Unknown
		//IL_15b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bc: Expected O, but got Unknown
		//IL_15ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d8: Expected O, but got Unknown
		//IL_15ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f4: Expected O, but got Unknown
		//IL_1606: Unknown result type (might be due to invalid IL or missing references)
		//IL_1610: Expected O, but got Unknown
		//IL_1622: Unknown result type (might be due to invalid IL or missing references)
		//IL_162c: Expected O, but got Unknown
		//IL_163e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1648: Expected O, but got Unknown
		//IL_165a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1664: Expected O, but got Unknown
		//IL_1676: Unknown result type (might be due to invalid IL or missing references)
		//IL_1680: Expected O, but got Unknown
		//IL_1692: Unknown result type (might be due to invalid IL or missing references)
		//IL_169c: Expected O, but got Unknown
		//IL_16ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b8: Expected O, but got Unknown
		//IL_16ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d4: Expected O, but got Unknown
		//IL_16e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f0: Expected O, but got Unknown
		//IL_1702: Unknown result type (might be due to invalid IL or missing references)
		//IL_170c: Expected O, but got Unknown
		//IL_171e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1728: Expected O, but got Unknown
		//IL_173a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1744: Expected O, but got Unknown
		//IL_1756: Unknown result type (might be due to invalid IL or missing references)
		//IL_1760: Expected O, but got Unknown
		//IL_1772: Unknown result type (might be due to invalid IL or missing references)
		//IL_177c: Expected O, but got Unknown
		//IL_178e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1798: Expected O, but got Unknown
		//IL_17aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b4: Expected O, but got Unknown
		//IL_17c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d0: Expected O, but got Unknown
		//IL_17e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ec: Expected O, but got Unknown
		//IL_17fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1808: Expected O, but got Unknown
		//IL_1863: Unknown result type (might be due to invalid IL or missing references)
		//IL_186d: Expected O, but got Unknown
		//IL_188e: Unknown result type (might be due to invalid IL or missing references)
		//IL_193a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1944: Expected O, but got Unknown
		//IL_1965: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1e: Expected O, but got Unknown
		//IL_1a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af6: Expected O, but got Unknown
		//IL_1b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bcc: Expected O, but got Unknown
		//IL_1be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca0: Expected O, but got Unknown
		//IL_1cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d76: Expected O, but got Unknown
		//IL_1d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4c: Expected O, but got Unknown
		//IL_1e79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f2c: Expected O, but got Unknown
		//IL_1f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ffc: Expected O, but got Unknown
		//IL_201d: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d3: Expected O, but got Unknown
		//IL_20f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_219f: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a9: Expected O, but got Unknown
		//IL_21c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2278: Unknown result type (might be due to invalid IL or missing references)
		//IL_2282: Expected O, but got Unknown
		//IL_22a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_234e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2358: Expected O, but got Unknown
		//IL_2378: Unknown result type (might be due to invalid IL or missing references)
		//IL_2427: Unknown result type (might be due to invalid IL or missing references)
		//IL_2431: Expected O, but got Unknown
		//IL_2451: Unknown result type (might be due to invalid IL or missing references)
		//IL_24fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2507: Expected O, but got Unknown
		//IL_2524: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_25da: Expected O, but got Unknown
		//IL_25fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_26a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b3: Expected O, but got Unknown
		//IL_26d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2781: Unknown result type (might be due to invalid IL or missing references)
		//IL_278b: Expected O, but got Unknown
		//IL_27af: Unknown result type (might be due to invalid IL or missing references)
		//IL_285b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2865: Expected O, but got Unknown
		//IL_2886: Unknown result type (might be due to invalid IL or missing references)
		//IL_2932: Unknown result type (might be due to invalid IL or missing references)
		//IL_293c: Expected O, but got Unknown
		//IL_295d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a13: Expected O, but got Unknown
		//IL_2a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aed: Expected O, but got Unknown
		//IL_2b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc7: Expected O, but got Unknown
		//IL_2beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca1: Expected O, but got Unknown
		//IL_2cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d7b: Expected O, but got Unknown
		//IL_2d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e55: Expected O, but got Unknown
		//IL_2e79: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f25: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f2f: Expected O, but got Unknown
		//IL_2f53: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3009: Expected O, but got Unknown
		//IL_302d: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_30e1: Expected O, but got Unknown
		//IL_3105: Unknown result type (might be due to invalid IL or missing references)
		//IL_31b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_31bc: Expected O, but got Unknown
		//IL_31e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_328d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3297: Expected O, but got Unknown
		//IL_32bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3368: Unknown result type (might be due to invalid IL or missing references)
		//IL_3372: Expected O, but got Unknown
		//IL_3396: Unknown result type (might be due to invalid IL or missing references)
		//IL_3443: Unknown result type (might be due to invalid IL or missing references)
		//IL_344d: Expected O, but got Unknown
		//IL_346d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3519: Unknown result type (might be due to invalid IL or missing references)
		//IL_3523: Expected O, but got Unknown
		//IL_3543: Unknown result type (might be due to invalid IL or missing references)
		//IL_35ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f9: Expected O, but got Unknown
		//IL_3619: Unknown result type (might be due to invalid IL or missing references)
		//IL_36c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_36d2: Expected O, but got Unknown
		//IL_36f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_37a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_37ab: Expected O, but got Unknown
		//IL_37cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_387a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3884: Expected O, but got Unknown
		//IL_38a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3953: Unknown result type (might be due to invalid IL or missing references)
		//IL_395d: Expected O, but got Unknown
		//IL_397d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a35: Expected O, but got Unknown
		//IL_3a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b0d: Expected O, but got Unknown
		//IL_3b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3be3: Expected O, but got Unknown
		//IL_3c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ca6: Expected O, but got Unknown
		//IL_3d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d66: Expected O, but got Unknown
		//IL_3e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fce: Unknown result type (might be due to invalid IL or missing references)
		//IL_4052: Unknown result type (might be due to invalid IL or missing references)
		//IL_40e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4165: Unknown result type (might be due to invalid IL or missing references)
		//IL_41f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_4278: Unknown result type (might be due to invalid IL or missing references)
		//IL_4307: Unknown result type (might be due to invalid IL or missing references)
		//IL_438b: Unknown result type (might be due to invalid IL or missing references)
		//IL_441a: Unknown result type (might be due to invalid IL or missing references)
		//IL_447c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4486: Expected O, but got Unknown
		//IL_4498: Unknown result type (might be due to invalid IL or missing references)
		//IL_44a2: Expected O, but got Unknown
		//IL_44b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_44be: Expected O, but got Unknown
		//IL_4518: Unknown result type (might be due to invalid IL or missing references)
		//IL_4554: Unknown result type (might be due to invalid IL or missing references)
		//IL_455e: Expected O, but got Unknown
		//IL_45de: Unknown result type (might be due to invalid IL or missing references)
		//IL_45e8: Expected O, but got Unknown
		//IL_4618: Unknown result type (might be due to invalid IL or missing references)
		//IL_46ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_46f8: Expected O, but got Unknown
		//IL_4724: Unknown result type (might be due to invalid IL or missing references)
		//IL_47c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_47d0: Expected O, but got Unknown
		//IL_4844: Unknown result type (might be due to invalid IL or missing references)
		//IL_4df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dfd: Expected O, but got Unknown
		//IL_4e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e18: Expected O, but got Unknown
		//IL_4e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e7e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm2));
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
		checkBox_9 = new CheckBox();
		checkBox_8 = new CheckBox();
		checkBox_24 = new CheckBox();
		checkBox_29 = new CheckBox();
		checkBox_14 = new CheckBox();
		checkBox_28 = new CheckBox();
		checkBox_13 = new CheckBox();
		checkBox_0 = new CheckBox();
		checkBox_32 = new CheckBox();
		checkBox_36 = new CheckBox();
		checkBox_7 = new CheckBox();
		checkBox_33 = new CheckBox();
		checkBox_5 = new CheckBox();
		checkBox_34 = new CheckBox();
		checkBox_3 = new CheckBox();
		checkBox_38 = new CheckBox();
		checkBox_1 = new CheckBox();
		checkBox_16 = new CheckBox();
		checkBox_31 = new CheckBox();
		checkBox_10 = new CheckBox();
		checkBox_18 = new CheckBox();
		checkBox_19 = new CheckBox();
		checkBox_20 = new CheckBox();
		checkBox_21 = new CheckBox();
		checkBox_22 = new CheckBox();
		checkBox_12 = new CheckBox();
		checkBox_11 = new CheckBox();
		checkBox_15 = new CheckBox();
		checkBox_27 = new CheckBox();
		checkBox_40 = new CheckBox();
		checkBox_37 = new CheckBox();
		checkBox_39 = new CheckBox();
		checkBox_41 = new CheckBox();
		checkBox_35 = new CheckBox();
		checkBox_25 = new CheckBox();
		checkBox_17 = new CheckBox();
		checkBox_26 = new CheckBox();
		checkBox_23 = new CheckBox();
		checkBox_30 = new CheckBox();
		checkBox_2 = new CheckBox();
		checkBox_4 = new CheckBox();
		checkBox_6 = new CheckBox();
		checkBox_42 = new CheckBox();
		checkBox_43 = new CheckBox();
		checkBox_44 = new CheckBox();
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
		toolStripMenuItem_5 = new ToolStripMenuItem();
		toolStripMenuItem_6 = new ToolStripMenuItem();
		toolStripMenuItem_7 = new ToolStripMenuItem();
		toolStripMenuItem_8 = new ToolStripMenuItem();
		toolStripMenuItem_9 = new ToolStripMenuItem();
		openFileDialog_0 = new OpenFileDialog();
		saveFileDialog_0 = new SaveFileDialog();
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
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 95f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 5f));
		((Control)tableLayoutPanel_0).set_Size(new Size(409, 703));
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
		((Control)tabControl_0).set_Size(new Size(403, 661));
		((Control)tabControl_0).set_TabIndex(1);
		((Control)tabPage_0).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_0).get_Controls().Add((Control)(object)tableLayoutPanel_2);
		tabPage_0.set_Location(new Point(4, 5));
		((Control)tabPage_0).set_Margin(new Padding(0));
		((Control)tabPage_0).set_Name(Class60.smethod_0(-2050206998));
		((Control)tabPage_0).set_Size(new Size(395, 652));
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
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 9f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 91f));
		((Control)tableLayoutPanel_2).set_Size(new Size(395, 652));
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
		((Control)groupBox_0).set_Size(new Size(395, 594));
		((Control)groupBox_0).set_TabIndex(1);
		groupBox_0.set_TabStop(false);
		((Control)groupBox_0).set_Text(Class60.smethod_0(-2050207207));
		tableLayoutPanel_3.set_ColumnCount(2);
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 55f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 45f));
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_9, 1, 3);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_8, 1, 1);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_24, 1, 18);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_29, 1, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_14, 0, 4);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_28, 0, 3);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_13, 0, 2);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_0, 0, 1);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_32, 0, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_36, 1, 2);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_7, 0, 10);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_33, 0, 9);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_5, 0, 8);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_34, 0, 7);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_3, 0, 6);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_38, 0, 5);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_1, 1, 17);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_16, 1, 16);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_31, 1, 15);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_10, 1, 4);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_18, 1, 5);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_19, 1, 6);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_20, 1, 7);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_21, 1, 8);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_22, 1, 9);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_12, 1, 10);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_11, 1, 11);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_15, 1, 12);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_27, 1, 13);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_40, 1, 14);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_37, 1, 19);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_39, 1, 20);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_41, 1, 21);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_35, 0, 22);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_25, 0, 21);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_17, 0, 20);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_26, 0, 18);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_23, 0, 17);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_30, 0, 16);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_2, 0, 15);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_4, 0, 14);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_6, 0, 13);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_42, 0, 11);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_43, 0, 12);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)checkBox_44, 0, 19);
		((Control)tableLayoutPanel_3).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)tableLayoutPanel_3).set_Location(new Point(4, 23));
		((Control)tableLayoutPanel_3).set_Margin(new Padding(4));
		((Control)tableLayoutPanel_3).set_Name(Class60.smethod_0(-2050211088));
		tableLayoutPanel_3.set_RowCount(23);
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.36f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 4.079999f));
		((Control)tableLayoutPanel_3).set_Size(new Size(387, 567));
		((Control)tableLayoutPanel_3).set_TabIndex(0);
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
		((Control)checkBox_24).set_AutoSize(true);
		((Control)checkBox_24).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_24).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_24).set_Location(new Point(215, 432));
		((Control)checkBox_24).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_24).set_Name(Class60.smethod_0(-2050207414));
		((Control)checkBox_24).set_Size(new Size(111, 20));
		((Control)checkBox_24).set_TabIndex(31);
		((Control)checkBox_24).set_Text(Class60.smethod_0(-2050207394));
		((ButtonBase)checkBox_24).set_UseVisualStyleBackColor(true);
		checkBox_24.add_CheckedChanged((EventHandler)checkBox_24_CheckedChanged);
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
		((Control)checkBox_7).set_AutoSize(true);
		((Control)checkBox_7).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_7).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_7).set_Location(new Point(3, 240));
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
		((Control)checkBox_33).set_Location(new Point(3, 216));
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
		((Control)checkBox_5).set_Location(new Point(3, 192));
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
		((Control)checkBox_1).set_AutoSize(true);
		((Control)checkBox_1).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_1).set_Location(new Point(215, 408));
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
		((Control)checkBox_16).set_Location(new Point(215, 384));
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
		((Control)checkBox_31).set_Location(new Point(215, 360));
		((Control)checkBox_31).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_31).set_Name(Class60.smethod_0(-2050206452));
		((Control)checkBox_31).set_Size(new Size(99, 20));
		((Control)checkBox_31).set_TabIndex(38);
		((Control)checkBox_31).set_Text(Class60.smethod_0(-2050206448));
		((ButtonBase)checkBox_31).set_UseVisualStyleBackColor(true);
		checkBox_31.add_CheckedChanged((EventHandler)checkBox_31_CheckedChanged);
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
		((Control)checkBox_21).set_AutoSize(true);
		((Control)checkBox_21).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_21).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_21).set_Location(new Point(215, 192));
		((Control)checkBox_21).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_21).set_Name(Class60.smethod_0(-2050206695));
		((Control)checkBox_21).set_Size(new Size(89, 20));
		((Control)checkBox_21).set_TabIndex(25);
		((Control)checkBox_21).set_Text(Class60.smethod_0(-2050200594));
		((ButtonBase)checkBox_21).set_UseVisualStyleBackColor(true);
		checkBox_21.add_CheckedChanged((EventHandler)checkBox_21_CheckedChanged);
		((Control)checkBox_22).set_AutoSize(true);
		((Control)checkBox_22).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_22).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_22).set_Location(new Point(215, 216));
		((Control)checkBox_22).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_22).set_Name(Class60.smethod_0(-2050200627));
		((Control)checkBox_22).set_Size(new Size(89, 20));
		((Control)checkBox_22).set_TabIndex(26);
		((Control)checkBox_22).set_Text(Class60.smethod_0(-2050200622));
		((ButtonBase)checkBox_22).set_UseVisualStyleBackColor(true);
		checkBox_22.add_CheckedChanged((EventHandler)checkBox_22_CheckedChanged);
		((Control)checkBox_12).set_AutoSize(true);
		((Control)checkBox_12).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_12).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_12).set_Location(new Point(215, 240));
		((Control)checkBox_12).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_12).set_Name(Class60.smethod_0(-2050200655));
		((Control)checkBox_12).set_Size(new Size(85, 20));
		((Control)checkBox_12).set_TabIndex(13);
		((Control)checkBox_12).set_Text(Class60.smethod_0(-2050200703));
		((ButtonBase)checkBox_12).set_UseVisualStyleBackColor(true);
		checkBox_12.add_CheckedChanged((EventHandler)checkBox_12_CheckedChanged);
		((Control)checkBox_11).set_AutoSize(true);
		((Control)checkBox_11).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_11).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_11).set_Location(new Point(215, 264));
		((Control)checkBox_11).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_11).set_Name(Class60.smethod_0(-2050200724));
		((Control)checkBox_11).set_Size(new Size(85, 20));
		((Control)checkBox_11).set_TabIndex(12);
		((Control)checkBox_11).set_Text(Class60.smethod_0(-2050200708));
		((ButtonBase)checkBox_11).set_UseVisualStyleBackColor(true);
		checkBox_11.add_CheckedChanged((EventHandler)checkBox_11_CheckedChanged);
		((Control)checkBox_15).set_AutoSize(true);
		((Control)checkBox_15).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_15).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_15).set_Location(new Point(215, 288));
		((Control)checkBox_15).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_15).set_Name(Class60.smethod_0(-2050200761));
		((Control)checkBox_15).set_Size(new Size(85, 20));
		((Control)checkBox_15).set_TabIndex(21);
		((Control)checkBox_15).set_Text(Class60.smethod_0(-2050200745));
		((ButtonBase)checkBox_15).set_UseVisualStyleBackColor(true);
		checkBox_15.add_CheckedChanged((EventHandler)checkBox_15_CheckedChanged);
		((Control)checkBox_27).set_AutoSize(true);
		((Control)checkBox_27).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_27).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_27).set_Location(new Point(215, 312));
		((Control)checkBox_27).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_27).set_Name(Class60.smethod_0(-2050200782));
		((Control)checkBox_27).set_Size(new Size(85, 20));
		((Control)checkBox_27).set_TabIndex(33);
		((Control)checkBox_27).set_Text(Class60.smethod_0(-2050200830));
		((ButtonBase)checkBox_27).set_UseVisualStyleBackColor(true);
		checkBox_27.add_CheckedChanged((EventHandler)checkBox_27_CheckedChanged);
		((Control)checkBox_40).set_AutoSize(true);
		((Control)checkBox_40).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_40).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_40).set_Location(new Point(215, 336));
		((Control)checkBox_40).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_40).set_Name(Class60.smethod_0(-2050200851));
		((Control)checkBox_40).set_Size(new Size(161, 20));
		((Control)checkBox_40).set_TabIndex(47);
		((Control)checkBox_40).set_Text(Class60.smethod_0(-2050200846));
		((ButtonBase)checkBox_40).set_UseVisualStyleBackColor(true);
		checkBox_40.add_CheckedChanged((EventHandler)checkBox_40_CheckedChanged);
		((Control)checkBox_37).set_AutoSize(true);
		((Control)checkBox_37).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_37).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_37).set_Location(new Point(215, 456));
		((Control)checkBox_37).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_37).set_Name(Class60.smethod_0(-2050200903));
		((Control)checkBox_37).set_Size(new Size(130, 20));
		((Control)checkBox_37).set_TabIndex(44);
		((Control)checkBox_37).set_Text(Class60.smethod_0(-2050200949));
		((ButtonBase)checkBox_37).set_UseVisualStyleBackColor(true);
		checkBox_37.add_CheckedChanged((EventHandler)checkBox_37_CheckedChanged);
		((Control)checkBox_39).set_AutoSize(true);
		((Control)checkBox_39).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_39).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_39).set_Location(new Point(215, 480));
		((Control)checkBox_39).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_39).set_Name(Class60.smethod_0(-2050200966));
		((Control)checkBox_39).set_Size(new Size(142, 20));
		((Control)checkBox_39).set_TabIndex(46);
		((Control)checkBox_39).set_Text(Class60.smethod_0(-2050201010));
		((ButtonBase)checkBox_39).set_UseVisualStyleBackColor(true);
		checkBox_39.add_CheckedChanged((EventHandler)checkBox_39_CheckedChanged);
		((Control)checkBox_41).set_AutoSize(true);
		((Control)checkBox_41).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_41).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_41).set_Location(new Point(215, 504));
		((Control)checkBox_41).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_41).set_Name(Class60.smethod_0(-2050201039));
		((Control)checkBox_41).set_Size(new Size(145, 20));
		((Control)checkBox_41).set_TabIndex(48);
		((Control)checkBox_41).set_Text(Class60.smethod_0(-2050201084));
		((ButtonBase)checkBox_41).set_UseVisualStyleBackColor(true);
		checkBox_41.add_CheckedChanged((EventHandler)checkBox_41_CheckedChanged);
		((Control)checkBox_35).set_AutoSize(true);
		((Control)checkBox_35).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_35).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_35).set_Location(new Point(3, 528));
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
		((Control)checkBox_25).set_Location(new Point(3, 504));
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
		((Control)checkBox_17).set_Location(new Point(3, 480));
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
		((Control)checkBox_26).set_Location(new Point(3, 432));
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
		((Control)checkBox_23).set_Location(new Point(3, 408));
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
		((Control)checkBox_30).set_Location(new Point(3, 384));
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
		((Control)checkBox_2).set_Location(new Point(3, 360));
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
		((Control)checkBox_4).set_Location(new Point(3, 336));
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
		((Control)checkBox_6).set_Location(new Point(3, 312));
		((Control)checkBox_6).set_Margin(new Padding(3, 0, 3, 0));
		((Control)checkBox_6).set_Name(Class60.smethod_0(-2050199626));
		((Control)checkBox_6).set_Size(new Size(138, 20));
		((Control)checkBox_6).set_TabIndex(1);
		((Control)checkBox_6).set_Text(Class60.smethod_0(-2050199652));
		((ButtonBase)checkBox_6).set_UseVisualStyleBackColor(true);
		checkBox_6.add_CheckedChanged((EventHandler)checkBox_6_CheckedChanged);
		((Control)checkBox_42).set_AutoSize(true);
		((Control)checkBox_42).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_42).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_42).set_Location(new Point(3, 267));
		((Control)checkBox_42).set_Name(Class60.smethod_0(-2050199743));
		((Control)checkBox_42).set_Size(new Size(160, 18));
		((Control)checkBox_42).set_TabIndex(49);
		((Control)checkBox_42).set_Text(Class60.smethod_0(-2050199725));
		((ButtonBase)checkBox_42).set_UseVisualStyleBackColor(true);
		checkBox_42.add_CheckedChanged((EventHandler)checkBox_42_CheckedChanged);
		((Control)checkBox_43).set_AutoSize(true);
		((Control)checkBox_43).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_43).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_43).set_Location(new Point(3, 291));
		((Control)checkBox_43).set_Name(Class60.smethod_0(-2050199782));
		((Control)checkBox_43).set_Size(new Size(120, 18));
		((Control)checkBox_43).set_TabIndex(50);
		((Control)checkBox_43).set_Text(Class60.smethod_0(-2050199826));
		((ButtonBase)checkBox_43).set_UseVisualStyleBackColor(true);
		checkBox_43.add_CheckedChanged((EventHandler)checkBox_43_CheckedChanged);
		((Control)checkBox_44).set_AutoSize(true);
		((Control)checkBox_44).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_44).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)checkBox_44).set_Location(new Point(3, 459));
		((Control)checkBox_44).set_Name(Class60.smethod_0(-2050199843));
		((Control)checkBox_44).set_Size(new Size(177, 18));
		((Control)checkBox_44).set_TabIndex(51);
		((Control)checkBox_44).set_Text(Class60.smethod_0(-2050199879));
		((ButtonBase)checkBox_44).set_UseVisualStyleBackColor(true);
		checkBox_44.add_CheckedChanged((EventHandler)checkBox_44_CheckedChanged);
		((Control)tabPage_1).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_1).get_Controls().Add((Control)(object)gcontrol5_0);
		tabPage_1.set_Location(new Point(4, 5));
		((Control)tabPage_1).set_Margin(new Padding(0));
		((Control)tabPage_1).set_Name(Class60.smethod_0(-2050199942));
		((Control)tabPage_1).set_Size(new Size(395, 619));
		tabPage_1.set_TabIndex(1);
		((Control)tabPage_1).set_Text(Class60.smethod_0(-2050199988));
		((Control)gcontrol5_0).set_BackColor(Color.DarkSlateGray);
		((Control)gcontrol5_0).set_Dock((DockStyle)5);
		((Control)gcontrol5_0).set_Location(new Point(0, 0));
		((Control)gcontrol5_0).set_Margin(new Padding(4));
		((Control)gcontrol5_0).set_Name(Class60.smethod_0(-2050199973));
		((Control)gcontrol5_0).set_Size(new Size(395, 619));
		((Control)gcontrol5_0).set_TabIndex(0);
		((Control)tabPage_2).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_2).get_Controls().Add((Control)(object)gcontrol0_0);
		tabPage_2.set_Location(new Point(4, 5));
		((Control)tabPage_2).set_Margin(new Padding(0));
		((Control)tabPage_2).set_Name(Class60.smethod_0(-2050200018));
		((Control)tabPage_2).set_Size(new Size(395, 619));
		tabPage_2.set_TabIndex(2);
		((Control)tabPage_2).set_Text(Class60.smethod_0(-2050200014));
		((Control)gcontrol0_0).set_BackColor(Color.DarkSlateGray);
		((Control)gcontrol0_0).set_Dock((DockStyle)5);
		((Control)gcontrol0_0).set_Location(new Point(0, 0));
		((Control)gcontrol0_0).set_Margin(new Padding(4));
		((Control)gcontrol0_0).set_Name(Class60.smethod_0(-2050200063));
		((Control)gcontrol0_0).set_Size(new Size(395, 619));
		((Control)gcontrol0_0).set_TabIndex(0);
		((Control)tabPage_3).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_3).get_Controls().Add((Control)(object)gcontrol1_0);
		tabPage_3.set_Location(new Point(4, 5));
		((Control)tabPage_3).set_Margin(new Padding(0));
		((Control)tabPage_3).set_Name(Class60.smethod_0(-2050200042));
		((Control)tabPage_3).set_Size(new Size(395, 619));
		tabPage_3.set_TabIndex(3);
		((Control)tabPage_3).set_Text(Class60.smethod_0(-2050200067));
		((Control)gcontrol1_0).set_BackColor(Color.DarkSlateGray);
		((Control)gcontrol1_0).set_Dock((DockStyle)5);
		((Control)gcontrol1_0).set_Location(new Point(0, 0));
		((Control)gcontrol1_0).set_Margin(new Padding(4));
		((Control)gcontrol1_0).set_Name(Class60.smethod_0(-2050200116));
		((Control)gcontrol1_0).set_Size(new Size(395, 619));
		((Control)gcontrol1_0).set_TabIndex(0);
		((Control)tabPage_4).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_4).get_Controls().Add((Control)(object)gcontrol2_0);
		tabPage_4.set_Location(new Point(4, 5));
		((Control)tabPage_4).set_Margin(new Padding(0));
		((Control)tabPage_4).set_Name(Class60.smethod_0(-2050200105));
		((Control)tabPage_4).set_Size(new Size(395, 619));
		tabPage_4.set_TabIndex(4);
		((Control)tabPage_4).set_Text(Class60.smethod_0(-2050206984));
		((Control)gcontrol2_0).set_BackColor(Color.DarkSlateGray);
		((Control)gcontrol2_0).set_Dock((DockStyle)5);
		((Control)gcontrol2_0).set_Location(new Point(0, 0));
		((Control)gcontrol2_0).set_Margin(new Padding(4));
		((Control)gcontrol2_0).set_Name(Class60.smethod_0(-2050200140));
		((Control)gcontrol2_0).set_Size(new Size(395, 619));
		((Control)gcontrol2_0).set_TabIndex(0);
		((Control)tabPage_5).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_5).get_Controls().Add((Control)(object)gcontrol4_0);
		tabPage_5.set_Location(new Point(4, 5));
		((Control)tabPage_5).set_Margin(new Padding(0));
		((Control)tabPage_5).set_Name(Class60.smethod_0(-2050200164));
		((Control)tabPage_5).set_Size(new Size(395, 619));
		tabPage_5.set_TabIndex(5);
		((Control)tabPage_5).set_Text(Class60.smethod_0(-2050206984));
		((Control)gcontrol4_0).set_BackColor(Color.DarkSlateGray);
		((Control)gcontrol4_0).set_Dock((DockStyle)5);
		((Control)gcontrol4_0).set_Location(new Point(0, 0));
		((Control)gcontrol4_0).set_Margin(new Padding(4));
		((Control)gcontrol4_0).set_Name(Class60.smethod_0(-2050200224));
		((Control)gcontrol4_0).set_Size(new Size(395, 619));
		((Control)gcontrol4_0).set_TabIndex(0);
		((Control)tabPage_6).set_BackColor(Color.DarkSlateGray);
		((Control)tabPage_6).get_Controls().Add((Control)(object)gcontrol3_0);
		tabPage_6.set_Location(new Point(4, 5));
		((Control)tabPage_6).set_Margin(new Padding(0));
		((Control)tabPage_6).set_Name(Class60.smethod_0(-2050200242));
		((Control)tabPage_6).set_Size(new Size(395, 619));
		tabPage_6.set_TabIndex(6);
		((Control)tabPage_6).set_Text(Class60.smethod_0(-2050206984));
		((Control)gcontrol3_0).set_BackColor(Color.DarkSlateGray);
		((Control)gcontrol3_0).set_Dock((DockStyle)5);
		((Control)gcontrol3_0).set_Location(new Point(0, 0));
		((Control)gcontrol3_0).set_Margin(new Padding(4));
		((Control)gcontrol3_0).set_Name(Class60.smethod_0(-2050200233));
		((Control)gcontrol3_0).set_Size(new Size(395, 619));
		((Control)gcontrol3_0).set_TabIndex(0);
		tableLayoutPanel_1.set_ColumnCount(2);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)button_0, 1, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)button_1, 0, 0);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(0, 667));
		((Control)tableLayoutPanel_1).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050200260));
		tableLayoutPanel_1.set_RowCount(1);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_1).set_Size(new Size(409, 36));
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
		((Control)button_0).set_Size(new Size(197, 32));
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
		((Control)button_1).set_Size(new Size(196, 32));
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
		((ToolStripDropDownItem)toolStripMenuItem_4).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)toolStripMenuItem_5,
			(ToolStripItem)toolStripMenuItem_6,
			(ToolStripItem)toolStripMenuItem_7
		});
		((ToolStripItem)toolStripMenuItem_4).set_Name(Class60.smethod_0(-2050202861));
		((ToolStripItem)toolStripMenuItem_4).set_Size(new Size(120, 20));
		((ToolStripItem)toolStripMenuItem_4).set_Text(Class60.smethod_0(-2050202966));
		((ToolStripItem)toolStripMenuItem_5).set_Name(Class60.smethod_0(-2050203005));
		((ToolStripItem)toolStripMenuItem_5).set_Size(new Size(152, 22));
		((ToolStripItem)toolStripMenuItem_5).set_Text(Class60.smethod_0(-2050203035));
		((ToolStripItem)toolStripMenuItem_5).add_Click((EventHandler)toolStripMenuItem_5_Click);
		((ToolStripItem)toolStripMenuItem_6).set_Name(Class60.smethod_0(-2050203066));
		((ToolStripItem)toolStripMenuItem_6).set_Size(new Size(152, 22));
		((ToolStripItem)toolStripMenuItem_6).set_Text(Class60.smethod_0(-2050203077));
		((ToolStripItem)toolStripMenuItem_6).add_Click((EventHandler)toolStripMenuItem_6_Click);
		((ToolStripItem)toolStripMenuItem_7).set_Name(Class60.smethod_0(-2050203112));
		((ToolStripItem)toolStripMenuItem_7).set_Size(new Size(152, 22));
		((ToolStripItem)toolStripMenuItem_7).set_Text(Class60.smethod_0(-2050203164));
		((ToolStripItem)toolStripMenuItem_7).add_Click((EventHandler)toolStripMenuItem_7_Click);
		((ToolStripItem)toolStripMenuItem_8).set_Name(Class60.smethod_0(-2050203185));
		((ToolStripItem)toolStripMenuItem_8).set_Size(new Size(55, 20));
		((ToolStripItem)toolStripMenuItem_8).set_Text(Class60.smethod_0(-2050203227));
		((ToolStripItem)toolStripMenuItem_8).add_Click((EventHandler)toolStripMenuItem_8_Click);
		((ToolStripItem)toolStripMenuItem_9).set_Name(Class60.smethod_0(-2050203254));
		((ToolStripItem)toolStripMenuItem_9).set_Size(new Size(97, 20));
		((ToolStripItem)toolStripMenuItem_9).set_Text(Class60.smethod_0(-2050203282));
		((ToolStripItem)toolStripMenuItem_9).add_Click((EventHandler)toolStripMenuItem_9_Click);
		((FileDialog)openFileDialog_0).set_FileName(Class60.smethod_0(-2050203327));
		((FileDialog)openFileDialog_0).set_RestoreDirectory(true);
		((FileDialog)saveFileDialog_0).set_FileName(Class60.smethod_0(-2050203327));
		((FileDialog)saveFileDialog_0).set_RestoreDirectory(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 18f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(409, 729));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		((Control)this).get_Controls().Add((Control)(object)menuStrip_0);
		((Control)this).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(Class60.smethod_0(-2050208183)));
		((Form)this).set_MainMenuStrip(menuStrip_0);
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_MinimumSize(new Size(425, 768));
		((Control)this).set_Name(Class60.smethod_0(-2050203297));
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(Class60.smethod_0(-2050203346));
		((Form)this).add_FormClosing(new FormClosingEventHandler(GForm2_FormClosing));
		((Form)this).add_Load((EventHandler)GForm2_Load);
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

	private bool method_28(string string_2)
	{
		return string_2.Contains(gclass12_0.PATH);
	}

	private void method_29(object sender, EventArgs e)
	{
		((Control)this).Show();
	}

	private void method_30(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
