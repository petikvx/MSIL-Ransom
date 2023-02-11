using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ai;
using Li65S;
using Microsoft.VisualBasic.CompilerServices;
using Pe;
using Rt;
using g1H7G;
using g4T;
using i4;
using j7B0E;
using o9P1F;
using p9;
using s4;
using z2;

namespace Qj;

[DesignerGenerated]
public class k4 : Form
{
	private IContainer g;

	private TabControl y;

	private TabPage B;

	private Panel H;

	private Panel E;

	private Label v;

	private Label a;

	private Label i;

	private Label R;

	private Label C;

	private Label u;

	private Label l;

	private Button n;

	private Panel W;

	private Label o;

	private TabPage k;

	private TableLayoutPanel yy;

	private Panel yH;

	private Label yS;

	private Panel yE;

	private ComboBox yv;

	private TextBox yi;

	private Label yM;

	private Label yq;

	private TabPage yu;

	private TableLayoutPanel yx;

	private Button yl;

	private Panel yF;

	private Label yk;

	private Label Bg;

	private TextBox BB;

	private Label BS;

	private Label Bv;

	private DataGridViewTextBoxColumn Bq;

	private DataGridViewTextBoxColumn BJ;

	private DataGridViewTextBoxColumn Bu;

	private TextBox BP;

	private Label Bl;

	private Label BF;

	public string Bn;

	private object Bo;

	private p2W0F.Ci9s7 O = new p2W0F.Ci9s7();

	public k4()
	{
		//Discarded unreachable code: IL_0035
		Bn = Rc6.Yy4s1(6, 947755690, typeof(g5), ' ');
		g0();
	}

