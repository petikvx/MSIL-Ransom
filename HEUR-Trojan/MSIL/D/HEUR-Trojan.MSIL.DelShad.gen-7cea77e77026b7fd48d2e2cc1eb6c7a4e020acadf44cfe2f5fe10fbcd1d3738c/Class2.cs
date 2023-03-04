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
using SAITMCalculator;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Class2
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public AboutBox1 aboutBox1_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dialog1 dialog1_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form1 form1_0;

		public AboutBox1 AboutBox1
		{
			[DebuggerHidden]
			get
			{
				aboutBox1_0 = smethod_0(aboutBox1_0);
				return aboutBox1_0;
			}
			[DebuggerHidden]
			set
			{
				if (value != aboutBox1_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					method_0(ref aboutBox1_0);
				}
			}
		}

		public Dialog1 Dialog1
		{
			[DebuggerHidden]
			get
			{
				dialog1_0 = smethod_0(dialog1_0);
				return dialog1_0;
			}
			[DebuggerHidden]
			set
			{
				if (value != dialog1_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					method_0(ref dialog1_0);
				}
			}
		}

		public Form1 Form1
		{
			[DebuggerHidden]
			get
			{
				form1_0 = smethod_0(form1_0);
				return form1_0;
			}
			[DebuggerHidden]
			set
			{
				if (value != form1_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					method_0(ref form1_0);
				}
			}
		}

		[DebuggerHidden]
		private static W5TmI9RKuy2YnR9qhh smethod_0<W5TmI9RKuy2YnR9qhh>(W5TmI9RKuy2YnR9qhh dsG1ueqIhg7p5aXXCA) where W5TmI9RKuy2YnR9qhh : Form, new()
		{
			if (dsG1ueqIhg7p5aXXCA == null || ((Control)dsG1ueqIhg7p5aXXCA).get_IsDisposed())
			{
				if (hashtable_0 != null)
				{
					if (hashtable_0.ContainsKey(typeof(W5TmI9RKuy2YnR9qhh)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					hashtable_0 = new Hashtable();
				}
				hashtable_0.Add(typeof(W5TmI9RKuy2YnR9qhh), null);
				try
				{
					return new W5TmI9RKuy2YnR9qhh();
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
					hashtable_0.Remove(typeof(W5TmI9RKuy2YnR9qhh));
				}
			}
			return dsG1ueqIhg7p5aXXCA;
		}

		[DebuggerHidden]
		private void method_0<yqO4CY3hoihSMdEGOu>(ref yqO4CY3hoihSMdEGOu gparam_0) where yqO4CY3hoihSMdEGOu : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(yqO4CY3hoihSMdEGOu);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class3()
		{
			Class8.BpPkGHSz2q2OL();
			base._002Ector();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return typeof(Class3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class4
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type zSifrgrau()
		{
			return typeof(Class4);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static o7sZ8GpqB7YomrCBZw smethod_0<o7sZ8GpqB7YomrCBZw>(o7sZ8GpqB7YomrCBZw QVGwDdWmrvtsfVJSuG) where o7sZ8GpqB7YomrCBZw : new()
		{
			if (QVGwDdWmrvtsfVJSuG == null)
			{
				return new o7sZ8GpqB7YomrCBZw();
			}
			return QVGwDdWmrvtsfVJSuG;
		}

		[DebuggerHidden]
		private void method_0<z2SqAemxhraW9NmnHu>(ref z2SqAemxhraW9NmnHu gparam_0)
		{
			gparam_0 = default(z2SqAemxhraW9NmnHu);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
			Class8.BpPkGHSz2q2OL();
			base._002Ector();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class5<ynf0hW66KwDLHU5vq0> where ynf0hW66KwDLHU5vq0 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static ynf0hW66KwDLHU5vq0 gparam_0;

		[SpecialName]
		[DebuggerHidden]
		internal ynf0hW66KwDLHU5vq0 method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new ynf0hW66KwDLHU5vq0();
			}
			return gparam_0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class5()
		{
			Class8.BpPkGHSz2q2OL();
			base._002Ector();
		}
	}

	private static readonly Class5<Class1> class5_0;

	private static readonly Class5<Form0> rmUjrNopP;

	private static readonly Class5<User> class5_1;

	private static Class5<Class3> omJgyIvTW;

	private static readonly Class5<Class4> class5_2;

	[HelpKeyword("My.Computer")]
	internal static Class1 Class1_0
	{
		[DebuggerHidden]
		get
		{
			return class5_0.method_0();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			return rmUjrNopP.method_0();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return class5_1.method_0();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class3 Class3_0
	{
		[DebuggerHidden]
		get
		{
			return omJgyIvTW.method_0();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			return class5_2.method_0();
		}
	}

	static Class2()
	{
		Class8.BpPkGHSz2q2OL();
		class5_0 = new Class5<Class1>();
		rmUjrNopP = new Class5<Form0>();
		class5_1 = new Class5<User>();
		omJgyIvTW = new Class5<Class3>();
		class5_2 = new Class5<Class4>();
	}
}
