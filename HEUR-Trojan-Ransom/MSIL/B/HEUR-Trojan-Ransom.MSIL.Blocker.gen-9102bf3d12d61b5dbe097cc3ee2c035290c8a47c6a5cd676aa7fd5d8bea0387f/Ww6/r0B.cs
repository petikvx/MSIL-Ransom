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
using As6;
using Cs3w;
using Ea3;
using Fj5q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Pn96;
using Xi58;
using g8H4;
using o0H6;
using q1N9;
using q9B0;
using t5C6;

namespace Ww6;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class r0B
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class p7H
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Xw6p m_BridgeAddForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q3F4 m_BridgeEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t2ZE m_BridgeHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ht08 m_BridgeManagementViewForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t5A3 m_BridgeNoteEditForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k9EH m_BridgeNoteHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s4QA m_ExcelImportForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cd60 m_InspectionHistoryForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ag76 m_MenuForm;

		public Xw6p BridgeAddForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeAddForm = p5E(m_BridgeAddForm);
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
					b4K(ref m_BridgeAddForm);
				}
			}
		}

		public q3F4 BridgeEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeEditForm = p5E(m_BridgeEditForm);
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
					b4K(ref m_BridgeEditForm);
				}
			}
		}

		public t2ZE BridgeHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeHistoryForm = p5E(m_BridgeHistoryForm);
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
					b4K(ref m_BridgeHistoryForm);
				}
			}
		}

		public Ht08 BridgeManagementViewForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeManagementViewForm = p5E(m_BridgeManagementViewForm);
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
					b4K(ref m_BridgeManagementViewForm);
				}
			}
		}

		public t5A3 BridgeNoteEditForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteEditForm = p5E(m_BridgeNoteEditForm);
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
					b4K(ref m_BridgeNoteEditForm);
				}
			}
		}

		public k9EH BridgeNoteHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_BridgeNoteHistoryForm = p5E(m_BridgeNoteHistoryForm);
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
					b4K(ref m_BridgeNoteHistoryForm);
				}
			}
		}

		public s4QA ExcelImportForm
		{
			[DebuggerHidden]
			get
			{
				m_ExcelImportForm = p5E(m_ExcelImportForm);
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
					b4K(ref m_ExcelImportForm);
				}
			}
		}

		public Cd60 InspectionHistoryForm
		{
			[DebuggerHidden]
			get
			{
				m_InspectionHistoryForm = p5E(m_InspectionHistoryForm);
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
					b4K(ref m_InspectionHistoryForm);
				}
			}
		}

		public Ag76 MenuForm
		{
			[DebuggerHidden]
			get
			{
				m_MenuForm = p5E(m_MenuForm);
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
					b4K(ref m_MenuForm);
				}
			}
		}

		[DebuggerHidden]
		private static a4D p5E<a4D>(a4D w2N) where a4D : Form, new()
		{
			if (w2N == null || ((Control)w2N).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(a4D)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(a4D), null);
				try
				{
					return new a4D();
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
					m_FormBeingCreated.Remove(typeof(a4D));
				}
			}
			return w2N;
		}

		[DebuggerHidden]
		private void b4K<c7K>(ref c7K Nz4) where c7K : Form
		{
			((Component)Nz4).Dispose();
			Nz4 = default(c7K);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public p7H()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool m9A(object Sg3)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Sg3));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int k0W()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type f2R()
		{
			return typeof(p7H);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string f2B()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Wo8
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool y7T(object j5Q)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(j5Q));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Hb4()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type c8Y()
		{
			return typeof(Wo8);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Gw4()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Ka7 Lr8<Ka7>(Ka7 k0L) where Ka7 : new()
		{
			if (k0L == null)
			{
				return new Ka7();
			}
			return k0L;
		}

		[DebuggerHidden]
		private void He6<k5N>(ref k5N Af2)
		{
			Af2 = default(k5N);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Wo8()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class p0M<Ae6> where Ae6 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static Ae6 m_ThreadStaticValue;

		internal Ae6 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Ae6();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public p0M()
		{
		}
	}

	private static readonly p0M<Bf0> m_ComputerObjectProvider = new p0M<Bf0>();

	private static readonly p0M<Bq8> m_AppObjectProvider = new p0M<Bq8>();

	private static readonly p0M<User> m_UserObjectProvider = new p0M<User>();

	private static p0M<p7H> m_MyFormsObjectProvider = new p0M<p7H>();

	private static readonly p0M<Wo8> m_MyWebServicesObjectProvider = new p0M<Wo8>();

	[HelpKeyword("My.Computer")]
	internal static Bf0 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Bq8 Application
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
	internal static p7H Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Wo8 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
