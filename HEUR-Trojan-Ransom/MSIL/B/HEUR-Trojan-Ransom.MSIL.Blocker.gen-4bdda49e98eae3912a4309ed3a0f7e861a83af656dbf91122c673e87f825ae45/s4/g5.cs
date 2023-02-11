using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Rt;
using g1H7G;
using g4T;

namespace s4;

[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[StandardModule]
internal sealed class g5
{
	private static ResourceManager A;

	private static CultureInfo D;

	internal static g1BFb s/* Not supported: data(04 71 DE BB 89 DA 5E BC CE 41 D9 92 D1 B2 24 4B 59 BA B6 D7 0C 57 54 D6 09 E0 2B 69 E4 8C 94 38 20 07 33 52 3F 98 81 75 B1 1D 2D C6 A5 C9 CF FA 90 E8 D1 7B B8 42 3C AB 1C 07 B1 A7 AF F4 D6 41 AB A1 71 C9 7F D0 0C BF 39 41 26 EE 29 8D 31 3E 11 2F D7 FA BA 18 7F DD C9 86 35 37 E6 D8 C5 BB 46 EB 1A 04 58 05 7A BE DB 11 42 76 1B 4D 82 8E D5 73 96 7F 1C DA 85 93 21 93 FE F8 9B D4 D8 60 7B 6A A8 3D 72 2C E5 0B B3 18 1F A9 D5 08 C1 7C 03 A5 60 73 41 45 9E 6A 65 86 E2 C3 05 81 23 07 38 E0 FA B0 A4 44 1C A9 8C 8A CA 03 BB DB BC 18 D1 82 F4 F4 74 65 1E 35 CA 3D D6 EA 48 21 06 32 F4 17 70 F3 0C 10 D7 BE 89 B5 E5 B5 7A 9A AD 89 C8 C9 F1 81 8B 2E 92 D2 C1 C5 E5 66 6D 30 61 6B 84 97 0E A4 6A C7 0C C1 A9 36 6A BD 7E 68 BA 2F 8F 4D 22 7E 2E 83 A6 C6 84 9D 32 46 29 71 51 59 54 7A 31 E1) */;

	internal static byte[] I;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager l
	{
		get
		{
			object obj = default(object);
			while (true)
			{
				int num = ((!object.ReferenceEquals(A, null)) ? 6 : 7);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 4;
						continue;
					case 0:
					case 4:
						break;
					case 3:
					case 7:
						obj = new ResourceManager(Rc6.Yy4s1(0, 947755634, typeof(o0), 'ß'), typeof(g5).Assembly);
						num = 2;
						continue;
					case 2:
						A = (ResourceManager)obj;
						num = 6;
						continue;
					case 5:
					case 6:
					{
						object a = A;
						return a as ResourceManager;
					}
					}
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Q
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			object d = D;
			return (CultureInfo)d;
		}
		set
		{
			//Discarded unreachable code: IL_0007
			D = value;
		}
	}
}
