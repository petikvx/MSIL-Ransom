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
using Kn0;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Mq7z;
using Rm1;
using Sp0;
using Tf5o;
using b4C;
using e7RM;
using k5DJ;
using r7T8;
using t6G;
using x2D;

namespace e7Y8;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Zt6j
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Zb39
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public r1Z9 m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s8H m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y6N m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xg5 m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Et45 m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d0AL m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ns0 m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public j4W m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b0K m_MenuForm;

		public r1Z9 BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = Sz6g(m_BridgeAddForm);
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
					Gt91(ref m_BridgeAddForm);
				}
			}
		}

		public s8H BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = Sz6g(m_BridgeEditForm);
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
					Gt91(ref m_BridgeEditForm);
				}
			}
		}

		public y6N BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = Sz6g(m_BridgeHistoryForm);
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
					Gt91(ref m_BridgeHistoryForm);
				}
			}
		}

		public Xg5 BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = Sz6g(m_BridgeManagementViewForm);
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
					Gt91(ref m_BridgeManagementViewForm);
				}
			}
		}

		public Et45 BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = Sz6g(m_BridgeNoteEditForm);
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
					Gt91(ref m_BridgeNoteEditForm);
				}
			}
		}

		public d0AL BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = Sz6g(m_BridgeNoteHistoryForm);
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
					Gt91(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public Ns0 ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = Sz6g(m_ExcelImportForm);
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
					Gt91(ref m_ExcelImportForm);
				}
			}
		}

		public j4W InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = Sz6g(m_InspectionHistoryForm);
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
					Gt91(ref m_InspectionHistoryForm);
				}
			}
		}

		public b0K MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = Sz6g(m_MenuForm);
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
					Gt91(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static z0J4 Sz6g<z0J4>(z0J4 Lp0q) where z0J4 : Form, new()
		{
			if (Lp0q == null || ((Control)Lp0q).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(z0J4)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(z0J4), null);
				try
				{
					return new z0J4();
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
					m_FormBeingCreated.Remove(typeof(z0J4));
				}
			}
			return Lp0q;
		}

		[DebuggerHidden]
		private void Gt91<Cs76>(ref Cs76 Xy17) where Cs76 : Form
		{
			((Component)Xy17).Dispose();
			Xy17 = default(Cs76);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Zb39()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool We74(object s6P7)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(s6P7));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int t0J8()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Jd36()
		{
			return typeof(Zb39);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string e1YH()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Pf09
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Cy16(object Jd31)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Jd31));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int p0JC()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type y7XD()
		{
			return typeof(Pf09);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string s7M9()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static j7T8 Ff79<j7T8>(j7T8 Rc4k) where j7T8 : new()
		{
			if (Rc4k == null)
			{
				return new j7T8();
			}
			return Rc4k;
		}

		[DebuggerHidden]
		private void St5z<Nk28>(ref Nk28 Qs1j)
		{
			Qs1j = default(Nk28);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pf09()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class t5J9<Fp7j> where Fp7j : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static Fp7j m_ThreadStaticValue;

		internal Fp7j GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Fp7j();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public t5J9()
		{
		}
	}

	private static readonly t5J9<Qd5c> m_ComputerObjectProvider = new t5J9<Qd5c>();

	private static readonly t5J9<b8B0> m_AppObjectProvider = new t5J9<b8B0>();

	private static readonly t5J9<User> m_UserObjectProvider = new t5J9<User>();

	private static t5J9<Zb39> m_MyFormsObjectProvider = new t5J9<Zb39>();

	private static readonly t5J9<Pf09> m_MyWebServicesObjectProvider = new t5J9<Pf09>();

	[HelpKeyword("My.Computer")]
	internal static Qd5c Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static b8B0 Application
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
	internal static Zb39 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Pf09 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
