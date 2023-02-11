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
using Cs4;
using Em6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Nw8;
using Nw9;
using So01;
using Tb4;
using c7H;
using k8X;
using n6HP;
using p3C0;
using r2Y9;

namespace Ci9;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Lo7
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Hp0
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qr93 m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m4S0 m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Be0 m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e5R m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s0T m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dk0 m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pi3 m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qs5w m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s7H1 m_MenuForm;

		public Qr93 BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = m2K(m_BridgeAddForm);
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
					Cs9(ref m_BridgeAddForm);
				}
			}
		}

		public m4S0 BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = m2K(m_BridgeEditForm);
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
					Cs9(ref m_BridgeEditForm);
				}
			}
		}

		public Be0 BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = m2K(m_BridgeHistoryForm);
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
					Cs9(ref m_BridgeHistoryForm);
				}
			}
		}

		public e5R BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = m2K(m_BridgeManagementViewForm);
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
					Cs9(ref m_BridgeManagementViewForm);
				}
			}
		}

		public s0T BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = m2K(m_BridgeNoteEditForm);
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
					Cs9(ref m_BridgeNoteEditForm);
				}
			}
		}

		public Dk0 BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = m2K(m_BridgeNoteHistoryForm);
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
					Cs9(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public Pi3 ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = m2K(m_ExcelImportForm);
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
					Cs9(ref m_ExcelImportForm);
				}
			}
		}

		public Qs5w InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = m2K(m_InspectionHistoryForm);
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
					Cs9(ref m_InspectionHistoryForm);
				}
			}
		}

		public s7H1 MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = m2K(m_MenuForm);
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
					Cs9(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static a0C m2K<a0C>(a0C z3E) where a0C : Form, new()
		{
			if (z3E == null || ((Control)z3E).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(a0C)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(a0C), null);
				try
				{
					return new a0C();
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
					m_FormBeingCreated.Remove(typeof(a0C));
				}
			}
			return z3E;
		}

		[DebuggerHidden]
		private void Cs9<f4P>(ref f4P z7M) where f4P : Form
		{
			((Component)z7M).Dispose();
			z7M = default(f4P);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Hp0()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool t1H(object Rn7)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Rn7));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int e3P()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Jb8()
		{
			return typeof(Hp0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string k4Z()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Sn2j
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Fw7q(object s9LT)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(s9LT));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int p1S4()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type n9WG()
		{
			return typeof(Sn2j);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Ej80()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static x2PY Cc1g<x2PY>(x2PY Xt26) where x2PY : new()
		{
			if (Xt26 == null)
			{
				return new x2PY();
			}
			return Xt26;
		}

		[DebuggerHidden]
		private void f7C3<s0P3>(ref s0P3 t9KM)
		{
			t9KM = default(s0P3);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sn2j()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class s4MG<m9W6> where m9W6 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static m9W6 m_ThreadStaticValue;

		internal m9W6 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new m9W6();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public s4MG()
		{
		}
	}

	private static readonly s4MG<Tf7> m_ComputerObjectProvider = new s4MG<Tf7>();

	private static readonly s4MG<Na7> m_AppObjectProvider = new s4MG<Na7>();

	private static readonly s4MG<User> m_UserObjectProvider = new s4MG<User>();

	private static s4MG<Hp0> m_MyFormsObjectProvider = new s4MG<Hp0>();

	private static readonly s4MG<Sn2j> m_MyWebServicesObjectProvider = new s4MG<Sn2j>();

	[HelpKeyword("My.Computer")]
	internal static Tf7 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Na7 Application
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
	internal static Hp0 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Sn2j WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
