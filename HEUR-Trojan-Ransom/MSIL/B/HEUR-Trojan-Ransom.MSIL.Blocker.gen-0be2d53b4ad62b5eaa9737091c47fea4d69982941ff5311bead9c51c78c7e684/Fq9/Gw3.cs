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
using Ab73;
using Er8;
using Fg7d;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Wg4;
using e4M;
using f9K0;
using g5Z;
using j8A;
using s7KW;
using x1D;
using z3E;

namespace Fq9;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Gw3
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Rg5
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public No5 m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xy0 m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pt8 m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public j5K6 m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k0FG m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public i7CZ m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qi68 m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z3E.Tn6 m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k0K m_MenuForm;

		public No5 BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = Sa2(m_BridgeAddForm);
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
					Ag5(ref m_BridgeAddForm);
				}
			}
		}

		public Xy0 BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = Sa2(m_BridgeEditForm);
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
					Ag5(ref m_BridgeEditForm);
				}
			}
		}

		public Pt8 BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = Sa2(m_BridgeHistoryForm);
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
					Ag5(ref m_BridgeHistoryForm);
				}
			}
		}

		public j5K6 BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = Sa2(m_BridgeManagementViewForm);
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
					Ag5(ref m_BridgeManagementViewForm);
				}
			}
		}

		public k0FG BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = Sa2(m_BridgeNoteEditForm);
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
					Ag5(ref m_BridgeNoteEditForm);
				}
			}
		}

		public i7CZ BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = Sa2(m_BridgeNoteHistoryForm);
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
					Ag5(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public Qi68 ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = Sa2(m_ExcelImportForm);
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
					Ag5(ref m_ExcelImportForm);
				}
			}
		}

		public z3E.Tn6 InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = Sa2(m_InspectionHistoryForm);
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
					Ag5(ref m_InspectionHistoryForm);
				}
			}
		}

		public k0K MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = Sa2(m_MenuForm);
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
					Ag5(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static z2X Sa2<z2X>(z2X Mt1) where z2X : Form, new()
		{
			if (Mt1 == null || ((Control)Mt1).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(z2X)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(z2X), null);
				try
				{
					return new z2X();
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
					m_FormBeingCreated.Remove(typeof(z2X));
				}
			}
			return Mt1;
		}

		[DebuggerHidden]
		private void Ag5<f0C>(ref f0C Po1) where f0C : Form
		{
			((Component)Po1).Dispose();
			Po1 = default(f0C);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Rg5()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Jq0(object Ps3)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Ps3));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Gw5()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Mj3()
		{
			return typeof(Rg5);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string t1Z()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Fg5
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Ce3(object Kn9)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Kn9));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int a1D()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type d1G()
		{
			return typeof(Fg5);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Xj3()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Ab1 Qd7<Ab1>(Ab1 r2G) where Ab1 : new()
		{
			if (r2G == null)
			{
				return new Ab1();
			}
			return r2G;
		}

		[DebuggerHidden]
		private void Pf7<Sk0>(ref Sk0 e7Y)
		{
			e7Y = default(Sk0);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fg5()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Wo1<Hm1> where Hm1 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static Hm1 m_ThreadStaticValue;

		internal Hm1 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Hm1();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Wo1()
		{
		}
	}

	private static readonly Wo1<Td5> m_ComputerObjectProvider = new Wo1<Td5>();

	private static readonly Wo1<j8A.Tn6> m_AppObjectProvider = new Wo1<j8A.Tn6>();

	private static readonly Wo1<User> m_UserObjectProvider = new Wo1<User>();

	private static Wo1<Rg5> m_MyFormsObjectProvider = new Wo1<Rg5>();

	private static readonly Wo1<Fg5> m_MyWebServicesObjectProvider = new Wo1<Fg5>();

	[HelpKeyword("My.Computer")]
	internal static Td5 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static j8A.Tn6 Application
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
	internal static Rg5 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Fg5 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
