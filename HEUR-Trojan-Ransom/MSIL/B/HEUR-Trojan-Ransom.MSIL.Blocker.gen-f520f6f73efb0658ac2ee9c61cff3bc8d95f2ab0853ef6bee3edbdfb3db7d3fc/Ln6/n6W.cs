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
using Bb0;
using Cm6;
using Jo2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Zo1;
using f8W;
using g5P;
using s6S;

namespace Ln6;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class n6W
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class q8T
	{
		[ThreadStatic]
		private static Hashtable t;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k1X r;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g3X Q;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t4C V;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jk9 A;

		private static Wj8 Mi0<Wj8>(Wj8 P_0) where Wj8 : Form, new()
		{
			bool flag = default(bool);
			Wj8 val = default(Wj8);
			while (true)
			{
				int num = ((P_0 == null) ? 9 : 12);
				while (true)
				{
					int num2;
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 8;
						continue;
					case 8:
						break;
					case 12:
						num2 = (((Control)P_0).get_IsDisposed() ? 1 : 0);
						goto IL_006a;
					case 9:
						num2 = 1;
						goto IL_006a;
					case 0:
					{
						if (flag)
						{
							num = 10;
							continue;
						}
						int num3 = 0;
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 2:
							case 5:
								return val;
							}
							val = P_0;
							num3 = 2;
						}
					}
					case 10:
						num = ((t == null) ? 3 : 5);
						continue;
					case 5:
						num = ((!t.ContainsKey(typeof(Wj8))) ? 6 : 4);
						continue;
					case 4:
						throw new InvalidOperationException(Utils.GetResourceString(k1X.i1X(3, 642587936, 8), new string[0]));
					case 2:
					case 6:
						num = 7;
						continue;
					case 3:
					case 11:
						t = new Hashtable();
						num = 7;
						continue;
					case 7:
						{
							t.Add(typeof(Wj8), null);
							try
							{
								return 1 switch
								{
									3 => val, 
									_ => new Wj8(), 
								};
							}
							catch (TargetInvocationException ex) when (((Func<bool>)delegate
							{
								// Could not convert BlockContainer to single expression
								ProjectData.SetProjectError((Exception)ex);
								return (ex as TargetInvocationException).InnerException != null;
							}).Invoke())
							{
								IEnumerable resourceString = Utils.GetResourceString(k1X.i1X(14, 642587969, 8), new string[1] { (ex as TargetInvocationException).InnerException!.Message });
								throw new InvalidOperationException(resourceString as string, (ex as TargetInvocationException).InnerException);
							}
							finally
							{
								switch (0)
								{
								default:
									t.Remove(typeof(Wj8));
									break;
								}
							}
						}
						IL_006a:
						flag = (byte)num2 != 0;
						goto case 0;
					}
					break;
				}
			}
		}

		private void j4H<t4F>(ref t4F P_0) where t4F : Form
		{
			//Discarded unreachable code: IL_0014
			((Component)P_0).Dispose();
			P_0 = default(t4F);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q8T()
		{
		}//Discarded unreachable code: IL_0007


		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool y0G(object P_0)
		{
			//Discarded unreachable code: IL_0002, IL_001c
			bool result = base.Equals(RuntimeHelpers.GetObjectValue(P_0));
			e6X.m[53] = Jk9.G[433];
			return result;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Xp1()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Jp5()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			MemberInfo typeFromHandle = typeof(q8T);
			Type result = (Type)typeFromHandle;
			Jk9.G[485] = (byte)((Jk9.G[485] - Jk9.G[471]) & 0x8F);
			return result;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Mq3()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			IComparable comparable = base.ToString();
			return comparable as string;
		}

		[SpecialName]
		public k1X Yz0()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			r = Mi0(r);
			return r;
		}

		[SpecialName]
		public g3X x0P()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			Q = Mi0(Q);
			return Q;
		}

		[SpecialName]
		public t4C r5S()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			V = Mi0(V);
			return V;
		}

		[SpecialName]
		public Jk9 r7J()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			A = Mi0(A);
			return A;
		}

		[SpecialName]
		public void Ma8(k1X P_0)
		{
			//Discarded unreachable code: IL_006e
			int num = 8;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((P_0 != r) ? 4 : 6);
					break;
				case 5:
				case 6:
					num = 7;
					break;
				case 0:
				case 2:
				case 4:
					num = ((P_0 == null) ? 1 : 3);
					break;
				case 3:
					throw new ArgumentException(k1X.i1X(5, 642588005, 1));
				case 1:
					j4H(ref r);
					return;
				case 7:
					return;
				}
			}
		}

		[SpecialName]
		public void Lp4(g3X P_0)
		{
			//Discarded unreachable code: IL_006f
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((P_0 != Q) ? 4 : 0);
					break;
				case 0:
				case 5:
					num = 2;
					break;
				case 4:
					num = ((P_0 == null) ? 3 : 8);
					break;
				case 7:
				case 8:
					throw new ArgumentException(k1X.i1X(11, 642588005, 1));
				case 3:
					j4H(ref Q);
					return;
				case 2:
				case 6:
					return;
				}
			}
		}

		[SpecialName]
		public void Jf7(t4C P_0)
		{
			//Discarded unreachable code: IL_0093
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((P_0 == V) ? 8 : 0);
					break;
				case 3:
				case 8:
					num = 7;
					break;
				case 0:
					num = ((P_0 == null) ? 6 : 4);
					break;
				case 1:
				case 2:
				case 4:
					throw new ArgumentException(k1X.i1X(6, 642588012, 8));
				case 6:
					j4H(ref V);
					e6X.m[240] = (byte)((e6X.m[240] * e6X.m[357]) & 0x5F);
					return;
				case 7:
					return;
				}
			}
		}

		[SpecialName]
		public void q9F(Jk9 P_0)
		{
			//Discarded unreachable code: IL_006f
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((P_0 != A) ? 2 : 8);
					break;
				case 8:
					num = 3;
					break;
				case 2:
					num = ((P_0 == null) ? 4 : 7);
					break;
				case 7:
					throw new ArgumentException(k1X.i1X(9, 642588007, 3));
				case 0:
				case 4:
					j4H(ref A);
					return;
				case 1:
				case 3:
					return;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class b1S
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Ba5(object P_0)
		{
			//Discarded unreachable code: IL_0002, IL_001c
			return base.Equals(RuntimeHelpers.GetObjectValue(P_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int x0R()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			int hashCode = base.GetHashCode();
			e6X.m[229] = (byte)((e6X.m[229] + e6X.m[242]) & 0xE5);
			return hashCode;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Mt1()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			object typeFromHandle = typeof(b1S);
			return typeFromHandle as Type;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string x9N()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			IEnumerable<char> enumerable = base.ToString();
			return (string)enumerable;
		}

		private static Bt6 Fq7<Bt6>(Bt6 P_0) where Bt6 : new()
		{
			Bt6 val = default(Bt6);
			while (true)
			{
				int num = ((P_0 == null) ? 1 : 4);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 5;
						continue;
					case 0:
					case 5:
						break;
					case 1:
						val = new Bt6();
						goto case 7;
					case 7:
						num = 2;
						continue;
					case 3:
					case 4:
						val = P_0;
						num = 2;
						continue;
					case 2:
					{
						Bt6 result = val;
						Jk9.G[46] = (byte)((Jk9.G[46] + Jk9.G[242]) & 0xD6);
						return result;
					}
					}
					break;
				}
			}
		}

		private void Qd8<Hn3>(ref Hn3 P_0)
		{
			//Discarded unreachable code: IL_0008
			P_0 = default(Hn3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b1S()
		{
		}//Discarded unreachable code: IL_0007

	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class w7L<To2> where To2 : new()
	{
		[ThreadStatic]
		private static To2 y;

		[SpecialName]
		internal To2 i7R()
		{
			To2 result = default(To2);
			while (true)
			{
				bool flag = y == null;
				while (true)
				{
					IL_003c:
					int num = ((!flag) ? 4 : 5);
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
							goto IL_003c;
						case 5:
							y = new To2();
							num = 4;
							continue;
						case 0:
						case 4:
							return y;
						case 6:
							return result;
						}
						break;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w7L()
		{
		}//Discarded unreachable code: IL_0007

	}

	private static readonly w7L<Rr0> x = new w7L<Rr0>();

	private static readonly w7L<w2D> D = new w7L<w2D>();

	private static readonly w7L<User> t = new w7L<User>();

	private static w7L<q8T> q = new w7L<q8T>();

	private static readonly w7L<b1S> K = new w7L<b1S>();

	[HelpKeyword("My.Computer")]
	internal static Rr0 s
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			Computer val = (Computer)(object)x.s();
			return (Rr0)(object)val;
		}
	}

	[HelpKeyword("My.Application")]
	internal static w2D A
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			ConsoleApplicationBase val = (ConsoleApplicationBase)(object)D.s();
			w2D result = (w2D)(object)val;
			Jk9.G[429] = (byte)((Jk9.G[429] | Jk9.G[291]) & 0x82);
			return result;
		}
	}

	[HelpKeyword("My.User")]
	internal static User s
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			object obj = t.s();
			object result = ((obj is User) ? obj : null);
			Jk9.G[20] = (byte)((Jk9.G[20] + Jk9.G[342]) & 0x7A);
			return (User)result;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static q8T v
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			object obj = q.s();
			q8T result = (q8T)obj;
			e6X.m[292] = (byte)((e6X.m[292] | e6X.m[328]) & 0x25);
			return result;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static b1S r
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			object obj = K.s();
			return (b1S)obj;
		}
	}
}
