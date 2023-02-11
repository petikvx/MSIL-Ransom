using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Aj3;
using Ji0;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Pb62;
using Qg8c;
using Rq8z;
using Tw5;
using Tz3;
using Wn24;
using Wx2;
using Yi7g;
using Yj2e;
using Zb1o;
using f8TP;
using g4S;
using i3QJ;
using j7F0;
using j8M;
using m6MF;
using q8MG;
using y4D7;
using y9R4;

namespace p0H8;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Ga6q
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Sy1c
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gd8 m_Admin_Function;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a6M m_Alert_Notification;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m1J m_Apartment_Details;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b4W m_Block_A;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c4P m_Block_B;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b0D m_Block_C;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cn4k m_Booking_Info;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nz6q m_E_Bill_Info;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d7G4 m_Event_Hall;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t3KL m_first_page;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o5N7 m_Flat_Rent;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s8Y m_Form1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hs6z m_House_Entry;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cn45 m_Pay_eletricity;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x5CY m_Problem_Report;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cx45 m_Rent_Info;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g8AE m_Tenant_Function;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qs08 m_Tenant_Login;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m5W6 m_Tenant_Registration;

		public Gd8 Admin_Function
		{
			[DebuggerHidden]
			get
			{
				m_Admin_Function = i0G2(m_Admin_Function);
				return m_Admin_Function;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Admin_Function)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Admin_Function);
				}
			}
		}

		public a6M Alert_Notification
		{
			[DebuggerHidden]
			get
			{
				m_Alert_Notification = i0G2(m_Alert_Notification);
				return m_Alert_Notification;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Alert_Notification)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Alert_Notification);
				}
			}
		}

		public m1J Apartment_Details
		{
			[DebuggerHidden]
			get
			{
				m_Apartment_Details = i0G2(m_Apartment_Details);
				return m_Apartment_Details;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Apartment_Details)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Apartment_Details);
				}
			}
		}

		public b4W Block_A
		{
			[DebuggerHidden]
			get
			{
				m_Block_A = i0G2(m_Block_A);
				return m_Block_A;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Block_A)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Block_A);
				}
			}
		}

		public c4P Block_B
		{
			[DebuggerHidden]
			get
			{
				m_Block_B = i0G2(m_Block_B);
				return m_Block_B;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Block_B)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Block_B);
				}
			}
		}

		public b0D Block_C
		{
			[DebuggerHidden]
			get
			{
				m_Block_C = i0G2(m_Block_C);
				return m_Block_C;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Block_C)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Block_C);
				}
			}
		}

		public Cn4k Booking_Info
		{
			[DebuggerHidden]
			get
			{
				m_Booking_Info = i0G2(m_Booking_Info);
				return m_Booking_Info;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Booking_Info)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Booking_Info);
				}
			}
		}

		public Nz6q E_Bill_Info
		{
			[DebuggerHidden]
			get
			{
				m_E_Bill_Info = i0G2(m_E_Bill_Info);
				return m_E_Bill_Info;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_E_Bill_Info)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_E_Bill_Info);
				}
			}
		}

		public d7G4 Event_Hall
		{
			[DebuggerHidden]
			get
			{
				m_Event_Hall = i0G2(m_Event_Hall);
				return m_Event_Hall;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Event_Hall)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Event_Hall);
				}
			}
		}

		public t3KL first_page
		{
			[DebuggerHidden]
			get
			{
				m_first_page = i0G2(m_first_page);
				return m_first_page;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_first_page)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_first_page);
				}
			}
		}

		public o5N7 Flat_Rent
		{
			[DebuggerHidden]
			get
			{
				m_Flat_Rent = i0G2(m_Flat_Rent);
				return m_Flat_Rent;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Flat_Rent)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Flat_Rent);
				}
			}
		}

		public s8Y Form1
		{
			[DebuggerHidden]
			get
			{
				m_Form1 = i0G2(m_Form1);
				return m_Form1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Form1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Form1);
				}
			}
		}

		public Hs6z House_Entry
		{
			[DebuggerHidden]
			get
			{
				m_House_Entry = i0G2(m_House_Entry);
				return m_House_Entry;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_House_Entry)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_House_Entry);
				}
			}
		}

		public Cn45 Pay_eletricity
		{
			[DebuggerHidden]
			get
			{
				m_Pay_eletricity = i0G2(m_Pay_eletricity);
				return m_Pay_eletricity;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Pay_eletricity)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Pay_eletricity);
				}
			}
		}

		public x5CY Problem_Report
		{
			[DebuggerHidden]
			get
			{
				m_Problem_Report = i0G2(m_Problem_Report);
				return m_Problem_Report;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Problem_Report)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Problem_Report);
				}
			}
		}

		public Cx45 Rent_Info
		{
			[DebuggerHidden]
			get
			{
				m_Rent_Info = i0G2(m_Rent_Info);
				return m_Rent_Info;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Rent_Info)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Rent_Info);
				}
			}
		}

		public g8AE Tenant_Function
		{
			[DebuggerHidden]
			get
			{
				m_Tenant_Function = i0G2(m_Tenant_Function);
				return m_Tenant_Function;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Tenant_Function)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Tenant_Function);
				}
			}
		}

		public Qs08 Tenant_Login
		{
			[DebuggerHidden]
			get
			{
				m_Tenant_Login = i0G2(m_Tenant_Login);
				return m_Tenant_Login;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Tenant_Login)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Tenant_Login);
				}
			}
		}

		public m5W6 Tenant_Registration
		{
			[DebuggerHidden]
			get
			{
				m_Tenant_Registration = i0G2(m_Tenant_Registration);
				return m_Tenant_Registration;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Tenant_Registration)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Km4o(ref m_Tenant_Registration);
				}
			}
		}

		[DebuggerHidden]
		private static Bj89 i0G2<Bj89>(Bj89 Wd6i) where Bj89 : Form, new()
		{
			if (Wd6i == null || ((Control)Wd6i).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Bj89)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Bj89), null);
				try
				{
					return new Bj89();
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
					m_FormBeingCreated.Remove(typeof(Bj89));
				}
			}
			return Wd6i;
		}

		[DebuggerHidden]
		private void Km4o<Mj0n>(ref Mj0n Rt46) where Mj0n : Form
		{
			((Component)Rt46).Dispose();
			Rt46 = default(Mj0n);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sy1c()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Rm09(object Qg01)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Qg01));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int t8T9()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Kn47()
		{
			return typeof(Sy1c);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Pe29()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class c2DA
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool So9n(object m8TA)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(m8TA));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Mt15()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type Nz54()
		{
			return typeof(c2DA);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Gb5t()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static y9G7 j9FY<y9G7>(y9G7 Rf6e) where y9G7 : new()
		{
			if (Rf6e == null)
			{
				return new y9G7();
			}
			return Rf6e;
		}

		[DebuggerHidden]
		private void Ws39<i1FG>(ref i1FG y4YR)
		{
			y4YR = default(i1FG);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public c2DA()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Aw2p<q1WL> where q1WL : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static q1WL m_ThreadStaticValue;

		internal q1WL GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new q1WL();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Aw2p()
		{
		}
	}

	private static readonly Aw2p<Ko23> m_ComputerObjectProvider = new Aw2p<Ko23>();

	private static readonly Aw2p<Xc9s> m_AppObjectProvider = new Aw2p<Xc9s>();

	private static readonly Aw2p<User> m_UserObjectProvider = new Aw2p<User>();

	private static Aw2p<Sy1c> m_MyFormsObjectProvider = new Aw2p<Sy1c>();

	private static readonly Aw2p<c2DA> m_MyWebServicesObjectProvider = new Aw2p<c2DA>();

	[HelpKeyword("My.Computer")]
	internal static Ko23 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Xc9s Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Sy1c Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static c2DA WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
