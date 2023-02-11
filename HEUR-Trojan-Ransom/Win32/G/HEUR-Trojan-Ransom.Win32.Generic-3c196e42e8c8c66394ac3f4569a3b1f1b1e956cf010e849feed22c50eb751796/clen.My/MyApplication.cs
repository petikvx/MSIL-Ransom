using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using ns0;

namespace clen.My;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class MyApplication : WindowsFormsApplicationBase
{
	private static List<WeakReference> list_0;

	[SecuritySafeCritical]
	static MyApplication()
	{
		Class6.smethod_1();
		list_0 = new List<WeakReference>();
	}

	private static void smethod_0(object object_0)
	{
		List<WeakReference> gparam_ = list_0;
		bool bool_ = false;
		checked
		{
			try
			{
				Class3.Class5.smethod_0((object)gparam_, ref bool_, (short)838, 855);
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference gparam_2 = (WeakReference)(ISerializable)list_0[num3];
						if (Class3.Class5.smethod_2(gparam_2, 'ʇ', 713))
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(Class6.smethod_2(object_0, '\u0015', 52)));
			}
			finally
			{
				if (bool_)
				{
					Class10.Class13.smethod_5((object)gparam_, 'Á', '\u0082');
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[STAThread]
	[SecuritySafeCritical]
	internal static void Main(string[] args)
	{
		Class6.smethod_1();
		try
		{
			Class3.smethod_7(WindowsFormsApplicationBase.get_UseCompatibleTextRendering(), 42, 'd');
		}
		finally
		{
		}
		Class3.smethod_8<WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)MyProject.MyApplication_0, args, (short)781, (short)839);
	}

	public MyApplication()
		: base((AuthenticationMode)0)
	{
		smethod_0(this);
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		Class3.Class5.smethod_3<WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)this, bool_0: true, '\u02f0', (short)644);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Class0_0.method_0());
	}
}
