using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cytotechnologist;

public class Form4 : Form
{
	private IContainer components = null;

	private TextBox textBox1;

	private TextBox textBox2;

	private TextBox textBox3;

	private Button button1;

	private ErrorProvider errorProvider1;

	public Form4()
	{
		while (true)
		{
			int num = -1347441231;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B67E8CFu) % 5u)
				{
				case 2u:
					num = ((int)num2 * -564014304) ^ 0x4B231E32;
					continue;
				case 1u:
					num = ((int)num2 * -1057613443) ^ 0x77A1B363;
					continue;
				case 0u:
					InitializeComponent();
					num = (int)(num2 * 527574621) ^ -1826318689;
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

	private void Form4_FormClosing(object sender, FormClosingEventArgs e)
	{
		Form4.smethod_1((Control)(object)Form4.smethod_0((Form)(object)this), bool_0: true);
	}

	private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1256818100;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E2E6BAEu) % 6u)
				{
				case 4u:
					flag = Form4.smethod_2(e) == ' ';
					num = (int)(num2 * 926838101) ^ -263292003;
					continue;
				case 3u:
					Form4.smethod_3(e, bool_0: true);
					num = (int)(num2 * 656315469) ^ -345386327;
					continue;
				case 2u:
					num = ((int)num2 * -381047311) ^ -822868352;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -756218400;
						num4 = -756218400;
					}
					else
					{
						num3 = -2097237451;
						num4 = -2097237451;
					}
					num = num3 ^ ((int)num2 * -968643991);
					continue;
				}
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

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox_TextChanged(object sender, EventArgs e)
	{
		Form4.smethod_4(errorProvider1);
		while (true)
		{
			int num = 1168218171;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x262118E4u) % 3u)
				{
				case 2u:
					goto IL_000d;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000d:
				num = (int)((num2 * 1359798388) ^ 0x7ED1746B);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (!disposing)
		{
			goto IL_0006;
		}
		goto IL_002d;
		IL_002d:
		int num = 1926228220;
		goto IL_0032;
		IL_0032:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x295DFC49u) % 4u)
			{
			case 2u:
				Form4.smethod_5((IDisposable)components);
				num = ((int)num2 * -416110996) ^ 0x6AF6ED3E;
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_0053;
			default:
				((Form)this).Dispose(disposing);
				return;
			}
			break;
			IL_0053:
			if (components != null)
			{
				num = 963199151;
				num3 = 963199151;
				continue;
			}
			goto IL_0006;
		}
		goto IL_002d;
		IL_0006:
		num = 492714038;
		num3 = 492714038;
		goto IL_0032;
	}

	private void InitializeComponent()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected O, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected O, but got Unknown
		components = Form4.smethod_6();
		while (true)
		{
			int num = -131677443;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC24C7AA8u) % 59u)
				{
				case 58u:
					Form4.smethod_10((ISupportInitialize)errorProvider1);
					Form4.smethod_11((Control)(object)this);
					num = (int)((num2 * 1709822810) ^ 0x3AF1388F);
					continue;
				case 57u:
					num = ((int)num2 * -207875156) ^ -441696447;
					continue;
				case 56u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)button1);
					num = ((int)num2 * -1856515054) ^ 0x5B04BF51;
					continue;
				case 55u:
					Form4.smethod_17((Control)(object)textBox3, new KeyPressEventHandler(TextBox_KeyPress));
					num = (int)((num2 * 1438848108) ^ 0x20B4D2F2);
					continue;
				case 54u:
					Form4.smethod_14((Control)(object)button1, new Size(70, 23));
					num = (int)((num2 * 946109367) ^ 0x44B75BF7);
					continue;
				case 53u:
					num = ((int)num2 * -46026345) ^ 0xE3415F6;
					continue;
				case 52u:
					Form4.smethod_17((Control)(object)textBox1, new KeyPressEventHandler(TextBox_KeyPress));
					Form4.smethod_12((Control)(object)textBox2, new Point(17, 33));
					num = ((int)num2 * -723215576) ^ 0x36B23EEF;
					continue;
				case 51u:
					textBox1 = Form4.smethod_7();
					textBox2 = Form4.smethod_7();
					num = ((int)num2 * -409765458) ^ 0x7F88E467;
					continue;
				case 50u:
					Form4.smethod_12((Control)(object)button1, new Point(52, 85));
					num = ((int)num2 * -901268952) ^ -2102027358;
					continue;
				case 49u:
					errorProvider1 = Form4.smethod_9(components);
					num = (int)(num2 * 1509024388) ^ -1274940422;
					continue;
				case 48u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox1);
					num = ((int)num2 * -1985302982) ^ -578014846;
					continue;
				case 47u:
					Form4.smethod_35((ISupportInitialize)errorProvider1);
					num = ((int)num2 * -304221727) ^ 0x12A55BD8;
					continue;
				case 46u:
					Form4.smethod_15((Control)(object)button1, 0);
					num = (int)((num2 * 1266862966) ^ 0x6C19A25);
					continue;
				case 45u:
					num = (int)((num2 * 1489535321) ^ 0xDB7E2FA);
					continue;
				case 44u:
					Form4.smethod_24((ContainerControl)(object)this, (AutoScaleMode)1);
					num = (int)((num2 * 1880737000) ^ 0x63A10B9B);
					continue;
				case 43u:
					num = ((int)num2 * -1660365704) ^ 0x59523E1D;
					continue;
				case 42u:
					num = ((int)num2 * -342725895) ^ -1229716210;
					continue;
				case 41u:
					Form4.smethod_13((Control)(object)textBox2, "textBox2");
					Form4.smethod_14((Control)(object)textBox2, new Size(140, 20));
					num = ((int)num2 * -685829106) ^ 0x45D8A97E;
					continue;
				case 40u:
					Form4.smethod_31((Control)(object)this, "Form4");
					num = (int)((num2 * 1902043154) ^ 0x67723C37);
					continue;
				case 39u:
					Form4.smethod_16((Control)(object)textBox2, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 959223285) ^ -1963316281;
					continue;
				case 38u:
					num = ((int)num2 * -658686744) ^ 0x69E15CD6;
					continue;
				case 37u:
					Form4.smethod_30((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1584870036) ^ 0x1262E329;
					continue;
				case 36u:
					Form4.smethod_13((Control)(object)textBox3, "textBox3");
					Form4.smethod_14((Control)(object)textBox3, new Size(140, 20));
					num = (int)((num2 * 1398012342) ^ 0x642EAA87);
					continue;
				case 35u:
					num = ((int)num2 * -2146388490) ^ 0x56025327;
					continue;
				case 34u:
					Form4.smethod_32((Form)(object)this, bool_0: false);
					num = (int)(num2 * 359968374) ^ -513086860;
					continue;
				case 33u:
					num = (int)((num2 * 1155877824) ^ 0x49AA8CB0);
					continue;
				case 32u:
					num = ((int)num2 * -1371984043) ^ 0x7F995134;
					continue;
				case 31u:
					num = ((int)num2 * -515263804) ^ 0x53AF0E9;
					continue;
				case 30u:
					Form4.smethod_12((Control)(object)textBox3, new Point(17, 59));
					num = (int)(num2 * 536559769) ^ -573542836;
					continue;
				case 29u:
					textBox3 = Form4.smethod_7();
					num = (int)(num2 * 1184758795) ^ -1109712042;
					continue;
				case 28u:
					Form4.smethod_19((Control)(object)this, "??????????????????????");
					num = (int)(num2 * 1052586142) ^ -1774868094;
					continue;
				case 27u:
					Form4.smethod_18(textBox3, bool_0: true);
					num = ((int)num2 * -1323200126) ^ 0x11D8C336;
					continue;
				case 26u:
					Form4.smethod_13((Control)(object)button1, "button1");
					num = (int)(num2 * 2041212850) ^ -500412155;
					continue;
				case 25u:
					Form4.smethod_15((Control)(object)textBox3, 3);
					num = ((int)num2 * -1916802900) ^ -1709158402;
					continue;
				case 24u:
					Form4.smethod_18(textBox2, bool_0: true);
					num = (int)((num2 * 926704523) ^ 0x4643F651);
					continue;
				case 23u:
					Form4.smethod_17((Control)(object)textBox2, new KeyPressEventHandler(TextBox_KeyPress));
					num = ((int)num2 * -1481675527) ^ 0x3E61E0DC;
					continue;
				case 21u:
					Form4.smethod_16((Control)(object)textBox3, (EventHandler)TextBox_TextChanged);
					num = ((int)num2 * -1196878508) ^ 0x4DB49705;
					continue;
				case 20u:
					Form4.smethod_33((Form)(object)this, bool_0: false);
					num = ((int)num2 * -1837808524) ^ 0xED377EE;
					continue;
				case 19u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox3);
					num = ((int)num2 * -663027294) ^ -1477800147;
					continue;
				case 18u:
					Form4.smethod_34((Form)(object)this, new FormClosingEventHandler(Form4_FormClosing));
					num = (int)((num2 * 1590970928) ^ 0x832C0);
					continue;
				case 17u:
					Form4.smethod_19((Control)(object)button1, "????????????????");
					num = ((int)num2 * -750647676) ^ -1199752717;
					continue;
				case 16u:
					Form4.smethod_16((Control)(object)textBox1, (EventHandler)TextBox_TextChanged);
					num = (int)(num2 * 1234308427) ^ -1684440926;
					continue;
				case 15u:
					num = ((int)num2 * -1101630449) ^ 0x6FC889DE;
					continue;
				case 14u:
					num = (int)((num2 * 441793210) ^ 0x14522920);
					continue;
				case 13u:
					Form4.smethod_15((Control)(object)textBox2, 2);
					num = ((int)num2 * -1752528148) ^ -880283439;
					continue;
				case 12u:
					Form4.smethod_20((ButtonBase)(object)button1, bool_0: true);
					Form4.smethod_21((Control)(object)button1, (EventHandler)Button1_Click);
					Form4.smethod_22(errorProvider1, (ContainerControl)(object)this);
					num = (int)((num2 * 329850760) ^ 0x1F465E03);
					continue;
				case 10u:
					Form4.smethod_29((Form)(object)this, bool_0: false);
					num = (int)(num2 * 2029526562) ^ -1949932563;
					continue;
				case 9u:
					Form4.smethod_15((Control)(object)textBox1, 1);
					num = (int)(num2 * 1565340630) ^ -1749125926;
					continue;
				case 8u:
					num = ((int)num2 * -1056671525) ^ -2143783611;
					continue;
				case 7u:
					Form4.smethod_23((ContainerControl)(object)this, new SizeF(6f, 13f));
					num = (int)(num2 * 53274379) ^ -1538108281;
					continue;
				case 6u:
					num = ((int)num2 * -380975653) ^ 0x4EEFDF0E;
					continue;
				case 5u:
					button1 = Form4.smethod_8();
					num = (int)(num2 * 732865121) ^ -510780768;
					continue;
				case 4u:
					Form4.smethod_28((Form)(object)this, (FormBorderStyle)1);
					num = ((int)num2 * -761091219) ^ -1653938747;
					continue;
				case 3u:
					Form4.smethod_25((Form)(object)this, new Size(176, 114));
					num = (int)((num2 * 555967161) ^ 0x133C312A);
					continue;
				case 2u:
					Form4.smethod_12((Control)(object)textBox1, new Point(17, 7));
					Form4.smethod_13((Control)(object)textBox1, "textBox1");
					Form4.smethod_14((Control)(object)textBox1, new Size(140, 20));
					num = (int)((num2 * 26421016) ^ 0x2E66D2D1);
					continue;
				case 1u:
					Form4.smethod_27(Form4.smethod_26((Control)(object)this), (Control)(object)textBox2);
					num = (int)(num2 * 660793548) ^ -1444957437;
					continue;
				case 0u:
					num = (int)((num2 * 866769479) ^ 0xEB5A19C);
					continue;
				case 11u:
					break;
				default:
					Form4.smethod_36((Control)(object)this, bool_0: false);
					Form4.smethod_37((Control)(object)this);
					return;
				}
				break;
			}
		}
	}

	static Form smethod_0(Form form_0)
	{
		return form_0.get_Owner();
	}

	static void smethod_1(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static char smethod_2(KeyPressEventArgs keyPressEventArgs_0)
	{
		return keyPressEventArgs_0.get_KeyChar();
	}

	static void smethod_3(KeyPressEventArgs keyPressEventArgs_0, bool bool_0)
	{
		keyPressEventArgs_0.set_Handled(bool_0);
	}

	static void smethod_4(ErrorProvider errorProvider_0)
	{
		errorProvider_0.Clear();
	}

	static void smethod_5(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_6()
	{
		return new Container();
	}

	static TextBox smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Button smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static ErrorProvider smethod_9(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new ErrorProvider(icontainer_0);
	}

	static void smethod_10(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_11(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_12(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_13(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_14(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_15(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_16(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_TextChanged(eventHandler_0);
	}

	static void smethod_17(Control control_0, KeyPressEventHandler keyPressEventHandler_0)
	{
		control_0.add_KeyPress(keyPressEventHandler_0);
	}

	static void smethod_18(TextBox textBox_0, bool bool_0)
	{
		textBox_0.set_UseSystemPasswordChar(bool_0);
	}

	static void smethod_19(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_20(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_21(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_22(ErrorProvider errorProvider_0, ContainerControl containerControl_0)
	{
		errorProvider_0.set_ContainerControl(containerControl_0);
	}

	static void smethod_23(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_24(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_25(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_26(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_27(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_28(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_29(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_30(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_31(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_32(Form form_0, bool bool_0)
	{
		form_0.set_ShowIcon(bool_0);
	}

	static void smethod_33(Form form_0, bool bool_0)
	{
		form_0.set_ShowInTaskbar(bool_0);
	}

	static void smethod_34(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static void smethod_35(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_36(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_37(Control control_0)
	{
		control_0.PerformLayout();
	}
}
