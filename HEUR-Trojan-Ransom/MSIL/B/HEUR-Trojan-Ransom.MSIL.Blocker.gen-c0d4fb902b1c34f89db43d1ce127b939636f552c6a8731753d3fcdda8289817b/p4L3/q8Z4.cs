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
using Da8s;
using Dp6;
using Fo17;
using Fw0s;
using Gs8g;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using e1NJ;
using e6M2;
using g0L3;
using o8S6;
using q7Y6;
using s4JR;

namespace p4L3;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class q8Z4
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class g0CS
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jj7p m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kt45 m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sb0 m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y2T5 m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ps65 m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ts6t m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m0XJ m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public r8HM m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public As63 m_MenuForm;

		public Jj7p BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = j2H5(m_BridgeAddForm);
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
					Bs8g(ref m_BridgeAddForm);
				}
			}
		}

		public Kt45 BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = j2H5(m_BridgeEditForm);
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
					Bs8g(ref m_BridgeEditForm);
				}
			}
		}

		public Sb0 BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = j2H5(m_BridgeHistoryForm);
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
					Bs8g(ref m_BridgeHistoryForm);
				}
			}
		}

		public y2T5 BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = j2H5(m_BridgeManagementViewForm);
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
					Bs8g(ref m_BridgeManagementViewForm);
				}
			}
		}

		public Ps65 BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = j2H5(m_BridgeNoteEditForm);
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
					Bs8g(ref m_BridgeNoteEditForm);
				}
			}
		}

		public Ts6t BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = j2H5(m_BridgeNoteHistoryForm);
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
					Bs8g(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public m0XJ ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = j2H5(m_ExcelImportForm);
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
					Bs8g(ref m_ExcelImportForm);
				}
			}
		}

		public r8HM InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = j2H5(m_InspectionHistoryForm);
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
					Bs8g(ref m_InspectionHistoryForm);
				}
			}
		}

		public As63 MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = j2H5(m_MenuForm);
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
					Bs8g(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static Rq5g j2H5<Rq5g>(Rq5g Ko35) where Rq5g : Form, new()
		{
			if (Ko35 == null || ((Control)Ko35).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Rq5g)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Rq5g), null);
				try
				{
					return new Rq5g();
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
					m_FormBeingCreated.Remove(typeof(Rq5g));
				}
			}
			return Ko35;
		}

		[DebuggerHidden]
		private void Bs8g<t2X7>(ref t2X7 Ey45) where t2X7 : Form
		{
			((Component)Ey45).Dispose();
			Ey45 = default(t2X7);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public g0CS()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Kz7j(object d7NS)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(d7NS));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int w5RT()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type y4RW()
		{
			return typeof(g0CS);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string t8L1()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Sg9a
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Wn0f(object e2LD)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(e2LD));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int z7PJ()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Pb9d()
		{
			return typeof(Sg9a);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Ky37()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Kk7o q8QZ<Kk7o>(Kk7o Ft7r) where Kk7o : new()
		{
			if (Ft7r == null)
			{
				return new Kk7o();
			}
			return Ft7r;
		}

		[DebuggerHidden]
		private void x6H0<Zi2j>(ref Zi2j Wz57)
		{
			Wz57 = default(Zi2j);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sg9a()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class g7YX<i2YK> where i2YK : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static i2YK m_ThreadStaticValue;

		internal i2YK GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new i2YK();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public g7YX()
		{
		}
	}

	private static readonly g7YX<x9NX> m_ComputerObjectProvider = new g7YX<x9NX>();

	private static readonly g7YX<o2A8> m_AppObjectProvider = new g7YX<o2A8>();

	private static readonly g7YX<User> m_UserObjectProvider = new g7YX<User>();

	private static g7YX<g0CS> m_MyFormsObjectProvider = new g7YX<g0CS>();

	private static readonly g7YX<Sg9a> m_MyWebServicesObjectProvider = new g7YX<Sg9a>();

	[HelpKeyword("My.Computer")]
	internal static x9NX Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static o2A8 Application
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
	internal static g0CS Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Sg9a WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
