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
				int num = -1676904535;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD83F1250u) % 7u)
					{
					case 5u:
					{
						int num4;
						int num5;
						if (val != null)
						{
							num4 = 767358010;
							num5 = 767358010;
						}
						else
						{
							num4 = 1057478386;
							num5 = 1057478386;
						}
						num = num4 ^ (int)(num2 * 1836477451);
						continue;
					}
					case 4u:
						val = timer_0;
						num = (int)((num2 * 1261327971) ^ 0x18229F42);
						continue;
					case 3u:
					{
						timer_0 = value;
						val = timer_0;
						int num3;
						if (val != null)
						{
							num = -1972259589;
							num3 = -1972259589;
						}
						else
						{
							num = -413631235;
							num3 = -413631235;
						}
						continue;
					}
					case 2u:
						GForm1.smethod_81(val, eventHandler_);
						num = ((int)num2 * -277487726) ^ -1570144645;
						continue;
					case 1u:
						GForm1.smethod_80(val, eventHandler_);
						num = (int)(num2 * 671873753) ^ -528068880;
						continue;
					default:
						return;
					case 6u:
						break;
					case 0u:
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
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			EventHandler eventHandler_ = method_2;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = -1401216322;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEC49C082u) % 13u)
					{
					case 12u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = ((int)num2 * -1892649117) ^ 0x7383AE01;
						continue;
					case 10u:
					{
						val = pictureBox_1;
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1140860250;
							num6 = 1140860250;
						}
						else
						{
							num5 = 1682738032;
							num6 = 1682738032;
						}
						num = num5 ^ (int)(num2 * 701564177);
						continue;
					}
					case 9u:
						pictureBox_1 = value;
						num = -920424171;
						continue;
					case 8u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = ((int)num2 * -912231321) ^ 0x6C7047A5;
						continue;
					case 7u:
						eventHandler_2 = method_3;
						num = ((int)num2 * -952243205) ^ -1093999888;
						continue;
					case 6u:
						val = pictureBox_1;
						num = (int)((num2 * 767262339) ^ 0x20AE41E8);
						continue;
					case 5u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						num = (int)(num2 * 897799090) ^ -585767944;
						continue;
					case 3u:
						mouseEventHandler_ = new MouseEventHandler(method_4);
						num = (int)((num2 * 1712616308) ^ 0x6FD38238);
						continue;
					case 2u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -979943723) ^ 0x2C839ABA;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 1627636349;
							num4 = 1627636349;
						}
						else
						{
							num3 = 1177771674;
							num4 = 1177771674;
						}
						num = num3 ^ (int)(num2 * 850856851);
						continue;
					}
					case 0u:
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1447780935) ^ 0x210B4262;
						continue;
					default:
						return;
					case 4u:
						break;
					case 11u:
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
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			EventHandler eventHandler_ = method_5;
			EventHandler eventHandler_2 = method_6;
			MouseEventHandler mouseEventHandler_ = new MouseEventHandler(method_7);
			PictureBox val = pictureBox_2;
			if (val != null)
			{
				goto IL_0050;
			}
			goto IL_012b;
			IL_012b:
			pictureBox_2 = value;
			val = pictureBox_2;
			int num = -1912901799;
			goto IL_00f0;
			IL_00f0:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x93220AFAu) % 10u)
				{
				case 9u:
					GForm1.smethod_82((Control)(object)val, eventHandler_);
					num = ((int)num2 * -682692856) ^ -223815925;
					continue;
				case 8u:
					break;
				case 7u:
					GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
					num = ((int)num2 * -2077776974) ^ -100944254;
					continue;
				case 6u:
					GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
					num = (int)((num2 * 588792191) ^ 0x3BE4F2DA);
					continue;
				case 5u:
					GForm1.smethod_83((Control)(object)val, eventHandler_2);
					num = ((int)num2 * -2082885380) ^ 0x5DF3D3EF;
					continue;
				case 4u:
					GForm1.smethod_86((Control)(object)val, eventHandler_2);
					num = ((int)num2 * -1043236336) ^ -779414088;
					continue;
				case 3u:
					GForm1.smethod_85((Control)(object)val, eventHandler_);
					num = ((int)num2 * -570653819) ^ 0x5DC81B21;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (val != null)
					{
						num3 = -1734520762;
						num4 = -1734520762;
					}
					else
					{
						num3 = -256737249;
						num4 = -256737249;
					}
					num = num3 ^ (int)(num2 * 1275955401);
					continue;
				}
				default:
					return;
				case 0u:
					goto IL_012b;
				case 2u:
					return;
				}
				break;
			}
			goto IL_0050;
			IL_0050:
			num = -738984785;
			goto IL_00f0;
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
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			EventHandler eventHandler_ = method_8;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = -1889798433;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xADC0E3BAu) % 11u)
					{
					case 9u:
						pictureBox_3 = value;
						val = pictureBox_3;
						num = -1702242571;
						continue;
					case 8u:
						val = pictureBox_3;
						num = ((int)num2 * -1640045848) ^ 0xD315222;
						continue;
					case 7u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -2062887916;
							num6 = -2062887916;
						}
						else
						{
							num5 = -190559610;
							num6 = -190559610;
						}
						num = num5 ^ (int)(num2 * 1149390194);
						continue;
					}
					case 6u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = ((int)num2 * -2146113494) ^ 0x5B813553;
						continue;
					case 5u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						num = (int)((num2 * 44083887) ^ 0x49FB4AD0);
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 28211678;
							num4 = 28211678;
						}
						else
						{
							num3 = 1998982418;
							num4 = 1998982418;
						}
						num = num3 ^ (int)(num2 * 953814389);
						continue;
					}
					case 3u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 1395185261) ^ -1023019120;
						continue;
					case 2u:
						eventHandler_2 = method_9;
						mouseEventHandler_ = new MouseEventHandler(method_10);
						num = (int)((num2 * 1936551288) ^ 0x19D78F4D);
						continue;
					case 1u:
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 1534508353) ^ 0x54276D32);
						continue;
					default:
						return;
					case 10u:
						break;
					case 0u:
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
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			EventHandler eventHandler_ = method_11;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = -434393727;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9ECEC48Fu) % 11u)
					{
					case 10u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 1021984418;
							num6 = 1021984418;
						}
						else
						{
							num5 = 1333308608;
							num6 = 1333308608;
						}
						num = num5 ^ (int)(num2 * 1069767384);
						continue;
					}
					case 9u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 61006357) ^ -353295300;
						continue;
					case 8u:
						eventHandler_2 = method_12;
						num = (int)((num2 * 1540852536) ^ 0x8DA929F);
						continue;
					case 6u:
						mouseEventHandler_ = new MouseEventHandler(method_13);
						val = pictureBox_4;
						num = (int)(num2 * 609819854) ^ -1227186540;
						continue;
					case 5u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = ((int)num2 * -2081891392) ^ -1661104463;
						continue;
					case 4u:
						val = pictureBox_4;
						num = (int)((num2 * 770927246) ^ 0x1617EF86);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = 328175037;
							num4 = 328175037;
						}
						else
						{
							num3 = 429019836;
							num4 = 429019836;
						}
						num = num3 ^ (int)(num2 * 1968237752);
						continue;
					}
					case 1u:
						pictureBox_4 = value;
						num = -679264812;
						continue;
					case 0u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 1171787286) ^ -787532729;
						continue;
					default:
						return;
					case 7u:
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
				int num = -883991364;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC9B89D71u) % 8u)
					{
					case 6u:
						GForm1.smethod_81(val, eventHandler_);
						num = (int)((num2 * 1936477457) ^ 0x1A3E2E67);
						continue;
					case 5u:
					{
						val = timer_1;
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1092357030;
							num6 = 1092357030;
						}
						else
						{
							num5 = 2026280419;
							num6 = 2026280419;
						}
						num = num5 ^ (int)(num2 * 994664294);
						continue;
					}
					case 4u:
						timer_1 = value;
						num = -1505048918;
						continue;
					case 3u:
						val = timer_1;
						num = ((int)num2 * -1372938850) ^ 0x706D8649;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (val != null)
						{
							num3 = 899977933;
							num4 = 899977933;
						}
						else
						{
							num3 = 1637927099;
							num4 = 1637927099;
						}
						num = num3 ^ ((int)num2 * -980819667);
						continue;
					}
					case 1u:
						GForm1.smethod_80(val, eventHandler_);
						num = ((int)num2 * -887461019) ^ -2018029072;
						continue;
					default:
						return;
					case 7u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
	}

	public GForm1()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		GForm1.smethod_8((Form)(object)this, (EventHandler)method_0);
		GForm1.smethod_9((Form)(object)this, new FormClosingEventHandler(method_15));
		int_0 = 0;
		int_1 = 0;
		float_0 = 0.3f;
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		method_17();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)Class2.Class3_0.GForm1_0);
	}

	private void method_0(object sender, EventArgs e)
	{
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1244281910;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC384F6D5u) % 59u)
				{
				case 58u:
					flag = !GClass1.bool_1;
					num = ((int)num2 * -929131393) ^ 0x4630F390;
					continue;
				case 57u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png"));
					num = (int)((num2 * 854623487) ^ 0x432F2FBB);
					continue;
				case 56u:
					GForm1.smethod_20((object)int_1);
					GForm1.smethod_20((object)float_0);
					num = ((int)num2 * -773012681) ^ 0x709CB9EB;
					continue;
				case 55u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_pressed.png"));
					num = (int)(num2 * 560558723) ^ -598551845;
					continue;
				case 54u:
					bool_1 = false;
					num = ((int)num2 * -700199342) ^ 0x2AADE5FE;
					continue;
				case 53u:
					GForm1.smethod_16((Control)(object)PictureBox_4, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")), 0.1f));
					num = (int)(num2 * 121639248) ^ -1675566953;
					continue;
				case 52u:
					num = -546890487;
					continue;
				case 51u:
					num = -2020388159;
					continue;
				case 50u:
					num = (int)((num2 * 1644970559) ^ 0x59970B0F);
					continue;
				case 49u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\main_menu_theme.mp3"));
					num = ((int)num2 * -1993195490) ^ 0x6F8510E0;
					continue;
				case 48u:
					GClass3.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data"));
					GClass3.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music"));
					num = ((int)num2 * -2012914246) ^ -1330097854;
					continue;
				case 47u:
					GForm1.smethod_19();
					num = ((int)num2 * -1628808040) ^ -1889186121;
					continue;
				case 46u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_hover.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_hover.png"));
					num = (int)((num2 * 1249227807) ^ 0x7B3A1D37);
					continue;
				case 45u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\dark_story.jpg"));
					num = (int)(num2 * 1793175627) ^ -319717277;
					continue;
				case 44u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\schermata_omegle.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\marco_introduzione.png"));
					num = (int)((num2 * 568400069) ^ 0x147E0438);
					continue;
				case 43u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_pressed.png"));
					num = ((int)num2 * -360856991) ^ -2080146524;
					continue;
				case 42u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = ((int)num2 * -217151383) ^ -8957187;
					continue;
				case 41u:
					GClass1.smethod_0();
					num = ((int)num2 * -1917746728) ^ 0x3B1C446;
					continue;
				case 40u:
					GForm1.smethod_18(Timer_1);
					num = -216176942;
					continue;
				case 39u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\introduction_start_music.mp3"));
					GForm1.smethod_16((Control)(object)this, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg")));
					num = (int)(num2 * 806917632) ^ -2091225199;
					continue;
				case 38u:
					GForm1.smethod_12(GForm1.smethod_11(), ProcessPriorityClass.RealTime);
					num = ((int)num2 * -2112317883) ^ -355622967;
					continue;
				case 37u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = -598535907;
						num8 = -598535907;
					}
					else
					{
						num7 = -1291493965;
						num8 = -1291493965;
					}
					num = num7 ^ (int)(num2 * 1586606239);
					continue;
				}
				case 36u:
					GClass1.smethod_1().method_0();
					num = (int)(num2 * 887429958) ^ -1874994007;
					continue;
				case 35u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_pressed.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_pressed.png"));
					num = (int)(num2 * 1399669734) ^ -594304551;
					continue;
				case 34u:
					num = ((int)num2 * -1075847234) ^ -777605159;
					continue;
				case 33u:
					GClass1.bool_1 = true;
					num = ((int)num2 * -449397622) ^ 0x1E202E6C;
					continue;
				case 32u:
					GForm1.smethod_18(Timer_0);
					num = (int)(num2 * 757879962) ^ -1017622729;
					continue;
				case 31u:
					GForm1.smethod_16((Control)(object)PictureBox_0, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png")));
					num = (int)(num2 * 1402444288) ^ -1457060830;
					continue;
				case 30u:
					num = ((int)num2 * -2036438094) ^ 0x6F4265E8;
					continue;
				case 29u:
					GForm1.smethod_19();
					num = ((int)num2 * -1200293854) ^ -2028225364;
					continue;
				case 28u:
					flag3 = GClass1.bool_1;
					num = (int)((num2 * 439850921) ^ 0x53F9EA1F);
					continue;
				case 27u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png"));
					num = (int)(num2 * 998237111) ^ -2131070287;
					continue;
				case 26u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_hover.png"));
					num = (int)((num2 * 176273583) ^ 0x590A52C8);
					continue;
				case 25u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png"));
					num = (int)((num2 * 1388776377) ^ 0x4BA896FD);
					continue;
				case 24u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					num = (int)(num2 * 1948481576) ^ -2102063095;
					continue;
				case 23u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -2026048373;
						num6 = -2026048373;
					}
					else
					{
						num5 = -804985504;
						num6 = -804985504;
					}
					num = num5 ^ ((int)num2 * -2103866090);
					continue;
				}
				case 22u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg"));
					num = (int)((num2 * 123089325) ^ 0x5553E359);
					continue;
				case 21u:
					num = (int)(num2 * 1253715216) ^ -894146322;
					continue;
				case 20u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_hover.png"));
					num = ((int)num2 * -1816658500) ^ -1525282012;
					continue;
				case 19u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
					num = (int)((num2 * 1974738400) ^ 0x1B39E26B);
					continue;
				case 18u:
					GForm1.smethod_16((Control)(object)PictureBox_1, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")), 0.1f));
					num = (int)(num2 * 1133779049) ^ -168472934;
					continue;
				case 17u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_la_cpu.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_la_cpu_hover.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_gli_altri.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\fai_un_duello.png"));
					num = ((int)num2 * -1508644779) ^ -64975174;
					continue;
				case 16u:
					GForm1.smethod_16((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_0), 0.1f));
					num = ((int)num2 * -525374913) ^ -859919581;
					continue;
				case 15u:
					flag2 = !GClass1.bool_1;
					num = (int)((num2 * 1767354597) ^ 0x2B11AA6);
					continue;
				case 14u:
					GForm1.smethod_16((Control)(object)PictureBox_3, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")), 0.1f));
					num = ((int)num2 * -157407050) ^ 0x14602274;
					continue;
				case 13u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
					num = (int)(num2 * 139639603) ^ -826473225;
					continue;
				case 11u:
					bool_0 = true;
					num = ((int)num2 * -1439855724) ^ -385231206;
					continue;
				case 10u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -626306499;
						num4 = -626306499;
					}
					else
					{
						num3 = -289831093;
						num4 = -289831093;
					}
					num = num3 ^ (int)(num2 * 1519843549);
					continue;
				}
				case 9u:
					num = (int)(num2 * 245873174) ^ -454444602;
					continue;
				case 7u:
					num = ((int)num2 * -421074491) ^ -349283681;
					continue;
				case 6u:
					GForm1.smethod_20((object)int_0);
					num = (int)(num2 * 936142877) ^ -347483680;
					continue;
				case 5u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\horror_music.mp3"));
					num = (int)((num2 * 1086995560) ^ 0x62283200);
					continue;
				case 4u:
					GForm1.smethod_16((Control)(object)PictureBox_2, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")), 0.1f));
					num = ((int)num2 * -916612087) ^ -238894836;
					continue;
				case 3u:
					num = (int)(num2 * 1219516090) ^ -216159289;
					continue;
				case 2u:
					num = (int)(num2 * 915543756) ^ -810604658;
					continue;
				case 1u:
					num = (int)((num2 * 27707264) ^ 0x5688DA2E);
					continue;
				case 0u:
					num = (int)(num2 * 779490288) ^ -641604160;
					continue;
				default:
					return;
				case 8u:
					break;
				case 12u:
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
			int num = 469540585;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x59D2BA01u) % 11u)
				{
				case 9u:
					result = val;
					num = (int)(num2 * 70132682) ^ -2089842033;
					continue;
				case 8u:
					num = ((int)num2 * -682774649) ^ 0x3569F979;
					continue;
				case 6u:
					val = GForm1.smethod_23(GForm1.smethod_21(image_0), GForm1.smethod_22(image_0));
					graphics_ = GForm1.smethod_24((Image)(object)val);
					colorMatrix_ = GForm1.smethod_25();
					num = ((int)num2 * -1033257134) ^ -1733218597;
					continue;
				case 5u:
					GForm1.smethod_29(graphics_, image_0, new Rectangle(0, 0, GForm1.smethod_21((Image)(object)val), GForm1.smethod_22((Image)(object)val)), 0, 0, GForm1.smethod_21(image_0), GForm1.smethod_22(image_0), (GraphicsUnit)2, imageAttributes_);
					num = (int)(num2 * 765161517) ^ -606751599;
					continue;
				case 4u:
					imageAttributes_ = GForm1.smethod_27();
					num = (int)(num2 * 2092699091) ^ -750660810;
					continue;
				case 3u:
					GForm1.smethod_26(colorMatrix_, float_1);
					num = ((int)num2 * -1027060391) ^ 0x1B20F900;
					continue;
				case 2u:
					num = ((int)num2 * -963918897) ^ 0x65F91C1C;
					continue;
				case 1u:
					GForm1.smethod_28(imageAttributes_, colorMatrix_, (ColorMatrixFlag)0, (ColorAdjustType)1);
					num = (int)((num2 * 679614581) ^ 0x78AFB680);
					continue;
				case 0u:
					GForm1.smethod_30(graphics_);
					num = ((int)num2 * -1613482956) ^ -644362212;
					continue;
				case 10u:
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
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag5 = default(bool);
		while (true)
		{
			int num = 1843315422;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26ECDB3Cu) % 58u)
				{
				case 57u:
					num = ((int)num2 * -62981003) ^ -1811472232;
					continue;
				case 56u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
					num = (int)(num2 * 122890623) ^ -427693656;
					continue;
				case 55u:
					num = 978668992;
					continue;
				case 54u:
					num = (int)((num2 * 1569355821) ^ 0x16AA36FE);
					continue;
				case 53u:
					flag4 = int_1 == 4;
					num = 558949355;
					continue;
				case 52u:
					int_0 = 0;
					float_0 = 0.3f;
					num = ((int)num2 * -415249610) ^ -2042700460;
					continue;
				case 51u:
					GForm1.smethod_16((Control)(object)PictureBox_0, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png")));
					num = ((int)num2 * -1776590130) ^ -614886355;
					continue;
				case 50u:
				{
					ref float reference5 = ref float_0;
					reference5 = (float)((double)reference5 + 0.3);
					num = (int)((num2 * 450763800) ^ 0x540A1E92);
					continue;
				}
				case 49u:
				{
					int num12;
					int num13;
					if (flag3)
					{
						num12 = -2019314329;
						num13 = -2019314329;
					}
					else
					{
						num12 = -79197200;
						num13 = -79197200;
					}
					num = num12 ^ ((int)num2 * -8984913);
					continue;
				}
				case 48u:
					GForm1.smethod_31(Timer_0);
					num = (int)(num2 * 66354924) ^ -930897150;
					continue;
				case 47u:
					GForm1.smethod_16((Control)(object)PictureBox_2, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_2), float_0));
					num = (int)(num2 * 1629192687) ^ -77869583;
					continue;
				case 46u:
					num = 1925857536;
					continue;
				case 45u:
				{
					int num7;
					if (int_1 != 2)
					{
						num = 1331801835;
						num7 = 1331801835;
					}
					else
					{
						num = 126304039;
						num7 = 126304039;
					}
					continue;
				}
				case 44u:
					num = (int)((num2 * 2096900927) ^ 0x25E1AFCC);
					continue;
				case 43u:
					flag3 = int_1 == 5;
					num = 1975255471;
					continue;
				case 42u:
					flag2 = int_1 == 0;
					num = ((int)num2 * -456452118) ^ 0x74DD8F83;
					continue;
				case 41u:
					num = (int)(num2 * 608305819) ^ -290429542;
					continue;
				case 40u:
					num = ((int)num2 * -574719254) ^ 0x1E7637A9;
					continue;
				case 39u:
					GForm1.smethod_32(Timer_0, 50);
					num = (int)((num2 * 648131377) ^ 0x54983FB0);
					continue;
				case 38u:
				{
					int num15;
					int num16;
					if (!(((int_0 <= 15) & (int_1 == 0)) | ((int_0 <= 9) & (int_1 != 0))))
					{
						num15 = -89903781;
						num16 = -89903781;
					}
					else
					{
						num15 = -230059832;
						num16 = -230059832;
					}
					num = num15 ^ (int)(num2 * 65265369);
					continue;
				}
				case 37u:
					num = ((int)num2 * -297340298) ^ 0x70178E6A;
					continue;
				case 36u:
					GForm1.smethod_20((object)int_0);
					num = (int)((num2 * 379568910) ^ 0x2F0D4429);
					continue;
				case 35u:
				{
					int num14;
					if (int_1 != 3)
					{
						num = 1925849469;
						num14 = 1925849469;
					}
					else
					{
						num = 1476651141;
						num14 = 1476651141;
					}
					continue;
				}
				case 34u:
					checked
					{
						int_1++;
					}
					num = (int)((num2 * 770502707) ^ 0x665275E4);
					continue;
				case 33u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					num = (int)((num2 * 562913529) ^ 0x21FA1DD9);
					continue;
				case 32u:
				{
					ref float reference4 = ref float_0;
					reference4 = (float)((double)reference4 + 0.3);
					num = (int)(num2 * 1939250306) ^ -1697034007;
					continue;
				}
				case 31u:
					GForm1.smethod_20((object)float_0);
					num = (int)((num2 * 200859471) ^ 0x11A0BA0E);
					continue;
				case 30u:
				{
					ref float reference3 = ref float_0;
					reference3 = (float)((double)reference3 + 0.3);
					num = (int)((num2 * 1441307275) ^ 0x7B17DF3E);
					continue;
				}
				case 29u:
					flag = int_1 == 1;
					num = 1193158610;
					continue;
				case 28u:
					num = ((int)num2 * -1800744039) ^ -1424580884;
					continue;
				case 27u:
					num = 1253060878;
					continue;
				case 26u:
					num = 1321208262;
					continue;
				case 25u:
					flag5 = int_1 == 1;
					num = ((int)num2 * -914343569) ^ -1489545443;
					continue;
				case 24u:
					bool_0 = true;
					num = (int)(num2 * 2032173140) ^ -1879807276;
					continue;
				case 23u:
					GForm1.smethod_16((Control)(object)PictureBox_1, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_1), float_0));
					num = ((int)num2 * -324791339) ^ -1066224217;
					continue;
				case 22u:
				{
					int num10;
					int num11;
					if (!flag5)
					{
						num10 = 247650130;
						num11 = 247650130;
					}
					else
					{
						num10 = 538830375;
						num11 = 538830375;
					}
					num = num10 ^ (int)(num2 * 115177090);
					continue;
				}
				case 21u:
					num = (int)(num2 * 496981508) ^ -1536694360;
					continue;
				case 20u:
					num = ((int)num2 * -1897646777) ^ -1863425488;
					continue;
				case 19u:
				{
					int num8;
					int num9;
					if (!flag4)
					{
						num8 = 1877935462;
						num9 = 1877935462;
					}
					else
					{
						num8 = 1516947700;
						num9 = 1516947700;
					}
					num = num8 ^ ((int)num2 * -1828572250);
					continue;
				}
				case 17u:
					num = (int)((num2 * 462379871) ^ 0x599E2B17);
					continue;
				case 16u:
				{
					ref float reference2 = ref float_0;
					reference2 = (float)((double)reference2 + 0.3);
					num = ((int)num2 * -1227704417) ^ -1597529379;
					continue;
				}
				case 15u:
				{
					GForm1.smethod_16((Control)(object)PictureBox_3, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_3), float_0));
					ref float reference = ref float_0;
					reference = (float)((double)reference + 0.3);
					num = (int)(num2 * 504412361) ^ -1352127755;
					continue;
				}
				case 14u:
					GForm1.smethod_16((Control)(object)PictureBox_4, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_4), float_0));
					num = (int)((num2 * 284841839) ^ 0x784F1C77);
					continue;
				case 13u:
					GForm1.smethod_16((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_0), float_0));
					num = ((int)num2 * -1782012293) ^ 0x77524229;
					continue;
				case 12u:
					num = ((int)num2 * -559826336) ^ -1957967086;
					continue;
				case 11u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 227450255;
						num6 = 227450255;
					}
					else
					{
						num5 = 432197593;
						num6 = 432197593;
					}
					num = num5 ^ (int)(num2 * 304392632);
					continue;
				}
				case 10u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = (int)((num2 * 1241612855) ^ 0x26192BB0);
					continue;
				case 9u:
					GForm1.smethod_19();
					num = ((int)num2 * -1443722226) ^ 0x7448C473;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -562651831;
						num4 = -562651831;
					}
					else
					{
						num3 = -2045231769;
						num4 = -2045231769;
					}
					num = num3 ^ ((int)num2 * -2055297970);
					continue;
				}
				case 6u:
					num = ((int)num2 * -894179679) ^ -1416450355;
					continue;
				case 5u:
					num = (int)(num2 * 1523316223) ^ -249689015;
					continue;
				case 4u:
					int_0 = 0;
					float_0 = 0.3f;
					num = ((int)num2 * -1416020993) ^ -763389311;
					continue;
				case 3u:
					GForm1.smethod_20((object)Timer_0);
					num = ((int)num2 * -76763092) ^ -2072225463;
					continue;
				case 2u:
					num = (int)((num2 * 18370954) ^ 0x220F9904);
					continue;
				case 1u:
					num = ((int)num2 * -771776421) ^ 0x1B57DBF7;
					continue;
				case 0u:
					GForm1.smethod_16((Control)(object)this, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg")));
					num = ((int)num2 * -722220232) ^ 0x367A525F;
					continue;
				case 7u:
					break;
				default:
					checked
					{
						int_0++;
						return;
					}
				}
				break;
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 977089197;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x47D8D89Fu) % 7u)
				{
				case 5u:
					num = 824077688;
					continue;
				case 4u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_hover.png")));
					num = ((int)num2 * -815156660) ^ -360342367;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1984259319;
						num4 = -1984259319;
					}
					else
					{
						num3 = -1056067426;
						num4 = -1056067426;
					}
					num = num3 ^ ((int)num2 * -1297472821);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1320307996) ^ -926790046;
					continue;
				case 1u:
					flag = bool_0;
					num = ((int)num2 * -1869766415) ^ 0x138B1A34;
					continue;
				default:
					return;
				case 0u:
					break;
				case 6u:
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
			int num = -1749821582;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB6DDFE4Du) % 6u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -727557655;
						num4 = -727557655;
					}
					else
					{
						num3 = -1375830759;
						num4 = -1375830759;
					}
					num = num3 ^ (int)(num2 * 1803670982);
					continue;
				}
				case 3u:
					num = ((int)num2 * -228965869) ^ 0x58A4910A;
					continue;
				case 1u:
					flag = bool_0;
					num = ((int)num2 * -119611863) ^ 0x563001C2;
					continue;
				case 0u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
					num = (int)(num2 * 1454789284) ^ -1124387892;
					continue;
				default:
					return;
				case 5u:
					break;
				case 2u:
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
			int num = -933218644;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC2DEB93Fu) % 9u)
				{
				case 8u:
					GForm1.smethod_34((Form)(object)this);
					num = ((int)num2 * -1316421697) ^ 0x78C311D4;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 548450636;
						num4 = 548450636;
					}
					else
					{
						num3 = 166098585;
						num4 = 166098585;
					}
					num = num3 ^ (int)(num2 * 1832518790);
					continue;
				}
				case 6u:
					num = ((int)num2 * -1738112998) ^ 0x46901451;
					continue;
				case 5u:
					num = -1006655913;
					continue;
				case 4u:
					bool_1 = true;
					num = (int)((num2 * 316390702) ^ 0x38C36090);
					continue;
				case 3u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_pressed.png")));
					GClass1.smethod_1().method_3();
					GClass1.smethod_1().method_4();
					num = ((int)num2 * -168908543) ^ -1971420945;
					continue;
				case 2u:
					GForm1.smethod_33((Control)(object)Class2.Class3_0.GForm3_0);
					num = (int)(num2 * 1828372616) ^ -1406342799;
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

	private void method_5(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -2039036654;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCDEC2346u) % 7u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -2053205107;
						num4 = -2053205107;
					}
					else
					{
						num3 = -238263451;
						num4 = -238263451;
					}
					num = num3 ^ ((int)num2 * -741872441);
					continue;
				}
				case 4u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_hover.png")));
					num = ((int)num2 * -402904306) ^ -1370236294;
					continue;
				case 2u:
					num = (int)((num2 * 521735416) ^ 0x3D80BD7C);
					continue;
				case 1u:
					flag = bool_0;
					num = (int)(num2 * 1433214620) ^ -2009596823;
					continue;
				case 0u:
					num = -2108165783;
					continue;
				default:
					return;
				case 6u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -85945179;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x87008E78u) % 5u)
				{
				case 2u:
					num = -449140522;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (bool_0)
					{
						num3 = 2049272504;
						num4 = 2049272504;
					}
					else
					{
						num3 = 2020808460;
						num4 = 2020808460;
					}
					num = num3 ^ ((int)num2 * -1317094440);
					continue;
				}
				case 0u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					num = ((int)num2 * -1239941085) ^ -1467826596;
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

	private void method_7(object sender, MouseEventArgs e)
	{
		bool flag = bool_0;
		while (true)
		{
			int num = -1096417359;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9DE044AEu) % 8u)
				{
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 750850686;
						num4 = 750850686;
					}
					else
					{
						num3 = 797503060;
						num4 = 797503060;
					}
					num = num3 ^ ((int)num2 * -107338473);
					continue;
				}
				case 6u:
					num = ((int)num2 * -940919779) ^ -662071316;
					continue;
				case 4u:
					GForm1.smethod_34((Form)(object)this);
					num = ((int)num2 * -844266978) ^ 0x4308B584;
					continue;
				case 3u:
					num = -1055303213;
					continue;
				case 2u:
					num = ((int)num2 * -1394191000) ^ -1402972979;
					continue;
				case 1u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_pressed.png")));
					bool_1 = true;
					GForm1.smethod_33((Control)(object)Class2.Class3_0.GForm2_0);
					num = (int)((num2 * 714808892) ^ 0x1335A4BC);
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

	private void method_8(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1373853031;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x10792556u) % 7u)
				{
				case 5u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_hover.png")));
					num = (int)((num2 * 835420858) ^ 0x239D3E9);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1097653322;
						num4 = -1097653322;
					}
					else
					{
						num3 = -1558758640;
						num4 = -1558758640;
					}
					num = num3 ^ (int)(num2 * 2115528128);
					continue;
				}
				case 3u:
					num = 1510504539;
					continue;
				case 2u:
					flag = bool_0;
					num = ((int)num2 * -978226410) ^ 0x1FACF95F;
					continue;
				case 1u:
					num = (int)(num2 * 1499434272) ^ -1749965904;
					continue;
				default:
					return;
				case 0u:
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
		bool flag = bool_0;
		while (true)
		{
			int num = 1270451981;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5276898Du) % 5u)
				{
				case 3u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
					num = ((int)num2 * -30856409) ^ 0x254551DB;
					continue;
				case 2u:
					num = ((int)num2 * -501321899) ^ 0x1B9D9367;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1307803035;
						num4 = -1307803035;
					}
					else
					{
						num3 = -1799827007;
						num4 = -1799827007;
					}
					num = num3 ^ (int)(num2 * 531260842);
					continue;
				}
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

	private void method_10(object sender, MouseEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 2111129749;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3FD65F44u) % 5u)
				{
				case 4u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_pressed.png")));
					num = ((int)num2 * -364340837) ^ 0x1C3E52EC;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1597937937;
						num4 = 1597937937;
					}
					else
					{
						num3 = 1882438051;
						num4 = 1882438051;
					}
					num = num3 ^ ((int)num2 * -536780664);
					continue;
				}
				case 1u:
					flag = bool_0;
					num = (int)((num2 * 1304071434) ^ 0x487C6033);
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void method_11(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -214448403;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC8A45D76u) % 7u)
				{
				case 5u:
					num = (int)((num2 * 1243340480) ^ 0x1866ADC5);
					continue;
				case 4u:
					num = -1831594803;
					continue;
				case 3u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_hover.png")));
					num = (int)((num2 * 1845046015) ^ 0x9044EDC);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (bool_0)
					{
						num3 = -765661478;
						num4 = -765661478;
					}
					else
					{
						num3 = -857844492;
						num4 = -857844492;
					}
					num = num3 ^ ((int)num2 * -1732357059);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1706319417) ^ 0x68700FFE;
					continue;
				default:
					return;
				case 6u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void method_12(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1636611442;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C01F944u) % 7u)
				{
				case 6u:
					flag = bool_0;
					num = ((int)num2 * -1811055209) ^ -1597187465;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 158585742;
						num4 = 158585742;
					}
					else
					{
						num3 = 1806616722;
						num4 = 1806616722;
					}
					num = num3 ^ ((int)num2 * -796512429);
					continue;
				}
				case 4u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = (int)((num2 * 616985511) ^ 0x3C447A7E);
					continue;
				case 1u:
					num = 1170534041;
					continue;
				case 0u:
					num = ((int)num2 * -1520089375) ^ 0x25D107A4;
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

	private void method_13(object sender, MouseEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -924061529;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80123B0Eu) % 8u)
				{
				case 5u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_pressed.png")));
					num = (int)((num2 * 7014139) ^ 0x4B0AD16A);
					continue;
				case 4u:
					num = ((int)num2 * -1937352919) ^ -698505336;
					continue;
				case 3u:
					method_14();
					num = ((int)num2 * -2057751738) ^ -943583480;
					continue;
				case 2u:
					num = -1705275063;
					continue;
				case 1u:
					flag = bool_0;
					num = (int)(num2 * 1533605985) ^ -912470561;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -311150876;
						num4 = -311150876;
					}
					else
					{
						num3 = -831403949;
						num4 = -831403949;
					}
					num = num3 ^ ((int)num2 * -686787175);
					continue;
				}
				default:
					return;
				case 6u:
					break;
				case 7u:
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
		while (true)
		{
			int num = -63045501;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC82143C0u) % 21u)
				{
				case 20u:
					num = ((int)num2 * -1312241588) ^ -48722733;
					continue;
				case 19u:
					num = ((int)num2 * -992217919) ^ 0x618274E9;
					continue;
				case 17u:
					num = -1394551936;
					continue;
				case 16u:
					GForm1.smethod_20((object)Timer_1);
					num = (int)((num2 * 2023450249) ^ 0x4AE7D4B0);
					continue;
				case 15u:
					GForm1.smethod_19();
					num = ((int)num2 * -1967741934) ^ -456724351;
					continue;
				case 14u:
					num = ((int)num2 * -1502005517) ^ -359915120;
					continue;
				case 13u:
					GForm1.smethod_31(Timer_1);
					GForm1.smethod_20((object)Timer_1);
					num = ((int)num2 * -1296870123) ^ 0x4F6A2128;
					continue;
				case 12u:
					GForm1.smethod_19();
					num = (int)((num2 * 1284654158) ^ 0x17DADC9B);
					continue;
				case 11u:
					GForm1.smethod_20((object)bool_0);
					num = ((int)num2 * -493905295) ^ -671574528;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if ((int)GForm1.smethod_35("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) != 6)
					{
						num5 = 790452763;
						num6 = 790452763;
					}
					else
					{
						num5 = 2055141822;
						num6 = 2055141822;
					}
					num = num5 ^ (int)(num2 * 1316908376);
					continue;
				}
				case 9u:
					GForm1.smethod_20((object)bool_1);
					num = ((int)num2 * -1552313319) ^ 0x531F8BF8;
					continue;
				case 8u:
					num = -117562842;
					continue;
				case 7u:
					num = ((int)num2 * -1481598136) ^ 0x4B6108DD;
					continue;
				case 6u:
					num = ((int)num2 * -1987555995) ^ 0x40F80FFC;
					continue;
				case 5u:
					num = (int)((num2 * 1859620849) ^ 0xE1E229F);
					continue;
				case 4u:
					GForm1.smethod_36(GForm1.smethod_11());
					num = ((int)num2 * -97493278) ^ -1171211009;
					continue;
				case 3u:
					GForm1.smethod_31(Timer_1);
					num = (int)(num2 * 1190604199) ^ -896522465;
					continue;
				case 2u:
					GForm1.smethod_20((object)bool_0);
					GForm1.smethod_20((object)bool_1);
					num = (int)((num2 * 82442801) ^ 0xBDFDFF6);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (bool_1)
					{
						num3 = -1889386392;
						num4 = -1889386392;
					}
					else
					{
						num3 = -1142754711;
						num4 = -1142754711;
					}
					num = num3 ^ ((int)num2 * -817767350);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 18u:
					return;
				}
				break;
			}
		}
	}

	private void method_15(object sender, FormClosingEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1334379912;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAB41B851u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -374310840) ^ -912656859;
					continue;
				case 3u:
					method_14();
					flag = !bool_1;
					num = ((int)num2 * -1960534802) ^ 0x2ADE5678;
					continue;
				case 2u:
					GForm1.smethod_37((CancelEventArgs)(object)e, bool_3: true);
					num = (int)((num2 * 1900566837) ^ 0x235A3B38);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1954757749;
						num4 = -1954757749;
					}
					else
					{
						num3 = -1480092361;
						num4 = -1480092361;
					}
					num = num3 ^ (int)(num2 * 780579850);
					continue;
				}
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

	private void method_16(object sender, EventArgs e)
	{
		GForm1.smethod_19();
		while (true)
		{
			int num = -1951268615;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA6076563u) % 3u)
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
				num = ((int)num2 * -1346324216) ^ 0x5597DA2C;
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
				int num = -685154092;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xDC913ED0u) % 9u)
					{
					case 7u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 1849655361;
							num5 = 1849655361;
						}
						else
						{
							num4 = 654649998;
							num5 = 654649998;
						}
						num = num4 ^ (int)(num2 * 1410086255);
						continue;
					}
					case 6u:
						GForm1.smethod_38((IDisposable)icontainer_0);
						num = ((int)num2 * -517272086) ^ -1847704871;
						continue;
					case 5u:
						if (disposing)
						{
							num = ((int)num2 * -1081998991) ^ 0x59CD4DFD;
							continue;
						}
						num3 = 0;
						goto IL_0058;
					case 4u:
						num = (int)(num2 * 1534949650) ^ -1473691719;
						continue;
					case 3u:
						num = ((int)num2 * -831318068) ^ -442323699;
						continue;
					case 2u:
						num = -1370882897;
						continue;
					case 1u:
						num3 = ((icontainer_0 != null) ? 1 : 0);
						goto IL_0058;
					default:
						return;
					case 8u:
						break;
					case 0u:
						return;
						IL_0058:
						flag = (byte)num3 != 0;
						num = -48399928;
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
				IL_0103:
				int num6 = -359783612;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num6 ^ 0xDC913ED0u) % 3u)
					{
					case 1u:
						goto IL_00d2;
					default:
						goto end_IL_00e6;
					case 0u:
						break;
					case 2u:
						goto end_IL_00e6;
					}
					goto IL_0103;
					IL_00d2:
					((Form)this).Dispose(disposing);
					num6 = ((int)num2 * -57773685) ^ -1612099214;
					continue;
					end_IL_00e6:
					break;
				}
				break;
			}
		}
	}

	[DebuggerStepThrough]
	private void method_17()
	{
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -1763676083;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2CDA32Cu) % 77u)
				{
				case 76u:
					GForm1.smethod_43((Control)(object)this);
					num = ((int)num2 * -2034598399) ^ 0x2740B3A9;
					continue;
				case 75u:
					GForm1.smethod_64((Form)(object)this, "The Omegle Game");
					GForm1.smethod_65((ISupportInitialize)PictureBox_0);
					num = (int)(num2 * 623585334) ^ -1459648635;
					continue;
				case 74u:
					GForm1.smethod_50(PictureBox_0, bool_3: false);
					GForm1.smethod_32(Timer_0, 300);
					num = ((int)num2 * -288846293) ^ 0x1F497014;
					continue;
				case 73u:
					num = ((int)num2 * -1949537377) ^ -315264517;
					continue;
				case 72u:
					GForm1.smethod_47((Control)(object)PictureBox_0, "PictureBox1");
					num = (int)(num2 * 1614796100) ^ -1424102401;
					continue;
				case 71u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_3);
					num = (int)((num2 * 1147302186) ^ 0x7CD6E7BD);
					continue;
				case 70u:
					num = ((int)num2 * -1834997660) ^ 0x33A036D5;
					continue;
				case 69u:
					GForm1.smethod_46((Control)(object)PictureBox_3, new Point(337, 343));
					num = ((int)num2 * -760771472) ^ 0x346FC24B;
					continue;
				case 68u:
					GForm1.smethod_50(PictureBox_4, bool_3: false);
					num = (int)((num2 * 1908752982) ^ 0x13BCC5EE);
					continue;
				case 67u:
					GForm1.smethod_58((Control)(object)this, GForm1.smethod_57("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					num = ((int)num2 * -1117689615) ^ -54070838;
					continue;
				case 66u:
					Timer_0 = GForm1.smethod_41(icontainer_0);
					PictureBox_1 = GForm1.smethod_40();
					PictureBox_2 = GForm1.smethod_40();
					num = (int)((num2 * 1915811655) ^ 0x351D4309);
					continue;
				case 65u:
					num = ((int)num2 * -1045774396) ^ 0x29A53EF4;
					continue;
				case 64u:
					GForm1.smethod_49(PictureBox_0, 0);
					num = (int)((num2 * 134074979) ^ 0x2CD4CD8E);
					continue;
				case 63u:
					GForm1.smethod_46((Control)(object)PictureBox_1, new Point(349, 198));
					num = (int)((num2 * 136122777) ^ 0x5175F54D);
					continue;
				case 62u:
					num = (int)((num2 * 264771756) ^ 0x245332D6);
					continue;
				case 61u:
					GForm1.smethod_46((Control)(object)PictureBox_2, new Point(336, 278));
					num = ((int)num2 * -1591584233) ^ -934386127;
					continue;
				case 60u:
					num = ((int)num2 * -116036085) ^ -510285329;
					continue;
				case 59u:
					GForm1.smethod_44((Control)(object)PictureBox_0, Color.Transparent);
					num = (int)(num2 * 166161889) ^ -173526756;
					continue;
				case 58u:
					GForm1.smethod_45((Control)(object)PictureBox_0, (ImageLayout)3);
					num = ((int)num2 * -1730180123) ^ -211206718;
					continue;
				case 57u:
					GForm1.smethod_45((Control)(object)this, (ImageLayout)3);
					num = (int)((num2 * 1948942001) ^ 0x7A044BF8);
					continue;
				case 56u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_4);
					num = (int)((num2 * 1970246690) ^ 0x75859BB9);
					continue;
				case 55u:
					GForm1.smethod_66((Control)(object)this, bool_3: false);
					num = (int)((num2 * 1340434289) ^ 0x1012535B);
					continue;
				case 54u:
					num = ((int)num2 * -154162407) ^ -489165068;
					continue;
				case 53u:
					GForm1.smethod_60((Form)(object)this, new Padding(4));
					num = ((int)num2 * -1214052979) ^ 0x58B24B5;
					continue;
				case 52u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_3);
					num = (int)(num2 * 1490091734) ^ -473779360;
					continue;
				case 51u:
					PictureBox_4 = GForm1.smethod_40();
					num = (int)(num2 * 2133427981) ^ -411959345;
					continue;
				case 50u:
					Timer_1 = GForm1.smethod_41(icontainer_0);
					num = (int)((num2 * 1527382424) ^ 0x5D440B20);
					continue;
				case 49u:
					GForm1.smethod_44((Control)(object)PictureBox_1, Color.Transparent);
					num = ((int)num2 * -969194624) ^ -1833815870;
					continue;
				case 48u:
					GForm1.smethod_49(PictureBox_1, 1);
					num = (int)(num2 * 1364442379) ^ -693654370;
					continue;
				case 47u:
					num = (int)((num2 * 1172253630) ^ 0x33F08661);
					continue;
				case 46u:
					GForm1.smethod_44((Control)(object)PictureBox_4, Color.Transparent);
					num = ((int)num2 * -60180392) ^ -332153416;
					continue;
				case 45u:
					GForm1.smethod_50(PictureBox_2, bool_3: false);
					GForm1.smethod_44((Control)(object)PictureBox_3, Color.Transparent);
					num = (int)(num2 * 1323086984) ^ -1441355205;
					continue;
				case 44u:
					num = ((int)num2 * -2109293935) ^ -538545674;
					continue;
				case 43u:
					num = (int)(num2 * 334024791) ^ -1370379600;
					continue;
				case 41u:
					num = (int)(num2 * 294209087) ^ -29022931;
					continue;
				case 40u:
					GForm1.smethod_48((Control)(object)PictureBox_0, new Size(617, 69));
					num = ((int)num2 * -1654732318) ^ -751397013;
					continue;
				case 39u:
					GForm1.smethod_50(PictureBox_1, bool_3: false);
					GForm1.smethod_44((Control)(object)PictureBox_2, Color.Transparent);
					num = (int)((num2 * 852265194) ^ 0x5F41FDF2);
					continue;
				case 38u:
					PictureBox_3 = GForm1.smethod_40();
					num = (int)(num2 * 1160402561) ^ -273614119;
					continue;
				case 37u:
					GForm1.smethod_54((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -159246414) ^ -943723266;
					continue;
				case 36u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_0);
					num = (int)((num2 * 387595473) ^ 0x5BDAEAE0);
					continue;
				case 35u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_2);
					num = (int)(num2 * 1077097091) ^ -738894013;
					continue;
				case 33u:
					num = (int)(num2 * 1749820505) ^ -967770982;
					continue;
				case 32u:
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -1921841320) ^ -952434396;
					continue;
				case 31u:
					GForm1.smethod_63((Form)(object)this, (FormStartPosition)1);
					num = (int)(num2 * 1070078123) ^ -1715163359;
					continue;
				case 30u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_4);
					num = (int)((num2 * 1096381505) ^ 0x96BAED7);
					continue;
				case 29u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_3);
					num = ((int)num2 * -878053030) ^ -949936773;
					continue;
				case 28u:
					GForm1.smethod_48((Control)(object)PictureBox_2, new Size(329, 59));
					GForm1.smethod_49(PictureBox_2, 2);
					num = ((int)num2 * -2128274420) ^ -758988456;
					continue;
				case 27u:
					GForm1.smethod_47((Control)(object)PictureBox_3, smethod_5(bool_3: true));
					num = ((int)num2 * -1233142080) ^ -933069739;
					continue;
				case 26u:
					GForm1.smethod_49(PictureBox_4, 4);
					num = (int)(num2 * 1238084484) ^ -1799824173;
					continue;
				case 25u:
					GForm1.smethod_46((Control)(object)PictureBox_4, new Point(396, 408));
					num = ((int)num2 * -2146612227) ^ 0x6A24FD49;
					continue;
				case 24u:
					GForm1.smethod_48((Control)(object)PictureBox_3, new Size(329, 59));
					num = ((int)num2 * -1934597397) ^ -1874727766;
					continue;
				case 23u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_4);
					num = (int)(num2 * 890449543) ^ -1215654114;
					continue;
				case 22u:
					num = (int)(num2 * 1682903412) ^ -1942493956;
					continue;
				case 21u:
					GForm1.smethod_53((Form)(object)this, Color.White);
					num = ((int)num2 * -604373440) ^ -1909880844;
					continue;
				case 20u:
					GForm1.smethod_59((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -350548443) ^ -1792621809;
					continue;
				case 19u:
					num = (int)((num2 * 1719356635) ^ 0x678D86CA);
					continue;
				case 18u:
					num = ((int)num2 * -2021086375) ^ -2133735504;
					continue;
				case 17u:
					icontainer_0 = GForm1.smethod_39();
					PictureBox_0 = GForm1.smethod_40();
					num = (int)((num2 * 479075559) ^ 0x16EE47C3);
					continue;
				case 16u:
					num = ((int)num2 * -1472890689) ^ 0x3D0573A0;
					continue;
				case 15u:
					GForm1.smethod_32(Timer_1, 1000);
					num = ((int)num2 * -868052932) ^ -437889322;
					continue;
				case 14u:
					num = (int)((num2 * 637232782) ^ 0x25BFC654);
					continue;
				case 13u:
					GForm1.smethod_49(PictureBox_3, 3);
					GForm1.smethod_50(PictureBox_3, bool_3: false);
					num = (int)((num2 * 289044974) ^ 0x326D71FB);
					continue;
				case 12u:
					num = ((int)num2 * -1407976174) ^ -500656948;
					continue;
				case 11u:
					GForm1.smethod_48((Control)(object)PictureBox_1, new Size(303, 65));
					num = ((int)num2 * -1976473193) ^ 0x125C05E5;
					continue;
				case 10u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_1);
					GForm1.smethod_65((ISupportInitialize)PictureBox_2);
					num = ((int)num2 * -2118022977) ^ 0x28242495;
					continue;
				case 9u:
					num = (int)((num2 * 1747050912) ^ 0x6DAD338C);
					continue;
				case 8u:
					GForm1.smethod_46((Control)(object)PictureBox_0, new Point(214, 12));
					num = ((int)num2 * -128137818) ^ 0x1A6DC56E;
					continue;
				case 7u:
					GForm1.smethod_48((Control)(object)PictureBox_4, new Size(213, 59));
					num = (int)((num2 * 259764112) ^ 0x21EE6E07);
					continue;
				case 6u:
					GForm1.smethod_61((Form)(object)this, bool_3: false);
					GForm1.smethod_62((Control)(object)this, "MainForm");
					num = ((int)num2 * -1362494111) ^ 0x4B6896C7;
					continue;
				case 5u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_0);
					GForm1.smethod_42((ISupportInitialize)PictureBox_1);
					num = (int)(num2 * 288386855) ^ -928867114;
					continue;
				case 4u:
					GForm1.smethod_47((Control)(object)PictureBox_4, "PictureBox5");
					num = (int)((num2 * 1747085249) ^ 0x31C71B76);
					continue;
				case 3u:
					GForm1.smethod_47((Control)(object)PictureBox_1, "PictureBox2");
					num = (int)((num2 * 254972145) ^ 0x39C7ACD8);
					continue;
				case 2u:
					GForm1.smethod_47((Control)(object)PictureBox_2, "PictureBox3");
					num = (int)((num2 * 1550878615) ^ 0x6BAC1B6);
					continue;
				case 1u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_2);
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_1);
					num = ((int)num2 * -1883227558) ^ -2127708293;
					continue;
				case 0u:
					GForm1.smethod_51((ContainerControl)(object)this, new SizeF(10f, 22f));
					GForm1.smethod_52((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)(num2 * 2048434454) ^ -1777046080;
					continue;
				default:
					return;
				case 34u:
					break;
				case 42u:
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
			int num = 552073825;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x54CE507u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					GForm1.smethod_68((object)object_, "Invoke", (CallType)2, new object[2] { 0, array });
					return;
				}
				break;
				IL_0003:
				array = new object[3]
				{
					GClass2.String_1,
					GClass2.String_0,
					"The_Omegle_Game"
				};
				object_ = GForm1.smethod_67(type_0)[3];
				num = (int)((num2 * 1521754344) ^ 0x4ADA2F18);
			}
		}
	}

	private static void smethod_2(Assembly assembly_0)
	{
		bool flag = default(bool);
		Type type_ = default(Type);
		int num3 = default(int);
		while (true)
		{
			int num = -493174274;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x823877E9u) % 16u)
				{
				case 15u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -1449287358;
						num7 = -1449287358;
					}
					else
					{
						num6 = -1063421064;
						num7 = -1063421064;
					}
					num = num6 ^ ((int)num2 * -1253577243);
					continue;
				}
				case 14u:
					smethod_1(type_, 5);
					num = (int)((num2 * 931666483) ^ 0x527EE265);
					continue;
				case 12u:
					type_ = GForm1.smethod_69(assembly_0)[0];
					num = (int)(num2 * 243499490) ^ -1844690896;
					continue;
				case 11u:
					num3 = 251367129;
					num = (int)((num2 * 166066712) ^ 0x9C52944);
					continue;
				case 10u:
					num = -174990841;
					continue;
				case 9u:
					num = (int)(num2 * 1875128633) ^ -1825033205;
					continue;
				case 8u:
					num = ((int)num2 * -2012023812) ^ -160879302;
					continue;
				case 7u:
					num3 = 251367102;
					num = (int)((num2 * 1486998455) ^ 0x6B7268B4);
					continue;
				case 6u:
					num = (int)(num2 * 1115131735) ^ -1861457343;
					continue;
				case 5u:
					num = ((int)num2 * -1357248416) ^ -811044614;
					continue;
				case 4u:
					flag = num3 == 251367142;
					num = -421034042;
					continue;
				case 2u:
					num3 = 251367134;
					num = ((int)num2 * -913372011) ^ 0x43D596DA;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (num3 == 251367199)
					{
						num4 = 2048583292;
						num5 = 2048583292;
					}
					else
					{
						num4 = 1781187411;
						num5 = 1781187411;
					}
					num = num4 ^ (int)(num2 * 512293982);
					continue;
				}
				case 0u:
					num3 = 251367188;
					num = (int)(num2 * 1373833640) ^ -2078443759;
					continue;
				default:
					return;
				case 13u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private static Assembly smethod_3(byte[] byte_0, bool bool_3)
	{
		Assembly result = GForm1.smethod_70(byte_0);
		while (true)
		{
			int num = -266897029;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9D80D780u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0009:
				num = ((int)num2 * -1710467626) ^ -428609911;
			}
		}
	}

	public static string smethod_4(string string_0)
	{
		string text = null;
		bool flag = default(bool);
		string string_2 = default(string);
		string string_ = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 1647482968;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x20E1E91Bu) % 10u)
				{
				case 9u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1008569208;
						num5 = -1008569208;
					}
					else
					{
						num4 = -199515772;
						num5 = -199515772;
					}
					num = num4 ^ ((int)num2 * -2089445349);
					continue;
				}
				case 8u:
				{
					int int_ = checked(GForm1.smethod_73(string_2) - 670);
					string_ = GForm1.smethod_72(GForm1.smethod_74(int_));
					num = ((int)num2 * -2018803197) ^ -375504370;
					continue;
				}
				case 7u:
					num3 = 0;
					num = (int)((num2 * 890693977) ^ 0xC3BEB20);
					continue;
				case 6u:
					string_2 = GForm1.smethod_72(GForm1.smethod_71(string_0, num3));
					num = 1698094143;
					continue;
				case 5u:
					num3 = checked(num3 + 1);
					num = ((int)num2 * -220389243) ^ -1884773180;
					continue;
				case 4u:
					flag = num3 < GForm1.smethod_75(string_0);
					num = 599517340;
					continue;
				case 1u:
					text = GForm1.smethod_14(text, string_);
					num = ((int)num2 * -362563634) ^ 0x71BB01E6;
					continue;
				case 0u:
					result = text;
					num = (int)((num2 * 2002851925) ^ 0x65F9D6A1);
					continue;
				case 3u:
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
		Assembly object_ = default(Assembly);
		object obj = default(object);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1461179308;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE01E57F8u) % 7u)
				{
				case 6u:
					smethod_7(object_);
					num = (int)((num2 * 1586207059) ^ 0x7502760D);
					continue;
				case 5u:
					num = ((int)num2 * -1659181104) ^ 0x5FD6ADFF;
					continue;
				case 4u:
					object_ = smethod_3((byte[])obj, bool_3: true);
					num = (int)((num2 * 172928913) ^ 0x458F1222);
					continue;
				case 3u:
				{
					text = GForm1.smethod_76("\u02f2\u02f4\u030f\u02ef\u200c??\u02eb\u200c??\u200c????\u200c??\u200c??????\u02d6\u200c??\u02ea\u0305\u200c??\u200c??\u200c??\u200c??\u02df\u02ef\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u0305\u200c??\u200c??\u02df\u02d2\u0304\u0313\u0305\u02d2\u02df\u0312\u02df\u030c??\u02e7\u0300\u0305??\u02f2\u02eb??\u0306\u02f4\u02e5\u0306\u030e\u0301\u0317??\u0315\u0301\u030b\u02d7\u030c\u0301\u030b??\u0312\u02e7\u02e5??\u0306\u0300\u030b\u02d3\u0314\u0302????\u0307\u02f8\u02f1??\u0317\u0302\u02f5\u02d2\u0305\u02ff\u02f5\u02d2\u0305\u02f0??\u02d7\u02f2\u02e7\u02e5??\u0314\u02f8\u02e5\u02f3\u0313??\u02ef??\u02e9\u02e8\u200c??\u200c??\u200c??\u200c??\u02df??\u02ef\u02f0\u02ef\u200c??\u02f2\u02df????\u02df\u02e5??\u02e9\u030a\u02f5??\u200c??\u200c??\u200c??\u200c??\u200c??\u02ed\u200c??\u02df\u0307??\u02ea\u02df\u02ef\u0305\u200c????\u030d\u200c??\u200c??\u02e5\u200c??\u200c??\u200c??\u200c????\u030a\u0305\u200c??\u200c??\u0305\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u0305\u200c??\u200c??\u02df\u0305\u200c????\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c????\u0305\u200c??\u200c??\u02df\u0305\u200c??\u200c??\u200c??\u200c??\u02eb\u02df\u02ef\u02e7\u02f3\u200c????\u200c??\u02df??\u200c??\u200c??\u200c????\u200c??\u02df??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02ea\u0316\u02f6\u200c??????\u200c??\u200c??\u02df\u02e5\u200c??\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u200c??\u0315\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df????\u200c??\u02df??\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02d3??\u02f8\u02f6\u0306??\u200c??\u200c??????\u0305\u200c??\u200c??\u0305\u200c??\u200c??\u02ed\u0305\u200c??\u200c??\u02e7\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u02df\u02e5\u02df\u0313\u0301\u030c??\u0317\u02f7\u0315\u200c??\u200c??\u02df??\u200c??\u200c??\u02f7\u200c??\u200c??\u02df\u02ef\u200c??\u200c??\u02d6\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u02df??\u02df\u02ea\u030c\u02e8\u030a\u0300\u02e5\u02d7\u0308\u200c??\u02df\u02eb\u200c??\u200c??\u02df\u02e7\u200c??\u200c??\u02df??\u200c??\u200c??\u02ef\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02ef\u200c??\u02df\u02ef\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u0315\u02f4\u0315\u200c??\u200c??\u200c??\u02df??\u0305\u200c??\u200c????\u200c??\u02f3\u02df\u02f7??\u02f7\u200c????\u0315\u02f0\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u02f7\u0305\u0301\u0305\u02e7\u200c??\u02e7????\u200c??\u02df??\u02e8\u0302\u02df??\u200c??\u02df??\u02e9\u02df??\u200c??\u02df\u030f\u200c??\u0305\u200c????????\u0311\u02df\u02ef\u200c??\u0308\u02ef??\u200c??\u02df??\u030a??\u02df\u02eb\u200c??\u02df\u02ef\u030d\u02df\u02ef\u200c????\u030d\u02df??\u200c??\u02df??\u02e9\u0305\u200c??\u02e5\u0318\u02df\u02e5\u02df??\u0311??\u200c??\u02df??\u200c??\u02df\u02f0\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u02f6\u02d2??\u200c??\u02df????\u0315\u02d2\u0310\u02e8\u0306??\u02e6\u02f0\u02ef\u02f3\u200c??\u200c??\u02ea\u200c??\u200c????\u0315\u200c??\u200c??\u0311\u200c??\u200c??\u02ea\u200c??\u200c??\u200c??\u200c??\u02df??\u02df??\u200c??\u02df\u02e5\u02e8\u0306\u0301\u02f2??\u0317\u0314\u02ff\u02df\u030c\u02eb??\u200c??\u02df\u02e9??\u0306\u030d\u02f2??\u02f0??\u02e8\u02f0\u02ef\u02f7\u200c??\u200c??\u030f\u200c??\u200c??\u02e8\u02ef\u200c??\u200c??\u200c??\u200c??\u02df\u030a\u200c??\u200c??\u200c??\u200c??\u02df??\u030d\u200c??\u200c??\u02ff\u0308\u02ef\u0305\u200c??\u02df??\u02ea??\u030c\u02f3\u02e6\u200c??\u02df??????\u02f3??\u200c??\u02df\u0300??\u0306\u030d\u0305\u02d5\u0305??\u200c????????\u02df\u02ef\u200c??\u02e9\u02df??\u200c????\u0311\u030b\u02e5\u0316\u02eb\u02e8\u02e9\u02d5\u0301\u02e6\u0302\u02df??\u200c????\u0311\u02f5\u02e7\u02df\u02e7??\u200c??\u02df\u0305\u02f5\u0305??\u200c????\u0305\u02f1\u200c??\u02df\u02e5??\u02df\u02f8????\u0315\u200c??\u02df\u02f0\u02f8\u0318\u02df\u0315\u200c????\u0305??\u02f8??\u0315\u0311\u02f0????\u02f3\u02e5\u200c??\u200c??\u02ea\u200c??\u200c??\u200c??\u200c??\u200c??\u0311\u200c??\u200c??\u200c??\u200c??\u02df??\u0315\u200c??\u200c??\u200c??\u200c??\u02df??\u02e7??\u02e7\u200c??\u02df????\u0315\u02ef\u02e8\u0302\u02df\u0309\u200c??\u02df??\u02f0??\u02e6\u02f3??\u200c??\u02df\u0300??\u0305\u0305\u0305\u0308\u0305??\u200c??????\u0307\u02df\u02ef\u200c??\u02e9\u02df??\u200c????\u0311\u030b\u02e5\u0306\u02eb\u02ea\u02e9\u02d5\u02f3\u02f0??\u02e6\u02f3??\u200c??\u02df\u0300??\u0315\u02f6\u0302\u0318\u200c??\u200c????\u0305\u02f2??\u02f0????\u02f0\u02ef\u0301\u200c??\u200c??\u200c??\u200c??\u02df\u02f0\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u030d\u200c??\u200c??\u030f\u200c??\u200c????\u02f6\u02f3\u02e8\u200c??\u02df??\u02ea??\u02e7\u02f0??\u0307????\u02df\u02ef\u200c??\u0309\u0317\u02df\u02ef??\u0315\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d6\u02eb\u02f0??\u0307??\u0308\u02df\u02ef\u200c??\u0309\u0317????\u0313\u0315\u200c??\u02f5\u02f1\u0314\u0311??\u02f6\u02f3\u02e8\u200c??\u02df??\u0300\u0315\u02ef\u200c??\u02df\u030d\u02f0??\u0306\u02d7\u02f4\u0309\u0317??\u0302??\u02ef\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d3\u030c\u0301\u02e5??\u02eb\u02ef??\u02f0??????\u0315\u200c??\u02df????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u030d\u200c??\u200c??\u02e5\u0302\u02df\u0301\u200c??\u02df??\u0311??\u0306??\u02ed\u02e7\u02e7\u02f7??\u200c????\u02f2\u02e7??\u0304\u0314\u200c????\u02f8??\u0316\u02df\u0310\u0315\u0316\u0315\u0310??\u02ef\u02f8????\u0315\u200c??\u02df\u02f5\u02d6??\u200c??\u02df\u02e9??\u02f0??\u0305\u02e9\u02df\u02e7\u200c??\u02e8\u02eb\u0305\u02df??\u02f3\u200c????\u0309\u02f2????\u0313\u0308????\u02f7\u02f2??\u0316??\u02f2\u02f0\u02ef\u02f3\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????????\u0302\u02ef??\u200c????\u0311\u030f\u02df??????\u200c??\u02df??\u200c??\u200c??\u0310\u02ef\u200c??\u02df??\u0315\u200c??\u200c??\u02e8\u02df\u02ef\u200c??\u02ff\u0315\u200c??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c????\u02ef\u200c??\u02df??\u0301??\u200c??????\u02df\u02ef\u200c??\u02f7\u02ef\u200c??\u200c??\u200c??\u200c??\u02df\u02f2\u02eb\u02df\u02f3\u02df\u030c\u0305??\u200c??\u02df\u02e7\u200c??????????\u200c??\u02df????\u02eb\u02e9\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u0317\u0312\u02f5??\u02ef\u030a????\u02ef\u200c??\u02df??\u02ef??\u200c????\u030b\u200c??\u200c??\u200c??\u200c??\u02df\u02ed\u02f7\u200c??\u200c??\u02ea\u200c??\u200c????\u0305\u200c??\u02df\u02e6\u02f7\u200c??\u02df????\u200c??\u200c??\u02e7\u0315??\u200c????\u200c??\u200c??\u02df\u02d5\u02df\u02ef\u200c??\u02f4\u200c??\u200c??\u02e5\u02ef\u200c??\u200c??\u200c??\u200c??\u02df\u0311\u0315\u200c??\u02df\u02e8\u02eb\u200c??\u02df??\u02ef\u200c??\u200c????\u02df\u02eb\u200c??\u02df\u02f7\u030b\u02e5\u0306\u02eb\u02e8\u02e9\u02d4\u030d\u0305\u0301\u02df\u02e7\u200c????\u02df\u02e9\u02df\u0305\u200c??\u02e9??\u02ef\u200c??\u02df\u02f7??\u02e7\u02ea\u02d6\u200c??\u200c??\u0305\u030f\u02ef\u200c??\u02df??\u0305??\u200c??\u02df\u0310??\u0306??\u02e9\u02e7????\u200c??\u02df??\u02f2\u02e7\u02e7\u02f2\u0310\u200c????\u02f8??\u0315\u0309\u02d2\u0302\u0304??????\u0315\u02e7??\u0308\u030b\u0309\u02f6\u02f5\u02f8??\u0304\u0301\u02e5??\u02ea\u02e6\u0315\u0311\u02f2??\u02f2\u0306\u0306????????\u02df\u030d\u02d3\u030e????\u0307????\u200c??\u200c??\u02ef\u0315\u02f5??\u02f0\u02f7\u02f2??????\u02ea\u02e6??\u02f1\u02f2\u02e7\u02e7\u02df\u02f8\u200c????\u02f8??\u0315\u0309\u02d2??????????\u0315\u0305\u02f0??\u02df\u02e7\u02f0??\u02e8??\u02e6\u02f7\u02ef\u02f8??\u02df\u02ef\u200c??\u02e5\u0315\u030b\u02f0\u02f7\u0302\u02e9\u0301\u02e6\u0315\u02d6\u02f2??\u02f2\u0305\u0307??????????\u02ef\u02eb\u0305??\u0315\u02e7\u200c????????\u02df\u0305\u200c??\u02e9\u02df\u02eb\u200c????\u0311\u02f6\u02f5\u0304\u02d2????\u0315\u02f3\u0304??\u0306\u02eb\u02e8\u02ed\u02df\u02ea??????\u02d6\u02f0??\u02f1\u0315\u02e8\u02e6\u0316\u02df\u02f2??\u02f2\u0308????\u0314??????\u02ef\u0311\u0305\u02ff\u0315??\u200c??\u02e8\u02eb\u0305\u02d4\u0307\u030d\u200c????\u0309\u0310\u02d4\u02f0\u02f7??\u02e5\u02f0\u02eb\u02e8\u02ed??\u0314??????\u02d6\u02e8????\u0305??\u02e5\u02f0\u02eb\u02e8\u02ed\u02eb????????\u02d6\u02f0????\u0302\u02f7??\u0315\u02ef\u02f0??\u0316\u02d7\u02d6\u0309\u0317??\u0301\u02d2\u0315\u200c??\u02f5\u02f0\u02eb\u02e8\u02ed\u02ea\u0304??????\u02d6\u02f0??\u02df\u02e9\u02ed\u02ff\u02f0\u0302\u02f8??\u0305\u02e7\u02f5??\u0305??\u02f2??\u0306\u02f7\u02f2??\u02f2\u0307\u0306??\u0314??????\u02ef\u02f7\u0312????\u02d2\u02f2??\u02f2\u0307\u02f4??\u0314????\u02e6??\u0314????\u0305\u02e7??\u0308\u030b\u0309\u02f6\u02f5\u02f1\u0305??\u200c??\u02df\u0310????\u02eb\u02e6\u02e6\u0315\u030d\u02f2??\u02f2\u0306\u02d4??\u0314??????\u02ef\u0302??\u02df\u02ef\u200c??\u02e5\u0317\u030d\u200c????\u02eb\u0315??\u200c????\u02df\u0305\u200c??\u02df\u0315\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u0316??\u02df\u0305\u200c??????\u02eb??\u02e9??\u0315\u02f0????\u02f3\u02ef\u200c??\u200c??\u02f5\u0305??\u200c????\u030d??\u200c????\u200c??\u200c??\u02df\u0307\u0305??\u200c??\u02e6????\u200c????\u02e9\u02df\u02ef\u200c??\u0318\u0315\u200c??\u02df\u02ea\u0315??\u200c??????\u200c??\u200c??\u200c??\u200c??\u02df\u02e8\u0301??\u200c????\u0311\u200c??\u200c??\u02e5\u0315\u200c??\u02df\u02e5\u02eb??\u200c??\u02df\u02f4\u200c??\u200c??\u02f4\u0315\u200c??\u02df??\u02df??\u200c??\u02df\u02e5\u02e8\u0306??\u02eb\u02e6\u0317\u02d4\u02f2\u02e7??\u0312??\u200c????\u02f8??\u0315\u0311\u0310\u030e\u02e6\u02eb\u02e5\u200c??\u02df\u02e9??\u0305\u02e7\u0305\u0305\u0315\u02e7\u200c??????\u0310\u02df\u0305\u200c??\u02e9\u02df\u02f3\u200c????\u0311\u02f6??\u0305\u0311\u02f0????\u02d6\u02ed\u0309\u0317\u02df\u02f0\u02f0\u0315\u200c??\u02f5\u02f0\u02eb\u02ea\u02ed\u02e6\u030c??????\u02d6\u02f5??????\u02eb\u02e7??\u02d2??\u200c????\u02f2\u02e7??\u02f4\u0307\u200c????\u02f8??\u0315\u0311\u02d2\u02f7\u0314??????\u0315\u02e7\u0305\u02f8\u02ef??\u200c????\u02df\u02eb\u02df\u02ef\u200c??\u02e9\u02df\u02f3\u200c????\u0311\u02f6??\u0305??\u02f5??\u0315\u02ef\u02f0??\u02f1\u02df\u0306\u02df\u02ef\u200c??\u0309\u0317????\u02f7\u02ef\u200c??\u02f5\u02f0\u02eb\u02ea\u02ed??\u0304??????\u02d6??????????\u02e7??\u02d6??\u200c??\u02df\u0305\u0314\u0305\u02e7\u200c????\u0305\u02e5\u200c??\u02df\u0310??\u0315\u02f3\u02f0??\u02f0\u02f7\u02f5??\u0306\u02f7\u0305\u0314\u0315??\u200c????????\u02df\u02ef\u200c??\u02e9\u02df\u0315\u200c??\u02df\u02f7\u0305??\u02ef\u200c??\u02df????\u0313\u200c??\u200c??\u02e9??\u02f3\u200c??\u02df\u02f7\u02f2??\u0306??\u02eb\u02e6??\u030b\u02f2\u02e7??\u030c\u02f7\u200c????\u02f8??\u0315\u0311\u02d2\u02d4\u0314\u02d5????\u0316??\u02e5\u02ea??\u02f3\u02f0??????\u02f6\u02df\u02ef\u200c??\u0309\u0317??\u030f??\u200c??\u02df\u02f5\u02f0\u02eb\u02ea\u02ed??\u02e6??????\u02d6\u0304??\u02f1\u0314????\u030c\u02f3??\u200c??\u02df????\u030c\u02ef??\u200c??\u02df??\u02e7\u02eb\u02e7??\u200c??\u02df\u0305\u030b\u02df\u02eb\u200c????\u0305\u02e6\u200c??\u02df\u0310\u02e5\u02f7??\u02e7\u200c??\u02df??\u02e8\u02f0\u02f7\u02f1??\u02f0\u02d6\u0303\u02e6??\u02ef\u030d??\u02ef\u200c????\u030e\u0315\u030a??\u0316\u02e7??\u02e7\u02e7\u0309\u200c??\u200c??\u0305\u02d2\u0305\u200c??\u02df??\u0305??\u200c??\u02df\u02e5\u030c??\u02f3\u02f7??\u0305\u02f3\u0305\u0309\u0305??\u200c????????\u02df\u02ef\u200c??\u02e9\u02df??\u200c??\u02df\u02ff\u0301\u02e7\u02e9\u0315??\u200c??\u02df\u0305\u0307\u0315??\u200c????\u0305\u02e7\u200c??\u02df\u0310??\u0316\u02eb\u02ea\u02ed??????????\u02d6\u0304??\u02f0\u02eb\u02ea\u02ed??\u0300??????\u02d6\u02f0????\u0304\u02f5??\u0315\u02ef\u02ff??\u0315\u0311\u02d2\u02f1??\u02d5????\u0316??????\u0304\u02d2????\u0314\u02d2????\u0315\u0301\u02f0??\u0317??\u02e7\u02e5\u02f0\u02eb\u02ea\u02ed??\u02ea??????\u02d6\u0303\u02e9??\u02f7\u02e7??\u02d7\u02f7\u02eb\u02e6\u0315\u030d\u02f2??\u0318\u0305\u0307??\u0314??????\u02df\u0304??\u02df\u0306\u0300??\u02df\u02f0\u02eb\u02e7??\u02ef\u0305\u0312??????\u02f2??\u0318\u0305????\u0314??????\u02ef\u0315\u0305\u0314\u0305\u200c??\u02df\u02e8\u02eb\u0305\u030e\u0305\u200c??\u02df??\u0309\u0310\u02d4\u02ef\u02f8????\u0315\u200c??\u02df\u0302\u02df\u02e7\u200c??\u02df??\u02e9\u02df\u0301\u200c??\u02df\u030e\u0314??\u200c??\u02df??\u030c\u02ef??\u200c??\u02df\u0300??\u0315\u0309\u02f0??\u02f6\u02ef??\u200c??\u02df\u0300\u02e9\u0305\u02df\u02f2\u02eb\u02df\u02f3\u02df\u030a\u200c??\u200c??\u02df\u02ef\u200c??????????\u200c??\u02df????\u02eb??\u02e9\u0318\u02e7\u02e8\u02f0\u02ef\u02f7\u200c??\u200c??\u02f3\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02f3\u200c??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c????\u02ef??\u02ef\u200c????\u0307\u02f7\u02f0????\u02d7\u02e6\u0309\u0317\u02df\u0309\u02f4\u02ef\u200c??\u02f5\u02ef??\u0310\u0318\u0305??\u02ef??\u0305\u200c??\u02df\u0307\u0305\u02e6\u200c??\u02df\u02e9\u02e7\u02df??\u02e8\u02d2??\u02ef\u0304??????\u030d??\u0305\u200c????\u0307??\u02f5\u200c??\u200c??\u02e7??\u02eb\u200c??\u200c??\u030d??\u02ef\u200c??\u02e9\u0317\u02df\u030c\u02df\u0305\u200c??\u02e7??\u0315??\u200c??\u02df\u030d??\u0315\u200c????\u030c\u02eb\u02e8\u200c??\u02df\u02e9??\u0306\u0309??\u02e9\u02d2\u02d2\u02e5\u0302\u02f0\u02f3\u200c??\u02df????\u0300\u0315\u030d\u200c??\u02df\u030e????\u02ef\u200c??\u02df\u02ef\u0311\u02e6\u0302????\u200c??\u02df??\u030f??\u0318\u02df\u02e6\u02df??\u02e7??\u200c??\u02df??\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02f6\u02d2??\u200c??\u02df????\u0315\u030d\u0300??\u0315\u0305\u02f0????\u02f3\u02e7\u200c??\u200c??\u02e7\u02ef\u200c??\u02df??\u0315\u200c??\u02df????\u200c??\u200c??\u02f5\u0315\u200c??\u02df\u02ea\u0301\u200c??\u200c??\u200c??\u200c??\u02df\u02f5\u0315\u200c??\u02df\u02ea\u0301\u200c??\u200c??\u0305\u030c\u02e5\u02eb\u200c??????\u0309\u02df\u02ef\u200c??\u02e7??\u0305??\u200c??\u02df\u030d??\u02ef\u200c????\u0305\u02e7??\u02e9\u02df\u02f3\u200c??\u02df\u02f7\u02e9??\u0306\u02eb\u02e7\u02e9\u02d5\u0305\u02e5\u0302\u02f0??\u200c??\u02df??\u030d??\u200c??\u02df??\u0305\u0311\u02e6\u0302\u02df??\u200c????\u0311??\u02e9\u02df\u02eb\u200c??\u02df\u02f7\u02eb??\u02e6\u02f3??\u200c??\u02df\u0300\u02e9\u02df\u02e7\u200c??\u02df\u02f7????\u02ef\u0309\u0305\u030a\u02ef\u200c??\u02df\u02e8\u02eb\u0305\u0308\u0307\u0301\u200c????\u0309\u02f2????\u0306????????????\u02f6\u02f3??\u200c??\u02df\u0300\u02e7\u02e7\u02df??\u200c??\u02df\u0305\u0314\u0305??\u200c????\u0305\u02ef\u200c??\u02df\u02e5??\u0315\u02ef\u02f0??\u02e6\u02ef\u02f5\u200c??\u02df????\u02df\u02f3\u200c??\u02df\u02e7\u030d??\u0315\u200c????\u0307\u02df??\u02f1\u0303????\u02e5\u02f0\u030d\u030d??\u0305\u200c????\u0306\u0305\u02f3\u02e7\u02eb\u02d6\u200c??\u200c??\u0305\u02d4\u02ef\u200c??\u02df??\u0305\u02e9\u200c??\u02df\u0310??\u0315\u02f3\u02f0??\u0307??\u0318\u200c??\u200c??\u0309\u0317??\u0302??\u0315\u200c??\u02f5\u02f0\u02eb\u02e7\u02ed??\u02ea??????\u02d6\u02f0??\u0302\u02df??\u200c??\u02df??\u02e9\u02df\u0301\u200c??\u02df\u030d\u0305????\u030c\u0308\u02f0??\u02d6\u02ea\u02e5\u0307\u0305\u02e9\u200c??\u02df\u02e5\u02e5??\u0307????\u02ef\u200c??\u02df\u02f1\u02f3\u02f5??\u030d\u0315\u02f7\u200c??\u02df??\u030d\u0307\u0305\u02ea\u200c??\u02df\u02e9??\u0315\u02f7\u02f0??\u0307??\u030a\u200c??\u200c??\u0309\u0317\u02df\u02e6\u030f\u200c??\u02df\u02f5\u02f0\u02eb\u02e7\u02ed??????????\u02d6\u02f5\u02e9\u02df\u0315\u200c??\u02df\u030d\u030f??\u02df\u02f7\u200c??\u02df\u02f7\u030b\u02e9\u0305\u200c??\u02ed\u0305\u02e7\u030d??\u02ef\u200c????\u0307\u0310\u02ef??\u0315\u200c????\u0307\u02f7\u030f\u02df??\u02eb\u0315\u02df\u0305\u02df\u0302\u02df\u02ef\u200c????\u0305\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f4????\u200c??\u02df????\u02eb\u02e5\u02e9??\u02f7\u02f0????\u02f3??\u200c??\u200c????\u0315\u200c??\u02df????\u200c??\u02df??\u02d5\u200c??\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u200c????\u02d7\u200c??\u200c??\u0313\u0315\u200c??\u02df??\u02d6\u200c??\u02df??\u0311\u200c??\u200c??\u030d\u02ef\u200c??\u200c??\u200c??\u200c????\u02f7\u200c??\u200c??\u0314\u02ef\u200c??\u02df??\u02df\u02e7\u200c??\u02df\u02e5\u02e8\u0306\u02f7\u02f2????\u0313\u02d4??\u0305\u030d\u02f0??\u02f1??\u02ff\u02df\u02ef\u200c??\u0309\u0317??\u02d5\u02eb\u200c??\u02df\u02f5\u02f0\u02eb??\u02e9\u02d4\u02f7??\u02df????\u0304\u02ff??\u0309\u02e5\u02f7\u02f3\u02f3??\u200c??\u200c????\u0305\u200c??\u02df??\u02f7\u200c??\u200c??\u02f0??\u02f0\u02d7\u02e7\u0309\u0317??\u0307??\u200c??\u02df\u02f5\u02f0\u02eb??\u02ed\u02e6????????\u02d6\u0304??\u0317\u0314??\u02e6\u0307\u0314\u0317\u02e6\u0315\u0311\u02ea\u02e5\u0306\u02eb??\u02ed\u02e5????????\u02d6??\u0308\u02df\u02e7\u200c????\u0312\u0314??\u0305\u200c????\u0305\u0311\u02ff??\u0315\u02ef\u02d2\u02f5\u0304??????\u0315\u02e9\u02eb\u02df\u0305\u200c??\u02e5??\u02d6??\u200c??\u02df\u02e9??\u0316\u030d\u02f2????\u0306????????????\u0306\u0302\u02f7??\u0305\u02ef\u030a\u02f5\u0305\u0315??????\u0305\u02eb??\u02ef\u02f7\u0305\u0304\u02df??\u200c??\u02e8\u02eb\u0305??\u0302\u02f3\u200c????\u0309\u02f2????\u0305\u0309????????????\u0306\u0302\u02ea\u02ef\u0305\u0301??\u0315\u02ef\u02d2??????????\u0316??\u02e5\u02e6\u0316\u030b\u02f2\u02e7??\u02ef\u02e9\u200c????\u02f8\u02e9??\u0315\u02e6\u02e9\u0306??\u02e5\u02e7\u02e9\u02df??\u200c????\u02f2\u02e7??\u02f2??\u200c????\u02f8??\u0315\u02ef\u02d2\u02d6??\u02d5????\u0315\u200c??\u02df??\u02eb\u0315\u02df\u0315??\u0317\u200c??\u200c????\u0315\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f3\u02f5??\u0315\u02ef\u02f0????\u02f3\u02e8\u200c??\u200c??\u200c??\u200c??\u02df??\u02f3\u200c??\u200c??\u0310\u200c??\u200c??\u02e7\u200c??\u200c????\u200c??\u200c??\u02df\u030a\u200c??\u200c????\u0315\u200c??\u02df??\u0301\u200c??\u200c??\u02e6\u200c??\u200c????\u0305\u030d\u0303??\u0315\u02ef\u0310\u0318\u0305\u02ef??\u02f7\u02f0\u02d6\u02d6\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c??\u02e5\u0306\u02eb??\u02e9\u02d5\u0305\u0300\u02e9??\u0309\u02f7??\u0315\u02ef\u0310\u0311\u02df\u02e7\u030d??\u200c??\u02df??\u0305\u02f7\u02f6\u02f5\u02df\u030d\u0305\u02d6\u02df\u0301\u200c??\u02df\u0311\u02f7??????\u02d6\u02df\u02ef\u200c????\u0316\u030e\u0300????\u0309\u0317??\u0316????\u02e6\u0317\u02f1\u02f2\u02e7\u02ed??\u0313\u200c????\u02f8??\u0315\u02ef\u0310\u0305\u0316\u02d2\u0310??\u02f1\u030d\u02f5??\u0315\u0301\u02f0????\u02f3??\u200c??\u200c??\u200c??\u200c??\u200c??\u0301\u200c??\u200c??\u02e6\u200c??\u200c????\u0305\u200c??\u200c??\u200c??\u200c????\u02ef??\u02ef\u200c????\u0307\u02f7\u030f\u02e9\u02d2\u030d\u200c????\u02eb\u0315??\u02df??\u0301\u02df\u0305\u200c????\u200c??\u02df??\u02f6\u02d2??\u200c??\u02df????\u0315\u02d7??\u02df\u0305\u200c??????\u02eb\u02ef\u02e9??\u030d\u02f0??\u0309\u02f3\u02f1\u200c??\u200c??\u02d7\u0305??\u200c??\u02df\u0311\u200c??\u02df??\u0318\u02df\u02ef\u200c??\u030e\u02ef??\u200c??\u02e5\u02ef\u200c??\u02df??\u02f6\u200c??\u200c??\u0311\u200c??\u200c????\u02ef\u200c??\u02df??\u02d7\u200c??\u200c??\u02f0\u02ef??\u200c??????\u200c??\u200c??\u200c??\u200c??\u02df\u030f\u200c??\u200c??\u02eb\u02d6??\u200c??????\u200c??\u200c??\u02f8\u200c??\u200c??????\u200c??\u02df??\u030d\u02df\u02ef\u200c????\u02df\u030d\u200c??\u02df\u02f7\u030b??\u0316\u02eb\u02ed\u02e9\u02d4\u02f7??\u02e7\u02df\u030e\u02e8\u02d2??\u02f0\u0306??\u02f5??\u02e9\u0304\u0305\u02f7\u200c??\u02df\u02ef\u02eb??\u02e6\u02ef??\u200c??\u02df\u0300\u02e8\u02ef\u02ff\u02f2??\u0315\u02f7\u02f7\u02f5\u02e8\u02eb\u02e6\u02f7\u02ef\u0311\u0302??\u0315\u02d2\u02d2\u0304\u0304????????\u02d2\u02e6\u200c??\u02df??\u0302\u02df\u02ef\u200c????\u0311\u02e6\u030b\u0307\u02f3??\u02ea\u02df\u0309\u0304????\u02eb\u02ed\u02ed\u02e5\u02f2??????\u02d6\u02f0??\u0317??\u02d7\u02df\u02ef\u200c??\u0309\u0317\u02df\u0306\u02d3\u0315\u200c??\u02f5\u02f1\u0314\u030e??\u02f6\u02f3\u0305\u200c??\u02df??\u02e9\u0305\u0306??\u02df\u0315\u200c??\u02e5??\u02d2??\u200c??\u02df??\u0302\u02df\u02eb\u200c????\u0311\u02e5??\u0315\u0315\u02f2??\u0316\u02eb\u02e9\u02e6\u0315\u02d2\u02f2??\u0308\u0305\u0312????????\u0301\u0316??\u200c??\u02df\u030d\u02f2??????\u02e9\u0302\u02ef\u02eb\u200c????\u0311\u02f0??\u02e8\u02eb\u02f2??\u02f0??\u02e9\u0302\u02df\u02eb\u200c????\u0311\u02f0????\u0302\u02f7\u0309\u0316????\u02f7\u02f0\u02eb\u02e5\u02e6??\u02eb\u02ed\u02ed\u02df\u02e6??????\u02d6\u02f0????\u030a\u02f7??\u0315\u0315\u02f0??\u0306\u02d6\u0304\u02f6\u0316??\u02e5\u02e7\u02eb????\u200c????\u0304??????\u0305??\u0315\u0301\u02f0????\u02df\u0303\u02df\u02ef\u200c??\u0309\u0317??\u02f3??\u0315\u200c??\u02f5\u02f0\u02eb\u02ed\u02ed??\u02f2??????\u02d6\u02f0??\u0306\u02d6\u0305\u02f6\u0317\u0315\u02f4??\u02f0\u02df\u0305\u02f2\u0305??\u200c??\u02e8\u02eb\u0305\u0303????\u200c????\u0309\u02f2??\u0308\u0307\u02d2??\u0314????\u02e6\u0315\u0309\u0310\u02d7\u02f0??\u02e6\u02e6\u0315\u02d7\u0307??\u02ef\u030e??\u02df\u0315\u200c??\u02e5\u0316??\u02eb\u02e8\u02f0\u0302\u02f7??\u0315\u0317\u02f2??\u02ef\u02f4??\u02df\u0305\u200c????????\u02f5\u200c??\u200c??\u0304\u0305\u02e7\u200c??\u02df\u02ef\u0305\u030a\u0305\u200c??\u02df\u02e8????\u02df\u0305\u200c????????\u02ed\u200c??\u200c??\u0309??\u02df\u0304\u0304????\u0302\u02f7\u02f5\u02df\u02f2??\u0316\u02d6\u02e8??\u0315\u02d2\u02d2\u0300??\u02d5????\u0316??\u02ea\u0302\u02ef\u02eb\u200c????\u0313\u02ed\u02ff\u02f0\u02eb\u02e7??\u0316\u02eb\u02e8??\u02ef\u02d6\u0305\u02e5\u02ef??\u200c??\u02e8\u02eb\u0305\u0303\u02f5\u02eb\u200c????\u0309\u02f2??\u0308\u0306\u02e8??\u0314??????\u02ef\u02f0??\u02e7\u02ef\u200c??\u02df\u02f0??????\u02ef\u030e??\u02df\u0315\u200c??\u02e5\u0316??\u02eb??\u02ef\u0302\u02f7??\u02ef\u030a\u02f8\u0309????\u02f0????\u02ef??\u200c??\u02df\u0300??\u02ef\u0309\u02f0????\u0305\u0304??\u02f4\u0305\u02f0??????\u02f2\u02f7\u0302??\u0314??\u0305\u200c????\u0307\u02f7\u02f8??\u0315\u02d2\u02d2????\u02d5????\u0316??\u02e8????\u0305\u02f2??\u02f0\u0305\u02f2??\u0308\u0308????\u0304??????\u02ef\u0309\u02f0??\u0318??\u02e8\u02e6\u0315??\u02f2??\u0308\u0308\u0314??\u0304??????\u02f0\u02df\u0304??\u02d3\u02eb\u0305\u02f5\u02ff\u02e7\u200c????\u0309\u0310\u02d5??????\u0302\u02f1??\u200c??\u02df??\u0314??\u0315\u200c????\u0305??????\u0315\u200c????\u02e6\u02ef??\u200c??\u02df\u0300??\u0315\u030a??\u02e7\u200c??\u200c??\u02ff\u02e7\u02f5??\u0315\u02d2\u02d2\u0313????????\u0315\u030a??\u02e7\u200c??\u200c??\u02f1\u030d\u02f2\u02eb\u02df\u02eb\u02df\u02d3\u0315\u200c??\u200c??\u0309\u200c??????????\u200c??\u02df????\u02eb\u02e5\u02e9\u0318\u02d2\u02f0??\u02f3\u02f3\u02ea\u200c??\u200c????\u0315\u200c??\u02df\u02e9??\u200c??\u200c??\u0304\u200c??\u200c??\u030d\u0315\u200c??\u02df??\u02f3\u200c??\u02df??\u0306\u200c??\u200c??\u200c??\u200c??\u02df??\u02f3\u200c??\u02df??\u02e6\u200c??\u200c??\u02f5\u02ef\u200c??\u02df\u02e5\u02d2\u200c??\u02df??\u02ef??\u0315\u200c????\u0307\u02f7\u02f5??\u0315\u02f3\u0310\u0315\u0306\u02f7\u02e9??\u02ef\u02f7\u0305\u0316\u02ef\u200c??\u02df\u02e8\u02eb\u0305\u0318\u02d7\u030d\u200c????\u0309\u02f2??\u02f1\u0313\u0313\u02df\u0315\u02f0\u0306\u02e6\u0317\u02f0\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u02f3\u200c??\u200c??\u02ff??\u0315\u02f3\u0310\u030b????\u02e5\u02e7??\u02eb\u200c??\u02df??\u02f2\u02e7\u02e8\u0302\u0317\u200c????\u02f8\u02e9??\u0315\u02f6??\u0316??\u02e5\u02e6????\u02f2\u02e7\u02e8\u02e9\u02f2\u200c????\u02f8??\u0315\u02f3\u02d2\u0302????????\u0315\u02e9\u02eb\u02df\u0305\u200c??\u02e5??\u02d6\u02f3\u200c??\u02df\u02e9??\u0316\u02d6\u02e9??\u0315\u02f3\u02d2\u02f6????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0304\u02e7\u02df\u0315\u0300??\u02f0\u02d2\u02e7\u02e5\u030a\u0311\u02e8\u02f5\u02f2\u02e7\u02f4??\u02ef\u02f7\u0305??\u02ef??\u200c??\u02e8\u02eb\u0305??\u02eb\u200c??\u02df??\u0309\u02f2??\u02f2\u0305\u02d3??????????\u02ef\u02f7\u0304\u0303\u02f8\u02eb\u0305??\u0302\u0305\u200c????\u0309\u0310\u02d5\u02df\u0301\u030f\u02e5??\u02eb??\u02ed??\u02ea??????\u02d6\u02df??\u0318\u02df??\u02df??\u0311??\u200c??\u02df\u02e9\u200c??\u02df\u02f0\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u030c\u02d2??\u200c??\u02df????\u0315\u0301\u0310\u02f2??????\u02f0\u02ef\u0315\u200c??\u02df????\u200c??\u200c??\u0314\u02ef\u200c??\u02df??\u02d2\u200c??\u02df??\u0307\u200c??\u200c????\u02ef\u200c??\u02df??\u0309\u200c??\u02df????\u200c??\u200c??\u0306\u0305\u200c??\u02df\u02e7\u0311\u200c??\u02df??\u02d7\u200c??\u200c??\u0301\u200c??\u200c??\u200c??\u200c??\u02df??\u02ef??\u200c??\u02df??\u0307\u02f7\u02f0??\u0306\u02d7\u02eb\u0309\u0317??\u030c\u0317\u0315\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d5\u02ef\u02f5??\u0306??\u02e5\u02e7\u02e6\u02d2??\u200c????\u02f2\u02e7??\u02f0\u0308\u200c????\u02f8??\u0315\u02f3\u0310\u030d\u02df\u02d2????\u0305\u02f0\u0306\u02e6\u0318??\u02f8??\u030b????\u02df\u02ef\u200c??\u02df??\u02e7\u200c??\u200c??\u02f0??\u0306\u02d6??\u0309\u0317??\u02f2\u02e9\u200c??\u02df\u02f5\u02f0\u02eb??\u02ed\u02e6\u0314??????\u02d6\u02f0??\u0317\u02df\u02f0\u02df\u02ef\u200c??\u0309\u0317??\u0317\u02e5\u02ef\u200c??\u02f5\u02f1\u0314\u030e??\u0305\u02ea????\u02ef\u02d2\u200c??\u02df??\u02e7??\u0316\u02f7\u02f2??\u02f2\u0306\u02f8????????\u02df\u0305\u02eb????\u02f1\u0305\u02f4\u200c??\u02df\u02e9??\u0316\u02f7\u02f2??\u02f2\u0306\u02e6??????????\u0306\u0302\u02f7??\u0305\u02d2??\u02e8\u02f4\u030d????\u0305\u02ef\u02e8\u02f5\u02df??\u02f0??\u0316\u02d7\u02f4\u0309\u0317??\u0300??\u02ef\u200c??\u02f5\u02f0\u02eb??\u02ed??\u0304??????\u02d6\u02e8\u02e5????\u0312??\u02f0\u02d6\u02e8??\u0315\u02f3\u02d2\u02e5\u0304??????\u0316??\u02e6\u02e6??\u02d4\u02f2\u02e7\u02e8\u02d7??\u200c????\u02f8\u02e9??\u0315\u02e6\u02e9\u0306??\u02e6\u02e7\u02ed\u0301\u200c??\u02df??\u02f2\u02e7\u02ea\u030f??\u200c????\u02f8??\u0315\u02f3\u02d2\u02d7\u0304\u02d5????\u0315\u02df\u02f2\u02eb\u02df\u0301\u02df\u0305\u0315??\u200c??\u02df\u0311\u200c????????\u02df\u0305\u200c??????\u02eb??\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u0307\u0312\u02e9??\u02ef\u02f0????\u0305\u200c??\u02df??\u02e7\u200c??\u02df??\u0303\u200c??\u200c??\u030c\u02ef\u200c??\u02df\u02e5\u02f3\u200c??\u02df????\u200c??\u200c??\u02d3\u0305\u200c??\u02df??\u0315??\u200c????\u02ef\u200c??\u200c????\u0315\u200c??\u02df??\u0315??\u200c??\u02df\u02ff\u02df\u02ef\u200c??\u200c??\u200c??\u02df??\u0315\u200c??\u02df????\u200c??\u200c????\u02df??\u200c??\u02df\u02f7\u030b\u02e6\u0306\u02eb??\u02e9\u02d5\u02f7\u02f5??\u0306\u02f7\u02f2????\u0313\u0314\u02df\u0315\u02f0\u0306\u02e6??\u030e\u02f8??\u030b????\u02df\u0315\u200c??\u02df??\u02e7\u200c??\u200c??\u0304\u200c??\u200c??\u02e7\u0305\u200c??\u02df??????\u02e7??\u0301\u200c??\u02df??\u02f2\u02e7\u02eb\u030f\u0315\u200c????\u02f8??\u0315\u02ef\u0310\u0306????\u02e5\u02e6??\u02f1\u02f2\u02e7??\u0303\u030b\u200c????\u02f8\u02e9??\u02d6\u02ff\u02e9??\u0315\u02f7\u02e9??\u0309\u0304\u02e6\u02df\u0311\u02f0??\u0306\u02d6\u0308\u0309\u0317????\u0304\u02ef\u200c??\u02f5\u02f0\u02eb??\u02ed??\u0318??????\u02d6??\u02e9??\u02f7\u200c??\u02df\u030d\u02ea??\u02ef\u02f3\u0305\u0311\u0305??\u200c??\u02e8\u02eb\u0305\u030c\u030c\u200c??\u02df??\u0309\u02f2????\u0306\u02df????????\u02df\u0307\u0305\u02f6\u200c??\u02df\u02e9??\u0316????\u02e7??\u02df??\u200c????\u02f2\u02e7??\u02e7\u0311\u200c????\u02f8??\u0315\u02ef\u02d2\u02e8????????\u0315\u02e7\u030d\u02e5\u200c??\u02df??\u0305\u0311\u02f0??\u02f1\u02df\u02f6\u02df\u02ef\u200c??\u0309\u0317??\u0314\u0300\u0305\u200c??\u0304\u0305\u02e7\u200c??\u02df\u02ef\u0305\u02f4\u0315\u02e7\u200c??\u02e6\u02d2??\u200c??\u02df??\u02e7??\u0301??\u200c????\u02f2\u0304\u0305\u02e7\u200c??\u02df\u02ef\u0304\u02e6\u02d3??\u0305\u02e7\u02ea\u02e7\u200c??\u02df??\u0304\u030c\u02f4\u0309\u02f2????\u0308\u0308??\u0314??????\u0306\u0302\u02f7??\u0305\u02eb\u030a\u02f5\u0305\u0315??????\u0305\u02eb??\u02ef\u02f7\u0304\u02f4\u02f8\u02eb\u0305\u0309\u0306\u02f3\u200c????\u0309\u02f2????\u0308????\u0314????????\u0306\u0302\u02ea\u02ef\u0309\u0304??\u0306\u02eb??\u02ed\u02ea\u0304??????\u02d6\u02f0??\u02f1\u02df??\u02df\u0305\u200c??\u0309\u0317??\u030c\u02f3\u02ef\u200c??\u02f5\u02f1\u0314\u030e??\u0317\u030d\u02f0??\u02f1??\u02f6\u200c??\u200c??\u0309\u0316????\u02e7??\u0301\u200c??\u02df??\u02f2\u02f5\u02f0\u02eb??\u02ed\u02e7????????\u02d6\u02df??\u0318\u02df\u02e5\u02df??\u0311\u200c??\u200c??\u02eb\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02e6\u02d2??\u200c??\u02df????\u0315\u02f3\u0300??\u02ef\u030a????\u0305\u200c??\u02df\u02e8\u02e7\u200c??\u02df??\u0313\u200c??\u200c??\u02ea\u0305\u200c??\u02df\u02e7\u0311\u200c??\u02df??\u02e7\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02ea\u200c??\u200c??\u0309\u0305\u200c??\u02df??\u0315\u200c??\u200c??\u02f5??\u0306????\u02e6\u0318??\u02f2\u02e7\u02e5\u0308\u02ed\u200c????????\u200c??\u02df????\u02df??\u02df\u02ef\u200c??\u0304\u0305\u02ef\u200c??\u02df\u02ef\u0305??\u02df??\u200c??\u02e8\u02eb??\u02f5\u02f1??\u0312\u200c??\u200c??\u02f6\u02d3??\u02f8??\u02f1\u0313\u0309??\u02ef\u02d2??\u02f7\u02f0\u02d6\u030c\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c??\u02e5\u0305??\u0310\u0308\u0306\u02d6\u02e8\u02e9??\u0309\u02f0??\u02f1??\u02e7\u02df\u02ef\u200c??\u0309\u0317\u02df\u02d5\u02f0\u02ef\u200c??\u02f5\u02ef??\u02d2\u0302\u0314??????\u0315\u02e9\u02eb\u02df\u0305\u200c??\u02e5\u0315\u02eb??\u0308\u02df\u02f3\u200c????\u0312\u0314\u02e5\u02ef\u200c????\u0305\u02f7\u02f6\u02f5\u02df\u030d\u0305\u0309\u200c??\u200c??\u02df\u0311\u02e6\u02e8\u02f4\u030d\u02e6\u02f5??\u0306\u0302\u02ea\u02df\u0301\u02f8??\u02f2\u0306\u02e9??????????\u0307\u0314??\u02e5\u02df??\u02d2\u02ef????????\u0317\u030d\u02f8??\u0315\u0301\u02f0????\u02f3??\u200c??\u200c????\u0315\u200c??\u200c??\u0301\u200c??\u200c??\u02e6\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02ef??\u0305\u200c????\u0307\u02f7\u030f\u02ed\u02e6\u02e6??????\u02d6\u02df??\u0318\u02df??\u02df\u02ea??\u200c??\u200c????\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2????\u0312\u02df??\u02f3\u02f3\u02eb\u200c??\u200c????\u200c??\u200c????\u02f3\u200c??\u02df??\u02ea\u200c??\u200c??\u02f6\u0315\u200c??\u02df??\u02d6\u200c??\u200c??\u200c??\u200c??\u02df\u02f1\u0315\u200c??\u02df??\u0315\u200c??\u200c??\u02e9\u200c??\u200c??\u02f0\u0315\u200c??\u02df\u02e6\u200c??\u200c??????\u200c??\u200c????\u02df\u02d6\u200c??\u02df\u02f7\u030b\u02e6\u0305??\u0310\u0315??\u02f7\u02e9??\u0305??\u0310\u0313\u0305\u02e7??\u02f7\u02f0\u02d7\u02d5\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c????\u0315??\u0310\u030e\u02f0????\u02e7??\u02d2??\u200c????\u02f2\u02e7??\u0306\u0307\u200c????\u02f8\u02e9????\u02f3??\u0316\u02d6\u02e8??\u02f1\u0313\u02ed\u02e9??\u030d\u200c??\u02df\u030d\u02ea\u02e6\u0315\u0309??\u02e9\u02d2\u02eb\u02e5????\u0305\u02e9\u02df\u0307\u02f4\u02ff\u02df\u030a\u0305\u02f7\u02f6\u02f1\u0315\u02e6\u02e5\u02ef??\u02d2\u0300????????\u0316\u02d6\u02e9\u02e9??\u02f7\u02f0????\u02d7\u0318\u0309\u0316????\u02e6??\u02ed\u02f2\u02f5\u02ef??\u02d2\u02f5\u0314??????\u0315\u0302????\u0305\u200c??\u02df\u02f1\u030d\u02f5??\u02f2\u0306\u02eb????????\u200c??\u200c????\u0318\u02df\u02e5\u02df??\u02f7??\u200c??\u02df\u02ed\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02f6\u02d2??\u200c??\u02df????\u0315\u02f7\u0310\u02ef\u0316????\u02f0\u02ef\u0315\u200c??\u02df??\u02d4\u200c??\u200c??\u0305\u200c??\u200c????\u02f7\u200c??\u200c??\u200c??\u200c??\u02df\u0311\u0315\u200c??\u02df\u02ea\u02eb\u200c??\u02df????\u200c??\u200c??\u0300\u200c??\u200c????\u200c??\u200c??\u02df\u02eb\u200c??\u200c??\u02e7\u200c??\u200c??\u02ea\u02eb\u200c??\u02df??\u02ef??\u200c??\u02df??\u0307\u02f7\u0304??\u02f0\u02eb??\u02e9\u02d5??\u02f5??\u0306????\u02e7??????\u200c????\u02f2\u02e7\u02ea\u02e7\u02f8\u200c????\u02f8??\u0315\u02ef\u0310\u030f\u02ef\u02ef??\u02f7\u02f0\u02d6??\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c??\u02f1\u200c??\u200c????\u02ef\u02f7\u0305??\u0305??\u200c??\u02e8\u02eb\u0305\u030b??\u0309\u200c????\u0309\u02f2????\u0313\u02e5\u02e6\u0307\u0314\u02d3??\u02df\u0311\u0302??\u0315\u02ef\u02d2\u0303\u0304??????\u0315\u02e7\u030d\u02e5\u0315\u200c????\u0305\u0311\u02f0??\u02f1??\u02ff\u200c??\u200c??\u0309\u0317??\u02d4\u0301\u0315\u200c??\u02f5\u02f0\u02eb??\u02ed??????????\u02d6\u02e5????\u0305\u02e9\u02df\u0317\u02f4\u02ff??\u02df\u02eb\u02e7\u02f5\u02df\u0315\u02f6??\u0315\u02ef\u02d2\u02f1\u0304??????\u0315\u0305\u02f7\u02f6\u02f6\u02d2??\u200c??\u02df??\u02e7\u02e8\u0315\u200c??\u02df????\u02df\u0305\u200c????????\u0301\u200c??\u200c??\u0309??\u02d2??\u200c??\u02df??\u02e6??\u02e5\u02f2\u02f7\u02f0\u02d7\u0316\u02f6\u02d3??\u0312????\u030d\u02f2????\u0305\u02ff????????\u02e6\u0315\u030d\u0310\u02d7\u02ef\u0302????\u0305\u200c??\u02df\u02f1\u030d\u02f0??\u0307??\u0313\u02df\u02ef\u200c??\u0309\u0317??????\u0315\u200c??\u02f5\u02f0\u02eb??\u02ed??\u0310??????\u02d6\u200c????\u02eb\u0315\u02df\u0315\u02df??\u02df\u02ef\u200c????\u0315\u200c????\u02f6\u02d2??\u200c??\u02df????\u02f6\u02d2??\u200c??\u02df????\u0315\u02ef\u02f8??\u02df\u0306????\u200c??\u200c??\u02e6\u0301\u200c??\u200c??\u0314\u200c??\u200c??\u02ea\u0315\u200c??\u200c??\u200c??\u200c????\u0307\u200c??\u200c??\u0316\u02ef\u200c??\u02df\u02e9\u02e7\u200c??\u02df??\u02f5\u200c??\u200c??\u02e6\u0317\u02ed??\u02df\u02ef\u200c??\u02df\u02f1\u02f6\u02ef??\u200c??\u02df????\u0305??\u200c??\u02df\u02e9\u0305\u02df\u02f7\u200c??\u02df\u02ef\u0303\u0308\u02ef??\u200c??\u02df??\u02e9??\u030c\u02f3??\u200c??\u02df\u0300\u02e6????\u02f2\u02e6\u200c??\u02df\u030c\u02f0\u0301\u02eb\u02e9\u02d4\u0311\u02e5\u0302\u02ef\u02eb\u200c????\u0311\u02f8\u02e7\u02ea\u02d6\u0308\u200c????\u0302??\u030c\u02f3??\u200c??\u02df\u0300\u02e5\u0317\u02df\u0318??\u0315\u200c??\u030c\u02ef\u0309\u0304\u02e6\u02d3\u02eb\u0305\u02e8\u02d5\u02eb\u200c????\u0309\u02eb\u02e9\u02d2\u02ef\u02e5\u0302\u02df\u02eb\u200c????\u0311\u02f5\u02e7\u02ea\u02ef??\u200c????\u0302??\u030c\u02f3??\u200c??\u02df\u0300??\u0317\u02df\u02f5\u02ed\u0315\u200c??\u030c\u02f0\u02f7\u02eb\u02ed\u02e5????????\u02d6\u02e5\u0302\u02ef\u02eb\u200c????\u0311\u0302\u02e7\u02e6\u02e7??\u200c????\u0302??\u030c\u02ef??\u200c??\u02df\u0300\u02e5\u0307????\u02ed\u0305\u200c??\u030c\u02f0????\u02e6??\u0317\u02f2\u02e7??\u02ea\u02f7\u200c????\u02f8????\u0305\u02d2??????????\u030c\u02f3??\u200c??\u02df\u0300\u02e5????\u0312\u02df\u02ef\u200c??\u030c\u02f0\u030b??\u02e7\u200c??\u200c??\u02f7\u02df\u02e6\u200c??\u02df????\u030c\u02f3??\u200c??\u02df\u0300\u0305\u02df\u02f3\u200c??\u02df\u02ef\u030f??????\u200c??\u02df\u02f7\u030b\u02e9\u0305\u200c????\u0318\u02df??\u02df??\u02f7\u200c??\u200c??\u02ef\u200c??\u02df\u02f0\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u030c\u02d2??\u200c??\u02df????\u0315\u0301\u0310??\u0306????\u02f0\u02ef\u0311\u200c??\u200c??\u0311\u200c??\u200c??\u0300\u0305\u200c??\u02df??\u02d2\u200c??\u200c??\u02f1\u200c??\u200c????\u0305\u200c??\u02df\u02e5\u02e7\u200c??\u200c??\u200c??\u200c??\u02df\u030c\u200c??\u200c??\u02df\u0311\u200c??\u02df????\u200c??\u200c??\u030c\u0305\u200c??\u02df??\u02df\u02f1\u200c??\u02df\u02e5\u02e8\u0306\u02d2\u02f2??\u02f1\u0314????\u0305\u030d\u02f8??\u0315\u02f3\u0310\u0313\u0315\u02ef??\u02f7\u02f0\u02d7\u02f7\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c????\u0306\u02eb??\u02e9\u02d4\u02f3\u0304??\u02f1\u0314\u02d2\u02e6\u0315??\u02ea??\u02ef\u02f7\u0305\u02f2\u0315??\u200c??\u02e8\u02eb\u0305????\u02d2\u200c????\u0309\u02f2??\u02f1\u0313\u02eb\u02df\u0305\u02eb\u030d\u02e6\u200c??\u02df??\u0305\u0311\u02f0??\u0307??\u02ea\u200c??\u200c??\u0309\u0317??\u02ff\u02d3\u02ef\u200c??\u02f5\u02f0\u02eb??\u02ed\u02e5????????\u02d6\u02e5????\u0305\u02e9\u02e7??\u02e7??\u200c??\u02df\u02eb\u02e7\u02e9\u0315\u200c??\u200c????\u02e7\u02e9\u0309??\u200c??\u02df\u02e7\u02e5??\u0311\u02e8\u02f5\u02f2\u02e7\u02f1??\u02ef\u0301\u0304\u0300\u02f8\u02eb\u0305\u02f6\u0303\u0309\u200c????\u0309\u02f2??\u02f2\u0306????????????\u02ef\u02f7\u0305\u02e6\u0305??\u200c??\u02e8\u02eb\u0305\u030b\u0315\u0301\u200c????\u0309\u0310\u02d4\u02ef\u0301\u030f??\u02ef\u02f7\u0305??\u0315??\u200c??\u02e8\u02eb\u0305\u0315??\u0309\u200c????\u0309\u02f2??\u02f2\u0305\u02ff????????\u200c??\u02df\u02f2\u02eb\u02df\u02ef\u02df\u02d4\u02ef\u200c??\u02df????\u200c????????\u02df\u0305\u200c??????\u02eb\u02e5\u02e9??\u02e7\u02f0??\u02f3\u02f3\u02eb\u200c??\u200c??\u0302\u200c??\u200c??\u02e9??\u200c??\u200c??\u02ea\u200c??\u200c??\u02ff\u0305\u200c??\u02df\u02e8\u02e7\u200c??\u02df??\u02ef\u200c??\u200c??\u0302\u200c??\u200c????\u02e7\u200c??\u200c??\u200c??\u200c??\u02df\u02ed\u02ef\u200c??\u02df\u02e6\u02ef\u200c??\u02df??\u02ff\u200c??\u200c??????\u02eb\u200c??\u02df\u02f7\u030b\u02e5??\u02eb??\u02e9\u02d5\u02d2\u02f5??\u0306??\u02f2??\u02f1\u0313????\u02ef\u02f0\u0306\u02e6\u0316\u02f8\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u02f7\u200c??\u200c??\u0304??\u02f0\u02eb??\u02e9\u02d4\u02df\u02f0??\u0307\u02df\u0306\u02df\u02ef\u200c??\u0309\u0317????\u02f7\u02ef\u200c??\u02f5\u02f1\u0314\u0311??\u02df\u0311\u02f0??\u0307??\u02f6\u02df\u02ef\u200c??\u0309\u0317??\u0304??\u200c??\u02df\u02f5\u02f0\u02eb??\u02ed\u02e6\u030c??????\u02d6??\u0308\u02df\u02f3\u200c????\u0311??\u0308\u02df\u02e7\u200c????\u0312\u0314\u02e6\u02ef\u200c????\u0305\u0311\u02f8??\u0315\u02f3\u02d2\u02f6????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0305\u030f\u0305??\u200c??\u02df??\u0305??\u02ef\u02e7\u200c??\u02df\u0315\u0305\u02ff\u0305\u02ef\u200c??\u02df\u0305\u02e8\u02e5??\u030e\u02f8\u02eb\u02df\u0305\u02ff??\u0315\u02f3\u02d2\u02ed????????\u0316\u02d6\u02ea\u02e9??\u02f3\u0302??\u0315\u02f3\u02d2\u02ea????????\u0315\u0302??\u02df\u02ef\u200c??\u02e5\u0317\u030d\u0302??\u0315\u02f3\u02d2\u02e7????????\u0315\u200c??\u02df??\u02eb\u0315\u02df\u0305??\u02f1\u200c??\u200c????\u0305\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f0????\u200c??\u02df????\u02eb??\u02e9????\u02e8\u02f0\u02ef\u0315\u200c??\u02df??\u02d2\u200c??\u200c????\u0315\u200c??\u02df??\u02e7\u200c??\u200c??\u200c??\u200c??\u02df??\u0315\u200c??\u02df??\u02f3\u200c??\u02df??\u030f\u200c??\u200c??\u02e6\u02ef\u200c??\u02df????\u200c??\u02df??\u0316\u200c??\u200c??\u200c??\u200c??\u02df????\u200c??\u02df??\u02ef??\u200c??\u02df??\u0307\u02f7\u02f0????\u02df\u0315\u02df\u02ef\u200c??\u0309\u0317??\u02d3\u0312\u200c??\u02df\u02f5\u02ef??\u0310\u0311\u0316\u02f7\u02e9\u02e6\u02ef??\u0310\u0310\u02ef\u02eb??\u02f7\u02f0\u02d7\u02d4\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c??\u02ed\u200c??\u200c????\u02ef\u02f3\u0304\u0304\u02f8\u02eb\u0305\u02df??\u02ef\u200c????\u0309??\u02e9\u02d2\u02d2\u0300\u02e9??\u030d\u02f3??\u0316\u0305??\u02e9\u02d2\u02f3\u030d\u02e6\u0305\u200c????\u0305\u0311\u02f7??\u02f2\u0306\u02d2??????????\u0306\u0302\u02f7??\u0305\u02e7\u030a\u02f5\u0305\u02e8\u02f7\u02e5????\u0311??\u0316\u0315??\u02ed\u02e5\u02f2??????\u02d6\u0304??\u02f1\u0314??\u02e6\u02ef??\u02d2\u02f5\u0304??????\u0315\u0302????\u200c??\u200c??\u02f1\u030d\u02f0????\u02df\u0306\u02df\u0305\u200c??\u0309\u0317??\u02ea\u02f1\u0305\u200c??\u02f5\u02ef??\u02d2??\u0314??????\u0315\u200c????\u0318\u02df\u02e6\u200c??\u02ef??\u200c??\u02df\u02f2\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u0307\u0311????\u02ef\u02f4????\u0315\u200c??\u02df\u02e8\u0301\u200c??\u02df??\u200c??\u200c??\u02df\u0301\u02ef\u200c??\u02df\u02e6??\u200c??\u200c??\u0305\u200c??\u200c??\u0314\u0305\u200c??\u02df\u02e6\u0315\u200c??\u200c??\u0305\u200c??\u200c??\u200c??\u200c??\u02df\u02e7??\u200c??\u200c??\u02eb\u200c??\u200c??????\u02f3\u200c??\u02df\u02f7\u030b\u02e6\u0315\u030d\u02f2??\u02f1\u0314????\u0305\u030d\u02f0??\u0307??\u0310\u02df\u02ef\u200c??\u0309\u0317??\u0312??\u200c??\u02df\u02f5\u02f0\u02eb??\u02e9\u02d4??????\u02f6\u02d2??\u200c??\u02df??\u02e7\u02df????\u200c??????\u02df\u0305\u200c??????\u02df??\u02df\u0305\u200c??\u0309??\u02d2??\u200c??\u02df??\u02e7\u02e8\u200c??\u200c????\u02f2\u02f5??????\u200c??\u200c??\u02f6\u02d3??\u0306\u02e6??\u02d7\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u0305\u200c??\u200c??\u02f8??\u0315\u02f3\u02d2\u0300????????\u0316??\u02e5\u02e7??\u02df??\u200c????\u02f2\u02e7\u02df\u02d5\u02e6\u200c????\u02f8\u02e9??\u0309\u02f6??\u0316\u02d6\u02e8??\u0315\u02f3\u02d2\u02f3\u0304??????\u0315\u02e7??\u02e9??\u02d6\u200c??\u02df\u030d\u02ea\u02e6\u0315\u0309\u02f2??\u02f2\u0306\u02df??????????\u0306\u0302\u02f7??\u0307??\u02f1\u02df\u0315\u200c??????\u02d7\u0315??\u02f1??\u02e8\u02df\u02ef\u200c??????\u0306\u0300??\u02f4\u0309\u0317??\u02f0??\u02e5\u02e7??\u02d2??\u200c????\u02f2\u02e7\u02e5\u02e5\u0301\u200c????\u02f8??\u0315\u02f3\u02d2??\u0314??????\u0316\u030d\u0310\u02d7\u0305\u0301\u030f\u02e5\u0306\u02eb??\u02ed\u02df\u02f6??????\u02d6\u02f2\u02eb\u02df\u02ef\u02df??\u02ef??\u200c????\u02e7\u200c????????\u02df\u0305\u200c??????\u02eb??\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02f1\u0312\u02df??\u02f3\u02f3\u02eb\u200c??\u200c??\u0302\u0305\u200c??\u02df????\u200c??\u02df??\u0316\u200c??\u200c??\u02f0\u02ef\u200c??\u02df\u02e6\u02f7\u200c??\u02df????\u200c??\u200c??\u0311\u0315\u200c??\u02df????\u200c??\u200c??\u02e9\u200c??\u200c??\u02f2\u0305\u200c??\u02df\u02e8??\u200c??\u200c??\u200c??\u200c??\u02df????\u02f7\u200c??\u02df\u02f7\u030b\u02e6\u0305??\u0310\u0315??\u02f7\u02e9??\u02ef\u02ef\u0305??\u02ef??\u200c??\u02e8\u02eb\u0305\u02f8??\u02e7\u200c????\u0309??\u02e9\u02d4??\u02ed??\u02ef\u02d2??\u02f7\u02f0\u02d6\u030b\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c??\u02f0\u200c??\u200c????\u02ef\u02ef\u0305\u02ed\u0315\u02e7\u200c??\u02e8\u02eb\u0305\u0310\u0311\u02d2\u200c????\u0309??\u02e9\u02d2\u0309\u0304??\u02f1\u0314\u02d3??\u02df\u0311\u02f5??\u02f2\u0306\u02d6????????\u02df\u030d\u0315??\u200c??\u02df\u0300\u02df\u02d2\u0315??\u200c??\u02df\u0300??\u02df\u02f3\u030d??\u0315\u200c????\u0305\u0311\u02f0??\u02f1??\u02eb\u02df\u02ef\u200c??\u0309\u0317????\u02f8\u0305\u200c??\u02f5\u02ef??\u02d2\u02f4????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u02ed??\u02f1\u02f4\u02ff??\u0305\u02f4\u02f7\u02e5????\u0311????\u02d6\u02e9??\u02f2\u0305\u02d7??????????\u02ef\u02ef\u0305\u02f4\u0315??\u200c??\u02e8\u02eb\u0305\u02e5??\u0301\u200c????\u0309\u0310\u02d4\u0306????\u02e7\u02eb??\u200c??\u02df??\u02f2\u02e7??\u0306??\u200c????\u02f8??\u02f2\u0305\u02f8??????????\u0317\u030d\u02f0??\u02f1??\u0308\u02df\u02ef\u200c??\u0309\u0317??\u0312\u0308\u200c??\u02df\u02f5\u02ef??\u02d2\u02df????????\u0315\u200c??\u02df??\u02eb\u0315??\u02df????\u200c??\u200c????\u0305\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f4??\u02df\u0305\u200c??????\u02eb\u02e5\u02e9??\u02e7\u02f0????\u02f3\u02eb\u200c??\u200c??\u0301\u200c??\u200c??\u02e9\u02eb\u200c??\u200c??\u02ea\u200c??\u200c??\u02e6\u200c??\u200c??\u02e9\u02f3\u200c??\u02df??\u02f2\u200c??\u200c??\u030d\u0315\u200c??\u02df????\u200c??\u200c??\u0301\u200c??\u200c??\u02f5\u02ef\u200c??\u02df\u02e6\u0309\u200c??\u200c??\u200c??\u200c??\u02df????\u0301\u200c??\u02df\u02f7\u030b\u02e5??\u02eb??\u02e9\u02d5\u02d2\u02f5??\u0306????\u02e6????\u02f2\u02e7??\u02d2\u0318\u200c????\u02f8??\u0315\u02ef\u0310\u0310\u02ef\u02d2????\u0305\u02f4\u0306\u02e6\u0317\u0316\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u02f3\u200c??\u200c??\u0302??\u0315\u02ef\u0310\u030a\u02f0????\u02e6\u0317\u02ed\u02f2\u02e7\u02e6??\u02d7\u200c????\u02f8\u02e9??\u02d6\u02ed??\u02df\u0311\u02f0??\u02f1??\u02e6\u02df\u02ef\u200c??\u0309\u0317\u02df??\u02f7\u0305\u200c??\u02f5\u02f0\u02eb??\u02ed\u02e6????????\u02d6??\u0308\u02df\u02e7\u200c????\u0311????\u02df\u02f4\u0314\u02e7\u200c??\u02df??\u0305\u0311\u02f5??\u0315\u02ef\u02d2\u02f5\u0304??????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u02ed??\u02f1\u02f4\u02ff??\u02df\u02d2??????\u0305\u02eb??\u02ef\u02f7\u0305\u02d6\u200c??\u200c??\u02e8\u02eb\u0305\u030c\u030a\u0305\u200c????\u0309\u02f2????\u0305??????????????\u0306\u0302\u02ea\u02ef\u0305\u02f6??\u0315\u02ef\u02d2\u02e9\u0304??????\u0316\u0309\u0310\u02d7\u0305\u0301\u030f\u02e5\u02f0\u02eb??\u02ed??\u0318??????\u02d6\u02f2\u02eb\u02df\u02eb\u02df\u02d5\u0305\u200c??\u200c??\u030d\u200c????????\u02df\u0305\u200c??????\u02eb\u02e5\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u0317\u0312????\u02ef\u02f4????\u200c??\u200c??\u200c??\u200c??\u02df??\u02f2\u200c??\u200c????\u0315\u200c??\u02df\u02e7\u02eb\u200c??\u02df??\u02f8\u200c??\u200c??\u0300\u0315\u200c??\u02df??\u0309\u200c??\u02df??\u02f4\u200c??\u200c??\u02f0\u0315\u200c??\u02df??\u0309\u200c??\u200c??\u02eb\u200c??\u200c??\u02f5\u02ef\u200c??\u02df??\u02df\u02f7\u200c??\u02df\u02e5\u02e8\u0306\u02d6\u02e9??\u0315\u02f3\u0310\u0314\u02f0\u02f7\u02e9\u02e5??\u02eb??\u02e9\u02d5\u02f7\u02ed??\u02df\u02f4\u0306\u02e6????\u02f8??\u030b????\u02df\u02ef\u200c??\u02df??\u02e7\u200c??\u200c??\u02f0??\u0307\u02df\u0304\u02df\u02ef\u200c??\u0309\u0317\u02df\u02d4??\u02ef\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d3\u02e7\u02f0??\u0317????\u200c??\u200c??\u0309\u0317??\u0301\u0304\u0315\u200c??\u02f5\u02f1\u0314\u0311??\u0305\u02ea????\u02ef\u02d2\u200c??\u02df??\u02e7??\u0316\u0311\u02f2??\u02f2\u0306\u0315????????\u02df\u030d\u0315??\u200c??\u02df\u0300\u02df\u0315\u02f0\u0314\u02e7\u02ef\u200c????\u0305\u0311\u0300??\u0315\u02f3\u02d2\u02f5\u0314??????\u0315\u02f7\u02f6\u02f5\u02df\u030d??\u02e8\u02f4\u030d????\u02ef\u030a\u02f7??\u02f0\u0309\u02f2??\u02f2\u0306\u02e5??????????\u02f0\u0306\u0302\u02ea\u02ef\u0305\u02f6??\u0315\u02f3\u02d2\u02ed\u0304??????\u0316\u0305\u0310\u02d7\u0305\u0301\u030f??\u02ef\u02f7\u0304??\u02d3\u02eb\u0305\u02ff\u02e9\u02e7\u200c????\u0309\u02f2??\u02f2\u0305\u0307????????\u200c??\u02df\u02f2\u02eb\u02df\u02eb\u200c??\u0315??\u200c????\u200c??\u02df????????\u200c??\u02df????\u02eb\u02e5\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u0317\u0312\u02ea??\u02ef\u02f4????\u0315\u200c??\u02df\u02e9\u0315\u200c??\u02df??\u0313\u200c??\u200c??\u0310\u200c??\u200c??????\u200c??\u200c??\u02f7\u200c??\u200c??\u02f0\u02ef\u200c??\u200c??\u200c??\u200c????\u02d5\u200c??\u200c??\u0307\u200c??\u200c????\u0315\u200c??\u200c??\u0311\u200c??\u200c??????\u0309\u200c??\u02df\u02f7\u030b??\u02ef\u02f7\u0305\u02f7\u02ef??\u200c??\u02e8\u02eb\u0305\u0306\u0312\u030d\u200c????\u0309\u02f2??\u02f1\u0313????\u0305\u030d\u02f0??\u0317\u02df\u0314\u02df\u0305\u200c??\u0309\u0317??\u0307\u02f1\u0315\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d4????\u02df????\u0304\u02f5\u030a\u0309\u02e5\u02f7\u02f3\u02f3??\u200c??\u200c????\u02ef\u200c??\u02df??\u0311\u02f2??\u02f1\u0313\u02ea\u02e5\u02f1\u0314\u02d3\u02e6\u0315??\u02ea??\u02ef\u02f7\u0305??\u0315\u200c??\u02df\u02e8\u02eb\u0305\u030b\u02f6\u02e7\u200c????\u0309\u02f2??\u02f2\u0306\u0315????????\u02df\u030d\u0315??\u200c??\u02df\u0300\u0300\u0317\u02e7\u200c??\u02df\u030d\u02ea??\u02ef\u02f7\u0304\u0300\u02d3\u02eb\u0305\u030a\u02f8\u02eb\u200c????\u0309\u02f2??\u02f2\u0306\u02f1??????????\u0306\u0302\u02f7??\u0307??\u030c??\u200c??\u02df????\u02d6\u02e8??\u02f1????\u02df\u0305\u200c??????\u030a\u0300??\u02f4\u0309\u0317????\u02f7\u02f2??\u02f2\u0305\u0316??????????\u02ef\u02f7\u0305??\u02ef??\u200c??\u02e8\u02eb\u0305\u02d7\u02d6\u200c??\u02df??\u0309\u0310\u02d4\u02ef\u0301\u030f??\u02ef\u02f7\u0304\u0303\u02f8\u02eb\u0305??\u0302\u0305\u200c????\u0309\u02f2??\u02f2\u0305??????????\u02df??\u02eb\u0315\u02df\u0315????\u200c??\u200c????\u200c??\u02df??\u02f6\u02d2??\u200c??\u02df????\u0315\u02f8????\u200c??\u02df????\u02eb\u02e6\u02e9\u0318\u02d6\u02f0??\u02f3\u02f3\u02ea\u200c??\u200c??\u0305\u02ef\u200c??\u02df??\u02ef\u200c??\u02df????\u200c??\u200c??\u200c??\u200c??\u02df\u02e6??\u200c??\u02df??\u02f5\u200c??\u200c??\u030f\u02ef\u200c??\u02df??\u02f7\u200c??\u200c??\u02f2\u200c??\u200c????\u200c??\u200c??\u02e9\u02e7\u200c??\u02df??\u02ef\u02e5\u0305\u200c????\u0307\u02f7\u0304??\u02f0\u02eb??\u02e9\u02d6??\u02f5??\u0306\u02d2\u02f2??\u02f1\u0313\u02d4??\u02ef\u02f0\u0306\u02e5??\u0309\u02e5\u02f7\u02f3\u02f3??\u200c??\u200c????\u0315\u200c??\u02df????\u02e5\u02e6??\u0317\u02f2\u02e7\u02e5\u030c\u02ea\u200c????\u02f8??\u0315\u02f3\u0310\u030b\u0316??\u02e5\u02e7\u02e6\u02d2??\u200c????\u02f2\u02e7??\u02e8\u0308\u200c????\u02f8\u02e9??\u0315\u02f3??\u0316??\u02e5\u02e6\u0318\u02f1\u02f2\u02e7????\u030d\u200c????\u02f8??\u0315\u02f3\u02d2\u0302????????\u0315\u02e9\u02eb??\u02ef\u200c??\u02e5\u0315\u02ed\u02eb\u02df\u0305\u200c??\u02e5\u0317\u0305\u0308\u200c??\u02df\u02e9??\u0316??\u02e6\u02e7??????\u200c????\u02f2\u02e7\u02ea\u0305\u02f8\u200c????\u02f8??\u0315\u02f3\u02d2\u02f3????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0305??\u02df\u02ef\u200c??\u02df\u0315\u0304??\u0305??\u0305\u02df\u0305??\u200c??\u02df\u0305\u02ff\u02f5\u0315\u030a\u02f8\u02eb\u0305\u0309\u0304??\u0306\u02eb??\u02ed??\u02d5??????\u02d6\u0303\u02e9??\u02f7\u02e6\u0302\u02f1\u200c??\u200c????\u030f??\u02ef\u0301\u0304\u02f4\u02f8\u02eb\u0305\u030a\u0306\u02f3\u200c????\u0309\u02f2??\u02f2\u0305\u02f1????????\u200c??????\u030f\u0312\u0316\u0314\u02f1\u0308\u0315\u030b\u030b\u02e9\u02eb\u030d??\u02f1\u0315??\u030c\u030e\u0312??\u0314\u02e8\u02e5\u02f8??\u02d2\u0302\u02d6\u02e6\u02d5\u0314\u02d5??\u0312??\u02ff\u02e8\u02ea????????\u0312\u0304\u030f\u02f4\u02e7\u0314\u0303??\u030f\u0307\u0304??\u0317\u030d\u02d7\u0314\u0309??\u02e7\u030f??\u0302??\u0313??\u02ef\u0302\u02f0\u0312\u0314????\u0307\u0300??\u02d2\u0301\u02df\u02d3\u0314??\u0302\u0318??\u02d7\u030b\u02ef\u030b??????\u0306??\u02d5\u02f3??\u02ef\u030b\u0316\u02f3??\u0308\u02e7\u0300\u02e5\u0301\u02ed??\u0301\u02d6\u02e9\u02d5\u02f3\u02df??\u0314????\u02f6??\u0302\u02f6\u02f3\u0313\u02f1\u02d3\u02eb??\u02ea??\u0311\u02e5??\u02d7\u02f8??\u02f3\u030d\u02d6????\u02ff??\u030a\u02ff??\u02d2\u030b??\u030c\u0308\u02f3\u030a\u02f8\u0312\u02f4\u0304\u02df??\u02eb\u02d5??\u02f3\u0302\u0317????\u030e\u0305\u02f8\u030a\u030a\u02d3\u02f0\u0313\u02d3\u02f1\u02d2\u0300\u030a\u02f8\u02f1\u030c??\u02e5\u0315\u0306\u0308\u030c\u0308??\u02eb\u0316\u02f8\u0313\u02ef\u02f3??\u02e8\u02f5\u0314\u02ea\u02ef\u0315??\u02e9\u0310\u02d7??\u0306\u0312\u030c\u0309\u0306??\u02d5\u02f5\u0301\u02d7\u02eb\u0313\u02e6\u02e5\u02ef\u02ed??\u030b\u0314\u02f6\u0301\u02e7\u02f7\u0311\u02ea??\u0316??\u0313\u0313\u02d7??\u02e5??\u0311????\u02d7\u030f\u02eb\u02ef\u02d2\u0301\u02d5\u030f\u02e5\u0310\u0305\u0305\u02e5??\u0302\u02df\u030d\u02ff\u0313\u0306\u030d\u02f8\u02d5\u0309\u0308\u02f5\u02f5\u02f3\u02df\u02f0\u02d6\u030e????\u030a\u0305\u0306\u02d6\u02d2????\u02e8\u0311\u02f0\u02d4\u0303\u0307\u0304\u02f4??\u0314\u0302\u02ff\u030c\u0304????\u02f8??\u02f8\u02e5\u02f2??\u0301????\u0318\u0315\u030a\u02e8\u0308\u02d4\u02ff\u02e6\u02f5\u02f8??\u02e9??\u02f6\u02f0\u030b??\u0308\u0304\u02ed\u030a\u02d5\u0300??\u02e7\u02ed\u02e9\u02f3\u030c\u02f5??\u030a\u02f3\u02e9\u0311\u02d4\u030d\u030b\u02e8\u0305\u030d\u02ed\u02eb\u0309\u02df\u02f2??\u0318\u0317\u030e\u02f2\u0315\u0308\u0318\u0310??\u0318\u030a\u02d4\u02f1\u02df\u02f2\u02e8\u02d4\u02f0\u02e8\u02d5??\u0309\u0311\u02e8??\u02d3\u030c\u02d7\u0313\u0307\u0304\u02f4\u02f0??\u02f7????\u0304\u02e7\u030c\u02f7??\u02e9\u0313\u0307??\u02e6\u02f2\u0309\u02f3\u02d2??\u0305\u0307\u02f6\u02d6\u02f7\u0316\u02e6\u02df\u0300\u02e5????\u02ff??\u02e6\u02f0????\u0303\u0306\u02f5??\u0306\u02f0\u0305\u0301????\u030c\u0309\u0313??\u0301\u02d6??????\u030d??\u02f7\u02f2??\u02e8\u02e9\u02e5\u0306\u0308\u030d\u02df\u0313\u0310\u0302??\u0302????\u02f3\u02d6\u02f7\u0311\u0317\u030d\u0304??\u02f6\u0317??\u02df??\u0311\u02f5\u0315??\u02f7\u0309??\u0305\u0317\u02f8\u0316\u0314??\u02d3\u0303\u030e\u02d5\u02f6\u0315\u02d7\u02f6\u02d6????\u0314\u030e\u0311\u02e5????\u02f4??\u02d3??\u0310\u0306??\u0306\u0318\u02d5\u02ed\u0306\u02ef\u030f\u0307\u030e\u02d6\u0314\u0300\u030d????\u0305\u030a\u02e5\u02f5\u0301\u0303\u02e8\u0316\u02f5\u0308??\u0314\u02d7??\u02e7\u02d4\u0301\u02ff\u02e8??\u0314\u02f5\u02f6\u0304\u02f8\u0309\u0313\u02e6\u02d2??\u02f7\u02f1\u0308\u0310????\u02d2????\u0300????\u02f5\u0308\u030a\u0318\u02f4\u02df\u0306????\u0318\u0314????\u030a\u02f7????\u0308\u0310??\u0300\u02f0\u030b\u0315\u0318\u030c\u0314\u02f0??\u0303\u0314\u0315\u02d5\u02ef\u0307\u030d\u02eb\u030f????\u030e??\u02d5\u02df\u02eb\u0318\u02f8\u02df\u02ef????\u030c\u0301\u0314\u0307\u02f8\u02d2\u02f7??\u02ea??\u02f1\u02f1\u0308\u02f5??\u02d3\u02f5\u0315\u0305??\u0309??\u02d3\u0302????\u02e9\u030e\u02ed\u02ed\u02f5??\u0307\u0300??\u02ea\u0301\u0300??\u0312??\u0303\u02f1\u02d5\u0313\u030c\u0317\u0310\u0310\u0313\u0317\u02f6\u02d3\u02d2\u02f0\u02f7\u0304\u02ea????\u02d2????\u02e7??\u0305\u030f\u02eb\u030e\u0313\u0317\u0309????\u0307\u02d2\u030f\u02f4\u0312\u02f7\u02ef????\u02d2\u0312\u02d6\u030f\u0310\u0316\u030c\u0309??\u0302\u0313\u02ed\u0312\u02d2\u0313\u02e5\u0302\u02e5\u02d3??\u030f\u0313\u02f6\u02e5\u0315\u02f6\u02f4\u030f\u0305\u02ff\u030d??\u02d7\u0315\u0300\u030b\u02e5\u02f4\u02e5\u02ff??\u02e8\u030f\u02f0\u02ed??\u02d5\u02f2\u02e9\u02d3\u0301\u02f8\u02d2\u02e6\u02ef\u0312\u02f4\u02d2????\u02f8\u0306\u02f1\u02eb\u0306\u02e5??\u0302??\u030a\u0308\u0312\u02ed\u02e8\u0305\u02e6\u030b\u0302\u0312????\u0314??\u02f2\u030f\u02e8\u0315\u02e5\u02d5\u0311\u02ea????\u02e6\u0312\u0308??\u02ef\u02d7\u02e6????\u02ea\u0314\u0318\u02df\u0316\u030f\u0303\u02d5\u02f3??\u0316\u0302\u0313\u0303\u02e9\u02ea\u0300\u0305\u02f1\u02e6\u030c??\u0303??\u0308\u02d4\u02e8\u030d\u02d7\u02e9\u02df\u02f0??\u02ea\u02f6\u0309??????\u0309??\u0315\u030c\u02eb\u030f\u02ea\u02f2\u0306\u02f8\u02e8??\u02f4\u0306\u02f0\u0300\u0304??\u030e\u02eb\u030d\u030a\u02ea\u0316\u0308\u02f7\u02f0\u02e5\u030d\u02f1\u0317\u0303??\u0300\u02f8\u02e6\u0308??\u02e7????\u02ef\u02f3\u02d3\u0308\u0304\u0310\u0303??\u030a\u0301\u0317\u02d7??\u0314\u0303\u030f\u02d7\u0309\u0314\u0316\u030b??\u030e\u02f6\u02f7\u02d7\u02f6\u02ff\u0315\u02d5\u02d6\u02d3\u030b??\u0308??\u02eb????\u02eb??\u02f7\u0313\u0303\u02ff\u0315\u030c\u02f5\u0317\u02ff\u02f1\u02e7\u02f8\u02f0????\u02ff\u030b\u02f4\u02f0\u030d\u02e6\u0312\u0314\u02f8\u0312\u02f3\u0309\u02ff\u02f8\u0301\u0317\u02d4\u030a\u0304\u0314\u02e9\u0310\u02f4\u0312\u0313\u0305\u0301\u02df\u0301\u02d4\u02f1\u02ed\u0316??\u0312??\u02f4\u02df\u02f0??\u02d3??\u0316??\u02d4??\u0304??\u0303??\u030a\u02df\u0314\u0302\u030d??\u030b\u030d\u030d\u02df\u0313??\u030c??\u02f4\u030f\u02f4\u0317\u02ed\u0307\u030a\u0308\u030b\u02d7\u0303\u02e5\u0306\u02ef\u0308\u0305\u02e6\u02e9\u02d4\u0307\u02d5??\u030b\u0310\u02f7\u02d5??\u02f5\u02d4??\u02e6\u0303????\u02f3\u0312\u02d7\u02d3\u0308??\u02f6??\u0305\u02e9\u02d7\u02df\u02e8\u0313\u02f8\u02ed\u030b\u030d\u0318\u0302\u030e\u02ef\u02e5\u030f\u0314\u02f2??\u02ea??\u0301\u02e5\u0316\u0300\u0316\u02ea\u0306????\u02d2\u0306??\u02ef\u02ff??\u02ff\u030d\u02f0\u02e6\u02f2????\u0309??\u030a\u02df\u02e9\u02d2??\u02eb\u02ea??\u0313\u0300\u0301\u02d7\u02ed\u0305\u02e5\u0303\u030a\u030f\u02d2??\u0301\u02f5\u02f4\u0317\u02e5\u02f1\u0303??\u0304\u0308\u030c\u02f8\u0310\u02d6\u02f8\u0303\u0310??????\u0316\u0308\u0314\u0301\u02f6\u0315\u02f2\u02f2\u02e8??\u02d4????\u030d\u02f4\u0300\u0312\u030c??\u02df\u02d5??\u030e\u02d2\u0312\u0302\u02d2\u02f8??\u0315\u02f8\u02f4\u02f5\u02d4\u02f4\u0315\u02d4\u030c\u02f4\u02e9????\u0315\u02eb\u0303\u02f1\u02ef\u02f7\u02ed\u0315??\u0305\u02d4\u030a\u0316??\u02e6\u02d3\u030e\u02d5\u0316\u030f\u02ea\u0316\u0318\u030b\u0301\u0307\u02d2\u02f5\u0315\u0312??\u0304\u02eb\u0310??\u0316??\u02e8??\u02ed\u030c??\u030d\u0304\u0309\u02f7\u02f6\u0318\u02f8??\u02f2\u02e5\u02f2\u0307\u030f??\u0302\u02d7\u0310??\u030e\u030d\u02d3????\u0302\u0305??\u0302\u02e7????\u0305\u02e6??\u02f1\u02eb??????\u0309\u02d5??\u02eb\u02e5\u02e5\u02d6??\u02ef\u02f3??\u02d2??????\u0300????\u0315\u030c????\u02df\u02eb\u0307\u030f\u030c\u02f5??\u02f7\u02f7\u0303??\u02f3\u02d7??\u02f6\u0316??\u02f1??\u0309\u0306\u030e\u030b\u0311\u0317\u02e9\u030f\u02d6\u02d7??\u02f4\u02f8??\u02f2\u0308\u02d6\u02ff\u0317??\u0303??\u02e5\u0302\u0301\u02df\u02e8\u02ea\u02e8??\u02ff\u02d7\u02f2\u02e7\u02df??\u030e\u02f8\u02f1\u02d3\u02e6\u02f2\u030c\u0304\u0312\u0304\u02d5\u0310\u02f2\u02e5\u0303\u0304\u02f3\u030f\u030f\u0300\u0302\u0318\u0316\u02f8\u0308\u030c\u02eb\u0308\u030c\u02ea????\u0304\u0303??\u030e\u02ff\u0300\u02f8\u02d4\u0310\u02df??\u030e\u02e9\u02f7\u0307\u02f1??\u02d3\u02e6??\u02f1\u0311\u0304\u0308??\u02f6\u02f8\u0305??\u030c\u02f3\u0300\u0305\u0318\u0302\u030c\u0313????\u02d4\u0302\u030a\u0303\u0308\u0308\u0314\u02ea\u02f2\u02f5\u02d6\u0308\u0301\u02d2??\u0307\u02f5\u0307\u0303\u030a\u02f1\u0300\u030b\u030b??\u02e9\u02d4\u02e9\u0300\u0307\u02e8\u030d\u02e6\u02f8\u0304\u0306\u0316\u030f\u0306\u0315\u02ff??\u0305??\u0309\u0310\u02d2\u0302\u02f6\u02e7??\u02f6\u030b\u02f0??\u030f\u02e6\u02d7\u0308\u02ed\u02d6\u02eb\u02e5\u02f0\u02f5\u0303\u02ff\u0306\u02e6????\u02d2??\u030f??\u030b\u02d6\u02ea\u0309\u0308\u0303\u0316\u02ea\u02ef\u0317\u0316??\u02ed\u02f3\u02e8\u030f\u02f2\u02eb\u02f3\u0313\u0304\u02d2\u02ed\u02f6\u02f7\u0317\u0313\u0308\u02ff\u0311\u0303\u02e9\u0308??????\u0301\u02ea??\u02ed??\u02df\u02f6\u030c??\u02ef\u02d5\u030e\u0312\u030e\u030b\u02f4??\u02ef\u030f\u02d7\u0308\u0310\u02ff\u02f2\u0313\u02ed??\u0300\u02f0\u0308\u02e7\u02f7??\u0315\u0316\u030c\u02e9\u02df\u02e7??\u0302\u0303\u0304\u030d\u0318\u0307??\u02e8\u02f3\u0300\u02ed\u030d\u02f2\u02f0\u0318\u02d2\u02f7\u0315??\u02ea\u02d3\u030b\u02d5\u030a\u0307\u0316??\u030c\u02eb\u0314\u02f3\u02d3\u02f4\u02f6\u02e8??\u02e9\u0309\u030a\u0313\u02e6??\u02f3\u02ea\u030f\u02f6\u0300??\u02e7\u0318\u02f3\u02d2\u0317\u030e\u02f0\u0308\u0314\u02f0??\u0310\u02f4\u02d5\u02e6\u02eb\u02d2\u02d5\u0305\u02e5??\u0311\u02f3\u02eb??????\u02f4??\u030b??\u02d5??\u02f4\u02d2\u0307??\u0305\u02eb\u0309\u0315??\u02df\u02e8\u030b\u030f\u02d4\u02f4??\u02f8\u0309\u02f8??\u0313\u02e8??\u02e8??\u0305\u02eb\u02ed\u02f6\u02d2??\u02f2\u02e6\u0305\u0311\u02f5\u0310\u0311\u0310\u0312??\u02e7\u02f1??\u0318\u02eb\u030b????\u0305\u02f4\u0310\u02ed??\u02e7??\u02eb\u02d2\u0302??\u0313\u02d5????????\u02e6??\u02e5??\u030e\u02f0\u02f5\u0317\u0300\u030d\u0309\u0314\u0307\u02f2??\u0317\u0315\u0303\u02f0\u02e6\u030b\u02ea\u02ff\u030a\u02d6\u02d6\u02f2\u030a\u0300??\u0310\u02ff??\u0305????\u02ea\u0316\u02f5\u0316\u02e6\u0313\u02d5\u0315\u0313\u0311\u02d3\u0317\u0312??\u02d5??\u02e8\u02f8\u030d\u02f8\u02d7\u02d3\u02e5\u02d2??\u02d6??\u02df\u0314\u02f5\u030b\u0302\u02d4\u02f5\u02eb??\u02f7\u02f5\u030b\u0302\u030a\u030d\u0315\u02f3\u02d3\u0316??\u02d6\u02e8\u02f0\u0309\u0301??\u02d4????\u02ed\u02f8??\u0314\u02f8\u02e6\u02ff\u0304????\u02ff\u0311\u02f4\u030c\u02eb\u02e6\u02df\u0300??\u02d2\u0303\u0318\u02ff\u02d7\u030e\u0305\u0301??\u030e\u02e5\u030a\u0316\u02d3\u02d2??\u030d\u02ed\u02ff\u0311\u02d5\u0315\u02e7\u0316\u030a\u02f0\u02eb\u02f6\u02df\u02d5??\u02f1\u030f\u030b\u0308\u02eb\u0309\u02f6\u02d6\u0317\u02f0\u02f4\u02e5??\u0316\u02e6\u02d3\u02e5\u0304????\u02d7\u0305\u0302\u030f\u030d??\u02e9\u030e??\u02eb\u030d\u0313\u030a????\u0300??\u0307\u02f6\u02ea????\u0302\u02df\u02e5\u02d4\u0303??\u02f1??\u0302\u02d6\u02e8\u0301\u02d3\u02d5\u0315\u0308\u02d4\u02ff??\u02d6\u02f4\u0314\u02d3\u0312\u0313\u0305\u02e7\u02f3??????\u02d7??\u02d4\u02eb\u030c\u0314\u030b\u02e6\u02f0??\u02d4??\u0303\u02f5??\u02d6\u02d2\u02e7\u02e5\u02d3\u0306\u0300\u02f5\u0310\u02f8??\u02f0\u02d2\u02ef??\u02ed\u02d5\u0304\u0316\u02ef\u0316\u02d3\u0309\u02d4\u02ff\u02ea??\u030c\u02e8\u02eb\u030e\u0300????\u02e6\u0304\u0303\u02f5\u030f\u02d2??\u02e5\u0315\u02f6\u02ea??\u030f\u02f7????\u02ed\u02d4\u030c\u02eb????\u02df??\u02ed\u02e7\u02ff\u0315\u0308\u02ff\u0305????\u0306??\u02ff\u02ff\u02d3\u0305\u0304\u02f8\u02f8??\u02d7\u02ed??\u0307\u02d2\u02f0??\u0315\u0313??\u02f5\u02d3\u02e9\u030f\u0305\u0310\u0312\u02f1\u02d2??\u0314\u02f4\u0316\u0313\u0307\u02d2\u02d4\u02f8\u0318\u02ff\u0302\u0303\u0313\u0312\u0303\u0302\u02ef??\u02f8\u02f2\u0304\u02e9\u0317??\u0312\u02f1\u02f5\u02d4\u0301??\u030d\u02e8\u02ef\u030c\u02e6\u02eb\u0303\u02eb\u02e5\u02e7\u02ef\u02d2\u02e7\u030c????\u0302??\u02f3??\u0318\u02ea\u0310\u02d2\u02d4\u0318\u0300\u0315\u0312??????\u030c\u02f5\u02f4\u02f3\u0311??\u0308\u0300\u030c\u0306\u0300\u0300\u0302\u02ea\u02e5\u02ef\u0307\u02e6\u02e7\u02ef\u0310??\u0318\u02d5\u02e9\u02f4\u0301??\u030e\u0302\u0313\u02f4\u0317\u02ea????\u0312????\u0318\u0307\u02e8\u02e8\u0303\u02ea??\u0307\u02d6\u0302??\u0307\u0303??\u02ed??\u0311??\u02d3\u030a\u02e5\u0301\u0310??\u02e9\u0313\u02eb\u02e6??\u030f??\u0308\u030d\u030b\u0300\u02f2\u030c??\u02e6\u02ed??\u02df??\u0308??\u02df??\u02f3\u02f0\u030f??\u030a\u02ea??\u030d\u0300????\u0312\u02e6\u02ff\u0314\u02f1\u0310\u0315\u0306\u02f2\u030a??\u0303\u02f3\u02e9\u0313\u0307\u0305\u02f8??????\u02f0??\u02d4??\u02f4????\u0301??\u0312??\u02f7??\u0310\u0315\u0312\u0307\u0305\u0301\u0308\u0316????\u030a\u02e5\u0303\u02f6\u02d3??\u0303\u0318\u02df??\u02d6\u02f8\u02d2??\u030b\u02f3??\u02f6\u02e9??\u02e9\u0304\u0313\u0314??\u0306\u0314\u030f\u02f3\u02f3\u030e??\u02ef\u02d4\u0305\u02d7\u030d\u02ef\u0305\u0312\u0317\u030e\u02d7\u0310\u02ff????\u0314\u02d2??\u0313\u02e6\u0301\u0310\u0313\u02e6\u030a\u0313\u0300\u030c\u030c????\u0309\u0302\u02df??\u0308\u0302??\u02eb\u0317\u02d4\u02f6\u02f6??\u030c\u030e\u0301\u02e8\u0314\u0316\u02d2\u030b\u0306\u02ed\u02ed\u02e5????\u030a\u0309????\u02e7\u02f8\u0313??\u030e\u0303\u02e7\u0306\u0310\u02ef??\u02f0\u030d\u02f0\u02f1\u02f5\u0312\u0309??\u02f1\u02d6\u02e5\u02f2\u02d5\u0306\u0315??\u0315????\u0302????\u0301\u02f1\u02d6\u02ff\u030a????????\u0318\u02f3??\u02f4\u02f2??\u02f4\u0301\u02f7\u0307??\u02d7\u0305\u02e6????\u02d4\u030d\u02d3??\u02ef\u02f6\u02ff\u0314??\u030b\u02e7????????\u02ea\u02f8\u02e9\u02f4\u02ea??\u02f7\u02ed\u02eb\u02e8\u0314\u0305\u0309\u02f6\u0312\u0308????\u0306????\u02f0\u02eb??\u02e8??\u030e??\u0308\u0315\u02f6\u02f7\u030e\u02f3\u02e5????\u0312??????\u0302??\u02f0\u0305??\u02f8????\u0312\u0302\u02f8\u0302\u0310\u0312??\u0307\u0301\u0316\u02e5\u0316\u030c\u02f4??\u02d2\u02f2\u0307\u030e\u02d7\u02e5\u02ff\u0301\u0301\u02e7\u0302\u02f1\u02ef\u0318\u02df\u02d5\u0305\u02f8\u02e5????\u0313\u02df??\u02eb\u0303\u0312\u0307\u0315\u0307\u02f6\u0312\u02f0\u02d7\u02e9\u02ed\u0311\u02f4????\u02f5\u02e8??\u0305\u02f4\u02d6\u030e\u02f8????\u030f\u02d4\u02d4\u02d2????\u02e9????\u02eb\u02f0\u0308??\u0315\u02e7\u0308\u0318\u02f3??\u030b\u0303\u02d3????\u02e9\u02d6\u02ef\u02f1??\u02e8????\u02e9\u0307\u0316\u02f3??\u030b\u0304\u02d6\u030a??\u02f7\u0308\u02ff\u0302??\u02eb\u0303\u0304\u02f3??\u0318\u02d3\u02d2\u0314\u030b\u0306\u0313??\u030b??\u02e8??\u02e8\u0317\u02f4\u0307\u030e??\u0313\u02e8\u0304??\u02df??\u02e6\u02f1\u030b??\u02f1\u030b\u02f0\u0314\u0309\u0303\u02d6\u02f1\u02f5\u0313\u0301\u02f7\u0310\u02ff\u02d6\u02f6????\u0313\u02d7??\u0312??\u02e9\u0316??\u02f1????\u0311\u0316\u02d2??\u0317\u02ea\u02d6\u0303\u02f7\u0311\u02f2\u0318\u02d3\u030f\u02ea\u02d5\u02d6??\u02e7\u0300\u02e7????\u02d7??\u02e8\u0303\u02f8??\u0317\u0311\u02df\u02e5\u0318\u02f4??\u02d2\u02f7??\u0309\u0318\u0307\u02f0\u02df\u02e5\u030f??\u0308\u0315??\u030f\u0316\u030e\u030e??\u02d5\u02f4\u02e8\u0303\u0302??\u0300\u02f0\u02f6\u02d5??\u02e9\u030e??\u02e6??\u02f0\u02f2\u0315\u02f7\u0313??\u02f1\u02f8\u030b\u030b\u02f4????\u0305\u02e5\u030a\u02e7??\u0304\u02d2??\u02ff\u0303??\u02d4\u02e8\u02eb\u0306\u0316\u0318\u030a\u02f6\u0307\u0312\u02ff\u0309\u0304\u0305????\u0318\u02d2\u02df\u030d??\u0317??\u030b\u02e8\u02d6\u02ed??\u0305\u0308\u0316\u0310\u02f3\u02ef\u0301\u02ff\u0302\u030c\u0300\u02d4\u02d2\u02ef\u0306\u02ea??\u0312\u02df\u02ed\u02ed\u030b\u030c\u02f8\u02ff\u0306\u030b\u0314\u0314??\u0311\u02e8??\u02d6\u0309\u0310\u02f1\u02eb\u0317\u030f\u0305\u02f4??\u0318\u030b??\u030e\u02ff\u0308\u02eb\u02d7\u030b\u02ed\u0314\u0300\u0305??????\u0311\u02d4\u02ff\u0316\u02e8\u0310\u02ed\u030b\u030b\u02d4\u02e5\u030b\u02e9??\u030d\u030d\u02df\u02ed\u02d3??\u030e\u0313??\u030d\u02ef\u030b\u0311??\u02f8\u0302??\u0306\u0312\u02ed\u0312\u02ea\u02d5\u0301\u030a\u0312\u0317\u02d4??\u02d3\u02e8\u02ef\u0311\u0312\u030a??\u02eb\u02d7\u02e7????\u0313\u030d\u02f5\u0310\u0300\u030d\u02df\u0303\u0308\u0304\u02d4\u02f3??\u02d5\u02f7\u0305\u0304\u0317\u02f8??\u02e7\u030c\u02d6\u02df\u02f0\u0304\u02f0\u0301\u02e7\u030c\u02d3\u02df\u02f0??\u030e\u02e8\u02e5??\u02e7\u200c????\u02e8\u02f2\u02f1\u0309\u02e7??\u200c????\u200c??\u200c??\u200c??\u02df\u0315\u200c??\u02df????\u02eb\u0307\u02d2\u0315\u02ea\u0308\u02f3\u0315??\u0318\u02e7??\u200c??\u200c??\u200c??\u02ef\u02df\u02ff\u200c??\u200c????\u02ef\u02e5\u200c??\u02df\u0308\u0304\u0305\u200c??\u02f6\u02df\u0301\u200c??\u02ed\u02ef??\u200c??\u02df\u0308\u02f3??\u02f0\u0317\u02ff\u02f5\u02d3\u030c\u0301\u0315\u200c??\u200c????\u02df??\u02ef\u200c????\u200c??\u200c??????\u02e6\u02f4\u02f3\u030a??\u200c??\u200c??\u02f3\u02df??\u200c??\u02df\u0315??\u200c??\u02df\u0308\u02ef\u030b\u0316\u0314\u02f7\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02e7\u200c??\u02df\u030e\u02f6\u030a\u02ef\u02e7\u030d??\u02f0\u02d2\u200c??\u02df??\u02d4\u02df\u02f2\u02eb\u02df??\u0305\u200c??\u02df\u02ef\u200c??\u02df??\u200c??\u200c??\u02df\u02ea\u200c??\u200c????\u200c??\u200c????\u030d\u200c??\u200c??\u02e7\u200c??\u200c??\u02eb\u200c??\u200c??\u02df??\u200c??\u200c????\u200c??\u200c????\u200c??\u200c??\u02df\u02f3\u200c??\u200c????\u200c??\u200c??\u02df\u02ef\u200c??\u200c??\u02ef\u200c??\u200c????\u200c??\u200c????\u02ef\u200c??\u200c??\u030d\u200c??\u200c????\u200c??\u200c??\u200c??\u02df??\u200c????\u200c??\u200c??\u200c??\u02df\u02f7\u02df\u02f4\u0315\u02df\u0307\u200c??\u02f7\u02df\u02f6\u02df??\u0310\u200c??\u02f7\u02df\u030b\u0315\u02df\u0307\u200c??\u02f7\u02df\u030d\u02ef\u02df\u0307\u200c??\u02f7\u02df\u0316\u0305\u02df\u0307\u200c??\u02f7\u02df??\u02ef??\u0301\u200c??\u02f7\u02df\u02d3\u0305??\u0301\u200c??\u02f7\u02df??\u02ef\u02df\u0307\u200c??\u030d\u02df??\u0305\u02df\u02e8\u02df\u02ef\u030d\u02df\u02e6\u0315??\u02e8\u02df\u02ef\u02f7\u02df\u02ea\u0315??\u0307\u200c??\u02f7\u02df\u02f3\u0305??\u0300\u02df\u02ef\u02f7\u02df\u0304\u02ef\u02e5\u02e8\u02df\u02ef\u02d2\u02df\u030c\u02df??\u030e\u200c??\u02f7\u02df\u030d\u0305\u02e5\u02e8\u02df\u02ef\u02d2\u02df\u0310\u02df??\u030e\u200c??\u02d2\u02df\u0311\u0305??\u030e\u200c??\u02f7\u02df\u0313\u02ef\u02e5\u02e8\u02df\u02ef\u02f7\u02df\u0316\u02ef??\u0307\u200c??\u02f7\u02df??\u02df??\u0307\u200c??\u02f7\u02df??\u0305??\u02e9\u02df\u0305\u02f7\u02df\u02e5\u0315\u02e7\u0309\u02df\u0305\u02f7\u02df\u02f4\u0315\u02e7\u0309\u02df\u0305\u02f7\u02df\u0301\u02df\u02e7\u0307\u02df??\u02e7\u02df\u0302\u0305\u02e7\u02d2\u02df??\u02e7\u02df\u0308\u02ef\u02e7\u02d2\u200c??\u02f7\u02df\u030a\u0305\u02e7\u0307\u200c??\u02f7\u02df\u02d3\u02ef\u02e7\u0307\u200c??\u02f7\u02df\u02e5\u0305\u02eb\u0306\u02df\u0315\u02f7\u02df\u02f1\u02df\u02eb\u0307\u200c??\u02f7\u02df\u02f4\u0305??\u0309\u02df\u0315\u02f7\u02df\u0305\u02ef\u02eb\u0307\u200c??\u02f7\u02df\u0307\u02df??\u0300\u02df\u02ef\u02f7\u02df\u02d6\u02df??\u02d4\u02df\u0315\u02f7\u02df\u02eb\u02df\u02ef\u0307\u200c??\u02f7\u02df\u030a\u02df\u02f0\u0310\u200c??\u02f7\u02df\u0312\u02df\u02f0\u0310\u200c??\u02f7\u02df??\u0305\u02ef\u0309\u02df\u0305\u02f7\u02df\u02d4\u02ef\u02ef\u0309\u02df\u0305\u02f7\u02df??\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u02e8\u02ef\u02f3\u0309\u02df\u0305\u02f7\u02df??\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u02f4\u0315\u02f3\u0309\u02df\u0305\u02f7\u02df\u0301\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u0308\u02ef\u02f6\u02d4\u02df\u0315\u02f7\u02df\u030d\u02ef\u02f6\u02d4\u02df\u0315\u02f7\u02df\u0310\u0315\u02f3\u0309\u02df\u0305\u02f7\u02df\u0318\u02df\u02f4\u0310\u200c??\u02df??\u200c????\u02ed\u200c??\u200c??\u200c??\u02df??\u200c????\u200c??\u02ef\u02df\u02ef\u02df\u02ea\u0311\u02df\u0315\u200c??\u02f4\u200c????\u200c??\u0305\u02df\u02ef\u02df\u02ef\u200c????\u0305\u02ea\u02f0\u02df\u02e6??\u200c??\u0315\u02df\u02e7\u200c??\u02df??\u200c????\u0314\u02df\u0312??\u02df??\u02ef\u02df??\u200c??\u0305\u02df??\u02df??\u200c????\u030d????\u02ef??\u0316\u200c??\u02f3\u02df??\u200c??\u200c??\u02ef\u200c??\u02df\u02ef\u02eb\u200c????\u02f3\u02df??\u02ef\u02df\u02e7\u200c??\u02f3??\u200c??\u02df\u02d6\u02df\u0315\u200c????\u02ef\u02df??\u200c??\u030d\u02df??\u0315??\u200c????\u02f3??\u200c????\u0316\u200c??\u0309\u02df??\u0305\u02df??\u02df\u02ef\u200c??\u02e9\u02ef\u02ef\u200c????\u02f3\u02df??\u02ef\u02df\u02f1\u200c??\u02f3??\u200c????\u02ed??\u200c??\u02df??\u02ef\u02df\u02e8\u02df??\u02ef\u200c??\u02df??\u200c????\u02df??\u200c??\u02df\u02f4\u200c??\u0309\u02df??\u0315\u02df\u02f2\u02df\u0301??\u02df\u02e6\u0315\u02df\u02f2\u02df????\u02df\u02e7\u0315\u02df\u02f2\u02df\u0304\u02f7??\u02e8\u0315??\u02f2\u02df??\u02f7??\u02e7\u0315\u02df\u0316\u02df??\u02df??\u02f5\u0305??\u0316\u02df??\u0305??\u02f5\u0305??\u0316\u200c??????\u02f5\u0305??\u02f2\u02df\u02f3\u02ef??\u02f6\u0305??\u02ef\u02e7\u200c??\u200c??\u02df??\u02f0\u02e5\u02ea\u02ef\u02df\u02e5\u0315\u02df??\u02df\u02e7\u0305\u0305\u200c??\u200c??\u02df\u02e8\u02f7\u02df\u02ef\u0315??\u0301\u200c????\u02df\u0316??\u02e7\u200c??\u200c??\u02df\u030a\u0305??\u0313\u02df\u02f7??\u200c??\u0305??\u0315\u02e8\u200c??\u200c??\u02df??\u02f0\u02df??\u02f7??\u0318\u0315\u02df??\u02df\u02ea\u02ef\u030b\u200c??\u200c??\u02df\u02e8\u02f7\u02df\u02ef\u02df\u02ea\u0316\u200c??\u02ef\u02df\u02f4??\u0301\u200c??\u200c??\u02df\u030a\u0305??\u030c\u02df\u0307\u02df????\u0305??\u0309\u02e9\u200c??\u200c??\u02df??\u02e5\u02e5??\u02eb\u02df\u02f5\u200c??\u02e8\u02df\u02ea\u02ef\u030d\u200c??\u200c??\u02df??\u02eb\u02df\u0318\u02ef\u02df??\u02df\u02ef\u0309\u02df\u02d2??\u0309\u200c??\u200c??\u02df??\u0315\u02df\u02d2\u02df??\u02eb????\u02ef??\u0305\u02e9\u0305\u200c??\u200c??\u02df\u02f2\u02df??\u02f7??\u0308\u0305??\u02e8\u200c??\u0305\u0312\u200c??\u200c??\u02df??\u02eb\u02df??\u02ef??\u0307\u02df\u02ef\u0309\u02df??????\u200c??\u200c??\u02df??\u0315????\u02df\u02eb\u02eb????\u02ef\u02df\u0309\u02ea\u0315\u200c??\u200c??\u02df\u02f2\u02df??\u02f7????\u0305??\u02e8\u02df\u02ea\u02ef\u0315\u200c??\u200c??\u02df??\u02eb\u02df??\u02df????\u02df\u02ef\u0309\u02df\u0314????\u200c??\u200c??\u02df??\u0315??\u0314\u02df\u0306\u0305????\u02ef??\u02e7\u02eb\u0305\u200c??\u200c??\u02df\u02f2\u02df??\u02d2????\u02df\u02e7\u02e8\u02df\u02e9\u0315\u0318\u200c??\u200c??\u02df\u02e8??\u02f7\u0312\u200c??\u0300\u200c??\u0309\u02df\u0314??\u02ef\u200c??\u200c??\u02df??\u0315??\u02f0\u02df??\u0311????\u02ef??\u02df??\u02ef\u200c??\u200c??\u02df\u02f2\u02df\u02eb??\u02df\u0302\u02ef\u02e7\u02e8\u02df\u02ea\u0305??\u200c??\u200c??\u02df??\u02eb\u02df\u0318\u02ef??\u02f0\u02df\u0305\u0309\u02df\u030b??\u0301\u200c??\u200c??\u02df??\u0315????\u02df\u030f\u0311????\u02ef??\u030d\u02ed\u200c??\u200c??\u200c??\u02f2\u02df??\u0305??\u0312\u02ef\u02e7\u02e8\u02df\u02eb\u02ef\u02d3\u200c??\u200c??\u02df??\u02eb\u02df\u02ed\u02df??\u02eb\u02df\u0305\u0309\u02df\u0316??\u030d\u200c??\u200c??\u02df??\u0315??\u02f0\u02df\u02ed\u02df????\u02ef??\u02df\u02ed\u0315\u200c??\u200c??\u02df\u02f2\u02df\u02eb??\u02df\u02d5\u02df\u02e7\u02e8\u02df??\u02df\u02d6\u200c??\u200c??\u02df??\u02eb\u02df\u02e8\u02ef\u02ef\u02e7\u02df\u0315\u0309\u200c??\u200c????\u02df??\u0305??\u200c??\u02df??\u02df\u02e6\u02e7??\u200c??\u02df??\u02df\u02e6\u02f7??\u200c??\u02df??\u02df??\u02ef??\u200c??\u02df??\u02df??????\u200c??\u02df??\u02df\u02ea\u02f7??\u200c??\u02df??\u02df\u02eb\u02ef??\u200c??\u02df??\u02df????????\u02ef??\u02ea\u02df??\u02eb\u02df\u02ed\u02ef??\u0318\u02df??\u02e7\u02df\u02f1\u02ef??\u0318\u02df??\u200c??\u02f5\u02ef\u02df\u02d5\u02df\u02f4\u0305\u02df\u02e5\u02ef??\u030c\u02df\u02f6\u02d6\u02df\u0303\u02ef??\u0318\u02df??\u0305\u02df\u030b\u02ef??\u02e9\u02df\u0301??\u02df\u0303\u02ef??\u0313\u02df\u0301\u0305\u02df\u030f\u02ef??\u0318\u02df\u02ed\u02f3\u02df\u030f\u02ef\u02df??\u02df\u0313\u0315\u02df\u0317\u02ef????\u02df\u0306??????\u02ef??\u0307\u02df\u0306\u0311??\u02e9\u02ef??\u0318\u02df??\u0305\u02df\u0305\u02ef\u02df??\u02df\u0318\u030d??\u0305\u02ef\u02df??\u02df\u0318\u030d??\u02d4\u02ef\u02df\u0317\u02df\u0316\u0311????\u02ef\u02e6\u0318\u02df??\u0305\u02df??\u02ef\u02e5\u02f5\u02df\u02d2\u02eb??\u02e9\u02ef??\u0302\u02df\u02d2\u030d??\u02df\u02ef\u02e5\u030b\u02df\u0318\u030d??\u0301\u02ef??\u0316\u02df\u02d5\u030d??\u0301\u02ef??\u02d4\u02df\u02d7\u030d??\u0301\u02ef??\u200c??\u02d7\u030d??\u0301\u02ef??\u02e5\u02df\u02d7\u030d??\u0303\u02ef??\u02eb\u02df??\u0301??\u0311\u02ef??\u0304\u02df\u0316\u02eb??\u0311\u02ef\u02df\u02f8????????\u02e5\u02ef??\u02d7????\u02ef??\u02f7\u02ef??????\u02e5\u02d6??\u02f7\u02ef??\u02f4??\u02e7\u0315??\u0301\u02ef??\u0304??\u02e9\u02eb??\u02eb\u02ef??\u0312??\u02eb\u02ef??\u0307\u02ef??\u0317????\u0309??\u0303\u02ef??\u02d5????\u030d??\u02df\u02ef\u02e5????\u02df\u02e7??\u02e7\u02ef\u02e6\u0318\u02df??\u02eb??\u02e9\u02ef\u02e6\u0318\u02df??\u0305\u02df\u02eb\u02ef\u02e6\u0318\u02df??\u02df??\u02ed\u02ef\u02e6\u0318\u02df??\u02df??\u02ef\u02ef\u02e6\u0318\u02df??\u02df??\u02f1\u02ef\u02e6\u0318\u02df??\u02df??\u02f3\u02ef\u02e6\u0318\u02df??\u02df??\u02f5\u02ef\u02e6\u0318\u02df??\u02df??\u02f7\u02ef\u02e6\u0318\u02df??\u02df??\u02ff\u02ef\u02e6\u0318\u02df\u02eb\u0311??\u0301\u02ef\u02e6\u0318\u02df??\u02df??\u0303\u02ef\u02e6\u0318\u02df??\u02df??\u0305\u02ef\u02e6\u0318\u02df??\u0305\u02df\u02ea\u0305??\u0310\u02df\u02f7\u02f3??\u02ea\u0305??\u0308\u02df\u02f7\u02f3??\u02ea\u0305??\u0300\u02df\u0300\u02eb??\u02ea\u0305????\u02df\u02ef\u0301??\u02ea\u0305??\u02d5\u02df\u0304\u030d??\u02ea\u0305??\u0318\u02df\u0302\u02df??\u02ea\u0305??\u02f2\u02df\u02ff\u02ef??\u02ea\u0305\u02df\u0318\u02df\u02f3\u02f3??\u02ea\u0305\u02df\u0310\u02df\u02f1????\u02ea\u0305\u02df\u0308\u02df\u02f0\u0305??\u02ea\u0305??\u02ea\u02df\u02f7\u0311??\u02ea\u0305????\u02df\u02f7\u02f3??\u02ea\u0305\u02df\u02d5\u02df\u02f5\u02ef??\u02df\u0305??\u0309??\u200c??\u200c??\u0315\u02df??\u02df??\u0305??\u200c??\u02df??\u200c????\u02df\u02f0\u0305\u200c??\u200c??\u0305\u02df\u02e8\u0315??\u0308\u02df\u02e8\u02f3\u02df??\u0305??\u02d2\u02df??\u0311??\u02f0\u0315??\u0307\u02df\u02f8\u0301??\u030f\u0315\u02e6\u02ed\u02df\u0303\u0301????\u0305\u02e7\u0304\u02df\u0308????\u02f0\u0315\u02e8\u0309\u02df\u030d????\u030b\u02df\u02ea??\u02df\u0309\u0305\u02df??\u0315??\u02d7\u02df\u02f7\u02df??\u02d7\u02df\u02e6\u0301??\u02ef\u200c??\u02df\u02ef??\u02df\u02ef\u0305\u200c??\u02df\u0315\u02df\u02f7\u02f0\u0305\u200c????\u200c????\u0305\u200c??\u200c??\u02ef\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c??\u02df\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02ef\u02df\u02f8\u200c??\u200c??\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u02df??\u02e7\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u030d\u02df\u02e9\u02ef\u200c??\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u0305\u02df\u02d2\u200c??\u200c??\u200c??\u02df\u02e6\u200c??\u02f7\u02df??\u200c??\u02e6\u200c??\u0309\u02df??\u0305\u02df\u02e9\u200c??\u0309\u200c??\u200c??\u200c??????\u02df\u0308\u02df\u02ef\u200c??\u200c??\u02df??\u0315??\u02eb??\u200c??\u200c??\u200c??\u0302\u02df\u02e7\u0315??\u02df\u02ef\u200c??\u02df????\u02df\u0309\u02df\u02ef\u200c??\u200c??\u02df\u02e8\u0315??\u02eb??\u02df??\u200c??\u200c??\u030c\u02df\u02e8\u02df??\u200c??\u200c??\u02df????\u02df\u0308\u02df\u02ef??\u200c??\u200c??\u02ea\u02ef??\u02ef??\u200c??\u200c??\u200c??\u0314\u02df\u02e7\u0315??\u200c??\u200c??\u02df????\u02df\u0308\u02df\u02ef\u200c??\u200c??\u02df\u02eb\u0315??\u02eb??\u200c??\u200c??\u200c????\u02df\u02e7\u0315??\u02df\u02ef\u200c??\u02df??\u02f3\u02df\u0309\u02df\u02ef\u0313\u02df??\u0311\u02df\u02e8\u0305????\u02df??\u02f7\u02df\u0303\u0315\u02df\u02ea\u02df\u02e7\u0309\u02df??\u02df??\u0310\u02df??\u200c??\u0311\u200c??\u0317\u02df\u02ea\u02f3\u02df\u02e6\u02df??\u02d4\u02df??\u02ef\u02df\u02d2\u200c??\u0311\u200c??\u0315??\u02df\u02ef????\u200c??\u02e7\u02df\u0305\u02ef\u02df??\u02df????\u02df??\u02df??\u02e8\u200c??\u02f3\u02df\u0305\u02ef\u02df\u02e5\u02df????\u02df??\u0315????\u200c??\u0305\u02df??\u02ef\u02df\u02e8\u02df??\u0309\u02df??\u0305????\u200c??\u0311\u02df??\u02ef\u02df\u02eb\u02df\u02e7??\u02df??\u02ef????\u200c??????\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f3\u0313\u02f4\u02f3\u0309\u0313\u02f8\u02e5\u0316\u0311\u02df??\u02e8??\u0300\u030b\u030a\u030b\u0302\u02f1\u02d3\u02f4\u02f1\u02ef??\u0312\u0301????\u0314\u0301\u030b\u0316\u030e\u02f7\u0305??\u02f2\u0303\u02f6????\u02f8\u02f5??\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u0309\u02f0\u0317\u02f7\u02f6\u0302\u030e\u0300\u030b\u0301\u02df\u02f2\u02f5\u030a\u0308\u0301\u030b\u02d7\u0318\u0300??\u02f8??\u02ea\u030a\u02f8\u030e\u0301??\u02f4\u0306\u0300??\u02e8\u0306\u0301??\u030a\u0308\u02df??\u0316??\u0300??\u02f0??\u0300\u02e5\u02f3??\u02df????\u030d\u02f7\u02f6\u02e7\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f3\u0306\u030a\u0300\u02e6??\u030a\u0301\u030c\u02eb\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02e8??\u0300\u030c\u02f0\u030e\u0300\u02f5\u02f3\u0313\u02ef??\u02d7\u0312\u0301\u02e5\u030a\u0311\u02f8\u02f6\u02e8\u02f2\u02f8\u02f6\u02e8??\u02ff\u02f5??\u030a\u0301\u0315??\u02e8\u0300\u030b\u030a??\u02ff\u02f5??\u0311\u02ff\u02f6\u030e\u030a\u02ef\u02f6\u02e8\u0317\u02f7\u02f6\u0309\u02df\u02ef\u02f6\u02e8\u0317\u02f7\u02f6\u0309\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f3\u02f8\u030e\u02f8\u02f5\u0316\u0309\u02f1\u02e5??\u0313\u02f8\u02e5\u0316\u030a\u02df??\u02d3\u0308\u02f7??\u02f0\u0314\u0301\u0305????\u02f8\u02f6\u02f0\u0306\u02df????\u0311\u0301\u02e5\u0306\u0306\u02df??\u02d7\u0307\u02ff\u030b\u02f4\u0308\u0302\u02df??\u0306\u0305\u030f??\u02df\u02d2\u02f7\u02e9\u0305\u02df??????\u0301\u030b\u02f4\u0306\u0300\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f1\u02f3\u02d6\u02df\u02f2\u02f5\u02f4\u0312\u0300??\u02e8\u02d3\u02f3??\u02f0\u0317\u02f8\u02f5??\u0312\u02df??\u02d3\u0308\u0302\u02e5\u02d7\u0317\u02df??\u02e8\u02d3\u0302\u02e5\u02f3\u02df\u02f0??\u030e\u030e\u0301??????\u0301\u030b\u02f4\u0306\u0300\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f1\u02f3\u02d6\u0313\u02ef??\u02d7\u0312\u0301\u02e6\u02e8\u030a\u0301????\u030e\u0300??\u02d2\u02df\u02ef??\u02d7\u0312\u0301\u02e6\u02e8\u030a\u0301????\u030e\u0300??\u02d3??\u0300??\u02f0\u030a\u02df??\u030a??\u02ff\u02f6??\u0315\u0300????\u0306\u02f7\u030b\u0316\u030a\u02df??\u02f0\u030e\u0301????\u0314\u0301??\u02f3\u02df\u02f0\u02e6\u02e8\u0306\u0302\u0315??\u030a\u030e\u02e9\u0304\u030b\u0312\u0300\u0304\u0308\u0305\u030e\u02e7\u02df\u02f0\u02f5\u02d3\u0308\u0300??\u02f0\u030e\u0300\u030b\u0301\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02f0\u030a\u0303\u02e6\u02ef\u02df\u02f3\u030b\u02f4\u0318\u02ff\u02f6\u030e\u030a\u02df????\u030a\u0300\u0305??\u0308\u0305\u030d\u0311\u02df\u02d4\u0300\u0303\u02d3\u02d2\u02d2\u02e5\u0314\u02df??\u030a??\u0300\u030c\u02f4\u0312\u02f8\u02f6\u02e8\u0306\u02f7\u030b\u0316\u030a\u02df????\u02d3\u0301??\u02f0\u030a\u0300\u02f1\u02d3??\u0300??\u0316\u0311\u02f8\u02f5????\u02ff\u02f5\u02d7\u0313\u0301\u0315????\u0300??\u0316\u0314\u0301\u0305????\u0301\u030c\u02e8\u0306\u0303\u02f3\u0316\u030e\u0301??\u02ef\u02df\u02f1\u02f5??\u0306\u02f8??\u02f3\u02df\u02ef\u030b\u030a??\u0300\u02f5??\u0315\u02df??\u030a??\u0300??\u0316\u0311\u02f8\u02f5????\u02ff\u02f5\u02d7\u0313\u02df??\u02f0\u02d3\u0301\u02e5\u02f3\u02df\u02f0??\u02f4??\u02f4\u02e6\u030a\u0315\u02f8\u02f3\u02f8\u0317\u0300????\u02e7\u02f7\u02f5\u02d3\u0309\u0300\u02e5\u02f3\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f4\u02f0\u02d3\u0301\u02e5\u02f4\u02e7\u02f7\u02f5\u02d3\u0309\u0300\u02e5\u02f3\u02df\u02f4\u02e5\u02d7??\u0301\u030c\u02e8\u0306\u0303\u02ef??\u0306\u0305\u030f\u02ef\u02df\u02f3\u030b\u02f4\u0318\u0300??\u02f4\u0317\u02f7??\u02f4??\u02f7\u02f5\u02d3\u0306\u02f8??\u02f4\u0317\u02df????\u02d3\u0301??\u02f0\u030a\u0300\u02f1\u02d3\u02f1\u02f8\u02f6??\u0314\u0302\u02f6\u02e8\u0308\u02f8\u02f6\u02eb\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u0309\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02e8\u030a\u02f8\u030b\u0316\u030a\u02f7??\u02f0\u030e\u0300??\u02d2\u02df\u02f0??\u02f4??\u02f2??\u02e8\u030f\u02f8\u02f5????\u02df??\u02d5??\u0312\u02df??\u0317\u02f8\u02f6??\u0304\u0300\u030b??\u0312\u02f8\u02ef??\u0315\u0301\u030b\u02d7\u030f\u02f6??\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02f1\u02f3????\u0301??\u02f0\u0314\u0300\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02f4??\u0317\u0300??\u02f8\u030e\u02f8\u02e5\u02f4\u0317\u02df??\u030a\u0313\u0302??\u02eb\u0317\u02df??\u030a\u0313\u0302\u02e5\u02f4\u0317\u02f7\u02f5????\u02ff\u02f5\u02d7\u0313\u02df????\u0306\u0300\u02e5\u0316??\u0303\u02f3\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02ef????\u0311\u0300??\u02f0\u02d3\u0301\u02e5\u02f3\u02df\u02f0\u02f5\u02d3??\u02ff\u02f6\u02e8\u0314\u0300\u030b??\u030a\u0300\u030c\u02ef\u02df\u02f0\u02f6\u0306\u030e\u0302\u02df????\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f4\u0304\u02f4\u02e5\u02f4\u02d2\u0302??\u02e8\u0314\u0303\u02df??\u0317\u02f8\u02f6??\u0314\u0302\u02f6\u02e8\u0308\u02f8\u02f4\u02d7\u0313\u02f7\u02f5??\u030a\u02df\u02ed\u030b??\u0313\u0303\u02ed??\u0310??\u02d7\u0315\u02f7\u02f6\u02e8\u0306\u0300\u02ef??\u0315\u0301\u030b\u02d7\u030f\u02f8\u02f5????\u02f6??\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02d2\u02f7\u02e9\u0318\u02d2\u02f7\u02e9\u0312\u02df??\u02f8\u0306\u0300\u02e6\u02f4\u030a\u02f4\u02e6\u030a\u0315\u02f8\u02ef??\u0306\u0305\u0310??\u0306\u0305\u0310\u02eb\u02df\u02d2\u02f7\u02e9\u030d\u02df\u02ed\u02e5??\u0311??\u02e5??\u030d\u02df??\u0306\u0305\u0310\u200c??\u02f8??\u02f4??\u02f6??\u0302\u030e\u02f8\u02e6\u02f0\u030d\u02df\u02e5\u0302\u030a\u0302??\u02d7\u02e7\u02f8\u02f5\u030a\u030c\u02ff\u02e6\u02ef\u02df\u02f4\u02e5\u0306\u0317\u02f8\u02f5??\u0309\u02df????\u02d3\u0301??\u02f0\u030a\u0300\u02f1\u02d3\u02f3\u02ff\u02e6\u02e8\u030a\u02f7\u02f5\u02f0\u030e\u0300\u030b\u0301\u02df\u02f3??\u0316\u030a\u02f8\u02f6\u200c??\u02d2\u02f7\u02e9\u0308\u02df\u02ed\u02e5??\u0314\u02df??\u0306\u0305\u0310\u02eb\u02df\u02d2\u02f7\u02e9\u030a\u02df??\u030a??\u0300????\u0315\u02f7\u02f6\u02e8\u0306\u02f7\u030b\u0316\u030a\u02f7????\u02df\u02f1\u02f4??\u030a\u0301\u030b\u030a\u0306\u0300\u02e5\u030a\u02d4\u02f7\u02f5\u02e8\u0311\u02f8\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f1\u02d3\u02f2\u02f8\u02f6\u02e8\u030e\u02f7\u02f5\u0316\u030e\u0303\u030b????\u02ff\u02f5\u02d7\u0313\u02df??????\u0301\u030b\u030a\u0313\u02f8\u0315??\u02f2\u0302\u02e6\u02e8\u030e\u0300\u030b\u0302??\u0302\u02f5\u030a\u0311\u02f8\u02e5\u02f4\u0317\u02df????\u0315\u0301\u02e5\u02f4\u0313\u02f8\u02df??\u02f3\u0300??????\u0301\u030b\u030a\u0313\u02f8\u0315??\u030c\u02f8\u02f6\u02f0\u0304\u02f2\u02e5\u02f4\u0313\u02f8??\u02f0\u030d\u02df??\u02f8\u0317\u0300??????\u0301\u030b\u0302\u0307\u02df\u02e5\u0302\u030a\u0302??\u02d7\u02f1\u02df\u02e5\u0302\u030a\u0302??\u02d7\u02e6\u02df\u02e5\u0302\u030a\u0302??\u02d7??\u02df??\u030a\u0313\u0301??\u02f4\u0317\u0302??\u02e8\u0306\u0300\u030b\u0302\u030a\u02df\u02ed\u02e5??\u0311??\u02e5??\u030e\u02df??\u02e6\u02f8\u02f6\u02f0??\u0300\u030c\u02f0\u0317\u0303\u02f3??\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02df??\u02d7??\u0301????\u030a\u0300\u02f5\u02e8\u0311\u0303\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f1\u02d3\u02e8\u0300\u030c\u02f0\u030a\u0301\u030b\u02d7\u0315\u02f3??\u02f4\u0317\u0302\u030b\u030a\u0308\u02f8\u02f6\u02eb\u02df\u02f2\u02e5\u02d7\u0306\u02f8\u02df??\u0306\u0305\u0310??\u0306\u0305\u030f\u02eb\u02df\u02d2\u02f7\u02e9??\u02df\u02ed\u02e5??\u0310\u0303\u02e5??\u030e\u02ef????\u02ff\u02f6\u02f0??\u0300??\u02d3??\u02f8\u02f6\u02e8??\u02f8\u02f6\u02e7\u02df\u02f4\u02e5\u02d7\u02e8\u0300\u030c\u02ef\u0318\u02eb\u0305??\u02e6\u02f8\u02f6\u02f0??\u0303\u02f6\u02f0\u030a\u0301\u0315??\u0306\u0305\u030f??\u0306\u0305\u030f??\u02df\u02f8??\u02f4??\u02f6????\u02f2\u02ef??\u030a\u02e8\u02df\u02e5\u02d7\u0315\u02f6??\u030a\u0313\u02f8\u02f6????\u02f7\u02f5\u0316\u030e\u0302\u02e6\u0309\u02df\u02f3\u030b\u02f4\u0306\u02f8\u02df??\u02e6\u02f8\u02f6\u02f0\u02ef\u02ff\u02f6\u0306\u030a\u0300\u02df??\u030c\u02f8\u02f6\u02f0\u0304\u02ef??\u02d7??\u0300\u030c\u02ef\u02df\u02ef??\u02d7\u0313\u02f7??????\u02df????\u0306\u02eb\u200c??\u0306\u02e7\u02f2??\u02df\u02ef??\u02d7\u0312\u0301\u02e5\u030a\u0311\u02f7\u02f6\u02f0\u030e\u0300??\u02d3\u02f1\u02f8\u02f5\u0316\u0306\u0303\u02e5????\u02ff\u02f5\u02d7\u0313\u0301??????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef??\u02f1\u0302\u02f5\u02d3??\u02ff\u02f5??\u030a\u02ef??\u02d7\u0312\u0301\u02e5????\u02ff\u02f5\u02e8\u030e\u0300\u02e5\u030a??\u0303\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef????\u0301????\u030a\u0300\u02f5\u02e8\u0311\u0303\u02f4\u02f0\u030e\u0302\u02e5\u0316\u030a\u02ef\u02f6\u02f0??\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02df????\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02f0\u02e5\u02f4\u0318\u02f7??\u02e8\u030e\u0301\u02e6\u02f0\u030e\u0300??\u02d3??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u030a??\u0300??\u02d3\u030b\u02ff\u02f5\u0302??\u0301\u030b????\u02ff\u02f5\u02d7\u0313\u02ef\u02f6\u02f0??\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02df????\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02ef??\u02d7\u0312\u0301\u02e5??\u0313\u0303\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef????\u0301????\u030a\u0300\u02f5\u02e8\u0311\u0303\u02f4??\u0317\u0300??\u02f0??\u02f7??\u02f0??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u030a??\u0300????\u02d3\u0301\u030b\u030a\u030c\u02ff\u02e6\u02f0??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u030a\u02f3\u0301\u030b??\u0309\u02f8\u02f5??\u0306\u0301\u030b\u0312??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef??\u02d7\u0312\u02f4\u030b\u030a\u0318\u02ff\u02f5\u02e8\u0311\u02f8\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef??\u02e6\u0302\u02f5\u030a\u0309\u02ef\u02f6\u02f0??\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02df????\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02f0\u030b\u030a\u0311\u02f8\u02f4\u02f8\u030a\u0301\u030c??\u030e\u0300??\u02d3??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02f3??\u02f4\u0315\u0301\u02e6\u02e8\u030a\u0301????\u02e8\u0300\u02e5\u02f0\u0306\u0301??????\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df??\u030d\u02df\u0303\u0307\u0316\u030f\u0318\u0300??\u0303\u0318\u0311??\u02d2\u0313\u02e7??\u0316\u030f\u0303\u200c??\u02e7\u0312??\u030e\u0301\u02f4\u0306\u0309??\u02d2\u02e7\u0309\u02e7\u0311??\u02d7\u0304\u0304\u0316\u02e6\u02f4??\u0308\u030d\u02e6\u200c??\u02e7????\u0305??\u02f0??\u02ef\u02eb\u200c??\u02df??????\u0306??\u02eb\u02df\u0315\u02f7\u0302\u02df\u0316\u030d\u02e6????\u02e7\u02f8??\u0305??\u02e7\u02e6??\u0315\u0301??\u02df\u0305\u02e7??\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0315\u0305\u02e7\u02e6\u02ef\u02eb\u02e7??\u02df\u02f3\u0305\u02df\u02ef??\u0302??\u02ef\u02e7\u0302??\u02ef\u02ef\u02e9\u02df\u02f0\u02e7\u02f8??\u0317\u02df??\u02df\u02f0\u02e7\u02f8??\u02f1\u0309??\u02e7\u200c??????\u0305\u02df??\u02e6\u02ef\u02f3\u0302??\u02f0??\u02e6????\u0315\u02e7\u02e6\u02ef\u02f3\u02e7??\u02df\u02e7??\u02e6\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02f3\u02e9\u02df\u0305\u02d2\u02f1\u02eb\u02ef\u02eb\u02e9\u02df\u02ef\u02d2\u02e8??\u02df????\u02df\u02f0\u02df\u0302\u02e6\u0305\u02df\u02e7\u02df\u0315\u030d????\u02ef\u0301\u200c??\u0306????\u02e6\u02ef\u02f3\u02ed??\u02ef\u0301\u02ed??\u0308\u02f3\u02e7??\u02df\u0305\u02e7??\u02f2\u0309??\u02df\u0305\u02e7\u02f1??\u02ef\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02ef\u02e9\u02df\u02f0\u02e8????\u02df\u030d????\u0309\u02f3????\u0305??\u02f1??\u02ef\u02f7\u02e9\u02df\u0306\u02e7\u02d7??\u0309\u0309\u02e5\u200c????\u02f1\u02f2\u02f0??\u02f0??\u0307\u02df????\u0305??\u02f1\u02f2\u02ef\u02f7\u200c??\u02f0??????\u0309\u02f3\u02e8??\u0315\u02f3\u0301??\u0309??\u02e7??????????\u02df\u030d????\u0305\u02d2\u02e5\u02e7\u02df\u02e7????\u0306\u02e8\u02f8????\u02df??\u02e6\u02df\u02d2\u02e5\u200c??\u02e7\u02f1\u02f0\u02ef\u02d2\u02ed??\u0315\u0301\u02ea??\u0309??\u0301??\u0305??\u02f1??\u02f0\u02e8\u0302\u02e6??\u0315\u02e7????????\u02e6\u02ef\u02eb????\u0305\u02e7\u02ed\u02e6\u02df\u0309\u02df????\u0315\u0301??\u0306??\u030e\u02e6\u02f0\u0315??\u200c????????\u02df\u02f7\u200c??\u0315??\u02ed??\u0305\u02d2????\u0306??\u02f3??\u0315\u0301\u02e6??\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0316????\u02df\u0306\u02d2\u200c??\u0317\u200c????\u02df\u0305\u02ef\u02df\u02ef\u02eb\u02e7\u02e6\u0305\u02df??\u02df\u0315\u0311\u02e6??\u02df\u0305\u02e7??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u02e7??\u02df\u02f7\u200c??\u0315??\u02e7??\u02df\u02eb????\u0306\u02e7??\u02df\u0315\u02f7\u02f0\u02e7??\u030d\u02e6??\u02ef\u0305\u02e7\u02e6??\u02f3\u02f1\u0303\u02ef??\u02ed??\u030c??????\u02df\u0305\u02e7????\u0315\u0301??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02e7\u0302\u02df\u0315\u02e7\u0302??\u0305\u02f7\u0305\u02df\u02f0\u02e9\u02df\u0306\u02ef\u02eb??\u02e7\u200c??\u02ed??\u200c??????\u0306\u02e8????\u02df\u02f3\u02e7??\u0305\u0301\u02e6??\u02df\u0305\u02e7??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u02e7??\u02df????????\u02d2\u02df??\u02df\u0305\u02ed??\u0315\u0305\u02e7??\u02f2\u0309\u02f0\u02ed\u02ef\u0305\u02e7????????\u02e6\u02ef\u02eb\u02e7\u200c??\u02ef\u02f0\u02ed\u02ef\u0305\u02e7??\u02df\u0305\u02e9\u200c??\u02f7\u02f0\u02ed\u02ef\u0305\u02e7??\u02df\u0305\u02e5\u02df\u0315\u0311\u02e6??\u0315\u0305????\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02eb\u0305\u200c??\u02f3\u02e7\u200c??\u02eb????????\u02d3\u02df\u0315\u02eb\u02eb??\u0315\u0305\u02e7??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u0305\u02e7\u02df\u0306\u02d2????\u0307\u02df??\u02df\u02ef\u0305\u02f1\u02f1\u02ef\u0311\u02ef\u02df\u0305\u02f3??\u02e6\u0305\u02df\u02e7\u02e6\u0305??\u02e7??\u02df\u0305\u02e6??\u02ef\u0305\u0301??\u02df\u0305\u0302\u02df\u0315\u02ef\u200c????\u02e8\u02f8??\u0305\u02df????\u030a\u0309????\u02df??\u02e6??\u0315\u0305\u02f1\u0305\u02e7\u0309\u02e7??\u02df\u0305\u0302\u02df\u0316??????\u0305\u02df????\u030a\u0309\u0302??\u02ef\u0305\u200c??\u0316\u02e8\u02f8\u02e6\u02ef\u02f3??\u02df\u0315\u0309\u02e6??\u02f0\u0315\u02e7????????\u02e6\u02ef\u02eb\u02eb??\u0315\u0305\u02e7??\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0316??????\u0305\u02df????????????\u02df\u0305\u02df??\u02df\u0305\u0302??\u02ef\u0305\u02e5\u02df\u0315\u030d\u02e6??\u0315\u0305\u0301??\u02df\u0305\u02e7??????????\u02f1\u02df??\u02e6\u02ef\u02f3\u02ed??\u0316\u02df??????????\u02e6\u0305??\u0303\u200c??\u02eb\u02e5??\u0305\u0301\u02e5????\u0315\u02e7????????\u02e6\u02ef\u02eb??\u200c??\u02df\u02f1\u02eb\u02ef\u02f7\u200c??\u0306\u02e7\u0316\u02df\u0315\u0305\u02e9??\u0315\u0301\u02e7\u02df\u0305\u0305\u02e7??\u02df\u0305\u0302\u02df\u0315\u0301\u200c??\u0305\u02e7\u02f0\u02ed\u02f0??\u02d3??\u02ef\u02df??\u02df\u0306??\u02d3??\u02f2\u0309\u02e5??\u0305\u02d2\u02ef\u02df\u0305\u02f7\u0301\u02e6\u0305??\u0303\u02df????\u030e\u02e6\u02f0\u0315\u02e7\u02df\u0315\u0301\u0305\u02df\u0315\u0305\u0302??\u02ef\u0305\u02e7????\u02df????\u0305\u0305\u0303\u02df????????\u02df\u0305\u02e7??\u0305\u02f7\u0305\u02df\u0306??\u02d3??\u02df\u0305\u02ea??\u02df??????\u02f2\u0309\u0303\u200c??\u0305\u02e7\u02df\u0315\u0305\u02e7??\u02df????????\u02d2\u02df??\u0305\u02f7\u02eb??\u0315\u0305\u02e7\u02e6\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0316??????\u02ef\u02df????\u0305\u02d2\u02ed??\u0306\u02df????\u02df\u02d2\u0303\u02df\u02f0\u02d2\u200c??\u0315\u02eb??\u02e7\u02df??????\u02df\u0305??\u200c??\u0305\u200c??\u200c??\u200c????\u02d2??\u200c????\u02df\u02f4\u02df\u02e7\u02f5\u02f4??\u02e8\u0306\u0301??\u02d3\u0314\u0300\u0309\u02f4\u02d2\u02f7??\u02f4\u0315\u0302\u02e5\u030a\u0314\u0300\u030a\u02f0\u030d\u0301\u030b\u02d7??\u0301\u0315????\u02e7\u02df??????\u0306\u02d2??\u02df??\u030a??\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f3\u0305\u02f0\u030c\u02e8\u0306\u0300\u02f5\u02f4??\u0300??\u02e8\u0310\u02e7????\u0305\u02f4\u02f3\u0309\u0305\u02f2\u02e5\u030a\u0307\u200c??\u02df\u0305\u02df\u02ef\u02df\u0300\u02ef??\u02f4\u0318\u0302\u02e5\u02d7\u0312\u02e7??\u02e8??\u0300\u030b\u030a\u030b\u0302\u02f1\u02df\u0313\u02f2\u0309\u02f4\u02f3\u02e7\u02e5??\u0314\u0300\u030c\u02f0\u0317\u0300??\u0316\u0318\u200c??\u02df??\u02df\u02ef\u200c??\u200c??\u02df\u02f7\u02df\u02ef\u02df\u02f2\u02ef\u030c\u02f4\u0313\u02ff\u02f5\u02f8??\u02e7??\u02f0\u030a\u02f7??\u0306\u0313\u0300??\u0316\u0314\u02f8??\u030a\u030a\u0301\u0315\u200c????\u0305??\u02df??\u02f3\u02e8??\u0300\u030b\u030a\u030b\u0302\u02f1??\u02f4\u02f1\u02ef\u200c????\u0315??\u02df??\u0309??\u0314\u0301\u02e6\u030a\u0317\u02ff\u02f5\u0302\u030d\u0302??????\u030f\u02f1\u02df\u0305\u02eb\u0308\u02df\u0316??\u0305\u200c??????\u02df??\u02df\u02ef\u02e7\u030e\u02df\u02ef\u02df\u0309\u02ed\u02f5\u02f8\u0307\u02ed??\u02e7\u0315??\u030b\u02f3\u0312????\u02df\u0315\u02f8\u0307????\u02eb\u0318\u02f7\u0315\u02ea\u02f2\u0309????\u0318\u0309\u0312\u02eb??\u0309??\u02eb\u02f2??\u0306????\u02e8\u030b\u02f7\u02f2\u02f7??\u200c??\u02df\u02eb\u02df\u02ef\u02df\u02e6\u02eb\u02f1\u02d2\u0318\u02ea\u0308\u02df\u0313\u02eb\u200c??\u02df??\u02df??\u200c??\u02df??\u0309\u02f4\u0315\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??????\u02f4\u0315\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02d6??\u0301\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u0304\u02ef??\u02d7\u0317\u02f0\u02e5\u0316\u0311\u02f2\u02f5??\u030e\u0300\u0305??\u0312\u0301????\u0314\u0301\u030b\u02f4\u030a\u02ea\u030b\u02f0\u0311\u0300\u200c??\u200c??\u200c??\u02df??\u0317\u02f3\u02df\u02e7??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u02df??\u200c??\u200c??\u02df\u02f7\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c????\u200c??\u200c??\u0315\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u200c????\u02e7\u200c??\u200c??\u02f5\u02e5\u200c??\u02df\u02e8\u02ef??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02e8\u02ef????\u200c??\u200c????\u02f7\u02df\u02f3\u0315??\u0304\u02df??\u02f7\u02df\u02f0\u02ef??\u02f1\u02df??\u02eb\u02df\u02f1\u02ef????\u02df??\u02d2\u02df\u02f6\u0315??\u02e8\u02df??\u02d2\u02df\u02f0\u0305????\u200c??\u200c??\u200c????\u02d7??\u02ed????\u200c??\u02df??\u200c??\u02eb\u200c??\u02ef\u200c??\u200c??\u200c??\u02df\u0315\u02df??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u02ef\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02f0\u200c??\u200c??\u02df??\u02df\u02f4\u0305??\u0306\u02df\u02e6\u02e7\u02df\u02f0\u0305??\u030e\u02df\u02e5\u0315\u02df\u02f8\u02ef??\u02e8\u02df\u02e5\u02d2\u02df\u02f8\u0305??\u0314\u200c??\u200c??\u200c??\u02df\u0309\u200c??\u02ef\u200c??\u02df??\u02f3\u02df\u02e6\u02e7\u02df\u02f7\u02ef??\u0313\u02df\u02e6\u02eb\u02df\u0300\u02df??\u0306\u02df\u02e6\u02ef\u02df\u02ff\u02ef??\u0314\u02df\u02e5\u02d2\u200c??\u200c??\u200c??\u200c??\u02df\u0311\u02df\u02f2??\u02df\u0305\u200c??\u02df\u02ef??\u02f2\u02df\u02e6\u02ef\u02df\u0301\u0305??\u030e\u02df\u02e5\u02d2\u02df\u02f8\u0315??\u02e5\u02df\u02e5\u0309\u02df\u0300\u02df??\u030a\u02df??\u0309\u02df\u0300\u0305??\u030b\u02df\u02e5\u02d6\u200c??\u02df??\u02ef\u02df\u0305\u200c??\u02df\u02ef\u02df\u0315\u02df??\u200c??\u02eb\u200c??\u0315\u02df??\u200c????\u02df??\u0307\u02df??\u200c??\u200c????\u02ef\u02df??\u0315\u200c??\u02ef????\u02df\u02e5\u02d6\u02df\u0300\u02ef??\u0312\u02df\u02e5\u02f3\u02df\u0300\u0305????\u02df\u02e6\u02eb\u200c??\u02df????\u02df\u02e6\u02f3\u02df\u0301\u0315????\u02df\u02e5\u02d6\u02df\u0300\u02ef\u02df\u0305\u02df??\u02e7\u02df\u0302\u02ef??\u0313\u02df\u02e5\u0309\u02df\u02f8\u0305????\u02df??\u200c??\u02ea\u0305??\u02ed\u02df??\u02f3\u02df\u02f4\u200c??\u0305\u02df\u02e5\u02eb\u02df\u0300\u0315??\u0313\u02df\u02e6\u02ef\u02df\u0301\u0305??\u0314\u02df\u02e5\u0315\u02df\u0301\u0315\u200c??\u02df??\u0305\u02df??\u200c????\u02df??\u02eb\u02df\u0300\u0315??\u0312\u02df\u02e6\u200c??\u02f7\u02ef??\u0313\u02df\u02e6\u0309\u02df\u02f2\u0305??\u0306\u02df\u02e5??\u02df\u02f8\u02ef\u200c??\u200c??\u200c??\u02ef\u0305????\u02df\u02e5\u02d2\u02df\u02ff\u02ef??\u030b\u02df\u02e6\u02f3\u02df\u02e7\u02df??\u02f3\u02df\u02e5\u02f3\u02df\u02f7\u0315??\u030d\u02df\u02e5\u02d2\u02df\u0300\u0315??\u0311\u02df\u02e5\u02d6\u02df\u02f8\u0315??\u030e\u02df\u02e5\u02f3\u02df\u0301\u0315\u200c??\u02df??\u0315\u02df\u02e5\u0305\u02df??\u02df??\u02f7\u02df\u02ff\u02ef??\u0311\u02df\u02e5\u02f3\u02df\u02f0\u02df??\u030a\u02df\u02e6\u02eb\u02df\u02f7\u0315??\u0317\u02df\u02e5\u0309\u02df\u0301\u02df????\u02df\u02e5\u0309\u02df\u0300\u0315??\u0313\u200c??\u200c??\u200c??????\u02df\u02e6\u02f3\u02df\u0300\u0305??\u030e\u02df\u02e5\u02f7\u02df\u0302\u02ef\u02df\u0305\u02df??\u02f7\u02df\u0301\u0305??\u0306\u02df\u02e5??\u02df\u02f8\u02ef????\u02df\u02e5\u02d6\u02df\u0301\u0305??\u0310\u02df??\u200c??\u02ea\u02ef\u02df\u0305\u02df??\u02f3\u02df\u02f1\u02ef\u02df\u0305\u02df??\u0315\u02df\u02ff\u02ef??\u0307\u200c??\u200c??\u02eb\u200c??\u02e7\u200c????\u02df\u02f0\u0305??\u030e\u02df\u02e5\u0315\u02df\u02f8\u02ef??\u02f5\u02df\u02e5\u02f3\u02df\u0301\u0305??\u0318\u02df\u02e5\u0309\u02df\u0300\u0315??\u0313\u200c??\u200c??\u200c??\u02df\u0316\u02df??\u02d2\u02df\u02eb\u0315\u02df\u0313\u02df??\u200c??\u02ea\u0305\u02df\u0315\u200c??\u200c????\u200c??\u02ed\u200c????\u02df\u02f1\u02ef??\u0313\u02df\u02e6\u02ef\u02df\u02f8\u02ef??\u0317\u02df\u02e5\u02d2\u02df\u02f7\u02ef??\u0311\u02df??\u02d2\u02df\u02f7\u02ef??\u0312\u02df\u02e5\u02f3\u200c??\u02df????\u02df\u02e6\u02f3\u02df\u0300\u0305??\u030e\u02df\u02e5\u02f7\u02df\u0302\u02ef\u02df\u0313\u02df??\u02f3\u02df\u02f1\u02ef\u02df\u0313\u02df\u02e5\u02ef\u02df\u0300\u02df??\u0311\u200c??\u200c??\u02f1\u200c??\u02f1\u200c????\u02df\u02f2\u02df??\u030a\u02df\u02e5\u0301\u02df\u02f7\u02ef??\u0311\u02df??\u02eb\u02df\u0300\u0315??\u0315\u02df\u02e6\u0309\u02df\u0301\u0305??\u030e\u02df\u02e5\u0301\u02df\u02ff\u02df????\u200c??\u200c??\u02ef\u0315??\u0314\u02df\u02e6\u200c??\u0303\u02ef??\u0317\u02df\u02e5\u0309\u02df\u02f8\u0315??\u030d\u02df\u02e6\u02ef\u02df\u02e7\u02df??\u030e\u02df??\u200c??\u02e7\u200c??\u0317\u02df??\u200c??\u02eb\u02ef\u02df??\u200c??\u200c??\u02e9\u0305\u02df??\u200c????\u02df\u02f2\u02df??\u030a\u02df\u02e5\u0301\u02df\u02f7\u02ef??\u0311\u02df??\u02ef\u02df\u0301\u0305??\u0306\u02df\u02e5\u02ef\u02df\u02f8\u02ef??\u0312\u02df\u02e5??\u02df\u0301\u0305??\u0310\u02df\u02e6\u02eb\u200c??\u200c??\u200c??\u200c??\u200c??\u02df????\u200c??\u02d2\u200c??\u02ef????\u02df\u02e6\u02e7\u02df\u02ff\u02ef??\u030c\u02df\u02e5\u0309\u02df\u0300\u0305??\u0306\u02df\u02e5\u0315\u02df\u02f0\u0305??\u030e\u02df\u02e5\u0315\u02df\u02f8\u02ef??\u0313\u02df\u02e5??\u02df\u0300\u02ef??\u030a\u200c??\u200c??\u02ef\u0305????\u02df\u02e5\u02d2\u02df\u02ff\u02ef??\u030b\u02df\u02e6\u02f3\u02df\u02ea\u0305??\u02f4\u02df??\u0309\u02df\u02ea\u0305??\u0309\u02df\u02e5\u0315\u02df\u0300\u200c??\u200c????\u02ef\u02df??\u0305\u02df??\u02df??\u200c??\u0301\u0305??\u0314\u02df\u02e5\u02ef\u02df\u0302\u02ef??\u0308\u02df\u02e6\u02ef\u02df\u02f2\u0305??\u0306\u02df\u02e5??\u02df\u02f8\u02ef\u200c??\u200c??\u200c??\u02ef\u0305????\u02df\u02e5\u02d2\u02df\u02ff\u02ef??\u030b\u02df\u02e6\u02f3\u02df\u02e7\u02df??\u02f4\u02df??\u0309\u200c??\u200c????\u200c??\u0305\u200c??\u02ef??\u02ef\u02df\u02e6\u02e7\u02df\u0300\u0315??\u0309\u02df\u02e6\u02f3\u02df\u02f7\u0315????\u02df??\u02f7\u02df\u02f8\u02ef??\u0317\u02df\u02e6\u02eb\u02df\u02ff\u02ef??\u0314\u02df\u02e5\u02d2\u200c??\u200c??\u0316\u02df??\u02d2\u02df\u02eb\u0315\u02df\u0313\u02df??\u200c??\u02ea\u0305\u02df\u0315\u200c??\u200c??\u02ed\u200c??\u02e7\u200c????\u02df\u02ef\u02ef??\u0318\u02df\u02e6\u02eb\u02df\u02f8\u02ef??\u0312\u02df\u02e5\u02e7\u02df\u0300\u02df??\u02d3\u02df??\u200c??\u02f4\u0305??\u030a\u02df\u02e6\u02e7\u02df\u0301\u0315??\u030e\u02df\u02e5\u02d6\u02df\u0300\u0305\u200c??\u02df????\u02df\u02ea\u0305\u02df\u0318\u02df??\u02d2\u02df\u02eb\u200c??\u0313\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02ef\u200c??\u02df\u02eb\u200c??\u200c??????\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df", "\u200c??", "\u02df\u02df");
					string string_ = smethod_4(text);
					obj = GForm1.smethod_78(smethod_6(GForm1.smethod_77(string_)));
					num = (int)(num2 * 70415507) ^ -1064321922;
					continue;
				}
				case 2u:
					result = text;
					num = (int)((num2 * 614111760) ^ 0x10A2E798);
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
		object result = default(object);
		while (true)
		{
			int num = 122938668;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE109D01u) % 12u)
				{
				case 10u:
					num = (int)((num2 * 375496857) ^ 0x189CBF7E);
					continue;
				case 9u:
					num = (int)((num2 * 495815853) ^ 0x6A86416A);
					continue;
				case 8u:
					num3 = 251367199;
					num = ((int)num2 * -2094226650) ^ -608262511;
					continue;
				case 7u:
					result = GForm1.smethod_79(char_0, 0, 22528);
					num = (int)(num2 * 2000728580) ^ -909027461;
					continue;
				case 5u:
					num = (int)(num2 * 681727873) ^ -630218654;
					continue;
				case 4u:
					num3 = 251367175;
					num = 1656037018;
					continue;
				case 3u:
					num3 = 251367192;
					num = (int)((num2 * 1484384833) ^ 0x8753A98);
					continue;
				case 2u:
				{
					int num4;
					if (num3 != 251367153)
					{
						num = 1783710449;
						num4 = 1783710449;
					}
					else
					{
						num = 963341638;
						num4 = 963341638;
					}
					continue;
				}
				case 1u:
					num3 = 251367135;
					num = 0x60CA1DB4 ^ ((int)num2 * -795425229);
					continue;
				case 0u:
					num = ((int)num2 * -635092396) ^ 0x68E0DCB4;
					continue;
				case 11u:
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
		smethod_2((Assembly)object_0);
		object result = default(object);
		return result;
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
