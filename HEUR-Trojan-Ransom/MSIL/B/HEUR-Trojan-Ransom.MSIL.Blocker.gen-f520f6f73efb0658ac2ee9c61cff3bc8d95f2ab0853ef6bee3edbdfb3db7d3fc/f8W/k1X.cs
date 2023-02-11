using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Bb0;
using Gi0;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;
using Microsoft.VisualBasic.CompilerServices;
using g5P;

namespace f8W;

[DesignerGenerated]
public class k1X : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 3206)]
	private struct Sr5
	{
	}

	internal sealed class y8B
	{
		internal object Q;

		internal object F;

		internal object D;

		internal y8B()
		{
		}
	}

	private IContainer G;

	private Panel L;

	private Guna2DataGridView u;

	private Guna2GradientButton m;

	private Guna2GradientButton X;

	private Yr0.s9C D = new Yr0.s9C();

	private static readonly Array N;

	private static readonly Array q;

	private static readonly object i;

	internal static Sr5 o/* Not supported: data(E7 4C E1 4C E7 4C D2 61 28 48 C5 53 6C 5B A5 52 22 6B 83 40 85 40 82 40 B9 58 EB 6D 45 44 AA 5F 0B 57 F0 5E 92 F3 9A F3 90 F3 F8 ED 4E D4 B0 E3 F8 EB F9 DE 56 F7 B0 EC 28 E4 78 68 7E 68 7B 68 A9 7F 37 76 94 4F 18 78 16 70 30 45 9D FB 96 FB 99 FB 67 DC FA EB F1 E3 EB D6 4B FF B5 E4 37 EC 9E E5 78 DC F3 EB D3 E3 7E 20 6C 20 7B 20 4B 0D AA 24 5C 3F FE 37 0B 3E 93 07 15 30 03 38 3D 0D BC 24 4D 3F F6 37 19 3E C5 07 1D 30 1F 38 0F 0D 9A 24 76 8B 64 8B 70 8B FB 9C 39 95 90 AC 16 9B 10 93 1F A6 B0 8F 62 94 BF 9C 26 95 91 AC 15 9B 2A 93 52 A6 BB 8F 54 94 EF 9C 1A 95 8D AE 81 AE 8A AE 9F B0 6A 89 E0 BE F6 B6 FD 83 5B AA 88 B1 0A B9 C7 B0 63 89 E0 BE CE B6 DB 4B DD 4B D3 4B 77 5C AC 55 17 6C 95 5B 91 53 9B 66 3F F2 2B F2 36 F2 2D EC D8 D5 52 E2 44 EA 4F DF E9 F6 3A ED A2 E5 72 EC D3 D5 54 E2 54 EA 5A DF EE F6 3F ED E4 E5 7D EC D8 D5 48 E2 77 EA C1 EB C2 EB CB EB 87 FB 8A F3 84 C6 45 92 51 92 4E 92 78 8A 2F BF 89 96 76 8D D8 85 13 8C 8E B5 33 82 24 8A 24 BF 8F 96 66 8D CD 85 14 8C 8B B5 75 82 2B 8A 2F BF 93 96 45 8D A5 85 A1 85 A9 85 F5 A8 4F 81 A6 9A 09 92 68 47 69 47 65 47 00 59 27 0D 20 0D 29 0D 13 12 AB 1A 67 13 DC 2A 50 1D 47 15 60 20 B4 E2 BC E2 BB E2 D7 FA D5 CF 79 E6 92 FD 0D F5 E7 FC 52 C5 E2 F2 00 D7 09 D7 10 D7 D8 C0 4F C9 EC F0 60 C7 6E CF 48 FA D1 D3 26 C8 BF C0 E9 A4 ED A4 F8 A4 AF BA 0D 83 84 B4 AE BC 9A A6 93 A6 88 A6 F1 8B 5E A2 B2 B9 3F B1 D5 B8 76 81 F6 B6 F4 BE CE 8B CD 6F CE 6F DE 6F D9 70 69 78 AD 71 AB 6A A1 6A BF 6A 47 4D CE 7A C5 72 C2 47 41 6E C2 75 2D 7D EF 74 4D 4D C5 7A D9 53 DD 53 CC 53 B4 43 B1 4B B2 7E 16 57 89 28 80 28 9F 28 BD 37 0E 3F CB 36 53 0F AB 38 E8 30 E8 05 5A 2C 81 37 3C 82 35 82 2B 82 4B 92 5D 9A 5D AF D2 86 17 9D B0 95 71 9C D4 A5 6E 92 04 89 14 89 1C 89 88 9E 40 97 EC AE 6B 99 42 91 2E A4 C9 8D 2C 96 99 9E 53 97 F8 AE 44 99 7F 91 69 A4 DF 8D 06 96 96 7E 9C 7E 8F 7E FA 6E F6 66 E6 53 41 7A A4 61 3D 69 C1 60 76 59 EC 6E DC 66 F0 10 F4 10 EA 10 AB 08 BD 3D 0B 14 F2 0F F4 DA E6 DA EF DA D6 C5 7A CD B6 C4 10 FD BF CA D5 C2 9E F7 38 DE C7 C5 69 CD A2 C4 3F FD 82 CA 8E C2 9F F7 30 DE DC C5 51 CD 09 4B 05 4B 15 4B 8E 5C 45 55 F4 6C 7F 5B 73 53 4F 66 DE 4F 3B 54 8F 5C 4D 55 EF 6C 47 5B 57 43 51 43 4A 43 44 5C EB 54 3B 5D 99 64 1A 53 14 5B FE 4F EC 4F E0 4F 12 68 9B 5F 90 57 97 62 14 4B 97 50 21 58 B3 51 18 68 88 5F 85 57 8F 62 1F 4B 8B 50 76 58 B3 51 02 68 BB 5F 35 7D 39 7D 2A 7D 01 6D 54 65 5E 50 E2 79 06 62 A9 6A 54 63 8E 5A 56 6D 54 65 44 50 D1 79 7A FD 73 FD 5A FD 6E E2 C1 EA 1C E3 A0 DA 2D ED 55 E5 3A D0 9D F9 7C E2 3C 6D 2E 6D 1D 6D D0 4A 59 7D 52 75 55 40 D6 69 55 72 E0 7A 71 73 DA 4A 4A 7D 47 75 4D 40 DD 69 49 72 B4 7A 71 73 C0 4A 79 7D EA 5F E6 5F C8 5F DD 4F 8B 47 81 72 3D 5B D9 40 76 48 8B 41 51 78 89 4F 8B 47 9B 72 0E 5B BE B1 B8 B1 9D B1 7F 96 FF A1 E3 A9 FB 9C 58 B5 AA AE 9D E7 8F E7 B9 E7 FC CA 59 E3 BB F8 19 F0 F7 F9 3A C0 AC F7 FC FF F6 CA 4A E3 AE F8 01 F0 FC F9 26 C0 FE F7 FC FF EC CA 79 E3 99 24 95 24 BC 24 09 20 B0 3B 1F 33 CE 3A 64 03 EE 34 D4 3C AF 09 5B 20 B0 3B 05 33 FD 3A 74 10 64 10 52 10 22 00 29 08 3F 3D 87 14 76 0F CF 07 77 0E AE 37 3D 00 29 08 31 3D 9A 14 13 0F BD 07 77 0E DD 37 DE 18 CC 18 F9 18 18 1C FE 07 56 0F 90 06 1E 3F F2 08 E3 00 B4 35 12 1C ED 07 43 0F 88 06 15 3F EE 08 B0 00 B4 35 08 1C DE 07 4C 4A 40 4A 64 4A 39 55 CB 5D 00 54 B1 6D 3A 5A 36 52 0A 67 DD 4E 6A 55 CB 5D 1A 54 82 6D FF 80 F5 80 D6 80 33 A7 BE 90 BE 98 BA AD 18 84 F6 9F 53 97 88 9E 22 A7 BC 90 0E 37 1C 37 24 37 6F 1A CA 33 28 28 8A 20 64 29 A9 10 3D 27 6F 2F 65 1A D9 33 3D 28 92 20 6F 29 B5 10 6D 27 6F 2F 7F 1A EA 33 0D A1 01 A1 26 A1 9F A5 24 BE 8B B6 5A BF F0 86 7A B1 40 B9 3B 8C CF A5 24 BE 91 B6 69 BF 34 B1 3F B1 18 B1 8E A6 5C AF EF 96 77 A1 76 A9 10 9C C5 B5 36 AE 89 A6 59 AF F8 96 F6 D3 E4 D3 DB D3 91 C3 9E CB 93 FE 38 D7 F8 CC 31 C4 BB CD 10 F4 80 C3 8D CB 87 FE 17 D7 D4 CC 7C C4 A7 CD 0A F4 9B C3 BA CB 51 00 5D 00 7F 00 30 18 3A 2D 86 04 62 1F CD 17 30 1E BD 27 30 10 2C 18 20 2D 9D 04 55 1F 33 05 34 05 1C 05 E9 22 74 15 7F 1D 65 28 C5 01 3B 1A 99 12 7A C5 69 C5 4A C5 10 DD 19 E8 B8 C1 50 DA DA D2 77 DB 9D E2 17 D5 01 DD 0A E8 AC C1 7F DA E1 D2 3C DB 9B E2 1B D5 14 DD 1B E8 8D C1 FF 8C F2 8C CE 8C 9E 94 94 A1 28 88 CC 93 63 9B 9E 92 04 AB 98 9C 98 94 98 A1 3D 88 DD 93 42 9B 5D 2D 5A 2D 6F 2D 8D 0A 0B 3D 1E 35 0C 00 BD 29 5B 32 F2 3A D6 B9 C5 B9 E5 B9 BC A1 B5 94 14 BD FC A6 76 AE DB A7 31 9E BB A9 AD A1 A6 94 00 BD D3 A6 4B AE 9B A7 3A 9E B0 A9 AC A1 A6 94 26 BD DB E3 D6 E3 EF E3 BA FB B0 CE 0C E7 E8 FC 47 F4 BA FD 26 C4 B7 F3 B1 FB BB CE 0D E7 E8 FC 61 F4 59 A7 51 A7 6C A7 29 B9 84 80 15 B7 13 BF 19 8A AF A3 4A B8 E3 B0 35 E4 20 E4 03 E4 73 FA DB C3 56 F4 57 FC 78 C9 B8 E0 1C FB B3 F3 62 FA C8 C3 42 F4 78 FC 55 C9 E4 E0 13 FB B3 F3 54 FA D4 C3 44 F4 5B FC 75 C9 0C F9 03 F9 3B F9 25 E6 8A EE 5B E7 F1 DE 7B E9 41 E1 6C D4 DD FD 2A E6 8A EE 6D E7 ED DE 7D E9 62 E1 4C D4 FB 17 F2 17 C3 17 BD 07 A6 0F BE 3A 17 13 FE 08 5A 00 8B 09 33 30 BD 07 56 71 5F 71 6F 71 7D 6E DE 66 1B 6F BE 56 04 61 37 69 3B 5C 94 75 5C 6E 72 DF 78 DF 48 DF 95 F8 1F CF 1E C7 3F F2 FF DB 46 C0 F2 C8 39 C1 8F F8 54 CF 07 7D 06 7D 3C 7D C0 79 8E 0F 88 0F B2 0F BB 22 41 0B AC 10 09 18 CC 11 57 28 80 B0 83 B0 BD B0 8A AF 3C A7 ED AE 85 63 8D 63 BB 63 F9 7B F5 4E 48 67 A7 7C 08 74 D3 7D 78 44 D4 73 84 08 95 08 BB 08 08 1F C0 16 6C 2F EB 18 C2 10 AE 25 16 0C BB 17 02 1F E5 16 68 2F F4 18 FE 10 F4 25 44 0C AA 17 3D 1F 41 A2 4A A2 01 A2 F9 85 3B B2 21 BA 07 8F 87 A6 74 BD DD B5 16 BC AB 85 2A B2 1E BA 8D 6E 8B 6E CC 6E 9C 70 68 49 EA 7E EC 76 E8 43 7E 6A CA 94 CC 94 88 94 11 83 85 8A 26 B3 AA 84 A4 8C 82 B9 69 18 6F 18 2A 18 1D 07 EC 0F 2F 06 82 3F 0A 08 2A 00 7C E7 6D E7 38 E7 1B F7 14 FF 19 CA B2 E3 72 F8 BB F0 6D F9 8D C0 11 F7 31 FF 1D CA AD E3 4E F8 E1 F0 3C F9 9C C0 2E F7 67 5B 6C 5B 22 5B 51 76 BC 5F 4F 44 CC 4C 21 45 9C 7C 10 4B 1C 43 00 76 AD 5F 70 44 15 FB 13 FB 53 FB 29 E3 7D D6 D3 FF 3C E4 9D EC 66 E5 67 B2 61 B2 20 B2 51 A2 04 AA 06 9F A6 B6 41 AD C2 A5 76 94 70 94 3E 94 CA B3 18 84 1C 8C 10 B9 B4 90 7D 8B BD 8D B5 8D F4 8D 89 92 26 9A FB 93 5C AA DC 9D D3 95 DC A0 4A 89 81 25 90 25 CB 25 E6 35 E9 3D E4 08 4F 21 8F 3A 46 32 91 3B 70 02 EC 35 CC 3D E0 08 50 21 B3 3A 1C 32 C1 3B 61 02 D3 35 AA E9 A1 E9 E1 E9 9D C4 71 ED 82 F6 01 FE EC F7 51 CE DD F9 D1 F1 CD C4 60 ED BD F6 CB 1C CD 1C 87 1C F0 04 A3 31 0D 18 E2 03 43 0B B8 02 7B 87 7D 87 36 87 4F 97 18 9F 1A AA BA 83 5D 98 DE 90 07 D1 01 D1 49 D1 B9 F6 69 C1 6D C9 61 FC C5 D5 0C CE 0D B5 05 B5 42 B5 39 AA 90 A2 4D AB E1 92 65 A5 60 AD 7C 98 FD B1 46 7E 57 7E 16 7E 21 6E 2E 66 23 53 88 7A 48 61 81 69 51 60 B7 59 2B 6E 0B 66 27 53 97 7A 74 61 DB 69 06 60 A6 59 14 6E BE 0B B5 0B EF 0B 8E 26 65 0F 96 14 15 1C F8 15 45 2C C9 1B C5 13 D9 26 74 0F A9 14 7B 15 72 15 29 15 3C 0B 80 32 18 05 1B 0D 1D 38 B0 11 4F 0A F3 02 1C 0B 09 BE 0F BE 5A BE D9 A9 46 A0 E5 99 69 AE 67 A6 41 93 FB 15 EF 15 AF 15 AA 0B 1D 32 8D 05 95 0D 8D 38 2C 11 CF 0A 7C 02 B1 0B 1F 32 9D 05 B5 0D DF 38 3D 11 D1 0A 7D 02 BB 0B 1E 32 9C 05 A3 0D 27 96 20 96 72 96 50 89 FF 81 68 88 CB B1 47 86 49 8E 6F BB 59 99 5F 99 0F 99 C0 9D 3E 86 D5 8E 0E 87 B1 BE 1F 89 22 56 2B 56 75 56 C7 71 45 46 4F 4E 47 7B CD 52 00 49 BF 41 60 48 EF 71 05 89 01 89 5D 89 62 99 7E 91 60 A4 E2 8D DC 66 DD 66 85 66 F9 79 C4 99 CC 99 9E 99 A6 81 B2 B4 08 9D E5 86 45 8E 94 87 2C BE 82 89 48 76 53 76 13 76 9A 72 6A 69 D0 61 2A 68 8D 51 06 66 0B 6E 00 5B A7 72 43 69 ED 61 2A 68 8D 51 02 66 00 6E 09 5B AE 72 4A 69 E4 61 2E 68 84 51 0F 66 02 6E 09 5B BF 72 5C 69 E4 61 25 45 39 45 79 45 15 5A A8 52 71 5B CD 62 66 55 66 5D 6D 68 CA 41 2E 5A 80 52 4A 5B E0 62 66 55 66 5D 69 68 C1 41 27 5A 89 52 43 5B E9 62 62 55 6F 5D 64 68 C3 41 27 5A 98 52 55 5B E9 62 6C 93 76 93 31 93 96 B4 1D 83 22 8B 24 BE 83 97 67 8C C9 84 03 8D A9 B4 22 83 22 8B 24 BE 87 97 6C 8C C0 84 0A 8D A0 B4 2B 83 26 8B 2D BE 8A 97 6E 8C C0 84 1B 8D B6 B4 2B 83 50 09 5B 09 0E 09 22 11 66 24 88 0D 39 16 C4 1E 42 17 A2 2E 7C 19 22 11 64 24 88 0D CA 99 C4 99 95 99 A1 E9 AC E1 A7 D4 04 9D E8 86 57 8E 80 E7 2A DE A1 E9 B6 81 B7 B4 3A 9D E4 E6 4A EE 7B 1D 6D 1D 1B 1D 9B 5A 10 6D 1D 65 16 50 B6 19 53 02 FB 0A 2C 03 9B 5A 10 6D 1D 65 1C 30 BD 19 50 02 FB 6A 31 63 9B 5A 1F 0D 11 05 2D 30 B1 79 55 62 8A 2E 99 2E EB 2E EC 56 E7 63 50 2A A1 31 0A 59 C0 50 6A 69 EA 3E E8 36 EB 03 40 4A A4 51 0A 59 DA 30 70 09 C9 3E EC 56 E7 63 40 4A CA FE CB FE A8 FE 4A 89 A8 42 A6 42 CB 42 8B 5D 20 55 E4 5C 6D 65 C3 32 CE 3A C5 0F 62 26 86 3D 28 35 E2 3C 48 05 C3 32 CE 3A 2D 3F 2D 3F 49 3F E7 E7 FB E7 82 E7 9E CA 73 E3 DB F8 73 F0 F2 F9 15 C0 CB F7 95 FF D6 CA 3F E3 DD F8 3A F0 BF F9 13 C0 D6 F7 93 FF CC CA 6B E3 9A F8 73 F0 F6 F9 15 C0 98 F7 D9 FF 98 CA 39 E3 90 F8 75 F0 B5 1D B4 1D D3 1D FE 03 13 6A 11 6A 74 6A 68 72 63 47 E8 91 EA 91 80 91 DC 8E 71 86 F5 7A F7 7A 9C 7A 0B 5D 80 6A 61 25 65 25 0B 25 0C 35 09 3D 4B 08 B5 21 1E 56 1A 56 75 56 74 4E 76 7B DA 52 36 49 D8 81 DA 81 B4 81 F0 9E 52 96 89 FA 88 FA E4 FA E6 EA 42 DC 5E DC 2C DC 28 C4 32 F1 80 D8 60 C3 D9 CB 22 C2 A6 FB 32 CC 22 C4 00 F1 84 D8 73 C3 C2 CB 12 C2 B9 FB 35 CC 2E C4 23 F1 B3 D8 5A C3 D8 CB 0C C2 B9 FB 2F CC 0B C4 28 F1 88 D8 52 C3 7E 90 64 90 11 90 57 8F F8 87 34 8E 83 B7 0C 80 14 88 19 BD A5 94 7C 8F E5 87 38 8E 99 B7 12 80 38 88 1F BD B8 94 6A 8F C8 87 2E 8E 9A B7 0E 80 1E 88 3C BD B3 94 50 8F C0 87 4E A0 0D A0 3E A0 0A BE A9 87 25 B0 29 B8 3E 8D 82 A4 47 BF 87 B7 02 BE B3 87 6C B0 35 B8 2F 8D 9E A4 29 BF C2 B7 0F BE E7 87 35 B0 2D B8 24 8D 82 A4 29 BF C9 B7 0C BE A4 87 6C B0 38 B8 3E 8D 9F A4 6C BF D7 B7 02 BE B5 87 1C B0 66 2A 67 2A 17 2A 10 07 C0 FE C7 FE B2 FE B6 EE A1 E6 A1 D3 07 FA F2 E1 5D E9 B0 E0 D1 03 C4 03 A2 03 A0 13 BB 1B B6 2E 00 07 E3 1C 57 14 81 1D 3D 24 81 13 F0 1B A1 2E 11 07 F3 1C 52 14 9D 1D 2A 24 83 13 81 1B 86 2E 3F 07 D5 1C) */;

	public k1X()
	{
		//Discarded unreachable code: IL_0018
		d7W();
	}

	protected override void Me9(bool P_0)
	{
		//Discarded unreachable code: IL_0063
		try
		{
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num = ((!P_0) ? 3 : 2);
					continue;
				case 2:
					num2 = ((G != null) ? 1 : 0);
					goto IL_003e;
				case 3:
					num2 = 0;
					goto IL_003e;
				case 1:
					num = ((!flag) ? 4 : 6);
					continue;
				case 6:
					G.Dispose();
					break;
				case 7:
					break;
				case 4:
					return;
					IL_003e:
					flag = (byte)num2 != 0;
					goto case 1;
				}
				num = 4;
			}
		}
		finally
		{
			((Form)this).Dispose(P_0);
		}
	}

	private void d7W()
	{
		//Discarded unreachable code: IL_1006
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Expected O, but got Unknown
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected O, but got Unknown
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Expected O, but got Unknown
		//IL_0bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c09: Expected O, but got Unknown
		//IL_0ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df7: Expected O, but got Unknown
		byte[] array = e6X.m;
		byte[] g = Jk9.G;
		int num = 22;
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
				obj = (object)new DataGridViewCellStyle();
				Ki6(new Panel());
				num = 19;
				break;
			case 19:
				a2A(new Label());
				n1E(new Guna2DataGridView());
				Sr6(new Guna2GradientButton());
				num = 64;
				break;
			case 64:
				Ls5(new Guna2GradientButton());
				s4D(new Guna2GradientButton());
				((Control)s5T()).SuspendLayout();
				num = 2;
				break;
			case 2:
				((ISupportInitialize)t6L()).BeginInit();
				((Control)this).SuspendLayout();
				((Control)s5T()).set_BackColor(Color.DarkSlateGray);
				num = 68;
				break;
			case 68:
				((Control)s5T()).get_Controls().Add((Control)(object)Hp4());
				((Control)s5T()).get_Controls().Add((Control)(object)j6L());
				num = 47;
				break;
			case 47:
				((Control)s5T()).get_Controls().Add((Control)(object)w3B());
				((Control)s5T()).get_Controls().Add((Control)(object)y9A());
				num = 36;
				break;
			case 36:
				((Control)s5T()).set_Dock((DockStyle)1);
				((Control)s5T()).set_Location(new Point(0, 0));
				num = 67;
				break;
			case 67:
				((Control)s5T()).set_Name(i1X(11, 642586777, 3));
				num = 45;
				break;
			case 45:
				((Control)s5T()).set_Size(new Size(1127, 131));
				((Control)s5T()).set_TabIndex(5);
				num = 31;
				break;
			case 31:
				y9A().set_AutoSize(true);
				((Control)y9A()).set_Font(new Font(i1X(14, 642586759, 6), 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 82;
				break;
			case 82:
				((Control)y9A()).set_ForeColor(Color.GhostWhite);
				((Control)y9A()).set_Location(new Point(24, 28));
				num = 81;
				break;
			case 81:
				((Control)y9A()).set_Name(i1X(11, 642586767, 1));
				num = 4;
				break;
			case 4:
				((Control)y9A()).set_Size(new Size(160, 37));
				((Control)y9A()).set_TabIndex(4);
				num = 78;
				break;
			case 78:
				y9A().set_Text(i1X(5, 642586801, 4));
				num = 26;
				break;
			case 26:
				((DataGridViewCellStyle)cloneable2).set_BackColor(Color.White);
				((DataGridView)t6L()).set_AlternatingRowsDefaultCellStyle((DataGridViewCellStyle)cloneable2);
				num = 44;
				break;
			case 44:
				((DataGridView)t6L()).set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
				((DataGridView)t6L()).set_BackgroundColor(Color.DimGray);
				num = 32;
				break;
			case 32:
				((DataGridView)t6L()).set_BorderStyle((BorderStyle)0);
				((DataGridView)t6L()).set_CellBorderStyle((DataGridViewCellBorderStyle)8);
				num = 35;
				break;
			case 35:
				((DataGridView)t6L()).set_ColumnHeadersBorderStyle((DataGridViewHeaderBorderStyle)4);
				((DataGridViewCellStyle)((cloneable is DataGridViewCellStyle) ? cloneable : null)).set_Alignment((DataGridViewContentAlignment)16);
				num = 27;
				break;
			case 27:
				((DataGridViewCellStyle)((cloneable is DataGridViewCellStyle) ? cloneable : null)).set_BackColor(Color.FromArgb(100, 88, 255));
				((DataGridViewCellStyle)((cloneable is DataGridViewCellStyle) ? cloneable : null)).set_Font(new Font(i1X(8, 642586755, 2), 10.5f));
				num = 12;
				break;
			case 12:
				((DataGridViewCellStyle)((cloneable is DataGridViewCellStyle) ? cloneable : null)).set_ForeColor(Color.White);
				((DataGridViewCellStyle)cloneable).set_SelectionBackColor(SystemColors.Highlight);
				num = 42;
				break;
			case 42:
				((DataGridViewCellStyle)((cloneable is DataGridViewCellStyle) ? cloneable : null)).set_SelectionForeColor(SystemColors.HighlightText);
				((DataGridViewCellStyle)((cloneable is DataGridViewCellStyle) ? cloneable : null)).set_WrapMode((DataGridViewTriState)1);
				num = 13;
				break;
			case 13:
				((DataGridView)t6L()).set_ColumnHeadersDefaultCellStyle((DataGridViewCellStyle)((cloneable is DataGridViewCellStyle) ? cloneable : null));
				((DataGridView)t6L()).set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
				num = 10;
				break;
			case 10:
				((DataGridViewCellStyle)obj).set_Alignment((DataGridViewContentAlignment)16);
				((DataGridViewCellStyle)((obj is DataGridViewCellStyle) ? obj : null)).set_BackColor(Color.White);
				num = 7;
				break;
			case 7:
				((DataGridViewCellStyle)((obj is DataGridViewCellStyle) ? obj : null)).set_Font(new Font(i1X(1, 642586758, 7), 10.5f));
				num = 15;
				break;
			case 15:
				((DataGridViewCellStyle)obj).set_ForeColor(Color.FromArgb(71, 69, 94));
				((DataGridViewCellStyle)((obj is DataGridViewCellStyle) ? obj : null)).set_SelectionBackColor(Color.FromArgb(231, 229, 255));
				num = 66;
				break;
			case 66:
				((DataGridViewCellStyle)obj).set_SelectionForeColor(Color.FromArgb(71, 69, 94));
				((DataGridViewCellStyle)obj).set_WrapMode((DataGridViewTriState)2);
				num = 62;
				break;
			case 62:
				((DataGridView)t6L()).set_DefaultCellStyle((DataGridViewCellStyle)((obj is DataGridViewCellStyle) ? obj : null));
				((Control)t6L()).set_Dock((DockStyle)5);
				num = 55;
				break;
			case 55:
				((DataGridView)t6L()).set_EnableHeadersVisualStyles(false);
				((DataGridView)t6L()).set_GridColor(Color.FromArgb(231, 229, 255));
				num = 58;
				break;
			case 58:
				((Control)t6L()).set_Location(new Point(0, 131));
				((Control)t6L()).set_Name(i1X(0, 642586784, 7));
				num = 74;
				break;
			case 74:
				((DataGridView)t6L()).set_RowHeadersVisible(false);
				((DataGridView)t6L()).set_SelectionMode((DataGridViewSelectionMode)1);
				num = 54;
				break;
			case 54:
				((Control)t6L()).set_Size(new Size(1127, 329));
				((Control)t6L()).set_TabIndex(5);
				num = 8;
				break;
			case 8:
				t6L().set_Theme((DataGridViewPresetThemes)0);
				t6L().get_ThemeStyle().get_AlternatingRowsStyle().set_BackColor(Color.White);
				num = 49;
				break;
			case 49:
				t6L().get_ThemeStyle().get_AlternatingRowsStyle().set_Font((Font)null);
				t6L().get_ThemeStyle().get_AlternatingRowsStyle().set_ForeColor(Color.Empty);
				num = 50;
				break;
			case 50:
				t6L().get_ThemeStyle().get_AlternatingRowsStyle().set_SelectionBackColor(Color.Empty);
				t6L().get_ThemeStyle().get_AlternatingRowsStyle().set_SelectionForeColor(Color.Empty);
				num = 37;
				break;
			case 37:
				t6L().get_ThemeStyle().set_BackColor(Color.DimGray);
				t6L().get_ThemeStyle().set_GridColor(Color.FromArgb(231, 229, 255));
				num = 33;
				break;
			case 33:
				t6L().get_ThemeStyle().get_HeaderStyle().set_BackColor(Color.FromArgb(100, 88, 255));
				num = 43;
				break;
			case 43:
				t6L().get_ThemeStyle().get_HeaderStyle().set_BorderStyle((DataGridViewHeaderBorderStyle)4);
				t6L().get_ThemeStyle().get_HeaderStyle().set_Font(new Font(i1X(4, 642586757, 4), 10.5f));
				num = 5;
				break;
			case 5:
				t6L().get_ThemeStyle().get_HeaderStyle().set_ForeColor(Color.White);
				t6L().get_ThemeStyle().get_HeaderStyle().set_HeaightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
				num = 11;
				break;
			case 11:
				t6L().get_ThemeStyle().get_HeaderStyle().set_Height(4);
				t6L().get_ThemeStyle().set_ReadOnly(false);
				num = 61;
				break;
			case 61:
				t6L().get_ThemeStyle().get_RowsStyle().set_BackColor(Color.White);
				t6L().get_ThemeStyle().get_RowsStyle().set_BorderStyle((DataGridViewCellBorderStyle)8);
				num = 73;
				break;
			case 73:
				t6L().get_ThemeStyle().get_RowsStyle().set_Font(new Font(i1X(2, 642586753, 0), 10.5f));
				num = 59;
				break;
			case 59:
				t6L().get_ThemeStyle().get_RowsStyle().set_ForeColor(Color.FromArgb(71, 69, 94));
				num = 53;
				break;
			case 34:
			case 53:
				t6L().get_ThemeStyle().get_RowsStyle().set_Height(22);
				t6L().get_ThemeStyle().get_RowsStyle().set_SelectionBackColor(Color.FromArgb(231, 229, 255));
				num = 21;
				break;
			case 21:
				t6L().get_ThemeStyle().get_RowsStyle().set_SelectionForeColor(Color.FromArgb(71, 69, 94));
				num = 3;
				break;
			case 3:
				w3B().set_AutoRoundedCorners(true);
				w3B().set_BorderRadius(17);
				num = 25;
				break;
			case 25:
				((ButtonState)w3B().get_CheckedState()).set_Parent((CustomButtonBase)(object)w3B());
				((Control)w3B()).set_Cursor(Cursors.get_Hand());
				num = 70;
				break;
			case 70:
				w3B().get_CustomImages().set_Parent((CustomButtonBase)(object)w3B());
				w3B().set_FillColor(Color.SlateBlue);
				num = 76;
				break;
			case 76:
				w3B().set_FillColor2(Color.SlateBlue);
				((Control)w3B()).set_Font(new Font(i1X(2, 642586846, 4), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 17;
				break;
			case 17:
				((Control)w3B()).set_ForeColor(Color.White);
				((ButtonState)w3B().get_HoverState()).set_FillColor(Color.Orchid);
				num = 65;
				break;
			case 65:
				w3B().get_HoverState().set_FillColor2(Color.Orchid);
				goto case 72;
			case 72:
				((ButtonState)w3B().get_HoverState()).set_Parent((CustomButtonBase)(object)w3B());
				num = 23;
				break;
			case 23:
				((Control)w3B()).set_Location(new Point(929, 79));
				((Control)w3B()).set_Name(i1X(14, 642586824, 5));
				num = 6;
				break;
			case 6:
				w3B().set_PressedColor(Color.Turquoise);
				w3B().set_PressedDepth(100);
				num = 77;
				break;
			case 77:
				w3B().get_ShadowDecoration().set_Parent((Control)(object)w3B());
				goto case 60;
			case 60:
				((Control)w3B()).set_Size(new Size(157, 37));
				num = 83;
				break;
			case 83:
				((Control)w3B()).set_TabIndex(6);
				((CustomButtonBase)w3B()).set_Text(i1X(13, 642586877, 3));
				num = (int)array[342] / 6;
				break;
			case 30:
				j6L().set_AutoRoundedCorners(true);
				j6L().set_BorderRadius(17);
				num = 57;
				break;
			case 57:
				((ButtonState)j6L().get_CheckedState()).set_Parent((CustomButtonBase)(object)j6L());
				((Control)j6L()).set_Cursor(Cursors.get_Hand());
				num = 9;
				break;
			case 9:
				j6L().get_CustomImages().set_Parent((CustomButtonBase)(object)j6L());
				j6L().set_FillColor(Color.SlateBlue);
				num = 16;
				break;
			case 16:
				j6L().set_FillColor2(Color.SlateBlue);
				((Control)j6L()).set_Font(new Font(i1X(14, 642586841, 3), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 38;
				break;
			case 38:
				((Control)j6L()).set_ForeColor(Color.White);
				((ButtonState)j6L().get_HoverState()).set_FillColor(Color.Orchid);
				num = 29;
				break;
			case 29:
				j6L().get_HoverState().set_FillColor2(Color.Orchid);
				((ButtonState)j6L().get_HoverState()).set_Parent((CustomButtonBase)(object)j6L());
				num = 80;
				break;
			case 80:
				((Control)j6L()).set_Location(new Point(579, 79));
				((Control)j6L()).set_Name(i1X(9, 642586850, 7));
				num = 18;
				break;
			case 18:
				j6L().set_PressedColor(Color.Turquoise);
				j6L().set_PressedDepth(100);
				num = 79;
				break;
			case 79:
				j6L().get_ShadowDecoration().set_Parent((Control)(object)j6L());
				((Control)j6L()).set_Size(new Size(157, 37));
				num = 1;
				break;
			case 1:
				((Control)j6L()).set_TabIndex(7);
				((CustomButtonBase)j6L()).set_Text(i1X(8, 642586652, 2));
				num = 24;
				break;
			case 24:
				Hp4().set_AutoRoundedCorners(true);
				Hp4().set_BorderRadius(17);
				num = 52;
				break;
			case 52:
				((ButtonState)Hp4().get_CheckedState()).set_Parent((CustomButtonBase)(object)Hp4());
				((Control)Hp4()).set_Cursor(Cursors.get_Hand());
				num = 69;
				break;
			case 69:
				Hp4().get_CustomImages().set_Parent((CustomButtonBase)(object)Hp4());
				Hp4().set_FillColor(Color.SlateBlue);
				num = g[169] - g[313];
				break;
			case 41:
				Hp4().set_FillColor2(Color.SlateBlue);
				((Control)Hp4()).set_Font(new Font(i1X(12, 642586844, 6), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 51;
				break;
			case 51:
				((Control)Hp4()).set_ForeColor(Color.White);
				((ButtonState)Hp4().get_HoverState()).set_FillColor(Color.Orchid);
				num = 0;
				break;
			case 0:
				Hp4().get_HoverState().set_FillColor2(Color.Orchid);
				((ButtonState)Hp4().get_HoverState()).set_Parent((CustomButtonBase)(object)Hp4());
				num = 14;
				break;
			case 14:
				((Control)Hp4()).set_Location(new Point(752, 79));
				((Control)Hp4()).set_Name(i1X(11, 642586626, 2));
				num = 63;
				break;
			case 63:
				Hp4().set_PressedColor(Color.Turquoise);
				Hp4().set_PressedDepth(100);
				num = 39;
				break;
			case 39:
				Hp4().get_ShadowDecoration().set_Parent((Control)(object)Hp4());
				((Control)Hp4()).set_Size(new Size(157, 37));
				num = 56;
				break;
			case 56:
				((Control)Hp4()).set_TabIndex(8);
				((CustomButtonBase)Hp4()).set_Text(i1X(3, 642586673, 8));
				num = 28;
				break;
			case 28:
				((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
				((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
				num = 75;
				break;
			case 75:
				((Form)this).set_ClientSize(new Size(1127, 460));
				((Control)this).get_Controls().Add((Control)(object)t6L());
				num = 71;
				break;
			case 71:
				((Control)this).get_Controls().Add((Control)(object)s5T());
				((Form)this).set_FormBorderStyle((FormBorderStyle)0);
				num = 48;
				break;
			case 48:
				((Control)this).set_Name(i1X(4, 642586657, 3));
				((Form)this).set_Text(i1X(7, 642586659, 5));
				num = 46;
				break;
			case 46:
				((Form)this).set_WindowState((FormWindowState)2);
				((Control)s5T()).ResumeLayout(false);
				num = 20;
				break;
			case 20:
				((Control)s5T()).PerformLayout();
				((ISupportInitialize)t6L()).EndInit();
				((Control)this).ResumeLayout(false);
				num = 40;
				break;
			case 40:
				return;
			}
		}
	}

	[SpecialName]
	internal virtual Panel s5T()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		Panel l = L;
		Jk9.G[198] = (byte)(Jk9.G[198] & Jk9.G[125] & 0xE);
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ki6(Panel P_0)
	{
		//Discarded unreachable code: IL_0008
		L = P_0;
	}

	[SpecialName]
	internal virtual Label y9A()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		Label x = D.x;
		e6X.m[287] = (byte)((e6X.m[287] - e6X.m[150]) & 0xCC);
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2A(Label P_0)
	{
		//Discarded unreachable code: IL_0014
		D.x = ((P_0 is Label) ? P_0 : null);
	}

	[SpecialName]
	internal virtual Guna2DataGridView t6L()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		Guna2DataGridView result = u;
		Jk9.G[393] = (byte)((Jk9.G[393] + Jk9.G[474]) & 0x16);
		return result;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n1E(Guna2DataGridView P_0)
	{
		//Discarded unreachable code: IL_0008
		u = P_0;
	}

	[SpecialName]
	internal virtual Guna2GradientButton Hp4()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4D(Guna2GradientButton P_0)
	{
		//Discarded unreachable code: IL_0008
		m = P_0;
	}

	[SpecialName]
	internal virtual Guna2GradientButton j6L()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		Guna2GradientButton x = X;
		e6X.m[66] = (byte)((e6X.m[66] - e6X.m[95]) & 0xD5);
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ls5(Guna2GradientButton P_0)
	{
		//Discarded unreachable code: IL_0008
		X = P_0;
	}

	[SpecialName]
	internal virtual Guna2GradientButton w3B()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return D.w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sr6(Guna2GradientButton P_0)
	{
		//Discarded unreachable code: IL_0014
		D.w = ((P_0 is Guna2GradientButton) ? P_0 : null);
	}

	internal static string i1X(int P_0, int P_1, int P_2)
	{
		object obj3 = default(object);
		int num6 = default(int);
		Array array = default(Array);
		Array array2 = default(Array);
		object obj4 = default(object);
		char c = default(char);
		int num7 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = P_1 ^ 0x264D1893 ^ P_2;
			object obj = q;
			char[] obj2 = (char[])obj;
			int num2 = obj2[num];
			num2 = obj2[num + 2] ^ num2;
			while (true)
			{
				IL_007d:
				int num3 = 0;
				while (true)
				{
					switch (num3)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num3 = 3;
						continue;
					case 3:
					case 17:
						break;
					case 4:
						goto IL_007d;
					case 0:
						num3 = (((obj3 = ((string[])i)[num2]) == null) ? 5 : 11);
						continue;
					case 11:
						return (string)obj3;
					case 5:
					{
						char[] obj5 = (char[])obj;
						char[] obj6 = (char[])N;
						num6 = num;
						array = obj6;
						array2 = obj5;
						num3 = 1;
						continue;
					}
					case 1:
						obj4 = new StringBuilder();
						c = (array2 as char[])[num6];
						num7 = (array2 as char[])[num6 + 1] ^ c;
						goto case 13;
					case 13:
						num3 = 15;
						continue;
					case 15:
						num6 += 3;
						num5 = (num7 & 0x1F) | ((num7 & 0xFFC0) >> 1);
						num3 = 2;
						continue;
					case 2:
					{
						int num9 = num7;
						Jk9.G[159] = (byte)((Jk9.G[159] ^ P_2) & 0xDB);
						num3 = (((num9 & 0x20) == 0) ? 14 : 8);
						continue;
					}
					case 8:
						num5 = (num5 << 15) | ((array2 as char[])[num6++] ^ c);
						num3 = 14;
						continue;
					case 14:
						num8 = (array as char[]).Length;
						num4 = 1;
						num3 = 10;
						continue;
					case 7:
						((StringBuilder)obj4).Append((char)(c ^ (array2 as char[])[num6 + num5 - num4] ^ (array as char[])[(num4 + num6 + 17) % num8]));
						num3 = 9;
						continue;
					case 9:
						num4++;
						num3 = 10;
						continue;
					case 10:
						num3 = ((num4 <= num5) ? 7 : 6);
						continue;
					case 6:
						obj3 = (obj4 as StringBuilder).ToString();
						((string[])i)[num2] = (string)obj3;
						num3 = 12;
						continue;
					case 12:
						return (string)obj3;
					}
					break;
				}
				break;
			}
		}
	}

	static k1X()
	{
		//Discarded unreachable code: IL_00df
		int num = 1;
		Array array = default(Array);
		while (true)
		{
			switch (num)
			{
			case 6:
				((char[])array)[7] = '៩';
				((char[])array)[5] = '➉';
				num = 4;
				continue;
			case 4:
				(array as char[])[2] = 'ⴄ';
				((char[])array)[1] = 'ң';
				num = 3;
				continue;
			case 3:
				(array as char[])[0] = '\u1f47';
				goto case 7;
			case 7:
				(array as char[])[3] = '\u180f';
				num = 5;
				continue;
			case 0:
			case 2:
			case 5:
				((char[])array)[6] = 'ḣ';
				i = new string[116];
				N = array as char[];
				return;
			}
			q = new char[1603]
			{
				'䳧', '䳡', '䳧', '懒', '䠨', '叅', '孬', '劥', '欢', '䂃',
				'䂅', '䂂', '墹', '淫', '䑅', '循', '國', '廰', '\uf392', '\uf39a',
				'\uf390', '\uedf8', '푎', '\ue3b0', '\uebf8', '\udef9', '\uf756', '\uecb0', '\ue428', '桸',
				'桾', '桻', '義', '瘷', '侔', '砘', '瀖', '䔰', 'ﮝ', 'ﮖ',
				'ﮙ', '\udc67', '\uebfa', '\ue3f1', '훫', 'ｋ', '\ue4b5', '\uec37', '\ue59e', '\udc78',
				'\uebf3', '\ue3d3', '⁾', '\u206c', '⁻', '\u0d4b', '⒪', '㽜', '㟾', '㸋',
				'ޓ', '〕', '㠃', 'ഽ', 'Ⓖ', '㽍', '㟶', '㸙', '߅', '〝',
				'㠟', 'ഏ', '⒚', '譶', '譤', '議', '鳻', '锹', '겐', '鬖',
				'錐', 'ꘟ', '辰', '鑢', '鲿', '锦', '겑', '鬕', '錪', 'Ꙓ',
				'辻', '鑔', '鳯', '锚', '꺍', '꺁', '꺊', '낟', '襪', '뻠',
				'뛶', '菽', '\uaa5b', '놈', '뤊', '냇', '襣', '뻠', '뛎', '䯛',
				'䯝', '䯓', '屷', '喬', '気', '宕', '厑', '暛', '\uf23f', '\uf22b',
				'\uf236', '\uec2d', '험', '\ue252', '\uea44', '\udf4f', '\uf6e9', '\ued3a', '\ue5a2', '\uec72',
				'헓', '\ue254', '\uea54', '\udf5a', '\uf6ee', '\ued3f', '\ue5e4', '\uec7d', '험', '\ue248',
				'\uea77', '\uebc1', '\uebc2', '\uebcb', 'ﮇ', '\uf38a', '욄', '鉅', '鉑', '鉎',
				'詸', '뼯', '隉', '赶', '藘', '谓', '떎', '舳', '訤', '뼤',
				'随', '赦', '藍', '谔', '떋', '艵', '訫', '뼯', '隓', '赅',
				'薥', '薡', '薩', 'ꣵ', '腏', '骦', '鈉', '䝨', '䝩', '䝥',
				'夀', 'ധ', 'ഠ', 'ഩ', 'ሓ', '᪫', '፧', '⫝̸', 'ᵐ', 'ᕇ',
				'\u2060', '\ue2b4', '\ue2bc', '\ue2bb', '𧻓', '쿕', '\ue679', 'ﶒ', '\uf50d', 'ﳧ',
				'앒', '\uf2e2', '휀', '휉', '휐', '샘', '쥏', '\uf0ec', '읠', '콮',
				'煮', '폑', '젦', '삿', 'ꓩ', 'ꓭ', 'ꓸ', '몯', '茍', '뒄',
				'벮', 'Ꚛ', 'ꚓ', 'Ꚉ', '诱', 'ꉞ', '릲', '넿', '룕', '腶',
				'뛶', '뻴', '诎', '濍', '濎', '濞', '烙', '硩', '熭', '檫',
				'檡', '檿', '䵇', '竎', '狅', '䟂', '湁', '痂', '紭', '瓯',
				'䵍', '竅', '叙', '叝', '双', '䎴', '䮱', '纲', '圖', '⢉',
				'⢀', '⢟', '㞽', '㼎', '㛋', 'ན', '㢫', 'ヨ', 'ר', 'ⱚ',
				'㞁', '舼', '舵', '舫', '鉋', '驝', '꽝', '蛒', '鴗', '閰',
				'鱱', 'ꗔ', '鉮', '褄', '褔', '褜', '麈', '靀', '껬', '饫',
				'酂', 'ꐮ', '跉', '阬', '麙', '靓', '껸', '饄', '酿', 'ꑩ',
				'跟', '阆', '纖', '纜', '纏', '滺', '曶', '另', '穁', '憤',
				'椽', '惁', '奶', '滬', '曜', 'ჰ', 'ჴ', 'ც', 'ࢫ', '㶽',
				'ᐋ', '\u0ff2', '\udaf4', '\udae6', '\udaef', '엖', '쵺', '쒶', 'ﴐ', '쪿',
				'싕', '\uf79e', '\ude38', '엇', '쵩', '쒢', '﴿', '쪂', '슎', '\uf79f',
				'\ude30', '엜', '쵑', '䬉', '䬅', '䬕', '岎', '啅', '泴', '孿',
				'即', '晏', '俞', '吻', '岏', '啍', '泯', '孇', '䍗', '䍑',
				'䍊', '屄', '哫', '崻', '撙', '匚', '嬔', '俾', '俬', '俠',
				'栒', '徛', '垐', '抗', '䬔', '傗', '堡', '决', '栘', '很',
				'垅', '抏', '䬟', '傋', '塶', '决', '栂', '徻', '紵', '紹',
				'紪', '洁', '敔', '偞', '秢', '戆', '檩', '捔', '媎', '浖',
				'敔', '偄', '科', 'ﵺ', 'ﵳ', 'ﵚ', '\ue26e', '\ueac1', '\ue31c', '\udaa0',
				'\ued2d', '\ue555', '퀺', '劣', '\ue27c', '洼', '洮', '洝', '䫐', '絙',
				'畒', '䁕', '槖', '牕', '章', '獱', '䫚', '絊', '畇', '䁍',
				'槝', '牉', '窴', '獱', '䫀', '絹', '忪', '忦', '忈', '保',
				'䞋', '犁', '嬽', '䃙', '䡶', '䆋', '硑', '侉', '䞋', '犛',
				'嬎', '놾', '놸', '놝', '陿', 'ꇿ', 'ꧣ', '鳻', '땘', '꺪',
				'\ue79d', '\ue78f', '\ue7b9', '쫼', '\ue359', '\uf8bb', '\uf019', '立', '쀺', '\uf7ac',
				'￼', '쫶', '\ue34a', '\uf8ae', '\uf001', '識', '쀦', '\uf7fe', '￼', '쫬',
				'\ue379', '⒙', '⒕', 'Ⓖ', '\u2009', '㮰', '㌟', '㫎', '\u0364', '㓮',
				'㳔', 'য', '⁛', '㮰', '㌅', '㫽', '\u1074', '\u1064', 'ၒ', '"',
				'\u0829', '㴿', 'ᒇ', '\u0f76', 'ߏ', '\u0e77', '㞮', '=', '\u0829', '㴱',
				'ᒚ', '༓', '\u07bd', '\u0e77', '㟝', 'ᣞ', 'ᣌ', '\u18f9', 'ᰘ', '߾',
				'བ', 'ڐ', '㼞', '\u08f2', 'ã', '㖴', 'ᰒ', '\u07ed', 'གྷ', 'ڈ',
				'㼕', '\u08ee', '°', '㖴', 'ᰈ', 'ߞ', '䩌', '䩀', '䩤', '唹',
				'巋', '吀', '涱', '娺', '制', '朊', '仝', '啪', '巋', '吚',
				'涂', '胿', '胵', '胖', 'ꜳ', '邾', '颾', '궺', '萘', '鿶',
				'靓', '麈', 'Ꜣ', '邼', '㜎', '㜜', '㜤', '\u1a6f', '㏊', '⠨',
				'₊', '⥤', 'Ⴉ', '✽', '⽯', '\u1a65', '㏙', '⠽', 'ₒ', '⥯',
				'Ⴕ', '❭', '⽯', '\u1a7f', '㏪', 'ꄍ', 'ꄁ', 'ꄦ', 'ꖟ', '븤',
				'뚋', '뽚', '蛰', '녺', '륀', '谻', 'ꗏ', '븤', '뚑', '뽩',
				'넴', '넿', '넘', 'Ꚏ', '꽜', '雯', 'ꅷ', 'ꥶ', '鰐', '뗅',
				'긶', 'ꚉ', '꽙', '雸', '폶', '폤', '폛', '쎑', '쮞', 'ﺓ',
				'휸', '쳸', '쐱', '춻', '\uf410', '쎀', '쮍', 'ﺇ', '휗', '쳔',
				'쑼', '춧', '\uf40a', '쎛', '쮺', 'Q', ']', '\u007f', 'ᠰ', 'ⴺ',
				'\u0486', 'ὢ', '\u17cd', 'Ḱ', '➽', '\u1030', 'ᠬ', 'ⴠ', 'ҝ', 'ὕ',
				'Գ', 'Դ', 'Ԝ', '⋩', 'ᕴ', 'ᵿ', '⡥', 'ǅ', 'ᨻ', 'ኙ',
				'앺', '앩', '않', '\udd10', '\ue819', '솸', '\uda50', '틚', '\udb77', '\ue29d',
				'픗', '\udd01', '\ue80a', '솬', '\uda7f', '틡', '\udb3c', '\ue29b', '픛', '\udd14',
				'\ue81b', '속', '賿', '賲', '賎', '钞', 'ꆔ', '蠨', '鏌', '魣',
				'銞', 'ꬄ', '鲘', '钘', 'ꆘ', '蠽', '鏝', '魂', 'ⵝ', 'ⵚ',
				'ⵯ', 'ઍ', '㴋', '㔞', '\f', '⦽', '㉛', '㫲', '맖', '맅',
				'맥', 'ꆼ', '钵', '봔', '\ua6fc', '깶', '\ua7db', '鸱', '\ua9bb', 'ꆭ',
				'钦', '봀', 'ꛓ', '깋', 'ꞛ', '鸺', 'ꦰ', 'ꆬ', '钦', '봦',
				'\ue3db', '\ue3d6', '\ue3ef', '\ufbba', '캰', '\ue70c', 'ﳨ', '\uf447', 'ﶺ', '쐦',
				'\uf3b7', 'ﮱ', '캻', '\ue70d', 'ﳨ', '\uf461', 'ꝙ', 'ꝑ', 'Ꝭ', '뤩',
				'肄', '뜕', '뼓', '訙', 'ꎯ', '롊', '냣', '\ue435', '\ue420', '\ue403',
				'侀', '쏛', '\uf456', 'ﱗ', '쥸', '\ue0b8', '\ufb1c', '\uf3b3', '謁', '쏈',
				'\uf442', 'ﱸ', '쥕', '\ue0e4', 'ﬓ', '\uf3b3', '穀', '쏔', '\uf444', 'ﱛ',
				'쥵', '奈', '賈', '碌', '\ue625', '\uee8a', '\ue75b', '\udef1', '\ue97b', '\ue141',
				'푬', '\ufddd', '\ue62a', '\uee8a', '\ue76d', '\udeed', '\ue97d', '\ue162', '푌', '\u17fb',
				'៲', '\u17c3', '\u07bd', '\u0fa6', '㪾', '\u1317', '\u08fe', 'Z', 'ঋ', '〳',
				'\u07bd', '煖', '煟', '煯', '湽', '曞', '漛', '嚾', '愄', '椷',
				'尻', '疔', '湜', '\udf72', '\udf78', '\udf48', '\uf895', '켟', '윞', '\uf23f',
				'\udbff', '쁆', '죲', '섹', '\uf88f', '코', '紇', '紆', '紼', '秀',
				'\u0f8e', 'ྈ', '\u0fb2', '⊻', '\u0b41', 'Ⴌ', '᠉', 'ᇌ', '⡗', '낀',
				'낃', '낽', '꾊', 'Ꜽ', '껭', '掅', '掍', '掻', '篹', '仵',
				'杈', '粧', '琈', '緓', '䑸', '珔', '\u0884', '\u0895', 'ࢻ', 'Ἀ',
				'ᛀ', '⽬', 'ᣫ', 'Ⴢ', '▮', 'ఖ', '\u17bb', 'ἂ', 'ᛥ', '⽨',
				'ᣴ', 'ჾ', '◴', '\u0c44', 'ឪ', 'Ἵ', 'ꉁ', 'ꉊ', 'ꈁ', '藹',
				'눻', '먡', '輇', 'ꚇ', '뵴', '뗝', '밖', '薫', '눪', '먞',
				'溍', '溋', '滌', '炜', '䥨', '绪', '盬', '䏨', '橾', '铊',
				'铌', '针', '茑', '誅', '댦', '蒪', '貤', '릂', 'ᡩ', 'ᡯ',
				'ᠪ', 'ܝ', '\u0fec', 'د', '㾂', 'ࠊ', '*', '\ue77c', '\ue76d', '\ue738',
				'\uf71b', '４', '쨙', '\ue3b2', '\uf872', '\uf0bb', '省', '삍', '\uf711', 'Ｑ',
				'쨝', '\ue3ad', '\uf84e', '\uf0e1', '祿', '삜', '\uf72e', '孧', '孬', '嬢',
				'癑', '徼', '䑏', '䳌', '䔡', '粜', '䬐', '䌜', '瘀', '徭',
				'䑰', 'ﬕ', 'ﬓ', 'ﭓ', '\ue329', '홽', 'ￓ', '\ue43c', '\uec9d', '\ue566',
				'뉧', '뉡', '눠', 'ꉑ', 'ꨄ', '鼆', '뚦', '굁', 'ꗂ', '鑶',
				'鑰', '鐾', '돊', '萘', '谜', '뤐', '邴', '譽', '趽', '趵',
				'跴', '銉', '騦', '鏻', '꩜', '鷜', '闓', 'ꃜ', '襊', '▁',
				'▐', '○', '㗦', '㷩', '\u08e4', '⅏', '㪏', '㉆', '㮑', 'ɰ',
				'㗬', '㷌', '\u08e0', '⅐', '㪳', '㈜', '㯁', 'ɡ', '㗓', '\ue9aa',
				'\ue9a1', '\ue9e1', '쒝', '\ued71', '\uf682', '\ufe01', '\uf7ec', '칑', '利', '\uf1d1',
				'쓍', '\ued60', '\uf6bd', '\u1ccb', '\u1ccd', 'ᲇ', 'Ӱ', 'ㆣ', '\u180d', 'Ϣ',
				'\u0b43', 'ʸ', '蝻', '蝽', '蜶', '靏', '鼘', 'ꨚ', '莺', '顝',
				'郞', '턇', '턁', '텉', '\uf6b9', '셩', '쥭', 'ﱡ', '헅', '츌',
				'딍', '딅', '땂', '\uaa39', 'ꊐ', 'ꭍ', '鋡', 'ꕥ', '굠', '顼',
				'뇽', '繆', '繗', '縖', '渡', '昮', '匣', '窈', '慈', '榁',
				'恑', '妷', '渫', '昋', '匧', '窗', '慴', '槛', '怆', '妦',
				'渔', '\u0bbe', 'வ', '௯', '⚎', 'ཥ', 'ᒖ', 'ᰕ', 'ᗸ', 'ⱅ',
				'ᯉ', 'Ꮕ', '⛙', '\u0f74', 'ᒩ', 'ᕻ', 'ᕲ', 'ᔩ', '\u0b3c', '㊀',
				'Ԙ', 'ഛ', '㠝', 'ᆰ', '\u0a4f', '\u02f3', 'ଜ', '븉', '븏', '빚',
				'꧙', 'ꁆ', '駥', '깩', 'ꙧ', '鍁', 'ᗻ', 'ᗯ', 'ᖯ', 'ப',
				'㈝', '֍', 'ඕ', '㢍', 'ᄬ', '\u0acf', 'ɼ', 'ற', '\u321f', '\u059d',
				'ඵ', '㣟', 'ᄽ', '\u0ad1', 'ɽ', '\u0bbb', '㈞', '\u059c', 'ඣ', '阧',
				'阠', '陲', '襐', '臿', '表', '뇋', '虇', '蹉', '뭯', '饙',
				'饟', '餏', '鷀', '蘾', '軕', '蜎', '뺱', '褟', '嘢', '嘫',
				'噵', '燇', '䙅', '乏', '筇', '勍', '䤀', '䆿', '䡠', '燯',
				'褅', '褁', '襝', '饢', '酾', 'ꑠ', '跢', '曜', '曝', '暅',
				'秹', '駄', '駌', '馞', '膦', '뒲', '鴈', '蛥', '蹅', '螔',
				'븬', '覂', '癈', '癓', '瘓', '犚', '楪', '懐', '株', '再',
				'昆', '渋', '嬀', '犧', '楃', '懭', '株', '再', '昂', '渀',
				'嬉', '犮', '楊', '懤', '栮', '冄', '昏', '渂', '嬉', '犿',
				'楜', '懤', '䔥', '䔹', '䕹', '娕', '动', '孱', '拍', '啦',
				'嵦', '桭', '䇊', '娮', '劀', '孊', '拠', '啦', '嵦', '桩',
				'䇁', '娧', '劉', '孃', '择', '啢', '嵯', '桤', '䇃', '娧',
				'劘', '孕', '择', '鍬', '鍶', '錱', '뒖', '茝', '謢', '븤',
				'鞃', '豧', '蓉', '贃', '뒩', '茢', '謢', '븤', '鞇', '豬',
				'蓀', '贊', '뒠', '茫', '謦', '븭', '鞊', '豮', '蓀', '贛',
				'뒶', '茫', 'ॐ', 'ज़', 'ऎ', 'ᄢ', '⑦', 'ඈ', 'ᘹ', 'Ễ',
				'ᝂ', '⺢', '\u197c', 'ᄢ', '⑤', 'ඈ', '駊', '駄', '馕', '\ue9a1',
				'\ue1ac', '풧', '鴄', '蛨', '蹗', '\ue780', '\ude2a', '\ue9a1', '膶', '뒷',
				'鴺', '\ue6e4', '\uee4a', 'ᵻ', 'ᵭ', 'ᴛ', '媛', '洐', '攝', '倖',
				'ᦶ', 'ɓ', '\u0afb', '\u032c', '媛', '洐', '攝', '〜', 'ᦽ', 'ɐ',
				'櫻', '挱', '媛', 'ട', 'ԑ', '\u302d', '禱', '払', '⺊', '⺙',
				'⻫', '囬', '揧', '⩐', 'ㆡ', '夊', '僀', '楪', '㻪', '㛨',
				'ϫ', '䩀', '冤', '夊', 'ペ', '॰', '㻉', '囬', '揧', '䩀',
				'ﻊ', 'ﻋ', 'ﺨ', '襊', '䊨', '䊦', '䋋', '嶋', '唠', '峤',
				'敭', '㋃', '㫎', '࿅', '♢', '㶆', '㔨', '㳢', 'Ո', '㋃',
				'㫎', '㼭', '㼭', '㽉', '\ue7e7', '\ue7fb', '\ue782', '쪞', '\ue373', '\uf8db',
				'\uf073', '鱗', '쀕', '\uf7cb', 'ﾕ', '쫖', '\ue33f', '\uf8dd', '\uf03a', '樂',
				'쀓', '\uf7d6', 'ﾓ', '쫌', '\ue36b', '\uf89a', '\uf073', '臨', '쀕', '\uf798',
				'\uffd9', '쪘', '\ue339', '\uf890', '\uf075', 'ᶵ', 'ᶴ', '\u1dd3', 'Ͼ', '樓',
				'樑', '橴', '牨', '䝣', '釨', '釪', '醀', '軜', '虱', '竵',
				'竷', '窜', '崋', '檀', '╡', '╥', '┋', '㔌', '㴉', 'ࡋ',
				'↵', '嘞', '嘚', '噵', '乴', '筶', '勚', '䤶', '臘', '臚',
				'膴', '黰', '陒', '憎', '愈', '\ufae4', '\ueae6', '\udc42', '\udc5e', '\udc2c',
				'쐨', '\uf132', '\ud880', '썠', '쯙', '숢', 'ﮦ', '찲', '쐢', '\uf100',
				'\ud884', '썳', '쯂', '숒', '\ufbb9', '찵', '쐮', '\uf123', '\ud8b3', '썚',
				'쯘', '숌', '\ufbb9', '찯', '쐋', '\uf128', '\ud888', '썒', '遾', '遤',
				'逑', '轗', '蟸', '踴', '랃', '而', '蠔', '봙', '钥', '轼',
				'蟥', '踸', '랙', '耒', '蠸', '봟', '钸', '轪', '蟈', '踮',
				'랚', '耎', '蠞', '봼', '钳', '轐', '蟀', 'ꁎ', 'ꀍ', 'ꀾ',
				'븊', '螩', '뀥', '렩', '贾', 'ꒂ', '뽇', '랇', '븂', '螳',
				'끬', '렵', '贯', '꒞', '뼩', '럂', '븏', '蟧', '뀵', '렭',
				'贤', 'ꒂ', '뼩', '량', '브', '螤', '끬', '렸', '贾', '꒟',
				'뽬', '럗', '븂', '螵', '뀜', '⩦', '⩧', '⨗', 'ܐ', 'ﻀ',
				'ﻇ', 'ﺲ', '\ueeb6', '\ue6a1', '펡', '輻', '\ue1f2', '\ue95d', '\ue0b0', 'ϑ',
				'τ', '\u03a2', 'Ꭰ', 'ᮻ', '⺶', '܀', '\u1ce3', 'ᑗ', 'ᶁ', '\u243d',
				'ᎁ', '\u1bf0', '⺡', '\u0711', 'ᳳ', 'ᑒ', 'ᶝ', '\u242a', 'ᎃ', '\u1b81',
				'⺆', '\u073f', '\u1cd5'
			};
			array = new char[8];
			(array as char[])[4] = 'ဂ';
			num = 6;
		}
	}
}
