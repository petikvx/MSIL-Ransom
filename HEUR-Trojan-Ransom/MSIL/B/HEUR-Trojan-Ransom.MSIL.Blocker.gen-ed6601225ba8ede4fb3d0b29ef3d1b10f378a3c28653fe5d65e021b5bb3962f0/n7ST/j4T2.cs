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
using Aa9;
using Cq82;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Wb1a;
using Xi6;
using Zf6q;
using c0K;
using i2TA;
using n8BG;
using r1MT;
using t0Z;
using y1D;

namespace n7ST;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class j4T2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Do7b
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n8EX m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tm9g m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public r7X1 m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f9FA m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tg2 m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Te3 m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z9E m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z0Y m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zn7 m_MenuForm;

		public n8EX BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = Xa30(m_BridgeAddForm);
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
					m7P4(ref m_BridgeAddForm);
				}
			}
		}

		public Tm9g BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = Xa30(m_BridgeEditForm);
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
					m7P4(ref m_BridgeEditForm);
				}
			}
		}

		public r7X1 BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = Xa30(m_BridgeHistoryForm);
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
					m7P4(ref m_BridgeHistoryForm);
				}
			}
		}

		public f9FA BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = Xa30(m_BridgeManagementViewForm);
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
					m7P4(ref m_BridgeManagementViewForm);
				}
			}
		}

		public Tg2 BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = Xa30(m_BridgeNoteEditForm);
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
					m7P4(ref m_BridgeNoteEditForm);
				}
			}
		}

		public Te3 BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = Xa30(m_BridgeNoteHistoryForm);
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
					m7P4(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public z9E ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = Xa30(m_ExcelImportForm);
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
					m7P4(ref m_ExcelImportForm);
				}
			}
		}

		public z0Y InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = Xa30(m_InspectionHistoryForm);
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
					m7P4(ref m_InspectionHistoryForm);
				}
			}
		}

		public Zn7 MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = Xa30(m_MenuForm);
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
					m7P4(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static Qo7m Xa30<Qo7m>(Qo7m w7R2) where Qo7m : Form, new()
		{
			if (w7R2 == null || ((Control)w7R2).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Qo7m)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Qo7m), null);
				try
				{
					return new Qo7m();
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
					m_FormBeingCreated.Remove(typeof(Qo7m));
				}
			}
			return w7R2;
		}

		[DebuggerHidden]
		private void m7P4<Gy3w>(ref Gy3w f0KT) where Gy3w : Form
		{
			((Component)f0KT).Dispose();
			f0KT = default(Gy3w);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Do7b()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool n6QD(object k9N8)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(k9N8));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int No56()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type t5B7()
		{
			return typeof(Do7b);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string k5J9()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class a6FM
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Mn1d(object d9M1)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(d9M1));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int m1K0()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Yn3y()
		{
			return typeof(a6FM);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string o4N1()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static p9D2 Bj6f<p9D2>(p9D2 o0QM) where p9D2 : new()
		{
			if (o0QM == null)
			{
				return new p9D2();
			}
			return o0QM;
		}

		[DebuggerHidden]
		private void Co42<a5C8>(ref a5C8 q3GF)
		{
			q3GF = default(a5C8);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public a6FM()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Ma28<Xi76> where Xi76 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static Xi76 m_ThreadStaticValue;

		internal Xi76 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Xi76();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Ma28()
		{
		}
	}

	private static readonly Ma28<Gy9c> m_ComputerObjectProvider = new Ma28<Gy9c>();

	private static readonly Ma28<Yy4k> m_AppObjectProvider = new Ma28<Yy4k>();

	private static readonly Ma28<User> m_UserObjectProvider = new Ma28<User>();

	private static Ma28<Do7b> m_MyFormsObjectProvider = new Ma28<Do7b>();

	private static readonly Ma28<a6FM> m_MyWebServicesObjectProvider = new Ma28<a6FM>();

	[HelpKeyword("My.Computer")]
	internal static Gy9c Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Yy4k Application
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
	internal static Do7b Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static a6FM WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
