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
using Bg6i;
using Bz98;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Mp73;
using Yc3;
using Za8;
using Zo4;
using Zx2m;
using k5E;
using n0DX;
using p5W;
using t8E;

namespace Tb38;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class m3S9
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class p7Y1
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hj32 m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d1Y8 m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ds5j m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Di7 m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t9G m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Az4 m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hx1 m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a9X m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o4H m_MenuForm;

		public Hj32 BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = Yk74(m_BridgeAddForm);
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
					Sy8r(ref m_BridgeAddForm);
				}
			}
		}

		public d1Y8 BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = Yk74(m_BridgeEditForm);
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
					Sy8r(ref m_BridgeEditForm);
				}
			}
		}

		public Ds5j BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = Yk74(m_BridgeHistoryForm);
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
					Sy8r(ref m_BridgeHistoryForm);
				}
			}
		}

		public Di7 BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = Yk74(m_BridgeManagementViewForm);
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
					Sy8r(ref m_BridgeManagementViewForm);
				}
			}
		}

		public t9G BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = Yk74(m_BridgeNoteEditForm);
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
					Sy8r(ref m_BridgeNoteEditForm);
				}
			}
		}

		public Az4 BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = Yk74(m_BridgeNoteHistoryForm);
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
					Sy8r(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public Hx1 ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = Yk74(m_ExcelImportForm);
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
					Sy8r(ref m_ExcelImportForm);
				}
			}
		}

		public a9X InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = Yk74(m_InspectionHistoryForm);
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
					Sy8r(ref m_InspectionHistoryForm);
				}
			}
		}

		public o4H MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = Yk74(m_MenuForm);
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
					Sy8r(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static De73 Yk74<De73>(De73 z4D2) where De73 : Form, new()
		{
			if (z4D2 == null || ((Control)z4D2).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(De73)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(De73), null);
				try
				{
					return new De73();
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
					m_FormBeingCreated.Remove(typeof(De73));
				}
			}
			return z4D2;
		}

		[DebuggerHidden]
		private void Sy8r<q9NF>(ref q9NF i3CB) where q9NF : Form
		{
			((Component)i3CB).Dispose();
			i3CB = default(q9NF);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public p7Y1()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool f3Y0(object Tg68)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Tg68));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int a9TJ()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Kc62()
		{
			return typeof(p7Y1);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Yn27()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Aq96
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Fj81(object Bs8y)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Bs8y));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int s0Q2()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type n8G6()
		{
			return typeof(Aq96);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Re5f()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static f7LF Ze64<f7LF>(f7LF Qw1o) where f7LF : new()
		{
			if (Qw1o == null)
			{
				return new f7LF();
			}
			return Qw1o;
		}

		[DebuggerHidden]
		private void Go2p<w6SC>(ref w6SC Lq1t)
		{
			Lq1t = default(w6SC);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Aq96()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class q4GH<w0F2> where w0F2 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static w0F2 m_ThreadStaticValue;

		internal w0F2 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new w0F2();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public q4GH()
		{
		}
	}

	private static readonly q4GH<a6W9> m_ComputerObjectProvider = new q4GH<a6W9>();

	private static readonly q4GH<Fr31> m_AppObjectProvider = new q4GH<Fr31>();

	private static readonly q4GH<User> m_UserObjectProvider = new q4GH<User>();

	private static q4GH<p7Y1> m_MyFormsObjectProvider = new q4GH<p7Y1>();

	private static readonly q4GH<Aq96> m_MyWebServicesObjectProvider = new q4GH<Aq96>();

	[HelpKeyword("My.Computer")]
	internal static a6W9 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Fr31 Application
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
	internal static p7Y1 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Aq96 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
