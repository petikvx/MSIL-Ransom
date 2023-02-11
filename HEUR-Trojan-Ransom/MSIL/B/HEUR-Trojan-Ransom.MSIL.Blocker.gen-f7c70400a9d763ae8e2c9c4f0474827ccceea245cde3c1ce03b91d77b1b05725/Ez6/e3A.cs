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
using Kt39;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Nb4y;
using Wm4;
using Xk61;
using Xp6;
using c4H;
using f6C;
using i1S;
using t7T2;
using x3L4;
using z4D;

namespace Ez6;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class e3A
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Px0
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ff7 m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b7S m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gz5 m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z0QK m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xk3c m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a7PS m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x3C m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k0L7 m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m9R4 m_MenuForm;

		public Ff7 BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = i7R(m_BridgeAddForm);
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
					c4R(ref m_BridgeAddForm);
				}
			}
		}

		public b7S BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = i7R(m_BridgeEditForm);
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
					c4R(ref m_BridgeEditForm);
				}
			}
		}

		public Gz5 BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = i7R(m_BridgeHistoryForm);
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
					c4R(ref m_BridgeHistoryForm);
				}
			}
		}

		public z0QK BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = i7R(m_BridgeManagementViewForm);
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
					c4R(ref m_BridgeManagementViewForm);
				}
			}
		}

		public Xk3c BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = i7R(m_BridgeNoteEditForm);
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
					c4R(ref m_BridgeNoteEditForm);
				}
			}
		}

		public a7PS BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = i7R(m_BridgeNoteHistoryForm);
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
					c4R(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public x3C ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = i7R(m_ExcelImportForm);
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
					c4R(ref m_ExcelImportForm);
				}
			}
		}

		public k0L7 InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = i7R(m_InspectionHistoryForm);
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
					c4R(ref m_InspectionHistoryForm);
				}
			}
		}

		public m9R4 MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = i7R(m_MenuForm);
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
					c4R(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static Dk4 i7R<Dk4>(Dk4 Pq5) where Dk4 : Form, new()
		{
			if (Pq5 == null || ((Control)Pq5).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Dk4)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Dk4), null);
				try
				{
					return new Dk4();
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
					m_FormBeingCreated.Remove(typeof(Dk4));
				}
			}
			return Pq5;
		}

		[DebuggerHidden]
		private void c4R<Yf1>(ref Yf1 t3Y) where Yf1 : Form
		{
			((Component)t3Y).Dispose();
			t3Y = default(Yf1);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Px0()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool k8A(object o3A)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o3A));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Np0()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type c5P()
		{
			return typeof(Px0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string a2P()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class z3Y
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool g3Z(object a5X)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(a5X));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int k3E()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Fa7()
		{
			return typeof(z3Y);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string j2Q()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Ga3 Si9<Ga3>(Ga3 f6M) where Ga3 : new()
		{
			if (f6M == null)
			{
				return new Ga3();
			}
			return f6M;
		}

		[DebuggerHidden]
		private void Mb4<n8S>(ref n8S Jk2)
		{
			Jk2 = default(n8S);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public z3Y()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class e6N<Pw8> where Pw8 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static Pw8 m_ThreadStaticValue;

		internal Pw8 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Pw8();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public e6N()
		{
		}
	}

	private static readonly e6N<Ry9> m_ComputerObjectProvider = new e6N<Ry9>();

	private static readonly e6N<Qd3> m_AppObjectProvider = new e6N<Qd3>();

	private static readonly e6N<User> m_UserObjectProvider = new e6N<User>();

	private static e6N<Px0> m_MyFormsObjectProvider = new e6N<Px0>();

	private static readonly e6N<z3Y> m_MyWebServicesObjectProvider = new e6N<z3Y>();

	[HelpKeyword("My.Computer")]
	internal static Ry9 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Qd3 Application
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
	internal static Px0 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static z3Y WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