	protected override void Ai(bool P_0)
	{
		//Discarded unreachable code: IL_0075
		byte[] array = g5.I;
		try
		{
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num = ((!P_0) ? 7 : 0);
					continue;
				case 0:
					if (g != null)
					{
						num2 = 6;
						goto IL_0049;
					}
					goto case 7;
				case 7:
					num2 = 1;
					goto IL_0049;
				case 3:
				case 6:
					g.Dispose();
					break;
				case 2:
					break;
				case 1:
				case 4:
					return;
					IL_0049:
					num = num2;
					continue;
				}
				num = array[145] - 164;
			}
		}
		finally
		{
			((Form)this).Dispose(P_0);
		}
	}

	private void g0()
	{
		//Discarded unreachable code: IL_5ef3
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected O, but got Unknown
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected O, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected O, but got Unknown
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected O, but got Unknown
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected O, but got Unknown
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected O, but got Unknown
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected O, but got Unknown
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected O, but got Unknown
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected O, but got Unknown
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected O, but got Unknown
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Expected O, but got Unknown
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected O, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected O, but got Unknown
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected O, but got Unknown
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected O, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected O, but got Unknown
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected O, but got Unknown
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected O, but got Unknown
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected O, but got Unknown
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected O, but got Unknown
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected O, but got Unknown
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected O, but got Unknown
		//IL_084b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Expected O, but got Unknown
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected O, but got Unknown
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected O, but got Unknown
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Expected O, but got Unknown
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected O, but got Unknown
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected O, but got Unknown
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Expected O, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected O, but got Unknown
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Expected O, but got Unknown
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Expected O, but got Unknown
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected O, but got Unknown
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected O, but got Unknown
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected O, but got Unknown
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Expected O, but got Unknown
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Expected O, but got Unknown
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Expected O, but got Unknown
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected O, but got Unknown
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Expected O, but got Unknown
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Expected O, but got Unknown
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Expected O, but got Unknown
		//IL_097d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Expected O, but got Unknown
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected O, but got Unknown
		//IL_099c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a6: Expected O, but got Unknown
		//IL_09a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Expected O, but got Unknown
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bc: Expected O, but got Unknown
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected O, but got Unknown
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Expected O, but got Unknown
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected O, but got Unknown
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected O, but got Unknown
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Expected O, but got Unknown
		//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a16: Expected O, but got Unknown
		//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2d: Expected O, but got Unknown
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Expected O, but got Unknown
		//IL_0a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a43: Expected O, but got Unknown
		//IL_0a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a57: Expected O, but got Unknown
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Expected O, but got Unknown
		//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6d: Expected O, but got Unknown
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Expected O, but got Unknown
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected O, but got Unknown
		//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected O, but got Unknown
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Expected O, but got Unknown
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab9: Expected O, but got Unknown
		//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac4: Expected O, but got Unknown
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Expected O, but got Unknown
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Expected O, but got Unknown
		//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b08: Expected O, but got Unknown
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected O, but got Unknown
		//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Expected O, but got Unknown
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Expected O, but got Unknown
		//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3d: Expected O, but got Unknown
		//IL_0dbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Expected O, but got Unknown
		//IL_1040: Unknown result type (might be due to invalid IL or missing references)
		//IL_104a: Expected O, but got Unknown
		//IL_1068: Unknown result type (might be due to invalid IL or missing references)
		//IL_1072: Expected O, but got Unknown
		//IL_1084: Unknown result type (might be due to invalid IL or missing references)
		//IL_108e: Expected O, but got Unknown
		//IL_130c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1316: Expected O, but got Unknown
		//IL_13c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ce: Expected O, but got Unknown
		//IL_1571: Unknown result type (might be due to invalid IL or missing references)
		//IL_158d: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15be: Expected O, but got Unknown
		//IL_15e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_1624: Unknown result type (might be due to invalid IL or missing references)
		//IL_1636: Unknown result type (might be due to invalid IL or missing references)
		//IL_1640: Expected O, but got Unknown
		//IL_16b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16be: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1705: Expected O, but got Unknown
		//IL_1722: Unknown result type (might be due to invalid IL or missing references)
		//IL_1728: Unknown result type (might be due to invalid IL or missing references)
		//IL_173f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1758: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b76: Expected O, but got Unknown
		//IL_1c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c63: Expected O, but got Unknown
		//IL_1d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d4d: Expected O, but got Unknown
		//IL_1e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e37: Expected O, but got Unknown
		//IL_1f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f19: Expected O, but got Unknown
		//IL_1ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2008: Expected O, but got Unknown
		//IL_210d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2117: Expected O, but got Unknown
		//IL_2216: Unknown result type (might be due to invalid IL or missing references)
		//IL_2220: Expected O, but got Unknown
		//IL_22ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2309: Expected O, but got Unknown
		//IL_23ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f6: Expected O, but got Unknown
		//IL_24d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_24dd: Expected O, but got Unknown
		//IL_25bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c7: Expected O, but got Unknown
		//IL_26a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b1: Expected O, but got Unknown
		//IL_278e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2798: Expected O, but got Unknown
		//IL_285e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2868: Expected O, but got Unknown
		//IL_2886: Unknown result type (might be due to invalid IL or missing references)
		//IL_2890: Expected O, but got Unknown
		//IL_28a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ac: Expected O, but got Unknown
		//IL_292f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2962: Unknown result type (might be due to invalid IL or missing references)
		//IL_296c: Expected O, but got Unknown
		//IL_2a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7f: Expected O, but got Unknown
		//IL_2b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d26: Expected O, but got Unknown
		//IL_2e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e0a: Expected O, but got Unknown
		//IL_2e25: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e2f: Expected O, but got Unknown
		//IL_2e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e4b: Expected O, but got Unknown
		//IL_2ea5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eaf: Expected O, but got Unknown
		//IL_2ecd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed7: Expected O, but got Unknown
		//IL_2ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef3: Expected O, but got Unknown
		//IL_2f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fbf: Expected O, but got Unknown
		//IL_30c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_30cf: Expected O, but got Unknown
		//IL_33f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_33fc: Expected O, but got Unknown
		//IL_3523: Unknown result type (might be due to invalid IL or missing references)
		//IL_352d: Expected O, but got Unknown
		//IL_360d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3617: Expected O, but got Unknown
		//IL_3749: Unknown result type (might be due to invalid IL or missing references)
		//IL_3753: Expected O, but got Unknown
		//IL_3890: Unknown result type (might be due to invalid IL or missing references)
		//IL_389a: Expected O, but got Unknown
		//IL_39dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_39e7: Expected O, but got Unknown
		//IL_3b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b0d: Expected O, but got Unknown
		//IL_3be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bf1: Expected O, but got Unknown
		//IL_3cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cd8: Expected O, but got Unknown
		//IL_3dbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dc8: Expected O, but got Unknown
		//IL_3ea8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eb2: Expected O, but got Unknown
		//IL_406c: Unknown result type (might be due to invalid IL or missing references)
		//IL_40b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_413d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4147: Expected O, but got Unknown
		//IL_4223: Unknown result type (might be due to invalid IL or missing references)
		//IL_422d: Expected O, but got Unknown
		//IL_424b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4255: Expected O, but got Unknown
		//IL_4267: Unknown result type (might be due to invalid IL or missing references)
		//IL_4271: Expected O, but got Unknown
		//IL_42ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_42d8: Expected O, but got Unknown
		//IL_42f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_42fd: Expected O, but got Unknown
		//IL_430f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4319: Expected O, but got Unknown
		//IL_43a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_43d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_43e2: Expected O, but got Unknown
		//IL_44f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_44fb: Expected O, but got Unknown
		//IL_4827: Unknown result type (might be due to invalid IL or missing references)
		//IL_4831: Expected O, but got Unknown
		//IL_495e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4968: Expected O, but got Unknown
		//IL_4a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a5d: Expected O, but got Unknown
		//IL_4b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b7d: Expected O, but got Unknown
		//IL_4c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c89: Expected O, but got Unknown
		//IL_4dbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dc9: Expected O, but got Unknown
		//IL_4f11: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f1b: Expected O, but got Unknown
		//IL_5039: Unknown result type (might be due to invalid IL or missing references)
		//IL_5043: Expected O, but got Unknown
		//IL_5129: Unknown result type (might be due to invalid IL or missing references)
		//IL_5133: Expected O, but got Unknown
		//IL_521f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5229: Expected O, but got Unknown
		//IL_5303: Unknown result type (might be due to invalid IL or missing references)
		//IL_530d: Expected O, but got Unknown
		//IL_5530: Unknown result type (might be due to invalid IL or missing references)
		//IL_553a: Expected O, but got Unknown
		//IL_558a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5747: Unknown result type (might be due to invalid IL or missing references)
		//IL_5751: Expected O, but got Unknown
		//IL_57a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_595a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5964: Expected O, but got Unknown
		//IL_59b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b57: Expected O, but got Unknown
		//IL_5b9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ba8: Expected O, but got Unknown
		//IL_5bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d0d: Expected O, but got Unknown
		byte[] array = g5.I;
		byte[] r = b4.R;
		int num = 340;
		ICloneable cloneable2 = default(ICloneable);
		ICloneable cloneable = default(ICloneable);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cloneable2 = (ICloneable)new DataGridViewCellStyle();
				cloneable = (ICloneable)new DataGridViewCellStyle();
				obj = new ComponentResourceManager(typeof(k4));
				z4(new TabControl());
				num = 48;
				break;
			case 48:
				c1(new TabPage());
				An(new Panel());
				En(new TableLayoutPanel());
				num = 109;
				break;
			case 109:
				Lg(new Panel());
				Gg0(new Label());
				Cb7(new Panel());
				num = 162;
				break;
			case 162:
				Sc5(new DataGridView());
				Fx2(new DataGridViewTextBoxColumn());
				a4K(new DataGridViewTextBoxColumn());
				num = 409;
				break;
			case 409:
				Ra2(new DataGridViewTextBoxColumn());
				Fe2(new DataGridViewTextBoxColumn());
				Yd0(new DataGridViewTextBoxColumn());
				num = 392;
				break;
			case 392:
				f0J(new DataGridViewTextBoxColumn());
				Bb(new Label());
				Ax(new Label());
				num = 196;
				break;
			case 196:
				Dd(new Label());
				q0(new Label());
				y2(new Label());
				num = 309;
				break;
			case 309:
				m2(new Label());
				Jn3(new Label());
				Gt4(new Label());
				num = 223;
				break;
			case 223:
				Bs4(new Label());
				q7A(new Label());
				goto case 89;
			case 89:
				Jj8(new Label());
				num = 390;
				break;
			case 390:
				Ar6(new Label());
				d2Q(new Label());
				c6R(new Label());
				num = 105;
				break;
			case 105:
				Ry7(new TableLayoutPanel());
				d3B(new Panel());
				Sb4(new Label());
				num = 317;
				break;
			case 317:
				Hk8(new TabPage());
				Ay3(new Panel());
				Gi9(new TableLayoutPanel());
				num = 143;
				break;
			case 143:
				t0S(new TableLayoutPanel());
				t8A(new Panel());
				s7X(new Label());
				num = 41;
				break;
			case 41:
				Aj6(new Panel());
				Mm0(new TextBox());
				w7Y(new Label());
				num = 92;
				break;
			case 92:
				Wg2(new ComboBox());
				c4Y(new TextBox());
				f3T(new TextBox());
				num = 77;
				break;
			case 77:
				Ap3(new TextBox());
				z7Q(new Label());
				j3X(new Label());
				num = 232;
				break;
			case 232:
				k1T(new Label());
				Bo4(new Label());
				Yc0(new Label());
				num = 242;
				break;
			case 242:
				Tt0(new Panel());
				g1H(new TabPage());
				Sf3(new TableLayoutPanel());
				num = 440;
				break;
			case 440:
				a3D(new TableLayoutPanel());
				Cm5(new Panel());
				g1M(new Label());
				num = 120;
				break;
			case 120:
				w0G(new Panel());
				w0R(new TextBox());
				r0J(new Label());
				num = 14;
				break;
			case 14:
				Px7(new ComboBox());
				Mk7(new Label());
				f6S(new TextBox());
				num = 231;
				break;
			case 231:
				Mj3(new TextBox());
				s2N(new TextBox());
				Ki6(new Label());
				num = 225;
				break;
			case 225:
				Xn6(new Label());
				n0M(new Label());
				Da7(new Label());
				num = 221;
				break;
			case 221:
				Xk9(new Panel());
				d9Q(new Button());
				Rx1(new Button());
				num = 46;
				break;
			case 46:
				Jk8(new Button());
				f3S(new Button());
				((Control)Wj()).SuspendLayout();
				num = 175;
				break;
			case 175:
				((Control)b0()).SuspendLayout();
				((Control)Kw()).SuspendLayout();
				((Control)Ka()).SuspendLayout();
				num = 361;
				break;
			case 361:
				((Control)x4()).SuspendLayout();
				((ISupportInitialize)Qn4()).BeginInit();
				((Control)w5J()).SuspendLayout();
				num = 374;
				break;
			case 374:
				((Control)z4L()).SuspendLayout();
				((Control)Hr6()).SuspendLayout();
				((Control)Tq0()).SuspendLayout();
				num = 212;
				break;
			case 212:
				((Control)b6Z()).SuspendLayout();
				((Control)z5G()).SuspendLayout();
				((Control)Gy8()).SuspendLayout();
				num = 405;
				break;
			case 405:
				((Control)o7S()).SuspendLayout();
				((Control)Bx3()).SuspendLayout();
				((Control)k4D()).SuspendLayout();
				num = 190;
				break;
			case 190:
				((Control)Yn7()).SuspendLayout();
				((Control)t5W()).SuspendLayout();
				((Control)j4G()).SuspendLayout();
				num = 139;
				break;
			case 139:
				((Control)this).SuspendLayout();
				((Control)Wj()).get_Controls().Add((Control)(object)b0());
				num = 393;
				break;
			case 393:
				((Control)Wj()).get_Controls().Add((Control)(object)Hr6());
				((Control)Wj()).get_Controls().Add((Control)(object)Bx3());
				num = 148;
				break;
			case 148:
				((Control)Wj()).set_Dock((DockStyle)5);
				((Control)Wj()).set_Location(new Point(0, 0));
				num = 136;
				break;
			case 136:
				((Control)Wj()).set_Name(Rc6.Yy4s1(7, 947755738, typeof(o0), 'C'));
				num = 316;
				break;
			case 316:
				Wj().set_SelectedIndex(0);
				((Control)Wj()).set_Size(new Size(955, 551));
				num = 249;
				break;
			case 249:
				Wj().set_SizeMode((TabSizeMode)2);
				((Control)Wj()).set_TabIndex(4);
				num = 380;
				break;
			case 380:
				b0().set_BackColor(Color.WhiteSmoke);
				((Control)b0()).get_Controls().Add((Control)(object)Kw());
				num = 206;
				break;
			case 206:
				b0().set_Location(new Point(4, 22));
				((Control)b0()).set_Margin(new Padding(0));
				num = 233;
				break;
			case 233:
				((Control)b0()).set_Name(Rc6.Yy4s1(7, 947755537, typeof(b6), '\u0084'));
				num = 57;
				break;
			case 57:
				((Control)b0()).set_Size(new Size(947, 525));
				b0().set_TabIndex(2);
				num = 307;
				break;
			case 307:
				b0().set_Text(Rc6.Yy4s1(7, 947755524, typeof(k4), 'Ó'));
				num = 165;
				break;
			case 165:
				((Control)Kw()).get_Controls().Add((Control)(object)Ka());
				((Control)Kw()).set_Dock((DockStyle)5);
				num = 432;
				break;
			case 432:
				((Control)Kw()).set_Location(new Point(0, 0));
				((Control)Kw()).set_Margin(new Padding(5));
				num = 100;
				break;
			case 100:
				((Control)Kw()).set_Name(Rc6.Yy4s1(1, 947755525, typeof(a9), '\u0014'));
				num = 387;
				break;
			case 387:
				((Control)Kw()).set_Padding(new Padding(10, 5, 10, 5));
				num = 437;
				break;
			case 437:
				((Control)Kw()).set_Size(new Size(947, 525));
				((Control)Kw()).set_TabIndex(2);
				num = 297;
				break;
			case 297:
				Ka().set_ColumnCount(1);
				Ka().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
				num = 308;
				break;
			case 308:
				Ka().get_Controls().Add((Control)(object)x4(), 0, 1);
				Ka().get_Controls().Add((Control)(object)w5J(), 0, 2);
				num = 21;
				break;
			case 21:
				Ka().get_Controls().Add((Control)(object)z4L(), 0, 0);
				num = 67;
				break;
			case 67:
				((Control)Ka()).set_Dock((DockStyle)5);
				((Control)Ka()).set_Location(new Point(10, 5));
				num = 82;
				break;
			case 82:
				((Control)Ka()).set_Name(Rc6.Yy4s1(2, 947755603, typeof(a9), '\u0081'));
				num = 79;
				break;
			case 79:
				Ka().set_RowCount(3);
				Ka().get_RowStyles().Add(new RowStyle((SizeType)2, 8.487085f));
				num = 252;
				break;
			case 252:
				Ka().get_RowStyles().Add(new RowStyle((SizeType)2, 81.36531f));
				Ka().get_RowStyles().Add(new RowStyle((SizeType)2, 10.1476f));
				num = 241;
				break;
			case 241:
				((Control)Ka()).set_Size(new Size(927, 515));
				((Control)Ka()).set_TabIndex(39);
				num = 210;
				break;
			case 210:
				((ScrollableControl)x4()).set_AutoScroll(true);
				((Control)x4()).set_BackColor(Color.White);
				num = 188;
				break;
			case 188:
				x4().set_BorderStyle((BorderStyle)1);
				((Control)x4()).get_Controls().Add((Control)(object)m6J());
				num = 9;
				break;
			case 9:
				((Control)x4()).get_Controls().Add((Control)(object)s1X());
				((Control)x4()).get_Controls().Add((Control)(object)Qn4());
				num = 282;
				break;
			case 282:
				((Control)x4()).get_Controls().Add((Control)(object)Cm());
				((Control)x4()).get_Controls().Add((Control)(object)Qi());
				num = 239;
				break;
			case 239:
				((Control)x4()).get_Controls().Add((Control)(object)Ec());
				((Control)x4()).get_Controls().Add((Control)(object)e7());
				num = 391;
				break;
			case 391:
				((Control)x4()).get_Controls().Add((Control)(object)z2());
				((Control)x4()).get_Controls().Add((Control)(object)Ng());
				num = 17;
				break;
			case 17:
				((Control)x4()).get_Controls().Add((Control)(object)b5());
				((Control)x4()).get_Controls().Add((Control)(object)d8Z());
				num = 117;
				break;
			case 117:
				((Control)x4()).get_Controls().Add((Control)(object)a5T());
				((Control)x4()).get_Controls().Add((Control)(object)Te9());
				num = 180;
				break;
			case 180:
				((Control)x4()).get_Controls().Add((Control)(object)g2C());
				((Control)x4()).get_Controls().Add((Control)(object)Sj8());
				num = 246;
				break;
			case 246:
				((Control)x4()).get_Controls().Add((Control)(object)g0J());
				((Control)x4()).get_Controls().Add((Control)(object)Mw3());
				num = 347;
				break;
			case 347:
				((Control)x4()).set_Dock((DockStyle)5);
				((Control)x4()).set_Font(new Font(Rc6.Yy4s1(2, 947755591, typeof(p2W0F), '9'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 133;
				break;
			case 133:
				((Control)x4()).set_Location(new Point(3, 46));
				((Control)x4()).set_Name(Rc6.Yy4s1(8, 947755963, typeof(k4), '\u000f'));
				num = 115;
				break;
			case 115:
				((Control)x4()).set_Size(new Size(921, 413));
				((Control)x4()).set_TabIndex(38);
				num = 343;
				break;
			case 343:
				m6J().set_AutoSize(true);
				((Control)m6J()).set_Font(new Font(Rc6.Yy4s1(1, 947755588, typeof(s6), '\n'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 134;
				break;
			case 134:
				((Control)m6J()).set_Location(new Point(324, 370));
				((Control)m6J()).set_Name(Rc6.Yy4s1(2, 947756001, typeof(a9), 'p'));
				num = 28;
				break;
			case 28:
				((Control)m6J()).set_Size(new Size(260, 18));
				((Control)m6J()).set_TabIndex(115);
				num = 275;
				break;
			case 275:
				m6J().set_Text(Rc6.Yy4s1(4, 947756013, typeof(p2W0F), '«'));
				num = 75;
				break;
			case 75:
				((Control)s1X()).set_Location(new Point(892, 700));
				((Control)s1X()).set_Name(Rc6.Yy4s1(5, 947755976, typeof(Rc6), 'Ó'));
				num = 129;
				break;
			case 129:
				((Control)s1X()).set_Size(new Size(10, 35));
				((Control)s1X()).set_TabIndex(71);
				num = 38;
				break;
			case 38:
				Qn4().set_AllowUserToAddRows(false);
				Qn4().set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
				num = 161;
				break;
			case 161:
				Qn4().set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
				Qn4().set_BackgroundColor(Color.WhiteSmoke);
				num = 345;
				break;
			case 345:
				Qn4().set_CellBorderStyle((DataGridViewCellBorderStyle)8);
				Qn4().set_ColumnHeadersBorderStyle((DataGridViewHeaderBorderStyle)1);
				num = 424;
				break;
			case 424:
				((DataGridViewCellStyle)((cloneable2 is DataGridViewCellStyle) ? cloneable2 : null)).set_Alignment((DataGridViewContentAlignment)16);
				((DataGridViewCellStyle)cloneable2).set_BackColor(SystemColors.Control);
				num = 348;
				break;
			case 348:
				((DataGridViewCellStyle)cloneable2).set_Font(new Font(Rc6.Yy4s1(5, 947755584, typeof(s6), 'Ä'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 218;
				break;
			case 218:
				((DataGridViewCellStyle)((cloneable2 is DataGridViewCellStyle) ? cloneable2 : null)).set_ForeColor(SystemColors.WindowText);
				((DataGridViewCellStyle)((cloneable2 is DataGridViewCellStyle) ? cloneable2 : null)).set_Padding(new Padding(3));
				num = 250;
				break;
			case 250:
				((DataGridViewCellStyle)cloneable2).set_SelectionBackColor(SystemColors.Highlight);
				((DataGridViewCellStyle)cloneable2).set_SelectionForeColor(SystemColors.HighlightText);
				num = 402;
				break;
			case 402:
				((DataGridViewCellStyle)cloneable2).set_WrapMode((DataGridViewTriState)1);
				Qn4().set_ColumnHeadersDefaultCellStyle((DataGridViewCellStyle)cloneable2);
				num = 300;
				break;
			case 300:
				Qn4().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
				Qn4().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
				{
					(DataGridViewColumn)s5X(),
					(DataGridViewColumn)g0N(),
					(DataGridViewColumn)Da5(),
					(DataGridViewColumn)r9A(),
					(DataGridViewColumn)s3F(),
					(DataGridViewColumn)Qi1()
				});
				num = 240;
				break;
			case 240:
				((DataGridViewCellStyle)cloneable).set_Alignment((DataGridViewContentAlignment)16);
				((DataGridViewCellStyle)cloneable).set_BackColor(SystemColors.Window);
				num = 45;
				break;
			case 45:
				((DataGridViewCellStyle)cloneable).set_Font(new Font(Rc6.Yy4s1(2, 947755591, typeof(Rg.Wk), 'S'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 264;
				break;
			case 264:
				((DataGridViewCellStyle)((cloneable is DataGridViewCellStyle) ? cloneable : null)).set_ForeColor(SystemColors.ControlText);
				((DataGridViewCellStyle)cloneable).set_Padding(new Padding(7));
				num = 283;
				break;
			case 283:
				((DataGridViewCellStyle)cloneable).set_SelectionBackColor(Color.FromArgb(25, 117, 211));
				((DataGridViewCellStyle)cloneable).set_SelectionForeColor(SystemColors.HighlightText);
				num = 204;
				break;
			case 204:
				((DataGridViewCellStyle)((cloneable is DataGridViewCellStyle) ? cloneable : null)).set_WrapMode((DataGridViewTriState)2);
				Qn4().set_DefaultCellStyle((DataGridViewCellStyle)((cloneable is DataGridViewCellStyle) ? cloneable : null));
				num = 365;
				break;
			case 365:
				((Control)Qn4()).set_Location(new Point(25, 405));
				Qn4().set_MultiSelect(false);
				num = 378;
				break;
			case 378:
				((Control)Qn4()).set_Name(Rc6.Yy4s1(6, 947755806, typeof(Rg.Zq), '\u0011'));
				num = 87;
				break;
			case 87:
				Qn4().set_ReadOnly(true);
				Qn4().set_SelectionMode((DataGridViewSelectionMode)1);
				num = 318;
				break;
			case 318:
				((Control)Qn4()).set_Size(new Size(861, 306));
				((Control)Qn4()).set_TabIndex(70);
				num = 435;
				break;
			case 435:
				((DataGridViewColumn)s5X()).set_HeaderText(Rc6.Yy4s1(6, 947755892, typeof(p2W0F.m1BLz), '}'));
				num = 137;
				break;
			case 137:
				((DataGridViewColumn)s5X()).set_Name(Rc6.Yy4s1(1, 947755874, typeof(Rg), '\u0013'));
				num = 287;
				break;
			case 287:
				((DataGridViewColumn)s5X()).set_ReadOnly(true);
				s5X().set_SortMode((DataGridViewColumnSortMode)0);
				num = 281;
				break;
			case 281:
				((DataGridViewColumn)g0N()).set_HeaderText(Rc6.Yy4s1(5, 947755866, typeof(Rg.Wk), '\u0003'));
				num = 331;
				break;
			case 331:
				((DataGridViewColumn)g0N()).set_Name(Rc6.Yy4s1(5, 947755852, typeof(p2W0F), 'Ñ'));
				num = 193;
				break;
			case 193:
				((DataGridViewColumn)g0N()).set_ReadOnly(true);
				((DataGridViewColumn)g0N()).set_Resizable((DataGridViewTriState)2);
				num = 16;
				break;
			case 16:
				g0N().set_SortMode((DataGridViewColumnSortMode)0);
				((DataGridViewColumn)Da5()).set_HeaderText(Rc6.Yy4s1(0, 947755173, typeof(k4), 'ñ'));
				num = 34;
				break;
			case 34:
				((DataGridViewColumn)Da5()).set_Name(Rc6.Yy4s1(2, 947755152, typeof(g5), ']'));
				num = 414;
				break;
			case 414:
				((DataGridViewColumn)Da5()).set_ReadOnly(true);
				((DataGridViewColumn)Da5()).set_Resizable((DataGridViewTriState)2);
				num = 142;
				break;
			case 142:
				Da5().set_SortMode((DataGridViewColumnSortMode)0);
				((DataGridViewColumn)r9A()).set_HeaderText(Rc6.Yy4s1(0, 947755160, typeof(Rg.Wk), 'Ø'));
				num = 255;
				break;
			case 255:
				((DataGridViewColumn)r9A()).set_Name(Rc6.Yy4s1(1, 947755249, typeof(k4), 'm'));
				num = 427;
				break;
			case 427:
				((DataGridViewColumn)r9A()).set_ReadOnly(true);
				((DataGridViewColumn)r9A()).set_Resizable((DataGridViewTriState)2);
				num = 202;
				break;
			case 202:
				r9A().set_SortMode((DataGridViewColumnSortMode)0);
				((DataGridViewColumn)s3F()).set_HeaderText(Rc6.Yy4s1(2, 947755244, typeof(k4), '\u0012'));
				num = 6;
				break;
			case 6:
				((DataGridViewColumn)s3F()).set_Name(Rc6.Yy4s1(6, 947755217, typeof(g1BFb), 'v'));
				num = 183;
				break;
			case 183:
				((DataGridViewColumn)s3F()).set_ReadOnly(true);
				((DataGridViewColumn)Qi1()).set_HeaderText(Rc6.Yy4s1(8, 947755065, typeof(Rg.Wk), 'Y'));
				num = 198;
				break;
			case 198:
				((DataGridViewColumn)Qi1()).set_Name(Rc6.Yy4s1(8, 947755056, typeof(g5), ';'));
				num = array[34] + array[5];
				break;
			case 269:
				((DataGridViewColumn)Qi1()).set_ReadOnly(true);
				((Control)Cm()).set_Font(new Font(Rc6.Yy4s1(4, 947755585, typeof(Rg), 'ì'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 363;
				break;
			case 363:
				((Control)Cm()).set_Location(new Point(344, 180));
				((Control)Cm()).set_Name(Rc6.Yy4s1(3, 947755045, typeof(j1X0S), 'm'));
				num = 145;
				break;
			case 145:
				((Control)Cm()).set_Size(new Size(327, 56));
				((Control)Cm()).set_TabIndex(69);
				num = 70;
				break;
			case 70:
				Cm().set_Text(Rc6.Yy4s1(5, 947755947, typeof(g1BFb), 'ì'));
				num = 357;
				break;
			case 357:
				Qi().set_AutoSize(true);
				((Control)Qi()).set_Font(new Font(Rc6.Yy4s1(0, 947755589, typeof(b4), 'x'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 426;
				break;
			case 426:
				((Control)Qi()).set_Location(new Point(116, 180));
				((Control)Qi()).set_Name(Rc6.Yy4s1(7, 947755927, typeof(s6), 'Ú'));
				num = 398;
				break;
			case 398:
				((Control)Qi()).set_Size(new Size(93, 18));
				((Control)Qi()).set_TabIndex(68);
				num = 156;
				break;
			case 156:
				Qi().set_Text(Rc6.Yy4s1(8, 947755123, typeof(k4), 'ô'));
				num = 124;
				break;
			case 124:
				Ec().set_AutoSize(true);
				((Control)Ec()).set_Font(new Font(Rc6.Yy4s1(2, 947755591, typeof(b4), 'C'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 47;
				break;
			case 47:
				((Control)Ec()).set_Location(new Point(344, 304));
				((Control)Ec()).set_Name(Rc6.Yy4s1(0, 947755088, typeof(p2W0F.m1BLz), '\u009c'));
				num = 315;
				break;
			case 315:
				((Control)Ec()).set_Size(new Size(25, 18));
				((Control)Ec()).set_TabIndex(67);
				num = 261;
				break;
			case 261:
				Ec().set_Text(Rc6.Yy4s1(0, 947755950, typeof(p2W0F.m1BLz), 'f'));
				num = 441;
				break;
			case 441:
				e7().set_AutoSize(true);
				((Control)e7()).set_Font(new Font(Rc6.Yy4s1(4, 947755585, typeof(Tq1r9), 'u'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 39;
				break;
			case 39:
				((Control)e7()).set_Location(new Point(116, 304));
				((Control)e7()).set_Name(Rc6.Yy4s1(4, 947755970, typeof(s6), ')'));
				num = 118;
				break;
			case 118:
				((Control)e7()).set_Size(new Size(96, 18));
				((Control)e7()).set_TabIndex(66);
				num = 12;
				break;
			case 12:
				e7().set_Text(Rc6.Yy4s1(6, 947755412, typeof(Rc6), 'G'));
				num = 401;
				break;
			case 401:
				((Control)z2()).set_Cursor(Cursors.get_Arrow());
				((Control)z2()).set_Font(new Font(Rc6.Yy4s1(3, 947755590, typeof(Tq1r9), 'j'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 140;
				break;
			case 140:
				((Control)z2()).set_Location(new Point(344, 266));
				((Control)z2()).set_Name(Rc6.Yy4s1(3, 947755402, typeof(b6), '¢'));
				num = 51;
				break;
			case 51:
				((Control)z2()).set_Size(new Size(347, 18));
				((Control)z2()).set_TabIndex(65);
				num = 209;
				break;
			case 209:
				z2().set_Text(Rc6.Yy4s1(4, 947755946, typeof(Rg.Zq), '\a'));
				num = 351;
				break;
			case 351:
				Ng().set_AutoSize(true);
				((Control)Ng()).set_Font(new Font(Rc6.Yy4s1(5, 947755584, typeof(j1X0S), 'Þ'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 91;
				break;
			case 91:
				((Control)Ng()).set_Location(new Point(116, 266));
				((Control)Ng()).set_Name(Rc6.Yy4s1(5, 947755888, typeof(j1X0S), '·'));
				num = 184;
				break;
			case 184:
				((Control)Ng()).set_Size(new Size(96, 18));
				((Control)Ng()).set_TabIndex(64);
				num = 186;
				break;
			case 186:
				Ng().set_Text(Rc6.Yy4s1(3, 947755462, typeof(p2W0F), 'ï'));
				num = 181;
				break;
			case 181:
				b5().set_AutoSize(true);
				((Control)b5()).set_Cursor(Cursors.get_Arrow());
				num = r[332] + 293;
				break;
			case 382:
				((Control)b5()).set_Font(new Font(Rc6.Yy4s1(8, 947755597, typeof(b6), 'P'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 293;
				break;
			case 293:
				((Control)b5()).set_Location(new Point(344, 144));
				((Control)b5()).set_Name(Rc6.Yy4s1(2, 947755327, typeof(Rg.p0<>), '\r'));
				num = 415;
				break;
			case 415:
				((Control)b5()).set_Size(new Size(25, 18));
				((Control)b5()).set_TabIndex(43);
				num = 289;
				break;
			case 289:
				b5().set_Text(Rc6.Yy4s1(0, 947755950, typeof(s6), '@'));
				num = 151;
				break;
			case 151:
				d8Z().set_AutoSize(true);
				((Control)d8Z()).set_Cursor(Cursors.get_Arrow());
				num = 298;
				break;
			case 298:
				((Control)d8Z()).set_Font(new Font(Rc6.Yy4s1(4, 947755585, typeof(b4), '\u0080'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 166;
				break;
			case 166:
				((Control)d8Z()).set_Location(new Point(344, 112));
				((Control)d8Z()).set_Name(Rc6.Yy4s1(2, 947755291, typeof(s6), 'e'));
				num = 66;
				break;
			case 66:
				((Control)d8Z()).set_Size(new Size(137, 18));
				((Control)d8Z()).set_TabIndex(42);
				num = 288;
				break;
			case 288:
				d8Z().set_Text(Rc6.Yy4s1(5, 947755446, typeof(b6), 'á'));
				num = 173;
				break;
			case 173:
				a5T().set_AutoSize(true);
				((Control)a5T()).set_Font(new Font(Rc6.Yy4s1(4, 947755585, typeof(p2W0F), '\a'), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 302;
				break;
			case 302:
				((Control)a5T()).set_Location(new Point(344, 78));
				((Control)a5T()).set_Name(Rc6.Yy4s1(5, 947755363, typeof(b4), '¡'));
				num = 58;
				break;
			case 58:
				((Control)a5T()).set_Size(new Size(116, 18));
				((Control)a5T()).set_TabIndex(41);
				num = 144;
				break;
			case 144:
				a5T().set_Text(Rc6.Yy4s1(5, 947755416, typeof(Rg.p0<>), 'ò'));
				num = 256;
				break;
			case 256:
				Te9().set_AutoSize(true);
				((Control)Te9()).set_Font(new Font(Rc6.Yy4s1(4, 947755585, typeof(j1X0S), 'Ä'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 420;
				break;
			case 420:
				((Control)Te9()).set_Location(new Point(344, 43));
				((Control)Te9()).set_Name(Rc6.Yy4s1(6, 947756716, typeof(s6), 'O'));
				num = 321;
				break;
			case 321:
				((Control)Te9()).set_Size(new Size(54, 18));
				((Control)Te9()).set_TabIndex(40);
				num = 423;
				break;
			case 423:
				Te9().set_Text(Rc6.Yy4s1(2, 947755494, typeof(Tq1r9), '0'));
				num = 328;
				break;
			case 328:
				g2C().set_AutoSize(true);
				((Control)g2C()).set_Font(new Font(Rc6.Yy4s1(8, 947755597, typeof(a9), 'Y'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 244;
				break;
			case 244:
				((Control)g2C()).set_Location(new Point(116, 144));
				((Control)g2C()).set_Name(Rc6.Yy4s1(3, 947755503, typeof(Rg.p0<>), 'e'));
				num = 65;
				break;
			case 65:
				((Control)g2C()).set_Size(new Size(130, 18));
				((Control)g2C()).set_TabIndex(39);
				num = 407;
				break;
			case 407:
				g2C().set_Text(Rc6.Yy4s1(3, 947756765, typeof(o0), '\u00b4'));
				num = 122;
				break;
			case 122:
				Sj8().set_AutoSize(true);
				((Control)Sj8()).set_Font(new Font(Rc6.Yy4s1(4, 947755585, typeof(Rg.Zq), 'Ì'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 159;
				break;
			case 159:
				((Control)Sj8()).set_Location(new Point(116, 112));
				((Control)Sj8()).set_Name(Rc6.Yy4s1(4, 947755316, typeof(o0), 'k'));
				num = 174;
				break;
			case 174:
				((Control)Sj8()).set_Size(new Size(119, 18));
				((Control)Sj8()).set_TabIndex(38);
				num = 375;
				break;
			case 375:
				Sj8().set_Text(Rc6.Yy4s1(7, 947756585, typeof(p2W0F.m1BLz), 'õ'));
				num = 352;
				break;
			case 352:
				g0J().set_AutoSize(true);
				((Control)g0J()).set_Font(new Font(Rc6.Yy4s1(8, 947755597, typeof(Rg.Wk), 'ì'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 284;
				break;
			case 284:
				((Control)g0J()).set_Location(new Point(116, 78));
				((Control)g0J()).set_Name(Rc6.Yy4s1(6, 947755273, typeof(Tq1r9), 'õ'));
				num = 436;
				break;
			case 436:
				((Control)g0J()).set_Size(new Size(113, 18));
				((Control)g0J()).set_TabIndex(37);
				num = 367;
				break;
			case 367:
				g0J().set_Text(Rc6.Yy4s1(0, 947756668, typeof(b6), '*'));
				num = 219;
				break;
			case 219:
				Mw3().set_AutoSize(true);
				((Control)Mw3()).set_Font(new Font(Rc6.Yy4s1(4, 947755585, typeof(Tq1r9), 'w'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 199;
				break;
			case 199:
				((Control)Mw3()).set_Location(new Point(116, 43));
				((Control)Mw3()).set_Name(Rc6.Yy4s1(1, 947755351, typeof(s6), '_'));
				num = 337;
				break;
			case 337:
				((Control)Mw3()).set_Size(new Size(85, 18));
				((Control)Mw3()).set_TabIndex(36);
				num = 153;
				break;
			case 153:
				Mw3().set_Text(Rc6.Yy4s1(1, 947756983, typeof(k4), 'd'));
				num = 428;
				break;
			case 428:
				w5J().set_ColumnCount(3);
				w5J().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 23f));
				num = 406;
				break;
			case 406:
				w5J().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 62.44444f));
				w5J().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 14.66667f));
				num = 78;
				break;
			case 78:
				w5J().get_Controls().Add((Control)(object)t3Q(), 2, 0);
				((Control)w5J()).set_Dock((DockStyle)5);
				num = 13;
				break;
			case 13:
				((Control)w5J()).set_Location(new Point(3, 465));
				((Control)w5J()).set_Name(Rc6.Yy4s1(4, 947756722, typeof(Rg), 'k'));
				num = 22;
				break;
			case 22:
				((Control)w5J()).set_Padding(new Padding(0, 10, 0, 0));
				num = 238;
				break;
			case 238:
				w5J().set_RowCount(1);
				w5J().get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
				num = 172;
				break;
			case 172:
				((Control)w5J()).set_Size(new Size(921, 47));
				((Control)w5J()).set_TabIndex(37);
				num = 191;
				break;
			case 191:
				((Control)z4L()).get_Controls().Add((Control)(object)t2Z());
				((Control)z4L()).set_Dock((DockStyle)5);
				num = 439;
				break;
			case 439:
				((Control)z4L()).set_Location(new Point(3, 3));
				((Control)z4L()).set_Name(Rc6.Yy4s1(5, 947756757, typeof(Rg.Zq), '\u0086'));
				num = 119;
				break;
			case 119:
				((Control)z4L()).set_Size(new Size(921, 37));
				((Control)z4L()).set_TabIndex(78);
				num = 97;
				break;
			case 97:
				((Control)t2Z()).set_Dock((DockStyle)5);
				((Control)t2Z()).set_Font(new Font(Rc6.Yy4s1(8, 947755597, typeof(o0), '\u001c'), 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 94;
				break;
			case 94:
				((Control)t2Z()).set_Location(new Point(0, 0));
				((Control)t2Z()).set_Name(Rc6.Yy4s1(1, 947756749, typeof(s6), 'æ'));
				num = 263;
				break;
			case 263:
				((Control)t2Z()).set_Size(new Size(921, 37));
				((Control)t2Z()).set_TabIndex(71);
				num = 74;
				break;
			case 74:
				t2Z().set_Text(Rc6.Yy4s1(3, 947756935, typeof(j1X0S), '7'));
				num = 259;
				break;
			case 259:
				t2Z().set_TextAlign((ContentAlignment)32);
				Hr6().set_BackColor(Color.WhiteSmoke);
				num = 322;
				break;
			case 322:
				((Control)Hr6()).get_Controls().Add((Control)(object)Tq0());
				Hr6().set_Location(new Point(4, 22));
				num = 27;
				break;
			case 27:
				((Control)Hr6()).set_Margin(new Padding(0));
				((Control)Hr6()).set_Name(Rc6.Yy4s1(3, 947756573, typeof(Rg.Wk), 'e'));
				num = 371;
				break;
			case 371:
				((Control)Hr6()).set_Size(new Size(947, 525));
				Hr6().set_TabIndex(1);
				num = 207;
				break;
			case 207:
				Hr6().set_Text(Rc6.Yy4s1(2, 947756556, typeof(Rg.Zq), 'c'));
				num = 178;
				break;
			case 178:
				((Control)Tq0()).get_Controls().Add((Control)(object)b6Z());
				((Control)Tq0()).set_Dock((DockStyle)5);
				num = 31;
				break;
			case 31:
				((Control)Tq0()).set_Location(new Point(0, 0));
				((Control)Tq0()).set_Margin(new Padding(5));
				num = 408;
				break;
			case 408:
				((Control)Tq0()).set_Name(Rc6.Yy4s1(3, 947756662, typeof(Rg.Zq), 'å'));
				num = 356;
				break;
			case 356:
				((Control)Tq0()).set_Padding(new Padding(10, 5, 10, 5));
				num = 303;
				break;
			case 303:
				((Control)Tq0()).set_Size(new Size(947, 525));
				((Control)Tq0()).set_TabIndex(2);
				num = 327;
				break;
			case 327:
				b6Z().set_ColumnCount(1);
				b6Z().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
				num = 110;
				break;
			case 110:
				b6Z().get_Controls().Add((Control)(object)z5G(), 0, 2);
				b6Z().get_Controls().Add((Control)(object)Gy8(), 0, 0);
				num = 26;
				break;
			case 26:
				b6Z().get_Controls().Add((Control)(object)o7S(), 0, 1);
				num = 18;
				break;
			case 18:
			case 107:
				((Control)b6Z()).set_Dock((DockStyle)5);
				((Control)b6Z()).set_Location(new Point(10, 5));
				num = 270;
				break;
			case 270:
				((Control)b6Z()).set_Name(Rc6.Yy4s1(2, 947756652, typeof(j1X0S), 'P'));
				num = 192;
				break;
			case 192:
				b6Z().set_RowCount(3);
				b6Z().get_RowStyles().Add(new RowStyle((SizeType)2, 8.487085f));
				num = 95;
				break;
			case 95:
				b6Z().get_RowStyles().Add(new RowStyle((SizeType)2, 81.36531f));
				b6Z().get_RowStyles().Add(new RowStyle((SizeType)2, 10.1476f));
				num = 64;
				break;
			case 64:
				((Control)b6Z()).set_Size(new Size(927, 515));
				((Control)b6Z()).set_TabIndex(39);
				num = 236;
				break;
			case 236:
				z5G().set_ColumnCount(3);
				z5G().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
				num = 234;
				break;
			case 234:
				z5G().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 65.68947f));
				z5G().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 14.33225f));
				num = 203;
				break;
			case 203:
				z5G().get_Controls().Add((Control)(object)Sp3(), 2, 0);
				((Control)z5G()).set_Dock((DockStyle)5);
				num = r[199] + 122;
				break;
			case 215:
				((Control)z5G()).set_Location(new Point(3, 465));
				((Control)z5G()).set_Name(Rc6.Yy4s1(2, 947756608, typeof(Rg.Wk), '4'));
				num = 130;
				break;
			case 130:
				((Control)z5G()).set_Padding(new Padding(0, 10, 0, 0));
				num = 80;
				break;
			case 80:
				z5G().set_RowCount(1);
				z5G().get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
				num = 121;
				break;
			case 121:
				((Control)z5G()).set_Size(new Size(921, 47));
				((Control)z5G()).set_TabIndex(37);
				num = 274;
				break;
			case 274:
				((Control)Gy8()).get_Controls().Add((Control)(object)Ca0());
				((Control)Gy8()).set_Dock((DockStyle)5);
				num = 113;
				break;
			case 113:
				((Control)Gy8()).set_Location(new Point(3, 3));
				((Control)Gy8()).set_Name(Rc6.Yy4s1(3, 947756957, typeof(Rg.Zq), 'o'));
				num = 123;
				break;
			case 123:
				((Control)Gy8()).set_Size(new Size(921, 37));
				((Control)Gy8()).set_TabIndex(78);
				num = 268;
				break;
			case 268:
				((Control)Ca0()).set_Dock((DockStyle)5);
				((Control)Ca0()).set_Font(new Font(Rc6.Yy4s1(0, 947755589, typeof(Rg.Wk), '\u00ad'), 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 279;
				break;
			case 279:
				((Control)Ca0()).set_Location(new Point(0, 0));
				((Control)Ca0()).set_Name(Rc6.Yy4s1(4, 947757053, typeof(Rg.Zq), '\u0017'));
				num = 104;
				break;
			case 104:
				((Control)Ca0()).set_Size(new Size(921, 37));
				((Control)Ca0()).set_TabIndex(71);
				num = 360;
				break;
			case 360:
				Ca0().set_Text(Rc6.Yy4s1(3, 947756935, typeof(Tq1r9), '\u00af'));
				num = 182;
				break;
			case 182:
				Ca0().set_TextAlign((ContentAlignment)32);
				((ScrollableControl)o7S()).set_AutoScroll(true);
				num = 320;
				break;
			case 320:
				((Control)o7S()).set_BackColor(Color.White);
				o7S().set_BorderStyle((BorderStyle)1);
				num = 332;
				break;
			case 332:
				((Control)o7S()).get_Controls().Add((Control)(object)Ss5());
				((Control)o7S()).get_Controls().Add((Control)(object)Cd4());
				num = 36;
				break;
			case 36:
				((Control)o7S()).get_Controls().Add((Control)(object)Fz7());
				((Control)o7S()).get_Controls().Add((Control)(object)w0X());
				num = 247;
				break;
			case 247:
				((Control)o7S()).get_Controls().Add((Control)(object)Mb5());
				((Control)o7S()).get_Controls().Add((Control)(object)f1J());
				num = 325;
				break;
			case 325:
				((Control)o7S()).get_Controls().Add((Control)(object)q6K());
				((Control)o7S()).get_Controls().Add((Control)(object)z4Z());
				num = 62;
				break;
			case 62:
				((Control)o7S()).get_Controls().Add((Control)(object)p6X());
				((Control)o7S()).get_Controls().Add((Control)(object)o0P());
				num = 277;
				break;
			case 277:
				((Control)o7S()).get_Controls().Add((Control)(object)q1M());
				((Control)o7S()).get_Controls().Add((Control)(object)e6R());
				num = 157;
				break;
			case 157:
				((Control)o7S()).set_Dock((DockStyle)5);
				((Control)o7S()).set_Location(new Point(3, 46));
				num = 257;
				break;
			case 257:
				((Control)o7S()).set_Name(Rc6.Yy4s1(7, 947756808, typeof(g1BFb), 'n'));
				num = 295;
				break;
			case 295:
				((Control)o7S()).set_Size(new Size(921, 413));
				((Control)o7S()).set_TabIndex(38);
				goto case 276;
			case 276:
				num = 23;
				break;
			case 23:
				((TextBoxBase)Ss5()).set_BackColor(Color.White);
				((TextBoxBase)Ss5()).set_BorderStyle((BorderStyle)1);
				num = 106;
				break;
			case 106:
				((Control)Ss5()).set_Enabled(false);
				((Control)Ss5()).set_Font(new Font(Rc6.Yy4s1(2, 947756694, typeof(a9), 'Ð'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 163;
				break;
			case 163:
				((TextBoxBase)Ss5()).set_ForeColor(Color.Black);
				((Control)Ss5()).set_Location(new Point(349, 91));
				num = 355;
				break;
			case 355:
				((TextBoxBase)Ss5()).set_MaxLength(100);
				Ss5().set_Multiline(true);
				num = 262;
				break;
			case 262:
				((Control)Ss5()).set_Name(Rc6.Yy4s1(2, 947756904, typeof(p2W0F.m1BLz), 'Ã'));
				num = 52;
				break;
			case 52:
				((Control)Ss5()).set_Size(new Size(303, 27));
				((Control)Ss5()).set_TabIndex(137);
				num = 197;
				break;
			case 197:
				((Control)Ss5()).set_Tag((object)Rc6.Yy4s1(8, 947755765, typeof(j1X0S), 'R'));
				num = 403;
				break;
			case 403:
				Cd4().set_AutoSize(true);
				((Control)Cd4()).set_Font(new Font(Rc6.Yy4s1(0, 947755589, typeof(a9), 'ë'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 10;
				break;
			case 10:
				((Control)Cd4()).set_Location(new Point(114, 96));
				((Control)Cd4()).set_Name(Rc6.Yy4s1(4, 947756872, typeof(Rg.p0<>), 'Z'));
				num = 319;
				break;
			case 319:
				((Control)Cd4()).set_Size(new Size(96, 18));
				((Control)Cd4()).set_TabIndex(136);
				num = 372;
				break;
			case 372:
				Cd4().set_Text(Rc6.Yy4s1(1, 947756219, typeof(Rc6), '¶'));
				num = 350;
				break;
			case 350:
				Fz7().set_DropDownStyle((ComboBoxStyle)2);
				((Control)Fz7()).set_Font(new Font(Rc6.Yy4s1(8, 947756700, typeof(Tq1r9), 'Ì'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 15;
				break;
			case 15:
				((ListControl)Fz7()).set_FormattingEnabled(true);
				Fz7().get_Items().AddRange(new object[2]
				{
					Rc6.Yy4s1(4, 947756191, typeof(Rg.Wk), '\u009b'),
					Rc6.Yy4s1(4, 947756163, typeof(p2W0F), '\f')
				});
				num = 341;
				break;
			case 341:
				((Control)Fz7()).set_Location(new Point(349, 182));
				((Control)Fz7()).set_Name(Rc6.Yy4s1(2, 947756282, typeof(p2W0F.m1BLz), '\u0087'));
				num = 1;
				break;
			case 1:
				((Control)Fz7()).set_Size(new Size(303, 28));
				((Control)Fz7()).set_TabIndex(135);
				num = 83;
				break;
			case 83:
				((TextBoxBase)w0X()).set_BackColor(Color.White);
				((TextBoxBase)w0X()).set_BorderStyle((BorderStyle)1);
				num = 323;
				break;
			case 323:
				((Control)w0X()).set_Font(new Font(Rc6.Yy4s1(6, 947756690, typeof(b4), 'M'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 425;
				break;
			case 425:
				((TextBoxBase)w0X()).set_ForeColor(Color.Black);
				((Control)w0X()).set_Location(new Point(349, 276));
				num = 213;
				break;
			case 213:
				((TextBoxBase)w0X()).set_MaxLength(100);
				w0X().set_Multiline(true);
				num = 222;
				break;
			case 222:
				((Control)w0X()).set_Name(Rc6.Yy4s1(4, 947756084, typeof(g1BFb), 'Â'));
				num = 155;
				break;
			case 155:
				((Control)w0X()).set_Size(new Size(303, 69));
				((Control)w0X()).set_TabIndex(119);
				num = 90;
				break;
			case 90:
				((Control)w0X()).set_Tag((object)Rc6.Yy4s1(4, 947755769, typeof(g1BFb), '\u007f'));
				num = 411;
				break;
			case 411:
				((TextBoxBase)Mb5()).set_BackColor(Color.White);
				((TextBoxBase)Mb5()).set_BorderStyle((BorderStyle)1);
				num = 73;
				break;
			case 73:
				((Control)Mb5()).set_Font(new Font(Rc6.Yy4s1(3, 947756695, typeof(g5), 'S'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 305;
				break;
			case 305:
				((TextBoxBase)Mb5()).set_ForeColor(Color.Black);
				((Control)Mb5()).set_Location(new Point(349, 228));
				num = 253;
				break;
			case 253:
				((TextBoxBase)Mb5()).set_MaxLength(100);
				Mb5().set_Multiline(true);
				num = 150;
				break;
			case 150:
				((Control)Mb5()).set_Name(Rc6.Yy4s1(1, 947756040, typeof(o0), ')'));
				num = 211;
				break;
			case 211:
				((Control)Mb5()).set_Size(new Size(303, 27));
				((Control)Mb5()).set_TabIndex(118);
				num = 285;
				break;
			case 285:
				((Control)Mb5()).set_Tag((object)Rc6.Yy4s1(6, 947755771, typeof(o0), 'Þ'));
				num = 304;
				break;
			case 304:
				((TextBoxBase)f1J()).set_BackColor(Color.White);
				((TextBoxBase)f1J()).set_BorderStyle((BorderStyle)1);
				num = 366;
				break;
			case 366:
				((Control)f1J()).set_Font(new Font(Rc6.Yy4s1(6, 947756690, typeof(Rg), '\u0011'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 7;
				break;
			case 7:
				((TextBoxBase)f1J()).set_ForeColor(Color.Black);
				((Control)f1J()).set_Location(new Point(349, 138));
				num = 86;
				break;
			case 86:
				((TextBoxBase)f1J()).set_MaxLength(100);
				f1J().set_Multiline(true);
				num = 358;
				break;
			case 358:
				((Control)f1J()).set_Name(Rc6.Yy4s1(8, 947756110, typeof(g1BFb), ';'));
				num = 354;
				break;
			case 354:
				((Control)f1J()).set_Size(new Size(303, 27));
				((Control)f1J()).set_TabIndex(115);
				num = 102;
				break;
			case 102:
				((Control)f1J()).set_Tag((object)Rc6.Yy4s1(5, 947755768, typeof(p2W0F), 'Ñ'));
				num = 245;
				break;
			case 245:
				q6K().set_AutoSize(true);
				((Control)q6K()).set_Font(new Font(Rc6.Yy4s1(1, 947755588, typeof(Tq1r9), '\a'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 20;
				break;
			case 20:
				((Control)q6K()).set_Location(new Point(114, 279));
				((Control)q6K()).set_Name(Rc6.Yy4s1(6, 947756449, typeof(Rc6), '\u0010'));
				num = 254;
				break;
			case 254:
				((Control)q6K()).set_Size(new Size(93, 18));
				((Control)q6K()).set_TabIndex(114);
				num = 413;
				break;
			case 413:
				q6K().set_Text(Rc6.Yy4s1(7, 947755132, typeof(Rg.Wk), '\u0098'));
				num = 69;
				break;
			case 69:
				z4Z().set_AutoSize(true);
				((Control)z4Z()).set_Font(new Font(Rc6.Yy4s1(5, 947755584, typeof(s6), 'q'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 99;
				break;
			case 99:
				((Control)z4Z()).set_Location(new Point(114, 233));
				((Control)z4Z()).set_Name(Rc6.Yy4s1(5, 947756416, typeof(Tq1r9), '³'));
				num = 229;
				break;
			case 229:
				((Control)z4Z()).set_Size(new Size(122, 18));
				((Control)z4Z()).set_TabIndex(96);
				num = 429;
				break;
			case 429:
				z4Z().set_Text(Rc6.Yy4s1(1, 947756530, typeof(g5), 'F'));
				num = 359;
				break;
			case 359:
				p6X().set_AutoSize(true);
				((Control)p6X()).set_Font(new Font(Rc6.Yy4s1(4, 947755585, typeof(Rg.Wk), 'J'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 72;
				break;
			case 72:
				((Control)p6X()).set_Location(new Point(114, 189));
				((Control)p6X()).set_Name(Rc6.Yy4s1(3, 947756497, typeof(p2W0F), 'Ë'));
				num = 286;
				break;
			case 286:
				((Control)p6X()).set_Size(new Size(130, 18));
				((Control)p6X()).set_TabIndex(95);
				num = 208;
				break;
			case 208:
				p6X().set_Text(Rc6.Yy4s1(1, 947756505, typeof(b4), '±'));
				num = 349;
				break;
			case 349:
				o0P().set_AutoSize(true);
				((Control)o0P()).set_Font(new Font(Rc6.Yy4s1(4, 947755585, typeof(Tq1r9), '\u0099'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 364;
				break;
			case 364:
				((Control)o0P()).set_Location(new Point(114, 143));
				((Control)o0P()).set_Name(Rc6.Yy4s1(0, 947756346, typeof(p2W0F.m1BLz), '('));
				num = 294;
				break;
			case 294:
				((Control)o0P()).set_Size(new Size(124, 18));
				((Control)o0P()).set_TabIndex(94);
				num = 418;
				break;
			case 418:
				o0P().set_Text(Rc6.Yy4s1(8, 947756328, typeof(Rg.Zq), 'F'));
				num = 292;
				break;
			case 292:
				q1M().set_AutoSize(true);
				((Control)q1M()).set_Font(new Font(Rc6.Yy4s1(4, 947755585, typeof(Tq1r9), 'Æ'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 344;
				break;
			case 344:
				((Control)q1M()).set_ForeColor(Color.FromArgb(192, 57, 43));
				((Control)q1M()).set_Location(new Point(706, 24));
				num = 388;
				break;
			case 388:
				((Control)q1M()).set_Name(Rc6.Yy4s1(2, 947756319, typeof(Rg.Wk), 'º'));
				num = 33;
				break;
			case 33:
				((Control)q1M()).set_Size(new Size(152, 18));
				((Control)q1M()).set_TabIndex(92);
				num = 243;
				break;
			case 243:
				q1M().set_Text(Rc6.Yy4s1(5, 947756289, typeof(a9), 'ô'));
				num = 400;
				break;
			case 400:
				((Control)e6R()).set_Location(new Point(631, 420));
				((Control)e6R()).set_Name(Rc6.Yy4s1(3, 947756411, typeof(a9), 'w'));
				num = r[197] + 329;
				break;
			case 431:
				((Control)e6R()).set_Size(new Size(10, 74));
				((Control)e6R()).set_TabIndex(68);
				num = 369;
				break;
			case 369:
				Bx3().set_BackColor(SystemColors.Control);
				((Control)Bx3()).get_Controls().Add((Control)(object)k4D());
				num = 200;
				break;
			case 200:
				((Control)Bx3()).set_ForeColor(Color.Black);
				Bx3().set_Location(new Point(4, 22));
				num = 35;
				break;
			case 35:
				((Control)Bx3()).set_Margin(new Padding(5));
				((Control)Bx3()).set_Name(Rc6.Yy4s1(3, 947756368, typeof(Tq1r9), 'z'));
				num = 227;
				break;
			case 227:
				((Control)Bx3()).set_Padding(new Padding(10, 5, 10, 5));
				num = 260;
				break;
			case 260:
				((Control)Bx3()).set_Size(new Size(947, 525));
				Bx3().set_TabIndex(3);
				num = 111;
				break;
			case 111:
				Bx3().set_Text(Rc6.Yy4s1(8, 947756375, typeof(a9), 's'));
				num = 114;
				break;
			case 114:
				k4D().set_ColumnCount(1);
				k4D().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
				num = 60;
				break;
			case 60:
				k4D().get_Controls().Add((Control)(object)Yn7(), 0, 2);
				k4D().get_Controls().Add((Control)(object)t5W(), 0, 0);
				num = 8;
				break;
			case 8:
				k4D().get_Controls().Add((Control)(object)j4G(), 0, 1);
				num = 334;
				break;
			case 334:
				((Control)k4D()).set_Dock((DockStyle)5);
				((Control)k4D()).set_Location(new Point(10, 5));
				num = 205;
				break;
			case 205:
				((Control)k4D()).set_Name(Rc6.Yy4s1(4, 947756355, typeof(p2W0F), 'î'));
				num = 108;
				break;
			case 108:
				k4D().set_RowCount(3);
				k4D().get_RowStyles().Add(new RowStyle((SizeType)2, 8.487085f));
				num = 383;
				break;
			case 383:
				k4D().get_RowStyles().Add(new RowStyle((SizeType)2, 81.36531f));
				k4D().get_RowStyles().Add(new RowStyle((SizeType)2, 10.1476f));
				num = 152;
				break;
			case 152:
				((Control)k4D()).set_Size(new Size(927, 515));
				((Control)k4D()).set_TabIndex(40);
				num = 185;
				break;
			case 185:
				Yn7().set_ColumnCount(3);
				Yn7().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
				num = 81;
				break;
			case 81:
				Yn7().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 65.14658f));
				Yn7().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 14.87514f));
				num = 310;
				break;
			case 310:
				Yn7().get_Controls().Add((Control)(object)Cf5(), 2, 0);
				((Control)Yn7()).set_Dock((DockStyle)5);
				num = 394;
				break;
			case 394:
				((Control)Yn7()).set_Location(new Point(3, 465));
				((Control)Yn7()).set_Name(Rc6.Yy4s1(2, 947753657, typeof(b4), '\u001b'));
				num = 336;
				break;
			case 336:
				((Control)Yn7()).set_Padding(new Padding(0, 10, 0, 0));
				num = 291;
				break;
			case 291:
				Yn7().set_RowCount(1);
				Yn7().get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
				num = 131;
				break;
			case 131:
				((Control)Yn7()).set_Size(new Size(921, 47));
				((Control)Yn7()).set_TabIndex(37);
				num = 312;
				break;
			case 312:
				((Control)t5W()).get_Controls().Add((Control)(object)a5R());
				((Control)t5W()).set_Dock((DockStyle)5);
				num = 333;
				break;
			case 333:
				((Control)t5W()).set_Location(new Point(3, 3));
				((Control)t5W()).set_Name(Rc6.Yy4s1(3, 947755340, typeof(Rg.Wk), '\u0091'));
				num = 296;
				break;
			case 296:
				((Control)t5W()).set_Size(new Size(921, 37));
				((Control)t5W()).set_TabIndex(78);
				num = 214;
				break;
			case 214:
				((Control)a5R()).set_Dock((DockStyle)5);
				((Control)a5R()).set_Font(new Font(Rc6.Yy4s1(8, 947755597, typeof(b4), '9'), 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 311;
				break;
			case 311:
				((Control)a5R()).set_Location(new Point(0, 0));
				((Control)a5R()).set_Name(Rc6.Yy4s1(2, 947756275, typeof(Rc6), 'l'));
				num = 376;
				break;
			case 376:
				((Control)a5R()).set_Size(new Size(921, 37));
				((Control)a5R()).set_TabIndex(71);
				num = 132;
				break;
			case 132:
				a5R().set_Text(Rc6.Yy4s1(3, 947753626, typeof(Tq1r9), '½'));
				num = 389;
				break;
			case 389:
				a5R().set_TextAlign((ContentAlignment)32);
				((ScrollableControl)j4G()).set_AutoScroll(true);
				num = 85;
				break;
			case 85:
				((Control)j4G()).set_BackColor(Color.White);
				j4G().set_BorderStyle((BorderStyle)1);
				num = 50;
				break;
			case 50:
				((Control)j4G()).get_Controls().Add((Control)(object)o7E());
				((Control)j4G()).get_Controls().Add((Control)(object)z8K());
				num = 30;
				break;
			case 30:
				((Control)j4G()).get_Controls().Add((Control)(object)Tg4());
				((Control)j4G()).get_Controls().Add((Control)(object)f1K());
				num = 98;
				break;
			case 98:
				((Control)j4G()).get_Controls().Add((Control)(object)Jc8());
				((Control)j4G()).get_Controls().Add((Control)(object)q3Y());
				num = 326;
				break;
			case 326:
				((Control)j4G()).get_Controls().Add((Control)(object)Ss3());
				((Control)j4G()).get_Controls().Add((Control)(object)k0D());
				num = 154;
				break;
			case 154:
				((Control)j4G()).get_Controls().Add((Control)(object)z8Y());
				((Control)j4G()).get_Controls().Add((Control)(object)Xf2());
				num = 32;
				break;
			case 32:
				((Control)j4G()).get_Controls().Add((Control)(object)x9Y());
				((Control)j4G()).get_Controls().Add((Control)(object)d8P());
				num = 368;
				break;
			case 368:
				((Control)j4G()).get_Controls().Add((Control)(object)y6L());
				((Control)j4G()).set_Dock((DockStyle)5);
				num = 301;
				break;
			case 301:
				((Control)j4G()).set_Location(new Point(3, 46));
				((Control)j4G()).set_Name(Rc6.Yy4s1(4, 947753609, typeof(Rg), '\b'));
				num = 417;
				break;
			case 417:
				((Control)j4G()).set_Size(new Size(921, 413));
				((Control)j4G()).set_TabIndex(38);
				num = 201;
				break;
			case 201:
				((TextBoxBase)z8K()).set_BackColor(Color.White);
				((TextBoxBase)z8K()).set_BorderStyle((BorderStyle)1);
				num = 329;
				break;
			case 329:
				((Control)z8K()).set_Font(new Font(Rc6.Yy4s1(5, 947756689, typeof(p2W0F.m1BLz), '£'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 228;
				break;
			case 228:
				((TextBoxBase)z8K()).set_ForeColor(Color.Black);
				((Control)z8K()).set_Location(new Point(319, 169));
				num = 385;
				break;
			case 385:
				((TextBoxBase)z8K()).set_MaxLength(100);
				z8K().set_Multiline(true);
				num = 377;
				break;
			case 377:
				((Control)z8K()).set_Name(Rc6.Yy4s1(7, 947753700, typeof(Tq1r9), 'j'));
				num = 217;
				break;
			case 217:
				((Control)z8K()).set_Size(new Size(303, 27));
				((Control)z8K()).set_TabIndex(139);
				num = 235;
				break;
			case 235:
				((Control)z8K()).set_Tag((object)Rc6.Yy4s1(2, 947755775, typeof(s6), 'ú'));
				num = 306;
				break;
			case 306:
				Tg4().set_AutoSize(true);
				((Control)Tg4()).set_Font(new Font(Rc6.Yy4s1(1, 947755588, typeof(s6), '®'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 37;
				break;
			case 37:
				((Control)Tg4()).set_Location(new Point(113, 172));
				((Control)Tg4()).set_Name(Rc6.Yy4s1(6, 947753682, typeof(Rg.p0<>), '\u0086'));
				num = array[33] * 8;
				break;
			case 56:
				((Control)Tg4()).set_Size(new Size(101, 18));
				((Control)Tg4()).set_TabIndex(138);
				num = r[214] + 195;
				break;
			case 299:
				Tg4().set_Text(Rc6.Yy4s1(3, 947753665, typeof(Rg.Zq), '/'));
				num = 68;
				break;
			case 68:
				f1K().set_DropDownStyle((ComboBoxStyle)2);
				((Control)f1K()).set_Font(new Font(Rc6.Yy4s1(6, 947756690, typeof(j1X0S), 'ü'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 93;
				break;
			case 93:
				((ListControl)f1K()).set_FormattingEnabled(true);
				f1K().get_Items().AddRange(new object[2]
				{
					Rc6.Yy4s1(1, 947753507, typeof(b4), '\u0098'),
					Rc6.Yy4s1(6, 947753513, typeof(a9), '~')
				});
				num = 324;
				break;
			case 324:
				((Control)f1K()).set_Location(new Point(319, 125));
				((Control)f1K()).set_Name(Rc6.Yy4s1(0, 947753478, typeof(g1BFb), '\u0001'));
				num = 330;
				break;
			case 330:
				((Control)f1K()).set_Size(new Size(303, 28));
				((Control)f1K()).set_TabIndex(137);
				num = 126;
				break;
			case 126:
				Jc8().set_AutoSize(true);
				((Control)Jc8()).set_Font(new Font(Rc6.Yy4s1(6, 947755587, typeof(g5), 'ð'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 433;
				break;
			case 433:
				((Control)Jc8()).set_Location(new Point(113, 129));
				((Control)Jc8()).set_Name(Rc6.Yy4s1(3, 947753596, typeof(g1BFb), 'ä'));
				num = 353;
				break;
			case 353:
				((Control)Jc8()).set_Size(new Size(167, 18));
				((Control)Jc8()).set_TabIndex(136);
				num = 224;
				break;
			case 224:
				Jc8().set_Text(Rc6.Yy4s1(2, 947753552, typeof(Rg.p0<>), 'È'));
				num = 251;
				break;
			case 251:
				((TextBoxBase)q3Y()).set_BackColor(Color.White);
				((TextBoxBase)q3Y()).set_BorderStyle((BorderStyle)1);
				num = 88;
				break;
			case 88:
				((Control)q3Y()).set_Font(new Font(Rc6.Yy4s1(6, 947756690, typeof(a9), '>'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 4;
				break;
			case 4:
				((TextBoxBase)q3Y()).set_ForeColor(Color.Black);
				((Control)q3Y()).set_Location(new Point(319, 260));
				num = 176;
				break;
			case 176:
				((TextBoxBase)q3Y()).set_MaxLength(100);
				q3Y().set_Multiline(true);
				num = 314;
				break;
			case 314:
				((Control)q3Y()).set_Name(Rc6.Yy4s1(5, 947753537, typeof(p2W0F.m1BLz), 'n'));
				num = 384;
				break;
			case 384:
				((Control)q3Y()).set_Size(new Size(303, 88));
				((Control)q3Y()).set_TabIndex(119);
				num = 76;
				break;
			case 76:
				((Control)q3Y()).set_Tag((object)Rc6.Yy4s1(4, 947755769, typeof(b4), '>'));
				num = 127;
				break;
			case 127:
				((TextBoxBase)Ss3()).set_BackColor(Color.White);
				((TextBoxBase)Ss3()).set_BorderStyle((BorderStyle)1);
				num = 29;
				break;
			case 29:
				((Control)Ss3()).set_Font(new Font(Rc6.Yy4s1(8, 947756700, typeof(s6), '\u0083'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 189;
				break;
			case 189:
				((TextBoxBase)Ss3()).set_ForeColor(Color.Black);
				((Control)Ss3()).set_Location(new Point(319, 213));
				num = 220;
				break;
			case 220:
				((TextBoxBase)Ss3()).set_MaxLength(100);
				Ss3().set_Multiline(true);
				num = 280;
				break;
			case 280:
				((Control)Ss3()).set_Name(Rc6.Yy4s1(4, 947753893, typeof(p2W0F.m1BLz), 'S'));
				num = 61;
				break;
			case 61:
				((Control)Ss3()).set_Size(new Size(303, 27));
				((Control)Ss3()).set_TabIndex(118);
				num = r[6] + r[377];
				break;
			case 273:
				((Control)Ss3()).set_Tag((object)Rc6.Yy4s1(0, 947755773, typeof(Rg.p0<>), 'M'));
				num = 272;
				break;
			case 272:
				((TextBoxBase)k0D()).set_BackColor(Color.White);
				((TextBoxBase)k0D()).set_BorderStyle((BorderStyle)1);
				num = 386;
				break;
			case 386:
				((Control)k0D()).set_Font(new Font(Rc6.Yy4s1(0, 947756692, typeof(s6), '\u009c'), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 410;
				break;
			case 410:
				((TextBoxBase)k0D()).set_ForeColor(Color.Black);
				((Control)k0D()).set_Location(new Point(319, 82));
				num = 290;
				break;
			case 290:
				((TextBoxBase)k0D()).set_MaxLength(100);
				k0D().set_Multiline(true);
				num = 63;
				break;
			case 63:
				((Control)k0D()).set_Name(Rc6.Yy4s1(8, 947753886, typeof(Rg), '%'));
				num = 40;
				break;
			case 40:
				((Control)k0D()).set_Size(new Size(303, 27));
				((Control)k0D()).set_TabIndex(116);
				num = 226;
				break;
			case 226:
				((Control)k0D()).set_Tag((object)Rc6.Yy4s1(8, 947755765, typeof(Rg.p0<>), '\u00a8'));
				num = 158;
				break;
			case 158:
				z8Y().set_AutoSize(true);
				((Control)z8Y()).set_Font(new Font(Rc6.Yy4s1(6, 947755587, typeof(Rg.Zq), 'r'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 194;
				break;
			case 194:
				((Control)z8Y()).set_Location(new Point(111, 263));
				((Control)z8Y()).set_Name(Rc6.Yy4s1(5, 947753713, typeof(o0), '×'));
				num = 397;
				break;
			case 397:
				((Control)z8Y()).set_Size(new Size(80, 18));
				((Control)z8Y()).set_TabIndex(114);
				num = 342;
				break;
			case 342:
				z8Y().set_Text(Rc6.Yy4s1(3, 947753864, typeof(g1BFb), '¾'));
				num = 438;
				break;
			case 438:
				Xf2().set_AutoSize(true);
				((Control)Xf2()).set_Font(new Font(Rc6.Yy4s1(6, 947755587, typeof(b4), '±'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = r[28] + 11;
				break;
			case 160:
				((Control)Xf2()).set_Location(new Point(113, 218));
				((Control)Xf2()).set_Name(Rc6.Yy4s1(1, 947753708, typeof(Rg), '\u0090'));
				num = 141;
				break;
			case 141:
				((Control)Xf2()).set_Size(new Size(139, 18));
				((Control)Xf2()).set_TabIndex(96);
				num = 399;
				break;
			case 399:
				Xf2().set_Text(Rc6.Yy4s1(2, 947753942, typeof(a9), 'Ý'));
				num = 147;
				break;
			case 147:
				x9Y().set_AutoSize(true);
				((Control)x9Y()).set_Font(new Font(Rc6.Yy4s1(4, 947755585, typeof(Rg), '\u00a0'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 84;
				break;
			case 84:
				((Control)x9Y()).set_Location(new Point(113, 85));
				((Control)x9Y()).set_Name(Rc6.Yy4s1(5, 947753932, typeof(Rg.p0<>), '\u008e'));
				num = 43;
				break;
			case 43:
				((Control)x9Y()).set_Size(new Size(124, 18));
				((Control)x9Y()).set_TabIndex(93);
				num = 422;
				break;
			case 422:
				x9Y().set_Text(Rc6.Yy4s1(5, 947756325, typeof(Rg.Zq), 'I'));
				num = 434;
				break;
			case 434:
				d8P().set_AutoSize(true);
				((Control)d8P()).set_Font(new Font(Rc6.Yy4s1(1, 947755588, typeof(p2W0F), 'õ'), 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 267;
				break;
			case 267:
				((Control)d8P()).set_ForeColor(Color.FromArgb(192, 57, 43));
				((Control)d8P()).set_Location(new Point(689, 24));
				num = 44;
				break;
			case 44:
				((Control)d8P()).set_Name(Rc6.Yy4s1(0, 947753829, typeof(k4), '\u007f'));
				num = 5;
				break;
			case 5:
				((Control)d8P()).set_Size(new Size(152, 18));
				((Control)d8P()).set_TabIndex(92);
				num = 24;
				break;
			case 24:
				d8P().set_Text(Rc6.Yy4s1(6, 947756290, typeof(p2W0F), 'J'));
				num = 195;
				break;
			case 195:
				((Control)y6L()).set_Location(new Point(631, 420));
				((Control)y6L()).set_Name(Rc6.Yy4s1(7, 947753133, typeof(Rg.Zq), '\b'));
				num = 116;
				break;
			case 116:
				((Control)y6L()).set_Size(new Size(10, 74));
				((Control)y6L()).set_TabIndex(68);
				num = 71;
				break;
			case 71:
				((ButtonBase)t3Q()).set_BackColor(Color.FromArgb(41, 128, 185));
				((Control)t3Q()).set_Dock((DockStyle)5);
				num = 112;
				break;
			case 112:
				((ButtonBase)t3Q()).get_FlatAppearance().set_BorderColor(Color.Black);
				((ButtonBase)t3Q()).get_FlatAppearance().set_BorderSize(0);
				num = 59;
				break;
			case 59:
				((ButtonBase)t3Q()).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(52, 152, 219));
				num = 395;
				break;
			case 395:
				((ButtonBase)t3Q()).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(52, 152, 219));
				((ButtonBase)t3Q()).set_FlatStyle((FlatStyle)0);
				num = 55;
				break;
			case 55:
				((Control)t3Q()).set_Font(new Font(Rc6.Yy4s1(6, 947756690, typeof(a9), 'Ú'), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 42;
				break;
			case 42:
				((Control)t3Q()).set_ForeColor(Color.White);
				((ButtonBase)t3Q()).set_ImageAlign((ContentAlignment)16);
				num = 138;
				break;
			case 138:
				((Control)t3Q()).set_Location(new Point(785, 10));
				((Control)t3Q()).set_Margin(new Padding(0));
				num = 248;
				break;
			case 248:
				((Control)t3Q()).set_Name(Rc6.Yy4s1(5, 947753098, typeof(Rg.Wk), 'Õ'));
				num = 258;
				break;
			case 258:
				((Control)t3Q()).set_Size(new Size(136, 37));
				((Control)t3Q()).set_TabIndex(34);
				num = 169;
				break;
			case 169:
				((Control)t3Q()).set_TabStop(false);
				((ButtonBase)t3Q()).set_Text(Rc6.Yy4s1(5, 947753192, typeof(j1X0S), 'ë'));
				num = 396;
				break;
			case 396:
				((ButtonBase)t3Q()).set_TextImageRelation((TextImageRelation)4);
				((ButtonBase)t3Q()).set_UseVisualStyleBackColor(false);
				num = 430;
				break;
			case 430:
				((ButtonBase)Sp3()).set_BackColor(Color.FromArgb(39, 174, 96));
				((Control)Sp3()).set_Dock((DockStyle)5);
				num = 49;
				break;
			case 49:
				((ButtonBase)Sp3()).get_FlatAppearance().set_BorderColor(Color.Black);
				((ButtonBase)Sp3()).get_FlatAppearance().set_BorderSize(0);
				num = 278;
				break;
			case 278:
				((ButtonBase)Sp3()).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(46, 204, 113));
				num = 146;
				break;
			case 146:
				((ButtonBase)Sp3()).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(46, 204, 113));
				((ButtonBase)Sp3()).set_FlatStyle((FlatStyle)0);
				num = 179;
				break;
			case 179:
				((Control)Sp3()).set_Font(new Font(Rc6.Yy4s1(0, 947756692, typeof(Rc6), '\v'), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 149;
				break;
			case 149:
				((Control)Sp3()).set_ForeColor(Color.White);
				((ButtonBase)Sp3()).set_ImageAlign((ContentAlignment)16);
				num = 11;
				break;
			case 11:
				((Control)Sp3()).set_Location(new Point(788, 10));
				((Control)Sp3()).set_Margin(new Padding(0));
				num = 230;
				break;
			case 230:
				((Control)Sp3()).set_Name(Rc6.Yy4s1(2, 947753019, typeof(b6), '0'));
				num = 412;
				break;
			case 412:
				((Control)Sp3()).set_Size(new Size(133, 37));
				((Control)Sp3()).set_TabIndex(34);
				num = 187;
				break;
			case 187:
				((Control)Sp3()).set_TabStop(false);
				((ButtonBase)Sp3()).set_Text(Rc6.Yy4s1(0, 947752964, typeof(a9), 'ê'));
				num = 164;
				break;
			case 164:
				((ButtonBase)Sp3()).set_TextImageRelation((TextImageRelation)4);
				((ButtonBase)Sp3()).set_UseVisualStyleBackColor(false);
				num = 266;
				break;
			case 266:
				((ButtonBase)Cf5()).set_BackColor(Color.FromArgb(39, 174, 96));
				((Control)Cf5()).set_Dock((DockStyle)5);
				num = 96;
				break;
			case 96:
				((ButtonBase)Cf5()).get_FlatAppearance().set_BorderColor(Color.Black);
				((ButtonBase)Cf5()).get_FlatAppearance().set_BorderSize(0);
				num = 3;
				break;
			case 3:
				((ButtonBase)Cf5()).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(46, 204, 113));
				num = 313;
				break;
			case 313:
				((ButtonBase)Cf5()).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(46, 204, 113));
				((ButtonBase)Cf5()).set_FlatStyle((FlatStyle)0);
				num = 416;
				break;
			case 416:
				((Control)Cf5()).set_Font(new Font(Rc6.Yy4s1(8, 947756700, typeof(o0), 'Ì'), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 419;
				break;
			case 419:
				((Control)Cf5()).set_ForeColor(Color.White);
				((ButtonBase)Cf5()).set_ImageAlign((ContentAlignment)16);
				num = 168;
				break;
			case 168:
				((Control)Cf5()).set_Location(new Point(783, 10));
				((Control)Cf5()).set_Margin(new Padding(0));
				num = 177;
				break;
			case 177:
				((Control)Cf5()).set_Name(Rc6.Yy4s1(5, 947753047, typeof(Rg), '4'));
				num = 338;
				break;
			case 338:
				((Control)Cf5()).set_Size(new Size(138, 37));
				((Control)Cf5()).set_TabIndex(34);
				num = 135;
				break;
			case 135:
				((Control)Cf5()).set_TabStop(false);
				((ButtonBase)Cf5()).set_Text(Rc6.Yy4s1(7, 947753394, typeof(k4), 'ó'));
				num = 171;
				break;
			case 171:
				((ButtonBase)Cf5()).set_TextImageRelation((TextImageRelation)4);
				((ButtonBase)Cf5()).set_UseVisualStyleBackColor(false);
				num = 125;
				break;
			case 125:
				((ButtonBase)o7E()).set_BackColor(Color.FromArgb(41, 128, 185));
				((ButtonBase)o7E()).get_FlatAppearance().set_BorderColor(Color.Black);
				num = 339;
				break;
			case 339:
				((ButtonBase)o7E()).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(52, 152, 219));
				num = 0;
				break;
			case 0:
				((ButtonBase)o7E()).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(52, 152, 219));
				((ButtonBase)o7E()).set_FlatStyle((FlatStyle)0);
				num = 370;
				break;
			case 370:
				((Control)o7E()).set_Font(new Font(Rc6.Yy4s1(1, 947756693, typeof(Rg.p0<>), 'b'), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 421;
				break;
			case 421:
				((Control)o7E()).set_ForeColor(Color.White);
				((ButtonBase)o7E()).set_Image((Image)(obj as ComponentResourceManager).GetObject(Rc6.Yy4s1(2, 947753382, typeof(g5), 'ß')));
				num = 25;
				break;
			case 25:
				((Control)o7E()).set_Location(new Point(639, 82));
				((Control)o7E()).set_Margin(new Padding(0));
				num = 216;
				break;
			case 216:
				((Control)o7E()).set_Name(Rc6.Yy4s1(7, 947753466, typeof(p2W0F.m1BLz), '\t'));
				num = r[82] + 338;
				break;
			case 373:
				((Control)o7E()).set_Size(new Size(36, 27));
				((Control)o7E()).set_TabIndex(142);
				num = 381;
				break;
			case 381:
				((Control)o7E()).set_TabStop(false);
				((ButtonBase)o7E()).set_TextImageRelation((TextImageRelation)4);
				num = 335;
				break;
			case 335:
				((ButtonBase)o7E()).set_UseVisualStyleBackColor(false);
				((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
				num = 53;
				break;
			case 53:
				((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
				((Form)this).set_ClientSize(new Size(955, 551));
				num = 271;
				break;
			case 271:
				((Control)this).get_Controls().Add((Control)(object)Wj());
				((Form)this).set_FormBorderStyle((FormBorderStyle)1);
				num = 101;
				break;
			case 101:
				((Form)this).set_Icon((Icon)(obj as ComponentResourceManager).GetObject(Rc6.Yy4s1(6, 947753974, typeof(o0), '\u0011')));
				num = 379;
				break;
			case 379:
				((Form)this).set_MaximizeBox(false);
				((Control)this).set_Name(Rc6.Yy4s1(6, 947753416, typeof(g1BFb), '^'));
				num = 346;
				break;
			case 346:
				((Form)this).set_StartPosition((FormStartPosition)4);
				((Form)this).set_Text(Rc6.Yy4s1(3, 947753277, typeof(a9), '\u001a'));
				num = 103;
				break;
			case 103:
				((Control)Wj()).ResumeLayout(false);
				((Control)b0()).ResumeLayout(false);
				num = 54;
				break;
			case 54:
				((Control)Kw()).ResumeLayout(false);
				((Control)Ka()).ResumeLayout(false);
				num = 237;
				break;
			case 237:
				((Control)x4()).ResumeLayout(false);
				((Control)x4()).PerformLayout();
				num = 362;
				break;
			case 362:
				((ISupportInitialize)Qn4()).EndInit();
				((Control)w5J()).ResumeLayout(false);
				((Control)z4L()).ResumeLayout(false);
				num = r[98] - 42;
				break;
			case 170:
				((Control)Hr6()).ResumeLayout(false);
				((Control)Tq0()).ResumeLayout(false);
				num = 404;
				break;
			case 404:
				((Control)b6Z()).ResumeLayout(false);
				((Control)z5G()).ResumeLayout(false);
				num = 265;
				break;
			case 265:
				((Control)Gy8()).ResumeLayout(false);
				((Control)o7S()).ResumeLayout(false);
				num = 2;
				break;
			case 2:
				((Control)o7S()).PerformLayout();
				((Control)Bx3()).ResumeLayout(false);
				num = 128;
				break;
			case 128:
				((Control)k4D()).ResumeLayout(false);
				((Control)Yn7()).ResumeLayout(false);
				num = 19;
				break;
			case 19:
				((Control)t5W()).ResumeLayout(false);
				((Control)j4G()).ResumeLayout(false);
				num = 167;
				break;
			case 167:
				((Control)j4G()).PerformLayout();
				((Control)this).ResumeLayout(false);
				return;
			}
		}
	}

	[SpecialName]
	internal virtual TabControl Wj()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4(TabControl P_0)
	{
		//Discarded unreachable code: IL_0008
		y = P_0;
	}

	[SpecialName]
	internal virtual TabPage b0()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c1(TabPage P_0)
	{
		//Discarded unreachable code: IL_0008
		B = P_0;
	}

	[SpecialName]
	internal virtual Panel Kw()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void An(Panel P_0)
	{
		//Discarded unreachable code: IL_0008
		H = P_0;
	}

	[SpecialName]
	internal virtual TableLayoutPanel Ka()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void En(TableLayoutPanel P_0)
	{
		//Discarded unreachable code: IL_0014
		O.E = ((P_0 is TableLayoutPanel) ? P_0 : null);
	}

	[SpecialName]
	internal virtual Panel x4()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		Panel e = E;
		b4.R[407] = (byte)((b4.R[407] + b4.R[418]) & 0x98);
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lg(Panel P_0)
	{
		//Discarded unreachable code: IL_0008
		E = P_0;
	}

	[SpecialName]
	internal virtual Label Cm()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bb(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		v = P_0;
	}

	[SpecialName]
	internal virtual Label Qi()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ax(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		a = P_0;
	}

	[SpecialName]
	internal virtual Label Ec()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dd(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		i = P_0;
	}

	[SpecialName]
	internal virtual Label e7()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q0(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.i = P_0;
	}

	[SpecialName]
	internal virtual Label z2()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y2(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		R = P_0;
	}

	[SpecialName]
	internal virtual Label Ng()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m2(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.k = P_0;
	}

	[SpecialName]
	internal virtual Label b5()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jn3(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		C = P_0;
	}

	[SpecialName]
	internal virtual Label d8Z()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gt4(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.N = P_0;
	}

	[SpecialName]
	internal virtual Label a5T()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bs4(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.R = P_0;
	}

	[SpecialName]
	internal virtual Label Te9()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7A(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.j = P_0;
	}

	[SpecialName]
	internal virtual Label g2C()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jj8(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		u = P_0;
	}

	[SpecialName]
	internal virtual Label Sj8()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ar6(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		O.Y = ((P_0 is Label) ? P_0 : null);
	}

	[SpecialName]
	internal virtual Label g0J()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d2Q(Label P_0)
	{
		//Discarded unreachable code: IL_0033
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.m = P_0;
		g5.I[116] = (byte)((g5.I[116] - g5.I[114]) & 0x92);
	}

	[SpecialName]
	internal virtual Label Mw3()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c6R(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		l = P_0;
	}

	[SpecialName]
	internal virtual TableLayoutPanel w5J()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		TableLayoutPanel result = O.l;
		b4.R[80] = (byte)((b4.R[80] ^ b4.R[341]) & 0xA3);
		return result;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ry7(TableLayoutPanel P_0)
	{
		//Discarded unreachable code: IL_0014
		O.l = ((P_0 is TableLayoutPanel) ? P_0 : null);
	}

	[SpecialName]
	internal virtual Button t3Q()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		Button result = n;
		b4.R[78] = (byte)((b4.R[78] ^ b4.R[233]) & 0xB9);
		return result;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d9Q(Button P_0)
	{
		//Discarded unreachable code: IL_0008
		n = P_0;
	}

	[SpecialName]
	internal virtual Panel z4L()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d3B(Panel P_0)
	{
		//Discarded unreachable code: IL_0008
		W = P_0;
	}

	[SpecialName]
	internal virtual Label t2Z()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sb4(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		o = P_0;
	}

	[SpecialName]
	internal virtual TabPage Hr6()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hk8(TabPage P_0)
	{
		//Discarded unreachable code: IL_0008
		k = P_0;
	}

	[SpecialName]
	internal virtual Panel Tq0()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ay3(Panel P_0)
	{
		//Discarded unreachable code: IL_0014
		O.X = ((P_0 is Panel) ? P_0 : null);
	}

	[SpecialName]
	internal virtual TableLayoutPanel b6Z()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gi9(TableLayoutPanel P_0)
	{
		//Discarded unreachable code: IL_0014
		O.G = ((P_0 is TableLayoutPanel) ? P_0 : null);
	}

	[SpecialName]
	internal virtual TableLayoutPanel z5G()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		TableLayoutPanel result = yy;
		b4.R[20] = (byte)((b4.R[20] + g5.I[54]) & 0xE7);
		return result;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0S(TableLayoutPanel P_0)
	{
		//Discarded unreachable code: IL_0008
		yy = P_0;
	}

	[SpecialName]
	internal virtual Button Sp3()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		Button q = O.q;
		g5.I[258] = (byte)((g5.I[258] ^ b4.R[153]) & 0xA6);
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rx1(Button P_0)
	{
		//Discarded unreachable code: IL_0014
		O.q = ((P_0 is Button) ? P_0 : null);
	}

	[SpecialName]
	internal virtual Panel Gy8()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return yH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t8A(Panel P_0)
	{
		//Discarded unreachable code: IL_0008
		yH = P_0;
	}

	[SpecialName]
	internal virtual Label Ca0()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return yS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s7X(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		yS = P_0;
	}

	[SpecialName]
	internal virtual Panel o7S()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		Panel result = yE;
		b4.R[332] = g5.I[16];
		return result;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aj6(Panel P_0)
	{
		//Discarded unreachable code: IL_0008
		yE = P_0;
	}

	[SpecialName]
	internal virtual ComboBox Fz7()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return yv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wg2(ComboBox P_0)
	{
		//Discarded unreachable code: IL_0008
		yv = P_0;
	}

	[SpecialName]
	internal virtual TextBox w0X()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		TextBox s = O.s;
		b4.R[95] = (byte)((b4.R[95] * b4.R[30]) & 0x82);
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c4Y(TextBox P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.s = P_0;
	}

	[SpecialName]
	internal virtual TextBox Mb5()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return yi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3T(TextBox P_0)
	{
		//Discarded unreachable code: IL_0008
		yi = P_0;
	}

	[SpecialName]
	internal virtual TextBox f1J()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ap3(TextBox P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.u = P_0;
	}

	[SpecialName]
	internal virtual Label q6K()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		Label result = O.o;
		b4.R[149] = (byte)((b4.R[149] * b4.R[84]) & 0x97);
		return result;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z7Q(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.o = P_0;
	}

	[SpecialName]
	internal virtual Label z4Z()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j3X(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		O.b = ((P_0 is Label) ? P_0 : null);
	}

	[SpecialName]
	internal virtual Label p6X()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k1T(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.p = P_0;
	}

	[SpecialName]
	internal virtual Label o0P()
	{
		//Discarded unreachable code: IL_0008, IL_0022
		byte[] r = b4.R;
		return yM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bo4(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		yM = P_0;
	}

	[SpecialName]
	internal virtual Label q1M()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return yq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yc0(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		yq = P_0;
	}

	[SpecialName]
	internal virtual Panel e6R()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tt0(Panel P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.h = P_0;
	}

	[SpecialName]
	internal virtual TabPage Bx3()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return yu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1H(TabPage P_0)
	{
		//Discarded unreachable code: IL_0008
		yu = P_0;
	}

	[SpecialName]
	internal virtual TableLayoutPanel k4D()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return yx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sf3(TableLayoutPanel P_0)
	{
		//Discarded unreachable code: IL_0008
		yx = P_0;
	}

	[SpecialName]
	internal virtual TableLayoutPanel Yn7()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		TableLayoutPanel d = O.D;
		b4.R[397] = (byte)((b4.R[397] * b4.R[129]) & 0x2D);
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a3D(TableLayoutPanel P_0)
	{
		//Discarded unreachable code: IL_0014
		O.D = ((P_0 is TableLayoutPanel) ? P_0 : null);
	}

	[SpecialName]
	internal virtual Button Cf5()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return yl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jk8(Button P_0)
	{
		//Discarded unreachable code: IL_0008
		yl = P_0;
	}

	[SpecialName]
	internal virtual Panel t5W()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		Panel result = yF;
		b4.R[243] = (byte)(b4.R[243] & b4.R[398] & 0x9F);
		return result;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cm5(Panel P_0)
	{
		//Discarded unreachable code: IL_0008
		yF = P_0;
	}

	[SpecialName]
	internal virtual Label a5R()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1M(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		O.f = ((P_0 is Label) ? P_0 : null);
	}

	[SpecialName]
	internal virtual Panel j4G()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		Panel c = O.C;
		b4.R[183] = (byte)((b4.R[183] | b4.R[356]) & 0x72);
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w0G(Panel P_0)
	{
		//Discarded unreachable code: IL_0014
		O.C = ((P_0 is Panel) ? P_0 : null);
	}

	[SpecialName]
	internal virtual TextBox z8K()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		TextBox result = O.V;
		g5.I[250] = b4.R[25];
		return result;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w0R(TextBox P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.V = P_0;
	}

	[SpecialName]
	internal virtual Label Tg4()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return yk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r0J(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		yk = P_0;
	}

	[SpecialName]
	internal virtual ComboBox f1K()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Px7(ComboBox P_0)
	{
		//Discarded unreachable code: IL_0014
		O.w = ((P_0 is ComboBox) ? P_0 : null);
	}

	[SpecialName]
	internal virtual Label Jc8()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return Bg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mk7(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		Bg = P_0;
	}

	[SpecialName]
	internal virtual TextBox q3Y()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f6S(TextBox P_0)
	{
		//Discarded unreachable code: IL_0036
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.t = P_0;
		b4.R[119] = (byte)((b4.R[119] * b4.R[299]) & 0xEF);
	}

	[SpecialName]
	internal virtual TextBox Ss3()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return BB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mj3(TextBox P_0)
	{
		//Discarded unreachable code: IL_0008
		BB = P_0;
	}

	[SpecialName]
	internal virtual TextBox k0D()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s2N(TextBox P_0)
	{
		//Discarded unreachable code: IL_0014
		O.a = ((P_0 is TextBox) ? P_0 : null);
	}

	[SpecialName]
	internal virtual Label z8Y()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return BS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ki6(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		BS = P_0;
	}

	[SpecialName]
	internal virtual Label Xf2()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.Z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xn6(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		O.Z = ((P_0 is Label) ? P_0 : null);
	}

	[SpecialName]
	internal virtual Label x9Y()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		Label bv = Bv;
		b4.R[160] = (byte)((b4.R[160] - b4.R[327]) & 0xF7);
		return bv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n0M(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		Bv = P_0;
	}

	[SpecialName]
	internal virtual Label d8P()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.iE;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Da7(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		O.iE = ((P_0 is Label) ? P_0 : null);
	}

	[SpecialName]
	internal virtual Panel y6L()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.ii;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xk9(Panel P_0)
	{
		//Discarded unreachable code: IL_0014
		O.ii = ((P_0 is Panel) ? P_0 : null);
	}

	[SpecialName]
	internal virtual Button o7E()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		Button ik = O.ik;
		g5.I[11] = (byte)((g5.I[11] - g5.I[134]) & 0x71);
		return ik;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3S(Button P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.ik = P_0;
	}

	[SpecialName]
	internal virtual DataGridView Qn4()
	{
		//Discarded unreachable code: IL_0008, IL_0022
		byte[] array = g5.I;
		return O.iN;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sc5(DataGridView P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.iN = P_0;
	}

	[SpecialName]
	internal virtual Panel s1X()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.iR;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cb7(Panel P_0)
	{
		//Discarded unreachable code: IL_0039
		O.iR = ((P_0 is Panel) ? P_0 : null);
		b4.R[135] = (byte)((b4.R[135] + g5.I[104]) & 0x8D);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn s5X()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		DataGridViewTextBoxColumn ij = O.ij;
		g5.I[243] = (byte)((g5.I[243] | g5.I[31]) & 0x39);
		return ij;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fx2(DataGridViewTextBoxColumn P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.ij = P_0;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn g0N()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.iY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4K(DataGridViewTextBoxColumn P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.iY = P_0;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Da5()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return Bq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ra2(DataGridViewTextBoxColumn P_0)
	{
		//Discarded unreachable code: IL_0008
		Bq = P_0;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn r9A()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return BJ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fe2(DataGridViewTextBoxColumn P_0)
	{
		//Discarded unreachable code: IL_0008
		BJ = P_0;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn s3F()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		DataGridViewTextBoxColumn bu = Bu;
		g5.I[196] = (byte)((g5.I[196] * g5.I[234]) & 0x43);
		return bu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yd0(DataGridViewTextBoxColumn P_0)
	{
		//Discarded unreachable code: IL_0008
		Bu = P_0;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Qi1()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		DataGridViewTextBoxColumn im = O.im;
		b4.R[224] = (byte)((b4.R[224] | b4.R[200]) & 0x88);
		return im;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0J(DataGridViewTextBoxColumn P_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		O.im = P_0;
	}

	[SpecialName]
	internal virtual TextBox Ss5()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return BP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mm0(TextBox P_0)
	{
		//Discarded unreachable code: IL_0008
		BP = P_0;
	}

	[SpecialName]
	internal virtual Label Cd4()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		Label bl = Bl;
		b4.R[320] = (byte)((b4.R[320] - b4.R[231]) & 0x4A);
		return bl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w7Y(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		Bl = P_0;
	}

	[SpecialName]
	internal virtual Label m6J()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return BF;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gg0(Label P_0)
	{
		//Discarded unreachable code: IL_0008
		BF = P_0;
	}

	[SpecialName]
	public object Jz7()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return O.il;
	}

	[SpecialName]
	public void m6M(object P_0)
	{
		//Discarded unreachable code: IL_0014
		object objectValue = RuntimeHelpers.GetObjectValue(P_0);
		O.il = objectValue;
	}

	[SpecialName]
	public object q8H()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return Bo;
	}

	[SpecialName]
	public void m1G(object P_0)
	{
		//Discarded unreachable code: IL_000d
		Bo = RuntimeHelpers.GetObjectValue(P_0);
	}

	[STAThread]
	public static void x3B()
	{
		//Discarded unreachable code: IL_01f2
		int num = 14;
		checked
		{
			int num3 = default(int);
			int num2 = default(int);
			object obj2 = default(object);
			int num6 = default(int);
			bool flag2 = default(bool);
			object obj3 = default(object);
			object obj = default(object);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					num3 = (int)Math.Round(Math.Floor((double)Rc6.Go84B() / 12.0) + 25.0);
					num = 10;
					break;
				case 10:
					num2 = num3 * 7;
					obj2 = new byte[16];
					goto case 13;
				case 13:
					num6 = 1;
					num = 17;
					break;
				case 17:
					num = ((num6 <= 6) ? 11 : 8);
					break;
				case 8:
					((byte[])obj2)[num6 - 1] = (byte)(num3 * 7);
					num = 9;
					break;
				case 9:
					flag2 = num6 > 7;
					goto case 2;
				case 2:
					num = ((!flag2) ? 15 : 0);
					break;
				case 0:
					((byte[])obj2)[num6 - 1] = (byte)(num3 * 0);
					num = 15;
					break;
				case 15:
					num = 12;
					break;
				case 11:
					((byte[])obj2)[num6 - 1] = (byte)(num3 * num6);
					num = 12;
					break;
				case 12:
					num6++;
					num = ((num6 <= 16) ? 17 : 4);
					break;
				case 4:
				{
					int num5 = Math.Abs(num2 * num2 * 1000);
					obj3 = new List<byte[]>();
					(obj3 as List<byte[]>).Add(obj2 as byte[]);
					num = 7;
					break;
				}
				case 7:
					(obj3 as List<byte[]>).Add(new byte[186880]);
					obj = (List<byte[]>)obj3;
					num = 6;
					break;
				case 6:
				{
					byte[] value = ((List<byte[]>)(obj3 = (List<byte[]>)obj))[1];
					bool num4 = Tq1r9.c8A7Y(ref value, num3);
					(obj3 as List<byte[]>)[1] = value;
					flag = num4;
					num = 1;
					break;
				}
				case 1:
					num = ((!flag) ? 3 : 5);
					break;
				case 5:
					Rc6.j6H8P(((List<byte[]>)obj)[1], ((List<byte[]>)obj)[0], num2);
					num = 3;
					break;
				case 3:
					return;
				}
			}
		}
	}

	internal static void Kt7(byte[] P_0, int P_1, int P_2)
	{
		//Discarded unreachable code: IL_005d
		int num = 1;
		object objectValue = default(object);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
			case 4:
				objectValue = RuntimeHelpers.GetObjectValue(((Assembly)objectValue).GetTypes()[P_1].GetMethods()[0].Invoke(null, new object[0]));
				return;
			}
			objectValue = RuntimeHelpers.GetObjectValue(Rc6.Pz2j4(P_1 % checked(P_2 + 6), P_0));
			num = 4;
		}
	}
}
