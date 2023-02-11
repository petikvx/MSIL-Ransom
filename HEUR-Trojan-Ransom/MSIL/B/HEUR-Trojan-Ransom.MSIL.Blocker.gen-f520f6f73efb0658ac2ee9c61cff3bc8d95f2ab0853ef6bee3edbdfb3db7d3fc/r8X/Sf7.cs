using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using f8W;

namespace r8X;

public class Sf7
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ft7
	{
		internal Guna2Panel q;

		internal Guna2Panel j;

		internal Guna2Button P;

		internal Label F;

		internal Guna2Button h;

		internal Guna2Button o;

		internal Guna2Button M;

		internal Control E;

		internal Control X;
	}

	internal sealed class Zf2
	{
		internal IContainer t;

		internal PictureBox R;

		internal Label s;

		internal Label f;

		internal PictureBox J;

		internal Label B;

		internal PictureBox q;

		internal Label W;

		internal Panel o;

		internal Timer k;

		internal Label a;

		internal Zf2()
		{
		}
	}

	private object m;

	private object W;

	[SpecialName]
	public object c1G()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return m;
	}

	[SpecialName]
	public void Cr5(object P_0)
	{
		//Discarded unreachable code: IL_000d
		m = RuntimeHelpers.GetObjectValue(P_0);
	}

	[SpecialName]
	public object d3S()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return W;
	}

	[SpecialName]
	public void Cw2(object P_0)
	{
		//Discarded unreachable code: IL_000d
		W = RuntimeHelpers.GetObjectValue(P_0);
	}

	internal static int Jd6()
	{
		//Discarded unreachable code: IL_0002, IL_001d
		int try0028_dispatch = -1;
		object obj = default(object);
		int num2;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num;
				switch (try0028_dispatch)
				{
				default:
					num = 3;
					goto IL_002b;
				case 83:
					{
						obj = (HttpWebRequest)WebRequest.Create(string.Format(k1X.i1X(14, 642588137, 8), k1X.i1X(3, 642587905, 3), k1X.i1X(4, 642587908, 2), k1X.i1X(5, 642587914, 3), k1X.i1X(4, 642587908, 8), k1X.i1X(11, 642587954, 5), k1X.i1X(12, 642587967, 7), k1X.i1X(12, 642587943, 6), k1X.i1X(0, 642587937, 5)));
						num = 4;
						goto IL_002b;
					}
					IL_002b:
					while (true)
					{
						switch (num)
						{
						default:
							goto IL_004e;
						case 6:
							break;
						case 4:
							(obj as HttpWebRequest).Timeout = 10000;
							goto case 0;
						case 0:
						case 5:
						{
							ISerializable response = ((HttpWebRequest)obj).GetResponse();
							num2 = 100;
							goto end_IL_002b;
						}
						}
						goto case 83;
						IL_004e:
						num = 6;
						continue;
						end_IL_002b:
						break;
					}
					break;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				try0028_dispatch = 83;
				continue;
			}
			break;
		}
		return 4 switch
		{
			_ => num2, 
		};
	}
}
