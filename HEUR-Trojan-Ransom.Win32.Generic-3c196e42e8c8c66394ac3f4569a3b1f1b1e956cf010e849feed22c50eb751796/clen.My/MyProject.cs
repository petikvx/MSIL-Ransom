using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace clen.My;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class MyProject
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class0
	{
		public Form1 form1_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		[SpecialName]
		public Form1 method_0()
		{
			form1_0 = smethod_0(form1_0);
			return form1_0;
		}

		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			if ((gparam_0 == null || ((Control)gparam_0).get_IsDisposed()) ? true : false)
			{
				if (hashtable_0 != null)
				{
					if (Class6.Class7.smethod_3(hashtable_0, (object)typeof(T), 'ţ', 'ċ'))
					{
						throw new InvalidOperationException(Class6.Class7.smethod_4("WinForms_RecursiveFormCreate", new string[0], 'Ĳ', 379));
					}
				}
				else
				{
					hashtable_0 = new Hashtable();
				}
				Class6.Class8.smethod_1<Hashtable, object, object>(hashtable_0, typeof(T), null, 618, 612);
				try
				{
					return new T();
				}
				catch (TargetInvocationException gparam_) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					Class6.Class8.smethod_2((Exception)gparam_, 'ȏ', (short)559);
					return Class3.Class5.smethod_4((Exception)gparam_, 432, (short)494) != null;
				}).Invoke())
				{
					string message = (string)(IEnumerable)Class6.Class7.smethod_4("WinForms_SeeInnerException", new string[1] { Class3.smethod_11(Class3.Class5.smethod_4((Exception)gparam_, 671, (short)705), 725, 743) }, '\u0322', 875);
					throw new InvalidOperationException(message, Class10.Class13.smethod_8((Exception)gparam_, 'Ń', (short)322));
				}
				finally
				{
					Class17.smethod_11(hashtable_0, (object)typeof(T), 'Ǣ', (short)505);
				}
			}
			return gparam_0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class0()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(Class6.smethod_2(obj, 'ɝ', 636));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return (Type)(IReflect)typeof(Class0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)(ICloneable)base.ToString();
		}

		[SecuritySafeCritical]
		static Class0()
		{
			Class6.smethod_1();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class1
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(Class6.smethod_2(obj, 'Ȓ', 563));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class1);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)(IEquatable<string>)base.ToString();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class1()
		{
		}

		[SecuritySafeCritical]
		static Class1()
		{
			Class6.smethod_1();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class2<T> where T : new()
	{
		[ThreadStatic]
		private static T gparam_0;

		[SpecialName]
		internal T method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new T();
			}
			return gparam_0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class2()
		{
		}

		[SecuritySafeCritical]
		static Class2()
		{
			Class6.smethod_1();
		}
	}

	private static readonly Class2<MyComputer> class2_0;

	private static readonly Class2<MyApplication> class2_1;

	private static readonly Class2<User> class2_2;

	private static Class2<Class0> class2_3;

	private static readonly Class2<Class1> class2_4;

	[HelpKeyword("My.Computer")]
	internal static MyComputer MyComputer_0 => class2_0.method_0();

	[HelpKeyword("My.Application")]
	internal static MyApplication MyApplication_0 => class2_1.method_0();

	[HelpKeyword("My.User")]
	internal static User User_0 => class2_2.method_0();

	[HelpKeyword("My.Forms")]
	internal static Class0 Class0_0 => class2_3.method_0();

	[HelpKeyword("My.WebServices")]
	internal static Class1 Class1_0 => class2_4.method_0();

	[SecuritySafeCritical]
	static MyProject()
	{
		Class6.smethod_1();
		class2_0 = new Class2<MyComputer>();
		class2_1 = new Class2<MyApplication>();
		class2_2 = new Class2<User>();
		class2_3 = new Class2<Class0>();
		class2_4 = new Class2<Class1>();
	}
}
