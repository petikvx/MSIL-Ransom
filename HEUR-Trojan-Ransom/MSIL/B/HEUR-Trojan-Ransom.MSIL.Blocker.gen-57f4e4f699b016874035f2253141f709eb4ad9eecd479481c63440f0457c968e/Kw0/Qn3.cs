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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Sc7;
using Yc2;
using Yc3;
using Zg4;
using Zy1k;
using b2C;
using k8E;
using n6K;
using s7Y8;
using x0H;
using z9KN;

namespace Kw0;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Qn3
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Hn0
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y0T3 m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gw25 m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qw87 m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ec0 m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dr8 m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o9M m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pa1 m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wf9 m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s7Y m_MenuForm;

		public y0T3 BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = Rp6(m_BridgeAddForm);
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
					Tm3(ref m_BridgeAddForm);
				}
			}
		}

		public Gw25 BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = Rp6(m_BridgeEditForm);
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
					Tm3(ref m_BridgeEditForm);
				}
			}
		}

		public Qw87 BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = Rp6(m_BridgeHistoryForm);
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
					Tm3(ref m_BridgeHistoryForm);
				}
			}
		}

		public Ec0 BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = Rp6(m_BridgeManagementViewForm);
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
					Tm3(ref m_BridgeManagementViewForm);
				}
			}
		}

		public Dr8 BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = Rp6(m_BridgeNoteEditForm);
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
					Tm3(ref m_BridgeNoteEditForm);
				}
			}
		}

		public o9M BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = Rp6(m_BridgeNoteHistoryForm);
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
					Tm3(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public Pa1 ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = Rp6(m_ExcelImportForm);
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
					Tm3(ref m_ExcelImportForm);
				}
			}
		}

		public Wf9 InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = Rp6(m_InspectionHistoryForm);
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
					Tm3(ref m_InspectionHistoryForm);
				}
			}
		}

		public s7Y MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = Rp6(m_MenuForm);
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
					Tm3(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static Zf5 Rp6<Zf5>(Zf5 e7W) where Zf5 : Form, new()
		{
			if (e7W == null || ((Control)e7W).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Zf5)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Zf5), null);
				try
				{
					return new Zf5();
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
					m_FormBeingCreated.Remove(typeof(Zf5));
				}
			}
			return e7W;
		}

		[DebuggerHidden]
		private void Tm3<d9X>(ref d9X Xq2) where d9X : Form
		{
			((Component)Xq2).Dispose();
			Xq2 = default(d9X);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Hn0()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Cq4(object i5L)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(i5L));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int d0S()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Dj5()
		{
			return typeof(Hn0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string g0Y()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Sw1
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool c3G(object Rr2)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Rr2));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Jj1()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type k2H()
		{
			return typeof(Sw1);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Tf6()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Ex6 r9Y<Ex6>(Ex6 p2G) where Ex6 : new()
		{
			if (p2G == null)
			{
				return new Ex6();
			}
			return p2G;
		}

		[DebuggerHidden]
		private void q5W<s5M>(ref s5M Nr4)
		{
			Nr4 = default(s5M);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sw1()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Em8<k6R> where k6R : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static k6R m_ThreadStaticValue;

		internal k6R GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new k6R();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Em8()
		{
		}
	}

	private static readonly Em8<w6A> m_ComputerObjectProvider = new Em8<w6A>();

	private static readonly Em8<Yg0> m_AppObjectProvider = new Em8<Yg0>();

	private static readonly Em8<User> m_UserObjectProvider = new Em8<User>();

	private static Em8<Hn0> m_MyFormsObjectProvider = new Em8<Hn0>();

	private static readonly Em8<Sw1> m_MyWebServicesObjectProvider = new Em8<Sw1>();

	[HelpKeyword("My.Computer")]
	internal static w6A Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Yg0 Application
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
	internal static Hn0 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Sw1 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
