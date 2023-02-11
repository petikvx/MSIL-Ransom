using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ed6;
using Ek9;
using Hz6;
using Jb27;
using Ly6n;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Nb2;
using Nn0;
using Rd5b;
using Ww2i;
using Xp8;
using Zr3;
using a6F;
using g0B;
using i8FQ;
using j4FQ;
using m1G3;
using m2Q;
using q5QZ;
using r0C3;
using s6S;
using z9Q;

namespace p9K;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class Gj9
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Cf6
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fo8 m_Admin_Function;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public j5N m_Alert_Notification;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n6Z m_Apartment_Details;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ep4 m_Block_A;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xb0 m_Block_B;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z4Y m_Block_C;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tr9 m_Booking_Info;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w1D m_E_Bill_Info;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z6G m_Event_Hall;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qd2o m_first_page;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Be4z m_Flat_Rent;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mq9 m_Form1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zd85 m_House_Entry;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qr4m m_Pay_eletricity;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q7SH m_Problem_Report;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g2BD m_Rent_Info;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g9Z2 m_Tenant_Function;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public By10 m_Tenant_Login;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ar9f m_Tenant_Registration;

		private static c6S r8Z<c6S>(c6S t6G) where c6S : Form, new()
		{
			if (t6G == null || ((Control)t6G).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(c6S)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(c6S), null);
				try
				{
					return new c6S();
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
					m_FormBeingCreated.Remove(typeof(c6S));
				}
			}
			return t6G;
		}

		private void Cn8<r8P>(ref r8P Pc1) where r8P : Form
		{
			((Component)Pc1).Dispose();
			Pc1 = default(r8P);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cf6()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool a4J(object y6J)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(y6J));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Lt7()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Pb6()
		{
			return typeof(Cf6);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Fj7()
		{
			return base.ToString();
		}

		[SpecialName]
		public Fo8 Xp5()
		{
			m_Admin_Function = r8Z(m_Admin_Function);
			return m_Admin_Function;
		}

		[SpecialName]
		public j5N s2P()
		{
			m_Alert_Notification = r8Z(m_Alert_Notification);
			return m_Alert_Notification;
		}

		[SpecialName]
		public n6Z x8F()
		{
			m_Apartment_Details = r8Z(m_Apartment_Details);
			return m_Apartment_Details;
		}

		[SpecialName]
		public Ep4 Wk8()
		{
			m_Block_A = r8Z(m_Block_A);
			return m_Block_A;
		}

		[SpecialName]
		public Xb0 y4W()
		{
			m_Block_B = r8Z(m_Block_B);
			return m_Block_B;
		}

		[SpecialName]
		public z4Y Jt4()
		{
			m_Block_C = r8Z(m_Block_C);
			return m_Block_C;
		}

		[SpecialName]
		public Tr9 s3J()
		{
			m_Booking_Info = r8Z(m_Booking_Info);
			return m_Booking_Info;
		}

		[SpecialName]
		public w1D w6P()
		{
			m_E_Bill_Info = r8Z(m_E_Bill_Info);
			return m_E_Bill_Info;
		}

		[SpecialName]
		public z6G b0L()
		{
			m_Event_Hall = r8Z(m_Event_Hall);
			return m_Event_Hall;
		}

		[SpecialName]
		public Qd2o Es8()
		{
			m_first_page = r8Z(m_first_page);
			return m_first_page;
		}

		[SpecialName]
		public Be4z Jk7()
		{
			m_Flat_Rent = r8Z(m_Flat_Rent);
			return m_Flat_Rent;
		}

		[SpecialName]
		public Mq9 Ys4()
		{
			m_Form1 = r8Z(m_Form1);
			return m_Form1;
		}

		[SpecialName]
		public Zd85 Cx1()
		{
			m_House_Entry = r8Z(m_House_Entry);
			return m_House_Entry;
		}

		[SpecialName]
		public Qr4m Ad3()
		{
			m_Pay_eletricity = r8Z(m_Pay_eletricity);
			return m_Pay_eletricity;
		}

		[SpecialName]
		public q7SH Gy9()
		{
			m_Problem_Report = r8Z(m_Problem_Report);
			return m_Problem_Report;
		}

		[SpecialName]
		public g2BD t8C()
		{
			m_Rent_Info = r8Z(m_Rent_Info);
			return m_Rent_Info;
		}

		[SpecialName]
		public g9Z2 Hz4()
		{
			m_Tenant_Function = r8Z(m_Tenant_Function);
			return m_Tenant_Function;
		}

		[SpecialName]
		public By10 p1T()
		{
			m_Tenant_Login = r8Z(m_Tenant_Login);
			return m_Tenant_Login;
		}

		[SpecialName]
		public Ar9f k3M()
		{
			m_Tenant_Registration = r8Z(m_Tenant_Registration);
			return m_Tenant_Registration;
		}

		[SpecialName]
		public void Ds9(Fo8 Ld9)
		{
			if (Ld9 != m_Admin_Function)
			{
				if (Ld9 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Admin_Function);
			}
		}

		[SpecialName]
		public void f1S(j5N Fa9)
		{
			if (Fa9 != m_Alert_Notification)
			{
				if (Fa9 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Alert_Notification);
			}
		}

		[SpecialName]
		public void Zz5(n6Z Fc1)
		{
			if (Fc1 != m_Apartment_Details)
			{
				if (Fc1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Apartment_Details);
			}
		}

		[SpecialName]
		public void b3G(Ep4 w7Y)
		{
			if (w7Y != m_Block_A)
			{
				if (w7Y != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Block_A);
			}
		}

		[SpecialName]
		public void Ci1(Xb0 Jd6)
		{
			if (Jd6 != m_Block_B)
			{
				if (Jd6 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Block_B);
			}
		}

		[SpecialName]
		public void m6F(z4Y Re8)
		{
			if (Re8 != m_Block_C)
			{
				if (Re8 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Block_C);
			}
		}

		[SpecialName]
		public void w4P(Tr9 f6B)
		{
			if (f6B != m_Booking_Info)
			{
				if (f6B != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Booking_Info);
			}
		}

		[SpecialName]
		public void r5X(w1D e3S)
		{
			if (e3S != m_E_Bill_Info)
			{
				if (e3S != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_E_Bill_Info);
			}
		}

		[SpecialName]
		public void Fm8(z6G o6J)
		{
			if (o6J != m_Event_Hall)
			{
				if (o6J != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Event_Hall);
			}
		}

		[SpecialName]
		public void Gf2(Qd2o Lc6)
		{
			if (Lc6 != m_first_page)
			{
				if (Lc6 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_first_page);
			}
		}

		[SpecialName]
		public void At7(Be4z z0X)
		{
			if (z0X != m_Flat_Rent)
			{
				if (z0X != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Flat_Rent);
			}
		}

		[SpecialName]
		public void Zw4(Mq9 r9G)
		{
			if (r9G != m_Form1)
			{
				if (r9G != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Form1);
			}
		}

		[SpecialName]
		public void o9K(Zd85 k5K)
		{
			if (k5K != m_House_Entry)
			{
				if (k5K != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_House_Entry);
			}
		}

		[SpecialName]
		public void g6Y(Qr4m Dk2)
		{
			if (Dk2 != m_Pay_eletricity)
			{
				if (Dk2 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Pay_eletricity);
			}
		}

		[SpecialName]
		public void r1Z(q7SH Yf8)
		{
			if (Yf8 != m_Problem_Report)
			{
				if (Yf8 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Problem_Report);
			}
		}

		[SpecialName]
		public void Zc1(g2BD Nc5)
		{
			if (Nc5 != m_Rent_Info)
			{
				if (Nc5 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Rent_Info);
			}
		}

		[SpecialName]
		public void m0Q(g9Z2 j7L)
		{
			if (j7L != m_Tenant_Function)
			{
				if (j7L != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Tenant_Function);
			}
		}

		[SpecialName]
		public void c7R(By10 Jp0)
		{
			if (Jp0 != m_Tenant_Login)
			{
				if (Jp0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Tenant_Login);
			}
		}

		[SpecialName]
		public void j5F(Ar9f p2L)
		{
			if (p2L != m_Tenant_Registration)
			{
				if (p2L != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Cn8(ref m_Tenant_Registration);
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class o6D
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Dg7(object Sy5)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Sy5));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int j9F()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type f4B()
		{
			return typeof(o6D);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Zr5()
		{
			return base.ToString();
		}

		private static y5J Xb2<y5J>(y5J g1F) where y5J : new()
		{
			if (g1F == null)
			{
				return new y5J();
			}
			return g1F;
		}

		private void b6W<d1F>(ref d1F Rj4)
		{
			Rj4 = default(d1F);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o6D()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Rd1<Lb4> where Lb4 : new()
	{
		[ThreadStatic]
		private static Lb4 m_ThreadStaticValue;

		[SpecialName]
		internal Lb4 Ds3()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new Lb4();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Rd1()
		{
		}
	}

	private static readonly Rd1<Gi7> m_ComputerObjectProvider = new Rd1<Gi7>();

	private static readonly Rd1<Ew9> m_AppObjectProvider = new Rd1<Ew9>();

	private static readonly Rd1<User> m_UserObjectProvider = new Rd1<User>();

	private static Rd1<Cf6> m_MyFormsObjectProvider = new Rd1<Cf6>();

	private static readonly Rd1<o6D> m_MyWebServicesObjectProvider = new Rd1<o6D>();

	[HelpKeyword("My.Computer")]
	internal static Gi7 Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static Ew9 Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static Cf6 Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static o6D WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
