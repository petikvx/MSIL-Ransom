using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ac42;
using En4;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Nm3z;
using Sp5f;
using Tm8;
using Zz6;
using b8X2;
using c1RE;
using c3Z;
using c8DW;
using e5F;
using p2S;
using q2J;
using s8P;
using s9X;

namespace o3C;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class Qm5
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Ls4
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mr4 m_Form1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public j9J m_Form10;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d0F m_Form11;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public j8Y m_Form12;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y4J m_Form13;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n6Z m_Form2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q9B m_Form3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pr4x m_Form4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fy68 m_Form5;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c7MG m_Form6;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hb1a m_Form7;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m5N4 m_Form8;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lc9y m_Form9;

		private static Zo3 o4D<Zo3>(Zo3 q1Z) where Zo3 : Form, new()
		{
			if (q1Z == null || ((Control)q1Z).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Zo3)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Zo3), null);
				try
				{
					return new Zo3();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError((Exception)ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message });
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(Zo3));
				}
			}
			return q1Z;
		}

		private void n5J<w0K>(ref w0K q4C) where w0K : Form
		{
			((Component)q4C).Dispose();
			q4C = default(w0K);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ls4()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Hp6(object z1T)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(z1T));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Gz4()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type j2S()
		{
			return typeof(Ls4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Zr9()
		{
			return base.ToString();
		}

		[SpecialName]
		public Mr4 f2H()
		{
			m_Form1 = o4D(m_Form1);
			return m_Form1;
		}

		[SpecialName]
		public j9J y9H()
		{
			m_Form10 = o4D(m_Form10);
			return m_Form10;
		}

		[SpecialName]
		public d0F Am4()
		{
			m_Form11 = o4D(m_Form11);
			return m_Form11;
		}

		[SpecialName]
		public j8Y e9P()
		{
			m_Form12 = o4D(m_Form12);
			return m_Form12;
		}

		[SpecialName]
		public y4J Cr0()
		{
			m_Form13 = o4D(m_Form13);
			return m_Form13;
		}

		[SpecialName]
		public n6Z k8W()
		{
			m_Form2 = o4D(m_Form2);
			return m_Form2;
		}

		[SpecialName]
		public q9B Cx0()
		{
			m_Form3 = o4D(m_Form3);
			return m_Form3;
		}

		[SpecialName]
		public Pr4x Lb2()
		{
			m_Form4 = o4D(m_Form4);
			return m_Form4;
		}

		[SpecialName]
		public Fy68 Ne1()
		{
			m_Form5 = o4D(m_Form5);
			return m_Form5;
		}

		[SpecialName]
		public c7MG s7W()
		{
			m_Form6 = o4D(m_Form6);
			return m_Form6;
		}

		[SpecialName]
		public Hb1a Mn2()
		{
			m_Form7 = o4D(m_Form7);
			return m_Form7;
		}

		[SpecialName]
		public m5N4 Xp1()
		{
			m_Form8 = o4D(m_Form8);
			return m_Form8;
		}

		[SpecialName]
		public Lc9y Ta5()
		{
			m_Form9 = o4D(m_Form9);
			return m_Form9;
		}

		[SpecialName]
		public void Ey8(Mr4 r6A)
		{
			if (r6A != m_Form1)
			{
				if (r6A != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				n5J(ref m_Form1);
			}
		}

		[SpecialName]
		public void j5E(j9J Wx8)
		{
			if (Wx8 != m_Form10)
			{
				if (Wx8 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				n5J(ref m_Form10);
			}
		}

		[SpecialName]
		public void Xb5(d0F y0C)
		{
			if (y0C != m_Form11)
			{
				if (y0C != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				n5J(ref m_Form11);
			}
		}

		[SpecialName]
		public void p9H(j8Y n9F)
		{
			if (n9F != m_Form12)
			{
				if (n9F != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				n5J(ref m_Form12);
			}
		}

		[SpecialName]
		public void Hg2(y4J o8H)
		{
			if (o8H != m_Form13)
			{
				if (o8H != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				n5J(ref m_Form13);
			}
		}

		[SpecialName]
		public void f7E(n6Z Rd6)
		{
			if (Rd6 != m_Form2)
			{
				if (Rd6 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				n5J(ref m_Form2);
			}
		}

		[SpecialName]
		public void a9Z(q9B w5F)
		{
			if (w5F != m_Form3)
			{
				if (w5F != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				n5J(ref m_Form3);
			}
		}

		[SpecialName]
		public void Yw1(Pr4x f0Z)
		{
			if (f0Z != m_Form4)
			{
				if (f0Z != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				n5J(ref m_Form4);
			}
		}

		[SpecialName]
		public void d2G(Fy68 Ks4)
		{
			if (Ks4 != m_Form5)
			{
				if (Ks4 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				n5J(ref m_Form5);
			}
		}

		[SpecialName]
		public void Mm7(c7MG Ae9)
		{
			if (Ae9 != m_Form6)
			{
				if (Ae9 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				n5J(ref m_Form6);
			}
		}

		[SpecialName]
		public void b5H(Hb1a j8P)
		{
			if (j8P != m_Form7)
			{
				if (j8P != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				n5J(ref m_Form7);
			}
		}

		[SpecialName]
		public void Ec3(m5N4 x2L)
		{
			if (x2L != m_Form8)
			{
				if (x2L != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				n5J(ref m_Form8);
			}
		}

		[SpecialName]
		public void Ji7(Lc9y z1Q)
		{
			if (z1Q != m_Form9)
			{
				if (z1Q != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				n5J(ref m_Form9);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class j8R
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Ni5(object Fx2)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Fx2));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int p0B()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Ce8()
		{
			return typeof(j8R);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string y8P()
		{
			return base.ToString();
		}

		private static Bx0 c1X<Bx0>(Bx0 d2J) where Bx0 : new()
		{
			if (d2J == null)
			{
				return new Bx0();
			}
			return d2J;
		}

		private void Kg9<a6N>(ref a6N Bs0)
		{
			Bs0 = default(a6N);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public j8R()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class k3S<s7M> where s7M : new()
	{
		[ThreadStatic]
		private static s7M m_ThreadStaticValue;

		[SpecialName]
		internal s7M w2B()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new s7M();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k3S()
		{
		}
	}

	private static readonly k3S<p1P> m_ComputerObjectProvider = new k3S<p1P>();

	private static readonly k3S<n7J> m_AppObjectProvider = new k3S<n7J>();

	private static readonly k3S<User> m_UserObjectProvider = new k3S<User>();

	private static k3S<Ls4> m_MyFormsObjectProvider = new k3S<Ls4>();

	private static readonly k3S<j8R> m_MyWebServicesObjectProvider = new k3S<j8R>();

	[HelpKeyword("My.Computer")]
	internal static p1P Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static n7J Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static Ls4 Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static j8R WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
