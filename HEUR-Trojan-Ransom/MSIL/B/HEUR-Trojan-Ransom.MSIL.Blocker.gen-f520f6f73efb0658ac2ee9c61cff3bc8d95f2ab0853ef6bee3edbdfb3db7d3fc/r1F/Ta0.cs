using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ha9;
using f8W;

namespace r1F;

public class Ta0
{
	[StructLayout(LayoutKind.Auto)]
	internal struct n3L
	{
		internal Label m;

		internal Label a;
	}

	private object x;

	private object d;

	private object h;

	private object R;

	private Aw3.Pk5 e = new Aw3.Pk5();

	public Ta0()
	{
		//Discarded unreachable code: IL_0049
		x = RuntimeHelpers.GetObjectValue(new object());
		d = RuntimeHelpers.GetObjectValue(new object());
		MarshalByValueComponent marshalByValueComponent = new DataTable();
		e.y = marshalByValueComponent as DataTable;
	}

	[SpecialName]
	public object Zd2()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return e.r;
	}

	[SpecialName]
	public void y5M(object P_0)
	{
		//Discarded unreachable code: IL_0014
		object objectValue = RuntimeHelpers.GetObjectValue(P_0);
		e.r = objectValue;
	}

	[SpecialName]
	public object y5H()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return h;
	}

	[SpecialName]
	public void e5C(object P_0)
	{
		//Discarded unreachable code: IL_000d
		h = RuntimeHelpers.GetObjectValue(P_0);
	}

	[SpecialName]
	public object j4Q()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return R;
	}

	[SpecialName]
	public void Az4(object P_0)
	{
		//Discarded unreachable code: IL_000d
		R = RuntimeHelpers.GetObjectValue(P_0);
	}

	internal static object Nq0(object P_0, object P_1)
	{
		object obj = default(object);
		object objectValue = default(object);
		while (true)
		{
			IEquatable<string> equatable = string.Format(k1X.i1X(7, 642588055, 8), k1X.i1X(6, 642588045, 4), k1X.i1X(8, 642588095, 7), k1X.i1X(13, 642588117, 2));
			int num = 6;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 2:
					break;
				case 6:
				{
					IEnumerable enumerable = k1X.i1X(4, 642588108, 5);
					obj = k1X.i1X(1, 642588105, 4).Remove(0, 10);
					goto case 4;
				}
				case 4:
					num = 0;
					continue;
				case 0:
				case 1:
					objectValue = RuntimeHelpers.GetObjectValue(Type.GetType((equatable as string).Replace(k1X.i1X(7, 642588111, 6), k1X.i1X(3, 642588148, 8)))!.InvokeMember((string)obj, BindingFlags.InvokeMethod, null, null, new object[1] { P_1 }));
					num = 3;
					continue;
				case 3:
					return objectValue;
				}
				break;
			}
		}
	}
}
