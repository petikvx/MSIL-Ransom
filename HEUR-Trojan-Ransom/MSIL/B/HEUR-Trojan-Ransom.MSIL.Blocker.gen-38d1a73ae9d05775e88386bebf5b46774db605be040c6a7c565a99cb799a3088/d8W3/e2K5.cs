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
using Ct5;
using Hk3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Tj57;
using b9K1;
using c7Q;
using e4HM;
using f3S;
using g4BZ;
using p3XA;
using w4W;
using x1H;

namespace d8W3;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class e2K5
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class n8P3
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x2F6 m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m0C5 m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zy9x m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wt2 m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public r5H m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bc0 m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Se5 m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mg9 m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s1A m_MenuForm;

		public x2F6 BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = r5QJ(m_BridgeAddForm);
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
					Zt4q(ref m_BridgeAddForm);
				}
			}
		}

		public m0C5 BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = r5QJ(m_BridgeEditForm);
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
					Zt4q(ref m_BridgeEditForm);
				}
			}
		}

		public Zy9x BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = r5QJ(m_BridgeHistoryForm);
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
					Zt4q(ref m_BridgeHistoryForm);
				}
			}
		}

		public Wt2 BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = r5QJ(m_BridgeManagementViewForm);
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
					Zt4q(ref m_BridgeManagementViewForm);
				}
			}
		}

		public r5H BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = r5QJ(m_BridgeNoteEditForm);
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
					Zt4q(ref m_BridgeNoteEditForm);
				}
			}
		}

		public Bc0 BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = r5QJ(m_BridgeNoteHistoryForm);
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
					Zt4q(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public Se5 ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = r5QJ(m_ExcelImportForm);
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
					Zt4q(ref m_ExcelImportForm);
				}
			}
		}

		public Mg9 InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = r5QJ(m_InspectionHistoryForm);
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
					Zt4q(ref m_InspectionHistoryForm);
				}
			}
		}

		public s1A MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = r5QJ(m_MenuForm);
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
					Zt4q(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static Wb9k r5QJ<Wb9k>(Wb9k i1Z2) where Wb9k : Form, new()
		{
			if (i1Z2 == null || ((Control)i1Z2).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Wb9k)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Wb9k), null);
				try
				{
					return new Wb9k();
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
					m_FormBeingCreated.Remove(typeof(Wb9k));
				}
			}
			return i1Z2;
		}

		[DebuggerHidden]
		private void Zt4q<Kw69>(ref Kw69 Kk6g) where Kw69 : Form
		{
			((Component)Kk6g).Dispose();
			Kk6g = default(Kw69);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public n8P3()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool n3C1(object t5YX)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(t5YX));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int i1H9()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type x9J7()
		{
			return typeof(n8P3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string o4R1()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class w8A9
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Ww02(object m2SP)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(m2SP));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Fi1b()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type c2TK()
		{
			return typeof(w8A9);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Ar6g()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Cj91 Gq48<Cj91>(Cj91 x2Z7) where Cj91 : new()
		{
			if (x2Z7 == null)
			{
				return new Cj91();
			}
			return x2Z7;
		}

		[DebuggerHidden]
		private void o4YM<Ko67>(ref Ko67 i4QY)
		{
			i4QY = default(Ko67);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public w8A9()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Hf39<Zk3y> where Zk3y : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static Zk3y m_ThreadStaticValue;

		internal Zk3y GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Zk3y();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Hf39()
		{
		}
	}

	private static readonly Hf39<Kf0y> m_ComputerObjectProvider = new Hf39<Kf0y>();

	private static readonly Hf39<q8WD> m_AppObjectProvider = new Hf39<q8WD>();

	private static readonly Hf39<User> m_UserObjectProvider = new Hf39<User>();

	private static Hf39<n8P3> m_MyFormsObjectProvider = new Hf39<n8P3>();

	private static readonly Hf39<w8A9> m_MyWebServicesObjectProvider = new Hf39<w8A9>();

	[HelpKeyword("My.Computer")]
	internal static Kf0y Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static q8WD Application
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
	internal static n8P3 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static w8A9 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
