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
using Af7;
using Am4;
using Fs0;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Ny9;
using Qt1;
using Rm67;
using Zo6w;
using a4M;
using c7JX;
using d0FH;
using o8B;

namespace My8;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class a3B
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class w5J
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p9F m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nn5 m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d5Q m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g4N m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f8X m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t7KN m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mk49 m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fm4i m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nq60 m_MenuForm;

		public p9F BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = Dd9(m_BridgeAddForm);
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
					o8B(ref m_BridgeAddForm);
				}
			}
		}

		public Nn5 BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = Dd9(m_BridgeEditForm);
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
					o8B(ref m_BridgeEditForm);
				}
			}
		}

		public d5Q BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = Dd9(m_BridgeHistoryForm);
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
					o8B(ref m_BridgeHistoryForm);
				}
			}
		}

		public g4N BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = Dd9(m_BridgeManagementViewForm);
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
					o8B(ref m_BridgeManagementViewForm);
				}
			}
		}

		public f8X BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = Dd9(m_BridgeNoteEditForm);
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
					o8B(ref m_BridgeNoteEditForm);
				}
			}
		}

		public t7KN BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = Dd9(m_BridgeNoteHistoryForm);
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
					o8B(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public Mk49 ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = Dd9(m_ExcelImportForm);
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
					o8B(ref m_ExcelImportForm);
				}
			}
		}

		public Fm4i InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = Dd9(m_InspectionHistoryForm);
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
					o8B(ref m_InspectionHistoryForm);
				}
			}
		}

		public Nq60 MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = Dd9(m_MenuForm);
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
					o8B(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static t3W Dd9<t3W>(t3W b5Z) where t3W : Form, new()
		{
			if (b5Z == null || ((Control)b5Z).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(t3W)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(t3W), null);
				try
				{
					return new t3W();
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
					m_FormBeingCreated.Remove(typeof(t3W));
				}
			}
			return b5Z;
		}

		[DebuggerHidden]
		private void o8B<Pw3>(ref Pw3 f4Z) where Pw3 : Form
		{
			((Component)f4Z).Dispose();
			f4Z = default(Pw3);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public w5J()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Gf4(object Tx2)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Tx2));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int r0K()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type w9M()
		{
			return typeof(w5J);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string i5A()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class g7G
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Py3(object c7C)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(c7C));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int x6F()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type Rp5()
		{
			return typeof(g7G);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string g5Q()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static y7Z m9R<y7Z>(y7Z Nr5) where y7Z : new()
		{
			if (Nr5 == null)
			{
				return new y7Z();
			}
			return Nr5;
		}

		[DebuggerHidden]
		private void Li8<q2G>(ref q2G y7C)
		{
			y7C = default(q2G);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public g7G()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Wf4<p3R> where p3R : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static p3R m_ThreadStaticValue;

		internal p3R GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new p3R();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wf4()
		{
		}
	}

	private static readonly Wf4<Xb8> m_ComputerObjectProvider = new Wf4<Xb8>();

	private static readonly Wf4<s3T> m_AppObjectProvider = new Wf4<s3T>();

	private static readonly Wf4<User> m_UserObjectProvider = new Wf4<User>();

	private static Wf4<w5J> m_MyFormsObjectProvider = new Wf4<w5J>();

	private static readonly Wf4<g7G> m_MyWebServicesObjectProvider = new Wf4<g7G>();

	[HelpKeyword("My.Computer")]
	internal static Xb8 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.get_GetInstance();
		}
	}

	[HelpKeyword("My.Application")]
	internal static s3T Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.get_GetInstance();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.get_GetInstance();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static w5J Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.get_GetInstance();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static g7G WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.get_GetInstance();
		}
	}
}
