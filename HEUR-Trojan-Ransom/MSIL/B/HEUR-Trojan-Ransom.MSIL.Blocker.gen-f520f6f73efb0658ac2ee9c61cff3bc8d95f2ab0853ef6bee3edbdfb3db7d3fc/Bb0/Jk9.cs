using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using f8W;
using o7S;
using r1F;

namespace Bb0;

[DesignerGenerated]
public class Jk9 : Form
{
	private IContainer h;

	internal static f6Y i/* Not supported: data(D3 7B 93 1B 79 2D BA 25 62 37 4D BC 73 CB E1 FA C4 82 D5 42 8A 5B 85 96 75 BF 80 AF 78 45 7E A1 E8 EC 32 EB 7C 38 81 20 99 4E E1 26 FC 39 6D B0 48 C0 53 7C 30 BB 24 78 F5 FB A5 B9 AC 0B AB 1D B8 AB D2 85 98 F4 7D 8B 00 B4 A8 3B 78 5E 99 3B 51 CF 67 B7 F1 01 70 2D C8 B9 F4 80 92 C7 73 8E A1 C4 6D 51 65 E7 17 52 42 C7 7B 7A 13 E7 FE 97 62 69 67 DB A2 F3 2B B6 3B A5 BC DE 00 FC F8 38 41 1A 98 B2 EF 47 D5 69 B7 15 74 29 85 F4 19 DF B9 5C 1E 28 5F 96 EA AD 99 B6 16 BF 2A 38 51 45 CD 43 38 F7 4E 4C A7 1A 93 FD 24 8D 7E 01 31 45 8B DC 25 A2 DD CF D7 AA 2F EA 19 39 31 15 3E 7F C2 2E 5B 42 BB 20 90 6D B4 03 94 61 71 5D 2E 98 84 CF 34 4D 12 AD 66 FD 6A 8D C8 63 32 6D E7 7E BE A4 C9 50 A4 EE 88 6A 4B B7 ED D9 3B 75 39 D0 BB 7F B3 60 E0 F0 6C 15 C6 5C D6 2E 57 2D 3A 46 1A 15 A2 CC 92 DD F2 95 47 C8 01 5A BF 8B C1 F3 54 F6 A6 B2 B9 86 9C CC 38 B4 88 48 17 59 13 1E 7C A6 BF 25 D2 6B 3D DD 8C 1D 19 17 EF 11 54 3B 9A E1 D9 5F 85 87 8B 92 78 D4 94 DD 55 AA 7E EC B5 E1 DC 18 CB 9B 21 E7 B9 C7 25 9C 6D 84 DC 26 5F 4C AD 35 7F B3 97 F4 1A 2C AC FC D6 5F 88 E0 9D 2C 61 0D 33 3B 6E FD BF F1 A5 BC 61 EE 25 F2 F7 6D 7E 08 FC 49 6C 01 4A E7 FC 9F EE 24 10 5A 3F 44 FD 40 23 CE F1 23 DD AE 74 8D 0E D9 93 2B 06 B9 04 69 DF 7F E3 54 BF 5F C2 4B 3E CD 0E 9B E1 4A 7D 1D F0 E4 CF 28 7B 5A 29 4D D4 DE F2 6F 54 D1 98 34 1F A5 79 BF 5F A8 80 C2 0C A5 E4 0F A0 D7 AA C2 5C 75 3A 20 E9 DB ED 85 55 95 7F DF 6C 53 F6 6C 34 D8 7B 3B D0 BC BC 47 64 0C 1B D4 75 1A AC FB 33 30 12 DD 96 77 4A 43 B7 F3 69 C8 29 9F 56 B8 AE 78 D9 C6 5B 6F F0 9E B8 F2 BB DC BF 19 0F 3B E8 83 AC 3B 41 19 D4 BB 8E 38 82 DC 53 F2 1E C4 B5 62 25 FC 3F E4 9F C3 3F 72 25 A3 BB 6C 83 9E E3 2D DF A5) */;

