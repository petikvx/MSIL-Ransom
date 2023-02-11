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
using Fk3q;
using Hs7;
using Ls6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Px9;
using Wp8;
using Xa6;
using Yz6;
using Zs9t;
using b0SW;
using k7E6;
using y8G1;

namespace o0Z3;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Ez07
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class o9TK
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c3Y4 m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xi5 m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s0K m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o0LQ m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nb0 m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w6P m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Lg8 m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s0H m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Kq0x m_MenuForm;

		public c3Y4 BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = c1LF(m_BridgeAddForm);
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
					Di7p(ref m_BridgeAddForm);
				}
			}
		}

		public Xi5 BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = c1LF(m_BridgeEditForm);
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
					Di7p(ref m_BridgeEditForm);
				}
			}
		}

		public s0K BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = c1LF(m_BridgeHistoryForm);
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
					Di7p(ref m_BridgeHistoryForm);
				}
			}
		}

		public o0LQ BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = c1LF(m_BridgeManagementViewForm);
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
					Di7p(ref m_BridgeManagementViewForm);
				}
			}
		}

		public Nb0 BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = c1LF(m_BridgeNoteEditForm);
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
					Di7p(ref m_BridgeNoteEditForm);
				}
			}
		}

		public w6P BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = c1LF(m_BridgeNoteHistoryForm);
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
					Di7p(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public Lg8 ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = c1LF(m_ExcelImportForm);
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
					Di7p(ref m_ExcelImportForm);
				}
			}
		}

		public s0H InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = c1LF(m_InspectionHistoryForm);
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
					Di7p(ref m_InspectionHistoryForm);
				}
			}
		}

		public Kq0x MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = c1LF(m_MenuForm);
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
					Di7p(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static s2W4 c1LF<s2W4>(s2W4 Qf9x) where s2W4 : Form, new()
		{
			if (Qf9x == null || ((Control)Qf9x).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(s2W4)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(s2W4), null);
				try
				{
					return new s2W4();
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
					m_FormBeingCreated.Remove(typeof(s2W4));
				}
			}
			return Qf9x;
		}

		[DebuggerHidden]
		private void Di7p<Ze91>(ref Ze91 Mf9r) where Ze91 : Form
		{
			((Component)Mf9r).Dispose();
			Mf9r = default(Ze91);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public o9TK()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Ew0p(object Nd05)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Nd05));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int a5CK()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type p0H9()
		{
			return typeof(o9TK);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Nf4e()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class En6i
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool An01(object Ab15)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Ab15));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int s1RY()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Ff14()
		{
			return typeof(En6i);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Yw98()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Gi61 w9WF<Gi61>(Gi61 e5X6) where Gi61 : new()
		{
			if (e5X6 == null)
			{
				return new Gi61();
			}
			return e5X6;
		}

		[DebuggerHidden]
		private void Wp2c<Go4t>(ref Go4t b2ZH)
		{
			b2ZH = default(Go4t);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public En6i()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class q8Y1<f0R1> where f0R1 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static f0R1 m_ThreadStaticValue;

		internal f0R1 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new f0R1();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public q8Y1()
		{
		}
	}

	private static readonly q8Y1<Rx75> m_ComputerObjectProvider = new q8Y1<Rx75>();

	private static readonly q8Y1<w3R1> m_AppObjectProvider = new q8Y1<w3R1>();

	private static readonly q8Y1<User> m_UserObjectProvider = new q8Y1<User>();

	private static q8Y1<o9TK> m_MyFormsObjectProvider = new q8Y1<o9TK>();

	private static readonly q8Y1<En6i> m_MyWebServicesObjectProvider = new q8Y1<En6i>();

	[HelpKeyword("My.Computer")]
	internal static Rx75 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static w3R1 Application
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
	internal static o9TK Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static En6i WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
