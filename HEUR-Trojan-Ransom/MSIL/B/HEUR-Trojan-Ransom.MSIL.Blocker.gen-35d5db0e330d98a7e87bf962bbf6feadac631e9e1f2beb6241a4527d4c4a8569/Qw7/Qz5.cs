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
using Br4x;
using Gp1;
using Hz54;
using Ke1x;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Xx8;
using e1M;
using g3QS;
using i1Q;
using n2WG;
using q3A;
using q7S;

namespace Qw7;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Qz5
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Ed3
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ds8 m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nd7 m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n2C m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public j3N m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tf3q m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fy03 m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qp4o m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w5FB m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gd27 m_MenuForm;

		public Ds8 BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = Jt3(m_BridgeAddForm);
				return m_BridgeAddForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_BridgeAddForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					y5J(ref m_BridgeAddForm);
				}
			}
		}

		public Nd7 BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = Jt3(m_BridgeEditForm);
				return m_BridgeEditForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_BridgeEditForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					y5J(ref m_BridgeEditForm);
				}
			}
		}

		public n2C BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = Jt3(m_BridgeHistoryForm);
				return m_BridgeHistoryForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_BridgeHistoryForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					y5J(ref m_BridgeHistoryForm);
				}
			}
		}

		public j3N BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = Jt3(m_BridgeManagementViewForm);
				return m_BridgeManagementViewForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_BridgeManagementViewForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					y5J(ref m_BridgeManagementViewForm);
				}
			}
		}

		public Tf3q BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = Jt3(m_BridgeNoteEditForm);
				return m_BridgeNoteEditForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_BridgeNoteEditForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					y5J(ref m_BridgeNoteEditForm);
				}
			}
		}

		public Fy03 BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = Jt3(m_BridgeNoteHistoryForm);
				return m_BridgeNoteHistoryForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_BridgeNoteHistoryForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					y5J(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public Qp4o ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = Jt3(m_ExcelImportForm);
				return m_ExcelImportForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ExcelImportForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					y5J(ref m_ExcelImportForm);
				}
			}
		}

		public w5FB InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = Jt3(m_InspectionHistoryForm);
				return m_InspectionHistoryForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_InspectionHistoryForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					y5J(ref m_InspectionHistoryForm);
				}
			}
		}

		public Gd27 MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = Jt3(m_MenuForm);
				return m_MenuForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_MenuForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					y5J(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static Kc7 Jt3<Kc7>(Kc7 n6P) where Kc7 : Form, new()
		{
			if (n6P == null || ((Control)n6P).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Kc7)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Kc7), null);
				try
				{
					return new Kc7();
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
					m_FormBeingCreated.Remove(typeof(Kc7));
				}
			}
			return n6P;
		}

		[DebuggerHidden]
		private void y5J<t6J>(ref t6J p2W) where t6J : Form
		{
			((Component)p2W).Dispose();
			p2W = default(t6J);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Ed3()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool x2S(object s3G)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(s3G));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Bo6()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type w7G()
		{
			return typeof(Ed3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string k7M()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class q7C
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool f2G(object b3Y)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(b3Y));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Tw2()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Mn1()
		{
			return typeof(q7C);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string t3A()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Lj1 Le9<Lj1>(Lj1 b9G) where Lj1 : new()
		{
			if (b9G == null)
			{
				return new Lj1();
			}
			return b9G;
		}

		[DebuggerHidden]
		private void b3G<d1A>(ref d1A Ng7)
		{
			Ng7 = default(d1A);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public q7C()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class c2Y<k9D> where k9D : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static k9D m_ThreadStaticValue;

		internal k9D GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new k9D();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public c2Y()
		{
		}
	}

	private static readonly c2Y<i2Q> m_ComputerObjectProvider = new c2Y<i2Q>();

	private static readonly c2Y<g7M> m_AppObjectProvider = new c2Y<g7M>();

	private static readonly c2Y<User> m_UserObjectProvider = new c2Y<User>();

	private static c2Y<Ed3> m_MyFormsObjectProvider = new c2Y<Ed3>();

	private static readonly c2Y<q7C> m_MyWebServicesObjectProvider = new c2Y<q7C>();

	[HelpKeyword("My.Computer")]
	internal static i2Q Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static g7M Application
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
	internal static Ed3 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static q7C WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
