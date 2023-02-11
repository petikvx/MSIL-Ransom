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
using Ks4;
using Lk4;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Pq2t;
using Rp8d;
using Sg32;
using Yp0k;
using Zi6;
using e5SA;
using g9Z1;
using j5Z0;
using n4R5;

namespace f9H1;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Cn9z
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class f9N7
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p5J9 m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nm08 m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Yz15 m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bt14 m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public p4FT m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fd15 m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qc5 m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t7Y m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xe4 m_MenuForm;

		public p5J9 BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = Ag1i(m_BridgeAddForm);
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
					Wb68(ref m_BridgeAddForm);
				}
			}
		}

		public Nm08 BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = Ag1i(m_BridgeEditForm);
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
					Wb68(ref m_BridgeEditForm);
				}
			}
		}

		public Yz15 BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = Ag1i(m_BridgeHistoryForm);
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
					Wb68(ref m_BridgeHistoryForm);
				}
			}
		}

		public Bt14 BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = Ag1i(m_BridgeManagementViewForm);
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
					Wb68(ref m_BridgeManagementViewForm);
				}
			}
		}

		public p4FT BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = Ag1i(m_BridgeNoteEditForm);
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
					Wb68(ref m_BridgeNoteEditForm);
				}
			}
		}

		public Fd15 BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = Ag1i(m_BridgeNoteHistoryForm);
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
					Wb68(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public Qc5 ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = Ag1i(m_ExcelImportForm);
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
					Wb68(ref m_ExcelImportForm);
				}
			}
		}

		public t7Y InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = Ag1i(m_InspectionHistoryForm);
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
					Wb68(ref m_InspectionHistoryForm);
				}
			}
		}

		public Xe4 MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = Ag1i(m_MenuForm);
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
					Wb68(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static Pm90 Ag1i<Pm90>(Pm90 Ja2g) where Pm90 : Form, new()
		{
			if (Ja2g == null || ((Control)Ja2g).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Pm90)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Pm90), null);
				try
				{
					return new Pm90();
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
					m_FormBeingCreated.Remove(typeof(Pm90));
				}
			}
			return Ja2g;
		}

		[DebuggerHidden]
		private void Wb68<n3DF>(ref n3DF Md0k) where n3DF : Form
		{
			((Component)Md0k).Dispose();
			Md0k = default(n3DF);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public f9N7()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Zt97(object y6MR)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(y6MR));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Ak35()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type o8H9()
		{
			return typeof(f9N7);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string i3QC()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Kr5a
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Qt91(object d3AX)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(d3AX));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Mt0w()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type b4M7()
		{
			return typeof(Kr5a);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Mx9f()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Tp4y n6RT<Tp4y>(Tp4y Jz79) where Tp4y : new()
		{
			if (Jz79 == null)
			{
				return new Tp4y();
			}
			return Jz79;
		}

		[DebuggerHidden]
		private void Jz6n<Xm65>(ref Xm65 Ti29)
		{
			Ti29 = default(Xm65);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kr5a()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class c8HK<c9CM> where c9CM : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static c9CM m_ThreadStaticValue;

		internal c9CM GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new c9CM();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public c8HK()
		{
		}
	}

	private static readonly c8HK<z7QL> m_ComputerObjectProvider = new c8HK<z7QL>();

	private static readonly c8HK<Gz76> m_AppObjectProvider = new c8HK<Gz76>();

	private static readonly c8HK<User> m_UserObjectProvider = new c8HK<User>();

	private static c8HK<f9N7> m_MyFormsObjectProvider = new c8HK<f9N7>();

	private static readonly c8HK<Kr5a> m_MyWebServicesObjectProvider = new c8HK<Kr5a>();

	[HelpKeyword("My.Computer")]
	internal static z7QL Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Gz76 Application
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
	internal static f9N7 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Kr5a WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
