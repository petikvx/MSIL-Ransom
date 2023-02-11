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
using Ae53;
using Af2;
using Ex5;
using Kj7;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Qz43;
using Yc8;
using Zk30;
using f1NR;
using j3E;
using p3HB;
using t4N;

namespace Gw0f;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Kd0j
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class e9G0
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g3FY m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p1YK m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public i2HW m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y2F m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Si6 m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gz4 m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Az5 m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pe6 m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public i1T m_MenuForm;

		public g3FY BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = Yp25(m_BridgeAddForm);
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
					Em7f(ref m_BridgeAddForm);
				}
			}
		}

		public p1YK BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = Yp25(m_BridgeEditForm);
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
					Em7f(ref m_BridgeEditForm);
				}
			}
		}

		public i2HW BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = Yp25(m_BridgeHistoryForm);
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
					Em7f(ref m_BridgeHistoryForm);
				}
			}
		}

		public y2F BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = Yp25(m_BridgeManagementViewForm);
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
					Em7f(ref m_BridgeManagementViewForm);
				}
			}
		}

		public Si6 BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = Yp25(m_BridgeNoteEditForm);
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
					Em7f(ref m_BridgeNoteEditForm);
				}
			}
		}

		public Gz4 BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = Yp25(m_BridgeNoteHistoryForm);
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
					Em7f(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public Az5 ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = Yp25(m_ExcelImportForm);
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
					Em7f(ref m_ExcelImportForm);
				}
			}
		}

		public Pe6 InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = Yp25(m_InspectionHistoryForm);
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
					Em7f(ref m_InspectionHistoryForm);
				}
			}
		}

		public i1T MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = Yp25(m_MenuForm);
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
					Em7f(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static p1AP Yp25<p1AP>(p1AP Li0j) where p1AP : Form, new()
		{
			if (Li0j == null || ((Control)Li0j).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(p1AP)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(p1AP), null);
				try
				{
					return new p1AP();
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
					m_FormBeingCreated.Remove(typeof(p1AP));
				}
			}
			return Li0j;
		}

		[DebuggerHidden]
		private void Em7f<a1GQ>(ref a1GQ b6KW) where a1GQ : Form
		{
			((Component)b6KW).Dispose();
			b6KW = default(a1GQ);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public e9G0()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Re94(object Jn47)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Jn47));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int q7R4()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type e4MD()
		{
			return typeof(e9G0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string n7ZQ()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class r1W8
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool i3P1(object Gs56)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Gs56));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int f0F8()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type w0C6()
		{
			return typeof(r1W8);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string z1GS()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static z0F4 Ey2n<z0F4>(z0F4 c6MA) where z0F4 : new()
		{
			if (c6MA == null)
			{
				return new z0F4();
			}
			return c6MA;
		}

		[DebuggerHidden]
		private void s8AS<Tz5d>(ref Tz5d e6Y9)
		{
			e6Y9 = default(Tz5d);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public r1W8()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Lc6x<Py4b> where Py4b : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static Py4b m_ThreadStaticValue;

		internal Py4b GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Py4b();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Lc6x()
		{
		}
	}

	private static readonly Lc6x<z1D0> m_ComputerObjectProvider = new Lc6x<z1D0>();

	private static readonly Lc6x<Ji81> m_AppObjectProvider = new Lc6x<Ji81>();

	private static readonly Lc6x<User> m_UserObjectProvider = new Lc6x<User>();

	private static Lc6x<e9G0> m_MyFormsObjectProvider = new Lc6x<e9G0>();

	private static readonly Lc6x<r1W8> m_MyWebServicesObjectProvider = new Lc6x<r1W8>();

	[HelpKeyword("My.Computer")]
	internal static z1D0 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Ji81 Application
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
	internal static e9G0 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static r1W8 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
