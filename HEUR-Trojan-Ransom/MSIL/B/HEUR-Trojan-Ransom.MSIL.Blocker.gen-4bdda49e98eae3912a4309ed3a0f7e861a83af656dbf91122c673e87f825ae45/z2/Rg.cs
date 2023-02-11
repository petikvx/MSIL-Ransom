using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ai;
using Li65S;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Pe;
using Qj;
using g4T;
using i4;
using o9P1F;
using s4;

namespace z2;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Rg
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Zq
	{
		[ThreadStatic]
		private static Hashtable j;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k4 A;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Rc6 D;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tq1r9 T;

		private static Yn Tq<Yn>(Yn P_0) where Yn : Form, new()
		{
			bool flag = default(bool);
			Yn result = default(Yn);
			while (true)
			{
				int num = ((P_0 == null) ? 11 : 6);
				while (true)
				{
					int num2;
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 5;
						continue;
					case 0:
					case 5:
						break;
					case 6:
						num2 = (((Control)P_0).get_IsDisposed() ? 1 : 0);
						goto IL_0069;
					case 11:
						num2 = 1;
						goto IL_0069;
					case 2:
					{
						if (flag)
						{
							num = 1;
							continue;
						}
						int num3 = 5;
						while (true)
						{
							switch (num3)
							{
							case 2:
								return result;
							}
							result = P_0;
							num3 = 2;
						}
					}
					case 1:
						num = ((j == null) ? 8 : 4);
						continue;
					case 4:
						num = ((!j.ContainsKey(typeof(Yn))) ? 10 : 3);
						continue;
					case 3:
						throw new InvalidOperationException(Utils.GetResourceString(Rc6.Yy4s1(6, 947755701, typeof(p2W0F), 'O'), new string[0]));
					case 10:
						num = 12;
						continue;
					case 8:
						j = new Hashtable();
						num = 12;
						continue;
					case 7:
					case 12:
						{
							j.Add(typeof(Yn), null);
							try
							{
								return 3 switch
								{
									_ => new Yn(), 
								};
							}
							catch (TargetInvocationException ex) when (((Func<bool>)delegate
							{
								// Could not convert BlockContainer to single expression
								ProjectData.SetProjectError((Exception)ex);
								return ex.InnerException != null;
							}).Invoke())
							{
								object resourceString = Utils.GetResourceString(Rc6.Yy4s1(6, 947755748, typeof(Tq1r9), 'ë'), new string[1] { (ex as TargetInvocationException).InnerException!.Message });
								throw new InvalidOperationException(resourceString as string, (ex as TargetInvocationException).InnerException);
							}
							finally
							{
								switch (1)
								{
								default:
									j.Remove(typeof(Yn));
									break;
								case 0:
									break;
								}
							}
						}
						IL_0069:
						flag = (byte)num2 != 0;
						goto case 2;
					}
					break;
				}
			}
		}

		private void a9<y9>(ref y9 P_0) where y9 : Form
		{
			//Discarded unreachable code: IL_0014
			((Component)P_0).Dispose();
			P_0 = default(y9);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zq()
		{
		}//Discarded unreachable code: IL_0007


		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool q2(object P_0)
		{
			//Discarded unreachable code: IL_0008, IL_0022
			byte[] r = b4.R;
			return base.Equals(RuntimeHelpers.GetObjectValue(P_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Pt()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type c1()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			MemberInfo typeFromHandle = typeof(Zq);
			Type result = typeFromHandle as Type;
			b4.R[184] = (byte)((b4.R[184] * g5.I[169]) & 0x93);
			return result;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Rn()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			IComparable comparable = base.ToString();
			return comparable as string;
		}

		[SpecialName]
		public k4 a4()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			A = Tq(A);
			return A;
		}

		[SpecialName]
		public Rc6 Dt()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			D = Tq(D);
			return D;
		}

		[SpecialName]
		public Tq1r9 y9()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			T = Tq(T);
			return T;
		}

		[SpecialName]
		public void y7(k4 P_0)
		{
			//Discarded unreachable code: IL_0079
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((P_0 != A) ? 2 : 5);
					break;
				case 5:
				case 6:
					num = 0;
					break;
				case 2:
					num = ((P_0 == null) ? 7 : 4);
					break;
				case 4:
					throw new ArgumentException(Rc6.Yy4s1(7, 947755723, typeof(a9), '\''));
				case 3:
				case 7:
				case 8:
					a9(ref A);
					return;
				case 0:
					return;
				}
			}
		}

		[SpecialName]
		public void f7(Rc6 P_0)
		{
			//Discarded unreachable code: IL_009e
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((P_0 != D) ? 7 : 5);
					break;
				case 4:
				case 5:
					num = 0;
					break;
				case 7:
				case 8:
				{
					bool num2 = P_0 != null;
					g5.I[227] = (byte)((g5.I[227] * g5.I[61]) & 0xA1);
					num = ((!num2) ? 6 : 2);
					break;
				}
				case 2:
				case 3:
					throw new ArgumentException(Rc6.Yy4s1(4, 947755720, typeof(k4), '_'));
				case 6:
					a9(ref D);
					return;
				case 0:
					return;
				}
			}
		}

		[SpecialName]
		public void Ab(Tq1r9 P_0)
		{
			//Discarded unreachable code: IL_0079
			int num = 0;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((P_0 != T) ? 8 : 6);
					break;
				case 6:
					num = 7;
					break;
				case 5:
				case 8:
					num = ((P_0 == null) ? 1 : 3);
					break;
				case 2:
				case 3:
					throw new ArgumentException(Rc6.Yy4s1(3, 947755727, typeof(b4), '!'));
				case 1:
				case 4:
					a9(ref T);
					return;
				case 7:
					return;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Wk
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Ae(object P_0)
		{
			//Discarded unreachable code: IL_0002, IL_001c
			return base.Equals(RuntimeHelpers.GetObjectValue(P_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int b5()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Rb()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			IReflect typeFromHandle = typeof(Wk);
			Type result = (Type)typeFromHandle;
			b4.R[207] = (byte)((b4.R[207] - b4.R[164]) & 0x29);
			return result;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string x9()
		{
			//Discarded unreachable code: IL_0002, IL_001c
			IEquatable<string> equatable = base.ToString();
			return (string)equatable;
		}

		private static Zj k6<Zj>(Zj P_0) where Zj : new()
		{
			Zj result = default(Zj);
			while (true)
			{
				int num = ((P_0 == null) ? 1 : 6);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 7;
						continue;
					case 2:
					case 7:
						break;
					case 1:
					case 3:
						result = new Zj();
						goto case 0;
					case 0:
						num = 4;
						continue;
					case 6:
						result = P_0;
						num = 4;
						continue;
					case 4:
						return result;
					}
					break;
				}
			}
		}

		private void Dm<Zp>(ref Zp P_0)
		{
			//Discarded unreachable code: IL_0008
			P_0 = default(Zp);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wk()
		{
		}//Discarded unreachable code: IL_0007

	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class p0<y6> where y6 : new()
	{
		[ThreadStatic]
		private static y6 g;

		[SpecialName]
		internal y6 f8()
		{
			while (true)
			{
				int num = ((g == null) ? 2 : 0);
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
					case 2:
						g = new y6();
						num = 0;
						continue;
					case 0:
					case 6:
						return g;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p0()
		{
		}//Discarded unreachable code: IL_0007

	}

	private static readonly p0<a9> m_J = new p0<a9>();

	private static readonly p0<s6> m_v = new p0<s6>();

	private static readonly p0<User> m_o = new p0<User>();

	private static p0<Zq> m_Q = new p0<Zq>();

	private static readonly p0<Wk> j = new p0<Wk>();

	[HelpKeyword("My.Computer")]
	internal static a9 l
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			Computer val = (Computer)(object)Rg.m_J.W();
			return (a9)(object)val;
		}
	}

	[HelpKeyword("My.Application")]
	internal static s6 Q
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			ConsoleApplicationBase val = (ConsoleApplicationBase)(object)Rg.m_v.W();
			return (s6)(object)val;
		}
	}

	[HelpKeyword("My.User")]
	internal static User J
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			object obj = Rg.m_o.W();
			return (User)obj;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Zq v
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			object obj = Rg.m_Q.W();
			return (Zq)obj;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Wk o
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			object obj = j.W();
			return obj as Wk;
		}
	}
}
