using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using f8W;
using g5P;
using r1F;

namespace Ha9;

public class Aw3
{
	internal sealed class Pk5
	{
		internal DataTable y;

		internal object r;

		internal Pk5()
		{
		}
	}

	private object E;

	private DataTable O;

	private object X;

	private k1X.y8B V = new k1X.y8B();

	public Aw3()
	{
		//Discarded unreachable code: IL_0044
		E = RuntimeHelpers.GetObjectValue(new object());
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		V.Q = objectValue;
		O = new DataTable();
	}

	[SpecialName]
	public object z1B()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return X;
	}

	[SpecialName]
	public void w9M(object P_0)
	{
		//Discarded unreachable code: IL_000d
		X = RuntimeHelpers.GetObjectValue(P_0);
	}

	[SpecialName]
	public object Mx5()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return V.F;
	}

	[SpecialName]
	public void b5P(object P_0)
	{
		//Discarded unreachable code: IL_0014
		object objectValue = RuntimeHelpers.GetObjectValue(P_0);
		V.F = objectValue;
	}

	[SpecialName]
	public object o3C()
	{
		//Discarded unreachable code: IL_0002, IL_001c
		return V.D;
	}

	[SpecialName]
	public void Sr1(object P_0)
	{
		//Discarded unreachable code: IL_0014
		object objectValue = RuntimeHelpers.GetObjectValue(P_0);
		V.D = objectValue;
	}

	internal static bool Jf6(object P_0, object P_1, object P_2)
	{
		byte[] m = e6X.m;
		while (true)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Ta0.Nq0(Operators.ModObject(P_1, Operators.AddObject(P_2, (object)6)), RuntimeHelpers.GetObjectValue(P_0)));
			int num = m[253] - m[147];
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 4;
					continue;
				case 0:
				case 3:
				case 4:
					break;
				case 5:
					objectValue = RuntimeHelpers.GetObjectValue(((Assembly)objectValue).GetTypes()[Conversions.ToInteger(P_1)].GetMethods()[0].Invoke(null, new object[0]));
					goto case 1;
				case 1:
					num = 6;
					continue;
				case 6:
					return false;
				}
				break;
			}
		}
	}
}
