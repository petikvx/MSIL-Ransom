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
using Hx60;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Qj6z;
using Te19;
using Wi46;
using e7ZH;
using j0X6;
using j7QH;
using j7Z8;
using w1D;
using y3E7;
using z0S;

namespace Gs35;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class z1AW
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class d6B9
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mr5g m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ly59 m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e8P4 m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dk0i m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t0Y9 m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o1H0 m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e7BL m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nz3 m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c9W m_MenuForm;

		public Mr5g BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = f9F7(m_BridgeAddForm);
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
					f6CS(ref m_BridgeAddForm);
				}
			}
		}

		public Ly59 BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = f9F7(m_BridgeEditForm);
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
					f6CS(ref m_BridgeEditForm);
				}
			}
		}

		public e8P4 BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = f9F7(m_BridgeHistoryForm);
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
					f6CS(ref m_BridgeHistoryForm);
				}
			}
		}

		public Dk0i BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = f9F7(m_BridgeManagementViewForm);
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
					f6CS(ref m_BridgeManagementViewForm);
				}
			}
		}

		public t0Y9 BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = f9F7(m_BridgeNoteEditForm);
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
					f6CS(ref m_BridgeNoteEditForm);
				}
			}
		}

		public o1H0 BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = f9F7(m_BridgeNoteHistoryForm);
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
					f6CS(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public e7BL ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = f9F7(m_ExcelImportForm);
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
					f6CS(ref m_ExcelImportForm);
				}
			}
		}

		public Nz3 InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = f9F7(m_InspectionHistoryForm);
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
					f6CS(ref m_InspectionHistoryForm);
				}
			}
		}

		public c9W MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = f9F7(m_MenuForm);
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
					f6CS(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static c8P9 f9F7<c8P9>(c8P9 z3WH) where c8P9 : Form, new()
		{
			if (z3WH == null || ((Control)z3WH).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(c8P9)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(c8P9), null);
				try
				{
					return new c8P9();
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
					m_FormBeingCreated.Remove(typeof(c8P9));
				}
			}
			return z3WH;
		}

		[DebuggerHidden]
		private void f6CS<Qs1x>(ref Qs1x Lq3a) where Qs1x : Form
		{
			((Component)Lq3a).Dispose();
			Lq3a = default(Qs1x);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public d6B9()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Ag61(object d7W1)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(d7W1));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int f5A9()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Ew6a()
		{
			return typeof(d6B9);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Ez4j()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Fb48
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Ep8m(object t9D7)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(t9D7));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int k9JK()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type s0A8()
		{
			return typeof(Fb48);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string g8BC()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static j5YF b0R8<j5YF>(j5YF Mo86) where j5YF : new()
		{
			if (Mo86 == null)
			{
				return new j5YF();
			}
			return Mo86;
		}

		[DebuggerHidden]
		private void o4PG<Jb03>(ref Jb03 j3NY)
		{
			j3NY = default(Jb03);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fb48()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Gc96<Ki43> where Ki43 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static Ki43 m_ThreadStaticValue;

		internal Ki43 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Ki43();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Gc96()
		{
		}
	}

	private static readonly Gc96<Yx72> m_ComputerObjectProvider = new Gc96<Yx72>();

	private static readonly Gc96<b0PA> m_AppObjectProvider = new Gc96<b0PA>();

	private static readonly Gc96<User> m_UserObjectProvider = new Gc96<User>();

	private static Gc96<d6B9> m_MyFormsObjectProvider = new Gc96<d6B9>();

	private static readonly Gc96<Fb48> m_MyWebServicesObjectProvider = new Gc96<Fb48>();

	[HelpKeyword("My.Computer")]
	internal static Yx72 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static b0PA Application
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
	internal static d6B9 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Fb48 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
