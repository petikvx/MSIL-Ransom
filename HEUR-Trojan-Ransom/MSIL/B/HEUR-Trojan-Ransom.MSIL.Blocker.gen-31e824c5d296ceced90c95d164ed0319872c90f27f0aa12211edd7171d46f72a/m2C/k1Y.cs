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
using Af71;
using Eg05;
using Gs72;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Sj57;
using Sx93;
using Wi62;
using Xi7;
using b5D;
using j5NC;
using m7QC;
using q8JE;

namespace m2C;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class k1Y
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Yz1
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public i1SB m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pq7j m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ga52 m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Aw4c m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pe51 m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x7NQ m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d3Z6 m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wr65 m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ts54 m_MenuForm;

		public i1SB BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = Qz2(m_BridgeAddForm);
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
					c2M(ref m_BridgeAddForm);
				}
			}
		}

		public Pq7j BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = Qz2(m_BridgeEditForm);
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
					c2M(ref m_BridgeEditForm);
				}
			}
		}

		public Ga52 BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = Qz2(m_BridgeHistoryForm);
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
					c2M(ref m_BridgeHistoryForm);
				}
			}
		}

		public Aw4c BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = Qz2(m_BridgeManagementViewForm);
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
					c2M(ref m_BridgeManagementViewForm);
				}
			}
		}

		public Pe51 BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = Qz2(m_BridgeNoteEditForm);
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
					c2M(ref m_BridgeNoteEditForm);
				}
			}
		}

		public x7NQ BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = Qz2(m_BridgeNoteHistoryForm);
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
					c2M(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public d3Z6 ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = Qz2(m_ExcelImportForm);
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
					c2M(ref m_ExcelImportForm);
				}
			}
		}

		public Wr65 InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = Qz2(m_InspectionHistoryForm);
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
					c2M(ref m_InspectionHistoryForm);
				}
			}
		}

		public Ts54 MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = Qz2(m_MenuForm);
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
					c2M(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static Xy2 Qz2<Xy2>(Xy2 k9D) where Xy2 : Form, new()
		{
			if (k9D == null || ((Control)k9D).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Xy2)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Xy2), null);
				try
				{
					return new Xy2();
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
					m_FormBeingCreated.Remove(typeof(Xy2));
				}
			}
			return k9D;
		}

		[DebuggerHidden]
		private void c2M<y4N>(ref y4N a2Z) where y4N : Form
		{
			((Component)a2Z).Dispose();
			a2Z = default(y4N);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Yz1()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool i3C(object p1Y)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(p1Y));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int k0W()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type z6P()
		{
			return typeof(Yz1);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string i4Y()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class i3Q
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool q1T(object Sc0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Sc0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int e3N()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Xz2()
		{
			return typeof(i3Q);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Sy3()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static g6Q n0W<g6Q>(g6Q m7A0) where g6Q : new()
		{
			if (m7A0 == null)
			{
				return new g6Q();
			}
			return m7A0;
		}

		[DebuggerHidden]
		private void z5A2<Xc7m>(ref Xc7m Cj32)
		{
			Cj32 = default(Xc7m);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public i3Q()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class i8S0<Pc7e> where Pc7e : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static Pc7e m_ThreadStaticValue;

		internal Pc7e GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Pc7e();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public i8S0()
		{
		}
	}

	private static readonly i8S0<p2X> m_ComputerObjectProvider = new i8S0<p2X>();

	private static readonly i8S0<b1M> m_AppObjectProvider = new i8S0<b1M>();

	private static readonly i8S0<User> m_UserObjectProvider = new i8S0<User>();

	private static i8S0<Yz1> m_MyFormsObjectProvider = new i8S0<Yz1>();

	private static readonly i8S0<i3Q> m_MyWebServicesObjectProvider = new i8S0<i3Q>();

	[HelpKeyword("My.Computer")]
	internal static p2X Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static b1M Application
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
	internal static Yz1 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static i3Q WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