	internal static byte[] G;

	private Ta0.n3L s;

	public Jk9()
	{
		//Discarded unreachable code: IL_000d
		Lc0();
	}

	protected override void n8B(bool P_0)
	{
		//Discarded unreachable code: IL_0063
		try
		{
			int num = 3;
			bool flag = default(bool);
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num = (P_0 ? 7 : 0);
					break;
				case 7:
					num2 = ((h != null) ? 1 : 0);
					goto IL_003e;
				case 0:
					num2 = 0;
					goto IL_003e;
				case 2:
					num = ((!flag) ? 4 : 5);
					break;
				case 5:
					h.Dispose();
					num = 4;
					break;
				case 4:
					return;
					IL_003e:
					flag = (byte)num2 != 0;
					goto case 2;
				}
			}
		}
		finally
		{
			((Form)this).Dispose(P_0);
		}
	}

	private void Lc0()
	{
		//Discarded unreachable code: IL_0278
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		int num = 7;
		while (true)
		{
			switch (num)
			{
			default:
				By1(new Label());
				Kc2(new Label());
				((Control)this).SuspendLayout();
				num = 14;
				break;
			case 14:
				Ho3().set_AutoSize(true);
				((Control)Ho3()).set_ForeColor(SystemColors.ButtonHighlight);
				num = 9;
				break;
			case 9:
				((Control)Ho3()).set_Location(new Point(749, 428));
				((Control)Ho3()).set_Name(k1X.i1X(10, 642586770, 1));
				num = 0;
				break;
			case 0:
				((Control)Ho3()).set_Size(new Size(39, 13));
				((Control)Ho3()).set_TabIndex(0);
				num = 15;
				break;
			case 15:
				Ho3().set_Text(k1X.i1X(1, 642586779, 8));
				num = 3;
				break;
			case 3:
				s3F().set_AutoSize(true);
				goto case 11;
			case 11:
				((Control)s3F()).set_ForeColor(SystemColors.ButtonHighlight);
				num = 5;
				break;
			case 5:
				((Control)s3F()).set_Location(new Point(749, 9));
				((Control)s3F()).set_Name(k1X.i1X(8, 642587423, 1));
				num = 2;
				break;
			case 2:
				((Control)s3F()).set_Size(new Size(39, 13));
				((Control)s3F()).set_TabIndex(1);
				num = 16;
				break;
			case 16:
				s3F().set_Text(k1X.i1X(10, 642587418, 4));
				num = 10;
				break;
			case 10:
				((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
				((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
				num = 13;
				break;
			case 13:
				((Form)this).set_BackColor(SystemColors.Highlight);
				((Form)this).set_ClientSize(new Size(800, 450));
				num = 12;
				break;
			case 12:
				((Control)this).get_Controls().Add((Control)(object)s3F());
				goto case 8;
			case 8:
				((Control)this).get_Controls().Add((Control)(object)Ho3());
				num = 1;
				break;
			case 1:
				((Form)this).set_FormBorderStyle((FormBorderStyle)0);
				goto case 4;
			case 4:
				((Control)this).set_Name(k1X.i1X(8, 642588297, 7));
				num = 17;
				break;
			case 17:
				((Form)this).set_Text(k1X.i1X(8, 642588339, 1));
				((Form)this).set_WindowState((FormWindowState)2);
				num = 6;
				break;
			case 6:
				((Control)this).ResumeLayout(false);
				((Control)this).PerformLayout();
				return;
			}
		}
	}

	[SpecialName]
	internal virtual Label Ho3()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return s.m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void By1(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		s.m = ((P_0 is Label) ? P_0 : null);
	}

	[SpecialName]
	internal virtual Label s3F()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return s.a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kc2(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		s.a = ((P_0 is Label) ? P_0 : null);
	}
}
