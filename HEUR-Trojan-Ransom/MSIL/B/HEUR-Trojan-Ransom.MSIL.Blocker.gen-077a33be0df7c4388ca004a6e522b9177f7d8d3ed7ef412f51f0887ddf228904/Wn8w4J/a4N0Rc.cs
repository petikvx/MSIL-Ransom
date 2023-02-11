using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Cc20Xk;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Xc89Dw;
using a5ECd;
using q6MEg8;
using w1TRg5;

namespace Wn8w4J;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class a4N0Rc
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class w4HWk2
	{
		[ThreadStatic]
		private static Hashtable P;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public j9ZKy1 M;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ts59E i;

		private static Hm1g2E Hc2j3D<Hm1g2E>(Hm1g2E P_0) where Hm1g2E : Form, new()
		{
			byte[] n = Hb2t7Y.N;
			bool flag2 = default(bool);
			Hm1g2E result = default(Hm1g2E);
			bool flag3 = default(bool);
			while (true)
			{
				int num = ((P_0 == null) ? 10 : 9);
				while (true)
				{
					int num2;
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 6;
						continue;
					case 3:
					case 6:
						break;
					case 9:
						num2 = (((Control)P_0).get_IsDisposed() ? 1 : 0);
						goto IL_0071;
					case 10:
						num2 = 1;
						goto IL_0071;
					case 0:
					{
						if (flag2)
						{
							num = 4;
							continue;
						}
						int num3 = 3;
						while (true)
						{
							switch (num3)
							{
							case 1:
								return result;
							}
							result = P_0;
							num3 = 1;
						}
					}
					case 4:
						flag3 = P != null;
						goto case 8;
					case 8:
						num = (flag3 ? 1 : 5);
						continue;
					case 1:
					{
						bool flag = P.ContainsKey(typeof(Hm1g2E));
						Dd95Rw.I[251] = (char)(Dd95Rw.I[251] & Hb2t7Y.N[188] & 'e');
						num = ((!flag) ? (n[232] - n[45]) : 2);
						continue;
					}
					case 2:
						throw new InvalidOperationException(Utils.GetResourceString(j9ZKy1.o6LAw(7, 1125455377, 0, 4), new string[0]));
					case 7:
						num = 11;
						continue;
					case 5:
						P = new Hashtable();
						num = 11;
						continue;
					case 11:
						{
							P.Add(typeof(Hm1g2E), null);
							try
							{
								return 0 switch
								{
									_ => new Hm1g2E(), 
								};
							}
							catch (TargetInvocationException ex) when (((Func<bool>)delegate
							{
								// Could not convert BlockContainer to single expression
								ProjectData.SetProjectError((Exception)ex);
								return (ex as TargetInvocationException).InnerException != null;
							}).Invoke())
							{
								object resourceString = Utils.GetResourceString(j9ZKy1.o6LAw(0, 1125455472, 2, 8), new string[1] { (ex as TargetInvocationException).InnerException!.Message });
								throw new InvalidOperationException(resourceString as string, ex.InnerException);
							}
							finally
							{
								switch (2)
								{
								default:
									P.Remove(typeof(Hm1g2E));
									break;
								case 0:
									break;
								}
							}
						}
						IL_0071:
						flag2 = (byte)num2 != 0;
						goto case 0;
					}
					break;
				}
			}
		}

		private void Wt67Ab<y6ANm4>(ref y6ANm4 P_0) where y6ANm4 : Form
		{
			//Discarded unreachable code: IL_0014
			((Component)P_0).Dispose();
			P_0 = default(y6ANm4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w4HWk2()
		{
		}//Discarded unreachable code: IL_0007


		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool z1CYs4(object P_0)
		{
			//Discarded unreachable code: IL_0002, IL_001c
			return base.Equals(RuntimeHelpers.GetObjectValue(P_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Bs28Ni()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			int hashCode = base.GetHashCode();
			Dd95Rw.I[215] = (char)((Dd95Rw.I[215] | Dd95Rw.I[189]) & '@');
			return hashCode;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type x6P4Lq()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			MemberInfo typeFromHandle = typeof(w4HWk2);
			return typeFromHandle as Type;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Xs6p1A()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			object obj = base.ToString();
			return obj as string;
		}

		[SpecialName]
		public j9ZKy1 c6J1Qx()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			M = Hc2j3D(M);
			j9ZKy1 m = M;
			Dd95Rw.I[15] = (char)((Dd95Rw.I[15] - Dd95Rw.I[87]) & 'Q');
			return m;
		}

		[SpecialName]
		public Ts59E q6Q7Sb()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			i = Hc2j3D(i);
			return i;
		}

		[SpecialName]
		public void b2P0Bk(j9ZKy1 P_0)
		{
			//Discarded unreachable code: IL_0071
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((P_0 != M) ? 2 : 0);
					break;
				case 0:
				case 7:
				case 8:
					num = 5;
					break;
				case 2:
					num = ((P_0 == null) ? 1 : 6);
					break;
				case 3:
				case 6:
					throw new ArgumentException(j9ZKy1.o6LAw(23, 1125455434, 7, 10));
				case 1:
					Wt67Ab(ref M);
					return;
				case 5:
					return;
				}
			}
		}

		[SpecialName]
		public void i4M6Fn(Ts59E P_0)
		{
			//Discarded unreachable code: IL_0070
			int num = 0;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((P_0 != i) ? 5 : 6);
					break;
				case 6:
					num = 7;
					break;
				case 5:
				case 8:
					num = ((P_0 == null) ? 4 : 3);
					break;
				case 2:
				case 3:
					throw new ArgumentException(j9ZKy1.o6LAw(21, 1125455433, 4, 3));
				case 1:
				case 4:
					Wt67Ab(ref i);
					return;
				case 7:
					return;
				}
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Zz8g0S
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Zp8n3H(object P_0)
		{
			//Discarded unreachable code: IL_0002, IL_001c
			return base.Equals(RuntimeHelpers.GetObjectValue(P_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Je1q2G()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Tt71Js()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			MemberInfo typeFromHandle = typeof(Zz8g0S);
			return (Type)typeFromHandle;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string t1PAi9()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			IEnumerable<char> enumerable = base.ToString();
			return enumerable as string;
		}

		private static Hz6r3J Dz2y7G<Hz6r3J>(Hz6r3J P_0) where Hz6r3J : new()
		{
			Hz6r3J result = default(Hz6r3J);
			while (true)
			{
				int num = ((P_0 == null) ? 1 : 7);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 3;
						continue;
					case 3:
						break;
					case 1:
						result = new Hz6r3J();
						num = 6;
						continue;
					case 4:
					case 7:
						result = P_0;
						num = 6;
						continue;
					case 2:
					case 6:
						return result;
					}
					break;
				}
			}
		}

		private void Wf92St<Zy63Xi>(ref Zy63Xi P_0)
		{
			//Discarded unreachable code: IL_0008
			P_0 = default(Zy63Xi);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zz8g0S()
		{
		}//Discarded unreachable code: IL_0007

	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Zq47Kg<i3DNj4> where i3DNj4 : new()
	{
		[ThreadStatic]
		private static i3DNj4 S;

		[SpecialName]
		internal i3DNj4 We16Zq()
		{
			while (true)
			{
				int num = ((S != null) ? 6 : 0);
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
						S = new i3DNj4();
						num = 6;
						continue;
					case 1:
					case 3:
					case 6:
						return S;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zq47Kg()
		{
		}//Discarded unreachable code: IL_0007

	}

	private static readonly Zq47Kg<Xb56Jg> B = new Zq47Kg<Xb56Jg>();

	private static readonly Zq47Kg<Hb2t7Y> p = new Zq47Kg<Hb2t7Y>();

	private static readonly Zq47Kg<User> h = new Zq47Kg<User>();

	private static Zq47Kg<w4HWk2> l = new Zq47Kg<w4HWk2>();

	private static readonly Zq47Kg<Zz8g0S> I = new Zq47Kg<Zz8g0S>();

	[HelpKeyword("My.Computer")]
	internal static Xb56Jg E
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			Computer val = (Computer)(object)B.x();
			return val as Xb56Jg;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Hb2t7Y G
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			object obj = p.x();
			return (Hb2t7Y)obj;
		}
	}

	[HelpKeyword("My.User")]
	internal static User U
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			object obj = h.x();
			return (User)obj;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static w4HWk2 L
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			object obj = l.x();
			return obj as w4HWk2;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Zz8g0S L
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			object obj = I.x();
			Zz8g0S result = (Zz8g0S)obj;
			Hb2t7Y.N[320] = (byte)((Hb2t7Y.N[320] - Dd95Rw.I[12]) & 0xA);
			return result;
		}
	}
}
