using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using w1TRg5;

namespace n4XCz5;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Qj4e1A
{
	private static ResourceManager C;

	private static CultureInfo y;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager E
	{
		get
		{
			object obj = default(object);
			while (true)
			{
				bool flag = object.ReferenceEquals(C, null);
				while (true)
				{
					IL_0040:
					int num = ((!flag) ? 6 : 7);
					while (true)
					{
						switch (num)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							num = 2;
							continue;
						case 2:
						case 4:
							break;
						case 1:
							goto IL_0040;
						case 7:
							obj = new ResourceManager(j9ZKy1.o6LAw(26, 1125455538, 5, 4), typeof(Qj4e1A).Assembly);
							num = 3;
							continue;
						case 3:
							C = obj as ResourceManager;
							num = 6;
							continue;
						case 0:
						case 6:
						{
							object c = C;
							return c as ResourceManager;
						}
						}
						break;
					}
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo G
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			IFormatProvider formatProvider = y;
			return formatProvider as CultureInfo;
		}
		set
		{
			//Discarded unreachable code: IL_0007
			y = value;
		}
	}
}
