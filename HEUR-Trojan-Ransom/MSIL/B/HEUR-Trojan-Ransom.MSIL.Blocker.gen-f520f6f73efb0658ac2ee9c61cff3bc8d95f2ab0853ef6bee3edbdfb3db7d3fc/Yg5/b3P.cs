using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using Bb0;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using f8W;

namespace Yg5;

[HideModuleName]
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
internal sealed class b3P
{
	private static ResourceManager x;

	private static CultureInfo u;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager m
	{
		get
		{
			object obj2 = default(object);
			while (true)
			{
				bool flag = object.ReferenceEquals(x, null);
				while (true)
				{
					IL_0040:
					int num = ((!flag) ? 6 : 3);
					while (true)
					{
						switch (num)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							num = 5;
							continue;
						case 5:
							break;
						case 0:
						case 1:
						case 4:
							goto IL_0040;
						case 3:
							obj2 = new ResourceManager(k1X.i1X(9, 642588345, 1), typeof(b3P).Assembly);
							num = 7;
							continue;
						case 7:
							x = obj2 as ResourceManager;
							num = 6;
							continue;
						case 6:
						{
							object obj = x;
							return (ResourceManager)obj;
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
	internal static CultureInfo E
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			object obj = u;
			CultureInfo result = (CultureInfo)obj;
			Jk9.G[159] = (byte)((Jk9.G[159] - Jk9.G[171]) & 0x93);
			return result;
		}
		set
		{
			//Discarded unreachable code: IL_0007
			u = value;
		}
	}
}
